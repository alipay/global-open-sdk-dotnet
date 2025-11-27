using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ResultPropertiesResultStatus
    {

        public ResultPropertiesResultStatus() { }

        

        public ResultPropertiesResultStatus( string description , string _ref)
        {
            this.Description = description;
            this.Ref = _ref;
        }

            public string Description { get; set; }
            public string Ref { get; set; }

        

    }

}
