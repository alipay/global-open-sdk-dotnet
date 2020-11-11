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
        public ProductCodeType ProductCode { get; set; }


        public string PaymentRequestId { get; set; }


        public Order Order { get; set; }


        public Amount PaymentAmount { get; set; }


        public PaymentMethod PayToMethod { get; set; }


        public PaymentMethod PaymentMethod { get; set; }


        public string PaymentExpiryTime { get; set; }


        public string PaymentRedirectUrl { get; set; }


        public string PaymentNotifyUrl { get; set; }


        public Boolean IsAuthorization { get; set; }


        public PaymentVerificationData PaymentVerificationData { get; set; }


        public PaymentFactor PaymentFactor { get; set; }


        public Merchant Merchant { get; set; }


        public Env Env { get; set; }


        public SettlementStrategy SettlementStrategy { get; set; }


        public string ExtendInfo { get; set; }


        public CreditPayPlan CreditPayPlan { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/pay";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(ProductCode, "productCode required.");
            Asserts.NotNull(PaymentAmount, "paymentAmount required.");
            Asserts.NotNull(Order, "order required.");
            Asserts.NotNull(PaymentMethod, "paymentMethod required.");
        }
    }
}
