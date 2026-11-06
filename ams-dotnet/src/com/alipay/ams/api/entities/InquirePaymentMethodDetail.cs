using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquirePaymentMethodDetail
    {

        public InquirePaymentMethodDetail() { }

        

        public InquirePaymentMethodDetail( string paymentMethodDetailType , InquirePaymentMethodCard card)
        {
            this.PaymentMethodDetailType = paymentMethodDetailType;
            this.Card = card;
        }

            public string PaymentMethodDetailType { get; set; }
            public InquirePaymentMethodCard Card { get; set; }

        

    }

}
