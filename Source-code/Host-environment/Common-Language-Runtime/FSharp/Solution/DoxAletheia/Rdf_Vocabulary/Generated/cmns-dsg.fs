namespace https.www.omg.org.spec.Commons.Designators.slash

open DoxAletheia

module cmns_dsg =
    let _namespace_name = "https://www.omg.org/spec/Commons/Designators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
