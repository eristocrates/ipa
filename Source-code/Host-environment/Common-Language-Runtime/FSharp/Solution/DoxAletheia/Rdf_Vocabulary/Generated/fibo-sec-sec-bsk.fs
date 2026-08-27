namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.Baskets.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_bsk =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_bsk |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-bsk:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Baskets Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_bsk, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-bsk:BasketOfIndices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndices">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndices</seealso>
    let BasketOfIndices =
        Prefixed_Name(fibo_sec_sec_bsk, "BasketOfIndices") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-bsk:BasketOfIndicesConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket Of indices constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndicesConstituent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndicesConstituent</seealso>
    let BasketOfIndicesConstituent =
        Prefixed_Name(fibo_sec_sec_bsk, "BasketOfIndicesConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-bsk:BasketOfSecurities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of securities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfSecurities">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfSecurities</seealso>
    let BasketOfSecurities =
        Prefixed_Name(fibo_sec_sec_bsk, "BasketOfSecurities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-bsk:MixedBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mixed basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/MixedBasket">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/MixedBasket</seealso>
    let MixedBasket = Prefixed_Name(fibo_sec_sec_bsk, "MixedBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-bsk:SecuritiesBasketConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities basket constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/SecuritiesBasketConstituent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/SecuritiesBasketConstituent</seealso>
    let SecuritiesBasketConstituent =
        Prefixed_Name(fibo_sec_sec_bsk, "SecuritiesBasketConstituent") |> PrefixedName
