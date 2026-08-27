namespace http.www.w3.org._2008._05.skos.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module skos08 =
    let _namespace_iri = Namespace_Iri skos08 |> NamespaceIRI
    /// <summary>
    ///   <para>skos08:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#">http://www.w3.org/2008/05/skos#</seealso>
    let _prefix_iri = Prefixed_Name(skos08, "") |> PrefixedName
    /// <summary>
    ///   <para>skos08:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract idea or notion; a unit of thought."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#Concept">http://www.w3.org/2008/05/skos#Concept</seealso>
    let Concept = Prefixed_Name(skos08, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>skos08:ScopeNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#ScopeNote">http://www.w3.org/2008/05/skos#ScopeNote</seealso>
    let ScopeNote = Prefixed_Name(skos08, "ScopeNote") |> PrefixedName
    /// <summary>
    ///   <para>skos08:changeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#changeNote">http://www.w3.org/2008/05/skos#changeNote</seealso>
    let changeNote = Prefixed_Name(skos08, "changeNote") |> PrefixedName
    /// <summary>
    ///   <para>skos08:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#editorialNote">http://www.w3.org/2008/05/skos#editorialNote</seealso>
    let editorialNote = Prefixed_Name(skos08, "editorialNote") |> PrefixedName
    /// <summary>
    ///   <para>skos08:historyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#historyNote">http://www.w3.org/2008/05/skos#historyNote</seealso>
    let historyNote = Prefixed_Name(skos08, "historyNote") |> PrefixedName
    /// <summary>
    ///   <para>skos08:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"skos:note"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#note">http://www.w3.org/2008/05/skos#note</seealso>
    let note = Prefixed_Name(skos08, "note") |> PrefixedName
    /// <summary>
    ///   <para>skos08:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#prefLabel">http://www.w3.org/2008/05/skos#prefLabel</seealso>
    let prefLabel = Prefixed_Name(skos08, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos08:scopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos#scopeNote">http://www.w3.org/2008/05/skos#scopeNote</seealso>
    let scopeNote = Prefixed_Name(skos08, "scopeNote") |> PrefixedName
