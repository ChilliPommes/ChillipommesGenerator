using ChillipommesGenerator.JsonGenerator.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Converter
{
    internal class PropertySchemaJsonConverter : JsonConverter<PropertySchema>
    {
        public override PropertySchema? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, PropertySchema value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
