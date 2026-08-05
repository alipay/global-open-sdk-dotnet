using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify
{
    public class AlipayInvoiceNotify : AlipayNotify
    {
        public string InvoiceRequestId { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceStatus { get; set; }
        public Amount InvoiceAmount { get; set; }
        public InvoicePaymentInfo PaymentInfo { get; set; }
        public SubscriptionInfo Subscription { get; set; }
        public string CustomerId { get; set; }
        public string Reason { get; set; }
        public string ReasonDescription { get; set; }
    }
}
