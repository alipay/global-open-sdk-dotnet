using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethod
    {

        public PaymentMethod() { }

        public PaymentMethod(String paymentMethodType){ 
    this.PaymentMethodType = paymentMethodType; 
} 


        public PaymentMethod( string paymentMethodType , string paymentMethodId , FundingType funding , string customerId , string extendInfo , bool? requireIssuerAuthentication , Dictionary<string, Object> paymentMethodMetaData)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodId = paymentMethodId;
            this.Funding = funding;
            this.CustomerId = customerId;
            this.ExtendInfo = extendInfo;
            this.RequireIssuerAuthentication = requireIssuerAuthentication;
            this.PaymentMethodMetaData = paymentMethodMetaData;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodId { get; set; }
            public FundingType Funding { get; set; }
            public string CustomerId { get; set; }
            public string ExtendInfo { get; set; }
            public bool? RequireIssuerAuthentication { get; set; }
            public Dictionary<string, Object> PaymentMethodMetaData { get; set; }

        

    }

}
