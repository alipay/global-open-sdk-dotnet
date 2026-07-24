using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayReceiptInquireListRequest : AMSRequest<AlipayReceiptInquireListResponse>
    {

        public AlipayReceiptInquireListRequest() { }

        

        public AlipayReceiptInquireListRequest( string startingAfter , string endingBefore , int? limit , bool? includeTotal , string customerId , string invoiceId , string subscriptionId , string status , string receiptType , string startDate , string endDate)
        {
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
            this.CustomerId = customerId;
            this.InvoiceId = invoiceId;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.ReceiptType = receiptType;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }
            public string CustomerId { get; set; }
            public string InvoiceId { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string ReceiptType { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/inquireList"; } 


    }

}
