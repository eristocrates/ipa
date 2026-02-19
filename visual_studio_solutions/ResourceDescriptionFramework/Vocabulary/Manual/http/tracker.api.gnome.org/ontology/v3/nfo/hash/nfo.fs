namespace Nepomuk.nfo.v3.Namespace

module nfo =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nfo#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/33-nfo.ontology")
            (Some "nepomuk.nfo.v3")
            None

    let Document = { _prefixID with _localName = "Document" }
    let FileDataObject = { _prefixID with _localName = "FileDataObject" }
    let Software = { _prefixID with _localName = "Software" }
    let Media = { _prefixID with _localName = "Media" }
    let Visual = { _prefixID with _localName = "Visual" }
    let Image = { _prefixID with _localName = "Image" }
    let RasterImage = { _prefixID with _localName = "RasterImage" }
    let DataContainer = { _prefixID with _localName = "DataContainer" }
    let RemotePortAddress = { _prefixID with _localName = "RemotePortAddress" }
    let MediaFileListEntry = { _prefixID with _localName = "MediaFileListEntry" }
    let VectorImage = { _prefixID with _localName = "VectorImage" }
    let Audio = { _prefixID with _localName = "Audio" }
    let CompressionType = { _prefixID with _localName = "CompressionType" }
    let compressionType = { _prefixID with _localName = "compressionType" }
    let Icon = { _prefixID with _localName = "Icon" }
    let TextDocument = { _prefixID with _localName = "TextDocument" }
    let PlainTextDocument = { _prefixID with _localName = "PlainTextDocument" }
    let HtmlDocument = { _prefixID with _localName = "HtmlDocument" }
    let OperatingSystem = { _prefixID with _localName = "OperatingSystem" }
    let MediaList = { _prefixID with _localName = "MediaList" }
    let Executable = { _prefixID with _localName = "Executable" }
    let Folder = { _prefixID with _localName = "Folder" }
    let Font = { _prefixID with _localName = "Font" }
    let Filesystem = { _prefixID with _localName = "Filesystem" }
    let SoftwareService = { _prefixID with _localName = "SoftwareService" }
    let SoftwareItem = { _prefixID with _localName = "SoftwareItem" }
    let Presentation = { _prefixID with _localName = "Presentation" }
    let RemoteDataObject = { _prefixID with _localName = "RemoteDataObject" }
    let PaginatedTextDocument = { _prefixID with _localName = "PaginatedTextDocument" }
    let Video = { _prefixID with _localName = "Video" }
    let Spreadsheet = { _prefixID with _localName = "Spreadsheet" }
    let Trash = { _prefixID with _localName = "Trash" }
    let FileHash = { _prefixID with _localName = "FileHash" }
    let SourceCode = { _prefixID with _localName = "SourceCode" }
    let Application = { _prefixID with _localName = "Application" }

    let EmbeddedFileDataObject =
        { _prefixID with _localName = "EmbeddedFileDataObject" }

    let Attachment = { _prefixID with _localName = "Attachment" }
    let ArchiveItem = { _prefixID with _localName = "ArchiveItem" }
    let Archive = { _prefixID with _localName = "Archive" }
    let MindMap = { _prefixID with _localName = "MindMap" }
    let MediaStream = { _prefixID with _localName = "MediaStream" }
    let BookmarkFolder = { _prefixID with _localName = "BookmarkFolder" }
    let containsBookmark = { _prefixID with _localName = "containsBookmark" }
    let FilesystemImage = { _prefixID with _localName = "FilesystemImage" }
    let HardDiskPartition = { _prefixID with _localName = "HardDiskPartition" }
    let Cursor = { _prefixID with _localName = "Cursor" }
    let Bookmark = { _prefixID with _localName = "Bookmark" }
    let bookmarks = { _prefixID with _localName = "bookmarks" }
    let DeletedResource = { _prefixID with _localName = "DeletedResource" }
    let Website = { _prefixID with _localName = "Website" }
    let WebHistory = { _prefixID with _localName = "WebHistory" }
    let count = { _prefixID with _localName = "count" }
    let channels = { _prefixID with _localName = "channels" }
    let sideChannels = { _prefixID with _localName = "sideChannels" }
    let frameRate = { _prefixID with _localName = "frameRate" }
    let commentCharacterCount = { _prefixID with _localName = "commentCharacterCount" }
    let duration = { _prefixID with _localName = "duration" }
    let wordCount = { _prefixID with _localName = "wordCount" }
    let fileLastAccessed = { _prefixID with _localName = "fileLastAccessed" }
    let fileCreated = { _prefixID with _localName = "fileCreated" }
    let belongsToContainer = { _prefixID with _localName = "belongsToContainer" }
    let aspectRatio = { _prefixID with _localName = "aspectRatio" }
    let heading = { _prefixID with _localName = "heading" }
    let tilt = { _prefixID with _localName = "tilt" }
    let fileSize = { _prefixID with _localName = "fileSize" }
    let conflicts = { _prefixID with _localName = "conflicts" }
    let hashValue = { _prefixID with _localName = "hashValue" }
    let pageCount = { _prefixID with _localName = "pageCount" }
    let programmingLanguage = { _prefixID with _localName = "programmingLanguage" }
    let definesClass = { _prefixID with _localName = "definesClass" }
    let interlaceMode = { _prefixID with _localName = "interlaceMode" }
    let permissions = { _prefixID with _localName = "permissions" }
    let lfeChannels = { _prefixID with _localName = "lfeChannels" }
    let supercedes = { _prefixID with _localName = "supercedes" }
    let definesFunction = { _prefixID with _localName = "definesFunction" }
    let hasMediaFileListEntry = { _prefixID with _localName = "hasMediaFileListEntry" }
    let entryCounter = { _prefixID with _localName = "entryCounter" }
    let listDuration = { _prefixID with _localName = "listDuration" }
    let listPosition = { _prefixID with _localName = "listPosition" }
    let entryUrl = { _prefixID with _localName = "entryUrl" }
    let height = { _prefixID with _localName = "height" }
    let hashAlgorithm = { _prefixID with _localName = "hashAlgorithm" }
    let fileName = { _prefixID with _localName = "fileName" }
    let encoding = { _prefixID with _localName = "encoding" }
    let verticalResolution = { _prefixID with _localName = "verticalResolution" }
    let definesGlobalVariable = { _prefixID with _localName = "definesGlobalVariable" }
    let hasMediaStream = { _prefixID with _localName = "hasMediaStream" }
    let width = { _prefixID with _localName = "width" }
    let sampleCount = { _prefixID with _localName = "sampleCount" }
    let tableOfContents = { _prefixID with _localName = "tableOfContents" }
    let Note = { _prefixID with _localName = "Note" }
    let lineCount = { _prefixID with _localName = "lineCount" }
    let bitDepth = { _prefixID with _localName = "bitDepth" }
    let bitsPerSample = { _prefixID with _localName = "bitsPerSample" }
    let hasHash = { _prefixID with _localName = "hasHash" }
    let fileOwner = { _prefixID with _localName = "fileOwner" }

    let containsBookmarkFolder =
        { _prefixID with _localName = "containsBookmarkFolder" }

    let codec = { _prefixID with _localName = "codec" }
    let encodedBy = { _prefixID with _localName = "encodedBy" }
    let fontFamily = { _prefixID with _localName = "fontFamily" }
    let frontChannels = { _prefixID with _localName = "frontChannels" }
    let originalLocation = { _prefixID with _localName = "originalLocation" }
    let foundry = { _prefixID with _localName = "foundry" }
    let colorDepth = { _prefixID with _localName = "colorDepth" }
    let frameCount = { _prefixID with _localName = "frameCount" }
    let horizontalResolution = { _prefixID with _localName = "horizontalResolution" }
    let characterCount = { _prefixID with _localName = "characterCount" }
    let bitrateType = { _prefixID with _localName = "bitrateType" }
    let isPasswordProtected = { _prefixID with _localName = "isPasswordProtected" }
    let sampleRate = { _prefixID with _localName = "sampleRate" }
    let fileLastModified = { _prefixID with _localName = "fileLastModified" }
    let averageBitrate = { _prefixID with _localName = "averageBitrate" }
    let averageVideoBitrate = { _prefixID with _localName = "averageVideoBitrate" }
    let averageAudioBitrate = { _prefixID with _localName = "averageAudioBitrate" }
    let deletionDate = { _prefixID with _localName = "deletionDate" }
    let depiction = { _prefixID with _localName = "depiction" }
    let depicts = { _prefixID with _localName = "depicts" }
    let uncompressedSize = { _prefixID with _localName = "uncompressedSize" }
    let rearChannels = { _prefixID with _localName = "rearChannels" }
    let genre = { _prefixID with _localName = "genre" }
    let gain = { _prefixID with _localName = "gain" }
    let peakGain = { _prefixID with _localName = "peakGain" }
    let characterPosition = { _prefixID with _localName = "characterPosition" }
    let pageNumber = { _prefixID with _localName = "pageNumber" }
    let streamPosition = { _prefixID with _localName = "streamPosition" }
    let streamDuration = { _prefixID with _localName = "streamDuration" }
    let domain = { _prefixID with _localName = "domain" }
    let uri = { _prefixID with _localName = "uri" }
    let ImageCategory = { _prefixID with _localName = "ImageCategory" }

    let ``image-category-screenshot`` =
        { _prefixID with _localName = "image-category-screenshot" }

    let SoftwareCategory = { _prefixID with _localName = "SoftwareCategory" }
    let softwareCategoryIcon = { _prefixID with _localName = "softwareCategoryIcon" }
    let SoftwareApplication = { _prefixID with _localName = "SoftwareApplication" }
    let softwareIcon = { _prefixID with _localName = "softwareIcon" }
    let softwareCmdLine = { _prefixID with _localName = "softwareCmdLine" }
    let Orientation = { _prefixID with _localName = "Orientation" }
    let ``orientation-top`` = { _prefixID with _localName = "orientation-top" }

    let ``orientation-top-mirror`` =
        { _prefixID with _localName = "orientation-top-mirror" }

    let ``orientation-bottom`` = { _prefixID with _localName = "orientation-bottom" }

    let ``orientation-bottom-mirror`` =
        { _prefixID with _localName = "orientation-bottom-mirror" }

    let ``orientation-left-mirror`` =
        { _prefixID with _localName = "orientation-left-mirror" }

    let ``orientation-right`` = { _prefixID with _localName = "orientation-right" }

    let ``orientation-right-mirror`` =
        { _prefixID with _localName = "orientation-right-mirror" }

    let ``orientation-left`` = { _prefixID with _localName = "orientation-left" }
    let orientation = { _prefixID with _localName = "orientation" }
    let mediaListEntry = { _prefixID with _localName = "mediaListEntry" }
    let isContentEncrypted = { _prefixID with _localName = "isContentEncrypted" }
    let isBootable = { _prefixID with _localName = "isBootable" }
    let Equipment = { _prefixID with _localName = "Equipment" }
    let equipment = { _prefixID with _localName = "equipment" }
    let manufacturer = { _prefixID with _localName = "manufacturer" }
    let model = { _prefixID with _localName = "model" }
    let equipmentSoftware = { _prefixID with _localName = "equipmentSoftware" }
    let HelpDocument = { _prefixID with _localName = "HelpDocument" }
    let EBook = { _prefixID with _localName = "EBook" }
    let lastPlayedPosition = { _prefixID with _localName = "lastPlayedPosition" }
    let audioOffset = { _prefixID with _localName = "audioOffset" }
    let RegionOfInterest = { _prefixID with _localName = "RegionOfInterest" }
    let regionOfInterestX = { _prefixID with _localName = "regionOfInterestX" }
    let regionOfInterestY = { _prefixID with _localName = "regionOfInterestY" }
    let regionOfInterestWidth = { _prefixID with _localName = "regionOfInterestWidth" }

    let regionOfInterestHeight =
        { _prefixID with _localName = "regionOfInterestHeight" }

    let RegionOfInterestContent =
        { _prefixID with _localName = "RegionOfInterestContent" }

    let ``roi-content-face`` = { _prefixID with _localName = "roi-content-face" }
    let ``roi-content-pet`` = { _prefixID with _localName = "roi-content-pet" }
    let ``roi-content-focus`` = { _prefixID with _localName = "roi-content-focus" }
    let ``roi-content-barcode`` = { _prefixID with _localName = "roi-content-barcode" }

    let ``roi-content-undefined`` =
        { _prefixID with _localName = "roi-content-undefined" }

    let regionOfInterestType = { _prefixID with _localName = "regionOfInterestType" }
    let hasRegionOfInterest = { _prefixID with _localName = "hasRegionOfInterest" }
    let roiRefersTo = { _prefixID with _localName = "roiRefersTo" }
    let GameImage = { _prefixID with _localName = "GameImage" }
