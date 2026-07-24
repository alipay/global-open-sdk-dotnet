using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Event
    {

        public Event() { }

        

        public Event( string idempotencyKey , int? eventTimestamp , EventPayload payload)
        {
            this.IdempotencyKey = idempotencyKey;
            this.EventTimestamp = eventTimestamp;
            this.Payload = payload;
        }

            public string IdempotencyKey { get; set; }
            public int? EventTimestamp { get; set; }
            public EventPayload Payload { get; set; }

        

    }

}
