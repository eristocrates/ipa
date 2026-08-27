namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DebtInstruments.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_dbti =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_dbti |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Debt Instruments Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_dbti, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:AtADiscount</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-dbti:RelativePrice</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"at a discount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtADiscount">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtADiscount</seealso>
    let AtADiscount = Prefixed_Name(fibo_sec_dbt_dbti, "AtADiscount") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:AtAPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-dbti:RelativePrice</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"at a premium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtAPremium">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/AtAPremium</seealso>
    let AtAPremium = Prefixed_Name(fibo_sec_dbt_dbti, "AtAPremium") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallEvent</seealso>
    let CallEvent = Prefixed_Name(fibo_sec_dbt_dbti, "CallEvent") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallFeature</seealso>
    let CallFeature = Prefixed_Name(fibo_sec_dbt_dbti, "CallFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallNotificationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call notification provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallNotificationProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallNotificationProvision</seealso>
    let CallNotificationProvision =
        Prefixed_Name(fibo_sec_dbt_dbti, "CallNotificationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call premium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallPremium">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallPremium</seealso>
    let CallPremium = Prefixed_Name(fibo_sec_dbt_dbti, "CallPremium") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallSchedule">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallSchedule</seealso>
    let CallSchedule = Prefixed_Name(fibo_sec_dbt_dbti, "CallSchedule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:CallWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallWindow">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallWindow</seealso>
    let CallWindow = Prefixed_Name(fibo_sec_dbt_dbti, "CallWindow") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:DebtOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/DebtOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/DebtOffering</seealso>
    let DebtOffering = Prefixed_Name(fibo_sec_dbt_dbti, "DebtOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:FixedIncomeSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed income security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FixedIncomeSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FixedIncomeSecurity</seealso>
    let FixedIncomeSecurity =
        Prefixed_Name(fibo_sec_dbt_dbti, "FixedIncomeSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:FullyIndexedInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fully-indexed interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FullyIndexedInterestRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FullyIndexedInterestRate</seealso>
    let FullyIndexedInterestRate =
        Prefixed_Name(fibo_sec_dbt_dbti, "FullyIndexedInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:InterestOnlyStrip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest-only strip"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/InterestOnlyStrip">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/InterestOnlyStrip</seealso>
    let InterestOnlyStrip =
        Prefixed_Name(fibo_sec_dbt_dbti, "InterestOnlyStrip") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:IssuedDebt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"issued debt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/IssuedDebt">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/IssuedDebt</seealso>
    let IssuedDebt = Prefixed_Name(fibo_sec_dbt_dbti, "IssuedDebt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:MakeWholeFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"make whole feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/MakeWholeFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/MakeWholeFeature</seealso>
    let MakeWholeFeature =
        Prefixed_Name(fibo_sec_dbt_dbti, "MakeWholeFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:Margin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"margin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Margin">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Margin</seealso>
    let Margin = Prefixed_Name(fibo_sec_dbt_dbti, "Margin") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:NonTradableDebtInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-tradable debt instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NonTradableDebtInstrument">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NonTradableDebtInstrument</seealso>
    let NonTradableDebtInstrument =
        Prefixed_Name(fibo_sec_dbt_dbti, "NonTradableDebtInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:NotificationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notification provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NotificationProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NotificationProvision</seealso>
    let NotificationProvision =
        Prefixed_Name(fibo_sec_dbt_dbti, "NotificationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:ParValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-dbt-dbti:RelativePrice</para>
    ///
    /// labels<para>"par value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/ParValue">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/ParValue</seealso>
    let ParValue = Prefixed_Name(fibo_sec_dbt_dbti, "ParValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PrescriptiveEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prescriptive event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrescriptiveEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrescriptiveEvent</seealso>
    let PrescriptiveEvent =
        Prefixed_Name(fibo_sec_dbt_dbti, "PrescriptiveEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PrincipalOnlyStrip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal-only strip"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrincipalOnlyStrip">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrincipalOnlyStrip</seealso>
    let PrincipalOnlyStrip =
        Prefixed_Name(fibo_sec_dbt_dbti, "PrincipalOnlyStrip") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PubliclyIssuedDebt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publicly issued debt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PubliclyIssuedDebt">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PubliclyIssuedDebt</seealso>
    let PubliclyIssuedDebt =
        Prefixed_Name(fibo_sec_dbt_dbti, "PubliclyIssuedDebt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutEvent</seealso>
    let PutEvent = Prefixed_Name(fibo_sec_dbt_dbti, "PutEvent") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutFeature</seealso>
    let PutFeature = Prefixed_Name(fibo_sec_dbt_dbti, "PutFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutNotificationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put notification provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutNotificationProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutNotificationProvision</seealso>
    let PutNotificationProvision =
        Prefixed_Name(fibo_sec_dbt_dbti, "PutNotificationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put premium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutPremium">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutPremium</seealso>
    let PutPremium = Prefixed_Name(fibo_sec_dbt_dbti, "PutPremium") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutSchedule">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutSchedule</seealso>
    let PutSchedule = Prefixed_Name(fibo_sec_dbt_dbti, "PutSchedule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:PutWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutWindow">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutWindow</seealso>
    let PutWindow = Prefixed_Name(fibo_sec_dbt_dbti, "PutWindow") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:RedemptionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redemption event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RedemptionEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RedemptionEvent</seealso>
    let RedemptionEvent =
        Prefixed_Name(fibo_sec_dbt_dbti, "RedemptionEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:RelativePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relative price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RelativePrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RelativePrice</seealso>
    let RelativePrice =
        Prefixed_Name(fibo_sec_dbt_dbti, "RelativePrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:StepEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"step event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepEvent</seealso>
    let StepEvent = Prefixed_Name(fibo_sec_dbt_dbti, "StepEvent") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:StepSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"step schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepSchedule">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepSchedule</seealso>
    let StepSchedule = Prefixed_Name(fibo_sec_dbt_dbti, "StepSchedule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:Strip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strip"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Strip">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Strip</seealso>
    let Strip = Prefixed_Name(fibo_sec_dbt_dbti, "Strip") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:TradableDebtInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tradable debt instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/TradableDebtInstrument">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/TradableDebtInstrument</seealso>
    let TradableDebtInstrument =
        Prefixed_Name(fibo_sec_dbt_dbti, "TradableDebtInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:VariableIncomeSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable income security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/VariableIncomeSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/VariableIncomeSecurity</seealso>
    let VariableIncomeSecurity =
        Prefixed_Name(fibo_sec_dbt_dbti, "VariableIncomeSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:allowsAutoReinvestment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"allows auto-reinvestment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsAutoReinvestment">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsAutoReinvestment</seealso>
    let allowsAutoReinvestment =
        Prefixed_Name(fibo_sec_dbt_dbti, "allowsAutoReinvestment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:allowsPaymentInKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"allows payment in kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsPaymentInKind">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsPaymentInKind</seealso>
    let allowsPaymentInKind =
        Prefixed_Name(fibo_sec_dbt_dbti, "allowsPaymentInKind") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasCallFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has call feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasCallFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasCallFeature</seealso>
    let hasCallFeature =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasCallFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasDatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dated date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDatedDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDatedDate</seealso>
    let hasDatedDate = Prefixed_Name(fibo_sec_dbt_dbti, "hasDatedDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasDefaultLotSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has default lot size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDefaultLotSize">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDefaultLotSize</seealso>
    let hasDefaultLotSize =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasDefaultLotSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasEstateOrDeathPutFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has estate or death put feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasEstateOrDeathPutFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasEstateOrDeathPutFeature</seealso>
    let hasEstateOrDeathPutFeature =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasEstateOrDeathPutFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasInterestPaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest payment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasInterestPaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasInterestPaymentTerms</seealso>
    let hasInterestPaymentTerms =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasInterestPaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasNotificationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has notification provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasNotificationProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasNotificationProvision</seealso>
    let hasNotificationProvision =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasNotificationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasPoolNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has pool number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPoolNumber">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPoolNumber</seealso>
    let hasPoolNumber =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasPoolNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasPriceAndYieldDayCountConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has price and yield day count convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPriceAndYieldDayCountConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPriceAndYieldDayCountConvention</seealso>
    let hasPriceAndYieldDayCountConvention =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasPriceAndYieldDayCountConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasPutFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has put feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPutFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPutFeature</seealso>
    let hasPutFeature =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasPutFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasRelativePriceAtIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relative price at issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtIssue">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtIssue</seealso>
    let hasRelativePriceAtIssue =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasRelativePriceAtIssue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasRelativePriceAtMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relative price at maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtMaturity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtMaturity</seealso>
    let hasRelativePriceAtMaturity =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasRelativePriceAtMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasRelativePriceAtRedemption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relative price at redemption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtRedemption">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtRedemption</seealso>
    let hasRelativePriceAtRedemption =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasRelativePriceAtRedemption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasRepaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has repayment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRepaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRepaymentTerms</seealso>
    let hasRepaymentTerms =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasRepaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:hasRightToRetain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"right to retain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRightToRetain">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRightToRetain</seealso>
    let hasRightToRetain =
        Prefixed_Name(fibo_sec_dbt_dbti, "hasRightToRetain") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isCallable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is callable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isCallable">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isCallable</seealso>
    let isCallable = Prefixed_Name(fibo_sec_dbt_dbti, "isCallable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isExchangeable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is exchangeable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExchangeable">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExchangeable</seealso>
    let isExchangeable =
        Prefixed_Name(fibo_sec_dbt_dbti, "isExchangeable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isExtendableByHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is extendable by holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByHolder">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByHolder</seealso>
    let isExtendableByHolder =
        Prefixed_Name(fibo_sec_dbt_dbti, "isExtendableByHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isExtendableByIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is extendable by issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByIssuer">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByIssuer</seealso>
    let isExtendableByIssuer =
        Prefixed_Name(fibo_sec_dbt_dbti, "isExtendableByIssuer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isPutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is putable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isPutable">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isPutable</seealso>
    let isPutable = Prefixed_Name(fibo_sec_dbt_dbti, "isPutable") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isStrippable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is strippable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isStrippable">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isStrippable</seealso>
    let isStrippable = Prefixed_Name(fibo_sec_dbt_dbti, "isStrippable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isSubordinated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is subordinated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinated">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinated</seealso>
    let isSubordinated =
        Prefixed_Name(fibo_sec_dbt_dbti, "isSubordinated") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dbti:isSubordinatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subordinated to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinatedTo">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinatedTo</seealso>
    let isSubordinatedTo =
        Prefixed_Name(fibo_sec_dbt_dbti, "isSubordinatedTo") |> PrefixedName
