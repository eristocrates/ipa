namespace http.vocab.deri.ie.cogs.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cogs =
    let _namespace_iri = Namespace_Iri cogs |> NamespaceIRI
    /// <summary>
    ///   <para>cogs:AIFB%2FKIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AIFB%2FKIT">http://vocab.deri.ie/cogs#AIFB%2FKIT</seealso>
    let ``AIFB%2FKIT`` = Prefixed_Name(cogs, "AIFB%2FKIT") |> PrefixedName
    /// <summary>
    ///   <para>cogs:AdHocProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Process that seeks a solution designed for a specific problem or task, non-generalizable, and not intended to be able to be adapted to other purposes. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AdHocProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AdHocProcess">http://vocab.deri.ie/cogs#AdHocProcess</seealso>
    let AdHocProcess = Prefixed_Name(cogs, "AdHocProcess") |> PrefixedName
    /// <summary>
    ///   <para>cogs:AggregateRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>" Functions which return a single result row based on groups of rows. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AggregateRows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AggregateRows">http://vocab.deri.ie/cogs#AggregateRows</seealso>
    let AggregateRows = Prefixed_Name(cogs, "AggregateRows") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Append</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"String operation for concatenating lists or arrays. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Append"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Append">http://vocab.deri.ie/cogs#Append</seealso>
    let Append = Prefixed_Name(cogs, "Append") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ApplyFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"New data are computed based on the user-defined formula. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ApplyFormula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ApplyFormula">http://vocab.deri.ie/cogs#ApplyFormula</seealso>
    let ApplyFormula = Prefixed_Name(cogs, "ApplyFormula") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ApplyScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Execution of a script. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ApplyScript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ApplyScript">http://vocab.deri.ie/cogs#ApplyScript</seealso>
    let ApplyScript = Prefixed_Name(cogs, "ApplyScript") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Sets or re-sets the value stored in the storage location(s) denoted by a variable name. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Assignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Assignment">http://vocab.deri.ie/cogs#Assignment</seealso>
    let Assignment = Prefixed_Name(cogs, "Assignment") |> PrefixedName

    /// <summary>
    ///   <para>cogs:AutomatedAdHocProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A non-recurrent, not frequent automated process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AutomatedAdHocProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AutomatedAdHocProcess">http://vocab.deri.ie/cogs#AutomatedAdHocProcess</seealso>
    let AutomatedAdHocProcess =
        Prefixed_Name(cogs, "AutomatedAdHocProcess") |> PrefixedName

    /// <summary>
    ///   <para>cogs:AutomatedMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Task of finding entries that refer to the same entity across different data sources using computer resources. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AutomatedMatching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AutomatedMatching">http://vocab.deri.ie/cogs#AutomatedMatching</seealso>
    let AutomatedMatching = Prefixed_Name(cogs, "AutomatedMatching") |> PrefixedName
    /// <summary>
    ///   <para>cogs:AutomatedValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Validation performed by a computer. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AutomatedValidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#AutomatedValidation">http://vocab.deri.ie/cogs#AutomatedValidation</seealso>
    let AutomatedValidation = Prefixed_Name(cogs, "AutomatedValidation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Ceil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Returns the smallest integer greater than or equal to n. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ceil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Ceil">http://vocab.deri.ie/cogs#Ceil</seealso>
    let Ceil = Prefixed_Name(cogs, "Ceil") |> PrefixedName

    /// <summary>
    ///   <para>cogs:CharacterSetConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Converts strings between different character sets. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterSetConversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#CharacterSetConversion">http://vocab.deri.ie/cogs#CharacterSetConversion</seealso>
    let CharacterSetConversion =
        Prefixed_Name(cogs, "CharacterSetConversion") |> PrefixedName

    /// <summary>
    ///   <para>cogs:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A construct that is used as a blueprint to create instances of the class. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Class">http://vocab.deri.ie/cogs#Class</seealso>
    let Class = Prefixed_Name(cogs, "Class") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Database tables are composed of individual columns corresponding to the attributes of the object. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Column"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Column">http://vocab.deri.ie/cogs#Column</seealso>
    let Column = Prefixed_Name(cogs, "Column") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ColumnOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instructions applied on one or more columns. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ColumnOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ColumnOperation">http://vocab.deri.ie/cogs#ColumnOperation</seealso>
    let ColumnOperation = Prefixed_Name(cogs, "ColumnOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ConstructiveMerge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"If the primary key of an incoming record matches with the key of an existing Record, leaves the existing Record, adds the incoming record and marks the added record as superseding the old record. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConstructiveMerge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ConstructiveMerge">http://vocab.deri.ie/cogs#ConstructiveMerge</seealso>
    let ConstructiveMerge = Prefixed_Name(cogs, "ConstructiveMerge") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A piece of data that was duplicated. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Copy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Copy">http://vocab.deri.ie/cogs#Copy</seealso>
    let Copy = Prefixed_Name(cogs, "Copy") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Cube</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A multidimensional database that holds data. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cube"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Cube">http://vocab.deri.ie/cogs#Cube</seealso>
    let Cube = Prefixed_Name(cogs, "Cube") |> PrefixedName

    /// <summary>
    ///   <para>cogs:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/cogs#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(cogs, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>cogs:DSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Data Source Name (DSN) is a data structure that contains the information about a specific database. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DSN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DSN">http://vocab.deri.ie/cogs#DSN</seealso>
    let DSN = Prefixed_Name(cogs, "DSN") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DataAccessLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Layer that controls access to data in a computer-based information system. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataAccessLayer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DataAccessLayer">http://vocab.deri.ie/cogs#DataAccessLayer</seealso>
    let DataAccessLayer = Prefixed_Name(cogs, "DataAccessLayer") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DataManagementLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Layer responsible for the development, execution and supervision of plans, policies, programs and practices that control, protect, deliver and enhance the value of data and information assets. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataManagementLayer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DataManagementLayer">http://vocab.deri.ie/cogs#DataManagementLayer</seealso>
    let DataManagementLayer = Prefixed_Name(cogs, "DataManagementLayer") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DataMart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Data mart is a process-oriented subset of the overall organization’s data based on a foundation of atomic data, and that depends only on the structure of the data-measurement events, not on the anticipated user’s questions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataMart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DataMart">http://vocab.deri.ie/cogs#DataMart</seealso>
    let DataMart = Prefixed_Name(cogs, "DataMart") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DataStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A sequence of digitally encoded coherent signals (packets of data) used to transmit or receive information that is in the process of being transmitted. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataStream"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DataStream">http://vocab.deri.ie/cogs#DataStream</seealso>
    let DataStream = Prefixed_Name(cogs, "DataStream") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A database is a collection of information organized into interrelated tables of data and specifications of data objects. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Database"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Database">http://vocab.deri.ie/cogs#Database</seealso>
    let Database = Prefixed_Name(cogs, "Database") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DatetimeConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Conversion from a datetime format to a different one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DatetimeConversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DatetimeConversion">http://vocab.deri.ie/cogs#DatetimeConversion</seealso>
    let DatetimeConversion = Prefixed_Name(cogs, "DatetimeConversion") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Deduplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Elimination of redundant data. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deduplication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Deduplication">http://vocab.deri.ie/cogs#Deduplication</seealso>
    let Deduplication = Prefixed_Name(cogs, "Deduplication") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DeleteColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Deletes one or more columns according to a certain criteria to a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeleteColumn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DeleteColumn">http://vocab.deri.ie/cogs#DeleteColumn</seealso>
    let DeleteColumn = Prefixed_Name(cogs, "DeleteColumn") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DeleteQueryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Query that does a delete operation on a row, column, table for example. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeleteQuery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DeleteQueryObject">http://vocab.deri.ie/cogs#DeleteQueryObject</seealso>
    let DeleteQueryObject = Prefixed_Name(cogs, "DeleteQueryObject") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DeleteRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Exclusion of a single or group of rows by a certain criteria on a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeleteRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DeleteRow">http://vocab.deri.ie/cogs#DeleteRow</seealso>
    let DeleteRow = Prefixed_Name(cogs, "DeleteRow") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DeleteTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Deletes on or more triples into the store.@en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeleteTriple"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DeleteTriple">http://vocab.deri.ie/cogs#DeleteTriple</seealso>
    let DeleteTriple = Prefixed_Name(cogs, "DeleteTriple") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DestructiveMerge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Inputs the incoming data to the target data if the primary key of an incoming record matches with the key of an existing record, updating the matching target record. If the incoming record is a new record without a match with any existing record, it adds the incoming record to the target table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DestructiveMerge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DestructiveMerge">http://vocab.deri.ie/cogs#DestructiveMerge</seealso>
    let DestructiveMerge = Prefixed_Name(cogs, "DestructiveMerge") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A machine designed for a purpose. E.g.: Unit of hardware.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Device">http://vocab.deri.ie/cogs#Device</seealso>
    let Device = Prefixed_Name(cogs, "Device") |> PrefixedName
    /// <summary>
    ///   <para>cogs:DimensionTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"One of the set of companion tables to a fact table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DimensionTable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#DimensionTable">http://vocab.deri.ie/cogs#DimensionTable</seealso>
    let DimensionTable = Prefixed_Name(cogs, "DimensionTable") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Database access point as a web service (SPARQL Endpoint) . @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Endpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Endpoint">http://vocab.deri.ie/cogs#Endpoint</seealso>
    let Endpoint = Prefixed_Name(cogs, "Endpoint") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An action that is usually initiated outside the scope of a program and that is handled by a piece of code inside the program. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Event">http://vocab.deri.ie/cogs#Event</seealso>
    let Event = Prefixed_Name(cogs, "Event") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Exception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An event, which occurs during the execution of a program, which disrupts the normal flow of the program's instructions. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Exception">http://vocab.deri.ie/cogs#Exception</seealso>
    let Exception = Prefixed_Name(cogs, "Exception") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The instantiation of an activity or workflow. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Execution">http://vocab.deri.ie/cogs#Execution</seealso>
    let Execution = Prefixed_Name(cogs, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ExecutionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provides the current execution status of a running process instance (a job). e.g. : fail, running, success. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExecutionStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ExecutionStatus">http://vocab.deri.ie/cogs#ExecutionStatus</seealso>
    let ExecutionStatus = Prefixed_Name(cogs, "ExecutionStatus") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The first part of an ETL process which involves extracting the data from source systems. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Extraction">http://vocab.deri.ie/cogs#Extraction</seealso>
    let Extraction = Prefixed_Name(cogs, "Extraction") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FactTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A table that consists of the measurements, metrics or facts of a  process. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FactTable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FactTable">http://vocab.deri.ie/cogs#FactTable</seealso>
    let FactTable = Prefixed_Name(cogs, "FactTable") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Fail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Status of a job that stops operating or functioning. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Fail">http://vocab.deri.ie/cogs#Fail</seealso>
    let Fail = Prefixed_Name(cogs, "Fail") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FieldDecoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Performs decoding operations when you specify field-encoding function. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FieldDecoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FieldDecoding">http://vocab.deri.ie/cogs#FieldDecoding</seealso>
    let FieldDecoding = Prefixed_Name(cogs, "FieldDecoding") |> PrefixedName
    /// <summary>
    ///   <para>cogs:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A block of arbitrary information, or resource for storing information, which is available to a computer program. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"File"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#File">http://vocab.deri.ie/cogs#File</seealso>
    let File = Prefixed_Name(cogs, "File") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FileLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The process of looking up for information on a file. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FileLookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FileLookup">http://vocab.deri.ie/cogs#FileLookup</seealso>
    let FileLookup = Prefixed_Name(cogs, "FileLookup") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FillDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Copy the contents of the topmost cells of a selected range into the cells below.@en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FillDown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FillDown">http://vocab.deri.ie/cogs#FillDown</seealso>
    let FillDown = Prefixed_Name(cogs, "FillDown") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An operation that can be used to retain rows in a mapping that do not meet specific conditions. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Filter">http://vocab.deri.ie/cogs#Filter</seealso>
    let Filter = Prefixed_Name(cogs, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FormatRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Reviews the file format. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FormatRevision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FormatRevision">http://vocab.deri.ie/cogs#FormatRevision</seealso>
    let FormatRevision = Prefixed_Name(cogs, "FormatRevision") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A rule or principle. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Formula">http://vocab.deri.ie/cogs#Formula</seealso>
    let Formula = Prefixed_Name(cogs, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>cogs:FullRefresh</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Truncates all the tables and data gets loaded again. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FullRefresh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#FullRefresh">http://vocab.deri.ie/cogs#FullRefresh</seealso>
    let FullRefresh = Prefixed_Name(cogs, "FullRefresh") |> PrefixedName
    /// <summary>
    ///   <para>cogs:GraphOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instructions performed on graphs. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#GraphOperation">http://vocab.deri.ie/cogs#GraphOperation</seealso>
    let GraphOperation = Prefixed_Name(cogs, "GraphOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:HumanMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Matching based on a human decision."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HumanMatching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#HumanMatching">http://vocab.deri.ie/cogs#HumanMatching</seealso>
    let HumanMatching = Prefixed_Name(cogs, "HumanMatching") |> PrefixedName
    /// <summary>
    ///   <para>cogs:HumanValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Validation performed by a person:  an user or admin. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HumanValidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#HumanValidation">http://vocab.deri.ie/cogs#HumanValidation</seealso>
    let HumanValidation = Prefixed_Name(cogs, "HumanValidation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:IncrementalLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Applies ongoing changes to one or more tables based on a predefined schedule. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IncrementalLoad"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#IncrementalLoad">http://vocab.deri.ie/cogs#IncrementalLoad</seealso>
    let IncrementalLoad = Prefixed_Name(cogs, "IncrementalLoad") |> PrefixedName
    /// <summary>
    ///   <para>cogs:InitialLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Populates the tables in the data warehouse schema and verifies if the data is ready for use. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InitialLoad"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#InitialLoad">http://vocab.deri.ie/cogs#InitialLoad</seealso>
    let InitialLoad = Prefixed_Name(cogs, "InitialLoad") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Any data entered into a computer.@en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Input">http://vocab.deri.ie/cogs#Input</seealso>
    let Input = Prefixed_Name(cogs, "Input") |> PrefixedName
    /// <summary>
    ///   <para>cogs:InsertColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inserts one or more columns according to a certain criteria to a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InsertColumn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#InsertColumn">http://vocab.deri.ie/cogs#InsertColumn</seealso>
    let InsertColumn = Prefixed_Name(cogs, "InsertColumn") |> PrefixedName
    /// <summary>
    ///   <para>cogs:InsertQueryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Query that inserts data into the database. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InsertQuery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#InsertQueryObject">http://vocab.deri.ie/cogs#InsertQueryObject</seealso>
    let InsertQueryObject = Prefixed_Name(cogs, "InsertQueryObject") |> PrefixedName
    /// <summary>
    ///   <para>cogs:InsertRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inclusion of a row on a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InsertRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#InsertRow">http://vocab.deri.ie/cogs#InsertRow</seealso>
    let InsertRow = Prefixed_Name(cogs, "InsertRow") |> PrefixedName
    /// <summary>
    ///   <para>cogs:InsertTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Includes one or more triple into the store. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InsertTriple"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#InsertTriple">http://vocab.deri.ie/cogs#InsertTriple</seealso>
    let InsertTriple = Prefixed_Name(cogs, "InsertTriple") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Job</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The instance of a process or group of processes (workflow)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Job"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Job">http://vocab.deri.ie/cogs#Job</seealso>
    let Job = Prefixed_Name(cogs, "Job") |> PrefixedName
    /// <summary>
    ///   <para>cogs:JoinRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Row Operation that allows combinations (Cartesian product) of all rows in the input streams.@en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JoinRows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#JoinRows">http://vocab.deri.ie/cogs#JoinRows</seealso>
    let JoinRows = Prefixed_Name(cogs, "JoinRows") |> PrefixedName
    /// <summary>
    ///   <para>cogs:KeyGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Process of generating keys/indexes for tables. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KeyGeneration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#KeyGeneration">http://vocab.deri.ie/cogs#KeyGeneration</seealso>
    let KeyGeneration = Prefixed_Name(cogs, "KeyGeneration") |> PrefixedName
    /// <summary>
    ///   <para>cogs:KeyRestructuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Transformation of keys with built-in meanings into generic keys. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KeyRestructuring"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#KeyRestructuring">http://vocab.deri.ie/cogs#KeyRestructuring</seealso>
    let KeyRestructuring = Prefixed_Name(cogs, "KeyRestructuring") |> PrefixedName
    /// <summary>
    ///   <para>cogs:LastError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Final error on a execution workflow. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LastError"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#LastError">http://vocab.deri.ie/cogs#LastError</seealso>
    let LastError = Prefixed_Name(cogs, "LastError") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Each individual level. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Layer">http://vocab.deri.ie/cogs#Layer</seealso>
    let Layer = Prefixed_Name(cogs, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Loading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Stage that is responsible for loading data into the end target. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Loading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Loading">http://vocab.deri.ie/cogs#Loading</seealso>
    let Loading = Prefixed_Name(cogs, "Loading") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Log</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A record of computer activity. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Log"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Log">http://vocab.deri.ie/cogs#Log</seealso>
    let Log = Prefixed_Name(cogs, "Log") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Lookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A process used to look up data in a relational table, view or dictionary. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Lookup">http://vocab.deri.ie/cogs#Lookup</seealso>
    let Lookup = Prefixed_Name(cogs, "Lookup") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Lowercase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"String operation for converting a string to lowercase.@en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lowercase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Lowercase">http://vocab.deri.ie/cogs#Lowercase</seealso>
    let Lowercase = Prefixed_Name(cogs, "Lowercase") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ManualAdHocProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A non-recurrent, not-frequent manual process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ManualAdHocProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ManualAdHocProcess">http://vocab.deri.ie/cogs#ManualAdHocProcess</seealso>
    let ManualAdHocProcess = Prefixed_Name(cogs, "ManualAdHocProcess") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ManuallyStartedJob</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Job that was initialized by an user. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ManuallyStartedJob"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ManuallyStartedJob">http://vocab.deri.ie/cogs#ManuallyStartedJob</seealso>
    let ManuallyStartedJob = Prefixed_Name(cogs, "ManuallyStartedJob") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The definition of a semantic equivalence relationship between source and target objects. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Mapping">http://vocab.deri.ie/cogs#Mapping</seealso>
    let Mapping = Prefixed_Name(cogs, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>cogs:MappingFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The specification of a mapping between source and target fields (e.g. RDB2RDF)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MappingFile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#MappingFile">http://vocab.deri.ie/cogs#MappingFile</seealso>
    let MappingFile = Prefixed_Name(cogs, "MappingFile") |> PrefixedName
    /// <summary>
    ///   <para>cogs:MappingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The process of mapping information from a source format to a destination format. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MappingProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#MappingProcess">http://vocab.deri.ie/cogs#MappingProcess</seealso>
    let MappingProcess = Prefixed_Name(cogs, "MappingProcess") |> PrefixedName
    /// <summary>
    ///   <para>cogs:MergeRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Row Operation that allows the comparison of two streams of rows. It is often used in situations where the source system of a data warehouse does not contain a date of last update. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MergeRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#MergeRow">http://vocab.deri.ie/cogs#MergeRow</seealso>
    let MergeRow = Prefixed_Name(cogs, "MergeRow") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Data that describe data and other structures, such as objects, business rules and processes. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Metadata">http://vocab.deri.ie/cogs#Metadata</seealso>
    let Metadata = Prefixed_Name(cogs, "Metadata") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A subroutine that is exclusively associated with a object. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Method">http://vocab.deri.ie/cogs#Method</seealso>
    let Method = Prefixed_Name(cogs, "Method") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Move</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"To change in position from one point to another. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Move"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Move">http://vocab.deri.ie/cogs#Move</seealso>
    let Move = Prefixed_Name(cogs, "Move") |> PrefixedName
    /// <summary>
    ///   <para>cogs:NumericCast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Converts an expression of one numeric data type to another. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NumericCast"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#NumericCast">http://vocab.deri.ie/cogs#NumericCast</seealso>
    let NumericCast = Prefixed_Name(cogs, "NumericCast") |> PrefixedName
    /// <summary>
    ///   <para>cogs:NumericOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Manipulate and manage numeric data. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NumericOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#NumericOperation">http://vocab.deri.ie/cogs#NumericOperation</seealso>
    let NumericOperation = Prefixed_Name(cogs, "NumericOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ObjectReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Value that enables a program to indirectly access a particular object. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ObjectReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ObjectReference">http://vocab.deri.ie/cogs#ObjectReference</seealso>
    let ObjectReference = Prefixed_Name(cogs, "ObjectReference") |> PrefixedName

    /// <summary>
    ///   <para>cogs:ObjectRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Internal representation of an object suitable for matching its features. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ObjectRepresentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ObjectRepresentation">http://vocab.deri.ie/cogs#ObjectRepresentation</seealso>
    let ObjectRepresentation =
        Prefixed_Name(cogs, "ObjectRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>cogs:Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Functional operations that can be done by a computer. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Operation">http://vocab.deri.ie/cogs#Operation</seealso>
    let Operation = Prefixed_Name(cogs, "Operation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A symbol or function representing a mathematical operation. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Operator">http://vocab.deri.ie/cogs#Operator</seealso>
    let Operator = Prefixed_Name(cogs, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Application of a specific order to a set of elemetns.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Order">http://vocab.deri.ie/cogs#Order</seealso>
    let Order = Prefixed_Name(cogs, "Order") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Information, resulting from computer processing, that is delivered to a user. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Output">http://vocab.deri.ie/cogs#Output</seealso>
    let Output = Prefixed_Name(cogs, "Output") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Parsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Process of analyzing text or data, checking for correct syntax and building a representation based on the input tokens. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parsing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Parsing">http://vocab.deri.ie/cogs#Parsing</seealso>
    let Parsing = Prefixed_Name(cogs, "Parsing") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Paste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"To copy an object from a buffer  or clipboard to a file. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paste"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Paste">http://vocab.deri.ie/cogs#Paste</seealso>
    let Paste = Prefixed_Name(cogs, "Paste") |> PrefixedName

    /// <summary>
    ///   <para>cogs:PerformanceIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Measures used to evaluate the success of a particular activity. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PerformanceIndicator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#PerformanceIndicator">http://vocab.deri.ie/cogs#PerformanceIndicator</seealso>
    let PerformanceIndicator =
        Prefixed_Name(cogs, "PerformanceIndicator") |> PrefixedName

    /// <summary>
    ///   <para>cogs:PredefinedMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Forces a matching under a certain predefined criteria.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PredefinedMatching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#PredefinedMatching">http://vocab.deri.ie/cogs#PredefinedMatching</seealso>
    let PredefinedMatching = Prefixed_Name(cogs, "PredefinedMatching") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Prefiltering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Preliminary filtering during the extraction phase."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prefiltering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Prefiltering">http://vocab.deri.ie/cogs#Prefiltering</seealso>
    let Prefiltering = Prefixed_Name(cogs, "Prefiltering") |> PrefixedName
    /// <summary>
    ///   <para>cogs:PresentationArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"What the user sees. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PresentationArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#PresentationArea">http://vocab.deri.ie/cogs#PresentationArea</seealso>
    let PresentationArea = Prefixed_Name(cogs, "PresentationArea") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A sequence of instructions written to perform a specified task for a computer. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Program">http://vocab.deri.ie/cogs#Program</seealso>
    let Program = Prefixed_Name(cogs, "Program") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The process of publishing the output of an ETL process. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Publication">http://vocab.deri.ie/cogs#Publication</seealso>
    let Publication = Prefixed_Name(cogs, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Query over a structured or semi-structured data source."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Query">http://vocab.deri.ie/cogs#Query</seealso>
    let Query = Prefixed_Name(cogs, "Query") |> PrefixedName
    /// <summary>
    ///   <para>cogs:QueryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A structured object which is used to request information or perform an action in a database. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#QueryObject">http://vocab.deri.ie/cogs#QueryObject</seealso>
    let QueryObject = Prefixed_Name(cogs, "QueryObject") |> PrefixedName

    /// <summary>
    ///   <para>cogs:RDFDataPropertyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Maps data properties from source to target."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RDFDataPropertyMapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RDFDataPropertyMapping">http://vocab.deri.ie/cogs#RDFDataPropertyMapping</seealso>
    let RDFDataPropertyMapping =
        Prefixed_Name(cogs, "RDFDataPropertyMapping") |> PrefixedName

    /// <summary>
    ///   <para>cogs:RDFGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A set of RDF triples. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RDFGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RDFGraph">http://vocab.deri.ie/cogs#RDFGraph</seealso>
    let RDFGraph = Prefixed_Name(cogs, "RDFGraph") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RDFInstanceMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maps an instance-level element from a source to an instance-level element in a target dataset. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RDFInstanceMapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RDFInstanceMapping">http://vocab.deri.ie/cogs#RDFInstanceMapping</seealso>
    let RDFInstanceMapping = Prefixed_Name(cogs, "RDFInstanceMapping") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RDFNamedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Multiple RDF graphs in a single document/repository and naming them with URIs. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RDFNamedGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RDFNamedGraph">http://vocab.deri.ie/cogs#RDFNamedGraph</seealso>
    let RDFNamedGraph = Prefixed_Name(cogs, "RDFNamedGraph") |> PrefixedName

    /// <summary>
    ///   <para>cogs:RDFObjectPropertyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maps object properties from source to target."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RDFObjectPropertyMapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RDFObjectPropertyMapping">http://vocab.deri.ie/cogs#RDFObjectPropertyMapping</seealso>
    let RDFObjectPropertyMapping =
        Prefixed_Name(cogs, "RDFObjectPropertyMapping") |> PrefixedName

    /// <summary>
    ///   <para>cogs:RESTLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Lookup on a REST service. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RESTLookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RESTLookup">http://vocab.deri.ie/cogs#RESTLookup</seealso>
    let RESTLookup = Prefixed_Name(cogs, "RESTLookup") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RegexFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Filter written in a formal language that can be interpreted by a regular expression processor. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RegexFilter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RegexFilter">http://vocab.deri.ie/cogs#RegexFilter</seealso>
    let RegexFilter = Prefixed_Name(cogs, "RegexFilter") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RejectedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Data that contain database violations and are forbidden to get inserted into a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RejectedData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RejectedData">http://vocab.deri.ie/cogs#RejectedData</seealso>
    let RejectedData = Prefixed_Name(cogs, "RejectedData") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RenameColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Changes the name of a certain column. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RenameColumn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RenameColumn">http://vocab.deri.ie/cogs#RenameColumn</seealso>
    let RenameColumn = Prefixed_Name(cogs, "RenameColumn") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Replace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"String operation for updating the content of a string. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Replace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Replace">http://vocab.deri.ie/cogs#Replace</seealso>
    let Replace = Prefixed_Name(cogs, "Replace") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Round</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Round a numeric value to a close number by following a specific rounding criteria. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Round"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Round">http://vocab.deri.ie/cogs#Round</seealso>
    let Round = Prefixed_Name(cogs, "Round") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Row</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A serie of objects placed in line. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Row"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Row">http://vocab.deri.ie/cogs#Row</seealso>
    let Row = Prefixed_Name(cogs, "Row") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RowOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instructions executed on rows of a table or file. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RowOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RowOperation">http://vocab.deri.ie/cogs#RowOperation</seealso>
    let RowOperation = Prefixed_Name(cogs, "RowOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A principle or formula. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Rule">http://vocab.deri.ie/cogs#Rule</seealso>
    let Rule = Prefixed_Name(cogs, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>cogs:RulesBasedMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Matching of data based on a rule or group of rules. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RulesBasedMatching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#RulesBasedMatching">http://vocab.deri.ie/cogs#RulesBasedMatching</seealso>
    let RulesBasedMatching = Prefixed_Name(cogs, "RulesBasedMatching") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Running</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Status of a job that is in the state of being operated. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Running"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Running">http://vocab.deri.ie/cogs#Running</seealso>
    let Running = Prefixed_Name(cogs, "Running") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ScheduledJob</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Job that owns information on when and how often it has to execute operations. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScheduledJob"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ScheduledJob">http://vocab.deri.ie/cogs#ScheduledJob</seealso>
    let ScheduledJob = Prefixed_Name(cogs, "ScheduledJob") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The structure of a database system described in a formal language supported by the database management system. Describes tables, for example. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Schema">http://vocab.deri.ie/cogs#Schema</seealso>
    let Schema = Prefixed_Name(cogs, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Script</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A program or sequence of instructions that is interpreted or carried out by another program rather than by the computer processor. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Script"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Script">http://vocab.deri.ie/cogs#Script</seealso>
    let Script = Prefixed_Name(cogs, "Script") |> PrefixedName
    /// <summary>
    ///   <para>cogs:SelectQueryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Query that locates and displays information requested. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SelectQuery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#SelectQueryObject">http://vocab.deri.ie/cogs#SelectQueryObject</seealso>
    let SelectQueryObject = Prefixed_Name(cogs, "SelectQueryObject") |> PrefixedName
    /// <summary>
    ///   <para>cogs:SemanticSimilarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Matching by a measure of semantic similarity. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SemanticSimilarity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#SemanticSimilarity">http://vocab.deri.ie/cogs#SemanticSimilarity</seealso>
    let SemanticSimilarity = Prefixed_Name(cogs, "SemanticSimilarity") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Device that measures or detects a real-world condition and converts the condition into an analog or digital representation. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Sensor">http://vocab.deri.ie/cogs#Sensor</seealso>
    let Sensor = Prefixed_Name(cogs, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Server</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Software program, or the computer on which that program runs, that provides a specific kind of service to a client software. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Server">http://vocab.deri.ie/cogs#Server</seealso>
    let Server = Prefixed_Name(cogs, "Server") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Action done by a device or user with the function of giving good by providing usefulness. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Service">http://vocab.deri.ie/cogs#Service</seealso>
    let Service = Prefixed_Name(cogs, "Service") |> PrefixedName
    /// <summary>
    ///   <para>cogs:SimilarityMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The process of matching two objects by a similarity measure. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SimilarityMatching"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#SimilarityMatching">http://vocab.deri.ie/cogs#SimilarityMatching</seealso>
    let SimilarityMatching = Prefixed_Name(cogs, "SimilarityMatching") |> PrefixedName
    /// <summary>
    ///   <para>cogs:SortRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Row Operation that sorts rows based on a specified fields and on whether they should be sorted in ascending or descending order. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SortRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#SortRow">http://vocab.deri.ie/cogs#SortRow</seealso>
    let SortRow = Prefixed_Name(cogs, "SortRow") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A database, application, file or other storage facility from which the data is derived. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Source">http://vocab.deri.ie/cogs#Source</seealso>
    let Source = Prefixed_Name(cogs, "Source") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"String operation that returns a zero-based, one-dimensional array containing a specified number of substrings. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Split"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Split">http://vocab.deri.ie/cogs#Split</seealso>
    let Split = Prefixed_Name(cogs, "Split") |> PrefixedName
    /// <summary>
    ///   <para>cogs:SplitColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Divides a column in one or more other columns. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SplitColumn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#SplitColumn">http://vocab.deri.ie/cogs#SplitColumn</seealso>
    let SplitColumn = Prefixed_Name(cogs, "SplitColumn") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StaggingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A place where data can be processed before entering the warehouse area. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StaggingArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StaggingArea">http://vocab.deri.ie/cogs#StaggingArea</seealso>
    let StaggingArea = Prefixed_Name(cogs, "StaggingArea") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StagingAreaArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The final product; what the end users see. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StagingAreaArtifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StagingAreaArtifact">http://vocab.deri.ie/cogs#StagingAreaArtifact</seealso>
    let StagingAreaArtifact = Prefixed_Name(cogs, "StagingAreaArtifact") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StoredProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A transformation used to create unique primary key values or cycle through a sequential range of numbers to replace missing keys. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StoredProcedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StoredProcedure">http://vocab.deri.ie/cogs#StoredProcedure</seealso>
    let StoredProcedure = Prefixed_Name(cogs, "StoredProcedure") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StringFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Provides means for matching strings of text, such as particular characters, words, or patterns of characters. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StringFilter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StringFilter">http://vocab.deri.ie/cogs#StringFilter</seealso>
    let StringFilter = Prefixed_Name(cogs, "StringFilter") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StringOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Operations for manipulating strings. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StringOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StringOperation">http://vocab.deri.ie/cogs#StringOperation</seealso>
    let StringOperation = Prefixed_Name(cogs, "StringOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:StringSimilarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Matching based on string similarity measures. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StringSimilarity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#StringSimilarity">http://vocab.deri.ie/cogs#StringSimilarity</seealso>
    let StringSimilarity = Prefixed_Name(cogs, "StringSimilarity") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Success</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Status of a job that had successful  performance. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Success"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Success">http://vocab.deri.ie/cogs#Success</seealso>
    let Success = Prefixed_Name(cogs, "Success") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A predefined format of rows and columns that define a database entity. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Table"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Table">http://vocab.deri.ie/cogs#Table</seealso>
    let Table = Prefixed_Name(cogs, "Table") |> PrefixedName
    /// <summary>
    ///   <para>cogs:TableLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Process of using a known attribute to search for data on a table. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TableLookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#TableLookup">http://vocab.deri.ie/cogs#TableLookup</seealso>
    let TableLookup = Prefixed_Name(cogs, "TableLookup") |> PrefixedName

    /// <summary>
    ///   <para>cogs:TerminologicalMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Maps terminological-level (schema-level) entities. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TerminologicalMapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#TerminologicalMapping">http://vocab.deri.ie/cogs#TerminologicalMapping</seealso>
    let TerminologicalMapping =
        Prefixed_Name(cogs, "TerminologicalMapping") |> PrefixedName

    /// <summary>
    ///   <para>cogs:Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The process of manipulating data. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Transformation">http://vocab.deri.ie/cogs#Transformation</seealso>
    let Transformation = Prefixed_Name(cogs, "Transformation") |> PrefixedName

    /// <summary>
    ///   <para>cogs:TransformationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Process that applies a series of rules or functions to the extracted data from the source to derive the data for loading into the end target. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransformationProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#TransformationProcess">http://vocab.deri.ie/cogs#TransformationProcess</seealso>
    let TransformationProcess =
        Prefixed_Name(cogs, "TransformationProcess") |> PrefixedName

    /// <summary>
    ///   <para>cogs:Trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A procedural code that is automatically executed in response to certain events on a particular table or view in a database.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trigger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Trigger">http://vocab.deri.ie/cogs#Trigger</seealso>
    let Trigger = Prefixed_Name(cogs, "Trigger") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Trim</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"String operation for removing leading and trailing whitespace from a string. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Trim"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Trim">http://vocab.deri.ie/cogs#Trim</seealso>
    let Trim = Prefixed_Name(cogs, "Trim") |> PrefixedName
    /// <summary>
    ///   <para>cogs:UnitConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Conversion on different units of measurement. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UnitConversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#UnitConversion">http://vocab.deri.ie/cogs#UnitConversion</seealso>
    let UnitConversion = Prefixed_Name(cogs, "UnitConversion") |> PrefixedName
    /// <summary>
    ///   <para>cogs:UpdateQueryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Query that changes the data of one or more records in a table.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UpdateQuery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#UpdateQueryObject">http://vocab.deri.ie/cogs#UpdateQueryObject</seealso>
    let UpdateQueryObject = Prefixed_Name(cogs, "UpdateQueryObject") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Uppercase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"String operation for converting a string to uppercase. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Uppercase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Uppercase">http://vocab.deri.ie/cogs#Uppercase</seealso>
    let Uppercase = Prefixed_Name(cogs, "Uppercase") |> PrefixedName
    /// <summary>
    ///   <para>cogs:Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The act of validating; finding or testing the truth of something. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Validation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#Validation">http://vocab.deri.ie/cogs#Validation</seealso>
    let Validation = Prefixed_Name(cogs, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ValueCalculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A calculation performed on a specified input value. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ValueCalculation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ValueCalculation">http://vocab.deri.ie/cogs#ValueCalculation</seealso>
    let ValueCalculation = Prefixed_Name(cogs, "ValueCalculation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ValueOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluate a selected function for a particular value of x. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ValueOperation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ValueOperation">http://vocab.deri.ie/cogs#ValueOperation</seealso>
    let ValueOperation = Prefixed_Name(cogs, "ValueOperation") |> PrefixedName
    /// <summary>
    ///   <para>cogs:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Consists of a stored query accessible as a virtual table composed of the result set of a query. @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"View"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#View">http://vocab.deri.ie/cogs#View</seealso>
    let View = Prefixed_Name(cogs, "View") |> PrefixedName
    /// <summary>
    ///   <para>cogs:WebServiceLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Allows the retrieving of data from a web service and uses this during the form filling process.  @en-us"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WebServiceLookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#WebServiceLookup">http://vocab.deri.ie/cogs#WebServiceLookup</seealso>
    let WebServiceLookup = Prefixed_Name(cogs, "WebServiceLookup") |> PrefixedName
    /// <summary>
    ///   <para>cogs:andfre</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#andfre">http://vocab.deri.ie/cogs#andfre</seealso>
    let andfre = Prefixed_Name(cogs, "andfre") |> PrefixedName
    /// <summary>
    ///   <para>cogs:associatedEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"associatedEndpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#associatedEndpoint">http://vocab.deri.ie/cogs#associatedEndpoint</seealso>
    let associatedEndpoint = Prefixed_Name(cogs, "associatedEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>cogs:associatedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"associatedGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#associatedGraph">http://vocab.deri.ie/cogs#associatedGraph</seealso>
    let associatedGraph = Prefixed_Name(cogs, "associatedGraph") |> PrefixedName
    /// <summary>
    ///   <para>cogs:benkam</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#benkam">http://vocab.deri.ie/cogs#benkam</seealso>
    let benkam = Prefixed_Name(cogs, "benkam") |> PrefixedName
    /// <summary>
    ///   <para>cogs:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dependsOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#dependsOn">http://vocab.deri.ie/cogs#dependsOn</seealso>
    let dependsOn = Prefixed_Name(cogs, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>cogs:hasEndPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Last process in a transformation workflow."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasEndPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#hasEndPoint">http://vocab.deri.ie/cogs#hasEndPoint</seealso>
    let hasEndPoint = Prefixed_Name(cogs, "hasEndPoint") |> PrefixedName
    /// <summary>
    ///   <para>cogs:hasStartPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"First process in a transformation workflow."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasStartPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#hasStartPoint">http://vocab.deri.ie/cogs#hasStartPoint</seealso>
    let hasStartPoint = Prefixed_Name(cogs, "hasStartPoint") |> PrefixedName
    /// <summary>
    ///   <para>cogs:isExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property allows the association between an abstract representation of a Transformation and an encapsulated computational artifact artifact (e.g. code, binary)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isExpressedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#isExpressedBy">http://vocab.deri.ie/cogs#isExpressedBy</seealso>
    let isExpressedBy = Prefixed_Name(cogs, "isExpressedBy") |> PrefixedName
    /// <summary>
    ///   <para>cogs:precededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines the ordering among two processes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"precededBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#precededBy">http://vocab.deri.ie/cogs#precededBy</seealso>
    let precededBy = Prefixed_Name(cogs, "precededBy") |> PrefixedName
    /// <summary>
    ///   <para>cogs:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#rdf">http://vocab.deri.ie/cogs#rdf</seealso>
    let rdf = Prefixed_Name(cogs, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>cogs:timleb</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#timleb">http://vocab.deri.ie/cogs#timleb</seealso>
    let timleb = Prefixed_Name(cogs, "timleb") |> PrefixedName
    /// <summary>
    ///   <para>cogs:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/cogs#ttl">http://vocab.deri.ie/cogs#ttl</seealso>
    let ttl = Prefixed_Name(cogs, "ttl") |> PrefixedName
