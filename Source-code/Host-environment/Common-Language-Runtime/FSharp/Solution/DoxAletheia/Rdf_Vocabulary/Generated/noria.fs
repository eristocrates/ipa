namespace https.w3id.org.noria.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module noria =
    let _namespace_iri = Namespace_Iri noria |> NamespaceIRI
    /// <summary>
    ///   <para>noria:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/">https://w3id.org/noria/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(noria, "") |> PrefixedName

    /// <summary>
    ///   <para>noria:NotificationOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/NotificationOntology-0.2">https://w3id.org/noria/ontology/NotificationOntology-0.2</seealso>
    let ``NotificationOntology_0.2`` =
        Prefixed_Name(noria, "NotificationOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:ResourceOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ResourceOntology-0.2">https://w3id.org/noria/ontology/ResourceOntology-0.2</seealso>
    let ``ResourceOntology_0.2`` =
        Prefixed_Name(noria, "ResourceOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:noria-0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/noria-0.1">https://w3id.org/noria/ontology/noria-0.1</seealso>
    let ``noria_0.1`` = Prefixed_Name(noria, "noria-0.1") |> PrefixedName
    /// <summary>
    ///   <para>noria:ActionPreCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of Pre Conditions or Hypothesis enabling/leading to the potential execution of some OperationPlan.</para>
    /// labels<para>ActionPreCondition</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ActionPreCondition">https://w3id.org/noria/ontology/ActionPreCondition</seealso>
    let ActionPreCondition = Prefixed_Name(noria, "ActionPreCondition") |> PrefixedName
    /// <summary>
    ///   <para>noria:FunctionalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for services and broadcasting zones above the *Structural* facet (a.k.a. *Functional facet*).</para>
    /// labels<para>FunctionalElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/FunctionalElement">https://w3id.org/noria/ontology/FunctionalElement</seealso>
    let FunctionalElement = Prefixed_Name(noria, "FunctionalElement") |> PrefixedName

    /// <summary>
    ///   <para>noria:CorporateUserIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Corporate User Identifier (CUid) is the unique identifier of a Person as a member of Organization (i.e. an Employee). It is also the main account of this Person for connecting to the organization's IT resources, including to its personal computer (PC).
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
    /// labels<para>CUid</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/CorporateUserIdentifier">https://w3id.org/noria/ontology/CorporateUserIdentifier</seealso>
    let CorporateUserIdentifier =
        Prefixed_Name(noria, "CorporateUserIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>noria:ManagedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Top abstract class of NORIA Cyber/Physical concepts for describing, managing and analyzing ICT systems.</para>
    /// labels<para>ManagedElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ManagedElement">https://w3id.org/noria/ontology/ManagedElement</seealso>
    let ManagedElement = Prefixed_Name(noria, "ManagedElement") |> PrefixedName
    /// <summary>
    ///   <para>noria:EventRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This managed object represents the information stored in the log as a result of receiving notifications or incoming event reports.
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
    /// labels<para>EventRecord</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/EventRecord">https://w3id.org/noria/ontology/EventRecord</seealso>
    let EventRecord = Prefixed_Name(noria, "EventRecord") |> PrefixedName

    /// <summary>
    ///   <para>noria:NotificationOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/NotificationOntology">https://w3id.org/noria/ontology/NotificationOntology</seealso>
    let NotificationOntology =
        Prefixed_Name(noria, "NotificationOntology") |> PrefixedName

    /// <summary>
    ///   <para>noria:LocationOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/LocationOntology">https://w3id.org/noria/ontology/LocationOntology</seealso>
    let LocationOntology = Prefixed_Name(noria, "LocationOntology") |> PrefixedName
    /// <summary>
    ///   <para>noria:Locus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A uniquely identified space for Resources within a given Room.
    ///
    /// Alignment:
    /// - *BOT*:
    ///   - The relationship to the Locus of a Room is available with the `bot:containsZone` property.
    ///   - Approximating the geographical coordinates of a Locus is feasible through transitive inference over the `bot:hasZeroPoint` of the parent `bot:Site` (considering the GeoNames database this would to a `(bot:Site)=[bot:hasZeroPoint]=&gt;(gn:Feature)` path towards `wgs84_pos:lat` or `wgs84_pos:long` values).
    /// - *ORG*: Note that, at instanciation time, `bot:Site` entities may also be `org:Site` (see https://www.w3.org/TR/vocab-org/#org:Site) in order to allow for an Organization (including teams, persons, manufacturers) to be localized (e.g. see `org:basedAt`), and hence allow for intervention distance/time calculus or threat calculus with respect to a given Locus.
    /// </para>
    /// labels<para>Locus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Locus">https://w3id.org/noria/ontology/Locus</seealso>
    let Locus = Prefixed_Name(noria, "Locus") |> PrefixedName
    /// <summary>
    ///   <para>noria:NetworkInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Network Interface of some Resource (e.g. server, router, virtual routing and forwarding (VRF) instance), and of some type (e.g. physical, virtual).
    ///
    /// Usage notes:
    /// - The name of the Network Interface (aka. networkInterfaceName, such as `ge-0/0/0.3013` or `ae52.3028`) can be set with the `rdfs:label` property.
    /// </para>
    /// labels<para>NetworkInterface</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/NetworkInterface">https://w3id.org/noria/ontology/NetworkInterface</seealso>
    let NetworkInterface = Prefixed_Name(noria, "NetworkInterface") |> PrefixedName
    /// <summary>
    ///   <para>noria:ResourceOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ResourceOntology">https://w3id.org/noria/ontology/ResourceOntology</seealso>
    let ResourceOntology = Prefixed_Name(noria, "ResourceOntology") |> PrefixedName
    /// <summary>
    ///   <para>noria:StructuralElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for physical/logical ICT systems's assets and relations (a.k.a. *Structural facet*).</para>
    /// labels<para>StructuralElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/StructuralElement">https://w3id.org/noria/ontology/StructuralElement</seealso>
    let StructuralElement = Prefixed_Name(noria, "StructuralElement") |> PrefixedName
    /// <summary>
    ///   <para>noria:ObservableOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ObservableOntology">https://w3id.org/noria/ontology/ObservableOntology</seealso>
    let ObservableOntology = Prefixed_Name(noria, "ObservableOntology") |> PrefixedName
    /// <summary>
    ///   <para>noria:OperationPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract class representing a formal set of operations to be carried out in a standardized/controlled way.</para>
    /// labels<para>OperationPlan</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/OperationPlan">https://w3id.org/noria/ontology/OperationPlan</seealso>
    let OperationPlan = Prefixed_Name(noria, "OperationPlan") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModelIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Application model code.</para>
    /// labels<para>applicationModelIdentifier</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModelIdentifier">https://w3id.org/noria/ontology/applicationModelIdentifier</seealso>
    let applicationModelIdentifier =
        Prefixed_Name(noria, "applicationModelIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleAdministrationLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Administration leader.</para>
    ///   <para>Responsable de l'entité exploitante.</para>
    /// labels<para>applicationModuleAdministrationLeader</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleAdministrationLeader">https://w3id.org/noria/ontology/applicationModuleAdministrationLeader</seealso>
    let applicationModuleAdministrationLeader =
        Prefixed_Name(noria, "applicationModuleAdministrationLeader") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleHotlineEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Possibilité d'appel de l'astreinte applicative.</para>
    ///   <para>Hotline enabled for issues on a given ApplicationModule.</para>
    /// labels<para>applicationModuleHotlineEnabled</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleHotlineEnabled">https://w3id.org/noria/ontology/applicationModuleHotlineEnabled</seealso>
    let applicationModuleHotlineEnabled =
        Prefixed_Name(noria, "applicationModuleHotlineEnabled") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleHotlineGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Equipe d'astreinte applicative.</para>
    ///   <para>Hotline team.</para>
    /// labels<para>applicationModuleHotlineGroup</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleHotlineGroup">https://w3id.org/noria/ontology/applicationModuleHotlineGroup</seealso>
    let applicationModuleHotlineGroup =
        Prefixed_Name(noria, "applicationModuleHotlineGroup") |> PrefixedName

    /// <summary>
    ///   <para>noria:functionalElementDistinguishedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Distinguished Name of the Functional Element Instance (i.e. unique identifier).</para>
    /// labels<para>functionalElementDistinguishedName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/functionalElementDistinguishedName">https://w3id.org/noria/ontology/functionalElementDistinguishedName</seealso>
    let functionalElementDistinguishedName =
        Prefixed_Name(noria, "functionalElementDistinguishedName") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A child/parent relationship between a specific and managed instance of an Application (i.e. an Application Module) and the Application.</para>
    /// labels<para>applicationModuleOf</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleOf">https://w3id.org/noria/ontology/applicationModuleOf</seealso>
    let applicationModuleOf =
        Prefixed_Name(noria, "applicationModuleOf") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleSlaLevelDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date du Niveau de service.</para>
    ///   <para>SLA Level date, the date at which the SLA Level has been set or updated.</para>
    /// labels<para>applicationModuleSlaLevelDate</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleSlaLevelDate">https://w3id.org/noria/ontology/applicationModuleSlaLevelDate</seealso>
    let applicationModuleSlaLevelDate =
        Prefixed_Name(noria, "applicationModuleSlaLevelDate") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleSupportGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité support: Point d'Entrée Interface Technique (PEIT) - Exploitant N1.</para>
    ///   <para>Level 1 support team.</para>
    /// labels<para>applicationModuleSupportGroup</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleSupportGroup">https://w3id.org/noria/ontology/applicationModuleSupportGroup</seealso>
    let applicationModuleSupportGroup =
        Prefixed_Name(noria, "applicationModuleSupportGroup") |> PrefixedName

    /// <summary>
    ///   <para>noria:locusLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The line identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.</para>
    /// labels<para>locusLine</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/locusLine">https://w3id.org/noria/ontology/locusLine</seealso>
    let locusLine = Prefixed_Name(noria, "locusLine") |> PrefixedName
    /// <summary>
    ///   <para>noria:locusRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The row identifier in a `noria:Room` for a Locus defined by Cartesian coordinates.</para>
    /// labels<para>locusLine</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/locusRow">https://w3id.org/noria/ontology/locusRow</seealso>
    let locusRow = Prefixed_Name(noria, "locusRow") |> PrefixedName

    /// <summary>
    ///   <para>noria:logOriginatingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Agent at the origin of the Log record whenever it represents some action carried out on the ICT system. This includes information about the service user associated with the service request that caused a security alarm.</para>
    /// labels<para>logOriginatingAgent</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/logOriginatingAgent">https://w3id.org/noria/ontology/logOriginatingAgent</seealso>
    let logOriginatingAgent =
        Prefixed_Name(noria, "logOriginatingAgent") |> PrefixedName

    /// <summary>
    ///   <para>noria:logOriginatingManagedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Managed Object entity at the origin of the Log record. This includes information about the service provider associated with the service request that caused a security alarm.</para>
    /// labels<para>logOriginatingManagedObject</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/logOriginatingManagedObject">https://w3id.org/noria/ontology/logOriginatingManagedObject</seealso>
    let logOriginatingManagedObject =
        Prefixed_Name(noria, "logOriginatingManagedObject") |> PrefixedName

    /// <summary>
    ///   <para>noria:logOriginatingManagementSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Management System that receives, processes and forwards the Log record.</para>
    /// labels<para>logOriginatingManagementSystem</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/logOriginatingManagementSystem">https://w3id.org/noria/ontology/logOriginatingManagementSystem</seealso>
    let logOriginatingManagementSystem =
        Prefixed_Name(noria, "logOriginatingManagementSystem") |> PrefixedName

    /// <summary>
    ///   <para>noria:loggingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Date on which the log record was created in the system.</para>
    /// labels<para>loggingTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/loggingTime">https://w3id.org/noria/ontology/loggingTime</seealso>
    let loggingTime = Prefixed_Name(noria, "loggingTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceAdministrativeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The administrative status of the Network Interface.</para>
    /// labels<para>networkInterfaceAdministrativeStatus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceAdministrativeStatus">https://w3id.org/noria/ontology/networkInterfaceAdministrativeStatus</seealso>
    let networkInterfaceAdministrativeStatus =
        Prefixed_Name(noria, "networkInterfaceAdministrativeStatus") |> PrefixedName

    /// <summary>
    ///   <para>noria:structuralElementObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An abstract representation of a relationship between some StructuralElement instance and some StructuralObservable instance.</para>
    /// labels<para>structuralElementObservable</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/structuralElementObservable">https://w3id.org/noria/ontology/structuralElementObservable</seealso>
    let structuralElementObservable =
        Prefixed_Name(noria, "structuralElementObservable") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Network Link the Network Interface is attached-to.</para>
    /// labels<para>networkInterfaceConnects</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceConnects">https://w3id.org/noria/ontology/networkInterfaceConnects</seealso>
    let networkInterfaceConnects =
        Prefixed_Name(noria, "networkInterfaceConnects") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A human-readable/editable text that describes the network interface. The information included in the description depends on the capabilities of the Resource's operating system.</para>
    /// labels<para>networkInterfaceDescription</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceDescription">https://w3id.org/noria/ontology/networkInterfaceDescription</seealso>
    let networkInterfaceDescription =
        Prefixed_Name(noria, "networkInterfaceDescription") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceLaserRxHighPowerWarningThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The high received power notification threshold.</para>
    /// labels<para>networkInterfaceLaserRxHighPowerWarningThreshold</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceLaserRxHighPowerWarningThreshold">https://w3id.org/noria/ontology/networkInterfaceLaserRxHighPowerWarningThreshold</seealso>
    let networkInterfaceLaserRxHighPowerWarningThreshold =
        Prefixed_Name(noria, "networkInterfaceLaserRxHighPowerWarningThreshold") |> PrefixedName

    /// <summary>
    ///   <para>noria:structuralElementObservableData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An abstract representation of a relationship between some StructuralElement instance and some literal data.</para>
    /// labels<para>structuralElementObservableData</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/structuralElementObservableData">https://w3id.org/noria/ontology/structuralElementObservableData</seealso>
    let structuralElementObservableData =
        Prefixed_Name(noria, "structuralElementObservableData") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceLaserRxLowPowerWarningThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The low received power notification threshold.</para>
    /// labels<para>networkInterfaceLaserRxLowPowerWarningThreshold</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceLaserRxLowPowerWarningThreshold">https://w3id.org/noria/ontology/networkInterfaceLaserRxLowPowerWarningThreshold</seealso>
    let networkInterfaceLaserRxLowPowerWarningThreshold =
        Prefixed_Name(noria, "networkInterfaceLaserRxLowPowerWarningThreshold") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceLaserRxOpticalPowerAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average received optical power of the Network Interface, in dBm.</para>
    /// labels<para>networkInterfaceLaserRxOpticalPowerAverage</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPowerAverage">https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPowerAverage</seealso>
    let networkInterfaceLaserRxOpticalPowerAverage =
        Prefixed_Name(noria, "networkInterfaceLaserRxOpticalPowerAverage") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceLaserTxOpticalPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The emitted optical power measure of the Network Interface, in dBm.</para>
    /// labels<para>networkInterfaceLaserTxOpticalPower</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceLaserTxOpticalPower">https://w3id.org/noria/ontology/networkInterfaceLaserTxOpticalPower</seealso>
    let networkInterfaceLaserTxOpticalPower =
        Prefixed_Name(noria, "networkInterfaceLaserTxOpticalPower") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Resource the Network Interface is part-of.</para>
    /// labels<para>networkInterfaceOf</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceOf">https://w3id.org/noria/ontology/networkInterfaceOf</seealso>
    let networkInterfaceOf = Prefixed_Name(noria, "networkInterfaceOf") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceOperationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The operational status of the Network Interface.</para>
    /// labels<para>networkInterfaceOperationalStatus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceOperationalStatus">https://w3id.org/noria/ontology/networkInterfaceOperationalStatus</seealso>
    let networkInterfaceOperationalStatus =
        Prefixed_Name(noria, "networkInterfaceOperationalStatus") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceRoutingPriorityMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The metric value associated to the Network Interface for some routing protocol.</para>
    /// labels<para>networkInterfaceRoutingPriorityMetric</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceRoutingPriorityMetric">https://w3id.org/noria/ontology/networkInterfaceRoutingPriorityMetric</seealso>
    let networkInterfaceRoutingPriorityMetric =
        Prefixed_Name(noria, "networkInterfaceRoutingPriorityMetric") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the Network Interface.</para>
    /// labels<para>networkInterfaceType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceType">https://w3id.org/noria/ontology/networkInterfaceType</seealso>
    let networkInterfaceType =
        Prefixed_Name(noria, "networkInterfaceType") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkLinkId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The UID of the NetworkLink.</para>
    /// labels<para>networkLinkId</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkLinkId">https://w3id.org/noria/ontology/networkLinkId</seealso>
    let networkLinkId = Prefixed_Name(noria, "networkLinkId") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkLinkInstallationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The installation date of the NetworkLink.</para>
    /// labels<para>networkLinkInstallationDate</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkLinkInstallationDate">https://w3id.org/noria/ontology/networkLinkInstallationDate</seealso>
    let networkLinkInstallationDate =
        Prefixed_Name(noria, "networkLinkInstallationDate") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkLinkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of the type of the Network Link.</para>
    /// labels<para>networkLinkType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkLinkType">https://w3id.org/noria/ontology/networkLinkType</seealso>
    let networkLinkType = Prefixed_Name(noria, "networkLinkType") |> PrefixedName

    /// <summary>
    ///   <para>noria:operationPlanPostCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ActionPostCondition to check/that would be observed whenever the OperationPlan is carried out.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the output, hence `operationPlanPostCondition` is a kind of `pep:hasOutput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPostCondition` is the description of what should be observed to after the realization of a given Task, hence it is a kind of `BBO:has_completionCondition`.
    /// </para>
    /// labels<para>operationPlanPostCondition</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/operationPlanPostCondition">https://w3id.org/noria/ontology/operationPlanPostCondition</seealso>
    let operationPlanPostCondition =
        Prefixed_Name(noria, "operationPlanPostCondition") |> PrefixedName

    /// <summary>
    ///   <para>noria:operationPlanPreCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ActionPreCondition to check/that would be checked whenever the OperationPlan will be executed/is executed.
    ///
    /// Alignment:
    /// - *PEP*: OperationPlan (Procedures) may be linked to some description of the input, hence `operationPlanPreCondition` is a kind of `pep:hasInput`.
    /// - *BBO*: From the BPMN perspective, the `operationPlanPreCondition` is the description of what may activate the realization of a given Task, hence it is a kind of `BBO:has_activationCondition`.
    /// </para>
    /// labels<para>operationPlanPreCondition</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/operationPlanPreCondition">https://w3id.org/noria/ontology/operationPlanPreCondition</seealso>
    let operationPlanPreCondition =
        Prefixed_Name(noria, "operationPlanPreCondition") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The *initial* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.</para>
    /// labels<para>troubleTicketCategory</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketCategory">https://w3id.org/noria/ontology/troubleTicketCategory</seealso>
    let troubleTicketCategory =
        Prefixed_Name(noria, "troubleTicketCategory") |> PrefixedName

    /// <summary>
    ///   <para>noria:problemResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The *final* area of responsibility identified for the incident.</para>
    /// labels<para>problemResponsibility</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/problemResponsibility">https://w3id.org/noria/ontology/problemResponsibility</seealso>
    let problemResponsibility =
        Prefixed_Name(noria, "problemResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>noria:productManufacturedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Manufacturer of the Product Model.</para>
    /// labels<para>productManufacturedBy</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/productManufacturedBy">https://w3id.org/noria/ontology/productManufacturedBy</seealso>
    let productManufacturedBy =
        Prefixed_Name(noria, "productManufacturedBy") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceForApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Application this Resource is contributing to, whatever the Application type.</para>
    /// labels<para>resourceForApplication</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceForApplication">https://w3id.org/noria/ontology/resourceForApplication</seealso>
    let resourceForApplication =
        Prefixed_Name(noria, "resourceForApplication") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceHostName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The hostname (nodename) of the Resource.</para>
    /// labels<para>resourceHostName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceHostName">https://w3id.org/noria/ontology/resourceHostName</seealso>
    let resourceHostName = Prefixed_Name(noria, "resourceHostName") |> PrefixedName

    /// <summary>
    ///   <para>noria:structuralElementDistinguishedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Distinguished Name of the Structural Element Instance (i.e. unique identifier).</para>
    /// labels<para>structuralElementDistinguishedName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/structuralElementDistinguishedName">https://w3id.org/noria/ontology/structuralElementDistinguishedName</seealso>
    let structuralElementDistinguishedName =
        Prefixed_Name(noria, "structuralElementDistinguishedName") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceInstallationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The installation date of the Resource.</para>
    /// labels<para>resourceInstallationDate</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceInstallationDate">https://w3id.org/noria/ontology/resourceInstallationDate</seealso>
    let resourceInstallationDate =
        Prefixed_Name(noria, "resourceInstallationDate") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceLogisticId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The logistic UID of the Resource (a.k.a. asset tag).</para>
    /// labels<para>resourceLogisticId</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceLogisticId">https://w3id.org/noria/ontology/resourceLogisticId</seealso>
    let resourceLogisticId = Prefixed_Name(noria, "resourceLogisticId") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceManagementIPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the IP address for remote management of the Resource, if relevant.</para>
    /// labels<para>resourceManagementIPAddress</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceManagementIPAddress">https://w3id.org/noria/ontology/resourceManagementIPAddress</seealso>
    let resourceManagementIPAddress =
        Prefixed_Name(noria, "resourceManagementIPAddress") |> PrefixedName

    /// <summary>
    ///   <para>noria:ObservableOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ObservableOntology-0.2">https://w3id.org/noria/ontology/ObservableOntology-0.2</seealso>
    let ``ObservableOntology_0.2`` =
        Prefixed_Name(noria, "ObservableOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:ActionPostCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of Post Conditions or Potential outcomes that the execution of some OperationPlan may satisfy/lead to/confirm/solve.
    ///
    /// From the *ChangeRequest* perspective this enables to declare what to observe in order to confirm that the Procedure reached its goal; from the *TroubleTicket* perspective this enables to capitalize on expectations and outcomes for a given Procedure.</para>
    /// labels<para>ActionPostCondition</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ActionPostCondition">https://w3id.org/noria/ontology/ActionPostCondition</seealso>
    let ActionPostCondition =
        Prefixed_Name(noria, "ActionPostCondition") |> PrefixedName

    /// <summary>
    ///   <para>noria:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract system based on data processing and presentation.</para>
    /// labels<para>Application</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Application">https://w3id.org/noria/ontology/Application</seealso>
    let Application = Prefixed_Name(noria, "Application") |> PrefixedName
    /// <summary>
    ///   <para>noria:ApplicationModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific and managed instance of an Application.</para>
    /// labels<para>ApplicationModule</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ApplicationModule">https://w3id.org/noria/ontology/ApplicationModule</seealso>
    let ApplicationModule = Prefixed_Name(noria, "ApplicationModule") |> PrefixedName
    /// <summary>
    ///   <para>noria:TroubleTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A trouble ticket represents a record used for reporting and managing the resolution of resource problems. Main trouble ticket attributes are its description, severity, type, priority, related dates (created, target resolution, resolution, etc.), state and related information (change reason, change date), related parties (originator, owner, pilot), notes, trouble causes and impacts.
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
    /// labels<para>TroubleTicket</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/TroubleTicket">https://w3id.org/noria/ontology/TroubleTicket</seealso>
    let TroubleTicket = Prefixed_Name(noria, "TroubleTicket") |> PrefixedName
    /// <summary>
    ///   <para>noria:CoreOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/CoreOntology">https://w3id.org/noria/ontology/CoreOntology</seealso>
    let CoreOntology = Prefixed_Name(noria, "CoreOntology") |> PrefixedName
    /// <summary>
    ///   <para>noria:DocumentAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A file attachment.
    ///
    /// Alignment:
    /// - *DCMI*: from the DCMI Abstract Model perspective, a DocumentAttachment is a described resource, hence DC terms apply:
    ///   - troubleTicketAttachmentForTicket &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    ///   - changeRequestAttachment &lt;=&gt; http://purl.org/dc/terms/isPartOf : The TroubleTicket this file is part of.
    /// - *BBO*: a DocumentAttachment is a DocumentResource in the sense that it is the result of the Incident Management Process (IMP) or Change Management Process (CMP) and can be used as an input for another activity. From the BPMN 2.0 perspective, a DocumentAttachment is a DataObject.
    ///     </para>
    /// labels<para>DocumentAttachment</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/DocumentAttachment">https://w3id.org/noria/ontology/DocumentAttachment</seealso>
    let DocumentAttachment = Prefixed_Name(noria, "DocumentAttachment") |> PrefixedName

    /// <summary>
    ///   <para>noria:StructuralObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract class for ICT systems's properties that should be defined as classes for extended description capability.</para>
    /// labels<para>StructuralObservable</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/StructuralObservable">https://w3id.org/noria/ontology/StructuralObservable</seealso>
    let StructuralObservable =
        Prefixed_Name(noria, "StructuralObservable") |> PrefixedName

    /// <summary>
    ///   <para>noria:TroubleTicketNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A trouble ticket note represents a record used for reporting and information sharing during the incident management process for a given Trouble Ticket.
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
    /// labels<para>TroubleTicketNote</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/TroubleTicketNote">https://w3id.org/noria/ontology/TroubleTicketNote</seealso>
    let TroubleTicketNote = Prefixed_Name(noria, "TroubleTicketNote") |> PrefixedName

    /// <summary>
    ///   <para>noria:CorrectiveMaintenanceAction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/CorrectiveMaintenanceAction">https://w3id.org/noria/ontology/CorrectiveMaintenanceAction</seealso>
    let CorrectiveMaintenanceAction =
        Prefixed_Name(noria, "CorrectiveMaintenanceAction") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Nature of the Change Request</para>
    /// labels<para>changeRequestCategory</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestCategory">https://w3id.org/noria/ontology/changeRequestCategory</seealso>
    let changeRequestCategory =
        Prefixed_Name(noria, "changeRequestCategory") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The serial number of the Resource.</para>
    /// labels<para>resourceSerialNumber</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceSerialNumber">https://w3id.org/noria/ontology/resourceSerialNumber</seealso>
    let resourceSerialNumber =
        Prefixed_Name(noria, "resourceSerialNumber") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the Network Element Resource.</para>
    /// labels<para>resourceType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceType">https://w3id.org/noria/ontology/resourceType</seealso>
    let resourceType = Prefixed_Name(noria, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>noria:resourceUsageState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The production state of the Resource.</para>
    /// labels<para>resourceUsageState</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceUsageState">https://w3id.org/noria/ontology/resourceUsageState</seealso>
    let resourceUsageState = Prefixed_Name(noria, "resourceUsageState") |> PrefixedName
    /// <summary>
    ///   <para>noria:siteId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique identifier of a Site.</para>
    /// labels<para>siteId</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/siteId">https://w3id.org/noria/ontology/siteId</seealso>
    let siteId = Prefixed_Name(noria, "siteId") |> PrefixedName

    /// <summary>
    ///   <para>noria:sitePrincipalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Street address of a Site.</para>
    /// labels<para>sitePrincipalAddress</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/sitePrincipalAddress">https://w3id.org/noria/ontology/sitePrincipalAddress</seealso>
    let sitePrincipalAddress =
        Prefixed_Name(noria, "sitePrincipalAddress") |> PrefixedName

    /// <summary>
    ///   <para>noria:sitePrincipalAddressCityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>City Name for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: a `P` class `gn:Feature` (city, village, etc.) may correspond to this property.</para>
    /// labels<para>sitePrincipalAddressCityName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/sitePrincipalAddressCityName">https://w3id.org/noria/ontology/sitePrincipalAddressCityName</seealso>
    let sitePrincipalAddressCityName =
        Prefixed_Name(noria, "sitePrincipalAddressCityName") |> PrefixedName

    /// <summary>
    ///   <para>noria:sitePrincipalAddressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Country name or code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*:
    ///   - a `A` class `gn:Feature` (country, state, region, etc.) may correspond to this property.
    ///   - prefer ISO 3166 values for easier matching with `gn:countryCode`.
    /// </para>
    /// labels<para>sitePrincipalAddressCountry</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/sitePrincipalAddressCountry">https://w3id.org/noria/ontology/sitePrincipalAddressCountry</seealso>
    let sitePrincipalAddressCountry =
        Prefixed_Name(noria, "sitePrincipalAddressCountry") |> PrefixedName

    /// <summary>
    ///   <para>noria:ProceduralObject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ProceduralObject">https://w3id.org/noria/ontology/ProceduralObject</seealso>
    let ProceduralObject = Prefixed_Name(noria, "ProceduralObject") |> PrefixedName

    /// <summary>
    ///   <para>noria:actionCorrelatedOperationPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Operation Plan (procedure) guiding the execution of the given Action.</para>
    /// labels<para>actionCorrelatedOperationPlan</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/actionCorrelatedOperationPlan">https://w3id.org/noria/ontology/actionCorrelatedOperationPlan</seealso>
    let actionCorrelatedOperationPlan =
        Prefixed_Name(noria, "actionCorrelatedOperationPlan") |> PrefixedName

    /// <summary>
    ///   <para>noria:ChangeAction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ChangeAction">https://w3id.org/noria/ontology/ChangeAction</seealso>
    let ChangeAction = Prefixed_Name(noria, "ChangeAction") |> PrefixedName
    /// <summary>
    ///   <para>noria:agentInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Instructions for involving the Agent (Team, Group, Employee).</para>
    /// labels<para>agentInstructions</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/agentInstructions">https://w3id.org/noria/ontology/agentInstructions</seealso>
    let agentInstructions = Prefixed_Name(noria, "agentInstructions") |> PrefixedName

    /// <summary>
    ///   <para>noria:agentManagesResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Network Element (IT Resource) the Agent is responsible of (supervises).
    ///
    /// Alignment:
    /// - *FOAF*: A team may be interested into following the state of some resources, hence this property is semantically akin to `foaf:topic_interest`.
    /// </para>
    /// labels<para>agentManagesResource</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/agentManagesResource">https://w3id.org/noria/ontology/agentManagesResource</seealso>
    let agentManagesResource =
        Prefixed_Name(noria, "agentManagesResource") |> PrefixedName

    /// <summary>
    ///   <para>noria:agentPreferredContactMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The preferred contact method to reach the Agent (Team, Group, Employee).</para>
    /// labels<para>agentPreferredContactMethod</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/agentPreferredContactMethod">https://w3id.org/noria/ontology/agentPreferredContactMethod</seealso>
    let agentPreferredContactMethod =
        Prefixed_Name(noria, "agentPreferredContactMethod") |> PrefixedName

    /// <summary>
    ///   <para>noria:alarmMitigatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ProcedureExecutionContainer (i.e. the set of Procedure Execution(s)) that led to clear the alarm and/or solve the issue.
    ///
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.</para>
    /// labels<para>alarmMitigatedBy</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/alarmMitigatedBy">https://w3id.org/noria/ontology/alarmMitigatedBy</seealso>
    let alarmMitigatedBy = Prefixed_Name(noria, "alarmMitigatedBy") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestPlannedStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.</para>
    /// labels<para>changeRequestPlannedStartTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestPlannedStartTime">https://w3id.org/noria/ontology/changeRequestPlannedStartTime</seealso>
    let changeRequestPlannedStartTime =
        Prefixed_Name(noria, "changeRequestPlannedStartTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An item of the standard operation plan catalog for recurring activities.</para>
    /// labels<para>changeRequestSpecification</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestSpecification">https://w3id.org/noria/ontology/changeRequestSpecification</seealso>
    let changeRequestSpecification =
        Prefixed_Name(noria, "changeRequestSpecification") |> PrefixedName

    /// <summary>
    ///   <para>noria:serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the Service.</para>
    /// labels<para>serviceType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/serviceType">https://w3id.org/noria/ontology/serviceType</seealso>
    let serviceType = Prefixed_Name(noria, "serviceType") |> PrefixedName

    /// <summary>
    ///   <para>noria:DocumentOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/DocumentOntology-0.2">https://w3id.org/noria/ontology/DocumentOntology-0.2</seealso>
    let ``DocumentOntology_0.2`` =
        Prefixed_Name(noria, "DocumentOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:DocumentOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/DocumentOntology">https://w3id.org/noria/ontology/DocumentOntology</seealso>
    let DocumentOntology = Prefixed_Name(noria, "DocumentOntology") |> PrefixedName
    /// <summary>
    ///   <para>noria:AnomalyPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract class for grouping observables and events that, when satisfied by the existence of some instance/value, represents the occurrence of a (complex) fault/failure mode.</para>
    /// labels<para>AnomalyPattern</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/AnomalyPattern">https://w3id.org/noria/ontology/AnomalyPattern</seealso>
    let AnomalyPattern = Prefixed_Name(noria, "AnomalyPattern") |> PrefixedName

    /// <summary>
    ///   <para>noria:ApplicationOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ApplicationOntology">https://w3id.org/noria/ontology/ApplicationOntology</seealso>
    let ApplicationOntology =
        Prefixed_Name(noria, "ApplicationOntology") |> PrefixedName

    /// <summary>
    ///   <para>noria:ChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Change Request represents a record used for reporting and managing change activities on services and resources. It is a key artefact to the Change Management process. Change Management process is to respond to the customer’s changing business requirements while maximizing value and reducing incidents, disruption and network.
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
    /// labels<para>ChangeRequest</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ChangeRequest">https://w3id.org/noria/ontology/ChangeRequest</seealso>
    let ChangeRequest = Prefixed_Name(noria, "ChangeRequest") |> PrefixedName
    /// <summary>
    ///   <para>noria:DynamicElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for time-related entities and their potential chaining (a.k.a. *Dynamic facet*).</para>
    /// labels<para>DynamicElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/DynamicElement">https://w3id.org/noria/ontology/DynamicElement</seealso>
    let DynamicElement = Prefixed_Name(noria, "DynamicElement") |> PrefixedName
    /// <summary>
    ///   <para>noria:ProductModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Product Model of some Resource as per the Manufacturer's naming.</para>
    /// labels<para>ProductModel</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ProductModel">https://w3id.org/noria/ontology/ProductModel</seealso>
    let ProductModel = Prefixed_Name(noria, "ProductModel") |> PrefixedName
    /// <summary>
    ///   <para>noria:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract representation of qualifiable, quantifiable, observable or operable qualities of some Element.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Property">https://w3id.org/noria/ontology/Property</seealso>
    let Property = Prefixed_Name(noria, "Property") |> PrefixedName

    /// <summary>
    ///   <para>noria:elementDistinguishedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Distinguished Name of the Element Instance (i.e. unique identifier).</para>
    /// labels<para>elementDistinguishedName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/elementDistinguishedName">https://w3id.org/noria/ontology/elementDistinguishedName</seealso>
    let elementDistinguishedName =
        Prefixed_Name(noria, "elementDistinguishedName") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkInterfaceLaserRxOpticalPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The received optical power measure of the Network Interface, in dBm.</para>
    /// labels<para>networkInterfaceLaserRxOpticalPower</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPower">https://w3id.org/noria/ontology/networkInterfaceLaserRxOpticalPower</seealso>
    let networkInterfaceLaserRxOpticalPower =
        Prefixed_Name(noria, "networkInterfaceLaserRxOpticalPower") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketFreezeItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ticket freeze period history.</para>
    /// labels<para>troubleTicketFreezeItem</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketFreezeItem">https://w3id.org/noria/ontology/troubleTicketFreezeItem</seealso>
    let troubleTicketFreezeItem =
        Prefixed_Name(noria, "troubleTicketFreezeItem") |> PrefixedName

    /// <summary>
    ///   <para>noria:problemCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The *final* nature (for product ticket class) or technical impact (for resource ticket class) of the incident category of any Trouble Ticket or Incident Ticket.</para>
    /// labels<para>problemCategory</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/problemCategory">https://w3id.org/noria/ontology/problemCategory</seealso>
    let problemCategory = Prefixed_Name(noria, "problemCategory") |> PrefixedName
    /// <summary>
    ///   <para>noria:troubleTicketCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The cause(s) defined for the trouble, in plain text.</para>
    /// labels<para>troubleTicketCause</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketCause">https://w3id.org/noria/ontology/troubleTicketCause</seealso>
    let troubleTicketCause = Prefixed_Name(noria, "troubleTicketCause") |> PrefixedName
    /// <summary>
    ///   <para>noria:NetworkLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical or logical Link between Resources.
    ///
    /// Usage notes:
    /// - The organizational unit in charge of the Network Link (i.e. the Support team or Owner of the Network Link) can be set with the `noria:resourceManagedBy` property.
    /// </para>
    /// labels<para>NetworkLink</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/NetworkLink">https://w3id.org/noria/ontology/NetworkLink</seealso>
    let NetworkLink = Prefixed_Name(noria, "NetworkLink") |> PrefixedName

    /// <summary>
    ///   <para>noria:eventRelatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The structural or functional element instance some event or time-dependant entity is related with.</para>
    /// labels<para>eventRelatedElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/eventRelatedElement">https://w3id.org/noria/ontology/eventRelatedElement</seealso>
    let eventRelatedElement =
        Prefixed_Name(noria, "eventRelatedElement") |> PrefixedName

    /// <summary>
    ///   <para>noria:logText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Textual information describing the logged event.</para>
    /// labels<para>logText</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/logText">https://w3id.org/noria/ontology/logText</seealso>
    let logText = Prefixed_Name(noria, "logText") |> PrefixedName

    /// <summary>
    ///   <para>noria:networkLinkTerminationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link termination Resource, the Resource at some end fo the Network Link.</para>
    /// labels<para>networkLinkTerminationResource</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/networkLinkTerminationResource">https://w3id.org/noria/ontology/networkLinkTerminationResource</seealso>
    let networkLinkTerminationResource =
        Prefixed_Name(noria, "networkLinkTerminationResource") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketPlannedRestorationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Confirmed to customer planned restoration date ATR (Actual Time to Restore (ATR)).</para>
    /// labels<para>troubleTicketPlannedRestorationDateTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketPlannedRestorationDateTime">https://w3id.org/noria/ontology/troubleTicketPlannedRestorationDateTime</seealso>
    let troubleTicketPlannedRestorationDateTime =
        Prefixed_Name(noria, "troubleTicketPlannedRestorationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:ProceduralElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for (predeﬁned/computed) operational process (a.k.a. *Procedural facet*).</para>
    /// labels<para>ProceduralElement</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ProceduralElement">https://w3id.org/noria/ontology/ProceduralElement</seealso>
    let ProceduralElement = Prefixed_Name(noria, "ProceduralElement") |> PrefixedName
    /// <summary>
    ///   <para>noria:StructuralProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/StructuralProperty">https://w3id.org/noria/ontology/StructuralProperty</seealso>
    let StructuralProperty = Prefixed_Name(noria, "StructuralProperty") |> PrefixedName
    /// <summary>
    ///   <para>noria:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General resource record of the Communication Device kind from the logistics park. It is a managed entity that can be either Physical or Virtual.
    ///
    /// Alignment:
    /// - *SEAS*: Whenever a Resource individual is an assembly of other resources (e.g. a server rack) or is part of an assembly (e.g. a server blade), the Resource individual can also be declared as a `seas:System` in order to benefit of the `seas:subSystemOf` relation.
    ///   For example, Resources may be grouped in some `noria:Service` class for providing both an end-to-end analysis of the data path (i.e. Communication Devices + Connections) and an abstract object linked to some end user (e.g. Customer).
    /// - *BOT*: A `noria:Resource` is a sub-class of `bot:Element` for setting instances in the context of a physical environment (e.g. in a building).
    /// - *SLOGERT*: A `noria:Resource` is equivalent to a `log:Host`.
    /// - *UCO*: A `noria:Resource` is equivalent to an UCO's observable `Device`.
    /// </para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Resource">https://w3id.org/noria/ontology/Resource</seealso>
    let Resource = Prefixed_Name(noria, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>noria:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of the physical world or a virtual world whose 3D spatial extent is bounded actually or theoretically, and provides for certain functions within the zone it is contained in.
    ///
    /// Alignment:
    /// - *BOT*: A Room is a specialization of a `bot:Space` for common sense understanding.
    /// </para>
    /// labels<para>Room</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Room">https://w3id.org/noria/ontology/Room</seealso>
    let Room = Prefixed_Name(noria, "Room") |> PrefixedName

    /// <summary>
    ///   <para>noria:resourceProductModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The product model of the Resource.</para>
    /// labels<para>resourceProductModel</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceProductModel">https://w3id.org/noria/ontology/resourceProductModel</seealso>
    let resourceProductModel =
        Prefixed_Name(noria, "resourceProductModel") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketPartyIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The history of groups activation and responsibility transfer.</para>
    /// labels<para>troubleTicketPartyIntervention</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketPartyIntervention">https://w3id.org/noria/ontology/troubleTicketPartyIntervention</seealso>
    let troubleTicketPartyIntervention =
        Prefixed_Name(noria, "troubleTicketPartyIntervention") |> PrefixedName

    /// <summary>
    ///   <para>noria:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service is an abstract base class for defining the Service hierarchy, i.e. the composition of assets (a.k.a. asset chain, service function chain) for providing a end-to-end data path or processing for some specific Customer or purpose.
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
    /// labels<para>Service</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/Service">https://w3id.org/noria/ontology/Service</seealso>
    let Service = Prefixed_Name(noria, "Service") |> PrefixedName
    /// <summary>
    ///   <para>noria:CoreOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/CoreOntology-0.2">https://w3id.org/noria/ontology/CoreOntology-0.2</seealso>
    let ``CoreOntology_0.2`` = Prefixed_Name(noria, "CoreOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:ApplicationOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/ApplicationOntology-0.2">https://w3id.org/noria/ontology/ApplicationOntology-0.2</seealso>
    let ``ApplicationOntology_0.2`` =
        Prefixed_Name(noria, "ApplicationOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:LocationOntology-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/LocationOntology-0.2">https://w3id.org/noria/ontology/LocationOntology-0.2</seealso>
    let ``LocationOntology_0.2`` =
        Prefixed_Name(noria, "LocationOntology-0.2") |> PrefixedName

    /// <summary>
    ///   <para>noria:noria-0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/noria-0.2">https://w3id.org/noria/ontology/noria-0.2</seealso>
    let ``noria_0.2`` = Prefixed_Name(noria, "noria-0.2") |> PrefixedName
    /// <summary>
    ///   <para>noria:resourceManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Support team or Owner of the Network Element (IT Resource).</para>
    /// labels<para>resourceManagedBy</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/resourceManagedBy">https://w3id.org/noria/ontology/resourceManagedBy</seealso>
    let resourceManagedBy = Prefixed_Name(noria, "resourceManagedBy") |> PrefixedName
    /// <summary>
    ///   <para>noria:agentWorkingHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Working Hours for reaching the Agent (Team, Employee, etc.).</para>
    /// labels<para>agentWorkingHours</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/agentWorkingHours">https://w3id.org/noria/ontology/agentWorkingHours</seealso>
    let agentWorkingHours = Prefixed_Name(noria, "agentWorkingHours") |> PrefixedName

    /// <summary>
    ///   <para>noria:alarmMonitoredAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Monitored attributes parameter, when present, defines one or more attributes of the managed object and their corresponding values at the time of the alarm.
    /// Managed object definers may specify the set of attributes which are of interest, if any.
    /// This allows, for example, the timely reporting of changing conditions prevalent at the time of the alarm.
    /// </para>
    /// labels<para>alarmMonitoredAttribute</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/alarmMonitoredAttribute">https://w3id.org/noria/ontology/alarmMonitoredAttribute</seealso>
    let alarmMonitoredAttribute =
        Prefixed_Name(noria, "alarmMonitoredAttribute") |> PrefixedName

    /// <summary>
    ///   <para>noria:alarmProposedRepairAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This parameter, when present, is used if the cause is known and the system being managed can suggest one or more solutions.
    /// This parameter is a set of possibilities specified by the object class definer.
    /// </para>
    /// labels<para>alarmProposedRepairAction</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/alarmProposedRepairAction">https://w3id.org/noria/ontology/alarmProposedRepairAction</seealso>
    let alarmProposedRepairAction =
        Prefixed_Name(noria, "alarmProposedRepairAction") |> PrefixedName

    /// <summary>
    ///   <para>noria:alarmSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indication of how it is perceived that the capability of the managed object has been affected, or how serious are the service affecting conditions (including for security alarms).</para>
    /// labels<para>alarmSeverity</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/alarmSeverity">https://w3id.org/noria/ontology/alarmSeverity</seealso>
    let alarmSeverity = Prefixed_Name(noria, "alarmSeverity") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationBusinessImportance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The importance of the Application from the business impact perspective for risk assessment analysis and incident management prioritization.</para>
    /// labels<para>applicationBusinessImportance</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationBusinessImportance">https://w3id.org/noria/ontology/applicationBusinessImportance</seealso>
    let applicationBusinessImportance =
        Prefixed_Name(noria, "applicationBusinessImportance") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationFunctionalDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The functional domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalDomain` is equivalent to the *Domain* concept of the ODA Functional Framework.
    /// </para>
    /// labels<para>applicationFunctionalDomain</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationFunctionalDomain">https://w3id.org/noria/ontology/applicationFunctionalDomain</seealso>
    let applicationFunctionalDomain =
        Prefixed_Name(noria, "applicationFunctionalDomain") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationFunctionalSubDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The functional sub-domain of the Application for describing the organization’s activities from a system point of view.
    ///
    /// Alignment:
    /// - *tmforum*: the `noria:applicationFunctionalSubDomain` is equivalent to *Aggregate Business Entities* (ABEs) and *Business Entities* (BEs) of the ODA Functional Framework.
    /// </para>
    /// labels<para>applicationFunctionalSubDomain</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationFunctionalSubDomain">https://w3id.org/noria/ontology/applicationFunctionalSubDomain</seealso>
    let applicationFunctionalSubDomain =
        Prefixed_Name(noria, "applicationFunctionalSubDomain") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleRelatedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generic property for linking a party playing a role in the management of the Application Module.</para>
    /// labels<para>applicationModuleRelatedParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleRelatedParty">https://w3id.org/noria/ontology/applicationModuleRelatedParty</seealso>
    let applicationModuleRelatedParty =
        Prefixed_Name(noria, "applicationModuleRelatedParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleAdministrationTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité exploitante.</para>
    ///   <para>Administration team.</para>
    /// labels<para>applicationModuleAdministrationTeam</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleAdministrationTeam">https://w3id.org/noria/ontology/applicationModuleAdministrationTeam</seealso>
    let applicationModuleAdministrationTeam =
        Prefixed_Name(noria, "applicationModuleAdministrationTeam") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Application module code.</para>
    /// labels<para>applicationModuleIdentifier</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleIdentifier">https://w3id.org/noria/ontology/applicationModuleIdentifier</seealso>
    let applicationModuleIdentifier =
        Prefixed_Name(noria, "applicationModuleIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the Application module.</para>
    /// labels<para>applicationModuleName</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleName">https://w3id.org/noria/ontology/applicationModuleName</seealso>
    let applicationModuleName =
        Prefixed_Name(noria, "applicationModuleName") |> PrefixedName

    /// <summary>
    ///   <para>noria:elementManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Agent or Owner of the Managed Element.
    ///
    /// Alignment:
    /// - *ORG*: the *elementManagedBy* property can range an `org:Organization` or `org:OrganizationalUnit` entity as the ORG data model defines these class as subClassOf `foaf:Agent` (see [org:Organization](https://www.w3.org/TR/vocab-org/#org:Organization)).
    /// </para>
    /// labels<para>elementManagedBy</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/elementManagedBy">https://w3id.org/noria/ontology/elementManagedBy</seealso>
    let elementManagedBy = Prefixed_Name(noria, "elementManagedBy") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleSlaLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>SLA level.</para>
    ///   <para>Niveau de service.</para>
    /// labels<para>applicationModuleSlaLevel</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleSlaLevel">https://w3id.org/noria/ontology/applicationModuleSlaLevel</seealso>
    let applicationModuleSlaLevel =
        Prefixed_Name(noria, "applicationModuleSlaLevel") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Status of the Application Module.</para>
    ///   <para>Etat de service du Module Applicatif.</para>
    /// labels<para>applicationModuleStatus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleStatus">https://w3id.org/noria/ontology/applicationModuleStatus</seealso>
    let applicationModuleStatus =
        Prefixed_Name(noria, "applicationModuleStatus") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleSupportLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Responsable de l'entité support.</para>
    ///   <para>Support leader.</para>
    /// labels<para>applicationModuleSupportLeader</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleSupportLeader">https://w3id.org/noria/ontology/applicationModuleSupportLeader</seealso>
    let applicationModuleSupportLeader =
        Prefixed_Name(noria, "applicationModuleSupportLeader") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationModuleSupportTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité support : Soutien Applicatif Technique (SAT) - Exploitant N2.</para>
    ///   <para>Level 2 Support Team.</para>
    /// labels<para>applicationModuleSupportTeam</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationModuleSupportTeam">https://w3id.org/noria/ontology/applicationModuleSupportTeam</seealso>
    let applicationModuleSupportTeam =
        Prefixed_Name(noria, "applicationModuleSupportTeam") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationNumericalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Application numerical identifier, the numerical identifier of the Application within the Information System.</para>
    /// labels<para>applicationNumericalIdentifier</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationNumericalIdentifier">https://w3id.org/noria/ontology/applicationNumericalIdentifier</seealso>
    let applicationNumericalIdentifier =
        Prefixed_Name(noria, "applicationNumericalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationShortIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Application short identifier, a short string identifier of Application within the Information System.</para>
    /// labels<para>applicationShortIdentifier</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationShortIdentifier">https://w3id.org/noria/ontology/applicationShortIdentifier</seealso>
    let applicationShortIdentifier =
        Prefixed_Name(noria, "applicationShortIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>noria:applicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the Application.</para>
    /// labels<para>applicationType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/applicationType">https://w3id.org/noria/ontology/applicationType</seealso>
    let applicationType = Prefixed_Name(noria, "applicationType") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestActorParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The actor of the Change Request.</para>
    /// labels<para>changeRequestActorParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestActorParty">https://w3id.org/noria/ontology/changeRequestActorParty</seealso>
    let changeRequestActorParty =
        Prefixed_Name(noria, "changeRequestActorParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestRelatedParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestRelatedParty">https://w3id.org/noria/ontology/changeRequestRelatedParty</seealso>
    let changeRequestRelatedParty =
        Prefixed_Name(noria, "changeRequestRelatedParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestActualEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time on which the Change Request implementation has been completed. It is displayed only after the Change Request implementation has been completed actually.</para>
    /// labels<para>changeRequestActualEndTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestActualEndTime">https://w3id.org/noria/ontology/changeRequestActualEndTime</seealso>
    let changeRequestActualEndTime =
        Prefixed_Name(noria, "changeRequestActualEndTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestActualStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time on which the Change Request implementation has started. It is displayed only after the Change Request implementation has started actually.</para>
    /// labels<para>changeRequestActualStartTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestActualStartTime">https://w3id.org/noria/ontology/changeRequestActualStartTime</seealso>
    let changeRequestActualStartTime =
        Prefixed_Name(noria, "changeRequestActualStartTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestChangeCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Cause of (reason for) the Change Request.</para>
    /// labels<para>changeRequestChangeCause</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestChangeCause">https://w3id.org/noria/ontology/changeRequestChangeCause</seealso>
    let changeRequestChangeCause =
        Prefixed_Name(noria, "changeRequestChangeCause") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Set of physical/logical entities on which the Change Request is carried-out.</para>
    /// labels<para>changeRequestImpact</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestImpact">https://w3id.org/noria/ontology/changeRequestImpact</seealso>
    let changeRequestImpact =
        Prefixed_Name(noria, "changeRequestImpact") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestInitiatorParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The agent initiating the Change Request.</para>
    /// labels<para>changeRequestInitiatorParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestInitiatorParty">https://w3id.org/noria/ontology/changeRequestInitiatorParty</seealso>
    let changeRequestInitiatorParty =
        Prefixed_Name(noria, "changeRequestInitiatorParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestIsRegulated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>If *true*, the Change Request is subject to special regulations.</para>
    /// labels<para>changeRequestIsRegulated</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestIsRegulated">https://w3id.org/noria/ontology/changeRequestIsRegulated</seealso>
    let changeRequestIsRegulated =
        Prefixed_Name(noria, "changeRequestIsRegulated") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestOutageDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expected duration of the outage, if any involved by the Change Request type.</para>
    /// labels<para>changeRequestOutageDuration</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestOutageDuration">https://w3id.org/noria/ontology/changeRequestOutageDuration</seealso>
    let changeRequestOutageDuration =
        Prefixed_Name(noria, "changeRequestOutageDuration") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestPilotParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The pilot of the Change Request.</para>
    /// labels<para>changeRequestPilotParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestPilotParty">https://w3id.org/noria/ontology/changeRequestPilotParty</seealso>
    let changeRequestPilotParty =
        Prefixed_Name(noria, "changeRequestPilotParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestPlannedEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time on which is planned the end of the implementation of the Change Request. It is displayed only before the Change Request implementation is completed.</para>
    /// labels<para>changeRequestPlannedEndTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestPlannedEndTime">https://w3id.org/noria/ontology/changeRequestPlannedEndTime</seealso>
    let changeRequestPlannedEndTime =
        Prefixed_Name(noria, "changeRequestPlannedEndTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestStatusCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The current status of the Change Request.</para>
    /// labels<para>changeRequestStatusCurrent</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestStatusCurrent">https://w3id.org/noria/ontology/changeRequestStatusCurrent</seealso>
    let changeRequestStatusCurrent =
        Prefixed_Name(noria, "changeRequestStatusCurrent") |> PrefixedName

    /// <summary>
    ///   <para>noria:changeRequestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the request describes the a priori impact and risk level of the Change Request.</para>
    /// labels<para>changeRequestType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/changeRequestType">https://w3id.org/noria/ontology/changeRequestType</seealso>
    let changeRequestType = Prefixed_Name(noria, "changeRequestType") |> PrefixedName
    /// <summary>
    ///   <para>noria:clusterController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Resource that is part of a cluster with the cluster controller.</para>
    /// labels<para>clusterController</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/clusterController">https://w3id.org/noria/ontology/clusterController</seealso>
    let clusterController = Prefixed_Name(noria, "clusterController") |> PrefixedName
    /// <summary>
    ///   <para>noria:documentExternalId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ID given by the requestor to facilitate the relationship set up and searches afterwards.</para>
    /// labels<para>documentExternalId</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/documentExternalId">https://w3id.org/noria/ontology/documentExternalId</seealso>
    let documentExternalId = Prefixed_Name(noria, "documentExternalId") |> PrefixedName
    /// <summary>
    ///   <para>noria:documentHRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Hyperlink to the TroubleTicket or ChangeRequest entity in the originating information system.</para>
    /// labels<para>documentHRef</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/documentHRef">https://w3id.org/noria/ontology/documentHRef</seealso>
    let documentHRef = Prefixed_Name(noria, "documentHRef") |> PrefixedName

    /// <summary>
    ///   <para>noria:documentStatusHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The status change history of the document as recorded by the system's logging feature.</para>
    /// labels<para>documentStatusHistory</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/documentStatusHistory">https://w3id.org/noria/ontology/documentStatusHistory</seealso>
    let documentStatusHistory =
        Prefixed_Name(noria, "documentStatusHistory") |> PrefixedName

    /// <summary>
    ///   <para>noria:elementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An abstract representation of a relationship between some Element instance and some Property instance.</para>
    /// labels<para>elementProperty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/elementProperty">https://w3id.org/noria/ontology/elementProperty</seealso>
    let elementProperty = Prefixed_Name(noria, "elementProperty") |> PrefixedName
    /// <summary>
    ///   <para>noria:eventRelatedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Party playing a role (stakeholders) in the life cycle of a given event instance or time-dependant entity.</para>
    /// labels<para>eventRelatedParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/eventRelatedParty">https://w3id.org/noria/ontology/eventRelatedParty</seealso>
    let eventRelatedParty = Prefixed_Name(noria, "eventRelatedParty") |> PrefixedName
    /// <summary>
    ///   <para>noria:locatedAtLocus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A uniquely identified space of the Resource within a given Room.
    ///
    /// Alignment:
    /// - *UCO*: This property enables linking a concrete `Resource` instance to some location, hence it relates to `observable:location`.
    /// - *BOT*: This property is akin to the inverse of `bot:hasElement`.
    /// </para>
    /// labels<para>locatedAtLocus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/locatedAtLocus">https://w3id.org/noria/ontology/locatedAtLocus</seealso>
    let locatedAtLocus = Prefixed_Name(noria, "locatedAtLocus") |> PrefixedName

    /// <summary>
    ///   <para>noria:sitePrincipalAddressPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Postal Code for a Site.
    ///
    /// Alignment:
    /// - *GeoNames*: *ADM2*, *ADM3* or *ADM4* annotations may correspond to this property, depending on the considered country.</para>
    /// labels<para>sitePrincipalAddressPostalCode</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/sitePrincipalAddressPostalCode">https://w3id.org/noria/ontology/sitePrincipalAddressPostalCode</seealso>
    let sitePrincipalAddressPostalCode =
        Prefixed_Name(noria, "sitePrincipalAddressPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>noria:sitePrincipalAddressStreet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Street for a Site.</para>
    /// labels<para>sitePrincipalAddressStreet</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/sitePrincipalAddressStreet">https://w3id.org/noria/ontology/sitePrincipalAddressStreet</seealso>
    let sitePrincipalAddressStreet =
        Prefixed_Name(noria, "sitePrincipalAddressStreet") |> PrefixedName

    /// <summary>
    ///   <para>noria:siteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of a Site.</para>
    /// labels<para>siteType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/siteType">https://w3id.org/noria/ontology/siteType</seealso>
    let siteType = Prefixed_Name(noria, "siteType") |> PrefixedName

    /// <summary>
    ///   <para>noria:structuralObservableOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates some `StructuralObservable` instance to some `StructuralElement` instance.</para>
    /// labels<para>structuralObservableOf</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/structuralObservableOf">https://w3id.org/noria/ontology/structuralObservableOf</seealso>
    let structuralObservableOf =
        Prefixed_Name(noria, "structuralObservableOf") |> PrefixedName

    /// <summary>
    ///   <para>noria:structuralElementProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/structuralElementProperty">https://w3id.org/noria/ontology/structuralElementProperty</seealso>
    let structuralElementProperty =
        Prefixed_Name(noria, "structuralElementProperty") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of Characteristics of the ticket (TroubleTicketCharacteristic [*]). The Trouble ticket specific characteristics</para>
    /// labels<para>troubleTicketCharacteristic</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketCharacteristic">https://w3id.org/noria/ontology/troubleTicketCharacteristic</seealso>
    let troubleTicketCharacteristic =
        Prefixed_Name(noria, "troubleTicketCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketCommittedRestorationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Customer Commitment Deadline Date (calculated on product information).</para>
    /// labels<para>troubleTicketCommittedRestorationDateTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketCommittedRestorationDateTime">https://w3id.org/noria/ontology/troubleTicketCommittedRestorationDateTime</seealso>
    let troubleTicketCommittedRestorationDateTime =
        Prefixed_Name(noria, "troubleTicketCommittedRestorationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketCriticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ticket criticity from the customer impact perspective.</para>
    /// labels<para>troubleTicketCriticity</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketCriticity">https://w3id.org/noria/ontology/troubleTicketCriticity</seealso>
    let troubleTicketCriticity =
        Prefixed_Name(noria, "troubleTicketCriticity") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketDetectionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which the trouble was discovered.</para>
    /// labels<para>troubleTicketDetectionDateTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketDetectionDateTime">https://w3id.org/noria/ontology/troubleTicketDetectionDateTime</seealso>
    let troubleTicketDetectionDateTime =
        Prefixed_Name(noria, "troubleTicketDetectionDateTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketImpacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of resources or services (applications) impacted by the trouble.</para>
    /// labels<para>troubleTicketImpacts</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketImpacts">https://w3id.org/noria/ontology/troubleTicketImpacts</seealso>
    let troubleTicketImpacts =
        Prefixed_Name(noria, "troubleTicketImpacts") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketRelatedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The *Application* or *Service* entity on which trouble ticket has been created.</para>
    /// labels<para>troubleTicketRelatedService</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketRelatedService">https://w3id.org/noria/ontology/troubleTicketRelatedService</seealso>
    let troubleTicketRelatedService =
        Prefixed_Name(noria, "troubleTicketRelatedService") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketRelatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Resource entity on which the trouble ticket has been created.</para>
    /// labels<para>troubleTicketRelatedResource</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketRelatedResource">https://w3id.org/noria/ontology/troubleTicketRelatedResource</seealso>
    let troubleTicketRelatedResource =
        Prefixed_Name(noria, "troubleTicketRelatedResource") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketIsNotificationEnable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The *enable* or *disable* external notification on trouble ticket events.</para>
    /// labels<para>troubleTicketIsNotificationEnable</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketIsNotificationEnable">https://w3id.org/noria/ontology/troubleTicketIsNotificationEnable</seealso>
    let troubleTicketIsNotificationEnable =
        Prefixed_Name(noria, "troubleTicketIsNotificationEnable") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketNoteCommentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The comment provenance type and/or disclosure rules family.</para>
    /// labels<para>troubleTicketNoteCommentType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketNoteCommentType">https://w3id.org/noria/ontology/troubleTicketNoteCommentType</seealso>
    let troubleTicketNoteCommentType =
        Prefixed_Name(noria, "troubleTicketNoteCommentType") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketNoteCorrelatedExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The correlated *ProcedureExecutionContainer* corresponding to the corrective maintenance actions depicted in the Trouble Ticket Note (i.e. the set of `EventRecord` about interactions with the system and as notified by the system).
    ///
    /// From a practical perspective, relating a `noria:TroubleTicketNote` to a `pep:ProcedureExecutionContainer` is akin to show off the materialization of a corrective maintenance action from the technical perspective.
    /// Note that for actions undoubtedly related to a given trouble ticket note (i.e. that can be asserted without mining for execution context candidates), one can avoid using `troubleTicketNoteCorrelatedExecution` by directly relating the note to `EventRecord` with `ldp:member` as `TroubleTicket` and `TroubleTicketNote` are themselves subclasses of `pep:ProcedureExecutionContainer`.
    /// </para>
    /// labels<para>troubleTicketNoteCorrelatedExecution</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketNoteCorrelatedExecution">https://w3id.org/noria/ontology/troubleTicketNoteCorrelatedExecution</seealso>
    let troubleTicketNoteCorrelatedExecution =
        Prefixed_Name(noria, "troubleTicketNoteCorrelatedExecution") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketNoteOperationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The operation type of the note.</para>
    /// labels<para>troubleTicketNoteOperationType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketNoteOperationType">https://w3id.org/noria/ontology/troubleTicketNoteOperationType</seealso>
    let troubleTicketNoteOperationType =
        Prefixed_Name(noria, "troubleTicketNoteOperationType") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person or group family at the origin of the creation of the Trouble Ticket.</para>
    /// labels<para>troubleTicketOrigin</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketOrigin">https://w3id.org/noria/ontology/troubleTicketOrigin</seealso>
    let troubleTicketOrigin =
        Prefixed_Name(noria, "troubleTicketOrigin") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The trouble management priority.</para>
    /// labels<para>troubleTicketPriority</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketPriority">https://w3id.org/noria/ontology/troubleTicketPriority</seealso>
    let troubleTicketPriority =
        Prefixed_Name(noria, "troubleTicketPriority") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketRelatedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The related party(ies) that are associated to the ticket.</para>
    /// labels<para>troubleTicketRelatedParty</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketRelatedParty">https://w3id.org/noria/ontology/troubleTicketRelatedParty</seealso>
    let troubleTicketRelatedParty =
        Prefixed_Name(noria, "troubleTicketRelatedParty") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The criticity of the incident.
    ///
    /// The classification (severity) of the Incident may be defined in accordance with Service Level Agreement (SLA) requirements.
    /// The thresholds of Incident resolution depend on standards defined per service type.
    /// When the thresholds are exceeded, specific process of escalation may be activated.</para>
    /// labels<para>troubleTicketSeverity</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketSeverity">https://w3id.org/noria/ontology/troubleTicketSeverity</seealso>
    let troubleTicketSeverity =
        Prefixed_Name(noria, "troubleTicketSeverity") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketStatusCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The current activity status of the trouble ticket.</para>
    /// labels<para>troubleTicketStatusCurrent</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketStatusCurrent">https://w3id.org/noria/ontology/troubleTicketStatusCurrent</seealso>
    let troubleTicketStatusCurrent =
        Prefixed_Name(noria, "troubleTicketStatusCurrent") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketSupervisionTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Supervision tool which detected the problem.</para>
    /// labels<para>troubleTicketSupervisionTool</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketSupervisionTool">https://w3id.org/noria/ontology/troubleTicketSupervisionTool</seealso>
    let troubleTicketSupervisionTool =
        Prefixed_Name(noria, "troubleTicketSupervisionTool") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketTargetRestorationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Customer initial restoration date Estimated Time to Restore (ETR).</para>
    /// labels<para>troubleTicketTargetRestorationDateTime</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketTargetRestorationDateTime">https://w3id.org/noria/ontology/troubleTicketTargetRestorationDateTime</seealso>
    let troubleTicketTargetRestorationDateTime =
        Prefixed_Name(noria, "troubleTicketTargetRestorationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The EventRecord at the origin of the creation of the Trouble Ticket.</para>
    /// labels<para>troubleTicketTrigger</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketTrigger">https://w3id.org/noria/ontology/troubleTicketTrigger</seealso>
    let troubleTicketTrigger =
        Prefixed_Name(noria, "troubleTicketTrigger") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ticket type.</para>
    /// labels<para>troubleTicketType</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketType">https://w3id.org/noria/ontology/troubleTicketType</seealso>
    let troubleTicketType = Prefixed_Name(noria, "troubleTicketType") |> PrefixedName

    /// <summary>
    ///   <para>noria:troubleTicketUrgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The priority level of the incident.</para>
    /// labels<para>troubleTicketUrgency</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/troubleTicketUrgency">https://w3id.org/noria/ontology/troubleTicketUrgency</seealso>
    let troubleTicketUrgency =
        Prefixed_Name(noria, "troubleTicketUrgency") |> PrefixedName

    /// <summary>
    ///   <para>noria:virtualServerStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The operational status of the Virtual Server.</para>
    /// labels<para>virtualServerStatus</para></remarks>
    /// <seealso href="https://w3id.org/noria/ontology/virtualServerStatus">https://w3id.org/noria/ontology/virtualServerStatus</seealso>
    let virtualServerStatus =
        Prefixed_Name(noria, "virtualServerStatus") |> PrefixedName
