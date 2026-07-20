namespace https.w3id.org._mod.hash

open DoxAletheia

module modp =
    let _namespace_name = "https://w3id.org/mod#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefact"></see>
    /// </summary>
    let SemanticArtefact = _prefix "SemanticArtefact"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactDistribution"></see>
    /// </summary>
    let SemanticArtefactDistribution = _prefix "SemanticArtefactDistribution"
    /// <summary>
    /// Number of visits an ontology received.
    /// <see href="https://w3id.org/mod#Analytics"></see></summary>
    let Analytics = _prefix "Analytics"
    /// <summary>
    /// Information about the engineering methodology.
    /// <see href="https://w3id.org/mod#EngineeringMethodology"></see></summary>
    let EngineeringMethodology = _prefix "EngineeringMethodology"
    /// <summary>
    /// The results of evaluating an ontology. An ontology can have more than one evaluations.
    /// <see href="https://w3id.org/mod#Evaluation"></see></summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    /// A group of ontologies that the ontology is usually considered into.
    /// <see href="https://w3id.org/mod#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="https://w3id.org/mod#KnowledgeRepresentationParadigm"></see>
    /// </summary>
    let KnowledgeRepresentationParadigm = _prefix "KnowledgeRepresentationParadigm"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactCatalogRecord"></see>
    /// </summary>
    let SemanticArtefactCatalogRecord = _prefix "SemanticArtefactCatalogRecord"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactEvaluation"></see>
    /// </summary>
    let SemanticArtefactEvaluation = _prefix "SemanticArtefactEvaluation"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactService"></see>
    /// </summary>
    let SemanticArtefactService = _prefix "SemanticArtefactService"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtefactTask"></see>
    /// </summary>
    let SemanticArtefactTask = _prefix "SemanticArtefactTask"
    /// <summary>
    ///   <see href="https://w3id.org/mod#SemanticArtfeactCatalog"></see>
    /// </summary>
    let SemanticArtfeactCatalog = _prefix "SemanticArtfeactCatalog"
    /// <summary>
    ///   <see href="https://w3id.org/mod#Taxonomy"></see>
    /// </summary>
    let Taxonomy = _prefix "Taxonomy"
    /// <summary>
    ///   <see href="https://w3id.org/mod#Terminology"></see>
    /// </summary>
    let Terminology = _prefix "Terminology"
    /// <summary>
    ///   <see href="https://w3id.org/mod#Thesaurus"></see>
    /// </summary>
    let Thesaurus = _prefix "Thesaurus"
    /// <summary>
    /// The URI of the ontology which is described by this metadata.
    /// <see href="https://w3id.org/mod#URI"></see></summary>
    let URI = _prefix "URI"
    /// <summary>
    /// Often used as an identifier within some ontology platforms such as BioPortal or OBO Foundry.
    /// <see href="https://w3id.org/mod#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    /// This property shall be used to store any analytics for an ontology. E.g., number of visits an ontology received in a portal, number of downloads, etc.
    /// <see href="https://w3id.org/mod#analytics"></see></summary>
    let analytics = _prefix "analytics"
    /// <summary>
    /// property used to specify the author of a class (BioPortal definition).
    /// <see href="https://w3id.org/mod#authorProperty"></see></summary>
    let authorProperty = _prefix "authorProperty"
    /// <summary>
    /// Average number of children per class (BioPortal definition) .
    /// <see href="https://w3id.org/mod#averageChildCount"></see></summary>
    let averageChildCount = _prefix "averageChildCount"
    /// <summary>
    /// A generic property to store any metrics related to the ontology.
    /// <see href="https://w3id.org/mod#metrics"></see></summary>
    let metrics = _prefix "metrics"
    /// <summary>
    /// The user interface (URL) where the ontology may be browsed or searched.
    /// <see href="https://w3id.org/mod#browsingUI"></see></summary>
    let browsingUI = _prefix "browsingUI"
    /// <summary>
    /// Number of classes that have more than 25 direct subclasses (BioPortal definition).
    /// <see href="https://w3id.org/mod#classesWithMoreThan25Children"></see></summary>
    let classesWithMoreThan25Children = _prefix "classesWithMoreThan25Children"
    /// <summary>
    /// List of classes that have no value for the definition property (BioPortal definition). For ontologies in OBO and RRF formats, the property for definition is part of the language. For OWL ontologies, the authors specify this property as part of the ontology metadata (the default is skos:definition).
    /// <see href="https://w3id.org/mod#classesWithNoDefinition"></see></summary>
    let classesWithNoDefinition = _prefix "classesWithNoDefinition"
    /// <summary>
    /// Number of classes that have only one subclass in the is-a hierarchy (BioPortal definition).
    /// <see href="https://w3id.org/mod#classesWithOneChild"></see></summary>
    let classesWithOneChild = _prefix "classesWithOneChild"
    /// <summary>
    /// If the two ontologies come from the same domain (without any other details).
    /// <see href="https://w3id.org/mod#comesFromTheSameDomain"></see></summary>
    let comesFromTheSameDomain = _prefix "comesFromTheSameDomain"
    /// <summary>
    ///   <see href="https://w3id.org/mod#semanticArtefactRelation"></see>
    /// </summary>
    let semanticArtefactRelation = _prefix "semanticArtefactRelation"
    /// <summary>
    /// A set of questions made to build an ontology at the design time.
    /// <see href="https://w3id.org/mod#competencyQuestion"></see></summary>
    let competencyQuestion = _prefix "competencyQuestion"

    /// <summary>
    /// A representation formalism that is followed to describe knowledge in an ontology. Example includes description logics, first order logic, etc. dct: An established standard to which the described resource conforms.
    /// <see href="https://w3id.org/mod#conformsToKnowledgeRepresentationParadigm"></see></summary>
    let conformsToKnowledgeRepresentationParadigm =
        _prefix "conformsToKnowledgeRepresentationParadigm"

    /// <summary>
    /// Property used to specify the definition of a class (BioPortal definition).
    /// <see href="https://w3id.org/mod#definitionProperty"></see></summary>
    let definitionProperty = _prefix "definitionProperty"
    /// <summary>
    /// A depiction of some thing.
    /// <see href="https://w3id.org/mod#depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    ///   <see href="https://w3id.org/mod#describes"></see>
    /// </summary>
    let describes = _prefix "describes"
    /// <summary>
    ///   <see href="https://w3id.org/mod#designedForTask"></see>
    /// </summary>
    let designedForTask = _prefix "designedForTask"
    /// <summary>
    /// An ontology endorsed by an agent.
    /// <see href="https://w3id.org/mod#endorsedBy"></see></summary>
    let endorsedBy = _prefix "endorsedBy"
    /// <summary>
    /// Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.
    /// <see href="https://w3id.org/mod#generalizes"></see></summary>
    let generalizes = _prefix "generalizes"
    /// <summary>
    /// An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. voaf:Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.
    /// <see href="https://w3id.org/mod#specializes"></see></summary>
    let specializes = _prefix "specializes"
    /// <summary>
    /// A group of ontologies that the ontology is usually considered into.
    /// <see href="https://w3id.org/mod#group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    /// Indicates that the subject vocabulary declares some disjunct classes with the object vocabulary.
    /// <see href="https://w3id.org/mod#hasDisjunctionsWith"></see></summary>
    let hasDisjunctionsWith = _prefix "hasDisjunctionsWith"
    /// <summary>
    /// Disagreements related  to  the  conceptualization  of  the  ontologies. Two ontologies are considered to have disparate modeling if they represent corresponding entities in different ways, e.g.  as an instance in one case and a class in the other.
    /// <see href="https://w3id.org/mod#hasDisparateModellingWith"></see></summary>
    let hasDisparateModellingWith = _prefix "hasDisparateModellingWith"
    /// <summary>
    /// Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.
    /// <see href="https://w3id.org/mod#hasEquivalencesWith"></see></summary>
    let hasEquivalencesWith = _prefix "hasEquivalencesWith"
    /// <summary>
    /// This property makes a relationship between an ontology and its evaluation result.
    /// <see href="https://w3id.org/mod#hasEvaluation"></see></summary>
    let hasEvaluation = _prefix "hasEvaluation"
    /// <summary>
    /// The level of formality of an ontology.
    /// <see href="https://w3id.org/mod#hasFormalityLevel"></see></summary>
    let hasFormalityLevel = _prefix "hasFormalityLevel"
    /// <summary>
    /// A language that is used to create an ontology.
    /// <see href="https://w3id.org/mod#hasRepresentationLanguage"></see></summary>
    let hasRepresentationLanguage = _prefix "hasRepresentationLanguage"
    /// <summary>
    /// The syntax followed in the creation of an ontology.
    /// <see href="https://w3id.org/mod#hasSyntax"></see></summary>
    let hasSyntax = _prefix "hasSyntax"
    /// <summary>
    /// property used to specify the hierarchy  (e.g. rdfs:subClassOf or skos:broader).
    /// <see href="https://w3id.org/mod#hierarchyProperty"></see></summary>
    let hierarchyProperty = _prefix "hierarchyProperty"
    /// <summary>
    /// The applications where the ontology is being used.
    /// <see href="https://w3id.org/mod#knownUsage"></see></summary>
    let knownUsage = _prefix "knownUsage"
    /// <summary>
    /// Maximum number of children per class (BioPortal definition)
    /// Screen reader support enabled.
    /// <see href="https://w3id.org/mod#maxChildCount"></see></summary>
    let maxChildCount = _prefix "maxChildCount"
    /// <summary>
    /// Maximum depth of the hierarchy tree (BioPortal definition).
    /// <see href="https://w3id.org/mod#maxDepth"></see></summary>
    let maxDepth = _prefix "maxDepth"
    /// <summary>
    /// Indicates that the subject vocabulary uses the object vocabulary in metadata at vocabulary or element level.
    /// <see href="https://w3id.org/mod#metadataVoc"></see></summary>
    let metadataVoc = _prefix "metadataVoc"
    /// <summary>
    /// The total number of axioms in an ontology.
    /// <see href="https://w3id.org/mod#numberOfAxioms"></see></summary>
    let numberOfAxioms = _prefix "numberOfAxioms"
    /// <summary>
    /// The total number of classes in an ontology.
    /// <see href="https://w3id.org/mod#numberOfClasses"></see></summary>
    let numberOfClasses = _prefix "numberOfClasses"
    /// <summary>
    /// The total number of data properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfDataProperties"></see></summary>
    let numberOfDataProperties = _prefix "numberOfDataProperties"
    /// <summary>
    /// The total number of properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfProperties"></see></summary>
    let numberOfProperties = _prefix "numberOfProperties"
    /// <summary>
    /// The total number of individuals in an ontology.
    /// <see href="https://w3id.org/mod#numberOfIndividuals"></see></summary>
    let numberOfIndividuals = _prefix "numberOfIndividuals"
    /// <summary>
    /// Number of defined labels for any resources in an ontology (classes, properties, etc).
    /// <see href="https://w3id.org/mod#numberOfLabels"></see></summary>
    let numberOfLabels = _prefix "numberOfLabels"
    /// <summary>
    /// The total number of object properties in an ontology.
    /// <see href="https://w3id.org/mod#numberOfObjectProperties"></see></summary>
    let numberOfObjectProperties = _prefix "numberOfObjectProperties"
    /// <summary>
    /// property used to specify the root of an obsolete branch in the ontology.
    /// <see href="https://w3id.org/mod#obsoleteParent"></see></summary>
    let obsoleteParent = _prefix "obsoleteParent"
    /// <summary>
    /// property used to specify an obsolete class.
    /// <see href="https://w3id.org/mod#obsoleteProperty"></see></summary>
    let obsoleteProperty = _prefix "obsoleteProperty"
    /// <summary>
    /// Property used to specify preferred name (BioPortal definition).
    /// <see href="https://w3id.org/mod#prefLabelPropert"></see></summary>
    let prefLabelPropert = _prefix "prefLabelPropert"
    /// <summary>
    /// Link to a description of a relationship with another resource.
    /// <see href="https://w3id.org/mod#qualifiedRelation"></see></summary>
    let qualifiedRelation = _prefix "qualifiedRelation"
    /// <summary>
    /// A set of queries (may be SPARQL, DL Queries) that are provided along with an ontology.
    /// <see href="https://w3id.org/mod#sampleQueries"></see></summary>
    let sampleQueries = _prefix "sampleQueries"
    /// <summary>
    /// Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.
    /// <see href="https://w3id.org/mod#similar"></see></summary>
    let similar = _prefix "similar"
    /// <summary>
    /// The tracking information for the contents of the ontology.
    /// <see href="https://w3id.org/mod#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Property used to specify preferred name (BioPortal definition).
    /// <see href="https://w3id.org/mod#synonymProperty"></see></summary>
    let synonymProperty = _prefix "synonymProperty"
    /// <summary>
    /// Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.
    /// <see href="https://w3id.org/mod#toDoList"></see></summary>
    let toDoList = _prefix "toDoList"
    /// <summary>
    /// Indicates that the subject vocabulary is used by the object vocabulary.
    /// <see href="https://w3id.org/mod#usedBy"></see></summary>
    let usedBy = _prefix "usedBy"
    /// <summary>
    ///   <see href="https://w3id.org/mod#usedEngineeringMethodology"></see>
    /// </summary>
    let usedEngineeringMethodology = _prefix "usedEngineeringMethodology"
    /// <summary>
    /// An semantic artefact that is used in a project.
    /// <see href="https://w3id.org/mod#usedInProject"></see></summary>
    let usedInProject = _prefix "usedInProject"
