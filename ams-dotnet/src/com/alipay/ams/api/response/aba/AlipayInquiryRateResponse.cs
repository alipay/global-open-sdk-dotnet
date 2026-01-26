using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquiryRateResponse : AMSResponse
    {

        public AlipayInquiryRateResponse() { }

        

        public AlipayInquiryRateResponse( List<RateResult> rateResultList , Result result)
        {
            this.RateResultList = rateResultList;
            this.Result = result;
        }

            public List<RateResult> RateResultList { get; set; }
            public Result Result { get; set; }

        

    }

}
