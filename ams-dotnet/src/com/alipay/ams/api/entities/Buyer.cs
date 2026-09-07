using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Buyer
    {

        public Buyer() { }

        

        public Buyer( string referenceBuyerId , UserName buyerName , string buyerPhoneNo , string buyerEmail , string buyerRegistrationTime , bool? isAccountVerified , int? successfulOrderCount , string buyerPhoneNoContryCode , Amount successfulOrderAmount , string dateOfLastPaidPurchase , string dateOfFirstPaidPurchase)
        {
            this.ReferenceBuyerId = referenceBuyerId;
            this.BuyerName = buyerName;
            this.BuyerPhoneNo = buyerPhoneNo;
            this.BuyerEmail = buyerEmail;
            this.BuyerRegistrationTime = buyerRegistrationTime;
            this.IsAccountVerified = isAccountVerified;
            this.SuccessfulOrderCount = successfulOrderCount;
            this.BuyerPhoneNoContryCode = buyerPhoneNoContryCode;
            this.SuccessfulOrderAmount = successfulOrderAmount;
            this.DateOfLastPaidPurchase = dateOfLastPaidPurchase;
            this.DateOfFirstPaidPurchase = dateOfFirstPaidPurchase;
        }

            public string ReferenceBuyerId { get; set; }
            public UserName BuyerName { get; set; }
            public string BuyerPhoneNo { get; set; }
            public string BuyerEmail { get; set; }
            public string BuyerRegistrationTime { get; set; }
            public bool? IsAccountVerified { get; set; }
            public int? SuccessfulOrderCount { get; set; }
            public string BuyerPhoneNoContryCode { get; set; }
            public Amount SuccessfulOrderAmount { get; set; }
            public string DateOfLastPaidPurchase { get; set; }
            public string DateOfFirstPaidPurchase { get; set; }

        

    }

}
