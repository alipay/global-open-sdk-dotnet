using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class PaymentFactor
    {
        [JsonPropertyNameAttribute("isPaymentEvaluation")]
        public Boolean IsPaymentEvaluation { get; set; }

        [JsonPropertyNameAttribute("inStorePaymentScenario")]
        public InStorePaymentScenario InStorePaymentScenario { get; set; }
    }
}
