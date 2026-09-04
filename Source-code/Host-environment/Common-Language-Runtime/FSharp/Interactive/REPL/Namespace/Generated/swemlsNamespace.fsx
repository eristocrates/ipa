#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swemls =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/semsys/ns/swemls#" "swemls"

    /// <summary>
    ///   <para>rdfs:label : Application Domain^^xsd:string</para>
    ///   <para>rdfs:comment : The application domain in which the SWeML systems solve tasks (e.g. Chemistry, Legal)^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#ApplicationDomain">swemls:ApplicationDomain</a>
    /// </summary>
    let ApplicationDomain = _prefixId.prefix "ApplicationDomain"
    /// <summary>
    ///   <para>rdfs:label : Area^^xsd:string</para>
    ///   <para>rdfs:comment : Positioning of the Paper in relation to research araeas e.g. Explainable AI or Semantic Web Mining^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Area">swemls:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : Atomic Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Basic pattern type: a single algorithmic module consumes a single input^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Atomic-Pattern">swemls:Atomic-Pattern</a>
    /// </summary>
    let Atomic_Pattern = _prefixId.prefix "Atomic-Pattern"
    let Australia = _prefixId.prefix "Australia"
    let Austria = _prefixId.prefix "Austria"
    let Belgium = _prefixId.prefix "Belgium"
    let Brazil = _prefixId.prefix "Brazil"
    let Bulgaria = _prefixId.prefix "Bulgaria"
    let Canada = _prefixId.prefix "Canada"
    let China = _prefixId.prefix "China"
    let Colombia = _prefixId.prefix "Colombia"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <para>rdfs:comment : Country to which authors describing the SWeML systems in their paper are affiliated to^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Country">swemls:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Data^^xsd:string</para>
    ///   <para>rdfs:comment : Facts and statistics collected together and used as a basis for reasoning, discussion or calculation.^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Data">swemls:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    let Denmark = _prefixId.prefix "Denmark"
    /// <summary>
    ///   <para>rdfs:label : Documentation^^xsd:string</para>
    ///   <para>rdfs:comment : Documenation characteristics e.g. used dataset, training parameters, evaluation metrics^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Documentation">swemls:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    let Egypt = _prefixId.prefix "Egypt"
    let Finland = _prefixId.prefix "Finland"
    let France = _prefixId.prefix "France"
    /// <summary>
    ///   <para>rdfs:label : Fusion Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Basic pattern type: a single algorithmic module consumes more than one input^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Fusion-Pattern">swemls:Fusion-Pattern</a>
    /// </summary>
    let Fusion_Pattern = _prefixId.prefix "Fusion-Pattern"
    let Germany = _prefixId.prefix "Germany"
    let Greece = _prefixId.prefix "Greece"
    let Hong_Kong = _prefixId.prefix "Hong_Kong"
    /// <summary>
    ///   <para>rdfs:label : I-Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Advanced pattern type: a chain of Atomic Patterns^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#I-Pattern">swemls:I-Pattern</a>
    /// </summary>
    let I_Pattern = _prefixId.prefix "I-Pattern"
    let India = _prefixId.prefix "India"
    let Indonesia = _prefixId.prefix "Indonesia"
    /// <summary>
    ///   <para>rdfs:label : Instance^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Instance">swemls:Instance</a>
    /// </summary>
    let Instance = _prefixId.prefix "Instance"
    let Iran = _prefixId.prefix "Iran"
    let Ireland = _prefixId.prefix "Ireland"
    let Italy = _prefixId.prefix "Italy"
    let Italy_and_UK = _prefixId.prefix "Italy_and_UK"
    let Jamaica = _prefixId.prefix "Jamaica"
    let Japan = _prefixId.prefix "Japan"

    /// <summary>
    ///   <para>rdfs:label : KR Component^^xsd:string</para>
    ///   <para>rdfs:comment : A Knowledge Representation component^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent">swemls:KnowledgeRepresentationComponent</a>
    /// </summary>
    let KnowledgeRepresentationComponent =
        _prefixId.prefix "KnowledgeRepresentationComponent"

    let Korea = _prefixId.prefix "Korea"
    let Kosovo = _prefixId.prefix "Kosovo"
    /// <summary>
    ///   <para>rdfs:label : M-Pattern^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#M-Pattern">swemls:M-Pattern</a>
    /// </summary>
    let M_Pattern = _prefixId.prefix "M-Pattern"
    /// <summary>
    ///   <para>rdfs:label : ML Component^^xsd:string</para>
    ///   <para>rdfs:comment : A Machine Learning component^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#MachineLearningComponent">swemls:MachineLearningComponent</a>
    /// </summary>
    let MachineLearningComponent = _prefixId.prefix "MachineLearningComponent"
    let Mexico = _prefixId.prefix "Mexico"
    let Missing_Info = _prefixId.prefix "Missing_Info"
    /// <summary>
    ///   <para>rdfs:label : Model^^xsd:string</para>
    ///   <para>rdfs:comment : Models used in the SWeML systems^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Model">swemls:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    let Morocco = _prefixId.prefix "Morocco"
    let Netherlands = _prefixId.prefix "Netherlands"
    let New_Zealand = _prefixId.prefix "New_Zealand"
    let Norway = _prefixId.prefix "Norway"
    /// <summary>
    ///   <para>rdfs:label : Other Patterns^^xsd:string</para>
    ///   <para>rdfs:comment : Other Patterns that do not fit in any other category^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Other-Pattern">swemls:Other-Pattern</a>
    /// </summary>
    let Other_Pattern = _prefixId.prefix "Other-Pattern"
    let Pakistan = _prefixId.prefix "Pakistan"
    let Palestine = _prefixId.prefix "Palestine"
    /// <summary>
    ///   <para>rdfs:label : Paper^^xsd:string</para>
    ///   <para>rdfs:comment : Paper in which the SWeML system is described^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Paper">swemls:Paper</a>
    /// </summary>
    let Paper = _prefixId.prefix "Paper"
    /// <summary>
    ///   <para>rdfs:label : Paper Type^^xsd:string</para>
    ///   <para>rdfs:comment : Paper type, e.g. Workshop or Conference paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#PaperType">swemls:PaperType</a>
    /// </summary>
    let PaperType = _prefixId.prefix "PaperType"
    /// <summary>
    ///   <para>rdfs:label : Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Patterns describing the SWeMLs flow^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Pattern">swemls:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    let Poland = _prefixId.prefix "Poland"
    let Portual = _prefixId.prefix "Portual"
    let Portugal = _prefixId.prefix "Portugal"
    /// <summary>
    ///   <para>rdfs:label : Processing Engine^^xsd:string</para>
    ///   <para>rdfs:comment : Processing engine, that processes semantic web resources e.g.  SPARQL query engine, reasoner^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#ProcessingEngine">swemls:ProcessingEngine</a>
    /// </summary>
    let ProcessingEngine = _prefixId.prefix "ProcessingEngine"
    let Republic_of_Korea = _prefixId.prefix "Republic_of_Korea"
    /// <summary>
    ///   <para>rdfs:label : Symbol Formalism^^xsd:string</para>
    ///   <para>rdfs:comment : Formalism of the semantic web resource data^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#ResourceFormalism">swemls:ResourceFormalism</a>
    /// </summary>
    let ResourceFormalism = _prefixId.prefix "ResourceFormalism"
    /// <summary>
    ///   <para>rdfs:label : Resource Size^^xsd:string</para>
    ///   <para>rdfs:comment : Size of the semantic web resource(s) in triples^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#ResourceSize">swemls:ResourceSize</a>
    /// </summary>
    let ResourceSize = _prefixId.prefix "ResourceSize"
    /// <summary>
    ///   <para>rdfs:label : Resource Type^^xsd:string</para>
    ///   <para>rdfs:comment : Resource type of the semantic web resources resource, e.g. ontology, queries^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#ResourceType">swemls:ResourceType</a>
    /// </summary>
    let ResourceType = _prefixId.prefix "ResourceType"
    let Romania = _prefixId.prefix "Romania"
    let Russia = _prefixId.prefix "Russia"
    let Saudi_Arabia = _prefixId.prefix "Saudi_Arabia"
    let Saudi_Ariabia = _prefixId.prefix "Saudi_Ariabia"
    let Scotland = _prefixId.prefix "Scotland"
    /// <summary>
    ///   <para>rdfs:label : Semantic Model^^xsd:string</para>
    ///   <para>rdfs:comment : Deductive Model^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#SemanticModel">swemls:SemanticModel</a>
    /// </summary>
    let SemanticModel = _prefixId.prefix "SemanticModel"
    /// <summary>
    ///   <para>rdfs:label : Semantic Web Resource^^xsd:string</para>
    ///   <para>rdfs:comment : Semantic entities or relations^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#SemanticWebResource">swemls:SemanticWebResource</a>
    /// </summary>
    let SemanticWebResource = _prefixId.prefix "SemanticWebResource"
    let Singapore = _prefixId.prefix "Singapore"
    let Slovenia = _prefixId.prefix "Slovenia"
    let South_Korea = _prefixId.prefix "South_Korea"
    let Spain = _prefixId.prefix "Spain"
    let Sri_Lanka = _prefixId.prefix "Sri_Lanka"
    /// <summary>
    ///   <para>rdfs:label : Statistical Model^^xsd:string</para>
    ///   <para>rdfs:comment : Inductive Model^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#StatisticalModel">swemls:StatisticalModel</a>
    /// </summary>
    let StatisticalModel = _prefixId.prefix "StatisticalModel"
    let Sudan = _prefixId.prefix "Sudan"
    let Sweden = _prefixId.prefix "Sweden"
    let Switzerland = _prefixId.prefix "Switzerland"
    /// <summary>
    ///   <para>rdfs:label : Symbol^^xsd:string</para>
    ///   <para>rdfs:comment : A representation of symbolic data such as semantic entities or relations.^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Symbol">swemls:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>rdfs:label : Symbol Usage^^xsd:string</para>
    ///   <para>rdfs:comment : Type of usage of the semantic web resource^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#SymbolUsage">swemls:SymbolUsage</a>
    /// </summary>
    let SymbolUsage = _prefixId.prefix "SymbolUsage"
    /// <summary>
    ///   <para>rdfs:label : System^^xsd:string</para>
    ///   <para>rdfs:comment : SWeML System^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#System">swemls:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : System Component^^xsd:string</para>
    ///   <para>rdfs:comment : One component of the system^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#SystemComponent">swemls:SystemComponent</a>
    /// </summary>
    let SystemComponent = _prefixId.prefix "SystemComponent"
    /// <summary>
    ///   <para>rdfs:label : System Maturity^^xsd:string</para>
    ///   <para>rdfs:comment : Maturity of the overall SWeML system^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#SystemMaturity">swemls:SystemMaturity</a>
    /// </summary>
    let SystemMaturity = _prefixId.prefix "SystemMaturity"
    /// <summary>
    ///   <para>rdfs:label : T-Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Advanded pattern type: a chain of Atomic and Fusion Patterns^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#T-Pattern">swemls:T-Pattern</a>
    /// </summary>
    let T_Pattern = _prefixId.prefix "T-Pattern"
    let Taiwan = _prefixId.prefix "Taiwan"
    /// <summary>
    ///   <para>rdfs:label : Task^^xsd:string</para>
    ///   <para>rdfs:comment : Task that the SWeML system supposed to solve^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Task">swemls:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    let Thailand = _prefixId.prefix "Thailand"
    let The_Netherlands = _prefixId.prefix "The_Netherlands"
    /// <summary>
    ///   <para>rdfs:label : Training Type^^xsd:string</para>
    ///   <para>rdfs:comment : Training type of the ML model(s)^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#TrainingType">swemls:TrainingType</a>
    /// </summary>
    let TrainingType = _prefixId.prefix "TrainingType"
    let Tunisia = _prefixId.prefix "Tunisia"
    let Turkey = _prefixId.prefix "Turkey"
    let UAE = _prefixId.prefix "UAE"
    let UK = _prefixId.prefix "UK"
    let USA = _prefixId.prefix "USA"
    let United_Kingdom = _prefixId.prefix "United_Kingdom"
    let Vietnam = _prefixId.prefix "Vietnam"
    let Wales = _prefixId.prefix "Wales"
    /// <summary>
    ///   <para>rdfs:label : X-Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#X-Pattern">swemls:X-Pattern</a>
    /// </summary>
    let X_Pattern = _prefixId.prefix "X-Pattern"
    /// <summary>
    ///   <para>rdfs:label : Y-Pattern^^xsd:string</para>
    ///   <para>rdfs:comment : Advanced pattern type: combination of two (or more) Atomic Patterns via a Fusion Pattern^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#Y-Pattern">swemls:Y-Pattern</a>
    /// </summary>
    let Y_Pattern = _prefixId.prefix "Y-Pattern"
    /// <summary>
    ///   <para>rdfs:label : author country^^xsd:string</para>
    ///   <para>rdfs:comment : Country to which authors describing the SWeML systems in their paper are affiliated to^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#author_country">swemls:author_country</a>
    /// </summary>
    let author_country = _prefixId.prefix "author_country"
    /// <summary>
    ///   <para>rdfs:label : component input^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#componentInput">swemls:componentInput</a>
    /// </summary>
    let componentInput = _prefixId.prefix "componentInput"
    /// <summary>
    ///   <para>rdfs:label : component model^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the system with component models^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#componentModel">swemls:componentModel</a>
    /// </summary>
    let componentModel = _prefixId.prefix "componentModel"
    /// <summary>
    ///   <para>rdfs:label : component output^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#componentOutput">swemls:componentOutput</a>
    /// </summary>
    let componentOutput = _prefixId.prefix "componentOutput"
    /// <summary>
    ///   <para>rdfs:label : evaluation data^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used data sets: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#evaluation_data">swemls:evaluation_data</a>
    /// </summary>
    let evaluation_data = _prefixId.prefix "evaluation_data"
    /// <summary>
    ///   <para>rdfs:label : evaluation data split^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used training, development and test set
    /// used in evaluation: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#evaluation_data_split">swemls:evaluation_data_split</a>
    /// </summary>
    let evaluation_data_split = _prefixId.prefix "evaluation_data_split"
    /// <summary>
    ///   <para>rdfs:label : evaluation metrics^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used metrics in evaluation: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#evaluation_metrics">swemls:evaluation_metrics</a>
    /// </summary>
    let evaluation_metrics = _prefixId.prefix "evaluation_metrics"
    /// <summary>
    ///   <para>rdfs:label : has application domain^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the system with the application domain it is working in^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasApplicationDomain">swemls:hasApplicationDomain</a>
    /// </summary>
    let hasApplicationDomain = _prefixId.prefix "hasApplicationDomain"
    /// <summary>
    ///   <para>rdfs:label : has area^^xsd:string</para>
    ///   <para>rdfs:comment : Linking a SWeML system with a research area it is associated with^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasArea">swemls:hasArea</a>
    /// </summary>
    let hasArea = _prefixId.prefix "hasArea"
    /// <summary>
    ///   <para>rdfs:label : has authors country^^xsd:string</para>
    ///   <para>rdfs:comment : Linking a paper with the countries of author's affiliations^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasAuthorsCountry">swemls:hasAuthorsCountry</a>
    /// </summary>
    let hasAuthorsCountry = _prefixId.prefix "hasAuthorsCountry"
    /// <summary>
    ///   <para>rdfs:label : has corresponding pattern^^xsd:string</para>
    ///   <para>rdfs:comment : A SWeML system has a corresponding pattern^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern">swemls:hasCorrespondingPattern</a>
    /// </summary>
    let hasCorrespondingPattern = _prefixId.prefix "hasCorrespondingPattern"
    /// <summary>
    ///   <para>rdfs:label : has corresponding pattern step^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the corresponding step of a pattern workflow with a specific system component^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep">swemls:hasCorrespondingPatternStep</a>
    /// </summary>
    let hasCorrespondingPatternStep = _prefixId.prefix "hasCorrespondingPatternStep"
    /// <summary>
    ///   <para>rdfs:label : has data I/O^^xsd:string</para>
    ///   <para>rdfs:comment : Data as in- output(s) in the workflow^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasDataIO">swemls:hasDataIO</a>
    /// </summary>
    let hasDataIO = _prefixId.prefix "hasDataIO"
    /// <summary>
    ///   <para>rdfs:label : has documentation^^xsd:string</para>
    ///   <para>rdfs:comment : System has documentation providing details about e.g. training steps or split, used datasets and evaluation metrics^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasDocumentation">swemls:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>rdfs:label : has keyword^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords assigned to the publication by the authors^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasKeyword">swemls:hasKeyword</a>
    /// </summary>
    let hasKeyword = _prefixId.prefix "hasKeyword"
    /// <summary>
    ///   <para>rdfs:label : has model^^xsd:string</para>
    ///   <para>rdfs:comment : A SWeML system can have one or more models^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasModel">swemls:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : has processing engine^^xsd:string</para>
    ///   <para>rdfs:comment : SWeMLs can have one or more processing engines^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasProcessingEngine">swemls:hasProcessingEngine</a>
    /// </summary>
    let hasProcessingEngine = _prefixId.prefix "hasProcessingEngine"
    /// <summary>
    ///   <para>rdfs:label : Resource Formalism^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the symbol formalism with the semantic web resource data^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasResourceFormalism">swemls:hasResourceFormalism</a>
    /// </summary>
    let hasResourceFormalism = _prefixId.prefix "hasResourceFormalism"
    /// <summary>
    ///   <para>rdfs:label : resource size^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the semantic web resource with the resource size^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasResourceSize">swemls:hasResourceSize</a>
    /// </summary>
    let hasResourceSize = _prefixId.prefix "hasResourceSize"
    /// <summary>
    ///   <para>rdfs:label : resource type^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the semantic web resource with the resource type^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasResourceType">swemls:hasResourceType</a>
    /// </summary>
    let hasResourceType = _prefixId.prefix "hasResourceType"
    /// <summary>
    ///   <para>rdfs:label : has statistical model^^xsd:string</para>
    ///   <para>rdfs:comment : A SWeML system linking to at least one statistical model^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStatisticalModel">swemls:hasStatisticalModel</a>
    /// </summary>
    let hasStatisticalModel = _prefixId.prefix "hasStatisticalModel"
    /// <summary>
    ///   <para>rdfs:label : has KR step^^xsd:string</para>
    ///   <para>rdfs:comment : Linking SWeMLs to Knowledge Representation component(s) in different steps of the workflow^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepKR">swemls:hasStepKR</a>
    /// </summary>
    let hasStepKR = _prefixId.prefix "hasStepKR"
    /// <summary>
    ///   <para>rdfs:label : has KR step 1^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepKR1">swemls:hasStepKR1</a>
    /// </summary>
    let hasStepKR1 = _prefixId.prefix "hasStepKR1"
    /// <summary>
    ///   <para>rdfs:label : has ML step^^xsd:string</para>
    ///   <para>rdfs:comment : Linking SWeMLs to Machine Learning component(s) in different steps of the workflow^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML">swemls:hasStepML</a>
    /// </summary>
    let hasStepML = _prefixId.prefix "hasStepML"
    /// <summary>
    ///   <para>rdfs:label : has ML step 1^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML1">swemls:hasStepML1</a>
    /// </summary>
    let hasStepML1 = _prefixId.prefix "hasStepML1"
    /// <summary>
    ///   <para>rdfs:label : has ML step 2^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML2">swemls:hasStepML2</a>
    /// </summary>
    let hasStepML2 = _prefixId.prefix "hasStepML2"
    /// <summary>
    ///   <para>rdfs:label : has ML step 3^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML3">swemls:hasStepML3</a>
    /// </summary>
    let hasStepML3 = _prefixId.prefix "hasStepML3"
    /// <summary>
    ///   <para>rdfs:label : has ML step 4^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML4">swemls:hasStepML4</a>
    /// </summary>
    let hasStepML4 = _prefixId.prefix "hasStepML4"
    /// <summary>
    ///   <para>rdfs:label : has ML step 5^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasStepML5">swemls:hasStepML5</a>
    /// </summary>
    let hasStepML5 = _prefixId.prefix "hasStepML5"
    /// <summary>
    ///   <para>rdfs:label : has symbol I/O^^xsd:string</para>
    ///   <para>rdfs:comment : Symbol as in- output(s) in the workflow^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasSymbolIO">swemls:hasSymbolIO</a>
    /// </summary>
    let hasSymbolIO = _prefixId.prefix "hasSymbolIO"
    /// <summary>
    ///   <para>rdfs:label : has symbol usage^^xsd:string</para>
    ///   <para>rdfs:comment : Linking system to symbol usage^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasSymbolUsage">swemls:hasSymbolUsage</a>
    /// </summary>
    let hasSymbolUsage = _prefixId.prefix "hasSymbolUsage"
    /// <summary>
    ///   <para>rdfs:label : has system component^^xsd:string</para>
    ///   <para>rdfs:comment : SWeMLs can have one or more system components^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasSystemComponent">swemls:hasSystemComponent</a>
    /// </summary>
    let hasSystemComponent = _prefixId.prefix "hasSystemComponent"
    /// <summary>
    ///   <para>rdfs:label : has system I/O^^xsd:string</para>
    ///   <para>rdfs:comment : Describes in- and outputs to SWeML systems^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasSystemIO">swemls:hasSystemIO</a>
    /// </summary>
    let hasSystemIO = _prefixId.prefix "hasSystemIO"
    /// <summary>
    ///   <para>rdfs:label : has system maturity^^xsd:string</para>
    ///   <para>rdfs:comment : System has a certain maturity according to different characteristics (stability, UI)^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasSystemMaturity">swemls:hasSystemMaturity</a>
    /// </summary>
    let hasSystemMaturity = _prefixId.prefix "hasSystemMaturity"
    /// <summary>
    ///   <para>rdfs:label : has task^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the system to the task it is solving^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasTask">swemls:hasTask</a>
    /// </summary>
    let hasTask = _prefixId.prefix "hasTask"
    /// <summary>
    ///   <para>rdfs:label : has training type^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the training type of the system^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasTrainingType">swemls:hasTrainingType</a>
    /// </summary>
    let hasTrainingType = _prefixId.prefix "hasTrainingType"
    /// <summary>
    ///   <para>rdfs:label : has variable data 1^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData1">swemls:hasVariableData1</a>
    /// </summary>
    let hasVariableData1 = _prefixId.prefix "hasVariableData1"
    /// <summary>
    ///   <para>rdfs:label : has variable data 2^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData2">swemls:hasVariableData2</a>
    /// </summary>
    let hasVariableData2 = _prefixId.prefix "hasVariableData2"
    /// <summary>
    ///   <para>rdfs:label : has variable data 3^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData3">swemls:hasVariableData3</a>
    /// </summary>
    let hasVariableData3 = _prefixId.prefix "hasVariableData3"
    /// <summary>
    ///   <para>rdfs:label : has variable data 4^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData4">swemls:hasVariableData4</a>
    /// </summary>
    let hasVariableData4 = _prefixId.prefix "hasVariableData4"
    /// <summary>
    ///   <para>rdfs:label : has variable data 5^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData5">swemls:hasVariableData5</a>
    /// </summary>
    let hasVariableData5 = _prefixId.prefix "hasVariableData5"
    /// <summary>
    ///   <para>rdfs:label : has variable data 6^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData6">swemls:hasVariableData6</a>
    /// </summary>
    let hasVariableData6 = _prefixId.prefix "hasVariableData6"
    /// <summary>
    ///   <para>rdfs:label : has variable data 7^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData7">swemls:hasVariableData7</a>
    /// </summary>
    let hasVariableData7 = _prefixId.prefix "hasVariableData7"
    /// <summary>
    ///   <para>rdfs:label : has variable data 8^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableData8">swemls:hasVariableData8</a>
    /// </summary>
    let hasVariableData8 = _prefixId.prefix "hasVariableData8"
    /// <summary>
    ///   <para>rdfs:label : has variable SW 1^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableSW1">swemls:hasVariableSW1</a>
    /// </summary>
    let hasVariableSW1 = _prefixId.prefix "hasVariableSW1"
    /// <summary>
    ///   <para>rdfs:label : has variable SW 2^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableSW2">swemls:hasVariableSW2</a>
    /// </summary>
    let hasVariableSW2 = _prefixId.prefix "hasVariableSW2"
    /// <summary>
    ///   <para>rdfs:label : has variable SW 3^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableSW3">swemls:hasVariableSW3</a>
    /// </summary>
    let hasVariableSW3 = _prefixId.prefix "hasVariableSW3"
    /// <summary>
    ///   <para>rdfs:label : has variable SW 4^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#hasVariableSW4">swemls:hasVariableSW4</a>
    /// </summary>
    let hasVariableSW4 = _prefixId.prefix "hasVariableSW4"
    /// <summary>
    ///   <para>rdfs:label : has id^^xsd:string</para>
    ///   <para>rdfs:comment : The ID of the SWeML system^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#has_ID">swemls:has_ID</a>
    /// </summary>
    let has_ID = _prefixId.prefix "has_ID"
    /// <summary>
    ///   <para>rdfs:label : has link^^xsd:string</para>
    ///   <para>rdfs:comment : Link of the paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#has_link">swemls:has_link</a>
    /// </summary>
    let has_link = _prefixId.prefix "has_link"
    /// <summary>
    ///   <para>rdfs:label : has title^^xsd:string</para>
    ///   <para>rdfs:comment : The title of the paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#has_title">swemls:has_title</a>
    /// </summary>
    let has_title = _prefixId.prefix "has_title"
    /// <summary>
    ///   <para>rdfs:label : infrastructure^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used infrastructure: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#infrastructure">swemls:infrastructure</a>
    /// </summary>
    let infrastructure = _prefixId.prefix "infrastructure"
    /// <summary>
    ///   <para>rdfs:label : is of type^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the paper type to the paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#isOfType">swemls:isOfType</a>
    /// </summary>
    let isOfType = _prefixId.prefix "isOfType"
    /// <summary>
    ///   <para>rdfs:label : parameters^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used parameters: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#parameters">swemls:parameters</a>
    /// </summary>
    let parameters = _prefixId.prefix "parameters"
    /// <summary>
    ///   <para>rdfs:label : process steps^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on performed processing steps, such as
    /// pre-processing, cross-validation: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#process_steps">swemls:process_steps</a>
    /// </summary>
    let process_steps = _prefixId.prefix "process_steps"
    /// <summary>
    ///   <para>rdfs:label : provenance support^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of input/output data provenance collection: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#provenance_support">swemls:provenance_support</a>
    /// </summary>
    let provenance_support = _prefixId.prefix "provenance_support"
    /// <summary>
    ///   <para>rdfs:label : reports^^xsd:string</para>
    ///   <para>rdfs:comment : Linking the system reported in the paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#reports">swemls:reports</a>
    /// </summary>
    let reports = _prefixId.prefix "reports"
    /// <summary>
    ///   <para>rdfs:label : software^^xsd:string</para>
    ///   <para>rdfs:comment : Presence of documentation on used software and libraries: yes, no^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#software">swemls:software</a>
    /// </summary>
    let software = _prefixId.prefix "software"
    /// <summary>
    ///   <para>rdfs:label : summary^^xsd:string</para>
    ///   <para>rdfs:comment : Short summary of the paper^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#summary">swemls:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:label : venue^^xsd:string</para>
    ///   <para>rdfs:comment : The venue where the paper is published^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#venue">swemls:venue</a>
    /// </summary>
    let venue = _prefixId.prefix "venue"
    /// <summary>
    ///   <para>rdfs:label : year^^xsd:string</para>
    ///   <para>rdfs:comment : Year in which the paper is published^^xsd:string</para>
    ///   <a href="https://w3id.org/semsys/ns/swemls#year">swemls:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
