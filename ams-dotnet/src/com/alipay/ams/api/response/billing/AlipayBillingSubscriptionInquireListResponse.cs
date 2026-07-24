using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionInquireListResponse : AMSResponse
    {

        public AlipayBillingSubscriptionInquireListResponse() { }

        

        public AlipayBillingSubscriptionInquireListResponse( ResultInfo result , List<Subscription> subscriptions , bool? hasMore , string nextCursor , string prevCursor , int? total)
        {
            this.Result = result;
            this.Subscriptions = subscriptions;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.PrevCursor = prevCursor;
            this.Total = total;
        }

            public ResultInfo Result { get; set; }
            public List<Subscription> Subscriptions { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }
            public string PrevCursor { get; set; }
            public int? Total { get; set; }

        

    }

}
