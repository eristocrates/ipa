namespace http.d_nb.info.standards.elementset.agrelon.hash

open DoxAletheia

module agrelon =
    let _namespace_name = "http://d-nb.info/standards/elementset/agrelon#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
