    
namespace com.alipay.ams.api.entities
{

public class Leg
    {

        public Leg() { }

        public Leg( string departureTime , string arrivalTime , Address departureAddress , Address arrivalAddress , string carrierName , string carrierNo , ClassType classType , string departureAirportCode , string arrivalAirportCode)
        {
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.DepartureAddress = departureAddress;
            this.ArrivalAddress = arrivalAddress;
            this.CarrierName = carrierName;
            this.CarrierNo = carrierNo;
            this.ClassType = classType;
            this.DepartureAirportCode = departureAirportCode;
            this.ArrivalAirportCode = arrivalAirportCode;
        }

            public string DepartureTime { get; set; }
            public string ArrivalTime { get; set; }
            public Address DepartureAddress { get; set; }
            public Address ArrivalAddress { get; set; }
            public string CarrierName { get; set; }
            public string CarrierNo { get; set; }
            public ClassType ClassType { get; set; }
            public string DepartureAirportCode { get; set; }
            public string ArrivalAirportCode { get; set; }

        

    }

}
