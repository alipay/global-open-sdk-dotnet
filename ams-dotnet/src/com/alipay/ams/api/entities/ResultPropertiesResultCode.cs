using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ResultPropertiesResultCode
    {

        public ResultPropertiesResultCode() { }

        

        public ResultPropertiesResultCode( string type , string description)
        {
            this.Type = type;
            this.Description = description;
        }

            public string Type { get; set; }
            public string Description { get; set; }

        

    }

}
