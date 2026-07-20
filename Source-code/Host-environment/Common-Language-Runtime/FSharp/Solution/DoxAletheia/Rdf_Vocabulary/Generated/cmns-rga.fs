namespace https.www.omg.org.spec.Commons.RegulatoryAgencies.slash

open DoxAletheia

module cmns_rga =
    let _namespace_name = "https://www.omg.org/spec/Commons/RegulatoryAgencies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
