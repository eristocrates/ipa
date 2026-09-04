#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module phdd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/phdd#" "phdd"

    /// <summary>
    ///   <para>rdfs:comment :
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    /// 	</para>
    ///   <para>rdfs:label : Column</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#Column">phdd:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Detailed description of a column. It comprehends common properties of delimited column and fixed column data.
    /// 	</para>
    ///   <para>rdfs:label : Column description</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#ColumnDescription">phdd:ColumnDescription</a>
    /// </summary>
    let ColumnDescription = _prefixId.prefix "ColumnDescription"
    /// <summary>
    ///   <para>rdfs:comment : Detailed description of a table with character-separated values additionally to the common properties in "TableStructure".</para>
    ///   <para>rdfs:label : Delimited</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#Delimited">phdd:Delimited</a>
    /// </summary>
    let Delimited = _prefixId.prefix "Delimited"
    /// <summary>
    ///   <para>rdfs:comment : Detailed description of a column in CSV data additionally to the common properties in "ColumnDescription".</para>
    ///   <para>rdfs:label : Delimited column description</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#DelimitedColumnDescription">phdd:DelimitedColumnDescription</a>
    /// </summary>
    let DelimitedColumnDescription = _prefixId.prefix "DelimitedColumnDescription"
    /// <summary>
    ///   <para>rdfs:comment : Detailed description of a column in fixed record length data in addition to the common properties in "ColumnDescription".</para>
    ///   <para>rdfs:label : fixed column description</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#FixedColumnDescription">phdd:FixedColumnDescription</a>
    /// </summary>
    let FixedColumnDescription = _prefixId.prefix "FixedColumnDescription"
    /// <summary>
    ///   <para>rdfs:comment : Detailed description of a table with fixed record length additionally to the common properties in "TableStructure".</para>
    ///   <para>rdfs:label : Fixed record length</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#FixedRecordLength">phdd:FixedRecordLength</a>
    /// </summary>
    let FixedRecordLength = _prefixId.prefix "FixedRecordLength"
    /// <summary>
    ///   <para>rdfs:comment : Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    /// 	</para>
    ///   <para>rdfs:label : Input Program</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#InputProgram">phdd:InputProgram</a>
    /// </summary>
    let InputProgram = _prefixId.prefix "InputProgram"
    /// <summary>
    ///   <para>rdfs:comment : A table, which could be a rectangular file with character-separated values (CSV) or a rectangular file with fixed record length.
    ///
    /// 	This can be a subclass of "Distribution" in Data Catalog Vocabulary (DCAT), see: http://www.w3.org/TR/vocab-dcat/#class-distribution.
    /// 	The equivalent class in DDI-RDF Discovery (Disco) is "DataFile", see: http://rdf-vocabulary.ddialliance.org/discovery.html#datafile.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalDataProduct
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/PhysicalDataProduct.html
    /// 	</para>
    ///   <para>rdfs:label : Table</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#Table">phdd:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:comment : Description of a table by significant parameters.</para>
    ///   <para>rdfs:label : Table Description</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#TableDescription">phdd:TableDescription</a>
    /// </summary>
    let TableDescription = _prefixId.prefix "TableDescription"
    /// <summary>
    ///   <para>rdfs:comment : The table properties described by default parameters of the data values.</para>
    ///   <para>rdfs:label : Table Structure</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#TableStructure">phdd:TableStructure</a>
    /// </summary>
    let TableStructure = _prefixId.prefix "TableStructure"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Number of cases or observations in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:CaseQuantity
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/CaseQuantity.html
    /// 	</para>
    ///   <para>rdfs:label : Case quantity</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#caseQuantity">phdd:caseQuantity</a>
    /// </summary>
    let caseQuantity = _prefixId.prefix "caseQuantity"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The character set or encoding used in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: CharacterSet
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CharacterSet.html
    /// 	</para>
    ///   <para>rdfs:label : character set</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#characterSet">phdd:characterSet</a>
    /// </summary>
    let characterSet = _prefixId.prefix "characterSet"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	A column of a table. Other terms are variable or data item.
    ///
    /// 	Equivalent class in Disco: Variable
    /// 	Disco documentation: http://rdf-vocabulary.ddialliance.org/discovery.html#variable-and-variable-definition
    /// 	Equivalent element in DDI 3.2: l:Variable
    /// 	DDI 3.2 Documentation:  http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/logicalproduct_xsd/elements/Variable.html
    /// 	</para>
    ///   <para>rdfs:label : column</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#column">phdd:column</a>
    /// </summary>
    let column = _prefixId.prefix "column"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Position number of the column for delimited records.
    ///
    /// 	Equivalent element in DDI 3.2: ArrayPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/ArrayPosition.html
    /// 	</para>
    ///   <para>rdfs:label : Column position</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#columnPosition">phdd:columnPosition</a>
    /// </summary>
    let columnPosition = _prefixId.prefix "columnPosition"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Indicates how consecutive delimiters should be handed by the software.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter/@treatConsecutiveDelimiterAsOne
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/complexTypes/DelimiterType.html#a6
    /// 	</para>
    ///   <para>rdfs:label : consecutive delimiters as one</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#consecutiveDelimitersAsOne">phdd:consecutiveDelimitersAsOne</a>
    /// </summary>
    let consecutiveDelimitersAsOne = _prefixId.prefix "consecutiveDelimitersAsOne"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Number of decimal places for data values with an implied decimal separator. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: p:DecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/DecimalPositions.html
    /// 	</para>
    ///   <para>rdfs:label : Decimal positions</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#decimalPositions">phdd:decimalPositions</a>
    /// </summary>
    let decimalPositions = _prefixId.prefix "decimalPositions"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Number of decimal places for data values with an implied decimal separator. It applies to the whole table. Another expression is decimal scaling factor. Default is 0.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalPositions
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalPositions.html
    /// 	</para>
    ///   <para>rdfs:label : Default decimal positions</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalPositions">phdd:defaultDecimalPositions</a>
    /// </summary>
    let defaultDecimalPositions = _prefixId.prefix "defaultDecimalPositions"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The character used to separate whole numbers from decimals expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDecimalSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDecimalSeparator.html
    /// 	</para>
    ///   <para>rdfs:label : Default decimal separator</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDecimalSeparator">phdd:defaultDecimalSeparator</a>
    /// </summary>
    let defaultDecimalSeparator = _prefixId.prefix "defaultDecimalSeparator"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The character used to separate the component of whole numbers (thousands, millions, etc.) expressed as a one character string.
    ///
    /// 	Equivalent element in DDI 3.2: r:DefaultDigitGroupSeparator
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/DefaultDigitGroupSeparator.html
    /// 	</para>
    ///   <para>rdfs:label : default digit group separator</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#defaultDigitGroupSeparator">phdd:defaultDigitGroupSeparator</a>
    /// </summary>
    let defaultDigitGroupSeparator = _prefixId.prefix "defaultDigitGroupSeparator"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Default language of text in the table. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LanguageOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LanguageOfData.html
    /// 	</para>
    ///   <para>rdfs:label : Default language</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLanguage">phdd:defaultLanguage</a>
    /// </summary>
    let defaultLanguage = _prefixId.prefix "defaultLanguage"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The default locale of text in the table. It is a set of parameters that defines the country, and any special variant preferences similar to BCP 47. The language can be defined by "defaultLanguage". Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Related element in DDI 3.2: p:LocaleOfData
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/LocaleOfData.html
    /// 	</para>
    ///   <para>rdfs:label : Default locale</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#defaultLocale">phdd:defaultLocale</a>
    /// </summary>
    let defaultLocale = _prefixId.prefix "defaultLocale"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Defines the delimiter used to separate variables in a delimited record.
    ///
    /// 	Equivalent element in DDI 3.2: p:Delimiter
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Delimiter.html
    /// 	</para>
    ///   <para>rdfs:label : Delimiter</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#delimiter">phdd:delimiter</a>
    /// </summary>
    let delimiter = _prefixId.prefix "delimiter"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Position of the last character of the column in a table with fixed record length. Must be specified if a value for "width" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:EndPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndPosition.html
    /// 	</para>
    ///   <para>rdfs:label : End position</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#endPosition">phdd:endPosition</a>
    /// </summary>
    let endPosition = _prefixId.prefix "endPosition"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The file name or URI of the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:DataFileIdentification
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/DataFileIdentification.html
    /// 	</para>
    ///   <para>rdfs:label : File name</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#fileName">phdd:fileName</a>
    /// </summary>
    let fileName = _prefixId.prefix "fileName"
    /// <summary>
    ///   <para>rdfs:comment : First line where the data start. Default is 2.</para>
    ///   <para>rdfs:label : First data line</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#firstDataLine">phdd:firstDataLine</a>
    /// </summary>
    let firstDataLine = _prefixId.prefix "firstDataLine"
    /// <summary>
    ///   <para>rdfs:comment : Program or program statements for reading the data.
    ///
    /// 	Related element in DDI 3.2: r:CommandFile
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/CommandFile.html
    /// 	</para>
    ///   <para>rdfs:label : Input program</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#inputProgram">phdd:inputProgram</a>
    /// </summary>
    let inputProgram = _prefixId.prefix "inputProgram"
    /// <summary>
    ///   <para>rdfs:comment : is described by</para>
    ///   <para>rdfs:label : is described by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#isDescribedBy">phdd:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:comment : is structured by</para>
    ///   <para>rdfs:label : is structured by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#isStructuredBy">phdd:isStructuredBy</a>
    /// </summary>
    let isStructuredBy = _prefixId.prefix "isStructuredBy"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Indicates if the first row of the table contains the names of the columns. Default is true.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@namesOnFirstRow
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/RecordLayoutType.html#a5
    /// 	</para>
    ///   <para>rdfs:label : Names on first row</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#namesOnFirstRow">phdd:namesOnFirstRow</a>
    /// </summary>
    let namesOnFirstRow = _prefixId.prefix "namesOnFirstRow"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Specifies the end-of-line (EOL) marker used in the file as produced. If no value is provided assume the use of a CRLF (carriage return and line feed)
    ///
    /// 	Equivalent element in DDI 3.2: p:EndOfLineMarker
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/EndOfLineMarker.html
    /// 	</para>
    ///   <para>rdfs:label : New line</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#newLine">phdd:newLine</a>
    /// </summary>
    let newLine = _prefixId.prefix "newLine"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Overall record count in the table.
    ///
    /// 	Equivalent element in DDI 3.2: pi:OverallRecordCount
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicalinstance_xsd/elements/OverallRecordCount.html
    /// 	</para>
    ///   <para>rdfs:label : Overall record count</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#overallRecordCount">phdd:overallRecordCount</a>
    /// </summary>
    let overallRecordCount = _prefixId.prefix "overallRecordCount"
    /// <summary>
    ///   <para>rdfs:comment : File name or URI of the input program.</para>
    ///   <para>rdfs:label : Program file name</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#programFileName">phdd:programFileName</a>
    /// </summary>
    let programFileName = _prefixId.prefix "programFileName"
    /// <summary>
    ///   <para>rdfs:comment : Version of the software used of the program for reading the data.</para>
    ///   <para>rdfs:label : Program version</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#programVersion">phdd:programVersion</a>
    /// </summary>
    let programVersion = _prefixId.prefix "programVersion"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The data type as recommended by the data producer.
    ///
    /// 	Equivalent element in DDI 3.2: r:RecommendedDataType
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/RecommendedDataType.html
    /// 	</para>
    ///   <para>rdfs:label : Recommended data type</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDataType">phdd:recommendedDataType</a>
    /// </summary>
    let recommendedDataType = _prefixId.prefix "recommendedDataType"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The recommended display format of the data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: r:GenericOutputFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/GenericOutputFormat.html
    /// 	</para>
    ///   <para>rdfs:label : Recommended display data format</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#recommendedDisplayDataFormat">phdd:recommendedDisplayDataFormat</a>
    /// </summary>
    let recommendedDisplayDataFormat = _prefixId.prefix "recommendedDisplayDataFormat"
    /// <summary>
    ///   <para>rdfs:comment : The length of a record with fixed length.</para>
    ///   <para>rdfs:label : Record length</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#recordLength">phdd:recordLength</a>
    /// </summary>
    let recordLength = _prefixId.prefix "recordLength"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	The record number where this data item ("Column") is included. This applies only to tables with cases using multiple records. Default is 1.
    ///
    /// 	Related element in DDI 3.2: p:PhysicalRecordSegment/@segmentOrder
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/PhysicalRecordSegmentType.html#a6
    /// 	</para>
    ///   <para>rdfs:label : Record number</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#recordNumber">phdd:recordNumber</a>
    /// </summary>
    let recordNumber = _prefixId.prefix "recordNumber"
    /// <summary>
    ///   <para>rdfs:comment : The number of records per case. Multiple records could represent one case. The default is 1.</para>
    ///   <para>rdfs:label : Records per case</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#recordsPerCase">phdd:recordsPerCase</a>
    /// </summary>
    let recordsPerCase = _prefixId.prefix "recordsPerCase"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Software or program language used of the program for reading the data.
    ///
    /// 	Equivalent element in DDI 3.2: r:ProgramLanguage
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/reusable_xsd/elements/ProgramLanguage.html
    /// 	</para>
    ///   <para>rdfs:label : Software type</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#softwareType">phdd:softwareType</a>
    /// </summary>
    let softwareType = _prefixId.prefix "softwareType"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Position of the first character of the column in a table with fixed record length.
    ///
    /// 	Equivalent element in DDI 3.2: p:StartPosition
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StartPosition.html
    /// 	</para>
    ///   <para>rdfs:label : Start position</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#startPosition">phdd:startPosition</a>
    /// </summary>
    let startPosition = _prefixId.prefix "startPosition"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Definition of the storage format of data values of a column. Supports the use of an external controlled vocabulary in SKOS.
    ///
    /// 	Equivalent element in DDI 3.2: p:StorageFormat
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/StorageFormat.html
    /// 	</para>
    ///   <para>rdfs:label : Storage format</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#storageFormat">phdd:storageFormat</a>
    /// </summary>
    let storageFormat = _prefixId.prefix "storageFormat"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Use for delimited files to designate the which text qualifier, if any, was used. Valid values include: single quote, double quote, and none.
    ///
    /// 	Equivalent element in DDI 3.2: p:RecordLayout/@textQualifier
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/complexTypes/BaseRecordLayoutType.html#a5
    /// 	</para>
    ///   <para>rdfs:label : text qualifier</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#textQualifier">phdd:textQualifier</a>
    /// </summary>
    let textQualifier = _prefixId.prefix "textQualifier"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Column width in a table with fixed record length. Must be specified if a value for "endPosition" is not provided.
    ///
    /// 	Equivalent element in DDI 3.2: p:Width
    /// 	DDI 3.2 Documentation: http://www.ddialliance.org/Specification/DDI-Lifecycle/3.2/XMLSchema/FieldLevelDocumentation/schemas/physicaldataproduct_xsd/elements/Width.html
    /// 	</para>
    ///   <para>rdfs:label : width</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/phdd#width">phdd:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
