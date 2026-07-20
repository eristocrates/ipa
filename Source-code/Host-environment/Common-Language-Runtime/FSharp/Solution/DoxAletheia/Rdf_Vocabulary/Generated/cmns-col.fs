namespace https.www.omg.org.spec.Commons.Collections.slash

open DoxAletheia

module cmns_col =
    let _namespace_name = "https://www.omg.org/spec/Commons/Collections/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
