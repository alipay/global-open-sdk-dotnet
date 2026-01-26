using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquiryRateCondition
    {

        public InquiryRateCondition() { }

        

        public InquiryRateCondition( string buyCurrency , string sellCurrency)
        {
            this.BuyCurrency = buyCurrency;
            this.SellCurrency = sellCurrency;
        }

            public string BuyCurrency { get; set; }
            public string SellCurrency { get; set; }

        

    }

}
