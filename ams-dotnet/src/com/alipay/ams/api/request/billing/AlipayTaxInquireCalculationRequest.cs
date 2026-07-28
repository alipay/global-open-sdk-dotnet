using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxInquireCalculationRequest : AMSRequest<AlipayTaxInquireCalculationResponse>
    {

        public AlipayTaxInquireCalculationRequest() { }

        

        public AlipayTaxInquireCalculationRequest( string taxCalculationId , string taxCalculationRequestId , string paymentRequestId)
        {
            this.TaxCalculationId = taxCalculationId;
            this.TaxCalculationRequestId = taxCalculationRequestId;
            this.PaymentRequestId = paymentRequestId;
        }

            public string TaxCalculationId { get; set; }
            public string TaxCalculationRequestId { get; set; }
            public string PaymentRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/inquireCalculation"; } 


    }

}
