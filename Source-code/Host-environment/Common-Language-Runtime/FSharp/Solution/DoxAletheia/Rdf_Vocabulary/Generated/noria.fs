namespace https.w3id.org.noria.ontology.slash

open DoxAletheia

module noria =
    let _namespace_name = "https://w3id.org/noria/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Service is an abstract base class for defining the Service hierarchy, i.e. the composition of assets (a.k.a. asset chain, service function chain) for providing a end-to-end data path or processing for some specific Customer or purpose.
    ///
    /// Usage notes:
    /// - The `noria:Service` is loosely defined as per the way to group underpinning assets. The typical usage is to assert `noria:ApplicationModule` entities as `seas:subSystemOf` a given `noria:Service`.
    /// - The network topology related to a given `noria:Service` is inferred from the set of resources, network interfaces and network links included in each Application that is part of the Service.
    ///   We remark here that, although deterministic, the data path granularity calculus for some communication session (e.g. a time-bounded IP/http query with its response) depends on the specificity of the resources included in `ApplicationModule` instances.
    ///   For example, the resulting granularity for a "national IP backbone infrastructure" application instance will correspond to the [routing domain](https://en.wikipedia.org/wiki/Routing_domain).
    ///
    /// Alignment:
    /// - *SEAS*: A `noria:Service` allows for grouping components, hence it is a subclass of `seas:System`.
    /// - *DevOps-Infra*:
    ///   - The `noria:Service` is a concrete instance of a set of deployment models, hence it relates to `devopsprod:ServiceInstance`.
    ///   - A `noria:Service.serviceType(&lt;kos/service/type/CustomerFacingService&gt;)` relates to the `devopsprod:BusinessProductInstance` concept.
    /// - *tmforum*:
    ///   - The `noria:Service` is equivalent to the `Service` object from the *[TMF 638 - Service Inventory](https://github.com/tmforum-apis/TMF638_ServiceInventory)* API.
    ///   - Using the `noria:serviceType` relates to asserting the `CustomerFacingService` or `ResourceFacingService` Service subclasses notions of the *TMF 638 - Service Inventory* API (i.e. as either being possibly visible and usable by a Customer or not).
    /// - *IETF*: Assuming a group *Service Functions* (SFs), the `noria:Service` concept relates to the *Service Function Chain (SFC)* definition from the [RFC 7665: SFC Architecture](https://www.rfc-editor.org/rfc/rfc7665) (see also [ITU-T X.1045](https://handle.itu.int/11.1002/1000/14043) for complementary SFC definition).
    ///
    /// <see href="https://w3id.org/noria/ontology/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/CoreOntology-0.2"></see>
    /// </summary>
    let ``CoreOntology-0.2`` = _prefix "CoreOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ApplicationOntology-0.2"></see>
    /// </summary>
    let ``ApplicationOntology-0.2`` = _prefix "ApplicationOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ObservableOntology-0.2"></see>
    /// </summary>
    let ``ObservableOntology-0.2`` = _prefix "ObservableOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/NotificationOntology-0.2"></see>
    /// </summary>
    let ``NotificationOntology-0.2`` = _prefix "NotificationOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ResourceOntology-0.2"></see>
    /// </summary>
    let ``ResourceOntology-0.2`` = _prefix "ResourceOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/DocumentOntology-0.2"></see>
    /// </summary>
    let ``DocumentOntology-0.2`` = _prefix "DocumentOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/LocationOntology-0.2"></see>
    /// </summary>
    let ``LocationOntology-0.2`` = _prefix "LocationOntology-0.2"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/noria-0.1"></see>
    /// </summary>
    let ``noria-0.1`` = _prefix "noria-0.1"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/noria-0.2"></see>
    /// </summary>
    let ``noria-0.2`` = _prefix "noria-0.2"
    /// <summary>
    /// Set of Post Conditions or Potential outcomes that the execution of some OperationPlan may satisfy/lead to/confirm/solve.
    ///
    /// From the *ChangeRequest* perspective this enables to declare what to observe in order to confirm that the Procedure reached its goal; from the *TroubleTicket* perspective this enables to capitalize on expectations and outcomes for a given Procedure.
    /// <see href="https://w3id.org/noria/ontology/ActionPostCondition"></see></summary>
    let ActionPostCondition = _prefix "ActionPostCondition"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/DocumentOntology"></see>
    /// </summary>
    let DocumentOntology = _prefix "DocumentOntology"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ProceduralObject"></see>
    /// </summary>
    let ProceduralObject = _prefix "ProceduralObject"
    /// <summary>
    /// Set of Pre Conditions or Hypothesis enabling/leading to the potential execution of some OperationPlan.
    /// <see href="https://w3id.org/noria/ontology/ActionPreCondition"></see></summary>
    let ActionPreCondition = _prefix "ActionPreCondition"
    /// <summary>
    /// An abstract class for grouping observables and events that, when satisfied by the existence of some instance/value, represents the occurrence of a (complex) fault/failure mode.
    /// <see href="https://w3id.org/noria/ontology/AnomalyPattern"></see></summary>
    let AnomalyPattern = _prefix "AnomalyPattern"
    /// <summary>
    /// An abstract system based on data processing and presentation.
    /// <see href="https://w3id.org/noria/ontology/Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ApplicationOntology"></see>
    /// </summary>
    let ApplicationOntology = _prefix "ApplicationOntology"
    /// <summary>
    /// Abstract class for services and broadcasting zones above the *Structural* facet (a.k.a. *Functional facet*).
    /// <see href="https://w3id.org/noria/ontology/FunctionalElement"></see></summary>
    let FunctionalElement = _prefix "FunctionalElement"
    /// <summary>
    /// A specific and managed instance of an Application.
    /// <see href="https://w3id.org/noria/ontology/ApplicationModule"></see></summary>
    let ApplicationModule = _prefix "ApplicationModule"
    /// <summary>
    /// A Change Request represents a record used for reporting and managing change activities on services and resources. It is a key artefact to the Change Management process. Change Management process is to respond to the customer’s changing business requirements while maximizing value and reducing incidents, disruption and network.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a ChangeRequest is a described resource, hence DC terms apply:
    ///   - changeRequestId &lt;=&gt; http://purl.org/dc/terms/identifier : Identifier of the ChangeRequest.
    ///   - changeRequestCreationDateTime &lt;=&gt; http://purl.org/dc/terms/created : The Date and time on which the ChangeRequest was created in the system.
    ///   - changeRequestLastUpdate &lt;=&gt; http://purl.org/dc/terms/modified : The date and time on which the ChangeRequest was last updated.
    ///   - changeRequestDescription &lt;=&gt; http://purl.org/dc/terms/description : Extended description of the change to be made.
    ///   - changeRequestNote &lt;=&gt; http://purl.org/dc/terms/hasPart : A list of customer or internal comments.
    ///   - changeRequestAttachment &lt;=&gt; http://purl.org/dc/terms/hasPart : DocumentAttachment(s) that are associated to the ChangeRequest.
    ///   - changeRequestDuration &lt;=&gt; http://purl.org/dc/terms/extent (optional)
    ///   - changeRequestRelatedParty &lt;=&gt; http://purl.org/dc/terms/contributor : Party playing a role in the ChangeRequest, whether it be an unqualified role (i.e. direct usage of dcterms:contributor) or a qualified role (i.e. sub-properties such as noria:changeRequestInitiatorParty).
    ///   - changeRequestCorrelatedNotifications &lt;=&gt; http://purl.org/dc/terms/relation : EventRecord(s) instances or identifiers that are considered to be correlated to this ChangeRequest.
    /// - *PEP*: a ChangeRequest is a context for (potentially) many *ChangeAction* to occur; hence it relates to a `pep:ProcedureExecutionContainer`.
    /// - *BBO*: a ChangeRequest is a DocumentResource in the sense that it is the result of the Change Management process and can be used as an input for another activity. From the BPMN 2.0 perspective, a ChangeRequest is a DataObject.
    ///
    /// <see href="https://w3id.org/noria/ontology/ChangeRequest"></see></summary>
    let ChangeRequest = _prefix "ChangeRequest"
    /// <summary>
    /// Abstract class for time-related entities and their potential chaining (a.k.a. *Dynamic facet*).
    /// <see href="https://w3id.org/noria/ontology/DynamicElement"></see></summary>
    let DynamicElement = _prefix "DynamicElement"
    /// <summary>
    /// A trouble ticket represents a record used for reporting and managing the resolution of resource problems. Main trouble ticket attributes are its description, severity, type, priority, related dates (created, target resolution, resolution, etc.), state and related information (change reason, change date), related parties (originator, owner, pilot), notes, trouble causes and impacts.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a TroubleTicket is a described resource, hence DC terms apply:
    ///   - troubleTicketId &lt;=&gt; http://purl.org/dc/terms/identifier : Identifier of the trouble ticket.
    ///   - troubleTicketCreationDateTime &lt;=&gt; http://purl.org/dc/terms/created : The Date on which the TroubleTicket was created in the ticketing system.
    ///   - troubleTicketLastUpdate &lt;=&gt; http://purl.org/dc/terms/modified : The date and time that the TroubleTicket was last updated.
    ///   - troubleTicketName &lt;=&gt; http://purl.org/dc/terms/title : Name of the TroubleTicket, typically a short description provided by the user that create the ticket or complementary data
    ///   - troubleTicketDescription &lt;=&gt; http://purl.org/dc/terms/description : Extended description of the trouble or issue.
    ///   - troubleTicketNote &lt;=&gt; http://purl.org/dc/terms/hasPart : The TroubleTicketNote(s) that are associated to the TroubleTicket.
    ///   - troubleTicketAttachment &lt;=&gt; http://purl.org/dc/terms/hasPart : The DocumentAttachment(s) that are associated to the TroubleTicket.
    ///   - troubleTicketRelationshipParentOf &lt;=&gt; http://purl.org/dc/terms/hasPart : The TroubleTicket(s) this ticket is parent of (TicketRelationship).
    ///   - troubleTicketRelationshipChildOf &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this ticket is the child of (TicketRelationship).
    ///   - troubleTicketDuration &lt;=&gt; http://purl.org/dc/terms/extent (optional) : The overall duration of the incident management process, typically in ISO 8601 duration format. Can be useful for computing Mean Time To Repair (MTTR) values for a given `problemCategory`.
    ///   - troubleTicketCorrelatedNotifications &lt;=&gt; http://purl.org/dc/terms/relation : EventRecord(s) instances or identifiers that are considered to be correlated to this TroubleTicket/TroubleTicketNote.
    /// - *BBO*: a TroubleTicket is a DocumentResource in the sense that it is the result of the Incident Management process and can be used as an input for another activity. From the BPMN 2.0 perspective, a TroubleTicket is a DataObject.
    /// - *PEP*: a TroubleTicketNote is a context for (potentially) many *CorrectiveMaintenanceAction* to occur; hence it relates to a `pep:ProcedureExecutionContainer`, which in turns enable to track the corresponding `EventRecord` through the `ldp:member` property.
    ///
    /// <see href="https://w3id.org/noria/ontology/TroubleTicket"></see></summary>
    let TroubleTicket = _prefix "TroubleTicket"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/CoreOntology"></see>
    /// </summary>
    let CoreOntology = _prefix "CoreOntology"
    /// <summary>
    /// The Corporate User Identifier (CUid) is the unique identifier of a Person as a member of Organization (i.e. an Employee). It is also the main account of this Person for connecting to the organization's IT resources, including to its personal computer (PC).
    ///
    /// Alignment:
    /// - *FOAF*:
    ///   - The `foaf:accountName` allows for asserting the login identifier of an instance of this class.
    ///   - The `foaf:holdsAccount` property allows for relating an employee entity to an instance of this class.
    /// - *UCO*:
    ///   - A CUid is equivalent to a `observable:UserAccount`.
    ///   - The `observable:accountLogin` and `observable:accountIdentifier` can be used in parallel to `foaf:accountName` for asserting the the login identifier.
    ///   - The Person (`foaf:Agent`) holding this CUid is also a `observable:Contact`.
    ///
    /// <see href="https://w3id.org/noria/ontology/CorporateUserIdentifier"></see></summary>
    let CorporateUserIdentifier = _prefix "CorporateUserIdentifier"
    /// <summary>
    /// A file attachment.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a DocumentAttachment is a described resource, hence DC terms apply:
    ///   - troubleTicketAttachmentForTicket &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    ///   - changeRequestAttachment &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    /// - *BBO*: a DocumentAttachment is a DocumentResource in the sense that it is the result of the Incident Management Process (IMP) or Change Management Process (CMP) and can be used as an input for another activity. From the BPMN 2.0 perspective, a DocumentAttachment is a DataObject.
    ///
    /// <see href="https://w3id.org/noria/ontology/DocumentAttachment"></see></summary>
    let DocumentAttachment = _prefix "DocumentAttachment"
    /// <summary>
    /// Top abstract class of NORIA Cyber/Physical concepts for describing, managing and analyzing ICT systems.
    /// <see href="https://w3id.org/noria/ontology/ManagedElement"></see></summary>
    let ManagedElement = _prefix "ManagedElement"
    /// <summary>
    /// This managed object represents the information stored in the log as a result of receiving notifications or incoming event reports.
    ///
    /// In that sense it is an abstract object with basic properties (e.g. event type, logging time, provenance system, message) to interpret in the context of its properties and relationships.
    /// For example, an *EventRecord* instance `log1` originating from the managed resource `R1` and describing a network interface state change on the Resource is fetched from a syslog-ng platform `Mon1` (i.e. the originating management system).
    /// A related *EventRecord* instance `alarm1` with `noria:alarmSeverity = Critical` and originating managed resource `R1` is triggered by a Network Monitoring System `NMS1` (i.e. the originating management system) for presentation to the Technical Support Center.
    ///
    /// Considering possible combinations of properties' objects and values, a `noria:EventRecord` allows for describing:
    /// - both informational and alarm notifications (this rely on `skos:ConceptScheme` over the `dcterms:type` of the `noria:EventRecord`),
    /// - notifications that affect both the network infrastructure (e.g. network interface down), network applications/services (e.g. timeout, k-out-of-n) and the Operation Support System (OSS) itself (e.g. updating a `noria:TroubleTicketNote`),
    /// - notifications originating from both onboard signaling (e.g. [SNMP Trap](https://en.wikipedia.org/wiki/Simple_Network_Management_Protocol)), probes (e.g. [NIDS](https://en.wikipedia.org/wiki/Intrusion_detection_system)), the monitoring system (e.g. threshold overrun, business rules) and inference engines (e.g. NORIA-AD).
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a EventRecord is a described resource, hence DC terms apply:
    ///   - *logRecordId* &lt;=&gt; http://purl.org/dc/terms/identifier : Identifier of notification or log record, as defined by &lt;https://www.itu.int/ITU-T/formal-language/itu-t/x/x721/1992/x721.html#-logRecordId&gt;.
    ///   - *logInformation* &lt;=&gt; http://purl.org/dc/terms/description : Additional information describing the logged event, as defined by &lt;https://www.itu.int/ITU-T/formal-language/itu-t/x/x721/1992/x721.html#-additionalInformation&gt;.
    ///   - *logType* &lt;=&gt; http://purl.org/dc/terms/type : The Type of the Event (e.g. General Operation Alarm, State Change, etc.), as defined by the NORIA `kos/Notification/EventType` concept scheme.
    ///   - *alarmCorrelatedNotifications* &lt;=&gt; http://purl.org/dc/terms/relation : EventRecord instances or identifiers that are considered to be correlated to this EventRecord, as defined by &lt;https://www.itu.int/ITU-T/formal-language/itu-t/x/x721/1992/x721.html#-correlatedNotifications&gt;.
    ///   - *alarmOwner* &lt;=&gt; http://purl.org/dc/terms/mediator : The Support team member who acknowledged an Alarm Event Record.
    ///   - *alarmProbableCause* &lt;=&gt; http://purl.org/dc/terms/conformsTo : The asserted or inferred cause of the Alarm Event Record, as defined by the NORIA `kos/Notification/ProbableCause` and `kos/Notification/SecurityAlarmCause` concept schemes.
    ///     Asserting the Alarm cause is equivalent to directly connecting the Alarm, as a fault (issue, incident) artefact, to some phenomenon interpretation.
    ///     Inferring the Alarm cause is equivalent to guessing the phenomenon origin through Root Cause Analysis (RCA) or some probabilistic approach.
    /// - *BBO*: an EventRecord is a `BBO:DocumentResource` in the sense that it is the result of the Event Management process and can be used as an input for another activity. From the BPMN 2.0 perspective, an EventRecord is a `DataObject`.
    /// - *PEP*: an EventRecord is an artefact of the realization of a `pep:Procedure`, hence it is a specialization of a `pep:ProcedureExecution` for the NORIA context.
    /// - *SLOGERT*: an EventRecord is equivalent to a `log:Event`.
    ///
    /// <see href="https://w3id.org/noria/ontology/EventRecord"></see></summary>
    let EventRecord = _prefix "EventRecord"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/NotificationOntology"></see>
    /// </summary>
    let NotificationOntology = _prefix "NotificationOntology"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/LocationOntology"></see>
    /// </summary>
    let LocationOntology = _prefix "LocationOntology"
    /// <summary>
    /// A uniquely identified space for Resources within a given Room.
    ///
    /// Alignment:
    /// - *BOT*:
    ///   - The relationship to the Locus of a Room is available with the `bot:containsZone` property.
    ///   - Approximating the geographical coordinates of a Locus is feasible through transitive inference over the `bot:hasZeroPoint` of the parent `bot:Site` (considering the GeoNames database this would to a `(bot:Site)=[bot:hasZeroPoint]=&gt;(gn:Feature)` path towards `wgs84_pos:lat` or `wgs84_pos:long` values).
    /// - *ORG*: Note that, at instanciation time, `bot:Site` entities may also be `org:Site` (see https://www.w3.org/TR/vocab-org/#org:Site) in order to allow for an Organization (including teams, persons, manufacturers) to be localized (e.g. see `org:basedAt`), and hence allow for intervention distance/time calculus or threat calculus with respect to a given Locus.
    ///
    /// <see href="https://w3id.org/noria/ontology/Locus"></see></summary>
    let Locus = _prefix "Locus"
    /// <summary>
    /// A Network Interface of some Resource (e.g. server, router, virtual routing and forwarding (VRF) instance), and of some type (e.g. physical, virtual).
    ///
    /// Usage notes:
    /// - The name of the Network Interface (aka. networkInterfaceName, such as `ge-0/0/0.3013` or `ae52.3028`) can be set with the `rdfs:label` property.
    ///
    /// <see href="https://w3id.org/noria/ontology/NetworkInterface"></see></summary>
    let NetworkInterface = _prefix "NetworkInterface"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ResourceOntology"></see>
    /// </summary>
    let ResourceOntology = _prefix "ResourceOntology"
    /// <summary>
    /// Abstract class for physical/logical ICT systems's assets and relations (a.k.a. *Structural facet*).
    /// <see href="https://w3id.org/noria/ontology/StructuralElement"></see></summary>
    let StructuralElement = _prefix "StructuralElement"
    /// <summary>
    /// A physical or logical Link between Resources.
    ///
    /// Usage notes:
    /// - The organizational unit in charge of the Network Link (i.e. the Support team or Owner of the Network Link) can be set with the `noria:resourceManagedBy` property.
    ///
    /// <see href="https://w3id.org/noria/ontology/NetworkLink"></see></summary>
    let NetworkLink = _prefix "NetworkLink"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ObservableOntology"></see>
    /// </summary>
    let ObservableOntology = _prefix "ObservableOntology"
    /// <summary>
    /// An abstract class representing a formal set of operations to be carried out in a standardized/controlled way.
    /// <see href="https://w3id.org/noria/ontology/OperationPlan"></see></summary>
    let OperationPlan = _prefix "OperationPlan"
    /// <summary>
    /// Abstract class for (predeﬁned/computed) operational process (a.k.a. *Procedural facet*).
    /// <see href="https://w3id.org/noria/ontology/ProceduralElement"></see></summary>
    let ProceduralElement = _prefix "ProceduralElement"
    /// <summary>
    /// The Product Model of some Resource as per the Manufacturer's naming.
    /// <see href="https://w3id.org/noria/ontology/ProductModel"></see></summary>
    let ProductModel = _prefix "ProductModel"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/StructuralProperty"></see>
    /// </summary>
    let StructuralProperty = _prefix "StructuralProperty"
    /// <summary>
    /// An abstract representation of qualifiable, quantifiable, observable or operable qualities of some Element.
    /// <see href="https://w3id.org/noria/ontology/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// General resource record of the Communication Device kind from the logistics park. It is a managed entity that can be either Physical or Virtual.
    ///
    /// Alignment:
    /// - *SEAS*: Whenever a Resource individual is an assembly of other resources (e.g. a server rack) or is part of an assembly (e.g. a server blade), the Resource individual can also be declared as a `seas:System` in order to benefit of the `seas:subSystemOf` relation.
    ///   For example, Resources may be grouped in some `noria:Service` class for providing both an end-to-end analysis of the data path (i.e. Communication Devices + Connections) and an abstract object linked to some end user (e.g. Customer).
    /// - *BOT*: A `noria:Resource` is a sub-class of `bot:Element` for setting instances in the context of a physical environment (e.g. in a building).
    /// - *SLOGERT*: A `noria:Resource` is equivalent to a `log:Host`.
    /// - *UCO*: A `noria:Resource` is equivalent to an UCO's observable `Device`.
    ///
    /// <see href="https://w3id.org/noria/ontology/Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// A part of the physical world or a virtual world whose 3D spatial extent is bounded actually or theoretically, and provides for certain functions within the zone it is contained in.
    ///
    /// Alignment:
    /// - *BOT*: A Room is a specialization of a `bot:Space` for common sense understanding.
    ///
    /// <see href="https://w3id.org/noria/ontology/Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// An abstract class for ICT systems's properties that should be defined as classes for extended description capability.
    /// <see href="https://w3id.org/noria/ontology/StructuralObservable"></see></summary>
    let StructuralObservable = _prefix "StructuralObservable"
    /// <summary>
    /// A trouble ticket note represents a record used for reporting and information sharing during the incident management process for a given Trouble Ticket.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a TroubleTicketNote is a described resource, hence DC terms apply:
    ///   - troubleTicketNoteDate &lt;=&gt; http://purl.org/dc/terms/created : The recording date of the TroubleTicketNote.
    ///   - troubleTicketNoteAuthor &lt;=&gt; http://purl.org/dc/terms/creator : The Author of the TroubleTicketNote.
    ///   - troubleTicketNoteText &lt;=&gt; http://purl.org/dc/terms/description : The content of the TroubleTicketNote.
    ///   - troubleTicketNoteForTicket &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this note is part of.
    ///   - troubleTicketNoteCorrelatedNotifications &lt;=&gt; http://purl.org/dc/terms/relation : EventRecord(s) instances or identifiers that are considered to be correlated to this TroubleTicketNote.
    /// - *BBO*: a TroubleTicketNote is a DocumentResource in the sense that it is the result of the Incident Management process and can be used as an input for another activity. From the BPMN 2.0 perspective, a TroubleTicketNote is a DataObject.
    /// - *PEP*: a TroubleTicketNote is a context for (potentially) many *CorrectiveMaintenanceAction* to occur; hence it relates to a `pep:ProcedureExecutionContainer`, which in turns enable to track the corresponding `EventRecord` through the `ldp:member` property.
    ///
    /// <see href="https://w3id.org/noria/ontology/TroubleTicketNote"></see></summary>
    let TroubleTicketNote = _prefix "TroubleTicketNote"
    /// <summary>
    /// The Operation Plan (procedure) guiding the execution of the given Action.
    /// <see href="https://w3id.org/noria/ontology/actionCorrelatedOperationPlan"></see></summary>
    let actionCorrelatedOperationPlan = _prefix "actionCorrelatedOperationPlan"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/CorrectiveMaintenanceAction"></see>
    /// </summary>
    let CorrectiveMaintenanceAction = _prefix "CorrectiveMaintenanceAction"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/ChangeAction"></see>
    /// </summary>
    let ChangeAction = _prefix "ChangeAction"
    /// <summary>
    /// Instructions for involving the Agent (Team, Group, Employee).
    /// <see href="https://w3id.org/noria/ontology/agentInstructions"></see></summary>
    let agentInstructions = _prefix "agentInstructions"
    /// <summary>
    /// The Network Element (IT Resource) the Agent is responsible of (supervises).
    ///
    /// Alignment:
    /// - *FOAF*: A team may be interested into following the state of some resources, hence this property is semantically akin to `foaf:topic_interest`.
    ///
    /// <see href="https://w3id.org/noria/ontology/agentManagesResource"></see></summary>
    let agentManagesResource = _prefix "agentManagesResource"
    /// <summary>
    /// The Support team or Owner of the Network Element (IT Resource).
    /// <see href="https://w3id.org/noria/ontology/resourceManagedBy"></see></summary>
    let resourceManagedBy = _prefix "resourceManagedBy"
    /// <summary>
    /// The preferred contact method to reach the Agent (Team, Group, Employee).
    /// <see href="https://w3id.org/noria/ontology/agentPreferredContactMethod"></see></summary>
    let agentPreferredContactMethod = _prefix "agentPreferredContactMethod"
    /// <summary>
    /// The Working Hours for reaching the Agent (Team, Employee, etc.).
    /// <see href="https://w3id.org/noria/ontology/agentWorkingHours"></see></summary>
    let agentWorkingHours = _prefix "agentWorkingHours"
    /// <summary>
    /// The ProcedureExecutionContainer (i.e. the set of Procedure Execution(s)) that led to clear the alarm and/or solve the issue.
    ///
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.
    /// <see href="https://w3id.org/noria/ontology/alarmMitigatedBy"></see></summary>
    let alarmMitigatedBy = _prefix "alarmMitigatedBy"
    /// <summary>
    /// The Monitored attributes parameter, when present, defines one or more attributes of the managed object and their corresponding values at the time of the alarm.
    /// Managed object definers may specify the set of attributes which are of interest, if any.
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.
    ///
    /// <see href="https://w3id.org/noria/ontology/alarmMonitoredAttribute"></see></summary>
    let alarmMonitoredAttribute = _prefix "alarmMonitoredAttribute"
    /// <summary>
    /// This parameter, when present, is used if the cause is known and the system being managed can suggest one or more solutions.
    /// This parameter is a set of possibilities specified by the object class definer.
    ///
    /// <see href="https://w3id.org/noria/ontology/alarmProposedRepairAction"></see></summary>
    let alarmProposedRepairAction = _prefix "alarmProposedRepairAction"
    /// <summary>
    /// Indication of how it is perceived that the capability of the managed object has been affected, or how serious are the service affecting conditions (including for security alarms).
    /// <see href="https://w3id.org/noria/ontology/alarmSeverity"></see></summary>
    let alarmSeverity = _prefix "alarmSeverity"
    /// <summary>
    /// The importance of the Application from the business impact perspective for risk assessment analysis and incident management prioritization.
    /// <see href="https://w3id.org/noria/ontology/applicationBusinessImportance"></see></summary>
    let applicationBusinessImportance = _prefix "applicationBusinessImportance"
    /// <summary>
    /// The functional domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalDomain` is equivalent to the *Domain* concept of the ODA Functional Framework.
    ///
    /// <see href="https://w3id.org/noria/ontology/applicationFunctionalDomain"></see></summary>
    let applicationFunctionalDomain = _prefix "applicationFunctionalDomain"
    /// <summary>
    /// The functional sub-domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalSubDomain` is equivalent to *Aggregate Business Entities* (ABEs) and *Business Entities* (BEs) of the ODA Functional Framework.
    ///
    /// <see href="https://w3id.org/noria/ontology/applicationFunctionalSubDomain"></see></summary>
    let applicationFunctionalSubDomain = _prefix "applicationFunctionalSubDomain"
    /// <summary>
    /// Application model code.
    /// <see href="https://w3id.org/noria/ontology/applicationModelIdentifier"></see></summary>
    let applicationModelIdentifier = _prefix "applicationModelIdentifier"

    /// <summary>
    /// Administration leader.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleAdministrationLeader"></see></summary>
    let applicationModuleAdministrationLeader =
        _prefix "applicationModuleAdministrationLeader"

    /// <summary>
    /// Generic property for linking a party playing a role in the management of the Application Module.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleRelatedParty"></see></summary>
    let applicationModuleRelatedParty = _prefix "applicationModuleRelatedParty"

    /// <summary>
    /// Administration team.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleAdministrationTeam"></see></summary>
    let applicationModuleAdministrationTeam =
        _prefix "applicationModuleAdministrationTeam"

    /// <summary>
    /// Hotline enabled for issues on a given ApplicationModule.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleHotlineEnabled"></see></summary>
    let applicationModuleHotlineEnabled = _prefix "applicationModuleHotlineEnabled"
    /// <summary>
    /// Hotline team.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleHotlineGroup"></see></summary>
    let applicationModuleHotlineGroup = _prefix "applicationModuleHotlineGroup"
    /// <summary>
    /// Application module code.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleIdentifier"></see></summary>
    let applicationModuleIdentifier = _prefix "applicationModuleIdentifier"
    /// <summary>
    /// The name of the Application module.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleName"></see></summary>
    let applicationModuleName = _prefix "applicationModuleName"

    /// <summary>
    /// The Distinguished Name of the Functional Element Instance (i.e. unique identifier).
    /// <see href="https://w3id.org/noria/ontology/functionalElementDistinguishedName"></see></summary>
    let functionalElementDistinguishedName =
        _prefix "functionalElementDistinguishedName"

    /// <summary>
    /// A child/parent relationship between a specific and managed instance of an Application (i.e. an Application Module) and the Application.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleOf"></see></summary>
    let applicationModuleOf = _prefix "applicationModuleOf"
    /// <summary>
    /// The Agent or Owner of the Managed Element.
    ///
    /// Alignment:
    /// - *ORG*: the *elementManagedBy* property can range an `org:Organization` or `org:OrganizationalUnit` entity as the ORG data model defines these class as subClassOf `foaf:Agent` (see [org:Organization](https://www.w3.org/TR/vocab-org/#org:Organization)).
    ///
    /// <see href="https://w3id.org/noria/ontology/elementManagedBy"></see></summary>
    let elementManagedBy = _prefix "elementManagedBy"
    /// <summary>
    /// SLA level.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleSlaLevel"></see></summary>
    let applicationModuleSlaLevel = _prefix "applicationModuleSlaLevel"
    /// <summary>
    /// SLA Level date, the date at which the SLA Level has been set or updated.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleSlaLevelDate"></see></summary>
    let applicationModuleSlaLevelDate = _prefix "applicationModuleSlaLevelDate"
    /// <summary>
    /// Status of the Application Module.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleStatus"></see></summary>
    let applicationModuleStatus = _prefix "applicationModuleStatus"
    /// <summary>
    /// Level 1 support team.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleSupportGroup"></see></summary>
    let applicationModuleSupportGroup = _prefix "applicationModuleSupportGroup"
    /// <summary>
    /// Support leader.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleSupportLeader"></see></summary>
    let applicationModuleSupportLeader = _prefix "applicationModuleSupportLeader"
    /// <summary>
    /// Level 2 Support Team.
    /// <see href="https://w3id.org/noria/ontology/applicationModuleSupportTeam"></see></summary>
    let applicationModuleSupportTeam = _prefix "applicationModuleSupportTeam"
    /// <summary>
    /// Application numerical identifier, the numerical identifier of the Application within the Information System.
    /// <see href="https://w3id.org/noria/ontology/applicationNumericalIdentifier"></see></summary>
    let applicationNumericalIdentifier = _prefix "applicationNumericalIdentifier"
    /// <summary>
    /// Application short identifier, a short string identifier of Application within the Information System.
    /// <see href="https://w3id.org/noria/ontology/applicationShortIdentifier"></see></summary>
    let applicationShortIdentifier = _prefix "applicationShortIdentifier"
    /// <summary>
    /// The type of the Application.
    /// <see href="https://w3id.org/noria/ontology/applicationType"></see></summary>
    let applicationType = _prefix "applicationType"
    /// <summary>
    /// The actor of the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestActorParty"></see></summary>
    let changeRequestActorParty = _prefix "changeRequestActorParty"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/changeRequestRelatedParty"></see>
    /// </summary>
    let changeRequestRelatedParty = _prefix "changeRequestRelatedParty"
    /// <summary>
    /// Date and time on which the Change Request implementation has been completed. It is displayed only after the Change Request implementation has been completed actually.
    /// <see href="https://w3id.org/noria/ontology/changeRequestActualEndTime"></see></summary>
    let changeRequestActualEndTime = _prefix "changeRequestActualEndTime"
    /// <summary>
    /// Date and time on which the Change Request implementation has started. It is displayed only after the Change Request implementation has started actually.
    /// <see href="https://w3id.org/noria/ontology/changeRequestActualStartTime"></see></summary>
    let changeRequestActualStartTime = _prefix "changeRequestActualStartTime"
    /// <summary>
    /// Nature of the Change Request
    /// <see href="https://w3id.org/noria/ontology/changeRequestCategory"></see></summary>
    let changeRequestCategory = _prefix "changeRequestCategory"
    /// <summary>
    /// Cause of (reason for) the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestChangeCause"></see></summary>
    let changeRequestChangeCause = _prefix "changeRequestChangeCause"
    /// <summary>
    /// Set of physical/logical entities on which the Change Request is carried-out.
    /// <see href="https://w3id.org/noria/ontology/changeRequestImpact"></see></summary>
    let changeRequestImpact = _prefix "changeRequestImpact"
    /// <summary>
    /// The structural or functional element instance some event or time-dependant entity is related with.
    /// <see href="https://w3id.org/noria/ontology/eventRelatedElement"></see></summary>
    let eventRelatedElement = _prefix "eventRelatedElement"
    /// <summary>
    /// The agent initiating the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestInitiatorParty"></see></summary>
    let changeRequestInitiatorParty = _prefix "changeRequestInitiatorParty"
    /// <summary>
    /// If *true*, the Change Request is subject to special regulations.
    /// <see href="https://w3id.org/noria/ontology/changeRequestIsRegulated"></see></summary>
    let changeRequestIsRegulated = _prefix "changeRequestIsRegulated"
    /// <summary>
    /// Expected duration of the outage, if any involved by the Change Request type.
    /// <see href="https://w3id.org/noria/ontology/changeRequestOutageDuration"></see></summary>
    let changeRequestOutageDuration = _prefix "changeRequestOutageDuration"
    /// <summary>
    /// The pilot of the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestPilotParty"></see></summary>
    let changeRequestPilotParty = _prefix "changeRequestPilotParty"
    /// <summary>
    /// Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.
    /// <see href="https://w3id.org/noria/ontology/changeRequestPlannedEndTime"></see></summary>
    let changeRequestPlannedEndTime = _prefix "changeRequestPlannedEndTime"
    /// <summary>
    /// Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.
    /// <see href="https://w3id.org/noria/ontology/changeRequestPlannedStartTime"></see></summary>
    let changeRequestPlannedStartTime = _prefix "changeRequestPlannedStartTime"
    /// <summary>
    /// An item of the standard operation plan catalog for recurring activities.
    /// <see href="https://w3id.org/noria/ontology/changeRequestSpecification"></see></summary>
    let changeRequestSpecification = _prefix "changeRequestSpecification"
    /// <summary>
    /// The current status of the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestStatusCurrent"></see></summary>
    let changeRequestStatusCurrent = _prefix "changeRequestStatusCurrent"
    /// <summary>
    /// The type of the request describes the a priori impact and risk level of the Change Request.
    /// <see href="https://w3id.org/noria/ontology/changeRequestType"></see></summary>
    let changeRequestType = _prefix "changeRequestType"
    /// <summary>
    /// Relates a Resource that is part of a cluster with the cluster controller.
    /// <see href="https://w3id.org/noria/ontology/clusterController"></see></summary>
    let clusterController = _prefix "clusterController"
    /// <summary>
    /// ID given by the requestor to facilitate the relationship set up and searches afterwards.
    /// <see href="https://w3id.org/noria/ontology/documentExternalId"></see></summary>
    let documentExternalId = _prefix "documentExternalId"
    /// <summary>
    /// Hyperlink to the TroubleTicket or ChangeRequest entity in the originating information system.
    /// <see href="https://w3id.org/noria/ontology/documentHRef"></see></summary>
    let documentHRef = _prefix "documentHRef"
    /// <summary>
    /// The status change history of the document as recorded by the system's logging feature.
    /// <see href="https://w3id.org/noria/ontology/documentStatusHistory"></see></summary>
    let documentStatusHistory = _prefix "documentStatusHistory"
    /// <summary>
    /// The Distinguished Name of the Element Instance (i.e. unique identifier).
    /// <see href="https://w3id.org/noria/ontology/elementDistinguishedName"></see></summary>
    let elementDistinguishedName = _prefix "elementDistinguishedName"
    /// <summary>
    /// An abstract representation of a relationship between some Element instance and some Property instance.
    /// <see href="https://w3id.org/noria/ontology/elementProperty"></see></summary>
    let elementProperty = _prefix "elementProperty"
    /// <summary>
    /// Party playing a role (stakeholders) in the life cycle of a given event instance or time-dependant entity.
    /// <see href="https://w3id.org/noria/ontology/eventRelatedParty"></see></summary>
    let eventRelatedParty = _prefix "eventRelatedParty"
    /// <summary>
    /// A uniquely identified space of the Resource within a given Room.
    ///
    /// Alignment:
    /// - *UCO*: This property enables linking a concrete `Resource` instance to some location, hence it relates to `observable:location`.
    /// - *BOT*: This property is akin to the inverse of `bot:hasElement`.
    ///
    /// <see href="https://w3id.org/noria/ontology/locatedAtLocus"></see></summary>
    let locatedAtLocus = _prefix "locatedAtLocus"
    /// <summary>
    /// The line identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.
    /// <see href="https://w3id.org/noria/ontology/locusLine"></see></summary>
    let locusLine = _prefix "locusLine"
    /// <summary>
    /// The row identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.
    /// <see href="https://w3id.org/noria/ontology/locusRow"></see></summary>
    let locusRow = _prefix "locusRow"
    /// <summary>
    /// The Agent at the origin of the Log record whenever it represents some action carried out on the ICT system. This includes information about the service user associated with the service request that caused a security alarm.
    /// <see href="https://w3id.org/noria/ontology/logOriginatingAgent"></see></summary>
    let logOriginatingAgent = _prefix "logOriginatingAgent"
    /// <summary>
    /// The Managed Object entity at the origin of the Log record. This includes information about the service provider associated with the service request that caused a security alarm.
    /// <see href="https://w3id.org/noria/ontology/logOriginatingManagedObject"></see></summary>
    let logOriginatingManagedObject = _prefix "logOriginatingManagedObject"
    /// <summary>
    /// The Management System that receives, processes and forwards the Log record.
    /// <see href="https://w3id.org/noria/ontology/logOriginatingManagementSystem"></see></summary>
    let logOriginatingManagementSystem = _prefix "logOriginatingManagementSystem"
    /// <summary>
    /// Textual information describing the logged event.
    /// <see href="https://w3id.org/noria/ontology/logText"></see></summary>
    let logText = _prefix "logText"
    /// <summary>
    /// The Date on which the log record was created in the system.
    /// <see href="https://w3id.org/noria/ontology/loggingTime"></see></summary>
    let loggingTime = _prefix "loggingTime"

    /// <summary>
    /// The administrative status of the Network Interface.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceAdministrativeStatus"></see></summary>
    let networkInterfaceAdministrativeStatus =
        _prefix "networkInterfaceAdministrativeStatus"

    /// <summary>
    /// An abstract representation of a relationship between some StructuralElement instance and some StructuralObservable instance.
    /// <see href="https://w3id.org/noria/ontology/structuralElementObservable"></see></summary>
    let structuralElementObservable = _prefix "structuralElementObservable"
    /// <summary>
    /// The Network Link the Network Interface is attached-to.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceConnects"></see></summary>
    let networkInterfaceConnects = _prefix "networkInterfaceConnects"
    /// <summary>
    /// A human-readable/editable text that describes the network interface. The information included in the description depends on the capabilities of the Resource's operating system.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceDescription"></see></summary>
    let networkInterfaceDescription = _prefix "networkInterfaceDescription"

    /// <summary>
    /// The high received power notification threshold.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceLaserRxHighPowerWarningThreshold"></see></summary>
    let networkInterfaceLaserRxHighPowerWarningThreshold =
        _prefix "networkInterfaceLaserRxHighPowerWarningThreshold"

    /// <summary>
    /// An abstract representation of a relationship between some StructuralElement instance and some literal data.
    /// <see href="https://w3id.org/noria/ontology/structuralElementObservableData"></see></summary>
    let structuralElementObservableData = _prefix "structuralElementObservableData"

    /// <summary>
    /// The low received power notification threshold.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceLaserRxLowPowerWarningThreshold"></see></summary>
    let networkInterfaceLaserRxLowPowerWarningThreshold =
        _prefix "networkInterfaceLaserRxLowPowerWarningThreshold"

    /// <summary>
    /// The received optical power measure of the Network Interface, in dBm.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPower"></see></summary>
    let networkInterfaceLaserRxOpticalPower =
        _prefix "networkInterfaceLaserRxOpticalPower"

    /// <summary>
    /// The average received optical power of the Network Interface, in dBm.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPowerAverage"></see></summary>
    let networkInterfaceLaserRxOpticalPowerAverage =
        _prefix "networkInterfaceLaserRxOpticalPowerAverage"

    /// <summary>
    /// The emitted optical power measure of the Network Interface, in dBm.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceLaserTxOpticalPower"></see></summary>
    let networkInterfaceLaserTxOpticalPower =
        _prefix "networkInterfaceLaserTxOpticalPower"

    /// <summary>
    /// The Resource the Network Interface is part-of.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceOf"></see></summary>
    let networkInterfaceOf = _prefix "networkInterfaceOf"
    /// <summary>
    /// The operational status of the Network Interface.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceOperationalStatus"></see></summary>
    let networkInterfaceOperationalStatus = _prefix "networkInterfaceOperationalStatus"

    /// <summary>
    /// The metric value associated to the Network Interface for some routing protocol.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceRoutingPriorityMetric"></see></summary>
    let networkInterfaceRoutingPriorityMetric =
        _prefix "networkInterfaceRoutingPriorityMetric"

    /// <summary>
    /// The type of the Network Interface.
    /// <see href="https://w3id.org/noria/ontology/networkInterfaceType"></see></summary>
    let networkInterfaceType = _prefix "networkInterfaceType"
    /// <summary>
    /// The UID of the NetworkLink.
    /// <see href="https://w3id.org/noria/ontology/networkLinkId"></see></summary>
    let networkLinkId = _prefix "networkLinkId"
    /// <summary>
    /// The installation date of the NetworkLink.
    /// <see href="https://w3id.org/noria/ontology/networkLinkInstallationDate"></see></summary>
    let networkLinkInstallationDate = _prefix "networkLinkInstallationDate"
    /// <summary>
    /// Link termination Resource, the Resource at some end fo the Network Link.
    /// <see href="https://w3id.org/noria/ontology/networkLinkTerminationResource"></see></summary>
    let networkLinkTerminationResource = _prefix "networkLinkTerminationResource"
    /// <summary>
    /// A description of the type of the Network Link.
    /// <see href="https://w3id.org/noria/ontology/networkLinkType"></see></summary>
    let networkLinkType = _prefix "networkLinkType"
    /// <summary>
    /// The ActionPostCondition to check/that would be observed whenever the OperationPlan is carried out.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the output, hence `operationPlanPostCondition` is a kind of `pep:hasOutput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPostCondition` is the description of what should be observed to after the realization of a given Task, hence it is a kind of `BBO:has_completionCondition`.
    ///
    /// <see href="https://w3id.org/noria/ontology/operationPlanPostCondition"></see></summary>
    let operationPlanPostCondition = _prefix "operationPlanPostCondition"
    /// <summary>
    /// The ActionPreCondition to check/that would be checked whenever the OperationPlan will be executed/is executed.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the input, hence `operationPlanPreCondition` is a kind of `pep:hasInput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPreCondition` is the description of what may activate the realization of a given Task, hence it is a kind of `BBO:has_activationCondition`.
    ///
    /// <see href="https://w3id.org/noria/ontology/operationPlanPreCondition"></see></summary>
    let operationPlanPreCondition = _prefix "operationPlanPreCondition"
    /// <summary>
    /// The *final* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.
    /// <see href="https://w3id.org/noria/ontology/problemCategory"></see></summary>
    let problemCategory = _prefix "problemCategory"
    /// <summary>
    /// The *initial* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketCategory"></see></summary>
    let troubleTicketCategory = _prefix "troubleTicketCategory"
    /// <summary>
    /// The *final* area of responsibility identified for the incident.
    /// <see href="https://w3id.org/noria/ontology/problemResponsibility"></see></summary>
    let problemResponsibility = _prefix "problemResponsibility"
    /// <summary>
    /// The cause(s) defined for the trouble, in plain text.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketCause"></see></summary>
    let troubleTicketCause = _prefix "troubleTicketCause"
    /// <summary>
    /// The Manufacturer of the Product Model.
    /// <see href="https://w3id.org/noria/ontology/productManufacturedBy"></see></summary>
    let productManufacturedBy = _prefix "productManufacturedBy"
    /// <summary>
    /// The Application this Resource is contributing to, whatever the Application type.
    /// <see href="https://w3id.org/noria/ontology/resourceForApplication"></see></summary>
    let resourceForApplication = _prefix "resourceForApplication"
    /// <summary>
    /// The hostname (nodename) of the Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceHostName"></see></summary>
    let resourceHostName = _prefix "resourceHostName"

    /// <summary>
    /// The Distinguished Name of the Structural Element Instance (i.e. unique identifier).
    /// <see href="https://w3id.org/noria/ontology/structuralElementDistinguishedName"></see></summary>
    let structuralElementDistinguishedName =
        _prefix "structuralElementDistinguishedName"

    /// <summary>
    /// The installation date of the Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceInstallationDate"></see></summary>
    let resourceInstallationDate = _prefix "resourceInstallationDate"
    /// <summary>
    /// The logistic UID of the Resource (a.k.a. asset tag).
    /// <see href="https://w3id.org/noria/ontology/resourceLogisticId"></see></summary>
    let resourceLogisticId = _prefix "resourceLogisticId"
    /// <summary>
    /// Specifies the IP address for remote management of the Resource, if relevant.
    /// <see href="https://w3id.org/noria/ontology/resourceManagementIPAddress"></see></summary>
    let resourceManagementIPAddress = _prefix "resourceManagementIPAddress"
    /// <summary>
    /// The product model of the Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceProductModel"></see></summary>
    let resourceProductModel = _prefix "resourceProductModel"
    /// <summary>
    /// The serial number of the Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceSerialNumber"></see></summary>
    let resourceSerialNumber = _prefix "resourceSerialNumber"
    /// <summary>
    /// The type of the Network Element Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceType"></see></summary>
    let resourceType = _prefix "resourceType"
    /// <summary>
    /// The production state of the Resource.
    /// <see href="https://w3id.org/noria/ontology/resourceUsageState"></see></summary>
    let resourceUsageState = _prefix "resourceUsageState"
    /// <summary>
    /// The type of the Service.
    /// <see href="https://w3id.org/noria/ontology/serviceType"></see></summary>
    let serviceType = _prefix "serviceType"
    /// <summary>
    /// A unique identifier of a Site.
    /// <see href="https://w3id.org/noria/ontology/siteId"></see></summary>
    let siteId = _prefix "siteId"
    /// <summary>
    /// Street address of a Site.
    /// <see href="https://w3id.org/noria/ontology/sitePrincipalAddress"></see></summary>
    let sitePrincipalAddress = _prefix "sitePrincipalAddress"
    /// <summary>
    /// City Name for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: a `P` class `gn:Feature` (city, village, etc.) may correspond to this property.
    /// <see href="https://w3id.org/noria/ontology/sitePrincipalAddressCityName"></see></summary>
    let sitePrincipalAddressCityName = _prefix "sitePrincipalAddressCityName"
    /// <summary>
    /// Country name or code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*:
    ///   - a `A` class `gn:Feature` (country, state, region, etc.) may correspond to this property.
    ///   - prefer ISO 3166 values for easier matching with `gn:countryCode`.
    ///
    /// <see href="https://w3id.org/noria/ontology/sitePrincipalAddressCountry"></see></summary>
    let sitePrincipalAddressCountry = _prefix "sitePrincipalAddressCountry"
    /// <summary>
    /// Postal Code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: *ADM2*, *ADM3* or *ADM4* annotations may correspond to this property, depending on the considered country.
    /// <see href="https://w3id.org/noria/ontology/sitePrincipalAddressPostalCode"></see></summary>
    let sitePrincipalAddressPostalCode = _prefix "sitePrincipalAddressPostalCode"
    /// <summary>
    /// Street for a Site.
    /// <see href="https://w3id.org/noria/ontology/sitePrincipalAddressStreet"></see></summary>
    let sitePrincipalAddressStreet = _prefix "sitePrincipalAddressStreet"
    /// <summary>
    /// The type of a Site.
    /// <see href="https://w3id.org/noria/ontology/siteType"></see></summary>
    let siteType = _prefix "siteType"
    /// <summary>
    /// Relates some `StructuralObservable` instance to some `StructuralElement` instance.
    /// <see href="https://w3id.org/noria/ontology/structuralObservableOf"></see></summary>
    let structuralObservableOf = _prefix "structuralObservableOf"
    /// <summary>
    ///   <see href="https://w3id.org/noria/ontology/structuralElementProperty"></see>
    /// </summary>
    let structuralElementProperty = _prefix "structuralElementProperty"
    /// <summary>
    /// A list of Characteristics of the ticket (TroubleTicketCharacteristic [*]). The Trouble ticket specific characteristics
    /// <see href="https://w3id.org/noria/ontology/troubleTicketCharacteristic"></see></summary>
    let troubleTicketCharacteristic = _prefix "troubleTicketCharacteristic"

    /// <summary>
    /// The Customer Commitment Deadline Date (calculated on product information).
    /// <see href="https://w3id.org/noria/ontology/troubleTicketCommittedRestorationDateTime"></see></summary>
    let troubleTicketCommittedRestorationDateTime =
        _prefix "troubleTicketCommittedRestorationDateTime"

    /// <summary>
    /// The ticket criticity from the customer impact perspective.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketCriticity"></see></summary>
    let troubleTicketCriticity = _prefix "troubleTicketCriticity"
    /// <summary>
    /// The date on which the trouble was discovered.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketDetectionDateTime"></see></summary>
    let troubleTicketDetectionDateTime = _prefix "troubleTicketDetectionDateTime"
    /// <summary>
    /// The ticket freeze period history.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketFreezeItem"></see></summary>
    let troubleTicketFreezeItem = _prefix "troubleTicketFreezeItem"
    /// <summary>
    /// A list of resources or services (applications) impacted by the trouble.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketImpacts"></see></summary>
    let troubleTicketImpacts = _prefix "troubleTicketImpacts"
    /// <summary>
    /// The *Application* or *Service* entity on which trouble ticket has been created.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketRelatedService"></see></summary>
    let troubleTicketRelatedService = _prefix "troubleTicketRelatedService"
    /// <summary>
    /// The Resource entity on which the trouble ticket has been created.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketRelatedResource"></see></summary>
    let troubleTicketRelatedResource = _prefix "troubleTicketRelatedResource"
    /// <summary>
    /// The *enable* or *disable* external notification on trouble ticket events.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketIsNotificationEnable"></see></summary>
    let troubleTicketIsNotificationEnable = _prefix "troubleTicketIsNotificationEnable"
    /// <summary>
    /// The comment provenance type and/or disclosure rules family.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketNoteCommentType"></see></summary>
    let troubleTicketNoteCommentType = _prefix "troubleTicketNoteCommentType"

    /// <summary>
    /// The correlated *ProcedureExecutionContainer* corresponding to the corrective maintenance actions depicted in the Trouble Ticket Note (i.e. the set of `EventRecord` about interactions with the system and as notified by the system).
    ///
    /// From a practical perspective, relating a `noria:TroubleTicketNote` to a `pep:ProcedureExecutionContainer` is akin to show off the materialization of a corrective maintenance action from the technical perspective.
    /// Note that for actions undoubtedly related to a given trouble ticket note (i.e. that can be asserted without mining for execution context candidates), one can avoid using `troubleTicketNoteCorrelatedExecution` by directly relating the note to `EventRecord` with `ldp:member` as `TroubleTicket` and `TroubleTicketNote` are themselves subclasses of `pep:ProcedureExecutionContainer`.
    ///
    /// <see href="https://w3id.org/noria/ontology/troubleTicketNoteCorrelatedExecution"></see></summary>
    let troubleTicketNoteCorrelatedExecution =
        _prefix "troubleTicketNoteCorrelatedExecution"

    /// <summary>
    /// The operation type of the note.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketNoteOperationType"></see></summary>
    let troubleTicketNoteOperationType = _prefix "troubleTicketNoteOperationType"
    /// <summary>
    /// The person or group family at the origin of the creation of the Trouble Ticket.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketOrigin"></see></summary>
    let troubleTicketOrigin = _prefix "troubleTicketOrigin"
    /// <summary>
    /// The history of groups activation and responsibility transfer.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketPartyIntervention"></see></summary>
    let troubleTicketPartyIntervention = _prefix "troubleTicketPartyIntervention"

    /// <summary>
    /// Confirmed to customer planned restoration date ATR (Actual Time to Restore (ATR)).
    /// <see href="https://w3id.org/noria/ontology/troubleTicketPlannedRestorationDateTime"></see></summary>
    let troubleTicketPlannedRestorationDateTime =
        _prefix "troubleTicketPlannedRestorationDateTime"

    /// <summary>
    /// The trouble management priority.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketPriority"></see></summary>
    let troubleTicketPriority = _prefix "troubleTicketPriority"
    /// <summary>
    /// The related party(ies) that are associated to the ticket.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketRelatedParty"></see></summary>
    let troubleTicketRelatedParty = _prefix "troubleTicketRelatedParty"
    /// <summary>
    /// The criticity of the incident.
    ///
    /// The classification (severity) of the Incident may be defined in accordance with Service Level Agreement (SLA) requirements.
    /// The thresholds of Incident resolution depend on standards defined per service type.
    /// When the thresholds are exceeded, specific process of escalation may be activated.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketSeverity"></see></summary>
    let troubleTicketSeverity = _prefix "troubleTicketSeverity"
    /// <summary>
    /// The current activity status of the trouble ticket.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketStatusCurrent"></see></summary>
    let troubleTicketStatusCurrent = _prefix "troubleTicketStatusCurrent"
    /// <summary>
    /// Supervision tool which detected the problem.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketSupervisionTool"></see></summary>
    let troubleTicketSupervisionTool = _prefix "troubleTicketSupervisionTool"

    /// <summary>
    /// The Customer initial restoration date Estimated Time to Restore (ETR).
    /// <see href="https://w3id.org/noria/ontology/troubleTicketTargetRestorationDateTime"></see></summary>
    let troubleTicketTargetRestorationDateTime =
        _prefix "troubleTicketTargetRestorationDateTime"

    /// <summary>
    /// The EventRecord at the origin of the creation of the Trouble Ticket.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketTrigger"></see></summary>
    let troubleTicketTrigger = _prefix "troubleTicketTrigger"
    /// <summary>
    /// The ticket type.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketType"></see></summary>
    let troubleTicketType = _prefix "troubleTicketType"
    /// <summary>
    /// The priority level of the incident.
    /// <see href="https://w3id.org/noria/ontology/troubleTicketUrgency"></see></summary>
    let troubleTicketUrgency = _prefix "troubleTicketUrgency"
    /// <summary>
    /// The operational status of the Virtual Server.
    /// <see href="https://w3id.org/noria/ontology/virtualServerStatus"></see></summary>
    let virtualServerStatus = _prefix "virtualServerStatus"
