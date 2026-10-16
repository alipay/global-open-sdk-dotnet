using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticBoundPaymentMethod
    {

        public AgenticBoundPaymentMethod() { }

        

        public AgenticBoundPaymentMethod( string paymentMethodType , string paymentMethodId , AgenticBoundPaymentMethodDetail paymentMethodDetail)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodId = paymentMethodId;
            this.PaymentMethodDetail = paymentMethodDetail;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodId { get; set; }
            public AgenticBoundPaymentMethodDetail PaymentMethodDetail { get; set; }

        

    }

}
