using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCustomerDetails
    {

        public TaxCustomerDetails() { }

        

        public TaxCustomerDetails( string name , TaxBusinessDetails businessDetails , TaxAddress shippingAddress , TaxAddress billingAddress , List<TaxId> taxIds)
        {
            this.Name = name;
            this.BusinessDetails = businessDetails;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
            this.TaxIds = taxIds;
        }

            public string Name { get; set; }
            public TaxBusinessDetails BusinessDetails { get; set; }
            public TaxAddress ShippingAddress { get; set; }
            public TaxAddress BillingAddress { get; set; }
            public List<TaxId> TaxIds { get; set; }

        

    }

}
