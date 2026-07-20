namespace http.ontology.eil.utoronto.ca.GCI.Foundation.GCI_Foundation.owl.hash

open DoxAletheia

module gci =
    let _namespace_name =
        "http://ontology.eil.utoronto.ca/GCI/Foundation/GCI-Foundation.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
