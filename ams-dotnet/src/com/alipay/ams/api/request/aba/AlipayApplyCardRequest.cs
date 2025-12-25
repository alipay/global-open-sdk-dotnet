using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayApplyCardRequest : AMSRequest<AlipayApplyCardResponse>
    {

        public AlipayApplyCardRequest() { }

        

        public AlipayApplyCardRequest( string requestId , string cardNickName , string note , string cardBinRule , string purpose , Dictionary<string, string> metadata , AuthorizationControl authorizationControl)
        {
            this.RequestId = requestId;
            this.CardNickName = cardNickName;
            this.Note = note;
            this.CardBinRule = cardBinRule;
            this.Purpose = purpose;
            this.Metadata = metadata;
            this.AuthorizationControl = authorizationControl;
        }

            public string RequestId { get; set; }
            public string CardNickName { get; set; }
            public string Note { get; set; }
            public string CardBinRule { get; set; }
            public string Purpose { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public AuthorizationControl AuthorizationControl { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/applyCard"; } 


    }

}
