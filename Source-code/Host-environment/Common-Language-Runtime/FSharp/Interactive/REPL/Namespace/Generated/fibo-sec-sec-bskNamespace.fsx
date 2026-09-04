#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-bsk`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/" "fibo-sec-sec-bsk"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : market basket^^xsd:string</para>
    ///   <para>skos:definition : basket composed of market indices^^xsd:string</para>
    ///   <para>skos:example : For example, certain equities derivatives have an underlying basket which is a basket of more than one index, not a basket of securities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndices">fibo-sec-sec-bsk:BasketOfIndices</a>
    /// </summary>
    let BasketOfIndices = _prefixId.prefix "BasketOfIndices"
    /// <summary>
    ///   <para>rdfs:label : basket Of indices constituent^^xsd:string</para>
    ///   <para>skos:definition : single constituent of a basket of indices^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfIndicesConstituent">fibo-sec-sec-bsk:BasketOfIndicesConstituent</a>
    /// </summary>
    let BasketOfIndicesConstituent = _prefixId.prefix "BasketOfIndicesConstituent"
    /// <summary>
    ///   <para>rdfs:label : basket of securities^^xsd:string</para>
    ///   <para>skos:definition : basket composed of securities, typically of a particular asset class such as equities or bonds^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/BasketOfSecurities">fibo-sec-sec-bsk:BasketOfSecurities</a>
    /// </summary>
    let BasketOfSecurities = _prefixId.prefix "BasketOfSecurities"
    /// <summary>
    ///   <para>rdfs:label : mixed basket^^xsd:string</para>
    ///   <para>skos:definition : basket that has a mix of constituents, including securities and indices^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/MixedBasket">fibo-sec-sec-bsk:MixedBasket</a>
    /// </summary>
    let MixedBasket = _prefixId.prefix "MixedBasket"
    /// <summary>
    ///   <para>rdfs:label : securities basket constituent^^xsd:string</para>
    ///   <para>skos:definition : security identified as a component of a basket of securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/SecuritiesBasketConstituent">fibo-sec-sec-bsk:SecuritiesBasketConstituent</a>
    /// </summary>
    let SecuritiesBasketConstituent = _prefixId.prefix "SecuritiesBasketConstituent"
