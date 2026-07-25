namespace http.tracker.api.gnome.org.ontology.v3.nmm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnmm =
    let _namespace_iri = Namespace_Iri tnmm |> NamespaceIRI
    /// <summary>
    ///   <para>tnmm:Artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An artist.</para>
    /// labels<para>Artist</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Artist">http://tracker.api.gnome.org/ontology/v3/nmm#Artist</seealso>
    let Artist = Prefixed_Name(tnmm, "Artist") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:DigitalRadio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Online Radio Stream data object (i.e. as a raw flow of bytes)</para>
    /// labels<para>Online Radio Stream</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#DigitalRadio">http://tracker.api.gnome.org/ontology/v3/nmm#DigitalRadio</seealso>
    let DigitalRadio = Prefixed_Name(tnmm, "DigitalRadio") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:ImageList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An album of images</para>
    /// labels<para>Image album</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#ImageList">http://tracker.api.gnome.org/ontology/v3/nmm#ImageList</seealso>
    let ImageList = Prefixed_Name(tnmm, "ImageList") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Video</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Video">http://tracker.api.gnome.org/ontology/v3/nmm#Video</seealso>
    let Video = Prefixed_Name(tnmm, "Video") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:TVSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A season of a TV show</para>
    /// labels<para>TV Season</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeason">http://tracker.api.gnome.org/ontology/v3/nmm#TVSeason</seealso>
    let TVSeason = Prefixed_Name(tnmm, "TVSeason") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:TVShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TV show</para>
    /// labels<para>TV Show</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#TVShow">http://tracker.api.gnome.org/ontology/v3/nmm#TVShow</seealso>
    let TVShow = Prefixed_Name(tnmm, "TVShow") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:MPAARating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>MPAA Rating</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#MPAARating">http://tracker.api.gnome.org/ontology/v3/nmm#MPAARating</seealso>
    let MPAARating = Prefixed_Name(tnmm, "MPAARating") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:MusicAlbumDisc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Music album Disc</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbumDisc">http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbumDisc</seealso>
    let MusicAlbumDisc = Prefixed_Name(tnmm, "MusicAlbumDisc") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:Playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Specific class to split MediaList in Albums and playlists.</para>
    /// labels<para>Media playlist</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Playlist">http://tracker.api.gnome.org/ontology/v3/nmm#Playlist</seealso>
    let Playlist = Prefixed_Name(tnmm, "Playlist") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:RadioModulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Set of instances for analog radio modulation</para>
    /// labels<para>Radio modulation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioModulation">http://tracker.api.gnome.org/ontology/v3/nmm#RadioModulation</seealso>
    let RadioModulation = Prefixed_Name(tnmm, "RadioModulation") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:RadioStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Radio station in user terms: BBC3, Radio5, YLEX, ... It is linked with 1 or more carriers (different FM frenquencies, online sources in different qualities, etc.). Some RDS information is represented with nie properties, nie:identifier for PI, nie:title for PS</para>
    /// labels<para>Radio station</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioStation">http://tracker.api.gnome.org/ontology/v3/nmm#RadioStation</seealso>
    let RadioStation = Prefixed_Name(tnmm, "RadioStation") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:Flash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumeration of the possible values of flash property</para>
    /// labels<para>Flash values</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Flash">http://tracker.api.gnome.org/ontology/v3/nmm#Flash</seealso>
    let Flash = Prefixed_Name(tnmm, "Flash") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:MeteringMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumeration of different ways a camera determines exposure.</para>
    /// labels<para>Metering mode values</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#MeteringMode">http://tracker.api.gnome.org/ontology/v3/nmm#MeteringMode</seealso>
    let MeteringMode = Prefixed_Name(tnmm, "MeteringMode") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:Movie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Movie</para>
    /// labels<para>Movie</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Movie">http://tracker.api.gnome.org/ontology/v3/nmm#Movie</seealso>
    let Movie = Prefixed_Name(tnmm, "Movie") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:MusicPiece</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Used to assign music-specific properties such as BPM to video and audio</para>
    /// labels<para>Music</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicPiece">http://tracker.api.gnome.org/ontology/v3/nmm#MusicPiece</seealso>
    let MusicPiece = Prefixed_Name(tnmm, "MusicPiece") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:MusicAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The music album as provided by the publisher. Not to be confused with media lists or collections</para>
    /// labels<para>Music album</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbum">http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbum</seealso>
    let MusicAlbum = Prefixed_Name(tnmm, "MusicAlbum") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:Photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A photo</para>
    /// labels<para>Photo</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#Photo">http://tracker.api.gnome.org/ontology/v3/nmm#Photo</seealso>
    let Photo = Prefixed_Name(tnmm, "Photo") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:TVSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TV Series has multiple seasons and episodes</para>
    /// labels<para>TV Series</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeries">http://tracker.api.gnome.org/ontology/v3/nmm#TVSeries</seealso>
    let TVSeries = Prefixed_Name(tnmm, "TVSeries") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:SynchronizedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Synchronized text (use nie:language to set the language). Valid for subtitles and lyrics</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#SynchronizedText">http://tracker.api.gnome.org/ontology/v3/nmm#SynchronizedText</seealso>
    let SynchronizedText = Prefixed_Name(tnmm, "SynchronizedText") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>main artists of the album</para>
    /// labels<para>artist</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumArtist">http://tracker.api.gnome.org/ontology/v3/nmm#albumArtist</seealso>
    let albumArtist = Prefixed_Name(tnmm, "albumArtist") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Duration of the album</para>
    /// labels<para>Album duration</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDuration">http://tracker.api.gnome.org/ontology/v3/nmm#albumDuration</seealso>
    let albumDuration = Prefixed_Name(tnmm, "albumDuration") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumPeakGain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Peak Gain of album</para>
    /// labels<para>Peak Gain</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumPeakGain">http://tracker.api.gnome.org/ontology/v3/nmm#albumPeakGain</seealso>
    let albumPeakGain = Prefixed_Name(tnmm, "albumPeakGain") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumTrackCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Track count of album</para>
    /// labels<para>Track count</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumTrackCount">http://tracker.api.gnome.org/ontology/v3/nmm#albumTrackCount</seealso>
    let albumTrackCount = Prefixed_Name(tnmm, "albumTrackCount") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:beatsPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>beats per minute</para>
    /// labels<para>Beats per minute</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#beatsPerMinute">http://tracker.api.gnome.org/ontology/v3/nmm#beatsPerMinute</seealso>
    let beatsPerMinute = Prefixed_Name(tnmm, "beatsPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Composer</para>
    /// labels<para>Composer</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#composer">http://tracker.api.gnome.org/ontology/v3/nmm#composer</seealso>
    let composer = Prefixed_Name(tnmm, "composer") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Director</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#director">http://tracker.api.gnome.org/ontology/v3/nmm#director</seealso>
    let director = Prefixed_Name(tnmm, "director") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:exposureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Exposure time of the photo</para>
    /// labels<para>Exposure time</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#exposureTime">http://tracker.api.gnome.org/ontology/v3/nmm#exposureTime</seealso>
    let exposureTime = Prefixed_Name(tnmm, "exposureTime") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:flash-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:Flash</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-on">http://tracker.api.gnome.org/ontology/v3/nmm#flash-on</seealso>
    let flash_on = Prefixed_Name(tnmm, "flash-on") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:fnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The diameter of the entrance pupil in terms of the focal length of the lens</para>
    /// labels<para>F number</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#fnumber">http://tracker.api.gnome.org/ontology/v3/nmm#fnumber</seealso>
    let fnumber = Prefixed_Name(tnmm, "fnumber") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Genre</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#genre">http://tracker.api.gnome.org/ontology/v3/nmm#genre</seealso>
    let genre = Prefixed_Name(tnmm, "genre") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:hasSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a TV Series to its seasons</para>
    /// labels<para>Seasons in a TV series</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeason">http://tracker.api.gnome.org/ontology/v3/nmm#hasSeason</seealso>
    let hasSeason = Prefixed_Name(tnmm, "hasSeason") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:hasSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has subtitle</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSubtitle">http://tracker.api.gnome.org/ontology/v3/nmm#hasSubtitle</seealso>
    let hasSubtitle = Prefixed_Name(tnmm, "hasSubtitle") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:isColorCorrected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isColorCorrected">http://tracker.api.gnome.org/ontology/v3/nmm#isColorCorrected</seealso>
    let isColorCorrected = Prefixed_Name(tnmm, "isColorCorrected") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:isContentEncrypted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Is content encrypted FIXME: defined already in IE in this ontology!</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isContentEncrypted">http://tracker.api.gnome.org/ontology/v3/nmm#isContentEncrypted</seealso>
    let isContentEncrypted = Prefixed_Name(tnmm, "isContentEncrypted") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:isPartOfSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a TV Show to its season</para>
    /// labels<para>Season that the episode belongs to</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isPartOfSeason">http://tracker.api.gnome.org/ontology/v3/nmm#isPartOfSeason</seealso>
    let isPartOfSeason = Prefixed_Name(tnmm, "isPartOfSeason") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:leadActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Lead actor</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#leadActor">http://tracker.api.gnome.org/ontology/v3/nmm#leadActor</seealso>
    let leadActor = Prefixed_Name(tnmm, "leadActor") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:lyricist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Lyricist</para>
    /// labels<para>Lyricist</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#lyricist">http://tracker.api.gnome.org/ontology/v3/nmm#lyricist</seealso>
    let lyricist = Prefixed_Name(tnmm, "lyricist") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:lyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>File with the lyrics for the music piece</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#lyrics">http://tracker.api.gnome.org/ontology/v3/nmm#lyrics</seealso>
    let lyrics = Prefixed_Name(tnmm, "lyrics") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-pattern">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-pattern</seealso>
    let metering_mode_pattern =
        Prefixed_Name(tnmm, "metering-mode-pattern") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-spot</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-spot">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-spot</seealso>
    let metering_mode_spot = Prefixed_Name(tnmm, "metering-mode-spot") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:meteringMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Metering mode refers to the way in which a camera determines the exposure.</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#meteringMode">http://tracker.api.gnome.org/ontology/v3/nmm#meteringMode</seealso>
    let meteringMode = Prefixed_Name(tnmm, "meteringMode") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:modulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Modulation used in the frequency (AM or FM)</para>
    /// labels<para>Signal modulation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#modulation">http://tracker.api.gnome.org/ontology/v3/nmm#modulation</seealso>
    let modulation = Prefixed_Name(tnmm, "modulation") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:musicAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>album the music belongs to</para>
    /// labels<para>album</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbum">http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbum</seealso>
    let musicAlbum = Prefixed_Name(tnmm, "musicAlbum") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:producedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Produced by</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#producedBy">http://tracker.api.gnome.org/ontology/v3/nmm#producedBy</seealso>
    let producedBy = Prefixed_Name(tnmm, "producedBy") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Protocol used for the streaming (HTTP, RTSP)</para>
    /// labels<para>Protocol</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#protocol">http://tracker.api.gnome.org/ontology/v3/nmm#protocol</seealso>
    let protocol = Prefixed_Name(tnmm, "protocol") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:radio-modulation-am</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:RadioModulation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-am">http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-am</seealso>
    let radio_modulation_am = Prefixed_Name(tnmm, "radio-modulation-am") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:seasonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a TV Season to its series</para>
    /// labels<para>Series that the season belongs to</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonOf">http://tracker.api.gnome.org/ontology/v3/nmm#seasonOf</seealso>
    let seasonOf = Prefixed_Name(tnmm, "seasonOf") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a TV Show to its TV series</para>
    /// labels<para>Series of a TV show</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#series">http://tracker.api.gnome.org/ontology/v3/nmm#series</seealso>
    let series = Prefixed_Name(tnmm, "series") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:setNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Disc number of album disc</para>
    /// labels<para>Disc number</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#setNumber">http://tracker.api.gnome.org/ontology/v3/nmm#setNumber</seealso>
    let setNumber = Prefixed_Name(tnmm, "setNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Subtitle file relevant for the video</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#subtitle">http://tracker.api.gnome.org/ontology/v3/nmm#subtitle</seealso>
    let subtitle = Prefixed_Name(tnmm, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Long form description of video content (plot, premise, etc.)</para>
    /// labels<para>Synopsis</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#synopsis">http://tracker.api.gnome.org/ontology/v3/nmm#synopsis</seealso>
    let synopsis = Prefixed_Name(tnmm, "synopsis") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:trackNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Track number of the music in its album</para>
    /// labels<para>Track number</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#trackNumber">http://tracker.api.gnome.org/ontology/v3/nmm#trackNumber</seealso>
    let trackNumber = Prefixed_Name(tnmm, "trackNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:white-balance-auto</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:WhiteBalance</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-auto">http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-auto</seealso>
    let white_balance_auto = Prefixed_Name(tnmm, "white-balance-auto") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:white-balance-manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:WhiteBalance</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-manual">http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-manual</seealso>
    let white_balance_manual =
        Prefixed_Name(tnmm, "white-balance-manual") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:whiteBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#whiteBalance">http://tracker.api.gnome.org/ontology/v3/nmm#whiteBalance</seealso>
    let whiteBalance = Prefixed_Name(tnmm, "whiteBalance") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:WhiteBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Camera's white balance setting</para>
    /// labels<para>White balance</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#WhiteBalance">http://tracker.api.gnome.org/ontology/v3/nmm#WhiteBalance</seealso>
    let WhiteBalance = Prefixed_Name(tnmm, "WhiteBalance") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumDiscAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Album of the disc</para>
    /// labels<para>album disc's album</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDiscAlbum">http://tracker.api.gnome.org/ontology/v3/nmm#albumDiscAlbum</seealso>
    let albumDiscAlbum = Prefixed_Name(tnmm, "albumDiscAlbum") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:albumGain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Gain of album</para>
    /// labels<para>Gain</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#albumGain">http://tracker.api.gnome.org/ontology/v3/nmm#albumGain</seealso>
    let albumGain = Prefixed_Name(tnmm, "albumGain") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:alternativeMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link between to different version of the same media. This is used for instances in uPnp where the server can provide the same video in different resolutions and codecs</para>
    /// labels<para>Alternative media</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#alternativeMedia">http://tracker.api.gnome.org/ontology/v3/nmm#alternativeMedia</seealso>
    let alternativeMedia = Prefixed_Name(tnmm, "alternativeMedia") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:artistName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of the artist</para>
    /// labels<para>fullname</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#artistName">http://tracker.api.gnome.org/ontology/v3/nmm#artistName</seealso>
    let artistName = Prefixed_Name(tnmm, "artistName") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Signal where a radio can be tuned in. There can be more than one.</para>
    /// labels<para>Carrier</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#carrier">http://tracker.api.gnome.org/ontology/v3/nmm#carrier</seealso>
    let carrier = Prefixed_Name(tnmm, "carrier") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:dlnaMime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Mimetypes as defined for DLNA (occasional differences compared to xdg-mime)</para>
    /// labels<para>DLNA mimetype</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaMime">http://tracker.api.gnome.org/ontology/v3/nmm#dlnaMime</seealso>
    let dlnaMime = Prefixed_Name(tnmm, "dlnaMime") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>main artist of the MusicPiece</para>
    /// labels<para>Artist</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#artist">http://tracker.api.gnome.org/ontology/v3/nmm#artist</seealso>
    let artist = Prefixed_Name(tnmm, "artist") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:artwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated Artwork</para>
    /// labels<para>Artwork</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#artwork">http://tracker.api.gnome.org/ontology/v3/nmm#artwork</seealso>
    let artwork = Prefixed_Name(tnmm, "artwork") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Category</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#category">http://tracker.api.gnome.org/ontology/v3/nmm#category</seealso>
    let category = Prefixed_Name(tnmm, "category") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Encoding of the radio. It is a property of the streaming, that it is known before hand, so the applications can choose the encoding they understand.</para>
    /// labels<para>Encoding of the radio</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#encoding">http://tracker.api.gnome.org/ontology/v3/nmm#encoding</seealso>
    let encoding = Prefixed_Name(tnmm, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:flash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies whether flash was used</para>
    /// labels<para>Flash</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#flash">http://tracker.api.gnome.org/ontology/v3/nmm#flash</seealso>
    let flash = Prefixed_Name(tnmm, "flash") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Frequency in the Radio spectrum in Khz (note that usually FM frequencies are in MHz)</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#frequency">http://tracker.api.gnome.org/ontology/v3/nmm#frequency</seealso>
    let frequency = Prefixed_Name(tnmm, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:dlnaProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>DLNA profile of the content, like MP3, MPEG_TS_HD_US, LPCM etc</para>
    /// labels<para>DLNA profile</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaProfile">http://tracker.api.gnome.org/ontology/v3/nmm#dlnaProfile</seealso>
    let dlnaProfile = Prefixed_Name(tnmm, "dlnaProfile") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:episodeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Episode number of a TV show</para>
    /// labels<para>Episode number</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#episodeNumber">http://tracker.api.gnome.org/ontology/v3/nmm#episodeNumber</seealso>
    let episodeNumber = Prefixed_Name(tnmm, "episodeNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:flash-off</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:Flash</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-off">http://tracker.api.gnome.org/ontology/v3/nmm#flash-off</seealso>
    let flash_off = Prefixed_Name(tnmm, "flash-off") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:focalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A measure of how strongly the lens converges light</para>
    /// labels<para>Focal length</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#focalLength">http://tracker.api.gnome.org/ontology/v3/nmm#focalLength</seealso>
    let focalLength = Prefixed_Name(tnmm, "focalLength") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:hasEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A TVSeries has many episodes</para>
    /// labels<para>Episodes in a TV series</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#hasEpisode">http://tracker.api.gnome.org/ontology/v3/nmm#hasEpisode</seealso>
    let hasEpisode = Prefixed_Name(tnmm, "hasEpisode") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:hasSeasonEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a TV Show season to its episodes</para>
    /// labels<para>whether an episode belongs to this season</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeasonEpisode">http://tracker.api.gnome.org/ontology/v3/nmm#hasSeasonEpisode</seealso>
    let hasSeasonEpisode = Prefixed_Name(tnmm, "hasSeasonEpisode") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:internationalStandardRecordingCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>ISRC ID. Format: 'CC-XXX-YY-NNNNN'</para>
    /// labels<para>International Standard Recording Code</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#internationalStandardRecordingCode">http://tracker.api.gnome.org/ontology/v3/nmm#internationalStandardRecordingCode</seealso>
    let internationalStandardRecordingCode =
        Prefixed_Name(tnmm, "internationalStandardRecordingCode") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:isCropped</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isCropped">http://tracker.api.gnome.org/ontology/v3/nmm#isCropped</seealso>
    let isCropped = Prefixed_Name(tnmm, "isCropped") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:isoSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Measure of a photographic film's sensitivity to light as ISO value</para>
    /// labels<para>ISO speed</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isoSpeed">http://tracker.api.gnome.org/ontology/v3/nmm#isoSpeed</seealso>
    let isoSpeed = Prefixed_Name(tnmm, "isoSpeed") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-center-weighted-average</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-center-weighted-average">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-center-weighted-average</seealso>
    let metering_mode_center_weighted_average =
        Prefixed_Name(tnmm, "metering-mode-center-weighted-average") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-partial</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-partial">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-partial</seealso>
    let metering_mode_partial =
        Prefixed_Name(tnmm, "metering-mode-partial") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:musicCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Music CD identifier to for databases like FreeDB.org. This frame is intended for music that comes from a CD, so that the CD can be identified in databases such as the CDDB. The frame consists of a binary dump of the Table Of Contents, TOC, from the CD, which is a header of 4 bytes and then 8 bytes/track on the CD plus 8 bytes for the 'lead out' making a maximum of 804 bytes. The offset to the beginning of every track on the CD should be described with a four bytes absolute CD-frame address per track, and not with absolute time.</para>
    /// labels<para>Music CD identifier</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#musicCDIdentifier">http://tracker.api.gnome.org/ontology/v3/nmm#musicCDIdentifier</seealso>
    let musicCDIdentifier = Prefixed_Name(tnmm, "musicCDIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:radioIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Image used as logo for a radio station</para>
    /// labels<para>Radio station icon</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#radioIcon">http://tracker.api.gnome.org/ontology/v3/nmm#radioIcon</seealso>
    let radioIcon = Prefixed_Name(tnmm, "radioIcon") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:seasonNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of a season</para>
    /// labels<para>Season number</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonNumber">http://tracker.api.gnome.org/ontology/v3/nmm#seasonNumber</seealso>
    let seasonNumber = Prefixed_Name(tnmm, "seasonNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:streamingBitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Bitrate indicating the quality of the stream in Kbits (usual values 32, 64, 128...)</para>
    /// labels<para>Streaming bitrate</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#streamingBitrate">http://tracker.api.gnome.org/ontology/v3/nmm#streamingBitrate</seealso>
    let streamingBitrate = Prefixed_Name(tnmm, "streamingBitrate") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:uPnPShared</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tells the uPnP MediaServer (e.g. Rygel) whether to export/share the resource or not</para>
    /// labels<para>uPnP shared</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#uPnPShared">http://tracker.api.gnome.org/ontology/v3/nmm#uPnPShared</seealso>
    let uPnPShared = Prefixed_Name(tnmm, "uPnPShared") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:isForHearingImpaired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Does text stream contain helper tags for hearing-impaired such as &amp;lt;steps in hallway&amp;gt;</para>
    /// labels<para>Is for hearing-impaired</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#isForHearingImpaired">http://tracker.api.gnome.org/ontology/v3/nmm#isForHearingImpaired</seealso>
    let isForHearingImpaired =
        Prefixed_Name(tnmm, "isForHearingImpaired") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-average</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-average">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-average</seealso>
    let metering_mode_average =
        Prefixed_Name(tnmm, "metering-mode-average") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-other</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-other">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-other</seealso>
    let metering_mode_other = Prefixed_Name(tnmm, "metering-mode-other") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:musicAlbumDisc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>album disc the music belongs to</para>
    /// labels<para>is part of album disc</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbumDisc">http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbumDisc</seealso>
    let musicAlbumDisc = Prefixed_Name(tnmm, "musicAlbumDisc") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Performer</para>
    /// labels<para>Performer</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#performer">http://tracker.api.gnome.org/ontology/v3/nmm#performer</seealso>
    let performer = Prefixed_Name(tnmm, "performer") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:radio-modulation-fm</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:RadioModulation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-fm">http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-fm</seealso>
    let radio_modulation_fm = Prefixed_Name(tnmm, "radio-modulation-fm") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:radioPTY</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>PTY Code (content description) as integer. RDS specs define the translations into human readable descriptions for various languages</para>
    /// labels<para>PTY</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#radioPTY">http://tracker.api.gnome.org/ontology/v3/nmm#radioPTY</seealso>
    let radioPTY = Prefixed_Name(tnmm, "radioPTY") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:runTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Run time</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#runTime">http://tracker.api.gnome.org/ontology/v3/nmm#runTime</seealso>
    let runTime = Prefixed_Name(tnmm, "runTime") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:skipCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Increase if the media is skip while playing</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#skipCounter">http://tracker.api.gnome.org/ontology/v3/nmm#skipCounter</seealso>
    let skipCounter = Prefixed_Name(tnmm, "skipCounter") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:metering-mode-multispot</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnmm:MeteringMode</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-multispot">http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-multispot</seealso>
    let metering_mode_multispot =
        Prefixed_Name(tnmm, "metering-mode-multispot") |> PrefixedName

    /// <summary>
    ///   <para>tnmm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    ///   <para>tnrl:Namespace</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#">http://tracker.api.gnome.org/ontology/v3/nmm#</seealso>
    let _prefix_iri = Prefixed_Name(tnmm, "") |> PrefixedName
    /// <summary>
    ///   <para>tnmm:AnalogRadio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>FM Radio carrier signal data. Basically the frequency</para>
    /// labels<para>AM/FM Radio carrier signal</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nmm#AnalogRadio">http://tracker.api.gnome.org/ontology/v3/nmm#AnalogRadio</seealso>
    let AnalogRadio = Prefixed_Name(tnmm, "AnalogRadio") |> PrefixedName
