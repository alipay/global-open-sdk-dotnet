using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerInquireListRequest : AMSRequest<AlipayCustomerInquireListResponse>
    {

        public AlipayCustomerInquireListRequest() { }

        

        public AlipayCustomerInquireListRequest( string startingAfter , string endingBefore , int? limit , bool? includeTotal , string status , string email , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode)
        {
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
            this.Status = status;
            this.Email = email;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
        }

            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }
            public string Status { get; set; }
            public string Email { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/inquireList"; } 


    }

}
