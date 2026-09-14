using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquireRuleListRequest : AMSRequest<AlipayInquireRuleListResponse>
    {

        public AlipayInquireRuleListRequest() { }

        

        public AlipayInquireRuleListRequest( FundsType fundsType , TakeType takeType , ReleaseType releaseType , int? limit , string startingAfter , string endingBefore)
        {
            this.FundsType = fundsType;
            this.TakeType = takeType;
            this.ReleaseType = releaseType;
            this.Limit = limit;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
        }

            public FundsType FundsType { get; set; }
            public TakeType TakeType { get; set; }
            public ReleaseType ReleaseType { get; set; }
            public int? Limit { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/inquireRuleList"; } 


    }

}
