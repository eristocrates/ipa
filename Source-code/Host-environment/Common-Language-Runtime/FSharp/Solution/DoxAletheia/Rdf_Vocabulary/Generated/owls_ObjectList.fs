namespace http.www.daml.org.services.owl_s._1._2.generic.ObjectList.owl.hash

open DoxAletheia

module owls_ObjectList =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This is intended to provide an OWL-DL compatible version of rdf:List
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// The first item in the subject RDF list.
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#first"></see></summary>
    let first = _prefix "first"
    /// <summary>
    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#nil"></see></summary>
    let nil = _prefix "nil"
    /// <summary>
    /// The rest of the subject RDF list after the first item.
    /// <see href="http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#rest"></see></summary>
    let rest = _prefix "rest"
