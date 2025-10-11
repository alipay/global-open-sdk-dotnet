using System;


namespace com.alipay.ams.api.entities
{
    public class Quote
    {
        public Quote() { }


        public bool Guaranteed { get; set; }


        public string QuoteCurrencyPair { get; set; }


        public decimal QuotePrice { get; set; }
        
        public string QuoteId  { get; set; }
        
        public string QuoteStartTime  { get; set; }
        
        public string QuoteExpiryTime  { get; set; }

        public Amount ExchangeAmount { get; set; }

    }
}
