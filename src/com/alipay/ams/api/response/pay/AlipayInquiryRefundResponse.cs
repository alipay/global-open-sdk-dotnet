using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquiryRefundResponse : AMSResponse
    {

        public AlipayInquiryRefundResponse() { }

        public AlipayInquiryRefundResponse( Result result , string refundId , string refundRequestId , Amount refundAmount , TransactionStatusType refundStatus , string refundTime , Amount grossSettlementAmount , Quote settlementQuote , AcquirerInfo acquirerInfo)
        {
            this.Result = result;
            this.RefundId = refundId;
            this.RefundRequestId = refundRequestId;
            this.RefundAmount = refundAmount;
            this.RefundStatus = refundStatus;
            this.RefundTime = refundTime;
            this.GrossSettlementAmount = grossSettlementAmount;
            this.SettlementQuote = settlementQuote;
            this.AcquirerInfo = acquirerInfo;
        }

            public Result Result { get; set; }
            public string RefundId { get; set; }
            public string RefundRequestId { get; set; }
            public Amount RefundAmount { get; set; }
            public TransactionStatusType RefundStatus { get; set; }
            public string RefundTime { get; set; }
            public Amount GrossSettlementAmount { get; set; }
            public Quote SettlementQuote { get; set; }
            public AcquirerInfo AcquirerInfo { get; set; }

        

    }

}
