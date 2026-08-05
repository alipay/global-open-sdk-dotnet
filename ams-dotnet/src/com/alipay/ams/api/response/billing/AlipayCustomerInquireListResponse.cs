using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerInquireListResponse : AMSResponse
    {

        public AlipayCustomerInquireListResponse() { }

        

        public AlipayCustomerInquireListResponse( Result result , List<Customer> customers , int? total , bool? hasMore , string nextCursor , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode)
        {
            this.Result = result;
            this.Customers = customers;
            this.Total = total;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
        }

            public Result Result { get; set; }
            public List<Customer> Customers { get; set; }
            public int? Total { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }

        

    }

}
