using System;
using com.alipay.ams.api.response.merchant;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request.merchant
{

    public class AlipayMerchantRegistrationInfoQueryRequest : AMSRequest<AlipayMerchantRegistrationInfoQueryResponse>
    {

        public string ReferenceMerchantId { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/merchants/inquiryRegistrationStatus";
        }

        public override void validate()
        {
            Asserts.NotNull(ReferenceMerchantId, "ReferenceMerchantId required.");
        }
    }


}
