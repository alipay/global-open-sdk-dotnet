namespace com.alipay.ams.api.entities;

public class Shipping
{
    public UserName ShippingName { get; set; }
    public Address ShippingAddress { get; set; }
    public string ShippingCarrier { get; set; }
    public string ShippingPhoneNo { get; set; }
    public string ShipToEmail { get; set; }
    public string ShippingFeeId { get; set; }
    public Amount ShippingFee { get; set; }
    public string ShippingDescription { get; set; }
    public DeliveryEstimate DeliveryEstimate { get; set; }
    public string ShippingNumber { get; set; }
    public string Notes { get; set; }
}