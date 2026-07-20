namespace https.www.omg.org.spec.LCC.Countries.Regions.ISO3166_2_SubdivisionCodes_GB.slash

open DoxAletheia

module lcc_3166_2_gb =
    let _namespace_name =
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-GB/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
