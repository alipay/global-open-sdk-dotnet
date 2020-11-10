using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class RedirectActionForm
    {
        [JsonPropertyNameAttribute("method")]
        public String Method { get; set; }
        [JsonPropertyNameAttribute("parameters")]
        public String Parameters { get; set; }
        [JsonPropertyNameAttribute("redirectUrl")]
        public String RedirectUrl { get; set; }
    }
}
