namespace http.taxref.mnhn.fr.lod.slash

open DoxAletheia

module taxref_ld =
    let _namespace_name = "http://taxref.mnhn.fr/lod/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Agrovoc"></see>
    /// </summary>
    let Agrovoc = _prefix "Agrovoc"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Catalog"></see>
    /// </summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/INPN"></see>
    /// </summary>
    let INPN = _prefix "INPN"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref"></see>
    /// </summary>
    let taxref = _prefix "taxref"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref-ld"></see>
    /// </summary>
    let ``taxref-ld`` = _prefix "taxref-ld"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/NcbiTaxon"></see>
    /// </summary>
    let NcbiTaxon = _prefix "NcbiTaxon"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_%C5%92uf_stage"></see>
    /// </summary>
    let ``Organisms_in_%C5%92uf_stage`` = _prefix "Organisms_in_%C5%92uf_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Egg"></see>
    /// </summary>
    let ``biologicalStage/Egg`` = _prefix "biologicalStage/Egg"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasBiologicalStage"></see>
    /// </summary>
    let ``property/hasBiologicalStage`` = _prefix "property/hasBiologicalStage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_adulte_stage"></see>
    /// </summary>
    let Organisms_in_adulte_stage = _prefix "Organisms_in_adulte_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Adult"></see>
    /// </summary>
    let ``biologicalStage/Adult`` = _prefix "biologicalStage/Adult"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_au%20nid_stage"></see>
    /// </summary>
    let ``Organisms_in_au%20nid_stage`` = _prefix "Organisms_in_au%20nid_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Spat"></see>
    /// </summary>
    let ``biologicalStage/Spat`` = _prefix "biologicalStage/Spat"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20III_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20III_stage`` =
        _prefix "Organisms_in_copepodite%20III_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIII"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeIII`` = _prefix "biologicalStage/CopepoditeIII"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20II_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20II_stage`` =
        _prefix "Organisms_in_copepodite%20II_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeII"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeII`` = _prefix "biologicalStage/CopepoditeII"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20IV_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20IV_stage`` =
        _prefix "Organisms_in_copepodite%20IV_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeIV"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeIV`` = _prefix "biologicalStage/CopepoditeIV"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20I_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20I_stage`` =
        _prefix "Organisms_in_copepodite%20I_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeI"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeI`` = _prefix "biologicalStage/CopepoditeI"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20VI_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20VI_stage`` =
        _prefix "Organisms_in_copepodite%20VI_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeVI"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeVI`` = _prefix "biologicalStage/CopepoditeVI"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_copepodite%20V_stage"></see>
    /// </summary>
    let ``Organisms_in_copepodite%20V_stage`` =
        _prefix "Organisms_in_copepodite%20V_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/CopepoditeV"></see>
    /// </summary>
    let ``biologicalStage/CopepoditeV`` = _prefix "biologicalStage/CopepoditeV"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_cypris_stage"></see>
    /// </summary>
    let Organisms_in_cypris_stage = _prefix "Organisms_in_cypris_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Cypris"></see>
    /// </summary>
    let ``biologicalStage/Cypris`` = _prefix "biologicalStage/Cypris"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_de%20l%27ann%C3%A9e_stage"></see>
    /// </summary>
    let ``Organisms_in_de%20l%27ann%C3%A9e_stage`` =
        _prefix "Organisms_in_de%20l%27ann%C3%A9e_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/1YearOld"></see>
    /// </summary>
    let ``biologicalStage/1YearOld`` = _prefix "biologicalStage/1YearOld"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_ephyra_stage"></see>
    /// </summary>
    let Organisms_in_ephyra_stage = _prefix "Organisms_in_ephyra_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Ephyra"></see>
    /// </summary>
    let ``biologicalStage/Ephyra`` = _prefix "biologicalStage/Ephyra"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_foetus_stage"></see>
    /// </summary>
    let Organisms_in_foetus_stage = _prefix "Organisms_in_foetus_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Fetus"></see>
    /// </summary>
    let ``biologicalStage/Fetus`` = _prefix "biologicalStage/Fetus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_gametophyte_stage"></see>
    /// </summary>
    let Organisms_in_gametophyte_stage = _prefix "Organisms_in_gametophyte_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Gametophyte"></see>
    /// </summary>
    let ``biologicalStage/Gametophyte`` = _prefix "biologicalStage/Gametophyte"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_hydro%C3%AFde_stage"></see>
    /// </summary>
    let ``Organisms_in_hydro%C3%AFde_stage`` =
        _prefix "Organisms_in_hydro%C3%AFde_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Hydroid"></see>
    /// </summary>
    let ``biologicalStage/Hydroid`` = _prefix "biologicalStage/Hydroid"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_juv%C3%A9nile_stage"></see>
    /// </summary>
    let ``Organisms_in_juv%C3%A9nile_stage`` =
        _prefix "Organisms_in_juv%C3%A9nile_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Juvenile"></see>
    /// </summary>
    let ``biologicalStage/Juvenile`` = _prefix "biologicalStage/Juvenile"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_larve_stage"></see>
    /// </summary>
    let Organisms_in_larve_stage = _prefix "Organisms_in_larve_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Larva"></see>
    /// </summary>
    let ``biologicalStage/Larva`` = _prefix "biologicalStage/Larva"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_m%C3%A9duse_stage"></see>
    /// </summary>
    let ``Organisms_in_m%C3%A9duse_stage`` = _prefix "Organisms_in_m%C3%A9duse_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Medusa"></see>
    /// </summary>
    let ``biologicalStage/Medusa`` = _prefix "biologicalStage/Medusa"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_macrothallus_stage"></see>
    /// </summary>
    let Organisms_in_macrothallus_stage = _prefix "Organisms_in_macrothallus_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Macrothallus"></see>
    /// </summary>
    let ``biologicalStage/Macrothallus`` = _prefix "biologicalStage/Macrothallus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_manca_stage"></see>
    /// </summary>
    let Organisms_in_manca_stage = _prefix "Organisms_in_manca_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Manca"></see>
    /// </summary>
    let ``biologicalStage/Manca`` = _prefix "biologicalStage/Manca"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_megalopa_stage"></see>
    /// </summary>
    let Organisms_in_megalopa_stage = _prefix "Organisms_in_megalopa_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Megalopa"></see>
    /// </summary>
    let ``biologicalStage/Megalopa`` = _prefix "biologicalStage/Megalopa"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_microthallus_stage"></see>
    /// </summary>
    let Organisms_in_microthallus_stage = _prefix "Organisms_in_microthallus_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Microthallus"></see>
    /// </summary>
    let ``biologicalStage/Microthallus`` = _prefix "biologicalStage/Microthallus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_nauplius_stage"></see>
    /// </summary>
    let Organisms_in_nauplius_stage = _prefix "Organisms_in_nauplius_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Nauplius"></see>
    /// </summary>
    let ``biologicalStage/Nauplius`` = _prefix "biologicalStage/Nauplius"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_nouveau-n%C3%A9_stage"></see>
    /// </summary>
    let ``Organisms_in_nouveau-n%C3%A9_stage`` =
        _prefix "Organisms_in_nouveau-n%C3%A9_stage"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Hatchling"></see>
    /// </summary>
    let ``biologicalStage/Hatchling`` = _prefix "biologicalStage/Hatchling"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_planula_stage"></see>
    /// </summary>
    let Organisms_in_planula_stage = _prefix "Organisms_in_planula_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Planula"></see>
    /// </summary>
    let ``biologicalStage/Planula`` = _prefix "biologicalStage/Planula"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_polype_stage"></see>
    /// </summary>
    let Organisms_in_polype_stage = _prefix "Organisms_in_polype_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Polyp"></see>
    /// </summary>
    let ``biologicalStage/Polyp`` = _prefix "biologicalStage/Polyp"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_post-larve_stage"></see>
    /// </summary>
    let ``Organisms_in_post-larve_stage`` = _prefix "Organisms_in_post-larve_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Postlarva"></see>
    /// </summary>
    let ``biologicalStage/Postlarva`` = _prefix "biologicalStage/Postlarva"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_sporophyte_stage"></see>
    /// </summary>
    let Organisms_in_sporophyte_stage = _prefix "Organisms_in_sporophyte_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Sporophyte"></see>
    /// </summary>
    let ``biologicalStage/Sporophyte`` = _prefix "biologicalStage/Sporophyte"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_subadulte_stage"></see>
    /// </summary>
    let Organisms_in_subadulte_stage = _prefix "Organisms_in_subadulte_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Subadult"></see>
    /// </summary>
    let ``biologicalStage/Subadult`` = _prefix "biologicalStage/Subadult"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Organisms_in_zoea_stage"></see>
    /// </summary>
    let Organisms_in_zoea_stage = _prefix "Organisms_in_zoea_stage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/Zoea"></see>
    /// </summary>
    let ``biologicalStage/Zoea`` = _prefix "biologicalStage/Zoea"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/RdfGeneration"></see>
    /// </summary>
    let RdfGeneration = _prefix "RdfGeneration"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/WebService"></see>
    /// </summary>
    let WebService = _prefix "WebService"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/xR2RML"></see>
    /// </summary>
    let xR2RML = _prefix "xR2RML"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2Agrovoc"></see>
    /// </summary>
    let Taxref2Agrovoc = _prefix "Taxref2Agrovoc"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2NcbiTaxon"></see>
    /// </summary>
    let Taxref2NcbiTaxon = _prefix "Taxref2NcbiTaxon"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Taxref2Worms"></see>
    /// </summary>
    let Taxref2Worms = _prefix "Taxref2Worms"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/Worms"></see>
    /// </summary>
    let Worms = _prefix "Worms"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/A"></see>
    /// </summary>
    let ``bioGeoStatus/A`` = _prefix "bioGeoStatus/A"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/B"></see>
    /// </summary>
    let ``bioGeoStatus/B`` = _prefix "bioGeoStatus/B"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatus"></see>
    /// </summary>
    let ``bioGeoStatus/BioGeographicalStatus`` =
        _prefix "bioGeoStatus/BioGeographicalStatus"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/BioGeographicalStatusCollection"></see>
    /// </summary>
    let ``bioGeoStatus/BioGeographicalStatusCollection`` =
        _prefix "bioGeoStatus/BioGeographicalStatusCollection"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Y"></see>
    /// </summary>
    let ``bioGeoStatus/Y`` = _prefix "bioGeoStatus/Y"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/M"></see>
    /// </summary>
    let ``bioGeoStatus/M`` = _prefix "bioGeoStatus/M"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/J"></see>
    /// </summary>
    let ``bioGeoStatus/J`` = _prefix "bioGeoStatus/J"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/C"></see>
    /// </summary>
    let ``bioGeoStatus/C`` = _prefix "bioGeoStatus/C"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Z"></see>
    /// </summary>
    let ``bioGeoStatus/Z`` = _prefix "bioGeoStatus/Z"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/W"></see>
    /// </summary>
    let ``bioGeoStatus/W`` = _prefix "bioGeoStatus/W"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/S"></see>
    /// </summary>
    let ``bioGeoStatus/S`` = _prefix "bioGeoStatus/S"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/P"></see>
    /// </summary>
    let ``bioGeoStatus/P`` = _prefix "bioGeoStatus/P"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/D"></see>
    /// </summary>
    let ``bioGeoStatus/D`` = _prefix "bioGeoStatus/D"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/X"></see>
    /// </summary>
    let ``bioGeoStatus/X`` = _prefix "bioGeoStatus/X"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/I"></see>
    /// </summary>
    let ``bioGeoStatus/I`` = _prefix "bioGeoStatus/I"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/Q"></see>
    /// </summary>
    let ``bioGeoStatus/Q`` = _prefix "bioGeoStatus/Q"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/bioGeoStatus/E"></see>
    /// </summary>
    let ``bioGeoStatus/E`` = _prefix "bioGeoStatus/E"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/biologicalStage/BiologicalStageCollection"></see>
    /// </summary>
    let ``biologicalStage/BiologicalStageCollection`` =
        _prefix "biologicalStage/BiologicalStageCollection"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/femelle_Organisms"></see>
    /// </summary>
    let femelle_Organisms = _prefix "femelle_Organisms"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasSex"></see>
    /// </summary>
    let ``property/hasSex`` = _prefix "property/hasSex"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/BrackishWater"></see>
    /// </summary>
    let ``habitat/BrackishWater`` = _prefix "habitat/BrackishWater"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/FreshWater"></see>
    /// </summary>
    let ``habitat/FreshWater`` = _prefix "habitat/FreshWater"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Habitat"></see>
    /// </summary>
    let ``habitat/Habitat`` = _prefix "habitat/Habitat"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/HabitatCollection"></see>
    /// </summary>
    let ``habitat/HabitatCollection`` = _prefix "habitat/HabitatCollection"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Terrestrial"></see>
    /// </summary>
    let ``habitat/Terrestrial`` = _prefix "habitat/Terrestrial"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/habitat/Marine"></see>
    /// </summary>
    let ``habitat/Marine`` = _prefix "habitat/Marine"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/hal01207828"></see>
    /// </summary>
    let hal01207828 = _prefix "hal01207828"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/johanmontagnat"></see>
    /// </summary>
    let johanmontagnat = _prefix "johanmontagnat"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/loicdjimenou"></see>
    /// </summary>
    let loicdjimenou = _prefix "loicdjimenou"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/hal01617708"></see>
    /// </summary>
    let hal01617708 = _prefix "hal01617708"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/oliviergargominy"></see>
    /// </summary>
    let oliviergargominy = _prefix "oliviergargominy"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/sandrinetercerie"></see>
    /// </summary>
    let sandrinetercerie = _prefix "sandrinetercerie"
    /// <summary>
    /// A maritime area, generally surrounding a landmass, that does not correspond to any specific sea or ocean, nor to any internationally recognized administrative subdivision (i.e. territorial waters or EEZ)
    /// <see href="http://taxref.mnhn.fr/lod/loc/MaritimeArea"></see></summary>
    let ``loc/MaritimeArea`` = _prefix "loc/MaritimeArea"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/m%C3%A2le_Organisms"></see>
    /// </summary>
    let ``m%C3%A2le_Organisms`` = _prefix "m%C3%A2le_Organisms"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/name/349525"></see>
    /// </summary>
    let ``name/349525`` = _prefix "name/349525"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/isReferenceNameOf"></see>
    /// </summary>
    let ``property/isReferenceNameOf`` = _prefix "property/isReferenceNameOf"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxon/349525"></see>
    /// </summary>
    let ``taxon/349525`` = _prefix "taxon/349525"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/bioGeoStatusIn"></see>
    /// </summary>
    let ``property/bioGeoStatusIn`` = _prefix "property/bioGeoStatusIn"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/habitat"></see>
    /// </summary>
    let ``property/habitat`` = _prefix "property/habitat"
    /// <summary>
    /// TDWG ontology's property http://rs.tdwg.org/ontology/voc/TaxonName#authorship is preferably associated with a scientific name (http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName), which is in line with TAXREF-LD's modelling. By contrast, DwC's scientificNameAuthorship property is associated with a taxon (dwc:Taxon), and its object shoud be a literal (DwC does not have a class for taxon names). Therefore, TAXREF-LD's hasAuthority property is not equivalent to the latter.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasAuthority"></see></summary>
    let ``property/hasAuthority`` = _prefix "property/hasAuthority"
    /// <summary>
    /// This property is not equivalent to http://rs.tdwg.org/ontology/voc/TaxonConcept#rank nor http://rs.tdwg.org/ontology/voc/TaxonName#rank whose domains are http://rs.tdwg.org/ontology/voc/TaxonConcept#TaxonConcept and http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName respectively, whereas we want to use taxrefprop:hasRank with taxa implemented as owl:Class's as well as scientific names implemented as instances of skos:Concept.
    /// This property is not equivalent to dwc:taxonRank which is expected to be used only with literal values (see http://rs.tdwg.org/dwc/terms/guides/rdf/index.htm, section 3.5)
    /// <see href="http://taxref.mnhn.fr/lod/property/hasRank"></see></summary>
    let ``property/hasRank`` = _prefix "property/hasRank"
    /// <summary>
    /// DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, TAXREF-LD extends it (rdfs:subPropertyOf) instead of asserting an equivalence.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasReferenceName"></see></summary>
    let ``property/hasReferenceName`` = _prefix "property/hasReferenceName"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasSpecificity"></see>
    /// </summary>
    let ``property/hasSpecificity`` = _prefix "property/hasSpecificity"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasStatus"></see>
    /// </summary>
    let ``property/hasStatus`` = _prefix "property/hasStatus"
    /// <summary>
    /// DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, in TAXREF-LD, we extend it with rdfs:subPropertyOf instead of asserting an equivalence.
    /// <see href="http://taxref.mnhn.fr/lod/property/hasSynonym"></see></summary>
    let ``property/hasSynonym`` = _prefix "property/hasSynonym"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/hasTrophicLevel"></see>
    /// </summary>
    let ``property/hasTrophicLevel`` = _prefix "property/hasTrophicLevel"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/isSynonymOf"></see>
    /// </summary>
    let ``property/isSynonymOf`` = _prefix "property/isSynonymOf"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/statusType"></see>
    /// </summary>
    let ``property/statusType`` = _prefix "property/statusType"
    /// <summary>
    /// Relates a biogeographical, conservation or legal status of a taxon with the geographical location where this status is valid and the bibliographic source that assigned this status to that taxon
    /// <see href="http://taxref.mnhn.fr/lod/status/TaxonStatus"></see></summary>
    let ``status/TaxonStatus`` = _prefix "status/TaxonStatus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/statusValue"></see>
    /// </summary>
    let ``property/statusValue`` = _prefix "property/statusValue"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/property/vernacularName"></see>
    /// </summary>
    let ``property/vernacularName`` = _prefix "property/vernacularName"
    /// <summary>
    /// This property was initially defined as a subPropertyOf skosxl:altLabel. However skosxl:altLabel is an owl:ObjectProperty and thus cannot apply to a class. Therefore, we instead define it a an owl:AnnotationProperty whose range is a skosxl:Label
    /// <see href="http://taxref.mnhn.fr/lod/property/vernacularNameXL"></see></summary>
    let ``property/vernacularNameXL`` = _prefix "property/vernacularNameXL"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/sparql-service"></see>
    /// </summary>
    let ``sparql-service`` = _prefix "sparql-service"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/habitats/15.0"></see>
    /// </summary>
    let ``graph/habitats/15.0`` = _prefix "graph/habitats/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/interactions/15.0"></see>
    /// </summary>
    let ``graph/interactions/15.0`` = _prefix "graph/interactions/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/concepts"></see>
    /// </summary>
    let ``graph/concepts`` = _prefix "graph/concepts"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-ncbi"></see>
    /// </summary>
    let ``graph/links-ncbi`` = _prefix "graph/links-ncbi"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/media"></see>
    /// </summary>
    let ``graph/media`` = _prefix "graph/media"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/classes/15.0"></see>
    /// </summary>
    let ``graph/classes/15.0`` = _prefix "graph/classes/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/vernacular/15.0"></see>
    /// </summary>
    let ``graph/vernacular/15.0`` = _prefix "graph/vernacular/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-worms"></see>
    /// </summary>
    let ``graph/links-worms`` = _prefix "graph/links-worms"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/statuses/15.0"></see>
    /// </summary>
    let ``graph/statuses/15.0`` = _prefix "graph/statuses/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/dbxref/15.0"></see>
    /// </summary>
    let ``graph/dbxref/15.0`` = _prefix "graph/dbxref/15.0"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/locations"></see>
    /// </summary>
    let ``graph/locations`` = _prefix "graph/locations"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/links-agrovoc"></see>
    /// </summary>
    let ``graph/links-agrovoc`` = _prefix "graph/links-agrovoc"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/metadata"></see>
    /// </summary>
    let ``graph/metadata`` = _prefix "graph/metadata"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/biblio"></see>
    /// </summary>
    let ``graph/biblio`` = _prefix "graph/biblio"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/graph/statusCodes"></see>
    /// </summary>
    let ``graph/statusCodes`` = _prefix "graph/statusCodes"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Mandatory"></see>
    /// </summary>
    let ``specificity/Mandatory`` = _prefix "specificity/Mandatory"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Optional"></see>
    /// </summary>
    let ``specificity/Optional`` = _prefix "specificity/Optional"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Principal"></see>
    /// </summary>
    let ``specificity/Principal`` = _prefix "specificity/Principal"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Regular"></see>
    /// </summary>
    let ``specificity/Regular`` = _prefix "specificity/Regular"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/SpecificityCollection"></see>
    /// </summary>
    let ``specificity/SpecificityCollection`` =
        _prefix "specificity/SpecificityCollection"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/specificity/Sporadic"></see>
    /// </summary>
    let ``specificity/Sporadic`` = _prefix "specificity/Sporadic"
    /// <summary>
    /// The biogeographical status of a taxon with the geographical area where this status applies and the bibliographic source that assigned this status to that taxon
    /// <see href="http://taxref.mnhn.fr/lod/status/BioGeographicalStatus"></see></summary>
    let ``status/BioGeographicalStatus`` = _prefix "status/BioGeographicalStatus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/EuropeanDirective"></see>
    /// </summary>
    let ``status/EuropeanDirective`` = _prefix "status/EuropeanDirective"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/TaxonStatusType"></see>
    /// </summary>
    let ``status/TaxonStatusType`` = _prefix "status/TaxonStatusType"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/InternationalConvention"></see>
    /// </summary>
    let ``status/InternationalConvention`` = _prefix "status/InternationalConvention"
    /// <summary>
    /// To be used jointly with http://taxref.mnhn.fr/lod/status/TaxonStatusType whose narrower concepts represent directives, conventions, regulations or protections
    /// <see href="http://taxref.mnhn.fr/lod/status/LegalStatus"></see></summary>
    let ``status/LegalStatus`` = _prefix "status/LegalStatus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/Protection"></see>
    /// </summary>
    let ``status/Protection`` = _prefix "status/Protection"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/CR%2A"></see>
    /// </summary>
    let ``status/RedList/CR%2A`` = _prefix "status/RedList/CR%2A"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/NA"></see>
    /// </summary>
    let ``status/RedList/NA`` = _prefix "status/RedList/NA"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedList/RE%3F"></see>
    /// </summary>
    let ``status/RedList/RE%3F`` = _prefix "status/RedList/RE%3F"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/RedListStatus"></see>
    /// </summary>
    let ``status/RedListStatus`` = _prefix "status/RedListStatus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/status/Regulation"></see>
    /// </summary>
    let ``status/Regulation`` = _prefix "status/Regulation"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Abberatio"></see>
    /// </summary>
    let ``taxrank/Abberatio`` = _prefix "taxrank/Abberatio"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Agregate"></see>
    /// </summary>
    let ``taxrank/Agregate`` = _prefix "taxrank/Agregate"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cladus"></see>
    /// </summary>
    let ``taxrank/Cladus`` = _prefix "taxrank/Cladus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Class"></see>
    /// </summary>
    let ``taxrank/Class`` = _prefix "taxrank/Class"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Clone"></see>
    /// </summary>
    let ``taxrank/Clone`` = _prefix "taxrank/Clone"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cohort"></see>
    /// </summary>
    let ``taxrank/Cohort`` = _prefix "taxrank/Cohort"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Cultivar"></see>
    /// </summary>
    let ``taxrank/Cultivar`` = _prefix "taxrank/Cultivar"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Division"></see>
    /// </summary>
    let ``taxrank/Division`` = _prefix "taxrank/Division"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Domain"></see>
    /// </summary>
    let ``taxrank/Domain`` = _prefix "taxrank/Domain"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Family"></see>
    /// </summary>
    let ``taxrank/Family`` = _prefix "taxrank/Family"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Forma"></see>
    /// </summary>
    let ``taxrank/Forma`` = _prefix "taxrank/Forma"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/FormaSpecies"></see>
    /// </summary>
    let ``taxrank/FormaSpecies`` = _prefix "taxrank/FormaSpecies"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Genus"></see>
    /// </summary>
    let ``taxrank/Genus`` = _prefix "taxrank/Genus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraClass"></see>
    /// </summary>
    let ``taxrank/InfraClass`` = _prefix "taxrank/InfraClass"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraKingdom"></see>
    /// </summary>
    let ``taxrank/InfraKingdom`` = _prefix "taxrank/InfraKingdom"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraOrder"></see>
    /// </summary>
    let ``taxrank/InfraOrder`` = _prefix "taxrank/InfraOrder"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/InfraPhylum"></see>
    /// </summary>
    let ``taxrank/InfraPhylum`` = _prefix "taxrank/InfraPhylum"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Kingdom"></see>
    /// </summary>
    let ``taxrank/Kingdom`` = _prefix "taxrank/Kingdom"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Legio"></see>
    /// </summary>
    let ``taxrank/Legio`` = _prefix "taxrank/Legio"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Linea"></see>
    /// </summary>
    let ``taxrank/Linea`` = _prefix "taxrank/Linea"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/MicroSpecies"></see>
    /// </summary>
    let ``taxrank/MicroSpecies`` = _prefix "taxrank/MicroSpecies"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Morpha"></see>
    /// </summary>
    let ``taxrank/Morpha`` = _prefix "taxrank/Morpha"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Natio"></see>
    /// </summary>
    let ``taxrank/Natio`` = _prefix "taxrank/Natio"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Order"></see>
    /// </summary>
    let ``taxrank/Order`` = _prefix "taxrank/Order"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Phylum"></see>
    /// </summary>
    let ``taxrank/Phylum`` = _prefix "taxrank/Phylum"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Race"></see>
    /// </summary>
    let ``taxrank/Race`` = _prefix "taxrank/Race"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Section"></see>
    /// </summary>
    let ``taxrank/Section`` = _prefix "taxrank/Section"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SemiSpecies"></see>
    /// </summary>
    let ``taxrank/SemiSpecies`` = _prefix "taxrank/SemiSpecies"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Series"></see>
    /// </summary>
    let ``taxrank/Series`` = _prefix "taxrank/Series"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Species"></see>
    /// </summary>
    let ``taxrank/Species`` = _prefix "taxrank/Species"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubClass"></see>
    /// </summary>
    let ``taxrank/SubClass`` = _prefix "taxrank/SubClass"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubDivision"></see>
    /// </summary>
    let ``taxrank/SubDivision`` = _prefix "taxrank/SubDivision"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubFamily"></see>
    /// </summary>
    let ``taxrank/SubFamily`` = _prefix "taxrank/SubFamily"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubForma"></see>
    /// </summary>
    let ``taxrank/SubForma`` = _prefix "taxrank/SubForma"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubGenus"></see>
    /// </summary>
    let ``taxrank/SubGenus`` = _prefix "taxrank/SubGenus"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubKingdom"></see>
    /// </summary>
    let ``taxrank/SubKingdom`` = _prefix "taxrank/SubKingdom"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubOrder"></see>
    /// </summary>
    let ``taxrank/SubOrder`` = _prefix "taxrank/SubOrder"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubPhylum"></see>
    /// </summary>
    let ``taxrank/SubPhylum`` = _prefix "taxrank/SubPhylum"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSection"></see>
    /// </summary>
    let ``taxrank/SubSection`` = _prefix "taxrank/SubSection"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSeries"></see>
    /// </summary>
    let ``taxrank/SubSeries`` = _prefix "taxrank/SubSeries"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubSpecies"></see>
    /// </summary>
    let ``taxrank/SubSpecies`` = _prefix "taxrank/SubSpecies"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubTribe"></see>
    /// </summary>
    let ``taxrank/SubTribe`` = _prefix "taxrank/SubTribe"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SubVarietas"></see>
    /// </summary>
    let ``taxrank/SubVarietas`` = _prefix "taxrank/SubVarietas"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperClass"></see>
    /// </summary>
    let ``taxrank/SuperClass`` = _prefix "taxrank/SuperClass"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperFamily"></see>
    /// </summary>
    let ``taxrank/SuperFamily`` = _prefix "taxrank/SuperFamily"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/SuperOrder"></see>
    /// </summary>
    let ``taxrank/SuperOrder`` = _prefix "taxrank/SuperOrder"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Superkingdom"></see>
    /// </summary>
    let ``taxrank/Superkingdom`` = _prefix "taxrank/Superkingdom"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRank"></see>
    /// </summary>
    let ``taxrank/TaxonomicRank`` = _prefix "taxrank/TaxonomicRank"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/TaxonomicRankCollection"></see>
    /// </summary>
    let ``taxrank/TaxonomicRankCollection`` = _prefix "taxrank/TaxonomicRankCollection"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Tribe"></see>
    /// </summary>
    let ``taxrank/Tribe`` = _prefix "taxrank/Tribe"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrank/Varietas"></see>
    /// </summary>
    let ``taxrank/Varietas`` = _prefix "taxrank/Varietas"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxrefmethodo"></see>
    /// </summary>
    let taxrefmethodo = _prefix "taxrefmethodo"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxon/60878"></see>
    /// </summary>
    let ``taxon/60878`` = _prefix "taxon/60878"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/taxref-ld/15.2"></see>
    /// </summary>
    let ``taxref-ld/15.2`` = _prefix "taxref-ld/15.2"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Algivore"></see>
    /// </summary>
    let ``trophicLevel/Algivore`` = _prefix "trophicLevel/Algivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Autotroph"></see>
    /// </summary>
    let ``trophicLevel/Autotroph`` = _prefix "trophicLevel/Autotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Carnivore"></see>
    /// </summary>
    let ``trophicLevel/Carnivore`` = _prefix "trophicLevel/Carnivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Chemoautotroph"></see>
    /// </summary>
    let ``trophicLevel/Chemoautotroph`` = _prefix "trophicLevel/Chemoautotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Coprophage"></see>
    /// </summary>
    let ``trophicLevel/Coprophage`` = _prefix "trophicLevel/Coprophage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Decomposer"></see>
    /// </summary>
    let ``trophicLevel/Decomposer`` = _prefix "trophicLevel/Decomposer"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Detritivore"></see>
    /// </summary>
    let ``trophicLevel/Detritivore`` = _prefix "trophicLevel/Detritivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Florivore"></see>
    /// </summary>
    let ``trophicLevel/Florivore`` = _prefix "trophicLevel/Florivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Folivore"></see>
    /// </summary>
    let ``trophicLevel/Folivore`` = _prefix "trophicLevel/Folivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Frugivore"></see>
    /// </summary>
    let ``trophicLevel/Frugivore`` = _prefix "trophicLevel/Frugivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Fungivore"></see>
    /// </summary>
    let ``trophicLevel/Fungivore`` = _prefix "trophicLevel/Fungivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Graminivore"></see>
    /// </summary>
    let ``trophicLevel/Graminivore`` = _prefix "trophicLevel/Graminivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Granivore"></see>
    /// </summary>
    let ``trophicLevel/Granivore`` = _prefix "trophicLevel/Granivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Herbivore"></see>
    /// </summary>
    let ``trophicLevel/Herbivore`` = _prefix "trophicLevel/Herbivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Heterotroph"></see>
    /// </summary>
    let ``trophicLevel/Heterotroph`` = _prefix "trophicLevel/Heterotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Nectarivore"></see>
    /// </summary>
    let ``trophicLevel/Nectarivore`` = _prefix "trophicLevel/Nectarivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Palynivore"></see>
    /// </summary>
    let ``trophicLevel/Palynivore`` = _prefix "trophicLevel/Palynivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Photoautotroph"></see>
    /// </summary>
    let ``trophicLevel/Photoautotroph`` = _prefix "trophicLevel/Photoautotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Predator"></see>
    /// </summary>
    let ``trophicLevel/Predator`` = _prefix "trophicLevel/Predator"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Rhizovore"></see>
    /// </summary>
    let ``trophicLevel/Rhizovore`` = _prefix "trophicLevel/Rhizovore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Saprotroph"></see>
    /// </summary>
    let ``trophicLevel/Saprotroph`` = _prefix "trophicLevel/Saprotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Saproxylotroph"></see>
    /// </summary>
    let ``trophicLevel/Saproxylotroph`` = _prefix "trophicLevel/Saproxylotroph"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Scavenger"></see>
    /// </summary>
    let ``trophicLevel/Scavenger`` = _prefix "trophicLevel/Scavenger"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/TrophicLevelCollection"></see>
    /// </summary>
    let ``trophicLevel/TrophicLevelCollection`` =
        _prefix "trophicLevel/TrophicLevelCollection"

    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Xylophage"></see>
    /// </summary>
    let ``trophicLevel/Xylophage`` = _prefix "trophicLevel/Xylophage"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Xylofungivore"></see>
    /// </summary>
    let ``trophicLevel/Xylofungivore`` = _prefix "trophicLevel/Xylofungivore"
    /// <summary>
    ///   <see href="http://taxref.mnhn.fr/lod/trophicLevel/Unknown"></see>
    /// </summary>
    let ``trophicLevel/Unknown`` = _prefix "trophicLevel/Unknown"
