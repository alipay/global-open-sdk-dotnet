using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.dispute;
using com.alipay.ams.api.request.marketplace;

namespace ams_dotnet.demo;

public class MarketplaceDemo
{
    public static void register(DefaultAlipayClient client)
    {
        var alipayRegisterRequest = new AlipayRegisterRequest();
        alipayRegisterRequest.RegistrationRequestId =
            "register_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        var settlementInfo = new SettlementInfo();
        settlementInfo.SettlementCurrency = "BRL";
        var settlementBankAccount = new SettlementBankAccount();
        settlementBankAccount.BranchCode = "1231";
        settlementBankAccount.RoutingNumber = "12";
        settlementBankAccount.BankRegion = "BR";
        settlementBankAccount.AccountType = AccountType.CHECKING;
        settlementBankAccount.AccountHolderTIN = "12345678901";
        settlementBankAccount.AccountHolderName = "TIMI";
        settlementBankAccount.BankAccountNo = "12312412421";
        settlementBankAccount.AccountHolderType = AccountHolderType.ENTERPRISE;
        settlementInfo.SettlementBankAccount = settlementBankAccount;
        alipayRegisterRequest.SettlementInfos = [settlementInfo];

        var merchantInfo = new MerchantInfo();
        merchantInfo.LoginId = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds +
                               "wangzunj3ao.wzj@digital-engine.com";
        merchantInfo.LegalEntityType = LegalEntityType.COMPANY;
        
        var company = new Company();
        company.LegalName = "legalName";
        var address = new Address();
        address.Region = "BR";
        company.RegisteredAddress = address;
        company.OperatingAddress = address;
        company.CompanyType = CompanyType.LTDA;
        var attachment = new Attachment();
        attachment.AttachmentName = "1.jpg";
        attachment.FileKey = "test";
        attachment.AttachmentType = AttachmentType.ARTICLES_OF_ASSOCIATION;
        var attachment1 = new Attachment();
        attachment1.AttachmentName = "2.jpg";
        attachment1.FileKey = "test1";
        attachment1.AttachmentType = AttachmentType.ASSOCIATION_ARTICLE;
        company.Attachments = [attachment, attachment1];

        var certificate = new Certificate();
        certificate.CertificateNo = "12312412";
        certificate.CertificateType = CertificateType.ENTERPRISE_REGISTRATION;
        company.Certificates = certificate;
        
        merchantInfo.Company = company;

        var businessInfo = new BusinessInfo();
        businessInfo.DoingBusinessAs = "businessName_DBA";
        var webSite = new WebSite();
        webSite.Url = "https://www.alipay.com";
        businessInfo.Websites = [webSite];
        merchantInfo.BusinessInfo = businessInfo;
        
        merchantInfo.ReferenceMerchantId = "referenceMerchantId" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

        var entityAssociations = new EntityAssociations();
        var individual = new Individual();
        var certificate1 = new Certificate();
        certificate1.CertificateNo = "12321421";
        certificate1.CertificateType = CertificateType.CPF;
        individual.Certificates = certificate1;
        var userName = new UserName();
        userName.FullName = "fullName";
        userName.LastName = "lastName";
        userName.FirstName = "firstName";
        userName.MiddleName = "middleName";
        individual.Name = userName;
        individual.DateOfBirth = "1990-01-01";
        entityAssociations.Individual = individual;
        entityAssociations.LegalEntityType = LegalEntityType.INDIVIDUAL;
        entityAssociations.AssociationType = AssociationType.LEGAL_REPRESENTATIVE;
        
        var entityAssociations1 = new EntityAssociations();
        var individual1 = new Individual();
        var certificate2 = new Certificate();
        certificate2.CertificateNo = "12321421";
        certificate2.CertificateType = CertificateType.CPF;
        certificate2.FileKeys = ["112342353252"];
        individual1.Certificates = certificate2;
        individual1.Name = userName;
        individual1.DateOfBirth = "1990-01-01";
        entityAssociations1.Individual = individual1;
        entityAssociations1.LegalEntityType = LegalEntityType.INDIVIDUAL;
        entityAssociations1.AssociationType = AssociationType.UBO;
        
        merchantInfo.EntityAssociations = [entityAssociations, entityAssociations1];
        alipayRegisterRequest.MerchantInfo = merchantInfo;
        
        var response = client.Execute(alipayRegisterRequest);
        
        Console.WriteLine(response);
        
    }

    public static void update(DefaultAlipayClient client, string referenceMerchantId)
    {
        var alipaySettlementInfoUpdateRequest = new AlipaySettlementInfoUpdateRequest();
        alipaySettlementInfoUpdateRequest.ReferenceMerchantId = referenceMerchantId;
        alipaySettlementInfoUpdateRequest.UpdateRequestId =
            "update_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        alipaySettlementInfoUpdateRequest.SettlementCurrency = "BRL";
        var settlementBankAccount = new SettlementBankAccount();
        settlementBankAccount.BranchCode = "1231";
        settlementBankAccount.RoutingNumber = "12";
        settlementBankAccount.BankRegion = "BR";
        settlementBankAccount.AccountType = AccountType.CHECKING;
        settlementBankAccount.AccountHolderTIN = "12345678901";
        settlementBankAccount.AccountHolderName = "TIMI";
        settlementBankAccount.BankAccountNo = "12312412421";
        settlementBankAccount.AccountHolderType = AccountHolderType.ENTERPRISE;
        alipaySettlementInfoUpdateRequest.SettlementBankAccount = settlementBankAccount;
        
        var response = client.Execute(alipaySettlementInfoUpdateRequest);
        
        Console.WriteLine(response);
    }
    
    public static void queryBalance(DefaultAlipayClient client, string referenceMerchantId)
    {
        var alipayInquireBalanceRequest = new AlipayInquireBalanceRequest();
        alipayInquireBalanceRequest.ReferenceMerchantId = referenceMerchantId;
        var response = client.Execute(alipayInquireBalanceRequest);
        Console.WriteLine(response);
    }

    public static void settleRequest(DefaultAlipayClient client, string paymentId)
    {
        var alipaySettleRequest = new AlipaySettleRequest();
        alipaySettleRequest.PaymentId = paymentId;
        alipaySettleRequest.SettlementRequestId =
            "settle_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        var settlementDetail = new SettlementDetail();
        settlementDetail.SettleTo = SettleToType.SELLER;
        settlementDetail.SettlementAmount = new Amount("BRL", "90");
        var settlementDetail1 = new SettlementDetail();
        settlementDetail1.SettleTo = SettleToType.MARKETPLACE;
        settlementDetail1.SettlementAmount = new Amount("BRL", "10");
        alipaySettleRequest.SettlementDetails = [settlementDetail, settlementDetail1];
        
        var response = client.Execute(alipaySettleRequest);
        Console.WriteLine(response);

    }

    public static void createPayout(DefaultAlipayClient client)
    {
        var alipayCreatePayoutRequest = new AlipayCreatePayoutRequest();
        alipayCreatePayoutRequest.TransferRequestId =
            "transfer_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

        var transferFromDetail = new TransferFromDetail();
        var paymentMethod = new PaymentMethod(WalletPaymentMethodType.BALANCE_ACCOUNT.ToString());
        paymentMethod.PaymentMethodId = "paymentMethodId" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        transferFromDetail.TransferFromMethod = paymentMethod;

        alipayCreatePayoutRequest.TransferFromDetail = transferFromDetail;


        var transferToDetail = new TransferToDetail();
        var method = new PaymentMethod(WalletPaymentMethodType.SETTLEMENT_CARD.ToString());
        method.PaymentMethodId = "paymentMethodId" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds; 
        transferToDetail.TransferToMethod = method;
        transferToDetail.TransferToCurrency = "BRL";
        transferToDetail.PurposeCode = "GSD";
        transferToDetail.TransferNotifyUrl = "http://www.yourNotifyUrl.com";
        
        alipayCreatePayoutRequest.TransferToDetail = transferToDetail;
        
        var response = client.Execute(alipayCreatePayoutRequest);
        Console.WriteLine(response);
    }


    public static void createTransfer(DefaultAlipayClient client)
    {
        var alipayCreateTransferRequest = new AlipayCreateTransferRequest();
        alipayCreateTransferRequest.TransferRequestId = "transfer_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
       
        var transferFromDetail = new TransferFromDetail();
        var paymentMethod = new PaymentMethod(WalletPaymentMethodType.BALANCE_ACCOUNT.ToString());
        paymentMethod.PaymentMethodId = "paymentMethodId" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        transferFromDetail.TransferFromMethod = paymentMethod;
        transferFromDetail.TransferFromAmount = new Amount("BRL", "100");

        alipayCreateTransferRequest.TransferFromDetail = transferFromDetail;


        var transferToDetail = new TransferToDetail();
        var method = new PaymentMethod(WalletPaymentMethodType.SETTLEMENT_CARD.ToString());
        method.PaymentMethodId = "paymentMethodId" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds; 
        transferToDetail.TransferToMethod = method;
        transferToDetail.TransferToCurrency = "BRL";
        transferToDetail.PurposeCode = "GSD";
        transferToDetail.TransferNotifyUrl = "http://www.yourNotifyUrl.com";
        
        alipayCreateTransferRequest.TransferToDetail = transferToDetail;
    }
    
    
}