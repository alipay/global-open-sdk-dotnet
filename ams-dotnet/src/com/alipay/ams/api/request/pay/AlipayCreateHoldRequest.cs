using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCreateHoldRequest : AMSRequest<AlipayCreateHoldResponse>
    {

        public AlipayCreateHoldRequest() { }

        

        public AlipayCreateHoldRequest( string holdRequestId , Amount holdAmount , string releaseTime)
        {
            this.HoldRequestId = holdRequestId;
            this.HoldAmount = holdAmount;
            this.ReleaseTime = releaseTime;
        }

            public string HoldRequestId { get; set; }
            public Amount HoldAmount { get; set; }
            public string ReleaseTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/createHold"; } 


    }

}
