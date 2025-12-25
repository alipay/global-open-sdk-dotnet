using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayUpdateCardRequest : AMSRequest<AlipayUpdateCardResponse>
    {

        public AlipayUpdateCardRequest() { }

        

        public AlipayUpdateCardRequest( string assetId , string requestId , string cardNickName , string note , string purpose , Dictionary<string, string> metadata , AuthorizationControl authorizationControl)
        {
            this.AssetId = assetId;
            this.RequestId = requestId;
            this.CardNickName = cardNickName;
            this.Note = note;
            this.Purpose = purpose;
            this.Metadata = metadata;
            this.AuthorizationControl = authorizationControl;
        }

            public string AssetId { get; set; }
            public string RequestId { get; set; }
            public string CardNickName { get; set; }
            public string Note { get; set; }
            public string Purpose { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public AuthorizationControl AuthorizationControl { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/updateCard"; } 


    }

}
