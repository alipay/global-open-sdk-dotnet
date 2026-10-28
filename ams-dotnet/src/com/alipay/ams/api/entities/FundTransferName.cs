using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferName
    {

        public FundTransferName() { }

        

        public FundTransferName( string firstName , string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

            public string FirstName { get; set; }
            public string LastName { get; set; }

        

    }

}
