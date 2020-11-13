using System;
using System.Net.Http;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentCancelResponse : AMSResponse
    {


        public string PaymentId { get; set; }


        public string PaymentRequestId { get; set; }


        public string CancelTime { get; set; }

    }
}