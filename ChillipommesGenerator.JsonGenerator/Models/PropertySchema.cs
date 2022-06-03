using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    /// <summary>
    /// Class to define the schema of a property entry in JSON Schema
    /// </summary>
    internal class PropertySchema
    {
        /// <summary>
        /// Name of the property
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Type of the property
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Short description of the property
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Accessebility of the property e.g. public
        /// </summary>
        [JsonPropertyName("accessebility")]
        public Accessebility Accessebility { get; set; }

        /// <summary>
        /// Minimal value which can be assigned
        /// </summary>
        [JsonPropertyName("minValue")]
        public double MinValue { get; set; }

        /// <summary>
        /// Maximum value which can be assigned
        /// </summary>
        [JsonPropertyName("maxValue")]
        public double MaxValue { get; set; }

        /// <summary>
        /// Determines if the property is static
        /// </summary>
        [JsonPropertyName("static")]
        public bool Static { get; set; }

        /// <summary>
        /// Determines if the property is required
        /// </summary>
        [JsonPropertyName("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Determines if the property can be null
        /// </summary>
        [JsonPropertyName("nullable")]
        public bool Nullable { get; set; }
    }
}
