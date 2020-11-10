using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class OrderCodeForm
    {
        [JsonPropertyNameAttribute("paymentMethodType")]
        public String PaymentMethodType { get; set; }

        [JsonPropertyNameAttribute("expireTime")]
        public String ExpireTime { get; set; }

        [JsonPropertyNameAttribute("codeDetails")]
        public List<CodeDetail> CodeDetails { get; set; }

        [JsonPropertyNameAttribute("extendInfo")]
        public String ExtendInfo { get; set; }
    }
}
