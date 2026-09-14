using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedBusinessDetails
    {

        public TaxCalculatedBusinessDetails() { }

        

        public TaxCalculatedBusinessDetails( TaxCalculatedAddress address)
        {
            this.Address = address;
        }

            public TaxCalculatedAddress Address { get; set; }

        

    }

}
