using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Applicability
    {

        public Applicability() { }

        

        public Applicability( string scope , string priceIds)
        {
            this.Scope = scope;
            this.PriceIds = priceIds;
        }

            public string Scope { get; set; }
            public string PriceIds { get; set; }

        

    }

}
