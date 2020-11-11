using System;
using System.Collections.Generic;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentRefundRequest : AMSRequest<PaymentRefundResponse>
    {

        public string PaymentId { get; set; }


        public string RefundRequestId { get; set; }


        public string ReferenceRefundId { get; set; }


        public Amount RefundAmount { get; set; }


        public string RefundReason { get; set; }


        public string RefundRequestTime { get; set; }


        public bool IsAsyncRefund { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/refund";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentId, "paymentId required.");
            Asserts.NotNull(RefundRequestId, "refundRequestId required.");
            Asserts.NotNull(RefundAmount, "refundAmount required.");
            Asserts.NotNull(RefundRequestTime, "refundRequestTime required.");
        }
    }
}
