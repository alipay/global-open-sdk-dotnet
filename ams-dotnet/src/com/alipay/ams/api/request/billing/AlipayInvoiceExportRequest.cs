using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceExportRequest : AMSRequest<AlipayInvoiceExportResponse>
    {

        public AlipayInvoiceExportRequest() { }

        

        public AlipayInvoiceExportRequest( int? limit , string customerId , string status , string subscriptionId , List<string> invoiceIds , string reason , string startDate , string endDate , Amount minAmount , Amount maxAmount)
        {
            this.Limit = limit;
            this.CustomerId = customerId;
            this.Status = status;
            this.SubscriptionId = subscriptionId;
            this.InvoiceIds = invoiceIds;
            this.Reason = reason;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MinAmount = minAmount;
            this.MaxAmount = maxAmount;
        }

            public int? Limit { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }
            public string SubscriptionId { get; set; }
            public List<string> InvoiceIds { get; set; }
            public string Reason { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public Amount MinAmount { get; set; }
            public Amount MaxAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/export"; } 


    }

}
