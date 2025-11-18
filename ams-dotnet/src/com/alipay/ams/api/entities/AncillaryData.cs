using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AncillaryData
    {

        public AncillaryData() { }

        

        public AncillaryData( List<Service> services , string connectedTicketNumber)
        {
            this.Services = services;
            this.ConnectedTicketNumber = connectedTicketNumber;
        }

            public List<Service> Services { get; set; }
            public string ConnectedTicketNumber { get; set; }

        

    }

}
