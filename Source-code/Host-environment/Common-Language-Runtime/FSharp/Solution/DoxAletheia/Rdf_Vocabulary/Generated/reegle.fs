namespace http.reegle.info.schema.hash

open DoxAletheia.Rdf_Vocabulary

module reegle =
    let _namespace_name = "http://reegle.info/schema#"

    /// <summary>
    ///   <see href="http://reegle.info/schema#CountryProfile"></see>
    /// </summary>
    let CountryProfile =
        Namespaced_IRI.parse _namespace_name "CountryProfile" |> NamespacedName

    /// <summary>
    /// output summary of a renewable energy &amp; energy efficiency project.
    /// <see href="http://reegle.info/schema#ProjectOutput"></see></summary>
    let ProjectOutput =
        Namespaced_IRI.parse _namespace_name "ProjectOutput" |> NamespacedName

    /// <summary>
    /// A sector in the field of renewable energy and energy efficiency.
    /// <see href="http://reegle.info/schema#Sector"></see></summary>
    let Sector = Namespaced_IRI.parse _namespace_name "Sector" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#Specialisation"></see>
    /// </summary>
    let Specialisation =
        Namespaced_IRI.parse _namespace_name "Specialisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#Technology"></see>
    /// </summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName
    /// <summary>
    /// defines the countries an organisation is active in
    /// <see href="http://reegle.info/schema#activeIn"></see></summary>
    let activeIn = Namespaced_IRI.parse _namespace_name "activeIn" |> NamespacedName
    /// <summary>
    /// activities of the organisation in the renewable energy &amp; energy efficiency sector.
    /// <see href="http://reegle.info/schema#activities"></see></summary>
    let activities = Namespaced_IRI.parse _namespace_name "activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#capacityConcerns"></see>
    /// </summary>
    let capacityConcerns =
        Namespaced_IRI.parse _namespace_name "capacityConcerns" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#competition"></see>
    /// </summary>
    let competition =
        Namespaced_IRI.parse _namespace_name "competition" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#degreeIndependence"></see>
    /// </summary>
    let degreeIndependence =
        Namespaced_IRI.parse _namespace_name "degreeIndependence" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#desirability"></see>
    /// </summary>
    let desirability =
        Namespaced_IRI.parse _namespace_name "desirability" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyDebates"></see>
    /// </summary>
    let energyDebates =
        Namespaced_IRI.parse _namespace_name "energyDebates" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiency"></see>
    /// </summary>
    let energyEfficiency =
        Namespaced_IRI.parse _namespace_name "energyEfficiency" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyIndustry"></see>
    /// </summary>
    let energyEfficiencyIndustry =
        Namespaced_IRI.parse _namespace_name "energyEfficiencyIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyPublic"></see>
    /// </summary>
    let energyEfficiencyPublic =
        Namespaced_IRI.parse _namespace_name "energyEfficiencyPublic" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyResidantial"></see>
    /// </summary>
    let energyEfficiencyResidantial =
        Namespaced_IRI.parse _namespace_name "energyEfficiencyResidantial" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyTransport"></see>
    /// </summary>
    let energyEfficiencyTransport =
        Namespaced_IRI.parse _namespace_name "energyEfficiencyTransport" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyEfficiencyUtilities"></see>
    /// </summary>
    let energyEfficiencyUtilities =
        Namespaced_IRI.parse _namespace_name "energyEfficiencyUtilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyFramework"></see>
    /// </summary>
    let energyFramework =
        Namespaced_IRI.parse _namespace_name "energyFramework" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyProcedure"></see>
    /// </summary>
    let energyProcedure =
        Namespaced_IRI.parse _namespace_name "energyProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyRegulationRole"></see>
    /// </summary>
    let energyRegulationRole =
        Namespaced_IRI.parse _namespace_name "energyRegulationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyRegulator"></see>
    /// </summary>
    let energyRegulator =
        Namespaced_IRI.parse _namespace_name "energyRegulator" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#energyStudies"></see>
    /// </summary>
    let energyStudies =
        Namespaced_IRI.parse _namespace_name "energyStudies" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#extendNetwork"></see>
    /// </summary>
    let extendNetwork =
        Namespaced_IRI.parse _namespace_name "extendNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#funded"></see>
    /// </summary>
    let funded = Namespaced_IRI.parse _namespace_name "funded" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#governmentAgencies"></see>
    /// </summary>
    let governmentAgencies =
        Namespaced_IRI.parse _namespace_name "governmentAgencies" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#governmentRole"></see>
    /// </summary>
    let governmentRole =
        Namespaced_IRI.parse _namespace_name "governmentRole" |> NamespacedName

    /// <summary>
    /// the declared mission of the organisation.
    /// <see href="http://reegle.info/schema#mission"></see></summary>
    let mission = Namespaced_IRI.parse _namespace_name "mission" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#organisationType"></see>
    /// </summary>
    let organisationType =
        Namespaced_IRI.parse _namespace_name "organisationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#ownership"></see>
    /// </summary>
    let ownership = Namespaced_IRI.parse _namespace_name "ownership" |> NamespacedName
    /// <summary>
    ///   <see href="http://reegle.info/schema#profile"></see>
    /// </summary>
    let profile = Namespaced_IRI.parse _namespace_name "profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#projectDescription"></see>
    /// </summary>
    let projectDescription =
        Namespaced_IRI.parse _namespace_name "projectDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#projectExpertise"></see>
    /// </summary>
    let projectExpertise =
        Namespaced_IRI.parse _namespace_name "projectExpertise" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#projectTitle"></see>
    /// </summary>
    let projectTitle =
        Namespaced_IRI.parse _namespace_name "projectTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#referenceNumber"></see>
    /// </summary>
    let referenceNumber =
        Namespaced_IRI.parse _namespace_name "referenceNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#references"></see>
    /// </summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryBarriers"></see>
    /// </summary>
    let regulatoryBarriers =
        Namespaced_IRI.parse _namespace_name "regulatoryBarriers" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryFramework"></see>
    /// </summary>
    let regulatoryFramework =
        Namespaced_IRI.parse _namespace_name "regulatoryFramework" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#regulatoryRoles"></see>
    /// </summary>
    let regulatoryRoles =
        Namespaced_IRI.parse _namespace_name "regulatoryRoles" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#reliance"></see>
    /// </summary>
    let reliance = Namespaced_IRI.parse _namespace_name "reliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#renewableEnergy"></see>
    /// </summary>
    let renewableEnergy =
        Namespaced_IRI.parse _namespace_name "renewableEnergy" |> NamespacedName

    /// <summary>
    /// The sector an organisation is active in.
    /// <see href="http://reegle.info/schema#sector"></see></summary>
    let sector = Namespaced_IRI.parse _namespace_name "sector" |> NamespacedName
    /// <summary>
    ///   <see href="http://reegle.info/schema#sources"></see>
    /// </summary>
    let sources = Namespaced_IRI.parse _namespace_name "sources" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#specialisation"></see>
    /// </summary>
    let specialisation =
        Namespaced_IRI.parse _namespace_name "specialisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://reegle.info/schema#targetAudience"></see>
    /// </summary>
    let targetAudience =
        Namespaced_IRI.parse _namespace_name "targetAudience" |> NamespacedName

    /// <summary>
    /// the technologies that are related to a project
    /// <see href="http://reegle.info/schema#technology"></see></summary>
    let technology = Namespaced_IRI.parse _namespace_name "technology" |> NamespacedName
