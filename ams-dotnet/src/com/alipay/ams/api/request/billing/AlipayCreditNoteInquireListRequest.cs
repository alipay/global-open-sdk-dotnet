using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditNoteInquireListRequest : AMSRequest<AlipayCreditNoteInquireListResponse>
    {

        public AlipayCreditNoteInquireListRequest() { }

        

        public AlipayCreditNoteInquireListRequest( string invoiceId , string customerId , string status , string type , string reason , string startDate , string endDate , string startingAfter , string endingBefore , int? limit , bool? includeTotal)
        {
            this.InvoiceId = invoiceId;
            this.CustomerId = customerId;
            this.Status = status;
            this.Type = type;
            this.Reason = reason;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
        }

            public string InvoiceId { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }
            public string Type { get; set; }
            public string Reason { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/creditNote/inquireList"; } 


    }

}
