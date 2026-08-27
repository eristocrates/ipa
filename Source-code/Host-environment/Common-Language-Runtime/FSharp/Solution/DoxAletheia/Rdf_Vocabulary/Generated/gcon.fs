namespace https.w3id.org.GConsent.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gcon =
    let _namespace_iri = Namespace_Iri gcon |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:GConsent#AdaptationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataAdaptation</para>
    ///   <para>"Represents Adaptation Of personal data."</para>
    /// labels<para>"Adaptation Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#AdaptationOfPersonalData">https://w3id.org/GConsent#AdaptationOfPersonalData</seealso>
    let AdaptationOfPersonalData =
        Prefixed_Name(gcon, "AdaptationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#AlignmentOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#DataAlignment</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents Alignment Of personal data."</para>
    /// labels<para>"Alignment Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#AlignmentOfPersonalData">https://w3id.org/GConsent#AlignmentOfPersonalData</seealso>
    let AlignmentOfPersonalData =
        Prefixed_Name(gcon, "AlignmentOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#AlterationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataAlteration</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Alteration Of personal data."</para>
    /// labels<para>"Alteration Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#AlterationOfPersonalData">https://w3id.org/GConsent#AlterationOfPersonalData</seealso>
    let AlterationOfPersonalData =
        Prefixed_Name(gcon, "AlterationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#CollectionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#DataCollection</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents Collection Of personal data."</para>
    /// labels<para>"Collection Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#CollectionOfPersonalData">https://w3id.org/GConsent#CollectionOfPersonalData</seealso>
    let CollectionOfPersonalData =
        Prefixed_Name(gcon, "CollectionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#CombinationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataCombination</para>
    ///   <para>"Represents Combination Of personal data."</para>
    /// labels<para>"Combination Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#CombinationOfPersonalData">https://w3id.org/GConsent#CombinationOfPersonalData</seealso>
    let CombinationOfPersonalData =
        Prefixed_Name(gcon, "CombinationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#Consent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"As per Article 4(11) of the GDPR, ‘consent’ of the data subject means any freely given, specific, informed and unambiguous indication of the data subject’s wishes by which he or she, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to him or her;
    ///
    /// In the case of this ontology, 'Consent' is a concept as well as a tangible entity (something that has a provenance record). To separate this distinction with relation to the data subject, the Consent class represents the consent of the data subject in its entirely, including any history and annotations for it.
    ///
    /// To link the `Consent` instance with the `DataSubject` instance, use the `isConsentForDataSubject` and `hasConsent` properties."</para>
    /// labels<para>"Consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Consent">https://w3id.org/GConsent#Consent</seealso>
    let Consent = Prefixed_Name(gcon, "Consent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusExpired</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>"Indicates the consent has expired."</para>
    /// labels<para>"Expired"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusExpired">https://w3id.org/GConsent#ConsentStatusExpired</seealso>
    let ConsentStatusExpired =
        Prefixed_Name(gcon, "ConsentStatusExpired") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusExplicitlyGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#StatusValidForProcessing</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates consent is explicitly given."</para>
    /// labels<para>"Explicitly Given"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusExplicitlyGiven">https://w3id.org/GConsent#ConsentStatusExplicitlyGiven</seealso>
    let ConsentStatusExplicitlyGiven =
        Prefixed_Name(gcon, "ConsentStatusExplicitlyGiven") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusGivenByDelegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#StatusValidForProcessing</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>"Indicates consent is given via delegation."</para>
    /// labels<para>"Given by Delegation"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusGivenByDelegation">https://w3id.org/GConsent#ConsentStatusGivenByDelegation</seealso>
    let ConsentStatusGivenByDelegation =
        Prefixed_Name(gcon, "ConsentStatusGivenByDelegation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusImplicitlyGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#StatusValidForProcessing</para>
    ///   <para>"Indicates consent is given via an implicit action or assumption."</para>
    /// labels<para>"Implicitly Given"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusImplicitlyGiven">https://w3id.org/GConsent#ConsentStatusImplicitlyGiven</seealso>
    let ConsentStatusImplicitlyGiven =
        Prefixed_Name(gcon, "ConsentStatusImplicitlyGiven") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusInvalidated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates the consent has been invalidated."</para>
    /// labels<para>"Invalidated"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusInvalidated">https://w3id.org/GConsent#ConsentStatusInvalidated</seealso>
    let ConsentStatusInvalidated =
        Prefixed_Name(gcon, "ConsentStatusInvalidated") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusNotGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>"Indicates that consent has not been given."</para>
    /// labels<para>"Not Given"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusNotGiven">https://w3id.org/GConsent#ConsentStatusNotGiven</seealso>
    let ConsentStatusNotGiven =
        Prefixed_Name(gcon, "ConsentStatusNotGiven") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusRefused</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>"Indicates that consent has been refused (to be given)."</para>
    /// labels<para>"Refused"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusRefused">https://w3id.org/GConsent#ConsentStatusRefused</seealso>
    let ConsentStatusRefused =
        Prefixed_Name(gcon, "ConsentStatusRefused") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusRequested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>"Indicates consent has been requested but has not been given (yet)."</para>
    /// labels<para>"Requested"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusRequested">https://w3id.org/GConsent#ConsentStatusRequested</seealso>
    let ConsentStatusRequested =
        Prefixed_Name(gcon, "ConsentStatusRequested") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>"Indicates the consent status is unknown."</para>
    /// labels<para>"Unknown"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusUnknown">https://w3id.org/GConsent#ConsentStatusUnknown</seealso>
    let ConsentStatusUnknown =
        Prefixed_Name(gcon, "ConsentStatusUnknown") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsentStatusWithdrawn</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    ///   <para>w3id:GConsent#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates consent has been withdrawn."</para>
    /// labels<para>"Withdrawn"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsentStatusWithdrawn">https://w3id.org/GConsent#ConsentStatusWithdrawn</seealso>
    let ConsentStatusWithdrawn =
        Prefixed_Name(gcon, "ConsentStatusWithdrawn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ConsultationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataConsultation</para>
    ///   <para>"Represents Consultation Of personal data."</para>
    /// labels<para>"Consultation Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ConsultationOfPersonalData">https://w3id.org/GConsent#ConsultationOfPersonalData</seealso>
    let ConsultationOfPersonalData =
        Prefixed_Name(gcon, "ConsultationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DataAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Adaptation of data takes place."</para>
    /// labels<para>"Data Adaptation"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataAdaptation">https://w3id.org/GConsent#DataAdaptation</seealso>
    let DataAdaptation = Prefixed_Name(gcon, "DataAdaptation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Alignment of data takes place."</para>
    /// labels<para>"Data Alignment"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataAlignment">https://w3id.org/GConsent#DataAlignment</seealso>
    let DataAlignment = Prefixed_Name(gcon, "DataAlignment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataAlteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Alteration of data takes place."</para>
    /// labels<para>"Data Alteration"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataAlteration">https://w3id.org/GConsent#DataAlteration</seealso>
    let DataAlteration = Prefixed_Name(gcon, "DataAlteration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Collection of data takes place."</para>
    /// labels<para>"Data Collection"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataCollection">https://w3id.org/GConsent#DataCollection</seealso>
    let DataCollection = Prefixed_Name(gcon, "DataCollection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataCombination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Combination of data takes place."</para>
    /// labels<para>"Data Combination"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataCombination">https://w3id.org/GConsent#DataCombination</seealso>
    let DataCombination = Prefixed_Name(gcon, "DataCombination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataConsultation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Consultation of data takes place."</para>
    /// labels<para>"Data Consultation"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataConsultation">https://w3id.org/GConsent#DataConsultation</seealso>
    let DataConsultation = Prefixed_Name(gcon, "DataConsultation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Data Controller is defined as "The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data.""</para>
    /// labels<para>"Data Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataController">https://w3id.org/GConsent#DataController</seealso>
    let DataController = Prefixed_Name(gcon, "DataController") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataDestruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Destruction of data takes place."</para>
    /// labels<para>"Data Destruction"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataDestruction">https://w3id.org/GConsent#DataDestruction</seealso>
    let DataDestruction = Prefixed_Name(gcon, "DataDestruction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DataDisclosureByTransmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Disclosure by Transmission of data takes place."</para>
    /// labels<para>"Data Disclosure by Transmission"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataDisclosureByTransmission">https://w3id.org/GConsent#DataDisclosureByTransmission</seealso>
    let DataDisclosureByTransmission =
        Prefixed_Name(gcon, "DataDisclosureByTransmission") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DataDissemination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Dissemination of data takes place."</para>
    /// labels<para>"Data Dissemination"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataDissemination">https://w3id.org/GConsent#DataDissemination</seealso>
    let DataDissemination = Prefixed_Name(gcon, "DataDissemination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataErasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Erasure of data takes place."</para>
    /// labels<para>"Data Erasure"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataErasure">https://w3id.org/GConsent#DataErasure</seealso>
    let DataErasure = Prefixed_Name(gcon, "DataErasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Organisation of data takes place."</para>
    /// labels<para>"Data Organisation"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataOrganisation">https://w3id.org/GConsent#DataOrganisation</seealso>
    let DataOrganisation = Prefixed_Name(gcon, "DataOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Recording of data takes place."</para>
    /// labels<para>"Data Recording"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataRecording">https://w3id.org/GConsent#DataRecording</seealso>
    let DataRecording = Prefixed_Name(gcon, "DataRecording") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Restriction of data takes place."</para>
    /// labels<para>"Data Restriction"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataRestriction">https://w3id.org/GConsent#DataRestriction</seealso>
    let DataRestriction = Prefixed_Name(gcon, "DataRestriction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Retrieval of data takes place."</para>
    /// labels<para>"Data Retrieval"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataRetrieval">https://w3id.org/GConsent#DataRetrieval</seealso>
    let DataRetrieval = Prefixed_Name(gcon, "DataRetrieval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataSharing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of processing where sharing of data takes place with a Third Party."</para>
    /// labels<para>"Data Sharing"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataSharing">https://w3id.org/GConsent#DataSharing</seealso>
    let DataSharing = Prefixed_Name(gcon, "DataSharing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Storage of data takes place."</para>
    /// labels<para>"Data Storage"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataStorage">https://w3id.org/GConsent#DataStorage</seealso>
    let DataStorage = Prefixed_Name(gcon, "DataStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataStructuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Structuring of data takes place."</para>
    /// labels<para>"Data Structuring"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataStructuring">https://w3id.org/GConsent#DataStructuring</seealso>
    let DataStructuring = Prefixed_Name(gcon, "DataStructuring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data Subject is defined as an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person; - according to Article 4(1) of the GDPR pertaining to the definition of Personal Data.
    ///
    /// In the case of this ontology, a Data Subject refers to the person(s) as per the definition of the GDPR. Since a Data Subject is a Person, it is defined as a subclass of foaf:Person.
    ///
    /// The Data Subject is linked to the Consent instance via the isConsentForDataSubject and hasConsent properties."</para>
    /// labels<para>"Data Subject"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataSubject">https://w3id.org/GConsent#DataSubject</seealso>
    let DataSubject = Prefixed_Name(gcon, "DataSubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#DataUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the type of processing where Use of data takes place."</para>
    /// labels<para>"Data Use"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DataUse">https://w3id.org/GConsent#DataUse</seealso>
    let DataUse = Prefixed_Name(gcon, "DataUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#Delegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Delegation of consent occurs when another entity, whether a data subject or their representative or an automated mechanism, provides the consent on behalf of the intended Data Subject. The delegated consent is provided through the mechanism of a _delegation_. This involves three entities - the Data Subject the delegation occurs for, the entity that acts as the delegate, and the mechanism used to verify the authority to delegate. They (first two) are provided respectively by the properties `isConsentDelegationFor`, and `hasConsentGivenByDelegate`."</para>
    /// labels<para>"Delegation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Delegation">https://w3id.org/GConsent#Delegation</seealso>
    let Delegation = Prefixed_Name(gcon, "Delegation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DestructionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#DataDestruction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Destruction Of personal data."</para>
    /// labels<para>"Destruction Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DestructionOfPersonalData">https://w3id.org/GConsent#DestructionOfPersonalData</seealso>
    let DestructionOfPersonalData =
        Prefixed_Name(gcon, "DestructionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DisclosureByTransmissionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataDisclosureByTransmission</para>
    ///   <para>"Represents Disclosure by Transmission Of personal data."</para>
    /// labels<para>"Disclosure by Transmission Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DisclosureByTransmissionOfPersonalData">https://w3id.org/GConsent#DisclosureByTransmissionOfPersonalData</seealso>
    let DisclosureByTransmissionOfPersonalData =
        Prefixed_Name(gcon, "DisclosureByTransmissionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#DisseminationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataDissemination</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents Dissemination Of personal data."</para>
    /// labels<para>"Dissemination Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#DisseminationOfPersonalData">https://w3id.org/GConsent#DisseminationOfPersonalData</seealso>
    let DisseminationOfPersonalData =
        Prefixed_Name(gcon, "DisseminationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ErasureOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataErasure</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Erasure Of personal data."</para>
    /// labels<para>"Erasure Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ErasureOfPersonalData">https://w3id.org/GConsent#ErasureOfPersonalData</seealso>
    let ErasureOfPersonalData =
        Prefixed_Name(gcon, "ErasureOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#GivenConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a consent entity that is considered given whether implicitly, explicitly, or by delegation."</para>
    /// labels<para>"Given Consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#GivenConsent">https://w3id.org/GConsent#GivenConsent</seealso>
    let GivenConsent = Prefixed_Name(gcon, "GivenConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the medium through which consent was given/provided. Example: web form, recorded voice, signature on document."</para>
    /// labels<para>"Medium"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Medium">https://w3id.org/GConsent#Medium</seealso>
    let Medium = Prefixed_Name(gcon, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#MinorDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Minor is a Data Subject who cannot provide their own consent (that is legally valid). Therefore, their consent must be obtained via a Guardian or Legal Representative or Parent. Minor is a subclass of Data Subject.
    ///
    /// Consent given in lieu of a Minor (by their Representative) is associated with the `ConsentInstance` class/instance using the `wasGivenBy` property.
    ///
    /// The ontology currently does not capture this relationship between the Minor and their Representative. This is due to required clarifications regarding how this role should be represented. For example, the `DataSubject` cannot be subclassed to create a `Representative` class, as this would make the `DataSubject` a permanent representative for the Minor. Instead, the role of 'acting as representative' is only for the instance of the given consent. Therefore, this could be represented with a `ConsentRepresentativeRole` class that links to the `MinorDataSubject` with `roleHadDataSubject` property, and the `DataSubject` that gave the consent via the `roleHadRepresentative` property. The relationship or reason or situation of this given consent can be captured by further annotating the `ConsentRepresentativeRole` instance. This approach can also be extended to other similar situations where one `DataSubject` gives consent in lieu of another.
    ///
    /// Note: A Minor can provide their own consent in certain cases, or conversely, a minor's consent may need to be provided by a 'parental' representative in some cases."</para>
    /// labels<para>"Minor Data Subject"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#MinorDataSubject">https://w3id.org/GConsent#MinorDataSubject</seealso>
    let MinorDataSubject = Prefixed_Name(gcon, "MinorDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#OrganisationOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataOrganisation</para>
    ///   <para>"Represents Organisation Of personal data."</para>
    /// labels<para>"Organisation Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#OrganisationOfPersonalData">https://w3id.org/GConsent#OrganisationOfPersonalData</seealso>
    let OrganisationOfPersonalData =
        Prefixed_Name(gcon, "OrganisationOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#PersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"As per Article 4(1) of the GDPR, ‘personal data’ means any information relating to an identified or identifiable natural person (‘data subject’);"</para>
    /// labels<para>"Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#PersonalData">https://w3id.org/GConsent#PersonalData</seealso>
    let PersonalData = Prefixed_Name(gcon, "PersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processing is defined by the GDPR (Article 4-2) as "any operation or set of operations which is performed on personal data or on sets of personal data, whether or not by automated means, such as collection, recording, organisation, structuring, storage, adaptation or alteration, retrieval, consultation, use, disclosure by transmission, dissemination or otherwise making available, alignment or combination, restriction, erasure or destruction;".
    ///
    /// Processing can be considered as the action, within an activity for example, that uses data in a particular or specific way. Therefore, processing specifies what is happening to/with the data.
    ///
    /// To define a type of processing (or its associated action), the Processing class should be subclassed for each type. Furthermore, each subclass should define a instance as a generic representative of that action. For example, "collect" as a type of processing (defined by the GDPR), is defined as the class DataCollection, which is a subclass of Processing, and has the individual CollectionOfPersonalData to represent a generic instance of the concept. This is to provide a ready-to-use ontology in terms of "collect" as an action, while also providing a way to specialise the action/processing.
    /// GConsent defines several such types of processing taken from the text of the GDPR."</para>
    /// labels<para>"Processing"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Processing">https://w3id.org/GConsent#Processing</seealso>
    let Processing = Prefixed_Name(gcon, "Processing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose refers to the aim or goal towards which the data is processed (or associated with any other form of action)."</para>
    /// labels<para>"Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Purpose">https://w3id.org/GConsent#Purpose</seealso>
    let Purpose = Prefixed_Name(gcon, "Purpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#RecordingOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataRecording</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents Recording Of personal data."</para>
    /// labels<para>"Recording Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#RecordingOfPersonalData">https://w3id.org/GConsent#RecordingOfPersonalData</seealso>
    let RecordingOfPersonalData =
        Prefixed_Name(gcon, "RecordingOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#RestrictionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataRestriction</para>
    ///   <para>"Represents Restriction Of personal data."</para>
    /// labels<para>"Restriction Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#RestrictionOfPersonalData">https://w3id.org/GConsent#RestrictionOfPersonalData</seealso>
    let RestrictionOfPersonalData =
        Prefixed_Name(gcon, "RestrictionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#RetrievalOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#DataRetrieval</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Retrieval Of personal data."</para>
    /// labels<para>"Retrieval Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#RetrievalOfPersonalData">https://w3id.org/GConsent#RetrievalOfPersonalData</seealso>
    let RetrievalOfPersonalData =
        Prefixed_Name(gcon, "RetrievalOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#SharingOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#DataSharing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents sharing of personal data"</para>
    /// labels<para>"Sharing of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#SharingOfPersonalData">https://w3id.org/GConsent#SharingOfPersonalData</seealso>
    let SharingOfPersonalData =
        Prefixed_Name(gcon, "SharingOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the status of consent for the data subject. This allows persisting the determination of the validatity or suitability of consent (as an entity or instance) for use in processing and other activities. Examples: consent is given, consent is requested but not given, consent was withdrawn."</para>
    /// labels<para>"Status"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#Status">https://w3id.org/GConsent#Status</seealso>
    let Status = Prefixed_Name(gcon, "Status") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#StatusInvalidForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents consent states that are invalid for processing."</para>
    /// labels<para>"Status invalid for Processing"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#StatusInvalidForProcessing">https://w3id.org/GConsent#StatusInvalidForProcessing</seealso>
    let StatusInvalidForProcessing =
        Prefixed_Name(gcon, "StatusInvalidForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#StatusValidForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents consent states that are valid for processing"</para>
    /// labels<para>"Status valid for Processing"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#StatusValidForProcessing">https://w3id.org/GConsent#StatusValidForProcessing</seealso>
    let StatusValidForProcessing =
        Prefixed_Name(gcon, "StatusValidForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#StorageOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataStorage</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Storage Of personal data."</para>
    /// labels<para>"Storage Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#StorageOfPersonalData">https://w3id.org/GConsent#StorageOfPersonalData</seealso>
    let StorageOfPersonalData =
        Prefixed_Name(gcon, "StorageOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#StructuringOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>w3id:GConsent#DataStructuring</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents Structuring Of personal data."</para>
    /// labels<para>"Structuring Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#StructuringOfPersonalData">https://w3id.org/GConsent#StructuringOfPersonalData</seealso>
    let StructuringOfPersonalData =
        Prefixed_Name(gcon, "StructuringOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#ThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an Agent that is a Person or an Organisation other than the current entity (w.r.t. data protection laws)."</para>
    /// labels<para>"Third Party"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#ThirdParty">https://w3id.org/GConsent#ThirdParty</seealso>
    let ThirdParty = Prefixed_Name(gcon, "ThirdParty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#UseOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:GConsent#DataUse</para>
    ///   <para>w3id:GConsent#Processing</para>
    ///   <para>"Represents Use Of personal data."</para>
    /// labels<para>"Use Of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#UseOfPersonalData">https://w3id.org/GConsent#UseOfPersonalData</seealso>
    let UseOfPersonalData = Prefixed_Name(gcon, "UseOfPersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#atLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the location at which the consent was given."</para>
    /// labels<para>"at location"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#atLocation">https://w3id.org/GConsent#atLocation</seealso>
    let atLocation = Prefixed_Name(gcon, "atLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the instant at which the consent was created/given/changed."</para>
    /// labels<para>"at time"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#atTime">https://w3id.org/GConsent#atTime</seealso>
    let atTime = Prefixed_Name(gcon, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#forPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the consent to personal data it is associated with it."</para>
    /// labels<para>"for personal data"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#forPersonalData">https://w3id.org/GConsent#forPersonalData</seealso>
    let forPersonalData = Prefixed_Name(gcon, "forPersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#forProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the consent with its associated processing."</para>
    /// labels<para>"for processing"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#forProcessing">https://w3id.org/GConsent#forProcessing</seealso>
    let forProcessing = Prefixed_Name(gcon, "forProcessing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#forPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a consent instace to the purpose(s) it is associated with."</para>
    /// labels<para>"for purpose"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#forPurpose">https://w3id.org/GConsent#forPurpose</seealso>
    let forPurpose = Prefixed_Name(gcon, "forPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates an Association with another entity for a Purpose or Processing"</para>
    /// labels<para>"has association"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasAssociation">https://w3id.org/GConsent#hasAssociation</seealso>
    let hasAssociation = Prefixed_Name(gcon, "hasAssociation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a data subject to their consent."</para>
    /// labels<para>"has consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasConsent">https://w3id.org/GConsent#hasConsent</seealso>
    let hasConsent = Prefixed_Name(gcon, "hasConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a consent instance to the context in which it was acquired/provided/given."</para>
    /// labels<para>"has context"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasContext">https://w3id.org/GConsent#hasContext</seealso>
    let hasContext = Prefixed_Name(gcon, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasExpiry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the Instant or Duration in which the consent expires."</para>
    /// labels<para>"has expiry"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasExpiry">https://w3id.org/GConsent#hasExpiry</seealso>
    let hasExpiry = Prefixed_Name(gcon, "hasExpiry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the role played by specified Person or Organisation or Third Party in the specified Association."</para>
    /// labels<para>"hasRole"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasRole">https://w3id.org/GConsent#hasRole</seealso>
    let hasRole = Prefixed_Name(gcon, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the state or status of consent."</para>
    /// labels<para>"has status"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#hasStatus">https://w3id.org/GConsent#hasStatus</seealso>
    let hasStatus = Prefixed_Name(gcon, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#inMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the medium through which the consent was given. Examples are web forms, paper documents."</para>
    /// labels<para>"in medium"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#inMedium">https://w3id.org/GConsent#inMedium</seealso>
    let inMedium = Prefixed_Name(gcon, "inMedium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#involvesThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the involvement by association of a Third Party."</para>
    /// labels<para>"involves third party"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#involvesThirdParty">https://w3id.org/GConsent#involvesThirdParty</seealso>
    let involvesThirdParty = Prefixed_Name(gcon, "involvesThirdParty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#isAssociationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an Association is for the associated Purpose or Processing."</para>
    /// labels<para>"is association for"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isAssociationFor">https://w3id.org/GConsent#isAssociationFor</seealso>
    let isAssociationFor = Prefixed_Name(gcon, "isAssociationFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isConsentForDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a consent instance with the data subject it is associated with."</para>
    /// labels<para>"is consent for data subject"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isConsentForDataSubject">https://w3id.org/GConsent#isConsentForDataSubject</seealso>
    let isConsentForDataSubject =
        Prefixed_Name(gcon, "isConsentForDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isContextForConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a context to the consent instance it describes"</para>
    /// labels<para>"is context for consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isContextForConsent">https://w3id.org/GConsent#isContextForConsent</seealso>
    let isContextForConsent = Prefixed_Name(gcon, "isContextForConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isPersonalDataForConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links personal data with the consent it is associated with."</para>
    /// labels<para>"is personal data for consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isPersonalDataForConsent">https://w3id.org/GConsent#isPersonalDataForConsent</seealso>
    let isPersonalDataForConsent =
        Prefixed_Name(gcon, "isPersonalDataForConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isPreviousConsentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that this consent instance is the previous consent for the specified consent instance."</para>
    /// labels<para>"is previous consent for"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isPreviousConsentFor">https://w3id.org/GConsent#isPreviousConsentFor</seealso>
    let isPreviousConsentFor =
        Prefixed_Name(gcon, "isPreviousConsentFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProcessingForConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an action to the purpose it is associated with."</para>
    /// labels<para>"is action for purpose"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProcessingForConsent">https://w3id.org/GConsent#isProcessingForConsent</seealso>
    let isProcessingForConsent =
        Prefixed_Name(gcon, "isProcessingForConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicates the entity or activitiy that provided the consent."</para>
    /// labels<para>"is provided by"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedBy">https://w3id.org/GConsent#isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(gcon, "isProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedByDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedByDataSubject">https://w3id.org/GConsent#isProvidedByDataSubject</seealso>
    let isProvidedByDataSubject =
        Prefixed_Name(gcon, "isProvidedByDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedByDelegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Specifies the delegation that provided this consent."</para>
    /// labels<para>"is provided by delegation"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedByDelegation">https://w3id.org/GConsent#isProvidedByDelegation</seealso>
    let isProvidedByDelegation =
        Prefixed_Name(gcon, "isProvidedByDelegation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedByPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the Person that provided this consent."</para>
    /// labels<para>"is provided by person"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedByPerson">https://w3id.org/GConsent#isProvidedByPerson</seealso>
    let isProvidedByPerson = Prefixed_Name(gcon, "isProvidedByPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#isProvidedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the Person or Data Controller the consent was provided to."</para>
    /// labels<para>"is provided to"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedTo">https://w3id.org/GConsent#isProvidedTo</seealso>
    let isProvidedTo = Prefixed_Name(gcon, "isProvidedTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedToController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Indicates the Organisation the consent was provided to."</para>
    /// labels<para>"is provided to controller"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedToController">https://w3id.org/GConsent#isProvidedToController</seealso>
    let isProvidedToController =
        Prefixed_Name(gcon, "isProvidedToController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#isProvidedToPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the Person the consent was provided to."</para>
    /// labels<para>"is provided to person"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isProvidedToPerson">https://w3id.org/GConsent#isProvidedToPerson</seealso>
    let isProvidedToPerson = Prefixed_Name(gcon, "isProvidedToPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#isPurposeForConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links purpose with the consent instance associated with it."</para>
    /// labels<para>"is purpose for consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isPurposeForConsent">https://w3id.org/GConsent#isPurposeForConsent</seealso>
    let isPurposeForConsent = Prefixed_Name(gcon, "isPurposeForConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#isStatusForConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Links a status to the consent that uses it."</para>
    /// labels<para>"is status for consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isStatusForConsent">https://w3id.org/GConsent#isStatusForConsent</seealso>
    let isStatusForConsent = Prefixed_Name(gcon, "isStatusForConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#isUpdatedConsentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Specifies the consent instance which this instance is an update or revision of."</para>
    /// labels<para>"is updated consent for"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#isUpdatedConsentFor">https://w3id.org/GConsent#isUpdatedConsentFor</seealso>
    let isUpdatedConsentFor = Prefixed_Name(gcon, "isUpdatedConsentFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent#providedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Links the entity or activity that gave consent to the entity or activity representing the consent (or its delegation)."</para>
    /// labels<para>"gave consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#providedConsent">https://w3id.org/GConsent#providedConsent</seealso>
    let providedConsent = Prefixed_Name(gcon, "providedConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#sharesDataWithThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates sharing of personal data with a Third Party through the association."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GConsent#sharesDataWithThirdParty">https://w3id.org/GConsent#sharesDataWithThirdParty</seealso>
    let sharesDataWithThirdParty =
        Prefixed_Name(gcon, "sharesDataWithThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent#wasProvidedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Indicates that the specified Person or Data Controller was provided the associated consent."</para>
    /// labels<para>"was provided consent"</para></remarks>
    /// <seealso href="https://w3id.org/GConsent#wasProvidedConsent">https://w3id.org/GConsent#wasProvidedConsent</seealso>
    let wasProvidedConsent = Prefixed_Name(gcon, "wasProvidedConsent") |> PrefixedName
