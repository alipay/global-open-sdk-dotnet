using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceInquireDetailsResponse : AMSResponse
    {

        public AlipayInvoiceInquireDetailsResponse() { }

        

        public AlipayInvoiceInquireDetailsResponse( Result result , string invoiceId , string invoiceRequestId , string subscriptionId , string customerId , string invoiceNumber , string customerFirstName , string customerLastName , string customerEmail , string reason , string phaseNo , string status , string currency , Amount subtotal , Amount discountAmount , Amount totalAmount , Amount paidAmount , Amount remainingAmount , Amount taxAmount , Amount paymentDeductedAmount , string collectionMethod , PaymentMethod paymentMethod , Shipping shipping , string hostedInvoiceUrl , string periodStart , string periodEnd , string dueDate , string paidTime , string description , List<Item> items , List<Payment> payments , List<InvoiceNote> invoiceNotes , string gmtCreate , string gmtUpdate , List<Discount> discounts)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.InvoiceRequestId = invoiceRequestId;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.InvoiceNumber = invoiceNumber;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.CustomerEmail = customerEmail;
            this.Reason = reason;
            this.PhaseNo = phaseNo;
            this.Status = status;
            this.Currency = currency;
            this.Subtotal = subtotal;
            this.DiscountAmount = discountAmount;
            this.TotalAmount = totalAmount;
            this.PaidAmount = paidAmount;
            this.RemainingAmount = remainingAmount;
            this.TaxAmount = taxAmount;
            this.PaymentDeductedAmount = paymentDeductedAmount;
            this.CollectionMethod = collectionMethod;
            this.PaymentMethod = paymentMethod;
            this.Shipping = shipping;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.DueDate = dueDate;
            this.PaidTime = paidTime;
            this.Description = description;
            this.Items = items;
            this.Payments = payments;
            this.InvoiceNotes = invoiceNotes;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
            this.Discounts = discounts;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string InvoiceRequestId { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string InvoiceNumber { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string Reason { get; set; }
            public string PhaseNo { get; set; }
            public string Status { get; set; }
            public string Currency { get; set; }
            public Amount Subtotal { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TotalAmount { get; set; }
            public Amount PaidAmount { get; set; }
            public Amount RemainingAmount { get; set; }
            public Amount TaxAmount { get; set; }
            public Amount PaymentDeductedAmount { get; set; }
            public string CollectionMethod { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public Shipping Shipping { get; set; }
            public string HostedInvoiceUrl { get; set; }
            public string PeriodStart { get; set; }
            public string PeriodEnd { get; set; }
            public string DueDate { get; set; }
            public string PaidTime { get; set; }
            public string Description { get; set; }
            public List<Item> Items { get; set; }
            public List<Payment> Payments { get; set; }
            public List<InvoiceNote> InvoiceNotes { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }
            public List<Discount> Discounts { get; set; }

        

    }

}
