using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AvailablePaymentMethod
    {

        public AvailablePaymentMethod() { }

        

        public AvailablePaymentMethod( Dictionary<string, Object> paymentMethodMetaData , PaymentMethodTypeItem[] paymentMethodTypeList)
        {
            this.PaymentMethodMetaData = paymentMethodMetaData;
            this.PaymentMethodTypeList = paymentMethodTypeList;
        }

            public Dictionary<string, Object> PaymentMethodMetaData { get; set; }
            public PaymentMethodTypeItem[] PaymentMethodTypeList { get; set; }

        

    }

}
