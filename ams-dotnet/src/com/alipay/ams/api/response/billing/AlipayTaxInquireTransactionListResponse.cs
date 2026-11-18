using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayTaxInquireTransactionListResponse : AMSResponse
    {

        public AlipayTaxInquireTransactionListResponse() { }

        

        public AlipayTaxInquireTransactionListResponse( Result result , List<TaxTransaction> transactions , Paginator paginator)
        {
            this.Result = result;
            this.Transactions = transactions;
            this.Paginator = paginator;
        }

            public Result Result { get; set; }
            public List<TaxTransaction> Transactions { get; set; }
            public Paginator Paginator { get; set; }

        

    }

}
