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

        

        public AlipayBillingSubscriptionInquireListRequest( string status , string customerId , string subscriptionId , string gmtCreateStart , string gmtCreateEnd , string sortOrder , string startingAfter , string endingBefore , int? limit)
        {
            this.Status = status;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.GmtCreateStart = gmtCreateStart;
            this.GmtCreateEnd = gmtCreateEnd;
            this.SortOrder = sortOrder;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
        }

            public string Status { get; set; }
            public string CustomerId { get; set; }
            public string SubscriptionId { get; set; }
            public string GmtCreateStart { get; set; }
            public string GmtCreateEnd { get; set; }
            public string SortOrder { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/inquireList"; } 


    }

}
