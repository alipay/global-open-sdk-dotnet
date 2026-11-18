using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquireReleaseRequest : AMSRequest<AlipayInquireReleaseResponse>
    {

        public AlipayInquireReleaseRequest() { }

        

        public AlipayInquireReleaseRequest( string releaseId , string releaseRequestId)
        {
            this.ReleaseId = releaseId;
            this.ReleaseRequestId = releaseRequestId;
        }

            public string ReleaseId { get; set; }
            public string ReleaseRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/inquireRelease"; } 


    }

}
