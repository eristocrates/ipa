#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module plo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/po#" "plo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Playlist</para>
    ///   <para>rdfs:comment : A class for representing a playlist. One Playlist instance is connected to one or more PlaylistEntry instances. It contains the name of the playlist and the name of the radio station.</para>
    ///   <a href="http://purl.org/net/po#Playlist">plo:Playlist</a>
    /// </summary>
    let Playlist = _prefixId.prefix "Playlist"
    /// <summary>
    ///   <para>rdfs:label : Playlist Entry</para>
    ///   <para>rdfs:comment : A class for representing an entry from a playlist. One PlaylistEntry instance is connected to one Song instance and one Playlist instance. It contains information about the 'position' of the Song in the Playlist, for the specific 'week' of the 'year'. It also contains an URL of a 'photo' for the playlist entry.</para>
    ///   <a href="http://purl.org/net/po#PlaylistEntry">plo:PlaylistEntry</a>
    /// </summary>
    let PlaylistEntry = _prefixId.prefix "PlaylistEntry"
    /// <summary>
    ///   <para>rdfs:label : Song</para>
    ///   <para>rdfs:comment : A class for representing a song. One Song instance is connected to one or more PlaylistEntry instances. It contains the name of the song and the name of the artist. It can also contain external links to mo:Track and/or mo:MusicArtist instances, for creating Linked Data.</para>
    ///   <a href="http://purl.org/net/po#Song">plo:Song</a>
    /// </summary>
    let Song = _prefixId.prefix "Song"
    let artistInfo = _prefixId.prefix "artistInfo"
    let featuredInPlaylistEntry = _prefixId.prefix "featuredInPlaylistEntry"
    let hasPlaylistEntry = _prefixId.prefix "hasPlaylistEntry"
    let partOfPlaylist = _prefixId.prefix "partOfPlaylist"
    let photoURL = _prefixId.prefix "photoURL"
    let playlistEntrySong = _prefixId.prefix "playlistEntrySong"
    let playlistName = _prefixId.prefix "playlistName"
    let position = _prefixId.prefix "position"
    let songInfo = _prefixId.prefix "songInfo"
    let stationName = _prefixId.prefix "stationName"
    let week = _prefixId.prefix "week"
    let year = _prefixId.prefix "year"
