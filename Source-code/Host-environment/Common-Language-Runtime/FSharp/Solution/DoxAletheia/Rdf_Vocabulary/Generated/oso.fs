namespace https.w3id.org.earthsemantics.OSO.hash

open DoxAletheia.Rdf_Vocabulary

module oso =
    let _namespace_name = "https://w3id.org/earthsemantics/OSO#"

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mol%C3%A8ne"></see>
    /// </summary>
    let ``Mol%C3%A8ne`` =
        Namespaced_IRI.parse _namespace_name "Mol%C3%A8ne" |> NamespacedName

    /// <summary>
    /// A localized observatory site, attached to a regional facility, potentially hosting one or more measurement platforms.
    /// <see href="https://w3id.org/earthsemantics/OSO#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Canada"></see>
    /// </summary>
    let Canada = Namespaced_IRI.parse _namespace_name "Canada" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#France"></see>
    /// </summary>
    let France = Namespaced_IRI.parse _namespace_name "France" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#French_riviera"></see>
    /// </summary>
    let French_riviera =
        Namespaced_IRI.parse _namespace_name "French_riviera" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Greece"></see>
    /// </summary>
    let Greece = Namespaced_IRI.parse _namespace_name "Greece" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ireland"></see>
    /// </summary>
    let Ireland = Namespaced_IRI.parse _namespace_name "Ireland" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Italy"></see>
    /// </summary>
    let Italy = Namespaced_IRI.parse _namespace_name "Italy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Japan"></see>
    /// </summary>
    let Japan = Namespaced_IRI.parse _namespace_name "Japan" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Norway"></see>
    /// </summary>
    let Norway = Namespaced_IRI.parse _namespace_name "Norway" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Portugal"></see>
    /// </summary>
    let Portugal = Namespaced_IRI.parse _namespace_name "Portugal" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Romania"></see>
    /// </summary>
    let Romania = Namespaced_IRI.parse _namespace_name "Romania" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Spain"></see>
    /// </summary>
    let Spain = Namespaced_IRI.parse _namespace_name "Spain" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sweden"></see>
    /// </summary>
    let Sweden = Namespaced_IRI.parse _namespace_name "Sweden" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Turkey"></see>
    /// </summary>
    let Turkey = Namespaced_IRI.parse _namespace_name "Turkey" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ukraine"></see>
    /// </summary>
    let Ukraine = Namespaced_IRI.parse _namespace_name "Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#United_Kingdom"></see>
    /// </summary>
    let United_Kingdom =
        Namespaced_IRI.parse _namespace_name "United_Kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanuatu"></see>
    /// </summary>
    let Vanuatu = Namespaced_IRI.parse _namespace_name "Vanuatu" |> NamespacedName

    /// <summary>
    /// An oceanographic campaign linked to a Regional Facility
    /// <see href="https://w3id.org/earthsemantics/OSO#OceanographicCampaign"></see></summary>
    let OceanographicCampaign =
        Namespaced_IRI.parse _namespace_name "OceanographicCampaign" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_DMSG"></see>
    /// </summary>
    let EMSO_DMSG = Namespaced_IRI.parse _namespace_name "EMSO_DMSG" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azores"></see>
    /// </summary>
    let Azores = Namespaced_IRI.parse _namespace_name "Azores" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO"></see>
    /// </summary>
    let EMSO = Namespaced_IRI.parse _namespace_name "EMSO" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ifremer"></see>
    /// </summary>
    let Ifremer = Namespaced_IRI.parse _namespace_name "Ifremer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_EVOLVE"></see>
    /// </summary>
    let EMSO_EVOLVE =
        Namespaced_IRI.parse _namespace_name "EMSO_EVOLVE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Commission"></see>
    /// </summary>
    let European_Commission =
        Namespaced_IRI.parse _namespace_name "European_Commission" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO-France"></see>
    /// </summary>
    let ``EMSO-France`` =
        Namespaced_IRI.parse _namespace_name "EMSO-France" |> NamespacedName

    /// <summary>
    /// The Marine Institute is the national agency responsible for Marine Research, Technology Development and Innovation (RTDI).
    /// <see href="https://w3id.org/earthsemantics/OSO#Marine_institute"></see></summary>
    let Marine_institute =
        Namespaced_IRI.parse _namespace_name "Marine_institute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OntologyEngineeringWorkflow"></see>
    /// </summary>
    let OntologyEngineeringWorkflow =
        Namespaced_IRI.parse _namespace_name "OntologyEngineeringWorkflow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#AIMSIR"></see>
    /// </summary>
    let AIMSIR = Namespaced_IRI.parse _namespace_name "AIMSIR" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ALBATROSS"></see>
    /// </summary>
    let ALBATROSS = Namespaced_IRI.parse _namespace_name "ALBATROSS" |> NamespacedName
    /// <summary>
    /// An observation platform, fixed or mobile, installed on a site or subsite, supporting one or more instruments or acquisition systems.
    /// <see href="https://w3id.org/earthsemantics/OSO#Platform"></see></summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName

    /// <summary>
    /// Date of the first deployment of an instrument, platform, or infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#dateFirstDeployment"></see></summary>
    let dateFirstDeployment =
        Namespaced_IRI.parse _namespace_name "dateFirstDeployment" |> NamespacedName

    /// <summary>
    /// Links a platform instance to a controlled concept from the NERC L06 SeaVoX Platform Categories vocabulary.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasPlatformCategory"></see></summary>
    let hasPlatformCategory =
        Namespaced_IRI.parse _namespace_name "hasPlatformCategory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ANTARES"></see>
    /// </summary>
    let ANTARES = Namespaced_IRI.parse _namespace_name "ANTARES" |> NamespacedName
    /// <summary>
    /// A subsite of observation, a finer component of a site, enabling increased spatial granularity for measurement or instrumentation.
    /// <see href="https://w3id.org/earthsemantics/OSO#Subsite"></see></summary>
    let Subsite = Namespaced_IRI.parse _namespace_name "Subsite" |> NamespacedName

    /// <summary>
    /// a subsite contains one or more platforms
    /// <see href="https://w3id.org/earthsemantics/OSO#Subsite_contains_a_Platform"></see></summary>
    let Subsite_contains_a_Platform =
        Namespaced_IRI.parse _namespace_name "Subsite_contains_a_Platform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IL07"></see>
    /// </summary>
    let IL07 = Namespaced_IRI.parse _namespace_name "IL07" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Subsite_is_part_of_a_RI"></see>
    /// </summary>
    let Subsite_is_part_of_a_RI =
        Namespaced_IRI.parse _namespace_name "Subsite_is_part_of_a_RI" |> NamespacedName

    /// <summary>
    /// Indicates whether a site or subsite is considered a test site (true/false).
    /// <see href="https://w3id.org/earthsemantics/OSO#isTestSite"></see></summary>
    let isTestSite = Namespaced_IRI.parse _namespace_name "isTestSite" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ARDITI"></see>
    /// </summary>
    let ARDITI = Namespaced_IRI.parse _namespace_name "ARDITI" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Alan_BERRY"></see>
    /// </summary>
    let Alan_BERRY = Namespaced_IRI.parse _namespace_name "Alan_BERRY" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasORCID"></see>
    /// </summary>
    let hasORCID = Namespaced_IRI.parse _namespace_name "hasORCID" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Antigonia"></see>
    /// </summary>
    let Antigonia = Namespaced_IRI.parse _namespace_name "Antigonia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#AtlanticWhaleDealbbox"></see>
    /// </summary>
    let AtlanticWhaleDealbbox =
        Namespaced_IRI.parse _namespace_name "AtlanticWhaleDealbbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Atlantic_Whale_Deal"></see>
    /// </summary>
    let Atlantic_Whale_Deal =
        Namespaced_IRI.parse _namespace_name "Atlantic_Whale_Deal" |> NamespacedName

    /// <summary>
    /// A research project supported by dedicated financial funding from one or more organizations or funding bodies.
    /// <see href="https://w3id.org/earthsemantics/OSO#FundedProject"></see></summary>
    let FundedProject =
        Namespaced_IRI.parse _namespace_name "FundedProject" |> NamespacedName

    /// <summary>
    /// Indicates the organization responsible for leading or coordinating a research project.
    /// <see href="https://w3id.org/earthsemantics/OSO#Project_is_led_by_an_Organization"></see></summary>
    let Project_is_led_by_an_Organization =
        Namespaced_IRI.parse _namespace_name "Project_is_led_by_an_Organization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasLogo"></see>
    /// </summary>
    let hasLogo = Namespaced_IRI.parse _namespace_name "hasLogo" |> NamespacedName

    /// <summary>
    /// Relates an entity to its geographical extent, such as a bounding box or spatial coverage.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSpatialExtent"></see></summary>
    let hasSpatialExtent =
        Namespaced_IRI.parse _namespace_name "hasSpatialExtent" |> NamespacedName

    /// <summary>
    /// A regional facility containing sites, associated with research infrastructures, oceanographic campaigns, organizations, and a Regional Team Leader.
    /// <see href="https://w3id.org/earthsemantics/OSO#RegionalFacility"></see></summary>
    let RegionalFacility =
        Namespaced_IRI.parse _namespace_name "RegionalFacility" |> NamespacedName

    /// <summary>
    /// value expressed in nautical miles (NM)
    /// <see href="https://w3id.org/earthsemantics/OSO#DistanceFromLand"></see></summary>
    let DistanceFromLand =
        Namespaced_IRI.parse _namespace_name "DistanceFromLand" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityispartofRI"></see>
    /// </summary>
    let RegionalFacilityispartofRI =
        Namespaced_IRI.parse _namespace_name "RegionalFacilityispartofRI" |> NamespacedName

    /// <summary>
    /// A Regional Facility contains one or more Sites.
    /// <see href="https://w3id.org/earthsemantics/OSO#containsSite"></see></summary>
    let containsSite =
        Namespaced_IRI.parse _namespace_name "containsSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike"></see>
    /// </summary>
    let Lucky_Strike =
        Namespaced_IRI.parse _namespace_name "Lucky_Strike" |> NamespacedName

    /// <summary>
    /// Links a regional facility to its spatial extent, aligned with EX_Extent/EX_GeographicBoundingBox in ISO 19115-3.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasBoundingBox"></see></summary>
    let hasBoundingBox =
        Namespaced_IRI.parse _namespace_name "hasBoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azoresbbox"></see>
    /// </summary>
    let Azoresbbox = Namespaced_IRI.parse _namespace_name "Azoresbbox" |> NamespacedName

    /// <summary>
    /// Links a regional facility to its membership within an ERIC infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasERICMembership"></see></summary>
    let hasERICMembership =
        Namespaced_IRI.parse _namespace_name "hasERICMembership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Azores_EMSO_membership"></see>
    /// </summary>
    let Azores_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Azores_EMSO_membership" |> NamespacedName

    /// <summary>
    /// A Regional Facility is managed by one Regional Team Leader.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasRegionalTeamLeader"></see></summary>
    let hasRegionalTeamLeader =
        Namespaced_IRI.parse _namespace_name "hasRegionalTeamLeader" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marjolaine_MATABOS"></see>
    /// </summary>
    let Marjolaine_MATABOS =
        Namespaced_IRI.parse _namespace_name "Marjolaine_MATABOS" |> NamespacedName

    /// <summary>
    /// A Regional Facility is linked to zero or more Oceanographic Campaigns.
    /// <see href="https://w3id.org/earthsemantics/OSO#linkedToCampaigns"></see></summary>
    let linkedToCampaigns =
        Namespaced_IRI.parse _namespace_name "linkedToCampaigns" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#LUCKYDIVMIC"></see>
    /// </summary>
    let LUCKYDIVMIC =
        Namespaced_IRI.parse _namespace_name "LUCKYDIVMIC" |> NamespacedName

    /// <summary>
    /// A Regional Facility is linked to zero or more of series of Oceanographic Campaigns.
    /// <see href="https://w3id.org/earthsemantics/OSO#linkedToSeries"></see></summary>
    let linkedToSeries =
        Namespaced_IRI.parse _namespace_name "linkedToSeries" |> NamespacedName

    /// <summary>
    /// MOMAR is the acronym for MOnitoring the Mid Atlantic Ridge
    /// <see href="https://w3id.org/earthsemantics/OSO#MOMARSAT"></see></summary>
    let MOMARSAT = Namespaced_IRI.parse _namespace_name "MOMARSAT" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#HYDROMOMAR"></see>
    /// </summary>
    let HYDROMOMAR = Namespaced_IRI.parse _namespace_name "HYDROMOMAR" |> NamespacedName

    /// <summary>
    /// value expressed in meter (m)
    /// <see href="https://w3id.org/earthsemantics/OSO#maxWaterDepth"></see></summary>
    let maxWaterDepth =
        Namespaced_IRI.parse _namespace_name "maxWaterDepth" |> NamespacedName

    /// <summary>
    /// A class representing the membership relationship between an organisation or national entity and a European Research Infrastructure Consortium (ERIC).
    /// <see href="https://w3id.org/earthsemantics/OSO#ERICMembership"></see></summary>
    let ERICMembership =
        Namespaced_IRI.parse _namespace_name "ERICMembership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isERICMembershipOf"></see>
    /// </summary>
    let isERICMembershipOf =
        Namespaced_IRI.parse _namespace_name "isERICMembershipOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#membershipInERIC"></see>
    /// </summary>
    let membershipInERIC =
        Namespaced_IRI.parse _namespace_name "membershipInERIC" |> NamespacedName

    /// <summary>
    /// Corresponds to eastBoundLongitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasEastLongitude"></see></summary>
    let hasEastLongitude =
        Namespaced_IRI.parse _namespace_name "hasEastLongitude" |> NamespacedName

    /// <summary>
    /// Corresponds to northBoundLatitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasNorthLatitude"></see></summary>
    let hasNorthLatitude =
        Namespaced_IRI.parse _namespace_name "hasNorthLatitude" |> NamespacedName

    /// <summary>
    /// Corresponds to southBoundLatitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSouthLatitude"></see></summary>
    let hasSouthLatitude =
        Namespaced_IRI.parse _namespace_name "hasSouthLatitude" |> NamespacedName

    /// <summary>
    /// Corresponds to westBoundLongitude in ISO 19115-3
    /// <see href="https://w3id.org/earthsemantics/OSO#hasWestLongitude"></see></summary>
    let hasWestLongitude =
        Namespaced_IRI.parse _namespace_name "hasWestLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#B%C3%A9n%C3%A9dicte_FERR%C3%89"></see>
    /// </summary>
    let ``B%C3%A9n%C3%A9dicte_FERR%C3%89`` =
        Namespaced_IRI.parse _namespace_name "B%C3%A9n%C3%A9dicte_FERR%C3%89" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BB"></see>
    /// </summary>
    let BB = Namespaced_IRI.parse _namespace_name "BB" |> NamespacedName

    /// <summary>
    /// A site contains one or more platforms.
    /// <see href="https://w3id.org/earthsemantics/OSO#containsPlatform"></see></summary>
    let containsPlatform =
        Namespaced_IRI.parse _namespace_name "containsPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BB_Mooring"></see>
    /// </summary>
    let BB_Mooring = Namespaced_IRI.parse _namespace_name "BB_Mooring" |> NamespacedName

    /// <summary>
    /// A Site is managed by one Site Responsible.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSiteResponsible"></see></summary>
    let hasSiteResponsible =
        Namespaced_IRI.parse _namespace_name "hasSiteResponsible" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Stefano_MISEROCCHI"></see>
    /// </summary>
    let Stefano_MISEROCCHI =
        Namespaced_IRI.parse _namespace_name "Stefano_MISEROCCHI" |> NamespacedName

    /// <summary>
    /// A Platform may have zero or more Principal Investigators.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasPrincipalInvestigator"></see></summary>
    let hasPrincipalInvestigator =
        Namespaced_IRI.parse _namespace_name "hasPrincipalInvestigator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanessa_CARDIN"></see>
    /// </summary>
    let Vanessa_CARDIN =
        Namespaced_IRI.parse _namespace_name "Vanessa_CARDIN" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BILLION"></see>
    /// </summary>
    let BILLION = Namespaced_IRI.parse _namespace_name "BILLION" |> NamespacedName

    /// <summary>
    /// This mooring is not part of either the EMSO-France network or the EMSO-ERIC network
    /// <see href="https://w3id.org/earthsemantics/OSO#Billion_mooring"></see></summary>
    let Billion_mooring =
        Namespaced_IRI.parse _namespace_name "Billion_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS"></see>
    /// </summary>
    let BJS = Namespaced_IRI.parse _namespace_name "BJS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_BathyBot"></see>
    /// </summary>
    let BJS_BathyBot =
        Namespaced_IRI.parse _namespace_name "BJS_BathyBot" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_SeabedStation"></see>
    /// </summary>
    let BJS_SeabedStation =
        Namespaced_IRI.parse _namespace_name "BJS_SeabedStation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BJS_BathyDock"></see>
    /// </summary>
    let BJS_BathyDock =
        Namespaced_IRI.parse _namespace_name "BJS_BathyDock" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#BRGM"></see>
    /// </summary>
    let BRGM = Namespaced_IRI.parse _namespace_name "BRGM" |> NamespacedName
    /// <summary>
    /// This property links an Organisation to its EDMO (European Directory of Marine Organisations) identifier.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasEDMO"></see></summary>
    let hasEDMO = Namespaced_IRI.parse _namespace_name "hasEDMO" |> NamespacedName
    /// <summary>
    /// This property links an Organisation to its ROR (Research Organization Registry) identifier.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasROR"></see></summary>
    let hasROR = Namespaced_IRI.parse _namespace_name "hasROR" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Balearic_Sea"></see>
    /// </summary>
    let Balearic_Sea =
        Namespaced_IRI.parse _namespace_name "Balearic_Sea" |> NamespacedName

    /// <summary>
    /// WMO ID 6103565
    /// <see href="https://w3id.org/earthsemantics/OSO#OBSEA"></see></summary>
    let OBSEA = Namespaced_IRI.parse _namespace_name "OBSEA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Balearic_Sea_EMSO_membership"></see>
    /// </summary>
    let Balearic_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Balearic_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Joaquin_DEL_RIO"></see>
    /// </summary>
    let Joaquin_DEL_RIO =
        Namespaced_IRI.parse _namespace_name "Joaquin_DEL_RIO" |> NamespacedName

    /// <summary>
    /// A Regional Facility is managed by one or more Organisations.
    /// <see href="https://w3id.org/earthsemantics/OSO#ledByOrganization"></see></summary>
    let ledByOrganization =
        Namespaced_IRI.parse _namespace_name "ledByOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#UPC"></see>
    /// </summary>
    let UPC = Namespaced_IRI.parse _namespace_name "UPC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Bay_of_Biscay_Slope"></see>
    /// </summary>
    let Bay_of_Biscay_Slope =
        Namespaced_IRI.parse _namespace_name "Bay_of_Biscay_Slope" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacility_is_linked_to_a_project"></see>
    /// </summary>
    let RegionalFacility_is_linked_to_a_project =
        Namespaced_IRI.parse _namespace_name "RegionalFacility_is_linked_to_a_project" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marha"></see>
    /// </summary>
    let Marha = Namespaced_IRI.parse _namespace_name "Marha" |> NamespacedName

    /// <summary>
    /// A Regional Facility is related to zero or more Research Infrastructure
    /// <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisRelatedTo"></see></summary>
    let RegionalFacilityisRelatedTo =
        Namespaced_IRI.parse _namespace_name "RegionalFacilityisRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lampaul_Canyon"></see>
    /// </summary>
    let Lampaul_Canyon =
        Namespaced_IRI.parse _namespace_name "Lampaul_Canyon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CHEREEF-OBS"></see>
    /// </summary>
    let ``CHEREEF-OBS`` =
        Namespaced_IRI.parse _namespace_name "CHEREEF-OBS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Benthic_station"></see>
    /// </summary>
    let Benthic_station =
        Namespaced_IRI.parse _namespace_name "Benthic_station" |> NamespacedName

    /// <summary>
    /// The Black Sea is one of the largest regional seas of the Eurasian continent and unique in many of its geographical, geological, biological, hydrographical and socio-political characteristics. With anoxic conditions in the deep, problems with invasive species and high sediment loads delivered to the system, this area has unique problems requiring long-term stations. The Black Sea is located in a geological complex area, where three major tectonic plates (Eurasian, Anatolian, Arabian) interact. Geo hazards, such as earthquarkes, submarine landslide, displacement along active faults, are present and are possible triggers of tsunami, together with extreme meteorological events.
    /// <see href="https://w3id.org/earthsemantics/OSO#Black_Sea"></see></summary>
    let Black_Sea = Namespaced_IRI.parse _namespace_name "Black_Sea" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EUXINUS"></see>
    /// </summary>
    let EUXINUS = Namespaced_IRI.parse _namespace_name "EUXINUS" |> NamespacedName
    /// <summary>
    /// Links an entity to its geometric representation.
    /// <see href="https://w3id.org/earthsemantics/OSO#EuxRo01"></see></summary>
    let EuxRo01 = Namespaced_IRI.parse _namespace_name "EuxRo01" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03"></see>
    /// </summary>
    let EuxRo03 = Namespaced_IRI.parse _namespace_name "EuxRo03" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02"></see>
    /// </summary>
    let EuxRo02 = Namespaced_IRI.parse _namespace_name "EuxRo02" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Black_Sea_RF_bbox"></see>
    /// </summary>
    let Black_Sea_RF_bbox =
        Namespaced_IRI.parse _namespace_name "Black_Sea_RF_bbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Black_Sea_EMSO_membership"></see>
    /// </summary>
    let Black_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Black_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vlad_R%C4%83dulescu"></see>
    /// </summary>
    let ``Vlad_R%C4%83dulescu`` =
        Namespaced_IRI.parse _namespace_name "Vlad_R%C4%83dulescu" |> NamespacedName

    /// <summary>
    /// The Ministry of National Education (ANCS) appointed GeoEcoMar to represent Romania in EMSO.
    /// <see href="https://w3id.org/earthsemantics/OSO#GeoEcoMar"></see></summary>
    let GeoEcoMar = Namespaced_IRI.parse _namespace_name "GeoEcoMar" |> NamespacedName

    /// <summary>
    /// value expressed in meter (m)
    /// <see href="https://w3id.org/earthsemantics/OSO#minWaterDepth"></see></summary>
    let minWaterDepth =
        Namespaced_IRI.parse _namespace_name "minWaterDepth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Boris_MARCAILLOU"></see>
    /// </summary>
    let Boris_MARCAILLOU =
        Namespaced_IRI.parse _namespace_name "Boris_MARCAILLOU" |> NamespacedName

    /// <summary>
    /// A series of oceanographic campaigns linked to a Regional Facility.
    /// <see href="https://w3id.org/earthsemantics/OSO#SeriesOfOceanographicCampaigns"></see></summary>
    let SeriesOfOceanographicCampaigns =
        Namespaced_IRI.parse _namespace_name "SeriesOfOceanographicCampaigns" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CLASS"></see>
    /// </summary>
    let CLASS = Namespaced_IRI.parse _namespace_name "CLASS" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CNR"></see>
    /// </summary>
    let CNR = Namespaced_IRI.parse _namespace_name "CNR" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isMemberof"></see>
    /// </summary>
    let isMemberof = Namespaced_IRI.parse _namespace_name "isMemberof" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CNRS"></see>
    /// </summary>
    let CNRS = Namespaced_IRI.parse _namespace_name "CNRS" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CONDOR"></see>
    /// </summary>
    let CONDOR = Namespaced_IRI.parse _namespace_name "CONDOR" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_is_part_of_a_RI"></see>
    /// </summary>
    let Site_is_part_of_a_RI =
        Namespaced_IRI.parse _namespace_name "Site_is_part_of_a_RI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO-PT"></see>
    /// </summary>
    let ``EMSO-PT`` = Namespaced_IRI.parse _namespace_name "EMSO-PT" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CSIC"></see>
    /// </summary>
    let CSIC = Namespaced_IRI.parse _namespace_name "CSIC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#CTD"></see>
    /// </summary>
    let CTD = Namespaced_IRI.parse _namespace_name "CTD" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Calipso"></see>
    /// </summary>
    let Calipso = Namespaced_IRI.parse _namespace_name "Calipso" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Calipso_Seabed_Station"></see>
    /// </summary>
    let Calipso_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "Calipso_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Davide_EMBRIACO"></see>
    /// </summary>
    let Davide_EMBRIACO =
        Namespaced_IRI.parse _namespace_name "Davide_EMBRIACO" |> NamespacedName

    /// <summary>
    /// Canarias Regional Facility is linked to the Atlantic Whale Deal project (issue concerning collision with marine mammals)
    /// <see href="https://w3id.org/earthsemantics/OSO#Canarias"></see></summary>
    let Canarias = Namespaced_IRI.parse _namespace_name "Canarias" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC"></see>
    /// </summary>
    let ESTOC = Namespaced_IRI.parse _namespace_name "ESTOC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria"></see>
    /// </summary>
    let East_of_Gran_Canaria =
        Namespaced_IRI.parse _namespace_name "East_of_Gran_Canaria" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Canarias_EMSO_membership"></see>
    /// </summary>
    let Canarias_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Canarias_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Eric_DELORY"></see>
    /// </summary>
    let Eric_DELORY =
        Namespaced_IRI.parse _namespace_name "Eric_DELORY" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ULPGC"></see>
    /// </summary>
    let ULPGC = Namespaced_IRI.parse _namespace_name "ULPGC" |> NamespacedName
    /// <summary>
    /// The Ministry of Economy and Competitiveness (MINECO) is represented within EMSO by PLOCAN.
    /// <see href="https://w3id.org/earthsemantics/OSO#PLOCAN"></see></summary>
    let PLOCAN = Namespaced_IRI.parse _namespace_name "PLOCAN" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Capelinhos"></see>
    /// </summary>
    let Capelinhos = Namespaced_IRI.parse _namespace_name "Capelinhos" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Capelinhos_AutonomousDevices"></see>
    /// </summary>
    let Capelinhos_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "Capelinhos_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Carlos_SOUSA"></see>
    /// </summary>
    let Carlos_SOUSA =
        Namespaced_IRI.parse _namespace_name "Carlos_SOUSA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Celtic_Seas"></see>
    /// </summary>
    let Celtic_Seas =
        Namespaced_IRI.parse _namespace_name "Celtic_Seas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay"></see>
    /// </summary>
    let Smartbay = Namespaced_IRI.parse _namespace_name "Smartbay" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough"></see>
    /// </summary>
    let South_Rockall_Trough =
        Namespaced_IRI.parse _namespace_name "South_Rockall_Trough" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Celtic_Seas_EMSO_membership"></see>
    /// </summary>
    let Celtic_Seas_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Celtic_Seas_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait"></see>
    /// </summary>
    let Central_Fram_Strait =
        Namespaced_IRI.parse _namespace_name "Central_Fram_Strait" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait_mooring"></see>
    /// </summary>
    let Central_Fram_Strait_mooring =
        Namespaced_IRI.parse _namespace_name "Central_Fram_Strait_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laura_DE_STEUR"></see>
    /// </summary>
    let Laura_DE_STEUR =
        Namespaced_IRI.parse _namespace_name "Laura_DE_STEUR" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cimendef"></see>
    /// </summary>
    let Cimendef = Namespaced_IRI.parse _namespace_name "Cimendef" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Condor_seamount"></see>
    /// </summary>
    let Condor_seamount =
        Namespaced_IRI.parse _namespace_name "Condor_seamount" |> NamespacedName

    /// <summary>
    /// A Regional Facility is associated with one or more Research Infrastructures.
    /// <see href="https://w3id.org/earthsemantics/OSO#associatedWithRI"></see></summary>
    let associatedWithRI =
        Namespaced_IRI.parse _namespace_name "associatedWithRI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IPMA"></see>
    /// </summary>
    let IPMA = Namespaced_IRI.parse _namespace_name "IPMA" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cretan_Sea"></see>
    /// </summary>
    let Cretan_Sea = Namespaced_IRI.parse _namespace_name "Cretan_Sea" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E1M3A"></see>
    /// </summary>
    let E1M3A = Namespaced_IRI.parse _namespace_name "E1M3A" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cretan_Sea_EMSO_membership"></see>
    /// </summary>
    let Cretan_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Cretan_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#George_PETIHAKIS"></see>
    /// </summary>
    let George_PETIHAKIS =
        Namespaced_IRI.parse _namespace_name "George_PETIHAKIS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#HCMR"></see>
    /// </summary>
    let HCMR = Namespaced_IRI.parse _namespace_name "HCMR" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Crystal"></see>
    /// </summary>
    let Crystal = Namespaced_IRI.parse _namespace_name "Crystal" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Cypres"></see>
    /// </summary>
    let Cypres = Namespaced_IRI.parse _namespace_name "Cypres" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#DAS"></see>
    /// </summary>
    let DAS = Namespaced_IRI.parse _namespace_name "DAS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Martin_PATRIAT"></see>
    /// </summary>
    let Martin_PATRIAT =
        Namespaced_IRI.parse _namespace_name "Martin_PATRIAT" |> NamespacedName

    /// <summary>
    /// DYFAMED: Dynamics of Atmospheric Fluxes in the Mediterranean
    /// <see href="https://w3id.org/earthsemantics/OSO#DYFAMED"></see></summary>
    let DYFAMED = Namespaced_IRI.parse _namespace_name "DYFAMED" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_Mugobs"></see>
    /// </summary>
    let Dyfamed_Mugobs =
        Namespaced_IRI.parse _namespace_name "Dyfamed_Mugobs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_mooring"></see>
    /// </summary>
    let Dyfamed_mooring =
        Namespaced_IRI.parse _namespace_name "Dyfamed_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dyfamed_ODAS"></see>
    /// </summary>
    let Dyfamed_ODAS =
        Namespaced_IRI.parse _namespace_name "Dyfamed_ODAS" |> NamespacedName

    /// <summary>
    /// Associates an entity with a geographical location description or geometry.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laurent_COPPOLA"></see>
    /// </summary>
    let Laurent_COPPOLA =
        Namespaced_IRI.parse _namespace_name "Laurent_COPPOLA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Deployment"></see>
    /// </summary>
    let Deployment = Namespaced_IRI.parse _namespace_name "Deployment" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dione"></see>
    /// </summary>
    let Dione = Namespaced_IRI.parse _namespace_name "Dione" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dione_Seabed_Station"></see>
    /// </summary>
    let Dione_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "Dione_Seabed_Station" |> NamespacedName

    /// <summary>
    /// List of EMSO scientific disciplines associated to a Regional Facility
    /// <see href="https://w3id.org/earthsemantics/OSO#Discipline"></see></summary>
    let Discipline = Namespaced_IRI.parse _namespace_name "Discipline" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Dominique_LEFEVRE"></see>
    /// </summary>
    let Dominique_LEFEVRE =
        Namespaced_IRI.parse _namespace_name "Dominique_LEFEVRE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E1M3A_mooring"></see>
    /// </summary>
    let E1M3A_mooring =
        Namespaced_IRI.parse _namespace_name "E1M3A_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Leonidas_PERIVOLIOTIS"></see>
    /// </summary>
    let Leonidas_PERIVOLIOTIS =
        Namespaced_IRI.parse _namespace_name "Leonidas_PERIVOLIOTIS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A"></see>
    /// </summary>
    let E2M3A = Namespaced_IRI.parse _namespace_name "E2M3A" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A_buoy"></see>
    /// </summary>
    let E2M3A_buoy = Namespaced_IRI.parse _namespace_name "E2M3A_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#E2M3A_mooring"></see>
    /// </summary>
    let E2M3A_mooring =
        Namespaced_IRI.parse _namespace_name "E2M3A_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EDOKKO"></see>
    /// </summary>
    let EDOKKO = Namespaced_IRI.parse _namespace_name "EDOKKO" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMBRC-France"></see>
    /// </summary>
    let ``EMBRC-France`` =
        Namespaced_IRI.parse _namespace_name "EMBRC-France" |> NamespacedName

    /// <summary>
    /// A research infrastructure may bring together one or more Regional Facilities
    /// <see href="https://w3id.org/earthsemantics/OSO#ResearchInfrastructure"></see></summary>
    let ResearchInfrastructure =
        Namespaced_IRI.parse _namespace_name "ResearchInfrastructure" |> NamespacedName

    /// <summary>
    /// Links a research infrastructure (ERIC or national) to the organisation that manages or coordinates it.
    /// <see href="https://w3id.org/earthsemantics/OSO#isManagedBy"></see></summary>
    let isManagedBy =
        Namespaced_IRI.parse _namespace_name "isManagedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SorbonneUniversit%C3%A9"></see>
    /// </summary>
    let ``SorbonneUniversit%C3%A9`` =
        Namespaced_IRI.parse _namespace_name "SorbonneUniversit%C3%A9" |> NamespacedName

    /// <summary>
    /// A European Research Infrastructure Consortium established under the ERIC legal framework to support long-term scientific collaboration and shared research services.
    /// <see href="https://w3id.org/earthsemantics/OSO#ERIC"></see></summary>
    let ERIC = Namespaced_IRI.parse _namespace_name "ERIC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ERIC_has_a_Director_General"></see>
    /// </summary>
    let ERIC_has_a_Director_General =
        Namespaced_IRI.parse _namespace_name "ERIC_has_a_Director_General" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ingrid_PUILLAT"></see>
    /// </summary>
    let Ingrid_PUILLAT =
        Namespaced_IRI.parse _namespace_name "Ingrid_PUILLAT" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ERICfederate"></see>
    /// </summary>
    let ERICfederate =
        Namespaced_IRI.parse _namespace_name "ERICfederate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NorEMSO"></see>
    /// </summary>
    let NorEMSO = Namespaced_IRI.parse _namespace_name "NorEMSO" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisledby"></see>
    /// </summary>
    let RegionalFacilityisledby =
        Namespaced_IRI.parse _namespace_name "RegionalFacilityisledby" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nadine_LANTERI"></see>
    /// </summary>
    let Nadine_LANTERI =
        Namespaced_IRI.parse _namespace_name "Nadine_LANTERI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Zuzia_STROYNOWSKI"></see>
    /// </summary>
    let Zuzia_STROYNOWSKI =
        Namespaced_IRI.parse _namespace_name "Zuzia_STROYNOWSKI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Union"></see>
    /// </summary>
    let European_Union =
        Namespaced_IRI.parse _namespace_name "European_Union" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_Italia"></see>
    /// </summary>
    let EMSO_Italia =
        Namespaced_IRI.parse _namespace_name "EMSO_Italia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_LIGURE_OUEST"></see>
    /// </summary>
    let EMSO_LIGURE_OUEST =
        Namespaced_IRI.parse _namespace_name "EMSO_LIGURE_OUEST" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EMSO_SA"></see>
    /// </summary>
    let EMSO_SA = Namespaced_IRI.parse _namespace_name "EMSO_SA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_gliders"></see>
    /// </summary>
    let ESTOC_Subsurface_gliders =
        Namespaced_IRI.parse _namespace_name "ESTOC_Subsurface_gliders" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Moored_Surface_Buoy"></see>
    /// </summary>
    let ESTOC_Moored_Surface_Buoy =
        Namespaced_IRI.parse _namespace_name "ESTOC_Moored_Surface_Buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Autonomous_Devices"></see>
    /// </summary>
    let ESTOC_Autonomous_Devices =
        Namespaced_IRI.parse _namespace_name "ESTOC_Autonomous_Devices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_mooring"></see>
    /// </summary>
    let ESTOC_Subsurface_mooring =
        Namespaced_IRI.parse _namespace_name "ESTOC_Subsurface_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EastVulcano"></see>
    /// </summary>
    let EastVulcano =
        Namespaced_IRI.parse _namespace_name "EastVulcano" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteLedBy"></see>
    /// </summary>
    let SiteLedBy = Namespaced_IRI.parse _namespace_name "SiteLedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Autonomous_Devices"></see>
    /// </summary>
    let East_of_Gran_Canaria_Autonomous_Devices =
        Namespaced_IRI.parse _namespace_name "East_of_Gran_Canaria_Autonomous_Devices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Seabed_Station"></see>
    /// </summary>
    let East_of_Gran_Canaria_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "East_of_Gran_Canaria_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#European_Marine_Biological_Resource_Centre"></see>
    /// </summary>
    let European_Marine_Biological_Resource_Centre =
        Namespaced_IRI.parse _namespace_name "European_Marine_Biological_Resource_Centre" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo01_surface_buoy"></see>
    /// </summary>
    let EuxRo01_surface_buoy =
        Namespaced_IRI.parse _namespace_name "EuxRo01_surface_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasGeometry"></see>
    /// </summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo01_geom"></see>
    /// </summary>
    let EuxRo01_geom =
        Namespaced_IRI.parse _namespace_name "EuxRo01_geom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02_surface_buoy"></see>
    /// </summary>
    let EuxRo02_surface_buoy =
        Namespaced_IRI.parse _namespace_name "EuxRo02_surface_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo02_seabed_station"></see>
    /// </summary>
    let EuxRo02_seabed_station =
        Namespaced_IRI.parse _namespace_name "EuxRo02_seabed_station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03_surface_buoy"></see>
    /// </summary>
    let EuxRo03_surface_buoy =
        Namespaced_IRI.parse _namespace_name "EuxRo03_surface_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#EuxRo03_seabed_station"></see>
    /// </summary>
    let EuxRo03_seabed_station =
        Namespaced_IRI.parse _namespace_name "EuxRo03_seabed_station" |> NamespacedName

    /// <summary>
    /// The Fundação para a Ciência e a Tecnologia (FCT) represents Portugal in EMSO.
    /// <see href="https://w3id.org/earthsemantics/OSO#FCT"></see></summary>
    let FCT = Namespaced_IRI.parse _namespace_name "FCT" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#FF"></see>
    /// </summary>
    let FF = Namespaced_IRI.parse _namespace_name "FF" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#FF_Mooring"></see>
    /// </summary>
    let FF_Mooring = Namespaced_IRI.parse _namespace_name "FF_Mooring" |> NamespacedName

    /// <summary>
    /// A structured scientific activity designed to produce new knowledge, data, or understanding within a defined scope and duration.
    /// <see href="https://w3id.org/earthsemantics/OSO#ResearchProject"></see></summary>
    let ResearchProject =
        Namespaced_IRI.parse _namespace_name "ResearchProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Galatea"></see>
    /// </summary>
    let Galatea = Namespaced_IRI.parse _namespace_name "Galatea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Galatea_Mooring"></see>
    /// </summary>
    let Galatea_Mooring =
        Namespaced_IRI.parse _namespace_name "Galatea_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc"></see>
    /// </summary>
    let Hellenic_Arc =
        Namespaced_IRI.parse _namespace_name "Hellenic_Arc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS"></see>
    /// </summary>
    let PYLOS = Namespaced_IRI.parse _namespace_name "PYLOS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc_EMSO_membership"></see>
    /// </summary>
    let Hellenic_Arc_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Hellenic_Arc_EMSO_membership" |> NamespacedName

    /// <summary>
    /// Date marking the end of deployment of an instrument, platform, or infrastructure.
    /// <see href="https://w3id.org/earthsemantics/OSO#dateEndDeployment"></see></summary>
    let dateEndDeployment =
        Namespaced_IRI.parse _namespace_name "dateEndDeployment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#INFN"></see>
    /// </summary>
    let INFN = Namespaced_IRI.parse _namespace_name "INFN" |> NamespacedName
    /// <summary>
    /// The Ministry of Education, University and Research (MIUR) appointed INGV to represent the Italian scientific community in marine science across different Italian research institutions.
    /// <see href="https://w3id.org/earthsemantics/OSO#INGV"></see></summary>
    let INGV = Namespaced_IRI.parse _namespace_name "INGV" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IPGP"></see>
    /// </summary>
    let IPGP = Namespaced_IRI.parse _namespace_name "IPGP" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IRD"></see>
    /// </summary>
    let IRD = Namespaced_IRI.parse _namespace_name "IRD" |> NamespacedName
    /// <summary>
    /// IbMa-CSV: Iberian Margin Cap St. Vincent
    /// <see href="https://w3id.org/earthsemantics/OSO#IbMa-CSV"></see></summary>
    let ``IbMa-CSV`` = Namespaced_IRI.parse _namespace_name "IbMa-CSV" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_Seabed_Station"></see>
    /// </summary>
    let IbMaCSV_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "IbMaCSV_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_SubSurface_Mooring"></see>
    /// </summary>
    let IbMaCSV_TUPEM_SubSurface_Mooring =
        Namespaced_IRI.parse _namespace_name "IbMaCSV_TUPEM_SubSurface_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_SaoVicenteCanyon"></see>
    /// </summary>
    let IbMaCSV_SaoVicenteCanyon =
        Namespaced_IRI.parse _namespace_name "IbMaCSV_SaoVicenteCanyon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler"></see>
    /// </summary>
    let IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler =
        Namespaced_IRI.parse _namespace_name "IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Paulo_RELVAS"></see>
    /// </summary>
    let Paulo_RELVAS =
        Namespaced_IRI.parse _namespace_name "Paulo_RELVAS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMa-N"></see>
    /// </summary>
    let ``IbMa-N`` = Namespaced_IRI.parse _namespace_name "IbMa-N" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasDeployment"></see>
    /// </summary>
    let hasDeployment =
        Namespaced_IRI.parse _namespace_name "hasDeployment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_2"></see>
    /// </summary>
    let TUPEM_SubSurface_Mooring_deployment_2 =
        Namespaced_IRI.parse _namespace_name "TUPEM_SubSurface_Mooring_deployment_2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_1"></see>
    /// </summary>
    let TUPEM_SubSurface_Mooring_deployment_1 =
        Namespaced_IRI.parse _namespace_name "TUPEM_SubSurface_Mooring_deployment_1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#IbMaN"></see>
    /// </summary>
    let IbMaN = Namespaced_IRI.parse _namespace_name "IbMaN" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Planned"></see>
    /// </summary>
    let Planned = Namespaced_IRI.parse _namespace_name "Planned" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iberian_Margin"></see>
    /// </summary>
    let Iberian_Margin =
        Namespaced_IRI.parse _namespace_name "Iberian_Margin" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iberian_Margin_EMSO_membership"></see>
    /// </summary>
    let Iberian_Margin_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Iberian_Margin_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ilker_FER"></see>
    /// </summary>
    let Ilker_FER = Namespaced_IRI.parse _namespace_name "Ilker_FER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ingunn_SKJELVAN"></see>
    /// </summary>
    let Ingunn_SKJELVAN =
        Namespaced_IRI.parse _namespace_name "Ingunn_SKJELVAN" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise"></see>
    /// </summary>
    let Iroise = Namespaced_IRI.parse _namespace_name "Iroise" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene"></see>
    /// </summary>
    let Molene = Namespaced_IRI.parse _namespace_name "Molene" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Poulmic"></see>
    /// </summary>
    let Poulmic = Namespaced_IRI.parse _namespace_name "Poulmic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise_RF_bbox"></see>
    /// </summary>
    let Iroise_RF_bbox =
        Namespaced_IRI.parse _namespace_name "Iroise_RF_bbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Iroise_EMSO_membership"></see>
    /// </summary>
    let Iroise_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Iroise_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Isabel"></see>
    /// </summary>
    let Isabel = Namespaced_IRI.parse _namespace_name "Isabel" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#JAMSTEC"></see>
    /// </summary>
    let JAMSTEC = Namespaced_IRI.parse _namespace_name "JAMSTEC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KANADEEP_2"></see>
    /// </summary>
    let KANADEEP_2 = Namespaced_IRI.parse _namespace_name "KANADEEP_2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KASEAOPE"></see>
    /// </summary>
    let KASEAOPE = Namespaced_IRI.parse _namespace_name "KASEAOPE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#KASEASPACE"></see>
    /// </summary>
    let KASEASPACE = Namespaced_IRI.parse _namespace_name "KASEASPACE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Karin_SIGLOCH"></see>
    /// </summary>
    let Karin_SIGLOCH =
        Namespaced_IRI.parse _namespace_name "Karin_SIGLOCH" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Karine_OLU"></see>
    /// </summary>
    let Karine_OLU = Namespaced_IRI.parse _namespace_name "Karine_OLU" |> NamespacedName
    /// <summary>
    /// LION
    /// <see href="https://w3id.org/earthsemantics/OSO#LION"></see></summary>
    let LION = Namespaced_IRI.parse _namespace_name "LION" |> NamespacedName

    /// <summary>
    /// This mooring belongs exclusively to the EMSO-France network and is not part of the EMSO-ERIC network
    /// <see href="https://w3id.org/earthsemantics/OSO#Lion_mooring"></see></summary>
    let Lion_mooring =
        Namespaced_IRI.parse _namespace_name "Lion_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Patrice_BRETEL"></see>
    /// </summary>
    let Patrice_BRETEL =
        Namespaced_IRI.parse _namespace_name "Patrice_BRETEL" |> NamespacedName

    /// <summary>
    /// LO: Western Ligurian site
    /// <see href="https://w3id.org/earthsemantics/OSO#LO"></see></summary>
    let LO = Namespaced_IRI.parse _namespace_name "LO" |> NamespacedName

    /// <summary>
    /// A site can be associated to one or more subsites
    /// <see href="https://w3id.org/earthsemantics/OSO#Site_has_a_Subsite"></see></summary>
    let Site_has_a_Subsite =
        Namespaced_IRI.parse _namespace_name "Site_has_a_Subsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MII"></see>
    /// </summary>
    let MII = Namespaced_IRI.parse _namespace_name "MII" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#S%C3%A9verine_MARTINI"></see>
    /// </summary>
    let ``S%C3%A9verine_MARTINI`` =
        Namespaced_IRI.parse _namespace_name "S%C3%A9verine_MARTINI" |> NamespacedName

    /// <summary>
    /// Associates an entity with a Digital Object Identifier (DOI) for persistent identification.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasDOI"></see></summary>
    let hasDOI = Namespaced_IRI.parse _namespace_name "hasDOI" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARLEY"></see>
    /// </summary>
    let MARLEY = Namespaced_IRI.parse _namespace_name "MARLEY" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Laurent_GAUTIER"></see>
    /// </summary>
    let Laurent_GAUTIER =
        Namespaced_IRI.parse _namespace_name "Laurent_GAUTIER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#LavaLake"></see>
    /// </summary>
    let LavaLake = Namespaced_IRI.parse _namespace_name "LavaLake" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SeaMoNWest"></see>
    /// </summary>
    let SeaMoNWest = Namespaced_IRI.parse _namespace_name "SeaMoNWest" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#WestLake"></see>
    /// </summary>
    let WestLake = Namespaced_IRI.parse _namespace_name "WestLake" |> NamespacedName

    /// <summary>
    /// Regional Facility covering a broad north-western Mediterranean marine area, including the Ligurian Sea, the French Riviera, the Gulf of Lion, and the intermediate marine space.
    /// <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea"></see></summary>
    let Ligurian_Sea =
        Namespaced_IRI.parse _namespace_name "Ligurian_Sea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice"></see>
    /// </summary>
    let Nice = Namespaced_IRI.parse _namespace_name "Nice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_RF_bbox"></see>
    /// </summary>
    let Ligurian_Sea_RF_bbox =
        Namespaced_IRI.parse _namespace_name "Ligurian_Sea_RF_bbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_EMSO_membership"></see>
    /// </summary>
    let Ligurian_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Ligurian_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MUG-OBS"></see>
    /// </summary>
    let ``MUG-OBS`` = Namespaced_IRI.parse _namespace_name "MUG-OBS" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MOOSE-GE"></see>
    /// </summary>
    let ``MOOSE-GE`` = Namespaced_IRI.parse _namespace_name "MOOSE-GE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Louis_GELLI"></see>
    /// </summary>
    let Louis_GELLI =
        Namespaced_IRI.parse _namespace_name "Louis_GELLI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Y3"></see>
    /// </summary>
    let Y3 = Namespaced_IRI.parse _namespace_name "Y3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MontSegur"></see>
    /// </summary>
    let MontSegur = Namespaced_IRI.parse _namespace_name "MontSegur" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SouthCrystal"></see>
    /// </summary>
    let SouthCrystal =
        Namespaced_IRI.parse _namespace_name "SouthCrystal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sapin"></see>
    /// </summary>
    let Sapin = Namespaced_IRI.parse _namespace_name "Sapin" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Sintra"></see>
    /// </summary>
    let Sintra = Namespaced_IRI.parse _namespace_name "Sintra" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#WhiteCastle"></see>
    /// </summary>
    let WhiteCastle =
        Namespaced_IRI.parse _namespace_name "WhiteCastle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TourEiffel"></see>
    /// </summary>
    let TourEiffel = Namespaced_IRI.parse _namespace_name "TourEiffel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_AutonomousDevices"></see>
    /// </summary>
    let Lucky_Strike_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "Lucky_Strike_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_EGIM"></see>
    /// </summary>
    let Lucky_Strike_EGIM =
        Namespaced_IRI.parse _namespace_name "Lucky_Strike_EGIM" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Hydrographicmooring"></see>
    /// </summary>
    let Lucky_Strike_Hydrographicmooring =
        Namespaced_IRI.parse _namespace_name "Lucky_Strike_Hydrographicmooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Thibault_BARREYRE"></see>
    /// </summary>
    let Thibault_BARREYRE =
        Namespaced_IRI.parse _namespace_name "Thibault_BARREYRE" |> NamespacedName

    /// <summary>
    /// An observation subplatform, a component or specific segment of a platform, dedicated to a particular type of measurement or instrumental configuration.
    /// <see href="https://w3id.org/earthsemantics/OSO#SubPlatform"></see></summary>
    let SubPlatform =
        Namespaced_IRI.parse _namespace_name "SubPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Surface_BOREL"></see>
    /// </summary>
    let Lucky_Strike_Surface_BOREL =
        Namespaced_IRI.parse _namespace_name "Lucky_Strike_Surface_BOREL" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARMESONET"></see>
    /// </summary>
    let MARMESONET = Namespaced_IRI.parse _namespace_name "MARMESONET" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARMOR"></see>
    /// </summary>
    let MARMOR = Namespaced_IRI.parse _namespace_name "MARMOR" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mayotte"></see>
    /// </summary>
    let Mayotte = Namespaced_IRI.parse _namespace_name "Mayotte" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARNAUT"></see>
    /// </summary>
    let MARNAUT = Namespaced_IRI.parse _namespace_name "MARNAUT" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MARSITECRUISE"></see>
    /// </summary>
    let MARSITECRUISE =
        Namespaced_IRI.parse _namespace_name "MARSITECRUISE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MAYOBS"></see>
    /// </summary>
    let MAYOBS = Namespaced_IRI.parse _namespace_name "MAYOBS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Office_fran%C3%A7ais_de_la_biodiversit%C3%A9"></see>
    /// </summary>
    let ``Office_fran%C3%A7ais_de_la_biodiversit%C3%A9`` =
        Namespaced_IRI.parse _namespace_name "Office_fran%C3%A7ais_de_la_biodiversit%C3%A9" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara"></see>
    /// </summary>
    let Marmara = Namespaced_IRI.parse _namespace_name "Marmara" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_AutonomousDevices"></see>
    /// </summary>
    let Marmara_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "Marmara_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Pierre_HENRY"></see>
    /// </summary>
    let Pierre_HENRY =
        Namespaced_IRI.parse _namespace_name "Pierre_HENRY" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_Sea"></see>
    /// </summary>
    let Marmara_Sea =
        Namespaced_IRI.parse _namespace_name "Marmara_Sea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN-4"></see>
    /// </summary>
    let ``SN-4`` = Namespaced_IRI.parse _namespace_name "SN-4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Marmara_Sea_RF_bbox"></see>
    /// </summary>
    let Marmara_Sea_RF_bbox =
        Namespaced_IRI.parse _namespace_name "Marmara_Sea_RF_bbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ScInObs"></see>
    /// </summary>
    let ScInObs = Namespaced_IRI.parse _namespace_name "ScInObs" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#REVOSIMA"></see>
    /// </summary>
    let REVOSIMA = Namespaced_IRI.parse _namespace_name "REVOSIMA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteSite"></see>
    /// </summary>
    let MayotteSite =
        Namespaced_IRI.parse _namespace_name "MayotteSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode1"></see>
    /// </summary>
    let MayotteCCNode1 =
        Namespaced_IRI.parse _namespace_name "MayotteCCNode1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode2"></see>
    /// </summary>
    let MayotteCCNode2 =
        Namespaced_IRI.parse _namespace_name "MayotteCCNode2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode3"></see>
    /// </summary>
    let MayotteCCNode3 =
        Namespaced_IRI.parse _namespace_name "MayotteCCNode3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MayotteCCNode4"></see>
    /// </summary>
    let MayotteCCNode4 =
        Namespaced_IRI.parse _namespace_name "MayotteCCNode4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn"></see>
    /// </summary>
    let Mohn = Namespaced_IRI.parse _namespace_name "Mohn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn_Seabed_Station"></see>
    /// </summary>
    let Mohn_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "Mohn_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Mohn_Subsurface_mooring"></see>
    /// </summary>
    let Mohn_Subsurface_mooring =
        Namespaced_IRI.parse _namespace_name "Mohn_Subsurface_mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Steffen_JORGENSEN"></see>
    /// </summary>
    let Steffen_JORGENSEN =
        Namespaced_IRI.parse _namespace_name "Steffen_JORGENSEN" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene_SubmarinePlatform"></see>
    /// </summary>
    let Molene_SubmarinePlatform =
        Namespaced_IRI.parse _namespace_name "Molene_SubmarinePlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Molene_AutonomousDevices"></see>
    /// </summary>
    let Molene_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "Molene_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#MontSegur_AutonomousDevices"></see>
    /// </summary>
    let MontSegur_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "MontSegur_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Munida"></see>
    /// </summary>
    let Munida = Namespaced_IRI.parse _namespace_name "Munida" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_B"></see>
    /// </summary>
    let mooring_line_B =
        Namespaced_IRI.parse _namespace_name "mooring_line_B" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_A"></see>
    /// </summary>
    let mooring_line_A =
        Namespaced_IRI.parse _namespace_name "mooring_line_A" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#mooring_line_C"></see>
    /// </summary>
    let mooring_line_C =
        Namespaced_IRI.parse _namespace_name "mooring_line_C" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NOC"></see>
    /// </summary>
    let NOC = Namespaced_IRI.parse _namespace_name "NOC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#NewHebridesSite"></see>
    /// </summary>
    let NewHebridesSite =
        Namespaced_IRI.parse _namespace_name "NewHebridesSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node3"></see>
    /// </summary>
    let node3 = Namespaced_IRI.parse _namespace_name "node3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node1"></see>
    /// </summary>
    let node1 = Namespaced_IRI.parse _namespace_name "node1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node4"></see>
    /// </summary>
    let node4 = Namespaced_IRI.parse _namespace_name "node4" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#node2"></see>
    /// </summary>
    let node2 = Namespaced_IRI.parse _namespace_name "node2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#New_Caledonia"></see>
    /// </summary>
    let New_Caledonia =
        Namespaced_IRI.parse _namespace_name "New_Caledonia" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Stylaster"></see>
    /// </summary>
    let Stylaster = Namespaced_IRI.parse _namespace_name "Stylaster" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice_West_station"></see>
    /// </summary>
    let Nice_West_station =
        Namespaced_IRI.parse _namespace_name "Nice_West_station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nice_East_station"></see>
    /// </summary>
    let Nice_East_station =
        Namespaced_IRI.parse _namespace_name "Nice_East_station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#S%C3%A9bastien_GARZIGLIA"></see>
    /// </summary>
    let ``S%C3%A9bastien_GARZIGLIA`` =
        Namespaced_IRI.parse _namespace_name "S%C3%A9bastien_GARZIGLIA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#UiB"></see>
    /// </summary>
    let UiB = Namespaced_IRI.parse _namespace_name "UiB" |> NamespacedName

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
    let Nordic_Seas =
        Namespaced_IRI.parse _namespace_name "Nordic_Seas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy"></see>
    /// </summary>
    let Svinoy = Namespaced_IRI.parse _namespace_name "Svinoy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape"></see>
    /// </summary>
    let South_Cape = Namespaced_IRI.parse _namespace_name "South_Cape" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Station_M"></see>
    /// </summary>
    let Station_M = Namespaced_IRI.parse _namespace_name "Station_M" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Nordic_Seas_EMSO_membership"></see>
    /// </summary>
    let Nordic_Seas_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Nordic_Seas_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OBSEA_seabed_station"></see>
    /// </summary>
    let OBSEA_seabed_station =
        Namespaced_IRI.parse _namespace_name "OBSEA_seabed_station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OBSEA_buoy"></see>
    /// </summary>
    let OBSEA_buoy = Namespaced_IRI.parse _namespace_name "OBSEA_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#ODASItalia1"></see>
    /// </summary>
    let ODASItalia1 =
        Namespaced_IRI.parse _namespace_name "ODASItalia1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Roberto_BOZZANO"></see>
    /// </summary>
    let Roberto_BOZZANO =
        Namespaced_IRI.parse _namespace_name "Roberto_BOZZANO" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#OGS"></see>
    /// </summary>
    let OGS = Namespaced_IRI.parse _namespace_name "OGS" |> NamespacedName

    /// <summary>
    /// Root class grouping deprecated OSO classes.
    /// <see href="https://w3id.org/earthsemantics/OSO#ObsoleteClass"></see></summary>
    let ObsoleteClass =
        Namespaced_IRI.parse _namespace_name "ObsoleteClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Ocean_Network_Canada"></see>
    /// </summary>
    let Ocean_Network_Canada =
        Namespaced_IRI.parse _namespace_name "Ocean_Network_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_Central_Site"></see>
    /// </summary>
    let PAP_Central_Site =
        Namespaced_IRI.parse _namespace_name "PAP_Central_Site" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Susan_HARTMAN"></see>
    /// </summary>
    let Susan_HARTMAN =
        Namespaced_IRI.parse _namespace_name "Susan_HARTMAN" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_H4"></see>
    /// </summary>
    let PAP_H4 = Namespaced_IRI.parse _namespace_name "PAP_H4" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PAP_P4"></see>
    /// </summary>
    let PAP_P4 = Namespaced_IRI.parse _namespace_name "PAP_P4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_Molene_AutonomousDevices"></see>
    /// </summary>
    let PI_Molene_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "PI_Molene_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_PoulmicPlatform"></see>
    /// </summary>
    let PI_PoulmicPlatform =
        Namespaced_IRI.parse _namespace_name "PI_PoulmicPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PI_SubmarinePlatform"></see>
    /// </summary>
    let PI_SubmarinePlatform =
        Namespaced_IRI.parse _namespace_name "PI_SubmarinePlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS_Mooring"></see>
    /// </summary>
    let PYLOS_Mooring =
        Namespaced_IRI.parse _namespace_name "PYLOS_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#PYLOS_Platform"></see>
    /// </summary>
    let PYLOS_Platform =
        Namespaced_IRI.parse _namespace_name "PYLOS_Platform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Pacific_Peering"></see>
    /// </summary>
    let Pacific_Peering =
        Namespaced_IRI.parse _namespace_name "Pacific_Peering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#isInvolvedIn"></see>
    /// </summary>
    let isInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isInvolvedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TamTam"></see>
    /// </summary>
    let TamTam = Namespaced_IRI.parse _namespace_name "TamTam" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Platform_contains_Subplatforms"></see>
    /// </summary>
    let Platform_contains_Subplatforms =
        Namespaced_IRI.parse _namespace_name "Platform_contains_Subplatforms" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain"></see>
    /// </summary>
    let Porcupine_Abyssal_Plain =
        Namespaced_IRI.parse _namespace_name "Porcupine_Abyssal_Plain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain_EMSO_membership"></see>
    /// </summary>
    let Porcupine_Abyssal_Plain_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Porcupine_Abyssal_Plain_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Poulmic_Platform"></see>
    /// </summary>
    let Poulmic_Platform =
        Namespaced_IRI.parse _namespace_name "Poulmic_Platform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R1"></see>
    /// </summary>
    let R1 = Namespaced_IRI.parse _namespace_name "R1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R1_SmartCable"></see>
    /// </summary>
    let R1_SmartCable =
        Namespaced_IRI.parse _namespace_name "R1_SmartCable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R2"></see>
    /// </summary>
    let R2 = Namespaced_IRI.parse _namespace_name "R2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R2_SmartCable"></see>
    /// </summary>
    let R2_SmartCable =
        Namespaced_IRI.parse _namespace_name "R2_SmartCable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R3"></see>
    /// </summary>
    let R3 = Namespaced_IRI.parse _namespace_name "R3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#R3_SmartCable"></see>
    /// </summary>
    let R3_SmartCable =
        Namespaced_IRI.parse _namespace_name "R3_SmartCable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#RegionalTeamLeaderIroise"></see>
    /// </summary>
    let RegionalTeamLeaderIroise =
        Namespaced_IRI.parse _namespace_name "RegionalTeamLeaderIroise" |> NamespacedName

    /// <summary>
    /// The Kingdom of Norway is represented in EMSO by the Research Council of Norway.
    /// <see href="https://w3id.org/earthsemantics/OSO#Research_Council_of_Norway"></see></summary>
    let Research_Council_of_Norway =
        Namespaced_IRI.parse _namespace_name "Research_Council_of_Norway" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN1"></see>
    /// </summary>
    let SN1 = Namespaced_IRI.parse _namespace_name "SN1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SN1_Seabed_Station"></see>
    /// </summary>
    let SN1_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "SN1_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SeaMoNEast"></see>
    /// </summary>
    let SeaMoNEast = Namespaced_IRI.parse _namespace_name "SeaMoNEast" |> NamespacedName
    /// <summary>
    /// Associates an infrastructure or system with one or more observation sites.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSite"></see></summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteResponsibleMol%C3%A8ne"></see>
    /// </summary>
    let ``SiteResponsibleMol%C3%A8ne`` =
        Namespaced_IRI.parse _namespace_name "SiteResponsibleMol%C3%A8ne" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SiteResponsiblePoulmic"></see>
    /// </summary>
    let SiteResponsiblePoulmic =
        Namespaced_IRI.parse _namespace_name "SiteResponsiblePoulmic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_has_Latitude"></see>
    /// </summary>
    let Site_has_Latitude =
        Namespaced_IRI.parse _namespace_name "Site_has_Latitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Site_has_Longitude"></see>
    /// </summary>
    let Site_has_Longitude =
        Namespaced_IRI.parse _namespace_name "Site_has_Longitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay_buoy"></see>
    /// </summary>
    let Smartbay_buoy =
        Namespaced_IRI.parse _namespace_name "Smartbay_buoy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Smartbay_observatory"></see>
    /// </summary>
    let Smartbay_observatory =
        Namespaced_IRI.parse _namespace_name "Smartbay_observatory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea"></see>
    /// </summary>
    let South_Adriatic_Sea =
        Namespaced_IRI.parse _namespace_name "South_Adriatic_Sea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea_EMSO_membership"></see>
    /// </summary>
    let South_Adriatic_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "South_Adriatic_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape_Seabed_Station"></see>
    /// </summary>
    let South_Cape_Seabed_Station =
        Namespaced_IRI.parse _namespace_name "South_Cape_Seabed_Station" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Cape_Subsurface_Mooring"></see>
    /// </summary>
    let South_Cape_Subsurface_Mooring =
        Namespaced_IRI.parse _namespace_name "South_Cape_Subsurface_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough_Mooring"></see>
    /// </summary>
    let South_Rockall_Trough_Mooring =
        Namespaced_IRI.parse _namespace_name "South_Rockall_Trough_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Station_M_Subsurface_Mooring"></see>
    /// </summary>
    let Station_M_Subsurface_Mooring =
        Namespaced_IRI.parse _namespace_name "Station_M_Subsurface_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#pilot_line"></see>
    /// </summary>
    let pilot_line = Namespaced_IRI.parse _namespace_name "pilot_line" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#profil_CTD"></see>
    /// </summary>
    let profil_CTD = Namespaced_IRI.parse _namespace_name "profil_CTD" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#SubmarinePlatform"></see>
    /// </summary>
    let SubmarinePlatform =
        Namespaced_IRI.parse _namespace_name "SubmarinePlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_North"></see>
    /// </summary>
    let Svinoy_North =
        Namespaced_IRI.parse _namespace_name "Svinoy_North" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_South"></see>
    /// </summary>
    let Svinoy_South =
        Namespaced_IRI.parse _namespace_name "Svinoy_South" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_North_Subsurface_Mooring"></see>
    /// </summary>
    let Svinoy_North_Subsurface_Mooring =
        Namespaced_IRI.parse _namespace_name "Svinoy_North_Subsurface_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Svinoy_South_Subsurface_Mooring"></see>
    /// </summary>
    let Svinoy_South_Subsurface_Mooring =
        Namespaced_IRI.parse _namespace_name "Svinoy_South_Subsurface_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#TourEiffel_AutonomousDevices"></see>
    /// </summary>
    let TourEiffel_AutonomousDevices =
        Namespaced_IRI.parse _namespace_name "TourEiffel_AutonomousDevices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Vanuatu_Trench"></see>
    /// </summary>
    let Vanuatu_Trench =
        Namespaced_IRI.parse _namespace_name "Vanuatu_Trench" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#W1M3A"></see>
    /// </summary>
    let W1M3A = Namespaced_IRI.parse _namespace_name "W1M3A" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#W1M3A_Mooring"></see>
    /// </summary>
    let W1M3A_Mooring =
        Namespaced_IRI.parse _namespace_name "W1M3A_Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea"></see>
    /// </summary>
    let Western_Ionian_Sea =
        Namespaced_IRI.parse _namespace_name "Western_Ionian_Sea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea_EMSO_membership"></see>
    /// </summary>
    let Western_Ionian_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Western_Ionian_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    /// The Regional Facility 'Western Mediterranean Sea' corresponds to the Ligurian Sea, as defined by the International Hydrographic Organization.
    /// <see href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea"></see></summary>
    let Western_Mediterranean_Sea =
        Namespaced_IRI.parse _namespace_name "Western_Mediterranean_Sea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea_EMSO_membership"></see>
    /// </summary>
    let Western_Mediterranean_Sea_EMSO_membership =
        Namespaced_IRI.parse _namespace_name "Western_Mediterranean_Sea_EMSO_membership" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#geosciences"></see>
    /// </summary>
    let geosciences =
        Namespaced_IRI.parse _namespace_name "geosciences" |> NamespacedName

    /// <summary>
    /// Relates a site to a subdivision or component subsite.
    /// <see href="https://w3id.org/earthsemantics/OSO#hasSubsite"></see></summary>
    let hasSubsite = Namespaced_IRI.parse _namespace_name "hasSubsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/earthsemantics/OSO#physical_oceanography"></see>
    /// </summary>
    let physical_oceanography =
        Namespaced_IRI.parse _namespace_name "physical_oceanography" |> NamespacedName
