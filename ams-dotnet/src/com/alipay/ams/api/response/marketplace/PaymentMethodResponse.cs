using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class PaymentMethodResponse : AMSResponse
    {

        public PaymentMethodResponse() { }

        

        public PaymentMethodResponse( string paymentMethodType , string customerId)
        {
            this.PaymentMethodType = paymentMethodType;
            this.CustomerId = customerId;
        }

            public string PaymentMethodType { get; set; }
            public string CustomerId { get; set; }

        

    }

}
