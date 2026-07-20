namespace http.purl.org.swan._2._0.collections.slash

open DoxAletheia

module swancol =
    let _namespace_name = "http://purl.org/swan/2.0/collections/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Bag - Collection that can have a number of copies of each object
    /// <see href="http://purl.org/swan/2.0/collections/Bag"></see></summary>
    let Bag = _prefix "Bag"
    /// <summary>
    /// Collection - A group of objects that can be considered as a whole.
    /// <see href="http://purl.org/swan/2.0/collections/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// Set - A collection that cannot contain duplicate elements.
    /// <see href="http://purl.org/swan/2.0/collections/Set"></see></summary>
    let Set = _prefix "Set"
    /// <summary>
    /// Item - Element belonging to a Bag
    /// <see href="http://purl.org/swan/2.0/collections/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// List - An ordered array of items, that can be present in multiple copies
    /// <see href="http://purl.org/swan/2.0/collections/List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// lastItem - The link to the first item of the list
    /// <see href="http://purl.org/swan/2.0/collections/lastItem"></see></summary>
    let lastItem = _prefix "lastItem"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/collections/firstItem"></see>
    /// </summary>
    let firstItem = _prefix "firstItem"
    /// <summary>
    /// ListItem - Element belonging to a list
    /// <see href="http://purl.org/swan/2.0/collections/ListItem"></see></summary>
    let ListItem = _prefix "ListItem"
    /// <summary>
    /// element - The link to the members of a Set
    /// <see href="http://purl.org/swan/2.0/collections/element"></see></summary>
    let element = _prefix "element"
    /// <summary>
    /// item - The link to every item of the Bag
    /// <see href="http://purl.org/swan/2.0/collections/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// followedBy - The link to the first item of the list
    /// <see href="http://purl.org/swan/2.0/collections/followedBy"></see></summary>
    let followedBy = _prefix "followedBy"
    /// <summary>
    /// itemContent - The link to the actual resource to which the item refers.
    /// <see href="http://purl.org/swan/2.0/collections/itemContent"></see></summary>
    let itemContent = _prefix "itemContent"
    /// <summary>
    /// nextItem - The link to the next item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/nextItem"></see></summary>
    let nextItem = _prefix "nextItem"
    /// <summary>
    /// preceededBy - The link to the previous item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/preceededBy"></see></summary>
    let preceededBy = _prefix "preceededBy"
    /// <summary>
    /// previousItem - The link to the previous item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/previousItem"></see></summary>
    let previousItem = _prefix "previousItem"
    /// <summary>
    /// size - The number of item belonging to a collection
    /// <see href="http://purl.org/swan/2.0/collections/size"></see></summary>
    let size = _prefix "size"
