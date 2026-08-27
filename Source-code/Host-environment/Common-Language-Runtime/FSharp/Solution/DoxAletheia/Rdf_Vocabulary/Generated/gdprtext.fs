namespace https.w3id.org.GDPRtEXT.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gdprtext =
    let _namespace_iri = Namespace_Iri gdprtext |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Accountability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of accountability states that the controller shall be responsible for, and be able to demonstrate compliance with the processing of personal data as defined by the justifications permissible under the GDPR"</para>
    /// labels<para>"Principle of Accountability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Accountability">https://w3id.org/GDPRtEXT#Accountability</seealso>
    let Accountability = Prefixed_Name(gdprtext, "Accountability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of accuracy states that personal data must be accurate and, where necessary, kept up to date; every reasonable step must be taken to ensure that personal data that are inaccurate, having regard to the purposes for which they are processed, are erased or rectified without delay."</para>
    /// labels<para>"Principle of Accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Accuracy">https://w3id.org/GDPRtEXT#Accuracy</seealso>
    let Accuracy = Prefixed_Name(gdprtext, "Accuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AccuracyIsContested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject can exercise the right to restrict processing of their personal data when the accuracy of personal data is contested"</para>
    /// labels<para>"Accuracy is contested"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AccuracyIsContested">https://w3id.org/GDPRtEXT#AccuracyIsContested</seealso>
    let AccuracyIsContested =
        Prefixed_Name(gdprtext, "AccuracyIsContested") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AccurateCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation specifies that the collection of (or collected) personal data should in an accurate form - i.e. the personal data should be accurate."</para>
    /// labels<para>"Accurate Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AccurateCollection">https://w3id.org/GDPRtEXT#AccurateCollection</seealso>
    let AccurateCollection =
        Prefixed_Name(gdprtext, "AccurateCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Activity signifies some process(es) or step(s) towards specific deed(s), action(s), function(s), or sphere(s) of action."</para>
    /// labels<para>"Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Activity">https://w3id.org/GDPRtEXT#Activity</seealso>
    let Activity = Prefixed_Name(gdprtext, "Activity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AdequateForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Only the personal data adequat for required processing should be maintained"</para>
    /// labels<para>"Adequate for processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AdequateForProcessing">https://w3id.org/GDPRtEXT#AdequateForProcessing</seealso>
    let AdequateForProcessing =
        Prefixed_Name(gdprtext, "AdequateForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AdherenceToSealCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The seal or certification does not reduce or impact the responsiblity of the controller or processor for compliance with the GDPR"</para>
    /// labels<para>"Adherence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AdherenceToSealCertification">https://w3id.org/GDPRtEXT#AdherenceToSealCertification</seealso>
    let AdherenceToSealCertification =
        Prefixed_Name(gdprtext, "AdherenceToSealCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AnonymousData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data is termed to be anonymous if it cannot be connected or associated with individual person or persons that have provided or are associated with it."</para>
    /// labels<para>"Anonymous Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AnonymousData">https://w3id.org/GDPRtEXT#AnonymousData</seealso>
    let AnonymousData = Prefixed_Name(gdprtext, "AnonymousData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AppointingSubProcessors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations for Processors over appointing sub-processors"</para>
    /// labels<para>"Appointing Sub-Processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AppointingSubProcessors">https://w3id.org/GDPRtEXT#AppointingSubProcessors</seealso>
    let AppointingSubProcessors =
        Prefixed_Name(gdprtext, "AppointingSubProcessors") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AppointmentOfProcessors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR for the appointment of Processors by Controllers."</para>
    /// labels<para>"Appointment of Processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AppointmentOfProcessors">https://w3id.org/GDPRtEXT#AppointmentOfProcessors</seealso>
    let AppointmentOfProcessors =
        Prefixed_Name(gdprtext, "AppointmentOfProcessors") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ArchiveData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity where personal data is archived"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Archive Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ArchiveData">https://w3id.org/GDPRtEXT#ArchiveData</seealso>
    let ArchiveData = Prefixed_Name(gdprtext, "ArchiveData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Article in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Article">https://w3id.org/GDPRtEXT#Article</seealso>
    let Article = Prefixed_Name(gdprtext, "Article") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AssistInComplyingWithRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processors must assist Controllers in complying with the various rights provided by the GDPR to data subjects which can be exercised at any time."</para>
    /// labels<para>"Assist in complying with rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AssistInComplyingWithRights">https://w3id.org/GDPRtEXT#AssistInComplyingWithRights</seealso>
    let AssistInComplyingWithRights =
        Prefixed_Name(gdprtext, "AssistInComplyingWithRights") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AutomatedDecisionMakingWithSignificantEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automated decision making with significant effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This type of processing involves automated processing that does decision making having significant effects on the data subject."</para>
    /// labels<para>"Automatic decision making with significant effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AutomatedDecisionMakingWithSignificantEffect">https://w3id.org/GDPRtEXT#AutomatedDecisionMakingWithSignificantEffect</seealso>
    let AutomatedDecisionMakingWithSignificantEffect =
        Prefixed_Name(gdprtext, "AutomatedDecisionMakingWithSignificantEffect") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#AutomatedProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is automated processing of data subject's personal data."</para>
    /// labels<para>"Automated Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#AutomatedProcessing">https://w3id.org/GDPRtEXT#AutomatedProcessing</seealso>
    let AutomatedProcessing =
        Prefixed_Name(gdprtext, "AutomatedProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CanBeWithdrawnEasilyConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation states that the data subject should be able to withdraw the consent as easily as it was to give it."</para>
    /// labels<para>"Can be withdrawn easily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CanBeWithdrawnEasilyConsentObligation">https://w3id.org/GDPRtEXT#CanBeWithdrawnEasilyConsentObligation</seealso>
    let CanBeWithdrawnEasilyConsentObligation =
        Prefixed_Name(gdprtext, "CanBeWithdrawnEasilyConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A certification pertaining to GDPR compliance"</para>
    /// labels<para>"Certification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Certification">https://w3id.org/GDPRtEXT#Certification</seealso>
    let Certification = Prefixed_Name(gdprtext, "Certification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#CertificationBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Certification Body is an entity that can award/issue/renew a certification pertaining to compliance towards the GDPR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certification Body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CertificationBody">https://w3id.org/GDPRtEXT#CertificationBody</seealso>
    let CertificationBody = Prefixed_Name(gdprtext, "CertificationBody") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chapter in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Chapter">https://w3id.org/GDPRtEXT#Chapter</seealso>
    let Chapter = Prefixed_Name(gdprtext, "Chapter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Citation in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Citation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Citation">https://w3id.org/GDPRtEXT#Citation</seealso>
    let Citation = Prefixed_Name(gdprtext, "Citation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ClearExplanationOfProcessingConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Obtaining consent must provide clear explanations of the processing involved over the personal data"</para>
    /// labels<para>"Clear explanation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ClearExplanationOfProcessingConsentObligation">https://w3id.org/GDPRtEXT#ClearExplanationOfProcessingConsentObligation</seealso>
    let ClearExplanationOfProcessingConsentObligation =
        Prefixed_Name(gdprtext, "ClearExplanationOfProcessingConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CodeOfConduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Code of Conduct for the purpose of specifying the application of GDPR which may be monitored, evaluated, or processed by a third party appointed by the organisation."</para>
    /// labels<para>"Code of Conduct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CodeOfConduct">https://w3id.org/GDPRtEXT#CodeOfConduct</seealso>
    let CodeOfConduct = Prefixed_Name(gdprtext, "CodeOfConduct") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CollectionMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies collection mechanism used to collect personal data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection Mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CollectionMechanism">https://w3id.org/GDPRtEXT#CollectionMechanism</seealso>
    let CollectionMechanism =
        Prefixed_Name(gdprtext, "CollectionMechanism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CollectionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction."</para>
    /// labels<para>"Collection of Personal Data"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CollectionOfPersonalData">https://w3id.org/GDPRtEXT#CollectionOfPersonalData</seealso>
    let CollectionOfPersonalData =
        Prefixed_Name(gdprtext, "CollectionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the act of complying with the obligations and actions specified by the GDPR."</para>
    /// labels<para>"Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Compliance">https://w3id.org/GDPRtEXT#Compliance</seealso>
    let Compliance = Prefixed_Name(gdprtext, "Compliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ComplianceWithControllersInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processor has an obligation to comply with the controller's instructions"</para>
    /// labels<para>"Compliance with Controller's instructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ComplianceWithControllersInstructions">https://w3id.org/GDPRtEXT#ComplianceWithControllersInstructions</seealso>
    let ComplianceWithControllersInstructions =
        Prefixed_Name(gdprtext, "ComplianceWithControllersInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ConditionsForSealsAndCertifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR mentions some conditions or criterion for the creation and issuing of seals and certifications pertaining to GDPR compliance"</para>
    /// labels<para>"Awarding Seals and Certifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ConditionsForSealsAndCertifications">https://w3id.org/GDPRtEXT#ConditionsForSealsAndCertifications</seealso>
    let ConditionsForSealsAndCertifications =
        Prefixed_Name(gdprtext, "ConditionsForSealsAndCertifications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ConfirmingOrMatchingDatasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This type of processing involves matching data subject's identity or personal data in different datasets."</para>
    /// labels<para>"Confirming or matching datasets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ConfirmingOrMatchingDatasets">https://w3id.org/GDPRtEXT#ConfirmingOrMatchingDatasets</seealso>
    let ConfirmingOrMatchingDatasets =
        Prefixed_Name(gdprtext, "ConfirmingOrMatchingDatasets") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Consent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consent in the context of the GDPR refers to the assent or agreement by the data subject in relation to their personal data for the proposed processing activities associated with one or more organisations."</para>
    /// labels<para>"Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Consent">https://w3id.org/GDPRtEXT#Consent</seealso>
    let Consent = Prefixed_Name(gdprtext, "Consent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#ConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity involving data subject's consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ConsentActivity">https://w3id.org/GDPRtEXT#ConsentActivity</seealso>
    let ConsentActivity = Prefixed_Name(gdprtext, "ConsentActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ContextOfDataCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The purpose of new processing should take the context of how the original data was collected into consideration"</para>
    /// labels<para>"Context of data collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ContextOfDataCollection">https://w3id.org/GDPRtEXT#ContextOfDataCollection</seealso>
    let ContextOfDataCollection =
        Prefixed_Name(gdprtext, "ContextOfDataCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ContractWithDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The lawful basis for processing personal data is provided through a contract with the data subject."</para>
    /// labels<para>"Contract with Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ContractWithDataSubject">https://w3id.org/GDPRtEXT#ContractWithDataSubject</seealso>
    let ContractWithDataSubject =
        Prefixed_Name(gdprtext, "ContractWithDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The natural or legal person, public authority, agency or other body which, alone or jointly with others, determines the purposes and means of the processing of personal data."</para>
    /// labels<para>"Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Controller">https://w3id.org/GDPRtEXT#Controller</seealso>
    let Controller = Prefixed_Name(gdprtext, "Controller") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ControllerAccountability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These obligations specify the accountability of the Controller."</para>
    /// labels<para>"Controller Accountability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ControllerAccountability">https://w3id.org/GDPRtEXT#ControllerAccountability</seealso>
    let ControllerAccountability =
        Prefixed_Name(gdprtext, "ControllerAccountability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ControllerHasTakenAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subjects were not notified about the data breach because the controller had already taken action regarding the data breach."</para>
    /// labels<para>"Controller has taken action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ControllerHasTakenAction">https://w3id.org/GDPRtEXT#ControllerHasTakenAction</seealso>
    let ControllerHasTakenAction =
        Prefixed_Name(gdprtext, "ControllerHasTakenAction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ControllerObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR as being specifically the responsbility of the Controller."</para>
    /// labels<para>"Controller Obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ControllerObligation">https://w3id.org/GDPRtEXT#ControllerObligation</seealso>
    let ControllerObligation =
        Prefixed_Name(gdprtext, "ControllerObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ControllerRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural or legal person established in the Union who, designated by the controllerin writing, represents the controller with regard to their respective obligations under the GDPR."</para>
    /// labels<para>"Controller Representative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ControllerRepresentative">https://w3id.org/GDPRtEXT#ControllerRepresentative</seealso>
    let ControllerRepresentative =
        Prefixed_Name(gdprtext, "ControllerRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ControllerResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These obligations specify the responsiblity of the Controller"</para>
    /// labels<para>"Controller Responsibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ControllerResponsibility">https://w3id.org/GDPRtEXT#ControllerResponsibility</seealso>
    let ControllerResponsibility =
        Prefixed_Name(gdprtext, "ControllerResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CooperateWithDPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation specifies the Controller/Processor must co-operate with the Data Protection Authority (DPA)."</para>
    /// labels<para>"Co-operate with DPA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CooperateWithDPA">https://w3id.org/GDPRtEXT#CooperateWithDPA</seealso>
    let CooperateWithDPA = Prefixed_Name(gdprtext, "CooperateWithDPA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#CriminalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data related to criminal convictions and offences."</para>
    /// labels<para>"Crime data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CriminalData">https://w3id.org/GDPRtEXT#CriminalData</seealso>
    let CriminalData = Prefixed_Name(gdprtext, "CriminalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#CrossBorderTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cross-border data transfer refers to data transfer crossing the boundaries of EU (legislative) region."</para>
    /// labels<para>"Cross-border Transfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#CrossBorderTransfer">https://w3id.org/GDPRtEXT#CrossBorderTransfer</seealso>
    let CrossBorderTransfer =
        Prefixed_Name(gdprtext, "CrossBorderTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Data Protection Authority (DPA) is a public institution responsible for monitoring the application of data protection laws."</para>
    /// labels<para>"DPA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DPA">https://w3id.org/GDPRtEXT#DPA</seealso>
    let DPA = Prefixed_Name(gdprtext, "DPA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Data Protection Officer (DPO) is an individual(s) appointed by the organisation to monitor compliance and assist in complying with the GDPR."</para>
    /// labels<para>"DPO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DPO">https://w3id.org/GDPRtEXT#DPO</seealso>
    let DPO = Prefixed_Name(gdprtext, "DPO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DPOObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified for the Data Protection Office (DPO) within the  GDPR"</para>
    /// labels<para>"DPO Obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DPOObligation">https://w3id.org/GDPRtEXT#DPOObligation</seealso>
    let DPOObligation = Prefixed_Name(gdprtext, "DPOObligation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic term to refer to Data."</para>
    /// labels<para>"Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Data">https://w3id.org/GDPRtEXT#Data</seealso>
    let Data = Prefixed_Name(gdprtext, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity involving personal data of data subject(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataActivity">https://w3id.org/GDPRtEXT#DataActivity</seealso>
    let DataActivity = Prefixed_Name(gdprtext, "DataActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data breach is the intentional or unintentional release of secure or private/confidential information to an untrusted environment."</para>
    /// labels<para>"Data Breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataBreach">https://w3id.org/GDPRtEXT#DataBreach</seealso>
    let DataBreach = Prefixed_Name(gdprtext, "DataBreach") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataMinimisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of data minimisation states that personal data must be adequate, relevant and limited to what is necessary in relation to the purposes for which they are processed."</para>
    /// labels<para>"Principle of Data Minimisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataMinimisation">https://w3id.org/GDPRtEXT#DataMinimisation</seealso>
    let DataMinimisation = Prefixed_Name(gdprtext, "DataMinimisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataNoLongerNeededForOriginalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject can exercise the right to restrict processing of their personal data when the personal data is no longer required for the original purpose it was collected under"</para>
    /// labels<para>"Data no longer needed for original purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataNoLongerNeededForOriginalPurpose">https://w3id.org/GDPRtEXT#DataNoLongerNeededForOriginalPurpose</seealso>
    let DataNoLongerNeededForOriginalPurpose =
        Prefixed_Name(gdprtext, "DataNoLongerNeededForOriginalPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataProtectionByDesignAndByDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to follow data protection by design and by default."</para>
    /// labels<para>"Data protection by design and default"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataProtectionByDesignAndByDefault">https://w3id.org/GDPRtEXT#DataProtectionByDesignAndByDefault</seealso>
    let DataProtectionByDesignAndByDefault =
        Prefixed_Name(gdprtext, "DataProtectionByDesignAndByDefault") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are obligations regarding security of data managed by the Controllers."</para>
    /// labels<para>"Data Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataSecurity">https://w3id.org/GDPRtEXT#DataSecurity</seealso>
    let DataSecurity = Prefixed_Name(gdprtext, "DataSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual or entity to whom their personal data relates."</para>
    /// labels<para>"Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataSubject">https://w3id.org/GDPRtEXT#DataSubject</seealso>
    let DataSubject = Prefixed_Name(gdprtext, "DataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DataWasInferredOrDerived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The obligation or activity coult not be completed because the data was inferred or derived, and therefore did not come from the data subject or other sources."</para>
    /// labels<para>"Data inferred or derived"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DataWasInferredOrDerived">https://w3id.org/GDPRtEXT#DataWasInferredOrDerived</seealso>
    let DataWasInferredOrDerived =
        Prefixed_Name(gdprtext, "DataWasInferredOrDerived") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DemonstratingConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The act of demonstrating consent is an activity whereby previously acquired consent is provided as sufficient justification for processing activities involving data subject's personal information."</para>
    /// labels<para>"Demonstrating Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DemonstratingConsent">https://w3id.org/GDPRtEXT#DemonstratingConsent</seealso>
    let DemonstratingConsent =
        Prefixed_Name(gdprtext, "DemonstratingConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#DirectMarketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of  Marketing that reaches data subjects directly by communications directly addressed to the data subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Direct Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#DirectMarketing">https://w3id.org/GDPRtEXT#DirectMarketing</seealso>
    let DirectMarketing = Prefixed_Name(gdprtext, "DirectMarketing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#EmploymentLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is provided by Employment Law"</para>
    /// labels<para>"Employment Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#EmploymentLaw">https://w3id.org/GDPRtEXT#EmploymentLaw</seealso>
    let EmploymentLaw = Prefixed_Name(gdprtext, "EmploymentLaw") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A general term for any institution, company, corporation, partnership, government agency, university, or any other organization including  individuals."</para>
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Entity">https://w3id.org/GDPRtEXT#Entity</seealso>
    let Entity = Prefixed_Name(gdprtext, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#EraseData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that erases data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Erase Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#EraseData">https://w3id.org/GDPRtEXT#EraseData</seealso>
    let EraseData = Prefixed_Name(gdprtext, "EraseData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#EraseWhenConsentWasWithdrawn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right of erasure applies when the data subject withdraws given consent"</para>
    /// labels<para>"Erase if conesnt was withdrawn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#EraseWhenConsentWasWithdrawn">https://w3id.org/GDPRtEXT#EraseWhenConsentWasWithdrawn</seealso>
    let EraseWhenConsentWasWithdrawn =
        Prefixed_Name(gdprtext, "EraseWhenConsentWasWithdrawn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#EraseWhenDataIsNoLongerNeededForOriginalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to erasure applies where data is no longer needed for original purposes for which it was collected"</para>
    /// labels<para>"Erase if no longer needed for original purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#EraseWhenDataIsNoLongerNeededForOriginalPurpose">https://w3id.org/GDPRtEXT#EraseWhenDataIsNoLongerNeededForOriginalPurpose</seealso>
    let EraseWhenDataIsNoLongerNeededForOriginalPurpose =
        Prefixed_Name(gdprtext, "EraseWhenDataIsNoLongerNeededForOriginalPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#EvaluationOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Whether the proposed activity involves the evaluation of the data subject."</para>
    /// labels<para>"Evaluation of data subjects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#EvaluationOfDataSubject">https://w3id.org/GDPRtEXT#EvaluationOfDataSubject</seealso>
    let EvaluationOfDataSubject =
        Prefixed_Name(gdprtext, "EvaluationOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExceptionsOnReportingDataSubjectsOfBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exceptions associated with compliance for reporting data breach to the affected data subjects."</para>
    /// labels<para>"Exceptions on reporting data breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExceptionsOnReportingDataSubjectsOfBreach">https://w3id.org/GDPRtEXT#ExceptionsOnReportingDataSubjectsOfBreach</seealso>
    let ExceptionsOnReportingDataSubjectsOfBreach =
        Prefixed_Name(gdprtext, "ExceptionsOnReportingDataSubjectsOfBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExclusionException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exclusions and Exemptions provided by the GDPR for not complying with the specified obligations."</para>
    /// labels<para>"Exlcusions and Exceptions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExclusionException">https://w3id.org/GDPRtEXT#ExclusionException</seealso>
    let ExclusionException =
        Prefixed_Name(gdprtext, "ExclusionException") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExemptedByNationalLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is provided by National Law"</para>
    /// labels<para>"Exempted by National Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExemptedByNationalLaw">https://w3id.org/GDPRtEXT#ExemptedByNationalLaw</seealso>
    let ExemptedByNationalLaw =
        Prefixed_Name(gdprtext, "ExemptedByNationalLaw") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExemptedWithoutProofOfDataSubjectIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The request or activity could not or was not completed because there was no sufficient proof of the data subject's identity."</para>
    /// labels<para>"Exempted without identity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExemptedWithoutProofOfDataSubjectIdentity">https://w3id.org/GDPRtEXT#ExemptedWithoutProofOfDataSubjectIdentity</seealso>
    let ExemptedWithoutProofOfDataSubjectIdentity =
        Prefixed_Name(gdprtext, "ExemptedWithoutProofOfDataSubjectIdentity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExerciseRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity represents exercising of rights provided by GDPR by the data subject."</para>
    /// labels<para>"Exercise Rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExerciseRights">https://w3id.org/GDPRtEXT#ExerciseRights</seealso>
    let ExerciseRights = Prefixed_Name(gdprtext, "ExerciseRights") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExistenceOfSafeguards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The purpose of new processing should take into context the existence of appropriate safeguards"</para>
    /// labels<para>"Existence of safeguards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExistenceOfSafeguards">https://w3id.org/GDPRtEXT#ExistenceOfSafeguards</seealso>
    let ExistenceOfSafeguards =
        Prefixed_Name(gdprtext, "ExistenceOfSafeguards") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ExplicitPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation specifies that the collected (or collection) of personal data should be for/with explicit purposes."</para>
    /// labels<para>"Explicit Purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ExplicitPurpose">https://w3id.org/GDPRtEXT#ExplicitPurpose</seealso>
    let ExplicitPurpose = Prefixed_Name(gdprtext, "ExplicitPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#FactorsForImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the factors stated by the GDPR for Impact Assessment."</para>
    /// labels<para>"Factors for Impact Assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#FactorsForImpactAssessment">https://w3id.org/GDPRtEXT#FactorsForImpactAssessment</seealso>
    let FactorsForImpactAssessment =
        Prefixed_Name(gdprtext, "FactorsForImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#FreedomsProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The stated obligation could not be completed as it concerns rights protection."</para>
    /// labels<para>"Rights protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#FreedomsProtection">https://w3id.org/GDPRtEXT#FreedomsProtection</seealso>
    let FreedomsProtection =
        Prefixed_Name(gdprtext, "FreedomsProtection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#FreelyGivenConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR obligation that specifies consent must be freely given by the data subject for it to be valid."</para>
    /// labels<para>"Freely given"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#FreelyGivenConsentObligation">https://w3id.org/GDPRtEXT#FreelyGivenConsentObligation</seealso>
    let FreelyGivenConsentObligation =
        Prefixed_Name(gdprtext, "FreelyGivenConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#GeneticData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data relating to the inherited or acquired genetic characteristics of a natural person which result from the analysis of a biological sample from the natural person in question, in particular chromosomal, deoxyribonucleic acid (DNA) or ribonucleic acid (RNA) analysis, or from the analysis of another element enabling equivalent information to be obtained."</para>
    /// labels<para>"Genetic Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#GeneticData">https://w3id.org/GDPRtEXT#GeneticData</seealso>
    let GeneticData = Prefixed_Name(gdprtext, "GeneticData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#GivenConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Given Consent refers specifically to the form of consent given by the data subject in relation to their personal data and the proposed usage by activities."</para>
    /// labels<para>"Given Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#GivenConsent">https://w3id.org/GDPRtEXT#GivenConsent</seealso>
    let GivenConsent = Prefixed_Name(gdprtext, "GivenConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#HarmWasRemote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subjects were not notified about the data breach because the harm was deemed to be remote."</para>
    /// labels<para>"Harm was remote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#HarmWasRemote">https://w3id.org/GDPRtEXT#HarmWasRemote</seealso>
    let HarmWasRemote = Prefixed_Name(gdprtext, "HarmWasRemote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#HealthData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data related to the physical or mental health of a natural person, including the provision of health care services, which reveal information about his or her health status."</para>
    /// labels<para>"Health data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#HealthData">https://w3id.org/GDPRtEXT#HealthData</seealso>
    let HealthData = Prefixed_Name(gdprtext, "HealthData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#HistoricStatisticScientificPurposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis if provided by the GDPR for processing related to historic, statistical, or scientific purposes."</para>
    /// labels<para>"Historic, Statistical, or Scientific purposes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#HistoricStatisticScientificPurposes">https://w3id.org/GDPRtEXT#HistoricStatisticScientificPurposes</seealso>
    let HistoricStatisticScientificPurposes =
        Prefixed_Name(gdprtext, "HistoricStatisticScientificPurposes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#IdentifiableForRequiredProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Retention of personal data should be identifiable for the requried processing"</para>
    /// labels<para>"Identifiable for required processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#IdentifiableForRequiredProcessing">https://w3id.org/GDPRtEXT#IdentifiableForRequiredProcessing</seealso>
    let IdentifiableForRequiredProcessing =
        Prefixed_Name(gdprtext, "IdentifiableForRequiredProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#IdentificationOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activity where the data subject is explicitly identified through direct or indirect means."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Identification of Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#IdentificationOfDataSubject">https://w3id.org/GDPRtEXT#IdentificationOfDataSubject</seealso>
    let IdentificationOfDataSubject =
        Prefixed_Name(gdprtext, "IdentificationOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#IfAndWhereControllerIsProcessingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about whether and where the controller is processing the data subject's personal data"</para>
    /// labels<para>"If and where Controller is processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#IfAndWhereControllerIsProcessingData">https://w3id.org/GDPRtEXT#IfAndWhereControllerIsProcessingData</seealso>
    let IfAndWhereControllerIsProcessingData =
        Prefixed_Name(gdprtext, "IfAndWhereControllerIsProcessingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity wherein the controller carries out an assessment of the impact of the envisaged processing operations on the protection of personal data."</para>
    /// labels<para>"Impact Assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ImpactAssessment">https://w3id.org/GDPRtEXT#ImpactAssessment</seealso>
    let ImpactAssessment = Prefixed_Name(gdprtext, "ImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ImplementTechnicalMeasuresForCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to implement the required technical measures necessary for compliance of the GDPR"</para>
    /// labels<para>"Implement technical measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ImplementTechnicalMeasuresForCompliance">https://w3id.org/GDPRtEXT#ImplementTechnicalMeasuresForCompliance</seealso>
    let ImplementTechnicalMeasuresForCompliance =
        Prefixed_Name(gdprtext, "ImplementTechnicalMeasuresForCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ImposeConfidentialityObligationOnPersonnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processor must impose confidentiality agreements on its personnel in relation to handling of personal data"</para>
    /// labels<para>"Impose confidentiality obligations on personnel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ImposeConfidentialityObligationOnPersonnel">https://w3id.org/GDPRtEXT#ImposeConfidentialityObligationOnPersonnel</seealso>
    let ImposeConfidentialityObligationOnPersonnel =
        Prefixed_Name(gdprtext, "ImposeConfidentialityObligationOnPersonnel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about automated processing that has significant effects on the data subject."</para>
    /// labels<para>"Information about automated processing with significant effects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject">https://w3id.org/GDPRtEXT#InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject</seealso>
    let InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject =
        Prefixed_Name(gdprtext, "InfoAboutAutomatedProcessingWithSignificantEffectsOnDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutCategoriesOfRecipientsDataSharedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about the categories of recipients the data is shared with."</para>
    /// labels<para>"Information about categories of recipients"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutCategoriesOfRecipientsDataSharedWith">https://w3id.org/GDPRtEXT#InfoAboutCategoriesOfRecipientsDataSharedWith</seealso>
    let InfoAboutCategoriesOfRecipientsDataSharedWith =
        Prefixed_Name(gdprtext, "InfoAboutCategoriesOfRecipientsDataSharedWith") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutCatgegoriesOfDataBeingProcessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about categories of data being processed"</para>
    /// labels<para>"Information about categories of data being processed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutCatgegoriesOfDataBeingProcessed">https://w3id.org/GDPRtEXT#InfoAboutCatgegoriesOfDataBeingProcessed</seealso>
    let InfoAboutCatgegoriesOfDataBeingProcessed =
        Prefixed_Name(gdprtext, "InfoAboutCatgegoriesOfDataBeingProcessed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutExistenceOfRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about the existence of rights provided by the GDPR to the data subject"</para>
    /// labels<para>"Information about rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutExistenceOfRights">https://w3id.org/GDPRtEXT#InfoAboutExistenceOfRights</seealso>
    let InfoAboutExistenceOfRights =
        Prefixed_Name(gdprtext, "InfoAboutExistenceOfRights") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about the processing of personal data of the data subject"</para>
    /// labels<para>"Information about processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutProcessing">https://w3id.org/GDPRtEXT#InfoAboutProcessing</seealso>
    let InfoAboutProcessing =
        Prefixed_Name(gdprtext, "InfoAboutProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutSourceOfData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about the source of the personal data"</para>
    /// labels<para>"Information about data source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutSourceOfData">https://w3id.org/GDPRtEXT#InfoAboutSourceOfData</seealso>
    let InfoAboutSourceOfData =
        Prefixed_Name(gdprtext, "InfoAboutSourceOfData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InfoAboutStoragePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data also includes information about the storage period of the data subject's personal data"</para>
    /// labels<para>"Information about storage period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InfoAboutStoragePeriod">https://w3id.org/GDPRtEXT#InfoAboutStoragePeriod</seealso>
    let InfoAboutStoragePeriod =
        Prefixed_Name(gdprtext, "InfoAboutStoragePeriod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformControllerOfConflictWithLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In case of conflict with the controller's intructions and the law, the processor must immediately inform the controller of this conflict"</para>
    /// labels<para>"Inform Controller of conflict with law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformControllerOfConflictWithLaw">https://w3id.org/GDPRtEXT#InformControllerOfConflictWithLaw</seealso>
    let InformControllerOfConflictWithLaw =
        Prefixed_Name(gdprtext, "InformControllerOfConflictWithLaw") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformationAboutThirdParties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to basic information also provides data subject's with information about third parties involved in the processing."</para>
    /// labels<para>"Information about third parties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformationAboutThirdParties">https://w3id.org/GDPRtEXT#InformationAboutThirdParties</seealso>
    let InformationAboutThirdParties =
        Prefixed_Name(gdprtext, "InformationAboutThirdParties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformationShouldBeConcise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information provided under the right to transparency should be concise"</para>
    /// labels<para>"Concise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformationShouldBeConcise">https://w3id.org/GDPRtEXT#InformationShouldBeConcise</seealso>
    let InformationShouldBeConcise =
        Prefixed_Name(gdprtext, "InformationShouldBeConcise") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformationShouldBeEasilyAccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information provided under the right to transparency should be easily accessible"</para>
    /// labels<para>"Easily Accessible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformationShouldBeEasilyAccessible">https://w3id.org/GDPRtEXT#InformationShouldBeEasilyAccessible</seealso>
    let InformationShouldBeEasilyAccessible =
        Prefixed_Name(gdprtext, "InformationShouldBeEasilyAccessible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformationShouldBeIntelligible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information provided under the right to transparency should be intelligible"</para>
    /// labels<para>"Intelligible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformationShouldBeIntelligible">https://w3id.org/GDPRtEXT#InformationShouldBeIntelligible</seealso>
    let InformationShouldBeIntelligible =
        Prefixed_Name(gdprtext, "InformationShouldBeIntelligible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformationShouldBeTransparent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information provided under the right to transparency should be transparent and clear (i.e. not umambigious or vague)"</para>
    /// labels<para>"Transparent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformationShouldBeTransparent">https://w3id.org/GDPRtEXT#InformationShouldBeTransparent</seealso>
    let InformationShouldBeTransparent =
        Prefixed_Name(gdprtext, "InformationShouldBeTransparent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#InformedConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR obligation that specifies consent must be informed for it be valid."</para>
    /// labels<para>"Informed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#InformedConsentObligation">https://w3id.org/GDPRtEXT#InformedConsentObligation</seealso>
    let InformedConsentObligation =
        Prefixed_Name(gdprtext, "InformedConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#IntegrityAndConfidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of integrity and confidentiality states that personal data must be  processed in a manner that ensures appropriate security of the personal data, including protection against unauthorised or unlawful processing and against accidental loss, destruction or damage, using appropriate technical or organisational measures."</para>
    /// labels<para>"Principle of Integrity and Confidentiality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#IntegrityAndConfidentiality">https://w3id.org/GDPRtEXT#IntegrityAndConfidentiality</seealso>
    let IntegrityAndConfidentiality =
        Prefixed_Name(gdprtext, "IntegrityAndConfidentiality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#IsImpossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The obligation or activity could not be completed as it was deemed to be impossible."</para>
    /// labels<para>"Is impossible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#IsImpossible">https://w3id.org/GDPRtEXT#IsImpossible</seealso>
    let IsImpossible = Prefixed_Name(gdprtext, "IsImpossible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#JointController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A joint controller is two or more controllers jointly determine the purposes and means of processing."</para>
    /// labels<para>"Joint Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#JointController">https://w3id.org/GDPRtEXT#JointController</seealso>
    let JointController = Prefixed_Name(gdprtext, "JointController") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#KeptUpToDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Retained personal data must be kept up-to-date"</para>
    /// labels<para>"Kept up to date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#KeptUpToDate">https://w3id.org/GDPRtEXT#KeptUpToDate</seealso>
    let KeptUpToDate = Prefixed_Name(gdprtext, "KeptUpToDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LargeScaleProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processing of personal data at a large scale of quantity or significant proportions."</para>
    /// labels<para>"Large scale processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LargeScaleProcessing">https://w3id.org/GDPRtEXT#LargeScaleProcessing</seealso>
    let LargeScaleProcessing =
        Prefixed_Name(gdprtext, "LargeScaleProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LawfulBasisForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This provides the basis for lawful processing of personal data."</para>
    /// labels<para>"Lawful Basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LawfulBasisForProcessing">https://w3id.org/GDPRtEXT#LawfulBasisForProcessing</seealso>
    let LawfulBasisForProcessing =
        Prefixed_Name(gdprtext, "LawfulBasisForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LawfulnessFairnessAndTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of lawfulness, fairness, and transparency states that personal data must be processed lawfully, fairly and in a transparent manner in relation to the data subject."</para>
    /// labels<para>"Principle of Lawfulness, Fairness, and Transparency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LawfulnessFairnessAndTransparency">https://w3id.org/GDPRtEXT#LawfulnessFairnessAndTransparency</seealso>
    let LawfulnessFairnessAndTransparency =
        Prefixed_Name(gdprtext, "LawfulnessFairnessAndTransparency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LegalClaims</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is provided by legal claims."</para>
    /// labels<para>"Legal Claims"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LegalClaims">https://w3id.org/GDPRtEXT#LegalClaims</seealso>
    let LegalClaims = Prefixed_Name(gdprtext, "LegalClaims") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#LegalObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is covered by legal obligation(s)."</para>
    /// labels<para>"Legal Obligations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LegalObligation">https://w3id.org/GDPRtEXT#LegalObligation</seealso>
    let LegalObligation = Prefixed_Name(gdprtext, "LegalObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LegitimateInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is provided through the legitimate interests pursued by the Controller or by a third party"</para>
    /// labels<para>"Legitimate Interests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LegitimateInterest">https://w3id.org/GDPRtEXT#LegitimateInterest</seealso>
    let LegitimateInterest =
        Prefixed_Name(gdprtext, "LegitimateInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LegitimatePurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This specifies that the collection (or collected) personal data should be used/specified to be used for legitimate purposes."</para>
    /// labels<para>"Legitimate purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LegitimatePurpose">https://w3id.org/GDPRtEXT#LegitimatePurpose</seealso>
    let LegitimatePurpose = Prefixed_Name(gdprtext, "LegitimatePurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LiabilityOfJointController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These specify the liability of Joint Controllers, i.e. cases where more than one Controller share the responsiblity."</para>
    /// labels<para>"Liability of Joint-Controllers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LiabilityOfJointController">https://w3id.org/GDPRtEXT#LiabilityOfJointController</seealso>
    let LiabilityOfJointController =
        Prefixed_Name(gdprtext, "LiabilityOfJointController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LimitedForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data retained should be limited in its use only for the requried processing"</para>
    /// labels<para>"Limited for processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LimitedForProcessing">https://w3id.org/GDPRtEXT#LimitedForProcessing</seealso>
    let LimitedForProcessing =
        Prefixed_Name(gdprtext, "LimitedForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#LinkBetweenNewAndOldPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Whether there is a link between the new and old purposes of processing"</para>
    /// labels<para>"Lnk between new and old processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#LinkBetweenNewAndOldPurpose">https://w3id.org/GDPRtEXT#LinkBetweenNewAndOldPurpose</seealso>
    let LinkBetweenNewAndOldPurpose =
        Prefixed_Name(gdprtext, "LinkBetweenNewAndOldPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MadePublicByDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis is provided through the data being publicly made available by the data subject"</para>
    /// labels<para>"Made Public"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MadePublicByDataSubject">https://w3id.org/GDPRtEXT#MadePublicByDataSubject</seealso>
    let MadePublicByDataSubject =
        Prefixed_Name(gdprtext, "MadePublicByDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MaintainRecordOfBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR mandates the recording of data breaches and its effects."</para>
    /// labels<para>"Maintain Record of Breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MaintainRecordOfBreach">https://w3id.org/GDPRtEXT#MaintainRecordOfBreach</seealso>
    let MaintainRecordOfBreach =
        Prefixed_Name(gdprtext, "MaintainRecordOfBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MaintainRecordsOfProcessingActivities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires the Controller/Processor to maintain adequate records about their processing activities."</para>
    /// labels<para>"Maintain records for processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MaintainRecordsOfProcessingActivities">https://w3id.org/GDPRtEXT#MaintainRecordsOfProcessingActivities</seealso>
    let MaintainRecordsOfProcessingActivities =
        Prefixed_Name(gdprtext, "MaintainRecordsOfProcessingActivities") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Marketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or technique of promoting, selling, and distributing a product or service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Marketing">https://w3id.org/GDPRtEXT#Marketing</seealso>
    let Marketing = Prefixed_Name(gdprtext, "Marketing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MaximumValidity3Years</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The maximum validity for all seals and certifications should be 3 years from the date of issue."</para>
    /// labels<para>"Maximum validty 3 years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MaximumValidity3Years">https://w3id.org/GDPRtEXT#MaximumValidity3Years</seealso>
    let MaximumValidity3Years =
        Prefixed_Name(gdprtext, "MaximumValidity3Years") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MedicalDiagnosisTreatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis for processing is provided by the GDPR for medical or diagnostics purposes pertaining to the data subject"</para>
    /// labels<para>"Medical or Diagnostics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MedicalDiagnosisTreatment">https://w3id.org/GDPRtEXT#MedicalDiagnosisTreatment</seealso>
    let MedicalDiagnosisTreatment =
        Prefixed_Name(gdprtext, "MedicalDiagnosisTreatment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#MonitorCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity or process of overseeing an organisation's compliance."</para>
    /// labels<para>"Monitor Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#MonitorCompliance">https://w3id.org/GDPRtEXT#MonitorCompliance</seealso>
    let MonitorCompliance = Prefixed_Name(gdprtext, "MonitorCompliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#NationalSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The stated obligation could not be completed as it concerns national security."</para>
    /// labels<para>"National Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NationalSecurity">https://w3id.org/GDPRtEXT#NationalSecurity</seealso>
    let NationalSecurity = Prefixed_Name(gdprtext, "NationalSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NatureOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The nature of the personal data involved, whether it is sensitive or confidential."</para>
    /// labels<para>"Nature of data involved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NatureOfPersonalData">https://w3id.org/GDPRtEXT#NatureOfPersonalData</seealso>
    let NatureOfPersonalData =
        Prefixed_Name(gdprtext, "NatureOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NoChargeLeviedForRightToAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to access personal data should not incur any undue charge levied on the data subject for exercising their right"</para>
    /// labels<para>"No charges levied"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NoChargeLeviedForRightToAccess">https://w3id.org/GDPRtEXT#NoChargeLeviedForRightToAccess</seealso>
    let NoChargeLeviedForRightToAccess =
        Prefixed_Name(gdprtext, "NoChargeLeviedForRightToAccess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotForProfitOrg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis is provided by the GDPR for activities of/for not-for-profit organisations"</para>
    /// labels<para>"Not-for-profit organisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotForProfitOrg">https://w3id.org/GDPRtEXT#NotForProfitOrg</seealso>
    let NotForProfitOrg = Prefixed_Name(gdprtext, "NotForProfitOrg") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotFromSilenceOrInactivityConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consent should not be obtained from silence or inactivity of the data subject"</para>
    /// labels<para>"Not from silence or inactivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotFromSilenceOrInactivityConsentObligation">https://w3id.org/GDPRtEXT#NotFromSilenceOrInactivityConsentObligation</seealso>
    let NotFromSilenceOrInactivityConsentObligation =
        Prefixed_Name(gdprtext, "NotFromSilenceOrInactivityConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotFurtherProcessedThanOriginalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation specifies that the collected personal data should not be processed beyond the purpose for which it was originally collected without an updated consent for the proposed purposes."</para>
    /// labels<para>"Not further processed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotFurtherProcessedThanOriginalPurpose">https://w3id.org/GDPRtEXT#NotFurtherProcessedThanOriginalPurpose</seealso>
    let NotFurtherProcessedThanOriginalPurpose =
        Prefixed_Name(gdprtext, "NotFurtherProcessedThanOriginalPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotificationRequiresDisproportionateEfforts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subjects were not notified about the data breach because it required disproportionate efforts."</para>
    /// labels<para>"Notification requires disproportionate efforts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotificationRequiresDisproportionateEfforts">https://w3id.org/GDPRtEXT#NotificationRequiresDisproportionateEfforts</seealso>
    let NotificationRequiresDisproportionateEfforts =
        Prefixed_Name(gdprtext, "NotificationRequiresDisproportionateEfforts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotifyDataSubjectAboutConsequencesOfDataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Affected data subject's must be notified about the consequences of the data breach."</para>
    /// labels<para>"Notify consequences of breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutConsequencesOfDataBreach">https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutConsequencesOfDataBreach</seealso>
    let NotifyDataSubjectAboutConsequencesOfDataBreach =
        Prefixed_Name(gdprtext, "NotifyDataSubjectAboutConsequencesOfDataBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotifyDataSubjectAboutDPOForDataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Affected data subjects must be notified with the name and contact of the DPO responsible/handling for the data breach."</para>
    /// labels<para>"Notify about DPO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutDPOForDataBreach">https://w3id.org/GDPRtEXT#NotifyDataSubjectAboutDPOForDataBreach</seealso>
    let NotifyDataSubjectAboutDPOForDataBreach =
        Prefixed_Name(gdprtext, "NotifyDataSubjectAboutDPOForDataBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotifyDataSubjectOfBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Affected data subjects must be notified of the data breach and its effects."</para>
    /// labels<para>"Notify Data Subject of Breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfBreach">https://w3id.org/GDPRtEXT#NotifyDataSubjectOfBreach</seealso>
    let NotifyDataSubjectOfBreach =
        Prefixed_Name(gdprtext, "NotifyDataSubjectOfBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#NotifyDataSubjectOfMeasuresTakenForDataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Affect data subjets must be notified of the measures taken against the data breach."</para>
    /// labels<para>"Notify measures taken"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#NotifyDataSubjectOfMeasuresTakenForDataBreach">https://w3id.org/GDPRtEXT#NotifyDataSubjectOfMeasuresTakenForDataBreach</seealso>
    let NotifyDataSubjectOfMeasuresTakenForDataBreach =
        Prefixed_Name(gdprtext, "NotifyDataSubjectOfMeasuresTakenForDataBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Obligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR. Following the obligations is necessary for compliance."</para>
    /// labels<para>"Obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Obligation">https://w3id.org/GDPRtEXT#Obligation</seealso>
    let Obligation = Prefixed_Name(gdprtext, "Obligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ObligationForCollectionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection of Personal Data is an Activity that deals with acquiring data subject's personal data through some model of interaction."</para>
    /// labels<para>"Obligation for data collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ObligationForCollectionOfPersonalData">https://w3id.org/GDPRtEXT#ObligationForCollectionOfPersonalData</seealso>
    let ObligationForCollectionOfPersonalData =
        Prefixed_Name(gdprtext, "ObligationForCollectionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ObligationForObtainingConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR for obtaining consent"</para>
    /// labels<para>"Obligation for obtaining consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ObligationForObtainingConsent">https://w3id.org/GDPRtEXT#ObligationForObtainingConsent</seealso>
    let ObligationForObtainingConsent =
        Prefixed_Name(gdprtext, "ObligationForObtainingConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ObtainingConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The act of getting a data subject's consent."</para>
    /// labels<para>"Obtaining Consent from Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ObtainingConsent">https://w3id.org/GDPRtEXT#ObtainingConsent</seealso>
    let ObtainingConsent = Prefixed_Name(gdprtext, "ObtainingConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#OnlyActOnDocumentedInstructionFromController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processor must only act on the intructions provided and documented by the controller"</para>
    /// labels<para>"Only act on Controller instructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#OnlyActOnDocumentedInstructionFromController">https://w3id.org/GDPRtEXT#OnlyActOnDocumentedInstructionFromController</seealso>
    let OnlyActOnDocumentedInstructionFromController =
        Prefixed_Name(gdprtext, "OnlyActOnDocumentedInstructionFromController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#OutsideMaterialScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity was deemed to be outside the material scope of the GDPR."</para>
    /// labels<para>"Outside Material Scope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#OutsideMaterialScope">https://w3id.org/GDPRtEXT#OutsideMaterialScope</seealso>
    let OutsideMaterialScope =
        Prefixed_Name(gdprtext, "OutsideMaterialScope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data means any information relating to an identified or identifiable natural person (‘data subject’); an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person."</para>
    /// labels<para>"Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PersonalData">https://w3id.org/GDPRtEXT#PersonalData</seealso>
    let PersonalData = Prefixed_Name(gdprtext, "PersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Point in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Point">https://w3id.org/GDPRtEXT#Point</seealso>
    let Point = Prefixed_Name(gdprtext, "Point") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PossibleConsequenceForDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The possible consequences of the change in processing for the data subject"</para>
    /// labels<para>"Consequences for data subjects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PossibleConsequenceForDataSubject">https://w3id.org/GDPRtEXT#PossibleConsequenceForDataSubject</seealso>
    let PossibleConsequenceForDataSubject =
        Prefixed_Name(gdprtext, "PossibleConsequenceForDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Principle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Principle is a rule or standard defined by the GDPR which is essential to be followed for compliance"</para>
    /// labels<para>"Principle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Principle">https://w3id.org/GDPRtEXT#Principle</seealso>
    let Principle = Prefixed_Name(gdprtext, "Principle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#PrivacyByDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Privacy by Design is the approach of taking privacy into consideration throughout the whole planning and execution processes."</para>
    /// labels<para>"Privacy by Design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PrivacyByDesign">https://w3id.org/GDPRtEXT#PrivacyByDesign</seealso>
    let PrivacyByDesign = Prefixed_Name(gdprtext, "PrivacyByDesign") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processing here refers to an Activity that acts on the Data Subject's personal information."</para>
    /// labels<para>"Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Processing">https://w3id.org/GDPRtEXT#Processing</seealso>
    let Processing = Prefixed_Name(gdprtext, "Processing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessingAffectedVulnerableIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This type of processing involves data subjects that are vulnerable, such as children, or people with disabilities."</para>
    /// labels<para>"Processing affected or vulnerable individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessingAffectedVulnerableIndividuals">https://w3id.org/GDPRtEXT#ProcessingAffectedVulnerableIndividuals</seealso>
    let ProcessingAffectedVulnerableIndividuals =
        Prefixed_Name(gdprtext, "ProcessingAffectedVulnerableIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessingIsUnlawful</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject can exercise the right to restrict processing of their personal data when the processing is unlawful"</para>
    /// labels<para>"Processing is unlawful"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessingIsUnlawful">https://w3id.org/GDPRtEXT#ProcessingIsUnlawful</seealso>
    let ProcessingIsUnlawful =
        Prefixed_Name(gdprtext, "ProcessingIsUnlawful") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessingSensitiveData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This involves processing involving sensitive personal data."</para>
    /// labels<para>"Processing sensitive data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessingSensitiveData">https://w3id.org/GDPRtEXT#ProcessingSensitiveData</seealso>
    let ProcessingSensitiveData =
        Prefixed_Name(gdprtext, "ProcessingSensitiveData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessingUsingUntestedTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This type of processing uses technologies that are new or have not yet been deemed to be fit or stable for usage."</para>
    /// labels<para>"Processing using untested technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessingUsingUntestedTechnologies">https://w3id.org/GDPRtEXT#ProcessingUsingUntestedTechnologies</seealso>
    let ProcessingUsingUntestedTechnologies =
        Prefixed_Name(gdprtext, "ProcessingUsingUntestedTechnologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural or legal person, public authority, agency or other body which processes personal data on behalf of the controller."</para>
    /// labels<para>"Processor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Processor">https://w3id.org/GDPRtEXT#Processor</seealso>
    let Processor = Prefixed_Name(gdprtext, "Processor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessorControllerAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Signifies the agreement between Controller and Processors for processing of personal data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agreement between Processor and Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessorControllerAgreement">https://w3id.org/GDPRtEXT#ProcessorControllerAgreement</seealso>
    let ProcessorControllerAgreement =
        Prefixed_Name(gdprtext, "ProcessorControllerAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessorObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR in the context of Processors"</para>
    /// labels<para>"Processor Obligations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessorObligation">https://w3id.org/GDPRtEXT#ProcessorObligation</seealso>
    let ProcessorObligation =
        Prefixed_Name(gdprtext, "ProcessorObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProcessorRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural or legal person established in the Union who, designated by the processor in writing, represents the processor with regard to their respective obligations under the GDPR."</para>
    /// labels<para>"Processor Representative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProcessorRepresentative">https://w3id.org/GDPRtEXT#ProcessorRepresentative</seealso>
    let ProcessorRepresentative =
        Prefixed_Name(gdprtext, "ProcessorRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PropogateRightsToThirdParties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To propogate a data subject's right once they have been exercised to other third parties that are involved through the data subject's personal data."</para>
    /// labels<para>"Propogate rights to Third Parties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PropogateRightsToThirdParties">https://w3id.org/GDPRtEXT#PropogateRightsToThirdParties</seealso>
    let PropogateRightsToThirdParties =
        Prefixed_Name(gdprtext, "PropogateRightsToThirdParties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProtectionAgainstAccidentalLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protection of data subject's personal data  against accidental loss."</para>
    /// labels<para>"Protection against accidental loss"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProtectionAgainstAccidentalLoss">https://w3id.org/GDPRtEXT#ProtectionAgainstAccidentalLoss</seealso>
    let ProtectionAgainstAccidentalLoss =
        Prefixed_Name(gdprtext, "ProtectionAgainstAccidentalLoss") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProtectionAgainstDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protection of data subject's personal data  against damage to the data."</para>
    /// labels<para>"Protection against damage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProtectionAgainstDamage">https://w3id.org/GDPRtEXT#ProtectionAgainstDamage</seealso>
    let ProtectionAgainstDamage =
        Prefixed_Name(gdprtext, "ProtectionAgainstDamage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProtectionAgainstDestruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protection of data subject's personal data  against destruction of data."</para>
    /// labels<para>"Protection against destruction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProtectionAgainstDestruction">https://w3id.org/GDPRtEXT#ProtectionAgainstDestruction</seealso>
    let ProtectionAgainstDestruction =
        Prefixed_Name(gdprtext, "ProtectionAgainstDestruction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProtectionAgainstUnlawfulProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protection of data subject's personal data  against unlawful processing of data."</para>
    /// labels<para>"Protection against unlawful processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProtectionAgainstUnlawfulProcessing">https://w3id.org/GDPRtEXT#ProtectionAgainstUnlawfulProcessing</seealso>
    let ProtectionAgainstUnlawfulProcessing =
        Prefixed_Name(gdprtext, "ProtectionAgainstUnlawfulProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProvideControllerWithInfoForCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processor must provide the controller with the information necessary to demonstrate compliance"</para>
    /// labels<para>"Provide information for compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProvideControllerWithInfoForCompliance">https://w3id.org/GDPRtEXT#ProvideControllerWithInfoForCompliance</seealso>
    let ProvideControllerWithInfoForCompliance =
        Prefixed_Name(gdprtext, "ProvideControllerWithInfoForCompliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ProvideCopyOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right of data portability requries providing a copy of the data subject's personal data"</para>
    /// labels<para>"Provide copy of Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ProvideCopyOfPersonalData">https://w3id.org/GDPRtEXT#ProvideCopyOfPersonalData</seealso>
    let ProvideCopyOfPersonalData =
        Prefixed_Name(gdprtext, "ProvideCopyOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PseudoAnonymousData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data that can no longer be attributed to a specific data subject without the use of additional information."</para>
    /// labels<para>"Pseudo-anonymous data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PseudoAnonymousData">https://w3id.org/GDPRtEXT#PseudoAnonymousData</seealso>
    let PseudoAnonymousData =
        Prefixed_Name(gdprtext, "PseudoAnonymousData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PublicInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lawful basis is provided by the GDPR as being in the interest of the public"</para>
    /// labels<para>"Public Interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PublicInterest">https://w3id.org/GDPRtEXT#PublicInterest</seealso>
    let PublicInterest = Prefixed_Name(gdprtext, "PublicInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#PurposeLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of purpose limitation states that personal data must be collected for specified, explicit and legitimate purposes and not further processed in a manner that is incompatible with those purposes; further processing for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes shall, in accordance with Article 89(1) of the GDPR, not be considered to be incompatible with the initial purposes."</para>
    /// labels<para>"Principle of Purpose Limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PurposeLimitation">https://w3id.org/GDPRtEXT#PurposeLimitation</seealso>
    let PurposeLimitation = Prefixed_Name(gdprtext, "PurposeLimitation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#PurposeOfNewProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations over determining the new or changed purposes of processing"</para>
    /// labels<para>"Purpose of new processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#PurposeOfNewProcessing">https://w3id.org/GDPRtEXT#PurposeOfNewProcessing</seealso>
    let PurposeOfNewProcessing =
        Prefixed_Name(gdprtext, "PurposeOfNewProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#R17</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Related to Regulation (EC) No. 45/2001"</para>
    /// labels<para>"Regulation (EC) No 45/2001"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#R17">https://w3id.org/GDPRtEXT#R17</seealso>
    let R17 = Prefixed_Name(gdprtext, "R17") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#R18</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exempted as the GDPR does not apply to personal or household activity that does not have a professional or commercial activity associated with it."</para>
    /// labels<para>"Personal or Household activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#R18">https://w3id.org/GDPRtEXT#R18</seealso>
    let R18 = Prefixed_Name(gdprtext, "R18") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#R19</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exempted as it involves areas covered by Directive (EU) 2016/680"</para>
    /// labels<para>"Covered by Directive (EU) 2016/680"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#R19">https://w3id.org/GDPRtEXT#R19</seealso>
    let R19 = Prefixed_Name(gdprtext, "R19") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#RacialData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data revealing racial or ethnic origin."</para>
    /// labels<para>"Racial origin data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RacialData">https://w3id.org/GDPRtEXT#RacialData</seealso>
    let RacialData = Prefixed_Name(gdprtext, "RacialData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Recital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regulation in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Recital">https://w3id.org/GDPRtEXT#Recital</seealso>
    let Recital = Prefixed_Name(gdprtext, "Recital") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordCategoriesOfDataSubjectsAndPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the categories of data subjects and the personal data involved in processing/activities."</para>
    /// labels<para>"Categories of data subjects and personal data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordCategoriesOfDataSubjectsAndPersonalData">https://w3id.org/GDPRtEXT#RecordCategoriesOfDataSubjectsAndPersonalData</seealso>
    let RecordCategoriesOfDataSubjectsAndPersonalData =
        Prefixed_Name(gdprtext, "RecordCategoriesOfDataSubjectsAndPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordCategoriesOfRecipientsWhereDataShared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the categories of recipients the personal data was shared with."</para>
    /// labels<para>"Record categories of recipients"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordCategoriesOfRecipientsWhereDataShared">https://w3id.org/GDPRtEXT#RecordCategoriesOfRecipientsWhereDataShared</seealso>
    let RecordCategoriesOfRecipientsWhereDataShared =
        Prefixed_Name(gdprtext, "RecordCategoriesOfRecipientsWhereDataShared") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordCrossBorderDataTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the cross-border data transfers."</para>
    /// labels<para>"Record cross-border transfers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordCrossBorderDataTransfer">https://w3id.org/GDPRtEXT#RecordCrossBorderDataTransfer</seealso>
    let RecordCrossBorderDataTransfer =
        Prefixed_Name(gdprtext, "RecordCrossBorderDataTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordDataRetentionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the data retention period of personal data."</para>
    /// labels<para>"Record data retention periods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordDataRetentionPeriod">https://w3id.org/GDPRtEXT#RecordDataRetentionPeriod</seealso>
    let RecordDataRetentionPeriod =
        Prefixed_Name(gdprtext, "RecordDataRetentionPeriod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordPurposeOfProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the purpose of processing associated with personal data and the given consent."</para>
    /// labels<para>"Record purpose of processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordPurposeOfProcessing">https://w3id.org/GDPRtEXT#RecordPurposeOfProcessing</seealso>
    let RecordPurposeOfProcessing =
        Prefixed_Name(gdprtext, "RecordPurposeOfProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RecordSecurityMeasures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation requires Controllers to record the measures taken to ensure adequate safety measures of personal data and the involved activities."</para>
    /// labels<para>"Record security measures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RecordSecurityMeasures">https://w3id.org/GDPRtEXT#RecordSecurityMeasures</seealso>
    let RecordSecurityMeasures =
        Prefixed_Name(gdprtext, "RecordSecurityMeasures") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RectifyData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that rectifies data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rectify Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RectifyData">https://w3id.org/GDPRtEXT#RectifyData</seealso>
    let RectifyData = Prefixed_Name(gdprtext, "RectifyData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#RectifyInaccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any inaccuracies or discrepancies in the retained data must be rectified"</para>
    /// labels<para>"Rectify Inaccuracies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RectifyInaccuracy">https://w3id.org/GDPRtEXT#RectifyInaccuracy</seealso>
    let RectifyInaccuracy = Prefixed_Name(gdprtext, "RectifyInaccuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RegulatoryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The authority responsible for regulating data protection laws."</para>
    /// labels<para>"Regulatory Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RegulatoryAuthority">https://w3id.org/GDPRtEXT#RegulatoryAuthority</seealso>
    let RegulatoryAuthority =
        Prefixed_Name(gdprtext, "RegulatoryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RelevantForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any retained personal data must be relevant for subsiquent processing"</para>
    /// labels<para>"Relevant for processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RelevantForProcessing">https://w3id.org/GDPRtEXT#RelevantForProcessing</seealso>
    let RelevantForProcessing =
        Prefixed_Name(gdprtext, "RelevantForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ReportDataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The act of reporting a data breach to entities mentioned within the GDPR. These are the Data Protection Authority (DPA), and in the case of Processors, the Controller they have an agreement with."</para>
    /// labels<para>"Report Data Breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ReportDataBreach">https://w3id.org/GDPRtEXT#ReportDataBreach</seealso>
    let ReportDataBreach = Prefixed_Name(gdprtext, "ReportDataBreach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ReportDataBreachToController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The occurence of a data breach must be reported to the Controller."</para>
    /// labels<para>"Report data breach to Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ReportDataBreachToController">https://w3id.org/GDPRtEXT#ReportDataBreachToController</seealso>
    let ReportDataBreachToController =
        Prefixed_Name(gdprtext, "ReportDataBreachToController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ReportDataBreachToDPAWithin72Hours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The occurence of a data breach must be reported to the Data Protection Authority (DPA) within 72 hours"</para>
    /// labels<para>"Report breach to DPA within 72 hours"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ReportDataBreachToDPAWithin72Hours">https://w3id.org/GDPRtEXT#ReportDataBreachToDPAWithin72Hours</seealso>
    let ReportDataBreachToDPAWithin72Hours =
        Prefixed_Name(gdprtext, "ReportDataBreachToDPAWithin72Hours") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RequiresDisproportionateEfforts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The stated obligation or activity could not be completed as it requires disproportionate efforts to complete."</para>
    /// labels<para>"Requires disproportionate efforts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RequiresDisproportionateEfforts">https://w3id.org/GDPRtEXT#RequiresDisproportionateEfforts</seealso>
    let RequiresDisproportionateEfforts =
        Prefixed_Name(gdprtext, "RequiresDisproportionateEfforts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RequiresWrittenConsentOfControllerToAppointSubProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appointing a sub-processor requires the written consent of the controller specifying permission or consent"</para>
    /// labels<para>"Written consent of Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RequiresWrittenConsentOfControllerToAppointSubProcessor">https://w3id.org/GDPRtEXT#RequiresWrittenConsentOfControllerToAppointSubProcessor</seealso>
    let RequiresWrittenConsentOfControllerToAppointSubProcessor =
        Prefixed_Name(gdprtext, "RequiresWrittenConsentOfControllerToAppointSubProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RestrictionsOnCrossBorderTransfers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These provide restrictions on cross-border transfers for Processors"</para>
    /// labels<para>"Restrictions on cross-border transfers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RestrictionsOnCrossBorderTransfers">https://w3id.org/GDPRtEXT#RestrictionsOnCrossBorderTransfers</seealso>
    let RestrictionsOnCrossBorderTransfers =
        Prefixed_Name(gdprtext, "RestrictionsOnCrossBorderTransfers") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RetentionOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are the obligations specified by the GDPR on the retention of personal data"</para>
    /// labels<para>"Data Retention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RetentionOfPersonalData">https://w3id.org/GDPRtEXT#RetentionOfPersonalData</seealso>
    let RetentionOfPersonalData =
        Prefixed_Name(gdprtext, "RetentionOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ReturnOrDestroyPersonalDataAtEndTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The processor must return or destroy personal data at the end of term (of its agreement with the controller)"</para>
    /// labels<para>"Return or destroy data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ReturnOrDestroyPersonalDataAtEndTerm">https://w3id.org/GDPRtEXT#ReturnOrDestroyPersonalDataAtEndTerm</seealso>
    let ReturnOrDestroyPersonalDataAtEndTerm =
        Prefixed_Name(gdprtext, "ReturnOrDestroyPersonalDataAtEndTerm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightOfDataPortability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has the right to receive the personal data concerning him or her, which he or she has provided to a controller, in a structured, commonly used and machine-readable format and has the right to transmit those data to another controller without hindrance from the controller to which the personal data have been provided."</para>
    /// labels<para>"Right of Data Portability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightOfDataPortability">https://w3id.org/GDPRtEXT#RightOfDataPortability</seealso>
    let RightOfDataPortability =
        Prefixed_Name(gdprtext, "RightOfDataPortability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightOfErasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has the right to obtain erasure of their personal data"</para>
    /// labels<para>"Right of Erasure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightOfErasure">https://w3id.org/GDPRtEXT#RightOfErasure</seealso>
    let RightOfErasure = Prefixed_Name(gdprtext, "RightOfErasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToAccessPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject shall have the right to obtain from the controller confirmation as to whether or not personal data concerning him or her are being processed, and, where that is the case, access to the personal data along with additional information about it."</para>
    /// labels<para>"Right to Access Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToAccessPersonalData">https://w3id.org/GDPRtEXT#RightToAccessPersonalData</seealso>
    let RightToAccessPersonalData =
        Prefixed_Name(gdprtext, "RightToAccessPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToBasicInformationAboutProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to basic information about processing provides data subjects with information about the processing activities involving their personal data"</para>
    /// labels<para>"Right to basic information about processing of personal data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToBasicInformationAboutProcessing">https://w3id.org/GDPRtEXT#RightToBasicInformationAboutProcessing</seealso>
    let RightToBasicInformationAboutProcessing =
        Prefixed_Name(gdprtext, "RightToBasicInformationAboutProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToNotBeEvaluatedThroughAutomatedProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has a right to not be evaluated through automated processing"</para>
    /// labels<para>"Right to not be evaluated through automated processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToNotBeEvaluatedThroughAutomatedProcessing">https://w3id.org/GDPRtEXT#RightToNotBeEvaluatedThroughAutomatedProcessing</seealso>
    let RightToNotBeEvaluatedThroughAutomatedProcessing =
        Prefixed_Name(gdprtext, "RightToNotBeEvaluatedThroughAutomatedProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToObjectForDirectMarketting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has a right to object to direct marketting based on their personal data"</para>
    /// labels<para>"Right to object direct marketting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToObjectForDirectMarketting">https://w3id.org/GDPRtEXT#RightToObjectForDirectMarketting</seealso>
    let RightToObjectForDirectMarketting =
        Prefixed_Name(gdprtext, "RightToObjectForDirectMarketting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToObjectToProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has the right to object to processing of their personal data"</para>
    /// labels<para>"Right to object processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToObjectToProcessing">https://w3id.org/GDPRtEXT#RightToObjectToProcessing</seealso>
    let RightToObjectToProcessing =
        Prefixed_Name(gdprtext, "RightToObjectToProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToRectification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has a right to recitify their personal data"</para>
    /// labels<para>"Right to rectify"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToRectification">https://w3id.org/GDPRtEXT#RightToRectification</seealso>
    let RightToRectification =
        Prefixed_Name(gdprtext, "RightToRectification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToRestrictProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The data subject has the rights to restrict the processing of their personal data"</para>
    /// labels<para>"Right to restrict processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToRestrictProcessing">https://w3id.org/GDPRtEXT#RightToRestrictProcessing</seealso>
    let RightToRestrictProcessing =
        Prefixed_Name(gdprtext, "RightToRestrictProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightToTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The right to transparency requires controllers to provide information about the processing activities as well as personal data and its usage in a transparent manner"</para>
    /// labels<para>"Right to Transparency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightToTransparency">https://w3id.org/GDPRtEXT#RightToTransparency</seealso>
    let RightToTransparency =
        Prefixed_Name(gdprtext, "RightToTransparency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The GDPR provides several rights to the data subjects which may be exercised at any time by the data subject and which are mandatory for the organisation to provide, comply with, and inform the data subject about."</para>
    /// labels<para>"Data Subject's Rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Rights">https://w3id.org/GDPRtEXT#Rights</seealso>
    let Rights = Prefixed_Name(gdprtext, "Rights") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#RightsProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The stated obligation could not be completed as it concerns freedoms protection."</para>
    /// labels<para>"Freedoms protection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#RightsProtection">https://w3id.org/GDPRtEXT#RightsProtection</seealso>
    let RightsProtection = Prefixed_Name(gdprtext, "RightsProtection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#Seal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A seal pertaining to GDPR compliance"</para>
    /// labels<para>"Seal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Seal">https://w3id.org/GDPRtEXT#Seal</seealso>
    let Seal = Prefixed_Name(gdprtext, "Seal") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SealsAndCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR provides for the creation and provision of seals and certificates pertaining to compliance or related activities"</para>
    /// labels<para>"Seals and Certifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SealsAndCertification">https://w3id.org/GDPRtEXT#SealsAndCertification</seealso>
    let SealsAndCertification =
        Prefixed_Name(gdprtext, "SealsAndCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Section in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#Section">https://w3id.org/GDPRtEXT#Section</seealso>
    let Section = Prefixed_Name(gdprtext, "Section") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SecurityOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This activity refers to security of data subject's personal data."</para>
    /// labels<para>"Security of Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SecurityOfPersonalData">https://w3id.org/GDPRtEXT#SecurityOfPersonalData</seealso>
    let SecurityOfPersonalData =
        Prefixed_Name(gdprtext, "SecurityOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SensitivePersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data revealing racial or ethnic origin, political opinions, religious or philosophical beliefs, or trade union membership, and the processing of genetic data, biometric data for the purpose of uniquely identifying a natural person, data concerning health or data concerning a natural person's sex life or sexual orientation."</para>
    /// labels<para>"Sensitive Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SensitivePersonalData">https://w3id.org/GDPRtEXT#SensitivePersonalData</seealso>
    let SensitivePersonalData =
        Prefixed_Name(gdprtext, "SensitivePersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShareDataWithThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This activity represents the sharing of data subject's personal data with a third party."</para>
    /// labels<para>"Share Personal Data with Third Party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShareDataWithThirdParty">https://w3id.org/GDPRtEXT#ShareDataWithThirdParty</seealso>
    let ShareDataWithThirdParty =
        Prefixed_Name(gdprtext, "ShareDataWithThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldBeCommonlyUsedFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The provided copy of personal data should be in a commonly used format"</para>
    /// labels<para>"Copy should be in a commonly used format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldBeCommonlyUsedFormat">https://w3id.org/GDPRtEXT#ShouldBeCommonlyUsedFormat</seealso>
    let ShouldBeCommonlyUsedFormat =
        Prefixed_Name(gdprtext, "ShouldBeCommonlyUsedFormat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldBeDemonstrable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Obtained consent should be in a demonstrable form"</para>
    /// labels<para>"Demonstrable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldBeDemonstrable">https://w3id.org/GDPRtEXT#ShouldBeDemonstrable</seealso>
    let ShouldBeDemonstrable =
        Prefixed_Name(gdprtext, "ShouldBeDemonstrable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldBeDistinguishableFromOtherMatters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Obtained consent should be distinguishable from other related matters (in the context of the process)"</para>
    /// labels<para>"Distinguishable from other matters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldBeDistinguishableFromOtherMatters">https://w3id.org/GDPRtEXT#ShouldBeDistinguishableFromOtherMatters</seealso>
    let ShouldBeDistinguishableFromOtherMatters =
        Prefixed_Name(gdprtext, "ShouldBeDistinguishableFromOtherMatters") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldBeMachineReadable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The provided copy of personal data should be machine readable"</para>
    /// labels<para>"Copy should be in a machine readable format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldBeMachineReadable">https://w3id.org/GDPRtEXT#ShouldBeMachineReadable</seealso>
    let ShouldBeMachineReadable =
        Prefixed_Name(gdprtext, "ShouldBeMachineReadable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldBeStructured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The provided copy of personal data should be structured"</para>
    /// labels<para>"Should be structured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldBeStructured">https://w3id.org/GDPRtEXT#ShouldBeStructured</seealso>
    let ShouldBeStructured =
        Prefixed_Name(gdprtext, "ShouldBeStructured") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#ShouldSupportReuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The provided copy of personal data should support reuse"</para>
    /// labels<para>"Shoud support reuse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ShouldSupportReuse">https://w3id.org/GDPRtEXT#ShouldSupportReuse</seealso>
    let ShouldSupportReuse =
        Prefixed_Name(gdprtext, "ShouldSupportReuse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SpecificConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GDPR obligation that specifies consent must be specific for it to be valid."</para>
    /// labels<para>"Specific"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SpecificConsentObligation">https://w3id.org/GDPRtEXT#SpecificConsentObligation</seealso>
    let SpecificConsentObligation =
        Prefixed_Name(gdprtext, "SpecificConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SpecifiedPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This obligation states that the collection of personal data should happen only for the specified purposes (for which the data subject has consented)."</para>
    /// labels<para>"Specified purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SpecifiedPurpose">https://w3id.org/GDPRtEXT#SpecifiedPurpose</seealso>
    let SpecifiedPurpose = Prefixed_Name(gdprtext, "SpecifiedPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#StorageLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The principle of storage limitation states that personal data must be kept in a form which permits identification of data subjects for no longer than is necessary for the purposes for which the personal data are processed; personal data may be stored for longer periods insofar as the personal data will be processed solely for archiving purposes in the public interest, scientific or historical research purposes or statistical purposes in accordance with Article 89(1) of the GDPR subject to implementation of the appropriate technical and organisational measures required by this Regulation in order to safeguard the rights and freedoms of the data subject."</para>
    /// labels<para>"Principle of Storage Limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#StorageLimitation">https://w3id.org/GDPRtEXT#StorageLimitation</seealso>
    let StorageLimitation = Prefixed_Name(gdprtext, "StorageLimitation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#StoreData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity where personal data is being stored"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Store Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#StoreData">https://w3id.org/GDPRtEXT#StoreData</seealso>
    let StoreData = Prefixed_Name(gdprtext, "StoreData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#SubPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubPoint in GDPR text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SubPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SubPoint">https://w3id.org/GDPRtEXT#SubPoint</seealso>
    let SubPoint = Prefixed_Name(gdprtext, "SubPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#SubProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sub-processor is a processor acting under another processor."</para>
    /// labels<para>"Sub-Processor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SubProcessor">https://w3id.org/GDPRtEXT#SubProcessor</seealso>
    let SubProcessor = Prefixed_Name(gdprtext, "SubProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SubProcessorMustFollowSameTermsAsProcessorControllerAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sub-processors must follow the same rules and obligations (or terms) as the agreement between processor and controller."</para>
    /// labels<para>"Follow same terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SubProcessorMustFollowSameTermsAsProcessorControllerAgreement">https://w3id.org/GDPRtEXT#SubProcessorMustFollowSameTermsAsProcessorControllerAgreement</seealso>
    let SubProcessorMustFollowSameTermsAsProcessorControllerAgreement =
        Prefixed_Name(gdprtext, "SubProcessorMustFollowSameTermsAsProcessorControllerAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#SystematicMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This activity provides a systematic monitoring or overview of processes/activities taking place within the context of the organisation."</para>
    /// labels<para>"Systematic Monitoring"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#SystematicMonitoring">https://w3id.org/GDPRtEXT#SystematicMonitoring</seealso>
    let SystematicMonitoring =
        Prefixed_Name(gdprtext, "SystematicMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#UnlawfulProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processing of personal data that is termed to be unlawful in the context of the GDPR or other relevant laws and regulations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unlawful Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#UnlawfulProcessing">https://w3id.org/GDPRtEXT#UnlawfulProcessing</seealso>
    let UnlawfulProcessing =
        Prefixed_Name(gdprtext, "UnlawfulProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#UseData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that uses personal data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Use Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#UseData">https://w3id.org/GDPRtEXT#UseData</seealso>
    let UseData = Prefixed_Name(gdprtext, "UseData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#ValidConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consent is termed to be valid if it passes all the criteria or obligations laid down by the GDPR."</para>
    /// labels<para>"Valid Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#ValidConsent">https://w3id.org/GDPRtEXT#ValidConsent</seealso>
    let ValidConsent = Prefixed_Name(gdprtext, "ValidConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#VitalInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These are obligations pertaining to the vital interests of the data subjects"</para>
    /// labels<para>"Vital Interests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#VitalInterest">https://w3id.org/GDPRtEXT#VitalInterest</seealso>
    let VitalInterest = Prefixed_Name(gdprtext, "VitalInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#VoluntaryOptInConsentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consent must be obtained through the data subject's voluntary action and should be opt-in and not opt-out or by default."</para>
    /// labels<para>"Voluntary &amp; Opt-in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#VoluntaryOptInConsentObligation">https://w3id.org/GDPRtEXT#VoluntaryOptInConsentObligation</seealso>
    let VoluntaryOptInConsentObligation =
        Prefixed_Name(gdprtext, "VoluntaryOptInConsentObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#VoluntarySystemOfAccredition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The seals and certifications should be a voluntary system of accredition"</para>
    /// labels<para>"Voluntary accredition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#VoluntarySystemOfAccredition">https://w3id.org/GDPRtEXT#VoluntarySystemOfAccredition</seealso>
    let VoluntarySystemOfAccredition =
        Prefixed_Name(gdprtext, "VoluntarySystemOfAccredition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#WithdrawingConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This activity represents the data subject withdrawing given consent."</para>
    /// labels<para>"Withdrawing Given Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#WithdrawingConsent">https://w3id.org/GDPRtEXT#WithdrawingConsent</seealso>
    let WithdrawingConsent =
        Prefixed_Name(gdprtext, "WithdrawingConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"indicates the legal resource has the Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasArticle">https://w3id.org/GDPRtEXT#hasArticle</seealso>
    let hasArticle = Prefixed_Name(gdprtext, "hasArticle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"indicates the legal resource has the Chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasChapter">https://w3id.org/GDPRtEXT#hasChapter</seealso>
    let hasChapter = Prefixed_Name(gdprtext, "hasChapter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"indicates that the legal resource has the referenced citation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Citation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasCitation">https://w3id.org/GDPRtEXT#hasCitation</seealso>
    let hasCitation = Prefixed_Name(gdprtext, "hasCitation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"indicates the legal resource has the Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasPoint">https://w3id.org/GDPRtEXT#hasPoint</seealso>
    let hasPoint = Prefixed_Name(gdprtext, "hasPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasRecital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"indicates the legal resource has the Recital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Recital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasRecital">https://w3id.org/GDPRtEXT#hasRecital</seealso>
    let hasRecital = Prefixed_Name(gdprtext, "hasRecital") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"indicates the legal resource has the Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasSection">https://w3id.org/GDPRtEXT#hasSection</seealso>
    let hasSection = Prefixed_Name(gdprtext, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#hasSubPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"indicates the legal resource has the SubPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has SubPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#hasSubPoint">https://w3id.org/GDPRtEXT#hasSubPoint</seealso>
    let hasSubPoint = Prefixed_Name(gdprtext, "hasSubPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"It signifies that two concepts are related within the context of the GDPR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"involves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#involves">https://w3id.org/GDPRtEXT#involves</seealso>
    let involves = Prefixed_Name(gdprtext, "involves") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#isPartOfArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"represents a legal resource subdivision to be part of a article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#isPartOfArticle">https://w3id.org/GDPRtEXT#isPartOfArticle</seealso>
    let isPartOfArticle = Prefixed_Name(gdprtext, "isPartOfArticle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#isPartOfChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"represents a legal resource subdivision to be part of a chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of Chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#isPartOfChapter">https://w3id.org/GDPRtEXT#isPartOfChapter</seealso>
    let isPartOfChapter = Prefixed_Name(gdprtext, "isPartOfChapter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#isPartOfPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"represents a legal resource subdivision to be part of a point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#isPartOfPoint">https://w3id.org/GDPRtEXT#isPartOfPoint</seealso>
    let isPartOfPoint = Prefixed_Name(gdprtext, "isPartOfPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT#isPartOfSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"represents a legal resource subdivision to be part of a section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT#isPartOfSection">https://w3id.org/GDPRtEXT#isPartOfSection</seealso>
    let isPartOfSection = Prefixed_Name(gdprtext, "isPartOfSection") |> PrefixedName
