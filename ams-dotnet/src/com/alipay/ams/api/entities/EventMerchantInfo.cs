using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class EventMerchantInfo
    {

        public EventMerchantInfo() { }

        

        public EventMerchantInfo( string name , string region , string mcc)
        {
            this.Name = name;
            this.Region = region;
            this.Mcc = mcc;
        }

            public string Name { get; set; }
            public string Region { get; set; }
            public string Mcc { get; set; }

        

    }

}
