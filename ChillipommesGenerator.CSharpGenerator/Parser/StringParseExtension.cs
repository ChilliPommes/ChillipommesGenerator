using ChillipommesGenerator.Core.Enums;
using ChillipommesGenerator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChillipommesGenerator.CSharpGenerator.Parser
{
    internal static class StringParseExtension
    {
        public static string ParseBascisc(this string value, ModelSchema modelSchema)
        {
            var classNameWithIherits = modelSchema.Class.Title +
                (string.IsNullOrEmpty(modelSchema.CSharp.InheritFromClass) ? "" : " : " + modelSchema.CSharp.InheritFromClass);

            classNameWithIherits = classNameWithIherits + (modelSchema.CSharp.InheritFromInterfaces.Length == 0 ? "" : ", " + string.Join(",", modelSchema.CSharp.InheritFromInterfaces));

            var accessebility = modelSchema.Class.Accessebility switch
            {
                Accessebility.Public => "public",
                Accessebility.Private => "private",
                Accessebility.Protected => "protected"
            };

            if (modelSchema.CSharp.Static)
            {
                accessebility += " static";
            }
            else if (modelSchema.CSharp.Sealed)
            {
                accessebility += " sealed";
            }

            // TODO add specials like static or sealed

            return value
                .Replace("{{ClassName}}", classNameWithIherits)
                .Replace("{{Usings}}", string.Join(";\n", modelSchema.CSharp.Usings) + ";")
                .Replace("{{Namespace}}", modelSchema.CSharp.NameSpace)
                .Replace("{{ClassVisibility}}", accessebility);
        }

        public static string ParseProperties(this string value, ModelSchema modelSchema)
        {
            string properties = "";

            for(int i = 0; i < modelSchema.Properties.Count(); i++)
            {
                // TODO special things like sealed etc
                properties = properties + value.Replace("{{PropertyVisibillity}}", modelSchema.Properties[i].Accessebility switch
                {
                    Accessebility.Public => "public",
                    Accessebility.Private => "private",
                    Accessebility.Protected => "protected"
                })
                    .Replace("{{PropertyType}}", modelSchema.Properties[i].Type)
                    .Replace("{{PropertyName}}", modelSchema.Properties[i].Title) 
                    + (i == modelSchema.Properties.Count() - 1 ? "" : "\n\n");
            }

            return properties;
        }
    }
}
