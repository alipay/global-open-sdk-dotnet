using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerCreatePortalLinkRequest : AMSRequest<AlipayCustomerCreatePortalLinkResponse>
    {

        public AlipayCustomerCreatePortalLinkRequest() { }

        

        public AlipayCustomerCreatePortalLinkRequest( string customerId , string email , int? expiryDays , List<string> features , bool? autoSend , string settingId)
        {
            this.CustomerId = customerId;
            this.Email = email;
            this.ExpiryDays = expiryDays;
            this.Features = features;
            this.AutoSend = autoSend;
            this.SettingId = settingId;
        }

            public string CustomerId { get; set; }
            public string Email { get; set; }
            public int? ExpiryDays { get; set; }
            public List<string> Features { get; set; }
            public bool? AutoSend { get; set; }
            public string SettingId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/createPortalLink"; } 


    }

}
