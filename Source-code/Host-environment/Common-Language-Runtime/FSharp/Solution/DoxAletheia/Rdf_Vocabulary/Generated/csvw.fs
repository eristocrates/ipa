namespace http.www.w3.org.ns.csvw.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module csvw =
    let _namespace_iri = Namespace_Iri csvw |> NamespaceIRI
    /// <summary>
    ///   <para>csvw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#">http://www.w3.org/ns/csvw#</seealso>
    let _prefix_iri = Prefixed_Name(csvw, "") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Cell represents a cell at the intersection of a Row and a Column within a Table."</para>
    /// labels<para>"Cell"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Cell">http://www.w3.org/ns/csvw#Cell</seealso>
    let Cell = Prefixed_Name(csvw, "Cell") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Column represents a vertical arrangement of Cells within a Table."</para>
    /// labels<para>"Column Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Column">http://www.w3.org/ns/csvw#Column</seealso>
    let Column = Prefixed_Name(csvw, "Column") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes facets of a datatype."</para>
    /// labels<para>"Datatype"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Datatype">http://www.w3.org/ns/csvw#Datatype</seealso>
    let Datatype = Prefixed_Name(csvw, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Dialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Dialect Description provides hints to parsers about how to parse a linked file."</para>
    /// labels<para>"Dialect Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Dialect">http://www.w3.org/ns/csvw#Dialect</seealso>
    let Dialect = Prefixed_Name(csvw, "Dialect") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of table/text directions."</para>
    /// labels<para>"Direction"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Direction">http://www.w3.org/ns/csvw#Direction</seealso>
    let Direction = Prefixed_Name(csvw, "Direction") |> PrefixedName
    /// <summary>
    ///   <para>csvw:ForeignKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes relationships between Columns in one or more Tables."</para>
    /// labels<para>"Foreign Key Definition"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#ForeignKey">http://www.w3.org/ns/csvw#ForeignKey</seealso>
    let ForeignKey = Prefixed_Name(csvw, "ForeignKey") |> PrefixedName
    /// <summary>
    ///   <para>csvw:JSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"A literal containing JSON."</para>
    /// labels<para>"JSON"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#JSON">http://www.w3.org/ns/csvw#JSON</seealso>
    let JSON = Prefixed_Name(csvw, "JSON") |> PrefixedName
    /// <summary>
    ///   <para>csvw:NumericFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"If the datatype is a numeric type, the format property indicates the expected format for that number. Its value must be either a single string or an object with one or more properties."</para>
    /// labels<para>"Numeric Format"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#NumericFormat">http://www.w3.org/ns/csvw#NumericFormat</seealso>
    let NumericFormat = Prefixed_Name(csvw, "NumericFormat") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Row represents a horizontal arrangement of cells within a Table."</para>
    /// labels<para>"Row"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Row">http://www.w3.org/ns/csvw#Row</seealso>
    let Row = Prefixed_Name(csvw, "Row") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Schema is a definition of a tabular format that may be common to multiple tables."</para>
    /// labels<para>"Schema"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Schema">http://www.w3.org/ns/csvw#Schema</seealso>
    let Schema = Prefixed_Name(csvw, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An annotated table is a table that is annotated with additional metadata."</para>
    /// labels<para>"Annotated Table"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Table">http://www.w3.org/ns/csvw#Table</seealso>
    let Table = Prefixed_Name(csvw, "Table") |> PrefixedName
    /// <summary>
    ///   <para>csvw:TableGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Group of Tables comprises a set of Annotated Tables and a set of annotations that relate to those Tables."</para>
    /// labels<para>"Group of Tables"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#TableGroup">http://www.w3.org/ns/csvw#TableGroup</seealso>
    let TableGroup = Prefixed_Name(csvw, "TableGroup") |> PrefixedName
    /// <summary>
    ///   <para>csvw:TableReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An object property that identifies a referenced table and a set of referenced columns within that table."</para>
    /// labels<para>"Table Reference"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#TableReference">http://www.w3.org/ns/csvw#TableReference</seealso>
    let TableReference = Prefixed_Name(csvw, "TableReference") |> PrefixedName
    /// <summary>
    ///   <para>csvw:Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Transformation Definition is a definition of how tabular data can be transformed into another format."</para>
    /// labels<para>"Transformation Definition"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#Transformation">http://www.w3.org/ns/csvw#Transformation</seealso>
    let Transformation = Prefixed_Name(csvw, "Transformation") |> PrefixedName
    /// <summary>
    ///   <para>csvw:aboutUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A URI template property that MAY be used to indicate what a cell contains information about."</para>
    /// labels<para>"about URL"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#aboutUrl">http://www.w3.org/ns/csvw#aboutUrl</seealso>
    let aboutUrl = Prefixed_Name(csvw, "aboutUrl") |> PrefixedName
    /// <summary>
    ///   <para>csvw:auto</para>
    /// </summary>
    /// <remarks>
    ///   <para>csvw:Direction</para>
    ///   <para>"Determins text direction based on the first character that has a specific direction."</para>
    /// labels<para>"auto"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#auto">http://www.w3.org/ns/csvw#auto</seealso>
    let auto = Prefixed_Name(csvw, "auto") |> PrefixedName
    /// <summary>
    ///   <para>csvw:base</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single string: a term defined in the default context representing a built-in datatype URL, as listed above."</para>
    /// labels<para>"base"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#base">http://www.w3.org/ns/csvw#base</seealso>
    let base_ = Prefixed_Name(csvw, "base") |> PrefixedName
    /// <summary>
    ///   <para>csvw:column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An array property of column descriptions as described in section 5.6 Columns."</para>
    /// labels<para>"column"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#column">http://www.w3.org/ns/csvw#column</seealso>
    let column = Prefixed_Name(csvw, "column") |> PrefixedName
    /// <summary>
    ///   <para>csvw:columnReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A column reference property that holds either a single reference to a column description object within this schema, or an array of references. These form the referencing columns for the foreign key definition."</para>
    /// labels<para>"column reference"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#columnReference">http://www.w3.org/ns/csvw#columnReference</seealso>
    let columnReference = Prefixed_Name(csvw, "columnReference") |> PrefixedName
    /// <summary>
    ///   <para>csvw:commentPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that sets the comment prefix flag to the single provided value, which MUST be a string."</para>
    /// labels<para>"comment prefix"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#commentPrefix">http://www.w3.org/ns/csvw#commentPrefix</seealso>
    let commentPrefix = Prefixed_Name(csvw, "commentPrefix") |> PrefixedName

    /// <summary>
    ///   <para>csvw:csvEncodedTabularData</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>"Describes the role of a CSV file in the tabular data mapping."</para>
    /// labels<para>"CSV Encoded Tabular Data"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#csvEncodedTabularData">http://www.w3.org/ns/csvw#csvEncodedTabularData</seealso>
    let csvEncodedTabularData =
        Prefixed_Name(csvw, "csvEncodedTabularData") |> PrefixedName

    /// <summary>
    ///   <para>csvw:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An object property that contains either a single string that is the main datatype of the values of the cell or a datatype description object. If the value of this property is a string, it MUST be one of the built-in datatypes defined in section 5.11.1 Built-in Datatypes or an absolute URL; if it is an object then it describes a more specialised datatype. "</para>
    /// labels<para>"datatype"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#datatype">http://www.w3.org/ns/csvw#datatype</seealso>
    let datatype = Prefixed_Name(csvw, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>csvw:decimalChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A string whose value is used to represent a decimal point within the number."</para>
    /// labels<para>"decimal character"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#decimalChar">http://www.w3.org/ns/csvw#decimalChar</seealso>
    let decimalChar = Prefixed_Name(csvw, "decimalChar") |> PrefixedName
    /// <summary>
    ///   <para>csvw:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property holding a single string that is used to create a default value for the cell in cases where the original string value is an empty string."</para>
    /// labels<para>"default"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#default">http://www.w3.org/ns/csvw#default</seealso>
    let default_ = Prefixed_Name(csvw, "default") |> PrefixedName
    /// <summary>
    ///   <para>csvw:delimiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that sets the delimiter flag to the single provided value, which MUST be a string."</para>
    /// labels<para>"delimiter"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#delimiter">http://www.w3.org/ns/csvw#delimiter</seealso>
    let delimiter = Prefixed_Name(csvw, "delimiter") |> PrefixedName
    /// <summary>
    ///   <para>csvw:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"From IANA describes: The relationship A 'describes' B asserts that resource A provides a description of resource B. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource."</para>
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#describes">http://www.w3.org/ns/csvw#describes</seealso>
    let describes = Prefixed_Name(csvw, "describes") |> PrefixedName
    /// <summary>
    ///   <para>csvw:dialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An object property that provides a single dialect description. If provided, dialect provides hints to processors about how to parse the referenced files to create tabular data models for the tables in the group."</para>
    /// labels<para>"dialect"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#dialect">http://www.w3.org/ns/csvw#dialect</seealso>
    let dialect = Prefixed_Name(csvw, "dialect") |> PrefixedName
    /// <summary>
    ///   <para>csvw:doubleQuote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property that, if `true`, sets the escape character flag to `"`."</para>
    /// labels<para>"double quote"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#doubleQuote">http://www.w3.org/ns/csvw#doubleQuote</seealso>
    let doubleQuote = Prefixed_Name(csvw, "doubleQuote") |> PrefixedName
    /// <summary>
    ///   <para>csvw:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that sets the encoding flag to the single provided string value, which MUST be a defined in [[encoding]]. The default is "utf-8"."</para>
    /// labels<para>"encoding"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#encoding">http://www.w3.org/ns/csvw#encoding</seealso>
    let encoding = Prefixed_Name(csvw, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>csvw:foreignKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For a Table: a list of foreign keys on the table.
    ///
    /// For a Schema: an array property of foreign key definitions that define how the values from specified columns within this table link to rows within this table or other tables."</para>
    /// labels<para>"foreign key"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#foreignKey">http://www.w3.org/ns/csvw#foreignKey</seealso>
    let foreignKey = Prefixed_Name(csvw, "foreignKey") |> PrefixedName
    /// <summary>
    ///   <para>csvw:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains either a single string or an object that defines the format of a value of this type, used when parsing a string value as described in Parsing Cells in [[tabular-data-model]]."</para>
    /// labels<para>"format"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#format">http://www.w3.org/ns/csvw#format</seealso>
    let format = Prefixed_Name(csvw, "format") |> PrefixedName
    /// <summary>
    ///   <para>csvw:groupChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A string whose value is used to group digits within the number."</para>
    /// labels<para>"group character"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#groupChar">http://www.w3.org/ns/csvw#groupChar</seealso>
    let groupChar = Prefixed_Name(csvw, "groupChar") |> PrefixedName
    /// <summary>
    ///   <para>csvw:header</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property that, if `true`, sets the header row count flag to `1`, and if `false` to `0`, unless headerRowCount is provided, in which case the value provided for the header property is ignored."</para>
    /// labels<para>"header"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#header">http://www.w3.org/ns/csvw#header</seealso>
    let header = Prefixed_Name(csvw, "header") |> PrefixedName
    /// <summary>
    ///   <para>csvw:headerRowCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An numeric atomic property that sets the header row count flag to the single provided value, which must be a non-negative integer."</para>
    /// labels<para>"header row count"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#headerRowCount">http://www.w3.org/ns/csvw#headerRowCount</seealso>
    let headerRowCount = Prefixed_Name(csvw, "headerRowCount") |> PrefixedName
    /// <summary>
    ///   <para>csvw:lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property giving a single string language code as defined by [[BCP47]]."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#lang">http://www.w3.org/ns/csvw#lang</seealso>
    let lang = Prefixed_Name(csvw, "lang") |> PrefixedName
    /// <summary>
    ///   <para>csvw:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The exact length of the value of the cell."</para>
    /// labels<para>"length"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#length">http://www.w3.org/ns/csvw#length</seealso>
    let length = Prefixed_Name(csvw, "length") |> PrefixedName
    /// <summary>
    ///   <para>csvw:lineTerminators</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that sets the line terminators flag to either an array containing the single provided string value, or the provided array."</para>
    /// labels<para>"line terminators"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#lineTerminators">http://www.w3.org/ns/csvw#lineTerminators</seealso>
    let lineTerminators = Prefixed_Name(csvw, "lineTerminators") |> PrefixedName
    /// <summary>
    ///   <para>csvw:ltr</para>
    /// </summary>
    /// <remarks>
    ///   <para>csvw:Direction</para>
    ///   <para>"Indicates text should be processed left to right."</para>
    /// labels<para>"left to right"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#ltr">http://www.w3.org/ns/csvw#ltr</seealso>
    let ltr = Prefixed_Name(csvw, "ltr") |> PrefixedName
    /// <summary>
    ///   <para>csvw:maxExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single number that is the maximum valid value (exclusive)."</para>
    /// labels<para>"max exclusive"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#maxExclusive">http://www.w3.org/ns/csvw#maxExclusive</seealso>
    let maxExclusive = Prefixed_Name(csvw, "maxExclusive") |> PrefixedName
    /// <summary>
    ///   <para>csvw:maxInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single number that is the maximum valid value (inclusive)."</para>
    /// labels<para>"max inclusive"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#maxInclusive">http://www.w3.org/ns/csvw#maxInclusive</seealso>
    let maxInclusive = Prefixed_Name(csvw, "maxInclusive") |> PrefixedName
    /// <summary>
    ///   <para>csvw:maxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A numeric atomic property that contains a single integer that is the maximum length of the value."</para>
    /// labels<para>"max length"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#maxLength">http://www.w3.org/ns/csvw#maxLength</seealso>
    let maxLength = Prefixed_Name(csvw, "maxLength") |> PrefixedName
    /// <summary>
    ///   <para>csvw:minExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single number that is the minimum valid value (exclusive)."</para>
    /// labels<para>"min exclusive"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#minExclusive">http://www.w3.org/ns/csvw#minExclusive</seealso>
    let minExclusive = Prefixed_Name(csvw, "minExclusive") |> PrefixedName
    /// <summary>
    ///   <para>csvw:minInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single number that is the minimum valid value (inclusive)."</para>
    /// labels<para>"min inclusive"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#minInclusive">http://www.w3.org/ns/csvw#minInclusive</seealso>
    let minInclusive = Prefixed_Name(csvw, "minInclusive") |> PrefixedName
    /// <summary>
    ///   <para>csvw:minLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that contains a single integer that is the minimum length of the value."</para>
    /// labels<para>"min length"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#minLength">http://www.w3.org/ns/csvw#minLength</seealso>
    let minLength = Prefixed_Name(csvw, "minLength") |> PrefixedName
    /// <summary>
    ///   <para>csvw:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that gives a single canonical name for the column. The value of this property becomes the name annotation for the described column."</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#name">http://www.w3.org/ns/csvw#name</seealso>
    let name = Prefixed_Name(csvw, "name") |> PrefixedName
    /// <summary>
    ///   <para>csvw:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An array property that provides an array of objects representing arbitrary annotations on the annotated tabular data model."</para>
    /// labels<para>"note"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#note">http://www.w3.org/ns/csvw#note</seealso>
    let note = Prefixed_Name(csvw, "note") |> PrefixedName
    /// <summary>
    ///   <para>csvw:null</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property giving the string or strings used for null values within the data. If the string value of the cell is equal to any one of these values, the cell value is `null`."</para>
    /// labels<para>"null"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#null">http://www.w3.org/ns/csvw#null</seealso>
    let null_ = Prefixed_Name(csvw, "null") |> PrefixedName
    /// <summary>
    ///   <para>csvw:ordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property taking a single value which indicates whether a list that is the value of the cell is ordered (if `true`) or unordered (if `false`)."</para>
    /// labels<para>"ordered"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#ordered">http://www.w3.org/ns/csvw#ordered</seealso>
    let ordered = Prefixed_Name(csvw, "ordered") |> PrefixedName
    /// <summary>
    ///   <para>csvw:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A regular expression string, in the syntax and interpreted as defined by [[ECMASCRIPT]]."</para>
    /// labels<para>"pattern"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#pattern">http://www.w3.org/ns/csvw#pattern</seealso>
    let pattern = Prefixed_Name(csvw, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>csvw:primaryKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For Schema: A column reference property that holds either a single reference to a column description object or an array of references.
    ///
    /// For Row: a possibly empty list of cells whose values together provide a unique identifier for this row. This is similar to the name of a column."</para>
    /// labels<para>"primary key"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#primaryKey">http://www.w3.org/ns/csvw#primaryKey</seealso>
    let primaryKey = Prefixed_Name(csvw, "primaryKey") |> PrefixedName
    /// <summary>
    ///   <para>csvw:propertyUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An URI template property that MAY be used to create a URI for a property if the table is mapped to another format. "</para>
    /// labels<para>"property URL"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#propertyUrl">http://www.w3.org/ns/csvw#propertyUrl</seealso>
    let propertyUrl = Prefixed_Name(csvw, "propertyUrl") |> PrefixedName
    /// <summary>
    ///   <para>csvw:quoteChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that sets the quote character flag to the single provided value, which must be a string or `null`."</para>
    /// labels<para>"quote char"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#quoteChar">http://www.w3.org/ns/csvw#quoteChar</seealso>
    let quoteChar = Prefixed_Name(csvw, "quoteChar") |> PrefixedName
    /// <summary>
    ///   <para>csvw:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An object property that identifies a **referenced table** and a set of **referenced columns** within that table."</para>
    /// labels<para>"reference"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#reference">http://www.w3.org/ns/csvw#reference</seealso>
    let reference = Prefixed_Name(csvw, "reference") |> PrefixedName
    /// <summary>
    ///   <para>csvw:referencedRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A possibly empty list of pairs of a foreign key and a row in a table within the same group of tables."</para>
    /// labels<para>"referenced rows"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#referencedRow">http://www.w3.org/ns/csvw#referencedRow</seealso>
    let referencedRow = Prefixed_Name(csvw, "referencedRow") |> PrefixedName
    /// <summary>
    ///   <para>csvw:required</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property taking a single value which indicates whether the cell must have a non-null value. The default is `false`. "</para>
    /// labels<para>"required"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#required">http://www.w3.org/ns/csvw#required</seealso>
    let required = Prefixed_Name(csvw, "required") |> PrefixedName
    /// <summary>
    ///   <para>csvw:resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link property holding a URL that is the identifier for a specific table that is being referenced."</para>
    /// labels<para>"resource"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#resource">http://www.w3.org/ns/csvw#resource</seealso>
    let resource = Prefixed_Name(csvw, "resource") |> PrefixedName
    /// <summary>
    ///   <para>csvw:row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates a Table to each Row output."</para>
    /// labels<para>"row"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#row">http://www.w3.org/ns/csvw#row</seealso>
    let row = Prefixed_Name(csvw, "row") |> PrefixedName
    /// <summary>
    ///   <para>csvw:rowTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A column reference property that holds either a single reference to a column description object or an array of references."</para>
    /// labels<para>"row titles"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#rowTitle">http://www.w3.org/ns/csvw#rowTitle</seealso>
    let rowTitle = Prefixed_Name(csvw, "rowTitle") |> PrefixedName
    /// <summary>
    ///   <para>csvw:rownum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The position of the row amongst the rows of the Annotated Tabl, starting from 1 "</para>
    /// labels<para>"row number"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#rownum">http://www.w3.org/ns/csvw#rownum</seealso>
    let rownum = Prefixed_Name(csvw, "rownum") |> PrefixedName
    /// <summary>
    ///   <para>csvw:rtl</para>
    /// </summary>
    /// <remarks>
    ///   <para>csvw:Direction</para>
    ///   <para>"Indiects text should be processed right to left"</para>
    /// labels<para>"right to left"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#rtl">http://www.w3.org/ns/csvw#rtl</seealso>
    let rtl = Prefixed_Name(csvw, "rtl") |> PrefixedName
    /// <summary>
    ///   <para>csvw:schemaReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link property holding a URL that is the identifier for a schema that is being referenced."</para>
    /// labels<para>"schema reference"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#schemaReference">http://www.w3.org/ns/csvw#schemaReference</seealso>
    let schemaReference = Prefixed_Name(csvw, "schemaReference") |> PrefixedName
    /// <summary>
    ///   <para>csvw:scriptFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link property giving the single URL for the format that is used by the script or template."</para>
    /// labels<para>"script format"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#scriptFormat">http://www.w3.org/ns/csvw#scriptFormat</seealso>
    let scriptFormat = Prefixed_Name(csvw, "scriptFormat") |> PrefixedName
    /// <summary>
    ///   <para>csvw:separator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that MUST have a single string value that is the character used to separate items in the string value of the cell."</para>
    /// labels<para>"separator"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#separator">http://www.w3.org/ns/csvw#separator</seealso>
    let separator = Prefixed_Name(csvw, "separator") |> PrefixedName
    /// <summary>
    ///   <para>csvw:skipBlankRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An boolean atomic property that sets the `skip blank rows` flag to the single provided boolean value."</para>
    /// labels<para>"skip blank rows"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#skipBlankRows">http://www.w3.org/ns/csvw#skipBlankRows</seealso>
    let skipBlankRows = Prefixed_Name(csvw, "skipBlankRows") |> PrefixedName
    /// <summary>
    ///   <para>csvw:skipColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An numeric atomic property that sets the `skip columns` flag to the single provided numeric value, which MUST be a non-negative integer."</para>
    /// labels<para>"skip columns"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#skipColumns">http://www.w3.org/ns/csvw#skipColumns</seealso>
    let skipColumns = Prefixed_Name(csvw, "skipColumns") |> PrefixedName
    /// <summary>
    ///   <para>csvw:skipInitialSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property that, if `true`, sets the trim flag to "start". If `false`, to `false`."</para>
    /// labels<para>"skip initial space"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#skipInitialSpace">http://www.w3.org/ns/csvw#skipInitialSpace</seealso>
    let skipInitialSpace = Prefixed_Name(csvw, "skipInitialSpace") |> PrefixedName
    /// <summary>
    ///   <para>csvw:skipRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An numeric atomic property that sets the `skip rows` flag to the single provided numeric value, which MUST be a non-negative integer."</para>
    /// labels<para>"skip rows"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#skipRows">http://www.w3.org/ns/csvw#skipRows</seealso>
    let skipRows = Prefixed_Name(csvw, "skipRows") |> PrefixedName
    /// <summary>
    ///   <para>csvw:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A single string atomic property that provides, if specified, the format to which the tabular data should be transformed prior to the transformation using the script or template."</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#source">http://www.w3.org/ns/csvw#source</seealso>
    let source = Prefixed_Name(csvw, "source") |> PrefixedName
    /// <summary>
    ///   <para>csvw:suppressOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property. If `true`, suppresses any output that would be generated when converting a table or cells within a column."</para>
    /// labels<para>"suppress output"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#suppressOutput">http://www.w3.org/ns/csvw#suppressOutput</seealso>
    let suppressOutput = Prefixed_Name(csvw, "suppressOutput") |> PrefixedName
    /// <summary>
    ///   <para>csvw:table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates an Table group to annotated tables."</para>
    /// labels<para>"table"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#table">http://www.w3.org/ns/csvw#table</seealso>
    let table = Prefixed_Name(csvw, "table") |> PrefixedName
    /// <summary>
    ///   <para>csvw:tableDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"One of `rtl`, `ltr` or `auto`. Indicates whether the tables in the group should be displayed with the first column on the right, on the left, or based on the first character in the table that has a specific direction."</para>
    /// labels<para>"table direction"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#tableDirection">http://www.w3.org/ns/csvw#tableDirection</seealso>
    let tableDirection = Prefixed_Name(csvw, "tableDirection") |> PrefixedName
    /// <summary>
    ///   <para>csvw:tableSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An object property that provides a single schema description as described in section 5.5 Schemas, used as the default for all the tables in the group"</para>
    /// labels<para>"table schema"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#tableSchema">http://www.w3.org/ns/csvw#tableSchema</seealso>
    let tableSchema = Prefixed_Name(csvw, "tableSchema") |> PrefixedName
    /// <summary>
    ///   <para>csvw:tabularMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>"Describes the role of a Metadata file in the tabular data mapping."</para>
    /// labels<para>"Tabular Metadata"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#tabularMetadata">http://www.w3.org/ns/csvw#tabularMetadata</seealso>
    let tabularMetadata = Prefixed_Name(csvw, "tabularMetadata") |> PrefixedName
    /// <summary>
    ///   <para>csvw:targetFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link property giving the single URL for the format that will be created through the transformation."</para>
    /// labels<para>"target format"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#targetFormat">http://www.w3.org/ns/csvw#targetFormat</seealso>
    let targetFormat = Prefixed_Name(csvw, "targetFormat") |> PrefixedName
    /// <summary>
    ///   <para>csvw:textDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that must have a single value that is one of `rtl` or `ltr` (the default)."</para>
    /// labels<para>"text direction"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#textDirection">http://www.w3.org/ns/csvw#textDirection</seealso>
    let textDirection = Prefixed_Name(csvw, "textDirection") |> PrefixedName
    /// <summary>
    ///   <para>csvw:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For a Transformation A natural language property that describes the format that will be generated from the transformation.
    ///
    /// For a Column: A natural language property that provides possible alternative names for the column."</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#title">http://www.w3.org/ns/csvw#title</seealso>
    let title = Prefixed_Name(csvw, "title") |> PrefixedName
    /// <summary>
    ///   <para>csvw:transformations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An array property of transformation definitions that provide mechanisms to transform the tabular data into other formats."</para>
    /// labels<para>"transformations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#transformations">http://www.w3.org/ns/csvw#transformations</seealso>
    let transformations = Prefixed_Name(csvw, "transformations") |> PrefixedName
    /// <summary>
    ///   <para>csvw:trim</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An atomic property that, if the boolean `true`, sets the trim flag to `true` and if the boolean `false` to `false`. If the value provided is a string, sets the trim flag to the provided value, which must be one of "true", "false", "start" or "end"."</para>
    /// labels<para>"trim"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#trim">http://www.w3.org/ns/csvw#trim</seealso>
    let trim = Prefixed_Name(csvw, "trim") |> PrefixedName
    /// <summary>
    ///   <para>csvw:uriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>""</para>
    /// labels<para>"uri template"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#uriTemplate">http://www.w3.org/ns/csvw#uriTemplate</seealso>
    let uriTemplate = Prefixed_Name(csvw, "uriTemplate") |> PrefixedName
    /// <summary>
    ///   <para>csvw:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For a Table: This link property gives the single URL of the CSV file that the table is held in, relative to the location of the metadata document.
    ///
    /// For a Transformation: A link property giving the single URL of the file that the script or template is held in, relative to the location of the metadata document."</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#url">http://www.w3.org/ns/csvw#url</seealso>
    let url = Prefixed_Name(csvw, "url") |> PrefixedName
    /// <summary>
    ///   <para>csvw:valueUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An URI template property that is used to map the values of cells into URLs."</para>
    /// labels<para>"valueUrl"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#valueUrl">http://www.w3.org/ns/csvw#valueUrl</seealso>
    let valueUrl = Prefixed_Name(csvw, "valueUrl") |> PrefixedName
    /// <summary>
    ///   <para>csvw:virtual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean atomic property taking a single value which indicates whether the column is a virtual column not present in the original source"</para>
    /// labels<para>"virtual"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/csvw#virtual">http://www.w3.org/ns/csvw#virtual</seealso>
    let virtual_ = Prefixed_Name(csvw, "virtual") |> PrefixedName
