using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireCardTransactionLifecycleRequest : AMSRequest<AlipayInquireCardTransactionLifecycleResponse>
    {

        public AlipayInquireCardTransactionLifecycleRequest() { }

        

        public AlipayInquireCardTransactionLifecycleRequest( string startTime , string endTime , List<string> assetIdList , List<string> transactionCurrencyList , List<string> lifecycleIdList , int? pageSize , int? pageNumber)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.AssetIdList = assetIdList;
            this.TransactionCurrencyList = transactionCurrencyList;
            this.LifecycleIdList = lifecycleIdList;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }

            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public List<string> AssetIdList { get; set; }
            public List<string> TransactionCurrencyList { get; set; }
            public List<string> LifecycleIdList { get; set; }
            public int? PageSize { get; set; }
            public int? PageNumber { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/inquireCardTransactionLifecycle"; } 


    }

}
