using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Tier
    {

        public Tier() { }

        

        public Tier( int? upTo , Amount unitAmount , Amount flatAmount)
        {
            this.UpTo = upTo;
            this.UnitAmount = unitAmount;
            this.FlatAmount = flatAmount;
        }

            public int? UpTo { get; set; }
            public Amount UnitAmount { get; set; }
            public Amount FlatAmount { get; set; }

        

    }

}
