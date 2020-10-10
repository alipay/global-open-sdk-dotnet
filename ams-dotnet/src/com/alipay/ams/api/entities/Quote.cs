using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Quote
    {
        public Quote() { }

        [JsonPropertyNameAttribute("guaranteed")]
        public bool Guaranteed { get; set; }

        [JsonPropertyNameAttribute("quoteCurrencyPair")]
        public string QuoteCurrencyPair { get; set; }

        [JsonPropertyNameAttribute("quotePrice")]
        public decimal QuotePrice { get; set; }

    }
}
