namespace http.www.bbc.co.uk.ontologies.provenance.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bbcprov =
    let _namespace_iri = Namespace_Iri bbcprov |> NamespaceIRI
    /// <summary>
    ///   <para>bbcprov:changeReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason for the most recent change applied to the graph.</para>
    /// labels<para>changeReason</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/changeReason">http://www.bbc.co.uk/ontologies/provenance/changeReason</seealso>
    let changeReason = Prefixed_Name(bbcprov, "changeReason") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The version of the graph.</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/version">http://www.bbc.co.uk/ontologies/provenance/version</seealso>
    let version = Prefixed_Name(bbcprov, "version") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:CreativeWorkGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of named graphs which contain the metadata for the CreativeWorks. For example all the metadata for a news story provided by a CMS will be contained in a single CreativeWorkGraph instance.</para>
    /// labels<para>CreativeWorkGraph</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/CreativeWorkGraph">http://www.bbc.co.uk/ontologies/provenance/CreativeWorkGraph</seealso>
    let CreativeWorkGraph = Prefixed_Name(bbcprov, "CreativeWorkGraph") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:ThingGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thing graphs hold metadata about a single thing. Note the difference with Datasets, which hold metadata about many things. Thing graphs are usually exposed to user friendly tools which allow users with little on no RDF skills to specifically edit a metadata about a thing in a form. For example a thing graph can contain metadata about a football team such as its various names, LOD links for the team, a short disambiguation hint, e.t.c. Thing graphs are also used to store metadata about things obtained from a feed, for example store metadata about locations obtained from a Location Services feed.</para>
    /// labels<para>ThingGraph</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/ThingGraph">http://www.bbc.co.uk/ontologies/provenance/ThingGraph</seealso>
    let ThingGraph = Prefixed_Name(bbcprov, "ThingGraph") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when a Thing was created.</para>
    /// labels<para>created</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/created">http://www.bbc.co.uk/ontologies/provenance/created</seealso>
    let created = Prefixed_Name(bbcprov, "created") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property indicates the owner of the data, i.e., the person or CMS who's responsible for managing and governing the data.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/owner">http://www.bbc.co.uk/ontologies/provenance/owner</seealso>
    let owner = Prefixed_Name(bbcprov, "owner") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:provided</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time at which the data was provided to the triplestore.</para>
    /// labels<para>provided</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/provided">http://www.bbc.co.uk/ontologies/provenance/provided</seealso>
    let provided = Prefixed_Name(bbcprov, "provided") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:1.8</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/1.8">http://www.bbc.co.uk/ontologies/provenance/1.8</seealso>
    let ``_1.8`` = Prefixed_Name(bbcprov, "1.8") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dataset is a single graph which contains a collection of things that is managed together, e.g., "the dataset of the BBC's News Regions". The management of datasets involves editing RDF files and publishing them to the triplestore in a single action. This requires a good knowledge of semantic technologies therefore datasets are managed by experts.</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/Dataset">http://www.bbc.co.uk/ontologies/provenance/Dataset</seealso>
    let Dataset = Prefixed_Name(bbcprov, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>bbcprov:TransitionOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ontology that is used to provide a transition feature for a parent ontology</para>
    /// labels<para>Transition Ontology</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/TransitionOntology">http://www.bbc.co.uk/ontologies/provenance/TransitionOntology</seealso>
    let TransitionOntology =
        Prefixed_Name(bbcprov, "TransitionOntology") |> PrefixedName

    /// <summary>
    ///   <para>bbcprov:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A predicate to allow hiding of Things so as to not delete them and lose the reference object.</para>
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/deprecated">http://www.bbc.co.uk/ontologies/provenance/deprecated</seealso>
    let deprecated = Prefixed_Name(bbcprov, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:public</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This predicate allows the distinction of ontologies that are appropriate for publishing from those ones that are currently kept internal, e.g., for testing purposes.</para>
    /// labels<para>public</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/public">http://www.bbc.co.uk/ontologies/provenance/public</seealso>
    let public_ = Prefixed_Name(bbcprov, "public") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of named graphs. All our data is stored in named graphs of different types depending on its provenance and management. These are specified by the subclasses of Graph.</para>
    /// labels<para>Graph</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/Graph">http://www.bbc.co.uk/ontologies/provenance/Graph</seealso>
    let Graph = Prefixed_Name(bbcprov, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:1.9</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/1.9">http://www.bbc.co.uk/ontologies/provenance/1.9</seealso>
    let ``_1.9`` = Prefixed_Name(bbcprov, "1.9") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:managedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the thing graph of a cms:ManagedThing with its managing system. This is needed to solve cases where different systems can manage metadata about a shared thing. E.g., one thing graph from BBC News may have all the politics related metadata for David Cameron, while another thing graph managed by Knowledge and Learning may contain information about the historical role David Cameron has played as a conservative leader in British politics. Separating metadata into thing graphs is useful for managing information about shared things.</para>
    /// labels<para>managedBy</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/managedBy">http://www.bbc.co.uk/ontologies/provenance/managedBy</seealso>
    let managedBy = Prefixed_Name(bbcprov, "managedBy") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The reference to the product from which the dataset, graph was created. This is needed for dataset management permissions. Not to be confused with bbc:product.</para>
    /// labels<para>product</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/product">http://www.bbc.co.uk/ontologies/provenance/product</seealso>
    let product = Prefixed_Name(bbcprov, "product") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:transitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that this transition property is providing a transition for.</para>
    /// labels<para>transitions</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/transitions">http://www.bbc.co.uk/ontologies/provenance/transitions</seealso>
    let transitions = Prefixed_Name(bbcprov, "transitions") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:canonicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The canonical location where all the triples contained within the context (named graph) are stored in and can be referred to outside the triplestore.</para>
    /// labels<para>canonicalLocation</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/canonicalLocation">http://www.bbc.co.uk/ontologies/provenance/canonicalLocation</seealso>
    let canonicalLocation = Prefixed_Name(bbcprov, "canonicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The email address extracted from the BBC SSL Certificate, indicating the person or system which directly interacted with the writer service to put the data in the store.</para>
    /// labels<para>provider</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/provider">http://www.bbc.co.uk/ontologies/provenance/provider</seealso>
    let provider = Prefixed_Name(bbcprov, "provider") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:slug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is a short human readable identifier for the ontology.</para>
    /// labels<para>slug</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/slug">http://www.bbc.co.uk/ontologies/provenance/slug</seealso>
    let slug = Prefixed_Name(bbcprov, "slug") |> PrefixedName
    /// <summary>
    ///   <para>bbcprov:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Graphs that contain ontologies in the store are declared to be of type provenance:Ontology. The graph name in the store is identical to the ontology IRI.</para>
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/provenance/Ontology">http://www.bbc.co.uk/ontologies/provenance/Ontology</seealso>
    let Ontology = Prefixed_Name(bbcprov, "Ontology") |> PrefixedName
