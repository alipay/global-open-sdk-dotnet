using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace com.alipay.ams.api.entities
{
    /// <summary>Preserves the existing Buyer property while supporting the consult wire subtype.</summary>
    public sealed class ConsultBuyerJsonConverter : JsonConverter<Buyer>
    {
        public static Type WireType { get { return typeof(ConsultBuyer); } }
        public override Buyer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;
            return JsonSerializer.Deserialize<ConsultBuyer>(ref reader, options);
        }
        public override void Write(Utf8JsonWriter writer, Buyer value, JsonSerializerOptions options)
        {
            if (value == null) { writer.WriteNullValue(); return; }
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
