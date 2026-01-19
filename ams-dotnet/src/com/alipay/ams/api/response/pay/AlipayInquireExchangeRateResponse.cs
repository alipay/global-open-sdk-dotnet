using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquireExchangeRateResponse : AMSResponse
    {

        public AlipayInquireExchangeRateResponse() { }

        

        public AlipayInquireExchangeRateResponse( Quote[] quotes , Result result , List<PaymentQuote> paymentQuotes)
        {
            this.Quotes = quotes;
            this.Result = result;
            this.PaymentQuotes = paymentQuotes;
        }

            public Quote[] Quotes { get; set; }
            public Result Result { get; set; }
            public List<PaymentQuote> PaymentQuotes { get; set; }

        

    }

}
