namespace https.w3id.org.citedcat_ap.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module citedcat =
    let _namespace_iri = Namespace_Iri citedcat |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:citedcat-ap/</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:AssetDistribution</para>
    ///   <para>foaf:Person</para>
    ///   <para>adms:Asset</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"CiteDCAT-AP is an extension of the DCAT application profile for data portals in Europe (DCAT-AP) for describing resources documented by using the DataCite metadata schema - the de facto standard for data citation, and used across scientific disciplines. Its basic use case is to make research data searchable on general data portals, thereby bridging the gap between scientific and public sector information. For this purpose, CiteDCAT-AP provides an RDF vocabulary and the corresponding RDF syntax binding for the metadata elements defined in DataCite."</para>
    /// labels<para>"CiteDCAT-AP Vocabulary"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/">https://w3id.org/citedcat-ap/</seealso>
    let _prefix_iri = Prefixed_Name(citedcat, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/DataPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A factual and objective publication with a focused intent to identify and describe specific data, sets of data, or data collections to facilitate discoverability [DataCite]."</para>
    /// labels<para>"Data paper"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/DataPaper">https://w3id.org/citedcat-ap/DataPaper</seealso>
    let DataPaper = Prefixed_Name(citedcat, "DataPaper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract, conceptual, graphical, mathematical or visualization model that represents empirical objects, phenomena, or physical processes [DataCite]."</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/Model">https://w3id.org/citedcat-ap/Model</seealso>
    let Model = Prefixed_Name(citedcat, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A structured series of steps which can be executed to produce a final outcome, allowing users a means to specify and enact their work in a more reproducible manner [DataCite]."</para>
    /// labels<para>"Workflow"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/Workflow">https://w3id.org/citedcat-ap/Workflow</seealso>
    let Workflow = Prefixed_Name(citedcat, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/compiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates B is the result of a compile or creation event using A [DataCite]."</para>
    /// labels<para>"compiles"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/compiles">https://w3id.org/citedcat-ap/compiles</seealso>
    let compiles = Prefixed_Name(citedcat, "compiles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/continues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates A is a continuation of the work B [DataCite]."</para>
    /// labels<para>"continues"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/continues">https://w3id.org/citedcat-ap/continues</seealso>
    let continues = Prefixed_Name(citedcat, "continues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/dataCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Person/institution responsible for finding, gathering/collecting data under the guidelines of the author(s) or Principal Investigator (PI) [DataCite]."</para>
    /// labels<para>"data collector"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/dataCollector">https://w3id.org/citedcat-ap/dataCollector</seealso>
    let dataCollector = Prefixed_Name(citedcat, "dataCollector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/dataCurator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Person tasked with reviewing, enhancing, cleaning, or standardizing metadata and the associated data submitted for storage, use, and maintenance within a data centre or repository [DataCite]."</para>
    /// labels<para>"data curator"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/dataCurator">https://w3id.org/citedcat-ap/dataCurator</seealso>
    let dataCurator = Prefixed_Name(citedcat, "dataCurator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/dataManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Person (or organisation with a staff of data managers, such as a data centre) responsible for maintaining the finished resource [DataCite]."</para>
    /// labels<para>"data manager"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/dataManager">https://w3id.org/citedcat-ap/dataManager</seealso>
    let dataManager = Prefixed_Name(citedcat, "dataManager") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates A describes B [DataCite]."</para>
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/describes">https://w3id.org/citedcat-ap/describes</seealso>
    let describes = Prefixed_Name(citedcat, "describes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/funder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Institution that provided financial support for the development of the resource [DataCite]."</para>
    /// labels<para>"funder"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/funder">https://w3id.org/citedcat-ap/funder</seealso>
    let funder = Prefixed_Name(citedcat, "funder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:citedcat-ap/hostingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typically, the organisation allowing the resource to be available on the Internet through the provision of its hardware/software/operating support [DataCite]."</para>
    /// labels<para>"hosting institution"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/hostingInstitution">https://w3id.org/citedcat-ap/hostingInstitution</seealso>
    let hostingInstitution =
        Prefixed_Name(citedcat, "hostingInstitution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:citedcat-ap/isAwardedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Agent responsible for awarding financial support to an activity (typically, a project)."</para>
    /// labels<para>"is awarded by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isAwardedBy">https://w3id.org/citedcat-ap/isAwardedBy</seealso>
    let isAwardedBy = Prefixed_Name(citedcat, "isAwardedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isCompiledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates B is used to compile or create A [DataCite]."</para>
    /// labels<para>"is compiled by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isCompiledBy">https://w3id.org/citedcat-ap/isCompiledBy</seealso>
    let isCompiledBy = Prefixed_Name(citedcat, "isCompiledBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isContinuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates A is continued by the work B [DataCite]."</para>
    /// labels<para>"is continued by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isContinuedBy">https://w3id.org/citedcat-ap/isContinuedBy</seealso>
    let isContinuedBy = Prefixed_Name(citedcat, "isContinuedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isFundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The activity (typically, a project) that provided financial support for the development of the resource."</para>
    /// labels<para>"is funded by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isFundedBy">https://w3id.org/citedcat-ap/isFundedBy</seealso>
    let isFundedBy = Prefixed_Name(citedcat, "isFundedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isOriginalFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates A is the original form of B [DataCite]."</para>
    /// labels<para>"is original form of"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isOriginalFormOf">https://w3id.org/citedcat-ap/isOriginalFormOf</seealso>
    let isOriginalFormOf = Prefixed_Name(citedcat, "isOriginalFormOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isReviewedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that A is reviewed by B [DataCite]."</para>
    /// labels<para>"is reviewed by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isReviewedBy">https://w3id.org/citedcat-ap/isReviewedBy</seealso>
    let isReviewedBy = Prefixed_Name(citedcat, "isReviewedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isSupplementTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that A is a supplement to B [DataCite]."</para>
    /// labels<para>"is supplement to"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isSupplementTo">https://w3id.org/citedcat-ap/isSupplementTo</seealso>
    let isSupplementTo = Prefixed_Name(citedcat, "isSupplementTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isSupplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that B is a supplement to A [DataCite]."</para>
    /// labels<para>"is supplemented by"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isSupplementedBy">https://w3id.org/citedcat-ap/isSupplementedBy</seealso>
    let isSupplementedBy = Prefixed_Name(citedcat, "isSupplementedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/isVariantFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates A is a variant or different form of B [DataCite]."</para>
    /// labels<para>"is variant form or"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/isVariantFormOf">https://w3id.org/citedcat-ap/isVariantFormOf</seealso>
    let isVariantFormOf = Prefixed_Name(citedcat, "isVariantFormOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/projectLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Person officially designated as head of project team or sub-project team instrumental in the work necessary to development of the resource [DataCite]."</para>
    /// labels<para>"project leader"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/projectLeader">https://w3id.org/citedcat-ap/projectLeader</seealso>
    let projectLeader = Prefixed_Name(citedcat, "projectLeader") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/projectManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Person officially designated as manager of a project. Project may consist of one or many project teams and sub-teams [DataCite]."</para>
    /// labels<para>"project manager"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/projectManager">https://w3id.org/citedcat-ap/projectManager</seealso>
    let projectManager = Prefixed_Name(citedcat, "projectManager") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/projectMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Person on the membership list of a designated project/project team [DataCite]."</para>
    /// labels<para>"project member"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/projectMember">https://w3id.org/citedcat-ap/projectMember</seealso>
    let projectMember = Prefixed_Name(citedcat, "projectMember") |> PrefixedName

    /// <summary>
    ///   <para>w3id:citedcat-ap/registrationAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Institution/organisation officially appointed by a Registration Authority to handle specific tasks within a defined area of responsibility [DataCite]."</para>
    /// labels<para>"registration agency"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/registrationAgency">https://w3id.org/citedcat-ap/registrationAgency</seealso>
    let registrationAgency =
        Prefixed_Name(citedcat, "registrationAgency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:citedcat-ap/registrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A standards-setting body from which Registration Agencies obtain official recognition and guidance [DataCite]."</para>
    /// labels<para>"registration authority"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/registrationAuthority">https://w3id.org/citedcat-ap/registrationAuthority</seealso>
    let registrationAuthority =
        Prefixed_Name(citedcat, "registrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:citedcat-ap/researchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typically refers to a group of individuals with a lab, department, or division that has a specifically defined focus of activity [DataCite]."</para>
    /// labels<para>"research group"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/researchGroup">https://w3id.org/citedcat-ap/researchGroup</seealso>
    let researchGroup = Prefixed_Name(citedcat, "researchGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A person involved in analyzing data or the results of an experiment or formal study. May indicate an intern or assistant to one of the authors who helped with research but who was not so “key” as to be listed as an author [DataCite]."</para>
    /// labels<para>"researcher"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/researcher">https://w3id.org/citedcat-ap/researcher</seealso>
    let researcher = Prefixed_Name(citedcat, "researcher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Person or organisation that issued a contract or under the auspices of which a work has been written, printed, published, developed, etc. [DataCite]."</para>
    /// labels<para>"sponsor"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/sponsor">https://w3id.org/citedcat-ap/sponsor</seealso>
    let sponsor = Prefixed_Name(citedcat, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/supervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Designated administrator over one or more groups/teams working to produce a resource or over one or more steps of a development process [DataCite]."</para>
    /// labels<para>"supervisor"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/supervisor">https://w3id.org/citedcat-ap/supervisor</seealso>
    let supervisor = Prefixed_Name(citedcat, "supervisor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:citedcat-ap/workPackageLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Work Package is a recognized data product, not all of which is included in publication. The package, instead, may include notes, discarded documents, etc. The Work Package Leader is responsible for ensuring the comprehensive contents, versioning, and availability of the Work Package during the development of the resource [DataCite]."</para>
    /// labels<para>"work package leader"</para></remarks>
    /// <seealso href="https://w3id.org/citedcat-ap/workPackageLeader">https://w3id.org/citedcat-ap/workPackageLeader</seealso>
    let workPackageLeader = Prefixed_Name(citedcat, "workPackageLeader") |> PrefixedName
