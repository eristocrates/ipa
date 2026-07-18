namespace http.purl.org.co.slash

open DoxAletheia.Rdf_Vocabulary

module coll =
    let _namespace_name = "http://purl.org/co/"
    /// <summary>
    /// A number identifying the position, starting from 1, of a particular list item within a list.
    /// <see href="http://purl.org/co/index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    /// The link to the following item in a list.
    /// <see href="http://purl.org/co/followedBy"></see></summary>
    let followedBy = Namespaced_IRI.parse _namespace_name "followedBy" |> NamespacedName
    /// <summary>
    /// The link to the last item of the list.
    /// <see href="http://purl.org/co/lastItem"></see></summary>
    let lastItem = Namespaced_IRI.parse _namespace_name "lastItem" |> NamespacedName
    /// <summary>
    /// The number of item belonging to a collection.
    /// <see href="http://purl.org/co/size"></see></summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    /// The link to a bag in which the item is member.
    /// <see href="http://purl.org/co/itemOf"></see></summary>
    let itemOf = Namespaced_IRI.parse _namespace_name "itemOf" |> NamespacedName
    /// <summary>
    /// The link to the next item in a list.
    /// <see href="http://purl.org/co/nextItem"></see></summary>
    let nextItem = Namespaced_IRI.parse _namespace_name "nextItem" |> NamespacedName
    /// <summary>
    /// The link to the preceding item in a list.
    /// <see href="http://purl.org/co/precededBy"></see></summary>
    let precededBy = Namespaced_IRI.parse _namespace_name "precededBy" |> NamespacedName
    /// <summary>
    /// The link to the first item of the list.
    /// <see href="http://purl.org/co/firstItem"></see></summary>
    let firstItem = Namespaced_IRI.parse _namespace_name "firstItem" |> NamespacedName
    /// <summary>
    /// An ordered array of items, that can be present in multiple copies
    /// <see href="http://purl.org/co/List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName
    /// <summary>
    /// Element belonging to a bag
    /// <see href="http://purl.org/co/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// element belonging to a list
    /// <see href="http://purl.org/co/ListItem"></see></summary>
    let ListItem = Namespaced_IRI.parse _namespace_name "ListItem" |> NamespacedName
    /// <summary>
    /// The link to every item of the bag
    /// <see href="http://purl.org/co/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// Collection that can have a number of copies of each object
    /// <see href="http://purl.org/co/Bag"></see></summary>
    let Bag = Namespaced_IRI.parse _namespace_name "Bag" |> NamespacedName
    /// <summary>
    /// A group of objects that can be considered as a whole.
    /// <see href="http://purl.org/co/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A collection that cannot contain duplicate elements.
    /// <see href="http://purl.org/co/Set"></see></summary>
    let Set = Namespaced_IRI.parse _namespace_name "Set" |> NamespacedName
    /// <summary>
    /// The link to the members of a collection
    /// <see href="http://purl.org/co/element"></see></summary>
    let element = Namespaced_IRI.parse _namespace_name "element" |> NamespacedName

    /// <summary>
    /// The link to the actual resource to which the item refers.
    /// <see href="http://purl.org/co/itemContent"></see></summary>
    let itemContent =
        Namespaced_IRI.parse _namespace_name "itemContent" |> NamespacedName

    /// <summary>
    /// The link to a collection in which the object is member.
    /// <see href="http://purl.org/co/elementOf"></see></summary>
    let elementOf = Namespaced_IRI.parse _namespace_name "elementOf" |> NamespacedName

    /// <summary>
    /// The link to the previous item in a list.
    /// <see href="http://purl.org/co/previousItem"></see></summary>
    let previousItem =
        Namespaced_IRI.parse _namespace_name "previousItem" |> NamespacedName

    /// <summary>
    /// The link to a list in which the item is first item.
    /// <see href="http://purl.org/co/firstItemOf"></see></summary>
    let firstItemOf =
        Namespaced_IRI.parse _namespace_name "firstItemOf" |> NamespacedName

    /// <summary>
    /// The link to the item that refers to the resource.
    /// <see href="http://purl.org/co/itemContentOf"></see></summary>
    let itemContentOf =
        Namespaced_IRI.parse _namespace_name "itemContentOf" |> NamespacedName

    /// <summary>
    /// The link to a list in which the item is last item.
    /// <see href="http://purl.org/co/lastItemOf"></see></summary>
    let lastItemOf = Namespaced_IRI.parse _namespace_name "lastItemOf" |> NamespacedName
