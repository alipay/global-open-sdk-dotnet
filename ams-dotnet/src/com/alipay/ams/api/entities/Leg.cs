namespace com.alipay.ams.api.entities;

public class Leg
{
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