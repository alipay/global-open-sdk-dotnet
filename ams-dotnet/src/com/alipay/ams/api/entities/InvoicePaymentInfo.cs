using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities
{
    public class InvoicePaymentInfo
    {
        public Result Result { get; set; }
        public string PaymentId { get; set; }
        public Amount PaymentAmount { get; set; }
        public string PaymentTime { get; set; }
    }
}
