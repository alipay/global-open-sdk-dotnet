using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireExchangeResponse : AMSResponse
    {

        public AlipayInquireExchangeResponse() { }

        

        public AlipayInquireExchangeResponse( Result result , Result exchangeResult , string exchangeTradeType , string exchangeMode , string exchangeRequestId , Quote quote , Amount sellAmount , Amount buyAmount , string exchangeId , string exchangeStartTime , string exchangeEndTime)
        {
            this.Result = result;
            this.ExchangeResult = exchangeResult;
            this.ExchangeTradeType = exchangeTradeType;
            this.ExchangeMode = exchangeMode;
            this.ExchangeRequestId = exchangeRequestId;
            this.Quote = quote;
            this.SellAmount = sellAmount;
            this.BuyAmount = buyAmount;
            this.ExchangeId = exchangeId;
            this.ExchangeStartTime = exchangeStartTime;
            this.ExchangeEndTime = exchangeEndTime;
        }

            public Result Result { get; set; }
            public Result ExchangeResult { get; set; }
            public string ExchangeTradeType { get; set; }
            public string ExchangeMode { get; set; }
            public string ExchangeRequestId { get; set; }
            public Quote Quote { get; set; }
            public Amount SellAmount { get; set; }
            public Amount BuyAmount { get; set; }
            public string ExchangeId { get; set; }
            public string ExchangeStartTime { get; set; }
            public string ExchangeEndTime { get; set; }

        

    }

}
