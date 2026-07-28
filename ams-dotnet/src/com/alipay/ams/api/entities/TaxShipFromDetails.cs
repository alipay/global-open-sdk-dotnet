using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxShipFromDetails
    {

        public TaxShipFromDetails() { }

        

        public TaxShipFromDetails( TaxAddress address)
        {
            this.Address = address;
        }

            public TaxAddress Address { get; set; }

        

    }

}
