namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.Bonds.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_bnd =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/AmortizingBond"></see>
    /// </summary>
    let AmortizingBond =
        Namespaced_IRI.parse _namespace_name "AmortizingBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/Bond"></see>
    /// </summary>
    let Bond = Namespaced_IRI.parse _namespace_name "Bond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondAmortizationPaymentTerms"></see>
    /// </summary>
    let BondAmortizationPaymentTerms =
        Namespaced_IRI.parse _namespace_name "BondAmortizationPaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletBond"></see>
    /// </summary>
    let BulletBond = Namespaced_IRI.parse _namespace_name "BulletBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CouponPaymentTerms"></see>
    /// </summary>
    let CouponPaymentTerms =
        Namespaced_IRI.parse _namespace_name "CouponPaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondPrincipalRepaymentTerms"></see>
    /// </summary>
    let BondPrincipalRepaymentTerms =
        Namespaced_IRI.parse _namespace_name "BondPrincipalRepaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletPrincipalRepaymentTerms"></see>
    /// </summary>
    let BulletPrincipalRepaymentTerms =
        Namespaced_IRI.parse _namespace_name "BulletPrincipalRepaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondConversionTerms"></see>
    /// </summary>
    let BondConversionTerms =
        Namespaced_IRI.parse _namespace_name "BondConversionTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondCoupon"></see>
    /// </summary>
    let BondCoupon = Namespaced_IRI.parse _namespace_name "BondCoupon" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondInsurance"></see>
    /// </summary>
    let BondInsurance =
        Namespaced_IRI.parse _namespace_name "BondInsurance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondRegistrar"></see>
    /// </summary>
    let BondRegistrar =
        Namespaced_IRI.parse _namespace_name "BondRegistrar" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondVariableCoupon"></see>
    /// </summary>
    let BondVariableCoupon =
        Namespaced_IRI.parse _namespace_name "BondVariableCoupon" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPartialCall"></see>
    /// </summary>
    let BondWithPartialCall =
        Namespaced_IRI.parse _namespace_name "BondWithPartialCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableBond"></see>
    /// </summary>
    let CallableBond =
        Namespaced_IRI.parse _namespace_name "CallableBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCallFeature"></see>
    /// </summary>
    let PartialCallFeature =
        Namespaced_IRI.parse _namespace_name "PartialCallFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPublishedSinkingFund"></see>
    /// </summary>
    let BondWithPublishedSinkingFund =
        Namespaced_IRI.parse _namespace_name "BondWithPublishedSinkingFund" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithWarrant"></see>
    /// </summary>
    let BondWithWarrant =
        Namespaced_IRI.parse _namespace_name "BondWithWarrant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BuildAmericaBond"></see>
    /// </summary>
    let BuildAmericaBond =
        Namespaced_IRI.parse _namespace_name "BuildAmericaBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalBond"></see>
    /// </summary>
    let MunicipalBond =
        Namespaced_IRI.parse _namespace_name "MunicipalBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasExtraordinaryRedemptionProvision"></see>
    /// </summary>
    let hasExtraordinaryRedemptionProvision =
        Namespaced_IRI.parse _namespace_name "hasExtraordinaryRedemptionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ExtraordinaryRedemptionProvision"></see>
    /// </summary>
    let ExtraordinaryRedemptionProvision =
        Namespaced_IRI.parse _namespace_name "ExtraordinaryRedemptionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableConvertibleBond"></see>
    /// </summary>
    let CallableConvertibleBond =
        Namespaced_IRI.parse _namespace_name "CallableConvertibleBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConvertibleBond"></see>
    /// </summary>
    let ConvertibleBond =
        Namespaced_IRI.parse _namespace_name "ConvertibleBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfObligation"></see>
    /// </summary>
    let CertificateOfObligation =
        Namespaced_IRI.parse _namespace_name "CertificateOfObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalSecurity"></see>
    /// </summary>
    let MunicipalSecurity =
        Namespaced_IRI.parse _namespace_name "MunicipalSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfParticipation"></see>
    /// </summary>
    let CertificateOfParticipation =
        Namespaced_IRI.parse _namespace_name "CertificateOfParticipation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConventionalGilt"></see>
    /// </summary>
    let ConventionalGilt =
        Namespaced_IRI.parse _namespace_name "ConventionalGilt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponBond"></see>
    /// </summary>
    let FixedCouponBond =
        Namespaced_IRI.parse _namespace_name "FixedCouponBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UKGovernmentSecurity"></see>
    /// </summary>
    let UKGovernmentSecurity =
        Namespaced_IRI.parse _namespace_name "UKGovernmentSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CorporateBond"></see>
    /// </summary>
    let CorporateBond =
        Namespaced_IRI.parse _namespace_name "CorporateBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentBond"></see>
    /// </summary>
    let GovernmentBond =
        Namespaced_IRI.parse _namespace_name "GovernmentBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/EquityLinkedBond"></see>
    /// </summary>
    let EquityLinkedBond =
        Namespaced_IRI.parse _namespace_name "EquityLinkedBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponBond"></see>
    /// </summary>
    let VariableCouponBond =
        Namespaced_IRI.parse _namespace_name "VariableCouponBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FirstRegularCouponDate"></see>
    /// </summary>
    let FirstRegularCouponDate =
        Namespaced_IRI.parse _namespace_name "FirstRegularCouponDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponTerms"></see>
    /// </summary>
    let FixedCouponTerms =
        Namespaced_IRI.parse _namespace_name "FixedCouponTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponTerms"></see>
    /// </summary>
    let VariableCouponTerms =
        Namespaced_IRI.parse _namespace_name "VariableCouponTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FloatingRateNote"></see>
    /// </summary>
    let FloatingRateNote =
        Namespaced_IRI.parse _namespace_name "FloatingRateNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FullFaithCreditBond"></see>
    /// </summary>
    let FullFaithCreditBond =
        Namespaced_IRI.parse _namespace_name "FullFaithCreditBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnsecuredBond"></see>
    /// </summary>
    let UnsecuredBond =
        Namespaced_IRI.parse _namespace_name "UnsecuredBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GeneralObligationMunicipalBond"></see>
    /// </summary>
    let GeneralObligationMunicipalBond =
        Namespaced_IRI.parse _namespace_name "GeneralObligationMunicipalBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RevenueBond"></see>
    /// </summary>
    let RevenueBond =
        Namespaced_IRI.parse _namespace_name "RevenueBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentIssuedDebtSecurity"></see>
    /// </summary>
    let GovernmentIssuedDebtSecurity =
        Namespaced_IRI.parse _namespace_name "GovernmentIssuedDebtSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GreenBond"></see>
    /// </summary>
    let GreenBond = Namespaced_IRI.parse _namespace_name "GreenBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ImplicitFullFaithCreditBond"></see>
    /// </summary>
    let ImplicitFullFaithCreditBond =
        Namespaced_IRI.parse _namespace_name "ImplicitFullFaithCreditBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/IndexLinkedBond"></see>
    /// </summary>
    let IndexLinkedBond =
        Namespaced_IRI.parse _namespace_name "IndexLinkedBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableIncomeBond"></see>
    /// </summary>
    let VariableIncomeBond =
        Namespaced_IRI.parse _namespace_name "VariableIncomeBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/InflationLinkedBond"></see>
    /// </summary>
    let InflationLinkedBond =
        Namespaced_IRI.parse _namespace_name "InflationLinkedBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LastRegularCouponDate"></see>
    /// </summary>
    let LastRegularCouponDate =
        Namespaced_IRI.parse _namespace_name "LastRegularCouponDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ListedBond"></see>
    /// </summary>
    let ListedBond = Namespaced_IRI.parse _namespace_name "ListedBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnlistedBond"></see>
    /// </summary>
    let UnlistedBond =
        Namespaced_IRI.parse _namespace_name "UnlistedBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LotteryConvention"></see>
    /// </summary>
    let LotteryConvention =
        Namespaced_IRI.parse _namespace_name "LotteryConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialRedemptionAllocationConvention"></see>
    /// </summary>
    let PartialRedemptionAllocationConvention =
        Namespaced_IRI.parse _namespace_name "PartialRedemptionAllocationConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MakeWholeCall"></see>
    /// </summary>
    let MakeWholeCall =
        Namespaced_IRI.parse _namespace_name "MakeWholeCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MandatoryConvertibleBond"></see>
    /// </summary>
    let MandatoryConvertibleBond =
        Namespaced_IRI.parse _namespace_name "MandatoryConvertibleBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MediumTermNote"></see>
    /// </summary>
    let MediumTermNote =
        Namespaced_IRI.parse _namespace_name "MediumTermNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtFundsUsage"></see>
    /// </summary>
    let MunicipalDebtFundsUsage =
        Namespaced_IRI.parse _namespace_name "MunicipalDebtFundsUsage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtRemarketingAgent"></see>
    /// </summary>
    let MunicipalDebtRemarketingAgent =
        Namespaced_IRI.parse _namespace_name "MunicipalDebtRemarketingAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtSourceOfFunds"></see>
    /// </summary>
    let MunicipalDebtSourceOfFunds =
        Namespaced_IRI.parse _namespace_name "MunicipalDebtSourceOfFunds" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalNote"></see>
    /// </summary>
    let MunicipalNote =
        Namespaced_IRI.parse _namespace_name "MunicipalNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFundingSource"></see>
    /// </summary>
    let hasFundingSource =
        Namespaced_IRI.parse _namespace_name "hasFundingSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignDebtInstrument"></see>
    /// </summary>
    let SovereignDebtInstrument =
        Namespaced_IRI.parse _namespace_name "SovereignDebtInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalTrustee"></see>
    /// </summary>
    let MunicipalTrustee =
        Namespaced_IRI.parse _namespace_name "MunicipalTrustee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/OriginalIssueDiscountBond"></see>
    /// </summary>
    let OriginalIssueDiscountBond =
        Namespaced_IRI.parse _namespace_name "OriginalIssueDiscountBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasOriginalIssueDiscountAmount"></see>
    /// </summary>
    let hasOriginalIssueDiscountAmount =
        Namespaced_IRI.parse _namespace_name "hasOriginalIssueDiscountAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCall"></see>
    /// </summary>
    let PartialCall =
        Namespaced_IRI.parse _namespace_name "PartialCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPartialRedemptionAllocationConvention"></see>
    /// </summary>
    let hasPartialRedemptionAllocationConvention =
        Namespaced_IRI.parse _namespace_name "hasPartialRedemptionAllocationConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageCumulativeAverageValue"></see>
    /// </summary>
    let PercentageCumulativeAverageValue =
        Namespaced_IRI.parse _namespace_name "PercentageCumulativeAverageValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RateBasisConvention"></see>
    /// </summary>
    let RateBasisConvention =
        Namespaced_IRI.parse _namespace_name "RateBasisConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageParValue"></see>
    /// </summary>
    let PercentageParValue =
        Namespaced_IRI.parse _namespace_name "PercentageParValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PerpetualBond"></see>
    /// </summary>
    let PerpetualBond =
        Namespaced_IRI.parse _namespace_name "PerpetualBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ProRataConvention"></see>
    /// </summary>
    let ProRataConvention =
        Namespaced_IRI.parse _namespace_name "ProRataConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionPayment"></see>
    /// </summary>
    let RedemptionPayment =
        Namespaced_IRI.parse _namespace_name "RedemptionPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionSchedule"></see>
    /// </summary>
    let RedemptionSchedule =
        Namespaced_IRI.parse _namespace_name "RedemptionSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RegulatoryCall"></see>
    /// </summary>
    let RegulatoryCall =
        Namespaced_IRI.parse _namespace_name "RegulatoryCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RemarketableBond"></see>
    /// </summary>
    let RemarketableBond =
        Namespaced_IRI.parse _namespace_name "RemarketableBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SecuredBond"></see>
    /// </summary>
    let SecuredBond =
        Namespaced_IRI.parse _namespace_name "SecuredBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SinkingFundAmortizationTerms"></see>
    /// </summary>
    let SinkingFundAmortizationTerms =
        Namespaced_IRI.parse _namespace_name "SinkingFundAmortizationTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isMandatory"></see>
    /// </summary>
    let isMandatory =
        Namespaced_IRI.parse _namespace_name "isMandatory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignBond"></see>
    /// </summary>
    let SovereignBond =
        Namespaced_IRI.parse _namespace_name "SovereignBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialAssessmentBond"></see>
    /// </summary>
    let SpecialAssessmentBond =
        Namespaced_IRI.parse _namespace_name "SpecialAssessmentBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialObligationBond"></see>
    /// </summary>
    let SpecialObligationBond =
        Namespaced_IRI.parse _namespace_name "SpecialObligationBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialTaxBond"></see>
    /// </summary>
    let SpecialTaxBond =
        Namespaced_IRI.parse _namespace_name "SpecialTaxBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StepUpBond"></see>
    /// </summary>
    let StepUpBond = Namespaced_IRI.parse _namespace_name "StepUpBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SteppedCouponTerms"></see>
    /// </summary>
    let SteppedCouponTerms =
        Namespaced_IRI.parse _namespace_name "SteppedCouponTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StripBond"></see>
    /// </summary>
    let StripBond = Namespaced_IRI.parse _namespace_name "StripBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponBond"></see>
    /// </summary>
    let ZeroCouponBond =
        Namespaced_IRI.parse _namespace_name "ZeroCouponBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TaxAllocationBond"></see>
    /// </summary>
    let TaxAllocationBond =
        Namespaced_IRI.parse _namespace_name "TaxAllocationBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBill"></see>
    /// </summary>
    let TreasuryBill =
        Namespaced_IRI.parse _namespace_name "TreasuryBill" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/USTreasurySecurity"></see>
    /// </summary>
    let USTreasurySecurity =
        Namespaced_IRI.parse _namespace_name "USTreasurySecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBond"></see>
    /// </summary>
    let TreasuryBond =
        Namespaced_IRI.parse _namespace_name "TreasuryBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryInflationProtectedSecurity"></see>
    /// </summary>
    let TreasuryInflationProtectedSecurity =
        Namespaced_IRI.parse _namespace_name "TreasuryInflationProtectedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariablePrincipalBond"></see>
    /// </summary>
    let VariablePrincipalBond =
        Namespaced_IRI.parse _namespace_name "VariablePrincipalBond" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryNote"></see>
    /// </summary>
    let TreasuryNote =
        Namespaced_IRI.parse _namespace_name "TreasuryNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestCalculationFormula"></see>
    /// </summary>
    let VariableInterestCalculationFormula =
        Namespaced_IRI.parse _namespace_name "VariableInterestCalculationFormula" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableDebtPrincipal"></see>
    /// </summary>
    let VariableDebtPrincipal =
        Namespaced_IRI.parse _namespace_name "VariableDebtPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestExpression"></see>
    /// </summary>
    let VariableInterestExpression =
        Namespaced_IRI.parse _namespace_name "VariableInterestExpression" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCeiling"></see>
    /// </summary>
    let hasCeiling = Namespaced_IRI.parse _namespace_name "hasCeiling" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFloor"></see>
    /// </summary>
    let hasFloor = Namespaced_IRI.parse _namespace_name "hasFloor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponTerms"></see>
    /// </summary>
    let ZeroCouponTerms =
        Namespaced_IRI.parse _namespace_name "ZeroCouponTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroInterestRate"></see>
    /// </summary>
    let ZeroInterestRate =
        Namespaced_IRI.parse _namespace_name "ZeroInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasAwardDate"></see>
    /// </summary>
    let hasAwardDate =
        Namespaced_IRI.parse _namespace_name "hasAwardDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallPrice"></see>
    /// </summary>
    let hasCallPrice =
        Namespaced_IRI.parse _namespace_name "hasCallPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallRateBasis"></see>
    /// </summary>
    let hasCallRateBasis =
        Namespaced_IRI.parse _namespace_name "hasCallRateBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasConvertibleDate"></see>
    /// </summary>
    let hasConvertibleDate =
        Namespaced_IRI.parse _namespace_name "hasConvertibleDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFinalMaturityDate"></see>
    /// </summary>
    let hasFinalMaturityDate =
        Namespaced_IRI.parse _namespace_name "hasFinalMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCallPrice"></see>
    /// </summary>
    let hasFirstCallPrice =
        Namespaced_IRI.parse _namespace_name "hasFirstCallPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCouponPaymentDate"></see>
    /// </summary>
    let hasFirstCouponPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasFirstCouponPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallDate"></see>
    /// </summary>
    let hasFirstParCallDate =
        Namespaced_IRI.parse _namespace_name "hasFirstParCallDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallPrice"></see>
    /// </summary>
    let hasFirstParCallPrice =
        Namespaced_IRI.parse _namespace_name "hasFirstParCallPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallDate"></see>
    /// </summary>
    let hasFirstPremiumCallDate =
        Namespaced_IRI.parse _namespace_name "hasFirstPremiumCallDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallPrice"></see>
    /// </summary>
    let hasFirstPremiumCallPrice =
        Namespaced_IRI.parse _namespace_name "hasFirstPremiumCallPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutDate"></see>
    /// </summary>
    let hasFirstPutDate =
        Namespaced_IRI.parse _namespace_name "hasFirstPutDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutDate"></see>
    /// </summary>
    let hasPutDate = Namespaced_IRI.parse _namespace_name "hasPutDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutPrice"></see>
    /// </summary>
    let hasFirstPutPrice =
        Namespaced_IRI.parse _namespace_name "hasFirstPutPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLastCouponPaymentDate"></see>
    /// </summary>
    let hasLastCouponPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasLastCouponPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLockoutPeriod"></see>
    /// </summary>
    let hasLockoutPeriod =
        Namespaced_IRI.parse _namespace_name "hasLockoutPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasMunicipalTrustee"></see>
    /// </summary>
    let hasMunicipalTrustee =
        Namespaced_IRI.parse _namespace_name "hasMunicipalTrustee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPenultimateCouponPaymentDate"></see>
    /// </summary>
    let hasPenultimateCouponPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasPenultimateCouponPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPremiumAmount"></see>
    /// </summary>
    let hasPremiumAmount =
        Namespaced_IRI.parse _namespace_name "hasPremiumAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutFrequency"></see>
    /// </summary>
    let hasPutFrequency =
        Namespaced_IRI.parse _namespace_name "hasPutFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRedemptionAmount"></see>
    /// </summary>
    let hasRedemptionAmount =
        Namespaced_IRI.parse _namespace_name "hasRedemptionAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRemarketingAgent"></see>
    /// </summary>
    let hasRemarketingAgent =
        Namespaced_IRI.parse _namespace_name "hasRemarketingAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasResetDateOffset"></see>
    /// </summary>
    let hasResetDateOffset =
        Namespaced_IRI.parse _namespace_name "hasResetDateOffset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isBankQualified"></see>
    /// </summary>
    let isBankQualified =
        Namespaced_IRI.parse _namespace_name "isBankQualified" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLegalOpinionAvailable"></see>
    /// </summary>
    let isLegalOpinionAvailable =
        Namespaced_IRI.parse _namespace_name "isLegalOpinionAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLinkedToFallback"></see>
    /// </summary>
    let isLinkedToFallback =
        Namespaced_IRI.parse _namespace_name "isLinkedToFallback" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isProRated"></see>
    /// </summary>
    let isProRated = Namespaced_IRI.parse _namespace_name "isProRated" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isSuperSinker"></see>
    /// </summary>
    let isSuperSinker =
        Namespaced_IRI.parse _namespace_name "isSuperSinker" |> NamespacedName
