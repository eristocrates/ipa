namespace https.ns.verisav.fr.rma.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rma =
    let _namespace_iri = Namespace_Iri rma |> NamespaceIRI

    /// <summary>
    ///   <para>rma:estimatedDeliveryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Estimated delivery date for the package.</para>
    /// labels<para>date de livraison estimée</para><para>estimated delivery date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#estimatedDeliveryDate">https://ns.verisav.fr/rma#estimatedDeliveryDate</seealso>
    let estimatedDeliveryDate =
        Prefixed_Name(rma, "estimatedDeliveryDate") |> PrefixedName

    /// <summary>
    ///   <para>rma:hasApproval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request or resolution to an approval.</para>
    /// labels<para>a pour approbation</para><para>has approval</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasApproval">https://ns.verisav.fr/rma#hasApproval</seealso>
    let hasApproval = Prefixed_Name(rma, "hasApproval") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasDispute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request or ticket to a dispute.</para>
    /// labels<para>a pour litige</para><para>has dispute</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasDispute">https://ns.verisav.fr/rma#hasDispute</seealso>
    let hasDispute = Prefixed_Name(rma, "hasDispute") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request, ticket, or dispute to a resolution.</para>
    /// labels<para>a pour résolution</para><para>has resolution</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasResolution">https://ns.verisav.fr/rma#hasResolution</seealso>
    let hasResolution = Prefixed_Name(rma, "hasResolution") |> PrefixedName
    /// <summary>
    ///   <para>rma:Dispute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dispute or complaint about a product (e.g., arrived broken, not as described, defective).</para>
    /// labels<para>Dispute</para><para>Litige</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Dispute">https://ns.verisav.fr/rma#Dispute</seealso>
    let Dispute = Prefixed_Name(rma, "Dispute") |> PrefixedName
    /// <summary>
    ///   <para>rma:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resolution proposed or applied to a return request or dispute (refund, exchange, store credit, repair).</para>
    /// labels<para>Resolution</para><para>Résolution</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Resolution">https://ns.verisav.fr/rma#Resolution</seealso>
    let Resolution = Prefixed_Name(rma, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>rma:ShippingLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A shipping label for returning a product, containing carrier and tracking information.</para>
    /// labels<para>Étiquette d'Expédition</para><para>Shipping Label</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ShippingLabel">https://ns.verisav.fr/rma#ShippingLabel</seealso>
    let ShippingLabel = Prefixed_Name(rma, "ShippingLabel") |> PrefixedName
    /// <summary>
    ///   <para>rma:approvalComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment associated with the approval or rejection.</para>
    /// labels<para>commentaire d'approbation</para><para>approval comment</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#approvalComment">https://ns.verisav.fr/rma#approvalComment</seealso>
    let approvalComment = Prefixed_Name(rma, "approvalComment") |> PrefixedName
    /// <summary>
    ///   <para>rma:approvalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of the approval (pending, approved, rejected).</para>
    /// labels<para>statut d'approbation</para><para>approval status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#approvalStatus">https://ns.verisav.fr/rma#approvalStatus</seealso>
    let approvalStatus = Prefixed_Name(rma, "approvalStatus") |> PrefixedName
    /// <summary>
    ///   <para>rma:authoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person or organization who authored a message.</para>
    /// labels<para>authored by</para><para>rédigé par</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#authoredBy">https://ns.verisav.fr/rma#authoredBy</seealso>
    let authoredBy = Prefixed_Name(rma, "authoredBy") |> PrefixedName
    /// <summary>
    ///   <para>rma:carrierService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of carrier service (standard, express, overnight, etc.).</para>
    /// labels<para>service transporteur</para><para>carrier service</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#carrierService">https://ns.verisav.fr/rma#carrierService</seealso>
    let carrierService = Prefixed_Name(rma, "carrierService") |> PrefixedName
    /// <summary>
    ///   <para>rma:disputeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Detailed description of the dispute or complaint.</para>
    /// labels<para>description du litige</para><para>dispute description</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#disputeDescription">https://ns.verisav.fr/rma#disputeDescription</seealso>
    let disputeDescription = Prefixed_Name(rma, "disputeDescription") |> PrefixedName
    /// <summary>
    ///   <para>rma:Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An approval or authorization for a return request or resolution.</para>
    /// labels<para>Approbation</para><para>Approval</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Approval">https://ns.verisav.fr/rma#Approval</seealso>
    let Approval = Prefixed_Name(rma, "Approval") |> PrefixedName
    /// <summary>
    ///   <para>rma:ReturnRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A request for returning a product to a retailer or manufacturer.</para>
    /// labels<para>Demande de Retour</para><para>Return Request</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ReturnRequest">https://ns.verisav.fr/rma#ReturnRequest</seealso>
    let ReturnRequest = Prefixed_Name(rma, "ReturnRequest") |> PrefixedName
    /// <summary>
    ///   <para>rma:Ticket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service ticket that tracks customer service interactions and issue resolution.</para>
    /// labels<para>Service Ticket</para><para>Ticket SAV</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Ticket">https://ns.verisav.fr/rma#Ticket</seealso>
    let Ticket = Prefixed_Name(rma, "Ticket") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a product or return request to a service ticket.</para>
    /// labels<para>a pour ticket</para><para>has ticket</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasTicket">https://ns.verisav.fr/rma#hasTicket</seealso>
    let hasTicket = Prefixed_Name(rma, "hasTicket") |> PrefixedName
    /// <summary>
    ///   <para>rma:isInternal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether the message is internal (not visible to customer).</para>
    /// labels<para>est interne</para><para>is internal</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#isInternal">https://ns.verisav.fr/rma#isInternal</seealso>
    let isInternal = Prefixed_Name(rma, "isInternal") |> PrefixedName
    /// <summary>
    ///   <para>rma:labelExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expiry date of the shipping label.</para>
    /// labels<para>date d'expiration de l'étiquette</para><para>label expiry date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#labelExpiryDate">https://ns.verisav.fr/rma#labelExpiryDate</seealso>
    let labelExpiryDate = Prefixed_Name(rma, "labelExpiryDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:lastTrackingUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time of the last tracking update.</para>
    /// labels<para>dernière mise à jour de suivi</para><para>last tracking update</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#lastTrackingUpdate">https://ns.verisav.fr/rma#lastTrackingUpdate</seealso>
    let lastTrackingUpdate = Prefixed_Name(rma, "lastTrackingUpdate") |> PrefixedName
    /// <summary>
    ///   <para>rma:messageText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text content of the message.</para>
    /// labels<para>texte du message</para><para>message text</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#messageText">https://ns.verisav.fr/rma#messageText</seealso>
    let messageText = Prefixed_Name(rma, "messageText") |> PrefixedName
    /// <summary>
    ///   <para>rma:requestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person or organization who requested the return or created the ticket.</para>
    /// labels<para>requested by</para><para>demandé par</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#requestedBy">https://ns.verisav.fr/rma#requestedBy</seealso>
    let requestedBy = Prefixed_Name(rma, "requestedBy") |> PrefixedName
    /// <summary>
    ///   <para>rma:resolutionCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Currency code for the resolution amount (ISO 4217).</para>
    /// labels<para>devise de résolution</para><para>resolution currency</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionCurrency">https://ns.verisav.fr/rma#resolutionCurrency</seealso>
    let resolutionCurrency = Prefixed_Name(rma, "resolutionCurrency") |> PrefixedName
    /// <summary>
    ///   <para>rma:resolutionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of the resolution (proposed, approved, rejected, applied, cancelled).</para>
    /// labels<para>statut de résolution</para><para>resolution status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionStatus">https://ns.verisav.fr/rma#resolutionStatus</seealso>
    let resolutionStatus = Prefixed_Name(rma, "resolutionStatus") |> PrefixedName
    /// <summary>
    ///   <para>rma:returnReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reason for the return (defective, wrong_item, not_as_described, changed_mind, etc.).</para>
    /// labels<para>raison du retour</para><para>return reason</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#returnReason">https://ns.verisav.fr/rma#returnReason</seealso>
    let returnReason = Prefixed_Name(rma, "returnReason") |> PrefixedName
    /// <summary>
    ///   <para>rma:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A message in a ticket conversation thread between customer, retailer, or repairer.</para>
    /// labels<para>Message</para><para>Message</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Message">https://ns.verisav.fr/rma#Message</seealso>
    let Message = Prefixed_Name(rma, "Message") |> PrefixedName
    /// <summary>
    ///   <para>rma:disputeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the dispute was raised.</para>
    /// labels<para>date du litige</para><para>dispute date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#disputeDate">https://ns.verisav.fr/rma#disputeDate</seealso>
    let disputeDate = Prefixed_Name(rma, "disputeDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:disputeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of dispute (defective, damaged_shipping, wrong_item, not_as_described, missing_parts, etc.).</para>
    /// labels<para>type de litige</para><para>dispute type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#disputeType">https://ns.verisav.fr/rma#disputeType</seealso>
    let disputeType = Prefixed_Name(rma, "disputeType") |> PrefixedName
    /// <summary>
    ///   <para>rma:expectedReturnDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expected date for receiving the returned product.</para>
    /// labels<para>date de retour attendue</para><para>expected return date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#expectedReturnDate">https://ns.verisav.fr/rma#expectedReturnDate</seealso>
    let expectedReturnDate = Prefixed_Name(rma, "expectedReturnDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:handledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The retailer, repairer, or organization handling the return request or ticket.</para>
    /// labels<para>handled by</para><para>traité par</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#handledBy">https://ns.verisav.fr/rma#handledBy</seealso>
    let handledBy = Prefixed_Name(rma, "handledBy") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ticket to messages in the conversation thread.</para>
    /// labels<para>a pour message</para><para>has message</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasMessage">https://ns.verisav.fr/rma#hasMessage</seealso>
    let hasMessage = Prefixed_Name(rma, "hasMessage") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasReturnRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a product or ticket to a return request.</para>
    /// labels<para>a pour demande de retour</para><para>has return request</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasReturnRequest">https://ns.verisav.fr/rma#hasReturnRequest</seealso>
    let hasReturnRequest = Prefixed_Name(rma, "hasReturnRequest") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasShippingLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request to a shipping label.</para>
    /// labels<para>a pour étiquette d'expédition</para><para>has shipping label</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasShippingLabel">https://ns.verisav.fr/rma#hasShippingLabel</seealso>
    let hasShippingLabel = Prefixed_Name(rma, "hasShippingLabel") |> PrefixedName
    /// <summary>
    ///   <para>rma:hasTracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request or shipping label to tracking information.</para>
    /// labels<para>has tracking</para><para>a pour suivi</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#hasTracking">https://ns.verisav.fr/rma#hasTracking</seealso>
    let hasTracking = Prefixed_Name(rma, "hasTracking") |> PrefixedName
    /// <summary>
    ///   <para>rma:labelCreatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the shipping label was created.</para>
    /// labels<para>date de création de l'étiquette</para><para>label created date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#labelCreatedDate">https://ns.verisav.fr/rma#labelCreatedDate</seealso>
    let labelCreatedDate = Prefixed_Name(rma, "labelCreatedDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:labelUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL or link to download the shipping label.</para>
    /// labels<para>URL de l'étiquette</para><para>label URL</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#labelUrl">https://ns.verisav.fr/rma#labelUrl</seealso>
    let labelUrl = Prefixed_Name(rma, "labelUrl") |> PrefixedName
    /// <summary>
    ///   <para>rma:messageDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time when the message was sent.</para>
    /// labels<para>date du message</para><para>message date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#messageDate">https://ns.verisav.fr/rma#messageDate</seealso>
    let messageDate = Prefixed_Name(rma, "messageDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:messageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of message (customer_message, support_response, internal_note, system_notification).</para>
    /// labels<para>type de message</para><para>message type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#messageType">https://ns.verisav.fr/rma#messageType</seealso>
    let messageType = Prefixed_Name(rma, "messageType") |> PrefixedName
    /// <summary>
    ///   <para>rma:resolutionAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount for refund or store credit resolution.</para>
    /// labels<para>montant de résolution</para><para>resolution amount</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionAmount">https://ns.verisav.fr/rma#resolutionAmount</seealso>
    let resolutionAmount = Prefixed_Name(rma, "resolutionAmount") |> PrefixedName
    /// <summary>
    ///   <para>rma:resolutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the resolution was proposed or applied.</para>
    /// labels<para>date de résolution</para><para>resolution date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionDate">https://ns.verisav.fr/rma#resolutionDate</seealso>
    let resolutionDate = Prefixed_Name(rma, "resolutionDate") |> PrefixedName

    /// <summary>
    ///   <para>rma:resolutionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Description of the proposed or applied resolution.</para>
    /// labels<para>description de résolution</para><para>resolution description</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionDescription">https://ns.verisav.fr/rma#resolutionDescription</seealso>
    let resolutionDescription =
        Prefixed_Name(rma, "resolutionDescription") |> PrefixedName

    /// <summary>
    ///   <para>rma:resolutionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of resolution (refund, exchange, store_credit, repair, replacement, rejection).</para>
    /// labels<para>type de résolution</para><para>resolution type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resolutionType">https://ns.verisav.fr/rma#resolutionType</seealso>
    let resolutionType = Prefixed_Name(rma, "resolutionType") |> PrefixedName
    /// <summary>
    ///   <para>rma:resultsInWorkOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request or resolution to a work order if repair is needed.</para>
    /// labels<para>résulte en ordre de travail</para><para>results in work order</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#resultsInWorkOrder">https://ns.verisav.fr/rma#resultsInWorkOrder</seealso>
    let resultsInWorkOrder = Prefixed_Name(rma, "resultsInWorkOrder") |> PrefixedName
    /// <summary>
    ///   <para>rma:returnRequestNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier for the return request (RMA number).</para>
    /// labels<para>numéro de demande de retour</para><para>return request number</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#returnRequestNumber">https://ns.verisav.fr/rma#returnRequestNumber</seealso>
    let returnRequestNumber = Prefixed_Name(rma, "returnRequestNumber") |> PrefixedName
    /// <summary>
    ///   <para>rma:returnRequestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of the return request (pending, approved, rejected, in_transit, received, processed, completed).</para>
    /// labels<para>statut de demande de retour</para><para>return request status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#returnRequestStatus">https://ns.verisav.fr/rma#returnRequestStatus</seealso>
    let returnRequestStatus = Prefixed_Name(rma, "returnRequestStatus") |> PrefixedName
    /// <summary>
    ///   <para>rma:ticketClosedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the ticket was closed.</para>
    /// labels<para>date de fermeture du ticket</para><para>ticket closed date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ticketClosedDate">https://ns.verisav.fr/rma#ticketClosedDate</seealso>
    let ticketClosedDate = Prefixed_Name(rma, "ticketClosedDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:ticketCreatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the ticket was created.</para>
    /// labels<para>date de création du ticket</para><para>ticket created date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ticketCreatedDate">https://ns.verisav.fr/rma#ticketCreatedDate</seealso>
    let ticketCreatedDate = Prefixed_Name(rma, "ticketCreatedDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:ticketPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Priority level of the ticket (low, normal, high, urgent).</para>
    /// labels<para>priorité du ticket</para><para>ticket priority</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ticketPriority">https://ns.verisav.fr/rma#ticketPriority</seealso>
    let ticketPriority = Prefixed_Name(rma, "ticketPriority") |> PrefixedName
    /// <summary>
    ///   <para>rma:ticketStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of the ticket (open, in_progress, waiting_customer, waiting_vendor, resolved, closed).</para>
    /// labels<para>statut du ticket</para><para>ticket status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ticketStatus">https://ns.verisav.fr/rma#ticketStatus</seealso>
    let ticketStatus = Prefixed_Name(rma, "ticketStatus") |> PrefixedName
    /// <summary>
    ///   <para>rma:trackingStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Current tracking status (label_created, in_transit, out_for_delivery, delivered, exception).</para>
    /// labels<para>statut de suivi</para><para>tracking status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#trackingStatus">https://ns.verisav.fr/rma#trackingStatus</seealso>
    let trackingStatus = Prefixed_Name(rma, "trackingStatus") |> PrefixedName
    /// <summary>
    ///   <para>rma:trackingUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL to track the package on carrier's website.</para>
    /// labels<para>tracking URL</para><para>URL de suivi</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#trackingUrl">https://ns.verisav.fr/rma#trackingUrl</seealso>
    let trackingUrl = Prefixed_Name(rma, "trackingUrl") |> PrefixedName
    /// <summary>
    ///   <para>rma:Tracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tracking information for a returned package, including carrier events and status.</para>
    /// labels<para>Package Tracking</para><para>Suivi Colis</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#Tracking">https://ns.verisav.fr/rma#Tracking</seealso>
    let Tracking = Prefixed_Name(rma, "Tracking") |> PrefixedName
    /// <summary>
    ///   <para>rma:approvalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the approval was given.</para>
    /// labels<para>date d'approbation</para><para>approval date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#approvalDate">https://ns.verisav.fr/rma#approvalDate</seealso>
    let approvalDate = Prefixed_Name(rma, "approvalDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:approvedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person or organization who approved the return request or resolution.</para>
    /// labels<para>approuvé par</para><para>approved by</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#approvedBy">https://ns.verisav.fr/rma#approvedBy</seealso>
    let approvedBy = Prefixed_Name(rma, "approvedBy") |> PrefixedName
    /// <summary>
    ///   <para>rma:carrierName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the shipping carrier (e.g., DHL, FedEx, UPS, Colissimo).</para>
    /// labels<para>nom du transporteur</para><para>carrier name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#carrierName">https://ns.verisav.fr/rma#carrierName</seealso>
    let carrierName = Prefixed_Name(rma, "carrierName") |> PrefixedName
    /// <summary>
    ///   <para>rma:concernsProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a return request, ticket, or dispute to the product it concerns.</para>
    /// labels<para>concerne le produit</para><para>concerns product</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#concernsProduct">https://ns.verisav.fr/rma#concernsProduct</seealso>
    let concernsProduct = Prefixed_Name(rma, "concernsProduct") |> PrefixedName
    /// <summary>
    ///   <para>rma:trackingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Carrier tracking number for the package.</para>
    /// labels<para>tracking number</para><para>numéro de suivi</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#trackingNumber">https://ns.verisav.fr/rma#trackingNumber</seealso>
    let trackingNumber = Prefixed_Name(rma, "trackingNumber") |> PrefixedName
    /// <summary>
    ///   <para>rma:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>Version 1.0.0 (2025-12-28): Initial release. Vocabulary for managing return requests, service tickets, disputes, and resolutions in after-sales service workflows.</para>
    ///   <para>Version 1.0.0 (2025-12-28): Version initiale. Vocabulaire pour gérer les demandes de retour, tickets SAV, litiges et résolutions dans les workflows de service après-vente.</para>
    /// labels<para>Vocabulaire RMA Verisav</para><para>Verisav RMA Vocabulary</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#">https://ns.verisav.fr/rma#</seealso>
    let _prefix_iri = Prefixed_Name(rma, "") |> PrefixedName
    /// <summary>
    ///   <para>rma:returnRequestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the return request was created.</para>
    /// labels<para>date de demande de retour</para><para>return request date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#returnRequestDate">https://ns.verisav.fr/rma#returnRequestDate</seealso>
    let returnRequestDate = Prefixed_Name(rma, "returnRequestDate") |> PrefixedName
    /// <summary>
    ///   <para>rma:ticketNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier for the service ticket.</para>
    /// labels<para>numéro de ticket</para><para>ticket number</para></remarks>
    /// <seealso href="https://ns.verisav.fr/rma#ticketNumber">https://ns.verisav.fr/rma#ticketNumber</seealso>
    let ticketNumber = Prefixed_Name(rma, "ticketNumber") |> PrefixedName
