namespace https.w3id.org.vair.hash

open DoxAletheia.Rdf_Vocabulary

module vair =
    let _namespace_name = "https://w3id.org/vair#"
    /// <summary>
    /// Represents a concept in VAIR
    /// <see href="https://w3id.org/vair#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    /// Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.
    /// <see href="https://w3id.org/vair#AGI"></see></summary>
    let AGI = Namespaced_IRI.parse _namespace_name "AGI" |> NamespacedName
    /// <summary>
    /// Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.
    /// <see href="https://w3id.org/vair#GeneralAI"></see></summary>
    let GeneralAI = Namespaced_IRI.parse _namespace_name "GeneralAI" |> NamespacedName
    /// <summary>
    /// A form of AI documentation
    /// <see href="https://w3id.org/vair#AICards"></see></summary>
    let AICards = Namespaced_IRI.parse _namespace_name "AICards" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AIComponent"></see>
    /// </summary>
    let AIComponent =
        Namespaced_IRI.parse _namespace_name "AIComponent" |> NamespacedName

    /// <summary>
    /// Action performed by a system.
    /// <see href="https://w3id.org/vair#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    /// The capability to recognise actions
    /// <see href="https://w3id.org/vair#ActionRecognition"></see></summary>
    let ActionRecognition =
        Namespaced_IRI.parse _namespace_name "ActionRecognition" |> NamespacedName

    /// <summary>
    /// Capability of a functional unit to acquire, process and interpret data representing images or video.
    /// <see href="https://w3id.org/vair#ComputerVision"></see></summary>
    let ComputerVision =
        Namespaced_IRI.parse _namespace_name "ComputerVision" |> NamespacedName

    /// <summary>
    /// Represents active interactation with an AI system.
    /// <see href="https://w3id.org/vair#ActiveInvolvement"></see></summary>
    let ActiveInvolvement =
        Namespaced_IRI.parse _namespace_name "ActiveInvolvement" |> NamespacedName

    /// <summary>
    /// Activities related to administration of democratic processes
    /// <see href="https://w3id.org/vair#AdministrationOfDemocraticProcesses"></see></summary>
    let AdministrationOfDemocraticProcesses =
        Namespaced_IRI.parse _namespace_name "AdministrationOfDemocraticProcesses" |> NamespacedName

    /// <summary>
    /// Activities related to administration of justice.
    /// <see href="https://w3id.org/vair#AdministrationOfJustice"></see></summary>
    let AdministrationOfJustice =
        Namespaced_IRI.parse _namespace_name "AdministrationOfJustice" |> NamespacedName

    /// <summary>
    /// Inputs designed to cause the model to make a mistake
    /// <see href="https://w3id.org/vair#AdversarialAttack"></see></summary>
    let AdversarialAttack =
        Namespaced_IRI.parse _namespace_name "AdversarialAttack" |> NamespacedName

    /// <summary>
    /// Malicious attempts to exploit vulnerabilities
    /// <see href="https://w3id.org/vair#Attack"></see></summary>
    let Attack = Namespaced_IRI.parse _namespace_name "Attack" |> NamespacedName
    /// <summary>
    /// physical, mathematical or otherwise logical representation of a system, entity, phenomenon, process or data.
    /// <see href="https://w3id.org/vair#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// Defines a set of instructions
    /// <see href="https://w3id.org/vair#Algorithm"></see></summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName

    /// <summary>
    /// Assignment of tasks to persons
    /// <see href="https://w3id.org/vair#AllocatingTasks"></see></summary>
    let AllocatingTasks =
        Namespaced_IRI.parse _namespace_name "AllocatingTasks" |> NamespacedName

    /// <summary>
    /// Planning purposes
    /// <see href="https://w3id.org/vair#Planning"></see></summary>
    let Planning = Namespaced_IRI.parse _namespace_name "Planning" |> NamespacedName

    /// <summary>
    /// Resource on which an application runs.
    /// <see href="https://w3id.org/vair#ApplicationPlatform"></see></summary>
    let ApplicationPlatform =
        Namespaced_IRI.parse _namespace_name "ApplicationPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ApplicationScreening"></see>
    /// </summary>
    let ApplicationScreening =
        Namespaced_IRI.parse _namespace_name "ApplicationScreening" |> NamespacedName

    /// <summary>
    /// An integrated circuit chip customized for a particular use.
    /// <see href="https://w3id.org/vair#ApplicationSpecificIntegratedCircuit"></see></summary>
    let ApplicationSpecificIntegratedCircuit =
        Namespaced_IRI.parse _namespace_name "ApplicationSpecificIntegratedCircuit" |> NamespacedName

    /// <summary>
    /// Physical equipment/components
    /// <see href="https://w3id.org/vair#Hardware"></see></summary>
    let Hardware = Namespaced_IRI.parse _namespace_name "Hardware" |> NamespacedName

    /// <summary>
    /// Applying the law to a concrete set of facts
    /// <see href="https://w3id.org/vair#ApplyingTheLawToFacts"></see></summary>
    let ApplyingTheLawToFacts =
        Namespaced_IRI.parse _namespace_name "ApplyingTheLawToFacts" |> NamespacedName

    /// <summary>
    /// Capturing knowledge and acquiring new knowledge
    /// <see href="https://w3id.org/vair#KnowledgeReasoning"></see></summary>
    let KnowledgeReasoning =
        Namespaced_IRI.parse _namespace_name "KnowledgeReasoning" |> NamespacedName

    /// <summary>
    /// Approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk.
    /// <see href="https://w3id.org/vair#Approval"></see></summary>
    let Approval = Namespaced_IRI.parse _namespace_name "Approval" |> NamespacedName

    /// <summary>
    /// Controls implemented manually by human actors
    /// <see href="https://w3id.org/vair#ManualControl"></see></summary>
    let ManualControl =
        Namespaced_IRI.parse _namespace_name "ManualControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AssesingStudent"></see>
    /// </summary>
    let AssesingStudent =
        Namespaced_IRI.parse _namespace_name "AssesingStudent" |> NamespacedName

    /// <summary>
    /// Assessing the appropriate level of education that an individual will be able to access
    /// <see href="https://w3id.org/vair#AssessingAccessibleLevelOfEducation"></see></summary>
    let AssessingAccessibleLevelOfEducation =
        Namespaced_IRI.parse _namespace_name "AssessingAccessibleLevelOfEducation" |> NamespacedName

    /// <summary>
    /// Assessment and evaluation
    /// <see href="https://w3id.org/vair#Assessment"></see></summary>
    let Assessment = Namespaced_IRI.parse _namespace_name "Assessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AssessingAdmissionTest"></see>
    /// </summary>
    let AssessingAdmissionTest =
        Namespaced_IRI.parse _namespace_name "AssessingAdmissionTest" |> NamespacedName

    /// <summary>
    /// Evaluation the creditworthiness of natural persons or establishing their credit score
    /// <see href="https://w3id.org/vair#AssessingCreditworthiness"></see></summary>
    let AssessingCreditworthiness =
        Namespaced_IRI.parse _namespace_name "AssessingCreditworthiness" |> NamespacedName

    /// <summary>
    /// Assessing health risk posed by a person
    /// <see href="https://w3id.org/vair#AssessingHealthRisk"></see></summary>
    let AssessingHealthRisk =
        Namespaced_IRI.parse _namespace_name "AssessingHealthRisk" |> NamespacedName

    /// <summary>
    /// Assessing a risk, e.g. a security risk, a risk of irregular migration, or a health risk, posed by a natural person
    /// <see href="https://w3id.org/vair#AssessingPeopleRelatedRisk"></see></summary>
    let AssessingPeopleRelatedRisk =
        Namespaced_IRI.parse _namespace_name "AssessingPeopleRelatedRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AssessingImmigrationEligibility"></see>
    /// </summary>
    let AssessingImmigrationEligibility =
        Namespaced_IRI.parse _namespace_name "AssessingImmigrationEligibility" |> NamespacedName

    /// <summary>
    /// Assessing the appropriate level of education that an individual will receive
    /// <see href="https://w3id.org/vair#AssessingLevelOfEducation"></see></summary>
    let AssessingLevelOfEducation =
        Namespaced_IRI.parse _namespace_name "AssessingLevelOfEducation" |> NamespacedName

    /// <summary>
    /// Assessing past criminal behaviour of natural persons or groups
    /// <see href="https://w3id.org/vair#AssessingPastCriminalBehaviour"></see></summary>
    let AssessingPastCriminalBehaviour =
        Namespaced_IRI.parse _namespace_name "AssessingPastCriminalBehaviour" |> NamespacedName

    /// <summary>
    /// Activities related to enforcing the law.
    /// <see href="https://w3id.org/vair#LawEnforcement"></see></summary>
    let LawEnforcement =
        Namespaced_IRI.parse _namespace_name "LawEnforcement" |> NamespacedName

    /// <summary>
    /// Assessing the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences
    /// <see href="https://w3id.org/vair#IndividualRiskAssessment"></see></summary>
    let IndividualRiskAssessment =
        Namespaced_IRI.parse _namespace_name "IndividualRiskAssessment" |> NamespacedName

    /// <summary>
    /// Assessing personality of natural persons or groups
    /// <see href="https://w3id.org/vair#AssessingPersonalityTraits"></see></summary>
    let AssessingPersonalityTraits =
        Namespaced_IRI.parse _namespace_name "AssessingPersonalityTraits" |> NamespacedName

    /// <summary>
    /// Assessing risk of a natural person becoming the victim of criminal offences
    /// <see href="https://w3id.org/vair#AssessingRiskOfBecomingVictimOfCrime"></see></summary>
    let AssessingRiskOfBecomingVictimOfCrime =
        Namespaced_IRI.parse _namespace_name "AssessingRiskOfBecomingVictimOfCrime" |> NamespacedName

    /// <summary>
    /// Assessing risk of irregular immigration posed by a person
    /// <see href="https://w3id.org/vair#AssessingRiskOfIrregularImmigration"></see></summary>
    let AssessingRiskOfIrregularImmigration =
        Namespaced_IRI.parse _namespace_name "AssessingRiskOfIrregularImmigration" |> NamespacedName

    /// <summary>
    /// Activities related to managing migration.
    /// <see href="https://w3id.org/vair#MigrationManagement"></see></summary>
    let MigrationManagement =
        Namespaced_IRI.parse _namespace_name "MigrationManagement" |> NamespacedName

    /// <summary>
    /// Assessing the risk of a natural person offending
    /// <see href="https://w3id.org/vair#AssessingRiskOfOffending"></see></summary>
    let AssessingRiskOfOffending =
        Namespaced_IRI.parse _namespace_name "AssessingRiskOfOffending" |> NamespacedName

    /// <summary>
    /// Assessing the risk of a natural person re-offending
    /// <see href="https://w3id.org/vair#AssessingRiskOfReoffending"></see></summary>
    let AssessingRiskOfReoffending =
        Namespaced_IRI.parse _namespace_name "AssessingRiskOfReoffending" |> NamespacedName

    /// <summary>
    /// Assess security risk posed by a person
    /// <see href="https://w3id.org/vair#AssessingSecurityRisk"></see></summary>
    let AssessingSecurityRisk =
        Namespaced_IRI.parse _namespace_name "AssessingSecurityRisk" |> NamespacedName

    /// <summary>
    /// Assigning natural persons to educational institutions at all levels.
    /// <see href="https://w3id.org/vair#AssigningPersonsToEducationalInstitutions"></see></summary>
    let AssigningPersonsToEducationalInstitutions =
        Namespaced_IRI.parse _namespace_name "AssigningPersonsToEducationalInstitutions" |> NamespacedName

    /// <summary>
    /// Indicates the sector that offers education or vocational training at any level or for any profession.
    /// <see href="https://w3id.org/vair#Education"></see></summary>
    let Education = Namespaced_IRI.parse _namespace_name "Education" |> NamespacedName

    /// <summary>
    /// Assigning natural persons to vocational training institutions at all levels.
    /// <see href="https://w3id.org/vair#AssigningPersonsToVocationalTrainingInstitutions"></see></summary>
    let AssigningPersonsToVocationalTrainingInstitutions =
        Namespaced_IRI.parse _namespace_name "AssigningPersonsToVocationalTrainingInstitutions" |> NamespacedName

    /// <summary>
    /// The level of automation where the system assists an operator
    /// <see href="https://w3id.org/vair#AssistiveAutomation"></see></summary>
    let AssistiveAutomation =
        Namespaced_IRI.parse _namespace_name "AssistiveAutomation" |> NamespacedName

    /// <summary>
    /// Activities related to asylum management
    /// <see href="https://w3id.org/vair#AsylumManagement"></see></summary>
    let AsylumManagement =
        Namespaced_IRI.parse _namespace_name "AsylumManagement" |> NamespacedName

    /// <summary>
    /// A person who has applied for asylum
    /// <see href="https://w3id.org/vair#AsylumSeeker"></see></summary>
    let AsylumSeeker =
        Namespaced_IRI.parse _namespace_name "AsylumSeeker" |> NamespacedName

    /// <summary>
    /// The capability to process audio recordings.
    /// <see href="https://w3id.org/vair#AudioProcessing"></see></summary>
    let AudioProcessing =
        Namespaced_IRI.parse _namespace_name "AudioProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AuthorisedRepresentative"></see>
    /// </summary>
    let AuthorisedRepresentative =
        Namespaced_IRI.parse _namespace_name "AuthorisedRepresentative" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Authority"></see>
    /// </summary>
    let Authority = Namespaced_IRI.parse _namespace_name "Authority" |> NamespacedName

    /// <summary>
    /// Shortening a portion of natural language content or text while retaining important semantic information.
    /// <see href="https://w3id.org/vair#AutomaticSummarisation"></see></summary>
    let AutomaticSummarisation =
        Namespaced_IRI.parse _namespace_name "AutomaticSummarisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#AutonomousSystem"></see>
    /// </summary>
    let AutonomousSystem =
        Namespaced_IRI.parse _namespace_name "AutonomousSystem" |> NamespacedName

    /// <summary>
    /// The level of automation where the system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.
    /// <see href="https://w3id.org/vair#Autonomy"></see></summary>
    let Autonomy = Namespaced_IRI.parse _namespace_name "Autonomy" |> NamespacedName

    /// <summary>
    /// Refers to Bayesian estimation approach
    /// <see href="https://w3id.org/vair#BayesianEstimation"></see></summary>
    let BayesianEstimation =
        Namespaced_IRI.parse _namespace_name "BayesianEstimation" |> NamespacedName

    /// <summary>
    /// Refers to techniques that are based on statistics
    /// <see href="https://w3id.org/vair#StatisticalTechnique"></see></summary>
    let StatisticalTechnique =
        Namespaced_IRI.parse _namespace_name "StatisticalTechnique" |> NamespacedName

    /// <summary>
    /// Probabilistic model  that uses Bayesian inference  for probability computations using a directed acyclic graph.
    /// <see href="https://w3id.org/vair#BayesianNetwork"></see></summary>
    let BayesianNetwork =
        Namespaced_IRI.parse _namespace_name "BayesianNetwork" |> NamespacedName

    /// <summary>
    /// Refers to Bayesian optimisation technique.
    /// <see href="https://w3id.org/vair#BayesianOptimisation"></see></summary>
    let BayesianOptimisation =
        Namespaced_IRI.parse _namespace_name "BayesianOptimisation" |> NamespacedName

    /// <summary>
    /// Capability of a system in analysing people's behaviour
    /// <see href="https://w3id.org/vair#BehaviourAnalysis"></see></summary>
    let BehaviourAnalysis =
        Namespaced_IRI.parse _namespace_name "BehaviourAnalysis" |> NamespacedName

    /// <summary>
    /// Systematic difference in treatment of certain objects, people or groups in comparison to others.
    /// <see href="https://w3id.org/vair#Bias"></see></summary>
    let Bias = Namespaced_IRI.parse _namespace_name "Bias" |> NamespacedName

    /// <summary>
    /// Control that is applied to detect bias in datasets, models, algorithms, etc.
    /// <see href="https://w3id.org/vair#BiasDetection"></see></summary>
    let BiasDetection =
        Namespaced_IRI.parse _namespace_name "BiasDetection" |> NamespacedName

    /// <summary>
    /// Control that is applied for detection purposes, e.g. detecting risks
    /// <see href="https://w3id.org/vair#DetectionControl"></see></summary>
    let DetectionControl =
        Namespaced_IRI.parse _namespace_name "DetectionControl" |> NamespacedName

    /// <summary>
    /// Bias in test data
    /// <see href="https://w3id.org/vair#BiasedTestData"></see></summary>
    let BiasedTestData =
        Namespaced_IRI.parse _namespace_name "BiasedTestData" |> NamespacedName

    /// <summary>
    /// Risk sources related to test data
    /// <see href="https://w3id.org/vair#TestDataRiskSource"></see></summary>
    let TestDataRiskSource =
        Namespaced_IRI.parse _namespace_name "TestDataRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#TestData"></see>
    /// </summary>
    let TestData = Namespaced_IRI.parse _namespace_name "TestData" |> NamespacedName

    /// <summary>
    /// Bias in training data
    /// <see href="https://w3id.org/vair#BiasedTrainingData"></see></summary>
    let BiasedTrainingData =
        Namespaced_IRI.parse _namespace_name "BiasedTrainingData" |> NamespacedName

    /// <summary>
    /// Risk sources related to training data
    /// <see href="https://w3id.org/vair#TrainingDataRiskSource"></see></summary>
    let TrainingDataRiskSource =
        Namespaced_IRI.parse _namespace_name "TrainingDataRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#TrainingData"></see>
    /// </summary>
    let TrainingData =
        Namespaced_IRI.parse _namespace_name "TrainingData" |> NamespacedName

    /// <summary>
    /// Bias in validation data
    /// <see href="https://w3id.org/vair#BiasedValidationData"></see></summary>
    let BiasedValidationData =
        Namespaced_IRI.parse _namespace_name "BiasedValidationData" |> NamespacedName

    /// <summary>
    /// Risk sources related to validation data
    /// <see href="https://w3id.org/vair#ValidationDataRiskSource"></see></summary>
    let ValidationDataRiskSource =
        Namespaced_IRI.parse _namespace_name "ValidationDataRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ValidationData"></see>
    /// </summary>
    let ValidationData =
        Namespaced_IRI.parse _namespace_name "ValidationData" |> NamespacedName

    /// <summary>
    /// The capability of the system is assigning natural persons to specific categories based on their biometric data
    /// <see href="https://w3id.org/vair#BiometricCategorisation"></see></summary>
    let BiometricCategorisation =
        Namespaced_IRI.parse _namespace_name "BiometricCategorisation" |> NamespacedName

    /// <summary>
    /// Automated recognition of physical, physiological and behavioural human features such as the face, eye movement, body shape, voice, prosody, gait, posture, heart rate, blood pressure, odour, keystrokes characteristics, for the purpose of establishing an individual’s identity by comparing biometric data of that individual to stored biometric data of individuals in a reference database, irrespective of whether the individual has given its consent or not.
    /// <see href="https://w3id.org/vair#BiometricIdentification"></see></summary>
    let BiometricIdentification =
        Namespaced_IRI.parse _namespace_name "BiometricIdentification" |> NamespacedName

    /// <summary>
    /// Refers to recognisting emtions based on biometrics information
    /// <see href="https://w3id.org/vair#BiometricsBasedEmotionRecognition"></see></summary>
    let BiometricsBasedEmotionRecognition =
        Namespaced_IRI.parse _namespace_name "BiometricsBasedEmotionRecognition" |> NamespacedName

    /// <summary>
    /// Computationally identifying and categorizing emotions expressed in a piece of text, speech, video or image or combination thereof.
    /// <see href="https://w3id.org/vair#EmotionRecognition"></see></summary>
    let EmotionRecognition =
        Namespaced_IRI.parse _namespace_name "EmotionRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#BiometricsBasedEmotionSensing"></see>
    /// </summary>
    let BiometricsBasedEmotionSensing =
        Namespaced_IRI.parse _namespace_name "BiometricsBasedEmotionSensing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Blueprint"></see>
    /// </summary>
    let Blueprint = Namespaced_IRI.parse _namespace_name "Blueprint" |> NamespacedName

    /// <summary>
    /// Activities related to border control management.
    /// <see href="https://w3id.org/vair#BorderControlManagement"></see></summary>
    let BorderControlManagement =
        Namespaced_IRI.parse _namespace_name "BorderControlManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#BorderControlSecurityCheck"></see>
    /// </summary>
    let BorderControlSecurityCheck =
        Namespaced_IRI.parse _namespace_name "BorderControlSecurityCheck" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders cannot opt out of the system’s output.
    /// <see href="https://w3id.org/vair#CannotOptOutOfOutput"></see></summary>
    let CannotOptOutOfOutput =
        Namespaced_IRI.parse _namespace_name "CannotOptOutOfOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#CaseBasedReasoning"></see>
    /// </summary>
    let CaseBasedReasoning =
        Namespaced_IRI.parse _namespace_name "CaseBasedReasoning" |> NamespacedName

    /// <summary>
    /// Assigning natural persons to specific categories
    /// <see href="https://w3id.org/vair#Categorisation"></see></summary>
    let Categorisation =
        Namespaced_IRI.parse _namespace_name "Categorisation" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders can challenge the system’s output.
    /// <see href="https://w3id.org/vair#ChallengeOutput"></see></summary>
    let ChallengeOutput =
        Namespaced_IRI.parse _namespace_name "ChallengeOutput" |> NamespacedName

    /// <summary>
    /// Classifying emergency calls by natural persons
    /// <see href="https://w3id.org/vair#ClassifyingEmergencyCall"></see></summary>
    let ClassifyingEmergencyCall =
        Namespaced_IRI.parse _namespace_name "ClassifyingEmergencyCall" |> NamespacedName

    /// <summary>
    /// Category of AI systems that enables people and machines to interact more naturally.
    /// <see href="https://w3id.org/vair#CognitiveComputing"></see></summary>
    let CognitiveComputing =
        Namespaced_IRI.parse _namespace_name "CognitiveComputing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#CognitiveSystem"></see>
    /// </summary>
    let CognitiveSystem =
        Namespaced_IRI.parse _namespace_name "CognitiveSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#CommonSenseReasoning"></see>
    /// </summary>
    let CommonSenseReasoning =
        Namespaced_IRI.parse _namespace_name "CommonSenseReasoning" |> NamespacedName

    /// <summary>
    /// The level of automation where there is sustained and specific performance by a system, with an external agent being ready to take over when necessary.
    /// <see href="https://w3id.org/vair#ConditionalAutomation"></see></summary>
    let ConditionalAutomation =
        Namespaced_IRI.parse _namespace_name "ConditionalAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ConformityAssessmentBody"></see>
    /// </summary>
    let ConformityAssessmentBody =
        Namespaced_IRI.parse _namespace_name "ConformityAssessmentBody" |> NamespacedName

    /// <summary>
    /// Content generated using an AI system.
    /// <see href="https://w3id.org/vair#Content"></see></summary>
    let Content = Namespaced_IRI.parse _namespace_name "Content" |> NamespacedName

    /// <summary>
    /// Generation or manipulation of audio content
    /// <see href="https://w3id.org/vair#ContentGeneration"></see></summary>
    let ContentGeneration =
        Namespaced_IRI.parse _namespace_name "ContentGeneration" |> NamespacedName

    /// <summary>
    /// Refers to validation phase of continuous learning AI systems, wherein incremental training takes place on an ongoing basis while the system is running in production.
    /// <see href="https://w3id.org/vair#ContinuousValidation"></see></summary>
    let ContinuousValidation =
        Namespaced_IRI.parse _namespace_name "ContinuousValidation" |> NamespacedName

    /// <summary>
    /// Feed forward neural network using convolution  in at least one of its layers.
    /// <see href="https://w3id.org/vair#ConvolutionalNeuralNetwork"></see></summary>
    let ConvolutionalNeuralNetwork =
        Namespaced_IRI.parse _namespace_name "ConvolutionalNeuralNetwork" |> NamespacedName

    /// <summary>
    /// Neural network where information is fed from the input layer to the output layer in one direction only.
    /// <see href="https://w3id.org/vair#FeedForwardNeuralNetwork"></see></summary>
    let FeedForwardNeuralNetwork =
        Namespaced_IRI.parse _namespace_name "FeedForwardNeuralNetwork" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders can correct the system’s output.
    /// <see href="https://w3id.org/vair#CorrectOutput"></see></summary>
    let CorrectOutput =
        Namespaced_IRI.parse _namespace_name "CorrectOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#CourseApplicant"></see>
    /// </summary>
    let CourseApplicant =
        Namespaced_IRI.parse _namespace_name "CourseApplicant" |> NamespacedName

    /// <summary>
    /// A person who attends a course.
    /// <see href="https://w3id.org/vair#CourseAttendee"></see></summary>
    let CourseAttendee =
        Namespaced_IRI.parse _namespace_name "CourseAttendee" |> NamespacedName

    /// <summary>
    /// Refers to the sector or activities that aim at provision and maintainance of critical services.
    /// <see href="https://w3id.org/vair#CriticalInfrastructure"></see></summary>
    let CriticalInfrastructure =
        Namespaced_IRI.parse _namespace_name "CriticalInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Cyberattack"></see>
    /// </summary>
    let Cyberattack =
        Namespaced_IRI.parse _namespace_name "Cyberattack" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName

    /// <summary>
    /// Attack trying to manipulate the training dataset.
    /// <see href="https://w3id.org/vair#DataPoisoning"></see></summary>
    let DataPoisoning =
        Namespaced_IRI.parse _namespace_name "DataPoisoning" |> NamespacedName

    /// <summary>
    /// Risk sources related to data
    /// <see href="https://w3id.org/vair#DataRiskSource"></see></summary>
    let DataRiskSource =
        Namespaced_IRI.parse _namespace_name "DataRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Dataset"></see>
    /// </summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// A form of dataset documentation
    /// <see href="https://w3id.org/vair#Datasheet"></see></summary>
    let Datasheet = Namespaced_IRI.parse _namespace_name "Datasheet" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vair#Death"></see>
    /// </summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName
    /// <summary>
    /// Decision generated by an AI system
    /// <see href="https://w3id.org/vair#Decision"></see></summary>
    let Decision = Namespaced_IRI.parse _namespace_name "Decision" |> NamespacedName

    /// <summary>
    /// Generation of decisions
    /// <see href="https://w3id.org/vair#DecisionMaking"></see></summary>
    let DecisionMaking =
        Namespaced_IRI.parse _namespace_name "DecisionMaking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#DecisionSupportSystem"></see>
    /// </summary>
    let DecisionSupportSystem =
        Namespaced_IRI.parse _namespace_name "DecisionSupportSystem" |> NamespacedName

    /// <summary>
    /// Model for which inference  is encoded as paths from the root to a leaf node in a tree structure.
    /// <see href="https://w3id.org/vair#DecisionTree"></see></summary>
    let DecisionTree =
        Namespaced_IRI.parse _namespace_name "DecisionTree" |> NamespacedName

    /// <summary>
    /// Decreased level of system's robustness resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DecreasedRobustness"></see></summary>
    let DecreasedRobustness =
        Namespaced_IRI.parse _namespace_name "DecreasedRobustness" |> NamespacedName

    /// <summary>
    /// Decreased level of security of system resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DecreasedSecurity"></see></summary>
    let DecreasedSecurity =
        Namespaced_IRI.parse _namespace_name "DecreasedSecurity" |> NamespacedName

    /// <summary>
    /// Dectection of content that is generated using deep fake
    /// <see href="https://w3id.org/vair#DeepFakeDetection"></see></summary>
    let DeepFakeDetection =
        Namespaced_IRI.parse _namespace_name "DeepFakeDetection" |> NamespacedName

    /// <summary>
    /// Purposes related to detecting
    /// <see href="https://w3id.org/vair#Detection"></see></summary>
    let Detection = Namespaced_IRI.parse _namespace_name "Detection" |> NamespacedName

    /// <summary>
    /// Approach to creating rich hierarchical representations through the training of neural networks with many hidden layers
    /// <see href="https://w3id.org/vair#DeepLearning"></see></summary>
    let DeepLearning =
        Namespaced_IRI.parse _namespace_name "DeepLearning" |> NamespacedName

    /// <summary>
    /// Process of optimizing model parameters through computational techniques, such that the model's behaviour reflects the data or experience.
    /// <see href="https://w3id.org/vair#MachineLearning"></see></summary>
    let MachineLearning =
        Namespaced_IRI.parse _namespace_name "MachineLearning" |> NamespacedName

    /// <summary>
    /// Decreased level of system's accuracy resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DegradedAccuracy"></see></summary>
    let DegradedAccuracy =
        Namespaced_IRI.parse _namespace_name "DegradedAccuracy" |> NamespacedName

    /// <summary>
    /// Refers to deployment phase oThe AI system is installed, released or configured for operation in a target environment.
    /// <see href="https://w3id.org/vair#Deployment"></see></summary>
    let Deployment = Namespaced_IRI.parse _namespace_name "Deployment" |> NamespacedName
    /// <summary>
    /// Refers to design phase of AI development
    /// <see href="https://w3id.org/vair#Design"></see></summary>
    let Design = Namespaced_IRI.parse _namespace_name "Design" |> NamespacedName

    /// <summary>
    /// Design specification of a system
    /// <see href="https://w3id.org/vair#DesignSpecification"></see></summary>
    let DesignSpecification =
        Namespaced_IRI.parse _namespace_name "DesignSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Detecting"></see>
    /// </summary>
    let Detecting = Namespaced_IRI.parse _namespace_name "Detecting" |> NamespacedName

    /// <summary>
    /// Detection of criminal offences
    /// <see href="https://w3id.org/vair#DetectingCriminalOffences"></see></summary>
    let DetectingCriminalOffences =
        Namespaced_IRI.parse _namespace_name "DetectingCriminalOffences" |> NamespacedName

    /// <summary>
    /// Detection of the emotional state of a natural person
    /// <see href="https://w3id.org/vair#DetectingEmotionalState"></see></summary>
    let DetectingEmotionalState =
        Namespaced_IRI.parse _namespace_name "DetectingEmotionalState" |> NamespacedName

    /// <summary>
    /// Detecting natural persons
    /// <see href="https://w3id.org/vair#DetectingIndividuals"></see></summary>
    let DetectingIndividuals =
        Namespaced_IRI.parse _namespace_name "DetectingIndividuals" |> NamespacedName

    /// <summary>
    /// Dectecting lies
    /// <see href="https://w3id.org/vair#DetectingLies"></see></summary>
    let DetectingLies =
        Namespaced_IRI.parse _namespace_name "DetectingLies" |> NamespacedName

    /// <summary>
    /// Detection of  non-authentic documents
    /// <see href="https://w3id.org/vair#DetectingNon-AuthenticDocument"></see></summary>
    let ``DetectingNon-AuthenticDocument`` =
        Namespaced_IRI.parse _namespace_name "DetectingNon-AuthenticDocument" |> NamespacedName

    /// <summary>
    /// Detecting prohibited behaviour during tests
    /// <see href="https://w3id.org/vair#DetectingProhibitedBehaviourDuringTest"></see></summary>
    let DetectingProhibitedBehaviourDuringTest =
        Namespaced_IRI.parse _namespace_name "DetectingProhibitedBehaviourDuringTest" |> NamespacedName

    /// <summary>
    /// Determining access to educational institutions all levels.
    /// <see href="https://w3id.org/vair#DeterminingAccessToEducationalInstitutions"></see></summary>
    let DeterminingAccessToEducationalInstitutions =
        Namespaced_IRI.parse _namespace_name "DeterminingAccessToEducationalInstitutions" |> NamespacedName

    /// <summary>
    /// Determining access to vocational training institutions all levels.
    /// <see href="https://w3id.org/vair#DeterminingAccessToVocationalTrainingInstitutions"></see></summary>
    let DeterminingAccessToVocationalTrainingInstitutions =
        Namespaced_IRI.parse _namespace_name "DeterminingAccessToVocationalTrainingInstitutions" |> NamespacedName

    /// <summary>
    /// Determining admission to educational institutions at all levels.
    /// <see href="https://w3id.org/vair#DeterminingAdmissionToEducationalInstitutions"></see></summary>
    let DeterminingAdmissionToEducationalInstitutions =
        Namespaced_IRI.parse _namespace_name "DeterminingAdmissionToEducationalInstitutions" |> NamespacedName

    /// <summary>
    /// Determining admission to vocational training institutions at all levels.
    /// <see href="https://w3id.org/vair#DeterminingAdmissionToVocationalTrainingInstitutions"></see></summary>
    let DeterminingAdmissionToVocationalTrainingInstitutions =
        Namespaced_IRI.parse _namespace_name "DeterminingAdmissionToVocationalTrainingInstitutions" |> NamespacedName

    /// <summary>
    /// Determining credit score of a person
    /// <see href="https://w3id.org/vair#DeterminingCreditScore"></see></summary>
    let DeterminingCreditScore =
        Namespaced_IRI.parse _namespace_name "DeterminingCreditScore" |> NamespacedName

    /// <summary>
    /// Refers to the development phase in AI lifecyle
    /// <see href="https://w3id.org/vair#Development"></see></summary>
    let Development =
        Namespaced_IRI.parse _namespace_name "Development" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#DevelopmentData"></see>
    /// </summary>
    let DevelopmentData =
        Namespaced_IRI.parse _namespace_name "DevelopmentData" |> NamespacedName

    /// <summary>
    /// Choosing the appropriate next move in a dialogue based on user input, the dialogue history and other contextual knowledge to meet a desired goal
    /// <see href="https://w3id.org/vair#DialogueManagement"></see></summary>
    let DialogueManagement =
        Namespaced_IRI.parse _namespace_name "DialogueManagement" |> NamespacedName

    /// <summary>
    /// Identifying unkown patterns of crime
    /// <see href="https://w3id.org/vair#DiscoveringCrimePatterns"></see></summary>
    let DiscoveringCrimePatterns =
        Namespaced_IRI.parse _namespace_name "DiscoveringCrimePatterns" |> NamespacedName

    /// <summary>
    /// Discovering hidden relationships related to crime
    /// <see href="https://w3id.org/vair#DiscoveringCrimeRelationships"></see></summary>
    let DiscoveringCrimeRelationships =
        Namespaced_IRI.parse _namespace_name "DiscoveringCrimeRelationships" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#LawEnforcemnet"></see>
    /// </summary>
    let LawEnforcemnet =
        Namespaced_IRI.parse _namespace_name "LawEnforcemnet" |> NamespacedName

    /// <summary>
    /// Dispatching  of emergency first response services, including by firefighters and medical aid
    /// <see href="https://w3id.org/vair#DispatchingEmergencyService"></see></summary>
    let DispatchingEmergencyService =
        Namespaced_IRI.parse _namespace_name "DispatchingEmergencyService" |> NamespacedName

    /// <summary>
    /// Business of supplying a commodity or a service by a govermental or public body.
    /// <see href="https://w3id.org/vair#PublicService"></see></summary>
    let PublicService =
        Namespaced_IRI.parse _namespace_name "PublicService" |> NamespacedName

    /// <summary>
    /// Represent distortion of human behaviour caused by AI
    /// <see href="https://w3id.org/vair#DistortionInHumanBehaviour"></see></summary>
    let DistortionInHumanBehaviour =
        Namespaced_IRI.parse _namespace_name "DistortionInHumanBehaviour" |> NamespacedName

    /// <summary>
    /// Refers to impacts that affect wellbeing
    /// <see href="https://w3id.org/vair#WellbeingImpact"></see></summary>
    let WellbeingImpact =
        Namespaced_IRI.parse _namespace_name "WellbeingImpact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Distributor"></see>
    /// </summary>
    let Distributor =
        Namespaced_IRI.parse _namespace_name "Distributor" |> NamespacedName

    /// <summary>
    /// Union agency
    /// <see href="https://w3id.org/vair#EUAgency"></see></summary>
    let EUAgency = Namespaced_IRI.parse _namespace_name "EUAgency" |> NamespacedName
    /// <summary>
    /// Union body
    /// <see href="https://w3id.org/vair#EUBody"></see></summary>
    let EUBody = Namespaced_IRI.parse _namespace_name "EUBody" |> NamespacedName

    /// <summary>
    /// Document providing the EU declaration of conformity, as required by the AI Act, Article 47.
    /// <see href="https://w3id.org/vair#EUDeclarationOfConformity"></see></summary>
    let EUDeclarationOfConformity =
        Namespaced_IRI.parse _namespace_name "EUDeclarationOfConformity" |> NamespacedName

    /// <summary>
    /// Union institution
    /// <see href="https://w3id.org/vair#EUInstitution"></see></summary>
    let EUInstitution =
        Namespaced_IRI.parse _namespace_name "EUInstitution" |> NamespacedName

    /// <summary>
    /// EU office
    /// <see href="https://w3id.org/vair#EUOffice"></see></summary>
    let EUOffice = Namespaced_IRI.parse _namespace_name "EUOffice" |> NamespacedName

    /// <summary>
    /// Educational institution at any level
    /// <see href="https://w3id.org/vair#EducationalInstitution"></see></summary>
    let EducationalInstitution =
        Namespaced_IRI.parse _namespace_name "EducationalInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EmergancyTriage"></see>
    /// </summary>
    let EmergancyTriage =
        Namespaced_IRI.parse _namespace_name "EmergancyTriage" |> NamespacedName

    /// <summary>
    /// Refer to emergency healthcare providers
    /// <see href="https://w3id.org/vair#EmergencyHealthCareProvider"></see></summary>
    let EmergencyHealthCareProvider =
        Namespaced_IRI.parse _namespace_name "EmergencyHealthCareProvider" |> NamespacedName

    /// <summary>
    /// Provider of emergency first response services
    /// <see href="https://w3id.org/vair#EmergencyServiceProvider"></see></summary>
    let EmergencyServiceProvider =
        Namespaced_IRI.parse _namespace_name "EmergencyServiceProvider" |> NamespacedName

    /// <summary>
    /// Emergency triaging
    /// <see href="https://w3id.org/vair#EmergencyTriage"></see></summary>
    let EmergencyTriage =
        Namespaced_IRI.parse _namespace_name "EmergencyTriage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EmotionSensing"></see>
    /// </summary>
    let EmotionSensing =
        Namespaced_IRI.parse _namespace_name "EmotionSensing" |> NamespacedName

    /// <summary>
    /// A person in work-related contractual relationships
    /// <see href="https://w3id.org/vair#Employee"></see></summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName
    /// <summary>
    /// Refers to employment, workers’ management and access to self-employment.
    /// <see href="https://w3id.org/vair#Employment"></see></summary>
    let Employment = Namespaced_IRI.parse _namespace_name "Employment" |> NamespacedName

    /// <summary>
    /// Error in data used as input
    /// <see href="https://w3id.org/vair#ErroneousInputData"></see></summary>
    let ErroneousInputData =
        Namespaced_IRI.parse _namespace_name "ErroneousInputData" |> NamespacedName

    /// <summary>
    /// Risk sources related to input data
    /// <see href="https://w3id.org/vair#InputDataRiskSource"></see></summary>
    let InputDataRiskSource =
        Namespaced_IRI.parse _namespace_name "InputDataRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#InputData"></see>
    /// </summary>
    let InputData = Namespaced_IRI.parse _namespace_name "InputData" |> NamespacedName

    /// <summary>
    /// Error in test data
    /// <see href="https://w3id.org/vair#ErroneousTestData"></see></summary>
    let ErroneousTestData =
        Namespaced_IRI.parse _namespace_name "ErroneousTestData" |> NamespacedName

    /// <summary>
    /// Error in training data
    /// <see href="https://w3id.org/vair#ErroneousTrainingData"></see></summary>
    let ErroneousTrainingData =
        Namespaced_IRI.parse _namespace_name "ErroneousTrainingData" |> NamespacedName

    /// <summary>
    /// Error in validation data
    /// <see href="https://w3id.org/vair#ErroneousValidationData"></see></summary>
    let ErroneousValidationData =
        Namespaced_IRI.parse _namespace_name "ErroneousValidationData" |> NamespacedName

    /// <summary>
    /// Refers to errors in data collection process
    /// <see href="https://w3id.org/vair#ErrorInDataCollection"></see></summary>
    let ErrorInDataCollection =
        Namespaced_IRI.parse _namespace_name "ErrorInDataCollection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#DataCollection"></see>
    /// </summary>
    let DataCollection =
        Namespaced_IRI.parse _namespace_name "DataCollection" |> NamespacedName

    /// <summary>
    /// Refers to errors in data prepration process
    /// <see href="https://w3id.org/vair#ErrorInDataPrepration"></see></summary>
    let ErrorInDataPrepration =
        Namespaced_IRI.parse _namespace_name "ErrorInDataPrepration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#DataPrepration"></see>
    /// </summary>
    let DataPrepration =
        Namespaced_IRI.parse _namespace_name "DataPrepration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EuropeanArtificialIntelligenceBoard"></see>
    /// </summary>
    let EuropeanArtificialIntelligenceBoard =
        Namespaced_IRI.parse _namespace_name "EuropeanArtificialIntelligenceBoard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EuropeanDataProtectionSupervisor"></see>
    /// </summary>
    let EuropeanDataProtectionSupervisor =
        Namespaced_IRI.parse _namespace_name "EuropeanDataProtectionSupervisor" |> NamespacedName

    /// <summary>
    /// Evaluating the eligibility of natural persons for essential public assistance benefits and services, including healthcare services,
    /// <see href="https://w3id.org/vair#EvaluatingEligibilityForPublicAssistanceServices"></see></summary>
    let EvaluatingEligibilityForPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "EvaluatingEligibilityForPublicAssistanceServices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingEligibilityToAccessPublicAssistanceServices"></see>
    /// </summary>
    let EvaluatingEligibilityToAccessPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "EvaluatingEligibilityToAccessPublicAssistanceServices" |> NamespacedName

    /// <summary>
    /// Evaluating the eligibility of natural persons for healthcare services
    /// <see href="https://w3id.org/vair#EvaluatingEligibilityforHealthCareServices"></see></summary>
    let EvaluatingEligibilityforHealthCareServices =
        Namespaced_IRI.parse _namespace_name "EvaluatingEligibilityforHealthCareServices" |> NamespacedName

    /// <summary>
    /// Evaluating emergency calls by natural persons
    /// <see href="https://w3id.org/vair#EvaluatingEmergencyCall"></see></summary>
    let EvaluatingEmergencyCall =
        Namespaced_IRI.parse _namespace_name "EvaluatingEmergencyCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingEmployee"></see>
    /// </summary>
    let EvaluatingEmployee =
        Namespaced_IRI.parse _namespace_name "EvaluatingEmployee" |> NamespacedName

    /// <summary>
    /// Evaluating the behaviour of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#EvaluatingEmployeeBehaviour"></see></summary>
    let EvaluatingEmployeeBehaviour =
        Namespaced_IRI.parse _namespace_name "EvaluatingEmployeeBehaviour" |> NamespacedName

    /// <summary>
    /// Evaluating the performance of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#EvaluatingEmployeePerformance"></see></summary>
    let EvaluatingEmployeePerformance =
        Namespaced_IRI.parse _namespace_name "EvaluatingEmployeePerformance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingInterview"></see>
    /// </summary>
    let EvaluatingInterview =
        Namespaced_IRI.parse _namespace_name "EvaluatingInterview" |> NamespacedName

    /// <summary>
    /// Evaluation of job candidates
    /// <see href="https://w3id.org/vair#EvaluatingJobCandidates"></see></summary>
    let EvaluatingJobCandidates =
        Namespaced_IRI.parse _namespace_name "EvaluatingJobCandidates" |> NamespacedName

    /// <summary>
    /// Evaluation of job interviews
    /// <see href="https://w3id.org/vair#EvaluatingJobInterview"></see></summary>
    let EvaluatingJobInterview =
        Namespaced_IRI.parse _namespace_name "EvaluatingJobInterview" |> NamespacedName

    /// <summary>
    /// Evaluating learning outcomes, including when those outcomes are used to steer the learning process of natural persons in educational and vocational training institutions or programmes at all levels.
    /// <see href="https://w3id.org/vair#EvaluatingLearningOutcomes"></see></summary>
    let EvaluatingLearningOutcomes =
        Namespaced_IRI.parse _namespace_name "EvaluatingLearningOutcomes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingRecruitmentTest"></see>
    /// </summary>
    let EvaluatingRecruitmentTest =
        Namespaced_IRI.parse _namespace_name "EvaluatingRecruitmentTest" |> NamespacedName

    /// <summary>
    /// Evaluation of the reliability of evidence in the course of investigation of criminal offences
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences"></see></summary>
    let EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences =
        Namespaced_IRI.parse _namespace_name "EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences" |> NamespacedName

    /// <summary>
    /// Assessments of the reliability of evidence in the examination of applications for asylum, visa or residence permits and for associated complaints with regard to the eligibility of the natural persons applying for a status
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications"></see></summary>
    let EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications =
        Namespaced_IRI.parse _namespace_name "EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications" |> NamespacedName

    /// <summary>
    /// Evaluation of the reliability of evidence in the course of prosecution of criminal offences
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences"></see></summary>
    let EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences =
        Namespaced_IRI.parse _namespace_name "EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluationData"></see>
    /// </summary>
    let EvaluationData =
        Namespaced_IRI.parse _namespace_name "EvaluationData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvolutionaryAlgorithm"></see>
    /// </summary>
    let EvolutionaryAlgorithm =
        Namespaced_IRI.parse _namespace_name "EvolutionaryAlgorithm" |> NamespacedName

    /// <summary>
    /// Purposes related to examining an application
    /// <see href="https://w3id.org/vair#ExaminingApplication"></see></summary>
    let ExaminingApplication =
        Namespaced_IRI.parse _namespace_name "ExaminingApplication" |> NamespacedName

    /// <summary>
    /// Examining asylum application
    /// <see href="https://w3id.org/vair#ExaminingAsylumApplication"></see></summary>
    let ExaminingAsylumApplication =
        Namespaced_IRI.parse _namespace_name "ExaminingAsylumApplication" |> NamespacedName

    /// <summary>
    /// Examining compliats related to migration
    /// <see href="https://w3id.org/vair#ExaminingMigrationRelatedComplaints"></see></summary>
    let ExaminingMigrationRelatedComplaints =
        Namespaced_IRI.parse _namespace_name "ExaminingMigrationRelatedComplaints" |> NamespacedName

    /// <summary>
    /// Examining residence permit application
    /// <see href="https://w3id.org/vair#ExaminingResidencePermitsApplication"></see></summary>
    let ExaminingResidencePermitsApplication =
        Namespaced_IRI.parse _namespace_name "ExaminingResidencePermitsApplication" |> NamespacedName

    /// <summary>
    /// Examining visa application
    /// <see href="https://w3id.org/vair#ExaminingVisaApplication"></see></summary>
    let ExaminingVisaApplication =
        Namespaced_IRI.parse _namespace_name "ExaminingVisaApplication" |> NamespacedName

    /// <summary>
    /// AI system that accumulates, combines and encapsulates knowledge provided by a human expert or experts in a specific domain to infer solutions to problems.
    /// <see href="https://w3id.org/vair#ExpertSystem"></see></summary>
    let ExpertSystem =
        Namespaced_IRI.parse _namespace_name "ExpertSystem" |> NamespacedName

    /// <summary>
    /// Refers to reasoning techniques.
    /// <see href="https://w3id.org/vair#ReasoningTechnique"></see></summary>
    let ReasoningTechnique =
        Namespaced_IRI.parse _namespace_name "ReasoningTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ExplainingAlgorithm"></see>
    /// </summary>
    let ExplainingAlgorithm =
        Namespaced_IRI.parse _namespace_name "ExplainingAlgorithm" |> NamespacedName

    /// <summary>
    /// Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs.
    /// <see href="https://w3id.org/vair#FaceRecognition"></see></summary>
    let FaceRecognition =
        Namespaced_IRI.parse _namespace_name "FaceRecognition" |> NamespacedName

    /// <summary>
    /// A group of people related to each other by blood or marraige
    /// <see href="https://w3id.org/vair#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    /// Network of one or more layers of neurons connected by weighted links with adjustable weights, which takes input data and produces an output.
    /// <see href="https://w3id.org/vair#NeuralNetwork"></see></summary>
    let NeuralNetwork =
        Namespaced_IRI.parse _namespace_name "NeuralNetwork" |> NamespacedName

    /// <summary>
    /// Refers to fire department
    /// <see href="https://w3id.org/vair#FireBrigade"></see></summary>
    let FireBrigade =
        Namespaced_IRI.parse _namespace_name "FireBrigade" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Firefighter"></see>
    /// </summary>
    let Firefighter =
        Namespaced_IRI.parse _namespace_name "Firefighter" |> NamespacedName

    /// <summary>
    /// Refers to freedoms given to individuals
    /// <see href="https://w3id.org/vair#Freedom"></see></summary>
    let Freedom = Namespaced_IRI.parse _namespace_name "Freedom" |> NamespacedName

    /// <summary>
    /// The level of automation where is capable of performing its entire mission without external intervention.
    /// <see href="https://w3id.org/vair#FullAutomation"></see></summary>
    let FullAutomation =
        Namespaced_IRI.parse _namespace_name "FullAutomation" |> NamespacedName

    /// <summary>
    /// Generation or manipulation of audio content
    /// <see href="https://w3id.org/vair#GeneratingAudioContent"></see></summary>
    let GeneratingAudioContent =
        Namespaced_IRI.parse _namespace_name "GeneratingAudioContent" |> NamespacedName

    /// <summary>
    /// Generation or manipulation of image content
    /// <see href="https://w3id.org/vair#GeneratingImageContent"></see></summary>
    let GeneratingImageContent =
        Namespaced_IRI.parse _namespace_name "GeneratingImageContent" |> NamespacedName

    /// <summary>
    /// Generation or manipulation of video content
    /// <see href="https://w3id.org/vair#GeneratingVideoContent"></see></summary>
    let GeneratingVideoContent =
        Namespaced_IRI.parse _namespace_name "GeneratingVideoContent" |> NamespacedName

    /// <summary>
    /// Algorithm which simulates natural selection by creating and evolving a population of individuals (solutions) for optimization problems
    /// <see href="https://w3id.org/vair#GeneticAlgorithm"></see></summary>
    let GeneticAlgorithm =
        Namespaced_IRI.parse _namespace_name "GeneticAlgorithm" |> NamespacedName

    /// <summary>
    /// The capability of AI system to recognise human gestures.
    /// <see href="https://w3id.org/vair#GestureRecognition"></see></summary>
    let GestureRecognition =
        Namespaced_IRI.parse _namespace_name "GestureRecognition" |> NamespacedName

    /// <summary>
    /// Granting natural persons healthcare services
    /// <see href="https://w3id.org/vair#GrantingHealthCareServices"></see></summary>
    let GrantingHealthCareServices =
        Namespaced_IRI.parse _namespace_name "GrantingHealthCareServices" |> NamespacedName

    /// <summary>
    /// Granting natural persons essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#GrantingPublicAssistanceServices"></see></summary>
    let GrantingPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "GrantingPublicAssistanceServices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#GrantingPublicAssistanceService"></see>
    /// </summary>
    let GrantingPublicAssistanceService =
        Namespaced_IRI.parse _namespace_name "GrantingPublicAssistanceService" |> NamespacedName

    /// <summary>
    /// A group of persons such as citizens, marginsalised groups, etc.
    /// <see href="https://w3id.org/vair#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// Refers to an individuals' health.
    /// <see href="https://w3id.org/vair#Health"></see></summary>
    let Health = Namespaced_IRI.parse _namespace_name "Health" |> NamespacedName

    /// <summary>
    /// Pricing in relation to natural persons in the case of health insurance
    /// <see href="https://w3id.org/vair#HealthInsurancePricing"></see></summary>
    let HealthInsurancePricing =
        Namespaced_IRI.parse _namespace_name "HealthInsurancePricing" |> NamespacedName

    /// <summary>
    /// Business of supplying a service by a private body.
    /// <see href="https://w3id.org/vair#PrivateService"></see></summary>
    let PrivateService =
        Namespaced_IRI.parse _namespace_name "PrivateService" |> NamespacedName

    /// <summary>
    /// Risk assessment in relation to natural persons in the case of health insurance
    /// <see href="https://w3id.org/vair#HealthInsuranceRiskAssessment"></see></summary>
    let HealthInsuranceRiskAssessment =
        Namespaced_IRI.parse _namespace_name "HealthInsuranceRiskAssessment" |> NamespacedName

    /// <summary>
    /// The level of automation where there the system performs parts of its mission without external intervention.
    /// <see href="https://w3id.org/vair#HighAutomation"></see></summary>
    let HighAutomation =
        Namespaced_IRI.parse _namespace_name "HighAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#HumanBehaviour"></see>
    /// </summary>
    let HumanBehaviour =
        Namespaced_IRI.parse _namespace_name "HumanBehaviour" |> NamespacedName

    /// <summary>
    /// Overseening the system by natural persons to detect, prevent or minimise risk.
    /// <see href="https://w3id.org/vair#HumanOversightMeasure"></see></summary>
    let HumanOversightMeasure =
        Namespaced_IRI.parse _namespace_name "HumanOversightMeasure" |> NamespacedName

    /// <summary>
    /// Controls that are implemeted in a semi automated manner.
    /// <see href="https://w3id.org/vair#SemiAutomatedControl"></see></summary>
    let SemiAutomatedControl =
        Namespaced_IRI.parse _namespace_name "SemiAutomatedControl" |> NamespacedName

    /// <summary>
    /// Risk management — Risk assessment techniques
    /// <see href="https://w3id.org/vair#IEC31010-2019"></see></summary>
    let ``IEC31010-2019`` =
        Namespaced_IRI.parse _namespace_name "IEC31010-2019" |> NamespacedName

    /// <summary>
    /// Quality management systems — Guidance for documented information
    /// <see href="https://w3id.org/vair#ISO10013-2021"></see></summary>
    let ``ISO10013-2021`` =
        Namespaced_IRI.parse _namespace_name "ISO10013-2021" |> NamespacedName

    /// <summary>
    /// Risk management — Guidelines
    /// <see href="https://w3id.org/vair#ISO31000-2018"></see></summary>
    let ``ISO31000-2018`` =
        Namespaced_IRI.parse _namespace_name "ISO31000-2018" |> NamespacedName

    /// <summary>
    /// ISO 31073:2022 Risk management — Vocabulary
    /// <see href="https://w3id.org/vair#ISO31073_2022"></see></summary>
    let ISO31073_2022 =
        Namespaced_IRI.parse _namespace_name "ISO31073_2022" |> NamespacedName

    /// <summary>
    /// Quality management systems — Requirements
    /// <see href="https://w3id.org/vair#ISO9001-2015"></see></summary>
    let ``ISO9001-2015`` =
        Namespaced_IRI.parse _namespace_name "ISO9001-2015" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ISOGuide73-2009"></see>
    /// </summary>
    let ``ISOGuide73-2009`` =
        Namespaced_IRI.parse _namespace_name "ISOGuide73-2009" |> NamespacedName

    /// <summary>
    /// Information technology — Big data — Overview and vocabulary
    /// <see href="https://w3id.org/vair#ISOIEC20546-2019"></see></summary>
    let ``ISOIEC20546-2019`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC20546-2019" |> NamespacedName

    /// <summary>
    /// Information technology — Big data reference architecture — Part 3: Reference architecture
    /// <see href="https://w3id.org/vair#ISOIEC20547-3-2020"></see></summary>
    let ``ISOIEC20547-3-2020`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC20547-3-2020" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence — Artificial intelligence concepts and terminology
    /// <see href="https://w3id.org/vair#ISOIEC22989-2022"></see></summary>
    let ``ISOIEC22989-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC22989-2022" |> NamespacedName

    /// <summary>
    /// Framework for Artificial Intelligence (AI) Systems Using Machine Learning (ML)
    /// <see href="https://w3id.org/vair#ISOIEC23053-2022"></see></summary>
    let ``ISOIEC23053-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC23053-2022" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence — Guidance on risk management
    /// <see href="https://w3id.org/vair#ISOIEC23894-2023"></see></summary>
    let ``ISOIEC23894-2023`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC23894-2023" |> NamespacedName

    /// <summary>
    /// ISO/IEC 23894:2023 Information technology — Artificial intelligence — Guidance on risk management
    /// <see href="https://w3id.org/vair#ISOIEC23894_2023"></see></summary>
    let ISOIEC23894_2023 =
        Namespaced_IRI.parse _namespace_name "ISOIEC23894_2023" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence — Process management framework for big data analytics
    /// <see href="https://w3id.org/vair#ISOIEC24668-2022"></see></summary>
    let ``ISOIEC24668-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC24668-2022" |> NamespacedName

    /// <summary>
    /// Information technology — Governance of IT — Governance implications of the use of artificial intelligence by organizations
    /// <see href="https://w3id.org/vair#ISOIEC38507-2022"></see></summary>
    let ``ISOIEC38507-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIEC38507-2022" |> NamespacedName

    /// <summary>
    /// ISO/IEC 42001:2023 Information technology — Artificial intelligence — Management system
    /// <see href="https://w3id.org/vair#ISOIEC42001_2023"></see></summary>
    let ISOIEC42001_2023 =
        Namespaced_IRI.parse _namespace_name "ISOIEC42001_2023" |> NamespacedName

    /// <summary>
    /// Information technology — Big data reference architecture — Part 1: Framework and application process
    /// <see href="https://w3id.org/vair#ISOIECTR20547-1-2020"></see></summary>
    let ``ISOIECTR20547-1-2020`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR20547-1-2020" |> NamespacedName

    /// <summary>
    /// Information technology — Big data reference architecture — Part 2: Use cases and derived requirements
    /// <see href="https://w3id.org/vair#ISOIECTR20547-2-2018"></see></summary>
    let ``ISOIECTR20547-2-2018`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR20547-2-2018" |> NamespacedName

    /// <summary>
    /// Information technology — Big data reference architecture — Part 5: Standards roadmap
    /// <see href="https://w3id.org/vair#ISOIECTR20547-5-2018"></see></summary>
    let ``ISOIECTR20547-5-2018`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR20547-5-2018" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Bias in AI systems and AI aided decision making
    /// <see href="https://w3id.org/vair#ISOIECTR24027-2021"></see></summary>
    let ``ISOIECTR24027-2021`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24027-2021" |> NamespacedName

    /// <summary>
    /// v
    /// <see href="https://w3id.org/vair#ISOIECTR24028-2020"></see></summary>
    let ``ISOIECTR24028-2020`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24028-2020" |> NamespacedName

    /// <summary>
    /// Artificial Intelligence (AI) — Assessment of the robustness of neural networks — Part 1: Overview
    /// <see href="https://w3id.org/vair#ISOIECTR24029-1-2021"></see></summary>
    let ``ISOIECTR24029-1-2021`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24029-1-2021" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Use cases
    /// <see href="https://w3id.org/vair#ISOIECTR24030-2021"></see></summary>
    let ``ISOIECTR24030-2021`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24030-2021" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence — Overview of ethical and societal concerns
    /// <see href="https://w3id.org/vair#ISOIECTR24368-2022"></see></summary>
    let ``ISOIECTR24368-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24368-2022" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Overview of computational approaches for AI systems
    /// <see href="https://w3id.org/vair#ISOIECTR24372-2021"></see></summary>
    let ``ISOIECTR24372-2021`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTR24372-2021" |> NamespacedName

    /// <summary>
    /// Information technology — Artificial intelligence — Assessment of machine learning classification performance
    /// <see href="https://w3id.org/vair#ISOIECTS4213-2022"></see></summary>
    let ``ISOIECTS4213-2022`` =
        Namespaced_IRI.parse _namespace_name "ISOIECTS4213-2022" |> NamespacedName

    /// <summary>
    /// Identifying natural persons
    /// <see href="https://w3id.org/vair#IdentiftyingIndividuals"></see></summary>
    let IdentiftyingIndividuals =
        Namespaced_IRI.parse _namespace_name "IdentiftyingIndividuals" |> NamespacedName

    /// <summary>
    /// Image classification process that classifies object(s), pattern(s) or concept(s) in an image.
    /// <see href="https://w3id.org/vair#ImageRecognition"></see></summary>
    let ImageRecognition =
        Namespaced_IRI.parse _namespace_name "ImageRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Importer"></see>
    /// </summary>
    let Importer = Namespaced_IRI.parse _namespace_name "Importer" |> NamespacedName

    /// <summary>
    /// Inaccurate decision generated by the system.
    /// <see href="https://w3id.org/vair#InaccurateDecision"></see></summary>
    let InaccurateDecision =
        Namespaced_IRI.parse _namespace_name "InaccurateDecision" |> NamespacedName

    /// <summary>
    /// Inacurracy of the predictions, recommondations, or decisions produced by the system.
    /// <see href="https://w3id.org/vair#LowAccuracy"></see></summary>
    let LowAccuracy =
        Namespaced_IRI.parse _namespace_name "LowAccuracy" |> NamespacedName

    /// <summary>
    /// Inaccurate prediction generated by the system.
    /// <see href="https://w3id.org/vair#InaccuratePrediction"></see></summary>
    let InaccuratePrediction =
        Namespaced_IRI.parse _namespace_name "InaccuratePrediction" |> NamespacedName

    /// <summary>
    /// Inaccurate recommendation generated by the system.
    /// <see href="https://w3id.org/vair#InaccurateRecommendation"></see></summary>
    let InaccurateRecommendation =
        Namespaced_IRI.parse _namespace_name "InaccurateRecommendation" |> NamespacedName

    /// <summary>
    /// Inception occurs when one or more stakeholders decides to turn an idea into a tangible system
    /// <see href="https://w3id.org/vair#Inception"></see></summary>
    let Inception = Namespaced_IRI.parse _namespace_name "Inception" |> NamespacedName

    /// <summary>
    /// Incompleteness of testing data set
    /// <see href="https://w3id.org/vair#IncompleteTestData"></see></summary>
    let IncompleteTestData =
        Namespaced_IRI.parse _namespace_name "IncompleteTestData" |> NamespacedName

    /// <summary>
    /// Incompleteness of training data set
    /// <see href="https://w3id.org/vair#IncompleteTrainingData"></see></summary>
    let IncompleteTrainingData =
        Namespaced_IRI.parse _namespace_name "IncompleteTrainingData" |> NamespacedName

    /// <summary>
    /// Incompleteness of validation data set
    /// <see href="https://w3id.org/vair#IncompleteValidationData"></see></summary>
    let IncompleteValidationData =
        Namespaced_IRI.parse _namespace_name "IncompleteValidationData" |> NamespacedName

    /// <summary>
    /// A person who has entered into the territory of a State
    /// <see href="https://w3id.org/vair#IndividualEnteredState"></see></summary>
    let IndividualEnteredState =
        Namespaced_IRI.parse _namespace_name "IndividualEnteredState" |> NamespacedName

    /// <summary>
    /// A person who intends to enter into the territory of a State
    /// <see href="https://w3id.org/vair#IndividualIntendsToEnterState"></see></summary>
    let IndividualIntendsToEnterState =
        Namespaced_IRI.parse _namespace_name "IndividualIntendsToEnterState" |> NamespacedName

    /// <summary>
    /// Tthe inference of an algorithm or program featuring recursive calls or repetition control structures
    /// <see href="https://w3id.org/vair#InductiveProgramming"></see></summary>
    let InductiveProgramming =
        Namespaced_IRI.parse _namespace_name "InductiveProgramming" |> NamespacedName

    /// <summary>
    /// Techniques based on the use of knowledge bases
    /// <see href="https://w3id.org/vair#KnowledgeBasedTechnique"></see></summary>
    let KnowledgeBasedTechnique =
        Namespaced_IRI.parse _namespace_name "KnowledgeBasedTechnique" |> NamespacedName

    /// <summary>
    /// A robot for use in industrial automation applications.
    /// <see href="https://w3id.org/vair#IndustrialRobot"></see></summary>
    let IndustrialRobot =
        Namespaced_IRI.parse _namespace_name "IndustrialRobot" |> NamespacedName

    /// <summary>
    /// An automation system with actuators that performs intended tasks in the physical world, by means of sensing its environment and a software control system.
    /// <see href="https://w3id.org/vair#Robot"></see></summary>
    let Robot = Namespaced_IRI.parse _namespace_name "Robot" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vair#Inference"></see>
    /// </summary>
    let Inference = Namespaced_IRI.parse _namespace_name "Inference" |> NamespacedName

    /// <summary>
    /// Purpose of influencing
    /// <see href="https://w3id.org/vair#Influencing"></see></summary>
    let Influencing =
        Namespaced_IRI.parse _namespace_name "Influencing" |> NamespacedName

    /// <summary>
    /// Influencing the outcome of an election.
    /// <see href="https://w3id.org/vair#InfluencingElectionOutcome"></see></summary>
    let InfluencingElectionOutcome =
        Namespaced_IRI.parse _namespace_name "InfluencingElectionOutcome" |> NamespacedName

    /// <summary>
    /// Influencing the outcome of a referendum.
    /// <see href="https://w3id.org/vair#InfluencingReferendumOutcome"></see></summary>
    let InfluencingReferendumOutcome =
        Namespaced_IRI.parse _namespace_name "InfluencingReferendumOutcome" |> NamespacedName

    /// <summary>
    /// Purpose of influencing voting behaviour of people
    /// <see href="https://w3id.org/vair#InfluencingVotingBehaviour"></see></summary>
    let InfluencingVotingBehaviour =
        Namespaced_IRI.parse _namespace_name "InfluencingVotingBehaviour" |> NamespacedName

    /// <summary>
    /// Providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used.
    /// <see href="https://w3id.org/vair#InformationProvision"></see></summary>
    let InformationProvision =
        Namespaced_IRI.parse _namespace_name "InformationProvision" |> NamespacedName

    /// <summary>
    /// Organisational measures applied to control risk sources, risks, consequences, or impacts.
    /// <see href="https://w3id.org/vair#OrganisationalMeasure"></see></summary>
    let OrganisationalMeasure =
        Namespaced_IRI.parse _namespace_name "OrganisationalMeasure" |> NamespacedName

    /// <summary>
    /// Retrieving relevant documents or parts of documents from a dataset, typically based on keyword or natural language queries.
    /// <see href="https://w3id.org/vair#InformationRetrieval"></see></summary>
    let InformationRetrieval =
        Namespaced_IRI.parse _namespace_name "InformationRetrieval" |> NamespacedName

    /// <summary>
    /// Represents that a specific actor was informed that an AI system is in place.
    /// <see href="https://w3id.org/vair#InformedInvolvement"></see></summary>
    let InformedInvolvement =
        Namespaced_IRI.parse _namespace_name "InformedInvolvement" |> NamespacedName

    /// <summary>
    /// Instruction for installing an application.
    /// <see href="https://w3id.org/vair#InstallationInstruction"></see></summary>
    let InstallationInstruction =
        Namespaced_IRI.parse _namespace_name "InstallationInstruction" |> NamespacedName

    /// <summary>
    /// The information provided by the provider to inform the deployer of, in particular, an AI system’s intended purpose and proper use.
    /// <see href="https://w3id.org/vair#InstructionForUse"></see></summary>
    let InstructionForUse =
        Namespaced_IRI.parse _namespace_name "InstructionForUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#InstructionOfUse"></see>
    /// </summary>
    let InstructionOfUse =
        Namespaced_IRI.parse _namespace_name "InstructionOfUse" |> NamespacedName

    /// <summary>
    /// Lack of appropriate human oversight measures
    /// <see href="https://w3id.org/vair#InsufficientHumanOversightMeasure"></see></summary>
    let InsufficientHumanOversightMeasure =
        Namespaced_IRI.parse _namespace_name "InsufficientHumanOversightMeasure" |> NamespacedName

    /// <summary>
    /// Risk sources related with the organisation developing, deploying, or using AI.
    /// <see href="https://w3id.org/vair#OrganisationalRiskSource"></see></summary>
    let OrganisationalRiskSource =
        Namespaced_IRI.parse _namespace_name "OrganisationalRiskSource" |> NamespacedName

    /// <summary>
    /// Lack of appropriate instruction for use
    /// <see href="https://w3id.org/vair#InsufficientInstruction"></see></summary>
    let InsufficientInstruction =
        Namespaced_IRI.parse _namespace_name "InsufficientInstruction" |> NamespacedName

    /// <summary>
    /// An AI-based control system
    /// <see href="https://w3id.org/vair#IntelligentControlSystem"></see></summary>
    let IntelligentControlSystem =
        Namespaced_IRI.parse _namespace_name "IntelligentControlSystem" |> NamespacedName

    /// <summary>
    /// Represents involvement of a specific actor is as intended.
    /// <see href="https://w3id.org/vair#IntendedInvolvement"></see></summary>
    let IntendedInvolvement =
        Namespaced_IRI.parse _namespace_name "IntendedInvolvement" |> NamespacedName

    /// <summary>
    /// Interpreting facts
    /// <see href="https://w3id.org/vair#InterpretingFacts"></see></summary>
    let InterpretingFacts =
        Namespaced_IRI.parse _namespace_name "InterpretingFacts" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Law"></see>
    /// </summary>
    let Law = Namespaced_IRI.parse _namespace_name "Law" |> NamespacedName

    /// <summary>
    /// Interpreting the law
    /// <see href="https://w3id.org/vair#InterpretingLaw"></see></summary>
    let InterpretingLaw =
        Namespaced_IRI.parse _namespace_name "InterpretingLaw" |> NamespacedName

    /// <summary>
    /// Interrupting the system's operation
    /// <see href="https://w3id.org/vair#Interruption"></see></summary>
    let Interruption =
        Namespaced_IRI.parse _namespace_name "Interruption" |> NamespacedName

    /// <summary>
    /// Control related to operation of the system.
    /// <see href="https://w3id.org/vair#OperationalMeasure"></see></summary>
    let OperationalMeasure =
        Namespaced_IRI.parse _namespace_name "OperationalMeasure" |> NamespacedName

    /// <summary>
    /// Intervention of system's operation
    /// <see href="https://w3id.org/vair#Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// Investigation of criminal offences
    /// <see href="https://w3id.org/vair#InvestigatingCriminalOffences"></see></summary>
    let InvestigatingCriminalOffences =
        Namespaced_IRI.parse _namespace_name "InvestigatingCriminalOffences" |> NamespacedName

    /// <summary>
    /// A system providing functionalities of IoT.
    /// <see href="https://w3id.org/vair#IoTSystem"></see></summary>
    let IoTSystem = Namespaced_IRI.parse _namespace_name "IoTSystem" |> NamespacedName

    /// <summary>
    /// Use of irrelevant data for testing
    /// <see href="https://w3id.org/vair#IrrelevantTestData"></see></summary>
    let IrrelevantTestData =
        Namespaced_IRI.parse _namespace_name "IrrelevantTestData" |> NamespacedName

    /// <summary>
    /// Use of irrelevant data for training
    /// <see href="https://w3id.org/vair#IrrelevantTrainingData"></see></summary>
    let IrrelevantTrainingData =
        Namespaced_IRI.parse _namespace_name "IrrelevantTrainingData" |> NamespacedName

    /// <summary>
    /// Use of irrelevant data for validation
    /// <see href="https://w3id.org/vair#IrrelevantValidationData"></see></summary>
    let IrrelevantValidationData =
        Namespaced_IRI.parse _namespace_name "IrrelevantValidationData" |> NamespacedName

    /// <summary>
    /// A person who has made an application for employment
    /// <see href="https://w3id.org/vair#JobApplicant"></see></summary>
    let JobApplicant =
        Namespaced_IRI.parse _namespace_name "JobApplicant" |> NamespacedName

    /// <summary>
    /// Analysis of job applications
    /// <see href="https://w3id.org/vair#JobApplicationAnalysis"></see></summary>
    let JobApplicationAnalysis =
        Namespaced_IRI.parse _namespace_name "JobApplicationAnalysis" |> NamespacedName

    /// <summary>
    /// Filtering applications for recruitment or selection of natural persons
    /// <see href="https://w3id.org/vair#JobApplicationFiltering"></see></summary>
    let JobApplicationFiltering =
        Namespaced_IRI.parse _namespace_name "JobApplicationFiltering" |> NamespacedName

    /// <summary>
    /// Screening job applications
    /// <see href="https://w3id.org/vair#JobApplicationScreening"></see></summary>
    let JobApplicationScreening =
        Namespaced_IRI.parse _namespace_name "JobApplicationScreening" |> NamespacedName

    /// <summary>
    /// A person who is considered for employment.
    /// <see href="https://w3id.org/vair#JobCandidate"></see></summary>
    let JobCandidate =
        Namespaced_IRI.parse _namespace_name "JobCandidate" |> NamespacedName

    /// <summary>
    /// Selecting people for a job for a position
    /// <see href="https://w3id.org/vair#JobCandidateSelection"></see></summary>
    let JobCandidateSelection =
        Namespaced_IRI.parse _namespace_name "JobCandidateSelection" |> NamespacedName

    /// <summary>
    /// An authority to administer justice
    /// <see href="https://w3id.org/vair#JudicialAuthority"></see></summary>
    let JudicialAuthority =
        Namespaced_IRI.parse _namespace_name "JudicialAuthority" |> NamespacedName

    /// <summary>
    /// An entity that acts on behalf on judicial authorities
    /// <see href="https://w3id.org/vair#JudicialAuthorityAgent"></see></summary>
    let JudicialAuthorityAgent =
        Namespaced_IRI.parse _namespace_name "JudicialAuthorityAgent" |> NamespacedName

    /// <summary>
    /// Encoding knowledge in a formal language
    /// <see href="https://w3id.org/vair#KnowledgeRepresentation"></see></summary>
    let KnowledgeRepresentation =
        Namespaced_IRI.parse _namespace_name "KnowledgeRepresentation" |> NamespacedName

    /// <summary>
    /// Refers to lack transparency regarding AI, its development, deployement, or use
    /// <see href="https://w3id.org/vair#LackOfTransparency"></see></summary>
    let LackOfTransparency =
        Namespaced_IRI.parse _namespace_name "LackOfTransparency" |> NamespacedName

    /// <summary>
    /// Law enforcement authority means:
    /// (a) any public authority competent for the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security; or
    /// (b) any other body or entity entrusted by Member State law to exercise public authority and public powers for the purposes of the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security.
    /// <see href="https://w3id.org/vair#LawEnforcementAuthority"></see></summary>
    let LawEnforcementAuthority =
        Namespaced_IRI.parse _namespace_name "LawEnforcementAuthority" |> NamespacedName

    /// <summary>
    /// An entity that acts on behalf of law enforcement authorities.
    /// <see href="https://w3id.org/vair#LawEnforcementAuthorityAgent"></see></summary>
    let LawEnforcementAuthorityAgent =
        Namespaced_IRI.parse _namespace_name "LawEnforcementAuthorityAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#LearningTechnique"></see>
    /// </summary>
    let LearningTechnique =
        Namespaced_IRI.parse _namespace_name "LearningTechnique" |> NamespacedName

    /// <summary>
    /// A collection of pre-written code
    /// <see href="https://w3id.org/vair#Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName

    /// <summary>
    /// Detecting lies
    /// <see href="https://w3id.org/vair#LieDetection"></see></summary>
    let LieDetection =
        Namespaced_IRI.parse _namespace_name "LieDetection" |> NamespacedName

    /// <summary>
    /// Pricing in relation to natural persons in the case of life insurance
    /// <see href="https://w3id.org/vair#LifeInsurancePricing"></see></summary>
    let LifeInsurancePricing =
        Namespaced_IRI.parse _namespace_name "LifeInsurancePricing" |> NamespacedName

    /// <summary>
    /// Risk assessment in relation to natural persons in the case of life insurance
    /// <see href="https://w3id.org/vair#LifeInsuranceRiskAssessment"></see></summary>
    let LifeInsuranceRiskAssessment =
        Namespaced_IRI.parse _namespace_name "LifeInsuranceRiskAssessment" |> NamespacedName

    /// <summary>
    /// Refers to logging measure in place
    /// <see href="https://w3id.org/vair#LoggingMeasure"></see></summary>
    let LoggingMeasure =
        Namespaced_IRI.parse _namespace_name "LoggingMeasure" |> NamespacedName

    /// <summary>
    /// Refers to logic based techniques.
    /// <see href="https://w3id.org/vair#LogicBasedTechnique"></see></summary>
    let LogicBasedTechnique =
        Namespaced_IRI.parse _namespace_name "LogicBasedTechnique" |> NamespacedName

    /// <summary>
    /// type of recurrent neural network that processes sequential data with a satisfactory performance for both long and short span dependencies.
    /// <see href="https://w3id.org/vair#LongShortTermMemory"></see></summary>
    let LongShortTermMemory =
        Namespaced_IRI.parse _namespace_name "LongShortTermMemory" |> NamespacedName

    /// <summary>
    /// neural network in which outputs from both the previous layer and the previous processing step are fed into the current layer.
    /// <see href="https://w3id.org/vair#RecurrentNeuralNetwork"></see></summary>
    let RecurrentNeuralNetwork =
        Namespaced_IRI.parse _namespace_name "RecurrentNeuralNetwork" |> NamespacedName

    /// <summary>
    /// Risk sources related to performance
    /// <see href="https://w3id.org/vair#PerfomanceRiskSource"></see></summary>
    let PerfomanceRiskSource =
        Namespaced_IRI.parse _namespace_name "PerfomanceRiskSource" |> NamespacedName

    /// <summary>
    /// Lack of appropriate level of robustness
    /// <see href="https://w3id.org/vair#LowRobustness"></see></summary>
    let LowRobustness =
        Namespaced_IRI.parse _namespace_name "LowRobustness" |> NamespacedName

    /// <summary>
    /// Lack of appropriate level of security.
    /// <see href="https://w3id.org/vair#LowSecurity"></see></summary>
    let LowSecurity =
        Namespaced_IRI.parse _namespace_name "LowSecurity" |> NamespacedName

    /// <summary>
    /// An algorithm to determine parameters of a machine learning model from data according to given criteria.
    /// <see href="https://w3id.org/vair#MachineLearningAlgorithm"></see></summary>
    let MachineLearningAlgorithm =
        Namespaced_IRI.parse _namespace_name "MachineLearningAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#MachineLearningFramework"></see>
    /// </summary>
    let MachineLearningFramework =
        Namespaced_IRI.parse _namespace_name "MachineLearningFramework" |> NamespacedName

    /// <summary>
    /// Refers to liberaries for machine learning
    /// <see href="https://w3id.org/vair#MachineLearningLibrary"></see></summary>
    let MachineLearningLibrary =
        Namespaced_IRI.parse _namespace_name "MachineLearningLibrary" |> NamespacedName

    /// <summary>
    /// Mathematical construct that generates an inference or prediction  based on input data or information.
    /// <see href="https://w3id.org/vair#MachineLearningModel"></see></summary>
    let MachineLearningModel =
        Namespaced_IRI.parse _namespace_name "MachineLearningModel" |> NamespacedName

    /// <summary>
    /// Resource on which a ML model runs.
    /// <see href="https://w3id.org/vair#MachineLearningPlatform"></see></summary>
    let MachineLearningPlatform =
        Namespaced_IRI.parse _namespace_name "MachineLearningPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#MachineLearningTechnique"></see>
    /// </summary>
    let MachineLearningTechnique =
        Namespaced_IRI.parse _namespace_name "MachineLearningTechnique" |> NamespacedName

    /// <summary>
    /// Automated translation of text or speech from one natural language to another using a computer system.
    /// <see href="https://w3id.org/vair#MachineTranslation"></see></summary>
    let MachineTranslation =
        Namespaced_IRI.parse _namespace_name "MachineTranslation" |> NamespacedName

    /// <summary>
    /// Making decisions on termination of work-related contractual relationship
    /// Making Contract Termination Decision
    /// <see href="https://w3id.org/vair#MakingContractTerminationDecision"></see></summary>
    let MakingContractTerminationDecision =
        Namespaced_IRI.parse _namespace_name "MakingContractTerminationDecision" |> NamespacedName

    /// <summary>
    /// Making decisions affecting terms of work-related relationships
    /// <see href="https://w3id.org/vair#MakingDecisionOnTermsOfWorkRelatedRelations"></see></summary>
    let MakingDecisionOnTermsOfWorkRelatedRelations =
        Namespaced_IRI.parse _namespace_name "MakingDecisionOnTermsOfWorkRelatedRelations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#MakingPrediction"></see>
    /// </summary>
    let MakingPrediction =
        Namespaced_IRI.parse _namespace_name "MakingPrediction" |> NamespacedName

    /// <summary>
    /// Making decisions on promotion
    /// <see href="https://w3id.org/vair#MakingPromotionDecision"></see></summary>
    let MakingPromotionDecision =
        Namespaced_IRI.parse _namespace_name "MakingPromotionDecision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagementAndOperationOfSafety"></see>
    /// </summary>
    let ManagementAndOperationOfSafety =
        Namespaced_IRI.parse _namespace_name "ManagementAndOperationOfSafety" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Managing"></see>
    /// </summary>
    let Managing = Namespaced_IRI.parse _namespace_name "Managing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingCriticalDigitalInfrastructure"></see>
    /// </summary>
    let ManagingCriticalDigitalInfrastructure =
        Namespaced_IRI.parse _namespace_name "ManagingCriticalDigitalInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingRoadTraffic"></see>
    /// </summary>
    let ManagingRoadTraffic =
        Namespaced_IRI.parse _namespace_name "ManagingRoadTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfElectricity"></see>
    /// </summary>
    let ManagingSupplyOfElectricity =
        Namespaced_IRI.parse _namespace_name "ManagingSupplyOfElectricity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfGas"></see>
    /// </summary>
    let ManagingSupplyOfGas =
        Namespaced_IRI.parse _namespace_name "ManagingSupplyOfGas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfHeating"></see>
    /// </summary>
    let ManagingSupplyOfHeating =
        Namespaced_IRI.parse _namespace_name "ManagingSupplyOfHeating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfWater"></see>
    /// </summary>
    let ManagingSupplyOfWater =
        Namespaced_IRI.parse _namespace_name "ManagingSupplyOfWater" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#MarketSurveillanceAuthority"></see>
    /// </summary>
    let MarketSurveillanceAuthority =
        Namespaced_IRI.parse _namespace_name "MarketSurveillanceAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#MedicalAid"></see>
    /// </summary>
    let MedicalAid = Namespaced_IRI.parse _namespace_name "MedicalAid" |> NamespacedName

    /// <summary>
    /// Entity that provides medical aid
    /// <see href="https://w3id.org/vair#MedicalAidProvider"></see></summary>
    let MedicalAidProvider =
        Namespaced_IRI.parse _namespace_name "MedicalAidProvider" |> NamespacedName

    /// <summary>
    /// Control that is applied for mitigation purposes, e.g. ,mitigating risk sources, impacts, etc.
    /// <see href="https://w3id.org/vair#MitigationMeasure"></see></summary>
    let MitigationMeasure =
        Namespaced_IRI.parse _namespace_name "MitigationMeasure" |> NamespacedName

    /// <summary>
    /// A form of model documentation
    /// <see href="https://w3id.org/vair#ModelCard"></see></summary>
    let ModelCard = Namespaced_IRI.parse _namespace_name "ModelCard" |> NamespacedName

    /// <summary>
    /// An input, which seems normal for a human but is wrongly classified by ML models.
    /// <see href="https://w3id.org/vair#ModelEvasion"></see></summary>
    let ModelEvasion =
        Namespaced_IRI.parse _namespace_name "ModelEvasion" |> NamespacedName

    /// <summary>
    /// A type of attack to AI models, in which the access to a model is abused to infer information about the training data.
    /// <see href="https://w3id.org/vair#ModelInversion"></see></summary>
    let ModelInversion =
        Namespaced_IRI.parse _namespace_name "ModelInversion" |> NamespacedName

    /// <summary>
    /// Risk sources related to the AI model
    /// <see href="https://w3id.org/vair#ModelRiskSource"></see></summary>
    let ModelRiskSource =
        Namespaced_IRI.parse _namespace_name "ModelRiskSource" |> NamespacedName

    /// <summary>
    /// Observing and keeping track of something
    /// <see href="https://w3id.org/vair#Monitoring"></see></summary>
    let Monitoring = Namespaced_IRI.parse _namespace_name "Monitoring" |> NamespacedName

    /// <summary>
    /// Monitoring the behaviour of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#MonitoringEmployeeBehaviour"></see></summary>
    let MonitoringEmployeeBehaviour =
        Namespaced_IRI.parse _namespace_name "MonitoringEmployeeBehaviour" |> NamespacedName

    /// <summary>
    /// Monitoring the performance of persons in work-related relationships
    /// <see href="https://w3id.org/vair#MonitoringEmployeePerformance"></see></summary>
    let MonitoringEmployeePerformance =
        Namespaced_IRI.parse _namespace_name "MonitoringEmployeePerformance" |> NamespacedName

    /// <summary>
    /// Refers to monitoring measures
    /// <see href="https://w3id.org/vair#MonitoringMeasure"></see></summary>
    let MonitoringMeasure =
        Namespaced_IRI.parse _namespace_name "MonitoringMeasure" |> NamespacedName

    /// <summary>
    /// Monitoring prohibited behaviour during tests
    /// <see href="https://w3id.org/vair#MonitoringProhibitedBehaviourDuringTest"></see></summary>
    let MonitoringProhibitedBehaviourDuringTest =
        Namespaced_IRI.parse _namespace_name "MonitoringProhibitedBehaviourDuringTest" |> NamespacedName

    /// <summary>
    /// A system consisting of multiple AI agents.
    /// <see href="https://w3id.org/vair#MultiAgentSystem"></see></summary>
    let MultiAgentSystem =
        Namespaced_IRI.parse _namespace_name "MultiAgentSystem" |> NamespacedName

    /// <summary>
    /// Retrieving information from music.
    /// <see href="https://w3id.org/vair#MusicInformationRetrieval"></see></summary>
    let MusicInformationRetrieval =
        Namespaced_IRI.parse _namespace_name "MusicInformationRetrieval" |> NamespacedName

    /// <summary>
    /// Recognizing and labelling the denotational names of entities and their categories for sequences of words in a stream of text or speech.
    /// <see href="https://w3id.org/vair#NamedEntityRecognition"></see></summary>
    let NamedEntityRecognition =
        Namespaced_IRI.parse _namespace_name "NamedEntityRecognition" |> NamespacedName

    /// <summary>
    /// Type of AI system that is focused on defined tasks to address a specific problem.
    /// <see href="https://w3id.org/vair#NarrowAI"></see></summary>
    let NarrowAI = Namespaced_IRI.parse _namespace_name "NarrowAI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#NationalPublicAuthority"></see>
    /// </summary>
    let NationalPublicAuthority =
        Namespaced_IRI.parse _namespace_name "NationalPublicAuthority" |> NamespacedName

    /// <summary>
    /// Converting data carrying semantics into natural language.
    /// <see href="https://w3id.org/vair#NaturalLanguageGeneration"></see></summary>
    let NaturalLanguageGeneration =
        Namespaced_IRI.parse _namespace_name "NaturalLanguageGeneration" |> NamespacedName

    /// <summary>
    /// Information processing based upon natural language understanding or natural language generation.
    /// <see href="https://w3id.org/vair#NaturalLanguageProcessingSystem"></see></summary>
    let NaturalLanguageProcessingSystem =
        Namespaced_IRI.parse _namespace_name "NaturalLanguageProcessingSystem" |> NamespacedName

    /// <summary>
    /// An individual human being
    /// <see href="https://w3id.org/vair#NaturalPerson"></see></summary>
    let NaturalPerson =
        Namespaced_IRI.parse _namespace_name "NaturalPerson" |> NamespacedName

    /// <summary>
    /// The level of automation where an operator fully controls the system
    /// <see href="https://w3id.org/vair#NoAutomation"></see></summary>
    let NoAutomation =
        Namespaced_IRI.parse _namespace_name "NoAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#NotifiedBody"></see>
    /// </summary>
    let NotifiedBody =
        Namespaced_IRI.parse _namespace_name "NotifiedBody" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#NotifyingAuthority"></see>
    /// </summary>
    let NotifyingAuthority =
        Namespaced_IRI.parse _namespace_name "NotifyingAuthority" |> NamespacedName

    /// <summary>
    /// The capability to recognise objects
    /// <see href="https://w3id.org/vair#ObjectRecognition"></see></summary>
    let ObjectRecognition =
        Namespaced_IRI.parse _namespace_name "ObjectRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Operating"></see>
    /// </summary>
    let Operating = Namespaced_IRI.parse _namespace_name "Operating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingCriticalDigitalInfrastructure"></see>
    /// </summary>
    let OperatingCriticalDigitalInfrastructure =
        Namespaced_IRI.parse _namespace_name "OperatingCriticalDigitalInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingRoadTraffic"></see>
    /// </summary>
    let OperatingRoadTraffic =
        Namespaced_IRI.parse _namespace_name "OperatingRoadTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfElectricity"></see>
    /// </summary>
    let OperatingSupplyOfElectricity =
        Namespaced_IRI.parse _namespace_name "OperatingSupplyOfElectricity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfGas"></see>
    /// </summary>
    let OperatingSupplyOfGas =
        Namespaced_IRI.parse _namespace_name "OperatingSupplyOfGas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfHeating"></see>
    /// </summary>
    let OperatingSupplyOfHeating =
        Namespaced_IRI.parse _namespace_name "OperatingSupplyOfHeating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfWater"></see>
    /// </summary>
    let OperatingSupplyOfWater =
        Namespaced_IRI.parse _namespace_name "OperatingSupplyOfWater" |> NamespacedName

    /// <summary>
    /// Refers to the operation stage when an AI system is running and generally available for use.
    /// <see href="https://w3id.org/vair#Operation"></see></summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName

    /// <summary>
    /// Refers to optimisation Method
    /// <see href="https://w3id.org/vair#OptimisationMethod"></see></summary>
    let OptimisationMethod =
        Namespaced_IRI.parse _namespace_name "OptimisationMethod" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders can opt in  the system’s output.
    /// <see href="https://w3id.org/vair#OpttingInOutput"></see></summary>
    let OpttingInOutput =
        Namespaced_IRI.parse _namespace_name "OpttingInOutput" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders can opt out of the system’s output.
    /// <see href="https://w3id.org/vair#OpttingOutOfOutput"></see></summary>
    let OpttingOutOfOutput =
        Namespaced_IRI.parse _namespace_name "OpttingOutOfOutput" |> NamespacedName

    /// <summary>
    /// Tendency of automatically relying or over-relying on the output produced by an AI system
    /// <see href="https://w3id.org/vair#Overreliance"></see></summary>
    let Overreliance =
        Namespaced_IRI.parse _namespace_name "Overreliance" |> NamespacedName

    /// <summary>
    /// Overriding outcome of a system.
    /// <see href="https://w3id.org/vair#OverridingOutcome"></see></summary>
    let OverridingOutcome =
        Namespaced_IRI.parse _namespace_name "OverridingOutcome" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Outcome"></see>
    /// </summary>
    let Outcome = Namespaced_IRI.parse _namespace_name "Outcome" |> NamespacedName

    /// <summary>
    /// Assigning a category (e.g. verb, noun, adjective) to a word based on its grammatical properties.
    /// <see href="https://w3id.org/vair#PartOfSpeechTagging"></see></summary>
    let PartOfSpeechTagging =
        Namespaced_IRI.parse _namespace_name "PartOfSpeechTagging" |> NamespacedName

    /// <summary>
    /// The level of automation where some sub-functions of the system are fully automated while the system remains under the control of an external agent
    /// <see href="https://w3id.org/vair#PartialAutomation"></see></summary>
    let PartialAutomation =
        Namespaced_IRI.parse _namespace_name "PartialAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Passenger"></see>
    /// </summary>
    let Passenger = Namespaced_IRI.parse _namespace_name "Passenger" |> NamespacedName

    /// <summary>
    /// Represents passive interactation with an AI system.
    /// <see href="https://w3id.org/vair#PassiveInvolvement"></see></summary>
    let PassiveInvolvement =
        Namespaced_IRI.parse _namespace_name "PassiveInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PatternRecognition"></see>
    /// </summary>
    let PatternRecognition =
        Namespaced_IRI.parse _namespace_name "PatternRecognition" |> NamespacedName

    /// <summary>
    /// Performing background checks
    /// <see href="https://w3id.org/vair#PerformingBackgroundCheck"></see></summary>
    let PerformingBackgroundCheck =
        Namespaced_IRI.parse _namespace_name "PerformingBackgroundCheck" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Perpetrator"></see>
    /// </summary>
    let Perpetrator =
        Namespaced_IRI.parse _namespace_name "Perpetrator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PersonalData"></see>
    /// </summary>
    let PersonalData =
        Namespaced_IRI.parse _namespace_name "PersonalData" |> NamespacedName

    /// <summary>
    /// Capability of a system in determining and analysing people's personality traits
    /// <see href="https://w3id.org/vair#PersonalityTraitsAnalysis"></see></summary>
    let PersonalityTraitsAnalysis =
        Namespaced_IRI.parse _namespace_name "PersonalityTraitsAnalysis" |> NamespacedName

    /// <summary>
    /// Refers to physical health.
    /// <see href="https://w3id.org/vair#PhysicalHealth"></see></summary>
    let PhysicalHealth =
        Namespaced_IRI.parse _namespace_name "PhysicalHealth" |> NamespacedName

    /// <summary>
    /// Represent physical injuries caused by AI
    /// <see href="https://w3id.org/vair#PhysicalInjury"></see></summary>
    let PhysicalInjury =
        Namespaced_IRI.parse _namespace_name "PhysicalInjury" |> NamespacedName

    /// <summary>
    /// Placing targeted job advertisments
    /// <see href="https://w3id.org/vair#PlacingTargetedJobAdvert"></see></summary>
    let PlacingTargetedJobAdvert =
        Namespaced_IRI.parse _namespace_name "PlacingTargetedJobAdvert" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Platform"></see>
    /// </summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName
    /// <summary>
    /// Police
    /// <see href="https://w3id.org/vair#Police"></see></summary>
    let Police = Namespaced_IRI.parse _namespace_name "Police" |> NamespacedName

    /// <summary>
    /// Description of the post-market monitoring plan, as required by the AI Act.
    /// <see href="https://w3id.org/vair#PostMarketMonitoringPlan"></see></summary>
    let PostMarketMonitoringPlan =
        Namespaced_IRI.parse _namespace_name "PostMarketMonitoringPlan" |> NamespacedName

    /// <summary>
    /// Description of the post-market monitoring system in place, as required by the AI Act.
    /// <see href="https://w3id.org/vair#PostMarketMonitoringSystemDescription"></see></summary>
    let PostMarketMonitoringSystemDescription =
        Namespaced_IRI.parse _namespace_name "PostMarketMonitoringSystemDescription" |> NamespacedName

    /// <summary>
    /// A person who may have applied for employment.
    /// <see href="https://w3id.org/vair#PotentialJobApplicant"></see></summary>
    let PotentialJobApplicant =
        Namespaced_IRI.parse _namespace_name "PotentialJobApplicant" |> NamespacedName

    /// <summary>
    /// A person who may have applied for public services.
    /// <see href="https://w3id.org/vair#PotentialPublicServicesApplicant"></see></summary>
    let PotentialPublicServicesApplicant =
        Namespaced_IRI.parse _namespace_name "PotentialPublicServicesApplicant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PreTrainedModel"></see>
    /// </summary>
    let PreTrainedModel =
        Namespaced_IRI.parse _namespace_name "PreTrainedModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingOccurrenceOfCriminalOffence"></see>
    /// </summary>
    let PredictingOccurrenceOfCriminalOffence =
        Namespaced_IRI.parse _namespace_name "PredictingOccurrenceOfCriminalOffence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingRecidivism"></see>
    /// </summary>
    let PredictingRecidivism =
        Namespaced_IRI.parse _namespace_name "PredictingRecidivism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingReoccurrenceOfCriminalOffence"></see>
    /// </summary>
    let PredictingReoccurrenceOfCriminalOffence =
        Namespaced_IRI.parse _namespace_name "PredictingReoccurrenceOfCriminalOffence" |> NamespacedName

    /// <summary>
    /// Primary output of an AI system when provided with input data or information.
    /// <see href="https://w3id.org/vair#Prediction"></see></summary>
    let Prediction = Namespaced_IRI.parse _namespace_name "Prediction" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vair#Principle"></see>
    /// </summary>
    let Principle = Namespaced_IRI.parse _namespace_name "Principle" |> NamespacedName

    /// <summary>
    /// Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid
    /// <see href="https://w3id.org/vair#PrioritisationOfEmergencyService"></see></summary>
    let PrioritisationOfEmergencyService =
        Namespaced_IRI.parse _namespace_name "PrioritisationOfEmergencyService" |> NamespacedName

    /// <summary>
    /// Producing meaningful recommendations to users of the system
    /// <see href="https://w3id.org/vair#ProducingRecommendation"></see></summary>
    let ProducingRecommendation =
        Namespaced_IRI.parse _namespace_name "ProducingRecommendation" |> NamespacedName

    /// <summary>
    /// Refers to physical products.
    /// <see href="https://w3id.org/vair#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ProductManufacturer"></see>
    /// </summary>
    let ProductManufacturer =
        Namespaced_IRI.parse _namespace_name "ProductManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ProductionData"></see>
    /// </summary>
    let ProductionData =
        Namespaced_IRI.parse _namespace_name "ProductionData" |> NamespacedName

    /// <summary>
    /// Any form of automated processing of personal data consisting of the use of personal data to evaluate certain personal aspects relating to a natural person, in particular to analyse or predict aspects concerning that natural person’s performance at work, economic situation, health, personal preferences, interests, reliability, behaviour, location or movements.
    /// <see href="https://w3id.org/vair#Profiling"></see></summary>
    let Profiling = Namespaced_IRI.parse _namespace_name "Profiling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ProfilingPeople"></see>
    /// </summary>
    let ProfilingPeople =
        Namespaced_IRI.parse _namespace_name "ProfilingPeople" |> NamespacedName

    /// <summary>
    /// Prosecution of criminal offences
    /// <see href="https://w3id.org/vair#ProsecutingCriminalOffences"></see></summary>
    let ProsecutingCriminalOffences =
        Namespaced_IRI.parse _namespace_name "ProsecutingCriminalOffences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ProsecutionOfCriminalOffences"></see>
    /// </summary>
    let ProsecutionOfCriminalOffences =
        Namespaced_IRI.parse _namespace_name "ProsecutionOfCriminalOffences" |> NamespacedName

    /// <summary>
    /// Represents negative impacts of AI on psychological health
    /// <see href="https://w3id.org/vair#PsychologicalHarm"></see></summary>
    let PsychologicalHarm =
        Namespaced_IRI.parse _namespace_name "PsychologicalHarm" |> NamespacedName

    /// <summary>
    /// Refers to psychological health.
    /// <see href="https://w3id.org/vair#PsychologicalHealth"></see></summary>
    let PsychologicalHealth =
        Namespaced_IRI.parse _namespace_name "PsychologicalHealth" |> NamespacedName

    /// <summary>
    /// Refers to public authorities and bodies.
    /// <see href="https://w3id.org/vair#PublicAuthority"></see></summary>
    let PublicAuthority =
        Namespaced_IRI.parse _namespace_name "PublicAuthority" |> NamespacedName

    /// <summary>
    /// An entity that acts on behalf of public authorities.
    /// <see href="https://w3id.org/vair#PublicAuthorityAgent"></see></summary>
    let PublicAuthorityAgent =
        Namespaced_IRI.parse _namespace_name "PublicAuthorityAgent" |> NamespacedName

    /// <summary>
    /// A person who has applied for public services and benefits
    /// <see href="https://w3id.org/vair#PublicServicesApplicant"></see></summary>
    let PublicServicesApplicant =
        Namespaced_IRI.parse _namespace_name "PublicServicesApplicant" |> NamespacedName

    /// <summary>
    /// Person who is recipient of public services and benefits
    /// <see href="https://w3id.org/vair#PublicServicesRecipient"></see></summary>
    let PublicServicesRecipient =
        Namespaced_IRI.parse _namespace_name "PublicServicesRecipient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#PubliclyAccessibleSpace"></see>
    /// </summary>
    let PubliclyAccessibleSpace =
        Namespaced_IRI.parse _namespace_name "PubliclyAccessibleSpace" |> NamespacedName

    /// <summary>
    /// Determining the most appropriate answer to a question provided in natural language.
    /// <see href="https://w3id.org/vair#QuestionAnswering"></see></summary>
    let QuestionAnswering =
        Namespaced_IRI.parse _namespace_name "QuestionAnswering" |> NamespacedName

    /// <summary>
    /// After the operation and monitoring stage, based on the results of the work of the AI system, the need for a reassessment can arise.
    /// <see href="https://w3id.org/vair#ReEvaluation"></see></summary>
    let ReEvaluation =
        Namespaced_IRI.parse _namespace_name "ReEvaluation" |> NamespacedName

    /// <summary>
    /// Reclaiming natural persons healthcare services
    /// <see href="https://w3id.org/vair#ReclaimingHealthCareServices"></see></summary>
    let ReclaimingHealthCareServices =
        Namespaced_IRI.parse _namespace_name "ReclaimingHealthCareServices" |> NamespacedName

    /// <summary>
    /// Reclaiming essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#ReclaimingPublicAssistanceServices"></see></summary>
    let ReclaimingPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "ReclaimingPublicAssistanceServices" |> NamespacedName

    /// <summary>
    /// Recognising emotions of a natural person
    /// <see href="https://w3id.org/vair#RecognisingEmotions"></see></summary>
    let RecognisingEmotions =
        Namespaced_IRI.parse _namespace_name "RecognisingEmotions" |> NamespacedName

    /// <summary>
    /// Recognising natural persons
    /// <see href="https://w3id.org/vair#RecognisingIndividuals"></see></summary>
    let RecognisingIndividuals =
        Namespaced_IRI.parse _namespace_name "RecognisingIndividuals" |> NamespacedName

    /// <summary>
    /// Recommendation generated by an AI system
    /// <see href="https://w3id.org/vair#Recommendation"></see></summary>
    let Recommendation =
        Namespaced_IRI.parse _namespace_name "Recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#RecommenderSystem"></see>
    /// </summary>
    let RecommenderSystem =
        Namespaced_IRI.parse _namespace_name "RecommenderSystem" |> NamespacedName

    /// <summary>
    /// Recruiting people for a job
    /// <see href="https://w3id.org/vair#Recruiting"></see></summary>
    let Recruiting = Namespaced_IRI.parse _namespace_name "Recruiting" |> NamespacedName

    /// <summary>
    /// Reducing natural persons healthcare services
    /// <see href="https://w3id.org/vair#ReducingHealthCareServices"></see></summary>
    let ReducingHealthCareServices =
        Namespaced_IRI.parse _namespace_name "ReducingHealthCareServices" |> NamespacedName

    /// <summary>
    /// Reducing essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#ReducingPublicAssistanceServices"></see></summary>
    let ReducingPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "ReducingPublicAssistanceServices" |> NamespacedName

    /// <summary>
    /// Learning of an optimal sequence of actions to maximize a reward through interaction with an environment
    /// <see href="https://w3id.org/vair#ReinforcementLearning"></see></summary>
    let ReinforcementLearning =
        Namespaced_IRI.parse _namespace_name "ReinforcementLearning" |> NamespacedName

    /// <summary>
    /// Identifying relationships among entities mentioned in a text.
    /// <see href="https://w3id.org/vair#RelationshipExtraction"></see></summary>
    let RelationshipExtraction =
        Namespaced_IRI.parse _namespace_name "RelationshipExtraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#RemoteBiometricIdentification"></see>
    /// </summary>
    let RemoteBiometricIdentification =
        Namespaced_IRI.parse _namespace_name "RemoteBiometricIdentification" |> NamespacedName

    /// <summary>
    /// Refers to the identification of natural persons without their active involvement, typically at a distance
    /// <see href="https://w3id.org/vair#RemoteIdentification"></see></summary>
    let RemoteIdentification =
        Namespaced_IRI.parse _namespace_name "RemoteIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#RemoteIdentificationOfPeople"></see>
    /// </summary>
    let RemoteIdentificationOfPeople =
        Namespaced_IRI.parse _namespace_name "RemoteIdentificationOfPeople" |> NamespacedName

    /// <summary>
    /// Researching facts
    /// <see href="https://w3id.org/vair#ResearchingFacts"></see></summary>
    let ResearchingFacts =
        Namespaced_IRI.parse _namespace_name "ResearchingFacts" |> NamespacedName

    /// <summary>
    /// Researching the law
    /// <see href="https://w3id.org/vair#ResearchingLaw"></see></summary>
    let ResearchingLaw =
        Namespaced_IRI.parse _namespace_name "ResearchingLaw" |> NamespacedName

    /// <summary>
    /// A person who has applied for a residence permit
    /// <see href="https://w3id.org/vair#ResidencePermitApplicant"></see></summary>
    let ResidencePermitApplicant =
        Namespaced_IRI.parse _namespace_name "ResidencePermitApplicant" |> NamespacedName

    /// <summary>
    /// The stage the AI system become obsolete
    /// <see href="https://w3id.org/vair#Retirement"></see></summary>
    let Retirement = Namespaced_IRI.parse _namespace_name "Retirement" |> NamespacedName

    /// <summary>
    /// A mode of controllability that stakeholders can reverse the system’s output ex-post.
    /// <see href="https://w3id.org/vair#ReverseOutput"></see></summary>
    let ReverseOutput =
        Namespaced_IRI.parse _namespace_name "ReverseOutput" |> NamespacedName

    /// <summary>
    /// Reversing the outcome of a system.
    /// <see href="https://w3id.org/vair#ReversingOutcome"></see></summary>
    let ReversingOutcome =
        Namespaced_IRI.parse _namespace_name "ReversingOutcome" |> NamespacedName

    /// <summary>
    /// Revoking natural persons healthcare services
    /// <see href="https://w3id.org/vair#RevokingHealthCareServices"></see></summary>
    let RevokingHealthCareServices =
        Namespaced_IRI.parse _namespace_name "RevokingHealthCareServices" |> NamespacedName

    /// <summary>
    /// Revoking essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#RevokingPublicAssistanceServices"></see></summary>
    let RevokingPublicAssistanceServices =
        Namespaced_IRI.parse _namespace_name "RevokingPublicAssistanceServices" |> NamespacedName

    /// <summary>
    /// Refers to fundamental rights.
    /// <see href="https://w3id.org/vair#Right"></see></summary>
    let Right = Namespaced_IRI.parse _namespace_name "Right" |> NamespacedName

    /// <summary>
    /// Refers to the fundamental right to non-discrimination
    /// <see href="https://w3id.org/vair#RightToNondiscrimination"></see></summary>
    let RightToNondiscrimination =
        Namespaced_IRI.parse _namespace_name "RightToNondiscrimination" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#RobotSystem"></see>
    /// </summary>
    let RobotSystem =
        Namespaced_IRI.parse _namespace_name "RobotSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SVM"></see>
    /// </summary>
    let SVM = Namespaced_IRI.parse _namespace_name "SVM" |> NamespacedName

    /// <summary>
    /// a machine learning algorithm that finds decision boundaries with maximal margins.
    /// <see href="https://w3id.org/vair#SupportVectorMachine"></see></summary>
    let SupportVectorMachine =
        Namespaced_IRI.parse _namespace_name "SupportVectorMachine" |> NamespacedName

    /// <summary>
    /// Refers to the state of safety.
    /// <see href="https://w3id.org/vair#Safety"></see></summary>
    let Safety = Namespaced_IRI.parse _namespace_name "Safety" |> NamespacedName

    /// <summary>
    /// Component of a product or of an AI system which fulfils a safety function for that product or AI system, or the failure or malfunctioning of which endangers the health and safety of persons or property
    /// <see href="https://w3id.org/vair#SafetyComponent"></see></summary>
    let SafetyComponent =
        Namespaced_IRI.parse _namespace_name "SafetyComponent" |> NamespacedName

    /// <summary>
    /// Refers to statistical-based search Methods
    /// <see href="https://w3id.org/vair#SearchMethod"></see></summary>
    let SearchMethod =
        Namespaced_IRI.parse _namespace_name "SearchMethod" |> NamespacedName

    /// <summary>
    /// Refers to security measures
    /// <see href="https://w3id.org/vair#SecurityMeasure"></see></summary>
    let SecurityMeasure =
        Namespaced_IRI.parse _namespace_name "SecurityMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SelectingPeople"></see>
    /// </summary>
    let SelectingPeople =
        Namespaced_IRI.parse _namespace_name "SelectingPeople" |> NamespacedName

    /// <summary>
    /// Machine learning that makes use of both labelled and unlabelled data during training
    /// <see href="https://w3id.org/vair#SemiSupervisedLearning"></see></summary>
    let SemiSupervisedLearning =
        Namespaced_IRI.parse _namespace_name "SemiSupervisedLearning" |> NamespacedName

    /// <summary>
    /// The capability of infering sensitive or protected attributes or characteristics
    /// <see href="https://w3id.org/vair#SensitiveAttributeInference"></see></summary>
    let SensitiveAttributeInference =
        Namespaced_IRI.parse _namespace_name "SensitiveAttributeInference" |> NamespacedName

    /// <summary>
    /// Computationally identifying and categorizing opinions expressed in a piece of text, speech or image, to determine a range of feeling such as from positive to negative.
    /// <see href="https://w3id.org/vair#SentimentAnalysis"></see></summary>
    let SentimentAnalysis =
        Namespaced_IRI.parse _namespace_name "SentimentAnalysis" |> NamespacedName

    /// <summary>
    /// Refers to system provided as a service
    /// <see href="https://w3id.org/vair#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// A robot in personal use or professional use that performs useful tasks for humans or equipment.
    /// <see href="https://w3id.org/vair#ServiceRobot"></see></summary>
    let ServiceRobot =
        Namespaced_IRI.parse _namespace_name "ServiceRobot" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function
    /// <see href="https://w3id.org/vair#ServingSafetyFunction"></see></summary>
    let ServingSafetyFunction =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunction" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of services
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagement"></see></summary>
    let ServingSafetyFunctionInManagement =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagement" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of critical digital infrastructure
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure"></see></summary>
    let ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of road traffic
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfRoadTraffic"></see></summary>
    let ServingSafetyFunctionInManagementOfRoadTraffic =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfRoadTraffic" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of the supply of electricity
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfElectricity =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfTheSupplyOfElectricity" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of the supply of gas
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfGas =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfTheSupplyOfGas" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of the supply of heating
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfHeating =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfTheSupplyOfHeating" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in management of the supply of water
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfWater =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInManagementOfTheSupplyOfWater" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of services
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperation"></see></summary>
    let ServingSafetyFunctionInOperation =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperation" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of critical digital infrastructure
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure"></see></summary>
    let ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of road traffic
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfRoadTraffic"></see></summary>
    let ServingSafetyFunctionInOperationOfRoadTraffic =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfRoadTraffic" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of electricity
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfElectricity =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfTheSupplyOfElectricity" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of gas
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfGas =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfTheSupplyOfGas" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of heating
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfHeating =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfTheSupplyOfHeating" |> NamespacedName

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of water
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfWater =
        Namespaced_IRI.parse _namespace_name "ServingSafetyFunctionInOperationOfTheSupplyOfWater" |> NamespacedName

    /// <summary>
    /// Alternative dispute resolution
    /// <see href="https://w3id.org/vair#SettlingDispute"></see></summary>
    let SettlingDispute =
        Namespaced_IRI.parse _namespace_name "SettlingDispute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SmallScaleProvider"></see>
    /// </summary>
    let SmallScaleProvider =
        Namespaced_IRI.parse _namespace_name "SmallScaleProvider" |> NamespacedName

    /// <summary>
    /// Robots with social interaction functions.
    /// <see href="https://w3id.org/vair#SocialRobot"></see></summary>
    let SocialRobot =
        Namespaced_IRI.parse _namespace_name "SocialRobot" |> NamespacedName

    /// <summary>
    /// Refers to a stand alone software system
    /// <see href="https://w3id.org/vair#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SoundEventRecognition"></see>
    /// </summary>
    let SoundEventRecognition =
        Namespaced_IRI.parse _namespace_name "SoundEventRecognition" |> NamespacedName

    /// <summary>
    /// Extracting individual sound from audio recordings.
    /// <see href="https://w3id.org/vair#SoundSourceSeparation"></see></summary>
    let SoundSourceSeparation =
        Namespaced_IRI.parse _namespace_name "SoundSourceSeparation" |> NamespacedName

    /// <summary>
    /// Generation of artificial sound.
    /// <see href="https://w3id.org/vair#SoundSynthesis"></see></summary>
    let SoundSynthesis =
        Namespaced_IRI.parse _namespace_name "SoundSynthesis" |> NamespacedName

    /// <summary>
    /// Recognising speaker in audio recordings.
    /// <see href="https://w3id.org/vair#SpeakerRecognition"></see></summary>
    let SpeakerRecognition =
        Namespaced_IRI.parse _namespace_name "SpeakerRecognition" |> NamespacedName

    /// <summary>
    /// Converting a speech signal to a representation of the content of the speech.
    /// <see href="https://w3id.org/vair#SpeechRecognition"></see></summary>
    let SpeechRecognition =
        Namespaced_IRI.parse _namespace_name "SpeechRecognition" |> NamespacedName

    /// <summary>
    /// Generation of artificial speech.
    /// <see href="https://w3id.org/vair#SpeechSynthesis"></see></summary>
    let SpeechSynthesis =
        Namespaced_IRI.parse _namespace_name "SpeechSynthesis" |> NamespacedName

    /// <summary>
    /// Incompetence of staff such as human oversight actors
    /// <see href="https://w3id.org/vair#StaffIncompetence"></see></summary>
    let StaffIncompetence =
        Namespaced_IRI.parse _namespace_name "StaffIncompetence" |> NamespacedName

    /// <summary>
    /// Machine learning that makes only use of labelled data during training
    /// <see href="https://w3id.org/vair#SupervisedLearning"></see></summary>
    let SupervisedLearning =
        Namespaced_IRI.parse _namespace_name "SupervisedLearning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Suspect"></see>
    /// </summary>
    let Suspect = Namespaced_IRI.parse _namespace_name "Suspect" |> NamespacedName

    /// <summary>
    /// Reasoning based on the knowledge encoded in a formal language
    /// <see href="https://w3id.org/vair#SymbolicReasoning"></see></summary>
    let SymbolicReasoning =
        Namespaced_IRI.parse _namespace_name "SymbolicReasoning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SystemArchitecture"></see>
    /// </summary>
    let SystemArchitecture =
        Namespaced_IRI.parse _namespace_name "SystemArchitecture" |> NamespacedName

    /// <summary>
    /// Documentation specifying software architecture.
    /// <see href="https://w3id.org/vair#SystemArchitectureDocumentation"></see></summary>
    let SystemArchitectureDocumentation =
        Namespaced_IRI.parse _namespace_name "SystemArchitectureDocumentation" |> NamespacedName

    /// <summary>
    /// Risk sources related to the AI system
    /// <see href="https://w3id.org/vair#SystemRiskSource"></see></summary>
    let SystemRiskSource =
        Namespaced_IRI.parse _namespace_name "SystemRiskSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#SystemVulnerability"></see>
    /// </summary>
    let SystemVulnerability =
        Namespaced_IRI.parse _namespace_name "SystemVulnerability" |> NamespacedName

    /// <summary>
    /// Documentation required by the AI Act, Article 11.
    /// <see href="https://w3id.org/vair#TechnicalDocumentation"></see></summary>
    let TechnicalDocumentation =
        Namespaced_IRI.parse _namespace_name "TechnicalDocumentation" |> NamespacedName

    /// <summary>
    /// Refers to technical measures
    /// <see href="https://w3id.org/vair#TechnicalMeasure"></see></summary>
    let TechnicalMeasure =
        Namespaced_IRI.parse _namespace_name "TechnicalMeasure" |> NamespacedName

    /// <summary>
    /// An AI application-specific integrated circuit developed by Google.
    /// <see href="https://w3id.org/vair#TensorProcessingUnit"></see></summary>
    let TensorProcessingUnit =
        Namespaced_IRI.parse _namespace_name "TensorProcessingUnit" |> NamespacedName

    /// <summary>
    /// Log of the tests performed.
    /// <see href="https://w3id.org/vair#TestLog"></see></summary>
    let TestLog = Namespaced_IRI.parse _namespace_name "TestLog" |> NamespacedName
    /// <summary>
    /// A document that includes a summary of test activities and their results.
    /// <see href="https://w3id.org/vair#TestReport"></see></summary>
    let TestReport = Namespaced_IRI.parse _namespace_name "TestReport" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vair#Testing"></see>
    /// </summary>
    let Testing = Namespaced_IRI.parse _namespace_name "Testing" |> NamespacedName
    /// <summary>
    /// Refers to a software tool
    /// Tool
    /// <see href="https://w3id.org/vair#Tool"></see></summary>
    let Tool = Namespaced_IRI.parse _namespace_name "Tool" |> NamespacedName

    /// <summary>
    /// Model resulted from model training.
    /// <see href="https://w3id.org/vair#TrainedModel"></see></summary>
    let TrainedModel =
        Namespaced_IRI.parse _namespace_name "TrainedModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#ModelTraning"></see>
    /// </summary>
    let ModelTraning =
        Namespaced_IRI.parse _namespace_name "ModelTraning" |> NamespacedName

    /// <summary>
    /// Refers to transparency measures
    /// <see href="https://w3id.org/vair#TransparencyMeasure"></see></summary>
    let TransparencyMeasure =
        Namespaced_IRI.parse _namespace_name "TransparencyMeasure" |> NamespacedName

    /// <summary>
    /// Use of datasets that are not available
    /// <see href="https://w3id.org/vair#UnavailabilityOfData"></see></summary>
    let UnavailabilityOfData =
        Namespaced_IRI.parse _namespace_name "UnavailabilityOfData" |> NamespacedName

    /// <summary>
    /// Represents that a specific actor was not informed that an AI system is in place.
    /// <see href="https://w3id.org/vair#UninformedInvolvement"></see></summary>
    let UninformedInvolvement =
        Namespaced_IRI.parse _namespace_name "UninformedInvolvement" |> NamespacedName

    /// <summary>
    /// Represents unintended involvement of a specific actor.
    /// <see href="https://w3id.org/vair#UnintendedInvolvement"></see></summary>
    let UnintendedInvolvement =
        Namespaced_IRI.parse _namespace_name "UnintendedInvolvement" |> NamespacedName

    /// <summary>
    /// Use of unrepresentative  data for testing
    /// <see href="https://w3id.org/vair#UnrepresentativeTestData"></see></summary>
    let UnrepresentativeTestData =
        Namespaced_IRI.parse _namespace_name "UnrepresentativeTestData" |> NamespacedName

    /// <summary>
    /// Use of unrepresentative data for training
    /// <see href="https://w3id.org/vair#UnrepresentativeTrainingData"></see></summary>
    let UnrepresentativeTrainingData =
        Namespaced_IRI.parse _namespace_name "UnrepresentativeTrainingData" |> NamespacedName

    /// <summary>
    /// Use of unrepresentative data for validation
    /// <see href="https://w3id.org/vair#UnrepresentativeValidationData"></see></summary>
    let UnrepresentativeValidationData =
        Namespaced_IRI.parse _namespace_name "UnrepresentativeValidationData" |> NamespacedName

    /// <summary>
    /// Machine learning that makes only use of unlabelled data during training.
    /// <see href="https://w3id.org/vair#UnsupervisedLearning"></see></summary>
    let UnsupervisedLearning =
        Namespaced_IRI.parse _namespace_name "UnsupervisedLearning" |> NamespacedName

    /// <summary>
    /// Providing training to staff, users, etc.
    /// <see href="https://w3id.org/vair#UserTraining"></see></summary>
    let UserTraining =
        Namespaced_IRI.parse _namespace_name "UserTraining" |> NamespacedName

    /// <summary>
    /// Validating that the AI system from the design and development stage works according to requirements and meets objectives.
    /// <see href="https://w3id.org/vair#Validation"></see></summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName

    /// <summary>
    /// Verifying the AI system from the design and development stage works according to requirements and meets objectives.
    /// <see href="https://w3id.org/vair#Verification"></see></summary>
    let Verification =
        Namespaced_IRI.parse _namespace_name "Verification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#VerificationOfMigrationSeekerClaims"></see>
    /// </summary>
    let VerificationOfMigrationSeekerClaims =
        Namespaced_IRI.parse _namespace_name "VerificationOfMigrationSeekerClaims" |> NamespacedName

    /// <summary>
    /// Verifying of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features.
    /// <see href="https://w3id.org/vair#VerifyingAuthenticityOfTravelDocument"></see></summary>
    let VerifyingAuthenticityOfTravelDocument =
        Namespaced_IRI.parse _namespace_name "VerifyingAuthenticityOfTravelDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vair#Victim"></see>
    /// </summary>
    let Victim = Namespaced_IRI.parse _namespace_name "Victim" |> NamespacedName

    /// <summary>
    /// A person who has applied for a visa
    /// <see href="https://w3id.org/vair#VisaApplicant"></see></summary>
    let VisaApplicant =
        Namespaced_IRI.parse _namespace_name "VisaApplicant" |> NamespacedName

    /// <summary>
    /// Vocational training institution at any level
    /// <see href="https://w3id.org/vair#VocationalTrainingInstitution"></see></summary>
    let VocationalTrainingInstitution =
        Namespaced_IRI.parse _namespace_name "VocationalTrainingInstitution" |> NamespacedName

    /// <summary>
    /// Refers to the wrong choice made in the selecting datasets.
    /// <see href="https://w3id.org/vair#WrongDataDesignChoice"></see></summary>
    let WrongDataDesignChoice =
        Namespaced_IRI.parse _namespace_name "WrongDataDesignChoice" |> NamespacedName
