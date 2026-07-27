using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceCreateViewLinkResult
    {

        public InvoiceCreateViewLinkResult() { }

        

        public InvoiceCreateViewLinkResult( string resultCode , string resultStatus , string resultMessage)
        {
            this.ResultCode = resultCode;
            this.ResultStatus = resultStatus;
            this.ResultMessage = resultMessage;
        }

            public string ResultCode { get; set; }
            public string ResultStatus { get; set; }
            public string ResultMessage { get; set; }

        

    }

}
