namespace http.ontology.it.itsmo.v1.hash

open DoxAletheia

module itsmo =
    let _namespace_name = "http://ontology.it/itsmo/v1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
