namespace http.purl.org.swan._2._0.collections.slash

open DoxAletheia.Rdf_Vocabulary

module swancol =
    let _namespace_name = "http://purl.org/swan/2.0/collections/"
    /// <summary>
    /// Bag - Collection that can have a number of copies of each object
    /// <see href="http://purl.org/swan/2.0/collections/Bag"></see></summary>
    let Bag = Namespaced_IRI.parse _namespace_name "Bag" |> NamespacedName
    /// <summary>
    /// Collection - A group of objects that can be considered as a whole.
    /// <see href="http://purl.org/swan/2.0/collections/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// Set - A collection that cannot contain duplicate elements.
    /// <see href="http://purl.org/swan/2.0/collections/Set"></see></summary>
    let Set = Namespaced_IRI.parse _namespace_name "Set" |> NamespacedName
    /// <summary>
    /// Item - Element belonging to a Bag
    /// <see href="http://purl.org/swan/2.0/collections/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// List - An ordered array of items, that can be present in multiple copies
    /// <see href="http://purl.org/swan/2.0/collections/List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName
    /// <summary>
    /// lastItem - The link to the first item of the list
    /// <see href="http://purl.org/swan/2.0/collections/lastItem"></see></summary>
    let lastItem = Namespaced_IRI.parse _namespace_name "lastItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/collections/firstItem"></see>
    /// </summary>
    let firstItem = Namespaced_IRI.parse _namespace_name "firstItem" |> NamespacedName
    /// <summary>
    /// ListItem - Element belonging to a list
    /// <see href="http://purl.org/swan/2.0/collections/ListItem"></see></summary>
    let ListItem = Namespaced_IRI.parse _namespace_name "ListItem" |> NamespacedName
    /// <summary>
    /// element - The link to the members of a Set
    /// <see href="http://purl.org/swan/2.0/collections/element"></see></summary>
    let element = Namespaced_IRI.parse _namespace_name "element" |> NamespacedName
    /// <summary>
    /// item - The link to every item of the Bag
    /// <see href="http://purl.org/swan/2.0/collections/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// followedBy - The link to the first item of the list
    /// <see href="http://purl.org/swan/2.0/collections/followedBy"></see></summary>
    let followedBy = Namespaced_IRI.parse _namespace_name "followedBy" |> NamespacedName

    /// <summary>
    /// itemContent - The link to the actual resource to which the item refers.
    /// <see href="http://purl.org/swan/2.0/collections/itemContent"></see></summary>
    let itemContent =
        Namespaced_IRI.parse _namespace_name "itemContent" |> NamespacedName

    /// <summary>
    /// nextItem - The link to the next item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/nextItem"></see></summary>
    let nextItem = Namespaced_IRI.parse _namespace_name "nextItem" |> NamespacedName

    /// <summary>
    /// preceededBy - The link to the previous item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/preceededBy"></see></summary>
    let preceededBy =
        Namespaced_IRI.parse _namespace_name "preceededBy" |> NamespacedName

    /// <summary>
    /// previousItem - The link to the previous item in a list (ordered collection)
    /// <see href="http://purl.org/swan/2.0/collections/previousItem"></see></summary>
    let previousItem =
        Namespaced_IRI.parse _namespace_name "previousItem" |> NamespacedName

    /// <summary>
    /// size - The number of item belonging to a collection
    /// <see href="http://purl.org/swan/2.0/collections/size"></see></summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
