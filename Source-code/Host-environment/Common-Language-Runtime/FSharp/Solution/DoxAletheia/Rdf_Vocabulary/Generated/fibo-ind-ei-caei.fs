namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.NorthAmericanIndicators.CAEconomicIndicators.slash

open DoxAletheia

module fibo_ind_ei_caei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianConsumerPriceIndex"></see>
    /// </summary>
    let CanadianConsumerPriceIndex = _prefix "CanadianConsumerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianStatisticsPublisher"></see>
    /// </summary>
    let CanadianStatisticsPublisher = _prefix "CanadianStatisticsPublisher"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/StatisticsCanada"></see>
    /// </summary>
    let StatisticsCanada = _prefix "StatisticsCanada"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianHouseholdsConsumersUniverse"></see>
    /// </summary>
    let CanadianHouseholdsConsumersUniverse =
        _prefix "CanadianHouseholdsConsumersUniverse"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianProducerPriceIndex"></see>
    /// </summary>
    let CanadianProducerPriceIndex = _prefix "CanadianProducerPriceIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/IndustrialProductsSector"></see>
    /// </summary>
    let IndustrialProductsSector = _prefix "IndustrialProductsSector"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/NewHousingSector"></see>
    /// </summary>
    let NewHousingSector = _prefix "NewHousingSector"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/RawMaterialsSector"></see>
    /// </summary>
    let RawMaterialsSector = _prefix "RawMaterialsSector"
