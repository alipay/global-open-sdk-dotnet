using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Meter
    {

        public Meter() { }

        

        public Meter( string meterId , string meterName , string eventName , string status , string aggregationMethod , string eventTimeWindow , string valueKeyOverride , string createdDateTime , string updatedDateTime)
        {
            this.MeterId = meterId;
            this.MeterName = meterName;
            this.EventName = eventName;
            this.Status = status;
            this.AggregationMethod = aggregationMethod;
            this.EventTimeWindow = eventTimeWindow;
            this.ValueKeyOverride = valueKeyOverride;
            this.CreatedDateTime = createdDateTime;
            this.UpdatedDateTime = updatedDateTime;
        }

            public string MeterId { get; set; }
            public string MeterName { get; set; }
            public string EventName { get; set; }
            public string Status { get; set; }
            public string AggregationMethod { get; set; }
            public string EventTimeWindow { get; set; }
            public string ValueKeyOverride { get; set; }
            public string CreatedDateTime { get; set; }
            public string UpdatedDateTime { get; set; }

        

    }

}
