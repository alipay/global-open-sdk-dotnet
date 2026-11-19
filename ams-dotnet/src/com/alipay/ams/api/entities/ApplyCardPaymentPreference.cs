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

            public List<string> CurrencyOrder { get; set; }

        

    }

}
