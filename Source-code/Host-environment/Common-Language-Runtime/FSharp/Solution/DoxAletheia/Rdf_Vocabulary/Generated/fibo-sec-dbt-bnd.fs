namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.Bonds.slash

open DoxAletheia

module fibo_sec_dbt_bnd =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/AmortizingBond"></see>
    /// </summary>
    let AmortizingBond = _prefix "AmortizingBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/Bond"></see>
    /// </summary>
    let Bond = _prefix "Bond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondAmortizationPaymentTerms"></see>
    /// </summary>
    let BondAmortizationPaymentTerms = _prefix "BondAmortizationPaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletBond"></see>
    /// </summary>
    let BulletBond = _prefix "BulletBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CouponPaymentTerms"></see>
    /// </summary>
    let CouponPaymentTerms = _prefix "CouponPaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondPrincipalRepaymentTerms"></see>
    /// </summary>
    let BondPrincipalRepaymentTerms = _prefix "BondPrincipalRepaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletPrincipalRepaymentTerms"></see>
    /// </summary>
    let BulletPrincipalRepaymentTerms = _prefix "BulletPrincipalRepaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondConversionTerms"></see>
    /// </summary>
    let BondConversionTerms = _prefix "BondConversionTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondCoupon"></see>
    /// </summary>
    let BondCoupon = _prefix "BondCoupon"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondInsurance"></see>
    /// </summary>
    let BondInsurance = _prefix "BondInsurance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondRegistrar"></see>
    /// </summary>
    let BondRegistrar = _prefix "BondRegistrar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondVariableCoupon"></see>
    /// </summary>
    let BondVariableCoupon = _prefix "BondVariableCoupon"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPartialCall"></see>
    /// </summary>
    let BondWithPartialCall = _prefix "BondWithPartialCall"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableBond"></see>
    /// </summary>
    let CallableBond = _prefix "CallableBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCallFeature"></see>
    /// </summary>
    let PartialCallFeature = _prefix "PartialCallFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPublishedSinkingFund"></see>
    /// </summary>
    let BondWithPublishedSinkingFund = _prefix "BondWithPublishedSinkingFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithWarrant"></see>
    /// </summary>
    let BondWithWarrant = _prefix "BondWithWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BuildAmericaBond"></see>
    /// </summary>
    let BuildAmericaBond = _prefix "BuildAmericaBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalBond"></see>
    /// </summary>
    let MunicipalBond = _prefix "MunicipalBond"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasExtraordinaryRedemptionProvision"></see>
    /// </summary>
    let hasExtraordinaryRedemptionProvision =
        _prefix "hasExtraordinaryRedemptionProvision"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ExtraordinaryRedemptionProvision"></see>
    /// </summary>
    let ExtraordinaryRedemptionProvision = _prefix "ExtraordinaryRedemptionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableConvertibleBond"></see>
    /// </summary>
    let CallableConvertibleBond = _prefix "CallableConvertibleBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConvertibleBond"></see>
    /// </summary>
    let ConvertibleBond = _prefix "ConvertibleBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfObligation"></see>
    /// </summary>
    let CertificateOfObligation = _prefix "CertificateOfObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalSecurity"></see>
    /// </summary>
    let MunicipalSecurity = _prefix "MunicipalSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfParticipation"></see>
    /// </summary>
    let CertificateOfParticipation = _prefix "CertificateOfParticipation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConventionalGilt"></see>
    /// </summary>
    let ConventionalGilt = _prefix "ConventionalGilt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponBond"></see>
    /// </summary>
    let FixedCouponBond = _prefix "FixedCouponBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UKGovernmentSecurity"></see>
    /// </summary>
    let UKGovernmentSecurity = _prefix "UKGovernmentSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CorporateBond"></see>
    /// </summary>
    let CorporateBond = _prefix "CorporateBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentBond"></see>
    /// </summary>
    let GovernmentBond = _prefix "GovernmentBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/EquityLinkedBond"></see>
    /// </summary>
    let EquityLinkedBond = _prefix "EquityLinkedBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponBond"></see>
    /// </summary>
    let VariableCouponBond = _prefix "VariableCouponBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FirstRegularCouponDate"></see>
    /// </summary>
    let FirstRegularCouponDate = _prefix "FirstRegularCouponDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponTerms"></see>
    /// </summary>
    let FixedCouponTerms = _prefix "FixedCouponTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponTerms"></see>
    /// </summary>
    let VariableCouponTerms = _prefix "VariableCouponTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FloatingRateNote"></see>
    /// </summary>
    let FloatingRateNote = _prefix "FloatingRateNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FullFaithCreditBond"></see>
    /// </summary>
    let FullFaithCreditBond = _prefix "FullFaithCreditBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnsecuredBond"></see>
    /// </summary>
    let UnsecuredBond = _prefix "UnsecuredBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GeneralObligationMunicipalBond"></see>
    /// </summary>
    let GeneralObligationMunicipalBond = _prefix "GeneralObligationMunicipalBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RevenueBond"></see>
    /// </summary>
    let RevenueBond = _prefix "RevenueBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentIssuedDebtSecurity"></see>
    /// </summary>
    let GovernmentIssuedDebtSecurity = _prefix "GovernmentIssuedDebtSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GreenBond"></see>
    /// </summary>
    let GreenBond = _prefix "GreenBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ImplicitFullFaithCreditBond"></see>
    /// </summary>
    let ImplicitFullFaithCreditBond = _prefix "ImplicitFullFaithCreditBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/IndexLinkedBond"></see>
    /// </summary>
    let IndexLinkedBond = _prefix "IndexLinkedBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableIncomeBond"></see>
    /// </summary>
    let VariableIncomeBond = _prefix "VariableIncomeBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/InflationLinkedBond"></see>
    /// </summary>
    let InflationLinkedBond = _prefix "InflationLinkedBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LastRegularCouponDate"></see>
    /// </summary>
    let LastRegularCouponDate = _prefix "LastRegularCouponDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ListedBond"></see>
    /// </summary>
    let ListedBond = _prefix "ListedBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnlistedBond"></see>
    /// </summary>
    let UnlistedBond = _prefix "UnlistedBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LotteryConvention"></see>
    /// </summary>
    let LotteryConvention = _prefix "LotteryConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialRedemptionAllocationConvention"></see>
    /// </summary>
    let PartialRedemptionAllocationConvention =
        _prefix "PartialRedemptionAllocationConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MakeWholeCall"></see>
    /// </summary>
    let MakeWholeCall = _prefix "MakeWholeCall"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MandatoryConvertibleBond"></see>
    /// </summary>
    let MandatoryConvertibleBond = _prefix "MandatoryConvertibleBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MediumTermNote"></see>
    /// </summary>
    let MediumTermNote = _prefix "MediumTermNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtFundsUsage"></see>
    /// </summary>
    let MunicipalDebtFundsUsage = _prefix "MunicipalDebtFundsUsage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtRemarketingAgent"></see>
    /// </summary>
    let MunicipalDebtRemarketingAgent = _prefix "MunicipalDebtRemarketingAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtSourceOfFunds"></see>
    /// </summary>
    let MunicipalDebtSourceOfFunds = _prefix "MunicipalDebtSourceOfFunds"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalNote"></see>
    /// </summary>
    let MunicipalNote = _prefix "MunicipalNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFundingSource"></see>
    /// </summary>
    let hasFundingSource = _prefix "hasFundingSource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignDebtInstrument"></see>
    /// </summary>
    let SovereignDebtInstrument = _prefix "SovereignDebtInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalTrustee"></see>
    /// </summary>
    let MunicipalTrustee = _prefix "MunicipalTrustee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/OriginalIssueDiscountBond"></see>
    /// </summary>
    let OriginalIssueDiscountBond = _prefix "OriginalIssueDiscountBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasOriginalIssueDiscountAmount"></see>
    /// </summary>
    let hasOriginalIssueDiscountAmount = _prefix "hasOriginalIssueDiscountAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCall"></see>
    /// </summary>
    let PartialCall = _prefix "PartialCall"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPartialRedemptionAllocationConvention"></see>
    /// </summary>
    let hasPartialRedemptionAllocationConvention =
        _prefix "hasPartialRedemptionAllocationConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageCumulativeAverageValue"></see>
    /// </summary>
    let PercentageCumulativeAverageValue = _prefix "PercentageCumulativeAverageValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RateBasisConvention"></see>
    /// </summary>
    let RateBasisConvention = _prefix "RateBasisConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageParValue"></see>
    /// </summary>
    let PercentageParValue = _prefix "PercentageParValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PerpetualBond"></see>
    /// </summary>
    let PerpetualBond = _prefix "PerpetualBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ProRataConvention"></see>
    /// </summary>
    let ProRataConvention = _prefix "ProRataConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionPayment"></see>
    /// </summary>
    let RedemptionPayment = _prefix "RedemptionPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionSchedule"></see>
    /// </summary>
    let RedemptionSchedule = _prefix "RedemptionSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RegulatoryCall"></see>
    /// </summary>
    let RegulatoryCall = _prefix "RegulatoryCall"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RemarketableBond"></see>
    /// </summary>
    let RemarketableBond = _prefix "RemarketableBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SecuredBond"></see>
    /// </summary>
    let SecuredBond = _prefix "SecuredBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SinkingFundAmortizationTerms"></see>
    /// </summary>
    let SinkingFundAmortizationTerms = _prefix "SinkingFundAmortizationTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isMandatory"></see>
    /// </summary>
    let isMandatory = _prefix "isMandatory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignBond"></see>
    /// </summary>
    let SovereignBond = _prefix "SovereignBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialAssessmentBond"></see>
    /// </summary>
    let SpecialAssessmentBond = _prefix "SpecialAssessmentBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialObligationBond"></see>
    /// </summary>
    let SpecialObligationBond = _prefix "SpecialObligationBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialTaxBond"></see>
    /// </summary>
    let SpecialTaxBond = _prefix "SpecialTaxBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StepUpBond"></see>
    /// </summary>
    let StepUpBond = _prefix "StepUpBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SteppedCouponTerms"></see>
    /// </summary>
    let SteppedCouponTerms = _prefix "SteppedCouponTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StripBond"></see>
    /// </summary>
    let StripBond = _prefix "StripBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponBond"></see>
    /// </summary>
    let ZeroCouponBond = _prefix "ZeroCouponBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TaxAllocationBond"></see>
    /// </summary>
    let TaxAllocationBond = _prefix "TaxAllocationBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBill"></see>
    /// </summary>
    let TreasuryBill = _prefix "TreasuryBill"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/USTreasurySecurity"></see>
    /// </summary>
    let USTreasurySecurity = _prefix "USTreasurySecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBond"></see>
    /// </summary>
    let TreasuryBond = _prefix "TreasuryBond"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryInflationProtectedSecurity"></see>
    /// </summary>
    let TreasuryInflationProtectedSecurity =
        _prefix "TreasuryInflationProtectedSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariablePrincipalBond"></see>
    /// </summary>
    let VariablePrincipalBond = _prefix "VariablePrincipalBond"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryNote"></see>
    /// </summary>
    let TreasuryNote = _prefix "TreasuryNote"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestCalculationFormula"></see>
    /// </summary>
    let VariableInterestCalculationFormula =
        _prefix "VariableInterestCalculationFormula"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableDebtPrincipal"></see>
    /// </summary>
    let VariableDebtPrincipal = _prefix "VariableDebtPrincipal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestExpression"></see>
    /// </summary>
    let VariableInterestExpression = _prefix "VariableInterestExpression"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCeiling"></see>
    /// </summary>
    let hasCeiling = _prefix "hasCeiling"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFloor"></see>
    /// </summary>
    let hasFloor = _prefix "hasFloor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponTerms"></see>
    /// </summary>
    let ZeroCouponTerms = _prefix "ZeroCouponTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroInterestRate"></see>
    /// </summary>
    let ZeroInterestRate = _prefix "ZeroInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasAwardDate"></see>
    /// </summary>
    let hasAwardDate = _prefix "hasAwardDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallPrice"></see>
    /// </summary>
    let hasCallPrice = _prefix "hasCallPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallRateBasis"></see>
    /// </summary>
    let hasCallRateBasis = _prefix "hasCallRateBasis"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasConvertibleDate"></see>
    /// </summary>
    let hasConvertibleDate = _prefix "hasConvertibleDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFinalMaturityDate"></see>
    /// </summary>
    let hasFinalMaturityDate = _prefix "hasFinalMaturityDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCallPrice"></see>
    /// </summary>
    let hasFirstCallPrice = _prefix "hasFirstCallPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCouponPaymentDate"></see>
    /// </summary>
    let hasFirstCouponPaymentDate = _prefix "hasFirstCouponPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallDate"></see>
    /// </summary>
    let hasFirstParCallDate = _prefix "hasFirstParCallDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallPrice"></see>
    /// </summary>
    let hasFirstParCallPrice = _prefix "hasFirstParCallPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallDate"></see>
    /// </summary>
    let hasFirstPremiumCallDate = _prefix "hasFirstPremiumCallDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallPrice"></see>
    /// </summary>
    let hasFirstPremiumCallPrice = _prefix "hasFirstPremiumCallPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutDate"></see>
    /// </summary>
    let hasFirstPutDate = _prefix "hasFirstPutDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutDate"></see>
    /// </summary>
    let hasPutDate = _prefix "hasPutDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutPrice"></see>
    /// </summary>
    let hasFirstPutPrice = _prefix "hasFirstPutPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLastCouponPaymentDate"></see>
    /// </summary>
    let hasLastCouponPaymentDate = _prefix "hasLastCouponPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLockoutPeriod"></see>
    /// </summary>
    let hasLockoutPeriod = _prefix "hasLockoutPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasMunicipalTrustee"></see>
    /// </summary>
    let hasMunicipalTrustee = _prefix "hasMunicipalTrustee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPenultimateCouponPaymentDate"></see>
    /// </summary>
    let hasPenultimateCouponPaymentDate = _prefix "hasPenultimateCouponPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPremiumAmount"></see>
    /// </summary>
    let hasPremiumAmount = _prefix "hasPremiumAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutFrequency"></see>
    /// </summary>
    let hasPutFrequency = _prefix "hasPutFrequency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRedemptionAmount"></see>
    /// </summary>
    let hasRedemptionAmount = _prefix "hasRedemptionAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRemarketingAgent"></see>
    /// </summary>
    let hasRemarketingAgent = _prefix "hasRemarketingAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasResetDateOffset"></see>
    /// </summary>
    let hasResetDateOffset = _prefix "hasResetDateOffset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isBankQualified"></see>
    /// </summary>
    let isBankQualified = _prefix "isBankQualified"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLegalOpinionAvailable"></see>
    /// </summary>
    let isLegalOpinionAvailable = _prefix "isLegalOpinionAvailable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLinkedToFallback"></see>
    /// </summary>
    let isLinkedToFallback = _prefix "isLinkedToFallback"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isProRated"></see>
    /// </summary>
    let isProRated = _prefix "isProRated"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isSuperSinker"></see>
    /// </summary>
    let isSuperSinker = _prefix "isSuperSinker"
