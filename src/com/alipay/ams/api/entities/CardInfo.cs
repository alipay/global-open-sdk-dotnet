    
namespace com.alipay.ams.api.entities
{

public class CardInfo
    {

        public CardInfo() { }

        public CardInfo( string cardNo , string cardBrand , string cardToken , string issuingCountry , string funding , string paymentMethodRegion , ThreeDSResult threeDSResult)
        {
            this.CardNo = cardNo;
            this.CardBrand = cardBrand;
            this.CardToken = cardToken;
            this.IssuingCountry = issuingCountry;
            this.Funding = funding;
            this.PaymentMethodRegion = paymentMethodRegion;
            this.ThreeDSResult = threeDSResult;
        }

            public string CardNo { get; set; }
            public string CardBrand { get; set; }
            public string CardToken { get; set; }
            public string IssuingCountry { get; set; }
            public string Funding { get; set; }
            public string PaymentMethodRegion { get; set; }
            public ThreeDSResult ThreeDSResult { get; set; }

        

    }

}
