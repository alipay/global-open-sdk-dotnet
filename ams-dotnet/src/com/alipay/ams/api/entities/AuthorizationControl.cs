using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationControl
    {

        public AuthorizationControl() { }

        

        public AuthorizationControl( string cardActiveTime , string cardCancelTime , List<string> allowedMerchantCategoryList , int? allowedAuthTimes , List<string> allowedCurrencies , List<string> paymentPreferenceCurrencies , CardLimitDetail cardLimitDetail , CardLimitInfo cardLimitInfo , RefundPreference refundPreference)
        {
            this.CardActiveTime = cardActiveTime;
            this.CardCancelTime = cardCancelTime;
            this.AllowedMerchantCategoryList = allowedMerchantCategoryList;
            this.AllowedAuthTimes = allowedAuthTimes;
            this.AllowedCurrencies = allowedCurrencies;
            this.PaymentPreferenceCurrencies = paymentPreferenceCurrencies;
            this.CardLimitDetail = cardLimitDetail;
            this.CardLimitInfo = cardLimitInfo;
            this.RefundPreference = refundPreference;
        }

            public string CardActiveTime { get; set; }
            public string CardCancelTime { get; set; }
            public List<string> AllowedMerchantCategoryList { get; set; }
            public int? AllowedAuthTimes { get; set; }
            public List<string> AllowedCurrencies { get; set; }
            public List<string> PaymentPreferenceCurrencies { get; set; }
            public CardLimitDetail CardLimitDetail { get; set; }
            public CardLimitInfo CardLimitInfo { get; set; }
            public RefundPreference RefundPreference { get; set; }

        

    }

}
