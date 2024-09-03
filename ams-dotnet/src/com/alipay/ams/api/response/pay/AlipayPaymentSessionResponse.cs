using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay
{
    public class AlipayPaymentSessionResponse : AMSResponse
    {
        public string PaymentSessionData { get; set; }

        public string PaymentSessionExpiryTime { get; set; }

        public string PaymentSessionId { get; set; }

        public string NormalUrl { get; set; }
    }
}