using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionResumeResponse : AMSResponse
    {

        public AlipayBillingSubscriptionResumeResponse() { }

        

        public AlipayBillingSubscriptionResumeResponse( ResultInfo result , string subscriptionId , string status , string billingCycleAnchor , string prorationInvoiceId , string prorationDate)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.ProrationInvoiceId = prorationInvoiceId;
            this.ProrationDate = prorationDate;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string ProrationInvoiceId { get; set; }
            public string ProrationDate { get; set; }

        

    }

}
