using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Applicability
    {

        public Applicability() { }

        

        public Applicability( string scope , List<string> priceIds)
        {
            this.Scope = scope;
            this.PriceIds = priceIds;
        }

            public string Scope { get; set; }
            public List<string> PriceIds { get; set; }

        

    }

}
