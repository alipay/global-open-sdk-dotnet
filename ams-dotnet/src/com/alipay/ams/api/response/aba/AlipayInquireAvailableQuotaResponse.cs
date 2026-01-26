using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireAvailableQuotaResponse : AMSResponse
    {

        public AlipayInquireAvailableQuotaResponse() { }

        

        public AlipayInquireAvailableQuotaResponse( Amount availableQuota , Result result)
        {
            this.AvailableQuota = availableQuota;
            this.Result = result;
        }

            public Amount AvailableQuota { get; set; }
            public Result Result { get; set; }

        

    }

}
