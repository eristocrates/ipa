namespace https.w3id.org.cdc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cdc =
    let _namespace_iri = Namespace_Iri cdc |> NamespaceIRI
    /// <summary>
    ///   <para>cdc:DesignDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In contrast to an as-built dataset (cdc:AsBuiltDS), this type of construction dataset describes a future situation that is the outcome of some type of design process. Use its subclasses to be more specific about the type of design/planning.</para>
    /// labels<para>design dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DesignDS">https://w3id.org/cdc#DesignDS</seealso>
    let DesignDS = Prefixed_Name(cdc, "DesignDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:AsBuiltDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A construction dataset reflecting the physical as-built situation at a certain moment in time (snapshot or a period of time), e.g. before an intervention, during an intervention (progress monitoring) or after an intervention. Use its subclasses to be more specific about the type of as-built situation.</para>
    /// labels<para>as-built dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#AsBuiltDS">https://w3id.org/cdc#AsBuiltDS</seealso>
    let AsBuiltDS = Prefixed_Name(cdc, "AsBuiltDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:HistoricalAsBuiltDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A historical as-built dataset contains a description of a construction in the past based on historical research.</para>
    /// labels<para>historical as-built dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#HistoricalAsBuiltDS">https://w3id.org/cdc#HistoricalAsBuiltDS</seealso>
    let HistoricalAsBuiltDS = Prefixed_Name(cdc, "HistoricalAsBuiltDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:DataManagementTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tag that is linked to a DCAT catalog, dataset, distribution or data service instance node using the cdc:hasDataManagementTag property. CDC predefines three instances of this class, i.e. cdc:incoming, cdc:internal and cdc:outgoing. Each catalog, dataset, distribution or data service can only have one tag that is not supposed to change over the lifetime of the described resource unless it considers a dataset (that is not a catalog). When necessary, qualified relations between DCAT entities can also get a tag.</para>
    /// labels<para>data management tag</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DataManagementTag">https://w3id.org/cdc#DataManagementTag</seealso>
    let DataManagementTag = Prefixed_Name(cdc, "DataManagementTag") |> PrefixedName

    /// <summary>
    ///   <para>cdc:DistributionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of this class represents a qualified relation from a dataset distribution to another DCAT entity. It is connected to a cdc:DistributionRole instance via cdc:hadDistributionRole.</para>
    /// labels<para>distribution relation</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DistributionRelation">https://w3id.org/cdc#DistributionRelation</seealso>
    let DistributionRelation =
        Prefixed_Name(cdc, "DistributionRelation") |> PrefixedName

    /// <summary>
    ///   <para>cdc:AdditionAndDeletionDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cdc:AdditionAndDeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). One of the two subdistributions (cdc:hasSubDistribution) of this direct distribution of dataset B is classified as cdc:AdditionDistribution, while the other is classified as cdc:DeletionDistribution.</para>
    /// labels<para>addition and deletion distribution (complement)</para></remarks>
    /// <seealso href="https://w3id.org/cdc#AdditionAndDeletionDistribution">https://w3id.org/cdc#AdditionAndDeletionDistribution</seealso>
    let AdditionAndDeletionDistribution =
        Prefixed_Name(cdc, "AdditionAndDeletionDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:DeletionDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cdc:DeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the deletion complement distribution of dataset B should be subtracted from the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.</para>
    /// labels<para>deletion distribution (complement)</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DeletionDistribution">https://w3id.org/cdc#DeletionDistribution</seealso>
    let DeletionDistribution =
        Prefixed_Name(cdc, "DeletionDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:ConstructionPlanningDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A construction planning dataset, made by a designer or contractor. This type of dataset typically contains construction tasks (cto:Task) that are planned.</para>
    /// labels<para>construction planning dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#ConstructionPlanningDS">https://w3id.org/cdc#ConstructionPlanningDS</seealso>
    let ConstructionPlanningDS =
        Prefixed_Name(cdc, "ConstructionPlanningDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:AdditionDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cdc:AdditionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the addition complement distribution of dataset B should be added to the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.</para>
    /// labels<para>addition distribution (complement)</para></remarks>
    /// <seealso href="https://w3id.org/cdc#AdditionDistribution">https://w3id.org/cdc#AdditionDistribution</seealso>
    let AdditionDistribution =
        Prefixed_Name(cdc, "AdditionDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:OwnerRequirementsDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dataset describing the requirements imposed by the construction owner at the start of a construction project. Such a dataset, when using RDF, can for example be described using SHACL shapes or a graph describing the components and spatial zones (and their properties) that should be provided in the delivered construction.</para>
    /// labels<para>owner requirements dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#OwnerRequirementsDS">https://w3id.org/cdc#OwnerRequirementsDS</seealso>
    let OwnerRequirementsDS = Prefixed_Name(cdc, "OwnerRequirementsDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:ArchitecturalDesignDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dataset describing a (part of a) planned construction that is the result of an architectural design process.</para>
    /// labels<para>architectural design dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#ArchitecturalDesignDS">https://w3id.org/cdc#ArchitecturalDesignDS</seealso>
    let ArchitecturalDesignDS =
        Prefixed_Name(cdc, "ArchitecturalDesignDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:ConstructionProgressDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A construction progress dataset, maintained by a construction site supervisor selected by the owner (e.g. the architect) or a contractor. This type of dataset contains construction tasks (cto:Task) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS (during construction progress monitoring of a running or relatively recent project) or cdc:HistoricalAsBuiltDS (for describing the results of a historical study regarding the construction process).</para>
    /// labels<para>construction progress dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#ConstructionProgressDS">https://w3id.org/cdc#ConstructionProgressDS</seealso>
    let ConstructionProgressDS =
        Prefixed_Name(cdc, "ConstructionProgressDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:ContemporaryAsBuiltDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contemporary as-built dataset depicts the construction as-is based on directly verifiable facts (e.g. a geometry survey). It typically forms the basis for managing maintenance information or construction progress monitoring. It can also be the starting point for a construction project.</para>
    /// labels<para>contemporary as-built dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#ContemporaryAsBuiltDS">https://w3id.org/cdc#ContemporaryAsBuiltDS</seealso>
    let ContemporaryAsBuiltDS =
        Prefixed_Name(cdc, "ContemporaryAsBuiltDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:DefaultGraphDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A DCAT distribution of an RDF dataset, where the content of the dataset can be found in the default graph of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).</para>
    /// labels<para>default graph distribution</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DefaultGraphDistribution">https://w3id.org/cdc#DefaultGraphDistribution</seealso>
    let DefaultGraphDistribution =
        Prefixed_Name(cdc, "DefaultGraphDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:DistributionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A distribution role defines the kind of qualified relation between two dataset distributions.</para>
    /// labels<para>distribution role</para></remarks>
    /// <seealso href="https://w3id.org/cdc#DistributionRole">https://w3id.org/cdc#DistributionRole</seealso>
    let DistributionRole = Prefixed_Name(cdc, "DistributionRole") |> PrefixedName

    /// <summary>
    ///   <para>cdc:InspectionPlanningDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inspection planning dataset, made by a construction inspector. This type of dataset typically contains inspection tasks (cto:InspectionTask, subclasses of cto:Task) that are planned, indicating which parts of the construction will be inspected.</para>
    /// labels<para>inspection planning dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#InspectionPlanningDS">https://w3id.org/cdc#InspectionPlanningDS</seealso>
    let InspectionPlanningDS =
        Prefixed_Name(cdc, "InspectionPlanningDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:MEPDesignDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dataset describing a (part of a) planned construction that is the result of a MEP engineering (mechanical, electrical and plumbing) design process.</para>
    /// labels<para>MEP design dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#MEPDesignDS">https://w3id.org/cdc#MEPDesignDS</seealso>
    let MEPDesignDS = Prefixed_Name(cdc, "MEPDesignDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:StructuralDesignDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dataset describing a (part of a) planned construction that is the result of a structural engineering design process.</para>
    /// labels<para>structural design dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#StructuralDesignDS">https://w3id.org/cdc#StructuralDesignDS</seealso>
    let StructuralDesignDS = Prefixed_Name(cdc, "StructuralDesignDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A property to directly connect a dataset to another dataset that proposes an alternative for the same construction context. This means that there is an overlap between the contexts of both datasets such as the construction described, the content type (e.g. two alternative designs (cdc:DesignDS) or two historical as built situations based on different sources (cdc:HistoricalAsBuiltDS)) and/or the timing. In the case of two alternative designs, the related owner requirements should be the same. When considering two alternative historical as-built situations, the temporal context should have an overlap.</para>
    /// labels<para>alternative</para></remarks>
    /// <seealso href="https://w3id.org/cdc#alternative">https://w3id.org/cdc#alternative</seealso>
    let alternative = Prefixed_Name(cdc, "alternative") |> PrefixedName

    /// <summary>
    ///   <para>cdc:copiedDistributionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to directly connect two distributions of the same dataset, where the source distribution is a content-wise copy of the target distribution. Examples are a received dataset accompanied by an incoming distribution. The content served by this incoming distribution can be copied to an internal distribution of the same dataset to improve accessability.</para>
    /// labels<para>copied distribution of</para></remarks>
    /// <seealso href="https://w3id.org/cdc#copiedDistributionOf">https://w3id.org/cdc#copiedDistributionOf</seealso>
    let copiedDistributionOf =
        Prefixed_Name(cdc, "copiedDistributionOf") |> PrefixedName

    /// <summary>
    ///   <para>cdc:hasDataManagementTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a DCAT catalog, dataset, distribution, data service or qualified relation (cdc:DistributionRelation or dcat:Relation) to exactly one of the following predefined data management tags: cdc:internal, cdc:incoming or cdc:outgoing.</para>
    /// labels<para>has data management tag</para></remarks>
    /// <seealso href="https://w3id.org/cdc#hasDataManagementTag">https://w3id.org/cdc#hasDataManagementTag</seealso>
    let hasDataManagementTag =
        Prefixed_Name(cdc, "hasDataManagementTag") |> PrefixedName

    /// <summary>
    ///   <para>cdc:hasValidationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property connecting a qualified relation between two datasets (instance of dcat:Relation) with cdc:requirementLink as role to a node representing the validation report (instance of cdc:ValidationReport).</para>
    /// labels<para>has validation report</para></remarks>
    /// <seealso href="https://w3id.org/cdc#hasValidationReport">https://w3id.org/cdc#hasValidationReport</seealso>
    let hasValidationReport = Prefixed_Name(cdc, "hasValidationReport") |> PrefixedName
    /// <summary>
    ///   <para>cdc:onlyInSourceDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset A should be contained in a dataset that is connected using this property.</para>
    /// labels<para>only in source dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#onlyInSourceDS">https://w3id.org/cdc#onlyInSourceDS</seealso>
    let onlyInSourceDS = Prefixed_Name(cdc, "onlyInSourceDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:onlyInTargetDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset B should be contained in a dataset that is connected using this property.</para>
    /// labels<para>only in target dataset </para></remarks>
    /// <seealso href="https://w3id.org/cdc#onlyInTargetDS">https://w3id.org/cdc#onlyInTargetDS</seealso>
    let onlyInTargetDS = Prefixed_Name(cdc, "onlyInTargetDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:qualifiedDistributionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to connect a source distribution to an instance of cdc:DistributionRelation, to form a qualified relation towards another DCAT entity.</para>
    /// labels<para>a qualified distribution relation </para></remarks>
    /// <seealso href="https://w3id.org/cdc#qualifiedDistributionRelation">https://w3id.org/cdc#qualifiedDistributionRelation</seealso>
    let qualifiedDistributionRelation =
        Prefixed_Name(cdc, "qualifiedDistributionRelation") |> PrefixedName

    /// <summary>
    ///   <para>cdc:requirementLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcat:Role</para>
    ///   <para>A role of a qualified relation between two datasets A and B. Dataset A has an outgoing dcat:qualifiedRelation property to an intermediate node that has an outgoing dcterms:relation property to dataset B. The intermediate node is connected using dcat:hadRole to cdc:requirementLink. The proposal contained in the source dataset (e.g. a cdc:DesignDS or a cdc:AsBuiltDS after delivery) tries to answer the requirements contained in the target dataset (e.g. respectively a cdc:OwnerRequirementsDS, and a cdc:OwnerRequirementsDS or a cdc:DesignDS).</para>
    /// labels<para>requirement link</para></remarks>
    /// <seealso href="https://w3id.org/cdc#requirementLink">https://w3id.org/cdc#requirementLink</seealso>
    let requirementLink = Prefixed_Name(cdc, "requirementLink") |> PrefixedName
    /// <summary>
    ///   <para>cdc:snapshotOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).</para>
    /// labels<para>snapshot dataset of</para></remarks>
    /// <seealso href="https://w3id.org/cdc#snapshotOf">https://w3id.org/cdc#snapshotOf</seealso>
    let snapshotOf = Prefixed_Name(cdc, "snapshotOf") |> PrefixedName
    /// <summary>
    ///   <para>cdc:outgoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DataManagementTag</para>
    ///   <para>A predefined tag to mark an outgoing catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.{</para>
    /// labels<para>outgoing</para></remarks>
    /// <seealso href="https://w3id.org/cdc#outgoing">https://w3id.org/cdc#outgoing</seealso>
    let outgoing = Prefixed_Name(cdc, "outgoing") |> PrefixedName

    /// <summary>
    ///   <para>cdc:requirementsRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A direct connection between owner requirements (cdc:OwnerRequirementsDS) and the as-built situation (cdc:AsBuiltDS or subclasses) before the start of a possible intervention.</para>
    /// labels<para>requirements related to </para></remarks>
    /// <seealso href="https://w3id.org/cdc#requirementsRelatedTo">https://w3id.org/cdc#requirementsRelatedTo</seealso>
    let requirementsRelatedTo =
        Prefixed_Name(cdc, "requirementsRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>cdc:standaloneLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DistributionRole</para>
    ///   <para>A role of a qualified relation between a standalone distribution (cdc:StandaloneDistribution) and a complementing distribution (cdc:AdditionDistribution, cdc:DeletionDistribution or cdc:AdditionAndDeletionDistribution) of the same dataset.</para>
    /// labels<para>standalone link</para></remarks>
    /// <seealso href="https://w3id.org/cdc#standaloneLink">https://w3id.org/cdc#standaloneLink</seealso>
    let standaloneLink = Prefixed_Name(cdc, "standaloneLink") |> PrefixedName
    /// <summary>
    ///   <para>cdc:standaloneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to directly connect a standalone distribution to a complementing distribution. Both distributions are serving the same dataset.</para>
    /// labels<para>standalone distribution of</para></remarks>
    /// <seealso href="https://w3id.org/cdc#standaloneOf">https://w3id.org/cdc#standaloneOf</seealso>
    let standaloneOf = Prefixed_Name(cdc, "standaloneOf") |> PrefixedName
    /// <summary>
    ///   <para>cdc:versionSourceDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the source dataset or the dataset served by the source distribution. The dataset version can be identified via a dateTime or a string identifier.</para>
    /// labels<para>version of source dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#versionSourceDS">https://w3id.org/cdc#versionSourceDS</seealso>
    let versionSourceDS = Prefixed_Name(cdc, "versionSourceDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:versionTargetDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the target dataset or the dataset served by the target distribution. The dataset version can be identified via a dateTime or a string identifier.</para>
    /// labels<para>version of target dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#versionTargetDS">https://w3id.org/cdc#versionTargetDS</seealso>
    let versionTargetDS = Prefixed_Name(cdc, "versionTargetDS") |> PrefixedName
    /// <summary>
    ///   <para>cdc:InspectionAsBuiltDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inspection as-built dataset, created by a construction inspector. This type of dataset contains detailed information about inspections, including inspection tasks (cto:InspectionTask) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS.</para>
    /// labels<para>inspection as-built dataset</para></remarks>
    /// <seealso href="https://w3id.org/cdc#InspectionAsBuiltDS">https://w3id.org/cdc#InspectionAsBuiltDS</seealso>
    let InspectionAsBuiltDS = Prefixed_Name(cdc, "InspectionAsBuiltDS") |> PrefixedName

    /// <summary>
    ///   <para>cdc:NamedGraphDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A DCAT distribution of an RDF dataset, where the content of the dataset can be found in a single named graph (specified using cdc:graphURI) of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).</para>
    /// labels<para>named graph distribution</para></remarks>
    /// <seealso href="https://w3id.org/cdc#NamedGraphDistribution">https://w3id.org/cdc#NamedGraphDistribution</seealso>
    let NamedGraphDistribution =
        Prefixed_Name(cdc, "NamedGraphDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:StandaloneDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cdc:StandaloneDistribution is applied to classify a distribution as being standalone, meaning that it does not complement to the content of another dataset. Consequently, the content served by this distribution is equal to the entire content represented by its dataset. If a standalone distribution is derived from a complementing distribution of the same dataset, it can be connected using the cdc:standaloneOf relation.</para>
    /// labels<para>standalone distribution</para></remarks>
    /// <seealso href="https://w3id.org/cdc#StandaloneDistribution">https://w3id.org/cdc#StandaloneDistribution</seealso>
    let StandaloneDistribution =
        Prefixed_Name(cdc, "StandaloneDistribution") |> PrefixedName

    /// <summary>
    ///   <para>cdc:ValidationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of this class is used to describe the result of a comparison between a design, a construction planning or a finalized as-built dataset and a dataset with requirements it tries to fulfill. The validation report node can be equal to the top node of a SHACL validation report RDF graph (e.g. owner requirements vs. design), or it can point to either two RDF datasets (cdc:onlyInSourceDS or cdc:onlyInTargetDS) containing the result of a subtraction (e.g. design vs. as-built) or a free text explanation of the comparison result (rdfs:comment).</para>
    /// labels<para>validation report</para></remarks>
    /// <seealso href="https://w3id.org/cdc#ValidationReport">https://w3id.org/cdc#ValidationReport</seealso>
    let ValidationReport = Prefixed_Name(cdc, "ValidationReport") |> PrefixedName
    /// <summary>
    ///   <para>cdc:complementLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DistributionRole</para>
    ///   <para>A role of a qualified relation between a distribution of a dataset B that complements another dataset A, where the source distribution (subject of cdc:qualifiedDistributionRelation) complements the target dataset (object of dcterms:relation). The intermediate node between the distribution of dataset B and dataset A has a property cdc:hadDistributionRole pointing to cdc:complementLink.
    ///
    /// When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset. The qualified relation described above is established between the direct distribution of dataset B and dataset A .</para>
    /// labels<para>complement link</para></remarks>
    /// <seealso href="https://w3id.org/cdc#complementLink">https://w3id.org/cdc#complementLink</seealso>
    let complementLink = Prefixed_Name(cdc, "complementLink") |> PrefixedName
    /// <summary>
    ///   <para>cdc:complements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).</para>
    /// labels<para>complements</para></remarks>
    /// <seealso href="https://w3id.org/cdc#complements">https://w3id.org/cdc#complements</seealso>
    let complements = Prefixed_Name(cdc, "complements") |> PrefixedName

    /// <summary>
    ///   <para>cdc:copiedDistributionLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DistributionRole</para>
    ///   <para>By connecting this node to a cdc:DistributionRelation instance, the source distribution (subject of cdc:qualifiedDistributionRelation) is marked as a copy of the target distribution (object of dcterms:relation).</para>
    /// labels<para>copied distribution of link</para></remarks>
    /// <seealso href="https://w3id.org/cdc#copiedDistributionLink">https://w3id.org/cdc#copiedDistributionLink</seealso>
    let copiedDistributionLink =
        Prefixed_Name(cdc, "copiedDistributionLink") |> PrefixedName

    /// <summary>
    ///   <para>cdc:distributedDatasetVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Connects a distribution to the version of the dataset it distributes. The dataset version can be identified via a dateTime or a string identifier.</para>
    /// labels<para>distributed dataset version</para></remarks>
    /// <seealso href="https://w3id.org/cdc#distributedDatasetVersion">https://w3id.org/cdc#distributedDatasetVersion</seealso>
    let distributedDatasetVersion =
        Prefixed_Name(cdc, "distributedDatasetVersion") |> PrefixedName

    /// <summary>
    ///   <para>cdc:fulfilsRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Boolean property to assert if a certain set of requirements contained in a dataset is fulfilled by another dataset. It should only be used on instances of dcat:Relation with a dcat:hadRole property pointing to cdc:requirementLink.</para>
    /// labels<para>fulfils requirements</para></remarks>
    /// <seealso href="https://w3id.org/cdc#fulfilsRequirements">https://w3id.org/cdc#fulfilsRequirements</seealso>
    let fulfilsRequirements = Prefixed_Name(cdc, "fulfilsRequirements") |> PrefixedName
    /// <summary>
    ///   <para>cdc:graphURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI of the named graph related to a cdc:NamedGraphDistribution.</para>
    /// labels<para>a (named) graph URI</para></remarks>
    /// <seealso href="https://w3id.org/cdc#graphURI">https://w3id.org/cdc#graphURI</seealso>
    let graphURI = Prefixed_Name(cdc, "graphURI") |> PrefixedName
    /// <summary>
    ///   <para>cdc:hadDistributionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to connect an instance of cdc:DistributionRelation to an instance of cdc:DistributionRole. The object of this property defines the type of the qualified distribution relation (cdc:qualifiedDistributionRelation) between a source distribution and another target DCAT entity.</para>
    /// labels<para>had distribution role</para></remarks>
    /// <seealso href="https://w3id.org/cdc#hadDistributionRole">https://w3id.org/cdc#hadDistributionRole</seealso>
    let hadDistributionRole = Prefixed_Name(cdc, "hadDistributionRole") |> PrefixedName
    /// <summary>
    ///   <para>cdc:hasSubDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to connect two dcat:Distribution instances of a dataset, where the object node (instance of cdc:AdditionDistribution or cdc:DeletionDistribtion) is the sub distribution of the subject node (instance of class cdc:AdditionAndDeletionDistribution). A subdistribution is only defined when a dataset distribution complenents another dataset and the complement exists of an addition and a deletion part.</para>
    /// labels<para>has sub distribution</para></remarks>
    /// <seealso href="https://w3id.org/cdc#hasSubDistribution">https://w3id.org/cdc#hasSubDistribution</seealso>
    let hasSubDistribution = Prefixed_Name(cdc, "hasSubDistribution") |> PrefixedName
    /// <summary>
    ///   <para>cdc:incoming</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DataManagementTag</para>
    ///   <para>A predefined tag to mark an incoming catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.</para>
    /// labels<para>incoming</para></remarks>
    /// <seealso href="https://w3id.org/cdc#incoming">https://w3id.org/cdc#incoming</seealso>
    let incoming = Prefixed_Name(cdc, "incoming") |> PrefixedName
    /// <summary>
    ///   <para>cdc:internal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cdc#DataManagementTag</para>
    ///   <para>A predefined tag to mark an internal (= not exchanged) catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.{</para>
    /// labels<para>internal</para></remarks>
    /// <seealso href="https://w3id.org/cdc#internal">https://w3id.org/cdc#internal</seealso>
    let internal_ = Prefixed_Name(cdc, "internal") |> PrefixedName
