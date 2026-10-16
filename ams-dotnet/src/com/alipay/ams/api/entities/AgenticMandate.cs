using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticMandate
    {

        public AgenticMandate() { }

        

        public AgenticMandate( string mandateId , AgenticMandateIntent intent , Order order)
        {
            this.MandateId = mandateId;
            this.Intent = intent;
            this.Order = order;
        }

            public string MandateId { get; set; }
            public AgenticMandateIntent Intent { get; set; }
            public Order Order { get; set; }

        

    }

}
