using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentInquiryRequest : AMSRequest<PaymentInquiryResponse>
    {

        [JsonPropertyNameAttribute("paymentRequestId")]
        public string PaymentRequestId { get; set; }


        public override string BuildBody()
        {

            validate();

            return JsonSerializer.Serialize(this);
        }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/inquiryPayment";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
        }
    }
}
