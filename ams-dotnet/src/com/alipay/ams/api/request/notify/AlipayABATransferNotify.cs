using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayABATransferNotify:AlipayNotify
{
    /**
     * The unique ID assigned by the merchant to identify a transfer request.
     * Maximum length: 64 characters
     */
    public string TransferRequestId { get; set; }

    /**
     * The unique ID assigned by Antom to identify a transfer.
     * Maximum length: 64 characters
     */
    public string TransferId { get; set; }

    /**
     * The result of the transfer request.
     */
    public Result TransferResult { get; set; }

    /**
     * The finishing time of a transfer.
     */
    public string TransferFinishTime { get; set; }

    /**
     * The transfer from detail information.
     */
    public TransferFromDetail TransferFromDetail { get; set; }

    /**
     * The transfer to detail information.
     */
    public TransferToDetail TransferToDetail { get; set; }
}