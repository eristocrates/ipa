namespace http.www.wiwiss.fu_berlin.de.suhl.bizer.D2RQ._0._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module d2rq =
    let _namespace_iri = Namespace_Iri d2rq |> NamespaceIRI
    /// <summary>
    ///   <para>d2rq:AdditionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents an additional property that may be added to instances as well as class and property definitions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Additional property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#AdditionalProperty">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#AdditionalProperty</seealso>
    let AdditionalProperty = Prefixed_Name(d2rq, "AdditionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:ClassMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Maps an RDFS or OWL class to its database representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ClassMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ClassMap</seealso>
    let ClassMap = Prefixed_Name(d2rq, "ClassMap") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents general settings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Configuration">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Configuration</seealso>
    let Configuration = Prefixed_Name(d2rq, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:D2RQModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Jena Assemler specification for a relational database, mapped to RDF using the D2RQ tool."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"D2RQ model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#D2RQModel">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#D2RQModel</seealso>
    let D2RQModel = Prefixed_Name(d2rq, "D2RQModel") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a database."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Database"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Database">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Database</seealso>
    let Database = Prefixed_Name(d2rq, "Database") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:DatatypePropertyBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"(Deprecated) Maps a datatype property to one or more database columns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datatype property bridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DatatypePropertyBridge">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DatatypePropertyBridge</seealso>
    let DatatypePropertyBridge =
        Prefixed_Name(d2rq, "DatatypePropertyBridge") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:DownloadMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Makes the contents of some database column downloadable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Download map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DownloadMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DownloadMap</seealso>
    let DownloadMap = Prefixed_Name(d2rq, "DownloadMap") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:ObjectPropertyBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"(Deprecated) Maps an object property to one or more database columns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object property bridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ObjectPropertyBridge">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ObjectPropertyBridge</seealso>
    let ObjectPropertyBridge =
        Prefixed_Name(d2rq, "ObjectPropertyBridge") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:PropertyBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Maps an RDF property to one or more database columns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property bridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#PropertyBridge">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#PropertyBridge</seealso>
    let PropertyBridge = Prefixed_Name(d2rq, "PropertyBridge") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:ResourceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A database-to-RDF mapping from one or more database columns to a set of RDF resources. An abstract class, usually not used directly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ResourceMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ResourceMap</seealso>
    let ResourceMap = Prefixed_Name(d2rq, "ResourceMap") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Translation Key/Value Pair."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Translation">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Translation</seealso>
    let Translation = Prefixed_Name(d2rq, "Translation") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:TranslationTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Lookup table for translations used in the mapping process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Translation table"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#TranslationTable">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#TranslationTable</seealso>
    let TranslationTable = Prefixed_Name(d2rq, "TranslationTable") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:additionalClassDefinitionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An additional property to be served for all associated class definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Additional class definition property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalClassDefinitionProperty">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalClassDefinitionProperty</seealso>
    let additionalClassDefinitionProperty =
        Prefixed_Name(d2rq, "additionalClassDefinitionProperty") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:additionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Additional property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalProperty">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalProperty</seealso>
    let additionalProperty = Prefixed_Name(d2rq, "additionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:additionalPropertyDefinitionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An additional property to be served for all associated property definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Additional property definition property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalPropertyDefinitionProperty">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalPropertyDefinitionProperty</seealso>
    let additionalPropertyDefinitionProperty =
        Prefixed_Name(d2rq, "additionalPropertyDefinitionProperty") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"TABLE AS ALIAS declaration for establishing an alternate table name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#alias">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#alias</seealso>
    let alias = Prefixed_Name(d2rq, "alias") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:allowDistinct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Value: true/false that describe the databases ability to handle DISTINCT correctly. Deprecated, the engine now determines this automatically."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Allow distinct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#allowDistinct">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#allowDistinct</seealso>
    let allowDistinct = Prefixed_Name(d2rq, "allowDistinct") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:bNodeIdColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Comma-separated list of database columns used for construction of blank nodes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blank node ID columns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bNodeIdColumns">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bNodeIdColumns</seealso>
    let bNodeIdColumns = Prefixed_Name(d2rq, "bNodeIdColumns") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:belongsToClassMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Belongs to class map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#belongsToClassMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#belongsToClassMap</seealso>
    let belongsToClassMap = Prefixed_Name(d2rq, "belongsToClassMap") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:binaryColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of a binary type, such as BINARY, VARBINARY or BLOB."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BINARY column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#binaryColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#binaryColumn</seealso>
    let binaryColumn = Prefixed_Name(d2rq, "binaryColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:bitColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type BIT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BIT column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bitColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bitColumn</seealso>
    let bitColumn = Prefixed_Name(d2rq, "bitColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:booleanColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type BOOLEAN."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BOOLEAN column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#booleanColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#booleanColumn</seealso>
    let booleanColumn = Prefixed_Name(d2rq, "booleanColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links d2rq:classMaps to RDFS or OWL classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#class">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#class</seealso>
    let class_ = Prefixed_Name(d2rq, "class") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:classDefinitionComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comment to be served as rdfs:comment for all associated class definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class definition comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionComment">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionComment</seealso>
    let classDefinitionComment =
        Prefixed_Name(d2rq, "classDefinitionComment") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:classDefinitionLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A label to be served as rdfs:label for all associated class definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class definition label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionLabel">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionLabel</seealso>
    let classDefinitionLabel =
        Prefixed_Name(d2rq, "classDefinitionLabel") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:classMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to link RDFS or OWL classes to d2r:classMaps. Deprecated, use inverse d2rq:class instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classMap</seealso>
    let classMap = Prefixed_Name(d2rq, "classMap") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#column">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#column</seealso>
    let column = Prefixed_Name(d2rq, "column") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"SQL WHERE condition that must be satisfied for a database row to be mapped."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#condition">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#condition</seealso>
    let condition = Prefixed_Name(d2rq, "condition") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:constantValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A constant RDF node to be used as the value of this property bridge, or as the resource of a singleton class map."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constant value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#constantValue">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#constantValue</seealso>
    let constantValue = Prefixed_Name(d2rq, "constantValue") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:containsDuplicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Set to true if the table, after applying d2rq:joins and d2rq:conditions, may contain duplicate records."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains duplicates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#containsDuplicates">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#containsDuplicates</seealso>
    let containsDuplicates = Prefixed_Name(d2rq, "containsDuplicates") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:contentDownloadColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A database column containing data to be made downloadable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Content download column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#contentDownloadColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#contentDownloadColumn</seealso>
    let contentDownloadColumn =
        Prefixed_Name(d2rq, "contentDownloadColumn") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:dataStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Data storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dataStorage">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dataStorage</seealso>
    let dataStorage = Prefixed_Name(d2rq, "dataStorage") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:databaseValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Database value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#databaseValue">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#databaseValue</seealso>
    let databaseValue = Prefixed_Name(d2rq, "databaseValue") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The datatype of literals created by this bridge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datatype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#datatype">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#datatype</seealso>
    let datatype = Prefixed_Name(d2rq, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:dateColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type DATE."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DATE column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dateColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dateColumn</seealso>
    let dateColumn = Prefixed_Name(d2rq, "dateColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:dynamicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a d2rq:PropertyBridge to a dynamic property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dynamicProperty">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dynamicProperty</seealso>
    let dynamicProperty = Prefixed_Name(d2rq, "dynamicProperty") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:fetchSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of rows that should be fetched from the database at once"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fetch size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#fetchSize">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#fetchSize</seealso>
    let fetchSize = Prefixed_Name(d2rq, "fetchSize") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:href</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to a translation table in an external CSV file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#href">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#href</seealso>
    let href = Prefixed_Name(d2rq, "href") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:intervalColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type INTERVAL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"INTERVAL column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#intervalColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#intervalColumn</seealso>
    let intervalColumn = Prefixed_Name(d2rq, "intervalColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:javaClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Qualified name of a Java class that implements de.fuberlin.wiwiss.d2rq.Translator and translates between database and RDF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#javaClass">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#javaClass</seealso>
    let javaClass = Prefixed_Name(d2rq, "javaClass") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:jdbcDSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"JDBC data source name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JDBC DSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDSN">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDSN</seealso>
    let jdbcDSN = Prefixed_Name(d2rq, "jdbcDSN") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:jdbcDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"JDBC driver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDriver">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDriver</seealso>
    let jdbcDriver = Prefixed_Name(d2rq, "jdbcDriver") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:join</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"SQL join condition over tables in the database."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Join"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#join">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#join</seealso>
    let join = Prefixed_Name(d2rq, "join") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The language tag of literals created by this bridge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#lang">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#lang</seealso>
    let lang = Prefixed_Name(d2rq, "lang") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of results to retrieve from the database for this PropertyBridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limit">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limit</seealso>
    let limit = Prefixed_Name(d2rq, "limit") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:limitInverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of results to retrieve from the database for the inverse statements for this PropertyBridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limit inverse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limitInverse">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limitInverse</seealso>
    let limitInverse = Prefixed_Name(d2rq, "limitInverse") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:mappingFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URL of a D2RQ mapping file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mapping file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mappingFile">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mappingFile</seealso>
    let mappingFile = Prefixed_Name(d2rq, "mappingFile") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Internet media type, such as image/png, of the downloadable content, suitable for use in the HTTP Content-Type header."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mediaType">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mediaType</seealso>
    let mediaType = Prefixed_Name(d2rq, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:numericColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of a numeric type, such as INT or DOUBLE or DECIMAL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Numeric column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#numericColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#numericColumn</seealso>
    let numericColumn = Prefixed_Name(d2rq, "numericColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:odbcDSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"ODBC DSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ODBC data source name. Deprecated, use JDBC instead (with ODBC-JDBC bridge if necessary)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#odbcDSN">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#odbcDSN</seealso>
    let odbcDSN = Prefixed_Name(d2rq, "odbcDSN") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:orderAsc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The column after which to sort results in ascending order for this PropertyBridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Order ascending"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderAsc">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderAsc</seealso>
    let orderAsc = Prefixed_Name(d2rq, "orderAsc") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:orderDesc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The column after which to sort results in descending order for this PropertyBridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Order descending"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderDesc">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderDesc</seealso>
    let orderDesc = Prefixed_Name(d2rq, "orderDesc") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:password</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Password"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#password">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#password</seealso>
    let password = Prefixed_Name(d2rq, "password") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#pattern">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#pattern</seealso>
    let pattern = Prefixed_Name(d2rq, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a d2rq:PropertyBridge to an RDF property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#property">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#property</seealso>
    let property = Prefixed_Name(d2rq, "property") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:propertyBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"Used for linking RDFS properties to D2R property bridges. Deprecated, use inverse d2rq:property instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property bridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyBridge">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyBridge</seealso>
    let propertyBridge = Prefixed_Name(d2rq, "propertyBridge") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:propertyDefinitionComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comment to be served as rdfs:comment for all associated properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property definition comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionComment">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionComment</seealso>
    let propertyDefinitionComment =
        Prefixed_Name(d2rq, "propertyDefinitionComment") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:propertyDefinitionLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A label to be served as rdfs:label for all associated properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property definition label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionLabel">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionLabel</seealso>
    let propertyDefinitionLabel =
        Prefixed_Name(d2rq, "propertyDefinitionLabel") |> PrefixedName

    /// <summary>
    ///   <para>d2rq:propertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Property name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyName">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyName</seealso>
    let propertyName = Prefixed_Name(d2rq, "propertyName") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:propertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Property value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyValue">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyValue</seealso>
    let propertyValue = Prefixed_Name(d2rq, "propertyValue") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:rdfValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"RDF value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#rdfValue">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#rdfValue</seealso>
    let rdfValue = Prefixed_Name(d2rq, "rdfValue") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:refersToClassMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Has to be used if a join refers to a different classMap."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Refers to class map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#refersToClassMap">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#refersToClassMap</seealso>
    let refersToClassMap = Prefixed_Name(d2rq, "refersToClassMap") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:resourceBaseURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Base URI for resources generated by relative URI patterns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource base URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resourceBaseURI">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resourceBaseURI</seealso>
    let resourceBaseURI = Prefixed_Name(d2rq, "resourceBaseURI") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:resultSizeLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Enforced upper limit for the size of SQL result sets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Result size limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resultSizeLimit">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resultSizeLimit</seealso>
    let resultSizeLimit = Prefixed_Name(d2rq, "resultSizeLimit") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:serveVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Whether to serve inferred and user-supplied vocabulary data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Serve vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#serveVocabulary">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#serveVocabulary</seealso>
    let serveVocabulary = Prefixed_Name(d2rq, "serveVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:sqlExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A SQL expression whose result will be the value of this property bridge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SQL expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#sqlExpression">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#sqlExpression</seealso>
    let sqlExpression = Prefixed_Name(d2rq, "sqlExpression") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:startupSQLScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URL of a SQL script that will be run on startup."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Startup SQL script"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#startupSQLScript">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#startupSQLScript</seealso>
    let startupSQLScript = Prefixed_Name(d2rq, "startupSQLScript") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:textColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of a character type, such as CHAR, VARCHAR, NVARCHAR or CLOB."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Text column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#textColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#textColumn</seealso>
    let textColumn = Prefixed_Name(d2rq, "textColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:timeColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type TIME."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TIME column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timeColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timeColumn</seealso>
    let timeColumn = Prefixed_Name(d2rq, "timeColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:timestampColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of a column of type TIMESTAMP."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TIMESTAMP column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timestampColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timestampColumn</seealso>
    let timestampColumn = Prefixed_Name(d2rq, "timestampColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:translateWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Translate with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translateWith">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translateWith</seealso>
    let translateWith = Prefixed_Name(d2rq, "translateWith") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Translation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translation">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translation</seealso>
    let translation = Prefixed_Name(d2rq, "translation") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:uriColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Database column which contains URIs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriColumn">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriColumn</seealso>
    let uriColumn = Prefixed_Name(d2rq, "uriColumn") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:uriPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI pattern with placeholders that will be filled with values from a database column."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriPattern">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriPattern</seealso>
    let uriPattern = Prefixed_Name(d2rq, "uriPattern") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:uriSqlExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An SQL expression whose result will be the URI value of this property bridge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI SQL expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriSqlExpression">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriSqlExpression</seealso>
    let uriSqlExpression = Prefixed_Name(d2rq, "uriSqlExpression") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:useAllOptimizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Whether to use bleeding edge optimizations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Use all optimizations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#useAllOptimizations">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#useAllOptimizations</seealso>
    let useAllOptimizations = Prefixed_Name(d2rq, "useAllOptimizations") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:username</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"User name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#username">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#username</seealso>
    let username = Prefixed_Name(d2rq, "username") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:valueContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Optimizing hint: a string contained in every value of this resource map."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueContains">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueContains</seealso>
    let valueContains = Prefixed_Name(d2rq, "valueContains") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:valueMaxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Optimizing hint: the maximum length of values of this resource map."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value max length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueMaxLength">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueMaxLength</seealso>
    let valueMaxLength = Prefixed_Name(d2rq, "valueMaxLength") |> PrefixedName
    /// <summary>
    ///   <para>d2rq:valueRegex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Optimizing hint: a regular expression matching every value of this resource map."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value regex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueRegex">http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueRegex</seealso>
    let valueRegex = Prefixed_Name(d2rq, "valueRegex") |> PrefixedName
