using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPayConsultResponse : AMSResponse
    {

        public AlipayPayConsultResponse() { }

        public AlipayPayConsultResponse( Result result , List<PaymentOption> paymentOptions , List<PaymentMethodInfo> paymentMethodInfos , string extendInfo)
        {
            this.Result = result;
            this.PaymentOptions = paymentOptions;
            this.PaymentMethodInfos = paymentMethodInfos;
            this.ExtendInfo = extendInfo;
        }

            public Result Result { get; set; }
            public List<PaymentOption> PaymentOptions { get; set; }
            public List<PaymentMethodInfo> PaymentMethodInfos { get; set; }
            public string ExtendInfo { get; set; }

        

    }

}
