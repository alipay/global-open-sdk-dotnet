using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RateResult
    {

        public RateResult() { }

        

        public RateResult( string buyCurrency , string sellCurrency , string exchangeRate)
        {
            this.BuyCurrency = buyCurrency;
            this.SellCurrency = sellCurrency;
            this.ExchangeRate = exchangeRate;
        }

            public string BuyCurrency { get; set; }
            public string SellCurrency { get; set; }
            public string ExchangeRate { get; set; }

        

    }

}
