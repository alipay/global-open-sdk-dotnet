namespace com.alipay.ams.api.entities;

public class AuthorizationError
{
    /**
     * Authorization error code.
     * 授权错误码
     */
    public string ErrorCode { get; set; }

    /**
     * Description of the Authorization error code.
     * 授权错误码的描述
     */
    public string ErrorMessage { get; set; }
}