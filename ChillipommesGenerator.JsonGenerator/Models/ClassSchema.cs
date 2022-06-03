using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    internal class ClassSchema
    {
        /// <summary>
        /// Inherits the class name of the projected class
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nameSpace")]
        public string NameSpace { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("usings")]
        public string[] Usings { get; set; } = Array.Empty<string>();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("")]
        public Accessebility Accessebility { get; set; }
    }
}
