namespace https.w3id.org.semsys.ns.swemls.hash

open DoxAletheia

module swemls =
    let _namespace_name = "https://w3id.org/semsys/ns/swemls#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Positioning of the Paper in relation to research araeas e.g. Explainable AI or Semantic Web Mining
    /// <see href="https://w3id.org/semsys/ns/swemls#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// The application domain in which the SWeML systems solve tasks (e.g. Chemistry, Legal)
    /// <see href="https://w3id.org/semsys/ns/swemls#ApplicationDomain"></see></summary>
    let ApplicationDomain = _prefix "ApplicationDomain"
    /// <summary>
    /// Maturity of the overall SWeML system
    /// <see href="https://w3id.org/semsys/ns/swemls#SystemMaturity"></see></summary>
    let SystemMaturity = _prefix "SystemMaturity"
    /// <summary>
    /// Paper type, e.g. Workshop or Conference paper
    /// <see href="https://w3id.org/semsys/ns/swemls#PaperType"></see></summary>
    let PaperType = _prefix "PaperType"
    /// <summary>
    /// Basic pattern type: a single algorithmic module consumes a single input
    /// <see href="https://w3id.org/semsys/ns/swemls#Atomic-Pattern"></see></summary>
    let ``Atomic-Pattern`` = _prefix "Atomic-Pattern"
    /// <summary>
    /// Basic pattern type: a single algorithmic module consumes more than one input
    /// <see href="https://w3id.org/semsys/ns/swemls#Fusion-Pattern"></see></summary>
    let ``Fusion-Pattern`` = _prefix "Fusion-Pattern"
    /// <summary>
    /// Advanced pattern type: a chain of Atomic Patterns
    /// <see href="https://w3id.org/semsys/ns/swemls#I-Pattern"></see></summary>
    let ``I-Pattern`` = _prefix "I-Pattern"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#M-Pattern"></see>
    /// </summary>
    let ``M-Pattern`` = _prefix "M-Pattern"
    /// <summary>
    /// Patterns describing the SWeMLs flow
    /// <see href="https://w3id.org/semsys/ns/swemls#Pattern"></see></summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    /// Other Patterns that do not fit in any other category
    /// <see href="https://w3id.org/semsys/ns/swemls#Other-Pattern"></see></summary>
    let ``Other-Pattern`` = _prefix "Other-Pattern"
    /// <summary>
    /// Advanded pattern type: a chain of Atomic and Fusion Patterns
    /// <see href="https://w3id.org/semsys/ns/swemls#T-Pattern"></see></summary>
    let ``T-Pattern`` = _prefix "T-Pattern"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#X-Pattern"></see>
    /// </summary>
    let ``X-Pattern`` = _prefix "X-Pattern"
    /// <summary>
    /// Advanced pattern type: combination of two (or more) Atomic Patterns via a Fusion Pattern
    /// <see href="https://w3id.org/semsys/ns/swemls#Y-Pattern"></see></summary>
    let ``Y-Pattern`` = _prefix "Y-Pattern"
    /// <summary>
    /// Processing engine, that processes semantic web resources e.g.  SPARQL query engine, reasoner
    /// <see href="https://w3id.org/semsys/ns/swemls#ProcessingEngine"></see></summary>
    let ProcessingEngine = _prefix "ProcessingEngine"
    /// <summary>
    /// Semantic entities or relations
    /// <see href="https://w3id.org/semsys/ns/swemls#SemanticWebResource"></see></summary>
    let SemanticWebResource = _prefix "SemanticWebResource"
    /// <summary>
    /// Linking the symbol formalism with the semantic web resource data
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceFormalism"></see></summary>
    let hasResourceFormalism = _prefix "hasResourceFormalism"
    /// <summary>
    /// Linking the semantic web resource with the resource size
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceSize"></see></summary>
    let hasResourceSize = _prefix "hasResourceSize"
    /// <summary>
    /// Linking the semantic web resource with the resource type
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceType"></see></summary>
    let hasResourceType = _prefix "hasResourceType"
    /// <summary>
    /// Formalism of the semantic web resource data
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceFormalism"></see></summary>
    let ResourceFormalism = _prefix "ResourceFormalism"
    /// <summary>
    /// Size of the semantic web resource(s) in triples
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceSize"></see></summary>
    let ResourceSize = _prefix "ResourceSize"
    /// <summary>
    /// Resource type of the semantic web resources resource, e.g. ontology, queries
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceType"></see></summary>
    let ResourceType = _prefix "ResourceType"
    /// <summary>
    /// Inductive Model
    /// <see href="https://w3id.org/semsys/ns/swemls#StatisticalModel"></see></summary>
    let StatisticalModel = _prefix "StatisticalModel"
    /// <summary>
    /// Type of usage of the semantic web resource
    /// <see href="https://w3id.org/semsys/ns/swemls#SymbolUsage"></see></summary>
    let SymbolUsage = _prefix "SymbolUsage"
    /// <summary>
    /// Task that the SWeML system supposed to solve
    /// <see href="https://w3id.org/semsys/ns/swemls#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// Training type of the ML model(s)
    /// <see href="https://w3id.org/semsys/ns/swemls#TrainingType"></see></summary>
    let TrainingType = _prefix "TrainingType"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Australia"></see>
    /// </summary>
    let Australia = _prefix "Australia"
    /// <summary>
    /// Country to which authors describing the SWeML systems in their paper are affiliated to
    /// <see href="https://w3id.org/semsys/ns/swemls#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Austria"></see>
    /// </summary>
    let Austria = _prefix "Austria"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Belgium"></see>
    /// </summary>
    let Belgium = _prefix "Belgium"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Brazil"></see>
    /// </summary>
    let Brazil = _prefix "Brazil"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Bulgaria"></see>
    /// </summary>
    let Bulgaria = _prefix "Bulgaria"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Canada"></see>
    /// </summary>
    let Canada = _prefix "Canada"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#China"></see>
    /// </summary>
    let China = _prefix "China"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Colombia"></see>
    /// </summary>
    let Colombia = _prefix "Colombia"
    /// <summary>
    /// Facts and statistics collected together and used as a basis for reasoning, discussion or calculation.
    /// <see href="https://w3id.org/semsys/ns/swemls#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Instance"></see>
    /// </summary>
    let Instance = _prefix "Instance"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Denmark"></see>
    /// </summary>
    let Denmark = _prefix "Denmark"
    /// <summary>
    /// Documenation characteristics e.g. used dataset, training parameters, evaluation metrics
    /// <see href="https://w3id.org/semsys/ns/swemls#Documentation"></see></summary>
    let Documentation = _prefix "Documentation"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Egypt"></see>
    /// </summary>
    let Egypt = _prefix "Egypt"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Finland"></see>
    /// </summary>
    let Finland = _prefix "Finland"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#France"></see>
    /// </summary>
    let France = _prefix "France"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Germany"></see>
    /// </summary>
    let Germany = _prefix "Germany"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Greece"></see>
    /// </summary>
    let Greece = _prefix "Greece"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Hong_Kong"></see>
    /// </summary>
    let Hong_Kong = _prefix "Hong_Kong"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#India"></see>
    /// </summary>
    let India = _prefix "India"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Indonesia"></see>
    /// </summary>
    let Indonesia = _prefix "Indonesia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Iran"></see>
    /// </summary>
    let Iran = _prefix "Iran"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Ireland"></see>
    /// </summary>
    let Ireland = _prefix "Ireland"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Italy"></see>
    /// </summary>
    let Italy = _prefix "Italy"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Italy_and_UK"></see>
    /// </summary>
    let Italy_and_UK = _prefix "Italy_and_UK"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Jamaica"></see>
    /// </summary>
    let Jamaica = _prefix "Jamaica"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Japan"></see>
    /// </summary>
    let Japan = _prefix "Japan"
    /// <summary>
    /// A Knowledge Representation component
    /// <see href="https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent"></see></summary>
    let KnowledgeRepresentationComponent = _prefix "KnowledgeRepresentationComponent"
    /// <summary>
    /// One component of the system
    /// <see href="https://w3id.org/semsys/ns/swemls#SystemComponent"></see></summary>
    let SystemComponent = _prefix "SystemComponent"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Korea"></see>
    /// </summary>
    let Korea = _prefix "Korea"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Kosovo"></see>
    /// </summary>
    let Kosovo = _prefix "Kosovo"
    /// <summary>
    /// A Machine Learning component
    /// <see href="https://w3id.org/semsys/ns/swemls#MachineLearningComponent"></see></summary>
    let MachineLearningComponent = _prefix "MachineLearningComponent"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Mexico"></see>
    /// </summary>
    let Mexico = _prefix "Mexico"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Missing_Info"></see>
    /// </summary>
    let Missing_Info = _prefix "Missing_Info"
    /// <summary>
    /// Models used in the SWeML systems
    /// <see href="https://w3id.org/semsys/ns/swemls#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Morocco"></see>
    /// </summary>
    let Morocco = _prefix "Morocco"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Netherlands"></see>
    /// </summary>
    let Netherlands = _prefix "Netherlands"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#New_Zealand"></see>
    /// </summary>
    let New_Zealand = _prefix "New_Zealand"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Norway"></see>
    /// </summary>
    let Norway = _prefix "Norway"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Pakistan"></see>
    /// </summary>
    let Pakistan = _prefix "Pakistan"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Palestine"></see>
    /// </summary>
    let Palestine = _prefix "Palestine"
    /// <summary>
    /// Paper in which the SWeML system is described
    /// <see href="https://w3id.org/semsys/ns/swemls#Paper"></see></summary>
    let Paper = _prefix "Paper"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Poland"></see>
    /// </summary>
    let Poland = _prefix "Poland"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Portual"></see>
    /// </summary>
    let Portual = _prefix "Portual"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Portugal"></see>
    /// </summary>
    let Portugal = _prefix "Portugal"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Republic_of_Korea"></see>
    /// </summary>
    let Republic_of_Korea = _prefix "Republic_of_Korea"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Romania"></see>
    /// </summary>
    let Romania = _prefix "Romania"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Russia"></see>
    /// </summary>
    let Russia = _prefix "Russia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Saudi_Arabia"></see>
    /// </summary>
    let Saudi_Arabia = _prefix "Saudi_Arabia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Saudi_Ariabia"></see>
    /// </summary>
    let Saudi_Ariabia = _prefix "Saudi_Ariabia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Scotland"></see>
    /// </summary>
    let Scotland = _prefix "Scotland"
    /// <summary>
    /// Deductive Model
    /// <see href="https://w3id.org/semsys/ns/swemls#SemanticModel"></see></summary>
    let SemanticModel = _prefix "SemanticModel"
    /// <summary>
    /// A representation of symbolic data such as semantic entities or relations.
    /// <see href="https://w3id.org/semsys/ns/swemls#Symbol"></see></summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Singapore"></see>
    /// </summary>
    let Singapore = _prefix "Singapore"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Slovenia"></see>
    /// </summary>
    let Slovenia = _prefix "Slovenia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#South_Korea"></see>
    /// </summary>
    let South_Korea = _prefix "South_Korea"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Spain"></see>
    /// </summary>
    let Spain = _prefix "Spain"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sri_Lanka"></see>
    /// </summary>
    let Sri_Lanka = _prefix "Sri_Lanka"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sudan"></see>
    /// </summary>
    let Sudan = _prefix "Sudan"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sweden"></see>
    /// </summary>
    let Sweden = _prefix "Sweden"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Switzerland"></see>
    /// </summary>
    let Switzerland = _prefix "Switzerland"
    /// <summary>
    /// SWeML System
    /// <see href="https://w3id.org/semsys/ns/swemls#System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Taiwan"></see>
    /// </summary>
    let Taiwan = _prefix "Taiwan"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Thailand"></see>
    /// </summary>
    let Thailand = _prefix "Thailand"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#The_Netherlands"></see>
    /// </summary>
    let The_Netherlands = _prefix "The_Netherlands"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Tunisia"></see>
    /// </summary>
    let Tunisia = _prefix "Tunisia"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Turkey"></see>
    /// </summary>
    let Turkey = _prefix "Turkey"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#UAE"></see>
    /// </summary>
    let UAE = _prefix "UAE"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#UK"></see>
    /// </summary>
    let UK = _prefix "UK"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#USA"></see>
    /// </summary>
    let USA = _prefix "USA"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#United_Kingdom"></see>
    /// </summary>
    let United_Kingdom = _prefix "United_Kingdom"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Vietnam"></see>
    /// </summary>
    let Vietnam = _prefix "Vietnam"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Wales"></see>
    /// </summary>
    let Wales = _prefix "Wales"
    /// <summary>
    /// Country to which authors describing the SWeML systems in their paper are affiliated to
    /// <see href="https://w3id.org/semsys/ns/swemls#author_country"></see></summary>
    let author_country = _prefix "author_country"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#componentInput"></see>
    /// </summary>
    let componentInput = _prefix "componentInput"
    /// <summary>
    /// Linking the system with component models
    /// <see href="https://w3id.org/semsys/ns/swemls#componentModel"></see></summary>
    let componentModel = _prefix "componentModel"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#componentOutput"></see>
    /// </summary>
    let componentOutput = _prefix "componentOutput"
    /// <summary>
    /// Presence of documentation on used data sets: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_data"></see></summary>
    let evaluation_data = _prefix "evaluation_data"
    /// <summary>
    /// Presence of documentation on used training, development and test set
    /// used in evaluation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_data_split"></see></summary>
    let evaluation_data_split = _prefix "evaluation_data_split"
    /// <summary>
    /// Presence of documentation on used metrics in evaluation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_metrics"></see></summary>
    let evaluation_metrics = _prefix "evaluation_metrics"
    /// <summary>
    /// Linking the system with the application domain it is working in
    /// <see href="https://w3id.org/semsys/ns/swemls#hasApplicationDomain"></see></summary>
    let hasApplicationDomain = _prefix "hasApplicationDomain"
    /// <summary>
    /// Linking a SWeML system with a research area it is associated with
    /// <see href="https://w3id.org/semsys/ns/swemls#hasArea"></see></summary>
    let hasArea = _prefix "hasArea"
    /// <summary>
    /// Linking a paper with the countries of author's affiliations
    /// <see href="https://w3id.org/semsys/ns/swemls#hasAuthorsCountry"></see></summary>
    let hasAuthorsCountry = _prefix "hasAuthorsCountry"
    /// <summary>
    /// A SWeML system has a corresponding pattern
    /// <see href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern"></see></summary>
    let hasCorrespondingPattern = _prefix "hasCorrespondingPattern"
    /// <summary>
    /// Linking the corresponding step of a pattern workflow with a specific system component
    /// <see href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep"></see></summary>
    let hasCorrespondingPatternStep = _prefix "hasCorrespondingPatternStep"
    /// <summary>
    /// Data as in- output(s) in the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasDataIO"></see></summary>
    let hasDataIO = _prefix "hasDataIO"
    /// <summary>
    /// Describes in- and outputs to SWeML systems
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemIO"></see></summary>
    let hasSystemIO = _prefix "hasSystemIO"
    /// <summary>
    /// System has documentation providing details about e.g. training steps or split, used datasets and evaluation metrics
    /// <see href="https://w3id.org/semsys/ns/swemls#hasDocumentation"></see></summary>
    let hasDocumentation = _prefix "hasDocumentation"
    /// <summary>
    /// Keywords assigned to the publication by the authors
    /// <see href="https://w3id.org/semsys/ns/swemls#hasKeyword"></see></summary>
    let hasKeyword = _prefix "hasKeyword"
    /// <summary>
    /// A SWeML system can have one or more models
    /// <see href="https://w3id.org/semsys/ns/swemls#hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    /// SWeMLs can have one or more processing engines
    /// <see href="https://w3id.org/semsys/ns/swemls#hasProcessingEngine"></see></summary>
    let hasProcessingEngine = _prefix "hasProcessingEngine"
    /// <summary>
    /// A SWeML system linking to at least one statistical model
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStatisticalModel"></see></summary>
    let hasStatisticalModel = _prefix "hasStatisticalModel"
    /// <summary>
    /// Linking SWeMLs to Knowledge Representation component(s) in different steps of the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStepKR"></see></summary>
    let hasStepKR = _prefix "hasStepKR"
    /// <summary>
    /// SWeMLs can have one or more system components
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemComponent"></see></summary>
    let hasSystemComponent = _prefix "hasSystemComponent"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepKR1"></see>
    /// </summary>
    let hasStepKR1 = _prefix "hasStepKR1"
    /// <summary>
    /// Linking SWeMLs to Machine Learning component(s) in different steps of the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStepML"></see></summary>
    let hasStepML = _prefix "hasStepML"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML1"></see>
    /// </summary>
    let hasStepML1 = _prefix "hasStepML1"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML2"></see>
    /// </summary>
    let hasStepML2 = _prefix "hasStepML2"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML3"></see>
    /// </summary>
    let hasStepML3 = _prefix "hasStepML3"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML4"></see>
    /// </summary>
    let hasStepML4 = _prefix "hasStepML4"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML5"></see>
    /// </summary>
    let hasStepML5 = _prefix "hasStepML5"
    /// <summary>
    /// Symbol as in- output(s) in the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSymbolIO"></see></summary>
    let hasSymbolIO = _prefix "hasSymbolIO"
    /// <summary>
    /// Linking system to symbol usage
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSymbolUsage"></see></summary>
    let hasSymbolUsage = _prefix "hasSymbolUsage"
    /// <summary>
    /// System has a certain maturity according to different characteristics (stability, UI)
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemMaturity"></see></summary>
    let hasSystemMaturity = _prefix "hasSystemMaturity"
    /// <summary>
    /// Linking the system to the task it is solving
    /// <see href="https://w3id.org/semsys/ns/swemls#hasTask"></see></summary>
    let hasTask = _prefix "hasTask"
    /// <summary>
    /// Linking the training type of the system
    /// <see href="https://w3id.org/semsys/ns/swemls#hasTrainingType"></see></summary>
    let hasTrainingType = _prefix "hasTrainingType"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData1"></see>
    /// </summary>
    let hasVariableData1 = _prefix "hasVariableData1"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData2"></see>
    /// </summary>
    let hasVariableData2 = _prefix "hasVariableData2"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData3"></see>
    /// </summary>
    let hasVariableData3 = _prefix "hasVariableData3"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData4"></see>
    /// </summary>
    let hasVariableData4 = _prefix "hasVariableData4"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData5"></see>
    /// </summary>
    let hasVariableData5 = _prefix "hasVariableData5"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData6"></see>
    /// </summary>
    let hasVariableData6 = _prefix "hasVariableData6"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData7"></see>
    /// </summary>
    let hasVariableData7 = _prefix "hasVariableData7"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData8"></see>
    /// </summary>
    let hasVariableData8 = _prefix "hasVariableData8"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW1"></see>
    /// </summary>
    let hasVariableSW1 = _prefix "hasVariableSW1"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW2"></see>
    /// </summary>
    let hasVariableSW2 = _prefix "hasVariableSW2"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW3"></see>
    /// </summary>
    let hasVariableSW3 = _prefix "hasVariableSW3"
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW4"></see>
    /// </summary>
    let hasVariableSW4 = _prefix "hasVariableSW4"
    /// <summary>
    /// The ID of the SWeML system
    /// <see href="https://w3id.org/semsys/ns/swemls#has_ID"></see></summary>
    let has_ID = _prefix "has_ID"
    /// <summary>
    /// Link of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#has_link"></see></summary>
    let has_link = _prefix "has_link"
    /// <summary>
    /// The title of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#has_title"></see></summary>
    let has_title = _prefix "has_title"
    /// <summary>
    /// Presence of documentation on used infrastructure: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#infrastructure"></see></summary>
    let infrastructure = _prefix "infrastructure"
    /// <summary>
    /// Linking the paper type to the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#isOfType"></see></summary>
    let isOfType = _prefix "isOfType"
    /// <summary>
    /// Presence of documentation on used parameters: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#parameters"></see></summary>
    let parameters = _prefix "parameters"
    /// <summary>
    /// Presence of documentation on performed processing steps, such as
    /// pre-processing, cross-validation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#process_steps"></see></summary>
    let process_steps = _prefix "process_steps"
    /// <summary>
    /// Presence of input/output data provenance collection: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#provenance_support"></see></summary>
    let provenance_support = _prefix "provenance_support"
    /// <summary>
    /// Linking the system reported in the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#reports"></see></summary>
    let reports = _prefix "reports"
    /// <summary>
    /// Presence of documentation on used software and libraries: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#software"></see></summary>
    let software = _prefix "software"
    /// <summary>
    /// Short summary of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// The venue where the paper is published
    /// <see href="https://w3id.org/semsys/ns/swemls#venue"></see></summary>
    let venue = _prefix "venue"
    /// <summary>
    /// Year in which the paper is published
    /// <see href="https://w3id.org/semsys/ns/swemls#year"></see></summary>
    let year = _prefix "year"
