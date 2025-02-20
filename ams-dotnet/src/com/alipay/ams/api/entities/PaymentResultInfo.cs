namespace com.alipay.ams.api.entities
{
    public class PaymentResultInfo
    {
        public string CardNo  { get; set; }

        public string CardBrand  { get; set; }

        public string CardToken  { get; set; }

        public string IssuingCountry  { get; set; }

        public string Funding  { get; set; }

        public string PaymentMethodRegion  { get; set; }

        public ThreeDSResult ThreeDSResult  { get; set; }

        public string AvsResultRaw  { get; set; }

        public string CvvResultRaw  { get; set; }
        
        public string NetworkTransactionId  { get; set; }
        
        public CreditPayPlan CreditPayPlan  { get; set; }
        
        public string CardholderName  { get; set; }

        public string CardBin  { get; set; }

        public string LastFour  { get; set; }

        public string ExpiryMonth  { get; set; }

        public string ExpiryYear  { get; set; }
    }
}