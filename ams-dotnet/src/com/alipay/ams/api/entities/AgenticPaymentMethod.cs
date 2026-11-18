using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPaymentMethod
    {

        public AgenticPaymentMethod() { }

        

        public AgenticPaymentMethod( string paymentMethodType , string paymentMethodId , string selectedCardBrand)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodId = paymentMethodId;
            this.SelectedCardBrand = selectedCardBrand;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodId { get; set; }
            public string SelectedCardBrand { get; set; }

        

    }

}
