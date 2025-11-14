using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Gaming
    {

        public Gaming() { }

        

        public Gaming( string gameName , string toppedUpUser , string toppedUpEmail , string toppedUpPhoneNo)
        {
            this.GameName = gameName;
            this.ToppedUpUser = toppedUpUser;
            this.ToppedUpEmail = toppedUpEmail;
            this.ToppedUpPhoneNo = toppedUpPhoneNo;
        }

            public string GameName { get; set; }
            public string ToppedUpUser { get; set; }
            public string ToppedUpEmail { get; set; }
            public string ToppedUpPhoneNo { get; set; }

        

    }

}
