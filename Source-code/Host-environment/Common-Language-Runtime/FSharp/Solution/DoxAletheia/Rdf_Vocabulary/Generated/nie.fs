namespace http.www.semanticdesktop.org.ontologies._2007._01._19.nie.hash

open DoxAletheia

module nie =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/01/19/nie#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A unit of data that is created, annotated and processed on the user desktop. It represents a native structure the user works with. The usage of the term 'native' is important. It means that a DataObject can be directly mapped to a data structure maintained by a native application. This may be a file, a set of files or a part of a file. The granularity depends on the user. This class is not intended to be instantiated by itself. Use more specific subclasses.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataObject"></see></summary>
    let DataObject = _prefix "DataObject"
    /// <summary>
    /// A superclass for all entities from which DataObjects can be extracted. Each entity represents a native application or some other system that manages information that may be of interest to the user of the Semantic Desktop. Subclasses may include FileSystems, Mailboxes, Calendars, websites etc. The exact choice of subclasses and their properties is considered application-specific. Each data extraction application is supposed to provide it's own DataSource ontology. Such an ontology should contain supported data source types coupled with properties necessary for the application to gain access to the data sources.  (paths, urls, passwords  etc...)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSource"></see></summary>
    let DataSource = _prefix "DataSource"
    /// <summary>
    /// Represents the sum of all information that has been obtained from a data source. Each data source has its own personal information graph. When a data source is deleted, the graph becomes redundant and should also be deleted. If two or more items in two or more data source graphs are determined to be equivalent, they are integrated at the PIMO level, and the integrated representation plus the links to the original items are stored in the pimo:PersonalInformationModel graph.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSourceGraph"></see></summary>
    let DataSourceGraph = _prefix "DataSourceGraph"
    /// <summary>
    /// A unit of content the user works with. This is a superclass for all interpretations of a DataObject.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#InformationElement"></see></summary>
    let InformationElement = _prefix "InformationElement"
    /// <summary>
    /// Representation for a standard set of device/application/service modes, corresponding to various sets of modes that are either inbuilt in a device (e.g. inbuilt phone modes such as silent, loud, general, vibrate, etc.) or available for applications and online services (e.g. IM system modes such as busy, available, invisible, etc.)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#Mode"></see></summary>
    let Mode = _prefix "Mode"
    /// <summary>
    /// The overall size of the data object in bytes. That means the space taken by the DataObject in its container, and not the size of the content that is of interest to the user. For cases where the content size is different (e.g. in compressed files the content is larger, in messages the content excludes headings and is smaller) use more specific properties, not necessarily subproperties of this one.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#byteSize"></see></summary>
    let byteSize = _prefix "byteSize"
    /// <summary>
    /// Characterset in which the content of the InformationElement was created. Example: ISO-8859-1, UTF-8. One of the registered character sets at http://www.iana.org/assignments/character-sets. This characterSet is used to interpret any textual parts of the content. If more than one characterSet is used within one data object, use more specific properties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#characterSet"></see></summary>
    let characterSet = _prefix "characterSet"
    /// <summary>
    /// A user comment about an InformationElement.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The date of the content creation. This may not necessarily be equal to the date when the DataObject (i.e. the physical representation) itself was created. Compare with nie:created property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentCreated"></see></summary>
    let contentCreated = _prefix "contentCreated"
    /// <summary>
    /// A point or period of time associated with an event in the lifecycle of an Information Element. A common superproperty for all date-related properties of InformationElements in the NIE Framework.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#informationElementDate"></see></summary>
    let informationElementDate = _prefix "informationElementDate"
    /// <summary>
    /// The date of a modification of the original content (not its corresponding DataObject or local copy). Compare with nie:modified.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentModified"></see></summary>
    let contentModified = _prefix "contentModified"
    /// <summary>
    /// The date of the last modification of the original content (not its corresponding DataObject or local copy). Compare with nie:lastModified.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentLastModified"></see></summary>
    let contentLastModified = _prefix "contentLastModified"
    /// <summary>
    /// The size of the content. This property can be used whenever the size of the content of an InformationElement differs from the size of the DataObject. (e.g. because of compression, encoding, encryption or any other representation issues). The contentSize in expressed in bytes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentSize"></see></summary>
    let contentSize = _prefix "contentSize"
    /// <summary>
    /// Content copyright
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#copyright"></see></summary>
    let copyright = _prefix "copyright"
    /// <summary>
    /// A common superproperty for all properties that point at legal information about an Information Element
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#legal"></see></summary>
    let legal = _prefix "legal"
    /// <summary>
    /// Connects the data object with the graph that contains information about it. Deprecated in favor of a more generic nao:isDataGraphFor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#coreGraph"></see></summary>
    let coreGraph = _prefix "coreGraph"
    /// <summary>
    /// Date of creation of the DataObject. Note that this date refers to the creation of the DataObject itself (i.e. the physical representation). Compare with nie:contentCreated.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// Date the DataObject was changed in any way.  Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentModified.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// Marks the provenance of a DataObject, what source does a data object come from.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#dataSource"></see></summary>
    let dataSource = _prefix "dataSource"
    /// <summary>
    /// Dependency relation. A piece of content depends on another piece of data in order to be properly understood/used/interpreted.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#depends"></see></summary>
    let depends = _prefix "depends"
    /// <summary>
    /// A common superproperty for all relations between a piece of content and other pieces of data (which may be interpreted as other pieces of content).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#relatedTo"></see></summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    /// A textual description of the resource. This property may be used for any metadata fields that provide some meta-information or comment about a resource in the form of a passage of text. This property is not to be confused with nie:plainTextContent. Use more specific subproperties wherever possible.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A disclaimer
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#disclaimer"></see></summary>
    let disclaimer = _prefix "disclaimer"
    /// <summary>
    /// Software used to "generate" the contents. E.g. a word processor name.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generator"></see></summary>
    let generator = _prefix "generator"
    /// <summary>
    /// A common superproperty for all settings used by the generating software. This may include compression settings, algorithms, autosave, interlaced/non-interlaced etc. Note that this property has no range specified and therefore should not be used directly. Always use more specific properties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generatorOption"></see></summary>
    let generatorOption = _prefix "generatorOption"
    /// <summary>
    /// Generic property used to express 'logical' containment relationships between InformationElements. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (hasPart) and logical containment (hasLogicalPart)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasLogicalPart"></see></summary>
    let hasLogicalPart = _prefix "hasLogicalPart"
    /// <summary>
    /// Generic property used to express 'logical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (isPartOf) and logical containment (isLogicalPartOf)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isLogicalPartOf"></see></summary>
    let isLogicalPartOf = _prefix "isLogicalPartOf"
    /// <summary>
    /// Generic property used to express 'physical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The hasPart relation models physical containment, an InformationElement (a nmo:Message) can have a 'physical' part (an nfo:Attachment).  Also, please note the difference between physical containment (hasPart) and logical containment (hasLogicalPart) the former has more strict meaning. They may occur independently of each other.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// Generic property used to express containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The isPartOf relation models physical containment, a nie:DataObject (e.g. an nfo:Attachment) is a 'physical' part of an nie:InformationElement (a nmo:Message). Also, please note the difference between physical containment (isPartOf) and logical containment (isLogicalPartOf) the former has more strict meaning. They may occur independently of each other.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// The HTML content of an information element. This property can be used to store text including formatting in a generic fashion.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#htmlContent"></see></summary>
    let htmlContent = _prefix "htmlContent"
    /// <summary>
    /// An unambiguous reference to the InformationElement within a given context. Recommended best practice is to identify the resource by means of a string conforming to a formal identification system.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Links the DataObject with the InformationElement it is interpreted as.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#interpretedAs"></see></summary>
    let interpretedAs = _prefix "interpretedAs"
    /// <summary>
    /// Links the information element with the DataObject it is stored in.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isStoredAs"></see></summary>
    let isStoredAs = _prefix "isStoredAs"
    /// <summary>
    /// Adapted DublinCore: The topic of the content of the resource, as keyword. No sentences here. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// Language the InformationElement is expressed in. This property applies to the data object in its entirety. If the data object is divisible into parts expressed in multiple languages - more specific properties should be used. Users are encouraged to use the two-letter code specified in the RFC 3066
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Last modification date of the DataObject. Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentLastModified.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// Date when information about this data object was retrieved (for the first time) or last refreshed from the data source. This property is important for metadata extraction applications that don't receive any notifications of changes in the data source and have to poll it regularly. This may lead to information becoming out of date. In these cases this property may be used to determine the age of data, which is an important element of it's dependability.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastRefreshed"></see></summary>
    let lastRefreshed = _prefix "lastRefreshed"
    /// <summary>
    /// Terms and intellectual property rights licensing conditions.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// The type of the license. Possible values for this field may include "GPL", "BSD", "Creative Commons" etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#licenseType"></see></summary>
    let licenseType = _prefix "licenseType"
    /// <summary>
    /// A linking relation. A piece of content links/mentions a piece of data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#links"></see></summary>
    let links = _prefix "links"
    /// <summary>
    /// The mime type of the resource, if available. Example: "text/plain". See http://www.iana.org/assignments/media-types/. This property applies to data objects that can be described with one mime type. In cases where the object as a whole has one mime type, while it's parts have other mime types, or there is no mime type that can be applied to the object as a whole, but some parts of the content have mime types - use more specific properties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#mimeType"></see></summary>
    let mimeType = _prefix "mimeType"
    /// <summary>
    /// Plain-text representation of the content of a InformationElement with all markup removed. The main purpose of this property is full-text indexing and search. Its exact content is considered application-specific. The user can make no assumptions about what is and what is not contained within. Applications should use more specific properties wherever possible.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#plainTextContent"></see></summary>
    let plainTextContent = _prefix "plainTextContent"
    /// <summary>
    /// DataObjects extracted from a single data source are organized into a containment tree. This property links the root of that tree with the datasource it has been extracted from
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#rootElementOf"></see></summary>
    let rootElementOf = _prefix "rootElementOf"
    /// <summary>
    /// Represents a number of applicable modes for a data source.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#sourceMode"></see></summary>
    let sourceMode = _prefix "sourceMode"
    /// <summary>
    /// An overall topic of the content of a InformationElement
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Name given to an InformationElement
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// URL of a DataObject. It points to the location of the object. A typial usage is FileDataObject. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// The current version of the given data object. Exact semantics is unspecified at this level. Use more specific subproperties if needed.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#version"></see></summary>
    let version = _prefix "version"
