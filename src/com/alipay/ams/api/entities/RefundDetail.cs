    
namespace com.alipay.ams.api.entities
{

public class RefundDetail
    {

        public RefundDetail() { }

        public RefundDetail( Amount refundAmount , RefundFromType refundFrom)
        {
            this.RefundAmount = refundAmount;
            this.RefundFrom = refundFrom;
        }

            public Amount RefundAmount { get; set; }
            public RefundFromType RefundFrom { get; set; }

        

    }

}
