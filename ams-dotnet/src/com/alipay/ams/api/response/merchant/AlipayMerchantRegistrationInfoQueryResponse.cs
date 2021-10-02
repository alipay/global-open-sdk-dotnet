using System;
using System.Collections.Generic;
using com.alipay.ams.api.entities;
namespace com.alipay.ams.api.response.merchant
{
    public class AlipayMerchantRegistrationInfoQueryResponse : AMSResponse
    {
        public MerchantRegistrationInfo merchantInfo { get; set; }

        public List<ProductCodeType> productCodes { get; set; }
    }
}
