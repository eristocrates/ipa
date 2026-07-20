namespace https.www.omg.org.spec.Commons.Identifiers.slash

open DoxAletheia

module cmns_id =
    let _namespace_name = "https://www.omg.org/spec/Commons/Identifiers/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
