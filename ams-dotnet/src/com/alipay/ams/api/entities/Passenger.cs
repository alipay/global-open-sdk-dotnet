namespace com.alipay.ams.api.entities;

public class Passenger
{
    public UserName PassengerName { get; set; }
    public string PassengerEmail { get; set; }
    public string PassengerPhoneNo  { get; set; }
    public string PassengerId { get; set; }
    public PassengerIdType PassengerIdType { get; set; }
    public string PassengerCode { get; set; }
}