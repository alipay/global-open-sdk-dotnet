using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayReceiptInquireDetailsResponse : AMSResponse
    {

        public AlipayReceiptInquireDetailsResponse() { }

        

        public AlipayReceiptInquireDetailsResponse( Result result , string receiptId , string originalReceiptId , string invoiceId , string subscriptionId , string customerId , string paymentId , string refundId , string receiptType , string status , string reason , string customerFirstName , string customerLastName , string customerEmail , string collectionMethod , Amount totalAmount , Amount subtotal , Amount paidAmount , Amount discountAmount , Amount taxAmount , Amount shippingFeeAmount , Amount paymentDeductedAmount , Amount refundAmount , Amount refundedAmount , Amount remainingAmount , Amount settlementAmount , string fxRate , string fxRateId , string paymentMethod , string periodStart , string periodEnd , string paidTime , string dueDate , string paymentRequestId , string payToRequestId , string payToId , string description , string fileUrl , List<Item> items , List<Payment> payments , string gmtCreate , string gmtUpdate , string paymentMethodType , string footer)
        {
            this.Result = result;
            this.ReceiptId = receiptId;
            this.OriginalReceiptId = originalReceiptId;
            this.InvoiceId = invoiceId;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.PaymentId = paymentId;
            this.RefundId = refundId;
            this.ReceiptType = receiptType;
            this.Status = status;
            this.Reason = reason;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.CustomerEmail = customerEmail;
            this.CollectionMethod = collectionMethod;
            this.TotalAmount = totalAmount;
            this.Subtotal = subtotal;
            this.PaidAmount = paidAmount;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.ShippingFeeAmount = shippingFeeAmount;
            this.PaymentDeductedAmount = paymentDeductedAmount;
            this.RefundAmount = refundAmount;
            this.RefundedAmount = refundedAmount;
            this.RemainingAmount = remainingAmount;
            this.SettlementAmount = settlementAmount;
            this.FxRate = fxRate;
            this.FxRateId = fxRateId;
            this.PaymentMethod = paymentMethod;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.PaidTime = paidTime;
            this.DueDate = dueDate;
            this.PaymentRequestId = paymentRequestId;
            this.PayToRequestId = payToRequestId;
            this.PayToId = payToId;
            this.Description = description;
            this.FileUrl = fileUrl;
            this.Items = items;
            this.Payments = payments;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
            this.PaymentMethodType = paymentMethodType;
            this.Footer = footer;
        }

            public Result Result { get; set; }
            public string ReceiptId { get; set; }
            public string OriginalReceiptId { get; set; }
            public string InvoiceId { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string PaymentId { get; set; }
            public string RefundId { get; set; }
            public string ReceiptType { get; set; }
            public string Status { get; set; }
            public string Reason { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string CollectionMethod { get; set; }
            public Amount TotalAmount { get; set; }
            public Amount Subtotal { get; set; }
            public Amount PaidAmount { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TaxAmount { get; set; }
            public Amount ShippingFeeAmount { get; set; }
            public Amount PaymentDeductedAmount { get; set; }
            public Amount RefundAmount { get; set; }
            public Amount RefundedAmount { get; set; }
            public Amount RemainingAmount { get; set; }
            public Amount SettlementAmount { get; set; }
            public string FxRate { get; set; }
            public string FxRateId { get; set; }
            public string PaymentMethod { get; set; }
            public string PeriodStart { get; set; }
            public string PeriodEnd { get; set; }
            public string PaidTime { get; set; }
            public string DueDate { get; set; }
            public string PaymentRequestId { get; set; }
            public string PayToRequestId { get; set; }
            public string PayToId { get; set; }
            public string Description { get; set; }
            public string FileUrl { get; set; }
            public List<Item> Items { get; set; }
            public List<Payment> Payments { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }
            public string PaymentMethodType { get; set; }
            public string Footer { get; set; }

        

    }

}
