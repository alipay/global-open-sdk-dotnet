using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquiryRefundRequest : AMSRequest<AlipayInquiryRefundResponse>
    {

        public AlipayInquiryRefundRequest() { }

        public AlipayInquiryRefundRequest( string refundRequestId , string refundId , string merchantAccountId)
        {
            this.RefundRequestId = refundRequestId;
            this.RefundId = refundId;
            this.MerchantAccountId = merchantAccountId;
        }

            public string RefundRequestId { get; set; }
            public string RefundId { get; set; }
            public string MerchantAccountId { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/payments/inquiryRefund"; 
} 


    }

}
