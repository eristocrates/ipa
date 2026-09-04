#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rr =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/r2rml#" "rr"
    let _namespaceIri = _prefixId.prefix ""
    let BaseTableOrView = _prefixId.prefix "BaseTableOrView"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a blank node, used with termType</para>
    ///   <a href="http://www.w3.org/ns/r2rml#BlankNode">rr:BlankNode</a>
    /// </summary>
    let BlankNode = _prefixId.prefix "BlankNode"
    /// <summary>
    ///   <para>rdfs:comment : Represents a graph map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#GraphMap">rr:GraphMap</a>
    /// </summary>
    let GraphMap = _prefixId.prefix "GraphMap"
    /// <summary>
    ///   <para>rdfs:comment : Denotes an IRI, used with termpType.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#IRI">rr:IRI</a>
    /// </summary>
    let IRI = _prefixId.prefix "IRI"
    /// <summary>
    ///   <para>rdfs:comment : Represents a join condition.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#Join">rr:Join</a>
    /// </summary>
    let Join = _prefixId.prefix "Join"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a Literal, used with termType.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#Literal">rr:Literal</a>
    /// </summary>
    let Literal = _prefixId.prefix "Literal"
    /// <summary>
    ///   <para>rdfs:comment : Represents a logical table.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#LogicalTable">rr:LogicalTable</a>
    /// </summary>
    let LogicalTable = _prefixId.prefix "LogicalTable"
    /// <summary>
    ///   <para>rdfs:comment : Represents an object map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#ObjectMap">rr:ObjectMap</a>
    /// </summary>
    let ObjectMap = _prefixId.prefix "ObjectMap"
    /// <summary>
    ///   <para>rdfs:comment : Represents a predicate map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#PredicateMap">rr:PredicateMap</a>
    /// </summary>
    let PredicateMap = _prefixId.prefix "PredicateMap"
    /// <summary>
    ///   <para>rdfs:comment : Represents a predicate-object map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#PredicateObjectMap">rr:PredicateObjectMap</a>
    /// </summary>
    let PredicateObjectMap = _prefixId.prefix "PredicateObjectMap"
    let R2RMLView = _prefixId.prefix "R2RMLView"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a reference to an object map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#RefObjectMap">rr:RefObjectMap</a>
    /// </summary>
    let RefObjectMap = _prefixId.prefix "RefObjectMap"
    let SQL2008 = _prefixId.prefix "SQL2008"
    /// <summary>
    ///   <para>rdfs:comment : Represents a subject map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#SubjectMap">rr:SubjectMap</a>
    /// </summary>
    let SubjectMap = _prefixId.prefix "SubjectMap"
    /// <summary>
    ///   <para>rdfs:comment : A function that generates an RDF term from a logical table row.</para>
    ///   <para>rdfs:label : Term Map</para>
    ///   <a href="http://www.w3.org/ns/r2rml#TermMap">rr:TermMap</a>
    /// </summary>
    let TermMap = _prefixId.prefix "TermMap"
    /// <summary>
    ///   <para>rdfs:comment : Represents a triples map.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#TriplesMap">rr:TriplesMap</a>
    /// </summary>
    let TriplesMap = _prefixId.prefix "TriplesMap"
    /// <summary>
    ///   <para>rdfs:comment : Names a column in the child table of a join.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#child">rr:child</a>
    /// </summary>
    let child = _prefixId.prefix "child"
    /// <summary>
    ///   <para>rdfs:comment : The subject value generated for a logical table row will be asserted as an instance of this RDFS class.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#class">rr:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:comment : Name of a column in the logical table. When generating RDF triples from a logical table row, value from the specified column is used as the subject, predicate, or object (based upon the specific domain).</para>
    ///   <a href="http://www.w3.org/ns/r2rml#column">rr:column</a>
    /// </summary>
    let column = _prefixId.prefix "column"
    let constant = _prefixId.prefix "constant"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the datatype of the object component for the generated triple from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#datatype">rr:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    let defaultGraph = _prefixId.prefix "defaultGraph"
    /// <summary>
    ///   <para>rdfs:comment : An IRI reference for use as the graph name of all triples generated with the GraphMap.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#graph">rr:graph</a>
    /// </summary>
    let graph = _prefixId.prefix "graph"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#graphMap">rr:graphMap</a>
    /// </summary>
    let graphMap = _prefixId.prefix "graphMap"
    /// <summary>
    ///   <para>rdfs:comment : An expression that allows, at query processing time, use of index-based access to the the (underlying) relational tables, instead of simply retrieving the table rows first and then applying a filter. This property is useful for retrieval based on conditions involving subject, predicate, or object generated from logical table column(s) and involves some transformation.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#inverseExpression">rr:inverseExpression</a>
    /// </summary>
    let inverseExpression = _prefixId.prefix "inverseExpression"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the join condition for joining the child logical table with the parent logical table of the foreign key constraint.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#joinCondition">rr:joinCondition</a>
    /// </summary>
    let joinCondition = _prefixId.prefix "joinCondition"
    /// <summary>
    ///   <para>rdfs:comment : Specified the language for the object component for the generated triple from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#language">rr:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : Definition of logical table to be mapped.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#logicalTable">rr:logicalTable</a>
    /// </summary>
    let logicalTable = _prefixId.prefix "logicalTable"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the object for the generated triple from the logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#object">rr:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : An ObjectMap element to generate the object component of the (predicate, object) pair from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#objectMap">rr:objectMap</a>
    /// </summary>
    let objectMap = _prefixId.prefix "objectMap"
    /// <summary>
    ///   <para>rdfs:comment : Names a column in the parent table of a join.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#parent">rr:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the TriplesMap element corresponding to the parent logical table of the foreign key constraint.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#parentTriplesMap">rr:parentTriplesMap</a>
    /// </summary>
    let parentTriplesMap = _prefixId.prefix "parentTriplesMap"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the predicate for the generated triple from the logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#predicate">rr:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#predicateMap">rr:predicateMap</a>
    /// </summary>
    let predicateMap = _prefixId.prefix "predicateMap"
    /// <summary>
    ///   <para>rdfs:comment : A PredicateObjectMap element to generate (predicate, object) pair from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#predicateObjectMap">rr:predicateObjectMap</a>
    /// </summary>
    let predicateObjectMap = _prefixId.prefix "predicateObjectMap"
    /// <summary>
    ///   <para>rdfs:comment : A valid SQL query.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#sqlQuery">rr:sqlQuery</a>
    /// </summary>
    let sqlQuery = _prefixId.prefix "sqlQuery"
    /// <summary>
    ///   <para>rdfs:comment : An identifier for a SQL version.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#sqlVersion">rr:sqlVersion</a>
    /// </summary>
    let sqlVersion = _prefixId.prefix "sqlVersion"
    /// <summary>
    ///   <para>rdfs:comment : An IRI reference for use as subject for all the RDF triples generated from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#subject">rr:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : A SubjectMap element to generate a subject from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#subjectMap">rr:subjectMap</a>
    /// </summary>
    let subjectMap = _prefixId.prefix "subjectMap"
    /// <summary>
    ///   <para>rdfs:comment : Schema-qualified name of a table or view.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#tableName">rr:tableName</a>
    /// </summary>
    let tableName = _prefixId.prefix "tableName"
    /// <summary>
    ///   <para>rdfs:comment : A template (format string) to specify how to generate a value for a subject, predicate, or object, using one or more columns from a logical table row.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#template">rr:template</a>
    /// </summary>
    let template = _prefixId.prefix "template"
    /// <summary>
    ///   <para>rdfs:comment : A string indicating whether subject or object generated using the value from column name specified for rr:column should be an IRI reference, blank node, or a literal.</para>
    ///   <a href="http://www.w3.org/ns/r2rml#termType">rr:termType</a>
    /// </summary>
    let termType = _prefixId.prefix "termType"
