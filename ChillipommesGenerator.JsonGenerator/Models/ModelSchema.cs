using ChillipommesGenerator.Core.Enums;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    /// <summary>
    /// Inherits BaseSchema class to impl. based structures of JSON Schema.
    /// This class adds additional information about the object used for the source generation.
    /// </summary>
    internal class ModelSchema : BaseSchema
    {
        [JsonPropertyName("class")]
        public ClassSchema? Class { get; set; }

        [JsonPropertyName("cSharp")]
        public CSharpSchema? CSharp { get; set; }
    }
}
