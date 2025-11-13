using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipayRegisterRequest : AMSRequest<AlipayRegisterResponse>
    {

        public AlipayRegisterRequest() { }

        

        public AlipayRegisterRequest(  string  registrationRequestId ,  List<SettlementInfo>  settlementInfos ,  MerchantInfo  merchantInfo ,  List<PaymentMethod>  paymentMethods)
        {
            this.RegistrationRequestId = registrationRequestId;
            this.SettlementInfos = settlementInfos;
            this.MerchantInfo = merchantInfo;
            this.PaymentMethods = paymentMethods;
        }

            public  string  RegistrationRequestId { get; set; }
            public  List<SettlementInfo>  SettlementInfos { get; set; }
            public  MerchantInfo  MerchantInfo { get; set; }
            public  List<PaymentMethod>  PaymentMethods { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/merchants/register"; } 


    }

}
