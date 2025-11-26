using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPayCancelResponse : AMSResponse
    {

        public AlipayPayCancelResponse() { }

        

        public AlipayPayCancelResponse( Result result , string paymentId , string paymentRequestId , string cancelTime)
        {
            this.Result = result;
            this.PaymentId = paymentId;
            this.PaymentRequestId = paymentRequestId;
            this.CancelTime = cancelTime;
        }

            public Result Result { get; set; }
            public string PaymentId { get; set; }
            public string PaymentRequestId { get; set; }
            public string CancelTime { get; set; }

        

    }

}
