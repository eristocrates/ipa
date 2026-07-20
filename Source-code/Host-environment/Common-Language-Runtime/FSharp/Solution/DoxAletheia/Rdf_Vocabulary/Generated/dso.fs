namespace http.inference_web.org._2._0.ds.owl.hash

open DoxAletheia

module dso =
    let _namespace_name = "http://inference-web.org/2.0/ds.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A template for defining typed-list. It functions like rdf:List with object members.
    /// <see href="http://inference-web.org/2.0/ds.owl#List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// The rest of the subject RDF list after the first item.
    /// <see href="http://inference-web.org/2.0/ds.owl#rest"></see></summary>
    let rest = _prefix "rest"
    /// <summary>
    /// The first item in the subject RDF list.
    /// <see href="http://inference-web.org/2.0/ds.owl#first"></see></summary>
    let first = _prefix "first"
    /// <summary>
    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    /// <see href="http://inference-web.org/2.0/ds.owl#nil"></see></summary>
    let nil = _prefix "nil"
