using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BrowserInfo
    {

        public BrowserInfo() { }

        

        public BrowserInfo(  string  acceptHeader ,  bool?  javaEnabled ,  bool?  javaScriptEnabled ,  string  language ,  string  userAgent)
        {
            this.AcceptHeader = acceptHeader;
            this.JavaEnabled = javaEnabled;
            this.JavaScriptEnabled = javaScriptEnabled;
            this.Language = language;
            this.UserAgent = userAgent;
        }

            public  string  AcceptHeader { get; set; }
            public  bool?  JavaEnabled { get; set; }
            public  bool?  JavaScriptEnabled { get; set; }
            public  string  Language { get; set; }
            public  string  UserAgent { get; set; }

        

    }

}
