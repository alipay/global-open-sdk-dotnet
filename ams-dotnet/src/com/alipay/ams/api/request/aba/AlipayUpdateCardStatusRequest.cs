using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayUpdateCardStatusRequest : AMSRequest<AlipayUpdateCardStatusResponse>
    {

        public AlipayUpdateCardStatusRequest() { }

        

        public AlipayUpdateCardStatusRequest( string assetId , string requestId , string operateType , string notifyUrl)
        {
            this.AssetId = assetId;
            this.RequestId = requestId;
            this.OperateType = operateType;
            this.NotifyUrl = notifyUrl;
        }

            public string AssetId { get; set; }
            public string RequestId { get; set; }
            public string OperateType { get; set; }
            public string NotifyUrl { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/updateCardStatus"; } 


    }

}
