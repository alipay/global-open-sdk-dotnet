using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AvailablePaymentMethod
    {

        public AvailablePaymentMethod() { }

        

        public AvailablePaymentMethod( PaymentMethodTypeItem[] paymentMethodTypeList , Dictionary<string, Object> paymentMethodMetaData)
        {
            this.PaymentMethodTypeList = paymentMethodTypeList;
            this.PaymentMethodMetaData = paymentMethodMetaData;
        }

            public PaymentMethodTypeItem[] PaymentMethodTypeList { get; set; }
            public Dictionary<string, Object> PaymentMethodMetaData { get; set; }

        

    }

}
