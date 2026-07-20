namespace http.purl.org.vocab.participation.schema.hash

open DoxAletheia

module particip =
    let _namespace_name = "http://purl.org/vocab/participation/schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
