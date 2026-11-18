using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipaySubscriptionNotify:AlipayNotify
{
    public string SubscriptionRequestId { get; set; }
    public string SubscriptionId { get; set; }
    public SubscriptionStatus SubscriptionStatus { get; set; }
    public SubscriptionNotificationType SubscriptionNotificationType { get; set; }
    public string SubscriptionStartTime { get; set; }
    public string SubscriptionEndTime { get; set; }
    public PeriodRule PeriodRule { get; set; }
}