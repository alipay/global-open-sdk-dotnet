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

        

        public AlipayReceiptExportRequest( string status , string subscriptionId , string customerId , string startDate , string endDate , List<string> receiptIds , string fileFormat , string language , string downloadType , string columnPreset)
        {
            this.Status = status;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReceiptIds = receiptIds;
            this.FileFormat = fileFormat;
            this.Language = language;
            this.DownloadType = downloadType;
            this.ColumnPreset = columnPreset;
        }

            public string Status { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public List<string> ReceiptIds { get; set; }
            public string FileFormat { get; set; }
            public string Language { get; set; }
            public string DownloadType { get; set; }
            public string ColumnPreset { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/export"; } 


    }

}
