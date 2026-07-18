namespace http.rdf.geospecies.org.ont.geospecies.hash

open DoxAletheia.Rdf_Vocabulary

module geospecies =
    let _namespace_name = "http://rdf.geospecies.org/ont/geospecies#"

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_BioCode"></see>
    /// </summary>
    let NomenclaturalCode_BioCode =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_BioCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICBN"></see>
    /// </summary>
    let NomenclaturalCode_ICBN =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICBN" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNB"></see>
    /// </summary>
    let NomenclaturalCode_ICNB =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICNB" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNCP"></see>
    /// </summary>
    let NomenclaturalCode_ICNCP =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICNCP" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICTV"></see>
    /// </summary>
    let NomenclaturalCode_ICTV =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICTV" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICZN"></see>
    /// </summary>
    let NomenclaturalCode_ICZN =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICZN" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Garden_persistent"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Garden_persistent =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Garden_persistent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Introduced =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Garden_persistent"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Garden_persistent =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Probably_Garden_persistent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Introduced =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Probably_Introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Native_and_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_Native_and_Introduced =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Probably_Native_and_Introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_a_Waif"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Probably_a_Waif =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Probably_a_Waif" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Waif"></see>
    /// </summary>
    let USDA_Native_Status_Introduced_Waif =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Introduced_Waif" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Native_Native" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native_and_Introduced =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Native_Native_and_Introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Probably_Introduced"></see>
    /// </summary>
    let USDA_Native_Status_Native_Native_and_Probably_Introduced =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Native_Native_and_Probably_Introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Probably_Native"></see>
    /// </summary>
    let USDA_Native_Status_Native_Probably_Native =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status_Native_Probably_Native" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_introduced"></see>
    /// </summary>
    let nativeness_introduced =
        Namespaced_IRI.parse _namespace_name "nativeness_introduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_invasive"></see>
    /// </summary>
    let nativeness_invasive =
        Namespaced_IRI.parse _namespace_name "nativeness_invasive" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_managed"></see>
    /// </summary>
    let nativeness_managed =
        Namespaced_IRI.parse _namespace_name "nativeness_managed" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_native"></see>
    /// </summary>
    let nativeness_native =
        Namespaced_IRI.parse _namespace_name "nativeness_native" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#nativeness_naturalised"></see>
    /// </summary>
    let nativeness_naturalised =
        Namespaced_IRI.parse _namespace_name "nativeness_naturalised" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_47g_Prairie_Pothole_Region_"></see>
    /// </summary>
    let Omernik_4_47g_Prairie_Pothole_Region_ =
        Namespaced_IRI.parse _namespace_name "Omernik_4_47g_Prairie_Pothole_Region_" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_50a_Lake_Superior_Clay_Plain"></see>
    /// </summary>
    let Omernik_4_50a_Lake_Superior_Clay_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_50a_Lake_Superior_Clay_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines"></see>
    /// </summary>
    let ``Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines`` =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain"></see>
    /// </summary>
    let Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain"></see>
    /// </summary>
    let Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51d_Central_Sand_Ridges"></see>
    /// </summary>
    let Omernik_4_51d_Central_Sand_Ridges =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51d_Central_Sand_Ridges" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine"></see>
    /// </summary>
    let Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain"></see>
    /// </summary>
    let Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51g_Door_Peninsula"></see>
    /// </summary>
    let Omernik_4_51g_Door_Peninsula =
        Namespaced_IRI.parse _namespace_name "Omernik_4_51g_Door_Peninsula" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52a_Savanna_Section"></see>
    /// </summary>
    let Omernik_4_52a_Savanna_Section =
        Namespaced_IRI.parse _namespace_name "Omernik_4_52a_Savanna_Section" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52b_Coulee_Section"></see>
    /// </summary>
    let Omernik_4_52b_Coulee_Section =
        Namespaced_IRI.parse _namespace_name "Omernik_4_52b_Coulee_Section" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53a_Rock_River_Drift_Plain"></see>
    /// </summary>
    let Omernik_4_53a_Rock_River_Drift_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_53a_Rock_River_Drift_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53b_Kettle_Moraines"></see>
    /// </summary>
    let Omernik_4_53b_Kettle_Moraines =
        Namespaced_IRI.parse _namespace_name "Omernik_4_53b_Kettle_Moraines" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain"></see>
    /// </summary>
    let Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain"></see>
    /// </summary>
    let Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain =
        Namespaced_IRI.parse _namespace_name "Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_54e_Chiwaukee_Prairie_Region"></see>
    /// </summary>
    let Omernik_4_54e_Chiwaukee_Prairie_Region =
        Namespaced_IRI.parse _namespace_name "Omernik_4_54e_Chiwaukee_Prairie_Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_female"></see>
    /// </summary>
    let Sex_female = Namespaced_IRI.parse _namespace_name "Sex_female" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_hermaphrodite"></see>
    /// </summary>
    let Sex_hermaphrodite =
        Namespaced_IRI.parse _namespace_name "Sex_hermaphrodite" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_male"></see>
    /// </summary>
    let Sex_male = Namespaced_IRI.parse _namespace_name "Sex_male" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_undetermined"></see>
    /// </summary>
    let Sex_undetermined =
        Namespaced_IRI.parse _namespace_name "Sex_undetermined" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex_unknowable"></see>
    /// </summary>
    let Sex_unknowable =
        Namespaced_IRI.parse _namespace_name "Sex_unknowable" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_47_Western_Corn_Belt_Plains"></see>
    /// </summary>
    let Omernik_3_47_Western_Corn_Belt_Plains =
        Namespaced_IRI.parse _namespace_name "Omernik_3_47_Western_Corn_Belt_Plains" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_50_Northern_Lakes_and_Forests"></see>
    /// </summary>
    let Omernik_3_50_Northern_Lakes_and_Forests =
        Namespaced_IRI.parse _namespace_name "Omernik_3_50_Northern_Lakes_and_Forests" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_51_North_Central_Hardwood_Forests"></see>
    /// </summary>
    let Omernik_3_51_North_Central_Hardwood_Forests =
        Namespaced_IRI.parse _namespace_name "Omernik_3_51_North_Central_Hardwood_Forests" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_52_Driftless_Area"></see>
    /// </summary>
    let Omernik_3_52_Driftless_Area =
        Namespaced_IRI.parse _namespace_name "Omernik_3_52_Driftless_Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_53_Southeastern_Wisconsin_Till_Plains"></see>
    /// </summary>
    let Omernik_3_53_Southeastern_Wisconsin_Till_Plains =
        Namespaced_IRI.parse _namespace_name "Omernik_3_53_Southeastern_Wisconsin_Till_Plains" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_54_Central_Corn_Belt_Plains"></see>
    /// </summary>
    let Omernik_3_54_Central_Corn_Belt_Plains =
        Namespaced_IRI.parse _namespace_name "Omernik_3_54_Central_Corn_Belt_Plains" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Beech_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Beech_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Beech_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bog_and_Fen"></see>
    /// </summary>
    let Wisconsin_Herbarium_Bog_and_Fen =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Bog_and_Fen" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Boreal_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Boreal_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Boreal_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bracken_Grassland"></see>
    /// </summary>
    let Wisconsin_Herbarium_Bracken_Grassland =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Bracken_Grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Cliff"></see>
    /// </summary>
    let Wisconsin_Herbarium_Cliff =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Cliff" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Emergent_Aquatic"></see>
    /// </summary>
    let Wisconsin_Herbarium_Emergent_Aquatic =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Emergent_Aquatic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Lowland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Northern_Lowland_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Northern_Lowland_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Upland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Northern_Upland_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Northern_Upland_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Pine_Barrens"></see>
    /// </summary>
    let Wisconsin_Herbarium_Pine_Barrens =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Pine_Barrens" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Prairie"></see>
    /// </summary>
    let Wisconsin_Herbarium_Prairie =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Prairie" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Barrens"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sand_Barrens =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Sand_Barrens" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Dunes"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sand_Dunes =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Sand_Dunes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Savanna"></see>
    /// </summary>
    let Wisconsin_Herbarium_Savanna =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Savanna" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sedge_Meadow"></see>
    /// </summary>
    let Wisconsin_Herbarium_Sedge_Meadow =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Sedge_Meadow" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Shrub_Carr"></see>
    /// </summary>
    let Wisconsin_Herbarium_Shrub_Carr =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Shrub_Carr" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Lowland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Southern_Lowland_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Southern_Lowland_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Upland_Forest"></see>
    /// </summary>
    let Wisconsin_Herbarium_Southern_Upland_Forest =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Southern_Upland_Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_accepted"></see>
    /// </summary>
    let TaxonomicStatus_accepted =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_accepted" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_heterotypicSynonym"></see>
    /// </summary>
    let TaxonomicStatus_heterotypicSynonym =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_heterotypicSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_homotypicSynonym"></see>
    /// </summary>
    let TaxonomicStatus_homotypicSynonym =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_homotypicSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_invalid"></see>
    /// </summary>
    let TaxonomicStatus_invalid =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_invalid" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_misapplied"></see>
    /// </summary>
    let TaxonomicStatus_misapplied =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_misapplied" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_proParteSynonym"></see>
    /// </summary>
    let TaxonomicStatus_proParteSynonym =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_proParteSynonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_synonym"></see>
    /// </summary>
    let TaxonomicStatus_synonym =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_synonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unaccepted"></see>
    /// </summary>
    let TaxonomicStatus_unaccepted =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_unaccepted" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unverified"></see>
    /// </summary>
    let TaxonomicStatus_unverified =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus_unverified" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#PhotoCollection"></see>
    /// </summary>
    let PhotoCollection =
        Namespaced_IRI.parse _namespace_name "PhotoCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Observation"></see>
    /// </summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Sex"></see>
    /// </summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#IndividualOrganism"></see>
    /// </summary>
    let IndividualOrganism =
        Namespaced_IRI.parse _namespace_name "IndividualOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonConcept"></see>
    /// </summary>
    let TaxonConcept =
        Namespaced_IRI.parse _namespace_name "TaxonConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ObservationMethod"></see>
    /// </summary>
    let ObservationMethod =
        Namespaced_IRI.parse _namespace_name "ObservationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBCPage"></see>
    /// </summary>
    let BBCPage = Namespaced_IRI.parse _namespace_name "BBCPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone"></see>
    /// </summary>
    let BBC_Ecozone =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Ecozone"></see>
    /// </summary>
    let Ecozone = Namespaced_IRI.parse _namespace_name "Ecozone" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Afrotropics"></see>
    /// </summary>
    let BBC_Ecozone_Afrotropics =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Afrotropics" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Antarctica"></see>
    /// </summary>
    let BBC_Ecozone_Antarctica =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Antarctica" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Australasia"></see>
    /// </summary>
    let BBC_Ecozone_Australasia =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Australasia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Indo-Malay"></see>
    /// </summary>
    let ``BBC_Ecozone_Indo-Malay`` =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Indo-Malay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Nearctic"></see>
    /// </summary>
    let BBC_Ecozone_Nearctic =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Nearctic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Neotropical"></see>
    /// </summary>
    let BBC_Ecozone_Neotropical =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Neotropical" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Oceania"></see>
    /// </summary>
    let BBC_Ecozone_Oceania =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Oceania" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Palaearctic"></see>
    /// </summary>
    let BBC_Ecozone_Palaearctic =
        Namespaced_IRI.parse _namespace_name "BBC_Ecozone_Palaearctic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat"></see>
    /// </summary>
    let BBC_Freshwater_Habitat =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Habitat_Classification"></see>
    /// </summary>
    let BBC_Habitat_Classification =
        Namespaced_IRI.parse _namespace_name "BBC_Habitat_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Brackish_water"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Brackish_water =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Brackish_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Lakes_and_ponds"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Lakes_and_ponds =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Lakes_and_ponds" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Marsh"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Marsh =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Marsh" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Rivers_and_streams"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Rivers_and_streams =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Rivers_and_streams" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Swamp"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Swamp =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Swamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Temporary_pools"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Temporary_pools =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Temporary_pools" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Wetlands"></see>
    /// </summary>
    let BBC_Freshwater_Habitat_Wetlands =
        Namespaced_IRI.parse _namespace_name "BBC_Freshwater_Habitat_Wetlands" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Habitat_Classification"></see>
    /// </summary>
    let Habitat_Classification =
        Namespaced_IRI.parse _namespace_name "Habitat_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat"></see>
    /// </summary>
    let BBC_Marine_Habitat =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Deep_ocean"></see>
    /// </summary>
    let BBC_Marine_Habitat_Deep_ocean =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Deep_ocean" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Estuaries"></see>
    /// </summary>
    let BBC_Marine_Habitat_Estuaries =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Estuaries" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Hydrothermal_vents"></see>
    /// </summary>
    let BBC_Marine_Habitat_Hydrothermal_vents =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Hydrothermal_vents" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Open_ocean"></see>
    /// </summary>
    let BBC_Marine_Habitat_Open_ocean =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Open_ocean" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Reefs"></see>
    /// </summary>
    let BBC_Marine_Habitat_Reefs =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Reefs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Sea_bed"></see>
    /// </summary>
    let BBC_Marine_Habitat_Sea_bed =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Sea_bed" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Shallow_seas"></see>
    /// </summary>
    let BBC_Marine_Habitat_Shallow_seas =
        Namespaced_IRI.parse _namespace_name "BBC_Marine_Habitat_Shallow_seas" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Broadleaf_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Broadleaf_forest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Broadleaf_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coastal"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Coastal =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Coastal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coniferous_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Coniferous_forest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Coniferous_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Desert"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Desert =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Desert" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Flooded_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Flooded_grassland =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Flooded_grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mangroves"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mangroves =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Mangroves" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mediterranean_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mediterranean_forest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Mediterranean_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mountain_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Mountain_grassland =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Mountain_grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Polar"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Polar =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Polar" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Rainforest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Rainforest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Rainforest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Taiga"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Taiga =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Taiga" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Temperate_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Temperate_grassland =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Temperate_grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_coniferous_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_coniferous_forest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Tropical_coniferous_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_dry_forest"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_dry_forest =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Tropical_dry_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_grassland"></see>
    /// </summary>
    let BBC_Terrestrial_Habitat_Tropical_grassland =
        Namespaced_IRI.parse _namespace_name "BBC_Terrestrial_Habitat_Tropical_grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord"></see>
    /// </summary>
    let BasisOfRecord =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_FossilSpecimen"></see>
    /// </summary>
    let BasisOfRecord_FossilSpecimen =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_FossilSpecimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_HumanObservation"></see>
    /// </summary>
    let BasisOfRecord_HumanObservation =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_HumanObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_LivingSpecimen"></see>
    /// </summary>
    let BasisOfRecord_LivingSpecimen =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_LivingSpecimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MachineObservation"></see>
    /// </summary>
    let BasisOfRecord_MachineObservation =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_MachineObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MovingImage"></see>
    /// </summary>
    let BasisOfRecord_MovingImage =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_MovingImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_NomenclaturalChecklist"></see>
    /// </summary>
    let BasisOfRecord_NomenclaturalChecklist =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_NomenclaturalChecklist" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_PreservedSpecimen"></see>
    /// </summary>
    let BasisOfRecord_PreservedSpecimen =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_PreservedSpecimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_Sound"></see>
    /// </summary>
    let BasisOfRecord_Sound =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_Sound" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_StillImage"></see>
    /// </summary>
    let BasisOfRecord_StillImage =
        Namespaced_IRI.parse _namespace_name "BasisOfRecord_StillImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Bio2RDFtaxon"></see>
    /// </summary>
    let Bio2RDFtaxon =
        Namespaced_IRI.parse _namespace_name "Bio2RDFtaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BioLibPage"></see>
    /// </summary>
    let BioLibPage = Namespaced_IRI.parse _namespace_name "BioLibPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#BugGuidePage"></see>
    /// </summary>
    let BugGuidePage =
        Namespaced_IRI.parse _namespace_name "BugGuidePage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ClassConcept"></see>
    /// </summary>
    let ClassConcept =
        Namespaced_IRI.parse _namespace_name "ClassConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#CoL_LSID"></see>
    /// </summary>
    let CoL_LSID = Namespaced_IRI.parse _namespace_name "CoL_LSID" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LSID"></see>
    /// </summary>
    let LSID = Namespaced_IRI.parse _namespace_name "LSID" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Continent"></see>
    /// </summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#DBpediaResource"></see>
    /// </summary>
    let DBpediaResource =
        Namespaced_IRI.parse _namespace_name "DBpediaResource" |> NamespacedName

    /// <summary>
    /// A Darwin Point is an occurrence location that meets the DarwinCore specifications for longitude, latitude, datum, extent, etc as described in "Guide to Best Practices for Georeferencing"
    /// <see href="http://rdf.geospecies.org/ont/geospecies#DarwinPoint"></see></summary>
    let DarwinPoint =
        Namespaced_IRI.parse _namespace_name "DarwinPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#EoLPage"></see>
    /// </summary>
    let EoLPage = Namespaced_IRI.parse _namespace_name "EoLPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#FamilyConcept"></see>
    /// </summary>
    let FamilyConcept =
        Namespaced_IRI.parse _namespace_name "FamilyConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#FreebaseGUID"></see>
    /// </summary>
    let FreebaseGUID =
        Namespaced_IRI.parse _namespace_name "FreebaseGUID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GBIFPage"></see>
    /// </summary>
    let GBIFPage = Namespaced_IRI.parse _namespace_name "GBIFPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesPage"></see>
    /// </summary>
    let GeoSpeciesPage =
        Namespaced_IRI.parse _namespace_name "GeoSpeciesPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesScheme"></see>
    /// </summary>
    let GeoSpeciesScheme =
        Namespaced_IRI.parse _namespace_name "GeoSpeciesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeoSpecies_Knowledge_Base_Project"></see>
    /// </summary>
    let GeoSpecies_Knowledge_Base_Project =
        Namespaced_IRI.parse _namespace_name "GeoSpecies_Knowledge_Base_Project" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum"></see>
    /// </summary>
    let GeodeticDatum =
        Namespaced_IRI.parse _namespace_name "GeodeticDatum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD27"></see>
    /// </summary>
    let GeodeticDatum_NAD27 =
        Namespaced_IRI.parse _namespace_name "GeodeticDatum_NAD27" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD83"></see>
    /// </summary>
    let GeodeticDatum_NAD83 =
        Namespaced_IRI.parse _namespace_name "GeodeticDatum_NAD83" |> NamespacedName

    /// <summary>
    /// The Geodetic Datum WGS84
    /// <see href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_WGS84"></see></summary>
    let GeodeticDatum_WGS84 =
        Namespaced_IRI.parse _namespace_name "GeodeticDatum_WGS84" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ITISPage"></see>
    /// </summary>
    let ITISPage = Namespaced_IRI.parse _namespace_name "ITISPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#IUCN_Habitat_Classification"></see>
    /// </summary>
    let IUCN_Habitat_Classification =
        Namespaced_IRI.parse _namespace_name "IUCN_Habitat_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#KingdomConcept"></see>
    /// </summary>
    let KingdomConcept =
        Namespaced_IRI.parse _namespace_name "KingdomConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LifeForm"></see>
    /// </summary>
    let LifeForm = Namespaced_IRI.parse _namespace_name "LifeForm" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#LifeStage"></see>
    /// </summary>
    let LifeStage = Namespaced_IRI.parse _namespace_name "LifeStage" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Locality"></see>
    /// </summary>
    let Locality = Namespaced_IRI.parse _namespace_name "Locality" |> NamespacedName
    /// <summary>
    /// A location, would be a subclass of geonames feature, but it will not always have a geonames feature id
    /// <see href="http://rdf.geospecies.org/ont/geospecies#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Above_Ground_Sticky_Trap"></see>
    /// </summary>
    let Method_Above_Ground_Sticky_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Above_Ground_Sticky_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Aerial_Collection_Net"></see>
    /// </summary>
    let Method_Aerial_Collection_Net =
        Namespaced_IRI.parse _namespace_name "Method_Aerial_Collection_Net" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Barrier_Trap"></see>
    /// </summary>
    let Method_Barrier_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Barrier_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Berlese_Sample"></see>
    /// </summary>
    let Method_Berlese_Sample =
        Namespaced_IRI.parse _namespace_name "Method_Berlese_Sample" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_CO2_Suction_Trap"></see>
    /// </summary>
    let Method_CO2_Suction_Trap =
        Namespaced_IRI.parse _namespace_name "Method_CO2_Suction_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Cantharidin_Baited_Jar_Trap"></see>
    /// </summary>
    let Method_Cantharidin_Baited_Jar_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Cantharidin_Baited_Jar_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Chicken_Mash_Baited_Trap"></see>
    /// </summary>
    let Method_Chicken_Mash_Baited_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Chicken_Mash_Baited_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Flight_Intercept_Trap"></see>
    /// </summary>
    let Method_Flight_Intercept_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Flight_Intercept_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Ground_Based_Sticky_Trap"></see>
    /// </summary>
    let Method_Ground_Based_Sticky_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Ground_Based_Sticky_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected"></see>
    /// </summary>
    let Method_Hand_Collected =
        Namespaced_IRI.parse _namespace_name "Method_Hand_Collected" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected_and_Released"></see>
    /// </summary>
    let Method_Hand_Collected_and_Released =
        Namespaced_IRI.parse _namespace_name "Method_Hand_Collected_and_Released" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Bite_Collection"></see>
    /// </summary>
    let Method_Human_Bite_Collection =
        Namespaced_IRI.parse _namespace_name "Method_Human_Bite_Collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Observation"></see>
    /// </summary>
    let Method_Human_Observation =
        Namespaced_IRI.parse _namespace_name "Method_Human_Observation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Light_and_CO2_Suction_Trap"></see>
    /// </summary>
    let Method_Light_and_CO2_Suction_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Light_and_CO2_Suction_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Malaise_Trap"></see>
    /// </summary>
    let Method_Malaise_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Malaise_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Photographed"></see>
    /// </summary>
    let Method_Photographed =
        Namespaced_IRI.parse _namespace_name "Method_Photographed" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Pitfall_Trap"></see>
    /// </summary>
    let Method_Pitfall_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Pitfall_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Sweep_Net"></see>
    /// </summary>
    let Method_Sweep_Net =
        Namespaced_IRI.parse _namespace_name "Method_Sweep_Net" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_UV_Light_Trap"></see>
    /// </summary>
    let Method_UV_Light_Trap =
        Namespaced_IRI.parse _namespace_name "Method_UV_Light_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Vacuum_Collector"></see>
    /// </summary>
    let Method_Vacuum_Collector =
        Namespaced_IRI.parse _namespace_name "Method_Vacuum_Collector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Method_Visible_Light_Trap"></see>
    /// </summary>
    let Method_Visible_Light_Trap =
        Namespaced_IRI.parse _namespace_name "Method_Visible_Light_Trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Nativeness"></see>
    /// </summary>
    let Nativeness = Namespaced_IRI.parse _namespace_name "Nativeness" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode"></see>
    /// </summary>
    let NomenclaturalCode =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICVCN"></see>
    /// </summary>
    let NomenclaturalCode_ICVCN =
        Namespaced_IRI.parse _namespace_name "NomenclaturalCode_ICVCN" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus"></see>
    /// </summary>
    let OccurrenceStatus =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_absent"></see>
    /// </summary>
    let OccurrenceStatus_absent =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_absent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_common"></see>
    /// </summary>
    let OccurrenceStatus_common =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_common" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_doubtful"></see>
    /// </summary>
    let OccurrenceStatus_doubtful =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_doubtful" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_irregular"></see>
    /// </summary>
    let OccurrenceStatus_irregular =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_irregular" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_present"></see>
    /// </summary>
    let OccurrenceStatus_present =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_present" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_rare"></see>
    /// </summary>
    let OccurrenceStatus_rare =
        Namespaced_IRI.parse _namespace_name "OccurrenceStatus_rare" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_III_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Level_III_Ecoregion_Classification =
        Namespaced_IRI.parse _namespace_name "Omernik_Level_III_Ecoregion_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Ecoregion_Classification =
        Namespaced_IRI.parse _namespace_name "Omernik_Ecoregion_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_IV_Ecoregion_Classification"></see>
    /// </summary>
    let Omernik_Level_IV_Ecoregion_Classification =
        Namespaced_IRI.parse _namespace_name "Omernik_Level_IV_Ecoregion_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OpenCycConcept"></see>
    /// </summary>
    let OpenCycConcept =
        Namespaced_IRI.parse _namespace_name "OpenCycConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#OrderConcept"></see>
    /// </summary>
    let OrderConcept =
        Namespaced_IRI.parse _namespace_name "OrderConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#PhylumConcept"></see>
    /// </summary>
    let PhylumConcept =
        Namespaced_IRI.parse _namespace_name "PhylumConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#SpeciesConcept"></see>
    /// </summary>
    let SpeciesConcept =
        Namespaced_IRI.parse _namespace_name "SpeciesConcept" |> NamespacedName

    /// <summary>
    /// State or Province
    /// <see href="http://rdf.geospecies.org/ont/geospecies#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank"></see>
    /// </summary>
    let TaxonRank = Namespaced_IRI.parse _namespace_name "TaxonRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_class"></see>
    /// </summary>
    let TaxonRank_class =
        Namespaced_IRI.parse _namespace_name "TaxonRank_class" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivar"></see>
    /// </summary>
    let TaxonRank_cultivar =
        Namespaced_IRI.parse _namespace_name "TaxonRank_cultivar" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivarGroup"></see>
    /// </summary>
    let TaxonRank_cultivarGroup =
        Namespaced_IRI.parse _namespace_name "TaxonRank_cultivarGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_domain"></see>
    /// </summary>
    let TaxonRank_domain =
        Namespaced_IRI.parse _namespace_name "TaxonRank_domain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_family"></see>
    /// </summary>
    let TaxonRank_family =
        Namespaced_IRI.parse _namespace_name "TaxonRank_family" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_form"></see>
    /// </summary>
    let TaxonRank_form =
        Namespaced_IRI.parse _namespace_name "TaxonRank_form" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_genus"></see>
    /// </summary>
    let TaxonRank_genus =
        Namespaced_IRI.parse _namespace_name "TaxonRank_genus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_infraorder"></see>
    /// </summary>
    let TaxonRank_infraorder =
        Namespaced_IRI.parse _namespace_name "TaxonRank_infraorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_kingdom"></see>
    /// </summary>
    let TaxonRank_kingdom =
        Namespaced_IRI.parse _namespace_name "TaxonRank_kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_order"></see>
    /// </summary>
    let TaxonRank_order =
        Namespaced_IRI.parse _namespace_name "TaxonRank_order" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_phylum"></see>
    /// </summary>
    let TaxonRank_phylum =
        Namespaced_IRI.parse _namespace_name "TaxonRank_phylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_section"></see>
    /// </summary>
    let TaxonRank_section =
        Namespaced_IRI.parse _namespace_name "TaxonRank_section" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_species"></see>
    /// </summary>
    let TaxonRank_species =
        Namespaced_IRI.parse _namespace_name "TaxonRank_species" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_speciesAggregate"></see>
    /// </summary>
    let TaxonRank_speciesAggregate =
        Namespaced_IRI.parse _namespace_name "TaxonRank_speciesAggregate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subclass"></see>
    /// </summary>
    let TaxonRank_subclass =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subfamily"></see>
    /// </summary>
    let TaxonRank_subfamily =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subform"></see>
    /// </summary>
    let TaxonRank_subform =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subform" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subgenus"></see>
    /// </summary>
    let TaxonRank_subgenus =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subgenus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subkingdom"></see>
    /// </summary>
    let TaxonRank_subkingdom =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subkingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_suborder"></see>
    /// </summary>
    let TaxonRank_suborder =
        Namespaced_IRI.parse _namespace_name "TaxonRank_suborder" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subphylum"></see>
    /// </summary>
    let TaxonRank_subphylum =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subphylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subsection"></see>
    /// </summary>
    let TaxonRank_subsection =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subsection" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecies"></see>
    /// </summary>
    let TaxonRank_subspecies =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subspecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecificAggregate"></see>
    /// </summary>
    let TaxonRank_subspecificAggregate =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subspecificAggregate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subtribe"></see>
    /// </summary>
    let TaxonRank_subtribe =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subtribe" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subvariety"></see>
    /// </summary>
    let TaxonRank_subvariety =
        Namespaced_IRI.parse _namespace_name "TaxonRank_subvariety" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superclass"></see>
    /// </summary>
    let TaxonRank_superclass =
        Namespaced_IRI.parse _namespace_name "TaxonRank_superclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superfamily"></see>
    /// </summary>
    let TaxonRank_superfamily =
        Namespaced_IRI.parse _namespace_name "TaxonRank_superfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superorder"></see>
    /// </summary>
    let TaxonRank_superorder =
        Namespaced_IRI.parse _namespace_name "TaxonRank_superorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_tribe"></see>
    /// </summary>
    let TaxonRank_tribe =
        Namespaced_IRI.parse _namespace_name "TaxonRank_tribe" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_variety"></see>
    /// </summary>
    let TaxonRank_variety =
        Namespaced_IRI.parse _namespace_name "TaxonRank_variety" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus"></see>
    /// </summary>
    let TaxonomicStatus =
        Namespaced_IRI.parse _namespace_name "TaxonomicStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#ThreatStatusIUCN"></see>
    /// </summary>
    let ThreatStatusIUCN =
        Namespaced_IRI.parse _namespace_name "ThreatStatusIUCN" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus"></see>
    /// </summary>
    let TypeStatus = Namespaced_IRI.parse _namespace_name "TypeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_hapantotype"></see>
    /// </summary>
    let TypeStatus_hapantotype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_hapantotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_holotype"></see>
    /// </summary>
    let TypeStatus_holotype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_holotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_lectotype"></see>
    /// </summary>
    let TypeStatus_lectotype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_lectotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_neotype"></see>
    /// </summary>
    let TypeStatus_neotype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_neotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paralectotype"></see>
    /// </summary>
    let TypeStatus_paralectotype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_paralectotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paratype"></see>
    /// </summary>
    let TypeStatus_paratype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_paratype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_syntype"></see>
    /// </summary>
    let TypeStatus_syntype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_syntype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_varitype"></see>
    /// </summary>
    let TypeStatus_varitype =
        Namespaced_IRI.parse _namespace_name "TypeStatus_varitype" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit"></see>
    /// </summary>
    let USDA_Growth_Habit =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Plant_Characteristics"></see>
    /// </summary>
    let USDA_Plant_Characteristics =
        Namespaced_IRI.parse _namespace_name "USDA_Plant_Characteristics" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only. Federal Geographic Data Committee (FGDC) definition includes graminoids, forbs, and ferns.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Forb_Herb"></see></summary>
    let USDA_Growth_Habit_Forb_Herb =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Forb_Herb" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only. An herb in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Graminoid"></see></summary>
    let USDA_Growth_Habit_Graminoid =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Graminoid" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only. In PLANTS, mutually exclusive with VI (Vine). A shrub in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Liana"></see></summary>
    let USDA_Growth_Habit_Liana =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Liana" |> NamespacedName

    /// <summary>
    /// Applies to lichens only, which are not true plants.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Lichenous"></see></summary>
    let USDA_Growth_Habit_Lichenous =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Lichenous" |> NamespacedName

    /// <summary>
    /// Applies to non-vascular plants only; in PLANTS system this is groups HN (Hornworts), LV (Liverworts), and MS (Mosses).
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Nonvascular"></see></summary>
    let USDA_Growth_Habit_Nonvascular =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Nonvascular" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Shrub"></see></summary>
    let USDA_Growth_Habit_Shrub =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Shrub" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only. A dwarf-shrub in the FGDC classification.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Subshrub"></see></summary>
    let USDA_Growth_Habit_Subshrub =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Subshrub" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Tree"></see></summary>
    let USDA_Growth_Habit_Tree =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Tree" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Unknown"></see>
    /// </summary>
    let USDA_Growth_Habit_Unknown =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Unknown" |> NamespacedName

    /// <summary>
    /// Applies to vascular plants only. In PLANTS, mutually exclusive with LI (Liana). FGDC classification considers woody vines to be shrubs and herbaceous vines to be herbs.
    /// <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Vine"></see></summary>
    let USDA_Growth_Habit_Vine =
        Namespaced_IRI.parse _namespace_name "USDA_Growth_Habit_Vine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Jurisdiction_Code"></see>
    /// </summary>
    let USDA_Native_Jurisdiction_Code =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Jurisdiction_Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status"></see>
    /// </summary>
    let USDA_Native_Status =
        Namespaced_IRI.parse _namespace_name "USDA_Native_Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#UUID"></see>
    /// </summary>
    let UUID = Namespaced_IRI.parse _namespace_name "UUID" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Ubio_LSID"></see>
    /// </summary>
    let Ubio_LSID = Namespaced_IRI.parse _namespace_name "Ubio_LSID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#UniprotTaxon"></see>
    /// </summary>
    let UniprotTaxon =
        Namespaced_IRI.parse _namespace_name "UniprotTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#WikipediaArticle"></see>
    /// </summary>
    let WikipediaArticle =
        Namespaced_IRI.parse _namespace_name "WikipediaArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#WikispeciesArticle"></see>
    /// </summary>
    let WikispeciesArticle =
        Namespaced_IRI.parse _namespace_name "WikispeciesArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Habitat_Classification"></see>
    /// </summary>
    let Wisconsin_Herbarium_Habitat_Classification =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Herbarium_Habitat_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Natural_Heritage_Inventory_Habitat_Classification"></see>
    /// </summary>
    let Wisconsin_Natural_Heritage_Inventory_Habitat_Classification =
        Namespaced_IRI.parse _namespace_name "Wisconsin_Natural_Heritage_Inventory_Habitat_Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#World_Pyrochroidae_Database"></see>
    /// </summary>
    let World_Pyrochroidae_Database =
        Namespaced_IRI.parse _namespace_name "World_Pyrochroidae_Database" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#habitatHasSpeciesAssociation"></see>
    /// </summary>
    let habitatHasSpeciesAssociation =
        Namespaced_IRI.parse _namespace_name "habitatHasSpeciesAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBCHabitatAssociation"></see>
    /// </summary>
    let hasBBCHabitatAssociation =
        Namespaced_IRI.parse _namespace_name "hasBBCHabitatAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#speciesHasHabitatAssociation"></see>
    /// </summary>
    let speciesHasHabitatAssociation =
        Namespaced_IRI.parse _namespace_name "speciesHasHabitatAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Ecozone"></see>
    /// </summary>
    let hasBBC_Ecozone =
        Namespaced_IRI.parse _namespace_name "hasBBC_Ecozone" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_EcozoneName"></see>
    /// </summary>
    let hasBBC_EcozoneName =
        Namespaced_IRI.parse _namespace_name "hasBBC_EcozoneName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Habitat"></see>
    /// </summary>
    let hasBBC_Habitat =
        Namespaced_IRI.parse _namespace_name "hasBBC_Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBasionymName"></see>
    /// </summary>
    let hasBasionymName =
        Namespaced_IRI.parse _namespace_name "hasBasionymName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBio2RDFtaxon"></see>
    /// </summary>
    let hasBio2RDFtaxon =
        Namespaced_IRI.parse _namespace_name "hasBio2RDFtaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBioLib"></see>
    /// </summary>
    let hasBioLib = Namespaced_IRI.parse _namespace_name "hasBioLib" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBioLibPage"></see>
    /// </summary>
    let hasBioLibPage =
        Namespaced_IRI.parse _namespace_name "hasBioLibPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasBugGuidePage"></see>
    /// </summary>
    let hasBugGuidePage =
        Namespaced_IRI.parse _namespace_name "hasBugGuidePage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCanonicalName"></see>
    /// </summary>
    let hasCanonicalName =
        Namespaced_IRI.parse _namespace_name "hasCanonicalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasClassName"></see>
    /// </summary>
    let hasClassName =
        Namespaced_IRI.parse _namespace_name "hasClassName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCoL_LSID"></see>
    /// </summary>
    let hasCoL_LSID =
        Namespaced_IRI.parse _namespace_name "hasCoL_LSID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCollectionCode"></see>
    /// </summary>
    let hasCollectionCode =
        Namespaced_IRI.parse _namespace_name "hasCollectionCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCollector"></see>
    /// </summary>
    let hasCollector =
        Namespaced_IRI.parse _namespace_name "hasCollector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCommonName"></see>
    /// </summary>
    let hasCommonName =
        Namespaced_IRI.parse _namespace_name "hasCommonName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasVernacularName"></see>
    /// </summary>
    let hasVernacularName =
        Namespaced_IRI.parse _namespace_name "hasVernacularName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasContinent"></see>
    /// </summary>
    let hasContinent =
        Namespaced_IRI.parse _namespace_name "hasContinent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasContinentName"></see>
    /// </summary>
    let hasContinentName =
        Namespaced_IRI.parse _namespace_name "hasContinentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountryCode"></see>
    /// </summary>
    let hasCountryCode =
        Namespaced_IRI.parse _namespace_name "hasCountryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountryName"></see>
    /// </summary>
    let hasCountryName =
        Namespaced_IRI.parse _namespace_name "hasCountryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCounty"></see>
    /// </summary>
    let hasCounty = Namespaced_IRI.parse _namespace_name "hasCounty" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasCountyName"></see>
    /// </summary>
    let hasCountyName =
        Namespaced_IRI.parse _namespace_name "hasCountyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasDBpediaResource"></see>
    /// </summary>
    let hasDBpediaResource =
        Namespaced_IRI.parse _namespace_name "hasDBpediaResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEOLPage"></see>
    /// </summary>
    let hasEOLPage = Namespaced_IRI.parse _namespace_name "hasEOLPage" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEndDate"></see>
    /// </summary>
    let hasEndDate = Namespaced_IRI.parse _namespace_name "hasEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasEndDayOfYear"></see>
    /// </summary>
    let hasEndDayOfYear =
        Namespaced_IRI.parse _namespace_name "hasEndDayOfYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasExpectationOf"></see>
    /// </summary>
    let hasExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFamilyInfoContributor"></see>
    /// </summary>
    let hasFamilyInfoContributor =
        Namespaced_IRI.parse _namespace_name "hasFamilyInfoContributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFamilyName"></see>
    /// </summary>
    let hasFamilyName =
        Namespaced_IRI.parse _namespace_name "hasFamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasFreebaseResource"></see>
    /// </summary>
    let hasFreebaseResource =
        Namespaced_IRI.parse _namespace_name "hasFreebaseResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGBIF"></see>
    /// </summary>
    let hasGBIF = Namespaced_IRI.parse _namespace_name "hasGBIF" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGBIFPage"></see>
    /// </summary>
    let hasGBIFPage =
        Namespaced_IRI.parse _namespace_name "hasGBIFPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGNI"></see>
    /// </summary>
    let hasGNI = Namespaced_IRI.parse _namespace_name "hasGNI" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGenusName"></see>
    /// </summary>
    let hasGenusName =
        Namespaced_IRI.parse _namespace_name "hasGenusName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGeoSpeciesConcept"></see>
    /// </summary>
    let hasGeoSpeciesConcept =
        Namespaced_IRI.parse _namespace_name "hasGeoSpeciesConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTaxonConcept"></see>
    /// </summary>
    let hasTaxonConcept =
        Namespaced_IRI.parse _namespace_name "hasTaxonConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasGeodeticDatum"></see>
    /// </summary>
    let hasGeodeticDatum =
        Namespaced_IRI.parse _namespace_name "hasGeodeticDatum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollector"></see>
    /// </summary>
    let hasHumanCollector =
        Namespaced_IRI.parse _namespace_name "hasHumanCollector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollectorName"></see>
    /// </summary>
    let hasHumanCollectorName =
        Namespaced_IRI.parse _namespace_name "hasHumanCollectorName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifier"></see>
    /// </summary>
    let hasHumanIdentifier =
        Namespaced_IRI.parse _namespace_name "hasHumanIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifierName"></see>
    /// </summary>
    let hasHumanIdentifierName =
        Namespaced_IRI.parse _namespace_name "hasHumanIdentifierName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasITIS"></see>
    /// </summary>
    let hasITIS = Namespaced_IRI.parse _namespace_name "hasITIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasITISPage"></see>
    /// </summary>
    let hasITISPage =
        Namespaced_IRI.parse _namespace_name "hasITISPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasInfraspecificEpithet"></see>
    /// </summary>
    let hasInfraspecificEpithet =
        Namespaced_IRI.parse _namespace_name "hasInfraspecificEpithet" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasKingdomName"></see>
    /// </summary>
    let hasKingdomName =
        Namespaced_IRI.parse _namespace_name "hasKingdomName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocality"></see>
    /// </summary>
    let hasLocality =
        Namespaced_IRI.parse _namespace_name "hasLocality" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocalityName"></see>
    /// </summary>
    let hasLocalityName =
        Namespaced_IRI.parse _namespace_name "hasLocalityName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocalityText"></see>
    /// </summary>
    let hasLocalityText =
        Namespaced_IRI.parse _namespace_name "hasLocalityText" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocationName"></see>
    /// </summary>
    let hasLocationName =
        Namespaced_IRI.parse _namespace_name "hasLocationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLocationText"></see>
    /// </summary>
    let hasLocationText =
        Namespaced_IRI.parse _namespace_name "hasLocationText" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLowExpectationOf"></see>
    /// </summary>
    let hasLowExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasLowExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasLowUSDA_ExpectationOf"></see>
    /// </summary>
    let hasLowUSDA_ExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasLowUSDA_ExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNCBITaxonID"></see>
    /// </summary>
    let hasNCBITaxonID =
        Namespaced_IRI.parse _namespace_name "hasNCBITaxonID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNoUSDA_ExpectationOf"></see>
    /// </summary>
    let hasNoUSDA_ExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasNoUSDA_ExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCode"></see>
    /// </summary>
    let hasNomenclaturalCode =
        Namespaced_IRI.parse _namespace_name "hasNomenclaturalCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCodeString"></see>
    /// </summary>
    let hasNomenclaturalCodeString =
        Namespaced_IRI.parse _namespace_name "hasNomenclaturalCodeString" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservation"></see>
    /// </summary>
    let hasObservation =
        Namespaced_IRI.parse _namespace_name "hasObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservationMethod"></see>
    /// </summary>
    let hasObservationMethod =
        Namespaced_IRI.parse _namespace_name "hasObservationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasObservationOf"></see>
    /// </summary>
    let hasObservationOf =
        Namespaced_IRI.parse _namespace_name "hasObservationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOccurrenceStatus"></see>
    /// </summary>
    let hasOccurrenceStatus =
        Namespaced_IRI.parse _namespace_name "hasOccurrenceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_3_Ecozone"></see>
    /// </summary>
    let hasOmernik_3_Ecozone =
        Namespaced_IRI.parse _namespace_name "hasOmernik_3_Ecozone" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_4_Ecozone"></see>
    /// </summary>
    let hasOmernik_4_Ecozone =
        Namespaced_IRI.parse _namespace_name "hasOmernik_4_Ecozone" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasOrderName"></see>
    /// </summary>
    let hasOrderName =
        Namespaced_IRI.parse _namespace_name "hasOrderName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasPhylumName"></see>
    /// </summary>
    let hasPhylumName =
        Namespaced_IRI.parse _namespace_name "hasPhylumName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasProject"></see>
    /// </summary>
    let hasProject = Namespaced_IRI.parse _namespace_name "hasProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificName"></see>
    /// </summary>
    let hasScientificName =
        Namespaced_IRI.parse _namespace_name "hasScientificName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameAuthorship"></see>
    /// </summary>
    let hasScientificNameAuthorship =
        Namespaced_IRI.parse _namespace_name "hasScientificNameAuthorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameRank"></see>
    /// </summary>
    let hasScientificNameRank =
        Namespaced_IRI.parse _namespace_name "hasScientificNameRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSex"></see>
    /// </summary>
    let hasSex = Namespaced_IRI.parse _namespace_name "hasSex" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSpecies"></see>
    /// </summary>
    let hasSpecies = Namespaced_IRI.parse _namespace_name "hasSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSpecificEpithet"></see>
    /// </summary>
    let hasSpecificEpithet =
        Namespaced_IRI.parse _namespace_name "hasSpecificEpithet" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStartDate"></see>
    /// </summary>
    let hasStartDate =
        Namespaced_IRI.parse _namespace_name "hasStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStartDayOfYear"></see>
    /// </summary>
    let hasStartDayOfYear =
        Namespaced_IRI.parse _namespace_name "hasStartDayOfYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvName"></see>
    /// </summary>
    let hasStateProvName =
        Namespaced_IRI.parse _namespace_name "hasStateProvName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvince"></see>
    /// </summary>
    let hasStateProvince =
        Namespaced_IRI.parse _namespace_name "hasStateProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasStateProvinceName"></see>
    /// </summary>
    let hasStateProvinceName =
        Namespaced_IRI.parse _namespace_name "hasStateProvinceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSubfamilyName"></see>
    /// </summary>
    let hasSubfamilyName =
        Namespaced_IRI.parse _namespace_name "hasSubfamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasSubgenusName"></see>
    /// </summary>
    let hasSubgenusName =
        Namespaced_IRI.parse _namespace_name "hasSubgenusName" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTDWG_Concept"></see>
    /// </summary>
    let hasTDWG_Concept =
        Namespaced_IRI.parse _namespace_name "hasTDWG_Concept" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTaxonomicStatus"></see>
    /// </summary>
    let hasTaxonomicStatus =
        Namespaced_IRI.parse _namespace_name "hasTaxonomicStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTreeBaseID"></see>
    /// </summary>
    let hasTreeBaseID =
        Namespaced_IRI.parse _namespace_name "hasTreeBaseID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasTypeStatus"></see>
    /// </summary>
    let hasTypeStatus =
        Namespaced_IRI.parse _namespace_name "hasTypeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUSDA_ExpectationOf"></see>
    /// </summary>
    let hasUSDA_ExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasUSDA_ExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUUID"></see>
    /// </summary>
    let hasUUID = Namespaced_IRI.parse _namespace_name "hasUUID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUbio_LSID"></see>
    /// </summary>
    let hasUbio_LSID =
        Namespaced_IRI.parse _namespace_name "hasUbio_LSID" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasUnknownExpectationOf"></see>
    /// </summary>
    let hasUnknownExpectationOf =
        Namespaced_IRI.parse _namespace_name "hasUnknownExpectationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWI_Herbarium_Habitat"></see>
    /// </summary>
    let hasWI_Herbarium_Habitat =
        Namespaced_IRI.parse _namespace_name "hasWI_Herbarium_Habitat" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle =
        Namespaced_IRI.parse _namespace_name "hasWikipediaArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWikispeciesArticle"></see>
    /// </summary>
    let hasWikispeciesArticle =
        Namespaced_IRI.parse _namespace_name "hasWikispeciesArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatAssociation"></see>
    /// </summary>
    let hasWisconsinHerbariumHabitatAssociation =
        Namespaced_IRI.parse _namespace_name "hasWisconsinHerbariumHabitatAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatPreference"></see>
    /// </summary>
    let hasWisconsinHerbariumHabitatPreference =
        Namespaced_IRI.parse _namespace_name "hasWisconsinHerbariumHabitatPreference" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumSpeciesAssociation"></see>
    /// </summary>
    let hasWisconsinHerbariumSpeciesAssociation =
        Namespaced_IRI.parse _namespace_name "hasWisconsinHerbariumSpeciesAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Growth_Habit"></see>
    /// </summary>
    let has_USDA_Growth_Habit =
        Namespaced_IRI.parse _namespace_name "has_USDA_Growth_Habit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Native_Status"></see>
    /// </summary>
    let has_USDA_Native_Status =
        Namespaced_IRI.parse _namespace_name "has_USDA_Native_Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inClass"></see>
    /// </summary>
    let inClass = Namespaced_IRI.parse _namespace_name "inClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inFamily"></see>
    /// </summary>
    let inFamily = Namespaced_IRI.parse _namespace_name "inFamily" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inKingdom"></see>
    /// </summary>
    let inKingdom = Namespaced_IRI.parse _namespace_name "inKingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inOrder"></see>
    /// </summary>
    let inOrder = Namespaced_IRI.parse _namespace_name "inOrder" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#inPhylum"></see>
    /// </summary>
    let inPhylum = Namespaced_IRI.parse _namespace_name "inPhylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isBugGuidePageOf"></see>
    /// </summary>
    let isBugGuidePageOf =
        Namespaced_IRI.parse _namespace_name "isBugGuidePageOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isExpectedIn"></see>
    /// </summary>
    let isExpectedIn =
        Namespaced_IRI.parse _namespace_name "isExpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isNotUSDA_ExpectedIn"></see>
    /// </summary>
    let isNotUSDA_ExpectedIn =
        Namespaced_IRI.parse _namespace_name "isNotUSDA_ExpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUnexpectedIn"></see>
    /// </summary>
    let isUnexpectedIn =
        Namespaced_IRI.parse _namespace_name "isUnexpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUSDA_ExpectedIn"></see>
    /// </summary>
    let isUSDA_ExpectedIn =
        Namespaced_IRI.parse _namespace_name "isUSDA_ExpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUSDA_UnexpectedIn"></see>
    /// </summary>
    let isUSDA_UnexpectedIn =
        Namespaced_IRI.parse _namespace_name "isUSDA_UnexpectedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#isUnknownAboutIn"></see>
    /// </summary>
    let isUnknownAboutIn =
        Namespaced_IRI.parse _namespace_name "isUnknownAboutIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.geospecies.org/ont/geospecies#wasObservedIn"></see>
    /// </summary>
    let wasObservedIn =
        Namespaced_IRI.parse _namespace_name "wasObservedIn" |> NamespacedName
