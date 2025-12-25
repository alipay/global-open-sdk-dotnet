using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireCardDetailRequest : AMSRequest<AlipayInquireCardDetailResponse>
    {

        public AlipayInquireCardDetailRequest() { }

        

        public AlipayInquireCardDetailRequest( string assetId)
        {
            this.AssetId = assetId;
        }

            public string AssetId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/inquireCardDetail"; } 


    }

}
