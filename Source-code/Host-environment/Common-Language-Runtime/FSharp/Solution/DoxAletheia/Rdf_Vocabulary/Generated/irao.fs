namespace http.ontology.ethereal.cz.irao.slash

open DoxAletheia

module irao =
    let _namespace_name = "http://ontology.ethereal.cz/irao/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An API is a type of service-based research artifact
    /// <see href="http://ontology.ethereal.cz/irao/API"></see></summary>
    let API = _prefix "API"
    /// <summary>
    /// A service is a type of software that provides e.g. data or some type of functionalities
    /// <see href="http://ontology.ethereal.cz/irao/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A research artifact can be made accessible via download or some kind of API, etc.
    /// <see href="http://ontology.ethereal.cz/irao/Accessibility"></see></summary>
    let Accessibility = _prefix "Accessibility"
    /// <summary>
    /// An affiliation of the author, it maybe a company or an institution
    /// <see href="http://ontology.ethereal.cz/irao/Affiliation"></see></summary>
    let Affiliation = _prefix "Affiliation"
    /// <summary>
    /// A dataset which was processed for AI or machine learning
    /// <see href="http://ontology.ethereal.cz/irao/AnnotatedDataset"></see></summary>
    let AnnotatedDataset = _prefix "AnnotatedDataset"
    /// <summary>
    /// A dataset containing the gathered or generated data about some topic
    /// <see href="http://ontology.ethereal.cz/irao/Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A framework that is used by applications
    /// <see href="http://ontology.ethereal.cz/irao/ApplicationFramework"></see></summary>
    let ApplicationFramework = _prefix "ApplicationFramework"
    /// <summary>
    /// A software framework is a type of software that provides guidelines for the development of new softwares
    /// <see href="http://ontology.ethereal.cz/irao/SoftwareFramework"></see></summary>
    let SoftwareFramework = _prefix "SoftwareFramework"
    /// <summary>
    /// A benchmark is a type of comparison and measuring with metrics, producing datasets and algorithms for comprehensive and systematic evaluation of existing and future systems
    /// <see href="http://ontology.ethereal.cz/irao/Benchmark"></see></summary>
    let Benchmark = _prefix "Benchmark"
    /// <summary>
    /// An informatics research artifact is a research artifact in the informatics field
    /// <see href="http://ontology.ethereal.cz/irao/InformaticsResearchArtifact"></see></summary>
    let InformaticsResearchArtifact = _prefix "InformaticsResearchArtifact"
    /// <summary>
    /// A paper or article published at a scientific conference
    /// <see href="http://ontology.ethereal.cz/irao/ConferencePaper"></see></summary>
    let ConferencePaper = _prefix "ConferencePaper"
    /// <summary>
    /// A publication makes content and research results available to the general public via publication venues such as journals, books, websites, etc.
    /// <see href="http://ontology.ethereal.cz/irao/Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// A data model such as schema and ontologies
    /// <see href="http://ontology.ethereal.cz/irao/DataModel"></see></summary>
    let DataModel = _prefix "DataModel"
    /// <summary>
    /// A model is a type of research artifact that can be used to describe other artifacts such as a dataset or a software
    /// <see href="http://ontology.ethereal.cz/irao/Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// A plan or specification for the construction or production of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Design"></see></summary>
    let Design = _prefix "Design"
    /// <summary>
    /// A design quality involves the usage of recommended standards, protocols, frameworks, methodologies
    /// <see href="http://ontology.ethereal.cz/irao/DesignQuality"></see></summary>
    let DesignQuality = _prefix "DesignQuality"
    /// <summary>
    /// The development status of a research artifact, informing about its maturity
    /// <see href="http://ontology.ethereal.cz/irao/DevelopmentStatus"></see></summary>
    let DevelopmentStatus = _prefix "DevelopmentStatus"
    /// <summary>
    /// The framework is a type of an informatics research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Framework"></see></summary>
    let Framework = _prefix "Framework"
    /// <summary>
    /// A research artifact is a direct output or result of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchArtifact"></see></summary>
    let ResearchArtifact = _prefix "ResearchArtifact"
    /// <summary>
    /// A license authorizes the use, performace, or release of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// The type of a license
    /// <see href="http://ontology.ethereal.cz/irao/LicenseType"></see></summary>
    let LicenseType = _prefix "LicenseType"
    /// <summary>
    /// Methodology is a type of research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Methodology"></see></summary>
    let Methodology = _prefix "Methodology"
    /// <summary>
    /// A middleware is a type of software that is used to connect software components in to a system
    /// <see href="http://ontology.ethereal.cz/irao/Middleware"></see></summary>
    let Middleware = _prefix "Middleware"
    /// <summary>
    /// A software is a type of informatics research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// An ontology is a type of data model used to describe linked datasets
    /// <see href="http://ontology.ethereal.cz/irao/Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// An ontology design pattern is a pattern used in designing ontologies
    /// <see href="http://ontology.ethereal.cz/irao/OntologyDesignPattern"></see></summary>
    let OntologyDesignPattern = _prefix "OntologyDesignPattern"
    /// <summary>
    /// A open standard is a standard used to provide guidelines for the development and operations of artifacts and systems
    /// <see href="http://ontology.ethereal.cz/irao/OpenStandard"></see></summary>
    let OpenStandard = _prefix "OpenStandard"
    /// <summary>
    /// A protocol is used to provide guidelines to execute certain tasks
    /// <see href="http://ontology.ethereal.cz/irao/Protocol"></see></summary>
    let Protocol = _prefix "Protocol"
    /// <summary>
    /// A research output is the result of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchOutput"></see></summary>
    let ResearchOutput = _prefix "ResearchOutput"
    /// <summary>
    /// A repository is an online storage for the deposit of research artifacts such as datasets and vocabularies
    /// <see href="http://ontology.ethereal.cz/irao/Repository"></see></summary>
    let Repository = _prefix "Repository"
    /// <summary>
    /// A repository type can be a knowledge base, knowledge graph, version control hosting, etc.
    /// <see href="http://ontology.ethereal.cz/irao/RepositoryType"></see></summary>
    let RepositoryType = _prefix "RepositoryType"
    /// <summary>
    /// A research domain is the domain of interest of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchDomain"></see></summary>
    let ResearchDomain = _prefix "ResearchDomain"
    /// <summary>
    /// A research field is the field of interest of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchField"></see></summary>
    let ResearchField = _prefix "ResearchField"
    /// <summary>
    /// A research project is a project within the research domain with the endeavor of achieving scientific results
    /// <see href="http://ontology.ethereal.cz/irao/ResearchProject"></see></summary>
    let ResearchProject = _prefix "ResearchProject"
    /// <summary>
    /// A researcher is a person doing research
    /// <see href="http://ontology.ethereal.cz/irao/Researcher"></see></summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    /// Synthetic datasets are generated through computer programs, instead of being composed through the documentation of real-world events
    /// <see href="http://ontology.ethereal.cz/irao/SyntheticDataset"></see></summary>
    let SyntheticDataset = _prefix "SyntheticDataset"
    /// <summary>
    /// A system is a group of interacting or interrelated informatics components that form a unified whole
    /// <see href="http://ontology.ethereal.cz/irao/System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// A thesis as a type of scientific or academic publication or dissertation is a document submitted in support of candidature for an academic degree or professional qualification presenting the author's research and findings
    /// <see href="http://ontology.ethereal.cz/irao/Thesis"></see></summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// A vocabulary is used to provide a range of commonly used terms and their definitions
    /// <see href="http://ontology.ethereal.cz/irao/Vocabulary"></see></summary>
    let Vocabulary = _prefix "Vocabulary"
    /// <summary>
    /// A web framework is a type of software framework that is used to develop applications on the web
    /// <see href="http://ontology.ethereal.cz/irao/WebFramework"></see></summary>
    let WebFramework = _prefix "WebFramework"
    /// <summary>
    /// A workflow is a sequence of interrelated, orchestrated and repeatable tasks
    /// <see href="http://ontology.ethereal.cz/irao/Workflow"></see></summary>
    let Workflow = _prefix "Workflow"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#API"></see>
    /// </summary>
    let ``accessibility#API`` = _prefix "accessibility#API"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#Download"></see>
    /// </summary>
    let ``accessibility#Download`` = _prefix "accessibility#Download"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#OpenData"></see>
    /// </summary>
    let ``accessibility#OpenData`` = _prefix "accessibility#OpenData"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#OpenSource"></see>
    /// </summary>
    let ``accessibility#OpenSource`` = _prefix "accessibility#OpenSource"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/designquality#FAIR"></see>
    /// </summary>
    let ``designquality#FAIR`` = _prefix "designquality#FAIR"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/designquality#Reuse"></see>
    /// </summary>
    let ``designquality#Reuse`` = _prefix "designquality#Reuse"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#alpha"></see>
    /// </summary>
    let ``developmentstatus#alpha`` = _prefix "developmentstatus#alpha"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#beta"></see>
    /// </summary>
    let ``developmentstatus#beta`` = _prefix "developmentstatus#beta"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#release"></see>
    /// </summary>
    let ``developmentstatus#release`` = _prefix "developmentstatus#release"
    /// <summary>
    /// This property specifies the accessibility of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasAccessibility"></see></summary>
    let hasAccessibility = _prefix "hasAccessibility"
    /// <summary>
    /// This property specifies the affiliation of a researcher
    /// <see href="http://ontology.ethereal.cz/irao/hasAffiliation"></see></summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    /// This property specifies the author of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// This property specifies the design of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDesign"></see></summary>
    let hasDesign = _prefix "hasDesign"
    /// <summary>
    /// This property specifies the design quality of a design
    /// <see href="http://ontology.ethereal.cz/irao/hasDesignQuality"></see></summary>
    let hasDesignQuality = _prefix "hasDesignQuality"
    /// <summary>
    /// This property specifies the development status of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDevelopmentStatus"></see></summary>
    let hasDevelopmentStatus = _prefix "hasDevelopmentStatus"
    /// <summary>
    /// This property specifies the research domain of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDomain"></see></summary>
    let hasDomain = _prefix "hasDomain"
    /// <summary>
    /// This property specifies the research field of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasField"></see></summary>
    let hasField = _prefix "hasField"
    /// <summary>
    /// This property specifies the protocol that a benchmark follows
    /// <see href="http://ontology.ethereal.cz/irao/hasFollowedProtocol"></see></summary>
    let hasFollowedProtocol = _prefix "hasFollowedProtocol"
    /// <summary>
    /// This property specifies the framework used by a software
    /// <see href="http://ontology.ethereal.cz/irao/hasFramework"></see></summary>
    let hasFramework = _prefix "hasFramework"
    /// <summary>
    /// This property specifies the license of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasLicense"></see></summary>
    let hasLicense = _prefix "hasLicense"
    /// <summary>
    /// This property specifies the type of a license
    /// <see href="http://ontology.ethereal.cz/irao/hasLicenseType"></see></summary>
    let hasLicenseType = _prefix "hasLicenseType"
    /// <summary>
    /// This property specifies the maintainer of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasMaintainer"></see></summary>
    let hasMaintainer = _prefix "hasMaintainer"
    /// <summary>
    /// This property specifies a system that measures a benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasMeasuringSystem"></see></summary>
    let hasMeasuringSystem = _prefix "hasMeasuringSystem"
    /// <summary>
    /// This property specifies the methodology used by a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasMethodology"></see></summary>
    let hasMethodology = _prefix "hasMethodology"
    /// <summary>
    /// This property specifies the open standard used by a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasOpenStandard"></see></summary>
    let hasOpenStandard = _prefix "hasOpenStandard"
    /// <summary>
    /// This property specifies the dataset which us produced by a benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasProducedDataset"></see></summary>
    let hasProducedDataset = _prefix "hasProducedDataset"
    /// <summary>
    /// This property specifies the publication of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasPublication"></see></summary>
    let hasPublication = _prefix "hasPublication"
    /// <summary>
    /// This property specifies a benchmark referred by another benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasReferredBenchmark"></see></summary>
    let hasReferredBenchmark = _prefix "hasReferredBenchmark"
    /// <summary>
    /// This property specifies the repository type of a research artifact repository
    /// <see href="http://ontology.ethereal.cz/irao/hasRepositoryType"></see></summary>
    let hasRepositoryType = _prefix "hasRepositoryType"
    /// <summary>
    /// This property specifies the research area of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasResearchArea"></see></summary>
    let hasResearchArea = _prefix "hasResearchArea"
    /// <summary>
    /// This property specifies the research output of a research project
    /// <see href="http://ontology.ethereal.cz/irao/hasResearchOutput"></see></summary>
    let hasResearchOutput = _prefix "hasResearchOutput"
    /// <summary>
    /// This property specifies the topic of a publication
    /// <see href="http://ontology.ethereal.cz/irao/hasTopic"></see></summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    /// This property specifies the resource URL of a publication, repository or research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasURL"></see></summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    /// This property specifies the framework used by a research artifact like software or system
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedFramework"></see></summary>
    let hasUsedFramework = _prefix "hasUsedFramework"
    /// <summary>
    /// This property specifies the methodology used in a research artifact like framework or dataset
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedMethodology"></see></summary>
    let hasUsedMethodology = _prefix "hasUsedMethodology"
    /// <summary>
    /// This property specifies the ontology design pattern of an ontology or another ontology design pattern
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedOntologyDesignPattern"></see></summary>
    let hasUsedOntologyDesignPattern = _prefix "hasUsedOntologyDesignPattern"
    /// <summary>
    /// This property specifies the version of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// This property specifies the data model of a dataset
    /// <see href="http://ontology.ethereal.cz/irao/isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// This property specifies that a research project is followed by another research project
    /// <see href="http://ontology.ethereal.cz/irao/isFollowedBy"></see></summary>
    let isFollowedBy = _prefix "isFollowedBy"
    /// <summary>
    /// This property specifies the system which a software is part of
    /// <see href="http://ontology.ethereal.cz/irao/isPartOfSystem"></see></summary>
    let isPartOfSystem = _prefix "isPartOfSystem"
    /// <summary>
    /// This property specifies the repository that a research artifact is published at
    /// <see href="http://ontology.ethereal.cz/irao/isPublishedAt"></see></summary>
    let isPublishedAt = _prefix "isPublishedAt"
    /// <summary>
    /// This property specifies that a research artifact is used by another research artifact
    /// <see href="http://ontology.ethereal.cz/irao/isUsedBy"></see></summary>
    let isUsedBy = _prefix "isUsedBy"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#RDF"></see>
    /// </summary>
    let ``openstandard#RDF`` = _prefix "openstandard#RDF"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#RDFS"></see>
    /// </summary>
    let ``openstandard#RDFS`` = _prefix "openstandard#RDFS"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#SKOS"></see>
    /// </summary>
    let ``openstandard#SKOS`` = _prefix "openstandard#SKOS"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#SPARQL"></see>
    /// </summary>
    let ``openstandard#SPARQL`` = _prefix "openstandard#SPARQL"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#XML"></see>
    /// </summary>
    let ``openstandard#XML`` = _prefix "openstandard#XML"
    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/repositorytype#KnowledgeBase"></see>
    /// </summary>
    let ``repositorytype#KnowledgeBase`` = _prefix "repositorytype#KnowledgeBase"

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/repositorytype#VersionControlHosting"></see>
    /// </summary>
    let ``repositorytype#VersionControlHosting`` =
        _prefix "repositorytype#VersionControlHosting"
