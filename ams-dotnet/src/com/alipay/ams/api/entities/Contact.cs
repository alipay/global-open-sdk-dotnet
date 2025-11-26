using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Contact
    {

        public Contact() { }

        

        public Contact( ContactType type , string info , string home , string work , string mobile)
        {
            this.Type = type;
            this.Info = info;
            this.Home = home;
            this.Work = work;
            this.Mobile = mobile;
        }

            public ContactType Type { get; set; }
            public string Info { get; set; }
            public string Home { get; set; }
            public string Work { get; set; }
            public string Mobile { get; set; }

        

    }

}
