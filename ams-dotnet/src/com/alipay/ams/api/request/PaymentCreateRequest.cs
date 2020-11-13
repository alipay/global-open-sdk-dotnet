using System;
using System.Collections.Generic;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentCreateRequest : AMSRequest<PaymentCreateResponse>
    {


        public ProductCodeType ProductCode { get; set; }


        public string PaymentRequestId { get; set; }


        public Order Order { get; set; }


        public Amount PaymentAmount { get; set; }


        public string PaymentRedirectUrl { get; set; }


        public string PaymentNotifyUrl { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/create";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(ProductCode, "productCode required.");
            Asserts.NotNull(PaymentAmount, "paymentAmount required.");
            Asserts.NotNull(Order, "order required.");
            Asserts.NotNull(PaymentRedirectUrl, "paymentRedirectUrl required.");
            Asserts.NotNull(PaymentNotifyUrl, "paymentNotifyUrl required.");
        }
    }
}
