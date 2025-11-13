using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AmountLimit
    {

        public AmountLimit() { }

        

        public AmountLimit(  string  maxAmount ,  string  minAmount ,  string  remainAmount)
        {
            this.MaxAmount = maxAmount;
            this.MinAmount = minAmount;
            this.RemainAmount = remainAmount;
        }

            public  string  MaxAmount { get; set; }
            public  string  MinAmount { get; set; }
            public  string  RemainAmount { get; set; }

        

    }

}
