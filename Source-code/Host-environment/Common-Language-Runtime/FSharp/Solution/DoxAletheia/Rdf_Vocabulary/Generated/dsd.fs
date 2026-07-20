namespace https.w3id.org.dsd.hash

open DoxAletheia

module dsd =
    let _namespace_name = "https://w3id.org/dsd#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Describes the relationship between an aggregation that is composed out of several components.
    /// <see href="https://w3id.org/dsd#AggregationAssociation"></see></summary>
    let AggregationAssociation = _prefix "AggregationAssociation"
    /// <summary>
    /// Describes the relationship between several child Concepts and their parent.
    /// <see href="https://w3id.org/dsd#InheritanceAssociation"></see></summary>
    let InheritanceAssociation = _prefix "InheritanceAssociation"
    /// <summary>
    /// Describes a regular relationship between two or more Concepts.
    /// <see href="https://w3id.org/dsd#ReferenceAssociation"></see></summary>
    let ReferenceAssociation = _prefix "ReferenceAssociation"
    /// <summary>
    ///  A dsd:Association describes a relationship between two instances of dsd:Concept. There are three dsd:Association subclasses for aggregation, inheritance, and reference associations.
    /// <see href="https://w3id.org/dsd#Association"></see></summary>
    let Association = _prefix "Association"
    /// <summary>
    /// An Attribute describes a property of a Concept. DSD also provides OWL data properties for the description of certain attribute characteristics, such as, nullable or unique.
    /// Example:  If a Concept represents a relational table, its attributes correspond to the columns.
    /// <see href="https://w3id.org/dsd#Attribute"></see></summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#CSV_File"></see>
    /// </summary>
    let CSV_File = _prefix "CSV_File"
    /// <summary>
    /// This class provides instances of the most common data source types, which can be assigned to instance of dsd:DataSource.
    /// <see href="https://w3id.org/dsd#DatasourceType"></see></summary>
    let DatasourceType = _prefix "DatasourceType"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Completeness"></see>
    /// </summary>
    let Completeness = _prefix "Completeness"
    /// <summary>
    /// A representation of a structural part of a data source.
    /// Example: A dsd:Concept can represent a table or a view of a relational database or a class in object-oriented structures.
    /// <see href="https://w3id.org/dsd#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// Connects an Association or an Concept with it primary key.
    /// <see href="https://w3id.org/dsd#hasPrimaryKey"></see></summary>
    let hasPrimaryKey = _prefix "hasPrimaryKey"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Correctness"></see>
    /// </summary>
    let Correctness = _prefix "Correctness"
    /// <summary>
    /// A generic class for representing data sources.
    ///                Example: A dsd:DataSource can represent structured data such as relational databases, semi-structured data like XML files, or NoSQL databases such as graph databases or wide-column stores. A dsd:DataSource can be assigned to an instance of dsd:DataSourceType.
    /// <see href="https://w3id.org/dsd#Datasource"></see></summary>
    let Datasource = _prefix "Datasource"
    /// <summary>
    /// References to a Primary key and consists of one or more Attributes.
    /// <see href="https://w3id.org/dsd#ForeignKey"></see></summary>
    let ForeignKey = _prefix "ForeignKey"
    /// <summary>
    /// Identifies a Concept and consists of one or more Attributes.
    /// <see href="https://w3id.org/dsd#PrimaryKey"></see></summary>
    let PrimaryKey = _prefix "PrimaryKey"
    /// <summary>
    /// Instances of dsd:Schema provide an optional hierarchy level between an instance of dsd:DataSource and instances of dsd:Concept. Schemas allow the grouping of concepts and are very common in enterprise databases.
    /// <see href="https://w3id.org/dsd#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Excel_Sheet"></see>
    /// </summary>
    let Excel_Sheet = _prefix "Excel_Sheet"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Minimality"></see>
    /// </summary>
    let Minimality = _prefix "Minimality"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#NoSQL_DB"></see>
    /// </summary>
    let NoSQL_DB = _prefix "NoSQL_DB"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#OO_DB"></see>
    /// </summary>
    let OO_DB = _prefix "OO_DB"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Pertinence"></see>
    /// </summary>
    let Pertinence = _prefix "Pertinence"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#PlainText"></see>
    /// </summary>
    let PlainText = _prefix "PlainText"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#RDF_Store"></see>
    /// </summary>
    let RDF_Store = _prefix "RDF_Store"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#Relational_DB"></see>
    /// </summary>
    let Relational_DB = _prefix "Relational_DB"
    /// <summary>
    ///   <see href="https://w3id.org/dsd#XML_File"></see>
    /// </summary>
    let XML_File = _prefix "XML_File"
    /// <summary>
    /// Gives a value of the average (character) length of instances of this concept. E.g., row entries in a MySQL DB.
    /// <see href="https://w3id.org/dsd#avgInstanceLength"></see></summary>
    let avgInstanceLength = _prefix "avgInstanceLength"
    /// <summary>
    /// Provides annotations for a concept.
    /// <see href="https://w3id.org/dsd#hasConceptDescriptor"></see></summary>
    let hasConceptDescriptor = _prefix "hasConceptDescriptor"
    /// <summary>
    /// A Primary or Foreign Key consists of one or several Attributes.
    /// <see href="https://w3id.org/dsd#consistsOfAttribute"></see></summary>
    let consistsOfAttribute = _prefix "consistsOfAttribute"
    /// <summary>
    /// Describes the constraint that is defined on a foreign key, which action should be carried out if the referenced primary key is deleted.
    /// <see href="https://w3id.org/dsd#constraintOnDelete"></see></summary>
    let constraintOnDelete = _prefix "constraintOnDelete"
    /// <summary>
    /// Foreign key descriptor: A textual description of what should happen if the reference of this foreign key is modified (updated/deleted).
    /// <see href="https://w3id.org/dsd#hasFKDescriptor"></see></summary>
    let hasFKDescriptor = _prefix "hasFKDescriptor"
    /// <summary>
    /// Describes which constraint is defined on a foreign key if the referenced primary key content is updated.
    /// <see href="https://w3id.org/dsd#constraintOnUpdate"></see></summary>
    let constraintOnUpdate = _prefix "constraintOnUpdate"
    /// <summary>
    /// Provides an default value for an attribute.
    /// <see href="https://w3id.org/dsd#defaultValue"></see></summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// Provides annotations for an attribute.
    /// <see href="https://w3id.org/dsd#hasAttributeDescriptor"></see></summary>
    let hasAttributeDescriptor = _prefix "hasAttributeDescriptor"
    /// <summary>
    /// Describes the connection between an AggregationAssociation and its Aggregation.
    /// <see href="https://w3id.org/dsd#hasAggregation"></see></summary>
    let hasAggregation = _prefix "hasAggregation"
    /// <summary>
    /// Describes the edges from an Association to its Members (Parent, Child, Aggregation, Component).
    /// <see href="https://w3id.org/dsd#hasAssociationMember"></see></summary>
    let hasAssociationMember = _prefix "hasAssociationMember"
    /// <summary>
    /// Describes the connection between an AggregationAssociation and one of its components.
    /// <see href="https://w3id.org/dsd#hasAggregationComponent"></see></summary>
    let hasAggregationComponent = _prefix "hasAggregationComponent"
    /// <summary>
    /// Provides annotations for an association.
    /// <see href="https://w3id.org/dsd#hasAssociationDescriptor"></see></summary>
    let hasAssociationDescriptor = _prefix "hasAssociationDescriptor"
    /// <summary>
    /// Describes the number of Attributes a Concept or Association comprises.
    /// <see href="https://w3id.org/dsd#hasAttribute"></see></summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    /// Describes an Attributes's connection to its Concept or Association.
    /// <see href="https://w3id.org/dsd#isAttributeOf"></see></summary>
    let isAttributeOf = _prefix "isAttributeOf"
    /// <summary>
    /// Describes the connection between an InheritanceAssociation and one of its childs.
    /// <see href="https://w3id.org/dsd#hasChild"></see></summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    /// Describes the number of components a Datasource comprises.
    /// <see href="https://w3id.org/dsd#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// Describes a components connection to its Datasource.
    /// <see href="https://w3id.org/dsd#isComponentOf"></see></summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    /// Connects an Association or an Concept with its foreign key.
    /// <see href="https://w3id.org/dsd#hasForeignKey"></see></summary>
    let hasForeignKey = _prefix "hasForeignKey"
    /// <summary>
    /// Describes the connection between an InheritanceAssociation and a parent Concept.
    /// <see href="https://w3id.org/dsd#hasParent"></see></summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    /// Describes the schemas a data source may consist of.
    /// <see href="https://w3id.org/dsd#hasSchema"></see></summary>
    let hasSchema = _prefix "hasSchema"
    /// <summary>
    /// Describes to which data source a schema belongs to.
    /// <see href="https://w3id.org/dsd#isSchemaOf"></see></summary>
    let isSchemaOf = _prefix "isSchemaOf"
    /// <summary>
    /// If the attribute automatically increments on a new insertion of a new value.
    /// <see href="https://w3id.org/dsd#isAutoIncrement"></see></summary>
    let isAutoIncrement = _prefix "isAutoIncrement"
    /// <summary>
    /// Defines whether an inheritance association is complete. If property is set to FALSE, the association is incomplete.
    /// <see href="https://w3id.org/dsd#isComplete"></see></summary>
    let isComplete = _prefix "isComplete"
    /// <summary>
    /// Describes whether the children of an inheritance association are disjoint. If property is set to FALSE, the children are overlapping.
    /// <see href="https://w3id.org/dsd#isDisjoint"></see></summary>
    let isDisjoint = _prefix "isDisjoint"
    /// <summary>
    /// If the attribute can contain NULL values.
    /// <see href="https://w3id.org/dsd#isNullable"></see></summary>
    let isNullable = _prefix "isNullable"
    /// <summary>
    /// Describes an Attribute with an XLS Datatype.
    /// <see href="https://w3id.org/dsd#isOfDataType"></see></summary>
    let isOfDataType = _prefix "isOfDataType"
    /// <summary>
    /// Describes the type of a Data Source. This vocabulary provides some Individuals that can be used.
    /// <see href="https://w3id.org/dsd#isOfDatasourceType"></see></summary>
    let isOfDatasourceType = _prefix "isOfDatasourceType"
    /// <summary>
    /// Describes if an attribute is unique or not.
    /// <see href="https://w3id.org/dsd#isUnique"></see></summary>
    let isUnique = _prefix "isUnique"
    /// <summary>
    /// Maximum character length of this attribute, given in the number of bits.
    /// <see href="https://w3id.org/dsd#maxCharacterLength"></see></summary>
    let maxCharacterLength = _prefix "maxCharacterLength"
    /// <summary>
    /// Number of instances of a concept/association.
    /// <see href="https://w3id.org/dsd#noOfInstances"></see></summary>
    let noOfInstances = _prefix "noOfInstances"
    /// <summary>
    /// The ordinal position of the attribute to the concept, this information might not always be available (depending on the data source).
    /// <see href="https://w3id.org/dsd#ordinalPosition"></see></summary>
    let ordinalPosition = _prefix "ordinalPosition"
    /// <summary>
    /// A PrimaryKey, Concept or any kind of Association references to another Concept, ForeignKey or Association.
    /// <see href="https://w3id.org/dsd#referencesTo"></see></summary>
    let referencesTo = _prefix "referencesTo"
