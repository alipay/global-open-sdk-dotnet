using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SupplyEvidenceContent
    {

        public SupplyEvidenceContent() { }

        

        public SupplyEvidenceContent( string merchantOrderNo , string productDescription , string productUnitPrice , string quantity , EvidenceFile originalOrderReceiptFile , string receiverName , string receiverEmailAddress , string receiverContactNumber , string customerCommunications , EvidenceFile customerCommunicationsFile , string returnAndRefundPolicy , EvidenceFile returnAndRefundPolicyFile , string cancellationPolicy , EvidenceFile cancellationPolicyFile , string subscriptionPolicy , EvidenceFile subscriptionPolicyFile , string paymentPolicy , EvidenceFile paymentPolicyFile , string certificationRecords , EvidenceFile certificationRecordsFile , string merchantComments , EvidenceFile merchantCommentsFile , string marketingMaterialsAndListings , EvidenceFile marketingMaterialsAndListingsFile , string usageRecordsOfRecurringService , EvidenceFile usageRecordsOfRecurringServiceFile , string transactionDate , string transactionAmount , string transactionCurrency , string arn , string orderDescription , string paymentAuthMode , string ipAddress , string supplementProof , EvidenceFile supplementProofFile , string refundMethod , string refundedAmount , string refundFinishedTime , string bookingConfirmationTerms , EvidenceFile bookingConfirmationTermsFile , string offlineSignedAgreement , EvidenceFile offlineSignedAgreementFile , string installmentBillingAgreement , EvidenceFile installmentBillingAgreementFile , string trackingNumber , string postCode , string shippingAddress , string trackingUrl , EvidenceFile proofOfShipmentFile , EvidenceFile logisticScreenshotFile , EvidenceFile pictureOfDispatchedItemFile , string userRechargeAccountNumber , EvidenceFile digitalProductCompletionFile , EvidenceFile serviceCompletionFile , string orderNumber , string bookingTime , string airRoute , string numberOfPassenger , string passengerName , string bookingReferenceNumber , string ticketNumber , string orderStatus , string orderAmount , string totalPaymentAmount , string flightRoute , string flightNo , string cabinClass , string departureTime , string arrivalTime , string ticketStatus , string baggage , string reservationConfirmationNumber , string hotelName , string hotelAddress , string checkInDate , string checkOutDate , string numberOfGuest , string guestName , string prePaymentFees , string accommodationFeePerNight , string numberOfNight , string additionalServiceCharge , string cityTax , string checkoutPayment , List<EvidenceFile> supplementProofFileList)
        {
            this.MerchantOrderNo = merchantOrderNo;
            this.ProductDescription = productDescription;
            this.ProductUnitPrice = productUnitPrice;
            this.Quantity = quantity;
            this.OriginalOrderReceiptFile = originalOrderReceiptFile;
            this.ReceiverName = receiverName;
            this.ReceiverEmailAddress = receiverEmailAddress;
            this.ReceiverContactNumber = receiverContactNumber;
            this.CustomerCommunications = customerCommunications;
            this.CustomerCommunicationsFile = customerCommunicationsFile;
            this.ReturnAndRefundPolicy = returnAndRefundPolicy;
            this.ReturnAndRefundPolicyFile = returnAndRefundPolicyFile;
            this.CancellationPolicy = cancellationPolicy;
            this.CancellationPolicyFile = cancellationPolicyFile;
            this.SubscriptionPolicy = subscriptionPolicy;
            this.SubscriptionPolicyFile = subscriptionPolicyFile;
            this.PaymentPolicy = paymentPolicy;
            this.PaymentPolicyFile = paymentPolicyFile;
            this.CertificationRecords = certificationRecords;
            this.CertificationRecordsFile = certificationRecordsFile;
            this.MerchantComments = merchantComments;
            this.MerchantCommentsFile = merchantCommentsFile;
            this.MarketingMaterialsAndListings = marketingMaterialsAndListings;
            this.MarketingMaterialsAndListingsFile = marketingMaterialsAndListingsFile;
            this.UsageRecordsOfRecurringService = usageRecordsOfRecurringService;
            this.UsageRecordsOfRecurringServiceFile = usageRecordsOfRecurringServiceFile;
            this.TransactionDate = transactionDate;
            this.TransactionAmount = transactionAmount;
            this.TransactionCurrency = transactionCurrency;
            this.Arn = arn;
            this.OrderDescription = orderDescription;
            this.PaymentAuthMode = paymentAuthMode;
            this.IpAddress = ipAddress;
            this.SupplementProof = supplementProof;
            this.SupplementProofFile = supplementProofFile;
            this.RefundMethod = refundMethod;
            this.RefundedAmount = refundedAmount;
            this.RefundFinishedTime = refundFinishedTime;
            this.BookingConfirmationTerms = bookingConfirmationTerms;
            this.BookingConfirmationTermsFile = bookingConfirmationTermsFile;
            this.OfflineSignedAgreement = offlineSignedAgreement;
            this.OfflineSignedAgreementFile = offlineSignedAgreementFile;
            this.InstallmentBillingAgreement = installmentBillingAgreement;
            this.InstallmentBillingAgreementFile = installmentBillingAgreementFile;
            this.TrackingNumber = trackingNumber;
            this.PostCode = postCode;
            this.ShippingAddress = shippingAddress;
            this.TrackingUrl = trackingUrl;
            this.ProofOfShipmentFile = proofOfShipmentFile;
            this.LogisticScreenshotFile = logisticScreenshotFile;
            this.PictureOfDispatchedItemFile = pictureOfDispatchedItemFile;
            this.UserRechargeAccountNumber = userRechargeAccountNumber;
            this.DigitalProductCompletionFile = digitalProductCompletionFile;
            this.ServiceCompletionFile = serviceCompletionFile;
            this.OrderNumber = orderNumber;
            this.BookingTime = bookingTime;
            this.AirRoute = airRoute;
            this.NumberOfPassenger = numberOfPassenger;
            this.PassengerName = passengerName;
            this.BookingReferenceNumber = bookingReferenceNumber;
            this.TicketNumber = ticketNumber;
            this.OrderStatus = orderStatus;
            this.OrderAmount = orderAmount;
            this.TotalPaymentAmount = totalPaymentAmount;
            this.FlightRoute = flightRoute;
            this.FlightNo = flightNo;
            this.CabinClass = cabinClass;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.TicketStatus = ticketStatus;
            this.Baggage = baggage;
            this.ReservationConfirmationNumber = reservationConfirmationNumber;
            this.HotelName = hotelName;
            this.HotelAddress = hotelAddress;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.NumberOfGuest = numberOfGuest;
            this.GuestName = guestName;
            this.PrePaymentFees = prePaymentFees;
            this.AccommodationFeePerNight = accommodationFeePerNight;
            this.NumberOfNight = numberOfNight;
            this.AdditionalServiceCharge = additionalServiceCharge;
            this.CityTax = cityTax;
            this.CheckoutPayment = checkoutPayment;
            this.SupplementProofFileList = supplementProofFileList;
        }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

            public string MerchantOrderNo { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ProductDescription { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ProductUnitPrice { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string Quantity { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile OriginalOrderReceiptFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ReceiverName { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ReceiverEmailAddress { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ReceiverContactNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CustomerCommunications { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile CustomerCommunicationsFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ReturnAndRefundPolicy { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile ReturnAndRefundPolicyFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CancellationPolicy { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile CancellationPolicyFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string SubscriptionPolicy { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile SubscriptionPolicyFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string PaymentPolicy { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile PaymentPolicyFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CertificationRecords { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile CertificationRecordsFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string MerchantComments { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile MerchantCommentsFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string MarketingMaterialsAndListings { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile MarketingMaterialsAndListingsFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string UsageRecordsOfRecurringService { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile UsageRecordsOfRecurringServiceFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TransactionDate { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TransactionAmount { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TransactionCurrency { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string Arn { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string OrderDescription { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string PaymentAuthMode { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string IpAddress { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string SupplementProof { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile SupplementProofFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string RefundMethod { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string RefundedAmount { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string RefundFinishedTime { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string BookingConfirmationTerms { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile BookingConfirmationTermsFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string OfflineSignedAgreement { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile OfflineSignedAgreementFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string InstallmentBillingAgreement { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile InstallmentBillingAgreementFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TrackingNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string PostCode { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ShippingAddress { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TrackingUrl { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile ProofOfShipmentFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile LogisticScreenshotFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile PictureOfDispatchedItemFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string UserRechargeAccountNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile DigitalProductCompletionFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EvidenceFile ServiceCompletionFile { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string OrderNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string BookingTime { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string AirRoute { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string NumberOfPassenger { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string PassengerName { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string BookingReferenceNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TicketNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string OrderStatus { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string OrderAmount { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TotalPaymentAmount { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string FlightRoute { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string FlightNo { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CabinClass { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string DepartureTime { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ArrivalTime { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string TicketStatus { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string Baggage { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string ReservationConfirmationNumber { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string HotelName { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string HotelAddress { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CheckInDate { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CheckOutDate { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string NumberOfGuest { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string GuestName { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string PrePaymentFees { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string AccommodationFeePerNight { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string NumberOfNight { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string AdditionalServiceCharge { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CityTax { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string CheckoutPayment { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public List<EvidenceFile> SupplementProofFileList { get; set; }

        

    }

}
