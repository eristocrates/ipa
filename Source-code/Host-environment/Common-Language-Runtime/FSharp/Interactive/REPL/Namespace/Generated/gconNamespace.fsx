#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gcon =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/GConsent#" "gcon"
    let AdaptationOfPersonalData = _prefixId.prefix "AdaptationOfPersonalData"
    let AlignmentOfPersonalData = _prefixId.prefix "AlignmentOfPersonalData"
    let AlterationOfPersonalData = _prefixId.prefix "AlterationOfPersonalData"
    let CollectionOfPersonalData = _prefixId.prefix "CollectionOfPersonalData"
    let CombinationOfPersonalData = _prefixId.prefix "CombinationOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Consent</para>
    ///   <para>rdfs:comment : As per Article 4(11) of the GDPR, ‘consent’ of the data subject means any freely given, specific, informed and unambiguous indication of the data subject’s wishes by which he or she, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to him or her;
    ///
    /// In the case of this ontology, 'Consent' is a concept as well as a tangible entity (something that has a provenance record). To separate this distinction with relation to the data subject, the Consent class represents the consent of the data subject in its entirely, including any history and annotations for it.
    ///
    /// To link the `Consent` instance with the `DataSubject` instance, use the `isConsentForDataSubject` and `hasConsent` properties.</para>
    ///   <a href="https://w3id.org/GConsent#Consent">gcon:Consent</a>
    /// </summary>
    let Consent = _prefixId.prefix "Consent"
    let ConsentStatusExpired = _prefixId.prefix "ConsentStatusExpired"
    let ConsentStatusExplicitlyGiven = _prefixId.prefix "ConsentStatusExplicitlyGiven"

    let ConsentStatusGivenByDelegation =
        _prefixId.prefix "ConsentStatusGivenByDelegation"

    let ConsentStatusImplicitlyGiven = _prefixId.prefix "ConsentStatusImplicitlyGiven"
    let ConsentStatusInvalidated = _prefixId.prefix "ConsentStatusInvalidated"
    let ConsentStatusNotGiven = _prefixId.prefix "ConsentStatusNotGiven"
    let ConsentStatusRefused = _prefixId.prefix "ConsentStatusRefused"
    let ConsentStatusRequested = _prefixId.prefix "ConsentStatusRequested"
    let ConsentStatusUnknown = _prefixId.prefix "ConsentStatusUnknown"
    let ConsentStatusWithdrawn = _prefixId.prefix "ConsentStatusWithdrawn"
    let ConsultationOfPersonalData = _prefixId.prefix "ConsultationOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Data Adaptation</para>
    ///   <para>rdfs:comment : Represents the type of processing where Adaptation of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataAdaptation">gcon:DataAdaptation</a>
    /// </summary>
    let DataAdaptation = _prefixId.prefix "DataAdaptation"
    /// <summary>
    ///   <para>rdfs:label : Data Alignment</para>
    ///   <para>rdfs:comment : Represents the type of processing where Alignment of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataAlignment">gcon:DataAlignment</a>
    /// </summary>
    let DataAlignment = _prefixId.prefix "DataAlignment"
    /// <summary>
    ///   <para>rdfs:label : Data Alteration</para>
    ///   <para>rdfs:comment : Represents the type of processing where Alteration of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataAlteration">gcon:DataAlteration</a>
    /// </summary>
    let DataAlteration = _prefixId.prefix "DataAlteration"
    /// <summary>
    ///   <para>rdfs:label : Data Collection</para>
    ///   <para>rdfs:comment : Represents the type of processing where Collection of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataCollection">gcon:DataCollection</a>
    /// </summary>
    let DataCollection = _prefixId.prefix "DataCollection"
    /// <summary>
    ///   <para>rdfs:label : Data Combination</para>
    ///   <para>rdfs:comment : Represents the type of processing where Combination of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataCombination">gcon:DataCombination</a>
    /// </summary>
    let DataCombination = _prefixId.prefix "DataCombination"
    /// <summary>
    ///   <para>rdfs:label : Data Consultation</para>
    ///   <para>rdfs:comment : Represents the type of processing where Consultation of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataConsultation">gcon:DataConsultation</a>
    /// </summary>
    let DataConsultation = _prefixId.prefix "DataConsultation"
    /// <summary>
    ///   <para>rdfs:label : Data Controller^^xsd:string</para>
    ///   <para>rdfs:comment : A Data Controller is defined as "The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data."</para>
    ///   <a href="https://w3id.org/GConsent#DataController">gcon:DataController</a>
    /// </summary>
    let DataController = _prefixId.prefix "DataController"
    /// <summary>
    ///   <para>rdfs:label : Data Destruction</para>
    ///   <para>rdfs:comment : Represents the type of processing where Destruction of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataDestruction">gcon:DataDestruction</a>
    /// </summary>
    let DataDestruction = _prefixId.prefix "DataDestruction"
    /// <summary>
    ///   <para>rdfs:label : Data Disclosure by Transmission</para>
    ///   <para>rdfs:comment : Represents the type of processing where Disclosure by Transmission of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataDisclosureByTransmission">gcon:DataDisclosureByTransmission</a>
    /// </summary>
    let DataDisclosureByTransmission = _prefixId.prefix "DataDisclosureByTransmission"
    /// <summary>
    ///   <para>rdfs:label : Data Dissemination</para>
    ///   <para>rdfs:comment : Represents the type of processing where Dissemination of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataDissemination">gcon:DataDissemination</a>
    /// </summary>
    let DataDissemination = _prefixId.prefix "DataDissemination"
    /// <summary>
    ///   <para>rdfs:label : Data Erasure</para>
    ///   <para>rdfs:comment : Represents the type of processing where Erasure of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataErasure">gcon:DataErasure</a>
    /// </summary>
    let DataErasure = _prefixId.prefix "DataErasure"
    /// <summary>
    ///   <para>rdfs:label : Data Organisation</para>
    ///   <para>rdfs:comment : Represents the type of processing where Organisation of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataOrganisation">gcon:DataOrganisation</a>
    /// </summary>
    let DataOrganisation = _prefixId.prefix "DataOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Data Recording</para>
    ///   <para>rdfs:comment : Represents the type of processing where Recording of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataRecording">gcon:DataRecording</a>
    /// </summary>
    let DataRecording = _prefixId.prefix "DataRecording"
    /// <summary>
    ///   <para>rdfs:label : Data Restriction</para>
    ///   <para>rdfs:comment : Represents the type of processing where Restriction of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataRestriction">gcon:DataRestriction</a>
    /// </summary>
    let DataRestriction = _prefixId.prefix "DataRestriction"
    /// <summary>
    ///   <para>rdfs:label : Data Retrieval</para>
    ///   <para>rdfs:comment : Represents the type of processing where Retrieval of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataRetrieval">gcon:DataRetrieval</a>
    /// </summary>
    let DataRetrieval = _prefixId.prefix "DataRetrieval"
    /// <summary>
    ///   <para>rdfs:label : Data Sharing</para>
    ///   <para>rdfs:comment : Type of processing where sharing of data takes place with a Third Party.</para>
    ///   <a href="https://w3id.org/GConsent#DataSharing">gcon:DataSharing</a>
    /// </summary>
    let DataSharing = _prefixId.prefix "DataSharing"
    /// <summary>
    ///   <para>rdfs:label : Data Storage</para>
    ///   <para>rdfs:comment : Represents the type of processing where Storage of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataStorage">gcon:DataStorage</a>
    /// </summary>
    let DataStorage = _prefixId.prefix "DataStorage"
    /// <summary>
    ///   <para>rdfs:label : Data Structuring</para>
    ///   <para>rdfs:comment : Represents the type of processing where Structuring of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataStructuring">gcon:DataStructuring</a>
    /// </summary>
    let DataStructuring = _prefixId.prefix "DataStructuring"
    /// <summary>
    ///   <para>rdfs:label : Data Subject</para>
    ///   <para>rdfs:comment : Data Subject is defined as an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person; - according to Article 4(1) of the GDPR pertaining to the definition of Personal Data.
    ///
    /// In the case of this ontology, a Data Subject refers to the person(s) as per the definition of the GDPR. Since a Data Subject is a Person, it is defined as a subclass of foaf:Person.
    ///
    /// The Data Subject is linked to the Consent instance via the isConsentForDataSubject and hasConsent properties.</para>
    ///   <a href="https://w3id.org/GConsent#DataSubject">gcon:DataSubject</a>
    /// </summary>
    let DataSubject = _prefixId.prefix "DataSubject"
    /// <summary>
    ///   <para>rdfs:label : Data Use</para>
    ///   <para>rdfs:comment : Represents the type of processing where Use of data takes place.</para>
    ///   <a href="https://w3id.org/GConsent#DataUse">gcon:DataUse</a>
    /// </summary>
    let DataUse = _prefixId.prefix "DataUse"
    /// <summary>
    ///   <para>rdfs:label : Delegation^^xsd:string</para>
    ///   <para>rdfs:comment : A Delegation of consent occurs when another entity, whether a data subject or their representative or an automated mechanism, provides the consent on behalf of the intended Data Subject. The delegated consent is provided through the mechanism of a _delegation_. This involves three entities - the Data Subject the delegation occurs for, the entity that acts as the delegate, and the mechanism used to verify the authority to delegate. They (first two) are provided respectively by the properties `isConsentDelegationFor`, and `hasConsentGivenByDelegate`.</para>
    ///   <a href="https://w3id.org/GConsent#Delegation">gcon:Delegation</a>
    /// </summary>
    let Delegation = _prefixId.prefix "Delegation"
    let DestructionOfPersonalData = _prefixId.prefix "DestructionOfPersonalData"

    let DisclosureByTransmissionOfPersonalData =
        _prefixId.prefix "DisclosureByTransmissionOfPersonalData"

    let DisseminationOfPersonalData = _prefixId.prefix "DisseminationOfPersonalData"
    let ErasureOfPersonalData = _prefixId.prefix "ErasureOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Given Consent</para>
    ///   <para>rdfs:comment : Represents a consent entity that is considered given whether implicitly, explicitly, or by delegation.</para>
    ///   <a href="https://w3id.org/GConsent#GivenConsent">gcon:GivenConsent</a>
    /// </summary>
    let GivenConsent = _prefixId.prefix "GivenConsent"
    /// <summary>
    ///   <para>rdfs:label : Medium</para>
    ///   <para>rdfs:comment : Describes the medium through which consent was given/provided. Example: web form, recorded voice, signature on document.</para>
    ///   <a href="https://w3id.org/GConsent#Medium">gcon:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    /// <summary>
    ///   <para>rdfs:label : Minor Data Subject</para>
    ///   <para>rdfs:comment : A Minor is a Data Subject who cannot provide their own consent (that is legally valid). Therefore, their consent must be obtained via a Guardian or Legal Representative or Parent. Minor is a subclass of Data Subject.
    ///
    /// Consent given in lieu of a Minor (by their Representative) is associated with the `ConsentInstance` class/instance using the `wasGivenBy` property.
    ///
    /// The ontology currently does not capture this relationship between the Minor and their Representative. This is due to required clarifications regarding how this role should be represented. For example, the `DataSubject` cannot be subclassed to create a `Representative` class, as this would make the `DataSubject` a permanent representative for the Minor. Instead, the role of 'acting as representative' is only for the instance of the given consent. Therefore, this could be represented with a `ConsentRepresentativeRole` class that links to the `MinorDataSubject` with `roleHadDataSubject` property, and the `DataSubject` that gave the consent via the `roleHadRepresentative` property. The relationship or reason or situation of this given consent can be captured by further annotating the `ConsentRepresentativeRole` instance. This approach can also be extended to other similar situations where one `DataSubject` gives consent in lieu of another.
    ///
    /// Note: A Minor can provide their own consent in certain cases, or conversely, a minor's consent may need to be provided by a 'parental' representative in some cases.</para>
    ///   <a href="https://w3id.org/GConsent#MinorDataSubject">gcon:MinorDataSubject</a>
    /// </summary>
    let MinorDataSubject = _prefixId.prefix "MinorDataSubject"
    let OrganisationOfPersonalData = _prefixId.prefix "OrganisationOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Personal Data</para>
    ///   <para>rdfs:comment : As per Article 4(1) of the GDPR, ‘personal data’ means any information relating to an identified or identifiable natural person (‘data subject’);</para>
    ///   <a href="https://w3id.org/GConsent#PersonalData">gcon:PersonalData</a>
    /// </summary>
    let PersonalData = _prefixId.prefix "PersonalData"
    /// <summary>
    ///   <para>rdfs:label : Processing</para>
    ///   <para>rdfs:comment : Processing is defined by the GDPR (Article 4-2) as "any operation or set of operations which is performed on personal data or on sets of personal data, whether or not by automated means, such as collection, recording, organisation, structuring, storage, adaptation or alteration, retrieval, consultation, use, disclosure by transmission, dissemination or otherwise making available, alignment or combination, restriction, erasure or destruction;".
    ///
    /// Processing can be considered as the action, within an activity for example, that uses data in a particular or specific way. Therefore, processing specifies what is happening to/with the data.
    ///
    /// To define a type of processing (or its associated action), the Processing class should be subclassed for each type. Furthermore, each subclass should define a instance as a generic representative of that action. For example, "collect" as a type of processing (defined by the GDPR), is defined as the class DataCollection, which is a subclass of Processing, and has the individual CollectionOfPersonalData to represent a generic instance of the concept. This is to provide a ready-to-use ontology in terms of "collect" as an action, while also providing a way to specialise the action/processing.
    /// GConsent defines several such types of processing taken from the text of the GDPR.</para>
    ///   <a href="https://w3id.org/GConsent#Processing">gcon:Processing</a>
    /// </summary>
    let Processing = _prefixId.prefix "Processing"
    /// <summary>
    ///   <para>rdfs:label : Purpose</para>
    ///   <para>rdfs:comment : Purpose refers to the aim or goal towards which the data is processed (or associated with any other form of action).</para>
    ///   <a href="https://w3id.org/GConsent#Purpose">gcon:Purpose</a>
    /// </summary>
    let Purpose = _prefixId.prefix "Purpose"
    let RecordingOfPersonalData = _prefixId.prefix "RecordingOfPersonalData"
    let RestrictionOfPersonalData = _prefixId.prefix "RestrictionOfPersonalData"
    let RetrievalOfPersonalData = _prefixId.prefix "RetrievalOfPersonalData"
    let SharingOfPersonalData = _prefixId.prefix "SharingOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Status</para>
    ///   <para>rdfs:comment : Represents the status of consent for the data subject. This allows persisting the determination of the validatity or suitability of consent (as an entity or instance) for use in processing and other activities. Examples: consent is given, consent is requested but not given, consent was withdrawn.</para>
    ///   <a href="https://w3id.org/GConsent#Status">gcon:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : Status invalid for Processing</para>
    ///   <para>rdfs:comment : Represents consent states that are invalid for processing.</para>
    ///   <a href="https://w3id.org/GConsent#StatusInvalidForProcessing">gcon:StatusInvalidForProcessing</a>
    /// </summary>
    let StatusInvalidForProcessing = _prefixId.prefix "StatusInvalidForProcessing"
    /// <summary>
    ///   <para>rdfs:label : Status valid for Processing</para>
    ///   <para>rdfs:comment : Represents consent states that are valid for processing</para>
    ///   <a href="https://w3id.org/GConsent#StatusValidForProcessing">gcon:StatusValidForProcessing</a>
    /// </summary>
    let StatusValidForProcessing = _prefixId.prefix "StatusValidForProcessing"
    let StorageOfPersonalData = _prefixId.prefix "StorageOfPersonalData"
    let StructuringOfPersonalData = _prefixId.prefix "StructuringOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Third Party</para>
    ///   <para>rdfs:comment : Represents an Agent that is a Person or an Organisation other than the current entity (w.r.t. data protection laws).</para>
    ///   <a href="https://w3id.org/GConsent#ThirdParty">gcon:ThirdParty</a>
    /// </summary>
    let ThirdParty = _prefixId.prefix "ThirdParty"
    let UseOfPersonalData = _prefixId.prefix "UseOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : at location</para>
    ///   <para>rdfs:comment : Specifies the location at which the consent was given.</para>
    ///   <a href="https://w3id.org/GConsent#atLocation">gcon:atLocation</a>
    /// </summary>
    let atLocation = _prefixId.prefix "atLocation"
    /// <summary>
    ///   <para>rdfs:label : at time</para>
    ///   <para>rdfs:comment : Specifies the instant at which the consent was created/given/changed.</para>
    ///   <a href="https://w3id.org/GConsent#atTime">gcon:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:label : for personal data</para>
    ///   <para>rdfs:comment : Links the consent to personal data it is associated with it.</para>
    ///   <a href="https://w3id.org/GConsent#forPersonalData">gcon:forPersonalData</a>
    /// </summary>
    let forPersonalData = _prefixId.prefix "forPersonalData"
    /// <summary>
    ///   <para>rdfs:label : for processing</para>
    ///   <para>rdfs:comment : Links the consent with its associated processing.</para>
    ///   <a href="https://w3id.org/GConsent#forProcessing">gcon:forProcessing</a>
    /// </summary>
    let forProcessing = _prefixId.prefix "forProcessing"
    /// <summary>
    ///   <para>rdfs:label : for purpose</para>
    ///   <para>rdfs:comment : Links a consent instace to the purpose(s) it is associated with.</para>
    ///   <a href="https://w3id.org/GConsent#forPurpose">gcon:forPurpose</a>
    /// </summary>
    let forPurpose = _prefixId.prefix "forPurpose"
    /// <summary>
    ///   <para>rdfs:label : has association</para>
    ///   <para>rdfs:comment : Indicates an Association with another entity for a Purpose or Processing</para>
    ///   <a href="https://w3id.org/GConsent#hasAssociation">gcon:hasAssociation</a>
    /// </summary>
    let hasAssociation = _prefixId.prefix "hasAssociation"
    /// <summary>
    ///   <para>rdfs:label : has consent</para>
    ///   <para>rdfs:comment : Links a data subject to their consent.</para>
    ///   <a href="https://w3id.org/GConsent#hasConsent">gcon:hasConsent</a>
    /// </summary>
    let hasConsent = _prefixId.prefix "hasConsent"
    /// <summary>
    ///   <para>rdfs:label : has context</para>
    ///   <para>rdfs:comment : Links a consent instance to the context in which it was acquired/provided/given.</para>
    ///   <a href="https://w3id.org/GConsent#hasContext">gcon:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : has expiry</para>
    ///   <para>rdfs:comment : Specifies the Instant or Duration in which the consent expires.</para>
    ///   <a href="https://w3id.org/GConsent#hasExpiry">gcon:hasExpiry</a>
    /// </summary>
    let hasExpiry = _prefixId.prefix "hasExpiry"
    /// <summary>
    ///   <para>rdfs:label : hasRole</para>
    ///   <para>rdfs:comment : Indicates the role played by specified Person or Organisation or Third Party in the specified Association.</para>
    ///   <a href="https://w3id.org/GConsent#hasRole">gcon:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has status</para>
    ///   <para>rdfs:comment : Denotes the state or status of consent.</para>
    ///   <a href="https://w3id.org/GConsent#hasStatus">gcon:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : in medium</para>
    ///   <para>rdfs:comment : Specifies the medium through which the consent was given. Examples are web forms, paper documents.</para>
    ///   <a href="https://w3id.org/GConsent#inMedium">gcon:inMedium</a>
    /// </summary>
    let inMedium = _prefixId.prefix "inMedium"
    /// <summary>
    ///   <para>rdfs:label : involves third party</para>
    ///   <para>rdfs:comment : Indicates the involvement by association of a Third Party.</para>
    ///   <a href="https://w3id.org/GConsent#involvesThirdParty">gcon:involvesThirdParty</a>
    /// </summary>
    let involvesThirdParty = _prefixId.prefix "involvesThirdParty"
    /// <summary>
    ///   <para>rdfs:label : is association for</para>
    ///   <para>rdfs:comment : Indicates an Association is for the associated Purpose or Processing.</para>
    ///   <a href="https://w3id.org/GConsent#isAssociationFor">gcon:isAssociationFor</a>
    /// </summary>
    let isAssociationFor = _prefixId.prefix "isAssociationFor"
    /// <summary>
    ///   <para>rdfs:label : is consent for data subject</para>
    ///   <para>rdfs:comment : Links a consent instance with the data subject it is associated with.</para>
    ///   <a href="https://w3id.org/GConsent#isConsentForDataSubject">gcon:isConsentForDataSubject</a>
    /// </summary>
    let isConsentForDataSubject = _prefixId.prefix "isConsentForDataSubject"
    /// <summary>
    ///   <para>rdfs:label : is context for consent</para>
    ///   <para>rdfs:comment : links a context to the consent instance it describes</para>
    ///   <a href="https://w3id.org/GConsent#isContextForConsent">gcon:isContextForConsent</a>
    /// </summary>
    let isContextForConsent = _prefixId.prefix "isContextForConsent"
    /// <summary>
    ///   <para>rdfs:label : is personal data for consent</para>
    ///   <para>rdfs:comment : Links personal data with the consent it is associated with.</para>
    ///   <a href="https://w3id.org/GConsent#isPersonalDataForConsent">gcon:isPersonalDataForConsent</a>
    /// </summary>
    let isPersonalDataForConsent = _prefixId.prefix "isPersonalDataForConsent"
    /// <summary>
    ///   <para>rdfs:label : is previous consent for</para>
    ///   <para>rdfs:comment : Denotes that this consent instance is the previous consent for the specified consent instance.</para>
    ///   <a href="https://w3id.org/GConsent#isPreviousConsentFor">gcon:isPreviousConsentFor</a>
    /// </summary>
    let isPreviousConsentFor = _prefixId.prefix "isPreviousConsentFor"
    /// <summary>
    ///   <para>rdfs:label : is action for purpose</para>
    ///   <para>rdfs:comment : Links an action to the purpose it is associated with.</para>
    ///   <a href="https://w3id.org/GConsent#isProcessingForConsent">gcon:isProcessingForConsent</a>
    /// </summary>
    let isProcessingForConsent = _prefixId.prefix "isProcessingForConsent"
    /// <summary>
    ///   <para>rdfs:label : is provided by</para>
    ///   <para>rdfs:comment : Indicates the entity or activitiy that provided the consent.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedBy">gcon:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    let isProvidedByDataSubject = _prefixId.prefix "isProvidedByDataSubject"
    /// <summary>
    ///   <para>rdfs:label : is provided by delegation</para>
    ///   <para>rdfs:comment : Specifies the delegation that provided this consent.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedByDelegation">gcon:isProvidedByDelegation</a>
    /// </summary>
    let isProvidedByDelegation = _prefixId.prefix "isProvidedByDelegation"
    /// <summary>
    ///   <para>rdfs:label : is provided by person</para>
    ///   <para>rdfs:comment : Specifies the Person that provided this consent.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedByPerson">gcon:isProvidedByPerson</a>
    /// </summary>
    let isProvidedByPerson = _prefixId.prefix "isProvidedByPerson"
    /// <summary>
    ///   <para>rdfs:label : is provided to</para>
    ///   <para>rdfs:comment : Indicates the Person or Data Controller the consent was provided to.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedTo">gcon:isProvidedTo</a>
    /// </summary>
    let isProvidedTo = _prefixId.prefix "isProvidedTo"
    /// <summary>
    ///   <para>rdfs:label : is provided to controller</para>
    ///   <para>rdfs:comment : Indicates the Organisation the consent was provided to.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedToController">gcon:isProvidedToController</a>
    /// </summary>
    let isProvidedToController = _prefixId.prefix "isProvidedToController"
    /// <summary>
    ///   <para>rdfs:label : is provided to person</para>
    ///   <para>rdfs:comment : Indicates the Person the consent was provided to.</para>
    ///   <a href="https://w3id.org/GConsent#isProvidedToPerson">gcon:isProvidedToPerson</a>
    /// </summary>
    let isProvidedToPerson = _prefixId.prefix "isProvidedToPerson"
    /// <summary>
    ///   <para>rdfs:label : is purpose for consent</para>
    ///   <para>rdfs:comment : Links purpose with the consent instance associated with it.</para>
    ///   <a href="https://w3id.org/GConsent#isPurposeForConsent">gcon:isPurposeForConsent</a>
    /// </summary>
    let isPurposeForConsent = _prefixId.prefix "isPurposeForConsent"
    /// <summary>
    ///   <para>rdfs:label : is status for consent</para>
    ///   <para>rdfs:comment : Links a status to the consent that uses it.</para>
    ///   <a href="https://w3id.org/GConsent#isStatusForConsent">gcon:isStatusForConsent</a>
    /// </summary>
    let isStatusForConsent = _prefixId.prefix "isStatusForConsent"
    /// <summary>
    ///   <para>rdfs:label : is updated consent for</para>
    ///   <para>rdfs:comment : Specifies the consent instance which this instance is an update or revision of.</para>
    ///   <a href="https://w3id.org/GConsent#isUpdatedConsentFor">gcon:isUpdatedConsentFor</a>
    /// </summary>
    let isUpdatedConsentFor = _prefixId.prefix "isUpdatedConsentFor"
    /// <summary>
    ///   <para>rdfs:label : gave consent</para>
    ///   <para>rdfs:comment : Links the entity or activity that gave consent to the entity or activity representing the consent (or its delegation).</para>
    ///   <a href="https://w3id.org/GConsent#providedConsent">gcon:providedConsent</a>
    /// </summary>
    let providedConsent = _prefixId.prefix "providedConsent"
    /// <summary>
    ///   <para>rdfs:comment : Indicates sharing of personal data with a Third Party through the association.</para>
    ///   <a href="https://w3id.org/GConsent#sharesDataWithThirdParty">gcon:sharesDataWithThirdParty</a>
    /// </summary>
    let sharesDataWithThirdParty = _prefixId.prefix "sharesDataWithThirdParty"
    /// <summary>
    ///   <para>rdfs:label : was provided consent</para>
    ///   <para>rdfs:comment : Indicates that the specified Person or Data Controller was provided the associated consent.</para>
    ///   <a href="https://w3id.org/GConsent#wasProvidedConsent">gcon:wasProvidedConsent</a>
    /// </summary>
    let wasProvidedConsent = _prefixId.prefix "wasProvidedConsent"
