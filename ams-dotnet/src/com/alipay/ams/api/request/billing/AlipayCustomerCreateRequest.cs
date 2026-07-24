using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerCreateRequest : AMSRequest<AlipayCustomerCreateResponse>
    {

        public AlipayCustomerCreateRequest() { }

        

        public AlipayCustomerCreateRequest( string customerRequestId , string referenceCustomerId , string alipayUserId , string email , string firstName , string lastName , string mobileNo , string country , string state , string city , string address , string addressDetail , string zipcode , string shippingName , string shippingPhone , string shippingCountry , string shippingState , string shippingCity , string shippingAddress , string shippingAddressDetail , string shippingZipcode , string description , string currency , string preferredLocales , string defaultPaymentMethod , Dictionary<string, string> metadata)
        {
            this.CustomerRequestId = customerRequestId;
            this.ReferenceCustomerId = referenceCustomerId;
            this.AlipayUserId = alipayUserId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MobileNo = mobileNo;
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.AddressDetail = addressDetail;
            this.Zipcode = zipcode;
            this.ShippingName = shippingName;
            this.ShippingPhone = shippingPhone;
            this.ShippingCountry = shippingCountry;
            this.ShippingState = shippingState;
            this.ShippingCity = shippingCity;
            this.ShippingAddress = shippingAddress;
            this.ShippingAddressDetail = shippingAddressDetail;
            this.ShippingZipcode = shippingZipcode;
            this.Description = description;
            this.Currency = currency;
            this.PreferredLocales = preferredLocales;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Metadata = metadata;
        }

            public string CustomerRequestId { get; set; }
            public string ReferenceCustomerId { get; set; }
            public string AlipayUserId { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MobileNo { get; set; }
            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string AddressDetail { get; set; }
            public string Zipcode { get; set; }
            public string ShippingName { get; set; }
            public string ShippingPhone { get; set; }
            public string ShippingCountry { get; set; }
            public string ShippingState { get; set; }
            public string ShippingCity { get; set; }
            public string ShippingAddress { get; set; }
            public string ShippingAddressDetail { get; set; }
            public string ShippingZipcode { get; set; }
            public string Description { get; set; }
            public string Currency { get; set; }
            public string PreferredLocales { get; set; }
            public string DefaultPaymentMethod { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/create"; } 


    }

}
