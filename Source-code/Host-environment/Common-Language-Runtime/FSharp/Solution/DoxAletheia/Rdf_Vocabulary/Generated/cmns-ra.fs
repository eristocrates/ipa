namespace https.www.omg.org.spec.Commons.RegistrationAuthorities.slash

open DoxAletheia

module cmns_ra =
    let _namespace_name = "https://www.omg.org/spec/Commons/RegistrationAuthorities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
