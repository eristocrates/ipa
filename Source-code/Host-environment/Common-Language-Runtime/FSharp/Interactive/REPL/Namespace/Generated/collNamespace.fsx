#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module coll =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/co/" "coll"
    /// <summary>
    ///   <para>rdfs:comment : Collection that can have a number of copies of each object</para>
    ///   <para>rdfs:label : bag</para>
    ///   <a href="http://purl.org/co/Bag">coll:Bag</a>
    /// </summary>
    let Bag = _prefixId.prefix "Bag"
    /// <summary>
    ///   <para>rdfs:comment : A group of objects that can be considered as a whole.</para>
    ///   <para>rdfs:label : collection</para>
    ///   <a href="http://purl.org/co/Collection">coll:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : Element belonging to a bag</para>
    ///   <para>rdfs:label : item</para>
    ///   <a href="http://purl.org/co/Item">coll:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:comment : An ordered array of items, that can be present in multiple copies</para>
    ///   <para>rdfs:label : list</para>
    ///   <a href="http://purl.org/co/List">coll:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:comment : element belonging to a list</para>
    ///   <para>rdfs:label : list item</para>
    ///   <a href="http://purl.org/co/ListItem">coll:ListItem</a>
    /// </summary>
    let ListItem = _prefixId.prefix "ListItem"
    /// <summary>
    ///   <para>rdfs:comment : A collection that cannot contain duplicate elements.</para>
    ///   <para>rdfs:label : set</para>
    ///   <a href="http://purl.org/co/Set">coll:Set</a>
    /// </summary>
    let Set = _prefixId.prefix "Set"
    /// <summary>
    ///   <para>rdfs:comment : The link to the members of a collection</para>
    ///   <para>rdfs:label : has element</para>
    ///   <a href="http://purl.org/co/element">coll:element</a>
    /// </summary>
    let element = _prefixId.prefix "element"
    /// <summary>
    ///   <para>rdfs:comment : The link to a collection in which the object is member.</para>
    ///   <para>rdfs:label : is element of</para>
    ///   <a href="http://purl.org/co/elementOf">coll:elementOf</a>
    /// </summary>
    let elementOf = _prefixId.prefix "elementOf"
    /// <summary>
    ///   <para>rdfs:comment : The link to the first item of the list.</para>
    ///   <para>rdfs:label : has first item</para>
    ///   <a href="http://purl.org/co/firstItem">coll:firstItem</a>
    /// </summary>
    let firstItem = _prefixId.prefix "firstItem"
    /// <summary>
    ///   <para>rdfs:comment : The link to a list in which the item is first item.</para>
    ///   <para>rdfs:label : is first item of</para>
    ///   <a href="http://purl.org/co/firstItemOf">coll:firstItemOf</a>
    /// </summary>
    let firstItemOf = _prefixId.prefix "firstItemOf"
    /// <summary>
    ///   <para>rdfs:comment : The link to the following item in a list.</para>
    ///   <para>dce:description : Given the list (I[1], I[2], ... , I[i-1], I[i], I[i+1], ... , I[n-1], I[n]), the item I[i] is followed by I[i+1], ... , I[n-1] and I[n].</para>
    ///   <para>rdfs:label : is followed by</para>
    ///   <a href="http://purl.org/co/followedBy">coll:followedBy</a>
    /// </summary>
    let followedBy = _prefixId.prefix "followedBy"
    /// <summary>
    ///   <para>rdfs:comment : A number identifying the position, starting from 1, of a particular list item within a list.</para>
    ///   <para>rdfs:label : has index</para>
    ///   <a href="http://purl.org/co/index">coll:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>rdfs:comment : The link to every item of the bag</para>
    ///   <para>rdfs:label : has item</para>
    ///   <a href="http://purl.org/co/item">coll:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>rdfs:comment : The link to the actual resource to which the item refers.</para>
    ///   <para>rdfs:label : has item content</para>
    ///   <a href="http://purl.org/co/itemContent">coll:itemContent</a>
    /// </summary>
    let itemContent = _prefixId.prefix "itemContent"
    /// <summary>
    ///   <para>rdfs:comment : The link to the item that refers to the resource.</para>
    ///   <para>rdfs:label : is item content of</para>
    ///   <a href="http://purl.org/co/itemContentOf">coll:itemContentOf</a>
    /// </summary>
    let itemContentOf = _prefixId.prefix "itemContentOf"
    /// <summary>
    ///   <para>rdfs:comment : The link to a bag in which the item is member.</para>
    ///   <para>rdfs:label : is item of</para>
    ///   <a href="http://purl.org/co/itemOf">coll:itemOf</a>
    /// </summary>
    let itemOf = _prefixId.prefix "itemOf"
    /// <summary>
    ///   <para>rdfs:comment : The link to the last item of the list.</para>
    ///   <para>rdfs:label : has last item</para>
    ///   <a href="http://purl.org/co/lastItem">coll:lastItem</a>
    /// </summary>
    let lastItem = _prefixId.prefix "lastItem"
    /// <summary>
    ///   <para>rdfs:comment : The link to a list in which the item is last item.</para>
    ///   <para>rdfs:label : is last item of</para>
    ///   <a href="http://purl.org/co/lastItemOf">coll:lastItemOf</a>
    /// </summary>
    let lastItemOf = _prefixId.prefix "lastItemOf"
    /// <summary>
    ///   <para>rdfs:comment : The link to the next item in a list.</para>
    ///   <para>dce:description : Given the list (I[1], I[2], ... , I[i-1], I[i], I[i+1], ... , I[n-1], I[n]), the next item of I[i] is I[i+1].</para>
    ///   <para>rdfs:label : has next item</para>
    ///   <a href="http://purl.org/co/nextItem">coll:nextItem</a>
    /// </summary>
    let nextItem = _prefixId.prefix "nextItem"
    /// <summary>
    ///   <para>rdfs:comment : The link to the preceding item in a list.</para>
    ///   <para>dce:description : Given the list (I[1], I[2], ... , I[i-1], I[i], I[i+1], ... , I[n-1], I[n]), the item I[i] is preceded by I[i-1], ... , I[2] and I[1].</para>
    ///   <para>rdfs:label : is preceded by</para>
    ///   <a href="http://purl.org/co/precededBy">coll:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    /// <summary>
    ///   <para>rdfs:comment : The link to the previous item in a list.</para>
    ///   <para>dce:description : Given the list (I[1], I[2], ... , I[i-1], I[i], I[i+1], ... , I[n-1], I[n]), the previous item of I[i] is I[i-1].</para>
    ///   <para>rdfs:label : has previous item</para>
    ///   <a href="http://purl.org/co/previousItem">coll:previousItem</a>
    /// </summary>
    let previousItem = _prefixId.prefix "previousItem"
    /// <summary>
    ///   <para>rdfs:comment : The number of item belonging to a collection.</para>
    ///   <para>dce:description : CO defines the size of a collection as the sum of the number of times entities that are part of the collection appear in it. This means that co:size considers how much each entity is involved by a particular collection, i.e.:
    /// - the size of the set {a, b, c} is three
    /// - the size of the bag [a, a, b, b, b, c] is five
    /// - the size of the list (a, b, c, b, a, b, c, c) is seven</para>
    ///   <para>rdfs:label : has size</para>
    ///   <a href="http://purl.org/co/size">coll:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
