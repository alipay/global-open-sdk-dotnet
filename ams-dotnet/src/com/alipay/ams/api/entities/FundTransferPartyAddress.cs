using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferPartyAddress
    {

        public FundTransferPartyAddress() { }

        

        public FundTransferPartyAddress( string address1 , string city , string state , string region)
        {
            this.Address1 = address1;
            this.City = city;
            this.State = state;
            this.Region = region;
        }

            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Region { get; set; }

        

    }

}
