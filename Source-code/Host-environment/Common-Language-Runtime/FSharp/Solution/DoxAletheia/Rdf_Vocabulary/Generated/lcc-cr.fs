namespace https.www.omg.org.spec.LCC.Countries.CountryRepresentation.slash

open DoxAletheia

module lcc_cr =
    let _namespace_name =
        "https://www.omg.org/spec/LCC/Countries/CountryRepresentation/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
