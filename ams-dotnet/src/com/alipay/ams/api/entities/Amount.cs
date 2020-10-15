using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Amount
    {
        public Amount() { }

        [JsonPropertyNameAttribute("currency")]
        public string Currency { get; set; }

        [JsonPropertyNameAttribute("value")]
        public string Value { get; set; }

        public Amount(string currency, string amountInCents)
        {
            this.Currency = currency;
            this.Value = amountInCents;
        }
        public Amount(string currency, long amountInCents)
        {
            this.Currency = currency;
            this.Value = amountInCents.ToString();
        }
    }
}