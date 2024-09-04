using System.Collections.Generic;

namespace com.alipay.ams.api.entities;

public class Lodging
{
    public string HotelName { get; set; }
    public Address HotelAddress { get; set; }
    public string CheckInDate { get; set; }
    public string CheckOutDate { get; set; }
    public int NumberOfNights { get; set; }
    public int NumberOfRooms { get; set; }
    public List<UserName> GuestNames { get; set; }
}