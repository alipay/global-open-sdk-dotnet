using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionCancellationDetails
    {

        public BillingSubscriptionCancellationDetails() { }

        

        public BillingSubscriptionCancellationDetails( string feedback , string comment)
        {
            this.Feedback = feedback;
            this.Comment = comment;
        }

            public string Feedback { get; set; }
            public string Comment { get; set; }

        

    }

}
