#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gdprt =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/GDPRtEXT#" "gdprt"
    /// <summary>
    ///   <para>rdfs:comment : The principle of accountability states that the controller shall be responsible for, and be able to demonstrate compliance with the processing of personal data as defined by the justifications permissible under the GDPR</para>
    ///   <para>rdfs:label : Principle of Accountability^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Accountability">gdprt:Accountability</a>
    /// </summary>
    let Accountability = _prefixId.prefix "Accountability"
    /// <summary>
    ///   <para>rdfs:label : Principle of Accuracy^^xsd:string</para>
    ///   <para>rdfs:comment : The principle of accuracy states that personal data must be accurate and, where necessary, kept up to date; every reasonable step must be taken to ensure that personal data that are inaccurate, having regard to the purposes for which they are processed, are erased or rectified without delay.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Accuracy">gdprt:Accuracy</a>
    /// </summary>
    let Accuracy = _prefixId.prefix "Accuracy"
    /// <summary>
    ///   <para>rdfs:label : Accuracy is contested^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject can exercise the right to restrict processing of their personal data when the accuracy of personal data is contested</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AccuracyIsContested">gdprt:AccuracyIsContested</a>
    /// </summary>
    let AccuracyIsContested = _prefixId.prefix "AccuracyIsContested"
    /// <summary>
    ///   <para>rdfs:label : Accurate Collection^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation specifies that the collection of (or collected) personal data should in an accurate form - i.e. the personal data should be accurate.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AccurateCollection">gdprt:AccurateCollection</a>
    /// </summary>
    let AccurateCollection = _prefixId.prefix "AccurateCollection"
    /// <summary>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An Activity signifies some process(es) or step(s) towards specific deed(s), action(s), function(s), or sphere(s) of action.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Activity">gdprt:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Adequate for processing^^xsd:string</para>
    ///   <para>rdfs:comment : Only the personal data adequat for required processing should be maintained</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AdequateForProcessing">gdprt:AdequateForProcessing</a>
    /// </summary>
    let AdequateForProcessing = _prefixId.prefix "AdequateForProcessing"
    /// <summary>
    ///   <para>rdfs:label : Adherence^^xsd:string</para>
    ///   <para>rdfs:comment : The seal or certification does not reduce or impact the responsiblity of the controller or processor for compliance with the GDPR</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AdherenceToSealCertification">gdprt:AdherenceToSealCertification</a>
    /// </summary>
    let AdherenceToSealCertification = _prefixId.prefix "AdherenceToSealCertification"
    /// <summary>
    ///   <para>rdfs:label : Anonymous Data^^xsd:string</para>
    ///   <para>rdfs:comment : Data is termed to be anonymous if it cannot be connected or associated with individual person or persons that have provided or are associated with it.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AnonymousData">gdprt:AnonymousData</a>
    /// </summary>
    let AnonymousData = _prefixId.prefix "AnonymousData"
    /// <summary>
    ///   <para>rdfs:label : Appointing Sub-Processors^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations for Processors over appointing sub-processors</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AppointingSubProcessors">gdprt:AppointingSubProcessors</a>
    /// </summary>
    let AppointingSubProcessors = _prefixId.prefix "AppointingSubProcessors"
    /// <summary>
    ///   <para>rdfs:label : Appointment of Processors^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR for the appointment of Processors by Controllers.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AppointmentOfProcessors">gdprt:AppointmentOfProcessors</a>
    /// </summary>
    let AppointmentOfProcessors = _prefixId.prefix "AppointmentOfProcessors"
    /// <summary>
    ///   <para>rdfs:label : Archive Data^^xsd:string</para>
    ///   <para>rdfs:comment : An activity where personal data is archived^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ArchiveData">gdprt:ArchiveData</a>
    /// </summary>
    let ArchiveData = _prefixId.prefix "ArchiveData"
    /// <summary>
    ///   <para>skos:example : gdpr:article10 a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Article ;
    ///     eli:is_part_of gdpr:GDPR,
    ///         gdpr:chapterII ;
    ///     eli:number "10"^^xsd:string ;
    ///     eli:title_alternative "Article 10"^^xsd:string ;
    ///     GDPRtEXT:hasPoint gdpr:article10-1 ;
    ///     GDPRtEXT:isPartOfChapter gdpr:chapterII .^^xsd:string</para>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <para>rdfs:comment : Article in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Article">gdprt:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Assist in complying with rights^^xsd:string</para>
    ///   <para>rdfs:comment : Processors must assist Controllers in complying with the various rights provided by the GDPR to data subjects which can be exercised at any time.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AssistInComplyingWithRights">gdprt:AssistInComplyingWithRights</a>
    /// </summary>
    let AssistInComplyingWithRights = _prefixId.prefix "AssistInComplyingWithRights"

    /// <summary>
    ///   <para>rdfs:label : Automatic decision making with significant effect^^xsd:string</para>
    ///   <para>rdfs:comment : This type of processing involves automated processing that does decision making having significant effects on the data subject.rdfs:comment : Automated decision making with significant effect^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AutomatedDecisionMakingWithSignificantEffect">gdprt:AutomatedDecisionMakingWithSignificantEffect</a>
    /// </summary>
    let AutomatedDecisionMakingWithSignificantEffect =
        _prefixId.prefix "AutomatedDecisionMakingWithSignificantEffect"

    /// <summary>
    ///   <para>rdfs:label : Automated Processing^^xsd:string</para>
    ///   <para>rdfs:comment : This is automated processing of data subject's personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#AutomatedProcessing">gdprt:AutomatedProcessing</a>
    /// </summary>
    let AutomatedProcessing = _prefixId.prefix "AutomatedProcessing"

    /// <summary>
    ///   <para>rdfs:label : Can be withdrawn easily^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation states that the data subject should be able to withdraw the consent as easily as it was to give it.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CanBeWithdrawnEasilyConsentObligation">gdprt:CanBeWithdrawnEasilyConsentObligation</a>
    /// </summary>
    let CanBeWithdrawnEasilyConsentObligation =
        _prefixId.prefix "CanBeWithdrawnEasilyConsentObligation"

    /// <summary>
    ///   <para>rdfs:label : Certification^^xsd:string</para>
    ///   <para>rdfs:comment : A certification pertaining to GDPR compliance</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Certification">gdprt:Certification</a>
    /// </summary>
    let Certification = _prefixId.prefix "Certification"
    /// <summary>
    ///   <para>rdfs:label : Certification Body^^xsd:string</para>
    ///   <para>rdfs:comment : A Certification Body is an entity that can award/issue/renew a certification pertaining to compliance towards the GDPR.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CertificationBody">gdprt:CertificationBody</a>
    /// </summary>
    let CertificationBody = _prefixId.prefix "CertificationBody"
    /// <summary>
    ///   <para>skos:example : gdpr:chapterI a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Chapter ;
    ///     eli:is_part_of gdpr:GDPR ;
    ///     eli:number "I"^^xsd:string ;
    ///     eli:title "General provisions"^^xsd:string ;
    ///     eli:title_alternative "Chapter I"^^xsd:string ;
    ///     GDPRtEXT:hasArticle gdpr:article1,
    ///         gdpr:article2,
    ///         gdpr:article3,
    ///         gdpr:article4 .^^xsd:string</para>
    ///   <para>rdfs:label : Chapter^^xsd:string</para>
    ///   <para>rdfs:comment : Chapter in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Chapter">gdprt:Chapter</a>
    /// </summary>
    let Chapter = _prefixId.prefix "Chapter"
    /// <summary>
    ///   <para>skos:example : gdpr:citation1 a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Citation ;
    ///     eli:description "OJ C 229, 31.7.2012, p. 90."^^xsd:string ;
    ///     eli:is_part_of gdpr:GDPR ;
    ///     eli:number "1"^^xsd:string .^^xsd:string</para>
    ///   <para>rdfs:label : Citation^^xsd:string</para>
    ///   <para>rdfs:comment : Citation in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Citation">gdprt:Citation</a>
    /// </summary>
    let Citation = _prefixId.prefix "Citation"

    /// <summary>
    ///   <para>rdfs:label : Clear explanation^^xsd:string</para>
    ///   <para>rdfs:comment : Obtaining consent must provide clear explanations of the processing involved over the personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ClearExplanationOfProcessingConsentObligation">gdprt:ClearExplanationOfProcessingConsentObligation</a>
    /// </summary>
    let ClearExplanationOfProcessingConsentObligation =
        _prefixId.prefix "ClearExplanationOfProcessingConsentObligation"

    /// <summary>
    ///   <para>rdfs:label : Code of Conduct^^xsd:string</para>
    ///   <para>rdfs:comment : A Code of Conduct for the purpose of specifying the application of GDPR which may be monitored, evaluated, or processed by a third party appointed by the organisation.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CodeOfConduct">gdprt:CodeOfConduct</a>
    /// </summary>
    let CodeOfConduct = _prefixId.prefix "CodeOfConduct"
    /// <summary>
    ///   <para>rdfs:label : Collection Mechanism^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies collection mechanism used to collect personal data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CollectionMechanism">gdprt:CollectionMechanism</a>
    /// </summary>
    let CollectionMechanism = _prefixId.prefix "CollectionMechanism"
    /// <summary>
    ///   <para>rdfs:label : Collection of Personal Data</para>
    ///   <para>rdfs:comment : Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CollectionOfPersonalData">gdprt:CollectionOfPersonalData</a>
    /// </summary>
    let CollectionOfPersonalData = _prefixId.prefix "CollectionOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the act of complying with the obligations and actions specified by the GDPR.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Compliance">gdprt:Compliance</a>
    /// </summary>
    let Compliance = _prefixId.prefix "Compliance"

    /// <summary>
    ///   <para>rdfs:label : Compliance with Controller's instructions^^xsd:string</para>
    ///   <para>rdfs:comment : The processor has an obligation to comply with the controller's instructions</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ComplianceWithControllersInstructions">gdprt:ComplianceWithControllersInstructions</a>
    /// </summary>
    let ComplianceWithControllersInstructions =
        _prefixId.prefix "ComplianceWithControllersInstructions"

    /// <summary>
    ///   <para>rdfs:label : Awarding Seals and Certifications^^xsd:string</para>
    ///   <para>rdfs:comment : GDPR mentions some conditions or criterion for the creation and issuing of seals and certifications pertaining to GDPR compliance</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ConditionsForSealsAndCertifications">gdprt:ConditionsForSealsAndCertifications</a>
    /// </summary>
    let ConditionsForSealsAndCertifications =
        _prefixId.prefix "ConditionsForSealsAndCertifications"

    /// <summary>
    ///   <para>rdfs:label : Confirming or matching datasets^^xsd:string</para>
    ///   <para>rdfs:comment : This type of processing involves matching data subject's identity or personal data in different datasets.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ConfirmingOrMatchingDatasets">gdprt:ConfirmingOrMatchingDatasets</a>
    /// </summary>
    let ConfirmingOrMatchingDatasets = _prefixId.prefix "ConfirmingOrMatchingDatasets"
    /// <summary>
    ///   <para>rdfs:label : Consent^^xsd:string</para>
    ///   <para>rdfs:comment : Consent in the context of the GDPR refers to the assent or agreement by the data subject in relation to their personal data for the proposed processing activities associated with one or more organisations.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Consent">gdprt:Consent</a>
    /// </summary>
    let Consent = _prefixId.prefix "Consent"
    /// <summary>
    ///   <para>rdfs:label : Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity involving data subject's consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ConsentActivity">gdprt:ConsentActivity</a>
    /// </summary>
    let ConsentActivity = _prefixId.prefix "ConsentActivity"
    /// <summary>
    ///   <para>rdfs:label : Context of data collection^^xsd:string</para>
    ///   <para>rdfs:comment : The purpose of new processing should take the context of how the original data was collected into consideration</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ContextOfDataCollection">gdprt:ContextOfDataCollection</a>
    /// </summary>
    let ContextOfDataCollection = _prefixId.prefix "ContextOfDataCollection"
    /// <summary>
    ///   <para>rdfs:label : Contract with Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : The lawful basis for processing personal data is provided through a contract with the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ContractWithDataSubject">gdprt:ContractWithDataSubject</a>
    /// </summary>
    let ContractWithDataSubject = _prefixId.prefix "ContractWithDataSubject"
    /// <summary>
    ///   <para>rdfs:label : Controller^^xsd:string</para>
    ///   <para>rdfs:comment : The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Controller">gdprt:Controller</a>
    /// </summary>
    let Controller = _prefixId.prefix "Controller"
    /// <summary>
    ///   <para>rdfs:label : Controller Accountability^^xsd:string</para>
    ///   <para>rdfs:comment : These obligations specify the accountability of the Controller.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ControllerAccountability">gdprt:ControllerAccountability</a>
    /// </summary>
    let ControllerAccountability = _prefixId.prefix "ControllerAccountability"
    /// <summary>
    ///   <para>rdfs:label : Controller has taken action^^xsd:string</para>
    ///   <para>rdfs:comment : The data subjects were not notified about the data breach because the controller had already taken action regarding the data breach.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ControllerHasTakenAction">gdprt:ControllerHasTakenAction</a>
    /// </summary>
    let ControllerHasTakenAction = _prefixId.prefix "ControllerHasTakenAction"
    /// <summary>
    ///   <para>rdfs:label : Controller Obligation^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR as being specifically the responsbility of the Controller.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ControllerObligation">gdprt:ControllerObligation</a>
    /// </summary>
    let ControllerObligation = _prefixId.prefix "ControllerObligation"
    /// <summary>
    ///   <para>rdfs:label : Controller Representative^^xsd:string</para>
    ///   <para>rdfs:comment : A natural or legal person established in the Union who, designated by the controllerin writing, represents the controller with regard to their respective obligations under the GDPR.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ControllerRepresentative">gdprt:ControllerRepresentative</a>
    /// </summary>
    let ControllerRepresentative = _prefixId.prefix "ControllerRepresentative"
    /// <summary>
    ///   <para>rdfs:label : Controller Responsibility^^xsd:string</para>
    ///   <para>rdfs:comment : These obligations specify the responsiblity of the Controller</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ControllerResponsibility">gdprt:ControllerResponsibility</a>
    /// </summary>
    let ControllerResponsibility = _prefixId.prefix "ControllerResponsibility"
    /// <summary>
    ///   <para>rdfs:label : Co-operate with DPA^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation specifies the Controller/Processor must co-operate with the Data Protection Authority (DPA).</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CooperateWithDPA">gdprt:CooperateWithDPA</a>
    /// </summary>
    let CooperateWithDPA = _prefixId.prefix "CooperateWithDPA"
    /// <summary>
    ///   <para>rdfs:label : Crime data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data related to criminal convictions and offences.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CriminalData">gdprt:CriminalData</a>
    /// </summary>
    let CriminalData = _prefixId.prefix "CriminalData"
    /// <summary>
    ///   <para>rdfs:label : Cross-border Transfer^^xsd:string</para>
    ///   <para>rdfs:comment : Cross-border data transfer refers to data transfer crossing the boundaries of EU (legislative) region.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#CrossBorderTransfer">gdprt:CrossBorderTransfer</a>
    /// </summary>
    let CrossBorderTransfer = _prefixId.prefix "CrossBorderTransfer"
    /// <summary>
    ///   <para>rdfs:label : DPA^^xsd:string</para>
    ///   <para>rdfs:comment : The Data Protection Authority (DPA) is a public institution responsible for monitoring the application of data protection laws.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DPA">gdprt:DPA</a>
    /// </summary>
    let DPA = _prefixId.prefix "DPA"
    /// <summary>
    ///   <para>rdfs:comment : The Data Protection Officer (DPO) is an individual(s) appointed by the organisation to monitor compliance and assist in complying with the GDPR.</para>
    ///   <para>rdfs:label : DPO^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DPO">gdprt:DPO</a>
    /// </summary>
    let DPO = _prefixId.prefix "DPO"
    /// <summary>
    ///   <para>rdfs:label : DPO Obligation^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified for the Data Protection Office (DPO) within the  GDPR</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DPOObligation">gdprt:DPOObligation</a>
    /// </summary>
    let DPOObligation = _prefixId.prefix "DPOObligation"
    /// <summary>
    ///   <para>rdfs:label : Data^^xsd:string</para>
    ///   <para>rdfs:comment : A generic term to refer to Data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Data">gdprt:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:label : Data Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity involving personal data of data subject(s).^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataActivity">gdprt:DataActivity</a>
    /// </summary>
    let DataActivity = _prefixId.prefix "DataActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Breach^^xsd:string</para>
    ///   <para>rdfs:comment : A data breach is the intentional or unintentional release of secure or private/confidential information to an untrusted environment.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataBreach">gdprt:DataBreach</a>
    /// </summary>
    let DataBreach = _prefixId.prefix "DataBreach"
    /// <summary>
    ///   <para>rdfs:comment : The principle of data minimisation states that personal data must be adequate, relevant and limited to what is necessary in relation to the purposes for which they are processed.</para>
    ///   <para>rdfs:label : Principle of Data Minimisation^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataMinimisation">gdprt:DataMinimisation</a>
    /// </summary>
    let DataMinimisation = _prefixId.prefix "DataMinimisation"

    /// <summary>
    ///   <para>rdfs:label : Data no longer needed for original purpose^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject can exercise the right to restrict processing of their personal data when the personal data is no longer required for the original purpose it was collected under</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataNoLongerNeededForOriginalPurpose">gdprt:DataNoLongerNeededForOriginalPurpose</a>
    /// </summary>
    let DataNoLongerNeededForOriginalPurpose =
        _prefixId.prefix "DataNoLongerNeededForOriginalPurpose"

    /// <summary>
    ///   <para>rdfs:label : Data protection by design and default^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to follow data protection by design and by default.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataProtectionByDesignAndByDefault">gdprt:DataProtectionByDesignAndByDefault</a>
    /// </summary>
    let DataProtectionByDesignAndByDefault =
        _prefixId.prefix "DataProtectionByDesignAndByDefault"

    /// <summary>
    ///   <para>rdfs:label : Data Security^^xsd:string</para>
    ///   <para>rdfs:comment : These are obligations regarding security of data managed by the Controllers.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataSecurity">gdprt:DataSecurity</a>
    /// </summary>
    let DataSecurity = _prefixId.prefix "DataSecurity"
    /// <summary>
    ///   <para>rdfs:label : Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : An individual or entity to whom their personal data relates.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataSubject">gdprt:DataSubject</a>
    /// </summary>
    let DataSubject = _prefixId.prefix "DataSubject"
    /// <summary>
    ///   <para>rdfs:label : Data inferred or derived^^xsd:string</para>
    ///   <para>rdfs:comment : The obligation or activity coult not be completed because the data was inferred or derived, and therefore did not come from the data subject or other sources.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DataWasInferredOrDerived">gdprt:DataWasInferredOrDerived</a>
    /// </summary>
    let DataWasInferredOrDerived = _prefixId.prefix "DataWasInferredOrDerived"
    /// <summary>
    ///   <para>rdfs:label : Demonstrating Consent^^xsd:string</para>
    ///   <para>rdfs:comment : The act of demonstrating consent is an activity whereby previously acquired consent is provided as sufficient justification for processing activities involving data subject's personal information.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DemonstratingConsent">gdprt:DemonstratingConsent</a>
    /// </summary>
    let DemonstratingConsent = _prefixId.prefix "DemonstratingConsent"
    /// <summary>
    ///   <para>rdfs:label : Direct Marketing^^xsd:string</para>
    ///   <para>rdfs:comment : Type of  Marketing that reaches data subjects directly by communications directly addressed to the data subject.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#DirectMarketing">gdprt:DirectMarketing</a>
    /// </summary>
    let DirectMarketing = _prefixId.prefix "DirectMarketing"
    /// <summary>
    ///   <para>rdfs:label : Employment Law^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is provided by Employment Law</para>
    ///   <a href="https://w3id.org/GDPRtEXT#EmploymentLaw">gdprt:EmploymentLaw</a>
    /// </summary>
    let EmploymentLaw = _prefixId.prefix "EmploymentLaw"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : A general term for any institution, company, corporation, partnership, government agency, university, or any other organization including  individuals.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Entity">gdprt:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Erase Data^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that erases data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#EraseData">gdprt:EraseData</a>
    /// </summary>
    let EraseData = _prefixId.prefix "EraseData"
    /// <summary>
    ///   <para>rdfs:label : Erase if conesnt was withdrawn^^xsd:string</para>
    ///   <para>rdfs:comment : The right of erasure applies when the data subject withdraws given consent</para>
    ///   <a href="https://w3id.org/GDPRtEXT#EraseWhenConsentWasWithdrawn">gdprt:EraseWhenConsentWasWithdrawn</a>
    /// </summary>
    let EraseWhenConsentWasWithdrawn = _prefixId.prefix "EraseWhenConsentWasWithdrawn"

    /// <summary>
    ///   <para>rdfs:label : Erase if no longer needed for original purpose^^xsd:string</para>
    ///   <para>rdfs:comment : The right to erasure applies where data is no longer needed for original purposes for which it was collected</para>
    ///   <a href="https://w3id.org/GDPRtEXT#EraseWhenDataIsNoLongerNeededForOriginalPurpose">gdprt:EraseWhenDataIsNoLongerNeededForOriginalPurpose</a>
    /// </summary>
    let EraseWhenDataIsNoLongerNeededForOriginalPurpose =
        _prefixId.prefix "EraseWhenDataIsNoLongerNeededForOriginalPurpose"

    /// <summary>
    ///   <para>rdfs:label : Evaluation of data subjects^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the proposed activity involves the evaluation of the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#EvaluationOfDataSubject">gdprt:EvaluationOfDataSubject</a>
    /// </summary>
    let EvaluationOfDataSubject = _prefixId.prefix "EvaluationOfDataSubject"

    /// <summary>
    ///   <para>rdfs:label : Exceptions on reporting data breach^^xsd:string</para>
    ///   <para>rdfs:comment : Exceptions associated with compliance for reporting data breach to the affected data subjects.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExceptionsOnReportingDataSubjectsOfBreach">gdprt:ExceptionsOnReportingDataSubjectsOfBreach</a>
    /// </summary>
    let ExceptionsOnReportingDataSubjectsOfBreach =
        _prefixId.prefix "ExceptionsOnReportingDataSubjectsOfBreach"

    /// <summary>
    ///   <para>rdfs:label : Exlcusions and Exceptions^^xsd:string</para>
    ///   <para>rdfs:comment : Exclusions and Exemptions provided by the GDPR for not complying with the specified obligations.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExclusionException">gdprt:ExclusionException</a>
    /// </summary>
    let ExclusionException = _prefixId.prefix "ExclusionException"
    /// <summary>
    ///   <para>rdfs:label : Exempted by National Law^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is provided by National Law</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExemptedByNationalLaw">gdprt:ExemptedByNationalLaw</a>
    /// </summary>
    let ExemptedByNationalLaw = _prefixId.prefix "ExemptedByNationalLaw"

    /// <summary>
    ///   <para>rdfs:label : Exempted without identity^^xsd:string</para>
    ///   <para>rdfs:comment : The request or activity could not or was not completed because there was no sufficient proof of the data subject's identity.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExemptedWithoutProofOfDataSubjectIdentity">gdprt:ExemptedWithoutProofOfDataSubjectIdentity</a>
    /// </summary>
    let ExemptedWithoutProofOfDataSubjectIdentity =
        _prefixId.prefix "ExemptedWithoutProofOfDataSubjectIdentity"

    /// <summary>
    ///   <para>rdfs:label : Exercise Rights^^xsd:string</para>
    ///   <para>rdfs:comment : The activity represents exercising of rights provided by GDPR by the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExerciseRights">gdprt:ExerciseRights</a>
    /// </summary>
    let ExerciseRights = _prefixId.prefix "ExerciseRights"
    /// <summary>
    ///   <para>rdfs:label : Existence of safeguards^^xsd:string</para>
    ///   <para>rdfs:comment : The purpose of new processing should take into context the existence of appropriate safeguards</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExistenceOfSafeguards">gdprt:ExistenceOfSafeguards</a>
    /// </summary>
    let ExistenceOfSafeguards = _prefixId.prefix "ExistenceOfSafeguards"
    /// <summary>
    ///   <para>rdfs:label : Explicit Purpose^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation specifies that the collected (or collection) of personal data should be for/with explicit purposes.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ExplicitPurpose">gdprt:ExplicitPurpose</a>
    /// </summary>
    let ExplicitPurpose = _prefixId.prefix "ExplicitPurpose"
    /// <summary>
    ///   <para>rdfs:label : Factors for Impact Assessment^^xsd:string</para>
    ///   <para>rdfs:comment : These are the factors stated by the GDPR for Impact Assessment.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#FactorsForImpactAssessment">gdprt:FactorsForImpactAssessment</a>
    /// </summary>
    let FactorsForImpactAssessment = _prefixId.prefix "FactorsForImpactAssessment"
    /// <summary>
    ///   <para>rdfs:label : Rights protection^^xsd:string</para>
    ///   <para>rdfs:comment : The stated obligation could not be completed as it concerns rights protection.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#FreedomsProtection">gdprt:FreedomsProtection</a>
    /// </summary>
    let FreedomsProtection = _prefixId.prefix "FreedomsProtection"
    /// <summary>
    ///   <para>rdfs:label : Freely given^^xsd:string</para>
    ///   <para>rdfs:comment : GDPR obligation that specifies consent must be freely given by the data subject for it to be valid.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#FreelyGivenConsentObligation">gdprt:FreelyGivenConsentObligation</a>
    /// </summary>
    let FreelyGivenConsentObligation = _prefixId.prefix "FreelyGivenConsentObligation"
    /// <summary>
    ///   <para>rdfs:label : Genetic Data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data relating to the inherited or acquired genetic characteristics of a natural person which result from the analysis of a biological sample from the natural person in question, in particular chromosomal, deoxyribonucleic acid (DNA) or ribonucleic acid (RNA) analysis, or from the analysis of another element enabling equivalent information to be obtained.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#GeneticData">gdprt:GeneticData</a>
    /// </summary>
    let GeneticData = _prefixId.prefix "GeneticData"
    /// <summary>
    ///   <para>rdfs:label : Given Consent^^xsd:string</para>
    ///   <para>rdfs:comment : Given Consent refers specifically to the form of consent given by the data subject in relation to their personal data and the proposed usage by activities.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#GivenConsent">gdprt:GivenConsent</a>
    /// </summary>
    let GivenConsent = _prefixId.prefix "GivenConsent"
    /// <summary>
    ///   <para>rdfs:label : Harm was remote^^xsd:string</para>
    ///   <para>rdfs:comment : The data subjects were not notified about the data breach because the harm was deemed to be remote.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#HarmWasRemote">gdprt:HarmWasRemote</a>
    /// </summary>
    let HarmWasRemote = _prefixId.prefix "HarmWasRemote"
    /// <summary>
    ///   <para>rdfs:label : Health data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data related to the physical or mental health of a natural person, including the provision of health care services, which reveal information about his or her health status.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#HealthData">gdprt:HealthData</a>
    /// </summary>
    let HealthData = _prefixId.prefix "HealthData"

    /// <summary>
    ///   <para>rdfs:label : Historic, Statistical, or Scientific purposes^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis if provided by the GDPR for processing related to historic, statistical, or scientific purposes.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#HistoricStatisticScientificPurposes">gdprt:HistoricStatisticScientificPurposes</a>
    /// </summary>
    let HistoricStatisticScientificPurposes =
        _prefixId.prefix "HistoricStatisticScientificPurposes"

    /// <summary>
    ///   <para>rdfs:label : Identifiable for required processing^^xsd:string</para>
    ///   <para>rdfs:comment : Retention of personal data should be identifiable for the requried processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#IdentifiableForRequiredProcessing">gdprt:IdentifiableForRequiredProcessing</a>
    /// </summary>
    let IdentifiableForRequiredProcessing =
        _prefixId.prefix "IdentifiableForRequiredProcessing"

    /// <summary>
    ///   <para>rdfs:label : Identification of Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : Activity where the data subject is explicitly identified through direct or indirect means.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#IdentificationOfDataSubject">gdprt:IdentificationOfDataSubject</a>
    /// </summary>
    let IdentificationOfDataSubject = _prefixId.prefix "IdentificationOfDataSubject"

    /// <summary>
    ///   <para>rdfs:label : If and where Controller is processing^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about whether and where the controller is processing the data subject's personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#IfAndWhereControllerIsProcessingData">gdprt:IfAndWhereControllerIsProcessingData</a>
    /// </summary>
    let IfAndWhereControllerIsProcessingData =
        _prefixId.prefix "IfAndWhereControllerIsProcessingData"

    /// <summary>
    ///   <para>rdfs:label : Impact Assessment^^xsd:string</para>
    ///   <para>rdfs:comment : The activity wherein the controller carries out an assessment of the impact of the envisaged processing operations on the protection of personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ImpactAssessment">gdprt:ImpactAssessment</a>
    /// </summary>
    let ImpactAssessment = _prefixId.prefix "ImpactAssessment"

    /// <summary>
    ///   <para>rdfs:label : Implement technical measures^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to implement the required technical measures necessary for compliance of the GDPR</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ImplementTechnicalMeasuresForCompliance">gdprt:ImplementTechnicalMeasuresForCompliance</a>
    /// </summary>
    let ImplementTechnicalMeasuresForCompliance =
        _prefixId.prefix "ImplementTechnicalMeasuresForCompliance"

    /// <summary>
    ///   <para>rdfs:label : Impose confidentiality obligations on personnel^^xsd:string</para>
    ///   <para>rdfs:comment : The processor must impose confidentiality agreements on its personnel in relation to handling of personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ImposeConfidentialityObligationOnPersonnel">gdprt:ImposeConfidentialityObligationOnPersonnel</a>
    /// </summary>
    let ImposeConfidentialityObligationOnPersonnel =
        _prefixId.prefix "ImposeConfidentialityObligationOnPersonnel"

    /// <summary>
    ///   <para>rdfs:label : Information about automated processing with significant effects^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about automated processing that has significant effects on the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject">gdprt:InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject</a>
    /// </summary>
    let InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject =
        _prefixId.prefix "InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject"

    /// <summary>
    ///   <para>rdfs:label : Information about categories of recipients^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about the categories of recipients the data is shared with.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutCategoriesOfRecipientsDataSharedWith">gdprt:InfoAboutCategoriesOfRecipientsDataSharedWith</a>
    /// </summary>
    let InfoAboutCategoriesOfRecipientsDataSharedWith =
        _prefixId.prefix "InfoAboutCategoriesOfRecipientsDataSharedWith"

    /// <summary>
    ///   <para>rdfs:label : Information about categories of data being processed^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about categories of data being processed</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutCatgegoriesOfDataBeingProcessed">gdprt:InfoAboutCatgegoriesOfDataBeingProcessed</a>
    /// </summary>
    let InfoAboutCatgegoriesOfDataBeingProcessed =
        _prefixId.prefix "InfoAboutCatgegoriesOfDataBeingProcessed"

    /// <summary>
    ///   <para>rdfs:label : Information about rights^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about the existence of rights provided by the GDPR to the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutExistenceOfRights">gdprt:InfoAboutExistenceOfRights</a>
    /// </summary>
    let InfoAboutExistenceOfRights = _prefixId.prefix "InfoAboutExistenceOfRights"
    /// <summary>
    ///   <para>rdfs:label : Information about processing^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about the processing of personal data of the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutProcessing">gdprt:InfoAboutProcessing</a>
    /// </summary>
    let InfoAboutProcessing = _prefixId.prefix "InfoAboutProcessing"
    /// <summary>
    ///   <para>rdfs:label : Information about data source^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about the source of the personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutSourceOfData">gdprt:InfoAboutSourceOfData</a>
    /// </summary>
    let InfoAboutSourceOfData = _prefixId.prefix "InfoAboutSourceOfData"
    /// <summary>
    ///   <para>rdfs:label : Information about storage period^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data also includes information about the storage period of the data subject's personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InfoAboutStoragePeriod">gdprt:InfoAboutStoragePeriod</a>
    /// </summary>
    let InfoAboutStoragePeriod = _prefixId.prefix "InfoAboutStoragePeriod"

    /// <summary>
    ///   <para>rdfs:label : Inform Controller of conflict with law^^xsd:string</para>
    ///   <para>rdfs:comment : In case of conflict with the controller's intructions and the law, the processor must immediately inform the controller of this conflict</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformControllerOfConflictWithLaw">gdprt:InformControllerOfConflictWithLaw</a>
    /// </summary>
    let InformControllerOfConflictWithLaw =
        _prefixId.prefix "InformControllerOfConflictWithLaw"

    /// <summary>
    ///   <para>rdfs:label : Information about third parties^^xsd:string</para>
    ///   <para>rdfs:comment : The right to basic information also provides data subject's with information about third parties involved in the processing.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformationAboutThirdParties">gdprt:InformationAboutThirdParties</a>
    /// </summary>
    let InformationAboutThirdParties = _prefixId.prefix "InformationAboutThirdParties"
    /// <summary>
    ///   <para>rdfs:label : Concise^^xsd:string</para>
    ///   <para>rdfs:comment : The information provided under the right to transparency should be concise</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformationShouldBeConcise">gdprt:InformationShouldBeConcise</a>
    /// </summary>
    let InformationShouldBeConcise = _prefixId.prefix "InformationShouldBeConcise"

    /// <summary>
    ///   <para>rdfs:label : Easily Accessible^^xsd:string</para>
    ///   <para>rdfs:comment : The information provided under the right to transparency should be easily accessible</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformationShouldBeEasilyAccessible">gdprt:InformationShouldBeEasilyAccessible</a>
    /// </summary>
    let InformationShouldBeEasilyAccessible =
        _prefixId.prefix "InformationShouldBeEasilyAccessible"

    /// <summary>
    ///   <para>rdfs:label : Intelligible^^xsd:string</para>
    ///   <para>rdfs:comment : The information provided under the right to transparency should be intelligible</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformationShouldBeIntelligible">gdprt:InformationShouldBeIntelligible</a>
    /// </summary>
    let InformationShouldBeIntelligible =
        _prefixId.prefix "InformationShouldBeIntelligible"

    /// <summary>
    ///   <para>rdfs:label : Transparent^^xsd:string</para>
    ///   <para>rdfs:comment : The information provided under the right to transparency should be transparent and clear (i.e. not umambigious or vague)</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformationShouldBeTransparent">gdprt:InformationShouldBeTransparent</a>
    /// </summary>
    let InformationShouldBeTransparent =
        _prefixId.prefix "InformationShouldBeTransparent"

    /// <summary>
    ///   <para>rdfs:comment : GDPR obligation that specifies consent must be informed for it be valid.</para>
    ///   <para>rdfs:label : Informed^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#InformedConsentObligation">gdprt:InformedConsentObligation</a>
    /// </summary>
    let InformedConsentObligation = _prefixId.prefix "InformedConsentObligation"
    /// <summary>
    ///   <para>rdfs:comment : The principle of integrity and confidentiality states that personal data must be  processed in a manner that ensures appropriate security of the personal data, including protection against unauthorised or unlawful processing and against accidental loss, destruction or damage, using appropriate technical or organisational measures.</para>
    ///   <para>rdfs:label : Principle of Integrity and Confidentiality^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#IntegrityAndConfidentiality">gdprt:IntegrityAndConfidentiality</a>
    /// </summary>
    let IntegrityAndConfidentiality = _prefixId.prefix "IntegrityAndConfidentiality"
    /// <summary>
    ///   <para>rdfs:label : Is impossible^^xsd:string</para>
    ///   <para>rdfs:comment : The obligation or activity could not be completed as it was deemed to be impossible.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#IsImpossible">gdprt:IsImpossible</a>
    /// </summary>
    let IsImpossible = _prefixId.prefix "IsImpossible"
    /// <summary>
    ///   <para>rdfs:label : Joint Controller^^xsd:string</para>
    ///   <para>rdfs:comment : A joint controller is two or more controllers jointly determine the purposes and means of processing.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#JointController">gdprt:JointController</a>
    /// </summary>
    let JointController = _prefixId.prefix "JointController"
    /// <summary>
    ///   <para>rdfs:label : Kept up to date^^xsd:string</para>
    ///   <para>rdfs:comment : Retained personal data must be kept up-to-date</para>
    ///   <a href="https://w3id.org/GDPRtEXT#KeptUpToDate">gdprt:KeptUpToDate</a>
    /// </summary>
    let KeptUpToDate = _prefixId.prefix "KeptUpToDate"
    /// <summary>
    ///   <para>rdfs:label : Large scale processing^^xsd:string</para>
    ///   <para>rdfs:comment : The processing of personal data at a large scale of quantity or significant proportions.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LargeScaleProcessing">gdprt:LargeScaleProcessing</a>
    /// </summary>
    let LargeScaleProcessing = _prefixId.prefix "LargeScaleProcessing"
    /// <summary>
    ///   <para>rdfs:label : Lawful Basis^^xsd:string</para>
    ///   <para>rdfs:comment : This provides the basis for lawful processing of personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LawfulBasisForProcessing">gdprt:LawfulBasisForProcessing</a>
    /// </summary>
    let LawfulBasisForProcessing = _prefixId.prefix "LawfulBasisForProcessing"

    /// <summary>
    ///   <para>rdfs:label : Principle of Lawfulness, Fairness, and Transparency^^xsd:string</para>
    ///   <para>rdfs:comment : The principle of lawfulness, fairness, and transparency states that personal data must be processed lawfully, fairly and in a transparent manner in relation to the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LawfulnessFairnessAndTransparency">gdprt:LawfulnessFairnessAndTransparency</a>
    /// </summary>
    let LawfulnessFairnessAndTransparency =
        _prefixId.prefix "LawfulnessFairnessAndTransparency"

    /// <summary>
    ///   <para>rdfs:label : Legal Claims^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is provided by legal claims.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LegalClaims">gdprt:LegalClaims</a>
    /// </summary>
    let LegalClaims = _prefixId.prefix "LegalClaims"
    /// <summary>
    ///   <para>rdfs:label : Legal Obligations^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is covered by legal obligation(s).</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LegalObligation">gdprt:LegalObligation</a>
    /// </summary>
    let LegalObligation = _prefixId.prefix "LegalObligation"
    /// <summary>
    ///   <para>rdfs:label : Legitimate Interests^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is provided through the legitimate interests pursued by the Controller or by a third party</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LegitimateInterest">gdprt:LegitimateInterest</a>
    /// </summary>
    let LegitimateInterest = _prefixId.prefix "LegitimateInterest"
    /// <summary>
    ///   <para>rdfs:label : Legitimate purpose^^xsd:string</para>
    ///   <para>rdfs:comment : This specifies that the collection (or collected) personal data should be used/specified to be used for legitimate purposes.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LegitimatePurpose">gdprt:LegitimatePurpose</a>
    /// </summary>
    let LegitimatePurpose = _prefixId.prefix "LegitimatePurpose"
    /// <summary>
    ///   <para>rdfs:label : Liability of Joint-Controllers^^xsd:string</para>
    ///   <para>rdfs:comment : These specify the liability of Joint Controllers, i.e. cases where more than one Controller share the responsiblity.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LiabilityOfJointController">gdprt:LiabilityOfJointController</a>
    /// </summary>
    let LiabilityOfJointController = _prefixId.prefix "LiabilityOfJointController"
    /// <summary>
    ///   <para>rdfs:label : Limited for processing^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data retained should be limited in its use only for the requried processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LimitedForProcessing">gdprt:LimitedForProcessing</a>
    /// </summary>
    let LimitedForProcessing = _prefixId.prefix "LimitedForProcessing"
    /// <summary>
    ///   <para>rdfs:label : Lnk between new and old processing^^xsd:string</para>
    ///   <para>rdfs:comment : Whether there is a link between the new and old purposes of processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#LinkBetweenNewAndOldPurpose">gdprt:LinkBetweenNewAndOldPurpose</a>
    /// </summary>
    let LinkBetweenNewAndOldPurpose = _prefixId.prefix "LinkBetweenNewAndOldPurpose"
    /// <summary>
    ///   <para>rdfs:label : Made Public^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis is provided through the data being publicly made available by the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MadePublicByDataSubject">gdprt:MadePublicByDataSubject</a>
    /// </summary>
    let MadePublicByDataSubject = _prefixId.prefix "MadePublicByDataSubject"
    /// <summary>
    ///   <para>rdfs:label : Maintain Record of Breach^^xsd:string</para>
    ///   <para>rdfs:comment : GDPR mandates the recording of data breaches and its effects.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MaintainRecordOfBreach">gdprt:MaintainRecordOfBreach</a>
    /// </summary>
    let MaintainRecordOfBreach = _prefixId.prefix "MaintainRecordOfBreach"

    /// <summary>
    ///   <para>rdfs:label : Maintain records for processing^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires the Controller/Processor to maintain adequate records about their processing activities.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MaintainRecordsOfProcessingActivities">gdprt:MaintainRecordsOfProcessingActivities</a>
    /// </summary>
    let MaintainRecordsOfProcessingActivities =
        _prefixId.prefix "MaintainRecordsOfProcessingActivities"

    /// <summary>
    ///   <para>rdfs:label : Marketing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or technique of promoting, selling, and distributing a product or service.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Marketing">gdprt:Marketing</a>
    /// </summary>
    let Marketing = _prefixId.prefix "Marketing"
    /// <summary>
    ///   <para>rdfs:label : Maximum validty 3 years^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum validity for all seals and certifications should be 3 years from the date of issue.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MaximumValidity3Years">gdprt:MaximumValidity3Years</a>
    /// </summary>
    let MaximumValidity3Years = _prefixId.prefix "MaximumValidity3Years"
    /// <summary>
    ///   <para>rdfs:label : Medical or Diagnostics^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis for processing is provided by the GDPR for medical or diagnostics purposes pertaining to the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MedicalDiagnosisTreatment">gdprt:MedicalDiagnosisTreatment</a>
    /// </summary>
    let MedicalDiagnosisTreatment = _prefixId.prefix "MedicalDiagnosisTreatment"
    /// <summary>
    ///   <para>rdfs:label : Monitor Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : The activity or process of overseeing an organisation's compliance.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#MonitorCompliance">gdprt:MonitorCompliance</a>
    /// </summary>
    let MonitorCompliance = _prefixId.prefix "MonitorCompliance"
    /// <summary>
    ///   <para>rdfs:label : National Security^^xsd:string</para>
    ///   <para>rdfs:comment : The stated obligation could not be completed as it concerns national security.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NationalSecurity">gdprt:NationalSecurity</a>
    /// </summary>
    let NationalSecurity = _prefixId.prefix "NationalSecurity"
    /// <summary>
    ///   <para>rdfs:label : Nature of data involved^^xsd:string</para>
    ///   <para>rdfs:comment : The nature of the personal data involved, whether it is sensitive or confidential.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NatureOfPersonalData">gdprt:NatureOfPersonalData</a>
    /// </summary>
    let NatureOfPersonalData = _prefixId.prefix "NatureOfPersonalData"

    /// <summary>
    ///   <para>rdfs:label : No charges levied^^xsd:string</para>
    ///   <para>rdfs:comment : The right to access personal data should not incur any undue charge levied on the data subject for exercising their right</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NoChargeLeviedForRightToAccess">gdprt:NoChargeLeviedForRightToAccess</a>
    /// </summary>
    let NoChargeLeviedForRightToAccess =
        _prefixId.prefix "NoChargeLeviedForRightToAccess"

    /// <summary>
    ///   <para>rdfs:label : Not-for-profit organisation^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis is provided by the GDPR for activities of/for not-for-profit organisations</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotForProfitOrg">gdprt:NotForProfitOrg</a>
    /// </summary>
    let NotForProfitOrg = _prefixId.prefix "NotForProfitOrg"

    /// <summary>
    ///   <para>rdfs:label : Not from silence or inactivity^^xsd:string</para>
    ///   <para>rdfs:comment : Consent should not be obtained from silence or inactivity of the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotFromSilenceOrInactivityConsentObligation">gdprt:NotFromSilenceOrInactivityConsentObligation</a>
    /// </summary>
    let NotFromSilenceOrInactivityConsentObligation =
        _prefixId.prefix "NotFromSilenceOrInactivityConsentObligation"

    /// <summary>
    ///   <para>rdfs:label : Not further processed^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation specifies that the collected personal data should not be processed beyond the purpose for which it was originally collected without an updated consent for the proposed purposes.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotFurtherProcessedThanOriginalPurpose">gdprt:NotFurtherProcessedThanOriginalPurpose</a>
    /// </summary>
    let NotFurtherProcessedThanOriginalPurpose =
        _prefixId.prefix "NotFurtherProcessedThanOriginalPurpose"

    /// <summary>
    ///   <para>rdfs:label : Notification requires disproportionate efforts^^xsd:string</para>
    ///   <para>rdfs:comment : The data subjects were not notified about the data breach because it required disproportionate efforts.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotificationRequiresDisproportionateEfforts">gdprt:NotificationRequiresDisproportionateEfforts</a>
    /// </summary>
    let NotificationRequiresDisproportionateEfforts =
        _prefixId.prefix "NotificationRequiresDisproportionateEfforts"

    /// <summary>
    ///   <para>rdfs:label : Notify consequences of breach^^xsd:string</para>
    ///   <para>rdfs:comment : Affected data subject's must be notified about the consequences of the data breach.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutConsequencesOfDataBreach">gdprt:NotifyDataSubjectAboutConsequencesOfDataBreach</a>
    /// </summary>
    let NotifyDataSubjectAboutConsequencesOfDataBreach =
        _prefixId.prefix "NotifyDataSubjectAboutConsequencesOfDataBreach"

    /// <summary>
    ///   <para>rdfs:label : Notify about DPO^^xsd:string</para>
    ///   <para>rdfs:comment : Affected data subjects must be notified with the name and contact of the DPO responsible/handling for the data breach.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutDPOForDataBreach">gdprt:NotifyDataSubjectAboutDPOForDataBreach</a>
    /// </summary>
    let NotifyDataSubjectAboutDPOForDataBreach =
        _prefixId.prefix "NotifyDataSubjectAboutDPOForDataBreach"

    /// <summary>
    ///   <para>rdfs:comment : Affected data subjects must be notified of the data breach and its effects.</para>
    ///   <para>rdfs:label : Notify Data Subject of Breach^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfBreach">gdprt:NotifyDataSubjectOfBreach</a>
    /// </summary>
    let NotifyDataSubjectOfBreach = _prefixId.prefix "NotifyDataSubjectOfBreach"

    /// <summary>
    ///   <para>rdfs:label : Notify measures taken^^xsd:string</para>
    ///   <para>rdfs:comment : Affect data subjets must be notified of the measures taken against the data breach.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfMeasuresTakenForDataBreach">gdprt:NotifyDataSubjectOfMeasuresTakenForDataBreach</a>
    /// </summary>
    let NotifyDataSubjectOfMeasuresTakenForDataBreach =
        _prefixId.prefix "NotifyDataSubjectOfMeasuresTakenForDataBreach"

    /// <summary>
    ///   <para>rdfs:label : Obligation^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR. Following the obligations is necessary for compliance.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Obligation">gdprt:Obligation</a>
    /// </summary>
    let Obligation = _prefixId.prefix "Obligation"

    /// <summary>
    ///   <para>rdfs:label : Obligation for data collection^^xsd:string</para>
    ///   <para>rdfs:comment : Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ObligationForCollectionOfPersonalData">gdprt:ObligationForCollectionOfPersonalData</a>
    /// </summary>
    let ObligationForCollectionOfPersonalData =
        _prefixId.prefix "ObligationForCollectionOfPersonalData"

    /// <summary>
    ///   <para>rdfs:label : Obligation for obtaining consent^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR for obtaining consent</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ObligationForObtainingConsent">gdprt:ObligationForObtainingConsent</a>
    /// </summary>
    let ObligationForObtainingConsent = _prefixId.prefix "ObligationForObtainingConsent"
    /// <summary>
    ///   <para>rdfs:label : Obtaining Consent from Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : The act of getting a data subject's consent.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ObtainingConsent">gdprt:ObtainingConsent</a>
    /// </summary>
    let ObtainingConsent = _prefixId.prefix "ObtainingConsent"

    /// <summary>
    ///   <para>rdfs:label : Only act on Controller instructions^^xsd:string</para>
    ///   <para>rdfs:comment : The processor must only act on the intructions provided and documented by the controller</para>
    ///   <a href="https://w3id.org/GDPRtEXT#OnlyActOnDocumentedInstructionFromController">gdprt:OnlyActOnDocumentedInstructionFromController</a>
    /// </summary>
    let OnlyActOnDocumentedInstructionFromController =
        _prefixId.prefix "OnlyActOnDocumentedInstructionFromController"

    /// <summary>
    ///   <para>rdfs:label : Outside Material Scope^^xsd:string</para>
    ///   <para>rdfs:comment : The activity was deemed to be outside the material scope of the GDPR.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#OutsideMaterialScope">gdprt:OutsideMaterialScope</a>
    /// </summary>
    let OutsideMaterialScope = _prefixId.prefix "OutsideMaterialScope"
    /// <summary>
    ///   <para>rdfs:label : Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data means any information relating to an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PersonalData">gdprt:PersonalData</a>
    /// </summary>
    let PersonalData = _prefixId.prefix "PersonalData"
    /// <summary>
    ///   <para>skos:example : gdpr:article27-2 a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Point ;
    ///     eli:description "The obligation laid down in paragraph 1 of this Article shall not apply to:"^^xsd:string ;
    ///     eli:is_part_of gdpr:GDPR,
    ///         gdpr:article27,
    ///         gdpr:chapterIV,
    ///         gdpr:chapterIV-1 ;
    ///     eli:number "2"^^xsd:string ;
    ///     eli:title_alternative "Article27(2)"^^xsd:string ;
    ///     GDPRtEXT:hasSubPoint gdpr:article27-2-a,
    ///         gdpr:article27-2-b ;
    ///     GDPRtEXT:isPartOfArticle gdpr:article27 ;
    ///     GDPRtEXT:isPartOfChapter gdpr:chapterIV ;
    ///     GDPRtEXT:isPartOfSection gdpr:chapterIV-1 .^^xsd:string</para>
    ///   <para>rdfs:label : Point^^xsd:string</para>
    ///   <para>rdfs:comment : Point in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Point">gdprt:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"

    /// <summary>
    ///   <para>rdfs:label : Consequences for data subjects^^xsd:string</para>
    ///   <para>rdfs:comment : The possible consequences of the change in processing for the data subject</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PossibleConsequenceForDataSubject">gdprt:PossibleConsequenceForDataSubject</a>
    /// </summary>
    let PossibleConsequenceForDataSubject =
        _prefixId.prefix "PossibleConsequenceForDataSubject"

    /// <summary>
    ///   <para>rdfs:label : Principle^^xsd:string</para>
    ///   <para>rdfs:comment : A Principle is a rule or standard defined by the GDPR which is essential to be followed for compliance</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Principle">gdprt:Principle</a>
    /// </summary>
    let Principle = _prefixId.prefix "Principle"
    /// <summary>
    ///   <para>rdfs:label : Privacy by Design^^xsd:string</para>
    ///   <para>rdfs:comment : Privacy by Design is the approach of taking privacy into consideration throughout the whole planning and execution processes.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PrivacyByDesign">gdprt:PrivacyByDesign</a>
    /// </summary>
    let PrivacyByDesign = _prefixId.prefix "PrivacyByDesign"
    /// <summary>
    ///   <para>rdfs:label : Processing^^xsd:string</para>
    ///   <para>rdfs:comment : Processing here refers to an Activity that acts on the Data Subject's personal information.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Processing">gdprt:Processing</a>
    /// </summary>
    let Processing = _prefixId.prefix "Processing"

    /// <summary>
    ///   <para>rdfs:label : Processing affected or vulnerable individuals^^xsd:string</para>
    ///   <para>rdfs:comment : This type of processing involves data subjects that are vulnerable, such as children, or people with disabilities.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessingAffectedVulnerableIndividuals">gdprt:ProcessingAffectedVulnerableIndividuals</a>
    /// </summary>
    let ProcessingAffectedVulnerableIndividuals =
        _prefixId.prefix "ProcessingAffectedVulnerableIndividuals"

    /// <summary>
    ///   <para>rdfs:label : Processing is unlawful^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject can exercise the right to restrict processing of their personal data when the processing is unlawful</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessingIsUnlawful">gdprt:ProcessingIsUnlawful</a>
    /// </summary>
    let ProcessingIsUnlawful = _prefixId.prefix "ProcessingIsUnlawful"
    /// <summary>
    ///   <para>rdfs:label : Processing sensitive data^^xsd:string</para>
    ///   <para>rdfs:comment : This involves processing involving sensitive personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessingSensitiveData">gdprt:ProcessingSensitiveData</a>
    /// </summary>
    let ProcessingSensitiveData = _prefixId.prefix "ProcessingSensitiveData"

    /// <summary>
    ///   <para>rdfs:label : Processing using untested technologies^^xsd:string</para>
    ///   <para>rdfs:comment : This type of processing uses technologies that are new or have not yet been deemed to be fit or stable for usage.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessingUsingUntestedTechnologies">gdprt:ProcessingUsingUntestedTechnologies</a>
    /// </summary>
    let ProcessingUsingUntestedTechnologies =
        _prefixId.prefix "ProcessingUsingUntestedTechnologies"

    /// <summary>
    ///   <para>rdfs:label : Processor^^xsd:string</para>
    ///   <para>rdfs:comment : A natural or legal person, public authority, agency or other body which processes personal data on behalf of the controller.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Processor">gdprt:Processor</a>
    /// </summary>
    let Processor = _prefixId.prefix "Processor"
    /// <summary>
    ///   <para>rdfs:label : Agreement between Processor and Controller^^xsd:string</para>
    ///   <para>rdfs:comment : Signifies the agreement between Controller and Processors for processing of personal data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessorControllerAgreement">gdprt:ProcessorControllerAgreement</a>
    /// </summary>
    let ProcessorControllerAgreement = _prefixId.prefix "ProcessorControllerAgreement"
    /// <summary>
    ///   <para>rdfs:label : Processor Obligations^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR in the context of Processors</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessorObligation">gdprt:ProcessorObligation</a>
    /// </summary>
    let ProcessorObligation = _prefixId.prefix "ProcessorObligation"
    /// <summary>
    ///   <para>rdfs:label : Processor Representative^^xsd:string</para>
    ///   <para>rdfs:comment : A natural or legal person established in the Union who, designated by the processor in writing, represents the processor with regard to their respective obligations under the GDPR.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProcessorRepresentative">gdprt:ProcessorRepresentative</a>
    /// </summary>
    let ProcessorRepresentative = _prefixId.prefix "ProcessorRepresentative"
    /// <summary>
    ///   <para>rdfs:label : Propogate rights to Third Parties^^xsd:string</para>
    ///   <para>rdfs:comment : To propogate a data subject's right once they have been exercised to other third parties that are involved through the data subject's personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PropogateRightsToThirdParties">gdprt:PropogateRightsToThirdParties</a>
    /// </summary>
    let PropogateRightsToThirdParties = _prefixId.prefix "PropogateRightsToThirdParties"

    /// <summary>
    ///   <para>rdfs:label : Protection against accidental loss^^xsd:string</para>
    ///   <para>rdfs:comment : Protection of data subject's personal data  against accidental loss.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProtectionAgainstAccidentalLoss">gdprt:ProtectionAgainstAccidentalLoss</a>
    /// </summary>
    let ProtectionAgainstAccidentalLoss =
        _prefixId.prefix "ProtectionAgainstAccidentalLoss"

    /// <summary>
    ///   <para>rdfs:label : Protection against damage^^xsd:string</para>
    ///   <para>rdfs:comment : Protection of data subject's personal data  against damage to the data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProtectionAgainstDamage">gdprt:ProtectionAgainstDamage</a>
    /// </summary>
    let ProtectionAgainstDamage = _prefixId.prefix "ProtectionAgainstDamage"
    /// <summary>
    ///   <para>rdfs:label : Protection against destruction^^xsd:string</para>
    ///   <para>rdfs:comment : Protection of data subject's personal data  against destruction of data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProtectionAgainstDestruction">gdprt:ProtectionAgainstDestruction</a>
    /// </summary>
    let ProtectionAgainstDestruction = _prefixId.prefix "ProtectionAgainstDestruction"

    /// <summary>
    ///   <para>rdfs:label : Protection against unlawful processing^^xsd:string</para>
    ///   <para>rdfs:comment : Protection of data subject's personal data  against unlawful processing of data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProtectionAgainstUnlawfulProcessing">gdprt:ProtectionAgainstUnlawfulProcessing</a>
    /// </summary>
    let ProtectionAgainstUnlawfulProcessing =
        _prefixId.prefix "ProtectionAgainstUnlawfulProcessing"

    /// <summary>
    ///   <para>rdfs:label : Provide information for compliance^^xsd:string</para>
    ///   <para>rdfs:comment : The processor must provide the controller with the information necessary to demonstrate compliance</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProvideControllerWithInfoForCompliance">gdprt:ProvideControllerWithInfoForCompliance</a>
    /// </summary>
    let ProvideControllerWithInfoForCompliance =
        _prefixId.prefix "ProvideControllerWithInfoForCompliance"

    /// <summary>
    ///   <para>rdfs:label : Provide copy of Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : The right of data portability requries providing a copy of the data subject's personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ProvideCopyOfPersonalData">gdprt:ProvideCopyOfPersonalData</a>
    /// </summary>
    let ProvideCopyOfPersonalData = _prefixId.prefix "ProvideCopyOfPersonalData"
    /// <summary>
    ///   <para>rdfs:comment : Personal data that can no longer be attributed to a specific data subject without the use of additional information.</para>
    ///   <para>rdfs:label : Pseudo-anonymous data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PseudoAnonymousData">gdprt:PseudoAnonymousData</a>
    /// </summary>
    let PseudoAnonymousData = _prefixId.prefix "PseudoAnonymousData"
    /// <summary>
    ///   <para>rdfs:label : Public Interest^^xsd:string</para>
    ///   <para>rdfs:comment : Lawful basis is provided by the GDPR as being in the interest of the public</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PublicInterest">gdprt:PublicInterest</a>
    /// </summary>
    let PublicInterest = _prefixId.prefix "PublicInterest"
    /// <summary>
    ///   <para>rdfs:comment : The principle of purpose limitation states that personal data must be collected for specified, explicit and legitimate purposes and not further processed in a manner that is incompatible with those purposes; further processing for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes shall, in accordance with Article 89(1) of the GDPR, not be considered to be incompatible with the initial purposes.</para>
    ///   <para>rdfs:label : Principle of Purpose Limitation^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PurposeLimitation">gdprt:PurposeLimitation</a>
    /// </summary>
    let PurposeLimitation = _prefixId.prefix "PurposeLimitation"
    /// <summary>
    ///   <para>rdfs:label : Purpose of new processing^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations over determining the new or changed purposes of processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#PurposeOfNewProcessing">gdprt:PurposeOfNewProcessing</a>
    /// </summary>
    let PurposeOfNewProcessing = _prefixId.prefix "PurposeOfNewProcessing"
    /// <summary>
    ///   <para>rdfs:label : Regulation (EC) No 45/2001^^xsd:string</para>
    ///   <para>rdfs:comment : Related to Regulation (EC) No. 45/2001</para>
    ///   <a href="https://w3id.org/GDPRtEXT#R17">gdprt:R17</a>
    /// </summary>
    let R17 = _prefixId.prefix "R17"
    /// <summary>
    ///   <para>rdfs:label : Personal or Household activity^^xsd:string</para>
    ///   <para>rdfs:comment : Exempted as the GDPR does not apply to personal or household activity that does not have a professional or commercial activity associated with it.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#R18">gdprt:R18</a>
    /// </summary>
    let R18 = _prefixId.prefix "R18"
    /// <summary>
    ///   <para>rdfs:label : Covered by Directive (EU) 2016/680^^xsd:string</para>
    ///   <para>rdfs:comment : Exempted as it involves areas covered by Directive (EU) 2016/680</para>
    ///   <a href="https://w3id.org/GDPRtEXT#R19">gdprt:R19</a>
    /// </summary>
    let R19 = _prefixId.prefix "R19"
    /// <summary>
    ///   <para>rdfs:label : Racial origin data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data revealing racial or ethnic origin.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RacialData">gdprt:RacialData</a>
    /// </summary>
    let RacialData = _prefixId.prefix "RacialData"
    /// <summary>
    ///   <para>skos:example : gdpr:recital1 a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Recital ;
    ///     eli:description "The protection of natural persons in relation to the processing of personal data is a fundamental right. Article 8(1) of the Charter of Fundamental Rights of the European Union (the ‘Charter’) and Article 16(1) of the Treaty on the Functioning of the European Union (TFEU) provide that everyone has the right to the protection of personal data concerning him or her."^^xsd:string ;
    ///     eli:is_part_of gdpr:GDPR ;
    ///     eli:number "1"^^xsd:string .^^xsd:string</para>
    ///   <para>rdfs:label : Regulation^^xsd:string</para>
    ///   <para>rdfs:comment : Regulation in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Recital">gdprt:Recital</a>
    /// </summary>
    let Recital = _prefixId.prefix "Recital"

    /// <summary>
    ///   <para>rdfs:label : Categories of data subjects and personal data^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the categories of data subjects and the personal data involved in processing/activities.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordCategoriesOfDataSubjectsAndPersonalData">gdprt:RecordCategoriesOfDataSubjectsAndPersonalData</a>
    /// </summary>
    let RecordCategoriesOfDataSubjectsAndPersonalData =
        _prefixId.prefix "RecordCategoriesOfDataSubjectsAndPersonalData"

    /// <summary>
    ///   <para>rdfs:label : Record categories of recipients^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the categories of recipients the personal data was shared with.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordCategoriesOfRecipientsWhereDataShared">gdprt:RecordCategoriesOfRecipientsWhereDataShared</a>
    /// </summary>
    let RecordCategoriesOfRecipientsWhereDataShared =
        _prefixId.prefix "RecordCategoriesOfRecipientsWhereDataShared"

    /// <summary>
    ///   <para>rdfs:label : Record cross-border transfers^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the cross-border data transfers.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordCrossBorderDataTransfer">gdprt:RecordCrossBorderDataTransfer</a>
    /// </summary>
    let RecordCrossBorderDataTransfer = _prefixId.prefix "RecordCrossBorderDataTransfer"
    /// <summary>
    ///   <para>rdfs:label : Record data retention periods^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the data retention period of personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordDataRetentionPeriod">gdprt:RecordDataRetentionPeriod</a>
    /// </summary>
    let RecordDataRetentionPeriod = _prefixId.prefix "RecordDataRetentionPeriod"
    /// <summary>
    ///   <para>rdfs:label : Record purpose of processing^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the purpose of processing associated with personal data and the given consent.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordPurposeOfProcessing">gdprt:RecordPurposeOfProcessing</a>
    /// </summary>
    let RecordPurposeOfProcessing = _prefixId.prefix "RecordPurposeOfProcessing"
    /// <summary>
    ///   <para>rdfs:label : Record security measures^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation requires Controllers to record the measures taken to ensure adequate safety measures of personal data and the involved activities.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RecordSecurityMeasures">gdprt:RecordSecurityMeasures</a>
    /// </summary>
    let RecordSecurityMeasures = _prefixId.prefix "RecordSecurityMeasures"
    /// <summary>
    ///   <para>rdfs:label : Rectify Data^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that rectifies data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RectifyData">gdprt:RectifyData</a>
    /// </summary>
    let RectifyData = _prefixId.prefix "RectifyData"
    /// <summary>
    ///   <para>rdfs:label : Rectify Inaccuracies^^xsd:string</para>
    ///   <para>rdfs:comment : Any inaccuracies or discrepancies in the retained data must be rectified</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RectifyInaccuracy">gdprt:RectifyInaccuracy</a>
    /// </summary>
    let RectifyInaccuracy = _prefixId.prefix "RectifyInaccuracy"
    /// <summary>
    ///   <para>rdfs:label : Regulatory Authority^^xsd:string</para>
    ///   <para>rdfs:comment : The authority responsible for regulating data protection laws.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RegulatoryAuthority">gdprt:RegulatoryAuthority</a>
    /// </summary>
    let RegulatoryAuthority = _prefixId.prefix "RegulatoryAuthority"
    /// <summary>
    ///   <para>rdfs:label : Relevant for processing^^xsd:string</para>
    ///   <para>rdfs:comment : Any retained personal data must be relevant for subsiquent processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RelevantForProcessing">gdprt:RelevantForProcessing</a>
    /// </summary>
    let RelevantForProcessing = _prefixId.prefix "RelevantForProcessing"
    /// <summary>
    ///   <para>rdfs:label : Report Data Breach^^xsd:string</para>
    ///   <para>rdfs:comment : The act of reporting a data breach to entities mentioned within the GDPR. These are the Data Protection Authority (DPA), and in the case of Processors, the Controller they have an agreement with.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ReportDataBreach">gdprt:ReportDataBreach</a>
    /// </summary>
    let ReportDataBreach = _prefixId.prefix "ReportDataBreach"
    /// <summary>
    ///   <para>rdfs:label : Report data breach to Controller^^xsd:string</para>
    ///   <para>rdfs:comment : The occurence of a data breach must be reported to the Controller.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ReportDataBreachToController">gdprt:ReportDataBreachToController</a>
    /// </summary>
    let ReportDataBreachToController = _prefixId.prefix "ReportDataBreachToController"

    /// <summary>
    ///   <para>rdfs:label : Report breach to DPA within 72 hours^^xsd:string</para>
    ///   <para>rdfs:comment : The occurence of a data breach must be reported to the Data Protection Authority (DPA) within 72 hours</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ReportDataBreachToDPAWithin72Hours">gdprt:ReportDataBreachToDPAWithin72Hours</a>
    /// </summary>
    let ReportDataBreachToDPAWithin72Hours =
        _prefixId.prefix "ReportDataBreachToDPAWithin72Hours"

    /// <summary>
    ///   <para>rdfs:label : Requires disproportionate efforts^^xsd:string</para>
    ///   <para>rdfs:comment : The stated obligation or activity could not be completed as it requires disproportionate efforts to complete.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RequiresDisproportionateEfforts">gdprt:RequiresDisproportionateEfforts</a>
    /// </summary>
    let RequiresDisproportionateEfforts =
        _prefixId.prefix "RequiresDisproportionateEfforts"

    /// <summary>
    ///   <para>rdfs:label : Written consent of Controller^^xsd:string</para>
    ///   <para>rdfs:comment : Appointing a sub-processor requires the written consent of the controller specifying permission or consent</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RequiresWrittenConsentOfControllerToAppointSubProcessor">gdprt:RequiresWrittenConsentOfControllerToAppointSubProcessor</a>
    /// </summary>
    let RequiresWrittenConsentOfControllerToAppointSubProcessor =
        _prefixId.prefix "RequiresWrittenConsentOfControllerToAppointSubProcessor"

    /// <summary>
    ///   <para>rdfs:label : Restrictions on cross-border transfers^^xsd:string</para>
    ///   <para>rdfs:comment : These provide restrictions on cross-border transfers for Processors</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RestrictionsOnCrossBorderTransfers">gdprt:RestrictionsOnCrossBorderTransfers</a>
    /// </summary>
    let RestrictionsOnCrossBorderTransfers =
        _prefixId.prefix "RestrictionsOnCrossBorderTransfers"

    /// <summary>
    ///   <para>rdfs:label : Data Retention^^xsd:string</para>
    ///   <para>rdfs:comment : These are the obligations specified by the GDPR on the retention of personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RetentionOfPersonalData">gdprt:RetentionOfPersonalData</a>
    /// </summary>
    let RetentionOfPersonalData = _prefixId.prefix "RetentionOfPersonalData"

    /// <summary>
    ///   <para>rdfs:label : Return or destroy data^^xsd:string</para>
    ///   <para>rdfs:comment : The processor must return or destroy personal data at the end of term (of its agreement with the controller)</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ReturnOrDestroyPersonalDataAtEndTerm">gdprt:ReturnOrDestroyPersonalDataAtEndTerm</a>
    /// </summary>
    let ReturnOrDestroyPersonalDataAtEndTerm =
        _prefixId.prefix "ReturnOrDestroyPersonalDataAtEndTerm"

    /// <summary>
    ///   <para>rdfs:comment : The data subject has the right to receive the personal data concerning him or her, which he or she has provided to a controller, in a structured, commonly used and machine-readable format and has the right to transmit those data to another controller without hindrance from the controller to which the personal data have been provided.</para>
    ///   <para>rdfs:label : Right of Data Portability^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightOfDataPortability">gdprt:RightOfDataPortability</a>
    /// </summary>
    let RightOfDataPortability = _prefixId.prefix "RightOfDataPortability"
    /// <summary>
    ///   <para>rdfs:comment : The data subject has the right to obtain erasure of their personal data</para>
    ///   <para>rdfs:label : Right of Erasure^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightOfErasure">gdprt:RightOfErasure</a>
    /// </summary>
    let RightOfErasure = _prefixId.prefix "RightOfErasure"
    /// <summary>
    ///   <para>rdfs:label : Right to Access Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject shall have the right to obtain from the controller confirmation as to whether or not personal data concerning him or her are being processed, and, where that is the case, access to the personal data along with additional information about it.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToAccessPersonalData">gdprt:RightToAccessPersonalData</a>
    /// </summary>
    let RightToAccessPersonalData = _prefixId.prefix "RightToAccessPersonalData"

    /// <summary>
    ///   <para>rdfs:label : Right to basic information about processing of personal data^^xsd:string</para>
    ///   <para>rdfs:comment : The right to basic information about processing provides data subjects with information about the processing activities involving their personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToBasicInformationAboutProcessing">gdprt:RightToBasicInformationAboutProcessing</a>
    /// </summary>
    let RightToBasicInformationAboutProcessing =
        _prefixId.prefix "RightToBasicInformationAboutProcessing"

    /// <summary>
    ///   <para>rdfs:label : Right to not be evaluated through automated processing^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject has a right to not be evaluated through automated processing</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToNotBeEvaluatedThroughAutomatedProcessing">gdprt:RightToNotBeEvaluatedThroughAutomatedProcessing</a>
    /// </summary>
    let RightToNotBeEvaluatedThroughAutomatedProcessing =
        _prefixId.prefix "RightToNotBeEvaluatedThroughAutomatedProcessing"

    /// <summary>
    ///   <para>rdfs:label : Right to object direct marketting^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject has a right to object to direct marketting based on their personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToObjectForDirectMarketting">gdprt:RightToObjectForDirectMarketting</a>
    /// </summary>
    let RightToObjectForDirectMarketting =
        _prefixId.prefix "RightToObjectForDirectMarketting"

    /// <summary>
    ///   <para>rdfs:comment : The data subject has the right to object to processing of their personal data</para>
    ///   <para>rdfs:label : Right to object processing^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToObjectToProcessing">gdprt:RightToObjectToProcessing</a>
    /// </summary>
    let RightToObjectToProcessing = _prefixId.prefix "RightToObjectToProcessing"
    /// <summary>
    ///   <para>rdfs:label : Right to rectify^^xsd:string</para>
    ///   <para>rdfs:comment : The data subject has a right to recitify their personal data</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToRectification">gdprt:RightToRectification</a>
    /// </summary>
    let RightToRectification = _prefixId.prefix "RightToRectification"
    /// <summary>
    ///   <para>rdfs:comment : The data subject has the rights to restrict the processing of their personal data</para>
    ///   <para>rdfs:label : Right to restrict processing^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToRestrictProcessing">gdprt:RightToRestrictProcessing</a>
    /// </summary>
    let RightToRestrictProcessing = _prefixId.prefix "RightToRestrictProcessing"
    /// <summary>
    ///   <para>rdfs:comment : The right to transparency requires controllers to provide information about the processing activities as well as personal data and its usage in a transparent manner</para>
    ///   <para>rdfs:label : Right to Transparency^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightToTransparency">gdprt:RightToTransparency</a>
    /// </summary>
    let RightToTransparency = _prefixId.prefix "RightToTransparency"
    /// <summary>
    ///   <para>rdfs:label : Data Subject's Rights^^xsd:string</para>
    ///   <para>rdfs:comment : The GDPR provides several rights to the data subjects which may be exercised at any time by the data subject and which are mandatory for the organisation to provide, comply with, and inform the data subject about.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Rights">gdprt:Rights</a>
    /// </summary>
    let Rights = _prefixId.prefix "Rights"
    /// <summary>
    ///   <para>rdfs:label : Freedoms protection^^xsd:string</para>
    ///   <para>rdfs:comment : The stated obligation could not be completed as it concerns freedoms protection.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#RightsProtection">gdprt:RightsProtection</a>
    /// </summary>
    let RightsProtection = _prefixId.prefix "RightsProtection"
    /// <summary>
    ///   <para>rdfs:label : Seal^^xsd:string</para>
    ///   <para>rdfs:comment : A seal pertaining to GDPR compliance</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Seal">gdprt:Seal</a>
    /// </summary>
    let Seal = _prefixId.prefix "Seal"
    /// <summary>
    ///   <para>rdfs:label : Seals and Certifications^^xsd:string</para>
    ///   <para>rdfs:comment : GDPR provides for the creation and provision of seals and certificates pertaining to compliance or related activities</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SealsAndCertification">gdprt:SealsAndCertification</a>
    /// </summary>
    let SealsAndCertification = _prefixId.prefix "SealsAndCertification"
    /// <summary>
    ///   <para>skos:example : gdpr:chapterIV-5 a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:Section ;
    ///     eli:is_part_of gdpr:GDPR,
    ///         gdpr:chapterIV ;
    ///     eli:number "5"^^xsd:string ;
    ///     eli:title "Codes of conduct and certification"^^xsd:string ;
    ///     eli:title_alternative "Section 5"^^xsd:string ;
    ///     GDPRtEXT:hasArticle gdpr:article40,
    ///         gdpr:article41,
    ///         gdpr:article42,
    ///         gdpr:article43 ;
    ///     GDPRtEXT:isPartOfChapter gdpr:chapterIV .^^xsd:string</para>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <para>rdfs:comment : Section in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#Section">gdprt:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:label : Security of Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : This activity refers to security of data subject's personal data.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SecurityOfPersonalData">gdprt:SecurityOfPersonalData</a>
    /// </summary>
    let SecurityOfPersonalData = _prefixId.prefix "SecurityOfPersonalData"
    /// <summary>
    ///   <para>rdfs:label : Sensitive Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data revealing racial or ethnic origin, political opinions, religious or philosophical beliefs, or trade union membership, and the processing of genetic data, biometric data for the purpose of uniquely identifying a natural person, data concerning health or data concerning a natural person's sex life or sexual orientation.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SensitivePersonalData">gdprt:SensitivePersonalData</a>
    /// </summary>
    let SensitivePersonalData = _prefixId.prefix "SensitivePersonalData"
    /// <summary>
    ///   <para>rdfs:label : Share Personal Data with Third Party^^xsd:string</para>
    ///   <para>rdfs:comment : This activity represents the sharing of data subject's personal data with a third party.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShareDataWithThirdParty">gdprt:ShareDataWithThirdParty</a>
    /// </summary>
    let ShareDataWithThirdParty = _prefixId.prefix "ShareDataWithThirdParty"
    /// <summary>
    ///   <para>rdfs:label : Copy should be in a commonly used format^^xsd:string</para>
    ///   <para>rdfs:comment : The provided copy of personal data should be in a commonly used format</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldBeCommonlyUsedFormat">gdprt:ShouldBeCommonlyUsedFormat</a>
    /// </summary>
    let ShouldBeCommonlyUsedFormat = _prefixId.prefix "ShouldBeCommonlyUsedFormat"
    /// <summary>
    ///   <para>rdfs:label : Demonstrable^^xsd:string</para>
    ///   <para>rdfs:comment : Obtained consent should be in a demonstrable form</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldBeDemonstrable">gdprt:ShouldBeDemonstrable</a>
    /// </summary>
    let ShouldBeDemonstrable = _prefixId.prefix "ShouldBeDemonstrable"

    /// <summary>
    ///   <para>rdfs:label : Distinguishable from other matters^^xsd:string</para>
    ///   <para>rdfs:comment : Obtained consent should be distinguishable from other related matters (in the context of the process)</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldBeDistinguishableFromOtherMatters">gdprt:ShouldBeDistinguishableFromOtherMatters</a>
    /// </summary>
    let ShouldBeDistinguishableFromOtherMatters =
        _prefixId.prefix "ShouldBeDistinguishableFromOtherMatters"

    /// <summary>
    ///   <para>rdfs:label : Copy should be in a machine readable format^^xsd:string</para>
    ///   <para>rdfs:comment : The provided copy of personal data should be machine readable</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldBeMachineReadable">gdprt:ShouldBeMachineReadable</a>
    /// </summary>
    let ShouldBeMachineReadable = _prefixId.prefix "ShouldBeMachineReadable"
    /// <summary>
    ///   <para>rdfs:label : Should be structured^^xsd:string</para>
    ///   <para>rdfs:comment : The provided copy of personal data should be structured</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldBeStructured">gdprt:ShouldBeStructured</a>
    /// </summary>
    let ShouldBeStructured = _prefixId.prefix "ShouldBeStructured"
    /// <summary>
    ///   <para>rdfs:label : Shoud support reuse^^xsd:string</para>
    ///   <para>rdfs:comment : The provided copy of personal data should support reuse</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ShouldSupportReuse">gdprt:ShouldSupportReuse</a>
    /// </summary>
    let ShouldSupportReuse = _prefixId.prefix "ShouldSupportReuse"
    /// <summary>
    ///   <para>rdfs:label : Specific^^xsd:string</para>
    ///   <para>rdfs:comment : GDPR obligation that specifies consent must be specific for it to be valid.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SpecificConsentObligation">gdprt:SpecificConsentObligation</a>
    /// </summary>
    let SpecificConsentObligation = _prefixId.prefix "SpecificConsentObligation"
    /// <summary>
    ///   <para>rdfs:label : Specified purpose^^xsd:string</para>
    ///   <para>rdfs:comment : This obligation states that the collection of personal data should happen only for the specified purposes (for which the data subject has consented).</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SpecifiedPurpose">gdprt:SpecifiedPurpose</a>
    /// </summary>
    let SpecifiedPurpose = _prefixId.prefix "SpecifiedPurpose"
    /// <summary>
    ///   <para>rdfs:label : Principle of Storage Limitation^^xsd:string</para>
    ///   <para>rdfs:comment : The principle of storage limitation states that personal data must be kept in a form which permits identification of data subjects for no longer than is necessary for the purposes for which the personal data are processed; personal data may be stored for longer periods insofar as the personal data will be processed solely for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes in accordance with Article 89(1) of the GDPR subject to implementation of the appropriate technical and organisational measures required by this Regulation in order to safeguard the rights and freedoms of the data subject.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#StorageLimitation">gdprt:StorageLimitation</a>
    /// </summary>
    let StorageLimitation = _prefixId.prefix "StorageLimitation"
    /// <summary>
    ///   <para>rdfs:label : Store Data^^xsd:string</para>
    ///   <para>rdfs:comment : An activity where personal data is being stored^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#StoreData">gdprt:StoreData</a>
    /// </summary>
    let StoreData = _prefixId.prefix "StoreData"
    /// <summary>
    ///   <para>skos:example : gdpr:article12-5-b a eli:LegalResourceSubdivision,
    ///         GDPRtEXT:SubPoint ;
    ///     eli:description "refuse to act on the request."^^xsd:string ;
    ///     eli:is_part_of gdpr:GDPR,
    ///         gdpr:article12,
    ///         gdpr:article12-5,
    ///         gdpr:chapterIII,
    ///         gdpr:chapterIII-1 ;
    ///     eli:number "b"^^xsd:string ;
    ///     eli:title_alternative "Article12(5)(b)"^^xsd:string ;
    ///     GDPRtEXT:isPartOfArticle gdpr:article12 ;
    ///     GDPRtEXT:isPartOfChapter gdpr:chapterIII ;
    ///     GDPRtEXT:isPartOfPoint gdpr:article12-5 ;
    ///     GDPRtEXT:isPartOfSection gdpr:chapterIII-1 .^^xsd:string</para>
    ///   <para>rdfs:label : SubPoint^^xsd:string</para>
    ///   <para>rdfs:comment : SubPoint in GDPR text^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SubPoint">gdprt:SubPoint</a>
    /// </summary>
    let SubPoint = _prefixId.prefix "SubPoint"
    /// <summary>
    ///   <para>rdfs:label : Sub-Processor^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-processor is a processor acting under another processor.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SubProcessor">gdprt:SubProcessor</a>
    /// </summary>
    let SubProcessor = _prefixId.prefix "SubProcessor"

    /// <summary>
    ///   <para>rdfs:label : Follow same terms^^xsd:string</para>
    ///   <para>rdfs:comment : Sub-processors must follow the same rules and obligations (or terms) as the agreement between processor and controller.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SubProcessorMustFollowSameTermsAsProcessorControllerAgreement">gdprt:SubProcessorMustFollowSameTermsAsProcessorControllerAgreement</a>
    /// </summary>
    let SubProcessorMustFollowSameTermsAsProcessorControllerAgreement =
        _prefixId.prefix "SubProcessorMustFollowSameTermsAsProcessorControllerAgreement"

    /// <summary>
    ///   <para>rdfs:label : Systematic Monitoring^^xsd:string</para>
    ///   <para>rdfs:comment : This activity provides a systematic monitoring or overview of processes/activities taking place within the context of the organisation.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#SystematicMonitoring">gdprt:SystematicMonitoring</a>
    /// </summary>
    let SystematicMonitoring = _prefixId.prefix "SystematicMonitoring"
    /// <summary>
    ///   <para>rdfs:label : Unlawful Processing^^xsd:string</para>
    ///   <para>rdfs:comment : Processing of personal data that is termed to be unlawful in the context of the GDPR or other relevant laws and regulations^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#UnlawfulProcessing">gdprt:UnlawfulProcessing</a>
    /// </summary>
    let UnlawfulProcessing = _prefixId.prefix "UnlawfulProcessing"
    /// <summary>
    ///   <para>rdfs:label : Use Data^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that uses personal data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#UseData">gdprt:UseData</a>
    /// </summary>
    let UseData = _prefixId.prefix "UseData"
    /// <summary>
    ///   <para>rdfs:comment : Consent is termed to be valid if it passes all the criteria or obligations laid down by the GDPR.</para>
    ///   <para>rdfs:label : Valid Consent^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#ValidConsent">gdprt:ValidConsent</a>
    /// </summary>
    let ValidConsent = _prefixId.prefix "ValidConsent"
    /// <summary>
    ///   <para>rdfs:label : Vital Interests^^xsd:string</para>
    ///   <para>rdfs:comment : These are obligations pertaining to the vital interests of the data subjects</para>
    ///   <a href="https://w3id.org/GDPRtEXT#VitalInterest">gdprt:VitalInterest</a>
    /// </summary>
    let VitalInterest = _prefixId.prefix "VitalInterest"

    /// <summary>
    ///   <para>rdfs:label : Voluntary &amp; Opt-in^^xsd:string</para>
    ///   <para>rdfs:comment : Consent must be obtained through the data subject's voluntary action and should be opt-in and not opt-out or by default.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#VoluntaryOptInConsentObligation">gdprt:VoluntaryOptInConsentObligation</a>
    /// </summary>
    let VoluntaryOptInConsentObligation =
        _prefixId.prefix "VoluntaryOptInConsentObligation"

    /// <summary>
    ///   <para>rdfs:label : Voluntary accredition^^xsd:string</para>
    ///   <para>rdfs:comment : The seals and certifications should be a voluntary system of accredition</para>
    ///   <a href="https://w3id.org/GDPRtEXT#VoluntarySystemOfAccredition">gdprt:VoluntarySystemOfAccredition</a>
    /// </summary>
    let VoluntarySystemOfAccredition = _prefixId.prefix "VoluntarySystemOfAccredition"
    /// <summary>
    ///   <para>rdfs:label : Withdrawing Given Consent^^xsd:string</para>
    ///   <para>rdfs:comment : This activity represents the data subject withdrawing given consent.</para>
    ///   <a href="https://w3id.org/GDPRtEXT#WithdrawingConsent">gdprt:WithdrawingConsent</a>
    /// </summary>
    let WithdrawingConsent = _prefixId.prefix "WithdrawingConsent"
    /// <summary>
    ///   <para>rdfs:label : has Article^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the Article^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasArticle">gdprt:hasArticle</a>
    /// </summary>
    let hasArticle = _prefixId.prefix "hasArticle"
    /// <summary>
    ///   <para>rdfs:label : has Chapter^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the Chapter^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasChapter">gdprt:hasChapter</a>
    /// </summary>
    let hasChapter = _prefixId.prefix "hasChapter"
    /// <summary>
    ///   <para>rdfs:label : has Citation^^xsd:string</para>
    ///   <para>rdfs:comment : indicates that the legal resource has the referenced citation^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasCitation">gdprt:hasCitation</a>
    /// </summary>
    let hasCitation = _prefixId.prefix "hasCitation"
    /// <summary>
    ///   <para>rdfs:label : has Point^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the Point^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasPoint">gdprt:hasPoint</a>
    /// </summary>
    let hasPoint = _prefixId.prefix "hasPoint"
    /// <summary>
    ///   <para>rdfs:label : has Recital^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the Recital^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasRecital">gdprt:hasRecital</a>
    /// </summary>
    let hasRecital = _prefixId.prefix "hasRecital"
    /// <summary>
    ///   <para>rdfs:label : has Section^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the Section^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasSection">gdprt:hasSection</a>
    /// </summary>
    let hasSection = _prefixId.prefix "hasSection"
    /// <summary>
    ///   <para>rdfs:label : has SubPoint^^xsd:string</para>
    ///   <para>rdfs:comment : indicates the legal resource has the SubPoint^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#hasSubPoint">gdprt:hasSubPoint</a>
    /// </summary>
    let hasSubPoint = _prefixId.prefix "hasSubPoint"
    /// <summary>
    ///   <para>rdfs:label : involves^^xsd:string</para>
    ///   <para>rdfs:comment : It signifies that two concepts are related within the context of the GDPR.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#involves">gdprt:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>rdfs:label : is part of Article^^xsd:string</para>
    ///   <para>rdfs:comment : represents a legal resource subdivision to be part of a article^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#isPartOfArticle">gdprt:isPartOfArticle</a>
    /// </summary>
    let isPartOfArticle = _prefixId.prefix "isPartOfArticle"
    /// <summary>
    ///   <para>rdfs:label : is part of Chapter^^xsd:string</para>
    ///   <para>rdfs:comment : represents a legal resource subdivision to be part of a chapter^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#isPartOfChapter">gdprt:isPartOfChapter</a>
    /// </summary>
    let isPartOfChapter = _prefixId.prefix "isPartOfChapter"
    /// <summary>
    ///   <para>rdfs:label : is part of Point^^xsd:string</para>
    ///   <para>rdfs:comment : represents a legal resource subdivision to be part of a point^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#isPartOfPoint">gdprt:isPartOfPoint</a>
    /// </summary>
    let isPartOfPoint = _prefixId.prefix "isPartOfPoint"
    /// <summary>
    ///   <para>rdfs:label : is part of Section^^xsd:string</para>
    ///   <para>rdfs:comment : represents a legal resource subdivision to be part of a section^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRtEXT#isPartOfSection">gdprt:isPartOfSection</a>
    /// </summary>
    let isPartOfSection = _prefixId.prefix "isPartOfSection"
