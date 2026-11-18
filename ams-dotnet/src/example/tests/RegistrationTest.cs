using System;
using com.alipay.ams.api;
using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.merchant;

namespace ams_dotnet.example.tests
{
    public class RegistrationTest
    {
        class SandboxAlipayMerchantRegistrationRequest : AlipayMerchantRegistrationRequest
        {

            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/merchants/registration";
            }
        }

        class SandboxAlipayMerchantRegistrationStatusQueryRequest : AlipayMerchantRegistrationStatusQueryRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/merchants/inquiryRegistrationStatus";
            }

        }

        class SandboxAlipayMerchantRegistrationInfoQueryRequest : AlipayMerchantRegistrationInfoQueryRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/merchants/inquiryRegistrationInfo";
            }

        }

        public static void run(DefaultAlipayClient client)
        {
            string registrationRequestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            //build your referenceMerchantId
            string referenceMerchantId = "111111111121112222";

            //step1. register merchant info.
            registerMerchant(client, registrationRequestId, referenceMerchantId);

            //step2. query registration status.
            queryRegistrationStatus(client, registrationRequestId, registrationRequestId);

            //step3. query registration info.
            queryRegistrationInfo(client, referenceMerchantId);
          
        }

        private static void registerMerchant(DefaultAlipayClient client, string registrationRequestId, string referenceMerchantId)
        {
            var request = new SandboxAlipayMerchantRegistrationRequest();
            request.RegistrationRequestId = registrationRequestId;
            request.ProductCodes = new List<ProductCodeType> { ProductCodeType.CASHIER_PAYMENT };
            request.passThroughInfo = "{\"extraInfo\":\"extra\"}";
            request.RegistrationNotifyURL = "https://www.yourNotifyUrl.com";

            MerchantRegistrationInfo merchant = new MerchantRegistrationInfo();
            Logo logo = new Logo();
            logo.LogoName = "expLogo";
            logo.LogoUrl = "http://www.logo.com";
            merchant.Logo = logo;

            Address address = new Address();
            address.Address1 = "38 Leighton Road, ****";
            address.Address2 = "40 Leighton Road, ****";
            address.City = "hong kong";
            address.Region = "HK";
            address.State = "HK";
            address.ZipCode = "zipCode";
            address.Label = "label";
            merchant.MerchantAddress = address;
            merchant.MerchantDisplayName = "Example Merchant Name";
            merchant.MerchantMCC = "5812";

            RegistrationDetail detail = new RegistrationDetail();
            detail.LegalName = "Example Legal Name";
            detail.RegistrationNo = "registration*****";
            detail.RegistrationType = "ENTERPRISE_REGISTRATION_NO";
            detail.RegistrationExpireDate = "2021-07-12T12:08:56+05:30";


            List<Attachment> attachments = new List<Attachment>();
            Attachment attachment = new Attachment();
            attachment.AttachmentName = "attachmentTestName";
            attachment.AttachmentType = AttachmentType.ARTICLES_OF_ASSOCIATION;
            attachment.File = "testFile";
            attachments.Add(attachment);
            detail.Attachments = attachments;

            List<ContactInfo> contactInfos = new List<ContactInfo>();
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.ContactNo = "contactNo123";
            contactInfo.ContactType = "MOBILE_PHONE";
            contactInfos.Add(contactInfo);
            detail.ContactInfo = contactInfos;
            Address registrationAddress = new Address();
            registrationAddress.Region = "HK";
            detail.RegistrationAddress = registrationAddress;
            detail.BusinessType = "ENTERPRISE";
            merchant.RegistrationDetail = detail;

            List<WebSite> webSites = new List<WebSite>();
            WebSite webSite = new WebSite();
            webSite.Url = "http://www.webSite.com";
            webSite.Desc = "this is webSite desc";
            webSite.Name = "webName";
            webSites.Add(webSite);
            merchant.Websites = webSites;

            merchant.ReferenceMerchantId = registrationRequestId;
            request.MerchantInfo = merchant;

            

            Console.WriteLine(request);

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");

            Console.WriteLine(response);

        }




        private static void queryRegistrationStatus(DefaultAlipayClient client, string registrationRequestId, string referenceMerchantId)
        {
            var request = new SandboxAlipayMerchantRegistrationStatusQueryRequest();
            //request.ReferenceMerchantId = referenceMerchantId;
            request.RegistrationRequestId = registrationRequestId;

            Console.WriteLine(request);

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");

            Console.WriteLine(response);

 
        }

        private static void queryRegistrationInfo(DefaultAlipayClient client, string referenceMerchantId)
        {
            var request = new SandboxAlipayMerchantRegistrationInfoQueryRequest();
            request.ReferenceMerchantId = referenceMerchantId;

            Console.WriteLine(request);

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");

            Console.WriteLine(response);
        }

    }

}
