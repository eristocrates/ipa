namespace https.w3id.org.linkml.slash

open DoxAletheia

module linkml =
    let _namespace_name = "https://w3id.org/linkml/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
