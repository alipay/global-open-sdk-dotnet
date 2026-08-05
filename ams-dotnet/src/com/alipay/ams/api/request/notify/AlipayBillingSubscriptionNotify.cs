using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayBillingSubscriptionNotify : AlipayNotify
{
    public string MerchantRequestId { get; set; }

    public string EventTime { get; set; }

    public string SubscriptionId { get; set; }

    public string InvoiceId { get; set; }

    public string Status { get; set; }

    public string Reason { get; set; }

    public string ReasonDescription { get; set; }

    public string PreviousStatus { get; set; }

    public Amount FixedAmount { get; set; }
}
