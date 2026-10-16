using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticBindingSessionMandate
    {

        public AgenticBindingSessionMandate() { }

        

        public AgenticBindingSessionMandate( string mandateId , AgenticBindingSessionMandateIntent intent , AgenticBindingSessionMandateOrder order)
        {
            this.MandateId = mandateId;
            this.Intent = intent;
            this.Order = order;
        }

            public string MandateId { get; set; }
            public AgenticBindingSessionMandateIntent Intent { get; set; }
            public AgenticBindingSessionMandateOrder Order { get; set; }

        

    }

}
