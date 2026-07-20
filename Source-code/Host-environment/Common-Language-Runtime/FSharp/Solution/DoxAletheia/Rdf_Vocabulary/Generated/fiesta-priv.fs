namespace http.purl.org.iot.ontology.fiesta_iot.hash

open DoxAletheia

module fiesta_priv =
    let _namespace_name = "http://purl.org/iot/ontology/fiesta-iot#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
