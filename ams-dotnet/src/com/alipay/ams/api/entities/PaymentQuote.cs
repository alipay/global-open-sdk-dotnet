using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentQuote
    {

        public PaymentQuote() { }

        

        public PaymentQuote( string buyCurrency , string sellCurrency , string quoteId , decimal? exchangeRate)
        {
            this.BuyCurrency = buyCurrency;
            this.SellCurrency = sellCurrency;
            this.QuoteId = quoteId;
            this.ExchangeRate = exchangeRate;
        }

            public string BuyCurrency { get; set; }
            public string SellCurrency { get; set; }
            public string QuoteId { get; set; }
            public decimal? ExchangeRate { get; set; }

        

    }

}
