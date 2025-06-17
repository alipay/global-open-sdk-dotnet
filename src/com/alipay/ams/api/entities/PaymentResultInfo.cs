    
namespace com.alipay.ams.api.entities
{

public class PaymentResultInfo
    {

        public PaymentResultInfo() { }

        public PaymentResultInfo( string cardNo , string cardBrand , string cardToken , string issuingCountry , string funding , string paymentMethodRegion , ThreeDSResult threeDSResult , string avsResultRaw , string cvvResultRaw , string networkTransactionId , CreditPayPlan creditPayPlan , string cardholderName , string cardBin , string lastFour , string expiryMonth , string expiryYear)
        {
            this.CardNo = cardNo;
            this.CardBrand = cardBrand;
            this.CardToken = cardToken;
            this.IssuingCountry = issuingCountry;
            this.Funding = funding;
            this.PaymentMethodRegion = paymentMethodRegion;
            this.ThreeDSResult = threeDSResult;
            this.AvsResultRaw = avsResultRaw;
            this.CvvResultRaw = cvvResultRaw;
            this.NetworkTransactionId = networkTransactionId;
            this.CreditPayPlan = creditPayPlan;
            this.CardholderName = cardholderName;
            this.CardBin = cardBin;
            this.LastFour = lastFour;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
        }

            public string CardNo { get; set; }
            public string CardBrand { get; set; }
            public string CardToken { get; set; }
            public string IssuingCountry { get; set; }
            public string Funding { get; set; }
            public string PaymentMethodRegion { get; set; }
            public ThreeDSResult ThreeDSResult { get; set; }
            public string AvsResultRaw { get; set; }
            public string CvvResultRaw { get; set; }
            public string NetworkTransactionId { get; set; }
            public CreditPayPlan CreditPayPlan { get; set; }
            public string CardholderName { get; set; }
            public string CardBin { get; set; }
            public string LastFour { get; set; }
            public string ExpiryMonth { get; set; }
            public string ExpiryYear { get; set; }

        

    }

}
