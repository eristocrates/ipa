namespace http.vocab.data.gov.def.fea.hash

open DoxAletheia

module fea =
    let _namespace_name = "http://vocab.data.gov/def/fea#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#Agency"></see></summary>
    let Agency = _prefix "Agency"
    /// <summary>
    /// The point at which value is measured.
    /// <see href="http://vocab.data.gov/def/fea#ValuePoint"></see></summary>
    let ValuePoint = _prefix "ValuePoint"
    /// <summary>
    /// Any US government organization
    /// <see href="http://vocab.data.gov/def/fea#GovernmentBody"></see></summary>
    let GovernmentBody = _prefix "GovernmentBody"
    /// <summary>
    /// US government board
    /// <see href="http://vocab.data.gov/def/fea#Board"></see></summary>
    let Board = _prefix "Board"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Budget"></see>
    /// </summary>
    let Budget = _prefix "Budget"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_EnterpriseConcept"></see>
    /// </summary>
    let FEA_EnterpriseConcept = _prefix "FEA_EnterpriseConcept"
    /// <summary>
    /// Citizen of the United States of Americe
    /// <see href="http://vocab.data.gov/def/fea#Citizen"></see></summary>
    let Citizen = _prefix "Citizen"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Party"></see>
    /// </summary>
    let Party = _prefix "Party"
    /// <summary>
    /// An employee of the US Government
    /// <see href="http://vocab.data.gov/def/fea#CivilServant"></see></summary>
    let CivilServant = _prefix "CivilServant"
    /// <summary>
    /// Us government commission
    /// <see href="http://vocab.data.gov/def/fea#Commission"></see></summary>
    let Commission = _prefix "Commission"
    /// <summary>
    /// A commercial organization
    /// <see href="http://vocab.data.gov/def/fea#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// Any non government organization
    /// <see href="http://vocab.data.gov/def/fea#IndustryBody"></see></summary>
    let IndustryBody = _prefix "IndustryBody"
    /// <summary>
    /// US Government council
    /// <see href="http://vocab.data.gov/def/fea#Council"></see></summary>
    let Council = _prefix "Council"
    /// <summary>
    /// The diverse nature of federal programs means that there are many customers spanning the citizen, business, other government, and internal categories.  Some customers
    /// receive direct government services, such as veterans receiving health care from the Veterans Health Administration. Other â€œcustomersâ€ are those subject to regulatory activities, such as large businesses conforming to safety regulations administered by the Occupational Safety and Health Administration. Importantly, the citizen is generally considered to be the ultimate â€œcustomerâ€ of government activities regardless of the nature of the customer relationship.
    /// PRM volume 1, p.14
    /// <see href="http://vocab.data.gov/def/fea#Customer"></see></summary>
    let Customer = _prefix "Customer"
    /// <summary>
    /// Executive Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#ExecutiveAgency"></see></summary>
    let ExecutiveAgency = _prefix "ExecutiveAgency"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_ArchitectureConcept"></see>
    /// </summary>
    let FEA_ArchitectureConcept = _prefix "FEA_ArchitectureConcept"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_Concept"></see>
    /// </summary>
    let FEA_Concept = _prefix "FEA_Concept"
    /// <summary>
    /// 1, the FEA is being constructed through a collection of interrelated
    /// â€œreference modelsâ€ designed to facilitate cross-agency analysis and the identification of duplicative investments, gaps, and opportunities for collaboration within and across Federal Agencies.
    /// <see href="http://vocab.data.gov/def/fea#FEA_Model"></see></summary>
    let FEA_Model = _prefix "FEA_Model"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_TechnologyConcept"></see>
    /// </summary>
    let FEA_TechnologyConcept = _prefix "FEA_TechnologyConcept"
    /// <summary>
    /// To facilitate efforts to transform the Federal Government to one that is citizen-centered, results-oriented, and market-based, the Office of Management and Budget (OMB) is developing the Federal Enterprise Architecture (FEA), a business-based framework for Governmentwide improvement.
    /// <see href="http://vocab.data.gov/def/fea#FederalEnterpriseArchitecture"></see></summary>
    let FederalEnterpriseArchitecture = _prefix "FederalEnterpriseArchitecture"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#OrganizationEntity"></see>
    /// </summary>
    let OrganizationEntity = _prefix "OrganizationEntity"
    /// <summary>
    /// This class refers to the workforce
    /// <see href="http://vocab.data.gov/def/fea#HumanResource"></see></summary>
    let HumanResource = _prefix "HumanResource"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// A program of work that implements information technology based capabilities.
    /// <see href="http://vocab.data.gov/def/fea#IT_Initiative"></see></summary>
    let IT_Initiative = _prefix "IT_Initiative"
    /// <summary>
    /// Independent Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#IndependentAgency"></see></summary>
    let IndependentAgency = _prefix "IndependentAgency"
    /// <summary>
    /// Missions are carried out by the organizational entities
    /// <see href="http://vocab.data.gov/def/fea#Mission"></see></summary>
    let Mission = _prefix "Mission"
    /// <summary>
    /// US government office
    /// <see href="http://vocab.data.gov/def/fea#Office"></see></summary>
    let Office = _prefix "Office"
    /// <summary>
    /// This class includes any fixed assets such as vehicle fleets, facilities and other equipment.
    /// <see href="http://vocab.data.gov/def/fea#OtherFixedAsset"></see></summary>
    let OtherFixedAsset = _prefix "OtherFixedAsset"
    /// <summary>
    /// Each reference model has an extensional  property based on partitioning. This reveals implicit semantics in each reference model.
    ///
    /// <see href="http://vocab.data.gov/def/fea#Partition"></see></summary>
    let Partition = _prefix "Partition"
    /// <summary>
    /// The BRM includes a Mode of Delivery Business Area that is designed to identify at a very high level the process that is being used to achieve an intended purpose.
    /// PRM volume 1, p.16
    /// <see href="http://vocab.data.gov/def/fea#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// Quasi Official Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#QuasiOfficialAgency"></see></summary>
    let QuasiOfficialAgency = _prefix "QuasiOfficialAgency"
    /// <summary>
    /// Technology standard
    /// <see href="http://vocab.data.gov/def/fea#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// Strategic Outcomes represent broad, policy priorities that drive the direction of government (such as to Secure the Homeland or Expand E-Government).
    /// PRM volume 1, p.13
    /// <see href="http://vocab.data.gov/def/fea#StrategicOutcome"></see></summary>
    let StrategicOutcome = _prefix "StrategicOutcome"
    /// <summary>
    /// Technology means Information Technology
    /// <see href="http://vocab.data.gov/def/fea#Technology"></see></summary>
    let Technology = _prefix "Technology"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#allignedWith"></see>
    /// </summary>
    let allignedWith = _prefix "allignedWith"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#buildsOn"></see>
    /// </summary>
    let buildsOn = _prefix "buildsOn"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#comprises"></see>
    /// </summary>
    let comprises = _prefix "comprises"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#dependsOn"></see>
    /// </summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#drawsUpon"></see>
    /// </summary>
    let drawsUpon = _prefix "drawsUpon"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#hasIntent"></see>
    /// </summary>
    let hasIntent = _prefix "hasIntent"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#intentOf"></see>
    /// </summary>
    let intentOf = _prefix "intentOf"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#isComprisedOf"></see>
    /// </summary>
    let isComprisedOf = _prefix "isComprisedOf"
    /// <summary>
    /// used to describe part of relationships, such as, for example, the fact that one organization is part of another (departmental hierarchy).
    /// <see href="http://vocab.data.gov/def/fea#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#mnemonic"></see>
    /// </summary>
    let mnemonic = _prefix "mnemonic"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#supportedBy"></see>
    /// </summary>
    let supportedBy = _prefix "supportedBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#undertakenBy"></see>
    /// </summary>
    let undertakenBy = _prefix "undertakenBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#undertakes"></see>
    /// </summary>
    let undertakes = _prefix "undertakes"
