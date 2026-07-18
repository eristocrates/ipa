namespace https.ns.verisav.fr.rma.hash

open DoxAletheia.Rdf_Vocabulary

module rma =
    let _namespace_name = "https://ns.verisav.fr/rma#"
    /// <summary>
    /// An approval or authorization for a return request or resolution.
    /// <see href="https://ns.verisav.fr/rma#Approval"></see></summary>
    let Approval = Namespaced_IRI.parse _namespace_name "Approval" |> NamespacedName
    /// <summary>
    /// A dispute or complaint about a product (e.g., arrived broken, not as described, defective).
    /// <see href="https://ns.verisav.fr/rma#Dispute"></see></summary>
    let Dispute = Namespaced_IRI.parse _namespace_name "Dispute" |> NamespacedName
    /// <summary>
    /// A message in a ticket conversation thread between customer, retailer, or repairer.
    /// <see href="https://ns.verisav.fr/rma#Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    /// A resolution proposed or applied to a return request or dispute (refund, exchange, store credit, repair).
    /// <see href="https://ns.verisav.fr/rma#Resolution"></see></summary>
    let Resolution = Namespaced_IRI.parse _namespace_name "Resolution" |> NamespacedName

    /// <summary>
    /// A request for returning a product to a retailer or manufacturer.
    /// <see href="https://ns.verisav.fr/rma#ReturnRequest"></see></summary>
    let ReturnRequest =
        Namespaced_IRI.parse _namespace_name "ReturnRequest" |> NamespacedName

    /// <summary>
    /// A shipping label for returning a product, containing carrier and tracking information.
    /// <see href="https://ns.verisav.fr/rma#ShippingLabel"></see></summary>
    let ShippingLabel =
        Namespaced_IRI.parse _namespace_name "ShippingLabel" |> NamespacedName

    /// <summary>
    /// A service ticket that tracks customer service interactions and issue resolution.
    /// <see href="https://ns.verisav.fr/rma#Ticket"></see></summary>
    let Ticket = Namespaced_IRI.parse _namespace_name "Ticket" |> NamespacedName
    /// <summary>
    /// Tracking information for a returned package, including carrier events and status.
    /// <see href="https://ns.verisav.fr/rma#Tracking"></see></summary>
    let Tracking = Namespaced_IRI.parse _namespace_name "Tracking" |> NamespacedName

    /// <summary>
    /// Comment associated with the approval or rejection.
    /// <see href="https://ns.verisav.fr/rma#approvalComment"></see></summary>
    let approvalComment =
        Namespaced_IRI.parse _namespace_name "approvalComment" |> NamespacedName

    /// <summary>
    /// Date when the approval was given.
    /// <see href="https://ns.verisav.fr/rma#approvalDate"></see></summary>
    let approvalDate =
        Namespaced_IRI.parse _namespace_name "approvalDate" |> NamespacedName

    /// <summary>
    /// Status of the approval (pending, approved, rejected).
    /// <see href="https://ns.verisav.fr/rma#approvalStatus"></see></summary>
    let approvalStatus =
        Namespaced_IRI.parse _namespace_name "approvalStatus" |> NamespacedName

    /// <summary>
    /// The person or organization who approved the return request or resolution.
    /// <see href="https://ns.verisav.fr/rma#approvedBy"></see></summary>
    let approvedBy = Namespaced_IRI.parse _namespace_name "approvedBy" |> NamespacedName
    /// <summary>
    /// The person or organization who authored a message.
    /// <see href="https://ns.verisav.fr/rma#authoredBy"></see></summary>
    let authoredBy = Namespaced_IRI.parse _namespace_name "authoredBy" |> NamespacedName

    /// <summary>
    /// Name of the shipping carrier (e.g., DHL, FedEx, UPS, Colissimo).
    /// <see href="https://ns.verisav.fr/rma#carrierName"></see></summary>
    let carrierName =
        Namespaced_IRI.parse _namespace_name "carrierName" |> NamespacedName

    /// <summary>
    /// Type of carrier service (standard, express, overnight, etc.).
    /// <see href="https://ns.verisav.fr/rma#carrierService"></see></summary>
    let carrierService =
        Namespaced_IRI.parse _namespace_name "carrierService" |> NamespacedName

    /// <summary>
    /// Links a return request, ticket, or dispute to the product it concerns.
    /// <see href="https://ns.verisav.fr/rma#concernsProduct"></see></summary>
    let concernsProduct =
        Namespaced_IRI.parse _namespace_name "concernsProduct" |> NamespacedName

    /// <summary>
    /// Date when the dispute was raised.
    /// <see href="https://ns.verisav.fr/rma#disputeDate"></see></summary>
    let disputeDate =
        Namespaced_IRI.parse _namespace_name "disputeDate" |> NamespacedName

    /// <summary>
    /// Detailed description of the dispute or complaint.
    /// <see href="https://ns.verisav.fr/rma#disputeDescription"></see></summary>
    let disputeDescription =
        Namespaced_IRI.parse _namespace_name "disputeDescription" |> NamespacedName

    /// <summary>
    /// Type of dispute (defective, damaged_shipping, wrong_item, not_as_described, missing_parts, etc.).
    /// <see href="https://ns.verisav.fr/rma#disputeType"></see></summary>
    let disputeType =
        Namespaced_IRI.parse _namespace_name "disputeType" |> NamespacedName

    /// <summary>
    /// Estimated delivery date for the package.
    /// <see href="https://ns.verisav.fr/rma#estimatedDeliveryDate"></see></summary>
    let estimatedDeliveryDate =
        Namespaced_IRI.parse _namespace_name "estimatedDeliveryDate" |> NamespacedName

    /// <summary>
    /// Expected date for receiving the returned product.
    /// <see href="https://ns.verisav.fr/rma#expectedReturnDate"></see></summary>
    let expectedReturnDate =
        Namespaced_IRI.parse _namespace_name "expectedReturnDate" |> NamespacedName

    /// <summary>
    /// The retailer, repairer, or organization handling the return request or ticket.
    /// <see href="https://ns.verisav.fr/rma#handledBy"></see></summary>
    let handledBy = Namespaced_IRI.parse _namespace_name "handledBy" |> NamespacedName

    /// <summary>
    /// Links a return request or resolution to an approval.
    /// <see href="https://ns.verisav.fr/rma#hasApproval"></see></summary>
    let hasApproval =
        Namespaced_IRI.parse _namespace_name "hasApproval" |> NamespacedName

    /// <summary>
    /// Links a return request or ticket to a dispute.
    /// <see href="https://ns.verisav.fr/rma#hasDispute"></see></summary>
    let hasDispute = Namespaced_IRI.parse _namespace_name "hasDispute" |> NamespacedName
    /// <summary>
    /// Links a ticket to messages in the conversation thread.
    /// <see href="https://ns.verisav.fr/rma#hasMessage"></see></summary>
    let hasMessage = Namespaced_IRI.parse _namespace_name "hasMessage" |> NamespacedName

    /// <summary>
    /// Links a return request, ticket, or dispute to a resolution.
    /// <see href="https://ns.verisav.fr/rma#hasResolution"></see></summary>
    let hasResolution =
        Namespaced_IRI.parse _namespace_name "hasResolution" |> NamespacedName

    /// <summary>
    /// Links a product or ticket to a return request.
    /// <see href="https://ns.verisav.fr/rma#hasReturnRequest"></see></summary>
    let hasReturnRequest =
        Namespaced_IRI.parse _namespace_name "hasReturnRequest" |> NamespacedName

    /// <summary>
    /// Links a return request to a shipping label.
    /// <see href="https://ns.verisav.fr/rma#hasShippingLabel"></see></summary>
    let hasShippingLabel =
        Namespaced_IRI.parse _namespace_name "hasShippingLabel" |> NamespacedName

    /// <summary>
    /// Links a product or return request to a service ticket.
    /// <see href="https://ns.verisav.fr/rma#hasTicket"></see></summary>
    let hasTicket = Namespaced_IRI.parse _namespace_name "hasTicket" |> NamespacedName

    /// <summary>
    /// Links a return request or shipping label to tracking information.
    /// <see href="https://ns.verisav.fr/rma#hasTracking"></see></summary>
    let hasTracking =
        Namespaced_IRI.parse _namespace_name "hasTracking" |> NamespacedName

    /// <summary>
    /// Whether the message is internal (not visible to customer).
    /// <see href="https://ns.verisav.fr/rma#isInternal"></see></summary>
    let isInternal = Namespaced_IRI.parse _namespace_name "isInternal" |> NamespacedName

    /// <summary>
    /// Date when the shipping label was created.
    /// <see href="https://ns.verisav.fr/rma#labelCreatedDate"></see></summary>
    let labelCreatedDate =
        Namespaced_IRI.parse _namespace_name "labelCreatedDate" |> NamespacedName

    /// <summary>
    /// Expiry date of the shipping label.
    /// <see href="https://ns.verisav.fr/rma#labelExpiryDate"></see></summary>
    let labelExpiryDate =
        Namespaced_IRI.parse _namespace_name "labelExpiryDate" |> NamespacedName

    /// <summary>
    /// URL or link to download the shipping label.
    /// <see href="https://ns.verisav.fr/rma#labelUrl"></see></summary>
    let labelUrl = Namespaced_IRI.parse _namespace_name "labelUrl" |> NamespacedName

    /// <summary>
    /// Date and time of the last tracking update.
    /// <see href="https://ns.verisav.fr/rma#lastTrackingUpdate"></see></summary>
    let lastTrackingUpdate =
        Namespaced_IRI.parse _namespace_name "lastTrackingUpdate" |> NamespacedName

    /// <summary>
    /// Date and time when the message was sent.
    /// <see href="https://ns.verisav.fr/rma#messageDate"></see></summary>
    let messageDate =
        Namespaced_IRI.parse _namespace_name "messageDate" |> NamespacedName

    /// <summary>
    /// Text content of the message.
    /// <see href="https://ns.verisav.fr/rma#messageText"></see></summary>
    let messageText =
        Namespaced_IRI.parse _namespace_name "messageText" |> NamespacedName

    /// <summary>
    /// Type of message (customer_message, support_response, internal_note, system_notification).
    /// <see href="https://ns.verisav.fr/rma#messageType"></see></summary>
    let messageType =
        Namespaced_IRI.parse _namespace_name "messageType" |> NamespacedName

    /// <summary>
    /// The person or organization who requested the return or created the ticket.
    /// <see href="https://ns.verisav.fr/rma#requestedBy"></see></summary>
    let requestedBy =
        Namespaced_IRI.parse _namespace_name "requestedBy" |> NamespacedName

    /// <summary>
    /// Amount for refund or store credit resolution.
    /// <see href="https://ns.verisav.fr/rma#resolutionAmount"></see></summary>
    let resolutionAmount =
        Namespaced_IRI.parse _namespace_name "resolutionAmount" |> NamespacedName

    /// <summary>
    /// Currency code for the resolution amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/rma#resolutionCurrency"></see></summary>
    let resolutionCurrency =
        Namespaced_IRI.parse _namespace_name "resolutionCurrency" |> NamespacedName

    /// <summary>
    /// Date when the resolution was proposed or applied.
    /// <see href="https://ns.verisav.fr/rma#resolutionDate"></see></summary>
    let resolutionDate =
        Namespaced_IRI.parse _namespace_name "resolutionDate" |> NamespacedName

    /// <summary>
    /// Description of the proposed or applied resolution.
    /// <see href="https://ns.verisav.fr/rma#resolutionDescription"></see></summary>
    let resolutionDescription =
        Namespaced_IRI.parse _namespace_name "resolutionDescription" |> NamespacedName

    /// <summary>
    /// Status of the resolution (proposed, approved, rejected, applied, cancelled).
    /// <see href="https://ns.verisav.fr/rma#resolutionStatus"></see></summary>
    let resolutionStatus =
        Namespaced_IRI.parse _namespace_name "resolutionStatus" |> NamespacedName

    /// <summary>
    /// Type of resolution (refund, exchange, store_credit, repair, replacement, rejection).
    /// <see href="https://ns.verisav.fr/rma#resolutionType"></see></summary>
    let resolutionType =
        Namespaced_IRI.parse _namespace_name "resolutionType" |> NamespacedName

    /// <summary>
    /// Links a return request or resolution to a work order if repair is needed.
    /// <see href="https://ns.verisav.fr/rma#resultsInWorkOrder"></see></summary>
    let resultsInWorkOrder =
        Namespaced_IRI.parse _namespace_name "resultsInWorkOrder" |> NamespacedName

    /// <summary>
    /// Reason for the return (defective, wrong_item, not_as_described, changed_mind, etc.).
    /// <see href="https://ns.verisav.fr/rma#returnReason"></see></summary>
    let returnReason =
        Namespaced_IRI.parse _namespace_name "returnReason" |> NamespacedName

    /// <summary>
    /// Date when the return request was created.
    /// <see href="https://ns.verisav.fr/rma#returnRequestDate"></see></summary>
    let returnRequestDate =
        Namespaced_IRI.parse _namespace_name "returnRequestDate" |> NamespacedName

    /// <summary>
    /// Unique identifier for the return request (RMA number).
    /// <see href="https://ns.verisav.fr/rma#returnRequestNumber"></see></summary>
    let returnRequestNumber =
        Namespaced_IRI.parse _namespace_name "returnRequestNumber" |> NamespacedName

    /// <summary>
    /// Status of the return request (pending, approved, rejected, in_transit, received, processed, completed).
    /// <see href="https://ns.verisav.fr/rma#returnRequestStatus"></see></summary>
    let returnRequestStatus =
        Namespaced_IRI.parse _namespace_name "returnRequestStatus" |> NamespacedName

    /// <summary>
    /// Date when the ticket was closed.
    /// <see href="https://ns.verisav.fr/rma#ticketClosedDate"></see></summary>
    let ticketClosedDate =
        Namespaced_IRI.parse _namespace_name "ticketClosedDate" |> NamespacedName

    /// <summary>
    /// Date when the ticket was created.
    /// <see href="https://ns.verisav.fr/rma#ticketCreatedDate"></see></summary>
    let ticketCreatedDate =
        Namespaced_IRI.parse _namespace_name "ticketCreatedDate" |> NamespacedName

    /// <summary>
    /// Unique identifier for the service ticket.
    /// <see href="https://ns.verisav.fr/rma#ticketNumber"></see></summary>
    let ticketNumber =
        Namespaced_IRI.parse _namespace_name "ticketNumber" |> NamespacedName

    /// <summary>
    /// Priority level of the ticket (low, normal, high, urgent).
    /// <see href="https://ns.verisav.fr/rma#ticketPriority"></see></summary>
    let ticketPriority =
        Namespaced_IRI.parse _namespace_name "ticketPriority" |> NamespacedName

    /// <summary>
    /// Status of the ticket (open, in_progress, waiting_customer, waiting_vendor, resolved, closed).
    /// <see href="https://ns.verisav.fr/rma#ticketStatus"></see></summary>
    let ticketStatus =
        Namespaced_IRI.parse _namespace_name "ticketStatus" |> NamespacedName

    /// <summary>
    /// Carrier tracking number for the package.
    /// <see href="https://ns.verisav.fr/rma#trackingNumber"></see></summary>
    let trackingNumber =
        Namespaced_IRI.parse _namespace_name "trackingNumber" |> NamespacedName

    /// <summary>
    /// Current tracking status (label_created, in_transit, out_for_delivery, delivered, exception).
    /// <see href="https://ns.verisav.fr/rma#trackingStatus"></see></summary>
    let trackingStatus =
        Namespaced_IRI.parse _namespace_name "trackingStatus" |> NamespacedName

    /// <summary>
    /// URL to track the package on carrier's website.
    /// <see href="https://ns.verisav.fr/rma#trackingUrl"></see></summary>
    let trackingUrl =
        Namespaced_IRI.parse _namespace_name "trackingUrl" |> NamespacedName
