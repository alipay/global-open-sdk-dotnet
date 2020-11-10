using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Env
    {
        public Env()
        {
        }

        [JsonPropertyNameAttribute("storeTerminalId")]
        public string StoreTerminalId { get; internal set; }

        [JsonPropertyNameAttribute("storeTerminalRequestTime")]
        public string StoreTerminalRequestTime { get; internal set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyNameAttribute("terminalType")]
        public TerminalType TerminalType { get; set; }

        [JsonPropertyNameAttribute("userAgent")]
        public string UserAgent { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyNameAttribute("osType")]
        public OsType OsType { get; set; }

        [JsonPropertyNameAttribute("deviceTokenId")]
        public string DeviceTokenId { get; set; }

        [JsonPropertyNameAttribute("clientIp")]
        public string ClientIp { get; set; }

        [JsonPropertyNameAttribute("cookieId")]
        public string CookieId { get; set; }

        [JsonPropertyNameAttribute("extendInfo")]
        public string ExtendInfo { get; set; }
    }
}
