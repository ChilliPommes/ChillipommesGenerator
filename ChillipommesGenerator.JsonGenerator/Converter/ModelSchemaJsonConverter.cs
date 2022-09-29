using ChillipommesGenerator.Core.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Converter
{
    internal class ModelSchemaJsonConverter : JsonConverter<ModelSchema>
    {
        private string lastPropName = "";

        public override ModelSchema? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            reader.Read();

            ModelSchema? result = new ModelSchema();

            do
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    lastPropName = Encoding.UTF8.GetString(reader.ValueSpan);
                }
                else
                {
                    var deserializeOptions = new JsonSerializerOptions
                    {
                        Converters =
                        {
                            new PropertySchemaJsonConverter(),
                            new PropertySchemaListJsonConverter()
                        }
                    };

                    switch (lastPropName.ToLower())
                    {
                        case "required":
                            var list = JsonSerializer.Deserialize<List<string>>(ref reader);
                            result!.Required = list;
                            break;
                        case "class":
                            var cla = JsonSerializer.Deserialize<ClassSchema>(ref reader);
                            result!.Class = cla;
                            break;
                        case "csharp":
                            var csharp = JsonSerializer.Deserialize<CSharpSchema>(ref reader);
                            result!.CSharp = csharp;
                            break;
                        case "properties":
                            var props = JsonSerializer.Deserialize<List<PropertySchema>>(ref reader, deserializeOptions);
                            result!.Properties = props;
                            break;
                        case "$id":
                            var id = Encoding.UTF8.GetString(reader.ValueSpan);
                            result!.Id = id ?? "";
                            break;
                        case "title":
                            var title = Encoding.UTF8.GetString(reader.ValueSpan);
                            result!.Title = title ?? "";
                            break;
                        case "description":
                            var desc = Encoding.UTF8.GetString(reader.ValueSpan);
                            result!.Description = desc ?? "";
                            break;
                        case "type":
                            var type = Encoding.UTF8.GetString(reader.ValueSpan);
                            result!.Type = type ?? "";
                            break;
                    }
                }
            } while (reader.Read());

            if (reader.IsFinalBlock)
            {
                var couldSkip = reader.TrySkip();
            }
            else
            {
                throw new JsonException("Expected end of file but wasn't");
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, ModelSchema value, JsonSerializerOptions options)
        {
            var properties = value.GetType().GetProperties();

            writer.WriteStartObject();

            foreach (var prop in properties)
            {
                var propName = prop.GetCustomAttributes(false).FirstOrDefault(x => x.GetType() == typeof(JsonPropertyNameAttribute));

                if (propName != null)
                {
                    writer.WritePropertyName((propName as JsonPropertyNameAttribute)!.Name);
                }
                else
                {
                    writer.WritePropertyName(prop.Name);
                }

                var serializeOptions = new JsonSerializerOptions();

                switch (prop.Name)
                {
                    case "Required":
                    case "Class":
                    case "CSharp":
                    case "Properties":
                        serializeOptions = new JsonSerializerOptions
                        {
                            Converters =
                            {
                                new PropertySchemaListJsonConverter(),
                                new PropertySchemaJsonConverter()
                            }
                        };

                        var val = prop.GetValue(value);

                        var json = JsonSerializer.Serialize(val, serializeOptions);

                        writer.WriteRawValue(json, true);
                        break;
                    default:
                        writer.WriteStringValue(prop.GetValue(value) as string);
                        break;
                }
            }

            writer.WriteEndObject();
        }
    }
}
