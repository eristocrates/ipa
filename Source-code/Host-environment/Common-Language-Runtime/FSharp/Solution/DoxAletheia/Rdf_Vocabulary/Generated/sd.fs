namespace http.www.w3.org.ns.sparql_service_description.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sd =
    let _namespace_iri = Namespace_Iri sd |> NamespaceIRI
    /// <summary>
    ///   <para>sd:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Feature represents a feature of a SPARQL service. Specific types of features include functions, aggregates, languages, and entailment regimes and profiles. This document defines five instances of sd:Feature: sd:DereferencesURIs, sd:UnionDefaultGraph, sd:RequiresDataset, sd:EmptyGraphs, and sd:BasicFederatedQuery.</para>
    /// labels<para>Feature</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Feature">http://www.w3.org/ns/sparql-service-description#Feature</seealso>
    let Feature = Prefixed_Name(sd, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>sd:GraphCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:GraphCollection represents a collection of zero or more named graph descriptions. Each named graph description belonging to an sd:GraphCollection MUST be linked with the sd:namedGraph predicate.</para>
    /// labels<para>Graph Collection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#GraphCollection">http://www.w3.org/ns/sparql-service-description#GraphCollection</seealso>
    let GraphCollection = Prefixed_Name(sd, "GraphCollection") |> PrefixedName
    /// <summary>
    ///   <para>sd:DereferencesURIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///   <para>sd:DereferencesURIs, when used as the object of the sd:feature property, indicates that a SPARQL service will dereference URIs used in FROM/FROM NAMED and USING/USING NAMED clauses and use the resulting RDF in the dataset during query evaluation.</para>
    /// labels<para>Dereferences URIs</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#DereferencesURIs">http://www.w3.org/ns/sparql-service-description#DereferencesURIs</seealso>
    let DereferencesURIs = Prefixed_Name(sd, "DereferencesURIs") |> PrefixedName

    /// <summary>
    ///   <para>sd:defaultEntailmentRegime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service with a resource representing an entailment regime used for basic graph pattern matching. This property is intended for use when a single entailment regime by default applies to all graphs in the default dataset of the service. In situations where a different entailment regime applies to a specific graph in the dataset, the sd:entailmentRegime property should be used to indicate this fact in the description of that graph.</para>
    /// labels<para>default entailment regime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#defaultEntailmentRegime">http://www.w3.org/ns/sparql-service-description#defaultEntailmentRegime</seealso>
    let defaultEntailmentRegime =
        Prefixed_Name(sd, "defaultEntailmentRegime") |> PrefixedName

    /// <summary>
    ///   <para>sd:BasicFederatedQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///   <para>sd:BasicFederatedQuery, when used as the object of the sd:feature property, indicates that the SPARQL service supports basic federated query using the SERVICE keyword as defined by SPARQL 1.1 Federation Extensions.</para>
    /// labels<para>Basic Federated Query</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#BasicFederatedQuery">http://www.w3.org/ns/sparql-service-description#BasicFederatedQuery</seealso>
    let BasicFederatedQuery = Prefixed_Name(sd, "BasicFederatedQuery") |> PrefixedName
    /// <summary>
    ///   <para>sd:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Function represents a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Function">http://www.w3.org/ns/sparql-service-description#Function</seealso>
    let Function = Prefixed_Name(sd, "Function") |> PrefixedName
    /// <summary>
    ///   <para>sd:RequiresDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///   <para>sd:RequiresDataset, when used as the object of the sd:feature property, indicates that the SPARQL service requires an explicit dataset declaration (based on either FROM/FROM NAMED clauses in a query, USING/USING NAMED clauses in an update, or the appropriate SPARQL Protocol parameters).</para>
    /// labels<para>Requires Dataset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#RequiresDataset">http://www.w3.org/ns/sparql-service-description#RequiresDataset</seealso>
    let RequiresDataset = Prefixed_Name(sd, "RequiresDataset") |> PrefixedName
    /// <summary>
    ///   <para>sd:SPARQL11Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Language</para>
    ///   <para>sd:SPARQL11Query is an sd:Language representing the SPARQL 1.1 Query language.</para>
    /// labels<para>SPARQL 1.1 Query</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#SPARQL11Query">http://www.w3.org/ns/sparql-service-description#SPARQL11Query</seealso>
    let SPARQL11Query = Prefixed_Name(sd, "SPARQL11Query") |> PrefixedName
    /// <summary>
    ///   <para>sd:UnionDefaultGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///   <para>sd:UnionDefaultGraph, when used as the object of the sd:feature property, indicates that the default graph of the dataset used during query and update evaluation (when an explicit dataset is not specified) is comprised of the union of all the named graphs in that dataset.</para>
    /// labels<para>Union Default Graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#UnionDefaultGraph">http://www.w3.org/ns/sparql-service-description#UnionDefaultGraph</seealso>
    let UnionDefaultGraph = Prefixed_Name(sd, "UnionDefaultGraph") |> PrefixedName
    /// <summary>
    ///   <para>sd:defaultGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Dataset to the description of its default graph.</para>
    /// labels<para>default graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#defaultGraph">http://www.w3.org/ns/sparql-service-description#defaultGraph</seealso>
    let defaultGraph = Prefixed_Name(sd, "defaultGraph") |> PrefixedName
    /// <summary>
    ///   <para>sd:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>The SPARQL endpoint of an sd:Service that implements the SPARQL Protocol service. The object of the sd:endpoint property is an IRI.</para>
    /// labels<para>endpoint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#endpoint">http://www.w3.org/ns/sparql-service-description#endpoint</seealso>
    let endpoint = Prefixed_Name(sd, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>sd:extensionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.</para>
    /// labels<para>extension function</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#extensionFunction">http://www.w3.org/ns/sparql-service-description#extensionFunction</seealso>
    let extensionFunction = Prefixed_Name(sd, "extensionFunction") |> PrefixedName
    /// <summary>
    ///   <para>sd:namedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:GraphCollection (or its subclass sd:Dataset) to the description of one of its named graphs. The description of such a named graph MUST include the sd:name property and MAY include the sd:graph property.</para>
    /// labels<para>named graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#namedGraph">http://www.w3.org/ns/sparql-service-description#namedGraph</seealso>
    let namedGraph = Prefixed_Name(sd, "namedGraph") |> PrefixedName

    /// <summary>
    ///   <para>sd:supportedEntailmentProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a named graph description with a resource representing a supported profile of the entailment regime (as declared by sd:entailmentRegime) used for basic graph pattern matching over that graph.</para>
    /// labels<para>supported entailment profile</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#supportedEntailmentProfile">http://www.w3.org/ns/sparql-service-description#supportedEntailmentProfile</seealso>
    let supportedEntailmentProfile =
        Prefixed_Name(sd, "supportedEntailmentProfile") |> PrefixedName

    /// <summary>
    ///   <para>sd:EntailmentProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:EntailmentProfile represents a profile of an entailment regime. An entailment profile MAY impose restrictions on what constitutes valid RDF with respect to entailment.</para>
    /// labels<para>Entailment Profile</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#EntailmentProfile">http://www.w3.org/ns/sparql-service-description#EntailmentProfile</seealso>
    let EntailmentProfile = Prefixed_Name(sd, "EntailmentProfile") |> PrefixedName
    /// <summary>
    ///   <para>sd:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Language represents one of the SPARQL languages, including specific configurations providing particular features or extensions. This document defines three instances of sd:Language: sd:SPARQL10Query, sd:SPARQL11Query, and sd:SPARQL11Update.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Language">http://www.w3.org/ns/sparql-service-description#Language</seealso>
    let Language = Prefixed_Name(sd, "Language") |> PrefixedName
    /// <summary>
    ///   <para>sd:SPARQL10Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Language</para>
    ///   <para>sd:SPARQL10Query is an sd:Language representing the SPARQL 1.0 Query language.</para>
    /// labels<para>SPARQL 1.0 Query</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#SPARQL10Query">http://www.w3.org/ns/sparql-service-description#SPARQL10Query</seealso>
    let SPARQL10Query = Prefixed_Name(sd, "SPARQL10Query") |> PrefixedName
    /// <summary>
    ///   <para>sd:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Service represents a SPARQL service made available via the SPARQL Protocol.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Service">http://www.w3.org/ns/sparql-service-description#Service</seealso>
    let Service = Prefixed_Name(sd, "Service") |> PrefixedName

    /// <summary>
    ///   <para>sd:defaultSupportedEntailmentProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service with a resource representing a supported profile of the default entailment regime (as declared by sd:defaultEntailmentRegime).</para>
    /// labels<para>default supported entailment profile</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#defaultSupportedEntailmentProfile">http://www.w3.org/ns/sparql-service-description#defaultSupportedEntailmentProfile</seealso>
    let defaultSupportedEntailmentProfile =
        Prefixed_Name(sd, "defaultSupportedEntailmentProfile") |> PrefixedName

    /// <summary>
    ///   <para>sd:defaultDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Relates an instance of sd:Service to a description of the default dataset available when no explicit dataset is specified in the query, update request or via protocol parameters.</para>
    /// labels<para>default dataset description</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#defaultDataset">http://www.w3.org/ns/sparql-service-description#defaultDataset</seealso>
    let defaultDataset = Prefixed_Name(sd, "defaultDataset") |> PrefixedName
    /// <summary>
    ///   <para>sd:entailmentRegime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a named graph description with a resource representing an entailment regime used for basic graph pattern matching over that graph.</para>
    /// labels<para>entailment regime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#entailmentRegime">http://www.w3.org/ns/sparql-service-description#entailmentRegime</seealso>
    let entailmentRegime = Prefixed_Name(sd, "entailmentRegime") |> PrefixedName
    /// <summary>
    ///   <para>sd:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a named graph to its graph description.</para>
    /// labels<para>graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#graph">http://www.w3.org/ns/sparql-service-description#graph</seealso>
    let graph = Prefixed_Name(sd, "graph") |> PrefixedName
    /// <summary>
    ///   <para>sd:languageExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a resource representing an implemented extension to the SPARQL Query or Update language.</para>
    /// labels<para>language extension</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#languageExtension">http://www.w3.org/ns/sparql-service-description#languageExtension</seealso>
    let languageExtension = Prefixed_Name(sd, "languageExtension") |> PrefixedName
    /// <summary>
    ///   <para>sd:propertyFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a resource representing an implemented feature that extends the SPARQL Query or Update language and that is accessed by using the named property.</para>
    /// labels<para>property feature</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#propertyFeature">http://www.w3.org/ns/sparql-service-description#propertyFeature</seealso>
    let propertyFeature = Prefixed_Name(sd, "propertyFeature") |> PrefixedName
    /// <summary>
    ///   <para>sd:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service with a resource representing a supported feature.</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#feature">http://www.w3.org/ns/sparql-service-description#feature</seealso>
    let feature = Prefixed_Name(sd, "feature") |> PrefixedName
    /// <summary>
    ///   <para>sd:extensionAggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE</para>
    /// labels<para>extension aggregate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#extensionAggregate">http://www.w3.org/ns/sparql-service-description#extensionAggregate</seealso>
    let extensionAggregate = Prefixed_Name(sd, "extensionAggregate") |> PrefixedName
    /// <summary>
    ///   <para>sd:inputFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a format that is supported for parsing RDF input; for example, via a SPARQL 1.1 Update LOAD statement, or when URIs are dereferenced in FROM/FROM NAMED/USING/USING NAMED clauses.</para>
    /// labels<para>input format</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#inputFormat">http://www.w3.org/ns/sparql-service-description#inputFormat</seealso>
    let inputFormat = Prefixed_Name(sd, "inputFormat") |> PrefixedName
    /// <summary>
    ///   <para>sd:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a named graph to the name by which it may be referenced in a FROM/FROM NAMED clause. The object of the sd:name property is an IRI.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#name">http://www.w3.org/ns/sparql-service-description#name</seealso>
    let name = Prefixed_Name(sd, "name") |> PrefixedName
    /// <summary>
    ///   <para>sd:resultFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a format that is supported for serializing query results.</para>
    /// labels<para>result format</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#resultFormat">http://www.w3.org/ns/sparql-service-description#resultFormat</seealso>
    let resultFormat = Prefixed_Name(sd, "resultFormat") |> PrefixedName
    /// <summary>
    ///   <para>sd:supportedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a SPARQL language (e.g. Query and Update) that it implements.</para>
    /// labels<para>supported language</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#supportedLanguage">http://www.w3.org/ns/sparql-service-description#supportedLanguage</seealso>
    let supportedLanguage = Prefixed_Name(sd, "supportedLanguage") |> PrefixedName
    /// <summary>
    ///   <para>sd:Aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Aggregate represents an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE.</para>
    /// labels<para>Aggregate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Aggregate">http://www.w3.org/ns/sparql-service-description#Aggregate</seealso>
    let Aggregate = Prefixed_Name(sd, "Aggregate") |> PrefixedName
    /// <summary>
    ///   <para>sd:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Dataset represents a RDF Dataset comprised of a default graph and zero or more named graphs.</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Dataset">http://www.w3.org/ns/sparql-service-description#Dataset</seealso>
    let Dataset = Prefixed_Name(sd, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>sd:EmptyGraphs</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///   <para>sd:EmptyGraphs, when used as the object of the sd:feature property, indicates that the underlying graph store supports empty graphs. A graph store that supports empty graphs MUST NOT remove graphs that are left empty after triples are removed from them.</para>
    /// labels<para>Empty Graphs</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#EmptyGraphs">http://www.w3.org/ns/sparql-service-description#EmptyGraphs</seealso>
    let EmptyGraphs = Prefixed_Name(sd, "EmptyGraphs") |> PrefixedName
    /// <summary>
    ///   <para>sd:EntailmentRegime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:EntailmentRegime represents an entailment regime used in basic graph pattern matching (as described by SPARQL 1.1 Query Language).</para>
    /// labels<para>Entailment Regime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#EntailmentRegime">http://www.w3.org/ns/sparql-service-description#EntailmentRegime</seealso>
    let EntailmentRegime = Prefixed_Name(sd, "EntailmentRegime") |> PrefixedName
    /// <summary>
    ///   <para>sd:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:Graph represents the description of an RDF graph.</para>
    /// labels<para>Graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#Graph">http://www.w3.org/ns/sparql-service-description#Graph</seealso>
    let Graph = Prefixed_Name(sd, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>sd:NamedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of sd:NamedGraph represents a named graph having a name (via sd:name) and an optional graph description (via sd:graph).</para>
    /// labels<para>Named Graph</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#NamedGraph">http://www.w3.org/ns/sparql-service-description#NamedGraph</seealso>
    let NamedGraph = Prefixed_Name(sd, "NamedGraph") |> PrefixedName
    /// <summary>
    ///   <para>sd:SPARQL11Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Language</para>
    ///   <para>sd:SPARQLUpdate is an sd:Language representing the SPARQL 1.1 Update language.</para>
    /// labels<para>SPARQL 1.1 Update</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#SPARQL11Update">http://www.w3.org/ns/sparql-service-description#SPARQL11Update</seealso>
    let SPARQL11Update = Prefixed_Name(sd, "SPARQL11Update") |> PrefixedName
    /// <summary>
    ///   <para>sd:availableGraphs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates an instance of sd:Service to a description of the graphs which are allowed in the construction of a dataset either via the SPARQL Protocol, with FROM/FROM NAMED clauses in a query, or with USING/USING NAMED in an update request, if the service limits the scope of dataset construction.</para>
    /// labels<para>available graph descriptions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sparql-service-description#availableGraphs">http://www.w3.org/ns/sparql-service-description#availableGraphs</seealso>
    let availableGraphs = Prefixed_Name(sd, "availableGraphs") |> PrefixedName
