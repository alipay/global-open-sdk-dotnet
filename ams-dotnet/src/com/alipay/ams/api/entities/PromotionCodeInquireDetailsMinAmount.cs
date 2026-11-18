using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PromotionCodeInquireDetailsMinAmount
    {

        public PromotionCodeInquireDetailsMinAmount() { }

        

        public PromotionCodeInquireDetailsMinAmount( string value , string currency)
        {
            this.Value = value;
            this.Currency = currency;
        }

            public string Value { get; set; }
            public string Currency { get; set; }

        

    }

}
