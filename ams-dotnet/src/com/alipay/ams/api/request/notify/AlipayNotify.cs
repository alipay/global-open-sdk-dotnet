using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayNotify
{
    public string NotifyType { get; set; }

    public Result Result { get; set; }
}