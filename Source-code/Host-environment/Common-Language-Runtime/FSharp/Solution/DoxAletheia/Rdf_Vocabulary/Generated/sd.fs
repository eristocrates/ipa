namespace http.www.w3.org.ns.sparql_service_description.hash

open DoxAletheia

module sd =
    let _namespace_name = "http://www.w3.org/ns/sparql-service-description#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An instance of sd:Aggregate represents an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Aggregate"></see></summary>
    let Aggregate = _prefix "Aggregate"
    /// <summary>
    /// An instance of sd:Feature represents a feature of a SPARQL service. Specific types of features include functions, aggregates, languages, and entailment regimes and profiles. This document defines five instances of sd:Feature: sd:DereferencesURIs, sd:UnionDefaultGraph, sd:RequiresDataset, sd:EmptyGraphs, and sd:BasicFederatedQuery.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// sd:BasicFederatedQuery, when used as the object of the sd:feature property, indicates that the SPARQL service supports basic federated query using the SERVICE keyword as defined by SPARQL 1.1 Federation Extensions.
    /// <see href="http://www.w3.org/ns/sparql-service-description#BasicFederatedQuery"></see></summary>
    let BasicFederatedQuery = _prefix "BasicFederatedQuery"
    /// <summary>
    /// An instance of sd:Dataset represents a RDF Dataset comprised of a default graph and zero or more named graphs.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// An instance of sd:GraphCollection represents a collection of zero or more named graph descriptions. Each named graph description belonging to an sd:GraphCollection MUST be linked with the sd:namedGraph predicate.
    /// <see href="http://www.w3.org/ns/sparql-service-description#GraphCollection"></see></summary>
    let GraphCollection = _prefix "GraphCollection"
    /// <summary>
    /// sd:DereferencesURIs, when used as the object of the sd:feature property, indicates that a SPARQL service will dereference URIs used in FROM/FROM NAMED and USING/USING NAMED clauses and use the resulting RDF in the dataset during query evaluation.
    /// <see href="http://www.w3.org/ns/sparql-service-description#DereferencesURIs"></see></summary>
    let DereferencesURIs = _prefix "DereferencesURIs"
    /// <summary>
    /// sd:EmptyGraphs, when used as the object of the sd:feature property, indicates that the underlying graph store supports empty graphs. A graph store that supports empty graphs MUST NOT remove graphs that are left empty after triples are removed from them.
    /// <see href="http://www.w3.org/ns/sparql-service-description#EmptyGraphs"></see></summary>
    let EmptyGraphs = _prefix "EmptyGraphs"
    /// <summary>
    /// An instance of sd:EntailmentProfile represents a profile of an entailment regime. An entailment profile MAY impose restrictions on what constitutes valid RDF with respect to entailment.
    /// <see href="http://www.w3.org/ns/sparql-service-description#EntailmentProfile"></see></summary>
    let EntailmentProfile = _prefix "EntailmentProfile"
    /// <summary>
    /// An instance of sd:EntailmentRegime represents an entailment regime used in basic graph pattern matching (as described by SPARQL 1.1 Query Language).
    /// <see href="http://www.w3.org/ns/sparql-service-description#EntailmentRegime"></see></summary>
    let EntailmentRegime = _prefix "EntailmentRegime"
    /// <summary>
    /// An instance of sd:Function represents a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// An instance of sd:Graph represents the description of an RDF graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Graph"></see></summary>
    let Graph = _prefix "Graph"
    /// <summary>
    /// An instance of sd:Language represents one of the SPARQL languages, including specific configurations providing particular features or extensions. This document defines three instances of sd:Language: sd:SPARQL10Query, sd:SPARQL11Query, and sd:SPARQL11Update.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// An instance of sd:NamedGraph represents a named graph having a name (via sd:name) and an optional graph description (via sd:graph).
    /// <see href="http://www.w3.org/ns/sparql-service-description#NamedGraph"></see></summary>
    let NamedGraph = _prefix "NamedGraph"
    /// <summary>
    /// sd:RequiresDataset, when used as the object of the sd:feature property, indicates that the SPARQL service requires an explicit dataset declaration (based on either FROM/FROM NAMED clauses in a query, USING/USING NAMED clauses in an update, or the appropriate SPARQL Protocol parameters).
    /// <see href="http://www.w3.org/ns/sparql-service-description#RequiresDataset"></see></summary>
    let RequiresDataset = _prefix "RequiresDataset"
    /// <summary>
    /// sd:SPARQL10Query is an sd:Language representing the SPARQL 1.0 Query language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL10Query"></see></summary>
    let SPARQL10Query = _prefix "SPARQL10Query"
    /// <summary>
    /// sd:SPARQL11Query is an sd:Language representing the SPARQL 1.1 Query language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL11Query"></see></summary>
    let SPARQL11Query = _prefix "SPARQL11Query"
    /// <summary>
    /// sd:SPARQLUpdate is an sd:Language representing the SPARQL 1.1 Update language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL11Update"></see></summary>
    let SPARQL11Update = _prefix "SPARQL11Update"
    /// <summary>
    /// An instance of sd:Service represents a SPARQL service made available via the SPARQL Protocol.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// sd:UnionDefaultGraph, when used as the object of the sd:feature property, indicates that the default graph of the dataset used during query and update evaluation (when an explicit dataset is not specified) is comprised of the union of all the named graphs in that dataset.
    /// <see href="http://www.w3.org/ns/sparql-service-description#UnionDefaultGraph"></see></summary>
    let UnionDefaultGraph = _prefix "UnionDefaultGraph"
    /// <summary>
    /// Relates an instance of sd:Service to a description of the graphs which are allowed in the construction of a dataset either via the SPARQL Protocol, with FROM/FROM NAMED clauses in a query, or with USING/USING NAMED in an update request, if the service limits the scope of dataset construction.
    /// <see href="http://www.w3.org/ns/sparql-service-description#availableGraphs"></see></summary>
    let availableGraphs = _prefix "availableGraphs"
    /// <summary>
    /// Relates an instance of sd:Service to a description of the default dataset available when no explicit dataset is specified in the query, update request or via protocol parameters.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultDataset"></see></summary>
    let defaultDataset = _prefix "defaultDataset"
    /// <summary>
    /// Relates an instance of sd:Service with a resource representing an entailment regime used for basic graph pattern matching. This property is intended for use when a single entailment regime by default applies to all graphs in the default dataset of the service. In situations where a different entailment regime applies to a specific graph in the dataset, the sd:entailmentRegime property should be used to indicate this fact in the description of that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultEntailmentRegime"></see></summary>
    let defaultEntailmentRegime = _prefix "defaultEntailmentRegime"
    /// <summary>
    /// Relates an instance of sd:Service with a resource representing a supported feature.
    /// <see href="http://www.w3.org/ns/sparql-service-description#feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// Relates an instance of sd:Dataset to the description of its default graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultGraph"></see></summary>
    let defaultGraph = _prefix "defaultGraph"
    /// <summary>
    /// Relates an instance of sd:Service with a resource representing a supported profile of the default entailment regime (as declared by sd:defaultEntailmentRegime).
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultSupportedEntailmentProfile"></see></summary>
    let defaultSupportedEntailmentProfile = _prefix "defaultSupportedEntailmentProfile"
    /// <summary>
    /// The SPARQL endpoint of an sd:Service that implements the SPARQL Protocol service. The object of the sd:endpoint property is an IRI.
    /// <see href="http://www.w3.org/ns/sparql-service-description#endpoint"></see></summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    /// Relates a named graph description with a resource representing an entailment regime used for basic graph pattern matching over that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#entailmentRegime"></see></summary>
    let entailmentRegime = _prefix "entailmentRegime"
    /// <summary>
    /// Relates an instance of sd:Service to an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE
    /// <see href="http://www.w3.org/ns/sparql-service-description#extensionAggregate"></see></summary>
    let extensionAggregate = _prefix "extensionAggregate"
    /// <summary>
    /// Relates an instance of sd:Service to a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.
    /// <see href="http://www.w3.org/ns/sparql-service-description#extensionFunction"></see></summary>
    let extensionFunction = _prefix "extensionFunction"
    /// <summary>
    /// Relates a named graph to its graph description.
    /// <see href="http://www.w3.org/ns/sparql-service-description#graph"></see></summary>
    let graph = _prefix "graph"
    /// <summary>
    /// Relates an instance of sd:Service to a format that is supported for parsing RDF input; for example, via a SPARQL 1.1 Update LOAD statement, or when URIs are dereferenced in FROM/FROM NAMED/USING/USING NAMED clauses.
    /// <see href="http://www.w3.org/ns/sparql-service-description#inputFormat"></see></summary>
    let inputFormat = _prefix "inputFormat"
    /// <summary>
    /// Relates an instance of sd:Service to a resource representing an implemented extension to the SPARQL Query or Update language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#languageExtension"></see></summary>
    let languageExtension = _prefix "languageExtension"
    /// <summary>
    /// Relates a named graph to the name by which it may be referenced in a FROM/FROM NAMED clause. The object of the sd:name property is an IRI.
    /// <see href="http://www.w3.org/ns/sparql-service-description#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Relates an instance of sd:GraphCollection (or its subclass sd:Dataset) to the description of one of its named graphs. The description of such a named graph MUST include the sd:name property and MAY include the sd:graph property.
    /// <see href="http://www.w3.org/ns/sparql-service-description#namedGraph"></see></summary>
    let namedGraph = _prefix "namedGraph"
    /// <summary>
    /// Relates an instance of sd:Service to a resource representing an implemented feature that extends the SPARQL Query or Update language and that is accessed by using the named property.
    /// <see href="http://www.w3.org/ns/sparql-service-description#propertyFeature"></see></summary>
    let propertyFeature = _prefix "propertyFeature"
    /// <summary>
    /// Relates an instance of sd:Service to a format that is supported for serializing query results.
    /// <see href="http://www.w3.org/ns/sparql-service-description#resultFormat"></see></summary>
    let resultFormat = _prefix "resultFormat"
    /// <summary>
    /// Relates a named graph description with a resource representing a supported profile of the entailment regime (as declared by sd:entailmentRegime) used for basic graph pattern matching over that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#supportedEntailmentProfile"></see></summary>
    let supportedEntailmentProfile = _prefix "supportedEntailmentProfile"
    /// <summary>
    /// Relates an instance of sd:Service to a SPARQL language (e.g. Query and Update) that it implements.
    /// <see href="http://www.w3.org/ns/sparql-service-description#supportedLanguage"></see></summary>
    let supportedLanguage = _prefix "supportedLanguage"
