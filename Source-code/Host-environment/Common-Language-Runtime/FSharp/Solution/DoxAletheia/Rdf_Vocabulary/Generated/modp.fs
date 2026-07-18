namespace https.w3id.org._mod.hash

open DoxAletheia.Rdf_Vocabulary

module modp =
    let _namespace_name = "https://w3id.org/mod#"

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefact"></see>
    /// </summary>
    let SemanticArtefact =
        Namespaced_IRI.parse _namespace_name "SemanticArtefact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactDistribution"></see>
    /// </summary>
    let SemanticArtefactDistribution =
        Namespaced_IRI.parse _namespace_name "SemanticArtefactDistribution" |> NamespacedName

    /// <summary>
    /// Number of visits an ontology received.
    /// <see href="https://w3id.org/mod#Analytics"></see></summary>
    let Analytics = Namespaced_IRI.parse _namespace_name "Analytics" |> NamespacedName

    /// <summary>
    /// Information about the engineering methodology.
    /// <see href="https://w3id.org/mod#EngineeringMethodology"></see></summary>
    let EngineeringMethodology =
        Namespaced_IRI.parse _namespace_name "EngineeringMethodology" |> NamespacedName

    /// <summary>
    /// The results of evaluating an ontology. An ontology can have more than one evaluations.
    /// <see href="https://w3id.org/mod#Evaluation"></see></summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName
    /// <summary>
    /// A group of ontologies that the ontology is usually considered into.
    /// <see href="https://w3id.org/mod#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#KnowledgeRepresentationParadigm"></see>
    /// </summary>
    let KnowledgeRepresentationParadigm =
        Namespaced_IRI.parse _namespace_name "KnowledgeRepresentationParadigm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactCatalogRecord"></see>
    /// </summary>
    let SemanticArtefactCatalogRecord =
        Namespaced_IRI.parse _namespace_name "SemanticArtefactCatalogRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactEvaluation"></see>
    /// </summary>
    let SemanticArtefactEvaluation =
        Namespaced_IRI.parse _namespace_name "SemanticArtefactEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactService"></see>
    /// </summary>
    let SemanticArtefactService =
        Namespaced_IRI.parse _namespace_name "SemanticArtefactService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactTask"></see>
    /// </summary>
    let SemanticArtefactTask =
        Namespaced_IRI.parse _namespace_name "SemanticArtefactTask" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtfeactCatalog"></see>
    /// </summary>
    let SemanticArtfeactCatalog =
        Namespaced_IRI.parse _namespace_name "SemanticArtfeactCatalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#Taxonomy"></see>
    /// </summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#Terminology"></see>
    /// </summary>
    let Terminology =
        Namespaced_IRI.parse _namespace_name "Terminology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#Thesaurus"></see>
    /// </summary>
    let Thesaurus = Namespaced_IRI.parse _namespace_name "Thesaurus" |> NamespacedName
    /// <summary>
    /// The URI of the ontology which is described by this metadata.
    /// <see href="https://w3id.org/mod#URI"></see></summary>
    let URI = Namespaced_IRI.parse _namespace_name "URI" |> NamespacedName
    /// <summary>
    /// Often used as an identifier within some ontology platforms such as BioPortal or OBO Foundry.
    /// <see href="https://w3id.org/mod#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName
    /// <summary>
    /// This property shall be used to store any analytics for an ontology. E.g., number of visits an ontology received in a portal, number of downloads, etc.
    /// <see href="https://w3id.org/mod#analytics"></see></summary>
    let analytics = Namespaced_IRI.parse _namespace_name "analytics" |> NamespacedName

    /// <summary>
    /// property used to specify the author of a class (BioPortal definition).
    /// <see href="https://w3id.org/mod#authorProperty"></see></summary>
    let authorProperty =
        Namespaced_IRI.parse _namespace_name "authorProperty" |> NamespacedName

    /// <summary>
    /// Average number of children per class (BioPortal definition) .
    /// <see href="https://w3id.org/mod#averageChildCount"></see></summary>
    let averageChildCount =
        Namespaced_IRI.parse _namespace_name "averageChildCount" |> NamespacedName

    /// <summary>
    /// A generic property to store any metrics related to the ontology.
    /// <see href="https://w3id.org/mod#metrics"></see></summary>
    let metrics = Namespaced_IRI.parse _namespace_name "metrics" |> NamespacedName
    /// <summary>
    /// The user interface (URL) where the ontology may be browsed or searched.
    /// <see href="https://w3id.org/mod#browsingUI"></see></summary>
    let browsingUI = Namespaced_IRI.parse _namespace_name "browsingUI" |> NamespacedName

    /// <summary>
    /// Number of classes that have more than 25 direct subclasses (BioPortal definition).
    /// <see href="https://w3id.org/mod#classesWithMoreThan25Children"></see></summary>
    let classesWithMoreThan25Children =
        Namespaced_IRI.parse _namespace_name "classesWithMoreThan25Children" |> NamespacedName

    /// <summary>
    /// List of classes that have no value for the definition property (BioPortal definition). For ontologies in OBO and RRF formats, the property for definition is part of the language. For OWL ontologies, the authors specify this property as part of the ontology metadata (the default is skos:definition).
    /// <see href="https://w3id.org/mod#classesWithNoDefinition"></see></summary>
    let classesWithNoDefinition =
        Namespaced_IRI.parse _namespace_name "classesWithNoDefinition" |> NamespacedName

    /// <summary>
    /// Number of classes that have only one subclass in the is-a hierarchy (BioPortal definition).
    /// <see href="https://w3id.org/mod#classesWithOneChild"></see></summary>
    let classesWithOneChild =
        Namespaced_IRI.parse _namespace_name "classesWithOneChild" |> NamespacedName

    /// <summary>
    /// If the two ontologies come from the same domain (without any other details).
    /// <see href="https://w3id.org/mod#comesFromTheSameDomain"></see></summary>
    let comesFromTheSameDomain =
        Namespaced_IRI.parse _namespace_name "comesFromTheSameDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#semanticArtefactRelation"></see>
    /// </summary>
    let semanticArtefactRelation =
        Namespaced_IRI.parse _namespace_name "semanticArtefactRelation" |> NamespacedName

    /// <summary>
    /// A set of questions made to build an ontology at the design time.
    /// <see href="https://w3id.org/mod#competencyQuestion"></see></summary>
    let competencyQuestion =
        Namespaced_IRI.parse _namespace_name "competencyQuestion" |> NamespacedName

    /// <summary>
    /// A representation formalism that is followed to describe knowledge in an ontology. Example includes description logics, first order logic, etc. dct: An established standard to which the described resource conforms.
    /// <see href="https://w3id.org/mod#conformsToKnowledgeRepresentationParadigm"></see></summary>
    let conformsToKnowledgeRepresentationParadigm =
        Namespaced_IRI.parse _namespace_name "conformsToKnowledgeRepresentationParadigm" |> NamespacedName

    /// <summary>
    /// Property used to specify the definition of a class (BioPortal definition).
    /// <see href="https://w3id.org/mod#definitionProperty"></see></summary>
    let definitionProperty =
        Namespaced_IRI.parse _namespace_name "definitionProperty" |> NamespacedName

    /// <summary>
    /// A depiction of some thing.
    /// <see href="https://w3id.org/mod#depiction"></see></summary>
    let depiction = Namespaced_IRI.parse _namespace_name "depiction" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/mod#describes"></see>
    /// </summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#designedForTask"></see>
    /// </summary>
    let designedForTask =
        Namespaced_IRI.parse _namespace_name "designedForTask" |> NamespacedName

    /// <summary>
    /// An ontology endorsed by an agent.
    /// <see href="https://w3id.org/mod#endorsedBy"></see></summary>
    let endorsedBy = Namespaced_IRI.parse _namespace_name "endorsedBy" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.
    /// <see href="https://w3id.org/mod#generalizes"></see></summary>
    let generalizes =
        Namespaced_IRI.parse _namespace_name "generalizes" |> NamespacedName

    /// <summary>
    /// An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. voaf:Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.
    /// <see href="https://w3id.org/mod#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    /// A group of ontologies that the ontology is usually considered into.
    /// <see href="https://w3id.org/mod#group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary declares some disjunct classes with the object vocabulary.
    /// <see href="https://w3id.org/mod#hasDisjunctionsWith"></see></summary>
    let hasDisjunctionsWith =
        Namespaced_IRI.parse _namespace_name "hasDisjunctionsWith" |> NamespacedName

    /// <summary>
    /// Disagreements related  to  the  conceptualization  of  the  ontologies. Two ontologies are considered to have disparate modeling if they represent corresponding entities in different ways, e.g.  as an instance in one case and a class in the other.
    /// <see href="https://w3id.org/mod#hasDisparateModellingWith"></see></summary>
    let hasDisparateModellingWith =
        Namespaced_IRI.parse _namespace_name "hasDisparateModellingWith" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.
    /// <see href="https://w3id.org/mod#hasEquivalencesWith"></see></summary>
    let hasEquivalencesWith =
        Namespaced_IRI.parse _namespace_name "hasEquivalencesWith" |> NamespacedName

    /// <summary>
    /// This property makes a relationship between an ontology and its evaluation result.
    /// <see href="https://w3id.org/mod#hasEvaluation"></see></summary>
    let hasEvaluation =
        Namespaced_IRI.parse _namespace_name "hasEvaluation" |> NamespacedName

    /// <summary>
    /// The level of formality of an ontology.
    /// <see href="https://w3id.org/mod#hasFormalityLevel"></see></summary>
    let hasFormalityLevel =
        Namespaced_IRI.parse _namespace_name "hasFormalityLevel" |> NamespacedName

    /// <summary>
    /// A language that is used to create an ontology.
    /// <see href="https://w3id.org/mod#hasRepresentationLanguage"></see></summary>
    let hasRepresentationLanguage =
        Namespaced_IRI.parse _namespace_name "hasRepresentationLanguage" |> NamespacedName

    /// <summary>
    /// The syntax followed in the creation of an ontology.
    /// <see href="https://w3id.org/mod#hasSyntax"></see></summary>
    let hasSyntax = Namespaced_IRI.parse _namespace_name "hasSyntax" |> NamespacedName

    /// <summary>
    /// property used to specify the hierarchy  (e.g. rdfs:subClassOf or skos:broader).
    /// <see href="https://w3id.org/mod#hierarchyProperty"></see></summary>
    let hierarchyProperty =
        Namespaced_IRI.parse _namespace_name "hierarchyProperty" |> NamespacedName

    /// <summary>
    /// The applications where the ontology is being used.
    /// <see href="https://w3id.org/mod#knownUsage"></see></summary>
    let knownUsage = Namespaced_IRI.parse _namespace_name "knownUsage" |> NamespacedName

    /// <summary>
    /// Maximum number of children per class (BioPortal definition)
    /// Screen reader support enabled.
    /// <see href="https://w3id.org/mod#maxChildCount"></see></summary>
    let maxChildCount =
        Namespaced_IRI.parse _namespace_name "maxChildCount" |> NamespacedName

    /// <summary>
    /// Maximum depth of the hierarchy tree (BioPortal definition).
    /// <see href="https://w3id.org/mod#maxDepth"></see></summary>
    let maxDepth = Namespaced_IRI.parse _namespace_name "maxDepth" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary uses the object vocabulary in metadata at vocabulary or element level.
    /// <see href="https://w3id.org/mod#metadataVoc"></see></summary>
    let metadataVoc =
        Namespaced_IRI.parse _namespace_name "metadataVoc" |> NamespacedName

    /// <summary>
    /// The total number of axioms in an ontology.
    /// <see href="https://w3id.org/mod#numberOfAxioms"></see></summary>
    let numberOfAxioms =
        Namespaced_IRI.parse _namespace_name "numberOfAxioms" |> NamespacedName

    /// <summary>
    /// The total number of classes in an ontology.
    /// <see href="https://w3id.org/mod#numberOfClasses"></see></summary>
    let numberOfClasses =
        Namespaced_IRI.parse _namespace_name "numberOfClasses" |> NamespacedName

    /// <summary>
    /// The total number of data properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfDataProperties"></see></summary>
    let numberOfDataProperties =
        Namespaced_IRI.parse _namespace_name "numberOfDataProperties" |> NamespacedName

    /// <summary>
    /// The total number of properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfProperties"></see></summary>
    let numberOfProperties =
        Namespaced_IRI.parse _namespace_name "numberOfProperties" |> NamespacedName

    /// <summary>
    /// The total number of individuals in an ontology.
    /// <see href="https://w3id.org/mod#numberOfIndividuals"></see></summary>
    let numberOfIndividuals =
        Namespaced_IRI.parse _namespace_name "numberOfIndividuals" |> NamespacedName

    /// <summary>
    /// Number of defined labels for any resources in an ontology (classes, properties, etc).
    /// <see href="https://w3id.org/mod#numberOfLabels"></see></summary>
    let numberOfLabels =
        Namespaced_IRI.parse _namespace_name "numberOfLabels" |> NamespacedName

    /// <summary>
    /// The total number of object properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfObjectProperties"></see></summary>
    let numberOfObjectProperties =
        Namespaced_IRI.parse _namespace_name "numberOfObjectProperties" |> NamespacedName

    /// <summary>
    /// property used to specify the root of an obsolete branch in the ontology.
    /// <see href="https://w3id.org/mod#obsoleteParent"></see></summary>
    let obsoleteParent =
        Namespaced_IRI.parse _namespace_name "obsoleteParent" |> NamespacedName

    /// <summary>
    /// property used to specify an obsolete class.
    /// <see href="https://w3id.org/mod#obsoleteProperty"></see></summary>
    let obsoleteProperty =
        Namespaced_IRI.parse _namespace_name "obsoleteProperty" |> NamespacedName

    /// <summary>
    /// Property used to specify preferred name (BioPortal definition).
    /// <see href="https://w3id.org/mod#prefLabelPropert"></see></summary>
    let prefLabelPropert =
        Namespaced_IRI.parse _namespace_name "prefLabelPropert" |> NamespacedName

    /// <summary>
    /// Link to a description of a relationship with another resource.
    /// <see href="https://w3id.org/mod#qualifiedRelation"></see></summary>
    let qualifiedRelation =
        Namespaced_IRI.parse _namespace_name "qualifiedRelation" |> NamespacedName

    /// <summary>
    /// A set of queries (may be SPARQL, DL Queries) that are provided along with an ontology.
    /// <see href="https://w3id.org/mod#sampleQueries"></see></summary>
    let sampleQueries =
        Namespaced_IRI.parse _namespace_name "sampleQueries" |> NamespacedName

    /// <summary>
    /// Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.
    /// <see href="https://w3id.org/mod#similar"></see></summary>
    let similar = Namespaced_IRI.parse _namespace_name "similar" |> NamespacedName
    /// <summary>
    /// The tracking information for the contents of the ontology.
    /// <see href="https://w3id.org/mod#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// Property used to specify preferred name (BioPortal definition).
    /// <see href="https://w3id.org/mod#synonymProperty"></see></summary>
    let synonymProperty =
        Namespaced_IRI.parse _namespace_name "synonymProperty" |> NamespacedName

    /// <summary>
    /// Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.
    /// <see href="https://w3id.org/mod#toDoList"></see></summary>
    let toDoList = Namespaced_IRI.parse _namespace_name "toDoList" |> NamespacedName
    /// <summary>
    /// Indicates that the subject vocabulary is used by the object vocabulary.
    /// <see href="https://w3id.org/mod#usedBy"></see></summary>
    let usedBy = Namespaced_IRI.parse _namespace_name "usedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#usedEngineeringMethodology"></see>
    /// </summary>
    let usedEngineeringMethodology =
        Namespaced_IRI.parse _namespace_name "usedEngineeringMethodology" |> NamespacedName

    /// <summary>
    /// An semantic artefact that is used in a project.
    /// <see href="https://w3id.org/mod#usedInProject"></see></summary>
    let usedInProject =
        Namespaced_IRI.parse _namespace_name "usedInProject" |> NamespacedName
