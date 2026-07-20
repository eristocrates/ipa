namespace http.purl.org.co.slash

open DoxAletheia

module coll =
    let _namespace_name = "http://purl.org/co/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A number identifying the position, starting from 1, of a particular list item within a list.
    /// <see href="http://purl.org/co/index"></see></summary>
    let index = _prefix "index"
    /// <summary>
    /// The link to the following item in a list.
    /// <see href="http://purl.org/co/followedBy"></see></summary>
    let followedBy = _prefix "followedBy"
    /// <summary>
    /// The link to the last item of the list.
    /// <see href="http://purl.org/co/lastItem"></see></summary>
    let lastItem = _prefix "lastItem"
    /// <summary>
    /// The number of item belonging to a collection.
    /// <see href="http://purl.org/co/size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    /// The link to a bag in which the item is member.
    /// <see href="http://purl.org/co/itemOf"></see></summary>
    let itemOf = _prefix "itemOf"
    /// <summary>
    /// The link to the next item in a list.
    /// <see href="http://purl.org/co/nextItem"></see></summary>
    let nextItem = _prefix "nextItem"
    /// <summary>
    /// The link to the preceding item in a list.
    /// <see href="http://purl.org/co/precededBy"></see></summary>
    let precededBy = _prefix "precededBy"
    /// <summary>
    /// The link to the first item of the list.
    /// <see href="http://purl.org/co/firstItem"></see></summary>
    let firstItem = _prefix "firstItem"
    /// <summary>
    /// An ordered array of items, that can be present in multiple copies
    /// <see href="http://purl.org/co/List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// Element belonging to a bag
    /// <see href="http://purl.org/co/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// element belonging to a list
    /// <see href="http://purl.org/co/ListItem"></see></summary>
    let ListItem = _prefix "ListItem"
    /// <summary>
    /// The link to every item of the bag
    /// <see href="http://purl.org/co/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// Collection that can have a number of copies of each object
    /// <see href="http://purl.org/co/Bag"></see></summary>
    let Bag = _prefix "Bag"
    /// <summary>
    /// A group of objects that can be considered as a whole.
    /// <see href="http://purl.org/co/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A collection that cannot contain duplicate elements.
    /// <see href="http://purl.org/co/Set"></see></summary>
    let Set = _prefix "Set"
    /// <summary>
    /// The link to the members of a collection
    /// <see href="http://purl.org/co/element"></see></summary>
    let element = _prefix "element"
    /// <summary>
    /// The link to the actual resource to which the item refers.
    /// <see href="http://purl.org/co/itemContent"></see></summary>
    let itemContent = _prefix "itemContent"
    /// <summary>
    /// The link to a collection in which the object is member.
    /// <see href="http://purl.org/co/elementOf"></see></summary>
    let elementOf = _prefix "elementOf"
    /// <summary>
    /// The link to the previous item in a list.
    /// <see href="http://purl.org/co/previousItem"></see></summary>
    let previousItem = _prefix "previousItem"
    /// <summary>
    /// The link to a list in which the item is first item.
    /// <see href="http://purl.org/co/firstItemOf"></see></summary>
    let firstItemOf = _prefix "firstItemOf"
    /// <summary>
    /// The link to the item that refers to the resource.
    /// <see href="http://purl.org/co/itemContentOf"></see></summary>
    let itemContentOf = _prefix "itemContentOf"
    /// <summary>
    /// The link to a list in which the item is last item.
    /// <see href="http://purl.org/co/lastItemOf"></see></summary>
    let lastItemOf = _prefix "lastItemOf"
