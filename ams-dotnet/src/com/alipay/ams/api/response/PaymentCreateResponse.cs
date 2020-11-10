using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentCreateResponse : AMSResponse
    {

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("paymentAmount")]
        public Amount PaymentAmount { get; set; }

        [JsonPropertyNameAttribute("clientPaymentToken")]
        public string ClientPaymentToken { get; set; }

        [JsonPropertyNameAttribute("redirectActionForm")]
        public RedirectActionForm RedirectActionForm { get; set; }


    }
}