using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Minimum
    {

        public Minimum() { }

        

        public Minimum( string unit , int? value)
        {
            this.Unit = unit;
            this.Value = value;
        }

            public string Unit { get; set; }
            public int? Value { get; set; }

        

    }

}
