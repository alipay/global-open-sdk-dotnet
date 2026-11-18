using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditNoteVoidResponse : AMSResponse
    {

        public AlipayCreditNoteVoidResponse() { }

        

        public AlipayCreditNoteVoidResponse( Result result , string creditNoteId , string status , string voidedAt)
        {
            this.Result = result;
            this.CreditNoteId = creditNoteId;
            this.Status = status;
            this.VoidedAt = voidedAt;
        }

            public Result Result { get; set; }
            public string CreditNoteId { get; set; }
            public string Status { get; set; }
            public string VoidedAt { get; set; }

        

    }

}
