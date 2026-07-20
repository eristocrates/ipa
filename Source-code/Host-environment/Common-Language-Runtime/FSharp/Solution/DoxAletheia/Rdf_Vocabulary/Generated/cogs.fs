namespace http.vocab.deri.ie.cogs.hash

open DoxAletheia

module cogs =
    let _namespace_name = "http://vocab.deri.ie/cogs#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#benkam"></see>
    /// </summary>
    let benkam = _prefix "benkam"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#andfre"></see>
    /// </summary>
    let andfre = _prefix "andfre"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#timleb"></see>
    /// </summary>
    let timleb = _prefix "timleb"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#AIFB%2FKIT"></see>
    /// </summary>
    let ``AIFB%2FKIT`` = _prefix "AIFB%2FKIT"
    /// <summary>
    /// Process that seeks a solution designed for a specific problem or task, non-generalizable, and not intended to be able to be adapted to other purposes. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AdHocProcess"></see></summary>
    let AdHocProcess = _prefix "AdHocProcess"
    /// <summary>
    /// The instantiation of an activity or workflow. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Execution"></see></summary>
    let Execution = _prefix "Execution"
    /// <summary>
    ///  Functions which return a single result row based on groups of rows. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AggregateRows"></see></summary>
    let AggregateRows = _prefix "AggregateRows"
    /// <summary>
    /// Instructions executed on rows of a table or file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RowOperation"></see></summary>
    let RowOperation = _prefix "RowOperation"
    /// <summary>
    /// String operation for concatenating lists or arrays. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Append"></see></summary>
    let Append = _prefix "Append"
    /// <summary>
    /// Operations for manipulating strings. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringOperation"></see></summary>
    let StringOperation = _prefix "StringOperation"
    /// <summary>
    /// New data are computed based on the user-defined formula. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ApplyFormula"></see></summary>
    let ApplyFormula = _prefix "ApplyFormula"
    /// <summary>
    /// Manipulate and manage numeric data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#NumericOperation"></see></summary>
    let NumericOperation = _prefix "NumericOperation"
    /// <summary>
    /// Execution of a script. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ApplyScript"></see></summary>
    let ApplyScript = _prefix "ApplyScript"
    /// <summary>
    /// Functional operations that can be done by a computer.
    /// <see href="http://vocab.deri.ie/cogs#Operation"></see></summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// Sets or re-sets the value stored in the storage location(s) denoted by a variable name. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Assignment"></see></summary>
    let Assignment = _prefix "Assignment"
    /// <summary>
    /// Evaluate a selected function for a particular value of x. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ValueOperation"></see></summary>
    let ValueOperation = _prefix "ValueOperation"
    /// <summary>
    /// A non-recurrent, not frequent automated process.
    /// <see href="http://vocab.deri.ie/cogs#AutomatedAdHocProcess"></see></summary>
    let AutomatedAdHocProcess = _prefix "AutomatedAdHocProcess"
    /// <summary>
    /// Task of finding entries that refer to the same entity across different data sources using computer resources. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AutomatedMatching"></see></summary>
    let AutomatedMatching = _prefix "AutomatedMatching"
    /// <summary>
    /// The process of mapping information from a source format to a destination format. @en-us
    /// <see href="http://vocab.deri.ie/cogs#MappingProcess"></see></summary>
    let MappingProcess = _prefix "MappingProcess"
    /// <summary>
    /// Validation performed by a computer. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AutomatedValidation"></see></summary>
    let AutomatedValidation = _prefix "AutomatedValidation"
    /// <summary>
    /// The act of validating; finding or testing the truth of something. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Validation"></see></summary>
    let Validation = _prefix "Validation"
    /// <summary>
    /// Returns the smallest integer greater than or equal to n. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Ceil"></see></summary>
    let Ceil = _prefix "Ceil"
    /// <summary>
    /// Converts strings between different character sets. @en-us
    /// <see href="http://vocab.deri.ie/cogs#CharacterSetConversion"></see></summary>
    let CharacterSetConversion = _prefix "CharacterSetConversion"
    /// <summary>
    /// A construct that is used as a blueprint to create instances of the class. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// Database tables are composed of individual columns corresponding to the attributes of the object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Column"></see></summary>
    let Column = _prefix "Column"
    /// <summary>
    /// Instructions applied on one or more columns. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ColumnOperation"></see></summary>
    let ColumnOperation = _prefix "ColumnOperation"
    /// <summary>
    /// If the primary key of an incoming record matches with the key of an existing Record, leaves the existing Record, adds the incoming record and marks the added record as superseding the old record. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ConstructiveMerge"></see></summary>
    let ConstructiveMerge = _prefix "ConstructiveMerge"
    /// <summary>
    /// Stage that is responsible for loading data into the end target. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Loading"></see></summary>
    let Loading = _prefix "Loading"
    /// <summary>
    /// A piece of data that was duplicated. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Copy"></see></summary>
    let Copy = _prefix "Copy"
    /// <summary>
    /// A multidimensional database that holds data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Cube"></see></summary>
    let Cube = _prefix "Cube"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` = _prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    /// Data Source Name (DSN) is a data structure that contains the information about a specific database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DSN"></see></summary>
    let DSN = _prefix "DSN"
    /// <summary>
    /// Layer that controls access to data in a computer-based information system. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataAccessLayer"></see></summary>
    let DataAccessLayer = _prefix "DataAccessLayer"
    /// <summary>
    /// Each individual level. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Layer"></see></summary>
    let Layer = _prefix "Layer"
    /// <summary>
    /// Layer responsible for the development, execution and supervision of plans, policies, programs and practices that control, protect, deliver and enhance the value of data and information assets. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataManagementLayer"></see></summary>
    let DataManagementLayer = _prefix "DataManagementLayer"
    /// <summary>
    /// Data mart is a process-oriented subset of the overall organization’s data based on a foundation of atomic data, and that depends only on the structure of the data-measurement events, not on the anticipated user’s questions.
    /// <see href="http://vocab.deri.ie/cogs#DataMart"></see></summary>
    let DataMart = _prefix "DataMart"
    /// <summary>
    /// A sequence of digitally encoded coherent signals (packets of data) used to transmit or receive information that is in the process of being transmitted. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataStream"></see></summary>
    let DataStream = _prefix "DataStream"
    /// <summary>
    /// A database is a collection of information organized into interrelated tables of data and specifications of data objects. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    /// Conversion from a datetime format to a different one.
    /// <see href="http://vocab.deri.ie/cogs#DatetimeConversion"></see></summary>
    let DatetimeConversion = _prefix "DatetimeConversion"
    /// <summary>
    /// Elimination of redundant data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Deduplication"></see></summary>
    let Deduplication = _prefix "Deduplication"
    /// <summary>
    /// Deletes one or more columns according to a certain criteria to a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteColumn"></see></summary>
    let DeleteColumn = _prefix "DeleteColumn"
    /// <summary>
    /// Query that does a delete operation on a row, column, table for example. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteQueryObject"></see></summary>
    let DeleteQueryObject = _prefix "DeleteQueryObject"
    /// <summary>
    /// A structured object which is used to request information or perform an action in a database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#QueryObject"></see></summary>
    let QueryObject = _prefix "QueryObject"
    /// <summary>
    /// Exclusion of a single or group of rows by a certain criteria on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteRow"></see></summary>
    let DeleteRow = _prefix "DeleteRow"
    /// <summary>
    /// Deletes on or more triples into the store.@en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteTriple"></see></summary>
    let DeleteTriple = _prefix "DeleteTriple"
    /// <summary>
    /// Instructions performed on graphs. @en-us
    /// <see href="http://vocab.deri.ie/cogs#GraphOperation"></see></summary>
    let GraphOperation = _prefix "GraphOperation"
    /// <summary>
    /// Inputs the incoming data to the target data if the primary key of an incoming record matches with the key of an existing record, updating the matching target record. If the incoming record is a new record without a match with any existing record, it adds the incoming record to the target table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DestructiveMerge"></see></summary>
    let DestructiveMerge = _prefix "DestructiveMerge"
    /// <summary>
    /// A machine designed for a purpose. E.g.: Unit of hardware.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// One of the set of companion tables to a fact table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DimensionTable"></see></summary>
    let DimensionTable = _prefix "DimensionTable"
    /// <summary>
    /// A predefined format of rows and columns that define a database entity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// Database access point as a web service (SPARQL Endpoint) . @en-us
    /// <see href="http://vocab.deri.ie/cogs#Endpoint"></see></summary>
    let Endpoint = _prefix "Endpoint"
    /// <summary>
    /// An action that is usually initiated outside the scope of a program and that is handled by a piece of code inside the program. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// An event, which occurs during the execution of a program, which disrupts the normal flow of the program's instructions. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Exception"></see></summary>
    let Exception = _prefix "Exception"
    /// <summary>
    /// Provides the current execution status of a running process instance (a job). e.g. : fail, running, success. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ExecutionStatus"></see></summary>
    let ExecutionStatus = _prefix "ExecutionStatus"
    /// <summary>
    /// The first part of an ETL process which involves extracting the data from source systems. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Extraction"></see></summary>
    let Extraction = _prefix "Extraction"
    /// <summary>
    /// A table that consists of the measurements, metrics or facts of a  process. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FactTable"></see></summary>
    let FactTable = _prefix "FactTable"
    /// <summary>
    /// Status of a job that stops operating or functioning. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Fail"></see></summary>
    let Fail = _prefix "Fail"
    /// <summary>
    /// Performs decoding operations when you specify field-encoding function. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FieldDecoding"></see></summary>
    let FieldDecoding = _prefix "FieldDecoding"
    /// <summary>
    /// A block of arbitrary information, or resource for storing information, which is available to a computer program. @en-us
    /// <see href="http://vocab.deri.ie/cogs#File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// The process of looking up for information on a file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FileLookup"></see></summary>
    let FileLookup = _prefix "FileLookup"
    /// <summary>
    /// A process used to look up data in a relational table, view or dictionary. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Lookup"></see></summary>
    let Lookup = _prefix "Lookup"
    /// <summary>
    /// Copy the contents of the topmost cells of a selected range into the cells below.@en-us
    /// <see href="http://vocab.deri.ie/cogs#FillDown"></see></summary>
    let FillDown = _prefix "FillDown"
    /// <summary>
    /// An operation that can be used to retain rows in a mapping that do not meet specific conditions. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// Reviews the file format. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FormatRevision"></see></summary>
    let FormatRevision = _prefix "FormatRevision"
    /// <summary>
    /// A rule or principle. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Formula"></see></summary>
    let Formula = _prefix "Formula"
    /// <summary>
    /// Truncates all the tables and data gets loaded again. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FullRefresh"></see></summary>
    let FullRefresh = _prefix "FullRefresh"
    /// <summary>
    /// Matching based on a human decision.
    /// <see href="http://vocab.deri.ie/cogs#HumanMatching"></see></summary>
    let HumanMatching = _prefix "HumanMatching"
    /// <summary>
    /// Validation performed by a person:  an user or admin. @en-us
    /// <see href="http://vocab.deri.ie/cogs#HumanValidation"></see></summary>
    let HumanValidation = _prefix "HumanValidation"
    /// <summary>
    /// Applies ongoing changes to one or more tables based on a predefined schedule. @en-us
    /// <see href="http://vocab.deri.ie/cogs#IncrementalLoad"></see></summary>
    let IncrementalLoad = _prefix "IncrementalLoad"
    /// <summary>
    /// Populates the tables in the data warehouse schema and verifies if the data is ready for use. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InitialLoad"></see></summary>
    let InitialLoad = _prefix "InitialLoad"
    /// <summary>
    /// Any data entered into a computer.@en-us
    /// <see href="http://vocab.deri.ie/cogs#Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    /// Inserts one or more columns according to a certain criteria to a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertColumn"></see></summary>
    let InsertColumn = _prefix "InsertColumn"
    /// <summary>
    /// Query that inserts data into the database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertQueryObject"></see></summary>
    let InsertQueryObject = _prefix "InsertQueryObject"
    /// <summary>
    /// Inclusion of a row on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertRow"></see></summary>
    let InsertRow = _prefix "InsertRow"
    /// <summary>
    /// Includes one or more triple into the store. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertTriple"></see></summary>
    let InsertTriple = _prefix "InsertTriple"
    /// <summary>
    /// The instance of a process or group of processes (workflow).
    /// <see href="http://vocab.deri.ie/cogs#Job"></see></summary>
    let Job = _prefix "Job"
    /// <summary>
    /// Row Operation that allows combinations (Cartesian product) of all rows in the input streams.@en-us
    /// <see href="http://vocab.deri.ie/cogs#JoinRows"></see></summary>
    let JoinRows = _prefix "JoinRows"
    /// <summary>
    /// Process of generating keys/indexes for tables. @en-us
    /// <see href="http://vocab.deri.ie/cogs#KeyGeneration"></see></summary>
    let KeyGeneration = _prefix "KeyGeneration"
    /// <summary>
    /// Transformation of keys with built-in meanings into generic keys. @en-us
    /// <see href="http://vocab.deri.ie/cogs#KeyRestructuring"></see></summary>
    let KeyRestructuring = _prefix "KeyRestructuring"
    /// <summary>
    /// Final error on a execution workflow. @en-us
    /// <see href="http://vocab.deri.ie/cogs#LastError"></see></summary>
    let LastError = _prefix "LastError"
    /// <summary>
    /// A record of computer activity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Log"></see></summary>
    let Log = _prefix "Log"
    /// <summary>
    /// The process of manipulating data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Transformation"></see></summary>
    let Transformation = _prefix "Transformation"
    /// <summary>
    /// String operation for converting a string to lowercase.@en-us
    /// <see href="http://vocab.deri.ie/cogs#Lowercase"></see></summary>
    let Lowercase = _prefix "Lowercase"
    /// <summary>
    /// A non-recurrent, not-frequent manual process.
    /// <see href="http://vocab.deri.ie/cogs#ManualAdHocProcess"></see></summary>
    let ManualAdHocProcess = _prefix "ManualAdHocProcess"
    /// <summary>
    /// Job that was initialized by an user. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ManuallyStartedJob"></see></summary>
    let ManuallyStartedJob = _prefix "ManuallyStartedJob"
    /// <summary>
    /// The definition of a semantic equivalence relationship between source and target objects. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Mapping"></see></summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    /// The specification of a mapping between source and target fields (e.g. RDB2RDF).
    /// <see href="http://vocab.deri.ie/cogs#MappingFile"></see></summary>
    let MappingFile = _prefix "MappingFile"
    /// <summary>
    /// Row Operation that allows the comparison of two streams of rows. It is often used in situations where the source system of a data warehouse does not contain a date of last update. @en-us
    /// <see href="http://vocab.deri.ie/cogs#MergeRow"></see></summary>
    let MergeRow = _prefix "MergeRow"
    /// <summary>
    /// Data that describe data and other structures, such as objects, business rules and processes. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Metadata"></see></summary>
    let Metadata = _prefix "Metadata"
    /// <summary>
    /// A subroutine that is exclusively associated with a object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// To change in position from one point to another. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Move"></see></summary>
    let Move = _prefix "Move"
    /// <summary>
    /// Converts an expression of one numeric data type to another. @en-us
    /// <see href="http://vocab.deri.ie/cogs#NumericCast"></see></summary>
    let NumericCast = _prefix "NumericCast"
    /// <summary>
    /// Value that enables a program to indirectly access a particular object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ObjectReference"></see></summary>
    let ObjectReference = _prefix "ObjectReference"
    /// <summary>
    /// Internal representation of an object suitable for matching its features. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ObjectRepresentation"></see></summary>
    let ObjectRepresentation = _prefix "ObjectRepresentation"
    /// <summary>
    /// A symbol or function representing a mathematical operation. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// Application of a specific order to a set of elemetns.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Order"></see></summary>
    let Order = _prefix "Order"
    /// <summary>
    /// Information, resulting from computer processing, that is delivered to a user. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Output"></see></summary>
    let Output = _prefix "Output"
    /// <summary>
    /// Process of analyzing text or data, checking for correct syntax and building a representation based on the input tokens. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Parsing"></see></summary>
    let Parsing = _prefix "Parsing"
    /// <summary>
    /// To copy an object from a buffer  or clipboard to a file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Paste"></see></summary>
    let Paste = _prefix "Paste"
    /// <summary>
    /// Measures used to evaluate the success of a particular activity.
    /// <see href="http://vocab.deri.ie/cogs#PerformanceIndicator"></see></summary>
    let PerformanceIndicator = _prefix "PerformanceIndicator"
    /// <summary>
    /// Forces a matching under a certain predefined criteria.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#PredefinedMatching"></see></summary>
    let PredefinedMatching = _prefix "PredefinedMatching"
    /// <summary>
    /// Preliminary filtering during the extraction phase.
    /// <see href="http://vocab.deri.ie/cogs#Prefiltering"></see></summary>
    let Prefiltering = _prefix "Prefiltering"
    /// <summary>
    /// What the user sees. @en-us
    /// <see href="http://vocab.deri.ie/cogs#PresentationArea"></see></summary>
    let PresentationArea = _prefix "PresentationArea"
    /// <summary>
    /// A sequence of instructions written to perform a specified task for a computer. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Program"></see></summary>
    let Program = _prefix "Program"
    /// <summary>
    /// The process of publishing the output of an ETL process. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Query over a structured or semi-structured data source.
    /// <see href="http://vocab.deri.ie/cogs#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// Maps data properties from source to target.
    /// <see href="http://vocab.deri.ie/cogs#RDFDataPropertyMapping"></see></summary>
    let RDFDataPropertyMapping = _prefix "RDFDataPropertyMapping"
    /// <summary>
    /// Maps terminological-level (schema-level) entities. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TerminologicalMapping"></see></summary>
    let TerminologicalMapping = _prefix "TerminologicalMapping"
    /// <summary>
    /// A set of RDF triples. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RDFGraph"></see></summary>
    let RDFGraph = _prefix "RDFGraph"
    /// <summary>
    /// Maps an instance-level element from a source to an instance-level element in a target dataset.
    /// <see href="http://vocab.deri.ie/cogs#RDFInstanceMapping"></see></summary>
    let RDFInstanceMapping = _prefix "RDFInstanceMapping"
    /// <summary>
    /// Multiple RDF graphs in a single document/repository and naming them with URIs. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RDFNamedGraph"></see></summary>
    let RDFNamedGraph = _prefix "RDFNamedGraph"
    /// <summary>
    /// Maps object properties from source to target.
    /// <see href="http://vocab.deri.ie/cogs#RDFObjectPropertyMapping"></see></summary>
    let RDFObjectPropertyMapping = _prefix "RDFObjectPropertyMapping"
    /// <summary>
    /// Lookup on a REST service. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RESTLookup"></see></summary>
    let RESTLookup = _prefix "RESTLookup"
    /// <summary>
    /// Filter written in a formal language that can be interpreted by a regular expression processor. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RegexFilter"></see></summary>
    let RegexFilter = _prefix "RegexFilter"
    /// <summary>
    /// Data that contain database violations and are forbidden to get inserted into a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RejectedData"></see></summary>
    let RejectedData = _prefix "RejectedData"
    /// <summary>
    /// Changes the name of a certain column. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RenameColumn"></see></summary>
    let RenameColumn = _prefix "RenameColumn"
    /// <summary>
    /// String operation for updating the content of a string. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Replace"></see></summary>
    let Replace = _prefix "Replace"
    /// <summary>
    /// Round a numeric value to a close number by following a specific rounding criteria. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Round"></see></summary>
    let Round = _prefix "Round"
    /// <summary>
    /// A serie of objects placed in line. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Row"></see></summary>
    let Row = _prefix "Row"
    /// <summary>
    /// A principle or formula. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Rule"></see></summary>
    let Rule = _prefix "Rule"
    /// <summary>
    /// Matching of data based on a rule or group of rules. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RulesBasedMatching"></see></summary>
    let RulesBasedMatching = _prefix "RulesBasedMatching"
    /// <summary>
    /// Status of a job that is in the state of being operated. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Running"></see></summary>
    let Running = _prefix "Running"
    /// <summary>
    /// Job that owns information on when and how often it has to execute operations. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ScheduledJob"></see></summary>
    let ScheduledJob = _prefix "ScheduledJob"
    /// <summary>
    /// The structure of a database system described in a formal language supported by the database management system. Describes tables, for example. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    /// A program or sequence of instructions that is interpreted or carried out by another program rather than by the computer processor. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Script"></see></summary>
    let Script = _prefix "Script"
    /// <summary>
    /// Query that locates and displays information requested. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SelectQueryObject"></see></summary>
    let SelectQueryObject = _prefix "SelectQueryObject"
    /// <summary>
    /// Matching by a measure of semantic similarity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SemanticSimilarity"></see></summary>
    let SemanticSimilarity = _prefix "SemanticSimilarity"
    /// <summary>
    /// The process of matching two objects by a similarity measure. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SimilarityMatching"></see></summary>
    let SimilarityMatching = _prefix "SimilarityMatching"
    /// <summary>
    /// Device that measures or detects a real-world condition and converts the condition into an analog or digital representation. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// Software program, or the computer on which that program runs, that provides a specific kind of service to a client software. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Server"></see></summary>
    let Server = _prefix "Server"
    /// <summary>
    /// Action done by a device or user with the function of giving good by providing usefulness. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Row Operation that sorts rows based on a specified fields and on whether they should be sorted in ascending or descending order. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SortRow"></see></summary>
    let SortRow = _prefix "SortRow"
    /// <summary>
    /// A database, application, file or other storage facility from which the data is derived. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    /// String operation that returns a zero-based, one-dimensional array containing a specified number of substrings. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Split"></see></summary>
    let Split = _prefix "Split"
    /// <summary>
    /// Divides a column in one or more other columns. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SplitColumn"></see></summary>
    let SplitColumn = _prefix "SplitColumn"
    /// <summary>
    /// A place where data can be processed before entering the warehouse area. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StaggingArea"></see></summary>
    let StaggingArea = _prefix "StaggingArea"
    /// <summary>
    /// The final product; what the end users see. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StagingAreaArtifact"></see></summary>
    let StagingAreaArtifact = _prefix "StagingAreaArtifact"
    /// <summary>
    /// A transformation used to create unique primary key values or cycle through a sequential range of numbers to replace missing keys. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StoredProcedure"></see></summary>
    let StoredProcedure = _prefix "StoredProcedure"
    /// <summary>
    /// Provides means for matching strings of text, such as particular characters, words, or patterns of characters. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringFilter"></see></summary>
    let StringFilter = _prefix "StringFilter"
    /// <summary>
    /// Matching based on string similarity measures. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringSimilarity"></see></summary>
    let StringSimilarity = _prefix "StringSimilarity"
    /// <summary>
    /// Status of a job that had successful  performance. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Success"></see></summary>
    let Success = _prefix "Success"
    /// <summary>
    /// Process of using a known attribute to search for data on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TableLookup"></see></summary>
    let TableLookup = _prefix "TableLookup"
    /// <summary>
    /// Process that applies a series of rules or functions to the extracted data from the source to derive the data for loading into the end target. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TransformationProcess"></see></summary>
    let TransformationProcess = _prefix "TransformationProcess"
    /// <summary>
    /// A procedural code that is automatically executed in response to certain events on a particular table or view in a database.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Trigger"></see></summary>
    let Trigger = _prefix "Trigger"
    /// <summary>
    /// String operation for removing leading and trailing whitespace from a string. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Trim"></see></summary>
    let Trim = _prefix "Trim"
    /// <summary>
    /// Conversion on different units of measurement. @en-us
    /// <see href="http://vocab.deri.ie/cogs#UnitConversion"></see></summary>
    let UnitConversion = _prefix "UnitConversion"
    /// <summary>
    /// Query that changes the data of one or more records in a table.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#UpdateQueryObject"></see></summary>
    let UpdateQueryObject = _prefix "UpdateQueryObject"
    /// <summary>
    /// String operation for converting a string to uppercase. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Uppercase"></see></summary>
    let Uppercase = _prefix "Uppercase"
    /// <summary>
    /// A calculation performed on a specified input value.
    /// <see href="http://vocab.deri.ie/cogs#ValueCalculation"></see></summary>
    let ValueCalculation = _prefix "ValueCalculation"
    /// <summary>
    /// Consists of a stored query accessible as a virtual table composed of the result set of a query. @en-us
    /// <see href="http://vocab.deri.ie/cogs#View"></see></summary>
    let View = _prefix "View"
    /// <summary>
    /// Allows the retrieving of data from a web service and uses this during the form filling process.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#WebServiceLookup"></see></summary>
    let WebServiceLookup = _prefix "WebServiceLookup"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#associatedEndpoint"></see>
    /// </summary>
    let associatedEndpoint = _prefix "associatedEndpoint"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#associatedGraph"></see>
    /// </summary>
    let associatedGraph = _prefix "associatedGraph"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#dependsOn"></see>
    /// </summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    /// Last process in a transformation workflow.
    /// <see href="http://vocab.deri.ie/cogs#hasEndPoint"></see></summary>
    let hasEndPoint = _prefix "hasEndPoint"
    /// <summary>
    /// First process in a transformation workflow.
    /// <see href="http://vocab.deri.ie/cogs#hasStartPoint"></see></summary>
    let hasStartPoint = _prefix "hasStartPoint"
    /// <summary>
    /// This property allows the association between an abstract representation of a Transformation and an encapsulated computational artifact artifact (e.g. code, binary).
    /// <see href="http://vocab.deri.ie/cogs#isExpressedBy"></see></summary>
    let isExpressedBy = _prefix "isExpressedBy"
    /// <summary>
    /// Defines the ordering among two processes
    /// <see href="http://vocab.deri.ie/cogs#precededBy"></see></summary>
    let precededBy = _prefix "precededBy"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
