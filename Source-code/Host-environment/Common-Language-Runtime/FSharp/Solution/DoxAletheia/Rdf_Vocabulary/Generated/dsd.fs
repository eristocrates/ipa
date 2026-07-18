namespace https.w3id.org.dsd.hash

open DoxAletheia.Rdf_Vocabulary

module dsd =
    let _namespace_name = "https://w3id.org/dsd#"

    /// <summary>
    /// Describes the relationship between an aggregation that is composed out of several components.
    /// <see href="https://w3id.org/dsd#AggregationAssociation"></see></summary>
    let AggregationAssociation =
        Namespaced_IRI.parse _namespace_name "AggregationAssociation" |> NamespacedName

    /// <summary>
    /// Describes the relationship between several child Concepts and their parent.
    /// <see href="https://w3id.org/dsd#InheritanceAssociation"></see></summary>
    let InheritanceAssociation =
        Namespaced_IRI.parse _namespace_name "InheritanceAssociation" |> NamespacedName

    /// <summary>
    /// Describes a regular relationship between two or more Concepts.
    /// <see href="https://w3id.org/dsd#ReferenceAssociation"></see></summary>
    let ReferenceAssociation =
        Namespaced_IRI.parse _namespace_name "ReferenceAssociation" |> NamespacedName

    /// <summary>
    ///  A dsd:Association describes a relationship between two instances of dsd:Concept. There are three dsd:Association subclasses for aggregation, inheritance, and reference associations.
    /// <see href="https://w3id.org/dsd#Association"></see></summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    /// An Attribute describes a property of a Concept. DSD also provides OWL data properties for the description of certain attribute characteristics, such as, nullable or unique.
    /// Example:  If a Concept represents a relational table, its attributes correspond to the columns.
    /// <see href="https://w3id.org/dsd#Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#CSV_File"></see>
    /// </summary>
    let CSV_File = Namespaced_IRI.parse _namespace_name "CSV_File" |> NamespacedName

    /// <summary>
    /// This class provides instances of the most common data source types, which can be assigned to instance of dsd:DataSource.
    /// <see href="https://w3id.org/dsd#DatasourceType"></see></summary>
    let DatasourceType =
        Namespaced_IRI.parse _namespace_name "DatasourceType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#Completeness"></see>
    /// </summary>
    let Completeness =
        Namespaced_IRI.parse _namespace_name "Completeness" |> NamespacedName

    /// <summary>
    /// A representation of a structural part of a data source.
    /// Example: A dsd:Concept can represent a table or a view of a relational database or a class in object-oriented structures.
    /// <see href="https://w3id.org/dsd#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// Connects an Association or an Concept with it primary key.
    /// <see href="https://w3id.org/dsd#hasPrimaryKey"></see></summary>
    let hasPrimaryKey =
        Namespaced_IRI.parse _namespace_name "hasPrimaryKey" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#Correctness"></see>
    /// </summary>
    let Correctness =
        Namespaced_IRI.parse _namespace_name "Correctness" |> NamespacedName

    /// <summary>
    /// A generic class for representing data sources.
    ///                Example: A dsd:DataSource can represent structured data such as relational databases, semi-structured data like XML files, or NoSQL databases such as graph databases or wide-column stores. A dsd:DataSource can be assigned to an instance of dsd:DataSourceType.
    /// <see href="https://w3id.org/dsd#Datasource"></see></summary>
    let Datasource = Namespaced_IRI.parse _namespace_name "Datasource" |> NamespacedName
    /// <summary>
    /// References to a Primary key and consists of one or more Attributes.
    /// <see href="https://w3id.org/dsd#ForeignKey"></see></summary>
    let ForeignKey = Namespaced_IRI.parse _namespace_name "ForeignKey" |> NamespacedName
    /// <summary>
    /// Identifies a Concept and consists of one or more Attributes.
    /// <see href="https://w3id.org/dsd#PrimaryKey"></see></summary>
    let PrimaryKey = Namespaced_IRI.parse _namespace_name "PrimaryKey" |> NamespacedName
    /// <summary>
    /// Instances of dsd:Schema provide an optional hierarchy level between an instance of dsd:DataSource and instances of dsd:Concept. Schemas allow the grouping of concepts and are very common in enterprise databases.
    /// <see href="https://w3id.org/dsd#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#Excel_Sheet"></see>
    /// </summary>
    let Excel_Sheet =
        Namespaced_IRI.parse _namespace_name "Excel_Sheet" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#Minimality"></see>
    /// </summary>
    let Minimality = Namespaced_IRI.parse _namespace_name "Minimality" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#NoSQL_DB"></see>
    /// </summary>
    let NoSQL_DB = Namespaced_IRI.parse _namespace_name "NoSQL_DB" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#OO_DB"></see>
    /// </summary>
    let OO_DB = Namespaced_IRI.parse _namespace_name "OO_DB" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Pertinence"></see>
    /// </summary>
    let Pertinence = Namespaced_IRI.parse _namespace_name "Pertinence" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#PlainText"></see>
    /// </summary>
    let PlainText = Namespaced_IRI.parse _namespace_name "PlainText" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsd#RDF_Store"></see>
    /// </summary>
    let RDF_Store = Namespaced_IRI.parse _namespace_name "RDF_Store" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#Relational_DB"></see>
    /// </summary>
    let Relational_DB =
        Namespaced_IRI.parse _namespace_name "Relational_DB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsd#XML_File"></see>
    /// </summary>
    let XML_File = Namespaced_IRI.parse _namespace_name "XML_File" |> NamespacedName

    /// <summary>
    /// Gives a value of the average (character) length of instances of this concept. E.g., row entries in a MySQL DB.
    /// <see href="https://w3id.org/dsd#avgInstanceLength"></see></summary>
    let avgInstanceLength =
        Namespaced_IRI.parse _namespace_name "avgInstanceLength" |> NamespacedName

    /// <summary>
    /// Provides annotations for a concept.
    /// <see href="https://w3id.org/dsd#hasConceptDescriptor"></see></summary>
    let hasConceptDescriptor =
        Namespaced_IRI.parse _namespace_name "hasConceptDescriptor" |> NamespacedName

    /// <summary>
    /// A Primary or Foreign Key consists of one or several Attributes.
    /// <see href="https://w3id.org/dsd#consistsOfAttribute"></see></summary>
    let consistsOfAttribute =
        Namespaced_IRI.parse _namespace_name "consistsOfAttribute" |> NamespacedName

    /// <summary>
    /// Describes the constraint that is defined on a foreign key, which action should be carried out if the referenced primary key is deleted.
    /// <see href="https://w3id.org/dsd#constraintOnDelete"></see></summary>
    let constraintOnDelete =
        Namespaced_IRI.parse _namespace_name "constraintOnDelete" |> NamespacedName

    /// <summary>
    /// Foreign key descriptor: A textual description of what should happen if the reference of this foreign key is modified (updated/deleted).
    /// <see href="https://w3id.org/dsd#hasFKDescriptor"></see></summary>
    let hasFKDescriptor =
        Namespaced_IRI.parse _namespace_name "hasFKDescriptor" |> NamespacedName

    /// <summary>
    /// Describes which constraint is defined on a foreign key if the referenced primary key content is updated.
    /// <see href="https://w3id.org/dsd#constraintOnUpdate"></see></summary>
    let constraintOnUpdate =
        Namespaced_IRI.parse _namespace_name "constraintOnUpdate" |> NamespacedName

    /// <summary>
    /// Provides an default value for an attribute.
    /// <see href="https://w3id.org/dsd#defaultValue"></see></summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    /// Provides annotations for an attribute.
    /// <see href="https://w3id.org/dsd#hasAttributeDescriptor"></see></summary>
    let hasAttributeDescriptor =
        Namespaced_IRI.parse _namespace_name "hasAttributeDescriptor" |> NamespacedName

    /// <summary>
    /// Describes the connection between an AggregationAssociation and its Aggregation.
    /// <see href="https://w3id.org/dsd#hasAggregation"></see></summary>
    let hasAggregation =
        Namespaced_IRI.parse _namespace_name "hasAggregation" |> NamespacedName

    /// <summary>
    /// Describes the edges from an Association to its Members (Parent, Child, Aggregation, Component).
    /// <see href="https://w3id.org/dsd#hasAssociationMember"></see></summary>
    let hasAssociationMember =
        Namespaced_IRI.parse _namespace_name "hasAssociationMember" |> NamespacedName

    /// <summary>
    /// Describes the connection between an AggregationAssociation and one of its components.
    /// <see href="https://w3id.org/dsd#hasAggregationComponent"></see></summary>
    let hasAggregationComponent =
        Namespaced_IRI.parse _namespace_name "hasAggregationComponent" |> NamespacedName

    /// <summary>
    /// Provides annotations for an association.
    /// <see href="https://w3id.org/dsd#hasAssociationDescriptor"></see></summary>
    let hasAssociationDescriptor =
        Namespaced_IRI.parse _namespace_name "hasAssociationDescriptor" |> NamespacedName

    /// <summary>
    /// Describes the number of Attributes a Concept or Association comprises.
    /// <see href="https://w3id.org/dsd#hasAttribute"></see></summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    /// Describes an Attributes's connection to its Concept or Association.
    /// <see href="https://w3id.org/dsd#isAttributeOf"></see></summary>
    let isAttributeOf =
        Namespaced_IRI.parse _namespace_name "isAttributeOf" |> NamespacedName

    /// <summary>
    /// Describes the connection between an InheritanceAssociation and one of its childs.
    /// <see href="https://w3id.org/dsd#hasChild"></see></summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName

    /// <summary>
    /// Describes the number of components a Datasource comprises.
    /// <see href="https://w3id.org/dsd#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// Describes a components connection to its Datasource.
    /// <see href="https://w3id.org/dsd#isComponentOf"></see></summary>
    let isComponentOf =
        Namespaced_IRI.parse _namespace_name "isComponentOf" |> NamespacedName

    /// <summary>
    /// Connects an Association or an Concept with its foreign key.
    /// <see href="https://w3id.org/dsd#hasForeignKey"></see></summary>
    let hasForeignKey =
        Namespaced_IRI.parse _namespace_name "hasForeignKey" |> NamespacedName

    /// <summary>
    /// Describes the connection between an InheritanceAssociation and a parent Concept.
    /// <see href="https://w3id.org/dsd#hasParent"></see></summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName
    /// <summary>
    /// Describes the schemas a data source may consist of.
    /// <see href="https://w3id.org/dsd#hasSchema"></see></summary>
    let hasSchema = Namespaced_IRI.parse _namespace_name "hasSchema" |> NamespacedName
    /// <summary>
    /// Describes to which data source a schema belongs to.
    /// <see href="https://w3id.org/dsd#isSchemaOf"></see></summary>
    let isSchemaOf = Namespaced_IRI.parse _namespace_name "isSchemaOf" |> NamespacedName

    /// <summary>
    /// If the attribute automatically increments on a new insertion of a new value.
    /// <see href="https://w3id.org/dsd#isAutoIncrement"></see></summary>
    let isAutoIncrement =
        Namespaced_IRI.parse _namespace_name "isAutoIncrement" |> NamespacedName

    /// <summary>
    /// Defines whether an inheritance association is complete. If property is set to FALSE, the association is incomplete.
    /// <see href="https://w3id.org/dsd#isComplete"></see></summary>
    let isComplete = Namespaced_IRI.parse _namespace_name "isComplete" |> NamespacedName
    /// <summary>
    /// Describes whether the children of an inheritance association are disjoint. If property is set to FALSE, the children are overlapping.
    /// <see href="https://w3id.org/dsd#isDisjoint"></see></summary>
    let isDisjoint = Namespaced_IRI.parse _namespace_name "isDisjoint" |> NamespacedName
    /// <summary>
    /// If the attribute can contain NULL values.
    /// <see href="https://w3id.org/dsd#isNullable"></see></summary>
    let isNullable = Namespaced_IRI.parse _namespace_name "isNullable" |> NamespacedName

    /// <summary>
    /// Describes an Attribute with an XLS Datatype.
    /// <see href="https://w3id.org/dsd#isOfDataType"></see></summary>
    let isOfDataType =
        Namespaced_IRI.parse _namespace_name "isOfDataType" |> NamespacedName

    /// <summary>
    /// Describes the type of a Data Source. This vocabulary provides some Individuals that can be used.
    /// <see href="https://w3id.org/dsd#isOfDatasourceType"></see></summary>
    let isOfDatasourceType =
        Namespaced_IRI.parse _namespace_name "isOfDatasourceType" |> NamespacedName

    /// <summary>
    /// Describes if an attribute is unique or not.
    /// <see href="https://w3id.org/dsd#isUnique"></see></summary>
    let isUnique = Namespaced_IRI.parse _namespace_name "isUnique" |> NamespacedName

    /// <summary>
    /// Maximum character length of this attribute, given in the number of bits.
    /// <see href="https://w3id.org/dsd#maxCharacterLength"></see></summary>
    let maxCharacterLength =
        Namespaced_IRI.parse _namespace_name "maxCharacterLength" |> NamespacedName

    /// <summary>
    /// Number of instances of a concept/association.
    /// <see href="https://w3id.org/dsd#noOfInstances"></see></summary>
    let noOfInstances =
        Namespaced_IRI.parse _namespace_name "noOfInstances" |> NamespacedName

    /// <summary>
    /// The ordinal position of the attribute to the concept, this information might not always be available (depending on the data source).
    /// <see href="https://w3id.org/dsd#ordinalPosition"></see></summary>
    let ordinalPosition =
        Namespaced_IRI.parse _namespace_name "ordinalPosition" |> NamespacedName

    /// <summary>
    /// A PrimaryKey, Concept or any kind of Association references to another Concept, ForeignKey or Association.
    /// <see href="https://w3id.org/dsd#referencesTo"></see></summary>
    let referencesTo =
        Namespaced_IRI.parse _namespace_name "referencesTo" |> NamespacedName
