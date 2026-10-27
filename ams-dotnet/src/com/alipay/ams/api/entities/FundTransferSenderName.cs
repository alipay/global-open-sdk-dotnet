using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferSenderName
    {

        public FundTransferSenderName() { }

        

        public FundTransferSenderName( string firstName , string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

            public string FirstName { get; set; }
            public string LastName { get; set; }

        

    }

}
