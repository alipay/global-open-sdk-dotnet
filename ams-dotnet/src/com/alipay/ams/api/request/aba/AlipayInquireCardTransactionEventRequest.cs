using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireCardTransactionEventRequest : AMSRequest<AlipayInquireCardTransactionEventResponse>
    {

        public AlipayInquireCardTransactionEventRequest() { }

        

        public AlipayInquireCardTransactionEventRequest( string startTime , string endTime , List<string> assetIdList , List<string> eventIdList , List<string> lifecycleIdList , List<string> transactionCurrencyList , List<CardTransactionEventFilterType> eventTypeList , List<CardTransactionStatusFilterType> statusList , int? pageSize , int? pageNumber)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.AssetIdList = assetIdList;
            this.EventIdList = eventIdList;
            this.LifecycleIdList = lifecycleIdList;
            this.TransactionCurrencyList = transactionCurrencyList;
            this.EventTypeList = eventTypeList;
            this.StatusList = statusList;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }

            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public List<string> AssetIdList { get; set; }
            public List<string> EventIdList { get; set; }
            public List<string> LifecycleIdList { get; set; }
            public List<string> TransactionCurrencyList { get; set; }
            public List<CardTransactionEventFilterType> EventTypeList { get; set; }
            public List<CardTransactionStatusFilterType> StatusList { get; set; }
            public int? PageSize { get; set; }
            public int? PageNumber { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/inquireCardTransactionEvent"; } 


    }

}
