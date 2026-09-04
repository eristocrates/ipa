#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rma =
    let _prefixId = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/rma#" "rma"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Approvalrdfs:label : Approbation</para>
    ///   <para>rdfs:comment : An approval or authorization for a return request or resolution.</para>
    ///   <a href="https://ns.verisav.fr/rma#Approval">rma:Approval</a>
    /// </summary>
    let Approval = _prefixId.prefix "Approval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Disputerdfs:label : Litige</para>
    ///   <para>rdfs:comment : A dispute or complaint about a product (e.g., arrived broken, not as described, defective).</para>
    ///   <a href="https://ns.verisav.fr/rma#Dispute">rma:Dispute</a>
    /// </summary>
    let Dispute = _prefixId.prefix "Dispute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Messagerdfs:label : Message</para>
    ///   <para>rdfs:comment : A message in a ticket conversation thread between customer, retailer, or repairer.</para>
    ///   <a href="https://ns.verisav.fr/rma#Message">rma:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Resolutionrdfs:label : Résolution</para>
    ///   <para>rdfs:comment : A resolution proposed or applied to a return request or dispute (refund, exchange, store credit, repair).</para>
    ///   <a href="https://ns.verisav.fr/rma#Resolution">rma:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Return Requestrdfs:label : Demande de Retour</para>
    ///   <para>rdfs:comment : A request for returning a product to a retailer or manufacturer.</para>
    ///   <a href="https://ns.verisav.fr/rma#ReturnRequest">rma:ReturnRequest</a>
    /// </summary>
    let ReturnRequest = _prefixId.prefix "ReturnRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Shipping Labelrdfs:label : Étiquette d'Expédition</para>
    ///   <para>rdfs:comment : A shipping label for returning a product, containing carrier and tracking information.</para>
    ///   <a href="https://ns.verisav.fr/rma#ShippingLabel">rma:ShippingLabel</a>
    /// </summary>
    let ShippingLabel = _prefixId.prefix "ShippingLabel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Service Ticketrdfs:label : Ticket SAV</para>
    ///   <para>rdfs:comment : A service ticket that tracks customer service interactions and issue resolution.</para>
    ///   <a href="https://ns.verisav.fr/rma#Ticket">rma:Ticket</a>
    /// </summary>
    let Ticket = _prefixId.prefix "Ticket"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Package Trackingrdfs:label : Suivi Colis</para>
    ///   <para>rdfs:comment : Tracking information for a returned package, including carrier events and status.</para>
    ///   <a href="https://ns.verisav.fr/rma#Tracking">rma:Tracking</a>
    /// </summary>
    let Tracking = _prefixId.prefix "Tracking"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : approval commentrdfs:label : commentaire d'approbation</para>
    ///   <para>rdfs:comment : Comment associated with the approval or rejection.</para>
    ///   <a href="https://ns.verisav.fr/rma#approvalComment">rma:approvalComment</a>
    /// </summary>
    let approvalComment = _prefixId.prefix "approvalComment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : approval daterdfs:label : date d'approbation</para>
    ///   <para>rdfs:comment : Date when the approval was given.</para>
    ///   <a href="https://ns.verisav.fr/rma#approvalDate">rma:approvalDate</a>
    /// </summary>
    let approvalDate = _prefixId.prefix "approvalDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : approval statusrdfs:label : statut d'approbation</para>
    ///   <para>rdfs:comment : Status of the approval (pending, approved, rejected).</para>
    ///   <a href="https://ns.verisav.fr/rma#approvalStatus">rma:approvalStatus</a>
    /// </summary>
    let approvalStatus = _prefixId.prefix "approvalStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : approved byrdfs:label : approuvé par</para>
    ///   <para>rdfs:comment : The person or organization who approved the return request or resolution.</para>
    ///   <a href="https://ns.verisav.fr/rma#approvedBy">rma:approvedBy</a>
    /// </summary>
    let approvedBy = _prefixId.prefix "approvedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : authored byrdfs:label : rédigé par</para>
    ///   <para>rdfs:comment : The person or organization who authored a message.</para>
    ///   <a href="https://ns.verisav.fr/rma#authoredBy">rma:authoredBy</a>
    /// </summary>
    let authoredBy = _prefixId.prefix "authoredBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : carrier namerdfs:label : nom du transporteur</para>
    ///   <para>rdfs:comment : Name of the shipping carrier (e.g., DHL, FedEx, UPS, Colissimo).</para>
    ///   <a href="https://ns.verisav.fr/rma#carrierName">rma:carrierName</a>
    /// </summary>
    let carrierName = _prefixId.prefix "carrierName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : carrier servicerdfs:label : service transporteur</para>
    ///   <para>rdfs:comment : Type of carrier service (standard, express, overnight, etc.).</para>
    ///   <a href="https://ns.verisav.fr/rma#carrierService">rma:carrierService</a>
    /// </summary>
    let carrierService = _prefixId.prefix "carrierService"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : concerns productrdfs:label : concerne le produit</para>
    ///   <para>rdfs:comment : Links a return request, ticket, or dispute to the product it concerns.</para>
    ///   <a href="https://ns.verisav.fr/rma#concernsProduct">rma:concernsProduct</a>
    /// </summary>
    let concernsProduct = _prefixId.prefix "concernsProduct"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dispute daterdfs:label : date du litige</para>
    ///   <para>rdfs:comment : Date when the dispute was raised.</para>
    ///   <a href="https://ns.verisav.fr/rma#disputeDate">rma:disputeDate</a>
    /// </summary>
    let disputeDate = _prefixId.prefix "disputeDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dispute descriptionrdfs:label : description du litige</para>
    ///   <para>rdfs:comment : Detailed description of the dispute or complaint.</para>
    ///   <a href="https://ns.verisav.fr/rma#disputeDescription">rma:disputeDescription</a>
    /// </summary>
    let disputeDescription = _prefixId.prefix "disputeDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dispute typerdfs:label : type de litige</para>
    ///   <para>rdfs:comment : Type of dispute (defective, damaged_shipping, wrong_item, not_as_described, missing_parts, etc.).</para>
    ///   <a href="https://ns.verisav.fr/rma#disputeType">rma:disputeType</a>
    /// </summary>
    let disputeType = _prefixId.prefix "disputeType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : estimated delivery daterdfs:label : date de livraison estimée</para>
    ///   <para>rdfs:comment : Estimated delivery date for the package.</para>
    ///   <a href="https://ns.verisav.fr/rma#estimatedDeliveryDate">rma:estimatedDeliveryDate</a>
    /// </summary>
    let estimatedDeliveryDate = _prefixId.prefix "estimatedDeliveryDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : expected return daterdfs:label : date de retour attendue</para>
    ///   <para>rdfs:comment : Expected date for receiving the returned product.</para>
    ///   <a href="https://ns.verisav.fr/rma#expectedReturnDate">rma:expectedReturnDate</a>
    /// </summary>
    let expectedReturnDate = _prefixId.prefix "expectedReturnDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : handled byrdfs:label : traité par</para>
    ///   <para>rdfs:comment : The retailer, repairer, or organization handling the return request or ticket.</para>
    ///   <a href="https://ns.verisav.fr/rma#handledBy">rma:handledBy</a>
    /// </summary>
    let handledBy = _prefixId.prefix "handledBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has approvalrdfs:label : a pour approbation</para>
    ///   <para>rdfs:comment : Links a return request or resolution to an approval.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasApproval">rma:hasApproval</a>
    /// </summary>
    let hasApproval = _prefixId.prefix "hasApproval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has disputerdfs:label : a pour litige</para>
    ///   <para>rdfs:comment : Links a return request or ticket to a dispute.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasDispute">rma:hasDispute</a>
    /// </summary>
    let hasDispute = _prefixId.prefix "hasDispute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has messagerdfs:label : a pour message</para>
    ///   <para>rdfs:comment : Links a ticket to messages in the conversation thread.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasMessage">rma:hasMessage</a>
    /// </summary>
    let hasMessage = _prefixId.prefix "hasMessage"
    /// <summary>
    ///   <para>rdfs:label : has resolutionrdfs:label : a pour résolution</para>
    ///   <para>rdfs:comment : Links a return request, ticket, or dispute to a resolution.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/rma#hasResolution">rma:hasResolution</a>
    /// </summary>
    let hasResolution = _prefixId.prefix "hasResolution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has return requestrdfs:label : a pour demande de retour</para>
    ///   <para>rdfs:comment : Links a product or ticket to a return request.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasReturnRequest">rma:hasReturnRequest</a>
    /// </summary>
    let hasReturnRequest = _prefixId.prefix "hasReturnRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has shipping labelrdfs:label : a pour étiquette d'expédition</para>
    ///   <para>rdfs:comment : Links a return request to a shipping label.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasShippingLabel">rma:hasShippingLabel</a>
    /// </summary>
    let hasShippingLabel = _prefixId.prefix "hasShippingLabel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has ticketrdfs:label : a pour ticket</para>
    ///   <para>rdfs:comment : Links a product or return request to a service ticket.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasTicket">rma:hasTicket</a>
    /// </summary>
    let hasTicket = _prefixId.prefix "hasTicket"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has trackingrdfs:label : a pour suivi</para>
    ///   <para>rdfs:comment : Links a return request or shipping label to tracking information.</para>
    ///   <a href="https://ns.verisav.fr/rma#hasTracking">rma:hasTracking</a>
    /// </summary>
    let hasTracking = _prefixId.prefix "hasTracking"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is internalrdfs:label : est interne</para>
    ///   <para>rdfs:comment : Whether the message is internal (not visible to customer).</para>
    ///   <a href="https://ns.verisav.fr/rma#isInternal">rma:isInternal</a>
    /// </summary>
    let isInternal = _prefixId.prefix "isInternal"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : label created daterdfs:label : date de création de l'étiquette</para>
    ///   <para>rdfs:comment : Date when the shipping label was created.</para>
    ///   <a href="https://ns.verisav.fr/rma#labelCreatedDate">rma:labelCreatedDate</a>
    /// </summary>
    let labelCreatedDate = _prefixId.prefix "labelCreatedDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : label expiry daterdfs:label : date d'expiration de l'étiquette</para>
    ///   <para>rdfs:comment : Expiry date of the shipping label.</para>
    ///   <a href="https://ns.verisav.fr/rma#labelExpiryDate">rma:labelExpiryDate</a>
    /// </summary>
    let labelExpiryDate = _prefixId.prefix "labelExpiryDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : label URLrdfs:label : URL de l'étiquette</para>
    ///   <para>rdfs:comment : URL or link to download the shipping label.</para>
    ///   <a href="https://ns.verisav.fr/rma#labelUrl">rma:labelUrl</a>
    /// </summary>
    let labelUrl = _prefixId.prefix "labelUrl"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : last tracking updaterdfs:label : dernière mise à jour de suivi</para>
    ///   <para>rdfs:comment : Date and time of the last tracking update.</para>
    ///   <a href="https://ns.verisav.fr/rma#lastTrackingUpdate">rma:lastTrackingUpdate</a>
    /// </summary>
    let lastTrackingUpdate = _prefixId.prefix "lastTrackingUpdate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : message daterdfs:label : date du message</para>
    ///   <para>rdfs:comment : Date and time when the message was sent.</para>
    ///   <a href="https://ns.verisav.fr/rma#messageDate">rma:messageDate</a>
    /// </summary>
    let messageDate = _prefixId.prefix "messageDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : message textrdfs:label : texte du message</para>
    ///   <para>rdfs:comment : Text content of the message.</para>
    ///   <a href="https://ns.verisav.fr/rma#messageText">rma:messageText</a>
    /// </summary>
    let messageText = _prefixId.prefix "messageText"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : message typerdfs:label : type de message</para>
    ///   <para>rdfs:comment : Type of message (customer_message, support_response, internal_note, system_notification).</para>
    ///   <a href="https://ns.verisav.fr/rma#messageType">rma:messageType</a>
    /// </summary>
    let messageType = _prefixId.prefix "messageType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : demandé parrdfs:label : requested by</para>
    ///   <para>rdfs:comment : The person or organization who requested the return or created the ticket.</para>
    ///   <a href="https://ns.verisav.fr/rma#requestedBy">rma:requestedBy</a>
    /// </summary>
    let requestedBy = _prefixId.prefix "requestedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution amountrdfs:label : montant de résolution</para>
    ///   <para>rdfs:comment : Amount for refund or store credit resolution.</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionAmount">rma:resolutionAmount</a>
    /// </summary>
    let resolutionAmount = _prefixId.prefix "resolutionAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution currencyrdfs:label : devise de résolution</para>
    ///   <para>rdfs:comment : Currency code for the resolution amount (ISO 4217).</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionCurrency">rma:resolutionCurrency</a>
    /// </summary>
    let resolutionCurrency = _prefixId.prefix "resolutionCurrency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution daterdfs:label : date de résolution</para>
    ///   <para>rdfs:comment : Date when the resolution was proposed or applied.</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionDate">rma:resolutionDate</a>
    /// </summary>
    let resolutionDate = _prefixId.prefix "resolutionDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution descriptionrdfs:label : description de résolution</para>
    ///   <para>rdfs:comment : Description of the proposed or applied resolution.</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionDescription">rma:resolutionDescription</a>
    /// </summary>
    let resolutionDescription = _prefixId.prefix "resolutionDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution statusrdfs:label : statut de résolution</para>
    ///   <para>rdfs:comment : Status of the resolution (proposed, approved, rejected, applied, cancelled).</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionStatus">rma:resolutionStatus</a>
    /// </summary>
    let resolutionStatus = _prefixId.prefix "resolutionStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resolution typerdfs:label : type de résolution</para>
    ///   <para>rdfs:comment : Type of resolution (refund, exchange, store_credit, repair, replacement, rejection).</para>
    ///   <a href="https://ns.verisav.fr/rma#resolutionType">rma:resolutionType</a>
    /// </summary>
    let resolutionType = _prefixId.prefix "resolutionType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : results in work orderrdfs:label : résulte en ordre de travail</para>
    ///   <para>rdfs:comment : Links a return request or resolution to a work order if repair is needed.</para>
    ///   <a href="https://ns.verisav.fr/rma#resultsInWorkOrder">rma:resultsInWorkOrder</a>
    /// </summary>
    let resultsInWorkOrder = _prefixId.prefix "resultsInWorkOrder"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : return reasonrdfs:label : raison du retour</para>
    ///   <para>rdfs:comment : Reason for the return (defective, wrong_item, not_as_described, changed_mind, etc.).</para>
    ///   <a href="https://ns.verisav.fr/rma#returnReason">rma:returnReason</a>
    /// </summary>
    let returnReason = _prefixId.prefix "returnReason"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : return request daterdfs:label : date de demande de retour</para>
    ///   <para>rdfs:comment : Date when the return request was created.</para>
    ///   <a href="https://ns.verisav.fr/rma#returnRequestDate">rma:returnRequestDate</a>
    /// </summary>
    let returnRequestDate = _prefixId.prefix "returnRequestDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : return request numberrdfs:label : numéro de demande de retour</para>
    ///   <para>rdfs:comment : Unique identifier for the return request (RMA number).</para>
    ///   <a href="https://ns.verisav.fr/rma#returnRequestNumber">rma:returnRequestNumber</a>
    /// </summary>
    let returnRequestNumber = _prefixId.prefix "returnRequestNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : return request statusrdfs:label : statut de demande de retour</para>
    ///   <para>rdfs:comment : Status of the return request (pending, approved, rejected, in_transit, received, processed, completed).</para>
    ///   <a href="https://ns.verisav.fr/rma#returnRequestStatus">rma:returnRequestStatus</a>
    /// </summary>
    let returnRequestStatus = _prefixId.prefix "returnRequestStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ticket closed daterdfs:label : date de fermeture du ticket</para>
    ///   <para>rdfs:comment : Date when the ticket was closed.</para>
    ///   <a href="https://ns.verisav.fr/rma#ticketClosedDate">rma:ticketClosedDate</a>
    /// </summary>
    let ticketClosedDate = _prefixId.prefix "ticketClosedDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ticket created daterdfs:label : date de création du ticket</para>
    ///   <para>rdfs:comment : Date when the ticket was created.</para>
    ///   <a href="https://ns.verisav.fr/rma#ticketCreatedDate">rma:ticketCreatedDate</a>
    /// </summary>
    let ticketCreatedDate = _prefixId.prefix "ticketCreatedDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ticket numberrdfs:label : numéro de ticket</para>
    ///   <para>rdfs:comment : Unique identifier for the service ticket.</para>
    ///   <a href="https://ns.verisav.fr/rma#ticketNumber">rma:ticketNumber</a>
    /// </summary>
    let ticketNumber = _prefixId.prefix "ticketNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ticket priorityrdfs:label : priorité du ticket</para>
    ///   <para>rdfs:comment : Priority level of the ticket (low, normal, high, urgent).</para>
    ///   <a href="https://ns.verisav.fr/rma#ticketPriority">rma:ticketPriority</a>
    /// </summary>
    let ticketPriority = _prefixId.prefix "ticketPriority"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ticket statusrdfs:label : statut du ticket</para>
    ///   <para>rdfs:comment : Status of the ticket (open, in_progress, waiting_customer, waiting_vendor, resolved, closed).</para>
    ///   <a href="https://ns.verisav.fr/rma#ticketStatus">rma:ticketStatus</a>
    /// </summary>
    let ticketStatus = _prefixId.prefix "ticketStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tracking numberrdfs:label : numéro de suivi</para>
    ///   <para>rdfs:comment : Carrier tracking number for the package.</para>
    ///   <a href="https://ns.verisav.fr/rma#trackingNumber">rma:trackingNumber</a>
    /// </summary>
    let trackingNumber = _prefixId.prefix "trackingNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tracking statusrdfs:label : statut de suivi</para>
    ///   <para>rdfs:comment : Current tracking status (label_created, in_transit, out_for_delivery, delivered, exception).</para>
    ///   <a href="https://ns.verisav.fr/rma#trackingStatus">rma:trackingStatus</a>
    /// </summary>
    let trackingStatus = _prefixId.prefix "trackingStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tracking URLrdfs:label : URL de suivi</para>
    ///   <para>rdfs:comment : URL to track the package on carrier's website.</para>
    ///   <a href="https://ns.verisav.fr/rma#trackingUrl">rma:trackingUrl</a>
    /// </summary>
    let trackingUrl = _prefixId.prefix "trackingUrl"
