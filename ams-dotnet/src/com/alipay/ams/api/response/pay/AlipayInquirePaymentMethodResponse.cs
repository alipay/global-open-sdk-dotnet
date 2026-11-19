using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquirePaymentMethodResponse : AMSResponse
    {

        public AlipayInquirePaymentMethodResponse() { }

        

        public AlipayInquirePaymentMethodResponse( Result result , List<InquirePaymentMethodDetail> paymentMethodDetails)
        {
            this.Result = result;
            this.PaymentMethodDetails = paymentMethodDetails;
        }

            public Result Result { get; set; }
            public List<InquirePaymentMethodDetail> PaymentMethodDetails { get; set; }

        

    }

}
