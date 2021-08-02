using System;
using System.Net.Http;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class EntryCodePaymentResponse : CommonPaymentResponse
    {

        public new Amount PaymentAmount { get; set; }


        public new string PaymentCreateTime { get; set; }


        public new string PaymentId { get; set; }


        public new string PaymentRequestId { get; set; }


        public new RedirectActionForm RedirectActionForm { get; set; }

    }
}