using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Receipt
    {

        public Receipt() { }

        

        public Receipt( string receiptId , string invoiceId , string customerId , string subscriptionId , string originalReceiptId , string receiptType , string status , string reason , string collectionMethod , string paymentMethod , Amount subtotal , Amount totalAmount , Amount paidAmount , Amount remainingAmount , Amount refundAmount , Amount refundedAmount , Amount paymentDeductedAmount , string periodStart , string periodEnd , string description , string gmtCreate , string gmtUpdate , string customerFirstName , string customerLastName , string customerEmail , string paymentMethodType , Amount discountAmount , Amount taxAmount , Amount shippingFeeAmount , Amount settlementAmount , string fxRate , string fxRateId , string dueDate , string paidTime , string paymentRequestId , string payToRequestId , string payToId , string footer , string fileUrl)
        {
            this.ReceiptId = receiptId;
            this.InvoiceId = invoiceId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.OriginalReceiptId = originalReceiptId;
            this.ReceiptType = receiptType;
            this.Status = status;
            this.Reason = reason;
            this.CollectionMethod = collectionMethod;
            this.PaymentMethod = paymentMethod;
            this.Subtotal = subtotal;
            this.TotalAmount = totalAmount;
            this.PaidAmount = paidAmount;
            this.RemainingAmount = remainingAmount;
            this.RefundAmount = refundAmount;
            this.RefundedAmount = refundedAmount;
            this.PaymentDeductedAmount = paymentDeductedAmount;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Description = description;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.CustomerEmail = customerEmail;
            this.PaymentMethodType = paymentMethodType;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.ShippingFeeAmount = shippingFeeAmount;
            this.SettlementAmount = settlementAmount;
            this.FxRate = fxRate;
            this.FxRateId = fxRateId;
            this.DueDate = dueDate;
            this.PaidTime = paidTime;
            this.PaymentRequestId = paymentRequestId;
            this.PayToRequestId = payToRequestId;
            this.PayToId = payToId;
            this.Footer = footer;
            this.FileUrl = fileUrl;
        }

            public string ReceiptId { get; set; }
            public string InvoiceId { get; set; }
            public string CustomerId { get; set; }
            public string SubscriptionId { get; set; }
            public string OriginalReceiptId { get; set; }
            public string ReceiptType { get; set; }
            public string Status { get; set; }
            public string Reason { get; set; }
            public string CollectionMethod { get; set; }
            public string PaymentMethod { get; set; }
            public Amount Subtotal { get; set; }
            public Amount TotalAmount { get; set; }
            public Amount PaidAmount { get; set; }
            public Amount RemainingAmount { get; set; }
            public Amount RefundAmount { get; set; }
            public Amount RefundedAmount { get; set; }
            public Amount PaymentDeductedAmount { get; set; }
            public string PeriodStart { get; set; }
            public string PeriodEnd { get; set; }
            public string Description { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string PaymentMethodType { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TaxAmount { get; set; }
            public Amount ShippingFeeAmount { get; set; }
            public Amount SettlementAmount { get; set; }
            public string FxRate { get; set; }
            public string FxRateId { get; set; }
            public string DueDate { get; set; }
            public string PaidTime { get; set; }
            public string PaymentRequestId { get; set; }
            public string PayToRequestId { get; set; }
            public string PayToId { get; set; }
            public string Footer { get; set; }
            public string FileUrl { get; set; }

        

    }

}
