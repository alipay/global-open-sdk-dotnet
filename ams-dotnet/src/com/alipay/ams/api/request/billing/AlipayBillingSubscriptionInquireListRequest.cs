using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionInquireListRequest : AMSRequest<AlipayBillingSubscriptionInquireListResponse>
    {

        public AlipayBillingSubscriptionInquireListRequest() { }

        

        public AlipayBillingSubscriptionInquireListRequest( string status , string customerId , string expiresBefore , string expiresAfter , string startingAfter , string endingBefore , int? limit , bool? includeTotal)
        {
            this.Status = status;
            this.CustomerId = customerId;
            this.ExpiresBefore = expiresBefore;
            this.ExpiresAfter = expiresAfter;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
        }

            public string Status { get; set; }
            public string CustomerId { get; set; }
            public string ExpiresBefore { get; set; }
            public string ExpiresAfter { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/inquireList"; } 


    }

}
