namespace https.w3id.org.pghdprovo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pghdprovo =
    let _namespace_iri = Namespace_Iri pghdprovo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:pghdprovo#Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software application is a software that can be directly executed by some processing unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Application">https://w3id.org/pghdprovo#Application</seealso>
    let Application = Prefixed_Name(pghdprovo, "Application") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#BPMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Device</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#BPMonitor">https://w3id.org/pghdprovo#BPMonitor</seealso>
    let BPMonitor = Prefixed_Name(pghdprovo, "BPMonitor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#BloodPressure1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PGHD</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#BloodPressure1">https://w3id.org/pghdprovo#BloodPressure1</seealso>
    let BloodPressure1 = Prefixed_Name(pghdprovo, "BloodPressure1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Carer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person who helps a patient to collect or transmit data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Carer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Carer">https://w3id.org/pghdprovo#Carer</seealso>
    let Carer = Prefixed_Name(pghdprovo, "Carer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Consent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A record of consent for Patient Generated Health Data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Consent">https://w3id.org/pghdprovo#Consent</seealso>
    let Consent = Prefixed_Name(pghdprovo, "Consent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#ContextualDataInfo1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#ContextualInfo</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ContextualDataInfo1">https://w3id.org/pghdprovo#ContextualDataInfo1</seealso>
    let ContextualDataInfo1 =
        Prefixed_Name(pghdprovo, "ContextualDataInfo1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#ContextualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Contextual Information provides to extra details that help explain the measurement, like the environment, device settings, or the activity the person was doing when the data was taken."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contextual information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ContextualInfo">https://w3id.org/pghdprovo#ContextualInfo</seealso>
    let ContextualInfo = Prefixed_Name(pghdprovo, "ContextualInfo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Organisation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Organization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Organisation1">https://w3id.org/pghdprovo#Organisation1</seealso>
    let Organisation1 = Prefixed_Name(pghdprovo, "Organisation1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PGHD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Patient Generated Health Data (PGHD) a term referring to data that patients (or their caregivers) collect from home or any location outside the clinical environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PGHD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHD">https://w3id.org/pghdprovo#PGHD</seealso>
    let PGHD = Prefixed_Name(pghdprovo, "PGHD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PGHDRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A request made by a practitioner to obtain patient health data generated by wearable device or software application."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PGHD Request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequest">https://w3id.org/pghdprovo#PGHDRequest</seealso>
    let PGHDRequest = Prefixed_Name(pghdprovo, "PGHDRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PGHDRequest1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PGHDRequest</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequest1">https://w3id.org/pghdprovo#PGHDRequest1</seealso>
    let PGHDRequest1 = Prefixed_Name(pghdprovo, "PGHDRequest1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PGHDRequestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A object property that declares the prov:agent responsible for the initializing a request for acquiring of patient Health data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PGHD requested by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PGHDRequestedBy">https://w3id.org/pghdprovo#PGHDRequestedBy</seealso>
    let PGHDRequestedBy = Prefixed_Name(pghdprovo, "PGHDRequestedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who receives medical attention, care, or treatment, or who is registered with medical professional or institution with the purpose to receive medical care when necessary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Patient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Patient">https://w3id.org/pghdprovo#Patient</seealso>
    let Patient = Prefixed_Name(pghdprovo, "Patient") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Patient1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Patient</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Patient1">https://w3id.org/pghdprovo#Patient1</seealso>
    let Patient1 = Prefixed_Name(pghdprovo, "Patient1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PatientRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Patient relative or friend who helps to collect or transmit data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Patient Relative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PatientRelative">https://w3id.org/pghdprovo#PatientRelative</seealso>
    let PatientRelative = Prefixed_Name(pghdprovo, "PatientRelative") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#PatientRelative1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#PatientRelative</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#PatientRelative1">https://w3id.org/pghdprovo#PatientRelative1</seealso>
    let PatientRelative1 = Prefixed_Name(pghdprovo, "PatientRelative1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Practitioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person professionally engaged medical practice who is appointed to a post or duties.
    /// [Definition Source: NCI]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Practitioner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Practitioner">https://w3id.org/pghdprovo#Practitioner</seealso>
    let Practitioner = Prefixed_Name(pghdprovo, "Practitioner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Practitioner1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#Practitioner</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Practitioner1">https://w3id.org/pghdprovo#Practitioner1</seealso>
    let Practitioner1 = Prefixed_Name(pghdprovo, "Practitioner1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a health plan or program the person is following, helping to understand the data in relation to their health goals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"programme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Programme">https://w3id.org/pghdprovo#Programme</seealso>
    let Programme = Prefixed_Name(pghdprovo, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Programme1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Programme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Programme1">https://w3id.org/pghdprovo#Programme1</seealso>
    let Programme1 = Prefixed_Name(pghdprovo, "Programme1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the steps or rules followed when collecting the data, such as instructions for using a device or following a specific health procedure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"protocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Protocol">https://w3id.org/pghdprovo#Protocol</seealso>
    let Protocol = Prefixed_Name(pghdprovo, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Protocol1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#Protocol</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Protocol1">https://w3id.org/pghdprovo#Protocol1</seealso>
    let Protocol1 = Prefixed_Name(pghdprovo, "Protocol1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Includes scores or opinions about the measurement, like how good the data is or a personal rating of a health condition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Rating">https://w3id.org/pghdprovo#Rating</seealso>
    let Rating = Prefixed_Name(pghdprovo, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#Rating1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#Rating</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#Rating1">https://w3id.org/pghdprovo#Rating1</seealso>
    let Rating1 = Prefixed_Name(pghdprovo, "Rating1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Informaion about the person's condition when the data was recorded, such as whether they were resting, active, sleeping, or exercising."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State">https://w3id.org/pghdprovo#State</seealso>
    let State = Prefixed_Name(pghdprovo, "State") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#State1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#State</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State1">https://w3id.org/pghdprovo#State1</seealso>
    let State1 = Prefixed_Name(pghdprovo, "State1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#State2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pghdprovo#State</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#State2">https://w3id.org/pghdprovo#State2</seealso>
    let State2 = Prefixed_Name(pghdprovo, "State2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A standardized representation of the location of a person, business, building, or organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#address">https://w3id.org/pghdprovo#address</seealso>
    let address = Prefixed_Name(pghdprovo, "address") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#appName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the software application utilised by a patient and practitioner."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"app name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#appName">https://w3id.org/pghdprovo#appName</seealso>
    let appName = Prefixed_Name(pghdprovo, "appName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#application1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pghdprovo#Application</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pghdprovo#application1">https://w3id.org/pghdprovo#application1</seealso>
    let application1 = Prefixed_Name(pghdprovo, "application1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines association between an agent and an activity. Inverse of prov:wasAssociatedWith."</para>
    /// labels<para>"associated with"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#associatedWith">https://w3id.org/pghdprovo#associatedWith</seealso>
    let associatedWith = Prefixed_Name(pghdprovo, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#authorized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an agent authorized an activity. Inverse of pghdprovo:wasAuthorizedBy."</para>
    /// labels<para>"authorized"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#authorized">https://w3id.org/pghdprovo#authorized</seealso>
    let authorized = Prefixed_Name(pghdprovo, "authorized") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#bodySite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The part of the body where data is collected or which a device was placed to collect health data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Body Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#bodySite">https://w3id.org/pghdprovo#bodySite</seealso>
    let bodySite = Prefixed_Name(pghdprovo, "bodySite") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#calibrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the calibration state of the device that produced the patient-generated health data. Preferred value includes calibrated, not-calibrated, calibration-due, unknown, and self-check-performed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"calibration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#calibrationStatus">https://w3id.org/pghdprovo#calibrationStatus</seealso>
    let calibrationStatus =
        Prefixed_Name(pghdprovo, "calibrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A code associated with the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#code">https://w3id.org/pghdprovo#code</seealso>
    let code = Prefixed_Name(pghdprovo, "code") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#collected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an agent collected data from an entity. Inverse of pghdprovo:wasCollectedBy."</para>
    /// labels<para>"collected"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#collected">https://w3id.org/pghdprovo#collected</seealso>
    let collected = Prefixed_Name(pghdprovo, "collected") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#consentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time the consent was issued."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentDate">https://w3id.org/pghdprovo#consentDate</seealso>
    let consentDate = Prefixed_Name(pghdprovo, "consentDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organization managing or enforcing this consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentOrganisation">https://w3id.org/pghdprovo#consentOrganisation</seealso>
    let consentOrganisation =
        Prefixed_Name(pghdprovo, "consentOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The patient to whom this consent applies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Patient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentPatient">https://w3id.org/pghdprovo#consentPatient</seealso>
    let consentPatient = Prefixed_Name(pghdprovo, "consentPatient") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#consentPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The URI for the specific organizational or jurisdictional policy referenced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Policy URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentPolicy">https://w3id.org/pghdprovo#consentPolicy</seealso>
    let consentPolicy = Prefixed_Name(pghdprovo, "consentPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentProvisionData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The specific observations (data) covered by this consent rule."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Provision Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentProvisionData">https://w3id.org/pghdprovo#consentProvisionData</seealso>
    let consentProvisionData =
        Prefixed_Name(pghdprovo, "consentProvisionData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentRegulatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The URI for the computable regulation or policy rule."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Regulatory Rule URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentRegulatory">https://w3id.org/pghdprovo#consentRegulatory</seealso>
    let consentRegulatory =
        Prefixed_Name(pghdprovo, "consentRegulatory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The practitioner or provider associated with the consent agreement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Service Provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentServiceProvider">https://w3id.org/pghdprovo#consentServiceProvider</seealso>
    let consentServiceProvider =
        Prefixed_Name(pghdprovo, "consentServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#consentSourceReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A string reference (URL, ID, or description) pointing to the original source of the consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Source Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#consentSourceReference">https://w3id.org/pghdprovo#consentSourceReference</seealso>
    let consentSourceReference =
        Prefixed_Name(pghdprovo, "consentSourceReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#contributed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an agent contributed to an entity. Inverse of prov:wasAttributedTo."</para>
    /// labels<para>"contributed"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#contributed">https://w3id.org/pghdprovo#contributed</seealso>
    let contributed = Prefixed_Name(pghdprovo, "contributed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#dataCoveredByConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates consents that cover this specific PGHD data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Covered By Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataCoveredByConsent">https://w3id.org/pghdprovo#dataCoveredByConsent</seealso>
    let dataCoveredByConsent =
        Prefixed_Name(pghdprovo, "dataCoveredByConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#dataName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'dataName' property indicates the type of measurement or observation being recorded, such as heart rate, blood pressure, step count, or sleep duration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"data name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataName">https://w3id.org/pghdprovo#dataName</seealso>
    let dataName = Prefixed_Name(pghdprovo, "dataName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An entity that produce a digital data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"data source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dataSource">https://w3id.org/pghdprovo#dataSource</seealso>
    let dataSource = Prefixed_Name(pghdprovo, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#dateCollected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'dateCollected' property records the date and time when the measurement or observation was taken."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date collected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#dateCollected">https://w3id.org/pghdprovo#dateCollected</seealso>
    let dateCollected = Prefixed_Name(pghdprovo, "dateCollected") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provide more information about an activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#description">https://w3id.org/pghdprovo#description</seealso>
    let description = Prefixed_Name(pghdprovo, "description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#deviceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A unique number or name given by a device manufacturer to devices that corresponds to a certain characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"device model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#deviceModel">https://w3id.org/pghdprovo#deviceModel</seealso>
    let deviceModel = Prefixed_Name(pghdprovo, "deviceModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#deviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A name for a device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"device name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#deviceName">https://w3id.org/pghdprovo#deviceName</seealso>
    let deviceName = Prefixed_Name(pghdprovo, "deviceName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#exerciseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"exercise state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exercise state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#exerciseState">https://w3id.org/pghdprovo#exerciseState</seealso>
    let exerciseState = Prefixed_Name(pghdprovo, "exerciseState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#hadDelegate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an agent had another agent act on their behalf. Inverse of prov:actedOnBehalfOf."</para>
    /// labels<para>"had delegate"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hadDelegate">https://w3id.org/pghdprovo#hadDelegate</seealso>
    let hadDelegate = Prefixed_Name(pghdprovo, "hadDelegate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#hasContextualInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has some contextual information associated to the PGHD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contain Contextual Info"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hasContextualInfo">https://w3id.org/pghdprovo#hasContextualInfo</seealso>
    let hasContextualInfo =
        Prefixed_Name(pghdprovo, "hasContextualInfo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#hasStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an organization has a staff member. Inverse of pghdprovo:isAStaffOf."</para>
    /// labels<para>"has staff"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#hasStaff">https://w3id.org/pghdprovo#hasStaff</seealso>
    let hasStaff = Prefixed_Name(pghdprovo, "hasStaff") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#id">https://w3id.org/pghdprovo#id</seealso>
    let id = Prefixed_Name(pghdprovo, "id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#isAStaffOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Shows the institution a person works."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is a staff of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isAStaffOf">https://w3id.org/pghdprovo#isAStaffOf</seealso>
    let isAStaffOf = Prefixed_Name(pghdprovo, "isAStaffOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#isContextualInfoOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates contextual information back to the entity it describes. Inverse of pghdprovo:hasContextualInfo."</para>
    /// labels<para>"is contextual info of"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isContextualInfoOf">https://w3id.org/pghdprovo#isContextualInfoOf</seealso>
    let isContextualInfoOf =
        Prefixed_Name(pghdprovo, "isContextualInfoOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an entity served as the source for a derived entity. Inverse of prov:wasDerivedFrom."</para>
    /// labels<para>"is source of"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#isSourceOf">https://w3id.org/pghdprovo#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(pghdprovo, "isSourceOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#locationOfPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Location of a patient during data collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"location of patient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#locationOfPatient">https://w3id.org/pghdprovo#locationOfPatient</seealso>
    let locationOfPatient =
        Prefixed_Name(pghdprovo, "locationOfPatient") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#orgAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Location of organisation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgAddress">https://w3id.org/pghdprovo#orgAddress</seealso>
    let orgAddress = Prefixed_Name(pghdprovo, "orgAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#orgEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Organization email address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgEmail">https://w3id.org/pghdprovo#orgEmail</seealso>
    let orgEmail = Prefixed_Name(pghdprovo, "orgEmail") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#orgId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier for an organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgId">https://w3id.org/pghdprovo#orgId</seealso>
    let orgId = Prefixed_Name(pghdprovo, "orgId") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#orgName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the organization where a practitioner belongs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#orgName">https://w3id.org/pghdprovo#orgName</seealso>
    let orgName = Prefixed_Name(pghdprovo, "orgName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#organisationConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates consents managed or enforced by the organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organisation Consented"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#organisationConsented">https://w3id.org/pghdprovo#organisationConsented</seealso>
    let organisationConsented =
        Prefixed_Name(pghdprovo, "organisationConsented") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#patientConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates consents associated with this patient."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Patient Consented"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#patientConsented">https://w3id.org/pghdprovo#patientConsented</seealso>
    let patientConsented = Prefixed_Name(pghdprovo, "patientConsented") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Phone contact number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phone number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#phoneNumber">https://w3id.org/pghdprovo#phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(pghdprovo, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#posture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The body position of the patient during data collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"posture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#posture">https://w3id.org/pghdprovo#posture</seealso>
    let posture = Prefixed_Name(pghdprovo, "posture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#programmeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The treatment programme associated with the PGHD request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"programme name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#programmeName">https://w3id.org/pghdprovo#programmeName</seealso>
    let programmeName = Prefixed_Name(pghdprovo, "programmeName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#ratingOrgName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes the name of the organization that conducted the rating."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating organization name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ratingOrgName">https://w3id.org/pghdprovo#ratingOrgName</seealso>
    let ratingOrgName = Prefixed_Name(pghdprovo, "ratingOrgName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#ratingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The efficiency rating of an equipement or device by recognized body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#ratingScore">https://w3id.org/pghdprovo#ratingScore</seealso>
    let ratingScore = Prefixed_Name(pghdprovo, "ratingScore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"shows the relationship of a caregiver, friend, or relative to a patient."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#relationship">https://w3id.org/pghdprovo#relationship</seealso>
    let relationship = Prefixed_Name(pghdprovo, "relationship") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#requestId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Log id for an activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"activity id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#requestId">https://w3id.org/pghdprovo#requestId</seealso>
    let requestId = Prefixed_Name(pghdprovo, "requestId") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an agent made a request for PGHD. Inverse of pghdprovo:PGHDRequestedBy."</para>
    /// labels<para>"requested"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#requested">https://w3id.org/pghdprovo#requested</seealso>
    let requested = Prefixed_Name(pghdprovo, "requested") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"position or function within an organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#role">https://w3id.org/pghdprovo#role</seealso>
    let role = Prefixed_Name(pghdprovo, "role") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#serviceProviderConsented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates consents associated with this practitioner or provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Provider Consented"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#serviceProviderConsented">https://w3id.org/pghdprovo#serviceProviderConsented</seealso>
    let serviceProviderConsented =
        Prefixed_Name(pghdprovo, "serviceProviderConsented") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo#unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'unit' property specifies the metric or unit of measurement associated with the observed value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#unit">https://w3id.org/pghdprovo#unit</seealso>
    let unit = Prefixed_Name(pghdprovo, "unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'value' property represents the quantity measured or observed, typically recorded by a health or activity monitoring device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#value">https://w3id.org/pghdprovo#value</seealso>
    let value = Prefixed_Name(pghdprovo, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#wasAuthorizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person who grant access to data requested."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"was authorized by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#wasAuthorizedBy">https://w3id.org/pghdprovo#wasAuthorizedBy</seealso>
    let wasAuthorizedBy = Prefixed_Name(pghdprovo, "wasAuthorizedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo#wasCollectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Ascribing a person engaged in the retrieval of health data. This could be the patient themself, a caregiver, a relative, or a friend."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"was collected by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo#wasCollectedBy">https://w3id.org/pghdprovo#wasCollectedBy</seealso>
    let wasCollectedBy = Prefixed_Name(pghdprovo, "wasCollectedBy") |> PrefixedName
