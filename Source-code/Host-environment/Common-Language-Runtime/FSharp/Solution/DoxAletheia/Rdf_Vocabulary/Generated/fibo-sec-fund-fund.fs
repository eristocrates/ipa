namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.Funds.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_fund_fund =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/AlignedCommunityInvestmentFund"></see>
    /// </summary>
    let AlignedCommunityInvestmentFund =
        Namespaced_IRI.parse _namespace_name "AlignedCommunityInvestmentFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CommunityInvestmentFund"></see>
    /// </summary>
    let CommunityInvestmentFund =
        Namespaced_IRI.parse _namespace_name "CommunityInvestmentFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ClosedEndInvestment"></see>
    /// </summary>
    let ClosedEndInvestment =
        Namespaced_IRI.parse _namespace_name "ClosedEndInvestment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isOpenEnded"></see>
    /// </summary>
    let isOpenEnded =
        Namespaced_IRI.parse _namespace_name "isOpenEnded" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CollectiveInvestmentVehicle"></see>
    /// </summary>
    let CollectiveInvestmentVehicle =
        Namespaced_IRI.parse _namespace_name "CollectiveInvestmentVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/DiversifiedCommunityInvestmentFund"></see>
    /// </summary>
    let DiversifiedCommunityInvestmentFund =
        Namespaced_IRI.parse _namespace_name "DiversifiedCommunityInvestmentFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ExchangeTradedFund"></see>
    /// </summary>
    let ExchangeTradedFund =
        Namespaced_IRI.parse _namespace_name "ExchangeTradedFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/OpenEndInvestment"></see>
    /// </summary>
    let OpenEndInvestment =
        Namespaced_IRI.parse _namespace_name "OpenEndInvestment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundAdministrator"></see>
    /// </summary>
    let FundAdministrator =
        Namespaced_IRI.parse _namespace_name "FundAdministrator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundContract"></see>
    /// </summary>
    let FundContract =
        Namespaced_IRI.parse _namespace_name "FundContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolder"></see>
    /// </summary>
    let FundHolder = Namespaced_IRI.parse _namespace_name "FundHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolding"></see>
    /// </summary>
    let FundHolding =
        Namespaced_IRI.parse _namespace_name "FundHolding" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundUnit"></see>
    /// </summary>
    let FundUnit = Namespaced_IRI.parse _namespace_name "FundUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundManager"></see>
    /// </summary>
    let FundManager =
        Namespaced_IRI.parse _namespace_name "FundManager" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundOfFunds"></see>
    /// </summary>
    let FundOfFunds =
        Namespaced_IRI.parse _namespace_name "FundOfFunds" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasSubFund"></see>
    /// </summary>
    let hasSubFund = Namespaced_IRI.parse _namespace_name "hasSubFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundPosition"></see>
    /// </summary>
    let FundPosition =
        Namespaced_IRI.parse _namespace_name "FundPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/HedgeFund"></see>
    /// </summary>
    let HedgeFund = Namespaced_IRI.parse _namespace_name "HedgeFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/LegalFundStructure"></see>
    /// </summary>
    let LegalFundStructure =
        Namespaced_IRI.parse _namespace_name "LegalFundStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/MutualFund"></see>
    /// </summary>
    let MutualFund = Namespaced_IRI.parse _namespace_name "MutualFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonTradableFundUnit"></see>
    /// </summary>
    let NonTradableFundUnit =
        Namespaced_IRI.parse _namespace_name "NonTradableFundUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/TradableFundUnit"></see>
    /// </summary>
    let TradableFundUnit =
        Namespaced_IRI.parse _namespace_name "TradableFundUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonprofitFund"></see>
    /// </summary>
    let NonprofitFund =
        Namespaced_IRI.parse _namespace_name "NonprofitFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PensionFund"></see>
    /// </summary>
    let PensionFund =
        Namespaced_IRI.parse _namespace_name "PensionFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateCreditFund"></see>
    /// </summary>
    let PrivateCreditFund =
        Namespaced_IRI.parse _namespace_name "PrivateCreditFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateEquityFund"></see>
    /// </summary>
    let PrivateEquityFund =
        Namespaced_IRI.parse _namespace_name "PrivateEquityFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/RealEstateInvestmentTrust"></see>
    /// </summary>
    let RealEstateInvestmentTrust =
        Namespaced_IRI.parse _namespace_name "RealEstateInvestmentTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasLegalStructure"></see>
    /// </summary>
    let hasLegalStructure =
        Namespaced_IRI.parse _namespace_name "hasLegalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/SovereignWealthFund"></see>
    /// </summary>
    let SovereignWealthFund =
        Namespaced_IRI.parse _namespace_name "SovereignWealthFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitTrust"></see>
    /// </summary>
    let UnitTrust = Namespaced_IRI.parse _namespace_name "UnitTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitizedFund"></see>
    /// </summary>
    let UnitizedFund =
        Namespaced_IRI.parse _namespace_name "UnitizedFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isPrivate"></see>
    /// </summary>
    let isPrivate = Namespaced_IRI.parse _namespace_name "isPrivate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isSubFundOf"></see>
    /// </summary>
    let isSubFundOf =
        Namespaced_IRI.parse _namespace_name "isSubFundOf" |> NamespacedName
