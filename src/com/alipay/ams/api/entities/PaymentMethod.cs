    
namespace com.alipay.ams.api.entities
{

public class PaymentMethod
    {

        public PaymentMethod() { }

        public PaymentMethod( string paymentMethodType , string paymentMethodId , Dictionary<string, Object> paymentMethodMetaData , string customerId , string extendInfo , bool? requireIssuerAuthentication)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodId = paymentMethodId;
            this.PaymentMethodMetaData = paymentMethodMetaData;
            this.CustomerId = customerId;
            this.ExtendInfo = extendInfo;
            this.RequireIssuerAuthentication = requireIssuerAuthentication;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodId { get; set; }
            public Dictionary<string, Object> PaymentMethodMetaData { get; set; }
            public string CustomerId { get; set; }
            public string ExtendInfo { get; set; }
            public bool? RequireIssuerAuthentication { get; set; }

        

    }

}
