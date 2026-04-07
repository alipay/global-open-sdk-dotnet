using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipayInquireSubscriptionListRequest : AMSRequest<AlipayInquireSubscriptionListResponse>
    {

        public AlipayInquireSubscriptionListRequest() { }

        

        public AlipayInquireSubscriptionListRequest( string merchantAccountId , DateTime? startTimeFrom , DateTime? startTimeTo , List<SubscriptionStatus> statuses , List<string> paymentMethodTypes , List<string> currencies , List<PeriodType> periodTypes , int? currentPage , int? pageSize)
        {
            this.MerchantAccountId = merchantAccountId;
            this.StartTimeFrom = startTimeFrom;
            this.StartTimeTo = startTimeTo;
            this.Statuses = statuses;
            this.PaymentMethodTypes = paymentMethodTypes;
            this.Currencies = currencies;
            this.PeriodTypes = periodTypes;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }

            public string MerchantAccountId { get; set; }
            public DateTime? StartTimeFrom { get; set; }
            public DateTime? StartTimeTo { get; set; }
            public List<SubscriptionStatus> Statuses { get; set; }
            public List<string> PaymentMethodTypes { get; set; }
            public List<string> Currencies { get; set; }
            public List<PeriodType> PeriodTypes { get; set; }
            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/inquireSubscriptionList"; } 


    }

}
