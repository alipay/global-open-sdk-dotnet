using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterCreateSessionRequest : AMSRequest<AlipayMeterCreateSessionResponse>
    {

        public AlipayMeterCreateSessionRequest() { }

        

        public AlipayMeterCreateSessionRequest( string requestId)
        {
            this.RequestId = requestId;
        }

            public string RequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/createSession"; } 


    }

}
