using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquiryRateRequest : AMSRequest<AlipayInquiryRateResponse>
    {

        public AlipayInquiryRateRequest() { }

        

        public AlipayInquiryRateRequest( List<InquiryRateCondition> rateConditionList)
        {
            this.RateConditionList = rateConditionList;
        }

            public List<InquiryRateCondition> RateConditionList { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/funds/inquireRate"; } 


    }

}
