namespace http.purl.org.voc.summa.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module summa =
    let _namespace_iri = Namespace_Iri summa |> NamespaceIRI
    /// <summary>
    ///   <para>summa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>summa</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/">http://purl.org/voc/summa/</seealso>
    let _prefix_iri = Prefixed_Name(summa, "") |> PrefixedName
    /// <summary>
    ///   <para>summa:SummaryGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>summary group</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/SummaryGroup">http://purl.org/voc/summa/SummaryGroup</seealso>
    let SummaryGroup = Prefixed_Name(summa, "SummaryGroup") |> PrefixedName
    /// <summary>
    ///   <para>summa:fixedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>fixed property</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/fixedProperty">http://purl.org/voc/summa/fixedProperty</seealso>
    let fixedProperty = Prefixed_Name(summa, "fixedProperty") |> PrefixedName
    /// <summary>
    ///   <para>summa:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>langauge</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/language">http://purl.org/voc/summa/language</seealso>
    let language = Prefixed_Name(summa, "language") |> PrefixedName
    /// <summary>
    ///   <para>summa:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>statement</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/statement">http://purl.org/voc/summa/statement</seealso>
    let statement = Prefixed_Name(summa, "statement") |> PrefixedName
    /// <summary>
    ///   <para>summa:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>entity</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/entity">http://purl.org/voc/summa/entity</seealso>
    let entity = Prefixed_Name(summa, "entity") |> PrefixedName
    /// <summary>
    ///   <para>summa:topK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>top k</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/topK">http://purl.org/voc/summa/topK</seealso>
    let topK = Prefixed_Name(summa, "topK") |> PrefixedName
    /// <summary>
    ///   <para>summa:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>path</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/path">http://purl.org/voc/summa/path</seealso>
    let path = Prefixed_Name(summa, "path") |> PrefixedName
    /// <summary>
    ///   <para>summa:Summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>summary</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/Summary">http://purl.org/voc/summa/Summary</seealso>
    let Summary = Prefixed_Name(summa, "Summary") |> PrefixedName
    /// <summary>
    ///   <para>summa:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>group</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/group">http://purl.org/voc/summa/group</seealso>
    let group = Prefixed_Name(summa, "group") |> PrefixedName
    /// <summary>
    ///   <para>summa:maxHops</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maximum number of hops</para></remarks>
    /// <seealso href="http://purl.org/voc/summa/maxHops">http://purl.org/voc/summa/maxHops</seealso>
    let maxHops = Prefixed_Name(summa, "maxHops") |> PrefixedName
