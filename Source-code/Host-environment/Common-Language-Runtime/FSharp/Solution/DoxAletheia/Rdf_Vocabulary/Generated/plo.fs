namespace http.purl.org.net.po.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module plo =
    let _namespace_iri = Namespace_Iri plo |> NamespaceIRI
    /// <summary>
    ///   <para>plo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#">http://purl.org/net/po#</seealso>
    let _prefix_iri = Prefixed_Name(plo, "") |> PrefixedName
    /// <summary>
    ///   <para>plo:Playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class for representing a playlist. One Playlist instance is connected to one or more PlaylistEntry instances. It contains the name of the playlist and the name of the radio station."</para>
    /// labels<para>"Playlist"</para></remarks>
    /// <seealso href="http://purl.org/net/po#Playlist">http://purl.org/net/po#Playlist</seealso>
    let Playlist = Prefixed_Name(plo, "Playlist") |> PrefixedName
    /// <summary>
    ///   <para>plo:PlaylistEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class for representing an entry from a playlist. One PlaylistEntry instance is connected to one Song instance and one Playlist instance. It contains information about the 'position' of the Song in the Playlist, for the specific 'week' of the 'year'. It also contains an URL of a 'photo' for the playlist entry."</para>
    /// labels<para>"Playlist Entry"</para></remarks>
    /// <seealso href="http://purl.org/net/po#PlaylistEntry">http://purl.org/net/po#PlaylistEntry</seealso>
    let PlaylistEntry = Prefixed_Name(plo, "PlaylistEntry") |> PrefixedName
    /// <summary>
    ///   <para>plo:Song</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class for representing a song. One Song instance is connected to one or more PlaylistEntry instances. It contains the name of the song and the name of the artist. It can also contain external links to mo:Track and/or mo:MusicArtist instances, for creating Linked Data."</para>
    /// labels<para>"Song"</para></remarks>
    /// <seealso href="http://purl.org/net/po#Song">http://purl.org/net/po#Song</seealso>
    let Song = Prefixed_Name(plo, "Song") |> PrefixedName
    /// <summary>
    ///   <para>plo:artistInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#artistInfo">http://purl.org/net/po#artistInfo</seealso>
    let artistInfo = Prefixed_Name(plo, "artistInfo") |> PrefixedName

    /// <summary>
    ///   <para>plo:featuredInPlaylistEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#featuredInPlaylistEntry">http://purl.org/net/po#featuredInPlaylistEntry</seealso>
    let featuredInPlaylistEntry =
        Prefixed_Name(plo, "featuredInPlaylistEntry") |> PrefixedName

    /// <summary>
    ///   <para>plo:hasPlaylistEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#hasPlaylistEntry">http://purl.org/net/po#hasPlaylistEntry</seealso>
    let hasPlaylistEntry = Prefixed_Name(plo, "hasPlaylistEntry") |> PrefixedName
    /// <summary>
    ///   <para>plo:partOfPlaylist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#partOfPlaylist">http://purl.org/net/po#partOfPlaylist</seealso>
    let partOfPlaylist = Prefixed_Name(plo, "partOfPlaylist") |> PrefixedName
    /// <summary>
    ///   <para>plo:photoURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#photoURL">http://purl.org/net/po#photoURL</seealso>
    let photoURL = Prefixed_Name(plo, "photoURL") |> PrefixedName
    /// <summary>
    ///   <para>plo:playlistEntrySong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#playlistEntrySong">http://purl.org/net/po#playlistEntrySong</seealso>
    let playlistEntrySong = Prefixed_Name(plo, "playlistEntrySong") |> PrefixedName
    /// <summary>
    ///   <para>plo:playlistName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#playlistName">http://purl.org/net/po#playlistName</seealso>
    let playlistName = Prefixed_Name(plo, "playlistName") |> PrefixedName
    /// <summary>
    ///   <para>plo:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#position">http://purl.org/net/po#position</seealso>
    let position = Prefixed_Name(plo, "position") |> PrefixedName
    /// <summary>
    ///   <para>plo:songInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#songInfo">http://purl.org/net/po#songInfo</seealso>
    let songInfo = Prefixed_Name(plo, "songInfo") |> PrefixedName
    /// <summary>
    ///   <para>plo:stationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#stationName">http://purl.org/net/po#stationName</seealso>
    let stationName = Prefixed_Name(plo, "stationName") |> PrefixedName
    /// <summary>
    ///   <para>plo:week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#week">http://purl.org/net/po#week</seealso>
    let week = Prefixed_Name(plo, "week") |> PrefixedName
    /// <summary>
    ///   <para>plo:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/po#year">http://purl.org/net/po#year</seealso>
    let year = Prefixed_Name(plo, "year") |> PrefixedName
