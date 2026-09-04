#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fea =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.data.gov/def/fea#" "fea"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An agency of the US government^^xsd:string</para>
    ///   <para>rdfs:label : Agency^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Agency">fea:Agency</a>
    /// </summary>
    let Agency = _prefixId.prefix "Agency"
    /// <summary>
    ///   <para>rdfs:comment : US government board^^xsd:string</para>
    ///   <para>rdfs:label : Board^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Board">fea:Board</a>
    /// </summary>
    let Board = _prefixId.prefix "Board"
    /// <summary>
    ///   <para>rdfs:label : Budget^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Budget">fea:Budget</a>
    /// </summary>
    let Budget = _prefixId.prefix "Budget"
    /// <summary>
    ///   <para>rdfs:comment : Citizen of the United States of Americe^^xsd:string</para>
    ///   <para>rdfs:label : Citizen^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Citizen">fea:Citizen</a>
    /// </summary>
    let Citizen = _prefixId.prefix "Citizen"
    /// <summary>
    ///   <para>rdfs:comment : An employee of the US Government^^xsd:string</para>
    ///   <para>rdfs:label : Civil Servant^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#CivilServant">fea:CivilServant</a>
    /// </summary>
    let CivilServant = _prefixId.prefix "CivilServant"
    /// <summary>
    ///   <para>rdfs:comment : Us government commission^^xsd:string</para>
    ///   <para>rdfs:label : Commission^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Commission">fea:Commission</a>
    /// </summary>
    let Commission = _prefixId.prefix "Commission"
    /// <summary>
    ///   <para>rdfs:comment : A commercial organization^^xsd:string</para>
    ///   <para>rdfs:label : Company^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Company">fea:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:comment : US Government council^^xsd:string</para>
    ///   <para>rdfs:label : Council^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Council">fea:Council</a>
    /// </summary>
    let Council = _prefixId.prefix "Council"
    /// <summary>
    ///   <para>rdfs:comment : The diverse nature of federal programs means that there are many customers spanning the citizen, business, other government, and internal categories.  Some customers
    /// receive direct government services, such as veterans receiving health care from the Veterans Health Administration. Other â€œcustomersâ€ are those subject to regulatory activities, such as large businesses conforming to safety regulations administered by the Occupational Safety and Health Administration. Importantly, the citizen is generally considered to be the ultimate â€œcustomerâ€ of government activities regardless of the nature of the customer relationship.
    /// PRM volume 1, p.14^^xsd:string</para>
    ///   <para>rdfs:label : Customer^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Customer">fea:Customer</a>
    /// </summary>
    let Customer = _prefixId.prefix "Customer"
    /// <summary>
    ///   <para>rdfs:comment : Executive Agency of the US government^^xsd:string</para>
    ///   <para>rdfs:label : Executive Agency^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#ExecutiveAgency">fea:ExecutiveAgency</a>
    /// </summary>
    let ExecutiveAgency = _prefixId.prefix "ExecutiveAgency"
    /// <summary>
    ///   <para>rdfs:label : FEA Architecture Concept^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FEA_ArchitectureConcept">fea:FEA_ArchitectureConcept</a>
    /// </summary>
    let FEA_ArchitectureConcept = _prefixId.prefix "FEA_ArchitectureConcept"
    /// <summary>
    ///   <para>rdfs:label : FEA Concept^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FEA_Concept">fea:FEA_Concept</a>
    /// </summary>
    let FEA_Concept = _prefixId.prefix "FEA_Concept"
    /// <summary>
    ///   <para>rdfs:label : FEA Enterprise Concept^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FEA_EnterpriseConcept">fea:FEA_EnterpriseConcept</a>
    /// </summary>
    let FEA_EnterpriseConcept = _prefixId.prefix "FEA_EnterpriseConcept"
    /// <summary>
    ///   <para>rdfs:comment : 1, the FEA is being constructed through a collection of interrelated
    /// â€œreference modelsâ€ designed to facilitate cross-agency analysis and the identification of duplicative investments, gaps, and opportunities for collaboration within and across Federal Agencies.^^xsd:string</para>
    ///   <para>rdfs:label : FEA Model^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FEA_Model">fea:FEA_Model</a>
    /// </summary>
    let FEA_Model = _prefixId.prefix "FEA_Model"
    /// <summary>
    ///   <para>rdfs:label : FEA Technology Concept^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FEA_TechnologyConcept">fea:FEA_TechnologyConcept</a>
    /// </summary>
    let FEA_TechnologyConcept = _prefixId.prefix "FEA_TechnologyConcept"
    /// <summary>
    ///   <para>rdfs:comment : To facilitate efforts to transform the Federal Government to one that is citizen-centered, results-oriented, and market-based, the Office of Management and Budget (OMB) is developing the Federal Enterprise Architecture (FEA), a business-based framework for Governmentwide improvement.^^xsd:string</para>
    ///   <para>rdfs:label : Federal Enterprise Architecture^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#FederalEnterpriseArchitecture">fea:FederalEnterpriseArchitecture</a>
    /// </summary>
    let FederalEnterpriseArchitecture = _prefixId.prefix "FederalEnterpriseArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : Any US government organization^^xsd:string</para>
    ///   <para>rdfs:label : Government Body^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#GovernmentBody">fea:GovernmentBody</a>
    /// </summary>
    let GovernmentBody = _prefixId.prefix "GovernmentBody"
    /// <summary>
    ///   <para>rdfs:comment : This class refers to the workforce^^xsd:string</para>
    ///   <para>rdfs:label : Human Resource^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#HumanResource">fea:HumanResource</a>
    /// </summary>
    let HumanResource = _prefixId.prefix "HumanResource"
    /// <summary>
    ///   <para>rdfs:comment : A program of work that implements information technology based capabilities.^^xsd:string</para>
    ///   <para>rdfs:label : IT Initiative^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#IT_Initiative">fea:IT_Initiative</a>
    /// </summary>
    let IT_Initiative = _prefixId.prefix "IT_Initiative"
    /// <summary>
    ///   <para>rdfs:comment : Independent Agency of the US government^^xsd:string</para>
    ///   <para>rdfs:label : Independent Agency^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#IndependentAgency">fea:IndependentAgency</a>
    /// </summary>
    let IndependentAgency = _prefixId.prefix "IndependentAgency"
    /// <summary>
    ///   <para>rdfs:comment : Any non government organization^^xsd:string</para>
    ///   <para>rdfs:label : Industry Body^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#IndustryBody">fea:IndustryBody</a>
    /// </summary>
    let IndustryBody = _prefixId.prefix "IndustryBody"
    /// <summary>
    ///   <para>rdfs:comment : Missions are carried out by the organizational entities^^xsd:string</para>
    ///   <para>rdfs:label : Mission^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Mission">fea:Mission</a>
    /// </summary>
    let Mission = _prefixId.prefix "Mission"
    /// <summary>
    ///   <para>rdfs:comment : US government office^^xsd:string</para>
    ///   <para>rdfs:label : Office^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Office">fea:Office</a>
    /// </summary>
    let Office = _prefixId.prefix "Office"
    /// <summary>
    ///   <para>rdfs:label : Organization Entity^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#OrganizationEntity">fea:OrganizationEntity</a>
    /// </summary>
    let OrganizationEntity = _prefixId.prefix "OrganizationEntity"
    /// <summary>
    ///   <para>rdfs:comment : This class includes any fixed assets such as vehicle fleets, facilities and other equipment.^^xsd:string</para>
    ///   <para>rdfs:label : Other Fixed Asset^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#OtherFixedAsset">fea:OtherFixedAsset</a>
    /// </summary>
    let OtherFixedAsset = _prefixId.prefix "OtherFixedAsset"
    /// <summary>
    ///   <para>rdfs:comment : Each reference model has an extensional  property based on partitioning. This reveals implicit semantics in each reference model.
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : Partition^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Partition">fea:Partition</a>
    /// </summary>
    let Partition = _prefixId.prefix "Partition"
    /// <summary>
    ///   <para>rdfs:label : Party^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Party">fea:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:comment : The BRM includes a Mode of Delivery Business Area that is designed to identify at a very high level the process that is being used to achieve an intended purpose.
    /// PRM volume 1, p.16^^xsd:string</para>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Process">fea:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:comment : Quasi Official Agency of the US government^^xsd:string</para>
    ///   <para>rdfs:label : Quasi Official Agency^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#QuasiOfficialAgency">fea:QuasiOfficialAgency</a>
    /// </summary>
    let QuasiOfficialAgency = _prefixId.prefix "QuasiOfficialAgency"
    /// <summary>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Resource">fea:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:comment : Technology standard^^xsd:string</para>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Standard">fea:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:comment : Strategic Outcomes represent broad, policy priorities that drive the direction of government (such as to Secure the Homeland or Expand E-Government).
    /// PRM volume 1, p.13^^xsd:string</para>
    ///   <para>rdfs:label : Strategic Outcome^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#StrategicOutcome">fea:StrategicOutcome</a>
    /// </summary>
    let StrategicOutcome = _prefixId.prefix "StrategicOutcome"
    /// <summary>
    ///   <para>rdfs:comment : Technology means Information Technology^^xsd:string</para>
    ///   <para>rdfs:label : Technology^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#Technology">fea:Technology</a>
    /// </summary>
    let Technology = _prefixId.prefix "Technology"
    /// <summary>
    ///   <para>rdfs:comment : The point at which value is measured.^^xsd:string</para>
    ///   <para>rdfs:label : ValuePoint^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#ValuePoint">fea:ValuePoint</a>
    /// </summary>
    let ValuePoint = _prefixId.prefix "ValuePoint"
    /// <summary>
    ///   <para>rdfs:label : allignedWith^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#allignedWith">fea:allignedWith</a>
    /// </summary>
    let allignedWith = _prefixId.prefix "allignedWith"
    /// <summary>
    ///   <para>rdfs:label : buildsOn^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#buildsOn">fea:buildsOn</a>
    /// </summary>
    let buildsOn = _prefixId.prefix "buildsOn"
    /// <summary>
    ///   <para>rdfs:label : comprises^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#comprises">fea:comprises</a>
    /// </summary>
    let comprises = _prefixId.prefix "comprises"
    /// <summary>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#date">fea:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : dependsOn^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#dependsOn">fea:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#description">fea:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : drawsUpon^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#drawsUpon">fea:drawsUpon</a>
    /// </summary>
    let drawsUpon = _prefixId.prefix "drawsUpon"
    /// <summary>
    ///   <para>rdfs:label : hasIntent^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#hasIntent">fea:hasIntent</a>
    /// </summary>
    let hasIntent = _prefixId.prefix "hasIntent"
    /// <summary>
    ///   <para>rdfs:label : intentOf^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#intentOf">fea:intentOf</a>
    /// </summary>
    let intentOf = _prefixId.prefix "intentOf"
    /// <summary>
    ///   <para>rdfs:label : isComprisedOf^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#isComprisedOf">fea:isComprisedOf</a>
    /// </summary>
    let isComprisedOf = _prefixId.prefix "isComprisedOf"
    /// <summary>
    ///   <para>rdfs:comment : used to describe part of relationships, such as, for example, the fact that one organization is part of another (departmental hierarchy).^^xsd:string</para>
    ///   <para>rdfs:label : is part of^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#isPartOf">fea:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : mnemonic^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#mnemonic">fea:mnemonic</a>
    /// </summary>
    let mnemonic = _prefixId.prefix "mnemonic"
    /// <summary>
    ///   <para>rdfs:label : supportedBy^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#supportedBy">fea:supportedBy</a>
    /// </summary>
    let supportedBy = _prefixId.prefix "supportedBy"
    /// <summary>
    ///   <para>rdfs:label : undertakenBy^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#undertakenBy">fea:undertakenBy</a>
    /// </summary>
    let undertakenBy = _prefixId.prefix "undertakenBy"
    /// <summary>
    ///   <para>rdfs:label : undertakes^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/fea#undertakes">fea:undertakes</a>
    /// </summary>
    let undertakes = _prefixId.prefix "undertakes"
