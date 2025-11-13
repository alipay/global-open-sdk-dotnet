using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Quote
    {

        public Quote() { }

        

        public Quote(  string  quoteId ,  string  quoteCurrencyPair ,  decimal?  quotePrice ,  string  quoteStartTime ,  string  quoteExpiryTime ,  bool?  guaranteed)
        {
            this.QuoteId = quoteId;
            this.QuoteCurrencyPair = quoteCurrencyPair;
            this.QuotePrice = quotePrice;
            this.QuoteStartTime = quoteStartTime;
            this.QuoteExpiryTime = quoteExpiryTime;
            this.Guaranteed = guaranteed;
        }

            public  string  QuoteId { get; set; }
            public  string  QuoteCurrencyPair { get; set; }
            public  decimal?  QuotePrice { get; set; }
            public  string  QuoteStartTime { get; set; }
            public  string  QuoteExpiryTime { get; set; }
            public  bool?  Guaranteed { get; set; }

        

    }

}
