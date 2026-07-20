namespace https.www.omg.org.spec.Commons.BusinessAuthorizations.slash

open DoxAletheia

module cmns_bauth =
    let _namespace_name = "https://www.omg.org/spec/Commons/BusinessAuthorizations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
