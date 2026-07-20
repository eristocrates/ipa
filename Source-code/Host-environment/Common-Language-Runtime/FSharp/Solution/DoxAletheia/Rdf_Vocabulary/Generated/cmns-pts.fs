namespace https.www.omg.org.spec.Commons.PartiesAndSituations.slash

open DoxAletheia

module cmns_pts =
    let _namespace_name = "https://www.omg.org/spec/Commons/PartiesAndSituations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
