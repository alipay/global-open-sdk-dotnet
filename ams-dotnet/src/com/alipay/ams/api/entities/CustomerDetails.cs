using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CustomerDetails
    {

        public CustomerDetails() { }

        

        public CustomerDetails( string fullName , CustomerAddress billingAddress , CustomerAddress shippingAddress , string customerType , string businessName , CustomerAddress businessAddress , List<CustomerTaxId> taxIds)
        {
            this.FullName = fullName;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.CustomerType = customerType;
            this.BusinessName = businessName;
            this.BusinessAddress = businessAddress;
            this.TaxIds = taxIds;
        }

            public string FullName { get; set; }
            public CustomerAddress BillingAddress { get; set; }
            public CustomerAddress ShippingAddress { get; set; }
            public string CustomerType { get; set; }
            public string BusinessName { get; set; }
            public CustomerAddress BusinessAddress { get; set; }
            public List<CustomerTaxId> TaxIds { get; set; }

        

    }

}
