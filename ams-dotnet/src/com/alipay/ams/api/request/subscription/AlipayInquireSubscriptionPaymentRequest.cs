using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipayInquireSubscriptionPaymentRequest : AMSRequest<AlipayInquireSubscriptionPaymentResponse>
    {

        public AlipayInquireSubscriptionPaymentRequest() { }

        

        public AlipayInquireSubscriptionPaymentRequest( string merchantAccountId , string subscriptionId , List<PaymentStatus> paymentStatuses , int? currentPage , int? pageSize)
        {
            this.MerchantAccountId = merchantAccountId;
            this.SubscriptionId = subscriptionId;
            this.PaymentStatuses = paymentStatuses;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }

            public string MerchantAccountId { get; set; }
            public string SubscriptionId { get; set; }
            public List<PaymentStatus> PaymentStatuses { get; set; }
            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/inquireSubscriptionPayment"; } 


    }

}
