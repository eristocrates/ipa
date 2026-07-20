namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nfo.hash

open DoxAletheia

module nfo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An application
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// A piece of software. Examples may include applications and the operating system. This interpretation most commonly applies to SoftwareItems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// A compressed file. May contain other files or folder inside.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// A superclass for all entities, whose primary purpose is to serve as containers for other data object. They usually don't have any "meaning" by themselves. Examples include folders, archives and optical disc images.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DataContainer"></see></summary>
    let DataContainer = _prefix "DataContainer"
    /// <summary>
    /// A file entity inside an archive.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#ArchiveItem"></see></summary>
    let ArchiveItem = _prefix "ArchiveItem"
    /// <summary>
    /// A file embedded in another data object. There are many ways in which a file may be embedded in another one. Use this class directly only in cases if none of the subclasses gives a better description of your case.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EmbeddedFileDataObject"></see></summary>
    let EmbeddedFileDataObject = _prefix "EmbeddedFileDataObject"
    /// <summary>
    /// A file attached to another data object. Many data formats allow for attachments: emails, vcards, ical events, id3 and exif...
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Attachment"></see></summary>
    let Attachment = _prefix "Attachment"
    /// <summary>
    /// A file containing audio content
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Audio"></see></summary>
    let Audio = _prefix "Audio"
    /// <summary>
    /// A piece of media content. This class may be used to express complex media containers with many streams of various media content (both aural and visual).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Media"></see></summary>
    let Media = _prefix "Media"
    /// <summary>
    /// A bookmark of a webbrowser. Use nie:title for the name/label, nie:contentCreated to represent the date when the user added the bookmark, and nie:contentLastModified for modifications. nfo:bookmarks to store the link.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Bookmark"></see></summary>
    let Bookmark = _prefix "Bookmark"
    /// <summary>
    /// A folder with bookmarks of a webbrowser. Use nfo:containsBookmark to relate Bookmarks. Folders can contain subfolders, use containsBookmarkFolder to relate them.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#BookmarkFolder"></see></summary>
    let BookmarkFolder = _prefix "BookmarkFolder"
    /// <summary>
    /// Type of compression. Instances of this class represent the limited set of values allowed for the nfo:compressionType property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#CompressionType"></see></summary>
    let CompressionType = _prefix "CompressionType"
    /// <summary>
    /// A Cursor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Cursor"></see></summary>
    let Cursor = _prefix "Cursor"
    /// <summary>
    /// A raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RasterImage"></see></summary>
    let RasterImage = _prefix "RasterImage"
    /// <summary>
    /// A file entity that has been deleted from the original source. Usually such entities are stored within various kinds of 'Trash' or 'Recycle Bin' folders.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DeletedResource"></see></summary>
    let DeletedResource = _prefix "DeletedResource"
    /// <summary>
    /// A resource containing a finite sequence of bytes with arbitrary information, that is available to a computer program and is usually based on some kind of durable storage. A file is durable in the sense that it remains available for programs to use after the current program has finished.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileDataObject"></see></summary>
    let FileDataObject = _prefix "FileDataObject"
    /// <summary>
    /// A generic document. A common superclass for all documents on the desktop.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// The status of the encryption of an InformationElement. nfo:encryptedStatus means that the InformationElement has been encrypted and couldn't be decrypted by the extraction software, thus no content is available. nfo:decryptedStatus means that decryption was successfull and the content is available.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EncryptionStatus"></see></summary>
    let EncryptionStatus = _prefix "EncryptionStatus"
    /// <summary>
    /// An executable file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Executable"></see></summary>
    let Executable = _prefix "Executable"
    /// <summary>
    /// A fingerprint of the file, generated by some hashing function.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileHash"></see></summary>
    let FileHash = _prefix "FileHash"
    /// <summary>
    /// A filesystem. Examples of filesystems include hard disk partitions, removable media, but also images thereof stored in files such as ISO.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Filesystem"></see></summary>
    let Filesystem = _prefix "Filesystem"
    /// <summary>
    /// An image of a filesystem. Instances of this class may include CD images, DVD images or hard disk partition images created by various pieces of software (e.g. Norton Ghost). Deprecated in favor of nfo:Filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FilesystemImage"></see></summary>
    let FilesystemImage = _prefix "FilesystemImage"
    /// <summary>
    /// A folder/directory. Examples of folders include folders on a filesystem and message folders in a mailbox.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Folder"></see></summary>
    let Folder = _prefix "Folder"
    /// <summary>
    /// A font.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Font"></see></summary>
    let Font = _prefix "Font"
    /// <summary>
    /// A partition on a hard disk
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HardDiskPartition"></see></summary>
    let HardDiskPartition = _prefix "HardDiskPartition"
    /// <summary>
    /// A HTML document, may contain links to other files.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HtmlDocument"></see></summary>
    let HtmlDocument = _prefix "HtmlDocument"
    /// <summary>
    /// A file containing plain text (ASCII, Unicode or other encodings). Examples may include TXT, HTML, XML, program source code etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlainTextDocument"></see></summary>
    let PlainTextDocument = _prefix "PlainTextDocument"
    /// <summary>
    /// An Icon (regardless of whether it's a raster or a vector icon. A resource representing an icon could have two types (Icon and Raster, or Icon and Vector) if required.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Icon"></see></summary>
    let Icon = _prefix "Icon"
    /// <summary>
    /// A file containing an image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// File containing visual content.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Visual"></see></summary>
    let Visual = _prefix "Visual"
    /// <summary>
    /// A local file data object which is stored on a local file system. Its nie:url always uses the file:/ protocol. The main use of this class is to distinguish local and non-local files.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#LocalFileDataObject"></see></summary>
    let LocalFileDataObject = _prefix "LocalFileDataObject"
    /// <summary>
    /// A single node in the list of media files contained within an MediaList instance. This class is intended to provide a type all those links have. In valid NRL untyped resources cannot be linked. There are no properties defined for this class but the application may expect rdf:first and rdf:last links. The former points to the DataObject instance, interpreted as Media the latter points at another MediaFileListEntr. At the end of the list there is a link to rdf:nil.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaFileListEntry"></see></summary>
    let MediaFileListEntry = _prefix "MediaFileListEntry"
    /// <summary>
    /// A file containing a list of media files.e.g. a playlist
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaList"></see></summary>
    let MediaList = _prefix "MediaList"
    /// <summary>
    /// A stream of multimedia content, usually contained within a media container such as a movie (containing both audio and video) or a DVD (possibly containing many streams of audio and video). Most common interpretations for such a DataObject include Audio and Video.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaStream"></see></summary>
    let MediaStream = _prefix "MediaStream"
    /// <summary>
    /// A MindMap, created by a mind-mapping utility. Examples might include FreeMind or mind mapper.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MindMap"></see></summary>
    let MindMap = _prefix "MindMap"
    /// <summary>
    /// An OperatingSystem
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#OperatingSystem"></see></summary>
    let OperatingSystem = _prefix "OperatingSystem"
    /// <summary>
    /// A file containing a text document, that is unambiguously divided into pages. Examples might include PDF, DOC, PS, DVI etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PaginatedTextDocument"></see></summary>
    let PaginatedTextDocument = _prefix "PaginatedTextDocument"
    /// <summary>
    /// A text document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#TextDocument"></see></summary>
    let TextDocument = _prefix "TextDocument"
    /// <summary>
    /// One placemark within a placemark container/file. Use nie:title for the name/label, nao:creator for defining the creator.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Placemark"></see></summary>
    let Placemark = _prefix "Placemark"
    /// <summary>
    /// A data object containing placemark(s). Use nie:contentCreated to represent the date when the user created the dataobject, nao:creator for defining the creator, nie:contentLastModified for modifications. nfo:containsPlacemark to refer to individual placemarks within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlacemarkContainer"></see></summary>
    let PlacemarkContainer = _prefix "PlacemarkContainer"
    /// <summary>
    /// A Presentation made by some presentation software (Corel Presentations, OpenOffice Impress, MS Powerpoint etc.)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Presentation"></see></summary>
    let Presentation = _prefix "Presentation"
    /// <summary>
    /// A file data object stored at a remote location. Don't confuse this class with a RemotePortAddress. This one applies to a particular resource, RemotePortAddress applies to an address, that can have various interpretations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemoteDataObject"></see></summary>
    let RemoteDataObject = _prefix "RemoteDataObject"
    /// <summary>
    /// An address specifying a remote host and port. Such an address can be interpreted in many ways (examples of such interpretations include mailboxes, websites, remote calendars or filesystems), depending on an interpretation, various kinds of data may be extracted from such an address.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemotePortAddress"></see></summary>
    let RemotePortAddress = _prefix "RemotePortAddress"
    /// <summary>
    /// A DataObject representing a piece of software. Examples of interpretations of a SoftwareItem include an Application and an OperatingSystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareItem"></see></summary>
    let SoftwareItem = _prefix "SoftwareItem"
    /// <summary>
    /// A service published by a piece of software, either by an operating system or an application. Examples of such services may include calendar, addressbook and mailbox managed by a PIM application. This category is introduced to distinguish between data available directly from the applications (Via some Interprocess Communication Mechanisms) and data available from files on a disk. In either case both DataObjects would receive a similar interpretation (e.g. a Mailbox) and wouldn't differ on the content level.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareService"></see></summary>
    let SoftwareService = _prefix "SoftwareService"
    /// <summary>
    /// Code in a compilable or interpreted programming language.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SourceCode"></see></summary>
    let SourceCode = _prefix "SourceCode"
    /// <summary>
    /// A spreadsheet, created by a spreadsheet application. Examples might include Gnumeric, OpenOffice Calc or MS Excel.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Spreadsheet"></see></summary>
    let Spreadsheet = _prefix "Spreadsheet"
    /// <summary>
    /// Represents a container for deleted files, a feature common in modern operating systems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Trash"></see></summary>
    let Trash = _prefix "Trash"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#VectorImage"></see>
    /// </summary>
    let VectorImage = _prefix "VectorImage"
    /// <summary>
    /// A video file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Video"></see></summary>
    let Video = _prefix "Video"
    /// <summary>
    /// An information resources of which representations (files, streams) can be retrieved through a web server. They may be generated at retrieval time. Typical examples are pages served by PHP or AJAX or mp3 streams.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#WebDataObject"></see></summary>
    let WebDataObject = _prefix "WebDataObject"
    /// <summary>
    /// A website, usually a container for remote resources, that may be interpreted as HTMLDocuments, images or other types of content.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Website"></see></summary>
    let Website = _prefix "Website"
    /// <summary>
    /// Visual content aspect ratio. (Width divided by Height)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#aspectRatio"></see></summary>
    let aspectRatio = _prefix "aspectRatio"
    /// <summary>
    /// The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#averageBitrate"></see></summary>
    let averageBitrate = _prefix "averageBitrate"
    /// <summary>
    /// A common superproperty for all properties specifying the media rate. Examples of subproperties may include frameRate for video and sampleRate for audio. This property is expressed in units per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rate"></see></summary>
    let rate = _prefix "rate"
    /// <summary>
    /// Models the containment relations between Files and Folders (or CompressedFiles).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#belongsToContainer"></see></summary>
    let belongsToContainer = _prefix "belongsToContainer"
    /// <summary>
    /// A common superproperty for all properties signifying the amount of bits for an atomic unit of data. Examples of subproperties may include bitsPerSample and bitsPerPixel
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitDepth"></see></summary>
    let bitDepth = _prefix "bitDepth"
    /// <summary>
    /// The type of the bitrate. Examples may include CBR and VBR.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitrateType"></see></summary>
    let bitrateType = _prefix "bitrateType"
    /// <summary>
    /// Amount of bits in each audio sample.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitsPerSample"></see></summary>
    let bitsPerSample = _prefix "bitsPerSample"
    /// <summary>
    /// The address of the linked object. Usually a web URI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bookmarks"></see></summary>
    let bookmarks = _prefix "bookmarks"
    /// <summary>
    /// Number of channels. This property is to be used directly if no detailed information is necessary. Otherwise use more detailed subproperties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#channels"></see></summary>
    let channels = _prefix "channels"
    /// <summary>
    /// The amount of characters in the document.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterCount"></see></summary>
    let characterCount = _prefix "characterCount"
    /// <summary>
    /// Character position of the bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterPosition"></see></summary>
    let characterPosition = _prefix "characterPosition"
    /// <summary>
    /// The name of the codec necessary to decode a piece of media.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#codec"></see></summary>
    let codec = _prefix "codec"
    /// <summary>
    /// The number of colors used/available in a raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorCount"></see></summary>
    let colorCount = _prefix "colorCount"
    /// <summary>
    /// Amount of bits used to express the color of each pixel.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorDepth"></see></summary>
    let colorDepth = _prefix "colorDepth"
    /// <summary>
    /// The amount of character in comments i.e. characters ignored by the compiler/interpreter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#commentCharacterCount"></see></summary>
    let commentCharacterCount = _prefix "commentCharacterCount"
    /// <summary>
    /// The type of the compression. Values include, 'lossy' and 'lossless'.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#compressionType"></see></summary>
    let compressionType = _prefix "compressionType"
    /// <summary>
    /// States that a piece of software is in conflict with another piece of software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#conflicts"></see></summary>
    let conflicts = _prefix "conflicts"
    /// <summary>
    /// The folder contains a bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmark"></see></summary>
    let containsBookmark = _prefix "containsBookmark"
    /// <summary>
    /// The folder contains a bookmark folder.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmarkFolder"></see></summary>
    let containsBookmarkFolder = _prefix "containsBookmarkFolder"
    /// <summary>
    /// Containment relation between placemark containers (files) and placemarks within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsPlacemark"></see></summary>
    let containsPlacemark = _prefix "containsPlacemark"
    /// <summary>
    /// A common superproperty for all properties signifying the amount of atomic media data units. Examples of subproperties may include sampleCount and frameCount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#decryptedStatus"></see>
    /// </summary>
    let decryptedStatus = _prefix "decryptedStatus"
    /// <summary>
    /// Name of a class defined in the source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesClass"></see></summary>
    let definesClass = _prefix "definesClass"
    /// <summary>
    /// A name of a function/method defined in the given source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesFunction"></see></summary>
    let definesFunction = _prefix "definesFunction"
    /// <summary>
    /// Name of a global variable defined within the source code file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesGlobalVariable"></see></summary>
    let definesGlobalVariable = _prefix "definesGlobalVariable"
    /// <summary>
    /// The date and time of the deletion.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#deletionDate"></see></summary>
    let deletionDate = _prefix "deletionDate"
    /// <summary>
    /// Relates an information element to an image which depicts said element.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    /// Relates an image to the information elements it depicts.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depicts"></see></summary>
    let depicts = _prefix "depicts"
    /// <summary>
    /// Duration of a media piece.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The encoding used for the Embedded File. Examples might include BASE64 or UUEncode
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encryptedStatus"></see>
    /// </summary>
    let encryptedStatus = _prefix "encryptedStatus"
    /// <summary>
    /// The status of the encryption of the InformationElement.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encryptionStatus"></see></summary>
    let encryptionStatus = _prefix "encryptionStatus"
    /// <summary>
    /// File creation date
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileCreated"></see></summary>
    let fileCreated = _prefix "fileCreated"
    /// <summary>
    /// Time when the file was last accessed.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastAccessed"></see></summary>
    let fileLastAccessed = _prefix "fileLastAccessed"
    /// <summary>
    /// last modification date
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastModified"></see></summary>
    let fileLastModified = _prefix "fileLastModified"
    /// <summary>
    /// Name of the file, together with the extension
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileName"></see></summary>
    let fileName = _prefix "fileName"
    /// <summary>
    /// The owner of the file as defined by the file system access rights feature.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileOwner"></see></summary>
    let fileOwner = _prefix "fileOwner"
    /// <summary>
    /// The size of the file in bytes. For compressed files it means the size of the packed file, not of the contents. For folders it means the aggregated size of all contained files and folders
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// URL of the file. It points at the location of the file. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileUrl"></see></summary>
    let fileUrl = _prefix "fileUrl"
    /// <summary>
    /// Type of filesystem such as ext3 and ntfs.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#filesystemType"></see></summary>
    let filesystemType = _prefix "filesystemType"
    /// <summary>
    /// The name of the font family.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fontFamily"></see></summary>
    let fontFamily = _prefix "fontFamily"
    /// <summary>
    /// The foundry, the organization that created the font.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#foundry"></see></summary>
    let foundry = _prefix "foundry"
    /// <summary>
    /// The amount of frames in a video sequence.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameCount"></see></summary>
    let frameCount = _prefix "frameCount"
    /// <summary>
    /// Amount of video frames per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameRate"></see></summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    /// Unoccupied storage space of the filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#freeSpace"></see></summary>
    let freeSpace = _prefix "freeSpace"
    /// <summary>
    /// Number of front channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frontChannels"></see></summary>
    let frontChannels = _prefix "frontChannels"
    /// <summary>
    /// Links the file with it's hash value.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasHash"></see></summary>
    let hasHash = _prefix "hasHash"
    /// <summary>
    /// This property is intended to point to an RDF list of MediaFiles.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaFileListEntry"></see></summary>
    let hasMediaFileListEntry = _prefix "hasMediaFileListEntry"
    /// <summary>
    /// Connects a media container with a single media stream contained within.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaStream"></see></summary>
    let hasMediaStream = _prefix "hasMediaStream"
    /// <summary>
    /// Name of the algorithm used to compute the hash value. Examples might include CRC32, MD5, SHA, TTH etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashAlgorithm"></see></summary>
    let hashAlgorithm = _prefix "hashAlgorithm"
    /// <summary>
    /// The actual value of the hash.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashValue"></see></summary>
    let hashValue = _prefix "hashValue"
    /// <summary>
    /// Visual content height in pixels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Horizontal resolution of an image (if printed). Expressed in DPI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#horizontalResolution"></see></summary>
    let horizontalResolution = _prefix "horizontalResolution"
    /// <summary>
    /// True if the image is interlaced, false if not.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#interlaceMode"></see></summary>
    let interlaceMode = _prefix "interlaceMode"
    /// <summary>
    /// States if a given resource is password-protected.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#isPasswordProtected"></see></summary>
    let isPasswordProtected = _prefix "isPasswordProtected"
    /// <summary>
    /// Number of Low Frequency Expansion (subwoofer) channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lfeChannels"></see></summary>
    let lfeChannels = _prefix "lfeChannels"
    /// <summary>
    /// The amount of lines in a text document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lineCount"></see></summary>
    let lineCount = _prefix "lineCount"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#losslessCompressionType"></see>
    /// </summary>
    let losslessCompressionType = _prefix "losslessCompressionType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lossyCompressionType"></see>
    /// </summary>
    let lossyCompressionType = _prefix "lossyCompressionType"
    /// <summary>
    /// Occupied storage space of the filesystem.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#occupiedSpace"></see></summary>
    let occupiedSpace = _prefix "occupiedSpace"
    /// <summary>
    /// The original location of the deleted resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#originalLocation"></see></summary>
    let originalLocation = _prefix "originalLocation"
    /// <summary>
    /// Number of pages.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageCount"></see></summary>
    let pageCount = _prefix "pageCount"
    /// <summary>
    /// Page linked by the bookmark.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageNumber"></see></summary>
    let pageNumber = _prefix "pageNumber"
    /// <summary>
    /// The number of colors defined in palette of the raster image.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#paletteSize"></see></summary>
    let paletteSize = _prefix "paletteSize"
    /// <summary>
    /// A string containing the permissions of a file. A feature common in many UNIX-like operating systems.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// Indicates the name of the programming language this source code file is written in. Examples might include 'C', 'C++', 'Java' etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#programmingLanguage"></see></summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    /// Number of rear channels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rearChannels"></see></summary>
    let rearChannels = _prefix "rearChannels"
    /// <summary>
    /// The amount of samples in an audio clip.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleCount"></see></summary>
    let sampleCount = _prefix "sampleCount"
    /// <summary>
    /// The amount of audio samples per second.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleRate"></see></summary>
    let sampleRate = _prefix "sampleRate"
    /// <summary>
    /// Number of side channels
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sideChannels"></see></summary>
    let sideChannels = _prefix "sideChannels"
    /// <summary>
    /// Stream position of the bookmark, suitable for e.g. audio books. Expressed in milliseconds
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#streamPosition"></see></summary>
    let streamPosition = _prefix "streamPosition"
    /// <summary>
    /// States that a piece of software supercedes another piece of software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#supercedes"></see></summary>
    let supercedes = _prefix "supercedes"
    /// <summary>
    /// Total storage space of the filesystem, which can be different from nie:contentSize because the latter includes filesystem format overhead.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#totalSpace"></see></summary>
    let totalSpace = _prefix "totalSpace"
    /// <summary>
    /// Uncompressed size of the content of a compressed file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uncompressedSize"></see></summary>
    let uncompressedSize = _prefix "uncompressedSize"
    /// <summary>
    /// Universally unique identifier of the filesystem. In the future, this property may have its parent changed to a more generic class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uuid"></see></summary>
    let uuid = _prefix "uuid"
    /// <summary>
    /// Vertical resolution of an Image (if printed). Expressed in DPI
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#verticalResolution"></see></summary>
    let verticalResolution = _prefix "verticalResolution"
    /// <summary>
    /// Visual content width in pixels.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// The amount of words in a text document.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#wordCount"></see></summary>
    let wordCount = _prefix "wordCount"
