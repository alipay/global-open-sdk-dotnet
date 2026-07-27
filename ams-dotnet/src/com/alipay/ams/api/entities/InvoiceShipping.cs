using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceShipping
    {

        public InvoiceShipping() { }

        

        public InvoiceShipping( UserName shippingName , Address shippingAddress , string shippingCarrier , string shippingNumber , string shippingPhoneNo , string shipToEmail , string notes , string shippingFeeId , Amount shippingFee , string shippingDescription , DeliveryEstimate deliveryEstimate , string trackingUrl , string shippingMethodIndicator)
        {
            this.ShippingName = shippingName;
            this.ShippingAddress = shippingAddress;
            this.ShippingCarrier = shippingCarrier;
            this.ShippingNumber = shippingNumber;
            this.ShippingPhoneNo = shippingPhoneNo;
            this.ShipToEmail = shipToEmail;
            this.Notes = notes;
            this.ShippingFeeId = shippingFeeId;
            this.ShippingFee = shippingFee;
            this.ShippingDescription = shippingDescription;
            this.DeliveryEstimate = deliveryEstimate;
            this.TrackingUrl = trackingUrl;
            this.ShippingMethodIndicator = shippingMethodIndicator;
        }

            public UserName ShippingName { get; set; }
            public Address ShippingAddress { get; set; }
            public string ShippingCarrier { get; set; }
            public string ShippingNumber { get; set; }
            public string ShippingPhoneNo { get; set; }
            public string ShipToEmail { get; set; }
            public string Notes { get; set; }
            public string ShippingFeeId { get; set; }
            public Amount ShippingFee { get; set; }
            public string ShippingDescription { get; set; }
            public DeliveryEstimate DeliveryEstimate { get; set; }
            public string TrackingUrl { get; set; }
            public string ShippingMethodIndicator { get; set; }

        

    }

}
