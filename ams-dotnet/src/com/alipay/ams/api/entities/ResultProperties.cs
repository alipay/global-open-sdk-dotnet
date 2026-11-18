using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ResultProperties
    {

        public ResultProperties() { }

        

        public ResultProperties( ResultPropertiesResultCode resultCode , ResultPropertiesResultStatus resultStatus , ResultPropertiesResultCode resultMessage)
        {
            this.ResultCode = resultCode;
            this.ResultStatus = resultStatus;
            this.ResultMessage = resultMessage;
        }

            public ResultPropertiesResultCode ResultCode { get; set; }
            public ResultPropertiesResultStatus ResultStatus { get; set; }
            public ResultPropertiesResultCode ResultMessage { get; set; }

        

    }

}
