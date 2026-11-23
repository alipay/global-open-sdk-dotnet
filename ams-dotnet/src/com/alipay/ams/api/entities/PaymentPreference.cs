using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentPreference
    {

        public PaymentPreference() { }

        

        public PaymentPreference( List<string> currencyOrder)
        {
            this.CurrencyOrder = currencyOrder;
        }

            public List<string> CurrencyOrder { get; set; }

        

    }

}
