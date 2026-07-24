using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditNoteInquireDetailsRequest : AMSRequest<AlipayCreditNoteInquireDetailsResponse>
    {

        public AlipayCreditNoteInquireDetailsRequest() { }

        

        public AlipayCreditNoteInquireDetailsRequest( string creditNoteId)
        {
            this.CreditNoteId = creditNoteId;
        }

            public string CreditNoteId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/creditNote/inquireDetails"; } 


    }

}
