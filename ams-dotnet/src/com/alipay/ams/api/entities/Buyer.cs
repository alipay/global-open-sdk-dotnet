using System;

namespace com.alipay.ams.api.entities
{
    public class Buyer
    {
        public string ReferenceBuyerId { get; set; }
        public UserName BuyerName { get; set; }
        public string BuyerPhoneNo  { get; set; }
        public string BuyerEmail  { get; set; }
        public string BuyerRegistrationTime { get; set; }

        public bool? IsAccountVerified  { get; set; }

        public Int64 SuccessfulOrderCount { get; set; }
    }
}