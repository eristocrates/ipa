namespace http.tracker.api.gnome.org.ontology.v3.nfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnfo =
    let _namespace_iri = Namespace_Iri tnfo |> NamespaceIRI
    /// <summary>
    ///   <para>tnfo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Namespace</para>
    ///   <para>tnrl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#">http://tracker.api.gnome.org/ontology/v3/nfo#</seealso>
    let _prefix_iri = Prefixed_Name(tnfo, "") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Application">http://tracker.api.gnome.org/ontology/v3/nfo#Application</seealso>
    let Application = Prefixed_Name(tnfo, "Application") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A compressed file. May contain other files or folder inside."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Archive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Archive">http://tracker.api.gnome.org/ontology/v3/nfo#Archive</seealso>
    let Archive = Prefixed_Name(tnfo, "Archive") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:ArchiveItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file entity inside an archive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArchiveItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#ArchiveItem">http://tracker.api.gnome.org/ontology/v3/nfo#ArchiveItem</seealso>
    let ArchiveItem = Prefixed_Name(tnfo, "ArchiveItem") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file attached to another data object. Many data formats allow for attachments: emails, vcards, ical events, id3 and exif..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attachment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Attachment">http://tracker.api.gnome.org/ontology/v3/nfo#Attachment</seealso>
    let Attachment = Prefixed_Name(tnfo, "Attachment") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file containing audio content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Audio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Audio">http://tracker.api.gnome.org/ontology/v3/nfo#Audio</seealso>
    let Audio = Prefixed_Name(tnfo, "Audio") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Bookmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A bookmark of a webbrowser. Use nie:title for the name/label, nie:contentCreated to represent the date when the user added the bookmark, and nie:contentLastModified for modifications. nfo:bookmarks to store the link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bookmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Bookmark">http://tracker.api.gnome.org/ontology/v3/nfo#Bookmark</seealso>
    let Bookmark = Prefixed_Name(tnfo, "Bookmark") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:BookmarkFolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A folder with bookmarks of a webbrowser. Use nfo:containsBookmark to relate Bookmarks. Folders can contain subfolders, use containsBookmarkFolder to relate them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bookmark Folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#BookmarkFolder">http://tracker.api.gnome.org/ontology/v3/nfo#BookmarkFolder</seealso>
    let BookmarkFolder = Prefixed_Name(tnfo, "BookmarkFolder") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:CompressionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Type of compression. Instances of this class represent the limited set of values allowed for the nfo:compressionType property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompressionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#CompressionType">http://tracker.api.gnome.org/ontology/v3/nfo#CompressionType</seealso>
    let CompressionType = Prefixed_Name(tnfo, "CompressionType") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Cursor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Cursor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cursor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Cursor">http://tracker.api.gnome.org/ontology/v3/nfo#Cursor</seealso>
    let Cursor = Prefixed_Name(tnfo, "Cursor") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:DataContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A superclass for all entities, whose primary purpose is to serve as containers for other data object. They usually don't have any 'meaning' by themselves. Examples include folders, archives and optical disc images."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataContainer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#DataContainer">http://tracker.api.gnome.org/ontology/v3/nfo#DataContainer</seealso>
    let DataContainer = Prefixed_Name(tnfo, "DataContainer") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:DeletedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file entity that has been deleted from the original source. Usually such entities are stored within various kinds of 'Trash' or 'Recycle Bin' folders."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeletedResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#DeletedResource">http://tracker.api.gnome.org/ontology/v3/nfo#DeletedResource</seealso>
    let DeletedResource = Prefixed_Name(tnfo, "DeletedResource") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A generic document. A common superclass for all documents on the desktop."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Document">http://tracker.api.gnome.org/ontology/v3/nfo#Document</seealso>
    let Document = Prefixed_Name(tnfo, "Document") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:EBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Books which can be electronically viewed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electronic book"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#EBook">http://tracker.api.gnome.org/ontology/v3/nfo#EBook</seealso>
    let EBook = Prefixed_Name(tnfo, "EBook") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:EmbeddedFileDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file embedded in another data object. There are many ways in which a file may be embedded in another one. Use this class directly only in cases if none of the subclasses gives a better description of your case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EmbeddedFileDataObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#EmbeddedFileDataObject">http://tracker.api.gnome.org/ontology/v3/nfo#EmbeddedFileDataObject</seealso>
    let EmbeddedFileDataObject =
        Prefixed_Name(tnfo, "EmbeddedFileDataObject") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The equipment used to create media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Equipment">http://tracker.api.gnome.org/ontology/v3/nfo#Equipment</seealso>
    let Equipment = Prefixed_Name(tnfo, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Executable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An executable file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Executable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Executable">http://tracker.api.gnome.org/ontology/v3/nfo#Executable</seealso>
    let Executable = Prefixed_Name(tnfo, "Executable") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:FileDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A resource containing a finite sequence of bytes with arbitrary information, that is available to a computer program and is usually based on some kind of durable storage. A file is durable in the sense that it remains available for programs to use after the current program has finished."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FileDataObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#FileDataObject">http://tracker.api.gnome.org/ontology/v3/nfo#FileDataObject</seealso>
    let FileDataObject = Prefixed_Name(tnfo, "FileDataObject") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:FileHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A fingerprint of the file, generated by some hashing function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FileHash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#FileHash">http://tracker.api.gnome.org/ontology/v3/nfo#FileHash</seealso>
    let FileHash = Prefixed_Name(tnfo, "FileHash") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Filesystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A filesystem. Examples of filesystems include hard disk partitions, removable media, but also images thereof stored in files."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Filesystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Filesystem">http://tracker.api.gnome.org/ontology/v3/nfo#Filesystem</seealso>
    let Filesystem = Prefixed_Name(tnfo, "Filesystem") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:FilesystemImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An image of a filesystem. Instances of this class may include CD images, DVD images or hard disk partition images created by various pieces of software (e.g. Norton Ghost)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FilesystemImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#FilesystemImage">http://tracker.api.gnome.org/ontology/v3/nfo#FilesystemImage</seealso>
    let FilesystemImage = Prefixed_Name(tnfo, "FilesystemImage") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Folder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A folder/directory. Examples of folders include folders on a filesystem and message folders in a mailbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Folder">http://tracker.api.gnome.org/ontology/v3/nfo#Folder</seealso>
    let Folder = Prefixed_Name(tnfo, "Folder") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Font</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A font."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Font">http://tracker.api.gnome.org/ontology/v3/nfo#Font</seealso>
    let Font = Prefixed_Name(tnfo, "Font") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:GameImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A game image. This is a Tracker extension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Game"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#GameImage">http://tracker.api.gnome.org/ontology/v3/nfo#GameImage</seealso>
    let GameImage = Prefixed_Name(tnfo, "GameImage") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:HardDiskPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A partition on a hard disk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardDiskPartition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#HardDiskPartition">http://tracker.api.gnome.org/ontology/v3/nfo#HardDiskPartition</seealso>
    let HardDiskPartition = Prefixed_Name(tnfo, "HardDiskPartition") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:HelpDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"User guides and similar to assist the user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Help document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#HelpDocument">http://tracker.api.gnome.org/ontology/v3/nfo#HelpDocument</seealso>
    let HelpDocument = Prefixed_Name(tnfo, "HelpDocument") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:HtmlDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A HTML document, may contain links to other files."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HtmlDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#HtmlDocument">http://tracker.api.gnome.org/ontology/v3/nfo#HtmlDocument</seealso>
    let HtmlDocument = Prefixed_Name(tnfo, "HtmlDocument") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Icon (regardless of whether it's a raster or a vector icon. A resource representing an icon could have two types (Icon and Raster, or Icon and Vector) if required."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Icon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Icon">http://tracker.api.gnome.org/ontology/v3/nfo#Icon</seealso>
    let Icon = Prefixed_Name(tnfo, "Icon") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file containing an image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Image">http://tracker.api.gnome.org/ontology/v3/nfo#Image</seealso>
    let Image = Prefixed_Name(tnfo, "Image") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:ImageCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A image category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#ImageCategory">http://tracker.api.gnome.org/ontology/v3/nfo#ImageCategory</seealso>
    let ImageCategory = Prefixed_Name(tnfo, "ImageCategory") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Media</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A piece of media content. This class may be used to express complex media containers with many streams of various media content (both aural and visual)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Media">http://tracker.api.gnome.org/ontology/v3/nfo#Media</seealso>
    let Media = Prefixed_Name(tnfo, "Media") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:MediaFileListEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A single node in the list of media files contained within an MediaList instance. This class is intended to provide a type all those links have. In valid NRL untyped resources cannot be linked. There are no properties defined for this class but the application may expect rdf:first and rdf:last links. The former points to the DataObject instance, interpreted as Media the latter points at another MediaFileListEntr. At the end of the list there is a link to rdf:nil."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MediaFileListEntry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaFileListEntry">http://tracker.api.gnome.org/ontology/v3/nfo#MediaFileListEntry</seealso>
    let MediaFileListEntry = Prefixed_Name(tnfo, "MediaFileListEntry") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:MediaList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file containing a list of media files.e.g. a playlist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MediaList"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaList">http://tracker.api.gnome.org/ontology/v3/nfo#MediaList</seealso>
    let MediaList = Prefixed_Name(tnfo, "MediaList") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:MediaStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A stream of multimedia content, usually contained within a media container such as a movie (containing both audio and video) or a DVD (possibly containing many streams of audio and video). Most common interpretations for such a DataObject include Audio and Video."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MediaStream"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#MediaStream">http://tracker.api.gnome.org/ontology/v3/nfo#MediaStream</seealso>
    let MediaStream = Prefixed_Name(tnfo, "MediaStream") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:MindMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A MindMap, created by a mind-mapping utility. Examples might include FreeMind or mind mapper."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MindMap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#MindMap">http://tracker.api.gnome.org/ontology/v3/nfo#MindMap</seealso>
    let MindMap = Prefixed_Name(tnfo, "MindMap") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Usually small document with snippets, reminders or frequenly used content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Note">http://tracker.api.gnome.org/ontology/v3/nfo#Note</seealso>
    let Note = Prefixed_Name(tnfo, "Note") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:OperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An OperatingSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OperatingSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#OperatingSystem">http://tracker.api.gnome.org/ontology/v3/nfo#OperatingSystem</seealso>
    let OperatingSystem = Prefixed_Name(tnfo, "OperatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Orientation enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orientation enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Orientation">http://tracker.api.gnome.org/ontology/v3/nfo#Orientation</seealso>
    let Orientation = Prefixed_Name(tnfo, "Orientation") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:PaginatedTextDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file containing a text document, that is unambiguously divided into pages. Examples might include PDF, DOC, PS', DVI etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PaginatedTextDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#PaginatedTextDocument">http://tracker.api.gnome.org/ontology/v3/nfo#PaginatedTextDocument</seealso>
    let PaginatedTextDocument =
        Prefixed_Name(tnfo, "PaginatedTextDocument") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:PlainTextDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file containing plain text (ASCII, Unicode or other encodings). Examples may include TXT, HTML, XML, program source code etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PlainTextDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#PlainTextDocument">http://tracker.api.gnome.org/ontology/v3/nfo#PlainTextDocument</seealso>
    let PlainTextDocument = Prefixed_Name(tnfo, "PlainTextDocument") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Presentation made by some presentation software (Corel Presentations, OpenOffice Impress, MS Powerpoint etc.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Presentation">http://tracker.api.gnome.org/ontology/v3/nfo#Presentation</seealso>
    let Presentation = Prefixed_Name(tnfo, "Presentation") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:RasterImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A raster image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RasterImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#RasterImage">http://tracker.api.gnome.org/ontology/v3/nfo#RasterImage</seealso>
    let RasterImage = Prefixed_Name(tnfo, "RasterImage") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:RegionOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Area on an image with relevant content. Following the spec in http://www.metadataworkinggroup.org"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of Interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterest">http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterest</seealso>
    let RegionOfInterest = Prefixed_Name(tnfo, "RegionOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Content in the area. There is a predefined set of contents in the spec: http://www.metadataworkinggroup.org"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterestContent">http://tracker.api.gnome.org/ontology/v3/nfo#RegionOfInterestContent</seealso>
    let RegionOfInterestContent =
        Prefixed_Name(tnfo, "RegionOfInterestContent") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:RemoteDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file data object stored at a remote location. Don't confuse this class with a RemotePortAddress. This one applies to a particular resource, RemotePortAddress applies to an address, that can have various interpretations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RemoteDataObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#RemoteDataObject">http://tracker.api.gnome.org/ontology/v3/nfo#RemoteDataObject</seealso>
    let RemoteDataObject = Prefixed_Name(tnfo, "RemoteDataObject") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:RemotePortAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An address specifying a remote host and port. Such an address can be interpreted in many ways (examples of such interpretations include mailboxes, websites, remote calendars or filesystems), depending on an interpretation, various kinds of data may be extracted from such an address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RemotePortAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#RemotePortAddress">http://tracker.api.gnome.org/ontology/v3/nfo#RemotePortAddress</seealso>
    let RemotePortAddress = Prefixed_Name(tnfo, "RemotePortAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A piece of software. Examples may include applications and the operating system. This interpretation most commonly applies to SoftwareItems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Software">http://tracker.api.gnome.org/ontology/v3/nfo#Software</seealso>
    let Software = Prefixed_Name(tnfo, "Software") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:SoftwareApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareApplication">http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareApplication</seealso>
    let SoftwareApplication = Prefixed_Name(tnfo, "SoftwareApplication") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:SoftwareCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A software category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareCategory">http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareCategory</seealso>
    let SoftwareCategory = Prefixed_Name(tnfo, "SoftwareCategory") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:SoftwareItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A DataObject representing a piece of software. Examples of interpretations of a SoftwareItem include an Application and an OperatingSystem."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftwareItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareItem">http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareItem</seealso>
    let SoftwareItem = Prefixed_Name(tnfo, "SoftwareItem") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:SoftwareService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A service published by a piece of software, either by an operating system or an application. Examples of such services may include calendar, addresbook and mailbox managed by a PIM application. This category is introduced to distinguish between data available directly from the applications (Via some Interprocess Communication Mechanisms) and data available from files on a disk. In either case both DataObjects would receive a similar interpretation (e.g. a Mailbox) and wouldn't differ on the content level."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftwareService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareService">http://tracker.api.gnome.org/ontology/v3/nfo#SoftwareService</seealso>
    let SoftwareService = Prefixed_Name(tnfo, "SoftwareService") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:SourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Code in a compilable or interpreted programming language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SourceCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#SourceCode">http://tracker.api.gnome.org/ontology/v3/nfo#SourceCode</seealso>
    let SourceCode = Prefixed_Name(tnfo, "SourceCode") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Spreadsheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A spreadsheet, created by a spreadsheet application. Examples might include Gnumeric, OpenOffice Calc or MS Excel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spreadsheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Spreadsheet">http://tracker.api.gnome.org/ontology/v3/nfo#Spreadsheet</seealso>
    let Spreadsheet = Prefixed_Name(tnfo, "Spreadsheet") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:TextDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A text document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TextDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#TextDocument">http://tracker.api.gnome.org/ontology/v3/nfo#TextDocument</seealso>
    let TextDocument = Prefixed_Name(tnfo, "TextDocument") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Trash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a container for deleted files, a feature common in modern operating systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Trash">http://tracker.api.gnome.org/ontology/v3/nfo#Trash</seealso>
    let Trash = Prefixed_Name(tnfo, "Trash") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:VectorImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A vector image (e.g. SVG)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VectorImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#VectorImage">http://tracker.api.gnome.org/ontology/v3/nfo#VectorImage</seealso>
    let VectorImage = Prefixed_Name(tnfo, "VectorImage") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A video file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Video">http://tracker.api.gnome.org/ontology/v3/nfo#Video</seealso>
    let Video = Prefixed_Name(tnfo, "Video") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Visual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"File containing visual content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Visual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Visual">http://tracker.api.gnome.org/ontology/v3/nfo#Visual</seealso>
    let Visual = Prefixed_Name(tnfo, "Visual") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:WebHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A web history entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web History"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#WebHistory">http://tracker.api.gnome.org/ontology/v3/nfo#WebHistory</seealso>
    let WebHistory = Prefixed_Name(tnfo, "WebHistory") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:Website</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A website, usually a container for remote resources, that may be interpreted as HTMLDocuments, images or other types of content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Website"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#Website">http://tracker.api.gnome.org/ontology/v3/nfo#Website</seealso>
    let Website = Prefixed_Name(tnfo, "Website") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:aspectRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Visual content aspect ratio. (Width divided by Height)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aspectRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#aspectRatio">http://tracker.api.gnome.org/ontology/v3/nfo#aspectRatio</seealso>
    let aspectRatio = Prefixed_Name(tnfo, "aspectRatio") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:audioOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the start offset of this resource within a larger file, such as a single song within a recording of a radio broadcast or a CD rip."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time offset within media container (seconds)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#audioOffset">http://tracker.api.gnome.org/ontology/v3/nfo#audioOffset</seealso>
    let audioOffset = Prefixed_Name(tnfo, "audioOffset") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:averageAudioBitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"averageBitrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#averageAudioBitrate">http://tracker.api.gnome.org/ontology/v3/nfo#averageAudioBitrate</seealso>
    let averageAudioBitrate = Prefixed_Name(tnfo, "averageAudioBitrate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:averageBitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"averageBitrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#averageBitrate">http://tracker.api.gnome.org/ontology/v3/nfo#averageBitrate</seealso>
    let averageBitrate = Prefixed_Name(tnfo, "averageBitrate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:averageVideoBitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The average overall bitrate of a media container. (i.e. the size of the piece of media in bits, divided by it's duration expressed in seconds)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"averageBitrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#averageVideoBitrate">http://tracker.api.gnome.org/ontology/v3/nfo#averageVideoBitrate</seealso>
    let averageVideoBitrate = Prefixed_Name(tnfo, "averageVideoBitrate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:belongsToContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Models the containment relations between Files and Folders (or CompressedFiles)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"belongsToContainer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#belongsToContainer">http://tracker.api.gnome.org/ontology/v3/nfo#belongsToContainer</seealso>
    let belongsToContainer = Prefixed_Name(tnfo, "belongsToContainer") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:bitDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A common superproperty for all properties signifying the amount of bits for an atomic unit of data. Examples of subproperties may include bitsPerSample and bitsPerPixel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bitDepth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#bitDepth">http://tracker.api.gnome.org/ontology/v3/nfo#bitDepth</seealso>
    let bitDepth = Prefixed_Name(tnfo, "bitDepth") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:bitrateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of the bitrate. Examples may include CBR and VBR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bitrateType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#bitrateType">http://tracker.api.gnome.org/ontology/v3/nfo#bitrateType</seealso>
    let bitrateType = Prefixed_Name(tnfo, "bitrateType") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:bitsPerSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount of bits in each audio sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bitsPerSample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#bitsPerSample">http://tracker.api.gnome.org/ontology/v3/nfo#bitsPerSample</seealso>
    let bitsPerSample = Prefixed_Name(tnfo, "bitsPerSample") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:bookmarks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The address of the linked object. Usually a web URL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#bookmarks">http://tracker.api.gnome.org/ontology/v3/nfo#bookmarks</seealso>
    let bookmarks = Prefixed_Name(tnfo, "bookmarks") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:channels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of channels. This property is to be used directly if no detailed information is necessary. Otherwise use more detailed subproperties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"channels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#channels">http://tracker.api.gnome.org/ontology/v3/nfo#channels</seealso>
    let channels = Prefixed_Name(tnfo, "channels") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:characterCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of characters in the document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characterCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#characterCount">http://tracker.api.gnome.org/ontology/v3/nfo#characterCount</seealso>
    let characterCount = Prefixed_Name(tnfo, "characterCount") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:characterPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Character position of the bookmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#characterPosition">http://tracker.api.gnome.org/ontology/v3/nfo#characterPosition</seealso>
    let characterPosition = Prefixed_Name(tnfo, "characterPosition") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:codec</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the codec necessary to decode a piece of media."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"codec"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#codec">http://tracker.api.gnome.org/ontology/v3/nfo#codec</seealso>
    let codec = Prefixed_Name(tnfo, "codec") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:colorDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount of bits used to express the color of each pixel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"colorDepth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#colorDepth">http://tracker.api.gnome.org/ontology/v3/nfo#colorDepth</seealso>
    let colorDepth = Prefixed_Name(tnfo, "colorDepth") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:commentCharacterCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of character in comments i.e. characters ignored by the compiler/interpreter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"commentCharacterCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#commentCharacterCount">http://tracker.api.gnome.org/ontology/v3/nfo#commentCharacterCount</seealso>
    let commentCharacterCount =
        Prefixed_Name(tnfo, "commentCharacterCount") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:compressionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of the compression. Values include, lossy and lossless."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"compressionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#compressionType">http://tracker.api.gnome.org/ontology/v3/nfo#compressionType</seealso>
    let compressionType = Prefixed_Name(tnfo, "compressionType") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:conflicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"States that a piece of software is in conflict with another piece of software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conflicts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#conflicts">http://tracker.api.gnome.org/ontology/v3/nfo#conflicts</seealso>
    let conflicts = Prefixed_Name(tnfo, "conflicts") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:containsBookmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The folder contains a bookmark."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains bookmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmark">http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmark</seealso>
    let containsBookmark = Prefixed_Name(tnfo, "containsBookmark") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:containsBookmarkFolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The folder contains a bookmark folder."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmarkFolder">http://tracker.api.gnome.org/ontology/v3/nfo#containsBookmarkFolder</seealso>
    let containsBookmarkFolder =
        Prefixed_Name(tnfo, "containsBookmarkFolder") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A common superproperty for all properties signifying the amount of atomic media data units. Examples of subproperties may include sampleCount and frameCount."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#count">http://tracker.api.gnome.org/ontology/v3/nfo#count</seealso>
    let count = Prefixed_Name(tnfo, "count") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:definesClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a class defined in the source code file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definesClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#definesClass">http://tracker.api.gnome.org/ontology/v3/nfo#definesClass</seealso>
    let definesClass = Prefixed_Name(tnfo, "definesClass") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:definesFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A name of a function/method defined in the given source code file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definesFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#definesFunction">http://tracker.api.gnome.org/ontology/v3/nfo#definesFunction</seealso>
    let definesFunction = Prefixed_Name(tnfo, "definesFunction") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:definesGlobalVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a global variable defined within the source code file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definesGlobalVariable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#definesGlobalVariable">http://tracker.api.gnome.org/ontology/v3/nfo#definesGlobalVariable</seealso>
    let definesGlobalVariable =
        Prefixed_Name(tnfo, "definesGlobalVariable") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:deletionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The date and time of the deletion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deletionDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#deletionDate">http://tracker.api.gnome.org/ontology/v3/nfo#deletionDate</seealso>
    let deletionDate = Prefixed_Name(tnfo, "deletionDate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates an information element to an image which depicts said element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#depiction">http://tracker.api.gnome.org/ontology/v3/nfo#depiction</seealso>
    let depiction = Prefixed_Name(tnfo, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    ///   <para>"Relates an image to the information elements it depicts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depicts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#depicts">http://tracker.api.gnome.org/ontology/v3/nfo#depicts</seealso>
    let depicts = Prefixed_Name(tnfo, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Domain for a web history entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#domain">http://tracker.api.gnome.org/ontology/v3/nfo#domain</seealso>
    let domain = Prefixed_Name(tnfo, "domain") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Duration of a media piece, measured in seconds."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#duration">http://tracker.api.gnome.org/ontology/v3/nfo#duration</seealso>
    let duration = Prefixed_Name(tnfo, "duration") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:encodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The contains the name of the person or organisation that encoded the media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"encodedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#encodedBy">http://tracker.api.gnome.org/ontology/v3/nfo#encodedBy</seealso>
    let encodedBy = Prefixed_Name(tnfo, "encodedBy") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The encoding used for the Embedded File. Examples might include BASE64 or UUEncode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"encoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#encoding">http://tracker.api.gnome.org/ontology/v3/nfo#encoding</seealso>
    let encoding = Prefixed_Name(tnfo, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:entryCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of entries in the list. Optimize some common queries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"entry Counter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#entryCounter">http://tracker.api.gnome.org/ontology/v3/nfo#entryCounter</seealso>
    let entryCounter = Prefixed_Name(tnfo, "entryCounter") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:entryUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URL to the element in certain position of the list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entry URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#entryUrl">http://tracker.api.gnome.org/ontology/v3/nfo#entryUrl</seealso>
    let entryUrl = Prefixed_Name(tnfo, "entryUrl") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Equipment used to create the media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#equipment">http://tracker.api.gnome.org/ontology/v3/nfo#equipment</seealso>
    let equipment = Prefixed_Name(tnfo, "equipment") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:equipmentSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The software of the equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equipment software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#equipmentSoftware">http://tracker.api.gnome.org/ontology/v3/nfo#equipmentSoftware</seealso>
    let equipmentSoftware = Prefixed_Name(tnfo, "equipmentSoftware") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"File creation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileCreated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileCreated">http://tracker.api.gnome.org/ontology/v3/nfo#fileCreated</seealso>
    let fileCreated = Prefixed_Name(tnfo, "fileCreated") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileLastAccessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Time when the file was last accessed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileLastAccessed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileLastAccessed">http://tracker.api.gnome.org/ontology/v3/nfo#fileLastAccessed</seealso>
    let fileLastAccessed = Prefixed_Name(tnfo, "fileLastAccessed") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileLastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"last modification date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileLastModified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileLastModified">http://tracker.api.gnome.org/ontology/v3/nfo#fileLastModified</seealso>
    let fileLastModified = Prefixed_Name(tnfo, "fileLastModified") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of the file, together with the extension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileName">http://tracker.api.gnome.org/ontology/v3/nfo#fileName</seealso>
    let fileName = Prefixed_Name(tnfo, "fileName") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The owner of the file as defined by the file system access rights feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileOwner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileOwner">http://tracker.api.gnome.org/ontology/v3/nfo#fileOwner</seealso>
    let fileOwner = Prefixed_Name(tnfo, "fileOwner") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The size of the file in bytes. For compressed files it means the size of the packed file, not of the contents. For folders it means the aggregated size of all contained files and folders"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fileSize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fileSize">http://tracker.api.gnome.org/ontology/v3/nfo#fileSize</seealso>
    let fileSize = Prefixed_Name(tnfo, "fileSize") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:fontFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the font family."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fontFamily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#fontFamily">http://tracker.api.gnome.org/ontology/v3/nfo#fontFamily</seealso>
    let fontFamily = Prefixed_Name(tnfo, "fontFamily") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:foundry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The foundry, the organization that created the font."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"foundry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#foundry">http://tracker.api.gnome.org/ontology/v3/nfo#foundry</seealso>
    let foundry = Prefixed_Name(tnfo, "foundry") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:frameCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of frames in a video sequence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"frameCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#frameCount">http://tracker.api.gnome.org/ontology/v3/nfo#frameCount</seealso>
    let frameCount = Prefixed_Name(tnfo, "frameCount") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:frameRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount of video frames per second."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"frameRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#frameRate">http://tracker.api.gnome.org/ontology/v3/nfo#frameRate</seealso>
    let frameRate = Prefixed_Name(tnfo, "frameRate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:frontChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of front channels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"frontChannels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#frontChannels">http://tracker.api.gnome.org/ontology/v3/nfo#frontChannels</seealso>
    let frontChannels = Prefixed_Name(tnfo, "frontChannels") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:gain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Gain of media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#gain">http://tracker.api.gnome.org/ontology/v3/nfo#gain</seealso>
    let gain = Prefixed_Name(tnfo, "gain") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Genre of media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Genre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#genre">http://tracker.api.gnome.org/ontology/v3/nfo#genre</seealso>
    let genre = Prefixed_Name(tnfo, "genre") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:hasHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links the file with it's hash value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasHash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hasHash">http://tracker.api.gnome.org/ontology/v3/nfo#hasHash</seealso>
    let hasHash = Prefixed_Name(tnfo, "hasHash") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:hasMediaFileListEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is intended to point to an RDF list of MediaFiles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMediaFileListEntry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaFileListEntry">http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaFileListEntry</seealso>
    let hasMediaFileListEntry =
        Prefixed_Name(tnfo, "hasMediaFileListEntry") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:hasMediaStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Connects a media container with a single media stream contained within."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMediaStream"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaStream">http://tracker.api.gnome.org/ontology/v3/nfo#hasMediaStream</seealso>
    let hasMediaStream = Prefixed_Name(tnfo, "hasMediaStream") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:hasRegionOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link an element with a defined region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has region or interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hasRegionOfInterest">http://tracker.api.gnome.org/ontology/v3/nfo#hasRegionOfInterest</seealso>
    let hasRegionOfInterest = Prefixed_Name(tnfo, "hasRegionOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:hashAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of the algorithm used to compute the hash value. Examples might include CRC32, MD5, SHA, TTH etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hashAlgorithm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hashAlgorithm">http://tracker.api.gnome.org/ontology/v3/nfo#hashAlgorithm</seealso>
    let hashAlgorithm = Prefixed_Name(tnfo, "hashAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:hashValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The actual value of the hash."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hashValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#hashValue">http://tracker.api.gnome.org/ontology/v3/nfo#hashValue</seealso>
    let hashValue = Prefixed_Name(tnfo, "hashValue") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:heading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the direction of travelling while capturing image/video. The range of values from 0.00 to 359.99 (where 0 is due North, 90 is East, 180 South and 270 is West)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#heading">http://tracker.api.gnome.org/ontology/v3/nfo#heading</seealso>
    let heading = Prefixed_Name(tnfo, "heading") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Visual content height in pixels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"height"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#height">http://tracker.api.gnome.org/ontology/v3/nfo#height</seealso>
    let height = Prefixed_Name(tnfo, "height") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:horizontalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Horizontal resolution of an image (if printed). Expressed in DPI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"horizontalResolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#horizontalResolution">http://tracker.api.gnome.org/ontology/v3/nfo#horizontalResolution</seealso>
    let horizontalResolution =
        Prefixed_Name(tnfo, "horizontalResolution") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:image-category-screenshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:ImageCategory</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#image-category-screenshot">http://tracker.api.gnome.org/ontology/v3/nfo#image-category-screenshot</seealso>
    let image_category_screenshot =
        Prefixed_Name(tnfo, "image-category-screenshot") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:interlaceMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"True if the image is interlaced, false if not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interlaceMode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#interlaceMode">http://tracker.api.gnome.org/ontology/v3/nfo#interlaceMode</seealso>
    let interlaceMode = Prefixed_Name(tnfo, "interlaceMode") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:isBootable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"True when the file is bootable, for example like an ISO or other disc images"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is content bootable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#isBootable">http://tracker.api.gnome.org/ontology/v3/nfo#isBootable</seealso>
    let isBootable = Prefixed_Name(tnfo, "isBootable") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:isContentEncrypted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Might change (IE of DataObject property?)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is content encrypted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#isContentEncrypted">http://tracker.api.gnome.org/ontology/v3/nfo#isContentEncrypted</seealso>
    let isContentEncrypted = Prefixed_Name(tnfo, "isContentEncrypted") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:isPasswordProtected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"States if a given resource is password-protected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPasswordProtected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#isPasswordProtected">http://tracker.api.gnome.org/ontology/v3/nfo#isPasswordProtected</seealso>
    let isPasswordProtected = Prefixed_Name(tnfo, "isPasswordProtected") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:lastPlayedPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Position in the media (in seconds) where the play was paused. Positive number, being 0 the beginning of the media."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"last played position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#lastPlayedPosition">http://tracker.api.gnome.org/ontology/v3/nfo#lastPlayedPosition</seealso>
    let lastPlayedPosition = Prefixed_Name(tnfo, "lastPlayedPosition") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:lfeChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of Low Frequency Expansion (subwoofer) channels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lfeChannels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#lfeChannels">http://tracker.api.gnome.org/ontology/v3/nfo#lfeChannels</seealso>
    let lfeChannels = Prefixed_Name(tnfo, "lfeChannels") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:lineCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of lines in a text document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#lineCount">http://tracker.api.gnome.org/ontology/v3/nfo#lineCount</seealso>
    let lineCount = Prefixed_Name(tnfo, "lineCount") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:listDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Sum of the duration of all items in the list. Optimize some common queries. In seconds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"List duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#listDuration">http://tracker.api.gnome.org/ontology/v3/nfo#listDuration</seealso>
    let listDuration = Prefixed_Name(tnfo, "listDuration") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:listPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Position of an entry in a list. Double, to optimize the poor insertions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"list position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#listPosition">http://tracker.api.gnome.org/ontology/v3/nfo#listPosition</seealso>
    let listPosition = Prefixed_Name(tnfo, "listPosition") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The manufacturer of the equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Manufacturer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#manufacturer">http://tracker.api.gnome.org/ontology/v3/nfo#manufacturer</seealso>
    let manufacturer = Prefixed_Name(tnfo, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:mediaListEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A certain item belongs to a media list. This can reflect that a song is in a playlist, an image or video in an Album"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media list entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#mediaListEntry">http://tracker.api.gnome.org/ontology/v3/nfo#mediaListEntry</seealso>
    let mediaListEntry = Prefixed_Name(tnfo, "mediaListEntry") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The model of the equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#model">http://tracker.api.gnome.org/ontology/v3/nfo#model</seealso>
    let model = Prefixed_Name(tnfo, "model") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation">http://tracker.api.gnome.org/ontology/v3/nfo#orientation</seealso>
    let orientation = Prefixed_Name(tnfo, "orientation") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:orientation-bottom</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom</seealso>
    let orientation_bottom = Prefixed_Name(tnfo, "orientation-bottom") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-bottom-mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom-mirror">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-bottom-mirror</seealso>
    let orientation_bottom_mirror =
        Prefixed_Name(tnfo, "orientation-bottom-mirror") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-left</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left</seealso>
    let orientation_left = Prefixed_Name(tnfo, "orientation-left") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-left-mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left-mirror">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-left-mirror</seealso>
    let orientation_left_mirror =
        Prefixed_Name(tnfo, "orientation-left-mirror") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-right</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right</seealso>
    let orientation_right = Prefixed_Name(tnfo, "orientation-right") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-right-mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right-mirror">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-right-mirror</seealso>
    let orientation_right_mirror =
        Prefixed_Name(tnfo, "orientation-right-mirror") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-top</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top</seealso>
    let orientation_top = Prefixed_Name(tnfo, "orientation-top") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:orientation-top-mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:Orientation</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top-mirror">http://tracker.api.gnome.org/ontology/v3/nfo#orientation-top-mirror</seealso>
    let orientation_top_mirror =
        Prefixed_Name(tnfo, "orientation-top-mirror") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:originalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The original location of the deleted resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"originalLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#originalLocation">http://tracker.api.gnome.org/ontology/v3/nfo#originalLocation</seealso>
    let originalLocation = Prefixed_Name(tnfo, "originalLocation") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:pageCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of pages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pageCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#pageCount">http://tracker.api.gnome.org/ontology/v3/nfo#pageCount</seealso>
    let pageCount = Prefixed_Name(tnfo, "pageCount") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:pageNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Page linked by the bookmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Page number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#pageNumber">http://tracker.api.gnome.org/ontology/v3/nfo#pageNumber</seealso>
    let pageNumber = Prefixed_Name(tnfo, "pageNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:peakGain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Peak Gain of media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Peak Gain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#peakGain">http://tracker.api.gnome.org/ontology/v3/nfo#peakGain</seealso>
    let peakGain = Prefixed_Name(tnfo, "peakGain") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:permissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A string containing the permissions of a file. A feature common in many UNIX-like operating systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"permissions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#permissions">http://tracker.api.gnome.org/ontology/v3/nfo#permissions</seealso>
    let permissions = Prefixed_Name(tnfo, "permissions") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:programmingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the name of the programming language this source code file is written in. Examples might include 'C', 'C++', 'Java' etc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"programmingLanguage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#programmingLanguage">http://tracker.api.gnome.org/ontology/v3/nfo#programmingLanguage</seealso>
    let programmingLanguage = Prefixed_Name(tnfo, "programmingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:rearChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of rear channels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rearChannels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#rearChannels">http://tracker.api.gnome.org/ontology/v3/nfo#rearChannels</seealso>
    let rearChannels = Prefixed_Name(tnfo, "rearChannels") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:regionOfInterestHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Height of the region. It is normalized (values between 0 and 1) to the total height of the picture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest height"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestHeight">http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestHeight</seealso>
    let regionOfInterestHeight =
        Prefixed_Name(tnfo, "regionOfInterestHeight") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:regionOfInterestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The content of a region can be one of the predefined types in the spec"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestType">http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestType</seealso>
    let regionOfInterestType =
        Prefixed_Name(tnfo, "regionOfInterestType") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:regionOfInterestWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Width of the region. It is normalized (values between 0 and 1) to the total width of the picture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest width"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestWidth">http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestWidth</seealso>
    let regionOfInterestWidth =
        Prefixed_Name(tnfo, "regionOfInterestWidth") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:regionOfInterestX</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Coordinate X where the region starts. It is normalized (values between 0 and 1) to the width of the picture. Starting in the upper left corner."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest X"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestX">http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestX</seealso>
    let regionOfInterestX = Prefixed_Name(tnfo, "regionOfInterestX") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:regionOfInterestY</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Coordinate y where the region starts. It is normalized (values between 0 and 1) to the height of the picture. Starting in the upper left corner."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest Y"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestY">http://tracker.api.gnome.org/ontology/v3/nfo#regionOfInterestY</seealso>
    let regionOfInterestY = Prefixed_Name(tnfo, "regionOfInterestY") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:roi-content-barcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-barcode">http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-barcode</seealso>
    let roi_content_barcode = Prefixed_Name(tnfo, "roi-content-barcode") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:roi-content-face</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-face">http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-face</seealso>
    let roi_content_face = Prefixed_Name(tnfo, "roi-content-face") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:roi-content-focus</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-focus">http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-focus</seealso>
    let roi_content_focus = Prefixed_Name(tnfo, "roi-content-focus") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:roi-content-pet</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-pet">http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-pet</seealso>
    let roi_content_pet = Prefixed_Name(tnfo, "roi-content-pet") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:roi-content-undefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnfo:RegionOfInterestContent</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-undefined">http://tracker.api.gnome.org/ontology/v3/nfo#roi-content-undefined</seealso>
    let roi_content_undefined =
        Prefixed_Name(tnfo, "roi-content-undefined") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:roiRefersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to an item that is represented in the region. The 'type' of the region can give a clue of what exact content is linked in this property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region of interest refers to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#roiRefersTo">http://tracker.api.gnome.org/ontology/v3/nfo#roiRefersTo</seealso>
    let roiRefersTo = Prefixed_Name(tnfo, "roiRefersTo") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:sampleCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of samples in an audio clip."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sampleCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#sampleCount">http://tracker.api.gnome.org/ontology/v3/nfo#sampleCount</seealso>
    let sampleCount = Prefixed_Name(tnfo, "sampleCount") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:sampleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of audio samples per second."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sampleRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#sampleRate">http://tracker.api.gnome.org/ontology/v3/nfo#sampleRate</seealso>
    let sampleRate = Prefixed_Name(tnfo, "sampleRate") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:sideChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Number of side channels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sideChannels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#sideChannels">http://tracker.api.gnome.org/ontology/v3/nfo#sideChannels</seealso>
    let sideChannels = Prefixed_Name(tnfo, "sideChannels") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:softwareCategoryIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Icon of the software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftwareIcon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareCategoryIcon">http://tracker.api.gnome.org/ontology/v3/nfo#softwareCategoryIcon</seealso>
    let softwareCategoryIcon =
        Prefixed_Name(tnfo, "softwareCategoryIcon") |> PrefixedName

    /// <summary>
    ///   <para>tnfo:softwareCmdLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Command to launch the software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftwareCmdLine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareCmdLine">http://tracker.api.gnome.org/ontology/v3/nfo#softwareCmdLine</seealso>
    let softwareCmdLine = Prefixed_Name(tnfo, "softwareCmdLine") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:softwareIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Icon of the software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftwareIcon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#softwareIcon">http://tracker.api.gnome.org/ontology/v3/nfo#softwareIcon</seealso>
    let softwareIcon = Prefixed_Name(tnfo, "softwareIcon") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:streamDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stream duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#streamDuration">http://tracker.api.gnome.org/ontology/v3/nfo#streamDuration</seealso>
    let streamDuration = Prefixed_Name(tnfo, "streamDuration") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:streamPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Stream position of the bookmark, suitable for e.g. audio books. Expressed in milliseconds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stream position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#streamPosition">http://tracker.api.gnome.org/ontology/v3/nfo#streamPosition</seealso>
    let streamPosition = Prefixed_Name(tnfo, "streamPosition") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:supercedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"States that a piece of software supercedes another piece of software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"supercedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#supercedes">http://tracker.api.gnome.org/ontology/v3/nfo#supercedes</seealso>
    let supercedes = Prefixed_Name(tnfo, "supercedes") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:tableOfContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Section titles and figure descriptions of the document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Table of contents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#tableOfContents">http://tracker.api.gnome.org/ontology/v3/nfo#tableOfContents</seealso>
    let tableOfContents = Prefixed_Name(tnfo, "tableOfContents") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:tilt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Vertical inclination of the camera while capturing the image, in angles starting on 0 as horizontal, positive numbers pointing up, negative angles pointing down"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tilt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#tilt">http://tracker.api.gnome.org/ontology/v3/nfo#tilt</seealso>
    let tilt = Prefixed_Name(tnfo, "tilt") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:uncompressedSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Uncompressed size of the content of a compressed file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uncompressedSize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#uncompressedSize">http://tracker.api.gnome.org/ontology/v3/nfo#uncompressedSize</seealso>
    let uncompressedSize = Prefixed_Name(tnfo, "uncompressedSize") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Uri for a web history entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#uri">http://tracker.api.gnome.org/ontology/v3/nfo#uri</seealso>
    let uri = Prefixed_Name(tnfo, "uri") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:verticalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Vertical resolution of an Image (if printed). Expressed in DPI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"verticalResolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#verticalResolution">http://tracker.api.gnome.org/ontology/v3/nfo#verticalResolution</seealso>
    let verticalResolution = Prefixed_Name(tnfo, "verticalResolution") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Visual content width in pixels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"width"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#width">http://tracker.api.gnome.org/ontology/v3/nfo#width</seealso>
    let width = Prefixed_Name(tnfo, "width") |> PrefixedName
    /// <summary>
    ///   <para>tnfo:wordCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The amount of words in a text document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wordCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nfo#wordCount">http://tracker.api.gnome.org/ontology/v3/nfo#wordCount</seealso>
    let wordCount = Prefixed_Name(tnfo, "wordCount") |> PrefixedName
