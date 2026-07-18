namespace https.w3id.org.pghdprovo.hash

open DoxAletheia.Rdf_Vocabulary

module pghdprovo =
    let _namespace_name = "https://w3id.org/pghdprovo#"

    /// <summary>
    /// A software application is a software that can be directly executed by some processing unit.
    /// <see href="https://w3id.org/pghdprovo#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// Contextual Information provides to extra details that help explain the measurement, like the environment, device settings, or the activity the person was doing when the data was taken.
    /// <see href="https://w3id.org/pghdprovo#ContextualInfo"></see></summary>
    let ContextualInfo =
        Namespaced_IRI.parse _namespace_name "ContextualInfo" |> NamespacedName

    /// <summary>
    /// Patient Generated Health Data (PGHD) a term referring to data that patients (or their caregivers) collect from home or any location outside the clinical environment.
    /// <see href="https://w3id.org/pghdprovo#PGHD"></see></summary>
    let PGHD = Namespaced_IRI.parse _namespace_name "PGHD" |> NamespacedName
    /// <summary>
    /// A person who receives medical attention, care, or treatment, or who is registered with medical professional or institution with the purpose to receive medical care when necessary.
    /// <see href="https://w3id.org/pghdprovo#Patient"></see></summary>
    let Patient = Namespaced_IRI.parse _namespace_name "Patient" |> NamespacedName

    /// <summary>
    /// A Patient relative or friend who helps to collect or transmit data.
    /// <see href="https://w3id.org/pghdprovo#PatientRelative"></see></summary>
    let PatientRelative =
        Namespaced_IRI.parse _namespace_name "PatientRelative" |> NamespacedName

    /// <summary>
    /// A person professionally engaged medical practice who is appointed to a post or duties.
    /// [Definition Source: NCI]
    /// <see href="https://w3id.org/pghdprovo#Practitioner"></see></summary>
    let Practitioner =
        Namespaced_IRI.parse _namespace_name "Practitioner" |> NamespacedName

    /// <summary>
    /// Refers to a health plan or program the person is following, helping to understand the data in relation to their health goals.
    /// <see href="https://w3id.org/pghdprovo#Programme"></see></summary>
    let Programme = Namespaced_IRI.parse _namespace_name "Programme" |> NamespacedName
    /// <summary>
    /// Describes the steps or rules followed when collecting the data, such as instructions for using a device or following a specific health procedure.
    /// <see href="https://w3id.org/pghdprovo#Protocol"></see></summary>
    let Protocol = Namespaced_IRI.parse _namespace_name "Protocol" |> NamespacedName
    /// <summary>
    /// Includes scores or opinions about the measurement, like how good the data is or a personal rating of a health condition.
    /// <see href="https://w3id.org/pghdprovo#Rating"></see></summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName
    /// <summary>
    /// Informaion about the person's condition when the data was recorded, such as whether they were resting, active, sleeping, or exercising.
    /// <see href="https://w3id.org/pghdprovo#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    /// Indicates that an agent had another agent act on their behalf. Inverse of prov:actedOnBehalfOf.
    /// <see href="https://w3id.org/pghdprovo#hadDelegate"></see></summary>
    let hadDelegate =
        Namespaced_IRI.parse _namespace_name "hadDelegate" |> NamespacedName

    /// <summary>
    /// Defines association between an agent and an activity. Inverse of prov:wasAssociatedWith.
    /// <see href="https://w3id.org/pghdprovo#associatedWith"></see></summary>
    let associatedWith =
        Namespaced_IRI.parse _namespace_name "associatedWith" |> NamespacedName

    /// <summary>
    /// Indicates that an agent contributed to an entity. Inverse of prov:wasAttributedTo.
    /// <see href="https://w3id.org/pghdprovo#contributed"></see></summary>
    let contributed =
        Namespaced_IRI.parse _namespace_name "contributed" |> NamespacedName

    /// <summary>
    /// Indicates that an entity served as the source for a derived entity. Inverse of prov:wasDerivedFrom.
    /// <see href="https://w3id.org/pghdprovo#isSourceOf"></see></summary>
    let isSourceOf = Namespaced_IRI.parse _namespace_name "isSourceOf" |> NamespacedName
    /// <summary>
    /// The name of the software application utilised by a patient and practitioner.
    /// <see href="https://w3id.org/pghdprovo#appName"></see></summary>
    let appName = Namespaced_IRI.parse _namespace_name "appName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#BPMonitor"></see>
    /// </summary>
    let BPMonitor = Namespaced_IRI.parse _namespace_name "BPMonitor" |> NamespacedName

    /// <summary>
    /// A unique number or name given by a device manufacturer to devices that corresponds to a certain characteristics.
    /// <see href="https://w3id.org/pghdprovo#deviceModel"></see></summary>
    let deviceModel =
        Namespaced_IRI.parse _namespace_name "deviceModel" |> NamespacedName

    /// <summary>
    /// A name for a device.
    /// <see href="https://w3id.org/pghdprovo#deviceName"></see></summary>
    let deviceName = Namespaced_IRI.parse _namespace_name "deviceName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#BloodPressure1"></see>
    /// </summary>
    let BloodPressure1 =
        Namespaced_IRI.parse _namespace_name "BloodPressure1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Patient1"></see>
    /// </summary>
    let Patient1 = Namespaced_IRI.parse _namespace_name "Patient1" |> NamespacedName
    /// <summary>
    /// An entity that produce a digital data.
    /// <see href="https://w3id.org/pghdprovo#dataSource"></see></summary>
    let dataSource = Namespaced_IRI.parse _namespace_name "dataSource" |> NamespacedName

    /// <summary>
    /// Has some contextual information associated to the PGHD
    /// <see href="https://w3id.org/pghdprovo#hasContextualInfo"></see></summary>
    let hasContextualInfo =
        Namespaced_IRI.parse _namespace_name "hasContextualInfo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Programme1"></see>
    /// </summary>
    let Programme1 = Namespaced_IRI.parse _namespace_name "Programme1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Rating1"></see>
    /// </summary>
    let Rating1 = Namespaced_IRI.parse _namespace_name "Rating1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#State1"></see>
    /// </summary>
    let State1 = Namespaced_IRI.parse _namespace_name "State1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Protocol1"></see>
    /// </summary>
    let Protocol1 = Namespaced_IRI.parse _namespace_name "Protocol1" |> NamespacedName
    /// <summary>
    /// The 'unit' property specifies the metric or unit of measurement associated with the observed value.
    /// <see href="https://w3id.org/pghdprovo#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
    /// <summary>
    /// The 'value' property represents the quantity measured or observed, typically recorded by a health or activity monitoring device.
    /// <see href="https://w3id.org/pghdprovo#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// Ascribing a person engaged in the retrieval of health data. This could be the patient themself, a caregiver, a relative, or a friend.
    /// <see href="https://w3id.org/pghdprovo#wasCollectedBy"></see></summary>
    let wasCollectedBy =
        Namespaced_IRI.parse _namespace_name "wasCollectedBy" |> NamespacedName

    /// <summary>
    /// A Person who helps a patient to collect or transmit data.
    /// <see href="https://w3id.org/pghdprovo#Carer"></see></summary>
    let Carer = Namespaced_IRI.parse _namespace_name "Carer" |> NamespacedName
    /// <summary>
    /// A record of consent for Patient Generated Health Data.
    /// <see href="https://w3id.org/pghdprovo#Consent"></see></summary>
    let Consent = Namespaced_IRI.parse _namespace_name "Consent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#ContextualDataInfo1"></see>
    /// </summary>
    let ContextualDataInfo1 =
        Namespaced_IRI.parse _namespace_name "ContextualDataInfo1" |> NamespacedName

    /// <summary>
    /// Location of a patient during data collection.
    /// <see href="https://w3id.org/pghdprovo#locationOfPatient"></see></summary>
    let locationOfPatient =
        Namespaced_IRI.parse _namespace_name "locationOfPatient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Organisation1"></see>
    /// </summary>
    let Organisation1 =
        Namespaced_IRI.parse _namespace_name "Organisation1" |> NamespacedName

    /// <summary>
    /// Location of organisation.
    /// <see href="https://w3id.org/pghdprovo#orgAddress"></see></summary>
    let orgAddress = Namespaced_IRI.parse _namespace_name "orgAddress" |> NamespacedName
    /// <summary>
    /// Organization email address.
    /// <see href="https://w3id.org/pghdprovo#orgEmail"></see></summary>
    let orgEmail = Namespaced_IRI.parse _namespace_name "orgEmail" |> NamespacedName
    /// <summary>
    /// An identifier for an organization.
    /// <see href="https://w3id.org/pghdprovo#orgId"></see></summary>
    let orgId = Namespaced_IRI.parse _namespace_name "orgId" |> NamespacedName
    /// <summary>
    /// The name of the organization where a practitioner belongs.
    /// <see href="https://w3id.org/pghdprovo#orgName"></see></summary>
    let orgName = Namespaced_IRI.parse _namespace_name "orgName" |> NamespacedName

    /// <summary>
    /// A request made by a practitioner to obtain patient health data generated by wearable device or software application.
    /// <see href="https://w3id.org/pghdprovo#PGHDRequest"></see></summary>
    let PGHDRequest =
        Namespaced_IRI.parse _namespace_name "PGHDRequest" |> NamespacedName

    /// <summary>
    /// A object property that declares the prov:agent responsible for the initializing a request for acquiring of patient Health data.
    /// <see href="https://w3id.org/pghdprovo#PGHDRequestedBy"></see></summary>
    let PGHDRequestedBy =
        Namespaced_IRI.parse _namespace_name "PGHDRequestedBy" |> NamespacedName

    /// <summary>
    /// A person who grant access to data requested.
    /// <see href="https://w3id.org/pghdprovo#wasAuthorizedBy"></see></summary>
    let wasAuthorizedBy =
        Namespaced_IRI.parse _namespace_name "wasAuthorizedBy" |> NamespacedName

    /// <summary>
    /// Log id for an activity.
    /// <see href="https://w3id.org/pghdprovo#requestId"></see></summary>
    let requestId = Namespaced_IRI.parse _namespace_name "requestId" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#PGHDRequest1"></see>
    /// </summary>
    let PGHDRequest1 =
        Namespaced_IRI.parse _namespace_name "PGHDRequest1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#application1"></see>
    /// </summary>
    let application1 =
        Namespaced_IRI.parse _namespace_name "application1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Practitioner1"></see>
    /// </summary>
    let Practitioner1 =
        Namespaced_IRI.parse _namespace_name "Practitioner1" |> NamespacedName

    /// <summary>
    /// Provide more information about an activity.
    /// <see href="https://w3id.org/pghdprovo#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Indicates that an agent made a request for PGHD. Inverse of pghdprovo:PGHDRequestedBy.
    /// <see href="https://w3id.org/pghdprovo#requested"></see></summary>
    let requested = Namespaced_IRI.parse _namespace_name "requested" |> NamespacedName
    /// <summary>
    /// A standardized representation of the location of a person, business, building, or organization.
    /// <see href="https://w3id.org/pghdprovo#address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    /// Identifier
    /// <see href="https://w3id.org/pghdprovo#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// Phone contact number.
    /// <see href="https://w3id.org/pghdprovo#phoneNumber"></see></summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    /// shows the relationship of a caregiver, friend, or relative to a patient.
    /// <see href="https://w3id.org/pghdprovo#relationship"></see></summary>
    let relationship =
        Namespaced_IRI.parse _namespace_name "relationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#PatientRelative1"></see>
    /// </summary>
    let PatientRelative1 =
        Namespaced_IRI.parse _namespace_name "PatientRelative1" |> NamespacedName

    /// <summary>
    /// position or function within an organization
    /// <see href="https://w3id.org/pghdprovo#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// Shows the institution a person works.
    /// <see href="https://w3id.org/pghdprovo#isAStaffOf"></see></summary>
    let isAStaffOf = Namespaced_IRI.parse _namespace_name "isAStaffOf" |> NamespacedName

    /// <summary>
    /// The treatment programme associated with the PGHD request.
    /// <see href="https://w3id.org/pghdprovo#programmeName"></see></summary>
    let programmeName =
        Namespaced_IRI.parse _namespace_name "programmeName" |> NamespacedName

    /// <summary>
    /// The part of the body where data is collected or which a device was placed to collect health data.
    /// <see href="https://w3id.org/pghdprovo#bodySite"></see></summary>
    let bodySite = Namespaced_IRI.parse _namespace_name "bodySite" |> NamespacedName

    /// <summary>
    /// Denotes the name of the organization that conducted the rating.
    /// <see href="https://w3id.org/pghdprovo#ratingOrgName"></see></summary>
    let ratingOrgName =
        Namespaced_IRI.parse _namespace_name "ratingOrgName" |> NamespacedName

    /// <summary>
    /// The efficiency rating of an equipement or device by recognized body.
    /// <see href="https://w3id.org/pghdprovo#ratingScore"></see></summary>
    let ratingScore =
        Namespaced_IRI.parse _namespace_name "ratingScore" |> NamespacedName

    /// <summary>
    /// exercise state.
    /// <see href="https://w3id.org/pghdprovo#exerciseState"></see></summary>
    let exerciseState =
        Namespaced_IRI.parse _namespace_name "exerciseState" |> NamespacedName

    /// <summary>
    /// The body position of the patient during data collection.
    /// <see href="https://w3id.org/pghdprovo#posture"></see></summary>
    let posture = Namespaced_IRI.parse _namespace_name "posture" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#State2"></see>
    /// </summary>
    let State2 = Namespaced_IRI.parse _namespace_name "State2" |> NamespacedName
    /// <summary>
    /// Indicates that an agent authorized an activity. Inverse of pghdprovo:wasAuthorizedBy.
    /// <see href="https://w3id.org/pghdprovo#authorized"></see></summary>
    let authorized = Namespaced_IRI.parse _namespace_name "authorized" |> NamespacedName

    /// <summary>
    /// Specifies the calibration state of the device that produced the patient-generated health data. Preferred value includes calibrated, not-calibrated, calibration-due, unknown, and self-check-performed.
    /// <see href="https://w3id.org/pghdprovo#calibrationStatus"></see></summary>
    let calibrationStatus =
        Namespaced_IRI.parse _namespace_name "calibrationStatus" |> NamespacedName

    /// <summary>
    /// A code associated with the resource.
    /// <see href="https://w3id.org/pghdprovo#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// Indicates that an agent collected data from an entity. Inverse of pghdprovo:wasCollectedBy.
    /// <see href="https://w3id.org/pghdprovo#collected"></see></summary>
    let collected = Namespaced_IRI.parse _namespace_name "collected" |> NamespacedName

    /// <summary>
    /// The date and time the consent was issued.
    /// <see href="https://w3id.org/pghdprovo#consentDate"></see></summary>
    let consentDate =
        Namespaced_IRI.parse _namespace_name "consentDate" |> NamespacedName

    /// <summary>
    /// The organization managing or enforcing this consent.
    /// <see href="https://w3id.org/pghdprovo#consentOrganisation"></see></summary>
    let consentOrganisation =
        Namespaced_IRI.parse _namespace_name "consentOrganisation" |> NamespacedName

    /// <summary>
    /// The patient to whom this consent applies.
    /// <see href="https://w3id.org/pghdprovo#consentPatient"></see></summary>
    let consentPatient =
        Namespaced_IRI.parse _namespace_name "consentPatient" |> NamespacedName

    /// <summary>
    /// The URI for the specific organizational or jurisdictional policy referenced.
    /// <see href="https://w3id.org/pghdprovo#consentPolicy"></see></summary>
    let consentPolicy =
        Namespaced_IRI.parse _namespace_name "consentPolicy" |> NamespacedName

    /// <summary>
    /// The specific observations (data) covered by this consent rule.
    /// <see href="https://w3id.org/pghdprovo#consentProvisionData"></see></summary>
    let consentProvisionData =
        Namespaced_IRI.parse _namespace_name "consentProvisionData" |> NamespacedName

    /// <summary>
    /// The URI for the computable regulation or policy rule.
    /// <see href="https://w3id.org/pghdprovo#consentRegulatory"></see></summary>
    let consentRegulatory =
        Namespaced_IRI.parse _namespace_name "consentRegulatory" |> NamespacedName

    /// <summary>
    /// The practitioner or provider associated with the consent agreement.
    /// <see href="https://w3id.org/pghdprovo#consentServiceProvider"></see></summary>
    let consentServiceProvider =
        Namespaced_IRI.parse _namespace_name "consentServiceProvider" |> NamespacedName

    /// <summary>
    /// A string reference (URL, ID, or description) pointing to the original source of the consent.
    /// <see href="https://w3id.org/pghdprovo#consentSourceReference"></see></summary>
    let consentSourceReference =
        Namespaced_IRI.parse _namespace_name "consentSourceReference" |> NamespacedName

    /// <summary>
    /// Indicates consents that cover this specific PGHD data.
    /// <see href="https://w3id.org/pghdprovo#dataCoveredByConsent"></see></summary>
    let dataCoveredByConsent =
        Namespaced_IRI.parse _namespace_name "dataCoveredByConsent" |> NamespacedName

    /// <summary>
    /// The 'dataName' property indicates the type of measurement or observation being recorded, such as heart rate, blood pressure, step count, or sleep duration.
    /// <see href="https://w3id.org/pghdprovo#dataName"></see></summary>
    let dataName = Namespaced_IRI.parse _namespace_name "dataName" |> NamespacedName

    /// <summary>
    /// The 'dateCollected' property records the date and time when the measurement or observation was taken.
    /// <see href="https://w3id.org/pghdprovo#dateCollected"></see></summary>
    let dateCollected =
        Namespaced_IRI.parse _namespace_name "dateCollected" |> NamespacedName

    /// <summary>
    /// Relates contextual information back to the entity it describes. Inverse of pghdprovo:hasContextualInfo.
    /// <see href="https://w3id.org/pghdprovo#isContextualInfoOf"></see></summary>
    let isContextualInfoOf =
        Namespaced_IRI.parse _namespace_name "isContextualInfoOf" |> NamespacedName

    /// <summary>
    /// Indicates that an organization has a staff member. Inverse of pghdprovo:isAStaffOf.
    /// <see href="https://w3id.org/pghdprovo#hasStaff"></see></summary>
    let hasStaff = Namespaced_IRI.parse _namespace_name "hasStaff" |> NamespacedName

    /// <summary>
    /// Indicates consents managed or enforced by the organization.
    /// <see href="https://w3id.org/pghdprovo#organisationConsented"></see></summary>
    let organisationConsented =
        Namespaced_IRI.parse _namespace_name "organisationConsented" |> NamespacedName

    /// <summary>
    /// Indicates consents associated with this patient.
    /// <see href="https://w3id.org/pghdprovo#patientConsented"></see></summary>
    let patientConsented =
        Namespaced_IRI.parse _namespace_name "patientConsented" |> NamespacedName

    /// <summary>
    /// Indicates consents associated with this practitioner or provider.
    /// <see href="https://w3id.org/pghdprovo#serviceProviderConsented"></see></summary>
    let serviceProviderConsented =
        Namespaced_IRI.parse _namespace_name "serviceProviderConsented" |> NamespacedName
