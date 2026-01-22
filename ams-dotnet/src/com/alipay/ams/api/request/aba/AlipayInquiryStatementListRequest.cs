using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquiryStatementListRequest : AMSRequest<AlipayInquiryStatementListResponse>
    {

        public AlipayInquiryStatementListRequest() { }

        

        public AlipayInquiryStatementListRequest( string fuzzyName , string customerId , string accessToken , string startTime , string endTime , List<string> transactionTypeList , List<string> currencyList , string pageSize , string pageNumber)
        {
            this.FuzzyName = fuzzyName;
            this.CustomerId = customerId;
            this.AccessToken = accessToken;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TransactionTypeList = transactionTypeList;
            this.CurrencyList = currencyList;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }

            public string FuzzyName { get; set; }
            public string CustomerId { get; set; }
            public string AccessToken { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public List<string> TransactionTypeList { get; set; }
            public List<string> CurrencyList { get; set; }
            public string PageSize { get; set; }
            public string PageNumber { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/accounts/inquiryStatementList"; } 


    }

}
