using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAmount
    {

        public AgenticAmount() { }

        

        public AgenticAmount( string currency , string value)
        {
            this.Currency = currency;
            this.Value = value;
        }

            public string Currency { get; set; }
            public string Value { get; set; }

        

    }

}
