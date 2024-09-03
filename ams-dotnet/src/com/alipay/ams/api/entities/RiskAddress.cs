using System;

namespace com.alipay.ams.api.entities
{
    public class RiskAddress
    {
        public string ShippingPhoneType { get; set; }
        
        public Boolean IsBillShipStateSame { get; set; }
        
        public Boolean IsPreviousStateSame { get; set; }
        
        public int LocToShipDistance { get; set; }
        
        public int MinPreviousShipToBillDistance { get; set; }
    }
}