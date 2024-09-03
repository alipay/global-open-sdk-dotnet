namespace com.alipay.ams.api.entities
{
    public class RiskThreeDSResult
    {
        public string ThreeDSVersion { get; set; }
        
        public string ThreeDSInteractionMode { get; set; }

        public string Eci { get; set; }

        public string Cavv { get; set; }
    }
}