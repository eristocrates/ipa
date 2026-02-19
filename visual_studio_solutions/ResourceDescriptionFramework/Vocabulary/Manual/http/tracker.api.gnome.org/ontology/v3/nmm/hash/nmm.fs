namespace Nepomuk.nmm.v3.Namespace

module nmm =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nmm#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/38-nmm.ontology")
            (Some "nepomuk.nmm.v3")
            None

    let MusicPiece = { _prefixID with _localName = "MusicPiece" }
    let MusicAlbum = { _prefixID with _localName = "MusicAlbum" }
    let MusicAlbumDisc = { _prefixID with _localName = "MusicAlbumDisc" }
    let albumDiscAlbum = { _prefixID with _localName = "albumDiscAlbum" }
    let SynchronizedText = { _prefixID with _localName = "SynchronizedText" }
    let Video = { _prefixID with _localName = "Video" }
    let Artist = { _prefixID with _localName = "Artist" }
    let Playlist = { _prefixID with _localName = "Playlist" }
    let Movie = { _prefixID with _localName = "Movie" }
    let TVSeason = { _prefixID with _localName = "TVSeason" }
    let TVSeries = { _prefixID with _localName = "TVSeries" }
    let TVShow = { _prefixID with _localName = "TVShow" }
    let artistName = { _prefixID with _localName = "artistName" }
    let musicAlbum = { _prefixID with _localName = "musicAlbum" }
    let musicAlbumDisc = { _prefixID with _localName = "musicAlbumDisc" }
    let albumArtist = { _prefixID with _localName = "albumArtist" }
    let beatsPerMinute = { _prefixID with _localName = "beatsPerMinute" }
    let artist = { _prefixID with _localName = "artist" }
    let performer = { _prefixID with _localName = "performer" }
    let composer = { _prefixID with _localName = "composer" }
    let lyricist = { _prefixID with _localName = "lyricist" }
    let lyrics = { _prefixID with _localName = "lyrics" }
    let trackNumber = { _prefixID with _localName = "trackNumber" }
    let isForHearingImpaired = { _prefixID with _localName = "isForHearingImpaired" }
    let musicCDIdentifier = { _prefixID with _localName = "musicCDIdentifier" }

    let internationalStandardRecordingCode =
        { _prefixID with _localName = "internationalStandardRecordingCode" }

    let albumTrackCount = { _prefixID with _localName = "albumTrackCount" }
    let artwork = { _prefixID with _localName = "artwork" }
    let albumDuration = { _prefixID with _localName = "albumDuration" }
    let albumGain = { _prefixID with _localName = "albumGain" }
    let albumPeakGain = { _prefixID with _localName = "albumPeakGain" }
    let setNumber = { _prefixID with _localName = "setNumber" }
    let episodeNumber = { _prefixID with _localName = "episodeNumber" }
    let runTime = { _prefixID with _localName = "runTime" }
    let synopsis = { _prefixID with _localName = "synopsis" }
    let MPAARating = { _prefixID with _localName = "MPAARating" }
    let category = { _prefixID with _localName = "category" }
    let genre = { _prefixID with _localName = "genre" }
    let director = { _prefixID with _localName = "director" }
    let producer = { _prefixID with _localName = "producer" }
    let producedBy = { _prefixID with _localName = "producedBy" }
    let leadActor = { _prefixID with _localName = "leadActor" }
    let hasSubtitle = { _prefixID with _localName = "hasSubtitle" }
    let subtitle = { _prefixID with _localName = "subtitle" }
    let isContentEncrypted = { _prefixID with _localName = "isContentEncrypted" }
    let skipCounter = { _prefixID with _localName = "skipCounter" }
    let ImageList = { _prefixID with _localName = "ImageList" }
    let Photo = { _prefixID with _localName = "Photo" }
    let exposureTime = { _prefixID with _localName = "exposureTime" }
    let Flash = { _prefixID with _localName = "Flash" }
    let ``flash-on`` = { _prefixID with _localName = "flash-on" }
    let ``flash-off`` = { _prefixID with _localName = "flash-off" }
    let flash = { _prefixID with _localName = "flash" }
    let fnumber = { _prefixID with _localName = "fnumber" }
    let focalLength = { _prefixID with _localName = "focalLength" }
    let isoSpeed = { _prefixID with _localName = "isoSpeed" }
    let MeteringMode = { _prefixID with _localName = "MeteringMode" }

    let ``metering-mode-average`` =
        { _prefixID with _localName = "metering-mode-average" }

    let ``metering-mode-center-weighted-average`` =
        { _prefixID with _localName = "metering-mode-center-weighted-average" }

    let ``metering-mode-spot`` = { _prefixID with _localName = "metering-mode-spot" }

    let ``metering-mode-multispot`` =
        { _prefixID with _localName = "metering-mode-multispot" }

    let ``metering-mode-pattern`` =
        { _prefixID with _localName = "metering-mode-pattern" }

    let ``metering-mode-partial`` =
        { _prefixID with _localName = "metering-mode-partial" }

    let ``metering-mode-other`` = { _prefixID with _localName = "metering-mode-other" }
    let meteringMode = { _prefixID with _localName = "meteringMode" }
    let WhiteBalance = { _prefixID with _localName = "WhiteBalance" }
    let ``white-balance-auto`` = { _prefixID with _localName = "white-balance-auto" }

    let ``white-balance-manual`` =
        { _prefixID with _localName = "white-balance-manual" }

    let whiteBalance = { _prefixID with _localName = "whiteBalance" }
    let isCropped = { _prefixID with _localName = "isCropped" }
    let isColorCorrected = { _prefixID with _localName = "isColorCorrected" }
    let RadioStation = { _prefixID with _localName = "RadioStation" }
    let radioIcon = { _prefixID with _localName = "radioIcon" }
    let radioPTY = { _prefixID with _localName = "radioPTY" }
    let carrier = { _prefixID with _localName = "carrier" }
    let DigitalRadio = { _prefixID with _localName = "DigitalRadio" }
    let AnalogRadio = { _prefixID with _localName = "AnalogRadio" }
    let RadioModulation = { _prefixID with _localName = "RadioModulation" }
    let ``radio-modulation-am`` = { _prefixID with _localName = "radio-modulation-am" }
    let ``radio-modulation-fm`` = { _prefixID with _localName = "radio-modulation-fm" }
    let modulation = { _prefixID with _localName = "modulation" }
    let frequency = { _prefixID with _localName = "frequency" }
    let streamingBitrate = { _prefixID with _localName = "streamingBitrate" }
    let encoding = { _prefixID with _localName = "encoding" }
    let protocol = { _prefixID with _localName = "protocol" }
    let alternativeMedia = { _prefixID with _localName = "alternativeMedia" }
    let dlnaProfile = { _prefixID with _localName = "dlnaProfile" }
    let dlnaMime = { _prefixID with _localName = "dlnaMime" }
    let uPnPShared = { _prefixID with _localName = "uPnPShared" }
    let hasSeasonEpisode = { _prefixID with _localName = "hasSeasonEpisode" }
    let seasonNumber = { _prefixID with _localName = "seasonNumber" }
    let seasonOf = { _prefixID with _localName = "seasonOf" }
    let hasEpisode = { _prefixID with _localName = "hasEpisode" }
    let hasSeason = { _prefixID with _localName = "hasSeason" }
    let isPartOfSeason = { _prefixID with _localName = "isPartOfSeason" }
    let series = { _prefixID with _localName = "series" }
