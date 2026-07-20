namespace http.rdf.geospecies.org.ont.geospecies.hash

open DoxAletheia

module geospecies =
    let _namespace_name = "http://rdf.geospecies.org/ont/geospecies#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_BioCode"></see>
    /// </summary>
    let NomenclaturalCode_BioCode = _prefix "NomenclaturalCode_BioCode"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICBN"></see>
    /// </summary>
    let NomenclaturalCode_ICBN = _prefix "NomenclaturalCode_ICBN"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNB"></see>
    /// </summary>
    let NomenclaturalCode_ICNB = _prefix "NomenclaturalCode_ICNB"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNCP"></see>
    /// </summary>
    let NomenclaturalCode_ICNCP = _prefix "NomenclaturalCode_ICNCP"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICTV"></see>
    /// </summary>
    let NomenclaturalCode_ICTV = _prefix "NomenclaturalCode_ICTV"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICZN"></see>
    /// </summary>
    let NomenclaturalCode_ICZN = _prefix "NomenclaturalCode_ICZN"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Garden_persistent"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Garden_persistent =
        _prefix "USDA_Native_Status_Introduced_Garden_persistent"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Introduced =
        _prefix "USDA_Native_Status_Introduced_Introduced"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Garden_persistent"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Garden_persistent =
        _prefix "USDA_Native_Status_Introduced_Probably_Garden_persistent"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Introduced =
        _prefix "USDA_Native_Status_Introduced_Probably_Introduced"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Native_and_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Native_and_Introduced =
        _prefix "USDA_Native_Status_Introduced_Probably_Native_and_Introduced"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_a_Waif"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_a_Waif =
        _prefix "USDA_Native_Status_Introduced_Probably_a_Waif"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Waif"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Waif =
        _prefix "USDA_Native_Status_Introduced_Waif"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native = _prefix "USDA_Native_Status_Native_Native"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native_and_Introduced =
        _prefix "USDA_Native_Status_Native_Native_and_Introduced"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Probably_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native_and_Probably_Introduced =
        _prefix "USDA_Native_Status_Native_Native_and_Probably_Introduced"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Probably_Native"></see>
    /// </summary>
    let USDA_Native_Status_Native_Probably_Native =
        _prefix "USDA_Native_Status_Native_Probably_Native"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_introduced"></see>
    /// </summary>
    let nativeness_introduced = _prefix "nativeness_introduced"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_invasive"></see>
    /// </summary>
    let nativeness_invasive = _prefix "nativeness_invasive"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_managed"></see>
    /// </summary>
    let nativeness_managed = _prefix "nativeness_managed"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_native"></see>
    /// </summary>
    let nativeness_native = _prefix "nativeness_native"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_naturalised"></see>
    /// </summary>
    let nativeness_naturalised = _prefix "nativeness_naturalised"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_47g_Prairie_Pothole_Region_"></see>
    /// </summary>
    let Omernik_4_47g_Prairie_Pothole_Region_ =
        _prefix "Omernik_4_47g_Prairie_Pothole_Region_"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_50a_Lake_Superior_Clay_Plain"></see>
    /// </summary>
    let Omernik_4_50a_Lake_Superior_Clay_Plain =
        _prefix "Omernik_4_50a_Lake_Superior_Clay_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines"></see>
    /// </summary>
    let ``Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines`` =
        _prefix "Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain"></see>
    /// </summary>
    let Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain =
        _prefix "Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain"></see>
    /// </summary>
    let Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain =
        _prefix "Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51d_Central_Sand_Ridges"></see>
    /// </summary>
    let Omernik_4_51d_Central_Sand_Ridges = _prefix "Omernik_4_51d_Central_Sand_Ridges"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine"></see>
    /// </summary>
    let Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine =
        _prefix "Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain"></see>
    /// </summary>
    let Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain =
        _prefix "Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51g_Door_Peninsula"></see>
    /// </summary>
    let Omernik_4_51g_Door_Peninsula = _prefix "Omernik_4_51g_Door_Peninsula"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52a_Savanna_Section"></see>
    /// </summary>
    let Omernik_4_52a_Savanna_Section = _prefix "Omernik_4_52a_Savanna_Section"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52b_Coulee_Section"></see>
    /// </summary>
    let Omernik_4_52b_Coulee_Section = _prefix "Omernik_4_52b_Coulee_Section"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53a_Rock_River_Drift_Plain"></see>
    /// </summary>
    let Omernik_4_53a_Rock_River_Drift_Plain =
        _prefix "Omernik_4_53a_Rock_River_Drift_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53b_Kettle_Moraines"></see>
    /// </summary>
    let Omernik_4_53b_Kettle_Moraines = _prefix "Omernik_4_53b_Kettle_Moraines"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain"></see>
    /// </summary>
    let Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain =
        _prefix "Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain"></see>
    /// </summary>
    let Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain =
        _prefix "Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_54e_Chiwaukee_Prairie_Region"></see>
    /// </summary>
    let Omernik_4_54e_Chiwaukee_Prairie_Region =
        _prefix "Omernik_4_54e_Chiwaukee_Prairie_Region"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_female"></see>
    /// </summary>
    let Sex_female = _prefix "Sex_female"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_hermaphrodite"></see>
    /// </summary>
    let Sex_hermaphrodite = _prefix "Sex_hermaphrodite"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_male"></see>
    /// </summary>
    let Sex_male = _prefix "Sex_male"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_undetermined"></see>
    /// </summary>
    let Sex_undetermined = _prefix "Sex_undetermined"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_unknowable"></see>
    /// </summary>
    let Sex_unknowable = _prefix "Sex_unknowable"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_47_Western_Corn_Belt_Plains"></see>
    /// </summary>
    let Omernik_3_47_Western_Corn_Belt_Plains =
        _prefix "Omernik_3_47_Western_Corn_Belt_Plains"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_50_Northern_Lakes_and_Forests"></see>
    /// </summary>
    let Omernik_3_50_Northern_Lakes_and_Forests =
        _prefix "Omernik_3_50_Northern_Lakes_and_Forests"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_51_North_Central_Hardwood_Forests"></see>
    /// </summary>
    let Omernik_3_51_North_Central_Hardwood_Forests =
        _prefix "Omernik_3_51_North_Central_Hardwood_Forests"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_52_Driftless_Area"></see>
    /// </summary>
    let Omernik_3_52_Driftless_Area = _prefix "Omernik_3_52_Driftless_Area"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_53_Southeastern_Wisconsin_Till_Plains"></see>
    /// </summary>
    let Omernik_3_53_Southeastern_Wisconsin_Till_Plains =
        _prefix "Omernik_3_53_Southeastern_Wisconsin_Till_Plains"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_54_Central_Corn_Belt_Plains"></see>
    /// </summary>
    let Omernik_3_54_Central_Corn_Belt_Plains =
        _prefix "Omernik_3_54_Central_Corn_Belt_Plains"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Beech_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Beech_Forest = _prefix "Wisconsin_Herbarium_Beech_Forest"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bog_and_Fen"></see>
    /// </summary>
    let Wisconsin_Herbarium_Bog_and_Fen = _prefix "Wisconsin_Herbarium_Bog_and_Fen"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Boreal_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Boreal_Forest = _prefix "Wisconsin_Herbarium_Boreal_Forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bracken_Grassland"></see>
    /// </summary>
    let Wisconsin_Herbarium_Bracken_Grassland =
        _prefix "Wisconsin_Herbarium_Bracken_Grassland"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Cliff"></see>
    /// </summary>
    let Wisconsin_Herbarium_Cliff = _prefix "Wisconsin_Herbarium_Cliff"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Emergent_Aquatic"></see>
    /// </summary>
    let Wisconsin_Herbarium_Emergent_Aquatic =
        _prefix "Wisconsin_Herbarium_Emergent_Aquatic"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Lowland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Northern_Lowland_Forest =
        _prefix "Wisconsin_Herbarium_Northern_Lowland_Forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Upland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Northern_Upland_Forest =
        _prefix "Wisconsin_Herbarium_Northern_Upland_Forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Pine_Barrens"></see>
    /// </summary>
    let Wisconsin_Herbarium_Pine_Barrens = _prefix "Wisconsin_Herbarium_Pine_Barrens"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Prairie"></see>
    /// </summary>
    let Wisconsin_Herbarium_Prairie = _prefix "Wisconsin_Herbarium_Prairie"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Barrens"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sand_Barrens = _prefix "Wisconsin_Herbarium_Sand_Barrens"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Dunes"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sand_Dunes = _prefix "Wisconsin_Herbarium_Sand_Dunes"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Savanna"></see>
    /// </summary>
    let Wisconsin_Herbarium_Savanna = _prefix "Wisconsin_Herbarium_Savanna"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sedge_Meadow"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sedge_Meadow = _prefix "Wisconsin_Herbarium_Sedge_Meadow"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Shrub_Carr"></see>
    /// </summary>
    let Wisconsin_Herbarium_Shrub_Carr = _prefix "Wisconsin_Herbarium_Shrub_Carr"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Lowland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Southern_Lowland_Forest =
        _prefix "Wisconsin_Herbarium_Southern_Lowland_Forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Upland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Southern_Upland_Forest =
        _prefix "Wisconsin_Herbarium_Southern_Upland_Forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_accepted"></see>
    /// </summary>
    let TaxonomicStatus_accepted = _prefix "TaxonomicStatus_accepted"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_heterotypicSynonym"></see>
    /// </summary>
    let TaxonomicStatus_heterotypicSynonym =
        _prefix "TaxonomicStatus_heterotypicSynonym"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_homotypicSynonym"></see>
    /// </summary>
    let TaxonomicStatus_homotypicSynonym = _prefix "TaxonomicStatus_homotypicSynonym"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_invalid"></see>
    /// </summary>
    let TaxonomicStatus_invalid = _prefix "TaxonomicStatus_invalid"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_misapplied"></see>
    /// </summary>
    let TaxonomicStatus_misapplied = _prefix "TaxonomicStatus_misapplied"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_proParteSynonym"></see>
    /// </summary>
    let TaxonomicStatus_proParteSynonym = _prefix "TaxonomicStatus_proParteSynonym"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_synonym"></see>
    /// </summary>
    let TaxonomicStatus_synonym = _prefix "TaxonomicStatus_synonym"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unaccepted"></see>
    /// </summary>
    let TaxonomicStatus_unaccepted = _prefix "TaxonomicStatus_unaccepted"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unverified"></see>
    /// </summary>
    let TaxonomicStatus_unverified = _prefix "TaxonomicStatus_unverified"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#PhotoCollection"></see>
    /// </summary>
    let PhotoCollection = _prefix "PhotoCollection"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Observation"></see>
    /// </summary>
    let Observation = _prefix "Observation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex"></see>
    /// </summary>
    let Sex = _prefix "Sex"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#IndividualOrganism"></see>
    /// </summary>
    let IndividualOrganism = _prefix "IndividualOrganism"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonConcept"></see>
    /// </summary>
    let TaxonConcept = _prefix "TaxonConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ObservationMethod"></see>
    /// </summary>
    let ObservationMethod = _prefix "ObservationMethod"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBCPage"></see>
    /// </summary>
    let BBCPage = _prefix "BBCPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone"></see>
    /// </summary>
    let BBC_Ecozone = _prefix "BBC_Ecozone"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Ecozone"></see>
    /// </summary>
    let Ecozone = _prefix "Ecozone"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Afrotropics"></see>
    /// </summary>
    let BBC_Ecozone_Afrotropics = _prefix "BBC_Ecozone_Afrotropics"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Antarctica"></see>
    /// </summary>
    let BBC_Ecozone_Antarctica = _prefix "BBC_Ecozone_Antarctica"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Australasia"></see>
    /// </summary>
    let BBC_Ecozone_Australasia = _prefix "BBC_Ecozone_Australasia"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Indo-Malay"></see>
    /// </summary>
    let ``BBC_Ecozone_Indo-Malay`` = _prefix "BBC_Ecozone_Indo-Malay"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Nearctic"></see>
    /// </summary>
    let BBC_Ecozone_Nearctic = _prefix "BBC_Ecozone_Nearctic"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Neotropical"></see>
    /// </summary>
    let BBC_Ecozone_Neotropical = _prefix "BBC_Ecozone_Neotropical"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Oceania"></see>
    /// </summary>
    let BBC_Ecozone_Oceania = _prefix "BBC_Ecozone_Oceania"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Palaearctic"></see>
    /// </summary>
    let BBC_Ecozone_Palaearctic = _prefix "BBC_Ecozone_Palaearctic"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat"></see>
    /// </summary>
    let BBC_Freshwater_Habitat = _prefix "BBC_Freshwater_Habitat"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Habitat_Classification"></see>
    /// </summary>
    let BBC_Habitat_Classification = _prefix "BBC_Habitat_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Brackish_water"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Brackish_water =
        _prefix "BBC_Freshwater_Habitat_Brackish_water"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Lakes_and_ponds"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Lakes_and_ponds =
        _prefix "BBC_Freshwater_Habitat_Lakes_and_ponds"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Marsh"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Marsh = _prefix "BBC_Freshwater_Habitat_Marsh"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Rivers_and_streams"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Rivers_and_streams =
        _prefix "BBC_Freshwater_Habitat_Rivers_and_streams"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Swamp"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Swamp = _prefix "BBC_Freshwater_Habitat_Swamp"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Temporary_pools"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Temporary_pools =
        _prefix "BBC_Freshwater_Habitat_Temporary_pools"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Wetlands"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Wetlands = _prefix "BBC_Freshwater_Habitat_Wetlands"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Habitat_Classification"></see>
    /// </summary>
    let Habitat_Classification = _prefix "Habitat_Classification"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat"></see>
    /// </summary>
    let BBC_Marine_Habitat = _prefix "BBC_Marine_Habitat"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Deep_ocean"></see>
    /// </summary>
    let BBC_Marine_Habitat_Deep_ocean = _prefix "BBC_Marine_Habitat_Deep_ocean"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Estuaries"></see>
    /// </summary>
    let BBC_Marine_Habitat_Estuaries = _prefix "BBC_Marine_Habitat_Estuaries"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Hydrothermal_vents"></see>
    /// </summary>
    let BBC_Marine_Habitat_Hydrothermal_vents =
        _prefix "BBC_Marine_Habitat_Hydrothermal_vents"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Open_ocean"></see>
    /// </summary>
    let BBC_Marine_Habitat_Open_ocean = _prefix "BBC_Marine_Habitat_Open_ocean"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Reefs"></see>
    /// </summary>
    let BBC_Marine_Habitat_Reefs = _prefix "BBC_Marine_Habitat_Reefs"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Sea_bed"></see>
    /// </summary>
    let BBC_Marine_Habitat_Sea_bed = _prefix "BBC_Marine_Habitat_Sea_bed"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Shallow_seas"></see>
    /// </summary>
    let BBC_Marine_Habitat_Shallow_seas = _prefix "BBC_Marine_Habitat_Shallow_seas"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat = _prefix "BBC_Terrestrial_Habitat"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Broadleaf_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Broadleaf_forest =
        _prefix "BBC_Terrestrial_Habitat_Broadleaf_forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coastal"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Coastal = _prefix "BBC_Terrestrial_Habitat_Coastal"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coniferous_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Coniferous_forest =
        _prefix "BBC_Terrestrial_Habitat_Coniferous_forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Desert"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Desert = _prefix "BBC_Terrestrial_Habitat_Desert"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Flooded_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Flooded_grassland =
        _prefix "BBC_Terrestrial_Habitat_Flooded_grassland"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mangroves"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mangroves = _prefix "BBC_Terrestrial_Habitat_Mangroves"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mediterranean_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mediterranean_forest =
        _prefix "BBC_Terrestrial_Habitat_Mediterranean_forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mountain_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mountain_grassland =
        _prefix "BBC_Terrestrial_Habitat_Mountain_grassland"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Polar"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Polar = _prefix "BBC_Terrestrial_Habitat_Polar"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Rainforest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Rainforest =
        _prefix "BBC_Terrestrial_Habitat_Rainforest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Taiga"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Taiga = _prefix "BBC_Terrestrial_Habitat_Taiga"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Temperate_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Temperate_grassland =
        _prefix "BBC_Terrestrial_Habitat_Temperate_grassland"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_coniferous_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_coniferous_forest =
        _prefix "BBC_Terrestrial_Habitat_Tropical_coniferous_forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_dry_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_dry_forest =
        _prefix "BBC_Terrestrial_Habitat_Tropical_dry_forest"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_grassland =
        _prefix "BBC_Terrestrial_Habitat_Tropical_grassland"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord"></see>
    /// </summary>
    let BasisOfRecord = _prefix "BasisOfRecord"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_FossilSpecimen"></see>
    /// </summary>
    let BasisOfRecord_FossilSpecimen = _prefix "BasisOfRecord_FossilSpecimen"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_HumanObservation"></see>
    /// </summary>
    let BasisOfRecord_HumanObservation = _prefix "BasisOfRecord_HumanObservation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_LivingSpecimen"></see>
    /// </summary>
    let BasisOfRecord_LivingSpecimen = _prefix "BasisOfRecord_LivingSpecimen"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MachineObservation"></see>
    /// </summary>
    let BasisOfRecord_MachineObservation = _prefix "BasisOfRecord_MachineObservation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MovingImage"></see>
    /// </summary>
    let BasisOfRecord_MovingImage = _prefix "BasisOfRecord_MovingImage"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_NomenclaturalChecklist"></see>
    /// </summary>
    let BasisOfRecord_NomenclaturalChecklist =
        _prefix "BasisOfRecord_NomenclaturalChecklist"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_PreservedSpecimen"></see>
    /// </summary>
    let BasisOfRecord_PreservedSpecimen = _prefix "BasisOfRecord_PreservedSpecimen"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_Sound"></see>
    /// </summary>
    let BasisOfRecord_Sound = _prefix "BasisOfRecord_Sound"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_StillImage"></see>
    /// </summary>
    let BasisOfRecord_StillImage = _prefix "BasisOfRecord_StillImage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Bio2RDFtaxon"></see>
    /// </summary>
    let Bio2RDFtaxon = _prefix "Bio2RDFtaxon"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BioLibPage"></see>
    /// </summary>
    let BioLibPage = _prefix "BioLibPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BugGuidePage"></see>
    /// </summary>
    let BugGuidePage = _prefix "BugGuidePage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ClassConcept"></see>
    /// </summary>
    let ClassConcept = _prefix "ClassConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#CoL_LSID"></see>
    /// </summary>
    let CoL_LSID = _prefix "CoL_LSID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LSID"></see>
    /// </summary>
    let LSID = _prefix "LSID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Continent"></see>
    /// </summary>
    let Continent = _prefix "Continent"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#DBpediaResource"></see>
    /// </summary>
    let DBpediaResource = _prefix "DBpediaResource"
    /// <summary>
    /// A Darwin Point is an occurrence location that meets the DarwinCore specifications for longitude, latitude, datum, extent, etc as described in "Guide to Best Practices for Georeferencing"
    /// <see href="http://rdf.geospecies.org/ont/geospecies#DarwinPoint"></see></summary>
    let DarwinPoint = _prefix "DarwinPoint"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#EoLPage"></see>
    /// </summary>
    let EoLPage = _prefix "EoLPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#FamilyConcept"></see>
    /// </summary>
    let FamilyConcept = _prefix "FamilyConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#FreebaseGUID"></see>
    /// </summary>
    let FreebaseGUID = _prefix "FreebaseGUID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GBIFPage"></see>
    /// </summary>
    let GBIFPage = _prefix "GBIFPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesPage"></see>
    /// </summary>
    let GeoSpeciesPage = _prefix "GeoSpeciesPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesScheme"></see>
    /// </summary>
    let GeoSpeciesScheme = _prefix "GeoSpeciesScheme"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpecies_Knowledge_Base_Project"></see>
    /// </summary>
    let GeoSpecies_Knowledge_Base_Project = _prefix "GeoSpecies_Knowledge_Base_Project"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum"></see>
    /// </summary>
    let GeodeticDatum = _prefix "GeodeticDatum"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD27"></see>
    /// </summary>
    let GeodeticDatum_NAD27 = _prefix "GeodeticDatum_NAD27"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD83"></see>
    /// </summary>
    let GeodeticDatum_NAD83 = _prefix "GeodeticDatum_NAD83"
    /// <summary>
    /// The Geodetic Datum WGS84
    /// <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_WGS84"></see></summary>
    let GeodeticDatum_WGS84 = _prefix "GeodeticDatum_WGS84"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ITISPage"></see>
    /// </summary>
    let ITISPage = _prefix "ITISPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#IUCN_Habitat_Classification"></see>
    /// </summary>
    let IUCN_Habitat_Classification = _prefix "IUCN_Habitat_Classification"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#KingdomConcept"></see>
    /// </summary>
    let KingdomConcept = _prefix "KingdomConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LifeForm"></see>
    /// </summary>
    let LifeForm = _prefix "LifeForm"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LifeStage"></see>
    /// </summary>
    let LifeStage = _prefix "LifeStage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Locality"></see>
    /// </summary>
    let Locality = _prefix "Locality"
    /// <summary>
    /// A location, would be a subclass of geonames feature, but it will not always have a geonames feature id
    /// <see href="http://rdf.geospecies.org/ont/geospecies#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Above_Ground_Sticky_Trap"></see>
    /// </summary>
    let Method_Above_Ground_Sticky_Trap = _prefix "Method_Above_Ground_Sticky_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Aerial_Collection_Net"></see>
    /// </summary>
    let Method_Aerial_Collection_Net = _prefix "Method_Aerial_Collection_Net"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Barrier_Trap"></see>
    /// </summary>
    let Method_Barrier_Trap = _prefix "Method_Barrier_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Berlese_Sample"></see>
    /// </summary>
    let Method_Berlese_Sample = _prefix "Method_Berlese_Sample"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_CO2_Suction_Trap"></see>
    /// </summary>
    let Method_CO2_Suction_Trap = _prefix "Method_CO2_Suction_Trap"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Cantharidin_Baited_Jar_Trap"></see>
    /// </summary>
    let Method_Cantharidin_Baited_Jar_Trap =
        _prefix "Method_Cantharidin_Baited_Jar_Trap"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Chicken_Mash_Baited_Trap"></see>
    /// </summary>
    let Method_Chicken_Mash_Baited_Trap = _prefix "Method_Chicken_Mash_Baited_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Flight_Intercept_Trap"></see>
    /// </summary>
    let Method_Flight_Intercept_Trap = _prefix "Method_Flight_Intercept_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Ground_Based_Sticky_Trap"></see>
    /// </summary>
    let Method_Ground_Based_Sticky_Trap = _prefix "Method_Ground_Based_Sticky_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected"></see>
    /// </summary>
    let Method_Hand_Collected = _prefix "Method_Hand_Collected"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected_and_Released"></see>
    /// </summary>
    let Method_Hand_Collected_and_Released =
        _prefix "Method_Hand_Collected_and_Released"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Bite_Collection"></see>
    /// </summary>
    let Method_Human_Bite_Collection = _prefix "Method_Human_Bite_Collection"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Observation"></see>
    /// </summary>
    let Method_Human_Observation = _prefix "Method_Human_Observation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Light_and_CO2_Suction_Trap"></see>
    /// </summary>
    let Method_Light_and_CO2_Suction_Trap = _prefix "Method_Light_and_CO2_Suction_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Malaise_Trap"></see>
    /// </summary>
    let Method_Malaise_Trap = _prefix "Method_Malaise_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Photographed"></see>
    /// </summary>
    let Method_Photographed = _prefix "Method_Photographed"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Pitfall_Trap"></see>
    /// </summary>
    let Method_Pitfall_Trap = _prefix "Method_Pitfall_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Sweep_Net"></see>
    /// </summary>
    let Method_Sweep_Net = _prefix "Method_Sweep_Net"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_UV_Light_Trap"></see>
    /// </summary>
    let Method_UV_Light_Trap = _prefix "Method_UV_Light_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Vacuum_Collector"></see>
    /// </summary>
    let Method_Vacuum_Collector = _prefix "Method_Vacuum_Collector"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Visible_Light_Trap"></see>
    /// </summary>
    let Method_Visible_Light_Trap = _prefix "Method_Visible_Light_Trap"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Nativeness"></see>
    /// </summary>
    let Nativeness = _prefix "Nativeness"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode"></see>
    /// </summary>
    let NomenclaturalCode = _prefix "NomenclaturalCode"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICVCN"></see>
    /// </summary>
    let NomenclaturalCode_ICVCN = _prefix "NomenclaturalCode_ICVCN"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus"></see>
    /// </summary>
    let OccurrenceStatus = _prefix "OccurrenceStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_absent"></see>
    /// </summary>
    let OccurrenceStatus_absent = _prefix "OccurrenceStatus_absent"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_common"></see>
    /// </summary>
    let OccurrenceStatus_common = _prefix "OccurrenceStatus_common"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_doubtful"></see>
    /// </summary>
    let OccurrenceStatus_doubtful = _prefix "OccurrenceStatus_doubtful"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_irregular"></see>
    /// </summary>
    let OccurrenceStatus_irregular = _prefix "OccurrenceStatus_irregular"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_present"></see>
    /// </summary>
    let OccurrenceStatus_present = _prefix "OccurrenceStatus_present"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_rare"></see>
    /// </summary>
    let OccurrenceStatus_rare = _prefix "OccurrenceStatus_rare"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_III_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Level_III_Ecoregion_Classification =
        _prefix "Omernik_Level_III_Ecoregion_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Ecoregion_Classification = _prefix "Omernik_Ecoregion_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_IV_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Level_IV_Ecoregion_Classification =
        _prefix "Omernik_Level_IV_Ecoregion_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OpenCycConcept"></see>
    /// </summary>
    let OpenCycConcept = _prefix "OpenCycConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OrderConcept"></see>
    /// </summary>
    let OrderConcept = _prefix "OrderConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#PhylumConcept"></see>
    /// </summary>
    let PhylumConcept = _prefix "PhylumConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#SpeciesConcept"></see>
    /// </summary>
    let SpeciesConcept = _prefix "SpeciesConcept"
    /// <summary>
    /// State or Province
    /// <see href="http://rdf.geospecies.org/ont/geospecies#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank"></see>
    /// </summary>
    let TaxonRank = _prefix "TaxonRank"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_class"></see>
    /// </summary>
    let TaxonRank_class = _prefix "TaxonRank_class"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivar"></see>
    /// </summary>
    let TaxonRank_cultivar = _prefix "TaxonRank_cultivar"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivarGroup"></see>
    /// </summary>
    let TaxonRank_cultivarGroup = _prefix "TaxonRank_cultivarGroup"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_domain"></see>
    /// </summary>
    let TaxonRank_domain = _prefix "TaxonRank_domain"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_family"></see>
    /// </summary>
    let TaxonRank_family = _prefix "TaxonRank_family"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_form"></see>
    /// </summary>
    let TaxonRank_form = _prefix "TaxonRank_form"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_genus"></see>
    /// </summary>
    let TaxonRank_genus = _prefix "TaxonRank_genus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_infraorder"></see>
    /// </summary>
    let TaxonRank_infraorder = _prefix "TaxonRank_infraorder"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_kingdom"></see>
    /// </summary>
    let TaxonRank_kingdom = _prefix "TaxonRank_kingdom"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_order"></see>
    /// </summary>
    let TaxonRank_order = _prefix "TaxonRank_order"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_phylum"></see>
    /// </summary>
    let TaxonRank_phylum = _prefix "TaxonRank_phylum"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_section"></see>
    /// </summary>
    let TaxonRank_section = _prefix "TaxonRank_section"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_species"></see>
    /// </summary>
    let TaxonRank_species = _prefix "TaxonRank_species"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_speciesAggregate"></see>
    /// </summary>
    let TaxonRank_speciesAggregate = _prefix "TaxonRank_speciesAggregate"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subclass"></see>
    /// </summary>
    let TaxonRank_subclass = _prefix "TaxonRank_subclass"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subfamily"></see>
    /// </summary>
    let TaxonRank_subfamily = _prefix "TaxonRank_subfamily"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subform"></see>
    /// </summary>
    let TaxonRank_subform = _prefix "TaxonRank_subform"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subgenus"></see>
    /// </summary>
    let TaxonRank_subgenus = _prefix "TaxonRank_subgenus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subkingdom"></see>
    /// </summary>
    let TaxonRank_subkingdom = _prefix "TaxonRank_subkingdom"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_suborder"></see>
    /// </summary>
    let TaxonRank_suborder = _prefix "TaxonRank_suborder"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subphylum"></see>
    /// </summary>
    let TaxonRank_subphylum = _prefix "TaxonRank_subphylum"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subsection"></see>
    /// </summary>
    let TaxonRank_subsection = _prefix "TaxonRank_subsection"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecies"></see>
    /// </summary>
    let TaxonRank_subspecies = _prefix "TaxonRank_subspecies"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecificAggregate"></see>
    /// </summary>
    let TaxonRank_subspecificAggregate = _prefix "TaxonRank_subspecificAggregate"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subtribe"></see>
    /// </summary>
    let TaxonRank_subtribe = _prefix "TaxonRank_subtribe"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subvariety"></see>
    /// </summary>
    let TaxonRank_subvariety = _prefix "TaxonRank_subvariety"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superclass"></see>
    /// </summary>
    let TaxonRank_superclass = _prefix "TaxonRank_superclass"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superfamily"></see>
    /// </summary>
    let TaxonRank_superfamily = _prefix "TaxonRank_superfamily"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superorder"></see>
    /// </summary>
    let TaxonRank_superorder = _prefix "TaxonRank_superorder"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_tribe"></see>
    /// </summary>
    let TaxonRank_tribe = _prefix "TaxonRank_tribe"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_variety"></see>
    /// </summary>
    let TaxonRank_variety = _prefix "TaxonRank_variety"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus"></see>
    /// </summary>
    let TaxonomicStatus = _prefix "TaxonomicStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ThreatStatusIUCN"></see>
    /// </summary>
    let ThreatStatusIUCN = _prefix "ThreatStatusIUCN"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus"></see>
    /// </summary>
    let TypeStatus = _prefix "TypeStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_hapantotype"></see>
    /// </summary>
    let TypeStatus_hapantotype = _prefix "TypeStatus_hapantotype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_holotype"></see>
    /// </summary>
    let TypeStatus_holotype = _prefix "TypeStatus_holotype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_lectotype"></see>
    /// </summary>
    let TypeStatus_lectotype = _prefix "TypeStatus_lectotype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_neotype"></see>
    /// </summary>
    let TypeStatus_neotype = _prefix "TypeStatus_neotype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paralectotype"></see>
    /// </summary>
    let TypeStatus_paralectotype = _prefix "TypeStatus_paralectotype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paratype"></see>
    /// </summary>
    let TypeStatus_paratype = _prefix "TypeStatus_paratype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_syntype"></see>
    /// </summary>
    let TypeStatus_syntype = _prefix "TypeStatus_syntype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_varitype"></see>
    /// </summary>
    let TypeStatus_varitype = _prefix "TypeStatus_varitype"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit"></see>
    /// </summary>
    let USDA_Growth_Habit = _prefix "USDA_Growth_Habit"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Plant_Characteristics"></see>
    /// </summary>
    let USDA_Plant_Characteristics = _prefix "USDA_Plant_Characteristics"
    /// <summary>
    /// Applies to vascular plants only. Federal Geographic Data Committee (FGDC) definition includes graminoids, forbs, and ferns.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Forb_Herb"></see></summary>
    let USDA_Growth_Habit_Forb_Herb = _prefix "USDA_Growth_Habit_Forb_Herb"
    /// <summary>
    /// Applies to vascular plants only. An herb in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Graminoid"></see></summary>
    let USDA_Growth_Habit_Graminoid = _prefix "USDA_Growth_Habit_Graminoid"
    /// <summary>
    /// Applies to vascular plants only. In PLANTS, mutually exclusive with VI (Vine). A shrub in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Liana"></see></summary>
    let USDA_Growth_Habit_Liana = _prefix "USDA_Growth_Habit_Liana"
    /// <summary>
    /// Applies to lichens only, which are not true plants.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Lichenous"></see></summary>
    let USDA_Growth_Habit_Lichenous = _prefix "USDA_Growth_Habit_Lichenous"
    /// <summary>
    /// Applies to non-vascular plants only; in PLANTS system this is groups HN (Hornworts), LV (Liverworts), and MS (Mosses).
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Nonvascular"></see></summary>
    let USDA_Growth_Habit_Nonvascular = _prefix "USDA_Growth_Habit_Nonvascular"
    /// <summary>
    /// Applies to vascular plants only.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Shrub"></see></summary>
    let USDA_Growth_Habit_Shrub = _prefix "USDA_Growth_Habit_Shrub"
    /// <summary>
    /// Applies to vascular plants only. A dwarf-shrub in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Subshrub"></see></summary>
    let USDA_Growth_Habit_Subshrub = _prefix "USDA_Growth_Habit_Subshrub"
    /// <summary>
    /// Applies to vascular plants only.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Tree"></see></summary>
    let USDA_Growth_Habit_Tree = _prefix "USDA_Growth_Habit_Tree"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Unknown"></see>
    /// </summary>
    let USDA_Growth_Habit_Unknown = _prefix "USDA_Growth_Habit_Unknown"
    /// <summary>
    /// Applies to vascular plants only. In PLANTS, mutually exclusive with LI (Liana). FGDC classification considers woody vines to be shrubs and herbaceous vines to be herbs.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Vine"></see></summary>
    let USDA_Growth_Habit_Vine = _prefix "USDA_Growth_Habit_Vine"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Jurisdiction_Code"></see>
    /// </summary>
    let USDA_Native_Jurisdiction_Code = _prefix "USDA_Native_Jurisdiction_Code"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status"></see>
    /// </summary>
    let USDA_Native_Status = _prefix "USDA_Native_Status"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#UUID"></see>
    /// </summary>
    let UUID = _prefix "UUID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Ubio_LSID"></see>
    /// </summary>
    let Ubio_LSID = _prefix "Ubio_LSID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#UniprotTaxon"></see>
    /// </summary>
    let UniprotTaxon = _prefix "UniprotTaxon"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#WikipediaArticle"></see>
    /// </summary>
    let WikipediaArticle = _prefix "WikipediaArticle"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#WikispeciesArticle"></see>
    /// </summary>
    let WikispeciesArticle = _prefix "WikispeciesArticle"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Habitat_Classification"></see>
    /// </summary>
    let Wisconsin_Herbarium_Habitat_Classification =
        _prefix "Wisconsin_Herbarium_Habitat_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Natural_Heritage_Inventory_Habitat_Classification"></see>
    /// </summary>
    let Wisconsin_Natural_Heritage_Inventory_Habitat_Classification =
        _prefix "Wisconsin_Natural_Heritage_Inventory_Habitat_Classification"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#World_Pyrochroidae_Database"></see>
    /// </summary>
    let World_Pyrochroidae_Database = _prefix "World_Pyrochroidae_Database"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#habitatHasSpeciesAssociation"></see>
    /// </summary>
    let habitatHasSpeciesAssociation = _prefix "habitatHasSpeciesAssociation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBCHabitatAssociation"></see>
    /// </summary>
    let hasBBCHabitatAssociation = _prefix "hasBBCHabitatAssociation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#speciesHasHabitatAssociation"></see>
    /// </summary>
    let speciesHasHabitatAssociation = _prefix "speciesHasHabitatAssociation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Ecozone"></see>
    /// </summary>
    let hasBBC_Ecozone = _prefix "hasBBC_Ecozone"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_EcozoneName"></see>
    /// </summary>
    let hasBBC_EcozoneName = _prefix "hasBBC_EcozoneName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Habitat"></see>
    /// </summary>
    let hasBBC_Habitat = _prefix "hasBBC_Habitat"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBasionymName"></see>
    /// </summary>
    let hasBasionymName = _prefix "hasBasionymName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBio2RDFtaxon"></see>
    /// </summary>
    let hasBio2RDFtaxon = _prefix "hasBio2RDFtaxon"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBioLib"></see>
    /// </summary>
    let hasBioLib = _prefix "hasBioLib"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBioLibPage"></see>
    /// </summary>
    let hasBioLibPage = _prefix "hasBioLibPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBugGuidePage"></see>
    /// </summary>
    let hasBugGuidePage = _prefix "hasBugGuidePage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCanonicalName"></see>
    /// </summary>
    let hasCanonicalName = _prefix "hasCanonicalName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasClassName"></see>
    /// </summary>
    let hasClassName = _prefix "hasClassName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCoL_LSID"></see>
    /// </summary>
    let hasCoL_LSID = _prefix "hasCoL_LSID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCollectionCode"></see>
    /// </summary>
    let hasCollectionCode = _prefix "hasCollectionCode"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCollector"></see>
    /// </summary>
    let hasCollector = _prefix "hasCollector"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCommonName"></see>
    /// </summary>
    let hasCommonName = _prefix "hasCommonName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasVernacularName"></see>
    /// </summary>
    let hasVernacularName = _prefix "hasVernacularName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasContinent"></see>
    /// </summary>
    let hasContinent = _prefix "hasContinent"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasContinentName"></see>
    /// </summary>
    let hasContinentName = _prefix "hasContinentName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountryCode"></see>
    /// </summary>
    let hasCountryCode = _prefix "hasCountryCode"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountryName"></see>
    /// </summary>
    let hasCountryName = _prefix "hasCountryName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCounty"></see>
    /// </summary>
    let hasCounty = _prefix "hasCounty"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountyName"></see>
    /// </summary>
    let hasCountyName = _prefix "hasCountyName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasDBpediaResource"></see>
    /// </summary>
    let hasDBpediaResource = _prefix "hasDBpediaResource"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEOLPage"></see>
    /// </summary>
    let hasEOLPage = _prefix "hasEOLPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEndDate"></see>
    /// </summary>
    let hasEndDate = _prefix "hasEndDate"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEndDayOfYear"></see>
    /// </summary>
    let hasEndDayOfYear = _prefix "hasEndDayOfYear"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasExpectationOf"></see>
    /// </summary>
    let hasExpectationOf = _prefix "hasExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFamilyInfoContributor"></see>
    /// </summary>
    let hasFamilyInfoContributor = _prefix "hasFamilyInfoContributor"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFamilyName"></see>
    /// </summary>
    let hasFamilyName = _prefix "hasFamilyName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFreebaseResource"></see>
    /// </summary>
    let hasFreebaseResource = _prefix "hasFreebaseResource"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGBIF"></see>
    /// </summary>
    let hasGBIF = _prefix "hasGBIF"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGBIFPage"></see>
    /// </summary>
    let hasGBIFPage = _prefix "hasGBIFPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGNI"></see>
    /// </summary>
    let hasGNI = _prefix "hasGNI"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGenusName"></see>
    /// </summary>
    let hasGenusName = _prefix "hasGenusName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGeoSpeciesConcept"></see>
    /// </summary>
    let hasGeoSpeciesConcept = _prefix "hasGeoSpeciesConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTaxonConcept"></see>
    /// </summary>
    let hasTaxonConcept = _prefix "hasTaxonConcept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGeodeticDatum"></see>
    /// </summary>
    let hasGeodeticDatum = _prefix "hasGeodeticDatum"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollector"></see>
    /// </summary>
    let hasHumanCollector = _prefix "hasHumanCollector"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollectorName"></see>
    /// </summary>
    let hasHumanCollectorName = _prefix "hasHumanCollectorName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifier"></see>
    /// </summary>
    let hasHumanIdentifier = _prefix "hasHumanIdentifier"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifierName"></see>
    /// </summary>
    let hasHumanIdentifierName = _prefix "hasHumanIdentifierName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasITIS"></see>
    /// </summary>
    let hasITIS = _prefix "hasITIS"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasITISPage"></see>
    /// </summary>
    let hasITISPage = _prefix "hasITISPage"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasInfraspecificEpithet"></see>
    /// </summary>
    let hasInfraspecificEpithet = _prefix "hasInfraspecificEpithet"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasKingdomName"></see>
    /// </summary>
    let hasKingdomName = _prefix "hasKingdomName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocality"></see>
    /// </summary>
    let hasLocality = _prefix "hasLocality"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocalityName"></see>
    /// </summary>
    let hasLocalityName = _prefix "hasLocalityName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocalityText"></see>
    /// </summary>
    let hasLocalityText = _prefix "hasLocalityText"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocationName"></see>
    /// </summary>
    let hasLocationName = _prefix "hasLocationName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocationText"></see>
    /// </summary>
    let hasLocationText = _prefix "hasLocationText"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLowExpectationOf"></see>
    /// </summary>
    let hasLowExpectationOf = _prefix "hasLowExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLowUSDA_ExpectationOf"></see>
    /// </summary>
    let hasLowUSDA_ExpectationOf = _prefix "hasLowUSDA_ExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNCBITaxonID"></see>
    /// </summary>
    let hasNCBITaxonID = _prefix "hasNCBITaxonID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNoUSDA_ExpectationOf"></see>
    /// </summary>
    let hasNoUSDA_ExpectationOf = _prefix "hasNoUSDA_ExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCode"></see>
    /// </summary>
    let hasNomenclaturalCode = _prefix "hasNomenclaturalCode"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCodeString"></see>
    /// </summary>
    let hasNomenclaturalCodeString = _prefix "hasNomenclaturalCodeString"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservation"></see>
    /// </summary>
    let hasObservation = _prefix "hasObservation"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservationMethod"></see>
    /// </summary>
    let hasObservationMethod = _prefix "hasObservationMethod"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservationOf"></see>
    /// </summary>
    let hasObservationOf = _prefix "hasObservationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOccurrenceStatus"></see>
    /// </summary>
    let hasOccurrenceStatus = _prefix "hasOccurrenceStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_3_Ecozone"></see>
    /// </summary>
    let hasOmernik_3_Ecozone = _prefix "hasOmernik_3_Ecozone"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_4_Ecozone"></see>
    /// </summary>
    let hasOmernik_4_Ecozone = _prefix "hasOmernik_4_Ecozone"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOrderName"></see>
    /// </summary>
    let hasOrderName = _prefix "hasOrderName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasPhylumName"></see>
    /// </summary>
    let hasPhylumName = _prefix "hasPhylumName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasProject"></see>
    /// </summary>
    let hasProject = _prefix "hasProject"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificName"></see>
    /// </summary>
    let hasScientificName = _prefix "hasScientificName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameAuthorship"></see>
    /// </summary>
    let hasScientificNameAuthorship = _prefix "hasScientificNameAuthorship"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameRank"></see>
    /// </summary>
    let hasScientificNameRank = _prefix "hasScientificNameRank"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSex"></see>
    /// </summary>
    let hasSex = _prefix "hasSex"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSpecies"></see>
    /// </summary>
    let hasSpecies = _prefix "hasSpecies"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSpecificEpithet"></see>
    /// </summary>
    let hasSpecificEpithet = _prefix "hasSpecificEpithet"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStartDate"></see>
    /// </summary>
    let hasStartDate = _prefix "hasStartDate"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStartDayOfYear"></see>
    /// </summary>
    let hasStartDayOfYear = _prefix "hasStartDayOfYear"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvName"></see>
    /// </summary>
    let hasStateProvName = _prefix "hasStateProvName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvince"></see>
    /// </summary>
    let hasStateProvince = _prefix "hasStateProvince"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvinceName"></see>
    /// </summary>
    let hasStateProvinceName = _prefix "hasStateProvinceName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSubfamilyName"></see>
    /// </summary>
    let hasSubfamilyName = _prefix "hasSubfamilyName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSubgenusName"></see>
    /// </summary>
    let hasSubgenusName = _prefix "hasSubgenusName"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTDWG_Concept"></see>
    /// </summary>
    let hasTDWG_Concept = _prefix "hasTDWG_Concept"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTaxonomicStatus"></see>
    /// </summary>
    let hasTaxonomicStatus = _prefix "hasTaxonomicStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTreeBaseID"></see>
    /// </summary>
    let hasTreeBaseID = _prefix "hasTreeBaseID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTypeStatus"></see>
    /// </summary>
    let hasTypeStatus = _prefix "hasTypeStatus"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUSDA_ExpectationOf"></see>
    /// </summary>
    let hasUSDA_ExpectationOf = _prefix "hasUSDA_ExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUUID"></see>
    /// </summary>
    let hasUUID = _prefix "hasUUID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUbio_LSID"></see>
    /// </summary>
    let hasUbio_LSID = _prefix "hasUbio_LSID"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUnknownExpectationOf"></see>
    /// </summary>
    let hasUnknownExpectationOf = _prefix "hasUnknownExpectationOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWI_Herbarium_Habitat"></see>
    /// </summary>
    let hasWI_Herbarium_Habitat = _prefix "hasWI_Herbarium_Habitat"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle = _prefix "hasWikipediaArticle"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWikispeciesArticle"></see>
    /// </summary>
    let hasWikispeciesArticle = _prefix "hasWikispeciesArticle"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatAssociation"></see>
    /// </summary>
    let hasWisconsinHerbariumHabitatAssociation =
        _prefix "hasWisconsinHerbariumHabitatAssociation"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatPreference"></see>
    /// </summary>
    let hasWisconsinHerbariumHabitatPreference =
        _prefix "hasWisconsinHerbariumHabitatPreference"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumSpeciesAssociation"></see>
    /// </summary>
    let hasWisconsinHerbariumSpeciesAssociation =
        _prefix "hasWisconsinHerbariumSpeciesAssociation"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Growth_Habit"></see>
    /// </summary>
    let has_USDA_Growth_Habit = _prefix "has_USDA_Growth_Habit"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Native_Status"></see>
    /// </summary>
    let has_USDA_Native_Status = _prefix "has_USDA_Native_Status"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inClass"></see>
    /// </summary>
    let inClass = _prefix "inClass"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inFamily"></see>
    /// </summary>
    let inFamily = _prefix "inFamily"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inKingdom"></see>
    /// </summary>
    let inKingdom = _prefix "inKingdom"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inOrder"></see>
    /// </summary>
    let inOrder = _prefix "inOrder"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inPhylum"></see>
    /// </summary>
    let inPhylum = _prefix "inPhylum"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isBugGuidePageOf"></see>
    /// </summary>
    let isBugGuidePageOf = _prefix "isBugGuidePageOf"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isExpectedIn"></see>
    /// </summary>
    let isExpectedIn = _prefix "isExpectedIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isNotUSDA_ExpectedIn"></see>
    /// </summary>
    let isNotUSDA_ExpectedIn = _prefix "isNotUSDA_ExpectedIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUnexpectedIn"></see>
    /// </summary>
    let isUnexpectedIn = _prefix "isUnexpectedIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUSDA_ExpectedIn"></see>
    /// </summary>
    let isUSDA_ExpectedIn = _prefix "isUSDA_ExpectedIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUSDA_UnexpectedIn"></see>
    /// </summary>
    let isUSDA_UnexpectedIn = _prefix "isUSDA_UnexpectedIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUnknownAboutIn"></see>
    /// </summary>
    let isUnknownAboutIn = _prefix "isUnknownAboutIn"
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#wasObservedIn"></see>
    /// </summary>
    let wasObservedIn = _prefix "wasObservedIn"
