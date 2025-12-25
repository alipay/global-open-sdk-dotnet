using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardSensitiveInfoResponse : AMSResponse
    {

        public AlipayInquireCardSensitiveInfoResponse() { }

        

        public AlipayInquireCardSensitiveInfoResponse( Result result , string assetId , string cvv , string cardNo , string expiredMonth , string expiredYear)
        {
            this.Result = result;
            this.AssetId = assetId;
            this.Cvv = cvv;
            this.CardNo = cardNo;
            this.ExpiredMonth = expiredMonth;
            this.ExpiredYear = expiredYear;
        }

            public Result Result { get; set; }
            public string AssetId { get; set; }
            public string Cvv { get; set; }
            public string CardNo { get; set; }
            public string ExpiredMonth { get; set; }
            public string ExpiredYear { get; set; }

        

    }

}
