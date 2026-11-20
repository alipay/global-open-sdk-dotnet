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

            public List<string> CurrencyOrder { get; set; }

        

    }

}
