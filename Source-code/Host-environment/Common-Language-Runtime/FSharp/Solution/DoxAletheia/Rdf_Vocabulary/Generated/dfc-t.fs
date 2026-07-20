namespace http._static.datafoodconsortium.org.ontologies.DFC_TechnicalOntology.owl.hash

open DoxAletheia

module dfc_t =
    let _namespace_name =
        "http://static.datafoodconsortium.org/ontologies/DFC_TechnicalOntology.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
