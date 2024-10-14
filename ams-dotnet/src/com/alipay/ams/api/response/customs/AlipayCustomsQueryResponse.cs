using System;
using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.customs
{
    public class AlipayCustomsQueryResponse : AMSResponse
    {
        public List<string> DeclarationRequestsNotFound { get; set; }

        public List<DeclarationRecord> DeclarationRecords { get; set; }
    }
}