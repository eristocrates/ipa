namespace https.www.omg.org.spec.Commons.SitesAndFacilities.slash

open DoxAletheia

module cmns_sfc =
    let _namespace_name = "https://www.omg.org/spec/Commons/SitesAndFacilities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
