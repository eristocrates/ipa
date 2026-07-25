namespace https.w3id.org._mod.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module modp =
    let _namespace_iri = Namespace_Iri modp |> NamespaceIRI
    /// <summary>
    ///   <para>modp:SemanticArtefact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Semantic Artefact</para></remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefact">https://w3id.org/mod#SemanticArtefact</seealso>
    let SemanticArtefact = Prefixed_Name(modp, "SemanticArtefact") |> PrefixedName
    /// <summary>
    ///   <para>modp:Analytics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of visits an ontology received.</para>
    /// labels<para>Analytics</para></remarks>
    /// <seealso href="https://w3id.org/mod#Analytics">https://w3id.org/mod#Analytics</seealso>
    let Analytics = Prefixed_Name(modp, "Analytics") |> PrefixedName

    /// <summary>
    ///   <para>modp:EngineeringMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the engineering methodology.</para>
    /// labels<para>Engineering Methodology</para></remarks>
    /// <seealso href="https://w3id.org/mod#EngineeringMethodology">https://w3id.org/mod#EngineeringMethodology</seealso>
    let EngineeringMethodology =
        Prefixed_Name(modp, "EngineeringMethodology") |> PrefixedName

    /// <summary>
    ///   <para>modp:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The results of evaluating an ontology. An ontology can have more than one evaluations.</para>
    /// labels<para>Evaluation</para></remarks>
    /// <seealso href="https://w3id.org/mod#Evaluation">https://w3id.org/mod#Evaluation</seealso>
    let Evaluation = Prefixed_Name(modp, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>modp:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of ontologies that the ontology is usually considered into.</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="https://w3id.org/mod#Group">https://w3id.org/mod#Group</seealso>
    let Group = Prefixed_Name(modp, "Group") |> PrefixedName

    /// <summary>
    ///   <para>modp:KnowledgeRepresentationParadigm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Knowledge representation paradigm</para></remarks>
    /// <seealso href="https://w3id.org/mod#KnowledgeRepresentationParadigm">https://w3id.org/mod#KnowledgeRepresentationParadigm</seealso>
    let KnowledgeRepresentationParadigm =
        Prefixed_Name(modp, "KnowledgeRepresentationParadigm") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtefactCatalogRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefactCatalogRecord">https://w3id.org/mod#SemanticArtefactCatalogRecord</seealso>
    let SemanticArtefactCatalogRecord =
        Prefixed_Name(modp, "SemanticArtefactCatalogRecord") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtefactEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Semantic Artefact Evaluation</para></remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefactEvaluation">https://w3id.org/mod#SemanticArtefactEvaluation</seealso>
    let SemanticArtefactEvaluation =
        Prefixed_Name(modp, "SemanticArtefactEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtefactService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefactService">https://w3id.org/mod#SemanticArtefactService</seealso>
    let SemanticArtefactService =
        Prefixed_Name(modp, "SemanticArtefactService") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtefactTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Semantic Artefact Task</para></remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefactTask">https://w3id.org/mod#SemanticArtefactTask</seealso>
    let SemanticArtefactTask =
        Prefixed_Name(modp, "SemanticArtefactTask") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtfeactCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtfeactCatalog">https://w3id.org/mod#SemanticArtfeactCatalog</seealso>
    let SemanticArtfeactCatalog =
        Prefixed_Name(modp, "SemanticArtfeactCatalog") |> PrefixedName

    /// <summary>
    ///   <para>modp:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#Taxonomy">https://w3id.org/mod#Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(modp, "Taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>modp:Terminology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#Terminology">https://w3id.org/mod#Terminology</seealso>
    let Terminology = Prefixed_Name(modp, "Terminology") |> PrefixedName
    /// <summary>
    ///   <para>modp:Thesaurus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#Thesaurus">https://w3id.org/mod#Thesaurus</seealso>
    let Thesaurus = Prefixed_Name(modp, "Thesaurus") |> PrefixedName
    /// <summary>
    ///   <para>modp:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The URI of the ontology which is described by this metadata.</para>
    /// labels<para>URI</para></remarks>
    /// <seealso href="https://w3id.org/mod#URI">https://w3id.org/mod#URI</seealso>
    let URI = Prefixed_Name(modp, "URI") |> PrefixedName
    /// <summary>
    ///   <para>modp:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Often used as an identifier within some ontology platforms such as BioPortal or OBO Foundry.</para>
    /// labels<para>acronym</para></remarks>
    /// <seealso href="https://w3id.org/mod#acronym">https://w3id.org/mod#acronym</seealso>
    let acronym = Prefixed_Name(modp, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>modp:analytics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property shall be used to store any analytics for an ontology. E.g., number of visits an ontology received in a portal, number of downloads, etc.</para>
    /// labels<para>analytics</para></remarks>
    /// <seealso href="https://w3id.org/mod#analytics">https://w3id.org/mod#analytics</seealso>
    let analytics = Prefixed_Name(modp, "analytics") |> PrefixedName
    /// <summary>
    ///   <para>modp:authorProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>property used to specify the author of a class (BioPortal definition).</para>
    /// labels<para>object author property</para></remarks>
    /// <seealso href="https://w3id.org/mod#authorProperty">https://w3id.org/mod#authorProperty</seealso>
    let authorProperty = Prefixed_Name(modp, "authorProperty") |> PrefixedName
    /// <summary>
    ///   <para>modp:averageChildCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Average number of children per class (BioPortal definition) .</para>
    /// labels<para>average number of children per class</para></remarks>
    /// <seealso href="https://w3id.org/mod#averageChildCount">https://w3id.org/mod#averageChildCount</seealso>
    let averageChildCount = Prefixed_Name(modp, "averageChildCount") |> PrefixedName

    /// <summary>
    ///   <para>modp:classesWithNoDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>List of classes that have no value for the definition property (BioPortal definition). For ontologies in OBO and RRF formats, the property for definition is part of the language. For OWL ontologies, the authors specify this property as part of the ontology metadata (the default is skos:definition).</para>
    /// labels<para>number of classes with no definition</para></remarks>
    /// <seealso href="https://w3id.org/mod#classesWithNoDefinition">https://w3id.org/mod#classesWithNoDefinition</seealso>
    let classesWithNoDefinition =
        Prefixed_Name(modp, "classesWithNoDefinition") |> PrefixedName

    /// <summary>
    ///   <para>modp:classesWithOneChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of classes that have only one subclass in the is-a hierarchy (BioPortal definition).</para>
    /// labels<para>number of classes with a single child</para></remarks>
    /// <seealso href="https://w3id.org/mod#classesWithOneChild">https://w3id.org/mod#classesWithOneChild</seealso>
    let classesWithOneChild = Prefixed_Name(modp, "classesWithOneChild") |> PrefixedName

    /// <summary>
    ///   <para>modp:comesFromTheSameDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If the two ontologies come from the same domain (without any other details).</para>
    /// labels<para>comes from the same domain</para></remarks>
    /// <seealso href="https://w3id.org/mod#comesFromTheSameDomain">https://w3id.org/mod#comesFromTheSameDomain</seealso>
    let comesFromTheSameDomain =
        Prefixed_Name(modp, "comesFromTheSameDomain") |> PrefixedName

    /// <summary>
    ///   <para>modp:semanticArtefactRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#semanticArtefactRelation">https://w3id.org/mod#semanticArtefactRelation</seealso>
    let semanticArtefactRelation =
        Prefixed_Name(modp, "semanticArtefactRelation") |> PrefixedName

    /// <summary>
    ///   <para>modp:competencyQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A set of questions made to build an ontology at the design time.</para>
    /// labels<para>competency question</para></remarks>
    /// <seealso href="https://w3id.org/mod#competencyQuestion">https://w3id.org/mod#competencyQuestion</seealso>
    let competencyQuestion = Prefixed_Name(modp, "competencyQuestion") |> PrefixedName

    /// <summary>
    ///   <para>modp:conformsToKnowledgeRepresentationParadigm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A representation formalism that is followed to describe knowledge in an ontology. Example includes description logics, first order logic, etc. dct: An established standard to which the described resource conforms.</para>
    /// labels<para>conforms to knowledge representation paradigm</para></remarks>
    /// <seealso href="https://w3id.org/mod#conformsToKnowledgeRepresentationParadigm">https://w3id.org/mod#conformsToKnowledgeRepresentationParadigm</seealso>
    let conformsToKnowledgeRepresentationParadigm =
        Prefixed_Name(modp, "conformsToKnowledgeRepresentationParadigm") |> PrefixedName

    /// <summary>
    ///   <para>modp:definitionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to specify the definition of a class (BioPortal definition).</para>
    /// labels<para>object definition property</para></remarks>
    /// <seealso href="https://w3id.org/mod#definitionProperty">https://w3id.org/mod#definitionProperty</seealso>
    let definitionProperty = Prefixed_Name(modp, "definitionProperty") |> PrefixedName
    /// <summary>
    ///   <para>modp:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A depiction of some thing.</para>
    /// labels<para>depiction</para></remarks>
    /// <seealso href="https://w3id.org/mod#depiction">https://w3id.org/mod#depiction</seealso>
    let depiction = Prefixed_Name(modp, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>modp:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#describes">https://w3id.org/mod#describes</seealso>
    let describes = Prefixed_Name(modp, "describes") |> PrefixedName
    /// <summary>
    ///   <para>modp:designedForTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>designed for task</para></remarks>
    /// <seealso href="https://w3id.org/mod#designedForTask">https://w3id.org/mod#designedForTask</seealso>
    let designedForTask = Prefixed_Name(modp, "designedForTask") |> PrefixedName
    /// <summary>
    ///   <para>modp:endorsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An ontology endorsed by an agent.</para>
    /// labels<para>endorsed by</para></remarks>
    /// <seealso href="https://w3id.org/mod#endorsedBy">https://w3id.org/mod#endorsedBy</seealso>
    let endorsedBy = Prefixed_Name(modp, "endorsedBy") |> PrefixedName
    /// <summary>
    ///   <para>modp:generalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.</para>
    /// labels<para>generalizes</para></remarks>
    /// <seealso href="https://w3id.org/mod#generalizes">https://w3id.org/mod#generalizes</seealso>
    let generalizes = Prefixed_Name(modp, "generalizes") |> PrefixedName
    /// <summary>
    ///   <para>modp:hasEquivalencesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.</para>
    /// labels<para>ontology aligned to</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasEquivalencesWith">https://w3id.org/mod#hasEquivalencesWith</seealso>
    let hasEquivalencesWith = Prefixed_Name(modp, "hasEquivalencesWith") |> PrefixedName
    /// <summary>
    ///   <para>modp:hasEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property makes a relationship between an ontology and its evaluation result.</para>
    /// labels<para>has evaluation</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasEvaluation">https://w3id.org/mod#hasEvaluation</seealso>
    let hasEvaluation = Prefixed_Name(modp, "hasEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>modp:hasFormalityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The level of formality of an ontology.</para>
    /// labels<para>has formality level</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasFormalityLevel">https://w3id.org/mod#hasFormalityLevel</seealso>
    let hasFormalityLevel = Prefixed_Name(modp, "hasFormalityLevel") |> PrefixedName

    /// <summary>
    ///   <para>modp:hasRepresentationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A language that is used to create an ontology.</para>
    /// labels<para>has representation language</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasRepresentationLanguage">https://w3id.org/mod#hasRepresentationLanguage</seealso>
    let hasRepresentationLanguage =
        Prefixed_Name(modp, "hasRepresentationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>modp:hasSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The syntax followed in the creation of an ontology.</para>
    /// labels<para>has syntax</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasSyntax">https://w3id.org/mod#hasSyntax</seealso>
    let hasSyntax = Prefixed_Name(modp, "hasSyntax") |> PrefixedName
    /// <summary>
    ///   <para>modp:hierarchyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>property used to specify the hierarchy  (e.g. rdfs:subClassOf or skos:broader).</para>
    /// labels<para>transitive hierarchy property</para></remarks>
    /// <seealso href="https://w3id.org/mod#hierarchyProperty">https://w3id.org/mod#hierarchyProperty</seealso>
    let hierarchyProperty = Prefixed_Name(modp, "hierarchyProperty") |> PrefixedName
    /// <summary>
    ///   <para>modp:knownUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The applications where the ontology is being used.</para>
    /// labels<para>known usage</para></remarks>
    /// <seealso href="https://w3id.org/mod#knownUsage">https://w3id.org/mod#knownUsage</seealso>
    let knownUsage = Prefixed_Name(modp, "knownUsage") |> PrefixedName
    /// <summary>
    ///   <para>modp:maxChildCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum number of children per class (BioPortal definition)
    /// Screen reader support enabled.</para>
    /// labels<para>maximum number of children per class</para></remarks>
    /// <seealso href="https://w3id.org/mod#maxChildCount">https://w3id.org/mod#maxChildCount</seealso>
    let maxChildCount = Prefixed_Name(modp, "maxChildCount") |> PrefixedName
    /// <summary>
    ///   <para>modp:maxDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum depth of the hierarchy tree (BioPortal definition).</para>
    /// labels<para>maximum depth of the hierarchy</para></remarks>
    /// <seealso href="https://w3id.org/mod#maxDepth">https://w3id.org/mod#maxDepth</seealso>
    let maxDepth = Prefixed_Name(modp, "maxDepth") |> PrefixedName
    /// <summary>
    ///   <para>modp:metadataVoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary uses the object vocabulary in metadata at vocabulary or element level.</para>
    /// labels<para>metadata vocubulary used</para></remarks>
    /// <seealso href="https://w3id.org/mod#metadataVoc">https://w3id.org/mod#metadataVoc</seealso>
    let metadataVoc = Prefixed_Name(modp, "metadataVoc") |> PrefixedName

    /// <summary>
    ///   <para>modp:numberOfDataProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of data properties in an ontology.</para>
    /// labels<para>number of data properties</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfDataProperties">https://w3id.org/mod#numberOfDataProperties</seealso>
    let numberOfDataProperties =
        Prefixed_Name(modp, "numberOfDataProperties") |> PrefixedName

    /// <summary>
    ///   <para>modp:numberOfProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of properties in an ontology.</para>
    /// labels<para>number of properties</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfProperties">https://w3id.org/mod#numberOfProperties</seealso>
    let numberOfProperties = Prefixed_Name(modp, "numberOfProperties") |> PrefixedName
    /// <summary>
    ///   <para>modp:numberOfIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of individuals in an ontology.</para>
    /// labels<para>number of individuals</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfIndividuals">https://w3id.org/mod#numberOfIndividuals</seealso>
    let numberOfIndividuals = Prefixed_Name(modp, "numberOfIndividuals") |> PrefixedName
    /// <summary>
    ///   <para>modp:numberOfLabels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of defined labels for any resources in an ontology (classes, properties, etc).</para>
    /// labels<para>number of labels</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfLabels">https://w3id.org/mod#numberOfLabels</seealso>
    let numberOfLabels = Prefixed_Name(modp, "numberOfLabels") |> PrefixedName

    /// <summary>
    ///   <para>modp:numberOfObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of object properties in an ontology.</para>
    /// labels<para>number of object properties</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfObjectProperties">https://w3id.org/mod#numberOfObjectProperties</seealso>
    let numberOfObjectProperties =
        Prefixed_Name(modp, "numberOfObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>modp:obsoleteParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>property used to specify the root of an obsolete branch in the ontology.</para>
    /// labels<para>root of obsolete branch</para></remarks>
    /// <seealso href="https://w3id.org/mod#obsoleteParent">https://w3id.org/mod#obsoleteParent</seealso>
    let obsoleteParent = Prefixed_Name(modp, "obsoleteParent") |> PrefixedName
    /// <summary>
    ///   <para>modp:obsoleteProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>property used to specify an obsolete class.</para>
    /// labels<para>object obsolete property</para></remarks>
    /// <seealso href="https://w3id.org/mod#obsoleteProperty">https://w3id.org/mod#obsoleteProperty</seealso>
    let obsoleteProperty = Prefixed_Name(modp, "obsoleteProperty") |> PrefixedName
    /// <summary>
    ///   <para>modp:prefLabelPropert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to specify preferred name (BioPortal definition).</para>
    /// labels<para>object preferred label property</para></remarks>
    /// <seealso href="https://w3id.org/mod#prefLabelPropert">https://w3id.org/mod#prefLabelPropert</seealso>
    let prefLabelPropert = Prefixed_Name(modp, "prefLabelPropert") |> PrefixedName
    /// <summary>
    ///   <para>modp:qualifiedRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to a description of a relationship with another resource.</para>
    /// labels<para>qualified relation</para></remarks>
    /// <seealso href="https://w3id.org/mod#qualifiedRelation">https://w3id.org/mod#qualifiedRelation</seealso>
    let qualifiedRelation = Prefixed_Name(modp, "qualifiedRelation") |> PrefixedName
    /// <summary>
    ///   <para>modp:sampleQueries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A set of queries (may be SPARQL, DL Queries) that are provided along with an ontology.</para>
    /// labels<para>sample queries</para></remarks>
    /// <seealso href="https://w3id.org/mod#sampleQueries">https://w3id.org/mod#sampleQueries</seealso>
    let sampleQueries = Prefixed_Name(modp, "sampleQueries") |> PrefixedName
    /// <summary>
    ///   <para>modp:similar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.</para>
    /// labels<para>similar to</para></remarks>
    /// <seealso href="https://w3id.org/mod#similar">https://w3id.org/mod#similar</seealso>
    let similar = Prefixed_Name(modp, "similar") |> PrefixedName
    /// <summary>
    ///   <para>modp:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The tracking information for the contents of the ontology.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#status">https://w3id.org/mod#status</seealso>
    let status = Prefixed_Name(modp, "status") |> PrefixedName
    /// <summary>
    ///   <para>modp:synonymProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to specify preferred name (BioPortal definition).</para>
    /// labels<para>object synonym property</para></remarks>
    /// <seealso href="https://w3id.org/mod#synonymProperty">https://w3id.org/mod#synonymProperty</seealso>
    let synonymProperty = Prefixed_Name(modp, "synonymProperty") |> PrefixedName
    /// <summary>
    ///   <para>modp:toDoList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.</para>
    /// labels<para>to do list</para></remarks>
    /// <seealso href="https://w3id.org/mod#toDoList">https://w3id.org/mod#toDoList</seealso>
    let toDoList = Prefixed_Name(modp, "toDoList") |> PrefixedName
    /// <summary>
    ///   <para>modp:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary is used by the object vocabulary.</para>
    /// labels<para>used by</para></remarks>
    /// <seealso href="https://w3id.org/mod#usedBy">https://w3id.org/mod#usedBy</seealso>
    let usedBy = Prefixed_Name(modp, "usedBy") |> PrefixedName

    /// <summary>
    ///   <para>modp:usedEngineeringMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>used engineering methodology</para></remarks>
    /// <seealso href="https://w3id.org/mod#usedEngineeringMethodology">https://w3id.org/mod#usedEngineeringMethodology</seealso>
    let usedEngineeringMethodology =
        Prefixed_Name(modp, "usedEngineeringMethodology") |> PrefixedName

    /// <summary>
    ///   <para>modp:usedInProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An semantic artefact that is used in a project.</para>
    /// labels<para>used in project</para></remarks>
    /// <seealso href="https://w3id.org/mod#usedInProject">https://w3id.org/mod#usedInProject</seealso>
    let usedInProject = Prefixed_Name(modp, "usedInProject") |> PrefixedName
    /// <summary>
    ///   <para>modp:metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A generic property to store any metrics related to the ontology.</para>
    /// labels<para>metrics</para></remarks>
    /// <seealso href="https://w3id.org/mod#metrics">https://w3id.org/mod#metrics</seealso>
    let metrics = Prefixed_Name(modp, "metrics") |> PrefixedName

    /// <summary>
    ///   <para>modp:classesWithMoreThan25Children</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of classes that have more than 25 direct subclasses (BioPortal definition).</para>
    /// labels<para>number of classes with more than 25 children</para></remarks>
    /// <seealso href="https://w3id.org/mod#classesWithMoreThan25Children">https://w3id.org/mod#classesWithMoreThan25Children</seealso>
    let classesWithMoreThan25Children =
        Prefixed_Name(modp, "classesWithMoreThan25Children") |> PrefixedName

    /// <summary>
    ///   <para>modp:browsingUI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The user interface (URL) where the ontology may be browsed or searched.</para>
    /// labels<para>Browsing user interface</para><para>browsing UI</para></remarks>
    /// <seealso href="https://w3id.org/mod#browsingUI">https://w3id.org/mod#browsingUI</seealso>
    let browsingUI = Prefixed_Name(modp, "browsingUI") |> PrefixedName
    /// <summary>
    ///   <para>modp:numberOfClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of classes in an ontology.</para>
    /// labels<para>number of classes</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfClasses">https://w3id.org/mod#numberOfClasses</seealso>
    let numberOfClasses = Prefixed_Name(modp, "numberOfClasses") |> PrefixedName
    /// <summary>
    ///   <para>modp:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. voaf:Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.</para>
    /// labels<para>specializes</para></remarks>
    /// <seealso href="https://w3id.org/mod#specializes">https://w3id.org/mod#specializes</seealso>
    let specializes = Prefixed_Name(modp, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>modp:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A group of ontologies that the ontology is usually considered into.</para>
    /// labels<para>group</para></remarks>
    /// <seealso href="https://w3id.org/mod#group">https://w3id.org/mod#group</seealso>
    let group = Prefixed_Name(modp, "group") |> PrefixedName
    /// <summary>
    ///   <para>modp:hasDisjunctionsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary declares some disjunct classes with the object vocabulary.</para>
    /// labels<para>has disjunctions with</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasDisjunctionsWith">https://w3id.org/mod#hasDisjunctionsWith</seealso>
    let hasDisjunctionsWith = Prefixed_Name(modp, "hasDisjunctionsWith") |> PrefixedName

    /// <summary>
    ///   <para>modp:hasDisparateModellingWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Disagreements related  to  the  conceptualization  of  the  ontologies. Two ontologies are considered to have disparate modeling if they represent corresponding entities in different ways, e.g.  as an instance in one case and a class in the other.</para>
    /// labels<para>disparate modelling with</para></remarks>
    /// <seealso href="https://w3id.org/mod#hasDisparateModellingWith">https://w3id.org/mod#hasDisparateModellingWith</seealso>
    let hasDisparateModellingWith =
        Prefixed_Name(modp, "hasDisparateModellingWith") |> PrefixedName

    /// <summary>
    ///   <para>modp:numberOfAxioms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of axioms in an ontology.</para>
    /// labels<para>number of axioms or triples</para></remarks>
    /// <seealso href="https://w3id.org/mod#numberOfAxioms">https://w3id.org/mod#numberOfAxioms</seealso>
    let numberOfAxioms = Prefixed_Name(modp, "numberOfAxioms") |> PrefixedName

    /// <summary>
    ///   <para>modp:SemanticArtefactDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod#SemanticArtefactDistribution">https://w3id.org/mod#SemanticArtefactDistribution</seealso>
    let SemanticArtefactDistribution =
        Prefixed_Name(modp, "SemanticArtefactDistribution") |> PrefixedName
