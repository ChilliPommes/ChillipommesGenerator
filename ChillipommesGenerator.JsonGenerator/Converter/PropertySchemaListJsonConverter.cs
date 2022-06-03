using ChillipommesGenerator.JsonGenerator.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Converter
{
    internal class PropertySchemaListJsonConverter : JsonConverter<List<PropertySchema>>
    {
        public override List<PropertySchema>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, List<PropertySchema> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach(var val in value)
            {
                var serializeOptions = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters =
                    {
                        new PropertySchemaJsonConverter()
                    }
                };

                var json = JsonSerializer.Serialize(val, serializeOptions);

                writer.WriteRawValue(json, true);
            }

            writer.WriteEndObject();
        }
    }
}
