using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AutomaticTax
    {

        public AutomaticTax() { }

        

        public AutomaticTax( bool? enabled)
        {
            this.Enabled = enabled;
        }

            public bool? Enabled { get; set; }

        

    }

}
