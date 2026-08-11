using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerInquireDetailsResponse : AMSResponse
    {

        public AlipayCustomerInquireDetailsResponse() { }

        

        public AlipayCustomerInquireDetailsResponse( Result result , string customerId , string customerRequestId , string alipayUserId , string email , string firstName , string lastName , string country , string state , string city , string address , string addressDetail , string zipcode , string shippingPhone , string shippingCountry , string shippingState , string shippingCity , string shippingAddress , string shippingAddressDetail , string description , string currency , List<string> preferredLocales , string defaultPaymentMethod , string status , string referenceCustomerId , string metadata , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode , string shippingZipcode , string gmtCreate)
        {
            this.Result = result;
            this.CustomerId = customerId;
            this.CustomerRequestId = customerRequestId;
            this.AlipayUserId = alipayUserId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.AddressDetail = addressDetail;
            this.Zipcode = zipcode;
            this.ShippingPhone = shippingPhone;
            this.ShippingCountry = shippingCountry;
            this.ShippingState = shippingState;
            this.ShippingCity = shippingCity;
            this.ShippingAddress = shippingAddress;
            this.ShippingAddressDetail = shippingAddressDetail;
            this.Description = description;
            this.Currency = currency;
            this.PreferredLocales = preferredLocales;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Status = status;
            this.ReferenceCustomerId = referenceCustomerId;
            this.Metadata = metadata;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
            this.ShippingZipcode = shippingZipcode;
            this.GmtCreate = gmtCreate;
        }

            public Result Result { get; set; }
            public string CustomerId { get; set; }
            public string CustomerRequestId { get; set; }
            public string AlipayUserId { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string AddressDetail { get; set; }
            public string Zipcode { get; set; }
            public string ShippingPhone { get; set; }
            public string ShippingCountry { get; set; }
            public string ShippingState { get; set; }
            public string ShippingCity { get; set; }
            public string ShippingAddress { get; set; }
            public string ShippingAddressDetail { get; set; }
            public string Description { get; set; }
            public string Currency { get; set; }
            public List<string> PreferredLocales { get; set; }
            public string DefaultPaymentMethod { get; set; }
            public string Status { get; set; }
            public string ReferenceCustomerId { get; set; }
            public string Metadata { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }
            public string ShippingZipcode { get; set; }
            public string GmtCreate { get; set; }

        

    }

}
