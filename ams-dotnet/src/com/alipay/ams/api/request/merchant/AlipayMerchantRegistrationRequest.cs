using System;
using com.alipay.ams.api.response.merchant;
using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request.merchant
{
    public class AlipayMerchantRegistrationRequest : AMSRequest<AlipayMerchantRegistrationResponse>
    {

        public List<ProductCodeType> ProductCodes { get; set; }

        public string RegistrationRequestId { get; set; }

        public string RegistrationNotifyURL { get; set; }

        public MerchantRegistrationInfo MerchantInfo { get; set; }

        public string passThroughInfo { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/merchants/registration";
        }

        public override void validate()
        {
            Asserts.NotNull(RegistrationRequestId, "RegistrationRequestId required.");
            Asserts.NotNull(MerchantInfo, "MerchantInfo required.");
            Asserts.NotNull(ProductCodes, "ProductCodes required.");
        }
    }
}
