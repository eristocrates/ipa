namespace https.www.w3.org.ns.posix.stat.hash

open DoxAletheia

module posix =
    let _namespace_name = "https://www.w3.org/ns/posix/stat#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
