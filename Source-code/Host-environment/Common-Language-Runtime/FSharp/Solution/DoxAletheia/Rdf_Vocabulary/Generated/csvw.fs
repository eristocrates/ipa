namespace http.www.w3.org.ns.csvw.hash

open DoxAletheia

module csvw =
    let _namespace_name = "http://www.w3.org/ns/csvw#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Cell represents a cell at the intersection of a Row and a Column within a Table.
    /// <see href="http://www.w3.org/ns/csvw#Cell"></see></summary>
    let Cell = _prefix "Cell"
    /// <summary>
    /// A Column represents a vertical arrangement of Cells within a Table.
    /// <see href="http://www.w3.org/ns/csvw#Column"></see></summary>
    let Column = _prefix "Column"
    /// <summary>
    /// Describes facets of a datatype.
    /// <see href="http://www.w3.org/ns/csvw#Datatype"></see></summary>
    let Datatype = _prefix "Datatype"
    /// <summary>
    /// A Dialect Description provides hints to parsers about how to parse a linked file.
    /// <see href="http://www.w3.org/ns/csvw#Dialect"></see></summary>
    let Dialect = _prefix "Dialect"
    /// <summary>
    /// The class of table/text directions.
    /// <see href="http://www.w3.org/ns/csvw#Direction"></see></summary>
    let Direction = _prefix "Direction"
    /// <summary>
    /// Describes relationships between Columns in one or more Tables.
    /// <see href="http://www.w3.org/ns/csvw#ForeignKey"></see></summary>
    let ForeignKey = _prefix "ForeignKey"
    /// <summary>
    /// A literal containing JSON.
    /// <see href="http://www.w3.org/ns/csvw#JSON"></see></summary>
    let JSON = _prefix "JSON"
    /// <summary>
    /// If the datatype is a numeric type, the format property indicates the expected format for that number. Its value must be either a single string or an object with one or more properties.
    /// <see href="http://www.w3.org/ns/csvw#NumericFormat"></see></summary>
    let NumericFormat = _prefix "NumericFormat"
    /// <summary>
    /// A Row represents a horizontal arrangement of cells within a Table.
    /// <see href="http://www.w3.org/ns/csvw#Row"></see></summary>
    let Row = _prefix "Row"
    /// <summary>
    /// A Schema is a definition of a tabular format that may be common to multiple tables.
    /// <see href="http://www.w3.org/ns/csvw#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    /// An annotated table is a table that is annotated with additional metadata.
    /// <see href="http://www.w3.org/ns/csvw#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// A Group of Tables comprises a set of Annotated Tables and a set of annotations that relate to those Tables.
    /// <see href="http://www.w3.org/ns/csvw#TableGroup"></see></summary>
    let TableGroup = _prefix "TableGroup"
    /// <summary>
    /// An object property that identifies a referenced table and a set of referenced columns within that table.
    /// <see href="http://www.w3.org/ns/csvw#TableReference"></see></summary>
    let TableReference = _prefix "TableReference"
    /// <summary>
    /// A Transformation Definition is a definition of how tabular data can be transformed into another format.
    /// <see href="http://www.w3.org/ns/csvw#Transformation"></see></summary>
    let Transformation = _prefix "Transformation"
    /// <summary>
    /// A URI template property that MAY be used to indicate what a cell contains information about.
    /// <see href="http://www.w3.org/ns/csvw#aboutUrl"></see></summary>
    let aboutUrl = _prefix "aboutUrl"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/csvw#uriTemplate"></see>
    /// </summary>
    let uriTemplate = _prefix "uriTemplate"
    /// <summary>
    /// Determins text direction based on the first character that has a specific direction.
    /// <see href="http://www.w3.org/ns/csvw#auto"></see></summary>
    let auto = _prefix "auto"
    /// <summary>
    /// An atomic property that contains a single string: a term defined in the default context representing a built-in datatype URL, as listed above.
    /// <see href="http://www.w3.org/ns/csvw#base"></see></summary>
    let base_ = _prefix "base"
    /// <summary>
    /// An array property of column descriptions as described in section 5.6 Columns.
    /// <see href="http://www.w3.org/ns/csvw#column"></see></summary>
    let column = _prefix "column"
    /// <summary>
    /// A column reference property that holds either a single reference to a column description object within this schema, or an array of references. These form the referencing columns for the foreign key definition.
    /// <see href="http://www.w3.org/ns/csvw#columnReference"></see></summary>
    let columnReference = _prefix "columnReference"
    /// <summary>
    /// An atomic property that sets the comment prefix flag to the single provided value, which MUST be a string.
    /// <see href="http://www.w3.org/ns/csvw#commentPrefix"></see></summary>
    let commentPrefix = _prefix "commentPrefix"
    /// <summary>
    /// Describes the role of a CSV file in the tabular data mapping.
    /// <see href="http://www.w3.org/ns/csvw#csvEncodedTabularData"></see></summary>
    let csvEncodedTabularData = _prefix "csvEncodedTabularData"
    /// <summary>
    /// An object property that contains either a single string that is the main datatype of the values of the cell or a datatype description object. If the value of this property is a string, it MUST be one of the built-in datatypes defined in section 5.11.1 Built-in Datatypes or an absolute URL; if it is an object then it describes a more specialised datatype.
    /// <see href="http://www.w3.org/ns/csvw#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// A string whose value is used to represent a decimal point within the number.
    /// <see href="http://www.w3.org/ns/csvw#decimalChar"></see></summary>
    let decimalChar = _prefix "decimalChar"
    /// <summary>
    /// An atomic property holding a single string that is used to create a default value for the cell in cases where the original string value is an empty string.
    /// <see href="http://www.w3.org/ns/csvw#default"></see></summary>
    let default_ = _prefix "default"
    /// <summary>
    /// An atomic property that sets the delimiter flag to the single provided value, which MUST be a string.
    /// <see href="http://www.w3.org/ns/csvw#delimiter"></see></summary>
    let delimiter = _prefix "delimiter"
    /// <summary>
    /// From IANA describes: The relationship A 'describes' B asserts that resource A provides a description of resource B. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource.
    /// <see href="http://www.w3.org/ns/csvw#describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// An object property that provides a single dialect description. If provided, dialect provides hints to processors about how to parse the referenced files to create tabular data models for the tables in the group.
    /// <see href="http://www.w3.org/ns/csvw#dialect"></see></summary>
    let dialect = _prefix "dialect"
    /// <summary>
    /// A boolean atomic property that, if `true`, sets the escape character flag to `"`.
    /// <see href="http://www.w3.org/ns/csvw#doubleQuote"></see></summary>
    let doubleQuote = _prefix "doubleQuote"
    /// <summary>
    /// An atomic property that sets the encoding flag to the single provided string value, which MUST be a defined in [[encoding]]. The default is "utf-8".
    /// <see href="http://www.w3.org/ns/csvw#encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// For a Table: a list of foreign keys on the table.
    ///
    /// For a Schema: an array property of foreign key definitions that define how the values from specified columns within this table link to rows within this table or other tables.
    /// <see href="http://www.w3.org/ns/csvw#foreignKey"></see></summary>
    let foreignKey = _prefix "foreignKey"
    /// <summary>
    /// An atomic property that contains either a single string or an object that defines the format of a value of this type, used when parsing a string value as described in Parsing Cells in [[tabular-data-model]].
    /// <see href="http://www.w3.org/ns/csvw#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// A string whose value is used to group digits within the number.
    /// <see href="http://www.w3.org/ns/csvw#groupChar"></see></summary>
    let groupChar = _prefix "groupChar"
    /// <summary>
    /// A boolean atomic property that, if `true`, sets the header row count flag to `1`, and if `false` to `0`, unless headerRowCount is provided, in which case the value provided for the header property is ignored.
    /// <see href="http://www.w3.org/ns/csvw#header"></see></summary>
    let header = _prefix "header"
    /// <summary>
    /// An numeric atomic property that sets the header row count flag to the single provided value, which must be a non-negative integer.
    /// <see href="http://www.w3.org/ns/csvw#headerRowCount"></see></summary>
    let headerRowCount = _prefix "headerRowCount"
    /// <summary>
    /// An atomic property giving a single string language code as defined by [[BCP47]].
    /// <see href="http://www.w3.org/ns/csvw#lang"></see></summary>
    let lang = _prefix "lang"
    /// <summary>
    /// The exact length of the value of the cell.
    /// <see href="http://www.w3.org/ns/csvw#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// An atomic property that sets the line terminators flag to either an array containing the single provided string value, or the provided array.
    /// <see href="http://www.w3.org/ns/csvw#lineTerminators"></see></summary>
    let lineTerminators = _prefix "lineTerminators"
    /// <summary>
    /// Indicates text should be processed left to right.
    /// <see href="http://www.w3.org/ns/csvw#ltr"></see></summary>
    let ltr = _prefix "ltr"
    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/csvw#maxExclusive"></see></summary>
    let maxExclusive = _prefix "maxExclusive"
    /// <summary>
    /// An atomic property that contains a single number that is the maximum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/csvw#maxInclusive"></see></summary>
    let maxInclusive = _prefix "maxInclusive"
    /// <summary>
    /// A numeric atomic property that contains a single integer that is the maximum length of the value.
    /// <see href="http://www.w3.org/ns/csvw#maxLength"></see></summary>
    let maxLength = _prefix "maxLength"
    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (exclusive).
    /// <see href="http://www.w3.org/ns/csvw#minExclusive"></see></summary>
    let minExclusive = _prefix "minExclusive"
    /// <summary>
    /// An atomic property that contains a single number that is the minimum valid value (inclusive).
    /// <see href="http://www.w3.org/ns/csvw#minInclusive"></see></summary>
    let minInclusive = _prefix "minInclusive"
    /// <summary>
    /// An atomic property that contains a single integer that is the minimum length of the value.
    /// <see href="http://www.w3.org/ns/csvw#minLength"></see></summary>
    let minLength = _prefix "minLength"
    /// <summary>
    /// An atomic property that gives a single canonical name for the column. The value of this property becomes the name annotation for the described column.
    /// <see href="http://www.w3.org/ns/csvw#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// An array property that provides an array of objects representing arbitrary annotations on the annotated tabular data model.
    /// <see href="http://www.w3.org/ns/csvw#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// An atomic property giving the string or strings used for null values within the data. If the string value of the cell is equal to any one of these values, the cell value is `null`.
    /// <see href="http://www.w3.org/ns/csvw#null"></see></summary>
    let null_ = _prefix "null"
    /// <summary>
    /// A boolean atomic property taking a single value which indicates whether a list that is the value of the cell is ordered (if `true`) or unordered (if `false`).
    /// <see href="http://www.w3.org/ns/csvw#ordered"></see></summary>
    let ordered = _prefix "ordered"
    /// <summary>
    /// A regular expression string, in the syntax and interpreted as defined by [[ECMASCRIPT]].
    /// <see href="http://www.w3.org/ns/csvw#pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// For Schema: A column reference property that holds either a single reference to a column description object or an array of references.
    ///
    /// For Row: a possibly empty list of cells whose values together provide a unique identifier for this row. This is similar to the name of a column.
    /// <see href="http://www.w3.org/ns/csvw#primaryKey"></see></summary>
    let primaryKey = _prefix "primaryKey"
    /// <summary>
    /// An URI template property that MAY be used to create a URI for a property if the table is mapped to another format.
    /// <see href="http://www.w3.org/ns/csvw#propertyUrl"></see></summary>
    let propertyUrl = _prefix "propertyUrl"
    /// <summary>
    /// An atomic property that sets the quote character flag to the single provided value, which must be a string or `null`.
    /// <see href="http://www.w3.org/ns/csvw#quoteChar"></see></summary>
    let quoteChar = _prefix "quoteChar"
    /// <summary>
    /// An object property that identifies a **referenced table** and a set of **referenced columns** within that table.
    /// <see href="http://www.w3.org/ns/csvw#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// A possibly empty list of pairs of a foreign key and a row in a table within the same group of tables.
    /// <see href="http://www.w3.org/ns/csvw#referencedRow"></see></summary>
    let referencedRow = _prefix "referencedRow"
    /// <summary>
    /// A boolean atomic property taking a single value which indicates whether the cell must have a non-null value. The default is `false`.
    /// <see href="http://www.w3.org/ns/csvw#required"></see></summary>
    let required = _prefix "required"
    /// <summary>
    /// A link property holding a URL that is the identifier for a specific table that is being referenced.
    /// <see href="http://www.w3.org/ns/csvw#resource"></see></summary>
    let resource = _prefix "resource"
    /// <summary>
    /// Relates a Table to each Row output.
    /// <see href="http://www.w3.org/ns/csvw#row"></see></summary>
    let row = _prefix "row"
    /// <summary>
    /// A column reference property that holds either a single reference to a column description object or an array of references.
    /// <see href="http://www.w3.org/ns/csvw#rowTitle"></see></summary>
    let rowTitle = _prefix "rowTitle"
    /// <summary>
    /// The position of the row amongst the rows of the Annotated Tabl, starting from 1
    /// <see href="http://www.w3.org/ns/csvw#rownum"></see></summary>
    let rownum = _prefix "rownum"
    /// <summary>
    /// Indiects text should be processed right to left
    /// <see href="http://www.w3.org/ns/csvw#rtl"></see></summary>
    let rtl = _prefix "rtl"
    /// <summary>
    /// A link property holding a URL that is the identifier for a schema that is being referenced.
    /// <see href="http://www.w3.org/ns/csvw#schemaReference"></see></summary>
    let schemaReference = _prefix "schemaReference"
    /// <summary>
    /// A link property giving the single URL for the format that is used by the script or template.
    /// <see href="http://www.w3.org/ns/csvw#scriptFormat"></see></summary>
    let scriptFormat = _prefix "scriptFormat"
    /// <summary>
    /// An atomic property that MUST have a single string value that is the character used to separate items in the string value of the cell.
    /// <see href="http://www.w3.org/ns/csvw#separator"></see></summary>
    let separator = _prefix "separator"
    /// <summary>
    /// An boolean atomic property that sets the `skip blank rows` flag to the single provided boolean value.
    /// <see href="http://www.w3.org/ns/csvw#skipBlankRows"></see></summary>
    let skipBlankRows = _prefix "skipBlankRows"
    /// <summary>
    /// An numeric atomic property that sets the `skip columns` flag to the single provided numeric value, which MUST be a non-negative integer.
    /// <see href="http://www.w3.org/ns/csvw#skipColumns"></see></summary>
    let skipColumns = _prefix "skipColumns"
    /// <summary>
    /// A boolean atomic property that, if `true`, sets the trim flag to "start". If `false`, to `false`.
    /// <see href="http://www.w3.org/ns/csvw#skipInitialSpace"></see></summary>
    let skipInitialSpace = _prefix "skipInitialSpace"
    /// <summary>
    /// An numeric atomic property that sets the `skip rows` flag to the single provided numeric value, which MUST be a non-negative integer.
    /// <see href="http://www.w3.org/ns/csvw#skipRows"></see></summary>
    let skipRows = _prefix "skipRows"
    /// <summary>
    /// A single string atomic property that provides, if specified, the format to which the tabular data should be transformed prior to the transformation using the script or template.
    /// <see href="http://www.w3.org/ns/csvw#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// A boolean atomic property. If `true`, suppresses any output that would be generated when converting a table or cells within a column.
    /// <see href="http://www.w3.org/ns/csvw#suppressOutput"></see></summary>
    let suppressOutput = _prefix "suppressOutput"
    /// <summary>
    /// Relates an Table group to annotated tables.
    /// <see href="http://www.w3.org/ns/csvw#table"></see></summary>
    let table = _prefix "table"
    /// <summary>
    /// One of `rtl`, `ltr` or `auto`. Indicates whether the tables in the group should be displayed with the first column on the right, on the left, or based on the first character in the table that has a specific direction.
    /// <see href="http://www.w3.org/ns/csvw#tableDirection"></see></summary>
    let tableDirection = _prefix "tableDirection"
    /// <summary>
    /// An object property that provides a single schema description as described in section 5.5 Schemas, used as the default for all the tables in the group
    /// <see href="http://www.w3.org/ns/csvw#tableSchema"></see></summary>
    let tableSchema = _prefix "tableSchema"
    /// <summary>
    /// Describes the role of a Metadata file in the tabular data mapping.
    /// <see href="http://www.w3.org/ns/csvw#tabularMetadata"></see></summary>
    let tabularMetadata = _prefix "tabularMetadata"
    /// <summary>
    /// A link property giving the single URL for the format that will be created through the transformation.
    /// <see href="http://www.w3.org/ns/csvw#targetFormat"></see></summary>
    let targetFormat = _prefix "targetFormat"
    /// <summary>
    /// An atomic property that must have a single value that is one of `rtl` or `ltr` (the default).
    /// <see href="http://www.w3.org/ns/csvw#textDirection"></see></summary>
    let textDirection = _prefix "textDirection"
    /// <summary>
    /// For a Transformation A natural language property that describes the format that will be generated from the transformation.
    ///
    /// For a Column: A natural language property that provides possible alternative names for the column.
    /// <see href="http://www.w3.org/ns/csvw#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// An array property of transformation definitions that provide mechanisms to transform the tabular data into other formats.
    /// <see href="http://www.w3.org/ns/csvw#transformations"></see></summary>
    let transformations = _prefix "transformations"
    /// <summary>
    /// An atomic property that, if the boolean `true`, sets the trim flag to `true` and if the boolean `false` to `false`. If the value provided is a string, sets the trim flag to the provided value, which must be one of "true", "false", "start" or "end".
    /// <see href="http://www.w3.org/ns/csvw#trim"></see></summary>
    let trim = _prefix "trim"
    /// <summary>
    /// For a Table: This link property gives the single URL of the CSV file that the table is held in, relative to the location of the metadata document.
    ///
    /// For a Transformation: A link property giving the single URL of the file that the script or template is held in, relative to the location of the metadata document.
    /// <see href="http://www.w3.org/ns/csvw#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// An URI template property that is used to map the values of cells into URLs.
    /// <see href="http://www.w3.org/ns/csvw#valueUrl"></see></summary>
    let valueUrl = _prefix "valueUrl"
    /// <summary>
    /// A boolean atomic property taking a single value which indicates whether the column is a virtual column not present in the original source
    /// <see href="http://www.w3.org/ns/csvw#virtual"></see></summary>
    let virtual_ = _prefix "virtual"
