using System.Text.Json.Serialization;

namespace ChillipommesGenerator.Core.Models
{
    /// <summary>
    /// Class to define the Schema for C-Sharp specific data properties and layouts
    /// </summary>
    public class CSharpSchema
    {
        /// <summary>
        /// Determines if the class is sealed
        /// </summary>
        [JsonPropertyName("sealed")]
        public bool Sealed { get; set; }

        /// <summary>
        /// Detemrines if the class is static
        /// </summary>
        [JsonPropertyName("static")]
        public bool Static { get; set; }

        /// <summary>
        /// The base class from which it should inherit 
        /// </summary>
        [JsonPropertyName("inheritFromClass")]
        public string InheritFromClass { get; set; } = string.Empty;

        /// <summary>
        /// The interfaces from which it should inherit
        /// </summary>
        [JsonPropertyName("inheritFromInterfaces")]
        public string[] InheritFromInterfaces { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Namespace used by the class
        /// </summary>
        [JsonPropertyName("nameSpace")]
        public string NameSpace { get; set; } = string.Empty;

        /// <summary>
        /// Imports / Usings of the class
        /// </summary>
        [JsonPropertyName("usings")]
        public string[] Usings { get; set; } = Array.Empty<string>();
    }
}
