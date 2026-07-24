using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ErrorStack
    {

        public ErrorStack() { }

        

        public ErrorStack( string errorStack)
        {
            this._ErrorStack = errorStack;
        }

            public string _ErrorStack { get; set; }

        

    }

}
