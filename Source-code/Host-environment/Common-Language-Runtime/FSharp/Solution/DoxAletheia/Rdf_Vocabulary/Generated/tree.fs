namespace https.w3id.org.tree.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tree =
    let _namespace_iri = Namespace_Iri tree |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:tree#</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Document</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tree#">https://w3id.org/tree#</seealso>
    let _prefix_iri = Prefixed_Name(tree, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A tree:Collection is a collection containing members. The members may be spread across multiple tree:Nodes."</para>
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="https://w3id.org/tree#Collection">https://w3id.org/tree#Collection</seealso>
    let Collection = Prefixed_Name(tree, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#ConditionalImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Import a page when the tree:path is interesting for the client"</para>
    /// labels<para>"Conditional Import"</para></remarks>
    /// <seealso href="https://w3id.org/tree#ConditionalImport">https://w3id.org/tree#ConditionalImport</seealso>
    let ConditionalImport = Prefixed_Name(tree, "ConditionalImport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#EqualToRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Equal To Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#EqualToRelation">https://w3id.org/tree#EqualToRelation</seealso>
    let EqualToRelation = Prefixed_Name(tree, "EqualToRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tree#GeospatiallyContainsRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All further members are geospatially contained within the WKT string of the tree:value."</para>
    /// labels<para>"Geospatially Contains Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#GeospatiallyContainsRelation">https://w3id.org/tree#GeospatiallyContainsRelation</seealso>
    let GeospatiallyContainsRelation =
        Prefixed_Name(tree, "GeospatiallyContainsRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tree#GreaterThanOrEqualToRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All members of this related node are greater than or equal to the value"</para>
    /// labels<para>"Greater than or equal to relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#GreaterThanOrEqualToRelation">https://w3id.org/tree#GreaterThanOrEqualToRelation</seealso>
    let GreaterThanOrEqualToRelation =
        Prefixed_Name(tree, "GreaterThanOrEqualToRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tree#GreaterThanRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All members of this related node are greater than the value"</para>
    /// labels<para>"Greater Than Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#GreaterThanRelation">https://w3id.org/tree#GreaterThanRelation</seealso>
    let GreaterThanRelation = Prefixed_Name(tree, "GreaterThanRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#InBetweenRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"For comparing intervals: all further members are in-between the given interval"</para>
    /// labels<para>"In Between Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#InBetweenRelation">https://w3id.org/tree#InBetweenRelation</seealso>
    let InBetweenRelation = Prefixed_Name(tree, "InBetweenRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tree#LessThanOrEqualToRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Less than or equal to Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#LessThanOrEqualToRelation">https://w3id.org/tree#LessThanOrEqualToRelation</seealso>
    let LessThanOrEqualToRelation =
        Prefixed_Name(tree, "LessThanOrEqualToRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tree#LessThanRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Less Than Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#LessThanRelation">https://w3id.org/tree#LessThanRelation</seealso>
    let LessThanRelation = Prefixed_Name(tree, "LessThanRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A tree:Node is a node that may contain relations to other nodes."</para>
    /// labels<para>"Node"</para></remarks>
    /// <seealso href="https://w3id.org/tree#Node">https://w3id.org/tree#Node</seealso>
    let Node = Prefixed_Name(tree, "Node") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A hypermedia specification for fragmenting collections."</para>
    /// labels<para>"TREE"</para></remarks>
    /// <seealso href="https://w3id.org/tree#Ontology">https://w3id.org/tree#Ontology</seealso>
    let Ontology = Prefixed_Name(tree, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#PrefixRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All members of this related node start with this prefix"</para>
    /// labels<para>"Prefix Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#PrefixRelation">https://w3id.org/tree#PrefixRelation</seealso>
    let PrefixRelation = Prefixed_Name(tree, "PrefixRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class describing the relation between two nodes"</para>
    /// labels<para>"Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#Relation">https://w3id.org/tree#Relation</seealso>
    let Relation = Prefixed_Name(tree, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#SubstringRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All members of this related node contain this substring"</para>
    /// labels<para>"Substring Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#SubstringRelation">https://w3id.org/tree#SubstringRelation</seealso>
    let SubstringRelation = Prefixed_Name(tree, "SubstringRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#SuffixRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All members of this related node end with this suffix"</para>
    /// labels<para>"Suffix Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#SuffixRelation">https://w3id.org/tree#SuffixRelation</seealso>
    let SuffixRelation = Prefixed_Name(tree, "SuffixRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#ViewDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes a specific TREE structure on top of the tree:Collection"</para>
    /// labels<para>"View Description"</para></remarks>
    /// <seealso href="https://w3id.org/tree#ViewDescription">https://w3id.org/tree#ViewDescription</seealso>
    let ViewDescription = Prefixed_Name(tree, "ViewDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#conditionalImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Imports a file in order being able to evaluate a tree:path correctly"</para>
    /// labels<para>"Import conditionally"</para></remarks>
    /// <seealso href="https://w3id.org/tree#conditionalImport">https://w3id.org/tree#conditionalImport</seealso>
    let conditionalImport = Prefixed_Name(tree, "conditionalImport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#import</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Imports a file in order being able to evaluate a tree:path correctly or comply fully to the tree:shape defined in the Collection"</para>
    /// labels<para>"Import"</para></remarks>
    /// <seealso href="https://w3id.org/tree#import">https://w3id.org/tree#import</seealso>
    let import = Prefixed_Name(tree, "import") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#latitudeTile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Y tile number from latitude cfr. OSM convention"</para>
    /// labels<para>"The Y tile number"</para></remarks>
    /// <seealso href="https://w3id.org/tree#latitudeTile">https://w3id.org/tree#latitudeTile</seealso>
    let latitudeTile = Prefixed_Name(tree, "latitudeTile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#longitudeTile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The X tile number from longitude cfr. OSM convention"</para>
    /// labels<para>"The X tile number"</para></remarks>
    /// <seealso href="https://w3id.org/tree#longitudeTile">https://w3id.org/tree#longitudeTile</seealso>
    let longitudeTile = Prefixed_Name(tree, "longitudeTile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The collection has a member."</para>
    /// labels<para>"Member"</para></remarks>
    /// <seealso href="https://w3id.org/tree#member">https://w3id.org/tree#member</seealso>
    let member_ = Prefixed_Name(tree, "member") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#node</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL to follow when this Node cannot be pruned"</para>
    /// labels<para>"Has node"</para></remarks>
    /// <seealso href="https://w3id.org/tree#node">https://w3id.org/tree#node</seealso>
    let node = Prefixed_Name(tree, "node") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#path</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property path, as defined by shacl, that indicates what resource the tree:value affects."</para>
    /// labels<para>"Path"</para></remarks>
    /// <seealso href="https://w3id.org/tree#path">https://w3id.org/tree#path</seealso>
    let path = Prefixed_Name(tree, "path") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a node with another through a Relation class"</para>
    /// labels<para>"Relation"</para></remarks>
    /// <seealso href="https://w3id.org/tree#relation">https://w3id.org/tree#relation</seealso>
    let relation = Prefixed_Name(tree, "relation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#remainingItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Total number of items of this node and its children"</para>
    /// labels<para>"Remaining Items"</para></remarks>
    /// <seealso href="https://w3id.org/tree#remainingItems">https://w3id.org/tree#remainingItems</seealso>
    let remainingItems = Prefixed_Name(tree, "remainingItems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#search</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Node can be searched for child nodes."</para>
    /// labels<para>"Search"</para></remarks>
    /// <seealso href="https://w3id.org/tree#search">https://w3id.org/tree#search</seealso>
    let search = Prefixed_Name(tree, "search") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The SHACL shape the members of the collection adhere to."</para>
    /// labels<para>"Shape"</para></remarks>
    /// <seealso href="https://w3id.org/tree#shape">https://w3id.org/tree#shape</seealso>
    let shape = Prefixed_Name(tree, "shape") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#timeQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Will search for elements starting from a certain timestamp"</para>
    /// labels<para>"Time Query"</para></remarks>
    /// <seealso href="https://w3id.org/tree#timeQuery">https://w3id.org/tree#timeQuery</seealso>
    let timeQuery = Prefixed_Name(tree, "timeQuery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The value the node linked in the node relation is compared to"</para>
    /// labels<para>"Value"</para></remarks>
    /// <seealso href="https://w3id.org/tree#value">https://w3id.org/tree#value</seealso>
    let value = Prefixed_Name(tree, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#view</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links the collection to a `tree:Node` from which all other members can be found."</para>
    /// labels<para>"View"</para></remarks>
    /// <seealso href="https://w3id.org/tree#view">https://w3id.org/tree#view</seealso>
    let view = Prefixed_Name(tree, "view") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#viewDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links together a tree:Node with its description of this TREE structure"</para>
    /// labels<para>"View Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tree#viewDescription">https://w3id.org/tree#viewDescription</seealso>
    let viewDescription = Prefixed_Name(tree, "viewDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tree#zoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The zoom level of the tile cfr. OSM convention"</para>
    /// labels<para>"Zoom level"</para></remarks>
    /// <seealso href="https://w3id.org/tree#zoom">https://w3id.org/tree#zoom</seealso>
    let zoom = Prefixed_Name(tree, "zoom") |> PrefixedName
