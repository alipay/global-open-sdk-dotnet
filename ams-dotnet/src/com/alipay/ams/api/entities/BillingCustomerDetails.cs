using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingCustomerDetails
    {

        public BillingCustomerDetails() { }

        

        public BillingCustomerDetails( string fullName , string customerType , string businessName , BillingCustomerAddress billingAddress , BillingCustomerAddress shippingAddress , BillingCustomerAddress businessAddress , List<BillingCustomerTaxId> taxIds)
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
            public BillingCustomerAddress BillingAddress { get; set; }
            public BillingCustomerAddress ShippingAddress { get; set; }
            public BillingCustomerAddress BusinessAddress { get; set; }
            public List<BillingCustomerTaxId> TaxIds { get; set; }

        

    }

}
