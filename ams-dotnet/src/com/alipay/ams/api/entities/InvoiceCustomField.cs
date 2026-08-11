using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceCustomField
    {

        public InvoiceCustomField() { }

        

        public InvoiceCustomField( string label , string value)
        {
            this.Label = label;
            this.Value = value;
        }

            public string Label { get; set; }
            public string Value { get; set; }

        

    }

}
