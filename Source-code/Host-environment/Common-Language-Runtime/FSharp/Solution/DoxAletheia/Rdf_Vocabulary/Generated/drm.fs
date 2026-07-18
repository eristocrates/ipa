namespace http.vocab.data.gov.def.drm.hash

open DoxAletheia.Rdf_Vocabulary

module drm =
    let _namespace_name = "http://vocab.data.gov/def/drm#"
    /// <summary>
    /// Example: The “SSN” Attribute of a “Person” Entity may have a Data Type of “string” (if hyphens are included with the SSN) or “integer” (if hyphens are not included).
    /// <see href="http://vocab.data.gov/def/drm#Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    /// An entity (person or organization) that consumes data that is supplied by a Supplier.
    /// <see href="http://vocab.data.gov/def/drm#Consumer"></see></summary>
    let Consumer = Namespaced_IRI.parse _namespace_name "Consumer" |> NamespacedName
    /// <summary>
    /// Requests for data services, such as a query of a Data Asset.  These requests are supported by Data Access Services
    /// <see href="http://vocab.data.gov/def/drm#DataAccess"></see></summary>
    let DataAccess = Namespaced_IRI.parse _namespace_name "DataAccess" |> NamespacedName
    /// <summary>
    /// The term “data asset” is synonymous with “data source”
    /// <see href="http://vocab.data.gov/def/drm#DataAsset"></see></summary>
    let DataAsset = Namespaced_IRI.parse _namespace_name "DataAsset" |> NamespacedName
    /// <summary>
    /// A representation of metadata, often in the form of data artifacts such as logical data models or conceptual data models. The Data Schema concept group is comprised of those concepts pertaining to the representation of structured data. A Data Schema provides a means to provision data sharing services that is independent of the values of the data in the data resource that it describes.
    /// <see href="http://vocab.data.gov/def/drm#DataSchema"></see></summary>
    let DataSchema = Namespaced_IRI.parse _namespace_name "DataSchema" |> NamespacedName

    /// <summary>
    /// A Digital Data Resource containing structured data. This data can be accessed in a uniform manner, independent of data values, once the Data Schema is known.
    /// <see href="http://vocab.data.gov/def/drm#StructuredDataResource"></see></summary>
    let StructuredDataResource =
        Namespaced_IRI.parse _namespace_name "StructuredDataResource" |> NamespacedName

    /// <summary>
    /// A person responsible for managing a Data Asset.
    /// <see href="http://vocab.data.gov/def/drm#DataSteward"></see></summary>
    let DataSteward =
        Namespaced_IRI.parse _namespace_name "DataSteward" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// A constraint on the type of data that an instance of an Attribute may hold (e.g. "string" or "integer").
    /// <see href="http://vocab.data.gov/def/drm#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

    /// <summary>
    /// A digital container of information, typically known as a file. A Digital Data Resource may be one of three specific types of data resources, each corresponding to one of the three types of data described earlier, and each described below (see “Structured Data Resource”, “Semi-Structured Data Resource”, and “Unstructured Data Resource”). It will be a container for the metadata about the data resource.
    /// <see href="http://vocab.data.gov/def/drm#DigitalDataResource"></see></summary>
    let DigitalDataResource =
        Namespaced_IRI.parse _namespace_name "DigitalDataResource" |> NamespacedName

    /// <summary>
    /// While a Document can contain structured data, it normally has explanatory material included, which would cause it to therefore be considered semi-structured.  It is for this reason that there is no “contains” relationship from Document to Structured Data Resource. It is very important to separate Documents from Structured Data Resources because they are processed very differently. The difference between a Document and a Digital Data Resource, therefore, is that a Digital Data Resource can contained structured data.
    /// <see href="http://vocab.data.gov/def/drm#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// An abstraction for a person, place, object, event, or concept described (or characterized) by common Attributes. For example, “Person” and “Agency” are Entities. An instance of an Entity represents one particular occurrence of the Entity, such as a specific person or a specific agency.
    /// <see href="http://vocab.data.gov/def/drm#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    /// A description of a specific recurring data exchange between a Supplier and a Consumer. An Exchange Package contains information (metadata) relating to the exchange (such as Supplier ID, Consumer ID, validity period for data, etc.), as well as a reference to the Payload (message content) for the exchange. An Exchange Package can also be used to define the result format for a query that is accepted and processed by a Query Point in a data sharing scenario.
    /// <see href="http://vocab.data.gov/def/drm#ExchangePackage"></see></summary>
    let ExchangePackage =
        Namespaced_IRI.parse _namespace_name "ExchangePackage" |> NamespacedName

    /// <summary>
    /// This is a schema not described using DRM built-in concepts, but just pointed to. For example, XML Schema file
    /// <see href="http://vocab.data.gov/def/drm#ExternalDataSchema"></see></summary>
    let ExternalDataSchema =
        Namespaced_IRI.parse _namespace_name "ExternalDataSchema" |> NamespacedName

    /// <summary>
    /// This is the data schema described using DRM built-in concepts
    /// <see href="http://vocab.data.gov/def/drm#InternalDataSchema"></see></summary>
    let InternalDataSchema =
        Namespaced_IRI.parse _namespace_name "InternalDataSchema" |> NamespacedName

    /// <summary>
    /// Example: A specific message set expressed as an XML schema or an EDI transaction set that contains information about a “Person” entity.
    /// <see href="http://vocab.data.gov/def/drm#PayloadDefinition"></see></summary>
    let PayloadDefinition =
        Namespaced_IRI.parse _namespace_name "PayloadDefinition" |> NamespacedName

    /// <summary>
    /// An endpoint that provides an interface for accessing and querying a Data Asset. A concrete representation of a Query Point may be a specific URL at which a query Web Service may be invoked.
    /// <see href="http://vocab.data.gov/def/drm#QueryPoint"></see></summary>
    let QueryPoint = Namespaced_IRI.parse _namespace_name "QueryPoint" |> NamespacedName

    /// <summary>
    /// Describes the relationship between two Entities.
    /// <see href="http://vocab.data.gov/def/drm#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// A Digital Data Resource containing semi-structured data. This will generally consist in part of structured data and in part of unstructured data.
    /// <see href="http://vocab.data.gov/def/drm#SemistructuredDataResource"></see></summary>
    let SemistructuredDataResource =
        Namespaced_IRI.parse _namespace_name "SemistructuredDataResource" |> NamespacedName

    /// <summary>
    /// The concept of managing a data resource
    /// <see href="http://vocab.data.gov/def/drm#Stewardship"></see></summary>
    let Stewardship =
        Namespaced_IRI.parse _namespace_name "Stewardship" |> NamespacedName

    /// <summary>
    /// An entity (person or organization) that supplies data to a Consumer.
    /// <see href="http://vocab.data.gov/def/drm#Supplier"></see></summary>
    let Supplier = Namespaced_IRI.parse _namespace_name "Supplier" |> NamespacedName
    /// <summary>
    /// A collection of controlled vocabulary terms organized into a hierarchical structure. Taxonomies provide a means for categorizing or classifying information within a reasonably well-defined associative structure, in which each term in a Taxonomy is in one or more parent/child (broader/narrower) relationships to other terms in the Taxonomy.
    /// <see href="http://vocab.data.gov/def/drm#Taxonomy"></see></summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName
    /// <summary>
    /// A category within a Taxonomy. A Topic is the central concept for applying context to data. For example, an agency may have a Taxonomy that represents their organizational structure. In such a Taxonomy, each role in the organizational structure (e.g. CIO) represents a Topic. Topic is often synonymous with “node”.
    /// <see href="http://vocab.data.gov/def/drm#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName

    /// <summary>
    /// A Digital Data Resource containing unstructured data. Unstructured data is collection of data values that are likely to be processed only by specialized application programs.
    /// <see href="http://vocab.data.gov/def/drm#UnstructuredDataResource"></see></summary>
    let UnstructuredDataResource =
        Namespaced_IRI.parse _namespace_name "UnstructuredDataResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#accesses"></see>
    /// </summary>
    let accesses = Namespaced_IRI.parse _namespace_name "accesses" |> NamespacedName
    /// <summary>
    /// Reference model acronym.
    /// <see href="http://vocab.data.gov/def/drm#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#categorizedBy"></see>
    /// </summary>
    let categorizedBy =
        Namespaced_IRI.parse _namespace_name "categorizedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#categorizes"></see>
    /// </summary>
    let categorizes =
        Namespaced_IRI.parse _namespace_name "categorizes" |> NamespacedName

    /// <summary>
    /// The security classification for an Exchange Package.
    /// <see href="http://vocab.data.gov/def/drm#classification"></see></summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#constrainedBy"></see>
    /// </summary>
    let constrainedBy =
        Namespaced_IRI.parse _namespace_name "constrainedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#defines"></see>
    /// </summary>
    let defines = Namespaced_IRI.parse _namespace_name "defines" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#destination"></see>
    /// </summary>
    let destination =
        Namespaced_IRI.parse _namespace_name "destination" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#relates"></see>
    /// </summary>
    let relates = Namespaced_IRI.parse _namespace_name "relates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#disseminatedTo"></see>
    /// </summary>
    let disseminatedTo =
        Namespaced_IRI.parse _namespace_name "disseminatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#employeeID"></see>
    /// </summary>
    let employeeID = Namespaced_IRI.parse _namespace_name "employeeID" |> NamespacedName
    /// <summary>
    /// The frequency at which the exchange occurs.
    /// <see href="http://vocab.data.gov/def/drm#frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName

    /// <summary>
    /// Designates whether or not the Data Asset supports or provides Geospatial data.
    /// <see href="http://vocab.data.gov/def/drm#geospatialEnabled"></see></summary>
    let geospatialEnabled =
        Namespaced_IRI.parse _namespace_name "geospatialEnabled" |> NamespacedName

    /// <summary>
    /// This relationship is not explicitly stated in the DRM document. It has been created because there was a need to connect the schema with the entities, relationships, etc.
    /// <see href="http://vocab.data.gov/def/drm#hasSchemaElement"></see></summary>
    let hasSchemaElement =
        Namespaced_IRI.parse _namespace_name "hasSchemaElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#hasStewardship"></see>
    /// </summary>
    let hasStewardship =
        Namespaced_IRI.parse _namespace_name "hasStewardship" |> NamespacedName

    /// <summary>
    /// The “Identifier” attribute is described at an abstract level in order to be consistent with the abstract nature of the reference model. Therefore, there are no references to aspects such as identifier uniqueness, representation format, or similar. Implementations based on the DRM will introduce such aspects as needed according to their requirements.
    /// <see href="http://vocab.data.gov/def/drm#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// The date that the Data Steward became associated with the Data Asset.
    /// <see href="http://vocab.data.gov/def/drm#initialDate"></see></summary>
    let initialDate =
        Namespaced_IRI.parse _namespace_name "initialDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#isElementOf"></see>
    /// </summary>
    let isElementOf =
        Namespaced_IRI.parse _namespace_name "isElementOf" |> NamespacedName

    /// <summary>
    /// This is a link to location of a digital resource
    /// <see href="http://vocab.data.gov/def/drm#locationPointer"></see></summary>
    let locationPointer =
        Namespaced_IRI.parse _namespace_name "locationPointer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#managedBy"></see>
    /// </summary>
    let managedBy = Namespaced_IRI.parse _namespace_name "managedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#manages"></see>
    /// </summary>
    let manages = Namespaced_IRI.parse _namespace_name "manages" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#origin"></see>
    /// </summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#producedBy"></see>
    /// </summary>
    let producedBy = Namespaced_IRI.parse _namespace_name "producedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#produces"></see>
    /// </summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#providesManagementContext"></see>
    /// </summary>
    let providesManagementContext =
        Namespaced_IRI.parse _namespace_name "providesManagementContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#queries"></see>
    /// </summary>
    let queries = Namespaced_IRI.parse _namespace_name "queries" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersTo"></see>
    /// </summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersToEntity"></see>
    /// </summary>
    let refersToEntity =
        Namespaced_IRI.parse _namespace_name "refersToEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#refersToPayload"></see>
    /// </summary>
    let refersToPayload =
        Namespaced_IRI.parse _namespace_name "refersToPayload" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#representedAs"></see>
    /// </summary>
    let representedAs =
        Namespaced_IRI.parse _namespace_name "representedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#returnsResultSetSpecifiedIn"></see>
    /// </summary>
    let returnsResultSetSpecifiedIn =
        Namespaced_IRI.parse _namespace_name "returnsResultSetSpecifiedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.data.gov/def/drm#worksFor"></see>
    /// </summary>
    let worksFor = Namespaced_IRI.parse _namespace_name "worksFor" |> NamespacedName
