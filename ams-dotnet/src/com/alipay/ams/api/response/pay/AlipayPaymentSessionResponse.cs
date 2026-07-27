using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPaymentSessionResponse : AMSResponse
    {

        public AlipayPaymentSessionResponse() { }

        

        public AlipayPaymentSessionResponse( Result result , string paymentSessionData , string paymentSessionExpiryTime , string paymentSessionId , string normalUrl , string url , string subscriptionId , string invoiceId)
        {
            this.Result = result;
            this.PaymentSessionData = paymentSessionData;
            this.PaymentSessionExpiryTime = paymentSessionExpiryTime;
            this.PaymentSessionId = paymentSessionId;
            this.NormalUrl = normalUrl;
            this.Url = url;
            this.SubscriptionId = subscriptionId;
            this.InvoiceId = invoiceId;
        }

            public Result Result { get; set; }
            public string PaymentSessionData { get; set; }
            public string PaymentSessionExpiryTime { get; set; }
            public string PaymentSessionId { get; set; }
            public string NormalUrl { get; set; }
            public string Url { get; set; }
            public string SubscriptionId { get; set; }
            public string InvoiceId { get; set; }

        

    }

}
