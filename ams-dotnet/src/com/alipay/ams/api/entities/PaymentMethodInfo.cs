using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodInfo
    {

        public PaymentMethodInfo() { }

        

        public PaymentMethodInfo( string paymentMethodType , string paymentMethodDetail , bool? enabled , bool? preferred , string extendInfo)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodDetail = paymentMethodDetail;
            this.Enabled = enabled;
            this.Preferred = preferred;
            this.ExtendInfo = extendInfo;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodDetail { get; set; }
            public bool? Enabled { get; set; }
            public bool? Preferred { get; set; }
            public string ExtendInfo { get; set; }

        

    }

}
