using System;
using System.Net.Http;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentRefundResponse : AMSResponse
    {


        public string PaymentId { get; set; }


        public string RefundId { get; set; }


        public string RefundRequestId { get; set; }


        public Amount RefundAmount { get; set; }


        public string RefundTime { get; set; }


        public bool IsAsyncRefund { get; set; }


        public Amount GrossSettlementAmount { get; set; }


        public Quote SettlementQuote { get; set; }

    }
}