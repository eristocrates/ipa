namespace https.w3id.org.earthsemantics.OSO.hash

open DoxAletheia

module oso =
    let _namespace_name = "https://w3id.org/earthsemantics/OSO#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mol%C3%A8ne"></see>
    /// </summary>
    let ``Mol%C3%A8ne`` = _prefix "Mol%C3%A8ne"
    /// <summary>
    /// A localized observatory site, attached to a regional facility, potentially hosting one or more measurement platforms.
    /// <see href="https://w3id.org/earthsemantics/OSO#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Canada"></see>
    /// </summary>
    let Canada = _prefix "Canada"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#France"></see>
    /// </summary>
    let France = _prefix "France"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#French_riviera"></see>
    /// </summary>
    let French_riviera = _prefix "French_riviera"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Greece"></see>
    /// </summary>
    let Greece = _prefix "Greece"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ireland"></see>
    /// </summary>
    let Ireland = _prefix "Ireland"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Italy"></see>
    /// </summary>
    let Italy = _prefix "Italy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Japan"></see>
    /// </summary>
    let Japan = _prefix "Japan"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Norway"></see>
    /// </summary>
    let Norway = _prefix "Norway"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Portugal"></see>
    /// </summary>
    let Portugal = _prefix "Portugal"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Romania"></see>
    /// </summary>
    let Romania = _prefix "Romania"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Spain"></see>
    /// </summary>
    let Spain = _prefix "Spain"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sweden"></see>
    /// </summary>
    let Sweden = _prefix "Sweden"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Turkey"></see>
    /// </summary>
    let Turkey = _prefix "Turkey"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ukraine"></see>
    /// </summary>
    let Ukraine = _prefix "Ukraine"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#United_Kingdom"></see>
    /// </summary>
    let United_Kingdom = _prefix "United_Kingdom"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanuatu"></see>
    /// </summary>
    let Vanuatu = _prefix "Vanuatu"
    /// <summary>
    /// An oceanographic campaign linked to a Regional Facility
    /// <see href="https://w3id.org/earthsemantics/OSO#OceanographicCampaign"></see></summary>
    let OceanographicCampaign = _prefix "OceanographicCampaign"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_DMSG"></see>
    /// </summary>
    let EMSO_DMSG = _prefix "EMSO_DMSG"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azores"></see>
    /// </summary>
    let Azores = _prefix "Azores"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO"></see>
    /// </summary>
    let EMSO = _prefix "EMSO"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ifremer"></see>
    /// </summary>
    let Ifremer = _prefix "Ifremer"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_EVOLVE"></see>
    /// </summary>
    let EMSO_EVOLVE = _prefix "EMSO_EVOLVE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Commission"></see>
    /// </summary>
    let European_Commission = _prefix "European_Commission"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO-France"></see>
    /// </summary>
    let ``EMSO-France`` = _prefix "EMSO-France"
    /// <summary>
    /// The Marine Institute is the national agency responsible for Marine Research, Technology Development and Innovation (RTDI).
    /// <see href="https://w3id.org/earthsemantics/OSO#Marine_institute"></see></summary>
    let Marine_institute = _prefix "Marine_institute"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OntologyEngineeringWorkflow"></see>
    /// </summary>
    let OntologyEngineeringWorkflow = _prefix "OntologyEngineeringWorkflow"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#AIMSIR"></see>
    /// </summary>
    let AIMSIR = _prefix "AIMSIR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ALBATROSS"></see>
    /// </summary>
    let ALBATROSS = _prefix "ALBATROSS"
    /// <summary>
    /// An observation platform, fixed or mobile, installed on a site or subsite, supporting one or more instruments or acquisition systems.
    /// <see href="https://w3id.org/earthsemantics/OSO#Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// Date of the first deployment of an instrument, platform, or infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#dateFirstDeployment"></see></summary>
    let dateFirstDeployment = _prefix "dateFirstDeployment"
    /// <summary>
    /// Links a platform instance to a controlled concept from the NERC L06 SeaVoX Platform Categories vocabulary.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasPlatformCategory"></see></summary>
    let hasPlatformCategory = _prefix "hasPlatformCategory"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ANTARES"></see>
    /// </summary>
    let ANTARES = _prefix "ANTARES"
    /// <summary>
    /// A subsite of observation, a finer component of a site, enabling increased spatial granularity for measurement or instrumentation.
    /// <see href="https://w3id.org/earthsemantics/OSO#Subsite"></see></summary>
    let Subsite = _prefix "Subsite"
    /// <summary>
    /// a subsite contains one or more platforms
    /// <see href="https://w3id.org/earthsemantics/OSO#Subsite_contains_a_Platform"></see></summary>
    let Subsite_contains_a_Platform = _prefix "Subsite_contains_a_Platform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IL07"></see>
    /// </summary>
    let IL07 = _prefix "IL07"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Subsite_is_part_of_a_RI"></see>
    /// </summary>
    let Subsite_is_part_of_a_RI = _prefix "Subsite_is_part_of_a_RI"
    /// <summary>
    /// Indicates whether a site or subsite is considered a test site (true/false).
    /// <see href="https://w3id.org/earthsemantics/OSO#isTestSite"></see></summary>
    let isTestSite = _prefix "isTestSite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ARDITI"></see>
    /// </summary>
    let ARDITI = _prefix "ARDITI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Alan_BERRY"></see>
    /// </summary>
    let Alan_BERRY = _prefix "Alan_BERRY"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasORCID"></see>
    /// </summary>
    let hasORCID = _prefix "hasORCID"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Antigonia"></see>
    /// </summary>
    let Antigonia = _prefix "Antigonia"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#AtlanticWhaleDealbbox"></see>
    /// </summary>
    let AtlanticWhaleDealbbox = _prefix "AtlanticWhaleDealbbox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Atlantic_Whale_Deal"></see>
    /// </summary>
    let Atlantic_Whale_Deal = _prefix "Atlantic_Whale_Deal"
    /// <summary>
    /// A research project supported by dedicated financial funding from one or more organizations or funding bodies.
    /// <see href="https://w3id.org/earthsemantics/OSO#FundedProject"></see></summary>
    let FundedProject = _prefix "FundedProject"
    /// <summary>
    /// Indicates the organization responsible for leading or coordinating a research project.
    /// <see href="https://w3id.org/earthsemantics/OSO#Project_is_led_by_an_Organization"></see></summary>
    let Project_is_led_by_an_Organization = _prefix "Project_is_led_by_an_Organization"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasLogo"></see>
    /// </summary>
    let hasLogo = _prefix "hasLogo"
    /// <summary>
    /// Relates an entity to its geographical extent, such as a bounding box or spatial coverage.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSpatialExtent"></see></summary>
    let hasSpatialExtent = _prefix "hasSpatialExtent"
    /// <summary>
    /// A regional facility containing sites, associated with research infrastructures, oceanographic campaigns, organizations, and a Regional Team Leader.
    /// <see href="https://w3id.org/earthsemantics/OSO#RegionalFacility"></see></summary>
    let RegionalFacility = _prefix "RegionalFacility"
    /// <summary>
    /// value expressed in nautical miles (NM)
    /// <see href="https://w3id.org/earthsemantics/OSO#DistanceFromLand"></see></summary>
    let DistanceFromLand = _prefix "DistanceFromLand"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityispartofRI"></see>
    /// </summary>
    let RegionalFacilityispartofRI = _prefix "RegionalFacilityispartofRI"
    /// <summary>
    /// A Regional Facility contains one or more Sites.
    /// <see href="https://w3id.org/earthsemantics/OSO#containsSite"></see></summary>
    let containsSite = _prefix "containsSite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike"></see>
    /// </summary>
    let Lucky_Strike = _prefix "Lucky_Strike"
    /// <summary>
    /// Links a regional facility to its spatial extent, aligned with EX_Extent/EX_GeographicBoundingBox in ISO 19115-3.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasBoundingBox"></see></summary>
    let hasBoundingBox = _prefix "hasBoundingBox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azoresbbox"></see>
    /// </summary>
    let Azoresbbox = _prefix "Azoresbbox"
    /// <summary>
    /// Links a regional facility to its membership within an ERIC infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasERICMembership"></see></summary>
    let hasERICMembership = _prefix "hasERICMembership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azores_EMSO_membership"></see>
    /// </summary>
    let Azores_EMSO_membership = _prefix "Azores_EMSO_membership"
    /// <summary>
    /// A Regional Facility is managed by one Regional Team Leader.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasRegionalTeamLeader"></see></summary>
    let hasRegionalTeamLeader = _prefix "hasRegionalTeamLeader"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marjolaine_MATABOS"></see>
    /// </summary>
    let Marjolaine_MATABOS = _prefix "Marjolaine_MATABOS"
    /// <summary>
    /// A Regional Facility is linked to zero or more Oceanographic Campaigns.
    /// <see href="https://w3id.org/earthsemantics/OSO#linkedToCampaigns"></see></summary>
    let linkedToCampaigns = _prefix "linkedToCampaigns"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#LUCKYDIVMIC"></see>
    /// </summary>
    let LUCKYDIVMIC = _prefix "LUCKYDIVMIC"
    /// <summary>
    /// A Regional Facility is linked to zero or more of series of Oceanographic Campaigns.
    /// <see href="https://w3id.org/earthsemantics/OSO#linkedToSeries"></see></summary>
    let linkedToSeries = _prefix "linkedToSeries"
    /// <summary>
    /// MOMAR is the acronym for MOnitoring the Mid Atlantic Ridge
    /// <see href="https://w3id.org/earthsemantics/OSO#MOMARSAT"></see></summary>
    let MOMARSAT = _prefix "MOMARSAT"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#HYDROMOMAR"></see>
    /// </summary>
    let HYDROMOMAR = _prefix "HYDROMOMAR"
    /// <summary>
    /// value expressed in meter (m)
    /// <see href="https://w3id.org/earthsemantics/OSO#maxWaterDepth"></see></summary>
    let maxWaterDepth = _prefix "maxWaterDepth"
    /// <summary>
    /// A class representing the membership relationship between an organisation or national entity and a European Research Infrastructure Consortium (ERIC).
    /// <see href="https://w3id.org/earthsemantics/OSO#ERICMembership"></see></summary>
    let ERICMembership = _prefix "ERICMembership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isERICMembershipOf"></see>
    /// </summary>
    let isERICMembershipOf = _prefix "isERICMembershipOf"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#membershipInERIC"></see>
    /// </summary>
    let membershipInERIC = _prefix "membershipInERIC"
    /// <summary>
    /// Corresponds to eastBoundLongitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasEastLongitude"></see></summary>
    let hasEastLongitude = _prefix "hasEastLongitude"
    /// <summary>
    /// Corresponds to northBoundLatitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasNorthLatitude"></see></summary>
    let hasNorthLatitude = _prefix "hasNorthLatitude"
    /// <summary>
    /// Corresponds to southBoundLatitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSouthLatitude"></see></summary>
    let hasSouthLatitude = _prefix "hasSouthLatitude"
    /// <summary>
    /// Corresponds to westBoundLongitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasWestLongitude"></see></summary>
    let hasWestLongitude = _prefix "hasWestLongitude"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#B%C3%A9n%C3%A9dicte_FERR%C3%89"></see>
    /// </summary>
    let ``B%C3%A9n%C3%A9dicte_FERR%C3%89`` = _prefix "B%C3%A9n%C3%A9dicte_FERR%C3%89"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BB"></see>
    /// </summary>
    let BB = _prefix "BB"
    /// <summary>
    /// A site contains one or more platforms.
    /// <see href="https://w3id.org/earthsemantics/OSO#containsPlatform"></see></summary>
    let containsPlatform = _prefix "containsPlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BB_Mooring"></see>
    /// </summary>
    let BB_Mooring = _prefix "BB_Mooring"
    /// <summary>
    /// A Site is managed by one Site Responsible.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSiteResponsible"></see></summary>
    let hasSiteResponsible = _prefix "hasSiteResponsible"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Stefano_MISEROCCHI"></see>
    /// </summary>
    let Stefano_MISEROCCHI = _prefix "Stefano_MISEROCCHI"
    /// <summary>
    /// A Platform may have zero or more Principal Investigators.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasPrincipalInvestigator"></see></summary>
    let hasPrincipalInvestigator = _prefix "hasPrincipalInvestigator"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanessa_CARDIN"></see>
    /// </summary>
    let Vanessa_CARDIN = _prefix "Vanessa_CARDIN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BILLION"></see>
    /// </summary>
    let BILLION = _prefix "BILLION"
    /// <summary>
    /// This mooring is not part of either the EMSO-France network or the EMSO-ERIC network
    /// <see href="https://w3id.org/earthsemantics/OSO#Billion_mooring"></see></summary>
    let Billion_mooring = _prefix "Billion_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS"></see>
    /// </summary>
    let BJS = _prefix "BJS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_BathyBot"></see>
    /// </summary>
    let BJS_BathyBot = _prefix "BJS_BathyBot"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_SeabedStation"></see>
    /// </summary>
    let BJS_SeabedStation = _prefix "BJS_SeabedStation"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_BathyDock"></see>
    /// </summary>
    let BJS_BathyDock = _prefix "BJS_BathyDock"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BRGM"></see>
    /// </summary>
    let BRGM = _prefix "BRGM"
    /// <summary>
    /// This property links an Organisation to its EDMO (European Directory of Marine Organisations) identifier.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasEDMO"></see></summary>
    let hasEDMO = _prefix "hasEDMO"
    /// <summary>
    /// This property links an Organisation to its ROR (Research Organization Registry) identifier.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasROR"></see></summary>
    let hasROR = _prefix "hasROR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Balearic_Sea"></see>
    /// </summary>
    let Balearic_Sea = _prefix "Balearic_Sea"
    /// <summary>
    /// WMO ID 6103565
    /// <see href="https://w3id.org/earthsemantics/OSO#OBSEA"></see></summary>
    let OBSEA = _prefix "OBSEA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Balearic_Sea_EMSO_membership"></see>
    /// </summary>
    let Balearic_Sea_EMSO_membership = _prefix "Balearic_Sea_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Joaquin_DEL_RIO"></see>
    /// </summary>
    let Joaquin_DEL_RIO = _prefix "Joaquin_DEL_RIO"
    /// <summary>
    /// A Regional Facility is managed by one or more Organisations.
    /// <see href="https://w3id.org/earthsemantics/OSO#ledByOrganization"></see></summary>
    let ledByOrganization = _prefix "ledByOrganization"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#UPC"></see>
    /// </summary>
    let UPC = _prefix "UPC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Bay_of_Biscay_Slope"></see>
    /// </summary>
    let Bay_of_Biscay_Slope = _prefix "Bay_of_Biscay_Slope"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacility_is_linked_to_a_project"></see>
    /// </summary>
    let RegionalFacility_is_linked_to_a_project =
        _prefix "RegionalFacility_is_linked_to_a_project"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marha"></see>
    /// </summary>
    let Marha = _prefix "Marha"
    /// <summary>
    /// A Regional Facility is related to zero or more Research Infrastructure
    /// <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisRelatedTo"></see></summary>
    let RegionalFacilityisRelatedTo = _prefix "RegionalFacilityisRelatedTo"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lampaul_Canyon"></see>
    /// </summary>
    let Lampaul_Canyon = _prefix "Lampaul_Canyon"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CHEREEF-OBS"></see>
    /// </summary>
    let ``CHEREEF-OBS`` = _prefix "CHEREEF-OBS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Benthic_station"></see>
    /// </summary>
    let Benthic_station = _prefix "Benthic_station"
    /// <summary>
    /// The Black Sea is one of the largest regional seas of the Eurasian continent and unique in many of its geographical, geological, biological, hydrographical and socio-political characteristics. With anoxic conditions in the deep, problems with invasive species and high sediment loads delivered to the system, this area has unique problems requiring long-term stations. The Black Sea is located in a geological complex area, where three major tectonic plates (Eurasian, Anatolian, Arabian) interact. Geo hazards, such as earthquarkes, submarine landslide, displacement along active faults, are present and are possible triggers of tsunami, together with extreme meteorological events.
    /// <see href="https://w3id.org/earthsemantics/OSO#Black_Sea"></see></summary>
    let Black_Sea = _prefix "Black_Sea"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EUXINUS"></see>
    /// </summary>
    let EUXINUS = _prefix "EUXINUS"
    /// <summary>
    /// Links an entity to its geometric representation.
    /// <see href="https://w3id.org/earthsemantics/OSO#EuxRo01"></see></summary>
    let EuxRo01 = _prefix "EuxRo01"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03"></see>
    /// </summary>
    let EuxRo03 = _prefix "EuxRo03"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02"></see>
    /// </summary>
    let EuxRo02 = _prefix "EuxRo02"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Black_Sea_RF_bbox"></see>
    /// </summary>
    let Black_Sea_RF_bbox = _prefix "Black_Sea_RF_bbox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Black_Sea_EMSO_membership"></see>
    /// </summary>
    let Black_Sea_EMSO_membership = _prefix "Black_Sea_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vlad_R%C4%83dulescu"></see>
    /// </summary>
    let ``Vlad_R%C4%83dulescu`` = _prefix "Vlad_R%C4%83dulescu"
    /// <summary>
    /// The Ministry of National Education (ANCS) appointed GeoEcoMar to represent Romania in EMSO.
    /// <see href="https://w3id.org/earthsemantics/OSO#GeoEcoMar"></see></summary>
    let GeoEcoMar = _prefix "GeoEcoMar"
    /// <summary>
    /// value expressed in meter (m)
    /// <see href="https://w3id.org/earthsemantics/OSO#minWaterDepth"></see></summary>
    let minWaterDepth = _prefix "minWaterDepth"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Boris_MARCAILLOU"></see>
    /// </summary>
    let Boris_MARCAILLOU = _prefix "Boris_MARCAILLOU"
    /// <summary>
    /// A series of oceanographic campaigns linked to a Regional Facility.
    /// <see href="https://w3id.org/earthsemantics/OSO#SeriesOfOceanographicCampaigns"></see></summary>
    let SeriesOfOceanographicCampaigns = _prefix "SeriesOfOceanographicCampaigns"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CLASS"></see>
    /// </summary>
    let CLASS = _prefix "CLASS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CNR"></see>
    /// </summary>
    let CNR = _prefix "CNR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isMemberof"></see>
    /// </summary>
    let isMemberof = _prefix "isMemberof"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CNRS"></see>
    /// </summary>
    let CNRS = _prefix "CNRS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CONDOR"></see>
    /// </summary>
    let CONDOR = _prefix "CONDOR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_is_part_of_a_RI"></see>
    /// </summary>
    let Site_is_part_of_a_RI = _prefix "Site_is_part_of_a_RI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO-PT"></see>
    /// </summary>
    let ``EMSO-PT`` = _prefix "EMSO-PT"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CSIC"></see>
    /// </summary>
    let CSIC = _prefix "CSIC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CTD"></see>
    /// </summary>
    let CTD = _prefix "CTD"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Calipso"></see>
    /// </summary>
    let Calipso = _prefix "Calipso"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Calipso_Seabed_Station"></see>
    /// </summary>
    let Calipso_Seabed_Station = _prefix "Calipso_Seabed_Station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Davide_EMBRIACO"></see>
    /// </summary>
    let Davide_EMBRIACO = _prefix "Davide_EMBRIACO"
    /// <summary>
    /// Canarias Regional Facility is linked to the Atlantic Whale Deal project (issue concerning collision with marine mammals)
    /// <see href="https://w3id.org/earthsemantics/OSO#Canarias"></see></summary>
    let Canarias = _prefix "Canarias"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC"></see>
    /// </summary>
    let ESTOC = _prefix "ESTOC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria"></see>
    /// </summary>
    let East_of_Gran_Canaria = _prefix "East_of_Gran_Canaria"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Canarias_EMSO_membership"></see>
    /// </summary>
    let Canarias_EMSO_membership = _prefix "Canarias_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Eric_DELORY"></see>
    /// </summary>
    let Eric_DELORY = _prefix "Eric_DELORY"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ULPGC"></see>
    /// </summary>
    let ULPGC = _prefix "ULPGC"
    /// <summary>
    /// The Ministry of Economy and Competitiveness (MINECO) is represented within EMSO by PLOCAN.
    /// <see href="https://w3id.org/earthsemantics/OSO#PLOCAN"></see></summary>
    let PLOCAN = _prefix "PLOCAN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Capelinhos"></see>
    /// </summary>
    let Capelinhos = _prefix "Capelinhos"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Capelinhos_AutonomousDevices"></see>
    /// </summary>
    let Capelinhos_AutonomousDevices = _prefix "Capelinhos_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Carlos_SOUSA"></see>
    /// </summary>
    let Carlos_SOUSA = _prefix "Carlos_SOUSA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Celtic_Seas"></see>
    /// </summary>
    let Celtic_Seas = _prefix "Celtic_Seas"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay"></see>
    /// </summary>
    let Smartbay = _prefix "Smartbay"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough"></see>
    /// </summary>
    let South_Rockall_Trough = _prefix "South_Rockall_Trough"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Celtic_Seas_EMSO_membership"></see>
    /// </summary>
    let Celtic_Seas_EMSO_membership = _prefix "Celtic_Seas_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait"></see>
    /// </summary>
    let Central_Fram_Strait = _prefix "Central_Fram_Strait"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait_mooring"></see>
    /// </summary>
    let Central_Fram_Strait_mooring = _prefix "Central_Fram_Strait_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laura_DE_STEUR"></see>
    /// </summary>
    let Laura_DE_STEUR = _prefix "Laura_DE_STEUR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cimendef"></see>
    /// </summary>
    let Cimendef = _prefix "Cimendef"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Condor_seamount"></see>
    /// </summary>
    let Condor_seamount = _prefix "Condor_seamount"
    /// <summary>
    /// A Regional Facility is associated with one or more Research Infrastructures.
    /// <see href="https://w3id.org/earthsemantics/OSO#associatedWithRI"></see></summary>
    let associatedWithRI = _prefix "associatedWithRI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IPMA"></see>
    /// </summary>
    let IPMA = _prefix "IPMA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cretan_Sea"></see>
    /// </summary>
    let Cretan_Sea = _prefix "Cretan_Sea"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E1M3A"></see>
    /// </summary>
    let E1M3A = _prefix "E1M3A"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cretan_Sea_EMSO_membership"></see>
    /// </summary>
    let Cretan_Sea_EMSO_membership = _prefix "Cretan_Sea_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#George_PETIHAKIS"></see>
    /// </summary>
    let George_PETIHAKIS = _prefix "George_PETIHAKIS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#HCMR"></see>
    /// </summary>
    let HCMR = _prefix "HCMR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Crystal"></see>
    /// </summary>
    let Crystal = _prefix "Crystal"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cypres"></see>
    /// </summary>
    let Cypres = _prefix "Cypres"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#DAS"></see>
    /// </summary>
    let DAS = _prefix "DAS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Martin_PATRIAT"></see>
    /// </summary>
    let Martin_PATRIAT = _prefix "Martin_PATRIAT"
    /// <summary>
    /// DYFAMED: Dynamics of Atmospheric Fluxes in the Mediterranean
    /// <see href="https://w3id.org/earthsemantics/OSO#DYFAMED"></see></summary>
    let DYFAMED = _prefix "DYFAMED"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_Mugobs"></see>
    /// </summary>
    let Dyfamed_Mugobs = _prefix "Dyfamed_Mugobs"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_mooring"></see>
    /// </summary>
    let Dyfamed_mooring = _prefix "Dyfamed_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_ODAS"></see>
    /// </summary>
    let Dyfamed_ODAS = _prefix "Dyfamed_ODAS"
    /// <summary>
    /// Associates an entity with a geographical location description or geometry.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laurent_COPPOLA"></see>
    /// </summary>
    let Laurent_COPPOLA = _prefix "Laurent_COPPOLA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Deployment"></see>
    /// </summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dione"></see>
    /// </summary>
    let Dione = _prefix "Dione"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dione_Seabed_Station"></see>
    /// </summary>
    let Dione_Seabed_Station = _prefix "Dione_Seabed_Station"
    /// <summary>
    /// List of EMSO scientific disciplines associated to a Regional Facility
    /// <see href="https://w3id.org/earthsemantics/OSO#Discipline"></see></summary>
    let Discipline = _prefix "Discipline"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dominique_LEFEVRE"></see>
    /// </summary>
    let Dominique_LEFEVRE = _prefix "Dominique_LEFEVRE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E1M3A_mooring"></see>
    /// </summary>
    let E1M3A_mooring = _prefix "E1M3A_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Leonidas_PERIVOLIOTIS"></see>
    /// </summary>
    let Leonidas_PERIVOLIOTIS = _prefix "Leonidas_PERIVOLIOTIS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A"></see>
    /// </summary>
    let E2M3A = _prefix "E2M3A"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A_buoy"></see>
    /// </summary>
    let E2M3A_buoy = _prefix "E2M3A_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A_mooring"></see>
    /// </summary>
    let E2M3A_mooring = _prefix "E2M3A_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EDOKKO"></see>
    /// </summary>
    let EDOKKO = _prefix "EDOKKO"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMBRC-France"></see>
    /// </summary>
    let ``EMBRC-France`` = _prefix "EMBRC-France"
    /// <summary>
    /// A research infrastructure may bring together one or more Regional Facilities
    /// <see href="https://w3id.org/earthsemantics/OSO#ResearchInfrastructure"></see></summary>
    let ResearchInfrastructure = _prefix "ResearchInfrastructure"
    /// <summary>
    /// Links a research infrastructure (ERIC or national) to the organisation that manages or coordinates it.
    /// <see href="https://w3id.org/earthsemantics/OSO#isManagedBy"></see></summary>
    let isManagedBy = _prefix "isManagedBy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SorbonneUniversit%C3%A9"></see>
    /// </summary>
    let ``SorbonneUniversit%C3%A9`` = _prefix "SorbonneUniversit%C3%A9"
    /// <summary>
    /// A European Research Infrastructure Consortium established under the ERIC legal framework to support long-term scientific collaboration and shared research services.
    /// <see href="https://w3id.org/earthsemantics/OSO#ERIC"></see></summary>
    let ERIC = _prefix "ERIC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ERIC_has_a_Director_General"></see>
    /// </summary>
    let ERIC_has_a_Director_General = _prefix "ERIC_has_a_Director_General"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ingrid_PUILLAT"></see>
    /// </summary>
    let Ingrid_PUILLAT = _prefix "Ingrid_PUILLAT"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ERICfederate"></see>
    /// </summary>
    let ERICfederate = _prefix "ERICfederate"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NorEMSO"></see>
    /// </summary>
    let NorEMSO = _prefix "NorEMSO"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisledby"></see>
    /// </summary>
    let RegionalFacilityisledby = _prefix "RegionalFacilityisledby"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nadine_LANTERI"></see>
    /// </summary>
    let Nadine_LANTERI = _prefix "Nadine_LANTERI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Zuzia_STROYNOWSKI"></see>
    /// </summary>
    let Zuzia_STROYNOWSKI = _prefix "Zuzia_STROYNOWSKI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Union"></see>
    /// </summary>
    let European_Union = _prefix "European_Union"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_Italia"></see>
    /// </summary>
    let EMSO_Italia = _prefix "EMSO_Italia"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_LIGURE_OUEST"></see>
    /// </summary>
    let EMSO_LIGURE_OUEST = _prefix "EMSO_LIGURE_OUEST"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_SA"></see>
    /// </summary>
    let EMSO_SA = _prefix "EMSO_SA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_gliders"></see>
    /// </summary>
    let ESTOC_Subsurface_gliders = _prefix "ESTOC_Subsurface_gliders"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Moored_Surface_Buoy"></see>
    /// </summary>
    let ESTOC_Moored_Surface_Buoy = _prefix "ESTOC_Moored_Surface_Buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Autonomous_Devices"></see>
    /// </summary>
    let ESTOC_Autonomous_Devices = _prefix "ESTOC_Autonomous_Devices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_mooring"></see>
    /// </summary>
    let ESTOC_Subsurface_mooring = _prefix "ESTOC_Subsurface_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EastVulcano"></see>
    /// </summary>
    let EastVulcano = _prefix "EastVulcano"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteLedBy"></see>
    /// </summary>
    let SiteLedBy = _prefix "SiteLedBy"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Autonomous_Devices"></see>
    /// </summary>
    let East_of_Gran_Canaria_Autonomous_Devices =
        _prefix "East_of_Gran_Canaria_Autonomous_Devices"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Seabed_Station"></see>
    /// </summary>
    let East_of_Gran_Canaria_Seabed_Station =
        _prefix "East_of_Gran_Canaria_Seabed_Station"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Marine_Biological_Resource_Centre"></see>
    /// </summary>
    let European_Marine_Biological_Resource_Centre =
        _prefix "European_Marine_Biological_Resource_Centre"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo01_surface_buoy"></see>
    /// </summary>
    let EuxRo01_surface_buoy = _prefix "EuxRo01_surface_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasGeometry"></see>
    /// </summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo01_geom"></see>
    /// </summary>
    let EuxRo01_geom = _prefix "EuxRo01_geom"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02_surface_buoy"></see>
    /// </summary>
    let EuxRo02_surface_buoy = _prefix "EuxRo02_surface_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02_seabed_station"></see>
    /// </summary>
    let EuxRo02_seabed_station = _prefix "EuxRo02_seabed_station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03_surface_buoy"></see>
    /// </summary>
    let EuxRo03_surface_buoy = _prefix "EuxRo03_surface_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03_seabed_station"></see>
    /// </summary>
    let EuxRo03_seabed_station = _prefix "EuxRo03_seabed_station"
    /// <summary>
    /// The Fundação para a Ciência e a Tecnologia (FCT) represents Portugal in EMSO.
    /// <see href="https://w3id.org/earthsemantics/OSO#FCT"></see></summary>
    let FCT = _prefix "FCT"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#FF"></see>
    /// </summary>
    let FF = _prefix "FF"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#FF_Mooring"></see>
    /// </summary>
    let FF_Mooring = _prefix "FF_Mooring"
    /// <summary>
    /// A structured scientific activity designed to produce new knowledge, data, or understanding within a defined scope and duration.
    /// <see href="https://w3id.org/earthsemantics/OSO#ResearchProject"></see></summary>
    let ResearchProject = _prefix "ResearchProject"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Galatea"></see>
    /// </summary>
    let Galatea = _prefix "Galatea"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Galatea_Mooring"></see>
    /// </summary>
    let Galatea_Mooring = _prefix "Galatea_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc"></see>
    /// </summary>
    let Hellenic_Arc = _prefix "Hellenic_Arc"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS"></see>
    /// </summary>
    let PYLOS = _prefix "PYLOS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc_EMSO_membership"></see>
    /// </summary>
    let Hellenic_Arc_EMSO_membership = _prefix "Hellenic_Arc_EMSO_membership"
    /// <summary>
    /// Date marking the end of deployment of an instrument, platform, or infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#dateEndDeployment"></see></summary>
    let dateEndDeployment = _prefix "dateEndDeployment"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#INFN"></see>
    /// </summary>
    let INFN = _prefix "INFN"
    /// <summary>
    /// The Ministry of Education, University and Research (MIUR) appointed INGV to represent the Italian scientific community in marine science across different Italian research institutions.
    /// <see href="https://w3id.org/earthsemantics/OSO#INGV"></see></summary>
    let INGV = _prefix "INGV"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IPGP"></see>
    /// </summary>
    let IPGP = _prefix "IPGP"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IRD"></see>
    /// </summary>
    let IRD = _prefix "IRD"
    /// <summary>
    /// IbMa-CSV: Iberian Margin Cap St. Vincent
    /// <see href="https://w3id.org/earthsemantics/OSO#IbMa-CSV"></see></summary>
    let ``IbMa-CSV`` = _prefix "IbMa-CSV"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_Seabed_Station"></see>
    /// </summary>
    let IbMaCSV_Seabed_Station = _prefix "IbMaCSV_Seabed_Station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_SubSurface_Mooring"></see>
    /// </summary>
    let IbMaCSV_TUPEM_SubSurface_Mooring = _prefix "IbMaCSV_TUPEM_SubSurface_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_SaoVicenteCanyon"></see>
    /// </summary>
    let IbMaCSV_SaoVicenteCanyon = _prefix "IbMaCSV_SaoVicenteCanyon"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler"></see>
    /// </summary>
    let IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler =
        _prefix "IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Paulo_RELVAS"></see>
    /// </summary>
    let Paulo_RELVAS = _prefix "Paulo_RELVAS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMa-N"></see>
    /// </summary>
    let ``IbMa-N`` = _prefix "IbMa-N"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasDeployment"></see>
    /// </summary>
    let hasDeployment = _prefix "hasDeployment"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_2"></see>
    /// </summary>
    let TUPEM_SubSurface_Mooring_deployment_2 =
        _prefix "TUPEM_SubSurface_Mooring_deployment_2"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_1"></see>
    /// </summary>
    let TUPEM_SubSurface_Mooring_deployment_1 =
        _prefix "TUPEM_SubSurface_Mooring_deployment_1"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaN"></see>
    /// </summary>
    let IbMaN = _prefix "IbMaN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Planned"></see>
    /// </summary>
    let Planned = _prefix "Planned"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iberian_Margin"></see>
    /// </summary>
    let Iberian_Margin = _prefix "Iberian_Margin"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iberian_Margin_EMSO_membership"></see>
    /// </summary>
    let Iberian_Margin_EMSO_membership = _prefix "Iberian_Margin_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ilker_FER"></see>
    /// </summary>
    let Ilker_FER = _prefix "Ilker_FER"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ingunn_SKJELVAN"></see>
    /// </summary>
    let Ingunn_SKJELVAN = _prefix "Ingunn_SKJELVAN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise"></see>
    /// </summary>
    let Iroise = _prefix "Iroise"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene"></see>
    /// </summary>
    let Molene = _prefix "Molene"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Poulmic"></see>
    /// </summary>
    let Poulmic = _prefix "Poulmic"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise_RF_bbox"></see>
    /// </summary>
    let Iroise_RF_bbox = _prefix "Iroise_RF_bbox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise_EMSO_membership"></see>
    /// </summary>
    let Iroise_EMSO_membership = _prefix "Iroise_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Isabel"></see>
    /// </summary>
    let Isabel = _prefix "Isabel"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#JAMSTEC"></see>
    /// </summary>
    let JAMSTEC = _prefix "JAMSTEC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KANADEEP_2"></see>
    /// </summary>
    let KANADEEP_2 = _prefix "KANADEEP_2"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KASEAOPE"></see>
    /// </summary>
    let KASEAOPE = _prefix "KASEAOPE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KASEASPACE"></see>
    /// </summary>
    let KASEASPACE = _prefix "KASEASPACE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Karin_SIGLOCH"></see>
    /// </summary>
    let Karin_SIGLOCH = _prefix "Karin_SIGLOCH"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Karine_OLU"></see>
    /// </summary>
    let Karine_OLU = _prefix "Karine_OLU"
    /// <summary>
    /// LION
    /// <see href="https://w3id.org/earthsemantics/OSO#LION"></see></summary>
    let LION = _prefix "LION"
    /// <summary>
    /// This mooring belongs exclusively to the EMSO-France network and is not part of the EMSO-ERIC network
    /// <see href="https://w3id.org/earthsemantics/OSO#Lion_mooring"></see></summary>
    let Lion_mooring = _prefix "Lion_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Patrice_BRETEL"></see>
    /// </summary>
    let Patrice_BRETEL = _prefix "Patrice_BRETEL"
    /// <summary>
    /// LO: Western Ligurian site
    /// <see href="https://w3id.org/earthsemantics/OSO#LO"></see></summary>
    let LO = _prefix "LO"
    /// <summary>
    /// A site can be associated to one or more subsites
    /// <see href="https://w3id.org/earthsemantics/OSO#Site_has_a_Subsite"></see></summary>
    let Site_has_a_Subsite = _prefix "Site_has_a_Subsite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MII"></see>
    /// </summary>
    let MII = _prefix "MII"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#S%C3%A9verine_MARTINI"></see>
    /// </summary>
    let ``S%C3%A9verine_MARTINI`` = _prefix "S%C3%A9verine_MARTINI"
    /// <summary>
    /// Associates an entity with a Digital Object Identifier (DOI) for persistent identification.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasDOI"></see></summary>
    let hasDOI = _prefix "hasDOI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARLEY"></see>
    /// </summary>
    let MARLEY = _prefix "MARLEY"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laurent_GAUTIER"></see>
    /// </summary>
    let Laurent_GAUTIER = _prefix "Laurent_GAUTIER"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#LavaLake"></see>
    /// </summary>
    let LavaLake = _prefix "LavaLake"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SeaMoNWest"></see>
    /// </summary>
    let SeaMoNWest = _prefix "SeaMoNWest"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#WestLake"></see>
    /// </summary>
    let WestLake = _prefix "WestLake"
    /// <summary>
    /// Regional Facility covering a broad north-western Mediterranean marine area, including the Ligurian Sea, the French Riviera, the Gulf of Lion, and the intermediate marine space.
    /// <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea"></see></summary>
    let Ligurian_Sea = _prefix "Ligurian_Sea"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice"></see>
    /// </summary>
    let Nice = _prefix "Nice"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_RF_bbox"></see>
    /// </summary>
    let Ligurian_Sea_RF_bbox = _prefix "Ligurian_Sea_RF_bbox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_EMSO_membership"></see>
    /// </summary>
    let Ligurian_Sea_EMSO_membership = _prefix "Ligurian_Sea_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MUG-OBS"></see>
    /// </summary>
    let ``MUG-OBS`` = _prefix "MUG-OBS"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MOOSE-GE"></see>
    /// </summary>
    let ``MOOSE-GE`` = _prefix "MOOSE-GE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Louis_GELLI"></see>
    /// </summary>
    let Louis_GELLI = _prefix "Louis_GELLI"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Y3"></see>
    /// </summary>
    let Y3 = _prefix "Y3"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MontSegur"></see>
    /// </summary>
    let MontSegur = _prefix "MontSegur"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SouthCrystal"></see>
    /// </summary>
    let SouthCrystal = _prefix "SouthCrystal"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sapin"></see>
    /// </summary>
    let Sapin = _prefix "Sapin"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sintra"></see>
    /// </summary>
    let Sintra = _prefix "Sintra"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#WhiteCastle"></see>
    /// </summary>
    let WhiteCastle = _prefix "WhiteCastle"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TourEiffel"></see>
    /// </summary>
    let TourEiffel = _prefix "TourEiffel"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_AutonomousDevices"></see>
    /// </summary>
    let Lucky_Strike_AutonomousDevices = _prefix "Lucky_Strike_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_EGIM"></see>
    /// </summary>
    let Lucky_Strike_EGIM = _prefix "Lucky_Strike_EGIM"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Hydrographicmooring"></see>
    /// </summary>
    let Lucky_Strike_Hydrographicmooring = _prefix "Lucky_Strike_Hydrographicmooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Thibault_BARREYRE"></see>
    /// </summary>
    let Thibault_BARREYRE = _prefix "Thibault_BARREYRE"
    /// <summary>
    /// An observation subplatform, a component or specific segment of a platform, dedicated to a particular type of measurement or instrumental configuration.
    /// <see href="https://w3id.org/earthsemantics/OSO#SubPlatform"></see></summary>
    let SubPlatform = _prefix "SubPlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Surface_BOREL"></see>
    /// </summary>
    let Lucky_Strike_Surface_BOREL = _prefix "Lucky_Strike_Surface_BOREL"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARMESONET"></see>
    /// </summary>
    let MARMESONET = _prefix "MARMESONET"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARMOR"></see>
    /// </summary>
    let MARMOR = _prefix "MARMOR"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mayotte"></see>
    /// </summary>
    let Mayotte = _prefix "Mayotte"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARNAUT"></see>
    /// </summary>
    let MARNAUT = _prefix "MARNAUT"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARSITECRUISE"></see>
    /// </summary>
    let MARSITECRUISE = _prefix "MARSITECRUISE"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MAYOBS"></see>
    /// </summary>
    let MAYOBS = _prefix "MAYOBS"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Office_fran%C3%A7ais_de_la_biodiversit%C3%A9"></see>
    /// </summary>
    let ``Office_fran%C3%A7ais_de_la_biodiversit%C3%A9`` =
        _prefix "Office_fran%C3%A7ais_de_la_biodiversit%C3%A9"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara"></see>
    /// </summary>
    let Marmara = _prefix "Marmara"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_AutonomousDevices"></see>
    /// </summary>
    let Marmara_AutonomousDevices = _prefix "Marmara_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Pierre_HENRY"></see>
    /// </summary>
    let Pierre_HENRY = _prefix "Pierre_HENRY"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_Sea"></see>
    /// </summary>
    let Marmara_Sea = _prefix "Marmara_Sea"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN-4"></see>
    /// </summary>
    let ``SN-4`` = _prefix "SN-4"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_Sea_RF_bbox"></see>
    /// </summary>
    let Marmara_Sea_RF_bbox = _prefix "Marmara_Sea_RF_bbox"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ScInObs"></see>
    /// </summary>
    let ScInObs = _prefix "ScInObs"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#REVOSIMA"></see>
    /// </summary>
    let REVOSIMA = _prefix "REVOSIMA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteSite"></see>
    /// </summary>
    let MayotteSite = _prefix "MayotteSite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode1"></see>
    /// </summary>
    let MayotteCCNode1 = _prefix "MayotteCCNode1"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode2"></see>
    /// </summary>
    let MayotteCCNode2 = _prefix "MayotteCCNode2"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode3"></see>
    /// </summary>
    let MayotteCCNode3 = _prefix "MayotteCCNode3"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode4"></see>
    /// </summary>
    let MayotteCCNode4 = _prefix "MayotteCCNode4"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn"></see>
    /// </summary>
    let Mohn = _prefix "Mohn"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn_Seabed_Station"></see>
    /// </summary>
    let Mohn_Seabed_Station = _prefix "Mohn_Seabed_Station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn_Subsurface_mooring"></see>
    /// </summary>
    let Mohn_Subsurface_mooring = _prefix "Mohn_Subsurface_mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Steffen_JORGENSEN"></see>
    /// </summary>
    let Steffen_JORGENSEN = _prefix "Steffen_JORGENSEN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene_SubmarinePlatform"></see>
    /// </summary>
    let Molene_SubmarinePlatform = _prefix "Molene_SubmarinePlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene_AutonomousDevices"></see>
    /// </summary>
    let Molene_AutonomousDevices = _prefix "Molene_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MontSegur_AutonomousDevices"></see>
    /// </summary>
    let MontSegur_AutonomousDevices = _prefix "MontSegur_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Munida"></see>
    /// </summary>
    let Munida = _prefix "Munida"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_B"></see>
    /// </summary>
    let mooring_line_B = _prefix "mooring_line_B"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_A"></see>
    /// </summary>
    let mooring_line_A = _prefix "mooring_line_A"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_C"></see>
    /// </summary>
    let mooring_line_C = _prefix "mooring_line_C"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NOC"></see>
    /// </summary>
    let NOC = _prefix "NOC"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NewHebridesSite"></see>
    /// </summary>
    let NewHebridesSite = _prefix "NewHebridesSite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node3"></see>
    /// </summary>
    let node3 = _prefix "node3"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node1"></see>
    /// </summary>
    let node1 = _prefix "node1"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node4"></see>
    /// </summary>
    let node4 = _prefix "node4"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node2"></see>
    /// </summary>
    let node2 = _prefix "node2"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#New_Caledonia"></see>
    /// </summary>
    let New_Caledonia = _prefix "New_Caledonia"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Stylaster"></see>
    /// </summary>
    let Stylaster = _prefix "Stylaster"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice_West_station"></see>
    /// </summary>
    let Nice_West_station = _prefix "Nice_West_station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice_East_station"></see>
    /// </summary>
    let Nice_East_station = _prefix "Nice_East_station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#S%C3%A9bastien_GARZIGLIA"></see>
    /// </summary>
    let ``S%C3%A9bastien_GARZIGLIA`` = _prefix "S%C3%A9bastien_GARZIGLIA"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#UiB"></see>
    /// </summary>
    let UiB = _prefix "UiB"
    /// <summary>
    /// The Nordic Seas regional facility comprises 5 ocean glider sections, 4 mooring sites, and one multi-array observatory. The facility combines existing monitoring components, which are expanded, with new installations, with the main aim of improving understanding of the role of the Nordic Seas in the global climate system. In particular, the multidisciplinary research conducted at the Nordic Seas regional facility focuses on:
    ///
    ///                              Water transport, circulation and water mass properties of the Nordic Seas
    ///                              Sub-surface biogeochemistry • Methane release from the seafloor
    ///                              Front variability between Polar and Atlantic waters
    ///                              Geophysical, oceanographic and ecological characterization of a hydrothermal vent
    ///
    ///                              The activity of the Nordic Seas regional facility is illustrated on the map, where ocean glider transects are shown as red lines and numbers, mooring sites as white circles (Svinøy, Station M, South Cape, Fram Strait), and the multi-array observatory as a white circle (EMSO-Mohn).
    ///
    ///                              EMSO scientific disciplines: physical oceanography, biogeochemistry, marine ecology (planned)
    /// <see href="https://w3id.org/earthsemantics/OSO#Nordic_Seas"></see></summary>
    let Nordic_Seas = _prefix "Nordic_Seas"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy"></see>
    /// </summary>
    let Svinoy = _prefix "Svinoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape"></see>
    /// </summary>
    let South_Cape = _prefix "South_Cape"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Station_M"></see>
    /// </summary>
    let Station_M = _prefix "Station_M"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nordic_Seas_EMSO_membership"></see>
    /// </summary>
    let Nordic_Seas_EMSO_membership = _prefix "Nordic_Seas_EMSO_membership"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OBSEA_seabed_station"></see>
    /// </summary>
    let OBSEA_seabed_station = _prefix "OBSEA_seabed_station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OBSEA_buoy"></see>
    /// </summary>
    let OBSEA_buoy = _prefix "OBSEA_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ODASItalia1"></see>
    /// </summary>
    let ODASItalia1 = _prefix "ODASItalia1"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Roberto_BOZZANO"></see>
    /// </summary>
    let Roberto_BOZZANO = _prefix "Roberto_BOZZANO"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OGS"></see>
    /// </summary>
    let OGS = _prefix "OGS"
    /// <summary>
    /// Root class grouping deprecated OSO classes.
    /// <see href="https://w3id.org/earthsemantics/OSO#ObsoleteClass"></see></summary>
    let ObsoleteClass = _prefix "ObsoleteClass"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ocean_Network_Canada"></see>
    /// </summary>
    let Ocean_Network_Canada = _prefix "Ocean_Network_Canada"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_Central_Site"></see>
    /// </summary>
    let PAP_Central_Site = _prefix "PAP_Central_Site"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Susan_HARTMAN"></see>
    /// </summary>
    let Susan_HARTMAN = _prefix "Susan_HARTMAN"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_H4"></see>
    /// </summary>
    let PAP_H4 = _prefix "PAP_H4"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_P4"></see>
    /// </summary>
    let PAP_P4 = _prefix "PAP_P4"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_Molene_AutonomousDevices"></see>
    /// </summary>
    let PI_Molene_AutonomousDevices = _prefix "PI_Molene_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_PoulmicPlatform"></see>
    /// </summary>
    let PI_PoulmicPlatform = _prefix "PI_PoulmicPlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_SubmarinePlatform"></see>
    /// </summary>
    let PI_SubmarinePlatform = _prefix "PI_SubmarinePlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS_Mooring"></see>
    /// </summary>
    let PYLOS_Mooring = _prefix "PYLOS_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS_Platform"></see>
    /// </summary>
    let PYLOS_Platform = _prefix "PYLOS_Platform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Pacific_Peering"></see>
    /// </summary>
    let Pacific_Peering = _prefix "Pacific_Peering"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isInvolvedIn"></see>
    /// </summary>
    let isInvolvedIn = _prefix "isInvolvedIn"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TamTam"></see>
    /// </summary>
    let TamTam = _prefix "TamTam"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Platform_contains_Subplatforms"></see>
    /// </summary>
    let Platform_contains_Subplatforms = _prefix "Platform_contains_Subplatforms"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain"></see>
    /// </summary>
    let Porcupine_Abyssal_Plain = _prefix "Porcupine_Abyssal_Plain"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain_EMSO_membership"></see>
    /// </summary>
    let Porcupine_Abyssal_Plain_EMSO_membership =
        _prefix "Porcupine_Abyssal_Plain_EMSO_membership"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Poulmic_Platform"></see>
    /// </summary>
    let Poulmic_Platform = _prefix "Poulmic_Platform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R1"></see>
    /// </summary>
    let R1 = _prefix "R1"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R1_SmartCable"></see>
    /// </summary>
    let R1_SmartCable = _prefix "R1_SmartCable"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R2"></see>
    /// </summary>
    let R2 = _prefix "R2"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R2_SmartCable"></see>
    /// </summary>
    let R2_SmartCable = _prefix "R2_SmartCable"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R3"></see>
    /// </summary>
    let R3 = _prefix "R3"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R3_SmartCable"></see>
    /// </summary>
    let R3_SmartCable = _prefix "R3_SmartCable"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalTeamLeaderIroise"></see>
    /// </summary>
    let RegionalTeamLeaderIroise = _prefix "RegionalTeamLeaderIroise"
    /// <summary>
    /// The Kingdom of Norway is represented in EMSO by the Research Council of Norway.
    /// <see href="https://w3id.org/earthsemantics/OSO#Research_Council_of_Norway"></see></summary>
    let Research_Council_of_Norway = _prefix "Research_Council_of_Norway"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN1"></see>
    /// </summary>
    let SN1 = _prefix "SN1"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN1_Seabed_Station"></see>
    /// </summary>
    let SN1_Seabed_Station = _prefix "SN1_Seabed_Station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SeaMoNEast"></see>
    /// </summary>
    let SeaMoNEast = _prefix "SeaMoNEast"
    /// <summary>
    /// Associates an infrastructure or system with one or more observation sites.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSite"></see></summary>
    let hasSite = _prefix "hasSite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteResponsibleMol%C3%A8ne"></see>
    /// </summary>
    let ``SiteResponsibleMol%C3%A8ne`` = _prefix "SiteResponsibleMol%C3%A8ne"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteResponsiblePoulmic"></see>
    /// </summary>
    let SiteResponsiblePoulmic = _prefix "SiteResponsiblePoulmic"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_has_Latitude"></see>
    /// </summary>
    let Site_has_Latitude = _prefix "Site_has_Latitude"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_has_Longitude"></see>
    /// </summary>
    let Site_has_Longitude = _prefix "Site_has_Longitude"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay_buoy"></see>
    /// </summary>
    let Smartbay_buoy = _prefix "Smartbay_buoy"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay_observatory"></see>
    /// </summary>
    let Smartbay_observatory = _prefix "Smartbay_observatory"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea"></see>
    /// </summary>
    let South_Adriatic_Sea = _prefix "South_Adriatic_Sea"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea_EMSO_membership"></see>
    /// </summary>
    let South_Adriatic_Sea_EMSO_membership =
        _prefix "South_Adriatic_Sea_EMSO_membership"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape_Seabed_Station"></see>
    /// </summary>
    let South_Cape_Seabed_Station = _prefix "South_Cape_Seabed_Station"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape_Subsurface_Mooring"></see>
    /// </summary>
    let South_Cape_Subsurface_Mooring = _prefix "South_Cape_Subsurface_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough_Mooring"></see>
    /// </summary>
    let South_Rockall_Trough_Mooring = _prefix "South_Rockall_Trough_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Station_M_Subsurface_Mooring"></see>
    /// </summary>
    let Station_M_Subsurface_Mooring = _prefix "Station_M_Subsurface_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#pilot_line"></see>
    /// </summary>
    let pilot_line = _prefix "pilot_line"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#profil_CTD"></see>
    /// </summary>
    let profil_CTD = _prefix "profil_CTD"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SubmarinePlatform"></see>
    /// </summary>
    let SubmarinePlatform = _prefix "SubmarinePlatform"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_North"></see>
    /// </summary>
    let Svinoy_North = _prefix "Svinoy_North"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_South"></see>
    /// </summary>
    let Svinoy_South = _prefix "Svinoy_South"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_North_Subsurface_Mooring"></see>
    /// </summary>
    let Svinoy_North_Subsurface_Mooring = _prefix "Svinoy_North_Subsurface_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_South_Subsurface_Mooring"></see>
    /// </summary>
    let Svinoy_South_Subsurface_Mooring = _prefix "Svinoy_South_Subsurface_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TourEiffel_AutonomousDevices"></see>
    /// </summary>
    let TourEiffel_AutonomousDevices = _prefix "TourEiffel_AutonomousDevices"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanuatu_Trench"></see>
    /// </summary>
    let Vanuatu_Trench = _prefix "Vanuatu_Trench"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#W1M3A"></see>
    /// </summary>
    let W1M3A = _prefix "W1M3A"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#W1M3A_Mooring"></see>
    /// </summary>
    let W1M3A_Mooring = _prefix "W1M3A_Mooring"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea"></see>
    /// </summary>
    let Western_Ionian_Sea = _prefix "Western_Ionian_Sea"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea_EMSO_membership"></see>
    /// </summary>
    let Western_Ionian_Sea_EMSO_membership =
        _prefix "Western_Ionian_Sea_EMSO_membership"

    /// <summary>
    /// The Regional Facility 'Western Mediterranean Sea' corresponds to the Ligurian Sea, as defined by the International Hydrographic Organization.
    /// <see href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea"></see></summary>
    let Western_Mediterranean_Sea = _prefix "Western_Mediterranean_Sea"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea_EMSO_membership"></see>
    /// </summary>
    let Western_Mediterranean_Sea_EMSO_membership =
        _prefix "Western_Mediterranean_Sea_EMSO_membership"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#geosciences"></see>
    /// </summary>
    let geosciences = _prefix "geosciences"
    /// <summary>
    /// Relates a site to a subdivision or component subsite.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSubsite"></see></summary>
    let hasSubsite = _prefix "hasSubsite"
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#physical_oceanography"></see>
    /// </summary>
    let physical_oceanography = _prefix "physical_oceanography"
