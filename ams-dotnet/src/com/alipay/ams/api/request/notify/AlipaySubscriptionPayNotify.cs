namespace com.alipay.ams.api.request.notify;

public class AlipaySubscriptionPayNotify:AlipayPayResultNotify
{
    public string SubscriptionRequestId { get; set; }
    public string SubscriptionId { get; set; }
    public string PeriodStartTime { get; set; }
    public string PeriodEndTime { get; set; }
    public string PhaseNo { get; set; }
}