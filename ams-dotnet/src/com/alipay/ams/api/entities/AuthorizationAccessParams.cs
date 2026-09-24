using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationAccessParams
    {

        public AuthorizationAccessParams() { }

        

        public AuthorizationAccessParams( string channel)
        {
            this.Channel = channel;
        }

            public string Channel { get; set; }

        

    }

}
