namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nfo.hash

open DoxAletheia.Rdf_Vocabulary

module nfo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#"

    /// <summary>
    /// An application
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// A piece of software. Examples may include applications and the operating system. This interpretation most commonly applies to SoftwareItems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    /// A compressed file. May contain other files or folder inside.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Archive"></see></summary>
    let Archive = Namespaced_IRI.parse _namespace_name "Archive" |> NamespacedName

    /// <summary>
    /// A superclass for all entities, whose primary purpose is to serve as containers for other data object. They usually don't have any "meaning" by themselves. Examples include folders, archives and optical disc images.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DataContainer"></see></summary>
    let DataContainer =
        Namespaced_IRI.parse _namespace_name "DataContainer" |> NamespacedName

    /// <summary>
    /// A file entity inside an archive.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#ArchiveItem"></see></summary>
    let ArchiveItem =
        Namespaced_IRI.parse _namespace_name "ArchiveItem" |> NamespacedName

    /// <summary>
    /// A file embedded in another data object. There are many ways in which a file may be embedded in another one. Use this class directly only in cases if none of the subclasses gives a better description of your case.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EmbeddedFileDataObject"></see></summary>
    let EmbeddedFileDataObject =
        Namespaced_IRI.parse _namespace_name "EmbeddedFileDataObject" |> NamespacedName

    /// <summary>
    /// A file attached to another data object. Many data formats allow for attachments: emails, vcards, ical events, id3 and exif...
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Attachment"></see></summary>
    let Attachment = Namespaced_IRI.parse _namespace_name "Attachment" |> NamespacedName
    /// <summary>
    /// A file containing audio content
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Audio"></see></summary>
    let Audio = Namespaced_IRI.parse _namespace_name "Audio" |> NamespacedName
    /// <summary>
    /// A piece of media content. This class may be used to express complex media containers with many streams of various media content (both aural and visual).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Media"></see></summary>
    let Media = Namespaced_IRI.parse _namespace_name "Media" |> NamespacedName
    /// <summary>
    /// A bookmark of a webbrowser. Use nie:title for the name/label, nie:contentCreated to represent the date when the user added the bookmark, and nie:contentLastModified for modifications. nfo:bookmarks to store the link.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Bookmark"></see></summary>
    let Bookmark = Namespaced_IRI.parse _namespace_name "Bookmark" |> NamespacedName

    /// <summary>
    /// A folder with bookmarks of a webbrowser. Use nfo:containsBookmark to relate Bookmarks. Folders can contain subfolders, use containsBookmarkFolder to relate them.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#BookmarkFolder"></see></summary>
    let BookmarkFolder =
        Namespaced_IRI.parse _namespace_name "BookmarkFolder" |> NamespacedName

    /// <summary>
    /// Type of compression. Instances of this class represent the limited set of values allowed for the nfo:compressionType property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#CompressionType"></see></summary>
    let CompressionType =
        Namespaced_IRI.parse _namespace_name "CompressionType" |> NamespacedName

    /// <summary>
    /// A Cursor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Cursor"></see></summary>
    let Cursor = Namespaced_IRI.parse _namespace_name "Cursor" |> NamespacedName

    /// <summary>
    /// A raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RasterImage"></see></summary>
    let RasterImage =
        Namespaced_IRI.parse _namespace_name "RasterImage" |> NamespacedName

    /// <summary>
    /// A file entity that has been deleted from the original source. Usually such entities are stored within various kinds of 'Trash' or 'Recycle Bin' folders.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DeletedResource"></see></summary>
    let DeletedResource =
        Namespaced_IRI.parse _namespace_name "DeletedResource" |> NamespacedName

    /// <summary>
    /// A resource containing a finite sequence of bytes with arbitrary information, that is available to a computer program and is usually based on some kind of durable storage. A file is durable in the sense that it remains available for programs to use after the current program has finished.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileDataObject"></see></summary>
    let FileDataObject =
        Namespaced_IRI.parse _namespace_name "FileDataObject" |> NamespacedName

    /// <summary>
    /// A generic document. A common superclass for all documents on the desktop.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// The status of the encryption of an InformationElement. nfo:encryptedStatus means that the InformationElement has been encrypted and couldn't be decrypted by the extraction software, thus no content is available. nfo:decryptedStatus means that decryption was successfull and the content is available.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EncryptionStatus"></see></summary>
    let EncryptionStatus =
        Namespaced_IRI.parse _namespace_name "EncryptionStatus" |> NamespacedName

    /// <summary>
    /// An executable file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Executable"></see></summary>
    let Executable = Namespaced_IRI.parse _namespace_name "Executable" |> NamespacedName
    /// <summary>
    /// A fingerprint of the file, generated by some hashing function.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileHash"></see></summary>
    let FileHash = Namespaced_IRI.parse _namespace_name "FileHash" |> NamespacedName
    /// <summary>
    /// A filesystem. Examples of filesystems include hard disk partitions, removable media, but also images thereof stored in files such as ISO.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Filesystem"></see></summary>
    let Filesystem = Namespaced_IRI.parse _namespace_name "Filesystem" |> NamespacedName

    /// <summary>
    /// An image of a filesystem. Instances of this class may include CD images, DVD images or hard disk partition images created by various pieces of software (e.g. Norton Ghost). Deprecated in favor of nfo:Filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FilesystemImage"></see></summary>
    let FilesystemImage =
        Namespaced_IRI.parse _namespace_name "FilesystemImage" |> NamespacedName

    /// <summary>
    /// A folder/directory. Examples of folders include folders on a filesystem and message folders in a mailbox.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Folder"></see></summary>
    let Folder = Namespaced_IRI.parse _namespace_name "Folder" |> NamespacedName
    /// <summary>
    /// A font.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Font"></see></summary>
    let Font = Namespaced_IRI.parse _namespace_name "Font" |> NamespacedName

    /// <summary>
    /// A partition on a hard disk
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HardDiskPartition"></see></summary>
    let HardDiskPartition =
        Namespaced_IRI.parse _namespace_name "HardDiskPartition" |> NamespacedName

    /// <summary>
    /// A HTML document, may contain links to other files.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HtmlDocument"></see></summary>
    let HtmlDocument =
        Namespaced_IRI.parse _namespace_name "HtmlDocument" |> NamespacedName

    /// <summary>
    /// A file containing plain text (ASCII, Unicode or other encodings). Examples may include TXT, HTML, XML, program source code etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlainTextDocument"></see></summary>
    let PlainTextDocument =
        Namespaced_IRI.parse _namespace_name "PlainTextDocument" |> NamespacedName

    /// <summary>
    /// An Icon (regardless of whether it's a raster or a vector icon. A resource representing an icon could have two types (Icon and Raster, or Icon and Vector) if required.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Icon"></see></summary>
    let Icon = Namespaced_IRI.parse _namespace_name "Icon" |> NamespacedName
    /// <summary>
    /// A file containing an image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// File containing visual content.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Visual"></see></summary>
    let Visual = Namespaced_IRI.parse _namespace_name "Visual" |> NamespacedName

    /// <summary>
    /// A local file data object which is stored on a local file system. Its nie:url always uses the file:/ protocol. The main use of this class is to distinguish local and non-local files.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#LocalFileDataObject"></see></summary>
    let LocalFileDataObject =
        Namespaced_IRI.parse _namespace_name "LocalFileDataObject" |> NamespacedName

    /// <summary>
    /// A single node in the list of media files contained within an MediaList instance. This class is intended to provide a type all those links have. In valid NRL untyped resources cannot be linked. There are no properties defined for this class but the application may expect rdf:first and rdf:last links. The former points to the DataObject instance, interpreted as Media the latter points at another MediaFileListEntr. At the end of the list there is a link to rdf:nil.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaFileListEntry"></see></summary>
    let MediaFileListEntry =
        Namespaced_IRI.parse _namespace_name "MediaFileListEntry" |> NamespacedName

    /// <summary>
    /// A file containing a list of media files.e.g. a playlist
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaList"></see></summary>
    let MediaList = Namespaced_IRI.parse _namespace_name "MediaList" |> NamespacedName

    /// <summary>
    /// A stream of multimedia content, usually contained within a media container such as a movie (containing both audio and video) or a DVD (possibly containing many streams of audio and video). Most common interpretations for such a DataObject include Audio and Video.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaStream"></see></summary>
    let MediaStream =
        Namespaced_IRI.parse _namespace_name "MediaStream" |> NamespacedName

    /// <summary>
    /// A MindMap, created by a mind-mapping utility. Examples might include FreeMind or mind mapper.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MindMap"></see></summary>
    let MindMap = Namespaced_IRI.parse _namespace_name "MindMap" |> NamespacedName

    /// <summary>
    /// An OperatingSystem
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#OperatingSystem"></see></summary>
    let OperatingSystem =
        Namespaced_IRI.parse _namespace_name "OperatingSystem" |> NamespacedName

    /// <summary>
    /// A file containing a text document, that is unambiguously divided into pages. Examples might include PDF, DOC, PS, DVI etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PaginatedTextDocument"></see></summary>
    let PaginatedTextDocument =
        Namespaced_IRI.parse _namespace_name "PaginatedTextDocument" |> NamespacedName

    /// <summary>
    /// A text document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#TextDocument"></see></summary>
    let TextDocument =
        Namespaced_IRI.parse _namespace_name "TextDocument" |> NamespacedName

    /// <summary>
    /// One placemark within a placemark container/file. Use nie:title for the name/label, nao:creator for defining the creator.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Placemark"></see></summary>
    let Placemark = Namespaced_IRI.parse _namespace_name "Placemark" |> NamespacedName

    /// <summary>
    /// A data object containing placemark(s). Use nie:contentCreated to represent the date when the user created the dataobject, nao:creator for defining the creator, nie:contentLastModified for modifications. nfo:containsPlacemark to refer to individual placemarks within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlacemarkContainer"></see></summary>
    let PlacemarkContainer =
        Namespaced_IRI.parse _namespace_name "PlacemarkContainer" |> NamespacedName

    /// <summary>
    /// A Presentation made by some presentation software (Corel Presentations, OpenOffice Impress, MS Powerpoint etc.)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Presentation"></see></summary>
    let Presentation =
        Namespaced_IRI.parse _namespace_name "Presentation" |> NamespacedName

    /// <summary>
    /// A file data object stored at a remote location. Don't confuse this class with a RemotePortAddress. This one applies to a particular resource, RemotePortAddress applies to an address, that can have various interpretations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemoteDataObject"></see></summary>
    let RemoteDataObject =
        Namespaced_IRI.parse _namespace_name "RemoteDataObject" |> NamespacedName

    /// <summary>
    /// An address specifying a remote host and port. Such an address can be interpreted in many ways (examples of such interpretations include mailboxes, websites, remote calendars or filesystems), depending on an interpretation, various kinds of data may be extracted from such an address.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemotePortAddress"></see></summary>
    let RemotePortAddress =
        Namespaced_IRI.parse _namespace_name "RemotePortAddress" |> NamespacedName

    /// <summary>
    /// A DataObject representing a piece of software. Examples of interpretations of a SoftwareItem include an Application and an OperatingSystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareItem"></see></summary>
    let SoftwareItem =
        Namespaced_IRI.parse _namespace_name "SoftwareItem" |> NamespacedName

    /// <summary>
    /// A service published by a piece of software, either by an operating system or an application. Examples of such services may include calendar, addressbook and mailbox managed by a PIM application. This category is introduced to distinguish between data available directly from the applications (Via some Interprocess Communication Mechanisms) and data available from files on a disk. In either case both DataObjects would receive a similar interpretation (e.g. a Mailbox) and wouldn't differ on the content level.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareService"></see></summary>
    let SoftwareService =
        Namespaced_IRI.parse _namespace_name "SoftwareService" |> NamespacedName

    /// <summary>
    /// Code in a compilable or interpreted programming language.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SourceCode"></see></summary>
    let SourceCode = Namespaced_IRI.parse _namespace_name "SourceCode" |> NamespacedName

    /// <summary>
    /// A spreadsheet, created by a spreadsheet application. Examples might include Gnumeric, OpenOffice Calc or MS Excel.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Spreadsheet"></see></summary>
    let Spreadsheet =
        Namespaced_IRI.parse _namespace_name "Spreadsheet" |> NamespacedName

    /// <summary>
    /// Represents a container for deleted files, a feature common in modern operating systems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Trash"></see></summary>
    let Trash = Namespaced_IRI.parse _namespace_name "Trash" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#VectorImage"></see>
    /// </summary>
    let VectorImage =
        Namespaced_IRI.parse _namespace_name "VectorImage" |> NamespacedName

    /// <summary>
    /// A video file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Video"></see></summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName

    /// <summary>
    /// An information resources of which representations (files, streams) can be retrieved through a web server. They may be generated at retrieval time. Typical examples are pages served by PHP or AJAX or mp3 streams.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#WebDataObject"></see></summary>
    let WebDataObject =
        Namespaced_IRI.parse _namespace_name "WebDataObject" |> NamespacedName

    /// <summary>
    /// A website, usually a container for remote resources, that may be interpreted as HTMLDocuments, images or other types of content.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Website"></see></summary>
    let Website = Namespaced_IRI.parse _namespace_name "Website" |> NamespacedName

    /// <summary>
    /// Visual content aspect ratio. (Width divided by Height)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#aspectRatio"></see></summary>
    let aspectRatio =
        Namespaced_IRI.parse _namespace_name "aspectRatio" |> NamespacedName

    /// <summary>
    /// The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#averageBitrate"></see></summary>
    let averageBitrate =
        Namespaced_IRI.parse _namespace_name "averageBitrate" |> NamespacedName

    /// <summary>
    /// A common superproperty for all properties specifying the media rate. Examples of subproperties may include frameRate for video and sampleRate for audio. This property is expressed in units per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rate"></see></summary>
    let rate = Namespaced_IRI.parse _namespace_name "rate" |> NamespacedName

    /// <summary>
    /// Models the containment relations between Files and Folders (or CompressedFiles).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#belongsToContainer"></see></summary>
    let belongsToContainer =
        Namespaced_IRI.parse _namespace_name "belongsToContainer" |> NamespacedName

    /// <summary>
    /// A common superproperty for all properties signifying the amount of bits for an atomic unit of data. Examples of subproperties may include bitsPerSample and bitsPerPixel
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitDepth"></see></summary>
    let bitDepth = Namespaced_IRI.parse _namespace_name "bitDepth" |> NamespacedName

    /// <summary>
    /// The type of the bitrate. Examples may include CBR and VBR.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitrateType"></see></summary>
    let bitrateType =
        Namespaced_IRI.parse _namespace_name "bitrateType" |> NamespacedName

    /// <summary>
    /// Amount of bits in each audio sample.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitsPerSample"></see></summary>
    let bitsPerSample =
        Namespaced_IRI.parse _namespace_name "bitsPerSample" |> NamespacedName

    /// <summary>
    /// The address of the linked object. Usually a web URI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bookmarks"></see></summary>
    let bookmarks = Namespaced_IRI.parse _namespace_name "bookmarks" |> NamespacedName
    /// <summary>
    /// Number of channels. This property is to be used directly if no detailed information is necessary. Otherwise use more detailed subproperties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#channels"></see></summary>
    let channels = Namespaced_IRI.parse _namespace_name "channels" |> NamespacedName

    /// <summary>
    /// The amount of characters in the document.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterCount"></see></summary>
    let characterCount =
        Namespaced_IRI.parse _namespace_name "characterCount" |> NamespacedName

    /// <summary>
    /// Character position of the bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterPosition"></see></summary>
    let characterPosition =
        Namespaced_IRI.parse _namespace_name "characterPosition" |> NamespacedName

    /// <summary>
    /// The name of the codec necessary to decode a piece of media.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#codec"></see></summary>
    let codec = Namespaced_IRI.parse _namespace_name "codec" |> NamespacedName
    /// <summary>
    /// The number of colors used/available in a raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorCount"></see></summary>
    let colorCount = Namespaced_IRI.parse _namespace_name "colorCount" |> NamespacedName
    /// <summary>
    /// Amount of bits used to express the color of each pixel.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorDepth"></see></summary>
    let colorDepth = Namespaced_IRI.parse _namespace_name "colorDepth" |> NamespacedName

    /// <summary>
    /// The amount of character in comments i.e. characters ignored by the compiler/interpreter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#commentCharacterCount"></see></summary>
    let commentCharacterCount =
        Namespaced_IRI.parse _namespace_name "commentCharacterCount" |> NamespacedName

    /// <summary>
    /// The type of the compression. Values include, 'lossy' and 'lossless'.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#compressionType"></see></summary>
    let compressionType =
        Namespaced_IRI.parse _namespace_name "compressionType" |> NamespacedName

    /// <summary>
    /// States that a piece of software is in conflict with another piece of software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#conflicts"></see></summary>
    let conflicts = Namespaced_IRI.parse _namespace_name "conflicts" |> NamespacedName

    /// <summary>
    /// The folder contains a bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmark"></see></summary>
    let containsBookmark =
        Namespaced_IRI.parse _namespace_name "containsBookmark" |> NamespacedName

    /// <summary>
    /// The folder contains a bookmark folder.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmarkFolder"></see></summary>
    let containsBookmarkFolder =
        Namespaced_IRI.parse _namespace_name "containsBookmarkFolder" |> NamespacedName

    /// <summary>
    /// Containment relation between placemark containers (files) and placemarks within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsPlacemark"></see></summary>
    let containsPlacemark =
        Namespaced_IRI.parse _namespace_name "containsPlacemark" |> NamespacedName

    /// <summary>
    /// A common superproperty for all properties signifying the amount of atomic media data units. Examples of subproperties may include sampleCount and frameCount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#count"></see></summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#decryptedStatus"></see>
    /// </summary>
    let decryptedStatus =
        Namespaced_IRI.parse _namespace_name "decryptedStatus" |> NamespacedName

    /// <summary>
    /// Name of a class defined in the source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesClass"></see></summary>
    let definesClass =
        Namespaced_IRI.parse _namespace_name "definesClass" |> NamespacedName

    /// <summary>
    /// A name of a function/method defined in the given source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesFunction"></see></summary>
    let definesFunction =
        Namespaced_IRI.parse _namespace_name "definesFunction" |> NamespacedName

    /// <summary>
    /// Name of a global variable defined within the source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesGlobalVariable"></see></summary>
    let definesGlobalVariable =
        Namespaced_IRI.parse _namespace_name "definesGlobalVariable" |> NamespacedName

    /// <summary>
    /// The date and time of the deletion.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#deletionDate"></see></summary>
    let deletionDate =
        Namespaced_IRI.parse _namespace_name "deletionDate" |> NamespacedName

    /// <summary>
    /// Relates an information element to an image which depicts said element.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depiction"></see></summary>
    let depiction = Namespaced_IRI.parse _namespace_name "depiction" |> NamespacedName
    /// <summary>
    /// Relates an image to the information elements it depicts.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depicts"></see></summary>
    let depicts = Namespaced_IRI.parse _namespace_name "depicts" |> NamespacedName
    /// <summary>
    /// Duration of a media piece.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// The encoding used for the Embedded File. Examples might include BASE64 or UUEncode
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encoding"></see></summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encryptedStatus"></see>
    /// </summary>
    let encryptedStatus =
        Namespaced_IRI.parse _namespace_name "encryptedStatus" |> NamespacedName

    /// <summary>
    /// The status of the encryption of the InformationElement.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encryptionStatus"></see></summary>
    let encryptionStatus =
        Namespaced_IRI.parse _namespace_name "encryptionStatus" |> NamespacedName

    /// <summary>
    /// File creation date
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileCreated"></see></summary>
    let fileCreated =
        Namespaced_IRI.parse _namespace_name "fileCreated" |> NamespacedName

    /// <summary>
    /// Time when the file was last accessed.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastAccessed"></see></summary>
    let fileLastAccessed =
        Namespaced_IRI.parse _namespace_name "fileLastAccessed" |> NamespacedName

    /// <summary>
    /// last modification date
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastModified"></see></summary>
    let fileLastModified =
        Namespaced_IRI.parse _namespace_name "fileLastModified" |> NamespacedName

    /// <summary>
    /// Name of the file, together with the extension
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileName"></see></summary>
    let fileName = Namespaced_IRI.parse _namespace_name "fileName" |> NamespacedName
    /// <summary>
    /// The owner of the file as defined by the file system access rights feature.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileOwner"></see></summary>
    let fileOwner = Namespaced_IRI.parse _namespace_name "fileOwner" |> NamespacedName
    /// <summary>
    /// The size of the file in bytes. For compressed files it means the size of the packed file, not of the contents. For folders it means the aggregated size of all contained files and folders
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName
    /// <summary>
    /// URL of the file. It points at the location of the file. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileUrl"></see></summary>
    let fileUrl = Namespaced_IRI.parse _namespace_name "fileUrl" |> NamespacedName

    /// <summary>
    /// Type of filesystem such as ext3 and ntfs.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#filesystemType"></see></summary>
    let filesystemType =
        Namespaced_IRI.parse _namespace_name "filesystemType" |> NamespacedName

    /// <summary>
    /// The name of the font family.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fontFamily"></see></summary>
    let fontFamily = Namespaced_IRI.parse _namespace_name "fontFamily" |> NamespacedName
    /// <summary>
    /// The foundry, the organization that created the font.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#foundry"></see></summary>
    let foundry = Namespaced_IRI.parse _namespace_name "foundry" |> NamespacedName
    /// <summary>
    /// The amount of frames in a video sequence.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameCount"></see></summary>
    let frameCount = Namespaced_IRI.parse _namespace_name "frameCount" |> NamespacedName
    /// <summary>
    /// Amount of video frames per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameRate"></see></summary>
    let frameRate = Namespaced_IRI.parse _namespace_name "frameRate" |> NamespacedName
    /// <summary>
    /// Unoccupied storage space of the filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#freeSpace"></see></summary>
    let freeSpace = Namespaced_IRI.parse _namespace_name "freeSpace" |> NamespacedName

    /// <summary>
    /// Number of front channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frontChannels"></see></summary>
    let frontChannels =
        Namespaced_IRI.parse _namespace_name "frontChannels" |> NamespacedName

    /// <summary>
    /// Links the file with it's hash value.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasHash"></see></summary>
    let hasHash = Namespaced_IRI.parse _namespace_name "hasHash" |> NamespacedName

    /// <summary>
    /// This property is intended to point to an RDF list of MediaFiles.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaFileListEntry"></see></summary>
    let hasMediaFileListEntry =
        Namespaced_IRI.parse _namespace_name "hasMediaFileListEntry" |> NamespacedName

    /// <summary>
    /// Connects a media container with a single media stream contained within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaStream"></see></summary>
    let hasMediaStream =
        Namespaced_IRI.parse _namespace_name "hasMediaStream" |> NamespacedName

    /// <summary>
    /// Name of the algorithm used to compute the hash value. Examples might include CRC32, MD5, SHA, TTH etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashAlgorithm"></see></summary>
    let hashAlgorithm =
        Namespaced_IRI.parse _namespace_name "hashAlgorithm" |> NamespacedName

    /// <summary>
    /// The actual value of the hash.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashValue"></see></summary>
    let hashValue = Namespaced_IRI.parse _namespace_name "hashValue" |> NamespacedName
    /// <summary>
    /// Visual content height in pixels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName

    /// <summary>
    /// Horizontal resolution of an image (if printed). Expressed in DPI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#horizontalResolution"></see></summary>
    let horizontalResolution =
        Namespaced_IRI.parse _namespace_name "horizontalResolution" |> NamespacedName

    /// <summary>
    /// True if the image is interlaced, false if not.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#interlaceMode"></see></summary>
    let interlaceMode =
        Namespaced_IRI.parse _namespace_name "interlaceMode" |> NamespacedName

    /// <summary>
    /// States if a given resource is password-protected.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#isPasswordProtected"></see></summary>
    let isPasswordProtected =
        Namespaced_IRI.parse _namespace_name "isPasswordProtected" |> NamespacedName

    /// <summary>
    /// Number of Low Frequency Expansion (subwoofer) channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lfeChannels"></see></summary>
    let lfeChannels =
        Namespaced_IRI.parse _namespace_name "lfeChannels" |> NamespacedName

    /// <summary>
    /// The amount of lines in a text document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lineCount"></see></summary>
    let lineCount = Namespaced_IRI.parse _namespace_name "lineCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#losslessCompressionType"></see>
    /// </summary>
    let losslessCompressionType =
        Namespaced_IRI.parse _namespace_name "losslessCompressionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lossyCompressionType"></see>
    /// </summary>
    let lossyCompressionType =
        Namespaced_IRI.parse _namespace_name "lossyCompressionType" |> NamespacedName

    /// <summary>
    /// Occupied storage space of the filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#occupiedSpace"></see></summary>
    let occupiedSpace =
        Namespaced_IRI.parse _namespace_name "occupiedSpace" |> NamespacedName

    /// <summary>
    /// The original location of the deleted resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#originalLocation"></see></summary>
    let originalLocation =
        Namespaced_IRI.parse _namespace_name "originalLocation" |> NamespacedName

    /// <summary>
    /// Number of pages.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageCount"></see></summary>
    let pageCount = Namespaced_IRI.parse _namespace_name "pageCount" |> NamespacedName
    /// <summary>
    /// Page linked by the bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageNumber"></see></summary>
    let pageNumber = Namespaced_IRI.parse _namespace_name "pageNumber" |> NamespacedName

    /// <summary>
    /// The number of colors defined in palette of the raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#paletteSize"></see></summary>
    let paletteSize =
        Namespaced_IRI.parse _namespace_name "paletteSize" |> NamespacedName

    /// <summary>
    /// A string containing the permissions of a file. A feature common in many UNIX-like operating systems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#permissions"></see></summary>
    let permissions =
        Namespaced_IRI.parse _namespace_name "permissions" |> NamespacedName

    /// <summary>
    /// Indicates the name of the programming language this source code file is written in. Examples might include 'C', 'C++', 'Java' etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#programmingLanguage"></see></summary>
    let programmingLanguage =
        Namespaced_IRI.parse _namespace_name "programmingLanguage" |> NamespacedName

    /// <summary>
    /// Number of rear channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rearChannels"></see></summary>
    let rearChannels =
        Namespaced_IRI.parse _namespace_name "rearChannels" |> NamespacedName

    /// <summary>
    /// The amount of samples in an audio clip.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleCount"></see></summary>
    let sampleCount =
        Namespaced_IRI.parse _namespace_name "sampleCount" |> NamespacedName

    /// <summary>
    /// The amount of audio samples per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleRate"></see></summary>
    let sampleRate = Namespaced_IRI.parse _namespace_name "sampleRate" |> NamespacedName

    /// <summary>
    /// Number of side channels
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sideChannels"></see></summary>
    let sideChannels =
        Namespaced_IRI.parse _namespace_name "sideChannels" |> NamespacedName

    /// <summary>
    /// Stream position of the bookmark, suitable for e.g. audio books. Expressed in milliseconds
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#streamPosition"></see></summary>
    let streamPosition =
        Namespaced_IRI.parse _namespace_name "streamPosition" |> NamespacedName

    /// <summary>
    /// States that a piece of software supercedes another piece of software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#supercedes"></see></summary>
    let supercedes = Namespaced_IRI.parse _namespace_name "supercedes" |> NamespacedName
    /// <summary>
    /// Total storage space of the filesystem, which can be different from nie:contentSize because the latter includes filesystem format overhead.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#totalSpace"></see></summary>
    let totalSpace = Namespaced_IRI.parse _namespace_name "totalSpace" |> NamespacedName

    /// <summary>
    /// Uncompressed size of the content of a compressed file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uncompressedSize"></see></summary>
    let uncompressedSize =
        Namespaced_IRI.parse _namespace_name "uncompressedSize" |> NamespacedName

    /// <summary>
    /// Universally unique identifier of the filesystem. In the future, this property may have its parent changed to a more generic class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uuid"></see></summary>
    let uuid = Namespaced_IRI.parse _namespace_name "uuid" |> NamespacedName

    /// <summary>
    /// Vertical resolution of an Image (if printed). Expressed in DPI
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#verticalResolution"></see></summary>
    let verticalResolution =
        Namespaced_IRI.parse _namespace_name "verticalResolution" |> NamespacedName

    /// <summary>
    /// Visual content width in pixels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    /// The amount of words in a text document.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#wordCount"></see></summary>
    let wordCount = Namespaced_IRI.parse _namespace_name "wordCount" |> NamespacedName
