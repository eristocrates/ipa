namespace http.purl.org.LiMo._0._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module limoo =
    let _namespace_iri = Namespace_Iri limoo |> NamespaceIRI

    /// <summary>
    ///   <para>limoo:shareAlikeCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#shareAlikeCondition">http://purl.org/LiMo/0.1#shareAlikeCondition</seealso>
    let shareAlikeCondition =
        Prefixed_Name(limoo, "shareAlikeCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:nonCommercialCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#nonCommercialCondition">http://purl.org/LiMo/0.1#nonCommercialCondition</seealso>
    let nonCommercialCondition =
        Prefixed_Name(limoo, "nonCommercialCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:nonDerivativeWorksCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#nonDerivativeWorksCondition">http://purl.org/LiMo/0.1#nonDerivativeWorksCondition</seealso>
    let nonDerivativeWorksCondition =
        Prefixed_Name(limoo, "nonDerivativeWorksCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:createCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#createCondition">http://purl.org/LiMo/0.1#createCondition</seealso>
    let createCondition = Prefixed_Name(limoo, "createCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:attributionCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#attributionCondition">http://purl.org/LiMo/0.1#attributionCondition</seealso>
    let attributionCondition =
        Prefixed_Name(limoo, "attributionCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:shareCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#shareCondition">http://purl.org/LiMo/0.1#shareCondition</seealso>
    let shareCondition = Prefixed_Name(limoo, "shareCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:noCopyrightCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#noCopyrightCondition">http://purl.org/LiMo/0.1#noCopyrightCondition</seealso>
    let noCopyrightCondition =
        Prefixed_Name(limoo, "noCopyrightCondition") |> PrefixedName

    /// <summary>
    ///   <para>limoo:remixCondition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#remixCondition">http://purl.org/LiMo/0.1#remixCondition</seealso>
    let remixCondition = Prefixed_Name(limoo, "remixCondition") |> PrefixedName
    /// <summary>
    ///   <para>limoo:compatibleWith</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1#compatibleWith">http://purl.org/LiMo/0.1#compatibleWith</seealso>
    let compatibleWith = Prefixed_Name(limoo, "compatibleWith") |> PrefixedName
