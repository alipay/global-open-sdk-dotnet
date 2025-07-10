using System.Collections.Generic;

namespace com.alipay.ams.api.entities;

public class SubscriptionInfo
{
    public string SubscriptionDescription { get;  set; }
    public string SubscriptionStartTime { get;  set; }
    public string SubscriptionEndTime { get;  set; }
    private PeriodRule PeriodRule { get;  set; }
    private List<Trial> Trials { get;  set; }
    public string SubscriptionNotifyUrl { get;  set; }
    public string SubscriptionExpiryTime { get;  set; }
}