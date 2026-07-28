using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxInquireTransactionListRequest : AMSRequest<AlipayTaxInquireTransactionListResponse>
    {

        public AlipayTaxInquireTransactionListRequest() { }

        

        public AlipayTaxInquireTransactionListRequest( string taxCalculationId , string paymentId , string refundId , int? currentPage , int? pageSize)
        {
            this.TaxCalculationId = taxCalculationId;
            this.PaymentId = paymentId;
            this.RefundId = refundId;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }

            public string TaxCalculationId { get; set; }
            public string PaymentId { get; set; }
            public string RefundId { get; set; }
            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/inquireTransactionList"; } 


    }

}
