using System.Collections;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay;

public class AlipayInquireExchangeRateResponse : AMSResponse
{
    public Quote[] Quotes { get; set; }
}