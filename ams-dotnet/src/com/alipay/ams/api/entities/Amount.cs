

namespace com.alipay.ams.api.entities
{
    public class Amount
    {
        public Amount() { }


        public string Currency { get; set; }


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