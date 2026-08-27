namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.FinancialInstruments.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fi_fi =
    let _namespace_iri = Namespace_Iri fibo_fbc_fi_fi |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fi-fi:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Financial Instruments Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fi_fi, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:CalculationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculation agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CalculationAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CalculationAgent</seealso>
    let CalculationAgent =
        Prefixed_Name(fibo_fbc_fi_fi, "CalculationAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:CashInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cash instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CashInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CashInstrument</seealso>
    let CashInstrument = Prefixed_Name(fibo_fbc_fi_fi, "CashInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:CommodityInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CommodityInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CommodityInstrument</seealso>
    let CommodityInstrument =
        Prefixed_Name(fibo_fbc_fi_fi, "CommodityInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:CurrencyInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CurrencyInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CurrencyInstrument</seealso>
    let CurrencyInstrument =
        Prefixed_Name(fibo_fbc_fi_fi, "CurrencyInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:DebtInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DebtInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DebtInstrument</seealso>
    let DebtInstrument = Prefixed_Name(fibo_fbc_fi_fi, "DebtInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:DerivativeInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivative instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DerivativeInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DerivativeInstrument</seealso>
    let DerivativeInstrument =
        Prefixed_Name(fibo_fbc_fi_fi, "DerivativeInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Entitlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entitlement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Entitlement">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Entitlement</seealso>
    let Entitlement = Prefixed_Name(fibo_fbc_fi_fi, "Entitlement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:EquityInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/EquityInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/EquityInstrument</seealso>
    let EquityInstrument =
        Prefixed_Name(fibo_fbc_fi_fi, "EquityInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:ExemptSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exempt security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/ExemptSecurity">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/ExemptSecurity</seealso>
    let ExemptSecurity = Prefixed_Name(fibo_fbc_fi_fi, "ExemptSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:FinancialInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrument">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrument</seealso>
    let FinancialInstrument =
        Prefixed_Name(fibo_fbc_fi_fi, "FinancialInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:FinancialInstrumentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrumentIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrumentIdentifier</seealso>
    let FinancialInstrumentIdentifier =
        Prefixed_Name(fibo_fbc_fi_fi, "FinancialInstrumentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Future</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Future">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Future</seealso>
    let Future = Prefixed_Name(fibo_fbc_fi_fi, "Future") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Issuer">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Issuer</seealso>
    let Issuer = Prefixed_Name(fibo_fbc_fi_fi, "Issuer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:NegotiableSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negotiable security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NegotiableSecurity">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NegotiableSecurity</seealso>
    let NegotiableSecurity =
        Prefixed_Name(fibo_fbc_fi_fi, "NegotiableSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:NonNegotiableSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-negotiable security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NonNegotiableSecurity">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NonNegotiableSecurity</seealso>
    let NonNegotiableSecurity =
        Prefixed_Name(fibo_fbc_fi_fi, "NonNegotiableSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Option</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Option">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Option</seealso>
    let Option = Prefixed_Name(fibo_fbc_fi_fi, "Option") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:PackagedFinancialProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"packaged financial product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PackagedFinancialProduct">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PackagedFinancialProduct</seealso>
    let PackagedFinancialProduct =
        Prefixed_Name(fibo_fbc_fi_fi, "PackagedFinancialProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:PromissoryNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"promissory note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PromissoryNote">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PromissoryNote</seealso>
    let PromissoryNote = Prefixed_Name(fibo_fbc_fi_fi, "PromissoryNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:RedemptionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redemption provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/RedemptionProvision">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/RedemptionProvision</seealso>
    let RedemptionProvision =
        Prefixed_Name(fibo_fbc_fi_fi, "RedemptionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:SecuritiesTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities transaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SecuritiesTransaction">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SecuritiesTransaction</seealso>
    let SecuritiesTransaction =
        Prefixed_Name(fibo_fbc_fi_fi, "SecuritiesTransaction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Security">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Security</seealso>
    let Security = Prefixed_Name(fibo_fbc_fi_fi, "Security") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-fi:SpotContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spot contract"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SpotContract">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SpotContract</seealso>
    let SpotContract = Prefixed_Name(fibo_fbc_fi_fi, "SpotContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:StandardizedTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standardized terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/StandardizedTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/StandardizedTerms</seealso>
    let StandardizedTerms =
        Prefixed_Name(fibo_fbc_fi_fi, "StandardizedTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:Underlier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underlier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Underlier">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Underlier</seealso>
    let Underlier = Prefixed_Name(fibo_fbc_fi_fi, "Underlier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasBuyingCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has buying currency"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasBuyingCurrency">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasBuyingCurrency</seealso>
    let hasBuyingCurrency =
        Prefixed_Name(fibo_fbc_fi_fi, "hasBuyingCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasCalculationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has calculation agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCalculationAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCalculationAgent</seealso>
    let hasCalculationAgent =
        Prefixed_Name(fibo_fbc_fi_fi, "hasCalculationAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasCommodityValueAsOfExecutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has commodity value as of execution date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCommodityValueAsOfExecutionDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCommodityValueAsOfExecutionDate</seealso>
    let hasCommodityValueAsOfExecutionDate =
        Prefixed_Name(fibo_fbc_fi_fi, "hasCommodityValueAsOfExecutionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasNominalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has nominal value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasNominalValue">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasNominalValue</seealso>
    let hasNominalValue =
        Prefixed_Name(fibo_fbc_fi_fi, "hasNominalValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasPrincipalExecutiveOfficeAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal executive office address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasPrincipalExecutiveOfficeAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasPrincipalExecutiveOfficeAddress</seealso>
    let hasPrincipalExecutiveOfficeAddress =
        Prefixed_Name(fibo_fbc_fi_fi, "hasPrincipalExecutiveOfficeAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasRedemptionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has redemption terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasRedemptionProvision">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasRedemptionProvision</seealso>
    let hasRedemptionProvision =
        Prefixed_Name(fibo_fbc_fi_fi, "hasRedemptionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasSellingCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has selling currency"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasSellingCurrency">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasSellingCurrency</seealso>
    let hasSellingCurrency =
        Prefixed_Name(fibo_fbc_fi_fi, "hasSellingCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasShareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has shareholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasShareholder">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasShareholder</seealso>
    let hasShareholder = Prefixed_Name(fibo_fbc_fi_fi, "hasShareholder") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasUnderlier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has underlier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasUnderlier">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasUnderlier</seealso>
    let hasUnderlier = Prefixed_Name(fibo_fbc_fi_fi, "hasUnderlier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:hasValueExpressedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has value expressed in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasValueExpressedIn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasValueExpressedIn</seealso>
    let hasValueExpressedIn =
        Prefixed_Name(fibo_fbc_fi_fi, "hasValueExpressedIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:holdsSharesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"holds shares in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/holdsSharesIn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/holdsSharesIn</seealso>
    let holdsSharesIn = Prefixed_Name(fibo_fbc_fi_fi, "holdsSharesIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:isDenominatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is denominated in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isDenominatedIn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isDenominatedIn</seealso>
    let isDenominatedIn =
        Prefixed_Name(fibo_fbc_fi_fi, "isDenominatedIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:isLegallyRecordedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is legally recorded in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isLegallyRecordedIn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isLegallyRecordedIn</seealso>
    let isLegallyRecordedIn =
        Prefixed_Name(fibo_fbc_fi_fi, "isLegallyRecordedIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-fi:isNegotiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is negotiable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isNegotiable">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isNegotiable</seealso>
    let isNegotiable = Prefixed_Name(fibo_fbc_fi_fi, "isNegotiable") |> PrefixedName
