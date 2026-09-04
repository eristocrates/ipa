#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tree =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/tree#" "tree"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Collection</para>
    ///   <para>rdfs:comment : A tree:Collection is a collection containing members. The members may be spread across multiple tree:Nodes.</para>
    ///   <a href="https://w3id.org/tree#Collection">tree:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Conditional Import</para>
    ///   <para>rdfs:comment : Import a page when the tree:path is interesting for the client</para>
    ///   <a href="https://w3id.org/tree#ConditionalImport">tree:ConditionalImport</a>
    /// </summary>
    let ConditionalImport = _prefixId.prefix "ConditionalImport"
    /// <summary>
    ///   <para>rdfs:label : Equal To Relation</para>
    ///   <a href="https://w3id.org/tree#EqualToRelation">tree:EqualToRelation</a>
    /// </summary>
    let EqualToRelation = _prefixId.prefix "EqualToRelation"
    /// <summary>
    ///   <para>rdfs:label : Geospatially Contains Relation</para>
    ///   <para>rdfs:comment : All further members are geospatially contained within the WKT string of the tree:value.</para>
    ///   <a href="https://w3id.org/tree#GeospatiallyContainsRelation">tree:GeospatiallyContainsRelation</a>
    /// </summary>
    let GeospatiallyContainsRelation = _prefixId.prefix "GeospatiallyContainsRelation"
    /// <summary>
    ///   <para>rdfs:label : Greater than or equal to relation</para>
    ///   <para>rdfs:comment : All members of this related node are greater than or equal to the value</para>
    ///   <a href="https://w3id.org/tree#GreaterThanOrEqualToRelation">tree:GreaterThanOrEqualToRelation</a>
    /// </summary>
    let GreaterThanOrEqualToRelation = _prefixId.prefix "GreaterThanOrEqualToRelation"
    /// <summary>
    ///   <para>rdfs:label : Greater Than Relation</para>
    ///   <para>rdfs:comment : All members of this related node are greater than the value</para>
    ///   <a href="https://w3id.org/tree#GreaterThanRelation">tree:GreaterThanRelation</a>
    /// </summary>
    let GreaterThanRelation = _prefixId.prefix "GreaterThanRelation"
    /// <summary>
    ///   <para>rdfs:label : In Between Relation</para>
    ///   <para>rdfs:comment : For comparing intervals: all further members are in-between the given interval</para>
    ///   <a href="https://w3id.org/tree#InBetweenRelation">tree:InBetweenRelation</a>
    /// </summary>
    let InBetweenRelation = _prefixId.prefix "InBetweenRelation"
    /// <summary>
    ///   <para>rdfs:label : Less than or equal to Relation</para>
    ///   <a href="https://w3id.org/tree#LessThanOrEqualToRelation">tree:LessThanOrEqualToRelation</a>
    /// </summary>
    let LessThanOrEqualToRelation = _prefixId.prefix "LessThanOrEqualToRelation"
    /// <summary>
    ///   <para>rdfs:label : Less Than Relation</para>
    ///   <a href="https://w3id.org/tree#LessThanRelation">tree:LessThanRelation</a>
    /// </summary>
    let LessThanRelation = _prefixId.prefix "LessThanRelation"
    /// <summary>
    ///   <para>rdfs:label : Node</para>
    ///   <para>rdfs:comment : A tree:Node is a node that may contain relations to other nodes.</para>
    ///   <a href="https://w3id.org/tree#Node">tree:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : Prefix Relation</para>
    ///   <para>rdfs:comment : All members of this related node start with this prefix</para>
    ///   <a href="https://w3id.org/tree#PrefixRelation">tree:PrefixRelation</a>
    /// </summary>
    let PrefixRelation = _prefixId.prefix "PrefixRelation"
    /// <summary>
    ///   <para>rdfs:label : Relation</para>
    ///   <para>rdfs:comment : A class describing the relation between two nodes</para>
    ///   <a href="https://w3id.org/tree#Relation">tree:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Substring Relation</para>
    ///   <para>rdfs:comment : All members of this related node contain this substring</para>
    ///   <a href="https://w3id.org/tree#SubstringRelation">tree:SubstringRelation</a>
    /// </summary>
    let SubstringRelation = _prefixId.prefix "SubstringRelation"
    /// <summary>
    ///   <para>rdfs:label : Suffix Relation</para>
    ///   <para>rdfs:comment : All members of this related node end with this suffix</para>
    ///   <a href="https://w3id.org/tree#SuffixRelation">tree:SuffixRelation</a>
    /// </summary>
    let SuffixRelation = _prefixId.prefix "SuffixRelation"
    /// <summary>
    ///   <para>rdfs:label : View Description</para>
    ///   <para>rdfs:comment : Describes a specific TREE structure on top of the tree:Collection</para>
    ///   <a href="https://w3id.org/tree#ViewDescription">tree:ViewDescription</a>
    /// </summary>
    let ViewDescription = _prefixId.prefix "ViewDescription"
    /// <summary>
    ///   <para>rdfs:label : Import conditionally</para>
    ///   <para>rdfs:comment : Imports a file in order being able to evaluate a tree:path correctly</para>
    ///   <a href="https://w3id.org/tree#conditionalImport">tree:conditionalImport</a>
    /// </summary>
    let conditionalImport = _prefixId.prefix "conditionalImport"
    /// <summary>
    ///   <para>rdfs:label : Import</para>
    ///   <para>rdfs:comment : Imports a file in order being able to evaluate a tree:path correctly or comply fully to the tree:shape defined in the Collection</para>
    ///   <a href="https://w3id.org/tree#import">tree:import</a>
    /// </summary>
    let import = _prefixId.prefix "import"
    /// <summary>
    ///   <para>rdfs:label : The Y tile number</para>
    ///   <para>rdfs:comment : The Y tile number from latitude cfr. OSM convention</para>
    ///   <a href="https://w3id.org/tree#latitudeTile">tree:latitudeTile</a>
    /// </summary>
    let latitudeTile = _prefixId.prefix "latitudeTile"
    /// <summary>
    ///   <para>rdfs:label : The X tile number</para>
    ///   <para>rdfs:comment : The X tile number from longitude cfr. OSM convention</para>
    ///   <a href="https://w3id.org/tree#longitudeTile">tree:longitudeTile</a>
    /// </summary>
    let longitudeTile = _prefixId.prefix "longitudeTile"
    /// <summary>
    ///   <para>rdfs:label : Member</para>
    ///   <para>rdfs:comment : The collection has a member.</para>
    ///   <a href="https://w3id.org/tree#member">tree:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : Has node</para>
    ///   <para>rdfs:comment : The URL to follow when this Node cannot be pruned</para>
    ///   <a href="https://w3id.org/tree#node">tree:node</a>
    /// </summary>
    let node = _prefixId.prefix "node"
    /// <summary>
    ///   <para>rdfs:label : Path</para>
    ///   <para>rdfs:comment : A property path, as defined by shacl, that indicates what resource the tree:value affects.</para>
    ///   <a href="https://w3id.org/tree#path">tree:path</a>
    /// </summary>
    let path = _prefixId.prefix "path"
    /// <summary>
    ///   <para>rdfs:label : Relation</para>
    ///   <para>rdfs:comment : Links a node with another through a Relation class</para>
    ///   <a href="https://w3id.org/tree#relation">tree:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : Remaining Items</para>
    ///   <para>rdfs:comment : Total number of items of this node and its children</para>
    ///   <a href="https://w3id.org/tree#remainingItems">tree:remainingItems</a>
    /// </summary>
    let remainingItems = _prefixId.prefix "remainingItems"
    /// <summary>
    ///   <para>rdfs:label : Search</para>
    ///   <para>rdfs:comment : The Node can be searched for child nodes.</para>
    ///   <a href="https://w3id.org/tree#search">tree:search</a>
    /// </summary>
    let search = _prefixId.prefix "search"
    /// <summary>
    ///   <para>rdfs:label : Shape</para>
    ///   <para>rdfs:comment : The SHACL shape the members of the collection adhere to.</para>
    ///   <a href="https://w3id.org/tree#shape">tree:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>rdfs:label : Time Query</para>
    ///   <para>rdfs:comment : Will search for elements starting from a certain timestamp</para>
    ///   <a href="https://w3id.org/tree#timeQuery">tree:timeQuery</a>
    /// </summary>
    let timeQuery = _prefixId.prefix "timeQuery"
    /// <summary>
    ///   <para>rdfs:label : Value</para>
    ///   <para>rdfs:comment : The value the node linked in the node relation is compared to</para>
    ///   <a href="https://w3id.org/tree#value">tree:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : View</para>
    ///   <para>rdfs:comment : Links the collection to a `tree:Node` from which all other members can be found.</para>
    ///   <a href="https://w3id.org/tree#view">tree:view</a>
    /// </summary>
    let view = _prefixId.prefix "view"
    /// <summary>
    ///   <para>rdfs:label : View Description^^xsd:string</para>
    ///   <para>rdfs:comment : Links together a tree:Node with its description of this TREE structure</para>
    ///   <a href="https://w3id.org/tree#viewDescription">tree:viewDescription</a>
    /// </summary>
    let viewDescription = _prefixId.prefix "viewDescription"
    /// <summary>
    ///   <para>rdfs:label : Zoom level</para>
    ///   <para>rdfs:comment : The zoom level of the tile cfr. OSM convention</para>
    ///   <a href="https://w3id.org/tree#zoom">tree:zoom</a>
    /// </summary>
    let zoom = _prefixId.prefix "zoom"
