namespace https.ns.verisav.fr.rma.hash

open DoxAletheia

module rma =
    let _namespace_name = "https://ns.verisav.fr/rma#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An approval or authorization for a return request or resolution.
    /// <see href="https://ns.verisav.fr/rma#Approval"></see></summary>
    let Approval = _prefix "Approval"
    /// <summary>
    /// A dispute or complaint about a product (e.g., arrived broken, not as described, defective).
    /// <see href="https://ns.verisav.fr/rma#Dispute"></see></summary>
    let Dispute = _prefix "Dispute"
    /// <summary>
    /// A message in a ticket conversation thread between customer, retailer, or repairer.
    /// <see href="https://ns.verisav.fr/rma#Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// A resolution proposed or applied to a return request or dispute (refund, exchange, store credit, repair).
    /// <see href="https://ns.verisav.fr/rma#Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// A request for returning a product to a retailer or manufacturer.
    /// <see href="https://ns.verisav.fr/rma#ReturnRequest"></see></summary>
    let ReturnRequest = _prefix "ReturnRequest"
    /// <summary>
    /// A shipping label for returning a product, containing carrier and tracking information.
    /// <see href="https://ns.verisav.fr/rma#ShippingLabel"></see></summary>
    let ShippingLabel = _prefix "ShippingLabel"
    /// <summary>
    /// A service ticket that tracks customer service interactions and issue resolution.
    /// <see href="https://ns.verisav.fr/rma#Ticket"></see></summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    /// Tracking information for a returned package, including carrier events and status.
    /// <see href="https://ns.verisav.fr/rma#Tracking"></see></summary>
    let Tracking = _prefix "Tracking"
    /// <summary>
    /// Comment associated with the approval or rejection.
    /// <see href="https://ns.verisav.fr/rma#approvalComment"></see></summary>
    let approvalComment = _prefix "approvalComment"
    /// <summary>
    /// Date when the approval was given.
    /// <see href="https://ns.verisav.fr/rma#approvalDate"></see></summary>
    let approvalDate = _prefix "approvalDate"
    /// <summary>
    /// Status of the approval (pending, approved, rejected).
    /// <see href="https://ns.verisav.fr/rma#approvalStatus"></see></summary>
    let approvalStatus = _prefix "approvalStatus"
    /// <summary>
    /// The person or organization who approved the return request or resolution.
    /// <see href="https://ns.verisav.fr/rma#approvedBy"></see></summary>
    let approvedBy = _prefix "approvedBy"
    /// <summary>
    /// The person or organization who authored a message.
    /// <see href="https://ns.verisav.fr/rma#authoredBy"></see></summary>
    let authoredBy = _prefix "authoredBy"
    /// <summary>
    /// Name of the shipping carrier (e.g., DHL, FedEx, UPS, Colissimo).
    /// <see href="https://ns.verisav.fr/rma#carrierName"></see></summary>
    let carrierName = _prefix "carrierName"
    /// <summary>
    /// Type of carrier service (standard, express, overnight, etc.).
    /// <see href="https://ns.verisav.fr/rma#carrierService"></see></summary>
    let carrierService = _prefix "carrierService"
    /// <summary>
    /// Links a return request, ticket, or dispute to the product it concerns.
    /// <see href="https://ns.verisav.fr/rma#concernsProduct"></see></summary>
    let concernsProduct = _prefix "concernsProduct"
    /// <summary>
    /// Date when the dispute was raised.
    /// <see href="https://ns.verisav.fr/rma#disputeDate"></see></summary>
    let disputeDate = _prefix "disputeDate"
    /// <summary>
    /// Detailed description of the dispute or complaint.
    /// <see href="https://ns.verisav.fr/rma#disputeDescription"></see></summary>
    let disputeDescription = _prefix "disputeDescription"
    /// <summary>
    /// Type of dispute (defective, damaged_shipping, wrong_item, not_as_described, missing_parts, etc.).
    /// <see href="https://ns.verisav.fr/rma#disputeType"></see></summary>
    let disputeType = _prefix "disputeType"
    /// <summary>
    /// Estimated delivery date for the package.
    /// <see href="https://ns.verisav.fr/rma#estimatedDeliveryDate"></see></summary>
    let estimatedDeliveryDate = _prefix "estimatedDeliveryDate"
    /// <summary>
    /// Expected date for receiving the returned product.
    /// <see href="https://ns.verisav.fr/rma#expectedReturnDate"></see></summary>
    let expectedReturnDate = _prefix "expectedReturnDate"
    /// <summary>
    /// The retailer, repairer, or organization handling the return request or ticket.
    /// <see href="https://ns.verisav.fr/rma#handledBy"></see></summary>
    let handledBy = _prefix "handledBy"
    /// <summary>
    /// Links a return request or resolution to an approval.
    /// <see href="https://ns.verisav.fr/rma#hasApproval"></see></summary>
    let hasApproval = _prefix "hasApproval"
    /// <summary>
    /// Links a return request or ticket to a dispute.
    /// <see href="https://ns.verisav.fr/rma#hasDispute"></see></summary>
    let hasDispute = _prefix "hasDispute"
    /// <summary>
    /// Links a ticket to messages in the conversation thread.
    /// <see href="https://ns.verisav.fr/rma#hasMessage"></see></summary>
    let hasMessage = _prefix "hasMessage"
    /// <summary>
    /// Links a return request, ticket, or dispute to a resolution.
    /// <see href="https://ns.verisav.fr/rma#hasResolution"></see></summary>
    let hasResolution = _prefix "hasResolution"
    /// <summary>
    /// Links a product or ticket to a return request.
    /// <see href="https://ns.verisav.fr/rma#hasReturnRequest"></see></summary>
    let hasReturnRequest = _prefix "hasReturnRequest"
    /// <summary>
    /// Links a return request to a shipping label.
    /// <see href="https://ns.verisav.fr/rma#hasShippingLabel"></see></summary>
    let hasShippingLabel = _prefix "hasShippingLabel"
    /// <summary>
    /// Links a product or return request to a service ticket.
    /// <see href="https://ns.verisav.fr/rma#hasTicket"></see></summary>
    let hasTicket = _prefix "hasTicket"
    /// <summary>
    /// Links a return request or shipping label to tracking information.
    /// <see href="https://ns.verisav.fr/rma#hasTracking"></see></summary>
    let hasTracking = _prefix "hasTracking"
    /// <summary>
    /// Whether the message is internal (not visible to customer).
    /// <see href="https://ns.verisav.fr/rma#isInternal"></see></summary>
    let isInternal = _prefix "isInternal"
    /// <summary>
    /// Date when the shipping label was created.
    /// <see href="https://ns.verisav.fr/rma#labelCreatedDate"></see></summary>
    let labelCreatedDate = _prefix "labelCreatedDate"
    /// <summary>
    /// Expiry date of the shipping label.
    /// <see href="https://ns.verisav.fr/rma#labelExpiryDate"></see></summary>
    let labelExpiryDate = _prefix "labelExpiryDate"
    /// <summary>
    /// URL or link to download the shipping label.
    /// <see href="https://ns.verisav.fr/rma#labelUrl"></see></summary>
    let labelUrl = _prefix "labelUrl"
    /// <summary>
    /// Date and time of the last tracking update.
    /// <see href="https://ns.verisav.fr/rma#lastTrackingUpdate"></see></summary>
    let lastTrackingUpdate = _prefix "lastTrackingUpdate"
    /// <summary>
    /// Date and time when the message was sent.
    /// <see href="https://ns.verisav.fr/rma#messageDate"></see></summary>
    let messageDate = _prefix "messageDate"
    /// <summary>
    /// Text content of the message.
    /// <see href="https://ns.verisav.fr/rma#messageText"></see></summary>
    let messageText = _prefix "messageText"
    /// <summary>
    /// Type of message (customer_message, support_response, internal_note, system_notification).
    /// <see href="https://ns.verisav.fr/rma#messageType"></see></summary>
    let messageType = _prefix "messageType"
    /// <summary>
    /// The person or organization who requested the return or created the ticket.
    /// <see href="https://ns.verisav.fr/rma#requestedBy"></see></summary>
    let requestedBy = _prefix "requestedBy"
    /// <summary>
    /// Amount for refund or store credit resolution.
    /// <see href="https://ns.verisav.fr/rma#resolutionAmount"></see></summary>
    let resolutionAmount = _prefix "resolutionAmount"
    /// <summary>
    /// Currency code for the resolution amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/rma#resolutionCurrency"></see></summary>
    let resolutionCurrency = _prefix "resolutionCurrency"
    /// <summary>
    /// Date when the resolution was proposed or applied.
    /// <see href="https://ns.verisav.fr/rma#resolutionDate"></see></summary>
    let resolutionDate = _prefix "resolutionDate"
    /// <summary>
    /// Description of the proposed or applied resolution.
    /// <see href="https://ns.verisav.fr/rma#resolutionDescription"></see></summary>
    let resolutionDescription = _prefix "resolutionDescription"
    /// <summary>
    /// Status of the resolution (proposed, approved, rejected, applied, cancelled).
    /// <see href="https://ns.verisav.fr/rma#resolutionStatus"></see></summary>
    let resolutionStatus = _prefix "resolutionStatus"
    /// <summary>
    /// Type of resolution (refund, exchange, store_credit, repair, replacement, rejection).
    /// <see href="https://ns.verisav.fr/rma#resolutionType"></see></summary>
    let resolutionType = _prefix "resolutionType"
    /// <summary>
    /// Links a return request or resolution to a work order if repair is needed.
    /// <see href="https://ns.verisav.fr/rma#resultsInWorkOrder"></see></summary>
    let resultsInWorkOrder = _prefix "resultsInWorkOrder"
    /// <summary>
    /// Reason for the return (defective, wrong_item, not_as_described, changed_mind, etc.).
    /// <see href="https://ns.verisav.fr/rma#returnReason"></see></summary>
    let returnReason = _prefix "returnReason"
    /// <summary>
    /// Date when the return request was created.
    /// <see href="https://ns.verisav.fr/rma#returnRequestDate"></see></summary>
    let returnRequestDate = _prefix "returnRequestDate"
    /// <summary>
    /// Unique identifier for the return request (RMA number).
    /// <see href="https://ns.verisav.fr/rma#returnRequestNumber"></see></summary>
    let returnRequestNumber = _prefix "returnRequestNumber"
    /// <summary>
    /// Status of the return request (pending, approved, rejected, in_transit, received, processed, completed).
    /// <see href="https://ns.verisav.fr/rma#returnRequestStatus"></see></summary>
    let returnRequestStatus = _prefix "returnRequestStatus"
    /// <summary>
    /// Date when the ticket was closed.
    /// <see href="https://ns.verisav.fr/rma#ticketClosedDate"></see></summary>
    let ticketClosedDate = _prefix "ticketClosedDate"
    /// <summary>
    /// Date when the ticket was created.
    /// <see href="https://ns.verisav.fr/rma#ticketCreatedDate"></see></summary>
    let ticketCreatedDate = _prefix "ticketCreatedDate"
    /// <summary>
    /// Unique identifier for the service ticket.
    /// <see href="https://ns.verisav.fr/rma#ticketNumber"></see></summary>
    let ticketNumber = _prefix "ticketNumber"
    /// <summary>
    /// Priority level of the ticket (low, normal, high, urgent).
    /// <see href="https://ns.verisav.fr/rma#ticketPriority"></see></summary>
    let ticketPriority = _prefix "ticketPriority"
    /// <summary>
    /// Status of the ticket (open, in_progress, waiting_customer, waiting_vendor, resolved, closed).
    /// <see href="https://ns.verisav.fr/rma#ticketStatus"></see></summary>
    let ticketStatus = _prefix "ticketStatus"
    /// <summary>
    /// Carrier tracking number for the package.
    /// <see href="https://ns.verisav.fr/rma#trackingNumber"></see></summary>
    let trackingNumber = _prefix "trackingNumber"
    /// <summary>
    /// Current tracking status (label_created, in_transit, out_for_delivery, delivered, exception).
    /// <see href="https://ns.verisav.fr/rma#trackingStatus"></see></summary>
    let trackingStatus = _prefix "trackingStatus"
    /// <summary>
    /// URL to track the package on carrier's website.
    /// <see href="https://ns.verisav.fr/rma#trackingUrl"></see></summary>
    let trackingUrl = _prefix "trackingUrl"
