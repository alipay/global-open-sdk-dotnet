using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireExchangeRequest : AMSRequest<AlipayInquireExchangeResponse>
    {

        public AlipayInquireExchangeRequest() { }

        

        public AlipayInquireExchangeRequest( string exchangeRequestId)
        {
            this.ExchangeRequestId = exchangeRequestId;
        }

            public string ExchangeRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/funds/inquireExchange"; } 


    }

}
