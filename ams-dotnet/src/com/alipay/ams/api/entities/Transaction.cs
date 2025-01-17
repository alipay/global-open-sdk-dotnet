namespace com.alipay.ams.api.entities;

public class Transaction
{
    public Result transactionResult;
    public string transactionId;
    public TransactionType transactionType;
    public TransactionStatusType transactionStatus;
    public Amount transactionAmount;
    public string transactionRequestId;
    public string transactionTime;

    public AcquirerInfo acquirerInfo;
}