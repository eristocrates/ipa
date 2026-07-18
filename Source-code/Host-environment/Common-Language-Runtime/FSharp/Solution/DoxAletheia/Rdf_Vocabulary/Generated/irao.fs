namespace http.ontology.ethereal.cz.irao.slash

open DoxAletheia.Rdf_Vocabulary

module irao =
    let _namespace_name = "http://ontology.ethereal.cz/irao/"
    /// <summary>
    /// An API is a type of service-based research artifact
    /// <see href="http://ontology.ethereal.cz/irao/API"></see></summary>
    let API = Namespaced_IRI.parse _namespace_name "API" |> NamespacedName
    /// <summary>
    /// A service is a type of software that provides e.g. data or some type of functionalities
    /// <see href="http://ontology.ethereal.cz/irao/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// A research artifact can be made accessible via download or some kind of API, etc.
    /// <see href="http://ontology.ethereal.cz/irao/Accessibility"></see></summary>
    let Accessibility =
        Namespaced_IRI.parse _namespace_name "Accessibility" |> NamespacedName

    /// <summary>
    /// An affiliation of the author, it maybe a company or an institution
    /// <see href="http://ontology.ethereal.cz/irao/Affiliation"></see></summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    /// A dataset which was processed for AI or machine learning
    /// <see href="http://ontology.ethereal.cz/irao/AnnotatedDataset"></see></summary>
    let AnnotatedDataset =
        Namespaced_IRI.parse _namespace_name "AnnotatedDataset" |> NamespacedName

    /// <summary>
    /// A dataset containing the gathered or generated data about some topic
    /// <see href="http://ontology.ethereal.cz/irao/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A framework that is used by applications
    /// <see href="http://ontology.ethereal.cz/irao/ApplicationFramework"></see></summary>
    let ApplicationFramework =
        Namespaced_IRI.parse _namespace_name "ApplicationFramework" |> NamespacedName

    /// <summary>
    /// A software framework is a type of software that provides guidelines for the development of new softwares
    /// <see href="http://ontology.ethereal.cz/irao/SoftwareFramework"></see></summary>
    let SoftwareFramework =
        Namespaced_IRI.parse _namespace_name "SoftwareFramework" |> NamespacedName

    /// <summary>
    /// A benchmark is a type of comparison and measuring with metrics, producing datasets and algorithms for comprehensive and systematic evaluation of existing and future systems
    /// <see href="http://ontology.ethereal.cz/irao/Benchmark"></see></summary>
    let Benchmark = Namespaced_IRI.parse _namespace_name "Benchmark" |> NamespacedName

    /// <summary>
    /// An informatics research artifact is a research artifact in the informatics field
    /// <see href="http://ontology.ethereal.cz/irao/InformaticsResearchArtifact"></see></summary>
    let InformaticsResearchArtifact =
        Namespaced_IRI.parse _namespace_name "InformaticsResearchArtifact" |> NamespacedName

    /// <summary>
    /// A paper or article published at a scientific conference
    /// <see href="http://ontology.ethereal.cz/irao/ConferencePaper"></see></summary>
    let ConferencePaper =
        Namespaced_IRI.parse _namespace_name "ConferencePaper" |> NamespacedName

    /// <summary>
    /// A publication makes content and research results available to the general public via publication venues such as journals, books, websites, etc.
    /// <see href="http://ontology.ethereal.cz/irao/Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// A data model such as schema and ontologies
    /// <see href="http://ontology.ethereal.cz/irao/DataModel"></see></summary>
    let DataModel = Namespaced_IRI.parse _namespace_name "DataModel" |> NamespacedName
    /// <summary>
    /// A model is a type of research artifact that can be used to describe other artifacts such as a dataset or a software
    /// <see href="http://ontology.ethereal.cz/irao/Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// A plan or specification for the construction or production of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Design"></see></summary>
    let Design = Namespaced_IRI.parse _namespace_name "Design" |> NamespacedName

    /// <summary>
    /// A design quality involves the usage of recommended standards, protocols, frameworks, methodologies
    /// <see href="http://ontology.ethereal.cz/irao/DesignQuality"></see></summary>
    let DesignQuality =
        Namespaced_IRI.parse _namespace_name "DesignQuality" |> NamespacedName

    /// <summary>
    /// The development status of a research artifact, informing about its maturity
    /// <see href="http://ontology.ethereal.cz/irao/DevelopmentStatus"></see></summary>
    let DevelopmentStatus =
        Namespaced_IRI.parse _namespace_name "DevelopmentStatus" |> NamespacedName

    /// <summary>
    /// The framework is a type of an informatics research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Framework"></see></summary>
    let Framework = Namespaced_IRI.parse _namespace_name "Framework" |> NamespacedName

    /// <summary>
    /// A research artifact is a direct output or result of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchArtifact"></see></summary>
    let ResearchArtifact =
        Namespaced_IRI.parse _namespace_name "ResearchArtifact" |> NamespacedName

    /// <summary>
    /// A license authorizes the use, performace, or release of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName

    /// <summary>
    /// The type of a license
    /// <see href="http://ontology.ethereal.cz/irao/LicenseType"></see></summary>
    let LicenseType =
        Namespaced_IRI.parse _namespace_name "LicenseType" |> NamespacedName

    /// <summary>
    /// Methodology is a type of research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Methodology"></see></summary>
    let Methodology =
        Namespaced_IRI.parse _namespace_name "Methodology" |> NamespacedName

    /// <summary>
    /// A middleware is a type of software that is used to connect software components in to a system
    /// <see href="http://ontology.ethereal.cz/irao/Middleware"></see></summary>
    let Middleware = Namespaced_IRI.parse _namespace_name "Middleware" |> NamespacedName
    /// <summary>
    /// A software is a type of informatics research artifact
    /// <see href="http://ontology.ethereal.cz/irao/Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    /// An ontology is a type of data model used to describe linked datasets
    /// <see href="http://ontology.ethereal.cz/irao/Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// An ontology design pattern is a pattern used in designing ontologies
    /// <see href="http://ontology.ethereal.cz/irao/OntologyDesignPattern"></see></summary>
    let OntologyDesignPattern =
        Namespaced_IRI.parse _namespace_name "OntologyDesignPattern" |> NamespacedName

    /// <summary>
    /// A open standard is a standard used to provide guidelines for the development and operations of artifacts and systems
    /// <see href="http://ontology.ethereal.cz/irao/OpenStandard"></see></summary>
    let OpenStandard =
        Namespaced_IRI.parse _namespace_name "OpenStandard" |> NamespacedName

    /// <summary>
    /// A protocol is used to provide guidelines to execute certain tasks
    /// <see href="http://ontology.ethereal.cz/irao/Protocol"></see></summary>
    let Protocol = Namespaced_IRI.parse _namespace_name "Protocol" |> NamespacedName

    /// <summary>
    /// A research output is the result of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchOutput"></see></summary>
    let ResearchOutput =
        Namespaced_IRI.parse _namespace_name "ResearchOutput" |> NamespacedName

    /// <summary>
    /// A repository is an online storage for the deposit of research artifacts such as datasets and vocabularies
    /// <see href="http://ontology.ethereal.cz/irao/Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// A repository type can be a knowledge base, knowledge graph, version control hosting, etc.
    /// <see href="http://ontology.ethereal.cz/irao/RepositoryType"></see></summary>
    let RepositoryType =
        Namespaced_IRI.parse _namespace_name "RepositoryType" |> NamespacedName

    /// <summary>
    /// A research domain is the domain of interest of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchDomain"></see></summary>
    let ResearchDomain =
        Namespaced_IRI.parse _namespace_name "ResearchDomain" |> NamespacedName

    /// <summary>
    /// A research field is the field of interest of a research project
    /// <see href="http://ontology.ethereal.cz/irao/ResearchField"></see></summary>
    let ResearchField =
        Namespaced_IRI.parse _namespace_name "ResearchField" |> NamespacedName

    /// <summary>
    /// A research project is a project within the research domain with the endeavor of achieving scientific results
    /// <see href="http://ontology.ethereal.cz/irao/ResearchProject"></see></summary>
    let ResearchProject =
        Namespaced_IRI.parse _namespace_name "ResearchProject" |> NamespacedName

    /// <summary>
    /// A researcher is a person doing research
    /// <see href="http://ontology.ethereal.cz/irao/Researcher"></see></summary>
    let Researcher = Namespaced_IRI.parse _namespace_name "Researcher" |> NamespacedName

    /// <summary>
    /// Synthetic datasets are generated through computer programs, instead of being composed through the documentation of real-world events
    /// <see href="http://ontology.ethereal.cz/irao/SyntheticDataset"></see></summary>
    let SyntheticDataset =
        Namespaced_IRI.parse _namespace_name "SyntheticDataset" |> NamespacedName

    /// <summary>
    /// A system is a group of interacting or interrelated informatics components that form a unified whole
    /// <see href="http://ontology.ethereal.cz/irao/System"></see></summary>
    let System = Namespaced_IRI.parse _namespace_name "System" |> NamespacedName
    /// <summary>
    /// A thesis as a type of scientific or academic publication or dissertation is a document submitted in support of candidature for an academic degree or professional qualification presenting the author's research and findings
    /// <see href="http://ontology.ethereal.cz/irao/Thesis"></see></summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName
    /// <summary>
    /// A vocabulary is used to provide a range of commonly used terms and their definitions
    /// <see href="http://ontology.ethereal.cz/irao/Vocabulary"></see></summary>
    let Vocabulary = Namespaced_IRI.parse _namespace_name "Vocabulary" |> NamespacedName

    /// <summary>
    /// A web framework is a type of software framework that is used to develop applications on the web
    /// <see href="http://ontology.ethereal.cz/irao/WebFramework"></see></summary>
    let WebFramework =
        Namespaced_IRI.parse _namespace_name "WebFramework" |> NamespacedName

    /// <summary>
    /// A workflow is a sequence of interrelated, orchestrated and repeatable tasks
    /// <see href="http://ontology.ethereal.cz/irao/Workflow"></see></summary>
    let Workflow = Namespaced_IRI.parse _namespace_name "Workflow" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#API"></see>
    /// </summary>
    let ``accessibility#API`` =
        Namespaced_IRI.parse _namespace_name "accessibility#API" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#Download"></see>
    /// </summary>
    let ``accessibility#Download`` =
        Namespaced_IRI.parse _namespace_name "accessibility#Download" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#OpenData"></see>
    /// </summary>
    let ``accessibility#OpenData`` =
        Namespaced_IRI.parse _namespace_name "accessibility#OpenData" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/accessibility#OpenSource"></see>
    /// </summary>
    let ``accessibility#OpenSource`` =
        Namespaced_IRI.parse _namespace_name "accessibility#OpenSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/designquality#FAIR"></see>
    /// </summary>
    let ``designquality#FAIR`` =
        Namespaced_IRI.parse _namespace_name "designquality#FAIR" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/designquality#Reuse"></see>
    /// </summary>
    let ``designquality#Reuse`` =
        Namespaced_IRI.parse _namespace_name "designquality#Reuse" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#alpha"></see>
    /// </summary>
    let ``developmentstatus#alpha`` =
        Namespaced_IRI.parse _namespace_name "developmentstatus#alpha" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#beta"></see>
    /// </summary>
    let ``developmentstatus#beta`` =
        Namespaced_IRI.parse _namespace_name "developmentstatus#beta" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/developmentstatus#release"></see>
    /// </summary>
    let ``developmentstatus#release`` =
        Namespaced_IRI.parse _namespace_name "developmentstatus#release" |> NamespacedName

    /// <summary>
    /// This property specifies the accessibility of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasAccessibility"></see></summary>
    let hasAccessibility =
        Namespaced_IRI.parse _namespace_name "hasAccessibility" |> NamespacedName

    /// <summary>
    /// This property specifies the affiliation of a researcher
    /// <see href="http://ontology.ethereal.cz/irao/hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// This property specifies the author of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName
    /// <summary>
    /// This property specifies the design of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDesign"></see></summary>
    let hasDesign = Namespaced_IRI.parse _namespace_name "hasDesign" |> NamespacedName

    /// <summary>
    /// This property specifies the design quality of a design
    /// <see href="http://ontology.ethereal.cz/irao/hasDesignQuality"></see></summary>
    let hasDesignQuality =
        Namespaced_IRI.parse _namespace_name "hasDesignQuality" |> NamespacedName

    /// <summary>
    /// This property specifies the development status of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDevelopmentStatus"></see></summary>
    let hasDevelopmentStatus =
        Namespaced_IRI.parse _namespace_name "hasDevelopmentStatus" |> NamespacedName

    /// <summary>
    /// This property specifies the research domain of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasDomain"></see></summary>
    let hasDomain = Namespaced_IRI.parse _namespace_name "hasDomain" |> NamespacedName
    /// <summary>
    /// This property specifies the research field of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasField"></see></summary>
    let hasField = Namespaced_IRI.parse _namespace_name "hasField" |> NamespacedName

    /// <summary>
    /// This property specifies the protocol that a benchmark follows
    /// <see href="http://ontology.ethereal.cz/irao/hasFollowedProtocol"></see></summary>
    let hasFollowedProtocol =
        Namespaced_IRI.parse _namespace_name "hasFollowedProtocol" |> NamespacedName

    /// <summary>
    /// This property specifies the framework used by a software
    /// <see href="http://ontology.ethereal.cz/irao/hasFramework"></see></summary>
    let hasFramework =
        Namespaced_IRI.parse _namespace_name "hasFramework" |> NamespacedName

    /// <summary>
    /// This property specifies the license of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasLicense"></see></summary>
    let hasLicense = Namespaced_IRI.parse _namespace_name "hasLicense" |> NamespacedName

    /// <summary>
    /// This property specifies the type of a license
    /// <see href="http://ontology.ethereal.cz/irao/hasLicenseType"></see></summary>
    let hasLicenseType =
        Namespaced_IRI.parse _namespace_name "hasLicenseType" |> NamespacedName

    /// <summary>
    /// This property specifies the maintainer of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasMaintainer"></see></summary>
    let hasMaintainer =
        Namespaced_IRI.parse _namespace_name "hasMaintainer" |> NamespacedName

    /// <summary>
    /// This property specifies a system that measures a benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasMeasuringSystem"></see></summary>
    let hasMeasuringSystem =
        Namespaced_IRI.parse _namespace_name "hasMeasuringSystem" |> NamespacedName

    /// <summary>
    /// This property specifies the methodology used by a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasMethodology"></see></summary>
    let hasMethodology =
        Namespaced_IRI.parse _namespace_name "hasMethodology" |> NamespacedName

    /// <summary>
    /// This property specifies the open standard used by a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasOpenStandard"></see></summary>
    let hasOpenStandard =
        Namespaced_IRI.parse _namespace_name "hasOpenStandard" |> NamespacedName

    /// <summary>
    /// This property specifies the dataset which us produced by a benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasProducedDataset"></see></summary>
    let hasProducedDataset =
        Namespaced_IRI.parse _namespace_name "hasProducedDataset" |> NamespacedName

    /// <summary>
    /// This property specifies the publication of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasPublication"></see></summary>
    let hasPublication =
        Namespaced_IRI.parse _namespace_name "hasPublication" |> NamespacedName

    /// <summary>
    /// This property specifies a benchmark referred by another benchmark
    /// <see href="http://ontology.ethereal.cz/irao/hasReferredBenchmark"></see></summary>
    let hasReferredBenchmark =
        Namespaced_IRI.parse _namespace_name "hasReferredBenchmark" |> NamespacedName

    /// <summary>
    /// This property specifies the repository type of a research artifact repository
    /// <see href="http://ontology.ethereal.cz/irao/hasRepositoryType"></see></summary>
    let hasRepositoryType =
        Namespaced_IRI.parse _namespace_name "hasRepositoryType" |> NamespacedName

    /// <summary>
    /// This property specifies the research area of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasResearchArea"></see></summary>
    let hasResearchArea =
        Namespaced_IRI.parse _namespace_name "hasResearchArea" |> NamespacedName

    /// <summary>
    /// This property specifies the research output of a research project
    /// <see href="http://ontology.ethereal.cz/irao/hasResearchOutput"></see></summary>
    let hasResearchOutput =
        Namespaced_IRI.parse _namespace_name "hasResearchOutput" |> NamespacedName

    /// <summary>
    /// This property specifies the topic of a publication
    /// <see href="http://ontology.ethereal.cz/irao/hasTopic"></see></summary>
    let hasTopic = Namespaced_IRI.parse _namespace_name "hasTopic" |> NamespacedName
    /// <summary>
    /// This property specifies the resource URL of a publication, repository or research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName

    /// <summary>
    /// This property specifies the framework used by a research artifact like software or system
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedFramework"></see></summary>
    let hasUsedFramework =
        Namespaced_IRI.parse _namespace_name "hasUsedFramework" |> NamespacedName

    /// <summary>
    /// This property specifies the methodology used in a research artifact like framework or dataset
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedMethodology"></see></summary>
    let hasUsedMethodology =
        Namespaced_IRI.parse _namespace_name "hasUsedMethodology" |> NamespacedName

    /// <summary>
    /// This property specifies the ontology design pattern of an ontology or another ontology design pattern
    /// <see href="http://ontology.ethereal.cz/irao/hasUsedOntologyDesignPattern"></see></summary>
    let hasUsedOntologyDesignPattern =
        Namespaced_IRI.parse _namespace_name "hasUsedOntologyDesignPattern" |> NamespacedName

    /// <summary>
    /// This property specifies the version of a research artifact
    /// <see href="http://ontology.ethereal.cz/irao/hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// This property specifies the data model of a dataset
    /// <see href="http://ontology.ethereal.cz/irao/isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// This property specifies that a research project is followed by another research project
    /// <see href="http://ontology.ethereal.cz/irao/isFollowedBy"></see></summary>
    let isFollowedBy =
        Namespaced_IRI.parse _namespace_name "isFollowedBy" |> NamespacedName

    /// <summary>
    /// This property specifies the system which a software is part of
    /// <see href="http://ontology.ethereal.cz/irao/isPartOfSystem"></see></summary>
    let isPartOfSystem =
        Namespaced_IRI.parse _namespace_name "isPartOfSystem" |> NamespacedName

    /// <summary>
    /// This property specifies the repository that a research artifact is published at
    /// <see href="http://ontology.ethereal.cz/irao/isPublishedAt"></see></summary>
    let isPublishedAt =
        Namespaced_IRI.parse _namespace_name "isPublishedAt" |> NamespacedName

    /// <summary>
    /// This property specifies that a research artifact is used by another research artifact
    /// <see href="http://ontology.ethereal.cz/irao/isUsedBy"></see></summary>
    let isUsedBy = Namespaced_IRI.parse _namespace_name "isUsedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#RDF"></see>
    /// </summary>
    let ``openstandard#RDF`` =
        Namespaced_IRI.parse _namespace_name "openstandard#RDF" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#RDFS"></see>
    /// </summary>
    let ``openstandard#RDFS`` =
        Namespaced_IRI.parse _namespace_name "openstandard#RDFS" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#SKOS"></see>
    /// </summary>
    let ``openstandard#SKOS`` =
        Namespaced_IRI.parse _namespace_name "openstandard#SKOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#SPARQL"></see>
    /// </summary>
    let ``openstandard#SPARQL`` =
        Namespaced_IRI.parse _namespace_name "openstandard#SPARQL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/openstandard#XML"></see>
    /// </summary>
    let ``openstandard#XML`` =
        Namespaced_IRI.parse _namespace_name "openstandard#XML" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/repositorytype#KnowledgeBase"></see>
    /// </summary>
    let ``repositorytype#KnowledgeBase`` =
        Namespaced_IRI.parse _namespace_name "repositorytype#KnowledgeBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.ethereal.cz/irao/repositorytype#VersionControlHosting"></see>
    /// </summary>
    let ``repositorytype#VersionControlHosting`` =
        Namespaced_IRI.parse _namespace_name "repositorytype#VersionControlHosting" |> NamespacedName
