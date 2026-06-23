namespace com.alipay.ams.util;

using System;
using Newtonsoft.Json;

public class SafeEnumConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        var type = Nullable.GetUnderlyingType(objectType) ?? objectType;
        return type.IsEnum;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return Nullable.GetUnderlyingType(objectType) != null ? null : Activator.CreateInstance(Nullable.GetUnderlyingType(objectType) ?? objectType);

        var type = Nullable.GetUnderlyingType(objectType) ?? objectType;

        if (reader.TokenType == JsonToken.String)
        {
            var value = reader.Value.ToString();
            if (Enum.TryParse(type, value, true, out var result))
                return result;
        }
        else if (reader.TokenType == JsonToken.Integer)
        {
            int intValue = Convert.ToInt32(reader.Value);
            if (Enum.IsDefined(type, intValue))
                return Enum.ToObject(type, intValue);
        }

        return Nullable.GetUnderlyingType(objectType) != null ? null : Activator.CreateInstance(type);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value == null)
        {
            writer.WriteNull();
            return;
        }
        writer.WriteValue(value.ToString());
    }
}
