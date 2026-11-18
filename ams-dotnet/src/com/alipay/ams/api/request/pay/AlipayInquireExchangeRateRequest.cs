using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquireExchangeRateRequest : AMSRequest<AlipayInquireExchangeRateResponse>
    {

        public AlipayInquireExchangeRateRequest() { }

        

        public AlipayInquireExchangeRateRequest( string merchantAccountId , string paymentCurrency , CurrencyPair[] currencyPairs , string sellCurrency , string buyCurrency , ProductCodeType productCode , RateType rateType)
        {
            this.MerchantAccountId = merchantAccountId;
            this.PaymentCurrency = paymentCurrency;
            this.CurrencyPairs = currencyPairs;
            this.SellCurrency = sellCurrency;
            this.BuyCurrency = buyCurrency;
            this.ProductCode = productCode;
            this.RateType = rateType;
        }

            public string MerchantAccountId { get; set; }
            public string PaymentCurrency { get; set; }
            public CurrencyPair[] CurrencyPairs { get; set; }
            public string SellCurrency { get; set; }
            public string BuyCurrency { get; set; }
            public ProductCodeType ProductCode { get; set; }
            public RateType RateType { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/inquireExchangeRate"; } 


    }

}
