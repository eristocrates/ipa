#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bbcprov =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/provenance/" "bbcprov"

    let ``_1.8`` = _prefixId.prefix "1.8"
    let ``_1.9`` = _prefixId.prefix "1.9"
    /// <summary>
    ///   <para>rdfs:label : CreativeWorkGraph</para>
    ///   <para>rdfs:comment : The class of named graphs which contain the metadata for the CreativeWorks. For example all the metadata for a news story provided by a CMS will be contained in a single CreativeWorkGraph instance.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/CreativeWorkGraph">bbcprov:CreativeWorkGraph</a>
    /// </summary>
    let CreativeWorkGraph = _prefixId.prefix "CreativeWorkGraph"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : Dataset is a single graph which contains a collection of things that is managed together, e.g., "the dataset of the BBC's News Regions". The management of datasets involves editing RDF files and publishing them to the triplestore in a single action. This requires a good knowledge of semantic technologies therefore datasets are managed by experts.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/Dataset">bbcprov:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Graph</para>
    ///   <para>rdfs:comment : The class of named graphs. All our data is stored in named graphs of different types depending on its provenance and management. These are specified by the subclasses of Graph.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/Graph">bbcprov:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>rdfs:label : Ontology</para>
    ///   <para>rdfs:comment : Graphs that contain ontologies in the store are declared to be of type provenance:Ontology. The graph name in the store is identical to the ontology IRI.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/Ontology">bbcprov:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : ThingGraph</para>
    ///   <para>rdfs:comment : Thing graphs hold metadata about a single thing. Note the difference with Datasets, which hold metadata about many things. Thing graphs are usually exposed to user friendly tools which allow users with little on no RDF skills to specifically edit a metadata about a thing in a form. For example a thing graph can contain metadata about a football team such as its various names, LOD links for the team, a short disambiguation hint, e.t.c. Thing graphs are also used to store metadata about things obtained from a feed, for example store metadata about locations obtained from a Location Services feed.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/ThingGraph">bbcprov:ThingGraph</a>
    /// </summary>
    let ThingGraph = _prefixId.prefix "ThingGraph"
    /// <summary>
    ///   <para>rdfs:label : Transition Ontology</para>
    ///   <para>rdfs:comment : An ontology that is used to provide a transition feature for a parent ontology^^xsd:string</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/TransitionOntology">bbcprov:TransitionOntology</a>
    /// </summary>
    let TransitionOntology = _prefixId.prefix "TransitionOntology"
    /// <summary>
    ///   <para>rdfs:label : canonicalLocation</para>
    ///   <para>rdfs:comment : The canonical location where all the triples contained within the context (named graph) are stored in and can be referred to outside the triplestore.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/canonicalLocation">bbcprov:canonicalLocation</a>
    /// </summary>
    let canonicalLocation = _prefixId.prefix "canonicalLocation"
    /// <summary>
    ///   <para>rdfs:label : changeReason</para>
    ///   <para>rdfs:comment : The reason for the most recent change applied to the graph.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/changeReason">bbcprov:changeReason</a>
    /// </summary>
    let changeReason = _prefixId.prefix "changeReason"
    /// <summary>
    ///   <para>rdfs:label : created</para>
    ///   <para>rdfs:comment : The date when a Thing was created.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/created">bbcprov:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : deprecated</para>
    ///   <para>rdfs:comment : A predicate to allow hiding of Things so as to not delete them and lose the reference object.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/deprecated">bbcprov:deprecated</a>
    /// </summary>
    let deprecated = _prefixId.prefix "deprecated"
    /// <summary>
    ///   <para>rdfs:label : managedBy</para>
    ///   <para>rdfs:comment : Associates the thing graph of a cms:ManagedThing with its managing system. This is needed to solve cases where different systems can manage metadata about a shared thing. E.g., one thing graph from BBC News may have all the politics related metadata for David Cameron, while another thing graph managed by Knowledge and Learning may contain information about the historical role David Cameron has played as a conservative leader in British politics. Separating metadata into thing graphs is useful for managing information about shared things.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/managedBy">bbcprov:managedBy</a>
    /// </summary>
    let managedBy = _prefixId.prefix "managedBy"
    /// <summary>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:comment : This property indicates the owner of the data, i.e., the person or CMS who's responsible for managing and governing the data.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/owner">bbcprov:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : product</para>
    ///   <para>rdfs:comment : The reference to the product from which the dataset, graph was created. This is needed for dataset management permissions. Not to be confused with bbc:product.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/product">bbcprov:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>rdfs:label : provided</para>
    ///   <para>rdfs:comment : The date and time at which the data was provided to the triplestore.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/provided">bbcprov:provided</a>
    /// </summary>
    let provided = _prefixId.prefix "provided"
    /// <summary>
    ///   <para>rdfs:label : provider</para>
    ///   <para>rdfs:comment : The email address extracted from the BBC SSL Certificate, indicating the person or system which directly interacted with the writer service to put the data in the store.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/provider">bbcprov:provider</a>
    /// </summary>
    let provider = _prefixId.prefix "provider"
    /// <summary>
    ///   <para>rdfs:label : public</para>
    ///   <para>rdfs:comment : This predicate allows the distinction of ontologies that are appropriate for publishing from those ones that are currently kept internal, e.g., for testing purposes.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/public">bbcprov:public</a>
    /// </summary>
    let public_ = _prefixId.prefix "public"
    /// <summary>
    ///   <para>rdfs:label : slug</para>
    ///   <para>rdfs:comment : This is a short human readable identifier for the ontology.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/slug">bbcprov:slug</a>
    /// </summary>
    let slug = _prefixId.prefix "slug"
    /// <summary>
    ///   <para>rdfs:label : transitions</para>
    ///   <para>rdfs:comment : The property that this transition property is providing a transition for.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/transitions">bbcprov:transitions</a>
    /// </summary>
    let transitions = _prefixId.prefix "transitions"
    /// <summary>
    ///   <para>rdfs:label : version</para>
    ///   <para>rdfs:comment : The version of the graph.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/provenance/version">bbcprov:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
