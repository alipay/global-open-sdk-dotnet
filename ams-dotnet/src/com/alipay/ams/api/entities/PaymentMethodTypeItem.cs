using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodTypeItem
    {

        public PaymentMethodTypeItem() { }

        

        public PaymentMethodTypeItem( string paymentMethodType , int? paymentMethodOrder , bool? expressCheckout)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodOrder = paymentMethodOrder;
            this.ExpressCheckout = expressCheckout;
        }

            public string PaymentMethodType { get; set; }
            public int? PaymentMethodOrder { get; set; }
            public bool? ExpressCheckout { get; set; }

        

    }

}
