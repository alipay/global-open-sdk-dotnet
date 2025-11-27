using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CodeDetail
    {

        public CodeDetail() { }

        

        public CodeDetail( CodeValueType codeValueType , string codeValue , DisplayType displayType)
        {
            this.CodeValueType = codeValueType;
            this.CodeValue = codeValue;
            this.DisplayType = displayType;
        }

            public CodeValueType CodeValueType { get; set; }
            public string CodeValue { get; set; }
            public DisplayType DisplayType { get; set; }

        

    }

}
