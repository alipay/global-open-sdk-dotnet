using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayVaultingNotify:AlipayNotify
{
    /**
     * The unique ID that is assigned by a merchant to identify a card vaulting request.
     */
    public string VaultingRequestId { get; set; }

    /**
     * The details about the card payment method.
     */
    public PaymentMethodDetail PaymentMethodDetail { get; set; }

    public string VaultingCreateTime { get; set; }

    public AcquirerInfo AcquirerInfo { get; set; }
    
    public string Metadata { get; set; }
}