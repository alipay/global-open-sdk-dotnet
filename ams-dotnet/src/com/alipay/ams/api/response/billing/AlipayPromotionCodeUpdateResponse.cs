using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPromotionCodeUpdateResponse : AMSResponse
    {

        public AlipayPromotionCodeUpdateResponse() { }

        

        public AlipayPromotionCodeUpdateResponse( Result result , string promotionCodeId , string status)
        {
            this.Result = result;
            this.PromotionCodeId = promotionCodeId;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string PromotionCodeId { get; set; }
            public string Status { get; set; }

        

    }

}
