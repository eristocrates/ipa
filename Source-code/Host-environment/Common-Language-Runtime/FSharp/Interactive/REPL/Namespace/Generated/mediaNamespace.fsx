#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module media =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/media#" "media"
    /// <summary>
    ///   <para>rdfs:label : &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://purl.org/media#Collection" xml:lang="en"&gt;media:Collection&lt;/a&gt;^^rdf:XMLLiteral</para>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : A collection of
    ///             one or more media recordings.</para>
    ///   <a href="http://purl.org/media#Collection">media:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://purl.org/media#Recording" xml:lang="en"&gt;media:Recording&lt;/a&gt;^^rdf:XMLLiteral</para>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : A recording of an item of interest in any form.</para>
    ///   <a href="http://purl.org/media#Recording">media:Recording</a>
    /// </summary>
    let Recording = _prefixId.prefix "Recording"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : Relationship for
    ///             linking singular media recordings to collections or media recordings. Also used to denote pieces of a media recording that constitute a larger media recording..</para>
    ///   <a href="http://purl.org/media#contains">media:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : An image summary
    ///             of the media recording.</para>
    ///   <a href="http://purl.org/media#depiction">media:depiction</a>
    /// </summary>
    let depiction = _prefixId.prefix "depiction"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : A link to a
    ///             complete audio file representation of the media recording.</para>
    ///   <a href="http://purl.org/media#download">media:download</a>
    /// </summary>
    let download = _prefixId.prefix "download"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : The length of the
    ///             media recording encoded in ISO-8601 time duration format.</para>
    ///   <a href="http://purl.org/media#duration">media:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : The position of
    ///             the media recording in an album, LP, playlist, top 10 list,
    ///             podcast history or other ordered list of media recordings.</para>
    ///   <a href="http://purl.org/media#position">media:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : A standards-body
    ///             rating such as PG-13, M, 18-SX, 15, AV15+, Explicit Lyrics,
    ///             etc.</para>
    ///   <a href="http://purl.org/media#rating">media:rating</a>
    /// </summary>
    let rating = _prefixId.prefix "rating"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : A link to a
    ///             sample file or stream of the media recording.</para>
    ///   <a href="http://purl.org/media#sample">media:sample</a>
    /// </summary>
    let sample = _prefixId.prefix "sample"
