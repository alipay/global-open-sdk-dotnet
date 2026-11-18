using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireCardTransactionLifecycleDetailRequest : AMSRequest<AlipayInquireCardTransactionLifecycleDetailResponse>
    {

        public AlipayInquireCardTransactionLifecycleDetailRequest() { }

        

        public AlipayInquireCardTransactionLifecycleDetailRequest( string lifecycleId)
        {
            this.LifecycleId = lifecycleId;
        }

            public string LifecycleId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/inquireCardTransactionLifecycleDetail"; } 


    }

}
