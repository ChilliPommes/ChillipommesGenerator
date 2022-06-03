using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    /// <summary>
    /// Class to define Schema of the class structure
    /// </summary>
    internal class ClassSchema
    {
        /// <summary>
        /// Inherits the class name of the projected class
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Short description of the class and its usage
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

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

        /// <summary>
        /// Accessebility of the class e.g. private
        /// </summary>
        [JsonPropertyName("accessebility")]
        public Accessebility Accessebility { get; set; }
    }
}
