using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquiryStatementRequest : AMSRequest<AlipayInquiryStatementResponse>
    {

        public AlipayInquiryStatementRequest() { }

        

        public AlipayInquiryStatementRequest( string customerId , string accessToken , Object startTime , string endTime , List<string> transactionTypeList , List<string> currencyList , int? pageSize , int? pageNumber)
        {
            this.CustomerId = customerId;
            this.AccessToken = accessToken;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TransactionTypeList = transactionTypeList;
            this.CurrencyList = currencyList;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }

            public string CustomerId { get; set; }
            public string AccessToken { get; set; }
            public Object StartTime { get; set; }
            public string EndTime { get; set; }
            public List<string> TransactionTypeList { get; set; }
            public List<string> CurrencyList { get; set; }
            public int? PageSize { get; set; }
            public int? PageNumber { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/accounts/inquiryStatement"; } 


    }

}
