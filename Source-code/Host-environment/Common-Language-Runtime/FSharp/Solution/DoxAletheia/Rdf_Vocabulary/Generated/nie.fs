namespace http.www.semanticdesktop.org.ontologies._2007._01._19.nie.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nie =
    let _namespace_iri = Namespace_Iri nie |> NamespaceIRI
    /// <summary>
    ///   <para>nie:sourceMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a number of applicable modes for a data source.</para>
    /// labels<para>Data Source Mode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#sourceMode">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#sourceMode</seealso>
    let sourceMode = Prefixed_Name(nie, "sourceMode") |> PrefixedName
    /// <summary>
    ///   <para>nie:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An overall topic of the content of a InformationElement</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#subject">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#subject</seealso>
    let subject = Prefixed_Name(nie, "subject") |> PrefixedName
    /// <summary>
    ///   <para>nie:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name given to an InformationElement</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#title">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#title</seealso>
    let title = Prefixed_Name(nie, "title") |> PrefixedName
    /// <summary>
    ///   <para>nie:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:DefiningProperty</para>
    ///   <para>URL of a DataObject. It points to the location of the object. A typial usage is FileDataObject. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.</para>
    /// labels<para>url</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#url">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#url</seealso>
    let url = Prefixed_Name(nie, "url") |> PrefixedName
    /// <summary>
    ///   <para>nie:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current version of the given data object. Exact semantics is unspecified at this level. Use more specific subproperties if needed.</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#version">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#version</seealso>
    let version = Prefixed_Name(nie, "version") |> PrefixedName
    /// <summary>
    ///   <para>nie:DataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A superclass for all entities from which DataObjects can be extracted. Each entity represents a native application or some other system that manages information that may be of interest to the user of the Semantic Desktop. Subclasses may include FileSystems, Mailboxes, Calendars, websites etc. The exact choice of subclasses and their properties is considered application-specific. Each data extraction application is supposed to provide it's own DataSource ontology. Such an ontology should contain supported data source types coupled with properties necessary for the application to gain access to the data sources.  (paths, urls, passwords  etc...)</para>
    /// labels<para>DataSource</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSource">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSource</seealso>
    let DataSource = Prefixed_Name(nie, "DataSource") |> PrefixedName
    /// <summary>
    ///   <para>nie:DataSourceGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Represents the sum of all information that has been obtained from a data source. Each data source has its own personal information graph. When a data source is deleted, the graph becomes redundant and should also be deleted. If two or more items in two or more data source graphs are determined to be equivalent, they are integrated at the PIMO level, and the integrated representation plus the links to the original items are stored in the pimo:PersonalInformationModel graph.</para>
    /// labels<para>Data Source Graph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSourceGraph">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSourceGraph</seealso>
    let DataSourceGraph = Prefixed_Name(nie, "DataSourceGraph") |> PrefixedName
    /// <summary>
    ///   <para>nie:InformationElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unit of content the user works with. This is a superclass for all interpretations of a DataObject.</para>
    /// labels<para>InformationElement</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#InformationElement">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#InformationElement</seealso>
    let InformationElement = Prefixed_Name(nie, "InformationElement") |> PrefixedName
    /// <summary>
    ///   <para>nie:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The overall size of the data object in bytes. That means the space taken by the DataObject in its container, and not the size of the content that is of interest to the user. For cases where the content size is different (e.g. in compressed files the content is larger, in messages the content excludes headings and is smaller) use more specific properties, not necessarily subproperties of this one.</para>
    /// labels<para>byteSize</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#byteSize">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#byteSize</seealso>
    let byteSize = Prefixed_Name(nie, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>nie:Mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Representation for a standard set of device/application/service modes, corresponding to various sets of modes that are either inbuilt in a device (e.g. inbuilt phone modes such as silent, loud, general, vibrate, etc.) or available for applications and online services (e.g. IM system modes such as busy, available, invisible, etc.)</para>
    /// labels<para>Mode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#Mode">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#Mode</seealso>
    let Mode = Prefixed_Name(nie, "Mode") |> PrefixedName
    /// <summary>
    ///   <para>nie:characterSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Characterset in which the content of the InformationElement was created. Example: ISO-8859-1, UTF-8. One of the registered character sets at http://www.iana.org/assignments/character-sets. This characterSet is used to interpret any textual parts of the content. If more than one characterSet is used within one data object, use more specific properties.</para>
    /// labels<para>characterSet</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#characterSet">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#characterSet</seealso>
    let characterSet = Prefixed_Name(nie, "characterSet") |> PrefixedName
    /// <summary>
    ///   <para>nie:contentCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of the content creation. This may not necessarily be equal to the date when the DataObject (i.e. the physical representation) itself was created. Compare with nie:created property.</para>
    /// labels<para>contentCreated</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentCreated">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentCreated</seealso>
    let contentCreated = Prefixed_Name(nie, "contentCreated") |> PrefixedName

    /// <summary>
    ///   <para>nie:informationElementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A point or period of time associated with an event in the lifecycle of an Information Element. A common superproperty for all date-related properties of InformationElements in the NIE Framework.</para>
    /// labels<para>informationElementDate</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#informationElementDate">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#informationElementDate</seealso>
    let informationElementDate =
        Prefixed_Name(nie, "informationElementDate") |> PrefixedName

    /// <summary>
    ///   <para>nie:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date the DataObject was changed in any way.  Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentModified.</para>
    /// labels<para>modified</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#modified">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#modified</seealso>
    let modified = Prefixed_Name(nie, "modified") |> PrefixedName
    /// <summary>
    ///   <para>nie:depends</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Dependency relation. A piece of content depends on another piece of data in order to be properly understood/used/interpreted.</para>
    /// labels<para>depends</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#depends">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#depends</seealso>
    let depends = Prefixed_Name(nie, "depends") |> PrefixedName
    /// <summary>
    ///   <para>nie:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all relations between a piece of content and other pieces of data (which may be interpreted as other pieces of content).</para>
    /// labels<para>relatedTo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#relatedTo">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#relatedTo</seealso>
    let relatedTo = Prefixed_Name(nie, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>nie:disclaimer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A disclaimer</para>
    /// labels<para>disclaimer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#disclaimer">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#disclaimer</seealso>
    let disclaimer = Prefixed_Name(nie, "disclaimer") |> PrefixedName
    /// <summary>
    ///   <para>nie:mimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The mime type of the resource, if available. Example: "text/plain". See http://www.iana.org/assignments/media-types/. This property applies to data objects that can be described with one mime type. In cases where the object as a whole has one mime type, while it's parts have other mime types, or there is no mime type that can be applied to the object as a whole, but some parts of the content have mime types - use more specific properties.</para>
    /// labels<para>mimeType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#mimeType">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#mimeType</seealso>
    let mimeType = Prefixed_Name(nie, "mimeType") |> PrefixedName
    /// <summary>
    ///   <para>nie:plainTextContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Plain-text representation of the content of a InformationElement with all markup removed. The main purpose of this property is full-text indexing and search. Its exact content is considered application-specific. The user can make no assumptions about what is and what is not contained within. Applications should use more specific properties wherever possible.</para>
    /// labels<para>plainTextContent</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#plainTextContent">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#plainTextContent</seealso>
    let plainTextContent = Prefixed_Name(nie, "plainTextContent") |> PrefixedName
    /// <summary>
    ///   <para>nie:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A user comment about an InformationElement.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#comment">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#comment</seealso>
    let comment = Prefixed_Name(nie, "comment") |> PrefixedName
    /// <summary>
    ///   <para>nie:contentModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of a modification of the original content (not its corresponding DataObject or local copy). Compare with nie:modified.</para>
    /// labels<para>modified</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentModified">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentModified</seealso>
    let contentModified = Prefixed_Name(nie, "contentModified") |> PrefixedName
    /// <summary>
    ///   <para>nie:contentLastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of the last modification of the original content (not its corresponding DataObject or local copy). Compare with nie:lastModified.</para>
    /// labels<para>contentLastModified</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentLastModified">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentLastModified</seealso>
    let contentLastModified = Prefixed_Name(nie, "contentLastModified") |> PrefixedName
    /// <summary>
    ///   <para>nie:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Content copyright</para>
    /// labels<para>copyright</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#copyright">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#copyright</seealso>
    let copyright = Prefixed_Name(nie, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>nie:contentSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the content. This property can be used whenever the size of the content of an InformationElement differs from the size of the DataObject. (e.g. because of compression, encoding, encryption or any other representation issues). The contentSize in expressed in bytes.</para>
    /// labels<para>contentSize</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentSize">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentSize</seealso>
    let contentSize = Prefixed_Name(nie, "contentSize") |> PrefixedName
    /// <summary>
    ///   <para>nie:legal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all properties that point at legal information about an Information Element</para>
    /// labels<para>legal</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#legal">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#legal</seealso>
    let legal = Prefixed_Name(nie, "legal") |> PrefixedName
    /// <summary>
    ///   <para>nie:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of creation of the DataObject. Note that this date refers to the creation of the DataObject itself (i.e. the physical representation). Compare with nie:contentCreated.</para>
    /// labels<para>created</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#created">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#created</seealso>
    let created = Prefixed_Name(nie, "created") |> PrefixedName
    /// <summary>
    ///   <para>nie:coreGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Connects the data object with the graph that contains information about it. Deprecated in favor of a more generic nao:isDataGraphFor.</para>
    /// labels<para>coreGraph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#coreGraph">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#coreGraph</seealso>
    let coreGraph = Prefixed_Name(nie, "coreGraph") |> PrefixedName
    /// <summary>
    ///   <para>nie:dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Marks the provenance of a DataObject, what source does a data object come from.</para>
    /// labels<para>dataSource</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#dataSource">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#dataSource</seealso>
    let dataSource = Prefixed_Name(nie, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>nie:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A textual description of the resource. This property may be used for any metadata fields that provide some meta-information or comment about a resource in the form of a passage of text. This property is not to be confused with nie:plainTextContent. Use more specific subproperties wherever possible.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#description">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#description</seealso>
    let description = Prefixed_Name(nie, "description") |> PrefixedName
    /// <summary>
    ///   <para>nie:generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Software used to "generate" the contents. E.g. a word processor name.</para>
    /// labels<para>generator</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generator">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generator</seealso>
    let generator = Prefixed_Name(nie, "generator") |> PrefixedName
    /// <summary>
    ///   <para>nie:hasLogicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'logical' containment relationships between InformationElements. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (hasPart) and logical containment (hasLogicalPart)</para>
    /// labels<para>hasLogicalPart</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasLogicalPart">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasLogicalPart</seealso>
    let hasLogicalPart = Prefixed_Name(nie, "hasLogicalPart") |> PrefixedName
    /// <summary>
    ///   <para>nie:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'physical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The hasPart relation models physical containment, an InformationElement (a nmo:Message) can have a 'physical' part (an nfo:Attachment).  Also, please note the difference between physical containment (hasPart) and logical containment (hasLogicalPart) the former has more strict meaning. They may occur independently of each other.</para>
    /// labels<para>hasPart</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasPart">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasPart</seealso>
    let hasPart = Prefixed_Name(nie, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>nie:generatorOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all settings used by the generating software. This may include compression settings, algorithms, autosave, interlaced/non-interlaced etc. Note that this property has no range specified and therefore should not be used directly. Always use more specific properties.</para>
    /// labels<para>generatorOption</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generatorOption">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generatorOption</seealso>
    let generatorOption = Prefixed_Name(nie, "generatorOption") |> PrefixedName
    /// <summary>
    ///   <para>nie:isLogicalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:DefiningProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'logical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (isPartOf) and logical containment (isLogicalPartOf)</para>
    /// labels<para>isLogicalPartOf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isLogicalPartOf">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isLogicalPartOf</seealso>
    let isLogicalPartOf = Prefixed_Name(nie, "isLogicalPartOf") |> PrefixedName
    /// <summary>
    ///   <para>nie:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:DefiningProperty</para>
    ///   <para>nrl:FunctionalProperty</para>
    ///   <para>Generic property used to express containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The isPartOf relation models physical containment, a nie:DataObject (e.g. an nfo:Attachment) is a 'physical' part of an nie:InformationElement (a nmo:Message). Also, please note the difference between physical containment (isPartOf) and logical containment (isLogicalPartOf) the former has more strict meaning. They may occur independently of each other.</para>
    /// labels<para>isPartOf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isPartOf">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isPartOf</seealso>
    let isPartOf = Prefixed_Name(nie, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>nie:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An unambiguous reference to the InformationElement within a given context. Recommended best practice is to identify the resource by means of a string conforming to a formal identification system.</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#identifier">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#identifier</seealso>
    let identifier = Prefixed_Name(nie, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>nie:interpretedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the DataObject with the InformationElement it is interpreted as.</para>
    /// labels<para>interpretedAs</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#interpretedAs">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#interpretedAs</seealso>
    let interpretedAs = Prefixed_Name(nie, "interpretedAs") |> PrefixedName
    /// <summary>
    ///   <para>nie:isStoredAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the information element with the DataObject it is stored in.</para>
    /// labels<para>isStoredAs</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isStoredAs">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isStoredAs</seealso>
    let isStoredAs = Prefixed_Name(nie, "isStoredAs") |> PrefixedName
    /// <summary>
    ///   <para>nie:htmlContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The HTML content of an information element. This property can be used to store text including formatting in a generic fashion.</para>
    /// labels<para>html content</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#htmlContent">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#htmlContent</seealso>
    let htmlContent = Prefixed_Name(nie, "htmlContent") |> PrefixedName
    /// <summary>
    ///   <para>nie:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Language the InformationElement is expressed in. This property applies to the data object in its entirety. If the data object is divisible into parts expressed in multiple languages - more specific properties should be used. Users are encouraged to use the two-letter code specified in the RFC 3066</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#language">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#language</seealso>
    let language = Prefixed_Name(nie, "language") |> PrefixedName
    /// <summary>
    ///   <para>nie:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Adapted DublinCore: The topic of the content of the resource, as keyword. No sentences here. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. </para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#keyword">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#keyword</seealso>
    let keyword = Prefixed_Name(nie, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>nie:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Terms and intellectual property rights licensing conditions.</para>
    /// labels<para>license</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#license">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#license</seealso>
    let license = Prefixed_Name(nie, "license") |> PrefixedName
    /// <summary>
    ///   <para>nie:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Last modification date of the DataObject. Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentLastModified.</para>
    /// labels<para>lastModified</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastModified">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastModified</seealso>
    let lastModified = Prefixed_Name(nie, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>nie:lastRefreshed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date when information about this data object was retrieved (for the first time) or last refreshed from the data source. This property is important for metadata extraction applications that don't receive any notifications of changes in the data source and have to poll it regularly. This may lead to information becoming out of date. In these cases this property may be used to determine the age of data, which is an important element of it's dependability. </para>
    /// labels<para>lastRefreshed</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastRefreshed">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastRefreshed</seealso>
    let lastRefreshed = Prefixed_Name(nie, "lastRefreshed") |> PrefixedName
    /// <summary>
    ///   <para>nie:links</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A linking relation. A piece of content links/mentions a piece of data</para>
    /// labels<para>links</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#links">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#links</seealso>
    let links = Prefixed_Name(nie, "links") |> PrefixedName
    /// <summary>
    ///   <para>nie:licenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of the license. Possible values for this field may include "GPL", "BSD", "Creative Commons" etc.</para>
    /// labels<para>licenseType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#licenseType">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#licenseType</seealso>
    let licenseType = Prefixed_Name(nie, "licenseType") |> PrefixedName
    /// <summary>
    ///   <para>nie:rootElementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>DataObjects extracted from a single data source are organized into a containment tree. This property links the root of that tree with the datasource it has been extracted from</para>
    /// labels<para>rootElementOf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#rootElementOf">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#rootElementOf</seealso>
    let rootElementOf = Prefixed_Name(nie, "rootElementOf") |> PrefixedName
    /// <summary>
    ///   <para>nie:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unit of data that is created, annotated and processed on the user desktop. It represents a native structure the user works with. The usage of the term 'native' is important. It means that a DataObject can be directly mapped to a data structure maintained by a native application. This may be a file, a set of files or a part of a file. The granularity depends on the user. This class is not intended to be instantiated by itself. Use more specific subclasses.</para>
    /// labels<para>DataObject</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataObject">http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataObject</seealso>
    let DataObject = Prefixed_Name(nie, "DataObject") |> PrefixedName
