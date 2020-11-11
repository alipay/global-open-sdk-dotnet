using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentCancelRequest : AMSRequest<PaymentCancelResponse>
    {

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/cancel";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
        }
    }
}
