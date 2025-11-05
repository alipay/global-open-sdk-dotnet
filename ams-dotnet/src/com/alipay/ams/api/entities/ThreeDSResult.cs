namespace com.alipay.ams.api.entities
{
    public class ThreeDSResult
    {
       public string ThreeDSVersion { get; set; }
       public string Eci  { get; set; }
       public string Cavv  { get; set; }
       public string DsTransactionId  { get; set; }
       public string Xid  { get; set; }
       public bool Challenged  { get; set; }
       public string ExemptionType  { get; set; }
       public bool ThreeDSOffered { get; set; }
    }
}