namespace http.rdf_vocabulary.ddialliance.org.phdd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module phdd =
    let _namespace_iri = Namespace_Iri phdd |> NamespaceIRI
    /// <summary>
    ///   <para>phdd:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    /// 	"</para>
    /// labels<para>"Column"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#Column">http://rdf-vocabulary.ddialliance.org/phdd#Column</seealso>
    let Column = Prefixed_Name(phdd, "Column") |> PrefixedName
    /// <summary>
    ///   <para>phdd:ColumnDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"
    /// 	Detailed description of a column. It comprehends common properties of delimited column and fixed column data.
    /// 	"</para>
    /// labels<para>"Column description"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#ColumnDescription">http://rdf-vocabulary.ddialliance.org/phdd#ColumnDescription</seealso>
    let ColumnDescription = Prefixed_Name(phdd, "ColumnDescription") |> PrefixedName
    /// <summary>
    ///   <para>phdd:Delimited</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Detailed description of a table with character-separated values additionally to the common properties in "TableStructure"."</para>
    /// labels<para>"Delimited"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#Delimited">http://rdf-vocabulary.ddialliance.org/phdd#Delimited</seealso>
    let Delimited = Prefixed_Name(phdd, "Delimited") |> PrefixedName

    /// <summary>
    ///   <para>phdd:DelimitedColumnDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Detailed description of a column in CSV data additionally to the common properties in "ColumnDescription"."</para>
    /// labels<para>"Delimited column description"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#DelimitedColumnDescription">http://rdf-vocabulary.ddialliance.org/phdd#DelimitedColumnDescription</seealso>
    let DelimitedColumnDescription =
        Prefixed_Name(phdd, "DelimitedColumnDescription") |> PrefixedName

    /// <summary>
    ///   <para>phdd:FixedColumnDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Detailed description of a column in fixed record length data in addition to the common properties in "ColumnDescription"."</para>
    /// labels<para>"fixed column description"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#FixedColumnDescription">http://rdf-vocabulary.ddialliance.org/phdd#FixedColumnDescription</seealso>
    let FixedColumnDescription =
        Prefixed_Name(phdd, "FixedColumnDescription") |> PrefixedName

    /// <summary>
    ///   <para>phdd:FixedRecordLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Detailed description of a table with fixed record length additionally to the common properties in "TableStructure"."</para>
    /// labels<para>"Fixed record length"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#FixedRecordLength">http://rdf-vocabulary.ddialliance.org/phdd#FixedRecordLength</seealso>
    let FixedRecordLength = Prefixed_Name(phdd, "FixedRecordLength") |> PrefixedName
    /// <summary>
    ///   <para>phdd:InputProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    /// 	"</para>
    /// labels<para>"Input Program"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#InputProgram">http://rdf-vocabulary.ddialliance.org/phdd#InputProgram</seealso>
    let InputProgram = Prefixed_Name(phdd, "InputProgram") |> PrefixedName
    /// <summary>
    ///   <para>phdd:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A table, which could be a rectangular file with character-separated values (CSV) or a rectangular file with fixed record length.
    ///
    /// 	This can be a subclass of "Distribution" in Data Catalog Vocabulary (DCAT), see: http://www.w3.org/TR/vocab-dcat/#class-distribution.
    /// 	The equivalent class in DDI-RDF Discovery (Disco) is "DataFile", see: http://rdf-vocabulary.ddialliance.org/discovery.html#datafile.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalDataProduct
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/PhysicalDataProduct.html
    /// 	"</para>
    /// labels<para>"Table"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#Table">http://rdf-vocabulary.ddialliance.org/phdd#Table</seealso>
    let Table = Prefixed_Name(phdd, "Table") |> PrefixedName
    /// <summary>
    ///   <para>phdd:TableDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Description of a table by significant parameters."</para>
    /// labels<para>"Table Description"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#TableDescription">http://rdf-vocabulary.ddialliance.org/phdd#TableDescription</seealso>
    let TableDescription = Prefixed_Name(phdd, "TableDescription") |> PrefixedName
    /// <summary>
    ///   <para>phdd:TableStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The table properties described by default parameters of the data values."</para>
    /// labels<para>"Table Structure"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#TableStructure">http://rdf-vocabulary.ddialliance.org/phdd#TableStructure</seealso>
    let TableStructure = Prefixed_Name(phdd, "TableStructure") |> PrefixedName
    /// <summary>
    ///   <para>phdd:caseQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Number of cases or observations in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:CaseQuantity
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/CaseQuantity.html
    /// 	"</para>
    /// labels<para>"Case quantity"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#caseQuantity">http://rdf-vocabulary.ddialliance.org/phdd#caseQuantity</seealso>
    let caseQuantity = Prefixed_Name(phdd, "caseQuantity") |> PrefixedName
    /// <summary>
    ///   <para>phdd:characterSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The character set or encoding used in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: CharacterSet
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CharacterSet.html
    /// 	"</para>
    /// labels<para>"character set"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#characterSet">http://rdf-vocabulary.ddialliance.org/phdd#characterSet</seealso>
    let characterSet = Prefixed_Name(phdd, "characterSet") |> PrefixedName
    /// <summary>
    ///   <para>phdd:column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    /// 	"</para>
    /// labels<para>"column"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#column">http://rdf-vocabulary.ddialliance.org/phdd#column</seealso>
    let column = Prefixed_Name(phdd, "column") |> PrefixedName
    /// <summary>
    ///   <para>phdd:columnPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Position number of the column for delimited records.
    ///
    /// 	Equivalent element in DDI 3.2: ArrayPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/ArrayPosition.html
    /// 	"</para>
    /// labels<para>"Column position"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#columnPosition">http://rdf-vocabulary.ddialliance.org/phdd#columnPosition</seealso>
    let columnPosition = Prefixed_Name(phdd, "columnPosition") |> PrefixedName

    /// <summary>
    ///   <para>phdd:consecutiveDelimitersAsOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Indicates how consecutive delimiters should be handed by the software.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter/@treatConsecutiveDelimiterAsOne
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/complexTypes/DelimiterType.html#a6
    /// 	"</para>
    /// labels<para>"consecutive delimiters as one"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#consecutiveDelimitersAsOne">http://rdf-vocabulary.ddialliance.org/phdd#consecutiveDelimitersAsOne</seealso>
    let consecutiveDelimitersAsOne =
        Prefixed_Name(phdd, "consecutiveDelimitersAsOne") |> PrefixedName

    /// <summary>
    ///   <para>phdd:decimalPositions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Number of decimal places for data values with an implied decimal separator. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: p:DecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/DecimalPositions.html
    /// 	"</para>
    /// labels<para>"Decimal positions"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#decimalPositions">http://rdf-vocabulary.ddialliance.org/phdd#decimalPositions</seealso>
    let decimalPositions = Prefixed_Name(phdd, "decimalPositions") |> PrefixedName

    /// <summary>
    ///   <para>phdd:defaultDecimalPositions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Number of decimal places for data values with an implied decimal separator. It applies to the whole table. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalPositions.html
    /// 	"</para>
    /// labels<para>"Default decimal positions"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalPositions">http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalPositions</seealso>
    let defaultDecimalPositions =
        Prefixed_Name(phdd, "defaultDecimalPositions") |> PrefixedName

    /// <summary>
    ///   <para>phdd:defaultDecimalSeparator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	The character used to separate whole numbers from decimals expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalSeparator.html
    /// 	"</para>
    /// labels<para>"Default decimal separator"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalSeparator">http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalSeparator</seealso>
    let defaultDecimalSeparator =
        Prefixed_Name(phdd, "defaultDecimalSeparator") |> PrefixedName

    /// <summary>
    ///   <para>phdd:defaultDigitGroupSeparator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	The character used to separate the component of whole numbers (thousands, millions, etc.) expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDigitGroupSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDigitGroupSeparator.html
    /// 	"</para>
    /// labels<para>"default digit group separator"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDigitGroupSeparator">http://rdf-vocabulary.ddialliance.org/phdd#defaultDigitGroupSeparator</seealso>
    let defaultDigitGroupSeparator =
        Prefixed_Name(phdd, "defaultDigitGroupSeparator") |> PrefixedName

    /// <summary>
    ///   <para>phdd:defaultLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// 	Default language of text in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LanguageOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LanguageOfData.html
    /// 	"</para>
    /// labels<para>"Default language"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLanguage">http://rdf-vocabulary.ddialliance.org/phdd#defaultLanguage</seealso>
    let defaultLanguage = Prefixed_Name(phdd, "defaultLanguage") |> PrefixedName
    /// <summary>
    ///   <para>phdd:defaultLocale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// 	The default locale of text in the table. It is a set of parameters that defines the country, and any special variant preferences similar to BCP 47. The language can be defined by "defaultLanguage". Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LocaleOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LocaleOfData.html
    /// 	"</para>
    /// labels<para>"Default locale"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLocale">http://rdf-vocabulary.ddialliance.org/phdd#defaultLocale</seealso>
    let defaultLocale = Prefixed_Name(phdd, "defaultLocale") |> PrefixedName
    /// <summary>
    ///   <para>phdd:delimiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Defines the delimiter used to separate variables in a delimited record.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Delimiter.html
    /// 	"</para>
    /// labels<para>"Delimiter"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#delimiter">http://rdf-vocabulary.ddialliance.org/phdd#delimiter</seealso>
    let delimiter = Prefixed_Name(phdd, "delimiter") |> PrefixedName
    /// <summary>
    ///   <para>phdd:endPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Position of the last character of the column in a table with fixed record length. Must be specified if a value for "width" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:EndPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndPosition.html
    /// 	"</para>
    /// labels<para>"End position"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#endPosition">http://rdf-vocabulary.ddialliance.org/phdd#endPosition</seealso>
    let endPosition = Prefixed_Name(phdd, "endPosition") |> PrefixedName
    /// <summary>
    ///   <para>phdd:fileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The file name or URI of the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:DataFileIdentification
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/DataFileIdentification.html
    /// 	"</para>
    /// labels<para>"File name"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#fileName">http://rdf-vocabulary.ddialliance.org/phdd#fileName</seealso>
    let fileName = Prefixed_Name(phdd, "fileName") |> PrefixedName
    /// <summary>
    ///   <para>phdd:firstDataLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"First line where the data start. Default is 2."</para>
    /// labels<para>"First data line"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#firstDataLine">http://rdf-vocabulary.ddialliance.org/phdd#firstDataLine</seealso>
    let firstDataLine = Prefixed_Name(phdd, "firstDataLine") |> PrefixedName
    /// <summary>
    ///   <para>phdd:inputProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    /// 	"</para>
    /// labels<para>"Input program"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#inputProgram">http://rdf-vocabulary.ddialliance.org/phdd#inputProgram</seealso>
    let inputProgram = Prefixed_Name(phdd, "inputProgram") |> PrefixedName
    /// <summary>
    ///   <para>phdd:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is described by"</para>
    /// labels<para>"is described by"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#isDescribedBy">http://rdf-vocabulary.ddialliance.org/phdd#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(phdd, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>phdd:isStructuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"is structured by"</para>
    /// labels<para>"is structured by"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#isStructuredBy">http://rdf-vocabulary.ddialliance.org/phdd#isStructuredBy</seealso>
    let isStructuredBy = Prefixed_Name(phdd, "isStructuredBy") |> PrefixedName
    /// <summary>
    ///   <para>phdd:namesOnFirstRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Indicates if the first row of the table contains the names of the columns. Default is true.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@namesOnFirstRow
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/RecordLayoutType.html#a5
    /// 	"</para>
    /// labels<para>"Names on first row"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#namesOnFirstRow">http://rdf-vocabulary.ddialliance.org/phdd#namesOnFirstRow</seealso>
    let namesOnFirstRow = Prefixed_Name(phdd, "namesOnFirstRow") |> PrefixedName
    /// <summary>
    ///   <para>phdd:newLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Specifies the end-of-line (EOL) marker used in the file as produced. If no value is provided assume the use of a CRLF (carriage return and line feed)
    ///
    /// 	Equivalent element in DDI 3.2: p:EndOfLineMarker
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndOfLineMarker.html
    /// 	"</para>
    /// labels<para>"New line"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#newLine">http://rdf-vocabulary.ddialliance.org/phdd#newLine</seealso>
    let newLine = Prefixed_Name(phdd, "newLine") |> PrefixedName
    /// <summary>
    ///   <para>phdd:overallRecordCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Overall record count in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:OverallRecordCount
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/OverallRecordCount.html
    /// 	"</para>
    /// labels<para>"Overall record count"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#overallRecordCount">http://rdf-vocabulary.ddialliance.org/phdd#overallRecordCount</seealso>
    let overallRecordCount = Prefixed_Name(phdd, "overallRecordCount") |> PrefixedName
    /// <summary>
    ///   <para>phdd:programFileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"File name or URI of the input program."</para>
    /// labels<para>"Program file name"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#programFileName">http://rdf-vocabulary.ddialliance.org/phdd#programFileName</seealso>
    let programFileName = Prefixed_Name(phdd, "programFileName") |> PrefixedName
    /// <summary>
    ///   <para>phdd:programVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Version of the software used of the program for reading the data."</para>
    /// labels<para>"Program version"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#programVersion">http://rdf-vocabulary.ddialliance.org/phdd#programVersion</seealso>
    let programVersion = Prefixed_Name(phdd, "programVersion") |> PrefixedName
    /// <summary>
    ///   <para>phdd:recommendedDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The data type as recommended by the data producer.
    ///
    /// 	Equivalent element in DDI 3.2: r:RecommendedDataType
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/RecommendedDataType.html
    /// 	"</para>
    /// labels<para>"Recommended data type"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDataType">http://rdf-vocabulary.ddialliance.org/phdd#recommendedDataType</seealso>
    let recommendedDataType = Prefixed_Name(phdd, "recommendedDataType") |> PrefixedName

    /// <summary>
    ///   <para>phdd:recommendedDisplayDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The recommended display format of the data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: r:GenericOutputFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/GenericOutputFormat.html
    /// 	"</para>
    /// labels<para>"Recommended display data format"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDisplayDataFormat">http://rdf-vocabulary.ddialliance.org/phdd#recommendedDisplayDataFormat</seealso>
    let recommendedDisplayDataFormat =
        Prefixed_Name(phdd, "recommendedDisplayDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>phdd:recordLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The length of a record with fixed length."</para>
    /// labels<para>"Record length"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#recordLength">http://rdf-vocabulary.ddialliance.org/phdd#recordLength</seealso>
    let recordLength = Prefixed_Name(phdd, "recordLength") |> PrefixedName
    /// <summary>
    ///   <para>phdd:recordNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The record number where this data item ("Column") is included. This applies only to tables with cases using multiple records. Default is 1.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalRecordSegment/@segmentOrder
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/PhysicalRecordSegmentType.html#a6
    /// 	"</para>
    /// labels<para>"Record number"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#recordNumber">http://rdf-vocabulary.ddialliance.org/phdd#recordNumber</seealso>
    let recordNumber = Prefixed_Name(phdd, "recordNumber") |> PrefixedName
    /// <summary>
    ///   <para>phdd:recordsPerCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of records per case. Multiple records could represent one case. The default is 1."</para>
    /// labels<para>"Records per case"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#recordsPerCase">http://rdf-vocabulary.ddialliance.org/phdd#recordsPerCase</seealso>
    let recordsPerCase = Prefixed_Name(phdd, "recordsPerCase") |> PrefixedName
    /// <summary>
    ///   <para>phdd:softwareType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Software or program language used of the program for reading the data.
    ///
    /// 	Equivalent element in DDI 3.2: r:ProgramLanguage
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/ProgramLanguage.html
    /// 	"</para>
    /// labels<para>"Software type"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#softwareType">http://rdf-vocabulary.ddialliance.org/phdd#softwareType</seealso>
    let softwareType = Prefixed_Name(phdd, "softwareType") |> PrefixedName
    /// <summary>
    ///   <para>phdd:startPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Position of the first character of the column in a table with fixed record length.
    ///
    /// 	Equivalent element in DDI 3.2: p:StartPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StartPosition.html
    /// 	"</para>
    /// labels<para>"Start position"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#startPosition">http://rdf-vocabulary.ddialliance.org/phdd#startPosition</seealso>
    let startPosition = Prefixed_Name(phdd, "startPosition") |> PrefixedName
    /// <summary>
    ///   <para>phdd:storageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	Definition of the storage format of data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: p:StorageFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StorageFormat.html
    /// 	"</para>
    /// labels<para>"Storage format"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#storageFormat">http://rdf-vocabulary.ddialliance.org/phdd#storageFormat</seealso>
    let storageFormat = Prefixed_Name(phdd, "storageFormat") |> PrefixedName
    /// <summary>
    ///   <para>phdd:textQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Use for delimited files to designate the which text qualifier, if any, was used. Valid values include: single quote, double quote, and none.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@textQualifier
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/BaseRecordLayoutType.html#a5
    /// 	"</para>
    /// labels<para>"text qualifier"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#textQualifier">http://rdf-vocabulary.ddialliance.org/phdd#textQualifier</seealso>
    let textQualifier = Prefixed_Name(phdd, "textQualifier") |> PrefixedName
    /// <summary>
    ///   <para>phdd:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    /// 	Column width in a table with fixed record length. Must be specified if a value for "endPosition" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:Width
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Width.html
    /// 	"</para>
    /// labels<para>"width"</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/phdd#width">http://rdf-vocabulary.ddialliance.org/phdd#width</seealso>
    let width = Prefixed_Name(phdd, "width") |> PrefixedName
