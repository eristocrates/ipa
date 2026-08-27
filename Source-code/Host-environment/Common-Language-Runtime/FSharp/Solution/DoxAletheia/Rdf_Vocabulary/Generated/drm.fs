namespace http.vocab.data.gov.def.drm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module drm =
    let _namespace_iri = Namespace_Iri drm |> NamespaceIRI
    /// <summary>
    ///   <para>drm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#">http://vocab.data.gov/def/drm#</seealso>
    let _prefix_iri = Prefixed_Name(drm, "") |> PrefixedName
    /// <summary>
    ///   <para>drm:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Example: The “SSN” Attribute of a “Person” Entity may have a Data Type of “string” (if hyphens are included with the SSN) or “integer” (if hyphens are not included)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Attribute">http://vocab.data.gov/def/drm#Attribute</seealso>
    let Attribute = Prefixed_Name(drm, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>drm:Consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An entity (person or organization) that consumes data that is supplied by a Supplier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consumer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Consumer">http://vocab.data.gov/def/drm#Consumer</seealso>
    let Consumer = Prefixed_Name(drm, "Consumer") |> PrefixedName
    /// <summary>
    ///   <para>drm:DataAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Requests for data services, such as a query of a Data Asset.  These requests are supported by Data Access Services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DataAccess">http://vocab.data.gov/def/drm#DataAccess</seealso>
    let DataAccess = Prefixed_Name(drm, "DataAccess") |> PrefixedName
    /// <summary>
    ///   <para>drm:DataAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The term “data asset” is synonymous with “data source”"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DataAsset">http://vocab.data.gov/def/drm#DataAsset</seealso>
    let DataAsset = Prefixed_Name(drm, "DataAsset") |> PrefixedName
    /// <summary>
    ///   <para>drm:DataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A representation of metadata, often in the form of data artifacts such as logical data models or conceptual data models. The Data Schema concept group is comprised of those concepts pertaining to the representation of structured data. A Data Schema provides a means to provision data sharing services that is independent of the values of the data in the data resource that it describes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DataSchema">http://vocab.data.gov/def/drm#DataSchema</seealso>
    let DataSchema = Prefixed_Name(drm, "DataSchema") |> PrefixedName
    /// <summary>
    ///   <para>drm:DataSteward</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person responsible for managing a Data Asset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data steward"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DataSteward">http://vocab.data.gov/def/drm#DataSteward</seealso>
    let DataSteward = Prefixed_Name(drm, "DataSteward") |> PrefixedName
    /// <summary>
    ///   <para>drm:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A constraint on the type of data that an instance of an Attribute may hold (e.g. "string" or "integer")."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DataType">http://vocab.data.gov/def/drm#DataType</seealso>
    let DataType = Prefixed_Name(drm, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>drm:DigitalDataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A digital container of information, typically known as a file. A Digital Data Resource may be one of three specific types of data resources, each corresponding to one of the three types of data described earlier, and each described below (see “Structured Data Resource”, “Semi-Structured Data Resource”, and “Unstructured Data Resource”). It will be a container for the metadata about the data resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Digital data resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#DigitalDataResource">http://vocab.data.gov/def/drm#DigitalDataResource</seealso>
    let DigitalDataResource = Prefixed_Name(drm, "DigitalDataResource") |> PrefixedName
    /// <summary>
    ///   <para>drm:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"While a Document can contain structured data, it normally has explanatory material included, which would cause it to therefore be considered semi-structured.  It is for this reason that there is no “contains” relationship from Document to Structured Data Resource. It is very important to separate Documents from Structured Data Resources because they are processed very differently. The difference between a Document and a Digital Data Resource, therefore, is that a Digital Data Resource can contained structured data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Document">http://vocab.data.gov/def/drm#Document</seealso>
    let Document = Prefixed_Name(drm, "Document") |> PrefixedName
    /// <summary>
    ///   <para>drm:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstraction for a person, place, object, event, or concept described (or characterized) by common Attributes. For example, “Person” and “Agency” are Entities. An instance of an Entity represents one particular occurrence of the Entity, such as a specific person or a specific agency."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Entity">http://vocab.data.gov/def/drm#Entity</seealso>
    let Entity = Prefixed_Name(drm, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>drm:ExchangePackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A description of a specific recurring data exchange between a Supplier and a Consumer. An Exchange Package contains information (metadata) relating to the exchange (such as Supplier ID, Consumer ID, validity period for data, etc.), as well as a reference to the Payload (message content) for the exchange. An Exchange Package can also be used to define the result format for a query that is accepted and processed by a Query Point in a data sharing scenario."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exchange package"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#ExchangePackage">http://vocab.data.gov/def/drm#ExchangePackage</seealso>
    let ExchangePackage = Prefixed_Name(drm, "ExchangePackage") |> PrefixedName
    /// <summary>
    ///   <para>drm:ExternalDataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This is a schema not described using DRM built-in concepts, but just pointed to. For example, XML Schema file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"External data schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#ExternalDataSchema">http://vocab.data.gov/def/drm#ExternalDataSchema</seealso>
    let ExternalDataSchema = Prefixed_Name(drm, "ExternalDataSchema") |> PrefixedName
    /// <summary>
    ///   <para>drm:InternalDataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This is the data schema described using DRM built-in concepts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Internal data schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#InternalDataSchema">http://vocab.data.gov/def/drm#InternalDataSchema</seealso>
    let InternalDataSchema = Prefixed_Name(drm, "InternalDataSchema") |> PrefixedName
    /// <summary>
    ///   <para>drm:PayloadDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Example: A specific message set expressed as an XML schema or an EDI transaction set that contains information about a “Person” entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Payload definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#PayloadDefinition">http://vocab.data.gov/def/drm#PayloadDefinition</seealso>
    let PayloadDefinition = Prefixed_Name(drm, "PayloadDefinition") |> PrefixedName
    /// <summary>
    ///   <para>drm:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Person">http://vocab.data.gov/def/drm#Person</seealso>
    let Person = Prefixed_Name(drm, "Person") |> PrefixedName
    /// <summary>
    ///   <para>drm:QueryPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An endpoint that provides an interface for accessing and querying a Data Asset. A concrete representation of a Query Point may be a specific URL at which a query Web Service may be invoked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#QueryPoint">http://vocab.data.gov/def/drm#QueryPoint</seealso>
    let QueryPoint = Prefixed_Name(drm, "QueryPoint") |> PrefixedName
    /// <summary>
    ///   <para>drm:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the relationship between two Entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Relationship">http://vocab.data.gov/def/drm#Relationship</seealso>
    let Relationship = Prefixed_Name(drm, "Relationship") |> PrefixedName

    /// <summary>
    ///   <para>drm:SemistructuredDataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Digital Data Resource containing semi-structured data. This will generally consist in part of structured data and in part of unstructured data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semistructured data resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#SemistructuredDataResource">http://vocab.data.gov/def/drm#SemistructuredDataResource</seealso>
    let SemistructuredDataResource =
        Prefixed_Name(drm, "SemistructuredDataResource") |> PrefixedName

    /// <summary>
    ///   <para>drm:Stewardship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The concept of managing a data resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stewardship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Stewardship">http://vocab.data.gov/def/drm#Stewardship</seealso>
    let Stewardship = Prefixed_Name(drm, "Stewardship") |> PrefixedName

    /// <summary>
    ///   <para>drm:StructuredDataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Digital Data Resource containing structured data. This data can be accessed in a uniform manner, independent of data values, once the Data Schema is known."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Structured data resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#StructuredDataResource">http://vocab.data.gov/def/drm#StructuredDataResource</seealso>
    let StructuredDataResource =
        Prefixed_Name(drm, "StructuredDataResource") |> PrefixedName

    /// <summary>
    ///   <para>drm:Supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An entity (person or organization) that supplies data to a Consumer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Supplier">http://vocab.data.gov/def/drm#Supplier</seealso>
    let Supplier = Prefixed_Name(drm, "Supplier") |> PrefixedName
    /// <summary>
    ///   <para>drm:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of controlled vocabulary terms organized into a hierarchical structure. Taxonomies provide a means for categorizing or classifying information within a reasonably well-defined associative structure, in which each term in a Taxonomy is in one or more parent/child (broader/narrower) relationships to other terms in the Taxonomy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Taxonomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Taxonomy">http://vocab.data.gov/def/drm#Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(drm, "Taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>drm:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A category within a Taxonomy. A Topic is the central concept for applying context to data. For example, an agency may have a Taxonomy that represents their organizational structure. In such a Taxonomy, each role in the organizational structure (e.g. CIO) represents a Topic. Topic is often synonymous with “node”."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#Topic">http://vocab.data.gov/def/drm#Topic</seealso>
    let Topic = Prefixed_Name(drm, "Topic") |> PrefixedName

    /// <summary>
    ///   <para>drm:UnstructuredDataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Digital Data Resource containing unstructured data. Unstructured data is collection of data values that are likely to be processed only by specialized application programs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unstructured data resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#UnstructuredDataResource">http://vocab.data.gov/def/drm#UnstructuredDataResource</seealso>
    let UnstructuredDataResource =
        Prefixed_Name(drm, "UnstructuredDataResource") |> PrefixedName

    /// <summary>
    ///   <para>drm:accesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"accesses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#accesses">http://vocab.data.gov/def/drm#accesses</seealso>
    let accesses = Prefixed_Name(drm, "accesses") |> PrefixedName
    /// <summary>
    ///   <para>drm:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Reference model acronym."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"acronym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#acronym">http://vocab.data.gov/def/drm#acronym</seealso>
    let acronym = Prefixed_Name(drm, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>drm:categorizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"categorized by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#categorizedBy">http://vocab.data.gov/def/drm#categorizedBy</seealso>
    let categorizedBy = Prefixed_Name(drm, "categorizedBy") |> PrefixedName
    /// <summary>
    ///   <para>drm:categorizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"categorizes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#categorizes">http://vocab.data.gov/def/drm#categorizes</seealso>
    let categorizes = Prefixed_Name(drm, "categorizes") |> PrefixedName
    /// <summary>
    ///   <para>drm:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The security classification for an Exchange Package."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#classification">http://vocab.data.gov/def/drm#classification</seealso>
    let classification = Prefixed_Name(drm, "classification") |> PrefixedName
    /// <summary>
    ///   <para>drm:constrainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"constrained by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#constrainedBy">http://vocab.data.gov/def/drm#constrainedBy</seealso>
    let constrainedBy = Prefixed_Name(drm, "constrainedBy") |> PrefixedName
    /// <summary>
    ///   <para>drm:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#contains">http://vocab.data.gov/def/drm#contains</seealso>
    let contains = Prefixed_Name(drm, "contains") |> PrefixedName
    /// <summary>
    ///   <para>drm:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"defines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#defines">http://vocab.data.gov/def/drm#defines</seealso>
    let defines = Prefixed_Name(drm, "defines") |> PrefixedName
    /// <summary>
    ///   <para>drm:destination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"destination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#destination">http://vocab.data.gov/def/drm#destination</seealso>
    let destination = Prefixed_Name(drm, "destination") |> PrefixedName
    /// <summary>
    ///   <para>drm:disseminatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"disseminated to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#disseminatedTo">http://vocab.data.gov/def/drm#disseminatedTo</seealso>
    let disseminatedTo = Prefixed_Name(drm, "disseminatedTo") |> PrefixedName
    /// <summary>
    ///   <para>drm:employeeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"employee iD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#employeeID">http://vocab.data.gov/def/drm#employeeID</seealso>
    let employeeID = Prefixed_Name(drm, "employeeID") |> PrefixedName
    /// <summary>
    ///   <para>drm:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The frequency at which the exchange occurs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#frequency">http://vocab.data.gov/def/drm#frequency</seealso>
    let frequency = Prefixed_Name(drm, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>drm:geospatialEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Designates whether or not the Data Asset supports or provides Geospatial data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geospatial enabled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#geospatialEnabled">http://vocab.data.gov/def/drm#geospatialEnabled</seealso>
    let geospatialEnabled = Prefixed_Name(drm, "geospatialEnabled") |> PrefixedName
    /// <summary>
    ///   <para>drm:hasSchemaElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This relationship is not explicitly stated in the DRM document. It has been created because there was a need to connect the schema with the entities, relationships, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has schema element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#hasSchemaElement">http://vocab.data.gov/def/drm#hasSchemaElement</seealso>
    let hasSchemaElement = Prefixed_Name(drm, "hasSchemaElement") |> PrefixedName
    /// <summary>
    ///   <para>drm:hasStewardship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has stewardship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#hasStewardship">http://vocab.data.gov/def/drm#hasStewardship</seealso>
    let hasStewardship = Prefixed_Name(drm, "hasStewardship") |> PrefixedName
    /// <summary>
    ///   <para>drm:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The “Identifier” attribute is described at an abstract level in order to be consistent with the abstract nature of the reference model. Therefore, there are no references to aspects such as identifier uniqueness, representation format, or similar. Implementations based on the DRM will introduce such aspects as needed according to their requirements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#identifier">http://vocab.data.gov/def/drm#identifier</seealso>
    let identifier = Prefixed_Name(drm, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>drm:initialDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date that the Data Steward became associated with the Data Asset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initial date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#initialDate">http://vocab.data.gov/def/drm#initialDate</seealso>
    let initialDate = Prefixed_Name(drm, "initialDate") |> PrefixedName
    /// <summary>
    ///   <para>drm:isElementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is element of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#isElementOf">http://vocab.data.gov/def/drm#isElementOf</seealso>
    let isElementOf = Prefixed_Name(drm, "isElementOf") |> PrefixedName
    /// <summary>
    ///   <para>drm:locationPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This is a link to location of a digital resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"location pointer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#locationPointer">http://vocab.data.gov/def/drm#locationPointer</seealso>
    let locationPointer = Prefixed_Name(drm, "locationPointer") |> PrefixedName
    /// <summary>
    ///   <para>drm:managedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"managed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#managedBy">http://vocab.data.gov/def/drm#managedBy</seealso>
    let managedBy = Prefixed_Name(drm, "managedBy") |> PrefixedName
    /// <summary>
    ///   <para>drm:manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"manages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#manages">http://vocab.data.gov/def/drm#manages</seealso>
    let manages = Prefixed_Name(drm, "manages") |> PrefixedName
    /// <summary>
    ///   <para>drm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#name">http://vocab.data.gov/def/drm#name</seealso>
    let name = Prefixed_Name(drm, "name") |> PrefixedName
    /// <summary>
    ///   <para>drm:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#origin">http://vocab.data.gov/def/drm#origin</seealso>
    let origin = Prefixed_Name(drm, "origin") |> PrefixedName
    /// <summary>
    ///   <para>drm:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"participates in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#participatesIn">http://vocab.data.gov/def/drm#participatesIn</seealso>
    let participatesIn = Prefixed_Name(drm, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>drm:producedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"produced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#producedBy">http://vocab.data.gov/def/drm#producedBy</seealso>
    let producedBy = Prefixed_Name(drm, "producedBy") |> PrefixedName
    /// <summary>
    ///   <para>drm:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"produces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#produces">http://vocab.data.gov/def/drm#produces</seealso>
    let produces = Prefixed_Name(drm, "produces") |> PrefixedName

    /// <summary>
    ///   <para>drm:providesManagementContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"provides management context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#providesManagementContext">http://vocab.data.gov/def/drm#providesManagementContext</seealso>
    let providesManagementContext =
        Prefixed_Name(drm, "providesManagementContext") |> PrefixedName

    /// <summary>
    ///   <para>drm:queries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"queries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#queries">http://vocab.data.gov/def/drm#queries</seealso>
    let queries = Prefixed_Name(drm, "queries") |> PrefixedName
    /// <summary>
    ///   <para>drm:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"refers to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#refersTo">http://vocab.data.gov/def/drm#refersTo</seealso>
    let refersTo = Prefixed_Name(drm, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>drm:refersToEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"refers to entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#refersToEntity">http://vocab.data.gov/def/drm#refersToEntity</seealso>
    let refersToEntity = Prefixed_Name(drm, "refersToEntity") |> PrefixedName
    /// <summary>
    ///   <para>drm:refersToPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"refers to payload"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#refersToPayload">http://vocab.data.gov/def/drm#refersToPayload</seealso>
    let refersToPayload = Prefixed_Name(drm, "refersToPayload") |> PrefixedName
    /// <summary>
    ///   <para>drm:relates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"relates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#relates">http://vocab.data.gov/def/drm#relates</seealso>
    let relates = Prefixed_Name(drm, "relates") |> PrefixedName
    /// <summary>
    ///   <para>drm:representedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"represented as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#representedAs">http://vocab.data.gov/def/drm#representedAs</seealso>
    let representedAs = Prefixed_Name(drm, "representedAs") |> PrefixedName

    /// <summary>
    ///   <para>drm:returnsResultSetSpecifiedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"returns result set specified in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#returnsResultSetSpecifiedIn">http://vocab.data.gov/def/drm#returnsResultSetSpecifiedIn</seealso>
    let returnsResultSetSpecifiedIn =
        Prefixed_Name(drm, "returnsResultSetSpecifiedIn") |> PrefixedName

    /// <summary>
    ///   <para>drm:worksFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This specifies persons who are working or who worked for a brand or a business entity."</para>
    /// labels<para>"works for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/drm#worksFor">http://vocab.data.gov/def/drm#worksFor</seealso>
    let worksFor = Prefixed_Name(drm, "worksFor") |> PrefixedName
