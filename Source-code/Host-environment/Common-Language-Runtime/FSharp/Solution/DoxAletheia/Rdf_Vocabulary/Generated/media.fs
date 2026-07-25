namespace http.purl.org.media.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module media =
    let _namespace_iri = Namespace_Iri media |> NamespaceIRI
    /// <summary>
    ///   <para>media:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of
    ///             one or more media recordings.</para>
    /// labels<para>&lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://purl.org/media#Collection" xml:lang="en"&gt;media:Collection&lt;/a&gt;</para></remarks>
    /// <seealso href="http://purl.org/media#Collection">http://purl.org/media#Collection</seealso>
    let Collection = Prefixed_Name(media, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>media:Recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A recording of an item of interest in any form.</para>
    /// labels<para>&lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://purl.org/media#Recording" xml:lang="en"&gt;media:Recording&lt;/a&gt;</para></remarks>
    /// <seealso href="http://purl.org/media#Recording">http://purl.org/media#Recording</seealso>
    let Recording = Prefixed_Name(media, "Recording") |> PrefixedName
    /// <summary>
    ///   <para>media:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship for
    ///             linking singular media recordings to collections or media recordings. Also used to denote pieces of a media recording that constitute a larger media recording..</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#contains">http://purl.org/media#contains</seealso>
    let contains = Prefixed_Name(media, "contains") |> PrefixedName
    /// <summary>
    ///   <para>media:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An image summary
    ///             of the media recording.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#depiction">http://purl.org/media#depiction</seealso>
    let depiction = Prefixed_Name(media, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>media:download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A link to a
    ///             complete audio file representation of the media recording.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#download">http://purl.org/media#download</seealso>
    let download = Prefixed_Name(media, "download") |> PrefixedName
    /// <summary>
    ///   <para>media:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The length of the
    ///             media recording encoded in ISO-8601 time duration format.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#duration">http://purl.org/media#duration</seealso>
    let duration = Prefixed_Name(media, "duration") |> PrefixedName
    /// <summary>
    ///   <para>media:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The position of
    ///             the media recording in an album, LP, playlist, top 10 list,
    ///             podcast history or other ordered list of media recordings.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#position">http://purl.org/media#position</seealso>
    let position = Prefixed_Name(media, "position") |> PrefixedName
    /// <summary>
    ///   <para>media:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A standards-body
    ///             rating such as PG-13, M, 18-SX, 15, AV15+, Explicit Lyrics,
    ///             etc.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#rating">http://purl.org/media#rating</seealso>
    let rating = Prefixed_Name(media, "rating") |> PrefixedName
    /// <summary>
    ///   <para>media:sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A link to a
    ///             sample file or stream of the media recording.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/media#sample">http://purl.org/media#sample</seealso>
    let sample = Prefixed_Name(media, "sample") |> PrefixedName
