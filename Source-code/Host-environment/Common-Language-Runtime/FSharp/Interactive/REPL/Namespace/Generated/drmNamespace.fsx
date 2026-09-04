#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module drm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.data.gov/def/drm#" "drm"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Example: The “SSN” Attribute of a “Person” Entity may have a Data Type of “string” (if hyphens are included with the SSN) or “integer” (if hyphens are not included).^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Attribute">drm:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>rdfs:label : Consumer^^xsd:string</para>
    ///   <para>rdfs:comment : An entity (person or organization) that consumes data that is supplied by a Supplier.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Consumer">drm:Consumer</a>
    /// </summary>
    let Consumer = _prefixId.prefix "Consumer"
    /// <summary>
    ///   <para>rdfs:label : Data access^^xsd:string</para>
    ///   <para>rdfs:comment : Requests for data services, such as a query of a Data Asset.  These requests are supported by Data Access Services^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DataAccess">drm:DataAccess</a>
    /// </summary>
    let DataAccess = _prefixId.prefix "DataAccess"
    /// <summary>
    ///   <para>rdfs:label : Data asset^^xsd:string</para>
    ///   <para>rdfs:comment : The term “data asset” is synonymous with “data source”^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DataAsset">drm:DataAsset</a>
    /// </summary>
    let DataAsset = _prefixId.prefix "DataAsset"
    /// <summary>
    ///   <para>rdfs:label : Data schema^^xsd:string</para>
    ///   <para>rdfs:comment : A representation of metadata, often in the form of data artifacts such as logical data models or conceptual data models. The Data Schema concept group is comprised of those concepts pertaining to the representation of structured data. A Data Schema provides a means to provision data sharing services that is independent of the values of the data in the data resource that it describes.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DataSchema">drm:DataSchema</a>
    /// </summary>
    let DataSchema = _prefixId.prefix "DataSchema"
    /// <summary>
    ///   <para>rdfs:label : Data steward^^xsd:string</para>
    ///   <para>rdfs:comment : A person responsible for managing a Data Asset.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DataSteward">drm:DataSteward</a>
    /// </summary>
    let DataSteward = _prefixId.prefix "DataSteward"
    /// <summary>
    ///   <para>rdfs:label : Data type^^xsd:string</para>
    ///   <para>rdfs:comment : A constraint on the type of data that an instance of an Attribute may hold (e.g. "string" or "integer").^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DataType">drm:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:label : Digital data resource^^xsd:string</para>
    ///   <para>rdfs:comment : A digital container of information, typically known as a file. A Digital Data Resource may be one of three specific types of data resources, each corresponding to one of the three types of data described earlier, and each described below (see “Structured Data Resource”, “Semi-Structured Data Resource”, and “Unstructured Data Resource”). It will be a container for the metadata about the data resource.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#DigitalDataResource">drm:DigitalDataResource</a>
    /// </summary>
    let DigitalDataResource = _prefixId.prefix "DigitalDataResource"
    /// <summary>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>rdfs:comment : While a Document can contain structured data, it normally has explanatory material included, which would cause it to therefore be considered semi-structured.  It is for this reason that there is no “contains” relationship from Document to Structured Data Resource. It is very important to separate Documents from Structured Data Resources because they are processed very differently. The difference between a Document and a Digital Data Resource, therefore, is that a Digital Data Resource can contained structured data.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Document">drm:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : An abstraction for a person, place, object, event, or concept described (or characterized) by common Attributes. For example, “Person” and “Agency” are Entities. An instance of an Entity represents one particular occurrence of the Entity, such as a specific person or a specific agency.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Entity">drm:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Exchange package^^xsd:string</para>
    ///   <para>rdfs:comment : A description of a specific recurring data exchange between a Supplier and a Consumer. An Exchange Package contains information (metadata) relating to the exchange (such as Supplier ID, Consumer ID, validity period for data, etc.), as well as a reference to the Payload (message content) for the exchange. An Exchange Package can also be used to define the result format for a query that is accepted and processed by a Query Point in a data sharing scenario.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#ExchangePackage">drm:ExchangePackage</a>
    /// </summary>
    let ExchangePackage = _prefixId.prefix "ExchangePackage"
    /// <summary>
    ///   <para>rdfs:label : External data schema^^xsd:string</para>
    ///   <para>rdfs:comment : This is a schema not described using DRM built-in concepts, but just pointed to. For example, XML Schema file^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#ExternalDataSchema">drm:ExternalDataSchema</a>
    /// </summary>
    let ExternalDataSchema = _prefixId.prefix "ExternalDataSchema"
    /// <summary>
    ///   <para>rdfs:label : Internal data schema^^xsd:string</para>
    ///   <para>rdfs:comment : This is the data schema described using DRM built-in concepts^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#InternalDataSchema">drm:InternalDataSchema</a>
    /// </summary>
    let InternalDataSchema = _prefixId.prefix "InternalDataSchema"
    /// <summary>
    ///   <para>rdfs:label : Payload definition^^xsd:string</para>
    ///   <para>rdfs:comment : Example: A specific message set expressed as an XML schema or an EDI transaction set that contains information about a “Person” entity.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#PayloadDefinition">drm:PayloadDefinition</a>
    /// </summary>
    let PayloadDefinition = _prefixId.prefix "PayloadDefinition"
    /// <summary>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Person">drm:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Query point^^xsd:string</para>
    ///   <para>rdfs:comment : An endpoint that provides an interface for accessing and querying a Data Asset. A concrete representation of a Query Point may be a specific URL at which a query Web Service may be invoked.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#QueryPoint">drm:QueryPoint</a>
    /// </summary>
    let QueryPoint = _prefixId.prefix "QueryPoint"
    /// <summary>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between two Entities.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Relationship">drm:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:label : Semistructured data resource^^xsd:string</para>
    ///   <para>rdfs:comment : A Digital Data Resource containing semi-structured data. This will generally consist in part of structured data and in part of unstructured data.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#SemistructuredDataResource">drm:SemistructuredDataResource</a>
    /// </summary>
    let SemistructuredDataResource = _prefixId.prefix "SemistructuredDataResource"
    /// <summary>
    ///   <para>rdfs:label : Stewardship^^xsd:string</para>
    ///   <para>rdfs:comment : The concept of managing a data resource^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Stewardship">drm:Stewardship</a>
    /// </summary>
    let Stewardship = _prefixId.prefix "Stewardship"
    /// <summary>
    ///   <para>rdfs:label : Structured data resource^^xsd:string</para>
    ///   <para>rdfs:comment : A Digital Data Resource containing structured data. This data can be accessed in a uniform manner, independent of data values, once the Data Schema is known.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#StructuredDataResource">drm:StructuredDataResource</a>
    /// </summary>
    let StructuredDataResource = _prefixId.prefix "StructuredDataResource"
    /// <summary>
    ///   <para>rdfs:label : Supplier^^xsd:string</para>
    ///   <para>rdfs:comment : An entity (person or organization) that supplies data to a Consumer.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Supplier">drm:Supplier</a>
    /// </summary>
    let Supplier = _prefixId.prefix "Supplier"
    /// <summary>
    ///   <para>rdfs:label : Taxonomy^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of controlled vocabulary terms organized into a hierarchical structure. Taxonomies provide a means for categorizing or classifying information within a reasonably well-defined associative structure, in which each term in a Taxonomy is in one or more parent/child (broader/narrower) relationships to other terms in the Taxonomy.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Taxonomy">drm:Taxonomy</a>
    /// </summary>
    let Taxonomy = _prefixId.prefix "Taxonomy"
    /// <summary>
    ///   <para>rdfs:label : Topic^^xsd:string</para>
    ///   <para>rdfs:comment : A category within a Taxonomy. A Topic is the central concept for applying context to data. For example, an agency may have a Taxonomy that represents their organizational structure. In such a Taxonomy, each role in the organizational structure (e.g. CIO) represents a Topic. Topic is often synonymous with “node”.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#Topic">drm:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : Unstructured data resource^^xsd:string</para>
    ///   <para>rdfs:comment : A Digital Data Resource containing unstructured data. Unstructured data is collection of data values that are likely to be processed only by specialized application programs.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#UnstructuredDataResource">drm:UnstructuredDataResource</a>
    /// </summary>
    let UnstructuredDataResource = _prefixId.prefix "UnstructuredDataResource"
    /// <summary>
    ///   <para>rdfs:label : accesses^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#accesses">drm:accesses</a>
    /// </summary>
    let accesses = _prefixId.prefix "accesses"
    /// <summary>
    ///   <para>rdfs:label : acronym^^xsd:string</para>
    ///   <para>rdfs:comment : Reference model acronym.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#acronym">drm:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:label : categorized by^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#categorizedBy">drm:categorizedBy</a>
    /// </summary>
    let categorizedBy = _prefixId.prefix "categorizedBy"
    /// <summary>
    ///   <para>rdfs:label : categorizes^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#categorizes">drm:categorizes</a>
    /// </summary>
    let categorizes = _prefixId.prefix "categorizes"
    /// <summary>
    ///   <para>rdfs:label : classification^^xsd:string</para>
    ///   <para>rdfs:comment : The security classification for an Exchange Package.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#classification">drm:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : constrained by^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#constrainedBy">drm:constrainedBy</a>
    /// </summary>
    let constrainedBy = _prefixId.prefix "constrainedBy"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#contains">drm:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : defines^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#defines">drm:defines</a>
    /// </summary>
    let defines = _prefixId.prefix "defines"
    /// <summary>
    ///   <para>rdfs:label : destination^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#destination">drm:destination</a>
    /// </summary>
    let destination = _prefixId.prefix "destination"
    /// <summary>
    ///   <para>rdfs:label : disseminated to^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#disseminatedTo">drm:disseminatedTo</a>
    /// </summary>
    let disseminatedTo = _prefixId.prefix "disseminatedTo"
    /// <summary>
    ///   <para>rdfs:label : employee iD^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#employeeID">drm:employeeID</a>
    /// </summary>
    let employeeID = _prefixId.prefix "employeeID"
    /// <summary>
    ///   <para>rdfs:label : frequency^^xsd:string</para>
    ///   <para>rdfs:comment : The frequency at which the exchange occurs.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#frequency">drm:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>rdfs:label : geospatial enabled^^xsd:string</para>
    ///   <para>rdfs:comment : Designates whether or not the Data Asset supports or provides Geospatial data.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#geospatialEnabled">drm:geospatialEnabled</a>
    /// </summary>
    let geospatialEnabled = _prefixId.prefix "geospatialEnabled"
    /// <summary>
    ///   <para>rdfs:label : has schema element^^xsd:string</para>
    ///   <para>rdfs:comment : This relationship is not explicitly stated in the DRM document. It has been created because there was a need to connect the schema with the entities, relationships, etc.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#hasSchemaElement">drm:hasSchemaElement</a>
    /// </summary>
    let hasSchemaElement = _prefixId.prefix "hasSchemaElement"
    /// <summary>
    ///   <para>rdfs:label : has stewardship^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#hasStewardship">drm:hasStewardship</a>
    /// </summary>
    let hasStewardship = _prefixId.prefix "hasStewardship"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <para>rdfs:comment : The “Identifier” attribute is described at an abstract level in order to be consistent with the abstract nature of the reference model. Therefore, there are no references to aspects such as identifier uniqueness, representation format, or similar. Implementations based on the DRM will introduce such aspects as needed according to their requirements.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#identifier">drm:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : initial date^^xsd:string</para>
    ///   <para>rdfs:comment : The date that the Data Steward became associated with the Data Asset.^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#initialDate">drm:initialDate</a>
    /// </summary>
    let initialDate = _prefixId.prefix "initialDate"
    /// <summary>
    ///   <para>rdfs:label : is element of^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#isElementOf">drm:isElementOf</a>
    /// </summary>
    let isElementOf = _prefixId.prefix "isElementOf"
    /// <summary>
    ///   <para>rdfs:label : location pointer^^xsd:string</para>
    ///   <para>rdfs:comment : This is a link to location of a digital resource^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#locationPointer">drm:locationPointer</a>
    /// </summary>
    let locationPointer = _prefixId.prefix "locationPointer"
    /// <summary>
    ///   <para>rdfs:label : managed by^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#managedBy">drm:managedBy</a>
    /// </summary>
    let managedBy = _prefixId.prefix "managedBy"
    /// <summary>
    ///   <para>rdfs:label : manages^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#manages">drm:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#name">drm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : origin^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#origin">drm:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    /// <summary>
    ///   <para>rdfs:label : participates in^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#participatesIn">drm:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>rdfs:label : produced by^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#producedBy">drm:producedBy</a>
    /// </summary>
    let producedBy = _prefixId.prefix "producedBy"
    /// <summary>
    ///   <para>rdfs:label : produces^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#produces">drm:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:label : provides management context^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#providesManagementContext">drm:providesManagementContext</a>
    /// </summary>
    let providesManagementContext = _prefixId.prefix "providesManagementContext"
    /// <summary>
    ///   <para>rdfs:label : queries^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#queries">drm:queries</a>
    /// </summary>
    let queries = _prefixId.prefix "queries"
    /// <summary>
    ///   <para>rdfs:label : refers to^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#refersTo">drm:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : refers to entity^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#refersToEntity">drm:refersToEntity</a>
    /// </summary>
    let refersToEntity = _prefixId.prefix "refersToEntity"
    /// <summary>
    ///   <para>rdfs:label : refers to payload^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#refersToPayload">drm:refersToPayload</a>
    /// </summary>
    let refersToPayload = _prefixId.prefix "refersToPayload"
    /// <summary>
    ///   <para>rdfs:label : relates^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#relates">drm:relates</a>
    /// </summary>
    let relates = _prefixId.prefix "relates"
    /// <summary>
    ///   <para>rdfs:label : represented as^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#representedAs">drm:representedAs</a>
    /// </summary>
    let representedAs = _prefixId.prefix "representedAs"
    /// <summary>
    ///   <para>rdfs:label : returns result set specified in^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#returnsResultSetSpecifiedIn">drm:returnsResultSetSpecifiedIn</a>
    /// </summary>
    let returnsResultSetSpecifiedIn = _prefixId.prefix "returnsResultSetSpecifiedIn"
    /// <summary>
    ///   <para>rdfs:label : works for^^xsd:string</para>
    ///   <a href="http://vocab.data.gov/def/drm#worksFor">drm:worksFor</a>
    /// </summary>
    let worksFor = _prefixId.prefix "worksFor"
