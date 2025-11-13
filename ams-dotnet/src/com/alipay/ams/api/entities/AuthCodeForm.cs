using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthCodeForm
    {

        public AuthCodeForm() { }

        

        public AuthCodeForm(  List<CodeDetail>  codeDetails)
        {
            this.CodeDetails = codeDetails;
        }

            public  List<CodeDetail>  CodeDetails { get; set; }

        

    }

}
