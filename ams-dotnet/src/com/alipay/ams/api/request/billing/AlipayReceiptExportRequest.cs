using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayReceiptExportRequest : AMSRequest<AlipayReceiptExportResponse>
    {

        public AlipayReceiptExportRequest() { }

        

        public AlipayReceiptExportRequest( int? limit , string status , string receiptType , string invoiceId , string subscriptionId , string customerId , string startDate , string endDate , List<string> receiptIds)
        {
            this.Limit = limit;
            this.Status = status;
            this.ReceiptType = receiptType;
            this.InvoiceId = invoiceId;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReceiptIds = receiptIds;
        }

            public int? Limit { get; set; }
            public string Status { get; set; }
            public string ReceiptType { get; set; }
            public string InvoiceId { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public List<string> ReceiptIds { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/export"; } 


    }

}
