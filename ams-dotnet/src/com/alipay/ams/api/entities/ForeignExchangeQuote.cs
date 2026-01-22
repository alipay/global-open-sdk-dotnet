using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ForeignExchangeQuote
    {

        public ForeignExchangeQuote() { }

        

        public ForeignExchangeQuote( string exchangeRate , string sourceCurrency , string targetCurrency , string quoteTime)
        {
            this.ExchangeRate = exchangeRate;
            this.SourceCurrency = sourceCurrency;
            this.TargetCurrency = targetCurrency;
            this.QuoteTime = quoteTime;
        }

            public string ExchangeRate { get; set; }
            public string SourceCurrency { get; set; }
            public string TargetCurrency { get; set; }
            public string QuoteTime { get; set; }

        

    }

}
