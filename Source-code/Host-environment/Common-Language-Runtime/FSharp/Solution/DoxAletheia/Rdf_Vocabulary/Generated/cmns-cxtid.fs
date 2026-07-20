namespace https.www.omg.org.spec.Commons.ContextualIdentifiers.slash

open DoxAletheia

module cmns_cxtid =
    let _namespace_name = "https://www.omg.org/spec/Commons/ContextualIdentifiers/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
