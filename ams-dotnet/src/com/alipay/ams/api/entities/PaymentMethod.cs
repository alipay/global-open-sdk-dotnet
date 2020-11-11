using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class PaymentMethod
    {
        public PaymentMethod(String paymentMethodType)
        {
            this.PaymentMethodType = paymentMethodType;
        }

        [JsonPropertyNameAttribute("paymentMethodType")]
        public String PaymentMethodType { get; set; }
        [JsonPropertyNameAttribute("paymentMethodId")]
        public String PaymentMethodId { get; set; }
        [JsonPropertyNameAttribute("paymentMethodMetaData")]
        public String PaymentMethodMetaData { get; set; }
        [JsonPropertyNameAttribute("customerId")]
        public String CustomerId { get; set; }
    }
}
