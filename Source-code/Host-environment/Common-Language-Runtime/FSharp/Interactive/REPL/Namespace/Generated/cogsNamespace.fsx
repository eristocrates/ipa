#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cogs =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/cogs#" "cogs"
    let ``AIFB%2FKIT`` = _prefixId.prefix "AIFB%2FKIT"
    /// <summary>
    ///   <para>rdfs:label : AdHocProcess^^xsd:string</para>
    ///   <para>rdfs:comment : Process that seeks a solution designed for a specific problem or task, non-generalizable, and not intended to be able to be adapted to other purposes. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#AdHocProcess">cogs:AdHocProcess</a>
    /// </summary>
    let AdHocProcess = _prefixId.prefix "AdHocProcess"
    /// <summary>
    ///   <para>rdfs:label : AggregateRows^^xsd:string</para>
    ///   <para>rdfs:comment :  Functions which return a single result row based on groups of rows. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#AggregateRows">cogs:AggregateRows</a>
    /// </summary>
    let AggregateRows = _prefixId.prefix "AggregateRows"
    /// <summary>
    ///   <para>rdfs:label : Append^^xsd:string</para>
    ///   <para>rdfs:comment : String operation for concatenating lists or arrays. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Append">cogs:Append</a>
    /// </summary>
    let Append = _prefixId.prefix "Append"
    /// <summary>
    ///   <para>rdfs:label : ApplyFormula^^xsd:string</para>
    ///   <para>rdfs:comment : New data are computed based on the user-defined formula. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ApplyFormula">cogs:ApplyFormula</a>
    /// </summary>
    let ApplyFormula = _prefixId.prefix "ApplyFormula"
    /// <summary>
    ///   <para>rdfs:label : ApplyScript^^xsd:string</para>
    ///   <para>rdfs:comment : Execution of a script. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ApplyScript">cogs:ApplyScript</a>
    /// </summary>
    let ApplyScript = _prefixId.prefix "ApplyScript"
    /// <summary>
    ///   <para>rdfs:label : Assignment^^xsd:string</para>
    ///   <para>rdfs:comment : Sets or re-sets the value stored in the storage location(s) denoted by a variable name. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Assignment">cogs:Assignment</a>
    /// </summary>
    let Assignment = _prefixId.prefix "Assignment"
    /// <summary>
    ///   <para>rdfs:label : AutomatedAdHocProcess^^xsd:string</para>
    ///   <para>rdfs:comment : A non-recurrent, not frequent automated process.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#AutomatedAdHocProcess">cogs:AutomatedAdHocProcess</a>
    /// </summary>
    let AutomatedAdHocProcess = _prefixId.prefix "AutomatedAdHocProcess"
    /// <summary>
    ///   <para>rdfs:label : AutomatedMatching^^xsd:string</para>
    ///   <para>rdfs:comment : Task of finding entries that refer to the same entity across different data sources using computer resources. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#AutomatedMatching">cogs:AutomatedMatching</a>
    /// </summary>
    let AutomatedMatching = _prefixId.prefix "AutomatedMatching"
    /// <summary>
    ///   <para>rdfs:label : AutomatedValidation^^xsd:string</para>
    ///   <para>rdfs:comment : Validation performed by a computer. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#AutomatedValidation">cogs:AutomatedValidation</a>
    /// </summary>
    let AutomatedValidation = _prefixId.prefix "AutomatedValidation"
    /// <summary>
    ///   <para>rdfs:label : Ceil^^xsd:string</para>
    ///   <para>rdfs:comment : Returns the smallest integer greater than or equal to n. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Ceil">cogs:Ceil</a>
    /// </summary>
    let Ceil = _prefixId.prefix "Ceil"
    /// <summary>
    ///   <para>rdfs:label : CharacterSetConversion^^xsd:string</para>
    ///   <para>rdfs:comment : Converts strings between different character sets. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#CharacterSetConversion">cogs:CharacterSetConversion</a>
    /// </summary>
    let CharacterSetConversion = _prefixId.prefix "CharacterSetConversion"
    /// <summary>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <para>rdfs:comment : A construct that is used as a blueprint to create instances of the class. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Class">cogs:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:label : Column^^xsd:string</para>
    ///   <para>rdfs:comment : Database tables are composed of individual columns corresponding to the attributes of the object. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Column">cogs:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:label : ColumnOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Instructions applied on one or more columns. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ColumnOperation">cogs:ColumnOperation</a>
    /// </summary>
    let ColumnOperation = _prefixId.prefix "ColumnOperation"
    /// <summary>
    ///   <para>rdfs:label : ConstructiveMerge^^xsd:string</para>
    ///   <para>rdfs:comment : If the primary key of an incoming record matches with the key of an existing Record, leaves the existing Record, adds the incoming record and marks the added record as superseding the old record. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ConstructiveMerge">cogs:ConstructiveMerge</a>
    /// </summary>
    let ConstructiveMerge = _prefixId.prefix "ConstructiveMerge"
    /// <summary>
    ///   <para>rdfs:label : Copy^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of data that was duplicated. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Copy">cogs:Copy</a>
    /// </summary>
    let Copy = _prefixId.prefix "Copy"
    /// <summary>
    ///   <para>rdfs:label : Cube^^xsd:string</para>
    ///   <para>rdfs:comment : A multidimensional database that holds data. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Cube">cogs:Cube</a>
    /// </summary>
    let Cube = _prefixId.prefix "Cube"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : DSN^^xsd:string</para>
    ///   <para>rdfs:comment : Data Source Name (DSN) is a data structure that contains the information about a specific database. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DSN">cogs:DSN</a>
    /// </summary>
    let DSN = _prefixId.prefix "DSN"
    /// <summary>
    ///   <para>rdfs:label : DataAccessLayer^^xsd:string</para>
    ///   <para>rdfs:comment : Layer that controls access to data in a computer-based information system. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DataAccessLayer">cogs:DataAccessLayer</a>
    /// </summary>
    let DataAccessLayer = _prefixId.prefix "DataAccessLayer"
    /// <summary>
    ///   <para>rdfs:label : DataManagementLayer^^xsd:string</para>
    ///   <para>rdfs:comment : Layer responsible for the development, execution and supervision of plans, policies, programs and practices that control, protect, deliver and enhance the value of data and information assets. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DataManagementLayer">cogs:DataManagementLayer</a>
    /// </summary>
    let DataManagementLayer = _prefixId.prefix "DataManagementLayer"
    /// <summary>
    ///   <para>rdfs:label : DataMart^^xsd:string</para>
    ///   <para>rdfs:comment : Data mart is a process-oriented subset of the overall organization’s data based on a foundation of atomic data, and that depends only on the structure of the data-measurement events, not on the anticipated user’s questions.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DataMart">cogs:DataMart</a>
    /// </summary>
    let DataMart = _prefixId.prefix "DataMart"
    /// <summary>
    ///   <para>rdfs:label : DataStream^^xsd:string</para>
    ///   <para>rdfs:comment : A sequence of digitally encoded coherent signals (packets of data) used to transmit or receive information that is in the process of being transmitted. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DataStream">cogs:DataStream</a>
    /// </summary>
    let DataStream = _prefixId.prefix "DataStream"
    /// <summary>
    ///   <para>rdfs:label : Database^^xsd:string</para>
    ///   <para>rdfs:comment : A database is a collection of information organized into interrelated tables of data and specifications of data objects. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Database">cogs:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : DatetimeConversion^^xsd:string</para>
    ///   <para>rdfs:comment : Conversion from a datetime format to a different one.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DatetimeConversion">cogs:DatetimeConversion</a>
    /// </summary>
    let DatetimeConversion = _prefixId.prefix "DatetimeConversion"
    /// <summary>
    ///   <para>rdfs:label : Deduplication^^xsd:string</para>
    ///   <para>rdfs:comment : Elimination of redundant data. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Deduplication">cogs:Deduplication</a>
    /// </summary>
    let Deduplication = _prefixId.prefix "Deduplication"
    /// <summary>
    ///   <para>rdfs:label : DeleteColumn^^xsd:string</para>
    ///   <para>rdfs:comment : Deletes one or more columns according to a certain criteria to a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DeleteColumn">cogs:DeleteColumn</a>
    /// </summary>
    let DeleteColumn = _prefixId.prefix "DeleteColumn"
    /// <summary>
    ///   <para>rdfs:label : DeleteQuery^^xsd:string</para>
    ///   <para>rdfs:comment : Query that does a delete operation on a row, column, table for example. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DeleteQueryObject">cogs:DeleteQueryObject</a>
    /// </summary>
    let DeleteQueryObject = _prefixId.prefix "DeleteQueryObject"
    /// <summary>
    ///   <para>rdfs:label : DeleteRow^^xsd:string</para>
    ///   <para>rdfs:comment : Exclusion of a single or group of rows by a certain criteria on a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DeleteRow">cogs:DeleteRow</a>
    /// </summary>
    let DeleteRow = _prefixId.prefix "DeleteRow"
    /// <summary>
    ///   <para>rdfs:label : DeleteTriple^^xsd:string</para>
    ///   <para>rdfs:comment : Deletes on or more triples into the store.@en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DeleteTriple">cogs:DeleteTriple</a>
    /// </summary>
    let DeleteTriple = _prefixId.prefix "DeleteTriple"
    /// <summary>
    ///   <para>rdfs:label : DestructiveMerge^^xsd:string</para>
    ///   <para>rdfs:comment : Inputs the incoming data to the target data if the primary key of an incoming record matches with the key of an existing record, updating the matching target record. If the incoming record is a new record without a match with any existing record, it adds the incoming record to the target table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DestructiveMerge">cogs:DestructiveMerge</a>
    /// </summary>
    let DestructiveMerge = _prefixId.prefix "DestructiveMerge"
    /// <summary>
    ///   <para>rdfs:label : Device^^xsd:string</para>
    ///   <para>rdfs:comment : A machine designed for a purpose. E.g.: Unit of hardware.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Device">cogs:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : DimensionTable^^xsd:string</para>
    ///   <para>rdfs:comment : One of the set of companion tables to a fact table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#DimensionTable">cogs:DimensionTable</a>
    /// </summary>
    let DimensionTable = _prefixId.prefix "DimensionTable"
    /// <summary>
    ///   <para>rdfs:label : Endpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Database access point as a web service (SPARQL Endpoint) . @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Endpoint">cogs:Endpoint</a>
    /// </summary>
    let Endpoint = _prefixId.prefix "Endpoint"
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <para>rdfs:comment : An action that is usually initiated outside the scope of a program and that is handled by a piece of code inside the program. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Event">cogs:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Exception^^xsd:string</para>
    ///   <para>rdfs:comment : An event, which occurs during the execution of a program, which disrupts the normal flow of the program's instructions. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Exception">cogs:Exception</a>
    /// </summary>
    let Exception = _prefixId.prefix "Exception"
    /// <summary>
    ///   <para>rdfs:label : Execution^^xsd:string</para>
    ///   <para>rdfs:comment : The instantiation of an activity or workflow. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Execution">cogs:Execution</a>
    /// </summary>
    let Execution = _prefixId.prefix "Execution"
    /// <summary>
    ///   <para>rdfs:label : ExecutionStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Provides the current execution status of a running process instance (a job). e.g. : fail, running, success. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ExecutionStatus">cogs:ExecutionStatus</a>
    /// </summary>
    let ExecutionStatus = _prefixId.prefix "ExecutionStatus"
    /// <summary>
    ///   <para>rdfs:label : Extraction^^xsd:string</para>
    ///   <para>rdfs:comment : The first part of an ETL process which involves extracting the data from source systems. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Extraction">cogs:Extraction</a>
    /// </summary>
    let Extraction = _prefixId.prefix "Extraction"
    /// <summary>
    ///   <para>rdfs:label : FactTable^^xsd:string</para>
    ///   <para>rdfs:comment : A table that consists of the measurements, metrics or facts of a  process. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FactTable">cogs:FactTable</a>
    /// </summary>
    let FactTable = _prefixId.prefix "FactTable"
    /// <summary>
    ///   <para>rdfs:label : Fail^^xsd:string</para>
    ///   <para>rdfs:comment : Status of a job that stops operating or functioning. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Fail">cogs:Fail</a>
    /// </summary>
    let Fail = _prefixId.prefix "Fail"
    /// <summary>
    ///   <para>rdfs:label : FieldDecoding^^xsd:string</para>
    ///   <para>rdfs:comment : Performs decoding operations when you specify field-encoding function. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FieldDecoding">cogs:FieldDecoding</a>
    /// </summary>
    let FieldDecoding = _prefixId.prefix "FieldDecoding"
    /// <summary>
    ///   <para>rdfs:label : File^^xsd:string</para>
    ///   <para>rdfs:comment : A block of arbitrary information, or resource for storing information, which is available to a computer program. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#File">cogs:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>rdfs:label : FileLookup^^xsd:string</para>
    ///   <para>rdfs:comment : The process of looking up for information on a file. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FileLookup">cogs:FileLookup</a>
    /// </summary>
    let FileLookup = _prefixId.prefix "FileLookup"
    /// <summary>
    ///   <para>rdfs:label : FillDown^^xsd:string</para>
    ///   <para>rdfs:comment : Copy the contents of the topmost cells of a selected range into the cells below.@en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FillDown">cogs:FillDown</a>
    /// </summary>
    let FillDown = _prefixId.prefix "FillDown"
    /// <summary>
    ///   <para>rdfs:label : Filter^^xsd:string</para>
    ///   <para>rdfs:comment : An operation that can be used to retain rows in a mapping that do not meet specific conditions. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Filter">cogs:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:label : FormatRevision^^xsd:string</para>
    ///   <para>rdfs:comment : Reviews the file format. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FormatRevision">cogs:FormatRevision</a>
    /// </summary>
    let FormatRevision = _prefixId.prefix "FormatRevision"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <para>rdfs:comment : A rule or principle. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Formula">cogs:Formula</a>
    /// </summary>
    let Formula = _prefixId.prefix "Formula"
    /// <summary>
    ///   <para>rdfs:label : FullRefresh^^xsd:string</para>
    ///   <para>rdfs:comment : Truncates all the tables and data gets loaded again. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#FullRefresh">cogs:FullRefresh</a>
    /// </summary>
    let FullRefresh = _prefixId.prefix "FullRefresh"
    /// <summary>
    ///   <para>rdfs:label : GraphOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Instructions performed on graphs. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#GraphOperation">cogs:GraphOperation</a>
    /// </summary>
    let GraphOperation = _prefixId.prefix "GraphOperation"
    /// <summary>
    ///   <para>rdfs:label : HumanMatching^^xsd:string</para>
    ///   <para>rdfs:comment : Matching based on a human decision.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#HumanMatching">cogs:HumanMatching</a>
    /// </summary>
    let HumanMatching = _prefixId.prefix "HumanMatching"
    /// <summary>
    ///   <para>rdfs:label : HumanValidation^^xsd:string</para>
    ///   <para>rdfs:comment : Validation performed by a person:  an user or admin. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#HumanValidation">cogs:HumanValidation</a>
    /// </summary>
    let HumanValidation = _prefixId.prefix "HumanValidation"
    /// <summary>
    ///   <para>rdfs:label : IncrementalLoad^^xsd:string</para>
    ///   <para>rdfs:comment : Applies ongoing changes to one or more tables based on a predefined schedule. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#IncrementalLoad">cogs:IncrementalLoad</a>
    /// </summary>
    let IncrementalLoad = _prefixId.prefix "IncrementalLoad"
    /// <summary>
    ///   <para>rdfs:label : InitialLoad^^xsd:string</para>
    ///   <para>rdfs:comment : Populates the tables in the data warehouse schema and verifies if the data is ready for use. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#InitialLoad">cogs:InitialLoad</a>
    /// </summary>
    let InitialLoad = _prefixId.prefix "InitialLoad"
    /// <summary>
    ///   <para>rdfs:label : Input^^xsd:string</para>
    ///   <para>rdfs:comment : Any data entered into a computer.@en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Input">cogs:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>rdfs:label : InsertColumn^^xsd:string</para>
    ///   <para>rdfs:comment : Inserts one or more columns according to a certain criteria to a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#InsertColumn">cogs:InsertColumn</a>
    /// </summary>
    let InsertColumn = _prefixId.prefix "InsertColumn"
    /// <summary>
    ///   <para>rdfs:label : InsertQuery^^xsd:string</para>
    ///   <para>rdfs:comment : Query that inserts data into the database. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#InsertQueryObject">cogs:InsertQueryObject</a>
    /// </summary>
    let InsertQueryObject = _prefixId.prefix "InsertQueryObject"
    /// <summary>
    ///   <para>rdfs:label : InsertRow^^xsd:string</para>
    ///   <para>rdfs:comment : Inclusion of a row on a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#InsertRow">cogs:InsertRow</a>
    /// </summary>
    let InsertRow = _prefixId.prefix "InsertRow"
    /// <summary>
    ///   <para>rdfs:label : InsertTriple^^xsd:string</para>
    ///   <para>rdfs:comment : Includes one or more triple into the store. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#InsertTriple">cogs:InsertTriple</a>
    /// </summary>
    let InsertTriple = _prefixId.prefix "InsertTriple"
    /// <summary>
    ///   <para>rdfs:label : Job^^xsd:string</para>
    ///   <para>rdfs:comment : The instance of a process or group of processes (workflow).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Job">cogs:Job</a>
    /// </summary>
    let Job = _prefixId.prefix "Job"
    /// <summary>
    ///   <para>rdfs:label : JoinRows^^xsd:string</para>
    ///   <para>rdfs:comment : Row Operation that allows combinations (Cartesian product) of all rows in the input streams.@en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#JoinRows">cogs:JoinRows</a>
    /// </summary>
    let JoinRows = _prefixId.prefix "JoinRows"
    /// <summary>
    ///   <para>rdfs:label : KeyGeneration^^xsd:string</para>
    ///   <para>rdfs:comment : Process of generating keys/indexes for tables. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#KeyGeneration">cogs:KeyGeneration</a>
    /// </summary>
    let KeyGeneration = _prefixId.prefix "KeyGeneration"
    /// <summary>
    ///   <para>rdfs:label : KeyRestructuring^^xsd:string</para>
    ///   <para>rdfs:comment : Transformation of keys with built-in meanings into generic keys. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#KeyRestructuring">cogs:KeyRestructuring</a>
    /// </summary>
    let KeyRestructuring = _prefixId.prefix "KeyRestructuring"
    /// <summary>
    ///   <para>rdfs:label : LastError^^xsd:string</para>
    ///   <para>rdfs:comment : Final error on a execution workflow. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#LastError">cogs:LastError</a>
    /// </summary>
    let LastError = _prefixId.prefix "LastError"
    /// <summary>
    ///   <para>rdfs:label : Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Each individual level. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Layer">cogs:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>rdfs:label : Loading^^xsd:string</para>
    ///   <para>rdfs:comment : Stage that is responsible for loading data into the end target. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Loading">cogs:Loading</a>
    /// </summary>
    let Loading = _prefixId.prefix "Loading"
    /// <summary>
    ///   <para>rdfs:label : Log^^xsd:string</para>
    ///   <para>rdfs:comment : A record of computer activity. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Log">cogs:Log</a>
    /// </summary>
    let Log = _prefixId.prefix "Log"
    /// <summary>
    ///   <para>rdfs:label : Lookup^^xsd:string</para>
    ///   <para>rdfs:comment : A process used to look up data in a relational table, view or dictionary. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Lookup">cogs:Lookup</a>
    /// </summary>
    let Lookup = _prefixId.prefix "Lookup"
    /// <summary>
    ///   <para>rdfs:label : Lowercase^^xsd:string</para>
    ///   <para>rdfs:comment : String operation for converting a string to lowercase.@en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Lowercase">cogs:Lowercase</a>
    /// </summary>
    let Lowercase = _prefixId.prefix "Lowercase"
    /// <summary>
    ///   <para>rdfs:label : ManualAdHocProcess^^xsd:string</para>
    ///   <para>rdfs:comment : A non-recurrent, not-frequent manual process.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ManualAdHocProcess">cogs:ManualAdHocProcess</a>
    /// </summary>
    let ManualAdHocProcess = _prefixId.prefix "ManualAdHocProcess"
    /// <summary>
    ///   <para>rdfs:label : ManuallyStartedJob^^xsd:string</para>
    ///   <para>rdfs:comment : Job that was initialized by an user. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ManuallyStartedJob">cogs:ManuallyStartedJob</a>
    /// </summary>
    let ManuallyStartedJob = _prefixId.prefix "ManuallyStartedJob"
    /// <summary>
    ///   <para>rdfs:label : Mapping^^xsd:string</para>
    ///   <para>rdfs:comment : The definition of a semantic equivalence relationship between source and target objects. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Mapping">cogs:Mapping</a>
    /// </summary>
    let Mapping = _prefixId.prefix "Mapping"
    /// <summary>
    ///   <para>rdfs:label : MappingFile^^xsd:string</para>
    ///   <para>rdfs:comment : The specification of a mapping between source and target fields (e.g. RDB2RDF).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#MappingFile">cogs:MappingFile</a>
    /// </summary>
    let MappingFile = _prefixId.prefix "MappingFile"
    /// <summary>
    ///   <para>rdfs:label : MappingProcess^^xsd:string</para>
    ///   <para>rdfs:comment : The process of mapping information from a source format to a destination format. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#MappingProcess">cogs:MappingProcess</a>
    /// </summary>
    let MappingProcess = _prefixId.prefix "MappingProcess"
    /// <summary>
    ///   <para>rdfs:label : MergeRow^^xsd:string</para>
    ///   <para>rdfs:comment : Row Operation that allows the comparison of two streams of rows. It is often used in situations where the source system of a data warehouse does not contain a date of last update. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#MergeRow">cogs:MergeRow</a>
    /// </summary>
    let MergeRow = _prefixId.prefix "MergeRow"
    /// <summary>
    ///   <para>rdfs:label : Metadata^^xsd:string</para>
    ///   <para>rdfs:comment : Data that describe data and other structures, such as objects, business rules and processes. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Metadata">cogs:Metadata</a>
    /// </summary>
    let Metadata = _prefixId.prefix "Metadata"
    /// <summary>
    ///   <para>rdfs:label : Method^^xsd:string</para>
    ///   <para>rdfs:comment : A subroutine that is exclusively associated with a object. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Method">cogs:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : Move^^xsd:string</para>
    ///   <para>rdfs:comment : To change in position from one point to another. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Move">cogs:Move</a>
    /// </summary>
    let Move = _prefixId.prefix "Move"
    /// <summary>
    ///   <para>rdfs:label : NumericCast^^xsd:string</para>
    ///   <para>rdfs:comment : Converts an expression of one numeric data type to another. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#NumericCast">cogs:NumericCast</a>
    /// </summary>
    let NumericCast = _prefixId.prefix "NumericCast"
    /// <summary>
    ///   <para>rdfs:label : NumericOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Manipulate and manage numeric data. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#NumericOperation">cogs:NumericOperation</a>
    /// </summary>
    let NumericOperation = _prefixId.prefix "NumericOperation"
    /// <summary>
    ///   <para>rdfs:label : ObjectReference^^xsd:string</para>
    ///   <para>rdfs:comment : Value that enables a program to indirectly access a particular object. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ObjectReference">cogs:ObjectReference</a>
    /// </summary>
    let ObjectReference = _prefixId.prefix "ObjectReference"
    /// <summary>
    ///   <para>rdfs:label : ObjectRepresentation^^xsd:string</para>
    ///   <para>rdfs:comment : Internal representation of an object suitable for matching its features. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ObjectRepresentation">cogs:ObjectRepresentation</a>
    /// </summary>
    let ObjectRepresentation = _prefixId.prefix "ObjectRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Operation^^xsd:string</para>
    ///   <para>rdfs:comment : Functional operations that can be done by a computer. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Operation">cogs:Operation</a>
    /// </summary>
    let Operation = _prefixId.prefix "Operation"
    /// <summary>
    ///   <para>rdfs:label : Operator^^xsd:string</para>
    ///   <para>rdfs:comment : A symbol or function representing a mathematical operation. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Operator">cogs:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>rdfs:label : Order^^xsd:string</para>
    ///   <para>rdfs:comment : Application of a specific order to a set of elemetns.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Order">cogs:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>rdfs:label : Output^^xsd:string</para>
    ///   <para>rdfs:comment : Information, resulting from computer processing, that is delivered to a user. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Output">cogs:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>rdfs:label : Parsing^^xsd:string</para>
    ///   <para>rdfs:comment : Process of analyzing text or data, checking for correct syntax and building a representation based on the input tokens. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Parsing">cogs:Parsing</a>
    /// </summary>
    let Parsing = _prefixId.prefix "Parsing"
    /// <summary>
    ///   <para>rdfs:label : Paste^^xsd:string</para>
    ///   <para>rdfs:comment : To copy an object from a buffer  or clipboard to a file. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Paste">cogs:Paste</a>
    /// </summary>
    let Paste = _prefixId.prefix "Paste"
    /// <summary>
    ///   <para>rdfs:label : PerformanceIndicator^^xsd:string</para>
    ///   <para>rdfs:comment : Measures used to evaluate the success of a particular activity. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#PerformanceIndicator">cogs:PerformanceIndicator</a>
    /// </summary>
    let PerformanceIndicator = _prefixId.prefix "PerformanceIndicator"
    /// <summary>
    ///   <para>rdfs:label : PredefinedMatching^^xsd:string</para>
    ///   <para>rdfs:comment : Forces a matching under a certain predefined criteria.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#PredefinedMatching">cogs:PredefinedMatching</a>
    /// </summary>
    let PredefinedMatching = _prefixId.prefix "PredefinedMatching"
    /// <summary>
    ///   <para>rdfs:label : Prefiltering^^xsd:string</para>
    ///   <para>rdfs:comment : Preliminary filtering during the extraction phase.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Prefiltering">cogs:Prefiltering</a>
    /// </summary>
    let Prefiltering = _prefixId.prefix "Prefiltering"
    /// <summary>
    ///   <para>rdfs:label : PresentationArea^^xsd:string</para>
    ///   <para>rdfs:comment : What the user sees. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#PresentationArea">cogs:PresentationArea</a>
    /// </summary>
    let PresentationArea = _prefixId.prefix "PresentationArea"
    /// <summary>
    ///   <para>rdfs:label : Program^^xsd:string</para>
    ///   <para>rdfs:comment : A sequence of instructions written to perform a specified task for a computer. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Program">cogs:Program</a>
    /// </summary>
    let Program = _prefixId.prefix "Program"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : The process of publishing the output of an ETL process. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Publication">cogs:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <para>rdfs:comment : Query over a structured or semi-structured data source.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Query">cogs:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <para>rdfs:comment : A structured object which is used to request information or perform an action in a database. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#QueryObject">cogs:QueryObject</a>
    /// </summary>
    let QueryObject = _prefixId.prefix "QueryObject"
    /// <summary>
    ///   <para>rdfs:label : RDFDataPropertyMapping^^xsd:string</para>
    ///   <para>rdfs:comment : Maps data properties from source to target.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RDFDataPropertyMapping">cogs:RDFDataPropertyMapping</a>
    /// </summary>
    let RDFDataPropertyMapping = _prefixId.prefix "RDFDataPropertyMapping"
    /// <summary>
    ///   <para>rdfs:label : RDFGraph^^xsd:string</para>
    ///   <para>rdfs:comment : A set of RDF triples. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RDFGraph">cogs:RDFGraph</a>
    /// </summary>
    let RDFGraph = _prefixId.prefix "RDFGraph"
    /// <summary>
    ///   <para>rdfs:label : RDFInstanceMapping^^xsd:string</para>
    ///   <para>rdfs:comment : Maps an instance-level element from a source to an instance-level element in a target dataset. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RDFInstanceMapping">cogs:RDFInstanceMapping</a>
    /// </summary>
    let RDFInstanceMapping = _prefixId.prefix "RDFInstanceMapping"
    /// <summary>
    ///   <para>rdfs:label : RDFNamedGraph^^xsd:string</para>
    ///   <para>rdfs:comment : Multiple RDF graphs in a single document/repository and naming them with URIs. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RDFNamedGraph">cogs:RDFNamedGraph</a>
    /// </summary>
    let RDFNamedGraph = _prefixId.prefix "RDFNamedGraph"
    /// <summary>
    ///   <para>rdfs:label : RDFObjectPropertyMapping^^xsd:string</para>
    ///   <para>rdfs:comment : Maps object properties from source to target.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RDFObjectPropertyMapping">cogs:RDFObjectPropertyMapping</a>
    /// </summary>
    let RDFObjectPropertyMapping = _prefixId.prefix "RDFObjectPropertyMapping"
    /// <summary>
    ///   <para>rdfs:label : RESTLookup^^xsd:string</para>
    ///   <para>rdfs:comment : Lookup on a REST service. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RESTLookup">cogs:RESTLookup</a>
    /// </summary>
    let RESTLookup = _prefixId.prefix "RESTLookup"
    /// <summary>
    ///   <para>rdfs:label : RegexFilter^^xsd:string</para>
    ///   <para>rdfs:comment : Filter written in a formal language that can be interpreted by a regular expression processor. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RegexFilter">cogs:RegexFilter</a>
    /// </summary>
    let RegexFilter = _prefixId.prefix "RegexFilter"
    /// <summary>
    ///   <para>rdfs:label : RejectedData^^xsd:string</para>
    ///   <para>rdfs:comment : Data that contain database violations and are forbidden to get inserted into a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RejectedData">cogs:RejectedData</a>
    /// </summary>
    let RejectedData = _prefixId.prefix "RejectedData"
    /// <summary>
    ///   <para>rdfs:label : RenameColumn^^xsd:string</para>
    ///   <para>rdfs:comment : Changes the name of a certain column. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RenameColumn">cogs:RenameColumn</a>
    /// </summary>
    let RenameColumn = _prefixId.prefix "RenameColumn"
    /// <summary>
    ///   <para>rdfs:label : Replace^^xsd:string</para>
    ///   <para>rdfs:comment : String operation for updating the content of a string. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Replace">cogs:Replace</a>
    /// </summary>
    let Replace = _prefixId.prefix "Replace"
    /// <summary>
    ///   <para>rdfs:label : Round^^xsd:string</para>
    ///   <para>rdfs:comment : Round a numeric value to a close number by following a specific rounding criteria. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Round">cogs:Round</a>
    /// </summary>
    let Round = _prefixId.prefix "Round"
    /// <summary>
    ///   <para>rdfs:label : Row^^xsd:string</para>
    ///   <para>rdfs:comment : A serie of objects placed in line. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Row">cogs:Row</a>
    /// </summary>
    let Row = _prefixId.prefix "Row"
    /// <summary>
    ///   <para>rdfs:label : RowOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Instructions executed on rows of a table or file. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RowOperation">cogs:RowOperation</a>
    /// </summary>
    let RowOperation = _prefixId.prefix "RowOperation"
    /// <summary>
    ///   <para>rdfs:label : Rule^^xsd:string</para>
    ///   <para>rdfs:comment : A principle or formula. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Rule">cogs:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:label : RulesBasedMatching^^xsd:string</para>
    ///   <para>rdfs:comment : Matching of data based on a rule or group of rules. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#RulesBasedMatching">cogs:RulesBasedMatching</a>
    /// </summary>
    let RulesBasedMatching = _prefixId.prefix "RulesBasedMatching"
    /// <summary>
    ///   <para>rdfs:label : Running^^xsd:string</para>
    ///   <para>rdfs:comment : Status of a job that is in the state of being operated. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Running">cogs:Running</a>
    /// </summary>
    let Running = _prefixId.prefix "Running"
    /// <summary>
    ///   <para>rdfs:label : ScheduledJob^^xsd:string</para>
    ///   <para>rdfs:comment : Job that owns information on when and how often it has to execute operations. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ScheduledJob">cogs:ScheduledJob</a>
    /// </summary>
    let ScheduledJob = _prefixId.prefix "ScheduledJob"
    /// <summary>
    ///   <para>rdfs:label : Schema^^xsd:string</para>
    ///   <para>rdfs:comment : The structure of a database system described in a formal language supported by the database management system. Describes tables, for example. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Schema">cogs:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:label : Script^^xsd:string</para>
    ///   <para>rdfs:comment : A program or sequence of instructions that is interpreted or carried out by another program rather than by the computer processor. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Script">cogs:Script</a>
    /// </summary>
    let Script = _prefixId.prefix "Script"
    /// <summary>
    ///   <para>rdfs:label : SelectQuery^^xsd:string</para>
    ///   <para>rdfs:comment : Query that locates and displays information requested. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#SelectQueryObject">cogs:SelectQueryObject</a>
    /// </summary>
    let SelectQueryObject = _prefixId.prefix "SelectQueryObject"
    /// <summary>
    ///   <para>rdfs:label : SemanticSimilarity^^xsd:string</para>
    ///   <para>rdfs:comment : Matching by a measure of semantic similarity. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#SemanticSimilarity">cogs:SemanticSimilarity</a>
    /// </summary>
    let SemanticSimilarity = _prefixId.prefix "SemanticSimilarity"
    /// <summary>
    ///   <para>rdfs:label : Sensor^^xsd:string</para>
    ///   <para>rdfs:comment : Device that measures or detects a real-world condition and converts the condition into an analog or digital representation. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Sensor">cogs:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Server^^xsd:string</para>
    ///   <para>rdfs:comment : Software program, or the computer on which that program runs, that provides a specific kind of service to a client software. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Server">cogs:Server</a>
    /// </summary>
    let Server = _prefixId.prefix "Server"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment : Action done by a device or user with the function of giving good by providing usefulness. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Service">cogs:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : SimilarityMatching^^xsd:string</para>
    ///   <para>rdfs:comment : The process of matching two objects by a similarity measure. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#SimilarityMatching">cogs:SimilarityMatching</a>
    /// </summary>
    let SimilarityMatching = _prefixId.prefix "SimilarityMatching"
    /// <summary>
    ///   <para>rdfs:label : SortRow^^xsd:string</para>
    ///   <para>rdfs:comment : Row Operation that sorts rows based on a specified fields and on whether they should be sorted in ascending or descending order. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#SortRow">cogs:SortRow</a>
    /// </summary>
    let SortRow = _prefixId.prefix "SortRow"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>rdfs:comment : A database, application, file or other storage facility from which the data is derived. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Source">cogs:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Split^^xsd:string</para>
    ///   <para>rdfs:comment : String operation that returns a zero-based, one-dimensional array containing a specified number of substrings. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Split">cogs:Split</a>
    /// </summary>
    let Split = _prefixId.prefix "Split"
    /// <summary>
    ///   <para>rdfs:label : SplitColumn^^xsd:string</para>
    ///   <para>rdfs:comment : Divides a column in one or more other columns. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#SplitColumn">cogs:SplitColumn</a>
    /// </summary>
    let SplitColumn = _prefixId.prefix "SplitColumn"
    /// <summary>
    ///   <para>rdfs:label : StaggingArea^^xsd:string</para>
    ///   <para>rdfs:comment : A place where data can be processed before entering the warehouse area. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StaggingArea">cogs:StaggingArea</a>
    /// </summary>
    let StaggingArea = _prefixId.prefix "StaggingArea"
    /// <summary>
    ///   <para>rdfs:label : StagingAreaArtifact^^xsd:string</para>
    ///   <para>rdfs:comment : The final product; what the end users see. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StagingAreaArtifact">cogs:StagingAreaArtifact</a>
    /// </summary>
    let StagingAreaArtifact = _prefixId.prefix "StagingAreaArtifact"
    /// <summary>
    ///   <para>rdfs:label : StoredProcedure^^xsd:string</para>
    ///   <para>rdfs:comment : A transformation used to create unique primary key values or cycle through a sequential range of numbers to replace missing keys. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StoredProcedure">cogs:StoredProcedure</a>
    /// </summary>
    let StoredProcedure = _prefixId.prefix "StoredProcedure"
    /// <summary>
    ///   <para>rdfs:label : StringFilter^^xsd:string</para>
    ///   <para>rdfs:comment : Provides means for matching strings of text, such as particular characters, words, or patterns of characters. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StringFilter">cogs:StringFilter</a>
    /// </summary>
    let StringFilter = _prefixId.prefix "StringFilter"
    /// <summary>
    ///   <para>rdfs:label : StringOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Operations for manipulating strings. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StringOperation">cogs:StringOperation</a>
    /// </summary>
    let StringOperation = _prefixId.prefix "StringOperation"
    /// <summary>
    ///   <para>rdfs:label : StringSimilarity^^xsd:string</para>
    ///   <para>rdfs:comment : Matching based on string similarity measures. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#StringSimilarity">cogs:StringSimilarity</a>
    /// </summary>
    let StringSimilarity = _prefixId.prefix "StringSimilarity"
    /// <summary>
    ///   <para>rdfs:label : Success^^xsd:string</para>
    ///   <para>rdfs:comment : Status of a job that had successful  performance. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Success">cogs:Success</a>
    /// </summary>
    let Success = _prefixId.prefix "Success"
    /// <summary>
    ///   <para>rdfs:label : Table^^xsd:string</para>
    ///   <para>rdfs:comment : A predefined format of rows and columns that define a database entity. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Table">cogs:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : TableLookup^^xsd:string</para>
    ///   <para>rdfs:comment : Process of using a known attribute to search for data on a table. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#TableLookup">cogs:TableLookup</a>
    /// </summary>
    let TableLookup = _prefixId.prefix "TableLookup"
    /// <summary>
    ///   <para>rdfs:label : TerminologicalMapping^^xsd:string</para>
    ///   <para>rdfs:comment : Maps terminological-level (schema-level) entities. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#TerminologicalMapping">cogs:TerminologicalMapping</a>
    /// </summary>
    let TerminologicalMapping = _prefixId.prefix "TerminologicalMapping"
    /// <summary>
    ///   <para>rdfs:label : Transformation^^xsd:string</para>
    ///   <para>rdfs:comment : The process of manipulating data. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Transformation">cogs:Transformation</a>
    /// </summary>
    let Transformation = _prefixId.prefix "Transformation"
    /// <summary>
    ///   <para>rdfs:label : TransformationProcess^^xsd:string</para>
    ///   <para>rdfs:comment : Process that applies a series of rules or functions to the extracted data from the source to derive the data for loading into the end target. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#TransformationProcess">cogs:TransformationProcess</a>
    /// </summary>
    let TransformationProcess = _prefixId.prefix "TransformationProcess"
    /// <summary>
    ///   <para>rdfs:label : Trigger^^xsd:string</para>
    ///   <para>rdfs:comment : A procedural code that is automatically executed in response to certain events on a particular table or view in a database.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Trigger">cogs:Trigger</a>
    /// </summary>
    let Trigger = _prefixId.prefix "Trigger"
    /// <summary>
    ///   <para>rdfs:label : Trim^^xsd:string</para>
    ///   <para>rdfs:comment : String operation for removing leading and trailing whitespace from a string. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Trim">cogs:Trim</a>
    /// </summary>
    let Trim = _prefixId.prefix "Trim"
    /// <summary>
    ///   <para>rdfs:label : UnitConversion^^xsd:string</para>
    ///   <para>rdfs:comment : Conversion on different units of measurement. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#UnitConversion">cogs:UnitConversion</a>
    /// </summary>
    let UnitConversion = _prefixId.prefix "UnitConversion"
    /// <summary>
    ///   <para>rdfs:label : UpdateQuery^^xsd:string</para>
    ///   <para>rdfs:comment : Query that changes the data of one or more records in a table.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#UpdateQueryObject">cogs:UpdateQueryObject</a>
    /// </summary>
    let UpdateQueryObject = _prefixId.prefix "UpdateQueryObject"
    /// <summary>
    ///   <para>rdfs:label : Uppercase^^xsd:string</para>
    ///   <para>rdfs:comment : String operation for converting a string to uppercase. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Uppercase">cogs:Uppercase</a>
    /// </summary>
    let Uppercase = _prefixId.prefix "Uppercase"
    /// <summary>
    ///   <para>rdfs:label : Validation^^xsd:string</para>
    ///   <para>rdfs:comment : The act of validating; finding or testing the truth of something. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#Validation">cogs:Validation</a>
    /// </summary>
    let Validation = _prefixId.prefix "Validation"
    /// <summary>
    ///   <para>rdfs:label : ValueCalculation^^xsd:string</para>
    ///   <para>rdfs:comment : A calculation performed on a specified input value. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ValueCalculation">cogs:ValueCalculation</a>
    /// </summary>
    let ValueCalculation = _prefixId.prefix "ValueCalculation"
    /// <summary>
    ///   <para>rdfs:label : ValueOperation^^xsd:string</para>
    ///   <para>rdfs:comment : Evaluate a selected function for a particular value of x. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#ValueOperation">cogs:ValueOperation</a>
    /// </summary>
    let ValueOperation = _prefixId.prefix "ValueOperation"
    /// <summary>
    ///   <para>rdfs:label : View^^xsd:string</para>
    ///   <para>rdfs:comment : Consists of a stored query accessible as a virtual table composed of the result set of a query. @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#View">cogs:View</a>
    /// </summary>
    let View = _prefixId.prefix "View"
    /// <summary>
    ///   <para>rdfs:label : WebServiceLookup^^xsd:string</para>
    ///   <para>rdfs:comment : Allows the retrieving of data from a web service and uses this during the form filling process.  @en-us^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#WebServiceLookup">cogs:WebServiceLookup</a>
    /// </summary>
    let WebServiceLookup = _prefixId.prefix "WebServiceLookup"
    let andfre = _prefixId.prefix "andfre"
    /// <summary>
    ///   <para>rdfs:label : associatedEndpoint^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#associatedEndpoint">cogs:associatedEndpoint</a>
    /// </summary>
    let associatedEndpoint = _prefixId.prefix "associatedEndpoint"
    /// <summary>
    ///   <para>rdfs:label : associatedGraph^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#associatedGraph">cogs:associatedGraph</a>
    /// </summary>
    let associatedGraph = _prefixId.prefix "associatedGraph"
    let benkam = _prefixId.prefix "benkam"
    /// <summary>
    ///   <para>rdfs:label : dependsOn^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#dependsOn">cogs:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:label : hasEndPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Last process in a transformation workflow.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#hasEndPoint">cogs:hasEndPoint</a>
    /// </summary>
    let hasEndPoint = _prefixId.prefix "hasEndPoint"
    /// <summary>
    ///   <para>rdfs:label : hasStartPoint^^xsd:string</para>
    ///   <para>rdfs:comment : First process in a transformation workflow.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#hasStartPoint">cogs:hasStartPoint</a>
    /// </summary>
    let hasStartPoint = _prefixId.prefix "hasStartPoint"
    /// <summary>
    ///   <para>rdfs:label : isExpressedBy^^xsd:string</para>
    ///   <para>rdfs:comment : This property allows the association between an abstract representation of a Transformation and an encapsulated computational artifact artifact (e.g. code, binary).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#isExpressedBy">cogs:isExpressedBy</a>
    /// </summary>
    let isExpressedBy = _prefixId.prefix "isExpressedBy"
    /// <summary>
    ///   <para>rdfs:label : precededBy^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the ordering among two processes^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/cogs#precededBy">cogs:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    let rdf = _prefixId.prefix "rdf"
    let timleb = _prefixId.prefix "timleb"
    let ttl = _prefixId.prefix "ttl"
