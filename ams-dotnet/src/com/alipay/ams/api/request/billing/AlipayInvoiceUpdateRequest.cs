using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceUpdateRequest : AMSRequest<AlipayInvoiceUpdateResponse>
    {

        public AlipayInvoiceUpdateRequest() { }

        

        public AlipayInvoiceUpdateRequest( string invoiceId , string description , string dueDate , string collectionMethod , PaymentMethod paymentMethod , InvoiceShipping shipping , string customerId , string footer , bool? includePaymentLink , string memo , List<InvoiceCustomField> customFields , string invoiceNotifyUrl)
        {
            this.InvoiceId = invoiceId;
            this.Description = description;
            this.DueDate = dueDate;
            this.CollectionMethod = collectionMethod;
            this.PaymentMethod = paymentMethod;
            this.Shipping = shipping;
            this.CustomerId = customerId;
            this.Footer = footer;
            this.IncludePaymentLink = includePaymentLink;
            this.Memo = memo;
            this.CustomFields = customFields;
            this.InvoiceNotifyUrl = invoiceNotifyUrl;
        }

            public string InvoiceId { get; set; }
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string CollectionMethod { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public InvoiceShipping Shipping { get; set; }
            public string CustomerId { get; set; }
            public string Footer { get; set; }
            public bool? IncludePaymentLink { get; set; }
            public string Memo { get; set; }
            public List<InvoiceCustomField> CustomFields { get; set; }
            public string InvoiceNotifyUrl { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/update"; } 


    }

}
