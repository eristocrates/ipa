namespace http.iflastandards.info.ns.lrm.lrmoo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmoo =
    let _namespace_iri = Namespace_Iri lrmoo |> NamespaceIRI
    /// <summary>
    ///   <para>lrmoo:F1_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://iflastandards.info/ns/lrm/lrmoo/F1_Work">http://iflastandards.info/ns/lrm/lrmoo/F1_Work</seealso>
    let F1_Work = Prefixed_Name(lrmoo, "F1_Work") |> PrefixedName
    /// <summary>
    ///   <para>lrmoo:F2_Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://iflastandards.info/ns/lrm/lrmoo/F2_Expression">http://iflastandards.info/ns/lrm/lrmoo/F2_Expression</seealso>
    let F2_Expression = Prefixed_Name(lrmoo, "F2_Expression") |> PrefixedName
    /// <summary>
    ///   <para>lrmoo:F31_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://iflastandards.info/ns/lrm/lrmoo/F31_Performance">http://iflastandards.info/ns/lrm/lrmoo/F31_Performance</seealso>
    let F31_Performance = Prefixed_Name(lrmoo, "F31_Performance") |> PrefixedName
    /// <summary>
    ///   <para>lrmoo:F3_Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://iflastandards.info/ns/lrm/lrmoo/F3_Manifestation">http://iflastandards.info/ns/lrm/lrmoo/F3_Manifestation</seealso>
    let F3_Manifestation = Prefixed_Name(lrmoo, "F3_Manifestation") |> PrefixedName

    /// <summary>
    ///   <para>lrmoo:R76_is_derivative_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://iflastandards.info/ns/lrm/lrmoo/R76_is_derivative_of">http://iflastandards.info/ns/lrm/lrmoo/R76_is_derivative_of</seealso>
    let R76_is_derivative_of =
        Prefixed_Name(lrmoo, "R76_is_derivative_of") |> PrefixedName
