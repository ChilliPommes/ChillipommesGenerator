using System.Text.Json.Serialization;

namespace ChillipommesGenerator.Core.Models
{
    public class BaseSchema
    {
        /// <summary>
        /// Schema on which the JSON structure is based
        /// </summary>
        [JsonPropertyName("$schema")]
        public string Schema => "https://json-schema.org/draft/2020-12/schema";

        /// <summary>
        /// Id of the file
        /// {host} and {name} should be replaced by correct domain and name of the file
        /// </summary>
        [JsonPropertyName("$id")]
        public string Id { get; set; } = "https://{host}/{name}.schema.json";

        /// <summary>
        /// Descriptive title e.g. ClassName
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Short description of the file and its content
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Type of the schema, default should be object
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "object";
    }
}
