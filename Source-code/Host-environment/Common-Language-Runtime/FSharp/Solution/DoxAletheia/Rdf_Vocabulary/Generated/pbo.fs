namespace http.purl.org.ontology.pbo.core.hash

open DoxAletheia.Rdf_Vocabulary

module pbo =
    let _namespace_name = "http://purl.org/ontology/pbo/core#"

    /// <summary>
    /// A (sub) playlist of a fixed length and a fixed order. This concept should be used to express static relations,
    /// e.g. "those three music tracks must always be played in a row".
    /// <see href="http://purl.org/ontology/pbo/core#FixedPlaylist"></see></summary>
    let FixedPlaylist =
        Namespaced_IRI.parse _namespace_name "FixedPlaylist" |> NamespacedName

    /// <summary>
    /// A playlist of specific media items, e.g. music tracks, videos or slides.
    /// <see href="http://purl.org/ontology/pbo/core#Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName

    /// <summary>
    /// A media action counter. Media actions are for example play back or skip events.
    /// <see href="http://purl.org/ontology/pbo/core#MediaActionCounter"></see></summary>
    let MediaActionCounter =
        Namespaced_IRI.parse _namespace_name "MediaActionCounter" |> NamespacedName

    /// <summary>
    /// A play back counter, e.g. to count the playback of a media object.
    /// <see href="http://purl.org/ontology/pbo/core#PlayBackCounter"></see></summary>
    let PlayBackCounter =
        Namespaced_IRI.parse _namespace_name "PlayBackCounter" |> NamespacedName

    /// <summary>
    /// A playlist slot. It could contain e.g. a music track, a video or a slide, and maybe related with some
    /// additional properties. However, it could maybe also included a "sub" playlist, e.g. to keep a fixed sequence of some tracks.
    /// <see href="http://purl.org/ontology/pbo/core#PlaylistSlot"></see></summary>
    let PlaylistSlot =
        Namespaced_IRI.parse _namespace_name "PlaylistSlot" |> NamespacedName

    /// <summary>
    /// A specific playlist item, e.g. a music track, video or slides. The range types of this property must be
    /// based on bibo:Document or frbr:Endeavour (to keep it somehow media based).
    /// <see href="http://purl.org/ontology/pbo/core#playlist_item"></see></summary>
    let playlist_item =
        Namespaced_IRI.parse _namespace_name "playlist_item" |> NamespacedName

    /// <summary>
    /// A skip counter, e.g. to count skip events of a media object.
    /// <see href="http://purl.org/ontology/pbo/core#SkipCounter"></see></summary>
    let SkipCounter =
        Namespaced_IRI.parse _namespace_name "SkipCounter" |> NamespacedName

    /// <summary>
    /// A specific skip event of something.
    /// <see href="http://purl.org/ontology/pbo/core#SkipEvent"></see></summary>
    let SkipEvent = Namespaced_IRI.parse _namespace_name "SkipEvent" |> NamespacedName

    /// <summary>
    /// Associates a media object to its related counter.
    /// <see href="http://purl.org/ontology/pbo/core#media_object"></see></summary>
    let media_object =
        Namespaced_IRI.parse _namespace_name "media_object" |> NamespacedName

    /// <summary>
    /// A media specific scrobble object, e.g. a music track or a video.
    /// <see href="http://purl.org/ontology/pbo/core#media_scrobble_object"></see></summary>
    let media_scrobble_object =
        Namespaced_IRI.parse _namespace_name "media_scrobble_object" |> NamespacedName

    /// <summary>
    /// Associates a playlist to something.
    /// <see href="http://purl.org/ontology/pbo/core#playlist"></see></summary>
    let playlist = Namespaced_IRI.parse _namespace_name "playlist" |> NamespacedName

    /// <summary>
    /// A specific slot in a playlist.
    /// <see href="http://purl.org/ontology/pbo/core#playlist_slot"></see></summary>
    let playlist_slot =
        Namespaced_IRI.parse _namespace_name "playlist_slot" |> NamespacedName

    /// <summary>
    /// The moment, when someone skipped the media object, e.g. an instant of a timeline of an audio signal.
    /// <see href="http://purl.org/ontology/pbo/core#skip_time"></see></summary>
    let skip_time = Namespaced_IRI.parse _namespace_name "skip_time" |> NamespacedName
    /// <summary>
    /// This relation directs to a description of a transition between two neighbouring playlist slots, e.g. two successive music tracks in a dj mix.
    /// <see href="http://purl.org/ontology/pbo/core#transition"></see></summary>
    let transition = Namespaced_IRI.parse _namespace_name "transition" |> NamespacedName
