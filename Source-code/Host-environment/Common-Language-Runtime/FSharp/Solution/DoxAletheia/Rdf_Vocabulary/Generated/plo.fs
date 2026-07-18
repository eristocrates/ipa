namespace http.purl.org.net.po.hash

open DoxAletheia.Rdf_Vocabulary

module plo =
    let _namespace_name = "http://purl.org/net/po#"
    /// <summary>
    /// A class for representing a playlist. One Playlist instance is connected to one or more PlaylistEntry instances. It contains the name of the playlist and the name of the radio station.
    /// <see href="http://purl.org/net/po#Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName

    /// <summary>
    /// A class for representing an entry from a playlist. One PlaylistEntry instance is connected to one Song instance and one Playlist instance. It contains information about the 'position' of the Song in the Playlist, for the specific 'week' of the 'year'. It also contains an URL of a 'photo' for the playlist entry.
    /// <see href="http://purl.org/net/po#PlaylistEntry"></see></summary>
    let PlaylistEntry =
        Namespaced_IRI.parse _namespace_name "PlaylistEntry" |> NamespacedName

    /// <summary>
    /// A class for representing a song. One Song instance is connected to one or more PlaylistEntry instances. It contains the name of the song and the name of the artist. It can also contain external links to mo:Track and/or mo:MusicArtist instances, for creating Linked Data.
    /// <see href="http://purl.org/net/po#Song"></see></summary>
    let Song = Namespaced_IRI.parse _namespace_name "Song" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#playlistEntrySong"></see>
    /// </summary>
    let playlistEntrySong =
        Namespaced_IRI.parse _namespace_name "playlistEntrySong" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#partOfPlaylist"></see>
    /// </summary>
    let partOfPlaylist =
        Namespaced_IRI.parse _namespace_name "partOfPlaylist" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#artistInfo"></see>
    /// </summary>
    let artistInfo = Namespaced_IRI.parse _namespace_name "artistInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#featuredInPlaylistEntry"></see>
    /// </summary>
    let featuredInPlaylistEntry =
        Namespaced_IRI.parse _namespace_name "featuredInPlaylistEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#hasPlaylistEntry"></see>
    /// </summary>
    let hasPlaylistEntry =
        Namespaced_IRI.parse _namespace_name "hasPlaylistEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#photoURL"></see>
    /// </summary>
    let photoURL = Namespaced_IRI.parse _namespace_name "photoURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#playlistName"></see>
    /// </summary>
    let playlistName =
        Namespaced_IRI.parse _namespace_name "playlistName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/po#songInfo"></see>
    /// </summary>
    let songInfo = Namespaced_IRI.parse _namespace_name "songInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#stationName"></see>
    /// </summary>
    let stationName =
        Namespaced_IRI.parse _namespace_name "stationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/po#week"></see>
    /// </summary>
    let week = Namespaced_IRI.parse _namespace_name "week" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/po#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
