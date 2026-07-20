namespace https.www.omg.org.spec.Commons.RolesAndCompositions.slash

open DoxAletheia

module cmns_rlcmp =
    let _namespace_name = "https://www.omg.org/spec/Commons/RolesAndCompositions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
