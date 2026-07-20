namespace http.tracker.api.gnome.org.ontology.v3.nfo.hash

open DoxAletheia

module tnfo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An application
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// A piece of software. Examples may include applications and the operating system. This interpretation most commonly applies to SoftwareItems.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// A compressed file. May contain other files or folder inside.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// A superclass for all entities, whose primary purpose is to serve as containers for other data object. They usually don't have any 'meaning' by themselves. Examples include folders, archives and optical disc images.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#DataContainer"></see></summary>
    let DataContainer = _prefix "DataContainer"
    /// <summary>
    /// A file entity inside an archive.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#ArchiveItem"></see></summary>
    let ArchiveItem = _prefix "ArchiveItem"
    /// <summary>
    /// A file embedded in another data object. There are many ways in which a file may be embedded in another one. Use this class directly only in cases if none of the subclasses gives a better description of your case.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#EmbeddedFileDataObject"></see></summary>
    let EmbeddedFileDataObject = _prefix "EmbeddedFileDataObject"
    /// <summary>
    /// A file attached to another data object. Many data formats allow for attachments: emails, vcards, ical events, id3 and exif...
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Attachment"></see></summary>
    let Attachment = _prefix "Attachment"
    /// <summary>
    /// A file containing audio content
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Audio"></see></summary>
    let Audio = _prefix "Audio"
    /// <summary>
    /// A piece of media content. This class may be used to express complex media containers with many streams of various media content (both aural and visual).
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Media"></see></summary>
    let Media = _prefix "Media"
    /// <summary>
    /// A bookmark of a webbrowser. Use nie:title for the name/label, nie:contentCreated to represent the date when the user added the bookmark, and nie:contentLastModified for modifications. nfo:bookmarks to store the link.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Bookmark"></see></summary>
    let Bookmark = _prefix "Bookmark"
    /// <summary>
    /// A folder with bookmarks of a webbrowser. Use nfo:containsBookmark to relate Bookmarks. Folders can contain subfolders, use containsBookmarkFolder to relate them.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#BookmarkFolder"></see></summary>
    let BookmarkFolder = _prefix "BookmarkFolder"
    /// <summary>
    /// Type of compression. Instances of this class represent the limited set of values allowed for the nfo:compressionType property.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#CompressionType"></see></summary>
    let CompressionType = _prefix "CompressionType"
    /// <summary>
    /// A Cursor.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Cursor"></see></summary>
    let Cursor = _prefix "Cursor"
    /// <summary>
    /// A raster image.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#RasterImage"></see></summary>
    let RasterImage = _prefix "RasterImage"
    /// <summary>
    /// A file entity that has been deleted from the original source. Usually such entities are stored within various kinds of 'Trash' or 'Recycle Bin' folders.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#DeletedResource"></see></summary>
    let DeletedResource = _prefix "DeletedResource"
    /// <summary>
    /// A resource containing a finite sequence of bytes with arbitrary information, that is available to a computer program and is usually based on some kind of durable storage. A file is durable in the sense that it remains available for programs to use after the current program has finished.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#FileDataObject"></see></summary>
    let FileDataObject = _prefix "FileDataObject"
    /// <summary>
    /// A generic document. A common superclass for all documents on the desktop.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// Books which can be electronically viewed
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#EBook"></see></summary>
    let EBook = _prefix "EBook"
    /// <summary>
    /// A file containing a text document, that is unambiguously divided into pages. Examples might include PDF, DOC, PS', DVI etc.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#PaginatedTextDocument"></see></summary>
    let PaginatedTextDocument = _prefix "PaginatedTextDocument"
    /// <summary>
    /// The equipment used to create media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    /// An executable file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Executable"></see></summary>
    let Executable = _prefix "Executable"
    /// <summary>
    /// A fingerprint of the file, generated by some hashing function.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#FileHash"></see></summary>
    let FileHash = _prefix "FileHash"
    /// <summary>
    /// A filesystem. Examples of filesystems include hard disk partitions, removable media, but also images thereof stored in files.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Filesystem"></see></summary>
    let Filesystem = _prefix "Filesystem"
    /// <summary>
    /// An image of a filesystem. Instances of this class may include CD images, DVD images or hard disk partition images created by various pieces of software (e.g. Norton Ghost)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#FilesystemImage"></see></summary>
    let FilesystemImage = _prefix "FilesystemImage"
    /// <summary>
    /// A folder/directory. Examples of folders include folders on a filesystem and message folders in a mailbox.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Folder"></see></summary>
    let Folder = _prefix "Folder"
    /// <summary>
    /// A font.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Font"></see></summary>
    let Font = _prefix "Font"
    /// <summary>
    /// A game image. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#GameImage"></see></summary>
    let GameImage = _prefix "GameImage"
    /// <summary>
    /// An application
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareApplication"></see></summary>
    let SoftwareApplication = _prefix "SoftwareApplication"
    /// <summary>
    /// A partition on a hard disk
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#HardDiskPartition"></see></summary>
    let HardDiskPartition = _prefix "HardDiskPartition"
    /// <summary>
    /// User guides and similar to assist the user
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#HelpDocument"></see></summary>
    let HelpDocument = _prefix "HelpDocument"
    /// <summary>
    /// A HTML document, may contain links to other files.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#HtmlDocument"></see></summary>
    let HtmlDocument = _prefix "HtmlDocument"
    /// <summary>
    /// A file containing plain text (ASCII, Unicode or other encodings). Examples may include TXT, HTML, XML, program source code etc.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#PlainTextDocument"></see></summary>
    let PlainTextDocument = _prefix "PlainTextDocument"
    /// <summary>
    /// An Icon (regardless of whether it's a raster or a vector icon. A resource representing an icon could have two types (Icon and Raster, or Icon and Vector) if required.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Icon"></see></summary>
    let Icon = _prefix "Icon"
    /// <summary>
    /// A file containing an image.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// File containing visual content.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Visual"></see></summary>
    let Visual = _prefix "Visual"
    /// <summary>
    /// A image category
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#ImageCategory"></see></summary>
    let ImageCategory = _prefix "ImageCategory"
    /// <summary>
    /// A single node in the list of media files contained within an MediaList instance. This class is intended to provide a type all those links have. In valid NRL untyped resources cannot be linked. There are no properties defined for this class but the application may expect rdf:first and rdf:last links. The former points to the DataObject instance, interpreted as Media the latter points at another MediaFileListEntr. At the end of the list there is a link to rdf:nil.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaFileListEntry"></see></summary>
    let MediaFileListEntry = _prefix "MediaFileListEntry"
    /// <summary>
    /// A file containing a list of media files.e.g. a playlist
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaList"></see></summary>
    let MediaList = _prefix "MediaList"
    /// <summary>
    /// A stream of multimedia content, usually contained within a media container such as a movie (containing both audio and video) or a DVD (possibly containing many streams of audio and video). Most common interpretations for such a DataObject include Audio and Video.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaStream"></see></summary>
    let MediaStream = _prefix "MediaStream"
    /// <summary>
    /// A MindMap, created by a mind-mapping utility. Examples might include FreeMind or mind mapper.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#MindMap"></see></summary>
    let MindMap = _prefix "MindMap"
    /// <summary>
    /// Usually small document with snippets, reminders or frequenly used content.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// An OperatingSystem
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#OperatingSystem"></see></summary>
    let OperatingSystem = _prefix "OperatingSystem"
    /// <summary>
    /// Orientation enum
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Orientation"></see></summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    /// A text document
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#TextDocument"></see></summary>
    let TextDocument = _prefix "TextDocument"
    /// <summary>
    /// A Presentation made by some presentation software (Corel Presentations, OpenOffice Impress, MS Powerpoint etc.)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Presentation"></see></summary>
    let Presentation = _prefix "Presentation"
    /// <summary>
    /// Area on an image with relevant content. Following the spec in http://www.metadataworkinggroup.org
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterest"></see></summary>
    let RegionOfInterest = _prefix "RegionOfInterest"
    /// <summary>
    /// Content in the area. There is a predefined set of contents in the spec: http://www.metadataworkinggroup.org
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterestContent"></see></summary>
    let RegionOfInterestContent = _prefix "RegionOfInterestContent"
    /// <summary>
    /// A file data object stored at a remote location. Don't confuse this class with a RemotePortAddress. This one applies to a particular resource, RemotePortAddress applies to an address, that can have various interpretations.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#RemoteDataObject"></see></summary>
    let RemoteDataObject = _prefix "RemoteDataObject"
    /// <summary>
    /// An address specifying a remote host and port. Such an address can be interpreted in many ways (examples of such interpretations include mailboxes, websites, remote calendars or filesystems), depending on an interpretation, various kinds of data may be extracted from such an address.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#RemotePortAddress"></see></summary>
    let RemotePortAddress = _prefix "RemotePortAddress"
    /// <summary>
    /// A software category
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareCategory"></see></summary>
    let SoftwareCategory = _prefix "SoftwareCategory"
    /// <summary>
    /// A DataObject representing a piece of software. Examples of interpretations of a SoftwareItem include an Application and an OperatingSystem.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareItem"></see></summary>
    let SoftwareItem = _prefix "SoftwareItem"
    /// <summary>
    /// A service published by a piece of software, either by an operating system or an application. Examples of such services may include calendar, addresbook and mailbox managed by a PIM application. This category is introduced to distinguish between data available directly from the applications (Via some Interprocess Communication Mechanisms) and data available from files on a disk. In either case both DataObjects would receive a similar interpretation (e.g. a Mailbox) and wouldn't differ on the content level.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareService"></see></summary>
    let SoftwareService = _prefix "SoftwareService"
    /// <summary>
    /// Code in a compilable or interpreted programming language.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#SourceCode"></see></summary>
    let SourceCode = _prefix "SourceCode"
    /// <summary>
    /// A spreadsheet, created by a spreadsheet application. Examples might include Gnumeric, OpenOffice Calc or MS Excel.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Spreadsheet"></see></summary>
    let Spreadsheet = _prefix "Spreadsheet"
    /// <summary>
    /// Represents a container for deleted files, a feature common in modern operating systems.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Trash"></see></summary>
    let Trash = _prefix "Trash"
    /// <summary>
    /// A vector image (e.g. SVG)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#VectorImage"></see></summary>
    let VectorImage = _prefix "VectorImage"
    /// <summary>
    /// A video file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Video"></see></summary>
    let Video = _prefix "Video"
    /// <summary>
    /// A web history entry
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#WebHistory"></see></summary>
    let WebHistory = _prefix "WebHistory"
    /// <summary>
    /// A website, usually a container for remote resources, that may be interpreted as HTMLDocuments, images or other types of content.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#Website"></see></summary>
    let Website = _prefix "Website"
    /// <summary>
    /// Visual content aspect ratio. (Width divided by Height)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#aspectRatio"></see></summary>
    let aspectRatio = _prefix "aspectRatio"
    /// <summary>
    /// Specifies the start offset of this resource within a larger file, such as a single song within a recording of a radio broadcast or a CD rip.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#audioOffset"></see></summary>
    let audioOffset = _prefix "audioOffset"
    /// <summary>
    /// The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#averageAudioBitrate"></see></summary>
    let averageAudioBitrate = _prefix "averageAudioBitrate"
    /// <summary>
    /// The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#averageBitrate"></see></summary>
    let averageBitrate = _prefix "averageBitrate"
    /// <summary>
    /// The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#averageVideoBitrate"></see></summary>
    let averageVideoBitrate = _prefix "averageVideoBitrate"
    /// <summary>
    /// Models the containment relations between Files and Folders (or CompressedFiles).
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#belongsToContainer"></see></summary>
    let belongsToContainer = _prefix "belongsToContainer"
    /// <summary>
    /// A common superproperty for all properties signifying the amount of bits for an atomic unit of data. Examples of subproperties may include bitsPerSample and bitsPerPixel
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#bitDepth"></see></summary>
    let bitDepth = _prefix "bitDepth"
    /// <summary>
    /// The type of the bitrate. Examples may include CBR and VBR.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#bitrateType"></see></summary>
    let bitrateType = _prefix "bitrateType"
    /// <summary>
    /// Amount of bits in each audio sample.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#bitsPerSample"></see></summary>
    let bitsPerSample = _prefix "bitsPerSample"
    /// <summary>
    /// The address of the linked object. Usually a web URL.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#bookmarks"></see></summary>
    let bookmarks = _prefix "bookmarks"
    /// <summary>
    /// Number of channels. This property is to be used directly if no detailed information is necessary. Otherwise use more detailed subproperties.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#channels"></see></summary>
    let channels = _prefix "channels"
    /// <summary>
    /// The amount of characters in the document.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#characterCount"></see></summary>
    let characterCount = _prefix "characterCount"
    /// <summary>
    /// Character position of the bookmark
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#characterPosition"></see></summary>
    let characterPosition = _prefix "characterPosition"
    /// <summary>
    /// The name of the codec necessary to decode a piece of media.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#codec"></see></summary>
    let codec = _prefix "codec"
    /// <summary>
    /// Amount of bits used to express the color of each pixel.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#colorDepth"></see></summary>
    let colorDepth = _prefix "colorDepth"
    /// <summary>
    /// The amount of character in comments i.e. characters ignored by the compiler/interpreter.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#commentCharacterCount"></see></summary>
    let commentCharacterCount = _prefix "commentCharacterCount"
    /// <summary>
    /// The type of the compression. Values include, lossy and lossless.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#compressionType"></see></summary>
    let compressionType = _prefix "compressionType"
    /// <summary>
    /// States that a piece of software is in conflict with another piece of software.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#conflicts"></see></summary>
    let conflicts = _prefix "conflicts"
    /// <summary>
    /// The folder contains a bookmark.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmark"></see></summary>
    let containsBookmark = _prefix "containsBookmark"
    /// <summary>
    /// The folder contains a bookmark folder.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmarkFolder"></see></summary>
    let containsBookmarkFolder = _prefix "containsBookmarkFolder"
    /// <summary>
    /// A common superproperty for all properties signifying the amount of atomic media data units. Examples of subproperties may include sampleCount and frameCount.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    /// Name of a class defined in the source code file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#definesClass"></see></summary>
    let definesClass = _prefix "definesClass"
    /// <summary>
    /// A name of a function/method defined in the given source code file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#definesFunction"></see></summary>
    let definesFunction = _prefix "definesFunction"
    /// <summary>
    /// Name of a global variable defined within the source code file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#definesGlobalVariable"></see></summary>
    let definesGlobalVariable = _prefix "definesGlobalVariable"
    /// <summary>
    /// The date and time of the deletion.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#deletionDate"></see></summary>
    let deletionDate = _prefix "deletionDate"
    /// <summary>
    /// Relates an information element to an image which depicts said element.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    /// Relates an image to the information elements it depicts.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#depicts"></see></summary>
    let depicts = _prefix "depicts"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#domain"></see>
    /// </summary>
    let domain = _prefix "domain"
    /// <summary>
    /// Duration of a media piece, measured in seconds.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The contains the name of the person or organisation that encoded the media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#encodedBy"></see></summary>
    let encodedBy = _prefix "encodedBy"
    /// <summary>
    /// The encoding used for the Embedded File. Examples might include BASE64 or UUEncode
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// Number of entries in the list. Optimize some common queries
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#entryCounter"></see></summary>
    let entryCounter = _prefix "entryCounter"
    /// <summary>
    /// URL to the element in certain position of the list
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#entryUrl"></see></summary>
    let entryUrl = _prefix "entryUrl"
    /// <summary>
    /// Equipment used to create the media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#equipment"></see></summary>
    let equipment = _prefix "equipment"
    /// <summary>
    /// The software of the equipment
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#equipmentSoftware"></see></summary>
    let equipmentSoftware = _prefix "equipmentSoftware"
    /// <summary>
    /// File creation date
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileCreated"></see></summary>
    let fileCreated = _prefix "fileCreated"
    /// <summary>
    /// Time when the file was last accessed.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileLastAccessed"></see></summary>
    let fileLastAccessed = _prefix "fileLastAccessed"
    /// <summary>
    /// last modification date
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileLastModified"></see></summary>
    let fileLastModified = _prefix "fileLastModified"
    /// <summary>
    /// Name of the file, together with the extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileName"></see></summary>
    let fileName = _prefix "fileName"
    /// <summary>
    /// The owner of the file as defined by the file system access rights feature.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileOwner"></see></summary>
    let fileOwner = _prefix "fileOwner"
    /// <summary>
    /// The size of the file in bytes. For compressed files it means the size of the packed file, not of the contents. For folders it means the aggregated size of all contained files and folders
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// The name of the font family.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#fontFamily"></see></summary>
    let fontFamily = _prefix "fontFamily"
    /// <summary>
    /// The foundry, the organization that created the font.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#foundry"></see></summary>
    let foundry = _prefix "foundry"
    /// <summary>
    /// The amount of frames in a video sequence.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#frameCount"></see></summary>
    let frameCount = _prefix "frameCount"
    /// <summary>
    /// Amount of video frames per second.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#frameRate"></see></summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    /// Number of front channels.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#frontChannels"></see></summary>
    let frontChannels = _prefix "frontChannels"
    /// <summary>
    /// Gain of media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#gain"></see></summary>
    let gain = _prefix "gain"
    /// <summary>
    /// Genre of media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// Links the file with it's hash value.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hasHash"></see></summary>
    let hasHash = _prefix "hasHash"
    /// <summary>
    /// This property is intended to point to an RDF list of MediaFiles.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaFileListEntry"></see></summary>
    let hasMediaFileListEntry = _prefix "hasMediaFileListEntry"
    /// <summary>
    /// Connects a media container with a single media stream contained within.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaStream"></see></summary>
    let hasMediaStream = _prefix "hasMediaStream"
    /// <summary>
    /// Link an element with a defined region
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hasRegionOfInterest"></see></summary>
    let hasRegionOfInterest = _prefix "hasRegionOfInterest"
    /// <summary>
    /// Name of the algorithm used to compute the hash value. Examples might include CRC32, MD5, SHA, TTH etc.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hashAlgorithm"></see></summary>
    let hashAlgorithm = _prefix "hashAlgorithm"
    /// <summary>
    /// The actual value of the hash.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#hashValue"></see></summary>
    let hashValue = _prefix "hashValue"
    /// <summary>
    /// Specifies the direction of travelling while capturing image/video. The range of values from 0.00 to 359.99 (where 0 is due North, 90 is East, 180 South and 270 is West)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#heading"></see></summary>
    let heading = _prefix "heading"
    /// <summary>
    /// Visual content height in pixels.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Horizontal resolution of an image (if printed). Expressed in DPI.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#horizontalResolution"></see></summary>
    let horizontalResolution = _prefix "horizontalResolution"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#image-category-screenshot"></see>
    /// </summary>
    let ``image-category-screenshot`` = _prefix "image-category-screenshot"
    /// <summary>
    /// True if the image is interlaced, false if not.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#interlaceMode"></see></summary>
    let interlaceMode = _prefix "interlaceMode"
    /// <summary>
    /// True when the file is bootable, for example like an ISO or other disc images
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#isBootable"></see></summary>
    let isBootable = _prefix "isBootable"
    /// <summary>
    /// Might change (IE of DataObject property?)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#isContentEncrypted"></see></summary>
    let isContentEncrypted = _prefix "isContentEncrypted"
    /// <summary>
    /// States if a given resource is password-protected.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#isPasswordProtected"></see></summary>
    let isPasswordProtected = _prefix "isPasswordProtected"
    /// <summary>
    /// Position in the media (in seconds) where the play was paused. Positive number, being 0 the beginning of the media.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#lastPlayedPosition"></see></summary>
    let lastPlayedPosition = _prefix "lastPlayedPosition"
    /// <summary>
    /// Number of Low Frequency Expansion (subwoofer) channels.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#lfeChannels"></see></summary>
    let lfeChannels = _prefix "lfeChannels"
    /// <summary>
    /// The amount of lines in a text document
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#lineCount"></see></summary>
    let lineCount = _prefix "lineCount"
    /// <summary>
    /// Sum of the duration of all items in the list. Optimize some common queries. In seconds
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#listDuration"></see></summary>
    let listDuration = _prefix "listDuration"
    /// <summary>
    /// Position of an entry in a list. Double, to optimize the poor insertions
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#listPosition"></see></summary>
    let listPosition = _prefix "listPosition"
    /// <summary>
    /// The manufacturer of the equipment
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// A certain item belongs to a media list. This can reflect that a song is in a playlist, an image or video in an Album
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#mediaListEntry"></see></summary>
    let mediaListEntry = _prefix "mediaListEntry"
    /// <summary>
    /// The model of the equipment
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation"></see>
    /// </summary>
    let orientation = _prefix "orientation"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom"></see>
    /// </summary>
    let ``orientation-bottom`` = _prefix "orientation-bottom"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom-mirror"></see>
    /// </summary>
    let ``orientation-bottom-mirror`` = _prefix "orientation-bottom-mirror"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left"></see>
    /// </summary>
    let ``orientation-left`` = _prefix "orientation-left"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left-mirror"></see>
    /// </summary>
    let ``orientation-left-mirror`` = _prefix "orientation-left-mirror"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right"></see>
    /// </summary>
    let ``orientation-right`` = _prefix "orientation-right"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right-mirror"></see>
    /// </summary>
    let ``orientation-right-mirror`` = _prefix "orientation-right-mirror"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top"></see>
    /// </summary>
    let ``orientation-top`` = _prefix "orientation-top"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top-mirror"></see>
    /// </summary>
    let ``orientation-top-mirror`` = _prefix "orientation-top-mirror"
    /// <summary>
    /// The original location of the deleted resource.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#originalLocation"></see></summary>
    let originalLocation = _prefix "originalLocation"
    /// <summary>
    /// Number of pages.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#pageCount"></see></summary>
    let pageCount = _prefix "pageCount"
    /// <summary>
    /// Page linked by the bookmark
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#pageNumber"></see></summary>
    let pageNumber = _prefix "pageNumber"
    /// <summary>
    /// Peak Gain of media
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#peakGain"></see></summary>
    let peakGain = _prefix "peakGain"
    /// <summary>
    /// A string containing the permissions of a file. A feature common in many UNIX-like operating systems.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// Indicates the name of the programming language this source code file is written in. Examples might include 'C', 'C++', 'Java' etc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#programmingLanguage"></see></summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    /// Number of rear channels.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#rearChannels"></see></summary>
    let rearChannels = _prefix "rearChannels"
    /// <summary>
    /// Height of the region. It is normalized (values between 0 and 1) to the total height of the picture.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestHeight"></see></summary>
    let regionOfInterestHeight = _prefix "regionOfInterestHeight"
    /// <summary>
    /// The content of a region can be one of the predefined types in the spec
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestType"></see></summary>
    let regionOfInterestType = _prefix "regionOfInterestType"
    /// <summary>
    /// Width of the region. It is normalized (values between 0 and 1) to the total width of the picture.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestWidth"></see></summary>
    let regionOfInterestWidth = _prefix "regionOfInterestWidth"
    /// <summary>
    /// Coordinate X where the region starts. It is normalized (values between 0 and 1) to the width of the picture. Starting in the upper left corner.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestX"></see></summary>
    let regionOfInterestX = _prefix "regionOfInterestX"
    /// <summary>
    /// Coordinate y where the region starts. It is normalized (values between 0 and 1) to the height of the picture. Starting in the upper left corner.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestY"></see></summary>
    let regionOfInterestY = _prefix "regionOfInterestY"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-barcode"></see>
    /// </summary>
    let ``roi-content-barcode`` = _prefix "roi-content-barcode"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-face"></see>
    /// </summary>
    let ``roi-content-face`` = _prefix "roi-content-face"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-focus"></see>
    /// </summary>
    let ``roi-content-focus`` = _prefix "roi-content-focus"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-pet"></see>
    /// </summary>
    let ``roi-content-pet`` = _prefix "roi-content-pet"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-undefined"></see>
    /// </summary>
    let ``roi-content-undefined`` = _prefix "roi-content-undefined"
    /// <summary>
    /// Link to an item that is represented in the region. The 'type' of the region can give a clue of what exact content is linked in this property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#roiRefersTo"></see></summary>
    let roiRefersTo = _prefix "roiRefersTo"
    /// <summary>
    /// The amount of samples in an audio clip.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#sampleCount"></see></summary>
    let sampleCount = _prefix "sampleCount"
    /// <summary>
    /// The amount of audio samples per second.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#sampleRate"></see></summary>
    let sampleRate = _prefix "sampleRate"
    /// <summary>
    /// Number of side channels
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#sideChannels"></see></summary>
    let sideChannels = _prefix "sideChannels"
    /// <summary>
    /// Icon of the software
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareCategoryIcon"></see></summary>
    let softwareCategoryIcon = _prefix "softwareCategoryIcon"
    /// <summary>
    /// Command to launch the software
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareCmdLine"></see></summary>
    let softwareCmdLine = _prefix "softwareCmdLine"
    /// <summary>
    /// Icon of the software
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareIcon"></see></summary>
    let softwareIcon = _prefix "softwareIcon"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#streamDuration"></see>
    /// </summary>
    let streamDuration = _prefix "streamDuration"
    /// <summary>
    /// Stream position of the bookmark, suitable for e.g. audio books. Expressed in milliseconds
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#streamPosition"></see></summary>
    let streamPosition = _prefix "streamPosition"
    /// <summary>
    /// States that a piece of software supercedes another piece of software.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#supercedes"></see></summary>
    let supercedes = _prefix "supercedes"
    /// <summary>
    /// Section titles and figure descriptions of the document.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#tableOfContents"></see></summary>
    let tableOfContents = _prefix "tableOfContents"
    /// <summary>
    /// Vertical inclination of the camera while capturing the image, in angles starting on 0 as horizontal, positive numbers pointing up, negative angles pointing down
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#tilt"></see></summary>
    let tilt = _prefix "tilt"
    /// <summary>
    /// Uncompressed size of the content of a compressed file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#uncompressedSize"></see></summary>
    let uncompressedSize = _prefix "uncompressedSize"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nfo#uri"></see>
    /// </summary>
    let uri = _prefix "uri"
    /// <summary>
    /// Vertical resolution of an Image (if printed). Expressed in DPI
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#verticalResolution"></see></summary>
    let verticalResolution = _prefix "verticalResolution"
    /// <summary>
    /// Visual content width in pixels.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// The amount of words in a text document.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nfo#wordCount"></see></summary>
    let wordCount = _prefix "wordCount"
