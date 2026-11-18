using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.customs
{
    public class AlipayCustomsDeclareResponse : AMSResponse
    {
        public string CustomsPaymentId { get; set; }
        public string CustomsOrderId  { get; set; }
        public IdentityCheckResult IdentityCheckResult  { get; set; }
        public ClearingChannel ClearingChannel  { get; set; }
        public string ClearingTransactionId  { get; set; }
        public string CustomsProviderRegistrationId  { get; set; }
    }
}