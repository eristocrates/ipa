namespace http.purl.org.ontology.olo.core.hash

open DoxAletheia

module olo =
    let _namespace_name = "http://purl.org/ontology/olo/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An ordered list with a given length an indexed items.
    /// <see href="http://purl.org/ontology/olo/core#OrderedList"></see></summary>
    let OrderedList = _prefix "OrderedList"
    /// <summary>
    /// The length of an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// A slot in an ordered list with a fixed index.
    /// <see href="http://purl.org/ontology/olo/core#Slot"></see></summary>
    let Slot = _prefix "Slot"
    /// <summary>
    /// An index of a slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#index"></see></summary>
    let index = _prefix "index"
    /// <summary>
    /// Associates the next slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// Associates the previous slot in an ordered list
    /// <see href="http://purl.org/ontology/olo/core#previous"></see></summary>
    let previous = _prefix "previous"
    /// <summary>
    /// An ordered list of an slot.
    /// <see href="http://purl.org/ontology/olo/core#ordered_list"></see></summary>
    let ordered_list = _prefix "ordered_list"
    /// <summary>
    /// An item of a slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// A slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#slot"></see></summary>
    let slot = _prefix "slot"
