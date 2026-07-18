namespace http.taxref.mnhn.fr.lod.slash

open DoxAletheia.Rdf_Vocabulary

module taxref_ld =
    let _namespace_name = "http://taxref.mnhn.fr/lod/"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Agrovoc"></see>
    /// </summary>
    let Agrovoc = Namespaced_IRI.parse _namespace_name "Agrovoc" |> NamespacedName
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Catalog"></see>
    /// </summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/INPN"></see>
    /// </summary>
    let INPN = Namespaced_IRI.parse _namespace_name "INPN" |> NamespacedName
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref"></see>
    /// </summary>
    let taxref = Namespaced_IRI.parse _namespace_name "taxref" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref-ld"></see>
    /// </summary>
    let ``taxref-ld`` =
        Namespaced_IRI.parse _namespace_name "taxref-ld" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/NcbiTaxon"></see>
    /// </summary>
    let NcbiTaxon = Namespaced_IRI.parse _namespace_name "NcbiTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_%C5%92uf_stage"></see>
    /// </summary>
    let ``Organisms_in_%C5%92uf_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_%C5%92uf_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Egg"></see>
    /// </summary>
    let ``biologicalStage/Egg`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Egg" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasBiologicalStage"></see>
    /// </summary>
    let ``property/hasBiologicalStage`` =
        Namespaced_IRI.parse _namespace_name "property/hasBiologicalStage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_adulte_stage"></see>
    /// </summary>
    let Organisms_in_adulte_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_adulte_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Adult"></see>
    /// </summary>
    let ``biologicalStage/Adult`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Adult" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_au%20nid_stage"></see>
    /// </summary>
    let ``Organisms_in_au%20nid_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_au%20nid_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Spat"></see>
    /// </summary>
    let ``biologicalStage/Spat`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Spat" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20III_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20III_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20III_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIII"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeIII`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeIII" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20II_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20II_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20II_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeII"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeII`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeII" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20IV_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20IV_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20IV_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIV"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeIV`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeIV" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20I_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20I_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20I_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeI"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeI`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeI" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20VI_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20VI_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20VI_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeVI"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeVI`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeVI" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20V_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20V_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_copepodite%20V_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeV"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeV`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/CopepoditeV" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_cypris_stage"></see>
    /// </summary>
    let Organisms_in_cypris_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_cypris_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Cypris"></see>
    /// </summary>
    let ``biologicalStage/Cypris`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Cypris" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_de%20l%27ann%C3%A9e_stage"></see>
    /// </summary>
    let ``Organisms_in_de%20l%27ann%C3%A9e_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_de%20l%27ann%C3%A9e_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/1YearOld"></see>
    /// </summary>
    let ``biologicalStage/1YearOld`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/1YearOld" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_ephyra_stage"></see>
    /// </summary>
    let Organisms_in_ephyra_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_ephyra_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Ephyra"></see>
    /// </summary>
    let ``biologicalStage/Ephyra`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Ephyra" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_foetus_stage"></see>
    /// </summary>
    let Organisms_in_foetus_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_foetus_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Fetus"></see>
    /// </summary>
    let ``biologicalStage/Fetus`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Fetus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_gametophyte_stage"></see>
    /// </summary>
    let Organisms_in_gametophyte_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_gametophyte_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Gametophyte"></see>
    /// </summary>
    let ``biologicalStage/Gametophyte`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Gametophyte" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_hydro%C3%AFde_stage"></see>
    /// </summary>
    let ``Organisms_in_hydro%C3%AFde_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_hydro%C3%AFde_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Hydroid"></see>
    /// </summary>
    let ``biologicalStage/Hydroid`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Hydroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_juv%C3%A9nile_stage"></see>
    /// </summary>
    let ``Organisms_in_juv%C3%A9nile_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_juv%C3%A9nile_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Juvenile"></see>
    /// </summary>
    let ``biologicalStage/Juvenile`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Juvenile" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_larve_stage"></see>
    /// </summary>
    let Organisms_in_larve_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_larve_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Larva"></see>
    /// </summary>
    let ``biologicalStage/Larva`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Larva" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_m%C3%A9duse_stage"></see>
    /// </summary>
    let ``Organisms_in_m%C3%A9duse_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_m%C3%A9duse_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Medusa"></see>
    /// </summary>
    let ``biologicalStage/Medusa`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Medusa" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_macrothallus_stage"></see>
    /// </summary>
    let Organisms_in_macrothallus_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_macrothallus_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Macrothallus"></see>
    /// </summary>
    let ``biologicalStage/Macrothallus`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Macrothallus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_manca_stage"></see>
    /// </summary>
    let Organisms_in_manca_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_manca_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Manca"></see>
    /// </summary>
    let ``biologicalStage/Manca`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Manca" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_megalopa_stage"></see>
    /// </summary>
    let Organisms_in_megalopa_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_megalopa_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Megalopa"></see>
    /// </summary>
    let ``biologicalStage/Megalopa`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Megalopa" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_microthallus_stage"></see>
    /// </summary>
    let Organisms_in_microthallus_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_microthallus_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Microthallus"></see>
    /// </summary>
    let ``biologicalStage/Microthallus`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Microthallus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_nauplius_stage"></see>
    /// </summary>
    let Organisms_in_nauplius_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_nauplius_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Nauplius"></see>
    /// </summary>
    let ``biologicalStage/Nauplius`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Nauplius" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_nouveau-n%C3%A9_stage"></see>
    /// </summary>
    let ``Organisms_in_nouveau-n%C3%A9_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_nouveau-n%C3%A9_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Hatchling"></see>
    /// </summary>
    let ``biologicalStage/Hatchling`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Hatchling" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_planula_stage"></see>
    /// </summary>
    let Organisms_in_planula_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_planula_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Planula"></see>
    /// </summary>
    let ``biologicalStage/Planula`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Planula" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_polype_stage"></see>
    /// </summary>
    let Organisms_in_polype_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_polype_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Polyp"></see>
    /// </summary>
    let ``biologicalStage/Polyp`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Polyp" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_post-larve_stage"></see>
    /// </summary>
    let ``Organisms_in_post-larve_stage`` =
        Namespaced_IRI.parse _namespace_name "Organisms_in_post-larve_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Postlarva"></see>
    /// </summary>
    let ``biologicalStage/Postlarva`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Postlarva" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_sporophyte_stage"></see>
    /// </summary>
    let Organisms_in_sporophyte_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_sporophyte_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Sporophyte"></see>
    /// </summary>
    let ``biologicalStage/Sporophyte`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Sporophyte" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_subadulte_stage"></see>
    /// </summary>
    let Organisms_in_subadulte_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_subadulte_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Subadult"></see>
    /// </summary>
    let ``biologicalStage/Subadult`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Subadult" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_zoea_stage"></see>
    /// </summary>
    let Organisms_in_zoea_stage =
        Namespaced_IRI.parse _namespace_name "Organisms_in_zoea_stage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Zoea"></see>
    /// </summary>
    let ``biologicalStage/Zoea`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/Zoea" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/RdfGeneration"></see>
    /// </summary>
    let RdfGeneration =
        Namespaced_IRI.parse _namespace_name "RdfGeneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/WebService"></see>
    /// </summary>
    let WebService = Namespaced_IRI.parse _namespace_name "WebService" |> NamespacedName
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/xR2RML"></see>
    /// </summary>
    let xR2RML = Namespaced_IRI.parse _namespace_name "xR2RML" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2Agrovoc"></see>
    /// </summary>
    let Taxref2Agrovoc =
        Namespaced_IRI.parse _namespace_name "Taxref2Agrovoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2NcbiTaxon"></see>
    /// </summary>
    let Taxref2NcbiTaxon =
        Namespaced_IRI.parse _namespace_name "Taxref2NcbiTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2Worms"></see>
    /// </summary>
    let Taxref2Worms =
        Namespaced_IRI.parse _namespace_name "Taxref2Worms" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Worms"></see>
    /// </summary>
    let Worms = Namespaced_IRI.parse _namespace_name "Worms" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/A"></see>
    /// </summary>
    let ``bioGeoStatus/A`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/A" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/B"></see>
    /// </summary>
    let ``bioGeoStatus/B`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/B" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatus"></see>
    /// </summary>
    let ``bioGeoStatus/BioGeographicalStatus`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/BioGeographicalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatusCollection"></see>
    /// </summary>
    let ``bioGeoStatus/BioGeographicalStatusCollection`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/BioGeographicalStatusCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Y"></see>
    /// </summary>
    let ``bioGeoStatus/Y`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/M"></see>
    /// </summary>
    let ``bioGeoStatus/M`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/M" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/J"></see>
    /// </summary>
    let ``bioGeoStatus/J`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/J" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/C"></see>
    /// </summary>
    let ``bioGeoStatus/C`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/C" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Z"></see>
    /// </summary>
    let ``bioGeoStatus/Z`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/Z" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/W"></see>
    /// </summary>
    let ``bioGeoStatus/W`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/W" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/S"></see>
    /// </summary>
    let ``bioGeoStatus/S`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/S" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/P"></see>
    /// </summary>
    let ``bioGeoStatus/P`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/P" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/D"></see>
    /// </summary>
    let ``bioGeoStatus/D`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/D" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/X"></see>
    /// </summary>
    let ``bioGeoStatus/X`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/X" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/I"></see>
    /// </summary>
    let ``bioGeoStatus/I`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/I" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Q"></see>
    /// </summary>
    let ``bioGeoStatus/Q`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/Q" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/E"></see>
    /// </summary>
    let ``bioGeoStatus/E`` =
        Namespaced_IRI.parse _namespace_name "bioGeoStatus/E" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/BiologicalStageCollection"></see>
    /// </summary>
    let ``biologicalStage/BiologicalStageCollection`` =
        Namespaced_IRI.parse _namespace_name "biologicalStage/BiologicalStageCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/femelle_Organisms"></see>
    /// </summary>
    let femelle_Organisms =
        Namespaced_IRI.parse _namespace_name "femelle_Organisms" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasSex"></see>
    /// </summary>
    let ``property/hasSex`` =
        Namespaced_IRI.parse _namespace_name "property/hasSex" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/BrackishWater"></see>
    /// </summary>
    let ``habitat/BrackishWater`` =
        Namespaced_IRI.parse _namespace_name "habitat/BrackishWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/FreshWater"></see>
    /// </summary>
    let ``habitat/FreshWater`` =
        Namespaced_IRI.parse _namespace_name "habitat/FreshWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Habitat"></see>
    /// </summary>
    let ``habitat/Habitat`` =
        Namespaced_IRI.parse _namespace_name "habitat/Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/HabitatCollection"></see>
    /// </summary>
    let ``habitat/HabitatCollection`` =
        Namespaced_IRI.parse _namespace_name "habitat/HabitatCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Terrestrial"></see>
    /// </summary>
    let ``habitat/Terrestrial`` =
        Namespaced_IRI.parse _namespace_name "habitat/Terrestrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Marine"></see>
    /// </summary>
    let ``habitat/Marine`` =
        Namespaced_IRI.parse _namespace_name "habitat/Marine" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/hal01207828"></see>
    /// </summary>
    let hal01207828 =
        Namespaced_IRI.parse _namespace_name "hal01207828" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/johanmontagnat"></see>
    /// </summary>
    let johanmontagnat =
        Namespaced_IRI.parse _namespace_name "johanmontagnat" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/loicdjimenou"></see>
    /// </summary>
    let loicdjimenou =
        Namespaced_IRI.parse _namespace_name "loicdjimenou" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/hal01617708"></see>
    /// </summary>
    let hal01617708 =
        Namespaced_IRI.parse _namespace_name "hal01617708" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/oliviergargominy"></see>
    /// </summary>
    let oliviergargominy =
        Namespaced_IRI.parse _namespace_name "oliviergargominy" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/sandrinetercerie"></see>
    /// </summary>
    let sandrinetercerie =
        Namespaced_IRI.parse _namespace_name "sandrinetercerie" |> NamespacedName

    /// <summary>
    /// A maritime area, generally surrounding a landmass, that does not correspond to any specific sea or ocean, nor to any internationally recognized administrative subdivision (i.e. territorial waters or EEZ)
    /// <see href="http://taxref.mnhn.fr/lod/loc/MaritimeArea"></see></summary>
    let ``loc/MaritimeArea`` =
        Namespaced_IRI.parse _namespace_name "loc/MaritimeArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/m%C3%A2le_Organisms"></see>
    /// </summary>
    let ``m%C3%A2le_Organisms`` =
        Namespaced_IRI.parse _namespace_name "m%C3%A2le_Organisms" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/name/349525"></see>
    /// </summary>
    let ``name/349525`` =
        Namespaced_IRI.parse _namespace_name "name/349525" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/isReferenceNameOf"></see>
    /// </summary>
    let ``property/isReferenceNameOf`` =
        Namespaced_IRI.parse _namespace_name "property/isReferenceNameOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxon/349525"></see>
    /// </summary>
    let ``taxon/349525`` =
        Namespaced_IRI.parse _namespace_name "taxon/349525" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/bioGeoStatusIn"></see>
    /// </summary>
    let ``property/bioGeoStatusIn`` =
        Namespaced_IRI.parse _namespace_name "property/bioGeoStatusIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/habitat"></see>
    /// </summary>
    let ``property/habitat`` =
        Namespaced_IRI.parse _namespace_name "property/habitat" |> NamespacedName

    /// <summary>
    /// TDWG ontology's property http://rs.tdwg.org/ontology/voc/TaxonName#authorship is preferably associated with a scientific name (http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName), which is in line with TAXREF-LD's modelling. By contrast, DwC's scientificNameAuthorship property is associated with a taxon (dwc:Taxon), and its object shoud be a literal (DwC does not have a class for taxon names). Therefore, TAXREF-LD's hasAuthority property is not equivalent to the latter.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasAuthority"></see></summary>
    let ``property/hasAuthority`` =
        Namespaced_IRI.parse _namespace_name "property/hasAuthority" |> NamespacedName

    /// <summary>
    /// This property is not equivalent to http://rs.tdwg.org/ontology/voc/TaxonConcept#rank nor http://rs.tdwg.org/ontology/voc/TaxonName#rank whose domains are http://rs.tdwg.org/ontology/voc/TaxonConcept#TaxonConcept and http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName respectively, whereas we want to use taxrefprop:hasRank with taxa implemented as owl:Class's as well as scientific names implemented as instances of skos:Concept.
    /// This property is not equivalent to dwc:taxonRank which is expected to be used only with literal values (see http://rs.tdwg.org/dwc/terms/guides/rdf/index.htm, section 3.5)
    /// <see href="http://taxref.mnhn.fr/lod/property/hasRank"></see></summary>
    let ``property/hasRank`` =
        Namespaced_IRI.parse _namespace_name "property/hasRank" |> NamespacedName

    /// <summary>
    /// DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, TAXREF-LD extends it (rdfs:subPropertyOf) instead of asserting an equivalence.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasReferenceName"></see></summary>
    let ``property/hasReferenceName`` =
        Namespaced_IRI.parse _namespace_name "property/hasReferenceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasSpecificity"></see>
    /// </summary>
    let ``property/hasSpecificity`` =
        Namespaced_IRI.parse _namespace_name "property/hasSpecificity" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasStatus"></see>
    /// </summary>
    let ``property/hasStatus`` =
        Namespaced_IRI.parse _namespace_name "property/hasStatus" |> NamespacedName

    /// <summary>
    /// DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, in TAXREF-LD, we extend it with rdfs:subPropertyOf instead of asserting an equivalence.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasSynonym"></see></summary>
    let ``property/hasSynonym`` =
        Namespaced_IRI.parse _namespace_name "property/hasSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasTrophicLevel"></see>
    /// </summary>
    let ``property/hasTrophicLevel`` =
        Namespaced_IRI.parse _namespace_name "property/hasTrophicLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/isSynonymOf"></see>
    /// </summary>
    let ``property/isSynonymOf`` =
        Namespaced_IRI.parse _namespace_name "property/isSynonymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/statusType"></see>
    /// </summary>
    let ``property/statusType`` =
        Namespaced_IRI.parse _namespace_name "property/statusType" |> NamespacedName

    /// <summary>
    /// Relates a biogeographical, conservation or legal status of a taxon with the geographical location where this status is valid and the bibliographic source that assigned this status to that taxon
    /// <see href="http://taxref.mnhn.fr/lod/status/TaxonStatus"></see></summary>
    let ``status/TaxonStatus`` =
        Namespaced_IRI.parse _namespace_name "status/TaxonStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/statusValue"></see>
    /// </summary>
    let ``property/statusValue`` =
        Namespaced_IRI.parse _namespace_name "property/statusValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/vernacularName"></see>
    /// </summary>
    let ``property/vernacularName`` =
        Namespaced_IRI.parse _namespace_name "property/vernacularName" |> NamespacedName

    /// <summary>
    /// This property was initially defined as a subPropertyOf skosxl:altLabel. However skosxl:altLabel is an owl:ObjectProperty and thus cannot apply to a class. Therefore, we instead define it a an owl:AnnotationProperty whose range is a skosxl:Label
    /// <see href="http://taxref.mnhn.fr/lod/property/vernacularNameXL"></see></summary>
    let ``property/vernacularNameXL`` =
        Namespaced_IRI.parse _namespace_name "property/vernacularNameXL" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/sparql-service"></see>
    /// </summary>
    let ``sparql-service`` =
        Namespaced_IRI.parse _namespace_name "sparql-service" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/habitats/15.0"></see>
    /// </summary>
    let ``graph/habitats/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/habitats/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/interactions/15.0"></see>
    /// </summary>
    let ``graph/interactions/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/interactions/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/concepts"></see>
    /// </summary>
    let ``graph/concepts`` =
        Namespaced_IRI.parse _namespace_name "graph/concepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-ncbi"></see>
    /// </summary>
    let ``graph/links-ncbi`` =
        Namespaced_IRI.parse _namespace_name "graph/links-ncbi" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/media"></see>
    /// </summary>
    let ``graph/media`` =
        Namespaced_IRI.parse _namespace_name "graph/media" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/classes/15.0"></see>
    /// </summary>
    let ``graph/classes/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/classes/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/vernacular/15.0"></see>
    /// </summary>
    let ``graph/vernacular/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/vernacular/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-worms"></see>
    /// </summary>
    let ``graph/links-worms`` =
        Namespaced_IRI.parse _namespace_name "graph/links-worms" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/statuses/15.0"></see>
    /// </summary>
    let ``graph/statuses/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/statuses/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/dbxref/15.0"></see>
    /// </summary>
    let ``graph/dbxref/15.0`` =
        Namespaced_IRI.parse _namespace_name "graph/dbxref/15.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/locations"></see>
    /// </summary>
    let ``graph/locations`` =
        Namespaced_IRI.parse _namespace_name "graph/locations" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-agrovoc"></see>
    /// </summary>
    let ``graph/links-agrovoc`` =
        Namespaced_IRI.parse _namespace_name "graph/links-agrovoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/metadata"></see>
    /// </summary>
    let ``graph/metadata`` =
        Namespaced_IRI.parse _namespace_name "graph/metadata" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/biblio"></see>
    /// </summary>
    let ``graph/biblio`` =
        Namespaced_IRI.parse _namespace_name "graph/biblio" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/statusCodes"></see>
    /// </summary>
    let ``graph/statusCodes`` =
        Namespaced_IRI.parse _namespace_name "graph/statusCodes" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Mandatory"></see>
    /// </summary>
    let ``specificity/Mandatory`` =
        Namespaced_IRI.parse _namespace_name "specificity/Mandatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Optional"></see>
    /// </summary>
    let ``specificity/Optional`` =
        Namespaced_IRI.parse _namespace_name "specificity/Optional" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Principal"></see>
    /// </summary>
    let ``specificity/Principal`` =
        Namespaced_IRI.parse _namespace_name "specificity/Principal" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Regular"></see>
    /// </summary>
    let ``specificity/Regular`` =
        Namespaced_IRI.parse _namespace_name "specificity/Regular" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/SpecificityCollection"></see>
    /// </summary>
    let ``specificity/SpecificityCollection`` =
        Namespaced_IRI.parse _namespace_name "specificity/SpecificityCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Sporadic"></see>
    /// </summary>
    let ``specificity/Sporadic`` =
        Namespaced_IRI.parse _namespace_name "specificity/Sporadic" |> NamespacedName

    /// <summary>
    /// The biogeographical status of a taxon with the geographical area where this status applies and the bibliographic source that assigned this status to that taxon
    /// <see href="http://taxref.mnhn.fr/lod/status/BioGeographicalStatus"></see></summary>
    let ``status/BioGeographicalStatus`` =
        Namespaced_IRI.parse _namespace_name "status/BioGeographicalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/EuropeanDirective"></see>
    /// </summary>
    let ``status/EuropeanDirective`` =
        Namespaced_IRI.parse _namespace_name "status/EuropeanDirective" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/TaxonStatusType"></see>
    /// </summary>
    let ``status/TaxonStatusType`` =
        Namespaced_IRI.parse _namespace_name "status/TaxonStatusType" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/InternationalConvention"></see>
    /// </summary>
    let ``status/InternationalConvention`` =
        Namespaced_IRI.parse _namespace_name "status/InternationalConvention" |> NamespacedName

    /// <summary>
    /// To be used jointly with http://taxref.mnhn.fr/lod/status/TaxonStatusType whose narrower concepts represent directives, conventions, regulations or protections
    /// <see href="http://taxref.mnhn.fr/lod/status/LegalStatus"></see></summary>
    let ``status/LegalStatus`` =
        Namespaced_IRI.parse _namespace_name "status/LegalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/Protection"></see>
    /// </summary>
    let ``status/Protection`` =
        Namespaced_IRI.parse _namespace_name "status/Protection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/CR%2A"></see>
    /// </summary>
    let ``status/RedList/CR%2A`` =
        Namespaced_IRI.parse _namespace_name "status/RedList/CR%2A" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/NA"></see>
    /// </summary>
    let ``status/RedList/NA`` =
        Namespaced_IRI.parse _namespace_name "status/RedList/NA" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/RE%3F"></see>
    /// </summary>
    let ``status/RedList/RE%3F`` =
        Namespaced_IRI.parse _namespace_name "status/RedList/RE%3F" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedListStatus"></see>
    /// </summary>
    let ``status/RedListStatus`` =
        Namespaced_IRI.parse _namespace_name "status/RedListStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/Regulation"></see>
    /// </summary>
    let ``status/Regulation`` =
        Namespaced_IRI.parse _namespace_name "status/Regulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Abberatio"></see>
    /// </summary>
    let ``taxrank/Abberatio`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Abberatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Agregate"></see>
    /// </summary>
    let ``taxrank/Agregate`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Agregate" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cladus"></see>
    /// </summary>
    let ``taxrank/Cladus`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Cladus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Class"></see>
    /// </summary>
    let ``taxrank/Class`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Class" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Clone"></see>
    /// </summary>
    let ``taxrank/Clone`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Clone" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cohort"></see>
    /// </summary>
    let ``taxrank/Cohort`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Cohort" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cultivar"></see>
    /// </summary>
    let ``taxrank/Cultivar`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Cultivar" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Division"></see>
    /// </summary>
    let ``taxrank/Division`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Division" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Domain"></see>
    /// </summary>
    let ``taxrank/Domain`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Domain" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Family"></see>
    /// </summary>
    let ``taxrank/Family`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Family" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Forma"></see>
    /// </summary>
    let ``taxrank/Forma`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Forma" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/FormaSpecies"></see>
    /// </summary>
    let ``taxrank/FormaSpecies`` =
        Namespaced_IRI.parse _namespace_name "taxrank/FormaSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Genus"></see>
    /// </summary>
    let ``taxrank/Genus`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Genus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraClass"></see>
    /// </summary>
    let ``taxrank/InfraClass`` =
        Namespaced_IRI.parse _namespace_name "taxrank/InfraClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraKingdom"></see>
    /// </summary>
    let ``taxrank/InfraKingdom`` =
        Namespaced_IRI.parse _namespace_name "taxrank/InfraKingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraOrder"></see>
    /// </summary>
    let ``taxrank/InfraOrder`` =
        Namespaced_IRI.parse _namespace_name "taxrank/InfraOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraPhylum"></see>
    /// </summary>
    let ``taxrank/InfraPhylum`` =
        Namespaced_IRI.parse _namespace_name "taxrank/InfraPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Kingdom"></see>
    /// </summary>
    let ``taxrank/Kingdom`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Legio"></see>
    /// </summary>
    let ``taxrank/Legio`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Legio" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Linea"></see>
    /// </summary>
    let ``taxrank/Linea`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Linea" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/MicroSpecies"></see>
    /// </summary>
    let ``taxrank/MicroSpecies`` =
        Namespaced_IRI.parse _namespace_name "taxrank/MicroSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Morpha"></see>
    /// </summary>
    let ``taxrank/Morpha`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Morpha" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Natio"></see>
    /// </summary>
    let ``taxrank/Natio`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Natio" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Order"></see>
    /// </summary>
    let ``taxrank/Order`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Order" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Phylum"></see>
    /// </summary>
    let ``taxrank/Phylum`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Phylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Race"></see>
    /// </summary>
    let ``taxrank/Race`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Race" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Section"></see>
    /// </summary>
    let ``taxrank/Section`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Section" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SemiSpecies"></see>
    /// </summary>
    let ``taxrank/SemiSpecies`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SemiSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Series"></see>
    /// </summary>
    let ``taxrank/Series`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Series" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Species"></see>
    /// </summary>
    let ``taxrank/Species`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Species" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubClass"></see>
    /// </summary>
    let ``taxrank/SubClass`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubDivision"></see>
    /// </summary>
    let ``taxrank/SubDivision`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubFamily"></see>
    /// </summary>
    let ``taxrank/SubFamily`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubForma"></see>
    /// </summary>
    let ``taxrank/SubForma`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubForma" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubGenus"></see>
    /// </summary>
    let ``taxrank/SubGenus`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubGenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubKingdom"></see>
    /// </summary>
    let ``taxrank/SubKingdom`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubKingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubOrder"></see>
    /// </summary>
    let ``taxrank/SubOrder`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubPhylum"></see>
    /// </summary>
    let ``taxrank/SubPhylum`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSection"></see>
    /// </summary>
    let ``taxrank/SubSection`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSeries"></see>
    /// </summary>
    let ``taxrank/SubSeries`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSpecies"></see>
    /// </summary>
    let ``taxrank/SubSpecies`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubTribe"></see>
    /// </summary>
    let ``taxrank/SubTribe`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubTribe" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubVarietas"></see>
    /// </summary>
    let ``taxrank/SubVarietas`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SubVarietas" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperClass"></see>
    /// </summary>
    let ``taxrank/SuperClass`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SuperClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperFamily"></see>
    /// </summary>
    let ``taxrank/SuperFamily`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SuperFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperOrder"></see>
    /// </summary>
    let ``taxrank/SuperOrder`` =
        Namespaced_IRI.parse _namespace_name "taxrank/SuperOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Superkingdom"></see>
    /// </summary>
    let ``taxrank/Superkingdom`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Superkingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRank"></see>
    /// </summary>
    let ``taxrank/TaxonomicRank`` =
        Namespaced_IRI.parse _namespace_name "taxrank/TaxonomicRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRankCollection"></see>
    /// </summary>
    let ``taxrank/TaxonomicRankCollection`` =
        Namespaced_IRI.parse _namespace_name "taxrank/TaxonomicRankCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Tribe"></see>
    /// </summary>
    let ``taxrank/Tribe`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Tribe" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Varietas"></see>
    /// </summary>
    let ``taxrank/Varietas`` =
        Namespaced_IRI.parse _namespace_name "taxrank/Varietas" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrefmethodo"></see>
    /// </summary>
    let taxrefmethodo =
        Namespaced_IRI.parse _namespace_name "taxrefmethodo" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxon/60878"></see>
    /// </summary>
    let ``taxon/60878`` =
        Namespaced_IRI.parse _namespace_name "taxon/60878" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref-ld/15.2"></see>
    /// </summary>
    let ``taxref-ld/15.2`` =
        Namespaced_IRI.parse _namespace_name "taxref-ld/15.2" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Algivore"></see>
    /// </summary>
    let ``trophicLevel/Algivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Algivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Autotroph"></see>
    /// </summary>
    let ``trophicLevel/Autotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Autotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Carnivore"></see>
    /// </summary>
    let ``trophicLevel/Carnivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Carnivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Chemoautotroph"></see>
    /// </summary>
    let ``trophicLevel/Chemoautotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Chemoautotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Coprophage"></see>
    /// </summary>
    let ``trophicLevel/Coprophage`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Coprophage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Decomposer"></see>
    /// </summary>
    let ``trophicLevel/Decomposer`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Decomposer" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Detritivore"></see>
    /// </summary>
    let ``trophicLevel/Detritivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Detritivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Florivore"></see>
    /// </summary>
    let ``trophicLevel/Florivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Florivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Folivore"></see>
    /// </summary>
    let ``trophicLevel/Folivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Folivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Frugivore"></see>
    /// </summary>
    let ``trophicLevel/Frugivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Frugivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Fungivore"></see>
    /// </summary>
    let ``trophicLevel/Fungivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Fungivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Graminivore"></see>
    /// </summary>
    let ``trophicLevel/Graminivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Graminivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Granivore"></see>
    /// </summary>
    let ``trophicLevel/Granivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Granivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Herbivore"></see>
    /// </summary>
    let ``trophicLevel/Herbivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Herbivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Heterotroph"></see>
    /// </summary>
    let ``trophicLevel/Heterotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Heterotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Nectarivore"></see>
    /// </summary>
    let ``trophicLevel/Nectarivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Nectarivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Palynivore"></see>
    /// </summary>
    let ``trophicLevel/Palynivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Palynivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Photoautotroph"></see>
    /// </summary>
    let ``trophicLevel/Photoautotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Photoautotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Predator"></see>
    /// </summary>
    let ``trophicLevel/Predator`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Predator" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Rhizovore"></see>
    /// </summary>
    let ``trophicLevel/Rhizovore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Rhizovore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Saprotroph"></see>
    /// </summary>
    let ``trophicLevel/Saprotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Saprotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Saproxylotroph"></see>
    /// </summary>
    let ``trophicLevel/Saproxylotroph`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Saproxylotroph" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Scavenger"></see>
    /// </summary>
    let ``trophicLevel/Scavenger`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Scavenger" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/TrophicLevelCollection"></see>
    /// </summary>
    let ``trophicLevel/TrophicLevelCollection`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/TrophicLevelCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Xylophage"></see>
    /// </summary>
    let ``trophicLevel/Xylophage`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Xylophage" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Xylofungivore"></see>
    /// </summary>
    let ``trophicLevel/Xylofungivore`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Xylofungivore" |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Unknown"></see>
    /// </summary>
    let ``trophicLevel/Unknown`` =
        Namespaced_IRI.parse _namespace_name "trophicLevel/Unknown" |> NamespacedName
