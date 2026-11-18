using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedCustomerDetails
    {

        public TaxCalculatedCustomerDetails() { }

        

        public TaxCalculatedCustomerDetails( TaxCalculatedBusinessDetails businessDetails , string name , TaxCalculatedAddress shippingAddress , TaxCalculatedAddress billingAddress , List<TaxCalculatedTaxId> taxIds , List<TaxCalculatedExemption> taxExemptions)
        {
            this.BusinessDetails = businessDetails;
            this.Name = name;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
            this.TaxIds = taxIds;
            this.TaxExemptions = taxExemptions;
        }

            public TaxCalculatedBusinessDetails BusinessDetails { get; set; }
            public string Name { get; set; }
            public TaxCalculatedAddress ShippingAddress { get; set; }
            public TaxCalculatedAddress BillingAddress { get; set; }
            public List<TaxCalculatedTaxId> TaxIds { get; set; }
            public List<TaxCalculatedExemption> TaxExemptions { get; set; }

        

    }

}
