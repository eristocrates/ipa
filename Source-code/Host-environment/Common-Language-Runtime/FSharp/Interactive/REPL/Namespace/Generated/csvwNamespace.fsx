#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module csvw =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/csvw#" "csvw"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Cell</para>
    ///   <para>rdfs:comment : A Cell represents a cell at the intersection of a Row and a Column within a Table.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Cell">csvw:Cell</a>
    /// </summary>
    let Cell = _prefixId.prefix "Cell"
    /// <summary>
    ///   <para>rdfs:label : Column Description</para>
    ///   <para>rdfs:comment : A Column represents a vertical arrangement of Cells within a Table.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Column">csvw:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:label : Datatype</para>
    ///   <para>rdfs:comment : Describes facets of a datatype.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Datatype">csvw:Datatype</a>
    /// </summary>
    let Datatype = _prefixId.prefix "Datatype"
    /// <summary>
    ///   <para>rdfs:label : Dialect Description</para>
    ///   <para>rdfs:comment : A Dialect Description provides hints to parsers about how to parse a linked file.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Dialect">csvw:Dialect</a>
    /// </summary>
    let Dialect = _prefixId.prefix "Dialect"
    /// <summary>
    ///   <para>rdfs:label : Direction</para>
    ///   <para>rdfs:comment : The class of table/text directions.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Direction">csvw:Direction</a>
    /// </summary>
    let Direction = _prefixId.prefix "Direction"
    /// <summary>
    ///   <para>rdfs:label : Foreign Key Definition</para>
    ///   <para>rdfs:comment : Describes relationships between Columns in one or more Tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#ForeignKey">csvw:ForeignKey</a>
    /// </summary>
    let ForeignKey = _prefixId.prefix "ForeignKey"
    let JSON = _prefixId.prefix "JSON"
    /// <summary>
    ///   <para>rdfs:label : Numeric Format</para>
    ///   <para>rdfs:comment : If the datatype is a numeric type, the format property indicates the expected format for that number. Its value must be either a single string or an object with one or more properties.</para>
    ///   <a href="http://www.w3.org/ns/csvw#NumericFormat">csvw:NumericFormat</a>
    /// </summary>
    let NumericFormat = _prefixId.prefix "NumericFormat"
    /// <summary>
    ///   <para>rdfs:label : Row</para>
    ///   <para>rdfs:comment : A Row represents a horizontal arrangement of cells within a Table.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Row">csvw:Row</a>
    /// </summary>
    let Row = _prefixId.prefix "Row"
    /// <summary>
    ///   <para>rdfs:label : Schema</para>
    ///   <para>rdfs:comment : A Schema is a definition of a tabular format that may be common to multiple tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Schema">csvw:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:label : Annotated Table</para>
    ///   <para>rdfs:comment : An annotated table is a table that is annotated with additional metadata.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Table">csvw:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : Group of Tables</para>
    ///   <para>rdfs:comment : A Group of Tables comprises a set of Annotated Tables and a set of annotations that relate to those Tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#TableGroup">csvw:TableGroup</a>
    /// </summary>
    let TableGroup = _prefixId.prefix "TableGroup"
    /// <summary>
    ///   <para>rdfs:label : Table Reference</para>
    ///   <para>rdfs:comment : An object property that identifies a referenced table and a set of referenced columns within that table.</para>
    ///   <a href="http://www.w3.org/ns/csvw#TableReference">csvw:TableReference</a>
    /// </summary>
    let TableReference = _prefixId.prefix "TableReference"
    /// <summary>
    ///   <para>rdfs:label : Transformation Definition</para>
    ///   <para>rdfs:comment : A Transformation Definition is a definition of how tabular data can be transformed into another format.</para>
    ///   <a href="http://www.w3.org/ns/csvw#Transformation">csvw:Transformation</a>
    /// </summary>
    let Transformation = _prefixId.prefix "Transformation"
    /// <summary>
    ///   <para>rdfs:label : about URL</para>
    ///   <para>rdfs:comment : A URI template property that MAY be used to indicate what a cell contains information about.</para>
    ///   <a href="http://www.w3.org/ns/csvw#aboutUrl">csvw:aboutUrl</a>
    /// </summary>
    let aboutUrl = _prefixId.prefix "aboutUrl"
    let auto = _prefixId.prefix "auto"
    /// <summary>
    ///   <para>rdfs:label : base</para>
    ///   <para>rdfs:comment : An atomic property that contains a single string: a term defined in the default context representing a built-in datatype URL, as listed above.</para>
    ///   <a href="http://www.w3.org/ns/csvw#base">csvw:base</a>
    /// </summary>
    let base_ = _prefixId.prefix "base"
    /// <summary>
    ///   <para>rdfs:label : column</para>
    ///   <para>rdfs:comment : An array property of column descriptions as described in section 5.6 Columns.</para>
    ///   <a href="http://www.w3.org/ns/csvw#column">csvw:column</a>
    /// </summary>
    let column = _prefixId.prefix "column"
    /// <summary>
    ///   <para>rdfs:label : column reference</para>
    ///   <para>rdfs:comment : A column reference property that holds either a single reference to a column description object within this schema, or an array of references. These form the referencing columns for the foreign key definition.</para>
    ///   <a href="http://www.w3.org/ns/csvw#columnReference">csvw:columnReference</a>
    /// </summary>
    let columnReference = _prefixId.prefix "columnReference"
    /// <summary>
    ///   <para>rdfs:label : comment prefix</para>
    ///   <para>rdfs:comment : An atomic property that sets the comment prefix flag to the single provided value, which MUST be a string.</para>
    ///   <a href="http://www.w3.org/ns/csvw#commentPrefix">csvw:commentPrefix</a>
    /// </summary>
    let commentPrefix = _prefixId.prefix "commentPrefix"
    let csvEncodedTabularData = _prefixId.prefix "csvEncodedTabularData"
    /// <summary>
    ///   <para>rdfs:label : datatype</para>
    ///   <para>rdfs:comment : An object property that contains either a single string that is the main datatype of the values of the cell or a datatype description object. If the value of this property is a string, it MUST be one of the built-in datatypes defined in section 5.11.1 Built-in Datatypes or an absolute URL; if it is an object then it describes a more specialised datatype. </para>
    ///   <a href="http://www.w3.org/ns/csvw#datatype">csvw:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : decimal character</para>
    ///   <para>rdfs:comment : A string whose value is used to represent a decimal point within the number.</para>
    ///   <a href="http://www.w3.org/ns/csvw#decimalChar">csvw:decimalChar</a>
    /// </summary>
    let decimalChar = _prefixId.prefix "decimalChar"
    /// <summary>
    ///   <para>rdfs:label : default</para>
    ///   <para>rdfs:comment : An atomic property holding a single string that is used to create a default value for the cell in cases where the original string value is an empty string.</para>
    ///   <a href="http://www.w3.org/ns/csvw#default">csvw:default</a>
    /// </summary>
    let default_ = _prefixId.prefix "default"
    /// <summary>
    ///   <para>rdfs:label : delimiter</para>
    ///   <para>rdfs:comment : An atomic property that sets the delimiter flag to the single provided value, which MUST be a string.</para>
    ///   <a href="http://www.w3.org/ns/csvw#delimiter">csvw:delimiter</a>
    /// </summary>
    let delimiter = _prefixId.prefix "delimiter"
    /// <summary>
    ///   <para>rdfs:label : describes</para>
    ///   <para>rdfs:comment : From IANA describes: The relationship A 'describes' B asserts that resource A provides a description of resource B. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource.</para>
    ///   <a href="http://www.w3.org/ns/csvw#describes">csvw:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : dialect</para>
    ///   <para>rdfs:comment : An object property that provides a single dialect description. If provided, dialect provides hints to processors about how to parse the referenced files to create tabular data models for the tables in the group.</para>
    ///   <a href="http://www.w3.org/ns/csvw#dialect">csvw:dialect</a>
    /// </summary>
    let dialect = _prefixId.prefix "dialect"
    /// <summary>
    ///   <para>rdfs:label : double quote</para>
    ///   <para>rdfs:comment : A boolean atomic property that, if `true`, sets the escape character flag to `"`.</para>
    ///   <a href="http://www.w3.org/ns/csvw#doubleQuote">csvw:doubleQuote</a>
    /// </summary>
    let doubleQuote = _prefixId.prefix "doubleQuote"
    /// <summary>
    ///   <para>rdfs:label : encoding</para>
    ///   <para>rdfs:comment : An atomic property that sets the encoding flag to the single provided string value, which MUST be a defined in [[encoding]]. The default is "utf-8".</para>
    ///   <a href="http://www.w3.org/ns/csvw#encoding">csvw:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    /// <summary>
    ///   <para>rdfs:label : foreign key</para>
    ///   <para>rdfs:comment : For a Table: a list of foreign keys on the table.
    ///
    /// For a Schema: an array property of foreign key definitions that define how the values from specified columns within this table link to rows within this table or other tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#foreignKey">csvw:foreignKey</a>
    /// </summary>
    let foreignKey = _prefixId.prefix "foreignKey"
    /// <summary>
    ///   <para>rdfs:label : format</para>
    ///   <para>rdfs:comment : An atomic property that contains either a single string or an object that defines the format of a value of this type, used when parsing a string value as described in Parsing Cells in [[tabular-data-model]].</para>
    ///   <a href="http://www.w3.org/ns/csvw#format">csvw:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : group character</para>
    ///   <para>rdfs:comment : A string whose value is used to group digits within the number.</para>
    ///   <a href="http://www.w3.org/ns/csvw#groupChar">csvw:groupChar</a>
    /// </summary>
    let groupChar = _prefixId.prefix "groupChar"
    /// <summary>
    ///   <para>rdfs:label : header</para>
    ///   <para>rdfs:comment : A boolean atomic property that, if `true`, sets the header row count flag to `1`, and if `false` to `0`, unless headerRowCount is provided, in which case the value provided for the header property is ignored.</para>
    ///   <a href="http://www.w3.org/ns/csvw#header">csvw:header</a>
    /// </summary>
    let header = _prefixId.prefix "header"
    /// <summary>
    ///   <para>rdfs:label : header row count</para>
    ///   <para>rdfs:comment : An numeric atomic property that sets the header row count flag to the single provided value, which must be a non-negative integer.</para>
    ///   <a href="http://www.w3.org/ns/csvw#headerRowCount">csvw:headerRowCount</a>
    /// </summary>
    let headerRowCount = _prefixId.prefix "headerRowCount"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : An atomic property giving a single string language code as defined by [[BCP47]].</para>
    ///   <a href="http://www.w3.org/ns/csvw#lang">csvw:lang</a>
    /// </summary>
    let lang = _prefixId.prefix "lang"
    /// <summary>
    ///   <para>rdfs:label : length</para>
    ///   <para>rdfs:comment : The exact length of the value of the cell.</para>
    ///   <a href="http://www.w3.org/ns/csvw#length">csvw:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : line terminators</para>
    ///   <para>rdfs:comment : An atomic property that sets the line terminators flag to either an array containing the single provided string value, or the provided array.</para>
    ///   <a href="http://www.w3.org/ns/csvw#lineTerminators">csvw:lineTerminators</a>
    /// </summary>
    let lineTerminators = _prefixId.prefix "lineTerminators"
    let ltr = _prefixId.prefix "ltr"
    /// <summary>
    ///   <para>rdfs:label : max exclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the maximum valid value (exclusive).</para>
    ///   <a href="http://www.w3.org/ns/csvw#maxExclusive">csvw:maxExclusive</a>
    /// </summary>
    let maxExclusive = _prefixId.prefix "maxExclusive"
    /// <summary>
    ///   <para>rdfs:label : max inclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the maximum valid value (inclusive).</para>
    ///   <a href="http://www.w3.org/ns/csvw#maxInclusive">csvw:maxInclusive</a>
    /// </summary>
    let maxInclusive = _prefixId.prefix "maxInclusive"
    /// <summary>
    ///   <para>rdfs:label : max length</para>
    ///   <para>rdfs:comment : A numeric atomic property that contains a single integer that is the maximum length of the value.</para>
    ///   <a href="http://www.w3.org/ns/csvw#maxLength">csvw:maxLength</a>
    /// </summary>
    let maxLength = _prefixId.prefix "maxLength"
    /// <summary>
    ///   <para>rdfs:label : min exclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the minimum valid value (exclusive).</para>
    ///   <a href="http://www.w3.org/ns/csvw#minExclusive">csvw:minExclusive</a>
    /// </summary>
    let minExclusive = _prefixId.prefix "minExclusive"
    /// <summary>
    ///   <para>rdfs:label : min inclusive</para>
    ///   <para>rdfs:comment : An atomic property that contains a single number that is the minimum valid value (inclusive).</para>
    ///   <a href="http://www.w3.org/ns/csvw#minInclusive">csvw:minInclusive</a>
    /// </summary>
    let minInclusive = _prefixId.prefix "minInclusive"
    /// <summary>
    ///   <para>rdfs:label : min length</para>
    ///   <para>rdfs:comment : An atomic property that contains a single integer that is the minimum length of the value.</para>
    ///   <a href="http://www.w3.org/ns/csvw#minLength">csvw:minLength</a>
    /// </summary>
    let minLength = _prefixId.prefix "minLength"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : An atomic property that gives a single canonical name for the column. The value of this property becomes the name annotation for the described column.</para>
    ///   <a href="http://www.w3.org/ns/csvw#name">csvw:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : note</para>
    ///   <para>rdfs:comment : An array property that provides an array of objects representing arbitrary annotations on the annotated tabular data model.</para>
    ///   <a href="http://www.w3.org/ns/csvw#note">csvw:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : null</para>
    ///   <para>rdfs:comment : An atomic property giving the string or strings used for null values within the data. If the string value of the cell is equal to any one of these values, the cell value is `null`.</para>
    ///   <a href="http://www.w3.org/ns/csvw#null">csvw:null</a>
    /// </summary>
    let null_ = _prefixId.prefix "null"
    /// <summary>
    ///   <para>rdfs:label : ordered</para>
    ///   <para>rdfs:comment : A boolean atomic property taking a single value which indicates whether a list that is the value of the cell is ordered (if `true`) or unordered (if `false`).</para>
    ///   <a href="http://www.w3.org/ns/csvw#ordered">csvw:ordered</a>
    /// </summary>
    let ordered = _prefixId.prefix "ordered"
    /// <summary>
    ///   <para>rdfs:label : pattern</para>
    ///   <para>rdfs:comment : A regular expression string, in the syntax and interpreted as defined by [[ECMASCRIPT]].</para>
    ///   <a href="http://www.w3.org/ns/csvw#pattern">csvw:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : primary key</para>
    ///   <para>rdfs:comment : For Schema: A column reference property that holds either a single reference to a column description object or an array of references.
    ///
    /// For Row: a possibly empty list of cells whose values together provide a unique identifier for this row. This is similar to the name of a column.</para>
    ///   <a href="http://www.w3.org/ns/csvw#primaryKey">csvw:primaryKey</a>
    /// </summary>
    let primaryKey = _prefixId.prefix "primaryKey"
    /// <summary>
    ///   <para>rdfs:label : property URL</para>
    ///   <para>rdfs:comment : An URI template property that MAY be used to create a URI for a property if the table is mapped to another format. </para>
    ///   <a href="http://www.w3.org/ns/csvw#propertyUrl">csvw:propertyUrl</a>
    /// </summary>
    let propertyUrl = _prefixId.prefix "propertyUrl"
    /// <summary>
    ///   <para>rdfs:label : quote char</para>
    ///   <para>rdfs:comment : An atomic property that sets the quote character flag to the single provided value, which must be a string or `null`.</para>
    ///   <a href="http://www.w3.org/ns/csvw#quoteChar">csvw:quoteChar</a>
    /// </summary>
    let quoteChar = _prefixId.prefix "quoteChar"
    /// <summary>
    ///   <para>rdfs:label : reference</para>
    ///   <para>rdfs:comment : An object property that identifies a **referenced table** and a set of **referenced columns** within that table.</para>
    ///   <a href="http://www.w3.org/ns/csvw#reference">csvw:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>rdfs:label : referenced rows</para>
    ///   <para>rdfs:comment : A possibly empty list of pairs of a foreign key and a row in a table within the same group of tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#referencedRow">csvw:referencedRow</a>
    /// </summary>
    let referencedRow = _prefixId.prefix "referencedRow"
    /// <summary>
    ///   <para>rdfs:label : required</para>
    ///   <para>rdfs:comment : A boolean atomic property taking a single value which indicates whether the cell must have a non-null value. The default is `false`. </para>
    ///   <a href="http://www.w3.org/ns/csvw#required">csvw:required</a>
    /// </summary>
    let required = _prefixId.prefix "required"
    /// <summary>
    ///   <para>rdfs:label : resource</para>
    ///   <para>rdfs:comment : A link property holding a URL that is the identifier for a specific table that is being referenced.</para>
    ///   <a href="http://www.w3.org/ns/csvw#resource">csvw:resource</a>
    /// </summary>
    let resource = _prefixId.prefix "resource"
    /// <summary>
    ///   <para>rdfs:label : row</para>
    ///   <para>rdfs:comment : Relates a Table to each Row output.</para>
    ///   <a href="http://www.w3.org/ns/csvw#row">csvw:row</a>
    /// </summary>
    let row = _prefixId.prefix "row"
    /// <summary>
    ///   <para>rdfs:label : row titles</para>
    ///   <para>rdfs:comment : A column reference property that holds either a single reference to a column description object or an array of references.</para>
    ///   <a href="http://www.w3.org/ns/csvw#rowTitle">csvw:rowTitle</a>
    /// </summary>
    let rowTitle = _prefixId.prefix "rowTitle"
    /// <summary>
    ///   <para>rdfs:label : row number</para>
    ///   <para>rdfs:comment : The position of the row amongst the rows of the Annotated Tabl, starting from 1 </para>
    ///   <a href="http://www.w3.org/ns/csvw#rownum">csvw:rownum</a>
    /// </summary>
    let rownum = _prefixId.prefix "rownum"
    let rtl = _prefixId.prefix "rtl"
    /// <summary>
    ///   <para>rdfs:label : schema reference</para>
    ///   <para>rdfs:comment : A link property holding a URL that is the identifier for a schema that is being referenced.</para>
    ///   <a href="http://www.w3.org/ns/csvw#schemaReference">csvw:schemaReference</a>
    /// </summary>
    let schemaReference = _prefixId.prefix "schemaReference"
    /// <summary>
    ///   <para>rdfs:label : script format</para>
    ///   <para>rdfs:comment : A link property giving the single URL for the format that is used by the script or template.</para>
    ///   <a href="http://www.w3.org/ns/csvw#scriptFormat">csvw:scriptFormat</a>
    /// </summary>
    let scriptFormat = _prefixId.prefix "scriptFormat"
    /// <summary>
    ///   <para>rdfs:label : separator</para>
    ///   <para>rdfs:comment : An atomic property that MUST have a single string value that is the character used to separate items in the string value of the cell.</para>
    ///   <a href="http://www.w3.org/ns/csvw#separator">csvw:separator</a>
    /// </summary>
    let separator = _prefixId.prefix "separator"
    /// <summary>
    ///   <para>rdfs:label : skip blank rows</para>
    ///   <para>rdfs:comment : An boolean atomic property that sets the `skip blank rows` flag to the single provided boolean value.</para>
    ///   <a href="http://www.w3.org/ns/csvw#skipBlankRows">csvw:skipBlankRows</a>
    /// </summary>
    let skipBlankRows = _prefixId.prefix "skipBlankRows"
    /// <summary>
    ///   <para>rdfs:label : skip columns</para>
    ///   <para>rdfs:comment : An numeric atomic property that sets the `skip columns` flag to the single provided numeric value, which MUST be a non-negative integer.</para>
    ///   <a href="http://www.w3.org/ns/csvw#skipColumns">csvw:skipColumns</a>
    /// </summary>
    let skipColumns = _prefixId.prefix "skipColumns"
    /// <summary>
    ///   <para>rdfs:label : skip initial space</para>
    ///   <para>rdfs:comment : A boolean atomic property that, if `true`, sets the trim flag to "start". If `false`, to `false`.</para>
    ///   <a href="http://www.w3.org/ns/csvw#skipInitialSpace">csvw:skipInitialSpace</a>
    /// </summary>
    let skipInitialSpace = _prefixId.prefix "skipInitialSpace"
    /// <summary>
    ///   <para>rdfs:label : skip rows</para>
    ///   <para>rdfs:comment : An numeric atomic property that sets the `skip rows` flag to the single provided numeric value, which MUST be a non-negative integer.</para>
    ///   <a href="http://www.w3.org/ns/csvw#skipRows">csvw:skipRows</a>
    /// </summary>
    let skipRows = _prefixId.prefix "skipRows"
    /// <summary>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : A single string atomic property that provides, if specified, the format to which the tabular data should be transformed prior to the transformation using the script or template.</para>
    ///   <a href="http://www.w3.org/ns/csvw#source">csvw:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : suppress output</para>
    ///   <para>rdfs:comment : A boolean atomic property. If `true`, suppresses any output that would be generated when converting a table or cells within a column.</para>
    ///   <a href="http://www.w3.org/ns/csvw#suppressOutput">csvw:suppressOutput</a>
    /// </summary>
    let suppressOutput = _prefixId.prefix "suppressOutput"
    /// <summary>
    ///   <para>rdfs:label : table</para>
    ///   <para>rdfs:comment : Relates an Table group to annotated tables.</para>
    ///   <a href="http://www.w3.org/ns/csvw#table">csvw:table</a>
    /// </summary>
    let table = _prefixId.prefix "table"
    /// <summary>
    ///   <para>rdfs:label : table direction</para>
    ///   <para>rdfs:comment : One of `rtl`, `ltr` or `auto`. Indicates whether the tables in the group should be displayed with the first column on the right, on the left, or based on the first character in the table that has a specific direction.</para>
    ///   <a href="http://www.w3.org/ns/csvw#tableDirection">csvw:tableDirection</a>
    /// </summary>
    let tableDirection = _prefixId.prefix "tableDirection"
    /// <summary>
    ///   <para>rdfs:label : table schema</para>
    ///   <para>rdfs:comment : An object property that provides a single schema description as described in section 5.5 Schemas, used as the default for all the tables in the group</para>
    ///   <a href="http://www.w3.org/ns/csvw#tableSchema">csvw:tableSchema</a>
    /// </summary>
    let tableSchema = _prefixId.prefix "tableSchema"
    let tabularMetadata = _prefixId.prefix "tabularMetadata"
    /// <summary>
    ///   <para>rdfs:label : target format</para>
    ///   <para>rdfs:comment : A link property giving the single URL for the format that will be created through the transformation.</para>
    ///   <a href="http://www.w3.org/ns/csvw#targetFormat">csvw:targetFormat</a>
    /// </summary>
    let targetFormat = _prefixId.prefix "targetFormat"
    /// <summary>
    ///   <para>rdfs:label : text direction</para>
    ///   <para>rdfs:comment : An atomic property that must have a single value that is one of `rtl` or `ltr` (the default).</para>
    ///   <a href="http://www.w3.org/ns/csvw#textDirection">csvw:textDirection</a>
    /// </summary>
    let textDirection = _prefixId.prefix "textDirection"
    /// <summary>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : For a Transformation A natural language property that describes the format that will be generated from the transformation.
    ///
    /// For a Column: A natural language property that provides possible alternative names for the column.</para>
    ///   <a href="http://www.w3.org/ns/csvw#title">csvw:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : transformations</para>
    ///   <para>rdfs:comment : An array property of transformation definitions that provide mechanisms to transform the tabular data into other formats.</para>
    ///   <a href="http://www.w3.org/ns/csvw#transformations">csvw:transformations</a>
    /// </summary>
    let transformations = _prefixId.prefix "transformations"
    /// <summary>
    ///   <para>rdfs:label : trim</para>
    ///   <para>rdfs:comment : An atomic property that, if the boolean `true`, sets the trim flag to `true` and if the boolean `false` to `false`. If the value provided is a string, sets the trim flag to the provided value, which must be one of "true", "false", "start" or "end".</para>
    ///   <a href="http://www.w3.org/ns/csvw#trim">csvw:trim</a>
    /// </summary>
    let trim = _prefixId.prefix "trim"
    let uriTemplate = _prefixId.prefix "uriTemplate"
    /// <summary>
    ///   <para>rdfs:label : url</para>
    ///   <para>rdfs:comment : For a Table: This link property gives the single URL of the CSV file that the table is held in, relative to the location of the metadata document.
    ///
    /// For a Transformation: A link property giving the single URL of the file that the script or template is held in, relative to the location of the metadata document.</para>
    ///   <a href="http://www.w3.org/ns/csvw#url">csvw:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : valueUrl</para>
    ///   <para>rdfs:comment : An URI template property that is used to map the values of cells into URLs.</para>
    ///   <a href="http://www.w3.org/ns/csvw#valueUrl">csvw:valueUrl</a>
    /// </summary>
    let valueUrl = _prefixId.prefix "valueUrl"
    /// <summary>
    ///   <para>rdfs:label : virtual</para>
    ///   <para>rdfs:comment : A boolean atomic property taking a single value which indicates whether the column is a virtual column not present in the original source</para>
    ///   <a href="http://www.w3.org/ns/csvw#virtual">csvw:virtual</a>
    /// </summary>
    let virtual_ = _prefixId.prefix "virtual"
