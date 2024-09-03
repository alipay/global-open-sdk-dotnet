using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.subscription
{
    public class AlipaySubscriptionCreateResponse : AMSResponse
    {
        public string SchemeUrl { get; set; }

        public string ApplinkUrl { get; set; }

        public string NormalUrl { get; set; }

        public string AppIdentifier { get; set; }
    }
}