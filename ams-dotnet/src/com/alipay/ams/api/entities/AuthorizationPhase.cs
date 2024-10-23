namespace com.alipay.ams.api.entities;

public enum AuthorizationPhase
{
    /**
    * Indicates that you initiated this call before the card payment was authorized.
    */
    PRE_AUTHORIZATION,
    /**
     * Indicates that you initiated this call after the card payment was authorized
     */
    POST_AUTHORIZATION
}