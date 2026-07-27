using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Invoice
    {

        public Invoice() { }

        

        public Invoice( string invoiceId , string subscriptionId , string customerId , string customerFirstName , string customerLastName , string customerEmail , string reason , string status , Amount totalAmount , Amount paidAmount , Amount remainingAmount , string currency , string paidTime , string voidedTime , string periodStart , string periodEnd , string dueDate , string gmtCreate , string gmtUpdate , string description , string pdfFileUrl)
        {
            this.InvoiceId = invoiceId;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.CustomerEmail = customerEmail;
            this.Reason = reason;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.PaidAmount = paidAmount;
            this.RemainingAmount = remainingAmount;
            this.Currency = currency;
            this.PaidTime = paidTime;
            this.VoidedTime = voidedTime;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.DueDate = dueDate;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
            this.Description = description;
            this.PdfFileUrl = pdfFileUrl;
        }

            public string InvoiceId { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string Reason { get; set; }
            public string Status { get; set; }
            public Amount TotalAmount { get; set; }
            public Amount PaidAmount { get; set; }
            public Amount RemainingAmount { get; set; }
            public string Currency { get; set; }
            public string PaidTime { get; set; }
            public string VoidedTime { get; set; }
            public string PeriodStart { get; set; }
            public string PeriodEnd { get; set; }
            public string DueDate { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }
            public string Description { get; set; }
            public string PdfFileUrl { get; set; }

        

    }

}
