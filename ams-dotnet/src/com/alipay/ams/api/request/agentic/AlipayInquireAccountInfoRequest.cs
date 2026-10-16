using com.alipay.ams.api.response.agentic;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.agentic
{

public class AlipayInquireAccountInfoRequest : AMSRequest<AlipayInquireAccountInfoResponse>
    {

        public AlipayInquireAccountInfoRequest() { }

        

        public AlipayInquireAccountInfoRequest( string requestId , string userLoginId , AgenticAccountInfoAgent agent , AgenticAccountInfoEnv env)
        {
            this.RequestId = requestId;
            this.UserLoginId = userLoginId;
            this.Agent = agent;
            this.Env = env;
        }

            public string RequestId { get; set; }
            public string UserLoginId { get; set; }
            public AgenticAccountInfoAgent Agent { get; set; }
            public AgenticAccountInfoEnv Env { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/agenticPayment/inquireAccountInfo"; } 


    }

}
