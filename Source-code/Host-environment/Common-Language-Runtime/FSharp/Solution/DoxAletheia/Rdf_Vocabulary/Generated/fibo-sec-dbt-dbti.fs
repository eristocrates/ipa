namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DebtInstruments.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_dbti =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasCallFeature"></see>
    /// </summary>
    let hasCallFeature =
        Namespaced_IRI.parse _namespace_name "hasCallFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallFeature"></see>
    /// </summary>
    let CallFeature =
        Namespaced_IRI.parse _namespace_name "CallFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/DebtOffering"></see>
    /// </summary>
    let DebtOffering =
        Namespaced_IRI.parse _namespace_name "DebtOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPutFeature"></see>
    /// </summary>
    let hasPutFeature =
        Namespaced_IRI.parse _namespace_name "hasPutFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutFeature"></see>
    /// </summary>
    let PutFeature = Namespaced_IRI.parse _namespace_name "PutFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasInterestPaymentTerms"></see>
    /// </summary>
    let hasInterestPaymentTerms =
        Namespaced_IRI.parse _namespace_name "hasInterestPaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRepaymentTerms"></see>
    /// </summary>
    let hasRepaymentTerms =
        Namespaced_IRI.parse _namespace_name "hasRepaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtADiscount"></see>
    /// </summary>
    let AtADiscount =
        Namespaced_IRI.parse _namespace_name "AtADiscount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RelativePrice"></see>
    /// </summary>
    let RelativePrice =
        Namespaced_IRI.parse _namespace_name "RelativePrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtAPremium"></see>
    /// </summary>
    let AtAPremium = Namespaced_IRI.parse _namespace_name "AtAPremium" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallEvent"></see>
    /// </summary>
    let CallEvent = Namespaced_IRI.parse _namespace_name "CallEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RedemptionEvent"></see>
    /// </summary>
    let RedemptionEvent =
        Namespaced_IRI.parse _namespace_name "RedemptionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasNotificationProvision"></see>
    /// </summary>
    let hasNotificationProvision =
        Namespaced_IRI.parse _namespace_name "hasNotificationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallNotificationProvision"></see>
    /// </summary>
    let CallNotificationProvision =
        Namespaced_IRI.parse _namespace_name "CallNotificationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallSchedule"></see>
    /// </summary>
    let CallSchedule =
        Namespaced_IRI.parse _namespace_name "CallSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NotificationProvision"></see>
    /// </summary>
    let NotificationProvision =
        Namespaced_IRI.parse _namespace_name "NotificationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallWindow"></see>
    /// </summary>
    let CallWindow = Namespaced_IRI.parse _namespace_name "CallWindow" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallPremium"></see>
    /// </summary>
    let CallPremium =
        Namespaced_IRI.parse _namespace_name "CallPremium" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FixedIncomeSecurity"></see>
    /// </summary>
    let FixedIncomeSecurity =
        Namespaced_IRI.parse _namespace_name "FixedIncomeSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/TradableDebtInstrument"></see>
    /// </summary>
    let TradableDebtInstrument =
        Namespaced_IRI.parse _namespace_name "TradableDebtInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FullyIndexedInterestRate"></see>
    /// </summary>
    let FullyIndexedInterestRate =
        Namespaced_IRI.parse _namespace_name "FullyIndexedInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Margin"></see>
    /// </summary>
    let Margin = Namespaced_IRI.parse _namespace_name "Margin" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/InterestOnlyStrip"></see>
    /// </summary>
    let InterestOnlyStrip =
        Namespaced_IRI.parse _namespace_name "InterestOnlyStrip" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Strip"></see>
    /// </summary>
    let Strip = Namespaced_IRI.parse _namespace_name "Strip" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/IssuedDebt"></see>
    /// </summary>
    let IssuedDebt = Namespaced_IRI.parse _namespace_name "IssuedDebt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/MakeWholeFeature"></see>
    /// </summary>
    let MakeWholeFeature =
        Namespaced_IRI.parse _namespace_name "MakeWholeFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NonTradableDebtInstrument"></see>
    /// </summary>
    let NonTradableDebtInstrument =
        Namespaced_IRI.parse _namespace_name "NonTradableDebtInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtIssue"></see>
    /// </summary>
    let hasRelativePriceAtIssue =
        Namespaced_IRI.parse _namespace_name "hasRelativePriceAtIssue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtRedemption"></see>
    /// </summary>
    let hasRelativePriceAtRedemption =
        Namespaced_IRI.parse _namespace_name "hasRelativePriceAtRedemption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/ParValue"></see>
    /// </summary>
    let ParValue = Namespaced_IRI.parse _namespace_name "ParValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrescriptiveEvent"></see>
    /// </summary>
    let PrescriptiveEvent =
        Namespaced_IRI.parse _namespace_name "PrescriptiveEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrincipalOnlyStrip"></see>
    /// </summary>
    let PrincipalOnlyStrip =
        Namespaced_IRI.parse _namespace_name "PrincipalOnlyStrip" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PubliclyIssuedDebt"></see>
    /// </summary>
    let PubliclyIssuedDebt =
        Namespaced_IRI.parse _namespace_name "PubliclyIssuedDebt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutEvent"></see>
    /// </summary>
    let PutEvent = Namespaced_IRI.parse _namespace_name "PutEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutNotificationProvision"></see>
    /// </summary>
    let PutNotificationProvision =
        Namespaced_IRI.parse _namespace_name "PutNotificationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutSchedule"></see>
    /// </summary>
    let PutSchedule =
        Namespaced_IRI.parse _namespace_name "PutSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutWindow"></see>
    /// </summary>
    let PutWindow = Namespaced_IRI.parse _namespace_name "PutWindow" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutPremium"></see>
    /// </summary>
    let PutPremium = Namespaced_IRI.parse _namespace_name "PutPremium" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepEvent"></see>
    /// </summary>
    let StepEvent = Namespaced_IRI.parse _namespace_name "StepEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepSchedule"></see>
    /// </summary>
    let StepSchedule =
        Namespaced_IRI.parse _namespace_name "StepSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinatedTo"></see>
    /// </summary>
    let isSubordinatedTo =
        Namespaced_IRI.parse _namespace_name "isSubordinatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/VariableIncomeSecurity"></see>
    /// </summary>
    let VariableIncomeSecurity =
        Namespaced_IRI.parse _namespace_name "VariableIncomeSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsAutoReinvestment"></see>
    /// </summary>
    let allowsAutoReinvestment =
        Namespaced_IRI.parse _namespace_name "allowsAutoReinvestment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsPaymentInKind"></see>
    /// </summary>
    let allowsPaymentInKind =
        Namespaced_IRI.parse _namespace_name "allowsPaymentInKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDatedDate"></see>
    /// </summary>
    let hasDatedDate =
        Namespaced_IRI.parse _namespace_name "hasDatedDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDefaultLotSize"></see>
    /// </summary>
    let hasDefaultLotSize =
        Namespaced_IRI.parse _namespace_name "hasDefaultLotSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasEstateOrDeathPutFeature"></see>
    /// </summary>
    let hasEstateOrDeathPutFeature =
        Namespaced_IRI.parse _namespace_name "hasEstateOrDeathPutFeature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPoolNumber"></see>
    /// </summary>
    let hasPoolNumber =
        Namespaced_IRI.parse _namespace_name "hasPoolNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPriceAndYieldDayCountConvention"></see>
    /// </summary>
    let hasPriceAndYieldDayCountConvention =
        Namespaced_IRI.parse _namespace_name "hasPriceAndYieldDayCountConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtMaturity"></see>
    /// </summary>
    let hasRelativePriceAtMaturity =
        Namespaced_IRI.parse _namespace_name "hasRelativePriceAtMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRightToRetain"></see>
    /// </summary>
    let hasRightToRetain =
        Namespaced_IRI.parse _namespace_name "hasRightToRetain" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isCallable"></see>
    /// </summary>
    let isCallable = Namespaced_IRI.parse _namespace_name "isCallable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExchangeable"></see>
    /// </summary>
    let isExchangeable =
        Namespaced_IRI.parse _namespace_name "isExchangeable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByHolder"></see>
    /// </summary>
    let isExtendableByHolder =
        Namespaced_IRI.parse _namespace_name "isExtendableByHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByIssuer"></see>
    /// </summary>
    let isExtendableByIssuer =
        Namespaced_IRI.parse _namespace_name "isExtendableByIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isPutable"></see>
    /// </summary>
    let isPutable = Namespaced_IRI.parse _namespace_name "isPutable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isStrippable"></see>
    /// </summary>
    let isStrippable =
        Namespaced_IRI.parse _namespace_name "isStrippable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinated"></see>
    /// </summary>
    let isSubordinated =
        Namespaced_IRI.parse _namespace_name "isSubordinated" |> NamespacedName
