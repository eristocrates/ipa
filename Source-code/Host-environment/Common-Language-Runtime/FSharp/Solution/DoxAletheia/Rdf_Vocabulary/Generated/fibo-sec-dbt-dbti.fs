namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DebtInstruments.slash

open DoxAletheia

module fibo_sec_dbt_dbti =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasCallFeature"></see>
    /// </summary>
    let hasCallFeature = _prefix "hasCallFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallFeature"></see>
    /// </summary>
    let CallFeature = _prefix "CallFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/DebtOffering"></see>
    /// </summary>
    let DebtOffering = _prefix "DebtOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPutFeature"></see>
    /// </summary>
    let hasPutFeature = _prefix "hasPutFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutFeature"></see>
    /// </summary>
    let PutFeature = _prefix "PutFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasInterestPaymentTerms"></see>
    /// </summary>
    let hasInterestPaymentTerms = _prefix "hasInterestPaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRepaymentTerms"></see>
    /// </summary>
    let hasRepaymentTerms = _prefix "hasRepaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtADiscount"></see>
    /// </summary>
    let AtADiscount = _prefix "AtADiscount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RelativePrice"></see>
    /// </summary>
    let RelativePrice = _prefix "RelativePrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtAPremium"></see>
    /// </summary>
    let AtAPremium = _prefix "AtAPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallEvent"></see>
    /// </summary>
    let CallEvent = _prefix "CallEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RedemptionEvent"></see>
    /// </summary>
    let RedemptionEvent = _prefix "RedemptionEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasNotificationProvision"></see>
    /// </summary>
    let hasNotificationProvision = _prefix "hasNotificationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallNotificationProvision"></see>
    /// </summary>
    let CallNotificationProvision = _prefix "CallNotificationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallSchedule"></see>
    /// </summary>
    let CallSchedule = _prefix "CallSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NotificationProvision"></see>
    /// </summary>
    let NotificationProvision = _prefix "NotificationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallWindow"></see>
    /// </summary>
    let CallWindow = _prefix "CallWindow"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallPremium"></see>
    /// </summary>
    let CallPremium = _prefix "CallPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FixedIncomeSecurity"></see>
    /// </summary>
    let FixedIncomeSecurity = _prefix "FixedIncomeSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/TradableDebtInstrument"></see>
    /// </summary>
    let TradableDebtInstrument = _prefix "TradableDebtInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FullyIndexedInterestRate"></see>
    /// </summary>
    let FullyIndexedInterestRate = _prefix "FullyIndexedInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Margin"></see>
    /// </summary>
    let Margin = _prefix "Margin"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/InterestOnlyStrip"></see>
    /// </summary>
    let InterestOnlyStrip = _prefix "InterestOnlyStrip"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Strip"></see>
    /// </summary>
    let Strip = _prefix "Strip"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/IssuedDebt"></see>
    /// </summary>
    let IssuedDebt = _prefix "IssuedDebt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/MakeWholeFeature"></see>
    /// </summary>
    let MakeWholeFeature = _prefix "MakeWholeFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NonTradableDebtInstrument"></see>
    /// </summary>
    let NonTradableDebtInstrument = _prefix "NonTradableDebtInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtIssue"></see>
    /// </summary>
    let hasRelativePriceAtIssue = _prefix "hasRelativePriceAtIssue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtRedemption"></see>
    /// </summary>
    let hasRelativePriceAtRedemption = _prefix "hasRelativePriceAtRedemption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/ParValue"></see>
    /// </summary>
    let ParValue = _prefix "ParValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrescriptiveEvent"></see>
    /// </summary>
    let PrescriptiveEvent = _prefix "PrescriptiveEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrincipalOnlyStrip"></see>
    /// </summary>
    let PrincipalOnlyStrip = _prefix "PrincipalOnlyStrip"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PubliclyIssuedDebt"></see>
    /// </summary>
    let PubliclyIssuedDebt = _prefix "PubliclyIssuedDebt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutEvent"></see>
    /// </summary>
    let PutEvent = _prefix "PutEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutNotificationProvision"></see>
    /// </summary>
    let PutNotificationProvision = _prefix "PutNotificationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutSchedule"></see>
    /// </summary>
    let PutSchedule = _prefix "PutSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutWindow"></see>
    /// </summary>
    let PutWindow = _prefix "PutWindow"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutPremium"></see>
    /// </summary>
    let PutPremium = _prefix "PutPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepEvent"></see>
    /// </summary>
    let StepEvent = _prefix "StepEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepSchedule"></see>
    /// </summary>
    let StepSchedule = _prefix "StepSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinatedTo"></see>
    /// </summary>
    let isSubordinatedTo = _prefix "isSubordinatedTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/VariableIncomeSecurity"></see>
    /// </summary>
    let VariableIncomeSecurity = _prefix "VariableIncomeSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsAutoReinvestment"></see>
    /// </summary>
    let allowsAutoReinvestment = _prefix "allowsAutoReinvestment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsPaymentInKind"></see>
    /// </summary>
    let allowsPaymentInKind = _prefix "allowsPaymentInKind"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDatedDate"></see>
    /// </summary>
    let hasDatedDate = _prefix "hasDatedDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDefaultLotSize"></see>
    /// </summary>
    let hasDefaultLotSize = _prefix "hasDefaultLotSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasEstateOrDeathPutFeature"></see>
    /// </summary>
    let hasEstateOrDeathPutFeature = _prefix "hasEstateOrDeathPutFeature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPoolNumber"></see>
    /// </summary>
    let hasPoolNumber = _prefix "hasPoolNumber"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPriceAndYieldDayCountConvention"></see>
    /// </summary>
    let hasPriceAndYieldDayCountConvention =
        _prefix "hasPriceAndYieldDayCountConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtMaturity"></see>
    /// </summary>
    let hasRelativePriceAtMaturity = _prefix "hasRelativePriceAtMaturity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRightToRetain"></see>
    /// </summary>
    let hasRightToRetain = _prefix "hasRightToRetain"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isCallable"></see>
    /// </summary>
    let isCallable = _prefix "isCallable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExchangeable"></see>
    /// </summary>
    let isExchangeable = _prefix "isExchangeable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByHolder"></see>
    /// </summary>
    let isExtendableByHolder = _prefix "isExtendableByHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByIssuer"></see>
    /// </summary>
    let isExtendableByIssuer = _prefix "isExtendableByIssuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isPutable"></see>
    /// </summary>
    let isPutable = _prefix "isPutable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isStrippable"></see>
    /// </summary>
    let isStrippable = _prefix "isStrippable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinated"></see>
    /// </summary>
    let isSubordinated = _prefix "isSubordinated"
