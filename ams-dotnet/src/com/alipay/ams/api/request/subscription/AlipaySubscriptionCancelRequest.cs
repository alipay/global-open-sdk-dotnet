using ams_dotnet.com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.subscription
{
    public class AlipaySubscriptionCancelRequest : AMSRequest<AlipaySubscriptionCancelResponse>
    {
        public string SubscriptionId { get; set; }
        public string SubscriptionRequestId { get; set; }
        public string CancellationType { get; set; }
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.SUBSCRIPTION_CANCEL_PATH;
        }

        public override void validate()
        {
            
        }
    }
}