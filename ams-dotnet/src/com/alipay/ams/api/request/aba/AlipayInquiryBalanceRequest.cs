using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquiryBalanceRequest : AMSRequest<AlipayInquiryBalanceResponse>
    {

        public AlipayInquiryBalanceRequest() { }

        

        public AlipayInquiryBalanceRequest( List<string> currencyList , string accesstoken , string customerId)
        {
            this.CurrencyList = currencyList;
            this.Accesstoken = accesstoken;
            this.CustomerId = customerId;
        }

            public List<string> CurrencyList { get; set; }
            public string Accesstoken { get; set; }
            public string CustomerId { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/accounts/inquiryBalance"; } 


    }

}
