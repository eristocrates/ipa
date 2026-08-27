namespace http.dbpedia.org.ontology.Stream.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module stream =
    let _namespace_iri = Namespace_Iri stream |> NamespaceIRI
    /// <summary>
    ///   <para>planet:ontology/Stream/discharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"εκροή (m³/s)"</para><para>"discharge (m³/s)"</para><para>"uitstoot (m³/s)"</para></remarks>
    /// <seealso href="http://dbpedia.org/ontology/Stream/discharge">http://dbpedia.org/ontology/Stream/discharge</seealso>
    let discharge = Prefixed_Name(stream, "discharge") |> PrefixedName
    /// <summary>
    ///   <para>planet:ontology/Stream/dischargeAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"discharge average (m³/s)"</para></remarks>
    /// <seealso href="http://dbpedia.org/ontology/Stream/dischargeAverage">http://dbpedia.org/ontology/Stream/dischargeAverage</seealso>
    let dischargeAverage = Prefixed_Name(stream, "dischargeAverage") |> PrefixedName
    /// <summary>
    ///   <para>planet:ontology/Stream/maximumDischarge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"maximum discharge (m³/s)"</para></remarks>
    /// <seealso href="http://dbpedia.org/ontology/Stream/maximumDischarge">http://dbpedia.org/ontology/Stream/maximumDischarge</seealso>
    let maximumDischarge = Prefixed_Name(stream, "maximumDischarge") |> PrefixedName
    /// <summary>
    ///   <para>planet:ontology/Stream/minimumDischarge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"minimum discharge (m³/s)"</para></remarks>
    /// <seealso href="http://dbpedia.org/ontology/Stream/minimumDischarge">http://dbpedia.org/ontology/Stream/minimumDischarge</seealso>
    let minimumDischarge = Prefixed_Name(stream, "minimumDischarge") |> PrefixedName
    /// <summary>
    ///   <para>planet:ontology/Stream/watershed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"waterscheiding (km2)"</para><para>"λεκάνη_απορροής (km2)"</para><para>"watershed (km2)"</para><para>"cuenca hidrográfica (km2)"</para><para>"Wasserscheide (km2)"</para></remarks>
    /// <seealso href="http://dbpedia.org/ontology/Stream/watershed">http://dbpedia.org/ontology/Stream/watershed</seealso>
    let watershed = Prefixed_Name(stream, "watershed") |> PrefixedName
