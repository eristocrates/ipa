namespace http.ns.inria.fr.semed.eduprogression.hash

open DoxAletheia

module edupro =
    let _namespace_name = "http://ns.inria.fr/semed/eduprogression#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
