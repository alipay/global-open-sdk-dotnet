using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardPaymentPreference
    {

        public CardPaymentPreference() { }

        

        public CardPaymentPreference( List<string> currencyOrder)
        {
            this.CurrencyOrder = currencyOrder;
        }

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
            public List<string> CurrencyOrder { get; set; }

        

    }

}
