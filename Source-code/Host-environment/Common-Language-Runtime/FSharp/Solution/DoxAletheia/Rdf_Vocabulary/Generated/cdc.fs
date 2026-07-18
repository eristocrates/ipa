namespace https.w3id.org.cdc.hash

open DoxAletheia.Rdf_Vocabulary

module cdc =
    let _namespace_name = "https://w3id.org/cdc#"

    /// <summary>
    /// A cdc:AdditionAndDeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). One of the two subdistributions (cdc:hasSubDistribution) of this direct distribution of dataset B is classified as cdc:AdditionDistribution, while the other is classified as cdc:DeletionDistribution.
    /// <see href="https://w3id.org/cdc#AdditionAndDeletionDistribution"></see></summary>
    let AdditionAndDeletionDistribution =
        Namespaced_IRI.parse _namespace_name "AdditionAndDeletionDistribution" |> NamespacedName

    /// <summary>
    /// A cdc:AdditionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the addition complement distribution of dataset B should be added to the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.
    /// <see href="https://w3id.org/cdc#AdditionDistribution"></see></summary>
    let AdditionDistribution =
        Namespaced_IRI.parse _namespace_name "AdditionDistribution" |> NamespacedName

    /// <summary>
    /// A cdc:DeletionDistribution is used to classify a distribution of a dataset B that complements another dataset A (connected using the cdc:complements relation). The content of the deletion complement distribution of dataset B should be subtracted from the entire content of dataset A to form dataset B. When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset.
    /// <see href="https://w3id.org/cdc#DeletionDistribution"></see></summary>
    let DeletionDistribution =
        Namespaced_IRI.parse _namespace_name "DeletionDistribution" |> NamespacedName

    /// <summary>
    /// A dataset describing a (part of a) planned construction that is the result of an architectural design process.
    /// <see href="https://w3id.org/cdc#ArchitecturalDesignDS"></see></summary>
    let ArchitecturalDesignDS =
        Namespaced_IRI.parse _namespace_name "ArchitecturalDesignDS" |> NamespacedName

    /// <summary>
    /// In contrast to an as-built dataset (cdc:AsBuiltDS), this type of construction dataset describes a future situation that is the outcome of some type of design process. Use its subclasses to be more specific about the type of design/planning.
    /// <see href="https://w3id.org/cdc#DesignDS"></see></summary>
    let DesignDS = Namespaced_IRI.parse _namespace_name "DesignDS" |> NamespacedName
    /// <summary>
    /// A construction dataset reflecting the physical as-built situation at a certain moment in time (snapshot or a period of time), e.g. before an intervention, during an intervention (progress monitoring) or after an intervention. Use its subclasses to be more specific about the type of as-built situation.
    /// <see href="https://w3id.org/cdc#AsBuiltDS"></see></summary>
    let AsBuiltDS = Namespaced_IRI.parse _namespace_name "AsBuiltDS" |> NamespacedName

    /// <summary>
    /// A dataset describing the requirements imposed by the construction owner at the start of a construction project. Such a dataset, when using RDF, can for example be described using SHACL shapes or a graph describing the components and spatial zones (and their properties) that should be provided in the delivered construction.
    /// <see href="https://w3id.org/cdc#OwnerRequirementsDS"></see></summary>
    let OwnerRequirementsDS =
        Namespaced_IRI.parse _namespace_name "OwnerRequirementsDS" |> NamespacedName

    /// <summary>
    /// A construction planning dataset, made by a designer or contractor. This type of dataset typically contains construction tasks (cto:Task) that are planned.
    /// <see href="https://w3id.org/cdc#ConstructionPlanningDS"></see></summary>
    let ConstructionPlanningDS =
        Namespaced_IRI.parse _namespace_name "ConstructionPlanningDS" |> NamespacedName

    /// <summary>
    /// A construction progress dataset, maintained by a construction site supervisor selected by the owner (e.g. the architect) or a contractor. This type of dataset contains construction tasks (cto:Task) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS (during construction progress monitoring of a running or relatively recent project) or cdc:HistoricalAsBuiltDS (for describing the results of a historical study regarding the construction process).
    /// <see href="https://w3id.org/cdc#ConstructionProgressDS"></see></summary>
    let ConstructionProgressDS =
        Namespaced_IRI.parse _namespace_name "ConstructionProgressDS" |> NamespacedName

    /// <summary>
    /// A contemporary as-built dataset depicts the construction as-is based on directly verifiable facts (e.g. a geometry survey). It typically forms the basis for managing maintenance information or construction progress monitoring. It can also be the starting point for a construction project.
    /// <see href="https://w3id.org/cdc#ContemporaryAsBuiltDS"></see></summary>
    let ContemporaryAsBuiltDS =
        Namespaced_IRI.parse _namespace_name "ContemporaryAsBuiltDS" |> NamespacedName

    /// <summary>
    /// A historical as-built dataset contains a description of a construction in the past based on historical research.
    /// <see href="https://w3id.org/cdc#HistoricalAsBuiltDS"></see></summary>
    let HistoricalAsBuiltDS =
        Namespaced_IRI.parse _namespace_name "HistoricalAsBuiltDS" |> NamespacedName

    /// <summary>
    /// A tag that is linked to a DCAT catalog, dataset, distribution or data service instance node using the cdc:hasDataManagementTag property. CDC predefines three instances of this class, i.e. cdc:incoming, cdc:internal and cdc:outgoing. Each catalog, dataset, distribution or data service can only have one tag that is not supposed to change over the lifetime of the described resource unless it considers a dataset (that is not a catalog). When necessary, qualified relations between DCAT entities can also get a tag.
    /// <see href="https://w3id.org/cdc#DataManagementTag"></see></summary>
    let DataManagementTag =
        Namespaced_IRI.parse _namespace_name "DataManagementTag" |> NamespacedName

    /// <summary>
    /// A DCAT distribution of an RDF dataset, where the content of the dataset can be found in the default graph of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).
    /// <see href="https://w3id.org/cdc#DefaultGraphDistribution"></see></summary>
    let DefaultGraphDistribution =
        Namespaced_IRI.parse _namespace_name "DefaultGraphDistribution" |> NamespacedName

    /// <summary>
    /// An instance of this class represents a qualified relation from a dataset distribution to another DCAT entity. It is connected to a cdc:DistributionRole instance via cdc:hadDistributionRole.
    /// <see href="https://w3id.org/cdc#DistributionRelation"></see></summary>
    let DistributionRelation =
        Namespaced_IRI.parse _namespace_name "DistributionRelation" |> NamespacedName

    /// <summary>
    /// A distribution role defines the kind of qualified relation between two dataset distributions.
    /// <see href="https://w3id.org/cdc#DistributionRole"></see></summary>
    let DistributionRole =
        Namespaced_IRI.parse _namespace_name "DistributionRole" |> NamespacedName

    /// <summary>
    /// An inspection as-built dataset, created by a construction inspector. This type of dataset contains detailed information about inspections, including inspection tasks (cto:InspectionTask) that are already executed. It can be used on a dataset already classified as cdc:ContemporaryAsBuiltDS.
    /// <see href="https://w3id.org/cdc#InspectionAsBuiltDS"></see></summary>
    let InspectionAsBuiltDS =
        Namespaced_IRI.parse _namespace_name "InspectionAsBuiltDS" |> NamespacedName

    /// <summary>
    /// An inspection planning dataset, made by a construction inspector. This type of dataset typically contains inspection tasks (cto:InspectionTask, subclasses of cto:Task) that are planned, indicating which parts of the construction will be inspected.
    /// <see href="https://w3id.org/cdc#InspectionPlanningDS"></see></summary>
    let InspectionPlanningDS =
        Namespaced_IRI.parse _namespace_name "InspectionPlanningDS" |> NamespacedName

    /// <summary>
    /// A dataset describing a (part of a) planned construction that is the result of a MEP engineering (mechanical, electrical and plumbing) design process.
    /// <see href="https://w3id.org/cdc#MEPDesignDS"></see></summary>
    let MEPDesignDS =
        Namespaced_IRI.parse _namespace_name "MEPDesignDS" |> NamespacedName

    /// <summary>
    /// A DCAT distribution of an RDF dataset, where the content of the dataset can be found in a single named graph (specified using cdc:graphURI) of an RDF quad file (connected with dcat:downloadURL) or quadstore (connected with dcat:accessService).
    /// <see href="https://w3id.org/cdc#NamedGraphDistribution"></see></summary>
    let NamedGraphDistribution =
        Namespaced_IRI.parse _namespace_name "NamedGraphDistribution" |> NamespacedName

    /// <summary>
    /// A cdc:StandaloneDistribution is applied to classify a distribution as being standalone, meaning that it does not complement to the content of another dataset. Consequently, the content served by this distribution is equal to the entire content represented by its dataset. If a standalone distribution is derived from a complementing distribution of the same dataset, it can be connected using the cdc:standaloneOf relation.
    /// <see href="https://w3id.org/cdc#StandaloneDistribution"></see></summary>
    let StandaloneDistribution =
        Namespaced_IRI.parse _namespace_name "StandaloneDistribution" |> NamespacedName

    /// <summary>
    /// A dataset describing a (part of a) planned construction that is the result of a structural engineering design process.
    /// <see href="https://w3id.org/cdc#StructuralDesignDS"></see></summary>
    let StructuralDesignDS =
        Namespaced_IRI.parse _namespace_name "StructuralDesignDS" |> NamespacedName

    /// <summary>
    /// An instance of this class is used to describe the result of a comparison between a design, a construction planning or a finalized as-built dataset and a dataset with requirements it tries to fulfill. The validation report node can be equal to the top node of a SHACL validation report RDF graph (e.g. owner requirements vs. design), or it can point to either two RDF datasets (cdc:onlyInSourceDS or cdc:onlyInTargetDS) containing the result of a subtraction (e.g. design vs. as-built) or a free text explanation of the comparison result (rdfs:comment).
    /// <see href="https://w3id.org/cdc#ValidationReport"></see></summary>
    let ValidationReport =
        Namespaced_IRI.parse _namespace_name "ValidationReport" |> NamespacedName

    /// <summary>
    /// A property to directly connect a dataset to another dataset that proposes an alternative for the same construction context. This means that there is an overlap between the contexts of both datasets such as the construction described, the content type (e.g. two alternative designs (cdc:DesignDS) or two historical as built situations based on different sources (cdc:HistoricalAsBuiltDS)) and/or the timing. In the case of two alternative designs, the related owner requirements should be the same. When considering two alternative historical as-built situations, the temporal context should have an overlap.
    /// <see href="https://w3id.org/cdc#alternative"></see></summary>
    let alternative =
        Namespaced_IRI.parse _namespace_name "alternative" |> NamespacedName

    /// <summary>
    /// A role of a qualified relation between a distribution of a dataset B that complements another dataset A, where the source distribution (subject of cdc:qualifiedDistributionRelation) complements the target dataset (object of dcterms:relation). The intermediate node between the distribution of dataset B and dataset A has a property cdc:hadDistributionRole pointing to cdc:complementLink.
    ///
    /// When the dataset B is the result of both additions and deletions on dataset A, dataset B should have a direct distribution with two subdistributions (cdc:hasSubDistribution): one containing triples to be deleted (cdc:DeletetionDistribution) from the source dataset and another containing triples that should be added (cdc:AdditionDistribution) to the source dataset. The qualified relation described above is established between the direct distribution of dataset B and dataset A .
    /// <see href="https://w3id.org/cdc#complementLink"></see></summary>
    let complementLink =
        Namespaced_IRI.parse _namespace_name "complementLink" |> NamespacedName

    /// <summary>
    /// A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).
    /// <see href="https://w3id.org/cdc#complements"></see></summary>
    let complements =
        Namespaced_IRI.parse _namespace_name "complements" |> NamespacedName

    /// <summary>
    /// By connecting this node to a cdc:DistributionRelation instance, the source distribution (subject of cdc:qualifiedDistributionRelation) is marked as a copy of the target distribution (object of dcterms:relation).
    /// <see href="https://w3id.org/cdc#copiedDistributionLink"></see></summary>
    let copiedDistributionLink =
        Namespaced_IRI.parse _namespace_name "copiedDistributionLink" |> NamespacedName

    /// <summary>
    /// A property to directly connect two distributions of the same dataset, where the source distribution is a content-wise copy of the target distribution. Examples are a received dataset accompanied by an incoming distribution. The content served by this incoming distribution can be copied to an internal distribution of the same dataset to improve accessability.
    /// <see href="https://w3id.org/cdc#copiedDistributionOf"></see></summary>
    let copiedDistributionOf =
        Namespaced_IRI.parse _namespace_name "copiedDistributionOf" |> NamespacedName

    /// <summary>
    /// Connects a distribution to the version of the dataset it distributes. The dataset version can be identified via a dateTime or a string identifier.
    /// <see href="https://w3id.org/cdc#distributedDatasetVersion"></see></summary>
    let distributedDatasetVersion =
        Namespaced_IRI.parse _namespace_name "distributedDatasetVersion" |> NamespacedName

    /// <summary>
    /// A Boolean property to assert if a certain set of requirements contained in a dataset is fulfilled by another dataset. It should only be used on instances of dcat:Relation with a dcat:hadRole property pointing to cdc:requirementLink.
    /// <see href="https://w3id.org/cdc#fulfilsRequirements"></see></summary>
    let fulfilsRequirements =
        Namespaced_IRI.parse _namespace_name "fulfilsRequirements" |> NamespacedName

    /// <summary>
    /// The URI of the named graph related to a cdc:NamedGraphDistribution.
    /// <see href="https://w3id.org/cdc#graphURI"></see></summary>
    let graphURI = Namespaced_IRI.parse _namespace_name "graphURI" |> NamespacedName

    /// <summary>
    /// A property to connect an instance of cdc:DistributionRelation to an instance of cdc:DistributionRole. The object of this property defines the type of the qualified distribution relation (cdc:qualifiedDistributionRelation) between a source distribution and another target DCAT entity.
    /// <see href="https://w3id.org/cdc#hadDistributionRole"></see></summary>
    let hadDistributionRole =
        Namespaced_IRI.parse _namespace_name "hadDistributionRole" |> NamespacedName

    /// <summary>
    /// Connects a DCAT catalog, dataset, distribution, data service or qualified relation (cdc:DistributionRelation or dcat:Relation) to exactly one of the following predefined data management tags: cdc:internal, cdc:incoming or cdc:outgoing.
    /// <see href="https://w3id.org/cdc#hasDataManagementTag"></see></summary>
    let hasDataManagementTag =
        Namespaced_IRI.parse _namespace_name "hasDataManagementTag" |> NamespacedName

    /// <summary>
    /// A property to connect two dcat:Distribution instances of a dataset, where the object node (instance of cdc:AdditionDistribution or cdc:DeletionDistribtion) is the sub distribution of the subject node (instance of class cdc:AdditionAndDeletionDistribution). A subdistribution is only defined when a dataset distribution complenents another dataset and the complement exists of an addition and a deletion part.
    /// <see href="https://w3id.org/cdc#hasSubDistribution"></see></summary>
    let hasSubDistribution =
        Namespaced_IRI.parse _namespace_name "hasSubDistribution" |> NamespacedName

    /// <summary>
    /// A property connecting a qualified relation between two datasets (instance of dcat:Relation) with cdc:requirementLink as role to a node representing the validation report (instance of cdc:ValidationReport).
    /// <see href="https://w3id.org/cdc#hasValidationReport"></see></summary>
    let hasValidationReport =
        Namespaced_IRI.parse _namespace_name "hasValidationReport" |> NamespacedName

    /// <summary>
    /// A predefined tag to mark an incoming catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.
    /// <see href="https://w3id.org/cdc#incoming"></see></summary>
    let incoming = Namespaced_IRI.parse _namespace_name "incoming" |> NamespacedName
    /// <summary>
    /// A predefined tag to mark an internal (= not exchanged) catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.{
    /// <see href="https://w3id.org/cdc#internal"></see></summary>
    let internal_ = Namespaced_IRI.parse _namespace_name "internal" |> NamespacedName

    /// <summary>
    /// When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset A should be contained in a dataset that is connected using this property.
    /// <see href="https://w3id.org/cdc#onlyInSourceDS"></see></summary>
    let onlyInSourceDS =
        Namespaced_IRI.parse _namespace_name "onlyInSourceDS" |> NamespacedName

    /// <summary>
    /// When the validation is done by comparing a descriptive RDF dataset A (source) containing the proposed design or executed construction to an RDF dataset B (target) containing the requirements, a diff is calculated between the two datasets. The triples that are only available in dataset B should be contained in a dataset that is connected using this property.
    /// <see href="https://w3id.org/cdc#onlyInTargetDS"></see></summary>
    let onlyInTargetDS =
        Namespaced_IRI.parse _namespace_name "onlyInTargetDS" |> NamespacedName

    /// <summary>
    /// A predefined tag to mark an outgoing catalog, dataset, distribution or data service. It can also be used to annotate qualified relations between DCAT entities.{
    /// <see href="https://w3id.org/cdc#outgoing"></see></summary>
    let outgoing = Namespaced_IRI.parse _namespace_name "outgoing" |> NamespacedName

    /// <summary>
    /// A property to connect a source distribution to an instance of cdc:DistributionRelation, to form a qualified relation towards another DCAT entity.
    /// <see href="https://w3id.org/cdc#qualifiedDistributionRelation"></see></summary>
    let qualifiedDistributionRelation =
        Namespaced_IRI.parse _namespace_name "qualifiedDistributionRelation" |> NamespacedName

    /// <summary>
    /// A role of a qualified relation between two datasets A and B. Dataset A has an outgoing dcat:qualifiedRelation property to an intermediate node that has an outgoing dcterms:relation property to dataset B. The intermediate node is connected using dcat:hadRole to cdc:requirementLink. The proposal contained in the source dataset (e.g. a cdc:DesignDS or a cdc:AsBuiltDS after delivery) tries to answer the requirements contained in the target dataset (e.g. respectively a cdc:OwnerRequirementsDS, and a cdc:OwnerRequirementsDS or a cdc:DesignDS).
    /// <see href="https://w3id.org/cdc#requirementLink"></see></summary>
    let requirementLink =
        Namespaced_IRI.parse _namespace_name "requirementLink" |> NamespacedName

    /// <summary>
    /// A direct connection between owner requirements (cdc:OwnerRequirementsDS) and the as-built situation (cdc:AsBuiltDS or subclasses) before the start of a possible intervention.
    /// <see href="https://w3id.org/cdc#requirementsRelatedTo"></see></summary>
    let requirementsRelatedTo =
        Namespaced_IRI.parse _namespace_name "requirementsRelatedTo" |> NamespacedName

    /// <summary>
    /// A property to directly connect a snapshot dataset (temporal context represents a single moment, dcat:startDate and dcat:endDate are equal to each other) to a dataset that contains tasks (temporal context represents a period).
    /// <see href="https://w3id.org/cdc#snapshotOf"></see></summary>
    let snapshotOf = Namespaced_IRI.parse _namespace_name "snapshotOf" |> NamespacedName

    /// <summary>
    /// A role of a qualified relation between a standalone distribution (cdc:StandaloneDistribution) and a complementing distribution (cdc:AdditionDistribution, cdc:DeletionDistribution or cdc:AdditionAndDeletionDistribution) of the same dataset.
    /// <see href="https://w3id.org/cdc#standaloneLink"></see></summary>
    let standaloneLink =
        Namespaced_IRI.parse _namespace_name "standaloneLink" |> NamespacedName

    /// <summary>
    /// A property to directly connect a standalone distribution to a complementing distribution. Both distributions are serving the same dataset.
    /// <see href="https://w3id.org/cdc#standaloneOf"></see></summary>
    let standaloneOf =
        Namespaced_IRI.parse _namespace_name "standaloneOf" |> NamespacedName

    /// <summary>
    /// Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the source dataset or the dataset served by the source distribution. The dataset version can be identified via a dateTime or a string identifier.
    /// <see href="https://w3id.org/cdc#versionSourceDS"></see></summary>
    let versionSourceDS =
        Namespaced_IRI.parse _namespace_name "versionSourceDS" |> NamespacedName

    /// <summary>
    /// Connects a qualified relation between datasets (instance of dcat:Relation) and/or distributions of a dataset (instance of cdc:DistributionRelation) with a version identifier of the target dataset or the dataset served by the target distribution. The dataset version can be identified via a dateTime or a string identifier.
    /// <see href="https://w3id.org/cdc#versionTargetDS"></see></summary>
    let versionTargetDS =
        Namespaced_IRI.parse _namespace_name "versionTargetDS" |> NamespacedName
