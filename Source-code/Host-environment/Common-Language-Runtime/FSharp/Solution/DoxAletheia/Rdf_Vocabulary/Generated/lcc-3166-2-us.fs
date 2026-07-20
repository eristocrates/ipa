namespace https.www.omg.org.spec.LCC.Countries.Regions.ISO3166_2_SubdivisionCodes_US.slash

open DoxAletheia

module lcc_3166_2_us =
    let _namespace_name =
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-US/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
