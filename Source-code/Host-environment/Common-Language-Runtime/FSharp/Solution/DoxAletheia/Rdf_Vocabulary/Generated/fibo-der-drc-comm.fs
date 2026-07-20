namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CommoditiesContracts.slash

open DoxAletheia

module fibo_der_drc_comm =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/AgriculturalResource"></see>
    /// </summary>
    let AgriculturalResource = _prefix "AgriculturalResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BaseMetal"></see>
    /// </summary>
    let BaseMetal = _prefix "BaseMetal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Metal"></see>
    /// </summary>
    let Metal = _prefix "Metal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BasketOfCommodities"></see>
    /// </summary>
    let BasketOfCommodities = _prefix "BasketOfCommodities"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityBasketConstituent"></see>
    /// </summary>
    let CommodityBasketConstituent = _prefix "CommodityBasketConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Bullion"></see>
    /// </summary>
    let Bullion = _prefix "Bullion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasCommodityValueAsOfDate"></see>
    /// </summary>
    let hasCommodityValueAsOfDate = _prefix "hasCommodityValueAsOfDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivative"></see>
    /// </summary>
    let CommodityDerivative = _prefix "CommodityDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivativeUnderlier"></see>
    /// </summary>
    let CommodityDerivativeUnderlier = _prefix "CommodityDerivativeUnderlier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityForward"></see>
    /// </summary>
    let CommodityForward = _prefix "CommodityForward"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityFuture"></see>
    /// </summary>
    let CommodityFuture = _prefix "CommodityFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityIndex"></see>
    /// </summary>
    let CommodityIndex = _prefix "CommodityIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityOption"></see>
    /// </summary>
    let CommodityOption = _prefix "CommodityOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityReturnLeg"></see>
    /// </summary>
    let CommodityReturnLeg = _prefix "CommodityReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySpotContract"></see>
    /// </summary>
    let CommoditySpotContract = _prefix "CommoditySpotContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySwap"></see>
    /// </summary>
    let CommoditySwap = _prefix "CommoditySwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyResource"></see>
    /// </summary>
    let EnergyResource = _prefix "EnergyResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyTransmissionRights"></see>
    /// </summary>
    let EnergyTransmissionRights = _prefix "EnergyTransmissionRights"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnvironmentalResource"></see>
    /// </summary>
    let EnvironmentalResource = _prefix "EnvironmentalResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ExtractionResource"></see>
    /// </summary>
    let ExtractionResource = _prefix "ExtractionResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FertilizerResource"></see>
    /// </summary>
    let FertilizerResource = _prefix "FertilizerResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FreightResource"></see>
    /// </summary>
    let FreightResource = _prefix "FreightResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GasCommodity"></see>
    /// </summary>
    let GasCommodity = _prefix "GasCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GeneratedResource"></see>
    /// </summary>
    let GeneratedResource = _prefix "GeneratedResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GrainCommodity"></see>
    /// </summary>
    let GrainCommodity = _prefix "GrainCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/IndustrialResource"></see>
    /// </summary>
    let IndustrialResource = _prefix "IndustrialResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/MeatCommodity"></see>
    /// </summary>
    let MeatCommodity = _prefix "MeatCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilCommodity"></see>
    /// </summary>
    let OilCommodity = _prefix "OilCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasGrade"></see>
    /// </summary>
    let hasGrade = _prefix "hasGrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilGrade"></see>
    /// </summary>
    let OilGrade = _prefix "OilGrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PaperResource"></see>
    /// </summary>
    let PaperResource = _prefix "PaperResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PolypropyleneResource"></see>
    /// </summary>
    let PolypropyleneResource = _prefix "PolypropyleneResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ServiceResource"></see>
    /// </summary>
    let ServiceResource = _prefix "ServiceResource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/WeatherDerivative"></see>
    /// </summary>
    let WeatherDerivative = _prefix "WeatherDerivative"
