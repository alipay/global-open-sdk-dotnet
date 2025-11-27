using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthMetaData
    {

        public AuthMetaData() { }

        

        public AuthMetaData( string accountHolderName , string accountHolderCertNo)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountHolderCertNo = accountHolderCertNo;
        }

            public string AccountHolderName { get; set; }
            public string AccountHolderCertNo { get; set; }

        

    }

}
