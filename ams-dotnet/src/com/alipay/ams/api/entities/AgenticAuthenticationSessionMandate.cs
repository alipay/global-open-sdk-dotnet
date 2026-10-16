using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAuthenticationSessionMandate
    {

        public AgenticAuthenticationSessionMandate() { }

        

        public AgenticAuthenticationSessionMandate( string mandateId , AgenticAuthenticationSessionMandateIntent intent , AgenticAuthenticationSessionMandateOrder order)
        {
            this.MandateId = mandateId;
            this.Intent = intent;
            this.Order = order;
        }

            public string MandateId { get; set; }
            public AgenticAuthenticationSessionMandateIntent Intent { get; set; }
            public AgenticAuthenticationSessionMandateOrder Order { get; set; }

        

    }

}
