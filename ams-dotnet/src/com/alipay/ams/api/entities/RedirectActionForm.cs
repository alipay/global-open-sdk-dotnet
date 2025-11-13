using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RedirectActionForm
    {

        public RedirectActionForm() { }

        

        public RedirectActionForm(  string  method ,  string  parameters ,  string  redirectUrl ,  string  actionFormType)
        {
            this.Method = method;
            this.Parameters = parameters;
            this.RedirectUrl = redirectUrl;
            this.ActionFormType = actionFormType;
        }

            public  string  Method { get; set; }
            public  string  Parameters { get; set; }
            public  string  RedirectUrl { get; set; }
            public  string  ActionFormType { get; set; }

        

    }

}
