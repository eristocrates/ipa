namespace https.w3id.org.citedcat_ap.slash

open DoxAletheia

module citedcat =
    let _namespace_name = "https://w3id.org/citedcat-ap/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A factual and objective publication with a focused intent to identify and describe specific data, sets of data, or data collections to facilitate discoverability [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/DataPaper"></see></summary>
    let DataPaper = _prefix "DataPaper"
    /// <summary>
    /// An abstract, conceptual, graphical, mathematical or visualization model that represents empirical objects, phenomena, or physical processes [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// A structured series of steps which can be executed to produce a final outcome, allowing users a means to specify and enact their work in a more reproducible manner [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/Workflow"></see></summary>
    let Workflow = _prefix "Workflow"
    /// <summary>
    /// Indicates B is the result of a compile or creation event using A [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/compiles"></see></summary>
    let compiles = _prefix "compiles"
    /// <summary>
    /// Indicates B is used to compile or create A [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isCompiledBy"></see></summary>
    let isCompiledBy = _prefix "isCompiledBy"
    /// <summary>
    /// Indicates A is a continuation of the work B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/continues"></see></summary>
    let continues = _prefix "continues"
    /// <summary>
    /// Indicates A is continued by the work B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isContinuedBy"></see></summary>
    let isContinuedBy = _prefix "isContinuedBy"
    /// <summary>
    /// Person/institution responsible for finding, gathering/collecting data under the guidelines of the author(s) or Principal Investigator (PI) [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/dataCollector"></see></summary>
    let dataCollector = _prefix "dataCollector"
    /// <summary>
    /// Person tasked with reviewing, enhancing, cleaning, or standardizing metadata and the associated data submitted for storage, use, and maintenance within a data centre or repository [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/dataCurator"></see></summary>
    let dataCurator = _prefix "dataCurator"
    /// <summary>
    /// Person (or organisation with a staff of data managers, such as a data centre) responsible for maintaining the finished resource [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/dataManager"></see></summary>
    let dataManager = _prefix "dataManager"
    /// <summary>
    /// Indicates A describes B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// Institution that provided financial support for the development of the resource [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/funder"></see></summary>
    let funder = _prefix "funder"
    /// <summary>
    /// Typically, the organisation allowing the resource to be available on the Internet through the provision of its hardware/software/operating support [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/hostingInstitution"></see></summary>
    let hostingInstitution = _prefix "hostingInstitution"
    /// <summary>
    /// Agent responsible for awarding financial support to an activity (typically, a project).
    /// <see href="https://w3id.org/citedcat-ap/isAwardedBy"></see></summary>
    let isAwardedBy = _prefix "isAwardedBy"
    /// <summary>
    /// The activity (typically, a project) that provided financial support for the development of the resource.
    /// <see href="https://w3id.org/citedcat-ap/isFundedBy"></see></summary>
    let isFundedBy = _prefix "isFundedBy"
    /// <summary>
    /// Indicates A is the original form of B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isOriginalFormOf"></see></summary>
    let isOriginalFormOf = _prefix "isOriginalFormOf"
    /// <summary>
    /// Indicates A is a variant or different form of B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isVariantFormOf"></see></summary>
    let isVariantFormOf = _prefix "isVariantFormOf"
    /// <summary>
    /// Indicates that A is reviewed by B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isReviewedBy"></see></summary>
    let isReviewedBy = _prefix "isReviewedBy"
    /// <summary>
    /// Indicates that A is a supplement to B [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isSupplementTo"></see></summary>
    let isSupplementTo = _prefix "isSupplementTo"
    /// <summary>
    /// Indicates that B is a supplement to A [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/isSupplementedBy"></see></summary>
    let isSupplementedBy = _prefix "isSupplementedBy"
    /// <summary>
    /// Person officially designated as head of project team or sub-project team instrumental in the work necessary to development of the resource [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/projectLeader"></see></summary>
    let projectLeader = _prefix "projectLeader"
    /// <summary>
    /// Person on the membership list of a designated project/project team [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/projectMember"></see></summary>
    let projectMember = _prefix "projectMember"
    /// <summary>
    /// Person officially designated as manager of a project. Project may consist of one or many project teams and sub-teams [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/projectManager"></see></summary>
    let projectManager = _prefix "projectManager"
    /// <summary>
    /// Institution/organisation officially appointed by a Registration Authority to handle specific tasks within a defined area of responsibility [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/registrationAgency"></see></summary>
    let registrationAgency = _prefix "registrationAgency"
    /// <summary>
    /// A standards-setting body from which Registration Agencies obtain official recognition and guidance [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/registrationAuthority"></see></summary>
    let registrationAuthority = _prefix "registrationAuthority"
    /// <summary>
    /// Typically refers to a group of individuals with a lab, department, or division that has a specifically defined focus of activity [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/researchGroup"></see></summary>
    let researchGroup = _prefix "researchGroup"
    /// <summary>
    /// A person involved in analyzing data or the results of an experiment or formal study. May indicate an intern or assistant to one of the authors who helped with research but who was not so “key” as to be listed as an author [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/researcher"></see></summary>
    let researcher = _prefix "researcher"
    /// <summary>
    /// Person or organisation that issued a contract or under the auspices of which a work has been written, printed, published, developed, etc. [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/sponsor"></see></summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    /// Designated administrator over one or more groups/teams working to produce a resource or over one or more steps of a development process [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/supervisor"></see></summary>
    let supervisor = _prefix "supervisor"
    /// <summary>
    /// A Work Package is a recognized data product, not all of which is included in publication. The package, instead, may include notes, discarded documents, etc. The Work Package Leader is responsible for ensuring the comprehensive contents, versioning, and availability of the Work Package during the development of the resource [DataCite].
    /// <see href="https://w3id.org/citedcat-ap/workPackageLeader"></see></summary>
    let workPackageLeader = _prefix "workPackageLeader"
