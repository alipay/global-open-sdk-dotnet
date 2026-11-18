using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Result
    {

        public Result() { }

        

        public Result( string resultCode , ResultStatusType resultStatus , string resultMessage)
        {
            this.ResultCode = resultCode;
            this.ResultStatus = resultStatus;
            this.ResultMessage = resultMessage;
        }

            public string ResultCode { get; set; }
            public ResultStatusType ResultStatus { get; set; }
            public string ResultMessage { get; set; }

        

    }

}
