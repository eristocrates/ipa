#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geosp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdf.geospecies.org/ont/geospecies#" "geosp"

    /// <summary>
    ///   <para>rdfs:label : BBCPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBCPage">geosp:BBCPage</a>
    /// </summary>
    let BBCPage = _prefixId.prefix "BBCPage"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.bbc.co.uk/nature/ecozones^^xsd:anyURI</para>
    ///   <para>dc11:description : From BBC Nature Project: "Ecozones are a method of dividing up the Earth's surface. Each ecozone is a large area that contains a number of habitats, which are linked by the evolutionary history of the animals and plants within them. For instance one ecozone is Australasia, because its marsupials evolved in isolation to mammals in the rest of the world."^^xsd:string</para>
    ///   <para>rdfs:label : BBC_Ecozone^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone">geosp:BBC_Ecozone</a>
    /// </summary>
    let BBC_Ecozone = _prefixId.prefix "BBC_Ecozone"
    let BBC_Ecozone_Afrotropics = _prefixId.prefix "BBC_Ecozone_Afrotropics"
    let BBC_Ecozone_Antarctica = _prefixId.prefix "BBC_Ecozone_Antarctica"
    let BBC_Ecozone_Australasia = _prefixId.prefix "BBC_Ecozone_Australasia"
    let BBC_Ecozone_Indo_Malay = _prefixId.prefix "BBC_Ecozone_Indo-Malay"
    let BBC_Ecozone_Nearctic = _prefixId.prefix "BBC_Ecozone_Nearctic"
    let BBC_Ecozone_Neotropical = _prefixId.prefix "BBC_Ecozone_Neotropical"
    let BBC_Ecozone_Oceania = _prefixId.prefix "BBC_Ecozone_Oceania"
    let BBC_Ecozone_Palaearctic = _prefixId.prefix "BBC_Ecozone_Palaearctic"
    /// <summary>
    ///   <para>rdfs:label : BBC_Freshwater_Habitats^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat">geosp:BBC_Freshwater_Habitat</a>
    /// </summary>
    let BBC_Freshwater_Habitat = _prefixId.prefix "BBC_Freshwater_Habitat"

    let BBC_Freshwater_Habitat_Brackish_water = _prefixId.prefix "BBC_Freshwater_Habitat_Brackish_water"

    let BBC_Freshwater_Habitat_Lakes_and_ponds = _prefixId.prefix "BBC_Freshwater_Habitat_Lakes_and_ponds"

    let BBC_Freshwater_Habitat_Marsh = _prefixId.prefix "BBC_Freshwater_Habitat_Marsh"

    let BBC_Freshwater_Habitat_Rivers_and_streams = _prefixId.prefix "BBC_Freshwater_Habitat_Rivers_and_streams"

    let BBC_Freshwater_Habitat_Swamp = _prefixId.prefix "BBC_Freshwater_Habitat_Swamp"

    let BBC_Freshwater_Habitat_Temporary_pools = _prefixId.prefix "BBC_Freshwater_Habitat_Temporary_pools"

    let BBC_Freshwater_Habitat_Wetlands = _prefixId.prefix "BBC_Freshwater_Habitat_Wetlands"

    /// <summary>
    ///   <para>rdfs:label : BBC_Habitat_Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBC_Habitat_Classification">geosp:BBC_Habitat_Classification</a>
    /// </summary>
    let BBC_Habitat_Classification = _prefixId.prefix "BBC_Habitat_Classification"
    /// <summary>
    ///   <para>rdfs:label : BBC_Marine_Habitats^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat">geosp:BBC_Marine_Habitat</a>
    /// </summary>
    let BBC_Marine_Habitat = _prefixId.prefix "BBC_Marine_Habitat"
    let BBC_Marine_Habitat_Deep_ocean = _prefixId.prefix "BBC_Marine_Habitat_Deep_ocean"
    let BBC_Marine_Habitat_Estuaries = _prefixId.prefix "BBC_Marine_Habitat_Estuaries"

    let BBC_Marine_Habitat_Hydrothermal_vents = _prefixId.prefix "BBC_Marine_Habitat_Hydrothermal_vents"

    let BBC_Marine_Habitat_Open_ocean = _prefixId.prefix "BBC_Marine_Habitat_Open_ocean"
    let BBC_Marine_Habitat_Reefs = _prefixId.prefix "BBC_Marine_Habitat_Reefs"
    let BBC_Marine_Habitat_Sea_bed = _prefixId.prefix "BBC_Marine_Habitat_Sea_bed"

    let BBC_Marine_Habitat_Shallow_seas = _prefixId.prefix "BBC_Marine_Habitat_Shallow_seas"

    /// <summary>
    ///   <para>rdfs:label : BBC_Terrestrial_Habitats^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat">geosp:BBC_Terrestrial_Habitat</a>
    /// </summary>
    let BBC_Terrestrial_Habitat = _prefixId.prefix "BBC_Terrestrial_Habitat"

    let BBC_Terrestrial_Habitat_Broadleaf_forest = _prefixId.prefix "BBC_Terrestrial_Habitat_Broadleaf_forest"

    let BBC_Terrestrial_Habitat_Coastal = _prefixId.prefix "BBC_Terrestrial_Habitat_Coastal"

    let BBC_Terrestrial_Habitat_Coniferous_forest = _prefixId.prefix "BBC_Terrestrial_Habitat_Coniferous_forest"

    let BBC_Terrestrial_Habitat_Desert = _prefixId.prefix "BBC_Terrestrial_Habitat_Desert"

    let BBC_Terrestrial_Habitat_Flooded_grassland = _prefixId.prefix "BBC_Terrestrial_Habitat_Flooded_grassland"

    let BBC_Terrestrial_Habitat_Mangroves = _prefixId.prefix "BBC_Terrestrial_Habitat_Mangroves"

    let BBC_Terrestrial_Habitat_Mediterranean_forest = _prefixId.prefix "BBC_Terrestrial_Habitat_Mediterranean_forest"

    let BBC_Terrestrial_Habitat_Mountain_grassland = _prefixId.prefix "BBC_Terrestrial_Habitat_Mountain_grassland"

    let BBC_Terrestrial_Habitat_Polar = _prefixId.prefix "BBC_Terrestrial_Habitat_Polar"

    let BBC_Terrestrial_Habitat_Rainforest = _prefixId.prefix "BBC_Terrestrial_Habitat_Rainforest"

    let BBC_Terrestrial_Habitat_Taiga = _prefixId.prefix "BBC_Terrestrial_Habitat_Taiga"

    let BBC_Terrestrial_Habitat_Temperate_grassland = _prefixId.prefix "BBC_Terrestrial_Habitat_Temperate_grassland"

    let BBC_Terrestrial_Habitat_Tropical_coniferous_forest = _prefixId.prefix "BBC_Terrestrial_Habitat_Tropical_coniferous_forest"

    let BBC_Terrestrial_Habitat_Tropical_dry_forest = _prefixId.prefix "BBC_Terrestrial_Habitat_Tropical_dry_forest"

    let BBC_Terrestrial_Habitat_Tropical_grassland = _prefixId.prefix "BBC_Terrestrial_Habitat_Tropical_grassland"

    /// <summary>
    ///   <para>rdfs:label : BasisOfRecord^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord">geosp:BasisOfRecord</a>
    /// </summary>
    let BasisOfRecord = _prefixId.prefix "BasisOfRecord"
    let BasisOfRecord_FossilSpecimen = _prefixId.prefix "BasisOfRecord_FossilSpecimen"

    let BasisOfRecord_HumanObservation = _prefixId.prefix "BasisOfRecord_HumanObservation"

    let BasisOfRecord_LivingSpecimen = _prefixId.prefix "BasisOfRecord_LivingSpecimen"

    let BasisOfRecord_MachineObservation = _prefixId.prefix "BasisOfRecord_MachineObservation"

    let BasisOfRecord_MovingImage = _prefixId.prefix "BasisOfRecord_MovingImage"

    let BasisOfRecord_NomenclaturalChecklist = _prefixId.prefix "BasisOfRecord_NomenclaturalChecklist"

    let BasisOfRecord_PreservedSpecimen = _prefixId.prefix "BasisOfRecord_PreservedSpecimen"

    let BasisOfRecord_Sound = _prefixId.prefix "BasisOfRecord_Sound"
    let BasisOfRecord_StillImage = _prefixId.prefix "BasisOfRecord_StillImage"
    /// <summary>
    ///   <para>rdfs:label : Bio2RDFtaxon^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Bio2RDFtaxon">geosp:Bio2RDFtaxon</a>
    /// </summary>
    let Bio2RDFtaxon = _prefixId.prefix "Bio2RDFtaxon"
    /// <summary>
    ///   <para>rdfs:label : BioLibPage^^xsd:stringrdfs:label : BBCPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BioLibPage">geosp:BioLibPage</a>
    /// </summary>
    let BioLibPage = _prefixId.prefix "BioLibPage"
    /// <summary>
    ///   <para>rdfs:label : BugGuidePage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#BugGuidePage">geosp:BugGuidePage</a>
    /// </summary>
    let BugGuidePage = _prefixId.prefix "BugGuidePage"
    /// <summary>
    ///   <para>rdfs:label : ClassConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#ClassConcept">geosp:ClassConcept</a>
    /// </summary>
    let ClassConcept = _prefixId.prefix "ClassConcept"
    /// <summary>
    ///   <para>rdfs:label : CoL_LSID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#CoL_LSID">geosp:CoL_LSID</a>
    /// </summary>
    let CoL_LSID = _prefixId.prefix "CoL_LSID"
    /// <summary>
    ///   <para>rdfs:label : Continent^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Continent">geosp:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Country">geosp:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : County^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#County">geosp:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : DBpediaResource^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#DBpediaResource">geosp:DBpediaResource</a>
    /// </summary>
    let DBpediaResource = _prefixId.prefix "DBpediaResource"
    /// <summary>
    ///   <para>rdfs:comment : A Darwin Point is an occurrence location that meets the DarwinCore specifications for longitude, latitude, datum, extent, etc as described in "Guide to Best Practices for Georeferencing"^^rdf:XMLLiteral</para>
    ///   <para>rdfs:label : DarwinPoint^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#DarwinPoint">geosp:DarwinPoint</a>
    /// </summary>
    let DarwinPoint = _prefixId.prefix "DarwinPoint"
    /// <summary>
    ///   <para>rdfs:label : Ecozone^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Ecozone">geosp:Ecozone</a>
    /// </summary>
    let Ecozone = _prefixId.prefix "Ecozone"
    /// <summary>
    ///   <para>rdfs:label : EoLPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#EoLPage">geosp:EoLPage</a>
    /// </summary>
    let EoLPage = _prefixId.prefix "EoLPage"
    /// <summary>
    ///   <para>rdfs:label : FamilyConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#FamilyConcept">geosp:FamilyConcept</a>
    /// </summary>
    let FamilyConcept = _prefixId.prefix "FamilyConcept"
    /// <summary>
    ///   <para>rdfs:label : FreebaseGUID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#FreebaseGUID">geosp:FreebaseGUID</a>
    /// </summary>
    let FreebaseGUID = _prefixId.prefix "FreebaseGUID"
    /// <summary>
    ///   <para>rdfs:label : GBIFPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#GBIFPage">geosp:GBIFPage</a>
    /// </summary>
    let GBIFPage = _prefixId.prefix "GBIFPage"
    /// <summary>
    ///   <para>rdfs:label : GeoSpeciesPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesPage">geosp:GeoSpeciesPage</a>
    /// </summary>
    let GeoSpeciesPage = _prefixId.prefix "GeoSpeciesPage"
    /// <summary>
    ///   <para>rdfs:label : GeoSpeciesScheme^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesScheme">geosp:GeoSpeciesScheme</a>
    /// </summary>
    let GeoSpeciesScheme = _prefixId.prefix "GeoSpeciesScheme"

    let GeoSpecies_Knowledge_Base_Project = _prefixId.prefix "GeoSpecies_Knowledge_Base_Project"

    /// <summary>
    ///   <para>rdfs:label : GeodeticDatum^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum">geosp:GeodeticDatum</a>
    /// </summary>
    let GeodeticDatum = _prefixId.prefix "GeodeticDatum"
    let GeodeticDatum_NAD27 = _prefixId.prefix "GeodeticDatum_NAD27"
    let GeodeticDatum_NAD83 = _prefixId.prefix "GeodeticDatum_NAD83"
    let GeodeticDatum_WGS84 = _prefixId.prefix "GeodeticDatum_WGS84"
    /// <summary>
    ///   <para>rdfs:label : Habitat^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Habitat_Classification">geosp:Habitat_Classification</a>
    /// </summary>
    let Habitat_Classification = _prefixId.prefix "Habitat_Classification"
    /// <summary>
    ///   <para>rdfs:label : ITISPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#ITISPage">geosp:ITISPage</a>
    /// </summary>
    let ITISPage = _prefixId.prefix "ITISPage"
    /// <summary>
    ///   <para>rdfs:label : HabitatIUCN^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#IUCN_Habitat_Classification">geosp:IUCN_Habitat_Classification</a>
    /// </summary>
    let IUCN_Habitat_Classification = _prefixId.prefix "IUCN_Habitat_Classification"
    /// <summary>
    ///   <para>rdfs:label : IndividualOrganism^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#IndividualOrganism">geosp:IndividualOrganism</a>
    /// </summary>
    let IndividualOrganism = _prefixId.prefix "IndividualOrganism"
    /// <summary>
    ///   <para>rdfs:label : KingdomConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#KingdomConcept">geosp:KingdomConcept</a>
    /// </summary>
    let KingdomConcept = _prefixId.prefix "KingdomConcept"
    /// <summary>
    ///   <para>rdfs:label : LSID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#LSID">geosp:LSID</a>
    /// </summary>
    let LSID = _prefixId.prefix "LSID"
    /// <summary>
    ///   <para>rdfs:label : LifeForm^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#LifeForm">geosp:LifeForm</a>
    /// </summary>
    let LifeForm = _prefixId.prefix "LifeForm"
    /// <summary>
    ///   <para>rdfs:label : LifeStage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#LifeStage">geosp:LifeStage</a>
    /// </summary>
    let LifeStage = _prefixId.prefix "LifeStage"
    /// <summary>
    ///   <para>rdfs:label : Locality^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Locality">geosp:Locality</a>
    /// </summary>
    let Locality = _prefixId.prefix "Locality"
    /// <summary>
    ///   <para>rdfs:comment : A location, would be a subclass of geonames feature, but it will not always have a geonames feature id^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Location">geosp:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"

    let Method_Above_Ground_Sticky_Trap = _prefixId.prefix "Method_Above_Ground_Sticky_Trap"

    let Method_Aerial_Collection_Net = _prefixId.prefix "Method_Aerial_Collection_Net"
    let Method_Barrier_Trap = _prefixId.prefix "Method_Barrier_Trap"
    let Method_Berlese_Sample = _prefixId.prefix "Method_Berlese_Sample"
    let Method_CO2_Suction_Trap = _prefixId.prefix "Method_CO2_Suction_Trap"

    let Method_Cantharidin_Baited_Jar_Trap = _prefixId.prefix "Method_Cantharidin_Baited_Jar_Trap"

    let Method_Chicken_Mash_Baited_Trap = _prefixId.prefix "Method_Chicken_Mash_Baited_Trap"

    let Method_Flight_Intercept_Trap = _prefixId.prefix "Method_Flight_Intercept_Trap"

    let Method_Ground_Based_Sticky_Trap = _prefixId.prefix "Method_Ground_Based_Sticky_Trap"

    let Method_Hand_Collected = _prefixId.prefix "Method_Hand_Collected"

    let Method_Hand_Collected_and_Released = _prefixId.prefix "Method_Hand_Collected_and_Released"

    let Method_Human_Bite_Collection = _prefixId.prefix "Method_Human_Bite_Collection"
    let Method_Human_Observation = _prefixId.prefix "Method_Human_Observation"

    let Method_Light_and_CO2_Suction_Trap = _prefixId.prefix "Method_Light_and_CO2_Suction_Trap"

    let Method_Malaise_Trap = _prefixId.prefix "Method_Malaise_Trap"
    let Method_Photographed = _prefixId.prefix "Method_Photographed"
    let Method_Pitfall_Trap = _prefixId.prefix "Method_Pitfall_Trap"
    let Method_Sweep_Net = _prefixId.prefix "Method_Sweep_Net"
    let Method_UV_Light_Trap = _prefixId.prefix "Method_UV_Light_Trap"
    let Method_Vacuum_Collector = _prefixId.prefix "Method_Vacuum_Collector"
    let Method_Visible_Light_Trap = _prefixId.prefix "Method_Visible_Light_Trap"
    /// <summary>
    ///   <para>rdfs:label : Nativeness^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Nativeness">geosp:Nativeness</a>
    /// </summary>
    let Nativeness = _prefixId.prefix "Nativeness"
    let NomenclaturalCode = _prefixId.prefix "NomenclaturalCode"
    let NomenclaturalCode_BioCode = _prefixId.prefix "NomenclaturalCode_BioCode"
    let NomenclaturalCode_ICBN = _prefixId.prefix "NomenclaturalCode_ICBN"
    let NomenclaturalCode_ICNB = _prefixId.prefix "NomenclaturalCode_ICNB"
    let NomenclaturalCode_ICNCP = _prefixId.prefix "NomenclaturalCode_ICNCP"
    let NomenclaturalCode_ICTV = _prefixId.prefix "NomenclaturalCode_ICTV"
    let NomenclaturalCode_ICVCN = _prefixId.prefix "NomenclaturalCode_ICVCN"
    let NomenclaturalCode_ICZN = _prefixId.prefix "NomenclaturalCode_ICZN"
    /// <summary>
    ///   <para>rdfs:label : Observation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Observation">geosp:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : ObservationMethod^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#ObservationMethod">geosp:ObservationMethod</a>
    /// </summary>
    let ObservationMethod = _prefixId.prefix "ObservationMethod"
    /// <summary>
    ///   <para>rdfs:label : OccurrenceStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus">geosp:OccurrenceStatus</a>
    /// </summary>
    let OccurrenceStatus = _prefixId.prefix "OccurrenceStatus"
    let OccurrenceStatus_absent = _prefixId.prefix "OccurrenceStatus_absent"
    let OccurrenceStatus_common = _prefixId.prefix "OccurrenceStatus_common"
    let OccurrenceStatus_doubtful = _prefixId.prefix "OccurrenceStatus_doubtful"
    let OccurrenceStatus_irregular = _prefixId.prefix "OccurrenceStatus_irregular"
    let OccurrenceStatus_present = _prefixId.prefix "OccurrenceStatus_present"
    let OccurrenceStatus_rare = _prefixId.prefix "OccurrenceStatus_rare"

    let Omernik_3_47_Western_Corn_Belt_Plains = _prefixId.prefix "Omernik_3_47_Western_Corn_Belt_Plains"

    let Omernik_3_50_Northern_Lakes_and_Forests = _prefixId.prefix "Omernik_3_50_Northern_Lakes_and_Forests"

    let Omernik_3_51_North_Central_Hardwood_Forests = _prefixId.prefix "Omernik_3_51_North_Central_Hardwood_Forests"

    let Omernik_3_52_Driftless_Area = _prefixId.prefix "Omernik_3_52_Driftless_Area"

    let Omernik_3_53_Southeastern_Wisconsin_Till_Plains = _prefixId.prefix "Omernik_3_53_Southeastern_Wisconsin_Till_Plains"

    let Omernik_3_54_Central_Corn_Belt_Plains = _prefixId.prefix "Omernik_3_54_Central_Corn_Belt_Plains"

    let Omernik_4_47g_Prairie_Pothole_Region_ = _prefixId.prefix "Omernik_4_47g_Prairie_Pothole_Region_"

    let Omernik_4_50a_Lake_Superior_Clay_Plain = _prefixId.prefix "Omernik_4_50a_Lake_Superior_Clay_Plain"

    let Omernik_4_51a_St'_period_'_Croix_Pitted_Stagnation_Moraines = _prefixId.prefix "Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines"

    let Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain = _prefixId.prefix "Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain"

    let Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain = _prefixId.prefix "Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain"

    let Omernik_4_51d_Central_Sand_Ridges = _prefixId.prefix "Omernik_4_51d_Central_Sand_Ridges"

    let Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine = _prefixId.prefix "Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine"

    let Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain = _prefixId.prefix "Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain"

    let Omernik_4_51g_Door_Peninsula = _prefixId.prefix "Omernik_4_51g_Door_Peninsula"
    let Omernik_4_52a_Savanna_Section = _prefixId.prefix "Omernik_4_52a_Savanna_Section"
    let Omernik_4_52b_Coulee_Section = _prefixId.prefix "Omernik_4_52b_Coulee_Section"

    let Omernik_4_53a_Rock_River_Drift_Plain = _prefixId.prefix "Omernik_4_53a_Rock_River_Drift_Plain"

    let Omernik_4_53b_Kettle_Moraines = _prefixId.prefix "Omernik_4_53b_Kettle_Moraines"

    let Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain = _prefixId.prefix "Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain"

    let Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain = _prefixId.prefix "Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain"

    let Omernik_4_54e_Chiwaukee_Prairie_Region = _prefixId.prefix "Omernik_4_54e_Chiwaukee_Prairie_Region"

    /// <summary>
    ///   <para>rdfs:label : Omernik Ecoregion Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Omernik_Ecoregion_Classification">geosp:Omernik_Ecoregion_Classification</a>
    /// </summary>
    let Omernik_Ecoregion_Classification = _prefixId.prefix "Omernik_Ecoregion_Classification"

    /// <summary>
    ///   <para>dc11:description : The ecoregions shown here have been derived from Omernik (1987) and from refinements of Omernik's framework that have been made for other projects. These ongoing or recently completed projects, conducted in collaboration with the U.S. EPA regional offices, state resource management agencies, and with other federal agencies, involve refining ecoregions, defining subregions, and locating sets of reference sites. Designed to serve as a spatial framework for environmental resource management, ecoregions denote areas within which ecosystems (and the type, quality, and quantity of environmental resources) are generally similar. The most immediate needs are to develop regional biological criteria and water quality standards and to set management goals for nonpoint source pollution.
    ///
    /// The approach used to compile this map is based on the premise that ecological regions can be identified through the analysis of the patterns and the composition of biotic and abiotic phenomena that affect or reflect differences in ecosystem quality and integrity (Wiken 1986; Omernik 1987, 1995). These phenomena include geology, physiography, vegetation, climate, soils, land use, wildlife, and hydrology. The relative importance of each characteristic varies from one ecological region to another regardless of the hierarchical level. Because of possible confusion with other meanings of terms for different levels of ecological regions, a Roman numeral classification scheme has been adopted for this effort. Level I is the coarsest level, dividing North America into 15 ecological regions, whereas at Level II the continent is subdivided into 52 classes (CEC 1997). Level III is the hierarchical level shown on this map. For portions of the United States the ecoregions have been further subdivided to Level IV. The applications of the ecoregions are explained in Gallant et al. (1989) and in reports and publications from the state and regional projects.
    ///
    /// For additional information, contact James M. Omernik, U.S. EPA National Health and Environmental Effects Laboratory (NHEERL), 200 SW 35th Street, Corvallis, OR 97333 (phone: 541-754-4458 and email: omernik.james@epa.gov).^^xsd:string</para>
    ///   <para>rdfs:label : Omernik_Level_Three_Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_III_Ecoregion_Classification">geosp:Omernik_Level_III_Ecoregion_Classification</a>
    /// </summary>
    let Omernik_Level_III_Ecoregion_Classification = _prefixId.prefix "Omernik_Level_III_Ecoregion_Classification"

    /// <summary>
    ///   <para>dc11:description : Ecoregions denote areas of general similarity in ecosystems and in the type, quality, and quantity of environmental resources. The level IV state projects depict revisions and subdivisions of ecoregions, that were compiled at a relatively small scale (Omernik 1987). Compilation of the level IV maps, performed at the larger 1:250,000 scale, has been a part of collaborative projects between United States Environmental Protection Agency, National Health and Environmental Effects Laboratory (NHEERL)--Corvallis, OR, the U.S. Forest Service, Natural Resources Conservation Service, and a variety of other state and federal resource agencies. The ecoregions and subregions are designed to serve as a spatial framework for environmental resource management. The most immediate needs by the states are for developing regional biological criteria and water resource standards, and for setting management goals for nonpoint-source pollution. Explanation of the methods used to delineate the ecoregions are given in Omernik (1995), Griffith et al. (1994), and Gallant et al. (1989). This series of maps has been produced as part of a regional interagency collaborative project aimed at obtaining consensus between the EPA, the NRCS, and the USFS regarding alignments of ecological regions.^^xsd:string</para>
    ///   <para>rdfs:label : Omernik_Level_Four_Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_IV_Ecoregion_Classification">geosp:Omernik_Level_IV_Ecoregion_Classification</a>
    /// </summary>
    let Omernik_Level_IV_Ecoregion_Classification = _prefixId.prefix "Omernik_Level_IV_Ecoregion_Classification"

    /// <summary>
    ///   <para>dc11:description : A OpenCyc resource^^xsd:string</para>
    ///   <para>rdfs:label : OpenCycConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#OpenCycConcept">geosp:OpenCycConcept</a>
    /// </summary>
    let OpenCycConcept = _prefixId.prefix "OpenCycConcept"
    /// <summary>
    ///   <para>rdfs:label : OrderConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#OrderConcept">geosp:OrderConcept</a>
    /// </summary>
    let OrderConcept = _prefixId.prefix "OrderConcept"
    /// <summary>
    ///   <para>rdfs:label : PhotoCollection^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#PhotoCollection">geosp:PhotoCollection</a>
    /// </summary>
    let PhotoCollection = _prefixId.prefix "PhotoCollection"
    /// <summary>
    ///   <para>rdfs:label : PhylumConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#PhylumConcept">geosp:PhylumConcept</a>
    /// </summary>
    let PhylumConcept = _prefixId.prefix "PhylumConcept"
    /// <summary>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Project">geosp:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Sex^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Sex">geosp:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    let Sex_female = _prefixId.prefix "Sex_female"
    let Sex_hermaphrodite = _prefixId.prefix "Sex_hermaphrodite"
    let Sex_male = _prefixId.prefix "Sex_male"
    let Sex_undetermined = _prefixId.prefix "Sex_undetermined"
    let Sex_unknowable = _prefixId.prefix "Sex_unknowable"
    /// <summary>
    ///   <para>rdfs:label : SpeciesConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#SpeciesConcept">geosp:SpeciesConcept</a>
    /// </summary>
    let SpeciesConcept = _prefixId.prefix "SpeciesConcept"
    /// <summary>
    ///   <para>rdfs:comment : State or Province^^xsd:string</para>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#State">geosp:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : TaxonConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#TaxonConcept">geosp:TaxonConcept</a>
    /// </summary>
    let TaxonConcept = _prefixId.prefix "TaxonConcept"
    /// <summary>
    ///   <para>rdfs:label : TaxonRank^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#TaxonRank">geosp:TaxonRank</a>
    /// </summary>
    let TaxonRank = _prefixId.prefix "TaxonRank"
    let TaxonRank_class = _prefixId.prefix "TaxonRank_class"
    let TaxonRank_cultivar = _prefixId.prefix "TaxonRank_cultivar"
    let TaxonRank_cultivarGroup = _prefixId.prefix "TaxonRank_cultivarGroup"
    let TaxonRank_domain = _prefixId.prefix "TaxonRank_domain"
    let TaxonRank_family = _prefixId.prefix "TaxonRank_family"
    let TaxonRank_form = _prefixId.prefix "TaxonRank_form"
    let TaxonRank_genus = _prefixId.prefix "TaxonRank_genus"
    let TaxonRank_infraorder = _prefixId.prefix "TaxonRank_infraorder"
    let TaxonRank_kingdom = _prefixId.prefix "TaxonRank_kingdom"
    let TaxonRank_order = _prefixId.prefix "TaxonRank_order"
    let TaxonRank_phylum = _prefixId.prefix "TaxonRank_phylum"
    let TaxonRank_section = _prefixId.prefix "TaxonRank_section"
    let TaxonRank_species = _prefixId.prefix "TaxonRank_species"
    let TaxonRank_speciesAggregate = _prefixId.prefix "TaxonRank_speciesAggregate"
    let TaxonRank_subclass = _prefixId.prefix "TaxonRank_subclass"
    let TaxonRank_subfamily = _prefixId.prefix "TaxonRank_subfamily"
    let TaxonRank_subform = _prefixId.prefix "TaxonRank_subform"
    let TaxonRank_subgenus = _prefixId.prefix "TaxonRank_subgenus"
    let TaxonRank_subkingdom = _prefixId.prefix "TaxonRank_subkingdom"
    let TaxonRank_suborder = _prefixId.prefix "TaxonRank_suborder"
    let TaxonRank_subphylum = _prefixId.prefix "TaxonRank_subphylum"
    let TaxonRank_subsection = _prefixId.prefix "TaxonRank_subsection"
    let TaxonRank_subspecies = _prefixId.prefix "TaxonRank_subspecies"

    let TaxonRank_subspecificAggregate = _prefixId.prefix "TaxonRank_subspecificAggregate"

    let TaxonRank_subtribe = _prefixId.prefix "TaxonRank_subtribe"
    let TaxonRank_subvariety = _prefixId.prefix "TaxonRank_subvariety"
    let TaxonRank_superclass = _prefixId.prefix "TaxonRank_superclass"
    let TaxonRank_superfamily = _prefixId.prefix "TaxonRank_superfamily"
    let TaxonRank_superorder = _prefixId.prefix "TaxonRank_superorder"
    let TaxonRank_tribe = _prefixId.prefix "TaxonRank_tribe"
    let TaxonRank_variety = _prefixId.prefix "TaxonRank_variety"
    /// <summary>
    ///   <para>rdfs:label : taxonomicStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus">geosp:TaxonomicStatus</a>
    /// </summary>
    let TaxonomicStatus = _prefixId.prefix "TaxonomicStatus"
    let TaxonomicStatus_accepted = _prefixId.prefix "TaxonomicStatus_accepted"

    let TaxonomicStatus_heterotypicSynonym = _prefixId.prefix "TaxonomicStatus_heterotypicSynonym"

    let TaxonomicStatus_homotypicSynonym = _prefixId.prefix "TaxonomicStatus_homotypicSynonym"

    let TaxonomicStatus_invalid = _prefixId.prefix "TaxonomicStatus_invalid"
    let TaxonomicStatus_misapplied = _prefixId.prefix "TaxonomicStatus_misapplied"

    let TaxonomicStatus_proParteSynonym = _prefixId.prefix "TaxonomicStatus_proParteSynonym"

    let TaxonomicStatus_synonym = _prefixId.prefix "TaxonomicStatus_synonym"
    let TaxonomicStatus_unaccepted = _prefixId.prefix "TaxonomicStatus_unaccepted"
    let TaxonomicStatus_unverified = _prefixId.prefix "TaxonomicStatus_unverified"
    /// <summary>
    ///   <para>rdfs:label : ThreatStatusIUCN^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#ThreatStatusIUCN">geosp:ThreatStatusIUCN</a>
    /// </summary>
    let ThreatStatusIUCN = _prefixId.prefix "ThreatStatusIUCN"
    /// <summary>
    ///   <para>rdfs:label : TypeStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#TypeStatus">geosp:TypeStatus</a>
    /// </summary>
    let TypeStatus = _prefixId.prefix "TypeStatus"
    let TypeStatus_hapantotype = _prefixId.prefix "TypeStatus_hapantotype"
    let TypeStatus_holotype = _prefixId.prefix "TypeStatus_holotype"
    let TypeStatus_lectotype = _prefixId.prefix "TypeStatus_lectotype"
    let TypeStatus_neotype = _prefixId.prefix "TypeStatus_neotype"
    let TypeStatus_paralectotype = _prefixId.prefix "TypeStatus_paralectotype"
    let TypeStatus_paratype = _prefixId.prefix "TypeStatus_paratype"
    let TypeStatus_syntype = _prefixId.prefix "TypeStatus_syntype"
    let TypeStatus_varitype = _prefixId.prefix "TypeStatus_varitype"
    /// <summary>
    ///   <para>rdfs:label : USDA_Growth_Habit^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit">geosp:USDA_Growth_Habit</a>
    /// </summary>
    let USDA_Growth_Habit = _prefixId.prefix "USDA_Growth_Habit"
    let USDA_Growth_Habit_Forb_Herb = _prefixId.prefix "USDA_Growth_Habit_Forb_Herb"
    let USDA_Growth_Habit_Graminoid = _prefixId.prefix "USDA_Growth_Habit_Graminoid"
    let USDA_Growth_Habit_Liana = _prefixId.prefix "USDA_Growth_Habit_Liana"
    let USDA_Growth_Habit_Lichenous = _prefixId.prefix "USDA_Growth_Habit_Lichenous"
    let USDA_Growth_Habit_Nonvascular = _prefixId.prefix "USDA_Growth_Habit_Nonvascular"
    let USDA_Growth_Habit_Shrub = _prefixId.prefix "USDA_Growth_Habit_Shrub"
    let USDA_Growth_Habit_Subshrub = _prefixId.prefix "USDA_Growth_Habit_Subshrub"
    let USDA_Growth_Habit_Tree = _prefixId.prefix "USDA_Growth_Habit_Tree"
    let USDA_Growth_Habit_Unknown = _prefixId.prefix "USDA_Growth_Habit_Unknown"
    let USDA_Growth_Habit_Vine = _prefixId.prefix "USDA_Growth_Habit_Vine"
    /// <summary>
    ///   <para>rdfs:label : Native Jurisdiction Code^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Jurisdiction_Code">geosp:USDA_Native_Jurisdiction_Code</a>
    /// </summary>
    let USDA_Native_Jurisdiction_Code = _prefixId.prefix "USDA_Native_Jurisdiction_Code"
    /// <summary>
    ///   <para>rdfs:label : USDA_Native_Status^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status">geosp:USDA_Native_Status</a>
    /// </summary>
    let USDA_Native_Status = _prefixId.prefix "USDA_Native_Status"

    let USDA_Native_Status_Introduced_Garden_persistent = _prefixId.prefix "USDA_Native_Status_Introduced_Garden_persistent"

    let USDA_Native_Status_Introduced_Introduced = _prefixId.prefix "USDA_Native_Status_Introduced_Introduced"

    let USDA_Native_Status_Introduced_Probably_Garden_persistent = _prefixId.prefix "USDA_Native_Status_Introduced_Probably_Garden_persistent"

    let USDA_Native_Status_Introduced_Probably_Introduced = _prefixId.prefix "USDA_Native_Status_Introduced_Probably_Introduced"

    let USDA_Native_Status_Introduced_Probably_Native_and_Introduced = _prefixId.prefix "USDA_Native_Status_Introduced_Probably_Native_and_Introduced"

    let USDA_Native_Status_Introduced_Probably_a_Waif = _prefixId.prefix "USDA_Native_Status_Introduced_Probably_a_Waif"

    let USDA_Native_Status_Introduced_Waif = _prefixId.prefix "USDA_Native_Status_Introduced_Waif"

    let USDA_Native_Status_Native_Native = _prefixId.prefix "USDA_Native_Status_Native_Native"

    let USDA_Native_Status_Native_Native_and_Introduced = _prefixId.prefix "USDA_Native_Status_Native_Native_and_Introduced"

    let USDA_Native_Status_Native_Native_and_Probably_Introduced = _prefixId.prefix "USDA_Native_Status_Native_Native_and_Probably_Introduced"

    let USDA_Native_Status_Native_Probably_Native = _prefixId.prefix "USDA_Native_Status_Native_Probably_Native"

    /// <summary>
    ///   <para>dc11:description : From USDA Plants Project: "We have Characteristics for about 2000 conservation plant species and 500 additional cultivars. (A cultivar is a variety, strain, or race that has originated and persisted under cultivation or was specifically developed for cultivation; cultivar is the cultivated plant equivalent of botanical variety.) Mostly we have species (not cultivar) data since conservation plants are primarily native plants without named cultivars. We also have this species data for most of the plants that have cultivar data, and the data ranges for a species generally encompass the ranges for its cultivar(s). In a few cases we have cultivar data only.
    ///
    /// These data have been gathered from the scientific literature, gray literature, agency documents, and the knowledge of plant specialists. Characteristics data values are best viewed as approximations since they are primarily based on field observations and estimates from the literature, not precise measurements or experiments. Characteristics for the many conservation plant species native to the U.S. were typically provided by experts familiar with the species in its natural setting. Most values given apply to plants nationwide. Many values are relative to other species since absolute figures are not available"^^xsd:string</para>
    ///   <para>rdfs:label : USDA_Plants_Characteristics^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#USDA_Plant_Characteristics">geosp:USDA_Plant_Characteristics</a>
    /// </summary>
    let USDA_Plant_Characteristics = _prefixId.prefix "USDA_Plant_Characteristics"
    /// <summary>
    ///   <para>rdfs:label : UUID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#UUID">geosp:UUID</a>
    /// </summary>
    let UUID = _prefixId.prefix "UUID"
    /// <summary>
    ///   <para>rdfs:label : Ubio_LSID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Ubio_LSID">geosp:Ubio_LSID</a>
    /// </summary>
    let Ubio_LSID = _prefixId.prefix "Ubio_LSID"
    /// <summary>
    ///   <para>rdfs:label : UniprotTaxon^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#UniprotTaxon">geosp:UniprotTaxon</a>
    /// </summary>
    let UniprotTaxon = _prefixId.prefix "UniprotTaxon"
    /// <summary>
    ///   <para>rdfs:label : WikipediaArticle^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#WikipediaArticle">geosp:WikipediaArticle</a>
    /// </summary>
    let WikipediaArticle = _prefixId.prefix "WikipediaArticle"
    /// <summary>
    ///   <para>rdfs:label : WikispeciesArticle^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#WikispeciesArticle">geosp:WikispeciesArticle</a>
    /// </summary>
    let WikispeciesArticle = _prefixId.prefix "WikispeciesArticle"

    let Wisconsin_Herbarium_Beech_Forest = _prefixId.prefix "Wisconsin_Herbarium_Beech_Forest"

    let Wisconsin_Herbarium_Bog_and_Fen = _prefixId.prefix "Wisconsin_Herbarium_Bog_and_Fen"

    let Wisconsin_Herbarium_Boreal_Forest = _prefixId.prefix "Wisconsin_Herbarium_Boreal_Forest"

    let Wisconsin_Herbarium_Bracken_Grassland = _prefixId.prefix "Wisconsin_Herbarium_Bracken_Grassland"

    let Wisconsin_Herbarium_Cliff = _prefixId.prefix "Wisconsin_Herbarium_Cliff"

    let Wisconsin_Herbarium_Emergent_Aquatic = _prefixId.prefix "Wisconsin_Herbarium_Emergent_Aquatic"

    /// <summary>
    ///   <para>dc11:description : C.E. Umbanhowar, Jr.'s revised "Vegetation of Wisconsin Habitats" as originally defined by J.T. Curtis (Wisconsin Plant Ecology Laboratory Data (PEL))
    ///
    /// The descriptions under each major habitat type were written by Eric J. Epstein, Emmet J. Judziewicz, and Elizabeth Spencer of the Natural Heritage Inventory (NHI), Bureau of Endangered Resources, Wisconsin Department of Natural Resources for the forthcoming Habitat Database of Endangered, Theatened, and Special Concern Vascular Plants, and must be considered tentative.  They were condensed and summarized for the Curtis-Umbanhowar classification by Judziewicz.  Not all NHI type as currently recognized are included in the preliminary classification below.^^xsd:anyURI</para>
    ///   <para>rdfs:label : Wisconsin Herbarium Habitat Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Habitat_Classification">geosp:Wisconsin_Herbarium_Habitat_Classification</a>
    /// </summary>
    let Wisconsin_Herbarium_Habitat_Classification = _prefixId.prefix "Wisconsin_Herbarium_Habitat_Classification"

    let Wisconsin_Herbarium_Northern_Lowland_Forest = _prefixId.prefix "Wisconsin_Herbarium_Northern_Lowland_Forest"

    let Wisconsin_Herbarium_Northern_Upland_Forest = _prefixId.prefix "Wisconsin_Herbarium_Northern_Upland_Forest"

    let Wisconsin_Herbarium_Pine_Barrens = _prefixId.prefix "Wisconsin_Herbarium_Pine_Barrens"

    let Wisconsin_Herbarium_Prairie = _prefixId.prefix "Wisconsin_Herbarium_Prairie"

    let Wisconsin_Herbarium_Sand_Barrens = _prefixId.prefix "Wisconsin_Herbarium_Sand_Barrens"

    let Wisconsin_Herbarium_Sand_Dunes = _prefixId.prefix "Wisconsin_Herbarium_Sand_Dunes"

    let Wisconsin_Herbarium_Savanna = _prefixId.prefix "Wisconsin_Herbarium_Savanna"

    let Wisconsin_Herbarium_Sedge_Meadow = _prefixId.prefix "Wisconsin_Herbarium_Sedge_Meadow"

    let Wisconsin_Herbarium_Shrub_Carr = _prefixId.prefix "Wisconsin_Herbarium_Shrub_Carr"

    let Wisconsin_Herbarium_Southern_Lowland_Forest = _prefixId.prefix "Wisconsin_Herbarium_Southern_Lowland_Forest"

    let Wisconsin_Herbarium_Southern_Upland_Forest = _prefixId.prefix "Wisconsin_Herbarium_Southern_Upland_Forest"

    /// <summary>
    ///   <para>rdfs:label : Wisconsin_Natural_Heritage_Inventory Habitat_Classification^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Natural_Heritage_Inventory_Habitat_Classification">geosp:Wisconsin_Natural_Heritage_Inventory_Habitat_Classification</a>
    /// </summary>
    let Wisconsin_Natural_Heritage_Inventory_Habitat_Classification = _prefixId.prefix "Wisconsin_Natural_Heritage_Inventory_Habitat_Classification"

    let World_Pyrochroidae_Database = _prefixId.prefix "World_Pyrochroidae_Database"
    /// <summary>
    ///   <para>rdfs:label : hasSpeciesAssociation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#habitatHasSpeciesAssociation">geosp:habitatHasSpeciesAssociation</a>
    /// </summary>
    let habitatHasSpeciesAssociation = _prefixId.prefix "habitatHasSpeciesAssociation"
    /// <summary>
    ///   <para>rdfs:label : hasBBCHabitatPreference^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBBCHabitatAssociation">geosp:hasBBCHabitatAssociation</a>
    /// </summary>
    let hasBBCHabitatAssociation = _prefixId.prefix "hasBBCHabitatAssociation"
    /// <summary>
    ///   <para>rdfs:label : hasBBC_Ecozone^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Ecozone">geosp:hasBBC_Ecozone</a>
    /// </summary>
    let hasBBC_Ecozone = _prefixId.prefix "hasBBC_Ecozone"
    /// <summary>
    ///   <para>rdfs:label : hasBBC_EcozoneName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBBC_EcozoneName">geosp:hasBBC_EcozoneName</a>
    /// </summary>
    let hasBBC_EcozoneName = _prefixId.prefix "hasBBC_EcozoneName"
    /// <summary>
    ///   <para>rdfs:label : hasBBC_Habitat^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Habitat">geosp:hasBBC_Habitat</a>
    /// </summary>
    let hasBBC_Habitat = _prefixId.prefix "hasBBC_Habitat"
    /// <summary>
    ///   <para>rdfs:label : hasBasionymName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBasionymName">geosp:hasBasionymName</a>
    /// </summary>
    let hasBasionymName = _prefixId.prefix "hasBasionymName"
    /// <summary>
    ///   <para>rdfs:label : hasBio2RDFtaxon^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBio2RDFtaxon">geosp:hasBio2RDFtaxon</a>
    /// </summary>
    let hasBio2RDFtaxon = _prefixId.prefix "hasBio2RDFtaxon"
    /// <summary>
    ///   <para>rdfs:label : hasBioLib^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBioLib">geosp:hasBioLib</a>
    /// </summary>
    let hasBioLib = _prefixId.prefix "hasBioLib"
    /// <summary>
    ///   <para>rdfs:label : hasBioLibPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBioLibPage">geosp:hasBioLibPage</a>
    /// </summary>
    let hasBioLibPage = _prefixId.prefix "hasBioLibPage"
    /// <summary>
    ///   <para>rdfs:label : hasBugGuidePage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasBugGuidePage">geosp:hasBugGuidePage</a>
    /// </summary>
    let hasBugGuidePage = _prefixId.prefix "hasBugGuidePage"
    /// <summary>
    ///   <para>rdfs:label : hasCanonicalName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCanonicalName">geosp:hasCanonicalName</a>
    /// </summary>
    let hasCanonicalName = _prefixId.prefix "hasCanonicalName"
    /// <summary>
    ///   <para>rdfs:label : hasClassName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasClassName">geosp:hasClassName</a>
    /// </summary>
    let hasClassName = _prefixId.prefix "hasClassName"
    /// <summary>
    ///   <para>dc11:description : Catalog of Life LSID^^xsd:string</para>
    ///   <para>rdfs:label : hasCoL_LSID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCoL_LSID">geosp:hasCoL_LSID</a>
    /// </summary>
    let hasCoL_LSID = _prefixId.prefix "hasCoL_LSID"
    /// <summary>
    ///   <para>rdfs:label : hasCollectionCode^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCollectionCode">geosp:hasCollectionCode</a>
    /// </summary>
    let hasCollectionCode = _prefixId.prefix "hasCollectionCode"
    /// <summary>
    ///   <para>rdfs:label : hasCollector^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCollector">geosp:hasCollector</a>
    /// </summary>
    let hasCollector = _prefixId.prefix "hasCollector"
    /// <summary>
    ///   <para>rdfs:label : hasCommonName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCommonName">geosp:hasCommonName</a>
    /// </summary>
    let hasCommonName = _prefixId.prefix "hasCommonName"
    /// <summary>
    ///   <para>rdfs:label : hasContinent^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasContinent">geosp:hasContinent</a>
    /// </summary>
    let hasContinent = _prefixId.prefix "hasContinent"
    /// <summary>
    ///   <para>rdfs:label : hasContinentName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasContinentName">geosp:hasContinentName</a>
    /// </summary>
    let hasContinentName = _prefixId.prefix "hasContinentName"
    /// <summary>
    ///   <para>rdfs:label : hasCountry^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCountry">geosp:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>rdfs:label : hasCountryCode^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCountryCode">geosp:hasCountryCode</a>
    /// </summary>
    let hasCountryCode = _prefixId.prefix "hasCountryCode"
    /// <summary>
    ///   <para>rdfs:label : hasCountryName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCountryName">geosp:hasCountryName</a>
    /// </summary>
    let hasCountryName = _prefixId.prefix "hasCountryName"
    /// <summary>
    ///   <para>rdfs:label : hasCounty^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCounty">geosp:hasCounty</a>
    /// </summary>
    let hasCounty = _prefixId.prefix "hasCounty"
    /// <summary>
    ///   <para>rdfs:label : hasCountyName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasCountyName">geosp:hasCountyName</a>
    /// </summary>
    let hasCountyName = _prefixId.prefix "hasCountyName"
    /// <summary>
    ///   <para>rdfs:label : hasDBpediaResource^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasDBpediaResource">geosp:hasDBpediaResource</a>
    /// </summary>
    let hasDBpediaResource = _prefixId.prefix "hasDBpediaResource"
    /// <summary>
    ///   <para>rdfs:label : hasEOLPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasEOLPage">geosp:hasEOLPage</a>
    /// </summary>
    let hasEOLPage = _prefixId.prefix "hasEOLPage"
    /// <summary>
    ///   <para>rdfs:label : hasEndDate^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasEndDate">geosp:hasEndDate</a>
    /// </summary>
    let hasEndDate = _prefixId.prefix "hasEndDate"
    /// <summary>
    ///   <para>rdfs:label : hasEndDayOfYear^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasEndDayOfYear">geosp:hasEndDayOfYear</a>
    /// </summary>
    let hasEndDayOfYear = _prefixId.prefix "hasEndDayOfYear"
    /// <summary>
    ///   <para>rdfs:label : hasExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasExpectationOf">geosp:hasExpectationOf</a>
    /// </summary>
    let hasExpectationOf = _prefixId.prefix "hasExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasFamilyInfoContributor^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasFamilyInfoContributor">geosp:hasFamilyInfoContributor</a>
    /// </summary>
    let hasFamilyInfoContributor = _prefixId.prefix "hasFamilyInfoContributor"
    /// <summary>
    ///   <para>rdfs:label : hasFamilyName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasFamilyName">geosp:hasFamilyName</a>
    /// </summary>
    let hasFamilyName = _prefixId.prefix "hasFamilyName"
    /// <summary>
    ///   <para>rdfs:label : FreebaseResource^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasFreebaseResource">geosp:hasFreebaseResource</a>
    /// </summary>
    let hasFreebaseResource = _prefixId.prefix "hasFreebaseResource"
    /// <summary>
    ///   <para>rdfs:label : hasGBIF^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGBIF">geosp:hasGBIF</a>
    /// </summary>
    let hasGBIF = _prefixId.prefix "hasGBIF"
    /// <summary>
    ///   <para>rdfs:label : hasGBIFPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGBIFPage">geosp:hasGBIFPage</a>
    /// </summary>
    let hasGBIFPage = _prefixId.prefix "hasGBIFPage"
    /// <summary>
    ///   <para>rdfs:label : hasGNI^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGNI">geosp:hasGNI</a>
    /// </summary>
    let hasGNI = _prefixId.prefix "hasGNI"
    /// <summary>
    ///   <para>rdfs:label : hasGenusName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGenusName">geosp:hasGenusName</a>
    /// </summary>
    let hasGenusName = _prefixId.prefix "hasGenusName"
    /// <summary>
    ///   <para>rdfs:label : hasGeoSpeciesConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGeoSpeciesConcept">geosp:hasGeoSpeciesConcept</a>
    /// </summary>
    let hasGeoSpeciesConcept = _prefixId.prefix "hasGeoSpeciesConcept"
    /// <summary>
    ///   <para>rdfs:label : hasGeodeticDatum^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasGeodeticDatum">geosp:hasGeodeticDatum</a>
    /// </summary>
    let hasGeodeticDatum = _prefixId.prefix "hasGeodeticDatum"
    /// <summary>
    ///   <para>rdfs:label : hasHumanCollector^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollector">geosp:hasHumanCollector</a>
    /// </summary>
    let hasHumanCollector = _prefixId.prefix "hasHumanCollector"
    /// <summary>
    ///   <para>rdfs:label : hasHumanCollector^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollectorName">geosp:hasHumanCollectorName</a>
    /// </summary>
    let hasHumanCollectorName = _prefixId.prefix "hasHumanCollectorName"
    /// <summary>
    ///   <para>rdfs:label : hasHumanIdentifier^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifier">geosp:hasHumanIdentifier</a>
    /// </summary>
    let hasHumanIdentifier = _prefixId.prefix "hasHumanIdentifier"
    /// <summary>
    ///   <para>rdfs:label : hasHumanIdentifierName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifierName">geosp:hasHumanIdentifierName</a>
    /// </summary>
    let hasHumanIdentifierName = _prefixId.prefix "hasHumanIdentifierName"
    /// <summary>
    ///   <para>rdfs:label : hasITIS^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasITIS">geosp:hasITIS</a>
    /// </summary>
    let hasITIS = _prefixId.prefix "hasITIS"
    /// <summary>
    ///   <para>rdfs:label : hasITISPage^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasITISPage">geosp:hasITISPage</a>
    /// </summary>
    let hasITISPage = _prefixId.prefix "hasITISPage"
    /// <summary>
    ///   <para>rdfs:label : hasInfraspecificEpithet^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasInfraspecificEpithet">geosp:hasInfraspecificEpithet</a>
    /// </summary>
    let hasInfraspecificEpithet = _prefixId.prefix "hasInfraspecificEpithet"
    /// <summary>
    ///   <para>rdfs:label : hasKingdomName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasKingdomName">geosp:hasKingdomName</a>
    /// </summary>
    let hasKingdomName = _prefixId.prefix "hasKingdomName"
    /// <summary>
    ///   <para>rdfs:label : hasLocality^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocality">geosp:hasLocality</a>
    /// </summary>
    let hasLocality = _prefixId.prefix "hasLocality"
    /// <summary>
    ///   <para>rdfs:label : hasLocalityName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocalityName">geosp:hasLocalityName</a>
    /// </summary>
    let hasLocalityName = _prefixId.prefix "hasLocalityName"
    /// <summary>
    ///   <para>rdfs:label : hasLocalityText^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocalityText">geosp:hasLocalityText</a>
    /// </summary>
    let hasLocalityText = _prefixId.prefix "hasLocalityText"
    /// <summary>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocation">geosp:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : hasLocationName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocationName">geosp:hasLocationName</a>
    /// </summary>
    let hasLocationName = _prefixId.prefix "hasLocationName"
    /// <summary>
    ///   <para>rdfs:label : hasLocationName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLocationText">geosp:hasLocationText</a>
    /// </summary>
    let hasLocationText = _prefixId.prefix "hasLocationText"
    /// <summary>
    ///   <para>rdfs:label : hasLowExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLowExpectationOf">geosp:hasLowExpectationOf</a>
    /// </summary>
    let hasLowExpectationOf = _prefixId.prefix "hasLowExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasLowUSDA_ExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasLowUSDA_ExpectationOf">geosp:hasLowUSDA_ExpectationOf</a>
    /// </summary>
    let hasLowUSDA_ExpectationOf = _prefixId.prefix "hasLowUSDA_ExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasNCBITaxonID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasNCBITaxonID">geosp:hasNCBITaxonID</a>
    /// </summary>
    let hasNCBITaxonID = _prefixId.prefix "hasNCBITaxonID"
    /// <summary>
    ///   <para>rdfs:label : hasNoUSDA_ExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasNoUSDA_ExpectationOf">geosp:hasNoUSDA_ExpectationOf</a>
    /// </summary>
    let hasNoUSDA_ExpectationOf = _prefixId.prefix "hasNoUSDA_ExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasNomenclaturalCode^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCode">geosp:hasNomenclaturalCode</a>
    /// </summary>
    let hasNomenclaturalCode = _prefixId.prefix "hasNomenclaturalCode"
    /// <summary>
    ///   <para>rdfs:label : hasNomenclaturalCodeString^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCodeString">geosp:hasNomenclaturalCodeString</a>
    /// </summary>
    let hasNomenclaturalCodeString = _prefixId.prefix "hasNomenclaturalCodeString"
    /// <summary>
    ///   <para>rdfs:label : hasObservation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasObservation">geosp:hasObservation</a>
    /// </summary>
    let hasObservation = _prefixId.prefix "hasObservation"
    /// <summary>
    ///   <para>rdfs:label : hasObservationMethod^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasObservationMethod">geosp:hasObservationMethod</a>
    /// </summary>
    let hasObservationMethod = _prefixId.prefix "hasObservationMethod"
    /// <summary>
    ///   <para>rdfs:label : hasObservationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasObservationOf">geosp:hasObservationOf</a>
    /// </summary>
    let hasObservationOf = _prefixId.prefix "hasObservationOf"
    /// <summary>
    ///   <para>rdfs:label : hasOccurrenceStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasOccurrenceStatus">geosp:hasOccurrenceStatus</a>
    /// </summary>
    let hasOccurrenceStatus = _prefixId.prefix "hasOccurrenceStatus"
    /// <summary>
    ///   <para>rdfs:label : hasOmernik_3_Ecozone^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_3_Ecozone">geosp:hasOmernik_3_Ecozone</a>
    /// </summary>
    let hasOmernik_3_Ecozone = _prefixId.prefix "hasOmernik_3_Ecozone"
    /// <summary>
    ///   <para>rdfs:label : hasOmernik_4_Ecozone^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_4_Ecozone">geosp:hasOmernik_4_Ecozone</a>
    /// </summary>
    let hasOmernik_4_Ecozone = _prefixId.prefix "hasOmernik_4_Ecozone"
    /// <summary>
    ///   <para>rdfs:label : hasOrderName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasOrderName">geosp:hasOrderName</a>
    /// </summary>
    let hasOrderName = _prefixId.prefix "hasOrderName"
    /// <summary>
    ///   <para>rdfs:label : hasPhylumName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasPhylumName">geosp:hasPhylumName</a>
    /// </summary>
    let hasPhylumName = _prefixId.prefix "hasPhylumName"
    /// <summary>
    ///   <para>rdfs:label : hasProject^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasProject">geosp:hasProject</a>
    /// </summary>
    let hasProject = _prefixId.prefix "hasProject"
    /// <summary>
    ///   <para>rdfs:label : hasScientificName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasScientificName">geosp:hasScientificName</a>
    /// </summary>
    let hasScientificName = _prefixId.prefix "hasScientificName"
    /// <summary>
    ///   <para>rdfs:label : hasScientificNameAuthorship^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameAuthorship">geosp:hasScientificNameAuthorship</a>
    /// </summary>
    let hasScientificNameAuthorship = _prefixId.prefix "hasScientificNameAuthorship"
    /// <summary>
    ///   <para>rdfs:label : hasScientificNameRank^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameRank">geosp:hasScientificNameRank</a>
    /// </summary>
    let hasScientificNameRank = _prefixId.prefix "hasScientificNameRank"
    /// <summary>
    ///   <para>rdfs:label : hasSex^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasSex">geosp:hasSex</a>
    /// </summary>
    let hasSex = _prefixId.prefix "hasSex"
    /// <summary>
    ///   <para>rdfs:label : hasSpecies^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasSpecies">geosp:hasSpecies</a>
    /// </summary>
    let hasSpecies = _prefixId.prefix "hasSpecies"
    /// <summary>
    ///   <para>rdfs:label : hasSpecificEpithet^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasSpecificEpithet">geosp:hasSpecificEpithet</a>
    /// </summary>
    let hasSpecificEpithet = _prefixId.prefix "hasSpecificEpithet"
    /// <summary>
    ///   <para>rdfs:label : hasStartDate^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasStartDate">geosp:hasStartDate</a>
    /// </summary>
    let hasStartDate = _prefixId.prefix "hasStartDate"
    /// <summary>
    ///   <para>rdfs:label : hasStartDayOfYear^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasStartDayOfYear">geosp:hasStartDayOfYear</a>
    /// </summary>
    let hasStartDayOfYear = _prefixId.prefix "hasStartDayOfYear"
    /// <summary>
    ///   <para>rdfs:label : hasStateProvName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasStateProvName">geosp:hasStateProvName</a>
    /// </summary>
    let hasStateProvName = _prefixId.prefix "hasStateProvName"
    /// <summary>
    ///   <para>rdfs:label : hasStateProv^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasStateProvince">geosp:hasStateProvince</a>
    /// </summary>
    let hasStateProvince = _prefixId.prefix "hasStateProvince"
    /// <summary>
    ///   <para>rdfs:label : hasStateProvinceName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasStateProvinceName">geosp:hasStateProvinceName</a>
    /// </summary>
    let hasStateProvinceName = _prefixId.prefix "hasStateProvinceName"
    /// <summary>
    ///   <para>rdfs:label : hasSubfamilyName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasSubfamilyName">geosp:hasSubfamilyName</a>
    /// </summary>
    let hasSubfamilyName = _prefixId.prefix "hasSubfamilyName"
    /// <summary>
    ///   <para>rdfs:label : hasSubgenusName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasSubgenusName">geosp:hasSubgenusName</a>
    /// </summary>
    let hasSubgenusName = _prefixId.prefix "hasSubgenusName"
    /// <summary>
    ///   <para>rdfs:label : hasTDWG_Concept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasTDWG_Concept">geosp:hasTDWG_Concept</a>
    /// </summary>
    let hasTDWG_Concept = _prefixId.prefix "hasTDWG_Concept"
    /// <summary>
    ///   <para>rdfs:label : hasTaxonConcept^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasTaxonConcept">geosp:hasTaxonConcept</a>
    /// </summary>
    let hasTaxonConcept = _prefixId.prefix "hasTaxonConcept"
    /// <summary>
    ///   <para>rdfs:label : hasTaxonomicStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasTaxonomicStatus">geosp:hasTaxonomicStatus</a>
    /// </summary>
    let hasTaxonomicStatus = _prefixId.prefix "hasTaxonomicStatus"
    /// <summary>
    ///   <para>rdfs:label : hasTreeBaseID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasTreeBaseID">geosp:hasTreeBaseID</a>
    /// </summary>
    let hasTreeBaseID = _prefixId.prefix "hasTreeBaseID"
    /// <summary>
    ///   <para>rdfs:label : hasTypeStatus^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasTypeStatus">geosp:hasTypeStatus</a>
    /// </summary>
    let hasTypeStatus = _prefixId.prefix "hasTypeStatus"
    /// <summary>
    ///   <para>rdfs:label : hasUSDA_ExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasUSDA_ExpectationOf">geosp:hasUSDA_ExpectationOf</a>
    /// </summary>
    let hasUSDA_ExpectationOf = _prefixId.prefix "hasUSDA_ExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasUUID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasUUID">geosp:hasUUID</a>
    /// </summary>
    let hasUUID = _prefixId.prefix "hasUUID"
    /// <summary>
    ///   <para>dc11:description : uBio NameBankID^^xsd:string</para>
    ///   <para>rdfs:label : hasUbio_LSID^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasUbio_LSID">geosp:hasUbio_LSID</a>
    /// </summary>
    let hasUbio_LSID = _prefixId.prefix "hasUbio_LSID"
    /// <summary>
    ///   <para>dc11:description : It is unknown if the taxon is expected in feature or not.^^xsd:string</para>
    ///   <para>rdfs:label : hasUnknownExpectationOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasUnknownExpectationOf">geosp:hasUnknownExpectationOf</a>
    /// </summary>
    let hasUnknownExpectationOf = _prefixId.prefix "hasUnknownExpectationOf"
    /// <summary>
    ///   <para>rdfs:label : hasVernacularName^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasVernacularName">geosp:hasVernacularName</a>
    /// </summary>
    let hasVernacularName = _prefixId.prefix "hasVernacularName"
    /// <summary>
    ///   <para>rdfs:label : hasWI_Herbarium_Habitat^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWI_Herbarium_Habitat">geosp:hasWI_Herbarium_Habitat</a>
    /// </summary>
    let hasWI_Herbarium_Habitat = _prefixId.prefix "hasWI_Herbarium_Habitat"
    /// <summary>
    ///   <para>rdfs:label : hasWikipediaArticle^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWikipediaArticle">geosp:hasWikipediaArticle</a>
    /// </summary>
    let hasWikipediaArticle = _prefixId.prefix "hasWikipediaArticle"
    /// <summary>
    ///   <para>rdfs:label : hasWikispeciesArticle^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWikispeciesArticle">geosp:hasWikispeciesArticle</a>
    /// </summary>
    let hasWikispeciesArticle = _prefixId.prefix "hasWikispeciesArticle"

    /// <summary>
    ///   <para>rdfs:label : hasWisconsinHerbariumHabitatAssociation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatAssociation">geosp:hasWisconsinHerbariumHabitatAssociation</a>
    /// </summary>
    let hasWisconsinHerbariumHabitatAssociation = _prefixId.prefix "hasWisconsinHerbariumHabitatAssociation"

    /// <summary>
    ///   <para>rdfs:label : hasWisconsinHerbariumHabitatPreference^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatPreference">geosp:hasWisconsinHerbariumHabitatPreference</a>
    /// </summary>
    let hasWisconsinHerbariumHabitatPreference = _prefixId.prefix "hasWisconsinHerbariumHabitatPreference"

    /// <summary>
    ///   <para>rdfs:label : hasWisconsinHerbariumSpeciesAssociation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumSpeciesAssociation">geosp:hasWisconsinHerbariumSpeciesAssociation</a>
    /// </summary>
    let hasWisconsinHerbariumSpeciesAssociation = _prefixId.prefix "hasWisconsinHerbariumSpeciesAssociation"

    /// <summary>
    ///   <para>rdfs:label : has_USDA_Growth_Habit^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Growth_Habit">geosp:has_USDA_Growth_Habit</a>
    /// </summary>
    let has_USDA_Growth_Habit = _prefixId.prefix "has_USDA_Growth_Habit"
    /// <summary>
    ///   <para>rdfs:label : has_USDA_Native_Status^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Native_Status">geosp:has_USDA_Native_Status</a>
    /// </summary>
    let has_USDA_Native_Status = _prefixId.prefix "has_USDA_Native_Status"
    /// <summary>
    ///   <para>rdfs:label : inClass^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#inClass">geosp:inClass</a>
    /// </summary>
    let inClass = _prefixId.prefix "inClass"
    /// <summary>
    ///   <para>rdfs:label : inFamily^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#inFamily">geosp:inFamily</a>
    /// </summary>
    let inFamily = _prefixId.prefix "inFamily"
    /// <summary>
    ///   <para>rdfs:label : inKingdom^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#inKingdom">geosp:inKingdom</a>
    /// </summary>
    let inKingdom = _prefixId.prefix "inKingdom"
    /// <summary>
    ///   <para>rdfs:label : inOrder^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#inOrder">geosp:inOrder</a>
    /// </summary>
    let inOrder = _prefixId.prefix "inOrder"
    /// <summary>
    ///   <para>rdfs:label : inPhylum^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#inPhylum">geosp:inPhylum</a>
    /// </summary>
    let inPhylum = _prefixId.prefix "inPhylum"
    /// <summary>
    ///   <para>rdfs:label : isBugGuidePageOf^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isBugGuidePageOf">geosp:isBugGuidePageOf</a>
    /// </summary>
    let isBugGuidePageOf = _prefixId.prefix "isBugGuidePageOf"
    /// <summary>
    ///   <para>rdfs:label : isExpectedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isExpectedIn">geosp:isExpectedIn</a>
    /// </summary>
    let isExpectedIn = _prefixId.prefix "isExpectedIn"
    /// <summary>
    ///   <para>rdfs:label : isNotUSDA_ExpectedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isNotUSDA_ExpectedIn">geosp:isNotUSDA_ExpectedIn</a>
    /// </summary>
    let isNotUSDA_ExpectedIn = _prefixId.prefix "isNotUSDA_ExpectedIn"
    /// <summary>
    ///   <para>rdfs:label : isUSDA_ExpectedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isUSDA_ExpectedIn">geosp:isUSDA_ExpectedIn</a>
    /// </summary>
    let isUSDA_ExpectedIn = _prefixId.prefix "isUSDA_ExpectedIn"
    /// <summary>
    ///   <para>rdfs:label : isUSDA_UnexpectedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isUSDA_UnexpectedIn">geosp:isUSDA_UnexpectedIn</a>
    /// </summary>
    let isUSDA_UnexpectedIn = _prefixId.prefix "isUSDA_UnexpectedIn"
    /// <summary>
    ///   <para>rdfs:label : isUnexpectedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isUnexpectedIn">geosp:isUnexpectedIn</a>
    /// </summary>
    let isUnexpectedIn = _prefixId.prefix "isUnexpectedIn"
    /// <summary>
    ///   <para>rdfs:label : isUnknownIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#isUnknownAboutIn">geosp:isUnknownAboutIn</a>
    /// </summary>
    let isUnknownAboutIn = _prefixId.prefix "isUnknownAboutIn"
    let nativeness_introduced = _prefixId.prefix "nativeness_introduced"
    let nativeness_invasive = _prefixId.prefix "nativeness_invasive"
    let nativeness_managed = _prefixId.prefix "nativeness_managed"
    let nativeness_native = _prefixId.prefix "nativeness_native"
    let nativeness_naturalised = _prefixId.prefix "nativeness_naturalised"
    /// <summary>
    ///   <para>rdfs:label : hasHabitatAssociation^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#speciesHasHabitatAssociation">geosp:speciesHasHabitatAssociation</a>
    /// </summary>
    let speciesHasHabitatAssociation = _prefixId.prefix "speciesHasHabitatAssociation"
    /// <summary>
    ///   <para>rdfs:label : wasObservedIn^^xsd:string</para>
    ///   <a href="http://rdf.geospecies.org/ont/geospecies#wasObservedIn">geosp:wasObservedIn</a>
    /// </summary>
    let wasObservedIn = _prefixId.prefix "wasObservedIn"
