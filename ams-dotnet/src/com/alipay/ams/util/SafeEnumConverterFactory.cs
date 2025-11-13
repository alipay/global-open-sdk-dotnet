namespace com.alipay.ams.util;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class SafeEnumConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        var type = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
        return type.IsEnum;
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var underlyingType = Nullable.GetUnderlyingType(typeToConvert);
        var converterType = underlyingType == null
            ? typeof(SafeEnumConverterInner<>).MakeGenericType(typeToConvert)
            : typeof(SafeNullableEnumConverterInner<>).MakeGenericType(underlyingType);

        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }

    private class SafeEnumConverterInner<T> : JsonConverter<T> where T : struct, Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    var value = reader.GetString();
                    if (Enum.TryParse<T>(value, true, out var result))
                        return result;
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    int intValue = reader.GetInt32();
                    if (Enum.IsDefined(typeof(T), intValue))
                        return (T)Enum.ToObject(typeof(T), intValue);
                }
            }
            catch { }

            return default; // 非可空枚举 → 返回默认值
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

    private class SafeNullableEnumConverterInner<T> : JsonConverter<T?> where T : struct, Enum
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    var value = reader.GetString();
                    if (Enum.TryParse<T>(value, true, out var result))
                        return result;
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    int intValue = reader.GetInt32();
                    if (Enum.IsDefined(typeof(T), intValue))
                        return (T)Enum.ToObject(typeof(T), intValue);
                }
            }
            catch { }

            return null; // 可空枚举 → 返回 null
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value.ToString());
            else
                writer.WriteNullValue();
        }
    }
}
