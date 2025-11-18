using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Transit
    {

        public Transit() { }

        

        public Transit( TransitType transitType , List<Leg> legs , List<Passenger> passengers , string agentCode , string agentName , string ticketNumber , string ticketIssuerCode , string restrictedTicketIndicator , AncillaryData ancillaryData)
        {
            this.TransitType = transitType;
            this.Legs = legs;
            this.Passengers = passengers;
            this.AgentCode = agentCode;
            this.AgentName = agentName;
            this.TicketNumber = ticketNumber;
            this.TicketIssuerCode = ticketIssuerCode;
            this.RestrictedTicketIndicator = restrictedTicketIndicator;
            this.AncillaryData = ancillaryData;
        }

            public TransitType TransitType { get; set; }
            public List<Leg> Legs { get; set; }
            public List<Passenger> Passengers { get; set; }
            public string AgentCode { get; set; }
            public string AgentName { get; set; }
            public string TicketNumber { get; set; }
            public string TicketIssuerCode { get; set; }
            public string RestrictedTicketIndicator { get; set; }
            public AncillaryData AncillaryData { get; set; }

        

    }

}
