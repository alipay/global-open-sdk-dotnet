namespace com.alipay.ams.api.request.notify;

public class AlipayAuthNotify:AlipayNotify
{
    /**
     * Authorization notification type
     */
    public string AuthorizationNotifyType { get; set; }

    /**
     * authClientId
     */
    public string AuthClientId { get; set; }

    /**
     * The access token that is used to access the corresponding scope of the user resource
     */
    public string AccessToken { get; set; }

    /**
     * A string that is generated by the acquirer to represent the consult request
     */
    public string AuthState { get; set; }

    /**
     * The authorization code, used for getting an access token
     */
    public string AuthCode { get; set; }

    /**
     * The reason why the authorization is canceled
     */
    public string Reason { get; set; }

    /**
     * The login ID that the user used to register in the wallet
     */
    public string UserLoginId { get; set; }

    /**
     * The ID assigned by the payment method provider to identify a user
     */
    public string UserId { get; set; }

}