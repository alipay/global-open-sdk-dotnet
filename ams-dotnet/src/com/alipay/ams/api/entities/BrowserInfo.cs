namespace com.alipay.ams.api.entities;

public class BrowserInfo
{

    public string AcceptHeader { get; set; }
    public bool? JavaEnabled  { get; set; }
    public bool? JavaScriptEnabled  { get; set; }
    public string Language  { get; set; }
    public string UserAgent  { get; set; }
}