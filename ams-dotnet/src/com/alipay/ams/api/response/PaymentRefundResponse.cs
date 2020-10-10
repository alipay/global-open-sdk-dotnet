using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentRefundResponse : AMSResponse
    {

        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("refundId")]
        public string RefundId { get; set; }

        [JsonPropertyNameAttribute("refundRequestId")]
        public string RefundRequestId { get; set; }

        [JsonPropertyNameAttribute("refundAmount")]
        public Amount RefundAmount { get; set; }

        [JsonPropertyNameAttribute("refundTime")]
        public string RefundTime { get; set; }

        [JsonPropertyNameAttribute("isAsyncRefund")]
        public bool IsAsyncRefund { get; set; }

        [JsonPropertyNameAttribute("grossSettlementAmount")]
        public Amount GrossSettlementAmount { get; set; }

        [JsonPropertyNameAttribute("settlementQuote")]
        public Quote SettlementQuote { get; set; }

    }
}