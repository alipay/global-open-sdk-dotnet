using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AvailablePaymentMethod
    {

        public AvailablePaymentMethod() { }

        

        public AvailablePaymentMethod(  List<PaymentMethodTypeItem>  paymentMethodTypeList)
        {
            this.PaymentMethodTypeList = paymentMethodTypeList;
        }

            public  List<PaymentMethodTypeItem>  PaymentMethodTypeList { get; set; }

        

    }

}
