using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquireHoldListRequest : AMSRequest<AlipayInquireHoldListResponse>
    {

        public AlipayInquireHoldListRequest() { }

        

        public AlipayInquireHoldListRequest( string holdRequestId , string holdId , int? limit , string startingAfter , string endingBefore)
        {
            this.HoldRequestId = holdRequestId;
            this.HoldId = holdId;
            this.Limit = limit;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
        }

            public string HoldRequestId { get; set; }
            public string HoldId { get; set; }
            public int? Limit { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/inquireHoldList"; } 


    }

}
