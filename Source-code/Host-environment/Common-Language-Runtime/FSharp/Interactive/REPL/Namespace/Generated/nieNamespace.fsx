#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nie =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/01/19/nie#" "nie"

    /// <summary>
    ///   <para>rdfs:label : DataObject^^xsd:string</para>
    ///   <para>rdfs:comment : A unit of data that is created, annotated and processed on the user desktop. It represents a native structure the user works with. The usage of the term 'native' is important. It means that a DataObject can be directly mapped to a data structure maintained by a native application. This may be a file, a set of files or a part of a file. The granularity depends on the user. This class is not intended to be instantiated by itself. Use more specific subclasses.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataObject">nie:DataObject</a>
    /// </summary>
    let DataObject = _prefixId.prefix "DataObject"
    /// <summary>
    ///   <para>rdfs:label : DataSource^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass for all entities from which DataObjects can be extracted. Each entity represents a native application or some other system that manages information that may be of interest to the user of the Semantic Desktop. Subclasses may include FileSystems, Mailboxes, Calendars, websites etc. The exact choice of subclasses and their properties is considered application-specific. Each data extraction application is supposed to provide it's own DataSource ontology. Such an ontology should contain supported data source types coupled with properties necessary for the application to gain access to the data sources.  (paths, urls, passwords  etc...)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#DataSource">nie:DataSource</a>
    /// </summary>
    let DataSource = _prefixId.prefix "DataSource"
    let DataSourceGraph = _prefixId.prefix "DataSourceGraph"
    /// <summary>
    ///   <para>rdfs:label : InformationElement^^xsd:string</para>
    ///   <para>rdfs:comment : A unit of content the user works with. This is a superclass for all interpretations of a DataObject.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#InformationElement">nie:InformationElement</a>
    /// </summary>
    let InformationElement = _prefixId.prefix "InformationElement"
    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <para>rdfs:comment : Representation for a standard set of device/application/service modes, corresponding to various sets of modes that are either inbuilt in a device (e.g. inbuilt phone modes such as silent, loud, general, vibrate, etc.) or available for applications and online services (e.g. IM system modes such as busy, available, invisible, etc.)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#Mode">nie:Mode</a>
    /// </summary>
    let Mode = _prefixId.prefix "Mode"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : byteSize^^xsd:string</para>
    ///   <para>rdfs:comment : The overall size of the data object in bytes. That means the space taken by the DataObject in its container, and not the size of the content that is of interest to the user. For cases where the content size is different (e.g. in compressed files the content is larger, in messages the content excludes headings and is smaller) use more specific properties, not necessarily subproperties of this one.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#byteSize">nie:byteSize</a>
    /// </summary>
    let byteSize = _prefixId.prefix "byteSize"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : characterSet^^xsd:string</para>
    ///   <para>rdfs:comment : Characterset in which the content of the InformationElement was created. Example: ISO-8859-1, UTF-8. One of the registered character sets at http://www.iana.org/assignments/character-sets. This characterSet is used to interpret any textual parts of the content. If more than one characterSet is used within one data object, use more specific properties.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#characterSet">nie:characterSet</a>
    /// </summary>
    let characterSet = _prefixId.prefix "characterSet"
    /// <summary>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <para>rdfs:comment : A user comment about an InformationElement.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#comment">nie:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : contentCreated^^xsd:string</para>
    ///   <para>rdfs:comment : The date of the content creation. This may not necessarily be equal to the date when the DataObject (i.e. the physical representation) itself was created. Compare with nie:created property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentCreated">nie:contentCreated</a>
    /// </summary>
    let contentCreated = _prefixId.prefix "contentCreated"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : contentLastModified^^xsd:string</para>
    ///   <para>rdfs:comment : The date of the last modification of the original content (not its corresponding DataObject or local copy). Compare with nie:lastModified.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentLastModified">nie:contentLastModified</a>
    /// </summary>
    let contentLastModified = _prefixId.prefix "contentLastModified"
    /// <summary>
    ///   <para>rdfs:label : modified^^xsd:string</para>
    ///   <para>rdfs:comment : The date of a modification of the original content (not its corresponding DataObject or local copy). Compare with nie:modified.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentModified">nie:contentModified</a>
    /// </summary>
    let contentModified = _prefixId.prefix "contentModified"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : contentSize^^xsd:string</para>
    ///   <para>rdfs:comment : The size of the content. This property can be used whenever the size of the content of an InformationElement differs from the size of the DataObject. (e.g. because of compression, encoding, encryption or any other representation issues). The contentSize in expressed in bytes.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#contentSize">nie:contentSize</a>
    /// </summary>
    let contentSize = _prefixId.prefix "contentSize"
    /// <summary>
    ///   <para>rdfs:label : copyright^^xsd:string</para>
    ///   <para>rdfs:comment : Content copyright^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#copyright">nie:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    /// <summary>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : coreGraph^^xsd:string</para>
    ///   <para>rdfs:comment : Connects the data object with the graph that contains information about it. Deprecated in favor of a more generic nao:isDataGraphFor.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#coreGraph">nie:coreGraph</a>
    /// </summary>
    let coreGraph = _prefixId.prefix "coreGraph"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : created^^xsd:string</para>
    ///   <para>rdfs:comment : Date of creation of the DataObject. Note that this date refers to the creation of the DataObject itself (i.e. the physical representation). Compare with nie:contentCreated.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#created">nie:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>nrl:minCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : dataSource^^xsd:string</para>
    ///   <para>rdfs:comment : Marks the provenance of a DataObject, what source does a data object come from.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#dataSource">nie:dataSource</a>
    /// </summary>
    let dataSource = _prefixId.prefix "dataSource"
    /// <summary>
    ///   <para>rdfs:label : depends^^xsd:string</para>
    ///   <para>rdfs:comment : Dependency relation. A piece of content depends on another piece of data in order to be properly understood/used/interpreted.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#depends">nie:depends</a>
    /// </summary>
    let depends = _prefixId.prefix "depends"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : A textual description of the resource. This property may be used for any metadata fields that provide some meta-information or comment about a resource in the form of a passage of text. This property is not to be confused with nie:plainTextContent. Use more specific subproperties wherever possible.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#description">nie:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : disclaimer^^xsd:string</para>
    ///   <para>rdfs:comment : A disclaimer^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#disclaimer">nie:disclaimer</a>
    /// </summary>
    let disclaimer = _prefixId.prefix "disclaimer"
    /// <summary>
    ///   <para>rdfs:label : generator^^xsd:string</para>
    ///   <para>rdfs:comment : Software used to "generate" the contents. E.g. a word processor name.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generator">nie:generator</a>
    /// </summary>
    let generator = _prefixId.prefix "generator"
    /// <summary>
    ///   <para>rdfs:label : generatorOption^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all settings used by the generating software. This may include compression settings, algorithms, autosave, interlaced/non-interlaced etc. Note that this property has no range specified and therefore should not be used directly. Always use more specific properties.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#generatorOption">nie:generatorOption</a>
    /// </summary>
    let generatorOption = _prefixId.prefix "generatorOption"
    /// <summary>
    ///   <para>rdfs:label : hasLogicalPart^^xsd:string</para>
    ///   <para>rdfs:comment : Generic property used to express 'logical' containment relationships between InformationElements. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (hasPart) and logical containment (hasLogicalPart)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasLogicalPart">nie:hasLogicalPart</a>
    /// </summary>
    let hasLogicalPart = _prefixId.prefix "hasLogicalPart"
    /// <summary>
    ///   <para>rdfs:comment : Generic property used to express 'physical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The hasPart relation models physical containment, an InformationElement (a nmo:Message) can have a 'physical' part (an nfo:Attachment).  Also, please note the difference between physical containment (hasPart) and logical containment (hasLogicalPart) the former has more strict meaning. They may occur independently of each other.^^xsd:string</para>
    ///   <para>nao:userVisible : false^^xsd:boolean</para>
    ///   <para>rdfs:label : hasPart^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#hasPart">nie:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : html content^^xsd:string</para>
    ///   <para>rdfs:comment : The HTML content of an information element. This property can be used to store text including formatting in a generic fashion.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#htmlContent">nie:htmlContent</a>
    /// </summary>
    let htmlContent = _prefixId.prefix "htmlContent"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <para>rdfs:comment : An unambiguous reference to the InformationElement within a given context. Recommended best practice is to identify the resource by means of a string conforming to a formal identification system.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#identifier">nie:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : informationElementDate^^xsd:string</para>
    ///   <para>rdfs:comment : A point or period of time associated with an event in the lifecycle of an Information Element. A common superproperty for all date-related properties of InformationElements in the NIE Framework.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#informationElementDate">nie:informationElementDate</a>
    /// </summary>
    let informationElementDate = _prefixId.prefix "informationElementDate"
    /// <summary>
    ///   <para>rdfs:label : interpretedAs^^xsd:string</para>
    ///   <para>rdfs:comment : Links the DataObject with the InformationElement it is interpreted as.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#interpretedAs">nie:interpretedAs</a>
    /// </summary>
    let interpretedAs = _prefixId.prefix "interpretedAs"
    /// <summary>
    ///   <para>rdfs:label : isLogicalPartOf^^xsd:string</para>
    ///   <para>rdfs:comment : Generic property used to express 'logical' containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of InformationElement to use those specific subproperties. Note the difference between 'physical' containment (isPartOf) and logical containment (isLogicalPartOf)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isLogicalPartOf">nie:isLogicalPartOf</a>
    /// </summary>
    let isLogicalPartOf = _prefixId.prefix "isLogicalPartOf"
    /// <summary>
    ///   <para>rdfs:comment : Generic property used to express containment relationships between DataObjects. NIE extensions are encouraged to provide more specific subproperties of this one. It is advisable for actual instances of DataObjects to use those specific subproperties. Note to the developers: Please be aware of the distinction between containment relation and provenance. The isPartOf relation models physical containment, a nie:DataObject (e.g. an nfo:Attachment) is a 'physical' part of an nie:InformationElement (a nmo:Message). Also, please note the difference between physical containment (isPartOf) and logical containment (isLogicalPartOf) the former has more strict meaning. They may occur independently of each other.^^xsd:string</para>
    ///   <para>nao:userVisible : false^^xsd:boolean</para>
    ///   <para>rdfs:label : isPartOf^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isPartOf">nie:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : isStoredAs^^xsd:string</para>
    ///   <para>rdfs:comment : Links the information element with the DataObject it is stored in.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#isStoredAs">nie:isStoredAs</a>
    /// </summary>
    let isStoredAs = _prefixId.prefix "isStoredAs"
    /// <summary>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <para>rdfs:comment : Adapted DublinCore: The topic of the content of the resource, as keyword. No sentences here. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. ^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#keyword">nie:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <para>rdfs:comment : Language the InformationElement is expressed in. This property applies to the data object in its entirety. If the data object is divisible into parts expressed in multiple languages - more specific properties should be used. Users are encouraged to use the two-letter code specified in the RFC 3066^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#language">nie:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : lastModified^^xsd:string</para>
    ///   <para>rdfs:comment : Last modification date of the DataObject. Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentLastModified.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastModified">nie:lastModified</a>
    /// </summary>
    let lastModified = _prefixId.prefix "lastModified"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : lastRefreshed^^xsd:string</para>
    ///   <para>rdfs:comment : Date when information about this data object was retrieved (for the first time) or last refreshed from the data source. This property is important for metadata extraction applications that don't receive any notifications of changes in the data source and have to poll it regularly. This may lead to information becoming out of date. In these cases this property may be used to determine the age of data, which is an important element of it's dependability. ^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#lastRefreshed">nie:lastRefreshed</a>
    /// </summary>
    let lastRefreshed = _prefixId.prefix "lastRefreshed"
    /// <summary>
    ///   <para>rdfs:label : legal^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all properties that point at legal information about an Information Element^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#legal">nie:legal</a>
    /// </summary>
    let legal = _prefixId.prefix "legal"
    /// <summary>
    ///   <para>rdfs:label : license^^xsd:string</para>
    ///   <para>rdfs:comment : Terms and intellectual property rights licensing conditions.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#license">nie:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : licenseType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the license. Possible values for this field may include "GPL", "BSD", "Creative Commons" etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#licenseType">nie:licenseType</a>
    /// </summary>
    let licenseType = _prefixId.prefix "licenseType"
    /// <summary>
    ///   <para>rdfs:label : links^^xsd:string</para>
    ///   <para>rdfs:comment : A linking relation. A piece of content links/mentions a piece of data^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#links">nie:links</a>
    /// </summary>
    let links = _prefixId.prefix "links"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : mimeType^^xsd:string</para>
    ///   <para>rdfs:comment : The mime type of the resource, if available. Example: "text/plain". See http://www.iana.org/assignments/media-types/. This property applies to data objects that can be described with one mime type. In cases where the object as a whole has one mime type, while it's parts have other mime types, or there is no mime type that can be applied to the object as a whole, but some parts of the content have mime types - use more specific properties.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#mimeType">nie:mimeType</a>
    /// </summary>
    let mimeType = _prefixId.prefix "mimeType"
    /// <summary>
    ///   <para>rdfs:label : modified^^xsd:string</para>
    ///   <para>rdfs:comment : Date the DataObject was changed in any way.  Note that this date refers to the modification of the DataObject itself (i.e. the physical representation). Compare with nie:contentModified.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#modified">nie:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : plainTextContent^^xsd:string</para>
    ///   <para>rdfs:comment : Plain-text representation of the content of a InformationElement with all markup removed. The main purpose of this property is full-text indexing and search. Its exact content is considered application-specific. The user can make no assumptions about what is and what is not contained within. Applications should use more specific properties wherever possible.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#plainTextContent">nie:plainTextContent</a>
    /// </summary>
    let plainTextContent = _prefixId.prefix "plainTextContent"
    /// <summary>
    ///   <para>rdfs:label : relatedTo^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all relations between a piece of content and other pieces of data (which may be interpreted as other pieces of content).^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#relatedTo">nie:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>rdfs:label : rootElementOf^^xsd:string</para>
    ///   <para>rdfs:comment : DataObjects extracted from a single data source are organized into a containment tree. This property links the root of that tree with the datasource it has been extracted from^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#rootElementOf">nie:rootElementOf</a>
    /// </summary>
    let rootElementOf = _prefixId.prefix "rootElementOf"
    /// <summary>
    ///   <para>rdfs:label : Data Source Mode^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a number of applicable modes for a data source.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#sourceMode">nie:sourceMode</a>
    /// </summary>
    let sourceMode = _prefixId.prefix "sourceMode"
    /// <summary>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <para>rdfs:comment : An overall topic of the content of a InformationElement^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#subject">nie:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : Name given to an InformationElement^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#title">nie:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <para>rdfs:comment : URL of a DataObject. It points to the location of the object. A typial usage is FileDataObject. In cases where creating a simple file:// or http:// URL for a file is difficult (e.g. for files inside compressed archives) the applications are encouraged to use conventions defined by Apache Commons VFS Project at http://jakarta.apache.org/  commons/ vfs/ filesystems.html.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#url">nie:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : The current version of the given data object. Exact semantics is unspecified at this level. Use more specific subproperties if needed.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/01/19/nie#version">nie:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
