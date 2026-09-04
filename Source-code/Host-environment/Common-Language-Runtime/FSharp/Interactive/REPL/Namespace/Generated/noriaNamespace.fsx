#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module noria =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/noria/ontology/" "noria"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : In an Incident Management context, the materialization to expect, such as:
    /// - 'service restored',
    /// - 'traffic down',
    /// - 'Customer or a probe with that traffic coming up after some CLI command'.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ActionPostCondition^^xsd:string</para>
    ///   <para>rdfs:comment : Set of Post Conditions or Potential outcomes that the execution of some OperationPlan may satisfy/lead to/confirm/solve.
    ///
    /// From the *ChangeRequest* perspective this enables to declare what to observe in order to confirm that the Procedure reached its goal; from the *TroubleTicket* perspective this enables to capitalize on expectations and outcomes for a given Procedure.</para>
    ///   <a href="https://w3id.org/noria/ontology/ActionPostCondition">noria:ActionPostCondition</a>
    /// </summary>
    let ActionPostCondition = _prefixId.prefix "ActionPostCondition"
    /// <summary>
    ///   <para>skos:example : In an Incident Management context: when in situation X, shut link may help</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ActionPreCondition^^xsd:string</para>
    ///   <para>rdfs:comment : Set of Pre Conditions or Hypothesis enabling/leading to the potential execution of some OperationPlan.</para>
    ///   <a href="https://w3id.org/noria/ontology/ActionPreCondition">noria:ActionPreCondition</a>
    /// </summary>
    let ActionPreCondition = _prefixId.prefix "ActionPreCondition"
    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Renamed AnomalyPattern from AnomalyMode.
    /// - Adding rdfs:subClassOf folio:FailureMode.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : AnomalyPattern^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class for grouping observables and events that, when satisfied by the existence of some instance/value, represents the occurrence of a (complex) fault/failure mode.</para>
    ///   <a href="https://w3id.org/noria/ontology/AnomalyPattern">noria:AnomalyPattern</a>
    /// </summary>
    let AnomalyPattern = _prefixId.prefix "AnomalyPattern"
    /// <summary>
    ///   <para>skos:example : - RLOGS: Centralization of real time logs.
    /// - DMZ VoIP: shared management zone / platform for Voice over IP services.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Application^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract system based on data processing and presentation.</para>
    ///   <a href="https://w3id.org/noria/ontology/Application">noria:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>skos:example : - Development instance of the RLOGS (Centralization of real time logs) Application.
    /// - B2B instance of the DMZ VoIP (shared management zone / platform for Voice over IP services) Application.^^xsd:string</para>
    ///   <para>rdfs:label : ApplicationModule^^xsd:string</para>
    ///   <para>rdfs:comment : A specific and managed instance of an Application.</para>
    ///   <a href="https://w3id.org/noria/ontology/ApplicationModule">noria:ApplicationModule</a>
    /// </summary>
    let ApplicationModule = _prefixId.prefix "ApplicationModule"
    let ApplicationOntology = _prefixId.prefix "ApplicationOntology"
    let ``ApplicationOntology_0.2`` = _prefixId.prefix "ApplicationOntology-0.2"
    let ChangeAction = _prefixId.prefix "ChangeAction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ChangeRequest^^xsd:string</para>
    ///   <para>rdfs:comment : A Change Request represents a record used for reporting and managing change activities on services and resources. It is a key artefact to the Change Management process. Change Management process is to respond to the customer’s changing business requirements while maximizing value and reducing incidents, disruption and network.
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
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/ChangeRequest">noria:ChangeRequest</a>
    /// </summary>
    let ChangeRequest = _prefixId.prefix "ChangeRequest"
    let CoreOntology = _prefixId.prefix "CoreOntology"
    let ``CoreOntology_0.2`` = _prefixId.prefix "CoreOntology-0.2"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - alignment with foaf of the previously available noria:employeeId property.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CUid^^xsd:string</para>
    ///   <para>rdfs:comment : The Corporate User Identifier (CUid) is the unique identifier of a Person as a member of Organization (i.e. an Employee). It is also the main account of this Person for connecting to the organization's IT resources, including to its personal computer (PC).
    ///
    /// Alignment:
    /// - *FOAF*:
    ///   - The `foaf:accountName` allows for asserting the login identifier of an instance of this class.
    ///   - The `foaf:holdsAccount` property allows for relating an employee entity to an instance of this class.
    /// - *UCO*:
    ///   - A CUid is equivalent to a `observable:UserAccount`.
    ///   - The `observable:accountLogin` and `observable:accountIdentifier` can be used in parallel to `foaf:accountName` for asserting the the login identifier.
    ///   - The Person (`foaf:Agent`) holding this CUid is also a `observable:Contact`.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/CorporateUserIdentifier">noria:CorporateUserIdentifier</a>
    /// </summary>
    let CorporateUserIdentifier = _prefixId.prefix "CorporateUserIdentifier"
    let CorrectiveMaintenanceAction = _prefixId.prefix "CorrectiveMaintenanceAction"
    /// <summary>
    ///   <para>skos:example : Picture of broken device, scanning of a bill or charge, network diagram, operation plan, location map.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DocumentAttachment^^xsd:string</para>
    ///   <para>rdfs:comment : A file attachment.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a DocumentAttachment is a described resource, hence DC terms apply:
    ///   - troubleTicketAttachmentForTicket &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    ///   - changeRequestAttachment &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    /// - *BBO*: a DocumentAttachment is a DocumentResource in the sense that it is the result of the Incident Management Process (IMP) or Change Management Process (CMP) and can be used as an input for another activity. From the BPMN 2.0 perspective, a DocumentAttachment is a DataObject.
    ///     </para>
    ///   <a href="https://w3id.org/noria/ontology/DocumentAttachment">noria:DocumentAttachment</a>
    /// </summary>
    let DocumentAttachment = _prefixId.prefix "DocumentAttachment"
    let DocumentOntology = _prefixId.prefix "DocumentOntology"
    let ``DocumentOntology_0.2`` = _prefixId.prefix "DocumentOntology-0.2"
    /// <summary>
    ///   <para>skos:example : An alarm with happens_on or followed_by properties^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DynamicElement</para>
    ///   <para>rdfs:comment : Abstract class for time-related entities and their potential chaining (a.k.a. *Dynamic facet*).</para>
    ///   <a href="https://w3id.org/noria/ontology/DynamicElement">noria:DynamicElement</a>
    /// </summary>
    let DynamicElement = _prefixId.prefix "DynamicElement"
    /// <summary>
    ///   <para>skos:example : - A network router event with
    ///   loggingTime=`2022-01-01T17:12:00,259Z` and
    ///   logText=`LINEPROTO-5-UPDOWN: Line protocol on Interface GigabitEthernet0/0/1, changed state to up`.
    /// - A configuration change event on network router with
    ///   pep:hasCommand='no shutdown' and
    ///   logText='SYS-5-CONFIG_I: Configured from console by vty2 (10.34.195.36)'
    ///   and logOriginatingManagedObject=&lt;object/NE_R1&gt;.
    /// </para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - EventRecord introduced, replacing noria:EventLog.
    /// - Removing many related properties to the benefit of direct instanciation with dcterms properties.
    /// - Adding rdfs:subClassOf BBO:DocumentResource.
    /// - Adding rdfs:subClassOf pep:ProcedureExecution.
    /// - Adding rdfs:subClassOf log:Event.
    /// ^^xsd:string</para>
    ///   <para>rdfs:comment : This managed object represents the information stored in the log as a result of receiving notifications or incoming event reports.
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
    /// </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : EventRecord^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/EventRecord">noria:EventRecord</a>
    /// </summary>
    let EventRecord = _prefixId.prefix "EventRecord"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FunctionalElement</para>
    ///   <para>rdfs:comment : Abstract class for services and broadcasting zones above the *Structural* facet (a.k.a. *Functional facet*).</para>
    ///   <a href="https://w3id.org/noria/ontology/FunctionalElement">noria:FunctionalElement</a>
    /// </summary>
    let FunctionalElement = _prefixId.prefix "FunctionalElement"
    let LocationOntology = _prefixId.prefix "LocationOntology"
    let ``LocationOntology_0.2`` = _prefixId.prefix "LocationOntology-0.2"
    /// <summary>
    ///   <para>rdfs:comment : A uniquely identified space for Resources within a given Room.
    ///
    /// Alignment:
    /// - *BOT*:
    ///   - The relationship to the Locus of a Room is available with the `bot:containsZone` property.
    ///   - Approximating the geographical coordinates of a Locus is feasible through transitive inference over the `bot:hasZeroPoint` of the parent `bot:Site` (considering the GeoNames database this would to a `(bot:Site)=[bot:hasZeroPoint]=&gt;(gn:Feature)` path towards `wgs84_pos:lat` or `wgs84_pos:long` values).
    /// - *ORG*: Note that, at instanciation time, `bot:Site` entities may also be `org:Site` (see https://www.w3.org/TR/vocab-org/#org:Site) in order to allow for an Organization (including teams, persons, manufacturers) to be localized (e.g. see `org:basedAt`), and hence allow for intervention distance/time calculus or threat calculus with respect to a given Locus.
    /// </para>
    ///   <para>skos:example : Line:L, Column:6, in Room:Server room 314.skos:example : Ligne:L, Colonne:6, en Salle:SALLE STOCKAGE RESEAU 314.</para>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>rdfs:label : Locus^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/Locus">noria:Locus</a>
    /// </summary>
    let Locus = _prefixId.prefix "Locus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ManagedElement</para>
    ///   <para>rdfs:comment : Top abstract class of NORIA Cyber/Physical concepts for describing, managing and analyzing ICT systems.</para>
    ///   <a href="https://w3id.org/noria/ontology/ManagedElement">noria:ManagedElement</a>
    /// </summary>
    let ManagedElement = _prefixId.prefix "ManagedElement"
    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subClassOf observable:NetworkInterface.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NetworkInterface^^xsd:string</para>
    ///   <para>rdfs:comment : A Network Interface of some Resource (e.g. server, router, virtual routing and forwarding (VRF) instance), and of some type (e.g. physical, virtual).
    ///
    /// Usage notes:
    /// - The name of the Network Interface (aka. networkInterfaceName, such as `ge-0/0/0.3013` or `ae52.3028`) can be set with the `rdfs:label` property.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/NetworkInterface">noria:NetworkInterface</a>
    /// </summary>
    let NetworkInterface = _prefixId.prefix "NetworkInterface"
    /// <summary>
    ///   <para>skos:example : Optical fiber, L2TP connection, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NetworkLink^^xsd:string</para>
    ///   <para>rdfs:comment : A physical or logical Link between Resources.
    ///
    /// Usage notes:
    /// - The organizational unit in charge of the Network Link (i.e. the Support team or Owner of the Network Link) can be set with the `noria:resourceManagedBy` property.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/NetworkLink">noria:NetworkLink</a>
    /// </summary>
    let NetworkLink = _prefixId.prefix "NetworkLink"
    let NotificationOntology = _prefixId.prefix "NotificationOntology"
    let ``NotificationOntology_0.2`` = _prefixId.prefix "NotificationOntology-0.2"
    let ObservableOntology = _prefixId.prefix "ObservableOntology"
    let ``ObservableOntology_0.2`` = _prefixId.prefix "ObservableOntology-0.2"
    /// <summary>
    ///   <para>rdfs:comment : An abstract class representing a formal set of operations to be carried out in a standardized/controlled way.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subClassOf folio:ControlMethod.
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : OperationPlan^^xsd:string</para>
    ///   <para>skos:example : A system upgrade procedure, a network traffic fail-over activation, the control method for qualifying some system fault.</para>
    ///   <a href="https://w3id.org/noria/ontology/OperationPlan">noria:OperationPlan</a>
    /// </summary>
    let OperationPlan = _prefixId.prefix "OperationPlan"
    /// <summary>
    ///   <para>skos:example : Incident diagnosis procedure, cyber attack scenario, network route fail-over algorithm</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ProceduralElement</para>
    ///   <para>rdfs:comment : Abstract class for (predeﬁned/computed) operational process (a.k.a. *Procedural facet*).</para>
    ///   <a href="https://w3id.org/noria/ontology/ProceduralElement">noria:ProceduralElement</a>
    /// </summary>
    let ProceduralElement = _prefixId.prefix "ProceduralElement"
    let ProceduralObject = _prefixId.prefix "ProceduralObject"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ProductModel^^xsd:string</para>
    ///   <para>rdfs:comment : The Product Model of some Resource as per the Manufacturer's naming.</para>
    ///   <a href="https://w3id.org/noria/ontology/ProductModel">noria:ProductModel</a>
    /// </summary>
    let ProductModel = _prefixId.prefix "ProductModel"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : An abstract representation of qualifiable, quantifiable, observable or operable qualities of some Element.</para>
    ///   <a href="https://w3id.org/noria/ontology/Property">noria:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:comment : General resource record of the Communication Device kind from the logistics park. It is a managed entity that can be either Physical or Virtual.
    ///
    /// Alignment:
    /// - *SEAS*: Whenever a Resource individual is an assembly of other resources (e.g. a server rack) or is part of an assembly (e.g. a server blade), the Resource individual can also be declared as a `seas:System` in order to benefit of the `seas:subSystemOf` relation.
    ///   For example, Resources may be grouped in some `noria:Service` class for providing both an end-to-end analysis of the data path (i.e. Communication Devices + Connections) and an abstract object linked to some end user (e.g. Customer).
    /// - *BOT*: A `noria:Resource` is a sub-class of `bot:Element` for setting instances in the context of a physical environment (e.g. in a building).
    /// - *SLOGERT*: A `noria:Resource` is equivalent to a `log:Host`.
    /// - *UCO*: A `noria:Resource` is equivalent to an UCO's observable `Device`.
    /// </para>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subClassOf bot:Element.
    /// - Adding rdfs:subClassOf observable:Device.
    /// - Adding rdfs:subClassOf log:Host.
    /// ^^xsd:string</para>
    ///   <para>skos:altLabel : Elément structurant informatique et télécoms.skos:altLabel : ICT resource.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/Resource">noria:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    let ResourceOntology = _prefixId.prefix "ResourceOntology"
    let ``ResourceOntology_0.2`` = _prefixId.prefix "ResourceOntology-0.2"
    /// <summary>
    ///   <para>skos:example : Server room 314skos:example : SALLE STOCKAGE RESEAU 314</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Room^^xsd:string</para>
    ///   <para>rdfs:comment : A part of the physical world or a virtual world whose 3D spatial extent is bounded actually or theoretically, and provides for certain functions within the zone it is contained in.
    ///
    /// Alignment:
    /// - *BOT*: A Room is a specialization of a `bot:Space` for common sense understanding.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/Room">noria:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>skos:example : End-to-end data path for some specific customer</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Service is an abstract base class for defining the Service hierarchy, i.e. the composition of assets (a.k.a. asset chain, service function chain) for providing a end-to-end data path or processing for some specific Customer or purpose.
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
    /// </para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Further definition, notably with rdfs:seeAlso relationships.
    /// - Adding owl:equivalentClass devopsprod:ServiceInstance.
    /// ^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/Service">noria:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>skos:example : router xxx, virtual machine yyy, link zzz entities; is_a, connected_to or part_of properties</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : StructuralElement</para>
    ///   <para>rdfs:comment : Abstract class for physical/logical ICT systems's assets and relations (a.k.a. *Structural facet*).</para>
    ///   <a href="https://w3id.org/noria/ontology/StructuralElement">noria:StructuralElement</a>
    /// </summary>
    let StructuralElement = _prefixId.prefix "StructuralElement"
    /// <summary>
    ///   <para>skos:example : Time context of the observable value</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : StructuralObservable</para>
    ///   <para>rdfs:comment : An abstract class for ICT systems's properties that should be defined as classes for extended description capability.</para>
    ///   <a href="https://w3id.org/noria/ontology/StructuralObservable">noria:StructuralObservable</a>
    /// </summary>
    let StructuralObservable = _prefixId.prefix "StructuralObservable"
    let StructuralProperty = _prefixId.prefix "StructuralProperty"
    /// <summary>
    ///   <para>rdfs:label : TroubleTicket^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A trouble ticket represents a record used for reporting and managing the resolution of resource problems. Main trouble ticket attributes are its description, severity, type, priority, related dates (created, target resolution, resolution, etc.), state and related information (change reason, change date), related parties (originator, owner, pilot), notes, trouble causes and impacts.
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
    ///     </para>
    ///   <a href="https://w3id.org/noria/ontology/TroubleTicket">noria:TroubleTicket</a>
    /// </summary>
    let TroubleTicket = _prefixId.prefix "TroubleTicket"
    /// <summary>
    ///   <para>skos:example : We shut interface ge-0-0-1 of Router1 in order to force route on Router2.
    /// 2.6Gb traffic measured at 10:28.
    /// Customer has confirmed that the service is restored.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TroubleTicketNote^^xsd:string</para>
    ///   <para>rdfs:comment : A trouble ticket note represents a record used for reporting and information sharing during the incident management process for a given Trouble Ticket.
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
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/TroubleTicketNote">noria:TroubleTicketNote</a>
    /// </summary>
    let TroubleTicketNote = _prefixId.prefix "TroubleTicketNote"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : actionCorrelatedOperationPlan^^xsd:string</para>
    ///   <para>rdfs:comment : The Operation Plan (procedure) guiding the execution of the given Action.</para>
    ///   <a href="https://w3id.org/noria/ontology/actionCorrelatedOperationPlan">noria:actionCorrelatedOperationPlan</a>
    /// </summary>
    let actionCorrelatedOperationPlan = _prefixId.prefix "actionCorrelatedOperationPlan"
    /// <summary>
    ///   <para>skos:example : Use the Ticketing system + hotline phone number for national L2 and L3 issues.</para>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - rdfs:domain moved from noria:Employee to foaf:Agent.
    /// - name and label moved from teamInstructions to agentInstructions.
    /// - adding rdfs:subPropertyOf observable:contactNote.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : agentInstructions^^xsd:string</para>
    ///   <para>rdfs:comment : Instructions for involving the Agent (Team, Group, Employee).</para>
    ///   <a href="https://w3id.org/noria/ontology/agentInstructions">noria:agentInstructions</a>
    /// </summary>
    let agentInstructions = _prefixId.prefix "agentInstructions"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - rdfs:domain moved from noria:Employee to foaf:Agent.
    /// - name and label moved from teamManagesResource to agentManagesResource.
    /// - Removing rdfs:range noria:Resource for noria:Resource and noria:NetworkLink compatibility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : agentManagesResource^^xsd:string</para>
    ///   <para>rdfs:comment : The Network Element (IT Resource) the Agent is responsible of (supervises).
    ///
    /// Alignment:
    /// - *FOAF*: A team may be interested into following the state of some resources, hence this property is semantically akin to `foaf:topic_interest`.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/agentManagesResource">noria:agentManagesResource</a>
    /// </summary>
    let agentManagesResource = _prefixId.prefix "agentManagesResource"
    /// <summary>
    ///   <para>skos:example : Phone, e-mail</para>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - rdfs:domain moved from noria:Employee to foaf:Agent.
    /// - name and label moved from employeePreferredContactMethod to agentPreferredContactMethod.
    /// - adding rdfs:subPropertyOf observable:contactNote.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : agentPreferredContactMethod^^xsd:string</para>
    ///   <para>rdfs:comment : The preferred contact method to reach the Agent (Team, Group, Employee).</para>
    ///   <a href="https://w3id.org/noria/ontology/agentPreferredContactMethod">noria:agentPreferredContactMethod</a>
    /// </summary>
    let agentPreferredContactMethod = _prefixId.prefix "agentPreferredContactMethod"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - rdfs:domain moved from noria:Employee to foaf:Agent.
    /// - name and label moved from teamWorkingHours to agentWorkingHours.^^xsd:string</para>
    ///   <para>rdfs:comment : The Working Hours for reaching the Agent (Team, Employee, etc.).</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : agentWorkingHours^^xsd:string</para>
    ///   <para>skos:example : 8:00 am - 12:00 am / 1:00 pm - 5:30 pm (Mon --&gt; Fri)skos:example : 8H-12H/13H-17H30 (lun --&gt; ven)</para>
    ///   <a href="https://w3id.org/noria/ontology/agentWorkingHours">noria:agentWorkingHours</a>
    /// </summary>
    let agentWorkingHours = _prefixId.prefix "agentWorkingHours"
    /// <summary>
    ///   <para>skos:example : ProcedureExecutionContainer(x)
    ///     .ldp:member EventRecord(y)
    ///         .hasCommand='ip address 10.1.5.1 255.255.255.0'
    ///         .hasResult='SYS-5-CONFIG_I: Configured from console by vty2 (10.34.195.36)'
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : alarmMitigatedBy^^xsd:string</para>
    ///   <para>rdfs:comment : The ProcedureExecutionContainer (i.e. the set of Procedure Execution(s)) that led to clear the alarm and/or solve the issue.
    ///
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.</para>
    ///   <a href="https://w3id.org/noria/ontology/alarmMitigatedBy">noria:alarmMitigatedBy</a>
    /// </summary>
    let alarmMitigatedBy = _prefixId.prefix "alarmMitigatedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : alarmMonitoredAttribute^^xsd:string</para>
    ///   <para>rdfs:comment : The Monitored attributes parameter, when present, defines one or more attributes of the managed object and their corresponding values at the time of the alarm.
    /// Managed object definers may specify the set of attributes which are of interest, if any.
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/alarmMonitoredAttribute">noria:alarmMonitoredAttribute</a>
    /// </summary>
    let alarmMonitoredAttribute = _prefixId.prefix "alarmMonitoredAttribute"
    /// <summary>
    ///   <para>rdfs:comment : This parameter, when present, is used if the cause is known and the system being managed can suggest one or more solutions.
    /// This parameter is a set of possibilities specified by the object class definer.
    /// </para>
    ///   <para>skos:example : Switch to standby equipment, retry to connect, replace media, etc.</para>
    ///   <para>rdfs:label : alarmProposedRepairAction^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/alarmProposedRepairAction">noria:alarmProposedRepairAction</a>
    /// </summary>
    let alarmProposedRepairAction = _prefixId.prefix "alarmProposedRepairAction"
    /// <summary>
    ///   <para>skos:example : Critical, Major, Minor, Warning.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of how it is perceived that the capability of the managed object has been affected, or how serious are the service affecting conditions (including for security alarms).</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Changed owl:hasValue restriction to &lt;Notification/Severity/PerceivedSeverity&gt; in place of &lt;Notification/PerceivedSeverity&gt;.
    /// - Adding rdfs:subPropertyOf dcterms:type.
    /// - Adding rdfs:subPropertyOf folio:hasCriticality.
    /// - Merging the noria:securityAlarmSeverity.
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : alarmSeverity^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/alarmSeverity">noria:alarmSeverity</a>
    /// </summary>
    let alarmSeverity = _prefixId.prefix "alarmSeverity"
    /// <summary>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationBusinessImportance^^xsd:string</para>
    ///   <para>rdfs:comment : The importance of the Application from the business impact perspective for risk assessment analysis and incident management prioritization.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationBusinessImportance">noria:applicationBusinessImportance</a>
    /// </summary>
    let applicationBusinessImportance = _prefixId.prefix "applicationBusinessImportance"
    /// <summary>
    ///   <para>skos:example : - Market and Customer Relationship Management domain
    /// - Service Development, Management and Operations
    /// - Resource Development, Management and Operations^^xsd:string</para>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationFunctionalDomain^^xsd:string</para>
    ///   <para>rdfs:comment : The functional domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalDomain` is equivalent to the *Domain* concept of the ODA Functional Framework.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/applicationFunctionalDomain">noria:applicationFunctionalDomain</a>
    /// </summary>
    let applicationFunctionalDomain = _prefixId.prefix "applicationFunctionalDomain"

    /// <summary>
    ///   <para>skos:example : - Human Resource Management
    /// - Offer and Product Operational Analysis
    /// - Resource Repository Management^^xsd:string</para>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationFunctionalSubDomain^^xsd:string</para>
    ///   <para>rdfs:comment : The functional sub-domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalSubDomain` is equivalent to *Aggregate Business Entities* (ABEs) and *Business Entities* (BEs) of the ODA Functional Framework.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/applicationFunctionalSubDomain">noria:applicationFunctionalSubDomain</a>
    /// </summary>
    let applicationFunctionalSubDomain =
        _prefixId.prefix "applicationFunctionalSubDomain"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModelIdentifier^^xsd:string</para>
    ///   <para>rdfs:comment : Application model code.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModelIdentifier">noria:applicationModelIdentifier</a>
    /// </summary>
    let applicationModelIdentifier = _prefixId.prefix "applicationModelIdentifier"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range foaf:Agent in place of noria:Employee.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleAdministrationLeader^^xsd:string</para>
    ///   <para>rdfs:comment : Responsable de l'entité exploitante.rdfs:comment : Administration leader.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleAdministrationLeader">noria:applicationModuleAdministrationLeader</a>
    /// </summary>
    let applicationModuleAdministrationLeader =
        _prefixId.prefix "applicationModuleAdministrationLeader"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range org:OrganizationalUnit in place of noria:Team.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleAdministrationTeam^^xsd:string</para>
    ///   <para>rdfs:comment : Entité exploitante.rdfs:comment : Administration team.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleAdministrationTeam">noria:applicationModuleAdministrationTeam</a>
    /// </summary>
    let applicationModuleAdministrationTeam =
        _prefixId.prefix "applicationModuleAdministrationTeam"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleHotlineEnabled^^xsd:string</para>
    ///   <para>rdfs:comment : Possibilité d'appel de l'astreinte applicative.rdfs:comment : Hotline enabled for issues on a given ApplicationModule.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleHotlineEnabled">noria:applicationModuleHotlineEnabled</a>
    /// </summary>
    let applicationModuleHotlineEnabled =
        _prefixId.prefix "applicationModuleHotlineEnabled"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range org:OrganizationalUnit in place of noria:Team.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleHotlineGroup^^xsd:string</para>
    ///   <para>rdfs:comment : Hotline team.rdfs:comment : Equipe d'astreinte applicative.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleHotlineGroup">noria:applicationModuleHotlineGroup</a>
    /// </summary>
    let applicationModuleHotlineGroup = _prefixId.prefix "applicationModuleHotlineGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleIdentifier</para>
    ///   <para>rdfs:comment : Application module code.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleIdentifier">noria:applicationModuleIdentifier</a>
    /// </summary>
    let applicationModuleIdentifier = _prefixId.prefix "applicationModuleIdentifier"
    /// <summary>
    ///   <para>skos:example : CONCAT(
    ///     Application().applicationModelIdentifier(),
    ///     "_",
    ///     ApplicationModule().applicationModuleIdentifier()
    /// )</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleName^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the Application module.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleName">noria:applicationModuleName</a>
    /// </summary>
    let applicationModuleName = _prefixId.prefix "applicationModuleName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleOf^^xsd:string</para>
    ///   <para>rdfs:comment : A child/parent relationship between a specific and managed instance of an Application (i.e. an Application Module) and the Application.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleOf">noria:applicationModuleOf</a>
    /// </summary>
    let applicationModuleOf = _prefixId.prefix "applicationModuleOf"
    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf noria:elementManagedBy.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleRelatedParty^^xsd:string</para>
    ///   <para>rdfs:comment : Generic property for linking a party playing a role in the management of the Application Module.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleRelatedParty">noria:applicationModuleRelatedParty</a>
    /// </summary>
    let applicationModuleRelatedParty = _prefixId.prefix "applicationModuleRelatedParty"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleSlaLevel^^xsd:string</para>
    ///   <para>rdfs:comment : SLA level.rdfs:comment : Niveau de service.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleSlaLevel">noria:applicationModuleSlaLevel</a>
    /// </summary>
    let applicationModuleSlaLevel = _prefixId.prefix "applicationModuleSlaLevel"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleSlaLevelDate^^xsd:string</para>
    ///   <para>rdfs:comment : SLA Level date, the date at which the SLA Level has been set or updated.rdfs:comment : Date du Niveau de service.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleSlaLevelDate">noria:applicationModuleSlaLevelDate</a>
    /// </summary>
    let applicationModuleSlaLevelDate = _prefixId.prefix "applicationModuleSlaLevelDate"
    /// <summary>
    ///   <para>rdfs:comment : Etat de service du Module Applicatif.rdfs:comment : Status of the Application Module.</para>
    ///   <para>skos:example : In Productionskos:example : En Production</para>
    ///   <para>rdfs:label : applicationModuleStatus^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleStatus">noria:applicationModuleStatus</a>
    /// </summary>
    let applicationModuleStatus = _prefixId.prefix "applicationModuleStatus"
    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range org:OrganizationalUnit in place of noria:Team.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleSupportGroup^^xsd:string</para>
    ///   <para>rdfs:comment : Level 1 support team.rdfs:comment : Entité support: Point d'Entrée Interface Technique (PEIT) - Exploitant N1.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleSupportGroup">noria:applicationModuleSupportGroup</a>
    /// </summary>
    let applicationModuleSupportGroup = _prefixId.prefix "applicationModuleSupportGroup"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range foaf:Agent in place of noria:Employee.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleSupportLeader^^xsd:string</para>
    ///   <para>rdfs:comment : Support leader.rdfs:comment : Responsable de l'entité support.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleSupportLeader">noria:applicationModuleSupportLeader</a>
    /// </summary>
    let applicationModuleSupportLeader =
        _prefixId.prefix "applicationModuleSupportLeader"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range org:OrganizationalUnit in place of noria:Team.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationModuleSupportTeam^^xsd:string</para>
    ///   <para>rdfs:comment : Level 2 Support Team.rdfs:comment : Entité support : Soutien Applicatif Technique (SAT) - Exploitant N2.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationModuleSupportTeam">noria:applicationModuleSupportTeam</a>
    /// </summary>
    let applicationModuleSupportTeam = _prefixId.prefix "applicationModuleSupportTeam"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : applicationNumericalIdentifier^^xsd:string</para>
    ///   <para>rdfs:comment : Application numerical identifier, the numerical identifier of the Application within the Information System.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationNumericalIdentifier">noria:applicationNumericalIdentifier</a>
    /// </summary>
    let applicationNumericalIdentifier =
        _prefixId.prefix "applicationNumericalIdentifier"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationShortIdentifier^^xsd:string</para>
    ///   <para>rdfs:comment : Application short identifier, a short string identifier of Application within the Information System.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationShortIdentifier">noria:applicationShortIdentifier</a>
    /// </summary>
    let applicationShortIdentifier = _prefixId.prefix "applicationShortIdentifier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applicationType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the Application.</para>
    ///   <a href="https://w3id.org/noria/ontology/applicationType">noria:applicationType</a>
    /// </summary>
    let applicationType = _prefixId.prefix "applicationType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestActorParty^^xsd:string</para>
    ///   <para>rdfs:comment : The actor of the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestActorParty">noria:changeRequestActorParty</a>
    /// </summary>
    let changeRequestActorParty = _prefixId.prefix "changeRequestActorParty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestActualEndTime^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time on which the Change Request implementation has been completed. It is displayed only after the Change Request implementation has been completed actually.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestActualEndTime">noria:changeRequestActualEndTime</a>
    /// </summary>
    let changeRequestActualEndTime = _prefixId.prefix "changeRequestActualEndTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestActualStartTime^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time on which the Change Request implementation has started. It is displayed only after the Change Request implementation has started actually.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestActualStartTime">noria:changeRequestActualStartTime</a>
    /// </summary>
    let changeRequestActualStartTime = _prefixId.prefix "changeRequestActualStartTime"
    /// <summary>
    ///   <para>skos:example : Internal intervention, Third party intervention, Customer intervention, Change requested by customer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Nature of the Change Request</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestCategory">noria:changeRequestCategory</a>
    /// </summary>
    let changeRequestCategory = _prefixId.prefix "changeRequestCategory"
    /// <summary>
    ///   <para>skos:example : Configuration, Preventative maintenance, Software upgrade, Network extension, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestChangeCause^^xsd:string</para>
    ///   <para>rdfs:comment : Cause of (reason for) the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestChangeCause">noria:changeRequestChangeCause</a>
    /// </summary>
    let changeRequestChangeCause = _prefixId.prefix "changeRequestChangeCause"
    /// <summary>
    ///   <para>rdfs:label : changeRequestImpact^^xsd:string</para>
    ///   <para>rdfs:comment : Set of physical/logical entities on which the Change Request is carried-out.</para>
    ///   <para>skos:example : Resource(s), Application(s), Service(s)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestImpact">noria:changeRequestImpact</a>
    /// </summary>
    let changeRequestImpact = _prefixId.prefix "changeRequestImpact"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestInitiatorParty^^xsd:string</para>
    ///   <para>rdfs:comment : The agent initiating the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestInitiatorParty">noria:changeRequestInitiatorParty</a>
    /// </summary>
    let changeRequestInitiatorParty = _prefixId.prefix "changeRequestInitiatorParty"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestIsRegulated^^xsd:string</para>
    ///   <para>rdfs:comment : If *true*, the Change Request is subject to special regulations.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestIsRegulated">noria:changeRequestIsRegulated</a>
    /// </summary>
    let changeRequestIsRegulated = _prefixId.prefix "changeRequestIsRegulated"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestOutageDuration^^xsd:string</para>
    ///   <para>rdfs:comment : Expected duration of the outage, if any involved by the Change Request type.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestOutageDuration">noria:changeRequestOutageDuration</a>
    /// </summary>
    let changeRequestOutageDuration = _prefixId.prefix "changeRequestOutageDuration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestPilotParty^^xsd:string</para>
    ///   <para>rdfs:comment : The pilot of the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestPilotParty">noria:changeRequestPilotParty</a>
    /// </summary>
    let changeRequestPilotParty = _prefixId.prefix "changeRequestPilotParty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestPlannedEndTime^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestPlannedEndTime">noria:changeRequestPlannedEndTime</a>
    /// </summary>
    let changeRequestPlannedEndTime = _prefixId.prefix "changeRequestPlannedEndTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestPlannedStartTime^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestPlannedStartTime">noria:changeRequestPlannedStartTime</a>
    /// </summary>
    let changeRequestPlannedStartTime = _prefixId.prefix "changeRequestPlannedStartTime"
    let changeRequestRelatedParty = _prefixId.prefix "changeRequestRelatedParty"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : An item of the standard operation plan catalog for recurring activities.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestSpecification">noria:changeRequestSpecification</a>
    /// </summary>
    let changeRequestSpecification = _prefixId.prefix "changeRequestSpecification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestStatusCurrent^^xsd:string</para>
    ///   <para>rdfs:comment : The current status of the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestStatusCurrent">noria:changeRequestStatusCurrent</a>
    /// </summary>
    let changeRequestStatusCurrent = _prefixId.prefix "changeRequestStatusCurrent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeRequestType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the request describes the a priori impact and risk level of the Change Request.</para>
    ///   <a href="https://w3id.org/noria/ontology/changeRequestType">noria:changeRequestType</a>
    /// </summary>
    let changeRequestType = _prefixId.prefix "changeRequestType"
    /// <summary>
    ///   <para>rdfs:comment : Relates a Resource that is part of a cluster with the cluster controller.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : clusterController^^xsd:string</para>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>skos:example : Resource("cluster-01").clusterController("virtual-center-01")^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/clusterController">noria:clusterController</a>
    /// </summary>
    let clusterController = _prefixId.prefix "clusterController"
    /// <summary>
    ///   <para>skos:example : Customer reference, Identifier coming from an external system, etc.</para>
    ///   <para>rdfs:label : documentExternalId^^xsd:string</para>
    ///   <para>rdfs:comment : ID given by the requestor to facilitate the relationship set up and searches afterwards.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/documentExternalId">noria:documentExternalId</a>
    /// </summary>
    let documentExternalId = _prefixId.prefix "documentExternalId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : documentHRef^^xsd:string</para>
    ///   <para>rdfs:comment : Hyperlink to the TroubleTicket or ChangeRequest entity in the originating information system.</para>
    ///   <a href="https://w3id.org/noria/ontology/documentHRef">noria:documentHRef</a>
    /// </summary>
    let documentHRef = _prefixId.prefix "documentHRef"
    /// <summary>
    ///   <para>rdfs:label : documentStatusHistory^^xsd:string</para>
    ///   <para>rdfs:comment : The status change history of the document as recorded by the system's logging feature.</para>
    ///   <para>skos:example : EventRecord
    ///     .loggingTime("2019-01-23T11:58:00Z")
    ///     .logOriginatingManagementSystem(&lt;/object/APP_MyOSS&gt;)
    ///     .references(&lt;/document/TT_2019-01-23_Resource1&gt;)
    ///     .title("InProgress")
    ///     .type &lt;/kos/Notification/EventType/stateChange&gt;^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/documentStatusHistory">noria:documentStatusHistory</a>
    /// </summary>
    let documentStatusHistory = _prefixId.prefix "documentStatusHistory"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : elementDistinguishedName</para>
    ///   <para>rdfs:comment : The Distinguished Name of the Element Instance (i.e. unique identifier).</para>
    ///   <a href="https://w3id.org/noria/ontology/elementDistinguishedName">noria:elementDistinguishedName</a>
    /// </summary>
    let elementDistinguishedName = _prefixId.prefix "elementDistinguishedName"
    /// <summary>
    ///   <para>skos:changeNote : Introduced in v0.2.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : elementManagedBy^^xsd:string</para>
    ///   <para>rdfs:comment : The Agent or Owner of the Managed Element.
    ///
    /// Alignment:
    /// - *ORG*: the *elementManagedBy* property can range an `org:Organization` or `org:OrganizationalUnit` entity as the ORG data model defines these class as subClassOf `foaf:Agent` (see [org:Organization](https://www.w3.org/TR/vocab-org/#org:Organization)).
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/elementManagedBy">noria:elementManagedBy</a>
    /// </summary>
    let elementManagedBy = _prefixId.prefix "elementManagedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : elementProperty</para>
    ///   <para>rdfs:comment : An abstract representation of a relationship between some Element instance and some Property instance.</para>
    ///   <a href="https://w3id.org/noria/ontology/elementProperty">noria:elementProperty</a>
    /// </summary>
    let elementProperty = _prefixId.prefix "elementProperty"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : eventRelatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The structural or functional element instance some event or time-dependant entity is related with.</para>
    ///   <a href="https://w3id.org/noria/ontology/eventRelatedElement">noria:eventRelatedElement</a>
    /// </summary>
    let eventRelatedElement = _prefixId.prefix "eventRelatedElement"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : eventRelatedParty^^xsd:string</para>
    ///   <para>rdfs:comment : Party playing a role (stakeholders) in the life cycle of a given event instance or time-dependant entity.</para>
    ///   <a href="https://w3id.org/noria/ontology/eventRelatedParty">noria:eventRelatedParty</a>
    /// </summary>
    let eventRelatedParty = _prefixId.prefix "eventRelatedParty"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : functionalElementDistinguishedName</para>
    ///   <para>rdfs:comment : The Distinguished Name of the Functional Element Instance (i.e. unique identifier).</para>
    ///   <a href="https://w3id.org/noria/ontology/functionalElementDistinguishedName">noria:functionalElementDistinguishedName</a>
    /// </summary>
    let functionalElementDistinguishedName =
        _prefixId.prefix "functionalElementDistinguishedName"

    /// <summary>
    ///   <para>rdfs:comment : A uniquely identified space of the Resource within a given Room.
    ///
    /// Alignment:
    /// - *UCO*: This property enables linking a concrete `Resource` instance to some location, hence it relates to `observable:location`.
    /// - *BOT*: This property is akin to the inverse of `bot:hasElement`.
    /// </para>
    ///   <para>rdfs:label : locatedAtLocus^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>skos:example : Line: L, Column:6, in Room:Server room 314.skos:example : Ligne:L, Colonne:6, en Salle:SALLE STOCKAGE RESEAU 314.</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:range noria:Locus.
    /// - Adding rdfs:subPropertyOf observable:location.
    /// ^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/locatedAtLocus">noria:locatedAtLocus</a>
    /// </summary>
    let locatedAtLocus = _prefixId.prefix "locatedAtLocus"
    /// <summary>
    ///   <para>skos:example : Line:L, in Room:Server room 314.</para>
    ///   <para>skos:changeNote : Addition in v0.2.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : locusLine^^xsd:string</para>
    ///   <para>rdfs:comment : The line identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.</para>
    ///   <a href="https://w3id.org/noria/ontology/locusLine">noria:locusLine</a>
    /// </summary>
    let locusLine = _prefixId.prefix "locusLine"
    /// <summary>
    ///   <para>skos:example : Column:6, in Room:Server room 314.</para>
    ///   <para>skos:changeNote : Addition in v0.2.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : locusLine^^xsd:string</para>
    ///   <para>rdfs:comment : The row identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.</para>
    ///   <a href="https://w3id.org/noria/ontology/locusRow">noria:locusRow</a>
    /// </summary>
    let locusRow = _prefixId.prefix "locusRow"
    /// <summary>
    ///   <para>rdfs:comment : The Agent at the origin of the Log record whenever it represents some action carried out on the ICT system. This includes information about the service user associated with the service request that caused a security alarm.</para>
    ///   <para>rdfs:label : logOriginatingAgent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - rdfs:range foaf:Agent in place of rdfs:range noria:Employee.
    /// - Adding rdfs:subPropertyOf dcterms:creator.
    /// - Adding rdfs:subPropertyOf prov:wasAttributedTo.
    /// - Merging the noria:alarmServiceUser.
    /// ^^xsd:string</para>
    ///   <para>skos:example : A employee or maintenance bot that carried-out a change or corrective maintenance action. A service user that carried-out SQL Injection.</para>
    ///   <a href="https://w3id.org/noria/ontology/logOriginatingAgent">noria:logOriginatingAgent</a>
    /// </summary>
    let logOriginatingAgent = _prefixId.prefix "logOriginatingAgent"
    /// <summary>
    ///   <para>rdfs:comment : The Managed Object entity at the origin of the Log record. This includes information about the service provider associated with the service request that caused a security alarm.</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf dcterms:creator.
    /// - Adding rdfs:subPropertyOf prov:wasAttributedTo.
    /// - Adding rdfs:subPropertyOf folio:happenedAt.
    /// - Adding rdfs:subPropertyOf log:hasSourceHost.
    /// - Adding reference to ITU-T X721 SecurityAlarmDetector.
    /// - Adding reference to ITU-T X721 serviceProvider.
    /// - Merging the noria:serviceProvider.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : logOriginatingManagedObject^^xsd:string</para>
    ///   <para>skos:example : A named Resource, Application, Security Alarm Detector, etc.</para>
    ///   <a href="https://w3id.org/noria/ontology/logOriginatingManagedObject">noria:logOriginatingManagedObject</a>
    /// </summary>
    let logOriginatingManagedObject = _prefixId.prefix "logOriginatingManagedObject"

    /// <summary>
    ///   <para>rdfs:comment : The Management System that receives, processes and forwards the Log record.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : logOriginatingManagementSystem^^xsd:string</para>
    ///   <para>skos:example : A named instance of Network Management System (NMS), Security Information and Event Monitoring system (SIEM), etc.</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf dcterms:creator.
    /// - Adding rdfs:subPropertyOf prov:wasAttributedTo.
    /// - Adding rdfs:subPropertyOf noria:eventRelatedElement.
    /// ^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/logOriginatingManagementSystem">noria:logOriginatingManagementSystem</a>
    /// </summary>
    let logOriginatingManagementSystem =
        _prefixId.prefix "logOriginatingManagementSystem"

    /// <summary>
    ///   <para>rdfs:label : logText^^xsd:string</para>
    ///   <para>rdfs:comment : Textual information describing the logged event.^^xsd:string</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf dcterms:title.
    /// - Adding rdfs:subPropertyOf pep:hasSimpleResult.
    /// - Adding rdfs:subPropertyOf log:msg.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/logText">noria:logText</a>
    /// </summary>
    let logText = _prefixId.prefix "logText"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The Date on which the log record was created in the system.^^xsd:string</para>
    ///   <para>rdfs:label : loggingTime^^xsd:string</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf dcterms:created.
    /// - Adding rdfs:subPropertyOf log:time.
    /// ^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/loggingTime">noria:loggingTime</a>
    /// </summary>
    let loggingTime = _prefixId.prefix "loggingTime"

    /// <summary>
    ///   <para>skos:example : up, down^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceAdministrativeStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The administrative status of the Network Interface.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceAdministrativeStatus">noria:networkInterfaceAdministrativeStatus</a>
    /// </summary>
    let networkInterfaceAdministrativeStatus =
        _prefixId.prefix "networkInterfaceAdministrativeStatus"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceConnects^^xsd:string</para>
    ///   <para>rdfs:comment : The Network Link the Network Interface is attached-to.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceConnects">noria:networkInterfaceConnects</a>
    /// </summary>
    let networkInterfaceConnects = _prefixId.prefix "networkInterfaceConnects"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceDescription^^xsd:string</para>
    ///   <para>rdfs:comment : A human-readable/editable text that describes the network interface. The information included in the description depends on the capabilities of the Resource's operating system.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceDescription">noria:networkInterfaceDescription</a>
    /// </summary>
    let networkInterfaceDescription = _prefixId.prefix "networkInterfaceDescription"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceLaserRxHighPowerWarningThreshold^^xsd:string</para>
    ///   <para>rdfs:comment : The high received power notification threshold.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceLaserRxHighPowerWarningThreshold">noria:networkInterfaceLaserRxHighPowerWarningThreshold</a>
    /// </summary>
    let networkInterfaceLaserRxHighPowerWarningThreshold =
        _prefixId.prefix "networkInterfaceLaserRxHighPowerWarningThreshold"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceLaserRxLowPowerWarningThreshold^^xsd:string</para>
    ///   <para>rdfs:comment : The low received power notification threshold.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceLaserRxLowPowerWarningThreshold">noria:networkInterfaceLaserRxLowPowerWarningThreshold</a>
    /// </summary>
    let networkInterfaceLaserRxLowPowerWarningThreshold =
        _prefixId.prefix "networkInterfaceLaserRxLowPowerWarningThreshold"

    /// <summary>
    ///   <para>skos:example : Rx = -3.58 dBm^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceLaserRxOpticalPower^^xsd:string</para>
    ///   <para>rdfs:comment : The received optical power measure of the Network Interface, in dBm.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPower">noria:networkInterfaceLaserRxOpticalPower</a>
    /// </summary>
    let networkInterfaceLaserRxOpticalPower =
        _prefixId.prefix "networkInterfaceLaserRxOpticalPower"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceLaserRxOpticalPowerAverage^^xsd:string</para>
    ///   <para>rdfs:comment : The average received optical power of the Network Interface, in dBm.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPowerAverage">noria:networkInterfaceLaserRxOpticalPowerAverage</a>
    /// </summary>
    let networkInterfaceLaserRxOpticalPowerAverage =
        _prefixId.prefix "networkInterfaceLaserRxOpticalPowerAverage"

    /// <summary>
    ///   <para>skos:example : Tx = -2.13 dBm^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceLaserTxOpticalPower^^xsd:string</para>
    ///   <para>rdfs:comment : The emitted optical power measure of the Network Interface, in dBm.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceLaserTxOpticalPower">noria:networkInterfaceLaserTxOpticalPower</a>
    /// </summary>
    let networkInterfaceLaserTxOpticalPower =
        _prefixId.prefix "networkInterfaceLaserTxOpticalPower"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceOf^^xsd:string</para>
    ///   <para>rdfs:comment : The Resource the Network Interface is part-of.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceOf">noria:networkInterfaceOf</a>
    /// </summary>
    let networkInterfaceOf = _prefixId.prefix "networkInterfaceOf"

    /// <summary>
    ///   <para>skos:example : up, down^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceOperationalStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The operational status of the Network Interface.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceOperationalStatus">noria:networkInterfaceOperationalStatus</a>
    /// </summary>
    let networkInterfaceOperationalStatus =
        _prefixId.prefix "networkInterfaceOperationalStatus"

    /// <summary>
    ///   <para>skos:example : IS-IS route priority=122^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceRoutingPriorityMetric^^xsd:string</para>
    ///   <para>rdfs:comment : The metric value associated to the Network Interface for some routing protocol.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceRoutingPriorityMetric">noria:networkInterfaceRoutingPriorityMetric</a>
    /// </summary>
    let networkInterfaceRoutingPriorityMetric =
        _prefixId.prefix "networkInterfaceRoutingPriorityMetric"

    /// <summary>
    ///   <para>skos:example : physical, subinterface, virtual</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkInterfaceType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the Network Interface.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkInterfaceType">noria:networkInterfaceType</a>
    /// </summary>
    let networkInterfaceType = _prefixId.prefix "networkInterfaceType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkLinkId^^xsd:string</para>
    ///   <para>rdfs:comment : The UID of the NetworkLink.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkLinkId">noria:networkLinkId</a>
    /// </summary>
    let networkLinkId = _prefixId.prefix "networkLinkId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkLinkInstallationDate^^xsd:string</para>
    ///   <para>rdfs:comment : The installation date of the NetworkLink.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkLinkInstallationDate">noria:networkLinkInstallationDate</a>
    /// </summary>
    let networkLinkInstallationDate = _prefixId.prefix "networkLinkInstallationDate"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : networkLinkTerminationResource^^xsd:string</para>
    ///   <para>rdfs:comment : Link termination Resource, the Resource at some end fo the Network Link.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkLinkTerminationResource">noria:networkLinkTerminationResource</a>
    /// </summary>
    let networkLinkTerminationResource =
        _prefixId.prefix "networkLinkTerminationResource"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : networkLinkType^^xsd:string</para>
    ///   <para>rdfs:comment : A description of the type of the Network Link.</para>
    ///   <a href="https://w3id.org/noria/ontology/networkLinkType">noria:networkLinkType</a>
    /// </summary>
    let networkLinkType = _prefixId.prefix "networkLinkType"
    let ``noria_0.1`` = _prefixId.prefix "noria-0.1"
    let ``noria_0.2`` = _prefixId.prefix "noria-0.2"
    /// <summary>
    ///   <para>rdfs:comment : The ActionPostCondition to check/that would be observed whenever the OperationPlan is carried out.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the output, hence `operationPlanPostCondition` is a kind of `pep:hasOutput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPostCondition` is the description of what should be observed to after the realization of a given Task, hence it is a kind of `BBO:has_completionCondition`.
    /// </para>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - Adding pep:hasOutput.
    /// - Adding rdfs:subPropertyOf BBO::has_completionCondition.
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : operationPlanPostCondition^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/operationPlanPostCondition">noria:operationPlanPostCondition</a>
    /// </summary>
    let operationPlanPostCondition = _prefixId.prefix "operationPlanPostCondition"
    /// <summary>
    ///   <para>rdfs:label : operationPlanPreCondition^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionPreCondition to check/that would be checked whenever the OperationPlan will be executed/is executed.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the input, hence `operationPlanPreCondition` is a kind of `pep:hasInput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPreCondition` is the description of what may activate the realization of a given Task, hence it is a kind of `BBO:has_activationCondition`.
    /// </para>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - Adding pep:hasInput.
    /// - Adding rdfs:subPropertyOf BBO::has_activationCondition.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/operationPlanPreCondition">noria:operationPlanPreCondition</a>
    /// </summary>
    let operationPlanPreCondition = _prefixId.prefix "operationPlanPreCondition"
    /// <summary>
    ///   <para>skos:example : Isolated customer site, Total breakdown, Working backup, Downgrading equipment, Inaccessible destination, etc.^^xsd:string</para>
    ///   <para>rdfs:comment : The *final* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.</para>
    ///   <para>rdfs:label : problemCategory</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/problemCategory">noria:problemCategory</a>
    /// </summary>
    let problemCategory = _prefixId.prefix "problemCategory"
    /// <summary>
    ///   <para>rdfs:comment : The *final* area of responsibility identified for the incident.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:example : Customer, Managed access equipment on customer's premises, Managed backbone networks, Managed specific networks, Contract application-hosting services, Ill-defined, etc.^^xsd:string</para>
    ///   <para>rdfs:label : problemResponsibility</para>
    ///   <a href="https://w3id.org/noria/ontology/problemResponsibility">noria:problemResponsibility</a>
    /// </summary>
    let problemResponsibility = _prefixId.prefix "problemResponsibility"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - property name and label changed from noria:manufacturedBy to noria:productManufacturedBy.
    /// - rdfs:range moved from noria:Manufacturer to org:Organization.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : productManufacturedBy^^xsd:string</para>
    ///   <para>rdfs:comment : The Manufacturer of the Product Model.</para>
    ///   <a href="https://w3id.org/noria/ontology/productManufacturedBy">noria:productManufacturedBy</a>
    /// </summary>
    let productManufacturedBy = _prefixId.prefix "productManufacturedBy"
    /// <summary>
    ///   <para>skos:example : Corporate Internet access Infrastructure, Clock synchronization Service</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceForApplication^^xsd:string</para>
    ///   <para>rdfs:comment : The Application this Resource is contributing to, whatever the Application type.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceForApplication">noria:resourceForApplication</a>
    /// </summary>
    let resourceForApplication = _prefixId.prefix "resourceForApplication"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceHostName^^xsd:string</para>
    ///   <para>rdfs:comment : The hostname (nodename) of the Resource.</para>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding rdfs:subPropertyOf log:host.
    /// - Adding rdfs:subPropertyOf observable:hostname.
    /// ^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceHostName">noria:resourceHostName</a>
    /// </summary>
    let resourceHostName = _prefixId.prefix "resourceHostName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceInstallationDate^^xsd:string</para>
    ///   <para>rdfs:comment : The installation date of the Resource.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceInstallationDate">noria:resourceInstallationDate</a>
    /// </summary>
    let resourceInstallationDate = _prefixId.prefix "resourceInstallationDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceLogisticId^^xsd:string</para>
    ///   <para>rdfs:comment : The logistic UID of the Resource (a.k.a. asset tag).</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceLogisticId">noria:resourceLogisticId</a>
    /// </summary>
    let resourceLogisticId = _prefixId.prefix "resourceLogisticId"
    /// <summary>
    ///   <para>skos:example : - Resource("DNS server").resourceManagedBy("DNS admin team")
    /// - NetworkLink("WAN Paris-Papeete").resourceManagedBy("International backbone support team")^^xsd:string</para>
    ///   <para>skos:changeNote : Change in v0.2:
    /// - rdfs:range moved from noria:Team and noria:Organization to foaf:Agent.
    /// - Removing rdfs:range foaf:Agent as it is already defined by noria:elementManagedBy.
    /// - Removing rdfs:domain noria:Resource for noria:Resource and noria:NetworkLink compatibility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceManagedBy^^xsd:string</para>
    ///   <para>rdfs:comment : The Support team or Owner of the Network Element (IT Resource).</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceManagedBy">noria:resourceManagedBy</a>
    /// </summary>
    let resourceManagedBy = _prefixId.prefix "resourceManagedBy"
    /// <summary>
    ///   <para>skos:example : - IPv4: 192.168.1.25.
    /// - IPv6: 2001:0db8:0000:0000:0000:8a2e:0370:7334</para>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : resourceManagementIPAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the IP address for remote management of the Resource, if relevant.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceManagementIPAddress">noria:resourceManagementIPAddress</a>
    /// </summary>
    let resourceManagementIPAddress = _prefixId.prefix "resourceManagementIPAddress"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceProductModel^^xsd:string</para>
    ///   <para>rdfs:comment : The product model of the Resource.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceProductModel">noria:resourceProductModel</a>
    /// </summary>
    let resourceProductModel = _prefixId.prefix "resourceProductModel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceSerialNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The serial number of the Resource.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceSerialNumber">noria:resourceSerialNumber</a>
    /// </summary>
    let resourceSerialNumber = _prefixId.prefix "resourceSerialNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the Network Element Resource.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceType">noria:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : resourceUsageState^^xsd:string</para>
    ///   <para>rdfs:comment : The production state of the Resource.</para>
    ///   <a href="https://w3id.org/noria/ontology/resourceUsageState">noria:resourceUsageState</a>
    /// </summary>
    let resourceUsageState = _prefixId.prefix "resourceUsageState"
    /// <summary>
    ///   <para>skos:changeNote : Introduced in v0.2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : serviceType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the Service.</para>
    ///   <a href="https://w3id.org/noria/ontology/serviceType">noria:serviceType</a>
    /// </summary>
    let serviceType = _prefixId.prefix "serviceType"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2: rdfs:range moved from noria:Site to bot:Site.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : siteId^^xsd:string</para>
    ///   <para>rdfs:comment : A unique identifier of a Site.</para>
    ///   <a href="https://w3id.org/noria/ontology/siteId">noria:siteId</a>
    /// </summary>
    let siteId = _prefixId.prefix "siteId"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2: rdfs:range moved from noria:Site to bot:Site.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : sitePrincipalAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Street address of a Site.</para>
    ///   <a href="https://w3id.org/noria/ontology/sitePrincipalAddress">noria:sitePrincipalAddress</a>
    /// </summary>
    let sitePrincipalAddress = _prefixId.prefix "sitePrincipalAddress"
    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2: rdfs:range moved from noria:Site to bot:Site.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : sitePrincipalAddressCityName^^xsd:string</para>
    ///   <para>rdfs:comment : City Name for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: a `P` class `gn:Feature` (city, village, etc.) may correspond to this property.</para>
    ///   <a href="https://w3id.org/noria/ontology/sitePrincipalAddressCityName">noria:sitePrincipalAddressCityName</a>
    /// </summary>
    let sitePrincipalAddressCityName = _prefixId.prefix "sitePrincipalAddressCityName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : sitePrincipalAddressCountry^^xsd:string</para>
    ///   <para>rdfs:comment : Country name or code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*:
    ///   - a `A` class `gn:Feature` (country, state, region, etc.) may correspond to this property.
    ///   - prefer ISO 3166 values for easier matching with `gn:countryCode`.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/sitePrincipalAddressCountry">noria:sitePrincipalAddressCountry</a>
    /// </summary>
    let sitePrincipalAddressCountry = _prefixId.prefix "sitePrincipalAddressCountry"

    /// <summary>
    ///   <para>skos:changeNote : Change in v0.2: rdfs:range moved from noria:Site to bot:Site.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : sitePrincipalAddressPostalCode^^xsd:string</para>
    ///   <para>rdfs:comment : Postal Code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: *ADM2*, *ADM3* or *ADM4* annotations may correspond to this property, depending on the considered country.</para>
    ///   <a href="https://w3id.org/noria/ontology/sitePrincipalAddressPostalCode">noria:sitePrincipalAddressPostalCode</a>
    /// </summary>
    let sitePrincipalAddressPostalCode =
        _prefixId.prefix "sitePrincipalAddressPostalCode"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : sitePrincipalAddressStreet^^xsd:string</para>
    ///   <para>rdfs:comment : Street for a Site.</para>
    ///   <a href="https://w3id.org/noria/ontology/sitePrincipalAddressStreet">noria:sitePrincipalAddressStreet</a>
    /// </summary>
    let sitePrincipalAddressStreet = _prefixId.prefix "sitePrincipalAddressStreet"
    /// <summary>
    ///   <para>skos:example : building, data center, rack^^xsd:string</para>
    ///   <para>skos:changeNote : Change in v0.2: rdfs:range moved from noria:Site to bot:Site.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : siteType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of a Site.</para>
    ///   <a href="https://w3id.org/noria/ontology/siteType">noria:siteType</a>
    /// </summary>
    let siteType = _prefixId.prefix "siteType"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : structuralElementDistinguishedName</para>
    ///   <para>rdfs:comment : The Distinguished Name of the Structural Element Instance (i.e. unique identifier).</para>
    ///   <a href="https://w3id.org/noria/ontology/structuralElementDistinguishedName">noria:structuralElementDistinguishedName</a>
    /// </summary>
    let structuralElementDistinguishedName =
        _prefixId.prefix "structuralElementDistinguishedName"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : structuralElementObservable</para>
    ///   <para>rdfs:comment : An abstract representation of a relationship between some StructuralElement instance and some StructuralObservable instance.</para>
    ///   <a href="https://w3id.org/noria/ontology/structuralElementObservable">noria:structuralElementObservable</a>
    /// </summary>
    let structuralElementObservable = _prefixId.prefix "structuralElementObservable"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : structuralElementObservableData</para>
    ///   <para>rdfs:comment : An abstract representation of a relationship between some StructuralElement instance and some literal data.</para>
    ///   <a href="https://w3id.org/noria/ontology/structuralElementObservableData">noria:structuralElementObservableData</a>
    /// </summary>
    let structuralElementObservableData =
        _prefixId.prefix "structuralElementObservableData"

    let structuralElementProperty = _prefixId.prefix "structuralElementProperty"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : structuralObservableOf</para>
    ///   <para>rdfs:comment : Relates some `StructuralObservable` instance to some `StructuralElement` instance.</para>
    ///   <a href="https://w3id.org/noria/ontology/structuralObservableOf">noria:structuralObservableOf</a>
    /// </summary>
    let structuralObservableOf = _prefixId.prefix "structuralObservableOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The *initial* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.</para>
    ///   <para>rdfs:label : troubleTicketCategory</para>
    ///   <para>skos:example : Isolated customer site, Total breakdown, Working backup, Downgrading equipment, Inaccessible destination, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketCategory">noria:troubleTicketCategory</a>
    /// </summary>
    let troubleTicketCategory = _prefixId.prefix "troubleTicketCategory"
    /// <summary>
    ///   <para>skos:example : SSH authentication failure due to loss of sync to NTP server and internal clock drift.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketCause</para>
    ///   <para>rdfs:comment : The cause(s) defined for the trouble, in plain text.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketCause">noria:troubleTicketCause</a>
    /// </summary>
    let troubleTicketCause = _prefixId.prefix "troubleTicketCause"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketCharacteristic^^xsd:string</para>
    ///   <para>rdfs:comment : A list of Characteristics of the ticket (TroubleTicketCharacteristic [*]). The Trouble ticket specific characteristics</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketCharacteristic">noria:troubleTicketCharacteristic</a>
    /// </summary>
    let troubleTicketCharacteristic = _prefixId.prefix "troubleTicketCharacteristic"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketCommittedRestorationDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : The Customer Commitment Deadline Date (calculated on product information).</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketCommittedRestorationDateTime">noria:troubleTicketCommittedRestorationDateTime</a>
    /// </summary>
    let troubleTicketCommittedRestorationDateTime =
        _prefixId.prefix "troubleTicketCommittedRestorationDateTime"

    /// <summary>
    ///   <para>skos:example : Interrupted service, Corrupted service, Working backup, etc.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketCriticity</para>
    ///   <para>rdfs:comment : The ticket criticity from the customer impact perspective.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketCriticity">noria:troubleTicketCriticity</a>
    /// </summary>
    let troubleTicketCriticity = _prefixId.prefix "troubleTicketCriticity"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketDetectionDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : The date on which the trouble was discovered.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketDetectionDateTime">noria:troubleTicketDetectionDateTime</a>
    /// </summary>
    let troubleTicketDetectionDateTime =
        _prefixId.prefix "troubleTicketDetectionDateTime"

    /// <summary>
    ///   <para>skos:example : A list of `noria:EventRecord` specifically describing the freeze periods for the given `noria:TroubleTicket`.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketFreezeItem</para>
    ///   <para>rdfs:comment : The ticket freeze period history.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketFreezeItem">noria:troubleTicketFreezeItem</a>
    /// </summary>
    let troubleTicketFreezeItem = _prefixId.prefix "troubleTicketFreezeItem"
    /// <summary>
    ///   <para>skos:example : TroubleTicket.troubleTicketImpacts({Application [*], Resource [*]})^^xsd:string</para>
    ///   <para>rdfs:comment : A list of resources or services (applications) impacted by the trouble.</para>
    ///   <para>rdfs:label : troubleTicketImpacts</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketImpacts">noria:troubleTicketImpacts</a>
    /// </summary>
    let troubleTicketImpacts = _prefixId.prefix "troubleTicketImpacts"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketIsNotificationEnable^^xsd:string</para>
    ///   <para>rdfs:comment : The *enable* or *disable* external notification on trouble ticket events.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketIsNotificationEnable">noria:troubleTicketIsNotificationEnable</a>
    /// </summary>
    let troubleTicketIsNotificationEnable =
        _prefixId.prefix "troubleTicketIsNotificationEnable"

    /// <summary>
    ///   <para>skos:example : Customer, Group, Internal, System, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketNoteCommentType^^xsd:string</para>
    ///   <para>rdfs:comment : The comment provenance type and/or disclosure rules family.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketNoteCommentType">noria:troubleTicketNoteCommentType</a>
    /// </summary>
    let troubleTicketNoteCommentType = _prefixId.prefix "troubleTicketNoteCommentType"

    /// <summary>
    ///   <para>skos:changeNote : Changes in v0.2:
    /// - Adding the troubleTicketNoteCorrelatedExecution property.
    /// ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketNoteCorrelatedExecution^^xsd:string</para>
    ///   <para>rdfs:comment : The correlated *ProcedureExecutionContainer* corresponding to the corrective maintenance actions depicted in the Trouble Ticket Note (i.e. the set of `EventRecord` about interactions with the system and as notified by the system).
    ///
    /// From a practical perspective, relating a `noria:TroubleTicketNote` to a `pep:ProcedureExecutionContainer` is akin to show off the materialization of a corrective maintenance action from the technical perspective.
    /// Note that for actions undoubtedly related to a given trouble ticket note (i.e. that can be asserted without mining for execution context candidates), one can avoid using `troubleTicketNoteCorrelatedExecution` by directly relating the note to `EventRecord` with `ldp:member` as `TroubleTicket` and `TroubleTicketNote` are themselves subclasses of `pep:ProcedureExecutionContainer`.
    /// </para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketNoteCorrelatedExecution">noria:troubleTicketNoteCorrelatedExecution</a>
    /// </summary>
    let troubleTicketNoteCorrelatedExecution =
        _prefixId.prefix "troubleTicketNoteCorrelatedExecution"

    /// <summary>
    ///   <para>skos:example : Inward customer comments, Local customer call back, Tests and measurements, Diagnosis, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketNoteOperationType^^xsd:string</para>
    ///   <para>rdfs:comment : The operation type of the note.^^xsd:string</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketNoteOperationType">noria:troubleTicketNoteOperationType</a>
    /// </summary>
    let troubleTicketNoteOperationType =
        _prefixId.prefix "troubleTicketNoteOperationType"

    /// <summary>
    ///   <para>skos:example : Customer, Supervision, Internal, Carrier, User, Partners^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketOrigin^^xsd:string</para>
    ///   <para>rdfs:comment : The person or group family at the origin of the creation of the Trouble Ticket.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketOrigin">noria:troubleTicketOrigin</a>
    /// </summary>
    let troubleTicketOrigin = _prefixId.prefix "troubleTicketOrigin"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketPartyIntervention</para>
    ///   <para>rdfs:comment : The history of groups activation and responsibility transfer.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketPartyIntervention">noria:troubleTicketPartyIntervention</a>
    /// </summary>
    let troubleTicketPartyIntervention =
        _prefixId.prefix "troubleTicketPartyIntervention"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketPlannedRestorationDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : Confirmed to customer planned restoration date ATR (Actual Time to Restore (ATR)).</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketPlannedRestorationDateTime">noria:troubleTicketPlannedRestorationDateTime</a>
    /// </summary>
    let troubleTicketPlannedRestorationDateTime =
        _prefixId.prefix "troubleTicketPlannedRestorationDateTime"

    /// <summary>
    ///   <para>skos:example : P1, P2, P3, P4^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketPriority</para>
    ///   <para>rdfs:comment : The trouble management priority.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketPriority">noria:troubleTicketPriority</a>
    /// </summary>
    let troubleTicketPriority = _prefixId.prefix "troubleTicketPriority"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketRelatedParty^^xsd:string</para>
    ///   <para>rdfs:comment : The related party(ies) that are associated to the ticket.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketRelatedParty">noria:troubleTicketRelatedParty</a>
    /// </summary>
    let troubleTicketRelatedParty = _prefixId.prefix "troubleTicketRelatedParty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketRelatedResource^^xsd:string</para>
    ///   <para>rdfs:comment : The Resource entity on which the trouble ticket has been created.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketRelatedResource">noria:troubleTicketRelatedResource</a>
    /// </summary>
    let troubleTicketRelatedResource = _prefixId.prefix "troubleTicketRelatedResource"
    /// <summary>
    ///   <para>skos:example : - TroubleTicket.troubleTicketImpacts("syslog-ng")
    ///   Application("syslog-ng").applicationType(&lt;kos/application/type/service-platform&gt;)
    ///
    /// - TroubleTicket.troubleTicketImpacts("Corporate Internet access Infrastructure")
    ///   Application("Corporate Internet access Infrastructure").applicationType(&lt;kos/application/type/infrastructure&gt;)
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketRelatedService^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The *Application* or *Service* entity on which trouble ticket has been created.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketRelatedService">noria:troubleTicketRelatedService</a>
    /// </summary>
    let troubleTicketRelatedService = _prefixId.prefix "troubleTicketRelatedService"
    /// <summary>
    ///   <para>skos:example : Minor, Major, Blocking, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketSeverity^^xsd:string</para>
    ///   <para>rdfs:comment : The criticity of the incident.
    ///
    /// The classification (severity) of the Incident may be defined in accordance with Service Level Agreement (SLA) requirements.
    /// The thresholds of Incident resolution depend on standards defined per service type.
    /// When the thresholds are exceeded, specific process of escalation may be activated.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketSeverity">noria:troubleTicketSeverity</a>
    /// </summary>
    let troubleTicketSeverity = _prefixId.prefix "troubleTicketSeverity"
    /// <summary>
    ///   <para>skos:example : Initialised, InProgress, Frozen, Restored, Resolved, Closed^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketStatusCurrent^^xsd:string</para>
    ///   <para>rdfs:comment : The current activity status of the trouble ticket.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketStatusCurrent">noria:troubleTicketStatusCurrent</a>
    /// </summary>
    let troubleTicketStatusCurrent = _prefixId.prefix "troubleTicketStatusCurrent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketSupervisionTool^^xsd:string</para>
    ///   <para>rdfs:comment : Supervision tool which detected the problem.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketSupervisionTool">noria:troubleTicketSupervisionTool</a>
    /// </summary>
    let troubleTicketSupervisionTool = _prefixId.prefix "troubleTicketSupervisionTool"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketTargetRestorationDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : The Customer initial restoration date Estimated Time to Restore (ETR).</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketTargetRestorationDateTime">noria:troubleTicketTargetRestorationDateTime</a>
    /// </summary>
    let troubleTicketTargetRestorationDateTime =
        _prefixId.prefix "troubleTicketTargetRestorationDateTime"

    /// <summary>
    ///   <para>skos:example : EventRecord(&lt;event/LOG_srvz01.dfg0f873c811_C015FWR080_2020-11-25&gt;)^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketTrigger^^xsd:string</para>
    ///   <para>rdfs:comment : The EventRecord at the origin of the creation of the Trouble Ticket.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketTrigger">noria:troubleTicketTrigger</a>
    /// </summary>
    let troubleTicketTrigger = _prefixId.prefix "troubleTicketTrigger"
    /// <summary>
    ///   <para>skos:example : Failure, Long period assistance, Assistance, Installation, Maintenance, Parametrization, etc.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketType^^xsd:string</para>
    ///   <para>rdfs:comment : The ticket type.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketType">noria:troubleTicketType</a>
    /// </summary>
    let troubleTicketType = _prefixId.prefix "troubleTicketType"
    /// <summary>
    ///   <para>skos:example : Immediate Intervention, Deferred Intervention, (State of) Emergency, No intervention, etc.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : troubleTicketUrgency^^xsd:string</para>
    ///   <para>rdfs:comment : The priority level of the incident.</para>
    ///   <a href="https://w3id.org/noria/ontology/troubleTicketUrgency">noria:troubleTicketUrgency</a>
    /// </summary>
    let troubleTicketUrgency = _prefixId.prefix "troubleTicketUrgency"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : virtualServerStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The operational status of the Virtual Server.</para>
    ///   <a href="https://w3id.org/noria/ontology/virtualServerStatus">noria:virtualServerStatus</a>
    /// </summary>
    let virtualServerStatus = _prefixId.prefix "virtualServerStatus"
