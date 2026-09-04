#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module citedcat =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/citedcat-ap/" "citedcat"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : A data paper describes data provenance and methodologies used in the gathering, processing, organizing, and representing the data [DataCite].</para>
    ///   <para>rdfs:label : Data paper</para>
    ///   <para>rdfs:comment : A factual and objective publication with a focused intent to identify and describe specific data, sets of data, or data collections to facilitate discoverability [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/DataPaper">citedcat:DataPaper</a>
    /// </summary>
    let DataPaper = _prefixId.prefix "DataPaper"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Modelled descriptions of, for example, different aspects of languages or a molecular biology reaction chain [DataCite].</para>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : An abstract, conceptual, graphical, mathematical or visualization model that represents empirical objects, phenomena, or physical processes [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/Model">citedcat:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:comment : A structured series of steps which can be executed to produce a final outcome, allowing users a means to specify and enact their work in a more reproducible manner [DataCite].</para>
    ///   <para>rdfs:label : Workflow</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Computational workflows involving sequential operations made on data by wrapped software and may be specified in a format belonging to a workflow management system, such as Taverna [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/Workflow">citedcat:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:comment : Indicates B is the result of a compile or creation event using A [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : May be used for software and text, as a compiler can be a computer program or a person [DataCite].</para>
    ///   <para>rdfs:label : compiles</para>
    ///   <a href="https://w3id.org/citedcat-ap/compiles">citedcat:compiles</a>
    /// </summary>
    let compiles = _prefixId.prefix "compiles"
    /// <summary>
    ///   <para>rdfs:comment : Indicates A is a continuation of the work B [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : continues</para>
    ///   <a href="https://w3id.org/citedcat-ap/continues">citedcat:continues</a>
    /// </summary>
    let continues = _prefixId.prefix "continues"
    /// <summary>
    ///   <para>rdfs:label : data collector</para>
    ///   <para>skos:scopeNote : May also use when crediting survey conductors, interviewers, event or condition observers, person responsible for monitoring key instrument data [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Person/institution responsible for finding, gathering/collecting data under the guidelines of the author(s) or Principal Investigator (PI) [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/dataCollector">citedcat:dataCollector</a>
    /// </summary>
    let dataCollector = _prefixId.prefix "dataCollector"
    /// <summary>
    ///   <para>skos:scopeNote : While the DataManager is concerned with digital maintenance, the DataCurator’s role encompasses quality assurance focused on content and metadata. DataCurator responsibilities include: checking completeness of the submitted dataset against the content as described by the submitter; verifying standard metadata according to the applicable system or schema; adding or verifying specialized metadata to add value and ensure access across disciplines; and determining how the metadata might map to search engines, database products, and automated feeds. Repository managers as well as data librarians working in the repository fall within this category [DataCite].</para>
    ///   <para>rdfs:comment : Person tasked with reviewing, enhancing, cleaning, or standardizing metadata and the associated data submitted for storage, use, and maintenance within a data centre or repository [DataCite].</para>
    ///   <para>rdfs:label : data curator</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/dataCurator">citedcat:dataCurator</a>
    /// </summary>
    let dataCurator = _prefixId.prefix "dataCurator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Person (or organisation with a staff of data managers, such as a data centre) responsible for maintaining the finished resource [DataCite].</para>
    ///   <para>skos:scopeNote : The work done by this person or organisation ensures that the resource is periodically “refreshed” in terms of software/hardware support, is kept available or is protected from unauthorized access, is stored in accordance with industry standards, and is handled in accordance with the records management requirements applicable to it [DataCite].</para>
    ///   <para>rdfs:label : data manager</para>
    ///   <a href="https://w3id.org/citedcat-ap/dataManager">citedcat:dataManager</a>
    /// </summary>
    let dataManager = _prefixId.prefix "dataManager"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates A describes B [DataCite].</para>
    ///   <para>rdfs:label : describes</para>
    ///   <a href="https://w3id.org/citedcat-ap/describes">citedcat:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : Institution that provided financial support for the development of the resource [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : funder</para>
    ///   <para>skos:scopeNote : Includes organizations that provide funding via regular budget allocations, through grants or awards [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/funder">citedcat:funder</a>
    /// </summary>
    let funder = _prefixId.prefix "funder"
    /// <summary>
    ///   <para>skos:scopeNote : This role normally falls on the University, research center or organization where the data center/data repository belongs. May also be used for an organisation that stores the data offline - often a data centre if that data centre is not the “publisher” of the resource [DataCite].</para>
    ///   <para>rdfs:label : hosting institution</para>
    ///   <para>rdfs:comment : Typically, the organisation allowing the resource to be available on the Internet through the provision of its hardware/software/operating support [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/hostingInstitution">citedcat:hostingInstitution</a>
    /// </summary>
    let hostingInstitution = _prefixId.prefix "hostingInstitution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is awarded by</para>
    ///   <para>rdfs:comment : Agent responsible for awarding financial support to an activity (typically, a project).</para>
    ///   <a href="https://w3id.org/citedcat-ap/isAwardedBy">citedcat:isAwardedBy</a>
    /// </summary>
    let isAwardedBy = _prefixId.prefix "isAwardedBy"
    /// <summary>
    ///   <para>rdfs:label : is compiled by</para>
    ///   <para>rdfs:comment : Indicates B is used to compile or create A [DataCite].</para>
    ///   <para>skos:scopeNote : May be used for software and text, as a compiler can be a computer program or a person [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/isCompiledBy">citedcat:isCompiledBy</a>
    /// </summary>
    let isCompiledBy = _prefixId.prefix "isCompiledBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is continued by</para>
    ///   <para>rdfs:comment : Indicates A is continued by the work B [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/isContinuedBy">citedcat:isContinuedBy</a>
    /// </summary>
    let isContinuedBy = _prefixId.prefix "isContinuedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is funded by</para>
    ///   <para>rdfs:comment : The activity (typically, a project) that provided financial support for the development of the resource.</para>
    ///   <a href="https://w3id.org/citedcat-ap/isFundedBy">citedcat:isFundedBy</a>
    /// </summary>
    let isFundedBy = _prefixId.prefix "isFundedBy"
    /// <summary>
    ///   <para>skos:scopeNote : May be used for different software operating systems or compiler formats, for example [DataCite].</para>
    ///   <para>rdfs:label : is original form of</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates A is the original form of B [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/isOriginalFormOf">citedcat:isOriginalFormOf</a>
    /// </summary>
    let isOriginalFormOf = _prefixId.prefix "isOriginalFormOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that A is reviewed by B [DataCite].</para>
    ///   <para>rdfs:label : is reviewed by</para>
    ///   <a href="https://w3id.org/citedcat-ap/isReviewedBy">citedcat:isReviewedBy</a>
    /// </summary>
    let isReviewedBy = _prefixId.prefix "isReviewedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that A is a supplement to B [DataCite].</para>
    ///   <para>rdfs:label : is supplement to</para>
    ///   <a href="https://w3id.org/citedcat-ap/isSupplementTo">citedcat:isSupplementTo</a>
    /// </summary>
    let isSupplementTo = _prefixId.prefix "isSupplementTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is supplemented by</para>
    ///   <para>rdfs:comment : Indicates that B is a supplement to A [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/isSupplementedBy">citedcat:isSupplementedBy</a>
    /// </summary>
    let isSupplementedBy = _prefixId.prefix "isSupplementedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates A is a variant or different form of B [DataCite].</para>
    ///   <para>rdfs:label : is variant form or</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : Use for a different form of one thing. May be used for different software operating systems or compiler formats, for example [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/isVariantFormOf">citedcat:isVariantFormOf</a>
    /// </summary>
    let isVariantFormOf = _prefixId.prefix "isVariantFormOf"
    /// <summary>
    ///   <para>skos:scopeNote : The Project Leader is not “removed” from the work that resulted in the resource; he or she remains intimately involved throughout the life of the particular project team [DataCite].</para>
    ///   <para>rdfs:label : project leader</para>
    ///   <para>rdfs:comment : Person officially designated as head of project team or sub-project team instrumental in the work necessary to development of the resource [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/projectLeader">citedcat:projectLeader</a>
    /// </summary>
    let projectLeader = _prefixId.prefix "projectLeader"
    /// <summary>
    ///   <para>rdfs:label : project manager</para>
    ///   <para>rdfs:comment : Person officially designated as manager of a project. Project may consist of one or many project teams and sub-teams [DataCite].</para>
    ///   <para>skos:scopeNote : The manager of a project normally has more administrative responsibility than actual work involvement [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/projectManager">citedcat:projectManager</a>
    /// </summary>
    let projectManager = _prefixId.prefix "projectManager"
    /// <summary>
    ///   <para>skos:scopeNote : This vocabulary may or may not indicate the quality, quantity, or substance of the person’s involvement [DataCite].</para>
    ///   <para>rdfs:comment : Person on the membership list of a designated project/project team [DataCite].</para>
    ///   <para>rdfs:label : project member</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/projectMember">citedcat:projectMember</a>
    /// </summary>
    let projectMember = _prefixId.prefix "projectMember"
    /// <summary>
    ///   <para>rdfs:label : registration agency</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:scopeNote : For instance: DataCite is a Registration Agency for the International DOI Foundation (IDF). One of DataCite’s tasks is to assign DOI prefixes to the allocating agents who then assign the full, specific character string to data clients, provide metadata back to the DataCite registry, etc. [DataCite].</para>
    ///   <para>rdfs:comment : Institution/organisation officially appointed by a Registration Authority to handle specific tasks within a defined area of responsibility [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/registrationAgency">citedcat:registrationAgency</a>
    /// </summary>
    let registrationAgency = _prefixId.prefix "registrationAgency"
    /// <summary>
    ///   <para>rdfs:comment : A standards-setting body from which Registration Agencies obtain official recognition and guidance [DataCite].</para>
    ///   <para>rdfs:label : registration authority</para>
    ///   <para>skos:scopeNote : For intance: The IDF serves as the Registration Authority for the International Standards Organisation (ISO) in the area/domain of Digital Object Identifiers [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/citedcat-ap/registrationAuthority">citedcat:registrationAuthority</a>
    /// </summary>
    let registrationAuthority = _prefixId.prefix "registrationAuthority"
    /// <summary>
    ///   <para>skos:scopeNote : May operate at a narrower level of scope; may or may not hold less administrative responsibility than a project team [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Typically refers to a group of individuals with a lab, department, or division that has a specifically defined focus of activity [DataCite].</para>
    ///   <para>rdfs:label : research group</para>
    ///   <a href="https://w3id.org/citedcat-ap/researchGroup">citedcat:researchGroup</a>
    /// </summary>
    let researchGroup = _prefixId.prefix "researchGroup"
    /// <summary>
    ///   <para>rdfs:label : researcher</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A person involved in analyzing data or the results of an experiment or formal study. May indicate an intern or assistant to one of the authors who helped with research but who was not so “key” as to be listed as an author [DataCite].</para>
    ///   <para>skos:scopeNote : Should be a person, not an institution. Note that a person involved in the gathering of data would fall under the contributorType “DataCollector.” The researcher may find additional data online and correlate it to the data collected for the experiment or study, for example [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/researcher">citedcat:researcher</a>
    /// </summary>
    let researcher = _prefixId.prefix "researcher"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : sponsor</para>
    ///   <para>skos:scopeNote : Includes organisations that provide in-kind support, through donation, provision of people or a facility or instrumentation necessary for the development of the resource, etc. [DataCite].</para>
    ///   <para>rdfs:comment : Person or organisation that issued a contract or under the auspices of which a work has been written, printed, published, developed, etc. [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/sponsor">citedcat:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:comment : Designated administrator over one or more groups/teams working to produce a resource or over one or more steps of a development process [DataCite].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : supervisor</para>
    ///   <a href="https://w3id.org/citedcat-ap/supervisor">citedcat:supervisor</a>
    /// </summary>
    let supervisor = _prefixId.prefix "supervisor"
    /// <summary>
    ///   <para>rdfs:label : work package leader</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A Work Package is a recognized data product, not all of which is included in publication. The package, instead, may include notes, discarded documents, etc. The Work Package Leader is responsible for ensuring the comprehensive contents, versioning, and availability of the Work Package during the development of the resource [DataCite].</para>
    ///   <a href="https://w3id.org/citedcat-ap/workPackageLeader">citedcat:workPackageLeader</a>
    /// </summary>
    let workPackageLeader = _prefixId.prefix "workPackageLeader"
