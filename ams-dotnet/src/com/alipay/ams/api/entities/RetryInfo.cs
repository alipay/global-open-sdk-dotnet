using System.Collections.Generic;

namespace com.alipay.ams.api.entities;

public class RetryInfo
{
    public int AvailableRetries { get; set; }
    public List<PaymentAttempt> PaymentAttempts { get; set; }
}