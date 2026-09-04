#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module d2rq =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#" "d2rq"

    /// <summary>
    ///   <para>rdfs:label : Additional property^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an additional property that may be added to instances as well as class and property definitions.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#AdditionalProperty">d2rq:AdditionalProperty</a>
    /// </summary>
    let AdditionalProperty = _prefixId.prefix "AdditionalProperty"
    /// <summary>
    ///   <para>rdfs:label : Class map^^xsd:string</para>
    ///   <para>rdfs:comment : Maps an RDFS or OWL class to its database representation.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ClassMap">d2rq:ClassMap</a>
    /// </summary>
    let ClassMap = _prefixId.prefix "ClassMap"
    /// <summary>
    ///   <para>rdfs:label : Configuration^^xsd:string</para>
    ///   <para>rdfs:comment : Represents general settings.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Configuration">d2rq:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:label : D2RQ model^^xsd:string</para>
    ///   <para>rdfs:comment : Jena Assemler specification for a relational database, mapped to RDF using the D2RQ tool.^^xsd:string</para>
    ///   <para>http://jena.hpl.hp.com/2005/11/Assembler#assembler : de.fuberlin.wiwiss.d2rq.assembler.D2RQAssembler^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#D2RQModel">d2rq:D2RQModel</a>
    /// </summary>
    let D2RQModel = _prefixId.prefix "D2RQModel"
    /// <summary>
    ///   <para>rdfs:label : Database^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a database.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Database">d2rq:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : Datatype property bridge^^xsd:string</para>
    ///   <para>rdfs:comment : (Deprecated) Maps a datatype property to one or more database columns.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DatatypePropertyBridge">d2rq:DatatypePropertyBridge</a>
    /// </summary>
    let DatatypePropertyBridge = _prefixId.prefix "DatatypePropertyBridge"
    /// <summary>
    ///   <para>rdfs:label : Download map^^xsd:string</para>
    ///   <para>rdfs:comment : Makes the contents of some database column downloadable.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DownloadMap">d2rq:DownloadMap</a>
    /// </summary>
    let DownloadMap = _prefixId.prefix "DownloadMap"
    /// <summary>
    ///   <para>rdfs:label : Object property bridge^^xsd:string</para>
    ///   <para>rdfs:comment : (Deprecated) Maps an object property to one or more database columns.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ObjectPropertyBridge">d2rq:ObjectPropertyBridge</a>
    /// </summary>
    let ObjectPropertyBridge = _prefixId.prefix "ObjectPropertyBridge"
    /// <summary>
    ///   <para>rdfs:label : Property bridge^^xsd:string</para>
    ///   <para>rdfs:comment : Maps an RDF property to one or more database columns.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#PropertyBridge">d2rq:PropertyBridge</a>
    /// </summary>
    let PropertyBridge = _prefixId.prefix "PropertyBridge"
    /// <summary>
    ///   <para>rdfs:label : Resource map^^xsd:string</para>
    ///   <para>rdfs:comment : A database-to-RDF mapping from one or more database columns to a set of RDF resources. An abstract class, usually not used directly.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ResourceMap">d2rq:ResourceMap</a>
    /// </summary>
    let ResourceMap = _prefixId.prefix "ResourceMap"
    /// <summary>
    ///   <para>rdfs:label : Translation^^xsd:string</para>
    ///   <para>rdfs:comment : Translation Key/Value Pair.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Translation">d2rq:Translation</a>
    /// </summary>
    let Translation = _prefixId.prefix "Translation"
    /// <summary>
    ///   <para>rdfs:label : Translation table^^xsd:string</para>
    ///   <para>rdfs:comment : Lookup table for translations used in the mapping process.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#TranslationTable">d2rq:TranslationTable</a>
    /// </summary>
    let TranslationTable = _prefixId.prefix "TranslationTable"

    /// <summary>
    ///   <para>rdfs:label : Additional class definition property^^xsd:string</para>
    ///   <para>rdfs:comment : An additional property to be served for all associated class definitions^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalClassDefinitionProperty">d2rq:additionalClassDefinitionProperty</a>
    /// </summary>
    let additionalClassDefinitionProperty =
        _prefixId.prefix "additionalClassDefinitionProperty"

    /// <summary>
    ///   <para>rdfs:label : Additional property^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalProperty">d2rq:additionalProperty</a>
    /// </summary>
    let additionalProperty = _prefixId.prefix "additionalProperty"

    /// <summary>
    ///   <para>rdfs:label : Additional property definition property^^xsd:string</para>
    ///   <para>rdfs:comment : An additional property to be served for all associated property definitions^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalPropertyDefinitionProperty">d2rq:additionalPropertyDefinitionProperty</a>
    /// </summary>
    let additionalPropertyDefinitionProperty =
        _prefixId.prefix "additionalPropertyDefinitionProperty"

    /// <summary>
    ///   <para>rdfs:label : Alias^^xsd:string</para>
    ///   <para>rdfs:comment : TABLE AS ALIAS declaration for establishing an alternate table name.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#alias">d2rq:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>rdfs:label : Allow distinct^^xsd:string</para>
    ///   <para>rdfs:comment : Value: true/false that describe the databases ability to handle DISTINCT correctly. Deprecated, the engine now determines this automatically.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#allowDistinct">d2rq:allowDistinct</a>
    /// </summary>
    let allowDistinct = _prefixId.prefix "allowDistinct"
    /// <summary>
    ///   <para>rdfs:label : Blank node ID columns^^xsd:string</para>
    ///   <para>rdfs:comment : Comma-separated list of database columns used for construction of blank nodes.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bNodeIdColumns">d2rq:bNodeIdColumns</a>
    /// </summary>
    let bNodeIdColumns = _prefixId.prefix "bNodeIdColumns"
    /// <summary>
    ///   <para>rdfs:label : Belongs to class map^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#belongsToClassMap">d2rq:belongsToClassMap</a>
    /// </summary>
    let belongsToClassMap = _prefixId.prefix "belongsToClassMap"
    /// <summary>
    ///   <para>rdfs:label : BINARY column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of a binary type, such as BINARY, VARBINARY or BLOB.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#binaryColumn">d2rq:binaryColumn</a>
    /// </summary>
    let binaryColumn = _prefixId.prefix "binaryColumn"
    /// <summary>
    ///   <para>rdfs:label : BIT column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type BIT.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bitColumn">d2rq:bitColumn</a>
    /// </summary>
    let bitColumn = _prefixId.prefix "bitColumn"
    /// <summary>
    ///   <para>rdfs:label : BOOLEAN column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type BOOLEAN.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#booleanColumn">d2rq:booleanColumn</a>
    /// </summary>
    let booleanColumn = _prefixId.prefix "booleanColumn"
    /// <summary>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <para>rdfs:comment : Links d2rq:classMaps to RDFS or OWL classes.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#class">d2rq:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : Class definition comment^^xsd:string</para>
    ///   <para>rdfs:comment : A comment to be served as rdfs:comment for all associated class definitions^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionComment">d2rq:classDefinitionComment</a>
    /// </summary>
    let classDefinitionComment = _prefixId.prefix "classDefinitionComment"
    /// <summary>
    ///   <para>rdfs:label : Class definition label^^xsd:string</para>
    ///   <para>rdfs:comment : A label to be served as rdfs:label for all associated class definitions^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionLabel">d2rq:classDefinitionLabel</a>
    /// </summary>
    let classDefinitionLabel = _prefixId.prefix "classDefinitionLabel"
    /// <summary>
    ///   <para>rdfs:label : Class map^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link RDFS or OWL classes to d2r:classMaps. Deprecated, use inverse d2rq:class instead.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classMap">d2rq:classMap</a>
    /// </summary>
    let classMap = _prefixId.prefix "classMap"
    /// <summary>
    ///   <para>rdfs:label : Column^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#column">d2rq:column</a>
    /// </summary>
    let column = _prefixId.prefix "column"
    /// <summary>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <para>rdfs:comment : SQL WHERE condition that must be satisfied for a database row to be mapped.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#condition">d2rq:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : Constant value^^xsd:string</para>
    ///   <para>rdfs:comment : A constant RDF node to be used as the value of this property bridge, or as the resource of a singleton class map.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#constantValue">d2rq:constantValue</a>
    /// </summary>
    let constantValue = _prefixId.prefix "constantValue"
    /// <summary>
    ///   <para>rdfs:label : Contains duplicates^^xsd:string</para>
    ///   <para>rdfs:comment : Set to true if the table, after applying d2rq:joins and d2rq:conditions, may contain duplicate records.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#containsDuplicates">d2rq:containsDuplicates</a>
    /// </summary>
    let containsDuplicates = _prefixId.prefix "containsDuplicates"
    /// <summary>
    ///   <para>rdfs:label : Content download column^^xsd:string</para>
    ///   <para>rdfs:comment : A database column containing data to be made downloadable.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#contentDownloadColumn">d2rq:contentDownloadColumn</a>
    /// </summary>
    let contentDownloadColumn = _prefixId.prefix "contentDownloadColumn"
    /// <summary>
    ///   <para>rdfs:label : Data storage^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dataStorage">d2rq:dataStorage</a>
    /// </summary>
    let dataStorage = _prefixId.prefix "dataStorage"
    /// <summary>
    ///   <para>rdfs:label : Database value^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#databaseValue">d2rq:databaseValue</a>
    /// </summary>
    let databaseValue = _prefixId.prefix "databaseValue"
    /// <summary>
    ///   <para>rdfs:label : Datatype^^xsd:string</para>
    ///   <para>rdfs:comment : The datatype of literals created by this bridge.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#datatype">d2rq:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : DATE column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type DATE.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dateColumn">d2rq:dateColumn</a>
    /// </summary>
    let dateColumn = _prefixId.prefix "dateColumn"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : Links a d2rq:PropertyBridge to a dynamic property.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dynamicProperty">d2rq:dynamicProperty</a>
    /// </summary>
    let dynamicProperty = _prefixId.prefix "dynamicProperty"
    /// <summary>
    ///   <para>rdfs:label : Fetch size^^xsd:string</para>
    ///   <para>rdfs:comment : The number of rows that should be fetched from the database at once^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#fetchSize">d2rq:fetchSize</a>
    /// </summary>
    let fetchSize = _prefixId.prefix "fetchSize"
    /// <summary>
    ///   <para>rdfs:label : Href^^xsd:string</para>
    ///   <para>rdfs:comment : Link to a translation table in an external CSV file.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#href">d2rq:href</a>
    /// </summary>
    let href = _prefixId.prefix "href"
    /// <summary>
    ///   <para>rdfs:label : INTERVAL column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type INTERVAL.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#intervalColumn">d2rq:intervalColumn</a>
    /// </summary>
    let intervalColumn = _prefixId.prefix "intervalColumn"
    /// <summary>
    ///   <para>rdfs:label : Java class^^xsd:string</para>
    ///   <para>rdfs:comment : Qualified name of a Java class that implements de.fuberlin.wiwiss.d2rq.Translator and translates between database and RDF.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#javaClass">d2rq:javaClass</a>
    /// </summary>
    let javaClass = _prefixId.prefix "javaClass"
    /// <summary>
    ///   <para>rdfs:label : JDBC DSN^^xsd:string</para>
    ///   <para>rdfs:comment : JDBC data source name.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDSN">d2rq:jdbcDSN</a>
    /// </summary>
    let jdbcDSN = _prefixId.prefix "jdbcDSN"
    /// <summary>
    ///   <para>rdfs:label : JDBC driver^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDriver">d2rq:jdbcDriver</a>
    /// </summary>
    let jdbcDriver = _prefixId.prefix "jdbcDriver"
    /// <summary>
    ///   <para>rdfs:label : Join^^xsd:string</para>
    ///   <para>rdfs:comment : SQL join condition over tables in the database.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#join">d2rq:join</a>
    /// </summary>
    let join = _prefixId.prefix "join"
    /// <summary>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <para>rdfs:comment : The language tag of literals created by this bridge.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#lang">d2rq:lang</a>
    /// </summary>
    let lang = _prefixId.prefix "lang"
    /// <summary>
    ///   <para>rdfs:label : Limit^^xsd:string</para>
    ///   <para>rdfs:comment : The number of results to retrieve from the database for this PropertyBridge^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limit">d2rq:limit</a>
    /// </summary>
    let limit = _prefixId.prefix "limit"
    /// <summary>
    ///   <para>rdfs:label : Limit inverse^^xsd:string</para>
    ///   <para>rdfs:comment : The number of results to retrieve from the database for the inverse statements for this PropertyBridge^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limitInverse">d2rq:limitInverse</a>
    /// </summary>
    let limitInverse = _prefixId.prefix "limitInverse"
    /// <summary>
    ///   <para>rdfs:label : Mapping file^^xsd:string</para>
    ///   <para>rdfs:comment : URL of a D2RQ mapping file.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mappingFile">d2rq:mappingFile</a>
    /// </summary>
    let mappingFile = _prefixId.prefix "mappingFile"
    /// <summary>
    ///   <para>rdfs:label : Media type^^xsd:string</para>
    ///   <para>rdfs:comment : The Internet media type, such as image/png, of the downloadable content, suitable for use in the HTTP Content-Type header.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mediaType">d2rq:mediaType</a>
    /// </summary>
    let mediaType = _prefixId.prefix "mediaType"
    /// <summary>
    ///   <para>rdfs:label : Numeric column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of a numeric type, such as INT or DOUBLE or DECIMAL.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#numericColumn">d2rq:numericColumn</a>
    /// </summary>
    let numericColumn = _prefixId.prefix "numericColumn"
    /// <summary>
    ///   <para>rdfs:comment : ODBC DSN^^xsd:string</para>
    ///   <para>rdfs:label : ODBC data source name. Deprecated, use JDBC instead (with ODBC-JDBC bridge if necessary).^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#odbcDSN">d2rq:odbcDSN</a>
    /// </summary>
    let odbcDSN = _prefixId.prefix "odbcDSN"
    /// <summary>
    ///   <para>rdfs:label : Order ascending^^xsd:string</para>
    ///   <para>rdfs:comment : The column after which to sort results in ascending order for this PropertyBridge^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderAsc">d2rq:orderAsc</a>
    /// </summary>
    let orderAsc = _prefixId.prefix "orderAsc"
    /// <summary>
    ///   <para>rdfs:label : Order descending^^xsd:string</para>
    ///   <para>rdfs:comment : The column after which to sort results in descending order for this PropertyBridge^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderDesc">d2rq:orderDesc</a>
    /// </summary>
    let orderDesc = _prefixId.prefix "orderDesc"
    /// <summary>
    ///   <para>rdfs:label : Password^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#password">d2rq:password</a>
    /// </summary>
    let password = _prefixId.prefix "password"
    /// <summary>
    ///   <para>rdfs:label : Pattern^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#pattern">d2rq:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : Links a d2rq:PropertyBridge to an RDF property.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#property">d2rq:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : Property bridge^^xsd:string</para>
    ///   <para>rdfs:comment : Used for linking RDFS properties to D2R property bridges. Deprecated, use inverse d2rq:property instead.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyBridge">d2rq:propertyBridge</a>
    /// </summary>
    let propertyBridge = _prefixId.prefix "propertyBridge"
    /// <summary>
    ///   <para>rdfs:label : Property definition comment^^xsd:string</para>
    ///   <para>rdfs:comment : A comment to be served as rdfs:comment for all associated properties^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionComment">d2rq:propertyDefinitionComment</a>
    /// </summary>
    let propertyDefinitionComment = _prefixId.prefix "propertyDefinitionComment"
    /// <summary>
    ///   <para>rdfs:label : Property definition label^^xsd:string</para>
    ///   <para>rdfs:comment : A label to be served as rdfs:label for all associated properties^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionLabel">d2rq:propertyDefinitionLabel</a>
    /// </summary>
    let propertyDefinitionLabel = _prefixId.prefix "propertyDefinitionLabel"
    /// <summary>
    ///   <para>rdfs:label : Property name^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyName">d2rq:propertyName</a>
    /// </summary>
    let propertyName = _prefixId.prefix "propertyName"
    /// <summary>
    ///   <para>rdfs:label : Property value^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyValue">d2rq:propertyValue</a>
    /// </summary>
    let propertyValue = _prefixId.prefix "propertyValue"
    /// <summary>
    ///   <para>rdfs:label : RDF value^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#rdfValue">d2rq:rdfValue</a>
    /// </summary>
    let rdfValue = _prefixId.prefix "rdfValue"
    /// <summary>
    ///   <para>rdfs:label : Refers to class map^^xsd:string</para>
    ///   <para>rdfs:comment : Has to be used if a join refers to a different classMap.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#refersToClassMap">d2rq:refersToClassMap</a>
    /// </summary>
    let refersToClassMap = _prefixId.prefix "refersToClassMap"
    /// <summary>
    ///   <para>rdfs:label : Resource base URI^^xsd:string</para>
    ///   <para>rdfs:comment : Base URI for resources generated by relative URI patterns.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resourceBaseURI">d2rq:resourceBaseURI</a>
    /// </summary>
    let resourceBaseURI = _prefixId.prefix "resourceBaseURI"
    /// <summary>
    ///   <para>rdfs:label : Result size limit^^xsd:string</para>
    ///   <para>rdfs:comment : Enforced upper limit for the size of SQL result sets.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resultSizeLimit">d2rq:resultSizeLimit</a>
    /// </summary>
    let resultSizeLimit = _prefixId.prefix "resultSizeLimit"
    /// <summary>
    ///   <para>rdfs:label : Serve vocabulary^^xsd:string</para>
    ///   <para>rdfs:comment : Whether to serve inferred and user-supplied vocabulary data^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#serveVocabulary">d2rq:serveVocabulary</a>
    /// </summary>
    let serveVocabulary = _prefixId.prefix "serveVocabulary"
    /// <summary>
    ///   <para>rdfs:label : SQL expression^^xsd:string</para>
    ///   <para>rdfs:comment : A SQL expression whose result will be the value of this property bridge.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#sqlExpression">d2rq:sqlExpression</a>
    /// </summary>
    let sqlExpression = _prefixId.prefix "sqlExpression"
    /// <summary>
    ///   <para>rdfs:label : Startup SQL script^^xsd:string</para>
    ///   <para>rdfs:comment : URL of a SQL script that will be run on startup.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#startupSQLScript">d2rq:startupSQLScript</a>
    /// </summary>
    let startupSQLScript = _prefixId.prefix "startupSQLScript"
    /// <summary>
    ///   <para>rdfs:label : Text column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of a character type, such as CHAR, VARCHAR, NVARCHAR or CLOB.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#textColumn">d2rq:textColumn</a>
    /// </summary>
    let textColumn = _prefixId.prefix "textColumn"
    /// <summary>
    ///   <para>rdfs:label : TIME column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type TIME.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timeColumn">d2rq:timeColumn</a>
    /// </summary>
    let timeColumn = _prefixId.prefix "timeColumn"
    /// <summary>
    ///   <para>rdfs:label : TIMESTAMP column^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a column of type TIMESTAMP.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timestampColumn">d2rq:timestampColumn</a>
    /// </summary>
    let timestampColumn = _prefixId.prefix "timestampColumn"
    /// <summary>
    ///   <para>rdfs:label : Translate with^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translateWith">d2rq:translateWith</a>
    /// </summary>
    let translateWith = _prefixId.prefix "translateWith"
    /// <summary>
    ///   <para>rdfs:label : Translation^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translation">d2rq:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:label : URI column^^xsd:string</para>
    ///   <para>rdfs:comment : Database column which contains URIs.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriColumn">d2rq:uriColumn</a>
    /// </summary>
    let uriColumn = _prefixId.prefix "uriColumn"
    /// <summary>
    ///   <para>rdfs:label : URI pattern^^xsd:string</para>
    ///   <para>rdfs:comment : URI pattern with placeholders that will be filled with values from a database column.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriPattern">d2rq:uriPattern</a>
    /// </summary>
    let uriPattern = _prefixId.prefix "uriPattern"
    /// <summary>
    ///   <para>rdfs:label : URI SQL expression^^xsd:string</para>
    ///   <para>rdfs:comment : An SQL expression whose result will be the URI value of this property bridge.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriSqlExpression">d2rq:uriSqlExpression</a>
    /// </summary>
    let uriSqlExpression = _prefixId.prefix "uriSqlExpression"
    /// <summary>
    ///   <para>rdfs:label : Use all optimizations^^xsd:string</para>
    ///   <para>rdfs:comment : Whether to use bleeding edge optimizations^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#useAllOptimizations">d2rq:useAllOptimizations</a>
    /// </summary>
    let useAllOptimizations = _prefixId.prefix "useAllOptimizations"
    /// <summary>
    ///   <para>rdfs:label : User name^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#username">d2rq:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
    /// <summary>
    ///   <para>rdfs:label : Value contains^^xsd:string</para>
    ///   <para>rdfs:comment : Optimizing hint: a string contained in every value of this resource map.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueContains">d2rq:valueContains</a>
    /// </summary>
    let valueContains = _prefixId.prefix "valueContains"
    /// <summary>
    ///   <para>rdfs:label : Value max length^^xsd:string</para>
    ///   <para>rdfs:comment : Optimizing hint: the maximum length of values of this resource map.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueMaxLength">d2rq:valueMaxLength</a>
    /// </summary>
    let valueMaxLength = _prefixId.prefix "valueMaxLength"
    /// <summary>
    ///   <para>rdfs:label : Value regex^^xsd:string</para>
    ///   <para>rdfs:comment : Optimizing hint: a regular expression matching every value of this resource map.^^xsd:string</para>
    ///   <a href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueRegex">d2rq:valueRegex</a>
    /// </summary>
    let valueRegex = _prefixId.prefix "valueRegex"
