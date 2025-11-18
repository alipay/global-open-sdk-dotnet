using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CurrencyPair
    {

        public CurrencyPair() { }

        

        public CurrencyPair( string sellCurrency , string buyCurrency)
        {
            this.SellCurrency = sellCurrency;
            this.BuyCurrency = buyCurrency;
        }

            public string SellCurrency { get; set; }
            public string BuyCurrency { get; set; }

        

    }

}
