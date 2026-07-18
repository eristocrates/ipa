namespace http.www.w3.org.ns.sparql_service_description.hash

open DoxAletheia.Rdf_Vocabulary

module sd =
    let _namespace_name = "http://www.w3.org/ns/sparql-service-description#"
    /// <summary>
    /// An instance of sd:Aggregate represents an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Aggregate"></see></summary>
    let Aggregate = Namespaced_IRI.parse _namespace_name "Aggregate" |> NamespacedName
    /// <summary>
    /// An instance of sd:Feature represents a feature of a SPARQL service. Specific types of features include functions, aggregates, languages, and entailment regimes and profiles. This document defines five instances of sd:Feature: sd:DereferencesURIs, sd:UnionDefaultGraph, sd:RequiresDataset, sd:EmptyGraphs, and sd:BasicFederatedQuery.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    /// sd:BasicFederatedQuery, when used as the object of the sd:feature property, indicates that the SPARQL service supports basic federated query using the SERVICE keyword as defined by SPARQL 1.1 Federation Extensions.
    /// <see href="http://www.w3.org/ns/sparql-service-description#BasicFederatedQuery"></see></summary>
    let BasicFederatedQuery =
        Namespaced_IRI.parse _namespace_name "BasicFederatedQuery" |> NamespacedName

    /// <summary>
    /// An instance of sd:Dataset represents a RDF Dataset comprised of a default graph and zero or more named graphs.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// An instance of sd:GraphCollection represents a collection of zero or more named graph descriptions. Each named graph description belonging to an sd:GraphCollection MUST be linked with the sd:namedGraph predicate.
    /// <see href="http://www.w3.org/ns/sparql-service-description#GraphCollection"></see></summary>
    let GraphCollection =
        Namespaced_IRI.parse _namespace_name "GraphCollection" |> NamespacedName

    /// <summary>
    /// sd:DereferencesURIs, when used as the object of the sd:feature property, indicates that a SPARQL service will dereference URIs used in FROM/FROM NAMED and USING/USING NAMED clauses and use the resulting RDF in the dataset during query evaluation.
    /// <see href="http://www.w3.org/ns/sparql-service-description#DereferencesURIs"></see></summary>
    let DereferencesURIs =
        Namespaced_IRI.parse _namespace_name "DereferencesURIs" |> NamespacedName

    /// <summary>
    /// sd:EmptyGraphs, when used as the object of the sd:feature property, indicates that the underlying graph store supports empty graphs. A graph store that supports empty graphs MUST NOT remove graphs that are left empty after triples are removed from them.
    /// <see href="http://www.w3.org/ns/sparql-service-description#EmptyGraphs"></see></summary>
    let EmptyGraphs =
        Namespaced_IRI.parse _namespace_name "EmptyGraphs" |> NamespacedName

    /// <summary>
    /// An instance of sd:EntailmentProfile represents a profile of an entailment regime. An entailment profile MAY impose restrictions on what constitutes valid RDF with respect to entailment.
    /// <see href="http://www.w3.org/ns/sparql-service-description#EntailmentProfile"></see></summary>
    let EntailmentProfile =
        Namespaced_IRI.parse _namespace_name "EntailmentProfile" |> NamespacedName

    /// <summary>
    /// An instance of sd:EntailmentRegime represents an entailment regime used in basic graph pattern matching (as described by SPARQL 1.1 Query Language).
    /// <see href="http://www.w3.org/ns/sparql-service-description#EntailmentRegime"></see></summary>
    let EntailmentRegime =
        Namespaced_IRI.parse _namespace_name "EntailmentRegime" |> NamespacedName

    /// <summary>
    /// An instance of sd:Function represents a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    /// An instance of sd:Graph represents the description of an RDF graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Graph"></see></summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName
    /// <summary>
    /// An instance of sd:Language represents one of the SPARQL languages, including specific configurations providing particular features or extensions. This document defines three instances of sd:Language: sd:SPARQL10Query, sd:SPARQL11Query, and sd:SPARQL11Update.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    /// An instance of sd:NamedGraph represents a named graph having a name (via sd:name) and an optional graph description (via sd:graph).
    /// <see href="http://www.w3.org/ns/sparql-service-description#NamedGraph"></see></summary>
    let NamedGraph = Namespaced_IRI.parse _namespace_name "NamedGraph" |> NamespacedName

    /// <summary>
    /// sd:RequiresDataset, when used as the object of the sd:feature property, indicates that the SPARQL service requires an explicit dataset declaration (based on either FROM/FROM NAMED clauses in a query, USING/USING NAMED clauses in an update, or the appropriate SPARQL Protocol parameters).
    /// <see href="http://www.w3.org/ns/sparql-service-description#RequiresDataset"></see></summary>
    let RequiresDataset =
        Namespaced_IRI.parse _namespace_name "RequiresDataset" |> NamespacedName

    /// <summary>
    /// sd:SPARQL10Query is an sd:Language representing the SPARQL 1.0 Query language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL10Query"></see></summary>
    let SPARQL10Query =
        Namespaced_IRI.parse _namespace_name "SPARQL10Query" |> NamespacedName

    /// <summary>
    /// sd:SPARQL11Query is an sd:Language representing the SPARQL 1.1 Query language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL11Query"></see></summary>
    let SPARQL11Query =
        Namespaced_IRI.parse _namespace_name "SPARQL11Query" |> NamespacedName

    /// <summary>
    /// sd:SPARQLUpdate is an sd:Language representing the SPARQL 1.1 Update language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#SPARQL11Update"></see></summary>
    let SPARQL11Update =
        Namespaced_IRI.parse _namespace_name "SPARQL11Update" |> NamespacedName

    /// <summary>
    /// An instance of sd:Service represents a SPARQL service made available via the SPARQL Protocol.
    /// <see href="http://www.w3.org/ns/sparql-service-description#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// sd:UnionDefaultGraph, when used as the object of the sd:feature property, indicates that the default graph of the dataset used during query and update evaluation (when an explicit dataset is not specified) is comprised of the union of all the named graphs in that dataset.
    /// <see href="http://www.w3.org/ns/sparql-service-description#UnionDefaultGraph"></see></summary>
    let UnionDefaultGraph =
        Namespaced_IRI.parse _namespace_name "UnionDefaultGraph" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a description of the graphs which are allowed in the construction of a dataset either via the SPARQL Protocol, with FROM/FROM NAMED clauses in a query, or with USING/USING NAMED in an update request, if the service limits the scope of dataset construction.
    /// <see href="http://www.w3.org/ns/sparql-service-description#availableGraphs"></see></summary>
    let availableGraphs =
        Namespaced_IRI.parse _namespace_name "availableGraphs" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a description of the default dataset available when no explicit dataset is specified in the query, update request or via protocol parameters.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultDataset"></see></summary>
    let defaultDataset =
        Namespaced_IRI.parse _namespace_name "defaultDataset" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service with a resource representing an entailment regime used for basic graph pattern matching. This property is intended for use when a single entailment regime by default applies to all graphs in the default dataset of the service. In situations where a different entailment regime applies to a specific graph in the dataset, the sd:entailmentRegime property should be used to indicate this fact in the description of that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultEntailmentRegime"></see></summary>
    let defaultEntailmentRegime =
        Namespaced_IRI.parse _namespace_name "defaultEntailmentRegime" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service with a resource representing a supported feature.
    /// <see href="http://www.w3.org/ns/sparql-service-description#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Dataset to the description of its default graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultGraph"></see></summary>
    let defaultGraph =
        Namespaced_IRI.parse _namespace_name "defaultGraph" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service with a resource representing a supported profile of the default entailment regime (as declared by sd:defaultEntailmentRegime).
    /// <see href="http://www.w3.org/ns/sparql-service-description#defaultSupportedEntailmentProfile"></see></summary>
    let defaultSupportedEntailmentProfile =
        Namespaced_IRI.parse _namespace_name "defaultSupportedEntailmentProfile" |> NamespacedName

    /// <summary>
    /// The SPARQL endpoint of an sd:Service that implements the SPARQL Protocol service. The object of the sd:endpoint property is an IRI.
    /// <see href="http://www.w3.org/ns/sparql-service-description#endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    /// Relates a named graph description with a resource representing an entailment regime used for basic graph pattern matching over that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#entailmentRegime"></see></summary>
    let entailmentRegime =
        Namespaced_IRI.parse _namespace_name "entailmentRegime" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE
    /// <see href="http://www.w3.org/ns/sparql-service-description#extensionAggregate"></see></summary>
    let extensionAggregate =
        Namespaced_IRI.parse _namespace_name "extensionAggregate" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.
    /// <see href="http://www.w3.org/ns/sparql-service-description#extensionFunction"></see></summary>
    let extensionFunction =
        Namespaced_IRI.parse _namespace_name "extensionFunction" |> NamespacedName

    /// <summary>
    /// Relates a named graph to its graph description.
    /// <see href="http://www.w3.org/ns/sparql-service-description#graph"></see></summary>
    let graph = Namespaced_IRI.parse _namespace_name "graph" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a format that is supported for parsing RDF input; for example, via a SPARQL 1.1 Update LOAD statement, or when URIs are dereferenced in FROM/FROM NAMED/USING/USING NAMED clauses.
    /// <see href="http://www.w3.org/ns/sparql-service-description#inputFormat"></see></summary>
    let inputFormat =
        Namespaced_IRI.parse _namespace_name "inputFormat" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a resource representing an implemented extension to the SPARQL Query or Update language.
    /// <see href="http://www.w3.org/ns/sparql-service-description#languageExtension"></see></summary>
    let languageExtension =
        Namespaced_IRI.parse _namespace_name "languageExtension" |> NamespacedName

    /// <summary>
    /// Relates a named graph to the name by which it may be referenced in a FROM/FROM NAMED clause. The object of the sd:name property is an IRI.
    /// <see href="http://www.w3.org/ns/sparql-service-description#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Relates an instance of sd:GraphCollection (or its subclass sd:Dataset) to the description of one of its named graphs. The description of such a named graph MUST include the sd:name property and MAY include the sd:graph property.
    /// <see href="http://www.w3.org/ns/sparql-service-description#namedGraph"></see></summary>
    let namedGraph = Namespaced_IRI.parse _namespace_name "namedGraph" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a resource representing an implemented feature that extends the SPARQL Query or Update language and that is accessed by using the named property.
    /// <see href="http://www.w3.org/ns/sparql-service-description#propertyFeature"></see></summary>
    let propertyFeature =
        Namespaced_IRI.parse _namespace_name "propertyFeature" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a format that is supported for serializing query results.
    /// <see href="http://www.w3.org/ns/sparql-service-description#resultFormat"></see></summary>
    let resultFormat =
        Namespaced_IRI.parse _namespace_name "resultFormat" |> NamespacedName

    /// <summary>
    /// Relates a named graph description with a resource representing a supported profile of the entailment regime (as declared by sd:entailmentRegime) used for basic graph pattern matching over that graph.
    /// <see href="http://www.w3.org/ns/sparql-service-description#supportedEntailmentProfile"></see></summary>
    let supportedEntailmentProfile =
        Namespaced_IRI.parse _namespace_name "supportedEntailmentProfile" |> NamespacedName

    /// <summary>
    /// Relates an instance of sd:Service to a SPARQL language (e.g. Query and Update) that it implements.
    /// <see href="http://www.w3.org/ns/sparql-service-description#supportedLanguage"></see></summary>
    let supportedLanguage =
        Namespaced_IRI.parse _namespace_name "supportedLanguage" |> NamespacedName
