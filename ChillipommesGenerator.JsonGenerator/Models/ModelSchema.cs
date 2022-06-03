using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    /// <summary>
    /// Inherits BaseSchema class to impl. based structures of JSON Schema.
    /// This class adds additional information about the object used for the source generation.
    /// </summary>
    internal class ModelSchema : BaseSchema
    {
        /// <summary>
        /// Class as ClassSchema to define the strucuter of the unlaying class
        /// </summary>
        [JsonPropertyName("class")]
        public ClassSchema? Class { get; set; }

        /// <summary>
        /// C-Sharp specific values which define the layout or values
        /// </summary>
        [JsonPropertyName("cSharp")]
        public CSharpSchema? CSharp { get; set; }

        /// <summary>
        /// KeyValue List of string (prop name) and <see cref="PropertySchema"/> to display all properties
        /// </summary>
        [JsonPropertyName("properties")]
        public List<PropertySchema>? Properties { get; set; }

        /// <summary>
        /// List of properties which are set as required
        /// </summary>
        [JsonPropertyName("required")]
        public List<string>? Required { get; set; }
    }
}
