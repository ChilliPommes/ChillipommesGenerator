using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    internal class CSharpSchema
    {
        [JsonPropertyName("sealed")]
        public bool Sealed { get; set; }

        [JsonPropertyName("static")]
        public bool Static { get; set; }

        [JsonPropertyName("inheritFromClass")]
        public string InheritFromClass { get; set; } = string.Empty;

        [JsonPropertyName("inheritFromInterfaces")]
        public string[] InheritFromInterfaces { get; set; } = Array.Empty<string>();
    }
}
