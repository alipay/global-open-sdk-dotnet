using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPriceInquireListRequest : AMSRequest<AlipayPriceInquireListResponse>
    {

        public AlipayPriceInquireListRequest() { }

        

        public AlipayPriceInquireListRequest( string productId , string pricingModel , bool? active , string startingAfter , string endingBefore , int? list , bool? includeTotal)
        {
            this.ProductId = productId;
            this.PricingModel = pricingModel;
            this.Active = active;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.List = list;
            this.IncludeTotal = includeTotal;
        }

            public string ProductId { get; set; }
            public string PricingModel { get; set; }
            public bool? Active { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? List { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/price/inquireList"; } 


    }

}
