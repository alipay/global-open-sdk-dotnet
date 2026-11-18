using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayReceiptExportResponse : AMSResponse
    {

        public AlipayReceiptExportResponse() { }

        

        public AlipayReceiptExportResponse( Result result , string fileFormat , string expiresAt , string fileUrl , long? fileSize , string fileName , string mode)
        {
            this.Result = result;
            this.FileFormat = fileFormat;
            this.ExpiresAt = expiresAt;
            this.FileUrl = fileUrl;
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.Mode = mode;
        }

            public Result Result { get; set; }
            public string FileFormat { get; set; }
            public string ExpiresAt { get; set; }
            public string FileUrl { get; set; }
            public long? FileSize { get; set; }
            public string FileName { get; set; }
            public string Mode { get; set; }

        

    }

}
