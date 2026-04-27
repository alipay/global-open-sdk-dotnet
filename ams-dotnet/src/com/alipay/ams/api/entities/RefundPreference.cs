using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RefundPreference
    {

        public RefundPreference() { }

        

        public RefundPreference( string preferenceType)
        {
            this.PreferenceType = preferenceType;
        }

            public string PreferenceType { get; set; }

        

    }

}
