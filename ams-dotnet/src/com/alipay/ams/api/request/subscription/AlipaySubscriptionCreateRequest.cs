using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.com.alipay.ams.api.request.subscription
{
    public class AlipaySubscriptionCreateRequest : AMSRequest<AlipaySubscriptionCreateResponse>
    {
        public string SubscriptionRequestId { get; set; }
        public string SubscriptionDescription  { get; set; }
        public string SubscriptionRedirectUrl  { get; set; }
        public string SubscriptionStartTime  { get; set; }
        public string SubscriptionEndTime  { get; set; }
        public PeriodRule PeriodRule  { get; set; }
        public string SubscriptionExpiryTime  { get; set; }
        public PaymentMethod PaymentMethod  { get; set; }
        public string SubscriptionNotificationUrl  { get; set; }
        public string PaymentNotificationUrl  { get; set; }
        public OrderInfo OrderInfo  { get; set; }
        public Amount PaymentAmount  { get; set; }
        public SettlementStrategy SettlementStrategy  { get; set; }
        public Env Env  { get; set; }
        public List<Trial> Trials  { get; set; }
        public override string GetRequestURI()
        {
            return AntomPathConstants.SUBSCRIPTION_CANCEL_PATH;
        }

        public override void validate()
        {
            
        }
    }
}