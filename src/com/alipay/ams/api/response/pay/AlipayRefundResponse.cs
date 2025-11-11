using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayRefundResponse : AMSResponse
    {

        public AlipayRefundResponse() { }

        public AlipayRefundResponse( Result result , string refundRequestId , string refundId , string paymentId , Amount refundAmount , string refundTime , Amount refundNonGuaranteeCouponAmount , Amount grossSettlementAmount , Quote settlementQuote , AcquirerInfo acquirerInfo , string acquirerReferenceNo)
        {
            this.Result = result;
            this.RefundRequestId = refundRequestId;
            this.RefundId = refundId;
            this.PaymentId = paymentId;
            this.RefundAmount = refundAmount;
            this.RefundTime = refundTime;
            this.RefundNonGuaranteeCouponAmount = refundNonGuaranteeCouponAmount;
            this.GrossSettlementAmount = grossSettlementAmount;
            this.SettlementQuote = settlementQuote;
            this.AcquirerInfo = acquirerInfo;
            this.AcquirerReferenceNo = acquirerReferenceNo;
        }

            public Result Result { get; set; }
            public string RefundRequestId { get; set; }
            public string RefundId { get; set; }
            public string PaymentId { get; set; }
            public Amount RefundAmount { get; set; }
            public string RefundTime { get; set; }
            public Amount RefundNonGuaranteeCouponAmount { get; set; }
            public Amount GrossSettlementAmount { get; set; }
            public Quote SettlementQuote { get; set; }
            public AcquirerInfo AcquirerInfo { get; set; }
            public string AcquirerReferenceNo { get; set; }

        

    }

}
