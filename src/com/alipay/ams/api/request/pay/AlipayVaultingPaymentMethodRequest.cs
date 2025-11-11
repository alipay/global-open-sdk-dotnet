using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayVaultingPaymentMethodRequest : AMSRequest<AlipayVaultingPaymentMethodResponse>
    {

        public AlipayVaultingPaymentMethodRequest() { }

        public AlipayVaultingPaymentMethodRequest( string vaultingRequestId , string vaultingNotificationUrl , string redirectUrl , string merchantRegion , PaymentMethodDetail paymentMethodDetail , Env env , string merchantAccountId , string vaultingCurrency , CustomizedInfo customizedInfo)
        {
            this.VaultingRequestId = vaultingRequestId;
            this.VaultingNotificationUrl = vaultingNotificationUrl;
            this.RedirectUrl = redirectUrl;
            this.MerchantRegion = merchantRegion;
            this.PaymentMethodDetail = paymentMethodDetail;
            this.Env = env;
            this.MerchantAccountId = merchantAccountId;
            this.VaultingCurrency = vaultingCurrency;
            this.CustomizedInfo = customizedInfo;
        }

            public string VaultingRequestId { get; set; }
            public string VaultingNotificationUrl { get; set; }
            public string RedirectUrl { get; set; }
            public string MerchantRegion { get; set; }
            public PaymentMethodDetail PaymentMethodDetail { get; set; }
            public Env Env { get; set; }
            public string MerchantAccountId { get; set; }
            public string VaultingCurrency { get; set; }
            public CustomizedInfo CustomizedInfo { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/vaults/vaultPaymentMethod"; 
} 


    }

}
