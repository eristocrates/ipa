namespace http.purl.org.ontology.olo.core.hash

open DoxAletheia.Rdf_Vocabulary

module olo =
    let _namespace_name = "http://purl.org/ontology/olo/core#"

    /// <summary>
    /// An ordered list with a given length an indexed items.
    /// <see href="http://purl.org/ontology/olo/core#OrderedList"></see></summary>
    let OrderedList =
        Namespaced_IRI.parse _namespace_name "OrderedList" |> NamespacedName

    /// <summary>
    /// The length of an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName
    /// <summary>
    /// A slot in an ordered list with a fixed index.
    /// <see href="http://purl.org/ontology/olo/core#Slot"></see></summary>
    let Slot = Namespaced_IRI.parse _namespace_name "Slot" |> NamespacedName
    /// <summary>
    /// An index of a slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    /// Associates the next slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    /// Associates the previous slot in an ordered list
    /// <see href="http://purl.org/ontology/olo/core#previous"></see></summary>
    let previous = Namespaced_IRI.parse _namespace_name "previous" |> NamespacedName

    /// <summary>
    /// An ordered list of an slot.
    /// <see href="http://purl.org/ontology/olo/core#ordered_list"></see></summary>
    let ordered_list =
        Namespaced_IRI.parse _namespace_name "ordered_list" |> NamespacedName

    /// <summary>
    /// An item of a slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// A slot in an ordered list.
    /// <see href="http://purl.org/ontology/olo/core#slot"></see></summary>
    let slot = Namespaced_IRI.parse _namespace_name "slot" |> NamespacedName
