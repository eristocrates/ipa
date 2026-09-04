#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pbo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/pbo/core#" "pbo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Fixed Playlist</para>
    ///   <para>rdfs:comment : A (sub) playlist of a fixed length and a fixed order. This concept should be used to express static relations,
    /// e.g. "those three music tracks must always be played in a row".</para>
    ///   <a href="http://purl.org/ontology/pbo/core#FixedPlaylist">pbo:FixedPlaylist</a>
    /// </summary>
    let FixedPlaylist = _prefixId.prefix "FixedPlaylist"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Media Action Counter</para>
    ///   <para>rdfs:comment : A media action counter. Media actions are for example play back or skip events.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/pbo/core#MediaActionCounter">pbo:MediaActionCounter</a>
    /// </summary>
    let MediaActionCounter = _prefixId.prefix "MediaActionCounter"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Play Back Counter</para>
    ///   <para>rdfs:comment : A play back counter, e.g. to count the playback of a media object.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/pbo/core#PlayBackCounter">pbo:PlayBackCounter</a>
    /// </summary>
    let PlayBackCounter = _prefixId.prefix "PlayBackCounter"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Playlist</para>
    ///   <para>rdfs:comment : A playlist of specific media items, e.g. music tracks, videos or slides.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#Playlist">pbo:Playlist</a>
    /// </summary>
    let Playlist = _prefixId.prefix "Playlist"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Playlist Slot</para>
    ///   <para>rdfs:comment : A playlist slot. It could contain e.g. a music track, a video or a slide, and maybe related with some
    /// additional properties. However, it could maybe also included a "sub" playlist, e.g. to keep a fixed sequence of some tracks.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#PlaylistSlot">pbo:PlaylistSlot</a>
    /// </summary>
    let PlaylistSlot = _prefixId.prefix "PlaylistSlot"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Skip Counter^^xsd:string</para>
    ///   <para>rdfs:comment : A skip counter, e.g. to count skip events of a media object.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/pbo/core#SkipCounter">pbo:SkipCounter</a>
    /// </summary>
    let SkipCounter = _prefixId.prefix "SkipCounter"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Skip Event^^xsd:string</para>
    ///   <para>rdfs:comment : A specific skip event of something.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/pbo/core#SkipEvent">pbo:SkipEvent</a>
    /// </summary>
    let SkipEvent = _prefixId.prefix "SkipEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has media object</para>
    ///   <para>rdfs:comment : Associates a media object to its related counter.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#media_object">pbo:media_object</a>
    /// </summary>
    let media_object = _prefixId.prefix "media_object"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has media scrobble object</para>
    ///   <para>rdfs:comment : A media specific scrobble object, e.g. a music track or a video.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#media_scrobble_object">pbo:media_scrobble_object</a>
    /// </summary>
    let media_scrobble_object = _prefixId.prefix "media_scrobble_object"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has playlist</para>
    ///   <para>rdfs:comment : Associates a playlist to something.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#playlist">pbo:playlist</a>
    /// </summary>
    let playlist = _prefixId.prefix "playlist"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has playlist item</para>
    ///   <para>rdfs:comment : A specific playlist item, e.g. a music track, video or slides. The range types of this property must be
    /// based on bibo:Document or frbr:Endeavour (to keep it somehow media based).</para>
    ///   <a href="http://purl.org/ontology/pbo/core#playlist_item">pbo:playlist_item</a>
    /// </summary>
    let playlist_item = _prefixId.prefix "playlist_item"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has playlist slot</para>
    ///   <para>rdfs:comment : A specific slot in a playlist.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#playlist_slot">pbo:playlist_slot</a>
    /// </summary>
    let playlist_slot = _prefixId.prefix "playlist_slot"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has skip time^^xsd:string</para>
    ///   <para>rdfs:comment : The moment, when someone skipped the media object, e.g. an instant of a timeline of an audio signal.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/pbo/core#skip_time">pbo:skip_time</a>
    /// </summary>
    let skip_time = _prefixId.prefix "skip_time"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has transition</para>
    ///   <para>rdfs:comment : This relation directs to a description of a transition between two neighbouring playlist slots, e.g. two successive music tracks in a dj mix.</para>
    ///   <a href="http://purl.org/ontology/pbo/core#transition">pbo:transition</a>
    /// </summary>
    let transition = _prefixId.prefix "transition"
