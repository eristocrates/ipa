namespace https.w3id.org.CEMontology.slash

open DoxAletheia

module cem =
    let _namespace_name = "https://w3id.org/CEMontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
