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
        public string AccountNo  { get; set; }
        public string RefusalCodeRaw  { get; set; }
        public string RefusalReasonRaw  { get; set; }
        public string MerchantAdviceCode  { get; set; }
        public AcquirerInfo AcquirerInfo  { get; set; }
        public string ExemptionRequested { get; set; }
        public string CardCategory { get; set; }
        public string CredentialTypeUsed { get; set; }


    }
}