namespace http.www.isibang.ac._in.ns._mod.hash

open DoxAletheia

module mod_ =
    let _namespace_name = "http://www.isibang.ac.in/ns/mod#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
