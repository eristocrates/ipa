namespace http.www.wiwiss.fu_berlin.de.suhl.bizer.D2RQ._0._1.hash

open DoxAletheia.Rdf_Vocabulary

module d2rq =
    let _namespace_name = "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#"

    /// <summary>
    /// Represents an additional property that may be added to instances as well as class and property definitions.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#AdditionalProperty"></see></summary>
    let AdditionalProperty =
        Namespaced_IRI.parse _namespace_name "AdditionalProperty" |> NamespacedName

    /// <summary>
    /// Maps an RDFS or OWL class to its database representation.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ClassMap"></see></summary>
    let ClassMap = Namespaced_IRI.parse _namespace_name "ClassMap" |> NamespacedName

    /// <summary>
    /// A database-to-RDF mapping from one or more database columns to a set of RDF resources. An abstract class, usually not used directly.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ResourceMap"></see></summary>
    let ResourceMap =
        Namespaced_IRI.parse _namespace_name "ResourceMap" |> NamespacedName

    /// <summary>
    /// Represents general settings.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Configuration"></see></summary>
    let Configuration =
        Namespaced_IRI.parse _namespace_name "Configuration" |> NamespacedName

    /// <summary>
    /// Jena Assemler specification for a relational database, mapped to RDF using the D2RQ tool.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#D2RQModel"></see></summary>
    let D2RQModel = Namespaced_IRI.parse _namespace_name "D2RQModel" |> NamespacedName
    /// <summary>
    /// Represents a database.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// (Deprecated) Maps a datatype property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DatatypePropertyBridge"></see></summary>
    let DatatypePropertyBridge =
        Namespaced_IRI.parse _namespace_name "DatatypePropertyBridge" |> NamespacedName

    /// <summary>
    /// Maps an RDF property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#PropertyBridge"></see></summary>
    let PropertyBridge =
        Namespaced_IRI.parse _namespace_name "PropertyBridge" |> NamespacedName

    /// <summary>
    /// Makes the contents of some database column downloadable.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#DownloadMap"></see></summary>
    let DownloadMap =
        Namespaced_IRI.parse _namespace_name "DownloadMap" |> NamespacedName

    /// <summary>
    /// (Deprecated) Maps an object property to one or more database columns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#ObjectPropertyBridge"></see></summary>
    let ObjectPropertyBridge =
        Namespaced_IRI.parse _namespace_name "ObjectPropertyBridge" |> NamespacedName

    /// <summary>
    /// Translation Key/Value Pair.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#Translation"></see></summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    /// Lookup table for translations used in the mapping process.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#TranslationTable"></see></summary>
    let TranslationTable =
        Namespaced_IRI.parse _namespace_name "TranslationTable" |> NamespacedName

    /// <summary>
    /// An additional property to be served for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalClassDefinitionProperty"></see></summary>
    let additionalClassDefinitionProperty =
        Namespaced_IRI.parse _namespace_name "additionalClassDefinitionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalProperty"></see>
    /// </summary>
    let additionalProperty =
        Namespaced_IRI.parse _namespace_name "additionalProperty" |> NamespacedName

    /// <summary>
    /// An additional property to be served for all associated property definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#additionalPropertyDefinitionProperty"></see></summary>
    let additionalPropertyDefinitionProperty =
        Namespaced_IRI.parse _namespace_name "additionalPropertyDefinitionProperty" |> NamespacedName

    /// <summary>
    /// TABLE AS ALIAS declaration for establishing an alternate table name.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName

    /// <summary>
    /// Value: true/false that describe the databases ability to handle DISTINCT correctly. Deprecated, the engine now determines this automatically.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#allowDistinct"></see></summary>
    let allowDistinct =
        Namespaced_IRI.parse _namespace_name "allowDistinct" |> NamespacedName

    /// <summary>
    /// Comma-separated list of database columns used for construction of blank nodes.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bNodeIdColumns"></see></summary>
    let bNodeIdColumns =
        Namespaced_IRI.parse _namespace_name "bNodeIdColumns" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#belongsToClassMap"></see>
    /// </summary>
    let belongsToClassMap =
        Namespaced_IRI.parse _namespace_name "belongsToClassMap" |> NamespacedName

    /// <summary>
    /// Name of a column of a binary type, such as BINARY, VARBINARY or BLOB.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#binaryColumn"></see></summary>
    let binaryColumn =
        Namespaced_IRI.parse _namespace_name "binaryColumn" |> NamespacedName

    /// <summary>
    /// Name of a column of type BIT.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#bitColumn"></see></summary>
    let bitColumn = Namespaced_IRI.parse _namespace_name "bitColumn" |> NamespacedName

    /// <summary>
    /// Name of a column of type BOOLEAN.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#booleanColumn"></see></summary>
    let booleanColumn =
        Namespaced_IRI.parse _namespace_name "booleanColumn" |> NamespacedName

    /// <summary>
    /// Links d2rq:classMaps to RDFS or OWL classes.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// Used to link RDFS or OWL classes to d2r:classMaps. Deprecated, use inverse d2rq:class instead.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classMap"></see></summary>
    let classMap = Namespaced_IRI.parse _namespace_name "classMap" |> NamespacedName

    /// <summary>
    /// A comment to be served as rdfs:comment for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionComment"></see></summary>
    let classDefinitionComment =
        Namespaced_IRI.parse _namespace_name "classDefinitionComment" |> NamespacedName

    /// <summary>
    /// A label to be served as rdfs:label for all associated class definitions
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#classDefinitionLabel"></see></summary>
    let classDefinitionLabel =
        Namespaced_IRI.parse _namespace_name "classDefinitionLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#column"></see>
    /// </summary>
    let column = Namespaced_IRI.parse _namespace_name "column" |> NamespacedName
    /// <summary>
    /// SQL WHERE condition that must be satisfied for a database row to be mapped.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName

    /// <summary>
    /// A constant RDF node to be used as the value of this property bridge, or as the resource of a singleton class map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#constantValue"></see></summary>
    let constantValue =
        Namespaced_IRI.parse _namespace_name "constantValue" |> NamespacedName

    /// <summary>
    /// Set to true if the table, after applying d2rq:joins and d2rq:conditions, may contain duplicate records.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#containsDuplicates"></see></summary>
    let containsDuplicates =
        Namespaced_IRI.parse _namespace_name "containsDuplicates" |> NamespacedName

    /// <summary>
    /// A database column containing data to be made downloadable.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#contentDownloadColumn"></see></summary>
    let contentDownloadColumn =
        Namespaced_IRI.parse _namespace_name "contentDownloadColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dataStorage"></see>
    /// </summary>
    let dataStorage =
        Namespaced_IRI.parse _namespace_name "dataStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#databaseValue"></see>
    /// </summary>
    let databaseValue =
        Namespaced_IRI.parse _namespace_name "databaseValue" |> NamespacedName

    /// <summary>
    /// The datatype of literals created by this bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// Name of a column of type DATE.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dateColumn"></see></summary>
    let dateColumn = Namespaced_IRI.parse _namespace_name "dateColumn" |> NamespacedName

    /// <summary>
    /// Links a d2rq:PropertyBridge to a dynamic property.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#dynamicProperty"></see></summary>
    let dynamicProperty =
        Namespaced_IRI.parse _namespace_name "dynamicProperty" |> NamespacedName

    /// <summary>
    /// The number of rows that should be fetched from the database at once
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#fetchSize"></see></summary>
    let fetchSize = Namespaced_IRI.parse _namespace_name "fetchSize" |> NamespacedName
    /// <summary>
    /// Link to a translation table in an external CSV file.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#href"></see></summary>
    let href = Namespaced_IRI.parse _namespace_name "href" |> NamespacedName

    /// <summary>
    /// Name of a column of type INTERVAL.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#intervalColumn"></see></summary>
    let intervalColumn =
        Namespaced_IRI.parse _namespace_name "intervalColumn" |> NamespacedName

    /// <summary>
    /// Qualified name of a Java class that implements de.fuberlin.wiwiss.d2rq.Translator and translates between database and RDF.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#javaClass"></see></summary>
    let javaClass = Namespaced_IRI.parse _namespace_name "javaClass" |> NamespacedName
    /// <summary>
    /// JDBC data source name.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDSN"></see></summary>
    let jdbcDSN = Namespaced_IRI.parse _namespace_name "jdbcDSN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#jdbcDriver"></see>
    /// </summary>
    let jdbcDriver = Namespaced_IRI.parse _namespace_name "jdbcDriver" |> NamespacedName
    /// <summary>
    /// SQL join condition over tables in the database.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#join"></see></summary>
    let join = Namespaced_IRI.parse _namespace_name "join" |> NamespacedName
    /// <summary>
    /// The language tag of literals created by this bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#lang"></see></summary>
    let lang = Namespaced_IRI.parse _namespace_name "lang" |> NamespacedName
    /// <summary>
    /// The number of results to retrieve from the database for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limit"></see></summary>
    let limit = Namespaced_IRI.parse _namespace_name "limit" |> NamespacedName

    /// <summary>
    /// The number of results to retrieve from the database for the inverse statements for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#limitInverse"></see></summary>
    let limitInverse =
        Namespaced_IRI.parse _namespace_name "limitInverse" |> NamespacedName

    /// <summary>
    /// URL of a D2RQ mapping file.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mappingFile"></see></summary>
    let mappingFile =
        Namespaced_IRI.parse _namespace_name "mappingFile" |> NamespacedName

    /// <summary>
    /// The Internet media type, such as image/png, of the downloadable content, suitable for use in the HTTP Content-Type header.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName

    /// <summary>
    /// Name of a column of a numeric type, such as INT or DOUBLE or DECIMAL.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#numericColumn"></see></summary>
    let numericColumn =
        Namespaced_IRI.parse _namespace_name "numericColumn" |> NamespacedName

    /// <summary>
    /// ODBC DSN
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#odbcDSN"></see></summary>
    let odbcDSN = Namespaced_IRI.parse _namespace_name "odbcDSN" |> NamespacedName
    /// <summary>
    /// The column after which to sort results in ascending order for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderAsc"></see></summary>
    let orderAsc = Namespaced_IRI.parse _namespace_name "orderAsc" |> NamespacedName
    /// <summary>
    /// The column after which to sort results in descending order for this PropertyBridge
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#orderDesc"></see></summary>
    let orderDesc = Namespaced_IRI.parse _namespace_name "orderDesc" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#password"></see>
    /// </summary>
    let password = Namespaced_IRI.parse _namespace_name "password" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#pattern"></see>
    /// </summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName
    /// <summary>
    /// Links a d2rq:PropertyBridge to an RDF property.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// Used for linking RDFS properties to D2R property bridges. Deprecated, use inverse d2rq:property instead.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyBridge"></see></summary>
    let propertyBridge =
        Namespaced_IRI.parse _namespace_name "propertyBridge" |> NamespacedName

    /// <summary>
    /// A comment to be served as rdfs:comment for all associated properties
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionComment"></see></summary>
    let propertyDefinitionComment =
        Namespaced_IRI.parse _namespace_name "propertyDefinitionComment" |> NamespacedName

    /// <summary>
    /// A label to be served as rdfs:label for all associated properties
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyDefinitionLabel"></see></summary>
    let propertyDefinitionLabel =
        Namespaced_IRI.parse _namespace_name "propertyDefinitionLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyName"></see>
    /// </summary>
    let propertyName =
        Namespaced_IRI.parse _namespace_name "propertyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#propertyValue"></see>
    /// </summary>
    let propertyValue =
        Namespaced_IRI.parse _namespace_name "propertyValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#rdfValue"></see>
    /// </summary>
    let rdfValue = Namespaced_IRI.parse _namespace_name "rdfValue" |> NamespacedName

    /// <summary>
    /// Has to be used if a join refers to a different classMap.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#refersToClassMap"></see></summary>
    let refersToClassMap =
        Namespaced_IRI.parse _namespace_name "refersToClassMap" |> NamespacedName

    /// <summary>
    /// Base URI for resources generated by relative URI patterns.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resourceBaseURI"></see></summary>
    let resourceBaseURI =
        Namespaced_IRI.parse _namespace_name "resourceBaseURI" |> NamespacedName

    /// <summary>
    /// Enforced upper limit for the size of SQL result sets.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#resultSizeLimit"></see></summary>
    let resultSizeLimit =
        Namespaced_IRI.parse _namespace_name "resultSizeLimit" |> NamespacedName

    /// <summary>
    /// Whether to serve inferred and user-supplied vocabulary data
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#serveVocabulary"></see></summary>
    let serveVocabulary =
        Namespaced_IRI.parse _namespace_name "serveVocabulary" |> NamespacedName

    /// <summary>
    /// A SQL expression whose result will be the value of this property bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#sqlExpression"></see></summary>
    let sqlExpression =
        Namespaced_IRI.parse _namespace_name "sqlExpression" |> NamespacedName

    /// <summary>
    /// URL of a SQL script that will be run on startup.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#startupSQLScript"></see></summary>
    let startupSQLScript =
        Namespaced_IRI.parse _namespace_name "startupSQLScript" |> NamespacedName

    /// <summary>
    /// Name of a column of a character type, such as CHAR, VARCHAR, NVARCHAR or CLOB.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#textColumn"></see></summary>
    let textColumn = Namespaced_IRI.parse _namespace_name "textColumn" |> NamespacedName
    /// <summary>
    /// Name of a column of type TIME.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timeColumn"></see></summary>
    let timeColumn = Namespaced_IRI.parse _namespace_name "timeColumn" |> NamespacedName

    /// <summary>
    /// Name of a column of type TIMESTAMP.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#timestampColumn"></see></summary>
    let timestampColumn =
        Namespaced_IRI.parse _namespace_name "timestampColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translateWith"></see>
    /// </summary>
    let translateWith =
        Namespaced_IRI.parse _namespace_name "translateWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#translation"></see>
    /// </summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName

    /// <summary>
    /// Database column which contains URIs.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriColumn"></see></summary>
    let uriColumn = Namespaced_IRI.parse _namespace_name "uriColumn" |> NamespacedName
    /// <summary>
    /// URI pattern with placeholders that will be filled with values from a database column.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriPattern"></see></summary>
    let uriPattern = Namespaced_IRI.parse _namespace_name "uriPattern" |> NamespacedName

    /// <summary>
    /// An SQL expression whose result will be the URI value of this property bridge.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#uriSqlExpression"></see></summary>
    let uriSqlExpression =
        Namespaced_IRI.parse _namespace_name "uriSqlExpression" |> NamespacedName

    /// <summary>
    /// Whether to use bleeding edge optimizations
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#useAllOptimizations"></see></summary>
    let useAllOptimizations =
        Namespaced_IRI.parse _namespace_name "useAllOptimizations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#username"></see>
    /// </summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName

    /// <summary>
    /// Optimizing hint: a string contained in every value of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueContains"></see></summary>
    let valueContains =
        Namespaced_IRI.parse _namespace_name "valueContains" |> NamespacedName

    /// <summary>
    /// Optimizing hint: the maximum length of values of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueMaxLength"></see></summary>
    let valueMaxLength =
        Namespaced_IRI.parse _namespace_name "valueMaxLength" |> NamespacedName

    /// <summary>
    /// Optimizing hint: a regular expression matching every value of this resource map.
    /// <see href="http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#valueRegex"></see></summary>
    let valueRegex = Namespaced_IRI.parse _namespace_name "valueRegex" |> NamespacedName
