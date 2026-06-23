using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace com.alipay.ams.util
{
    public class JsonSerializerOptionsFactory
    {

        public static readonly JsonSerializerSettings WriteIndented = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        };

        public static readonly JsonSerializerSettings WriteNotIndented = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Include,
            Formatting = Formatting.None,
            Converters = { new SafeEnumConverter() }
        };

        static JsonSerializerOptionsFactory()
        {
            WriteIndented.Converters.Add(new StringEnumConverter());
            WriteNotIndented.Converters.Add(new StringEnumConverter());
        }
    }
}
