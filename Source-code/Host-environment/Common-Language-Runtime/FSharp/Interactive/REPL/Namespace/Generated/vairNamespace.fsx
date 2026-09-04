#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vair =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/vair#" "vair"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.</para>
    ///   <para>rdfs:comment : Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.</para>
    ///   <para>skos:prefLabel : Artificial General Intelligence</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.14^^xsd:string</para>
    ///   <para>rdfs:label : Artificial General Intelligence</para>
    ///   <a href="https://w3id.org/vair#AGI">vair:AGI</a>
    /// </summary>
    let AGI = _prefixId.prefix "AGI"
    /// <summary>
    ///   <para>rdfs:label : AI Cards</para>
    ///   <para>skos:definition : A form of AI documentation</para>
    ///   <para>skos:prefLabel : AI Cards</para>
    ///   <para>rdfs:comment : A form of AI documentation</para>
    ///   <a href="https://w3id.org/vair#AICards">vair:AICards</a>
    /// </summary>
    let AICards = _prefixId.prefix "AICards"
    let AIComponent = _prefixId.prefix "AIComponent"
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <para>skos:definition : Action performed by a system.</para>
    ///   <para>skos:prefLabel : Action</para>
    ///   <para>rdfs:comment : Action performed by a system.</para>
    ///   <a href="https://w3id.org/vair#Action">vair:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>skos:definition : The capability to recognise actions</para>
    ///   <para>skos:prefLabel : Action Recognition</para>
    ///   <para>rdfs:comment : The capability to recognise actions</para>
    ///   <para>rdfs:label : Action Recognition</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#ActionRecognition">vair:ActionRecognition</a>
    /// </summary>
    let ActionRecognition = _prefixId.prefix "ActionRecognition"
    /// <summary>
    ///   <para>rdfs:label : Active Involvement</para>
    ///   <para>rdfs:comment : Represents active interactation with an AI system.</para>
    ///   <para>skos:prefLabel : Active Involvement</para>
    ///   <para>skos:definition : Represents active interactation with an AI system.</para>
    ///   <a href="https://w3id.org/vair#ActiveInvolvement">vair:ActiveInvolvement</a>
    /// </summary>
    let ActiveInvolvement = _prefixId.prefix "ActiveInvolvement"

    /// <summary>
    ///   <para>rdfs:label : Administration Of Democratic Processes</para>
    ///   <para>skos:prefLabel : Administration Of Democratic Processes</para>
    ///   <para>rdfs:comment : Activities related to administration of democratic processes</para>
    ///   <para>skos:definition : Activities related to administration of democratic processes</para>
    ///   <a href="https://w3id.org/vair#AdministrationOfDemocraticProcesses">vair:AdministrationOfDemocraticProcesses</a>
    /// </summary>
    let AdministrationOfDemocraticProcesses =
        _prefixId.prefix "AdministrationOfDemocraticProcesses"

    /// <summary>
    ///   <para>rdfs:label : Administration Of Justice</para>
    ///   <para>skos:definition : Activities related to administration of justice.</para>
    ///   <para>rdfs:comment : Activities related to administration of justice.</para>
    ///   <para>skos:prefLabel : Administration Of Justice</para>
    ///   <a href="https://w3id.org/vair#AdministrationOfJustice">vair:AdministrationOfJustice</a>
    /// </summary>
    let AdministrationOfJustice = _prefixId.prefix "AdministrationOfJustice"
    /// <summary>
    ///   <para>skos:definition : Inputs designed to cause the model to make a mistake</para>
    ///   <para>rdfs:label : Adversarial Attack</para>
    ///   <para>rdfs:comment : Inputs designed to cause the model to make a mistake</para>
    ///   <para>skos:prefLabel : Adversarial Attack</para>
    ///   <a href="https://w3id.org/vair#AdversarialAttack">vair:AdversarialAttack</a>
    /// </summary>
    let AdversarialAttack = _prefixId.prefix "AdversarialAttack"
    /// <summary>
    ///   <para>rdfs:comment : Defines a set of instructions^^xsd:string</para>
    ///   <para>skos:definition : Defines a set of instructions</para>
    ///   <para>rdfs:label : Algorithm</para>
    ///   <para>skos:prefLabel : Algorithm</para>
    ///   <a href="https://w3id.org/vair#Algorithm">vair:Algorithm</a>
    /// </summary>
    let Algorithm = _prefixId.prefix "Algorithm"
    /// <summary>
    ///   <para>skos:prefLabel : Allocating Tasks</para>
    ///   <para>skos:definition : Assignment of tasks to persons</para>
    ///   <para>rdfs:comment : Assignment of tasks to persons</para>
    ///   <para>rdfs:label : Allocating Tasks</para>
    ///   <a href="https://w3id.org/vair#AllocatingTasks">vair:AllocatingTasks</a>
    /// </summary>
    let AllocatingTasks = _prefixId.prefix "AllocatingTasks"
    /// <summary>
    ///   <para>rdfs:comment : Resource on which an application runs.</para>
    ///   <para>rdfs:label : Application Platform</para>
    ///   <para>skos:prefLabel : Application Platform</para>
    ///   <para>skos:definition : Resource on which an application runs.</para>
    ///   <a href="https://w3id.org/vair#ApplicationPlatform">vair:ApplicationPlatform</a>
    /// </summary>
    let ApplicationPlatform = _prefixId.prefix "ApplicationPlatform"
    let ApplicationScreening = _prefixId.prefix "ApplicationScreening"

    /// <summary>
    ///   <para>skos:definition : An integrated circuit chip customized for a particular use</para>
    ///   <para>rdfs:comment : An integrated circuit chip customized for a particular use.</para>
    ///   <para>skos:prefLabel : Application Specific Integrated Circuit</para>
    ///   <para>rdfs:label : Application Specific Integrated Circuit</para>
    ///   <a href="https://w3id.org/vair#ApplicationSpecificIntegratedCircuit">vair:ApplicationSpecificIntegratedCircuit</a>
    /// </summary>
    let ApplicationSpecificIntegratedCircuit =
        _prefixId.prefix "ApplicationSpecificIntegratedCircuit"

    /// <summary>
    ///   <para>rdfs:label : Applying The Law To Facts</para>
    ///   <para>rdfs:comment : Applying the law to a concrete set of facts</para>
    ///   <para>skos:definition : Applying the law to a concrete set of facts</para>
    ///   <para>skos:prefLabel : Applying The Law To Facts</para>
    ///   <a href="https://w3id.org/vair#ApplyingTheLawToFacts">vair:ApplyingTheLawToFacts</a>
    /// </summary>
    let ApplyingTheLawToFacts = _prefixId.prefix "ApplyingTheLawToFacts"
    /// <summary>
    ///   <para>skos:prefLabel : Approval</para>
    ///   <para>rdfs:label : Approval</para>
    ///   <para>skos:definition : Approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk.</para>
    ///   <para>rdfs:comment : Approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk.</para>
    ///   <a href="https://w3id.org/vair#Approval">vair:Approval</a>
    /// </summary>
    let Approval = _prefixId.prefix "Approval"
    let AssesingStudent = _prefixId.prefix "AssesingStudent"

    /// <summary>
    ///   <para>skos:prefLabel : Assessing Accessible Level Of Education</para>
    ///   <para>skos:definition : Assessing the appropriate level of education that an individual will be able to access</para>
    ///   <para>rdfs:comment : Assessing the appropriate level of education that an individual will be able to access</para>
    ///   <para>rdfs:label : Assessing Accessible Level Of Education</para>
    ///   <a href="https://w3id.org/vair#AssessingAccessibleLevelOfEducation">vair:AssessingAccessibleLevelOfEducation</a>
    /// </summary>
    let AssessingAccessibleLevelOfEducation =
        _prefixId.prefix "AssessingAccessibleLevelOfEducation"

    let AssessingAdmissionTest = _prefixId.prefix "AssessingAdmissionTest"
    /// <summary>
    ///   <para>rdfs:label : Assessing Creditworthiness</para>
    ///   <para>rdfs:comment : Evaluation the creditworthiness of natural persons or establishing their credit score</para>
    ///   <para>skos:definition : Evaluation the creditworthiness of natural persons or establishing their credit score</para>
    ///   <para>skos:prefLabel : Assessing Creditworthiness</para>
    ///   <a href="https://w3id.org/vair#AssessingCreditworthiness">vair:AssessingCreditworthiness</a>
    /// </summary>
    let AssessingCreditworthiness = _prefixId.prefix "AssessingCreditworthiness"
    /// <summary>
    ///   <para>rdfs:comment : Assessing health risk posed by a person</para>
    ///   <para>skos:definition : Assessing health risk posed by a person</para>
    ///   <para>skos:prefLabel : Assessing Health Risk</para>
    ///   <para>rdfs:label : Assessing Health Risk</para>
    ///   <a href="https://w3id.org/vair#AssessingHealthRisk">vair:AssessingHealthRisk</a>
    /// </summary>
    let AssessingHealthRisk = _prefixId.prefix "AssessingHealthRisk"

    let AssessingImmigrationEligibility =
        _prefixId.prefix "AssessingImmigrationEligibility"

    /// <summary>
    ///   <para>skos:definition : Assessing the appropriate level of education that an individual will receive</para>
    ///   <para>rdfs:comment : Assessing the appropriate level of education that an individual will receive</para>
    ///   <para>skos:prefLabel : Assessing Level Of Education</para>
    ///   <para>rdfs:label : Assessing Level Of Education</para>
    ///   <a href="https://w3id.org/vair#AssessingLevelOfEducation">vair:AssessingLevelOfEducation</a>
    /// </summary>
    let AssessingLevelOfEducation = _prefixId.prefix "AssessingLevelOfEducation"

    /// <summary>
    ///   <para>rdfs:label : Assessing Past Criminal Behaviour</para>
    ///   <para>skos:prefLabel : Assessing Past Criminal Behaviour</para>
    ///   <para>skos:definition : Assessing past criminal behaviour of natural persons or groups</para>
    ///   <para>rdfs:comment : Assessing past criminal behaviour of natural persons or groups</para>
    ///   <a href="https://w3id.org/vair#AssessingPastCriminalBehaviour">vair:AssessingPastCriminalBehaviour</a>
    /// </summary>
    let AssessingPastCriminalBehaviour =
        _prefixId.prefix "AssessingPastCriminalBehaviour"

    /// <summary>
    ///   <para>rdfs:comment : Assessing a risk, e.g. a security risk, a risk of irregular migration, or a health risk, posed by a natural person</para>
    ///   <para>skos:prefLabel : Assessing People Related Risk</para>
    ///   <para>rdfs:label : Assessing People Related Risk</para>
    ///   <para>skos:definition : Assessing a risk, e.g. a security risk, a risk of irregular migration, or a health risk, posed by a natural person</para>
    ///   <a href="https://w3id.org/vair#AssessingPeopleRelatedRisk">vair:AssessingPeopleRelatedRisk</a>
    /// </summary>
    let AssessingPeopleRelatedRisk = _prefixId.prefix "AssessingPeopleRelatedRisk"
    /// <summary>
    ///   <para>rdfs:label : Assessing Personality Traits</para>
    ///   <para>rdfs:comment : Assessing personality of natural persons or groups</para>
    ///   <para>skos:definition : Assessing personality of natural persons or groups</para>
    ///   <para>skos:prefLabel : Assessing Personality Traits</para>
    ///   <a href="https://w3id.org/vair#AssessingPersonalityTraits">vair:AssessingPersonalityTraits</a>
    /// </summary>
    let AssessingPersonalityTraits = _prefixId.prefix "AssessingPersonalityTraits"

    /// <summary>
    ///   <para>skos:definition : Assessing risk of a natural person becoming the victim of criminal offences</para>
    ///   <para>rdfs:label : Assessing Risk For Potential Victims Of Criminal Offences</para>
    ///   <para>rdfs:comment : Assessing risk of a natural person becoming the victim of criminal offences</para>
    ///   <para>skos:prefLabel : Assessing Risk For Potential Victims Of Criminal Offences</para>
    ///   <a href="https://w3id.org/vair#AssessingRiskOfBecomingVictimOfCrime">vair:AssessingRiskOfBecomingVictimOfCrime</a>
    /// </summary>
    let AssessingRiskOfBecomingVictimOfCrime =
        _prefixId.prefix "AssessingRiskOfBecomingVictimOfCrime"

    /// <summary>
    ///   <para>skos:prefLabel : Assessing Risk Of Irregular Immigration</para>
    ///   <para>rdfs:label : Assessing Risk Of Irregular Immigration</para>
    ///   <para>rdfs:comment : Assessing risk of irregular immigration posed by a person</para>
    ///   <para>skos:definition : Assessing risk of irregular immigration posed by a person</para>
    ///   <a href="https://w3id.org/vair#AssessingRiskOfIrregularImmigration">vair:AssessingRiskOfIrregularImmigration</a>
    /// </summary>
    let AssessingRiskOfIrregularImmigration =
        _prefixId.prefix "AssessingRiskOfIrregularImmigration"

    /// <summary>
    ///   <para>skos:definition : Assessing the risk of a natural person offending</para>
    ///   <para>skos:prefLabel : Assessing Risk Of Offending</para>
    ///   <para>rdfs:label : Assessing Risk Of Offending</para>
    ///   <para>rdfs:comment : Assessing the risk of a natural person offending</para>
    ///   <a href="https://w3id.org/vair#AssessingRiskOfOffending">vair:AssessingRiskOfOffending</a>
    /// </summary>
    let AssessingRiskOfOffending = _prefixId.prefix "AssessingRiskOfOffending"
    /// <summary>
    ///   <para>skos:prefLabel : Assessing Risk Of Reoffending</para>
    ///   <para>rdfs:label : Assessing Risk Of Reoffending</para>
    ///   <para>rdfs:comment : Assessing the risk of a natural person re-offending</para>
    ///   <para>skos:definition : Assessing the risk of a natural person re-offending</para>
    ///   <a href="https://w3id.org/vair#AssessingRiskOfReoffending">vair:AssessingRiskOfReoffending</a>
    /// </summary>
    let AssessingRiskOfReoffending = _prefixId.prefix "AssessingRiskOfReoffending"
    /// <summary>
    ///   <para>rdfs:label : Assessing Security Risk</para>
    ///   <para>skos:definition : Assess security risk posed by a person</para>
    ///   <para>rdfs:comment : Assess security risk posed by a person</para>
    ///   <para>skos:prefLabel : Assessing Security Risk</para>
    ///   <a href="https://w3id.org/vair#AssessingSecurityRisk">vair:AssessingSecurityRisk</a>
    /// </summary>
    let AssessingSecurityRisk = _prefixId.prefix "AssessingSecurityRisk"
    /// <summary>
    ///   <para>skos:definition : Assessment and evaluation</para>
    ///   <para>skos:prefLabel : Assessment</para>
    ///   <para>rdfs:comment : Assessment and evaluation</para>
    ///   <para>rdfs:label : Assessment</para>
    ///   <a href="https://w3id.org/vair#Assessment">vair:Assessment</a>
    /// </summary>
    let Assessment = _prefixId.prefix "Assessment"

    /// <summary>
    ///   <para>rdfs:comment : Assigning natural persons to educational institutions at all levels.</para>
    ///   <para>skos:definition : Assigning natural persons to educational institutions at all levels.</para>
    ///   <para>skos:prefLabel : Assigning Persons To Educational Institutions</para>
    ///   <para>rdfs:label : Assigning Persons To Educational Institutions</para>
    ///   <a href="https://w3id.org/vair#AssigningPersonsToEducationalInstitutions">vair:AssigningPersonsToEducationalInstitutions</a>
    /// </summary>
    let AssigningPersonsToEducationalInstitutions =
        _prefixId.prefix "AssigningPersonsToEducationalInstitutions"

    /// <summary>
    ///   <para>skos:definition : Assigning natural persons to vocational training institutions at all levels.</para>
    ///   <para>skos:prefLabel : Assigning Persons To Vocational Training Institutions</para>
    ///   <para>rdfs:label : Assigning Persons To Vocational Training Institutions</para>
    ///   <para>rdfs:comment : Assigning natural persons to vocational training institutions at all levels.</para>
    ///   <a href="https://w3id.org/vair#AssigningPersonsToVocationalTrainingInstitutions">vair:AssigningPersonsToVocationalTrainingInstitutions</a>
    /// </summary>
    let AssigningPersonsToVocationalTrainingInstitutions =
        _prefixId.prefix "AssigningPersonsToVocationalTrainingInstitutions"

    /// <summary>
    ///   <para>rdfs:label : Assistive Automation</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <para>rdfs:comment : The level of automation where the system assists an operator</para>
    ///   <para>skos:definition : The level of automation where the system assists an operator</para>
    ///   <para>skos:prefLabel : Assistive Automation</para>
    ///   <a href="https://w3id.org/vair#AssistiveAutomation">vair:AssistiveAutomation</a>
    /// </summary>
    let AssistiveAutomation = _prefixId.prefix "AssistiveAutomation"
    /// <summary>
    ///   <para>rdfs:comment : Activities related to asylum management</para>
    ///   <para>skos:definition : Activities related to asylum management.</para>
    ///   <para>rdfs:label : Asylum Management</para>
    ///   <para>skos:prefLabel : Asylum Management</para>
    ///   <a href="https://w3id.org/vair#AsylumManagement">vair:AsylumManagement</a>
    /// </summary>
    let AsylumManagement = _prefixId.prefix "AsylumManagement"
    /// <summary>
    ///   <para>skos:prefLabel : Asylum Seeker</para>
    ///   <para>rdfs:comment : A person who has applied for asylum</para>
    ///   <para>rdfs:label : Asylum Seeker</para>
    ///   <para>skos:definition : A person who has applied for asylum</para>
    ///   <a href="https://w3id.org/vair#AsylumSeeker">vair:AsylumSeeker</a>
    /// </summary>
    let AsylumSeeker = _prefixId.prefix "AsylumSeeker"
    /// <summary>
    ///   <para>skos:prefLabel : Attack</para>
    ///   <para>rdfs:label : Attack</para>
    ///   <para>skos:definition : Malicious attempts to exploit vulnerabilities</para>
    ///   <para>rdfs:comment : Malicious attempts to exploit vulnerabilities</para>
    ///   <a href="https://w3id.org/vair#Attack">vair:Attack</a>
    /// </summary>
    let Attack = _prefixId.prefix "Attack"
    /// <summary>
    ///   <para>skos:prefLabel : Audio Processing</para>
    ///   <para>rdfs:comment : The capability to process audio recordings.</para>
    ///   <para>rdfs:label : Audio Processing</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>skos:definition : The capability to process audio recordings.^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#AudioProcessing">vair:AudioProcessing</a>
    /// </summary>
    let AudioProcessing = _prefixId.prefix "AudioProcessing"
    let AuthorisedRepresentative = _prefixId.prefix "AuthorisedRepresentative"
    let Authority = _prefixId.prefix "Authority"
    /// <summary>
    ///   <para>rdfs:label : Automatic Summarisation</para>
    ///   <para>rdfs:comment : Shortening a portion of natural language content or text while retaining important semantic information.</para>
    ///   <para>skos:definition : Shortening a portion of natural language content or text while retaining important semantic information.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.1</para>
    ///   <para>skos:prefLabel : Automatic Summarisation</para>
    ///   <a href="https://w3id.org/vair#AutomaticSummarisation">vair:AutomaticSummarisation</a>
    /// </summary>
    let AutomaticSummarisation = _prefixId.prefix "AutomaticSummarisation"
    let AutonomousSystem = _prefixId.prefix "AutonomousSystem"
    /// <summary>
    ///   <para>rdfs:label : Autonomy</para>
    ///   <para>rdfs:comment : The level of automation where the system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.</para>
    ///   <para>skos:definition : The level of automation where the system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <para>skos:prefLabel : Autonomy</para>
    ///   <a href="https://w3id.org/vair#Autonomy">vair:Autonomy</a>
    /// </summary>
    let Autonomy = _prefixId.prefix "Autonomy"
    /// <summary>
    ///   <para>skos:prefLabel : Bayesian Estimation</para>
    ///   <para>rdfs:label : Bayesian Estimation</para>
    ///   <para>skos:definition : Refers to Bayesian estimation approach</para>
    ///   <para>rdfs:comment : Refers to Bayesian estimation approach</para>
    ///   <a href="https://w3id.org/vair#BayesianEstimation">vair:BayesianEstimation</a>
    /// </summary>
    let BayesianEstimation = _prefixId.prefix "BayesianEstimation"
    /// <summary>
    ///   <para>rdfs:label : Bayesian Network</para>
    ///   <para>skos:definition : Probabilistic model  that uses Bayesian inference  for probability computations using a directed acyclic graph.</para>
    ///   <para>rdfs:comment : Probabilistic model  that uses Bayesian inference  for probability computations using a directed acyclic graph.</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.3.1^^xsd:string</para>
    ///   <para>skos:prefLabel : Bayesian Network</para>
    ///   <a href="https://w3id.org/vair#BayesianNetwork">vair:BayesianNetwork</a>
    /// </summary>
    let BayesianNetwork = _prefixId.prefix "BayesianNetwork"
    /// <summary>
    ///   <para>skos:definition : Refers to Bayesian optimisation technique.</para>
    ///   <para>rdfs:label : Bayesian Optimisation</para>
    ///   <para>skos:prefLabel : Bayesian Optimisation</para>
    ///   <para>rdfs:comment : Refers to Bayesian optimisation technique.</para>
    ///   <a href="https://w3id.org/vair#BayesianOptimisation">vair:BayesianOptimisation</a>
    /// </summary>
    let BayesianOptimisation = _prefixId.prefix "BayesianOptimisation"
    /// <summary>
    ///   <para>skos:definition : Capability of a system in analysing people's behaviour</para>
    ///   <para>skos:prefLabel : Behaviour Analysis</para>
    ///   <para>rdfs:comment : Capability of a system in analysing people's behaviour</para>
    ///   <para>rdfs:label : Behaviour Analysis</para>
    ///   <a href="https://w3id.org/vair#BehaviourAnalysis">vair:BehaviourAnalysis</a>
    /// </summary>
    let BehaviourAnalysis = _prefixId.prefix "BehaviourAnalysis"
    /// <summary>
    ///   <para>skos:definition : Systematic difference in treatment of certain objects, people or groups in comparison to others.</para>
    ///   <para>skos:prefLabel : Bias</para>
    ///   <para>rdfs:comment : Systematic difference in treatment of certain objects, people or groups in comparison to others.</para>
    ///   <para>rdfs:label : Bias</para>
    ///   <a href="https://w3id.org/vair#Bias">vair:Bias</a>
    /// </summary>
    let Bias = _prefixId.prefix "Bias"
    /// <summary>
    ///   <para>rdfs:label : Bias Detection</para>
    ///   <para>skos:definition : Control that is applied to detect bias in datasets, models, algorithms, etc.</para>
    ///   <para>rdfs:comment : Control that is applied to detect bias in datasets, models, algorithms, etc.</para>
    ///   <para>skos:prefLabel : Bias Detection</para>
    ///   <a href="https://w3id.org/vair#BiasDetection">vair:BiasDetection</a>
    /// </summary>
    let BiasDetection = _prefixId.prefix "BiasDetection"
    /// <summary>
    ///   <para>rdfs:label : Biased Test Data</para>
    ///   <para>skos:prefLabel : Biased Test Data</para>
    ///   <para>rdfs:comment : Bias in test data</para>
    ///   <para>skos:definition : Bias in test data</para>
    ///   <a href="https://w3id.org/vair#BiasedTestData">vair:BiasedTestData</a>
    /// </summary>
    let BiasedTestData = _prefixId.prefix "BiasedTestData"
    /// <summary>
    ///   <para>skos:definition : Bias in training data</para>
    ///   <para>skos:prefLabel : Biased Training Data</para>
    ///   <para>rdfs:label : Biased Training Data</para>
    ///   <para>rdfs:comment : Bias in training data</para>
    ///   <a href="https://w3id.org/vair#BiasedTrainingData">vair:BiasedTrainingData</a>
    /// </summary>
    let BiasedTrainingData = _prefixId.prefix "BiasedTrainingData"
    /// <summary>
    ///   <para>skos:prefLabel : Biased Validation Data</para>
    ///   <para>skos:definition : Bias in validation data</para>
    ///   <para>rdfs:label : Biased Validation Data</para>
    ///   <para>rdfs:comment : Bias in validation data</para>
    ///   <a href="https://w3id.org/vair#BiasedValidationData">vair:BiasedValidationData</a>
    /// </summary>
    let BiasedValidationData = _prefixId.prefix "BiasedValidationData"
    /// <summary>
    ///   <para>skos:prefLabel : Biometric Categorisation</para>
    ///   <para>rdfs:comment : The capability of the system is assigning natural persons to specific categories based on their biometric data^^xsd:string</para>
    ///   <para>skos:definition : The capability of the system is assigning natural persons to specific categories based on their biometric data</para>
    ///   <para>rdfs:label : Biometric Categorisation</para>
    ///   <a href="https://w3id.org/vair#BiometricCategorisation">vair:BiometricCategorisation</a>
    /// </summary>
    let BiometricCategorisation = _prefixId.prefix "BiometricCategorisation"
    /// <summary>
    ///   <para>rdfs:comment : Automated recognition of physical, physiological and behavioural human features such as the face, eye movement, body shape, voice, prosody, gait, posture, heart rate, blood pressure, odour, keystrokes characteristics, for the purpose of establishing an individual’s identity by comparing biometric data of that individual to stored biometric data of individuals in a reference database, irrespective of whether the individual has given its consent or not.</para>
    ///   <para>rdfs:label : Biometric Identification</para>
    ///   <para>skos:prefLabel : Biometric Identification</para>
    ///   <para>dcterms:source : The AI Act, Recital 15^^xsd:string</para>
    ///   <para>skos:definition : Automated recognition of physical, physiological and behavioural human features such as the face, eye movement, body shape, voice, prosody, gait, posture, heart rate, blood pressure, odour, keystrokes characteristics, for the purpose of establishing an individual’s identity by comparing biometric data of that individual to stored biometric data of individuals in a reference database, irrespective of whether the individual has given its consent or not</para>
    ///   <a href="https://w3id.org/vair#BiometricIdentification">vair:BiometricIdentification</a>
    /// </summary>
    let BiometricIdentification = _prefixId.prefix "BiometricIdentification"

    /// <summary>
    ///   <para>skos:prefLabel : Biometrics Based Emotion Recognition</para>
    ///   <para>rdfs:comment : Refers to recognisting emtions based on biometrics information</para>
    ///   <para>skos:definition : Refers to recognisting emtions based on biometrics information</para>
    ///   <para>rdfs:label : Biometrics Based Emotion Recognition</para>
    ///   <a href="https://w3id.org/vair#BiometricsBasedEmotionRecognition">vair:BiometricsBasedEmotionRecognition</a>
    /// </summary>
    let BiometricsBasedEmotionRecognition =
        _prefixId.prefix "BiometricsBasedEmotionRecognition"

    let BiometricsBasedEmotionSensing = _prefixId.prefix "BiometricsBasedEmotionSensing"
    let Blueprint = _prefixId.prefix "Blueprint"
    /// <summary>
    ///   <para>skos:definition : Activities related to border control management.</para>
    ///   <para>rdfs:comment : Activities related to border control management.</para>
    ///   <para>rdfs:label : Border Control Management</para>
    ///   <para>skos:prefLabel : Border Control Management</para>
    ///   <a href="https://w3id.org/vair#BorderControlManagement">vair:BorderControlManagement</a>
    /// </summary>
    let BorderControlManagement = _prefixId.prefix "BorderControlManagement"
    let BorderControlSecurityCheck = _prefixId.prefix "BorderControlSecurityCheck"
    /// <summary>
    ///   <para>skos:definition : A mode of controllability that stakeholders cannot opt out of the system’s output.</para>
    ///   <para>rdfs:label : Cannot Opt Out Of Output</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders cannot opt out of the system’s output.</para>
    ///   <para>skos:prefLabel : Cannot Opt Out Of Output</para>
    ///   <a href="https://w3id.org/vair#CannotOptOutOfOutput">vair:CannotOptOutOfOutput</a>
    /// </summary>
    let CannotOptOutOfOutput = _prefixId.prefix "CannotOptOutOfOutput"
    let CaseBasedReasoning = _prefixId.prefix "CaseBasedReasoning"
    /// <summary>
    ///   <para>skos:prefLabel : Categorisation</para>
    ///   <para>rdfs:comment : Assigning natural persons to specific categories</para>
    ///   <para>rdfs:label : Categorisation</para>
    ///   <para>skos:definition : Assigning natural persons to specific categories</para>
    ///   <a href="https://w3id.org/vair#Categorisation">vair:Categorisation</a>
    /// </summary>
    let Categorisation = _prefixId.prefix "Categorisation"
    /// <summary>
    ///   <para>skos:definition : A mode of controllability that stakeholders can challenge the system’s output.</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders can challenge the system’s output.</para>
    ///   <para>skos:prefLabel : Challenge Output</para>
    ///   <para>rdfs:label : Challenge Output</para>
    ///   <a href="https://w3id.org/vair#ChallengeOutput">vair:ChallengeOutput</a>
    /// </summary>
    let ChallengeOutput = _prefixId.prefix "ChallengeOutput"
    /// <summary>
    ///   <para>skos:prefLabel : Classifying Emergency Call</para>
    ///   <para>skos:definition : Classifying emergency calls by natural persons</para>
    ///   <para>rdfs:comment : Classifying emergency calls by natural persons</para>
    ///   <para>rdfs:label : Classifying Emergency Call</para>
    ///   <a href="https://w3id.org/vair#ClassifyingEmergencyCall">vair:ClassifyingEmergencyCall</a>
    /// </summary>
    let ClassifyingEmergencyCall = _prefixId.prefix "ClassifyingEmergencyCall"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.8^^xsd:string</para>
    ///   <para>rdfs:label : Cognitive Computing</para>
    ///   <para>rdfs:comment : Category of AI systems that enables people and machines to interact more naturally.</para>
    ///   <para>skos:definition : Category of AI systems that enables people and machines to interact more naturally.</para>
    ///   <para>skos:prefLabel : Cognitive Computing</para>
    ///   <a href="https://w3id.org/vair#CognitiveComputing">vair:CognitiveComputing</a>
    /// </summary>
    let CognitiveComputing = _prefixId.prefix "CognitiveComputing"
    let CognitiveSystem = _prefixId.prefix "CognitiveSystem"
    let CommonSenseReasoning = _prefixId.prefix "CommonSenseReasoning"
    /// <summary>
    ///   <para>skos:definition : Capability of a functional unit to acquire, process and interpret data representing images or video.</para>
    ///   <para>rdfs:label : Computer Vision</para>
    ///   <para>skos:prefLabel : Computer Vision</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.7.1^^xsd:string</para>
    ///   <para>rdfs:comment : Capability of a functional unit to acquire, process and interpret data representing images or video.</para>
    ///   <a href="https://w3id.org/vair#ComputerVision">vair:ComputerVision</a>
    /// </summary>
    let ComputerVision = _prefixId.prefix "ComputerVision"
    /// <summary>
    ///   <para>skos:prefLabel : Concept</para>
    ///   <para>skos:definition : Represents a concept in VAIR.</para>
    ///   <para>rdfs:label : Concept</para>
    ///   <para>rdfs:comment : Represents a concept in VAIR</para>
    ///   <a href="https://w3id.org/vair#Concept">vair:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:comment : The level of automation where there is sustained and specific performance by a system, with an external agent being ready to take over when necessary.</para>
    ///   <para>skos:prefLabel : Conditional Automation</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <para>skos:definition : The level of automation where there is sustained and specific performance by a system, with an external agent being ready to take over when necessary.</para>
    ///   <para>rdfs:label : Conditional Automation</para>
    ///   <a href="https://w3id.org/vair#ConditionalAutomation">vair:ConditionalAutomation</a>
    /// </summary>
    let ConditionalAutomation = _prefixId.prefix "ConditionalAutomation"
    let ConformityAssessmentBody = _prefixId.prefix "ConformityAssessmentBody"
    /// <summary>
    ///   <para>rdfs:label : Content</para>
    ///   <para>skos:definition : Content generated using an AI system.</para>
    ///   <para>rdfs:comment : Content generated using an AI system.</para>
    ///   <para>skos:prefLabel : Content</para>
    ///   <a href="https://w3id.org/vair#Content">vair:Content</a>
    /// </summary>
    let Content = _prefixId.prefix "Content"
    /// <summary>
    ///   <para>skos:definition : Generation or manipulation of audio content</para>
    ///   <para>skos:prefLabel : Content Generation</para>
    ///   <para>rdfs:comment : Generation or manipulation of audio content</para>
    ///   <para>rdfs:label : Content Generation</para>
    ///   <a href="https://w3id.org/vair#ContentGeneration">vair:ContentGeneration</a>
    /// </summary>
    let ContentGeneration = _prefixId.prefix "ContentGeneration"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.7^^xsd:string</para>
    ///   <para>rdfs:label : Continuous Validation</para>
    ///   <para>skos:prefLabel : Continuous Validation</para>
    ///   <para>skos:definition : Refers to validation phase of continuous learning AI systems, wherein incremental training takes place on an ongoing basis while the system is running in production.</para>
    ///   <para>rdfs:comment : Refers to validation phase of continuous learning AI systems, wherein incremental training takes place on an ongoing basis while the system is running in production.</para>
    ///   <a href="https://w3id.org/vair#ContinuousValidation">vair:ContinuousValidation</a>
    /// </summary>
    let ContinuousValidation = _prefixId.prefix "ContinuousValidation"
    /// <summary>
    ///   <para>skos:definition : Feed forward neural network using convolution in at least one of its layers.</para>
    ///   <para>rdfs:comment : Feed forward neural network using convolution  in at least one of its layers.</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.4.2^^xsd:string</para>
    ///   <para>rdfs:label : Convolutional Neural Network</para>
    ///   <para>skos:prefLabel : Convolutional Neural Network</para>
    ///   <a href="https://w3id.org/vair#ConvolutionalNeuralNetwork">vair:ConvolutionalNeuralNetwork</a>
    /// </summary>
    let ConvolutionalNeuralNetwork = _prefixId.prefix "ConvolutionalNeuralNetwork"
    /// <summary>
    ///   <para>skos:definition : A mode of controllability that stakeholders can correct the system’s output.</para>
    ///   <para>skos:prefLabel : Correct Output</para>
    ///   <para>rdfs:label : Correct Output</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders can correct the system’s output.</para>
    ///   <a href="https://w3id.org/vair#CorrectOutput">vair:CorrectOutput</a>
    /// </summary>
    let CorrectOutput = _prefixId.prefix "CorrectOutput"
    let CourseApplicant = _prefixId.prefix "CourseApplicant"
    /// <summary>
    ///   <para>skos:definition : A natural person who attends a course.</para>
    ///   <para>rdfs:comment : A person who attends a course.</para>
    ///   <para>rdfs:label : Course Attendee</para>
    ///   <para>skos:prefLabel : Course Attendee</para>
    ///   <a href="https://w3id.org/vair#CourseAttendee">vair:CourseAttendee</a>
    /// </summary>
    let CourseAttendee = _prefixId.prefix "CourseAttendee"
    /// <summary>
    ///   <para>skos:prefLabel : Critical Infrastructure</para>
    ///   <para>skos:definition : Refers to the sector or activities that aim at provision and maintainance of critical services.</para>
    ///   <para>rdfs:comment : Refers to the sector or activities that aim at provision and maintainance of critical services.</para>
    ///   <para>rdfs:label : Critical Infrastructure</para>
    ///   <a href="https://w3id.org/vair#CriticalInfrastructure">vair:CriticalInfrastructure</a>
    /// </summary>
    let CriticalInfrastructure = _prefixId.prefix "CriticalInfrastructure"
    let Cyberattack = _prefixId.prefix "Cyberattack"
    let Data = _prefixId.prefix "Data"
    let DataCollection = _prefixId.prefix "DataCollection"
    /// <summary>
    ///   <para>rdfs:comment : Attack trying to manipulate the training dataset.</para>
    ///   <para>rdfs:label : Data Poisoning</para>
    ///   <para>skos:definition : Attack trying to manipulate the training dataset.</para>
    ///   <para>skos:prefLabel : Data Poisoning</para>
    ///   <a href="https://w3id.org/vair#DataPoisoning">vair:DataPoisoning</a>
    /// </summary>
    let DataPoisoning = _prefixId.prefix "DataPoisoning"
    let DataPrepration = _prefixId.prefix "DataPrepration"
    /// <summary>
    ///   <para>rdfs:comment : Risk sources related to data</para>
    ///   <para>skos:definition : Risk sources related to data</para>
    ///   <para>rdfs:label : Data Risk Source</para>
    ///   <para>skos:prefLabel : Data Risk Source</para>
    ///   <a href="https://w3id.org/vair#DataRiskSource">vair:DataRiskSource</a>
    /// </summary>
    let DataRiskSource = _prefixId.prefix "DataRiskSource"
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A form of dataset documentation</para>
    ///   <para>skos:prefLabel : Datasheet</para>
    ///   <para>rdfs:label : Datasheet</para>
    ///   <para>skos:definition : A form of dataset documentation</para>
    ///   <a href="https://w3id.org/vair#Datasheet">vair:Datasheet</a>
    /// </summary>
    let Datasheet = _prefixId.prefix "Datasheet"
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>rdfs:comment : Decision generated by an AI system</para>
    ///   <para>rdfs:label : Decision</para>
    ///   <para>skos:prefLabel : Decision</para>
    ///   <para>skos:definition : Decision generated by an AI system</para>
    ///   <a href="https://w3id.org/vair#Decision">vair:Decision</a>
    /// </summary>
    let Decision = _prefixId.prefix "Decision"
    /// <summary>
    ///   <para>skos:definition : Generation of decisions</para>
    ///   <para>rdfs:comment : Generation of decisions</para>
    ///   <para>skos:prefLabel : Decision Making</para>
    ///   <para>rdfs:label : Decision Making</para>
    ///   <a href="https://w3id.org/vair#DecisionMaking">vair:DecisionMaking</a>
    /// </summary>
    let DecisionMaking = _prefixId.prefix "DecisionMaking"
    let DecisionSupportSystem = _prefixId.prefix "DecisionSupportSystem"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989 3.3.2^^xsd:string</para>
    ///   <para>rdfs:label : Decision Tree</para>
    ///   <para>skos:definition : Model for which inference  is encoded as paths from the root to a leaf node in a tree structure.</para>
    ///   <para>skos:prefLabel : Decision Tree</para>
    ///   <para>rdfs:comment : Model for which inference  is encoded as paths from the root to a leaf node in a tree structure.</para>
    ///   <a href="https://w3id.org/vair#DecisionTree">vair:DecisionTree</a>
    /// </summary>
    let DecisionTree = _prefixId.prefix "DecisionTree"
    /// <summary>
    ///   <para>rdfs:comment : Decreased level of system's robustness resulted from materialisation of a risk.</para>
    ///   <para>skos:definition : Decreased level of system's robustness resulted from materialisation of a risk.</para>
    ///   <para>rdfs:label : Decreased Robustness</para>
    ///   <para>skos:prefLabel : Decreased Robustness</para>
    ///   <a href="https://w3id.org/vair#DecreasedRobustness">vair:DecreasedRobustness</a>
    /// </summary>
    let DecreasedRobustness = _prefixId.prefix "DecreasedRobustness"
    /// <summary>
    ///   <para>rdfs:label : Decreased Security</para>
    ///   <para>rdfs:comment : Decreased level of security of system resulted from materialisation of a risk.</para>
    ///   <para>skos:prefLabel : Decreased Security</para>
    ///   <para>skos:definition : Decreased level of security of system resulted from materialisation of a risk.</para>
    ///   <a href="https://w3id.org/vair#DecreasedSecurity">vair:DecreasedSecurity</a>
    /// </summary>
    let DecreasedSecurity = _prefixId.prefix "DecreasedSecurity"
    /// <summary>
    ///   <para>skos:prefLabel : Deep Fake Detection</para>
    ///   <para>rdfs:label : Deep Fake Detection</para>
    ///   <para>rdfs:comment : Dectection of content that is generated using deep fake</para>
    ///   <para>skos:definition : Dectection of content that is generated using deep fake</para>
    ///   <a href="https://w3id.org/vair#DeepFakeDetection">vair:DeepFakeDetection</a>
    /// </summary>
    let DeepFakeDetection = _prefixId.prefix "DeepFakeDetection"
    /// <summary>
    ///   <para>rdfs:label : Deep learning</para>
    ///   <para>skos:prefLabel : Deep Learning</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.4.4^^xsd:string</para>
    ///   <para>rdfs:comment : Approach to creating rich hierarchical representations through the training of neural networks with many hidden layers</para>
    ///   <para>skos:definition : Approach to creating rich hierarchical representations through the training of neural networks with many hidden layers</para>
    ///   <a href="https://w3id.org/vair#DeepLearning">vair:DeepLearning</a>
    /// </summary>
    let DeepLearning = _prefixId.prefix "DeepLearning"
    /// <summary>
    ///   <para>rdfs:label : Degraded Accuracy</para>
    ///   <para>skos:definition : Decreased level of system's accuracy resulted from materialisation of a risk.</para>
    ///   <para>rdfs:comment : Decreased level of system's accuracy resulted from materialisation of a risk.</para>
    ///   <para>skos:prefLabel : Degraded Accuracy</para>
    ///   <a href="https://w3id.org/vair#DegradedAccuracy">vair:DegradedAccuracy</a>
    /// </summary>
    let DegradedAccuracy = _prefixId.prefix "DegradedAccuracy"
    /// <summary>
    ///   <para>skos:prefLabel : Deployment</para>
    ///   <para>rdfs:comment : Refers to deployment phase oThe AI system is installed, released or configured for operation in a target environment.</para>
    ///   <para>rdfs:label : Deployment</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.5^^xsd:string</para>
    ///   <para>skos:definition : Refers to deployment phase when the AI system is installed, released or configured for operation in a target environment.</para>
    ///   <a href="https://w3id.org/vair#Deployment">vair:Deployment</a>
    /// </summary>
    let Deployment = _prefixId.prefix "Deployment"
    /// <summary>
    ///   <para>rdfs:label : Design</para>
    ///   <para>skos:definition : Refers to design phase of AI development</para>
    ///   <para>skos:prefLabel : Design</para>
    ///   <para>rdfs:comment : Refers to design phase of AI development</para>
    ///   <a href="https://w3id.org/vair#Design">vair:Design</a>
    /// </summary>
    let Design = _prefixId.prefix "Design"
    /// <summary>
    ///   <para>skos:prefLabel : Design Specification</para>
    ///   <para>rdfs:comment : Design specification of a system</para>
    ///   <para>rdfs:label : Design Specification</para>
    ///   <para>skos:definition : Design specification of a system</para>
    ///   <a href="https://w3id.org/vair#DesignSpecification">vair:DesignSpecification</a>
    /// </summary>
    let DesignSpecification = _prefixId.prefix "DesignSpecification"
    let Detecting = _prefixId.prefix "Detecting"
    /// <summary>
    ///   <para>rdfs:label : Detecting Criminal Offences</para>
    ///   <para>skos:definition : Detection of criminal offences</para>
    ///   <para>skos:prefLabel : Detecting Criminal Offences</para>
    ///   <para>rdfs:comment : Detection of criminal offences</para>
    ///   <a href="https://w3id.org/vair#DetectingCriminalOffences">vair:DetectingCriminalOffences</a>
    /// </summary>
    let DetectingCriminalOffences = _prefixId.prefix "DetectingCriminalOffences"
    /// <summary>
    ///   <para>skos:prefLabel : Detecting Emotional State</para>
    ///   <para>rdfs:comment : Detection of the emotional state of a natural person</para>
    ///   <para>rdfs:label : Detecting Emotional State</para>
    ///   <para>skos:definition : Detection of the emotional state of a natural person</para>
    ///   <a href="https://w3id.org/vair#DetectingEmotionalState">vair:DetectingEmotionalState</a>
    /// </summary>
    let DetectingEmotionalState = _prefixId.prefix "DetectingEmotionalState"
    /// <summary>
    ///   <para>skos:definition : Detecting natural persons </para>
    ///   <para>skos:prefLabel : Detecting Individuals</para>
    ///   <para>rdfs:label : Detecting Individuals</para>
    ///   <para>rdfs:comment : Detecting natural persons </para>
    ///   <a href="https://w3id.org/vair#DetectingIndividuals">vair:DetectingIndividuals</a>
    /// </summary>
    let DetectingIndividuals = _prefixId.prefix "DetectingIndividuals"
    /// <summary>
    ///   <para>skos:definition : Dectecting lies</para>
    ///   <para>rdfs:label : Detecting Lies</para>
    ///   <para>rdfs:comment : Dectecting lies</para>
    ///   <para>skos:prefLabel : Detecting Lies</para>
    ///   <a href="https://w3id.org/vair#DetectingLies">vair:DetectingLies</a>
    /// </summary>
    let DetectingLies = _prefixId.prefix "DetectingLies"

    /// <summary>
    ///   <para>skos:definition : Detection of  non-authentic documents</para>
    ///   <para>skos:prefLabel : Detecting Non Authentic Document</para>
    ///   <para>rdfs:comment : Detection of  non-authentic documents</para>
    ///   <para>rdfs:label : Detecting Non Authentic Document</para>
    ///   <a href="https://w3id.org/vair#DetectingNon-AuthenticDocument">vair:DetectingNon-AuthenticDocument</a>
    /// </summary>
    let DetectingNon_AuthenticDocument =
        _prefixId.prefix "DetectingNon-AuthenticDocument"

    /// <summary>
    ///   <para>skos:prefLabel : Detecting Prohibited Behaviour During Test</para>
    ///   <para>rdfs:label : Detecting Prohibited Behaviour During Test</para>
    ///   <para>skos:definition : Detecting prohibited behaviour during tests</para>
    ///   <para>rdfs:comment : Detecting prohibited behaviour during tests</para>
    ///   <a href="https://w3id.org/vair#DetectingProhibitedBehaviourDuringTest">vair:DetectingProhibitedBehaviourDuringTest</a>
    /// </summary>
    let DetectingProhibitedBehaviourDuringTest =
        _prefixId.prefix "DetectingProhibitedBehaviourDuringTest"

    /// <summary>
    ///   <para>rdfs:label : Detection</para>
    ///   <para>skos:prefLabel : Detection</para>
    ///   <para>rdfs:comment : Purposes related to detecting</para>
    ///   <para>skos:definition : Purposes related to detecting</para>
    ///   <a href="https://w3id.org/vair#Detection">vair:Detection</a>
    /// </summary>
    let Detection = _prefixId.prefix "Detection"
    /// <summary>
    ///   <para>skos:prefLabel : Detection Control</para>
    ///   <para>rdfs:comment : Control that is applied for detection purposes, e.g. detecting risks</para>
    ///   <para>skos:definition : Control that is applied for detection purposes, e.g. detecting risks</para>
    ///   <para>rdfs:label : Detection Control</para>
    ///   <a href="https://w3id.org/vair#DetectionControl">vair:DetectionControl</a>
    /// </summary>
    let DetectionControl = _prefixId.prefix "DetectionControl"

    /// <summary>
    ///   <para>skos:definition : Determining access to educational institutions all levels.</para>
    ///   <para>rdfs:comment : Determining access to educational institutions all levels.</para>
    ///   <para>rdfs:label : Determining Access To Educational Institutions</para>
    ///   <para>skos:prefLabel : Determining Access To Educational Institutions</para>
    ///   <a href="https://w3id.org/vair#DeterminingAccessToEducationalInstitutions">vair:DeterminingAccessToEducationalInstitutions</a>
    /// </summary>
    let DeterminingAccessToEducationalInstitutions =
        _prefixId.prefix "DeterminingAccessToEducationalInstitutions"

    /// <summary>
    ///   <para>skos:definition : Determining access to vocational training institutions all levels.</para>
    ///   <para>rdfs:comment : Determining access to vocational training institutions all levels.</para>
    ///   <para>rdfs:label : Determining Access To Vocational Training Institutions</para>
    ///   <para>skos:prefLabel : Determining Access To Vocational Training Institutions</para>
    ///   <a href="https://w3id.org/vair#DeterminingAccessToVocationalTrainingInstitutions">vair:DeterminingAccessToVocationalTrainingInstitutions</a>
    /// </summary>
    let DeterminingAccessToVocationalTrainingInstitutions =
        _prefixId.prefix "DeterminingAccessToVocationalTrainingInstitutions"

    /// <summary>
    ///   <para>rdfs:comment : Determining admission to educational institutions at all levels.</para>
    ///   <para>rdfs:label : Determining Admission To Educational Institutions</para>
    ///   <para>skos:prefLabel : Determining Admission To Educational Institutions</para>
    ///   <para>skos:definition : Determining admission to educational institutions at all levels.</para>
    ///   <a href="https://w3id.org/vair#DeterminingAdmissionToEducationalInstitutions">vair:DeterminingAdmissionToEducationalInstitutions</a>
    /// </summary>
    let DeterminingAdmissionToEducationalInstitutions =
        _prefixId.prefix "DeterminingAdmissionToEducationalInstitutions"

    /// <summary>
    ///   <para>skos:prefLabel : Determining Admission To Vocational Training Institutions</para>
    ///   <para>skos:definition : Determining admission to vocational training institutions at all levels.</para>
    ///   <para>rdfs:label : Determining Admission To Vocational Training Institutions</para>
    ///   <para>rdfs:comment : Determining admission to vocational training institutions at all levels.</para>
    ///   <a href="https://w3id.org/vair#DeterminingAdmissionToVocationalTrainingInstitutions">vair:DeterminingAdmissionToVocationalTrainingInstitutions</a>
    /// </summary>
    let DeterminingAdmissionToVocationalTrainingInstitutions =
        _prefixId.prefix "DeterminingAdmissionToVocationalTrainingInstitutions"

    /// <summary>
    ///   <para>rdfs:label : Determining Credit Score</para>
    ///   <para>rdfs:comment : Determining credit score of a person</para>
    ///   <para>skos:definition : Determining credit score of a person</para>
    ///   <para>skos:prefLabel : Determining Credit Score</para>
    ///   <a href="https://w3id.org/vair#DeterminingCreditScore">vair:DeterminingCreditScore</a>
    /// </summary>
    let DeterminingCreditScore = _prefixId.prefix "DeterminingCreditScore"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the development phase in AI lifecyle</para>
    ///   <para>skos:prefLabel : Development</para>
    ///   <para>rdfs:label : Development</para>
    ///   <para>skos:definition : Refers to the development phase in AI lifecyle</para>
    ///   <a href="https://w3id.org/vair#Development">vair:Development</a>
    /// </summary>
    let Development = _prefixId.prefix "Development"
    let DevelopmentData = _prefixId.prefix "DevelopmentData"
    /// <summary>
    ///   <para>rdfs:comment : Choosing the appropriate next move in a dialogue based on user input, the dialogue history and other contextual knowledge to meet a desired goal</para>
    ///   <para>rdfs:label : Dialogue Management</para>
    ///   <para>skos:prefLabel : Dialogue Management</para>
    ///   <para>skos:definition : Choosing the appropriate next move in a dialogue based on user input, the dialogue history and other contextual knowledge to meet a desired goal.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.2^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#DialogueManagement">vair:DialogueManagement</a>
    /// </summary>
    let DialogueManagement = _prefixId.prefix "DialogueManagement"
    /// <summary>
    ///   <para>rdfs:comment : Identifying unkown patterns of crime</para>
    ///   <para>skos:prefLabel : Discovering Crime Patterns</para>
    ///   <para>skos:definition : Identifying unkown patterns of crime</para>
    ///   <para>rdfs:label : Discovering Crime Patterns</para>
    ///   <a href="https://w3id.org/vair#DiscoveringCrimePatterns">vair:DiscoveringCrimePatterns</a>
    /// </summary>
    let DiscoveringCrimePatterns = _prefixId.prefix "DiscoveringCrimePatterns"
    /// <summary>
    ///   <para>rdfs:comment : Discovering hidden relationships related to crime</para>
    ///   <para>skos:prefLabel : Discovering Crime Relationships</para>
    ///   <para>skos:definition : Discovering hidden relationships related to crime</para>
    ///   <para>rdfs:label : Discovering Crime Relationships</para>
    ///   <a href="https://w3id.org/vair#DiscoveringCrimeRelationships">vair:DiscoveringCrimeRelationships</a>
    /// </summary>
    let DiscoveringCrimeRelationships = _prefixId.prefix "DiscoveringCrimeRelationships"
    let DispatchingEmergencyService = _prefixId.prefix "DispatchingEmergencyService"
    /// <summary>
    ///   <para>rdfs:comment : Represent distortion of human behaviour caused by AI</para>
    ///   <para>skos:prefLabel : Distortion In Human Behaviour</para>
    ///   <para>rdfs:label : Distortion In Human Behaviour</para>
    ///   <para>skos:definition : Represent distortion of human behaviour caused by AI</para>
    ///   <a href="https://w3id.org/vair#DistortionInHumanBehaviour">vair:DistortionInHumanBehaviour</a>
    /// </summary>
    let DistortionInHumanBehaviour = _prefixId.prefix "DistortionInHumanBehaviour"
    let Distributor = _prefixId.prefix "Distributor"
    /// <summary>
    ///   <para>rdfs:comment : Union agency</para>
    ///   <para>dcterms:source : ^^xsd:string</para>
    ///   <para>skos:prefLabel : EU Agency</para>
    ///   <para>skos:definition : Union agency</para>
    ///   <para>rdfs:label : EU Agency</para>
    ///   <a href="https://w3id.org/vair#EUAgency">vair:EUAgency</a>
    /// </summary>
    let EUAgency = _prefixId.prefix "EUAgency"
    /// <summary>
    ///   <para>skos:prefLabel : EU Body</para>
    ///   <para>skos:definition : Union body</para>
    ///   <para>rdfs:label : EU Body</para>
    ///   <para>rdfs:comment : Union body</para>
    ///   <a href="https://w3id.org/vair#EUBody">vair:EUBody</a>
    /// </summary>
    let EUBody = _prefixId.prefix "EUBody"
    /// <summary>
    ///   <para>rdfs:comment : Document providing the EU declaration of conformity, as required by the AI Act, Article 47.</para>
    ///   <para>skos:definition : Document providing the EU declaration of conformity, as required by the AI Act, Article 47.</para>
    ///   <para>rdfs:label : EU Declaration Of Conformity</para>
    ///   <para>skos:prefLabel : EU Declaration Of Conformity</para>
    ///   <a href="https://w3id.org/vair#EUDeclarationOfConformity">vair:EUDeclarationOfConformity</a>
    /// </summary>
    let EUDeclarationOfConformity = _prefixId.prefix "EUDeclarationOfConformity"
    /// <summary>
    ///   <para>skos:definition : Union institution</para>
    ///   <para>rdfs:label : EU Institution</para>
    ///   <para>rdfs:comment : Union institution</para>
    ///   <para>skos:prefLabel : EU Institution</para>
    ///   <a href="https://w3id.org/vair#EUInstitution">vair:EUInstitution</a>
    /// </summary>
    let EUInstitution = _prefixId.prefix "EUInstitution"
    /// <summary>
    ///   <para>rdfs:comment : EU office</para>
    ///   <para>skos:definition : EU office</para>
    ///   <para>skos:prefLabel : EU Office</para>
    ///   <para>rdfs:label : EU Office</para>
    ///   <a href="https://w3id.org/vair#EUOffice">vair:EUOffice</a>
    /// </summary>
    let EUOffice = _prefixId.prefix "EUOffice"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the sector that offers education or vocational training at any level or for any profession.</para>
    ///   <para>skos:prefLabel : Education</para>
    ///   <para>rdfs:label : Education</para>
    ///   <para>skos:definition : Indicates the sector that offers education or vocational training at any level or for any profession.</para>
    ///   <a href="https://w3id.org/vair#Education">vair:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    /// <summary>
    ///   <para>skos:prefLabel : Educational Institution</para>
    ///   <para>skos:definition : Educational institution at any level</para>
    ///   <para>rdfs:label : Educational Institution</para>
    ///   <para>rdfs:comment : Educational institution at any level</para>
    ///   <a href="https://w3id.org/vair#EducationalInstitution">vair:EducationalInstitution</a>
    /// </summary>
    let EducationalInstitution = _prefixId.prefix "EducationalInstitution"
    let EmergancyTriage = _prefixId.prefix "EmergancyTriage"
    /// <summary>
    ///   <para>skos:prefLabel : Emergency Healthcare Provider</para>
    ///   <para>rdfs:comment : Refer to emergency healthcare providers</para>
    ///   <para>rdfs:label : Emergency Healthcare Provider</para>
    ///   <para>skos:definition : Refer to emergency healthcare providers</para>
    ///   <a href="https://w3id.org/vair#EmergencyHealthCareProvider">vair:EmergencyHealthCareProvider</a>
    /// </summary>
    let EmergencyHealthCareProvider = _prefixId.prefix "EmergencyHealthCareProvider"
    /// <summary>
    ///   <para>rdfs:label : Emergency Service Provider</para>
    ///   <para>rdfs:comment : Provider of emergency first response services</para>
    ///   <para>skos:definition : Provider of emergency first response services</para>
    ///   <para>skos:prefLabel : Emergency Service Provider</para>
    ///   <a href="https://w3id.org/vair#EmergencyServiceProvider">vair:EmergencyServiceProvider</a>
    /// </summary>
    let EmergencyServiceProvider = _prefixId.prefix "EmergencyServiceProvider"
    /// <summary>
    ///   <para>rdfs:comment : Emergency triaging</para>
    ///   <para>rdfs:label : Emergency Triage</para>
    ///   <para>skos:prefLabel : Emergency Triage</para>
    ///   <para>skos:definition : Emergency triaging</para>
    ///   <a href="https://w3id.org/vair#EmergencyTriage">vair:EmergencyTriage</a>
    /// </summary>
    let EmergencyTriage = _prefixId.prefix "EmergencyTriage"
    /// <summary>
    ///   <para>rdfs:label : Emotion Recognition</para>
    ///   <para>skos:prefLabel : Emotion Recognition</para>
    ///   <para>rdfs:comment : Computationally identifying and categorizing emotions expressed in a piece of text, speech, video or image or combination thereof.^^xsd:string</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.3</para>
    ///   <para>skos:definition : Computationally identifying and categorizing emotions expressed in a piece of text, speech, video or image or combination thereof.</para>
    ///   <a href="https://w3id.org/vair#EmotionRecognition">vair:EmotionRecognition</a>
    /// </summary>
    let EmotionRecognition = _prefixId.prefix "EmotionRecognition"
    let EmotionSensing = _prefixId.prefix "EmotionSensing"
    /// <summary>
    ///   <para>rdfs:comment : A person in work-related contractual relationships</para>
    ///   <para>skos:prefLabel : Employee</para>
    ///   <para>rdfs:label : Employee</para>
    ///   <para>skos:definition : A person in work-related contractual relationships</para>
    ///   <a href="https://w3id.org/vair#Employee">vair:Employee</a>
    /// </summary>
    let Employee = _prefixId.prefix "Employee"
    /// <summary>
    ///   <para>rdfs:comment : Refers to employment, workers’ management and access to self-employment.</para>
    ///   <para>skos:definition : Refers to employment, workers’ management and access to self-employment.</para>
    ///   <para>rdfs:label : Employment</para>
    ///   <para>skos:prefLabel : Employment</para>
    ///   <a href="https://w3id.org/vair#Employment">vair:Employment</a>
    /// </summary>
    let Employment = _prefixId.prefix "Employment"
    /// <summary>
    ///   <para>skos:definition : Error in data used as input</para>
    ///   <para>rdfs:label : Erroneous Input Data</para>
    ///   <para>skos:prefLabel : Erroneous Input Data</para>
    ///   <para>rdfs:comment : Error in data used as input</para>
    ///   <a href="https://w3id.org/vair#ErroneousInputData">vair:ErroneousInputData</a>
    /// </summary>
    let ErroneousInputData = _prefixId.prefix "ErroneousInputData"
    /// <summary>
    ///   <para>rdfs:label : Erroneous Test Data</para>
    ///   <para>rdfs:comment : Error in test data</para>
    ///   <para>skos:prefLabel : Erroneous Test Data</para>
    ///   <para>skos:definition : Error in test data</para>
    ///   <a href="https://w3id.org/vair#ErroneousTestData">vair:ErroneousTestData</a>
    /// </summary>
    let ErroneousTestData = _prefixId.prefix "ErroneousTestData"
    /// <summary>
    ///   <para>rdfs:comment : Error in training data^^xsd:string</para>
    ///   <para>rdfs:label : Erroneous Training Data</para>
    ///   <para>skos:prefLabel : Erroneous Training Data</para>
    ///   <para>skos:definition : Error in training data</para>
    ///   <a href="https://w3id.org/vair#ErroneousTrainingData">vair:ErroneousTrainingData</a>
    /// </summary>
    let ErroneousTrainingData = _prefixId.prefix "ErroneousTrainingData"
    /// <summary>
    ///   <para>skos:prefLabel : Erroneous Validation Data</para>
    ///   <para>rdfs:label : Erroneous Validation Data</para>
    ///   <para>skos:definition : Error in validation data</para>
    ///   <para>rdfs:comment : Error in validation data</para>
    ///   <a href="https://w3id.org/vair#ErroneousValidationData">vair:ErroneousValidationData</a>
    /// </summary>
    let ErroneousValidationData = _prefixId.prefix "ErroneousValidationData"
    /// <summary>
    ///   <para>skos:prefLabel : Error In Data Collection</para>
    ///   <para>skos:definition : Refers to errors in data collection process</para>
    ///   <para>rdfs:comment : Refers to errors in data collection process</para>
    ///   <para>rdfs:label : Error In Data Collection</para>
    ///   <a href="https://w3id.org/vair#ErrorInDataCollection">vair:ErrorInDataCollection</a>
    /// </summary>
    let ErrorInDataCollection = _prefixId.prefix "ErrorInDataCollection"
    /// <summary>
    ///   <para>skos:definition : Refers to errors in data prepration process</para>
    ///   <para>rdfs:label : Error In Data Prepration</para>
    ///   <para>rdfs:comment : Refers to errors in data prepration process</para>
    ///   <para>skos:prefLabel : Error In Data Prepration</para>
    ///   <a href="https://w3id.org/vair#ErrorInDataPrepration">vair:ErrorInDataPrepration</a>
    /// </summary>
    let ErrorInDataPrepration = _prefixId.prefix "ErrorInDataPrepration"

    let EuropeanArtificialIntelligenceBoard =
        _prefixId.prefix "EuropeanArtificialIntelligenceBoard"

    let EuropeanDataProtectionSupervisor =
        _prefixId.prefix "EuropeanDataProtectionSupervisor"

    /// <summary>
    ///   <para>skos:prefLabel : Evaluating Eligibility For Public Assistance Services</para>
    ///   <para>skos:definition : Evaluating the eligibility of natural persons for essential public assistance benefits and services, including healthcare services,</para>
    ///   <para>rdfs:comment : Evaluating the eligibility of natural persons for essential public assistance benefits and services, including healthcare services,</para>
    ///   <para>rdfs:label : Evaluating Eligibility For Public Assistance Services</para>
    ///   <a href="https://w3id.org/vair#EvaluatingEligibilityForPublicAssistanceServices">vair:EvaluatingEligibilityForPublicAssistanceServices</a>
    /// </summary>
    let EvaluatingEligibilityForPublicAssistanceServices =
        _prefixId.prefix "EvaluatingEligibilityForPublicAssistanceServices"

    let EvaluatingEligibilityToAccessPublicAssistanceServices =
        _prefixId.prefix "EvaluatingEligibilityToAccessPublicAssistanceServices"

    /// <summary>
    ///   <para>skos:prefLabel : Evaluating Eligibility For Healthcare Services</para>
    ///   <para>rdfs:label : Evaluating Eligibility For Healthcare Services</para>
    ///   <para>rdfs:comment : Evaluating the eligibility of natural persons for healthcare services</para>
    ///   <para>skos:definition : Evaluating the eligibility of natural persons for healthcare services</para>
    ///   <a href="https://w3id.org/vair#EvaluatingEligibilityforHealthCareServices">vair:EvaluatingEligibilityforHealthCareServices</a>
    /// </summary>
    let EvaluatingEligibilityforHealthCareServices =
        _prefixId.prefix "EvaluatingEligibilityforHealthCareServices"

    /// <summary>
    ///   <para>skos:prefLabel : Evaluating Emergency Call</para>
    ///   <para>skos:definition : Evaluating emergency calls by natural persons</para>
    ///   <para>rdfs:label : Evaluating Emergency Call</para>
    ///   <para>rdfs:comment : Evaluating emergency calls by natural persons</para>
    ///   <a href="https://w3id.org/vair#EvaluatingEmergencyCall">vair:EvaluatingEmergencyCall</a>
    /// </summary>
    let EvaluatingEmergencyCall = _prefixId.prefix "EvaluatingEmergencyCall"
    let EvaluatingEmployee = _prefixId.prefix "EvaluatingEmployee"
    /// <summary>
    ///   <para>rdfs:label : Evaluating Employee Behaviour</para>
    ///   <para>skos:definition : Evaluating the behaviour of persons in work-related relationships.</para>
    ///   <para>rdfs:comment : Evaluating the behaviour of persons in work-related relationships.</para>
    ///   <para>skos:prefLabel : Evaluating Employee Behaviour</para>
    ///   <a href="https://w3id.org/vair#EvaluatingEmployeeBehaviour">vair:EvaluatingEmployeeBehaviour</a>
    /// </summary>
    let EvaluatingEmployeeBehaviour = _prefixId.prefix "EvaluatingEmployeeBehaviour"
    /// <summary>
    ///   <para>skos:definition : Evaluating the performance of persons in work-related relationships.</para>
    ///   <para>rdfs:label : Evaluating Employee Performance</para>
    ///   <para>skos:prefLabel : Evaluating Employee Performance</para>
    ///   <para>rdfs:comment : Evaluating the performance of persons in work-related relationships.</para>
    ///   <a href="https://w3id.org/vair#EvaluatingEmployeePerformance">vair:EvaluatingEmployeePerformance</a>
    /// </summary>
    let EvaluatingEmployeePerformance = _prefixId.prefix "EvaluatingEmployeePerformance"
    let EvaluatingInterview = _prefixId.prefix "EvaluatingInterview"
    /// <summary>
    ///   <para>rdfs:label : Evaluating Job Candidates</para>
    ///   <para>skos:prefLabel : Evaluating Job Candidates</para>
    ///   <para>skos:definition : Evaluation of job candidates</para>
    ///   <para>rdfs:comment : Evaluation of job candidates</para>
    ///   <a href="https://w3id.org/vair#EvaluatingJobCandidates">vair:EvaluatingJobCandidates</a>
    /// </summary>
    let EvaluatingJobCandidates = _prefixId.prefix "EvaluatingJobCandidates"
    /// <summary>
    ///   <para>rdfs:comment : Evaluation of job interviews</para>
    ///   <para>skos:definition : Evaluation of job interviews</para>
    ///   <para>rdfs:label : Evaluating Job Interview</para>
    ///   <para>skos:prefLabel : Evaluating Job Interview</para>
    ///   <a href="https://w3id.org/vair#EvaluatingJobInterview">vair:EvaluatingJobInterview</a>
    /// </summary>
    let EvaluatingJobInterview = _prefixId.prefix "EvaluatingJobInterview"
    /// <summary>
    ///   <para>skos:prefLabel : Evaluating Learning Outcomes</para>
    ///   <para>skos:definition : Evaluating learning outcomes, including when those outcomes are used to steer the learning process of natural persons in educational and vocational training institutions or programmes at all levels.</para>
    ///   <para>rdfs:comment : Evaluating learning outcomes, including when those outcomes are used to steer the learning process of natural persons in educational and vocational training institutions or programmes at all levels.</para>
    ///   <para>rdfs:label : Evaluating Learning Outcomes</para>
    ///   <a href="https://w3id.org/vair#EvaluatingLearningOutcomes">vair:EvaluatingLearningOutcomes</a>
    /// </summary>
    let EvaluatingLearningOutcomes = _prefixId.prefix "EvaluatingLearningOutcomes"
    let EvaluatingRecruitmentTest = _prefixId.prefix "EvaluatingRecruitmentTest"

    /// <summary>
    ///   <para>skos:prefLabel : Evaluating Reliability Of Evidence In Investigation Of Criminal Offences </para>
    ///   <para>skos:definition : Evaluation of the reliability of evidence in the course of investigation of criminal offences</para>
    ///   <para>rdfs:label : Evaluating Reliability Of Evidence In Investigation Of Criminal Offences </para>
    ///   <para>rdfs:comment : Evaluation of the reliability of evidence in the course of investigation of criminal offences</para>
    ///   <a href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences">vair:EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences</a>
    /// </summary>
    let EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences =
        _prefixId.prefix "EvaluatingReliabilityOfEvidenceInInvestigationOfCriminalOffences"

    /// <summary>
    ///   <para>skos:definition : Assessments of the reliability of evidence in the examination of applications for asylum, visa or residence permits and for associated complaints with regard to the eligibility of the natural persons applying for a status</para>
    ///   <para>skos:prefLabel : Evaluating Reliability Of Evidence In Migration Related Applications</para>
    ///   <para>rdfs:label : Evaluating Reliability Of Evidence In Migration Related Applications</para>
    ///   <para>rdfs:comment : Assessments of the reliability of evidence in the examination of applications for asylum, visa or residence permits and for associated complaints with regard to the eligibility of the natural persons applying for a status</para>
    ///   <a href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications">vair:EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications</a>
    /// </summary>
    let EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications =
        _prefixId.prefix "EvaluatingReliabilityOfEvidenceInMigrationRelatedApplications"

    /// <summary>
    ///   <para>skos:definition : Evaluation of the reliability of evidence in the course of prosecution of criminal offences</para>
    ///   <para>skos:prefLabel : Evaluating Reliability Of Evidence In Prosecution Of Criminal Offences </para>
    ///   <para>rdfs:comment : Evaluation of the reliability of evidence in the course of prosecution of criminal offences</para>
    ///   <para>rdfs:label : Evaluating Reliability Of Evidence In Prosecution Of Criminal Offences </para>
    ///   <a href="https://w3id.org/vair#EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences">vair:EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences</a>
    /// </summary>
    let EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences =
        _prefixId.prefix "EvaluatingReliabilityOfEvidenceInProsecutionOfCriminalOffences"

    let EvaluationData = _prefixId.prefix "EvaluationData"
    let EvolutionaryAlgorithm = _prefixId.prefix "EvolutionaryAlgorithm"
    /// <summary>
    ///   <para>skos:definition : Purposes related to examining an application</para>
    ///   <para>rdfs:comment : Purposes related to examining an application</para>
    ///   <para>skos:prefLabel : Examining Application</para>
    ///   <para>rdfs:label : Examining Application</para>
    ///   <a href="https://w3id.org/vair#ExaminingApplication">vair:ExaminingApplication</a>
    /// </summary>
    let ExaminingApplication = _prefixId.prefix "ExaminingApplication"
    /// <summary>
    ///   <para>rdfs:label : Examining Asylum Application</para>
    ///   <para>skos:prefLabel : Examining Asylum Application</para>
    ///   <para>rdfs:comment : Examining asylum application</para>
    ///   <para>skos:definition : Examining asylum application</para>
    ///   <a href="https://w3id.org/vair#ExaminingAsylumApplication">vair:ExaminingAsylumApplication</a>
    /// </summary>
    let ExaminingAsylumApplication = _prefixId.prefix "ExaminingAsylumApplication"

    /// <summary>
    ///   <para>rdfs:comment : Examining compliats related to migration</para>
    ///   <para>skos:definition : Examining compliats related to migration</para>
    ///   <para>rdfs:label : Examining Migration Related Complaints</para>
    ///   <para>skos:prefLabel : Examining Migration Related Complaints</para>
    ///   <a href="https://w3id.org/vair#ExaminingMigrationRelatedComplaints">vair:ExaminingMigrationRelatedComplaints</a>
    /// </summary>
    let ExaminingMigrationRelatedComplaints =
        _prefixId.prefix "ExaminingMigrationRelatedComplaints"

    /// <summary>
    ///   <para>skos:definition : Examining residence permit application</para>
    ///   <para>rdfs:label : Examining Residence Permits Application</para>
    ///   <para>skos:prefLabel : Examining Residence Permits Application</para>
    ///   <para>rdfs:comment : Examining residence permit application</para>
    ///   <a href="https://w3id.org/vair#ExaminingResidencePermitsApplication">vair:ExaminingResidencePermitsApplication</a>
    /// </summary>
    let ExaminingResidencePermitsApplication =
        _prefixId.prefix "ExaminingResidencePermitsApplication"

    /// <summary>
    ///   <para>rdfs:comment : Examining visa application</para>
    ///   <para>rdfs:label : Examining Visa Application</para>
    ///   <para>skos:prefLabel : Examining Visa Application</para>
    ///   <para>skos:definition : Examining visa application</para>
    ///   <a href="https://w3id.org/vair#ExaminingVisaApplication">vair:ExaminingVisaApplication</a>
    /// </summary>
    let ExaminingVisaApplication = _prefixId.prefix "ExaminingVisaApplication"
    /// <summary>
    ///   <para>skos:prefLabel : Expert System</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.13^^xsd:string</para>
    ///   <para>rdfs:label : Expert System</para>
    ///   <para>skos:definition : AI system that accumulates, combines and encapsulates knowledge provided by a human expert or experts in a specific domain to infer solutions to problems.</para>
    ///   <para>rdfs:comment : AI system that accumulates, combines and encapsulates knowledge provided by a human expert or experts in a specific domain to infer solutions to problems.</para>
    ///   <a href="https://w3id.org/vair#ExpertSystem">vair:ExpertSystem</a>
    /// </summary>
    let ExpertSystem = _prefixId.prefix "ExpertSystem"
    let ExplainingAlgorithm = _prefixId.prefix "ExplainingAlgorithm"
    /// <summary>
    ///   <para>skos:prefLabel : Face Recognition</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.7.2^^xsd:string</para>
    ///   <para>rdfs:label : Face Recognition</para>
    ///   <para>rdfs:comment : Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs.</para>
    ///   <para>skos:definition : Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs.</para>
    ///   <a href="https://w3id.org/vair#FaceRecognition">vair:FaceRecognition</a>
    /// </summary>
    let FaceRecognition = _prefixId.prefix "FaceRecognition"
    /// <summary>
    ///   <para>rdfs:comment : A group of people related to each other by blood or marraige</para>
    ///   <para>skos:prefLabel : Family</para>
    ///   <para>skos:definition : A group of people related to each other by blood or marraige</para>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="https://w3id.org/vair#Family">vair:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>skos:prefLabel : Feed Forward Neural Network</para>
    ///   <para>rdfs:comment : Neural network where information is fed from the input layer to the output layer in one direction only.</para>
    ///   <para>rdfs:label : Feed Forward Neural Network</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.4.6^^xsd:string</para>
    ///   <para>skos:definition : Neural network where information is fed from the input layer to the output layer in one direction only.</para>
    ///   <a href="https://w3id.org/vair#FeedForwardNeuralNetwork">vair:FeedForwardNeuralNetwork</a>
    /// </summary>
    let FeedForwardNeuralNetwork = _prefixId.prefix "FeedForwardNeuralNetwork"
    /// <summary>
    ///   <para>rdfs:comment : Refers to fire department</para>
    ///   <para>rdfs:label : Fire Brigade</para>
    ///   <para>skos:prefLabel : Fire Brigade</para>
    ///   <para>skos:definition : Refers to fire department</para>
    ///   <a href="https://w3id.org/vair#FireBrigade">vair:FireBrigade</a>
    /// </summary>
    let FireBrigade = _prefixId.prefix "FireBrigade"
    let Firefighter = _prefixId.prefix "Firefighter"
    /// <summary>
    ///   <para>skos:definition : Refers to freedoms given to individuals.</para>
    ///   <para>rdfs:comment : Refers to freedoms given to individuals</para>
    ///   <para>skos:prefLabel : Freedom</para>
    ///   <para>rdfs:label : Freedom</para>
    ///   <a href="https://w3id.org/vair#Freedom">vair:Freedom</a>
    /// </summary>
    let Freedom = _prefixId.prefix "Freedom"
    /// <summary>
    ///   <para>rdfs:label : Full Automation</para>
    ///   <para>skos:definition : The level of automation where is capable of performing its entire mission without external intervention.</para>
    ///   <para>skos:prefLabel : Full Automation</para>
    ///   <para>rdfs:comment : The level of automation where is capable of performing its entire mission without external intervention.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#FullAutomation">vair:FullAutomation</a>
    /// </summary>
    let FullAutomation = _prefixId.prefix "FullAutomation"
    /// <summary>
    ///   <para>skos:definition : Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.</para>
    ///   <para>rdfs:comment : Type of AI system that addresses a broad range of tasks with a satisfactory level of performance.</para>
    ///   <para>skos:prefLabel : General AI</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.14^^xsd:string</para>
    ///   <para>rdfs:label : General AI^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#GeneralAI">vair:GeneralAI</a>
    /// </summary>
    let GeneralAI = _prefixId.prefix "GeneralAI"
    /// <summary>
    ///   <para>skos:definition : Generation or manipulation of audio content</para>
    ///   <para>rdfs:comment : Generation or manipulation of audio content</para>
    ///   <para>rdfs:label : Generating Audio Content</para>
    ///   <para>skos:prefLabel : Generating Audio Content</para>
    ///   <a href="https://w3id.org/vair#GeneratingAudioContent">vair:GeneratingAudioContent</a>
    /// </summary>
    let GeneratingAudioContent = _prefixId.prefix "GeneratingAudioContent"
    /// <summary>
    ///   <para>rdfs:label : Generating Image Content</para>
    ///   <para>skos:definition : Generation or manipulation of image content</para>
    ///   <para>skos:prefLabel : Generating Image Content</para>
    ///   <para>rdfs:comment : Generation or manipulation of image content</para>
    ///   <a href="https://w3id.org/vair#GeneratingImageContent">vair:GeneratingImageContent</a>
    /// </summary>
    let GeneratingImageContent = _prefixId.prefix "GeneratingImageContent"
    /// <summary>
    ///   <para>skos:definition : Generation or manipulation of video content</para>
    ///   <para>skos:prefLabel : Generating Video Content</para>
    ///   <para>rdfs:comment : Generation or manipulation of video content</para>
    ///   <para>rdfs:label : Generating Video Content^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#GeneratingVideoContent">vair:GeneratingVideoContent</a>
    /// </summary>
    let GeneratingVideoContent = _prefixId.prefix "GeneratingVideoContent"
    /// <summary>
    ///   <para>skos:prefLabel : Genetic Algorithm</para>
    ///   <para>skos:definition : Algorithm which simulates natural selection by creating and evolving a population of individuals (solutions) for optimization problems. [ISO/IEC 22989, 3.1.15]</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.15</para>
    ///   <para>rdfs:label : Genetic Algorithm</para>
    ///   <para>rdfs:comment : Algorithm which simulates natural selection by creating and evolving a population of individuals (solutions) for optimization problems</para>
    ///   <a href="https://w3id.org/vair#GeneticAlgorithm">vair:GeneticAlgorithm</a>
    /// </summary>
    let GeneticAlgorithm = _prefixId.prefix "GeneticAlgorithm"
    /// <summary>
    ///   <para>skos:prefLabel : Gesture Recognition</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>skos:definition : The capability of AI system to recognise human gestures.</para>
    ///   <para>rdfs:label : Gesture Recognition</para>
    ///   <para>rdfs:comment : The capability of AI system to recognise human gestures.^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#GestureRecognition">vair:GestureRecognition</a>
    /// </summary>
    let GestureRecognition = _prefixId.prefix "GestureRecognition"
    /// <summary>
    ///   <para>rdfs:comment : Granting natural persons healthcare services</para>
    ///   <para>rdfs:label : Granting Health Care Services</para>
    ///   <para>skos:definition : Granting natural persons healthcare services</para>
    ///   <para>skos:prefLabel : Granting Health Care Services</para>
    ///   <a href="https://w3id.org/vair#GrantingHealthCareServices">vair:GrantingHealthCareServices</a>
    /// </summary>
    let GrantingHealthCareServices = _prefixId.prefix "GrantingHealthCareServices"

    let GrantingPublicAssistanceService =
        _prefixId.prefix "GrantingPublicAssistanceService"

    /// <summary>
    ///   <para>skos:prefLabel : Granting Public Assistance Services</para>
    ///   <para>rdfs:comment : Granting natural persons essential public assistance benefits and services</para>
    ///   <para>rdfs:label : Granting Public Assistance Services</para>
    ///   <para>skos:definition : Granting natural persons essential public assistance benefits and services</para>
    ///   <a href="https://w3id.org/vair#GrantingPublicAssistanceServices">vair:GrantingPublicAssistanceServices</a>
    /// </summary>
    let GrantingPublicAssistanceServices =
        _prefixId.prefix "GrantingPublicAssistanceServices"

    /// <summary>
    ///   <para>rdfs:comment : A group of persons such as citizens, marginsalised groups, etc.</para>
    ///   <para>skos:definition : A group of persons such as citizens, marginsalised groups, etc.</para>
    ///   <para>rdfs:label : Group</para>
    ///   <para>skos:prefLabel : Group</para>
    ///   <a href="https://w3id.org/vair#Group">vair:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>skos:prefLabel : Hardware</para>
    ///   <para>rdfs:comment : Physical equipment/components</para>
    ///   <para>rdfs:label : Hardware</para>
    ///   <para>skos:definition : Physical equipment/components</para>
    ///   <a href="https://w3id.org/vair#Hardware">vair:Hardware</a>
    /// </summary>
    let Hardware = _prefixId.prefix "Hardware"
    /// <summary>
    ///   <para>rdfs:comment : Refers to an individuals' health.</para>
    ///   <para>skos:definition : Refers to an individuals' health.</para>
    ///   <para>skos:prefLabel : Health</para>
    ///   <para>rdfs:label : Health</para>
    ///   <a href="https://w3id.org/vair#Health">vair:Health</a>
    /// </summary>
    let Health = _prefixId.prefix "Health"
    /// <summary>
    ///   <para>rdfs:comment : Pricing in relation to natural persons in the case of health insurance</para>
    ///   <para>skos:definition : Pricing in relation to natural persons in the case of health insurance</para>
    ///   <para>rdfs:label : Health Insurance Pricing</para>
    ///   <para>skos:prefLabel : Health Insurance Pricing</para>
    ///   <a href="https://w3id.org/vair#HealthInsurancePricing">vair:HealthInsurancePricing</a>
    /// </summary>
    let HealthInsurancePricing = _prefixId.prefix "HealthInsurancePricing"
    /// <summary>
    ///   <para>skos:definition : Risk assessment in relation to natural persons in the case of health insurance</para>
    ///   <para>rdfs:label : Health Insurance Risk Assessment</para>
    ///   <para>skos:prefLabel : Health Insurance Risk Assessment</para>
    ///   <para>rdfs:comment : Risk assessment in relation to natural persons in the case of health insurance</para>
    ///   <a href="https://w3id.org/vair#HealthInsuranceRiskAssessment">vair:HealthInsuranceRiskAssessment</a>
    /// </summary>
    let HealthInsuranceRiskAssessment = _prefixId.prefix "HealthInsuranceRiskAssessment"
    /// <summary>
    ///   <para>rdfs:label : High Automation</para>
    ///   <para>skos:prefLabel : High Automation</para>
    ///   <para>skos:definition : The level of automation where there the system performs parts of its mission without external intervention.</para>
    ///   <para>rdfs:comment : The level of automation where there the system performs parts of its mission without external intervention.^^xsd:string</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#HighAutomation">vair:HighAutomation</a>
    /// </summary>
    let HighAutomation = _prefixId.prefix "HighAutomation"
    let HumanBehaviour = _prefixId.prefix "HumanBehaviour"
    /// <summary>
    ///   <para>skos:definition : Overseening the system by natural persons to detect, prevent or minimise risk.</para>
    ///   <para>rdfs:comment : Overseening the system by natural persons to detect, prevent or minimise risk.</para>
    ///   <para>rdfs:label : Human Oversight Measure</para>
    ///   <para>skos:prefLabel : Human Oversight Measure</para>
    ///   <a href="https://w3id.org/vair#HumanOversightMeasure">vair:HumanOversightMeasure</a>
    /// </summary>
    let HumanOversightMeasure = _prefixId.prefix "HumanOversightMeasure"
    /// <summary>
    ///   <para>rdfs:label : IEC 31010:2019</para>
    ///   <para>skos:definition : Risk management — Risk assessment techniques</para>
    ///   <para>rdfs:comment : Risk management — Risk assessment techniques</para>
    ///   <para>skos:prefLabel : IEC 31010:2019</para>
    ///   <a href="https://w3id.org/vair#IEC31010-2019">vair:IEC31010-2019</a>
    /// </summary>
    let IEC31010_2019 = _prefixId.prefix "IEC31010-2019"
    /// <summary>
    ///   <para>rdfs:comment : Quality management systems — Guidance for documented information</para>
    ///   <para>skos:prefLabel : ISO 10013:2021</para>
    ///   <para>rdfs:label : ISO 10013:2021</para>
    ///   <para>skos:definition : Quality management systems — Guidance for documented information</para>
    ///   <a href="https://w3id.org/vair#ISO10013-2021">vair:ISO10013-2021</a>
    /// </summary>
    let ISO10013_2021 = _prefixId.prefix "ISO10013-2021"
    /// <summary>
    ///   <para>rdfs:label : ISO 31000:2018</para>
    ///   <para>skos:definition : Risk management — Guidelines</para>
    ///   <para>skos:prefLabel : ISO 31000:2018</para>
    ///   <para>rdfs:comment : Risk management — Guidelines</para>
    ///   <a href="https://w3id.org/vair#ISO31000-2018">vair:ISO31000-2018</a>
    /// </summary>
    let ISO31000_2018 = _prefixId.prefix "ISO31000-2018"
    /// <summary>
    ///   <para>rdfs:comment : ISO 31073:2022 Risk management — Vocabulary</para>
    ///   <para>skos:definition : ISO 31073:2022 Risk management — Vocabulary</para>
    ///   <para>skos:prefLabel : ISO 31073:2022</para>
    ///   <para>rdfs:label : ISO 31073:2022</para>
    ///   <a href="https://w3id.org/vair#ISO31073_2022">vair:ISO31073_2022</a>
    /// </summary>
    let ISO31073_2022 = _prefixId.prefix "ISO31073_2022"
    /// <summary>
    ///   <para>rdfs:label : ISO 9001:2015</para>
    ///   <para>skos:definition : Quality management systems — Requirements</para>
    ///   <para>skos:prefLabel : ISO 9001:2015</para>
    ///   <para>rdfs:comment : Quality management systems — Requirements</para>
    ///   <a href="https://w3id.org/vair#ISO9001-2015">vair:ISO9001-2015</a>
    /// </summary>
    let ISO9001_2015 = _prefixId.prefix "ISO9001-2015"
    let ISOGuide73_2009 = _prefixId.prefix "ISOGuide73-2009"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC 20546:2019</para>
    ///   <para>rdfs:label : ISO/IEC 20546:2019</para>
    ///   <para>rdfs:comment : Information technology — Big data — Overview and vocabulary</para>
    ///   <para>skos:definition : Information technology — Big data — Overview and vocabulary</para>
    ///   <a href="https://w3id.org/vair#ISOIEC20546-2019">vair:ISOIEC20546-2019</a>
    /// </summary>
    let ISOIEC20546_2019 = _prefixId.prefix "ISOIEC20546-2019"
    /// <summary>
    ///   <para>rdfs:label : ISO/IEC 20547-3:2020</para>
    ///   <para>skos:prefLabel : ISO/IEC 20547-3:2020</para>
    ///   <para>rdfs:comment : Information technology — Big data reference architecture — Part 3: Reference architecture</para>
    ///   <para>skos:definition : Information technology — Big data reference architecture — Part 3: Reference architecture</para>
    ///   <a href="https://w3id.org/vair#ISOIEC20547-3-2020">vair:ISOIEC20547-3-2020</a>
    /// </summary>
    let ISOIEC20547_3_2020 = _prefixId.prefix "ISOIEC20547-3-2020"
    /// <summary>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence — Artificial intelligence concepts and terminology</para>
    ///   <para>rdfs:label : ISO/IEC 22989:2022</para>
    ///   <para>skos:prefLabel : ISO/IEC 22989:2022</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Artificial intelligence concepts and terminology</para>
    ///   <a href="https://w3id.org/vair#ISOIEC22989-2022">vair:ISOIEC22989-2022</a>
    /// </summary>
    let ISOIEC22989_2022 = _prefixId.prefix "ISOIEC22989-2022"
    /// <summary>
    ///   <para>rdfs:label : ISO/IEC 23053:2022</para>
    ///   <para>rdfs:comment : Framework for Artificial Intelligence (AI) Systems Using Machine Learning (ML)</para>
    ///   <para>skos:definition : Framework for Artificial Intelligence (AI) Systems Using Machine Learning (ML)</para>
    ///   <para>skos:prefLabel : ISO/IEC 23053:2022</para>
    ///   <a href="https://w3id.org/vair#ISOIEC23053-2022">vair:ISOIEC23053-2022</a>
    /// </summary>
    let ISOIEC23053_2022 = _prefixId.prefix "ISOIEC23053-2022"
    /// <summary>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence — Guidance on risk management</para>
    ///   <para>rdfs:label : ISO/IEC 23894:2023</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Guidance on risk management</para>
    ///   <para>skos:prefLabel : ISO/IEC 23894:2023</para>
    ///   <a href="https://w3id.org/vair#ISOIEC23894-2023">vair:ISOIEC23894-2023</a>
    /// </summary>
    let ISOIEC23894_2023 = _prefixId.prefix "ISOIEC23894-2023"
    /// <summary>
    ///   <para>rdfs:label : ISO/IEC 23894:2023</para>
    ///   <para>skos:label : ISO/IEC 23894:2023</para>
    ///   <para>skos:definition : ISO/IEC 23894:2023 Information technology — Artificial intelligence — Guidance on risk management</para>
    ///   <para>rdfs:comment : ISO/IEC 23894:2023 Information technology — Artificial intelligence — Guidance on risk management</para>
    ///   <a href="https://w3id.org/vair#ISOIEC23894_2023">vair:ISOIEC23894_2023</a>
    /// </summary>
    let ISOIEC23894_2023 = _prefixId.prefix "ISOIEC23894_2023"
    /// <summary>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence — Process management framework for big data analytics</para>
    ///   <para>rdfs:label : ISO/IEC 24668:2022</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Process management framework for big data analytics</para>
    ///   <para>skos:prefLabel : ISO/IEC 24668:2022</para>
    ///   <a href="https://w3id.org/vair#ISOIEC24668-2022">vair:ISOIEC24668-2022</a>
    /// </summary>
    let ISOIEC24668_2022 = _prefixId.prefix "ISOIEC24668-2022"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC 38507:2022</para>
    ///   <para>rdfs:label : ISO/IEC 38507:2022</para>
    ///   <para>skos:definition : Information technology — Governance of IT — Governance implications of the use of artificial intelligence by organizations</para>
    ///   <para>rdfs:comment : Information technology — Governance of IT — Governance implications of the use of artificial intelligence by organizations</para>
    ///   <a href="https://w3id.org/vair#ISOIEC38507-2022">vair:ISOIEC38507-2022</a>
    /// </summary>
    let ISOIEC38507_2022 = _prefixId.prefix "ISOIEC38507-2022"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC 42001:2023</para>
    ///   <para>skos:definition : ISO/IEC 42001:2023 Information technology — Artificial intelligence — Management system</para>
    ///   <para>rdfs:comment : ISO/IEC 42001:2023 Information technology — Artificial intelligence — Management system</para>
    ///   <para>rdfs:label : ISO/IEC 42001:2023</para>
    ///   <a href="https://w3id.org/vair#ISOIEC42001_2023">vair:ISOIEC42001_2023</a>
    /// </summary>
    let ISOIEC42001_2023 = _prefixId.prefix "ISOIEC42001_2023"
    /// <summary>
    ///   <para>rdfs:label : ISO/IEC TR 20547-1:2020</para>
    ///   <para>rdfs:comment : Information technology — Big data reference architecture — Part 1: Framework and application process</para>
    ///   <para>skos:prefLabel : ISO/IEC TR 20547-1:2020</para>
    ///   <para>skos:definition : Information technology — Big data reference architecture — Part 1: Framework and application process</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR20547-1-2020">vair:ISOIECTR20547-1-2020</a>
    /// </summary>
    let ISOIECTR20547_1_2020 = _prefixId.prefix "ISOIECTR20547-1-2020"
    /// <summary>
    ///   <para>skos:definition : Information technology — Big data reference architecture — Part 2: Use cases and derived requirements</para>
    ///   <para>rdfs:comment : Information technology — Big data reference architecture — Part 2: Use cases and derived requirements</para>
    ///   <para>rdfs:label : ISO/IEC TR 20547-2:2018</para>
    ///   <para>skos:prefLabel : ISO/IEC TR 20547-2:2018</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR20547-2-2018">vair:ISOIECTR20547-2-2018</a>
    /// </summary>
    let ISOIECTR20547_2_2018 = _prefixId.prefix "ISOIECTR20547-2-2018"
    /// <summary>
    ///   <para>rdfs:comment : Information technology — Big data reference architecture — Part 5: Standards roadmap</para>
    ///   <para>rdfs:label : ISO/IEC TR 20547-5:2018</para>
    ///   <para>skos:prefLabel : ISO/IEC TR 20547-5:2018</para>
    ///   <para>skos:definition : Information technology — Big data reference architecture — Part 5: Standards roadmap</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR20547-5-2018">vair:ISOIECTR20547-5-2018</a>
    /// </summary>
    let ISOIECTR20547_5_2018 = _prefixId.prefix "ISOIECTR20547-5-2018"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC TR 24027:2021</para>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence (AI) — Bias in AI systems and AI aided decision making</para>
    ///   <para>rdfs:label : ISO/IEC TR 24027:2021</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence (AI) — Bias in AI systems and AI aided decision making</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24027-2021">vair:ISOIECTR24027-2021</a>
    /// </summary>
    let ISOIECTR24027_2021 = _prefixId.prefix "ISOIECTR24027-2021"
    /// <summary>
    ///   <para>rdfs:comment : v</para>
    ///   <para>skos:prefLabel : ISO/IEC TR 24028:2020</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Overview of trustworthiness in artificial intelligence</para>
    ///   <para>rdfs:label : ISO/IEC TR 24028:2020</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24028-2020">vair:ISOIECTR24028-2020</a>
    /// </summary>
    let ISOIECTR24028_2020 = _prefixId.prefix "ISOIECTR24028-2020"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC TR 24029-1:2021</para>
    ///   <para>rdfs:label : ISO/IEC TR 24029-1:2021^^xsd:string</para>
    ///   <para>skos:definition : Artificial Intelligence (AI) — Assessment of the robustness of neural networks — Part 1: Overview</para>
    ///   <para>rdfs:comment : Artificial Intelligence (AI) — Assessment of the robustness of neural networks — Part 1: Overview</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24029-1-2021">vair:ISOIECTR24029-1-2021</a>
    /// </summary>
    let ISOIECTR24029_1_2021 = _prefixId.prefix "ISOIECTR24029-1-2021"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC TR 24030:2021</para>
    ///   <para>rdfs:label : ISO/IEC TR 24030:2021</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence (AI) — Use cases</para>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence (AI) — Use cases</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24030-2021">vair:ISOIECTR24030-2021</a>
    /// </summary>
    let ISOIECTR24030_2021 = _prefixId.prefix "ISOIECTR24030-2021"
    /// <summary>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence — Overview of ethical and societal concerns</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Overview of ethical and societal concerns</para>
    ///   <para>rdfs:label : ISO/IEC TR 24368:2022</para>
    ///   <para>skos:prefLabel : ISO/IEC TR 24368:2022</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24368-2022">vair:ISOIECTR24368-2022</a>
    /// </summary>
    let ISOIECTR24368_2022 = _prefixId.prefix "ISOIECTR24368-2022"
    /// <summary>
    ///   <para>skos:prefLabel : ISO/IEC TR 24372:2021</para>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence (AI) — Overview of computational approaches for AI systems</para>
    ///   <para>rdfs:label : ISO/IEC TR 24372:2021</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence (AI) — Overview of computational approaches for AI systems</para>
    ///   <a href="https://w3id.org/vair#ISOIECTR24372-2021">vair:ISOIECTR24372-2021</a>
    /// </summary>
    let ISOIECTR24372_2021 = _prefixId.prefix "ISOIECTR24372-2021"
    /// <summary>
    ///   <para>rdfs:label : ISO/IEC TS 4213:2022^^xsd:string</para>
    ///   <para>skos:prefLabel : ISO/IEC TS 4213:2022</para>
    ///   <para>skos:definition : Information technology — Artificial intelligence — Assessment of machine learning classification performance</para>
    ///   <para>rdfs:comment : Information technology — Artificial intelligence — Assessment of machine learning classification performance</para>
    ///   <a href="https://w3id.org/vair#ISOIECTS4213-2022">vair:ISOIECTS4213-2022</a>
    /// </summary>
    let ISOIECTS4213_2022 = _prefixId.prefix "ISOIECTS4213-2022"
    /// <summary>
    ///   <para>skos:prefLabel : Identiftying Individuals</para>
    ///   <para>rdfs:label : Identiftying Individuals</para>
    ///   <para>rdfs:comment : Identifying natural persons</para>
    ///   <para>skos:definition : Identifying natural persons</para>
    ///   <a href="https://w3id.org/vair#IdentiftyingIndividuals">vair:IdentiftyingIndividuals</a>
    /// </summary>
    let IdentiftyingIndividuals = _prefixId.prefix "IdentiftyingIndividuals"
    /// <summary>
    ///   <para>rdfs:comment : Image classification process that classifies object(s), pattern(s) or concept(s) in an image.</para>
    ///   <para>skos:prefLabel : Image Recognition</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.7.4^^xsd:string</para>
    ///   <para>rdfs:label : Image Recognition</para>
    ///   <para>skos:definition : Image classification process that classifies object(s), pattern(s) or concept(s) in an image.</para>
    ///   <a href="https://w3id.org/vair#ImageRecognition">vair:ImageRecognition</a>
    /// </summary>
    let ImageRecognition = _prefixId.prefix "ImageRecognition"
    let Importer = _prefixId.prefix "Importer"
    /// <summary>
    ///   <para>rdfs:label : Inaccurate Decision^^xsd:string</para>
    ///   <para>skos:prefLabel : Inaccurate Decision</para>
    ///   <para>skos:definition : Inaccurate decision generated by the system.</para>
    ///   <para>rdfs:comment : Inaccurate decision generated by the system.</para>
    ///   <a href="https://w3id.org/vair#InaccurateDecision">vair:InaccurateDecision</a>
    /// </summary>
    let InaccurateDecision = _prefixId.prefix "InaccurateDecision"
    /// <summary>
    ///   <para>skos:prefLabel : Inaccurate Prediction</para>
    ///   <para>rdfs:comment : Inaccurate prediction generated by the system.</para>
    ///   <para>skos:definition : Inaccurate prediction generated by the system.</para>
    ///   <para>rdfs:label : Inaccurate Prediction</para>
    ///   <a href="https://w3id.org/vair#InaccuratePrediction">vair:InaccuratePrediction</a>
    /// </summary>
    let InaccuratePrediction = _prefixId.prefix "InaccuratePrediction"
    /// <summary>
    ///   <para>skos:definition : Inaccurate recommendation generated by the system.</para>
    ///   <para>skos:prefLabel : Inaccurate Recommendation</para>
    ///   <para>rdfs:comment : Inaccurate recommendation generated by the system.</para>
    ///   <para>rdfs:label : Inaccurate Recommendation</para>
    ///   <a href="https://w3id.org/vair#InaccurateRecommendation">vair:InaccurateRecommendation</a>
    /// </summary>
    let InaccurateRecommendation = _prefixId.prefix "InaccurateRecommendation"
    /// <summary>
    ///   <para>skos:prefLabel : Inception</para>
    ///   <para>rdfs:comment : Inception occurs when one or more stakeholders decides to turn an idea into a tangible system</para>
    ///   <para>rdfs:label : Inception</para>
    ///   <para>skos:definition : Inception occurs when one or more stakeholders decides to turn an idea into a tangible system</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.2^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#Inception">vair:Inception</a>
    /// </summary>
    let Inception = _prefixId.prefix "Inception"
    /// <summary>
    ///   <para>skos:definition : Incompleteness of testing data set</para>
    ///   <para>rdfs:label : Incomplete Test Data</para>
    ///   <para>rdfs:comment : Incompleteness of testing data set</para>
    ///   <para>skos:prefLabel : Incomplete Test Data</para>
    ///   <a href="https://w3id.org/vair#IncompleteTestData">vair:IncompleteTestData</a>
    /// </summary>
    let IncompleteTestData = _prefixId.prefix "IncompleteTestData"
    /// <summary>
    ///   <para>skos:prefLabel : Incomplete Training Data</para>
    ///   <para>skos:definition : Incompleteness of training data set</para>
    ///   <para>rdfs:comment : Incompleteness of training data set</para>
    ///   <para>rdfs:label : Incomplete Training Data</para>
    ///   <a href="https://w3id.org/vair#IncompleteTrainingData">vair:IncompleteTrainingData</a>
    /// </summary>
    let IncompleteTrainingData = _prefixId.prefix "IncompleteTrainingData"
    /// <summary>
    ///   <para>skos:prefLabel : Incomplete Validation Data</para>
    ///   <para>skos:definition : Incompleteness of validation data set</para>
    ///   <para>rdfs:comment : Incompleteness of validation data set</para>
    ///   <para>rdfs:label : Incomplete Validation Data</para>
    ///   <a href="https://w3id.org/vair#IncompleteValidationData">vair:IncompleteValidationData</a>
    /// </summary>
    let IncompleteValidationData = _prefixId.prefix "IncompleteValidationData"
    /// <summary>
    ///   <para>skos:definition : A person who has entered into the territory of a State</para>
    ///   <para>rdfs:comment : A person who has entered into the territory of a State</para>
    ///   <para>skos:prefLabel : Individual Entered State</para>
    ///   <para>rdfs:label : Individual Entered State</para>
    ///   <a href="https://w3id.org/vair#IndividualEnteredState">vair:IndividualEnteredState</a>
    /// </summary>
    let IndividualEnteredState = _prefixId.prefix "IndividualEnteredState"
    /// <summary>
    ///   <para>skos:prefLabel : Individual Intends To Enter State</para>
    ///   <para>rdfs:comment : A person who intends to enter into the territory of a State</para>
    ///   <para>rdfs:label : Individual Intends To Enter State</para>
    ///   <para>skos:definition : A person who intends to enter into the territory of a State</para>
    ///   <a href="https://w3id.org/vair#IndividualIntendsToEnterState">vair:IndividualIntendsToEnterState</a>
    /// </summary>
    let IndividualIntendsToEnterState = _prefixId.prefix "IndividualIntendsToEnterState"
    /// <summary>
    ///   <para>skos:prefLabel : Individual Risk Assessment</para>
    ///   <para>skos:definition : Assessing the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences</para>
    ///   <para>rdfs:comment : Assessing the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences</para>
    ///   <para>rdfs:label : Individual Risk Assessment</para>
    ///   <a href="https://w3id.org/vair#IndividualRiskAssessment">vair:IndividualRiskAssessment</a>
    /// </summary>
    let IndividualRiskAssessment = _prefixId.prefix "IndividualRiskAssessment"
    /// <summary>
    ///   <para>rdfs:comment : Tthe inference of an algorithm or program featuring recursive calls or repetition control structures</para>
    ///   <para>skos:prefLabel : Inductive Programming</para>
    ///   <para>rdfs:label : Inductive Programming</para>
    ///   <para>skos:definition : The inference of an algorithm or program featuring recursive calls or repetition control structures</para>
    ///   <a href="https://w3id.org/vair#InductiveProgramming">vair:InductiveProgramming</a>
    /// </summary>
    let InductiveProgramming = _prefixId.prefix "InductiveProgramming"
    /// <summary>
    ///   <para>rdfs:comment : A robot for use in industrial automation applications.</para>
    ///   <para>rdfs:label : Industrial Robot</para>
    ///   <para>skos:prefLabel : Industrial Robot</para>
    ///   <para>skos:definition : A robot for use in industrial automation applications.</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:stringdcterms:source : ISO/IEC 22989, 3.1.29^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#IndustrialRobot">vair:IndustrialRobot</a>
    /// </summary>
    let IndustrialRobot = _prefixId.prefix "IndustrialRobot"
    let Inference = _prefixId.prefix "Inference"
    /// <summary>
    ///   <para>skos:prefLabel : Influencing</para>
    ///   <para>rdfs:comment : Purpose of influencing</para>
    ///   <para>skos:definition : Purpose of influencing</para>
    ///   <para>rdfs:label : Influencing</para>
    ///   <a href="https://w3id.org/vair#Influencing">vair:Influencing</a>
    /// </summary>
    let Influencing = _prefixId.prefix "Influencing"
    /// <summary>
    ///   <para>rdfs:comment : Influencing the outcome of an election.</para>
    ///   <para>rdfs:label : Influencing Election Outcome</para>
    ///   <para>skos:definition : Influencing the outcome of an election.</para>
    ///   <para>skos:prefLabel : Influencing Election Outcome</para>
    ///   <a href="https://w3id.org/vair#InfluencingElectionOutcome">vair:InfluencingElectionOutcome</a>
    /// </summary>
    let InfluencingElectionOutcome = _prefixId.prefix "InfluencingElectionOutcome"
    /// <summary>
    ///   <para>skos:definition : Influencing the outcome of a referendum.</para>
    ///   <para>rdfs:label : Influencing Referendum Outcome</para>
    ///   <para>rdfs:comment : Influencing the outcome of a referendum.</para>
    ///   <para>skos:prefLabel : Influencing Referendum Outcome</para>
    ///   <a href="https://w3id.org/vair#InfluencingReferendumOutcome">vair:InfluencingReferendumOutcome</a>
    /// </summary>
    let InfluencingReferendumOutcome = _prefixId.prefix "InfluencingReferendumOutcome"
    /// <summary>
    ///   <para>rdfs:label : Influencing Voting Behaviour</para>
    ///   <para>rdfs:comment : Purpose of influencing voting behaviour of people</para>
    ///   <para>skos:prefLabel : Influencing Voting Behaviour</para>
    ///   <para>skos:definition : Purpose of influencing voting behaviour of people</para>
    ///   <a href="https://w3id.org/vair#InfluencingVotingBehaviour">vair:InfluencingVotingBehaviour</a>
    /// </summary>
    let InfluencingVotingBehaviour = _prefixId.prefix "InfluencingVotingBehaviour"
    /// <summary>
    ///   <para>skos:definition : Providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used.</para>
    ///   <para>rdfs:comment : Providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used.</para>
    ///   <para>skos:prefLabel : Information Provision</para>
    ///   <para>rdfs:label : Information Provision</para>
    ///   <a href="https://w3id.org/vair#InformationProvision">vair:InformationProvision</a>
    /// </summary>
    let InformationProvision = _prefixId.prefix "InformationProvision"
    /// <summary>
    ///   <para>rdfs:label : Information Retrieval</para>
    ///   <para>skos:definition : Retrieving relevant documents or parts of documents from a dataset, typically based on keyword or natural language queries.</para>
    ///   <para>skos:prefLabel : Information Retrieval</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.4^^xsd:string</para>
    ///   <para>rdfs:comment : Retrieving relevant documents or parts of documents from a dataset, typically based on keyword or natural language queries.</para>
    ///   <a href="https://w3id.org/vair#InformationRetrieval">vair:InformationRetrieval</a>
    /// </summary>
    let InformationRetrieval = _prefixId.prefix "InformationRetrieval"
    /// <summary>
    ///   <para>skos:prefLabel : Informed Involvement</para>
    ///   <para>rdfs:comment : Represents that a specific actor was informed that an AI system is in place.</para>
    ///   <para>skos:definition : Represents that a specific actor was informed that an AI system is in place.</para>
    ///   <para>rdfs:label : Informed Involvement</para>
    ///   <a href="https://w3id.org/vair#InformedInvolvement">vair:InformedInvolvement</a>
    /// </summary>
    let InformedInvolvement = _prefixId.prefix "InformedInvolvement"
    let InputData = _prefixId.prefix "InputData"
    /// <summary>
    ///   <para>skos:prefLabel : Input Data Risk Source</para>
    ///   <para>skos:definition : Risk sources related to input data</para>
    ///   <para>rdfs:label : Input Data Risk Source</para>
    ///   <para>rdfs:comment : Risk sources related to input data</para>
    ///   <a href="https://w3id.org/vair#InputDataRiskSource">vair:InputDataRiskSource</a>
    /// </summary>
    let InputDataRiskSource = _prefixId.prefix "InputDataRiskSource"
    /// <summary>
    ///   <para>skos:definition : Instruction for installing an application.</para>
    ///   <para>rdfs:label : Installation Instruction</para>
    ///   <para>skos:prefLabel : Installation Instruction</para>
    ///   <para>rdfs:comment : Instruction for installing an application.</para>
    ///   <a href="https://w3id.org/vair#InstallationInstruction">vair:InstallationInstruction</a>
    /// </summary>
    let InstallationInstruction = _prefixId.prefix "InstallationInstruction"
    /// <summary>
    ///   <para>rdfs:comment : The information provided by the provider to inform the deployer of, in particular, an AI system’s intended purpose and proper use.</para>
    ///   <para>skos:definition : The information provided by the provider to inform the deployer of, in particular, an AI system’s intended purpose and proper use.</para>
    ///   <para>rdfs:label : Instruction For Use</para>
    ///   <para>skos:prefLabel : Instruction For Use</para>
    ///   <para>dcterms:source : AI Act, Art. 3(15)^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#InstructionForUse">vair:InstructionForUse</a>
    /// </summary>
    let InstructionForUse = _prefixId.prefix "InstructionForUse"
    let InstructionOfUse = _prefixId.prefix "InstructionOfUse"

    /// <summary>
    ///   <para>skos:definition : Lack of appropriate human oversight measures</para>
    ///   <para>rdfs:label : Insufficient Human Oversight Measure</para>
    ///   <para>skos:prefLabel : Insufficient Human Oversight Measure</para>
    ///   <para>rdfs:comment : Lack of appropriate human oversight measures</para>
    ///   <a href="https://w3id.org/vair#InsufficientHumanOversightMeasure">vair:InsufficientHumanOversightMeasure</a>
    /// </summary>
    let InsufficientHumanOversightMeasure =
        _prefixId.prefix "InsufficientHumanOversightMeasure"

    /// <summary>
    ///   <para>rdfs:comment : Lack of appropriate instruction for use</para>
    ///   <para>skos:definition : Lack of appropriate instruction for use</para>
    ///   <para>skos:prefLabel : Insufficient Instruction</para>
    ///   <para>rdfs:label : Insufficient Instruction</para>
    ///   <a href="https://w3id.org/vair#InsufficientInstruction">vair:InsufficientInstruction</a>
    /// </summary>
    let InsufficientInstruction = _prefixId.prefix "InsufficientInstruction"
    /// <summary>
    ///   <para>rdfs:comment : An AI-based control system</para>
    ///   <para>skos:definition : An AI-based control system^^xsd:stringskos:definition : </para>
    ///   <para>skos:prefLabel : Intelligent Control System</para>
    ///   <para>rdfs:label : Intelligent Control System</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#IntelligentControlSystem">vair:IntelligentControlSystem</a>
    /// </summary>
    let IntelligentControlSystem = _prefixId.prefix "IntelligentControlSystem"
    /// <summary>
    ///   <para>rdfs:comment : Represents involvement of a specific actor is as intended.</para>
    ///   <para>skos:prefLabel : Intended Involvement</para>
    ///   <para>rdfs:label : Intended Involvement</para>
    ///   <para>skos:definition : Represents involvement of a specific actor is as intended.</para>
    ///   <a href="https://w3id.org/vair#IntendedInvolvement">vair:IntendedInvolvement</a>
    /// </summary>
    let IntendedInvolvement = _prefixId.prefix "IntendedInvolvement"
    /// <summary>
    ///   <para>skos:definition : Interpreting facts</para>
    ///   <para>rdfs:comment : Interpreting facts</para>
    ///   <para>skos:prefLabel : Interpreting Facts</para>
    ///   <para>rdfs:label : Interpreting Facts</para>
    ///   <a href="https://w3id.org/vair#InterpretingFacts">vair:InterpretingFacts</a>
    /// </summary>
    let InterpretingFacts = _prefixId.prefix "InterpretingFacts"
    /// <summary>
    ///   <para>rdfs:comment : Interpreting the law</para>
    ///   <para>skos:definition : Interpreting the law</para>
    ///   <para>skos:prefLabel : Interpreting Law</para>
    ///   <para>rdfs:label : Interpreting Law</para>
    ///   <a href="https://w3id.org/vair#InterpretingLaw">vair:InterpretingLaw</a>
    /// </summary>
    let InterpretingLaw = _prefixId.prefix "InterpretingLaw"
    /// <summary>
    ///   <para>rdfs:label : Interruption</para>
    ///   <para>skos:definition : Interrupting the system's operation</para>
    ///   <para>skos:prefLabel : Interruption</para>
    ///   <para>rdfs:comment : Interrupting the system's operation</para>
    ///   <a href="https://w3id.org/vair#Interruption">vair:Interruption</a>
    /// </summary>
    let Interruption = _prefixId.prefix "Interruption"
    /// <summary>
    ///   <para>skos:definition : Intervention of system's operation</para>
    ///   <para>rdfs:comment : Intervention of system's operation</para>
    ///   <para>skos:prefLabel : Intervention</para>
    ///   <para>rdfs:label : Intervention</para>
    ///   <a href="https://w3id.org/vair#Intervention">vair:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>rdfs:label : Investigating Criminal Offences</para>
    ///   <para>skos:prefLabel : Investigating Criminal Offences</para>
    ///   <para>skos:definition : Investigation of criminal offences</para>
    ///   <para>rdfs:comment : Investigation of criminal offences</para>
    ///   <a href="https://w3id.org/vair#InvestigatingCriminalOffences">vair:InvestigatingCriminalOffences</a>
    /// </summary>
    let InvestigatingCriminalOffences = _prefixId.prefix "InvestigatingCriminalOffences"
    /// <summary>
    ///   <para>skos:prefLabel : IoT System</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.20^^xsd:string</para>
    ///   <para>rdfs:comment : A system providing functionalities of IoT.</para>
    ///   <para>skos:definition : A system providing functionalities of IoT.</para>
    ///   <para>rdfs:label : IoT System</para>
    ///   <a href="https://w3id.org/vair#IoTSystem">vair:IoTSystem</a>
    /// </summary>
    let IoTSystem = _prefixId.prefix "IoTSystem"
    /// <summary>
    ///   <para>rdfs:label : Irrelevant Test Data</para>
    ///   <para>rdfs:comment : Use of irrelevant data for testing</para>
    ///   <para>skos:definition : Use of irrelevant data for testing</para>
    ///   <para>skos:prefLabel : Irrelevant Test Data</para>
    ///   <a href="https://w3id.org/vair#IrrelevantTestData">vair:IrrelevantTestData</a>
    /// </summary>
    let IrrelevantTestData = _prefixId.prefix "IrrelevantTestData"
    /// <summary>
    ///   <para>skos:definition : Use of irrelevant data for training</para>
    ///   <para>skos:prefLabel : Irrelevant Training Data</para>
    ///   <para>rdfs:label : Irrelevant Training Data</para>
    ///   <para>rdfs:comment : Use of irrelevant data for training</para>
    ///   <a href="https://w3id.org/vair#IrrelevantTrainingData">vair:IrrelevantTrainingData</a>
    /// </summary>
    let IrrelevantTrainingData = _prefixId.prefix "IrrelevantTrainingData"
    /// <summary>
    ///   <para>rdfs:comment : Use of irrelevant data for validation</para>
    ///   <para>skos:definition : Use of irrelevant data for validation</para>
    ///   <para>rdfs:label : Irrelevant Validation Data</para>
    ///   <para>skos:prefLabel : Irrelevant Validation Data</para>
    ///   <a href="https://w3id.org/vair#IrrelevantValidationData">vair:IrrelevantValidationData</a>
    /// </summary>
    let IrrelevantValidationData = _prefixId.prefix "IrrelevantValidationData"
    /// <summary>
    ///   <para>skos:prefLabel : Job Applicant</para>
    ///   <para>skos:definition : A person who has made an application for employment</para>
    ///   <para>rdfs:label : Job Applicant</para>
    ///   <para>rdfs:comment : A person who has made an application for employment</para>
    ///   <a href="https://w3id.org/vair#JobApplicant">vair:JobApplicant</a>
    /// </summary>
    let JobApplicant = _prefixId.prefix "JobApplicant"
    /// <summary>
    ///   <para>skos:prefLabel : Job Application Analysis</para>
    ///   <para>skos:definition : Analysis of job applications</para>
    ///   <para>rdfs:label : Job Application Analysis</para>
    ///   <para>rdfs:comment : Analysis of job applications</para>
    ///   <a href="https://w3id.org/vair#JobApplicationAnalysis">vair:JobApplicationAnalysis</a>
    /// </summary>
    let JobApplicationAnalysis = _prefixId.prefix "JobApplicationAnalysis"
    /// <summary>
    ///   <para>skos:definition : Filtering applications for recruitment or selection of natural persons</para>
    ///   <para>rdfs:label : Job Application Filtering</para>
    ///   <para>skos:prefLabel : Job Application Filtering</para>
    ///   <para>rdfs:comment : Filtering applications for recruitment or selection of natural persons</para>
    ///   <a href="https://w3id.org/vair#JobApplicationFiltering">vair:JobApplicationFiltering</a>
    /// </summary>
    let JobApplicationFiltering = _prefixId.prefix "JobApplicationFiltering"
    /// <summary>
    ///   <para>skos:definition : Screening job applications </para>
    ///   <para>rdfs:comment : Screening job applications</para>
    ///   <para>rdfs:label : Job Application Screening</para>
    ///   <para>skos:prefLabel : Job Application Screening</para>
    ///   <a href="https://w3id.org/vair#JobApplicationScreening">vair:JobApplicationScreening</a>
    /// </summary>
    let JobApplicationScreening = _prefixId.prefix "JobApplicationScreening"
    /// <summary>
    ///   <para>rdfs:label : Job Candidate</para>
    ///   <para>skos:definition : A person who is considered for employment.</para>
    ///   <para>skos:prefLabel : Job Candidate</para>
    ///   <para>rdfs:comment : A person who is considered for employment.</para>
    ///   <a href="https://w3id.org/vair#JobCandidate">vair:JobCandidate</a>
    /// </summary>
    let JobCandidate = _prefixId.prefix "JobCandidate"
    let JobCandidateSelection = _prefixId.prefix "JobCandidateSelection"
    /// <summary>
    ///   <para>rdfs:label : Judicial Authority</para>
    ///   <para>skos:prefLabel : Judicial Authority </para>
    ///   <para>skos:definition : An authority to administer justice</para>
    ///   <para>rdfs:comment : An authority to administer justice</para>
    ///   <a href="https://w3id.org/vair#JudicialAuthority">vair:JudicialAuthority</a>
    /// </summary>
    let JudicialAuthority = _prefixId.prefix "JudicialAuthority"
    /// <summary>
    ///   <para>skos:definition : An entity that acts on behalf on judicial authorities</para>
    ///   <para>skos:prefLabel : Judicial Authority Agent</para>
    ///   <para>rdfs:label : Judicial Authority Agent</para>
    ///   <para>rdfs:comment : An entity that acts on behalf on judicial authorities^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#JudicialAuthorityAgent">vair:JudicialAuthorityAgent</a>
    /// </summary>
    let JudicialAuthorityAgent = _prefixId.prefix "JudicialAuthorityAgent"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Based Technique</para>
    ///   <para>rdfs:comment : Techniques based on the use of knowledge bases</para>
    ///   <para>skos:prefLabel : Knowledge Based Technique</para>
    ///   <para>skos:definition : Techniques based on the use of knowledge basesskos:definition : </para>
    ///   <a href="https://w3id.org/vair#KnowledgeBasedTechnique">vair:KnowledgeBasedTechnique</a>
    /// </summary>
    let KnowledgeBasedTechnique = _prefixId.prefix "KnowledgeBasedTechnique"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Reasoning</para>
    ///   <para>skos:definition : Capturing knowledge and acquiring new knowledge</para>
    ///   <para>skos:prefLabel : Knowledge Reasoning</para>
    ///   <para>rdfs:comment : Capturing knowledge and acquiring new knowledge</para>
    ///   <a href="https://w3id.org/vair#KnowledgeReasoning">vair:KnowledgeReasoning</a>
    /// </summary>
    let KnowledgeReasoning = _prefixId.prefix "KnowledgeReasoning"
    /// <summary>
    ///   <para>skos:definition : Encoding knowledge in a formal language</para>
    ///   <para>rdfs:comment : Encoding knowledge in a formal language</para>
    ///   <para>rdfs:label : Knowledge Representation</para>
    ///   <para>skos:prefLabel : Knowledge Representation</para>
    ///   <a href="https://w3id.org/vair#KnowledgeRepresentation">vair:KnowledgeRepresentation</a>
    /// </summary>
    let KnowledgeRepresentation = _prefixId.prefix "KnowledgeRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Lack Of Transparency</para>
    ///   <para>rdfs:comment : Refers to lack transparency regarding AI, its development, deployement, or use</para>
    ///   <para>skos:definition : Refers to lack transparency regarding AI, its development, deployement, or use</para>
    ///   <para>skos:prefLabel : Lack Of Transparency</para>
    ///   <a href="https://w3id.org/vair#LackOfTransparency">vair:LackOfTransparency</a>
    /// </summary>
    let LackOfTransparency = _prefixId.prefix "LackOfTransparency"
    let Law = _prefixId.prefix "Law"
    /// <summary>
    ///   <para>skos:prefLabel : Law Enforcement</para>
    ///   <para>skos:definition : Activities related to enforcing the law.</para>
    ///   <para>rdfs:label : Law Enforcement</para>
    ///   <para>rdfs:comment : Activities related to enforcing the law.</para>
    ///   <a href="https://w3id.org/vair#LawEnforcement">vair:LawEnforcement</a>
    /// </summary>
    let LawEnforcement = _prefixId.prefix "LawEnforcement"
    /// <summary>
    ///   <para>rdfs:label : Law Enforcement Authority</para>
    ///   <para>rdfs:comment : Law enforcement authority means:
    /// (a) any public authority competent for the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security; or
    /// (b) any other body or entity entrusted by Member State law to exercise public authority and public powers for the purposes of the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security.</para>
    ///   <para>skos:prefLabel : Law Enforcement Authority</para>
    ///   <para>skos:definition : Law enforcement authority means:
    /// (a) any public authority competent for the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security; or
    /// (b) any other body or entity entrusted by Member State law to exercise public authority and public powers for the purposes of the prevention, investigation, detection or prosecution of criminal offences or the execution of criminal penalties, including the safeguarding against and the prevention of threats to public security.</para>
    ///   <para>dcterms:source : AI Act, Art. 3(45)^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#LawEnforcementAuthority">vair:LawEnforcementAuthority</a>
    /// </summary>
    let LawEnforcementAuthority = _prefixId.prefix "LawEnforcementAuthority"
    /// <summary>
    ///   <para>rdfs:comment : An entity that acts on behalf of law enforcement authorities.</para>
    ///   <para>skos:prefLabel : Law Enforcement Authority Agent</para>
    ///   <para>rdfs:label : Law Enforcement Authority Agent</para>
    ///   <para>skos:definition : An entity that acts on behalf of law enforcement authorities</para>
    ///   <a href="https://w3id.org/vair#LawEnforcementAuthorityAgent">vair:LawEnforcementAuthorityAgent</a>
    /// </summary>
    let LawEnforcementAuthorityAgent = _prefixId.prefix "LawEnforcementAuthorityAgent"
    let LawEnforcemnet = _prefixId.prefix "LawEnforcemnet"
    let LearningTechnique = _prefixId.prefix "LearningTechnique"
    /// <summary>
    ///   <para>rdfs:comment : A collection of pre-written code</para>
    ///   <para>skos:definition : A collection of pre-written code</para>
    ///   <para>rdfs:label : Library</para>
    ///   <para>skos:prefLabel : Library</para>
    ///   <a href="https://w3id.org/vair#Library">vair:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>rdfs:comment : Detecting lies</para>
    ///   <para>skos:prefLabel : Lie Detection</para>
    ///   <para>rdfs:label : Lie Detection</para>
    ///   <para>skos:definition : Detecting lies</para>
    ///   <a href="https://w3id.org/vair#LieDetection">vair:LieDetection</a>
    /// </summary>
    let LieDetection = _prefixId.prefix "LieDetection"
    /// <summary>
    ///   <para>skos:definition : Pricing in relation to natural persons in the case of life insurance</para>
    ///   <para>rdfs:comment : Pricing in relation to natural persons in the case of life insurance</para>
    ///   <para>rdfs:label : Life Insurance Pricing</para>
    ///   <para>skos:prefLabel : Life Insurance Pricing</para>
    ///   <a href="https://w3id.org/vair#LifeInsurancePricing">vair:LifeInsurancePricing</a>
    /// </summary>
    let LifeInsurancePricing = _prefixId.prefix "LifeInsurancePricing"
    /// <summary>
    ///   <para>rdfs:label : Life Insurance Risk Assessment</para>
    ///   <para>skos:definition : Risk assessment in relation to natural persons in the case of life insurance</para>
    ///   <para>skos:prefLabel : Life Insurance Risk Assessment</para>
    ///   <para>rdfs:comment : Risk assessment in relation to natural persons in the case of life insurance</para>
    ///   <a href="https://w3id.org/vair#LifeInsuranceRiskAssessment">vair:LifeInsuranceRiskAssessment</a>
    /// </summary>
    let LifeInsuranceRiskAssessment = _prefixId.prefix "LifeInsuranceRiskAssessment"
    /// <summary>
    ///   <para>skos:prefLabel : Logging Measure</para>
    ///   <para>rdfs:comment : Refers to logging measure in place </para>
    ///   <para>skos:definition : Refers to logging measure in place</para>
    ///   <para>rdfs:label : Logging Measure</para>
    ///   <a href="https://w3id.org/vair#LoggingMeasure">vair:LoggingMeasure</a>
    /// </summary>
    let LoggingMeasure = _prefixId.prefix "LoggingMeasure"
    /// <summary>
    ///   <para>skos:definition : Refers to logic based techniques.</para>
    ///   <para>rdfs:label : Logic Based Technique</para>
    ///   <para>rdfs:comment : Refers to logic based techniques.</para>
    ///   <para>skos:prefLabel : Logic Based Technique</para>
    ///   <a href="https://w3id.org/vair#LogicBasedTechnique">vair:LogicBasedTechnique</a>
    /// </summary>
    let LogicBasedTechnique = _prefixId.prefix "LogicBasedTechnique"
    /// <summary>
    ///   <para>skos:prefLabel : Long ShortTerm Memory</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.4.7^^xsd:string</para>
    ///   <para>rdfs:label : Long ShortTerm Memory</para>
    ///   <para>rdfs:comment : type of recurrent neural network that processes sequential data with a satisfactory performance for both long and short span dependencies.</para>
    ///   <para>skos:definition : type of recurrent neural network that processes sequential data with a satisfactory performance for both long and short span dependencies. </para>
    ///   <a href="https://w3id.org/vair#LongShortTermMemory">vair:LongShortTermMemory</a>
    /// </summary>
    let LongShortTermMemory = _prefixId.prefix "LongShortTermMemory"
    /// <summary>
    ///   <para>rdfs:label : Low Accuracy</para>
    ///   <para>skos:prefLabel : Low Accuracy</para>
    ///   <para>rdfs:comment : Inacurracy of the predictions, recommondations, or decisions produced by the system.</para>
    ///   <para>skos:definition : Inacurracy of the predictions, recommondations, or decisions produced by the system.</para>
    ///   <a href="https://w3id.org/vair#LowAccuracy">vair:LowAccuracy</a>
    /// </summary>
    let LowAccuracy = _prefixId.prefix "LowAccuracy"
    /// <summary>
    ///   <para>rdfs:label : Low Robustness</para>
    ///   <para>rdfs:comment : Lack of appropriate level of robustness</para>
    ///   <para>skos:prefLabel : Low Robustness</para>
    ///   <para>skos:definition : Lack of appropriate level of robustness</para>
    ///   <a href="https://w3id.org/vair#LowRobustness">vair:LowRobustness</a>
    /// </summary>
    let LowRobustness = _prefixId.prefix "LowRobustness"
    /// <summary>
    ///   <para>skos:definition : Lack of appropriate level of security.</para>
    ///   <para>rdfs:comment : Lack of appropriate level of security.</para>
    ///   <para>rdfs:label : Low Security</para>
    ///   <para>skos:prefLabel : Low Security</para>
    ///   <a href="https://w3id.org/vair#LowSecurity">vair:LowSecurity</a>
    /// </summary>
    let LowSecurity = _prefixId.prefix "LowSecurity"
    /// <summary>
    ///   <para>skos:definition : Process of optimizing model parameters through computational techniques, such that the model's behaviour reflects the data or experience.</para>
    ///   <para>skos:prefLabel : Machine Learning</para>
    ///   <para>rdfs:label : Machine Learning</para>
    ///   <para>rdfs:comment : Process of optimizing model parameters through computational techniques, such that the model's behaviour reflects the data or experience.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.5^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#MachineLearning">vair:MachineLearning</a>
    /// </summary>
    let MachineLearning = _prefixId.prefix "MachineLearning"
    /// <summary>
    ///   <para>skos:prefLabel : Machine Learning Algorithm</para>
    ///   <para>rdfs:comment : An algorithm to determine parameters of a machine learning model from data according to given criteria.</para>
    ///   <para>rdfs:label : Machine Learning Algorithm</para>
    ///   <para>skos:definition : An algorithm to determine parameters of a machine learning model from data according to given criteria.</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.3.6^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#MachineLearningAlgorithm">vair:MachineLearningAlgorithm</a>
    /// </summary>
    let MachineLearningAlgorithm = _prefixId.prefix "MachineLearningAlgorithm"
    let MachineLearningFramework = _prefixId.prefix "MachineLearningFramework"
    /// <summary>
    ///   <para>skos:prefLabel : Machine Learning Library</para>
    ///   <para>rdfs:label : Machine Learning Library</para>
    ///   <para>rdfs:comment : Refers to liberaries for machine learning</para>
    ///   <para>skos:definition : Refers to liberaries for machine learning</para>
    ///   <a href="https://w3id.org/vair#MachineLearningLibrary">vair:MachineLearningLibrary</a>
    /// </summary>
    let MachineLearningLibrary = _prefixId.prefix "MachineLearningLibrary"
    /// <summary>
    ///   <para>skos:prefLabel : Machine Learning Model</para>
    ///   <para>rdfs:comment : Mathematical construct that generates an inference or prediction  based on input data or information.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.7^^xsd:string</para>
    ///   <para>skos:definition : Mathematical construct that generates an inference or prediction  based on input data or information.</para>
    ///   <para>rdfs:label : Machine Learning Model</para>
    ///   <a href="https://w3id.org/vair#MachineLearningModel">vair:MachineLearningModel</a>
    /// </summary>
    let MachineLearningModel = _prefixId.prefix "MachineLearningModel"
    /// <summary>
    ///   <para>rdfs:comment : Resource on which a ML model runs.</para>
    ///   <para>rdfs:label : Machine Learning Platform</para>
    ///   <para>skos:prefLabel : Machine Learning Platform</para>
    ///   <para>skos:definition : Resource on which a ML model runs.</para>
    ///   <a href="https://w3id.org/vair#MachineLearningPlatform">vair:MachineLearningPlatform</a>
    /// </summary>
    let MachineLearningPlatform = _prefixId.prefix "MachineLearningPlatform"
    let MachineLearningTechnique = _prefixId.prefix "MachineLearningTechnique"
    /// <summary>
    ///   <para>skos:definition : Automated translation of text or speech from one natural language to another using a computer system.</para>
    ///   <para>rdfs:label : Machine Translation</para>
    ///   <para>rdfs:comment : Automated translation of text or speech from one natural language to another using a computer system.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.5^^xsd:string</para>
    ///   <para>skos:prefLabel : Machine Translation</para>
    ///   <a href="https://w3id.org/vair#MachineTranslation">vair:MachineTranslation</a>
    /// </summary>
    let MachineTranslation = _prefixId.prefix "MachineTranslation"

    /// <summary>
    ///   <para>skos:prefLabel : Making Contract Termination Decision</para>
    ///   <para>skos:definition : Making decisions on termination of work-related contractual relationship</para>
    ///   <para>rdfs:label : Making Contract Termination Decision</para>
    ///   <para>rdfs:comment : Making decisions on termination of work-related contractual relationshiprdfs:comment : Making Contract Termination Decision</para>
    ///   <a href="https://w3id.org/vair#MakingContractTerminationDecision">vair:MakingContractTerminationDecision</a>
    /// </summary>
    let MakingContractTerminationDecision =
        _prefixId.prefix "MakingContractTerminationDecision"

    /// <summary>
    ///   <para>rdfs:label : Making Decision On Terms Of Work-Related Relations</para>
    ///   <para>rdfs:comment : Making decisions affecting terms of work-related relationships</para>
    ///   <para>skos:prefLabel : Making Decision On Terms Of Work-Related Relations</para>
    ///   <para>skos:definition : Making decisions affecting terms of work-related relationships</para>
    ///   <a href="https://w3id.org/vair#MakingDecisionOnTermsOfWorkRelatedRelations">vair:MakingDecisionOnTermsOfWorkRelatedRelations</a>
    /// </summary>
    let MakingDecisionOnTermsOfWorkRelatedRelations =
        _prefixId.prefix "MakingDecisionOnTermsOfWorkRelatedRelations"

    let MakingPrediction = _prefixId.prefix "MakingPrediction"
    /// <summary>
    ///   <para>skos:definition : Making decisions on promotion</para>
    ///   <para>rdfs:comment : Making decisions on promotion</para>
    ///   <para>rdfs:label : Making Promotion Decision</para>
    ///   <para>skos:prefLabel : Making Promotion Decision</para>
    ///   <a href="https://w3id.org/vair#MakingPromotionDecision">vair:MakingPromotionDecision</a>
    /// </summary>
    let MakingPromotionDecision = _prefixId.prefix "MakingPromotionDecision"

    let ManagementAndOperationOfSafety =
        _prefixId.prefix "ManagementAndOperationOfSafety"

    let Managing = _prefixId.prefix "Managing"

    let ManagingCriticalDigitalInfrastructure =
        _prefixId.prefix "ManagingCriticalDigitalInfrastructure"

    let ManagingRoadTraffic = _prefixId.prefix "ManagingRoadTraffic"
    let ManagingSupplyOfElectricity = _prefixId.prefix "ManagingSupplyOfElectricity"
    let ManagingSupplyOfGas = _prefixId.prefix "ManagingSupplyOfGas"
    let ManagingSupplyOfHeating = _prefixId.prefix "ManagingSupplyOfHeating"
    let ManagingSupplyOfWater = _prefixId.prefix "ManagingSupplyOfWater"
    /// <summary>
    ///   <para>rdfs:comment : Controls implemented manually by human actors</para>
    ///   <para>skos:prefLabel : Manual Control</para>
    ///   <para>skos:definition : Controls implemented manually by human actors</para>
    ///   <para>rdfs:label : Manual Control</para>
    ///   <a href="https://w3id.org/vair#ManualControl">vair:ManualControl</a>
    /// </summary>
    let ManualControl = _prefixId.prefix "ManualControl"
    let MarketSurveillanceAuthority = _prefixId.prefix "MarketSurveillanceAuthority"
    let MedicalAid = _prefixId.prefix "MedicalAid"
    /// <summary>
    ///   <para>rdfs:comment : Entity that provides medical aid</para>
    ///   <para>skos:definition : Entity that provides medical aid</para>
    ///   <para>rdfs:label : Medical Aid Provider</para>
    ///   <para>skos:prefLabel : Medical Aid Provider</para>
    ///   <a href="https://w3id.org/vair#MedicalAidProvider">vair:MedicalAidProvider</a>
    /// </summary>
    let MedicalAidProvider = _prefixId.prefix "MedicalAidProvider"
    /// <summary>
    ///   <para>skos:definition : Activities related to managing migration.</para>
    ///   <para>rdfs:comment : Activities related to managing migration.</para>
    ///   <para>rdfs:label : Migration Management</para>
    ///   <para>skos:prefLabel : Migration Management</para>
    ///   <a href="https://w3id.org/vair#MigrationManagement">vair:MigrationManagement</a>
    /// </summary>
    let MigrationManagement = _prefixId.prefix "MigrationManagement"
    /// <summary>
    ///   <para>rdfs:label : Mitigation Measure</para>
    ///   <para>skos:prefLabel : Mitigation Measure</para>
    ///   <para>skos:definition : Control that is applied for mitigation purposes, e.g. ,mitigating risk sources, impacts, etc.</para>
    ///   <para>rdfs:comment : Control that is applied for mitigation purposes, e.g. ,mitigating risk sources, impacts, etc.</para>
    ///   <a href="https://w3id.org/vair#MitigationMeasure">vair:MitigationMeasure</a>
    /// </summary>
    let MitigationMeasure = _prefixId.prefix "MitigationMeasure"
    /// <summary>
    ///   <para>rdfs:comment : physical, mathematical or otherwise logical representation of a system, entity, phenomenon, process or data. </para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.23^^xsd:string</para>
    ///   <para>skos:definition : physical, mathematical or otherwise logical representation of a system, entity, phenomenon, process or data. </para>
    ///   <para>rdfs:label : Model</para>
    ///   <para>skos:prefLabel : Model</para>
    ///   <a href="https://w3id.org/vair#Model">vair:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:comment : A form of model documentation</para>
    ///   <para>skos:prefLabel : Model Card</para>
    ///   <para>skos:definition : A form of model documentation</para>
    ///   <para>rdfs:label : Model Card</para>
    ///   <a href="https://w3id.org/vair#ModelCard">vair:ModelCard</a>
    /// </summary>
    let ModelCard = _prefixId.prefix "ModelCard"
    /// <summary>
    ///   <para>skos:definition : An input, which seems normal for a human but is wrongly classified by ML models.</para>
    ///   <para>rdfs:comment : An input, which seems normal for a human but is wrongly classified by ML models.</para>
    ///   <para>dcterms:source : ALTAI^^xsd:string</para>
    ///   <para>rdfs:label : Model Evasion</para>
    ///   <para>skos:prefLabel : Model Evasion</para>
    ///   <a href="https://w3id.org/vair#ModelEvasion">vair:ModelEvasion</a>
    /// </summary>
    let ModelEvasion = _prefixId.prefix "ModelEvasion"
    /// <summary>
    ///   <para>skos:definition : A type of attack to AI models, in which the access to a model is abused to infer information about the training data.</para>
    ///   <para>rdfs:label : Model Inversion</para>
    ///   <para>dcterms:source : ALTAI^^xsd:string</para>
    ///   <para>rdfs:comment : A type of attack to AI models, in which the access to a model is abused to infer information about the training data.</para>
    ///   <para>skos:prefLabel : Model Inversion</para>
    ///   <a href="https://w3id.org/vair#ModelInversion">vair:ModelInversion</a>
    /// </summary>
    let ModelInversion = _prefixId.prefix "ModelInversion"
    /// <summary>
    ///   <para>skos:prefLabel : Model Risk Source</para>
    ///   <para>skos:definition : Risk sources related to AI model</para>
    ///   <para>rdfs:comment : Risk sources related to the AI model</para>
    ///   <para>rdfs:label : Model Risk Source</para>
    ///   <a href="https://w3id.org/vair#ModelRiskSource">vair:ModelRiskSource</a>
    /// </summary>
    let ModelRiskSource = _prefixId.prefix "ModelRiskSource"
    let ModelTraning = _prefixId.prefix "ModelTraning"
    /// <summary>
    ///   <para>rdfs:label : Monitoring</para>
    ///   <para>skos:definition : Observing and keeping track of something</para>
    ///   <para>skos:prefLabel : Monitoring</para>
    ///   <para>rdfs:comment : Observing and keeping track of something</para>
    ///   <a href="https://w3id.org/vair#Monitoring">vair:Monitoring</a>
    /// </summary>
    let Monitoring = _prefixId.prefix "Monitoring"
    /// <summary>
    ///   <para>skos:definition : Monitoring the behaviour of persons in work-related relationships.</para>
    ///   <para>rdfs:label : Monitoring Employee Behaviour</para>
    ///   <para>rdfs:comment : Monitoring the behaviour of persons in work-related relationships.</para>
    ///   <para>skos:prefLabel : Monitoring Employee Behaviour</para>
    ///   <a href="https://w3id.org/vair#MonitoringEmployeeBehaviour">vair:MonitoringEmployeeBehaviour</a>
    /// </summary>
    let MonitoringEmployeeBehaviour = _prefixId.prefix "MonitoringEmployeeBehaviour"
    /// <summary>
    ///   <para>skos:definition : Monitoring the performance of persons in work-related relationships</para>
    ///   <para>rdfs:label : Monitoring Employee Performance</para>
    ///   <para>rdfs:comment : Monitoring the performance of persons in work-related relationships</para>
    ///   <para>skos:prefLabel : Monitoring Employee Performance</para>
    ///   <a href="https://w3id.org/vair#MonitoringEmployeePerformance">vair:MonitoringEmployeePerformance</a>
    /// </summary>
    let MonitoringEmployeePerformance = _prefixId.prefix "MonitoringEmployeePerformance"
    /// <summary>
    ///   <para>rdfs:label : Monitoring Measure</para>
    ///   <para>skos:prefLabel : Monitoring Measure</para>
    ///   <para>rdfs:comment : Refers to monitoring measures </para>
    ///   <para>skos:definition : Refers to monitoring measures</para>
    ///   <a href="https://w3id.org/vair#MonitoringMeasure">vair:MonitoringMeasure</a>
    /// </summary>
    let MonitoringMeasure = _prefixId.prefix "MonitoringMeasure"

    /// <summary>
    ///   <para>skos:definition : Monitoring prohibited behaviour during tests</para>
    ///   <para>rdfs:comment : Monitoring prohibited behaviour during tests</para>
    ///   <para>rdfs:label : Monitoring Prohibited Behaviour During Test</para>
    ///   <para>skos:prefLabel : Monitoring Prohibited Behaviour During Test</para>
    ///   <a href="https://w3id.org/vair#MonitoringProhibitedBehaviourDuringTest">vair:MonitoringProhibitedBehaviourDuringTest</a>
    /// </summary>
    let MonitoringProhibitedBehaviourDuringTest =
        _prefixId.prefix "MonitoringProhibitedBehaviourDuringTest"

    /// <summary>
    ///   <para>rdfs:comment : A system consisting of multiple AI agents.</para>
    ///   <para>skos:definition : A system consisting of multiple AI agents.</para>
    ///   <para>skos:prefLabel : Multi Agent System</para>
    ///   <para>rdfs:label : AI Watch, Defining Artificial Intelligence 2.0^^xsd:stringrdfs:label : Multi Agent System</para>
    ///   <a href="https://w3id.org/vair#MultiAgentSystem">vair:MultiAgentSystem</a>
    /// </summary>
    let MultiAgentSystem = _prefixId.prefix "MultiAgentSystem"
    /// <summary>
    ///   <para>skos:prefLabel : Music Information Retrieval</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>skos:definition : Retrieving information from music.</para>
    ///   <para>rdfs:comment : Retrieving information from music.</para>
    ///   <para>rdfs:label : Music Information Retrieval</para>
    ///   <a href="https://w3id.org/vair#MusicInformationRetrieval">vair:MusicInformationRetrieval</a>
    /// </summary>
    let MusicInformationRetrieval = _prefixId.prefix "MusicInformationRetrieval"
    /// <summary>
    ///   <para>skos:definition : Recognizing and labelling the denotational names of entities and their categories for sequences of words in a stream of text or speech.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.6^^xsd:string</para>
    ///   <para>rdfs:comment : Recognizing and labelling the denotational names of entities and their categories for sequences of words in a stream of text or speech.</para>
    ///   <para>skos:prefLabel : Named Entity Recognition</para>
    ///   <para>rdfs:label : Named Entity Recognition</para>
    ///   <a href="https://w3id.org/vair#NamedEntityRecognition">vair:NamedEntityRecognition</a>
    /// </summary>
    let NamedEntityRecognition = _prefixId.prefix "NamedEntityRecognition"
    /// <summary>
    ///   <para>rdfs:comment : Type of AI system that is focused on defined tasks to address a specific problem.</para>
    ///   <para>skos:prefLabel : Narrow AI</para>
    ///   <para>rdfs:label : Narrow AI</para>
    ///   <para>skos:definition : Type of AI system that is focused on defined tasks to address a specific problem.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.24^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#NarrowAI">vair:NarrowAI</a>
    /// </summary>
    let NarrowAI = _prefixId.prefix "NarrowAI"
    let NationalPublicAuthority = _prefixId.prefix "NationalPublicAuthority"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.8^^xsd:string</para>
    ///   <para>skos:prefLabel : Natural Language Generation</para>
    ///   <para>skos:definition : Converting data carrying semantics into natural language.</para>
    ///   <para>rdfs:comment : Converting data carrying semantics into natural language.</para>
    ///   <para>rdfs:label : Natural Language Generation</para>
    ///   <a href="https://w3id.org/vair#NaturalLanguageGeneration">vair:NaturalLanguageGeneration</a>
    /// </summary>
    let NaturalLanguageGeneration = _prefixId.prefix "NaturalLanguageGeneration"

    /// <summary>
    ///   <para>skos:prefLabel : Natural Language Processing System</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.9^^xsd:string</para>
    ///   <para>rdfs:label : Natural Language Processing System</para>
    ///   <para>rdfs:comment : Information processing based upon natural language understanding or natural language generation.</para>
    ///   <para>skos:definition : Information processing based upon natural language understanding or natural language generation.</para>
    ///   <a href="https://w3id.org/vair#NaturalLanguageProcessingSystem">vair:NaturalLanguageProcessingSystem</a>
    /// </summary>
    let NaturalLanguageProcessingSystem =
        _prefixId.prefix "NaturalLanguageProcessingSystem"

    /// <summary>
    ///   <para>skos:definition : An individual human being</para>
    ///   <para>rdfs:label : Natural Person</para>
    ///   <para>skos:prefLabel : Natural Person</para>
    ///   <para>rdfs:comment : An individual human being</para>
    ///   <a href="https://w3id.org/vair#NaturalPerson">vair:NaturalPerson</a>
    /// </summary>
    let NaturalPerson = _prefixId.prefix "NaturalPerson"
    /// <summary>
    ///   <para>skos:prefLabel : Neural Network</para>
    ///   <para>rdfs:comment : Network of one or more layers of neurons connected by weighted links with adjustable weights, which takes input data and produces an output.</para>
    ///   <para>rdfs:label : Neural Network</para>
    ///   <para>skos:definition : Network of one or more layers of neurons connected by weighted links with adjustable weights, which takes input data and produces an output.</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.4.8^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#NeuralNetwork">vair:NeuralNetwork</a>
    /// </summary>
    let NeuralNetwork = _prefixId.prefix "NeuralNetwork"
    /// <summary>
    ///   <para>rdfs:comment : The level of automation where an operator fully controls the system</para>
    ///   <para>rdfs:label : No Automation</para>
    ///   <para>skos:definition : The level of automation where an operator fully controls the system</para>
    ///   <para>skos:prefLabel : No Automation</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#NoAutomation">vair:NoAutomation</a>
    /// </summary>
    let NoAutomation = _prefixId.prefix "NoAutomation"
    let NotifiedBody = _prefixId.prefix "NotifiedBody"
    let NotifyingAuthority = _prefixId.prefix "NotifyingAuthority"
    /// <summary>
    ///   <para>rdfs:comment : The capability to recognise objects</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>rdfs:label : Object Recognition</para>
    ///   <para>skos:definition : The capability to recognise objects.</para>
    ///   <para>skos:prefLabel : Object Recognition</para>
    ///   <a href="https://w3id.org/vair#ObjectRecognition">vair:ObjectRecognition</a>
    /// </summary>
    let ObjectRecognition = _prefixId.prefix "ObjectRecognition"
    let Operating = _prefixId.prefix "Operating"

    let OperatingCriticalDigitalInfrastructure =
        _prefixId.prefix "OperatingCriticalDigitalInfrastructure"

    let OperatingRoadTraffic = _prefixId.prefix "OperatingRoadTraffic"
    let OperatingSupplyOfElectricity = _prefixId.prefix "OperatingSupplyOfElectricity"
    let OperatingSupplyOfGas = _prefixId.prefix "OperatingSupplyOfGas"
    let OperatingSupplyOfHeating = _prefixId.prefix "OperatingSupplyOfHeating"
    let OperatingSupplyOfWater = _prefixId.prefix "OperatingSupplyOfWater"
    /// <summary>
    ///   <para>skos:definition : Refers to the operation stage when an AI system is running and generally available for use.</para>
    ///   <para>rdfs:label : Operation</para>
    ///   <para>rdfs:comment : Refers to the operation stage when an AI system is running and generally available for use.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.6^^xsd:string</para>
    ///   <para>skos:prefLabel : Operation</para>
    ///   <a href="https://w3id.org/vair#Operation">vair:Operation</a>
    /// </summary>
    let Operation = _prefixId.prefix "Operation"
    /// <summary>
    ///   <para>skos:definition : Control related to operation of the system.</para>
    ///   <para>rdfs:comment : Control related to operation of the system.</para>
    ///   <para>rdfs:label : Operational Measure</para>
    ///   <para>skos:prefLabel : Operational Measure</para>
    ///   <a href="https://w3id.org/vair#OperationalMeasure">vair:OperationalMeasure</a>
    /// </summary>
    let OperationalMeasure = _prefixId.prefix "OperationalMeasure"
    /// <summary>
    ///   <para>rdfs:label : Optimisation Method</para>
    ///   <para>skos:definition : Refers to optimisation Method</para>
    ///   <para>skos:prefLabel : Optimisation Method</para>
    ///   <para>rdfs:comment : Refers to optimisation Method</para>
    ///   <a href="https://w3id.org/vair#OptimisationMethod">vair:OptimisationMethod</a>
    /// </summary>
    let OptimisationMethod = _prefixId.prefix "OptimisationMethod"
    /// <summary>
    ///   <para>skos:prefLabel : Optting In Output</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders can opt in  the system’s output.</para>
    ///   <para>skos:definition : A mode of controllability that stakeholders can opt in  the system’s output.</para>
    ///   <para>rdfs:label : Optting In Output</para>
    ///   <a href="https://w3id.org/vair#OpttingInOutput">vair:OpttingInOutput</a>
    /// </summary>
    let OpttingInOutput = _prefixId.prefix "OpttingInOutput"
    /// <summary>
    ///   <para>skos:prefLabel : Optting Out Of Output</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders can opt out of the system’s output.</para>
    ///   <para>rdfs:label : Optting Out Of Output</para>
    ///   <para>skos:definition : A mode of controllability that stakeholders can opt out of the system’s output.</para>
    ///   <a href="https://w3id.org/vair#OpttingOutOfOutput">vair:OpttingOutOfOutput</a>
    /// </summary>
    let OpttingOutOfOutput = _prefixId.prefix "OpttingOutOfOutput"
    /// <summary>
    ///   <para>rdfs:comment : Organisational measures applied to control risk sources, risks, consequences, or impacts.</para>
    ///   <para>skos:definition : Organisational measures applied to control risk sources, risks, consequences, or impacts.</para>
    ///   <para>rdfs:label : Organisational Measure</para>
    ///   <para>skos:prefLabel : Organisational Measure</para>
    ///   <a href="https://w3id.org/vair#OrganisationalMeasure">vair:OrganisationalMeasure</a>
    /// </summary>
    let OrganisationalMeasure = _prefixId.prefix "OrganisationalMeasure"
    /// <summary>
    ///   <para>rdfs:label : Organisational Risk Source</para>
    ///   <para>skos:prefLabel : Organisational Risk Source</para>
    ///   <para>rdfs:comment : Risk sources related with the organisation developing, deploying, or using AI.</para>
    ///   <para>skos:definition : Risk sources related with the organisation developing, deploying, or using AI.</para>
    ///   <a href="https://w3id.org/vair#OrganisationalRiskSource">vair:OrganisationalRiskSource</a>
    /// </summary>
    let OrganisationalRiskSource = _prefixId.prefix "OrganisationalRiskSource"
    let Outcome = _prefixId.prefix "Outcome"
    /// <summary>
    ///   <para>rdfs:comment : Tendency of automatically relying or over-relying on the output produced by an AI system</para>
    ///   <para>skos:prefLabel : Overreliance</para>
    ///   <para>rdfs:label : Overreliance</para>
    ///   <para>skos:definition : Tendency of automatically relying or over-relying on the output produced by an AI system</para>
    ///   <a href="https://w3id.org/vair#Overreliance">vair:Overreliance</a>
    /// </summary>
    let Overreliance = _prefixId.prefix "Overreliance"
    /// <summary>
    ///   <para>skos:definition : Overriding outcome of a system.</para>
    ///   <para>rdfs:label : Overriding Outcome</para>
    ///   <para>skos:prefLabel : Overriding Outcome</para>
    ///   <para>rdfs:comment : Overriding outcome of a system.</para>
    ///   <a href="https://w3id.org/vair#OverridingOutcome">vair:OverridingOutcome</a>
    /// </summary>
    let OverridingOutcome = _prefixId.prefix "OverridingOutcome"
    /// <summary>
    ///   <para>skos:definition : Assigning a category (e.g. verb, noun, adjective) to a word based on its grammatical properties.</para>
    ///   <para>rdfs:label : Part Of Speech Tagging</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.13^^xsd:string</para>
    ///   <para>rdfs:comment : Assigning a category (e.g. verb, noun, adjective) to a word based on its grammatical properties.</para>
    ///   <para>skos:prefLabel : Part Of Speech Tagging</para>
    ///   <a href="https://w3id.org/vair#PartOfSpeechTagging">vair:PartOfSpeechTagging</a>
    /// </summary>
    let PartOfSpeechTagging = _prefixId.prefix "PartOfSpeechTagging"
    /// <summary>
    ///   <para>rdfs:label : Partial Automation</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 5.13^^xsd:string</para>
    ///   <para>rdfs:comment : The level of automation where some sub-functions of the system are fully automated while the system remains under the control of an external agent</para>
    ///   <para>skos:prefLabel : Partial Automation</para>
    ///   <para>skos:definition : The level of automation where some sub-functions of the system are fully automated while the system remains under the control of an external agent</para>
    ///   <a href="https://w3id.org/vair#PartialAutomation">vair:PartialAutomation</a>
    /// </summary>
    let PartialAutomation = _prefixId.prefix "PartialAutomation"
    let Passenger = _prefixId.prefix "Passenger"
    /// <summary>
    ///   <para>skos:definition : Represents passive interactation with an AI system.</para>
    ///   <para>skos:prefLabel : Passive Involvement</para>
    ///   <para>rdfs:comment : Represents passive interactation with an AI system.</para>
    ///   <para>rdfs:label : Passive Involvement</para>
    ///   <a href="https://w3id.org/vair#PassiveInvolvement">vair:PassiveInvolvement</a>
    /// </summary>
    let PassiveInvolvement = _prefixId.prefix "PassiveInvolvement"
    let PatternRecognition = _prefixId.prefix "PatternRecognition"
    /// <summary>
    ///   <para>rdfs:comment : Risk sources related to performance</para>
    ///   <para>skos:prefLabel : Perfomance Risk Source</para>
    ///   <para>skos:definition : Risk sources related to performance</para>
    ///   <para>rdfs:label : Perfomance Risk Source</para>
    ///   <a href="https://w3id.org/vair#PerfomanceRiskSource">vair:PerfomanceRiskSource</a>
    /// </summary>
    let PerfomanceRiskSource = _prefixId.prefix "PerfomanceRiskSource"
    /// <summary>
    ///   <para>rdfs:label : Performing Background Check</para>
    ///   <para>skos:prefLabel : Performing Background Check</para>
    ///   <para>skos:definition : Performing background checks</para>
    ///   <para>rdfs:comment : Performing background checks</para>
    ///   <a href="https://w3id.org/vair#PerformingBackgroundCheck">vair:PerformingBackgroundCheck</a>
    /// </summary>
    let PerformingBackgroundCheck = _prefixId.prefix "PerformingBackgroundCheck"
    let Perpetrator = _prefixId.prefix "Perpetrator"
    let PersonalData = _prefixId.prefix "PersonalData"
    /// <summary>
    ///   <para>rdfs:label : Personality Traits Analysis</para>
    ///   <para>rdfs:comment : Capability of a system in determining and analysing people's personality traits</para>
    ///   <para>skos:prefLabel : Personality Traits Analysis</para>
    ///   <para>skos:definition : Capability of a system in determining and analysing people's personality traits</para>
    ///   <a href="https://w3id.org/vair#PersonalityTraitsAnalysis">vair:PersonalityTraitsAnalysis</a>
    /// </summary>
    let PersonalityTraitsAnalysis = _prefixId.prefix "PersonalityTraitsAnalysis"
    /// <summary>
    ///   <para>skos:definition : Refers to physical health.</para>
    ///   <para>rdfs:label : Physical Health</para>
    ///   <para>skos:prefLabel : Physical Health</para>
    ///   <para>rdfs:comment : Refers to physical health.</para>
    ///   <a href="https://w3id.org/vair#PhysicalHealth">vair:PhysicalHealth</a>
    /// </summary>
    let PhysicalHealth = _prefixId.prefix "PhysicalHealth"
    /// <summary>
    ///   <para>skos:prefLabel : Physical Injury</para>
    ///   <para>rdfs:label : Physical Injury</para>
    ///   <para>skos:definition : Represent physical injuries caused by AI</para>
    ///   <para>rdfs:comment : Represent physical injuries caused by AI</para>
    ///   <a href="https://w3id.org/vair#PhysicalInjury">vair:PhysicalInjury</a>
    /// </summary>
    let PhysicalInjury = _prefixId.prefix "PhysicalInjury"
    /// <summary>
    ///   <para>rdfs:label : Placing Targeted Job Advert</para>
    ///   <para>skos:definition : Placing targeted job advertisments</para>
    ///   <para>rdfs:comment : Placing targeted job advertisments</para>
    ///   <para>skos:prefLabel : Placing Targeted Job Advert</para>
    ///   <a href="https://w3id.org/vair#PlacingTargetedJobAdvert">vair:PlacingTargetedJobAdvert</a>
    /// </summary>
    let PlacingTargetedJobAdvert = _prefixId.prefix "PlacingTargetedJobAdvert"
    /// <summary>
    ///   <para>skos:prefLabel : Planning</para>
    ///   <para>rdfs:label : Planning</para>
    ///   <para>skos:definition : Planning purposes</para>
    ///   <para>rdfs:comment : Planning purposes</para>
    ///   <a href="https://w3id.org/vair#Planning">vair:Planning</a>
    /// </summary>
    let Planning = _prefixId.prefix "Planning"
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>skos:prefLabel : Police</para>
    ///   <para>rdfs:comment : Police</para>
    ///   <para>rdfs:label : Police</para>
    ///   <para>skos:definition : Police</para>
    ///   <a href="https://w3id.org/vair#Police">vair:Police</a>
    /// </summary>
    let Police = _prefixId.prefix "Police"
    /// <summary>
    ///   <para>skos:definition : Description of the post-market monitoring plan, as required by the AI Act.</para>
    ///   <para>rdfs:label : Post-market Monitoring Plan</para>
    ///   <para>rdfs:comment : Description of the post-market monitoring plan, as required by the AI Act.</para>
    ///   <para>skos:prefLabel : Post-market Monitoring Plan</para>
    ///   <a href="https://w3id.org/vair#PostMarketMonitoringPlan">vair:PostMarketMonitoringPlan</a>
    /// </summary>
    let PostMarketMonitoringPlan = _prefixId.prefix "PostMarketMonitoringPlan"

    /// <summary>
    ///   <para>skos:definition : Description of the post-market monitoring system in place, as required by the AI Act.</para>
    ///   <para>skos:prefLabel : Post-market Monitoring System Description</para>
    ///   <para>rdfs:label : Post-market Monitoring System Description</para>
    ///   <para>rdfs:comment : Description of the post-market monitoring system in place, as required by the AI Act.</para>
    ///   <a href="https://w3id.org/vair#PostMarketMonitoringSystemDescription">vair:PostMarketMonitoringSystemDescription</a>
    /// </summary>
    let PostMarketMonitoringSystemDescription =
        _prefixId.prefix "PostMarketMonitoringSystemDescription"

    /// <summary>
    ///   <para>rdfs:label : Potential Job Applicant</para>
    ///   <para>rdfs:comment : A person who may have applied for employment.</para>
    ///   <para>skos:definition : A person who may have applied for employment.</para>
    ///   <para>skos:prefLabel : Potential Job Applicant</para>
    ///   <a href="https://w3id.org/vair#PotentialJobApplicant">vair:PotentialJobApplicant</a>
    /// </summary>
    let PotentialJobApplicant = _prefixId.prefix "PotentialJobApplicant"

    /// <summary>
    ///   <para>skos:prefLabel : Potential Public Services Applicant</para>
    ///   <para>rdfs:label : Potential Public Services Applicant</para>
    ///   <para>skos:definition : A person who may have applied for public services.</para>
    ///   <para>rdfs:comment : A person who may have applied for public services.</para>
    ///   <a href="https://w3id.org/vair#PotentialPublicServicesApplicant">vair:PotentialPublicServicesApplicant</a>
    /// </summary>
    let PotentialPublicServicesApplicant =
        _prefixId.prefix "PotentialPublicServicesApplicant"

    let PreTrainedModel = _prefixId.prefix "PreTrainedModel"

    let PredictingOccurrenceOfCriminalOffence =
        _prefixId.prefix "PredictingOccurrenceOfCriminalOffence"

    let PredictingRecidivism = _prefixId.prefix "PredictingRecidivism"

    let PredictingReoccurrenceOfCriminalOffence =
        _prefixId.prefix "PredictingReoccurrenceOfCriminalOffence"

    /// <summary>
    ///   <para>rdfs:comment : Primary output of an AI system when provided with input data or information.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.27^^xsd:string</para>
    ///   <para>skos:definition : Primary output of an AI system when provided with input data or information.</para>
    ///   <para>skos:prefLabel : Prediction</para>
    ///   <para>rdfs:label : Prediction</para>
    ///   <a href="https://w3id.org/vair#Prediction">vair:Prediction</a>
    /// </summary>
    let Prediction = _prefixId.prefix "Prediction"
    let Principle = _prefixId.prefix "Principle"

    /// <summary>
    ///   <para>skos:definition : Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid</para>
    ///   <para>skos:prefLabel : Prioritisation Of Emergency Service</para>
    ///   <para>rdfs:label : Prioritisation Of Emergency Service</para>
    ///   <para>rdfs:comment : Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid</para>
    ///   <a href="https://w3id.org/vair#PrioritisationOfEmergencyService">vair:PrioritisationOfEmergencyService</a>
    /// </summary>
    let PrioritisationOfEmergencyService =
        _prefixId.prefix "PrioritisationOfEmergencyService"

    /// <summary>
    ///   <para>skos:prefLabel : Private Service</para>
    ///   <para>rdfs:label : Private Service</para>
    ///   <para>skos:definition : Business of supplying a service by a private body.</para>
    ///   <para>rdfs:comment : Business of supplying a service by a private body.</para>
    ///   <a href="https://w3id.org/vair#PrivateService">vair:PrivateService</a>
    /// </summary>
    let PrivateService = _prefixId.prefix "PrivateService"
    /// <summary>
    ///   <para>rdfs:comment : Producing meaningful recommendations to users of the system</para>
    ///   <para>skos:prefLabel : Producing Recommendation</para>
    ///   <para>skos:definition : Producing meaningful recommendations to users of the system</para>
    ///   <para>rdfs:label : Producing Recommendation</para>
    ///   <a href="https://w3id.org/vair#ProducingRecommendation">vair:ProducingRecommendation</a>
    /// </summary>
    let ProducingRecommendation = _prefixId.prefix "ProducingRecommendation"
    /// <summary>
    ///   <para>rdfs:comment : Refers to physical products.</para>
    ///   <para>rdfs:label : Product</para>
    ///   <para>skos:definition : Refers to physical products.</para>
    ///   <para>skos:prefLabel : Product</para>
    ///   <a href="https://w3id.org/vair#Product">vair:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    let ProductManufacturer = _prefixId.prefix "ProductManufacturer"
    let ProductionData = _prefixId.prefix "ProductionData"
    /// <summary>
    ///   <para>dcterms:source : GDPR, Art. 4(4)^^xsd:string</para>
    ///   <para>rdfs:label : Profiling</para>
    ///   <para>skos:prefLabel : Profiling</para>
    ///   <para>rdfs:comment : Any form of automated processing of personal data consisting of the use of personal data to evaluate certain personal aspects relating to a natural person, in particular to analyse or predict aspects concerning that natural person’s performance at work, economic situation, health, personal preferences, interests, reliability, behaviour, location or movements.</para>
    ///   <para>skos:definition : Any form of automated processing of personal data consisting of the use of personal data to evaluate certain personal aspects relating to a natural person, in particular to analyse or predict aspects concerning that natural person’s performance at work, economic situation, health, personal preferences, interests, reliability, behaviour, location or movements.</para>
    ///   <a href="https://w3id.org/vair#Profiling">vair:Profiling</a>
    /// </summary>
    let Profiling = _prefixId.prefix "Profiling"
    let ProfilingPeople = _prefixId.prefix "ProfilingPeople"
    /// <summary>
    ///   <para>skos:definition : Prosecution of criminal offences</para>
    ///   <para>rdfs:label : Prosecuting Criminal Offences</para>
    ///   <para>rdfs:comment : Prosecution of criminal offences</para>
    ///   <para>skos:prefLabel : Prosecuting Criminal Offences</para>
    ///   <a href="https://w3id.org/vair#ProsecutingCriminalOffences">vair:ProsecutingCriminalOffences</a>
    /// </summary>
    let ProsecutingCriminalOffences = _prefixId.prefix "ProsecutingCriminalOffences"
    let ProsecutionOfCriminalOffences = _prefixId.prefix "ProsecutionOfCriminalOffences"
    /// <summary>
    ///   <para>rdfs:label : Psychological Harm</para>
    ///   <para>skos:prefLabel : Psychological Harm</para>
    ///   <para>rdfs:comment : Represents negative impacts of AI on psychological health</para>
    ///   <para>skos:definition : Represents negative impacts of AI on psychological health</para>
    ///   <a href="https://w3id.org/vair#PsychologicalHarm">vair:PsychologicalHarm</a>
    /// </summary>
    let PsychologicalHarm = _prefixId.prefix "PsychologicalHarm"
    /// <summary>
    ///   <para>skos:prefLabel : Psychological Health</para>
    ///   <para>rdfs:comment : Refers to psychological health.</para>
    ///   <para>skos:definition : Refers to psychological health.</para>
    ///   <para>rdfs:label : Psychological Health</para>
    ///   <a href="https://w3id.org/vair#PsychologicalHealth">vair:PsychologicalHealth</a>
    /// </summary>
    let PsychologicalHealth = _prefixId.prefix "PsychologicalHealth"
    /// <summary>
    ///   <para>skos:definition : Refers to public authorities and bodies.</para>
    ///   <para>skos:prefLabel : Public Authority</para>
    ///   <para>rdfs:comment : Refers to public authorities and bodies.</para>
    ///   <para>rdfs:label : Public Authority</para>
    ///   <a href="https://w3id.org/vair#PublicAuthority">vair:PublicAuthority</a>
    /// </summary>
    let PublicAuthority = _prefixId.prefix "PublicAuthority"
    /// <summary>
    ///   <para>skos:prefLabel : Public Authority Agent</para>
    ///   <para>rdfs:comment : An entity that acts on behalf of public authorities.</para>
    ///   <para>skos:definition : An entity that acts on behalf of public authorities.</para>
    ///   <para>rdfs:label : Public Authority Agent</para>
    ///   <a href="https://w3id.org/vair#PublicAuthorityAgent">vair:PublicAuthorityAgent</a>
    /// </summary>
    let PublicAuthorityAgent = _prefixId.prefix "PublicAuthorityAgent"
    /// <summary>
    ///   <para>skos:prefLabel : Public Service</para>
    ///   <para>rdfs:comment : Business of supplying a commodity or a service by a govermental or public body.</para>
    ///   <para>rdfs:label : Public Service</para>
    ///   <para>skos:definition : Business of supplying a commodity or a service by a govermental or public body.</para>
    ///   <a href="https://w3id.org/vair#PublicService">vair:PublicService</a>
    /// </summary>
    let PublicService = _prefixId.prefix "PublicService"
    /// <summary>
    ///   <para>skos:prefLabel : Public Services Applicant</para>
    ///   <para>skos:definition : A person who has applied for public services and benefits</para>
    ///   <para>rdfs:label : Public Services Applicant</para>
    ///   <para>rdfs:comment : A person who has applied for public services and benefits</para>
    ///   <a href="https://w3id.org/vair#PublicServicesApplicant">vair:PublicServicesApplicant</a>
    /// </summary>
    let PublicServicesApplicant = _prefixId.prefix "PublicServicesApplicant"
    /// <summary>
    ///   <para>skos:prefLabel : Public Services Recipient</para>
    ///   <para>rdfs:comment : Person who is recipient of public services and benefits</para>
    ///   <para>rdfs:label : Public Services Recipient</para>
    ///   <para>skos:definition : Person who is recipient of public services and benefits</para>
    ///   <a href="https://w3id.org/vair#PublicServicesRecipient">vair:PublicServicesRecipient</a>
    /// </summary>
    let PublicServicesRecipient = _prefixId.prefix "PublicServicesRecipient"
    let PubliclyAccessibleSpace = _prefixId.prefix "PubliclyAccessibleSpace"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.14^^xsd:string</para>
    ///   <para>rdfs:label : Question Answering</para>
    ///   <para>skos:definition : Determining the most appropriate answer to a question provided in natural language.</para>
    ///   <para>skos:prefLabel : Question Answering</para>
    ///   <para>rdfs:comment : Determining the most appropriate answer to a question provided in natural language.</para>
    ///   <a href="https://w3id.org/vair#QuestionAnswering">vair:QuestionAnswering</a>
    /// </summary>
    let QuestionAnswering = _prefixId.prefix "QuestionAnswering"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.8^^xsd:string</para>
    ///   <para>skos:definition : After the operation and monitoring stage, based on the results of the work of the AI system, the need for a reassessment can arise.</para>
    ///   <para>skos:prefLabel : Re-Evaluation</para>
    ///   <para>rdfs:label : Re-Evaluation</para>
    ///   <para>rdfs:comment : After the operation and monitoring stage, based on the results of the work of the AI system, the need for a reassessment can arise.</para>
    ///   <a href="https://w3id.org/vair#ReEvaluation">vair:ReEvaluation</a>
    /// </summary>
    let ReEvaluation = _prefixId.prefix "ReEvaluation"
    /// <summary>
    ///   <para>skos:prefLabel : Reasoning Technique</para>
    ///   <para>rdfs:comment : Refers to reasoning techniques.</para>
    ///   <para>skos:definition : Refers to reasoning techniques.</para>
    ///   <para>rdfs:label : Reasoning Technique</para>
    ///   <a href="https://w3id.org/vair#ReasoningTechnique">vair:ReasoningTechnique</a>
    /// </summary>
    let ReasoningTechnique = _prefixId.prefix "ReasoningTechnique"
    /// <summary>
    ///   <para>skos:definition : Reclaiming natural persons healthcare services</para>
    ///   <para>skos:prefLabel : Reclaiming Health Care Services</para>
    ///   <para>rdfs:label : Reclaiming Health Care Services</para>
    ///   <para>rdfs:comment : Reclaiming natural persons healthcare services</para>
    ///   <a href="https://w3id.org/vair#ReclaimingHealthCareServices">vair:ReclaimingHealthCareServices</a>
    /// </summary>
    let ReclaimingHealthCareServices = _prefixId.prefix "ReclaimingHealthCareServices"

    /// <summary>
    ///   <para>rdfs:label : Reclaiming Public Assistance Services</para>
    ///   <para>rdfs:comment : Reclaiming essential public assistance benefits and services</para>
    ///   <para>skos:definition : Reclaiming essential public assistance benefits and services</para>
    ///   <para>skos:prefLabel : Reclaiming Public Assistance Services</para>
    ///   <a href="https://w3id.org/vair#ReclaimingPublicAssistanceServices">vair:ReclaimingPublicAssistanceServices</a>
    /// </summary>
    let ReclaimingPublicAssistanceServices =
        _prefixId.prefix "ReclaimingPublicAssistanceServices"

    /// <summary>
    ///   <para>rdfs:comment : Recognising emotions of a natural person</para>
    ///   <para>rdfs:label : Recognising Emotions</para>
    ///   <para>skos:definition : Recognising emotions of a natural person</para>
    ///   <para>skos:prefLabel : Recognising Emotions</para>
    ///   <a href="https://w3id.org/vair#RecognisingEmotions">vair:RecognisingEmotions</a>
    /// </summary>
    let RecognisingEmotions = _prefixId.prefix "RecognisingEmotions"
    /// <summary>
    ///   <para>rdfs:comment : Recognising natural persons </para>
    ///   <para>skos:prefLabel : Recognising Individuals</para>
    ///   <para>skos:definition : Recognising natural persons </para>
    ///   <para>rdfs:label : Recognising Individuals</para>
    ///   <a href="https://w3id.org/vair#RecognisingIndividuals">vair:RecognisingIndividuals</a>
    /// </summary>
    let RecognisingIndividuals = _prefixId.prefix "RecognisingIndividuals"
    /// <summary>
    ///   <para>skos:prefLabel : Recommendation</para>
    ///   <para>rdfs:comment : Recommendation generated by an AI system</para>
    ///   <para>rdfs:label : Recommendation</para>
    ///   <para>skos:definition : Recommendation generated by an AI system</para>
    ///   <a href="https://w3id.org/vair#Recommendation">vair:Recommendation</a>
    /// </summary>
    let Recommendation = _prefixId.prefix "Recommendation"
    let RecommenderSystem = _prefixId.prefix "RecommenderSystem"
    /// <summary>
    ///   <para>skos:definition : Recruiting people for a job</para>
    ///   <para>skos:prefLabel : Recruiting</para>
    ///   <para>rdfs:comment : Recruiting people for a job</para>
    ///   <para>rdfs:label : Recruiting</para>
    ///   <a href="https://w3id.org/vair#Recruiting">vair:Recruiting</a>
    /// </summary>
    let Recruiting = _prefixId.prefix "Recruiting"
    /// <summary>
    ///   <para>rdfs:label : Recurrent Neural Network</para>
    ///   <para>skos:definition : neural network in which outputs from both the previous layer and the previous processing step are fed into the current layer. </para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.4.10^^xsd:string</para>
    ///   <para>rdfs:comment : neural network in which outputs from both the previous layer and the previous processing step are fed into the current layer. </para>
    ///   <para>skos:prefLabel : Recurrent Neural Network</para>
    ///   <a href="https://w3id.org/vair#RecurrentNeuralNetwork">vair:RecurrentNeuralNetwork</a>
    /// </summary>
    let RecurrentNeuralNetwork = _prefixId.prefix "RecurrentNeuralNetwork"
    /// <summary>
    ///   <para>skos:prefLabel : Reducing Health Care Services</para>
    ///   <para>rdfs:comment : Reducing natural persons healthcare services</para>
    ///   <para>rdfs:label : Reducing Health Care Services</para>
    ///   <para>skos:definition : Reducing natural persons healthcare services</para>
    ///   <a href="https://w3id.org/vair#ReducingHealthCareServices">vair:ReducingHealthCareServices</a>
    /// </summary>
    let ReducingHealthCareServices = _prefixId.prefix "ReducingHealthCareServices"

    /// <summary>
    ///   <para>rdfs:comment : Reducing essential public assistance benefits and services</para>
    ///   <para>rdfs:label : Reducing Public Assistance Services</para>
    ///   <para>skos:definition : Reducing essential public assistance benefits and services</para>
    ///   <para>skos:prefLabel : Reducing Public Assistance Services</para>
    ///   <a href="https://w3id.org/vair#ReducingPublicAssistanceServices">vair:ReducingPublicAssistanceServices</a>
    /// </summary>
    let ReducingPublicAssistanceServices =
        _prefixId.prefix "ReducingPublicAssistanceServices"

    /// <summary>
    ///   <para>rdfs:label : Reinforcement Learning</para>
    ///   <para>skos:prefLabel : Reinforcement Learning</para>
    ///   <para>rdfs:comment : Learning of an optimal sequence of actions to maximize a reward through interaction with an environment</para>
    ///   <para>skos:definition : Learning of an optimal sequence of actions to maximize a reward through interaction with an environment</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.9^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#ReinforcementLearning">vair:ReinforcementLearning</a>
    /// </summary>
    let ReinforcementLearning = _prefixId.prefix "ReinforcementLearning"
    /// <summary>
    ///   <para>rdfs:comment : Identifying relationships among entities mentioned in a text.</para>
    ///   <para>skos:prefLabel : Relationship Extraction</para>
    ///   <para>rdfs:label : Relationship Extraction</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.15^^xsd:string</para>
    ///   <para>skos:definition : Identifying relationships among entities mentioned in a text.</para>
    ///   <a href="https://w3id.org/vair#RelationshipExtraction">vair:RelationshipExtraction</a>
    /// </summary>
    let RelationshipExtraction = _prefixId.prefix "RelationshipExtraction"
    let RemoteBiometricIdentification = _prefixId.prefix "RemoteBiometricIdentification"
    /// <summary>
    ///   <para>skos:prefLabel : Remote Identification</para>
    ///   <para>skos:definition : Refers to the identification of natural persons without their active involvement, typically at a distance</para>
    ///   <para>rdfs:label : Remote Identification</para>
    ///   <para>rdfs:comment : Refers to the identification of natural persons without their active involvement, typically at a distance</para>
    ///   <para>dcterms:source : AI Act, Recital 17^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#RemoteIdentification">vair:RemoteIdentification</a>
    /// </summary>
    let RemoteIdentification = _prefixId.prefix "RemoteIdentification"
    let RemoteIdentificationOfPeople = _prefixId.prefix "RemoteIdentificationOfPeople"
    /// <summary>
    ///   <para>rdfs:comment : Researching facts</para>
    ///   <para>skos:definition : Researching facts</para>
    ///   <para>rdfs:label : Researching Facts</para>
    ///   <para>skos:prefLabel : Researching Facts</para>
    ///   <a href="https://w3id.org/vair#ResearchingFacts">vair:ResearchingFacts</a>
    /// </summary>
    let ResearchingFacts = _prefixId.prefix "ResearchingFacts"
    /// <summary>
    ///   <para>rdfs:comment : Researching the law</para>
    ///   <para>skos:prefLabel : Researching Law</para>
    ///   <para>skos:definition : Researching the law</para>
    ///   <para>rdfs:label : Researching Law</para>
    ///   <a href="https://w3id.org/vair#ResearchingLaw">vair:ResearchingLaw</a>
    /// </summary>
    let ResearchingLaw = _prefixId.prefix "ResearchingLaw"
    /// <summary>
    ///   <para>rdfs:label : Residence Permit Applicant</para>
    ///   <para>skos:definition : A person who has applied for a residence permit</para>
    ///   <para>rdfs:comment : A person who has applied for a residence permit</para>
    ///   <para>skos:prefLabel : Residence Permit Applicant</para>
    ///   <a href="https://w3id.org/vair#ResidencePermitApplicant">vair:ResidencePermitApplicant</a>
    /// </summary>
    let ResidencePermitApplicant = _prefixId.prefix "ResidencePermitApplicant"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.9^^xsd:string</para>
    ///   <para>skos:prefLabel : Retirement</para>
    ///   <para>rdfs:label : Retirement</para>
    ///   <para>skos:definition : The stage the AI system become obsolete</para>
    ///   <para>rdfs:comment : The stage the AI system become obsolete</para>
    ///   <a href="https://w3id.org/vair#Retirement">vair:Retirement</a>
    /// </summary>
    let Retirement = _prefixId.prefix "Retirement"
    /// <summary>
    ///   <para>skos:prefLabel : Reverse Output</para>
    ///   <para>skos:definition : A mode of controllability that stakeholders can reverse the system’s output ex-post.</para>
    ///   <para>rdfs:comment : A mode of controllability that stakeholders can reverse the system’s output ex-post.</para>
    ///   <para>rdfs:label : Reverse Output^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#ReverseOutput">vair:ReverseOutput</a>
    /// </summary>
    let ReverseOutput = _prefixId.prefix "ReverseOutput"
    /// <summary>
    ///   <para>skos:prefLabel : Reversing Outcome</para>
    ///   <para>rdfs:label : Reversing Outcome</para>
    ///   <para>rdfs:comment : Reversing the outcome of a system.</para>
    ///   <para>skos:definition : Reversing the outcome of a system.</para>
    ///   <a href="https://w3id.org/vair#ReversingOutcome">vair:ReversingOutcome</a>
    /// </summary>
    let ReversingOutcome = _prefixId.prefix "ReversingOutcome"
    /// <summary>
    ///   <para>rdfs:label : Revoking Health Care Services</para>
    ///   <para>skos:prefLabel : Revoking Health Care Services</para>
    ///   <para>rdfs:comment : Revoking natural persons healthcare services</para>
    ///   <para>skos:definition : Revoking natural persons healthcare services</para>
    ///   <a href="https://w3id.org/vair#RevokingHealthCareServices">vair:RevokingHealthCareServices</a>
    /// </summary>
    let RevokingHealthCareServices = _prefixId.prefix "RevokingHealthCareServices"

    /// <summary>
    ///   <para>rdfs:comment : Revoking essential public assistance benefits and services</para>
    ///   <para>rdfs:label : Revoking Public Assistance Services</para>
    ///   <para>skos:prefLabel : Revoking Public Assistance Services</para>
    ///   <para>skos:definition : Revoking essential public assistance benefits and services</para>
    ///   <a href="https://w3id.org/vair#RevokingPublicAssistanceServices">vair:RevokingPublicAssistanceServices</a>
    /// </summary>
    let RevokingPublicAssistanceServices =
        _prefixId.prefix "RevokingPublicAssistanceServices"

    /// <summary>
    ///   <para>skos:definition : Refers to fundamental rights.</para>
    ///   <para>skos:prefLabel : Right</para>
    ///   <para>rdfs:comment : Refers to fundamental rights.</para>
    ///   <para>rdfs:label : Right</para>
    ///   <a href="https://w3id.org/vair#Right">vair:Right</a>
    /// </summary>
    let Right = _prefixId.prefix "Right"
    /// <summary>
    ///   <para>rdfs:label : Right To Non-discrimination</para>
    ///   <para>skos:prefLabel : Right To Non-discrimination</para>
    ///   <para>skos:definition : Refers to the fundamental right to non-discrimination</para>
    ///   <para>rdfs:comment : Refers to the fundamental right to non-discrimination</para>
    ///   <a href="https://w3id.org/vair#RightToNondiscrimination">vair:RightToNondiscrimination</a>
    /// </summary>
    let RightToNondiscrimination = _prefixId.prefix "RightToNondiscrimination"
    /// <summary>
    ///   <para>skos:definition : An automation system with actuators that performs intended tasks in the physical world, by means of sensing its environment and a software control system.</para>
    ///   <para>rdfs:label : ISO/IEC 22989, 3.1.29^^xsd:stringrdfs:label : Robot</para>
    ///   <para>rdfs:comment : An automation system with actuators that performs intended tasks in the physical world, by means of sensing its environment and a software control system.</para>
    ///   <para>skos:prefLabel : Robot</para>
    ///   <a href="https://w3id.org/vair#Robot">vair:Robot</a>
    /// </summary>
    let Robot = _prefixId.prefix "Robot"
    let RobotSystem = _prefixId.prefix "RobotSystem"
    let SVM = _prefixId.prefix "SVM"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the state of safety.</para>
    ///   <para>rdfs:label : Safety</para>
    ///   <para>skos:prefLabel : Safety</para>
    ///   <para>skos:definition : Refers to the state of safety.</para>
    ///   <a href="https://w3id.org/vair#Safety">vair:Safety</a>
    /// </summary>
    let Safety = _prefixId.prefix "Safety"
    /// <summary>
    ///   <para>skos:definition : Component of a product or of an AI system which fulfils a safety function for that product or AI system, or the failure or malfunctioning of which endangers the health and safety of persons or property.</para>
    ///   <para>dcterms:source : AI Act, Art. 3(14)^^xsd:string</para>
    ///   <para>rdfs:label : Safety Component</para>
    ///   <para>skos:prefLabel : Safety Component</para>
    ///   <para>rdfs:comment : Component of a product or of an AI system which fulfils a safety function for that product or AI system, or the failure or malfunctioning of which endangers the health and safety of persons or property</para>
    ///   <a href="https://w3id.org/vair#SafetyComponent">vair:SafetyComponent</a>
    /// </summary>
    let SafetyComponent = _prefixId.prefix "SafetyComponent"
    /// <summary>
    ///   <para>skos:definition : Refers to statistical-based search Methods</para>
    ///   <para>rdfs:comment : Refers to statistical-based search Methods</para>
    ///   <para>skos:prefLabel : Search Method</para>
    ///   <para>rdfs:label : Search Method</para>
    ///   <a href="https://w3id.org/vair#SearchMethod">vair:SearchMethod</a>
    /// </summary>
    let SearchMethod = _prefixId.prefix "SearchMethod"
    /// <summary>
    ///   <para>rdfs:comment : Refers to security measures </para>
    ///   <para>skos:definition : Refers to security measures</para>
    ///   <para>skos:prefLabel : Security Measure</para>
    ///   <para>rdfs:label : Security Measure</para>
    ///   <a href="https://w3id.org/vair#SecurityMeasure">vair:SecurityMeasure</a>
    /// </summary>
    let SecurityMeasure = _prefixId.prefix "SecurityMeasure"
    let SelectingPeople = _prefixId.prefix "SelectingPeople"
    /// <summary>
    ///   <para>rdfs:comment : Controls that are implemeted in a semi automated manner.</para>
    ///   <para>skos:prefLabel : Semi Automated Control</para>
    ///   <para>rdfs:label : Semi Automated Control</para>
    ///   <para>skos:definition : Controls that are implemeted in a semi automated manner.</para>
    ///   <a href="https://w3id.org/vair#SemiAutomatedControl">vair:SemiAutomatedControl</a>
    /// </summary>
    let SemiAutomatedControl = _prefixId.prefix "SemiAutomatedControl"
    /// <summary>
    ///   <para>skos:definition : Machine learning that makes use of both labelled and unlabelled data during training</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.11^^xsd:string</para>
    ///   <para>skos:prefLabel : Semi Supervised Learning</para>
    ///   <para>rdfs:label : Semi Supervised Learning</para>
    ///   <para>rdfs:comment : Machine learning that makes use of both labelled and unlabelled data during training</para>
    ///   <a href="https://w3id.org/vair#SemiSupervisedLearning">vair:SemiSupervisedLearning</a>
    /// </summary>
    let SemiSupervisedLearning = _prefixId.prefix "SemiSupervisedLearning"
    /// <summary>
    ///   <para>skos:definition : The capability of infering sensitive or protected attributes or characteristics</para>
    ///   <para>rdfs:comment : The capability of infering sensitive or protected attributes or characteristics</para>
    ///   <para>rdfs:label : Sensitive Attribute Inference</para>
    ///   <para>skos:prefLabel : Sensitive Attribute Inference</para>
    ///   <a href="https://w3id.org/vair#SensitiveAttributeInference">vair:SensitiveAttributeInference</a>
    /// </summary>
    let SensitiveAttributeInference = _prefixId.prefix "SensitiveAttributeInference"
    /// <summary>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.16^^xsd:string</para>
    ///   <para>rdfs:label : Sentiment Analysis</para>
    ///   <para>skos:prefLabel : Sentiment Analysis</para>
    ///   <para>skos:definition : Computationally identifying and categorizing opinions expressed in a piece of text, speech or image, to determine a range of feeling such as from positive to negative.</para>
    ///   <para>rdfs:comment : Computationally identifying and categorizing opinions expressed in a piece of text, speech or image, to determine a range of feeling such as from positive to negative.</para>
    ///   <a href="https://w3id.org/vair#SentimentAnalysis">vair:SentimentAnalysis</a>
    /// </summary>
    let SentimentAnalysis = _prefixId.prefix "SentimentAnalysis"
    /// <summary>
    ///   <para>skos:prefLabel : Service</para>
    ///   <para>rdfs:comment : Refers to system provided as a service</para>
    ///   <para>skos:definition : Refers to system provided as a service</para>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="https://w3id.org/vair#Service">vair:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>skos:definition : A robot in personal use or professional use that performs useful tasks for humans or equipment.</para>
    ///   <para>rdfs:label : Service Robot</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.1.29^^xsd:stringdcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:stringdcterms:source : SOURCE: ISO 8373:2021, 3.7^^xsd:string</para>
    ///   <para>rdfs:comment : A robot in personal use or professional use that performs useful tasks for humans or equipment.</para>
    ///   <para>skos:prefLabel : Service Robot</para>
    ///   <a href="https://w3id.org/vair#ServiceRobot">vair:ServiceRobot</a>
    /// </summary>
    let ServiceRobot = _prefixId.prefix "ServiceRobot"
    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function</para>
    ///   <para>rdfs:label : Serving Safety Function</para>
    ///   <para>skos:prefLabel : Serving Safety Function</para>
    ///   <para>rdfs:comment : Purpose of providing safety function</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunction">vair:ServingSafetyFunction</a>
    /// </summary>
    let ServingSafetyFunction = _prefixId.prefix "ServingSafetyFunction"

    /// <summary>
    ///   <para>skos:prefLabel : Serving Safety Function In Management</para>
    ///   <para>rdfs:label : Serving Safety Function In Management</para>
    ///   <para>skos:definition : Purpose of providing safety function in management of services</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of services</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagement">vair:ServingSafetyFunctionInManagement</a>
    /// </summary>
    let ServingSafetyFunctionInManagement =
        _prefixId.prefix "ServingSafetyFunctionInManagement"

    /// <summary>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of critical digital infrastructure</para>
    ///   <para>rdfs:label : Serving Safety Function In Management Of Critical Digital Infrastructure</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of Critical Digital Infrastructure</para>
    ///   <para>skos:definition : Purpose of providing safety function in management of critical digital infrastructure</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure">vair:ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfCriticalDigitalInfrastructure"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in management of road traffic</para>
    ///   <para>rdfs:label : Serving Safety Function In Management Of Road Traffic</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of Road Traffic</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of road traffic</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfRoadTraffic">vair:ServingSafetyFunctionInManagementOfRoadTraffic</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfRoadTraffic =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfRoadTraffic"

    /// <summary>
    ///   <para>rdfs:label : Serving Safety Function In Management Of The Supply Of Electricity</para>
    ///   <para>skos:definition : Purpose of providing safety function in management of the supply of electricity</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of the supply of electricity</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of The Supply Of Electricity</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfElectricity">vair:ServingSafetyFunctionInManagementOfTheSupplyOfElectricity</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfElectricity =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfTheSupplyOfElectricity"

    /// <summary>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of The Supply Of Gas</para>
    ///   <para>skos:definition : Purpose of providing safety function in management of the supply of gas</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of the supply of gas</para>
    ///   <para>rdfs:label : Serving Safety Function In Management Of The Supply Of Gas</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfGas">vair:ServingSafetyFunctionInManagementOfTheSupplyOfGas</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfGas =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfTheSupplyOfGas"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in management of the supply of heating</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of The Supply Of Heating</para>
    ///   <para>rdfs:label : Serving Safety Function In Management Of The Supply Of Heating</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of the supply of heating</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfHeating">vair:ServingSafetyFunctionInManagementOfTheSupplyOfHeating</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfHeating =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfTheSupplyOfHeating"

    /// <summary>
    ///   <para>skos:prefLabel : Serving Safety Function In Management Of The Supply Of Water</para>
    ///   <para>rdfs:label : Serving Safety Function In Management Of The Supply Of Water</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in management of the supply of water</para>
    ///   <para>skos:definition : Purpose of providing safety function in management of the supply of water</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInManagementOfTheSupplyOfWater">vair:ServingSafetyFunctionInManagementOfTheSupplyOfWater</a>
    /// </summary>
    let ServingSafetyFunctionInManagementOfTheSupplyOfWater =
        _prefixId.prefix "ServingSafetyFunctionInManagementOfTheSupplyOfWater"

    /// <summary>
    ///   <para>rdfs:label : Serving Safety Function In Operation</para>
    ///   <para>skos:definition : Purpose of providing safety function in operation of services</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of services</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperation">vair:ServingSafetyFunctionInOperation</a>
    /// </summary>
    let ServingSafetyFunctionInOperation =
        _prefixId.prefix "ServingSafetyFunctionInOperation"

    /// <summary>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of Critical Digital Infrastructure</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of Critical Digital Infrastructure</para>
    ///   <para>skos:definition : Purpose of providing safety function in operation of critical digital infrastructure</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of critical digital infrastructure</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure">vair:ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfCriticalDigitalInfrastructure"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in operation of road traffic</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of Road Traffic</para>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of Road Traffic</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of road traffic</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfRoadTraffic">vair:ServingSafetyFunctionInOperationOfRoadTraffic</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfRoadTraffic =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfRoadTraffic"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in operation of the supply of electricity</para>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of The Supply Of Electricity</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of the supply of electricity</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of The Supply Of Electricity</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfElectricity">vair:ServingSafetyFunctionInOperationOfTheSupplyOfElectricity</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfElectricity =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfTheSupplyOfElectricity"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in operation of the supply of gas</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of the supply of gas</para>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of The Supply Of Gas</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of The Supply Of Gas</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfGas">vair:ServingSafetyFunctionInOperationOfTheSupplyOfGas</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfGas =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfTheSupplyOfGas"

    /// <summary>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of the supply of heating</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of The Supply Of Heating</para>
    ///   <para>skos:definition : Purpose of providing safety function in operation of the supply of heating</para>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of The Supply Of Heating</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfHeating">vair:ServingSafetyFunctionInOperationOfTheSupplyOfHeating</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfHeating =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfTheSupplyOfHeating"

    /// <summary>
    ///   <para>skos:definition : Purpose of providing safety function in operation of the supply of water</para>
    ///   <para>rdfs:comment : Purpose of providing safety function in operation of the supply of water</para>
    ///   <para>rdfs:label : Serving Safety Function In Operation Of The Supply Of Water</para>
    ///   <para>skos:prefLabel : Serving Safety Function In Operation Of The Supply Of Water</para>
    ///   <a href="https://w3id.org/vair#ServingSafetyFunctionInOperationOfTheSupplyOfWater">vair:ServingSafetyFunctionInOperationOfTheSupplyOfWater</a>
    /// </summary>
    let ServingSafetyFunctionInOperationOfTheSupplyOfWater =
        _prefixId.prefix "ServingSafetyFunctionInOperationOfTheSupplyOfWater"

    /// <summary>
    ///   <para>skos:definition : Alternative dispute resolution</para>
    ///   <para>skos:prefLabel : Settling Dispute</para>
    ///   <para>rdfs:comment : Alternative dispute resolution</para>
    ///   <para>rdfs:label : Settling Dispute</para>
    ///   <a href="https://w3id.org/vair#SettlingDispute">vair:SettlingDispute</a>
    /// </summary>
    let SettlingDispute = _prefixId.prefix "SettlingDispute"
    let SmallScaleProvider = _prefixId.prefix "SmallScaleProvider"
    /// <summary>
    ///   <para>skos:prefLabel : Social Robot</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>rdfs:label : Social Robot^^xsd:string</para>
    ///   <para>skos:definition : Robots with social interaction functions.</para>
    ///   <para>rdfs:comment : Robots with social interaction functions.</para>
    ///   <a href="https://w3id.org/vair#SocialRobot">vair:SocialRobot</a>
    /// </summary>
    let SocialRobot = _prefixId.prefix "SocialRobot"
    /// <summary>
    ///   <para>rdfs:comment : Refers to a stand alone software system</para>
    ///   <para>rdfs:label : Software</para>
    ///   <para>skos:prefLabel : Software</para>
    ///   <para>skos:definition : Refers to a stand alone software system</para>
    ///   <a href="https://w3id.org/vair#Software">vair:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    let SoundEventRecognition = _prefixId.prefix "SoundEventRecognition"
    /// <summary>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>rdfs:label : Sound Source Separation</para>
    ///   <para>skos:definition : Extracting individual sound from audio recordings.</para>
    ///   <para>rdfs:comment : Extracting individual sound from audio recordings.</para>
    ///   <para>skos:prefLabel : Sound Source Separation</para>
    ///   <a href="https://w3id.org/vair#SoundSourceSeparation">vair:SoundSourceSeparation</a>
    /// </summary>
    let SoundSourceSeparation = _prefixId.prefix "SoundSourceSeparation"
    /// <summary>
    ///   <para>skos:definition : Generation of artificial sound.</para>
    ///   <para>rdfs:comment : Generation of artificial sound.</para>
    ///   <para>rdfs:label : Sound Synthesis</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>skos:prefLabel : Sound Synthesis</para>
    ///   <a href="https://w3id.org/vair#SoundSynthesis">vair:SoundSynthesis</a>
    /// </summary>
    let SoundSynthesis = _prefixId.prefix "SoundSynthesis"
    /// <summary>
    ///   <para>skos:prefLabel : Speaker Recognition</para>
    ///   <para>dcterms:source : AI Watch, Defining Artificial Intelligence 2.0^^xsd:string</para>
    ///   <para>rdfs:comment : Recognising speaker in audio recordings.</para>
    ///   <para>rdfs:label : Speaker Recognition</para>
    ///   <para>skos:definition : Recognising speaker in audio recordings.</para>
    ///   <a href="https://w3id.org/vair#SpeakerRecognition">vair:SpeakerRecognition</a>
    /// </summary>
    let SpeakerRecognition = _prefixId.prefix "SpeakerRecognition"
    /// <summary>
    ///   <para>rdfs:comment : Converting a speech signal to a representation of the content of the speech.</para>
    ///   <para>skos:prefLabel : Speech Recognition</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.17^^xsd:string</para>
    ///   <para>rdfs:label : Speech Recognition</para>
    ///   <para>skos:definition : Converting a speech signal to a representation of the content of the speech.</para>
    ///   <a href="https://w3id.org/vair#SpeechRecognition">vair:SpeechRecognition</a>
    /// </summary>
    let SpeechRecognition = _prefixId.prefix "SpeechRecognition"
    /// <summary>
    ///   <para>rdfs:comment : Generation of artificial speech.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.6.18^^xsd:string</para>
    ///   <para>skos:definition : Generation of artificial speech.</para>
    ///   <para>rdfs:label : Speech Synthesis</para>
    ///   <para>skos:prefLabel : Speech Synthesis</para>
    ///   <a href="https://w3id.org/vair#SpeechSynthesis">vair:SpeechSynthesis</a>
    /// </summary>
    let SpeechSynthesis = _prefixId.prefix "SpeechSynthesis"
    /// <summary>
    ///   <para>rdfs:comment : Incompetence of staff such as human oversight actors</para>
    ///   <para>skos:definition : Incompetence of staff such as human oversight actors</para>
    ///   <para>rdfs:label : Staff Incompetence</para>
    ///   <para>skos:prefLabel : Staff Incompetence</para>
    ///   <a href="https://w3id.org/vair#StaffIncompetence">vair:StaffIncompetence</a>
    /// </summary>
    let StaffIncompetence = _prefixId.prefix "StaffIncompetence"
    /// <summary>
    ///   <para>skos:prefLabel : Statistical Technique</para>
    ///   <para>rdfs:comment : Refers to techniques that are based on statistics</para>
    ///   <para>rdfs:label : Statistical Technique</para>
    ///   <para>skos:definition : Refers to techniques that are based on statistics</para>
    ///   <a href="https://w3id.org/vair#StatisticalTechnique">vair:StatisticalTechnique</a>
    /// </summary>
    let StatisticalTechnique = _prefixId.prefix "StatisticalTechnique"
    /// <summary>
    ///   <para>skos:definition : Machine learning that makes only use of labelled data during training</para>
    ///   <para>rdfs:comment : Machine learning that makes only use of labelled data during training</para>
    ///   <para>rdfs:label : Supervised Learning</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.11^^xsd:string</para>
    ///   <para>skos:prefLabel : Supervised Learning</para>
    ///   <a href="https://w3id.org/vair#SupervisedLearning">vair:SupervisedLearning</a>
    /// </summary>
    let SupervisedLearning = _prefixId.prefix "SupervisedLearning"
    /// <summary>
    ///   <para>rdfs:comment : a machine learning algorithm that finds decision boundaries with maximal margins.</para>
    ///   <para>skos:prefLabel : Support Vector Machine</para>
    ///   <para>dcterms:source : ISO/IEC 22989 3.3.13^^xsd:string</para>
    ///   <para>rdfs:label : Support Vector Machine</para>
    ///   <para>skos:definition : a machine learning algorithm that finds decision boundaries with maximal margins.</para>
    ///   <a href="https://w3id.org/vair#SupportVectorMachine">vair:SupportVectorMachine</a>
    /// </summary>
    let SupportVectorMachine = _prefixId.prefix "SupportVectorMachine"
    let Suspect = _prefixId.prefix "Suspect"
    /// <summary>
    ///   <para>skos:definition : Reasoning based on the knowledge encoded in a formal language</para>
    ///   <para>rdfs:comment : Reasoning based on the knowledge encoded in a formal language</para>
    ///   <para>skos:prefLabel : Symbolic Reasoning</para>
    ///   <para>rdfs:label : Symbolic Reasoning</para>
    ///   <a href="https://w3id.org/vair#SymbolicReasoning">vair:SymbolicReasoning</a>
    /// </summary>
    let SymbolicReasoning = _prefixId.prefix "SymbolicReasoning"
    let SystemArchitecture = _prefixId.prefix "SystemArchitecture"

    /// <summary>
    ///   <para>rdfs:label : System Architecture Documentation</para>
    ///   <para>skos:prefLabel : System Architecture Documentation</para>
    ///   <para>skos:definition : Documentation specifying software architecture.</para>
    ///   <para>rdfs:comment : Documentation specifying software architecture.</para>
    ///   <a href="https://w3id.org/vair#SystemArchitectureDocumentation">vair:SystemArchitectureDocumentation</a>
    /// </summary>
    let SystemArchitectureDocumentation =
        _prefixId.prefix "SystemArchitectureDocumentation"

    /// <summary>
    ///   <para>skos:prefLabel : System Risk Source</para>
    ///   <para>rdfs:label : System Risk Source</para>
    ///   <para>rdfs:comment : Risk sources related to the AI system</para>
    ///   <para>skos:definition : Risk sources related to the AI system</para>
    ///   <a href="https://w3id.org/vair#SystemRiskSource">vair:SystemRiskSource</a>
    /// </summary>
    let SystemRiskSource = _prefixId.prefix "SystemRiskSource"
    let SystemVulnerability = _prefixId.prefix "SystemVulnerability"
    /// <summary>
    ///   <para>skos:prefLabel : Technical Documentation</para>
    ///   <para>rdfs:label : Technical Documentation</para>
    ///   <para>skos:definition : Documentation required by the AI Act, Article 11.</para>
    ///   <para>rdfs:comment : Documentation required by the AI Act, Article 11.</para>
    ///   <a href="https://w3id.org/vair#TechnicalDocumentation">vair:TechnicalDocumentation</a>
    /// </summary>
    let TechnicalDocumentation = _prefixId.prefix "TechnicalDocumentation"
    /// <summary>
    ///   <para>skos:definition : Refers to technical measures</para>
    ///   <para>rdfs:label : Technical Measure</para>
    ///   <para>skos:prefLabel : Technical Measure</para>
    ///   <para>rdfs:comment : Refers to technical measures </para>
    ///   <a href="https://w3id.org/vair#TechnicalMeasure">vair:TechnicalMeasure</a>
    /// </summary>
    let TechnicalMeasure = _prefixId.prefix "TechnicalMeasure"
    /// <summary>
    ///   <para>rdfs:comment : An AI application-specific integrated circuit developed by Google.</para>
    ///   <para>skos:definition : An AI application-specific integrated circuit developed by Google.</para>
    ///   <para>skos:prefLabel : Tensor Processing Unit</para>
    ///   <para>rdfs:label : Tensor Processing Unit</para>
    ///   <a href="https://w3id.org/vair#TensorProcessingUnit">vair:TensorProcessingUnit</a>
    /// </summary>
    let TensorProcessingUnit = _prefixId.prefix "TensorProcessingUnit"
    let TestData = _prefixId.prefix "TestData"
    /// <summary>
    ///   <para>skos:definition : Risk sources related to test data</para>
    ///   <para>skos:prefLabel : Test Data Risk Source</para>
    ///   <para>rdfs:comment : Risk sources related to test data</para>
    ///   <para>rdfs:label : Test Data Risk Source</para>
    ///   <a href="https://w3id.org/vair#TestDataRiskSource">vair:TestDataRiskSource</a>
    /// </summary>
    let TestDataRiskSource = _prefixId.prefix "TestDataRiskSource"
    /// <summary>
    ///   <para>rdfs:label : Test Log</para>
    ///   <para>skos:prefLabel : Test Log</para>
    ///   <para>rdfs:comment : Log of the tests performed.</para>
    ///   <para>skos:definition : Log of the tests performed.</para>
    ///   <a href="https://w3id.org/vair#TestLog">vair:TestLog</a>
    /// </summary>
    let TestLog = _prefixId.prefix "TestLog"
    /// <summary>
    ///   <para>skos:definition : A document that includes a summary of test activities and their results.</para>
    ///   <para>skos:prefLabel : Test Report</para>
    ///   <para>rdfs:label : Test Report</para>
    ///   <para>rdfs:comment : A document that includes a summary of test activities and their results.</para>
    ///   <a href="https://w3id.org/vair#TestReport">vair:TestReport</a>
    /// </summary>
    let TestReport = _prefixId.prefix "TestReport"
    let Testing = _prefixId.prefix "Testing"
    /// <summary>
    ///   <para>rdfs:comment : Refers to a software toolrdfs:comment : Tool^^xsd:string</para>
    ///   <para>rdfs:label : Tool</para>
    ///   <para>skos:definition : Refers to a software tool</para>
    ///   <para>skos:prefLabel : Tool</para>
    ///   <a href="https://w3id.org/vair#Tool">vair:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    /// <summary>
    ///   <para>rdfs:label : Trained Model^^xsd:string</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.14^^xsd:string</para>
    ///   <para>rdfs:comment : Model resulted from model training.</para>
    ///   <para>skos:definition : Model resulted from model training.</para>
    ///   <para>skos:prefLabel : Trained Model</para>
    ///   <a href="https://w3id.org/vair#TrainedModel">vair:TrainedModel</a>
    /// </summary>
    let TrainedModel = _prefixId.prefix "TrainedModel"
    let TrainingData = _prefixId.prefix "TrainingData"
    /// <summary>
    ///   <para>skos:prefLabel : Training Data Risk Source</para>
    ///   <para>skos:definition : Risk sources related to training data</para>
    ///   <para>rdfs:comment : Risk sources related to training data</para>
    ///   <para>rdfs:label : Training Data Risk Source</para>
    ///   <a href="https://w3id.org/vair#TrainingDataRiskSource">vair:TrainingDataRiskSource</a>
    /// </summary>
    let TrainingDataRiskSource = _prefixId.prefix "TrainingDataRiskSource"
    /// <summary>
    ///   <para>rdfs:comment : Refers to transparency measures </para>
    ///   <para>rdfs:label : Transparency Measure</para>
    ///   <para>skos:definition : Refers to transparency measures</para>
    ///   <para>skos:prefLabel : Transparency Measure</para>
    ///   <a href="https://w3id.org/vair#TransparencyMeasure">vair:TransparencyMeasure</a>
    /// </summary>
    let TransparencyMeasure = _prefixId.prefix "TransparencyMeasure"
    /// <summary>
    ///   <para>rdfs:label : Unavailability Of Data</para>
    ///   <para>rdfs:comment : Use of datasets that are not available</para>
    ///   <para>skos:prefLabel : Unavailability Of Data</para>
    ///   <para>skos:definition : Use of datasets that are not available</para>
    ///   <a href="https://w3id.org/vair#UnavailabilityOfData">vair:UnavailabilityOfData</a>
    /// </summary>
    let UnavailabilityOfData = _prefixId.prefix "UnavailabilityOfData"
    /// <summary>
    ///   <para>rdfs:label : Uninformed Involvement</para>
    ///   <para>skos:prefLabel : Uninformed Involvement</para>
    ///   <para>rdfs:comment : Represents that a specific actor was not informed that an AI system is in place.</para>
    ///   <para>skos:definition : Represents that a specific actor was not informed that an AI system is in place.</para>
    ///   <a href="https://w3id.org/vair#UninformedInvolvement">vair:UninformedInvolvement</a>
    /// </summary>
    let UninformedInvolvement = _prefixId.prefix "UninformedInvolvement"
    /// <summary>
    ///   <para>rdfs:label : Unintended Involvement</para>
    ///   <para>skos:prefLabel : Unintended Involvement</para>
    ///   <para>rdfs:comment : Represents unintended involvement of a specific actor.</para>
    ///   <para>skos:definition : Represents unintended involvement of a specific actor.</para>
    ///   <a href="https://w3id.org/vair#UnintendedInvolvement">vair:UnintendedInvolvement</a>
    /// </summary>
    let UnintendedInvolvement = _prefixId.prefix "UnintendedInvolvement"
    /// <summary>
    ///   <para>skos:definition : Use of unrepresentative data for testing</para>
    ///   <para>rdfs:label : Unrepresentative Test Data</para>
    ///   <para>rdfs:comment : Use of unrepresentative  data for testing</para>
    ///   <para>skos:prefLabel : Unrepresentative Test Data</para>
    ///   <a href="https://w3id.org/vair#UnrepresentativeTestData">vair:UnrepresentativeTestData</a>
    /// </summary>
    let UnrepresentativeTestData = _prefixId.prefix "UnrepresentativeTestData"
    /// <summary>
    ///   <para>rdfs:comment : Use of unrepresentative data for training</para>
    ///   <para>rdfs:label : Unrepresentative Training Data</para>
    ///   <para>skos:definition : Use of unrepresentative data for training</para>
    ///   <para>skos:prefLabel : Unrepresentative Training Data</para>
    ///   <a href="https://w3id.org/vair#UnrepresentativeTrainingData">vair:UnrepresentativeTrainingData</a>
    /// </summary>
    let UnrepresentativeTrainingData = _prefixId.prefix "UnrepresentativeTrainingData"

    /// <summary>
    ///   <para>skos:prefLabel : Unrepresentative Validation Data</para>
    ///   <para>rdfs:label : Unrepresentative Validation Data</para>
    ///   <para>skos:definition : Use of unrepresentative data for validation</para>
    ///   <para>rdfs:comment : Use of unrepresentative data for validation</para>
    ///   <a href="https://w3id.org/vair#UnrepresentativeValidationData">vair:UnrepresentativeValidationData</a>
    /// </summary>
    let UnrepresentativeValidationData =
        _prefixId.prefix "UnrepresentativeValidationData"

    /// <summary>
    ///   <para>skos:definition : Machine learning that makes only use of unlabelled data during training.</para>
    ///   <para>skos:prefLabel : Unsupervised Learning</para>
    ///   <para>rdfs:label : Unsupervised Learning</para>
    ///   <para>rdfs:comment : Machine learning that makes only use of unlabelled data during training.</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 3.3.17^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#UnsupervisedLearning">vair:UnsupervisedLearning</a>
    /// </summary>
    let UnsupervisedLearning = _prefixId.prefix "UnsupervisedLearning"
    /// <summary>
    ///   <para>rdfs:label : User Training</para>
    ///   <para>skos:prefLabel : User Training</para>
    ///   <para>rdfs:comment : Providing training to staff, users, etc.</para>
    ///   <para>skos:definition : Providing training to staff, users, etc.</para>
    ///   <a href="https://w3id.org/vair#UserTraining">vair:UserTraining</a>
    /// </summary>
    let UserTraining = _prefixId.prefix "UserTraining"
    /// <summary>
    ///   <para>skos:prefLabel : Validation</para>
    ///   <para>rdfs:comment : Validating that the AI system from the design and development stage works according to requirements and meets objectives.</para>
    ///   <para>rdfs:label : Validation</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.4^^xsd:string</para>
    ///   <para>skos:definition : Validating that the AI system from the design and development stage works according to requirements and meets objectives.</para>
    ///   <a href="https://w3id.org/vair#Validation">vair:Validation</a>
    /// </summary>
    let Validation = _prefixId.prefix "Validation"
    let ValidationData = _prefixId.prefix "ValidationData"
    /// <summary>
    ///   <para>rdfs:label : Validation Data Risk Source</para>
    ///   <para>skos:definition : Risk sources related to validation data</para>
    ///   <para>rdfs:comment : Risk sources related to validation data</para>
    ///   <para>skos:prefLabel : Validation Data Risk Source</para>
    ///   <a href="https://w3id.org/vair#ValidationDataRiskSource">vair:ValidationDataRiskSource</a>
    /// </summary>
    let ValidationDataRiskSource = _prefixId.prefix "ValidationDataRiskSource"
    /// <summary>
    ///   <para>skos:prefLabel : Verification</para>
    ///   <para>rdfs:comment : Verifying the AI system from the design and development stage works according to requirements and meets objectives.</para>
    ///   <para>skos:definition : Verifying the AI system from the design and development stage works according to requirements and meets objectives.</para>
    ///   <para>rdfs:label : Verification</para>
    ///   <para>dcterms:source : ISO/IEC 22989, 6.2.4^^xsd:string</para>
    ///   <a href="https://w3id.org/vair#Verification">vair:Verification</a>
    /// </summary>
    let Verification = _prefixId.prefix "Verification"

    let VerificationOfMigrationSeekerClaims =
        _prefixId.prefix "VerificationOfMigrationSeekerClaims"

    /// <summary>
    ///   <para>skos:prefLabel : Verifying Authenticity Of Travel Document</para>
    ///   <para>rdfs:label : Verifying Authenticity Of Travel Document</para>
    ///   <para>rdfs:comment : Verifying of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features.</para>
    ///   <para>skos:definition : Verifying of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features.</para>
    ///   <a href="https://w3id.org/vair#VerifyingAuthenticityOfTravelDocument">vair:VerifyingAuthenticityOfTravelDocument</a>
    /// </summary>
    let VerifyingAuthenticityOfTravelDocument =
        _prefixId.prefix "VerifyingAuthenticityOfTravelDocument"

    let Victim = _prefixId.prefix "Victim"
    /// <summary>
    ///   <para>skos:definition : A person who has applied for a visa</para>
    ///   <para>skos:prefLabel : Visa Applicant</para>
    ///   <para>rdfs:label : Visa Applicant</para>
    ///   <para>rdfs:comment : A person who has applied for a visa</para>
    ///   <a href="https://w3id.org/vair#VisaApplicant">vair:VisaApplicant</a>
    /// </summary>
    let VisaApplicant = _prefixId.prefix "VisaApplicant"
    /// <summary>
    ///   <para>skos:definition : Vocational training institution at any level</para>
    ///   <para>rdfs:label : Vocational Training Institution</para>
    ///   <para>skos:prefLabel : Vocational Training Institution</para>
    ///   <para>rdfs:comment : Vocational training institution at any level</para>
    ///   <a href="https://w3id.org/vair#VocationalTrainingInstitution">vair:VocationalTrainingInstitution</a>
    /// </summary>
    let VocationalTrainingInstitution = _prefixId.prefix "VocationalTrainingInstitution"
    /// <summary>
    ///   <para>skos:definition : Refers to impacts that affect wellbeing</para>
    ///   <para>rdfs:label : Wellbeing Impact</para>
    ///   <para>skos:prefLabel : Wellbeing Impact</para>
    ///   <para>rdfs:comment : Refers to impacts that affect wellbeing</para>
    ///   <a href="https://w3id.org/vair#WellbeingImpact">vair:WellbeingImpact</a>
    /// </summary>
    let WellbeingImpact = _prefixId.prefix "WellbeingImpact"
    /// <summary>
    ///   <para>rdfs:label : Wrong Data Design Choice</para>
    ///   <para>skos:definition : Refers to the wrong choice made in the selecting datasets.</para>
    ///   <para>rdfs:comment : Refers to the wrong choice made in the selecting datasets.</para>
    ///   <para>skos:prefLabel : Wrong Data Design Choice</para>
    ///   <a href="https://w3id.org/vair#WrongDataDesignChoice">vair:WrongDataDesignChoice</a>
    /// </summary>
    let WrongDataDesignChoice = _prefixId.prefix "WrongDataDesignChoice"
