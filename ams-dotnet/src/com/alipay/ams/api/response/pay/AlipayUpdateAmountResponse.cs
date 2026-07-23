using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayUpdateAmountResponse : AMSResponse
    {

        public AlipayUpdateAmountResponse() { }

        

        public AlipayUpdateAmountResponse( Result result , string updateRequestId , string paymentId , Amount amount)
        {
            this.Result = result;
            this.UpdateRequestId = updateRequestId;
            this.PaymentId = paymentId;
            this.Amount = amount;
        }

            public Result Result { get; set; }
            public string UpdateRequestId { get; set; }
            public string PaymentId { get; set; }
            public Amount Amount { get; set; }

        

    }

}
