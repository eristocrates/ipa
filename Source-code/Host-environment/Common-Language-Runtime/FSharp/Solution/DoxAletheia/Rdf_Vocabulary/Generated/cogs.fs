namespace http.vocab.deri.ie.cogs.hash

open DoxAletheia.Rdf_Vocabulary

module cogs =
    let _namespace_name = "http://vocab.deri.ie/cogs#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#benkam"></see>
    /// </summary>
    let benkam = Namespaced_IRI.parse _namespace_name "benkam" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#andfre"></see>
    /// </summary>
    let andfre = Namespaced_IRI.parse _namespace_name "andfre" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#timleb"></see>
    /// </summary>
    let timleb = Namespaced_IRI.parse _namespace_name "timleb" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#AIFB%2FKIT"></see>
    /// </summary>
    let ``AIFB%2FKIT`` =
        Namespaced_IRI.parse _namespace_name "AIFB%2FKIT" |> NamespacedName

    /// <summary>
    /// Process that seeks a solution designed for a specific problem or task, non-generalizable, and not intended to be able to be adapted to other purposes. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AdHocProcess"></see></summary>
    let AdHocProcess =
        Namespaced_IRI.parse _namespace_name "AdHocProcess" |> NamespacedName

    /// <summary>
    /// The instantiation of an activity or workflow. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Execution"></see></summary>
    let Execution = Namespaced_IRI.parse _namespace_name "Execution" |> NamespacedName

    /// <summary>
    ///  Functions which return a single result row based on groups of rows. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AggregateRows"></see></summary>
    let AggregateRows =
        Namespaced_IRI.parse _namespace_name "AggregateRows" |> NamespacedName

    /// <summary>
    /// Instructions executed on rows of a table or file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RowOperation"></see></summary>
    let RowOperation =
        Namespaced_IRI.parse _namespace_name "RowOperation" |> NamespacedName

    /// <summary>
    /// String operation for concatenating lists or arrays. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Append"></see></summary>
    let Append = Namespaced_IRI.parse _namespace_name "Append" |> NamespacedName

    /// <summary>
    /// Operations for manipulating strings. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringOperation"></see></summary>
    let StringOperation =
        Namespaced_IRI.parse _namespace_name "StringOperation" |> NamespacedName

    /// <summary>
    /// New data are computed based on the user-defined formula. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ApplyFormula"></see></summary>
    let ApplyFormula =
        Namespaced_IRI.parse _namespace_name "ApplyFormula" |> NamespacedName

    /// <summary>
    /// Manipulate and manage numeric data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#NumericOperation"></see></summary>
    let NumericOperation =
        Namespaced_IRI.parse _namespace_name "NumericOperation" |> NamespacedName

    /// <summary>
    /// Execution of a script. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ApplyScript"></see></summary>
    let ApplyScript =
        Namespaced_IRI.parse _namespace_name "ApplyScript" |> NamespacedName

    /// <summary>
    /// Functional operations that can be done by a computer.
    /// <see href="http://vocab.deri.ie/cogs#Operation"></see></summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName
    /// <summary>
    /// Sets or re-sets the value stored in the storage location(s) denoted by a variable name. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Assignment"></see></summary>
    let Assignment = Namespaced_IRI.parse _namespace_name "Assignment" |> NamespacedName

    /// <summary>
    /// Evaluate a selected function for a particular value of x. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ValueOperation"></see></summary>
    let ValueOperation =
        Namespaced_IRI.parse _namespace_name "ValueOperation" |> NamespacedName

    /// <summary>
    /// A non-recurrent, not frequent automated process.
    /// <see href="http://vocab.deri.ie/cogs#AutomatedAdHocProcess"></see></summary>
    let AutomatedAdHocProcess =
        Namespaced_IRI.parse _namespace_name "AutomatedAdHocProcess" |> NamespacedName

    /// <summary>
    /// Task of finding entries that refer to the same entity across different data sources using computer resources. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AutomatedMatching"></see></summary>
    let AutomatedMatching =
        Namespaced_IRI.parse _namespace_name "AutomatedMatching" |> NamespacedName

    /// <summary>
    /// The process of mapping information from a source format to a destination format. @en-us
    /// <see href="http://vocab.deri.ie/cogs#MappingProcess"></see></summary>
    let MappingProcess =
        Namespaced_IRI.parse _namespace_name "MappingProcess" |> NamespacedName

    /// <summary>
    /// Validation performed by a computer. @en-us
    /// <see href="http://vocab.deri.ie/cogs#AutomatedValidation"></see></summary>
    let AutomatedValidation =
        Namespaced_IRI.parse _namespace_name "AutomatedValidation" |> NamespacedName

    /// <summary>
    /// The act of validating; finding or testing the truth of something. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Validation"></see></summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName
    /// <summary>
    /// Returns the smallest integer greater than or equal to n. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Ceil"></see></summary>
    let Ceil = Namespaced_IRI.parse _namespace_name "Ceil" |> NamespacedName

    /// <summary>
    /// Converts strings between different character sets. @en-us
    /// <see href="http://vocab.deri.ie/cogs#CharacterSetConversion"></see></summary>
    let CharacterSetConversion =
        Namespaced_IRI.parse _namespace_name "CharacterSetConversion" |> NamespacedName

    /// <summary>
    /// A construct that is used as a blueprint to create instances of the class. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    /// Database tables are composed of individual columns corresponding to the attributes of the object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Column"></see></summary>
    let Column = Namespaced_IRI.parse _namespace_name "Column" |> NamespacedName

    /// <summary>
    /// Instructions applied on one or more columns. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ColumnOperation"></see></summary>
    let ColumnOperation =
        Namespaced_IRI.parse _namespace_name "ColumnOperation" |> NamespacedName

    /// <summary>
    /// If the primary key of an incoming record matches with the key of an existing Record, leaves the existing Record, adds the incoming record and marks the added record as superseding the old record. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ConstructiveMerge"></see></summary>
    let ConstructiveMerge =
        Namespaced_IRI.parse _namespace_name "ConstructiveMerge" |> NamespacedName

    /// <summary>
    /// Stage that is responsible for loading data into the end target. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Loading"></see></summary>
    let Loading = Namespaced_IRI.parse _namespace_name "Loading" |> NamespacedName
    /// <summary>
    /// A piece of data that was duplicated. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Copy"></see></summary>
    let Copy = Namespaced_IRI.parse _namespace_name "Copy" |> NamespacedName
    /// <summary>
    /// A multidimensional database that holds data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Cube"></see></summary>
    let Cube = Namespaced_IRI.parse _namespace_name "Cube" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "DERI%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    /// Data Source Name (DSN) is a data structure that contains the information about a specific database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DSN"></see></summary>
    let DSN = Namespaced_IRI.parse _namespace_name "DSN" |> NamespacedName

    /// <summary>
    /// Layer that controls access to data in a computer-based information system. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataAccessLayer"></see></summary>
    let DataAccessLayer =
        Namespaced_IRI.parse _namespace_name "DataAccessLayer" |> NamespacedName

    /// <summary>
    /// Each individual level. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Layer"></see></summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName

    /// <summary>
    /// Layer responsible for the development, execution and supervision of plans, policies, programs and practices that control, protect, deliver and enhance the value of data and information assets. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataManagementLayer"></see></summary>
    let DataManagementLayer =
        Namespaced_IRI.parse _namespace_name "DataManagementLayer" |> NamespacedName

    /// <summary>
    /// Data mart is a process-oriented subset of the overall organization’s data based on a foundation of atomic data, and that depends only on the structure of the data-measurement events, not on the anticipated user’s questions.
    /// <see href="http://vocab.deri.ie/cogs#DataMart"></see></summary>
    let DataMart = Namespaced_IRI.parse _namespace_name "DataMart" |> NamespacedName
    /// <summary>
    /// A sequence of digitally encoded coherent signals (packets of data) used to transmit or receive information that is in the process of being transmitted. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DataStream"></see></summary>
    let DataStream = Namespaced_IRI.parse _namespace_name "DataStream" |> NamespacedName
    /// <summary>
    /// A database is a collection of information organized into interrelated tables of data and specifications of data objects. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// Conversion from a datetime format to a different one.
    /// <see href="http://vocab.deri.ie/cogs#DatetimeConversion"></see></summary>
    let DatetimeConversion =
        Namespaced_IRI.parse _namespace_name "DatetimeConversion" |> NamespacedName

    /// <summary>
    /// Elimination of redundant data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Deduplication"></see></summary>
    let Deduplication =
        Namespaced_IRI.parse _namespace_name "Deduplication" |> NamespacedName

    /// <summary>
    /// Deletes one or more columns according to a certain criteria to a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteColumn"></see></summary>
    let DeleteColumn =
        Namespaced_IRI.parse _namespace_name "DeleteColumn" |> NamespacedName

    /// <summary>
    /// Query that does a delete operation on a row, column, table for example. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteQueryObject"></see></summary>
    let DeleteQueryObject =
        Namespaced_IRI.parse _namespace_name "DeleteQueryObject" |> NamespacedName

    /// <summary>
    /// A structured object which is used to request information or perform an action in a database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#QueryObject"></see></summary>
    let QueryObject =
        Namespaced_IRI.parse _namespace_name "QueryObject" |> NamespacedName

    /// <summary>
    /// Exclusion of a single or group of rows by a certain criteria on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteRow"></see></summary>
    let DeleteRow = Namespaced_IRI.parse _namespace_name "DeleteRow" |> NamespacedName

    /// <summary>
    /// Deletes on or more triples into the store.@en-us
    /// <see href="http://vocab.deri.ie/cogs#DeleteTriple"></see></summary>
    let DeleteTriple =
        Namespaced_IRI.parse _namespace_name "DeleteTriple" |> NamespacedName

    /// <summary>
    /// Instructions performed on graphs. @en-us
    /// <see href="http://vocab.deri.ie/cogs#GraphOperation"></see></summary>
    let GraphOperation =
        Namespaced_IRI.parse _namespace_name "GraphOperation" |> NamespacedName

    /// <summary>
    /// Inputs the incoming data to the target data if the primary key of an incoming record matches with the key of an existing record, updating the matching target record. If the incoming record is a new record without a match with any existing record, it adds the incoming record to the target table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DestructiveMerge"></see></summary>
    let DestructiveMerge =
        Namespaced_IRI.parse _namespace_name "DestructiveMerge" |> NamespacedName

    /// <summary>
    /// A machine designed for a purpose. E.g.: Unit of hardware.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName

    /// <summary>
    /// One of the set of companion tables to a fact table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#DimensionTable"></see></summary>
    let DimensionTable =
        Namespaced_IRI.parse _namespace_name "DimensionTable" |> NamespacedName

    /// <summary>
    /// A predefined format of rows and columns that define a database entity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName
    /// <summary>
    /// Database access point as a web service (SPARQL Endpoint) . @en-us
    /// <see href="http://vocab.deri.ie/cogs#Endpoint"></see></summary>
    let Endpoint = Namespaced_IRI.parse _namespace_name "Endpoint" |> NamespacedName
    /// <summary>
    /// An action that is usually initiated outside the scope of a program and that is handled by a piece of code inside the program. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// An event, which occurs during the execution of a program, which disrupts the normal flow of the program's instructions. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Exception"></see></summary>
    let Exception = Namespaced_IRI.parse _namespace_name "Exception" |> NamespacedName

    /// <summary>
    /// Provides the current execution status of a running process instance (a job). e.g. : fail, running, success. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ExecutionStatus"></see></summary>
    let ExecutionStatus =
        Namespaced_IRI.parse _namespace_name "ExecutionStatus" |> NamespacedName

    /// <summary>
    /// The first part of an ETL process which involves extracting the data from source systems. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Extraction"></see></summary>
    let Extraction = Namespaced_IRI.parse _namespace_name "Extraction" |> NamespacedName
    /// <summary>
    /// A table that consists of the measurements, metrics or facts of a  process. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FactTable"></see></summary>
    let FactTable = Namespaced_IRI.parse _namespace_name "FactTable" |> NamespacedName
    /// <summary>
    /// Status of a job that stops operating or functioning. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Fail"></see></summary>
    let Fail = Namespaced_IRI.parse _namespace_name "Fail" |> NamespacedName

    /// <summary>
    /// Performs decoding operations when you specify field-encoding function. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FieldDecoding"></see></summary>
    let FieldDecoding =
        Namespaced_IRI.parse _namespace_name "FieldDecoding" |> NamespacedName

    /// <summary>
    /// A block of arbitrary information, or resource for storing information, which is available to a computer program. @en-us
    /// <see href="http://vocab.deri.ie/cogs#File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName
    /// <summary>
    /// The process of looking up for information on a file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FileLookup"></see></summary>
    let FileLookup = Namespaced_IRI.parse _namespace_name "FileLookup" |> NamespacedName
    /// <summary>
    /// A process used to look up data in a relational table, view or dictionary. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Lookup"></see></summary>
    let Lookup = Namespaced_IRI.parse _namespace_name "Lookup" |> NamespacedName
    /// <summary>
    /// Copy the contents of the topmost cells of a selected range into the cells below.@en-us
    /// <see href="http://vocab.deri.ie/cogs#FillDown"></see></summary>
    let FillDown = Namespaced_IRI.parse _namespace_name "FillDown" |> NamespacedName
    /// <summary>
    /// An operation that can be used to retain rows in a mapping that do not meet specific conditions. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Filter"></see></summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    /// Reviews the file format. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FormatRevision"></see></summary>
    let FormatRevision =
        Namespaced_IRI.parse _namespace_name "FormatRevision" |> NamespacedName

    /// <summary>
    /// A rule or principle. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Formula"></see></summary>
    let Formula = Namespaced_IRI.parse _namespace_name "Formula" |> NamespacedName

    /// <summary>
    /// Truncates all the tables and data gets loaded again. @en-us
    /// <see href="http://vocab.deri.ie/cogs#FullRefresh"></see></summary>
    let FullRefresh =
        Namespaced_IRI.parse _namespace_name "FullRefresh" |> NamespacedName

    /// <summary>
    /// Matching based on a human decision.
    /// <see href="http://vocab.deri.ie/cogs#HumanMatching"></see></summary>
    let HumanMatching =
        Namespaced_IRI.parse _namespace_name "HumanMatching" |> NamespacedName

    /// <summary>
    /// Validation performed by a person:  an user or admin. @en-us
    /// <see href="http://vocab.deri.ie/cogs#HumanValidation"></see></summary>
    let HumanValidation =
        Namespaced_IRI.parse _namespace_name "HumanValidation" |> NamespacedName

    /// <summary>
    /// Applies ongoing changes to one or more tables based on a predefined schedule. @en-us
    /// <see href="http://vocab.deri.ie/cogs#IncrementalLoad"></see></summary>
    let IncrementalLoad =
        Namespaced_IRI.parse _namespace_name "IncrementalLoad" |> NamespacedName

    /// <summary>
    /// Populates the tables in the data warehouse schema and verifies if the data is ready for use. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InitialLoad"></see></summary>
    let InitialLoad =
        Namespaced_IRI.parse _namespace_name "InitialLoad" |> NamespacedName

    /// <summary>
    /// Any data entered into a computer.@en-us
    /// <see href="http://vocab.deri.ie/cogs#Input"></see></summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName

    /// <summary>
    /// Inserts one or more columns according to a certain criteria to a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertColumn"></see></summary>
    let InsertColumn =
        Namespaced_IRI.parse _namespace_name "InsertColumn" |> NamespacedName

    /// <summary>
    /// Query that inserts data into the database. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertQueryObject"></see></summary>
    let InsertQueryObject =
        Namespaced_IRI.parse _namespace_name "InsertQueryObject" |> NamespacedName

    /// <summary>
    /// Inclusion of a row on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertRow"></see></summary>
    let InsertRow = Namespaced_IRI.parse _namespace_name "InsertRow" |> NamespacedName

    /// <summary>
    /// Includes one or more triple into the store. @en-us
    /// <see href="http://vocab.deri.ie/cogs#InsertTriple"></see></summary>
    let InsertTriple =
        Namespaced_IRI.parse _namespace_name "InsertTriple" |> NamespacedName

    /// <summary>
    /// The instance of a process or group of processes (workflow).
    /// <see href="http://vocab.deri.ie/cogs#Job"></see></summary>
    let Job = Namespaced_IRI.parse _namespace_name "Job" |> NamespacedName
    /// <summary>
    /// Row Operation that allows combinations (Cartesian product) of all rows in the input streams.@en-us
    /// <see href="http://vocab.deri.ie/cogs#JoinRows"></see></summary>
    let JoinRows = Namespaced_IRI.parse _namespace_name "JoinRows" |> NamespacedName

    /// <summary>
    /// Process of generating keys/indexes for tables. @en-us
    /// <see href="http://vocab.deri.ie/cogs#KeyGeneration"></see></summary>
    let KeyGeneration =
        Namespaced_IRI.parse _namespace_name "KeyGeneration" |> NamespacedName

    /// <summary>
    /// Transformation of keys with built-in meanings into generic keys. @en-us
    /// <see href="http://vocab.deri.ie/cogs#KeyRestructuring"></see></summary>
    let KeyRestructuring =
        Namespaced_IRI.parse _namespace_name "KeyRestructuring" |> NamespacedName

    /// <summary>
    /// Final error on a execution workflow. @en-us
    /// <see href="http://vocab.deri.ie/cogs#LastError"></see></summary>
    let LastError = Namespaced_IRI.parse _namespace_name "LastError" |> NamespacedName
    /// <summary>
    /// A record of computer activity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Log"></see></summary>
    let Log = Namespaced_IRI.parse _namespace_name "Log" |> NamespacedName

    /// <summary>
    /// The process of manipulating data. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Transformation"></see></summary>
    let Transformation =
        Namespaced_IRI.parse _namespace_name "Transformation" |> NamespacedName

    /// <summary>
    /// String operation for converting a string to lowercase.@en-us
    /// <see href="http://vocab.deri.ie/cogs#Lowercase"></see></summary>
    let Lowercase = Namespaced_IRI.parse _namespace_name "Lowercase" |> NamespacedName

    /// <summary>
    /// A non-recurrent, not-frequent manual process.
    /// <see href="http://vocab.deri.ie/cogs#ManualAdHocProcess"></see></summary>
    let ManualAdHocProcess =
        Namespaced_IRI.parse _namespace_name "ManualAdHocProcess" |> NamespacedName

    /// <summary>
    /// Job that was initialized by an user. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ManuallyStartedJob"></see></summary>
    let ManuallyStartedJob =
        Namespaced_IRI.parse _namespace_name "ManuallyStartedJob" |> NamespacedName

    /// <summary>
    /// The definition of a semantic equivalence relationship between source and target objects. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Mapping"></see></summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName

    /// <summary>
    /// The specification of a mapping between source and target fields (e.g. RDB2RDF).
    /// <see href="http://vocab.deri.ie/cogs#MappingFile"></see></summary>
    let MappingFile =
        Namespaced_IRI.parse _namespace_name "MappingFile" |> NamespacedName

    /// <summary>
    /// Row Operation that allows the comparison of two streams of rows. It is often used in situations where the source system of a data warehouse does not contain a date of last update. @en-us
    /// <see href="http://vocab.deri.ie/cogs#MergeRow"></see></summary>
    let MergeRow = Namespaced_IRI.parse _namespace_name "MergeRow" |> NamespacedName
    /// <summary>
    /// Data that describe data and other structures, such as objects, business rules and processes. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Metadata"></see></summary>
    let Metadata = Namespaced_IRI.parse _namespace_name "Metadata" |> NamespacedName
    /// <summary>
    /// A subroutine that is exclusively associated with a object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    /// To change in position from one point to another. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Move"></see></summary>
    let Move = Namespaced_IRI.parse _namespace_name "Move" |> NamespacedName

    /// <summary>
    /// Converts an expression of one numeric data type to another. @en-us
    /// <see href="http://vocab.deri.ie/cogs#NumericCast"></see></summary>
    let NumericCast =
        Namespaced_IRI.parse _namespace_name "NumericCast" |> NamespacedName

    /// <summary>
    /// Value that enables a program to indirectly access a particular object. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ObjectReference"></see></summary>
    let ObjectReference =
        Namespaced_IRI.parse _namespace_name "ObjectReference" |> NamespacedName

    /// <summary>
    /// Internal representation of an object suitable for matching its features. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ObjectRepresentation"></see></summary>
    let ObjectRepresentation =
        Namespaced_IRI.parse _namespace_name "ObjectRepresentation" |> NamespacedName

    /// <summary>
    /// A symbol or function representing a mathematical operation. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    /// Application of a specific order to a set of elemetns.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Order"></see></summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    /// Information, resulting from computer processing, that is delivered to a user. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Output"></see></summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    /// Process of analyzing text or data, checking for correct syntax and building a representation based on the input tokens. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Parsing"></see></summary>
    let Parsing = Namespaced_IRI.parse _namespace_name "Parsing" |> NamespacedName
    /// <summary>
    /// To copy an object from a buffer  or clipboard to a file. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Paste"></see></summary>
    let Paste = Namespaced_IRI.parse _namespace_name "Paste" |> NamespacedName

    /// <summary>
    /// Measures used to evaluate the success of a particular activity.
    /// <see href="http://vocab.deri.ie/cogs#PerformanceIndicator"></see></summary>
    let PerformanceIndicator =
        Namespaced_IRI.parse _namespace_name "PerformanceIndicator" |> NamespacedName

    /// <summary>
    /// Forces a matching under a certain predefined criteria.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#PredefinedMatching"></see></summary>
    let PredefinedMatching =
        Namespaced_IRI.parse _namespace_name "PredefinedMatching" |> NamespacedName

    /// <summary>
    /// Preliminary filtering during the extraction phase.
    /// <see href="http://vocab.deri.ie/cogs#Prefiltering"></see></summary>
    let Prefiltering =
        Namespaced_IRI.parse _namespace_name "Prefiltering" |> NamespacedName

    /// <summary>
    /// What the user sees. @en-us
    /// <see href="http://vocab.deri.ie/cogs#PresentationArea"></see></summary>
    let PresentationArea =
        Namespaced_IRI.parse _namespace_name "PresentationArea" |> NamespacedName

    /// <summary>
    /// A sequence of instructions written to perform a specified task for a computer. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Program"></see></summary>
    let Program = Namespaced_IRI.parse _namespace_name "Program" |> NamespacedName

    /// <summary>
    /// The process of publishing the output of an ETL process. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// Query over a structured or semi-structured data source.
    /// <see href="http://vocab.deri.ie/cogs#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    /// Maps data properties from source to target.
    /// <see href="http://vocab.deri.ie/cogs#RDFDataPropertyMapping"></see></summary>
    let RDFDataPropertyMapping =
        Namespaced_IRI.parse _namespace_name "RDFDataPropertyMapping" |> NamespacedName

    /// <summary>
    /// Maps terminological-level (schema-level) entities. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TerminologicalMapping"></see></summary>
    let TerminologicalMapping =
        Namespaced_IRI.parse _namespace_name "TerminologicalMapping" |> NamespacedName

    /// <summary>
    /// A set of RDF triples. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RDFGraph"></see></summary>
    let RDFGraph = Namespaced_IRI.parse _namespace_name "RDFGraph" |> NamespacedName

    /// <summary>
    /// Maps an instance-level element from a source to an instance-level element in a target dataset.
    /// <see href="http://vocab.deri.ie/cogs#RDFInstanceMapping"></see></summary>
    let RDFInstanceMapping =
        Namespaced_IRI.parse _namespace_name "RDFInstanceMapping" |> NamespacedName

    /// <summary>
    /// Multiple RDF graphs in a single document/repository and naming them with URIs. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RDFNamedGraph"></see></summary>
    let RDFNamedGraph =
        Namespaced_IRI.parse _namespace_name "RDFNamedGraph" |> NamespacedName

    /// <summary>
    /// Maps object properties from source to target.
    /// <see href="http://vocab.deri.ie/cogs#RDFObjectPropertyMapping"></see></summary>
    let RDFObjectPropertyMapping =
        Namespaced_IRI.parse _namespace_name "RDFObjectPropertyMapping" |> NamespacedName

    /// <summary>
    /// Lookup on a REST service. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RESTLookup"></see></summary>
    let RESTLookup = Namespaced_IRI.parse _namespace_name "RESTLookup" |> NamespacedName

    /// <summary>
    /// Filter written in a formal language that can be interpreted by a regular expression processor. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RegexFilter"></see></summary>
    let RegexFilter =
        Namespaced_IRI.parse _namespace_name "RegexFilter" |> NamespacedName

    /// <summary>
    /// Data that contain database violations and are forbidden to get inserted into a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RejectedData"></see></summary>
    let RejectedData =
        Namespaced_IRI.parse _namespace_name "RejectedData" |> NamespacedName

    /// <summary>
    /// Changes the name of a certain column. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RenameColumn"></see></summary>
    let RenameColumn =
        Namespaced_IRI.parse _namespace_name "RenameColumn" |> NamespacedName

    /// <summary>
    /// String operation for updating the content of a string. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Replace"></see></summary>
    let Replace = Namespaced_IRI.parse _namespace_name "Replace" |> NamespacedName
    /// <summary>
    /// Round a numeric value to a close number by following a specific rounding criteria. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Round"></see></summary>
    let Round = Namespaced_IRI.parse _namespace_name "Round" |> NamespacedName
    /// <summary>
    /// A serie of objects placed in line. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Row"></see></summary>
    let Row = Namespaced_IRI.parse _namespace_name "Row" |> NamespacedName
    /// <summary>
    /// A principle or formula. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName

    /// <summary>
    /// Matching of data based on a rule or group of rules. @en-us
    /// <see href="http://vocab.deri.ie/cogs#RulesBasedMatching"></see></summary>
    let RulesBasedMatching =
        Namespaced_IRI.parse _namespace_name "RulesBasedMatching" |> NamespacedName

    /// <summary>
    /// Status of a job that is in the state of being operated. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Running"></see></summary>
    let Running = Namespaced_IRI.parse _namespace_name "Running" |> NamespacedName

    /// <summary>
    /// Job that owns information on when and how often it has to execute operations. @en-us
    /// <see href="http://vocab.deri.ie/cogs#ScheduledJob"></see></summary>
    let ScheduledJob =
        Namespaced_IRI.parse _namespace_name "ScheduledJob" |> NamespacedName

    /// <summary>
    /// The structure of a database system described in a formal language supported by the database management system. Describes tables, for example. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName
    /// <summary>
    /// A program or sequence of instructions that is interpreted or carried out by another program rather than by the computer processor. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Script"></see></summary>
    let Script = Namespaced_IRI.parse _namespace_name "Script" |> NamespacedName

    /// <summary>
    /// Query that locates and displays information requested. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SelectQueryObject"></see></summary>
    let SelectQueryObject =
        Namespaced_IRI.parse _namespace_name "SelectQueryObject" |> NamespacedName

    /// <summary>
    /// Matching by a measure of semantic similarity. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SemanticSimilarity"></see></summary>
    let SemanticSimilarity =
        Namespaced_IRI.parse _namespace_name "SemanticSimilarity" |> NamespacedName

    /// <summary>
    /// The process of matching two objects by a similarity measure. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SimilarityMatching"></see></summary>
    let SimilarityMatching =
        Namespaced_IRI.parse _namespace_name "SimilarityMatching" |> NamespacedName

    /// <summary>
    /// Device that measures or detects a real-world condition and converts the condition into an analog or digital representation. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Sensor"></see></summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName
    /// <summary>
    /// Software program, or the computer on which that program runs, that provides a specific kind of service to a client software. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Server"></see></summary>
    let Server = Namespaced_IRI.parse _namespace_name "Server" |> NamespacedName
    /// <summary>
    /// Action done by a device or user with the function of giving good by providing usefulness. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// Row Operation that sorts rows based on a specified fields and on whether they should be sorted in ascending or descending order. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SortRow"></see></summary>
    let SortRow = Namespaced_IRI.parse _namespace_name "SortRow" |> NamespacedName
    /// <summary>
    /// A database, application, file or other storage facility from which the data is derived. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    /// String operation that returns a zero-based, one-dimensional array containing a specified number of substrings. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Split"></see></summary>
    let Split = Namespaced_IRI.parse _namespace_name "Split" |> NamespacedName

    /// <summary>
    /// Divides a column in one or more other columns. @en-us
    /// <see href="http://vocab.deri.ie/cogs#SplitColumn"></see></summary>
    let SplitColumn =
        Namespaced_IRI.parse _namespace_name "SplitColumn" |> NamespacedName

    /// <summary>
    /// A place where data can be processed before entering the warehouse area. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StaggingArea"></see></summary>
    let StaggingArea =
        Namespaced_IRI.parse _namespace_name "StaggingArea" |> NamespacedName

    /// <summary>
    /// The final product; what the end users see. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StagingAreaArtifact"></see></summary>
    let StagingAreaArtifact =
        Namespaced_IRI.parse _namespace_name "StagingAreaArtifact" |> NamespacedName

    /// <summary>
    /// A transformation used to create unique primary key values or cycle through a sequential range of numbers to replace missing keys. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StoredProcedure"></see></summary>
    let StoredProcedure =
        Namespaced_IRI.parse _namespace_name "StoredProcedure" |> NamespacedName

    /// <summary>
    /// Provides means for matching strings of text, such as particular characters, words, or patterns of characters. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringFilter"></see></summary>
    let StringFilter =
        Namespaced_IRI.parse _namespace_name "StringFilter" |> NamespacedName

    /// <summary>
    /// Matching based on string similarity measures. @en-us
    /// <see href="http://vocab.deri.ie/cogs#StringSimilarity"></see></summary>
    let StringSimilarity =
        Namespaced_IRI.parse _namespace_name "StringSimilarity" |> NamespacedName

    /// <summary>
    /// Status of a job that had successful  performance. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Success"></see></summary>
    let Success = Namespaced_IRI.parse _namespace_name "Success" |> NamespacedName

    /// <summary>
    /// Process of using a known attribute to search for data on a table. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TableLookup"></see></summary>
    let TableLookup =
        Namespaced_IRI.parse _namespace_name "TableLookup" |> NamespacedName

    /// <summary>
    /// Process that applies a series of rules or functions to the extracted data from the source to derive the data for loading into the end target. @en-us
    /// <see href="http://vocab.deri.ie/cogs#TransformationProcess"></see></summary>
    let TransformationProcess =
        Namespaced_IRI.parse _namespace_name "TransformationProcess" |> NamespacedName

    /// <summary>
    /// A procedural code that is automatically executed in response to certain events on a particular table or view in a database.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#Trigger"></see></summary>
    let Trigger = Namespaced_IRI.parse _namespace_name "Trigger" |> NamespacedName
    /// <summary>
    /// String operation for removing leading and trailing whitespace from a string. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Trim"></see></summary>
    let Trim = Namespaced_IRI.parse _namespace_name "Trim" |> NamespacedName

    /// <summary>
    /// Conversion on different units of measurement. @en-us
    /// <see href="http://vocab.deri.ie/cogs#UnitConversion"></see></summary>
    let UnitConversion =
        Namespaced_IRI.parse _namespace_name "UnitConversion" |> NamespacedName

    /// <summary>
    /// Query that changes the data of one or more records in a table.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#UpdateQueryObject"></see></summary>
    let UpdateQueryObject =
        Namespaced_IRI.parse _namespace_name "UpdateQueryObject" |> NamespacedName

    /// <summary>
    /// String operation for converting a string to uppercase. @en-us
    /// <see href="http://vocab.deri.ie/cogs#Uppercase"></see></summary>
    let Uppercase = Namespaced_IRI.parse _namespace_name "Uppercase" |> NamespacedName

    /// <summary>
    /// A calculation performed on a specified input value.
    /// <see href="http://vocab.deri.ie/cogs#ValueCalculation"></see></summary>
    let ValueCalculation =
        Namespaced_IRI.parse _namespace_name "ValueCalculation" |> NamespacedName

    /// <summary>
    /// Consists of a stored query accessible as a virtual table composed of the result set of a query. @en-us
    /// <see href="http://vocab.deri.ie/cogs#View"></see></summary>
    let View = Namespaced_IRI.parse _namespace_name "View" |> NamespacedName

    /// <summary>
    /// Allows the retrieving of data from a web service and uses this during the form filling process.  @en-us
    /// <see href="http://vocab.deri.ie/cogs#WebServiceLookup"></see></summary>
    let WebServiceLookup =
        Namespaced_IRI.parse _namespace_name "WebServiceLookup" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#associatedEndpoint"></see>
    /// </summary>
    let associatedEndpoint =
        Namespaced_IRI.parse _namespace_name "associatedEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#associatedGraph"></see>
    /// </summary>
    let associatedGraph =
        Namespaced_IRI.parse _namespace_name "associatedGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#dependsOn"></see>
    /// </summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName

    /// <summary>
    /// Last process in a transformation workflow.
    /// <see href="http://vocab.deri.ie/cogs#hasEndPoint"></see></summary>
    let hasEndPoint =
        Namespaced_IRI.parse _namespace_name "hasEndPoint" |> NamespacedName

    /// <summary>
    /// First process in a transformation workflow.
    /// <see href="http://vocab.deri.ie/cogs#hasStartPoint"></see></summary>
    let hasStartPoint =
        Namespaced_IRI.parse _namespace_name "hasStartPoint" |> NamespacedName

    /// <summary>
    /// This property allows the association between an abstract representation of a Transformation and an encapsulated computational artifact artifact (e.g. code, binary).
    /// <see href="http://vocab.deri.ie/cogs#isExpressedBy"></see></summary>
    let isExpressedBy =
        Namespaced_IRI.parse _namespace_name "isExpressedBy" |> NamespacedName

    /// <summary>
    /// Defines the ordering among two processes
    /// <see href="http://vocab.deri.ie/cogs#precededBy"></see></summary>
    let precededBy = Namespaced_IRI.parse _namespace_name "precededBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/cogs#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
