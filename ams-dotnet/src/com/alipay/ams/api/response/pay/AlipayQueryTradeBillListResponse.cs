using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayQueryTradeBillListResponse : AMSResponse
    {

        public AlipayQueryTradeBillListResponse() { }

        

        public AlipayQueryTradeBillListResponse( int? currentPage , int? pageSize , string timeZone , long? total , List<TradeBillQueryInfo> records , Result result , string referenceStoreId , string tid , string merchantTransactionId , TradeBillPaymentAmount paymentAmount , string bizOrderType , string startTime , string completedTime , string bizOrderStatus)
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TimeZone = timeZone;
            this.Total = total;
            this.Records = records;
            this.Result = result;
            this.ReferenceStoreId = referenceStoreId;
            this.Tid = tid;
            this.MerchantTransactionId = merchantTransactionId;
            this.PaymentAmount = paymentAmount;
            this.BizOrderType = bizOrderType;
            this.StartTime = startTime;
            this.CompletedTime = completedTime;
            this.BizOrderStatus = bizOrderStatus;
        }

            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }
            public string TimeZone { get; set; }
            public long? Total { get; set; }
            public List<TradeBillQueryInfo> Records { get; set; }
            public Result Result { get; set; }
            public string ReferenceStoreId { get; set; }
            public string Tid { get; set; }
            public string MerchantTransactionId { get; set; }
            public TradeBillPaymentAmount PaymentAmount { get; set; }
            public string BizOrderType { get; set; }
            public string StartTime { get; set; }
            public string CompletedTime { get; set; }
            public string BizOrderStatus { get; set; }

        

    }

}
