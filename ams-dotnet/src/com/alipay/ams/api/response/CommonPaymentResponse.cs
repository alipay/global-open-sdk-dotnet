using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class CommonPaymentResponse : AMSResponse
    {

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyNameAttribute("paymentAmount")]
        public Amount PaymentAmount { get; set; }

        [JsonPropertyNameAttribute("actualPaymentAmount")]
        public Amount ActualPaymentAmount { get; set; }

        [JsonPropertyNameAttribute("paymentQuote")]
        public Quote PaymentQuote { get; set; }

        [JsonPropertyNameAttribute("paymentTime")]
        public string PaymentTime { get; set; }

        [JsonPropertyNameAttribute("paymentCreateTime")]
        public string PaymentCreateTime { get; set; }

        [JsonPropertyNameAttribute("authExpiryTime")]
        public string AuthExpiryTime { get; set; }

        [JsonPropertyNameAttribute("nonGuaranteeCouponValue")]
        public Amount NonGuaranteeCouponValue { get; set; }

        [JsonPropertyNameAttribute("paymentActionForm")]
        public string PaymentActionForm { get; set; }

        [JsonPropertyNameAttribute("pspCustomerInfo")]
        public PspCustomerInfo PspCustomerInfo { get; set; }

        [JsonPropertyNameAttribute("challengeActionForm")]
        public ChallengeActionForm ChallengeActionForm { get; set; }

        [JsonPropertyNameAttribute("redirectActionForm")]
        public RedirectActionForm RedirectActionForm { get; set; }

        [JsonPropertyNameAttribute("orderCodeForm")]
        public OrderCodeForm OrderCodeForm { get; set; }

        [JsonPropertyNameAttribute("extendInfo")]
        public string ExtendInfo { get; set; }


    }
}