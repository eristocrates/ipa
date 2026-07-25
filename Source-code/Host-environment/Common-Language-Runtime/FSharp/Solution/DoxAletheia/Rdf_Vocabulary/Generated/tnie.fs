namespace http.tracker.api.gnome.org.ontology.v3.nie.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnie =
    let _namespace_iri = Namespace_Iri tnie |> NamespaceIRI
    /// <summary>
    ///   <para>tnie:InformationElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unit of content the user works with. This is a superclass for all interpretations of a DataObject.</para>
    /// labels<para>Information Element</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#InformationElement">http://tracker.api.gnome.org/ontology/v3/nie#InformationElement</seealso>
    let InformationElement = Prefixed_Name(tnie, "InformationElement") |> PrefixedName
    /// <summary>
    ///   <para>tnie:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A user comment about an InformationElement</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#comment">http://tracker.api.gnome.org/ontology/v3/nie#comment</seealso>
    let comment = Prefixed_Name(tnie, "comment") |> PrefixedName

    /// <summary>
    ///   <para>tnie:informationElementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A point or period of time associated with an event in the lifecycle of an Information Element. A common superproperty for all date-related properties of InformationElements in the NIE Framework</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#informationElementDate">http://tracker.api.gnome.org/ontology/v3/nie#informationElementDate</seealso>
    let informationElementDate =
        Prefixed_Name(tnie, "informationElementDate") |> PrefixedName

    /// <summary>
    ///   <para>tnie:contentLastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of the last modification of the original content (not its corresponding DataObject or local copy). Compare with nie:lastModified</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#contentLastModified">http://tracker.api.gnome.org/ontology/v3/nie#contentLastModified</seealso>
    let contentLastModified = Prefixed_Name(tnie, "contentLastModified") |> PrefixedName
    /// <summary>
    ///   <para>tnie:contentSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the content. This property can be used whenever the size of the content of an InformationElement differs from the size of the DataObject. (e.g. because of compression, encoding, encryption or any other representation issues). The contentSize in expressed in bytes</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#contentSize">http://tracker.api.gnome.org/ontology/v3/nie#contentSize</seealso>
    let contentSize = Prefixed_Name(tnie, "contentSize") |> PrefixedName
    /// <summary>
    ///   <para>tnie:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all relations between a piece of content and other pieces of data (which may be interpreted as other pieces of content).</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#relatedTo">http://tracker.api.gnome.org/ontology/v3/nie#relatedTo</seealso>
    let relatedTo = Prefixed_Name(tnie, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>tnie:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A textual description of the resource. This property may be used for any metadata fields that provide some meta-information or comment about a resource in the form of a passage of text. This property is not to be confused with nie:plainTextContent. Use more specific subproperties wherever possible</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#description">http://tracker.api.gnome.org/ontology/v3/nie#description</seealso>
    let description = Prefixed_Name(tnie, "description") |> PrefixedName
    /// <summary>
    ///   <para>tnie:generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Software used to 'generate' the contents. E.g. a word processor name</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#generator">http://tracker.api.gnome.org/ontology/v3/nie#generator</seealso>
    let generator = Prefixed_Name(tnie, "generator") |> PrefixedName
    /// <summary>
    ///   <para>tnie:hasLogicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'logical' containment relationships between InformationElements. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (hasPart) and logical containment (hasLogicalPart)</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#hasLogicalPart">http://tracker.api.gnome.org/ontology/v3/nie#hasLogicalPart</seealso>
    let hasLogicalPart = Prefixed_Name(tnie, "hasLogicalPart") |> PrefixedName
    /// <summary>
    ///   <para>tnie:interpretedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the DataObject with the InformationElement it is interpreted as</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#interpretedAs">http://tracker.api.gnome.org/ontology/v3/nie#interpretedAs</seealso>
    let interpretedAs = Prefixed_Name(tnie, "interpretedAs") |> PrefixedName
    /// <summary>
    ///   <para>tnie:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The isPartOf relation models physical containment, a nie:DataObject (e.g. an nfo:Attachment) is a 'physical' part of an nie:InformationElement (a nmo:Message). Also, please note the difference between physical containment (isPartOf) and logical containment (isLogicalPartOf) the former has more strict meaning. They may occur independently of each other</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#isPartOf">http://tracker.api.gnome.org/ontology/v3/nie#isPartOf</seealso>
    let isPartOf = Prefixed_Name(tnie, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>tnie:isStoredAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the information element with the DataObject it is stored in</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#isStoredAs">http://tracker.api.gnome.org/ontology/v3/nie#isStoredAs</seealso>
    let isStoredAs = Prefixed_Name(tnie, "isStoredAs") |> PrefixedName
    /// <summary>
    ///   <para>tnie:lastRefreshed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date when information about this data object was retrieved (for the first time) or last refreshed from the data source. This property is important for metadata extraction applications that don't receive any notifications of changes in the data source and have to poll it regularly. This may lead to information becoming out of date. In these cases this property may be used to determine the age of data, which is an important element of it's dependability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#lastRefreshed">http://tracker.api.gnome.org/ontology/v3/nie#lastRefreshed</seealso>
    let lastRefreshed = Prefixed_Name(tnie, "lastRefreshed") |> PrefixedName
    /// <summary>
    ///   <para>tnie:links</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A linking relation. A piece of content links/mentions a piece of data</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#links">http://tracker.api.gnome.org/ontology/v3/nie#links</seealso>
    let links = Prefixed_Name(tnie, "links") |> PrefixedName
    /// <summary>
    ///   <para>tnie:mimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>File Mime Type</para>
    /// labels<para>Mime Type</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#mimeType">http://tracker.api.gnome.org/ontology/v3/nie#mimeType</seealso>
    let mimeType = Prefixed_Name(tnie, "mimeType") |> PrefixedName
    /// <summary>
    ///   <para>tnie:rootElementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>DataObjects extracted from a single data source are organized into a containment tree. This property links the root of that tree with the datasource it has been extracted from</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#rootElementOf">http://tracker.api.gnome.org/ontology/v3/nie#rootElementOf</seealso>
    let rootElementOf = Prefixed_Name(tnie, "rootElementOf") |> PrefixedName
    /// <summary>
    ///   <para>tnie:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>URL pointing at the location of the resource. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.</para>
    /// labels<para>URL</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#url">http://tracker.api.gnome.org/ontology/v3/nie#url</seealso>
    let url = Prefixed_Name(tnie, "url") |> PrefixedName
    /// <summary>
    ///   <para>tnie:usageCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#usageCounter">http://tracker.api.gnome.org/ontology/v3/nie#usageCounter</seealso>
    let usageCounter = Prefixed_Name(tnie, "usageCounter") |> PrefixedName
    /// <summary>
    ///   <para>tnie:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current version of the given data object. Exact semantics is unspecified at this level. Use more specific subproperties if needed</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#version">http://tracker.api.gnome.org/ontology/v3/nie#version</seealso>
    let version = Prefixed_Name(tnie, "version") |> PrefixedName
    /// <summary>
    ///   <para>tnie:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Namespace</para>
    ///   <para>tnrl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#">http://tracker.api.gnome.org/ontology/v3/nie#</seealso>
    let _prefix_iri = Prefixed_Name(tnie, "") |> PrefixedName
    /// <summary>
    ///   <para>tnie:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unit of data that is created, annotated and processed on the user desktop. It represents a native structure the user works with. The usage of the term 'native'	is important. It means that a DataObject can be directly mapped to a data structure maintained by a native application.	This may be a file, a set of files or a part of a file. The granularity depends on the user. This class is not intended to be instantiated by itself. Use more specific subclasses.</para>
    /// labels<para>Data Object</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#DataObject">http://tracker.api.gnome.org/ontology/v3/nie#DataObject</seealso>
    let DataObject = Prefixed_Name(tnie, "DataObject") |> PrefixedName
    /// <summary>
    ///   <para>tnie:DataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A superclass for all entities from which DataObjects can be extracted. Each entity represents a native application or some other system that manages information that may be of interest to the user of the Semantic Desktop. Subclasses may include FileSystems, Mailboxes, Calendars, websites etc. The exact choice of subclasses and their properties is considered application-specific. Each data extraction application is supposed to provide it's own DataSource ontology. Such an ontology should contain supported data source types coupled with properties necessary for the application to gain access to the data sources. (paths, urls, passwords etc...)</para>
    /// labels<para>Data Source</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#DataSource">http://tracker.api.gnome.org/ontology/v3/nie#DataSource</seealso>
    let DataSource = Prefixed_Name(tnie, "DataSource") |> PrefixedName
    /// <summary>
    ///   <para>tnie:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>File size in bytes</para>
    /// labels<para>Size</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#byteSize">http://tracker.api.gnome.org/ontology/v3/nie#byteSize</seealso>
    let byteSize = Prefixed_Name(tnie, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>tnie:characterSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Characterset in which the content of the InformationElement was created. Example: ISO-8859-1, UTF-8. One of the registered character sets at http://www.iana.org/assignments/character-sets. This characterSet is used to interpret any textual parts of the content. If more than one characterSet is used within one data object, use more specific properties</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#characterSet">http://tracker.api.gnome.org/ontology/v3/nie#characterSet</seealso>
    let characterSet = Prefixed_Name(tnie, "characterSet") |> PrefixedName
    /// <summary>
    ///   <para>tnie:contentAccessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#contentAccessed">http://tracker.api.gnome.org/ontology/v3/nie#contentAccessed</seealso>
    let contentAccessed = Prefixed_Name(tnie, "contentAccessed") |> PrefixedName
    /// <summary>
    ///   <para>tnie:contentCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of the content creation. This may not necessarily be equal to the date when the DataObject (i.e. the physical representation) itself was created. Compare with nie:created property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#contentCreated">http://tracker.api.gnome.org/ontology/v3/nie#contentCreated</seealso>
    let contentCreated = Prefixed_Name(tnie, "contentCreated") |> PrefixedName
    /// <summary>
    ///   <para>tnie:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Content copyright</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#copyright">http://tracker.api.gnome.org/ontology/v3/nie#copyright</seealso>
    let copyright = Prefixed_Name(tnie, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>tnie:legal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all properties that point at legal information about an Information Element</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#legal">http://tracker.api.gnome.org/ontology/v3/nie#legal</seealso>
    let legal = Prefixed_Name(tnie, "legal") |> PrefixedName
    /// <summary>
    ///   <para>tnie:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of creation of the DataObject. Note that this date refers to the creation of the DataObject itself (i.e. the physical representation). Compare with nie:contentCreated</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#created">http://tracker.api.gnome.org/ontology/v3/nie#created</seealso>
    let created = Prefixed_Name(tnie, "created") |> PrefixedName
    /// <summary>
    ///   <para>tnie:dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Marks the provenance of a DataObject, what source does a data object come from</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#dataSource">http://tracker.api.gnome.org/ontology/v3/nie#dataSource</seealso>
    let dataSource = Prefixed_Name(tnie, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>tnie:depends</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Dependency relation. A piece of content depends on another piece of data in order to be properly understood/used/interpreted</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#depends">http://tracker.api.gnome.org/ontology/v3/nie#depends</seealso>
    let depends = Prefixed_Name(tnie, "depends") |> PrefixedName
    /// <summary>
    ///   <para>tnie:disclaimer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A disclaimer</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#disclaimer">http://tracker.api.gnome.org/ontology/v3/nie#disclaimer</seealso>
    let disclaimer = Prefixed_Name(tnie, "disclaimer") |> PrefixedName
    /// <summary>
    ///   <para>tnie:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'physical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The hasPart relation models physical containment, an InformationElement (a nmo:Message) can have a 'physical' part (an nfo:Attachment). Also, please note the difference between physical containment (hasPart) and logical containment (hasLogicalPart) the former has more strict meaning. They may occur independently of each other</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#hasPart">http://tracker.api.gnome.org/ontology/v3/nie#hasPart</seealso>
    let hasPart = Prefixed_Name(tnie, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>tnie:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An unambiguous reference to the InformationElement within a given context. Recommended best practice is to identify the resource by means of a string conforming to a formal identification system</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#identifier">http://tracker.api.gnome.org/ontology/v3/nie#identifier</seealso>
    let identifier = Prefixed_Name(tnie, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>tnie:isLogicalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property used to express 'logical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (isPartOf) and logical containment (isLogicalPartOf)</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#isLogicalPartOf">http://tracker.api.gnome.org/ontology/v3/nie#isLogicalPartOf</seealso>
    let isLogicalPartOf = Prefixed_Name(tnie, "isLogicalPartOf") |> PrefixedName
    /// <summary>
    ///   <para>tnie:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Adapted DublinCore: The topic of the content of the resource, as keyword. No sentences here. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#keyword">http://tracker.api.gnome.org/ontology/v3/nie#keyword</seealso>
    let keyword = Prefixed_Name(tnie, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>tnie:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Language the InformationElement is expressed in. Users are encouraged to use the two-letter code specified in the RFC 3066</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#language">http://tracker.api.gnome.org/ontology/v3/nie#language</seealso>
    let language = Prefixed_Name(tnie, "language") |> PrefixedName
    /// <summary>
    ///   <para>tnie:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Terms and intellectual property rights licensing conditions.</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#license">http://tracker.api.gnome.org/ontology/v3/nie#license</seealso>
    let license = Prefixed_Name(tnie, "license") |> PrefixedName
    /// <summary>
    ///   <para>tnie:licenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of the license. Possible values for this field may include 'GPL', 'BSD', 'Creative Commons' etc.</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#licenseType">http://tracker.api.gnome.org/ontology/v3/nie#licenseType</seealso>
    let licenseType = Prefixed_Name(tnie, "licenseType") |> PrefixedName
    /// <summary>
    ///   <para>tnie:plainTextContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Plain-text representation of the content of a InformationElement with all markup removed. The main purpose of this property is full-text indexing and search. Its exact content is considered application-specific. The user can make no assumptions about what is and what is not contained within. Applications should use more specific properties wherever possible.</para>
    /// labels<para>Plain-text content</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#plainTextContent">http://tracker.api.gnome.org/ontology/v3/nie#plainTextContent</seealso>
    let plainTextContent = Prefixed_Name(tnie, "plainTextContent") |> PrefixedName
    /// <summary>
    ///   <para>tnie:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject or topic of the document</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#subject">http://tracker.api.gnome.org/ontology/v3/nie#subject</seealso>
    let subject = Prefixed_Name(tnie, "subject") |> PrefixedName
    /// <summary>
    ///   <para>tnie:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The title of the document</para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nie#title">http://tracker.api.gnome.org/ontology/v3/nie#title</seealso>
    let title = Prefixed_Name(tnie, "title") |> PrefixedName
