using System;
using System.Collections.Generic;
namespace com.alipay.ams.api.entities
{
    public class RegistrationDetail
    {
        public string LegalName { get; set; }

        public List<Attachment> Attachments { get; set; }

        public List<ContactInfo> ContactInfo { get; set; }


        public string RegistrationType { get; set; }

        public string RegistrationNo { get; set; }

        public Address RegistrationAddress { get; set; }

        public string BusinessType { get; set; }

        public string RegistrationEffectiveDate { get; set; }

        public string RegistrationExpireDate { get; set; }
    }
}
