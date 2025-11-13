using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.util
{
    public class JsonSerializerOptionsFactory
    {

        public static JsonSerializerOptions WriteIndented = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            WriteIndented = true
        };

        public static JsonSerializerOptions WriteNotIndented = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = false,
            WriteIndented = false,
            Converters = {  new SafeEnumConverterFactory() }
        };

        static JsonSerializerOptionsFactory()
        {
            WriteIndented.Converters.Add(new JsonStringEnumConverter());
            WriteNotIndented.Converters.Add(new JsonStringEnumConverter());
        }
    }
}
