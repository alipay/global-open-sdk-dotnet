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

        

        public AlipayInvoiceExportRequest( string customerId , string status , string subscriptionId , List<string> invoiceIds , string startDate , string endDate , string fileFormat , string language , string downloadType , string columnPreset)
        {
            this.CustomerId = customerId;
            this.Status = status;
            this.SubscriptionId = subscriptionId;
            this.InvoiceIds = invoiceIds;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FileFormat = fileFormat;
            this.Language = language;
            this.DownloadType = downloadType;
            this.ColumnPreset = columnPreset;
        }

            public string CustomerId { get; set; }
            public string Status { get; set; }
            public string SubscriptionId { get; set; }
            public List<string> InvoiceIds { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string FileFormat { get; set; }
            public string Language { get; set; }
            public string DownloadType { get; set; }
            public string ColumnPreset { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/export"; } 


    }

}
