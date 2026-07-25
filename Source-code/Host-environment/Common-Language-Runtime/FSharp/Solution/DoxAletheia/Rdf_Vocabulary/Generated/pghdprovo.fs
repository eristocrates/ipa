namespace https.w3id.org.pghdprovo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pghdprovo =
    let _namespace_iri = Namespace_Iri pghdprovo |> NamespaceIRI
    /// <summary>
    ///   <para>pghdprovo:ContextualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contextual Information provides to extra details that help explain the measurement, like the environment, device settings, or the activity the person was doing when the data was taken.</para>
    /// labels<para>contextual information</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ContextualInfo">https://w3id.org/pghdprovo#ContextualInfo</seealso>
    let ContextualInfo = Prefixed_Name(pghdprovo, "ContextualInfo") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PatientRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Patient relative or friend who helps to collect or transmit data.</para>
    /// labels<para>Patient Relative</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PatientRelative">https://w3id.org/pghdprovo#PatientRelative</seealso>
    let PatientRelative = Prefixed_Name(pghdprovo, "PatientRelative") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PGHD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Patient Generated Health Data (PGHD) a term referring to data that patients (or their caregivers) collect from home or any location outside the clinical environment.</para>
    /// labels<para>PGHD</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHD">https://w3id.org/pghdprovo#PGHD</seealso>
    let PGHD = Prefixed_Name(pghdprovo, "PGHD") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:deviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A name for a device.</para>
    /// labels<para>device name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#deviceName">https://w3id.org/pghdprovo#deviceName</seealso>
    let deviceName = Prefixed_Name(pghdprovo, "deviceName") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:hasContextualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has some contextual information associated to the PGHD</para>
    /// labels<para>Contain Contextual Info</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hasContextualInfo">https://w3id.org/pghdprovo#hasContextualInfo</seealso>
    let hasContextualInfo =
        Prefixed_Name(pghdprovo, "hasContextualInfo") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:Programme1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#Programme</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Programme1">https://w3id.org/pghdprovo#Programme1</seealso>
    let Programme1 = Prefixed_Name(pghdprovo, "Programme1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Protocol1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#Protocol</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Protocol1">https://w3id.org/pghdprovo#Protocol1</seealso>
    let Protocol1 = Prefixed_Name(pghdprovo, "Protocol1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'unit' property specifies the metric or unit of measurement associated with the observed value.</para>
    /// labels<para>unit</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#unit">https://w3id.org/pghdprovo#unit</seealso>
    let unit = Prefixed_Name(pghdprovo, "unit") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Consent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A record of consent for Patient Generated Health Data.</para>
    /// labels<para>Consent</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Consent">https://w3id.org/pghdprovo#Consent</seealso>
    let Consent = Prefixed_Name(pghdprovo, "Consent") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Organisation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Organization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Organisation1">https://w3id.org/pghdprovo#Organisation1</seealso>
    let Organisation1 = Prefixed_Name(pghdprovo, "Organisation1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:orgAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Location of organisation.</para>
    /// labels<para>organization address</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgAddress">https://w3id.org/pghdprovo#orgAddress</seealso>
    let orgAddress = Prefixed_Name(pghdprovo, "orgAddress") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Refers to a health plan or program the person is following, helping to understand the data in relation to their health goals.</para>
    /// labels<para>programme</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Programme">https://w3id.org/pghdprovo#Programme</seealso>
    let Programme = Prefixed_Name(pghdprovo, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>shows the relationship of a caregiver, friend, or relative to a patient.</para>
    /// labels<para>relationship</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#relationship">https://w3id.org/pghdprovo#relationship</seealso>
    let relationship = Prefixed_Name(pghdprovo, "relationship") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PatientRelative1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PatientRelative</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PatientRelative1">https://w3id.org/pghdprovo#PatientRelative1</seealso>
    let PatientRelative1 = Prefixed_Name(pghdprovo, "PatientRelative1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:programmeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The treatment programme associated with the PGHD request.</para>
    /// labels<para>programme name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#programmeName">https://w3id.org/pghdprovo#programmeName</seealso>
    let programmeName = Prefixed_Name(pghdprovo, "programmeName") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:exerciseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>exercise state.</para>
    /// labels<para>exercise state</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#exerciseState">https://w3id.org/pghdprovo#exerciseState</seealso>
    let exerciseState = Prefixed_Name(pghdprovo, "exerciseState") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:posture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The body position of the patient during data collection.</para>
    /// labels<para>posture</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#posture">https://w3id.org/pghdprovo#posture</seealso>
    let posture = Prefixed_Name(pghdprovo, "posture") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the steps or rules followed when collecting the data, such as instructions for using a device or following a specific health procedure.</para>
    /// labels<para>protocol</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Protocol">https://w3id.org/pghdprovo#Protocol</seealso>
    let Protocol = Prefixed_Name(pghdprovo, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:State2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#State</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State2">https://w3id.org/pghdprovo#State2</seealso>
    let State2 = Prefixed_Name(pghdprovo, "State2") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:calibrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the calibration state of the device that produced the patient-generated health data. Preferred value includes calibrated, not-calibrated, calibration-due, unknown, and self-check-performed.</para>
    /// labels<para>calibration status</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#calibrationStatus">https://w3id.org/pghdprovo#calibrationStatus</seealso>
    let calibrationStatus =
        Prefixed_Name(pghdprovo, "calibrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time the consent was issued.</para>
    /// labels<para>Consent Date</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentDate">https://w3id.org/pghdprovo#consentDate</seealso>
    let consentDate = Prefixed_Name(pghdprovo, "consentDate") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The practitioner or provider associated with the consent agreement.</para>
    /// labels<para>Consent Service Provider</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentServiceProvider">https://w3id.org/pghdprovo#consentServiceProvider</seealso>
    let consentServiceProvider =
        Prefixed_Name(pghdprovo, "consentServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentSourceReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A string reference (URL, ID, or description) pointing to the original source of the consent.</para>
    /// labels<para>Consent Source Reference</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentSourceReference">https://w3id.org/pghdprovo#consentSourceReference</seealso>
    let consentSourceReference =
        Prefixed_Name(pghdprovo, "consentSourceReference") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:dataName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'dataName' property indicates the type of measurement or observation being recorded, such as heart rate, blood pressure, step count, or sleep duration.</para>
    /// labels<para>data name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataName">https://w3id.org/pghdprovo#dataName</seealso>
    let dataName = Prefixed_Name(pghdprovo, "dataName") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Includes scores or opinions about the measurement, like how good the data is or a personal rating of a health condition.</para>
    /// labels<para>rating</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Rating">https://w3id.org/pghdprovo#Rating</seealso>
    let Rating = Prefixed_Name(pghdprovo, "Rating") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:dataCoveredByConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates consents that cover this specific PGHD data.</para>
    /// labels<para>Data Covered By Consent</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataCoveredByConsent">https://w3id.org/pghdprovo#dataCoveredByConsent</seealso>
    let dataCoveredByConsent =
        Prefixed_Name(pghdprovo, "dataCoveredByConsent") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Informaion about the person's condition when the data was recorded, such as whether they were resting, active, sleeping, or exercising.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State">https://w3id.org/pghdprovo#State</seealso>
    let State = Prefixed_Name(pghdprovo, "State") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:serviceProviderConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates consents associated with this practitioner or provider.</para>
    /// labels<para>Service Provider Consented</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#serviceProviderConsented">https://w3id.org/pghdprovo#serviceProviderConsented</seealso>
    let serviceProviderConsented =
        Prefixed_Name(pghdprovo, "serviceProviderConsented") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an agent made a request for PGHD. Inverse of pghdprovo:PGHDRequestedBy.</para>
    /// labels<para>requested</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#requested">https://w3id.org/pghdprovo#requested</seealso>
    let requested = Prefixed_Name(pghdprovo, "requested") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:hadDelegate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an agent had another agent act on their behalf. Inverse of prov:actedOnBehalfOf.</para>
    /// labels<para>had delegate</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hadDelegate">https://w3id.org/pghdprovo#hadDelegate</seealso>
    let hadDelegate = Prefixed_Name(pghdprovo, "hadDelegate") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines association between an agent and an activity. Inverse of prov:wasAssociatedWith.</para>
    /// labels<para>associated with</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#associatedWith">https://w3id.org/pghdprovo#associatedWith</seealso>
    let associatedWith = Prefixed_Name(pghdprovo, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:contributed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an agent contributed to an entity. Inverse of prov:wasAttributedTo.</para>
    /// labels<para>contributed</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#contributed">https://w3id.org/pghdprovo#contributed</seealso>
    let contributed = Prefixed_Name(pghdprovo, "contributed") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an entity served as the source for a derived entity. Inverse of prov:wasDerivedFrom.</para>
    /// labels<para>is source of</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isSourceOf">https://w3id.org/pghdprovo#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(pghdprovo, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:appName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the software application utilised by a patient and practitioner.</para>
    /// labels<para>app name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#appName">https://w3id.org/pghdprovo#appName</seealso>
    let appName = Prefixed_Name(pghdprovo, "appName") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:BPMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Device</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#BPMonitor">https://w3id.org/pghdprovo#BPMonitor</seealso>
    let BPMonitor = Prefixed_Name(pghdprovo, "BPMonitor") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:deviceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique number or name given by a device manufacturer to devices that corresponds to a certain characteristics.</para>
    /// labels<para>device model</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#deviceModel">https://w3id.org/pghdprovo#deviceModel</seealso>
    let deviceModel = Prefixed_Name(pghdprovo, "deviceModel") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:BloodPressure1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PGHD</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#BloodPressure1">https://w3id.org/pghdprovo#BloodPressure1</seealso>
    let BloodPressure1 = Prefixed_Name(pghdprovo, "BloodPressure1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Patient1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Patient</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Patient1">https://w3id.org/pghdprovo#Patient1</seealso>
    let Patient1 = Prefixed_Name(pghdprovo, "Patient1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An entity that produce a digital data.</para>
    /// labels<para>data source</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataSource">https://w3id.org/pghdprovo#dataSource</seealso>
    let dataSource = Prefixed_Name(pghdprovo, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'value' property represents the quantity measured or observed, typically recorded by a health or activity monitoring device.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#value">https://w3id.org/pghdprovo#value</seealso>
    let value = Prefixed_Name(pghdprovo, "value") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:wasCollectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ascribing a person engaged in the retrieval of health data. This could be the patient themself, a caregiver, a relative, or a friend.</para>
    /// labels<para>was collected by</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#wasCollectedBy">https://w3id.org/pghdprovo#wasCollectedBy</seealso>
    let wasCollectedBy = Prefixed_Name(pghdprovo, "wasCollectedBy") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Carer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Person who helps a patient to collect or transmit data.</para>
    /// labels<para>Carer</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Carer">https://w3id.org/pghdprovo#Carer</seealso>
    let Carer = Prefixed_Name(pghdprovo, "Carer") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:orgName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the organization where a practitioner belongs.</para>
    /// labels<para>organization name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgName">https://w3id.org/pghdprovo#orgName</seealso>
    let orgName = Prefixed_Name(pghdprovo, "orgName") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PGHDRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A request made by a practitioner to obtain patient health data generated by wearable device or software application.</para>
    /// labels<para>PGHD Request</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequest">https://w3id.org/pghdprovo#PGHDRequest</seealso>
    let PGHDRequest = Prefixed_Name(pghdprovo, "PGHDRequest") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PGHDRequestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A object property that declares the prov:agent responsible for the initializing a request for acquiring of patient Health data.</para>
    /// labels<para>PGHD requested by</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequestedBy">https://w3id.org/pghdprovo#PGHDRequestedBy</seealso>
    let PGHDRequestedBy = Prefixed_Name(pghdprovo, "PGHDRequestedBy") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:wasAuthorizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person who grant access to data requested.</para>
    /// labels<para>was authorized by</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#wasAuthorizedBy">https://w3id.org/pghdprovo#wasAuthorizedBy</seealso>
    let wasAuthorizedBy = Prefixed_Name(pghdprovo, "wasAuthorizedBy") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:requestId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Log id for an activity.</para>
    /// labels<para>activity id</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#requestId">https://w3id.org/pghdprovo#requestId</seealso>
    let requestId = Prefixed_Name(pghdprovo, "requestId") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:PGHDRequest1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PGHDRequest</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequest1">https://w3id.org/pghdprovo#PGHDRequest1</seealso>
    let PGHDRequest1 = Prefixed_Name(pghdprovo, "PGHDRequest1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:application1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Application</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#application1">https://w3id.org/pghdprovo#application1</seealso>
    let application1 = Prefixed_Name(pghdprovo, "application1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Practitioner1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Practitioner</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Practitioner1">https://w3id.org/pghdprovo#Practitioner1</seealso>
    let Practitioner1 = Prefixed_Name(pghdprovo, "Practitioner1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provide more information about an activity.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#description">https://w3id.org/pghdprovo#description</seealso>
    let description = Prefixed_Name(pghdprovo, "description") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A standardized representation of the location of a person, business, building, or organization.</para>
    /// labels<para>address</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#address">https://w3id.org/pghdprovo#address</seealso>
    let address = Prefixed_Name(pghdprovo, "address") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifier</para>
    /// labels<para>id</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#id">https://w3id.org/pghdprovo#id</seealso>
    let id = Prefixed_Name(pghdprovo, "id") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Phone contact number.</para>
    /// labels<para>phone number</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#phoneNumber">https://w3id.org/pghdprovo#phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(pghdprovo, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>position or function within an organization</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#role">https://w3id.org/pghdprovo#role</seealso>
    let role = Prefixed_Name(pghdprovo, "role") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:isAStaffOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Shows the institution a person works.</para>
    /// labels<para>is a staff of</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isAStaffOf">https://w3id.org/pghdprovo#isAStaffOf</seealso>
    let isAStaffOf = Prefixed_Name(pghdprovo, "isAStaffOf") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:bodySite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The part of the body where data is collected or which a device was placed to collect health data.</para>
    /// labels<para>Body Site</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#bodySite">https://w3id.org/pghdprovo#bodySite</seealso>
    let bodySite = Prefixed_Name(pghdprovo, "bodySite") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:ratingOrgName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Denotes the name of the organization that conducted the rating.</para>
    /// labels<para>rating organization name</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ratingOrgName">https://w3id.org/pghdprovo#ratingOrgName</seealso>
    let ratingOrgName = Prefixed_Name(pghdprovo, "ratingOrgName") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:ratingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The efficiency rating of an equipement or device by recognized body.</para>
    /// labels<para>rating score</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ratingScore">https://w3id.org/pghdprovo#ratingScore</seealso>
    let ratingScore = Prefixed_Name(pghdprovo, "ratingScore") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:authorized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an agent authorized an activity. Inverse of pghdprovo:wasAuthorizedBy.</para>
    /// labels<para>authorized</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#authorized">https://w3id.org/pghdprovo#authorized</seealso>
    let authorized = Prefixed_Name(pghdprovo, "authorized") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A code associated with the resource.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#code">https://w3id.org/pghdprovo#code</seealso>
    let code = Prefixed_Name(pghdprovo, "code") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:collected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an agent collected data from an entity. Inverse of pghdprovo:wasCollectedBy.</para>
    /// labels<para>collected</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#collected">https://w3id.org/pghdprovo#collected</seealso>
    let collected = Prefixed_Name(pghdprovo, "collected") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The organization managing or enforcing this consent.</para>
    /// labels<para>Consent Organization</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentOrganisation">https://w3id.org/pghdprovo#consentOrganisation</seealso>
    let consentOrganisation =
        Prefixed_Name(pghdprovo, "consentOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The patient to whom this consent applies.</para>
    /// labels<para>Consent Patient</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentPatient">https://w3id.org/pghdprovo#consentPatient</seealso>
    let consentPatient = Prefixed_Name(pghdprovo, "consentPatient") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:consentPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The URI for the specific organizational or jurisdictional policy referenced.</para>
    /// labels<para>Consent Policy URI</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentPolicy">https://w3id.org/pghdprovo#consentPolicy</seealso>
    let consentPolicy = Prefixed_Name(pghdprovo, "consentPolicy") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentProvisionData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The specific observations (data) covered by this consent rule.</para>
    /// labels<para>Consent Provision Data</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentProvisionData">https://w3id.org/pghdprovo#consentProvisionData</seealso>
    let consentProvisionData =
        Prefixed_Name(pghdprovo, "consentProvisionData") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:consentRegulatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The URI for the computable regulation or policy rule.</para>
    /// labels<para>Consent Regulatory Rule URI</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentRegulatory">https://w3id.org/pghdprovo#consentRegulatory</seealso>
    let consentRegulatory =
        Prefixed_Name(pghdprovo, "consentRegulatory") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:dateCollected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'dateCollected' property records the date and time when the measurement or observation was taken.</para>
    /// labels<para>date collected</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dateCollected">https://w3id.org/pghdprovo#dateCollected</seealso>
    let dateCollected = Prefixed_Name(pghdprovo, "dateCollected") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:isContextualInfoOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates contextual information back to the entity it describes. Inverse of pghdprovo:hasContextualInfo.</para>
    /// labels<para>is contextual info of</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isContextualInfoOf">https://w3id.org/pghdprovo#isContextualInfoOf</seealso>
    let isContextualInfoOf =
        Prefixed_Name(pghdprovo, "isContextualInfoOf") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:hasStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an organization has a staff member. Inverse of pghdprovo:isAStaffOf.</para>
    /// labels<para>has staff</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hasStaff">https://w3id.org/pghdprovo#hasStaff</seealso>
    let hasStaff = Prefixed_Name(pghdprovo, "hasStaff") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:organisationConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates consents managed or enforced by the organization.</para>
    /// labels<para>Organisation Consented</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#organisationConsented">https://w3id.org/pghdprovo#organisationConsented</seealso>
    let organisationConsented =
        Prefixed_Name(pghdprovo, "organisationConsented") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:patientConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates consents associated with this patient.</para>
    /// labels<para>Patient Consented</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#patientConsented">https://w3id.org/pghdprovo#patientConsented</seealso>
    let patientConsented = Prefixed_Name(pghdprovo, "patientConsented") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A software application is a software that can be directly executed by some processing unit.</para>
    /// labels<para>Application</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Application">https://w3id.org/pghdprovo#Application</seealso>
    let Application = Prefixed_Name(pghdprovo, "Application") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person who receives medical attention, care, or treatment, or who is registered with medical professional or institution with the purpose to receive medical care when necessary.</para>
    /// labels<para>Patient</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Patient">https://w3id.org/pghdprovo#Patient</seealso>
    let Patient = Prefixed_Name(pghdprovo, "Patient") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Practitioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person professionally engaged medical practice who is appointed to a post or duties.
    /// [Definition Source: NCI]</para>
    /// labels<para>Practitioner</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Practitioner">https://w3id.org/pghdprovo#Practitioner</seealso>
    let Practitioner = Prefixed_Name(pghdprovo, "Practitioner") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:Rating1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Rating</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Rating1">https://w3id.org/pghdprovo#Rating1</seealso>
    let Rating1 = Prefixed_Name(pghdprovo, "Rating1") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:State1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#State</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State1">https://w3id.org/pghdprovo#State1</seealso>
    let State1 = Prefixed_Name(pghdprovo, "State1") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:ContextualDataInfo1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#ContextualInfo</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ContextualDataInfo1">https://w3id.org/pghdprovo#ContextualDataInfo1</seealso>
    let ContextualDataInfo1 =
        Prefixed_Name(pghdprovo, "ContextualDataInfo1") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:locationOfPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Location of a patient during data collection.</para>
    /// labels<para>location of patient</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#locationOfPatient">https://w3id.org/pghdprovo#locationOfPatient</seealso>
    let locationOfPatient =
        Prefixed_Name(pghdprovo, "locationOfPatient") |> PrefixedName

    /// <summary>
    ///   <para>pghdprovo:orgEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Organization email address.</para>
    /// labels<para>organization email</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgEmail">https://w3id.org/pghdprovo#orgEmail</seealso>
    let orgEmail = Prefixed_Name(pghdprovo, "orgEmail") |> PrefixedName
    /// <summary>
    ///   <para>pghdprovo:orgId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier for an organization.</para>
    /// labels<para>organization id</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgId">https://w3id.org/pghdprovo#orgId</seealso>
    let orgId = Prefixed_Name(pghdprovo, "orgId") |> PrefixedName
