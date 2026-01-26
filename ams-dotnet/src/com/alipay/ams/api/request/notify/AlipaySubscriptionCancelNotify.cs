using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipaySubscriptionCancelNotify:AlipayNotify
{
    public Amount PaymentAmount { get; set; }
    public string PaymentCreateTime { get; set; }
    public string PaymentTime { get; set; }
    public string PeriodEndTime { get; set; }
    public string PhaseNo { get; set; }
    public string SubscriptionId { get; set; }
    public string SubscriptionOrderId { get; set; }
    public SubscriptionNotificationType SubscriptionOrderStatus { get; set; }
    public string SubscriptionRequestId { get; set; }
    public string SubscriptionTransId { get; set; }
}