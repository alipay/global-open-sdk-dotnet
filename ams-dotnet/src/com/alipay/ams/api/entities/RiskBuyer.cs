namespace com.alipay.ams.api.entities
{
    public class RiskBuyer
    {
        public string NoteToMerchant {get;set;}
        
        public string NoteToShipping {get;set;}
        
        public int OrderCountIn1H {get;set;}
        
        public int OrderCountIn24H {get;set;}
    }
}