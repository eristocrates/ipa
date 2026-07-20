namespace http.purl.org.net.po.hash

open DoxAletheia

module plo =
    let _namespace_name = "http://purl.org/net/po#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A class for representing a playlist. One Playlist instance is connected to one or more PlaylistEntry instances. It contains the name of the playlist and the name of the radio station.
    /// <see href="http://purl.org/net/po#Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// A class for representing an entry from a playlist. One PlaylistEntry instance is connected to one Song instance and one Playlist instance. It contains information about the 'position' of the Song in the Playlist, for the specific 'week' of the 'year'. It also contains an URL of a 'photo' for the playlist entry.
    /// <see href="http://purl.org/net/po#PlaylistEntry"></see></summary>
    let PlaylistEntry = _prefix "PlaylistEntry"
    /// <summary>
    /// A class for representing a song. One Song instance is connected to one or more PlaylistEntry instances. It contains the name of the song and the name of the artist. It can also contain external links to mo:Track and/or mo:MusicArtist instances, for creating Linked Data.
    /// <see href="http://purl.org/net/po#Song"></see></summary>
    let Song = _prefix "Song"
    /// <summary>
    ///   <see href="http://purl.org/net/po#playlistEntrySong"></see>
    /// </summary>
    let playlistEntrySong = _prefix "playlistEntrySong"
    /// <summary>
    ///   <see href="http://purl.org/net/po#partOfPlaylist"></see>
    /// </summary>
    let partOfPlaylist = _prefix "partOfPlaylist"
    /// <summary>
    ///   <see href="http://purl.org/net/po#artistInfo"></see>
    /// </summary>
    let artistInfo = _prefix "artistInfo"
    /// <summary>
    ///   <see href="http://purl.org/net/po#featuredInPlaylistEntry"></see>
    /// </summary>
    let featuredInPlaylistEntry = _prefix "featuredInPlaylistEntry"
    /// <summary>
    ///   <see href="http://purl.org/net/po#hasPlaylistEntry"></see>
    /// </summary>
    let hasPlaylistEntry = _prefix "hasPlaylistEntry"
    /// <summary>
    ///   <see href="http://purl.org/net/po#photoURL"></see>
    /// </summary>
    let photoURL = _prefix "photoURL"
    /// <summary>
    ///   <see href="http://purl.org/net/po#playlistName"></see>
    /// </summary>
    let playlistName = _prefix "playlistName"
    /// <summary>
    ///   <see href="http://purl.org/net/po#position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://purl.org/net/po#songInfo"></see>
    /// </summary>
    let songInfo = _prefix "songInfo"
    /// <summary>
    ///   <see href="http://purl.org/net/po#stationName"></see>
    /// </summary>
    let stationName = _prefix "stationName"
    /// <summary>
    ///   <see href="http://purl.org/net/po#week"></see>
    /// </summary>
    let week = _prefix "week"
    /// <summary>
    ///   <see href="http://purl.org/net/po#year"></see>
    /// </summary>
    let year = _prefix "year"
