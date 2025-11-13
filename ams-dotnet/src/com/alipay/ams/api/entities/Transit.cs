using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Transit
    {

        public Transit() { }

        

        public Transit(  TransitType  transitType ,  List<Leg>  legs ,  List<Passenger>  passengers)
        {
            this.TransitType = transitType;
            this.Legs = legs;
            this.Passengers = passengers;
        }

            public  TransitType  TransitType { get; set; }
            public  List<Leg>  Legs { get; set; }
            public  List<Passenger>  Passengers { get; set; }

        

    }

}
