using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceCustomerDetails
    {

        public InvoiceCustomerDetails() { }

        

        public InvoiceCustomerDetails( string email , string customerType , string businessName , string firstName , string lastName , CustomerBusinessAddress businessAddress , string preferredLocales , List<BuyerTaxId> taxIds)
        {
            this.Email = email;
            this.CustomerType = customerType;
            this.BusinessName = businessName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BusinessAddress = businessAddress;
            this.PreferredLocales = preferredLocales;
            this.TaxIds = taxIds;
        }

            public string Email { get; set; }
            public string CustomerType { get; set; }
            public string BusinessName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public CustomerBusinessAddress BusinessAddress { get; set; }
            public string PreferredLocales { get; set; }
            public List<BuyerTaxId> TaxIds { get; set; }

        

    }

}
