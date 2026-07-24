using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayReceiptExportResponse : AMSResponse
    {

        public AlipayReceiptExportResponse() { }

        

        public AlipayReceiptExportResponse( Result result , string status , string downloadUrl , string expiresAt)
        {
            this.Result = result;
            this.Status = status;
            this.DownloadUrl = downloadUrl;
            this.ExpiresAt = expiresAt;
        }

            public Result Result { get; set; }
            public string Status { get; set; }
            public string DownloadUrl { get; set; }
            public string ExpiresAt { get; set; }

        

    }

}
