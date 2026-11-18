using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquireHoldListResponse : AMSResponse
    {

        public AlipayInquireHoldListResponse() { }

        

        public AlipayInquireHoldListResponse( Result result , List<ReserveHoldDetail> holdDetails , bool? hasMore)
        {
            this.Result = result;
            this.HoldDetails = holdDetails;
            this.HasMore = hasMore;
        }

            public Result Result { get; set; }
            public List<ReserveHoldDetail> HoldDetails { get; set; }
            public bool? HasMore { get; set; }

        

    }

}
