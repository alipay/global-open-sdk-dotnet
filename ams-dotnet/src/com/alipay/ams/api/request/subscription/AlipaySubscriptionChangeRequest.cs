using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.com.alipay.ams.api.response.subscription
{
    public class AlipaySubscriptionChangeRequest : AMSRequest<AlipaySubscriptionChangeResponse>
    {
        public string SubscriptionChangeRequestId { get; set; }
        public string SubscriptionId  { get; set; }
        public string SubscriptionDescription  { get; set; }
        public string SubscriptionStartTime  { get; set; }
        public string SubscriptionEndTime  { get; set; }
        public PeriodRule PeriodRule  { get; set; }
        public string SubscriptionExpiryTime  { get; set; }
        public OrderInfo OrderInfo  { get; set; }
        public Amount PaymentAmount  { get; set; }
        public Amount PaymentAmountDifference  { get; set; }
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.SUBSCRIPTION_CHANGE_PATH;
        }

        public override void validate()
        {
            
        }
    }
}