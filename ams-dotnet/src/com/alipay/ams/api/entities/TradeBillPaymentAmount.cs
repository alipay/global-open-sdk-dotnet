using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TradeBillPaymentAmount
    {

        public TradeBillPaymentAmount() { }

        

        public TradeBillPaymentAmount( string currency , string value)
        {
            this.Currency = currency;
            this.Value = value;
        }

            public string Currency { get; set; }
            public string Value { get; set; }

        

    }

}
