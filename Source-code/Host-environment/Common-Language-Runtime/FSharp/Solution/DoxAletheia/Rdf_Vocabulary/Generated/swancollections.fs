namespace http.purl.org.swan._2._0.collections.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swancollections =
    let _namespace_iri = Namespace_Iri swancollections |> NamespaceIRI
    /// <summary>
    ///   <para>swan:collections/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Collections v. 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/">http://purl.org/swan/2.0/collections/</seealso>
    let _prefix_iri = Prefixed_Name(swancollections, "") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/Bag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bag - Collection that can have a number of copies of each object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) Bag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/Bag">http://purl.org/swan/2.0/collections/Bag</seealso>
    let Bag = Prefixed_Name(swancollections, "Bag") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection - A group of objects that can be considered as a whole."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/Collection">http://purl.org/swan/2.0/collections/Collection</seealso>
    let Collection = Prefixed_Name(swancollections, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Item - Element belonging to a Bag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/Item">http://purl.org/swan/2.0/collections/Item</seealso>
    let Item = Prefixed_Name(swancollections, "Item") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List - An ordered array of items, that can be present in multiple copies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/List">http://purl.org/swan/2.0/collections/List</seealso>
    let List = Prefixed_Name(swancollections, "List") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/ListItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ListItem - Element belonging to a list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) ListItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/ListItem">http://purl.org/swan/2.0/collections/ListItem</seealso>
    let ListItem = Prefixed_Name(swancollections, "ListItem") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Set - A collection that cannot contain duplicate elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(collections) Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/Set">http://purl.org/swan/2.0/collections/Set</seealso>
    let Set = Prefixed_Name(swancollections, "Set") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"element - The link to the members of a Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/element">http://purl.org/swan/2.0/collections/element</seealso>
    let element = Prefixed_Name(swancollections, "element") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/firstItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/firstItem">http://purl.org/swan/2.0/collections/firstItem</seealso>
    let firstItem = Prefixed_Name(swancollections, "firstItem") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/followedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"followedBy - The link to the first item of the list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/followedBy">http://purl.org/swan/2.0/collections/followedBy</seealso>
    let followedBy = Prefixed_Name(swancollections, "followedBy") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"item - The link to every item of the Bag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/item">http://purl.org/swan/2.0/collections/item</seealso>
    let item = Prefixed_Name(swancollections, "item") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/itemContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"itemContent - The link to the actual resource to which the item refers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/itemContent">http://purl.org/swan/2.0/collections/itemContent</seealso>
    let itemContent = Prefixed_Name(swancollections, "itemContent") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/lastItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"lastItem - The link to the first item of the list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/lastItem">http://purl.org/swan/2.0/collections/lastItem</seealso>
    let lastItem = Prefixed_Name(swancollections, "lastItem") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/nextItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"nextItem - The link to the next item in a list (ordered collection)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/nextItem">http://purl.org/swan/2.0/collections/nextItem</seealso>
    let nextItem = Prefixed_Name(swancollections, "nextItem") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/preceededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"preceededBy - The link to the previous item in a list (ordered collection)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/preceededBy">http://purl.org/swan/2.0/collections/preceededBy</seealso>
    let preceededBy = Prefixed_Name(swancollections, "preceededBy") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/previousItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"previousItem - The link to the previous item in a list (ordered collection)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/previousItem">http://purl.org/swan/2.0/collections/previousItem</seealso>
    let previousItem = Prefixed_Name(swancollections, "previousItem") |> PrefixedName
    /// <summary>
    ///   <para>swan:collections/size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"size - The number of item belonging to a collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/swan/2.0/collections/size">http://purl.org/swan/2.0/collections/size</seealso>
    let size = Prefixed_Name(swancollections, "size") |> PrefixedName
