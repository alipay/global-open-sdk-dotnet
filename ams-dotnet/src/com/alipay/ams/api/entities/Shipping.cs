using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Shipping
    {

        public Shipping() { }

        

        public Shipping( UserName shippingName , Address shippingAddress , string shippingCarrier , string shippingPhoneNo , string shipToEmail , string shippingFeeId , Amount shippingFee , string shippingDescription , DeliveryEstimate deliveryEstimate , string shippingNumber , string notes)
        {
            this.ShippingName = shippingName;
            this.ShippingAddress = shippingAddress;
            this.ShippingCarrier = shippingCarrier;
            this.ShippingPhoneNo = shippingPhoneNo;
            this.ShipToEmail = shipToEmail;
            this.ShippingFeeId = shippingFeeId;
            this.ShippingFee = shippingFee;
            this.ShippingDescription = shippingDescription;
            this.DeliveryEstimate = deliveryEstimate;
            this.ShippingNumber = shippingNumber;
            this.Notes = notes;
        }

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

}
