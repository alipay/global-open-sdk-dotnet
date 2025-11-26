using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AmountLimit
    {

        public AmountLimit() { }

        

        public AmountLimit( Amount maxAmount , Amount minAmount , Amount remainAmount)
        {
            this.MaxAmount = maxAmount;
            this.MinAmount = minAmount;
            this.RemainAmount = remainAmount;
        }

            public Amount MaxAmount { get; set; }
            public Amount MinAmount { get; set; }
            public Amount RemainAmount { get; set; }

        

    }

}
