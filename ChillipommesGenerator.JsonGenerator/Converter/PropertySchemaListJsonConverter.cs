using ChillipommesGenerator.JsonGenerator.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Converter
{
    internal class PropertySchemaListJsonConverter : JsonConverter<List<PropertySchema>>
    {
        public override List<PropertySchema>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var resultList = new List<PropertySchema>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                    return resultList;

                var deserializeOptions = new JsonSerializerOptions
                {
                    Converters =
                    {
                        new PropertySchemaJsonConverter()
                    }
                };

                var schema = JsonSerializer.Deserialize<PropertySchema>(ref reader, deserializeOptions);

                if (schema != null)
                {
                    resultList.Add(schema);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, List<PropertySchema> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach(var val in value)
            {
                var serializeOptions = new JsonSerializerOptions
                {
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
