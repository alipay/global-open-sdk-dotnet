using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticBoundPaymentMethodDetail
    {

        public AgenticBoundPaymentMethodDetail() { }

        

        public AgenticBoundPaymentMethodDetail( string cardBrand , string lastFour)
        {
            this.CardBrand = cardBrand;
            this.LastFour = lastFour;
        }

            public string CardBrand { get; set; }
            public string LastFour { get; set; }

        

    }

}
