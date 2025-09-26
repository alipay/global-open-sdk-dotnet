using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayRefundRequest : AMSRequest<AlipayRefundResponse>
    {

        public AlipayRefundRequest() { }

        public AlipayRefundRequest( string refundRequestId , string paymentId , string referenceRefundId , Amount refundAmount , string refundReason , string refundNotifyUrl , bool? isAsyncRefund , string extendInfo , List<RefundDetail> refundDetails , string refundSourceAccountNo)
        {
            this.RefundRequestId = refundRequestId;
            this.PaymentId = paymentId;
            this.ReferenceRefundId = referenceRefundId;
            this.RefundAmount = refundAmount;
            this.RefundReason = refundReason;
            this.RefundNotifyUrl = refundNotifyUrl;
            this.IsAsyncRefund = isAsyncRefund;
            this.ExtendInfo = extendInfo;
            this.RefundDetails = refundDetails;
            this.RefundSourceAccountNo = refundSourceAccountNo;
        }

            public string RefundRequestId { get; set; }
            public string PaymentId { get; set; }
            public string ReferenceRefundId { get; set; }
            public Amount RefundAmount { get; set; }
            public string RefundReason { get; set; }
            public string RefundNotifyUrl { get; set; }
            public bool? IsAsyncRefund { get; set; }
            public string ExtendInfo { get; set; }
            public List<RefundDetail> RefundDetails { get; set; }
            public string RefundSourceAccountNo { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/payments/refund"; 
} 


    }

}
