#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module modp =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/mod#" "modp"
    /// <summary>
    ///   <para>rdfs:label : Analytics</para>
    ///   <para>rdfs:isDefinedBy : https://www.isibang.ac.in/ns/mod/1.4/</para>
    ///   <para>rdfs:comment : Number of visits an ontology received.</para>
    ///   <a href="https://w3id.org/mod#Analytics">modp:Analytics</a>
    /// </summary>
    let Analytics = _prefixId.prefix "Analytics"
    /// <summary>
    ///   <para>skos:historyNote : This class has been adopted from OMV Ontology Metadata Vocabulary, and renamed and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : Engineering Methodology</para>
    ///   <para>rdfs:comment : Information about the engineering methodology.</para>
    ///   <a href="https://w3id.org/mod#EngineeringMethodology">modp:EngineeringMethodology</a>
    /// </summary>
    let EngineeringMethodology = _prefixId.prefix "EngineeringMethodology"
    /// <summary>
    ///   <para>rdfs:label : Evaluation</para>
    ///   <para>rdfs:comment : The results of evaluating an ontology. An ontology can have more than one evaluations.</para>
    ///   <a href="https://w3id.org/mod#Evaluation">modp:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : A group of ontologies that the ontology is usually considered into.</para>
    ///   <a href="https://w3id.org/mod#Group">modp:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"

    /// <summary>
    ///   <para>rdfs:label : Knowledge representation paradigm</para>
    ///   <a href="https://w3id.org/mod#KnowledgeRepresentationParadigm">modp:KnowledgeRepresentationParadigm</a>
    /// </summary>
    let KnowledgeRepresentationParadigm =
        _prefixId.prefix "KnowledgeRepresentationParadigm"

    /// <summary>
    ///   <para>rdfs:label : Semantic Artefact</para>
    ///   <a href="https://w3id.org/mod#SemanticArtefact">modp:SemanticArtefact</a>
    /// </summary>
    let SemanticArtefact = _prefixId.prefix "SemanticArtefact"
    let SemanticArtefactCatalogRecord = _prefixId.prefix "SemanticArtefactCatalogRecord"
    let SemanticArtefactDistribution = _prefixId.prefix "SemanticArtefactDistribution"
    /// <summary>
    ///   <para>rdfs:label : Semantic Artefact Evaluation</para>
    ///   <a href="https://w3id.org/mod#SemanticArtefactEvaluation">modp:SemanticArtefactEvaluation</a>
    /// </summary>
    let SemanticArtefactEvaluation = _prefixId.prefix "SemanticArtefactEvaluation"
    let SemanticArtefactService = _prefixId.prefix "SemanticArtefactService"
    /// <summary>
    ///   <para>rdfs:label : Semantic Artefact Task</para>
    ///   <a href="https://w3id.org/mod#SemanticArtefactTask">modp:SemanticArtefactTask</a>
    /// </summary>
    let SemanticArtefactTask = _prefixId.prefix "SemanticArtefactTask"
    let SemanticArtfeactCatalog = _prefixId.prefix "SemanticArtfeactCatalog"
    let Taxonomy = _prefixId.prefix "Taxonomy"
    let Terminology = _prefixId.prefix "Terminology"
    let Thesaurus = _prefixId.prefix "Thesaurus"
    /// <summary>
    ///   <para>rdfs:label : URI</para>
    ///   <para>rdfs:comment : The URI of the ontology which is described by this metadata.</para>
    ///   <a href="https://w3id.org/mod#URI">modp:URI</a>
    /// </summary>
    let URI = _prefixId.prefix "URI"
    /// <summary>
    ///   <para>rdfs:label : acronym</para>
    ///   <para>rdfs:comment : Often used as an identifier within some ontology platforms such as BioPortal or OBO Foundry.</para>
    ///   <a href="https://w3id.org/mod#acronym">modp:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:label : analytics</para>
    ///   <para>rdfs:isDefinedBy : https://www.isibang.ac.in/ns/mod/1.4/</para>
    ///   <para>rdfs:comment : This property shall be used to store any analytics for an ontology. E.g., number of visits an ontology received in a portal, number of downloads, etc.</para>
    ///   <a href="https://w3id.org/mod#analytics">modp:analytics</a>
    /// </summary>
    let analytics = _prefixId.prefix "analytics"
    /// <summary>
    ///   <para>rdfs:label : object author property</para>
    ///   <para>rdfs:comment : property used to specify the author of a class (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#authorProperty">modp:authorProperty</a>
    /// </summary>
    let authorProperty = _prefixId.prefix "authorProperty"
    /// <summary>
    ///   <para>rdfs:label : average number of children per class</para>
    ///   <para>rdfs:comment : Average number of children per class (BioPortal definition) .</para>
    ///   <a href="https://w3id.org/mod#averageChildCount">modp:averageChildCount</a>
    /// </summary>
    let averageChildCount = _prefixId.prefix "averageChildCount"
    /// <summary>
    ///   <para>rdfs:label : Browsing user interfacerdfs:label : browsing UI</para>
    ///   <para>rdfs:comment : The user interface (URL) where the ontology may be browsed or searched.</para>
    ///   <a href="https://w3id.org/mod#browsingUI">modp:browsingUI</a>
    /// </summary>
    let browsingUI = _prefixId.prefix "browsingUI"
    /// <summary>
    ///   <para>rdfs:label : number of classes with more than 25 children</para>
    ///   <para>rdfs:comment : Number of classes that have more than 25 direct subclasses (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#classesWithMoreThan25Children">modp:classesWithMoreThan25Children</a>
    /// </summary>
    let classesWithMoreThan25Children = _prefixId.prefix "classesWithMoreThan25Children"
    /// <summary>
    ///   <para>rdfs:label : number of classes with no definition</para>
    ///   <para>rdfs:comment : List of classes that have no value for the definition property (BioPortal definition). For ontologies in OBO and RRF formats, the property for definition is part of the language. For OWL ontologies, the authors specify this property as part of the ontology metadata (the default is skos:definition).</para>
    ///   <a href="https://w3id.org/mod#classesWithNoDefinition">modp:classesWithNoDefinition</a>
    /// </summary>
    let classesWithNoDefinition = _prefixId.prefix "classesWithNoDefinition"
    /// <summary>
    ///   <para>rdfs:label : number of classes with a single child</para>
    ///   <para>rdfs:comment : Number of classes that have only one subclass in the is-a hierarchy (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#classesWithOneChild">modp:classesWithOneChild</a>
    /// </summary>
    let classesWithOneChild = _prefixId.prefix "classesWithOneChild"
    /// <summary>
    ///   <para>rdfs:label : comes from the same domain</para>
    ///   <para>rdfs:comment : If the two ontologies come from the same domain (without any other details).</para>
    ///   <a href="https://w3id.org/mod#comesFromTheSameDomain">modp:comesFromTheSameDomain</a>
    /// </summary>
    let comesFromTheSameDomain = _prefixId.prefix "comesFromTheSameDomain"
    /// <summary>
    ///   <para>rdfs:label : competency question</para>
    ///   <para>rdfs:comment : A set of questions made to build an ontology at the design time.</para>
    ///   <a href="https://w3id.org/mod#competencyQuestion">modp:competencyQuestion</a>
    /// </summary>
    let competencyQuestion = _prefixId.prefix "competencyQuestion"

    /// <summary>
    ///   <para>skos:historyNote : This property has been adopted from OMV Ontology Metadata Vocabulary and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : conforms to knowledge representation paradigm</para>
    ///   <para>rdfs:comment : A representation formalism that is followed to describe knowledge in an ontology. Example includes description logics, first order logic, etc. dct: An established standard to which the described resource conforms.</para>
    ///   <a href="https://w3id.org/mod#conformsToKnowledgeRepresentationParadigm">modp:conformsToKnowledgeRepresentationParadigm</a>
    /// </summary>
    let conformsToKnowledgeRepresentationParadigm =
        _prefixId.prefix "conformsToKnowledgeRepresentationParadigm"

    /// <summary>
    ///   <para>rdfs:label : object definition property</para>
    ///   <para>rdfs:comment : Property used to specify the definition of a class (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#definitionProperty">modp:definitionProperty</a>
    /// </summary>
    let definitionProperty = _prefixId.prefix "definitionProperty"
    /// <summary>
    ///   <para>rdfs:label : depiction</para>
    ///   <para>rdfs:comment : A depiction of some thing.</para>
    ///   <a href="https://w3id.org/mod#depiction">modp:depiction</a>
    /// </summary>
    let depiction = _prefixId.prefix "depiction"
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : designed for task</para>
    ///   <a href="https://w3id.org/mod#designedForTask">modp:designedForTask</a>
    /// </summary>
    let designedForTask = _prefixId.prefix "designedForTask"
    /// <summary>
    ///   <para>rdfs:label : endorsed by</para>
    ///   <para>rdfs:comment : An ontology endorsed by an agent.</para>
    ///   <a href="https://w3id.org/mod#endorsedBy">modp:endorsedBy</a>
    /// </summary>
    let endorsedBy = _prefixId.prefix "endorsedBy"
    /// <summary>
    ///   <para>rdfs:label : generalizes</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.</para>
    ///   <a href="https://w3id.org/mod#generalizes">modp:generalizes</a>
    /// </summary>
    let generalizes = _prefixId.prefix "generalizes"
    /// <summary>
    ///   <para>rdfs:label : group</para>
    ///   <para>rdfs:comment : A group of ontologies that the ontology is usually considered into.</para>
    ///   <a href="https://w3id.org/mod#group">modp:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : has disjunctions with</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary declares some disjunct classes with the object vocabulary.</para>
    ///   <a href="https://w3id.org/mod#hasDisjunctionsWith">modp:hasDisjunctionsWith</a>
    /// </summary>
    let hasDisjunctionsWith = _prefixId.prefix "hasDisjunctionsWith"
    /// <summary>
    ///   <para>rdfs:label : disparate modelling with</para>
    ///   <para>rdfs:comment : Disagreements related  to  the  conceptualization  of  the  ontologies. Two ontologies are considered to have disparate modeling if they represent corresponding entities in different ways, e.g.  as an instance in one case and a class in the other.</para>
    ///   <a href="https://w3id.org/mod#hasDisparateModellingWith">modp:hasDisparateModellingWith</a>
    /// </summary>
    let hasDisparateModellingWith = _prefixId.prefix "hasDisparateModellingWith"
    /// <summary>
    ///   <para>rdfs:label : ontology aligned to</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.</para>
    ///   <a href="https://w3id.org/mod#hasEquivalencesWith">modp:hasEquivalencesWith</a>
    /// </summary>
    let hasEquivalencesWith = _prefixId.prefix "hasEquivalencesWith"
    /// <summary>
    ///   <para>rdfs:label : has evaluation</para>
    ///   <para>rdfs:comment : This property makes a relationship between an ontology and its evaluation result.</para>
    ///   <a href="https://w3id.org/mod#hasEvaluation">modp:hasEvaluation</a>
    /// </summary>
    let hasEvaluation = _prefixId.prefix "hasEvaluation"
    /// <summary>
    ///   <para>skos:historyNote : This property has been adopted from OMV Ontology Metadata Vocabulary and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : has formality level</para>
    ///   <para>rdfs:comment : The level of formality of an ontology.</para>
    ///   <a href="https://w3id.org/mod#hasFormalityLevel">modp:hasFormalityLevel</a>
    /// </summary>
    let hasFormalityLevel = _prefixId.prefix "hasFormalityLevel"
    /// <summary>
    ///   <para>rdfs:label : has representation language</para>
    ///   <para>rdfs:comment : A language that is used to create an ontology.</para>
    ///   <a href="https://w3id.org/mod#hasRepresentationLanguage">modp:hasRepresentationLanguage</a>
    /// </summary>
    let hasRepresentationLanguage = _prefixId.prefix "hasRepresentationLanguage"
    /// <summary>
    ///   <para>rdfs:label : has syntax</para>
    ///   <para>rdfs:comment : The syntax followed in the creation of an ontology.</para>
    ///   <a href="https://w3id.org/mod#hasSyntax">modp:hasSyntax</a>
    /// </summary>
    let hasSyntax = _prefixId.prefix "hasSyntax"
    /// <summary>
    ///   <para>rdfs:label : transitive hierarchy property</para>
    ///   <para>rdfs:comment : property used to specify the hierarchy  (e.g. rdfs:subClassOf or skos:broader).</para>
    ///   <a href="https://w3id.org/mod#hierarchyProperty">modp:hierarchyProperty</a>
    /// </summary>
    let hierarchyProperty = _prefixId.prefix "hierarchyProperty"
    /// <summary>
    ///   <para>skos:historyNote : This property has been adopted from OMV Ontology Metadata Vocabulary and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : known usage</para>
    ///   <para>rdfs:comment : The applications where the ontology is being used.</para>
    ///   <a href="https://w3id.org/mod#knownUsage">modp:knownUsage</a>
    /// </summary>
    let knownUsage = _prefixId.prefix "knownUsage"
    /// <summary>
    ///   <para>rdfs:label : maximum number of children per class</para>
    ///   <para>rdfs:comment : Maximum number of children per class (BioPortal definition)
    /// Screen reader support enabled.</para>
    ///   <a href="https://w3id.org/mod#maxChildCount">modp:maxChildCount</a>
    /// </summary>
    let maxChildCount = _prefixId.prefix "maxChildCount"
    /// <summary>
    ///   <para>rdfs:label : maximum depth of the hierarchy</para>
    ///   <para>rdfs:comment : Maximum depth of the hierarchy tree (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#maxDepth">modp:maxDepth</a>
    /// </summary>
    let maxDepth = _prefixId.prefix "maxDepth"
    /// <summary>
    ///   <para>rdfs:label : metadata vocubulary used</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary uses the object vocabulary in metadata at vocabulary or element level.</para>
    ///   <a href="https://w3id.org/mod#metadataVoc">modp:metadataVoc</a>
    /// </summary>
    let metadataVoc = _prefixId.prefix "metadataVoc"
    /// <summary>
    ///   <para>rdfs:label : metrics</para>
    ///   <para>rdfs:comment : A generic property to store any metrics related to the ontology.</para>
    ///   <a href="https://w3id.org/mod#metrics">modp:metrics</a>
    /// </summary>
    let metrics = _prefixId.prefix "metrics"
    /// <summary>
    ///   <para>rdfs:label : number of axioms or triples</para>
    ///   <para>rdfs:comment : The total number of axioms in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfAxioms">modp:numberOfAxioms</a>
    /// </summary>
    let numberOfAxioms = _prefixId.prefix "numberOfAxioms"
    /// <summary>
    ///   <para>rdfs:label : number of classes</para>
    ///   <para>rdfs:comment : The total number of classes in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfClasses">modp:numberOfClasses</a>
    /// </summary>
    let numberOfClasses = _prefixId.prefix "numberOfClasses"
    /// <summary>
    ///   <para>rdfs:label : number of data properties</para>
    ///   <para>rdfs:comment : The total number of data properties in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfDataProperties">modp:numberOfDataProperties</a>
    /// </summary>
    let numberOfDataProperties = _prefixId.prefix "numberOfDataProperties"
    /// <summary>
    ///   <para>rdfs:label : number of individuals</para>
    ///   <para>rdfs:comment : The total number of individuals in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfIndividuals">modp:numberOfIndividuals</a>
    /// </summary>
    let numberOfIndividuals = _prefixId.prefix "numberOfIndividuals"
    /// <summary>
    ///   <para>rdfs:label : number of labels</para>
    ///   <para>rdfs:comment : Number of defined labels for any resources in an ontology (classes, properties, etc).</para>
    ///   <a href="https://w3id.org/mod#numberOfLabels">modp:numberOfLabels</a>
    /// </summary>
    let numberOfLabels = _prefixId.prefix "numberOfLabels"
    /// <summary>
    ///   <para>rdfs:label : number of object properties</para>
    ///   <para>rdfs:comment : The total number of object properties in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfObjectProperties">modp:numberOfObjectProperties</a>
    /// </summary>
    let numberOfObjectProperties = _prefixId.prefix "numberOfObjectProperties"
    /// <summary>
    ///   <para>rdfs:label : number of properties</para>
    ///   <para>rdfs:comment : The total number of properties in an ontology.</para>
    ///   <a href="https://w3id.org/mod#numberOfProperties">modp:numberOfProperties</a>
    /// </summary>
    let numberOfProperties = _prefixId.prefix "numberOfProperties"
    /// <summary>
    ///   <para>rdfs:label : root of obsolete branch</para>
    ///   <para>rdfs:comment : property used to specify the root of an obsolete branch in the ontology.</para>
    ///   <a href="https://w3id.org/mod#obsoleteParent">modp:obsoleteParent</a>
    /// </summary>
    let obsoleteParent = _prefixId.prefix "obsoleteParent"
    /// <summary>
    ///   <para>rdfs:label : object obsolete property</para>
    ///   <para>rdfs:comment : property used to specify an obsolete class.</para>
    ///   <a href="https://w3id.org/mod#obsoleteProperty">modp:obsoleteProperty</a>
    /// </summary>
    let obsoleteProperty = _prefixId.prefix "obsoleteProperty"
    /// <summary>
    ///   <para>rdfs:label : object preferred label property</para>
    ///   <para>rdfs:comment : Property used to specify preferred name (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#prefLabelPropert">modp:prefLabelPropert</a>
    /// </summary>
    let prefLabelPropert = _prefixId.prefix "prefLabelPropert"
    /// <summary>
    ///   <para>rdfs:label : qualified relation</para>
    ///   <para>rdfs:comment : Link to a description of a relationship with another resource.</para>
    ///   <a href="https://w3id.org/mod#qualifiedRelation">modp:qualifiedRelation</a>
    /// </summary>
    let qualifiedRelation = _prefixId.prefix "qualifiedRelation"
    /// <summary>
    ///   <para>rdfs:label : sample queries</para>
    ///   <para>rdfs:comment : A set of queries (may be SPARQL, DL Queries) that are provided along with an ontology.</para>
    ///   <a href="https://w3id.org/mod#sampleQueries">modp:sampleQueries</a>
    /// </summary>
    let sampleQueries = _prefixId.prefix "sampleQueries"
    let semanticArtefactRelation = _prefixId.prefix "semanticArtefactRelation"
    /// <summary>
    ///   <para>rdfs:label : similar to</para>
    ///   <para>rdfs:comment : Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.</para>
    ///   <a href="https://w3id.org/mod#similar">modp:similar</a>
    /// </summary>
    let similar = _prefixId.prefix "similar"
    /// <summary>
    ///   <para>rdfs:label : specializes</para>
    ///   <para>rdfs:comment : An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. voaf:Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.</para>
    ///   <a href="https://w3id.org/mod#specializes">modp:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>skos:historyNote : This property has been adopted from OMV Ontology Metadata Vocabulary and redefined in the MOD namespace.</para>
    ///   <para>rdfs:comment : The tracking information for the contents of the ontology.</para>
    ///   <a href="https://w3id.org/mod#status">modp:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : object synonym property</para>
    ///   <para>rdfs:comment : Property used to specify preferred name (BioPortal definition).</para>
    ///   <a href="https://w3id.org/mod#synonymProperty">modp:synonymProperty</a>
    /// </summary>
    let synonymProperty = _prefixId.prefix "synonymProperty"
    /// <summary>
    ///   <para>skos:historyNote : This property had been originally defined by VOAF metadata vocabulary.
    /// Now, it has been adopted and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : to do list</para>
    ///   <para>rdfs:comment : Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.</para>
    ///   <a href="https://w3id.org/mod#toDoList">modp:toDoList</a>
    /// </summary>
    let toDoList = _prefixId.prefix "toDoList"
    /// <summary>
    ///   <para>rdfs:label : used by</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary is used by the object vocabulary.</para>
    ///   <a href="https://w3id.org/mod#usedBy">modp:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"
    /// <summary>
    ///   <para>skos:historyNote : This property has been adopted from OMV Ontology Metadata Vocabulary, and renamed and redefined in the MOD namespace.</para>
    ///   <para>rdfs:label : used engineering methodology</para>
    ///   <a href="https://w3id.org/mod#usedEngineeringMethodology">modp:usedEngineeringMethodology</a>
    /// </summary>
    let usedEngineeringMethodology = _prefixId.prefix "usedEngineeringMethodology"
    /// <summary>
    ///   <para>rdfs:label : used in project</para>
    ///   <para>rdfs:comment : An semantic artefact that is used in a project.</para>
    ///   <a href="https://w3id.org/mod#usedInProject">modp:usedInProject</a>
    /// </summary>
    let usedInProject = _prefixId.prefix "usedInProject"
