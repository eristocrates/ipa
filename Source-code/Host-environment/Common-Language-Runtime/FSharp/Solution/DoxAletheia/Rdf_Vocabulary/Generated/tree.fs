namespace https.w3id.org.tree.hash

open DoxAletheia

module tree =
    let _namespace_name = "https://w3id.org/tree#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A hypermedia specification for fragmenting collections.
    /// <see href="https://w3id.org/tree#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// A tree:Collection is a collection containing members. The members may be spread across multiple tree:Nodes.
    /// <see href="https://w3id.org/tree#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// Import a page when the tree:path is interesting for the client
    /// <see href="https://w3id.org/tree#ConditionalImport"></see></summary>
    let ConditionalImport = _prefix "ConditionalImport"
    /// <summary>
    ///   <see href="https://w3id.org/tree#EqualToRelation"></see>
    /// </summary>
    let EqualToRelation = _prefix "EqualToRelation"
    /// <summary>
    /// A class describing the relation between two nodes
    /// <see href="https://w3id.org/tree#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// All further members are geospatially contained within the WKT string of the tree:value.
    /// <see href="https://w3id.org/tree#GeospatiallyContainsRelation"></see></summary>
    let GeospatiallyContainsRelation = _prefix "GeospatiallyContainsRelation"
    /// <summary>
    /// All members of this related node are greater than or equal to the value
    /// <see href="https://w3id.org/tree#GreaterThanOrEqualToRelation"></see></summary>
    let GreaterThanOrEqualToRelation = _prefix "GreaterThanOrEqualToRelation"
    /// <summary>
    /// All members of this related node are greater than the value
    /// <see href="https://w3id.org/tree#GreaterThanRelation"></see></summary>
    let GreaterThanRelation = _prefix "GreaterThanRelation"
    /// <summary>
    /// For comparing intervals: all further members are in-between the given interval
    /// <see href="https://w3id.org/tree#InBetweenRelation"></see></summary>
    let InBetweenRelation = _prefix "InBetweenRelation"
    /// <summary>
    ///   <see href="https://w3id.org/tree#LessThanOrEqualToRelation"></see>
    /// </summary>
    let LessThanOrEqualToRelation = _prefix "LessThanOrEqualToRelation"
    /// <summary>
    ///   <see href="https://w3id.org/tree#LessThanRelation"></see>
    /// </summary>
    let LessThanRelation = _prefix "LessThanRelation"
    /// <summary>
    /// A tree:Node is a node that may contain relations to other nodes.
    /// <see href="https://w3id.org/tree#Node"></see></summary>
    let Node = _prefix "Node"
    /// <summary>
    /// All members of this related node start with this prefix
    /// <see href="https://w3id.org/tree#PrefixRelation"></see></summary>
    let PrefixRelation = _prefix "PrefixRelation"
    /// <summary>
    /// All members of this related node contain this substring
    /// <see href="https://w3id.org/tree#SubstringRelation"></see></summary>
    let SubstringRelation = _prefix "SubstringRelation"
    /// <summary>
    /// All members of this related node end with this suffix
    /// <see href="https://w3id.org/tree#SuffixRelation"></see></summary>
    let SuffixRelation = _prefix "SuffixRelation"
    /// <summary>
    /// Describes a specific TREE structure on top of the tree:Collection
    /// <see href="https://w3id.org/tree#ViewDescription"></see></summary>
    let ViewDescription = _prefix "ViewDescription"
    /// <summary>
    /// Imports a file in order being able to evaluate a tree:path correctly
    /// <see href="https://w3id.org/tree#conditionalImport"></see></summary>
    let conditionalImport = _prefix "conditionalImport"
    /// <summary>
    /// Imports a file in order being able to evaluate a tree:path correctly or comply fully to the tree:shape defined in the Collection
    /// <see href="https://w3id.org/tree#import"></see></summary>
    let import = _prefix "import"
    /// <summary>
    /// The Y tile number from latitude cfr. OSM convention
    /// <see href="https://w3id.org/tree#latitudeTile"></see></summary>
    let latitudeTile = _prefix "latitudeTile"
    /// <summary>
    /// The X tile number from longitude cfr. OSM convention
    /// <see href="https://w3id.org/tree#longitudeTile"></see></summary>
    let longitudeTile = _prefix "longitudeTile"
    /// <summary>
    /// The collection has a member.
    /// <see href="https://w3id.org/tree#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// The URL to follow when this Node cannot be pruned
    /// <see href="https://w3id.org/tree#node"></see></summary>
    let node = _prefix "node"
    /// <summary>
    /// A property path, as defined by shacl, that indicates what resource the tree:value affects.
    /// <see href="https://w3id.org/tree#path"></see></summary>
    let path = _prefix "path"
    /// <summary>
    /// Links a node with another through a Relation class
    /// <see href="https://w3id.org/tree#relation"></see></summary>
    let relation = _prefix "relation"
    /// <summary>
    /// Total number of items of this node and its children
    /// <see href="https://w3id.org/tree#remainingItems"></see></summary>
    let remainingItems = _prefix "remainingItems"
    /// <summary>
    /// The Node can be searched for child nodes.
    /// <see href="https://w3id.org/tree#search"></see></summary>
    let search = _prefix "search"
    /// <summary>
    /// The SHACL shape the members of the collection adhere to.
    /// <see href="https://w3id.org/tree#shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    /// Will search for elements starting from a certain timestamp
    /// <see href="https://w3id.org/tree#timeQuery"></see></summary>
    let timeQuery = _prefix "timeQuery"
    /// <summary>
    /// The value the node linked in the node relation is compared to
    /// <see href="https://w3id.org/tree#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Links the collection to a `tree:Node` from which all other members can be found.
    /// <see href="https://w3id.org/tree#view"></see></summary>
    let view = _prefix "view"
    /// <summary>
    /// Links together a tree:Node with its description of this TREE structure
    /// <see href="https://w3id.org/tree#viewDescription"></see></summary>
    let viewDescription = _prefix "viewDescription"
    /// <summary>
    /// The zoom level of the tile cfr. OSM convention
    /// <see href="https://w3id.org/tree#zoom"></see></summary>
    let zoom = _prefix "zoom"
