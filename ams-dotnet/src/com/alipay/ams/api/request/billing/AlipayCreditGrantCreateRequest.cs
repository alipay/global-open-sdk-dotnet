using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditGrantCreateRequest : AMSRequest<AlipayCreditGrantCreateResponse>
    {

        public AlipayCreditGrantCreateRequest() { }

        

        public AlipayCreditGrantCreateRequest( string customerId , string creditGrantName , Amount amount , Applicability applicability , int? priority , string category , string effectiveDateTime , string expiryDateTime)
        {
            this.CustomerId = customerId;
            this.CreditGrantName = creditGrantName;
            this.Amount = amount;
            this.Applicability = applicability;
            this.Priority = priority;
            this.Category = category;
            this.EffectiveDateTime = effectiveDateTime;
            this.ExpiryDateTime = expiryDateTime;
        }

            public string CustomerId { get; set; }
            public string CreditGrantName { get; set; }
            public Amount Amount { get; set; }
            public Applicability Applicability { get; set; }
            public int? Priority { get; set; }
            public string Category { get; set; }
            public string EffectiveDateTime { get; set; }
            public string ExpiryDateTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/create"; } 


    }

}
