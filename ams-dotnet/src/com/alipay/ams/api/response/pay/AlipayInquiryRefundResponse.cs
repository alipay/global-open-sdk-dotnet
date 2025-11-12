using System;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay
{
    public class AlipayInquiryRefundResponse : AMSResponse
    {
        public string RefundId { get; set; }
        public string RefundRequestId { get; set; }
        public Amount RefundAmount { get; set; }
        public TransactionStatusType RefundStatus { get; set; }
        public string RefundTime { get; set; }
        public Amount GrossSettlementAmount { get; set; }
        public Quote SettlementQuote { get; set; }
        public AcquirerInfo AcquirerInfo { get; set; }
        
            
        public CustomizedInfo CustomizedInfo { get; set; }

        public string Arn { get; set; }

        public Amount ActualRefundAmount { get; set; }
    }
}