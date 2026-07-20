namespace https.w3id.org.airo.hash

open DoxAletheia

module airo =
    let _namespace_name = "https://w3id.org/airo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
