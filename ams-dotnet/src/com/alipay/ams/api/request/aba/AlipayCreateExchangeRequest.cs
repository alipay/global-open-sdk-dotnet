using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayCreateExchangeRequest : AMSRequest<AlipayCreateExchangeResponse>
    {

        public AlipayCreateExchangeRequest() { }

        

        public AlipayCreateExchangeRequest( Amount buyAmount , Amount sellAmount , string exchangeTradeType , string exchangeRequestId , string exchangeMode)
        {
            this.BuyAmount = buyAmount;
            this.SellAmount = sellAmount;
            this.ExchangeTradeType = exchangeTradeType;
            this.ExchangeRequestId = exchangeRequestId;
            this.ExchangeMode = exchangeMode;
        }

            public Amount BuyAmount { get; set; }
            public Amount SellAmount { get; set; }
            public string ExchangeTradeType { get; set; }
            public string ExchangeRequestId { get; set; }
            public string ExchangeMode { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/funds/createExchange"; } 


    }

}
