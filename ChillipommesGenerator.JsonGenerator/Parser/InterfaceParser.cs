﻿using ChillipommesGenerator.Core.Enums;
using ChillipommesGenerator.JsonGenerator.Models;
using System.Text.Json;

namespace ChillipommesGenerator.JsonGenerator.Parser
{
    public sealed class InterfaceParser : BaseParser
    {
        /// <summary>
        /// Parses an C# Interface to the generator valid json format
        /// </summary>
        /// <param name="fileName">Full qualified filename of the interface to parse</param>
        /// <returns>Generator valid json string</returns>
        public string Parse(string fileName)
        {
            var filePayload = LoadFile(fileName);

            var baseStructure = new BaseStructure();

            // Area of usings
            baseStructure.Usings = ParseUsings(filePayload);

            // Area of Namespace
            baseStructure.NameSpace = ParseNameSpace(filePayload);

            // Area of Accessebility
            baseStructure.Accessebility = ParseClassAccessebility(filePayload);

            // Area of Class Name
            baseStructure.ClassName = ParseClassName(filePayload);

            // Area of Properties
            baseStructure.Properties = ParseProperties(filePayload);

            return JsonSerializer.Serialize(baseStructure);
        }

        private string[] ParseUsings(string payload)
        {
            List<string> usings = new List<string>();

            var endOfUsings = payload.IndexOf("namespace");
            var substring = payload.Substring(0, endOfUsings).Replace("\r", "").Replace("\n","");

            var fullUsings = substring.Split(";");

            foreach(var fullUsing in fullUsings.Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)))
            {
                var splittedUsing = fullUsing.Split(" ");
                usings.Add(splittedUsing[1]);
            }

            return usings.ToArray();
        }

        private string ParseNameSpace(string payload)
        {
            var beginOfNamespace = payload.IndexOf("namespace") + "namespace".Length;
            var endOfNamespace = payload.IndexOf("{");

            return payload.Substring(beginOfNamespace, endOfNamespace - beginOfNamespace).Replace("\r", "").Replace("\n", "").Trim();
        }

        private Accessebility ParseClassAccessebility(string payload)
        {
            var beginOfClass = payload.IndexOf("{") + 1;
            
            var substring = payload.Substring(beginOfClass);
            var beginOfProps = substring.IndexOf("{");

            var classString = substring.Substring(0, beginOfProps).Replace("\r", "").Replace("\n", "").Trim();

            switch(classString.Split(" ")[0])
            {
                case "private": return Accessebility.Private;
                case "protected": return Accessebility.Protected;
                case "public":
                default: return Accessebility.Public;
            }
        }

        private string ParseClassName(string payload)
        {
            var beginOfClass = payload.IndexOf("{") + 1;

            var substring = payload.Substring(beginOfClass);
            var beginOfProps = substring.IndexOf("{");

            var classString = substring.Substring(0, beginOfProps).Replace("\r", "").Replace("\n", "").Trim();
            var interfaceName = classString.Split(" ").Last();

            return interfaceName.Substring(1, interfaceName.Length - 1);
        }

        private PropertyStructure[] ParseProperties(string payload)
        {
            List<PropertyStructure> propertyStructures = new List<PropertyStructure>();

            var beginOfClass = payload.IndexOf("{") + 1;

            var substring = payload.Substring(beginOfClass).Replace("\r", "").Replace("\n", "");
            var beginOfProps = substring.IndexOf("{") + 1;
            var endOfProps = substring.LastIndexOf("}}");

            var propSubstring = substring.Substring(beginOfProps, endOfProps - beginOfProps).Trim();

            var fullProps = propSubstring.Split("}");

            foreach(var fullProp in fullProps.Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)))
            {
                var propertyStructure = new PropertyStructure();
                var propParts = fullProp.Substring(0, fullProp.IndexOf("{")).Split(" ").Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)).ToArray();

                propertyStructure.Accessebility = propParts[0] switch
                {
                    "private" => Accessebility.Private,
                    "protected" => Accessebility.Protected,
                    "public" => Accessebility.Public,
                    _ => Accessebility.Public,
                };

                propertyStructure.PropertyName = propParts.Last();

                propertyStructure.PropertyType = propParts.Length == 3 ? propParts[1] : propParts[propParts.Length - 2];

                propertyStructure.Static = propParts.Any(x => x.Equals("static", StringComparison.OrdinalIgnoreCase));

                propertyStructures.Add(propertyStructure);
            }

            return propertyStructures.ToArray();
        }
    }
}
