namespace http.purl.org.ontology.pbo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pbo =
    let _namespace_iri = Namespace_Iri pbo |> NamespaceIRI
    /// <summary>
    ///   <para>pbo:MediaActionCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A media action counter. Media actions are for example play back or skip events.</para>
    /// labels<para>Media Action Counter</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#MediaActionCounter">http://purl.org/ontology/pbo/core#MediaActionCounter</seealso>
    let MediaActionCounter = Prefixed_Name(pbo, "MediaActionCounter") |> PrefixedName
    /// <summary>
    ///   <para>pbo:SkipCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A skip counter, e.g. to count skip events of a media object.</para>
    /// labels<para>Skip Counter</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#SkipCounter">http://purl.org/ontology/pbo/core#SkipCounter</seealso>
    let SkipCounter = Prefixed_Name(pbo, "SkipCounter") |> PrefixedName
    /// <summary>
    ///   <para>pbo:transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation directs to a description of a transition between two neighbouring playlist slots, e.g. two successive music tracks in a dj mix.</para>
    /// labels<para>has transition</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#transition">http://purl.org/ontology/pbo/core#transition</seealso>
    let transition = Prefixed_Name(pbo, "transition") |> PrefixedName
    /// <summary>
    ///   <para>pbo:FixedPlaylist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A (sub) playlist of a fixed length and a fixed order. This concept should be used to express static relations,
    /// e.g. "those three music tracks must always be played in a row".</para>
    /// labels<para>Fixed Playlist</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#FixedPlaylist">http://purl.org/ontology/pbo/core#FixedPlaylist</seealso>
    let FixedPlaylist = Prefixed_Name(pbo, "FixedPlaylist") |> PrefixedName
    /// <summary>
    ///   <para>pbo:PlayBackCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A play back counter, e.g. to count the playback of a media object.</para>
    /// labels<para>Play Back Counter</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#PlayBackCounter">http://purl.org/ontology/pbo/core#PlayBackCounter</seealso>
    let PlayBackCounter = Prefixed_Name(pbo, "PlayBackCounter") |> PrefixedName
    /// <summary>
    ///   <para>pbo:PlaylistSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A playlist slot. It could contain e.g. a music track, a video or a slide, and maybe related with some
    /// additional properties. However, it could maybe also included a "sub" playlist, e.g. to keep a fixed sequence of some tracks.</para>
    /// labels<para>Playlist Slot</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#PlaylistSlot">http://purl.org/ontology/pbo/core#PlaylistSlot</seealso>
    let PlaylistSlot = Prefixed_Name(pbo, "PlaylistSlot") |> PrefixedName
    /// <summary>
    ///   <para>pbo:SkipEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific skip event of something.</para>
    /// labels<para>Skip Event</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#SkipEvent">http://purl.org/ontology/pbo/core#SkipEvent</seealso>
    let SkipEvent = Prefixed_Name(pbo, "SkipEvent") |> PrefixedName
    /// <summary>
    ///   <para>pbo:media_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a media object to its related counter.</para>
    /// labels<para>has media object</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#media_object">http://purl.org/ontology/pbo/core#media_object</seealso>
    let media_object = Prefixed_Name(pbo, "media_object") |> PrefixedName

    /// <summary>
    ///   <para>pbo:media_scrobble_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A media specific scrobble object, e.g. a music track or a video.</para>
    /// labels<para>has media scrobble object</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#media_scrobble_object">http://purl.org/ontology/pbo/core#media_scrobble_object</seealso>
    let media_scrobble_object =
        Prefixed_Name(pbo, "media_scrobble_object") |> PrefixedName

    /// <summary>
    ///   <para>pbo:Playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A playlist of specific media items, e.g. music tracks, videos or slides.</para>
    /// labels<para>Playlist</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#Playlist">http://purl.org/ontology/pbo/core#Playlist</seealso>
    let Playlist = Prefixed_Name(pbo, "Playlist") |> PrefixedName
    /// <summary>
    ///   <para>pbo:playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a playlist to something.</para>
    /// labels<para>has playlist</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#playlist">http://purl.org/ontology/pbo/core#playlist</seealso>
    let playlist = Prefixed_Name(pbo, "playlist") |> PrefixedName
    /// <summary>
    ///   <para>pbo:playlist_slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A specific slot in a playlist.</para>
    /// labels<para>has playlist slot</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#playlist_slot">http://purl.org/ontology/pbo/core#playlist_slot</seealso>
    let playlist_slot = Prefixed_Name(pbo, "playlist_slot") |> PrefixedName
    /// <summary>
    ///   <para>pbo:skip_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The moment, when someone skipped the media object, e.g. an instant of a timeline of an audio signal.</para>
    /// labels<para>has skip time</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#skip_time">http://purl.org/ontology/pbo/core#skip_time</seealso>
    let skip_time = Prefixed_Name(pbo, "skip_time") |> PrefixedName
    /// <summary>
    ///   <para>pbo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#">http://purl.org/ontology/pbo/core#</seealso>
    let _prefix_iri = Prefixed_Name(pbo, "") |> PrefixedName
    /// <summary>
    ///   <para>pbo:playlist_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A specific playlist item, e.g. a music track, video or slides. The range types of this property must be
    /// based on bibo:Document or frbr:Endeavour (to keep it somehow media based).</para>
    /// labels<para>has playlist item</para></remarks>
    /// <seealso href="http://purl.org/ontology/pbo/core#playlist_item">http://purl.org/ontology/pbo/core#playlist_item</seealso>
    let playlist_item = Prefixed_Name(pbo, "playlist_item") |> PrefixedName
