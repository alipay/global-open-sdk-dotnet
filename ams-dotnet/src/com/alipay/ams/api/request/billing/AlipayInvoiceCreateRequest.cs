using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceCreateRequest : AMSRequest<AlipayInvoiceCreateResponse>
    {

        public AlipayInvoiceCreateRequest() { }

        

        public AlipayInvoiceCreateRequest( string invoiceRequestId , string customerId , string subscriptionId , string currency , List<Item> items , string status , bool? autoSend , List<string> ccEmails , string description , string dueDate , string collectionMethod , PaymentMethod paymentMethod , Shipping shipping , List<Discount> discounts)
        {
            this.InvoiceRequestId = invoiceRequestId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Currency = currency;
            this.Items = items;
            this.Status = status;
            this.AutoSend = autoSend;
            this.CcEmails = ccEmails;
            this.Description = description;
            this.DueDate = dueDate;
            this.CollectionMethod = collectionMethod;
            this.PaymentMethod = paymentMethod;
            this.Shipping = shipping;
            this.Discounts = discounts;
        }

            public string InvoiceRequestId { get; set; }
            public string CustomerId { get; set; }
            public string SubscriptionId { get; set; }
            public string Currency { get; set; }
            public List<Item> Items { get; set; }
            public string Status { get; set; }
            public bool? AutoSend { get; set; }
            public List<string> CcEmails { get; set; }
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string CollectionMethod { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public Shipping Shipping { get; set; }
            public List<Discount> Discounts { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/create"; } 


    }

}
