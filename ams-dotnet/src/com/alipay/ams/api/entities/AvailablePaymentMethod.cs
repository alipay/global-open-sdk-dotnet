using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AvailablePaymentMethod
    {

        public AvailablePaymentMethod() { }

        

        public AvailablePaymentMethod( PaymentMethodTypeItem[] paymentMethodTypeList)
        {
            this.PaymentMethodTypeList = paymentMethodTypeList;
        }

            public PaymentMethodTypeItem[] PaymentMethodTypeList { get; set; }

        

    }

}
