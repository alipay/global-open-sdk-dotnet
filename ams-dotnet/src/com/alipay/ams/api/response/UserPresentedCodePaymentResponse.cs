using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class UserPresentedCodePaymentResponse : AMSResponse
    {

        [JsonPropertyNameAttribute("actualPaymentAmount")]
        public Amount ActualPaymentAmount { get; set; }

        [JsonPropertyNameAttribute("paymentAmount")]
        public Amount PaymentAmount { get; set; }

        [JsonPropertyNameAttribute("paymentCreateTime")]
        public string PaymentCreateTime { get; set; }

        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("paymentQuote")]
        public Quote PaymentQuote { get; set; }

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("paymentTime")]
        public string PaymentTime { get; set; }

        [JsonPropertyNameAttribute("pspCustomerInfo")]
        public PspCustomerInfo PspCustomerInfo { get; set; }

    }
}