using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class CommonPaymentRequest : AMSRequest<CommonPaymentResponse>
    {
        [JsonPropertyNameAttribute("productCode")]
        public ProductCodeType ProductCodeType { get; set; }

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }

        [JsonPropertyNameAttribute("order")]
        public Order Order { get; set; }

        [JsonPropertyNameAttribute("paymentAmount")]
        public Amount PaymentAmount { get; set; }

        [JsonPropertyNameAttribute("payToMethod")]
        public PaymentMethod PayToMethod { get; set; }

        [JsonPropertyNameAttribute("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonPropertyNameAttribute("paymentExpiryTime")]
        public string PaymentExpiryTime { get; set; }

        [JsonPropertyNameAttribute("paymentRedirectUrl")]
        public string PaymentRedirectUrl { get; set; }

        [JsonPropertyNameAttribute("paymentNotifyUrl")]
        public string PaymentNotifyUrl { get; set; }

        [JsonPropertyNameAttribute("isAuthorization")]
        public Boolean IsAuthorization { get; set; }

        [JsonPropertyNameAttribute("paymentVerificationData")]
        public PaymentVerificationData PaymentVerificationData { get; set; }

        [JsonPropertyNameAttribute("paymentFactor")]
        public PaymentFactor PaymentFactor { get; set; }

        [JsonPropertyNameAttribute("merchant")]
        public Merchant Merchant { get; set; }

        [JsonPropertyNameAttribute("env")]
        public Env Env { get; set; }

        [JsonPropertyNameAttribute("settlementStrategy")]
        public SettlementStrategy SettlementStrategy { get; set; }

        [JsonPropertyNameAttribute("extendInfo")]
        public string ExtendInfo { get; set; }

        [JsonPropertyNameAttribute("creditPayPlan")]
        public CreditPayPlan CreditPayPlan { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/pay";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(ProductCodeType, "productCodeType required.");
            Asserts.NotNull(PaymentAmount, "paymentAmount required.");
            Asserts.NotNull(Order, "order required.");
            Asserts.NotNull(PaymentMethod, "paymentMethod required.");
        }
    }
}
