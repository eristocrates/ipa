#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nfo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#" "nfo"

    /// <summary>
    ///   <para>rdfs:label : Application^^xsd:string</para>
    ///   <para>rdfs:comment : An application^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Application">nfo:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>rdfs:label : Archive^^xsd:string</para>
    ///   <para>rdfs:comment : A compressed file. May contain other files or folder inside. ^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Archive">nfo:Archive</a>
    /// </summary>
    let Archive = _prefixId.prefix "Archive"
    /// <summary>
    ///   <para>rdfs:label : ArchiveItem^^xsd:string</para>
    ///   <para>rdfs:comment : A file entity inside an archive.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#ArchiveItem">nfo:ArchiveItem</a>
    /// </summary>
    let ArchiveItem = _prefixId.prefix "ArchiveItem"
    /// <summary>
    ///   <para>rdfs:label : Attachment^^xsd:string</para>
    ///   <para>rdfs:comment : A file attached to another data object. Many data formats allow for attachments: emails, vcards, ical events, id3 and exif...^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Attachment">nfo:Attachment</a>
    /// </summary>
    let Attachment = _prefixId.prefix "Attachment"
    /// <summary>
    ///   <para>rdfs:label : Audio^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing audio content^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Audio">nfo:Audio</a>
    /// </summary>
    let Audio = _prefixId.prefix "Audio"
    /// <summary>
    ///   <para>rdfs:label : Bookmark^^xsd:string</para>
    ///   <para>rdfs:comment : A bookmark of a webbrowser. Use nie:title for the name/label, nie:contentCreated to represent the date when the user added the bookmark, and nie:contentLastModified for modifications. nfo:bookmarks to store the link.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Bookmark">nfo:Bookmark</a>
    /// </summary>
    let Bookmark = _prefixId.prefix "Bookmark"
    /// <summary>
    ///   <para>rdfs:label : Bookmark Folder^^xsd:string</para>
    ///   <para>rdfs:comment : A folder with bookmarks of a webbrowser. Use nfo:containsBookmark to relate Bookmarks. Folders can contain subfolders, use containsBookmarkFolder to relate them.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#BookmarkFolder">nfo:BookmarkFolder</a>
    /// </summary>
    let BookmarkFolder = _prefixId.prefix "BookmarkFolder"
    /// <summary>
    ///   <para>rdfs:label : CompressionType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of compression. Instances of this class represent the limited set of values allowed for the nfo:compressionType property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#CompressionType">nfo:CompressionType</a>
    /// </summary>
    let CompressionType = _prefixId.prefix "CompressionType"
    /// <summary>
    ///   <para>rdfs:label : Cursor^^xsd:string</para>
    ///   <para>rdfs:comment : A Cursor.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Cursor">nfo:Cursor</a>
    /// </summary>
    let Cursor = _prefixId.prefix "Cursor"
    /// <summary>
    ///   <para>rdfs:label : DataContainer^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass for all entities, whose primary purpose is to serve as containers for other data object. They usually don't have any "meaning" by themselves. Examples include folders, archives and optical disc images.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DataContainer">nfo:DataContainer</a>
    /// </summary>
    let DataContainer = _prefixId.prefix "DataContainer"
    /// <summary>
    ///   <para>rdfs:label : DeletedResource^^xsd:string</para>
    ///   <para>rdfs:comment : A file entity that has been deleted from the original source. Usually such entities are stored within various kinds of 'Trash' or 'Recycle Bin' folders.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#DeletedResource">nfo:DeletedResource</a>
    /// </summary>
    let DeletedResource = _prefixId.prefix "DeletedResource"
    /// <summary>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>rdfs:comment : A generic document. A common superclass for all documents on the desktop.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Document">nfo:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : EmbeddedFileDataObject^^xsd:string</para>
    ///   <para>rdfs:comment : A file embedded in another data object. There are many ways in which a file may be embedded in another one. Use this class directly only in cases if none of the subclasses gives a better description of your case.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EmbeddedFileDataObject">nfo:EmbeddedFileDataObject</a>
    /// </summary>
    let EmbeddedFileDataObject = _prefixId.prefix "EmbeddedFileDataObject"
    /// <summary>
    ///   <para>rdfs:label : EncryptionStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The status of the encryption of an InformationElement. nfo:encryptedStatus means that the InformationElement has been encrypted and couldn't be decrypted by the extraction software, thus no content is available. nfo:decryptedStatus means that decryption was successfull and the content is available.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#EncryptionStatus">nfo:EncryptionStatus</a>
    /// </summary>
    let EncryptionStatus = _prefixId.prefix "EncryptionStatus"
    /// <summary>
    ///   <para>rdfs:label : Executable^^xsd:string</para>
    ///   <para>rdfs:comment : An executable file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Executable">nfo:Executable</a>
    /// </summary>
    let Executable = _prefixId.prefix "Executable"
    /// <summary>
    ///   <para>rdfs:label : file^^xsd:string</para>
    ///   <para>rdfs:comment : A resource containing a finite sequence of bytes with arbitrary information, that is available to a computer program and is usually based on some kind of durable storage. A file is durable in the sense that it remains available for programs to use after the current program has finished.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileDataObject">nfo:FileDataObject</a>
    /// </summary>
    let FileDataObject = _prefixId.prefix "FileDataObject"
    /// <summary>
    ///   <para>rdfs:label : FileHash^^xsd:string</para>
    ///   <para>rdfs:comment : A fingerprint of the file, generated by some hashing function.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FileHash">nfo:FileHash</a>
    /// </summary>
    let FileHash = _prefixId.prefix "FileHash"
    /// <summary>
    ///   <para>rdfs:label : Filesystem^^xsd:string</para>
    ///   <para>rdfs:comment : A filesystem. Examples of filesystems include hard disk partitions, removable media, but also images thereof stored in files such as ISO.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Filesystem">nfo:Filesystem</a>
    /// </summary>
    let Filesystem = _prefixId.prefix "Filesystem"
    /// <summary>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : FilesystemImage^^xsd:string</para>
    ///   <para>rdfs:comment : An image of a filesystem. Instances of this class may include CD images, DVD images or hard disk partition images created by various pieces of software (e.g. Norton Ghost). Deprecated in favor of nfo:Filesystem.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#FilesystemImage">nfo:FilesystemImage</a>
    /// </summary>
    let FilesystemImage = _prefixId.prefix "FilesystemImage"
    /// <summary>
    ///   <para>rdfs:label : Folder^^xsd:string</para>
    ///   <para>rdfs:comment : A folder/directory. Examples of folders include folders on a filesystem and message folders in a mailbox.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Folder">nfo:Folder</a>
    /// </summary>
    let Folder = _prefixId.prefix "Folder"
    /// <summary>
    ///   <para>rdfs:label : Font^^xsd:string</para>
    ///   <para>rdfs:comment : A font.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Font">nfo:Font</a>
    /// </summary>
    let Font = _prefixId.prefix "Font"
    /// <summary>
    ///   <para>rdfs:label : HardDiskPartition^^xsd:string</para>
    ///   <para>rdfs:comment : A partition on a hard disk^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HardDiskPartition">nfo:HardDiskPartition</a>
    /// </summary>
    let HardDiskPartition = _prefixId.prefix "HardDiskPartition"
    /// <summary>
    ///   <para>rdfs:label : HtmlDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A HTML document, may contain links to other files.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#HtmlDocument">nfo:HtmlDocument</a>
    /// </summary>
    let HtmlDocument = _prefixId.prefix "HtmlDocument"
    /// <summary>
    ///   <para>rdfs:label : Icon^^xsd:string</para>
    ///   <para>rdfs:comment : An Icon (regardless of whether it's a raster or a vector icon. A resource representing an icon could have two types (Icon and Raster, or Icon and Vector) if required.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Icon">nfo:Icon</a>
    /// </summary>
    let Icon = _prefixId.prefix "Icon"
    /// <summary>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing an image.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Image">nfo:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : local file^^xsd:string</para>
    ///   <para>rdfs:comment : A local file data object which is stored on a local file system. Its nie:url always uses the file:/ protocol. The main use of this class is to distinguish local and non-local files.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#LocalFileDataObject">nfo:LocalFileDataObject</a>
    /// </summary>
    let LocalFileDataObject = _prefixId.prefix "LocalFileDataObject"
    /// <summary>
    ///   <para>rdfs:label : Media^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of media content. This class may be used to express complex media containers with many streams of various media content (both aural and visual).^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Media">nfo:Media</a>
    /// </summary>
    let Media = _prefixId.prefix "Media"
    /// <summary>
    ///   <para>rdfs:label : MediaFileListEntry^^xsd:string</para>
    ///   <para>rdfs:comment : A single node in the list of media files contained within an MediaList instance. This class is intended to provide a type all those links have. In valid NRL untyped resources cannot be linked. There are no properties defined for this class but the application may expect rdf:first and rdf:last links. The former points to the DataObject instance, interpreted as Media the latter points at another MediaFileListEntr. At the end of the list there is a link to rdf:nil.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaFileListEntry">nfo:MediaFileListEntry</a>
    /// </summary>
    let MediaFileListEntry = _prefixId.prefix "MediaFileListEntry"
    /// <summary>
    ///   <para>rdfs:label : MediaList^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing a list of media files.e.g. a playlist^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaList">nfo:MediaList</a>
    /// </summary>
    let MediaList = _prefixId.prefix "MediaList"
    /// <summary>
    ///   <para>rdfs:label : MediaStream^^xsd:string</para>
    ///   <para>rdfs:comment : A stream of multimedia content, usually contained within a media container such as a movie (containing both audio and video) or a DVD (possibly containing many streams of audio and video). Most common interpretations for such a DataObject include Audio and Video.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MediaStream">nfo:MediaStream</a>
    /// </summary>
    let MediaStream = _prefixId.prefix "MediaStream"
    /// <summary>
    ///   <para>rdfs:label : MindMap^^xsd:string</para>
    ///   <para>rdfs:comment : A MindMap, created by a mind-mapping utility. Examples might include FreeMind or mind mapper.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#MindMap">nfo:MindMap</a>
    /// </summary>
    let MindMap = _prefixId.prefix "MindMap"
    /// <summary>
    ///   <para>rdfs:label : OperatingSystem^^xsd:string</para>
    ///   <para>rdfs:comment : An OperatingSystem^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#OperatingSystem">nfo:OperatingSystem</a>
    /// </summary>
    let OperatingSystem = _prefixId.prefix "OperatingSystem"
    /// <summary>
    ///   <para>rdfs:label : PaginatedTextDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing a text document, that is unambiguously divided into pages. Examples might include PDF, DOC, PS, DVI etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PaginatedTextDocument">nfo:PaginatedTextDocument</a>
    /// </summary>
    let PaginatedTextDocument = _prefixId.prefix "PaginatedTextDocument"
    /// <summary>
    ///   <para>rdfs:label : Placemark^^xsd:string</para>
    ///   <para>rdfs:comment : One placemark within a placemark container/file. Use nie:title for the name/label, nao:creator for defining the creator.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Placemark">nfo:Placemark</a>
    /// </summary>
    let Placemark = _prefixId.prefix "Placemark"
    /// <summary>
    ///   <para>rdfs:label : Placemark Container^^xsd:string</para>
    ///   <para>rdfs:comment : A data object containing placemark(s). Use nie:contentCreated to represent the date when the user created the dataobject, nao:creator for defining the creator, nie:contentLastModified for modifications. nfo:containsPlacemark to refer to individual placemarks within.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlacemarkContainer">nfo:PlacemarkContainer</a>
    /// </summary>
    let PlacemarkContainer = _prefixId.prefix "PlacemarkContainer"
    /// <summary>
    ///   <para>rdfs:label : PlainTextDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing plain text (ASCII, Unicode or other encodings). Examples may include TXT, HTML, XML, program source code etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#PlainTextDocument">nfo:PlainTextDocument</a>
    /// </summary>
    let PlainTextDocument = _prefixId.prefix "PlainTextDocument"
    /// <summary>
    ///   <para>rdfs:label : Presentation^^xsd:string</para>
    ///   <para>rdfs:comment : A Presentation made by some presentation software (Corel Presentations, OpenOffice Impress, MS Powerpoint etc.)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Presentation">nfo:Presentation</a>
    /// </summary>
    let Presentation = _prefixId.prefix "Presentation"
    /// <summary>
    ///   <para>rdfs:label : RasterImage^^xsd:string</para>
    ///   <para>rdfs:comment : A raster image.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RasterImage">nfo:RasterImage</a>
    /// </summary>
    let RasterImage = _prefixId.prefix "RasterImage"
    /// <summary>
    ///   <para>rdfs:label : RemoteDataObject^^xsd:string</para>
    ///   <para>rdfs:comment : A file data object stored at a remote location. Don't confuse this class with a RemotePortAddress. This one applies to a particular resource, RemotePortAddress applies to an address, that can have various interpretations.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemoteDataObject">nfo:RemoteDataObject</a>
    /// </summary>
    let RemoteDataObject = _prefixId.prefix "RemoteDataObject"
    /// <summary>
    ///   <para>rdfs:label : RemotePortAddress^^xsd:string</para>
    ///   <para>rdfs:comment : An address specifying a remote host and port. Such an address can be interpreted in many ways (examples of such interpretations include mailboxes, websites, remote calendars or filesystems), depending on an interpretation, various kinds of data may be extracted from such an address.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#RemotePortAddress">nfo:RemotePortAddress</a>
    /// </summary>
    let RemotePortAddress = _prefixId.prefix "RemotePortAddress"
    /// <summary>
    ///   <para>rdfs:label : Software^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of software. Examples may include applications and the operating system. This interpretation most commonly applies to SoftwareItems.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Software">nfo:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : SoftwareItem^^xsd:string</para>
    ///   <para>rdfs:comment : A DataObject representing a piece of software. Examples of interpretations of a SoftwareItem include an Application and an OperatingSystem.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareItem">nfo:SoftwareItem</a>
    /// </summary>
    let SoftwareItem = _prefixId.prefix "SoftwareItem"
    /// <summary>
    ///   <para>rdfs:label : SoftwareService^^xsd:string</para>
    ///   <para>rdfs:comment : A service published by a piece of software, either by an operating system or an application. Examples of such services may include calendar, addressbook and mailbox managed by a PIM application. This category is introduced to distinguish between data available directly from the applications (Via some Interprocess Communication Mechanisms) and data available from files on a disk. In either case both DataObjects would receive a similar interpretation (e.g. a Mailbox) and wouldn't differ on the content level.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SoftwareService">nfo:SoftwareService</a>
    /// </summary>
    let SoftwareService = _prefixId.prefix "SoftwareService"
    /// <summary>
    ///   <para>rdfs:label : SourceCode^^xsd:string</para>
    ///   <para>rdfs:comment : Code in a compilable or interpreted programming language.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#SourceCode">nfo:SourceCode</a>
    /// </summary>
    let SourceCode = _prefixId.prefix "SourceCode"
    /// <summary>
    ///   <para>rdfs:label : Spreadsheet^^xsd:string</para>
    ///   <para>rdfs:comment : A spreadsheet, created by a spreadsheet application. Examples might include Gnumeric, OpenOffice Calc or MS Excel.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Spreadsheet">nfo:Spreadsheet</a>
    /// </summary>
    let Spreadsheet = _prefixId.prefix "Spreadsheet"
    /// <summary>
    ///   <para>rdfs:label : TextDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A text document^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#TextDocument">nfo:TextDocument</a>
    /// </summary>
    let TextDocument = _prefixId.prefix "TextDocument"
    /// <summary>
    ///   <para>rdfs:label : Trash^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a container for deleted files, a feature common in modern operating systems.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Trash">nfo:Trash</a>
    /// </summary>
    let Trash = _prefixId.prefix "Trash"
    /// <summary>
    ///   <para>rdfs:label : VectorImage^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#VectorImage">nfo:VectorImage</a>
    /// </summary>
    let VectorImage = _prefixId.prefix "VectorImage"
    /// <summary>
    ///   <para>rdfs:label : Video^^xsd:string</para>
    ///   <para>rdfs:comment : A video file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Video">nfo:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>rdfs:label : Visual^^xsd:string</para>
    ///   <para>rdfs:comment : File containing visual content.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Visual">nfo:Visual</a>
    /// </summary>
    let Visual = _prefixId.prefix "Visual"
    /// <summary>
    ///   <para>rdfs:label : web data object^^xsd:string</para>
    ///   <para>rdfs:comment : An information resources of which representations (files, streams) can be retrieved through a web server. They may be generated at retrieval time. Typical examples are pages served by PHP or AJAX or mp3 streams.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#WebDataObject">nfo:WebDataObject</a>
    /// </summary>
    let WebDataObject = _prefixId.prefix "WebDataObject"
    /// <summary>
    ///   <para>rdfs:label : Website^^xsd:string</para>
    ///   <para>rdfs:comment : A website, usually a container for remote resources, that may be interpreted as HTMLDocuments, images or other types of content.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#Website">nfo:Website</a>
    /// </summary>
    let Website = _prefixId.prefix "Website"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : aspectRatio^^xsd:string</para>
    ///   <para>rdfs:comment : Visual content aspect ratio. (Width divided by Height)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#aspectRatio">nfo:aspectRatio</a>
    /// </summary>
    let aspectRatio = _prefixId.prefix "aspectRatio"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : averageBitrate^^xsd:string</para>
    ///   <para>rdfs:comment : The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds).^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#averageBitrate">nfo:averageBitrate</a>
    /// </summary>
    let averageBitrate = _prefixId.prefix "averageBitrate"
    /// <summary>
    ///   <para>rdfs:label : belongsToContainer^^xsd:string</para>
    ///   <para>rdfs:comment : Models the containment relations between Files and Folders (or CompressedFiles).^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#belongsToContainer">nfo:belongsToContainer</a>
    /// </summary>
    let belongsToContainer = _prefixId.prefix "belongsToContainer"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : bitDepth^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all properties signifying the amount of bits for an atomic unit of data. Examples of subproperties may include bitsPerSample and bitsPerPixel^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitDepth">nfo:bitDepth</a>
    /// </summary>
    let bitDepth = _prefixId.prefix "bitDepth"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : bitrateType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the bitrate. Examples may include CBR and VBR.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitrateType">nfo:bitrateType</a>
    /// </summary>
    let bitrateType = _prefixId.prefix "bitrateType"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : bitsPerSample^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of bits in each audio sample.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bitsPerSample">nfo:bitsPerSample</a>
    /// </summary>
    let bitsPerSample = _prefixId.prefix "bitsPerSample"
    /// <summary>
    ///   <para>nrl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : link^^xsd:string</para>
    ///   <para>rdfs:comment : The address of the linked object. Usually a web URI.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#bookmarks">nfo:bookmarks</a>
    /// </summary>
    let bookmarks = _prefixId.prefix "bookmarks"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : channels^^xsd:string</para>
    ///   <para>rdfs:comment : Number of channels. This property is to be used directly if no detailed information is necessary. Otherwise use more detailed subproperties.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#channels">nfo:channels</a>
    /// </summary>
    let channels = _prefixId.prefix "channels"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : characterCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of characters in the document.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterCount">nfo:characterCount</a>
    /// </summary>
    let characterCount = _prefixId.prefix "characterCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : characterPosition^^xsd:string</para>
    ///   <para>rdfs:comment : Character position of the bookmark.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#characterPosition">nfo:characterPosition</a>
    /// </summary>
    let characterPosition = _prefixId.prefix "characterPosition"
    /// <summary>
    ///   <para>rdfs:label : codec^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the codec necessary to decode a piece of media.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#codec">nfo:codec</a>
    /// </summary>
    let codec = _prefixId.prefix "codec"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : color count^^xsd:string</para>
    ///   <para>rdfs:comment : The number of colors used/available in a raster image.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorCount">nfo:colorCount</a>
    /// </summary>
    let colorCount = _prefixId.prefix "colorCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : colorDepth^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of bits used to express the color of each pixel.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#colorDepth">nfo:colorDepth</a>
    /// </summary>
    let colorDepth = _prefixId.prefix "colorDepth"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : commentCharacterCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of character in comments i.e. characters ignored by the compiler/interpreter.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#commentCharacterCount">nfo:commentCharacterCount</a>
    /// </summary>
    let commentCharacterCount = _prefixId.prefix "commentCharacterCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : compressionType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the compression. Values include, 'lossy' and 'lossless'.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#compressionType">nfo:compressionType</a>
    /// </summary>
    let compressionType = _prefixId.prefix "compressionType"
    /// <summary>
    ///   <para>rdfs:label : conflicts^^xsd:string</para>
    ///   <para>rdfs:comment : States that a piece of software is in conflict with another piece of software.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#conflicts">nfo:conflicts</a>
    /// </summary>
    let conflicts = _prefixId.prefix "conflicts"
    /// <summary>
    ///   <para>rdfs:label : contains bookmark^^xsd:string</para>
    ///   <para>rdfs:comment : The folder contains a bookmark.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmark">nfo:containsBookmark</a>
    /// </summary>
    let containsBookmark = _prefixId.prefix "containsBookmark"
    /// <summary>
    ///   <para>rdfs:label : contains folder^^xsd:string</para>
    ///   <para>rdfs:comment : The folder contains a bookmark folder.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsBookmarkFolder">nfo:containsBookmarkFolder</a>
    /// </summary>
    let containsBookmarkFolder = _prefixId.prefix "containsBookmarkFolder"
    /// <summary>
    ///   <para>rdfs:label : contains Placemark^^xsd:string</para>
    ///   <para>rdfs:comment : Containment relation between placemark containers (files) and placemarks within.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#containsPlacemark">nfo:containsPlacemark</a>
    /// </summary>
    let containsPlacemark = _prefixId.prefix "containsPlacemark"
    /// <summary>
    ///   <para>rdfs:label : count^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all properties signifying the amount of atomic media data units. Examples of subproperties may include sampleCount and frameCount.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#count">nfo:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    let decryptedStatus = _prefixId.prefix "decryptedStatus"
    /// <summary>
    ///   <para>rdfs:label : definesClass^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a class defined in the source code file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesClass">nfo:definesClass</a>
    /// </summary>
    let definesClass = _prefixId.prefix "definesClass"
    /// <summary>
    ///   <para>rdfs:label : definesFunction^^xsd:string</para>
    ///   <para>rdfs:comment : A name of a function/method defined in the given source code file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesFunction">nfo:definesFunction</a>
    /// </summary>
    let definesFunction = _prefixId.prefix "definesFunction"
    /// <summary>
    ///   <para>rdfs:label : definesGlobalVariable^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a global variable defined within the source code file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#definesGlobalVariable">nfo:definesGlobalVariable</a>
    /// </summary>
    let definesGlobalVariable = _prefixId.prefix "definesGlobalVariable"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : deletionDate^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of the deletion.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#deletionDate">nfo:deletionDate</a>
    /// </summary>
    let deletionDate = _prefixId.prefix "deletionDate"
    /// <summary>
    ///   <para>rdfs:label : depiction^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an information element to an image which depicts said element.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depiction">nfo:depiction</a>
    /// </summary>
    let depiction = _prefixId.prefix "depiction"
    /// <summary>
    ///   <para>rdfs:label : depicts^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an image to the information elements it depicts.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#depicts">nfo:depicts</a>
    /// </summary>
    let depicts = _prefixId.prefix "depicts"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <para>rdfs:comment : Duration of a media piece.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#duration">nfo:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <para>rdfs:comment : The encoding used for the Embedded File. Examples might include BASE64 or UUEncode^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encoding">nfo:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    let encryptedStatus = _prefixId.prefix "encryptedStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : encryptionStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The status of the encryption of the InformationElement.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#encryptionStatus">nfo:encryptionStatus</a>
    /// </summary>
    let encryptionStatus = _prefixId.prefix "encryptionStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fileCreated^^xsd:string</para>
    ///   <para>rdfs:comment : File creation date^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileCreated">nfo:fileCreated</a>
    /// </summary>
    let fileCreated = _prefixId.prefix "fileCreated"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fileLastAccessed^^xsd:string</para>
    ///   <para>rdfs:comment : Time when the file was last accessed.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastAccessed">nfo:fileLastAccessed</a>
    /// </summary>
    let fileLastAccessed = _prefixId.prefix "fileLastAccessed"
    /// <summary>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : fileLastModified^^xsd:string</para>
    ///   <para>rdfs:comment : last modification date^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileLastModified">nfo:fileLastModified</a>
    /// </summary>
    let fileLastModified = _prefixId.prefix "fileLastModified"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : fileName^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the file, together with the extension^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileName">nfo:fileName</a>
    /// </summary>
    let fileName = _prefixId.prefix "fileName"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fileOwner^^xsd:string</para>
    ///   <para>rdfs:comment : The owner of the file as defined by the file system access rights feature.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileOwner">nfo:fileOwner</a>
    /// </summary>
    let fileOwner = _prefixId.prefix "fileOwner"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fileSize^^xsd:string</para>
    ///   <para>rdfs:comment : The size of the file in bytes. For compressed files it means the size of the packed file, not of the contents. For folders it means the aggregated size of all contained files and folders ^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileSize">nfo:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : fileUrl^^xsd:string</para>
    ///   <para>rdfs:comment : URL of the file. It points at the location of the file. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fileUrl">nfo:fileUrl</a>
    /// </summary>
    let fileUrl = _prefixId.prefix "fileUrl"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : filesystemType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of filesystem such as ext3 and ntfs.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#filesystemType">nfo:filesystemType</a>
    /// </summary>
    let filesystemType = _prefixId.prefix "filesystemType"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fontFamily^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the font family.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#fontFamily">nfo:fontFamily</a>
    /// </summary>
    let fontFamily = _prefixId.prefix "fontFamily"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : foundry^^xsd:string</para>
    ///   <para>rdfs:comment : The foundry, the organization that created the font.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#foundry">nfo:foundry</a>
    /// </summary>
    let foundry = _prefixId.prefix "foundry"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : frameCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of frames in a video sequence.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameCount">nfo:frameCount</a>
    /// </summary>
    let frameCount = _prefixId.prefix "frameCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : frameRate^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of video frames per second.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frameRate">nfo:frameRate</a>
    /// </summary>
    let frameRate = _prefixId.prefix "frameRate"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : freeSpace^^xsd:string</para>
    ///   <para>rdfs:comment : Unoccupied storage space of the filesystem.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#freeSpace">nfo:freeSpace</a>
    /// </summary>
    let freeSpace = _prefixId.prefix "freeSpace"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : frontChannels^^xsd:string</para>
    ///   <para>rdfs:comment : Number of front channels.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#frontChannels">nfo:frontChannels</a>
    /// </summary>
    let frontChannels = _prefixId.prefix "frontChannels"
    /// <summary>
    ///   <para>nao:userVisible : false^^xsd:boolean</para>
    ///   <para>rdfs:label : hasHash^^xsd:string</para>
    ///   <para>rdfs:comment : Links the file with it's hash value.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasHash">nfo:hasHash</a>
    /// </summary>
    let hasHash = _prefixId.prefix "hasHash"
    /// <summary>
    ///   <para>rdfs:label : hasMediaFileListEntry^^xsd:string</para>
    ///   <para>rdfs:comment : This property is intended to point to an RDF list of MediaFiles.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaFileListEntry">nfo:hasMediaFileListEntry</a>
    /// </summary>
    let hasMediaFileListEntry = _prefixId.prefix "hasMediaFileListEntry"
    /// <summary>
    ///   <para>rdfs:label : hasMediaStream^^xsd:string</para>
    ///   <para>rdfs:comment : Connects a media container with a single media stream contained within.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hasMediaStream">nfo:hasMediaStream</a>
    /// </summary>
    let hasMediaStream = _prefixId.prefix "hasMediaStream"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : hashAlgorithm^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the algorithm used to compute the hash value. Examples might include CRC32, MD5, SHA, TTH etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashAlgorithm">nfo:hashAlgorithm</a>
    /// </summary>
    let hashAlgorithm = _prefixId.prefix "hashAlgorithm"
    /// <summary>
    ///   <para>nrl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : hashValue^^xsd:string</para>
    ///   <para>rdfs:comment : The actual value of the hash.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#hashValue">nfo:hashValue</a>
    /// </summary>
    let hashValue = _prefixId.prefix "hashValue"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : height^^xsd:string</para>
    ///   <para>rdfs:comment : Visual content height in pixels.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#height">nfo:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : horizontalResolution^^xsd:string</para>
    ///   <para>rdfs:comment : Horizontal resolution of an image (if printed). Expressed in DPI.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#horizontalResolution">nfo:horizontalResolution</a>
    /// </summary>
    let horizontalResolution = _prefixId.prefix "horizontalResolution"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : interlaceMode^^xsd:string</para>
    ///   <para>rdfs:comment : True if the image is interlaced, false if not.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#interlaceMode">nfo:interlaceMode</a>
    /// </summary>
    let interlaceMode = _prefixId.prefix "interlaceMode"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : isPasswordProtected^^xsd:string</para>
    ///   <para>rdfs:comment : States if a given resource is password-protected.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#isPasswordProtected">nfo:isPasswordProtected</a>
    /// </summary>
    let isPasswordProtected = _prefixId.prefix "isPasswordProtected"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : lfeChannels^^xsd:string</para>
    ///   <para>rdfs:comment : Number of Low Frequency Expansion (subwoofer) channels.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lfeChannels">nfo:lfeChannels</a>
    /// </summary>
    let lfeChannels = _prefixId.prefix "lfeChannels"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : lineCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of lines in a text document^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#lineCount">nfo:lineCount</a>
    /// </summary>
    let lineCount = _prefixId.prefix "lineCount"
    let losslessCompressionType = _prefixId.prefix "losslessCompressionType"
    let lossyCompressionType = _prefixId.prefix "lossyCompressionType"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : occupiedSpace^^xsd:string</para>
    ///   <para>rdfs:comment : Occupied storage space of the filesystem.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#occupiedSpace">nfo:occupiedSpace</a>
    /// </summary>
    let occupiedSpace = _prefixId.prefix "occupiedSpace"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : originalLocation^^xsd:string</para>
    ///   <para>rdfs:comment : The original location of the deleted resource.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#originalLocation">nfo:originalLocation</a>
    /// </summary>
    let originalLocation = _prefixId.prefix "originalLocation"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : pageCount^^xsd:string</para>
    ///   <para>rdfs:comment : Number of pages.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageCount">nfo:pageCount</a>
    /// </summary>
    let pageCount = _prefixId.prefix "pageCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : pageNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Page linked by the bookmark.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#pageNumber">nfo:pageNumber</a>
    /// </summary>
    let pageNumber = _prefixId.prefix "pageNumber"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : palette size^^xsd:string</para>
    ///   <para>rdfs:comment : The number of colors defined in palette of the raster image.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#paletteSize">nfo:paletteSize</a>
    /// </summary>
    let paletteSize = _prefixId.prefix "paletteSize"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : permissions^^xsd:string</para>
    ///   <para>rdfs:comment : A string containing the permissions of a file. A feature common in many UNIX-like operating systems.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#permissions">nfo:permissions</a>
    /// </summary>
    let permissions = _prefixId.prefix "permissions"
    /// <summary>
    ///   <para>rdfs:label : programmingLanguage^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the name of the programming language this source code file is written in. Examples might include 'C', 'C++', 'Java' etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#programmingLanguage">nfo:programmingLanguage</a>
    /// </summary>
    let programmingLanguage = _prefixId.prefix "programmingLanguage"
    /// <summary>
    ///   <para>rdfs:label : rate^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all properties specifying the media rate. Examples of subproperties may include frameRate for video and sampleRate for audio. This property is expressed in units per second.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rate">nfo:rate</a>
    /// </summary>
    let rate = _prefixId.prefix "rate"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : rearChannels^^xsd:string</para>
    ///   <para>rdfs:comment : Number of rear channels.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#rearChannels">nfo:rearChannels</a>
    /// </summary>
    let rearChannels = _prefixId.prefix "rearChannels"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : sampleCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of samples in an audio clip.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleCount">nfo:sampleCount</a>
    /// </summary>
    let sampleCount = _prefixId.prefix "sampleCount"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : sampleRate^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of audio samples per second.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sampleRate">nfo:sampleRate</a>
    /// </summary>
    let sampleRate = _prefixId.prefix "sampleRate"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : sideChannels^^xsd:string</para>
    ///   <para>rdfs:comment : Number of side channels^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#sideChannels">nfo:sideChannels</a>
    /// </summary>
    let sideChannels = _prefixId.prefix "sideChannels"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : streamPosition^^xsd:string</para>
    ///   <para>rdfs:comment : Stream position of the bookmark, suitable for e.g. audio books. Expressed in milliseconds^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#streamPosition">nfo:streamPosition</a>
    /// </summary>
    let streamPosition = _prefixId.prefix "streamPosition"
    /// <summary>
    ///   <para>rdfs:label : supercedes^^xsd:string</para>
    ///   <para>rdfs:comment : States that a piece of software supercedes another piece of software.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#supercedes">nfo:supercedes</a>
    /// </summary>
    let supercedes = _prefixId.prefix "supercedes"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : totalSpace^^xsd:string</para>
    ///   <para>rdfs:comment : Total storage space of the filesystem, which can be different from nie:contentSize because the latter includes filesystem format overhead.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#totalSpace">nfo:totalSpace</a>
    /// </summary>
    let totalSpace = _prefixId.prefix "totalSpace"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : uncompressedSize^^xsd:string</para>
    ///   <para>rdfs:comment : Uncompressed size of the content of a compressed file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uncompressedSize">nfo:uncompressedSize</a>
    /// </summary>
    let uncompressedSize = _prefixId.prefix "uncompressedSize"
    /// <summary>
    ///   <para>rdfs:label : uuid^^xsd:string</para>
    ///   <para>rdfs:comment : Universally unique identifier of the filesystem. In the future, this property may have its parent changed to a more generic class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#uuid">nfo:uuid</a>
    /// </summary>
    let uuid = _prefixId.prefix "uuid"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : verticalResolution^^xsd:string</para>
    ///   <para>rdfs:comment : Vertical resolution of an Image (if printed). Expressed in DPI^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#verticalResolution">nfo:verticalResolution</a>
    /// </summary>
    let verticalResolution = _prefixId.prefix "verticalResolution"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : width^^xsd:string</para>
    ///   <para>rdfs:comment : Visual content width in pixels.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#width">nfo:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : wordCount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of words in a text document.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#wordCount">nfo:wordCount</a>
    /// </summary>
    let wordCount = _prefixId.prefix "wordCount"
