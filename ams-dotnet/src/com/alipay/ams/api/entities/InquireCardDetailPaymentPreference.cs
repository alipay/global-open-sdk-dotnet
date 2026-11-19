using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquireCardDetailPaymentPreference
    {

        public InquireCardDetailPaymentPreference() { }

        

        public InquireCardDetailPaymentPreference( List<string> currencyOrder)
        {
            this.CurrencyOrder = currencyOrder;
        }

            public List<string> CurrencyOrder { get; set; }

        

    }

}
