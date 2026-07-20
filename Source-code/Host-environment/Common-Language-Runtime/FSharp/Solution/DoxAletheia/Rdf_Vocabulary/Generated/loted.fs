namespace http.loted.eu.ontology.hash

open DoxAletheia

module loted =
    let _namespace_name = "http://loted.eu/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
