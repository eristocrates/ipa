namespace http.reegle.info.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module reegle =
    let _namespace_iri = Namespace_Iri reegle |> NamespaceIRI
    /// <summary>
    ///   <para>reegle:CountryProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"country profle"</para></remarks>
    /// <seealso href="http://reegle.info/schema#CountryProfile">http://reegle.info/schema#CountryProfile</seealso>
    let CountryProfile = Prefixed_Name(reegle, "CountryProfile") |> PrefixedName
    /// <summary>
    ///   <para>reegle:ProjectOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"output summary of a renewable energy &amp; energy efficiency project."</para>
    /// labels<para>"project output"</para></remarks>
    /// <seealso href="http://reegle.info/schema#ProjectOutput">http://reegle.info/schema#ProjectOutput</seealso>
    let ProjectOutput = Prefixed_Name(reegle, "ProjectOutput") |> PrefixedName
    /// <summary>
    ///   <para>reegle:Sector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sector in the field of renewable energy and energy efficiency."</para>
    /// labels<para>"sector"</para></remarks>
    /// <seealso href="http://reegle.info/schema#Sector">http://reegle.info/schema#Sector</seealso>
    let Sector = Prefixed_Name(reegle, "Sector") |> PrefixedName
    /// <summary>
    ///   <para>reegle:Specialisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specialisation"</para></remarks>
    /// <seealso href="http://reegle.info/schema#Specialisation">http://reegle.info/schema#Specialisation</seealso>
    let Specialisation = Prefixed_Name(reegle, "Specialisation") |> PrefixedName
    /// <summary>
    ///   <para>reegle:Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"technology"</para></remarks>
    /// <seealso href="http://reegle.info/schema#Technology">http://reegle.info/schema#Technology</seealso>
    let Technology = Prefixed_Name(reegle, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>reegle:activeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"defines the countries an organisation is active in"</para>
    /// labels<para>"is active in"</para></remarks>
    /// <seealso href="http://reegle.info/schema#activeIn">http://reegle.info/schema#activeIn</seealso>
    let activeIn = Prefixed_Name(reegle, "activeIn") |> PrefixedName
    /// <summary>
    ///   <para>reegle:activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"activities of the organisation in the renewable energy &amp; energy efficiency sector."</para>
    /// labels<para>"activities"</para></remarks>
    /// <seealso href="http://reegle.info/schema#activities">http://reegle.info/schema#activities</seealso>
    let activities = Prefixed_Name(reegle, "activities") |> PrefixedName
    /// <summary>
    ///   <para>reegle:capacityConcerns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"capacity concerns"</para></remarks>
    /// <seealso href="http://reegle.info/schema#capacityConcerns">http://reegle.info/schema#capacityConcerns</seealso>
    let capacityConcerns = Prefixed_Name(reegle, "capacityConcerns") |> PrefixedName
    /// <summary>
    ///   <para>reegle:competition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"competition"</para></remarks>
    /// <seealso href="http://reegle.info/schema#competition">http://reegle.info/schema#competition</seealso>
    let competition = Prefixed_Name(reegle, "competition") |> PrefixedName
    /// <summary>
    ///   <para>reegle:degreeIndependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"degree of independence"</para></remarks>
    /// <seealso href="http://reegle.info/schema#degreeIndependence">http://reegle.info/schema#degreeIndependence</seealso>
    let degreeIndependence = Prefixed_Name(reegle, "degreeIndependence") |> PrefixedName
    /// <summary>
    ///   <para>reegle:desirability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"desirability"</para></remarks>
    /// <seealso href="http://reegle.info/schema#desirability">http://reegle.info/schema#desirability</seealso>
    let desirability = Prefixed_Name(reegle, "desirability") |> PrefixedName
    /// <summary>
    ///   <para>reegle:energyDebates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy debates"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyDebates">http://reegle.info/schema#energyDebates</seealso>
    let energyDebates = Prefixed_Name(reegle, "energyDebates") |> PrefixedName
    /// <summary>
    ///   <para>reegle:energyEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiency">http://reegle.info/schema#energyEfficiency</seealso>
    let energyEfficiency = Prefixed_Name(reegle, "energyEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyEfficiencyIndustry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency industry"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiencyIndustry">http://reegle.info/schema#energyEfficiencyIndustry</seealso>
    let energyEfficiencyIndustry =
        Prefixed_Name(reegle, "energyEfficiencyIndustry") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyEfficiencyPublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency public"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiencyPublic">http://reegle.info/schema#energyEfficiencyPublic</seealso>
    let energyEfficiencyPublic =
        Prefixed_Name(reegle, "energyEfficiencyPublic") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyEfficiencyResidantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency residential"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiencyResidantial">http://reegle.info/schema#energyEfficiencyResidantial</seealso>
    let energyEfficiencyResidantial =
        Prefixed_Name(reegle, "energyEfficiencyResidantial") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyEfficiencyTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency transport"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiencyTransport">http://reegle.info/schema#energyEfficiencyTransport</seealso>
    let energyEfficiencyTransport =
        Prefixed_Name(reegle, "energyEfficiencyTransport") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyEfficiencyUtilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy efficiency utilities"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyEfficiencyUtilities">http://reegle.info/schema#energyEfficiencyUtilities</seealso>
    let energyEfficiencyUtilities =
        Prefixed_Name(reegle, "energyEfficiencyUtilities") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy framework"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyFramework">http://reegle.info/schema#energyFramework</seealso>
    let energyFramework = Prefixed_Name(reegle, "energyFramework") |> PrefixedName
    /// <summary>
    ///   <para>reegle:energyProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy procedure"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyProcedure">http://reegle.info/schema#energyProcedure</seealso>
    let energyProcedure = Prefixed_Name(reegle, "energyProcedure") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyRegulationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy regulation role"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyRegulationRole">http://reegle.info/schema#energyRegulationRole</seealso>
    let energyRegulationRole =
        Prefixed_Name(reegle, "energyRegulationRole") |> PrefixedName

    /// <summary>
    ///   <para>reegle:energyRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy regulator"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyRegulator">http://reegle.info/schema#energyRegulator</seealso>
    let energyRegulator = Prefixed_Name(reegle, "energyRegulator") |> PrefixedName
    /// <summary>
    ///   <para>reegle:energyStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy debates"</para></remarks>
    /// <seealso href="http://reegle.info/schema#energyStudies">http://reegle.info/schema#energyStudies</seealso>
    let energyStudies = Prefixed_Name(reegle, "energyStudies") |> PrefixedName
    /// <summary>
    ///   <para>reegle:extendNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"extend network"</para></remarks>
    /// <seealso href="http://reegle.info/schema#extendNetwork">http://reegle.info/schema#extendNetwork</seealso>
    let extendNetwork = Prefixed_Name(reegle, "extendNetwork") |> PrefixedName
    /// <summary>
    ///   <para>reegle:funded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"funded"</para></remarks>
    /// <seealso href="http://reegle.info/schema#funded">http://reegle.info/schema#funded</seealso>
    let funded = Prefixed_Name(reegle, "funded") |> PrefixedName
    /// <summary>
    ///   <para>reegle:governmentAgencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"government agencies"</para></remarks>
    /// <seealso href="http://reegle.info/schema#governmentAgencies">http://reegle.info/schema#governmentAgencies</seealso>
    let governmentAgencies = Prefixed_Name(reegle, "governmentAgencies") |> PrefixedName
    /// <summary>
    ///   <para>reegle:governmentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"role of the government"</para></remarks>
    /// <seealso href="http://reegle.info/schema#governmentRole">http://reegle.info/schema#governmentRole</seealso>
    let governmentRole = Prefixed_Name(reegle, "governmentRole") |> PrefixedName
    /// <summary>
    ///   <para>reegle:mission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the declared mission of the organisation."</para>
    /// labels<para>"mission"</para></remarks>
    /// <seealso href="http://reegle.info/schema#mission">http://reegle.info/schema#mission</seealso>
    let mission = Prefixed_Name(reegle, "mission") |> PrefixedName
    /// <summary>
    ///   <para>reegle:organisationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"organisation type"</para></remarks>
    /// <seealso href="http://reegle.info/schema#organisationType">http://reegle.info/schema#organisationType</seealso>
    let organisationType = Prefixed_Name(reegle, "organisationType") |> PrefixedName
    /// <summary>
    ///   <para>reegle:ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ownership"</para></remarks>
    /// <seealso href="http://reegle.info/schema#ownership">http://reegle.info/schema#ownership</seealso>
    let ownership = Prefixed_Name(reegle, "ownership") |> PrefixedName
    /// <summary>
    ///   <para>reegle:profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has country profile"</para></remarks>
    /// <seealso href="http://reegle.info/schema#profile">http://reegle.info/schema#profile</seealso>
    let profile = Prefixed_Name(reegle, "profile") |> PrefixedName
    /// <summary>
    ///   <para>reegle:projectDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project description"</para></remarks>
    /// <seealso href="http://reegle.info/schema#projectDescription">http://reegle.info/schema#projectDescription</seealso>
    let projectDescription = Prefixed_Name(reegle, "projectDescription") |> PrefixedName
    /// <summary>
    ///   <para>reegle:projectExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project expertise"</para></remarks>
    /// <seealso href="http://reegle.info/schema#projectExpertise">http://reegle.info/schema#projectExpertise</seealso>
    let projectExpertise = Prefixed_Name(reegle, "projectExpertise") |> PrefixedName
    /// <summary>
    ///   <para>reegle:projectTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project title"</para></remarks>
    /// <seealso href="http://reegle.info/schema#projectTitle">http://reegle.info/schema#projectTitle</seealso>
    let projectTitle = Prefixed_Name(reegle, "projectTitle") |> PrefixedName
    /// <summary>
    ///   <para>reegle:referenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"reference number""</para></remarks>
    /// <seealso href="http://reegle.info/schema#referenceNumber">http://reegle.info/schema#referenceNumber</seealso>
    let referenceNumber = Prefixed_Name(reegle, "referenceNumber") |> PrefixedName
    /// <summary>
    ///   <para>reegle:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"references""</para></remarks>
    /// <seealso href="http://reegle.info/schema#references">http://reegle.info/schema#references</seealso>
    let references = Prefixed_Name(reegle, "references") |> PrefixedName
    /// <summary>
    ///   <para>reegle:regulatoryBarriers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"regulatory barriers"</para></remarks>
    /// <seealso href="http://reegle.info/schema#regulatoryBarriers">http://reegle.info/schema#regulatoryBarriers</seealso>
    let regulatoryBarriers = Prefixed_Name(reegle, "regulatoryBarriers") |> PrefixedName

    /// <summary>
    ///   <para>reegle:regulatoryFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"regulatory framework"</para></remarks>
    /// <seealso href="http://reegle.info/schema#regulatoryFramework">http://reegle.info/schema#regulatoryFramework</seealso>
    let regulatoryFramework =
        Prefixed_Name(reegle, "regulatoryFramework") |> PrefixedName

    /// <summary>
    ///   <para>reegle:regulatoryRoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"regulatory roles"</para></remarks>
    /// <seealso href="http://reegle.info/schema#regulatoryRoles">http://reegle.info/schema#regulatoryRoles</seealso>
    let regulatoryRoles = Prefixed_Name(reegle, "regulatoryRoles") |> PrefixedName
    /// <summary>
    ///   <para>reegle:reliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"reliance"</para></remarks>
    /// <seealso href="http://reegle.info/schema#reliance">http://reegle.info/schema#reliance</seealso>
    let reliance = Prefixed_Name(reegle, "reliance") |> PrefixedName
    /// <summary>
    ///   <para>reegle:renewableEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"renewable energy"</para></remarks>
    /// <seealso href="http://reegle.info/schema#renewableEnergy">http://reegle.info/schema#renewableEnergy</seealso>
    let renewableEnergy = Prefixed_Name(reegle, "renewableEnergy") |> PrefixedName
    /// <summary>
    ///   <para>reegle:sector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The sector an organisation is active in."</para>
    /// labels<para>"sector"</para><para>"in sector"</para></remarks>
    /// <seealso href="http://reegle.info/schema#sector">http://reegle.info/schema#sector</seealso>
    let sector = Prefixed_Name(reegle, "sector") |> PrefixedName
    /// <summary>
    ///   <para>reegle:sources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"energy sources"</para></remarks>
    /// <seealso href="http://reegle.info/schema#sources">http://reegle.info/schema#sources</seealso>
    let sources = Prefixed_Name(reegle, "sources") |> PrefixedName
    /// <summary>
    ///   <para>reegle:specialisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specialisation"</para></remarks>
    /// <seealso href="http://reegle.info/schema#specialisation">http://reegle.info/schema#specialisation</seealso>
    let specialisation = Prefixed_Name(reegle, "specialisation") |> PrefixedName
    /// <summary>
    ///   <para>reegle:targetAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"target audience"</para></remarks>
    /// <seealso href="http://reegle.info/schema#targetAudience">http://reegle.info/schema#targetAudience</seealso>
    let targetAudience = Prefixed_Name(reegle, "targetAudience") |> PrefixedName
    /// <summary>
    ///   <para>reegle:technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the technologies that are related to a project"</para>
    /// labels<para>"technology"</para></remarks>
    /// <seealso href="http://reegle.info/schema#technology">http://reegle.info/schema#technology</seealso>
    let technology = Prefixed_Name(reegle, "technology") |> PrefixedName
