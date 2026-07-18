namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.EconomicIndicators.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ei_ei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageDailyEarnings"></see>
    /// </summary>
    let AverageDailyEarnings =
        Namespaced_IRI.parse _namespace_name "AverageDailyEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageEarnings"></see>
    /// </summary>
    let AverageEarnings =
        Namespaced_IRI.parse _namespace_name "AverageEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Daily"></see>
    /// </summary>
    let Daily = Namespaced_IRI.parse _namespace_name "Daily" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EconomicIndicator"></see>
    /// </summary>
    let EconomicIndicator =
        Namespaced_IRI.parse _namespace_name "EconomicIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageHourlyEarnings"></see>
    /// </summary>
    let AverageHourlyEarnings =
        Namespaced_IRI.parse _namespace_name "AverageHourlyEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Hourly"></see>
    /// </summary>
    let Hourly = Namespaced_IRI.parse _namespace_name "Hourly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageMonthlyEarnings"></see>
    /// </summary>
    let AverageMonthlyEarnings =
        Namespaced_IRI.parse _namespace_name "AverageMonthlyEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Monthly"></see>
    /// </summary>
    let Monthly = Namespaced_IRI.parse _namespace_name "Monthly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageWeeklyEarnings"></see>
    /// </summary>
    let AverageWeeklyEarnings =
        Namespaced_IRI.parse _namespace_name "AverageWeeklyEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Weekly"></see>
    /// </summary>
    let Weekly = Namespaced_IRI.parse _namespace_name "Weekly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborEnergyMaterialsMultifactorProductivity"></see>
    /// </summary>
    let CapitalLaborEnergyMaterialsMultifactorProductivity =
        Namespaced_IRI.parse _namespace_name "CapitalLaborEnergyMaterialsMultifactorProductivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Productivity"></see>
    /// </summary>
    let Productivity =
        Namespaced_IRI.parse _namespace_name "Productivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborMultifactorProductivityValueAdded"></see>
    /// </summary>
    let CapitalLaborMultifactorProductivityValueAdded =
        Namespaced_IRI.parse _namespace_name "CapitalLaborMultifactorProductivityValueAdded" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalProductivityValueAdded"></see>
    /// </summary>
    let CapitalProductivityValueAdded =
        Namespaced_IRI.parse _namespace_name "CapitalProductivityValueAdded" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Civilian"></see>
    /// </summary>
    let Civilian = Namespaced_IRI.parse _namespace_name "Civilian" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForce"></see>
    /// </summary>
    let CivilianLaborForce =
        Namespaced_IRI.parse _namespace_name "CivilianLaborForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPopulation"></see>
    /// </summary>
    let CivilianNonInstitutionalPopulation =
        Namespaced_IRI.parse _namespace_name "CivilianNonInstitutionalPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PopulationNotInLaborForce"></see>
    /// </summary>
    let PopulationNotInLaborForce =
        Namespaced_IRI.parse _namespace_name "PopulationNotInLaborForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForceParticipationRate"></see>
    /// </summary>
    let CivilianLaborForceParticipationRate =
        Namespaced_IRI.parse _namespace_name "CivilianLaborForceParticipationRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasBaselinePopulation"></see>
    /// </summary>
    let hasBaselinePopulation =
        Namespaced_IRI.parse _namespace_name "hasBaselinePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasComparisonPopulation"></see>
    /// </summary>
    let hasComparisonPopulation =
        Namespaced_IRI.parse _namespace_name "hasComparisonPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPerson"></see>
    /// </summary>
    let CivilianNonInstitutionalPerson =
        Namespaced_IRI.parse _namespace_name "CivilianNonInstitutionalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalPerson"></see>
    /// </summary>
    let InstitutionalPerson =
        Namespaced_IRI.parse _namespace_name "InstitutionalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CombinedStatisticalArea"></see>
    /// </summary>
    let CombinedStatisticalArea =
        Namespaced_IRI.parse _namespace_name "CombinedStatisticalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GovernmentSpecifiedStatisticalArea"></see>
    /// </summary>
    let GovernmentSpecifiedStatisticalArea =
        Namespaced_IRI.parse _namespace_name "GovernmentSpecifiedStatisticalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ConsumerPriceIndex"></see>
    /// </summary>
    let ConsumerPriceIndex =
        Namespaced_IRI.parse _namespace_name "ConsumerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasket"></see>
    /// </summary>
    let FixedBasket =
        Namespaced_IRI.parse _namespace_name "FixedBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmploymentPopulationRatio"></see>
    /// </summary>
    let EmploymentPopulationRatio =
        Namespaced_IRI.parse _namespace_name "EmploymentPopulationRatio" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GrossDomesticProduct"></see>
    /// </summary>
    let GrossDomesticProduct =
        Namespaced_IRI.parse _namespace_name "GrossDomesticProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InflationRate"></see>
    /// </summary>
    let InflationRate =
        Namespaced_IRI.parse _namespace_name "InflationRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemploymentRate"></see>
    /// </summary>
    let UnemploymentRate =
        Namespaced_IRI.parse _namespace_name "UnemploymentRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/DiscouragedWorkerPopulation"></see>
    /// </summary>
    let DiscouragedWorkerPopulation =
        Namespaced_IRI.parse _namespace_name "DiscouragedWorkerPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MarginallyAttachedPopulation"></see>
    /// </summary>
    let MarginallyAttachedPopulation =
        Namespaced_IRI.parse _namespace_name "MarginallyAttachedPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/isSeasonallyAdjusted"></see>
    /// </summary>
    let isSeasonallyAdjusted =
        Namespaced_IRI.parse _namespace_name "isSeasonallyAdjusted" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasSeriesOrigin"></see>
    /// </summary>
    let hasSeriesOrigin =
        Namespaced_IRI.parse _namespace_name "hasSeriesOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulation"></see>
    /// </summary>
    let EmployedPopulation =
        Namespaced_IRI.parse _namespace_name "EmployedPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTime"></see>
    /// </summary>
    let EmployedPopulationPartTime =
        Namespaced_IRI.parse _namespace_name "EmployedPopulationPartTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForEconomicReasons"></see>
    /// </summary>
    let EmployedPopulationPartTimeForEconomicReasons =
        Namespaced_IRI.parse _namespace_name "EmployedPopulationPartTimeForEconomicReasons" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulation"></see>
    /// </summary>
    let UnderemployedPopulation =
        Namespaced_IRI.parse _namespace_name "UnderemployedPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForNonEconomicReasons"></see>
    /// </summary>
    let EmployedPopulationPartTimeForNonEconomicReasons =
        Namespaced_IRI.parse _namespace_name "EmployedPopulationPartTimeForNonEconomicReasons" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationTemporarilyNotAtWork"></see>
    /// </summary>
    let EmployedPopulationTemporarilyNotAtWork =
        Namespaced_IRI.parse _namespace_name "EmployedPopulationTemporarilyNotAtWork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Enterprise"></see>
    /// </summary>
    let Enterprise = Namespaced_IRI.parse _namespace_name "Enterprise" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalUnit"></see>
    /// </summary>
    let InstitutionalUnit =
        Namespaced_IRI.parse _namespace_name "InstitutionalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Establishment"></see>
    /// </summary>
    let Establishment =
        Namespaced_IRI.parse _namespace_name "Establishment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EnterprisePopulation"></see>
    /// </summary>
    let EnterprisePopulation =
        Namespaced_IRI.parse _namespace_name "EnterprisePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentEmployment"></see>
    /// </summary>
    let EstablishmentEmployment =
        Namespaced_IRI.parse _namespace_name "EstablishmentEmployment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentPopulation"></see>
    /// </summary>
    let EstablishmentPopulation =
        Namespaced_IRI.parse _namespace_name "EstablishmentPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketConstituent"></see>
    /// </summary>
    let FixedBasketConstituent =
        Namespaced_IRI.parse _namespace_name "FixedBasketConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketPopulation"></see>
    /// </summary>
    let FixedBasketPopulation =
        Namespaced_IRI.parse _namespace_name "FixedBasketPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Household"></see>
    /// </summary>
    let Household = Namespaced_IRI.parse _namespace_name "Household" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/HousingUnit"></see>
    /// </summary>
    let HousingUnit =
        Namespaced_IRI.parse _namespace_name "HousingUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InputProducerPriceIndex"></see>
    /// </summary>
    let InputProducerPriceIndex =
        Namespaced_IRI.parse _namespace_name "InputProducerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ProducerPriceIndex"></see>
    /// </summary>
    let ProducerPriceIndex =
        Namespaced_IRI.parse _namespace_name "ProducerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityGrossOutput"></see>
    /// </summary>
    let LaborProductivityGrossOutput =
        Namespaced_IRI.parse _namespace_name "LaborProductivityGrossOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityValueAdded"></see>
    /// </summary>
    let LaborProductivityValueAdded =
        Namespaced_IRI.parse _namespace_name "LaborProductivityValueAdded" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MetropolitanStatisticalArea"></see>
    /// </summary>
    let MetropolitanStatisticalArea =
        Namespaced_IRI.parse _namespace_name "MetropolitanStatisticalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MicropolitanStatisticalArea"></see>
    /// </summary>
    let MicropolitanStatisticalArea =
        Namespaced_IRI.parse _namespace_name "MicropolitanStatisticalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MilitaryPerson"></see>
    /// </summary>
    let MilitaryPerson =
        Namespaced_IRI.parse _namespace_name "MilitaryPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/OutputProducerPriceIndex"></see>
    /// </summary>
    let OutputProducerPriceIndex =
        Namespaced_IRI.parse _namespace_name "OutputProducerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PersonalConsumptionExpenditures"></see>
    /// </summary>
    let PersonalConsumptionExpenditures =
        Namespaced_IRI.parse _namespace_name "PersonalConsumptionExpenditures" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/StatisticalInformationPublisher"></see>
    /// </summary>
    let StatisticalInformationPublisher =
        Namespaced_IRI.parse _namespace_name "StatisticalInformationPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UltimateConsumer"></see>
    /// </summary>
    let UltimateConsumer =
        Namespaced_IRI.parse _namespace_name "UltimateConsumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulationWithRespectToOccupation"></see>
    /// </summary>
    let UnderemployedPopulationWithRespectToOccupation =
        Namespaced_IRI.parse _namespace_name "UnderemployedPopulationWithRespectToOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderutilizedPopulation"></see>
    /// </summary>
    let UnderutilizedPopulation =
        Namespaced_IRI.parse _namespace_name "UnderutilizedPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemployedPopulation"></see>
    /// </summary>
    let UnemployedPopulation =
        Namespaced_IRI.parse _namespace_name "UnemployedPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasDurationOfUnemployment"></see>
    /// </summary>
    let hasDurationOfUnemployment =
        Namespaced_IRI.parse _namespace_name "hasDurationOfUnemployment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ValueAddedProducerPriceIndex"></see>
    /// </summary>
    let ValueAddedProducerPriceIndex =
        Namespaced_IRI.parse _namespace_name "ValueAddedProducerPriceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/excludesEnergyAndFood"></see>
    /// </summary>
    let excludesEnergyAndFood =
        Namespaced_IRI.parse _namespace_name "excludesEnergyAndFood" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasIndicatorValue"></see>
    /// </summary>
    let hasIndicatorValue =
        Namespaced_IRI.parse _namespace_name "hasIndicatorValue" |> NamespacedName
