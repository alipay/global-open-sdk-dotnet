using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPromotionCodeCreateResponse : AMSResponse
    {

        public AlipayPromotionCodeCreateResponse() { }

        

        public AlipayPromotionCodeCreateResponse( Result result , string promotionCodeId , string code , string status)
        {
            this.Result = result;
            this.PromotionCodeId = promotionCodeId;
            this.Code = code;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string PromotionCodeId { get; set; }
            public string Code { get; set; }
            public string Status { get; set; }

        

    }

}
