using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAgentInfo
    {

        public AgenticAgentInfo() { }

        

        public AgenticAgentInfo( string agentId , string agentName , string agentUrl , string agentJwk)
        {
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.AgentUrl = agentUrl;
            this.AgentJwk = agentJwk;
        }

            public string AgentId { get; set; }
            public string AgentName { get; set; }
            public string AgentUrl { get; set; }
            public string AgentJwk { get; set; }

        

    }

}
