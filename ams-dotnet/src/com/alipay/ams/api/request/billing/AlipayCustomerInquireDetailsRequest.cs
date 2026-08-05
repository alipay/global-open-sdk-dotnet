using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerInquireDetailsRequest : AMSRequest<AlipayCustomerInquireDetailsResponse>
    {

        public AlipayCustomerInquireDetailsRequest() { }

        

        public AlipayCustomerInquireDetailsRequest( string customerId , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode)
        {
            this.CustomerId = customerId;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
        }

            public string CustomerId { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/inquireDetails"; } 


    }

}
