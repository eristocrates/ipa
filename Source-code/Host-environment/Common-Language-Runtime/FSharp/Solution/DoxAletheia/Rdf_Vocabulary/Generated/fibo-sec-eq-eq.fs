namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.EquityInstruments.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_eq_eq =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Share"></see>
    /// </summary>
    let Share = Namespaced_IRI.parse _namespace_name "Share" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AdjustableRateDividend"></see>
    /// </summary>
    let AdjustableRateDividend =
        Namespaced_IRI.parse _namespace_name "AdjustableRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredDividend"></see>
    /// </summary>
    let PreferredDividend =
        Namespaced_IRI.parse _namespace_name "PreferredDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAdjustableDividendRate"></see>
    /// </summary>
    let hasAdjustableDividendRate =
        Namespaced_IRI.parse _namespace_name "hasAdjustableDividendRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AuctionRateDividend"></see>
    /// </summary>
    let AuctionRateDividend =
        Namespaced_IRI.parse _namespace_name "AuctionRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CommonShare"></see>
    /// </summary>
    let CommonShare =
        Namespaced_IRI.parse _namespace_name "CommonShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividend"></see>
    /// </summary>
    let hasDividend =
        Namespaced_IRI.parse _namespace_name "hasDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/OrdinaryDividend"></see>
    /// </summary>
    let OrdinaryDividend =
        Namespaced_IRI.parse _namespace_name "OrdinaryDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShare"></see>
    /// </summary>
    let PreferredShare =
        Namespaced_IRI.parse _namespace_name "PreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertibleCommonShare"></see>
    /// </summary>
    let ConvertibleCommonShare =
        Namespaced_IRI.parse _namespace_name "ConvertibleCommonShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertiblePreferredShare"></see>
    /// </summary>
    let ConvertiblePreferredShare =
        Namespaced_IRI.parse _namespace_name "ConvertiblePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CumulativePreferredShare"></see>
    /// </summary>
    let CumulativePreferredShare =
        Namespaced_IRI.parse _namespace_name "CumulativePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Custodian"></see>
    /// </summary>
    let Custodian = Namespaced_IRI.parse _namespace_name "Custodian" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByCashPayment"></see>
    /// </summary>
    let DistributionByCashPayment =
        Namespaced_IRI.parse _namespace_name "DistributionByCashPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendDistributionMethod"></see>
    /// </summary>
    let DividendDistributionMethod =
        Namespaced_IRI.parse _namespace_name "DividendDistributionMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByReinvestment"></see>
    /// </summary>
    let DistributionByReinvestment =
        Namespaced_IRI.parse _namespace_name "DistributionByReinvestment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Dividend"></see>
    /// </summary>
    let Dividend = Namespaced_IRI.parse _namespace_name "Dividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDistributionMethod"></see>
    /// </summary>
    let hasDistributionMethod =
        Namespaced_IRI.parse _namespace_name "hasDistributionMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendSchedule"></see>
    /// </summary>
    let DividendSchedule =
        Namespaced_IRI.parse _namespace_name "DividendSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EnhancedVotingShare"></see>
    /// </summary>
    let EnhancedVotingShare =
        Namespaced_IRI.parse _namespace_name "EnhancedVotingShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersNumberOfVotesPerShare"></see>
    /// </summary>
    let confersNumberOfVotesPerShare =
        Namespaced_IRI.parse _namespace_name "confersNumberOfVotesPerShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityConversionTerms"></see>
    /// </summary>
    let EquityConversionTerms =
        Namespaced_IRI.parse _namespace_name "EquityConversionTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/specifiesConversionDate"></see>
    /// </summary>
    let specifiesConversionDate =
        Namespaced_IRI.parse _namespace_name "specifiesConversionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityPosition"></see>
    /// </summary>
    let EquityPosition =
        Namespaced_IRI.parse _namespace_name "EquityPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvision"></see>
    /// </summary>
    let EquityRedemptionProvision =
        Namespaced_IRI.parse _namespace_name "EquityRedemptionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasMinimumRedemptionPrice"></see>
    /// </summary>
    let hasMinimumRedemptionPrice =
        Namespaced_IRI.parse _namespace_name "hasMinimumRedemptionPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRedemptionPremium"></see>
    /// </summary>
    let hasRedemptionPremium =
        Namespaced_IRI.parse _namespace_name "hasRedemptionPremium" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasEarliestRedemptionDate"></see>
    /// </summary>
    let hasEarliestRedemptionDate =
        Namespaced_IRI.parse _namespace_name "hasEarliestRedemptionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableRedemptionDate"></see>
    /// </summary>
    let hasExtendableRedemptionDate =
        Namespaced_IRI.parse _namespace_name "hasExtendableRedemptionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtIssuerOption"></see>
    /// </summary>
    let isRedeemableAtIssuerOption =
        Namespaced_IRI.parse _namespace_name "isRedeemableAtIssuerOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtShareholderOption"></see>
    /// </summary>
    let isRedeemableAtShareholderOption =
        Namespaced_IRI.parse _namespace_name "isRedeemableAtShareholderOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvisionWithExtendableRedemptionDate"></see>
    /// </summary>
    let EquityRedemptionProvisionWithExtendableRedemptionDate =
        Namespaced_IRI.parse _namespace_name "EquityRedemptionProvisionWithExtendableRedemptionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExchangeablePreferredShare"></see>
    /// </summary>
    let ExchangeablePreferredShare =
        Namespaced_IRI.parse _namespace_name "ExchangeablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExtendablePreferredShare"></see>
    /// </summary>
    let ExtendablePreferredShare =
        Namespaced_IRI.parse _namespace_name "ExtendablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FixedRateDividend"></see>
    /// </summary>
    let FixedRateDividend =
        Namespaced_IRI.parse _namespace_name "FixedRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFixedDividendRate"></see>
    /// </summary>
    let hasFixedDividendRate =
        Namespaced_IRI.parse _namespace_name "hasFixedDividendRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShare"></see>
    /// </summary>
    let FullyPaidShare =
        Namespaced_IRI.parse _namespace_name "FullyPaidShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharePaymentStatus"></see>
    /// </summary>
    let hasSharePaymentStatus =
        Namespaced_IRI.parse _namespace_name "hasSharePaymentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShareStatus"></see>
    /// </summary>
    let FullyPaidShareStatus =
        Namespaced_IRI.parse _namespace_name "FullyPaidShareStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SharePaymentStatus"></see>
    /// </summary>
    let SharePaymentStatus =
        Namespaced_IRI.parse _namespace_name "SharePaymentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/HardRetractablePreferredShare"></see>
    /// </summary>
    let HardRetractablePreferredShare =
        Namespaced_IRI.parse _namespace_name "HardRetractablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShare"></see>
    /// </summary>
    let RetractablePreferredShare =
        Namespaced_IRI.parse _namespace_name "RetractablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SoftRetractablePreferredShare"></see>
    /// </summary>
    let SoftRetractablePreferredShare =
        Namespaced_IRI.parse _namespace_name "SoftRetractablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/LimitedPartnershipUnit"></see>
    /// </summary>
    let LimitedPartnershipUnit =
        Namespaced_IRI.parse _namespace_name "LimitedPartnershipUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ListedShare"></see>
    /// </summary>
    let ListedShare =
        Namespaced_IRI.parse _namespace_name "ListedShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShare"></see>
    /// </summary>
    let NilPaidShare =
        Namespaced_IRI.parse _namespace_name "NilPaidShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShareStatus"></see>
    /// </summary>
    let NilPaidShareStatus =
        Namespaced_IRI.parse _namespace_name "NilPaidShareStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShareStatus"></see>
    /// </summary>
    let PartiallyPaidShareStatus =
        Namespaced_IRI.parse _namespace_name "PartiallyPaidShareStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonCumulativePreferredShare"></see>
    /// </summary>
    let NonCumulativePreferredShare =
        Namespaced_IRI.parse _namespace_name "NonCumulativePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonParticipatingPreferredShare"></see>
    /// </summary>
    let NonParticipatingPreferredShare =
        Namespaced_IRI.parse _namespace_name "NonParticipatingPreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ParticipatingPreferredShare"></see>
    /// </summary>
    let ParticipatingPreferredShare =
        Namespaced_IRI.parse _namespace_name "ParticipatingPreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonVotingShare"></see>
    /// </summary>
    let NonVotingShare =
        Namespaced_IRI.parse _namespace_name "NonVotingShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShare"></see>
    /// </summary>
    let PartiallyPaidShare =
        Namespaced_IRI.parse _namespace_name "PartiallyPaidShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PerpetualPreferredShare"></see>
    /// </summary>
    let PerpetualPreferredShare =
        Namespaced_IRI.parse _namespace_name "PerpetualPreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedMaturityDate"></see>
    /// </summary>
    let PreferredShareWithFixedMaturityDate =
        Namespaced_IRI.parse _namespace_name "PreferredShareWithFixedMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrecedenceRight"></see>
    /// </summary>
    let PrecedenceRight =
        Namespaced_IRI.parse _namespace_name "PrecedenceRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendGracePeriod"></see>
    /// </summary>
    let hasDividendGracePeriod =
        Namespaced_IRI.parse _namespace_name "hasDividendGracePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isSeniorTo"></see>
    /// </summary>
    let isSeniorTo = Namespaced_IRI.parse _namespace_name "isSeniorTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAdjustableRateDividend"></see>
    /// </summary>
    let PreferredShareWithAdjustableRateDividend =
        Namespaced_IRI.parse _namespace_name "PreferredShareWithAdjustableRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedRateDividend"></see>
    /// </summary>
    let PreferredShareWithFixedRateDividend =
        Namespaced_IRI.parse _namespace_name "PreferredShareWithFixedRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAuctionRateDividend"></see>
    /// </summary>
    let PreferredShareWithAuctionRateDividend =
        Namespaced_IRI.parse _namespace_name "PreferredShareWithAuctionRateDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PricePerShare"></see>
    /// </summary>
    let PricePerShare =
        Namespaced_IRI.parse _namespace_name "PricePerShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrivatelyHeldShare"></see>
    /// </summary>
    let PrivatelyHeldShare =
        Namespaced_IRI.parse _namespace_name "PrivatelyHeldShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/QualifiedDividend"></see>
    /// </summary>
    let QualifiedDividend =
        Namespaced_IRI.parse _namespace_name "QualifiedDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShare"></see>
    /// </summary>
    let RedeemablePreferredShare =
        Namespaced_IRI.parse _namespace_name "RedeemablePreferredShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableMaturityDate"></see>
    /// </summary>
    let RedeemablePreferredShareWithExtendableMaturityDate =
        Namespaced_IRI.parse _namespace_name "RedeemablePreferredShareWithExtendableMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableMaturityDate"></see>
    /// </summary>
    let hasExtendableMaturityDate =
        Namespaced_IRI.parse _namespace_name "hasExtendableMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableRedemptionDate"></see>
    /// </summary>
    let RedeemablePreferredShareWithExtendableRedemptionDate =
        Namespaced_IRI.parse _namespace_name "RedeemablePreferredShareWithExtendableRedemptionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedShare"></see>
    /// </summary>
    let RestrictedShare =
        Namespaced_IRI.parse _namespace_name "RestrictedShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/UnrestrictedShare"></see>
    /// </summary>
    let UnrestrictedShare =
        Namespaced_IRI.parse _namespace_name "UnrestrictedShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedVotingShare"></see>
    /// </summary>
    let RestrictedVotingShare =
        Namespaced_IRI.parse _namespace_name "RestrictedVotingShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableMaturityDate"></see>
    /// </summary>
    let RetractablePreferredShareWithExtendableMaturityDate =
        Namespaced_IRI.parse _namespace_name "RetractablePreferredShareWithExtendableMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableRedemptionDate"></see>
    /// </summary>
    let RetractablePreferredShareWithExtendableRedemptionDate =
        Namespaced_IRI.parse _namespace_name "RetractablePreferredShareWithExtendableRedemptionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAvailableShares"></see>
    /// </summary>
    let hasAvailableShares =
        Namespaced_IRI.parse _namespace_name "hasAvailableShares" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFloatingStock"></see>
    /// </summary>
    let hasFloatingStock =
        Namespaced_IRI.parse _namespace_name "hasFloatingStock" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesIssued"></see>
    /// </summary>
    let hasSharesIssued =
        Namespaced_IRI.parse _namespace_name "hasSharesIssued" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesOutstanding"></see>
    /// </summary>
    let hasSharesOutstanding =
        Namespaced_IRI.parse _namespace_name "hasSharesOutstanding" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasTreasuryShares"></see>
    /// </summary>
    let hasTreasuryShares =
        Namespaced_IRI.parse _namespace_name "hasTreasuryShares" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasShareClass"></see>
    /// </summary>
    let hasShareClass =
        Namespaced_IRI.parse _namespace_name "hasShareClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasVotingRestriction"></see>
    /// </summary>
    let hasVotingRestriction =
        Namespaced_IRI.parse _namespace_name "hasVotingRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersOwnershipOf"></see>
    /// </summary>
    let confersOwnershipOf =
        Namespaced_IRI.parse _namespace_name "confersOwnershipOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareIssuer"></see>
    /// </summary>
    let ShareIssuer =
        Namespaced_IRI.parse _namespace_name "ShareIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareYield"></see>
    /// </summary>
    let ShareYield = Namespaced_IRI.parse _namespace_name "ShareYield" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SingleVotingShare"></see>
    /// </summary>
    let SingleVotingShare =
        Namespaced_IRI.parse _namespace_name "SingleVotingShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SpecialDividend"></see>
    /// </summary>
    let SpecialDividend =
        Namespaced_IRI.parse _namespace_name "SpecialDividend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VariableInterestEntityShare"></see>
    /// </summary>
    let VariableInterestEntityShare =
        Namespaced_IRI.parse _namespace_name "VariableInterestEntityShare" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VotingRight"></see>
    /// </summary>
    let VotingRight =
        Namespaced_IRI.parse _namespace_name "VotingRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendDeclarationDate"></see>
    /// </summary>
    let hasDividendDeclarationDate =
        Namespaced_IRI.parse _namespace_name "hasDividendDeclarationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExDividendDate"></see>
    /// </summary>
    let hasExDividendDate =
        Namespaced_IRI.parse _namespace_name "hasExDividendDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRecordDate"></see>
    /// </summary>
    let hasRecordDate =
        Namespaced_IRI.parse _namespace_name "hasRecordDate" |> NamespacedName
