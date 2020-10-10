using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class PspCustomerInfo
    {
        public PspCustomerInfo() { }

        [JsonPropertyNameAttribute("displayCustomerId")]
        public string DisplayCustomerId { get; set; }

        [JsonPropertyNameAttribute("pspCustomerId")]
        public string PspCustomerId { get; set; }

        [JsonPropertyNameAttribute("pspName")]
        public string PspName { get; set; }


    }
}
