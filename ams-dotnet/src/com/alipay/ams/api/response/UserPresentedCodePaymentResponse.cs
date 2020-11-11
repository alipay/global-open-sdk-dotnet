using System;
using System.Net.Http;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class UserPresentedCodePaymentResponse : AMSResponse
    {


        public Amount ActualPaymentAmount { get; set; }


        public Amount PaymentAmount { get; set; }


        public string PaymentCreateTime { get; set; }


        public string PaymentId { get; set; }


        public Quote PaymentQuote { get; set; }


        public string PaymentRequestId { get; set; }


        public string PaymentTime { get; set; }


        public PspCustomerInfo PspCustomerInfo { get; set; }

    }
}