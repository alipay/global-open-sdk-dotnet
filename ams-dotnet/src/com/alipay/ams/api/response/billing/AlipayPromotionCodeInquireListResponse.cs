using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPromotionCodeInquireListResponse : AMSResponse
    {

        public AlipayPromotionCodeInquireListResponse() { }

        

        public AlipayPromotionCodeInquireListResponse( Result result , List<PromotionCodeInfo> promotionCodes , bool? hasMore , string nextCursor , string prevCursor , int? total)
        {
            this.Result = result;
            this.PromotionCodes = promotionCodes;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.PrevCursor = prevCursor;
            this.Total = total;
        }

            public Result Result { get; set; }
            public List<PromotionCodeInfo> PromotionCodes { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }
            public string PrevCursor { get; set; }
            public int? Total { get; set; }

        

    }

}
