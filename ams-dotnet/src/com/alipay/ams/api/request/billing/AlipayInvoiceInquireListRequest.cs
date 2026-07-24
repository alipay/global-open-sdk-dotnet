using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceInquireListRequest : AMSRequest<AlipayInvoiceInquireListResponse>
    {

        public AlipayInvoiceInquireListRequest() { }

        

        public AlipayInvoiceInquireListRequest( string startingAfter , string endingBefore , int? limit , bool? includeTotal , string subscriptionId , string customerId , string invoiceId , string status , string reason , string startDate , string endDate , Amount minAmount , Amount maxAmount)
        {
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.Reason = reason;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MinAmount = minAmount;
            this.MaxAmount = maxAmount;
        }

            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string Reason { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public Amount MinAmount { get; set; }
            public Amount MaxAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/inquireList"; } 


    }

}
