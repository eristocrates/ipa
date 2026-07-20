namespace https.w3id.org.vair.hash

open DoxAletheia

module vair =
    let _namespace_name = "https://w3id.org/vair#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents a concept in VAIR
    /// <see href="https://w3id.org/vair#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.
    /// <see href="https://w3id.org/vair#AGI"></see></summary>
    let AGI = _prefix "AGI"
    /// <summary>
    /// Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.
    /// <see href="https://w3id.org/vair#GeneralAI"></see></summary>
    let GeneralAI = _prefix "GeneralAI"
    /// <summary>
    /// A form of AI documentation
    /// <see href="https://w3id.org/vair#AICards"></see></summary>
    let AICards = _prefix "AICards"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AIComponent"></see>
    /// </summary>
    let AIComponent = _prefix "AIComponent"
    /// <summary>
    /// Action performed by a system.
    /// <see href="https://w3id.org/vair#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The capability to recognise actions
    /// <see href="https://w3id.org/vair#ActionRecognition"></see></summary>
    let ActionRecognition = _prefix "ActionRecognition"
    /// <summary>
    /// Capability of a functional unit to acquire, process and interpret data representing images or video.
    /// <see href="https://w3id.org/vair#ComputerVision"></see></summary>
    let ComputerVision = _prefix "ComputerVision"
    /// <summary>
    /// Represents active interactation with an AI system.
    /// <see href="https://w3id.org/vair#ActiveInvolvement"></see></summary>
    let ActiveInvolvement = _prefix "ActiveInvolvement"

    /// <summary>
    /// Activities related to administration of democratic processes
    /// <see href="https://w3id.org/vair#AdministrationOfDemocraticProcesses"></see></summary>
    let AdministrationOfDemocraticProcesses =
        _prefix "AdministrationOfDemocraticProcesses"

    /// <summary>
    /// Activities related to administration of justice.
    /// <see href="https://w3id.org/vair#AdministrationOfJustice"></see></summary>
    let AdministrationOfJustice = _prefix "AdministrationOfJustice"
    /// <summary>
    /// Inputs designed to cause the model to make a mistake
    /// <see href="https://w3id.org/vair#AdversarialAttack"></see></summary>
    let AdversarialAttack = _prefix "AdversarialAttack"
    /// <summary>
    /// Malicious attempts to exploit vulnerabilities
    /// <see href="https://w3id.org/vair#Attack"></see></summary>
    let Attack = _prefix "Attack"
    /// <summary>
    /// physical, mathematical or otherwise logical representation of a system, entity, phenomenon, process or data.
    /// <see href="https://w3id.org/vair#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Defines a set of instructions
    /// <see href="https://w3id.org/vair#Algorithm"></see></summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    /// Assignment of tasks to persons
    /// <see href="https://w3id.org/vair#AllocatingTasks"></see></summary>
    let AllocatingTasks = _prefix "AllocatingTasks"
    /// <summary>
    /// Planning purposes
    /// <see href="https://w3id.org/vair#Planning"></see></summary>
    let Planning = _prefix "Planning"
    /// <summary>
    /// Resource on which an application runs.
    /// <see href="https://w3id.org/vair#ApplicationPlatform"></see></summary>
    let ApplicationPlatform = _prefix "ApplicationPlatform"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ApplicationScreening"></see>
    /// </summary>
    let ApplicationScreening = _prefix "ApplicationScreening"

    /// <summary>
    /// An integrated circuit chip customized for a particular use.
    /// <see href="https://w3id.org/vair#ApplicationSpecificIntegratedCircuit"></see></summary>
    let ApplicationSpecificIntegratedCircuit =
        _prefix "ApplicationSpecificIntegratedCircuit"

    /// <summary>
    /// Physical equipment/components
    /// <see href="https://w3id.org/vair#Hardware"></see></summary>
    let Hardware = _prefix "Hardware"
    /// <summary>
    /// Applying the law to a concrete set of facts
    /// <see href="https://w3id.org/vair#ApplyingTheLawToFacts"></see></summary>
    let ApplyingTheLawToFacts = _prefix "ApplyingTheLawToFacts"
    /// <summary>
    /// Capturing knowledge and acquiring new knowledge
    /// <see href="https://w3id.org/vair#KnowledgeReasoning"></see></summary>
    let KnowledgeReasoning = _prefix "KnowledgeReasoning"
    /// <summary>
    /// Approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk.
    /// <see href="https://w3id.org/vair#Approval"></see></summary>
    let Approval = _prefix "Approval"
    /// <summary>
    /// Controls implemented manually by human actors
    /// <see href="https://w3id.org/vair#ManualControl"></see></summary>
    let ManualControl = _prefix "ManualControl"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AssesingStudent"></see>
    /// </summary>
    let AssesingStudent = _prefix "AssesingStudent"

    /// <summary>
    /// Assessing the appropriate level of education that an individual will be able to access
    /// <see href="https://w3id.org/vair#AssessingAccessibleLevelOfEducation"></see></summary>
    let AssessingAccessibleLevelOfEducation =
        _prefix "AssessingAccessibleLevelOfEducation"

    /// <summary>
    /// Assessment and evaluation
    /// <see href="https://w3id.org/vair#Assessment"></see></summary>
    let Assessment = _prefix "Assessment"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AssessingAdmissionTest"></see>
    /// </summary>
    let AssessingAdmissionTest = _prefix "AssessingAdmissionTest"
    /// <summary>
    /// Evaluation the creditworthiness of natural persons or establishing their credit score
    /// <see href="https://w3id.org/vair#AssessingCreditworthiness"></see></summary>
    let AssessingCreditworthiness = _prefix "AssessingCreditworthiness"
    /// <summary>
    /// Assessing health risk posed by a person
    /// <see href="https://w3id.org/vair#AssessingHealthRisk"></see></summary>
    let AssessingHealthRisk = _prefix "AssessingHealthRisk"
    /// <summary>
    /// Assessing a risk, e.g. a security risk, a risk of irregular migration, or a health risk, posed by a natural person
    /// <see href="https://w3id.org/vair#AssessingPeopleRelatedRisk"></see></summary>
    let AssessingPeopleRelatedRisk = _prefix "AssessingPeopleRelatedRisk"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AssessingImmigrationEligibility"></see>
    /// </summary>
    let AssessingImmigrationEligibility = _prefix "AssessingImmigrationEligibility"
    /// <summary>
    /// Assessing the appropriate level of education that an individual will receive
    /// <see href="https://w3id.org/vair#AssessingLevelOfEducation"></see></summary>
    let AssessingLevelOfEducation = _prefix "AssessingLevelOfEducation"
    /// <summary>
    /// Assessing past criminal behaviour of natural persons or groups
    /// <see href="https://w3id.org/vair#AssessingPastCriminalBehaviour"></see></summary>
    let AssessingPastCriminalBehaviour = _prefix "AssessingPastCriminalBehaviour"
    /// <summary>
    /// Activities related to enforcing the law.
    /// <see href="https://w3id.org/vair#LawEnforcement"></see></summary>
    let LawEnforcement = _prefix "LawEnforcement"
    /// <summary>
    /// Assessing the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences
    /// <see href="https://w3id.org/vair#IndividualRiskAssessment"></see></summary>
    let IndividualRiskAssessment = _prefix "IndividualRiskAssessment"
    /// <summary>
    /// Assessing personality of natural persons or groups
    /// <see href="https://w3id.org/vair#AssessingPersonalityTraits"></see></summary>
    let AssessingPersonalityTraits = _prefix "AssessingPersonalityTraits"

    /// <summary>
    /// Assessing risk of a natural person becoming the victim of criminal offences
    /// <see href="https://w3id.org/vair#AssessingRiskOfBecomingVictimOfCrime"></see></summary>
    let AssessingRiskOfBecomingVictimOfCrime =
        _prefix "AssessingRiskOfBecomingVictimOfCrime"

    /// <summary>
    /// Assessing risk of irregular immigration posed by a person
    /// <see href="https://w3id.org/vair#AssessingRiskOfIrregularImmigration"></see></summary>
    let AssessingRiskOfIrregularImmigration =
        _prefix "AssessingRiskOfIrregularImmigration"

    /// <summary>
    /// Activities related to managing migration.
    /// <see href="https://w3id.org/vair#MigrationManagement"></see></summary>
    let MigrationManagement = _prefix "MigrationManagement"
    /// <summary>
    /// Assessing the risk of a natural person offending
    /// <see href="https://w3id.org/vair#AssessingRiskOfOffending"></see></summary>
    let AssessingRiskOfOffending = _prefix "AssessingRiskOfOffending"
    /// <summary>
    /// Assessing the risk of a natural person re-offending
    /// <see href="https://w3id.org/vair#AssessingRiskOfReoffending"></see></summary>
    let AssessingRiskOfReoffending = _prefix "AssessingRiskOfReoffending"
    /// <summary>
    /// Assess security risk posed by a person
    /// <see href="https://w3id.org/vair#AssessingSecurityRisk"></see></summary>
    let AssessingSecurityRisk = _prefix "AssessingSecurityRisk"

    /// <summary>
    /// Assigning natural persons to educational institutions at all levels.
    /// <see href="https://w3id.org/vair#AssigningPersonsToEducationalInstitutions"></see></summary>
    let AssigningPersonsToEducationalInstitutions =
        _prefix "AssigningPersonsToEducationalInstitutions"

    /// <summary>
    /// Indicates the sector that offers education or vocational training at any level or for any profession.
    /// <see href="https://w3id.org/vair#Education"></see></summary>
    let Education = _prefix "Education"

    /// <summary>
    /// Assigning natural persons to vocational training institutions at all levels.
    /// <see href="https://w3id.org/vair#AssigningPersonsToVocationalTrainingInstitutions"></see></summary>
    let AssigningPersonsToVocationalTrainingInstitutions =
        _prefix "AssigningPersonsToVocationalTrainingInstitutions"

    /// <summary>
    /// The level of automation where the system assists an operator
    /// <see href="https://w3id.org/vair#AssistiveAutomation"></see></summary>
    let AssistiveAutomation = _prefix "AssistiveAutomation"
    /// <summary>
    /// Activities related to asylum management
    /// <see href="https://w3id.org/vair#AsylumManagement"></see></summary>
    let AsylumManagement = _prefix "AsylumManagement"
    /// <summary>
    /// A person who has applied for asylum
    /// <see href="https://w3id.org/vair#AsylumSeeker"></see></summary>
    let AsylumSeeker = _prefix "AsylumSeeker"
    /// <summary>
    /// The capability to process audio recordings.
    /// <see href="https://w3id.org/vair#AudioProcessing"></see></summary>
    let AudioProcessing = _prefix "AudioProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AuthorisedRepresentative"></see>
    /// </summary>
    let AuthorisedRepresentative = _prefix "AuthorisedRepresentative"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Authority"></see>
    /// </summary>
    let Authority = _prefix "Authority"
    /// <summary>
    /// Shortening a portion of natural language content or text while retaining important semantic information.
    /// <see href="https://w3id.org/vair#AutomaticSummarisation"></see></summary>
    let AutomaticSummarisation = _prefix "AutomaticSummarisation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#AutonomousSystem"></see>
    /// </summary>
    let AutonomousSystem = _prefix "AutonomousSystem"
    /// <summary>
    /// The level of automation where the system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.
    /// <see href="https://w3id.org/vair#Autonomy"></see></summary>
    let Autonomy = _prefix "Autonomy"
    /// <summary>
    /// Refers to Bayesian estimation approach
    /// <see href="https://w3id.org/vair#BayesianEstimation"></see></summary>
    let BayesianEstimation = _prefix "BayesianEstimation"
    /// <summary>
    /// Refers to techniques that are based on statistics
    /// <see href="https://w3id.org/vair#StatisticalTechnique"></see></summary>
    let StatisticalTechnique = _prefix "StatisticalTechnique"
    /// <summary>
    /// Probabilistic model  that uses Bayesian inference  for probability computations using a directed acyclic graph.
    /// <see href="https://w3id.org/vair#BayesianNetwork"></see></summary>
    let BayesianNetwork = _prefix "BayesianNetwork"
    /// <summary>
    /// Refers to Bayesian optimisation technique.
    /// <see href="https://w3id.org/vair#BayesianOptimisation"></see></summary>
    let BayesianOptimisation = _prefix "BayesianOptimisation"
    /// <summary>
    /// Capability of a system in analysing people's behaviour
    /// <see href="https://w3id.org/vair#BehaviourAnalysis"></see></summary>
    let BehaviourAnalysis = _prefix "BehaviourAnalysis"
    /// <summary>
    /// Systematic difference in treatment of certain objects, people or groups in comparison to others.
    /// <see href="https://w3id.org/vair#Bias"></see></summary>
    let Bias = _prefix "Bias"
    /// <summary>
    /// Control that is applied to detect bias in datasets, models, algorithms, etc.
    /// <see href="https://w3id.org/vair#BiasDetection"></see></summary>
    let BiasDetection = _prefix "BiasDetection"
    /// <summary>
    /// Control that is applied for detection purposes, e.g. detecting risks
    /// <see href="https://w3id.org/vair#DetectionControl"></see></summary>
    let DetectionControl = _prefix "DetectionControl"
    /// <summary>
    /// Bias in test data
    /// <see href="https://w3id.org/vair#BiasedTestData"></see></summary>
    let BiasedTestData = _prefix "BiasedTestData"
    /// <summary>
    /// Risk sources related to test data
    /// <see href="https://w3id.org/vair#TestDataRiskSource"></see></summary>
    let TestDataRiskSource = _prefix "TestDataRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#TestData"></see>
    /// </summary>
    let TestData = _prefix "TestData"
    /// <summary>
    /// Bias in training data
    /// <see href="https://w3id.org/vair#BiasedTrainingData"></see></summary>
    let BiasedTrainingData = _prefix "BiasedTrainingData"
    /// <summary>
    /// Risk sources related to training data
    /// <see href="https://w3id.org/vair#TrainingDataRiskSource"></see></summary>
    let TrainingDataRiskSource = _prefix "TrainingDataRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#TrainingData"></see>
    /// </summary>
    let TrainingData = _prefix "TrainingData"
    /// <summary>
    /// Bias in validation data
    /// <see href="https://w3id.org/vair#BiasedValidationData"></see></summary>
    let BiasedValidationData = _prefix "BiasedValidationData"
    /// <summary>
    /// Risk sources related to validation data
    /// <see href="https://w3id.org/vair#ValidationDataRiskSource"></see></summary>
    let ValidationDataRiskSource = _prefix "ValidationDataRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ValidationData"></see>
    /// </summary>
    let ValidationData = _prefix "ValidationData"
    /// <summary>
    /// The capability of the system is assigning natural persons to specific categories based on their biometric data
    /// <see href="https://w3id.org/vair#BiometricCategorisation"></see></summary>
    let BiometricCategorisation = _prefix "BiometricCategorisation"
    /// <summary>
    /// Automated recognition of physical, physiological and behavioural human features such as the face, eye movement, body shape, voice, prosody, gait, posture, heart rate, blood pressure, odour, keystrokes characteristics, for the purpose of establishing an individual’s identity by comparing biometric data of that individual to stored biometric data of individuals in a reference database, irrespective of whether the individual has given its consent or not.
    /// <see href="https://w3id.org/vair#BiometricIdentification"></see></summary>
    let BiometricIdentification = _prefix "BiometricIdentification"
    /// <summary>
    /// Refers to recognisting emtions based on biometrics information
    /// <see href="https://w3id.org/vair#BiometricsBasedEmotionRecognition"></see></summary>
    let BiometricsBasedEmotionRecognition = _prefix "BiometricsBasedEmotionRecognition"
    /// <summary>
    /// Computationally identifying and categorizing emotions expressed in a piece of text, speech, video or image or combination thereof.
    /// <see href="https://w3id.org/vair#EmotionRecognition"></see></summary>
    let EmotionRecognition = _prefix "EmotionRecognition"
    /// <summary>
    ///   <see href="https://w3id.org/vair#BiometricsBasedEmotionSensing"></see>
    /// </summary>
    let BiometricsBasedEmotionSensing = _prefix "BiometricsBasedEmotionSensing"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Blueprint"></see>
    /// </summary>
    let Blueprint = _prefix "Blueprint"
    /// <summary>
    /// Activities related to border control management.
    /// <see href="https://w3id.org/vair#BorderControlManagement"></see></summary>
    let BorderControlManagement = _prefix "BorderControlManagement"
    /// <summary>
    ///   <see href="https://w3id.org/vair#BorderControlSecurityCheck"></see>
    /// </summary>
    let BorderControlSecurityCheck = _prefix "BorderControlSecurityCheck"
    /// <summary>
    /// A mode of controllability that stakeholders cannot opt out of the system’s output.
    /// <see href="https://w3id.org/vair#CannotOptOutOfOutput"></see></summary>
    let CannotOptOutOfOutput = _prefix "CannotOptOutOfOutput"
    /// <summary>
    ///   <see href="https://w3id.org/vair#CaseBasedReasoning"></see>
    /// </summary>
    let CaseBasedReasoning = _prefix "CaseBasedReasoning"
    /// <summary>
    /// Assigning natural persons to specific categories
    /// <see href="https://w3id.org/vair#Categorisation"></see></summary>
    let Categorisation = _prefix "Categorisation"
    /// <summary>
    /// A mode of controllability that stakeholders can challenge the system’s output.
    /// <see href="https://w3id.org/vair#ChallengeOutput"></see></summary>
    let ChallengeOutput = _prefix "ChallengeOutput"
    /// <summary>
    /// Classifying emergency calls by natural persons
    /// <see href="https://w3id.org/vair#ClassifyingEmergencyCall"></see></summary>
    let ClassifyingEmergencyCall = _prefix "ClassifyingEmergencyCall"
    /// <summary>
    /// Category of AI systems that enables people and machines to interact more naturally.
    /// <see href="https://w3id.org/vair#CognitiveComputing"></see></summary>
    let CognitiveComputing = _prefix "CognitiveComputing"
    /// <summary>
    ///   <see href="https://w3id.org/vair#CognitiveSystem"></see>
    /// </summary>
    let CognitiveSystem = _prefix "CognitiveSystem"
    /// <summary>
    ///   <see href="https://w3id.org/vair#CommonSenseReasoning"></see>
    /// </summary>
    let CommonSenseReasoning = _prefix "CommonSenseReasoning"
    /// <summary>
    /// The level of automation where there is sustained and specific performance by a system, with an external agent being ready to take over when necessary.
    /// <see href="https://w3id.org/vair#ConditionalAutomation"></see></summary>
    let ConditionalAutomation = _prefix "ConditionalAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ConformityAssessmentBody"></see>
    /// </summary>
    let ConformityAssessmentBody = _prefix "ConformityAssessmentBody"
    /// <summary>
    /// Content generated using an AI system.
    /// <see href="https://w3id.org/vair#Content"></see></summary>
    let Content = _prefix "Content"
    /// <summary>
    /// Generation or manipulation of audio content
    /// <see href="https://w3id.org/vair#ContentGeneration"></see></summary>
    let ContentGeneration = _prefix "ContentGeneration"
    /// <summary>
    /// Refers to validation phase of continuous learning AI systems, wherein incremental training takes place on an ongoing basis while the system is running in production.
    /// <see href="https://w3id.org/vair#ContinuousValidation"></see></summary>
    let ContinuousValidation = _prefix "ContinuousValidation"
    /// <summary>
    /// Feed forward neural network using convolution  in at least one of its layers.
    /// <see href="https://w3id.org/vair#ConvolutionalNeuralNetwork"></see></summary>
    let ConvolutionalNeuralNetwork = _prefix "ConvolutionalNeuralNetwork"
    /// <summary>
    /// Neural network where information is fed from the input layer to the output layer in one direction only.
    /// <see href="https://w3id.org/vair#FeedForwardNeuralNetwork"></see></summary>
    let FeedForwardNeuralNetwork = _prefix "FeedForwardNeuralNetwork"
    /// <summary>
    /// A mode of controllability that stakeholders can correct the system’s output.
    /// <see href="https://w3id.org/vair#CorrectOutput"></see></summary>
    let CorrectOutput = _prefix "CorrectOutput"
    /// <summary>
    ///   <see href="https://w3id.org/vair#CourseApplicant"></see>
    /// </summary>
    let CourseApplicant = _prefix "CourseApplicant"
    /// <summary>
    /// A person who attends a course.
    /// <see href="https://w3id.org/vair#CourseAttendee"></see></summary>
    let CourseAttendee = _prefix "CourseAttendee"
    /// <summary>
    /// Refers to the sector or activities that aim at provision and maintainance of critical services.
    /// <see href="https://w3id.org/vair#CriticalInfrastructure"></see></summary>
    let CriticalInfrastructure = _prefix "CriticalInfrastructure"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Cyberattack"></see>
    /// </summary>
    let Cyberattack = _prefix "Cyberattack"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    /// Attack trying to manipulate the training dataset.
    /// <see href="https://w3id.org/vair#DataPoisoning"></see></summary>
    let DataPoisoning = _prefix "DataPoisoning"
    /// <summary>
    /// Risk sources related to data
    /// <see href="https://w3id.org/vair#DataRiskSource"></see></summary>
    let DataRiskSource = _prefix "DataRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Dataset"></see>
    /// </summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A form of dataset documentation
    /// <see href="https://w3id.org/vair#Datasheet"></see></summary>
    let Datasheet = _prefix "Datasheet"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Death"></see>
    /// </summary>
    let Death = _prefix "Death"
    /// <summary>
    /// Decision generated by an AI system
    /// <see href="https://w3id.org/vair#Decision"></see></summary>
    let Decision = _prefix "Decision"
    /// <summary>
    /// Generation of decisions
    /// <see href="https://w3id.org/vair#DecisionMaking"></see></summary>
    let DecisionMaking = _prefix "DecisionMaking"
    /// <summary>
    ///   <see href="https://w3id.org/vair#DecisionSupportSystem"></see>
    /// </summary>
    let DecisionSupportSystem = _prefix "DecisionSupportSystem"
    /// <summary>
    /// Model for which inference  is encoded as paths from the root to a leaf node in a tree structure.
    /// <see href="https://w3id.org/vair#DecisionTree"></see></summary>
    let DecisionTree = _prefix "DecisionTree"
    /// <summary>
    /// Decreased level of system's robustness resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DecreasedRobustness"></see></summary>
    let DecreasedRobustness = _prefix "DecreasedRobustness"
    /// <summary>
    /// Decreased level of security of system resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DecreasedSecurity"></see></summary>
    let DecreasedSecurity = _prefix "DecreasedSecurity"
    /// <summary>
    /// Dectection of content that is generated using deep fake
    /// <see href="https://w3id.org/vair#DeepFakeDetection"></see></summary>
    let DeepFakeDetection = _prefix "DeepFakeDetection"
    /// <summary>
    /// Purposes related to detecting
    /// <see href="https://w3id.org/vair#Detection"></see></summary>
    let Detection = _prefix "Detection"
    /// <summary>
    /// Approach to creating rich hierarchical representations through the training of neural networks with many hidden layers
    /// <see href="https://w3id.org/vair#DeepLearning"></see></summary>
    let DeepLearning = _prefix "DeepLearning"
    /// <summary>
    /// Process of optimizing model parameters through computational techniques, such that the model's behaviour reflects the data or experience.
    /// <see href="https://w3id.org/vair#MachineLearning"></see></summary>
    let MachineLearning = _prefix "MachineLearning"
    /// <summary>
    /// Decreased level of system's accuracy resulted from materialisation of a risk.
    /// <see href="https://w3id.org/vair#DegradedAccuracy"></see></summary>
    let DegradedAccuracy = _prefix "DegradedAccuracy"
    /// <summary>
    /// Refers to deployment phase oThe AI system is installed, released or configured for operation in a target environment.
    /// <see href="https://w3id.org/vair#Deployment"></see></summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    /// Refers to design phase of AI development
    /// <see href="https://w3id.org/vair#Design"></see></summary>
    let Design = _prefix "Design"
    /// <summary>
    /// Design specification of a system
    /// <see href="https://w3id.org/vair#DesignSpecification"></see></summary>
    let DesignSpecification = _prefix "DesignSpecification"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Detecting"></see>
    /// </summary>
    let Detecting = _prefix "Detecting"
    /// <summary>
    /// Detection of criminal offences
    /// <see href="https://w3id.org/vair#DetectingCriminalOffences"></see></summary>
    let DetectingCriminalOffences = _prefix "DetectingCriminalOffences"
    /// <summary>
    /// Detection of the emotional state of a natural person
    /// <see href="https://w3id.org/vair#DetectingEmotionalState"></see></summary>
    let DetectingEmotionalState = _prefix "DetectingEmotionalState"
    /// <summary>
    /// Detecting natural persons
    /// <see href="https://w3id.org/vair#DetectingIndividuals"></see></summary>
    let DetectingIndividuals = _prefix "DetectingIndividuals"
    /// <summary>
    /// Dectecting lies
    /// <see href="https://w3id.org/vair#DetectingLies"></see></summary>
    let DetectingLies = _prefix "DetectingLies"
    /// <summary>
    /// Detection of  non-authentic documents
    /// <see href="https://w3id.org/vair#DetectingNon-AuthenticDocument"></see></summary>
    let ``DetectingNon-AuthenticDocument`` = _prefix "DetectingNon-AuthenticDocument"

    /// <summary>
    /// Detecting prohibited behaviour during tests
    /// <see href="https://w3id.org/vair#DetectingProhibitedBehaviourDuringTest"></see></summary>
    let DetectingProhibitedBehaviourDuringTest =
        _prefix "DetectingProhibitedBehaviourDuringTest"

    /// <summary>
    /// Determining access to educational institutions all levels.
    /// <see href="https://w3id.org/vair#DeterminingAccessToEducationalInstitutions"></see></summary>
    let DeterminingAccessToEducationalInstitutions =
        _prefix "DeterminingAccessToEducationalInstitutions"

    /// <summary>
    /// Determining access to vocational training institutions all levels.
    /// <see href="https://w3id.org/vair#DeterminingAccessToVocationalTrainingInstitutions"></see></summary>
    let DeterminingAccessToVocationalTrainingInstitutions =
        _prefix "DeterminingAccessToVocationalTrainingInstitutions"

    /// <summary>
    /// Determining admission to educational institutions at all levels.
    /// <see href="https://w3id.org/vair#DeterminingAdmissionToEducationalInstitutions"></see></summary>
    let DeterminingAdmissionToEducationalInstitutions =
        _prefix "DeterminingAdmissionToEducationalInstitutions"

    /// <summary>
    /// Determining admission to vocational training institutions at all levels.
    /// <see href="https://w3id.org/vair#DeterminingAdmissionToVocationalTrainingInstitutions"></see></summary>
    let DeterminingAdmissionToVocationalTrainingInstitutions =
        _prefix "DeterminingAdmissionToVocationalTrainingInstitutions"

    /// <summary>
    /// Determining credit score of a person
    /// <see href="https://w3id.org/vair#DeterminingCreditScore"></see></summary>
    let DeterminingCreditScore = _prefix "DeterminingCreditScore"
    /// <summary>
    /// Refers to the development phase in AI lifecyle
    /// <see href="https://w3id.org/vair#Development"></see></summary>
    let Development = _prefix "Development"
    /// <summary>
    ///   <see href="https://w3id.org/vair#DevelopmentData"></see>
    /// </summary>
    let DevelopmentData = _prefix "DevelopmentData"
    /// <summary>
    /// Choosing the appropriate next move in a dialogue based on user input, the dialogue history and other contextual knowledge to meet a desired goal
    /// <see href="https://w3id.org/vair#DialogueManagement"></see></summary>
    let DialogueManagement = _prefix "DialogueManagement"
    /// <summary>
    /// Identifying unkown patterns of crime
    /// <see href="https://w3id.org/vair#DiscoveringCrimePatterns"></see></summary>
    let DiscoveringCrimePatterns = _prefix "DiscoveringCrimePatterns"
    /// <summary>
    /// Discovering hidden relationships related to crime
    /// <see href="https://w3id.org/vair#DiscoveringCrimeRelationships"></see></summary>
    let DiscoveringCrimeRelationships = _prefix "DiscoveringCrimeRelationships"
    /// <summary>
    ///   <see href="https://w3id.org/vair#LawEnforcemnet"></see>
    /// </summary>
    let LawEnforcemnet = _prefix "LawEnforcemnet"
    /// <summary>
    /// Dispatching  of emergency first response services, including by firefighters and medical aid
    /// <see href="https://w3id.org/vair#DispatchingEmergencyService"></see></summary>
    let DispatchingEmergencyService = _prefix "DispatchingEmergencyService"
    /// <summary>
    /// Business of supplying a commodity or a service by a govermental or public body.
    /// <see href="https://w3id.org/vair#PublicService"></see></summary>
    let PublicService = _prefix "PublicService"
    /// <summary>
    /// Represent distortion of human behaviour caused by AI
    /// <see href="https://w3id.org/vair#DistortionInHumanBehaviour"></see></summary>
    let DistortionInHumanBehaviour = _prefix "DistortionInHumanBehaviour"
    /// <summary>
    /// Refers to impacts that affect wellbeing
    /// <see href="https://w3id.org/vair#WellbeingImpact"></see></summary>
    let WellbeingImpact = _prefix "WellbeingImpact"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Distributor"></see>
    /// </summary>
    let Distributor = _prefix "Distributor"
    /// <summary>
    /// Union agency
    /// <see href="https://w3id.org/vair#EUAgency"></see></summary>
    let EUAgency = _prefix "EUAgency"
    /// <summary>
    /// Union body
    /// <see href="https://w3id.org/vair#EUBody"></see></summary>
    let EUBody = _prefix "EUBody"
    /// <summary>
    /// Document providing the EU declaration of conformity, as required by the AI Act, Article 47.
    /// <see href="https://w3id.org/vair#EUDeclarationOfConformity"></see></summary>
    let EUDeclarationOfConformity = _prefix "EUDeclarationOfConformity"
    /// <summary>
    /// Union institution
    /// <see href="https://w3id.org/vair#EUInstitution"></see></summary>
    let EUInstitution = _prefix "EUInstitution"
    /// <summary>
    /// EU office
    /// <see href="https://w3id.org/vair#EUOffice"></see></summary>
    let EUOffice = _prefix "EUOffice"
    /// <summary>
    /// Educational institution at any level
    /// <see href="https://w3id.org/vair#EducationalInstitution"></see></summary>
    let EducationalInstitution = _prefix "EducationalInstitution"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EmergancyTriage"></see>
    /// </summary>
    let EmergancyTriage = _prefix "EmergancyTriage"
    /// <summary>
    /// Refer to emergency healthcare providers
    /// <see href="https://w3id.org/vair#EmergencyHealthCareProvider"></see></summary>
    let EmergencyHealthCareProvider = _prefix "EmergencyHealthCareProvider"
    /// <summary>
    /// Provider of emergency first response services
    /// <see href="https://w3id.org/vair#EmergencyServiceProvider"></see></summary>
    let EmergencyServiceProvider = _prefix "EmergencyServiceProvider"
    /// <summary>
    /// Emergency triaging
    /// <see href="https://w3id.org/vair#EmergencyTriage"></see></summary>
    let EmergencyTriage = _prefix "EmergencyTriage"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EmotionSensing"></see>
    /// </summary>
    let EmotionSensing = _prefix "EmotionSensing"
    /// <summary>
    /// A person in work-related contractual relationships
    /// <see href="https://w3id.org/vair#Employee"></see></summary>
    let Employee = _prefix "Employee"
    /// <summary>
    /// Refers to employment, workers’ management and access to self-employment.
    /// <see href="https://w3id.org/vair#Employment"></see></summary>
    let Employment = _prefix "Employment"
    /// <summary>
    /// Error in data used as input
    /// <see href="https://w3id.org/vair#ErroneousInputData"></see></summary>
    let ErroneousInputData = _prefix "ErroneousInputData"
    /// <summary>
    /// Risk sources related to input data
    /// <see href="https://w3id.org/vair#InputDataRiskSource"></see></summary>
    let InputDataRiskSource = _prefix "InputDataRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#InputData"></see>
    /// </summary>
    let InputData = _prefix "InputData"
    /// <summary>
    /// Error in test data
    /// <see href="https://w3id.org/vair#ErroneousTestData"></see></summary>
    let ErroneousTestData = _prefix "ErroneousTestData"
    /// <summary>
    /// Error in training data
    /// <see href="https://w3id.org/vair#ErroneousTrainingData"></see></summary>
    let ErroneousTrainingData = _prefix "ErroneousTrainingData"
    /// <summary>
    /// Error in validation data
    /// <see href="https://w3id.org/vair#ErroneousValidationData"></see></summary>
    let ErroneousValidationData = _prefix "ErroneousValidationData"
    /// <summary>
    /// Refers to errors in data collection process
    /// <see href="https://w3id.org/vair#ErrorInDataCollection"></see></summary>
    let ErrorInDataCollection = _prefix "ErrorInDataCollection"
    /// <summary>
    ///   <see href="https://w3id.org/vair#DataCollection"></see>
    /// </summary>
    let DataCollection = _prefix "DataCollection"
    /// <summary>
    /// Refers to errors in data prepration process
    /// <see href="https://w3id.org/vair#ErrorInDataPrepration"></see></summary>
    let ErrorInDataPrepration = _prefix "ErrorInDataPrepration"
    /// <summary>
    ///   <see href="https://w3id.org/vair#DataPrepration"></see>
    /// </summary>
    let DataPrepration = _prefix "DataPrepration"

    /// <summary>
    ///   <see href="https://w3id.org/vair#EuropeanArtificialIntelligenceBoard"></see>
    /// </summary>
    let EuropeanArtificialIntelligenceBoard =
        _prefix "EuropeanArtificialIntelligenceBoard"

    /// <summary>
    ///   <see href="https://w3id.org/vair#EuropeanDataProtectionSupervisor"></see>
    /// </summary>
    let EuropeanDataProtectionSupervisor = _prefix "EuropeanDataProtectionSupervisor"

    /// <summary>
    /// Evaluating the eligibility of natural persons for essential public assistance benefits and services, including healthcare services,
    /// <see href="https://w3id.org/vair#EvaluatingEligibilityForPublicAssistanceServices"></see></summary>
    let EvaluatingEligibilityForPublicAssistanceServices =
        _prefix "EvaluatingEligibilityForPublicAssistanceServices"

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingEligibilityToAccessPublicAssistanceServices"></see>
    /// </summary>
    let EvaluatingEligibilityToAccessPublicAssistanceServices =
        _prefix "EvaluatingEligibilityToAccessPublicAssistanceServices"

    /// <summary>
    /// Evaluating the eligibility of natural persons for healthcare services
    /// <see href="https://w3id.org/vair#EvaluatingEligibilityforHealthCareServices"></see></summary>
    let EvaluatingEligibilityforHealthCareServices =
        _prefix "EvaluatingEligibilityforHealthCareServices"

    /// <summary>
    /// Evaluating emergency calls by natural persons
    /// <see href="https://w3id.org/vair#EvaluatingEmergencyCall"></see></summary>
    let EvaluatingEmergencyCall = _prefix "EvaluatingEmergencyCall"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingEmployee"></see>
    /// </summary>
    let EvaluatingEmployee = _prefix "EvaluatingEmployee"
    /// <summary>
    /// Evaluating the behaviour of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#EvaluatingEmployeeBehaviour"></see></summary>
    let EvaluatingEmployeeBehaviour = _prefix "EvaluatingEmployeeBehaviour"
    /// <summary>
    /// Evaluating the performance of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#EvaluatingEmployeePerformance"></see></summary>
    let EvaluatingEmployeePerformance = _prefix "EvaluatingEmployeePerformance"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingInterview"></see>
    /// </summary>
    let EvaluatingInterview = _prefix "EvaluatingInterview"
    /// <summary>
    /// Evaluation of job candidates
    /// <see href="https://w3id.org/vair#EvaluatingJobCandidates"></see></summary>
    let EvaluatingJobCandidates = _prefix "EvaluatingJobCandidates"
    /// <summary>
    /// Evaluation of job interviews
    /// <see href="https://w3id.org/vair#EvaluatingJobInterview"></see></summary>
    let EvaluatingJobInterview = _prefix "EvaluatingJobInterview"
    /// <summary>
    /// Evaluating learning outcomes, including when those outcomes are used to steer the learning process of natural persons in educational and vocational training institutions or programmes at all levels.
    /// <see href="https://w3id.org/vair#EvaluatingLearningOutcomes"></see></summary>
    let EvaluatingLearningOutcomes = _prefix "EvaluatingLearningOutcomes"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluatingRecruitmentTest"></see>
    /// </summary>
    let EvaluatingRecruitmentTest = _prefix "EvaluatingRecruitmentTest"

    /// <summary>
    /// Evaluation of the reliability of evidence in the course of investigation of criminal offences
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences"></see></summary>
    let EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences =
        _prefix "EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences"

    /// <summary>
    /// Assessments of the reliability of evidence in the examination of applications for asylum, visa or residence permits and for associated complaints with regard to the eligibility of the natural persons applying for a status
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications"></see></summary>
    let EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications =
        _prefix "EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications"

    /// <summary>
    /// Evaluation of the reliability of evidence in the course of prosecution of criminal offences
    /// <see href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences"></see></summary>
    let EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences =
        _prefix "EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences"

    /// <summary>
    ///   <see href="https://w3id.org/vair#EvaluationData"></see>
    /// </summary>
    let EvaluationData = _prefix "EvaluationData"
    /// <summary>
    ///   <see href="https://w3id.org/vair#EvolutionaryAlgorithm"></see>
    /// </summary>
    let EvolutionaryAlgorithm = _prefix "EvolutionaryAlgorithm"
    /// <summary>
    /// Purposes related to examining an application
    /// <see href="https://w3id.org/vair#ExaminingApplication"></see></summary>
    let ExaminingApplication = _prefix "ExaminingApplication"
    /// <summary>
    /// Examining asylum application
    /// <see href="https://w3id.org/vair#ExaminingAsylumApplication"></see></summary>
    let ExaminingAsylumApplication = _prefix "ExaminingAsylumApplication"

    /// <summary>
    /// Examining compliats related to migration
    /// <see href="https://w3id.org/vair#ExaminingMigrationRelatedComplaints"></see></summary>
    let ExaminingMigrationRelatedComplaints =
        _prefix "ExaminingMigrationRelatedComplaints"

    /// <summary>
    /// Examining residence permit application
    /// <see href="https://w3id.org/vair#ExaminingResidencePermitsApplication"></see></summary>
    let ExaminingResidencePermitsApplication =
        _prefix "ExaminingResidencePermitsApplication"

    /// <summary>
    /// Examining visa application
    /// <see href="https://w3id.org/vair#ExaminingVisaApplication"></see></summary>
    let ExaminingVisaApplication = _prefix "ExaminingVisaApplication"
    /// <summary>
    /// AI system that accumulates, combines and encapsulates knowledge provided by a human expert or experts in a specific domain to infer solutions to problems.
    /// <see href="https://w3id.org/vair#ExpertSystem"></see></summary>
    let ExpertSystem = _prefix "ExpertSystem"
    /// <summary>
    /// Refers to reasoning techniques.
    /// <see href="https://w3id.org/vair#ReasoningTechnique"></see></summary>
    let ReasoningTechnique = _prefix "ReasoningTechnique"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ExplainingAlgorithm"></see>
    /// </summary>
    let ExplainingAlgorithm = _prefix "ExplainingAlgorithm"
    /// <summary>
    /// Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs.
    /// <see href="https://w3id.org/vair#FaceRecognition"></see></summary>
    let FaceRecognition = _prefix "FaceRecognition"
    /// <summary>
    /// A group of people related to each other by blood or marraige
    /// <see href="https://w3id.org/vair#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// Network of one or more layers of neurons connected by weighted links with adjustable weights, which takes input data and produces an output.
    /// <see href="https://w3id.org/vair#NeuralNetwork"></see></summary>
    let NeuralNetwork = _prefix "NeuralNetwork"
    /// <summary>
    /// Refers to fire department
    /// <see href="https://w3id.org/vair#FireBrigade"></see></summary>
    let FireBrigade = _prefix "FireBrigade"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Firefighter"></see>
    /// </summary>
    let Firefighter = _prefix "Firefighter"
    /// <summary>
    /// Refers to freedoms given to individuals
    /// <see href="https://w3id.org/vair#Freedom"></see></summary>
    let Freedom = _prefix "Freedom"
    /// <summary>
    /// The level of automation where is capable of performing its entire mission without external intervention.
    /// <see href="https://w3id.org/vair#FullAutomation"></see></summary>
    let FullAutomation = _prefix "FullAutomation"
    /// <summary>
    /// Generation or manipulation of audio content
    /// <see href="https://w3id.org/vair#GeneratingAudioContent"></see></summary>
    let GeneratingAudioContent = _prefix "GeneratingAudioContent"
    /// <summary>
    /// Generation or manipulation of image content
    /// <see href="https://w3id.org/vair#GeneratingImageContent"></see></summary>
    let GeneratingImageContent = _prefix "GeneratingImageContent"
    /// <summary>
    /// Generation or manipulation of video content
    /// <see href="https://w3id.org/vair#GeneratingVideoContent"></see></summary>
    let GeneratingVideoContent = _prefix "GeneratingVideoContent"
    /// <summary>
    /// Algorithm which simulates natural selection by creating and evolving a population of individuals (solutions) for optimization problems
    /// <see href="https://w3id.org/vair#GeneticAlgorithm"></see></summary>
    let GeneticAlgorithm = _prefix "GeneticAlgorithm"
    /// <summary>
    /// The capability of AI system to recognise human gestures.
    /// <see href="https://w3id.org/vair#GestureRecognition"></see></summary>
    let GestureRecognition = _prefix "GestureRecognition"
    /// <summary>
    /// Granting natural persons healthcare services
    /// <see href="https://w3id.org/vair#GrantingHealthCareServices"></see></summary>
    let GrantingHealthCareServices = _prefix "GrantingHealthCareServices"
    /// <summary>
    /// Granting natural persons essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#GrantingPublicAssistanceServices"></see></summary>
    let GrantingPublicAssistanceServices = _prefix "GrantingPublicAssistanceServices"
    /// <summary>
    ///   <see href="https://w3id.org/vair#GrantingPublicAssistanceService"></see>
    /// </summary>
    let GrantingPublicAssistanceService = _prefix "GrantingPublicAssistanceService"
    /// <summary>
    /// A group of persons such as citizens, marginsalised groups, etc.
    /// <see href="https://w3id.org/vair#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// Refers to an individuals' health.
    /// <see href="https://w3id.org/vair#Health"></see></summary>
    let Health = _prefix "Health"
    /// <summary>
    /// Pricing in relation to natural persons in the case of health insurance
    /// <see href="https://w3id.org/vair#HealthInsurancePricing"></see></summary>
    let HealthInsurancePricing = _prefix "HealthInsurancePricing"
    /// <summary>
    /// Business of supplying a service by a private body.
    /// <see href="https://w3id.org/vair#PrivateService"></see></summary>
    let PrivateService = _prefix "PrivateService"
    /// <summary>
    /// Risk assessment in relation to natural persons in the case of health insurance
    /// <see href="https://w3id.org/vair#HealthInsuranceRiskAssessment"></see></summary>
    let HealthInsuranceRiskAssessment = _prefix "HealthInsuranceRiskAssessment"
    /// <summary>
    /// The level of automation where there the system performs parts of its mission without external intervention.
    /// <see href="https://w3id.org/vair#HighAutomation"></see></summary>
    let HighAutomation = _prefix "HighAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#HumanBehaviour"></see>
    /// </summary>
    let HumanBehaviour = _prefix "HumanBehaviour"
    /// <summary>
    /// Overseening the system by natural persons to detect, prevent or minimise risk.
    /// <see href="https://w3id.org/vair#HumanOversightMeasure"></see></summary>
    let HumanOversightMeasure = _prefix "HumanOversightMeasure"
    /// <summary>
    /// Controls that are implemeted in a semi automated manner.
    /// <see href="https://w3id.org/vair#SemiAutomatedControl"></see></summary>
    let SemiAutomatedControl = _prefix "SemiAutomatedControl"
    /// <summary>
    /// Risk management — Risk assessment techniques
    /// <see href="https://w3id.org/vair#IEC31010-2019"></see></summary>
    let ``IEC31010-2019`` = _prefix "IEC31010-2019"
    /// <summary>
    /// Quality management systems — Guidance for documented information
    /// <see href="https://w3id.org/vair#ISO10013-2021"></see></summary>
    let ``ISO10013-2021`` = _prefix "ISO10013-2021"
    /// <summary>
    /// Risk management — Guidelines
    /// <see href="https://w3id.org/vair#ISO31000-2018"></see></summary>
    let ``ISO31000-2018`` = _prefix "ISO31000-2018"
    /// <summary>
    /// ISO 31073:2022 Risk management — Vocabulary
    /// <see href="https://w3id.org/vair#ISO31073_2022"></see></summary>
    let ISO31073_2022 = _prefix "ISO31073_2022"
    /// <summary>
    /// Quality management systems — Requirements
    /// <see href="https://w3id.org/vair#ISO9001-2015"></see></summary>
    let ``ISO9001-2015`` = _prefix "ISO9001-2015"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ISOGuide73-2009"></see>
    /// </summary>
    let ``ISOGuide73-2009`` = _prefix "ISOGuide73-2009"
    /// <summary>
    /// Information technology — Big data — Overview and vocabulary
    /// <see href="https://w3id.org/vair#ISOIEC20546-2019"></see></summary>
    let ``ISOIEC20546-2019`` = _prefix "ISOIEC20546-2019"
    /// <summary>
    /// Information technology — Big data reference architecture — Part 3: Reference architecture
    /// <see href="https://w3id.org/vair#ISOIEC20547-3-2020"></see></summary>
    let ``ISOIEC20547-3-2020`` = _prefix "ISOIEC20547-3-2020"
    /// <summary>
    /// Information technology — Artificial intelligence — Artificial intelligence concepts and terminology
    /// <see href="https://w3id.org/vair#ISOIEC22989-2022"></see></summary>
    let ``ISOIEC22989-2022`` = _prefix "ISOIEC22989-2022"
    /// <summary>
    /// Framework for Artificial Intelligence (AI) Systems Using Machine Learning (ML)
    /// <see href="https://w3id.org/vair#ISOIEC23053-2022"></see></summary>
    let ``ISOIEC23053-2022`` = _prefix "ISOIEC23053-2022"
    /// <summary>
    /// Information technology — Artificial intelligence — Guidance on risk management
    /// <see href="https://w3id.org/vair#ISOIEC23894-2023"></see></summary>
    let ``ISOIEC23894-2023`` = _prefix "ISOIEC23894-2023"
    /// <summary>
    /// ISO/IEC 23894:2023 Information technology — Artificial intelligence — Guidance on risk management
    /// <see href="https://w3id.org/vair#ISOIEC23894_2023"></see></summary>
    let ISOIEC23894_2023 = _prefix "ISOIEC23894_2023"
    /// <summary>
    /// Information technology — Artificial intelligence — Process management framework for big data analytics
    /// <see href="https://w3id.org/vair#ISOIEC24668-2022"></see></summary>
    let ``ISOIEC24668-2022`` = _prefix "ISOIEC24668-2022"
    /// <summary>
    /// Information technology — Governance of IT — Governance implications of the use of artificial intelligence by organizations
    /// <see href="https://w3id.org/vair#ISOIEC38507-2022"></see></summary>
    let ``ISOIEC38507-2022`` = _prefix "ISOIEC38507-2022"
    /// <summary>
    /// ISO/IEC 42001:2023 Information technology — Artificial intelligence — Management system
    /// <see href="https://w3id.org/vair#ISOIEC42001_2023"></see></summary>
    let ISOIEC42001_2023 = _prefix "ISOIEC42001_2023"
    /// <summary>
    /// Information technology — Big data reference architecture — Part 1: Framework and application process
    /// <see href="https://w3id.org/vair#ISOIECTR20547-1-2020"></see></summary>
    let ``ISOIECTR20547-1-2020`` = _prefix "ISOIECTR20547-1-2020"
    /// <summary>
    /// Information technology — Big data reference architecture — Part 2: Use cases and derived requirements
    /// <see href="https://w3id.org/vair#ISOIECTR20547-2-2018"></see></summary>
    let ``ISOIECTR20547-2-2018`` = _prefix "ISOIECTR20547-2-2018"
    /// <summary>
    /// Information technology — Big data reference architecture — Part 5: Standards roadmap
    /// <see href="https://w3id.org/vair#ISOIECTR20547-5-2018"></see></summary>
    let ``ISOIECTR20547-5-2018`` = _prefix "ISOIECTR20547-5-2018"
    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Bias in AI systems and AI aided decision making
    /// <see href="https://w3id.org/vair#ISOIECTR24027-2021"></see></summary>
    let ``ISOIECTR24027-2021`` = _prefix "ISOIECTR24027-2021"
    /// <summary>
    /// v
    /// <see href="https://w3id.org/vair#ISOIECTR24028-2020"></see></summary>
    let ``ISOIECTR24028-2020`` = _prefix "ISOIECTR24028-2020"
    /// <summary>
    /// Artificial Intelligence (AI) — Assessment of the robustness of neural networks — Part 1: Overview
    /// <see href="https://w3id.org/vair#ISOIECTR24029-1-2021"></see></summary>
    let ``ISOIECTR24029-1-2021`` = _prefix "ISOIECTR24029-1-2021"
    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Use cases
    /// <see href="https://w3id.org/vair#ISOIECTR24030-2021"></see></summary>
    let ``ISOIECTR24030-2021`` = _prefix "ISOIECTR24030-2021"
    /// <summary>
    /// Information technology — Artificial intelligence — Overview of ethical and societal concerns
    /// <see href="https://w3id.org/vair#ISOIECTR24368-2022"></see></summary>
    let ``ISOIECTR24368-2022`` = _prefix "ISOIECTR24368-2022"
    /// <summary>
    /// Information technology — Artificial intelligence (AI) — Overview of computational approaches for AI systems
    /// <see href="https://w3id.org/vair#ISOIECTR24372-2021"></see></summary>
    let ``ISOIECTR24372-2021`` = _prefix "ISOIECTR24372-2021"
    /// <summary>
    /// Information technology — Artificial intelligence — Assessment of machine learning classification performance
    /// <see href="https://w3id.org/vair#ISOIECTS4213-2022"></see></summary>
    let ``ISOIECTS4213-2022`` = _prefix "ISOIECTS4213-2022"
    /// <summary>
    /// Identifying natural persons
    /// <see href="https://w3id.org/vair#IdentiftyingIndividuals"></see></summary>
    let IdentiftyingIndividuals = _prefix "IdentiftyingIndividuals"
    /// <summary>
    /// Image classification process that classifies object(s), pattern(s) or concept(s) in an image.
    /// <see href="https://w3id.org/vair#ImageRecognition"></see></summary>
    let ImageRecognition = _prefix "ImageRecognition"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Importer"></see>
    /// </summary>
    let Importer = _prefix "Importer"
    /// <summary>
    /// Inaccurate decision generated by the system.
    /// <see href="https://w3id.org/vair#InaccurateDecision"></see></summary>
    let InaccurateDecision = _prefix "InaccurateDecision"
    /// <summary>
    /// Inacurracy of the predictions, recommondations, or decisions produced by the system.
    /// <see href="https://w3id.org/vair#LowAccuracy"></see></summary>
    let LowAccuracy = _prefix "LowAccuracy"
    /// <summary>
    /// Inaccurate prediction generated by the system.
    /// <see href="https://w3id.org/vair#InaccuratePrediction"></see></summary>
    let InaccuratePrediction = _prefix "InaccuratePrediction"
    /// <summary>
    /// Inaccurate recommendation generated by the system.
    /// <see href="https://w3id.org/vair#InaccurateRecommendation"></see></summary>
    let InaccurateRecommendation = _prefix "InaccurateRecommendation"
    /// <summary>
    /// Inception occurs when one or more stakeholders decides to turn an idea into a tangible system
    /// <see href="https://w3id.org/vair#Inception"></see></summary>
    let Inception = _prefix "Inception"
    /// <summary>
    /// Incompleteness of testing data set
    /// <see href="https://w3id.org/vair#IncompleteTestData"></see></summary>
    let IncompleteTestData = _prefix "IncompleteTestData"
    /// <summary>
    /// Incompleteness of training data set
    /// <see href="https://w3id.org/vair#IncompleteTrainingData"></see></summary>
    let IncompleteTrainingData = _prefix "IncompleteTrainingData"
    /// <summary>
    /// Incompleteness of validation data set
    /// <see href="https://w3id.org/vair#IncompleteValidationData"></see></summary>
    let IncompleteValidationData = _prefix "IncompleteValidationData"
    /// <summary>
    /// A person who has entered into the territory of a State
    /// <see href="https://w3id.org/vair#IndividualEnteredState"></see></summary>
    let IndividualEnteredState = _prefix "IndividualEnteredState"
    /// <summary>
    /// A person who intends to enter into the territory of a State
    /// <see href="https://w3id.org/vair#IndividualIntendsToEnterState"></see></summary>
    let IndividualIntendsToEnterState = _prefix "IndividualIntendsToEnterState"
    /// <summary>
    /// Tthe inference of an algorithm or program featuring recursive calls or repetition control structures
    /// <see href="https://w3id.org/vair#InductiveProgramming"></see></summary>
    let InductiveProgramming = _prefix "InductiveProgramming"
    /// <summary>
    /// Techniques based on the use of knowledge bases
    /// <see href="https://w3id.org/vair#KnowledgeBasedTechnique"></see></summary>
    let KnowledgeBasedTechnique = _prefix "KnowledgeBasedTechnique"
    /// <summary>
    /// A robot for use in industrial automation applications.
    /// <see href="https://w3id.org/vair#IndustrialRobot"></see></summary>
    let IndustrialRobot = _prefix "IndustrialRobot"
    /// <summary>
    /// An automation system with actuators that performs intended tasks in the physical world, by means of sensing its environment and a software control system.
    /// <see href="https://w3id.org/vair#Robot"></see></summary>
    let Robot = _prefix "Robot"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Inference"></see>
    /// </summary>
    let Inference = _prefix "Inference"
    /// <summary>
    /// Purpose of influencing
    /// <see href="https://w3id.org/vair#Influencing"></see></summary>
    let Influencing = _prefix "Influencing"
    /// <summary>
    /// Influencing the outcome of an election.
    /// <see href="https://w3id.org/vair#InfluencingElectionOutcome"></see></summary>
    let InfluencingElectionOutcome = _prefix "InfluencingElectionOutcome"
    /// <summary>
    /// Influencing the outcome of a referendum.
    /// <see href="https://w3id.org/vair#InfluencingReferendumOutcome"></see></summary>
    let InfluencingReferendumOutcome = _prefix "InfluencingReferendumOutcome"
    /// <summary>
    /// Purpose of influencing voting behaviour of people
    /// <see href="https://w3id.org/vair#InfluencingVotingBehaviour"></see></summary>
    let InfluencingVotingBehaviour = _prefix "InfluencingVotingBehaviour"
    /// <summary>
    /// Providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used.
    /// <see href="https://w3id.org/vair#InformationProvision"></see></summary>
    let InformationProvision = _prefix "InformationProvision"
    /// <summary>
    /// Organisational measures applied to control risk sources, risks, consequences, or impacts.
    /// <see href="https://w3id.org/vair#OrganisationalMeasure"></see></summary>
    let OrganisationalMeasure = _prefix "OrganisationalMeasure"
    /// <summary>
    /// Retrieving relevant documents or parts of documents from a dataset, typically based on keyword or natural language queries.
    /// <see href="https://w3id.org/vair#InformationRetrieval"></see></summary>
    let InformationRetrieval = _prefix "InformationRetrieval"
    /// <summary>
    /// Represents that a specific actor was informed that an AI system is in place.
    /// <see href="https://w3id.org/vair#InformedInvolvement"></see></summary>
    let InformedInvolvement = _prefix "InformedInvolvement"
    /// <summary>
    /// Instruction for installing an application.
    /// <see href="https://w3id.org/vair#InstallationInstruction"></see></summary>
    let InstallationInstruction = _prefix "InstallationInstruction"
    /// <summary>
    /// The information provided by the provider to inform the deployer of, in particular, an AI system’s intended purpose and proper use.
    /// <see href="https://w3id.org/vair#InstructionForUse"></see></summary>
    let InstructionForUse = _prefix "InstructionForUse"
    /// <summary>
    ///   <see href="https://w3id.org/vair#InstructionOfUse"></see>
    /// </summary>
    let InstructionOfUse = _prefix "InstructionOfUse"
    /// <summary>
    /// Lack of appropriate human oversight measures
    /// <see href="https://w3id.org/vair#InsufficientHumanOversightMeasure"></see></summary>
    let InsufficientHumanOversightMeasure = _prefix "InsufficientHumanOversightMeasure"
    /// <summary>
    /// Risk sources related with the organisation developing, deploying, or using AI.
    /// <see href="https://w3id.org/vair#OrganisationalRiskSource"></see></summary>
    let OrganisationalRiskSource = _prefix "OrganisationalRiskSource"
    /// <summary>
    /// Lack of appropriate instruction for use
    /// <see href="https://w3id.org/vair#InsufficientInstruction"></see></summary>
    let InsufficientInstruction = _prefix "InsufficientInstruction"
    /// <summary>
    /// An AI-based control system
    /// <see href="https://w3id.org/vair#IntelligentControlSystem"></see></summary>
    let IntelligentControlSystem = _prefix "IntelligentControlSystem"
    /// <summary>
    /// Represents involvement of a specific actor is as intended.
    /// <see href="https://w3id.org/vair#IntendedInvolvement"></see></summary>
    let IntendedInvolvement = _prefix "IntendedInvolvement"
    /// <summary>
    /// Interpreting facts
    /// <see href="https://w3id.org/vair#InterpretingFacts"></see></summary>
    let InterpretingFacts = _prefix "InterpretingFacts"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Law"></see>
    /// </summary>
    let Law = _prefix "Law"
    /// <summary>
    /// Interpreting the law
    /// <see href="https://w3id.org/vair#InterpretingLaw"></see></summary>
    let InterpretingLaw = _prefix "InterpretingLaw"
    /// <summary>
    /// Interrupting the system's operation
    /// <see href="https://w3id.org/vair#Interruption"></see></summary>
    let Interruption = _prefix "Interruption"
    /// <summary>
    /// Control related to operation of the system.
    /// <see href="https://w3id.org/vair#OperationalMeasure"></see></summary>
    let OperationalMeasure = _prefix "OperationalMeasure"
    /// <summary>
    /// Intervention of system's operation
    /// <see href="https://w3id.org/vair#Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// Investigation of criminal offences
    /// <see href="https://w3id.org/vair#InvestigatingCriminalOffences"></see></summary>
    let InvestigatingCriminalOffences = _prefix "InvestigatingCriminalOffences"
    /// <summary>
    /// A system providing functionalities of IoT.
    /// <see href="https://w3id.org/vair#IoTSystem"></see></summary>
    let IoTSystem = _prefix "IoTSystem"
    /// <summary>
    /// Use of irrelevant data for testing
    /// <see href="https://w3id.org/vair#IrrelevantTestData"></see></summary>
    let IrrelevantTestData = _prefix "IrrelevantTestData"
    /// <summary>
    /// Use of irrelevant data for training
    /// <see href="https://w3id.org/vair#IrrelevantTrainingData"></see></summary>
    let IrrelevantTrainingData = _prefix "IrrelevantTrainingData"
    /// <summary>
    /// Use of irrelevant data for validation
    /// <see href="https://w3id.org/vair#IrrelevantValidationData"></see></summary>
    let IrrelevantValidationData = _prefix "IrrelevantValidationData"
    /// <summary>
    /// A person who has made an application for employment
    /// <see href="https://w3id.org/vair#JobApplicant"></see></summary>
    let JobApplicant = _prefix "JobApplicant"
    /// <summary>
    /// Analysis of job applications
    /// <see href="https://w3id.org/vair#JobApplicationAnalysis"></see></summary>
    let JobApplicationAnalysis = _prefix "JobApplicationAnalysis"
    /// <summary>
    /// Filtering applications for recruitment or selection of natural persons
    /// <see href="https://w3id.org/vair#JobApplicationFiltering"></see></summary>
    let JobApplicationFiltering = _prefix "JobApplicationFiltering"
    /// <summary>
    /// Screening job applications
    /// <see href="https://w3id.org/vair#JobApplicationScreening"></see></summary>
    let JobApplicationScreening = _prefix "JobApplicationScreening"
    /// <summary>
    /// A person who is considered for employment.
    /// <see href="https://w3id.org/vair#JobCandidate"></see></summary>
    let JobCandidate = _prefix "JobCandidate"
    /// <summary>
    /// Selecting people for a job for a position
    /// <see href="https://w3id.org/vair#JobCandidateSelection"></see></summary>
    let JobCandidateSelection = _prefix "JobCandidateSelection"
    /// <summary>
    /// An authority to administer justice
    /// <see href="https://w3id.org/vair#JudicialAuthority"></see></summary>
    let JudicialAuthority = _prefix "JudicialAuthority"
    /// <summary>
    /// An entity that acts on behalf on judicial authorities
    /// <see href="https://w3id.org/vair#JudicialAuthorityAgent"></see></summary>
    let JudicialAuthorityAgent = _prefix "JudicialAuthorityAgent"
    /// <summary>
    /// Encoding knowledge in a formal language
    /// <see href="https://w3id.org/vair#KnowledgeRepresentation"></see></summary>
    let KnowledgeRepresentation = _prefix "KnowledgeRepresentation"
    /// <summary>
    /// Refers to lack transparency regarding AI, its development, deployement, or use
    /// <see href="https://w3id.org/vair#LackOfTransparency"></see></summary>
    let LackOfTransparency = _prefix "LackOfTransparency"
    /// <summary>
    /// Law enforcement authority means:
    /// (a) any public authority competent for the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security; or
    /// (b) any other body or entity entrusted by Member State law to exercise public authority and public powers for the purposes of the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security.
    /// <see href="https://w3id.org/vair#LawEnforcementAuthority"></see></summary>
    let LawEnforcementAuthority = _prefix "LawEnforcementAuthority"
    /// <summary>
    /// An entity that acts on behalf of law enforcement authorities.
    /// <see href="https://w3id.org/vair#LawEnforcementAuthorityAgent"></see></summary>
    let LawEnforcementAuthorityAgent = _prefix "LawEnforcementAuthorityAgent"
    /// <summary>
    ///   <see href="https://w3id.org/vair#LearningTechnique"></see>
    /// </summary>
    let LearningTechnique = _prefix "LearningTechnique"
    /// <summary>
    /// A collection of pre-written code
    /// <see href="https://w3id.org/vair#Library"></see></summary>
    let Library = _prefix "Library"
    /// <summary>
    /// Detecting lies
    /// <see href="https://w3id.org/vair#LieDetection"></see></summary>
    let LieDetection = _prefix "LieDetection"
    /// <summary>
    /// Pricing in relation to natural persons in the case of life insurance
    /// <see href="https://w3id.org/vair#LifeInsurancePricing"></see></summary>
    let LifeInsurancePricing = _prefix "LifeInsurancePricing"
    /// <summary>
    /// Risk assessment in relation to natural persons in the case of life insurance
    /// <see href="https://w3id.org/vair#LifeInsuranceRiskAssessment"></see></summary>
    let LifeInsuranceRiskAssessment = _prefix "LifeInsuranceRiskAssessment"
    /// <summary>
    /// Refers to logging measure in place
    /// <see href="https://w3id.org/vair#LoggingMeasure"></see></summary>
    let LoggingMeasure = _prefix "LoggingMeasure"
    /// <summary>
    /// Refers to logic based techniques.
    /// <see href="https://w3id.org/vair#LogicBasedTechnique"></see></summary>
    let LogicBasedTechnique = _prefix "LogicBasedTechnique"
    /// <summary>
    /// type of recurrent neural network that processes sequential data with a satisfactory performance for both long and short span dependencies.
    /// <see href="https://w3id.org/vair#LongShortTermMemory"></see></summary>
    let LongShortTermMemory = _prefix "LongShortTermMemory"
    /// <summary>
    /// neural network in which outputs from both the previous layer and the previous processing step are fed into the current layer.
    /// <see href="https://w3id.org/vair#RecurrentNeuralNetwork"></see></summary>
    let RecurrentNeuralNetwork = _prefix "RecurrentNeuralNetwork"
    /// <summary>
    /// Risk sources related to performance
    /// <see href="https://w3id.org/vair#PerfomanceRiskSource"></see></summary>
    let PerfomanceRiskSource = _prefix "PerfomanceRiskSource"
    /// <summary>
    /// Lack of appropriate level of robustness
    /// <see href="https://w3id.org/vair#LowRobustness"></see></summary>
    let LowRobustness = _prefix "LowRobustness"
    /// <summary>
    /// Lack of appropriate level of security.
    /// <see href="https://w3id.org/vair#LowSecurity"></see></summary>
    let LowSecurity = _prefix "LowSecurity"
    /// <summary>
    /// An algorithm to determine parameters of a machine learning model from data according to given criteria.
    /// <see href="https://w3id.org/vair#MachineLearningAlgorithm"></see></summary>
    let MachineLearningAlgorithm = _prefix "MachineLearningAlgorithm"
    /// <summary>
    ///   <see href="https://w3id.org/vair#MachineLearningFramework"></see>
    /// </summary>
    let MachineLearningFramework = _prefix "MachineLearningFramework"
    /// <summary>
    /// Refers to liberaries for machine learning
    /// <see href="https://w3id.org/vair#MachineLearningLibrary"></see></summary>
    let MachineLearningLibrary = _prefix "MachineLearningLibrary"
    /// <summary>
    /// Mathematical construct that generates an inference or prediction  based on input data or information.
    /// <see href="https://w3id.org/vair#MachineLearningModel"></see></summary>
    let MachineLearningModel = _prefix "MachineLearningModel"
    /// <summary>
    /// Resource on which a ML model runs.
    /// <see href="https://w3id.org/vair#MachineLearningPlatform"></see></summary>
    let MachineLearningPlatform = _prefix "MachineLearningPlatform"
    /// <summary>
    ///   <see href="https://w3id.org/vair#MachineLearningTechnique"></see>
    /// </summary>
    let MachineLearningTechnique = _prefix "MachineLearningTechnique"
    /// <summary>
    /// Automated translation of text or speech from one natural language to another using a computer system.
    /// <see href="https://w3id.org/vair#MachineTranslation"></see></summary>
    let MachineTranslation = _prefix "MachineTranslation"
    /// <summary>
    /// Making decisions on termination of work-related contractual relationship
    /// Making Contract Termination Decision
    /// <see href="https://w3id.org/vair#MakingContractTerminationDecision"></see></summary>
    let MakingContractTerminationDecision = _prefix "MakingContractTerminationDecision"

    /// <summary>
    /// Making decisions affecting terms of work-related relationships
    /// <see href="https://w3id.org/vair#MakingDecisionOnTermsOfWorkRelatedRelations"></see></summary>
    let MakingDecisionOnTermsOfWorkRelatedRelations =
        _prefix "MakingDecisionOnTermsOfWorkRelatedRelations"

    /// <summary>
    ///   <see href="https://w3id.org/vair#MakingPrediction"></see>
    /// </summary>
    let MakingPrediction = _prefix "MakingPrediction"
    /// <summary>
    /// Making decisions on promotion
    /// <see href="https://w3id.org/vair#MakingPromotionDecision"></see></summary>
    let MakingPromotionDecision = _prefix "MakingPromotionDecision"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagementAndOperationOfSafety"></see>
    /// </summary>
    let ManagementAndOperationOfSafety = _prefix "ManagementAndOperationOfSafety"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Managing"></see>
    /// </summary>
    let Managing = _prefix "Managing"

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingCriticalDigitalInfrastructure"></see>
    /// </summary>
    let ManagingCriticalDigitalInfrastructure =
        _prefix "ManagingCriticalDigitalInfrastructure"

    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingRoadTraffic"></see>
    /// </summary>
    let ManagingRoadTraffic = _prefix "ManagingRoadTraffic"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfElectricity"></see>
    /// </summary>
    let ManagingSupplyOfElectricity = _prefix "ManagingSupplyOfElectricity"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfGas"></see>
    /// </summary>
    let ManagingSupplyOfGas = _prefix "ManagingSupplyOfGas"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfHeating"></see>
    /// </summary>
    let ManagingSupplyOfHeating = _prefix "ManagingSupplyOfHeating"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ManagingSupplyOfWater"></see>
    /// </summary>
    let ManagingSupplyOfWater = _prefix "ManagingSupplyOfWater"
    /// <summary>
    ///   <see href="https://w3id.org/vair#MarketSurveillanceAuthority"></see>
    /// </summary>
    let MarketSurveillanceAuthority = _prefix "MarketSurveillanceAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/vair#MedicalAid"></see>
    /// </summary>
    let MedicalAid = _prefix "MedicalAid"
    /// <summary>
    /// Entity that provides medical aid
    /// <see href="https://w3id.org/vair#MedicalAidProvider"></see></summary>
    let MedicalAidProvider = _prefix "MedicalAidProvider"
    /// <summary>
    /// Control that is applied for mitigation purposes, e.g. ,mitigating risk sources, impacts, etc.
    /// <see href="https://w3id.org/vair#MitigationMeasure"></see></summary>
    let MitigationMeasure = _prefix "MitigationMeasure"
    /// <summary>
    /// A form of model documentation
    /// <see href="https://w3id.org/vair#ModelCard"></see></summary>
    let ModelCard = _prefix "ModelCard"
    /// <summary>
    /// An input, which seems normal for a human but is wrongly classified by ML models.
    /// <see href="https://w3id.org/vair#ModelEvasion"></see></summary>
    let ModelEvasion = _prefix "ModelEvasion"
    /// <summary>
    /// A type of attack to AI models, in which the access to a model is abused to infer information about the training data.
    /// <see href="https://w3id.org/vair#ModelInversion"></see></summary>
    let ModelInversion = _prefix "ModelInversion"
    /// <summary>
    /// Risk sources related to the AI model
    /// <see href="https://w3id.org/vair#ModelRiskSource"></see></summary>
    let ModelRiskSource = _prefix "ModelRiskSource"
    /// <summary>
    /// Observing and keeping track of something
    /// <see href="https://w3id.org/vair#Monitoring"></see></summary>
    let Monitoring = _prefix "Monitoring"
    /// <summary>
    /// Monitoring the behaviour of persons in work-related relationships.
    /// <see href="https://w3id.org/vair#MonitoringEmployeeBehaviour"></see></summary>
    let MonitoringEmployeeBehaviour = _prefix "MonitoringEmployeeBehaviour"
    /// <summary>
    /// Monitoring the performance of persons in work-related relationships
    /// <see href="https://w3id.org/vair#MonitoringEmployeePerformance"></see></summary>
    let MonitoringEmployeePerformance = _prefix "MonitoringEmployeePerformance"
    /// <summary>
    /// Refers to monitoring measures
    /// <see href="https://w3id.org/vair#MonitoringMeasure"></see></summary>
    let MonitoringMeasure = _prefix "MonitoringMeasure"

    /// <summary>
    /// Monitoring prohibited behaviour during tests
    /// <see href="https://w3id.org/vair#MonitoringProhibitedBehaviourDuringTest"></see></summary>
    let MonitoringProhibitedBehaviourDuringTest =
        _prefix "MonitoringProhibitedBehaviourDuringTest"

    /// <summary>
    /// A system consisting of multiple AI agents.
    /// <see href="https://w3id.org/vair#MultiAgentSystem"></see></summary>
    let MultiAgentSystem = _prefix "MultiAgentSystem"
    /// <summary>
    /// Retrieving information from music.
    /// <see href="https://w3id.org/vair#MusicInformationRetrieval"></see></summary>
    let MusicInformationRetrieval = _prefix "MusicInformationRetrieval"
    /// <summary>
    /// Recognizing and labelling the denotational names of entities and their categories for sequences of words in a stream of text or speech.
    /// <see href="https://w3id.org/vair#NamedEntityRecognition"></see></summary>
    let NamedEntityRecognition = _prefix "NamedEntityRecognition"
    /// <summary>
    /// Type of AI system that is focused on defined tasks to address a specific problem.
    /// <see href="https://w3id.org/vair#NarrowAI"></see></summary>
    let NarrowAI = _prefix "NarrowAI"
    /// <summary>
    ///   <see href="https://w3id.org/vair#NationalPublicAuthority"></see>
    /// </summary>
    let NationalPublicAuthority = _prefix "NationalPublicAuthority"
    /// <summary>
    /// Converting data carrying semantics into natural language.
    /// <see href="https://w3id.org/vair#NaturalLanguageGeneration"></see></summary>
    let NaturalLanguageGeneration = _prefix "NaturalLanguageGeneration"
    /// <summary>
    /// Information processing based upon natural language understanding or natural language generation.
    /// <see href="https://w3id.org/vair#NaturalLanguageProcessingSystem"></see></summary>
    let NaturalLanguageProcessingSystem = _prefix "NaturalLanguageProcessingSystem"
    /// <summary>
    /// An individual human being
    /// <see href="https://w3id.org/vair#NaturalPerson"></see></summary>
    let NaturalPerson = _prefix "NaturalPerson"
    /// <summary>
    /// The level of automation where an operator fully controls the system
    /// <see href="https://w3id.org/vair#NoAutomation"></see></summary>
    let NoAutomation = _prefix "NoAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#NotifiedBody"></see>
    /// </summary>
    let NotifiedBody = _prefix "NotifiedBody"
    /// <summary>
    ///   <see href="https://w3id.org/vair#NotifyingAuthority"></see>
    /// </summary>
    let NotifyingAuthority = _prefix "NotifyingAuthority"
    /// <summary>
    /// The capability to recognise objects
    /// <see href="https://w3id.org/vair#ObjectRecognition"></see></summary>
    let ObjectRecognition = _prefix "ObjectRecognition"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Operating"></see>
    /// </summary>
    let Operating = _prefix "Operating"

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingCriticalDigitalInfrastructure"></see>
    /// </summary>
    let OperatingCriticalDigitalInfrastructure =
        _prefix "OperatingCriticalDigitalInfrastructure"

    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingRoadTraffic"></see>
    /// </summary>
    let OperatingRoadTraffic = _prefix "OperatingRoadTraffic"
    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfElectricity"></see>
    /// </summary>
    let OperatingSupplyOfElectricity = _prefix "OperatingSupplyOfElectricity"
    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfGas"></see>
    /// </summary>
    let OperatingSupplyOfGas = _prefix "OperatingSupplyOfGas"
    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfHeating"></see>
    /// </summary>
    let OperatingSupplyOfHeating = _prefix "OperatingSupplyOfHeating"
    /// <summary>
    ///   <see href="https://w3id.org/vair#OperatingSupplyOfWater"></see>
    /// </summary>
    let OperatingSupplyOfWater = _prefix "OperatingSupplyOfWater"
    /// <summary>
    /// Refers to the operation stage when an AI system is running and generally available for use.
    /// <see href="https://w3id.org/vair#Operation"></see></summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// Refers to optimisation Method
    /// <see href="https://w3id.org/vair#OptimisationMethod"></see></summary>
    let OptimisationMethod = _prefix "OptimisationMethod"
    /// <summary>
    /// A mode of controllability that stakeholders can opt in  the system’s output.
    /// <see href="https://w3id.org/vair#OpttingInOutput"></see></summary>
    let OpttingInOutput = _prefix "OpttingInOutput"
    /// <summary>
    /// A mode of controllability that stakeholders can opt out of the system’s output.
    /// <see href="https://w3id.org/vair#OpttingOutOfOutput"></see></summary>
    let OpttingOutOfOutput = _prefix "OpttingOutOfOutput"
    /// <summary>
    /// Tendency of automatically relying or over-relying on the output produced by an AI system
    /// <see href="https://w3id.org/vair#Overreliance"></see></summary>
    let Overreliance = _prefix "Overreliance"
    /// <summary>
    /// Overriding outcome of a system.
    /// <see href="https://w3id.org/vair#OverridingOutcome"></see></summary>
    let OverridingOutcome = _prefix "OverridingOutcome"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Outcome"></see>
    /// </summary>
    let Outcome = _prefix "Outcome"
    /// <summary>
    /// Assigning a category (e.g. verb, noun, adjective) to a word based on its grammatical properties.
    /// <see href="https://w3id.org/vair#PartOfSpeechTagging"></see></summary>
    let PartOfSpeechTagging = _prefix "PartOfSpeechTagging"
    /// <summary>
    /// The level of automation where some sub-functions of the system are fully automated while the system remains under the control of an external agent
    /// <see href="https://w3id.org/vair#PartialAutomation"></see></summary>
    let PartialAutomation = _prefix "PartialAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Passenger"></see>
    /// </summary>
    let Passenger = _prefix "Passenger"
    /// <summary>
    /// Represents passive interactation with an AI system.
    /// <see href="https://w3id.org/vair#PassiveInvolvement"></see></summary>
    let PassiveInvolvement = _prefix "PassiveInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/vair#PatternRecognition"></see>
    /// </summary>
    let PatternRecognition = _prefix "PatternRecognition"
    /// <summary>
    /// Performing background checks
    /// <see href="https://w3id.org/vair#PerformingBackgroundCheck"></see></summary>
    let PerformingBackgroundCheck = _prefix "PerformingBackgroundCheck"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Perpetrator"></see>
    /// </summary>
    let Perpetrator = _prefix "Perpetrator"
    /// <summary>
    ///   <see href="https://w3id.org/vair#PersonalData"></see>
    /// </summary>
    let PersonalData = _prefix "PersonalData"
    /// <summary>
    /// Capability of a system in determining and analysing people's personality traits
    /// <see href="https://w3id.org/vair#PersonalityTraitsAnalysis"></see></summary>
    let PersonalityTraitsAnalysis = _prefix "PersonalityTraitsAnalysis"
    /// <summary>
    /// Refers to physical health.
    /// <see href="https://w3id.org/vair#PhysicalHealth"></see></summary>
    let PhysicalHealth = _prefix "PhysicalHealth"
    /// <summary>
    /// Represent physical injuries caused by AI
    /// <see href="https://w3id.org/vair#PhysicalInjury"></see></summary>
    let PhysicalInjury = _prefix "PhysicalInjury"
    /// <summary>
    /// Placing targeted job advertisments
    /// <see href="https://w3id.org/vair#PlacingTargetedJobAdvert"></see></summary>
    let PlacingTargetedJobAdvert = _prefix "PlacingTargetedJobAdvert"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Platform"></see>
    /// </summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// Police
    /// <see href="https://w3id.org/vair#Police"></see></summary>
    let Police = _prefix "Police"
    /// <summary>
    /// Description of the post-market monitoring plan, as required by the AI Act.
    /// <see href="https://w3id.org/vair#PostMarketMonitoringPlan"></see></summary>
    let PostMarketMonitoringPlan = _prefix "PostMarketMonitoringPlan"

    /// <summary>
    /// Description of the post-market monitoring system in place, as required by the AI Act.
    /// <see href="https://w3id.org/vair#PostMarketMonitoringSystemDescription"></see></summary>
    let PostMarketMonitoringSystemDescription =
        _prefix "PostMarketMonitoringSystemDescription"

    /// <summary>
    /// A person who may have applied for employment.
    /// <see href="https://w3id.org/vair#PotentialJobApplicant"></see></summary>
    let PotentialJobApplicant = _prefix "PotentialJobApplicant"
    /// <summary>
    /// A person who may have applied for public services.
    /// <see href="https://w3id.org/vair#PotentialPublicServicesApplicant"></see></summary>
    let PotentialPublicServicesApplicant = _prefix "PotentialPublicServicesApplicant"
    /// <summary>
    ///   <see href="https://w3id.org/vair#PreTrainedModel"></see>
    /// </summary>
    let PreTrainedModel = _prefix "PreTrainedModel"

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingOccurrenceOfCriminalOffence"></see>
    /// </summary>
    let PredictingOccurrenceOfCriminalOffence =
        _prefix "PredictingOccurrenceOfCriminalOffence"

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingRecidivism"></see>
    /// </summary>
    let PredictingRecidivism = _prefix "PredictingRecidivism"

    /// <summary>
    ///   <see href="https://w3id.org/vair#PredictingReoccurrenceOfCriminalOffence"></see>
    /// </summary>
    let PredictingReoccurrenceOfCriminalOffence =
        _prefix "PredictingReoccurrenceOfCriminalOffence"

    /// <summary>
    /// Primary output of an AI system when provided with input data or information.
    /// <see href="https://w3id.org/vair#Prediction"></see></summary>
    let Prediction = _prefix "Prediction"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Principle"></see>
    /// </summary>
    let Principle = _prefix "Principle"
    /// <summary>
    /// Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid
    /// <see href="https://w3id.org/vair#PrioritisationOfEmergencyService"></see></summary>
    let PrioritisationOfEmergencyService = _prefix "PrioritisationOfEmergencyService"
    /// <summary>
    /// Producing meaningful recommendations to users of the system
    /// <see href="https://w3id.org/vair#ProducingRecommendation"></see></summary>
    let ProducingRecommendation = _prefix "ProducingRecommendation"
    /// <summary>
    /// Refers to physical products.
    /// <see href="https://w3id.org/vair#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ProductManufacturer"></see>
    /// </summary>
    let ProductManufacturer = _prefix "ProductManufacturer"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ProductionData"></see>
    /// </summary>
    let ProductionData = _prefix "ProductionData"
    /// <summary>
    /// Any form of automated processing of personal data consisting of the use of personal data to evaluate certain personal aspects relating to a natural person, in particular to analyse or predict aspects concerning that natural person’s performance at work, economic situation, health, personal preferences, interests, reliability, behaviour, location or movements.
    /// <see href="https://w3id.org/vair#Profiling"></see></summary>
    let Profiling = _prefix "Profiling"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ProfilingPeople"></see>
    /// </summary>
    let ProfilingPeople = _prefix "ProfilingPeople"
    /// <summary>
    /// Prosecution of criminal offences
    /// <see href="https://w3id.org/vair#ProsecutingCriminalOffences"></see></summary>
    let ProsecutingCriminalOffences = _prefix "ProsecutingCriminalOffences"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ProsecutionOfCriminalOffences"></see>
    /// </summary>
    let ProsecutionOfCriminalOffences = _prefix "ProsecutionOfCriminalOffences"
    /// <summary>
    /// Represents negative impacts of AI on psychological health
    /// <see href="https://w3id.org/vair#PsychologicalHarm"></see></summary>
    let PsychologicalHarm = _prefix "PsychologicalHarm"
    /// <summary>
    /// Refers to psychological health.
    /// <see href="https://w3id.org/vair#PsychologicalHealth"></see></summary>
    let PsychologicalHealth = _prefix "PsychologicalHealth"
    /// <summary>
    /// Refers to public authorities and bodies.
    /// <see href="https://w3id.org/vair#PublicAuthority"></see></summary>
    let PublicAuthority = _prefix "PublicAuthority"
    /// <summary>
    /// An entity that acts on behalf of public authorities.
    /// <see href="https://w3id.org/vair#PublicAuthorityAgent"></see></summary>
    let PublicAuthorityAgent = _prefix "PublicAuthorityAgent"
    /// <summary>
    /// A person who has applied for public services and benefits
    /// <see href="https://w3id.org/vair#PublicServicesApplicant"></see></summary>
    let PublicServicesApplicant = _prefix "PublicServicesApplicant"
    /// <summary>
    /// Person who is recipient of public services and benefits
    /// <see href="https://w3id.org/vair#PublicServicesRecipient"></see></summary>
    let PublicServicesRecipient = _prefix "PublicServicesRecipient"
    /// <summary>
    ///   <see href="https://w3id.org/vair#PubliclyAccessibleSpace"></see>
    /// </summary>
    let PubliclyAccessibleSpace = _prefix "PubliclyAccessibleSpace"
    /// <summary>
    /// Determining the most appropriate answer to a question provided in natural language.
    /// <see href="https://w3id.org/vair#QuestionAnswering"></see></summary>
    let QuestionAnswering = _prefix "QuestionAnswering"
    /// <summary>
    /// After the operation and monitoring stage, based on the results of the work of the AI system, the need for a reassessment can arise.
    /// <see href="https://w3id.org/vair#ReEvaluation"></see></summary>
    let ReEvaluation = _prefix "ReEvaluation"
    /// <summary>
    /// Reclaiming natural persons healthcare services
    /// <see href="https://w3id.org/vair#ReclaimingHealthCareServices"></see></summary>
    let ReclaimingHealthCareServices = _prefix "ReclaimingHealthCareServices"

    /// <summary>
    /// Reclaiming essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#ReclaimingPublicAssistanceServices"></see></summary>
    let ReclaimingPublicAssistanceServices =
        _prefix "ReclaimingPublicAssistanceServices"

    /// <summary>
    /// Recognising emotions of a natural person
    /// <see href="https://w3id.org/vair#RecognisingEmotions"></see></summary>
    let RecognisingEmotions = _prefix "RecognisingEmotions"
    /// <summary>
    /// Recognising natural persons
    /// <see href="https://w3id.org/vair#RecognisingIndividuals"></see></summary>
    let RecognisingIndividuals = _prefix "RecognisingIndividuals"
    /// <summary>
    /// Recommendation generated by an AI system
    /// <see href="https://w3id.org/vair#Recommendation"></see></summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    ///   <see href="https://w3id.org/vair#RecommenderSystem"></see>
    /// </summary>
    let RecommenderSystem = _prefix "RecommenderSystem"
    /// <summary>
    /// Recruiting people for a job
    /// <see href="https://w3id.org/vair#Recruiting"></see></summary>
    let Recruiting = _prefix "Recruiting"
    /// <summary>
    /// Reducing natural persons healthcare services
    /// <see href="https://w3id.org/vair#ReducingHealthCareServices"></see></summary>
    let ReducingHealthCareServices = _prefix "ReducingHealthCareServices"
    /// <summary>
    /// Reducing essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#ReducingPublicAssistanceServices"></see></summary>
    let ReducingPublicAssistanceServices = _prefix "ReducingPublicAssistanceServices"
    /// <summary>
    /// Learning of an optimal sequence of actions to maximize a reward through interaction with an environment
    /// <see href="https://w3id.org/vair#ReinforcementLearning"></see></summary>
    let ReinforcementLearning = _prefix "ReinforcementLearning"
    /// <summary>
    /// Identifying relationships among entities mentioned in a text.
    /// <see href="https://w3id.org/vair#RelationshipExtraction"></see></summary>
    let RelationshipExtraction = _prefix "RelationshipExtraction"
    /// <summary>
    ///   <see href="https://w3id.org/vair#RemoteBiometricIdentification"></see>
    /// </summary>
    let RemoteBiometricIdentification = _prefix "RemoteBiometricIdentification"
    /// <summary>
    /// Refers to the identification of natural persons without their active involvement, typically at a distance
    /// <see href="https://w3id.org/vair#RemoteIdentification"></see></summary>
    let RemoteIdentification = _prefix "RemoteIdentification"
    /// <summary>
    ///   <see href="https://w3id.org/vair#RemoteIdentificationOfPeople"></see>
    /// </summary>
    let RemoteIdentificationOfPeople = _prefix "RemoteIdentificationOfPeople"
    /// <summary>
    /// Researching facts
    /// <see href="https://w3id.org/vair#ResearchingFacts"></see></summary>
    let ResearchingFacts = _prefix "ResearchingFacts"
    /// <summary>
    /// Researching the law
    /// <see href="https://w3id.org/vair#ResearchingLaw"></see></summary>
    let ResearchingLaw = _prefix "ResearchingLaw"
    /// <summary>
    /// A person who has applied for a residence permit
    /// <see href="https://w3id.org/vair#ResidencePermitApplicant"></see></summary>
    let ResidencePermitApplicant = _prefix "ResidencePermitApplicant"
    /// <summary>
    /// The stage the AI system become obsolete
    /// <see href="https://w3id.org/vair#Retirement"></see></summary>
    let Retirement = _prefix "Retirement"
    /// <summary>
    /// A mode of controllability that stakeholders can reverse the system’s output ex-post.
    /// <see href="https://w3id.org/vair#ReverseOutput"></see></summary>
    let ReverseOutput = _prefix "ReverseOutput"
    /// <summary>
    /// Reversing the outcome of a system.
    /// <see href="https://w3id.org/vair#ReversingOutcome"></see></summary>
    let ReversingOutcome = _prefix "ReversingOutcome"
    /// <summary>
    /// Revoking natural persons healthcare services
    /// <see href="https://w3id.org/vair#RevokingHealthCareServices"></see></summary>
    let RevokingHealthCareServices = _prefix "RevokingHealthCareServices"
    /// <summary>
    /// Revoking essential public assistance benefits and services
    /// <see href="https://w3id.org/vair#RevokingPublicAssistanceServices"></see></summary>
    let RevokingPublicAssistanceServices = _prefix "RevokingPublicAssistanceServices"
    /// <summary>
    /// Refers to fundamental rights.
    /// <see href="https://w3id.org/vair#Right"></see></summary>
    let Right = _prefix "Right"
    /// <summary>
    /// Refers to the fundamental right to non-discrimination
    /// <see href="https://w3id.org/vair#RightToNondiscrimination"></see></summary>
    let RightToNondiscrimination = _prefix "RightToNondiscrimination"
    /// <summary>
    ///   <see href="https://w3id.org/vair#RobotSystem"></see>
    /// </summary>
    let RobotSystem = _prefix "RobotSystem"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SVM"></see>
    /// </summary>
    let SVM = _prefix "SVM"
    /// <summary>
    /// a machine learning algorithm that finds decision boundaries with maximal margins.
    /// <see href="https://w3id.org/vair#SupportVectorMachine"></see></summary>
    let SupportVectorMachine = _prefix "SupportVectorMachine"
    /// <summary>
    /// Refers to the state of safety.
    /// <see href="https://w3id.org/vair#Safety"></see></summary>
    let Safety = _prefix "Safety"
    /// <summary>
    /// Component of a product or of an AI system which fulfils a safety function for that product or AI system, or the failure or malfunctioning of which endangers the health and safety of persons or property
    /// <see href="https://w3id.org/vair#SafetyComponent"></see></summary>
    let SafetyComponent = _prefix "SafetyComponent"
    /// <summary>
    /// Refers to statistical-based search Methods
    /// <see href="https://w3id.org/vair#SearchMethod"></see></summary>
    let SearchMethod = _prefix "SearchMethod"
    /// <summary>
    /// Refers to security measures
    /// <see href="https://w3id.org/vair#SecurityMeasure"></see></summary>
    let SecurityMeasure = _prefix "SecurityMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SelectingPeople"></see>
    /// </summary>
    let SelectingPeople = _prefix "SelectingPeople"
    /// <summary>
    /// Machine learning that makes use of both labelled and unlabelled data during training
    /// <see href="https://w3id.org/vair#SemiSupervisedLearning"></see></summary>
    let SemiSupervisedLearning = _prefix "SemiSupervisedLearning"
    /// <summary>
    /// The capability of infering sensitive or protected attributes or characteristics
    /// <see href="https://w3id.org/vair#SensitiveAttributeInference"></see></summary>
    let SensitiveAttributeInference = _prefix "SensitiveAttributeInference"
    /// <summary>
    /// Computationally identifying and categorizing opinions expressed in a piece of text, speech or image, to determine a range of feeling such as from positive to negative.
    /// <see href="https://w3id.org/vair#SentimentAnalysis"></see></summary>
    let SentimentAnalysis = _prefix "SentimentAnalysis"
    /// <summary>
    /// Refers to system provided as a service
    /// <see href="https://w3id.org/vair#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A robot in personal use or professional use that performs useful tasks for humans or equipment.
    /// <see href="https://w3id.org/vair#ServiceRobot"></see></summary>
    let ServiceRobot = _prefix "ServiceRobot"
    /// <summary>
    /// Purpose of providing safety function
    /// <see href="https://w3id.org/vair#ServingSafetyFunction"></see></summary>
    let ServingSafetyFunction = _prefix "ServingSafetyFunction"
    /// <summary>
    /// Purpose of providing safety function in management of services
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagement"></see></summary>
    let ServingSafetyFunctionInManagement = _prefix "ServingSafetyFunctionInManagement"

    /// <summary>
    /// Purpose of providing safety function in management of critical digital infrastructure
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure"></see></summary>
    let ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure =
        _prefix "ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure"

    /// <summary>
    /// Purpose of providing safety function in management of road traffic
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfRoadTraffic"></see></summary>
    let ServingSafetyFunctionInManagementOfRoadTraffic =
        _prefix "ServingSafetyFunctionInManagementOfRoadTraffic"

    /// <summary>
    /// Purpose of providing safety function in management of the supply of electricity
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfElectricity =
        _prefix "ServingSafetyFunctionInManagementOfTheSupplyOfElectricity"

    /// <summary>
    /// Purpose of providing safety function in management of the supply of gas
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfGas =
        _prefix "ServingSafetyFunctionInManagementOfTheSupplyOfGas"

    /// <summary>
    /// Purpose of providing safety function in management of the supply of heating
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfHeating =
        _prefix "ServingSafetyFunctionInManagementOfTheSupplyOfHeating"

    /// <summary>
    /// Purpose of providing safety function in management of the supply of water
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater"></see></summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfWater =
        _prefix "ServingSafetyFunctionInManagementOfTheSupplyOfWater"

    /// <summary>
    /// Purpose of providing safety function in operation of services
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperation"></see></summary>
    let ServingSafetyFunctionInOperation = _prefix "ServingSafetyFunctionInOperation"

    /// <summary>
    /// Purpose of providing safety function in operation of critical digital infrastructure
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure"></see></summary>
    let ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure =
        _prefix "ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure"

    /// <summary>
    /// Purpose of providing safety function in operation of road traffic
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfRoadTraffic"></see></summary>
    let ServingSafetyFunctionInOperationOfRoadTraffic =
        _prefix "ServingSafetyFunctionInOperationOfRoadTraffic"

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of electricity
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfElectricity =
        _prefix "ServingSafetyFunctionInOperationOfTheSupplyOfElectricity"

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of gas
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfGas =
        _prefix "ServingSafetyFunctionInOperationOfTheSupplyOfGas"

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of heating
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfHeating =
        _prefix "ServingSafetyFunctionInOperationOfTheSupplyOfHeating"

    /// <summary>
    /// Purpose of providing safety function in operation of the supply of water
    /// <see href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater"></see></summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfWater =
        _prefix "ServingSafetyFunctionInOperationOfTheSupplyOfWater"

    /// <summary>
    /// Alternative dispute resolution
    /// <see href="https://w3id.org/vair#SettlingDispute"></see></summary>
    let SettlingDispute = _prefix "SettlingDispute"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SmallScaleProvider"></see>
    /// </summary>
    let SmallScaleProvider = _prefix "SmallScaleProvider"
    /// <summary>
    /// Robots with social interaction functions.
    /// <see href="https://w3id.org/vair#SocialRobot"></see></summary>
    let SocialRobot = _prefix "SocialRobot"
    /// <summary>
    /// Refers to a stand alone software system
    /// <see href="https://w3id.org/vair#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SoundEventRecognition"></see>
    /// </summary>
    let SoundEventRecognition = _prefix "SoundEventRecognition"
    /// <summary>
    /// Extracting individual sound from audio recordings.
    /// <see href="https://w3id.org/vair#SoundSourceSeparation"></see></summary>
    let SoundSourceSeparation = _prefix "SoundSourceSeparation"
    /// <summary>
    /// Generation of artificial sound.
    /// <see href="https://w3id.org/vair#SoundSynthesis"></see></summary>
    let SoundSynthesis = _prefix "SoundSynthesis"
    /// <summary>
    /// Recognising speaker in audio recordings.
    /// <see href="https://w3id.org/vair#SpeakerRecognition"></see></summary>
    let SpeakerRecognition = _prefix "SpeakerRecognition"
    /// <summary>
    /// Converting a speech signal to a representation of the content of the speech.
    /// <see href="https://w3id.org/vair#SpeechRecognition"></see></summary>
    let SpeechRecognition = _prefix "SpeechRecognition"
    /// <summary>
    /// Generation of artificial speech.
    /// <see href="https://w3id.org/vair#SpeechSynthesis"></see></summary>
    let SpeechSynthesis = _prefix "SpeechSynthesis"
    /// <summary>
    /// Incompetence of staff such as human oversight actors
    /// <see href="https://w3id.org/vair#StaffIncompetence"></see></summary>
    let StaffIncompetence = _prefix "StaffIncompetence"
    /// <summary>
    /// Machine learning that makes only use of labelled data during training
    /// <see href="https://w3id.org/vair#SupervisedLearning"></see></summary>
    let SupervisedLearning = _prefix "SupervisedLearning"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Suspect"></see>
    /// </summary>
    let Suspect = _prefix "Suspect"
    /// <summary>
    /// Reasoning based on the knowledge encoded in a formal language
    /// <see href="https://w3id.org/vair#SymbolicReasoning"></see></summary>
    let SymbolicReasoning = _prefix "SymbolicReasoning"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SystemArchitecture"></see>
    /// </summary>
    let SystemArchitecture = _prefix "SystemArchitecture"
    /// <summary>
    /// Documentation specifying software architecture.
    /// <see href="https://w3id.org/vair#SystemArchitectureDocumentation"></see></summary>
    let SystemArchitectureDocumentation = _prefix "SystemArchitectureDocumentation"
    /// <summary>
    /// Risk sources related to the AI system
    /// <see href="https://w3id.org/vair#SystemRiskSource"></see></summary>
    let SystemRiskSource = _prefix "SystemRiskSource"
    /// <summary>
    ///   <see href="https://w3id.org/vair#SystemVulnerability"></see>
    /// </summary>
    let SystemVulnerability = _prefix "SystemVulnerability"
    /// <summary>
    /// Documentation required by the AI Act, Article 11.
    /// <see href="https://w3id.org/vair#TechnicalDocumentation"></see></summary>
    let TechnicalDocumentation = _prefix "TechnicalDocumentation"
    /// <summary>
    /// Refers to technical measures
    /// <see href="https://w3id.org/vair#TechnicalMeasure"></see></summary>
    let TechnicalMeasure = _prefix "TechnicalMeasure"
    /// <summary>
    /// An AI application-specific integrated circuit developed by Google.
    /// <see href="https://w3id.org/vair#TensorProcessingUnit"></see></summary>
    let TensorProcessingUnit = _prefix "TensorProcessingUnit"
    /// <summary>
    /// Log of the tests performed.
    /// <see href="https://w3id.org/vair#TestLog"></see></summary>
    let TestLog = _prefix "TestLog"
    /// <summary>
    /// A document that includes a summary of test activities and their results.
    /// <see href="https://w3id.org/vair#TestReport"></see></summary>
    let TestReport = _prefix "TestReport"
    /// <summary>
    ///   <see href="https://w3id.org/vair#Testing"></see>
    /// </summary>
    let Testing = _prefix "Testing"
    /// <summary>
    /// Refers to a software tool
    /// Tool
    /// <see href="https://w3id.org/vair#Tool"></see></summary>
    let Tool = _prefix "Tool"
    /// <summary>
    /// Model resulted from model training.
    /// <see href="https://w3id.org/vair#TrainedModel"></see></summary>
    let TrainedModel = _prefix "TrainedModel"
    /// <summary>
    ///   <see href="https://w3id.org/vair#ModelTraning"></see>
    /// </summary>
    let ModelTraning = _prefix "ModelTraning"
    /// <summary>
    /// Refers to transparency measures
    /// <see href="https://w3id.org/vair#TransparencyMeasure"></see></summary>
    let TransparencyMeasure = _prefix "TransparencyMeasure"
    /// <summary>
    /// Use of datasets that are not available
    /// <see href="https://w3id.org/vair#UnavailabilityOfData"></see></summary>
    let UnavailabilityOfData = _prefix "UnavailabilityOfData"
    /// <summary>
    /// Represents that a specific actor was not informed that an AI system is in place.
    /// <see href="https://w3id.org/vair#UninformedInvolvement"></see></summary>
    let UninformedInvolvement = _prefix "UninformedInvolvement"
    /// <summary>
    /// Represents unintended involvement of a specific actor.
    /// <see href="https://w3id.org/vair#UnintendedInvolvement"></see></summary>
    let UnintendedInvolvement = _prefix "UnintendedInvolvement"
    /// <summary>
    /// Use of unrepresentative  data for testing
    /// <see href="https://w3id.org/vair#UnrepresentativeTestData"></see></summary>
    let UnrepresentativeTestData = _prefix "UnrepresentativeTestData"
    /// <summary>
    /// Use of unrepresentative data for training
    /// <see href="https://w3id.org/vair#UnrepresentativeTrainingData"></see></summary>
    let UnrepresentativeTrainingData = _prefix "UnrepresentativeTrainingData"
    /// <summary>
    /// Use of unrepresentative data for validation
    /// <see href="https://w3id.org/vair#UnrepresentativeValidationData"></see></summary>
    let UnrepresentativeValidationData = _prefix "UnrepresentativeValidationData"
    /// <summary>
    /// Machine learning that makes only use of unlabelled data during training.
    /// <see href="https://w3id.org/vair#UnsupervisedLearning"></see></summary>
    let UnsupervisedLearning = _prefix "UnsupervisedLearning"
    /// <summary>
    /// Providing training to staff, users, etc.
    /// <see href="https://w3id.org/vair#UserTraining"></see></summary>
    let UserTraining = _prefix "UserTraining"
    /// <summary>
    /// Validating that the AI system from the design and development stage works according to requirements and meets objectives.
    /// <see href="https://w3id.org/vair#Validation"></see></summary>
    let Validation = _prefix "Validation"
    /// <summary>
    /// Verifying the AI system from the design and development stage works according to requirements and meets objectives.
    /// <see href="https://w3id.org/vair#Verification"></see></summary>
    let Verification = _prefix "Verification"

    /// <summary>
    ///   <see href="https://w3id.org/vair#VerificationOfMigrationSeekerClaims"></see>
    /// </summary>
    let VerificationOfMigrationSeekerClaims =
        _prefix "VerificationOfMigrationSeekerClaims"

    /// <summary>
    /// Verifying of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features.
    /// <see href="https://w3id.org/vair#VerifyingAuthenticityOfTravelDocument"></see></summary>
    let VerifyingAuthenticityOfTravelDocument =
        _prefix "VerifyingAuthenticityOfTravelDocument"

    /// <summary>
    ///   <see href="https://w3id.org/vair#Victim"></see>
    /// </summary>
    let Victim = _prefix "Victim"
    /// <summary>
    /// A person who has applied for a visa
    /// <see href="https://w3id.org/vair#VisaApplicant"></see></summary>
    let VisaApplicant = _prefix "VisaApplicant"
    /// <summary>
    /// Vocational training institution at any level
    /// <see href="https://w3id.org/vair#VocationalTrainingInstitution"></see></summary>
    let VocationalTrainingInstitution = _prefix "VocationalTrainingInstitution"
    /// <summary>
    /// Refers to the wrong choice made in the selecting datasets.
    /// <see href="https://w3id.org/vair#WrongDataDesignChoice"></see></summary>
    let WrongDataDesignChoice = _prefix "WrongDataDesignChoice"
