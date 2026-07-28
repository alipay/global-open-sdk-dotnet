using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxHeadOffice
    {

        public TaxHeadOffice() { }

        

        public TaxHeadOffice( TaxAddress address)
        {
            this.Address = address;
        }

            public TaxAddress Address { get; set; }

        

    }

}
