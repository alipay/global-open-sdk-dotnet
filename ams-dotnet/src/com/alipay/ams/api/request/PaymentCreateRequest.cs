using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentCreateRequest : AMSRequest<PaymentCreateResponse>
    {

        [JsonPropertyNameAttribute("productCode")]
        public string ProductCodeType { get; set; }

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("order")]
        public Order Order { get; set; }

        [JsonPropertyNameAttribute("paymentAmount")]
        public Amount PaymentAmount { get; set; }

        [JsonPropertyNameAttribute("paymentRedirectUrl")]
        public string PaymentRedirectUrl { get; set; }

        [JsonPropertyNameAttribute("paymentNotifyUrl")]
        public string PaymentNotifyUrl { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/create";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(ProductCodeType, "productCodeType required.");
            Asserts.NotNull(PaymentAmount, "paymentAmount required.");
            Asserts.NotNull(Order, "order required.");
            Asserts.NotNull(PaymentRedirectUrl, "paymentRedirectUrl required.");
            Asserts.NotNull(PaymentNotifyUrl, "paymentNotifyUrl required.");
        }
    }
}
