using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditNoteVoidRequest : AMSRequest<AlipayCreditNoteVoidResponse>
    {

        public AlipayCreditNoteVoidRequest() { }

        

        public AlipayCreditNoteVoidRequest( string creditNoteId , string reason)
        {
            this.CreditNoteId = creditNoteId;
            this.Reason = reason;
        }

            public string CreditNoteId { get; set; }
            public string Reason { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/creditNote/void"; } 


    }

}
