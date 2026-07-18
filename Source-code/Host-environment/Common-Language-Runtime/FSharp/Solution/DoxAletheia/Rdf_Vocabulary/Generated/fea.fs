namespace http.vocab.data.gov.def.fea.hash

open DoxAletheia.Rdf_Vocabulary

module fea =
    let _namespace_name = "http://vocab.data.gov/def/fea#"
    /// <summary>
    /// An agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#Agency"></see></summary>
    let Agency = Namespaced_IRI.parse _namespace_name "Agency" |> NamespacedName
    /// <summary>
    /// The point at which value is measured.
    /// <see href="http://vocab.data.gov/def/fea#ValuePoint"></see></summary>
    let ValuePoint = Namespaced_IRI.parse _namespace_name "ValuePoint" |> NamespacedName

    /// <summary>
    /// Any US government organization
    /// <see href="http://vocab.data.gov/def/fea#GovernmentBody"></see></summary>
    let GovernmentBody =
        Namespaced_IRI.parse _namespace_name "GovernmentBody" |> NamespacedName

    /// <summary>
    /// US government board
    /// <see href="http://vocab.data.gov/def/fea#Board"></see></summary>
    let Board = Namespaced_IRI.parse _namespace_name "Board" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Budget"></see>
    /// </summary>
    let Budget = Namespaced_IRI.parse _namespace_name "Budget" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_EnterpriseConcept"></see>
    /// </summary>
    let FEA_EnterpriseConcept =
        Namespaced_IRI.parse _namespace_name "FEA_EnterpriseConcept" |> NamespacedName

    /// <summary>
    /// Citizen of the United States of Americe
    /// <see href="http://vocab.data.gov/def/fea#Citizen"></see></summary>
    let Citizen = Namespaced_IRI.parse _namespace_name "Citizen" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Party"></see>
    /// </summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName

    /// <summary>
    /// An employee of the US Government
    /// <see href="http://vocab.data.gov/def/fea#CivilServant"></see></summary>
    let CivilServant =
        Namespaced_IRI.parse _namespace_name "CivilServant" |> NamespacedName

    /// <summary>
    /// Us government commission
    /// <see href="http://vocab.data.gov/def/fea#Commission"></see></summary>
    let Commission = Namespaced_IRI.parse _namespace_name "Commission" |> NamespacedName
    /// <summary>
    /// A commercial organization
    /// <see href="http://vocab.data.gov/def/fea#Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    /// Any non government organization
    /// <see href="http://vocab.data.gov/def/fea#IndustryBody"></see></summary>
    let IndustryBody =
        Namespaced_IRI.parse _namespace_name "IndustryBody" |> NamespacedName

    /// <summary>
    /// US Government council
    /// <see href="http://vocab.data.gov/def/fea#Council"></see></summary>
    let Council = Namespaced_IRI.parse _namespace_name "Council" |> NamespacedName
    /// <summary>
    /// The diverse nature of federal programs means that there are many customers spanning the citizen, business, other government, and internal categories.  Some customers
    /// receive direct government services, such as veterans receiving health care from the Veterans Health Administration. Other â€œcustomersâ€ are those subject to regulatory activities, such as large businesses conforming to safety regulations administered by the Occupational Safety and Health Administration. Importantly, the citizen is generally considered to be the ultimate â€œcustomerâ€ of government activities regardless of the nature of the customer relationship.
    /// PRM volume 1, p.14
    /// <see href="http://vocab.data.gov/def/fea#Customer"></see></summary>
    let Customer = Namespaced_IRI.parse _namespace_name "Customer" |> NamespacedName

    /// <summary>
    /// Executive Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#ExecutiveAgency"></see></summary>
    let ExecutiveAgency =
        Namespaced_IRI.parse _namespace_name "ExecutiveAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_ArchitectureConcept"></see>
    /// </summary>
    let FEA_ArchitectureConcept =
        Namespaced_IRI.parse _namespace_name "FEA_ArchitectureConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_Concept"></see>
    /// </summary>
    let FEA_Concept =
        Namespaced_IRI.parse _namespace_name "FEA_Concept" |> NamespacedName

    /// <summary>
    /// 1, the FEA is being constructed through a collection of interrelated
    /// â€œreference modelsâ€ designed to facilitate cross-agency analysis and the identification of duplicative investments, gaps, and opportunities for collaboration within and across Federal Agencies.
    /// <see href="http://vocab.data.gov/def/fea#FEA_Model"></see></summary>
    let FEA_Model = Namespaced_IRI.parse _namespace_name "FEA_Model" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#FEA_TechnologyConcept"></see>
    /// </summary>
    let FEA_TechnologyConcept =
        Namespaced_IRI.parse _namespace_name "FEA_TechnologyConcept" |> NamespacedName

    /// <summary>
    /// To facilitate efforts to transform the Federal Government to one that is citizen-centered, results-oriented, and market-based, the Office of Management and Budget (OMB) is developing the Federal Enterprise Architecture (FEA), a business-based framework for Governmentwide improvement.
    /// <see href="http://vocab.data.gov/def/fea#FederalEnterpriseArchitecture"></see></summary>
    let FederalEnterpriseArchitecture =
        Namespaced_IRI.parse _namespace_name "FederalEnterpriseArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#OrganizationEntity"></see>
    /// </summary>
    let OrganizationEntity =
        Namespaced_IRI.parse _namespace_name "OrganizationEntity" |> NamespacedName

    /// <summary>
    /// This class refers to the workforce
    /// <see href="http://vocab.data.gov/def/fea#HumanResource"></see></summary>
    let HumanResource =
        Namespaced_IRI.parse _namespace_name "HumanResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// A program of work that implements information technology based capabilities.
    /// <see href="http://vocab.data.gov/def/fea#IT_Initiative"></see></summary>
    let IT_Initiative =
        Namespaced_IRI.parse _namespace_name "IT_Initiative" |> NamespacedName

    /// <summary>
    /// Independent Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#IndependentAgency"></see></summary>
    let IndependentAgency =
        Namespaced_IRI.parse _namespace_name "IndependentAgency" |> NamespacedName

    /// <summary>
    /// Missions are carried out by the organizational entities
    /// <see href="http://vocab.data.gov/def/fea#Mission"></see></summary>
    let Mission = Namespaced_IRI.parse _namespace_name "Mission" |> NamespacedName
    /// <summary>
    /// US government office
    /// <see href="http://vocab.data.gov/def/fea#Office"></see></summary>
    let Office = Namespaced_IRI.parse _namespace_name "Office" |> NamespacedName

    /// <summary>
    /// This class includes any fixed assets such as vehicle fleets, facilities and other equipment.
    /// <see href="http://vocab.data.gov/def/fea#OtherFixedAsset"></see></summary>
    let OtherFixedAsset =
        Namespaced_IRI.parse _namespace_name "OtherFixedAsset" |> NamespacedName

    /// <summary>
    /// Each reference model has an extensional  property based on partitioning. This reveals implicit semantics in each reference model.
    ///
    /// <see href="http://vocab.data.gov/def/fea#Partition"></see></summary>
    let Partition = Namespaced_IRI.parse _namespace_name "Partition" |> NamespacedName
    /// <summary>
    /// The BRM includes a Mode of Delivery Business Area that is designed to identify at a very high level the process that is being used to achieve an intended purpose.
    /// PRM volume 1, p.16
    /// <see href="http://vocab.data.gov/def/fea#Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    /// Quasi Official Agency of the US government
    /// <see href="http://vocab.data.gov/def/fea#QuasiOfficialAgency"></see></summary>
    let QuasiOfficialAgency =
        Namespaced_IRI.parse _namespace_name "QuasiOfficialAgency" |> NamespacedName

    /// <summary>
    /// Technology standard
    /// <see href="http://vocab.data.gov/def/fea#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    /// Strategic Outcomes represent broad, policy priorities that drive the direction of government (such as to Secure the Homeland or Expand E-Government).
    /// PRM volume 1, p.13
    /// <see href="http://vocab.data.gov/def/fea#StrategicOutcome"></see></summary>
    let StrategicOutcome =
        Namespaced_IRI.parse _namespace_name "StrategicOutcome" |> NamespacedName

    /// <summary>
    /// Technology means Information Technology
    /// <see href="http://vocab.data.gov/def/fea#Technology"></see></summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#allignedWith"></see>
    /// </summary>
    let allignedWith =
        Namespaced_IRI.parse _namespace_name "allignedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#buildsOn"></see>
    /// </summary>
    let buildsOn = Namespaced_IRI.parse _namespace_name "buildsOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#comprises"></see>
    /// </summary>
    let comprises = Namespaced_IRI.parse _namespace_name "comprises" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#dependsOn"></see>
    /// </summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#drawsUpon"></see>
    /// </summary>
    let drawsUpon = Namespaced_IRI.parse _namespace_name "drawsUpon" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#hasIntent"></see>
    /// </summary>
    let hasIntent = Namespaced_IRI.parse _namespace_name "hasIntent" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#intentOf"></see>
    /// </summary>
    let intentOf = Namespaced_IRI.parse _namespace_name "intentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#isComprisedOf"></see>
    /// </summary>
    let isComprisedOf =
        Namespaced_IRI.parse _namespace_name "isComprisedOf" |> NamespacedName

    /// <summary>
    /// used to describe part of relationships, such as, for example, the fact that one organization is part of another (departmental hierarchy).
    /// <see href="http://vocab.data.gov/def/fea#isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#mnemonic"></see>
    /// </summary>
    let mnemonic = Namespaced_IRI.parse _namespace_name "mnemonic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#supportedBy"></see>
    /// </summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#undertakenBy"></see>
    /// </summary>
    let undertakenBy =
        Namespaced_IRI.parse _namespace_name "undertakenBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/fea#undertakes"></see>
    /// </summary>
    let undertakes = Namespaced_IRI.parse _namespace_name "undertakes" |> NamespacedName
