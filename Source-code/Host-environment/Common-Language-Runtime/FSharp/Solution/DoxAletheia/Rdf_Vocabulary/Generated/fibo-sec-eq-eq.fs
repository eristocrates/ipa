namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.EquityInstruments.slash

open DoxAletheia

module fibo_sec_eq_eq =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Share"></see>
    /// </summary>
    let Share = _prefix "Share"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AdjustableRateDividend"></see>
    /// </summary>
    let AdjustableRateDividend = _prefix "AdjustableRateDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredDividend"></see>
    /// </summary>
    let PreferredDividend = _prefix "PreferredDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAdjustableDividendRate"></see>
    /// </summary>
    let hasAdjustableDividendRate = _prefix "hasAdjustableDividendRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AuctionRateDividend"></see>
    /// </summary>
    let AuctionRateDividend = _prefix "AuctionRateDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CommonShare"></see>
    /// </summary>
    let CommonShare = _prefix "CommonShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividend"></see>
    /// </summary>
    let hasDividend = _prefix "hasDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/OrdinaryDividend"></see>
    /// </summary>
    let OrdinaryDividend = _prefix "OrdinaryDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShare"></see>
    /// </summary>
    let PreferredShare = _prefix "PreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertibleCommonShare"></see>
    /// </summary>
    let ConvertibleCommonShare = _prefix "ConvertibleCommonShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertiblePreferredShare"></see>
    /// </summary>
    let ConvertiblePreferredShare = _prefix "ConvertiblePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CumulativePreferredShare"></see>
    /// </summary>
    let CumulativePreferredShare = _prefix "CumulativePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Custodian"></see>
    /// </summary>
    let Custodian = _prefix "Custodian"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByCashPayment"></see>
    /// </summary>
    let DistributionByCashPayment = _prefix "DistributionByCashPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendDistributionMethod"></see>
    /// </summary>
    let DividendDistributionMethod = _prefix "DividendDistributionMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByReinvestment"></see>
    /// </summary>
    let DistributionByReinvestment = _prefix "DistributionByReinvestment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Dividend"></see>
    /// </summary>
    let Dividend = _prefix "Dividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDistributionMethod"></see>
    /// </summary>
    let hasDistributionMethod = _prefix "hasDistributionMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendSchedule"></see>
    /// </summary>
    let DividendSchedule = _prefix "DividendSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EnhancedVotingShare"></see>
    /// </summary>
    let EnhancedVotingShare = _prefix "EnhancedVotingShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersNumberOfVotesPerShare"></see>
    /// </summary>
    let confersNumberOfVotesPerShare = _prefix "confersNumberOfVotesPerShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityConversionTerms"></see>
    /// </summary>
    let EquityConversionTerms = _prefix "EquityConversionTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/specifiesConversionDate"></see>
    /// </summary>
    let specifiesConversionDate = _prefix "specifiesConversionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityPosition"></see>
    /// </summary>
    let EquityPosition = _prefix "EquityPosition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvision"></see>
    /// </summary>
    let EquityRedemptionProvision = _prefix "EquityRedemptionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasMinimumRedemptionPrice"></see>
    /// </summary>
    let hasMinimumRedemptionPrice = _prefix "hasMinimumRedemptionPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRedemptionPremium"></see>
    /// </summary>
    let hasRedemptionPremium = _prefix "hasRedemptionPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasEarliestRedemptionDate"></see>
    /// </summary>
    let hasEarliestRedemptionDate = _prefix "hasEarliestRedemptionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableRedemptionDate"></see>
    /// </summary>
    let hasExtendableRedemptionDate = _prefix "hasExtendableRedemptionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtIssuerOption"></see>
    /// </summary>
    let isRedeemableAtIssuerOption = _prefix "isRedeemableAtIssuerOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtShareholderOption"></see>
    /// </summary>
    let isRedeemableAtShareholderOption = _prefix "isRedeemableAtShareholderOption"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvisionWithExtendableRedemptionDate"></see>
    /// </summary>
    let EquityRedemptionProvisionWithExtendableRedemptionDate =
        _prefix "EquityRedemptionProvisionWithExtendableRedemptionDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExchangeablePreferredShare"></see>
    /// </summary>
    let ExchangeablePreferredShare = _prefix "ExchangeablePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExtendablePreferredShare"></see>
    /// </summary>
    let ExtendablePreferredShare = _prefix "ExtendablePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FixedRateDividend"></see>
    /// </summary>
    let FixedRateDividend = _prefix "FixedRateDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFixedDividendRate"></see>
    /// </summary>
    let hasFixedDividendRate = _prefix "hasFixedDividendRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShare"></see>
    /// </summary>
    let FullyPaidShare = _prefix "FullyPaidShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharePaymentStatus"></see>
    /// </summary>
    let hasSharePaymentStatus = _prefix "hasSharePaymentStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShareStatus"></see>
    /// </summary>
    let FullyPaidShareStatus = _prefix "FullyPaidShareStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SharePaymentStatus"></see>
    /// </summary>
    let SharePaymentStatus = _prefix "SharePaymentStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/HardRetractablePreferredShare"></see>
    /// </summary>
    let HardRetractablePreferredShare = _prefix "HardRetractablePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShare"></see>
    /// </summary>
    let RetractablePreferredShare = _prefix "RetractablePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SoftRetractablePreferredShare"></see>
    /// </summary>
    let SoftRetractablePreferredShare = _prefix "SoftRetractablePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/LimitedPartnershipUnit"></see>
    /// </summary>
    let LimitedPartnershipUnit = _prefix "LimitedPartnershipUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ListedShare"></see>
    /// </summary>
    let ListedShare = _prefix "ListedShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShare"></see>
    /// </summary>
    let NilPaidShare = _prefix "NilPaidShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShareStatus"></see>
    /// </summary>
    let NilPaidShareStatus = _prefix "NilPaidShareStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShareStatus"></see>
    /// </summary>
    let PartiallyPaidShareStatus = _prefix "PartiallyPaidShareStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonCumulativePreferredShare"></see>
    /// </summary>
    let NonCumulativePreferredShare = _prefix "NonCumulativePreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonParticipatingPreferredShare"></see>
    /// </summary>
    let NonParticipatingPreferredShare = _prefix "NonParticipatingPreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ParticipatingPreferredShare"></see>
    /// </summary>
    let ParticipatingPreferredShare = _prefix "ParticipatingPreferredShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonVotingShare"></see>
    /// </summary>
    let NonVotingShare = _prefix "NonVotingShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShare"></see>
    /// </summary>
    let PartiallyPaidShare = _prefix "PartiallyPaidShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PerpetualPreferredShare"></see>
    /// </summary>
    let PerpetualPreferredShare = _prefix "PerpetualPreferredShare"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedMaturityDate"></see>
    /// </summary>
    let PreferredShareWithFixedMaturityDate =
        _prefix "PreferredShareWithFixedMaturityDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrecedenceRight"></see>
    /// </summary>
    let PrecedenceRight = _prefix "PrecedenceRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendGracePeriod"></see>
    /// </summary>
    let hasDividendGracePeriod = _prefix "hasDividendGracePeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isSeniorTo"></see>
    /// </summary>
    let isSeniorTo = _prefix "isSeniorTo"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAdjustableRateDividend"></see>
    /// </summary>
    let PreferredShareWithAdjustableRateDividend =
        _prefix "PreferredShareWithAdjustableRateDividend"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedRateDividend"></see>
    /// </summary>
    let PreferredShareWithFixedRateDividend =
        _prefix "PreferredShareWithFixedRateDividend"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAuctionRateDividend"></see>
    /// </summary>
    let PreferredShareWithAuctionRateDividend =
        _prefix "PreferredShareWithAuctionRateDividend"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PricePerShare"></see>
    /// </summary>
    let PricePerShare = _prefix "PricePerShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrivatelyHeldShare"></see>
    /// </summary>
    let PrivatelyHeldShare = _prefix "PrivatelyHeldShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/QualifiedDividend"></see>
    /// </summary>
    let QualifiedDividend = _prefix "QualifiedDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShare"></see>
    /// </summary>
    let RedeemablePreferredShare = _prefix "RedeemablePreferredShare"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableMaturityDate"></see>
    /// </summary>
    let RedeemablePreferredShareWithExtendableMaturityDate =
        _prefix "RedeemablePreferredShareWithExtendableMaturityDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableMaturityDate"></see>
    /// </summary>
    let hasExtendableMaturityDate = _prefix "hasExtendableMaturityDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableRedemptionDate"></see>
    /// </summary>
    let RedeemablePreferredShareWithExtendableRedemptionDate =
        _prefix "RedeemablePreferredShareWithExtendableRedemptionDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedShare"></see>
    /// </summary>
    let RestrictedShare = _prefix "RestrictedShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/UnrestrictedShare"></see>
    /// </summary>
    let UnrestrictedShare = _prefix "UnrestrictedShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedVotingShare"></see>
    /// </summary>
    let RestrictedVotingShare = _prefix "RestrictedVotingShare"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableMaturityDate"></see>
    /// </summary>
    let RetractablePreferredShareWithExtendableMaturityDate =
        _prefix "RetractablePreferredShareWithExtendableMaturityDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableRedemptionDate"></see>
    /// </summary>
    let RetractablePreferredShareWithExtendableRedemptionDate =
        _prefix "RetractablePreferredShareWithExtendableRedemptionDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAvailableShares"></see>
    /// </summary>
    let hasAvailableShares = _prefix "hasAvailableShares"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFloatingStock"></see>
    /// </summary>
    let hasFloatingStock = _prefix "hasFloatingStock"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesIssued"></see>
    /// </summary>
    let hasSharesIssued = _prefix "hasSharesIssued"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesOutstanding"></see>
    /// </summary>
    let hasSharesOutstanding = _prefix "hasSharesOutstanding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasTreasuryShares"></see>
    /// </summary>
    let hasTreasuryShares = _prefix "hasTreasuryShares"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasShareClass"></see>
    /// </summary>
    let hasShareClass = _prefix "hasShareClass"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasVotingRestriction"></see>
    /// </summary>
    let hasVotingRestriction = _prefix "hasVotingRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersOwnershipOf"></see>
    /// </summary>
    let confersOwnershipOf = _prefix "confersOwnershipOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareIssuer"></see>
    /// </summary>
    let ShareIssuer = _prefix "ShareIssuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareYield"></see>
    /// </summary>
    let ShareYield = _prefix "ShareYield"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SingleVotingShare"></see>
    /// </summary>
    let SingleVotingShare = _prefix "SingleVotingShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SpecialDividend"></see>
    /// </summary>
    let SpecialDividend = _prefix "SpecialDividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VariableInterestEntityShare"></see>
    /// </summary>
    let VariableInterestEntityShare = _prefix "VariableInterestEntityShare"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VotingRight"></see>
    /// </summary>
    let VotingRight = _prefix "VotingRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendDeclarationDate"></see>
    /// </summary>
    let hasDividendDeclarationDate = _prefix "hasDividendDeclarationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExDividendDate"></see>
    /// </summary>
    let hasExDividendDate = _prefix "hasExDividendDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRecordDate"></see>
    /// </summary>
    let hasRecordDate = _prefix "hasRecordDate"
