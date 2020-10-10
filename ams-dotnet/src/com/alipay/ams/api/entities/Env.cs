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
    }
}
