using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PromotionCodeCreateMinAmount
    {

        public PromotionCodeCreateMinAmount() { }

        

        public PromotionCodeCreateMinAmount( string value , string currency)
        {
            this.Value = value;
            this.Currency = currency;
        }

            public string Value { get; set; }
            public string Currency { get; set; }

        

    }

}
