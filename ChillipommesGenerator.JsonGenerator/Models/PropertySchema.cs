using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    internal class PropertySchema
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("accessebility")]
        public Accessebility Accessebility { get; set; }

        [JsonPropertyName("static")]
        public bool Static { get; set; }
    }
}
