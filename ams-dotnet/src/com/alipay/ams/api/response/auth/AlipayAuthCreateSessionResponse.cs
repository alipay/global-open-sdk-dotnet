namespace com.alipay.ams.api.response.auth;

public class AlipayAuthCreateSessionResponse : AMSResponse
{
    public string PaymentSessionId { get; set; }
    public string PaymentSessionData { get; set; }
    public string PaymentSessionExpiryTime { get; set; }
}