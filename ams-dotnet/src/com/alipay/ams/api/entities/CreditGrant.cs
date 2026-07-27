using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreditGrant
    {

        public CreditGrant() { }

        

        public CreditGrant( string creditGrantId , string creditGrantName , string customerId , string status , Amount amount , AvailableAmount availableAmount , Applicability applicability , int? priority , string category , string effectiveDateTime , string expiryDateTime , string createdDateTime , string updatedDateTime)
        {
            this.CreditGrantId = creditGrantId;
            this.CreditGrantName = creditGrantName;
            this.CustomerId = customerId;
            this.Status = status;
            this.Amount = amount;
            this.AvailableAmount = availableAmount;
            this.Applicability = applicability;
            this.Priority = priority;
            this.Category = category;
            this.EffectiveDateTime = effectiveDateTime;
            this.ExpiryDateTime = expiryDateTime;
            this.CreatedDateTime = createdDateTime;
            this.UpdatedDateTime = updatedDateTime;
        }

            public string CreditGrantId { get; set; }
            public string CreditGrantName { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }
            public Amount Amount { get; set; }
            public AvailableAmount AvailableAmount { get; set; }
            public Applicability Applicability { get; set; }
            public int? Priority { get; set; }
            public string Category { get; set; }
            public string EffectiveDateTime { get; set; }
            public string ExpiryDateTime { get; set; }
            public string CreatedDateTime { get; set; }
            public string UpdatedDateTime { get; set; }

        

    }

}
