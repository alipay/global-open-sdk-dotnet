using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerUpdateResponse : AMSResponse
    {

        public AlipayCustomerUpdateResponse() { }

        

        public AlipayCustomerUpdateResponse( Result result , string customerId , string status , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode)
        {
            this.Result = result;
            this.CustomerId = customerId;
            this.Status = status;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
        }

            public Result Result { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }

        

    }

}
