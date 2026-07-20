namespace http.tracker.api.gnome.org.ontology.v3.nmm.hash

open DoxAletheia

module tnmm =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nmm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// FM Radio carrier signal data. Basically the frequency
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#AnalogRadio"></see></summary>
    let AnalogRadio = _prefix "AnalogRadio"
    /// <summary>
    /// An artist.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Artist"></see></summary>
    let Artist = _prefix "Artist"
    /// <summary>
    /// Online Radio Stream data object (i.e. as a raw flow of bytes)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#DigitalRadio"></see></summary>
    let DigitalRadio = _prefix "DigitalRadio"
    /// <summary>
    /// Enumeration of the possible values of flash property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Flash"></see></summary>
    let Flash = _prefix "Flash"
    /// <summary>
    /// An album of images
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#ImageList"></see></summary>
    let ImageList = _prefix "ImageList"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MPAARating"></see>
    /// </summary>
    let MPAARating = _prefix "MPAARating"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    /// Enumeration of different ways a camera determines exposure.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MeteringMode"></see></summary>
    let MeteringMode = _prefix "MeteringMode"
    /// <summary>
    /// A Movie
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Movie"></see></summary>
    let Movie = _prefix "Movie"
    /// <summary>
    /// The music album as provided by the publisher. Not to be confused with media lists or collections
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbum"></see></summary>
    let MusicAlbum = _prefix "MusicAlbum"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicAlbumDisc"></see>
    /// </summary>
    let MusicAlbumDisc = _prefix "MusicAlbumDisc"
    /// <summary>
    /// Used to assign music-specific properties such as BPM to video and audio
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#MusicPiece"></see></summary>
    let MusicPiece = _prefix "MusicPiece"
    /// <summary>
    /// A photo
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Photo"></see></summary>
    let Photo = _prefix "Photo"
    /// <summary>
    /// Specific class to split MediaList in Albums and playlists.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// Set of instances for analog radio modulation
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioModulation"></see></summary>
    let RadioModulation = _prefix "RadioModulation"
    /// <summary>
    /// The Radio station in user terms: BBC3, Radio5, YLEX, ... It is linked with 1 or more carriers (different FM frenquencies, online sources in different qualities, etc.). Some RDS information is represented with nie properties, nie:identifier for PI, nie:title for PS
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#RadioStation"></see></summary>
    let RadioStation = _prefix "RadioStation"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#SynchronizedText"></see>
    /// </summary>
    let SynchronizedText = _prefix "SynchronizedText"
    /// <summary>
    /// A season of a TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeason"></see></summary>
    let TVSeason = _prefix "TVSeason"
    /// <summary>
    /// A TV Series has multiple seasons and episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVSeries"></see></summary>
    let TVSeries = _prefix "TVSeries"
    /// <summary>
    /// A TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#TVShow"></see></summary>
    let TVShow = _prefix "TVShow"
    /// <summary>
    /// Camera's white balance setting
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#WhiteBalance"></see></summary>
    let WhiteBalance = _prefix "WhiteBalance"
    /// <summary>
    /// main artists of the album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumArtist"></see></summary>
    let albumArtist = _prefix "albumArtist"
    /// <summary>
    /// Album of the disc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDiscAlbum"></see></summary>
    let albumDiscAlbum = _prefix "albumDiscAlbum"
    /// <summary>
    /// Duration of the album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumDuration"></see></summary>
    let albumDuration = _prefix "albumDuration"
    /// <summary>
    /// Gain of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumGain"></see></summary>
    let albumGain = _prefix "albumGain"
    /// <summary>
    /// Peak Gain of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumPeakGain"></see></summary>
    let albumPeakGain = _prefix "albumPeakGain"
    /// <summary>
    /// Track count of album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#albumTrackCount"></see></summary>
    let albumTrackCount = _prefix "albumTrackCount"
    /// <summary>
    /// Link between to different version of the same media. This is used for instances in uPnp where the server can provide the same video in different resolutions and codecs
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#alternativeMedia"></see></summary>
    let alternativeMedia = _prefix "alternativeMedia"
    /// <summary>
    /// main artist of the MusicPiece
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artist"></see></summary>
    let artist = _prefix "artist"
    /// <summary>
    /// Name of the artist
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artistName"></see></summary>
    let artistName = _prefix "artistName"
    /// <summary>
    /// Associated Artwork
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#artwork"></see></summary>
    let artwork = _prefix "artwork"
    /// <summary>
    /// beats per minute
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#beatsPerMinute"></see></summary>
    let beatsPerMinute = _prefix "beatsPerMinute"
    /// <summary>
    /// Signal where a radio can be tuned in. There can be more than one.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#carrier"></see></summary>
    let carrier = _prefix "carrier"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    /// Composer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#director"></see>
    /// </summary>
    let director = _prefix "director"
    /// <summary>
    /// Mimetypes as defined for DLNA (occasional differences compared to xdg-mime)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaMime"></see></summary>
    let dlnaMime = _prefix "dlnaMime"
    /// <summary>
    /// DLNA profile of the content, like MP3, MPEG_TS_HD_US, LPCM etc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#dlnaProfile"></see></summary>
    let dlnaProfile = _prefix "dlnaProfile"
    /// <summary>
    /// Encoding of the radio. It is a property of the streaming, that it is known before hand, so the applications can choose the encoding they understand.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// Episode number of a TV show
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#episodeNumber"></see></summary>
    let episodeNumber = _prefix "episodeNumber"
    /// <summary>
    /// Exposure time of the photo
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#exposureTime"></see></summary>
    let exposureTime = _prefix "exposureTime"
    /// <summary>
    /// Specifies whether flash was used
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash"></see></summary>
    let flash = _prefix "flash"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-off"></see>
    /// </summary>
    let ``flash-off`` = _prefix "flash-off"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#flash-on"></see>
    /// </summary>
    let ``flash-on`` = _prefix "flash-on"
    /// <summary>
    /// The diameter of the entrance pupil in terms of the focal length of the lens
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#fnumber"></see></summary>
    let fnumber = _prefix "fnumber"
    /// <summary>
    /// A measure of how strongly the lens converges light
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#focalLength"></see></summary>
    let focalLength = _prefix "focalLength"
    /// <summary>
    /// Frequency in the Radio spectrum in Khz (note that usually FM frequencies are in MHz)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#genre"></see>
    /// </summary>
    let genre = _prefix "genre"
    /// <summary>
    /// A TVSeries has many episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasEpisode"></see></summary>
    let hasEpisode = _prefix "hasEpisode"
    /// <summary>
    /// Relates a TV Series to its seasons
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeason"></see></summary>
    let hasSeason = _prefix "hasSeason"
    /// <summary>
    /// Relates a TV Show season to its episodes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSeasonEpisode"></see></summary>
    let hasSeasonEpisode = _prefix "hasSeasonEpisode"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#hasSubtitle"></see>
    /// </summary>
    let hasSubtitle = _prefix "hasSubtitle"

    /// <summary>
    /// ISRC ID. Format: 'CC-XXX-YY-NNNNN'
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#internationalStandardRecordingCode"></see></summary>
    let internationalStandardRecordingCode =
        _prefix "internationalStandardRecordingCode"

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isColorCorrected"></see>
    /// </summary>
    let isColorCorrected = _prefix "isColorCorrected"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isContentEncrypted"></see>
    /// </summary>
    let isContentEncrypted = _prefix "isContentEncrypted"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isCropped"></see>
    /// </summary>
    let isCropped = _prefix "isCropped"
    /// <summary>
    /// Does text stream contain helper tags for hearing-impaired such as &amp;lt;steps in hallway&amp;gt;
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isForHearingImpaired"></see></summary>
    let isForHearingImpaired = _prefix "isForHearingImpaired"
    /// <summary>
    /// Relates a TV Show to its season
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isPartOfSeason"></see></summary>
    let isPartOfSeason = _prefix "isPartOfSeason"
    /// <summary>
    /// Measure of a photographic film's sensitivity to light as ISO value
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#isoSpeed"></see></summary>
    let isoSpeed = _prefix "isoSpeed"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#leadActor"></see>
    /// </summary>
    let leadActor = _prefix "leadActor"
    /// <summary>
    /// Lyricist
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#lyricist"></see></summary>
    let lyricist = _prefix "lyricist"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#lyrics"></see>
    /// </summary>
    let lyrics = _prefix "lyrics"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-average"></see>
    /// </summary>
    let ``metering-mode-average`` = _prefix "metering-mode-average"

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-center-weighted-average"></see>
    /// </summary>
    let ``metering-mode-center-weighted-average`` =
        _prefix "metering-mode-center-weighted-average"

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-multispot"></see>
    /// </summary>
    let ``metering-mode-multispot`` = _prefix "metering-mode-multispot"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-other"></see>
    /// </summary>
    let ``metering-mode-other`` = _prefix "metering-mode-other"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-partial"></see>
    /// </summary>
    let ``metering-mode-partial`` = _prefix "metering-mode-partial"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-pattern"></see>
    /// </summary>
    let ``metering-mode-pattern`` = _prefix "metering-mode-pattern"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#metering-mode-spot"></see>
    /// </summary>
    let ``metering-mode-spot`` = _prefix "metering-mode-spot"
    /// <summary>
    /// Metering mode refers to the way in which a camera determines the exposure.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#meteringMode"></see></summary>
    let meteringMode = _prefix "meteringMode"
    /// <summary>
    /// Modulation used in the frequency (AM or FM)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#modulation"></see></summary>
    let modulation = _prefix "modulation"
    /// <summary>
    /// album the music belongs to
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbum"></see></summary>
    let musicAlbum = _prefix "musicAlbum"
    /// <summary>
    /// album disc the music belongs to
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicAlbumDisc"></see></summary>
    let musicAlbumDisc = _prefix "musicAlbumDisc"
    /// <summary>
    /// Music CD identifier to for databases like FreeDB.org. This frame is intended for music that comes from a CD, so that the CD can be identified in databases such as the CDDB. The frame consists of a binary dump of the Table Of Contents, TOC, from the CD, which is a header of 4 bytes and then 8 bytes/track on the CD plus 8 bytes for the 'lead out' making a maximum of 804 bytes. The offset to the beginning of every track on the CD should be described with a four bytes absolute CD-frame address per track, and not with absolute time.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#musicCDIdentifier"></see></summary>
    let musicCDIdentifier = _prefix "musicCDIdentifier"
    /// <summary>
    /// Performer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#producedBy"></see>
    /// </summary>
    let producedBy = _prefix "producedBy"
    /// <summary>
    /// Protocol used for the streaming (HTTP, RTSP)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#protocol"></see></summary>
    let protocol = _prefix "protocol"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-am"></see>
    /// </summary>
    let ``radio-modulation-am`` = _prefix "radio-modulation-am"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radio-modulation-fm"></see>
    /// </summary>
    let ``radio-modulation-fm`` = _prefix "radio-modulation-fm"
    /// <summary>
    /// Image used as logo for a radio station
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radioIcon"></see></summary>
    let radioIcon = _prefix "radioIcon"
    /// <summary>
    /// PTY Code (content description) as integer. RDS specs define the translations into human readable descriptions for various languages
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#radioPTY"></see></summary>
    let radioPTY = _prefix "radioPTY"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#runTime"></see>
    /// </summary>
    let runTime = _prefix "runTime"
    /// <summary>
    /// The number of a season
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonNumber"></see></summary>
    let seasonNumber = _prefix "seasonNumber"
    /// <summary>
    /// Relates a TV Season to its series
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#seasonOf"></see></summary>
    let seasonOf = _prefix "seasonOf"
    /// <summary>
    /// Relates a TV Show to its TV series
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#series"></see></summary>
    let series = _prefix "series"
    /// <summary>
    /// Disc number of album disc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#setNumber"></see></summary>
    let setNumber = _prefix "setNumber"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#skipCounter"></see>
    /// </summary>
    let skipCounter = _prefix "skipCounter"
    /// <summary>
    /// Bitrate indicating the quality of the stream in Kbits (usual values 32, 64, 128...)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#streamingBitrate"></see></summary>
    let streamingBitrate = _prefix "streamingBitrate"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#subtitle"></see>
    /// </summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// Long form description of video content (plot, premise, etc.)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#synopsis"></see></summary>
    let synopsis = _prefix "synopsis"
    /// <summary>
    /// Track number of the music in its album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#trackNumber"></see></summary>
    let trackNumber = _prefix "trackNumber"
    /// <summary>
    /// Tells the uPnP MediaServer (e.g. Rygel) whether to export/share the resource or not
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nmm#uPnPShared"></see></summary>
    let uPnPShared = _prefix "uPnPShared"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-auto"></see>
    /// </summary>
    let ``white-balance-auto`` = _prefix "white-balance-auto"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#white-balance-manual"></see>
    /// </summary>
    let ``white-balance-manual`` = _prefix "white-balance-manual"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nmm#whiteBalance"></see>
    /// </summary>
    let whiteBalance = _prefix "whiteBalance"
