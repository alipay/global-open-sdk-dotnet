using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ReceiptPaymentMethod
    {

        public ReceiptPaymentMethod() { }

        

        public ReceiptPaymentMethod( string paymentMethodType)
        {
            this.PaymentMethodType = paymentMethodType;
        }

            public string PaymentMethodType { get; set; }

        

    }

}
