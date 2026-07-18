namespace https.w3id.org.tree.hash

open DoxAletheia.Rdf_Vocabulary

module tree =
    let _namespace_name = "https://w3id.org/tree#"
    /// <summary>
    /// A hypermedia specification for fragmenting collections.
    /// <see href="https://w3id.org/tree#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName
    /// <summary>
    /// A tree:Collection is a collection containing members. The members may be spread across multiple tree:Nodes.
    /// <see href="https://w3id.org/tree#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// Import a page when the tree:path is interesting for the client
    /// <see href="https://w3id.org/tree#ConditionalImport"></see></summary>
    let ConditionalImport =
        Namespaced_IRI.parse _namespace_name "ConditionalImport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tree#EqualToRelation"></see>
    /// </summary>
    let EqualToRelation =
        Namespaced_IRI.parse _namespace_name "EqualToRelation" |> NamespacedName

    /// <summary>
    /// A class describing the relation between two nodes
    /// <see href="https://w3id.org/tree#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName

    /// <summary>
    /// All further members are geospatially contained within the WKT string of the tree:value.
    /// <see href="https://w3id.org/tree#GeospatiallyContainsRelation"></see></summary>
    let GeospatiallyContainsRelation =
        Namespaced_IRI.parse _namespace_name "GeospatiallyContainsRelation" |> NamespacedName

    /// <summary>
    /// All members of this related node are greater than or equal to the value
    /// <see href="https://w3id.org/tree#GreaterThanOrEqualToRelation"></see></summary>
    let GreaterThanOrEqualToRelation =
        Namespaced_IRI.parse _namespace_name "GreaterThanOrEqualToRelation" |> NamespacedName

    /// <summary>
    /// All members of this related node are greater than the value
    /// <see href="https://w3id.org/tree#GreaterThanRelation"></see></summary>
    let GreaterThanRelation =
        Namespaced_IRI.parse _namespace_name "GreaterThanRelation" |> NamespacedName

    /// <summary>
    /// For comparing intervals: all further members are in-between the given interval
    /// <see href="https://w3id.org/tree#InBetweenRelation"></see></summary>
    let InBetweenRelation =
        Namespaced_IRI.parse _namespace_name "InBetweenRelation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tree#LessThanOrEqualToRelation"></see>
    /// </summary>
    let LessThanOrEqualToRelation =
        Namespaced_IRI.parse _namespace_name "LessThanOrEqualToRelation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tree#LessThanRelation"></see>
    /// </summary>
    let LessThanRelation =
        Namespaced_IRI.parse _namespace_name "LessThanRelation" |> NamespacedName

    /// <summary>
    /// A tree:Node is a node that may contain relations to other nodes.
    /// <see href="https://w3id.org/tree#Node"></see></summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName

    /// <summary>
    /// All members of this related node start with this prefix
    /// <see href="https://w3id.org/tree#PrefixRelation"></see></summary>
    let PrefixRelation =
        Namespaced_IRI.parse _namespace_name "PrefixRelation" |> NamespacedName

    /// <summary>
    /// All members of this related node contain this substring
    /// <see href="https://w3id.org/tree#SubstringRelation"></see></summary>
    let SubstringRelation =
        Namespaced_IRI.parse _namespace_name "SubstringRelation" |> NamespacedName

    /// <summary>
    /// All members of this related node end with this suffix
    /// <see href="https://w3id.org/tree#SuffixRelation"></see></summary>
    let SuffixRelation =
        Namespaced_IRI.parse _namespace_name "SuffixRelation" |> NamespacedName

    /// <summary>
    /// Describes a specific TREE structure on top of the tree:Collection
    /// <see href="https://w3id.org/tree#ViewDescription"></see></summary>
    let ViewDescription =
        Namespaced_IRI.parse _namespace_name "ViewDescription" |> NamespacedName

    /// <summary>
    /// Imports a file in order being able to evaluate a tree:path correctly
    /// <see href="https://w3id.org/tree#conditionalImport"></see></summary>
    let conditionalImport =
        Namespaced_IRI.parse _namespace_name "conditionalImport" |> NamespacedName

    /// <summary>
    /// Imports a file in order being able to evaluate a tree:path correctly or comply fully to the tree:shape defined in the Collection
    /// <see href="https://w3id.org/tree#import"></see></summary>
    let import = Namespaced_IRI.parse _namespace_name "import" |> NamespacedName

    /// <summary>
    /// The Y tile number from latitude cfr. OSM convention
    /// <see href="https://w3id.org/tree#latitudeTile"></see></summary>
    let latitudeTile =
        Namespaced_IRI.parse _namespace_name "latitudeTile" |> NamespacedName

    /// <summary>
    /// The X tile number from longitude cfr. OSM convention
    /// <see href="https://w3id.org/tree#longitudeTile"></see></summary>
    let longitudeTile =
        Namespaced_IRI.parse _namespace_name "longitudeTile" |> NamespacedName

    /// <summary>
    /// The collection has a member.
    /// <see href="https://w3id.org/tree#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// The URL to follow when this Node cannot be pruned
    /// <see href="https://w3id.org/tree#node"></see></summary>
    let node = Namespaced_IRI.parse _namespace_name "node" |> NamespacedName
    /// <summary>
    /// A property path, as defined by shacl, that indicates what resource the tree:value affects.
    /// <see href="https://w3id.org/tree#path"></see></summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    /// Links a node with another through a Relation class
    /// <see href="https://w3id.org/tree#relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName

    /// <summary>
    /// Total number of items of this node and its children
    /// <see href="https://w3id.org/tree#remainingItems"></see></summary>
    let remainingItems =
        Namespaced_IRI.parse _namespace_name "remainingItems" |> NamespacedName

    /// <summary>
    /// The Node can be searched for child nodes.
    /// <see href="https://w3id.org/tree#search"></see></summary>
    let search = Namespaced_IRI.parse _namespace_name "search" |> NamespacedName
    /// <summary>
    /// The SHACL shape the members of the collection adhere to.
    /// <see href="https://w3id.org/tree#shape"></see></summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName
    /// <summary>
    /// Will search for elements starting from a certain timestamp
    /// <see href="https://w3id.org/tree#timeQuery"></see></summary>
    let timeQuery = Namespaced_IRI.parse _namespace_name "timeQuery" |> NamespacedName
    /// <summary>
    /// The value the node linked in the node relation is compared to
    /// <see href="https://w3id.org/tree#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Links the collection to a `tree:Node` from which all other members can be found.
    /// <see href="https://w3id.org/tree#view"></see></summary>
    let view = Namespaced_IRI.parse _namespace_name "view" |> NamespacedName

    /// <summary>
    /// Links together a tree:Node with its description of this TREE structure
    /// <see href="https://w3id.org/tree#viewDescription"></see></summary>
    let viewDescription =
        Namespaced_IRI.parse _namespace_name "viewDescription" |> NamespacedName

    /// <summary>
    /// The zoom level of the tile cfr. OSM convention
    /// <see href="https://w3id.org/tree#zoom"></see></summary>
    let zoom = Namespaced_IRI.parse _namespace_name "zoom" |> NamespacedName
