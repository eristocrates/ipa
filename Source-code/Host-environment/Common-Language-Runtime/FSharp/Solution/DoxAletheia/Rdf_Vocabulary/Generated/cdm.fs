namespace http.purl.org.twc.ontology.cdm.owl.hash

open DoxAletheia

module cdm =
    let _namespace_name = "http://purl.org/twc/ontology/cdm.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
