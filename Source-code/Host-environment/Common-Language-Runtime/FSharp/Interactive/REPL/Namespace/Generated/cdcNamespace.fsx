#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cdc =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/cdc#" "cdc"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : addition and deletion distribution (complement)</para>
    ///   <para>rdfs:comment : A cdc:AdditionAndDeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). One of the two subdistributions (cdc:hasSubDistribution) of this direct distribution of dataset B is classified as cdc:AdditionDistribution, while the other is classified as cdc:DeletionDistribution.</para>
    ///   <a href="https://w3id.org/cdc#AdditionAndDeletionDistribution">cdc:AdditionAndDeletionDistribution</a>
    /// </summary>
    let AdditionAndDeletionDistribution =
        _prefixId.prefix "AdditionAndDeletionDistribution"

    /// <summary>
    ///   <para>rdfs:label : addition distribution (complement)</para>
    ///   <para>rdfs:comment : A cdc:AdditionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the addition complement distribution of dataset B should be added to the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.</para>
    ///   <a href="https://w3id.org/cdc#AdditionDistribution">cdc:AdditionDistribution</a>
    /// </summary>
    let AdditionDistribution = _prefixId.prefix "AdditionDistribution"
    /// <summary>
    ///   <para>rdfs:label : architectural design dataset</para>
    ///   <para>rdfs:comment : A dataset describing a (part of a) planned construction that is the result of an architectural design process.</para>
    ///   <a href="https://w3id.org/cdc#ArchitecturalDesignDS">cdc:ArchitecturalDesignDS</a>
    /// </summary>
    let ArchitecturalDesignDS = _prefixId.prefix "ArchitecturalDesignDS"
    /// <summary>
    ///   <para>rdfs:label : as-built dataset</para>
    ///   <para>rdfs:comment : A construction dataset reflecting the physical as-built situation at a certain moment in time (snapshot or a period of time), e.g. before an intervention, during an intervention (progress monitoring) or after an intervention. Use its subclasses to be more specific about the type of as-built situation.</para>
    ///   <a href="https://w3id.org/cdc#AsBuiltDS">cdc:AsBuiltDS</a>
    /// </summary>
    let AsBuiltDS = _prefixId.prefix "AsBuiltDS"
    /// <summary>
    ///   <para>rdfs:label : construction planning dataset</para>
    ///   <para>rdfs:comment : A construction planning dataset, made by a designer or contractor. This type of dataset typically contains construction tasks (cto:Task) that are planned.</para>
    ///   <a href="https://w3id.org/cdc#ConstructionPlanningDS">cdc:ConstructionPlanningDS</a>
    /// </summary>
    let ConstructionPlanningDS = _prefixId.prefix "ConstructionPlanningDS"
    /// <summary>
    ///   <para>rdfs:label : construction progress dataset</para>
    ///   <para>rdfs:comment : A construction progress dataset, maintained by a construction site supervisor selected by the owner (e.g. the architect) or a contractor. This type of dataset contains construction tasks (cto:Task) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS (during construction progress monitoring of a running or relatively recent project) or cdc:HistoricalAsBuiltDS (for describing the results of a historical study regarding the construction process).</para>
    ///   <a href="https://w3id.org/cdc#ConstructionProgressDS">cdc:ConstructionProgressDS</a>
    /// </summary>
    let ConstructionProgressDS = _prefixId.prefix "ConstructionProgressDS"
    /// <summary>
    ///   <para>rdfs:label : contemporary as-built dataset</para>
    ///   <para>rdfs:comment : A contemporary as-built dataset depicts the construction as-is based on directly verifiable facts (e.g. a geometry survey). It typically forms the basis for managing maintenance information or construction progress monitoring. It can also be the starting point for a construction project.</para>
    ///   <a href="https://w3id.org/cdc#ContemporaryAsBuiltDS">cdc:ContemporaryAsBuiltDS</a>
    /// </summary>
    let ContemporaryAsBuiltDS = _prefixId.prefix "ContemporaryAsBuiltDS"
    /// <summary>
    ///   <para>rdfs:label : data management tag</para>
    ///   <para>rdfs:comment : A tag that is linked to a DCAT catalog, dataset, distribution or data service instance node using the cdc:hasDataManagementTag property. CDC predefines three instances of this class, i.e. cdc:incoming, cdc:internal and cdc:outgoing. Each catalog, dataset, distribution or data service can only have one tag that is not supposed to change over the lifetime of the described resource unless it considers a dataset (that is not a catalog). When necessary, qualified relations between DCAT entities can also get a tag.</para>
    ///   <a href="https://w3id.org/cdc#DataManagementTag">cdc:DataManagementTag</a>
    /// </summary>
    let DataManagementTag = _prefixId.prefix "DataManagementTag"
    /// <summary>
    ///   <para>rdfs:label : default graph distribution</para>
    ///   <para>rdfs:comment : A DCAT distribution of an RDF dataset, where the content of the dataset can be found in the default graph of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).</para>
    ///   <a href="https://w3id.org/cdc#DefaultGraphDistribution">cdc:DefaultGraphDistribution</a>
    /// </summary>
    let DefaultGraphDistribution = _prefixId.prefix "DefaultGraphDistribution"
    /// <summary>
    ///   <para>rdfs:label : deletion distribution (complement)</para>
    ///   <para>rdfs:comment : A cdc:DeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the deletion complement distribution of dataset B should be subtracted from the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.</para>
    ///   <a href="https://w3id.org/cdc#DeletionDistribution">cdc:DeletionDistribution</a>
    /// </summary>
    let DeletionDistribution = _prefixId.prefix "DeletionDistribution"
    /// <summary>
    ///   <para>rdfs:label : design dataset</para>
    ///   <para>rdfs:comment : In contrast to an as-built dataset (cdc:AsBuiltDS), this type of construction dataset describes a future situation that is the outcome of some type of design process. Use its subclasses to be more specific about the type of design/planning.</para>
    ///   <a href="https://w3id.org/cdc#DesignDS">cdc:DesignDS</a>
    /// </summary>
    let DesignDS = _prefixId.prefix "DesignDS"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : distribution relation</para>
    ///   <para>rdfs:comment : An instance of this class represents a qualified relation from a dataset distribution to another DCAT entity. It is connected to a cdc:DistributionRole instance via cdc:hadDistributionRole.</para>
    ///   <a href="https://w3id.org/cdc#DistributionRelation">cdc:DistributionRelation</a>
    /// </summary>
    let DistributionRelation = _prefixId.prefix "DistributionRelation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : distribution role</para>
    ///   <para>rdfs:comment : A distribution role defines the kind of qualified relation between two dataset distributions.</para>
    ///   <a href="https://w3id.org/cdc#DistributionRole">cdc:DistributionRole</a>
    /// </summary>
    let DistributionRole = _prefixId.prefix "DistributionRole"
    /// <summary>
    ///   <para>rdfs:label : historical as-built dataset</para>
    ///   <para>rdfs:comment : A historical as-built dataset contains a description of a construction in the past based on historical research.</para>
    ///   <a href="https://w3id.org/cdc#HistoricalAsBuiltDS">cdc:HistoricalAsBuiltDS</a>
    /// </summary>
    let HistoricalAsBuiltDS = _prefixId.prefix "HistoricalAsBuiltDS"
    /// <summary>
    ///   <para>rdfs:label : inspection as-built dataset</para>
    ///   <para>rdfs:comment : An inspection as-built dataset, created by a construction inspector. This type of dataset contains detailed information about inspections, including inspection tasks (cto:InspectionTask) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS.</para>
    ///   <a href="https://w3id.org/cdc#InspectionAsBuiltDS">cdc:InspectionAsBuiltDS</a>
    /// </summary>
    let InspectionAsBuiltDS = _prefixId.prefix "InspectionAsBuiltDS"
    /// <summary>
    ///   <para>rdfs:label : inspection planning dataset</para>
    ///   <para>rdfs:comment : An inspection planning dataset, made by a construction inspector. This type of dataset typically contains inspection tasks (cto:InspectionTask, subclasses of cto:Task) that are planned, indicating which parts of the construction will be inspected.</para>
    ///   <a href="https://w3id.org/cdc#InspectionPlanningDS">cdc:InspectionPlanningDS</a>
    /// </summary>
    let InspectionPlanningDS = _prefixId.prefix "InspectionPlanningDS"
    /// <summary>
    ///   <para>rdfs:label : MEP design dataset</para>
    ///   <para>rdfs:comment : A dataset describing a (part of a) planned construction that is the result of a MEP engineering (mechanical, electrical and plumbing) design process.</para>
    ///   <a href="https://w3id.org/cdc#MEPDesignDS">cdc:MEPDesignDS</a>
    /// </summary>
    let MEPDesignDS = _prefixId.prefix "MEPDesignDS"
    /// <summary>
    ///   <para>rdfs:label : named graph distribution</para>
    ///   <para>rdfs:comment : A DCAT distribution of an RDF dataset, where the content of the dataset can be found in a single named graph (specified using cdc:graphURI) of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).</para>
    ///   <a href="https://w3id.org/cdc#NamedGraphDistribution">cdc:NamedGraphDistribution</a>
    /// </summary>
    let NamedGraphDistribution = _prefixId.prefix "NamedGraphDistribution"
    /// <summary>
    ///   <para>rdfs:label : owner requirements dataset</para>
    ///   <para>rdfs:comment : A dataset describing the requirements imposed by the construction owner at the start of a construction project. Such a dataset, when using RDF, can for example be described using SHACL shapes or a graph describing the components and spatial zones (and their properties) that should be provided in the delivered construction.</para>
    ///   <a href="https://w3id.org/cdc#OwnerRequirementsDS">cdc:OwnerRequirementsDS</a>
    /// </summary>
    let OwnerRequirementsDS = _prefixId.prefix "OwnerRequirementsDS"
    /// <summary>
    ///   <para>rdfs:label : standalone distribution</para>
    ///   <para>rdfs:comment : A cdc:StandaloneDistribution is applied to classify a distribution as being standalone, meaning that it does not complement to the content of another dataset. Consequently, the content served by this distribution is equal to the entire content represented by its dataset. If a standalone distribution is derived from a complementing distribution of the same dataset, it can be connected using the cdc:standaloneOf relation.</para>
    ///   <a href="https://w3id.org/cdc#StandaloneDistribution">cdc:StandaloneDistribution</a>
    /// </summary>
    let StandaloneDistribution = _prefixId.prefix "StandaloneDistribution"
    /// <summary>
    ///   <para>rdfs:label : structural design dataset</para>
    ///   <para>rdfs:comment : A dataset describing a (part of a) planned construction that is the result of a structural engineering design process.</para>
    ///   <a href="https://w3id.org/cdc#StructuralDesignDS">cdc:StructuralDesignDS</a>
    /// </summary>
    let StructuralDesignDS = _prefixId.prefix "StructuralDesignDS"
    /// <summary>
    ///   <para>rdfs:label : validation report</para>
    ///   <para>rdfs:comment : An instance of this class is used to describe the result of a comparison between a design, a construction planning or a finalized as-built dataset and a dataset with requirements it tries to fulfill. The validation report node can be equal to the top node of a SHACL validation report RDF graph (e.g. owner requirements vs. design), or it can point to either two RDF datasets (cdc:onlyInSourceDS or cdc:onlyInTargetDS) containing the result of a subtraction (e.g. design vs. as-built) or a free text explanation of the comparison result (rdfs:comment).</para>
    ///   <a href="https://w3id.org/cdc#ValidationReport">cdc:ValidationReport</a>
    /// </summary>
    let ValidationReport = _prefixId.prefix "ValidationReport"
    let alternative = _prefixId.prefix "alternative"
    let complementLink = _prefixId.prefix "complementLink"
    /// <summary>
    ///   <para>rdfs:label : complements</para>
    ///   <para>rdfs:comment : A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).</para>
    ///   <a href="https://w3id.org/cdc#complements">cdc:complements</a>
    /// </summary>
    let complements = _prefixId.prefix "complements"
    let copiedDistributionLink = _prefixId.prefix "copiedDistributionLink"
    /// <summary>
    ///   <para>rdfs:label : copied distribution of</para>
    ///   <para>rdfs:comment : A property to directly connect two distributions of the same dataset, where the source distribution is a content-wise copy of the target distribution. Examples are a received dataset accompanied by an incoming distribution. The content served by this incoming distribution can be copied to an internal distribution of the same dataset to improve accessability.</para>
    ///   <a href="https://w3id.org/cdc#copiedDistributionOf">cdc:copiedDistributionOf</a>
    /// </summary>
    let copiedDistributionOf = _prefixId.prefix "copiedDistributionOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : distributed dataset version</para>
    ///   <para>rdfs:comment : Connects a distribution to the version of the dataset it distributes. The dataset version can be identified via a dateTime or a string identifier.</para>
    ///   <a href="https://w3id.org/cdc#distributedDatasetVersion">cdc:distributedDatasetVersion</a>
    /// </summary>
    let distributedDatasetVersion = _prefixId.prefix "distributedDatasetVersion"
    /// <summary>
    ///   <para>rdfs:label : fulfils requirements</para>
    ///   <para>rdfs:comment : A Boolean property to assert if a certain set of requirements contained in a dataset is fulfilled by another dataset. It should only be used on instances of dcat:Relation with a dcat:hadRole property pointing to cdc:requirementLink.</para>
    ///   <a href="https://w3id.org/cdc#fulfilsRequirements">cdc:fulfilsRequirements</a>
    /// </summary>
    let fulfilsRequirements = _prefixId.prefix "fulfilsRequirements"
    /// <summary>
    ///   <para>rdfs:label : a (named) graph URI</para>
    ///   <para>rdfs:comment : The URI of the named graph related to a cdc:NamedGraphDistribution.</para>
    ///   <a href="https://w3id.org/cdc#graphURI">cdc:graphURI</a>
    /// </summary>
    let graphURI = _prefixId.prefix "graphURI"
    /// <summary>
    ///   <para>rdfs:label : had distribution role</para>
    ///   <para>rdfs:comment : A property to connect an instance of cdc:DistributionRelation to an instance of cdc:DistributionRole. The object of this property defines the type of the qualified distribution relation (cdc:qualifiedDistributionRelation) between a source distribution and another target DCAT entity.</para>
    ///   <a href="https://w3id.org/cdc#hadDistributionRole">cdc:hadDistributionRole</a>
    /// </summary>
    let hadDistributionRole = _prefixId.prefix "hadDistributionRole"
    /// <summary>
    ///   <para>rdfs:label : has data management tag</para>
    ///   <para>rdfs:comment : Connects a DCAT catalog, dataset, distribution, data service or qualified relation (cdc:DistributionRelation or dcat:Relation) to exactly one of the following predefined data management tags: cdc:internal, cdc:incoming or cdc:outgoing.</para>
    ///   <a href="https://w3id.org/cdc#hasDataManagementTag">cdc:hasDataManagementTag</a>
    /// </summary>
    let hasDataManagementTag = _prefixId.prefix "hasDataManagementTag"
    /// <summary>
    ///   <para>rdfs:label : has sub distribution</para>
    ///   <para>rdfs:comment : A property to connect two dcat:Distribution instances of a dataset, where the object node (instance of cdc:AdditionDistribution or cdc:DeletionDistribtion) is the sub distribution of the subject node (instance of class cdc:AdditionAndDeletionDistribution). A subdistribution is only defined when a dataset distribution complenents another dataset and the complement exists of an addition and a deletion part.</para>
    ///   <a href="https://w3id.org/cdc#hasSubDistribution">cdc:hasSubDistribution</a>
    /// </summary>
    let hasSubDistribution = _prefixId.prefix "hasSubDistribution"
    /// <summary>
    ///   <para>rdfs:label : has validation report</para>
    ///   <para>rdfs:comment : A property connecting a qualified relation between two datasets (instance of dcat:Relation) with cdc:requirementLink as role to a node representing the validation report (instance of cdc:ValidationReport).</para>
    ///   <a href="https://w3id.org/cdc#hasValidationReport">cdc:hasValidationReport</a>
    /// </summary>
    let hasValidationReport = _prefixId.prefix "hasValidationReport"
    let incoming = _prefixId.prefix "incoming"
    let internal_ = _prefixId.prefix "internal"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : only in source dataset</para>
    ///   <para>rdfs:comment : When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset A should be contained in a dataset that is connected using this property.</para>
    ///   <a href="https://w3id.org/cdc#onlyInSourceDS">cdc:onlyInSourceDS</a>
    /// </summary>
    let onlyInSourceDS = _prefixId.prefix "onlyInSourceDS"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : only in target dataset </para>
    ///   <para>rdfs:comment : When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset B should be contained in a dataset that is connected using this property.</para>
    ///   <a href="https://w3id.org/cdc#onlyInTargetDS">cdc:onlyInTargetDS</a>
    /// </summary>
    let onlyInTargetDS = _prefixId.prefix "onlyInTargetDS"
    let outgoing = _prefixId.prefix "outgoing"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : a qualified distribution relation </para>
    ///   <para>rdfs:comment : A property to connect a source distribution to an instance of cdc:DistributionRelation, to form a qualified relation towards another DCAT entity.</para>
    ///   <a href="https://w3id.org/cdc#qualifiedDistributionRelation">cdc:qualifiedDistributionRelation</a>
    /// </summary>
    let qualifiedDistributionRelation = _prefixId.prefix "qualifiedDistributionRelation"
    let requirementLink = _prefixId.prefix "requirementLink"
    /// <summary>
    ///   <para>rdfs:label : requirements related to </para>
    ///   <para>rdfs:comment : A direct connection between owner requirements (cdc:OwnerRequirementsDS) and the as-built situation (cdc:AsBuiltDS or subclasses) before the start of a possible intervention.</para>
    ///   <a href="https://w3id.org/cdc#requirementsRelatedTo">cdc:requirementsRelatedTo</a>
    /// </summary>
    let requirementsRelatedTo = _prefixId.prefix "requirementsRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).</para>
    ///   <para>rdfs:label : snapshot dataset of</para>
    ///   <a href="https://w3id.org/cdc#snapshotOf">cdc:snapshotOf</a>
    /// </summary>
    let snapshotOf = _prefixId.prefix "snapshotOf"
    let standaloneLink = _prefixId.prefix "standaloneLink"
    /// <summary>
    ///   <para>rdfs:label : standalone distribution of</para>
    ///   <para>rdfs:comment : A property to directly connect a standalone distribution to a complementing distribution. Both distributions are serving the same dataset.</para>
    ///   <a href="https://w3id.org/cdc#standaloneOf">cdc:standaloneOf</a>
    /// </summary>
    let standaloneOf = _prefixId.prefix "standaloneOf"
    /// <summary>
    ///   <para>rdfs:label : version of source dataset</para>
    ///   <para>rdfs:comment : Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the source dataset or the dataset served by the source distribution. The dataset version can be identified via a dateTime or a string identifier.</para>
    ///   <a href="https://w3id.org/cdc#versionSourceDS">cdc:versionSourceDS</a>
    /// </summary>
    let versionSourceDS = _prefixId.prefix "versionSourceDS"
    /// <summary>
    ///   <para>rdfs:label : version of target dataset</para>
    ///   <para>rdfs:comment : Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the target dataset or the dataset served by the target distribution. The dataset version can be identified via a dateTime or a string identifier.</para>
    ///   <a href="https://w3id.org/cdc#versionTargetDS">cdc:versionTargetDS</a>
    /// </summary>
    let versionTargetDS = _prefixId.prefix "versionTargetDS"
