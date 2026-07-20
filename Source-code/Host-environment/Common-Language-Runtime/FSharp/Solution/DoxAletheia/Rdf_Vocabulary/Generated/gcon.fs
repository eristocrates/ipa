namespace https.w3id.org.GConsent.hash

open DoxAletheia

module gcon =
    let _namespace_name = "https://w3id.org/GConsent#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents Adaptation Of personal data.
    /// <see href="https://w3id.org/GConsent#AdaptationOfPersonalData"></see></summary>
    let AdaptationOfPersonalData = _prefix "AdaptationOfPersonalData"
    /// <summary>
    /// Represents Alignment Of personal data.
    /// <see href="https://w3id.org/GConsent#AlignmentOfPersonalData"></see></summary>
    let AlignmentOfPersonalData = _prefix "AlignmentOfPersonalData"
    /// <summary>
    /// Represents Alteration Of personal data.
    /// <see href="https://w3id.org/GConsent#AlterationOfPersonalData"></see></summary>
    let AlterationOfPersonalData = _prefix "AlterationOfPersonalData"
    /// <summary>
    /// Represents Collection Of personal data.
    /// <see href="https://w3id.org/GConsent#CollectionOfPersonalData"></see></summary>
    let CollectionOfPersonalData = _prefix "CollectionOfPersonalData"
    /// <summary>
    /// Represents Combination Of personal data.
    /// <see href="https://w3id.org/GConsent#CombinationOfPersonalData"></see></summary>
    let CombinationOfPersonalData = _prefix "CombinationOfPersonalData"
    /// <summary>
    /// Represents Consultation Of personal data.
    /// <see href="https://w3id.org/GConsent#ConsultationOfPersonalData"></see></summary>
    let ConsultationOfPersonalData = _prefix "ConsultationOfPersonalData"
    /// <summary>
    /// Represents Destruction Of personal data.
    /// <see href="https://w3id.org/GConsent#DestructionOfPersonalData"></see></summary>
    let DestructionOfPersonalData = _prefix "DestructionOfPersonalData"

    /// <summary>
    /// Represents Disclosure by Transmission Of personal data.
    /// <see href="https://w3id.org/GConsent#DisclosureByTransmissionOfPersonalData"></see></summary>
    let DisclosureByTransmissionOfPersonalData =
        _prefix "DisclosureByTransmissionOfPersonalData"

    /// <summary>
    /// Represents Dissemination Of personal data.
    /// <see href="https://w3id.org/GConsent#DisseminationOfPersonalData"></see></summary>
    let DisseminationOfPersonalData = _prefix "DisseminationOfPersonalData"
    /// <summary>
    /// Represents Erasure Of personal data.
    /// <see href="https://w3id.org/GConsent#ErasureOfPersonalData"></see></summary>
    let ErasureOfPersonalData = _prefix "ErasureOfPersonalData"
    /// <summary>
    /// Represents Organisation Of personal data.
    /// <see href="https://w3id.org/GConsent#OrganisationOfPersonalData"></see></summary>
    let OrganisationOfPersonalData = _prefix "OrganisationOfPersonalData"
    /// <summary>
    /// Represents Recording Of personal data.
    /// <see href="https://w3id.org/GConsent#RecordingOfPersonalData"></see></summary>
    let RecordingOfPersonalData = _prefix "RecordingOfPersonalData"
    /// <summary>
    /// Represents Restriction Of personal data.
    /// <see href="https://w3id.org/GConsent#RestrictionOfPersonalData"></see></summary>
    let RestrictionOfPersonalData = _prefix "RestrictionOfPersonalData"
    /// <summary>
    /// Represents Retrieval Of personal data.
    /// <see href="https://w3id.org/GConsent#RetrievalOfPersonalData"></see></summary>
    let RetrievalOfPersonalData = _prefix "RetrievalOfPersonalData"
    /// <summary>
    /// Represents sharing of personal data
    /// <see href="https://w3id.org/GConsent#SharingOfPersonalData"></see></summary>
    let SharingOfPersonalData = _prefix "SharingOfPersonalData"
    /// <summary>
    /// Represents Storage Of personal data.
    /// <see href="https://w3id.org/GConsent#StorageOfPersonalData"></see></summary>
    let StorageOfPersonalData = _prefix "StorageOfPersonalData"
    /// <summary>
    /// Represents Structuring Of personal data.
    /// <see href="https://w3id.org/GConsent#StructuringOfPersonalData"></see></summary>
    let StructuringOfPersonalData = _prefix "StructuringOfPersonalData"
    /// <summary>
    /// Represents Use Of personal data.
    /// <see href="https://w3id.org/GConsent#UseOfPersonalData"></see></summary>
    let UseOfPersonalData = _prefix "UseOfPersonalData"
    /// <summary>
    /// Indicates the consent has expired.
    /// <see href="https://w3id.org/GConsent#ConsentStatusExpired"></see></summary>
    let ConsentStatusExpired = _prefix "ConsentStatusExpired"
    /// <summary>
    /// Indicates consent is explicitly given.
    /// <see href="https://w3id.org/GConsent#ConsentStatusExplicitlyGiven"></see></summary>
    let ConsentStatusExplicitlyGiven = _prefix "ConsentStatusExplicitlyGiven"
    /// <summary>
    /// Indicates consent is given via delegation.
    /// <see href="https://w3id.org/GConsent#ConsentStatusGivenByDelegation"></see></summary>
    let ConsentStatusGivenByDelegation = _prefix "ConsentStatusGivenByDelegation"
    /// <summary>
    /// Indicates consent is given via an implicit action or assumption.
    /// <see href="https://w3id.org/GConsent#ConsentStatusImplicitlyGiven"></see></summary>
    let ConsentStatusImplicitlyGiven = _prefix "ConsentStatusImplicitlyGiven"
    /// <summary>
    /// Indicates the consent has been invalidated.
    /// <see href="https://w3id.org/GConsent#ConsentStatusInvalidated"></see></summary>
    let ConsentStatusInvalidated = _prefix "ConsentStatusInvalidated"
    /// <summary>
    /// Indicates that consent has not been given.
    /// <see href="https://w3id.org/GConsent#ConsentStatusNotGiven"></see></summary>
    let ConsentStatusNotGiven = _prefix "ConsentStatusNotGiven"
    /// <summary>
    /// Indicates that consent has been refused (to be given).
    /// <see href="https://w3id.org/GConsent#ConsentStatusRefused"></see></summary>
    let ConsentStatusRefused = _prefix "ConsentStatusRefused"
    /// <summary>
    /// Indicates consent has been requested but has not been given (yet).
    /// <see href="https://w3id.org/GConsent#ConsentStatusRequested"></see></summary>
    let ConsentStatusRequested = _prefix "ConsentStatusRequested"
    /// <summary>
    /// Indicates the consent status is unknown.
    /// <see href="https://w3id.org/GConsent#ConsentStatusUnknown"></see></summary>
    let ConsentStatusUnknown = _prefix "ConsentStatusUnknown"
    /// <summary>
    /// Indicates consent has been withdrawn.
    /// <see href="https://w3id.org/GConsent#ConsentStatusWithdrawn"></see></summary>
    let ConsentStatusWithdrawn = _prefix "ConsentStatusWithdrawn"
    /// <summary>
    /// Represents the type of processing where Adaptation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAdaptation"></see></summary>
    let DataAdaptation = _prefix "DataAdaptation"
    /// <summary>
    /// Processing is defined by the GDPR (Article 4-2) as "any operation or set of operations which is performed on personal data or on sets of personal data, whether or not by automated means, such as collection, recording, organisation, structuring, storage, adaptation or alteration, retrieval, consultation, use, disclosure by transmission, dissemination or otherwise making available, alignment or combination, restriction, erasure or destruction;".
    ///
    /// Processing can be considered as the action, within an activity for example, that uses data in a particular or specific way. Therefore, processing specifies what is happening to/with the data.
    ///
    /// To define a type of processing (or its associated action), the Processing class should be subclassed for each type. Furthermore, each subclass should define a instance as a generic representative of that action. For example, "collect" as a type of processing (defined by the GDPR), is defined as the class DataCollection, which is a subclass of Processing, and has the individual CollectionOfPersonalData to represent a generic instance of the concept. This is to provide a ready-to-use ontology in terms of "collect" as an action, while also providing a way to specialise the action/processing.
    /// GConsent defines several such types of processing taken from the text of the GDPR.
    /// <see href="https://w3id.org/GConsent#Processing"></see></summary>
    let Processing = _prefix "Processing"
    /// <summary>
    /// Represents the type of processing where Alignment of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAlignment"></see></summary>
    let DataAlignment = _prefix "DataAlignment"
    /// <summary>
    /// Represents the type of processing where Alteration of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAlteration"></see></summary>
    let DataAlteration = _prefix "DataAlteration"
    /// <summary>
    /// Represents the type of processing where Collection of data takes place.
    /// <see href="https://w3id.org/GConsent#DataCollection"></see></summary>
    let DataCollection = _prefix "DataCollection"
    /// <summary>
    /// Represents the type of processing where Combination of data takes place.
    /// <see href="https://w3id.org/GConsent#DataCombination"></see></summary>
    let DataCombination = _prefix "DataCombination"
    /// <summary>
    /// As per Article 4(11) of the GDPR, ‘consent’ of the data subject means any freely given, specific, informed and unambiguous indication of the data subject’s wishes by which he or she, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to him or her;
    ///
    /// In the case of this ontology, 'Consent' is a concept as well as a tangible entity (something that has a provenance record). To separate this distinction with relation to the data subject, the Consent class represents the consent of the data subject in its entirely, including any history and annotations for it.
    ///
    /// To link the `Consent` instance with the `DataSubject` instance, use the `isConsentForDataSubject` and `hasConsent` properties.
    /// <see href="https://w3id.org/GConsent#Consent"></see></summary>
    let Consent = _prefix "Consent"
    /// <summary>
    /// Denotes the state or status of consent.
    /// <see href="https://w3id.org/GConsent#hasStatus"></see></summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// Represents the status of consent for the data subject. This allows persisting the determination of the validatity or suitability of consent (as an entity or instance) for use in processing and other activities. Examples: consent is given, consent is requested but not given, consent was withdrawn.
    /// <see href="https://w3id.org/GConsent#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Links a consent instance with the data subject it is associated with.
    /// <see href="https://w3id.org/GConsent#isConsentForDataSubject"></see></summary>
    let isConsentForDataSubject = _prefix "isConsentForDataSubject"
    /// <summary>
    /// Data Subject is defined as an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person; - according to Article 4(1) of the GDPR pertaining to the definition of Personal Data.
    ///
    /// In the case of this ontology, a Data Subject refers to the person(s) as per the definition of the GDPR. Since a Data Subject is a Person, it is defined as a subclass of foaf:Person.
    ///
    /// The Data Subject is linked to the Consent instance via the isConsentForDataSubject and hasConsent properties.
    /// <see href="https://w3id.org/GConsent#DataSubject"></see></summary>
    let DataSubject = _prefix "DataSubject"
    /// <summary>
    /// Represents consent states that are invalid for processing.
    /// <see href="https://w3id.org/GConsent#StatusInvalidForProcessing"></see></summary>
    let StatusInvalidForProcessing = _prefix "StatusInvalidForProcessing"
    /// <summary>
    /// Represents consent states that are valid for processing
    /// <see href="https://w3id.org/GConsent#StatusValidForProcessing"></see></summary>
    let StatusValidForProcessing = _prefix "StatusValidForProcessing"
    /// <summary>
    /// Represents the type of processing where Consultation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataConsultation"></see></summary>
    let DataConsultation = _prefix "DataConsultation"
    /// <summary>
    /// A Data Controller is defined as "The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data."
    /// <see href="https://w3id.org/GConsent#DataController"></see></summary>
    let DataController = _prefix "DataController"
    /// <summary>
    /// Represents the type of processing where Destruction of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDestruction"></see></summary>
    let DataDestruction = _prefix "DataDestruction"
    /// <summary>
    /// Represents the type of processing where Disclosure by Transmission of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDisclosureByTransmission"></see></summary>
    let DataDisclosureByTransmission = _prefix "DataDisclosureByTransmission"
    /// <summary>
    /// Represents the type of processing where Dissemination of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDissemination"></see></summary>
    let DataDissemination = _prefix "DataDissemination"
    /// <summary>
    /// Represents the type of processing where Erasure of data takes place.
    /// <see href="https://w3id.org/GConsent#DataErasure"></see></summary>
    let DataErasure = _prefix "DataErasure"
    /// <summary>
    /// Represents the type of processing where Organisation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataOrganisation"></see></summary>
    let DataOrganisation = _prefix "DataOrganisation"
    /// <summary>
    /// Represents the type of processing where Recording of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRecording"></see></summary>
    let DataRecording = _prefix "DataRecording"
    /// <summary>
    /// Represents the type of processing where Restriction of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRestriction"></see></summary>
    let DataRestriction = _prefix "DataRestriction"
    /// <summary>
    /// Represents the type of processing where Retrieval of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRetrieval"></see></summary>
    let DataRetrieval = _prefix "DataRetrieval"
    /// <summary>
    /// Type of processing where sharing of data takes place with a Third Party.
    /// <see href="https://w3id.org/GConsent#DataSharing"></see></summary>
    let DataSharing = _prefix "DataSharing"
    /// <summary>
    /// Represents the type of processing where Storage of data takes place.
    /// <see href="https://w3id.org/GConsent#DataStorage"></see></summary>
    let DataStorage = _prefix "DataStorage"
    /// <summary>
    /// Represents the type of processing where Structuring of data takes place.
    /// <see href="https://w3id.org/GConsent#DataStructuring"></see></summary>
    let DataStructuring = _prefix "DataStructuring"
    /// <summary>
    /// Represents the type of processing where Use of data takes place.
    /// <see href="https://w3id.org/GConsent#DataUse"></see></summary>
    let DataUse = _prefix "DataUse"
    /// <summary>
    /// A Delegation of consent occurs when another entity, whether a data subject or their representative or an automated mechanism, provides the consent on behalf of the intended Data Subject. The delegated consent is provided through the mechanism of a _delegation_. This involves three entities - the Data Subject the delegation occurs for, the entity that acts as the delegate, and the mechanism used to verify the authority to delegate. They (first two) are provided respectively by the properties `isConsentDelegationFor`, and `hasConsentGivenByDelegate`.
    /// <see href="https://w3id.org/GConsent#Delegation"></see></summary>
    let Delegation = _prefix "Delegation"
    /// <summary>
    /// Represents a consent entity that is considered given whether implicitly, explicitly, or by delegation.
    /// <see href="https://w3id.org/GConsent#GivenConsent"></see></summary>
    let GivenConsent = _prefix "GivenConsent"
    /// <summary>
    /// Describes the medium through which consent was given/provided. Example: web form, recorded voice, signature on document.
    /// <see href="https://w3id.org/GConsent#Medium"></see></summary>
    let Medium = _prefix "Medium"
    /// <summary>
    /// A Minor is a Data Subject who cannot provide their own consent (that is legally valid). Therefore, their consent must be obtained via a Guardian or Legal Representative or Parent. Minor is a subclass of Data Subject.
    ///
    /// Consent given in lieu of a Minor (by their Representative) is associated with the `ConsentInstance` class/instance using the `wasGivenBy` property.
    ///
    /// The ontology currently does not capture this relationship between the Minor and their Representative. This is due to required clarifications regarding how this role should be represented. For example, the `DataSubject` cannot be subclassed to create a `Representative` class, as this would make the `DataSubject` a permanent representative for the Minor. Instead, the role of 'acting as representative' is only for the instance of the given consent. Therefore, this could be represented with a `ConsentRepresentativeRole` class that links to the `MinorDataSubject` with `roleHadDataSubject` property, and the `DataSubject` that gave the consent via the `roleHadRepresentative` property. The relationship or reason or situation of this given consent can be captured by further annotating the `ConsentRepresentativeRole` instance. This approach can also be extended to other similar situations where one `DataSubject` gives consent in lieu of another.
    ///
    /// Note: A Minor can provide their own consent in certain cases, or conversely, a minor's consent may need to be provided by a 'parental' representative in some cases.
    /// <see href="https://w3id.org/GConsent#MinorDataSubject"></see></summary>
    let MinorDataSubject = _prefix "MinorDataSubject"
    /// <summary>
    /// As per Article 4(1) of the GDPR, ‘personal data’ means any information relating to an identified or identifiable natural person (‘data subject’);
    /// <see href="https://w3id.org/GConsent#PersonalData"></see></summary>
    let PersonalData = _prefix "PersonalData"
    /// <summary>
    /// Purpose refers to the aim or goal towards which the data is processed (or associated with any other form of action).
    /// <see href="https://w3id.org/GConsent#Purpose"></see></summary>
    let Purpose = _prefix "Purpose"
    /// <summary>
    /// Represents an Agent that is a Person or an Organisation other than the current entity (w.r.t. data protection laws).
    /// <see href="https://w3id.org/GConsent#ThirdParty"></see></summary>
    let ThirdParty = _prefix "ThirdParty"
    /// <summary>
    /// Specifies the location at which the consent was given.
    /// <see href="https://w3id.org/GConsent#atLocation"></see></summary>
    let atLocation = _prefix "atLocation"
    /// <summary>
    /// Links a consent instance to the context in which it was acquired/provided/given.
    /// <see href="https://w3id.org/GConsent#hasContext"></see></summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    /// Specifies the instant at which the consent was created/given/changed.
    /// <see href="https://w3id.org/GConsent#atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// Links the consent to personal data it is associated with it.
    /// <see href="https://w3id.org/GConsent#forPersonalData"></see></summary>
    let forPersonalData = _prefix "forPersonalData"
    /// <summary>
    /// Links personal data with the consent it is associated with.
    /// <see href="https://w3id.org/GConsent#isPersonalDataForConsent"></see></summary>
    let isPersonalDataForConsent = _prefix "isPersonalDataForConsent"
    /// <summary>
    /// Links the consent with its associated processing.
    /// <see href="https://w3id.org/GConsent#forProcessing"></see></summary>
    let forProcessing = _prefix "forProcessing"
    /// <summary>
    /// Links an action to the purpose it is associated with.
    /// <see href="https://w3id.org/GConsent#isProcessingForConsent"></see></summary>
    let isProcessingForConsent = _prefix "isProcessingForConsent"
    /// <summary>
    /// Links a consent instace to the purpose(s) it is associated with.
    /// <see href="https://w3id.org/GConsent#forPurpose"></see></summary>
    let forPurpose = _prefix "forPurpose"
    /// <summary>
    /// Links purpose with the consent instance associated with it.
    /// <see href="https://w3id.org/GConsent#isPurposeForConsent"></see></summary>
    let isPurposeForConsent = _prefix "isPurposeForConsent"
    /// <summary>
    /// Indicates an Association with another entity for a Purpose or Processing
    /// <see href="https://w3id.org/GConsent#hasAssociation"></see></summary>
    let hasAssociation = _prefix "hasAssociation"
    /// <summary>
    /// Indicates an Association is for the associated Purpose or Processing.
    /// <see href="https://w3id.org/GConsent#isAssociationFor"></see></summary>
    let isAssociationFor = _prefix "isAssociationFor"
    /// <summary>
    /// Links a data subject to their consent.
    /// <see href="https://w3id.org/GConsent#hasConsent"></see></summary>
    let hasConsent = _prefix "hasConsent"
    /// <summary>
    /// links a context to the consent instance it describes
    /// <see href="https://w3id.org/GConsent#isContextForConsent"></see></summary>
    let isContextForConsent = _prefix "isContextForConsent"
    /// <summary>
    /// Specifies the Instant or Duration in which the consent expires.
    /// <see href="https://w3id.org/GConsent#hasExpiry"></see></summary>
    let hasExpiry = _prefix "hasExpiry"
    /// <summary>
    /// Indicates the role played by specified Person or Organisation or Third Party in the specified Association.
    /// <see href="https://w3id.org/GConsent#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// Links a status to the consent that uses it.
    /// <see href="https://w3id.org/GConsent#isStatusForConsent"></see></summary>
    let isStatusForConsent = _prefix "isStatusForConsent"
    /// <summary>
    /// Specifies the medium through which the consent was given. Examples are web forms, paper documents.
    /// <see href="https://w3id.org/GConsent#inMedium"></see></summary>
    let inMedium = _prefix "inMedium"
    /// <summary>
    /// Indicates the involvement by association of a Third Party.
    /// <see href="https://w3id.org/GConsent#involvesThirdParty"></see></summary>
    let involvesThirdParty = _prefix "involvesThirdParty"
    /// <summary>
    /// Denotes that this consent instance is the previous consent for the specified consent instance.
    /// <see href="https://w3id.org/GConsent#isPreviousConsentFor"></see></summary>
    let isPreviousConsentFor = _prefix "isPreviousConsentFor"
    /// <summary>
    /// Specifies the consent instance which this instance is an update or revision of.
    /// <see href="https://w3id.org/GConsent#isUpdatedConsentFor"></see></summary>
    let isUpdatedConsentFor = _prefix "isUpdatedConsentFor"
    /// <summary>
    /// Indicates the entity or activitiy that provided the consent.
    /// <see href="https://w3id.org/GConsent#isProvidedBy"></see></summary>
    let isProvidedBy = _prefix "isProvidedBy"
    /// <summary>
    /// Links the entity or activity that gave consent to the entity or activity representing the consent (or its delegation).
    /// <see href="https://w3id.org/GConsent#providedConsent"></see></summary>
    let providedConsent = _prefix "providedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/GConsent#isProvidedByDataSubject"></see>
    /// </summary>
    let isProvidedByDataSubject = _prefix "isProvidedByDataSubject"
    /// <summary>
    /// Specifies the delegation that provided this consent.
    /// <see href="https://w3id.org/GConsent#isProvidedByDelegation"></see></summary>
    let isProvidedByDelegation = _prefix "isProvidedByDelegation"
    /// <summary>
    /// Specifies the Person that provided this consent.
    /// <see href="https://w3id.org/GConsent#isProvidedByPerson"></see></summary>
    let isProvidedByPerson = _prefix "isProvidedByPerson"
    /// <summary>
    /// Indicates the Person or Data Controller the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedTo"></see></summary>
    let isProvidedTo = _prefix "isProvidedTo"
    /// <summary>
    /// Indicates that the specified Person or Data Controller was provided the associated consent.
    /// <see href="https://w3id.org/GConsent#wasProvidedConsent"></see></summary>
    let wasProvidedConsent = _prefix "wasProvidedConsent"
    /// <summary>
    /// Indicates the Organisation the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedToController"></see></summary>
    let isProvidedToController = _prefix "isProvidedToController"
    /// <summary>
    /// Indicates the Person the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedToPerson"></see></summary>
    let isProvidedToPerson = _prefix "isProvidedToPerson"
    /// <summary>
    /// Indicates sharing of personal data with a Third Party through the association.
    /// <see href="https://w3id.org/GConsent#sharesDataWithThirdParty"></see></summary>
    let sharesDataWithThirdParty = _prefix "sharesDataWithThirdParty"
