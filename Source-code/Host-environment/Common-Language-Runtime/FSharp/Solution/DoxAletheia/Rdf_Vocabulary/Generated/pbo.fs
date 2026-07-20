namespace http.purl.org.ontology.pbo.core.hash

open DoxAletheia

module pbo =
    let _namespace_name = "http://purl.org/ontology/pbo/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A (sub) playlist of a fixed length and a fixed order. This concept should be used to express static relations,
    /// e.g. "those three music tracks must always be played in a row".
    /// <see href="http://purl.org/ontology/pbo/core#FixedPlaylist"></see></summary>
    let FixedPlaylist = _prefix "FixedPlaylist"
    /// <summary>
    /// A playlist of specific media items, e.g. music tracks, videos or slides.
    /// <see href="http://purl.org/ontology/pbo/core#Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// A media action counter. Media actions are for example play back or skip events.
    /// <see href="http://purl.org/ontology/pbo/core#MediaActionCounter"></see></summary>
    let MediaActionCounter = _prefix "MediaActionCounter"
    /// <summary>
    /// A play back counter, e.g. to count the playback of a media object.
    /// <see href="http://purl.org/ontology/pbo/core#PlayBackCounter"></see></summary>
    let PlayBackCounter = _prefix "PlayBackCounter"
    /// <summary>
    /// A playlist slot. It could contain e.g. a music track, a video or a slide, and maybe related with some
    /// additional properties. However, it could maybe also included a "sub" playlist, e.g. to keep a fixed sequence of some tracks.
    /// <see href="http://purl.org/ontology/pbo/core#PlaylistSlot"></see></summary>
    let PlaylistSlot = _prefix "PlaylistSlot"
    /// <summary>
    /// A specific playlist item, e.g. a music track, video or slides. The range types of this property must be
    /// based on bibo:Document or frbr:Endeavour (to keep it somehow media based).
    /// <see href="http://purl.org/ontology/pbo/core#playlist_item"></see></summary>
    let playlist_item = _prefix "playlist_item"
    /// <summary>
    /// A skip counter, e.g. to count skip events of a media object.
    /// <see href="http://purl.org/ontology/pbo/core#SkipCounter"></see></summary>
    let SkipCounter = _prefix "SkipCounter"
    /// <summary>
    /// A specific skip event of something.
    /// <see href="http://purl.org/ontology/pbo/core#SkipEvent"></see></summary>
    let SkipEvent = _prefix "SkipEvent"
    /// <summary>
    /// Associates a media object to its related counter.
    /// <see href="http://purl.org/ontology/pbo/core#media_object"></see></summary>
    let media_object = _prefix "media_object"
    /// <summary>
    /// A media specific scrobble object, e.g. a music track or a video.
    /// <see href="http://purl.org/ontology/pbo/core#media_scrobble_object"></see></summary>
    let media_scrobble_object = _prefix "media_scrobble_object"
    /// <summary>
    /// Associates a playlist to something.
    /// <see href="http://purl.org/ontology/pbo/core#playlist"></see></summary>
    let playlist = _prefix "playlist"
    /// <summary>
    /// A specific slot in a playlist.
    /// <see href="http://purl.org/ontology/pbo/core#playlist_slot"></see></summary>
    let playlist_slot = _prefix "playlist_slot"
    /// <summary>
    /// The moment, when someone skipped the media object, e.g. an instant of a timeline of an audio signal.
    /// <see href="http://purl.org/ontology/pbo/core#skip_time"></see></summary>
    let skip_time = _prefix "skip_time"
    /// <summary>
    /// This relation directs to a description of a transition between two neighbouring playlist slots, e.g. two successive music tracks in a dj mix.
    /// <see href="http://purl.org/ontology/pbo/core#transition"></see></summary>
    let transition = _prefix "transition"
