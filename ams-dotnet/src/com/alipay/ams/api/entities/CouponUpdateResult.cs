using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponUpdateResult
    {

        public CouponUpdateResult() { }

        

        public CouponUpdateResult( string resultStatus , string resultCode , string resultMessage)
        {
            this.ResultStatus = resultStatus;
            this.ResultCode = resultCode;
            this.ResultMessage = resultMessage;
        }

            public string ResultStatus { get; set; }
            public string ResultCode { get; set; }
            public string ResultMessage { get; set; }

        

    }

}
