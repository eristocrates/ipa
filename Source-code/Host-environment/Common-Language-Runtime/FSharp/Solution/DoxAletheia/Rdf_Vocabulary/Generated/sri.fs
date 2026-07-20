namespace https.w3id.org.sri.hash

open DoxAletheia

module sri =
    let _namespace_name = "https://w3id.org/sri#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This represents a building which is assessed.
    /// <see href="https://w3id.org/sri#Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// Class of technical domains.
    /// <see href="https://w3id.org/sri#Domain"></see></summary>
    let Domain = _prefix "Domain"
    /// <summary>
    /// Class for Services.
    /// <see href="https://w3id.org/sri#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Class of instances in the functional hierarchy, this includes Domains and Services.
    /// <see href="https://w3id.org/sri#FunctionalThing"></see></summary>
    let FunctionalThing = _prefix "FunctionalThing"
    /// <summary>
    /// Class of Impacts.
    /// <see href="https://w3id.org/sri#Impact"></see></summary>
    let Impact = _prefix "Impact"
    /// <summary>
    /// Class of all Key Capabilities, aggregation of Impacts.
    /// <see href="https://w3id.org/sri#KeyCapability"></see></summary>
    let KeyCapability = _prefix "KeyCapability"
    /// <summary>
    /// Class of all instances in the impact hierarchy, this includes Impacts and Key Capabilities.
    /// <see href="https://w3id.org/sri#ImpactThing"></see></summary>
    let ImpactThing = _prefix "ImpactThing"
    /// <summary>
    /// Class of service levels.
    /// <see href="https://w3id.org/sri#Level"></see></summary>
    let Level = _prefix "Level"
    /// <summary>
    /// A Service Catalogue is a collection of services used in an assessment.
    /// <see href="https://w3id.org/sri#ServiceCatalogue"></see></summary>
    let ServiceCatalogue = _prefix "ServiceCatalogue"
    /// <summary>
    /// Class for all ServiceLevel instances, which are all allowed/defined combinations of Services and Levels.
    /// <see href="https://w3id.org/sri#ServiceLevel"></see></summary>
    let ServiceLevel = _prefix "ServiceLevel"
    /// <summary>
    /// Relates something to a FunctionalThing.
    /// <see href="https://w3id.org/sri#function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// Relates something to a Level.
    /// <see href="https://w3id.org/sri#level"></see></summary>
    let level = _prefix "level"

    /// <summary>
    ///   <see href="https://w3id.org/sri#adaptTheirOperationToTheNeedsOfTheOccupant"></see>
    /// </summary>
    let adaptTheirOperationToTheNeedsOfTheOccupant =
        _prefix "adaptTheirOperationToTheNeedsOfTheOccupant"

    /// <summary>
    ///   <see href="https://w3id.org/sri#comfort"></see>
    /// </summary>
    let comfort = _prefix "comfort"
    /// <summary>
    ///   <see href="https://w3id.org/sri#convenience"></see>
    /// </summary>
    let convenience = _prefix "convenience"

    /// <summary>
    ///   <see href="https://w3id.org/sri#health_well_being_and_accessibility"></see>
    /// </summary>
    let health_well_being_and_accessibility =
        _prefix "health_well_being_and_accessibility"

    /// <summary>
    ///   <see href="https://w3id.org/sri#information_to_occupants"></see>
    /// </summary>
    let information_to_occupants = _prefix "information_to_occupants"
    /// <summary>
    ///   <see href="https://w3id.org/sri#adaptToSignalsFromTheGrid"></see>
    /// </summary>
    let adaptToSignalsFromTheGrid = _prefix "adaptToSignalsFromTheGrid"
    /// <summary>
    ///   <see href="https://w3id.org/sri#energy_flexibility_and_storage"></see>
    /// </summary>
    let energy_flexibility_and_storage = _prefix "energy_flexibility_and_storage"
    /// <summary>
    /// Additional Level if share is &lt; 100%.
    /// <see href="https://w3id.org/sri#additionalLevel"></see></summary>
    let additionalLevel = _prefix "additionalLevel"
    /// <summary>
    /// Relates something to an assessment dataset.
    /// <see href="https://w3id.org/sri#assessment"></see></summary>
    let assessment = _prefix "assessment"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-assessment"></see>
    /// </summary>
    let ``dsd-assessment`` = _prefix "dsd-assessment"
    /// <summary>
    /// Relates something to a Building.
    /// <see href="https://w3id.org/sri#building"></see></summary>
    let building = _prefix "building"
    /// <summary>
    ///   <see href="https://w3id.org/sri#cooling"></see>
    /// </summary>
    let cooling = _prefix "cooling"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dE"></see>
    /// </summary>
    let dE = _prefix "dE"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dHW"></see>
    /// </summary>
    let dHW = _prefix "dHW"
    /// <summary>
    /// Relates something to an ImpactThing.
    /// <see href="https://w3id.org/sri#impact"></see></summary>
    let impact = _prefix "impact"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-scores"></see>
    /// </summary>
    let ``dsd-scores`` = _prefix "dsd-scores"
    /// <summary>
    /// The smart-readiness score is defined for ImpactThings on all levels from Impacts to the complete Building (Steps 5, 6, and 7) and optionally for Domains (Step 8)
    /// <see href="https://w3id.org/sri#score"></see></summary>
    let score = _prefix "score"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-sriscores"></see>
    /// </summary>
    let ``dsd-sriscores`` = _prefix "dsd-sriscores"
    /// <summary>
    /// The impact criterion score is defined for Services and calculated for Domains in Step 3.
    /// <see href="https://w3id.org/sri#icscore"></see></summary>
    let icscore = _prefix "icscore"
    /// <summary>
    /// A weight of the weight matrix used for weighing the smart-readiness scores before aggregation.
    /// <see href="https://w3id.org/sri#weight"></see></summary>
    let weight = _prefix "weight"
    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-weights"></see>
    /// </summary>
    let ``dsd-weights`` = _prefix "dsd-weights"
    /// <summary>
    ///   <see href="https://w3id.org/sri#eV"></see>
    /// </summary>
    let eV = _prefix "eV"
    /// <summary>
    ///   <see href="https://w3id.org/sri#electricity"></see>
    /// </summary>
    let electricity = _prefix "electricity"
    /// <summary>
    ///   <see href="https://w3id.org/sri#energy_efficiency"></see>
    /// </summary>
    let energy_efficiency = _prefix "energy_efficiency"
    /// <summary>
    ///   <see href="https://w3id.org/sri#heating"></see>
    /// </summary>
    let heating = _prefix "heating"
    /// <summary>
    ///   <see href="https://w3id.org/sri#level0"></see>
    /// </summary>
    let level0 = _prefix "level0"
    /// <summary>
    ///   <see href="https://w3id.org/sri#level1"></see>
    /// </summary>
    let level1 = _prefix "level1"
    /// <summary>
    ///   <see href="https://w3id.org/sri#level2"></see>
    /// </summary>
    let level2 = _prefix "level2"
    /// <summary>
    ///   <see href="https://w3id.org/sri#level3"></see>
    /// </summary>
    let level3 = _prefix "level3"
    /// <summary>
    ///   <see href="https://w3id.org/sri#level4"></see>
    /// </summary>
    let level4 = _prefix "level4"
    /// <summary>
    ///   <see href="https://w3id.org/sri#lighting"></see>
    /// </summary>
    let lighting = _prefix "lighting"
    /// <summary>
    ///   <see href="https://w3id.org/sri#mC"></see>
    /// </summary>
    let mC = _prefix "mC"
    /// <summary>
    ///   <see href="https://w3id.org/sri#maintenance_and_fault_prediction"></see>
    /// </summary>
    let maintenance_and_fault_prediction = _prefix "maintenance_and_fault_prediction"
    /// <summary>
    /// Maximum impact criterion score. This is defined for Domains and calculated in Step 4.
    /// <see href="https://w3id.org/sri#max"></see></summary>
    let max = _prefix "max"

    /// <summary>
    ///   <see href="https://w3id.org/sri#optimiseEnergyEfficiencyAndOverallIn-UsePerformance"></see>
    /// </summary>
    let ``optimiseEnergyEfficiencyAndOverallIn-UsePerformance`` =
        _prefix "optimiseEnergyEfficiencyAndOverallIn-UsePerformance"

    /// <summary>
    /// Relates something to a ServiceCatalogue.
    /// <see href="https://w3id.org/sri#serviceCatalogue"></see></summary>
    let serviceCatalogue = _prefix "serviceCatalogue"
    /// <summary>
    /// A percentage (value between 0.0 and 1.0) which expresses that parts of a building are assessed with different levels wrt. a Service. If share is &lt; 100% then additionalLevel has to be defined.
    /// <see href="https://w3id.org/sri#share"></see></summary>
    let share = _prefix "share"
    /// <summary>
    ///   <see href="https://w3id.org/sri#topDomain"></see>
    /// </summary>
    let topDomain = _prefix "topDomain"
    /// <summary>
    ///   <see href="https://w3id.org/sri#ventilation"></see>
    /// </summary>
    let ventilation = _prefix "ventilation"
    /// <summary>
    ///   <see href="https://w3id.org/sri#topImpact"></see>
    /// </summary>
    let topImpact = _prefix "topImpact"
