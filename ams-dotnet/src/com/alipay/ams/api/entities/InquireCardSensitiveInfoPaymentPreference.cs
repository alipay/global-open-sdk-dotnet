using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquireCardSensitiveInfoPaymentPreference
    {

        public InquireCardSensitiveInfoPaymentPreference() { }

        

        public InquireCardSensitiveInfoPaymentPreference( List<string> currencyOrder)
        {
            this.CurrencyOrder = currencyOrder;
        }

            public List<string> CurrencyOrder { get; set; }

        

    }

}
