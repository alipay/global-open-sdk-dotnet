using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayCreateQuoteRequest : AMSRequest<AlipayCreateQuoteResponse>
    {

        public AlipayCreateQuoteRequest() { }

        

        public AlipayCreateQuoteRequest( Amount buyAmount , Amount sellAmount , string exchangeTradeType)
        {
            this.BuyAmount = buyAmount;
            this.SellAmount = sellAmount;
            this.ExchangeTradeType = exchangeTradeType;
        }

            public Amount BuyAmount { get; set; }
            public Amount SellAmount { get; set; }
            public string ExchangeTradeType { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/funds/createQuote"; } 


    }

}
