namespace com.alipay.ams.api.entities
{
    public class CardVerificationResult
    {
        public string AuthenticationType { get; set; }
        
        public string AuthenticationMethod { get; set; }
        
        public string CvvResult { get; set; }
        
        public string AvsResult { get; set; }
        
        public string AuthorizationCode { get; set; }
        
        public RiskThreeDSResult ThreeDSResult { get; set; }
    }
}