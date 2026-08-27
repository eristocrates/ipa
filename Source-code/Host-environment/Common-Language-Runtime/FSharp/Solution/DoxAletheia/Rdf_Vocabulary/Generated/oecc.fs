namespace http.www.oegov.org.core.owl.cc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oecc =
    let _namespace_iri = Namespace_Iri oecc |> NamespaceIRI
    /// <summary>
    ///   <para>oecc:AttributedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name, url and other details of an attribution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attributed Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#AttributedSource">http://www.oegov.org/core/owl/cc#AttributedSource</seealso>
    let AttributedSource = Prefixed_Name(oecc, "AttributedSource") |> PrefixedName

    /// <summary>
    ///   <para>oecc:CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:License</para>
    ///
    /// labels<para>"Creative Commons Attribution-Share Alike 3.0 United States License"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense">http://www.oegov.org/core/owl/cc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense</seealso>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        Prefixed_Name(oecc, "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense") |> PrefixedName

    /// <summary>
    ///   <para>oecc:TopQuadrantAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>oecc:AttributedSource</para>
    ///
    /// labels<para>"TopQuadrant attribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#TopQuadrantAttribution">http://www.oegov.org/core/owl/cc#TopQuadrantAttribution</seealso>
    let TopQuadrantAttribution =
        Prefixed_Name(oecc, "TopQuadrantAttribution") |> PrefixedName

    /// <summary>
    ///   <para>oecc:attributedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"attributed source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#attributedSource">http://www.oegov.org/core/owl/cc#attributedSource</seealso>
    let attributedSource = Prefixed_Name(oecc, "attributedSource") |> PrefixedName
    /// <summary>
    ///   <para>oecc:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#image">http://www.oegov.org/core/owl/cc#image</seealso>
    let image = Prefixed_Name(oecc, "image") |> PrefixedName
    /// <summary>
    ///   <para>oecc:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"licence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#licence">http://www.oegov.org/core/owl/cc#licence</seealso>
    let licence = Prefixed_Name(oecc, "licence") |> PrefixedName
    /// <summary>
    ///   <para>oecc:pointOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"point of contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#pointOfContact">http://www.oegov.org/core/owl/cc#pointOfContact</seealso>
    let pointOfContact = Prefixed_Name(oecc, "pointOfContact") |> PrefixedName
    /// <summary>
    ///   <para>oecc:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#revision">http://www.oegov.org/core/owl/cc#revision</seealso>
    let revision = Prefixed_Name(oecc, "revision") |> PrefixedName
    /// <summary>
    ///   <para>oecc:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.oegov.org/core/owl/cc#url">http://www.oegov.org/core/owl/cc#url</seealso>
    let url = Prefixed_Name(oecc, "url") |> PrefixedName
