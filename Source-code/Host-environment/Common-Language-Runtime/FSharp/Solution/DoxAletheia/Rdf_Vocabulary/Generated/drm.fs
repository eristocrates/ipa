namespace http.vocab.data.gov.def.drm.hash

open DoxAletheia

module drm =
    let _namespace_name = "http://vocab.data.gov/def/drm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Example: The “SSN” Attribute of a “Person” Entity may have a Data Type of “string” (if hyphens are included with the SSN) or “integer” (if hyphens are not included).
    /// <see href="http://vocab.data.gov/def/drm#Attribute"></see></summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    /// An entity (person or organization) that consumes data that is supplied by a Supplier.
    /// <see href="http://vocab.data.gov/def/drm#Consumer"></see></summary>
    let Consumer = _prefix "Consumer"
    /// <summary>
    /// Requests for data services, such as a query of a Data Asset.  These requests are supported by Data Access Services
    /// <see href="http://vocab.data.gov/def/drm#DataAccess"></see></summary>
    let DataAccess = _prefix "DataAccess"
    /// <summary>
    /// The term “data asset” is synonymous with “data source”
    /// <see href="http://vocab.data.gov/def/drm#DataAsset"></see></summary>
    let DataAsset = _prefix "DataAsset"
    /// <summary>
    /// A representation of metadata, often in the form of data artifacts such as logical data models or conceptual data models. The Data Schema concept group is comprised of those concepts pertaining to the representation of structured data. A Data Schema provides a means to provision data sharing services that is independent of the values of the data in the data resource that it describes.
    /// <see href="http://vocab.data.gov/def/drm#DataSchema"></see></summary>
    let DataSchema = _prefix "DataSchema"
    /// <summary>
    /// A Digital Data Resource containing structured data. This data can be accessed in a uniform manner, independent of data values, once the Data Schema is known.
    /// <see href="http://vocab.data.gov/def/drm#StructuredDataResource"></see></summary>
    let StructuredDataResource = _prefix "StructuredDataResource"
    /// <summary>
    /// A person responsible for managing a Data Asset.
    /// <see href="http://vocab.data.gov/def/drm#DataSteward"></see></summary>
    let DataSteward = _prefix "DataSteward"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A constraint on the type of data that an instance of an Attribute may hold (e.g. "string" or "integer").
    /// <see href="http://vocab.data.gov/def/drm#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// A digital container of information, typically known as a file. A Digital Data Resource may be one of three specific types of data resources, each corresponding to one of the three types of data described earlier, and each described below (see “Structured Data Resource”, “Semi-Structured Data Resource”, and “Unstructured Data Resource”). It will be a container for the metadata about the data resource.
    /// <see href="http://vocab.data.gov/def/drm#DigitalDataResource"></see></summary>
    let DigitalDataResource = _prefix "DigitalDataResource"
    /// <summary>
    /// While a Document can contain structured data, it normally has explanatory material included, which would cause it to therefore be considered semi-structured.  It is for this reason that there is no “contains” relationship from Document to Structured Data Resource. It is very important to separate Documents from Structured Data Resources because they are processed very differently. The difference between a Document and a Digital Data Resource, therefore, is that a Digital Data Resource can contained structured data.
    /// <see href="http://vocab.data.gov/def/drm#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// An abstraction for a person, place, object, event, or concept described (or characterized) by common Attributes. For example, “Person” and “Agency” are Entities. An instance of an Entity represents one particular occurrence of the Entity, such as a specific person or a specific agency.
    /// <see href="http://vocab.data.gov/def/drm#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// A description of a specific recurring data exchange between a Supplier and a Consumer. An Exchange Package contains information (metadata) relating to the exchange (such as Supplier ID, Consumer ID, validity period for data, etc.), as well as a reference to the Payload (message content) for the exchange. An Exchange Package can also be used to define the result format for a query that is accepted and processed by a Query Point in a data sharing scenario.
    /// <see href="http://vocab.data.gov/def/drm#ExchangePackage"></see></summary>
    let ExchangePackage = _prefix "ExchangePackage"
    /// <summary>
    /// This is a schema not described using DRM built-in concepts, but just pointed to. For example, XML Schema file
    /// <see href="http://vocab.data.gov/def/drm#ExternalDataSchema"></see></summary>
    let ExternalDataSchema = _prefix "ExternalDataSchema"
    /// <summary>
    /// This is the data schema described using DRM built-in concepts
    /// <see href="http://vocab.data.gov/def/drm#InternalDataSchema"></see></summary>
    let InternalDataSchema = _prefix "InternalDataSchema"
    /// <summary>
    /// Example: A specific message set expressed as an XML schema or an EDI transaction set that contains information about a “Person” entity.
    /// <see href="http://vocab.data.gov/def/drm#PayloadDefinition"></see></summary>
    let PayloadDefinition = _prefix "PayloadDefinition"
    /// <summary>
    /// An endpoint that provides an interface for accessing and querying a Data Asset. A concrete representation of a Query Point may be a specific URL at which a query Web Service may be invoked.
    /// <see href="http://vocab.data.gov/def/drm#QueryPoint"></see></summary>
    let QueryPoint = _prefix "QueryPoint"
    /// <summary>
    /// Describes the relationship between two Entities.
    /// <see href="http://vocab.data.gov/def/drm#Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// A Digital Data Resource containing semi-structured data. This will generally consist in part of structured data and in part of unstructured data.
    /// <see href="http://vocab.data.gov/def/drm#SemistructuredDataResource"></see></summary>
    let SemistructuredDataResource = _prefix "SemistructuredDataResource"
    /// <summary>
    /// The concept of managing a data resource
    /// <see href="http://vocab.data.gov/def/drm#Stewardship"></see></summary>
    let Stewardship = _prefix "Stewardship"
    /// <summary>
    /// An entity (person or organization) that supplies data to a Consumer.
    /// <see href="http://vocab.data.gov/def/drm#Supplier"></see></summary>
    let Supplier = _prefix "Supplier"
    /// <summary>
    /// A collection of controlled vocabulary terms organized into a hierarchical structure. Taxonomies provide a means for categorizing or classifying information within a reasonably well-defined associative structure, in which each term in a Taxonomy is in one or more parent/child (broader/narrower) relationships to other terms in the Taxonomy.
    /// <see href="http://vocab.data.gov/def/drm#Taxonomy"></see></summary>
    let Taxonomy = _prefix "Taxonomy"
    /// <summary>
    /// A category within a Taxonomy. A Topic is the central concept for applying context to data. For example, an agency may have a Taxonomy that represents their organizational structure. In such a Taxonomy, each role in the organizational structure (e.g. CIO) represents a Topic. Topic is often synonymous with “node”.
    /// <see href="http://vocab.data.gov/def/drm#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// A Digital Data Resource containing unstructured data. Unstructured data is collection of data values that are likely to be processed only by specialized application programs.
    /// <see href="http://vocab.data.gov/def/drm#UnstructuredDataResource"></see></summary>
    let UnstructuredDataResource = _prefix "UnstructuredDataResource"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#accesses"></see>
    /// </summary>
    let accesses = _prefix "accesses"
    /// <summary>
    /// Reference model acronym.
    /// <see href="http://vocab.data.gov/def/drm#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#categorizedBy"></see>
    /// </summary>
    let categorizedBy = _prefix "categorizedBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#categorizes"></see>
    /// </summary>
    let categorizes = _prefix "categorizes"
    /// <summary>
    /// The security classification for an Exchange Package.
    /// <see href="http://vocab.data.gov/def/drm#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#constrainedBy"></see>
    /// </summary>
    let constrainedBy = _prefix "constrainedBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#defines"></see>
    /// </summary>
    let defines = _prefix "defines"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#destination"></see>
    /// </summary>
    let destination = _prefix "destination"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#relates"></see>
    /// </summary>
    let relates = _prefix "relates"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#disseminatedTo"></see>
    /// </summary>
    let disseminatedTo = _prefix "disseminatedTo"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#employeeID"></see>
    /// </summary>
    let employeeID = _prefix "employeeID"
    /// <summary>
    /// The frequency at which the exchange occurs.
    /// <see href="http://vocab.data.gov/def/drm#frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// Designates whether or not the Data Asset supports or provides Geospatial data.
    /// <see href="http://vocab.data.gov/def/drm#geospatialEnabled"></see></summary>
    let geospatialEnabled = _prefix "geospatialEnabled"
    /// <summary>
    /// This relationship is not explicitly stated in the DRM document. It has been created because there was a need to connect the schema with the entities, relationships, etc.
    /// <see href="http://vocab.data.gov/def/drm#hasSchemaElement"></see></summary>
    let hasSchemaElement = _prefix "hasSchemaElement"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#hasStewardship"></see>
    /// </summary>
    let hasStewardship = _prefix "hasStewardship"
    /// <summary>
    /// The “Identifier” attribute is described at an abstract level in order to be consistent with the abstract nature of the reference model. Therefore, there are no references to aspects such as identifier uniqueness, representation format, or similar. Implementations based on the DRM will introduce such aspects as needed according to their requirements.
    /// <see href="http://vocab.data.gov/def/drm#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// The date that the Data Steward became associated with the Data Asset.
    /// <see href="http://vocab.data.gov/def/drm#initialDate"></see></summary>
    let initialDate = _prefix "initialDate"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#isElementOf"></see>
    /// </summary>
    let isElementOf = _prefix "isElementOf"
    /// <summary>
    /// This is a link to location of a digital resource
    /// <see href="http://vocab.data.gov/def/drm#locationPointer"></see></summary>
    let locationPointer = _prefix "locationPointer"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#managedBy"></see>
    /// </summary>
    let managedBy = _prefix "managedBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#manages"></see>
    /// </summary>
    let manages = _prefix "manages"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#origin"></see>
    /// </summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#participatesIn"></see>
    /// </summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#producedBy"></see>
    /// </summary>
    let producedBy = _prefix "producedBy"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#produces"></see>
    /// </summary>
    let produces = _prefix "produces"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#providesManagementContext"></see>
    /// </summary>
    let providesManagementContext = _prefix "providesManagementContext"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#queries"></see>
    /// </summary>
    let queries = _prefix "queries"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersTo"></see>
    /// </summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersToEntity"></see>
    /// </summary>
    let refersToEntity = _prefix "refersToEntity"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersToPayload"></see>
    /// </summary>
    let refersToPayload = _prefix "refersToPayload"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#representedAs"></see>
    /// </summary>
    let representedAs = _prefix "representedAs"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#returnsResultSetSpecifiedIn"></see>
    /// </summary>
    let returnsResultSetSpecifiedIn = _prefix "returnsResultSetSpecifiedIn"
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#worksFor"></see>
    /// </summary>
    let worksFor = _prefix "worksFor"
