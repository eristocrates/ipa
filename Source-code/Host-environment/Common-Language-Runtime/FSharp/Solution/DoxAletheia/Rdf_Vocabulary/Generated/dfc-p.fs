namespace http._static.datafoodconsortium.org.ontologies.DFC_ProductGlossary.owl.hash

open DoxAletheia

module dfc_p =
    let _namespace_name =
        "http://static.datafoodconsortium.org/ontologies/DFC_ProductGlossary.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
