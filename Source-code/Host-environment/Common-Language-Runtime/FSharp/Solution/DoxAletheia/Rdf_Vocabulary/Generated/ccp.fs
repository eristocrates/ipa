namespace http.cookingbigdata.com.linkeddata.ccpricing.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ccp =
    let _namespace_iri = Namespace_Iri ccp |> NamespaceIRI
    /// <summary>
    ///   <para>ccp:PriceCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Compound</para>
    /// labels<para>Compound</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#PriceCompound">http://cookingbigdata.com/linkeddata/ccpricing#PriceCompound</seealso>
    let PriceCompound = Prefixed_Name(ccp, "PriceCompound") |> PrefixedName
    /// <summary>
    ///   <para>ccp:manuelparra</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#manuelparra">http://cookingbigdata.com/linkeddata/ccpricing#manuelparra</seealso>
    let manuelparra = Prefixed_Name(ccp, "manuelparra") |> PrefixedName
    /// <summary>
    ///   <para>ccp:PricingPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>PricingPlan</para>
    /// labels<para>Prcing Plan</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#PricingPlan">http://cookingbigdata.com/linkeddata/ccpricing#PricingPlan</seealso>
    let PricingPlan = Prefixed_Name(ccp, "PricingPlan") |> PrefixedName
    /// <summary>
    ///   <para>ccp:hasPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>Component price</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#hasPrice">http://cookingbigdata.com/linkeddata/ccpricing#hasPrice</seealso>
    let hasPrice = Prefixed_Name(ccp, "hasPrice") |> PrefixedName
    /// <summary>
    ///   <para>ccp:hasPriceCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>has Component price</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#hasPriceCompound">http://cookingbigdata.com/linkeddata/ccpricing#hasPriceCompound</seealso>
    let hasPriceCompound = Prefixed_Name(ccp, "hasPriceCompound") |> PrefixedName
    /// <summary>
    ///   <para>ccp:ServicePricing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#ServicePricing">http://cookingbigdata.com/linkeddata/ccpricing#ServicePricing</seealso>
    let ServicePricing = Prefixed_Name(ccp, "ServicePricing") |> PrefixedName
    /// <summary>
    ///   <para>ccp:hasPricingPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Has pricing plans</para>
    /// labels<para>Has pricing</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#hasPricingPlan">http://cookingbigdata.com/linkeddata/ccpricing#hasPricingPlan</seealso>
    let hasPricingPlan = Prefixed_Name(ccp, "hasPricingPlan") |> PrefixedName
    /// <summary>
    ///   <para>ccp:withMaxCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>Max compound</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxCompound">http://cookingbigdata.com/linkeddata/ccpricing#withMaxCompound</seealso>
    let withMaxCompound = Prefixed_Name(ccp, "withMaxCompound") |> PrefixedName
    /// <summary>
    ///   <para>ccp:withMinPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>Min price</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#withMinPrice">http://cookingbigdata.com/linkeddata/ccpricing#withMinPrice</seealso>
    let withMinPrice = Prefixed_Name(ccp, "withMinPrice") |> PrefixedName
    /// <summary>
    ///   <para>ccp:instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Instance</para>
    /// labels<para>Instance</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#instance">http://cookingbigdata.com/linkeddata/ccpricing#instance</seealso>
    let instance = Prefixed_Name(ccp, "instance") |> PrefixedName
    /// <summary>
    ///   <para>ccp:plan_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Example Free</para>
    /// labels<para>Plan Name</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#plan_name">http://cookingbigdata.com/linkeddata/ccpricing#plan_name</seealso>
    let plan_name = Prefixed_Name(ccp, "plan_name") |> PrefixedName
    /// <summary>
    ///   <para>ccp:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Region</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#region">http://cookingbigdata.com/linkeddata/ccpricing#region</seealso>
    let region = Prefixed_Name(ccp, "region") |> PrefixedName
    /// <summary>
    ///   <para>ccp:withMaxPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>Max price</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#withMaxPrice">http://cookingbigdata.com/linkeddata/ccpricing#withMaxPrice</seealso>
    let withMaxPrice = Prefixed_Name(ccp, "withMaxPrice") |> PrefixedName
    /// <summary>
    ///   <para>ccp:withMinCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>Min compound</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#withMinCompound">http://cookingbigdata.com/linkeddata/ccpricing#withMinCompound</seealso>
    let withMinCompound = Prefixed_Name(ccp, "withMinCompound") |> PrefixedName
    /// <summary>
    ///   <para>ccp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Pricing Plan for Cloud Computing Services</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#">http://cookingbigdata.com/linkeddata/ccpricing#</seealso>
    let _prefix_iri = Prefixed_Name(ccp, "") |> PrefixedName
    /// <summary>
    ///   <para>ccp:cookingbigdata</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccpricing#cookingbigdata">http://cookingbigdata.com/linkeddata/ccpricing#cookingbigdata</seealso>
    let cookingbigdata = Prefixed_Name(ccp, "cookingbigdata") |> PrefixedName
