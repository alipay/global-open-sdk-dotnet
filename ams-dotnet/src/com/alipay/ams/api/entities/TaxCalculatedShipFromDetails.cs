using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedShipFromDetails
    {

        public TaxCalculatedShipFromDetails() { }

        

        public TaxCalculatedShipFromDetails( TaxCalculatedAddress address)
        {
            this.Address = address;
        }

            public TaxCalculatedAddress Address { get; set; }

        

    }

}
