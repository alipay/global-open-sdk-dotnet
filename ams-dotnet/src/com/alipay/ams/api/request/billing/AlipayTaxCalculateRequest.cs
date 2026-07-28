using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxCalculateRequest : AMSRequest<AlipayTaxCalculateResponse>
    {

        public AlipayTaxCalculateRequest() { }

        

        public AlipayTaxCalculateRequest( string taxCalculationRequestId , string currency , List<TaxCalculationLineItem> lineItems , string customerId , TaxCustomerDetails customerDetails , TaxShipFromDetails shipFromDetails , TaxShippingCost shippingCost , string taxDate)
        {
            this.TaxCalculationRequestId = taxCalculationRequestId;
            this.Currency = currency;
            this.LineItems = lineItems;
            this.CustomerId = customerId;
            this.CustomerDetails = customerDetails;
            this.ShipFromDetails = shipFromDetails;
            this.ShippingCost = shippingCost;
            this.TaxDate = taxDate;
        }

            public string TaxCalculationRequestId { get; set; }
            public string Currency { get; set; }
            public List<TaxCalculationLineItem> LineItems { get; set; }
            public string CustomerId { get; set; }
            public TaxCustomerDetails CustomerDetails { get; set; }
            public TaxShipFromDetails ShipFromDetails { get; set; }
            public TaxShippingCost ShippingCost { get; set; }
            public string TaxDate { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/calculate"; } 


    }

}
