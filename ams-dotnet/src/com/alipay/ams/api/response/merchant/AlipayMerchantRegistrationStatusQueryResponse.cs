using System;
using System.Collections.Generic;
using com.alipay.ams.api.entities;
namespace com.alipay.ams.api.response.merchant
{
    public class AlipayMerchantRegistrationStatusQueryResponse : AMSResponse
    {
       public RegistrationResult RegistrationResult { get; set; }

       public List<PSPRegistrationResult> pspRegistrationResultList { get; set; }
    }
}
