#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ccp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccpricing#" "ccp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:description : .</para>
    ///   <para>rdfs:label : Compound</para>
    ///   <para>rdfs:comment : Compound</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#PriceCompound">ccp:PriceCompound</a>
    /// </summary>
    let PriceCompound = _prefixId.prefix "PriceCompound"
    /// <summary>
    ///   <para>dcterms:description : .</para>
    ///   <para>rdfs:label : Prcing Plan</para>
    ///   <para>rdfs:comment : PricingPlan</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#PricingPlan">ccp:PricingPlan</a>
    /// </summary>
    let PricingPlan = _prefixId.prefix "PricingPlan"
    let ServicePricing = _prefixId.prefix "ServicePricing"
    let cookingbigdata = _prefixId.prefix "cookingbigdata"
    /// <summary>
    ///   <para>rdfs:label : Component price</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#hasPrice">ccp:hasPrice</a>
    /// </summary>
    let hasPrice = _prefixId.prefix "hasPrice"
    /// <summary>
    ///   <para>rdfs:label : has Component price</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#hasPriceCompound">ccp:hasPriceCompound</a>
    /// </summary>
    let hasPriceCompound = _prefixId.prefix "hasPriceCompound"
    /// <summary>
    ///   <para>rdfs:label : Has pricing</para>
    ///   <para>rdfs:comment : Has pricing plans</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#hasPricingPlan">ccp:hasPricingPlan</a>
    /// </summary>
    let hasPricingPlan = _prefixId.prefix "hasPricingPlan"
    /// <summary>
    ///   <para>rdfs:label : Instance</para>
    ///   <para>rdfs:comment : Instance</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#instance">ccp:instance</a>
    /// </summary>
    let instance = _prefixId.prefix "instance"
    let manuelparra = _prefixId.prefix "manuelparra"
    /// <summary>
    ///   <para>rdfs:label : Plan Name</para>
    ///   <para>rdfs:comment : Example Free</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#plan_name">ccp:plan_name</a>
    /// </summary>
    let plan_name = _prefixId.prefix "plan_name"
    /// <summary>
    ///   <para>rdfs:label : Region</para>
    ///   <para>rdfs:comment : Region</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#region">ccp:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : Max compound</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxCompound">ccp:withMaxCompound</a>
    /// </summary>
    let withMaxCompound = _prefixId.prefix "withMaxCompound"
    /// <summary>
    ///   <para>rdfs:label : Max price</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxPrice">ccp:withMaxPrice</a>
    /// </summary>
    let withMaxPrice = _prefixId.prefix "withMaxPrice"
    /// <summary>
    ///   <para>rdfs:label : Min compound</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#withMinCompound">ccp:withMinCompound</a>
    /// </summary>
    let withMinCompound = _prefixId.prefix "withMinCompound"
    /// <summary>
    ///   <para>rdfs:label : Min price</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccpricing#withMinPrice">ccp:withMinPrice</a>
    /// </summary>
    let withMinPrice = _prefixId.prefix "withMinPrice"
