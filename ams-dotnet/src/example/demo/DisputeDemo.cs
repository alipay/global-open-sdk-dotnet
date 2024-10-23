using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.dispute;

namespace ams_dotnet.demo;

public class DisputeDemo
{
    public static void acceptDispute(DefaultAlipayClient client, string disputeId)
    {
        var alipayAcceptDisputeRequest = new AlipayAcceptDisputeRequest();
        alipayAcceptDisputeRequest.DisputeId = disputeId;
        
        var response = client.Execute(alipayAcceptDisputeRequest);
        
        Console.WriteLine(response);
    }

    public static void supplyDefenseDocument(DefaultAlipayClient client, string disputeId)
    {
        var alipaySupplyDefenseDocumentRequest = new AlipaySupplyDefenseDocumentRequest();
        alipaySupplyDefenseDocumentRequest.DisputeId = disputeId;
        alipaySupplyDefenseDocumentRequest.DisputeEvidence = "test";
        
        var response = client.Execute(alipaySupplyDefenseDocumentRequest);
        
        Console.WriteLine(response);
    }

    public static void downloadDisputeEvidence(DefaultAlipayClient client, string disputeId)
    {
        var alipayDownloadDisputeEvidenceRequest = new AlipayDownloadDisputeEvidenceRequest();
        alipayDownloadDisputeEvidenceRequest.DisputeId = disputeId;
        alipayDownloadDisputeEvidenceRequest.DisputeEvidenceType = DisputeEvidenceType.DISPUTE_EVIDENCE_TEMPLATE;
        var response = client.Execute(alipayDownloadDisputeEvidenceRequest);
        
        Console.WriteLine(response);
    }
}