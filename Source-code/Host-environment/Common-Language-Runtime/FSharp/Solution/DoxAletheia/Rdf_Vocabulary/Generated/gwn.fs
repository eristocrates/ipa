namespace https.globalwordnet.github.io.schemas.wn.hash

open DoxAletheia

module gwn =
    let _namespace_name = "https://globalwordnet.github.io/schemas/wn#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
