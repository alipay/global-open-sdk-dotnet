    
namespace com.alipay.ams.api.entities
{

public class OrderCodeForm
    {

        public OrderCodeForm() { }

        public OrderCodeForm( string paymentMethodType , string expireTime , List<CodeDetail> codeDetails , string extendInfo)
        {
            this.PaymentMethodType = paymentMethodType;
            this.ExpireTime = expireTime;
            this.CodeDetails = codeDetails;
            this.ExtendInfo = extendInfo;
        }

            public string PaymentMethodType { get; set; }
            public string ExpireTime { get; set; }
            public List<CodeDetail> CodeDetails { get; set; }
            public string ExtendInfo { get; set; }

        

    }

}
