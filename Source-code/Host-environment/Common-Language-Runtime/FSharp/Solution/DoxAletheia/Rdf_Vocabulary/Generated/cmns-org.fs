namespace https.www.omg.org.spec.Commons.Organizations.slash

open DoxAletheia

module cmns_org =
    let _namespace_name = "https://www.omg.org/spec/Commons/Organizations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
