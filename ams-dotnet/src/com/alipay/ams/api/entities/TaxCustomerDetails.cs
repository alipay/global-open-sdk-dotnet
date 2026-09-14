using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCustomerDetails
    {

        public TaxCustomerDetails() { }

        

        public TaxCustomerDetails( TaxBusinessDetails businessDetails , string name , TaxAddress shippingAddress , TaxAddress billingAddress , List<TaxId> taxIds , List<TaxExemption> taxExemptions)
        {
            this.BusinessDetails = businessDetails;
            this.Name = name;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
            this.TaxIds = taxIds;
            this.TaxExemptions = taxExemptions;
        }

            public TaxBusinessDetails BusinessDetails { get; set; }
            public string Name { get; set; }
            public TaxAddress ShippingAddress { get; set; }
            public TaxAddress BillingAddress { get; set; }
            public List<TaxId> TaxIds { get; set; }
            public List<TaxExemption> TaxExemptions { get; set; }

        

    }

}
