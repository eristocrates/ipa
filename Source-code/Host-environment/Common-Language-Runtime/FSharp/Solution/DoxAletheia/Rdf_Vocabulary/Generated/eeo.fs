namespace https.w3id.org.eeo.hash

open DoxAletheia

module eeo =
    let _namespace_name = "https://w3id.org/eeo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
