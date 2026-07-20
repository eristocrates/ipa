namespace https.www.omg.org.spec.LCC.Countries.ISO3166_1_CountryCodes.slash

open DoxAletheia

module lcc_3166_1 =
    let _namespace_name =
        "https://www.omg.org/spec/LCC/Countries/ISO3166-1-CountryCodes/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
