using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentRefundRequest : AMSRequest<PaymentRefundResponse>
    {
        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("refundRequestId")]
        public string RefundRequestId { get; set; }

        [JsonPropertyNameAttribute("referenceRefundId")]
        public string ReferenceRefundId { get; set; }

        [JsonPropertyNameAttribute("refundAmount")]
        public Amount RefundAmount { get; set; }

        [JsonPropertyNameAttribute("refundReason")]
        public string RefundReason { get; set; }

        [JsonPropertyNameAttribute("refundRequestTime")]
        public string RefundRequestTime { get; set; }

        [JsonPropertyNameAttribute("isAsyncRefund")]
        public bool IsAsyncRefund { get; set; }




        public override string BuildBody()
        {

            validate();

            return JsonSerializer.Serialize(this);
        }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/refund";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentId, "paymentId required.");
            Asserts.NotNull(RefundRequestId, "refundRequestId required.");
            Asserts.NotNull(RefundAmount, "refundAmount required.");
            Asserts.NotNull(RefundRequestTime, "refundRequestTime required.");
        }
    }
}
