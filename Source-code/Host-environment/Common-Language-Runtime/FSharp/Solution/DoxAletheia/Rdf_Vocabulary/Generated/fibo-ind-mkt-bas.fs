namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.BasketIndices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_mkt_bas =
    let _namespace_iri = Namespace_Iri fibo_ind_mkt_bas |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-mkt-bas:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Basket Indices Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_mkt_bas, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:BasketOfCreditRisks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of credit risks"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfCreditRisks">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfCreditRisks</seealso>
    let BasketOfCreditRisks =
        Prefixed_Name(fibo_ind_mkt_bas, "BasketOfCreditRisks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:BasketOfEquities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of equities"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfEquities">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfEquities</seealso>
    let BasketOfEquities =
        Prefixed_Name(fibo_ind_mkt_bas, "BasketOfEquities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:CapitalizationBasedWeightingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capitalization-based weighting function"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CapitalizationBasedWeightingFunction">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CapitalizationBasedWeightingFunction</seealso>
    let CapitalizationBasedWeightingFunction =
        Prefixed_Name(fibo_ind_mkt_bas, "CapitalizationBasedWeightingFunction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:CreditIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit index"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndex">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndex</seealso>
    let CreditIndex = Prefixed_Name(fibo_ind_mkt_bas, "CreditIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:CreditIndexConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit index constituent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndexConstituent">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndexConstituent</seealso>
    let CreditIndexConstituent =
        Prefixed_Name(fibo_ind_mkt_bas, "CreditIndexConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:EquityIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity index"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/EquityIndex">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/EquityIndex</seealso>
    let EquityIndex = Prefixed_Name(fibo_ind_mkt_bas, "EquityIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:MarketCapitalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market capitalization"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/MarketCapitalization">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/MarketCapitalization</seealso>
    let MarketCapitalization =
        Prefixed_Name(fibo_ind_mkt_bas, "MarketCapitalization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:ReferenceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reference index"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/ReferenceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/ReferenceIndex</seealso>
    let ReferenceIndex =
        Prefixed_Name(fibo_ind_mkt_bas, "ReferenceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasDebtRanking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has debt ranking"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasDebtRanking">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasDebtRanking</seealso>
    let hasDebtRanking =
        Prefixed_Name(fibo_ind_mkt_bas, "hasDebtRanking") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasIndexName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has index name"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexName">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexName</seealso>
    let hasIndexName = Prefixed_Name(fibo_ind_mkt_bas, "hasIndexName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasIndexValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has index value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexValue">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexValue</seealso>
    let hasIndexValue = Prefixed_Name(fibo_ind_mkt_bas, "hasIndexValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasMarketCapitalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has market capitalization"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalization">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalization</seealso>
    let hasMarketCapitalization =
        Prefixed_Name(fibo_ind_mkt_bas, "hasMarketCapitalization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasMarketCapitalizationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has market capitalization value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalizationValue">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalizationValue</seealso>
    let hasMarketCapitalizationValue =
        Prefixed_Name(fibo_ind_mkt_bas, "hasMarketCapitalizationValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasOriginalNotionalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has original notional value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasOriginalNotionalValue">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasOriginalNotionalValue</seealso>
    let hasOriginalNotionalValue =
        Prefixed_Name(fibo_ind_mkt_bas, "hasOriginalNotionalValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has premium"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasPremium">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasPremium</seealso>
    let hasPremium = Prefixed_Name(fibo_ind_mkt_bas, "hasPremium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasSpreadRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has spread range"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasSpreadRange">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasSpreadRange</seealso>
    let hasSpreadRange =
        Prefixed_Name(fibo_ind_mkt_bas, "hasSpreadRange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-bas:hasUpFrontFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has up front fee"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasUpFrontFee">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasUpFrontFee</seealso>
    let hasUpFrontFee = Prefixed_Name(fibo_ind_mkt_bas, "hasUpFrontFee") |> PrefixedName
