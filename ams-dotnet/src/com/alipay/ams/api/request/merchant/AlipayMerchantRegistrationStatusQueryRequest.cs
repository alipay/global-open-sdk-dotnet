using System;
using com.alipay.ams.api.response.merchant;
namespace com.alipay.ams.api.request.merchant
{
    public class AlipayMerchantRegistrationStatusQueryRequest : AMSRequest<AlipayMerchantRegistrationStatusQueryResponse>
    {

        public string RegistrationRequestId { get; set; }

        public string ReferenceMerchantId { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/merchants/inquiryRegistrationInfo";
        }

        public override void validate()
        {
            
        }
    }
}
