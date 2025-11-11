    
namespace com.alipay.ams.api.entities
{

public class RiskAddress
    {

        public RiskAddress() { }

        public RiskAddress( string shippingPhoneType , bool? isBillShipStateSame , bool? isPreviousStateSame , int? locToShipDistance , int? minPreviousShipToBillDistance)
        {
            this.ShippingPhoneType = shippingPhoneType;
            this.IsBillShipStateSame = isBillShipStateSame;
            this.IsPreviousStateSame = isPreviousStateSame;
            this.LocToShipDistance = locToShipDistance;
            this.MinPreviousShipToBillDistance = minPreviousShipToBillDistance;
        }

            public string ShippingPhoneType { get; set; }
            public bool? IsBillShipStateSame { get; set; }
            public bool? IsPreviousStateSame { get; set; }
            public int? LocToShipDistance { get; set; }
            public int? MinPreviousShipToBillDistance { get; set; }

        

    }

}
