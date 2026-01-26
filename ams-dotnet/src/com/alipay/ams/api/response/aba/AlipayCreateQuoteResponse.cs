using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayCreateQuoteResponse : AMSResponse
    {

        public AlipayCreateQuoteResponse() { }

        

        public AlipayCreateQuoteResponse( string exchangeTradeType , Quote quote , Amount sellAmount , Amount buyAmount , Result result)
        {
            this.ExchangeTradeType = exchangeTradeType;
            this.Quote = quote;
            this.SellAmount = sellAmount;
            this.BuyAmount = buyAmount;
            this.Result = result;
        }

            public string ExchangeTradeType { get; set; }
            public Quote Quote { get; set; }
            public Amount SellAmount { get; set; }
            public Amount BuyAmount { get; set; }
            public Result Result { get; set; }

        

    }

}
