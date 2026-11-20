using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ApplyCardPaymentPreference
    {

        public ApplyCardPaymentPreference() { }

        

        public ApplyCardPaymentPreference( List<string> currencyOrder)
        {
            this.CurrencyOrder = currencyOrder;
        }

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
            public List<string> CurrencyOrder { get; set; }

        

    }

}
