using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class SettlementStrategy
    {
        [JsonPropertyNameAttribute("settlementCurrency")]
        public String SettlementCurrency { get; set; }
    }
}
