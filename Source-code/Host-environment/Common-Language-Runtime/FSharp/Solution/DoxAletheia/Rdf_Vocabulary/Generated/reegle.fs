namespace http.reegle.info.schema.hash

open DoxAletheia

module reegle =
    let _namespace_name = "http://reegle.info/schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#CountryProfile"></see>
    /// </summary>
    let CountryProfile = _prefix "CountryProfile"
    /// <summary>
    /// output summary of a renewable energy &amp; energy efficiency project.
    /// <see href="http://reegle.info/schema#ProjectOutput"></see></summary>
    let ProjectOutput = _prefix "ProjectOutput"
    /// <summary>
    /// A sector in the field of renewable energy and energy efficiency.
    /// <see href="http://reegle.info/schema#Sector"></see></summary>
    let Sector = _prefix "Sector"
    /// <summary>
    ///   <see href="http://reegle.info/schema#Specialisation"></see>
    /// </summary>
    let Specialisation = _prefix "Specialisation"
    /// <summary>
    ///   <see href="http://reegle.info/schema#Technology"></see>
    /// </summary>
    let Technology = _prefix "Technology"
    /// <summary>
    /// defines the countries an organisation is active in
    /// <see href="http://reegle.info/schema#activeIn"></see></summary>
    let activeIn = _prefix "activeIn"
    /// <summary>
    /// activities of the organisation in the renewable energy &amp; energy efficiency sector.
    /// <see href="http://reegle.info/schema#activities"></see></summary>
    let activities = _prefix "activities"
    /// <summary>
    ///   <see href="http://reegle.info/schema#capacityConcerns"></see>
    /// </summary>
    let capacityConcerns = _prefix "capacityConcerns"
    /// <summary>
    ///   <see href="http://reegle.info/schema#competition"></see>
    /// </summary>
    let competition = _prefix "competition"
    /// <summary>
    ///   <see href="http://reegle.info/schema#degreeIndependence"></see>
    /// </summary>
    let degreeIndependence = _prefix "degreeIndependence"
    /// <summary>
    ///   <see href="http://reegle.info/schema#desirability"></see>
    /// </summary>
    let desirability = _prefix "desirability"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyDebates"></see>
    /// </summary>
    let energyDebates = _prefix "energyDebates"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiency"></see>
    /// </summary>
    let energyEfficiency = _prefix "energyEfficiency"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyIndustry"></see>
    /// </summary>
    let energyEfficiencyIndustry = _prefix "energyEfficiencyIndustry"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyPublic"></see>
    /// </summary>
    let energyEfficiencyPublic = _prefix "energyEfficiencyPublic"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyResidantial"></see>
    /// </summary>
    let energyEfficiencyResidantial = _prefix "energyEfficiencyResidantial"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyTransport"></see>
    /// </summary>
    let energyEfficiencyTransport = _prefix "energyEfficiencyTransport"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyUtilities"></see>
    /// </summary>
    let energyEfficiencyUtilities = _prefix "energyEfficiencyUtilities"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyFramework"></see>
    /// </summary>
    let energyFramework = _prefix "energyFramework"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyProcedure"></see>
    /// </summary>
    let energyProcedure = _prefix "energyProcedure"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyRegulationRole"></see>
    /// </summary>
    let energyRegulationRole = _prefix "energyRegulationRole"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyRegulator"></see>
    /// </summary>
    let energyRegulator = _prefix "energyRegulator"
    /// <summary>
    ///   <see href="http://reegle.info/schema#energyStudies"></see>
    /// </summary>
    let energyStudies = _prefix "energyStudies"
    /// <summary>
    ///   <see href="http://reegle.info/schema#extendNetwork"></see>
    /// </summary>
    let extendNetwork = _prefix "extendNetwork"
    /// <summary>
    ///   <see href="http://reegle.info/schema#funded"></see>
    /// </summary>
    let funded = _prefix "funded"
    /// <summary>
    ///   <see href="http://reegle.info/schema#governmentAgencies"></see>
    /// </summary>
    let governmentAgencies = _prefix "governmentAgencies"
    /// <summary>
    ///   <see href="http://reegle.info/schema#governmentRole"></see>
    /// </summary>
    let governmentRole = _prefix "governmentRole"
    /// <summary>
    /// the declared mission of the organisation.
    /// <see href="http://reegle.info/schema#mission"></see></summary>
    let mission = _prefix "mission"
    /// <summary>
    ///   <see href="http://reegle.info/schema#organisationType"></see>
    /// </summary>
    let organisationType = _prefix "organisationType"
    /// <summary>
    ///   <see href="http://reegle.info/schema#ownership"></see>
    /// </summary>
    let ownership = _prefix "ownership"
    /// <summary>
    ///   <see href="http://reegle.info/schema#profile"></see>
    /// </summary>
    let profile = _prefix "profile"
    /// <summary>
    ///   <see href="http://reegle.info/schema#projectDescription"></see>
    /// </summary>
    let projectDescription = _prefix "projectDescription"
    /// <summary>
    ///   <see href="http://reegle.info/schema#projectExpertise"></see>
    /// </summary>
    let projectExpertise = _prefix "projectExpertise"
    /// <summary>
    ///   <see href="http://reegle.info/schema#projectTitle"></see>
    /// </summary>
    let projectTitle = _prefix "projectTitle"
    /// <summary>
    ///   <see href="http://reegle.info/schema#referenceNumber"></see>
    /// </summary>
    let referenceNumber = _prefix "referenceNumber"
    /// <summary>
    ///   <see href="http://reegle.info/schema#references"></see>
    /// </summary>
    let references = _prefix "references"
    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryBarriers"></see>
    /// </summary>
    let regulatoryBarriers = _prefix "regulatoryBarriers"
    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryFramework"></see>
    /// </summary>
    let regulatoryFramework = _prefix "regulatoryFramework"
    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryRoles"></see>
    /// </summary>
    let regulatoryRoles = _prefix "regulatoryRoles"
    /// <summary>
    ///   <see href="http://reegle.info/schema#reliance"></see>
    /// </summary>
    let reliance = _prefix "reliance"
    /// <summary>
    ///   <see href="http://reegle.info/schema#renewableEnergy"></see>
    /// </summary>
    let renewableEnergy = _prefix "renewableEnergy"
    /// <summary>
    /// The sector an organisation is active in.
    /// <see href="http://reegle.info/schema#sector"></see></summary>
    let sector = _prefix "sector"
    /// <summary>
    ///   <see href="http://reegle.info/schema#sources"></see>
    /// </summary>
    let sources = _prefix "sources"
    /// <summary>
    ///   <see href="http://reegle.info/schema#specialisation"></see>
    /// </summary>
    let specialisation = _prefix "specialisation"
    /// <summary>
    ///   <see href="http://reegle.info/schema#targetAudience"></see>
    /// </summary>
    let targetAudience = _prefix "targetAudience"
    /// <summary>
    /// the technologies that are related to a project
    /// <see href="http://reegle.info/schema#technology"></see></summary>
    let technology = _prefix "technology"
