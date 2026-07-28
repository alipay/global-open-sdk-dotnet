using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxBusinessDetails
    {

        public TaxBusinessDetails() { }

        

        public TaxBusinessDetails( TaxAddress address)
        {
            this.Address = address;
        }

            public TaxAddress Address { get; set; }

        

    }

}
