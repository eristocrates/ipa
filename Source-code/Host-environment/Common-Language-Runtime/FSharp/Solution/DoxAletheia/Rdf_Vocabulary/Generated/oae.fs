namespace http.www.ics.forth.gr.isl.oae.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oae =
    let _namespace_iri = Namespace_Iri oae |> NamespaceIRI
    /// <summary>
    ///   <para>oae:detectedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>detected as</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#detectedAs">http://www.ics.forth.gr/isl/oae/core#detectedAs</seealso>
    let detectedAs = Prefixed_Name(oae, "detectedAs") |> PrefixedName
    /// <summary>
    ///   <para>oae:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entity</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#Entity">http://www.ics.forth.gr/isl/oae/core#Entity</seealso>
    let Entity = Prefixed_Name(oae, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>oae:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#belongsTo">http://www.ics.forth.gr/isl/oae/core#belongsTo</seealso>
    let belongsTo = Prefixed_Name(oae, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>oae:hasMatchedURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has matched URI</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#hasMatchedURI">http://www.ics.forth.gr/isl/oae/core#hasMatchedURI</seealso>
    let hasMatchedURI = Prefixed_Name(oae, "hasMatchedURI") |> PrefixedName
    /// <summary>
    ///   <para>oae:NEE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>oa:Motivation</para>
    ///
    /// labels<para>Named Entity Extraction (NEE)</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#NEE">http://www.ics.forth.gr/isl/oae/core#NEE</seealso>
    let NEE = Prefixed_Name(oae, "NEE") |> PrefixedName
    /// <summary>
    ///   <para>oae:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>position</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#position">http://www.ics.forth.gr/isl/oae/core#position</seealso>
    let position = Prefixed_Name(oae, "position") |> PrefixedName
    /// <summary>
    ///   <para>oae:score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>score</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#score">http://www.ics.forth.gr/isl/oae/core#score</seealso>
    let score = Prefixed_Name(oae, "score") |> PrefixedName
    /// <summary>
    ///   <para>oae:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>confidence</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#confidence">http://www.ics.forth.gr/isl/oae/core#confidence</seealso>
    let confidence = Prefixed_Name(oae, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>oae:regardsEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>regards entity name</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#regardsEntityName">http://www.ics.forth.gr/isl/oae/core#regardsEntityName</seealso>
    let regardsEntityName = Prefixed_Name(oae, "regardsEntityName") |> PrefixedName
    /// <summary>
    ///   <para>oae:usingConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>using configuration</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oae/core#usingConfiguration">http://www.ics.forth.gr/isl/oae/core#usingConfiguration</seealso>
    let usingConfiguration = Prefixed_Name(oae, "usingConfiguration") |> PrefixedName
