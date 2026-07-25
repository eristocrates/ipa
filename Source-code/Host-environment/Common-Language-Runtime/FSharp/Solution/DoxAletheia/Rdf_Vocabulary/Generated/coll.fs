namespace http.purl.org.co.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coll =
    let _namespace_iri = Namespace_Iri coll |> NamespaceIRI
    /// <summary>
    ///   <para>coll:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A number identifying the position, starting from 1, of a particular list item within a list.</para>
    /// labels<para>has index</para></remarks>
    /// <seealso href="http://purl.org/co/index">http://purl.org/co/index</seealso>
    let index = Prefixed_Name(coll, "index") |> PrefixedName
    /// <summary>
    ///   <para>coll:elementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to a collection in which the object is member.</para>
    /// labels<para>is element of</para></remarks>
    /// <seealso href="http://purl.org/co/elementOf">http://purl.org/co/elementOf</seealso>
    let elementOf = Prefixed_Name(coll, "elementOf") |> PrefixedName
    /// <summary>
    ///   <para>coll:Bag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection that can have a number of copies of each object</para>
    /// labels<para>bag</para></remarks>
    /// <seealso href="http://purl.org/co/Bag">http://purl.org/co/Bag</seealso>
    let Bag = Prefixed_Name(coll, "Bag") |> PrefixedName
    /// <summary>
    ///   <para>coll:itemContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the actual resource to which the item refers.</para>
    /// labels<para>has item content</para></remarks>
    /// <seealso href="http://purl.org/co/itemContent">http://purl.org/co/itemContent</seealso>
    let itemContent = Prefixed_Name(coll, "itemContent") |> PrefixedName
    /// <summary>
    ///   <para>coll:previousItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the previous item in a list.</para>
    /// labels<para>has previous item</para></remarks>
    /// <seealso href="http://purl.org/co/previousItem">http://purl.org/co/previousItem</seealso>
    let previousItem = Prefixed_Name(coll, "previousItem") |> PrefixedName
    /// <summary>
    ///   <para>coll:nextItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The link to the next item in a list.</para>
    /// labels<para>has next item</para></remarks>
    /// <seealso href="http://purl.org/co/nextItem">http://purl.org/co/nextItem</seealso>
    let nextItem = Prefixed_Name(coll, "nextItem") |> PrefixedName
    /// <summary>
    ///   <para>coll:firstItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The link to the first item of the list.</para>
    /// labels<para>has first item</para></remarks>
    /// <seealso href="http://purl.org/co/firstItem">http://purl.org/co/firstItem</seealso>
    let firstItem = Prefixed_Name(coll, "firstItem") |> PrefixedName
    /// <summary>
    ///   <para>coll:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element belonging to a bag</para>
    /// labels<para>item</para></remarks>
    /// <seealso href="http://purl.org/co/Item">http://purl.org/co/Item</seealso>
    let Item = Prefixed_Name(coll, "Item") |> PrefixedName
    /// <summary>
    ///   <para>coll:ListItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>element belonging to a list</para>
    /// labels<para>list item</para></remarks>
    /// <seealso href="http://purl.org/co/ListItem">http://purl.org/co/ListItem</seealso>
    let ListItem = Prefixed_Name(coll, "ListItem") |> PrefixedName
    /// <summary>
    ///   <para>coll:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to every item of the bag</para>
    /// labels<para>has item</para></remarks>
    /// <seealso href="http://purl.org/co/item">http://purl.org/co/item</seealso>
    let item = Prefixed_Name(coll, "item") |> PrefixedName
    /// <summary>
    ///   <para>coll:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of objects that can be considered as a whole.</para>
    /// labels<para>collection</para></remarks>
    /// <seealso href="http://purl.org/co/Collection">http://purl.org/co/Collection</seealso>
    let Collection = Prefixed_Name(coll, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>coll:Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection that cannot contain duplicate elements.</para>
    /// labels<para>set</para></remarks>
    /// <seealso href="http://purl.org/co/Set">http://purl.org/co/Set</seealso>
    let Set = Prefixed_Name(coll, "Set") |> PrefixedName
    /// <summary>
    ///   <para>coll:element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the members of a collection</para>
    /// labels<para>has element</para></remarks>
    /// <seealso href="http://purl.org/co/element">http://purl.org/co/element</seealso>
    let element = Prefixed_Name(coll, "element") |> PrefixedName
    /// <summary>
    ///   <para>coll:precededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the preceding item in a list.</para>
    /// labels<para>is preceded by</para></remarks>
    /// <seealso href="http://purl.org/co/precededBy">http://purl.org/co/precededBy</seealso>
    let precededBy = Prefixed_Name(coll, "precededBy") |> PrefixedName
    /// <summary>
    ///   <para>coll:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered array of items, that can be present in multiple copies</para>
    /// labels<para>list</para></remarks>
    /// <seealso href="http://purl.org/co/List">http://purl.org/co/List</seealso>
    let List = Prefixed_Name(coll, "List") |> PrefixedName
    /// <summary>
    ///   <para>coll:followedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the following item in a list.</para>
    /// labels<para>is followed by</para></remarks>
    /// <seealso href="http://purl.org/co/followedBy">http://purl.org/co/followedBy</seealso>
    let followedBy = Prefixed_Name(coll, "followedBy") |> PrefixedName
    /// <summary>
    ///   <para>coll:lastItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the last item of the list.</para>
    /// labels<para>has last item</para></remarks>
    /// <seealso href="http://purl.org/co/lastItem">http://purl.org/co/lastItem</seealso>
    let lastItem = Prefixed_Name(coll, "lastItem") |> PrefixedName
    /// <summary>
    ///   <para>coll:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of item belonging to a collection.</para>
    /// labels<para>has size</para></remarks>
    /// <seealso href="http://purl.org/co/size">http://purl.org/co/size</seealso>
    let size = Prefixed_Name(coll, "size") |> PrefixedName
    /// <summary>
    ///   <para>coll:itemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to a bag in which the item is member.</para>
    /// labels<para>is item of</para></remarks>
    /// <seealso href="http://purl.org/co/itemOf">http://purl.org/co/itemOf</seealso>
    let itemOf = Prefixed_Name(coll, "itemOf") |> PrefixedName
    /// <summary>
    ///   <para>coll:firstItemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to a list in which the item is first item.</para>
    /// labels<para>is first item of</para></remarks>
    /// <seealso href="http://purl.org/co/firstItemOf">http://purl.org/co/firstItemOf</seealso>
    let firstItemOf = Prefixed_Name(coll, "firstItemOf") |> PrefixedName
    /// <summary>
    ///   <para>coll:itemContentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to the item that refers to the resource.</para>
    /// labels<para>is item content of</para></remarks>
    /// <seealso href="http://purl.org/co/itemContentOf">http://purl.org/co/itemContentOf</seealso>
    let itemContentOf = Prefixed_Name(coll, "itemContentOf") |> PrefixedName
    /// <summary>
    ///   <para>coll:lastItemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The link to a list in which the item is last item.</para>
    /// labels<para>is last item of</para></remarks>
    /// <seealso href="http://purl.org/co/lastItemOf">http://purl.org/co/lastItemOf</seealso>
    let lastItemOf = Prefixed_Name(coll, "lastItemOf") |> PrefixedName
