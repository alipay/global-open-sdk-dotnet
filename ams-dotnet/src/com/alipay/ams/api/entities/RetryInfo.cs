using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RetryInfo
    {

        public RetryInfo() { }

        

        public RetryInfo( int? availableRetries , string orderId , List<PaymentAttempt> paymentAttempts)
        {
            this.AvailableRetries = availableRetries;
            this.OrderId = orderId;
            this.PaymentAttempts = paymentAttempts;
        }

            public int? AvailableRetries { get; set; }
            public string OrderId { get; set; }
            public List<PaymentAttempt> PaymentAttempts { get; set; }

        

    }

}
