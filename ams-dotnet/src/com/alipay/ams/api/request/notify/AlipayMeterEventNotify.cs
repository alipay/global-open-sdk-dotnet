using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayMeterEventNotify : AlipayNotify
{
    public string EventName { get; set; }

    public ErrorEvent ErrorEvents { get; set; }
}
