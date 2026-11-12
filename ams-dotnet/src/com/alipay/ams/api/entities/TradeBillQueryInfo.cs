using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TradeBillQueryInfo
    {

        public TradeBillQueryInfo() { }

        

        public TradeBillQueryInfo( string merchantId , string referenceStoreId , string tid , string merchantTransactionId , TradeBillPaymentAmount paymentAmount , string bizOrderType , string bizOrderStatus , string startTime , string completedTime)
        {
            this.MerchantId = merchantId;
            this.ReferenceStoreId = referenceStoreId;
            this.Tid = tid;
            this.MerchantTransactionId = merchantTransactionId;
            this.PaymentAmount = paymentAmount;
            this.BizOrderType = bizOrderType;
            this.BizOrderStatus = bizOrderStatus;
            this.StartTime = startTime;
            this.CompletedTime = completedTime;
        }

            public string MerchantId { get; set; }
            public string ReferenceStoreId { get; set; }
            public string Tid { get; set; }
            public string MerchantTransactionId { get; set; }
            public TradeBillPaymentAmount PaymentAmount { get; set; }
            public string BizOrderType { get; set; }
            public string BizOrderStatus { get; set; }
            public string StartTime { get; set; }
            public string CompletedTime { get; set; }

        

    }

}
