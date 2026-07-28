using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class EventPayload
    {

        public EventPayload() { }

        

        public EventPayload( string value , string customerId)
        {
            this.Value = value;
            this.CustomerId = customerId;
        }

            public string Value { get; set; }
            public string CustomerId { get; set; }

        

    }

}
