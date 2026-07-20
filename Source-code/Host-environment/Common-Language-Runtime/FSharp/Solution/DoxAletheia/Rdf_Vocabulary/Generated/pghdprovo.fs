namespace https.w3id.org.pghdprovo.hash

open DoxAletheia

module pghdprovo =
    let _namespace_name = "https://w3id.org/pghdprovo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A software application is a software that can be directly executed by some processing unit.
    /// <see href="https://w3id.org/pghdprovo#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// Contextual Information provides to extra details that help explain the measurement, like the environment, device settings, or the activity the person was doing when the data was taken.
    /// <see href="https://w3id.org/pghdprovo#ContextualInfo"></see></summary>
    let ContextualInfo = _prefix "ContextualInfo"
    /// <summary>
    /// Patient Generated Health Data (PGHD) a term referring to data that patients (or their caregivers) collect from home or any location outside the clinical environment.
    /// <see href="https://w3id.org/pghdprovo#PGHD"></see></summary>
    let PGHD = _prefix "PGHD"
    /// <summary>
    /// A person who receives medical attention, care, or treatment, or who is registered with medical professional or institution with the purpose to receive medical care when necessary.
    /// <see href="https://w3id.org/pghdprovo#Patient"></see></summary>
    let Patient = _prefix "Patient"
    /// <summary>
    /// A Patient relative or friend who helps to collect or transmit data.
    /// <see href="https://w3id.org/pghdprovo#PatientRelative"></see></summary>
    let PatientRelative = _prefix "PatientRelative"
    /// <summary>
    /// A person professionally engaged medical practice who is appointed to a post or duties.
    /// [Definition Source: NCI]
    /// <see href="https://w3id.org/pghdprovo#Practitioner"></see></summary>
    let Practitioner = _prefix "Practitioner"
    /// <summary>
    /// Refers to a health plan or program the person is following, helping to understand the data in relation to their health goals.
    /// <see href="https://w3id.org/pghdprovo#Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    /// Describes the steps or rules followed when collecting the data, such as instructions for using a device or following a specific health procedure.
    /// <see href="https://w3id.org/pghdprovo#Protocol"></see></summary>
    let Protocol = _prefix "Protocol"
    /// <summary>
    /// Includes scores or opinions about the measurement, like how good the data is or a personal rating of a health condition.
    /// <see href="https://w3id.org/pghdprovo#Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// Informaion about the person's condition when the data was recorded, such as whether they were resting, active, sleeping, or exercising.
    /// <see href="https://w3id.org/pghdprovo#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// Indicates that an agent had another agent act on their behalf. Inverse of prov:actedOnBehalfOf.
    /// <see href="https://w3id.org/pghdprovo#hadDelegate"></see></summary>
    let hadDelegate = _prefix "hadDelegate"
    /// <summary>
    /// Defines association between an agent and an activity. Inverse of prov:wasAssociatedWith.
    /// <see href="https://w3id.org/pghdprovo#associatedWith"></see></summary>
    let associatedWith = _prefix "associatedWith"
    /// <summary>
    /// Indicates that an agent contributed to an entity. Inverse of prov:wasAttributedTo.
    /// <see href="https://w3id.org/pghdprovo#contributed"></see></summary>
    let contributed = _prefix "contributed"
    /// <summary>
    /// Indicates that an entity served as the source for a derived entity. Inverse of prov:wasDerivedFrom.
    /// <see href="https://w3id.org/pghdprovo#isSourceOf"></see></summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    /// The name of the software application utilised by a patient and practitioner.
    /// <see href="https://w3id.org/pghdprovo#appName"></see></summary>
    let appName = _prefix "appName"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#BPMonitor"></see>
    /// </summary>
    let BPMonitor = _prefix "BPMonitor"
    /// <summary>
    /// A unique number or name given by a device manufacturer to devices that corresponds to a certain characteristics.
    /// <see href="https://w3id.org/pghdprovo#deviceModel"></see></summary>
    let deviceModel = _prefix "deviceModel"
    /// <summary>
    /// A name for a device.
    /// <see href="https://w3id.org/pghdprovo#deviceName"></see></summary>
    let deviceName = _prefix "deviceName"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#BloodPressure1"></see>
    /// </summary>
    let BloodPressure1 = _prefix "BloodPressure1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Patient1"></see>
    /// </summary>
    let Patient1 = _prefix "Patient1"
    /// <summary>
    /// An entity that produce a digital data.
    /// <see href="https://w3id.org/pghdprovo#dataSource"></see></summary>
    let dataSource = _prefix "dataSource"
    /// <summary>
    /// Has some contextual information associated to the PGHD
    /// <see href="https://w3id.org/pghdprovo#hasContextualInfo"></see></summary>
    let hasContextualInfo = _prefix "hasContextualInfo"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Programme1"></see>
    /// </summary>
    let Programme1 = _prefix "Programme1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Rating1"></see>
    /// </summary>
    let Rating1 = _prefix "Rating1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#State1"></see>
    /// </summary>
    let State1 = _prefix "State1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Protocol1"></see>
    /// </summary>
    let Protocol1 = _prefix "Protocol1"
    /// <summary>
    /// The 'unit' property specifies the metric or unit of measurement associated with the observed value.
    /// <see href="https://w3id.org/pghdprovo#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// The 'value' property represents the quantity measured or observed, typically recorded by a health or activity monitoring device.
    /// <see href="https://w3id.org/pghdprovo#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Ascribing a person engaged in the retrieval of health data. This could be the patient themself, a caregiver, a relative, or a friend.
    /// <see href="https://w3id.org/pghdprovo#wasCollectedBy"></see></summary>
    let wasCollectedBy = _prefix "wasCollectedBy"
    /// <summary>
    /// A Person who helps a patient to collect or transmit data.
    /// <see href="https://w3id.org/pghdprovo#Carer"></see></summary>
    let Carer = _prefix "Carer"
    /// <summary>
    /// A record of consent for Patient Generated Health Data.
    /// <see href="https://w3id.org/pghdprovo#Consent"></see></summary>
    let Consent = _prefix "Consent"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#ContextualDataInfo1"></see>
    /// </summary>
    let ContextualDataInfo1 = _prefix "ContextualDataInfo1"
    /// <summary>
    /// Location of a patient during data collection.
    /// <see href="https://w3id.org/pghdprovo#locationOfPatient"></see></summary>
    let locationOfPatient = _prefix "locationOfPatient"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Organisation1"></see>
    /// </summary>
    let Organisation1 = _prefix "Organisation1"
    /// <summary>
    /// Location of organisation.
    /// <see href="https://w3id.org/pghdprovo#orgAddress"></see></summary>
    let orgAddress = _prefix "orgAddress"
    /// <summary>
    /// Organization email address.
    /// <see href="https://w3id.org/pghdprovo#orgEmail"></see></summary>
    let orgEmail = _prefix "orgEmail"
    /// <summary>
    /// An identifier for an organization.
    /// <see href="https://w3id.org/pghdprovo#orgId"></see></summary>
    let orgId = _prefix "orgId"
    /// <summary>
    /// The name of the organization where a practitioner belongs.
    /// <see href="https://w3id.org/pghdprovo#orgName"></see></summary>
    let orgName = _prefix "orgName"
    /// <summary>
    /// A request made by a practitioner to obtain patient health data generated by wearable device or software application.
    /// <see href="https://w3id.org/pghdprovo#PGHDRequest"></see></summary>
    let PGHDRequest = _prefix "PGHDRequest"
    /// <summary>
    /// A object property that declares the prov:agent responsible for the initializing a request for acquiring of patient Health data.
    /// <see href="https://w3id.org/pghdprovo#PGHDRequestedBy"></see></summary>
    let PGHDRequestedBy = _prefix "PGHDRequestedBy"
    /// <summary>
    /// A person who grant access to data requested.
    /// <see href="https://w3id.org/pghdprovo#wasAuthorizedBy"></see></summary>
    let wasAuthorizedBy = _prefix "wasAuthorizedBy"
    /// <summary>
    /// Log id for an activity.
    /// <see href="https://w3id.org/pghdprovo#requestId"></see></summary>
    let requestId = _prefix "requestId"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#PGHDRequest1"></see>
    /// </summary>
    let PGHDRequest1 = _prefix "PGHDRequest1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#application1"></see>
    /// </summary>
    let application1 = _prefix "application1"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#Practitioner1"></see>
    /// </summary>
    let Practitioner1 = _prefix "Practitioner1"
    /// <summary>
    /// Provide more information about an activity.
    /// <see href="https://w3id.org/pghdprovo#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Indicates that an agent made a request for PGHD. Inverse of pghdprovo:PGHDRequestedBy.
    /// <see href="https://w3id.org/pghdprovo#requested"></see></summary>
    let requested = _prefix "requested"
    /// <summary>
    /// A standardized representation of the location of a person, business, building, or organization.
    /// <see href="https://w3id.org/pghdprovo#address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// Identifier
    /// <see href="https://w3id.org/pghdprovo#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// Phone contact number.
    /// <see href="https://w3id.org/pghdprovo#phoneNumber"></see></summary>
    let phoneNumber = _prefix "phoneNumber"
    /// <summary>
    /// shows the relationship of a caregiver, friend, or relative to a patient.
    /// <see href="https://w3id.org/pghdprovo#relationship"></see></summary>
    let relationship = _prefix "relationship"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#PatientRelative1"></see>
    /// </summary>
    let PatientRelative1 = _prefix "PatientRelative1"
    /// <summary>
    /// position or function within an organization
    /// <see href="https://w3id.org/pghdprovo#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Shows the institution a person works.
    /// <see href="https://w3id.org/pghdprovo#isAStaffOf"></see></summary>
    let isAStaffOf = _prefix "isAStaffOf"
    /// <summary>
    /// The treatment programme associated with the PGHD request.
    /// <see href="https://w3id.org/pghdprovo#programmeName"></see></summary>
    let programmeName = _prefix "programmeName"
    /// <summary>
    /// The part of the body where data is collected or which a device was placed to collect health data.
    /// <see href="https://w3id.org/pghdprovo#bodySite"></see></summary>
    let bodySite = _prefix "bodySite"
    /// <summary>
    /// Denotes the name of the organization that conducted the rating.
    /// <see href="https://w3id.org/pghdprovo#ratingOrgName"></see></summary>
    let ratingOrgName = _prefix "ratingOrgName"
    /// <summary>
    /// The efficiency rating of an equipement or device by recognized body.
    /// <see href="https://w3id.org/pghdprovo#ratingScore"></see></summary>
    let ratingScore = _prefix "ratingScore"
    /// <summary>
    /// exercise state.
    /// <see href="https://w3id.org/pghdprovo#exerciseState"></see></summary>
    let exerciseState = _prefix "exerciseState"
    /// <summary>
    /// The body position of the patient during data collection.
    /// <see href="https://w3id.org/pghdprovo#posture"></see></summary>
    let posture = _prefix "posture"
    /// <summary>
    ///   <see href="https://w3id.org/pghdprovo#State2"></see>
    /// </summary>
    let State2 = _prefix "State2"
    /// <summary>
    /// Indicates that an agent authorized an activity. Inverse of pghdprovo:wasAuthorizedBy.
    /// <see href="https://w3id.org/pghdprovo#authorized"></see></summary>
    let authorized = _prefix "authorized"
    /// <summary>
    /// Specifies the calibration state of the device that produced the patient-generated health data. Preferred value includes calibrated, not-calibrated, calibration-due, unknown, and self-check-performed.
    /// <see href="https://w3id.org/pghdprovo#calibrationStatus"></see></summary>
    let calibrationStatus = _prefix "calibrationStatus"
    /// <summary>
    /// A code associated with the resource.
    /// <see href="https://w3id.org/pghdprovo#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// Indicates that an agent collected data from an entity. Inverse of pghdprovo:wasCollectedBy.
    /// <see href="https://w3id.org/pghdprovo#collected"></see></summary>
    let collected = _prefix "collected"
    /// <summary>
    /// The date and time the consent was issued.
    /// <see href="https://w3id.org/pghdprovo#consentDate"></see></summary>
    let consentDate = _prefix "consentDate"
    /// <summary>
    /// The organization managing or enforcing this consent.
    /// <see href="https://w3id.org/pghdprovo#consentOrganisation"></see></summary>
    let consentOrganisation = _prefix "consentOrganisation"
    /// <summary>
    /// The patient to whom this consent applies.
    /// <see href="https://w3id.org/pghdprovo#consentPatient"></see></summary>
    let consentPatient = _prefix "consentPatient"
    /// <summary>
    /// The URI for the specific organizational or jurisdictional policy referenced.
    /// <see href="https://w3id.org/pghdprovo#consentPolicy"></see></summary>
    let consentPolicy = _prefix "consentPolicy"
    /// <summary>
    /// The specific observations (data) covered by this consent rule.
    /// <see href="https://w3id.org/pghdprovo#consentProvisionData"></see></summary>
    let consentProvisionData = _prefix "consentProvisionData"
    /// <summary>
    /// The URI for the computable regulation or policy rule.
    /// <see href="https://w3id.org/pghdprovo#consentRegulatory"></see></summary>
    let consentRegulatory = _prefix "consentRegulatory"
    /// <summary>
    /// The practitioner or provider associated with the consent agreement.
    /// <see href="https://w3id.org/pghdprovo#consentServiceProvider"></see></summary>
    let consentServiceProvider = _prefix "consentServiceProvider"
    /// <summary>
    /// A string reference (URL, ID, or description) pointing to the original source of the consent.
    /// <see href="https://w3id.org/pghdprovo#consentSourceReference"></see></summary>
    let consentSourceReference = _prefix "consentSourceReference"
    /// <summary>
    /// Indicates consents that cover this specific PGHD data.
    /// <see href="https://w3id.org/pghdprovo#dataCoveredByConsent"></see></summary>
    let dataCoveredByConsent = _prefix "dataCoveredByConsent"
    /// <summary>
    /// The 'dataName' property indicates the type of measurement or observation being recorded, such as heart rate, blood pressure, step count, or sleep duration.
    /// <see href="https://w3id.org/pghdprovo#dataName"></see></summary>
    let dataName = _prefix "dataName"
    /// <summary>
    /// The 'dateCollected' property records the date and time when the measurement or observation was taken.
    /// <see href="https://w3id.org/pghdprovo#dateCollected"></see></summary>
    let dateCollected = _prefix "dateCollected"
    /// <summary>
    /// Relates contextual information back to the entity it describes. Inverse of pghdprovo:hasContextualInfo.
    /// <see href="https://w3id.org/pghdprovo#isContextualInfoOf"></see></summary>
    let isContextualInfoOf = _prefix "isContextualInfoOf"
    /// <summary>
    /// Indicates that an organization has a staff member. Inverse of pghdprovo:isAStaffOf.
    /// <see href="https://w3id.org/pghdprovo#hasStaff"></see></summary>
    let hasStaff = _prefix "hasStaff"
    /// <summary>
    /// Indicates consents managed or enforced by the organization.
    /// <see href="https://w3id.org/pghdprovo#organisationConsented"></see></summary>
    let organisationConsented = _prefix "organisationConsented"
    /// <summary>
    /// Indicates consents associated with this patient.
    /// <see href="https://w3id.org/pghdprovo#patientConsented"></see></summary>
    let patientConsented = _prefix "patientConsented"
    /// <summary>
    /// Indicates consents associated with this practitioner or provider.
    /// <see href="https://w3id.org/pghdprovo#serviceProviderConsented"></see></summary>
    let serviceProviderConsented = _prefix "serviceProviderConsented"
