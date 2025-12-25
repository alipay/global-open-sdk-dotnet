using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationControl
    {

        public AuthorizationControl() { }

        

        public AuthorizationControl( string cardActiveTime , string cardCancelTime , List<string> allowedMerchantCategoryList , int? allowedAuthTimes , List<string> allowedCurrencies , CardLimitDetail cardLimitDetail , CardLimitInfo cardLimitInfo)
        {
            this.CardActiveTime = cardActiveTime;
            this.CardCancelTime = cardCancelTime;
            this.AllowedMerchantCategoryList = allowedMerchantCategoryList;
            this.AllowedAuthTimes = allowedAuthTimes;
            this.AllowedCurrencies = allowedCurrencies;
            this.CardLimitDetail = cardLimitDetail;
            this.CardLimitInfo = cardLimitInfo;
        }

            public string CardActiveTime { get; set; }
            public string CardCancelTime { get; set; }
            public List<string> AllowedMerchantCategoryList { get; set; }
            public int? AllowedAuthTimes { get; set; }
            public List<string> AllowedCurrencies { get; set; }
            public CardLimitDetail CardLimitDetail { get; set; }
            public CardLimitInfo CardLimitInfo { get; set; }

        

    }

}
