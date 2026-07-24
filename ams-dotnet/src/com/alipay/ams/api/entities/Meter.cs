using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Meter
    {

        public Meter() { }

        

        public Meter( string eventName , List<Event> events)
        {
            this.EventName = eventName;
            this.Events = events;
        }

            public string EventName { get; set; }
            public List<Event> Events { get; set; }

        

    }

}
