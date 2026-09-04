#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dsd =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dsd#" "dsd"
    /// <summary>
    ///   <para>rdfs:label : Aggregation association</para>
    ///   <para>rdfs:comment : Describes the relationship between an aggregation that is composed out of several components.</para>
    ///   <a href="https://w3id.org/dsd#AggregationAssociation">dsd:AggregationAssociation</a>
    /// </summary>
    let AggregationAssociation = _prefixId.prefix "AggregationAssociation"
    /// <summary>
    ///   <para>rdfs:label : Association</para>
    ///   <para>rdfs:comment :  A dsd:Association describes a relationship between two instances of dsd:Concept. There are three dsd:Association subclasses for aggregation, inheritance, and reference associations.</para>
    ///   <a href="https://w3id.org/dsd#Association">dsd:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>rdfs:label : Attribute</para>
    ///   <para>rdfs:comment : An Attribute describes a property of a Concept. DSD also provides OWL data properties for the description of certain attribute characteristics, such as, nullable or unique.
    /// Example:  If a Concept represents a relational table, its attributes correspond to the columns.</para>
    ///   <a href="https://w3id.org/dsd#Attribute">dsd:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    let CSV_File = _prefixId.prefix "CSV_File"
    let Completeness = _prefixId.prefix "Completeness"
    /// <summary>
    ///   <para>rdfs:label : Concept</para>
    ///   <para>rdfs:comment : A representation of a structural part of a data source.
    /// Example: A dsd:Concept can represent a table or a view of a relational database or a class in object-oriented structures.</para>
    ///   <a href="https://w3id.org/dsd#Concept">dsd:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    let Correctness = _prefixId.prefix "Correctness"
    /// <summary>
    ///   <para>rdfs:label : Data source</para>
    ///   <para>rdfs:comment : A generic class for representing data sources.
    ///                Example: A dsd:DataSource can represent structured data such as relational databases, semi-structured data like XML files, or NoSQL databases such as graph databases or wide-column stores. A dsd:DataSource can be assigned to an instance of dsd:DataSourceType.</para>
    ///   <a href="https://w3id.org/dsd#Datasource">dsd:Datasource</a>
    /// </summary>
    let Datasource = _prefixId.prefix "Datasource"
    /// <summary>
    ///   <para>rdfs:label : Data source type</para>
    ///   <para>rdfs:comment : This class provides instances of the most common data source types, which can be assigned to instance of dsd:DataSource.</para>
    ///   <a href="https://w3id.org/dsd#DatasourceType">dsd:DatasourceType</a>
    /// </summary>
    let DatasourceType = _prefixId.prefix "DatasourceType"
    let Excel_Sheet = _prefixId.prefix "Excel_Sheet"
    /// <summary>
    ///   <para>rdfs:label : Foreign key</para>
    ///   <para>rdfs:comment : References to a Primary key and consists of one or more Attributes.</para>
    ///   <a href="https://w3id.org/dsd#ForeignKey">dsd:ForeignKey</a>
    /// </summary>
    let ForeignKey = _prefixId.prefix "ForeignKey"
    /// <summary>
    ///   <para>rdfs:label : Inheritance association</para>
    ///   <para>rdfs:comment : Describes the relationship between several child Concepts and their parent.</para>
    ///   <a href="https://w3id.org/dsd#InheritanceAssociation">dsd:InheritanceAssociation</a>
    /// </summary>
    let InheritanceAssociation = _prefixId.prefix "InheritanceAssociation"
    let Minimality = _prefixId.prefix "Minimality"
    let NoSQL_DB = _prefixId.prefix "NoSQL_DB"
    let OO_DB = _prefixId.prefix "OO_DB"
    let Pertinence = _prefixId.prefix "Pertinence"
    let PlainText = _prefixId.prefix "PlainText"
    /// <summary>
    ///   <para>rdfs:label : Primary key</para>
    ///   <para>rdfs:comment : Identifies a Concept and consists of one or more Attributes.</para>
    ///   <a href="https://w3id.org/dsd#PrimaryKey">dsd:PrimaryKey</a>
    /// </summary>
    let PrimaryKey = _prefixId.prefix "PrimaryKey"
    let RDF_Store = _prefixId.prefix "RDF_Store"
    /// <summary>
    ///   <para>rdfs:label : Reference association</para>
    ///   <para>rdfs:comment : Describes a regular relationship between two or more Concepts.</para>
    ///   <a href="https://w3id.org/dsd#ReferenceAssociation">dsd:ReferenceAssociation</a>
    /// </summary>
    let ReferenceAssociation = _prefixId.prefix "ReferenceAssociation"
    let Relational_DB = _prefixId.prefix "Relational_DB"
    /// <summary>
    ///   <para>rdfs:label : Schema</para>
    ///   <para>rdfs:comment : Instances of dsd:Schema provide an optional hierarchy level between an instance of dsd:DataSource and instances of dsd:Concept. Schemas allow the grouping of concepts and are very common in enterprise databases.</para>
    ///   <a href="https://w3id.org/dsd#Schema">dsd:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    let XML_File = _prefixId.prefix "XML_File"
    /// <summary>
    ///   <para>rdfs:label : Average length of instance</para>
    ///   <para>rdfs:comment : Gives a value of the average (character) length of instances of this concept. E.g., row entries in a MySQL DB.</para>
    ///   <a href="https://w3id.org/dsd#avgInstanceLength">dsd:avgInstanceLength</a>
    /// </summary>
    let avgInstanceLength = _prefixId.prefix "avgInstanceLength"
    /// <summary>
    ///   <para>rdfs:label : consists of Attributes</para>
    ///   <para>rdfs:comment : A Primary or Foreign Key consists of one or several Attributes.</para>
    ///   <a href="https://w3id.org/dsd#consistsOfAttribute">dsd:consistsOfAttribute</a>
    /// </summary>
    let consistsOfAttribute = _prefixId.prefix "consistsOfAttribute"
    /// <summary>
    ///   <para>rdfs:label : Constraint on Delete</para>
    ///   <para>rdfs:comment : Describes the constraint that is defined on a foreign key, which action should be carried out if the referenced primary key is deleted.</para>
    ///   <a href="https://w3id.org/dsd#constraintOnDelete">dsd:constraintOnDelete</a>
    /// </summary>
    let constraintOnDelete = _prefixId.prefix "constraintOnDelete"
    /// <summary>
    ///   <para>rdfs:label : Constraint on Update</para>
    ///   <para>rdfs:comment : Describes which constraint is defined on a foreign key if the referenced primary key content is updated.</para>
    ///   <a href="https://w3id.org/dsd#constraintOnUpdate">dsd:constraintOnUpdate</a>
    /// </summary>
    let constraintOnUpdate = _prefixId.prefix "constraintOnUpdate"
    /// <summary>
    ///   <para>rdfs:label : Default Value</para>
    ///   <para>rdfs:comment : Provides an default value for an attribute.</para>
    ///   <a href="https://w3id.org/dsd#defaultValue">dsd:defaultValue</a>
    /// </summary>
    let defaultValue = _prefixId.prefix "defaultValue"
    /// <summary>
    ///   <para>rdfs:label : has Aggregation</para>
    ///   <para>rdfs:comment : Describes the connection between an AggregationAssociation and its Aggregation.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasAggregation">dsd:hasAggregation</a>
    /// </summary>
    let hasAggregation = _prefixId.prefix "hasAggregation"
    /// <summary>
    ///   <para>rdfs:label : has Aggregation Component^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the connection between an AggregationAssociation and one of its components.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasAggregationComponent">dsd:hasAggregationComponent</a>
    /// </summary>
    let hasAggregationComponent = _prefixId.prefix "hasAggregationComponent"
    /// <summary>
    ///   <para>rdfs:label : has Association Descriptor</para>
    ///   <para>rdfs:comment : Provides annotations for an association.</para>
    ///   <a href="https://w3id.org/dsd#hasAssociationDescriptor">dsd:hasAssociationDescriptor</a>
    /// </summary>
    let hasAssociationDescriptor = _prefixId.prefix "hasAssociationDescriptor"
    /// <summary>
    ///   <para>rdfs:label : has Association Member</para>
    ///   <para>rdfs:comment : Describes the edges from an Association to its Members (Parent, Child, Aggregation, Component).</para>
    ///   <a href="https://w3id.org/dsd#hasAssociationMember">dsd:hasAssociationMember</a>
    /// </summary>
    let hasAssociationMember = _prefixId.prefix "hasAssociationMember"
    /// <summary>
    ///   <para>rdfs:label : has Attribute</para>
    ///   <para>rdfs:comment : Describes the number of Attributes a Concept or Association comprises.</para>
    ///   <a href="https://w3id.org/dsd#hasAttribute">dsd:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:label : has Attribute Descriptor</para>
    ///   <para>rdfs:comment : Provides annotations for an attribute.</para>
    ///   <a href="https://w3id.org/dsd#hasAttributeDescriptor">dsd:hasAttributeDescriptor</a>
    /// </summary>
    let hasAttributeDescriptor = _prefixId.prefix "hasAttributeDescriptor"
    /// <summary>
    ///   <para>rdfs:label : has Child</para>
    ///   <para>rdfs:comment : Describes the connection between an InheritanceAssociation and one of its childs.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasChild">dsd:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : has Component</para>
    ///   <para>rdfs:comment : Describes the number of components a Datasource comprises.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasComponent">dsd:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:label : has Concept Descriptor</para>
    ///   <para>rdfs:comment : Provides annotations for a concept.</para>
    ///   <a href="https://w3id.org/dsd#hasConceptDescriptor">dsd:hasConceptDescriptor</a>
    /// </summary>
    let hasConceptDescriptor = _prefixId.prefix "hasConceptDescriptor"
    /// <summary>
    ///   <para>rdfs:label : has Foreign Key Descriptor</para>
    ///   <para>rdfs:comment : Foreign key descriptor: A textual description of what should happen if the reference of this foreign key is modified (updated/deleted).</para>
    ///   <a href="https://w3id.org/dsd#hasFKDescriptor">dsd:hasFKDescriptor</a>
    /// </summary>
    let hasFKDescriptor = _prefixId.prefix "hasFKDescriptor"
    /// <summary>
    ///   <para>rdfs:label : has Foreign Key</para>
    ///   <para>rdfs:comment : Connects an Association or an Concept with its foreign key.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasForeignKey">dsd:hasForeignKey</a>
    /// </summary>
    let hasForeignKey = _prefixId.prefix "hasForeignKey"
    /// <summary>
    ///   <para>rdfs:label : has Parent^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the connection between an InheritanceAssociation and a parent Concept.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasParent">dsd:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:label : has Primary Key</para>
    ///   <para>rdfs:comment : Connects an Association or an Concept with it primary key.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasPrimaryKey">dsd:hasPrimaryKey</a>
    /// </summary>
    let hasPrimaryKey = _prefixId.prefix "hasPrimaryKey"
    /// <summary>
    ///   <para>rdfs:label : has Schema</para>
    ///   <para>rdfs:comment : Describes the schemas a data source may consist of.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#hasSchema">dsd:hasSchema</a>
    /// </summary>
    let hasSchema = _prefixId.prefix "hasSchema"
    /// <summary>
    ///   <para>rdfs:label : is Attribute of</para>
    ///   <para>rdfs:comment : Describes an Attributes's connection to its Concept or Association.</para>
    ///   <a href="https://w3id.org/dsd#isAttributeOf">dsd:isAttributeOf</a>
    /// </summary>
    let isAttributeOf = _prefixId.prefix "isAttributeOf"
    /// <summary>
    ///   <para>rdfs:label : automatically increments</para>
    ///   <para>rdfs:comment : If the attribute automatically increments on a new insertion of a new value.</para>
    ///   <a href="https://w3id.org/dsd#isAutoIncrement">dsd:isAutoIncrement</a>
    /// </summary>
    let isAutoIncrement = _prefixId.prefix "isAutoIncrement"
    /// <summary>
    ///   <para>rdfs:label : is Complete</para>
    ///   <para>rdfs:comment : Defines whether an inheritance association is complete. If property is set to FALSE, the association is incomplete.</para>
    ///   <a href="https://w3id.org/dsd#isComplete">dsd:isComplete</a>
    /// </summary>
    let isComplete = _prefixId.prefix "isComplete"
    /// <summary>
    ///   <para>rdfs:label : is Component of</para>
    ///   <para>rdfs:comment : Describes a components connection to its Datasource.</para>
    ///   <a href="https://w3id.org/dsd#isComponentOf">dsd:isComponentOf</a>
    /// </summary>
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:label : is Disjoint</para>
    ///   <para>rdfs:comment : Describes whether the children of an inheritance association are disjoint. If property is set to FALSE, the children are overlapping.</para>
    ///   <a href="https://w3id.org/dsd#isDisjoint">dsd:isDisjoint</a>
    /// </summary>
    let isDisjoint = _prefixId.prefix "isDisjoint"
    /// <summary>
    ///   <para>rdfs:label : is Nullable</para>
    ///   <para>rdfs:comment : If the attribute can contain NULL values.</para>
    ///   <a href="https://w3id.org/dsd#isNullable">dsd:isNullable</a>
    /// </summary>
    let isNullable = _prefixId.prefix "isNullable"
    /// <summary>
    ///   <para>rdfs:label : is of Data Type</para>
    ///   <para>rdfs:comment : Describes an Attribute with an XLS Datatype.</para>
    ///   <a href="https://w3id.org/dsd#isOfDataType">dsd:isOfDataType</a>
    /// </summary>
    let isOfDataType = _prefixId.prefix "isOfDataType"
    /// <summary>
    ///   <para>rdfs:label : is of Data Source Type</para>
    ///   <para>rdfs:comment : Describes the type of a Data Source. This vocabulary provides some Individuals that can be used.</para>
    ///   <a href="https://w3id.org/dsd#isOfDatasourceType">dsd:isOfDatasourceType</a>
    /// </summary>
    let isOfDatasourceType = _prefixId.prefix "isOfDatasourceType"
    /// <summary>
    ///   <para>rdfs:label : is Schema of</para>
    ///   <para>rdfs:comment : Describes to which data source a schema belongs to.^^xsd:string</para>
    ///   <a href="https://w3id.org/dsd#isSchemaOf">dsd:isSchemaOf</a>
    /// </summary>
    let isSchemaOf = _prefixId.prefix "isSchemaOf"
    /// <summary>
    ///   <para>rdfs:label : is Unique</para>
    ///   <para>rdfs:comment : Describes if an attribute is unique or not.</para>
    ///   <a href="https://w3id.org/dsd#isUnique">dsd:isUnique</a>
    /// </summary>
    let isUnique = _prefixId.prefix "isUnique"
    /// <summary>
    ///   <para>rdfs:label : Maximum Character Length</para>
    ///   <para>rdfs:comment : Maximum character length of this attribute, given in the number of bits.</para>
    ///   <a href="https://w3id.org/dsd#maxCharacterLength">dsd:maxCharacterLength</a>
    /// </summary>
    let maxCharacterLength = _prefixId.prefix "maxCharacterLength"
    /// <summary>
    ///   <para>rdfs:label : Number of Instances</para>
    ///   <para>rdfs:comment : Number of instances of a concept/association.</para>
    ///   <a href="https://w3id.org/dsd#noOfInstances">dsd:noOfInstances</a>
    /// </summary>
    let noOfInstances = _prefixId.prefix "noOfInstances"
    /// <summary>
    ///   <para>rdfs:label : Ordinal Position</para>
    ///   <para>rdfs:comment : The ordinal position of the attribute to the concept, this information might not always be available (depending on the data source).</para>
    ///   <a href="https://w3id.org/dsd#ordinalPosition">dsd:ordinalPosition</a>
    /// </summary>
    let ordinalPosition = _prefixId.prefix "ordinalPosition"
    /// <summary>
    ///   <para>rdfs:label : referencesTo</para>
    ///   <para>rdfs:comment : A PrimaryKey, Concept or any kind of Association references to another Concept, ForeignKey or Association.</para>
    ///   <a href="https://w3id.org/dsd#referencesTo">dsd:referencesTo</a>
    /// </summary>
    let referencesTo = _prefixId.prefix "referencesTo"
