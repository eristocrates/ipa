namespace https.w3id.org.GDPRtEXT.hash

open DoxAletheia.Rdf_Vocabulary

module gdprtext =
    let _namespace_name = "https://w3id.org/GDPRtEXT#"

    /// <summary>
    /// The principle of accountability states that the controller shall be responsible for, and be able to demonstrate compliance with the processing of personal data as defined by the justifications permissible under the GDPR
    /// <see href="https://w3id.org/GDPRtEXT#Accountability"></see></summary>
    let Accountability =
        Namespaced_IRI.parse _namespace_name "Accountability" |> NamespacedName

    /// <summary>
    /// A Principle is a rule or standard defined by the GDPR which is essential to be followed for compliance
    /// <see href="https://w3id.org/GDPRtEXT#Principle"></see></summary>
    let Principle = Namespaced_IRI.parse _namespace_name "Principle" |> NamespacedName
    /// <summary>
    /// It signifies that two concepts are related within the context of the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    /// Represents the act of complying with the obligations and actions specified by the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#Compliance"></see></summary>
    let Compliance = Namespaced_IRI.parse _namespace_name "Compliance" |> NamespacedName

    /// <summary>
    /// This provides the basis for lawful processing of personal data.
    /// <see href="https://w3id.org/GDPRtEXT#LawfulBasisForProcessing"></see></summary>
    let LawfulBasisForProcessing =
        Namespaced_IRI.parse _namespace_name "LawfulBasisForProcessing" |> NamespacedName

    /// <summary>
    /// Processing here refers to an Activity that acts on the Data Subject's personal information.
    /// <see href="https://w3id.org/GDPRtEXT#Processing"></see></summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName

    /// <summary>
    /// These obligations specify the responsiblity of the Controller
    /// <see href="https://w3id.org/GDPRtEXT#ControllerResponsibility"></see></summary>
    let ControllerResponsibility =
        Namespaced_IRI.parse _namespace_name "ControllerResponsibility" |> NamespacedName

    /// <summary>
    /// The principle of accuracy states that personal data must be accurate and, where necessary, kept up to date; every reasonable step must be taken to ensure that personal data that are inaccurate, having regard to the purposes for which they are processed, are erased or rectified without delay.
    /// <see href="https://w3id.org/GDPRtEXT#Accuracy"></see></summary>
    let Accuracy = Namespaced_IRI.parse _namespace_name "Accuracy" |> NamespacedName
    /// <summary>
    /// An activity that erases data
    /// <see href="https://w3id.org/GDPRtEXT#EraseData"></see></summary>
    let EraseData = Namespaced_IRI.parse _namespace_name "EraseData" |> NamespacedName

    /// <summary>
    /// Any inaccuracies or discrepancies in the retained data must be rectified
    /// <see href="https://w3id.org/GDPRtEXT#RectifyInaccuracy"></see></summary>
    let RectifyInaccuracy =
        Namespaced_IRI.parse _namespace_name "RectifyInaccuracy" |> NamespacedName

    /// <summary>
    /// Retained personal data must be kept up-to-date
    /// <see href="https://w3id.org/GDPRtEXT#KeptUpToDate"></see></summary>
    let KeptUpToDate =
        Namespaced_IRI.parse _namespace_name "KeptUpToDate" |> NamespacedName

    /// <summary>
    /// An activity that rectifies data
    /// <see href="https://w3id.org/GDPRtEXT#RectifyData"></see></summary>
    let RectifyData =
        Namespaced_IRI.parse _namespace_name "RectifyData" |> NamespacedName

    /// <summary>
    /// Personal data means any information relating to an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person.
    /// <see href="https://w3id.org/GDPRtEXT#PersonalData"></see></summary>
    let PersonalData =
        Namespaced_IRI.parse _namespace_name "PersonalData" |> NamespacedName

    /// <summary>
    /// The data subject can exercise the right to restrict processing of their personal data when the accuracy of personal data is contested
    /// <see href="https://w3id.org/GDPRtEXT#AccuracyIsContested"></see></summary>
    let AccuracyIsContested =
        Namespaced_IRI.parse _namespace_name "AccuracyIsContested" |> NamespacedName

    /// <summary>
    /// The data subject has the rights to restrict the processing of their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightToRestrictProcessing"></see></summary>
    let RightToRestrictProcessing =
        Namespaced_IRI.parse _namespace_name "RightToRestrictProcessing" |> NamespacedName

    /// <summary>
    /// This obligation specifies that the collection of (or collected) personal data should in an accurate form - i.e. the personal data should be accurate.
    /// <see href="https://w3id.org/GDPRtEXT#AccurateCollection"></see></summary>
    let AccurateCollection =
        Namespaced_IRI.parse _namespace_name "AccurateCollection" |> NamespacedName

    /// <summary>
    /// Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction.
    /// <see href="https://w3id.org/GDPRtEXT#ObligationForCollectionOfPersonalData"></see></summary>
    let ObligationForCollectionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "ObligationForCollectionOfPersonalData" |> NamespacedName

    /// <summary>
    /// Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction.
    /// <see href="https://w3id.org/GDPRtEXT#CollectionOfPersonalData"></see></summary>
    let CollectionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "CollectionOfPersonalData" |> NamespacedName

    /// <summary>
    /// An Activity signifies some process(es) or step(s) towards specific deed(s), action(s), function(s), or sphere(s) of action.
    /// <see href="https://w3id.org/GDPRtEXT#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    /// Only the personal data adequat for required processing should be maintained
    /// <see href="https://w3id.org/GDPRtEXT#AdequateForProcessing"></see></summary>
    let AdequateForProcessing =
        Namespaced_IRI.parse _namespace_name "AdequateForProcessing" |> NamespacedName

    /// <summary>
    /// These are the obligations specified by the GDPR on the retention of personal data
    /// <see href="https://w3id.org/GDPRtEXT#RetentionOfPersonalData"></see></summary>
    let RetentionOfPersonalData =
        Namespaced_IRI.parse _namespace_name "RetentionOfPersonalData" |> NamespacedName

    /// <summary>
    /// An activity where personal data is being stored
    /// <see href="https://w3id.org/GDPRtEXT#StoreData"></see></summary>
    let StoreData = Namespaced_IRI.parse _namespace_name "StoreData" |> NamespacedName

    /// <summary>
    /// The seal or certification does not reduce or impact the responsiblity of the controller or processor for compliance with the GDPR
    /// <see href="https://w3id.org/GDPRtEXT#AdherenceToSealCertification"></see></summary>
    let AdherenceToSealCertification =
        Namespaced_IRI.parse _namespace_name "AdherenceToSealCertification" |> NamespacedName

    /// <summary>
    /// GDPR mentions some conditions or criterion for the creation and issuing of seals and certifications pertaining to GDPR compliance
    /// <see href="https://w3id.org/GDPRtEXT#ConditionsForSealsAndCertifications"></see></summary>
    let ConditionsForSealsAndCertifications =
        Namespaced_IRI.parse _namespace_name "ConditionsForSealsAndCertifications" |> NamespacedName

    /// <summary>
    /// Data is termed to be anonymous if it cannot be connected or associated with individual person or persons that have provided or are associated with it.
    /// <see href="https://w3id.org/GDPRtEXT#AnonymousData"></see></summary>
    let AnonymousData =
        Namespaced_IRI.parse _namespace_name "AnonymousData" |> NamespacedName

    /// <summary>
    /// A generic term to refer to Data.
    /// <see href="https://w3id.org/GDPRtEXT#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName

    /// <summary>
    /// These are the obligations for Processors over appointing sub-processors
    /// <see href="https://w3id.org/GDPRtEXT#AppointingSubProcessors"></see></summary>
    let AppointingSubProcessors =
        Namespaced_IRI.parse _namespace_name "AppointingSubProcessors" |> NamespacedName

    /// <summary>
    /// These are the obligations specified by the GDPR in the context of Processors
    /// <see href="https://w3id.org/GDPRtEXT#ProcessorObligation"></see></summary>
    let ProcessorObligation =
        Namespaced_IRI.parse _namespace_name "ProcessorObligation" |> NamespacedName

    /// <summary>
    /// A natural or legal person, public authority, agency or other body which processes personal data on behalf of the controller.
    /// <see href="https://w3id.org/GDPRtEXT#Processor"></see></summary>
    let Processor = Namespaced_IRI.parse _namespace_name "Processor" |> NamespacedName

    /// <summary>
    /// A sub-processor is a processor acting under another processor.
    /// <see href="https://w3id.org/GDPRtEXT#SubProcessor"></see></summary>
    let SubProcessor =
        Namespaced_IRI.parse _namespace_name "SubProcessor" |> NamespacedName

    /// <summary>
    /// These are the obligations specified by the GDPR for the appointment of Processors by Controllers.
    /// <see href="https://w3id.org/GDPRtEXT#AppointmentOfProcessors"></see></summary>
    let AppointmentOfProcessors =
        Namespaced_IRI.parse _namespace_name "AppointmentOfProcessors" |> NamespacedName

    /// <summary>
    /// These are the obligations specified by the GDPR as being specifically the responsbility of the Controller.
    /// <see href="https://w3id.org/GDPRtEXT#ControllerObligation"></see></summary>
    let ControllerObligation =
        Namespaced_IRI.parse _namespace_name "ControllerObligation" |> NamespacedName

    /// <summary>
    /// The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data.
    /// <see href="https://w3id.org/GDPRtEXT#Controller"></see></summary>
    let Controller = Namespaced_IRI.parse _namespace_name "Controller" |> NamespacedName

    /// <summary>
    /// An activity where personal data is archived
    /// <see href="https://w3id.org/GDPRtEXT#ArchiveData"></see></summary>
    let ArchiveData =
        Namespaced_IRI.parse _namespace_name "ArchiveData" |> NamespacedName

    /// <summary>
    /// An activity involving personal data of data subject(s).
    /// <see href="https://w3id.org/GDPRtEXT#DataActivity"></see></summary>
    let DataActivity =
        Namespaced_IRI.parse _namespace_name "DataActivity" |> NamespacedName

    /// <summary>
    /// Article in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// Processors must assist Controllers in complying with the various rights provided by the GDPR to data subjects which can be exercised at any time.
    /// <see href="https://w3id.org/GDPRtEXT#AssistInComplyingWithRights"></see></summary>
    let AssistInComplyingWithRights =
        Namespaced_IRI.parse _namespace_name "AssistInComplyingWithRights" |> NamespacedName

    /// <summary>
    /// The GDPR provides several rights to the data subjects which may be exercised at any time by the data subject and which are mandatory for the organisation to provide, comply with, and inform the data subject about.
    /// <see href="https://w3id.org/GDPRtEXT#Rights"></see></summary>
    let Rights = Namespaced_IRI.parse _namespace_name "Rights" |> NamespacedName

    /// <summary>
    /// This type of processing involves automated processing that does decision making having significant effects on the data subject.
    /// Automated decision making with significant effect
    /// <see href="https://w3id.org/GDPRtEXT#AutomatedDecisionMakingWithSignificantEffect"></see></summary>
    let AutomatedDecisionMakingWithSignificantEffect =
        Namespaced_IRI.parse _namespace_name "AutomatedDecisionMakingWithSignificantEffect" |> NamespacedName

    /// <summary>
    /// This is automated processing of data subject's personal data.
    /// <see href="https://w3id.org/GDPRtEXT#AutomatedProcessing"></see></summary>
    let AutomatedProcessing =
        Namespaced_IRI.parse _namespace_name "AutomatedProcessing" |> NamespacedName

    /// <summary>
    /// These are the factors stated by the GDPR for Impact Assessment.
    /// <see href="https://w3id.org/GDPRtEXT#FactorsForImpactAssessment"></see></summary>
    let FactorsForImpactAssessment =
        Namespaced_IRI.parse _namespace_name "FactorsForImpactAssessment" |> NamespacedName

    /// <summary>
    /// An individual or entity to whom their personal data relates.
    /// <see href="https://w3id.org/GDPRtEXT#DataSubject"></see></summary>
    let DataSubject =
        Namespaced_IRI.parse _namespace_name "DataSubject" |> NamespacedName

    /// <summary>
    /// This obligation states that the data subject should be able to withdraw the consent as easily as it was to give it.
    /// <see href="https://w3id.org/GDPRtEXT#CanBeWithdrawnEasilyConsentObligation"></see></summary>
    let CanBeWithdrawnEasilyConsentObligation =
        Namespaced_IRI.parse _namespace_name "CanBeWithdrawnEasilyConsentObligation" |> NamespacedName

    /// <summary>
    /// These are the obligations specified by the GDPR for obtaining consent
    /// <see href="https://w3id.org/GDPRtEXT#ObligationForObtainingConsent"></see></summary>
    let ObligationForObtainingConsent =
        Namespaced_IRI.parse _namespace_name "ObligationForObtainingConsent" |> NamespacedName

    /// <summary>
    /// Given Consent refers specifically to the form of consent given by the data subject in relation to their personal data and the proposed usage by activities.
    /// <see href="https://w3id.org/GDPRtEXT#GivenConsent"></see></summary>
    let GivenConsent =
        Namespaced_IRI.parse _namespace_name "GivenConsent" |> NamespacedName

    /// <summary>
    /// This activity represents the data subject withdrawing given consent.
    /// <see href="https://w3id.org/GDPRtEXT#WithdrawingConsent"></see></summary>
    let WithdrawingConsent =
        Namespaced_IRI.parse _namespace_name "WithdrawingConsent" |> NamespacedName

    /// <summary>
    /// A certification pertaining to GDPR compliance
    /// <see href="https://w3id.org/GDPRtEXT#Certification"></see></summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    /// GDPR provides for the creation and provision of seals and certificates pertaining to compliance or related activities
    /// <see href="https://w3id.org/GDPRtEXT#SealsAndCertification"></see></summary>
    let SealsAndCertification =
        Namespaced_IRI.parse _namespace_name "SealsAndCertification" |> NamespacedName

    /// <summary>
    /// A Certification Body is an entity that can award/issue/renew a certification pertaining to compliance towards the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#CertificationBody"></see></summary>
    let CertificationBody =
        Namespaced_IRI.parse _namespace_name "CertificationBody" |> NamespacedName

    /// <summary>
    /// A general term for any institution, company, corporation, partnership, government agency, university, or any other organization including  individuals.
    /// <see href="https://w3id.org/GDPRtEXT#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// A seal pertaining to GDPR compliance
    /// <see href="https://w3id.org/GDPRtEXT#Seal"></see></summary>
    let Seal = Namespaced_IRI.parse _namespace_name "Seal" |> NamespacedName
    /// <summary>
    /// Chapter in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Chapter"></see></summary>
    let Chapter = Namespaced_IRI.parse _namespace_name "Chapter" |> NamespacedName
    /// <summary>
    /// Citation in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Citation"></see></summary>
    let Citation = Namespaced_IRI.parse _namespace_name "Citation" |> NamespacedName

    /// <summary>
    /// Obtaining consent must provide clear explanations of the processing involved over the personal data
    /// <see href="https://w3id.org/GDPRtEXT#ClearExplanationOfProcessingConsentObligation"></see></summary>
    let ClearExplanationOfProcessingConsentObligation =
        Namespaced_IRI.parse _namespace_name "ClearExplanationOfProcessingConsentObligation" |> NamespacedName

    /// <summary>
    /// A Code of Conduct for the purpose of specifying the application of GDPR which may be monitored, evaluated, or processed by a third party appointed by the organisation.
    /// <see href="https://w3id.org/GDPRtEXT#CodeOfConduct"></see></summary>
    let CodeOfConduct =
        Namespaced_IRI.parse _namespace_name "CodeOfConduct" |> NamespacedName

    /// <summary>
    /// Specifies collection mechanism used to collect personal data
    /// <see href="https://w3id.org/GDPRtEXT#CollectionMechanism"></see></summary>
    let CollectionMechanism =
        Namespaced_IRI.parse _namespace_name "CollectionMechanism" |> NamespacedName

    /// <summary>
    /// The processor has an obligation to comply with the controller's instructions
    /// <see href="https://w3id.org/GDPRtEXT#ComplianceWithControllersInstructions"></see></summary>
    let ComplianceWithControllersInstructions =
        Namespaced_IRI.parse _namespace_name "ComplianceWithControllersInstructions" |> NamespacedName

    /// <summary>
    /// The maximum validity for all seals and certifications should be 3 years from the date of issue.
    /// <see href="https://w3id.org/GDPRtEXT#MaximumValidity3Years"></see></summary>
    let MaximumValidity3Years =
        Namespaced_IRI.parse _namespace_name "MaximumValidity3Years" |> NamespacedName

    /// <summary>
    /// The seals and certifications should be a voluntary system of accredition
    /// <see href="https://w3id.org/GDPRtEXT#VoluntarySystemOfAccredition"></see></summary>
    let VoluntarySystemOfAccredition =
        Namespaced_IRI.parse _namespace_name "VoluntarySystemOfAccredition" |> NamespacedName

    /// <summary>
    /// This type of processing involves matching data subject's identity or personal data in different datasets.
    /// <see href="https://w3id.org/GDPRtEXT#ConfirmingOrMatchingDatasets"></see></summary>
    let ConfirmingOrMatchingDatasets =
        Namespaced_IRI.parse _namespace_name "ConfirmingOrMatchingDatasets" |> NamespacedName

    /// <summary>
    /// Consent in the context of the GDPR refers to the assent or agreement by the data subject in relation to their personal data for the proposed processing activities associated with one or more organisations.
    /// <see href="https://w3id.org/GDPRtEXT#Consent"></see></summary>
    let Consent = Namespaced_IRI.parse _namespace_name "Consent" |> NamespacedName

    /// <summary>
    /// An activity involving data subject's consent.
    /// <see href="https://w3id.org/GDPRtEXT#ConsentActivity"></see></summary>
    let ConsentActivity =
        Namespaced_IRI.parse _namespace_name "ConsentActivity" |> NamespacedName

    /// <summary>
    /// The purpose of new processing should take the context of how the original data was collected into consideration
    /// <see href="https://w3id.org/GDPRtEXT#ContextOfDataCollection"></see></summary>
    let ContextOfDataCollection =
        Namespaced_IRI.parse _namespace_name "ContextOfDataCollection" |> NamespacedName

    /// <summary>
    /// These are the obligations over determining the new or changed purposes of processing
    /// <see href="https://w3id.org/GDPRtEXT#PurposeOfNewProcessing"></see></summary>
    let PurposeOfNewProcessing =
        Namespaced_IRI.parse _namespace_name "PurposeOfNewProcessing" |> NamespacedName

    /// <summary>
    /// The lawful basis for processing personal data is provided through a contract with the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#ContractWithDataSubject"></see></summary>
    let ContractWithDataSubject =
        Namespaced_IRI.parse _namespace_name "ContractWithDataSubject" |> NamespacedName

    /// <summary>
    /// These obligations specify the accountability of the Controller.
    /// <see href="https://w3id.org/GDPRtEXT#ControllerAccountability"></see></summary>
    let ControllerAccountability =
        Namespaced_IRI.parse _namespace_name "ControllerAccountability" |> NamespacedName

    /// <summary>
    /// The data subjects were not notified about the data breach because the controller had already taken action regarding the data breach.
    /// <see href="https://w3id.org/GDPRtEXT#ControllerHasTakenAction"></see></summary>
    let ControllerHasTakenAction =
        Namespaced_IRI.parse _namespace_name "ControllerHasTakenAction" |> NamespacedName

    /// <summary>
    /// Exceptions associated with compliance for reporting data breach to the affected data subjects.
    /// <see href="https://w3id.org/GDPRtEXT#ExceptionsOnReportingDataSubjectsOfBreach"></see></summary>
    let ExceptionsOnReportingDataSubjectsOfBreach =
        Namespaced_IRI.parse _namespace_name "ExceptionsOnReportingDataSubjectsOfBreach" |> NamespacedName

    /// <summary>
    /// A data breach is the intentional or unintentional release of secure or private/confidential information to an untrusted environment.
    /// <see href="https://w3id.org/GDPRtEXT#DataBreach"></see></summary>
    let DataBreach = Namespaced_IRI.parse _namespace_name "DataBreach" |> NamespacedName
    /// <summary>
    /// These are the obligations specified by the GDPR. Following the obligations is necessary for compliance.
    /// <see href="https://w3id.org/GDPRtEXT#Obligation"></see></summary>
    let Obligation = Namespaced_IRI.parse _namespace_name "Obligation" |> NamespacedName

    /// <summary>
    /// A natural or legal person established in the Union who, designated by the controllerin writing, represents the controller with regard to their respective obligations under the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#ControllerRepresentative"></see></summary>
    let ControllerRepresentative =
        Namespaced_IRI.parse _namespace_name "ControllerRepresentative" |> NamespacedName

    /// <summary>
    /// This obligation specifies the Controller/Processor must co-operate with the Data Protection Authority (DPA).
    /// <see href="https://w3id.org/GDPRtEXT#CooperateWithDPA"></see></summary>
    let CooperateWithDPA =
        Namespaced_IRI.parse _namespace_name "CooperateWithDPA" |> NamespacedName

    /// <summary>
    /// The Data Protection Authority (DPA) is a public institution responsible for monitoring the application of data protection laws.
    /// <see href="https://w3id.org/GDPRtEXT#DPA"></see></summary>
    let DPA = Namespaced_IRI.parse _namespace_name "DPA" |> NamespacedName

    /// <summary>
    /// Personal data related to criminal convictions and offences.
    /// <see href="https://w3id.org/GDPRtEXT#CriminalData"></see></summary>
    let CriminalData =
        Namespaced_IRI.parse _namespace_name "CriminalData" |> NamespacedName

    /// <summary>
    /// Personal data revealing racial or ethnic origin, political opinions, religious or philosophical beliefs, or trade union membership, and the processing of genetic data, biometric data for the purpose of uniquely identifying a natural person, data concerning health or data concerning a natural person's sex life or sexual orientation.
    /// <see href="https://w3id.org/GDPRtEXT#SensitivePersonalData"></see></summary>
    let SensitivePersonalData =
        Namespaced_IRI.parse _namespace_name "SensitivePersonalData" |> NamespacedName

    /// <summary>
    /// Cross-border data transfer refers to data transfer crossing the boundaries of EU (legislative) region.
    /// <see href="https://w3id.org/GDPRtEXT#CrossBorderTransfer"></see></summary>
    let CrossBorderTransfer =
        Namespaced_IRI.parse _namespace_name "CrossBorderTransfer" |> NamespacedName

    /// <summary>
    /// The Data Protection Officer (DPO) is an individual(s) appointed by the organisation to monitor compliance and assist in complying with the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#DPO"></see></summary>
    let DPO = Namespaced_IRI.parse _namespace_name "DPO" |> NamespacedName

    /// <summary>
    /// Affected data subjects must be notified with the name and contact of the DPO responsible/handling for the data breach.
    /// <see href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutDPOForDataBreach"></see></summary>
    let NotifyDataSubjectAboutDPOForDataBreach =
        Namespaced_IRI.parse _namespace_name "NotifyDataSubjectAboutDPOForDataBreach" |> NamespacedName

    /// <summary>
    /// The activity or process of overseeing an organisation's compliance.
    /// <see href="https://w3id.org/GDPRtEXT#MonitorCompliance"></see></summary>
    let MonitorCompliance =
        Namespaced_IRI.parse _namespace_name "MonitorCompliance" |> NamespacedName

    /// <summary>
    /// These are the obligations specified for the Data Protection Office (DPO) within the  GDPR
    /// <see href="https://w3id.org/GDPRtEXT#DPOObligation"></see></summary>
    let DPOObligation =
        Namespaced_IRI.parse _namespace_name "DPOObligation" |> NamespacedName

    /// <summary>
    /// The principle of data minimisation states that personal data must be adequate, relevant and limited to what is necessary in relation to the purposes for which they are processed.
    /// <see href="https://w3id.org/GDPRtEXT#DataMinimisation"></see></summary>
    let DataMinimisation =
        Namespaced_IRI.parse _namespace_name "DataMinimisation" |> NamespacedName

    /// <summary>
    /// This obligation states that the collection of personal data should happen only for the specified purposes (for which the data subject has consented).
    /// <see href="https://w3id.org/GDPRtEXT#SpecifiedPurpose"></see></summary>
    let SpecifiedPurpose =
        Namespaced_IRI.parse _namespace_name "SpecifiedPurpose" |> NamespacedName

    /// <summary>
    /// This obligation specifies that the collected (or collection) of personal data should be for/with explicit purposes.
    /// <see href="https://w3id.org/GDPRtEXT#ExplicitPurpose"></see></summary>
    let ExplicitPurpose =
        Namespaced_IRI.parse _namespace_name "ExplicitPurpose" |> NamespacedName

    /// <summary>
    /// The data subject can exercise the right to restrict processing of their personal data when the personal data is no longer required for the original purpose it was collected under
    /// <see href="https://w3id.org/GDPRtEXT#DataNoLongerNeededForOriginalPurpose"></see></summary>
    let DataNoLongerNeededForOriginalPurpose =
        Namespaced_IRI.parse _namespace_name "DataNoLongerNeededForOriginalPurpose" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to follow data protection by design and by default.
    /// <see href="https://w3id.org/GDPRtEXT#DataProtectionByDesignAndByDefault"></see></summary>
    let DataProtectionByDesignAndByDefault =
        Namespaced_IRI.parse _namespace_name "DataProtectionByDesignAndByDefault" |> NamespacedName

    /// <summary>
    /// These are obligations regarding security of data managed by the Controllers.
    /// <see href="https://w3id.org/GDPRtEXT#DataSecurity"></see></summary>
    let DataSecurity =
        Namespaced_IRI.parse _namespace_name "DataSecurity" |> NamespacedName

    /// <summary>
    /// This activity refers to security of data subject's personal data.
    /// <see href="https://w3id.org/GDPRtEXT#SecurityOfPersonalData"></see></summary>
    let SecurityOfPersonalData =
        Namespaced_IRI.parse _namespace_name "SecurityOfPersonalData" |> NamespacedName

    /// <summary>
    /// The obligation or activity coult not be completed because the data was inferred or derived, and therefore did not come from the data subject or other sources.
    /// <see href="https://w3id.org/GDPRtEXT#DataWasInferredOrDerived"></see></summary>
    let DataWasInferredOrDerived =
        Namespaced_IRI.parse _namespace_name "DataWasInferredOrDerived" |> NamespacedName

    /// <summary>
    /// Exclusions and Exemptions provided by the GDPR for not complying with the specified obligations.
    /// <see href="https://w3id.org/GDPRtEXT#ExclusionException"></see></summary>
    let ExclusionException =
        Namespaced_IRI.parse _namespace_name "ExclusionException" |> NamespacedName

    /// <summary>
    /// The act of demonstrating consent is an activity whereby previously acquired consent is provided as sufficient justification for processing activities involving data subject's personal information.
    /// <see href="https://w3id.org/GDPRtEXT#DemonstratingConsent"></see></summary>
    let DemonstratingConsent =
        Namespaced_IRI.parse _namespace_name "DemonstratingConsent" |> NamespacedName

    /// <summary>
    /// Consent is termed to be valid if it passes all the criteria or obligations laid down by the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#ValidConsent"></see></summary>
    let ValidConsent =
        Namespaced_IRI.parse _namespace_name "ValidConsent" |> NamespacedName

    /// <summary>
    /// Type of  Marketing that reaches data subjects directly by communications directly addressed to the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#DirectMarketing"></see></summary>
    let DirectMarketing =
        Namespaced_IRI.parse _namespace_name "DirectMarketing" |> NamespacedName

    /// <summary>
    /// The process or technique of promoting, selling, and distributing a product or service.
    /// <see href="https://w3id.org/GDPRtEXT#Marketing"></see></summary>
    let Marketing = Namespaced_IRI.parse _namespace_name "Marketing" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is provided by Employment Law
    /// <see href="https://w3id.org/GDPRtEXT#EmploymentLaw"></see></summary>
    let EmploymentLaw =
        Namespaced_IRI.parse _namespace_name "EmploymentLaw" |> NamespacedName

    /// <summary>
    /// The right of erasure applies when the data subject withdraws given consent
    /// <see href="https://w3id.org/GDPRtEXT#EraseWhenConsentWasWithdrawn"></see></summary>
    let EraseWhenConsentWasWithdrawn =
        Namespaced_IRI.parse _namespace_name "EraseWhenConsentWasWithdrawn" |> NamespacedName

    /// <summary>
    /// The data subject has the right to obtain erasure of their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightOfErasure"></see></summary>
    let RightOfErasure =
        Namespaced_IRI.parse _namespace_name "RightOfErasure" |> NamespacedName

    /// <summary>
    /// The right to erasure applies where data is no longer needed for original purposes for which it was collected
    /// <see href="https://w3id.org/GDPRtEXT#EraseWhenDataIsNoLongerNeededForOriginalPurpose"></see></summary>
    let EraseWhenDataIsNoLongerNeededForOriginalPurpose =
        Namespaced_IRI.parse _namespace_name "EraseWhenDataIsNoLongerNeededForOriginalPurpose" |> NamespacedName

    /// <summary>
    /// Whether the proposed activity involves the evaluation of the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#EvaluationOfDataSubject"></see></summary>
    let EvaluationOfDataSubject =
        Namespaced_IRI.parse _namespace_name "EvaluationOfDataSubject" |> NamespacedName

    /// <summary>
    /// The act of reporting a data breach to entities mentioned within the GDPR. These are the Data Protection Authority (DPA), and in the case of Processors, the Controller they have an agreement with.
    /// <see href="https://w3id.org/GDPRtEXT#ReportDataBreach"></see></summary>
    let ReportDataBreach =
        Namespaced_IRI.parse _namespace_name "ReportDataBreach" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is provided by National Law
    /// <see href="https://w3id.org/GDPRtEXT#ExemptedByNationalLaw"></see></summary>
    let ExemptedByNationalLaw =
        Namespaced_IRI.parse _namespace_name "ExemptedByNationalLaw" |> NamespacedName

    /// <summary>
    /// The request or activity could not or was not completed because there was no sufficient proof of the data subject's identity.
    /// <see href="https://w3id.org/GDPRtEXT#ExemptedWithoutProofOfDataSubjectIdentity"></see></summary>
    let ExemptedWithoutProofOfDataSubjectIdentity =
        Namespaced_IRI.parse _namespace_name "ExemptedWithoutProofOfDataSubjectIdentity" |> NamespacedName

    /// <summary>
    /// Activity where the data subject is explicitly identified through direct or indirect means.
    /// <see href="https://w3id.org/GDPRtEXT#IdentificationOfDataSubject"></see></summary>
    let IdentificationOfDataSubject =
        Namespaced_IRI.parse _namespace_name "IdentificationOfDataSubject" |> NamespacedName

    /// <summary>
    /// The activity represents exercising of rights provided by GDPR by the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#ExerciseRights"></see></summary>
    let ExerciseRights =
        Namespaced_IRI.parse _namespace_name "ExerciseRights" |> NamespacedName

    /// <summary>
    /// The purpose of new processing should take into context the existence of appropriate safeguards
    /// <see href="https://w3id.org/GDPRtEXT#ExistenceOfSafeguards"></see></summary>
    let ExistenceOfSafeguards =
        Namespaced_IRI.parse _namespace_name "ExistenceOfSafeguards" |> NamespacedName

    /// <summary>
    /// The activity wherein the controller carries out an assessment of the impact of the envisaged processing operations on the protection of personal data.
    /// <see href="https://w3id.org/GDPRtEXT#ImpactAssessment"></see></summary>
    let ImpactAssessment =
        Namespaced_IRI.parse _namespace_name "ImpactAssessment" |> NamespacedName

    /// <summary>
    /// The stated obligation could not be completed as it concerns rights protection.
    /// <see href="https://w3id.org/GDPRtEXT#FreedomsProtection"></see></summary>
    let FreedomsProtection =
        Namespaced_IRI.parse _namespace_name "FreedomsProtection" |> NamespacedName

    /// <summary>
    /// GDPR obligation that specifies consent must be freely given by the data subject for it to be valid.
    /// <see href="https://w3id.org/GDPRtEXT#FreelyGivenConsentObligation"></see></summary>
    let FreelyGivenConsentObligation =
        Namespaced_IRI.parse _namespace_name "FreelyGivenConsentObligation" |> NamespacedName

    /// <summary>
    /// The act of getting a data subject's consent.
    /// <see href="https://w3id.org/GDPRtEXT#ObtainingConsent"></see></summary>
    let ObtainingConsent =
        Namespaced_IRI.parse _namespace_name "ObtainingConsent" |> NamespacedName

    /// <summary>
    /// Personal data relating to the inherited or acquired genetic characteristics of a natural person which result from the analysis of a biological sample from the natural person in question, in particular chromosomal, deoxyribonucleic acid (DNA) or ribonucleic acid (RNA) analysis, or from the analysis of another element enabling equivalent information to be obtained.
    /// <see href="https://w3id.org/GDPRtEXT#GeneticData"></see></summary>
    let GeneticData =
        Namespaced_IRI.parse _namespace_name "GeneticData" |> NamespacedName

    /// <summary>
    /// The data subjects were not notified about the data breach because the harm was deemed to be remote.
    /// <see href="https://w3id.org/GDPRtEXT#HarmWasRemote"></see></summary>
    let HarmWasRemote =
        Namespaced_IRI.parse _namespace_name "HarmWasRemote" |> NamespacedName

    /// <summary>
    /// Personal data related to the physical or mental health of a natural person, including the provision of health care services, which reveal information about his or her health status.
    /// <see href="https://w3id.org/GDPRtEXT#HealthData"></see></summary>
    let HealthData = Namespaced_IRI.parse _namespace_name "HealthData" |> NamespacedName

    /// <summary>
    /// Lawful basis if provided by the GDPR for processing related to historic, statistical, or scientific purposes.
    /// <see href="https://w3id.org/GDPRtEXT#HistoricStatisticScientificPurposes"></see></summary>
    let HistoricStatisticScientificPurposes =
        Namespaced_IRI.parse _namespace_name "HistoricStatisticScientificPurposes" |> NamespacedName

    /// <summary>
    /// Retention of personal data should be identifiable for the requried processing
    /// <see href="https://w3id.org/GDPRtEXT#IdentifiableForRequiredProcessing"></see></summary>
    let IdentifiableForRequiredProcessing =
        Namespaced_IRI.parse _namespace_name "IdentifiableForRequiredProcessing" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about whether and where the controller is processing the data subject's personal data
    /// <see href="https://w3id.org/GDPRtEXT#IfAndWhereControllerIsProcessingData"></see></summary>
    let IfAndWhereControllerIsProcessingData =
        Namespaced_IRI.parse _namespace_name "IfAndWhereControllerIsProcessingData" |> NamespacedName

    /// <summary>
    /// The data subject shall have the right to obtain from the controller confirmation as to whether or not personal data concerning him or her are being processed, and, where that is the case, access to the personal data along with additional information about it.
    /// <see href="https://w3id.org/GDPRtEXT#RightToAccessPersonalData"></see></summary>
    let RightToAccessPersonalData =
        Namespaced_IRI.parse _namespace_name "RightToAccessPersonalData" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to implement the required technical measures necessary for compliance of the GDPR
    /// <see href="https://w3id.org/GDPRtEXT#ImplementTechnicalMeasuresForCompliance"></see></summary>
    let ImplementTechnicalMeasuresForCompliance =
        Namespaced_IRI.parse _namespace_name "ImplementTechnicalMeasuresForCompliance" |> NamespacedName

    /// <summary>
    /// The processor must impose confidentiality agreements on its personnel in relation to handling of personal data
    /// <see href="https://w3id.org/GDPRtEXT#ImposeConfidentialityObligationOnPersonnel"></see></summary>
    let ImposeConfidentialityObligationOnPersonnel =
        Namespaced_IRI.parse _namespace_name "ImposeConfidentialityObligationOnPersonnel" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about automated processing that has significant effects on the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject"></see></summary>
    let InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject =
        Namespaced_IRI.parse _namespace_name "InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about the categories of recipients the data is shared with.
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutCategoriesOfRecipientsDataSharedWith"></see></summary>
    let InfoAboutCategoriesOfRecipientsDataSharedWith =
        Namespaced_IRI.parse _namespace_name "InfoAboutCategoriesOfRecipientsDataSharedWith" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the categories of recipients the personal data was shared with.
    /// <see href="https://w3id.org/GDPRtEXT#RecordCategoriesOfRecipientsWhereDataShared"></see></summary>
    let RecordCategoriesOfRecipientsWhereDataShared =
        Namespaced_IRI.parse _namespace_name "RecordCategoriesOfRecipientsWhereDataShared" |> NamespacedName

    /// <summary>
    /// This activity represents the sharing of data subject's personal data with a third party.
    /// <see href="https://w3id.org/GDPRtEXT#ShareDataWithThirdParty"></see></summary>
    let ShareDataWithThirdParty =
        Namespaced_IRI.parse _namespace_name "ShareDataWithThirdParty" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about categories of data being processed
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutCatgegoriesOfDataBeingProcessed"></see></summary>
    let InfoAboutCatgegoriesOfDataBeingProcessed =
        Namespaced_IRI.parse _namespace_name "InfoAboutCatgegoriesOfDataBeingProcessed" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about the existence of rights provided by the GDPR to the data subject
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutExistenceOfRights"></see></summary>
    let InfoAboutExistenceOfRights =
        Namespaced_IRI.parse _namespace_name "InfoAboutExistenceOfRights" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about the processing of personal data of the data subject
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutProcessing"></see></summary>
    let InfoAboutProcessing =
        Namespaced_IRI.parse _namespace_name "InfoAboutProcessing" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about the source of the personal data
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutSourceOfData"></see></summary>
    let InfoAboutSourceOfData =
        Namespaced_IRI.parse _namespace_name "InfoAboutSourceOfData" |> NamespacedName

    /// <summary>
    /// The right to access personal data also includes information about the storage period of the data subject's personal data
    /// <see href="https://w3id.org/GDPRtEXT#InfoAboutStoragePeriod"></see></summary>
    let InfoAboutStoragePeriod =
        Namespaced_IRI.parse _namespace_name "InfoAboutStoragePeriod" |> NamespacedName

    /// <summary>
    /// In case of conflict with the controller's intructions and the law, the processor must immediately inform the controller of this conflict
    /// <see href="https://w3id.org/GDPRtEXT#InformControllerOfConflictWithLaw"></see></summary>
    let InformControllerOfConflictWithLaw =
        Namespaced_IRI.parse _namespace_name "InformControllerOfConflictWithLaw" |> NamespacedName

    /// <summary>
    /// The right to basic information also provides data subject's with information about third parties involved in the processing.
    /// <see href="https://w3id.org/GDPRtEXT#InformationAboutThirdParties"></see></summary>
    let InformationAboutThirdParties =
        Namespaced_IRI.parse _namespace_name "InformationAboutThirdParties" |> NamespacedName

    /// <summary>
    /// The right to basic information about processing provides data subjects with information about the processing activities involving their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightToBasicInformationAboutProcessing"></see></summary>
    let RightToBasicInformationAboutProcessing =
        Namespaced_IRI.parse _namespace_name "RightToBasicInformationAboutProcessing" |> NamespacedName

    /// <summary>
    /// The information provided under the right to transparency should be concise
    /// <see href="https://w3id.org/GDPRtEXT#InformationShouldBeConcise"></see></summary>
    let InformationShouldBeConcise =
        Namespaced_IRI.parse _namespace_name "InformationShouldBeConcise" |> NamespacedName

    /// <summary>
    /// The right to transparency requires controllers to provide information about the processing activities as well as personal data and its usage in a transparent manner
    /// <see href="https://w3id.org/GDPRtEXT#RightToTransparency"></see></summary>
    let RightToTransparency =
        Namespaced_IRI.parse _namespace_name "RightToTransparency" |> NamespacedName

    /// <summary>
    /// The information provided under the right to transparency should be easily accessible
    /// <see href="https://w3id.org/GDPRtEXT#InformationShouldBeEasilyAccessible"></see></summary>
    let InformationShouldBeEasilyAccessible =
        Namespaced_IRI.parse _namespace_name "InformationShouldBeEasilyAccessible" |> NamespacedName

    /// <summary>
    /// The information provided under the right to transparency should be intelligible
    /// <see href="https://w3id.org/GDPRtEXT#InformationShouldBeIntelligible"></see></summary>
    let InformationShouldBeIntelligible =
        Namespaced_IRI.parse _namespace_name "InformationShouldBeIntelligible" |> NamespacedName

    /// <summary>
    /// The information provided under the right to transparency should be transparent and clear (i.e. not umambigious or vague)
    /// <see href="https://w3id.org/GDPRtEXT#InformationShouldBeTransparent"></see></summary>
    let InformationShouldBeTransparent =
        Namespaced_IRI.parse _namespace_name "InformationShouldBeTransparent" |> NamespacedName

    /// <summary>
    /// The principle of lawfulness, fairness, and transparency states that personal data must be processed lawfully, fairly and in a transparent manner in relation to the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#LawfulnessFairnessAndTransparency"></see></summary>
    let LawfulnessFairnessAndTransparency =
        Namespaced_IRI.parse _namespace_name "LawfulnessFairnessAndTransparency" |> NamespacedName

    /// <summary>
    /// GDPR obligation that specifies consent must be informed for it be valid.
    /// <see href="https://w3id.org/GDPRtEXT#InformedConsentObligation"></see></summary>
    let InformedConsentObligation =
        Namespaced_IRI.parse _namespace_name "InformedConsentObligation" |> NamespacedName

    /// <summary>
    /// The principle of integrity and confidentiality states that personal data must be  processed in a manner that ensures appropriate security of the personal data, including protection against unauthorised or unlawful processing and against accidental loss, destruction or damage, using appropriate technical or organisational measures.
    /// <see href="https://w3id.org/GDPRtEXT#IntegrityAndConfidentiality"></see></summary>
    let IntegrityAndConfidentiality =
        Namespaced_IRI.parse _namespace_name "IntegrityAndConfidentiality" |> NamespacedName

    /// <summary>
    /// Protection of data subject's personal data  against destruction of data.
    /// <see href="https://w3id.org/GDPRtEXT#ProtectionAgainstDestruction"></see></summary>
    let ProtectionAgainstDestruction =
        Namespaced_IRI.parse _namespace_name "ProtectionAgainstDestruction" |> NamespacedName

    /// <summary>
    /// Protection of data subject's personal data  against damage to the data.
    /// <see href="https://w3id.org/GDPRtEXT#ProtectionAgainstDamage"></see></summary>
    let ProtectionAgainstDamage =
        Namespaced_IRI.parse _namespace_name "ProtectionAgainstDamage" |> NamespacedName

    /// <summary>
    /// Protection of data subject's personal data  against accidental loss.
    /// <see href="https://w3id.org/GDPRtEXT#ProtectionAgainstAccidentalLoss"></see></summary>
    let ProtectionAgainstAccidentalLoss =
        Namespaced_IRI.parse _namespace_name "ProtectionAgainstAccidentalLoss" |> NamespacedName

    /// <summary>
    /// The obligation or activity could not be completed as it was deemed to be impossible.
    /// <see href="https://w3id.org/GDPRtEXT#IsImpossible"></see></summary>
    let IsImpossible =
        Namespaced_IRI.parse _namespace_name "IsImpossible" |> NamespacedName

    /// <summary>
    /// A joint controller is two or more controllers jointly determine the purposes and means of processing.
    /// <see href="https://w3id.org/GDPRtEXT#JointController"></see></summary>
    let JointController =
        Namespaced_IRI.parse _namespace_name "JointController" |> NamespacedName

    /// <summary>
    /// The processing of personal data at a large scale of quantity or significant proportions.
    /// <see href="https://w3id.org/GDPRtEXT#LargeScaleProcessing"></see></summary>
    let LargeScaleProcessing =
        Namespaced_IRI.parse _namespace_name "LargeScaleProcessing" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is provided by legal claims.
    /// <see href="https://w3id.org/GDPRtEXT#LegalClaims"></see></summary>
    let LegalClaims =
        Namespaced_IRI.parse _namespace_name "LegalClaims" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is covered by legal obligation(s).
    /// <see href="https://w3id.org/GDPRtEXT#LegalObligation"></see></summary>
    let LegalObligation =
        Namespaced_IRI.parse _namespace_name "LegalObligation" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is provided through the legitimate interests pursued by the Controller or by a third party
    /// <see href="https://w3id.org/GDPRtEXT#LegitimateInterest"></see></summary>
    let LegitimateInterest =
        Namespaced_IRI.parse _namespace_name "LegitimateInterest" |> NamespacedName

    /// <summary>
    /// This specifies that the collection (or collected) personal data should be used/specified to be used for legitimate purposes.
    /// <see href="https://w3id.org/GDPRtEXT#LegitimatePurpose"></see></summary>
    let LegitimatePurpose =
        Namespaced_IRI.parse _namespace_name "LegitimatePurpose" |> NamespacedName

    /// <summary>
    /// These specify the liability of Joint Controllers, i.e. cases where more than one Controller share the responsiblity.
    /// <see href="https://w3id.org/GDPRtEXT#LiabilityOfJointController"></see></summary>
    let LiabilityOfJointController =
        Namespaced_IRI.parse _namespace_name "LiabilityOfJointController" |> NamespacedName

    /// <summary>
    /// Personal data retained should be limited in its use only for the requried processing
    /// <see href="https://w3id.org/GDPRtEXT#LimitedForProcessing"></see></summary>
    let LimitedForProcessing =
        Namespaced_IRI.parse _namespace_name "LimitedForProcessing" |> NamespacedName

    /// <summary>
    /// Whether there is a link between the new and old purposes of processing
    /// <see href="https://w3id.org/GDPRtEXT#LinkBetweenNewAndOldPurpose"></see></summary>
    let LinkBetweenNewAndOldPurpose =
        Namespaced_IRI.parse _namespace_name "LinkBetweenNewAndOldPurpose" |> NamespacedName

    /// <summary>
    /// Lawful basis is provided through the data being publicly made available by the data subject
    /// <see href="https://w3id.org/GDPRtEXT#MadePublicByDataSubject"></see></summary>
    let MadePublicByDataSubject =
        Namespaced_IRI.parse _namespace_name "MadePublicByDataSubject" |> NamespacedName

    /// <summary>
    /// GDPR mandates the recording of data breaches and its effects.
    /// <see href="https://w3id.org/GDPRtEXT#MaintainRecordOfBreach"></see></summary>
    let MaintainRecordOfBreach =
        Namespaced_IRI.parse _namespace_name "MaintainRecordOfBreach" |> NamespacedName

    /// <summary>
    /// This obligation requires the Controller/Processor to maintain adequate records about their processing activities.
    /// <see href="https://w3id.org/GDPRtEXT#MaintainRecordsOfProcessingActivities"></see></summary>
    let MaintainRecordsOfProcessingActivities =
        Namespaced_IRI.parse _namespace_name "MaintainRecordsOfProcessingActivities" |> NamespacedName

    /// <summary>
    /// Lawful basis for processing is provided by the GDPR for medical or diagnostics purposes pertaining to the data subject
    /// <see href="https://w3id.org/GDPRtEXT#MedicalDiagnosisTreatment"></see></summary>
    let MedicalDiagnosisTreatment =
        Namespaced_IRI.parse _namespace_name "MedicalDiagnosisTreatment" |> NamespacedName

    /// <summary>
    /// The stated obligation could not be completed as it concerns national security.
    /// <see href="https://w3id.org/GDPRtEXT#NationalSecurity"></see></summary>
    let NationalSecurity =
        Namespaced_IRI.parse _namespace_name "NationalSecurity" |> NamespacedName

    /// <summary>
    /// The nature of the personal data involved, whether it is sensitive or confidential.
    /// <see href="https://w3id.org/GDPRtEXT#NatureOfPersonalData"></see></summary>
    let NatureOfPersonalData =
        Namespaced_IRI.parse _namespace_name "NatureOfPersonalData" |> NamespacedName

    /// <summary>
    /// The right to access personal data should not incur any undue charge levied on the data subject for exercising their right
    /// <see href="https://w3id.org/GDPRtEXT#NoChargeLeviedForRightToAccess"></see></summary>
    let NoChargeLeviedForRightToAccess =
        Namespaced_IRI.parse _namespace_name "NoChargeLeviedForRightToAccess" |> NamespacedName

    /// <summary>
    /// Lawful basis is provided by the GDPR for activities of/for not-for-profit organisations
    /// <see href="https://w3id.org/GDPRtEXT#NotForProfitOrg"></see></summary>
    let NotForProfitOrg =
        Namespaced_IRI.parse _namespace_name "NotForProfitOrg" |> NamespacedName

    /// <summary>
    /// Consent should not be obtained from silence or inactivity of the data subject
    /// <see href="https://w3id.org/GDPRtEXT#NotFromSilenceOrInactivityConsentObligation"></see></summary>
    let NotFromSilenceOrInactivityConsentObligation =
        Namespaced_IRI.parse _namespace_name "NotFromSilenceOrInactivityConsentObligation" |> NamespacedName

    /// <summary>
    /// This obligation specifies that the collected personal data should not be processed beyond the purpose for which it was originally collected without an updated consent for the proposed purposes.
    /// <see href="https://w3id.org/GDPRtEXT#NotFurtherProcessedThanOriginalPurpose"></see></summary>
    let NotFurtherProcessedThanOriginalPurpose =
        Namespaced_IRI.parse _namespace_name "NotFurtherProcessedThanOriginalPurpose" |> NamespacedName

    /// <summary>
    /// The data subjects were not notified about the data breach because it required disproportionate efforts.
    /// <see href="https://w3id.org/GDPRtEXT#NotificationRequiresDisproportionateEfforts"></see></summary>
    let NotificationRequiresDisproportionateEfforts =
        Namespaced_IRI.parse _namespace_name "NotificationRequiresDisproportionateEfforts" |> NamespacedName

    /// <summary>
    /// The stated obligation or activity could not be completed as it requires disproportionate efforts to complete.
    /// <see href="https://w3id.org/GDPRtEXT#RequiresDisproportionateEfforts"></see></summary>
    let RequiresDisproportionateEfforts =
        Namespaced_IRI.parse _namespace_name "RequiresDisproportionateEfforts" |> NamespacedName

    /// <summary>
    /// Affected data subject's must be notified about the consequences of the data breach.
    /// <see href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutConsequencesOfDataBreach"></see></summary>
    let NotifyDataSubjectAboutConsequencesOfDataBreach =
        Namespaced_IRI.parse _namespace_name "NotifyDataSubjectAboutConsequencesOfDataBreach" |> NamespacedName

    /// <summary>
    /// Affected data subjects must be notified of the data breach and its effects.
    /// <see href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfBreach"></see></summary>
    let NotifyDataSubjectOfBreach =
        Namespaced_IRI.parse _namespace_name "NotifyDataSubjectOfBreach" |> NamespacedName

    /// <summary>
    /// Affect data subjets must be notified of the measures taken against the data breach.
    /// <see href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfMeasuresTakenForDataBreach"></see></summary>
    let NotifyDataSubjectOfMeasuresTakenForDataBreach =
        Namespaced_IRI.parse _namespace_name "NotifyDataSubjectOfMeasuresTakenForDataBreach" |> NamespacedName

    /// <summary>
    /// The processor must only act on the intructions provided and documented by the controller
    /// <see href="https://w3id.org/GDPRtEXT#OnlyActOnDocumentedInstructionFromController"></see></summary>
    let OnlyActOnDocumentedInstructionFromController =
        Namespaced_IRI.parse _namespace_name "OnlyActOnDocumentedInstructionFromController" |> NamespacedName

    /// <summary>
    /// The activity was deemed to be outside the material scope of the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#OutsideMaterialScope"></see></summary>
    let OutsideMaterialScope =
        Namespaced_IRI.parse _namespace_name "OutsideMaterialScope" |> NamespacedName

    /// <summary>
    /// Point in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    /// The possible consequences of the change in processing for the data subject
    /// <see href="https://w3id.org/GDPRtEXT#PossibleConsequenceForDataSubject"></see></summary>
    let PossibleConsequenceForDataSubject =
        Namespaced_IRI.parse _namespace_name "PossibleConsequenceForDataSubject" |> NamespacedName

    /// <summary>
    /// Privacy by Design is the approach of taking privacy into consideration throughout the whole planning and execution processes.
    /// <see href="https://w3id.org/GDPRtEXT#PrivacyByDesign"></see></summary>
    let PrivacyByDesign =
        Namespaced_IRI.parse _namespace_name "PrivacyByDesign" |> NamespacedName

    /// <summary>
    /// An activity that uses personal data
    /// <see href="https://w3id.org/GDPRtEXT#UseData"></see></summary>
    let UseData = Namespaced_IRI.parse _namespace_name "UseData" |> NamespacedName

    /// <summary>
    /// This type of processing involves data subjects that are vulnerable, such as children, or people with disabilities.
    /// <see href="https://w3id.org/GDPRtEXT#ProcessingAffectedVulnerableIndividuals"></see></summary>
    let ProcessingAffectedVulnerableIndividuals =
        Namespaced_IRI.parse _namespace_name "ProcessingAffectedVulnerableIndividuals" |> NamespacedName

    /// <summary>
    /// The data subject can exercise the right to restrict processing of their personal data when the processing is unlawful
    /// <see href="https://w3id.org/GDPRtEXT#ProcessingIsUnlawful"></see></summary>
    let ProcessingIsUnlawful =
        Namespaced_IRI.parse _namespace_name "ProcessingIsUnlawful" |> NamespacedName

    /// <summary>
    /// Processing of personal data that is termed to be unlawful in the context of the GDPR or other relevant laws and regulations
    /// <see href="https://w3id.org/GDPRtEXT#UnlawfulProcessing"></see></summary>
    let UnlawfulProcessing =
        Namespaced_IRI.parse _namespace_name "UnlawfulProcessing" |> NamespacedName

    /// <summary>
    /// This involves processing involving sensitive personal data.
    /// <see href="https://w3id.org/GDPRtEXT#ProcessingSensitiveData"></see></summary>
    let ProcessingSensitiveData =
        Namespaced_IRI.parse _namespace_name "ProcessingSensitiveData" |> NamespacedName

    /// <summary>
    /// This type of processing uses technologies that are new or have not yet been deemed to be fit or stable for usage.
    /// <see href="https://w3id.org/GDPRtEXT#ProcessingUsingUntestedTechnologies"></see></summary>
    let ProcessingUsingUntestedTechnologies =
        Namespaced_IRI.parse _namespace_name "ProcessingUsingUntestedTechnologies" |> NamespacedName

    /// <summary>
    /// Signifies the agreement between Controller and Processors for processing of personal data
    /// <see href="https://w3id.org/GDPRtEXT#ProcessorControllerAgreement"></see></summary>
    let ProcessorControllerAgreement =
        Namespaced_IRI.parse _namespace_name "ProcessorControllerAgreement" |> NamespacedName

    /// <summary>
    /// A natural or legal person established in the Union who, designated by the processor in writing, represents the processor with regard to their respective obligations under the GDPR.
    /// <see href="https://w3id.org/GDPRtEXT#ProcessorRepresentative"></see></summary>
    let ProcessorRepresentative =
        Namespaced_IRI.parse _namespace_name "ProcessorRepresentative" |> NamespacedName

    /// <summary>
    /// To propogate a data subject's right once they have been exercised to other third parties that are involved through the data subject's personal data.
    /// <see href="https://w3id.org/GDPRtEXT#PropogateRightsToThirdParties"></see></summary>
    let PropogateRightsToThirdParties =
        Namespaced_IRI.parse _namespace_name "PropogateRightsToThirdParties" |> NamespacedName

    /// <summary>
    /// Protection of data subject's personal data  against unlawful processing of data.
    /// <see href="https://w3id.org/GDPRtEXT#ProtectionAgainstUnlawfulProcessing"></see></summary>
    let ProtectionAgainstUnlawfulProcessing =
        Namespaced_IRI.parse _namespace_name "ProtectionAgainstUnlawfulProcessing" |> NamespacedName

    /// <summary>
    /// The processor must provide the controller with the information necessary to demonstrate compliance
    /// <see href="https://w3id.org/GDPRtEXT#ProvideControllerWithInfoForCompliance"></see></summary>
    let ProvideControllerWithInfoForCompliance =
        Namespaced_IRI.parse _namespace_name "ProvideControllerWithInfoForCompliance" |> NamespacedName

    /// <summary>
    /// The right of data portability requries providing a copy of the data subject's personal data
    /// <see href="https://w3id.org/GDPRtEXT#ProvideCopyOfPersonalData"></see></summary>
    let ProvideCopyOfPersonalData =
        Namespaced_IRI.parse _namespace_name "ProvideCopyOfPersonalData" |> NamespacedName

    /// <summary>
    /// The data subject has the right to receive the personal data concerning him or her, which he or she has provided to a controller, in a structured, commonly used and machine-readable format and has the right to transmit those data to another controller without hindrance from the controller to which the personal data have been provided.
    /// <see href="https://w3id.org/GDPRtEXT#RightOfDataPortability"></see></summary>
    let RightOfDataPortability =
        Namespaced_IRI.parse _namespace_name "RightOfDataPortability" |> NamespacedName

    /// <summary>
    /// Personal data that can no longer be attributed to a specific data subject without the use of additional information.
    /// <see href="https://w3id.org/GDPRtEXT#PseudoAnonymousData"></see></summary>
    let PseudoAnonymousData =
        Namespaced_IRI.parse _namespace_name "PseudoAnonymousData" |> NamespacedName

    /// <summary>
    /// Lawful basis is provided by the GDPR as being in the interest of the public
    /// <see href="https://w3id.org/GDPRtEXT#PublicInterest"></see></summary>
    let PublicInterest =
        Namespaced_IRI.parse _namespace_name "PublicInterest" |> NamespacedName

    /// <summary>
    /// The principle of purpose limitation states that personal data must be collected for specified, explicit and legitimate purposes and not further processed in a manner that is incompatible with those purposes; further processing for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes shall, in accordance with Article 89(1) of the GDPR, not be considered to be incompatible with the initial purposes.
    /// <see href="https://w3id.org/GDPRtEXT#PurposeLimitation"></see></summary>
    let PurposeLimitation =
        Namespaced_IRI.parse _namespace_name "PurposeLimitation" |> NamespacedName

    /// <summary>
    /// Related to Regulation (EC) No. 45/2001
    /// <see href="https://w3id.org/GDPRtEXT#R17"></see></summary>
    let R17 = Namespaced_IRI.parse _namespace_name "R17" |> NamespacedName
    /// <summary>
    /// Exempted as the GDPR does not apply to personal or household activity that does not have a professional or commercial activity associated with it.
    /// <see href="https://w3id.org/GDPRtEXT#R18"></see></summary>
    let R18 = Namespaced_IRI.parse _namespace_name "R18" |> NamespacedName
    /// <summary>
    /// Exempted as it involves areas covered by Directive (EU) 2016/680
    /// <see href="https://w3id.org/GDPRtEXT#R19"></see></summary>
    let R19 = Namespaced_IRI.parse _namespace_name "R19" |> NamespacedName
    /// <summary>
    /// Personal data revealing racial or ethnic origin.
    /// <see href="https://w3id.org/GDPRtEXT#RacialData"></see></summary>
    let RacialData = Namespaced_IRI.parse _namespace_name "RacialData" |> NamespacedName
    /// <summary>
    /// Regulation in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Recital"></see></summary>
    let Recital = Namespaced_IRI.parse _namespace_name "Recital" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the categories of data subjects and the personal data involved in processing/activities.
    /// <see href="https://w3id.org/GDPRtEXT#RecordCategoriesOfDataSubjectsAndPersonalData"></see></summary>
    let RecordCategoriesOfDataSubjectsAndPersonalData =
        Namespaced_IRI.parse _namespace_name "RecordCategoriesOfDataSubjectsAndPersonalData" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the cross-border data transfers.
    /// <see href="https://w3id.org/GDPRtEXT#RecordCrossBorderDataTransfer"></see></summary>
    let RecordCrossBorderDataTransfer =
        Namespaced_IRI.parse _namespace_name "RecordCrossBorderDataTransfer" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the data retention period of personal data.
    /// <see href="https://w3id.org/GDPRtEXT#RecordDataRetentionPeriod"></see></summary>
    let RecordDataRetentionPeriod =
        Namespaced_IRI.parse _namespace_name "RecordDataRetentionPeriod" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the purpose of processing associated with personal data and the given consent.
    /// <see href="https://w3id.org/GDPRtEXT#RecordPurposeOfProcessing"></see></summary>
    let RecordPurposeOfProcessing =
        Namespaced_IRI.parse _namespace_name "RecordPurposeOfProcessing" |> NamespacedName

    /// <summary>
    /// This obligation requires Controllers to record the measures taken to ensure adequate safety measures of personal data and the involved activities.
    /// <see href="https://w3id.org/GDPRtEXT#RecordSecurityMeasures"></see></summary>
    let RecordSecurityMeasures =
        Namespaced_IRI.parse _namespace_name "RecordSecurityMeasures" |> NamespacedName

    /// <summary>
    /// The authority responsible for regulating data protection laws.
    /// <see href="https://w3id.org/GDPRtEXT#RegulatoryAuthority"></see></summary>
    let RegulatoryAuthority =
        Namespaced_IRI.parse _namespace_name "RegulatoryAuthority" |> NamespacedName

    /// <summary>
    /// Any retained personal data must be relevant for subsiquent processing
    /// <see href="https://w3id.org/GDPRtEXT#RelevantForProcessing"></see></summary>
    let RelevantForProcessing =
        Namespaced_IRI.parse _namespace_name "RelevantForProcessing" |> NamespacedName

    /// <summary>
    /// The occurence of a data breach must be reported to the Data Protection Authority (DPA) within 72 hours
    /// <see href="https://w3id.org/GDPRtEXT#ReportDataBreachToDPAWithin72Hours"></see></summary>
    let ReportDataBreachToDPAWithin72Hours =
        Namespaced_IRI.parse _namespace_name "ReportDataBreachToDPAWithin72Hours" |> NamespacedName

    /// <summary>
    /// The occurence of a data breach must be reported to the Controller.
    /// <see href="https://w3id.org/GDPRtEXT#ReportDataBreachToController"></see></summary>
    let ReportDataBreachToController =
        Namespaced_IRI.parse _namespace_name "ReportDataBreachToController" |> NamespacedName

    /// <summary>
    /// Appointing a sub-processor requires the written consent of the controller specifying permission or consent
    /// <see href="https://w3id.org/GDPRtEXT#RequiresWrittenConsentOfControllerToAppointSubProcessor"></see></summary>
    let RequiresWrittenConsentOfControllerToAppointSubProcessor =
        Namespaced_IRI.parse _namespace_name "RequiresWrittenConsentOfControllerToAppointSubProcessor" |> NamespacedName

    /// <summary>
    /// These provide restrictions on cross-border transfers for Processors
    /// <see href="https://w3id.org/GDPRtEXT#RestrictionsOnCrossBorderTransfers"></see></summary>
    let RestrictionsOnCrossBorderTransfers =
        Namespaced_IRI.parse _namespace_name "RestrictionsOnCrossBorderTransfers" |> NamespacedName

    /// <summary>
    /// The processor must return or destroy personal data at the end of term (of its agreement with the controller)
    /// <see href="https://w3id.org/GDPRtEXT#ReturnOrDestroyPersonalDataAtEndTerm"></see></summary>
    let ReturnOrDestroyPersonalDataAtEndTerm =
        Namespaced_IRI.parse _namespace_name "ReturnOrDestroyPersonalDataAtEndTerm" |> NamespacedName

    /// <summary>
    /// The provided copy of personal data should be structured
    /// <see href="https://w3id.org/GDPRtEXT#ShouldBeStructured"></see></summary>
    let ShouldBeStructured =
        Namespaced_IRI.parse _namespace_name "ShouldBeStructured" |> NamespacedName

    /// <summary>
    /// The provided copy of personal data should be in a commonly used format
    /// <see href="https://w3id.org/GDPRtEXT#ShouldBeCommonlyUsedFormat"></see></summary>
    let ShouldBeCommonlyUsedFormat =
        Namespaced_IRI.parse _namespace_name "ShouldBeCommonlyUsedFormat" |> NamespacedName

    /// <summary>
    /// The provided copy of personal data should support reuse
    /// <see href="https://w3id.org/GDPRtEXT#ShouldSupportReuse"></see></summary>
    let ShouldSupportReuse =
        Namespaced_IRI.parse _namespace_name "ShouldSupportReuse" |> NamespacedName

    /// <summary>
    /// The provided copy of personal data should be machine readable
    /// <see href="https://w3id.org/GDPRtEXT#ShouldBeMachineReadable"></see></summary>
    let ShouldBeMachineReadable =
        Namespaced_IRI.parse _namespace_name "ShouldBeMachineReadable" |> NamespacedName

    /// <summary>
    /// The data subject has a right to not be evaluated through automated processing
    /// <see href="https://w3id.org/GDPRtEXT#RightToNotBeEvaluatedThroughAutomatedProcessing"></see></summary>
    let RightToNotBeEvaluatedThroughAutomatedProcessing =
        Namespaced_IRI.parse _namespace_name "RightToNotBeEvaluatedThroughAutomatedProcessing" |> NamespacedName

    /// <summary>
    /// The data subject has a right to object to direct marketting based on their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightToObjectForDirectMarketting"></see></summary>
    let RightToObjectForDirectMarketting =
        Namespaced_IRI.parse _namespace_name "RightToObjectForDirectMarketting" |> NamespacedName

    /// <summary>
    /// The data subject has the right to object to processing of their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightToObjectToProcessing"></see></summary>
    let RightToObjectToProcessing =
        Namespaced_IRI.parse _namespace_name "RightToObjectToProcessing" |> NamespacedName

    /// <summary>
    /// The data subject has a right to recitify their personal data
    /// <see href="https://w3id.org/GDPRtEXT#RightToRectification"></see></summary>
    let RightToRectification =
        Namespaced_IRI.parse _namespace_name "RightToRectification" |> NamespacedName

    /// <summary>
    /// The stated obligation could not be completed as it concerns freedoms protection.
    /// <see href="https://w3id.org/GDPRtEXT#RightsProtection"></see></summary>
    let RightsProtection =
        Namespaced_IRI.parse _namespace_name "RightsProtection" |> NamespacedName

    /// <summary>
    /// Section in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName

    /// <summary>
    /// Obtained consent should be in a demonstrable form
    /// <see href="https://w3id.org/GDPRtEXT#ShouldBeDemonstrable"></see></summary>
    let ShouldBeDemonstrable =
        Namespaced_IRI.parse _namespace_name "ShouldBeDemonstrable" |> NamespacedName

    /// <summary>
    /// Obtained consent should be distinguishable from other related matters (in the context of the process)
    /// <see href="https://w3id.org/GDPRtEXT#ShouldBeDistinguishableFromOtherMatters"></see></summary>
    let ShouldBeDistinguishableFromOtherMatters =
        Namespaced_IRI.parse _namespace_name "ShouldBeDistinguishableFromOtherMatters" |> NamespacedName

    /// <summary>
    /// GDPR obligation that specifies consent must be specific for it to be valid.
    /// <see href="https://w3id.org/GDPRtEXT#SpecificConsentObligation"></see></summary>
    let SpecificConsentObligation =
        Namespaced_IRI.parse _namespace_name "SpecificConsentObligation" |> NamespacedName

    /// <summary>
    /// The principle of storage limitation states that personal data must be kept in a form which permits identification of data subjects for no longer than is necessary for the purposes for which the personal data are processed; personal data may be stored for longer periods insofar as the personal data will be processed solely for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes in accordance with Article 89(1) of the GDPR subject to implementation of the appropriate technical and organisational measures required by this Regulation in order to safeguard the rights and freedoms of the data subject.
    /// <see href="https://w3id.org/GDPRtEXT#StorageLimitation"></see></summary>
    let StorageLimitation =
        Namespaced_IRI.parse _namespace_name "StorageLimitation" |> NamespacedName

    /// <summary>
    /// SubPoint in GDPR text
    /// <see href="https://w3id.org/GDPRtEXT#SubPoint"></see></summary>
    let SubPoint = Namespaced_IRI.parse _namespace_name "SubPoint" |> NamespacedName

    /// <summary>
    /// Sub-processors must follow the same rules and obligations (or terms) as the agreement between processor and controller.
    /// <see href="https://w3id.org/GDPRtEXT#SubProcessorMustFollowSameTermsAsProcessorControllerAgreement"></see></summary>
    let SubProcessorMustFollowSameTermsAsProcessorControllerAgreement =
        Namespaced_IRI.parse _namespace_name "SubProcessorMustFollowSameTermsAsProcessorControllerAgreement" |> NamespacedName

    /// <summary>
    /// This activity provides a systematic monitoring or overview of processes/activities taking place within the context of the organisation.
    /// <see href="https://w3id.org/GDPRtEXT#SystematicMonitoring"></see></summary>
    let SystematicMonitoring =
        Namespaced_IRI.parse _namespace_name "SystematicMonitoring" |> NamespacedName

    /// <summary>
    /// These are obligations pertaining to the vital interests of the data subjects
    /// <see href="https://w3id.org/GDPRtEXT#VitalInterest"></see></summary>
    let VitalInterest =
        Namespaced_IRI.parse _namespace_name "VitalInterest" |> NamespacedName

    /// <summary>
    /// Consent must be obtained through the data subject's voluntary action and should be opt-in and not opt-out or by default.
    /// <see href="https://w3id.org/GDPRtEXT#VoluntaryOptInConsentObligation"></see></summary>
    let VoluntaryOptInConsentObligation =
        Namespaced_IRI.parse _namespace_name "VoluntaryOptInConsentObligation" |> NamespacedName

    /// <summary>
    /// indicates the legal resource has the Article
    /// <see href="https://w3id.org/GDPRtEXT#hasArticle"></see></summary>
    let hasArticle = Namespaced_IRI.parse _namespace_name "hasArticle" |> NamespacedName
    /// <summary>
    /// indicates the legal resource has the Chapter
    /// <see href="https://w3id.org/GDPRtEXT#hasChapter"></see></summary>
    let hasChapter = Namespaced_IRI.parse _namespace_name "hasChapter" |> NamespacedName

    /// <summary>
    /// indicates that the legal resource has the referenced citation
    /// <see href="https://w3id.org/GDPRtEXT#hasCitation"></see></summary>
    let hasCitation =
        Namespaced_IRI.parse _namespace_name "hasCitation" |> NamespacedName

    /// <summary>
    /// indicates the legal resource has the Point
    /// <see href="https://w3id.org/GDPRtEXT#hasPoint"></see></summary>
    let hasPoint = Namespaced_IRI.parse _namespace_name "hasPoint" |> NamespacedName
    /// <summary>
    /// indicates the legal resource has the Recital
    /// <see href="https://w3id.org/GDPRtEXT#hasRecital"></see></summary>
    let hasRecital = Namespaced_IRI.parse _namespace_name "hasRecital" |> NamespacedName
    /// <summary>
    /// indicates the legal resource has the Section
    /// <see href="https://w3id.org/GDPRtEXT#hasSection"></see></summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName

    /// <summary>
    /// indicates the legal resource has the SubPoint
    /// <see href="https://w3id.org/GDPRtEXT#hasSubPoint"></see></summary>
    let hasSubPoint =
        Namespaced_IRI.parse _namespace_name "hasSubPoint" |> NamespacedName

    /// <summary>
    /// represents a legal resource subdivision to be part of a article
    /// <see href="https://w3id.org/GDPRtEXT#isPartOfArticle"></see></summary>
    let isPartOfArticle =
        Namespaced_IRI.parse _namespace_name "isPartOfArticle" |> NamespacedName

    /// <summary>
    /// represents a legal resource subdivision to be part of a chapter
    /// <see href="https://w3id.org/GDPRtEXT#isPartOfChapter"></see></summary>
    let isPartOfChapter =
        Namespaced_IRI.parse _namespace_name "isPartOfChapter" |> NamespacedName

    /// <summary>
    /// represents a legal resource subdivision to be part of a point
    /// <see href="https://w3id.org/GDPRtEXT#isPartOfPoint"></see></summary>
    let isPartOfPoint =
        Namespaced_IRI.parse _namespace_name "isPartOfPoint" |> NamespacedName

    /// <summary>
    /// represents a legal resource subdivision to be part of a section
    /// <see href="https://w3id.org/GDPRtEXT#isPartOfSection"></see></summary>
    let isPartOfSection =
        Namespaced_IRI.parse _namespace_name "isPartOfSection" |> NamespacedName
