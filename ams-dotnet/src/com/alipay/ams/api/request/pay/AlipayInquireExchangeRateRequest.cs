using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request;

public class AlipayInquireExchangeRateRequest  : AMSRequest<AlipayInquireExchangeRateResponse>
{

    public string MerchantAccountId { get; set; }
    public string PaymentCurrency { get; set; }
    public CurrencyPair[] CurrencyPairs { get; set; }
    public string SellCurrency { get; set; }
    public string BuyCurrency { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.PAYMENT_INQUIRE_EXCHANGE_RATE_PATH;
    }

    public override void validate()
    {
           
    }

}