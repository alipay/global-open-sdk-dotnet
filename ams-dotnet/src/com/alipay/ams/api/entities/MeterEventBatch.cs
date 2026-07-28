using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class MeterEventBatch
    {

        public MeterEventBatch() { }

        

        public MeterEventBatch( string eventName , List<Event> events)
        {
            this.EventName = eventName;
            this.Events = events;
        }

            public string EventName { get; set; }
            public List<Event> Events { get; set; }

        

    }

}
