namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.Settlement.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fi_stl =
    let _namespace_iri = Namespace_Iri fibo_fbc_fi_stl |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fi-stl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Settlement Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fi_stl, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:CashSettlementTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cash settlement terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/CashSettlementTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/CashSettlementTerms</seealso>
    let CashSettlementTerms =
        Prefixed_Name(fibo_fbc_fi_stl, "CashSettlementTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:DeliveryInCash</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fi-stl:DeliveryMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"delivery in cash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryInCash">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryInCash</seealso>
    let DeliveryInCash =
        Prefixed_Name(fibo_fbc_fi_stl, "DeliveryInCash") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:DeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fibo-fnd-agr-ctr:ContractualCommitment</para>
    ///
    /// labels<para>"delivery method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryMethod</seealso>
    let DeliveryMethod =
        Prefixed_Name(fibo_fbc_fi_stl, "DeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:ElectAtExerciseMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fi-stl:DeliveryMethod</para>
    ///
    /// labels<para>"elect at exercise method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/ElectAtExerciseMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/ElectAtExerciseMethod</seealso>
    let ElectAtExerciseMethod =
        Prefixed_Name(fibo_fbc_fi_stl, "ElectAtExerciseMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:NonDeliverableMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fi-stl:DeliveryMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"non-deliverable method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/NonDeliverableMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/NonDeliverableMethod</seealso>
    let NonDeliverableMethod =
        Prefixed_Name(fibo_fbc_fi_stl, "NonDeliverableMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:PhysicalDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fi-stl:DeliveryMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"physical delivery method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalDeliveryMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalDeliveryMethod</seealso>
    let PhysicalDeliveryMethod =
        Prefixed_Name(fibo_fbc_fi_stl, "PhysicalDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:PhysicalSettlementTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical settlement terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalSettlementTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalSettlementTerms</seealso>
    let PhysicalSettlementTerms =
        Prefixed_Name(fibo_fbc_fi_stl, "PhysicalSettlementTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:Settlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/Settlement">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/Settlement</seealso>
    let Settlement = Prefixed_Name(fibo_fbc_fi_stl, "Settlement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:SettlementConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementConvention">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementConvention</seealso>
    let SettlementConvention =
        Prefixed_Name(fibo_fbc_fi_stl, "SettlementConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:SettlementEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementEvent</seealso>
    let SettlementEvent =
        Prefixed_Name(fibo_fbc_fi_stl, "SettlementEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:hasDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has settlement method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasDeliveryMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasDeliveryMethod</seealso>
    let hasDeliveryMethod =
        Prefixed_Name(fibo_fbc_fi_stl, "hasDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:hasPreferredSettlementCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has preferred settlement currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasPreferredSettlementCurrency">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasPreferredSettlementCurrency</seealso>
    let hasPreferredSettlementCurrency =
        Prefixed_Name(fibo_fbc_fi_stl, "hasPreferredSettlementCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:hasSettlementAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has settlement amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasSettlementAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasSettlementAmount</seealso>
    let hasSettlementAmount =
        Prefixed_Name(fibo_fbc_fi_stl, "hasSettlementAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:isFractionalEligible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is fractional eligible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFractionalEligible">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFractionalEligible</seealso>
    let isFractionalEligible =
        Prefixed_Name(fibo_fbc_fi_stl, "isFractionalEligible") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-stl:isFullyAutomatedSecuritiesTransferApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is fully automated securities transfer applicable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFullyAutomatedSecuritiesTransferApplicable">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFullyAutomatedSecuritiesTransferApplicable</seealso>
    let isFullyAutomatedSecuritiesTransferApplicable =
        Prefixed_Name(fibo_fbc_fi_stl, "isFullyAutomatedSecuritiesTransferApplicable") |> PrefixedName
