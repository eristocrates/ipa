namespace http.tracker.api.gnome.org.ontology.v3.nmm.hash

open DoxAletheia.Rdf_Vocabulary

module tnmm =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nmm#"

    /// <summary>
    /// FM Radio carrier signal data. Basically the frequency
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#AnalogRadio"></see></summary>
    let AnalogRadio =
        Namespaced_IRI.parse _namespace_name "AnalogRadio" |> NamespacedName

    /// <summary>
    /// An artist.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Artist"></see></summary>
    let Artist = Namespaced_IRI.parse _namespace_name "Artist" |> NamespacedName

    /// <summary>
    /// Online Radio Stream data object (i.e. as a raw flow of bytes)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#DigitalRadio"></see></summary>
    let DigitalRadio =
        Namespaced_IRI.parse _namespace_name "DigitalRadio" |> NamespacedName

    /// <summary>
    /// Enumeration of the possible values of flash property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Flash"></see></summary>
    let Flash = Namespaced_IRI.parse _namespace_name "Flash" |> NamespacedName
    /// <summary>
    /// An album of images
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#ImageList"></see></summary>
    let ImageList = Namespaced_IRI.parse _namespace_name "ImageList" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MPAARating"></see>
    /// </summary>
    let MPAARating = Namespaced_IRI.parse _namespace_name "MPAARating" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName

    /// <summary>
    /// Enumeration of different ways a camera determines exposure.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MeteringMode"></see></summary>
    let MeteringMode =
        Namespaced_IRI.parse _namespace_name "MeteringMode" |> NamespacedName

    /// <summary>
    /// A Movie
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Movie"></see></summary>
    let Movie = Namespaced_IRI.parse _namespace_name "Movie" |> NamespacedName
    /// <summary>
    /// The music album as provided by the publisher. Not to be confused with media lists or collections
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbum"></see></summary>
    let MusicAlbum = Namespaced_IRI.parse _namespace_name "MusicAlbum" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbumDisc"></see>
    /// </summary>
    let MusicAlbumDisc =
        Namespaced_IRI.parse _namespace_name "MusicAlbumDisc" |> NamespacedName

    /// <summary>
    /// Used to assign music-specific properties such as BPM to video and audio
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicPiece"></see></summary>
    let MusicPiece = Namespaced_IRI.parse _namespace_name "MusicPiece" |> NamespacedName
    /// <summary>
    /// A photo
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Photo"></see></summary>
    let Photo = Namespaced_IRI.parse _namespace_name "Photo" |> NamespacedName
    /// <summary>
    /// Specific class to split MediaList in Albums and playlists.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName

    /// <summary>
    /// Set of instances for analog radio modulation
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioModulation"></see></summary>
    let RadioModulation =
        Namespaced_IRI.parse _namespace_name "RadioModulation" |> NamespacedName

    /// <summary>
    /// The Radio station in user terms: BBC3, Radio5, YLEX, ... It is linked with 1 or more carriers (different FM frenquencies, online sources in different qualities, etc.). Some RDS information is represented with nie properties, nie:identifier for PI, nie:title for PS
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioStation"></see></summary>
    let RadioStation =
        Namespaced_IRI.parse _namespace_name "RadioStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#SynchronizedText"></see>
    /// </summary>
    let SynchronizedText =
        Namespaced_IRI.parse _namespace_name "SynchronizedText" |> NamespacedName

    /// <summary>
    /// A season of a TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeason"></see></summary>
    let TVSeason = Namespaced_IRI.parse _namespace_name "TVSeason" |> NamespacedName
    /// <summary>
    /// A TV Series has multiple seasons and episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeries"></see></summary>
    let TVSeries = Namespaced_IRI.parse _namespace_name "TVSeries" |> NamespacedName
    /// <summary>
    /// A TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVShow"></see></summary>
    let TVShow = Namespaced_IRI.parse _namespace_name "TVShow" |> NamespacedName

    /// <summary>
    /// Camera's white balance setting
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#WhiteBalance"></see></summary>
    let WhiteBalance =
        Namespaced_IRI.parse _namespace_name "WhiteBalance" |> NamespacedName

    /// <summary>
    /// main artists of the album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumArtist"></see></summary>
    let albumArtist =
        Namespaced_IRI.parse _namespace_name "albumArtist" |> NamespacedName

    /// <summary>
    /// Album of the disc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDiscAlbum"></see></summary>
    let albumDiscAlbum =
        Namespaced_IRI.parse _namespace_name "albumDiscAlbum" |> NamespacedName

    /// <summary>
    /// Duration of the album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDuration"></see></summary>
    let albumDuration =
        Namespaced_IRI.parse _namespace_name "albumDuration" |> NamespacedName

    /// <summary>
    /// Gain of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumGain"></see></summary>
    let albumGain = Namespaced_IRI.parse _namespace_name "albumGain" |> NamespacedName

    /// <summary>
    /// Peak Gain of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumPeakGain"></see></summary>
    let albumPeakGain =
        Namespaced_IRI.parse _namespace_name "albumPeakGain" |> NamespacedName

    /// <summary>
    /// Track count of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumTrackCount"></see></summary>
    let albumTrackCount =
        Namespaced_IRI.parse _namespace_name "albumTrackCount" |> NamespacedName

    /// <summary>
    /// Link between to different version of the same media. This is used for instances in uPnp where the server can provide the same video in different resolutions and codecs
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#alternativeMedia"></see></summary>
    let alternativeMedia =
        Namespaced_IRI.parse _namespace_name "alternativeMedia" |> NamespacedName

    /// <summary>
    /// main artist of the MusicPiece
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artist"></see></summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName
    /// <summary>
    /// Name of the artist
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artistName"></see></summary>
    let artistName = Namespaced_IRI.parse _namespace_name "artistName" |> NamespacedName
    /// <summary>
    /// Associated Artwork
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artwork"></see></summary>
    let artwork = Namespaced_IRI.parse _namespace_name "artwork" |> NamespacedName

    /// <summary>
    /// beats per minute
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#beatsPerMinute"></see></summary>
    let beatsPerMinute =
        Namespaced_IRI.parse _namespace_name "beatsPerMinute" |> NamespacedName

    /// <summary>
    /// Signal where a radio can be tuned in. There can be more than one.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#carrier"></see></summary>
    let carrier = Namespaced_IRI.parse _namespace_name "carrier" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// Composer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#director"></see>
    /// </summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName
    /// <summary>
    /// Mimetypes as defined for DLNA (occasional differences compared to xdg-mime)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaMime"></see></summary>
    let dlnaMime = Namespaced_IRI.parse _namespace_name "dlnaMime" |> NamespacedName

    /// <summary>
    /// DLNA profile of the content, like MP3, MPEG_TS_HD_US, LPCM etc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaProfile"></see></summary>
    let dlnaProfile =
        Namespaced_IRI.parse _namespace_name "dlnaProfile" |> NamespacedName

    /// <summary>
    /// Encoding of the radio. It is a property of the streaming, that it is known before hand, so the applications can choose the encoding they understand.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#encoding"></see></summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName

    /// <summary>
    /// Episode number of a TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#episodeNumber"></see></summary>
    let episodeNumber =
        Namespaced_IRI.parse _namespace_name "episodeNumber" |> NamespacedName

    /// <summary>
    /// Exposure time of the photo
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#exposureTime"></see></summary>
    let exposureTime =
        Namespaced_IRI.parse _namespace_name "exposureTime" |> NamespacedName

    /// <summary>
    /// Specifies whether flash was used
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash"></see></summary>
    let flash = Namespaced_IRI.parse _namespace_name "flash" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-off"></see>
    /// </summary>
    let ``flash-off`` =
        Namespaced_IRI.parse _namespace_name "flash-off" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-on"></see>
    /// </summary>
    let ``flash-on`` = Namespaced_IRI.parse _namespace_name "flash-on" |> NamespacedName
    /// <summary>
    /// The diameter of the entrance pupil in terms of the focal length of the lens
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#fnumber"></see></summary>
    let fnumber = Namespaced_IRI.parse _namespace_name "fnumber" |> NamespacedName

    /// <summary>
    /// A measure of how strongly the lens converges light
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#focalLength"></see></summary>
    let focalLength =
        Namespaced_IRI.parse _namespace_name "focalLength" |> NamespacedName

    /// <summary>
    /// Frequency in the Radio spectrum in Khz (note that usually FM frequencies are in MHz)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#genre"></see>
    /// </summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    /// A TVSeries has many episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasEpisode"></see></summary>
    let hasEpisode = Namespaced_IRI.parse _namespace_name "hasEpisode" |> NamespacedName
    /// <summary>
    /// Relates a TV Series to its seasons
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeason"></see></summary>
    let hasSeason = Namespaced_IRI.parse _namespace_name "hasSeason" |> NamespacedName

    /// <summary>
    /// Relates a TV Show season to its episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeasonEpisode"></see></summary>
    let hasSeasonEpisode =
        Namespaced_IRI.parse _namespace_name "hasSeasonEpisode" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSubtitle"></see>
    /// </summary>
    let hasSubtitle =
        Namespaced_IRI.parse _namespace_name "hasSubtitle" |> NamespacedName

    /// <summary>
    /// ISRC ID. Format: 'CC-XXX-YY-NNNNN'
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#internationalStandardRecordingCode"></see></summary>
    let internationalStandardRecordingCode =
        Namespaced_IRI.parse _namespace_name "internationalStandardRecordingCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isColorCorrected"></see>
    /// </summary>
    let isColorCorrected =
        Namespaced_IRI.parse _namespace_name "isColorCorrected" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isContentEncrypted"></see>
    /// </summary>
    let isContentEncrypted =
        Namespaced_IRI.parse _namespace_name "isContentEncrypted" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isCropped"></see>
    /// </summary>
    let isCropped = Namespaced_IRI.parse _namespace_name "isCropped" |> NamespacedName

    /// <summary>
    /// Does text stream contain helper tags for hearing-impaired such as &amp;lt;steps in hallway&amp;gt;
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isForHearingImpaired"></see></summary>
    let isForHearingImpaired =
        Namespaced_IRI.parse _namespace_name "isForHearingImpaired" |> NamespacedName

    /// <summary>
    /// Relates a TV Show to its season
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isPartOfSeason"></see></summary>
    let isPartOfSeason =
        Namespaced_IRI.parse _namespace_name "isPartOfSeason" |> NamespacedName

    /// <summary>
    /// Measure of a photographic film's sensitivity to light as ISO value
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isoSpeed"></see></summary>
    let isoSpeed = Namespaced_IRI.parse _namespace_name "isoSpeed" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#leadActor"></see>
    /// </summary>
    let leadActor = Namespaced_IRI.parse _namespace_name "leadActor" |> NamespacedName
    /// <summary>
    /// Lyricist
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#lyricist"></see></summary>
    let lyricist = Namespaced_IRI.parse _namespace_name "lyricist" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#lyrics"></see>
    /// </summary>
    let lyrics = Namespaced_IRI.parse _namespace_name "lyrics" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-average"></see>
    /// </summary>
    let ``metering-mode-average`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-average" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-center-weighted-average"></see>
    /// </summary>
    let ``metering-mode-center-weighted-average`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-center-weighted-average" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-multispot"></see>
    /// </summary>
    let ``metering-mode-multispot`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-multispot" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-other"></see>
    /// </summary>
    let ``metering-mode-other`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-other" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-partial"></see>
    /// </summary>
    let ``metering-mode-partial`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-partial" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-pattern"></see>
    /// </summary>
    let ``metering-mode-pattern`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-spot"></see>
    /// </summary>
    let ``metering-mode-spot`` =
        Namespaced_IRI.parse _namespace_name "metering-mode-spot" |> NamespacedName

    /// <summary>
    /// Metering mode refers to the way in which a camera determines the exposure.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#meteringMode"></see></summary>
    let meteringMode =
        Namespaced_IRI.parse _namespace_name "meteringMode" |> NamespacedName

    /// <summary>
    /// Modulation used in the frequency (AM or FM)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#modulation"></see></summary>
    let modulation = Namespaced_IRI.parse _namespace_name "modulation" |> NamespacedName
    /// <summary>
    /// album the music belongs to
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbum"></see></summary>
    let musicAlbum = Namespaced_IRI.parse _namespace_name "musicAlbum" |> NamespacedName

    /// <summary>
    /// album disc the music belongs to
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbumDisc"></see></summary>
    let musicAlbumDisc =
        Namespaced_IRI.parse _namespace_name "musicAlbumDisc" |> NamespacedName

    /// <summary>
    /// Music CD identifier to for databases like FreeDB.org. This frame is intended for music that comes from a CD, so that the CD can be identified in databases such as the CDDB. The frame consists of a binary dump of the Table Of Contents, TOC, from the CD, which is a header of 4 bytes and then 8 bytes/track on the CD plus 8 bytes for the 'lead out' making a maximum of 804 bytes. The offset to the beginning of every track on the CD should be described with a four bytes absolute CD-frame address per track, and not with absolute time.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicCDIdentifier"></see></summary>
    let musicCDIdentifier =
        Namespaced_IRI.parse _namespace_name "musicCDIdentifier" |> NamespacedName

    /// <summary>
    /// Performer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#producedBy"></see>
    /// </summary>
    let producedBy = Namespaced_IRI.parse _namespace_name "producedBy" |> NamespacedName
    /// <summary>
    /// Protocol used for the streaming (HTTP, RTSP)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#protocol"></see></summary>
    let protocol = Namespaced_IRI.parse _namespace_name "protocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-am"></see>
    /// </summary>
    let ``radio-modulation-am`` =
        Namespaced_IRI.parse _namespace_name "radio-modulation-am" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-fm"></see>
    /// </summary>
    let ``radio-modulation-fm`` =
        Namespaced_IRI.parse _namespace_name "radio-modulation-fm" |> NamespacedName

    /// <summary>
    /// Image used as logo for a radio station
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radioIcon"></see></summary>
    let radioIcon = Namespaced_IRI.parse _namespace_name "radioIcon" |> NamespacedName
    /// <summary>
    /// PTY Code (content description) as integer. RDS specs define the translations into human readable descriptions for various languages
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radioPTY"></see></summary>
    let radioPTY = Namespaced_IRI.parse _namespace_name "radioPTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#runTime"></see>
    /// </summary>
    let runTime = Namespaced_IRI.parse _namespace_name "runTime" |> NamespacedName

    /// <summary>
    /// The number of a season
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonNumber"></see></summary>
    let seasonNumber =
        Namespaced_IRI.parse _namespace_name "seasonNumber" |> NamespacedName

    /// <summary>
    /// Relates a TV Season to its series
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonOf"></see></summary>
    let seasonOf = Namespaced_IRI.parse _namespace_name "seasonOf" |> NamespacedName
    /// <summary>
    /// Relates a TV Show to its TV series
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#series"></see></summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    /// Disc number of album disc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#setNumber"></see></summary>
    let setNumber = Namespaced_IRI.parse _namespace_name "setNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#skipCounter"></see>
    /// </summary>
    let skipCounter =
        Namespaced_IRI.parse _namespace_name "skipCounter" |> NamespacedName

    /// <summary>
    /// Bitrate indicating the quality of the stream in Kbits (usual values 32, 64, 128...)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#streamingBitrate"></see></summary>
    let streamingBitrate =
        Namespaced_IRI.parse _namespace_name "streamingBitrate" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#subtitle"></see>
    /// </summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName
    /// <summary>
    /// Long form description of video content (plot, premise, etc.)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#synopsis"></see></summary>
    let synopsis = Namespaced_IRI.parse _namespace_name "synopsis" |> NamespacedName

    /// <summary>
    /// Track number of the music in its album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#trackNumber"></see></summary>
    let trackNumber =
        Namespaced_IRI.parse _namespace_name "trackNumber" |> NamespacedName

    /// <summary>
    /// Tells the uPnP MediaServer (e.g. Rygel) whether to export/share the resource or not
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#uPnPShared"></see></summary>
    let uPnPShared = Namespaced_IRI.parse _namespace_name "uPnPShared" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-auto"></see>
    /// </summary>
    let ``white-balance-auto`` =
        Namespaced_IRI.parse _namespace_name "white-balance-auto" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-manual"></see>
    /// </summary>
    let ``white-balance-manual`` =
        Namespaced_IRI.parse _namespace_name "white-balance-manual" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#whiteBalance"></see>
    /// </summary>
    let whiteBalance =
        Namespaced_IRI.parse _namespace_name "whiteBalance" |> NamespacedName
