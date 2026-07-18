namespace https.w3id.org.semsys.ns.swemls.hash

open DoxAletheia.Rdf_Vocabulary

module swemls =
    let _namespace_name = "https://w3id.org/semsys/ns/swemls#"
    /// <summary>
    /// Positioning of the Paper in relation to research araeas e.g. Explainable AI or Semantic Web Mining
    /// <see href="https://w3id.org/semsys/ns/swemls#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    /// The application domain in which the SWeML systems solve tasks (e.g. Chemistry, Legal)
    /// <see href="https://w3id.org/semsys/ns/swemls#ApplicationDomain"></see></summary>
    let ApplicationDomain =
        Namespaced_IRI.parse _namespace_name "ApplicationDomain" |> NamespacedName

    /// <summary>
    /// Maturity of the overall SWeML system
    /// <see href="https://w3id.org/semsys/ns/swemls#SystemMaturity"></see></summary>
    let SystemMaturity =
        Namespaced_IRI.parse _namespace_name "SystemMaturity" |> NamespacedName

    /// <summary>
    /// Paper type, e.g. Workshop or Conference paper
    /// <see href="https://w3id.org/semsys/ns/swemls#PaperType"></see></summary>
    let PaperType = Namespaced_IRI.parse _namespace_name "PaperType" |> NamespacedName

    /// <summary>
    /// Basic pattern type: a single algorithmic module consumes a single input
    /// <see href="https://w3id.org/semsys/ns/swemls#Atomic-Pattern"></see></summary>
    let ``Atomic-Pattern`` =
        Namespaced_IRI.parse _namespace_name "Atomic-Pattern" |> NamespacedName

    /// <summary>
    /// Basic pattern type: a single algorithmic module consumes more than one input
    /// <see href="https://w3id.org/semsys/ns/swemls#Fusion-Pattern"></see></summary>
    let ``Fusion-Pattern`` =
        Namespaced_IRI.parse _namespace_name "Fusion-Pattern" |> NamespacedName

    /// <summary>
    /// Advanced pattern type: a chain of Atomic Patterns
    /// <see href="https://w3id.org/semsys/ns/swemls#I-Pattern"></see></summary>
    let ``I-Pattern`` =
        Namespaced_IRI.parse _namespace_name "I-Pattern" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#M-Pattern"></see>
    /// </summary>
    let ``M-Pattern`` =
        Namespaced_IRI.parse _namespace_name "M-Pattern" |> NamespacedName

    /// <summary>
    /// Patterns describing the SWeMLs flow
    /// <see href="https://w3id.org/semsys/ns/swemls#Pattern"></see></summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName

    /// <summary>
    /// Other Patterns that do not fit in any other category
    /// <see href="https://w3id.org/semsys/ns/swemls#Other-Pattern"></see></summary>
    let ``Other-Pattern`` =
        Namespaced_IRI.parse _namespace_name "Other-Pattern" |> NamespacedName

    /// <summary>
    /// Advanded pattern type: a chain of Atomic and Fusion Patterns
    /// <see href="https://w3id.org/semsys/ns/swemls#T-Pattern"></see></summary>
    let ``T-Pattern`` =
        Namespaced_IRI.parse _namespace_name "T-Pattern" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#X-Pattern"></see>
    /// </summary>
    let ``X-Pattern`` =
        Namespaced_IRI.parse _namespace_name "X-Pattern" |> NamespacedName

    /// <summary>
    /// Advanced pattern type: combination of two (or more) Atomic Patterns via a Fusion Pattern
    /// <see href="https://w3id.org/semsys/ns/swemls#Y-Pattern"></see></summary>
    let ``Y-Pattern`` =
        Namespaced_IRI.parse _namespace_name "Y-Pattern" |> NamespacedName

    /// <summary>
    /// Processing engine, that processes semantic web resources e.g.  SPARQL query engine, reasoner
    /// <see href="https://w3id.org/semsys/ns/swemls#ProcessingEngine"></see></summary>
    let ProcessingEngine =
        Namespaced_IRI.parse _namespace_name "ProcessingEngine" |> NamespacedName

    /// <summary>
    /// Semantic entities or relations
    /// <see href="https://w3id.org/semsys/ns/swemls#SemanticWebResource"></see></summary>
    let SemanticWebResource =
        Namespaced_IRI.parse _namespace_name "SemanticWebResource" |> NamespacedName

    /// <summary>
    /// Linking the symbol formalism with the semantic web resource data
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceFormalism"></see></summary>
    let hasResourceFormalism =
        Namespaced_IRI.parse _namespace_name "hasResourceFormalism" |> NamespacedName

    /// <summary>
    /// Linking the semantic web resource with the resource size
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceSize"></see></summary>
    let hasResourceSize =
        Namespaced_IRI.parse _namespace_name "hasResourceSize" |> NamespacedName

    /// <summary>
    /// Linking the semantic web resource with the resource type
    /// <see href="https://w3id.org/semsys/ns/swemls#hasResourceType"></see></summary>
    let hasResourceType =
        Namespaced_IRI.parse _namespace_name "hasResourceType" |> NamespacedName

    /// <summary>
    /// Formalism of the semantic web resource data
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceFormalism"></see></summary>
    let ResourceFormalism =
        Namespaced_IRI.parse _namespace_name "ResourceFormalism" |> NamespacedName

    /// <summary>
    /// Size of the semantic web resource(s) in triples
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceSize"></see></summary>
    let ResourceSize =
        Namespaced_IRI.parse _namespace_name "ResourceSize" |> NamespacedName

    /// <summary>
    /// Resource type of the semantic web resources resource, e.g. ontology, queries
    /// <see href="https://w3id.org/semsys/ns/swemls#ResourceType"></see></summary>
    let ResourceType =
        Namespaced_IRI.parse _namespace_name "ResourceType" |> NamespacedName

    /// <summary>
    /// Inductive Model
    /// <see href="https://w3id.org/semsys/ns/swemls#StatisticalModel"></see></summary>
    let StatisticalModel =
        Namespaced_IRI.parse _namespace_name "StatisticalModel" |> NamespacedName

    /// <summary>
    /// Type of usage of the semantic web resource
    /// <see href="https://w3id.org/semsys/ns/swemls#SymbolUsage"></see></summary>
    let SymbolUsage =
        Namespaced_IRI.parse _namespace_name "SymbolUsage" |> NamespacedName

    /// <summary>
    /// Task that the SWeML system supposed to solve
    /// <see href="https://w3id.org/semsys/ns/swemls#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// Training type of the ML model(s)
    /// <see href="https://w3id.org/semsys/ns/swemls#TrainingType"></see></summary>
    let TrainingType =
        Namespaced_IRI.parse _namespace_name "TrainingType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Australia"></see>
    /// </summary>
    let Australia = Namespaced_IRI.parse _namespace_name "Australia" |> NamespacedName
    /// <summary>
    /// Country to which authors describing the SWeML systems in their paper are affiliated to
    /// <see href="https://w3id.org/semsys/ns/swemls#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Austria"></see>
    /// </summary>
    let Austria = Namespaced_IRI.parse _namespace_name "Austria" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Belgium"></see>
    /// </summary>
    let Belgium = Namespaced_IRI.parse _namespace_name "Belgium" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Brazil"></see>
    /// </summary>
    let Brazil = Namespaced_IRI.parse _namespace_name "Brazil" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Bulgaria"></see>
    /// </summary>
    let Bulgaria = Namespaced_IRI.parse _namespace_name "Bulgaria" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Canada"></see>
    /// </summary>
    let Canada = Namespaced_IRI.parse _namespace_name "Canada" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#China"></see>
    /// </summary>
    let China = Namespaced_IRI.parse _namespace_name "China" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Colombia"></see>
    /// </summary>
    let Colombia = Namespaced_IRI.parse _namespace_name "Colombia" |> NamespacedName
    /// <summary>
    /// Facts and statistics collected together and used as a basis for reasoning, discussion or calculation.
    /// <see href="https://w3id.org/semsys/ns/swemls#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Instance"></see>
    /// </summary>
    let Instance = Namespaced_IRI.parse _namespace_name "Instance" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Denmark"></see>
    /// </summary>
    let Denmark = Namespaced_IRI.parse _namespace_name "Denmark" |> NamespacedName

    /// <summary>
    /// Documenation characteristics e.g. used dataset, training parameters, evaluation metrics
    /// <see href="https://w3id.org/semsys/ns/swemls#Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Egypt"></see>
    /// </summary>
    let Egypt = Namespaced_IRI.parse _namespace_name "Egypt" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Finland"></see>
    /// </summary>
    let Finland = Namespaced_IRI.parse _namespace_name "Finland" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#France"></see>
    /// </summary>
    let France = Namespaced_IRI.parse _namespace_name "France" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Germany"></see>
    /// </summary>
    let Germany = Namespaced_IRI.parse _namespace_name "Germany" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Greece"></see>
    /// </summary>
    let Greece = Namespaced_IRI.parse _namespace_name "Greece" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Hong_Kong"></see>
    /// </summary>
    let Hong_Kong = Namespaced_IRI.parse _namespace_name "Hong_Kong" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#India"></see>
    /// </summary>
    let India = Namespaced_IRI.parse _namespace_name "India" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Indonesia"></see>
    /// </summary>
    let Indonesia = Namespaced_IRI.parse _namespace_name "Indonesia" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Iran"></see>
    /// </summary>
    let Iran = Namespaced_IRI.parse _namespace_name "Iran" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Ireland"></see>
    /// </summary>
    let Ireland = Namespaced_IRI.parse _namespace_name "Ireland" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Italy"></see>
    /// </summary>
    let Italy = Namespaced_IRI.parse _namespace_name "Italy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Italy_and_UK"></see>
    /// </summary>
    let Italy_and_UK =
        Namespaced_IRI.parse _namespace_name "Italy_and_UK" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Jamaica"></see>
    /// </summary>
    let Jamaica = Namespaced_IRI.parse _namespace_name "Jamaica" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Japan"></see>
    /// </summary>
    let Japan = Namespaced_IRI.parse _namespace_name "Japan" |> NamespacedName

    /// <summary>
    /// A Knowledge Representation component
    /// <see href="https://w3id.org/semsys/ns/swemls#KnowledgeRepresentationComponent"></see></summary>
    let KnowledgeRepresentationComponent =
        Namespaced_IRI.parse _namespace_name "KnowledgeRepresentationComponent" |> NamespacedName

    /// <summary>
    /// One component of the system
    /// <see href="https://w3id.org/semsys/ns/swemls#SystemComponent"></see></summary>
    let SystemComponent =
        Namespaced_IRI.parse _namespace_name "SystemComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Korea"></see>
    /// </summary>
    let Korea = Namespaced_IRI.parse _namespace_name "Korea" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Kosovo"></see>
    /// </summary>
    let Kosovo = Namespaced_IRI.parse _namespace_name "Kosovo" |> NamespacedName

    /// <summary>
    /// A Machine Learning component
    /// <see href="https://w3id.org/semsys/ns/swemls#MachineLearningComponent"></see></summary>
    let MachineLearningComponent =
        Namespaced_IRI.parse _namespace_name "MachineLearningComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Mexico"></see>
    /// </summary>
    let Mexico = Namespaced_IRI.parse _namespace_name "Mexico" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Missing_Info"></see>
    /// </summary>
    let Missing_Info =
        Namespaced_IRI.parse _namespace_name "Missing_Info" |> NamespacedName

    /// <summary>
    /// Models used in the SWeML systems
    /// <see href="https://w3id.org/semsys/ns/swemls#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Morocco"></see>
    /// </summary>
    let Morocco = Namespaced_IRI.parse _namespace_name "Morocco" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Netherlands"></see>
    /// </summary>
    let Netherlands =
        Namespaced_IRI.parse _namespace_name "Netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#New_Zealand"></see>
    /// </summary>
    let New_Zealand =
        Namespaced_IRI.parse _namespace_name "New_Zealand" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Norway"></see>
    /// </summary>
    let Norway = Namespaced_IRI.parse _namespace_name "Norway" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Pakistan"></see>
    /// </summary>
    let Pakistan = Namespaced_IRI.parse _namespace_name "Pakistan" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Palestine"></see>
    /// </summary>
    let Palestine = Namespaced_IRI.parse _namespace_name "Palestine" |> NamespacedName
    /// <summary>
    /// Paper in which the SWeML system is described
    /// <see href="https://w3id.org/semsys/ns/swemls#Paper"></see></summary>
    let Paper = Namespaced_IRI.parse _namespace_name "Paper" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Poland"></see>
    /// </summary>
    let Poland = Namespaced_IRI.parse _namespace_name "Poland" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Portual"></see>
    /// </summary>
    let Portual = Namespaced_IRI.parse _namespace_name "Portual" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Portugal"></see>
    /// </summary>
    let Portugal = Namespaced_IRI.parse _namespace_name "Portugal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Republic_of_Korea"></see>
    /// </summary>
    let Republic_of_Korea =
        Namespaced_IRI.parse _namespace_name "Republic_of_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Romania"></see>
    /// </summary>
    let Romania = Namespaced_IRI.parse _namespace_name "Romania" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Russia"></see>
    /// </summary>
    let Russia = Namespaced_IRI.parse _namespace_name "Russia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Saudi_Arabia"></see>
    /// </summary>
    let Saudi_Arabia =
        Namespaced_IRI.parse _namespace_name "Saudi_Arabia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Saudi_Ariabia"></see>
    /// </summary>
    let Saudi_Ariabia =
        Namespaced_IRI.parse _namespace_name "Saudi_Ariabia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Scotland"></see>
    /// </summary>
    let Scotland = Namespaced_IRI.parse _namespace_name "Scotland" |> NamespacedName

    /// <summary>
    /// Deductive Model
    /// <see href="https://w3id.org/semsys/ns/swemls#SemanticModel"></see></summary>
    let SemanticModel =
        Namespaced_IRI.parse _namespace_name "SemanticModel" |> NamespacedName

    /// <summary>
    /// A representation of symbolic data such as semantic entities or relations.
    /// <see href="https://w3id.org/semsys/ns/swemls#Symbol"></see></summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Singapore"></see>
    /// </summary>
    let Singapore = Namespaced_IRI.parse _namespace_name "Singapore" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Slovenia"></see>
    /// </summary>
    let Slovenia = Namespaced_IRI.parse _namespace_name "Slovenia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#South_Korea"></see>
    /// </summary>
    let South_Korea =
        Namespaced_IRI.parse _namespace_name "South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Spain"></see>
    /// </summary>
    let Spain = Namespaced_IRI.parse _namespace_name "Spain" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sri_Lanka"></see>
    /// </summary>
    let Sri_Lanka = Namespaced_IRI.parse _namespace_name "Sri_Lanka" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sudan"></see>
    /// </summary>
    let Sudan = Namespaced_IRI.parse _namespace_name "Sudan" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Sweden"></see>
    /// </summary>
    let Sweden = Namespaced_IRI.parse _namespace_name "Sweden" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Switzerland"></see>
    /// </summary>
    let Switzerland =
        Namespaced_IRI.parse _namespace_name "Switzerland" |> NamespacedName

    /// <summary>
    /// SWeML System
    /// <see href="https://w3id.org/semsys/ns/swemls#System"></see></summary>
    let System = Namespaced_IRI.parse _namespace_name "System" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Taiwan"></see>
    /// </summary>
    let Taiwan = Namespaced_IRI.parse _namespace_name "Taiwan" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Thailand"></see>
    /// </summary>
    let Thailand = Namespaced_IRI.parse _namespace_name "Thailand" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#The_Netherlands"></see>
    /// </summary>
    let The_Netherlands =
        Namespaced_IRI.parse _namespace_name "The_Netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Tunisia"></see>
    /// </summary>
    let Tunisia = Namespaced_IRI.parse _namespace_name "Tunisia" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Turkey"></see>
    /// </summary>
    let Turkey = Namespaced_IRI.parse _namespace_name "Turkey" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#UAE"></see>
    /// </summary>
    let UAE = Namespaced_IRI.parse _namespace_name "UAE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#UK"></see>
    /// </summary>
    let UK = Namespaced_IRI.parse _namespace_name "UK" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#USA"></see>
    /// </summary>
    let USA = Namespaced_IRI.parse _namespace_name "USA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#United_Kingdom"></see>
    /// </summary>
    let United_Kingdom =
        Namespaced_IRI.parse _namespace_name "United_Kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Vietnam"></see>
    /// </summary>
    let Vietnam = Namespaced_IRI.parse _namespace_name "Vietnam" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#Wales"></see>
    /// </summary>
    let Wales = Namespaced_IRI.parse _namespace_name "Wales" |> NamespacedName

    /// <summary>
    /// Country to which authors describing the SWeML systems in their paper are affiliated to
    /// <see href="https://w3id.org/semsys/ns/swemls#author_country"></see></summary>
    let author_country =
        Namespaced_IRI.parse _namespace_name "author_country" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#componentInput"></see>
    /// </summary>
    let componentInput =
        Namespaced_IRI.parse _namespace_name "componentInput" |> NamespacedName

    /// <summary>
    /// Linking the system with component models
    /// <see href="https://w3id.org/semsys/ns/swemls#componentModel"></see></summary>
    let componentModel =
        Namespaced_IRI.parse _namespace_name "componentModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#componentOutput"></see>
    /// </summary>
    let componentOutput =
        Namespaced_IRI.parse _namespace_name "componentOutput" |> NamespacedName

    /// <summary>
    /// Presence of documentation on used data sets: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_data"></see></summary>
    let evaluation_data =
        Namespaced_IRI.parse _namespace_name "evaluation_data" |> NamespacedName

    /// <summary>
    /// Presence of documentation on used training, development and test set
    /// used in evaluation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_data_split"></see></summary>
    let evaluation_data_split =
        Namespaced_IRI.parse _namespace_name "evaluation_data_split" |> NamespacedName

    /// <summary>
    /// Presence of documentation on used metrics in evaluation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#evaluation_metrics"></see></summary>
    let evaluation_metrics =
        Namespaced_IRI.parse _namespace_name "evaluation_metrics" |> NamespacedName

    /// <summary>
    /// Linking the system with the application domain it is working in
    /// <see href="https://w3id.org/semsys/ns/swemls#hasApplicationDomain"></see></summary>
    let hasApplicationDomain =
        Namespaced_IRI.parse _namespace_name "hasApplicationDomain" |> NamespacedName

    /// <summary>
    /// Linking a SWeML system with a research area it is associated with
    /// <see href="https://w3id.org/semsys/ns/swemls#hasArea"></see></summary>
    let hasArea = Namespaced_IRI.parse _namespace_name "hasArea" |> NamespacedName

    /// <summary>
    /// Linking a paper with the countries of author's affiliations
    /// <see href="https://w3id.org/semsys/ns/swemls#hasAuthorsCountry"></see></summary>
    let hasAuthorsCountry =
        Namespaced_IRI.parse _namespace_name "hasAuthorsCountry" |> NamespacedName

    /// <summary>
    /// A SWeML system has a corresponding pattern
    /// <see href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPattern"></see></summary>
    let hasCorrespondingPattern =
        Namespaced_IRI.parse _namespace_name "hasCorrespondingPattern" |> NamespacedName

    /// <summary>
    /// Linking the corresponding step of a pattern workflow with a specific system component
    /// <see href="https://w3id.org/semsys/ns/swemls#hasCorrespondingPatternStep"></see></summary>
    let hasCorrespondingPatternStep =
        Namespaced_IRI.parse _namespace_name "hasCorrespondingPatternStep" |> NamespacedName

    /// <summary>
    /// Data as in- output(s) in the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasDataIO"></see></summary>
    let hasDataIO = Namespaced_IRI.parse _namespace_name "hasDataIO" |> NamespacedName

    /// <summary>
    /// Describes in- and outputs to SWeML systems
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemIO"></see></summary>
    let hasSystemIO =
        Namespaced_IRI.parse _namespace_name "hasSystemIO" |> NamespacedName

    /// <summary>
    /// System has documentation providing details about e.g. training steps or split, used datasets and evaluation metrics
    /// <see href="https://w3id.org/semsys/ns/swemls#hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// Keywords assigned to the publication by the authors
    /// <see href="https://w3id.org/semsys/ns/swemls#hasKeyword"></see></summary>
    let hasKeyword = Namespaced_IRI.parse _namespace_name "hasKeyword" |> NamespacedName
    /// <summary>
    /// A SWeML system can have one or more models
    /// <see href="https://w3id.org/semsys/ns/swemls#hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName

    /// <summary>
    /// SWeMLs can have one or more processing engines
    /// <see href="https://w3id.org/semsys/ns/swemls#hasProcessingEngine"></see></summary>
    let hasProcessingEngine =
        Namespaced_IRI.parse _namespace_name "hasProcessingEngine" |> NamespacedName

    /// <summary>
    /// A SWeML system linking to at least one statistical model
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStatisticalModel"></see></summary>
    let hasStatisticalModel =
        Namespaced_IRI.parse _namespace_name "hasStatisticalModel" |> NamespacedName

    /// <summary>
    /// Linking SWeMLs to Knowledge Representation component(s) in different steps of the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStepKR"></see></summary>
    let hasStepKR = Namespaced_IRI.parse _namespace_name "hasStepKR" |> NamespacedName

    /// <summary>
    /// SWeMLs can have one or more system components
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemComponent"></see></summary>
    let hasSystemComponent =
        Namespaced_IRI.parse _namespace_name "hasSystemComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepKR1"></see>
    /// </summary>
    let hasStepKR1 = Namespaced_IRI.parse _namespace_name "hasStepKR1" |> NamespacedName
    /// <summary>
    /// Linking SWeMLs to Machine Learning component(s) in different steps of the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasStepML"></see></summary>
    let hasStepML = Namespaced_IRI.parse _namespace_name "hasStepML" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML1"></see>
    /// </summary>
    let hasStepML1 = Namespaced_IRI.parse _namespace_name "hasStepML1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML2"></see>
    /// </summary>
    let hasStepML2 = Namespaced_IRI.parse _namespace_name "hasStepML2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML3"></see>
    /// </summary>
    let hasStepML3 = Namespaced_IRI.parse _namespace_name "hasStepML3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML4"></see>
    /// </summary>
    let hasStepML4 = Namespaced_IRI.parse _namespace_name "hasStepML4" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasStepML5"></see>
    /// </summary>
    let hasStepML5 = Namespaced_IRI.parse _namespace_name "hasStepML5" |> NamespacedName

    /// <summary>
    /// Symbol as in- output(s) in the workflow
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSymbolIO"></see></summary>
    let hasSymbolIO =
        Namespaced_IRI.parse _namespace_name "hasSymbolIO" |> NamespacedName

    /// <summary>
    /// Linking system to symbol usage
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSymbolUsage"></see></summary>
    let hasSymbolUsage =
        Namespaced_IRI.parse _namespace_name "hasSymbolUsage" |> NamespacedName

    /// <summary>
    /// System has a certain maturity according to different characteristics (stability, UI)
    /// <see href="https://w3id.org/semsys/ns/swemls#hasSystemMaturity"></see></summary>
    let hasSystemMaturity =
        Namespaced_IRI.parse _namespace_name "hasSystemMaturity" |> NamespacedName

    /// <summary>
    /// Linking the system to the task it is solving
    /// <see href="https://w3id.org/semsys/ns/swemls#hasTask"></see></summary>
    let hasTask = Namespaced_IRI.parse _namespace_name "hasTask" |> NamespacedName

    /// <summary>
    /// Linking the training type of the system
    /// <see href="https://w3id.org/semsys/ns/swemls#hasTrainingType"></see></summary>
    let hasTrainingType =
        Namespaced_IRI.parse _namespace_name "hasTrainingType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData1"></see>
    /// </summary>
    let hasVariableData1 =
        Namespaced_IRI.parse _namespace_name "hasVariableData1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData2"></see>
    /// </summary>
    let hasVariableData2 =
        Namespaced_IRI.parse _namespace_name "hasVariableData2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData3"></see>
    /// </summary>
    let hasVariableData3 =
        Namespaced_IRI.parse _namespace_name "hasVariableData3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData4"></see>
    /// </summary>
    let hasVariableData4 =
        Namespaced_IRI.parse _namespace_name "hasVariableData4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData5"></see>
    /// </summary>
    let hasVariableData5 =
        Namespaced_IRI.parse _namespace_name "hasVariableData5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData6"></see>
    /// </summary>
    let hasVariableData6 =
        Namespaced_IRI.parse _namespace_name "hasVariableData6" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData7"></see>
    /// </summary>
    let hasVariableData7 =
        Namespaced_IRI.parse _namespace_name "hasVariableData7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableData8"></see>
    /// </summary>
    let hasVariableData8 =
        Namespaced_IRI.parse _namespace_name "hasVariableData8" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW1"></see>
    /// </summary>
    let hasVariableSW1 =
        Namespaced_IRI.parse _namespace_name "hasVariableSW1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW2"></see>
    /// </summary>
    let hasVariableSW2 =
        Namespaced_IRI.parse _namespace_name "hasVariableSW2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW3"></see>
    /// </summary>
    let hasVariableSW3 =
        Namespaced_IRI.parse _namespace_name "hasVariableSW3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/semsys/ns/swemls#hasVariableSW4"></see>
    /// </summary>
    let hasVariableSW4 =
        Namespaced_IRI.parse _namespace_name "hasVariableSW4" |> NamespacedName

    /// <summary>
    /// The ID of the SWeML system
    /// <see href="https://w3id.org/semsys/ns/swemls#has_ID"></see></summary>
    let has_ID = Namespaced_IRI.parse _namespace_name "has_ID" |> NamespacedName
    /// <summary>
    /// Link of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#has_link"></see></summary>
    let has_link = Namespaced_IRI.parse _namespace_name "has_link" |> NamespacedName
    /// <summary>
    /// The title of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#has_title"></see></summary>
    let has_title = Namespaced_IRI.parse _namespace_name "has_title" |> NamespacedName

    /// <summary>
    /// Presence of documentation on used infrastructure: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#infrastructure"></see></summary>
    let infrastructure =
        Namespaced_IRI.parse _namespace_name "infrastructure" |> NamespacedName

    /// <summary>
    /// Linking the paper type to the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#isOfType"></see></summary>
    let isOfType = Namespaced_IRI.parse _namespace_name "isOfType" |> NamespacedName
    /// <summary>
    /// Presence of documentation on used parameters: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#parameters"></see></summary>
    let parameters = Namespaced_IRI.parse _namespace_name "parameters" |> NamespacedName

    /// <summary>
    /// Presence of documentation on performed processing steps, such as
    /// pre-processing, cross-validation: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#process_steps"></see></summary>
    let process_steps =
        Namespaced_IRI.parse _namespace_name "process_steps" |> NamespacedName

    /// <summary>
    /// Presence of input/output data provenance collection: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#provenance_support"></see></summary>
    let provenance_support =
        Namespaced_IRI.parse _namespace_name "provenance_support" |> NamespacedName

    /// <summary>
    /// Linking the system reported in the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#reports"></see></summary>
    let reports = Namespaced_IRI.parse _namespace_name "reports" |> NamespacedName
    /// <summary>
    /// Presence of documentation on used software and libraries: yes, no
    /// <see href="https://w3id.org/semsys/ns/swemls#software"></see></summary>
    let software = Namespaced_IRI.parse _namespace_name "software" |> NamespacedName
    /// <summary>
    /// Short summary of the paper
    /// <see href="https://w3id.org/semsys/ns/swemls#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    /// The venue where the paper is published
    /// <see href="https://w3id.org/semsys/ns/swemls#venue"></see></summary>
    let venue = Namespaced_IRI.parse _namespace_name "venue" |> NamespacedName
    /// <summary>
    /// Year in which the paper is published
    /// <see href="https://w3id.org/semsys/ns/swemls#year"></see></summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
