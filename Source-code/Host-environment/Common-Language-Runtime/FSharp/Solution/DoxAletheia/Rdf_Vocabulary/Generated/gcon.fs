namespace https.w3id.org.GConsent.hash

open DoxAletheia.Rdf_Vocabulary

module gcon =
    let _namespace_name = "https://w3id.org/GConsent#"

    /// <summary>
    /// Represents Adaptation Of personal data.
    /// <see href="https://w3id.org/GConsent#AdaptationOfPersonalData"></see></summary>
    let AdaptationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "AdaptationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Alignment Of personal data.
    /// <see href="https://w3id.org/GConsent#AlignmentOfPersonalData"></see></summary>
    let AlignmentOfPersonalData =
        Namespaced_IRI.parse _namespace_name "AlignmentOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Alteration Of personal data.
    /// <see href="https://w3id.org/GConsent#AlterationOfPersonalData"></see></summary>
    let AlterationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "AlterationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Collection Of personal data.
    /// <see href="https://w3id.org/GConsent#CollectionOfPersonalData"></see></summary>
    let CollectionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "CollectionOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Combination Of personal data.
    /// <see href="https://w3id.org/GConsent#CombinationOfPersonalData"></see></summary>
    let CombinationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "CombinationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Consultation Of personal data.
    /// <see href="https://w3id.org/GConsent#ConsultationOfPersonalData"></see></summary>
    let ConsultationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "ConsultationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Destruction Of personal data.
    /// <see href="https://w3id.org/GConsent#DestructionOfPersonalData"></see></summary>
    let DestructionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "DestructionOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Disclosure by Transmission Of personal data.
    /// <see href="https://w3id.org/GConsent#DisclosureByTransmissionOfPersonalData"></see></summary>
    let DisclosureByTransmissionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "DisclosureByTransmissionOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Dissemination Of personal data.
    /// <see href="https://w3id.org/GConsent#DisseminationOfPersonalData"></see></summary>
    let DisseminationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "DisseminationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Erasure Of personal data.
    /// <see href="https://w3id.org/GConsent#ErasureOfPersonalData"></see></summary>
    let ErasureOfPersonalData =
        Namespaced_IRI.parse _namespace_name "ErasureOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Organisation Of personal data.
    /// <see href="https://w3id.org/GConsent#OrganisationOfPersonalData"></see></summary>
    let OrganisationOfPersonalData =
        Namespaced_IRI.parse _namespace_name "OrganisationOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Recording Of personal data.
    /// <see href="https://w3id.org/GConsent#RecordingOfPersonalData"></see></summary>
    let RecordingOfPersonalData =
        Namespaced_IRI.parse _namespace_name "RecordingOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Restriction Of personal data.
    /// <see href="https://w3id.org/GConsent#RestrictionOfPersonalData"></see></summary>
    let RestrictionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "RestrictionOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Retrieval Of personal data.
    /// <see href="https://w3id.org/GConsent#RetrievalOfPersonalData"></see></summary>
    let RetrievalOfPersonalData =
        Namespaced_IRI.parse _namespace_name "RetrievalOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents sharing of personal data
    /// <see href="https://w3id.org/GConsent#SharingOfPersonalData"></see></summary>
    let SharingOfPersonalData =
        Namespaced_IRI.parse _namespace_name "SharingOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Storage Of personal data.
    /// <see href="https://w3id.org/GConsent#StorageOfPersonalData"></see></summary>
    let StorageOfPersonalData =
        Namespaced_IRI.parse _namespace_name "StorageOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Structuring Of personal data.
    /// <see href="https://w3id.org/GConsent#StructuringOfPersonalData"></see></summary>
    let StructuringOfPersonalData =
        Namespaced_IRI.parse _namespace_name "StructuringOfPersonalData" |> NamespacedName

    /// <summary>
    /// Represents Use Of personal data.
    /// <see href="https://w3id.org/GConsent#UseOfPersonalData"></see></summary>
    let UseOfPersonalData =
        Namespaced_IRI.parse _namespace_name "UseOfPersonalData" |> NamespacedName

    /// <summary>
    /// Indicates the consent has expired.
    /// <see href="https://w3id.org/GConsent#ConsentStatusExpired"></see></summary>
    let ConsentStatusExpired =
        Namespaced_IRI.parse _namespace_name "ConsentStatusExpired" |> NamespacedName

    /// <summary>
    /// Indicates consent is explicitly given.
    /// <see href="https://w3id.org/GConsent#ConsentStatusExplicitlyGiven"></see></summary>
    let ConsentStatusExplicitlyGiven =
        Namespaced_IRI.parse _namespace_name "ConsentStatusExplicitlyGiven" |> NamespacedName

    /// <summary>
    /// Indicates consent is given via delegation.
    /// <see href="https://w3id.org/GConsent#ConsentStatusGivenByDelegation"></see></summary>
    let ConsentStatusGivenByDelegation =
        Namespaced_IRI.parse _namespace_name "ConsentStatusGivenByDelegation" |> NamespacedName

    /// <summary>
    /// Indicates consent is given via an implicit action or assumption.
    /// <see href="https://w3id.org/GConsent#ConsentStatusImplicitlyGiven"></see></summary>
    let ConsentStatusImplicitlyGiven =
        Namespaced_IRI.parse _namespace_name "ConsentStatusImplicitlyGiven" |> NamespacedName

    /// <summary>
    /// Indicates the consent has been invalidated.
    /// <see href="https://w3id.org/GConsent#ConsentStatusInvalidated"></see></summary>
    let ConsentStatusInvalidated =
        Namespaced_IRI.parse _namespace_name "ConsentStatusInvalidated" |> NamespacedName

    /// <summary>
    /// Indicates that consent has not been given.
    /// <see href="https://w3id.org/GConsent#ConsentStatusNotGiven"></see></summary>
    let ConsentStatusNotGiven =
        Namespaced_IRI.parse _namespace_name "ConsentStatusNotGiven" |> NamespacedName

    /// <summary>
    /// Indicates that consent has been refused (to be given).
    /// <see href="https://w3id.org/GConsent#ConsentStatusRefused"></see></summary>
    let ConsentStatusRefused =
        Namespaced_IRI.parse _namespace_name "ConsentStatusRefused" |> NamespacedName

    /// <summary>
    /// Indicates consent has been requested but has not been given (yet).
    /// <see href="https://w3id.org/GConsent#ConsentStatusRequested"></see></summary>
    let ConsentStatusRequested =
        Namespaced_IRI.parse _namespace_name "ConsentStatusRequested" |> NamespacedName

    /// <summary>
    /// Indicates the consent status is unknown.
    /// <see href="https://w3id.org/GConsent#ConsentStatusUnknown"></see></summary>
    let ConsentStatusUnknown =
        Namespaced_IRI.parse _namespace_name "ConsentStatusUnknown" |> NamespacedName

    /// <summary>
    /// Indicates consent has been withdrawn.
    /// <see href="https://w3id.org/GConsent#ConsentStatusWithdrawn"></see></summary>
    let ConsentStatusWithdrawn =
        Namespaced_IRI.parse _namespace_name "ConsentStatusWithdrawn" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Adaptation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAdaptation"></see></summary>
    let DataAdaptation =
        Namespaced_IRI.parse _namespace_name "DataAdaptation" |> NamespacedName

    /// <summary>
    /// Processing is defined by the GDPR (Article 4-2) as "any operation or set of operations which is performed on personal data or on sets of personal data, whether or not by automated means, such as collection, recording, organisation, structuring, storage, adaptation or alteration, retrieval, consultation, use, disclosure by transmission, dissemination or otherwise making available, alignment or combination, restriction, erasure or destruction;".
    ///
    /// Processing can be considered as the action, within an activity for example, that uses data in a particular or specific way. Therefore, processing specifies what is happening to/with the data.
    ///
    /// To define a type of processing (or its associated action), the Processing class should be subclassed for each type. Furthermore, each subclass should define a instance as a generic representative of that action. For example, "collect" as a type of processing (defined by the GDPR), is defined as the class DataCollection, which is a subclass of Processing, and has the individual CollectionOfPersonalData to represent a generic instance of the concept. This is to provide a ready-to-use ontology in terms of "collect" as an action, while also providing a way to specialise the action/processing.
    /// GConsent defines several such types of processing taken from the text of the GDPR.
    /// <see href="https://w3id.org/GConsent#Processing"></see></summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Alignment of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAlignment"></see></summary>
    let DataAlignment =
        Namespaced_IRI.parse _namespace_name "DataAlignment" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Alteration of data takes place.
    /// <see href="https://w3id.org/GConsent#DataAlteration"></see></summary>
    let DataAlteration =
        Namespaced_IRI.parse _namespace_name "DataAlteration" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Collection of data takes place.
    /// <see href="https://w3id.org/GConsent#DataCollection"></see></summary>
    let DataCollection =
        Namespaced_IRI.parse _namespace_name "DataCollection" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Combination of data takes place.
    /// <see href="https://w3id.org/GConsent#DataCombination"></see></summary>
    let DataCombination =
        Namespaced_IRI.parse _namespace_name "DataCombination" |> NamespacedName

    /// <summary>
    /// As per Article 4(11) of the GDPR, ‘consent’ of the data subject means any freely given, specific, informed and unambiguous indication of the data subject’s wishes by which he or she, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to him or her;
    ///
    /// In the case of this ontology, 'Consent' is a concept as well as a tangible entity (something that has a provenance record). To separate this distinction with relation to the data subject, the Consent class represents the consent of the data subject in its entirely, including any history and annotations for it.
    ///
    /// To link the `Consent` instance with the `DataSubject` instance, use the `isConsentForDataSubject` and `hasConsent` properties.
    /// <see href="https://w3id.org/GConsent#Consent"></see></summary>
    let Consent = Namespaced_IRI.parse _namespace_name "Consent" |> NamespacedName
    /// <summary>
    /// Denotes the state or status of consent.
    /// <see href="https://w3id.org/GConsent#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName
    /// <summary>
    /// Represents the status of consent for the data subject. This allows persisting the determination of the validatity or suitability of consent (as an entity or instance) for use in processing and other activities. Examples: consent is given, consent is requested but not given, consent was withdrawn.
    /// <see href="https://w3id.org/GConsent#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// Links a consent instance with the data subject it is associated with.
    /// <see href="https://w3id.org/GConsent#isConsentForDataSubject"></see></summary>
    let isConsentForDataSubject =
        Namespaced_IRI.parse _namespace_name "isConsentForDataSubject" |> NamespacedName

    /// <summary>
    /// Data Subject is defined as an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person; - according to Article 4(1) of the GDPR pertaining to the definition of Personal Data.
    ///
    /// In the case of this ontology, a Data Subject refers to the person(s) as per the definition of the GDPR. Since a Data Subject is a Person, it is defined as a subclass of foaf:Person.
    ///
    /// The Data Subject is linked to the Consent instance via the isConsentForDataSubject and hasConsent properties.
    /// <see href="https://w3id.org/GConsent#DataSubject"></see></summary>
    let DataSubject =
        Namespaced_IRI.parse _namespace_name "DataSubject" |> NamespacedName

    /// <summary>
    /// Represents consent states that are invalid for processing.
    /// <see href="https://w3id.org/GConsent#StatusInvalidForProcessing"></see></summary>
    let StatusInvalidForProcessing =
        Namespaced_IRI.parse _namespace_name "StatusInvalidForProcessing" |> NamespacedName

    /// <summary>
    /// Represents consent states that are valid for processing
    /// <see href="https://w3id.org/GConsent#StatusValidForProcessing"></see></summary>
    let StatusValidForProcessing =
        Namespaced_IRI.parse _namespace_name "StatusValidForProcessing" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Consultation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataConsultation"></see></summary>
    let DataConsultation =
        Namespaced_IRI.parse _namespace_name "DataConsultation" |> NamespacedName

    /// <summary>
    /// A Data Controller is defined as "The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data."
    /// <see href="https://w3id.org/GConsent#DataController"></see></summary>
    let DataController =
        Namespaced_IRI.parse _namespace_name "DataController" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Destruction of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDestruction"></see></summary>
    let DataDestruction =
        Namespaced_IRI.parse _namespace_name "DataDestruction" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Disclosure by Transmission of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDisclosureByTransmission"></see></summary>
    let DataDisclosureByTransmission =
        Namespaced_IRI.parse _namespace_name "DataDisclosureByTransmission" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Dissemination of data takes place.
    /// <see href="https://w3id.org/GConsent#DataDissemination"></see></summary>
    let DataDissemination =
        Namespaced_IRI.parse _namespace_name "DataDissemination" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Erasure of data takes place.
    /// <see href="https://w3id.org/GConsent#DataErasure"></see></summary>
    let DataErasure =
        Namespaced_IRI.parse _namespace_name "DataErasure" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Organisation of data takes place.
    /// <see href="https://w3id.org/GConsent#DataOrganisation"></see></summary>
    let DataOrganisation =
        Namespaced_IRI.parse _namespace_name "DataOrganisation" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Recording of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRecording"></see></summary>
    let DataRecording =
        Namespaced_IRI.parse _namespace_name "DataRecording" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Restriction of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRestriction"></see></summary>
    let DataRestriction =
        Namespaced_IRI.parse _namespace_name "DataRestriction" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Retrieval of data takes place.
    /// <see href="https://w3id.org/GConsent#DataRetrieval"></see></summary>
    let DataRetrieval =
        Namespaced_IRI.parse _namespace_name "DataRetrieval" |> NamespacedName

    /// <summary>
    /// Type of processing where sharing of data takes place with a Third Party.
    /// <see href="https://w3id.org/GConsent#DataSharing"></see></summary>
    let DataSharing =
        Namespaced_IRI.parse _namespace_name "DataSharing" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Storage of data takes place.
    /// <see href="https://w3id.org/GConsent#DataStorage"></see></summary>
    let DataStorage =
        Namespaced_IRI.parse _namespace_name "DataStorage" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Structuring of data takes place.
    /// <see href="https://w3id.org/GConsent#DataStructuring"></see></summary>
    let DataStructuring =
        Namespaced_IRI.parse _namespace_name "DataStructuring" |> NamespacedName

    /// <summary>
    /// Represents the type of processing where Use of data takes place.
    /// <see href="https://w3id.org/GConsent#DataUse"></see></summary>
    let DataUse = Namespaced_IRI.parse _namespace_name "DataUse" |> NamespacedName
    /// <summary>
    /// A Delegation of consent occurs when another entity, whether a data subject or their representative or an automated mechanism, provides the consent on behalf of the intended Data Subject. The delegated consent is provided through the mechanism of a _delegation_. This involves three entities - the Data Subject the delegation occurs for, the entity that acts as the delegate, and the mechanism used to verify the authority to delegate. They (first two) are provided respectively by the properties `isConsentDelegationFor`, and `hasConsentGivenByDelegate`.
    /// <see href="https://w3id.org/GConsent#Delegation"></see></summary>
    let Delegation = Namespaced_IRI.parse _namespace_name "Delegation" |> NamespacedName

    /// <summary>
    /// Represents a consent entity that is considered given whether implicitly, explicitly, or by delegation.
    /// <see href="https://w3id.org/GConsent#GivenConsent"></see></summary>
    let GivenConsent =
        Namespaced_IRI.parse _namespace_name "GivenConsent" |> NamespacedName

    /// <summary>
    /// Describes the medium through which consent was given/provided. Example: web form, recorded voice, signature on document.
    /// <see href="https://w3id.org/GConsent#Medium"></see></summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName

    /// <summary>
    /// A Minor is a Data Subject who cannot provide their own consent (that is legally valid). Therefore, their consent must be obtained via a Guardian or Legal Representative or Parent. Minor is a subclass of Data Subject.
    ///
    /// Consent given in lieu of a Minor (by their Representative) is associated with the `ConsentInstance` class/instance using the `wasGivenBy` property.
    ///
    /// The ontology currently does not capture this relationship between the Minor and their Representative. This is due to required clarifications regarding how this role should be represented. For example, the `DataSubject` cannot be subclassed to create a `Representative` class, as this would make the `DataSubject` a permanent representative for the Minor. Instead, the role of 'acting as representative' is only for the instance of the given consent. Therefore, this could be represented with a `ConsentRepresentativeRole` class that links to the `MinorDataSubject` with `roleHadDataSubject` property, and the `DataSubject` that gave the consent via the `roleHadRepresentative` property. The relationship or reason or situation of this given consent can be captured by further annotating the `ConsentRepresentativeRole` instance. This approach can also be extended to other similar situations where one `DataSubject` gives consent in lieu of another.
    ///
    /// Note: A Minor can provide their own consent in certain cases, or conversely, a minor's consent may need to be provided by a 'parental' representative in some cases.
    /// <see href="https://w3id.org/GConsent#MinorDataSubject"></see></summary>
    let MinorDataSubject =
        Namespaced_IRI.parse _namespace_name "MinorDataSubject" |> NamespacedName

    /// <summary>
    /// As per Article 4(1) of the GDPR, ‘personal data’ means any information relating to an identified or identifiable natural person (‘data subject’);
    /// <see href="https://w3id.org/GConsent#PersonalData"></see></summary>
    let PersonalData =
        Namespaced_IRI.parse _namespace_name "PersonalData" |> NamespacedName

    /// <summary>
    /// Purpose refers to the aim or goal towards which the data is processed (or associated with any other form of action).
    /// <see href="https://w3id.org/GConsent#Purpose"></see></summary>
    let Purpose = Namespaced_IRI.parse _namespace_name "Purpose" |> NamespacedName
    /// <summary>
    /// Represents an Agent that is a Person or an Organisation other than the current entity (w.r.t. data protection laws).
    /// <see href="https://w3id.org/GConsent#ThirdParty"></see></summary>
    let ThirdParty = Namespaced_IRI.parse _namespace_name "ThirdParty" |> NamespacedName
    /// <summary>
    /// Specifies the location at which the consent was given.
    /// <see href="https://w3id.org/GConsent#atLocation"></see></summary>
    let atLocation = Namespaced_IRI.parse _namespace_name "atLocation" |> NamespacedName
    /// <summary>
    /// Links a consent instance to the context in which it was acquired/provided/given.
    /// <see href="https://w3id.org/GConsent#hasContext"></see></summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName
    /// <summary>
    /// Specifies the instant at which the consent was created/given/changed.
    /// <see href="https://w3id.org/GConsent#atTime"></see></summary>
    let atTime = Namespaced_IRI.parse _namespace_name "atTime" |> NamespacedName

    /// <summary>
    /// Links the consent to personal data it is associated with it.
    /// <see href="https://w3id.org/GConsent#forPersonalData"></see></summary>
    let forPersonalData =
        Namespaced_IRI.parse _namespace_name "forPersonalData" |> NamespacedName

    /// <summary>
    /// Links personal data with the consent it is associated with.
    /// <see href="https://w3id.org/GConsent#isPersonalDataForConsent"></see></summary>
    let isPersonalDataForConsent =
        Namespaced_IRI.parse _namespace_name "isPersonalDataForConsent" |> NamespacedName

    /// <summary>
    /// Links the consent with its associated processing.
    /// <see href="https://w3id.org/GConsent#forProcessing"></see></summary>
    let forProcessing =
        Namespaced_IRI.parse _namespace_name "forProcessing" |> NamespacedName

    /// <summary>
    /// Links an action to the purpose it is associated with.
    /// <see href="https://w3id.org/GConsent#isProcessingForConsent"></see></summary>
    let isProcessingForConsent =
        Namespaced_IRI.parse _namespace_name "isProcessingForConsent" |> NamespacedName

    /// <summary>
    /// Links a consent instace to the purpose(s) it is associated with.
    /// <see href="https://w3id.org/GConsent#forPurpose"></see></summary>
    let forPurpose = Namespaced_IRI.parse _namespace_name "forPurpose" |> NamespacedName

    /// <summary>
    /// Links purpose with the consent instance associated with it.
    /// <see href="https://w3id.org/GConsent#isPurposeForConsent"></see></summary>
    let isPurposeForConsent =
        Namespaced_IRI.parse _namespace_name "isPurposeForConsent" |> NamespacedName

    /// <summary>
    /// Indicates an Association with another entity for a Purpose or Processing
    /// <see href="https://w3id.org/GConsent#hasAssociation"></see></summary>
    let hasAssociation =
        Namespaced_IRI.parse _namespace_name "hasAssociation" |> NamespacedName

    /// <summary>
    /// Indicates an Association is for the associated Purpose or Processing.
    /// <see href="https://w3id.org/GConsent#isAssociationFor"></see></summary>
    let isAssociationFor =
        Namespaced_IRI.parse _namespace_name "isAssociationFor" |> NamespacedName

    /// <summary>
    /// Links a data subject to their consent.
    /// <see href="https://w3id.org/GConsent#hasConsent"></see></summary>
    let hasConsent = Namespaced_IRI.parse _namespace_name "hasConsent" |> NamespacedName

    /// <summary>
    /// links a context to the consent instance it describes
    /// <see href="https://w3id.org/GConsent#isContextForConsent"></see></summary>
    let isContextForConsent =
        Namespaced_IRI.parse _namespace_name "isContextForConsent" |> NamespacedName

    /// <summary>
    /// Specifies the Instant or Duration in which the consent expires.
    /// <see href="https://w3id.org/GConsent#hasExpiry"></see></summary>
    let hasExpiry = Namespaced_IRI.parse _namespace_name "hasExpiry" |> NamespacedName
    /// <summary>
    /// Indicates the role played by specified Person or Organisation or Third Party in the specified Association.
    /// <see href="https://w3id.org/GConsent#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    /// Links a status to the consent that uses it.
    /// <see href="https://w3id.org/GConsent#isStatusForConsent"></see></summary>
    let isStatusForConsent =
        Namespaced_IRI.parse _namespace_name "isStatusForConsent" |> NamespacedName

    /// <summary>
    /// Specifies the medium through which the consent was given. Examples are web forms, paper documents.
    /// <see href="https://w3id.org/GConsent#inMedium"></see></summary>
    let inMedium = Namespaced_IRI.parse _namespace_name "inMedium" |> NamespacedName

    /// <summary>
    /// Indicates the involvement by association of a Third Party.
    /// <see href="https://w3id.org/GConsent#involvesThirdParty"></see></summary>
    let involvesThirdParty =
        Namespaced_IRI.parse _namespace_name "involvesThirdParty" |> NamespacedName

    /// <summary>
    /// Denotes that this consent instance is the previous consent for the specified consent instance.
    /// <see href="https://w3id.org/GConsent#isPreviousConsentFor"></see></summary>
    let isPreviousConsentFor =
        Namespaced_IRI.parse _namespace_name "isPreviousConsentFor" |> NamespacedName

    /// <summary>
    /// Specifies the consent instance which this instance is an update or revision of.
    /// <see href="https://w3id.org/GConsent#isUpdatedConsentFor"></see></summary>
    let isUpdatedConsentFor =
        Namespaced_IRI.parse _namespace_name "isUpdatedConsentFor" |> NamespacedName

    /// <summary>
    /// Indicates the entity or activitiy that provided the consent.
    /// <see href="https://w3id.org/GConsent#isProvidedBy"></see></summary>
    let isProvidedBy =
        Namespaced_IRI.parse _namespace_name "isProvidedBy" |> NamespacedName

    /// <summary>
    /// Links the entity or activity that gave consent to the entity or activity representing the consent (or its delegation).
    /// <see href="https://w3id.org/GConsent#providedConsent"></see></summary>
    let providedConsent =
        Namespaced_IRI.parse _namespace_name "providedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/GConsent#isProvidedByDataSubject"></see>
    /// </summary>
    let isProvidedByDataSubject =
        Namespaced_IRI.parse _namespace_name "isProvidedByDataSubject" |> NamespacedName

    /// <summary>
    /// Specifies the delegation that provided this consent.
    /// <see href="https://w3id.org/GConsent#isProvidedByDelegation"></see></summary>
    let isProvidedByDelegation =
        Namespaced_IRI.parse _namespace_name "isProvidedByDelegation" |> NamespacedName

    /// <summary>
    /// Specifies the Person that provided this consent.
    /// <see href="https://w3id.org/GConsent#isProvidedByPerson"></see></summary>
    let isProvidedByPerson =
        Namespaced_IRI.parse _namespace_name "isProvidedByPerson" |> NamespacedName

    /// <summary>
    /// Indicates the Person or Data Controller the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedTo"></see></summary>
    let isProvidedTo =
        Namespaced_IRI.parse _namespace_name "isProvidedTo" |> NamespacedName

    /// <summary>
    /// Indicates that the specified Person or Data Controller was provided the associated consent.
    /// <see href="https://w3id.org/GConsent#wasProvidedConsent"></see></summary>
    let wasProvidedConsent =
        Namespaced_IRI.parse _namespace_name "wasProvidedConsent" |> NamespacedName

    /// <summary>
    /// Indicates the Organisation the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedToController"></see></summary>
    let isProvidedToController =
        Namespaced_IRI.parse _namespace_name "isProvidedToController" |> NamespacedName

    /// <summary>
    /// Indicates the Person the consent was provided to.
    /// <see href="https://w3id.org/GConsent#isProvidedToPerson"></see></summary>
    let isProvidedToPerson =
        Namespaced_IRI.parse _namespace_name "isProvidedToPerson" |> NamespacedName

    /// <summary>
    /// Indicates sharing of personal data with a Third Party through the association.
    /// <see href="https://w3id.org/GConsent#sharesDataWithThirdParty"></see></summary>
    let sharesDataWithThirdParty =
        Namespaced_IRI.parse _namespace_name "sharesDataWithThirdParty" |> NamespacedName
