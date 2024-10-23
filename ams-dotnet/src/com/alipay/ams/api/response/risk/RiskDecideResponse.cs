using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.risk;

public class RiskDecideResponse:AMSResponse
{
    /**
    * Ant Group's risk decisions. Valid values are as follows:
    * ACCEPT: indicates that the payment is accepted.
    * REJECT: indicates that the payment is rejected.
    * 蚂蚁集团的风控决策。有效值为：
    * ACCEPT：表示建议接受该笔支付。
    * REJECT：表示建议拒绝该笔支付。
    */
    public string Decision { get; set; }
    /**
     * Ant Group's recommended authentication method. Valid values are as follows:
     * 3D: 3D authentication is recommended for this transaction.
     * NON_3D: Non-3D authentication is recommended for this transaction.
     * * 蚂蚁集团推荐的身份验证方法。有效值为：
     * * 3D：本次交易建议使用 3D 认证。
     * * NON_3D：本次交易建议使用非 3D 认证。
     */
    public string AuthenticationDecision { get; set; }
}