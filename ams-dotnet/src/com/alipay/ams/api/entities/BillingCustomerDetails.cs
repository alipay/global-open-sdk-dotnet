using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingCustomerDetails
    {

        public BillingCustomerDetails() { }

        

        public BillingCustomerDetails( string fullName , string customerType , string businessName , CustomerAddress billingAddress , CustomerAddress shippingAddress , CustomerAddress businessAddress , List<CustomerTaxId> taxIds)
        {
            this.FullName = fullName;
            this.CustomerType = customerType;
            this.BusinessName = businessName;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.BusinessAddress = businessAddress;
            this.TaxIds = taxIds;
        }

            public string FullName { get; set; }
            public string CustomerType { get; set; }
            public string BusinessName { get; set; }
            public CustomerAddress BillingAddress { get; set; }
            public CustomerAddress ShippingAddress { get; set; }
            public CustomerAddress BusinessAddress { get; set; }
            public List<CustomerTaxId> TaxIds { get; set; }

        

    }

}
