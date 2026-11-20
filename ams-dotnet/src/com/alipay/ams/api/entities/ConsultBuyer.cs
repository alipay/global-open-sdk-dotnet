using System.Collections.Generic;
namespace com.alipay.ams.api.entities
{
    /// <summary>Consult Buyer with an optional Kwai-Bettr string access-group flag.</summary>
    public class ConsultBuyer : Buyer
    {
        public ConsultBuyer() { }
        /// <summary>Kwai-Bettr consult flag: string "true" or "false"; other merchants omit it.</summary>
        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
        public string BuyerAccessGroupFlag { get; set; }
        public ConsultBuyer(List<string> preferredLocales , string businessName , string buyerType , string referenceBuyerId , UserName buyerName , string buyerPhoneNo , string buyerEmail , string buyerRegistrationTime , bool? isAccountVerified , int? successfulOrderCount , string buyerPhoneNoContryCode , Amount successfulOrderAmount , string dateOfLastPaidPurchase , string dateOfFirstPaidPurchase , List<BuyerTaxId> taxIds , Address businessAddress, string buyerAccessGroupFlag) : base(preferredLocales, businessName, buyerType, referenceBuyerId, buyerName, buyerPhoneNo, buyerEmail, buyerRegistrationTime, isAccountVerified, successfulOrderCount, buyerPhoneNoContryCode, successfulOrderAmount, dateOfLastPaidPurchase, dateOfFirstPaidPurchase, taxIds, businessAddress)
        { BuyerAccessGroupFlag = buyerAccessGroupFlag; }
    }
}
