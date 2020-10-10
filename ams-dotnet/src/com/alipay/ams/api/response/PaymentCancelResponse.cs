using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentCancelResponse : AMSResponse
    {

        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("cancelTime")]
        public string CancelTime { get; set; }

    }
}