using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayUpdateHoldRequest : AMSRequest<AlipayUpdateHoldResponse>
    {

        public AlipayUpdateHoldRequest() { }

        

        public AlipayUpdateHoldRequest( string holdId , string releaseTime)
        {
            this.HoldId = holdId;
            this.ReleaseTime = releaseTime;
        }

            public string HoldId { get; set; }
            public string ReleaseTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/updateHold"; } 


    }

}
