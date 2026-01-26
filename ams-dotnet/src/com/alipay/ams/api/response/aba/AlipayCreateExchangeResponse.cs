using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayCreateExchangeResponse : AMSResponse
    {

        public AlipayCreateExchangeResponse() { }

        

        public AlipayCreateExchangeResponse( string exchangeRequestId , string exchangeTradeType , string exchangeMode , Quote quote , Amount buyAmount , Amount sellAmount , string exchangeStartTime , string exchangeEndTime , Result result)
        {
            this.ExchangeRequestId = exchangeRequestId;
            this.ExchangeTradeType = exchangeTradeType;
            this.ExchangeMode = exchangeMode;
            this.Quote = quote;
            this.BuyAmount = buyAmount;
            this.SellAmount = sellAmount;
            this.ExchangeStartTime = exchangeStartTime;
            this.ExchangeEndTime = exchangeEndTime;
            this.Result = result;
        }

            public string ExchangeRequestId { get; set; }
            public string ExchangeTradeType { get; set; }
            public string ExchangeMode { get; set; }
            public Quote Quote { get; set; }
            public Amount BuyAmount { get; set; }
            public Amount SellAmount { get; set; }
            public string ExchangeStartTime { get; set; }
            public string ExchangeEndTime { get; set; }
            public Result Result { get; set; }

        

    }

}
