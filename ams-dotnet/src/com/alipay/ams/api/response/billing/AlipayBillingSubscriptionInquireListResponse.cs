using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionInquireListResponse : AMSResponse
    {

        public AlipayBillingSubscriptionInquireListResponse() { }

        

        public AlipayBillingSubscriptionInquireListResponse( ResultInfo result , List<Subscription> subscriptions , bool? hasMore , string nextCursor , string previousCursor)
        {
            this.Result = result;
            this.Subscriptions = subscriptions;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.PreviousCursor = previousCursor;
        }

            public ResultInfo Result { get; set; }
            public List<Subscription> Subscriptions { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }
            public string PreviousCursor { get; set; }

        

    }

}
