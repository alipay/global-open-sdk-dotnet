using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPaymentSessionResponse : AMSResponse
    {

        public AlipayPaymentSessionResponse() { }

        public AlipayPaymentSessionResponse( Result result , string paymentSessionData , string paymentSessionExpiryTime , string paymentSessionId , string normalUrl)
        {
            this.Result = result;
            this.PaymentSessionData = paymentSessionData;
            this.PaymentSessionExpiryTime = paymentSessionExpiryTime;
            this.PaymentSessionId = paymentSessionId;
            this.NormalUrl = normalUrl;
        }

            public Result Result { get; set; }
            public string PaymentSessionData { get; set; }
            public string PaymentSessionExpiryTime { get; set; }
            public string PaymentSessionId { get; set; }
            public string NormalUrl { get; set; }

        

    }

}
