namespace com.alipay.ams.api.entities
{
    public static class AntomPathConstants
    {
        public const string AUTH_CONSULT_PATH = "/ams/api/v1/authorizations/consult";
        public const string AUTH_APPLY_TOKEN_PATH = "/ams/api/v1/authorizations/applyToken";
        public const string AUTH_REVOKE_PATH = "/ams/api/v1/authorizations/revoke";
        public const string CREATE_VAULTING_SESSION_PATH = "/ams/api/v1/vaults/createVaultingSession";
        public const string VAULT_PAYMENT_METHOD_PATH = "/ams/api/v1/vaults/vaultPaymentMethod";
        public const string INQUIRE_VAULTING_PATH = "/ams/api/v1/vaults/inquireVaulting";
        public const string CONSULT_PAYMENT_PATH = "/ams/api/v1/payments/consult";
        public const string PAYMENT_PATH = "/ams/api/v1/payments/pay";
        public const string CREATE_SESSION_PATH = "/ams/api/v1/payments/createPaymentSession";
        public const string CAPTURE_PATH = "/ams/api/v1/payments/capture";
        public const string INQUIRY_PAYMENT_PATH = "/ams/api/v1/payments/inquiryPayment";
        public const string CANCEL_PATH = "/ams/api/v1/payments/cancel";
        public const  string SYNC_ARREAR_PATH = "/ams/api/v1/payments/syncArrear";
        public const  string CREATE_DEVICE_CERTIFICATE_PATH = "/ams/api/v1/payments/createDeviceCertificate";
        public const string SUBSCRIPTION_CREATE_PATH = "/ams/api/v1/subscriptions/create";
        public const string SUBSCRIPTION_CHANGE_PATH = "/ams/api/v1/subscriptions/change";
        public const string SUBSCRIPTION_CANCEL_PATH = "/ams/api/v1/subscriptions/cancel";
        public const string SUBSCRIPTION_UPDATE_PATH = "/ams/api/v1/subscriptions/update";
        public const string ACCEPT_DISPUTE_PATH = "/ams/api/v1/payments/acceptDispute";
        public const string SUPPLY_DEFENCE_DOC_PATH = "/ams/api/v1/payments/supplyDefenseDocument";
        public const string DOWNLOAD_DISPUTE_EVIDENCE_PATH = "/ams/api/v1/payments/downloadDisputeEvidence";
        public const string REFUND_PATH = "/ams/api/v1/payments/refund";
        public const string INQUIRY_REFUND_PATH = "/ams/api/v1/payments/inquiryRefund";
        public const string DECLARE_PATH = "/ams/api/v1/customs/declare";
        public const string INQUIRY_DECLARE_PATH = "/ams/api/v1/customs/inquiryDeclarationRequests";
        public const string MARKETPLACE_SUBMITATTACHMENT_PATH = "/ams/api/open/openapiv2_file/v1/business/attachment/submitAttachment";
        public const string MARKETPLACE_REGISTER_PATH = "/ams/api/v1/merchants/register";
        public const string MARKETPLACE_SETTLEMENTINFO_UPDATE_PATH = "/ams/api/v1/merchants/settlementInfo/update";
        public const string MARKETPLACE_INQUIREBALANCE_PATH = "/ams/api/v1/accounts/inquireBalance";
        public const string MARKETPLACE_SETTLE_PATH = "/ams/api/v1/payments/settle";
        public const string MARKETPLACE_CREATEPAYOUT_PATH = "/ams/api/v1/funds/createPayout";
        public const string MARKETPLACE_CREATETRANSFER_PATH = "/ams/api/v1/funds/createTransfer";
        public const string RISK_DECIDE_PATH = "/ams/api/v1/risk/payments/decide";
        public const string RISK_REPORT_PATH = "/ams/api/v1/risk/payments/reportRisk";
        public const string RISK_SEND_PAYMENT_RESULT_PATH = "/ams/api/v1/risk/payments/sendPaymentResult";
        public const string RISK_SEND_REFUND_RESULT_PATH = "/ams/api/v1/risk/payments/sendRefundResult";
    }
}
