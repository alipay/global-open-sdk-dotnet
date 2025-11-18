using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.aba;

public class AlipayInquiryStatementListResponse : AMSResponse
{
    public List<Statement> StatementList  { get; set; }

}