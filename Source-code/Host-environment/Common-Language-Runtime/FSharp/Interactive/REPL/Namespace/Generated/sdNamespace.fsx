#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/sparql-service-description#" "sd"

    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Aggregate represents an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE.^^xsd:string</para>
    ///   <para>rdfs:label : Aggregate^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Aggregate">sd:Aggregate</a>
    /// </summary>
    let Aggregate = _prefixId.prefix "Aggregate"
    let BasicFederatedQuery = _prefixId.prefix "BasicFederatedQuery"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Dataset represents a RDF Dataset comprised of a default graph and zero or more named graphs.^^xsd:string</para>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Dataset">sd:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    let DereferencesURIs = _prefixId.prefix "DereferencesURIs"
    let EmptyGraphs = _prefixId.prefix "EmptyGraphs"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:EntailmentProfile represents a profile of an entailment regime. An entailment profile MAY impose restrictions on what constitutes valid RDF with respect to entailment.^^xsd:string</para>
    ///   <para>rdfs:label : Entailment Profile^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#EntailmentProfile">sd:EntailmentProfile</a>
    /// </summary>
    let EntailmentProfile = _prefixId.prefix "EntailmentProfile"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:EntailmentRegime represents an entailment regime used in basic graph pattern matching (as described by SPARQL 1.1 Query Language).^^xsd:string</para>
    ///   <para>rdfs:label : Entailment Regime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#EntailmentRegime">sd:EntailmentRegime</a>
    /// </summary>
    let EntailmentRegime = _prefixId.prefix "EntailmentRegime"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Feature represents a feature of a SPARQL service. Specific types of features include functions, aggregates, languages, and entailment regimes and profiles. This document defines five instances of sd:Feature: sd:DereferencesURIs, sd:UnionDefaultGraph, sd:RequiresDataset, sd:EmptyGraphs, and sd:BasicFederatedQuery.^^xsd:string</para>
    ///   <para>rdfs:label : Feature^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Feature">sd:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Function represents a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.^^xsd:string</para>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Function">sd:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Graph represents the description of an RDF graph.^^xsd:string</para>
    ///   <para>rdfs:label : Graph^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Graph">sd:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:GraphCollection represents a collection of zero or more named graph descriptions. Each named graph description belonging to an sd:GraphCollection MUST be linked with the sd:namedGraph predicate.^^xsd:string</para>
    ///   <para>rdfs:label : Graph Collection^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#GraphCollection">sd:GraphCollection</a>
    /// </summary>
    let GraphCollection = _prefixId.prefix "GraphCollection"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Language represents one of the SPARQL languages, including specific configurations providing particular features or extensions. This document defines three instances of sd:Language: sd:SPARQL10Query, sd:SPARQL11Query, and sd:SPARQL11Update.^^xsd:string</para>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Language">sd:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:NamedGraph represents a named graph having a name (via sd:name) and an optional graph description (via sd:graph).^^xsd:string</para>
    ///   <para>rdfs:label : Named Graph^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#NamedGraph">sd:NamedGraph</a>
    /// </summary>
    let NamedGraph = _prefixId.prefix "NamedGraph"
    let RequiresDataset = _prefixId.prefix "RequiresDataset"
    let SPARQL10Query = _prefixId.prefix "SPARQL10Query"
    let SPARQL11Query = _prefixId.prefix "SPARQL11Query"
    let SPARQL11Update = _prefixId.prefix "SPARQL11Update"
    /// <summary>
    ///   <para>rdfs:comment : An instance of sd:Service represents a SPARQL service made available via the SPARQL Protocol.^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#Service">sd:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    let UnionDefaultGraph = _prefixId.prefix "UnionDefaultGraph"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a description of the graphs which are allowed in the construction of a dataset either via the SPARQL Protocol, with FROM/FROM NAMED clauses in a query, or with USING/USING NAMED in an update request, if the service limits the scope of dataset construction.^^xsd:string</para>
    ///   <para>rdfs:label : available graph descriptions^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#availableGraphs">sd:availableGraphs</a>
    /// </summary>
    let availableGraphs = _prefixId.prefix "availableGraphs"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a description of the default dataset available when no explicit dataset is specified in the query, update request or via protocol parameters.^^xsd:string</para>
    ///   <para>rdfs:label : default dataset description^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#defaultDataset">sd:defaultDataset</a>
    /// </summary>
    let defaultDataset = _prefixId.prefix "defaultDataset"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service with a resource representing an entailment regime used for basic graph pattern matching. This property is intended for use when a single entailment regime by default applies to all graphs in the default dataset of the service. In situations where a different entailment regime applies to a specific graph in the dataset, the sd:entailmentRegime property should be used to indicate this fact in the description of that graph.^^xsd:string</para>
    ///   <para>rdfs:label : default entailment regime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#defaultEntailmentRegime">sd:defaultEntailmentRegime</a>
    /// </summary>
    let defaultEntailmentRegime = _prefixId.prefix "defaultEntailmentRegime"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Dataset to the description of its default graph.^^xsd:string</para>
    ///   <para>rdfs:label : default graph^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#defaultGraph">sd:defaultGraph</a>
    /// </summary>
    let defaultGraph = _prefixId.prefix "defaultGraph"

    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service with a resource representing a supported profile of the default entailment regime (as declared by sd:defaultEntailmentRegime).^^xsd:string</para>
    ///   <para>rdfs:label : default supported entailment profile^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#defaultSupportedEntailmentProfile">sd:defaultSupportedEntailmentProfile</a>
    /// </summary>
    let defaultSupportedEntailmentProfile =
        _prefixId.prefix "defaultSupportedEntailmentProfile"

    /// <summary>
    ///   <para>rdfs:comment : The SPARQL endpoint of an sd:Service that implements the SPARQL Protocol service. The object of the sd:endpoint property is an IRI.^^xsd:string</para>
    ///   <para>rdfs:label : endpoint^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#endpoint">sd:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:comment : Relates a named graph description with a resource representing an entailment regime used for basic graph pattern matching over that graph.^^xsd:string</para>
    ///   <para>rdfs:label : entailment regime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#entailmentRegime">sd:entailmentRegime</a>
    /// </summary>
    let entailmentRegime = _prefixId.prefix "entailmentRegime"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to an aggregate that may be used in a SPARQL aggregate query (for instance in a HAVING clause or SELECT expression) besides the standard list of supported aggregates COUNT, SUM, MIN, MAX, AVG, GROUP_CONCAT, and SAMPLE^^xsd:string</para>
    ///   <para>rdfs:label : extension aggregate^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#extensionAggregate">sd:extensionAggregate</a>
    /// </summary>
    let extensionAggregate = _prefixId.prefix "extensionAggregate"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a function that may be used in a SPARQL SELECT expression or a FILTER, HAVING, GROUP BY, ORDER BY, or BIND clause.^^xsd:string</para>
    ///   <para>rdfs:label : extension function^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#extensionFunction">sd:extensionFunction</a>
    /// </summary>
    let extensionFunction = _prefixId.prefix "extensionFunction"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service with a resource representing a supported feature.^^xsd:string</para>
    ///   <para>rdfs:label : feature^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#feature">sd:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : Relates a named graph to its graph description.^^xsd:string</para>
    ///   <para>rdfs:label : graph^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#graph">sd:graph</a>
    /// </summary>
    let graph = _prefixId.prefix "graph"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a format that is supported for parsing RDF input; for example, via a SPARQL 1.1 Update LOAD statement, or when URIs are dereferenced in FROM/FROM NAMED/USING/USING NAMED clauses.^^xsd:string</para>
    ///   <para>rdfs:label : input format^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#inputFormat">sd:inputFormat</a>
    /// </summary>
    let inputFormat = _prefixId.prefix "inputFormat"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a resource representing an implemented extension to the SPARQL Query or Update language.^^xsd:string</para>
    ///   <para>rdfs:label : language extension^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#languageExtension">sd:languageExtension</a>
    /// </summary>
    let languageExtension = _prefixId.prefix "languageExtension"
    /// <summary>
    ///   <para>rdfs:comment : Relates a named graph to the name by which it may be referenced in a FROM/FROM NAMED clause. The object of the sd:name property is an IRI.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#name">sd:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:GraphCollection (or its subclass sd:Dataset) to the description of one of its named graphs. The description of such a named graph MUST include the sd:name property and MAY include the sd:graph property.^^xsd:string</para>
    ///   <para>rdfs:label : named graph^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#namedGraph">sd:namedGraph</a>
    /// </summary>
    let namedGraph = _prefixId.prefix "namedGraph"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a resource representing an implemented feature that extends the SPARQL Query or Update language and that is accessed by using the named property.^^xsd:string</para>
    ///   <para>rdfs:label : property feature^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#propertyFeature">sd:propertyFeature</a>
    /// </summary>
    let propertyFeature = _prefixId.prefix "propertyFeature"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a format that is supported for serializing query results.^^xsd:string</para>
    ///   <para>rdfs:label : result format^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#resultFormat">sd:resultFormat</a>
    /// </summary>
    let resultFormat = _prefixId.prefix "resultFormat"
    /// <summary>
    ///   <para>rdfs:comment : Relates a named graph description with a resource representing a supported profile of the entailment regime (as declared by sd:entailmentRegime) used for basic graph pattern matching over that graph.^^xsd:string</para>
    ///   <para>rdfs:label : supported entailment profile^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#supportedEntailmentProfile">sd:supportedEntailmentProfile</a>
    /// </summary>
    let supportedEntailmentProfile = _prefixId.prefix "supportedEntailmentProfile"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of sd:Service to a SPARQL language (e.g. Query and Update) that it implements.^^xsd:string</para>
    ///   <para>rdfs:label : supported language^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/sparql-service-description#supportedLanguage">sd:supportedLanguage</a>
    /// </summary>
    let supportedLanguage = _prefixId.prefix "supportedLanguage"
