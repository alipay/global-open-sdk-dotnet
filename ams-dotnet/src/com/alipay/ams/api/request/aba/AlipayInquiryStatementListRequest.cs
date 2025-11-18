using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.aba;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;

namespace com.alipay.ams.api.request.aba;

public class AlipayInquiryStatementListRequest : AMSRequest<AlipayInquiryStatementListResponse>
{
    public string CustomerId { get; set; }
    public string AccessToken { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public List<string> TransactionTypeList { get; set; }
    public List<string> CurrencyList { get; set; }
    public string PageSize { get; set; }
    public string PageNumber { get; set; }
    public override string GetRequestURI()
    {
        return AntomPathConstants.ABA_INQUERY_STATEMENT_LIST_PATH;
    }

    public override void validate()
    {
        
    }
}