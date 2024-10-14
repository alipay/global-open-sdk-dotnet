using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class AlipayInquiryRefundRequest : AMSRequest<AlipayInquiryRefundResponse>
    {
        public string RefundRequestId { get; set; }
        public string RefundId { get; set; }
        public string MerchantAccountId { get; set; }
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.INQUIRY_REFUND_PATH;
        }

        public override void validate()
        {
           
        }

    }
}