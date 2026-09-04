#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module irao =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.ethereal.cz/irao/" "irao"

    /// <summary>
    ///   <para>rdfs:label : API</para>
    ///   <para>rdfs:comment : An API is a type of service-based research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/API">irao:API</a>
    /// </summary>
    let API = _prefixId.prefix "API"
    /// <summary>
    ///   <para>rdfs:label : Accessibility</para>
    ///   <para>rdfs:comment : A research artifact can be made accessible via download or some kind of API, etc.</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Accessibility">irao:Accessibility</a>
    /// </summary>
    let Accessibility = _prefixId.prefix "Accessibility"
    /// <summary>
    ///   <para>rdfs:label : Affiliation</para>
    ///   <para>rdfs:comment : An affiliation of the author, it maybe a company or an institution</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Affiliation">irao:Affiliation</a>
    /// </summary>
    let Affiliation = _prefixId.prefix "Affiliation"
    /// <summary>
    ///   <para>rdfs:label : Annotated Dataset</para>
    ///   <para>rdfs:comment : A dataset which was processed for AI or machine learning</para>
    ///   <a href="http://ontology.ethereal.cz/irao/AnnotatedDataset">irao:AnnotatedDataset</a>
    /// </summary>
    let AnnotatedDataset = _prefixId.prefix "AnnotatedDataset"
    /// <summary>
    ///   <para>rdfs:label : Application Framework</para>
    ///   <para>rdfs:comment : A framework that is used by applications</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ApplicationFramework">irao:ApplicationFramework</a>
    /// </summary>
    let ApplicationFramework = _prefixId.prefix "ApplicationFramework"
    /// <summary>
    ///   <para>rdfs:label : Benchmark</para>
    ///   <para>rdfs:comment : A benchmark is a type of comparison and measuring with metrics, producing datasets and algorithms for comprehensive and systematic evaluation of existing and future systems</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Benchmark">irao:Benchmark</a>
    /// </summary>
    let Benchmark = _prefixId.prefix "Benchmark"
    /// <summary>
    ///   <para>rdfs:label : Conference paper</para>
    ///   <para>rdfs:comment : A paper or article published at a scientific conference</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ConferencePaper">irao:ConferencePaper</a>
    /// </summary>
    let ConferencePaper = _prefixId.prefix "ConferencePaper"
    /// <summary>
    ///   <para>rdfs:label : Data model</para>
    ///   <para>rdfs:comment : A data model such as schema and ontologies</para>
    ///   <a href="http://ontology.ethereal.cz/irao/DataModel">irao:DataModel</a>
    /// </summary>
    let DataModel = _prefixId.prefix "DataModel"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : A dataset containing the gathered or generated data about some topic</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Dataset">irao:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Design</para>
    ///   <para>rdfs:comment : A plan or specification for the construction or production of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Design">irao:Design</a>
    /// </summary>
    let Design = _prefixId.prefix "Design"
    /// <summary>
    ///   <para>rdfs:label : Design quality</para>
    ///   <para>rdfs:comment : A design quality involves the usage of recommended standards, protocols, frameworks, methodologies</para>
    ///   <a href="http://ontology.ethereal.cz/irao/DesignQuality">irao:DesignQuality</a>
    /// </summary>
    let DesignQuality = _prefixId.prefix "DesignQuality"
    /// <summary>
    ///   <para>rdfs:label : Development status</para>
    ///   <para>rdfs:comment : The development status of a research artifact, informing about its maturity</para>
    ///   <a href="http://ontology.ethereal.cz/irao/DevelopmentStatus">irao:DevelopmentStatus</a>
    /// </summary>
    let DevelopmentStatus = _prefixId.prefix "DevelopmentStatus"
    /// <summary>
    ///   <para>rdfs:label : Framework</para>
    ///   <para>rdfs:comment : The framework is a type of an informatics research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Framework">irao:Framework</a>
    /// </summary>
    let Framework = _prefixId.prefix "Framework"
    /// <summary>
    ///   <para>rdfs:label : Informatics Research Artifact</para>
    ///   <para>rdfs:comment : An informatics research artifact is a research artifact in the informatics field</para>
    ///   <a href="http://ontology.ethereal.cz/irao/InformaticsResearchArtifact">irao:InformaticsResearchArtifact</a>
    /// </summary>
    let InformaticsResearchArtifact = _prefixId.prefix "InformaticsResearchArtifact"
    /// <summary>
    ///   <para>rdfs:label : License</para>
    ///   <para>rdfs:comment : A license authorizes the use, performace, or release of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/License">irao:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    /// <summary>
    ///   <para>rdfs:label : License type</para>
    ///   <para>rdfs:comment : The type of a license</para>
    ///   <a href="http://ontology.ethereal.cz/irao/LicenseType">irao:LicenseType</a>
    /// </summary>
    let LicenseType = _prefixId.prefix "LicenseType"
    /// <summary>
    ///   <para>rdfs:label : Methodology</para>
    ///   <para>rdfs:comment : Methodology is a type of research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Methodology">irao:Methodology</a>
    /// </summary>
    let Methodology = _prefixId.prefix "Methodology"
    /// <summary>
    ///   <para>rdfs:label : Middleware</para>
    ///   <para>rdfs:comment : A middleware is a type of software that is used to connect software components in to a system</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Middleware">irao:Middleware</a>
    /// </summary>
    let Middleware = _prefixId.prefix "Middleware"
    /// <summary>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : A model is a type of research artifact that can be used to describe other artifacts such as a dataset or a software</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Model">irao:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : Ontology</para>
    ///   <para>rdfs:comment : An ontology is a type of data model used to describe linked datasets</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Ontology">irao:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : Ontology design pattern</para>
    ///   <para>rdfs:comment : An ontology design pattern is a pattern used in designing ontologies</para>
    ///   <a href="http://ontology.ethereal.cz/irao/OntologyDesignPattern">irao:OntologyDesignPattern</a>
    /// </summary>
    let OntologyDesignPattern = _prefixId.prefix "OntologyDesignPattern"
    /// <summary>
    ///   <para>rdfs:label : Open Standard</para>
    ///   <para>rdfs:comment : A open standard is a standard used to provide guidelines for the development and operations of artifacts and systems</para>
    ///   <a href="http://ontology.ethereal.cz/irao/OpenStandard">irao:OpenStandard</a>
    /// </summary>
    let OpenStandard = _prefixId.prefix "OpenStandard"
    /// <summary>
    ///   <para>rdfs:label : Protocol</para>
    ///   <para>rdfs:comment : A protocol is used to provide guidelines to execute certain tasks</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Protocol">irao:Protocol</a>
    /// </summary>
    let Protocol = _prefixId.prefix "Protocol"
    /// <summary>
    ///   <para>rdfs:label : Publication</para>
    ///   <para>rdfs:comment : A publication makes content and research results available to the general public via publication venues such as journals, books, websites, etc.</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Publication">irao:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Repository</para>
    ///   <para>rdfs:comment : A repository is an online storage for the deposit of research artifacts such as datasets and vocabularies</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Repository">irao:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:label : Repository Type</para>
    ///   <para>rdfs:comment : A repository type can be a knowledge base, knowledge graph, version control hosting, etc.</para>
    ///   <a href="http://ontology.ethereal.cz/irao/RepositoryType">irao:RepositoryType</a>
    /// </summary>
    let RepositoryType = _prefixId.prefix "RepositoryType"
    /// <summary>
    ///   <para>rdfs:label : Research Artifact</para>
    ///   <para>rdfs:comment : A research artifact is a direct output or result of a research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ResearchArtifact">irao:ResearchArtifact</a>
    /// </summary>
    let ResearchArtifact = _prefixId.prefix "ResearchArtifact"
    /// <summary>
    ///   <para>rdfs:label : Research Domain</para>
    ///   <para>rdfs:comment : A research domain is the domain of interest of a research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ResearchDomain">irao:ResearchDomain</a>
    /// </summary>
    let ResearchDomain = _prefixId.prefix "ResearchDomain"
    /// <summary>
    ///   <para>rdfs:label : Research Field</para>
    ///   <para>rdfs:comment : A research field is the field of interest of a research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ResearchField">irao:ResearchField</a>
    /// </summary>
    let ResearchField = _prefixId.prefix "ResearchField"
    /// <summary>
    ///   <para>rdfs:label : Research output</para>
    ///   <para>rdfs:comment : A research output is the result of a research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ResearchOutput">irao:ResearchOutput</a>
    /// </summary>
    let ResearchOutput = _prefixId.prefix "ResearchOutput"
    /// <summary>
    ///   <para>rdfs:label : Research project</para>
    ///   <para>rdfs:comment : A research project is a project within the research domain with the endeavor of achieving scientific results</para>
    ///   <a href="http://ontology.ethereal.cz/irao/ResearchProject">irao:ResearchProject</a>
    /// </summary>
    let ResearchProject = _prefixId.prefix "ResearchProject"
    /// <summary>
    ///   <para>rdfs:label : Researcher</para>
    ///   <para>rdfs:comment : A researcher is a person doing research</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Researcher">irao:Researcher</a>
    /// </summary>
    let Researcher = _prefixId.prefix "Researcher"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A service is a type of software that provides e.g. data or some type of functionalities</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Service">irao:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : A software is a type of informatics research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Software">irao:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : Software Framework</para>
    ///   <para>rdfs:comment : A software framework is a type of software that provides guidelines for the development of new softwares</para>
    ///   <a href="http://ontology.ethereal.cz/irao/SoftwareFramework">irao:SoftwareFramework</a>
    /// </summary>
    let SoftwareFramework = _prefixId.prefix "SoftwareFramework"
    /// <summary>
    ///   <para>rdfs:label : Synthetic Dataset</para>
    ///   <para>rdfs:comment : Synthetic datasets are generated through computer programs, instead of being composed through the documentation of real-world events</para>
    ///   <a href="http://ontology.ethereal.cz/irao/SyntheticDataset">irao:SyntheticDataset</a>
    /// </summary>
    let SyntheticDataset = _prefixId.prefix "SyntheticDataset"
    /// <summary>
    ///   <para>rdfs:label : System</para>
    ///   <para>rdfs:comment : A system is a group of interacting or interrelated informatics components that form a unified whole</para>
    ///   <a href="http://ontology.ethereal.cz/irao/System">irao:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : Thesis</para>
    ///   <para>rdfs:comment : A thesis as a type of scientific or academic publication or dissertation is a document submitted in support of candidature for an academic degree or professional qualification presenting the author's research and findings</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Thesis">irao:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>rdfs:label : Vocabulary</para>
    ///   <para>rdfs:comment : A vocabulary is used to provide a range of commonly used terms and their definitions</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Vocabulary">irao:Vocabulary</a>
    /// </summary>
    let Vocabulary = _prefixId.prefix "Vocabulary"
    /// <summary>
    ///   <para>rdfs:label : Web Framework</para>
    ///   <para>rdfs:comment : A web framework is a type of software framework that is used to develop applications on the web</para>
    ///   <a href="http://ontology.ethereal.cz/irao/WebFramework">irao:WebFramework</a>
    /// </summary>
    let WebFramework = _prefixId.prefix "WebFramework"
    /// <summary>
    ///   <para>rdfs:label : Workflow</para>
    ///   <para>rdfs:comment : A workflow is a sequence of interrelated, orchestrated and repeatable tasks</para>
    ///   <a href="http://ontology.ethereal.cz/irao/Workflow">irao:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:label : has accessibility</para>
    ///   <para>rdfs:comment : This property specifies the accessibility of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasAccessibility">irao:hasAccessibility</a>
    /// </summary>
    let hasAccessibility = _prefixId.prefix "hasAccessibility"
    /// <summary>
    ///   <para>rdfs:label : has affiliation</para>
    ///   <para>rdfs:comment : This property specifies the affiliation of a researcher</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasAffiliation">irao:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>rdfs:label : has author</para>
    ///   <para>rdfs:comment : This property specifies the author of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasAuthor">irao:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : has design</para>
    ///   <para>rdfs:comment : This property specifies the design of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasDesign">irao:hasDesign</a>
    /// </summary>
    let hasDesign = _prefixId.prefix "hasDesign"
    /// <summary>
    ///   <para>rdfs:label : has design quality</para>
    ///   <para>rdfs:comment : This property specifies the design quality of a design</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasDesignQuality">irao:hasDesignQuality</a>
    /// </summary>
    let hasDesignQuality = _prefixId.prefix "hasDesignQuality"
    /// <summary>
    ///   <para>rdfs:label : has development status</para>
    ///   <para>rdfs:comment : This property specifies the development status of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasDevelopmentStatus">irao:hasDevelopmentStatus</a>
    /// </summary>
    let hasDevelopmentStatus = _prefixId.prefix "hasDevelopmentStatus"
    /// <summary>
    ///   <para>rdfs:label : has domain</para>
    ///   <para>rdfs:comment : This property specifies the research domain of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasDomain">irao:hasDomain</a>
    /// </summary>
    let hasDomain = _prefixId.prefix "hasDomain"
    /// <summary>
    ///   <para>rdfs:label : has field</para>
    ///   <para>rdfs:comment : This property specifies the research field of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasField">irao:hasField</a>
    /// </summary>
    let hasField = _prefixId.prefix "hasField"
    /// <summary>
    ///   <para>rdfs:label : has followed protocol</para>
    ///   <para>rdfs:comment : This property specifies the protocol that a benchmark follows</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasFollowedProtocol">irao:hasFollowedProtocol</a>
    /// </summary>
    let hasFollowedProtocol = _prefixId.prefix "hasFollowedProtocol"
    /// <summary>
    ///   <para>rdfs:label : has framework</para>
    ///   <para>rdfs:comment : This property specifies the framework used by a software</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasFramework">irao:hasFramework</a>
    /// </summary>
    let hasFramework = _prefixId.prefix "hasFramework"
    /// <summary>
    ///   <para>rdfs:label : has license</para>
    ///   <para>rdfs:comment : This property specifies the license of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasLicense">irao:hasLicense</a>
    /// </summary>
    let hasLicense = _prefixId.prefix "hasLicense"
    /// <summary>
    ///   <para>rdfs:label : has license type</para>
    ///   <para>rdfs:comment : This property specifies the type of a license</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasLicenseType">irao:hasLicenseType</a>
    /// </summary>
    let hasLicenseType = _prefixId.prefix "hasLicenseType"
    /// <summary>
    ///   <para>rdfs:label : is maintained by</para>
    ///   <para>rdfs:comment : This property specifies the maintainer of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasMaintainer">irao:hasMaintainer</a>
    /// </summary>
    let hasMaintainer = _prefixId.prefix "hasMaintainer"
    /// <summary>
    ///   <para>rdfs:label : has measuring system</para>
    ///   <para>rdfs:comment : This property specifies a system that measures a benchmark</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasMeasuringSystem">irao:hasMeasuringSystem</a>
    /// </summary>
    let hasMeasuringSystem = _prefixId.prefix "hasMeasuringSystem"
    /// <summary>
    ///   <para>rdfs:label : has methodology</para>
    ///   <para>rdfs:comment : This property specifies the methodology used by a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasMethodology">irao:hasMethodology</a>
    /// </summary>
    let hasMethodology = _prefixId.prefix "hasMethodology"
    /// <summary>
    ///   <para>rdfs:label : has open standard</para>
    ///   <para>rdfs:comment : This property specifies the open standard used by a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasOpenStandard">irao:hasOpenStandard</a>
    /// </summary>
    let hasOpenStandard = _prefixId.prefix "hasOpenStandard"
    /// <summary>
    ///   <para>rdfs:label : has produced dataset</para>
    ///   <para>rdfs:comment : This property specifies the dataset which us produced by a benchmark</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasProducedDataset">irao:hasProducedDataset</a>
    /// </summary>
    let hasProducedDataset = _prefixId.prefix "hasProducedDataset"
    /// <summary>
    ///   <para>rdfs:label : has publication</para>
    ///   <para>rdfs:comment : This property specifies the publication of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasPublication">irao:hasPublication</a>
    /// </summary>
    let hasPublication = _prefixId.prefix "hasPublication"
    /// <summary>
    ///   <para>rdfs:label : has referred benchmark</para>
    ///   <para>rdfs:comment : This property specifies a benchmark referred by another benchmark</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasReferredBenchmark">irao:hasReferredBenchmark</a>
    /// </summary>
    let hasReferredBenchmark = _prefixId.prefix "hasReferredBenchmark"
    /// <summary>
    ///   <para>rdfs:label : has repository type</para>
    ///   <para>rdfs:comment : This property specifies the repository type of a research artifact repository</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasRepositoryType">irao:hasRepositoryType</a>
    /// </summary>
    let hasRepositoryType = _prefixId.prefix "hasRepositoryType"
    /// <summary>
    ///   <para>rdfs:label : has research area</para>
    ///   <para>rdfs:comment : This property specifies the research area of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasResearchArea">irao:hasResearchArea</a>
    /// </summary>
    let hasResearchArea = _prefixId.prefix "hasResearchArea"
    /// <summary>
    ///   <para>rdfs:label : has research output</para>
    ///   <para>rdfs:comment : This property specifies the research output of a research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasResearchOutput">irao:hasResearchOutput</a>
    /// </summary>
    let hasResearchOutput = _prefixId.prefix "hasResearchOutput"
    /// <summary>
    ///   <para>rdfs:label : has topic</para>
    ///   <para>rdfs:comment : This property specifies the topic of a publication</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasTopic">irao:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:label : has URL</para>
    ///   <para>rdfs:comment : This property specifies the resource URL of a publication, repository or research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasURL">irao:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:label : has used framework</para>
    ///   <para>rdfs:comment : This property specifies the framework used by a research artifact like software or system</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasUsedFramework">irao:hasUsedFramework</a>
    /// </summary>
    let hasUsedFramework = _prefixId.prefix "hasUsedFramework"
    /// <summary>
    ///   <para>rdfs:label : has used methodology</para>
    ///   <para>rdfs:comment : This property specifies the methodology used in a research artifact like framework or dataset</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasUsedMethodology">irao:hasUsedMethodology</a>
    /// </summary>
    let hasUsedMethodology = _prefixId.prefix "hasUsedMethodology"
    /// <summary>
    ///   <para>rdfs:label : has used ontology design pattern</para>
    ///   <para>rdfs:comment : This property specifies the ontology design pattern of an ontology or another ontology design pattern</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasUsedOntologyDesignPattern">irao:hasUsedOntologyDesignPattern</a>
    /// </summary>
    let hasUsedOntologyDesignPattern = _prefixId.prefix "hasUsedOntologyDesignPattern"
    /// <summary>
    ///   <para>rdfs:label : has version</para>
    ///   <para>rdfs:comment : This property specifies the version of a research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/hasVersion">irao:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : is described by</para>
    ///   <para>rdfs:comment : This property specifies the data model of a dataset</para>
    ///   <a href="http://ontology.ethereal.cz/irao/isDescribedBy">irao:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : is followed by</para>
    ///   <para>rdfs:comment : This property specifies that a research project is followed by another research project</para>
    ///   <a href="http://ontology.ethereal.cz/irao/isFollowedBy">irao:isFollowedBy</a>
    /// </summary>
    let isFollowedBy = _prefixId.prefix "isFollowedBy"
    /// <summary>
    ///   <para>rdfs:label : is part of system</para>
    ///   <para>rdfs:comment : This property specifies the system which a software is part of</para>
    ///   <a href="http://ontology.ethereal.cz/irao/isPartOfSystem">irao:isPartOfSystem</a>
    /// </summary>
    let isPartOfSystem = _prefixId.prefix "isPartOfSystem"
    /// <summary>
    ///   <para>rdfs:label : is published at</para>
    ///   <para>rdfs:comment : This property specifies the repository that a research artifact is published at</para>
    ///   <a href="http://ontology.ethereal.cz/irao/isPublishedAt">irao:isPublishedAt</a>
    /// </summary>
    let isPublishedAt = _prefixId.prefix "isPublishedAt"
    /// <summary>
    ///   <para>rdfs:label : is used by</para>
    ///   <para>rdfs:comment : This property specifies that a research artifact is used by another research artifact</para>
    ///   <a href="http://ontology.ethereal.cz/irao/isUsedBy">irao:isUsedBy</a>
    /// </summary>
    let isUsedBy = _prefixId.prefix "isUsedBy"
