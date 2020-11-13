using System.Text.Json;
using System.Text.Json.Serialization;

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
            IgnoreNullValues = true,
            WriteIndented = false
        };

        static JsonSerializerOptionsFactory()
        {
            WriteIndented.Converters.Add(new JsonStringEnumConverter());
            WriteNotIndented.Converters.Add(new JsonStringEnumConverter());
        }
    }
}
