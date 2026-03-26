using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RefundFromMethod
    {

        public RefundFromMethod() { }

        

        public RefundFromMethod( string grantToken , string refundFromMethodType , string customerId)
        {
            this.GrantToken = grantToken;
            this.RefundFromMethodType = refundFromMethodType;
            this.CustomerId = customerId;
        }

            public string GrantToken { get; set; }
            public string RefundFromMethodType { get; set; }
            public string CustomerId { get; set; }

        

    }

}
