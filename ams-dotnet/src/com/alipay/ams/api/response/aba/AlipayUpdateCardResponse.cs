using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayUpdateCardResponse : AMSResponse
    {

        public AlipayUpdateCardResponse() { }

        

        public AlipayUpdateCardResponse( string status , string requestId , Result result)
        {
            this.Status = status;
            this.RequestId = requestId;
            this.Result = result;
        }

            public string Status { get; set; }
            public string RequestId { get; set; }
            public Result Result { get; set; }

        

    }

}
