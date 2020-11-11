using System;


namespace com.alipay.ams.api.entities
{
    public class Quote
    {
        public Quote() { }


        public bool Guaranteed { get; set; }


        public string QuoteCurrencyPair { get; set; }


        public decimal QuotePrice { get; set; }

    }
}
