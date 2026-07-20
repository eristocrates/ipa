namespace https.w3id.org.dpv.pd.hash

open DoxAletheia

module dpvpd =
    let _namespace_name = "https://w3id.org/dpv/pd#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
