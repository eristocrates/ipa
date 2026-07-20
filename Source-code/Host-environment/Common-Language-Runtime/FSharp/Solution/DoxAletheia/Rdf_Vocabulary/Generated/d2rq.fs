namespace http.www.wiwiss.fu_berlin.de.suhl.bizer.D2RQ._0._1.hash

open DoxAletheia

module d2rq =
    let _namespace_name = "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents an additional property that may be added to instances as well as class and property definitions.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#AdditionalProperty"></see></summary>
    let AdditionalProperty = _prefix "AdditionalProperty"
    /// <summary>
    /// Maps an RDFS or OWL class to its database representation.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ClassMap"></see></summary>
    let ClassMap = _prefix "ClassMap"
    /// <summary>
    /// A database-to-RDF mapping from one or more database columns to a set of RDF resources. An abstract class, usually not used directly.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ResourceMap"></see></summary>
    let ResourceMap = _prefix "ResourceMap"
    /// <summary>
    /// Represents general settings.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Configuration"></see></summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    /// Jena Assemler specification for a relational database, mapped to RDF using the D2RQ tool.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#D2RQModel"></see></summary>
    let D2RQModel = _prefix "D2RQModel"
    /// <summary>
    /// Represents a database.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    /// (Deprecated) Maps a datatype property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DatatypePropertyBridge"></see></summary>
    let DatatypePropertyBridge = _prefix "DatatypePropertyBridge"
    /// <summary>
    /// Maps an RDF property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#PropertyBridge"></see></summary>
    let PropertyBridge = _prefix "PropertyBridge"
    /// <summary>
    /// Makes the contents of some database column downloadable.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DownloadMap"></see></summary>
    let DownloadMap = _prefix "DownloadMap"
    /// <summary>
    /// (Deprecated) Maps an object property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ObjectPropertyBridge"></see></summary>
    let ObjectPropertyBridge = _prefix "ObjectPropertyBridge"
    /// <summary>
    /// Translation Key/Value Pair.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Translation"></see></summary>
    let Translation = _prefix "Translation"
    /// <summary>
    /// Lookup table for translations used in the mapping process.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#TranslationTable"></see></summary>
    let TranslationTable = _prefix "TranslationTable"
    /// <summary>
    /// An additional property to be served for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalClassDefinitionProperty"></see></summary>
    let additionalClassDefinitionProperty = _prefix "additionalClassDefinitionProperty"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalProperty"></see>
    /// </summary>
    let additionalProperty = _prefix "additionalProperty"

    /// <summary>
    /// An additional property to be served for all associated property definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalPropertyDefinitionProperty"></see></summary>
    let additionalPropertyDefinitionProperty =
        _prefix "additionalPropertyDefinitionProperty"

    /// <summary>
    /// TABLE AS ALIAS declaration for establishing an alternate table name.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#alias"></see></summary>
    let alias = _prefix "alias"
    /// <summary>
    /// Value: true/false that describe the databases ability to handle DISTINCT correctly. Deprecated, the engine now determines this automatically.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#allowDistinct"></see></summary>
    let allowDistinct = _prefix "allowDistinct"
    /// <summary>
    /// Comma-separated list of database columns used for construction of blank nodes.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bNodeIdColumns"></see></summary>
    let bNodeIdColumns = _prefix "bNodeIdColumns"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#belongsToClassMap"></see>
    /// </summary>
    let belongsToClassMap = _prefix "belongsToClassMap"
    /// <summary>
    /// Name of a column of a binary type, such as BINARY, VARBINARY or BLOB.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#binaryColumn"></see></summary>
    let binaryColumn = _prefix "binaryColumn"
    /// <summary>
    /// Name of a column of type BIT.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bitColumn"></see></summary>
    let bitColumn = _prefix "bitColumn"
    /// <summary>
    /// Name of a column of type BOOLEAN.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#booleanColumn"></see></summary>
    let booleanColumn = _prefix "booleanColumn"
    /// <summary>
    /// Links d2rq:classMaps to RDFS or OWL classes.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// Used to link RDFS or OWL classes to d2r:classMaps. Deprecated, use inverse d2rq:class instead.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classMap"></see></summary>
    let classMap = _prefix "classMap"
    /// <summary>
    /// A comment to be served as rdfs:comment for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionComment"></see></summary>
    let classDefinitionComment = _prefix "classDefinitionComment"
    /// <summary>
    /// A label to be served as rdfs:label for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionLabel"></see></summary>
    let classDefinitionLabel = _prefix "classDefinitionLabel"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#column"></see>
    /// </summary>
    let column = _prefix "column"
    /// <summary>
    /// SQL WHERE condition that must be satisfied for a database row to be mapped.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#condition"></see></summary>
    let condition = _prefix "condition"
    /// <summary>
    /// A constant RDF node to be used as the value of this property bridge, or as the resource of a singleton class map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#constantValue"></see></summary>
    let constantValue = _prefix "constantValue"
    /// <summary>
    /// Set to true if the table, after applying d2rq:joins and d2rq:conditions, may contain duplicate records.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#containsDuplicates"></see></summary>
    let containsDuplicates = _prefix "containsDuplicates"
    /// <summary>
    /// A database column containing data to be made downloadable.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#contentDownloadColumn"></see></summary>
    let contentDownloadColumn = _prefix "contentDownloadColumn"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dataStorage"></see>
    /// </summary>
    let dataStorage = _prefix "dataStorage"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#databaseValue"></see>
    /// </summary>
    let databaseValue = _prefix "databaseValue"
    /// <summary>
    /// The datatype of literals created by this bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// Name of a column of type DATE.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dateColumn"></see></summary>
    let dateColumn = _prefix "dateColumn"
    /// <summary>
    /// Links a d2rq:PropertyBridge to a dynamic property.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dynamicProperty"></see></summary>
    let dynamicProperty = _prefix "dynamicProperty"
    /// <summary>
    /// The number of rows that should be fetched from the database at once
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#fetchSize"></see></summary>
    let fetchSize = _prefix "fetchSize"
    /// <summary>
    /// Link to a translation table in an external CSV file.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#href"></see></summary>
    let href = _prefix "href"
    /// <summary>
    /// Name of a column of type INTERVAL.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#intervalColumn"></see></summary>
    let intervalColumn = _prefix "intervalColumn"
    /// <summary>
    /// Qualified name of a Java class that implements de.fuberlin.wiwiss.d2rq.Translator and translates between database and RDF.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#javaClass"></see></summary>
    let javaClass = _prefix "javaClass"
    /// <summary>
    /// JDBC data source name.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDSN"></see></summary>
    let jdbcDSN = _prefix "jdbcDSN"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDriver"></see>
    /// </summary>
    let jdbcDriver = _prefix "jdbcDriver"
    /// <summary>
    /// SQL join condition over tables in the database.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#join"></see></summary>
    let join = _prefix "join"
    /// <summary>
    /// The language tag of literals created by this bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#lang"></see></summary>
    let lang = _prefix "lang"
    /// <summary>
    /// The number of results to retrieve from the database for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limit"></see></summary>
    let limit = _prefix "limit"
    /// <summary>
    /// The number of results to retrieve from the database for the inverse statements for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limitInverse"></see></summary>
    let limitInverse = _prefix "limitInverse"
    /// <summary>
    /// URL of a D2RQ mapping file.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mappingFile"></see></summary>
    let mappingFile = _prefix "mappingFile"
    /// <summary>
    /// The Internet media type, such as image/png, of the downloadable content, suitable for use in the HTTP Content-Type header.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    /// Name of a column of a numeric type, such as INT or DOUBLE or DECIMAL.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#numericColumn"></see></summary>
    let numericColumn = _prefix "numericColumn"
    /// <summary>
    /// ODBC DSN
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#odbcDSN"></see></summary>
    let odbcDSN = _prefix "odbcDSN"
    /// <summary>
    /// The column after which to sort results in ascending order for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderAsc"></see></summary>
    let orderAsc = _prefix "orderAsc"
    /// <summary>
    /// The column after which to sort results in descending order for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderDesc"></see></summary>
    let orderDesc = _prefix "orderDesc"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#password"></see>
    /// </summary>
    let password = _prefix "password"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#pattern"></see>
    /// </summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// Links a d2rq:PropertyBridge to an RDF property.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// Used for linking RDFS properties to D2R property bridges. Deprecated, use inverse d2rq:property instead.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyBridge"></see></summary>
    let propertyBridge = _prefix "propertyBridge"
    /// <summary>
    /// A comment to be served as rdfs:comment for all associated properties
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionComment"></see></summary>
    let propertyDefinitionComment = _prefix "propertyDefinitionComment"
    /// <summary>
    /// A label to be served as rdfs:label for all associated properties
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionLabel"></see></summary>
    let propertyDefinitionLabel = _prefix "propertyDefinitionLabel"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyName"></see>
    /// </summary>
    let propertyName = _prefix "propertyName"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyValue"></see>
    /// </summary>
    let propertyValue = _prefix "propertyValue"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#rdfValue"></see>
    /// </summary>
    let rdfValue = _prefix "rdfValue"
    /// <summary>
    /// Has to be used if a join refers to a different classMap.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#refersToClassMap"></see></summary>
    let refersToClassMap = _prefix "refersToClassMap"
    /// <summary>
    /// Base URI for resources generated by relative URI patterns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resourceBaseURI"></see></summary>
    let resourceBaseURI = _prefix "resourceBaseURI"
    /// <summary>
    /// Enforced upper limit for the size of SQL result sets.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resultSizeLimit"></see></summary>
    let resultSizeLimit = _prefix "resultSizeLimit"
    /// <summary>
    /// Whether to serve inferred and user-supplied vocabulary data
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#serveVocabulary"></see></summary>
    let serveVocabulary = _prefix "serveVocabulary"
    /// <summary>
    /// A SQL expression whose result will be the value of this property bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#sqlExpression"></see></summary>
    let sqlExpression = _prefix "sqlExpression"
    /// <summary>
    /// URL of a SQL script that will be run on startup.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#startupSQLScript"></see></summary>
    let startupSQLScript = _prefix "startupSQLScript"
    /// <summary>
    /// Name of a column of a character type, such as CHAR, VARCHAR, NVARCHAR or CLOB.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#textColumn"></see></summary>
    let textColumn = _prefix "textColumn"
    /// <summary>
    /// Name of a column of type TIME.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timeColumn"></see></summary>
    let timeColumn = _prefix "timeColumn"
    /// <summary>
    /// Name of a column of type TIMESTAMP.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timestampColumn"></see></summary>
    let timestampColumn = _prefix "timestampColumn"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translateWith"></see>
    /// </summary>
    let translateWith = _prefix "translateWith"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translation"></see>
    /// </summary>
    let translation = _prefix "translation"
    /// <summary>
    /// Database column which contains URIs.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriColumn"></see></summary>
    let uriColumn = _prefix "uriColumn"
    /// <summary>
    /// URI pattern with placeholders that will be filled with values from a database column.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriPattern"></see></summary>
    let uriPattern = _prefix "uriPattern"
    /// <summary>
    /// An SQL expression whose result will be the URI value of this property bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriSqlExpression"></see></summary>
    let uriSqlExpression = _prefix "uriSqlExpression"
    /// <summary>
    /// Whether to use bleeding edge optimizations
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#useAllOptimizations"></see></summary>
    let useAllOptimizations = _prefix "useAllOptimizations"
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#username"></see>
    /// </summary>
    let username = _prefix "username"
    /// <summary>
    /// Optimizing hint: a string contained in every value of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueContains"></see></summary>
    let valueContains = _prefix "valueContains"
    /// <summary>
    /// Optimizing hint: the maximum length of values of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueMaxLength"></see></summary>
    let valueMaxLength = _prefix "valueMaxLength"
    /// <summary>
    /// Optimizing hint: a regular expression matching every value of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueRegex"></see></summary>
    let valueRegex = _prefix "valueRegex"
