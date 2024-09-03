using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.customs;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.customs
{
    public class AlipayCustomsQueryRequest : AMSRequest<AlipayCustomsQueryResponse>
    {
        public List<string> DeclarationRequestIds { get; set; }
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.INQUIRY_DECLARE_PATH;
        }

        public override void validate()
        {
            
        }
    }
}