using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.Core.Models
{
    /// <summary>
    /// Class to define Schema of the class structure
    /// </summary>
    public class ClassSchema
    {
        // TODO Namespace and Usings into csharp and java

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
        /// Accessebility of the class e.g. private
        /// </summary>
        [JsonPropertyName("accessebility")]
        public Accessebility Accessebility { get; set; }
    }
}
