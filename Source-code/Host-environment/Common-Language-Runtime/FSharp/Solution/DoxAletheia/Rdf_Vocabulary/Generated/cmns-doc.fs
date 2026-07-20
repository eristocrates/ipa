namespace https.www.omg.org.spec.Commons.Documents.slash

open DoxAletheia

module cmns_doc =
    let _namespace_name = "https://www.omg.org/spec/Commons/Documents/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
