namespace https.w3id.org.IIoT.hash

open DoxAletheia

module IIoT =
    let _namespace_name = "https://w3id.org/IIoT#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
