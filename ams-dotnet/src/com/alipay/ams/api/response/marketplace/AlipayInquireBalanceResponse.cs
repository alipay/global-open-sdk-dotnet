using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.marketplace;

public class AlipayInquireBalanceResponse:AMSResponse
{
    public AccountBalance[] AccountBalances { get; set; }
}