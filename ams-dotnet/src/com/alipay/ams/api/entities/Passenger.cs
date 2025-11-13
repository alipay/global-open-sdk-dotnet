using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Passenger
    {

        public Passenger() { }

        

        public Passenger(  UserName  passengerName ,  string  passengerEmail ,  string  passengerPhoneNo)
        {
            this.PassengerName = passengerName;
            this.PassengerEmail = passengerEmail;
            this.PassengerPhoneNo = passengerPhoneNo;
        }

            public  UserName  PassengerName { get; set; }
            public  string  PassengerEmail { get; set; }
            public  string  PassengerPhoneNo { get; set; }

        

    }

}
