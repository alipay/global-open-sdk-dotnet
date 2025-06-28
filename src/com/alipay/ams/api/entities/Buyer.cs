    
namespace com.alipay.ams.api.entities
{

public class Buyer
    {

        public Buyer() { }

        public Buyer( string referenceBuyerId , UserName buyerName , string buyerPhoneNo , string buyerEmail , string buyerRegistrationTime , bool? isAccountVerified , int? successfulOrderCount)
        {
            this.ReferenceBuyerId = referenceBuyerId;
            this.BuyerName = buyerName;
            this.BuyerPhoneNo = buyerPhoneNo;
            this.BuyerEmail = buyerEmail;
            this.BuyerRegistrationTime = buyerRegistrationTime;
            this.IsAccountVerified = isAccountVerified;
            this.SuccessfulOrderCount = successfulOrderCount;
        }

            public string ReferenceBuyerId { get; set; }
            public UserName BuyerName { get; set; }
            public string BuyerPhoneNo { get; set; }
            public string BuyerEmail { get; set; }
            public string BuyerRegistrationTime { get; set; }
            public bool? IsAccountVerified { get; set; }
            public int? SuccessfulOrderCount { get; set; }

        

    }

}
