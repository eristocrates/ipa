namespace https.w3id.org.vair.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vair =
    let _namespace_iri = Namespace_Iri vair |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:vair#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#">https://w3id.org/vair#</seealso>
    let _prefix_iri = Prefixed_Name(vair, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AGI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Type of AI system that addresses a broad range of tasks with a satisfactory level of performance."</para>
    /// labels<para>"Artificial General Intelligence"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AGI">https://w3id.org/vair#AGI</seealso>
    let AGI = Prefixed_Name(vair, "AGI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AICards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A form of AI documentation"</para>
    /// labels<para>"AI Cards"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AICards">https://w3id.org/vair#AICards</seealso>
    let AICards = Prefixed_Name(vair, "AICards") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AIComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AIComponent">https://w3id.org/vair#AIComponent</seealso>
    let AIComponent = Prefixed_Name(vair, "AIComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Action performed by a system."</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Action">https://w3id.org/vair#Action</seealso>
    let Action = Prefixed_Name(vair, "Action") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ActionRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The capability to recognise actions"</para>
    /// labels<para>"Action Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ActionRecognition">https://w3id.org/vair#ActionRecognition</seealso>
    let ActionRecognition = Prefixed_Name(vair, "ActionRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ActiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Represents active interactation with an AI system."</para>
    /// labels<para>"Active Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ActiveInvolvement">https://w3id.org/vair#ActiveInvolvement</seealso>
    let ActiveInvolvement = Prefixed_Name(vair, "ActiveInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AdministrationOfDemocraticProcesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Activities related to administration of democratic processes"</para>
    /// labels<para>"Administration Of Democratic Processes"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AdministrationOfDemocraticProcesses">https://w3id.org/vair#AdministrationOfDemocraticProcesses</seealso>
    let AdministrationOfDemocraticProcesses =
        Prefixed_Name(vair, "AdministrationOfDemocraticProcesses") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AdministrationOfJustice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Activities related to administration of justice."</para>
    /// labels<para>"Administration Of Justice"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AdministrationOfJustice">https://w3id.org/vair#AdministrationOfJustice</seealso>
    let AdministrationOfJustice =
        Prefixed_Name(vair, "AdministrationOfJustice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AdversarialAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Inputs designed to cause the model to make a mistake"</para>
    /// labels<para>"Adversarial Attack"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AdversarialAttack">https://w3id.org/vair#AdversarialAttack</seealso>
    let AdversarialAttack = Prefixed_Name(vair, "AdversarialAttack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Defines a set of instructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Algorithm">https://w3id.org/vair#Algorithm</seealso>
    let Algorithm = Prefixed_Name(vair, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AllocatingTasks</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assignment of tasks to persons"</para>
    /// labels<para>"Allocating Tasks"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AllocatingTasks">https://w3id.org/vair#AllocatingTasks</seealso>
    let AllocatingTasks = Prefixed_Name(vair, "AllocatingTasks") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ApplicationPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Resource on which an application runs."</para>
    /// labels<para>"Application Platform"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ApplicationPlatform">https://w3id.org/vair#ApplicationPlatform</seealso>
    let ApplicationPlatform = Prefixed_Name(vair, "ApplicationPlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ApplicationScreening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ApplicationScreening">https://w3id.org/vair#ApplicationScreening</seealso>
    let ApplicationScreening =
        Prefixed_Name(vair, "ApplicationScreening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ApplicationSpecificIntegratedCircuit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"An integrated circuit chip customized for a particular use."</para>
    /// labels<para>"Application Specific Integrated Circuit"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ApplicationSpecificIntegratedCircuit">https://w3id.org/vair#ApplicationSpecificIntegratedCircuit</seealso>
    let ApplicationSpecificIntegratedCircuit =
        Prefixed_Name(vair, "ApplicationSpecificIntegratedCircuit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ApplyingTheLawToFacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Applying the law to a concrete set of facts"</para>
    /// labels<para>"Applying The Law To Facts"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ApplyingTheLawToFacts">https://w3id.org/vair#ApplyingTheLawToFacts</seealso>
    let ApplyingTheLawToFacts =
        Prefixed_Name(vair, "ApplyingTheLawToFacts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk."</para>
    /// labels<para>"Approval"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Approval">https://w3id.org/vair#Approval</seealso>
    let Approval = Prefixed_Name(vair, "Approval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AssesingStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AssesingStudent">https://w3id.org/vair#AssesingStudent</seealso>
    let AssesingStudent = Prefixed_Name(vair, "AssesingStudent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingAccessibleLevelOfEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Assessing the appropriate level of education that an individual will be able to access"</para>
    /// labels<para>"Assessing Accessible Level Of Education"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingAccessibleLevelOfEducation">https://w3id.org/vair#AssessingAccessibleLevelOfEducation</seealso>
    let AssessingAccessibleLevelOfEducation =
        Prefixed_Name(vair, "AssessingAccessibleLevelOfEducation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingAdmissionTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AssessingAdmissionTest">https://w3id.org/vair#AssessingAdmissionTest</seealso>
    let AssessingAdmissionTest =
        Prefixed_Name(vair, "AssessingAdmissionTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingCreditworthiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Evaluation the creditworthiness of natural persons or establishing their credit score"</para>
    /// labels<para>"Assessing Creditworthiness"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingCreditworthiness">https://w3id.org/vair#AssessingCreditworthiness</seealso>
    let AssessingCreditworthiness =
        Prefixed_Name(vair, "AssessingCreditworthiness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingHealthRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assessing health risk posed by a person"</para>
    /// labels<para>"Assessing Health Risk"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingHealthRisk">https://w3id.org/vair#AssessingHealthRisk</seealso>
    let AssessingHealthRisk = Prefixed_Name(vair, "AssessingHealthRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingImmigrationEligibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AssessingImmigrationEligibility">https://w3id.org/vair#AssessingImmigrationEligibility</seealso>
    let AssessingImmigrationEligibility =
        Prefixed_Name(vair, "AssessingImmigrationEligibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingLevelOfEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessing the appropriate level of education that an individual will receive"</para>
    /// labels<para>"Assessing Level Of Education"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingLevelOfEducation">https://w3id.org/vair#AssessingLevelOfEducation</seealso>
    let AssessingLevelOfEducation =
        Prefixed_Name(vair, "AssessingLevelOfEducation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingPastCriminalBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Assessing past criminal behaviour of natural persons or groups"</para>
    /// labels<para>"Assessing Past Criminal Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingPastCriminalBehaviour">https://w3id.org/vair#AssessingPastCriminalBehaviour</seealso>
    let AssessingPastCriminalBehaviour =
        Prefixed_Name(vair, "AssessingPastCriminalBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingPeopleRelatedRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Assessing a risk, e.g. a security risk, a risk of irregular migration, or a health risk, posed by a natural person"</para>
    /// labels<para>"Assessing People Related Risk"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingPeopleRelatedRisk">https://w3id.org/vair#AssessingPeopleRelatedRisk</seealso>
    let AssessingPeopleRelatedRisk =
        Prefixed_Name(vair, "AssessingPeopleRelatedRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingPersonalityTraits</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Assessing personality of natural persons or groups"</para>
    /// labels<para>"Assessing Personality Traits"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingPersonalityTraits">https://w3id.org/vair#AssessingPersonalityTraits</seealso>
    let AssessingPersonalityTraits =
        Prefixed_Name(vair, "AssessingPersonalityTraits") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingRiskOfBecomingVictimOfCrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessing risk of a natural person becoming the victim of criminal offences"</para>
    /// labels<para>"Assessing Risk For Potential Victims Of Criminal Offences"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingRiskOfBecomingVictimOfCrime">https://w3id.org/vair#AssessingRiskOfBecomingVictimOfCrime</seealso>
    let AssessingRiskOfBecomingVictimOfCrime =
        Prefixed_Name(vair, "AssessingRiskOfBecomingVictimOfCrime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingRiskOfIrregularImmigration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessing risk of irregular immigration posed by a person"</para>
    /// labels<para>"Assessing Risk Of Irregular Immigration"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingRiskOfIrregularImmigration">https://w3id.org/vair#AssessingRiskOfIrregularImmigration</seealso>
    let AssessingRiskOfIrregularImmigration =
        Prefixed_Name(vair, "AssessingRiskOfIrregularImmigration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingRiskOfOffending</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assessing the risk of a natural person offending"</para>
    /// labels<para>"Assessing Risk Of Offending"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingRiskOfOffending">https://w3id.org/vair#AssessingRiskOfOffending</seealso>
    let AssessingRiskOfOffending =
        Prefixed_Name(vair, "AssessingRiskOfOffending") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingRiskOfReoffending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessing the risk of a natural person re-offending"</para>
    /// labels<para>"Assessing Risk Of Reoffending"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingRiskOfReoffending">https://w3id.org/vair#AssessingRiskOfReoffending</seealso>
    let AssessingRiskOfReoffending =
        Prefixed_Name(vair, "AssessingRiskOfReoffending") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssessingSecurityRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Assess security risk posed by a person"</para>
    /// labels<para>"Assessing Security Risk"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssessingSecurityRisk">https://w3id.org/vair#AssessingSecurityRisk</seealso>
    let AssessingSecurityRisk =
        Prefixed_Name(vair, "AssessingSecurityRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessment and evaluation"</para>
    /// labels<para>"Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Assessment">https://w3id.org/vair#Assessment</seealso>
    let Assessment = Prefixed_Name(vair, "Assessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssigningPersonsToEducationalInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Assigning natural persons to educational institutions at all levels."</para>
    /// labels<para>"Assigning Persons To Educational Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssigningPersonsToEducationalInstitutions">https://w3id.org/vair#AssigningPersonsToEducationalInstitutions</seealso>
    let AssigningPersonsToEducationalInstitutions =
        Prefixed_Name(vair, "AssigningPersonsToEducationalInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssigningPersonsToVocationalTrainingInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assigning natural persons to vocational training institutions at all levels."</para>
    /// labels<para>"Assigning Persons To Vocational Training Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssigningPersonsToVocationalTrainingInstitutions">https://w3id.org/vair#AssigningPersonsToVocationalTrainingInstitutions</seealso>
    let AssigningPersonsToVocationalTrainingInstitutions =
        Prefixed_Name(vair, "AssigningPersonsToVocationalTrainingInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AssistiveAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The level of automation where the system assists an operator"</para>
    /// labels<para>"Assistive Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AssistiveAutomation">https://w3id.org/vair#AssistiveAutomation</seealso>
    let AssistiveAutomation = Prefixed_Name(vair, "AssistiveAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AsylumManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Activities related to asylum management"</para>
    /// labels<para>"Asylum Management"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AsylumManagement">https://w3id.org/vair#AsylumManagement</seealso>
    let AsylumManagement = Prefixed_Name(vair, "AsylumManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AsylumSeeker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"A person who has applied for asylum"</para>
    /// labels<para>"Asylum Seeker"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AsylumSeeker">https://w3id.org/vair#AsylumSeeker</seealso>
    let AsylumSeeker = Prefixed_Name(vair, "AsylumSeeker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Attack</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Malicious attempts to exploit vulnerabilities"</para>
    /// labels<para>"Attack"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Attack">https://w3id.org/vair#Attack</seealso>
    let Attack = Prefixed_Name(vair, "Attack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#AudioProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"The capability to process audio recordings."</para>
    /// labels<para>"Audio Processing"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AudioProcessing">https://w3id.org/vair#AudioProcessing</seealso>
    let AudioProcessing = Prefixed_Name(vair, "AudioProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AuthorisedRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AuthorisedRepresentative">https://w3id.org/vair#AuthorisedRepresentative</seealso>
    let AuthorisedRepresentative =
        Prefixed_Name(vair, "AuthorisedRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Authority">https://w3id.org/vair#Authority</seealso>
    let Authority = Prefixed_Name(vair, "Authority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AutomaticSummarisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Shortening a portion of natural language content or text while retaining important semantic information."</para>
    /// labels<para>"Automatic Summarisation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#AutomaticSummarisation">https://w3id.org/vair#AutomaticSummarisation</seealso>
    let AutomaticSummarisation =
        Prefixed_Name(vair, "AutomaticSummarisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#AutonomousSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#AutonomousSystem">https://w3id.org/vair#AutonomousSystem</seealso>
    let AutonomousSystem = Prefixed_Name(vair, "AutonomousSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Autonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"The level of automation where the system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight."</para>
    /// labels<para>"Autonomy"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Autonomy">https://w3id.org/vair#Autonomy</seealso>
    let Autonomy = Prefixed_Name(vair, "Autonomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#BayesianEstimation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to Bayesian estimation approach"</para>
    /// labels<para>"Bayesian Estimation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BayesianEstimation">https://w3id.org/vair#BayesianEstimation</seealso>
    let BayesianEstimation = Prefixed_Name(vair, "BayesianEstimation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#BayesianNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Probabilistic model  that uses Bayesian inference  for probability computations using a directed acyclic graph."</para>
    /// labels<para>"Bayesian Network"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BayesianNetwork">https://w3id.org/vair#BayesianNetwork</seealso>
    let BayesianNetwork = Prefixed_Name(vair, "BayesianNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BayesianOptimisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to Bayesian optimisation technique."</para>
    /// labels<para>"Bayesian Optimisation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BayesianOptimisation">https://w3id.org/vair#BayesianOptimisation</seealso>
    let BayesianOptimisation =
        Prefixed_Name(vair, "BayesianOptimisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BehaviourAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a system in analysing people's behaviour"</para>
    /// labels<para>"Behaviour Analysis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BehaviourAnalysis">https://w3id.org/vair#BehaviourAnalysis</seealso>
    let BehaviourAnalysis = Prefixed_Name(vair, "BehaviourAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Bias</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Systematic difference in treatment of certain objects, people or groups in comparison to others."</para>
    /// labels<para>"Bias"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Bias">https://w3id.org/vair#Bias</seealso>
    let Bias = Prefixed_Name(vair, "Bias") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#BiasDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Control that is applied to detect bias in datasets, models, algorithms, etc."</para>
    /// labels<para>"Bias Detection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiasDetection">https://w3id.org/vair#BiasDetection</seealso>
    let BiasDetection = Prefixed_Name(vair, "BiasDetection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#BiasedTestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Bias in test data"</para>
    /// labels<para>"Biased Test Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiasedTestData">https://w3id.org/vair#BiasedTestData</seealso>
    let BiasedTestData = Prefixed_Name(vair, "BiasedTestData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#BiasedTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Bias in training data"</para>
    /// labels<para>"Biased Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiasedTrainingData">https://w3id.org/vair#BiasedTrainingData</seealso>
    let BiasedTrainingData = Prefixed_Name(vair, "BiasedTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BiasedValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Bias in validation data"</para>
    /// labels<para>"Biased Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiasedValidationData">https://w3id.org/vair#BiasedValidationData</seealso>
    let BiasedValidationData =
        Prefixed_Name(vair, "BiasedValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BiometricCategorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The capability of the system is assigning natural persons to specific categories based on their biometric data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biometric Categorisation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiometricCategorisation">https://w3id.org/vair#BiometricCategorisation</seealso>
    let BiometricCategorisation =
        Prefixed_Name(vair, "BiometricCategorisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BiometricIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Automated recognition of physical, physiological and behavioural human features such as the face, eye movement, body shape, voice, prosody, gait, posture, heart rate, blood pressure, odour, keystrokes characteristics, for the purpose of establishing an individual’s identity by comparing biometric data of that individual to stored biometric data of individuals in a reference database, irrespective of whether the individual has given its consent or not."</para>
    /// labels<para>"Biometric Identification"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiometricIdentification">https://w3id.org/vair#BiometricIdentification</seealso>
    let BiometricIdentification =
        Prefixed_Name(vair, "BiometricIdentification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BiometricsBasedEmotionRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to recognisting emtions based on biometrics information"</para>
    /// labels<para>"Biometrics Based Emotion Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BiometricsBasedEmotionRecognition">https://w3id.org/vair#BiometricsBasedEmotionRecognition</seealso>
    let BiometricsBasedEmotionRecognition =
        Prefixed_Name(vair, "BiometricsBasedEmotionRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BiometricsBasedEmotionSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#BiometricsBasedEmotionSensing">https://w3id.org/vair#BiometricsBasedEmotionSensing</seealso>
    let BiometricsBasedEmotionSensing =
        Prefixed_Name(vair, "BiometricsBasedEmotionSensing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Blueprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Blueprint">https://w3id.org/vair#Blueprint</seealso>
    let Blueprint = Prefixed_Name(vair, "Blueprint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BorderControlManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Activities related to border control management."</para>
    /// labels<para>"Border Control Management"</para></remarks>
    /// <seealso href="https://w3id.org/vair#BorderControlManagement">https://w3id.org/vair#BorderControlManagement</seealso>
    let BorderControlManagement =
        Prefixed_Name(vair, "BorderControlManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#BorderControlSecurityCheck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#BorderControlSecurityCheck">https://w3id.org/vair#BorderControlSecurityCheck</seealso>
    let BorderControlSecurityCheck =
        Prefixed_Name(vair, "BorderControlSecurityCheck") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CannotOptOutOfOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A mode of controllability that stakeholders cannot opt out of the system’s output."</para>
    /// labels<para>"Cannot Opt Out Of Output"</para></remarks>
    /// <seealso href="https://w3id.org/vair#CannotOptOutOfOutput">https://w3id.org/vair#CannotOptOutOfOutput</seealso>
    let CannotOptOutOfOutput =
        Prefixed_Name(vair, "CannotOptOutOfOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CaseBasedReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#CaseBasedReasoning">https://w3id.org/vair#CaseBasedReasoning</seealso>
    let CaseBasedReasoning = Prefixed_Name(vair, "CaseBasedReasoning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Categorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assigning natural persons to specific categories"</para>
    /// labels<para>"Categorisation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Categorisation">https://w3id.org/vair#Categorisation</seealso>
    let Categorisation = Prefixed_Name(vair, "Categorisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ChallengeOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A mode of controllability that stakeholders can challenge the system’s output."</para>
    /// labels<para>"Challenge Output"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ChallengeOutput">https://w3id.org/vair#ChallengeOutput</seealso>
    let ChallengeOutput = Prefixed_Name(vair, "ChallengeOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ClassifyingEmergencyCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Classifying emergency calls by natural persons"</para>
    /// labels<para>"Classifying Emergency Call"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ClassifyingEmergencyCall">https://w3id.org/vair#ClassifyingEmergencyCall</seealso>
    let ClassifyingEmergencyCall =
        Prefixed_Name(vair, "ClassifyingEmergencyCall") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CognitiveComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Category of AI systems that enables people and machines to interact more naturally."</para>
    /// labels<para>"Cognitive Computing"</para></remarks>
    /// <seealso href="https://w3id.org/vair#CognitiveComputing">https://w3id.org/vair#CognitiveComputing</seealso>
    let CognitiveComputing = Prefixed_Name(vair, "CognitiveComputing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#CognitiveSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#CognitiveSystem">https://w3id.org/vair#CognitiveSystem</seealso>
    let CognitiveSystem = Prefixed_Name(vair, "CognitiveSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CommonSenseReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#CommonSenseReasoning">https://w3id.org/vair#CommonSenseReasoning</seealso>
    let CommonSenseReasoning =
        Prefixed_Name(vair, "CommonSenseReasoning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ComputerVision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Capability of a functional unit to acquire, process and interpret data representing images or video."</para>
    /// labels<para>"Computer Vision"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ComputerVision">https://w3id.org/vair#ComputerVision</seealso>
    let ComputerVision = Prefixed_Name(vair, "ComputerVision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a concept in VAIR"</para>
    /// labels<para>"Concept"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Concept">https://w3id.org/vair#Concept</seealso>
    let Concept = Prefixed_Name(vair, "Concept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ConditionalAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The level of automation where there is sustained and specific performance by a system, with an external agent being ready to take over when necessary."</para>
    /// labels<para>"Conditional Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ConditionalAutomation">https://w3id.org/vair#ConditionalAutomation</seealso>
    let ConditionalAutomation =
        Prefixed_Name(vair, "ConditionalAutomation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ConformityAssessmentBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ConformityAssessmentBody">https://w3id.org/vair#ConformityAssessmentBody</seealso>
    let ConformityAssessmentBody =
        Prefixed_Name(vair, "ConformityAssessmentBody") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Content generated using an AI system."</para>
    /// labels<para>"Content"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Content">https://w3id.org/vair#Content</seealso>
    let Content = Prefixed_Name(vair, "Content") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ContentGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Generation or manipulation of audio content"</para>
    /// labels<para>"Content Generation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ContentGeneration">https://w3id.org/vair#ContentGeneration</seealso>
    let ContentGeneration = Prefixed_Name(vair, "ContentGeneration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ContinuousValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to validation phase of continuous learning AI systems, wherein incremental training takes place on an ongoing basis while the system is running in production."</para>
    /// labels<para>"Continuous Validation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ContinuousValidation">https://w3id.org/vair#ContinuousValidation</seealso>
    let ContinuousValidation =
        Prefixed_Name(vair, "ContinuousValidation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ConvolutionalNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Feed forward neural network using convolution  in at least one of its layers."</para>
    /// labels<para>"Convolutional Neural Network"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ConvolutionalNeuralNetwork">https://w3id.org/vair#ConvolutionalNeuralNetwork</seealso>
    let ConvolutionalNeuralNetwork =
        Prefixed_Name(vair, "ConvolutionalNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CorrectOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"A mode of controllability that stakeholders can correct the system’s output."</para>
    /// labels<para>"Correct Output"</para></remarks>
    /// <seealso href="https://w3id.org/vair#CorrectOutput">https://w3id.org/vair#CorrectOutput</seealso>
    let CorrectOutput = Prefixed_Name(vair, "CorrectOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#CourseApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#CourseApplicant">https://w3id.org/vair#CourseApplicant</seealso>
    let CourseApplicant = Prefixed_Name(vair, "CourseApplicant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#CourseAttendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A person who attends a course."</para>
    /// labels<para>"Course Attendee"</para></remarks>
    /// <seealso href="https://w3id.org/vair#CourseAttendee">https://w3id.org/vair#CourseAttendee</seealso>
    let CourseAttendee = Prefixed_Name(vair, "CourseAttendee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#CriticalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to the sector or activities that aim at provision and maintainance of critical services."</para>
    /// labels<para>"Critical Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#CriticalInfrastructure">https://w3id.org/vair#CriticalInfrastructure</seealso>
    let CriticalInfrastructure =
        Prefixed_Name(vair, "CriticalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Cyberattack</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Cyberattack">https://w3id.org/vair#Cyberattack</seealso>
    let Cyberattack = Prefixed_Name(vair, "Cyberattack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Data">https://w3id.org/vair#Data</seealso>
    let Data = Prefixed_Name(vair, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DataCollection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#DataCollection">https://w3id.org/vair#DataCollection</seealso>
    let DataCollection = Prefixed_Name(vair, "DataCollection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DataPoisoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Attack trying to manipulate the training dataset."</para>
    /// labels<para>"Data Poisoning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DataPoisoning">https://w3id.org/vair#DataPoisoning</seealso>
    let DataPoisoning = Prefixed_Name(vair, "DataPoisoning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DataPrepration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#DataPrepration">https://w3id.org/vair#DataPrepration</seealso>
    let DataPrepration = Prefixed_Name(vair, "DataPrepration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Risk sources related to data"</para>
    /// labels<para>"Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DataRiskSource">https://w3id.org/vair#DataRiskSource</seealso>
    let DataRiskSource = Prefixed_Name(vair, "DataRiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Dataset">https://w3id.org/vair#Dataset</seealso>
    let Dataset = Prefixed_Name(vair, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Datasheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A form of dataset documentation"</para>
    /// labels<para>"Datasheet"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Datasheet">https://w3id.org/vair#Datasheet</seealso>
    let Datasheet = Prefixed_Name(vair, "Datasheet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Death">https://w3id.org/vair#Death</seealso>
    let Death = Prefixed_Name(vair, "Death") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Decision</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Decision generated by an AI system"</para>
    /// labels<para>"Decision"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Decision">https://w3id.org/vair#Decision</seealso>
    let Decision = Prefixed_Name(vair, "Decision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DecisionMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Generation of decisions"</para>
    /// labels<para>"Decision Making"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DecisionMaking">https://w3id.org/vair#DecisionMaking</seealso>
    let DecisionMaking = Prefixed_Name(vair, "DecisionMaking") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DecisionSupportSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#DecisionSupportSystem">https://w3id.org/vair#DecisionSupportSystem</seealso>
    let DecisionSupportSystem =
        Prefixed_Name(vair, "DecisionSupportSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DecisionTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Model for which inference  is encoded as paths from the root to a leaf node in a tree structure."</para>
    /// labels<para>"Decision Tree"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DecisionTree">https://w3id.org/vair#DecisionTree</seealso>
    let DecisionTree = Prefixed_Name(vair, "DecisionTree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DecreasedRobustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Decreased level of system's robustness resulted from materialisation of a risk."</para>
    /// labels<para>"Decreased Robustness"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DecreasedRobustness">https://w3id.org/vair#DecreasedRobustness</seealso>
    let DecreasedRobustness = Prefixed_Name(vair, "DecreasedRobustness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DecreasedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Decreased level of security of system resulted from materialisation of a risk."</para>
    /// labels<para>"Decreased Security"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DecreasedSecurity">https://w3id.org/vair#DecreasedSecurity</seealso>
    let DecreasedSecurity = Prefixed_Name(vair, "DecreasedSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DeepFakeDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Dectection of content that is generated using deep fake"</para>
    /// labels<para>"Deep Fake Detection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeepFakeDetection">https://w3id.org/vair#DeepFakeDetection</seealso>
    let DeepFakeDetection = Prefixed_Name(vair, "DeepFakeDetection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DeepLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Approach to creating rich hierarchical representations through the training of neural networks with many hidden layers"</para>
    /// labels<para>"Deep learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeepLearning">https://w3id.org/vair#DeepLearning</seealso>
    let DeepLearning = Prefixed_Name(vair, "DeepLearning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DegradedAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Decreased level of system's accuracy resulted from materialisation of a risk."</para>
    /// labels<para>"Degraded Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DegradedAccuracy">https://w3id.org/vair#DegradedAccuracy</seealso>
    let DegradedAccuracy = Prefixed_Name(vair, "DegradedAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to deployment phase oThe AI system is installed, released or configured for operation in a target environment."</para>
    /// labels<para>"Deployment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Deployment">https://w3id.org/vair#Deployment</seealso>
    let Deployment = Prefixed_Name(vair, "Deployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to design phase of AI development"</para>
    /// labels<para>"Design"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Design">https://w3id.org/vair#Design</seealso>
    let Design = Prefixed_Name(vair, "Design") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DesignSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Design specification of a system"</para>
    /// labels<para>"Design Specification"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DesignSpecification">https://w3id.org/vair#DesignSpecification</seealso>
    let DesignSpecification = Prefixed_Name(vair, "DesignSpecification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Detecting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Detecting">https://w3id.org/vair#Detecting</seealso>
    let Detecting = Prefixed_Name(vair, "Detecting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Detection of criminal offences"</para>
    /// labels<para>"Detecting Criminal Offences"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingCriminalOffences">https://w3id.org/vair#DetectingCriminalOffences</seealso>
    let DetectingCriminalOffences =
        Prefixed_Name(vair, "DetectingCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingEmotionalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Detection of the emotional state of a natural person"</para>
    /// labels<para>"Detecting Emotional State"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingEmotionalState">https://w3id.org/vair#DetectingEmotionalState</seealso>
    let DetectingEmotionalState =
        Prefixed_Name(vair, "DetectingEmotionalState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Detecting natural persons "</para>
    /// labels<para>"Detecting Individuals"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingIndividuals">https://w3id.org/vair#DetectingIndividuals</seealso>
    let DetectingIndividuals =
        Prefixed_Name(vair, "DetectingIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingLies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Dectecting lies"</para>
    /// labels<para>"Detecting Lies"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingLies">https://w3id.org/vair#DetectingLies</seealso>
    let DetectingLies = Prefixed_Name(vair, "DetectingLies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingNon-AuthenticDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Detection of  non-authentic documents"</para>
    /// labels<para>"Detecting Non Authentic Document"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingNon-AuthenticDocument">https://w3id.org/vair#DetectingNon-AuthenticDocument</seealso>
    let DetectingNon_AuthenticDocument =
        Prefixed_Name(vair, "DetectingNon-AuthenticDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DetectingProhibitedBehaviourDuringTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Detecting prohibited behaviour during tests"</para>
    /// labels<para>"Detecting Prohibited Behaviour During Test"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectingProhibitedBehaviourDuringTest">https://w3id.org/vair#DetectingProhibitedBehaviourDuringTest</seealso>
    let DetectingProhibitedBehaviourDuringTest =
        Prefixed_Name(vair, "DetectingProhibitedBehaviourDuringTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Detection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Purposes related to detecting"</para>
    /// labels<para>"Detection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Detection">https://w3id.org/vair#Detection</seealso>
    let Detection = Prefixed_Name(vair, "Detection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DetectionControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Control that is applied for detection purposes, e.g. detecting risks"</para>
    /// labels<para>"Detection Control"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DetectionControl">https://w3id.org/vair#DetectionControl</seealso>
    let DetectionControl = Prefixed_Name(vair, "DetectionControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DeterminingAccessToEducationalInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Determining access to educational institutions all levels."</para>
    /// labels<para>"Determining Access To Educational Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeterminingAccessToEducationalInstitutions">https://w3id.org/vair#DeterminingAccessToEducationalInstitutions</seealso>
    let DeterminingAccessToEducationalInstitutions =
        Prefixed_Name(vair, "DeterminingAccessToEducationalInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DeterminingAccessToVocationalTrainingInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Determining access to vocational training institutions all levels."</para>
    /// labels<para>"Determining Access To Vocational Training Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeterminingAccessToVocationalTrainingInstitutions">https://w3id.org/vair#DeterminingAccessToVocationalTrainingInstitutions</seealso>
    let DeterminingAccessToVocationalTrainingInstitutions =
        Prefixed_Name(vair, "DeterminingAccessToVocationalTrainingInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DeterminingAdmissionToEducationalInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Determining admission to educational institutions at all levels."</para>
    /// labels<para>"Determining Admission To Educational Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeterminingAdmissionToEducationalInstitutions">https://w3id.org/vair#DeterminingAdmissionToEducationalInstitutions</seealso>
    let DeterminingAdmissionToEducationalInstitutions =
        Prefixed_Name(vair, "DeterminingAdmissionToEducationalInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DeterminingAdmissionToVocationalTrainingInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Determining admission to vocational training institutions at all levels."</para>
    /// labels<para>"Determining Admission To Vocational Training Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeterminingAdmissionToVocationalTrainingInstitutions">https://w3id.org/vair#DeterminingAdmissionToVocationalTrainingInstitutions</seealso>
    let DeterminingAdmissionToVocationalTrainingInstitutions =
        Prefixed_Name(vair, "DeterminingAdmissionToVocationalTrainingInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DeterminingCreditScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Determining credit score of a person"</para>
    /// labels<para>"Determining Credit Score"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DeterminingCreditScore">https://w3id.org/vair#DeterminingCreditScore</seealso>
    let DeterminingCreditScore =
        Prefixed_Name(vair, "DeterminingCreditScore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the development phase in AI lifecyle"</para>
    /// labels<para>"Development"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Development">https://w3id.org/vair#Development</seealso>
    let Development = Prefixed_Name(vair, "Development") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DevelopmentData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#DevelopmentData">https://w3id.org/vair#DevelopmentData</seealso>
    let DevelopmentData = Prefixed_Name(vair, "DevelopmentData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#DialogueManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Choosing the appropriate next move in a dialogue based on user input, the dialogue history and other contextual knowledge to meet a desired goal"</para>
    /// labels<para>"Dialogue Management"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DialogueManagement">https://w3id.org/vair#DialogueManagement</seealso>
    let DialogueManagement = Prefixed_Name(vair, "DialogueManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DiscoveringCrimePatterns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Identifying unkown patterns of crime"</para>
    /// labels<para>"Discovering Crime Patterns"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DiscoveringCrimePatterns">https://w3id.org/vair#DiscoveringCrimePatterns</seealso>
    let DiscoveringCrimePatterns =
        Prefixed_Name(vair, "DiscoveringCrimePatterns") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DiscoveringCrimeRelationships</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Discovering hidden relationships related to crime"</para>
    /// labels<para>"Discovering Crime Relationships"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DiscoveringCrimeRelationships">https://w3id.org/vair#DiscoveringCrimeRelationships</seealso>
    let DiscoveringCrimeRelationships =
        Prefixed_Name(vair, "DiscoveringCrimeRelationships") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DispatchingEmergencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Dispatching  of emergency first response services, including by firefighters and medical aid"</para>
    /// labels<para>"Dispatching  Emergency Service"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DispatchingEmergencyService">https://w3id.org/vair#DispatchingEmergencyService</seealso>
    let DispatchingEmergencyService =
        Prefixed_Name(vair, "DispatchingEmergencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#DistortionInHumanBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Represent distortion of human behaviour caused by AI"</para>
    /// labels<para>"Distortion In Human Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/vair#DistortionInHumanBehaviour">https://w3id.org/vair#DistortionInHumanBehaviour</seealso>
    let DistortionInHumanBehaviour =
        Prefixed_Name(vair, "DistortionInHumanBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Distributor">https://w3id.org/vair#Distributor</seealso>
    let Distributor = Prefixed_Name(vair, "Distributor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#EUAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Union agency"</para>
    /// labels<para>"EU Agency"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EUAgency">https://w3id.org/vair#EUAgency</seealso>
    let EUAgency = Prefixed_Name(vair, "EUAgency") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#EUBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Union body"</para>
    /// labels<para>"EU Body"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EUBody">https://w3id.org/vair#EUBody</seealso>
    let EUBody = Prefixed_Name(vair, "EUBody") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EUDeclarationOfConformity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Document providing the EU declaration of conformity, as required by the AI Act, Article 47."</para>
    /// labels<para>"EU Declaration Of Conformity"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EUDeclarationOfConformity">https://w3id.org/vair#EUDeclarationOfConformity</seealso>
    let EUDeclarationOfConformity =
        Prefixed_Name(vair, "EUDeclarationOfConformity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EUInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Union institution"</para>
    /// labels<para>"EU Institution"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EUInstitution">https://w3id.org/vair#EUInstitution</seealso>
    let EUInstitution = Prefixed_Name(vair, "EUInstitution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#EUOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"EU office"</para>
    /// labels<para>"EU Office"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EUOffice">https://w3id.org/vair#EUOffice</seealso>
    let EUOffice = Prefixed_Name(vair, "EUOffice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Indicates the sector that offers education or vocational training at any level or for any profession."</para>
    /// labels<para>"Education"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Education">https://w3id.org/vair#Education</seealso>
    let Education = Prefixed_Name(vair, "Education") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EducationalInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Educational institution at any level"</para>
    /// labels<para>"Educational Institution"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EducationalInstitution">https://w3id.org/vair#EducationalInstitution</seealso>
    let EducationalInstitution =
        Prefixed_Name(vair, "EducationalInstitution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EmergancyTriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EmergancyTriage">https://w3id.org/vair#EmergancyTriage</seealso>
    let EmergancyTriage = Prefixed_Name(vair, "EmergancyTriage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EmergencyHealthCareProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refer to emergency healthcare providers"</para>
    /// labels<para>"Emergency Healthcare Provider"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EmergencyHealthCareProvider">https://w3id.org/vair#EmergencyHealthCareProvider</seealso>
    let EmergencyHealthCareProvider =
        Prefixed_Name(vair, "EmergencyHealthCareProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EmergencyServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provider of emergency first response services"</para>
    /// labels<para>"Emergency Service Provider"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EmergencyServiceProvider">https://w3id.org/vair#EmergencyServiceProvider</seealso>
    let EmergencyServiceProvider =
        Prefixed_Name(vair, "EmergencyServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EmergencyTriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Emergency triaging"</para>
    /// labels<para>"Emergency Triage"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EmergencyTriage">https://w3id.org/vair#EmergencyTriage</seealso>
    let EmergencyTriage = Prefixed_Name(vair, "EmergencyTriage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#EmotionRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Computationally identifying and categorizing emotions expressed in a piece of text, speech, video or image or combination thereof."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emotion Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EmotionRecognition">https://w3id.org/vair#EmotionRecognition</seealso>
    let EmotionRecognition = Prefixed_Name(vair, "EmotionRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#EmotionSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EmotionSensing">https://w3id.org/vair#EmotionSensing</seealso>
    let EmotionSensing = Prefixed_Name(vair, "EmotionSensing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A person in work-related contractual relationships"</para>
    /// labels<para>"Employee"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Employee">https://w3id.org/vair#Employee</seealso>
    let Employee = Prefixed_Name(vair, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to employment, workers’ management and access to self-employment."</para>
    /// labels<para>"Employment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Employment">https://w3id.org/vair#Employment</seealso>
    let Employment = Prefixed_Name(vair, "Employment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ErroneousInputData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Error in data used as input"</para>
    /// labels<para>"Erroneous Input Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErroneousInputData">https://w3id.org/vair#ErroneousInputData</seealso>
    let ErroneousInputData = Prefixed_Name(vair, "ErroneousInputData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ErroneousTestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Error in test data"</para>
    /// labels<para>"Erroneous Test Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErroneousTestData">https://w3id.org/vair#ErroneousTestData</seealso>
    let ErroneousTestData = Prefixed_Name(vair, "ErroneousTestData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ErroneousTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Error in training data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Erroneous Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErroneousTrainingData">https://w3id.org/vair#ErroneousTrainingData</seealso>
    let ErroneousTrainingData =
        Prefixed_Name(vair, "ErroneousTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ErroneousValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Error in validation data"</para>
    /// labels<para>"Erroneous Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErroneousValidationData">https://w3id.org/vair#ErroneousValidationData</seealso>
    let ErroneousValidationData =
        Prefixed_Name(vair, "ErroneousValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ErrorInDataCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to errors in data collection process"</para>
    /// labels<para>"Error In Data Collection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErrorInDataCollection">https://w3id.org/vair#ErrorInDataCollection</seealso>
    let ErrorInDataCollection =
        Prefixed_Name(vair, "ErrorInDataCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ErrorInDataPrepration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to errors in data prepration process"</para>
    /// labels<para>"Error In Data Prepration"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ErrorInDataPrepration">https://w3id.org/vair#ErrorInDataPrepration</seealso>
    let ErrorInDataPrepration =
        Prefixed_Name(vair, "ErrorInDataPrepration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EuropeanArtificialIntelligenceBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EuropeanArtificialIntelligenceBoard">https://w3id.org/vair#EuropeanArtificialIntelligenceBoard</seealso>
    let EuropeanArtificialIntelligenceBoard =
        Prefixed_Name(vair, "EuropeanArtificialIntelligenceBoard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EuropeanDataProtectionSupervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EuropeanDataProtectionSupervisor">https://w3id.org/vair#EuropeanDataProtectionSupervisor</seealso>
    let EuropeanDataProtectionSupervisor =
        Prefixed_Name(vair, "EuropeanDataProtectionSupervisor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEligibilityForPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Evaluating the eligibility of natural persons for essential public assistance benefits and services, including healthcare services,"</para>
    /// labels<para>"Evaluating Eligibility For Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEligibilityForPublicAssistanceServices">https://w3id.org/vair#EvaluatingEligibilityForPublicAssistanceServices</seealso>
    let EvaluatingEligibilityForPublicAssistanceServices =
        Prefixed_Name(vair, "EvaluatingEligibilityForPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEligibilityToAccessPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEligibilityToAccessPublicAssistanceServices">https://w3id.org/vair#EvaluatingEligibilityToAccessPublicAssistanceServices</seealso>
    let EvaluatingEligibilityToAccessPublicAssistanceServices =
        Prefixed_Name(vair, "EvaluatingEligibilityToAccessPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEligibilityforHealthCareServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Evaluating the eligibility of natural persons for healthcare services"</para>
    /// labels<para>"Evaluating Eligibility For Healthcare Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEligibilityforHealthCareServices">https://w3id.org/vair#EvaluatingEligibilityforHealthCareServices</seealso>
    let EvaluatingEligibilityforHealthCareServices =
        Prefixed_Name(vair, "EvaluatingEligibilityforHealthCareServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEmergencyCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Evaluating emergency calls by natural persons"</para>
    /// labels<para>"Evaluating Emergency Call"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEmergencyCall">https://w3id.org/vair#EvaluatingEmergencyCall</seealso>
    let EvaluatingEmergencyCall =
        Prefixed_Name(vair, "EvaluatingEmergencyCall") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEmployee">https://w3id.org/vair#EvaluatingEmployee</seealso>
    let EvaluatingEmployee = Prefixed_Name(vair, "EvaluatingEmployee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEmployeeBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Evaluating the behaviour of persons in work-related relationships."</para>
    /// labels<para>"Evaluating Employee Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEmployeeBehaviour">https://w3id.org/vair#EvaluatingEmployeeBehaviour</seealso>
    let EvaluatingEmployeeBehaviour =
        Prefixed_Name(vair, "EvaluatingEmployeeBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingEmployeePerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Evaluating the performance of persons in work-related relationships."</para>
    /// labels<para>"Evaluating Employee Performance"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingEmployeePerformance">https://w3id.org/vair#EvaluatingEmployeePerformance</seealso>
    let EvaluatingEmployeePerformance =
        Prefixed_Name(vair, "EvaluatingEmployeePerformance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingInterview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingInterview">https://w3id.org/vair#EvaluatingInterview</seealso>
    let EvaluatingInterview = Prefixed_Name(vair, "EvaluatingInterview") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingJobCandidates</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Evaluation of job candidates"</para>
    /// labels<para>"Evaluating Job Candidates"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingJobCandidates">https://w3id.org/vair#EvaluatingJobCandidates</seealso>
    let EvaluatingJobCandidates =
        Prefixed_Name(vair, "EvaluatingJobCandidates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingJobInterview</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Evaluation of job interviews"</para>
    /// labels<para>"Evaluating Job Interview"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingJobInterview">https://w3id.org/vair#EvaluatingJobInterview</seealso>
    let EvaluatingJobInterview =
        Prefixed_Name(vair, "EvaluatingJobInterview") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingLearningOutcomes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Evaluating learning outcomes, including when those outcomes are used to steer the learning process of natural persons in educational and vocational training institutions or programmes at all levels."</para>
    /// labels<para>"Evaluating Learning Outcomes"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingLearningOutcomes">https://w3id.org/vair#EvaluatingLearningOutcomes</seealso>
    let EvaluatingLearningOutcomes =
        Prefixed_Name(vair, "EvaluatingLearningOutcomes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingRecruitmentTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingRecruitmentTest">https://w3id.org/vair#EvaluatingRecruitmentTest</seealso>
    let EvaluatingRecruitmentTest =
        Prefixed_Name(vair, "EvaluatingRecruitmentTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Evaluation of the reliability of evidence in the course of investigation of criminal offences"</para>
    /// labels<para>"Evaluating Reliability Of Evidence In Investigation Of Criminal Offences "</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences">https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences</seealso>
    let EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences =
        Prefixed_Name(vair, "EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Assessments of the reliability of evidence in the examination of applications for asylum, visa or residence permits and for associated complaints with regard to the eligibility of the natural persons applying for a status"</para>
    /// labels<para>"Evaluating Reliability Of Evidence In Migration Related Applications"</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications">https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications</seealso>
    let EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications =
        Prefixed_Name(vair, "EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Evaluation of the reliability of evidence in the course of prosecution of criminal offences"</para>
    /// labels<para>"Evaluating Reliability Of Evidence In Prosecution Of Criminal Offences "</para></remarks>
    /// <seealso href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences">https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences</seealso>
    let EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences =
        Prefixed_Name(vair, "EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvaluationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvaluationData">https://w3id.org/vair#EvaluationData</seealso>
    let EvaluationData = Prefixed_Name(vair, "EvaluationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#EvolutionaryAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#EvolutionaryAlgorithm">https://w3id.org/vair#EvolutionaryAlgorithm</seealso>
    let EvolutionaryAlgorithm =
        Prefixed_Name(vair, "EvolutionaryAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExaminingApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purposes related to examining an application"</para>
    /// labels<para>"Examining Application"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExaminingApplication">https://w3id.org/vair#ExaminingApplication</seealso>
    let ExaminingApplication =
        Prefixed_Name(vair, "ExaminingApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExaminingAsylumApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Examining asylum application"</para>
    /// labels<para>"Examining Asylum Application"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExaminingAsylumApplication">https://w3id.org/vair#ExaminingAsylumApplication</seealso>
    let ExaminingAsylumApplication =
        Prefixed_Name(vair, "ExaminingAsylumApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExaminingMigrationRelatedComplaints</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Examining compliats related to migration"</para>
    /// labels<para>"Examining Migration Related Complaints"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExaminingMigrationRelatedComplaints">https://w3id.org/vair#ExaminingMigrationRelatedComplaints</seealso>
    let ExaminingMigrationRelatedComplaints =
        Prefixed_Name(vair, "ExaminingMigrationRelatedComplaints") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExaminingResidencePermitsApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Examining residence permit application"</para>
    /// labels<para>"Examining Residence Permits Application"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExaminingResidencePermitsApplication">https://w3id.org/vair#ExaminingResidencePermitsApplication</seealso>
    let ExaminingResidencePermitsApplication =
        Prefixed_Name(vair, "ExaminingResidencePermitsApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExaminingVisaApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Examining visa application"</para>
    /// labels<para>"Examining Visa Application"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExaminingVisaApplication">https://w3id.org/vair#ExaminingVisaApplication</seealso>
    let ExaminingVisaApplication =
        Prefixed_Name(vair, "ExaminingVisaApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ExpertSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"AI system that accumulates, combines and encapsulates knowledge provided by a human expert or experts in a specific domain to infer solutions to problems."</para>
    /// labels<para>"Expert System"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ExpertSystem">https://w3id.org/vair#ExpertSystem</seealso>
    let ExpertSystem = Prefixed_Name(vair, "ExpertSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ExplainingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ExplainingAlgorithm">https://w3id.org/vair#ExplainingAlgorithm</seealso>
    let ExplainingAlgorithm = Prefixed_Name(vair, "ExplainingAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#FaceRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs."</para>
    /// labels<para>"Face Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#FaceRecognition">https://w3id.org/vair#FaceRecognition</seealso>
    let FaceRecognition = Prefixed_Name(vair, "FaceRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A group of people related to each other by blood or marraige"</para>
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Family">https://w3id.org/vair#Family</seealso>
    let Family = Prefixed_Name(vair, "Family") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#FeedForwardNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Neural network where information is fed from the input layer to the output layer in one direction only."</para>
    /// labels<para>"Feed Forward Neural Network"</para></remarks>
    /// <seealso href="https://w3id.org/vair#FeedForwardNeuralNetwork">https://w3id.org/vair#FeedForwardNeuralNetwork</seealso>
    let FeedForwardNeuralNetwork =
        Prefixed_Name(vair, "FeedForwardNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#FireBrigade</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to fire department"</para>
    /// labels<para>"Fire Brigade"</para></remarks>
    /// <seealso href="https://w3id.org/vair#FireBrigade">https://w3id.org/vair#FireBrigade</seealso>
    let FireBrigade = Prefixed_Name(vair, "FireBrigade") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Firefighter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Firefighter">https://w3id.org/vair#Firefighter</seealso>
    let Firefighter = Prefixed_Name(vair, "Firefighter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Freedom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to freedoms given to individuals"</para>
    /// labels<para>"Freedom"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Freedom">https://w3id.org/vair#Freedom</seealso>
    let Freedom = Prefixed_Name(vair, "Freedom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#FullAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The level of automation where is capable of performing its entire mission without external intervention."</para>
    /// labels<para>"Full Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#FullAutomation">https://w3id.org/vair#FullAutomation</seealso>
    let FullAutomation = Prefixed_Name(vair, "FullAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#GeneralAI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Type of AI system that addresses a broad range of tasks with a satisfactory level of performance."</para>
    /// labels<para>"General AI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#GeneralAI">https://w3id.org/vair#GeneralAI</seealso>
    let GeneralAI = Prefixed_Name(vair, "GeneralAI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GeneratingAudioContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Generation or manipulation of audio content"</para>
    /// labels<para>"Generating Audio Content"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GeneratingAudioContent">https://w3id.org/vair#GeneratingAudioContent</seealso>
    let GeneratingAudioContent =
        Prefixed_Name(vair, "GeneratingAudioContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GeneratingImageContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Generation or manipulation of image content"</para>
    /// labels<para>"Generating Image Content"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GeneratingImageContent">https://w3id.org/vair#GeneratingImageContent</seealso>
    let GeneratingImageContent =
        Prefixed_Name(vair, "GeneratingImageContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GeneratingVideoContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Generation or manipulation of video content"</para>
    /// labels<para>"Generating Video Content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#GeneratingVideoContent">https://w3id.org/vair#GeneratingVideoContent</seealso>
    let GeneratingVideoContent =
        Prefixed_Name(vair, "GeneratingVideoContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GeneticAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Algorithm which simulates natural selection by creating and evolving a population of individuals (solutions) for optimization problems"</para>
    /// labels<para>"Genetic Algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GeneticAlgorithm">https://w3id.org/vair#GeneticAlgorithm</seealso>
    let GeneticAlgorithm = Prefixed_Name(vair, "GeneticAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#GestureRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"The capability of AI system to recognise human gestures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gesture Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GestureRecognition">https://w3id.org/vair#GestureRecognition</seealso>
    let GestureRecognition = Prefixed_Name(vair, "GestureRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GrantingHealthCareServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Granting natural persons healthcare services"</para>
    /// labels<para>"Granting Health Care Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GrantingHealthCareServices">https://w3id.org/vair#GrantingHealthCareServices</seealso>
    let GrantingHealthCareServices =
        Prefixed_Name(vair, "GrantingHealthCareServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GrantingPublicAssistanceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#GrantingPublicAssistanceService">https://w3id.org/vair#GrantingPublicAssistanceService</seealso>
    let GrantingPublicAssistanceService =
        Prefixed_Name(vair, "GrantingPublicAssistanceService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#GrantingPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Granting natural persons essential public assistance benefits and services"</para>
    /// labels<para>"Granting Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#GrantingPublicAssistanceServices">https://w3id.org/vair#GrantingPublicAssistanceServices</seealso>
    let GrantingPublicAssistanceServices =
        Prefixed_Name(vair, "GrantingPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A group of persons such as citizens, marginsalised groups, etc."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Group">https://w3id.org/vair#Group</seealso>
    let Group = Prefixed_Name(vair, "Group") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Physical equipment/components"</para>
    /// labels<para>"Hardware"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Hardware">https://w3id.org/vair#Hardware</seealso>
    let Hardware = Prefixed_Name(vair, "Hardware") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to an individuals' health."</para>
    /// labels<para>"Health"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Health">https://w3id.org/vair#Health</seealso>
    let Health = Prefixed_Name(vair, "Health") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#HealthInsurancePricing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Pricing in relation to natural persons in the case of health insurance"</para>
    /// labels<para>"Health Insurance Pricing"</para></remarks>
    /// <seealso href="https://w3id.org/vair#HealthInsurancePricing">https://w3id.org/vair#HealthInsurancePricing</seealso>
    let HealthInsurancePricing =
        Prefixed_Name(vair, "HealthInsurancePricing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#HealthInsuranceRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk assessment in relation to natural persons in the case of health insurance"</para>
    /// labels<para>"Health Insurance Risk Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#HealthInsuranceRiskAssessment">https://w3id.org/vair#HealthInsuranceRiskAssessment</seealso>
    let HealthInsuranceRiskAssessment =
        Prefixed_Name(vair, "HealthInsuranceRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#HighAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"The level of automation where there the system performs parts of its mission without external intervention."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"High Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#HighAutomation">https://w3id.org/vair#HighAutomation</seealso>
    let HighAutomation = Prefixed_Name(vair, "HighAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#HumanBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#HumanBehaviour">https://w3id.org/vair#HumanBehaviour</seealso>
    let HumanBehaviour = Prefixed_Name(vair, "HumanBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#HumanOversightMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Overseening the system by natural persons to detect, prevent or minimise risk."</para>
    /// labels<para>"Human Oversight Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#HumanOversightMeasure">https://w3id.org/vair#HumanOversightMeasure</seealso>
    let HumanOversightMeasure =
        Prefixed_Name(vair, "HumanOversightMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IEC31010-2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk management — Risk assessment techniques"</para>
    /// labels<para>"IEC 31010:2019"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IEC31010-2019">https://w3id.org/vair#IEC31010-2019</seealso>
    let IEC31010_2019 = Prefixed_Name(vair, "IEC31010-2019") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISO10013-2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Quality management systems — Guidance for documented information"</para>
    /// labels<para>"ISO 10013:2021"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISO10013-2021">https://w3id.org/vair#ISO10013-2021</seealso>
    let ISO10013_2021 = Prefixed_Name(vair, "ISO10013-2021") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISO31000-2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk management — Guidelines"</para>
    /// labels<para>"ISO 31000:2018"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISO31000-2018">https://w3id.org/vair#ISO31000-2018</seealso>
    let ISO31000_2018 = Prefixed_Name(vair, "ISO31000-2018") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISO31073_2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"ISO 31073:2022 Risk management — Vocabulary"</para>
    /// labels<para>"ISO 31073:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISO31073_2022">https://w3id.org/vair#ISO31073_2022</seealso>
    let ISO31073_2022 = Prefixed_Name(vair, "ISO31073_2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISO9001-2015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Quality management systems — Requirements"</para>
    /// labels<para>"ISO 9001:2015"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISO9001-2015">https://w3id.org/vair#ISO9001-2015</seealso>
    let ISO9001_2015 = Prefixed_Name(vair, "ISO9001-2015") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOGuide73-2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ISOGuide73-2009">https://w3id.org/vair#ISOGuide73-2009</seealso>
    let ISOGuide73_2009 = Prefixed_Name(vair, "ISOGuide73-2009") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC20546-2019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Information technology — Big data — Overview and vocabulary"</para>
    /// labels<para>"ISO/IEC 20546:2019"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC20546-2019">https://w3id.org/vair#ISOIEC20546-2019</seealso>
    let ISOIEC20546_2019 = Prefixed_Name(vair, "ISOIEC20546-2019") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC20547-3-2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information technology — Big data reference architecture — Part 3: Reference architecture"</para>
    /// labels<para>"ISO/IEC 20547-3:2020"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC20547-3-2020">https://w3id.org/vair#ISOIEC20547-3-2020</seealso>
    let ISOIEC20547_3_2020 = Prefixed_Name(vair, "ISOIEC20547-3-2020") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC22989-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Information technology — Artificial intelligence — Artificial intelligence concepts and terminology"</para>
    /// labels<para>"ISO/IEC 22989:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC22989-2022">https://w3id.org/vair#ISOIEC22989-2022</seealso>
    let ISOIEC22989_2022 = Prefixed_Name(vair, "ISOIEC22989-2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC23053-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Framework for Artificial Intelligence (AI) Systems Using Machine Learning (ML)"</para>
    /// labels<para>"ISO/IEC 23053:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC23053-2022">https://w3id.org/vair#ISOIEC23053-2022</seealso>
    let ISOIEC23053_2022 = Prefixed_Name(vair, "ISOIEC23053-2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC23894-2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information technology — Artificial intelligence — Guidance on risk management"</para>
    /// labels<para>"ISO/IEC 23894:2023"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC23894-2023">https://w3id.org/vair#ISOIEC23894-2023</seealso>
    let ``ISOIEC23894-2023`` = Prefixed_Name(vair, "ISOIEC23894-2023") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC23894_2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"ISO/IEC 23894:2023 Information technology — Artificial intelligence — Guidance on risk management"</para>
    /// labels<para>"ISO/IEC 23894:2023"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC23894_2023">https://w3id.org/vair#ISOIEC23894_2023</seealso>
    let ISOIEC23894_2023 = Prefixed_Name(vair, "ISOIEC23894_2023") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC24668-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Information technology — Artificial intelligence — Process management framework for big data analytics"</para>
    /// labels<para>"ISO/IEC 24668:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC24668-2022">https://w3id.org/vair#ISOIEC24668-2022</seealso>
    let ISOIEC24668_2022 = Prefixed_Name(vair, "ISOIEC24668-2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC38507-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information technology — Governance of IT — Governance implications of the use of artificial intelligence by organizations"</para>
    /// labels<para>"ISO/IEC 38507:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC38507-2022">https://w3id.org/vair#ISOIEC38507-2022</seealso>
    let ISOIEC38507_2022 = Prefixed_Name(vair, "ISOIEC38507-2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIEC42001_2023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"ISO/IEC 42001:2023 Information technology — Artificial intelligence — Management system"</para>
    /// labels<para>"ISO/IEC 42001:2023"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIEC42001_2023">https://w3id.org/vair#ISOIEC42001_2023</seealso>
    let ISOIEC42001_2023 = Prefixed_Name(vair, "ISOIEC42001_2023") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR20547-1-2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Information technology — Big data reference architecture — Part 1: Framework and application process"</para>
    /// labels<para>"ISO/IEC TR 20547-1:2020"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR20547-1-2020">https://w3id.org/vair#ISOIECTR20547-1-2020</seealso>
    let ISOIECTR20547_1_2020 =
        Prefixed_Name(vair, "ISOIECTR20547-1-2020") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR20547-2-2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Information technology — Big data reference architecture — Part 2: Use cases and derived requirements"</para>
    /// labels<para>"ISO/IEC TR 20547-2:2018"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR20547-2-2018">https://w3id.org/vair#ISOIECTR20547-2-2018</seealso>
    let ISOIECTR20547_2_2018 =
        Prefixed_Name(vair, "ISOIECTR20547-2-2018") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR20547-5-2018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Information technology — Big data reference architecture — Part 5: Standards roadmap"</para>
    /// labels<para>"ISO/IEC TR 20547-5:2018"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR20547-5-2018">https://w3id.org/vair#ISOIECTR20547-5-2018</seealso>
    let ISOIECTR20547_5_2018 =
        Prefixed_Name(vair, "ISOIECTR20547-5-2018") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24027-2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Information technology — Artificial intelligence (AI) — Bias in AI systems and AI aided decision making"</para>
    /// labels<para>"ISO/IEC TR 24027:2021"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24027-2021">https://w3id.org/vair#ISOIECTR24027-2021</seealso>
    let ISOIECTR24027_2021 = Prefixed_Name(vair, "ISOIECTR24027-2021") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24028-2020</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"v"</para>
    /// labels<para>"ISO/IEC TR 24028:2020"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24028-2020">https://w3id.org/vair#ISOIECTR24028-2020</seealso>
    let ISOIECTR24028_2020 = Prefixed_Name(vair, "ISOIECTR24028-2020") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24029-1-2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Artificial Intelligence (AI) — Assessment of the robustness of neural networks — Part 1: Overview"</para>
    /// labels<para>"ISO/IEC TR 24029-1:2021"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24029-1-2021">https://w3id.org/vair#ISOIECTR24029-1-2021</seealso>
    let ISOIECTR24029_1_2021 =
        Prefixed_Name(vair, "ISOIECTR24029-1-2021") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24030-2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information technology — Artificial intelligence (AI) — Use cases"</para>
    /// labels<para>"ISO/IEC TR 24030:2021"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24030-2021">https://w3id.org/vair#ISOIECTR24030-2021</seealso>
    let ISOIECTR24030_2021 = Prefixed_Name(vair, "ISOIECTR24030-2021") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24368-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information technology — Artificial intelligence — Overview of ethical and societal concerns"</para>
    /// labels<para>"ISO/IEC TR 24368:2022"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24368-2022">https://w3id.org/vair#ISOIECTR24368-2022</seealso>
    let ISOIECTR24368_2022 = Prefixed_Name(vair, "ISOIECTR24368-2022") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIECTR24372-2021</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Information technology — Artificial intelligence (AI) — Overview of computational approaches for AI systems"</para>
    /// labels<para>"ISO/IEC TR 24372:2021"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTR24372-2021">https://w3id.org/vair#ISOIECTR24372-2021</seealso>
    let ISOIECTR24372_2021 = Prefixed_Name(vair, "ISOIECTR24372-2021") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ISOIECTS4213-2022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Information technology — Artificial intelligence — Assessment of machine learning classification performance"</para>
    /// labels<para>"ISO/IEC TS 4213:2022"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#ISOIECTS4213-2022">https://w3id.org/vair#ISOIECTS4213-2022</seealso>
    let ISOIECTS4213_2022 = Prefixed_Name(vair, "ISOIECTS4213-2022") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IdentiftyingIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Identifying natural persons"</para>
    /// labels<para>"Identiftying Individuals"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IdentiftyingIndividuals">https://w3id.org/vair#IdentiftyingIndividuals</seealso>
    let IdentiftyingIndividuals =
        Prefixed_Name(vair, "IdentiftyingIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ImageRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Image classification process that classifies object(s), pattern(s) or concept(s) in an image."</para>
    /// labels<para>"Image Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ImageRecognition">https://w3id.org/vair#ImageRecognition</seealso>
    let ImageRecognition = Prefixed_Name(vair, "ImageRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Importer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Importer">https://w3id.org/vair#Importer</seealso>
    let Importer = Prefixed_Name(vair, "Importer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InaccurateDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Inaccurate decision generated by the system."</para>
    /// labels<para>"Inaccurate Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#InaccurateDecision">https://w3id.org/vair#InaccurateDecision</seealso>
    let InaccurateDecision = Prefixed_Name(vair, "InaccurateDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InaccuratePrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Inaccurate prediction generated by the system."</para>
    /// labels<para>"Inaccurate Prediction"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InaccuratePrediction">https://w3id.org/vair#InaccuratePrediction</seealso>
    let InaccuratePrediction =
        Prefixed_Name(vair, "InaccuratePrediction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InaccurateRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Inaccurate recommendation generated by the system."</para>
    /// labels<para>"Inaccurate Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InaccurateRecommendation">https://w3id.org/vair#InaccurateRecommendation</seealso>
    let InaccurateRecommendation =
        Prefixed_Name(vair, "InaccurateRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Inception</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Inception occurs when one or more stakeholders decides to turn an idea into a tangible system"</para>
    /// labels<para>"Inception"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Inception">https://w3id.org/vair#Inception</seealso>
    let Inception = Prefixed_Name(vair, "Inception") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#IncompleteTestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Incompleteness of testing data set"</para>
    /// labels<para>"Incomplete Test Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IncompleteTestData">https://w3id.org/vair#IncompleteTestData</seealso>
    let IncompleteTestData = Prefixed_Name(vair, "IncompleteTestData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IncompleteTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Incompleteness of training data set"</para>
    /// labels<para>"Incomplete Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IncompleteTrainingData">https://w3id.org/vair#IncompleteTrainingData</seealso>
    let IncompleteTrainingData =
        Prefixed_Name(vair, "IncompleteTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IncompleteValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Incompleteness of validation data set"</para>
    /// labels<para>"Incomplete Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IncompleteValidationData">https://w3id.org/vair#IncompleteValidationData</seealso>
    let IncompleteValidationData =
        Prefixed_Name(vair, "IncompleteValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IndividualEnteredState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A person who has entered into the territory of a State"</para>
    /// labels<para>"Individual Entered State"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IndividualEnteredState">https://w3id.org/vair#IndividualEnteredState</seealso>
    let IndividualEnteredState =
        Prefixed_Name(vair, "IndividualEnteredState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IndividualIntendsToEnterState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person who intends to enter into the territory of a State"</para>
    /// labels<para>"Individual Intends To Enter State"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IndividualIntendsToEnterState">https://w3id.org/vair#IndividualIntendsToEnterState</seealso>
    let IndividualIntendsToEnterState =
        Prefixed_Name(vair, "IndividualIntendsToEnterState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IndividualRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Assessing the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences"</para>
    /// labels<para>"Individual Risk Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IndividualRiskAssessment">https://w3id.org/vair#IndividualRiskAssessment</seealso>
    let IndividualRiskAssessment =
        Prefixed_Name(vair, "IndividualRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InductiveProgramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Tthe inference of an algorithm or program featuring recursive calls or repetition control structures"</para>
    /// labels<para>"Inductive Programming"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InductiveProgramming">https://w3id.org/vair#InductiveProgramming</seealso>
    let InductiveProgramming =
        Prefixed_Name(vair, "InductiveProgramming") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IndustrialRobot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A robot for use in industrial automation applications."</para>
    /// labels<para>"Industrial Robot"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IndustrialRobot">https://w3id.org/vair#IndustrialRobot</seealso>
    let IndustrialRobot = Prefixed_Name(vair, "IndustrialRobot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Inference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Inference">https://w3id.org/vair#Inference</seealso>
    let Inference = Prefixed_Name(vair, "Inference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Influencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purpose of influencing"</para>
    /// labels<para>"Influencing"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Influencing">https://w3id.org/vair#Influencing</seealso>
    let Influencing = Prefixed_Name(vair, "Influencing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InfluencingElectionOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Influencing the outcome of an election."</para>
    /// labels<para>"Influencing Election Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InfluencingElectionOutcome">https://w3id.org/vair#InfluencingElectionOutcome</seealso>
    let InfluencingElectionOutcome =
        Prefixed_Name(vair, "InfluencingElectionOutcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InfluencingReferendumOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Influencing the outcome of a referendum."</para>
    /// labels<para>"Influencing Referendum Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InfluencingReferendumOutcome">https://w3id.org/vair#InfluencingReferendumOutcome</seealso>
    let InfluencingReferendumOutcome =
        Prefixed_Name(vair, "InfluencingReferendumOutcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InfluencingVotingBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of influencing voting behaviour of people"</para>
    /// labels<para>"Influencing Voting Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InfluencingVotingBehaviour">https://w3id.org/vair#InfluencingVotingBehaviour</seealso>
    let InfluencingVotingBehaviour =
        Prefixed_Name(vair, "InfluencingVotingBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InformationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used."</para>
    /// labels<para>"Information Provision"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InformationProvision">https://w3id.org/vair#InformationProvision</seealso>
    let InformationProvision =
        Prefixed_Name(vair, "InformationProvision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Retrieving relevant documents or parts of documents from a dataset, typically based on keyword or natural language queries."</para>
    /// labels<para>"Information Retrieval"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InformationRetrieval">https://w3id.org/vair#InformationRetrieval</seealso>
    let InformationRetrieval =
        Prefixed_Name(vair, "InformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InformedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents that a specific actor was informed that an AI system is in place."</para>
    /// labels<para>"Informed Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InformedInvolvement">https://w3id.org/vair#InformedInvolvement</seealso>
    let InformedInvolvement = Prefixed_Name(vair, "InformedInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InputData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#InputData">https://w3id.org/vair#InputData</seealso>
    let InputData = Prefixed_Name(vair, "InputData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InputDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk sources related to input data"</para>
    /// labels<para>"Input Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InputDataRiskSource">https://w3id.org/vair#InputDataRiskSource</seealso>
    let InputDataRiskSource = Prefixed_Name(vair, "InputDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InstallationInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Instruction for installing an application."</para>
    /// labels<para>"Installation Instruction"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InstallationInstruction">https://w3id.org/vair#InstallationInstruction</seealso>
    let InstallationInstruction =
        Prefixed_Name(vair, "InstallationInstruction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InstructionForUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The information provided by the provider to inform the deployer of, in particular, an AI system’s intended purpose and proper use."</para>
    /// labels<para>"Instruction For Use"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InstructionForUse">https://w3id.org/vair#InstructionForUse</seealso>
    let InstructionForUse = Prefixed_Name(vair, "InstructionForUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InstructionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#InstructionOfUse">https://w3id.org/vair#InstructionOfUse</seealso>
    let InstructionOfUse = Prefixed_Name(vair, "InstructionOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InsufficientHumanOversightMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Lack of appropriate human oversight measures"</para>
    /// labels<para>"Insufficient Human Oversight Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InsufficientHumanOversightMeasure">https://w3id.org/vair#InsufficientHumanOversightMeasure</seealso>
    let InsufficientHumanOversightMeasure =
        Prefixed_Name(vair, "InsufficientHumanOversightMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InsufficientInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Lack of appropriate instruction for use"</para>
    /// labels<para>"Insufficient Instruction"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InsufficientInstruction">https://w3id.org/vair#InsufficientInstruction</seealso>
    let InsufficientInstruction =
        Prefixed_Name(vair, "InsufficientInstruction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IntelligentControlSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"An AI-based control system"</para>
    /// labels<para>"Intelligent Control System"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IntelligentControlSystem">https://w3id.org/vair#IntelligentControlSystem</seealso>
    let IntelligentControlSystem =
        Prefixed_Name(vair, "IntelligentControlSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IntendedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents involvement of a specific actor is as intended."</para>
    /// labels<para>"Intended Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IntendedInvolvement">https://w3id.org/vair#IntendedInvolvement</seealso>
    let IntendedInvolvement = Prefixed_Name(vair, "IntendedInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InterpretingFacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Interpreting facts"</para>
    /// labels<para>"Interpreting Facts"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InterpretingFacts">https://w3id.org/vair#InterpretingFacts</seealso>
    let InterpretingFacts = Prefixed_Name(vair, "InterpretingFacts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#InterpretingLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Interpreting the law"</para>
    /// labels<para>"Interpreting Law"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InterpretingLaw">https://w3id.org/vair#InterpretingLaw</seealso>
    let InterpretingLaw = Prefixed_Name(vair, "InterpretingLaw") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Interruption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Interrupting the system's operation"</para>
    /// labels<para>"Interruption"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Interruption">https://w3id.org/vair#Interruption</seealso>
    let Interruption = Prefixed_Name(vair, "Interruption") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Intervention of system's operation"</para>
    /// labels<para>"Intervention"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Intervention">https://w3id.org/vair#Intervention</seealso>
    let Intervention = Prefixed_Name(vair, "Intervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#InvestigatingCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Investigation of criminal offences"</para>
    /// labels<para>"Investigating Criminal Offences"</para></remarks>
    /// <seealso href="https://w3id.org/vair#InvestigatingCriminalOffences">https://w3id.org/vair#InvestigatingCriminalOffences</seealso>
    let InvestigatingCriminalOffences =
        Prefixed_Name(vair, "InvestigatingCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IoTSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A system providing functionalities of IoT."</para>
    /// labels<para>"IoT System"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IoTSystem">https://w3id.org/vair#IoTSystem</seealso>
    let IoTSystem = Prefixed_Name(vair, "IoTSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#IrrelevantTestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Use of irrelevant data for testing"</para>
    /// labels<para>"Irrelevant Test Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IrrelevantTestData">https://w3id.org/vair#IrrelevantTestData</seealso>
    let IrrelevantTestData = Prefixed_Name(vair, "IrrelevantTestData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IrrelevantTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Use of irrelevant data for training"</para>
    /// labels<para>"Irrelevant Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IrrelevantTrainingData">https://w3id.org/vair#IrrelevantTrainingData</seealso>
    let IrrelevantTrainingData =
        Prefixed_Name(vair, "IrrelevantTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#IrrelevantValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Use of irrelevant data for validation"</para>
    /// labels<para>"Irrelevant Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#IrrelevantValidationData">https://w3id.org/vair#IrrelevantValidationData</seealso>
    let IrrelevantValidationData =
        Prefixed_Name(vair, "IrrelevantValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A person who has made an application for employment"</para>
    /// labels<para>"Job Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobApplicant">https://w3id.org/vair#JobApplicant</seealso>
    let JobApplicant = Prefixed_Name(vair, "JobApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobApplicationAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Analysis of job applications"</para>
    /// labels<para>"Job Application Analysis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobApplicationAnalysis">https://w3id.org/vair#JobApplicationAnalysis</seealso>
    let JobApplicationAnalysis =
        Prefixed_Name(vair, "JobApplicationAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobApplicationFiltering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Filtering applications for recruitment or selection of natural persons"</para>
    /// labels<para>"Job Application Filtering"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobApplicationFiltering">https://w3id.org/vair#JobApplicationFiltering</seealso>
    let JobApplicationFiltering =
        Prefixed_Name(vair, "JobApplicationFiltering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobApplicationScreening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Screening job applications"</para>
    /// labels<para>"Job Application Screening"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobApplicationScreening">https://w3id.org/vair#JobApplicationScreening</seealso>
    let JobApplicationScreening =
        Prefixed_Name(vair, "JobApplicationScreening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobCandidate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A person who is considered for employment."</para>
    /// labels<para>"Job Candidate"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobCandidate">https://w3id.org/vair#JobCandidate</seealso>
    let JobCandidate = Prefixed_Name(vair, "JobCandidate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JobCandidateSelection</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Selecting people for a job for a position "</para>
    /// labels<para>"Job Candidate Selection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JobCandidateSelection">https://w3id.org/vair#JobCandidateSelection</seealso>
    let JobCandidateSelection =
        Prefixed_Name(vair, "JobCandidateSelection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JudicialAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An authority to administer justice"</para>
    /// labels<para>"Judicial Authority"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JudicialAuthority">https://w3id.org/vair#JudicialAuthority</seealso>
    let JudicialAuthority = Prefixed_Name(vair, "JudicialAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#JudicialAuthorityAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that acts on behalf on judicial authorities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Judicial Authority Agent"</para></remarks>
    /// <seealso href="https://w3id.org/vair#JudicialAuthorityAgent">https://w3id.org/vair#JudicialAuthorityAgent</seealso>
    let JudicialAuthorityAgent =
        Prefixed_Name(vair, "JudicialAuthorityAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#KnowledgeBasedTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Techniques based on the use of knowledge bases"</para>
    /// labels<para>"Knowledge Based Technique"</para></remarks>
    /// <seealso href="https://w3id.org/vair#KnowledgeBasedTechnique">https://w3id.org/vair#KnowledgeBasedTechnique</seealso>
    let KnowledgeBasedTechnique =
        Prefixed_Name(vair, "KnowledgeBasedTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#KnowledgeReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Capturing knowledge and acquiring new knowledge"</para>
    /// labels<para>"Knowledge Reasoning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#KnowledgeReasoning">https://w3id.org/vair#KnowledgeReasoning</seealso>
    let KnowledgeReasoning = Prefixed_Name(vair, "KnowledgeReasoning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#KnowledgeRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Encoding knowledge in a formal language"</para>
    /// labels<para>"Knowledge Representation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#KnowledgeRepresentation">https://w3id.org/vair#KnowledgeRepresentation</seealso>
    let KnowledgeRepresentation =
        Prefixed_Name(vair, "KnowledgeRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LackOfTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to lack transparency regarding AI, its development, deployement, or use"</para>
    /// labels<para>"Lack Of Transparency"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LackOfTransparency">https://w3id.org/vair#LackOfTransparency</seealso>
    let LackOfTransparency = Prefixed_Name(vair, "LackOfTransparency") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Law</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#Law">https://w3id.org/vair#Law</seealso>
    let Law = Prefixed_Name(vair, "Law") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LawEnforcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activities related to enforcing the law."</para>
    /// labels<para>"Law Enforcement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LawEnforcement">https://w3id.org/vair#LawEnforcement</seealso>
    let LawEnforcement = Prefixed_Name(vair, "LawEnforcement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LawEnforcementAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Law enforcement authority means:
    /// (a) any public authority competent for the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security; or
    /// (b) any other body or entity entrusted by Member State law to exercise public authority and public powers for the purposes of the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security."</para>
    /// labels<para>"Law Enforcement Authority"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LawEnforcementAuthority">https://w3id.org/vair#LawEnforcementAuthority</seealso>
    let LawEnforcementAuthority =
        Prefixed_Name(vair, "LawEnforcementAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LawEnforcementAuthorityAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An entity that acts on behalf of law enforcement authorities."</para>
    /// labels<para>"Law Enforcement Authority Agent"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LawEnforcementAuthorityAgent">https://w3id.org/vair#LawEnforcementAuthorityAgent</seealso>
    let LawEnforcementAuthorityAgent =
        Prefixed_Name(vair, "LawEnforcementAuthorityAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LawEnforcemnet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#LawEnforcemnet">https://w3id.org/vair#LawEnforcemnet</seealso>
    let LawEnforcemnet = Prefixed_Name(vair, "LawEnforcemnet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LearningTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#LearningTechnique">https://w3id.org/vair#LearningTechnique</seealso>
    let LearningTechnique = Prefixed_Name(vair, "LearningTechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of pre-written code"</para>
    /// labels<para>"Library"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Library">https://w3id.org/vair#Library</seealso>
    let Library = Prefixed_Name(vair, "Library") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LieDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Detecting lies"</para>
    /// labels<para>"Lie Detection"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LieDetection">https://w3id.org/vair#LieDetection</seealso>
    let LieDetection = Prefixed_Name(vair, "LieDetection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LifeInsurancePricing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Pricing in relation to natural persons in the case of life insurance"</para>
    /// labels<para>"Life Insurance Pricing"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LifeInsurancePricing">https://w3id.org/vair#LifeInsurancePricing</seealso>
    let LifeInsurancePricing =
        Prefixed_Name(vair, "LifeInsurancePricing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LifeInsuranceRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk assessment in relation to natural persons in the case of life insurance"</para>
    /// labels<para>"Life Insurance Risk Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LifeInsuranceRiskAssessment">https://w3id.org/vair#LifeInsuranceRiskAssessment</seealso>
    let LifeInsuranceRiskAssessment =
        Prefixed_Name(vair, "LifeInsuranceRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#LoggingMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to logging measure in place "</para>
    /// labels<para>"Logging Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LoggingMeasure">https://w3id.org/vair#LoggingMeasure</seealso>
    let LoggingMeasure = Prefixed_Name(vair, "LoggingMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LogicBasedTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to logic based techniques."</para>
    /// labels<para>"Logic Based Technique"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LogicBasedTechnique">https://w3id.org/vair#LogicBasedTechnique</seealso>
    let LogicBasedTechnique = Prefixed_Name(vair, "LogicBasedTechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LongShortTermMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"type of recurrent neural network that processes sequential data with a satisfactory performance for both long and short span dependencies."</para>
    /// labels<para>"Long ShortTerm Memory"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LongShortTermMemory">https://w3id.org/vair#LongShortTermMemory</seealso>
    let LongShortTermMemory = Prefixed_Name(vair, "LongShortTermMemory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LowAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inacurracy of the predictions, recommondations, or decisions produced by the system."</para>
    /// labels<para>"Low Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LowAccuracy">https://w3id.org/vair#LowAccuracy</seealso>
    let LowAccuracy = Prefixed_Name(vair, "LowAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LowRobustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Lack of appropriate level of robustness"</para>
    /// labels<para>"Low Robustness"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LowRobustness">https://w3id.org/vair#LowRobustness</seealso>
    let LowRobustness = Prefixed_Name(vair, "LowRobustness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#LowSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Lack of appropriate level of security."</para>
    /// labels<para>"Low Security"</para></remarks>
    /// <seealso href="https://w3id.org/vair#LowSecurity">https://w3id.org/vair#LowSecurity</seealso>
    let LowSecurity = Prefixed_Name(vair, "LowSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#MachineLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Process of optimizing model parameters through computational techniques, such that the model's behaviour reflects the data or experience."</para>
    /// labels<para>"Machine Learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearning">https://w3id.org/vair#MachineLearning</seealso>
    let MachineLearning = Prefixed_Name(vair, "MachineLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An algorithm to determine parameters of a machine learning model from data according to given criteria."</para>
    /// labels<para>"Machine Learning Algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningAlgorithm">https://w3id.org/vair#MachineLearningAlgorithm</seealso>
    let MachineLearningAlgorithm =
        Prefixed_Name(vair, "MachineLearningAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningFramework">https://w3id.org/vair#MachineLearningFramework</seealso>
    let MachineLearningFramework =
        Prefixed_Name(vair, "MachineLearningFramework") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningLibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to liberaries for machine learning"</para>
    /// labels<para>"Machine Learning Library"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningLibrary">https://w3id.org/vair#MachineLearningLibrary</seealso>
    let MachineLearningLibrary =
        Prefixed_Name(vair, "MachineLearningLibrary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Mathematical construct that generates an inference or prediction  based on input data or information."</para>
    /// labels<para>"Machine Learning Model"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningModel">https://w3id.org/vair#MachineLearningModel</seealso>
    let MachineLearningModel =
        Prefixed_Name(vair, "MachineLearningModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Resource on which a ML model runs."</para>
    /// labels<para>"Machine Learning Platform"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningPlatform">https://w3id.org/vair#MachineLearningPlatform</seealso>
    let MachineLearningPlatform =
        Prefixed_Name(vair, "MachineLearningPlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineLearningTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#MachineLearningTechnique">https://w3id.org/vair#MachineLearningTechnique</seealso>
    let MachineLearningTechnique =
        Prefixed_Name(vair, "MachineLearningTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MachineTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Automated translation of text or speech from one natural language to another using a computer system."</para>
    /// labels<para>"Machine Translation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MachineTranslation">https://w3id.org/vair#MachineTranslation</seealso>
    let MachineTranslation = Prefixed_Name(vair, "MachineTranslation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MakingContractTerminationDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Making decisions on termination of work-related contractual relationship"</para>
    ///   <para>"Making Contract Termination Decision"</para>
    /// labels<para>"Making Contract Termination Decision"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MakingContractTerminationDecision">https://w3id.org/vair#MakingContractTerminationDecision</seealso>
    let MakingContractTerminationDecision =
        Prefixed_Name(vair, "MakingContractTerminationDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MakingDecisionOnTermsOfWorkRelatedRelations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Making decisions affecting terms of work-related relationships"</para>
    /// labels<para>"Making Decision On Terms Of Work-Related Relations"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MakingDecisionOnTermsOfWorkRelatedRelations">https://w3id.org/vair#MakingDecisionOnTermsOfWorkRelatedRelations</seealso>
    let MakingDecisionOnTermsOfWorkRelatedRelations =
        Prefixed_Name(vair, "MakingDecisionOnTermsOfWorkRelatedRelations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MakingPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#MakingPrediction">https://w3id.org/vair#MakingPrediction</seealso>
    let MakingPrediction = Prefixed_Name(vair, "MakingPrediction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MakingPromotionDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Making decisions on promotion"</para>
    /// labels<para>"Making Promotion Decision"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MakingPromotionDecision">https://w3id.org/vair#MakingPromotionDecision</seealso>
    let MakingPromotionDecision =
        Prefixed_Name(vair, "MakingPromotionDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagementAndOperationOfSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagementAndOperationOfSafety">https://w3id.org/vair#ManagementAndOperationOfSafety</seealso>
    let ManagementAndOperationOfSafety =
        Prefixed_Name(vair, "ManagementAndOperationOfSafety") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Managing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Managing">https://w3id.org/vair#Managing</seealso>
    let Managing = Prefixed_Name(vair, "Managing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingCriticalDigitalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingCriticalDigitalInfrastructure">https://w3id.org/vair#ManagingCriticalDigitalInfrastructure</seealso>
    let ManagingCriticalDigitalInfrastructure =
        Prefixed_Name(vair, "ManagingCriticalDigitalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingRoadTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingRoadTraffic">https://w3id.org/vair#ManagingRoadTraffic</seealso>
    let ManagingRoadTraffic = Prefixed_Name(vair, "ManagingRoadTraffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingSupplyOfElectricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingSupplyOfElectricity">https://w3id.org/vair#ManagingSupplyOfElectricity</seealso>
    let ManagingSupplyOfElectricity =
        Prefixed_Name(vair, "ManagingSupplyOfElectricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingSupplyOfGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingSupplyOfGas">https://w3id.org/vair#ManagingSupplyOfGas</seealso>
    let ManagingSupplyOfGas = Prefixed_Name(vair, "ManagingSupplyOfGas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingSupplyOfHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingSupplyOfHeating">https://w3id.org/vair#ManagingSupplyOfHeating</seealso>
    let ManagingSupplyOfHeating =
        Prefixed_Name(vair, "ManagingSupplyOfHeating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManagingSupplyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ManagingSupplyOfWater">https://w3id.org/vair#ManagingSupplyOfWater</seealso>
    let ManagingSupplyOfWater =
        Prefixed_Name(vair, "ManagingSupplyOfWater") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ManualControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Controls implemented manually by human actors"</para>
    /// labels<para>"Manual Control"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ManualControl">https://w3id.org/vair#ManualControl</seealso>
    let ManualControl = Prefixed_Name(vair, "ManualControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MarketSurveillanceAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#MarketSurveillanceAuthority">https://w3id.org/vair#MarketSurveillanceAuthority</seealso>
    let MarketSurveillanceAuthority =
        Prefixed_Name(vair, "MarketSurveillanceAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MedicalAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#MedicalAid">https://w3id.org/vair#MedicalAid</seealso>
    let MedicalAid = Prefixed_Name(vair, "MedicalAid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#MedicalAidProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Entity that provides medical aid"</para>
    /// labels<para>"Medical Aid Provider"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MedicalAidProvider">https://w3id.org/vair#MedicalAidProvider</seealso>
    let MedicalAidProvider = Prefixed_Name(vair, "MedicalAidProvider") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#MigrationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Activities related to managing migration."</para>
    /// labels<para>"Migration Management"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MigrationManagement">https://w3id.org/vair#MigrationManagement</seealso>
    let MigrationManagement = Prefixed_Name(vair, "MigrationManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#MitigationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Control that is applied for mitigation purposes, e.g. ,mitigating risk sources, impacts, etc."</para>
    /// labels<para>"Mitigation Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MitigationMeasure">https://w3id.org/vair#MitigationMeasure</seealso>
    let MitigationMeasure = Prefixed_Name(vair, "MitigationMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"physical, mathematical or otherwise logical representation of a system, entity, phenomenon, process or data. "</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Model">https://w3id.org/vair#Model</seealso>
    let Model = Prefixed_Name(vair, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ModelCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"A form of model documentation"</para>
    /// labels<para>"Model Card"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ModelCard">https://w3id.org/vair#ModelCard</seealso>
    let ModelCard = Prefixed_Name(vair, "ModelCard") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ModelEvasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"An input, which seems normal for a human but is wrongly classified by ML models."</para>
    /// labels<para>"Model Evasion"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ModelEvasion">https://w3id.org/vair#ModelEvasion</seealso>
    let ModelEvasion = Prefixed_Name(vair, "ModelEvasion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ModelInversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A type of attack to AI models, in which the access to a model is abused to infer information about the training data."</para>
    /// labels<para>"Model Inversion"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ModelInversion">https://w3id.org/vair#ModelInversion</seealso>
    let ModelInversion = Prefixed_Name(vair, "ModelInversion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ModelRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Risk sources related to the AI model"</para>
    /// labels<para>"Model Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ModelRiskSource">https://w3id.org/vair#ModelRiskSource</seealso>
    let ModelRiskSource = Prefixed_Name(vair, "ModelRiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ModelTraning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#ModelTraning">https://w3id.org/vair#ModelTraning</seealso>
    let ModelTraning = Prefixed_Name(vair, "ModelTraning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Monitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Observing and keeping track of something"</para>
    /// labels<para>"Monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Monitoring">https://w3id.org/vair#Monitoring</seealso>
    let Monitoring = Prefixed_Name(vair, "Monitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MonitoringEmployeeBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Monitoring the behaviour of persons in work-related relationships."</para>
    /// labels<para>"Monitoring Employee Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MonitoringEmployeeBehaviour">https://w3id.org/vair#MonitoringEmployeeBehaviour</seealso>
    let MonitoringEmployeeBehaviour =
        Prefixed_Name(vair, "MonitoringEmployeeBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MonitoringEmployeePerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Monitoring the performance of persons in work-related relationships"</para>
    /// labels<para>"Monitoring Employee Performance"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MonitoringEmployeePerformance">https://w3id.org/vair#MonitoringEmployeePerformance</seealso>
    let MonitoringEmployeePerformance =
        Prefixed_Name(vair, "MonitoringEmployeePerformance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MonitoringMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to monitoring measures "</para>
    /// labels<para>"Monitoring Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MonitoringMeasure">https://w3id.org/vair#MonitoringMeasure</seealso>
    let MonitoringMeasure = Prefixed_Name(vair, "MonitoringMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MonitoringProhibitedBehaviourDuringTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Monitoring prohibited behaviour during tests"</para>
    /// labels<para>"Monitoring Prohibited Behaviour During Test"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MonitoringProhibitedBehaviourDuringTest">https://w3id.org/vair#MonitoringProhibitedBehaviourDuringTest</seealso>
    let MonitoringProhibitedBehaviourDuringTest =
        Prefixed_Name(vair, "MonitoringProhibitedBehaviourDuringTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MultiAgentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A system consisting of multiple AI agents."</para>
    /// labels<para>"AI Watch, Defining Artificial Intelligence 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Multi Agent System"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MultiAgentSystem">https://w3id.org/vair#MultiAgentSystem</seealso>
    let MultiAgentSystem = Prefixed_Name(vair, "MultiAgentSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#MusicInformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Retrieving information from music."</para>
    /// labels<para>"Music Information Retrieval"</para></remarks>
    /// <seealso href="https://w3id.org/vair#MusicInformationRetrieval">https://w3id.org/vair#MusicInformationRetrieval</seealso>
    let MusicInformationRetrieval =
        Prefixed_Name(vair, "MusicInformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NamedEntityRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Recognizing and labelling the denotational names of entities and their categories for sequences of words in a stream of text or speech."</para>
    /// labels<para>"Named Entity Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NamedEntityRecognition">https://w3id.org/vair#NamedEntityRecognition</seealso>
    let NamedEntityRecognition =
        Prefixed_Name(vair, "NamedEntityRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NarrowAI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type of AI system that is focused on defined tasks to address a specific problem."</para>
    /// labels<para>"Narrow AI"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NarrowAI">https://w3id.org/vair#NarrowAI</seealso>
    let NarrowAI = Prefixed_Name(vair, "NarrowAI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NationalPublicAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#NationalPublicAuthority">https://w3id.org/vair#NationalPublicAuthority</seealso>
    let NationalPublicAuthority =
        Prefixed_Name(vair, "NationalPublicAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NaturalLanguageGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Converting data carrying semantics into natural language."</para>
    /// labels<para>"Natural Language Generation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NaturalLanguageGeneration">https://w3id.org/vair#NaturalLanguageGeneration</seealso>
    let NaturalLanguageGeneration =
        Prefixed_Name(vair, "NaturalLanguageGeneration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NaturalLanguageProcessingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Information processing based upon natural language understanding or natural language generation."</para>
    /// labels<para>"Natural Language Processing System"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NaturalLanguageProcessingSystem">https://w3id.org/vair#NaturalLanguageProcessingSystem</seealso>
    let NaturalLanguageProcessingSystem =
        Prefixed_Name(vair, "NaturalLanguageProcessingSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#NaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"An individual human being"</para>
    /// labels<para>"Natural Person"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NaturalPerson">https://w3id.org/vair#NaturalPerson</seealso>
    let NaturalPerson = Prefixed_Name(vair, "NaturalPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#NeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Network of one or more layers of neurons connected by weighted links with adjustable weights, which takes input data and produces an output."</para>
    /// labels<para>"Neural Network"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NeuralNetwork">https://w3id.org/vair#NeuralNetwork</seealso>
    let NeuralNetwork = Prefixed_Name(vair, "NeuralNetwork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#NoAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The level of automation where an operator fully controls the system"</para>
    /// labels<para>"No Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#NoAutomation">https://w3id.org/vair#NoAutomation</seealso>
    let NoAutomation = Prefixed_Name(vair, "NoAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#NotifiedBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#NotifiedBody">https://w3id.org/vair#NotifiedBody</seealso>
    let NotifiedBody = Prefixed_Name(vair, "NotifiedBody") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#NotifyingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#NotifyingAuthority">https://w3id.org/vair#NotifyingAuthority</seealso>
    let NotifyingAuthority = Prefixed_Name(vair, "NotifyingAuthority") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ObjectRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The capability to recognise objects"</para>
    /// labels<para>"Object Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ObjectRecognition">https://w3id.org/vair#ObjectRecognition</seealso>
    let ObjectRecognition = Prefixed_Name(vair, "ObjectRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Operating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Operating">https://w3id.org/vair#Operating</seealso>
    let Operating = Prefixed_Name(vair, "Operating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingCriticalDigitalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingCriticalDigitalInfrastructure">https://w3id.org/vair#OperatingCriticalDigitalInfrastructure</seealso>
    let OperatingCriticalDigitalInfrastructure =
        Prefixed_Name(vair, "OperatingCriticalDigitalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingRoadTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingRoadTraffic">https://w3id.org/vair#OperatingRoadTraffic</seealso>
    let OperatingRoadTraffic =
        Prefixed_Name(vair, "OperatingRoadTraffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingSupplyOfElectricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingSupplyOfElectricity">https://w3id.org/vair#OperatingSupplyOfElectricity</seealso>
    let OperatingSupplyOfElectricity =
        Prefixed_Name(vair, "OperatingSupplyOfElectricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingSupplyOfGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingSupplyOfGas">https://w3id.org/vair#OperatingSupplyOfGas</seealso>
    let OperatingSupplyOfGas =
        Prefixed_Name(vair, "OperatingSupplyOfGas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingSupplyOfHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingSupplyOfHeating">https://w3id.org/vair#OperatingSupplyOfHeating</seealso>
    let OperatingSupplyOfHeating =
        Prefixed_Name(vair, "OperatingSupplyOfHeating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OperatingSupplyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#OperatingSupplyOfWater">https://w3id.org/vair#OperatingSupplyOfWater</seealso>
    let OperatingSupplyOfWater =
        Prefixed_Name(vair, "OperatingSupplyOfWater") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to the operation stage when an AI system is running and generally available for use."</para>
    /// labels<para>"Operation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Operation">https://w3id.org/vair#Operation</seealso>
    let Operation = Prefixed_Name(vair, "Operation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#OperationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Control related to operation of the system."</para>
    /// labels<para>"Operational Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OperationalMeasure">https://w3id.org/vair#OperationalMeasure</seealso>
    let OperationalMeasure = Prefixed_Name(vair, "OperationalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#OptimisationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to optimisation Method"</para>
    /// labels<para>"Optimisation Method"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OptimisationMethod">https://w3id.org/vair#OptimisationMethod</seealso>
    let OptimisationMethod = Prefixed_Name(vair, "OptimisationMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#OpttingInOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A mode of controllability that stakeholders can opt in  the system’s output."</para>
    /// labels<para>"Optting In Output"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OpttingInOutput">https://w3id.org/vair#OpttingInOutput</seealso>
    let OpttingInOutput = Prefixed_Name(vair, "OpttingInOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#OpttingOutOfOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"A mode of controllability that stakeholders can opt out of the system’s output."</para>
    /// labels<para>"Optting Out Of Output"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OpttingOutOfOutput">https://w3id.org/vair#OpttingOutOfOutput</seealso>
    let OpttingOutOfOutput = Prefixed_Name(vair, "OpttingOutOfOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OrganisationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Organisational measures applied to control risk sources, risks, consequences, or impacts."</para>
    /// labels<para>"Organisational Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OrganisationalMeasure">https://w3id.org/vair#OrganisationalMeasure</seealso>
    let OrganisationalMeasure =
        Prefixed_Name(vair, "OrganisationalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#OrganisationalRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Risk sources related with the organisation developing, deploying, or using AI."</para>
    /// labels<para>"Organisational Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OrganisationalRiskSource">https://w3id.org/vair#OrganisationalRiskSource</seealso>
    let OrganisationalRiskSource =
        Prefixed_Name(vair, "OrganisationalRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Outcome</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair#Outcome">https://w3id.org/vair#Outcome</seealso>
    let Outcome = Prefixed_Name(vair, "Outcome") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Overreliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Tendency of automatically relying or over-relying on the output produced by an AI system"</para>
    /// labels<para>"Overreliance"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Overreliance">https://w3id.org/vair#Overreliance</seealso>
    let Overreliance = Prefixed_Name(vair, "Overreliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#OverridingOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Overriding outcome of a system."</para>
    /// labels<para>"Overriding Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/vair#OverridingOutcome">https://w3id.org/vair#OverridingOutcome</seealso>
    let OverridingOutcome = Prefixed_Name(vair, "OverridingOutcome") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PartOfSpeechTagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Assigning a category (e.g. verb, noun, adjective) to a word based on its grammatical properties."</para>
    /// labels<para>"Part Of Speech Tagging"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PartOfSpeechTagging">https://w3id.org/vair#PartOfSpeechTagging</seealso>
    let PartOfSpeechTagging = Prefixed_Name(vair, "PartOfSpeechTagging") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PartialAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The level of automation where some sub-functions of the system are fully automated while the system remains under the control of an external agent"</para>
    /// labels<para>"Partial Automation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PartialAutomation">https://w3id.org/vair#PartialAutomation</seealso>
    let PartialAutomation = Prefixed_Name(vair, "PartialAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Passenger</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Passenger">https://w3id.org/vair#Passenger</seealso>
    let Passenger = Prefixed_Name(vair, "Passenger") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PassiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Represents passive interactation with an AI system."</para>
    /// labels<para>"Passive Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PassiveInvolvement">https://w3id.org/vair#PassiveInvolvement</seealso>
    let PassiveInvolvement = Prefixed_Name(vair, "PassiveInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PatternRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PatternRecognition">https://w3id.org/vair#PatternRecognition</seealso>
    let PatternRecognition = Prefixed_Name(vair, "PatternRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PerfomanceRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Risk sources related to performance"</para>
    /// labels<para>"Perfomance Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PerfomanceRiskSource">https://w3id.org/vair#PerfomanceRiskSource</seealso>
    let PerfomanceRiskSource =
        Prefixed_Name(vair, "PerfomanceRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PerformingBackgroundCheck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Performing background checks"</para>
    /// labels<para>"Performing Background Check"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PerformingBackgroundCheck">https://w3id.org/vair#PerformingBackgroundCheck</seealso>
    let PerformingBackgroundCheck =
        Prefixed_Name(vair, "PerformingBackgroundCheck") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Perpetrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Perpetrator">https://w3id.org/vair#Perpetrator</seealso>
    let Perpetrator = Prefixed_Name(vair, "Perpetrator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PersonalData">https://w3id.org/vair#PersonalData</seealso>
    let PersonalData = Prefixed_Name(vair, "PersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PersonalityTraitsAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a system in determining and analysing people's personality traits"</para>
    /// labels<para>"Personality Traits Analysis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PersonalityTraitsAnalysis">https://w3id.org/vair#PersonalityTraitsAnalysis</seealso>
    let PersonalityTraitsAnalysis =
        Prefixed_Name(vair, "PersonalityTraitsAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PhysicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to physical health."</para>
    /// labels<para>"Physical Health"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PhysicalHealth">https://w3id.org/vair#PhysicalHealth</seealso>
    let PhysicalHealth = Prefixed_Name(vair, "PhysicalHealth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PhysicalInjury</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represent physical injuries caused by AI"</para>
    /// labels<para>"Physical Injury"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PhysicalInjury">https://w3id.org/vair#PhysicalInjury</seealso>
    let PhysicalInjury = Prefixed_Name(vair, "PhysicalInjury") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PlacingTargetedJobAdvert</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Placing targeted job advertisments"</para>
    /// labels<para>"Placing Targeted Job Advert"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PlacingTargetedJobAdvert">https://w3id.org/vair#PlacingTargetedJobAdvert</seealso>
    let PlacingTargetedJobAdvert =
        Prefixed_Name(vair, "PlacingTargetedJobAdvert") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Planning purposes"</para>
    /// labels<para>"Planning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Planning">https://w3id.org/vair#Planning</seealso>
    let Planning = Prefixed_Name(vair, "Planning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Platform">https://w3id.org/vair#Platform</seealso>
    let Platform = Prefixed_Name(vair, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Police</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Police"</para>
    /// labels<para>"Police"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Police">https://w3id.org/vair#Police</seealso>
    let Police = Prefixed_Name(vair, "Police") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PostMarketMonitoringPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Description of the post-market monitoring plan, as required by the AI Act."</para>
    /// labels<para>"Post-market Monitoring Plan"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PostMarketMonitoringPlan">https://w3id.org/vair#PostMarketMonitoringPlan</seealso>
    let PostMarketMonitoringPlan =
        Prefixed_Name(vair, "PostMarketMonitoringPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PostMarketMonitoringSystemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Description of the post-market monitoring system in place, as required by the AI Act."</para>
    /// labels<para>"Post-market Monitoring System Description"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PostMarketMonitoringSystemDescription">https://w3id.org/vair#PostMarketMonitoringSystemDescription</seealso>
    let PostMarketMonitoringSystemDescription =
        Prefixed_Name(vair, "PostMarketMonitoringSystemDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PotentialJobApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"A person who may have applied for employment."</para>
    /// labels<para>"Potential Job Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PotentialJobApplicant">https://w3id.org/vair#PotentialJobApplicant</seealso>
    let PotentialJobApplicant =
        Prefixed_Name(vair, "PotentialJobApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PotentialPublicServicesApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person who may have applied for public services."</para>
    /// labels<para>"Potential Public Services Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PotentialPublicServicesApplicant">https://w3id.org/vair#PotentialPublicServicesApplicant</seealso>
    let PotentialPublicServicesApplicant =
        Prefixed_Name(vair, "PotentialPublicServicesApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PreTrainedModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PreTrainedModel">https://w3id.org/vair#PreTrainedModel</seealso>
    let PreTrainedModel = Prefixed_Name(vair, "PreTrainedModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PredictingOccurrenceOfCriminalOffence</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PredictingOccurrenceOfCriminalOffence">https://w3id.org/vair#PredictingOccurrenceOfCriminalOffence</seealso>
    let PredictingOccurrenceOfCriminalOffence =
        Prefixed_Name(vair, "PredictingOccurrenceOfCriminalOffence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PredictingRecidivism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PredictingRecidivism">https://w3id.org/vair#PredictingRecidivism</seealso>
    let PredictingRecidivism =
        Prefixed_Name(vair, "PredictingRecidivism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PredictingReoccurrenceOfCriminalOffence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PredictingReoccurrenceOfCriminalOffence">https://w3id.org/vair#PredictingReoccurrenceOfCriminalOffence</seealso>
    let PredictingReoccurrenceOfCriminalOffence =
        Prefixed_Name(vair, "PredictingReoccurrenceOfCriminalOffence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Prediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Primary output of an AI system when provided with input data or information."</para>
    /// labels<para>"Prediction"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Prediction">https://w3id.org/vair#Prediction</seealso>
    let Prediction = Prefixed_Name(vair, "Prediction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Principle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Principle">https://w3id.org/vair#Principle</seealso>
    let Principle = Prefixed_Name(vair, "Principle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PrioritisationOfEmergencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid"</para>
    /// labels<para>"Prioritisation Of Emergency Service"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PrioritisationOfEmergencyService">https://w3id.org/vair#PrioritisationOfEmergencyService</seealso>
    let PrioritisationOfEmergencyService =
        Prefixed_Name(vair, "PrioritisationOfEmergencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PrivateService</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Business of supplying a service by a private body."</para>
    /// labels<para>"Private Service"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PrivateService">https://w3id.org/vair#PrivateService</seealso>
    let PrivateService = Prefixed_Name(vair, "PrivateService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ProducingRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Producing meaningful recommendations to users of the system"</para>
    /// labels<para>"Producing Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ProducingRecommendation">https://w3id.org/vair#ProducingRecommendation</seealso>
    let ProducingRecommendation =
        Prefixed_Name(vair, "ProducingRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to physical products."</para>
    /// labels<para>"Product"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Product">https://w3id.org/vair#Product</seealso>
    let Product = Prefixed_Name(vair, "Product") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ProductManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ProductManufacturer">https://w3id.org/vair#ProductManufacturer</seealso>
    let ProductManufacturer = Prefixed_Name(vair, "ProductManufacturer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ProductionData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ProductionData">https://w3id.org/vair#ProductionData</seealso>
    let ProductionData = Prefixed_Name(vair, "ProductionData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Profiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Any form of automated processing of personal data consisting of the use of personal data to evaluate certain personal aspects relating to a natural person, in particular to analyse or predict aspects concerning that natural person’s performance at work, economic situation, health, personal preferences, interests, reliability, behaviour, location or movements."</para>
    /// labels<para>"Profiling"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Profiling">https://w3id.org/vair#Profiling</seealso>
    let Profiling = Prefixed_Name(vair, "Profiling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ProfilingPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ProfilingPeople">https://w3id.org/vair#ProfilingPeople</seealso>
    let ProfilingPeople = Prefixed_Name(vair, "ProfilingPeople") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ProsecutingCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Prosecution of criminal offences"</para>
    /// labels<para>"Prosecuting Criminal Offences"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ProsecutingCriminalOffences">https://w3id.org/vair#ProsecutingCriminalOffences</seealso>
    let ProsecutingCriminalOffences =
        Prefixed_Name(vair, "ProsecutingCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ProsecutionOfCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ProsecutionOfCriminalOffences">https://w3id.org/vair#ProsecutionOfCriminalOffences</seealso>
    let ProsecutionOfCriminalOffences =
        Prefixed_Name(vair, "ProsecutionOfCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PsychologicalHarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents negative impacts of AI on psychological health"</para>
    /// labels<para>"Psychological Harm"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PsychologicalHarm">https://w3id.org/vair#PsychologicalHarm</seealso>
    let PsychologicalHarm = Prefixed_Name(vair, "PsychologicalHarm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PsychologicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to psychological health."</para>
    /// labels<para>"Psychological Health"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PsychologicalHealth">https://w3id.org/vair#PsychologicalHealth</seealso>
    let PsychologicalHealth = Prefixed_Name(vair, "PsychologicalHealth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#PublicAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to public authorities and bodies."</para>
    /// labels<para>"Public Authority"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PublicAuthority">https://w3id.org/vair#PublicAuthority</seealso>
    let PublicAuthority = Prefixed_Name(vair, "PublicAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PublicAuthorityAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that acts on behalf of public authorities."</para>
    /// labels<para>"Public Authority Agent"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PublicAuthorityAgent">https://w3id.org/vair#PublicAuthorityAgent</seealso>
    let PublicAuthorityAgent =
        Prefixed_Name(vair, "PublicAuthorityAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PublicService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Business of supplying a commodity or a service by a govermental or public body."</para>
    /// labels<para>"Public Service"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PublicService">https://w3id.org/vair#PublicService</seealso>
    let PublicService = Prefixed_Name(vair, "PublicService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PublicServicesApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A person who has applied for public services and benefits"</para>
    /// labels<para>"Public Services Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PublicServicesApplicant">https://w3id.org/vair#PublicServicesApplicant</seealso>
    let PublicServicesApplicant =
        Prefixed_Name(vair, "PublicServicesApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PublicServicesRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Person who is recipient of public services and benefits"</para>
    /// labels<para>"Public Services Recipient"</para></remarks>
    /// <seealso href="https://w3id.org/vair#PublicServicesRecipient">https://w3id.org/vair#PublicServicesRecipient</seealso>
    let PublicServicesRecipient =
        Prefixed_Name(vair, "PublicServicesRecipient") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#PubliclyAccessibleSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#PubliclyAccessibleSpace">https://w3id.org/vair#PubliclyAccessibleSpace</seealso>
    let PubliclyAccessibleSpace =
        Prefixed_Name(vair, "PubliclyAccessibleSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#QuestionAnswering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Determining the most appropriate answer to a question provided in natural language."</para>
    /// labels<para>"Question Answering"</para></remarks>
    /// <seealso href="https://w3id.org/vair#QuestionAnswering">https://w3id.org/vair#QuestionAnswering</seealso>
    let QuestionAnswering = Prefixed_Name(vair, "QuestionAnswering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ReEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"After the operation and monitoring stage, based on the results of the work of the AI system, the need for a reassessment can arise."</para>
    /// labels<para>"Re-Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReEvaluation">https://w3id.org/vair#ReEvaluation</seealso>
    let ReEvaluation = Prefixed_Name(vair, "ReEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ReasoningTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to reasoning techniques."</para>
    /// labels<para>"Reasoning Technique"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReasoningTechnique">https://w3id.org/vair#ReasoningTechnique</seealso>
    let ReasoningTechnique = Prefixed_Name(vair, "ReasoningTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ReclaimingHealthCareServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Reclaiming natural persons healthcare services"</para>
    /// labels<para>"Reclaiming Health Care Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReclaimingHealthCareServices">https://w3id.org/vair#ReclaimingHealthCareServices</seealso>
    let ReclaimingHealthCareServices =
        Prefixed_Name(vair, "ReclaimingHealthCareServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ReclaimingPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Reclaiming essential public assistance benefits and services"</para>
    /// labels<para>"Reclaiming Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReclaimingPublicAssistanceServices">https://w3id.org/vair#ReclaimingPublicAssistanceServices</seealso>
    let ReclaimingPublicAssistanceServices =
        Prefixed_Name(vair, "ReclaimingPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RecognisingEmotions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Recognising emotions of a natural person"</para>
    /// labels<para>"Recognising Emotions"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RecognisingEmotions">https://w3id.org/vair#RecognisingEmotions</seealso>
    let RecognisingEmotions = Prefixed_Name(vair, "RecognisingEmotions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RecognisingIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Recognising natural persons "</para>
    /// labels<para>"Recognising Individuals"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RecognisingIndividuals">https://w3id.org/vair#RecognisingIndividuals</seealso>
    let RecognisingIndividuals =
        Prefixed_Name(vair, "RecognisingIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Recommendation generated by an AI system"</para>
    /// labels<para>"Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Recommendation">https://w3id.org/vair#Recommendation</seealso>
    let Recommendation = Prefixed_Name(vair, "Recommendation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#RecommenderSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#RecommenderSystem">https://w3id.org/vair#RecommenderSystem</seealso>
    let RecommenderSystem = Prefixed_Name(vair, "RecommenderSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Recruiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Recruiting people for a job"</para>
    /// labels<para>"Recruiting"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Recruiting">https://w3id.org/vair#Recruiting</seealso>
    let Recruiting = Prefixed_Name(vair, "Recruiting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RecurrentNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"neural network in which outputs from both the previous layer and the previous processing step are fed into the current layer. "</para>
    /// labels<para>"Recurrent Neural Network"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RecurrentNeuralNetwork">https://w3id.org/vair#RecurrentNeuralNetwork</seealso>
    let RecurrentNeuralNetwork =
        Prefixed_Name(vair, "RecurrentNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ReducingHealthCareServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Reducing natural persons healthcare services"</para>
    /// labels<para>"Reducing Health Care Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReducingHealthCareServices">https://w3id.org/vair#ReducingHealthCareServices</seealso>
    let ReducingHealthCareServices =
        Prefixed_Name(vair, "ReducingHealthCareServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ReducingPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Reducing essential public assistance benefits and services"</para>
    /// labels<para>"Reducing Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReducingPublicAssistanceServices">https://w3id.org/vair#ReducingPublicAssistanceServices</seealso>
    let ReducingPublicAssistanceServices =
        Prefixed_Name(vair, "ReducingPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ReinforcementLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Learning of an optimal sequence of actions to maximize a reward through interaction with an environment"</para>
    /// labels<para>"Reinforcement Learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReinforcementLearning">https://w3id.org/vair#ReinforcementLearning</seealso>
    let ReinforcementLearning =
        Prefixed_Name(vair, "ReinforcementLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RelationshipExtraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Identifying relationships among entities mentioned in a text."</para>
    /// labels<para>"Relationship Extraction"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RelationshipExtraction">https://w3id.org/vair#RelationshipExtraction</seealso>
    let RelationshipExtraction =
        Prefixed_Name(vair, "RelationshipExtraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RemoteBiometricIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#RemoteBiometricIdentification">https://w3id.org/vair#RemoteBiometricIdentification</seealso>
    let RemoteBiometricIdentification =
        Prefixed_Name(vair, "RemoteBiometricIdentification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RemoteIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to the identification of natural persons without their active involvement, typically at a distance"</para>
    /// labels<para>"Remote Identification"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RemoteIdentification">https://w3id.org/vair#RemoteIdentification</seealso>
    let RemoteIdentification =
        Prefixed_Name(vair, "RemoteIdentification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RemoteIdentificationOfPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#RemoteIdentificationOfPeople">https://w3id.org/vair#RemoteIdentificationOfPeople</seealso>
    let RemoteIdentificationOfPeople =
        Prefixed_Name(vair, "RemoteIdentificationOfPeople") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ResearchingFacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Researching facts"</para>
    /// labels<para>"Researching Facts"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ResearchingFacts">https://w3id.org/vair#ResearchingFacts</seealso>
    let ResearchingFacts = Prefixed_Name(vair, "ResearchingFacts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ResearchingLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Researching the law"</para>
    /// labels<para>"Researching Law"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ResearchingLaw">https://w3id.org/vair#ResearchingLaw</seealso>
    let ResearchingLaw = Prefixed_Name(vair, "ResearchingLaw") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ResidencePermitApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for a residence permit"</para>
    /// labels<para>"Residence Permit Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ResidencePermitApplicant">https://w3id.org/vair#ResidencePermitApplicant</seealso>
    let ResidencePermitApplicant =
        Prefixed_Name(vair, "ResidencePermitApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Retirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"The stage the AI system become obsolete"</para>
    /// labels<para>"Retirement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Retirement">https://w3id.org/vair#Retirement</seealso>
    let Retirement = Prefixed_Name(vair, "Retirement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ReverseOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A mode of controllability that stakeholders can reverse the system’s output ex-post."</para>
    /// labels<para>"Reverse Output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReverseOutput">https://w3id.org/vair#ReverseOutput</seealso>
    let ReverseOutput = Prefixed_Name(vair, "ReverseOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ReversingOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Reversing the outcome of a system."</para>
    /// labels<para>"Reversing Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ReversingOutcome">https://w3id.org/vair#ReversingOutcome</seealso>
    let ReversingOutcome = Prefixed_Name(vair, "ReversingOutcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RevokingHealthCareServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Revoking natural persons healthcare services"</para>
    /// labels<para>"Revoking Health Care Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RevokingHealthCareServices">https://w3id.org/vair#RevokingHealthCareServices</seealso>
    let RevokingHealthCareServices =
        Prefixed_Name(vair, "RevokingHealthCareServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RevokingPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Revoking essential public assistance benefits and services"</para>
    /// labels<para>"Revoking Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RevokingPublicAssistanceServices">https://w3id.org/vair#RevokingPublicAssistanceServices</seealso>
    let RevokingPublicAssistanceServices =
        Prefixed_Name(vair, "RevokingPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to fundamental rights."</para>
    /// labels<para>"Right"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Right">https://w3id.org/vair#Right</seealso>
    let Right = Prefixed_Name(vair, "Right") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#RightToNondiscrimination</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the fundamental right to non-discrimination"</para>
    /// labels<para>"Right To Non-discrimination"</para></remarks>
    /// <seealso href="https://w3id.org/vair#RightToNondiscrimination">https://w3id.org/vair#RightToNondiscrimination</seealso>
    let RightToNondiscrimination =
        Prefixed_Name(vair, "RightToNondiscrimination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Robot</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An automation system with actuators that performs intended tasks in the physical world, by means of sensing its environment and a software control system."</para>
    /// labels<para>"Robot"</para><para>"ISO/IEC 22989, 3.1.29"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#Robot">https://w3id.org/vair#Robot</seealso>
    let Robot = Prefixed_Name(vair, "Robot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#RobotSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#RobotSystem">https://w3id.org/vair#RobotSystem</seealso>
    let RobotSystem = Prefixed_Name(vair, "RobotSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SVM">https://w3id.org/vair#SVM</seealso>
    let SVM = Prefixed_Name(vair, "SVM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to the state of safety."</para>
    /// labels<para>"Safety"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Safety">https://w3id.org/vair#Safety</seealso>
    let Safety = Prefixed_Name(vair, "Safety") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SafetyComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Component of a product or of an AI system which fulfils a safety function for that product or AI system, or the failure or malfunctioning of which endangers the health and safety of persons or property"</para>
    /// labels<para>"Safety Component"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SafetyComponent">https://w3id.org/vair#SafetyComponent</seealso>
    let SafetyComponent = Prefixed_Name(vair, "SafetyComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SearchMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to statistical-based search Methods"</para>
    /// labels<para>"Search Method"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SearchMethod">https://w3id.org/vair#SearchMethod</seealso>
    let SearchMethod = Prefixed_Name(vair, "SearchMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SecurityMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to security measures "</para>
    /// labels<para>"Security Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SecurityMeasure">https://w3id.org/vair#SecurityMeasure</seealso>
    let SecurityMeasure = Prefixed_Name(vair, "SecurityMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SelectingPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SelectingPeople">https://w3id.org/vair#SelectingPeople</seealso>
    let SelectingPeople = Prefixed_Name(vair, "SelectingPeople") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SemiAutomatedControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Controls that are implemeted in a semi automated manner."</para>
    /// labels<para>"Semi Automated Control"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SemiAutomatedControl">https://w3id.org/vair#SemiAutomatedControl</seealso>
    let SemiAutomatedControl =
        Prefixed_Name(vair, "SemiAutomatedControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SemiSupervisedLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Machine learning that makes use of both labelled and unlabelled data during training"</para>
    /// labels<para>"Semi Supervised Learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SemiSupervisedLearning">https://w3id.org/vair#SemiSupervisedLearning</seealso>
    let SemiSupervisedLearning =
        Prefixed_Name(vair, "SemiSupervisedLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SensitiveAttributeInference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"The capability of infering sensitive or protected attributes or characteristics"</para>
    /// labels<para>"Sensitive Attribute Inference"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SensitiveAttributeInference">https://w3id.org/vair#SensitiveAttributeInference</seealso>
    let SensitiveAttributeInference =
        Prefixed_Name(vair, "SensitiveAttributeInference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SentimentAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Computationally identifying and categorizing opinions expressed in a piece of text, speech or image, to determine a range of feeling such as from positive to negative."</para>
    /// labels<para>"Sentiment Analysis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SentimentAnalysis">https://w3id.org/vair#SentimentAnalysis</seealso>
    let SentimentAnalysis = Prefixed_Name(vair, "SentimentAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Refers to system provided as a service"</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Service">https://w3id.org/vair#Service</seealso>
    let Service = Prefixed_Name(vair, "Service") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ServiceRobot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"A robot in personal use or professional use that performs useful tasks for humans or equipment."</para>
    /// labels<para>"Service Robot"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServiceRobot">https://w3id.org/vair#ServiceRobot</seealso>
    let ServiceRobot = Prefixed_Name(vair, "ServiceRobot") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function"</para>
    /// labels<para>"Serving Safety Function"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunction">https://w3id.org/vair#ServingSafetyFunction</seealso>
    let ServingSafetyFunction =
        Prefixed_Name(vair, "ServingSafetyFunction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purpose of providing safety function in management of services"</para>
    /// labels<para>"Serving Safety Function In Management"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagement">https://w3id.org/vair#ServingSafetyFunctionInManagement</seealso>
    let ServingSafetyFunctionInManagement =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purpose of providing safety function in management of critical digital infrastructure"</para>
    /// labels<para>"Serving Safety Function In Management Of Critical Digital Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure">https://w3id.org/vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure</seealso>
    let ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfRoadTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purpose of providing safety function in management of road traffic"</para>
    /// labels<para>"Serving Safety Function In Management Of Road Traffic"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfRoadTraffic">https://w3id.org/vair#ServingSafetyFunctionInManagementOfRoadTraffic</seealso>
    let ServingSafetyFunctionInManagementOfRoadTraffic =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfRoadTraffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function in management of the supply of electricity"</para>
    /// labels<para>"Serving Safety Function In Management Of The Supply Of Electricity"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity">https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity</seealso>
    let ServingSafetyFunctionInManagementOfTheSupplyOfElectricity =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfTheSupplyOfElectricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Purpose of providing safety function in management of the supply of gas"</para>
    /// labels<para>"Serving Safety Function In Management Of The Supply Of Gas"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas">https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas</seealso>
    let ServingSafetyFunctionInManagementOfTheSupplyOfGas =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfTheSupplyOfGas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function in management of the supply of heating"</para>
    /// labels<para>"Serving Safety Function In Management Of The Supply Of Heating"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating">https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating</seealso>
    let ServingSafetyFunctionInManagementOfTheSupplyOfHeating =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfTheSupplyOfHeating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Purpose of providing safety function in management of the supply of water"</para>
    /// labels<para>"Serving Safety Function In Management Of The Supply Of Water"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater">https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater</seealso>
    let ServingSafetyFunctionInManagementOfTheSupplyOfWater =
        Prefixed_Name(vair, "ServingSafetyFunctionInManagementOfTheSupplyOfWater") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Purpose of providing safety function in operation of services"</para>
    /// labels<para>"Serving Safety Function In Operation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperation">https://w3id.org/vair#ServingSafetyFunctionInOperation</seealso>
    let ServingSafetyFunctionInOperation =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function in operation of critical digital infrastructure"</para>
    /// labels<para>"Serving Safety Function In Operation Of Critical Digital Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure">https://w3id.org/vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure</seealso>
    let ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfRoadTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Purpose of providing safety function in operation of road traffic"</para>
    /// labels<para>"Serving Safety Function In Operation Of Road Traffic"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfRoadTraffic">https://w3id.org/vair#ServingSafetyFunctionInOperationOfRoadTraffic</seealso>
    let ServingSafetyFunctionInOperationOfRoadTraffic =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfRoadTraffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function in operation of the supply of electricity"</para>
    /// labels<para>"Serving Safety Function In Operation Of The Supply Of Electricity"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity">https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity</seealso>
    let ServingSafetyFunctionInOperationOfTheSupplyOfElectricity =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfTheSupplyOfElectricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Purpose of providing safety function in operation of the supply of gas"</para>
    /// labels<para>"Serving Safety Function In Operation Of The Supply Of Gas"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas">https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas</seealso>
    let ServingSafetyFunctionInOperationOfTheSupplyOfGas =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfTheSupplyOfGas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Purpose of providing safety function in operation of the supply of heating"</para>
    /// labels<para>"Serving Safety Function In Operation Of The Supply Of Heating"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating">https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating</seealso>
    let ServingSafetyFunctionInOperationOfTheSupplyOfHeating =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfTheSupplyOfHeating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Purpose of providing safety function in operation of the supply of water"</para>
    /// labels<para>"Serving Safety Function In Operation Of The Supply Of Water"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater">https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater</seealso>
    let ServingSafetyFunctionInOperationOfTheSupplyOfWater =
        Prefixed_Name(vair, "ServingSafetyFunctionInOperationOfTheSupplyOfWater") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SettlingDispute</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Alternative dispute resolution"</para>
    /// labels<para>"Settling Dispute"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SettlingDispute">https://w3id.org/vair#SettlingDispute</seealso>
    let SettlingDispute = Prefixed_Name(vair, "SettlingDispute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SmallScaleProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SmallScaleProvider">https://w3id.org/vair#SmallScaleProvider</seealso>
    let SmallScaleProvider = Prefixed_Name(vair, "SmallScaleProvider") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SocialRobot</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Robots with social interaction functions."</para>
    /// labels<para>"Social Robot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#SocialRobot">https://w3id.org/vair#SocialRobot</seealso>
    let SocialRobot = Prefixed_Name(vair, "SocialRobot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to a stand alone software system"</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Software">https://w3id.org/vair#Software</seealso>
    let Software = Prefixed_Name(vair, "Software") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SoundEventRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SoundEventRecognition">https://w3id.org/vair#SoundEventRecognition</seealso>
    let SoundEventRecognition =
        Prefixed_Name(vair, "SoundEventRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SoundSourceSeparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Extracting individual sound from audio recordings."</para>
    /// labels<para>"Sound Source Separation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SoundSourceSeparation">https://w3id.org/vair#SoundSourceSeparation</seealso>
    let SoundSourceSeparation =
        Prefixed_Name(vair, "SoundSourceSeparation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SoundSynthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Generation of artificial sound."</para>
    /// labels<para>"Sound Synthesis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SoundSynthesis">https://w3id.org/vair#SoundSynthesis</seealso>
    let SoundSynthesis = Prefixed_Name(vair, "SoundSynthesis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SpeakerRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Recognising speaker in audio recordings."</para>
    /// labels<para>"Speaker Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SpeakerRecognition">https://w3id.org/vair#SpeakerRecognition</seealso>
    let SpeakerRecognition = Prefixed_Name(vair, "SpeakerRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SpeechRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Converting a speech signal to a representation of the content of the speech."</para>
    /// labels<para>"Speech Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SpeechRecognition">https://w3id.org/vair#SpeechRecognition</seealso>
    let SpeechRecognition = Prefixed_Name(vair, "SpeechRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SpeechSynthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Generation of artificial speech."</para>
    /// labels<para>"Speech Synthesis"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SpeechSynthesis">https://w3id.org/vair#SpeechSynthesis</seealso>
    let SpeechSynthesis = Prefixed_Name(vair, "SpeechSynthesis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#StaffIncompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Incompetence of staff such as human oversight actors"</para>
    /// labels<para>"Staff Incompetence"</para></remarks>
    /// <seealso href="https://w3id.org/vair#StaffIncompetence">https://w3id.org/vair#StaffIncompetence</seealso>
    let StaffIncompetence = Prefixed_Name(vair, "StaffIncompetence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#StatisticalTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to techniques that are based on statistics"</para>
    /// labels<para>"Statistical Technique"</para></remarks>
    /// <seealso href="https://w3id.org/vair#StatisticalTechnique">https://w3id.org/vair#StatisticalTechnique</seealso>
    let StatisticalTechnique =
        Prefixed_Name(vair, "StatisticalTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SupervisedLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Machine learning that makes only use of labelled data during training"</para>
    /// labels<para>"Supervised Learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SupervisedLearning">https://w3id.org/vair#SupervisedLearning</seealso>
    let SupervisedLearning = Prefixed_Name(vair, "SupervisedLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SupportVectorMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"a machine learning algorithm that finds decision boundaries with maximal margins."</para>
    /// labels<para>"Support Vector Machine"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SupportVectorMachine">https://w3id.org/vair#SupportVectorMachine</seealso>
    let SupportVectorMachine =
        Prefixed_Name(vair, "SupportVectorMachine") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Suspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Suspect">https://w3id.org/vair#Suspect</seealso>
    let Suspect = Prefixed_Name(vair, "Suspect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SymbolicReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Reasoning based on the knowledge encoded in a formal language"</para>
    /// labels<para>"Symbolic Reasoning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SymbolicReasoning">https://w3id.org/vair#SymbolicReasoning</seealso>
    let SymbolicReasoning = Prefixed_Name(vair, "SymbolicReasoning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SystemArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SystemArchitecture">https://w3id.org/vair#SystemArchitecture</seealso>
    let SystemArchitecture = Prefixed_Name(vair, "SystemArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SystemArchitectureDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Documentation specifying software architecture."</para>
    /// labels<para>"System Architecture Documentation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SystemArchitectureDocumentation">https://w3id.org/vair#SystemArchitectureDocumentation</seealso>
    let SystemArchitectureDocumentation =
        Prefixed_Name(vair, "SystemArchitectureDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#SystemRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Risk sources related to the AI system"</para>
    /// labels<para>"System Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#SystemRiskSource">https://w3id.org/vair#SystemRiskSource</seealso>
    let SystemRiskSource = Prefixed_Name(vair, "SystemRiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#SystemVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#SystemVulnerability">https://w3id.org/vair#SystemVulnerability</seealso>
    let SystemVulnerability = Prefixed_Name(vair, "SystemVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TechnicalDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Documentation required by the AI Act, Article 11."</para>
    /// labels<para>"Technical Documentation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TechnicalDocumentation">https://w3id.org/vair#TechnicalDocumentation</seealso>
    let TechnicalDocumentation =
        Prefixed_Name(vair, "TechnicalDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TechnicalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to technical measures "</para>
    /// labels<para>"Technical Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TechnicalMeasure">https://w3id.org/vair#TechnicalMeasure</seealso>
    let TechnicalMeasure = Prefixed_Name(vair, "TechnicalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TensorProcessingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>"An AI application-specific integrated circuit developed by Google."</para>
    /// labels<para>"Tensor Processing Unit"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TensorProcessingUnit">https://w3id.org/vair#TensorProcessingUnit</seealso>
    let TensorProcessingUnit =
        Prefixed_Name(vair, "TensorProcessingUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#TestData">https://w3id.org/vair#TestData</seealso>
    let TestData = Prefixed_Name(vair, "TestData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#TestDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Risk sources related to test data"</para>
    /// labels<para>"Test Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TestDataRiskSource">https://w3id.org/vair#TestDataRiskSource</seealso>
    let TestDataRiskSource = Prefixed_Name(vair, "TestDataRiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#TestLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Log of the tests performed."</para>
    /// labels<para>"Test Log"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TestLog">https://w3id.org/vair#TestLog</seealso>
    let TestLog = Prefixed_Name(vair, "TestLog") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#TestReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"A document that includes a summary of test activities and their results."</para>
    /// labels<para>"Test Report"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TestReport">https://w3id.org/vair#TestReport</seealso>
    let TestReport = Prefixed_Name(vair, "TestReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Testing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Testing">https://w3id.org/vair#Testing</seealso>
    let Testing = Prefixed_Name(vair, "Testing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to a software tool"</para>
    ///   <para>"Tool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tool"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Tool">https://w3id.org/vair#Tool</seealso>
    let Tool = Prefixed_Name(vair, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#TrainedModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Model resulted from model training."</para>
    /// labels<para>"Trained Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/vair#TrainedModel">https://w3id.org/vair#TrainedModel</seealso>
    let TrainedModel = Prefixed_Name(vair, "TrainedModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#TrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#TrainingData">https://w3id.org/vair#TrainingData</seealso>
    let TrainingData = Prefixed_Name(vair, "TrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TrainingDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Risk sources related to training data"</para>
    /// labels<para>"Training Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TrainingDataRiskSource">https://w3id.org/vair#TrainingDataRiskSource</seealso>
    let TrainingDataRiskSource =
        Prefixed_Name(vair, "TrainingDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#TransparencyMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Refers to transparency measures "</para>
    /// labels<para>"Transparency Measure"</para></remarks>
    /// <seealso href="https://w3id.org/vair#TransparencyMeasure">https://w3id.org/vair#TransparencyMeasure</seealso>
    let TransparencyMeasure = Prefixed_Name(vair, "TransparencyMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnavailabilityOfData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Use of datasets that are not available"</para>
    /// labels<para>"Unavailability Of Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnavailabilityOfData">https://w3id.org/vair#UnavailabilityOfData</seealso>
    let UnavailabilityOfData =
        Prefixed_Name(vair, "UnavailabilityOfData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UninformedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents that a specific actor was not informed that an AI system is in place."</para>
    /// labels<para>"Uninformed Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UninformedInvolvement">https://w3id.org/vair#UninformedInvolvement</seealso>
    let UninformedInvolvement =
        Prefixed_Name(vair, "UninformedInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnintendedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Represents unintended involvement of a specific actor."</para>
    /// labels<para>"Unintended Involvement"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnintendedInvolvement">https://w3id.org/vair#UnintendedInvolvement</seealso>
    let UnintendedInvolvement =
        Prefixed_Name(vair, "UnintendedInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnrepresentativeTestData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Use of unrepresentative  data for testing"</para>
    /// labels<para>"Unrepresentative Test Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnrepresentativeTestData">https://w3id.org/vair#UnrepresentativeTestData</seealso>
    let UnrepresentativeTestData =
        Prefixed_Name(vair, "UnrepresentativeTestData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnrepresentativeTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Use of unrepresentative data for training"</para>
    /// labels<para>"Unrepresentative Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnrepresentativeTrainingData">https://w3id.org/vair#UnrepresentativeTrainingData</seealso>
    let UnrepresentativeTrainingData =
        Prefixed_Name(vair, "UnrepresentativeTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnrepresentativeValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>"Use of unrepresentative data for validation"</para>
    /// labels<para>"Unrepresentative Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnrepresentativeValidationData">https://w3id.org/vair#UnrepresentativeValidationData</seealso>
    let UnrepresentativeValidationData =
        Prefixed_Name(vair, "UnrepresentativeValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UnsupervisedLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Machine learning that makes only use of unlabelled data during training."</para>
    /// labels<para>"Unsupervised Learning"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UnsupervisedLearning">https://w3id.org/vair#UnsupervisedLearning</seealso>
    let UnsupervisedLearning =
        Prefixed_Name(vair, "UnsupervisedLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#UserTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>"Providing training to staff, users, etc."</para>
    /// labels<para>"User Training"</para></remarks>
    /// <seealso href="https://w3id.org/vair#UserTraining">https://w3id.org/vair#UserTraining</seealso>
    let UserTraining = Prefixed_Name(vair, "UserTraining") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Validating that the AI system from the design and development stage works according to requirements and meets objectives."</para>
    /// labels<para>"Validation"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Validation">https://w3id.org/vair#Validation</seealso>
    let Validation = Prefixed_Name(vair, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#ValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#ValidationData">https://w3id.org/vair#ValidationData</seealso>
    let ValidationData = Prefixed_Name(vair, "ValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#ValidationDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Risk sources related to validation data"</para>
    /// labels<para>"Validation Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/vair#ValidationDataRiskSource">https://w3id.org/vair#ValidationDataRiskSource</seealso>
    let ValidationDataRiskSource =
        Prefixed_Name(vair, "ValidationDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Verification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Verifying the AI system from the design and development stage works according to requirements and meets objectives."</para>
    /// labels<para>"Verification"</para></remarks>
    /// <seealso href="https://w3id.org/vair#Verification">https://w3id.org/vair#Verification</seealso>
    let Verification = Prefixed_Name(vair, "Verification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#VerificationOfMigrationSeekerClaims</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#VerificationOfMigrationSeekerClaims">https://w3id.org/vair#VerificationOfMigrationSeekerClaims</seealso>
    let VerificationOfMigrationSeekerClaims =
        Prefixed_Name(vair, "VerificationOfMigrationSeekerClaims") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#VerifyingAuthenticityOfTravelDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Verifying of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features."</para>
    /// labels<para>"Verifying Authenticity Of Travel Document"</para></remarks>
    /// <seealso href="https://w3id.org/vair#VerifyingAuthenticityOfTravelDocument">https://w3id.org/vair#VerifyingAuthenticityOfTravelDocument</seealso>
    let VerifyingAuthenticityOfTravelDocument =
        Prefixed_Name(vair, "VerifyingAuthenticityOfTravelDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#Victim</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vair#Victim">https://w3id.org/vair#Victim</seealso>
    let Victim = Prefixed_Name(vair, "Victim") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair#VisaApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for a visa"</para>
    /// labels<para>"Visa Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/vair#VisaApplicant">https://w3id.org/vair#VisaApplicant</seealso>
    let VisaApplicant = Prefixed_Name(vair, "VisaApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#VocationalTrainingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Vocational training institution at any level"</para>
    /// labels<para>"Vocational Training Institution"</para></remarks>
    /// <seealso href="https://w3id.org/vair#VocationalTrainingInstitution">https://w3id.org/vair#VocationalTrainingInstitution</seealso>
    let VocationalTrainingInstitution =
        Prefixed_Name(vair, "VocationalTrainingInstitution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#WellbeingImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Refers to impacts that affect wellbeing"</para>
    /// labels<para>"Wellbeing Impact"</para></remarks>
    /// <seealso href="https://w3id.org/vair#WellbeingImpact">https://w3id.org/vair#WellbeingImpact</seealso>
    let WellbeingImpact = Prefixed_Name(vair, "WellbeingImpact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair#WrongDataDesignChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:vair#Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the wrong choice made in the selecting datasets."</para>
    /// labels<para>"Wrong Data Design Choice"</para></remarks>
    /// <seealso href="https://w3id.org/vair#WrongDataDesignChoice">https://w3id.org/vair#WrongDataDesignChoice</seealso>
    let WrongDataDesignChoice =
        Prefixed_Name(vair, "WrongDataDesignChoice") |> PrefixedName
