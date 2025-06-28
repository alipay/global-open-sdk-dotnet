    
namespace com.alipay.ams.api.entities
{

public class Amount
    {

        public Amount() { }

        public Amount( string currency , string value)
        {
            this.Currency = currency;
            this.Value = value;
        }

            public string Currency { get; set; }
            public string Value { get; set; }

        

    }

}
