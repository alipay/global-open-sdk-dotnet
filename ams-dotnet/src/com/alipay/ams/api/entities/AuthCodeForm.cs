using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthCodeForm
    {

        public AuthCodeForm() { }

        

        public AuthCodeForm( CodeDetail[] codeDetails)
        {
            this.CodeDetails = codeDetails;
        }

            public CodeDetail[] CodeDetails { get; set; }

        

    }

}
