namespace https.w3id.org.dsd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dsd =
    let _namespace_iri = Namespace_Iri dsd |> NamespaceIRI
    /// <summary>
    ///   <para>dsd:PrimaryKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identifies a Concept and consists of one or more Attributes.</para>
    /// labels<para>Primary key</para></remarks>
    /// <seealso href="https://w3id.org/dsd#PrimaryKey">https://w3id.org/dsd#PrimaryKey</seealso>
    let PrimaryKey = Prefixed_Name(dsd, "PrimaryKey") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Excel_Sheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Excel_Sheet">https://w3id.org/dsd#Excel_Sheet</seealso>
    let Excel_Sheet = Prefixed_Name(dsd, "Excel_Sheet") |> PrefixedName
    /// <summary>
    ///   <para>dsd:NoSQL_DB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#NoSQL_DB">https://w3id.org/dsd#NoSQL_DB</seealso>
    let NoSQL_DB = Prefixed_Name(dsd, "NoSQL_DB") |> PrefixedName
    /// <summary>
    ///   <para>dsd:OO_DB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#OO_DB">https://w3id.org/dsd#OO_DB</seealso>
    let OO_DB = Prefixed_Name(dsd, "OO_DB") |> PrefixedName

    /// <summary>
    ///   <para>dsd:AggregationAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the relationship between an aggregation that is composed out of several components.</para>
    /// labels<para>Aggregation association</para></remarks>
    /// <seealso href="https://w3id.org/dsd#AggregationAssociation">https://w3id.org/dsd#AggregationAssociation</seealso>
    let AggregationAssociation =
        Prefixed_Name(dsd, "AggregationAssociation") |> PrefixedName

    /// <summary>
    ///   <para>dsd:ReferenceAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a regular relationship between two or more Concepts.</para>
    /// labels<para>Reference association</para></remarks>
    /// <seealso href="https://w3id.org/dsd#ReferenceAssociation">https://w3id.org/dsd#ReferenceAssociation</seealso>
    let ReferenceAssociation =
        Prefixed_Name(dsd, "ReferenceAssociation") |> PrefixedName

    /// <summary>
    ///   <para>dsd:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> A dsd:Association describes a relationship between two instances of dsd:Concept. There are three dsd:Association subclasses for aggregation, inheritance, and reference associations.</para>
    /// labels<para>Association</para></remarks>
    /// <seealso href="https://w3id.org/dsd#Association">https://w3id.org/dsd#Association</seealso>
    let Association = Prefixed_Name(dsd, "Association") |> PrefixedName
    /// <summary>
    ///   <para>dsd:CSV_File</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dsd#DatasourceType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#CSV_File">https://w3id.org/dsd#CSV_File</seealso>
    let CSV_File = Prefixed_Name(dsd, "CSV_File") |> PrefixedName
    /// <summary>
    ///   <para>dsd:DatasourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class provides instances of the most common data source types, which can be assigned to instance of dsd:DataSource.</para>
    /// labels<para>Data source type</para></remarks>
    /// <seealso href="https://w3id.org/dsd#DatasourceType">https://w3id.org/dsd#DatasourceType</seealso>
    let DatasourceType = Prefixed_Name(dsd, "DatasourceType") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Datasource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class for representing data sources.
    ///                Example: A dsd:DataSource can represent structured data such as relational databases, semi-structured data like XML files, or NoSQL databases such as graph databases or wide-column stores. A dsd:DataSource can be assigned to an instance of dsd:DataSourceType.</para>
    /// labels<para>Data source</para></remarks>
    /// <seealso href="https://w3id.org/dsd#Datasource">https://w3id.org/dsd#Datasource</seealso>
    let Datasource = Prefixed_Name(dsd, "Datasource") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isUnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes if an attribute is unique or not.</para>
    /// labels<para>is Unique</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isUnique">https://w3id.org/dsd#isUnique</seealso>
    let isUnique = Prefixed_Name(dsd, "isUnique") |> PrefixedName
    /// <summary>
    ///   <para>dsd:ordinalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The ordinal position of the attribute to the concept, this information might not always be available (depending on the data source).</para>
    /// labels<para>Ordinal Position</para></remarks>
    /// <seealso href="https://w3id.org/dsd#ordinalPosition">https://w3id.org/dsd#ordinalPosition</seealso>
    let ordinalPosition = Prefixed_Name(dsd, "ordinalPosition") |> PrefixedName
    /// <summary>
    ///   <para>dsd:referencesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A PrimaryKey, Concept or any kind of Association references to another Concept, ForeignKey or Association.</para>
    /// labels<para>referencesTo</para></remarks>
    /// <seealso href="https://w3id.org/dsd#referencesTo">https://w3id.org/dsd#referencesTo</seealso>
    let referencesTo = Prefixed_Name(dsd, "referencesTo") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Relational_DB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Relational_DB">https://w3id.org/dsd#Relational_DB</seealso>
    let Relational_DB = Prefixed_Name(dsd, "Relational_DB") |> PrefixedName
    /// <summary>
    ///   <para>dsd:avgInstanceLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Gives a value of the average (character) length of instances of this concept. E.g., row entries in a MySQL DB.</para>
    /// labels<para>Average length of instance</para></remarks>
    /// <seealso href="https://w3id.org/dsd#avgInstanceLength">https://w3id.org/dsd#avgInstanceLength</seealso>
    let avgInstanceLength = Prefixed_Name(dsd, "avgInstanceLength") |> PrefixedName
    /// <summary>
    ///   <para>dsd:consistsOfAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Primary or Foreign Key consists of one or several Attributes.</para>
    /// labels<para>consists of Attributes</para></remarks>
    /// <seealso href="https://w3id.org/dsd#consistsOfAttribute">https://w3id.org/dsd#consistsOfAttribute</seealso>
    let consistsOfAttribute = Prefixed_Name(dsd, "consistsOfAttribute") |> PrefixedName
    /// <summary>
    ///   <para>dsd:constraintOnDelete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the constraint that is defined on a foreign key, which action should be carried out if the referenced primary key is deleted.</para>
    /// labels<para>Constraint on Delete</para></remarks>
    /// <seealso href="https://w3id.org/dsd#constraintOnDelete">https://w3id.org/dsd#constraintOnDelete</seealso>
    let constraintOnDelete = Prefixed_Name(dsd, "constraintOnDelete") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasFKDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Foreign key descriptor: A textual description of what should happen if the reference of this foreign key is modified (updated/deleted).</para>
    /// labels<para>has Foreign Key Descriptor</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasFKDescriptor">https://w3id.org/dsd#hasFKDescriptor</seealso>
    let hasFKDescriptor = Prefixed_Name(dsd, "hasFKDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>dsd:constraintOnUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes which constraint is defined on a foreign key if the referenced primary key content is updated.</para>
    /// labels<para>Constraint on Update</para></remarks>
    /// <seealso href="https://w3id.org/dsd#constraintOnUpdate">https://w3id.org/dsd#constraintOnUpdate</seealso>
    let constraintOnUpdate = Prefixed_Name(dsd, "constraintOnUpdate") |> PrefixedName

    /// <summary>
    ///   <para>dsd:hasAttributeDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides annotations for an attribute.</para>
    /// labels<para>has Attribute Descriptor</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAttributeDescriptor">https://w3id.org/dsd#hasAttributeDescriptor</seealso>
    let hasAttributeDescriptor =
        Prefixed_Name(dsd, "hasAttributeDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dsd:hasAssociationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the edges from an Association to its Members (Parent, Child, Aggregation, Component).</para>
    /// labels<para>has Association Member</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAssociationMember">https://w3id.org/dsd#hasAssociationMember</seealso>
    let hasAssociationMember =
        Prefixed_Name(dsd, "hasAssociationMember") |> PrefixedName

    /// <summary>
    ///   <para>dsd:hasAggregationComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the connection between an AggregationAssociation and one of its components.</para>
    /// labels<para>has Aggregation Component</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAggregationComponent">https://w3id.org/dsd#hasAggregationComponent</seealso>
    let hasAggregationComponent =
        Prefixed_Name(dsd, "hasAggregationComponent") |> PrefixedName

    /// <summary>
    ///   <para>dsd:hasAssociationDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides annotations for an association.</para>
    /// labels<para>has Association Descriptor</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAssociationDescriptor">https://w3id.org/dsd#hasAssociationDescriptor</seealso>
    let hasAssociationDescriptor =
        Prefixed_Name(dsd, "hasAssociationDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dsd:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Attribute describes a property of a Concept. DSD also provides OWL data properties for the description of certain attribute characteristics, such as, nullable or unique.
    /// Example:  If a Concept represents a relational table, its attributes correspond to the columns.</para>
    /// labels<para>Attribute</para></remarks>
    /// <seealso href="https://w3id.org/dsd#Attribute">https://w3id.org/dsd#Attribute</seealso>
    let Attribute = Prefixed_Name(dsd, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isSchemaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes to which data source a schema belongs to.</para>
    /// labels<para>is Schema of</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isSchemaOf">https://w3id.org/dsd#isSchemaOf</seealso>
    let isSchemaOf = Prefixed_Name(dsd, "isSchemaOf") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isAutoIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>If the attribute automatically increments on a new insertion of a new value.</para>
    /// labels<para>automatically increments</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isAutoIncrement">https://w3id.org/dsd#isAutoIncrement</seealso>
    let isAutoIncrement = Prefixed_Name(dsd, "isAutoIncrement") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines whether an inheritance association is complete. If property is set to FALSE, the association is incomplete.</para>
    /// labels<para>is Complete</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isComplete">https://w3id.org/dsd#isComplete</seealso>
    let isComplete = Prefixed_Name(dsd, "isComplete") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes whether the children of an inheritance association are disjoint. If property is set to FALSE, the children are overlapping.</para>
    /// labels<para>is Disjoint</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isDisjoint">https://w3id.org/dsd#isDisjoint</seealso>
    let isDisjoint = Prefixed_Name(dsd, "isDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isNullable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>If the attribute can contain NULL values.</para>
    /// labels<para>is Nullable</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isNullable">https://w3id.org/dsd#isNullable</seealso>
    let isNullable = Prefixed_Name(dsd, "isNullable") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isOfDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Describes an Attribute with an XLS Datatype.</para>
    /// labels<para>is of Data Type</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isOfDataType">https://w3id.org/dsd#isOfDataType</seealso>
    let isOfDataType = Prefixed_Name(dsd, "isOfDataType") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a components connection to its Datasource.</para>
    /// labels<para>is Component of</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isComponentOf">https://w3id.org/dsd#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(dsd, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasForeignKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an Association or an Concept with its foreign key.</para>
    /// labels<para>has Foreign Key</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasForeignKey">https://w3id.org/dsd#hasForeignKey</seealso>
    let hasForeignKey = Prefixed_Name(dsd, "hasForeignKey") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the connection between an InheritanceAssociation and a parent Concept.</para>
    /// labels<para>has Parent</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasParent">https://w3id.org/dsd#hasParent</seealso>
    let hasParent = Prefixed_Name(dsd, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Describes the schemas a data source may consist of.</para>
    /// labels<para>has Schema</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasSchema">https://w3id.org/dsd#hasSchema</seealso>
    let hasSchema = Prefixed_Name(dsd, "hasSchema") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A representation of a structural part of a data source.
    /// Example: A dsd:Concept can represent a table or a view of a relational database or a class in object-oriented structures.</para>
    /// labels<para>Concept</para></remarks>
    /// <seealso href="https://w3id.org/dsd#Concept">https://w3id.org/dsd#Concept</seealso>
    let Concept = Prefixed_Name(dsd, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Completeness">https://w3id.org/dsd#Completeness</seealso>
    let Completeness = Prefixed_Name(dsd, "Completeness") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasPrimaryKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Connects an Association or an Concept with it primary key.</para>
    /// labels<para>has Primary Key</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasPrimaryKey">https://w3id.org/dsd#hasPrimaryKey</seealso>
    let hasPrimaryKey = Prefixed_Name(dsd, "hasPrimaryKey") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Correctness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Correctness">https://w3id.org/dsd#Correctness</seealso>
    let Correctness = Prefixed_Name(dsd, "Correctness") |> PrefixedName
    /// <summary>
    ///   <para>dsd:ForeignKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>References to a Primary key and consists of one or more Attributes.</para>
    /// labels<para>Foreign key</para></remarks>
    /// <seealso href="https://w3id.org/dsd#ForeignKey">https://w3id.org/dsd#ForeignKey</seealso>
    let ForeignKey = Prefixed_Name(dsd, "ForeignKey") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isOfDatasourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes the type of a Data Source. This vocabulary provides some Individuals that can be used.</para>
    /// labels<para>is of Data Source Type</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isOfDatasourceType">https://w3id.org/dsd#isOfDatasourceType</seealso>
    let isOfDatasourceType = Prefixed_Name(dsd, "isOfDatasourceType") |> PrefixedName
    /// <summary>
    ///   <para>dsd:maxCharacterLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum character length of this attribute, given in the number of bits.</para>
    /// labels<para>Maximum Character Length</para></remarks>
    /// <seealso href="https://w3id.org/dsd#maxCharacterLength">https://w3id.org/dsd#maxCharacterLength</seealso>
    let maxCharacterLength = Prefixed_Name(dsd, "maxCharacterLength") |> PrefixedName
    /// <summary>
    ///   <para>dsd:noOfInstances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of instances of a concept/association.</para>
    /// labels<para>Number of Instances</para></remarks>
    /// <seealso href="https://w3id.org/dsd#noOfInstances">https://w3id.org/dsd#noOfInstances</seealso>
    let noOfInstances = Prefixed_Name(dsd, "noOfInstances") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of dsd:Schema provide an optional hierarchy level between an instance of dsd:DataSource and instances of dsd:Concept. Schemas allow the grouping of concepts and are very common in enterprise databases.</para>
    /// labels<para>Schema</para></remarks>
    /// <seealso href="https://w3id.org/dsd#Schema">https://w3id.org/dsd#Schema</seealso>
    let Schema = Prefixed_Name(dsd, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>dsd:Minimality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Minimality">https://w3id.org/dsd#Minimality</seealso>
    let Minimality = Prefixed_Name(dsd, "Minimality") |> PrefixedName
    /// <summary>
    ///   <para>dsd:PlainText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#PlainText">https://w3id.org/dsd#PlainText</seealso>
    let PlainText = Prefixed_Name(dsd, "PlainText") |> PrefixedName
    /// <summary>
    ///   <para>dsd:RDF_Store</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dsd#DatasourceType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#RDF_Store">https://w3id.org/dsd#RDF_Store</seealso>
    let RDF_Store = Prefixed_Name(dsd, "RDF_Store") |> PrefixedName
    /// <summary>
    ///   <para>dsd:XML_File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dsd#DatasourceType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#XML_File">https://w3id.org/dsd#XML_File</seealso>
    let XML_File = Prefixed_Name(dsd, "XML_File") |> PrefixedName

    /// <summary>
    ///   <para>dsd:hasConceptDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides annotations for a concept.</para>
    /// labels<para>has Concept Descriptor</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasConceptDescriptor">https://w3id.org/dsd#hasConceptDescriptor</seealso>
    let hasConceptDescriptor =
        Prefixed_Name(dsd, "hasConceptDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dsd:Pertinence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd#Pertinence">https://w3id.org/dsd#Pertinence</seealso>
    let Pertinence = Prefixed_Name(dsd, "Pertinence") |> PrefixedName
    /// <summary>
    ///   <para>dsd:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Provides an default value for an attribute.</para>
    /// labels<para>Default Value</para></remarks>
    /// <seealso href="https://w3id.org/dsd#defaultValue">https://w3id.org/dsd#defaultValue</seealso>
    let defaultValue = Prefixed_Name(dsd, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasAggregation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the connection between an AggregationAssociation and its Aggregation.</para>
    /// labels<para>has Aggregation</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAggregation">https://w3id.org/dsd#hasAggregation</seealso>
    let hasAggregation = Prefixed_Name(dsd, "hasAggregation") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the number of Attributes a Concept or Association comprises.</para>
    /// labels<para>has Attribute</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasAttribute">https://w3id.org/dsd#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(dsd, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the connection between an InheritanceAssociation and one of its childs.</para>
    /// labels<para>has Child</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasChild">https://w3id.org/dsd#hasChild</seealso>
    let hasChild = Prefixed_Name(dsd, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>dsd:isAttributeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes an Attributes's connection to its Concept or Association.</para>
    /// labels<para>is Attribute of</para></remarks>
    /// <seealso href="https://w3id.org/dsd#isAttributeOf">https://w3id.org/dsd#isAttributeOf</seealso>
    let isAttributeOf = Prefixed_Name(dsd, "isAttributeOf") |> PrefixedName
    /// <summary>
    ///   <para>dsd:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the number of components a Datasource comprises.</para>
    /// labels<para>has Component</para></remarks>
    /// <seealso href="https://w3id.org/dsd#hasComponent">https://w3id.org/dsd#hasComponent</seealso>
    let hasComponent = Prefixed_Name(dsd, "hasComponent") |> PrefixedName

    /// <summary>
    ///   <para>dsd:InheritanceAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the relationship between several child Concepts and their parent.</para>
    /// labels<para>Inheritance association</para></remarks>
    /// <seealso href="https://w3id.org/dsd#InheritanceAssociation">https://w3id.org/dsd#InheritanceAssociation</seealso>
    let InheritanceAssociation =
        Prefixed_Name(dsd, "InheritanceAssociation") |> PrefixedName
