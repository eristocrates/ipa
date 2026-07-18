namespace http.www.bbc.co.uk.ontologies.provenance.slash

open DoxAletheia.Rdf_Vocabulary

module bbcprov =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/provenance/"

    /// <summary>
    /// The canonical location where all the triples contained within the context (named graph) are stored in and can be referred to outside the triplestore.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/canonicalLocation"></see></summary>
    let canonicalLocation =
        Namespaced_IRI.parse _namespace_name "canonicalLocation" |> NamespacedName

    /// <summary>
    /// The reason for the most recent change applied to the graph.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/changeReason"></see></summary>
    let changeReason =
        Namespaced_IRI.parse _namespace_name "changeReason" |> NamespacedName

    /// <summary>
    /// The date and time at which the data was provided to the triplestore.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/provided"></see></summary>
    let provided = Namespaced_IRI.parse _namespace_name "provided" |> NamespacedName
    /// <summary>
    /// The email address extracted from the BBC SSL Certificate, indicating the person or system which directly interacted with the writer service to put the data in the store.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/provider"></see></summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName
    /// <summary>
    /// This predicate allows the distinction of ontologies that are appropriate for publishing from those ones that are currently kept internal, e.g., for testing purposes.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/public"></see></summary>
    let public_ = Namespaced_IRI.parse _namespace_name "public" |> NamespacedName
    /// <summary>
    /// This is a short human readable identifier for the ontology.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/slug"></see></summary>
    let slug = Namespaced_IRI.parse _namespace_name "slug" |> NamespacedName
    /// <summary>
    /// The version of the graph.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// Graphs that contain ontologies in the store are declared to be of type provenance:Ontology. The graph name in the store is identical to the ontology IRI.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/provenance/1.8"></see>
    /// </summary>
    let ``_1.8`` = Namespaced_IRI.parse _namespace_name "1.8" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/provenance/1.9"></see>
    /// </summary>
    let ``_1.9`` = Namespaced_IRI.parse _namespace_name "1.9" |> NamespacedName

    /// <summary>
    /// The class of named graphs which contain the metadata for the CreativeWorks. For example all the metadata for a news story provided by a CMS will be contained in a single CreativeWorkGraph instance.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/CreativeWorkGraph"></see></summary>
    let CreativeWorkGraph =
        Namespaced_IRI.parse _namespace_name "CreativeWorkGraph" |> NamespacedName

    /// <summary>
    /// The class of named graphs. All our data is stored in named graphs of different types depending on its provenance and management. These are specified by the subclasses of Graph.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/Graph"></see></summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName
    /// <summary>
    /// Dataset is a single graph which contains a collection of things that is managed together, e.g., "the dataset of the BBC's News Regions". The management of datasets involves editing RDF files and publishing them to the triplestore in a single action. This requires a good knowledge of semantic technologies therefore datasets are managed by experts.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// Thing graphs hold metadata about a single thing. Note the difference with Datasets, which hold metadata about many things. Thing graphs are usually exposed to user friendly tools which allow users with little on no RDF skills to specifically edit a metadata about a thing in a form. For example a thing graph can contain metadata about a football team such as its various names, LOD links for the team, a short disambiguation hint, e.t.c. Thing graphs are also used to store metadata about things obtained from a feed, for example store metadata about locations obtained from a Location Services feed.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/ThingGraph"></see></summary>
    let ThingGraph = Namespaced_IRI.parse _namespace_name "ThingGraph" |> NamespacedName

    /// <summary>
    /// An ontology that is used to provide a transition feature for a parent ontology
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/TransitionOntology"></see></summary>
    let TransitionOntology =
        Namespaced_IRI.parse _namespace_name "TransitionOntology" |> NamespacedName

    /// <summary>
    /// The date when a Thing was created.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// A predicate to allow hiding of Things so as to not delete them and lose the reference object.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/deprecated"></see></summary>
    let deprecated = Namespaced_IRI.parse _namespace_name "deprecated" |> NamespacedName
    /// <summary>
    /// Associates the thing graph of a cms:ManagedThing with its managing system. This is needed to solve cases where different systems can manage metadata about a shared thing. E.g., one thing graph from BBC News may have all the politics related metadata for David Cameron, while another thing graph managed by Knowledge and Learning may contain information about the historical role David Cameron has played as a conservative leader in British politics. Separating metadata into thing graphs is useful for managing information about shared things.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/managedBy"></see></summary>
    let managedBy = Namespaced_IRI.parse _namespace_name "managedBy" |> NamespacedName
    /// <summary>
    /// This property indicates the owner of the data, i.e., the person or CMS who's responsible for managing and governing the data.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// The reference to the product from which the dataset, graph was created. This is needed for dataset management permissions. Not to be confused with bbc:product.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName

    /// <summary>
    /// The property that this transition property is providing a transition for.
    /// <see href="http://www.bbc.co.uk/ontologies/provenance/transitions"></see></summary>
    let transitions =
        Namespaced_IRI.parse _namespace_name "transitions" |> NamespacedName
