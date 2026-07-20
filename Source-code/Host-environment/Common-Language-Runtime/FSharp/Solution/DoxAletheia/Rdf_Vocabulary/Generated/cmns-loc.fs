namespace https.www.omg.org.spec.Commons.Locations.slash

open DoxAletheia

module cmns_loc =
    let _namespace_name = "https://www.omg.org/spec/Commons/Locations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
