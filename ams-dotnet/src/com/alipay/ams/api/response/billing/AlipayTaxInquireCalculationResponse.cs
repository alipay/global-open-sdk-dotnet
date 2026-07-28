using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayTaxInquireCalculationResponse : AMSResponse
    {

        public AlipayTaxInquireCalculationResponse() { }

        

        public AlipayTaxInquireCalculationResponse( Result result , string taxCalculationId , string currency , string totalAmount , string exclusiveTaxAmount , string inclusiveTaxAmount , List<TaxCalculatedLineItem> lineItems , List<TaxBreakdown> taxBreakdown , string expireAt , string taxDate , TaxCalculatedShippingCost shippingCost)
        {
            this.Result = result;
            this.TaxCalculationId = taxCalculationId;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.ExclusiveTaxAmount = exclusiveTaxAmount;
            this.InclusiveTaxAmount = inclusiveTaxAmount;
            this.LineItems = lineItems;
            this.TaxBreakdown = taxBreakdown;
            this.ExpireAt = expireAt;
            this.TaxDate = taxDate;
            this.ShippingCost = shippingCost;
        }

            public Result Result { get; set; }
            public string TaxCalculationId { get; set; }
            public string Currency { get; set; }
            public string TotalAmount { get; set; }
            public string ExclusiveTaxAmount { get; set; }
            public string InclusiveTaxAmount { get; set; }
            public List<TaxCalculatedLineItem> LineItems { get; set; }
            public List<TaxBreakdown> TaxBreakdown { get; set; }
            public string ExpireAt { get; set; }
            public string TaxDate { get; set; }
            public TaxCalculatedShippingCost ShippingCost { get; set; }

        

    }

}
