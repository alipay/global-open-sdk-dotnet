namespace com.alipay.ams.api.entities
{
    public class AmountLimit
    {
        public Amount MaxAmount {get;set;}
        public Amount MinAmount {get;set;}
        public Amount RemainAmount {get;set;}
    }
}