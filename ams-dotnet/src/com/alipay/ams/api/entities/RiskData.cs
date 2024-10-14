namespace com.alipay.ams.api.entities
{
    public class RiskData
    {
        private RiskOrder Order { get; set; }

        private RiskBuyer Buyer { get; set; }
        
        private RiskEnv Env { get; set; }
        
        private RiskSignal RiskSignal { get; set; }
        
        private RiskAddress Address { get; set; }
        
        private CardVerificationResult CardVerificationResult { get; set; }
    }
}