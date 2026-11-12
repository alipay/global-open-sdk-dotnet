using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ExcludedPaymentMethod
    {

        public ExcludedPaymentMethod() { }

        

        public ExcludedPaymentMethod( PaymentMethodTypeItem[] paymentMethodTypeList)
        {
            this.PaymentMethodTypeList = paymentMethodTypeList;
        }

            public PaymentMethodTypeItem[] PaymentMethodTypeList { get; set; }

        

    }

}
