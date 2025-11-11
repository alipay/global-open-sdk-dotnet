    
namespace com.alipay.ams.api.entities
{

public class Lodging
    {

        public Lodging() { }

        public Lodging( string hotelName , Address hotelAddress , string checkInDate , string checkOutDate , int? numberOfNights , int? numberOfRooms , List<UserName> guestNames)
        {
            this.HotelName = hotelName;
            this.HotelAddress = hotelAddress;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.NumberOfNights = numberOfNights;
            this.NumberOfRooms = numberOfRooms;
            this.GuestNames = guestNames;
        }

            public string HotelName { get; set; }
            public Address HotelAddress { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public int? NumberOfNights { get; set; }
            public int? NumberOfRooms { get; set; }
            public List<UserName> GuestNames { get; set; }

        

    }

}
