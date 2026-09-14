using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCreateReleaseRequest : AMSRequest<AlipayCreateReleaseResponse>
    {

        public AlipayCreateReleaseRequest() { }

        

        public AlipayCreateReleaseRequest( string releaseRequestId , string holdId , Amount releaseAmount)
        {
            this.ReleaseRequestId = releaseRequestId;
            this.HoldId = holdId;
            this.ReleaseAmount = releaseAmount;
        }

            public string ReleaseRequestId { get; set; }
            public string HoldId { get; set; }
            public Amount ReleaseAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/createRelease"; } 


    }

}
