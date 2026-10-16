using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPaymentTokenAgent
    {

        public AgenticPaymentTokenAgent() { }

        

        public AgenticPaymentTokenAgent( string agentId , string agentName , string agentUrl)
        {
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.AgentUrl = agentUrl;
        }

            public string AgentId { get; set; }
            public string AgentName { get; set; }
            public string AgentUrl { get; set; }

        

    }

}
