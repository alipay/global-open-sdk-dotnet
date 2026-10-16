using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAccountInfoAgent
    {

        public AgenticAccountInfoAgent() { }

        

        public AgenticAccountInfoAgent( string agentId)
        {
            this.AgentId = agentId;
        }

            public string AgentId { get; set; }

        

    }

}
