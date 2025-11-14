using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Passenger
    {

        public Passenger() { }

        

        public Passenger( UserName passengerName , string passengerEmail , string passengerPhoneNo , string passengerId , PassengerIdType passengerIdType , string passengerCode)
        {
            this.PassengerName = passengerName;
            this.PassengerEmail = passengerEmail;
            this.PassengerPhoneNo = passengerPhoneNo;
            this.PassengerId = passengerId;
            this.PassengerIdType = passengerIdType;
            this.PassengerCode = passengerCode;
        }

            public UserName PassengerName { get; set; }
            public string PassengerEmail { get; set; }
            public string PassengerPhoneNo { get; set; }
            public string PassengerId { get; set; }
            public PassengerIdType PassengerIdType { get; set; }
            public string PassengerCode { get; set; }

        

    }

}
