namespace https.w3id.org.sri.hash

open DoxAletheia.Rdf_Vocabulary

module sri =
    let _namespace_name = "https://w3id.org/sri#"
    /// <summary>
    /// This represents a building which is assessed.
    /// <see href="https://w3id.org/sri#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// Class of technical domains.
    /// <see href="https://w3id.org/sri#Domain"></see></summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName
    /// <summary>
    /// Class for Services.
    /// <see href="https://w3id.org/sri#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Class of instances in the functional hierarchy, this includes Domains and Services.
    /// <see href="https://w3id.org/sri#FunctionalThing"></see></summary>
    let FunctionalThing =
        Namespaced_IRI.parse _namespace_name "FunctionalThing" |> NamespacedName

    /// <summary>
    /// Class of Impacts.
    /// <see href="https://w3id.org/sri#Impact"></see></summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName

    /// <summary>
    /// Class of all Key Capabilities, aggregation of Impacts.
    /// <see href="https://w3id.org/sri#KeyCapability"></see></summary>
    let KeyCapability =
        Namespaced_IRI.parse _namespace_name "KeyCapability" |> NamespacedName

    /// <summary>
    /// Class of all instances in the impact hierarchy, this includes Impacts and Key Capabilities.
    /// <see href="https://w3id.org/sri#ImpactThing"></see></summary>
    let ImpactThing =
        Namespaced_IRI.parse _namespace_name "ImpactThing" |> NamespacedName

    /// <summary>
    /// Class of service levels.
    /// <see href="https://w3id.org/sri#Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName

    /// <summary>
    /// A Service Catalogue is a collection of services used in an assessment.
    /// <see href="https://w3id.org/sri#ServiceCatalogue"></see></summary>
    let ServiceCatalogue =
        Namespaced_IRI.parse _namespace_name "ServiceCatalogue" |> NamespacedName

    /// <summary>
    /// Class for all ServiceLevel instances, which are all allowed/defined combinations of Services and Levels.
    /// <see href="https://w3id.org/sri#ServiceLevel"></see></summary>
    let ServiceLevel =
        Namespaced_IRI.parse _namespace_name "ServiceLevel" |> NamespacedName

    /// <summary>
    /// Relates something to a FunctionalThing.
    /// <see href="https://w3id.org/sri#function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName
    /// <summary>
    /// Relates something to a Level.
    /// <see href="https://w3id.org/sri#level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#adaptTheirOperationToTheNeedsOfTheOccupant"></see>
    /// </summary>
    let adaptTheirOperationToTheNeedsOfTheOccupant =
        Namespaced_IRI.parse _namespace_name "adaptTheirOperationToTheNeedsOfTheOccupant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#comfort"></see>
    /// </summary>
    let comfort = Namespaced_IRI.parse _namespace_name "comfort" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#convenience"></see>
    /// </summary>
    let convenience =
        Namespaced_IRI.parse _namespace_name "convenience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#health_well_being_and_accessibility"></see>
    /// </summary>
    let health_well_being_and_accessibility =
        Namespaced_IRI.parse _namespace_name "health_well_being_and_accessibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#information_to_occupants"></see>
    /// </summary>
    let information_to_occupants =
        Namespaced_IRI.parse _namespace_name "information_to_occupants" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#adaptToSignalsFromTheGrid"></see>
    /// </summary>
    let adaptToSignalsFromTheGrid =
        Namespaced_IRI.parse _namespace_name "adaptToSignalsFromTheGrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#energy_flexibility_and_storage"></see>
    /// </summary>
    let energy_flexibility_and_storage =
        Namespaced_IRI.parse _namespace_name "energy_flexibility_and_storage" |> NamespacedName

    /// <summary>
    /// Additional Level if share is &lt; 100%.
    /// <see href="https://w3id.org/sri#additionalLevel"></see></summary>
    let additionalLevel =
        Namespaced_IRI.parse _namespace_name "additionalLevel" |> NamespacedName

    /// <summary>
    /// Relates something to an assessment dataset.
    /// <see href="https://w3id.org/sri#assessment"></see></summary>
    let assessment = Namespaced_IRI.parse _namespace_name "assessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-assessment"></see>
    /// </summary>
    let ``dsd-assessment`` =
        Namespaced_IRI.parse _namespace_name "dsd-assessment" |> NamespacedName

    /// <summary>
    /// Relates something to a Building.
    /// <see href="https://w3id.org/sri#building"></see></summary>
    let building = Namespaced_IRI.parse _namespace_name "building" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#cooling"></see>
    /// </summary>
    let cooling = Namespaced_IRI.parse _namespace_name "cooling" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#dE"></see>
    /// </summary>
    let dE = Namespaced_IRI.parse _namespace_name "dE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#dHW"></see>
    /// </summary>
    let dHW = Namespaced_IRI.parse _namespace_name "dHW" |> NamespacedName
    /// <summary>
    /// Relates something to an ImpactThing.
    /// <see href="https://w3id.org/sri#impact"></see></summary>
    let impact = Namespaced_IRI.parse _namespace_name "impact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-scores"></see>
    /// </summary>
    let ``dsd-scores`` =
        Namespaced_IRI.parse _namespace_name "dsd-scores" |> NamespacedName

    /// <summary>
    /// The smart-readiness score is defined for ImpactThings on all levels from Impacts to the complete Building (Steps 5, 6, and 7) and optionally for Domains (Step 8)
    /// <see href="https://w3id.org/sri#score"></see></summary>
    let score = Namespaced_IRI.parse _namespace_name "score" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-sriscores"></see>
    /// </summary>
    let ``dsd-sriscores`` =
        Namespaced_IRI.parse _namespace_name "dsd-sriscores" |> NamespacedName

    /// <summary>
    /// The impact criterion score is defined for Services and calculated for Domains in Step 3.
    /// <see href="https://w3id.org/sri#icscore"></see></summary>
    let icscore = Namespaced_IRI.parse _namespace_name "icscore" |> NamespacedName
    /// <summary>
    /// A weight of the weight matrix used for weighing the smart-readiness scores before aggregation.
    /// <see href="https://w3id.org/sri#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#dsd-weights"></see>
    /// </summary>
    let ``dsd-weights`` =
        Namespaced_IRI.parse _namespace_name "dsd-weights" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#eV"></see>
    /// </summary>
    let eV = Namespaced_IRI.parse _namespace_name "eV" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#electricity"></see>
    /// </summary>
    let electricity =
        Namespaced_IRI.parse _namespace_name "electricity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#energy_efficiency"></see>
    /// </summary>
    let energy_efficiency =
        Namespaced_IRI.parse _namespace_name "energy_efficiency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#heating"></see>
    /// </summary>
    let heating = Namespaced_IRI.parse _namespace_name "heating" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#level0"></see>
    /// </summary>
    let level0 = Namespaced_IRI.parse _namespace_name "level0" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#level1"></see>
    /// </summary>
    let level1 = Namespaced_IRI.parse _namespace_name "level1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#level2"></see>
    /// </summary>
    let level2 = Namespaced_IRI.parse _namespace_name "level2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#level3"></see>
    /// </summary>
    let level3 = Namespaced_IRI.parse _namespace_name "level3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#level4"></see>
    /// </summary>
    let level4 = Namespaced_IRI.parse _namespace_name "level4" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#lighting"></see>
    /// </summary>
    let lighting = Namespaced_IRI.parse _namespace_name "lighting" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#mC"></see>
    /// </summary>
    let mC = Namespaced_IRI.parse _namespace_name "mC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#maintenance_and_fault_prediction"></see>
    /// </summary>
    let maintenance_and_fault_prediction =
        Namespaced_IRI.parse _namespace_name "maintenance_and_fault_prediction" |> NamespacedName

    /// <summary>
    /// Maximum impact criterion score. This is defined for Domains and calculated in Step 4.
    /// <see href="https://w3id.org/sri#max"></see></summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#optimiseEnergyEfficiencyAndOverallIn-UsePerformance"></see>
    /// </summary>
    let ``optimiseEnergyEfficiencyAndOverallIn-UsePerformance`` =
        Namespaced_IRI.parse _namespace_name "optimiseEnergyEfficiencyAndOverallIn-UsePerformance" |> NamespacedName

    /// <summary>
    /// Relates something to a ServiceCatalogue.
    /// <see href="https://w3id.org/sri#serviceCatalogue"></see></summary>
    let serviceCatalogue =
        Namespaced_IRI.parse _namespace_name "serviceCatalogue" |> NamespacedName

    /// <summary>
    /// A percentage (value between 0.0 and 1.0) which expresses that parts of a building are assessed with different levels wrt. a Service. If share is &lt; 100% then additionalLevel has to be defined.
    /// <see href="https://w3id.org/sri#share"></see></summary>
    let share = Namespaced_IRI.parse _namespace_name "share" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sri#topDomain"></see>
    /// </summary>
    let topDomain = Namespaced_IRI.parse _namespace_name "topDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#ventilation"></see>
    /// </summary>
    let ventilation =
        Namespaced_IRI.parse _namespace_name "ventilation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sri#topImpact"></see>
    /// </summary>
    let topImpact = Namespaced_IRI.parse _namespace_name "topImpact" |> NamespacedName
