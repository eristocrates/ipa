namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.EconomicIndicators.slash

open DoxAletheia

module fibo_ind_ei_ei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageDailyEarnings"></see>
    /// </summary>
    let AverageDailyEarnings = _prefix "AverageDailyEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageEarnings"></see>
    /// </summary>
    let AverageEarnings = _prefix "AverageEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Daily"></see>
    /// </summary>
    let Daily = _prefix "Daily"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EconomicIndicator"></see>
    /// </summary>
    let EconomicIndicator = _prefix "EconomicIndicator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageHourlyEarnings"></see>
    /// </summary>
    let AverageHourlyEarnings = _prefix "AverageHourlyEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Hourly"></see>
    /// </summary>
    let Hourly = _prefix "Hourly"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageMonthlyEarnings"></see>
    /// </summary>
    let AverageMonthlyEarnings = _prefix "AverageMonthlyEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Monthly"></see>
    /// </summary>
    let Monthly = _prefix "Monthly"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageWeeklyEarnings"></see>
    /// </summary>
    let AverageWeeklyEarnings = _prefix "AverageWeeklyEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Weekly"></see>
    /// </summary>
    let Weekly = _prefix "Weekly"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborEnergyMaterialsMultifactorProductivity"></see>
    /// </summary>
    let CapitalLaborEnergyMaterialsMultifactorProductivity =
        _prefix "CapitalLaborEnergyMaterialsMultifactorProductivity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Productivity"></see>
    /// </summary>
    let Productivity = _prefix "Productivity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborMultifactorProductivityValueAdded"></see>
    /// </summary>
    let CapitalLaborMultifactorProductivityValueAdded =
        _prefix "CapitalLaborMultifactorProductivityValueAdded"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalProductivityValueAdded"></see>
    /// </summary>
    let CapitalProductivityValueAdded = _prefix "CapitalProductivityValueAdded"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Civilian"></see>
    /// </summary>
    let Civilian = _prefix "Civilian"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForce"></see>
    /// </summary>
    let CivilianLaborForce = _prefix "CivilianLaborForce"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPopulation"></see>
    /// </summary>
    let CivilianNonInstitutionalPopulation =
        _prefix "CivilianNonInstitutionalPopulation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PopulationNotInLaborForce"></see>
    /// </summary>
    let PopulationNotInLaborForce = _prefix "PopulationNotInLaborForce"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForceParticipationRate"></see>
    /// </summary>
    let CivilianLaborForceParticipationRate =
        _prefix "CivilianLaborForceParticipationRate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasBaselinePopulation"></see>
    /// </summary>
    let hasBaselinePopulation = _prefix "hasBaselinePopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasComparisonPopulation"></see>
    /// </summary>
    let hasComparisonPopulation = _prefix "hasComparisonPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPerson"></see>
    /// </summary>
    let CivilianNonInstitutionalPerson = _prefix "CivilianNonInstitutionalPerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalPerson"></see>
    /// </summary>
    let InstitutionalPerson = _prefix "InstitutionalPerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CombinedStatisticalArea"></see>
    /// </summary>
    let CombinedStatisticalArea = _prefix "CombinedStatisticalArea"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GovernmentSpecifiedStatisticalArea"></see>
    /// </summary>
    let GovernmentSpecifiedStatisticalArea =
        _prefix "GovernmentSpecifiedStatisticalArea"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ConsumerPriceIndex"></see>
    /// </summary>
    let ConsumerPriceIndex = _prefix "ConsumerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasket"></see>
    /// </summary>
    let FixedBasket = _prefix "FixedBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmploymentPopulationRatio"></see>
    /// </summary>
    let EmploymentPopulationRatio = _prefix "EmploymentPopulationRatio"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GrossDomesticProduct"></see>
    /// </summary>
    let GrossDomesticProduct = _prefix "GrossDomesticProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InflationRate"></see>
    /// </summary>
    let InflationRate = _prefix "InflationRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemploymentRate"></see>
    /// </summary>
    let UnemploymentRate = _prefix "UnemploymentRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/DiscouragedWorkerPopulation"></see>
    /// </summary>
    let DiscouragedWorkerPopulation = _prefix "DiscouragedWorkerPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MarginallyAttachedPopulation"></see>
    /// </summary>
    let MarginallyAttachedPopulation = _prefix "MarginallyAttachedPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/isSeasonallyAdjusted"></see>
    /// </summary>
    let isSeasonallyAdjusted = _prefix "isSeasonallyAdjusted"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasSeriesOrigin"></see>
    /// </summary>
    let hasSeriesOrigin = _prefix "hasSeriesOrigin"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulation"></see>
    /// </summary>
    let EmployedPopulation = _prefix "EmployedPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTime"></see>
    /// </summary>
    let EmployedPopulationPartTime = _prefix "EmployedPopulationPartTime"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForEconomicReasons"></see>
    /// </summary>
    let EmployedPopulationPartTimeForEconomicReasons =
        _prefix "EmployedPopulationPartTimeForEconomicReasons"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulation"></see>
    /// </summary>
    let UnderemployedPopulation = _prefix "UnderemployedPopulation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForNonEconomicReasons"></see>
    /// </summary>
    let EmployedPopulationPartTimeForNonEconomicReasons =
        _prefix "EmployedPopulationPartTimeForNonEconomicReasons"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationTemporarilyNotAtWork"></see>
    /// </summary>
    let EmployedPopulationTemporarilyNotAtWork =
        _prefix "EmployedPopulationTemporarilyNotAtWork"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Enterprise"></see>
    /// </summary>
    let Enterprise = _prefix "Enterprise"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalUnit"></see>
    /// </summary>
    let InstitutionalUnit = _prefix "InstitutionalUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Establishment"></see>
    /// </summary>
    let Establishment = _prefix "Establishment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EnterprisePopulation"></see>
    /// </summary>
    let EnterprisePopulation = _prefix "EnterprisePopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentEmployment"></see>
    /// </summary>
    let EstablishmentEmployment = _prefix "EstablishmentEmployment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentPopulation"></see>
    /// </summary>
    let EstablishmentPopulation = _prefix "EstablishmentPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketConstituent"></see>
    /// </summary>
    let FixedBasketConstituent = _prefix "FixedBasketConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketPopulation"></see>
    /// </summary>
    let FixedBasketPopulation = _prefix "FixedBasketPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Household"></see>
    /// </summary>
    let Household = _prefix "Household"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/HousingUnit"></see>
    /// </summary>
    let HousingUnit = _prefix "HousingUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InputProducerPriceIndex"></see>
    /// </summary>
    let InputProducerPriceIndex = _prefix "InputProducerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ProducerPriceIndex"></see>
    /// </summary>
    let ProducerPriceIndex = _prefix "ProducerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityGrossOutput"></see>
    /// </summary>
    let LaborProductivityGrossOutput = _prefix "LaborProductivityGrossOutput"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityValueAdded"></see>
    /// </summary>
    let LaborProductivityValueAdded = _prefix "LaborProductivityValueAdded"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MetropolitanStatisticalArea"></see>
    /// </summary>
    let MetropolitanStatisticalArea = _prefix "MetropolitanStatisticalArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MicropolitanStatisticalArea"></see>
    /// </summary>
    let MicropolitanStatisticalArea = _prefix "MicropolitanStatisticalArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MilitaryPerson"></see>
    /// </summary>
    let MilitaryPerson = _prefix "MilitaryPerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/OutputProducerPriceIndex"></see>
    /// </summary>
    let OutputProducerPriceIndex = _prefix "OutputProducerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PersonalConsumptionExpenditures"></see>
    /// </summary>
    let PersonalConsumptionExpenditures = _prefix "PersonalConsumptionExpenditures"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/StatisticalInformationPublisher"></see>
    /// </summary>
    let StatisticalInformationPublisher = _prefix "StatisticalInformationPublisher"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UltimateConsumer"></see>
    /// </summary>
    let UltimateConsumer = _prefix "UltimateConsumer"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulationWithRespectToOccupation"></see>
    /// </summary>
    let UnderemployedPopulationWithRespectToOccupation =
        _prefix "UnderemployedPopulationWithRespectToOccupation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderutilizedPopulation"></see>
    /// </summary>
    let UnderutilizedPopulation = _prefix "UnderutilizedPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemployedPopulation"></see>
    /// </summary>
    let UnemployedPopulation = _prefix "UnemployedPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasDurationOfUnemployment"></see>
    /// </summary>
    let hasDurationOfUnemployment = _prefix "hasDurationOfUnemployment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ValueAddedProducerPriceIndex"></see>
    /// </summary>
    let ValueAddedProducerPriceIndex = _prefix "ValueAddedProducerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/excludesEnergyAndFood"></see>
    /// </summary>
    let excludesEnergyAndFood = _prefix "excludesEnergyAndFood"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasIndicatorValue"></see>
    /// </summary>
    let hasIndicatorValue = _prefix "hasIndicatorValue"
