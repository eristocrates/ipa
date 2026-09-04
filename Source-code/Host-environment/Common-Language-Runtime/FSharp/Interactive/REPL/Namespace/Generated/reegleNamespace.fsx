#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module reegle =
    let _prefixId = PrefixId.fromNamespaceLabel "http://reegle.info/schema#" "reegle"
    /// <summary>
    ///   <para>rdfs:label : country profle</para>
    ///   <a href="http://reegle.info/schema#CountryProfile">reegle:CountryProfile</a>
    /// </summary>
    let CountryProfile = _prefixId.prefix "CountryProfile"
    /// <summary>
    ///   <para>rdfs:comment : output summary of a renewable energy &amp; energy efficiency project.</para>
    ///   <para>rdfs:label : project output</para>
    ///   <a href="http://reegle.info/schema#ProjectOutput">reegle:ProjectOutput</a>
    /// </summary>
    let ProjectOutput = _prefixId.prefix "ProjectOutput"
    /// <summary>
    ///   <para>rdfs:comment : A sector in the field of renewable energy and energy efficiency.</para>
    ///   <para>rdfs:label : sector</para>
    ///   <a href="http://reegle.info/schema#Sector">reegle:Sector</a>
    /// </summary>
    let Sector = _prefixId.prefix "Sector"
    /// <summary>
    ///   <para>rdfs:label : specialisation</para>
    ///   <a href="http://reegle.info/schema#Specialisation">reegle:Specialisation</a>
    /// </summary>
    let Specialisation = _prefixId.prefix "Specialisation"
    /// <summary>
    ///   <para>rdfs:label : technology</para>
    ///   <a href="http://reegle.info/schema#Technology">reegle:Technology</a>
    /// </summary>
    let Technology = _prefixId.prefix "Technology"
    /// <summary>
    ///   <para>rdfs:comment : defines the countries an organisation is active in</para>
    ///   <para>rdfs:label : is active in</para>
    ///   <a href="http://reegle.info/schema#activeIn">reegle:activeIn</a>
    /// </summary>
    let activeIn = _prefixId.prefix "activeIn"
    /// <summary>
    ///   <para>rdfs:comment : activities of the organisation in the renewable energy &amp; energy efficiency sector.</para>
    ///   <para>rdfs:label : activities</para>
    ///   <a href="http://reegle.info/schema#activities">reegle:activities</a>
    /// </summary>
    let activities = _prefixId.prefix "activities"
    /// <summary>
    ///   <para>rdfs:label : capacity concerns</para>
    ///   <a href="http://reegle.info/schema#capacityConcerns">reegle:capacityConcerns</a>
    /// </summary>
    let capacityConcerns = _prefixId.prefix "capacityConcerns"
    /// <summary>
    ///   <para>rdfs:label : competition</para>
    ///   <a href="http://reegle.info/schema#competition">reegle:competition</a>
    /// </summary>
    let competition = _prefixId.prefix "competition"
    /// <summary>
    ///   <para>rdfs:label : degree of independence</para>
    ///   <a href="http://reegle.info/schema#degreeIndependence">reegle:degreeIndependence</a>
    /// </summary>
    let degreeIndependence = _prefixId.prefix "degreeIndependence"
    /// <summary>
    ///   <para>rdfs:label : desirability</para>
    ///   <a href="http://reegle.info/schema#desirability">reegle:desirability</a>
    /// </summary>
    let desirability = _prefixId.prefix "desirability"
    /// <summary>
    ///   <para>rdfs:label : energy debates</para>
    ///   <a href="http://reegle.info/schema#energyDebates">reegle:energyDebates</a>
    /// </summary>
    let energyDebates = _prefixId.prefix "energyDebates"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency</para>
    ///   <a href="http://reegle.info/schema#energyEfficiency">reegle:energyEfficiency</a>
    /// </summary>
    let energyEfficiency = _prefixId.prefix "energyEfficiency"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency industry</para>
    ///   <a href="http://reegle.info/schema#energyEfficiencyIndustry">reegle:energyEfficiencyIndustry</a>
    /// </summary>
    let energyEfficiencyIndustry = _prefixId.prefix "energyEfficiencyIndustry"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency public</para>
    ///   <a href="http://reegle.info/schema#energyEfficiencyPublic">reegle:energyEfficiencyPublic</a>
    /// </summary>
    let energyEfficiencyPublic = _prefixId.prefix "energyEfficiencyPublic"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency residential</para>
    ///   <a href="http://reegle.info/schema#energyEfficiencyResidantial">reegle:energyEfficiencyResidantial</a>
    /// </summary>
    let energyEfficiencyResidantial = _prefixId.prefix "energyEfficiencyResidantial"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency transport</para>
    ///   <a href="http://reegle.info/schema#energyEfficiencyTransport">reegle:energyEfficiencyTransport</a>
    /// </summary>
    let energyEfficiencyTransport = _prefixId.prefix "energyEfficiencyTransport"
    /// <summary>
    ///   <para>rdfs:label : energy efficiency utilities</para>
    ///   <a href="http://reegle.info/schema#energyEfficiencyUtilities">reegle:energyEfficiencyUtilities</a>
    /// </summary>
    let energyEfficiencyUtilities = _prefixId.prefix "energyEfficiencyUtilities"
    /// <summary>
    ///   <para>rdfs:label : energy framework</para>
    ///   <a href="http://reegle.info/schema#energyFramework">reegle:energyFramework</a>
    /// </summary>
    let energyFramework = _prefixId.prefix "energyFramework"
    /// <summary>
    ///   <para>rdfs:label : energy procedure</para>
    ///   <a href="http://reegle.info/schema#energyProcedure">reegle:energyProcedure</a>
    /// </summary>
    let energyProcedure = _prefixId.prefix "energyProcedure"
    /// <summary>
    ///   <para>rdfs:label : energy regulation role</para>
    ///   <a href="http://reegle.info/schema#energyRegulationRole">reegle:energyRegulationRole</a>
    /// </summary>
    let energyRegulationRole = _prefixId.prefix "energyRegulationRole"
    /// <summary>
    ///   <para>rdfs:label : energy regulator</para>
    ///   <a href="http://reegle.info/schema#energyRegulator">reegle:energyRegulator</a>
    /// </summary>
    let energyRegulator = _prefixId.prefix "energyRegulator"
    /// <summary>
    ///   <para>rdfs:label : energy debates</para>
    ///   <a href="http://reegle.info/schema#energyStudies">reegle:energyStudies</a>
    /// </summary>
    let energyStudies = _prefixId.prefix "energyStudies"
    /// <summary>
    ///   <para>rdfs:label : extend network</para>
    ///   <a href="http://reegle.info/schema#extendNetwork">reegle:extendNetwork</a>
    /// </summary>
    let extendNetwork = _prefixId.prefix "extendNetwork"
    /// <summary>
    ///   <para>rdfs:label : funded</para>
    ///   <a href="http://reegle.info/schema#funded">reegle:funded</a>
    /// </summary>
    let funded = _prefixId.prefix "funded"
    /// <summary>
    ///   <para>rdfs:label : government agencies</para>
    ///   <a href="http://reegle.info/schema#governmentAgencies">reegle:governmentAgencies</a>
    /// </summary>
    let governmentAgencies = _prefixId.prefix "governmentAgencies"
    /// <summary>
    ///   <para>rdfs:label : role of the government</para>
    ///   <a href="http://reegle.info/schema#governmentRole">reegle:governmentRole</a>
    /// </summary>
    let governmentRole = _prefixId.prefix "governmentRole"
    /// <summary>
    ///   <para>rdfs:comment : the declared mission of the organisation.</para>
    ///   <para>rdfs:label : mission</para>
    ///   <a href="http://reegle.info/schema#mission">reegle:mission</a>
    /// </summary>
    let mission = _prefixId.prefix "mission"
    /// <summary>
    ///   <para>rdfs:label : organisation type</para>
    ///   <a href="http://reegle.info/schema#organisationType">reegle:organisationType</a>
    /// </summary>
    let organisationType = _prefixId.prefix "organisationType"
    /// <summary>
    ///   <para>rdfs:label : ownership</para>
    ///   <a href="http://reegle.info/schema#ownership">reegle:ownership</a>
    /// </summary>
    let ownership = _prefixId.prefix "ownership"
    /// <summary>
    ///   <para>rdfs:label : has country profile</para>
    ///   <a href="http://reegle.info/schema#profile">reegle:profile</a>
    /// </summary>
    let profile = _prefixId.prefix "profile"
    /// <summary>
    ///   <para>rdfs:label : project description</para>
    ///   <a href="http://reegle.info/schema#projectDescription">reegle:projectDescription</a>
    /// </summary>
    let projectDescription = _prefixId.prefix "projectDescription"
    /// <summary>
    ///   <para>rdfs:label : project expertise</para>
    ///   <a href="http://reegle.info/schema#projectExpertise">reegle:projectExpertise</a>
    /// </summary>
    let projectExpertise = _prefixId.prefix "projectExpertise"
    /// <summary>
    ///   <para>rdfs:label : project title</para>
    ///   <a href="http://reegle.info/schema#projectTitle">reegle:projectTitle</a>
    /// </summary>
    let projectTitle = _prefixId.prefix "projectTitle"
    /// <summary>
    ///   <para>rdfs:label : reference number"</para>
    ///   <a href="http://reegle.info/schema#referenceNumber">reegle:referenceNumber</a>
    /// </summary>
    let referenceNumber = _prefixId.prefix "referenceNumber"
    /// <summary>
    ///   <para>rdfs:label : references"</para>
    ///   <a href="http://reegle.info/schema#references">reegle:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    /// <summary>
    ///   <para>rdfs:label : regulatory barriers</para>
    ///   <a href="http://reegle.info/schema#regulatoryBarriers">reegle:regulatoryBarriers</a>
    /// </summary>
    let regulatoryBarriers = _prefixId.prefix "regulatoryBarriers"
    /// <summary>
    ///   <para>rdfs:label : regulatory framework</para>
    ///   <a href="http://reegle.info/schema#regulatoryFramework">reegle:regulatoryFramework</a>
    /// </summary>
    let regulatoryFramework = _prefixId.prefix "regulatoryFramework"
    /// <summary>
    ///   <para>rdfs:label : regulatory roles</para>
    ///   <a href="http://reegle.info/schema#regulatoryRoles">reegle:regulatoryRoles</a>
    /// </summary>
    let regulatoryRoles = _prefixId.prefix "regulatoryRoles"
    /// <summary>
    ///   <para>rdfs:label : reliance</para>
    ///   <a href="http://reegle.info/schema#reliance">reegle:reliance</a>
    /// </summary>
    let reliance = _prefixId.prefix "reliance"
    /// <summary>
    ///   <para>rdfs:label : renewable energy</para>
    ///   <a href="http://reegle.info/schema#renewableEnergy">reegle:renewableEnergy</a>
    /// </summary>
    let renewableEnergy = _prefixId.prefix "renewableEnergy"
    /// <summary>
    ///   <para>rdfs:label : sectorrdfs:label : in sector</para>
    ///   <para>rdfs:comment : The sector an organisation is active in.</para>
    ///   <a href="http://reegle.info/schema#sector">reegle:sector</a>
    /// </summary>
    let sector = _prefixId.prefix "sector"
    /// <summary>
    ///   <para>rdfs:label : energy sources</para>
    ///   <a href="http://reegle.info/schema#sources">reegle:sources</a>
    /// </summary>
    let sources = _prefixId.prefix "sources"
    /// <summary>
    ///   <para>rdfs:label : specialisation</para>
    ///   <a href="http://reegle.info/schema#specialisation">reegle:specialisation</a>
    /// </summary>
    let specialisation = _prefixId.prefix "specialisation"
    /// <summary>
    ///   <para>rdfs:label : target audience</para>
    ///   <a href="http://reegle.info/schema#targetAudience">reegle:targetAudience</a>
    /// </summary>
    let targetAudience = _prefixId.prefix "targetAudience"
    /// <summary>
    ///   <para>rdfs:comment : the technologies that are related to a project</para>
    ///   <para>rdfs:label : technology</para>
    ///   <a href="http://reegle.info/schema#technology">reegle:technology</a>
    /// </summary>
    let technology = _prefixId.prefix "technology"
