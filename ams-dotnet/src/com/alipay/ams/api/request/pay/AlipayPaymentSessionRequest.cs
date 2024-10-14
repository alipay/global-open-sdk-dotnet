using System;
using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request
{
    public class AlipayPaymentSessionRequest : AMSRequest<AlipayPaymentSessionResponse>
    {

    public ProductCodeType ProductCode { get; set; }
         
    public string PaymentRequestId { get; set; }
    
    public Order Order { get; set; }
    
    public Amount PaymentAmount { get; set; }
    
    public PaymentMethod PaymentMethod { get; set; }
    
    public string PaymentSessionExpiryTime { get; set; }
    
    public string PaymentRedirectUrl { get; set; }
    
    public string PaymentNotifyUrl { get; set; }
    
    public PaymentFactor PaymentFactor  { get; set; }
    
    public SettlementStrategy SettlementStrategy  { get; set; }
    
    public Boolean EnableInstallmentCollection { get; set; }
    
    public CreditPayPlan CreditPayPlan { get; set; }
    
    public string MerchantRegion { get; set; }
    
    public Env Env { get; set; }
    
    public AgreementInfo AgreementInfo { get; set; }
    
    public RiskData RiskData { get; set; }
    
    public string ProductScene { get; set; }

    public List<PaymentMethod> SavedPaymentMethods { get; set; }

    public string Locale { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.CREATE_SESSION_PATH;
    }

    public override void validate()
    {
        
    }
    }
}