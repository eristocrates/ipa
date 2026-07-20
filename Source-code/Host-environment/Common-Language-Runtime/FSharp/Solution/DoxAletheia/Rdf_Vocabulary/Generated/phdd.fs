namespace http.rdf_vocabulary.ddialliance.org.phdd.hash

open DoxAletheia

module phdd =
    let _namespace_name = "http://rdf-vocabulary.ddialliance.org/phdd#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#Column"></see></summary>
    let Column = _prefix "Column"
    /// <summary>
    ///
    /// 	Detailed description of a column. It comprehends common properties of delimited column and fixed column data.
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#ColumnDescription"></see></summary>
    let ColumnDescription = _prefix "ColumnDescription"
    /// <summary>
    /// Detailed description of a table with character-separated values additionally to the common properties in "TableStructure".
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#Delimited"></see></summary>
    let Delimited = _prefix "Delimited"
    /// <summary>
    /// The table properties described by default parameters of the data values.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#TableStructure"></see></summary>
    let TableStructure = _prefix "TableStructure"
    /// <summary>
    /// Detailed description of a column in CSV data additionally to the common properties in "ColumnDescription".
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#DelimitedColumnDescription"></see></summary>
    let DelimitedColumnDescription = _prefix "DelimitedColumnDescription"
    /// <summary>
    /// Detailed description of a column in fixed record length data in addition to the common properties in "ColumnDescription".
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#FixedColumnDescription"></see></summary>
    let FixedColumnDescription = _prefix "FixedColumnDescription"
    /// <summary>
    /// Detailed description of a table with fixed record length additionally to the common properties in "TableStructure".
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#FixedRecordLength"></see></summary>
    let FixedRecordLength = _prefix "FixedRecordLength"
    /// <summary>
    /// Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#InputProgram"></see></summary>
    let InputProgram = _prefix "InputProgram"
    /// <summary>
    /// Description of a table by significant parameters.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#TableDescription"></see></summary>
    let TableDescription = _prefix "TableDescription"
    /// <summary>
    /// Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#inputProgram"></see></summary>
    let inputProgram = _prefix "inputProgram"
    /// <summary>
    /// A table, which could be a rectangular file with character-separated values (CSV) or a rectangular file with fixed record length.
    ///
    /// 	This can be a subclass of "Distribution" in Data Catalog Vocabulary (DCAT), see: http://www.w3.org/TR/vocab-dcat/#class-distribution.
    /// 	The equivalent class in DDI-RDF Discovery (Disco) is "DataFile", see: http://rdf-vocabulary.ddialliance.org/discovery.html#datafile.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalDataProduct
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/PhysicalDataProduct.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// is described by
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    ///
    /// 	Number of cases or observations in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:CaseQuantity
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/CaseQuantity.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#caseQuantity"></see></summary>
    let caseQuantity = _prefix "caseQuantity"
    /// <summary>
    ///
    /// 	The character set or encoding used in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: CharacterSet
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CharacterSet.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#characterSet"></see></summary>
    let characterSet = _prefix "characterSet"
    /// <summary>
    ///
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#column"></see></summary>
    let column = _prefix "column"
    /// <summary>
    ///
    /// 	Position number of the column for delimited records.
    ///
    /// 	Equivalent element in DDI 3.2: ArrayPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/ArrayPosition.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#columnPosition"></see></summary>
    let columnPosition = _prefix "columnPosition"
    /// <summary>
    ///
    /// 	Indicates how consecutive delimiters should be handed by the software.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter/@treatConsecutiveDelimiterAsOne
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/complexTypes/DelimiterType.html#a6
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#consecutiveDelimitersAsOne"></see></summary>
    let consecutiveDelimitersAsOne = _prefix "consecutiveDelimitersAsOne"
    /// <summary>
    ///
    /// 	Number of decimal places for data values with an implied decimal separator. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: p:DecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/DecimalPositions.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#decimalPositions"></see></summary>
    let decimalPositions = _prefix "decimalPositions"
    /// <summary>
    ///
    /// 	Number of decimal places for data values with an implied decimal separator. It applies to the whole table. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalPositions.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalPositions"></see></summary>
    let defaultDecimalPositions = _prefix "defaultDecimalPositions"
    /// <summary>
    ///
    /// 	The character used to separate whole numbers from decimals expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalSeparator.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalSeparator"></see></summary>
    let defaultDecimalSeparator = _prefix "defaultDecimalSeparator"
    /// <summary>
    ///
    /// 	The character used to separate the component of whole numbers (thousands, millions, etc.) expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDigitGroupSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDigitGroupSeparator.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDigitGroupSeparator"></see></summary>
    let defaultDigitGroupSeparator = _prefix "defaultDigitGroupSeparator"
    /// <summary>
    ///
    /// 	Default language of text in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LanguageOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LanguageOfData.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLanguage"></see></summary>
    let defaultLanguage = _prefix "defaultLanguage"
    /// <summary>
    ///
    /// 	The default locale of text in the table. It is a set of parameters that defines the country, and any special variant preferences similar to BCP 47. The language can be defined by "defaultLanguage". Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LocaleOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LocaleOfData.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLocale"></see></summary>
    let defaultLocale = _prefix "defaultLocale"
    /// <summary>
    ///
    /// 	Defines the delimiter used to separate variables in a delimited record.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Delimiter.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#delimiter"></see></summary>
    let delimiter = _prefix "delimiter"
    /// <summary>
    ///
    /// 	Position of the last character of the column in a table with fixed record length. Must be specified if a value for "width" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:EndPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndPosition.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#endPosition"></see></summary>
    let endPosition = _prefix "endPosition"
    /// <summary>
    ///
    /// 	The file name or URI of the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:DataFileIdentification
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/DataFileIdentification.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#fileName"></see></summary>
    let fileName = _prefix "fileName"
    /// <summary>
    /// First line where the data start. Default is 2.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#firstDataLine"></see></summary>
    let firstDataLine = _prefix "firstDataLine"
    /// <summary>
    /// is structured by
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#isStructuredBy"></see></summary>
    let isStructuredBy = _prefix "isStructuredBy"
    /// <summary>
    ///
    /// 	Indicates if the first row of the table contains the names of the columns. Default is true.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@namesOnFirstRow
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/RecordLayoutType.html#a5
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#namesOnFirstRow"></see></summary>
    let namesOnFirstRow = _prefix "namesOnFirstRow"
    /// <summary>
    ///
    /// 	Specifies the end-of-line (EOL) marker used in the file as produced. If no value is provided assume the use of a CRLF (carriage return and line feed)
    ///
    /// 	Equivalent element in DDI 3.2: p:EndOfLineMarker
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndOfLineMarker.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#newLine"></see></summary>
    let newLine = _prefix "newLine"
    /// <summary>
    ///
    /// 	Overall record count in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:OverallRecordCount
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/OverallRecordCount.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#overallRecordCount"></see></summary>
    let overallRecordCount = _prefix "overallRecordCount"
    /// <summary>
    /// File name or URI of the input program.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#programFileName"></see></summary>
    let programFileName = _prefix "programFileName"
    /// <summary>
    /// Version of the software used of the program for reading the data.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#programVersion"></see></summary>
    let programVersion = _prefix "programVersion"
    /// <summary>
    ///
    /// 	The data type as recommended by the data producer.
    ///
    /// 	Equivalent element in DDI 3.2: r:RecommendedDataType
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/RecommendedDataType.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDataType"></see></summary>
    let recommendedDataType = _prefix "recommendedDataType"
    /// <summary>
    ///
    /// 	The recommended display format of the data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: r:GenericOutputFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/GenericOutputFormat.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDisplayDataFormat"></see></summary>
    let recommendedDisplayDataFormat = _prefix "recommendedDisplayDataFormat"
    /// <summary>
    /// The length of a record with fixed length.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#recordLength"></see></summary>
    let recordLength = _prefix "recordLength"
    /// <summary>
    ///
    /// 	The record number where this data item ("Column") is included. This applies only to tables with cases using multiple records. Default is 1.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalRecordSegment/@segmentOrder
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/PhysicalRecordSegmentType.html#a6
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#recordNumber"></see></summary>
    let recordNumber = _prefix "recordNumber"
    /// <summary>
    /// The number of records per case. Multiple records could represent one case. The default is 1.
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#recordsPerCase"></see></summary>
    let recordsPerCase = _prefix "recordsPerCase"
    /// <summary>
    ///
    /// 	Software or program language used of the program for reading the data.
    ///
    /// 	Equivalent element in DDI 3.2: r:ProgramLanguage
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/ProgramLanguage.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#softwareType"></see></summary>
    let softwareType = _prefix "softwareType"
    /// <summary>
    ///
    /// 	Position of the first character of the column in a table with fixed record length.
    ///
    /// 	Equivalent element in DDI 3.2: p:StartPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StartPosition.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#startPosition"></see></summary>
    let startPosition = _prefix "startPosition"
    /// <summary>
    ///
    /// 	Definition of the storage format of data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: p:StorageFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StorageFormat.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#storageFormat"></see></summary>
    let storageFormat = _prefix "storageFormat"
    /// <summary>
    ///
    /// 	Use for delimited files to designate the which text qualifier, if any, was used. Valid values include: single quote, double quote, and none.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@textQualifier
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/BaseRecordLayoutType.html#a5
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#textQualifier"></see></summary>
    let textQualifier = _prefix "textQualifier"
    /// <summary>
    ///
    /// 	Column width in a table with fixed record length. Must be specified if a value for "endPosition" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:Width
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Width.html
    ///
    /// <see href="http://rdf-vocabulary.ddialliance.org/phdd#width"></see></summary>
    let width = _prefix "width"
