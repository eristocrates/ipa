namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSTaxonomy.slash

open DoxAletheia

module fibo_actus_acv =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily"></see>
    /// </summary>
    let ACTUSCashFlowFamily = _prefix "ACTUSCashFlowFamily"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractTypesClassificationScheme"></see>
    /// </summary>
    let AlgorithmicContractTypesClassificationScheme =
        _prefix "AlgorithmicContractTypesClassificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-Basic"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-Basic`` = _prefix "ACTUSCashFlowFamily-Basic"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-Combined"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-Combined`` = _prefix "ACTUSCashFlowFamily-Combined"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashFlowFamily-CreditEnhancement"></see>
    /// </summary>
    let ``ACTUSCashFlowFamily-CreditEnhancement`` =
        _prefix "ACTUSCashFlowFamily-CreditEnhancement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory"></see>
    /// </summary>
    let ACTUSCashflowCategory = _prefix "ACTUSCashflowCategory"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Asymmetric"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Asymmetric`` =
        _prefix "ACTUSCashflowCategory-Asymmetric"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-CreditEnhancement"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-CreditEnhancement`` =
        _prefix "ACTUSCashflowCategory-CreditEnhancement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-FixedIncome"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-FixedIncome`` =
        _prefix "ACTUSCashflowCategory-FixedIncome"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Ownership"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Ownership`` = _prefix "ACTUSCashflowCategory-Ownership"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Securitization"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Securitization`` =
        _prefix "ACTUSCashflowCategory-Securitization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSCashflowCategory-Symmetric"></see>
    /// </summary>
    let ``ACTUSCashflowCategory-Symmetric`` = _prefix "ACTUSCashflowCategory-Symmetric"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType"></see>
    /// </summary>
    let ACTUSContractType = _prefix "ACTUSContractType"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/hasCoverageDescription"></see>
    /// </summary>
    let hasCoverageDescription = _prefix "hasCoverageDescription"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Annuity"></see>
    /// </summary>
    let ``ACTUSContractType-Annuity`` = _prefix "ACTUSContractType-Annuity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BondWithWarrant"></see>
    /// </summary>
    let ``ACTUSContractType-BondWithWarrant`` =
        _prefix "ACTUSContractType-BondWithWarrant"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BoundaryControlledSwitch"></see>
    /// </summary>
    let ``ACTUSContractType-BoundaryControlledSwitch`` =
        _prefix "ACTUSContractType-BoundaryControlledSwitch"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CallMoney"></see>
    /// </summary>
    let ``ACTUSContractType-CallMoney`` = _prefix "ACTUSContractType-CallMoney"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CapFloorOption"></see>
    /// </summary>
    let ``ACTUSContractType-CapFloorOption`` =
        _prefix "ACTUSContractType-CapFloorOption"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Cash"></see>
    /// </summary>
    let ``ACTUSContractType-Cash`` = _prefix "ACTUSContractType-Cash"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Collateral"></see>
    /// </summary>
    let ``ACTUSContractType-Collateral`` = _prefix "ACTUSContractType-Collateral"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Commodity"></see>
    /// </summary>
    let ``ACTUSContractType-Commodity`` = _prefix "ACTUSContractType-Commodity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ConvertibleNote"></see>
    /// </summary>
    let ``ACTUSContractType-ConvertibleNote`` =
        _prefix "ACTUSContractType-ConvertibleNote"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditDefaultSwap"></see>
    /// </summary>
    let ``ACTUSContractType-CreditDefaultSwap`` =
        _prefix "ACTUSContractType-CreditDefaultSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditLinkedNote"></see>
    /// </summary>
    let ``ACTUSContractType-CreditLinkedNote`` =
        _prefix "ACTUSContractType-CreditLinkedNote"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticAnnuity"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticAnnuity`` = _prefix "ACTUSContractType-ExoticAnnuity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticLinearAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticLinearAmortizer`` =
        _prefix "ACTUSContractType-ExoticLinearAmortizer"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticNegativeAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticNegativeAmortizer`` =
        _prefix "ACTUSContractType-ExoticNegativeAmortizer"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticOption"></see>
    /// </summary>
    let ``ACTUSContractType-ExoticOption`` = _prefix "ACTUSContractType-ExoticOption"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ForeignExchangeOutright"></see>
    /// </summary>
    let ``ACTUSContractType-ForeignExchangeOutright`` =
        _prefix "ACTUSContractType-ForeignExchangeOutright"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Future"></see>
    /// </summary>
    let ``ACTUSContractType-Future`` = _prefix "ACTUSContractType-Future"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Guarantee"></see>
    /// </summary>
    let ``ACTUSContractType-Guarantee`` = _prefix "ACTUSContractType-Guarantee"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-LinearAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-LinearAmortizer`` =
        _prefix "ACTUSContractType-LinearAmortizer"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Margining"></see>
    /// </summary>
    let ``ACTUSContractType-Margining`` = _prefix "ACTUSContractType-Margining"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-NegativeAmortizer"></see>
    /// </summary>
    let ``ACTUSContractType-NegativeAmortizer`` =
        _prefix "ACTUSContractType-NegativeAmortizer"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Option"></see>
    /// </summary>
    let ``ACTUSContractType-Option`` = _prefix "ACTUSContractType-Option"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PerpetualBond"></see>
    /// </summary>
    let ``ACTUSContractType-PerpetualBond`` = _prefix "ACTUSContractType-PerpetualBond"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PlainVanillaSwap"></see>
    /// </summary>
    let ``ACTUSContractType-PlainVanillaSwap`` =
        _prefix "ACTUSContractType-PlainVanillaSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PrincipalAtMaturity"></see>
    /// </summary>
    let ``ACTUSContractType-PrincipalAtMaturity`` =
        _prefix "ACTUSContractType-PrincipalAtMaturity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-RepurchaseAgreement"></see>
    /// </summary>
    let ``ACTUSContractType-RepurchaseAgreement`` =
        _prefix "ACTUSContractType-RepurchaseAgreement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationCreditRisk"></see>
    /// </summary>
    let ``ACTUSContractType-SecuritizationCreditRisk`` =
        _prefix "ACTUSContractType-SecuritizationCreditRisk"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationMarketRisk"></see>
    /// </summary>
    let ``ACTUSContractType-SecuritizationMarketRisk`` =
        _prefix "ACTUSContractType-SecuritizationMarketRisk"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Stock"></see>
    /// </summary>
    let ``ACTUSContractType-Stock`` = _prefix "ACTUSContractType-Stock"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Swap"></see>
    /// </summary>
    let ``ACTUSContractType-Swap`` = _prefix "ACTUSContractType-Swap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-TotalReturnSwap"></see>
    /// </summary>
    let ``ACTUSContractType-TotalReturnSwap`` =
        _prefix "ACTUSContractType-TotalReturnSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-UndefinedMaturityProfile"></see>
    /// </summary>
    let ``ACTUSContractType-UndefinedMaturityProfile`` =
        _prefix "ACTUSContractType-UndefinedMaturityProfile"
