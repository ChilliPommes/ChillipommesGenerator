using ChillipommesGenerator.Core.Enums;
using ChillipommesGenerator.Core.Models;
using ChillipommesGenerator.JsonGenerator.Helper;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChillipommesGenerator.JsonGenerator.Converter
{
    internal class PropertySchemaJsonConverter : JsonConverter<PropertySchema>
    {
        public override PropertySchema? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            return JsonSerializer.Deserialize<PropertySchema>(ref reader);
        }

        public override void Write(Utf8JsonWriter writer, PropertySchema value, JsonSerializerOptions options)
        {
            // Lower first char to make title camel case if not
            string propertyName = value.Title[0].ToString().ToLower() + value.Title.Substring(1);
            writer.WritePropertyName(propertyName);
            
            writer.WriteStartObject();

            var properties = value.GetType().GetProperties();
            foreach(var property in properties)
            {
                var propName = property.GetCustomAttributes(false).FirstOrDefault(x => x.GetType() == typeof(JsonPropertyNameAttribute));

                if (propName != null)
                {
                    writer.WritePropertyName((propName as JsonPropertyNameAttribute)!.Name);
                }
                else
                {
                    writer.WritePropertyName(property.Name);
                }

                if (property.GetValue(value)!.IsNumericType())
                {
                    switch (Type.GetTypeCode(property.GetValue(value)!.GetType()))
                    {
                        case TypeCode.Byte:
                            writer.WriteNumberValue((byte)property.GetValue(value)!);
                            break;
                        case TypeCode.SByte:
                            writer.WriteNumberValue((sbyte)property.GetValue(value)!);
                            break;
                        case TypeCode.UInt16:
                            writer.WriteNumberValue((ushort)property.GetValue(value)!);
                            break;
                        case TypeCode.UInt32:
                            writer.WriteNumberValue((uint)property.GetValue(value)!);
                            break;
                        case TypeCode.UInt64:
                            writer.WriteNumberValue((ulong)property.GetValue(value)!);
                            break;
                        case TypeCode.Int16:
                            writer.WriteNumberValue((short)property.GetValue(value)!);
                            break;
                        case TypeCode.Int32:
                            writer.WriteNumberValue((int)property.GetValue(value)!);
                            break;
                        case TypeCode.Int64:
                            writer.WriteNumberValue((long)property.GetValue(value)!);
                            break;
                        case TypeCode.Decimal:
                            writer.WriteNumberValue((decimal)property.GetValue(value)!);
                            break;
                        case TypeCode.Double:
                            writer.WriteNumberValue((double)property.GetValue(value)!);
                            break;
                        case TypeCode.Single:
                            writer.WriteNumberValue((float)property.GetValue(value)!);
                            break;
                    }
                }
                else if (Type.GetTypeCode(property.GetValue(value)!.GetType()) == TypeCode.Boolean)
                {
                    writer.WriteBooleanValue((bool)property.GetValue(value)!);
                }
                else if (property.GetValue(value)!.GetType() == typeof(Accessebility))
                {
                    writer.WriteNumberValue((int)property.GetValue(value)!);
                }
                else if (property.GetValue(value)!.GetType().IsGenericType && (property.GetValue(value)!.GetType().GetGenericTypeDefinition() == typeof(List<>)))
                {
                    writer.WriteRawValue(JsonSerializer.Serialize(property.GetValue(value)));
                }
                else
                {
                    writer.WriteStringValue((string)property.GetValue(value)!);
                }
                
            }

            writer.WriteEndObject();
        }
    }
}
