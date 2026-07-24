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

        

        public AlipayInvoiceUpdateRequest( string invoiceId , string description , string dueDate , string collectionMethod , PaymentMethod paymentMethod , Shipping shipping)
        {
            this.InvoiceId = invoiceId;
            this.Description = description;
            this.DueDate = dueDate;
            this.CollectionMethod = collectionMethod;
            this.PaymentMethod = paymentMethod;
            this.Shipping = shipping;
        }

            public string InvoiceId { get; set; }
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string CollectionMethod { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public Shipping Shipping { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/update"; } 


    }

}
