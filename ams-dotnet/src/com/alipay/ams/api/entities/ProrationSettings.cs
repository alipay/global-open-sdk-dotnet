using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ProrationSettings
    {

        public ProrationSettings() { }

        

        public ProrationSettings( string prorationMode , Amount customAmount)
        {
            this.ProrationMode = prorationMode;
            this.CustomAmount = customAmount;
        }

            public string ProrationMode { get; set; }
            public Amount CustomAmount { get; set; }

        

    }

}
