namespace http.ontology.ethereal.cz.irao.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module irao =
    let _namespace_iri = Namespace_Iri irao |> NamespaceIRI
    /// <summary>
    ///   <para>irao:API</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An API is a type of service-based research artifact"</para>
    /// labels<para>"API"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/API">http://ontology.ethereal.cz/irao/API</seealso>
    let API = Prefixed_Name(irao, "API") |> PrefixedName
    /// <summary>
    ///   <para>irao:Accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research artifact can be made accessible via download or some kind of API, etc."</para>
    /// labels<para>"Accessibility"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Accessibility">http://ontology.ethereal.cz/irao/Accessibility</seealso>
    let Accessibility = Prefixed_Name(irao, "Accessibility") |> PrefixedName
    /// <summary>
    ///   <para>irao:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affiliation of the author, it maybe a company or an institution"</para>
    /// labels<para>"Affiliation"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Affiliation">http://ontology.ethereal.cz/irao/Affiliation</seealso>
    let Affiliation = Prefixed_Name(irao, "Affiliation") |> PrefixedName
    /// <summary>
    ///   <para>irao:AnnotatedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset which was processed for AI or machine learning"</para>
    /// labels<para>"Annotated Dataset"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/AnnotatedDataset">http://ontology.ethereal.cz/irao/AnnotatedDataset</seealso>
    let AnnotatedDataset = Prefixed_Name(irao, "AnnotatedDataset") |> PrefixedName

    /// <summary>
    ///   <para>irao:ApplicationFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A framework that is used by applications"</para>
    /// labels<para>"Application Framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ApplicationFramework">http://ontology.ethereal.cz/irao/ApplicationFramework</seealso>
    let ApplicationFramework =
        Prefixed_Name(irao, "ApplicationFramework") |> PrefixedName

    /// <summary>
    ///   <para>irao:Benchmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A benchmark is a type of comparison and measuring with metrics, producing datasets and algorithms for comprehensive and systematic evaluation of existing and future systems"</para>
    /// labels<para>"Benchmark"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Benchmark">http://ontology.ethereal.cz/irao/Benchmark</seealso>
    let Benchmark = Prefixed_Name(irao, "Benchmark") |> PrefixedName
    /// <summary>
    ///   <para>irao:ConferencePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper or article published at a scientific conference"</para>
    /// labels<para>"Conference paper"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ConferencePaper">http://ontology.ethereal.cz/irao/ConferencePaper</seealso>
    let ConferencePaper = Prefixed_Name(irao, "ConferencePaper") |> PrefixedName
    /// <summary>
    ///   <para>irao:DataModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data model such as schema and ontologies"</para>
    /// labels<para>"Data model"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/DataModel">http://ontology.ethereal.cz/irao/DataModel</seealso>
    let DataModel = Prefixed_Name(irao, "DataModel") |> PrefixedName
    /// <summary>
    ///   <para>irao:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset containing the gathered or generated data about some topic"</para>
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Dataset">http://ontology.ethereal.cz/irao/Dataset</seealso>
    let Dataset = Prefixed_Name(irao, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>irao:Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan or specification for the construction or production of a research artifact"</para>
    /// labels<para>"Design"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Design">http://ontology.ethereal.cz/irao/Design</seealso>
    let Design = Prefixed_Name(irao, "Design") |> PrefixedName
    /// <summary>
    ///   <para>irao:DesignQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A design quality involves the usage of recommended standards, protocols, frameworks, methodologies"</para>
    /// labels<para>"Design quality"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/DesignQuality">http://ontology.ethereal.cz/irao/DesignQuality</seealso>
    let DesignQuality = Prefixed_Name(irao, "DesignQuality") |> PrefixedName
    /// <summary>
    ///   <para>irao:DevelopmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The development status of a research artifact, informing about its maturity"</para>
    /// labels<para>"Development status"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/DevelopmentStatus">http://ontology.ethereal.cz/irao/DevelopmentStatus</seealso>
    let DevelopmentStatus = Prefixed_Name(irao, "DevelopmentStatus") |> PrefixedName
    /// <summary>
    ///   <para>irao:Framework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The framework is a type of an informatics research artifact"</para>
    /// labels<para>"Framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Framework">http://ontology.ethereal.cz/irao/Framework</seealso>
    let Framework = Prefixed_Name(irao, "Framework") |> PrefixedName

    /// <summary>
    ///   <para>irao:InformaticsResearchArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An informatics research artifact is a research artifact in the informatics field"</para>
    /// labels<para>"Informatics Research Artifact"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/InformaticsResearchArtifact">http://ontology.ethereal.cz/irao/InformaticsResearchArtifact</seealso>
    let InformaticsResearchArtifact =
        Prefixed_Name(irao, "InformaticsResearchArtifact") |> PrefixedName

    /// <summary>
    ///   <para>irao:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A license authorizes the use, performace, or release of a research artifact"</para>
    /// labels<para>"License"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/License">http://ontology.ethereal.cz/irao/License</seealso>
    let License = Prefixed_Name(irao, "License") |> PrefixedName
    /// <summary>
    ///   <para>irao:LicenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of a license"</para>
    /// labels<para>"License type"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/LicenseType">http://ontology.ethereal.cz/irao/LicenseType</seealso>
    let LicenseType = Prefixed_Name(irao, "LicenseType") |> PrefixedName
    /// <summary>
    ///   <para>irao:Methodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Methodology is a type of research artifact"</para>
    /// labels<para>"Methodology"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Methodology">http://ontology.ethereal.cz/irao/Methodology</seealso>
    let Methodology = Prefixed_Name(irao, "Methodology") |> PrefixedName
    /// <summary>
    ///   <para>irao:Middleware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A middleware is a type of software that is used to connect software components in to a system"</para>
    /// labels<para>"Middleware"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Middleware">http://ontology.ethereal.cz/irao/Middleware</seealso>
    let Middleware = Prefixed_Name(irao, "Middleware") |> PrefixedName
    /// <summary>
    ///   <para>irao:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A model is a type of research artifact that can be used to describe other artifacts such as a dataset or a software"</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Model">http://ontology.ethereal.cz/irao/Model</seealso>
    let Model = Prefixed_Name(irao, "Model") |> PrefixedName
    /// <summary>
    ///   <para>irao:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ontology is a type of data model used to describe linked datasets"</para>
    /// labels<para>"Ontology"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Ontology">http://ontology.ethereal.cz/irao/Ontology</seealso>
    let Ontology = Prefixed_Name(irao, "Ontology") |> PrefixedName

    /// <summary>
    ///   <para>irao:OntologyDesignPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ontology design pattern is a pattern used in designing ontologies"</para>
    /// labels<para>"Ontology design pattern"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/OntologyDesignPattern">http://ontology.ethereal.cz/irao/OntologyDesignPattern</seealso>
    let OntologyDesignPattern =
        Prefixed_Name(irao, "OntologyDesignPattern") |> PrefixedName

    /// <summary>
    ///   <para>irao:OpenStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A open standard is a standard used to provide guidelines for the development and operations of artifacts and systems"</para>
    /// labels<para>"Open Standard"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/OpenStandard">http://ontology.ethereal.cz/irao/OpenStandard</seealso>
    let OpenStandard = Prefixed_Name(irao, "OpenStandard") |> PrefixedName
    /// <summary>
    ///   <para>irao:Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A protocol is used to provide guidelines to execute certain tasks"</para>
    /// labels<para>"Protocol"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Protocol">http://ontology.ethereal.cz/irao/Protocol</seealso>
    let Protocol = Prefixed_Name(irao, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>irao:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A publication makes content and research results available to the general public via publication venues such as journals, books, websites, etc."</para>
    /// labels<para>"Publication"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Publication">http://ontology.ethereal.cz/irao/Publication</seealso>
    let Publication = Prefixed_Name(irao, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>irao:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A repository is an online storage for the deposit of research artifacts such as datasets and vocabularies"</para>
    /// labels<para>"Repository"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Repository">http://ontology.ethereal.cz/irao/Repository</seealso>
    let Repository = Prefixed_Name(irao, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>irao:RepositoryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A repository type can be a knowledge base, knowledge graph, version control hosting, etc."</para>
    /// labels<para>"Repository Type"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/RepositoryType">http://ontology.ethereal.cz/irao/RepositoryType</seealso>
    let RepositoryType = Prefixed_Name(irao, "RepositoryType") |> PrefixedName
    /// <summary>
    ///   <para>irao:ResearchArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research artifact is a direct output or result of a research project"</para>
    /// labels<para>"Research Artifact"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ResearchArtifact">http://ontology.ethereal.cz/irao/ResearchArtifact</seealso>
    let ResearchArtifact = Prefixed_Name(irao, "ResearchArtifact") |> PrefixedName
    /// <summary>
    ///   <para>irao:ResearchDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research domain is the domain of interest of a research project"</para>
    /// labels<para>"Research Domain"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ResearchDomain">http://ontology.ethereal.cz/irao/ResearchDomain</seealso>
    let ResearchDomain = Prefixed_Name(irao, "ResearchDomain") |> PrefixedName
    /// <summary>
    ///   <para>irao:ResearchField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research field is the field of interest of a research project"</para>
    /// labels<para>"Research Field"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ResearchField">http://ontology.ethereal.cz/irao/ResearchField</seealso>
    let ResearchField = Prefixed_Name(irao, "ResearchField") |> PrefixedName
    /// <summary>
    ///   <para>irao:ResearchOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research output is the result of a research project"</para>
    /// labels<para>"Research output"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ResearchOutput">http://ontology.ethereal.cz/irao/ResearchOutput</seealso>
    let ResearchOutput = Prefixed_Name(irao, "ResearchOutput") |> PrefixedName
    /// <summary>
    ///   <para>irao:ResearchProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research project is a project within the research domain with the endeavor of achieving scientific results"</para>
    /// labels<para>"Research project"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/ResearchProject">http://ontology.ethereal.cz/irao/ResearchProject</seealso>
    let ResearchProject = Prefixed_Name(irao, "ResearchProject") |> PrefixedName
    /// <summary>
    ///   <para>irao:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A researcher is a person doing research"</para>
    /// labels<para>"Researcher"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Researcher">http://ontology.ethereal.cz/irao/Researcher</seealso>
    let Researcher = Prefixed_Name(irao, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>irao:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A service is a type of software that provides e.g. data or some type of functionalities"</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Service">http://ontology.ethereal.cz/irao/Service</seealso>
    let Service = Prefixed_Name(irao, "Service") |> PrefixedName
    /// <summary>
    ///   <para>irao:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software is a type of informatics research artifact"</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Software">http://ontology.ethereal.cz/irao/Software</seealso>
    let Software = Prefixed_Name(irao, "Software") |> PrefixedName
    /// <summary>
    ///   <para>irao:SoftwareFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software framework is a type of software that provides guidelines for the development of new softwares"</para>
    /// labels<para>"Software Framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/SoftwareFramework">http://ontology.ethereal.cz/irao/SoftwareFramework</seealso>
    let SoftwareFramework = Prefixed_Name(irao, "SoftwareFramework") |> PrefixedName
    /// <summary>
    ///   <para>irao:SyntheticDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Synthetic datasets are generated through computer programs, instead of being composed through the documentation of real-world events"</para>
    /// labels<para>"Synthetic Dataset"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/SyntheticDataset">http://ontology.ethereal.cz/irao/SyntheticDataset</seealso>
    let SyntheticDataset = Prefixed_Name(irao, "SyntheticDataset") |> PrefixedName
    /// <summary>
    ///   <para>irao:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system is a group of interacting or interrelated informatics components that form a unified whole"</para>
    /// labels<para>"System"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/System">http://ontology.ethereal.cz/irao/System</seealso>
    let System = Prefixed_Name(irao, "System") |> PrefixedName
    /// <summary>
    ///   <para>irao:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis as a type of scientific or academic publication or dissertation is a document submitted in support of candidature for an academic degree or professional qualification presenting the author's research and findings"</para>
    /// labels<para>"Thesis"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Thesis">http://ontology.ethereal.cz/irao/Thesis</seealso>
    let Thesis = Prefixed_Name(irao, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>irao:Vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vocabulary is used to provide a range of commonly used terms and their definitions"</para>
    /// labels<para>"Vocabulary"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Vocabulary">http://ontology.ethereal.cz/irao/Vocabulary</seealso>
    let Vocabulary = Prefixed_Name(irao, "Vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>irao:WebFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A web framework is a type of software framework that is used to develop applications on the web"</para>
    /// labels<para>"Web Framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/WebFramework">http://ontology.ethereal.cz/irao/WebFramework</seealso>
    let WebFramework = Prefixed_Name(irao, "WebFramework") |> PrefixedName
    /// <summary>
    ///   <para>irao:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A workflow is a sequence of interrelated, orchestrated and repeatable tasks"</para>
    /// labels<para>"Workflow"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/Workflow">http://ontology.ethereal.cz/irao/Workflow</seealso>
    let Workflow = Prefixed_Name(irao, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>irao:accessibility#API</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:Accessibility</para>
    ///
    /// labels<para>"API"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/accessibility#API">http://ontology.ethereal.cz/irao/accessibility#API</seealso>
    let ``accessibility#API`` = Prefixed_Name(irao, "accessibility#API") |> PrefixedName

    /// <summary>
    ///   <para>irao:accessibility#Download</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:Accessibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Download"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/accessibility#Download">http://ontology.ethereal.cz/irao/accessibility#Download</seealso>
    let ``accessibility#Download`` =
        Prefixed_Name(irao, "accessibility#Download") |> PrefixedName

    /// <summary>
    ///   <para>irao:accessibility#OpenData</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:Accessibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Open Data"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/accessibility#OpenData">http://ontology.ethereal.cz/irao/accessibility#OpenData</seealso>
    let ``accessibility#OpenData`` =
        Prefixed_Name(irao, "accessibility#OpenData") |> PrefixedName

    /// <summary>
    ///   <para>irao:accessibility#OpenSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:Accessibility</para>
    ///
    /// labels<para>"Opensource"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/accessibility#OpenSource">http://ontology.ethereal.cz/irao/accessibility#OpenSource</seealso>
    let ``accessibility#OpenSource`` =
        Prefixed_Name(irao, "accessibility#OpenSource") |> PrefixedName

    /// <summary>
    ///   <para>irao:designquality#FAIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:DesignQuality</para>
    ///
    /// labels<para>"FAIR"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/designquality#FAIR">http://ontology.ethereal.cz/irao/designquality#FAIR</seealso>
    let ``designquality#FAIR`` =
        Prefixed_Name(irao, "designquality#FAIR") |> PrefixedName

    /// <summary>
    ///   <para>irao:designquality#Reuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:DesignQuality</para>
    ///
    /// labels<para>"Reuse"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/designquality#Reuse">http://ontology.ethereal.cz/irao/designquality#Reuse</seealso>
    let ``designquality#Reuse`` =
        Prefixed_Name(irao, "designquality#Reuse") |> PrefixedName

    /// <summary>
    ///   <para>irao:developmentstatus#alpha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:DevelopmentStatus</para>
    ///
    /// labels<para>"Alpha"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/developmentstatus#alpha">http://ontology.ethereal.cz/irao/developmentstatus#alpha</seealso>
    let ``developmentstatus#alpha`` =
        Prefixed_Name(irao, "developmentstatus#alpha") |> PrefixedName

    /// <summary>
    ///   <para>irao:developmentstatus#beta</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:DevelopmentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Beta"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/developmentstatus#beta">http://ontology.ethereal.cz/irao/developmentstatus#beta</seealso>
    let ``developmentstatus#beta`` =
        Prefixed_Name(irao, "developmentstatus#beta") |> PrefixedName

    /// <summary>
    ///   <para>irao:developmentstatus#release</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:DevelopmentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Release"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/developmentstatus#release">http://ontology.ethereal.cz/irao/developmentstatus#release</seealso>
    let ``developmentstatus#release`` =
        Prefixed_Name(irao, "developmentstatus#release") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the accessibility of a research artifact"</para>
    /// labels<para>"has accessibility"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasAccessibility">http://ontology.ethereal.cz/irao/hasAccessibility</seealso>
    let hasAccessibility = Prefixed_Name(irao, "hasAccessibility") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the affiliation of a researcher"</para>
    /// labels<para>"has affiliation"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasAffiliation">http://ontology.ethereal.cz/irao/hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(irao, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the author of a research artifact"</para>
    /// labels<para>"has author"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasAuthor">http://ontology.ethereal.cz/irao/hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(irao, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the design of a research artifact"</para>
    /// labels<para>"has design"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasDesign">http://ontology.ethereal.cz/irao/hasDesign</seealso>
    let hasDesign = Prefixed_Name(irao, "hasDesign") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasDesignQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the design quality of a design"</para>
    /// labels<para>"has design quality"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasDesignQuality">http://ontology.ethereal.cz/irao/hasDesignQuality</seealso>
    let hasDesignQuality = Prefixed_Name(irao, "hasDesignQuality") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasDevelopmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the development status of a research artifact"</para>
    /// labels<para>"has development status"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasDevelopmentStatus">http://ontology.ethereal.cz/irao/hasDevelopmentStatus</seealso>
    let hasDevelopmentStatus =
        Prefixed_Name(irao, "hasDevelopmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the research domain of a research artifact"</para>
    /// labels<para>"has domain"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasDomain">http://ontology.ethereal.cz/irao/hasDomain</seealso>
    let hasDomain = Prefixed_Name(irao, "hasDomain") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the research field of a research artifact"</para>
    /// labels<para>"has field"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasField">http://ontology.ethereal.cz/irao/hasField</seealso>
    let hasField = Prefixed_Name(irao, "hasField") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasFollowedProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the protocol that a benchmark follows"</para>
    /// labels<para>"has followed protocol"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasFollowedProtocol">http://ontology.ethereal.cz/irao/hasFollowedProtocol</seealso>
    let hasFollowedProtocol = Prefixed_Name(irao, "hasFollowedProtocol") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the framework used by a software"</para>
    /// labels<para>"has framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasFramework">http://ontology.ethereal.cz/irao/hasFramework</seealso>
    let hasFramework = Prefixed_Name(irao, "hasFramework") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the license of a research artifact"</para>
    /// labels<para>"has license"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasLicense">http://ontology.ethereal.cz/irao/hasLicense</seealso>
    let hasLicense = Prefixed_Name(irao, "hasLicense") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasLicenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the type of a license"</para>
    /// labels<para>"has license type"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasLicenseType">http://ontology.ethereal.cz/irao/hasLicenseType</seealso>
    let hasLicenseType = Prefixed_Name(irao, "hasLicenseType") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasMaintainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the maintainer of a research artifact"</para>
    /// labels<para>"is maintained by"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasMaintainer">http://ontology.ethereal.cz/irao/hasMaintainer</seealso>
    let hasMaintainer = Prefixed_Name(irao, "hasMaintainer") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasMeasuringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies a system that measures a benchmark"</para>
    /// labels<para>"has measuring system"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasMeasuringSystem">http://ontology.ethereal.cz/irao/hasMeasuringSystem</seealso>
    let hasMeasuringSystem = Prefixed_Name(irao, "hasMeasuringSystem") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the methodology used by a research artifact"</para>
    /// labels<para>"has methodology"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasMethodology">http://ontology.ethereal.cz/irao/hasMethodology</seealso>
    let hasMethodology = Prefixed_Name(irao, "hasMethodology") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasOpenStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the open standard used by a research artifact"</para>
    /// labels<para>"has open standard"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasOpenStandard">http://ontology.ethereal.cz/irao/hasOpenStandard</seealso>
    let hasOpenStandard = Prefixed_Name(irao, "hasOpenStandard") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasProducedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the dataset which us produced by a benchmark"</para>
    /// labels<para>"has produced dataset"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasProducedDataset">http://ontology.ethereal.cz/irao/hasProducedDataset</seealso>
    let hasProducedDataset = Prefixed_Name(irao, "hasProducedDataset") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the publication of a research artifact"</para>
    /// labels<para>"has publication"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasPublication">http://ontology.ethereal.cz/irao/hasPublication</seealso>
    let hasPublication = Prefixed_Name(irao, "hasPublication") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasReferredBenchmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies a benchmark referred by another benchmark"</para>
    /// labels<para>"has referred benchmark"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasReferredBenchmark">http://ontology.ethereal.cz/irao/hasReferredBenchmark</seealso>
    let hasReferredBenchmark =
        Prefixed_Name(irao, "hasReferredBenchmark") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasRepositoryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the repository type of a research artifact repository"</para>
    /// labels<para>"has repository type"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasRepositoryType">http://ontology.ethereal.cz/irao/hasRepositoryType</seealso>
    let hasRepositoryType = Prefixed_Name(irao, "hasRepositoryType") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasResearchArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the research area of a research artifact"</para>
    /// labels<para>"has research area"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasResearchArea">http://ontology.ethereal.cz/irao/hasResearchArea</seealso>
    let hasResearchArea = Prefixed_Name(irao, "hasResearchArea") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasResearchOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the research output of a research project"</para>
    /// labels<para>"has research output"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasResearchOutput">http://ontology.ethereal.cz/irao/hasResearchOutput</seealso>
    let hasResearchOutput = Prefixed_Name(irao, "hasResearchOutput") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the topic of a publication"</para>
    /// labels<para>"has topic"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasTopic">http://ontology.ethereal.cz/irao/hasTopic</seealso>
    let hasTopic = Prefixed_Name(irao, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the resource URL of a publication, repository or research artifact"</para>
    /// labels<para>"has URL"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasURL">http://ontology.ethereal.cz/irao/hasURL</seealso>
    let hasURL = Prefixed_Name(irao, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasUsedFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the framework used by a research artifact like software or system"</para>
    /// labels<para>"has used framework"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasUsedFramework">http://ontology.ethereal.cz/irao/hasUsedFramework</seealso>
    let hasUsedFramework = Prefixed_Name(irao, "hasUsedFramework") |> PrefixedName
    /// <summary>
    ///   <para>irao:hasUsedMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the methodology used in a research artifact like framework or dataset"</para>
    /// labels<para>"has used methodology"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasUsedMethodology">http://ontology.ethereal.cz/irao/hasUsedMethodology</seealso>
    let hasUsedMethodology = Prefixed_Name(irao, "hasUsedMethodology") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasUsedOntologyDesignPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the ontology design pattern of an ontology or another ontology design pattern"</para>
    /// labels<para>"has used ontology design pattern"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasUsedOntologyDesignPattern">http://ontology.ethereal.cz/irao/hasUsedOntologyDesignPattern</seealso>
    let hasUsedOntologyDesignPattern =
        Prefixed_Name(irao, "hasUsedOntologyDesignPattern") |> PrefixedName

    /// <summary>
    ///   <para>irao:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the version of a research artifact"</para>
    /// labels<para>"has version"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/hasVersion">http://ontology.ethereal.cz/irao/hasVersion</seealso>
    let hasVersion = Prefixed_Name(irao, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>irao:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the data model of a dataset"</para>
    /// labels<para>"is described by"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/isDescribedBy">http://ontology.ethereal.cz/irao/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(irao, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>irao:isFollowedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that a research project is followed by another research project"</para>
    /// labels<para>"is followed by"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/isFollowedBy">http://ontology.ethereal.cz/irao/isFollowedBy</seealso>
    let isFollowedBy = Prefixed_Name(irao, "isFollowedBy") |> PrefixedName
    /// <summary>
    ///   <para>irao:isPartOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the system which a software is part of"</para>
    /// labels<para>"is part of system"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/isPartOfSystem">http://ontology.ethereal.cz/irao/isPartOfSystem</seealso>
    let isPartOfSystem = Prefixed_Name(irao, "isPartOfSystem") |> PrefixedName
    /// <summary>
    ///   <para>irao:isPublishedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the repository that a research artifact is published at"</para>
    /// labels<para>"is published at"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/isPublishedAt">http://ontology.ethereal.cz/irao/isPublishedAt</seealso>
    let isPublishedAt = Prefixed_Name(irao, "isPublishedAt") |> PrefixedName
    /// <summary>
    ///   <para>irao:isUsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that a research artifact is used by another research artifact"</para>
    /// labels<para>"is used by"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/isUsedBy">http://ontology.ethereal.cz/irao/isUsedBy</seealso>
    let isUsedBy = Prefixed_Name(irao, "isUsedBy") |> PrefixedName
    /// <summary>
    ///   <para>irao:openstandard#RDF</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:OpenStandard</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RDF"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/openstandard#RDF">http://ontology.ethereal.cz/irao/openstandard#RDF</seealso>
    let ``openstandard#RDF`` = Prefixed_Name(irao, "openstandard#RDF") |> PrefixedName
    /// <summary>
    ///   <para>irao:openstandard#RDFS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:OpenStandard</para>
    ///
    /// labels<para>"RDFS"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/openstandard#RDFS">http://ontology.ethereal.cz/irao/openstandard#RDFS</seealso>
    let ``openstandard#RDFS`` = Prefixed_Name(irao, "openstandard#RDFS") |> PrefixedName
    /// <summary>
    ///   <para>irao:openstandard#SKOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:OpenStandard</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SKOS"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/openstandard#SKOS">http://ontology.ethereal.cz/irao/openstandard#SKOS</seealso>
    let ``openstandard#SKOS`` = Prefixed_Name(irao, "openstandard#SKOS") |> PrefixedName

    /// <summary>
    ///   <para>irao:openstandard#SPARQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:OpenStandard</para>
    ///
    /// labels<para>"SPARQL"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/openstandard#SPARQL">http://ontology.ethereal.cz/irao/openstandard#SPARQL</seealso>
    let ``openstandard#SPARQL`` =
        Prefixed_Name(irao, "openstandard#SPARQL") |> PrefixedName

    /// <summary>
    ///   <para>irao:openstandard#XML</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:OpenStandard</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"XML"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/openstandard#XML">http://ontology.ethereal.cz/irao/openstandard#XML</seealso>
    let ``openstandard#XML`` = Prefixed_Name(irao, "openstandard#XML") |> PrefixedName

    /// <summary>
    ///   <para>irao:repositorytype#KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>irao:RepositoryType</para>
    ///
    /// labels<para>"Knowledge base"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/repositorytype#KnowledgeBase">http://ontology.ethereal.cz/irao/repositorytype#KnowledgeBase</seealso>
    let ``repositorytype#KnowledgeBase`` =
        Prefixed_Name(irao, "repositorytype#KnowledgeBase") |> PrefixedName

    /// <summary>
    ///   <para>irao:repositorytype#VersionControlHosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>irao:RepositoryType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Version control hosting"</para></remarks>
    /// <seealso href="http://ontology.ethereal.cz/irao/repositorytype#VersionControlHosting">http://ontology.ethereal.cz/irao/repositorytype#VersionControlHosting</seealso>
    let ``repositorytype#VersionControlHosting`` =
        Prefixed_Name(irao, "repositorytype#VersionControlHosting") |> PrefixedName
