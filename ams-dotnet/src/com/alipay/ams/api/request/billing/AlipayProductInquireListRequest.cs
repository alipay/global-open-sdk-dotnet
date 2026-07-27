using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayProductInquireListRequest : AMSRequest<AlipayProductInquireListResponse>
    {

        public AlipayProductInquireListRequest() { }

        

        public AlipayProductInquireListRequest( string startingAfter , string endingBefore , int? limit , bool? active , string type , string keyword , bool? includeTotal)
        {
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.Active = active;
            this.Type = type;
            this.Keyword = keyword;
            this.IncludeTotal = includeTotal;
        }

            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? Active { get; set; }
            public string Type { get; set; }
            public string Keyword { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/product/inquireList"; } 


    }

}
