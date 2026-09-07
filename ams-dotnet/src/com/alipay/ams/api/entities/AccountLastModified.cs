using System;
using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{

public class AccountLastModified
    {

        public AccountLastModified() { }



        public AccountLastModified( string passwordChangeDate , string emailChangeDate , string listingChangeDate , string loginDate , string addressChangeDate)
        {
            this.PasswordChangeDate = passwordChangeDate;
            this.EmailChangeDate = emailChangeDate;
            this.ListingChangeDate = listingChangeDate;
            this.LoginDate = loginDate;
            this.AddressChangeDate = addressChangeDate;
        }

            public string PasswordChangeDate { get; set; }
            public string EmailChangeDate { get; set; }
            public string ListingChangeDate { get; set; }
            public string LoginDate { get; set; }
            public string AddressChangeDate { get; set; }



    }

}
