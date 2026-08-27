namespace http.www.w3.org.ns.r2rml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module r2rml =
    let _namespace_iri = Namespace_Iri r2rml |> NamespaceIRI
    /// <summary>
    ///   <para>r2rml:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#">http://www.w3.org/ns/r2rml#</seealso>
    let _prefix_iri = Prefixed_Name(r2rml, "") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:BaseTableOrView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#BaseTableOrView">http://www.w3.org/ns/r2rml#BaseTableOrView</seealso>
    let BaseTableOrView = Prefixed_Name(r2rml, "BaseTableOrView") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:BlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a blank node, used with termType"</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#BlankNode">http://www.w3.org/ns/r2rml#BlankNode</seealso>
    let BlankNode = Prefixed_Name(r2rml, "BlankNode") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:GraphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a graph map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#GraphMap">http://www.w3.org/ns/r2rml#GraphMap</seealso>
    let GraphMap = Prefixed_Name(r2rml, "GraphMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes an IRI, used with termpType."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#IRI">http://www.w3.org/ns/r2rml#IRI</seealso>
    let IRI = Prefixed_Name(r2rml, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a join condition."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#Join">http://www.w3.org/ns/r2rml#Join</seealso>
    let Join = Prefixed_Name(r2rml, "Join") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a Literal, used with termType."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#Literal">http://www.w3.org/ns/r2rml#Literal</seealso>
    let Literal = Prefixed_Name(r2rml, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:LogicalTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a logical table."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#LogicalTable">http://www.w3.org/ns/r2rml#LogicalTable</seealso>
    let LogicalTable = Prefixed_Name(r2rml, "LogicalTable") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:ObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an object map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#ObjectMap">http://www.w3.org/ns/r2rml#ObjectMap</seealso>
    let ObjectMap = Prefixed_Name(r2rml, "ObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:PredicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a predicate map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#PredicateMap">http://www.w3.org/ns/r2rml#PredicateMap</seealso>
    let PredicateMap = Prefixed_Name(r2rml, "PredicateMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:PredicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a predicate-object map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#PredicateObjectMap">http://www.w3.org/ns/r2rml#PredicateObjectMap</seealso>
    let PredicateObjectMap = Prefixed_Name(r2rml, "PredicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:R2RMLView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#R2RMLView">http://www.w3.org/ns/r2rml#R2RMLView</seealso>
    let R2RMLView = Prefixed_Name(r2rml, "R2RMLView") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:RefObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a reference to an object map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#RefObjectMap">http://www.w3.org/ns/r2rml#RefObjectMap</seealso>
    let RefObjectMap = Prefixed_Name(r2rml, "RefObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:SQL2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Core SQL 2008"</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#SQL2008">http://www.w3.org/ns/r2rml#SQL2008</seealso>
    let SQL2008 = Prefixed_Name(r2rml, "SQL2008") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:SubjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a subject map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#SubjectMap">http://www.w3.org/ns/r2rml#SubjectMap</seealso>
    let SubjectMap = Prefixed_Name(r2rml, "SubjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:TermMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A function that generates an RDF term from a logical table row."</para>
    /// labels<para>"Term Map"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#TermMap">http://www.w3.org/ns/r2rml#TermMap</seealso>
    let TermMap = Prefixed_Name(r2rml, "TermMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:TriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a triples map."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#TriplesMap">http://www.w3.org/ns/r2rml#TriplesMap</seealso>
    let TriplesMap = Prefixed_Name(r2rml, "TriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Names a column in the child table of a join."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#child">http://www.w3.org/ns/r2rml#child</seealso>
    let child = Prefixed_Name(r2rml, "child") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject value generated for a logical table row will be asserted as an instance of this RDFS class."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#class">http://www.w3.org/ns/r2rml#class</seealso>
    let class_ = Prefixed_Name(r2rml, "class") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of a column in the logical table. When generating RDF triples from a logical table row, value from the specified column is used as the subject, predicate, or object (based upon the specific domain)."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#column">http://www.w3.org/ns/r2rml#column</seealso>
    let column = Prefixed_Name(r2rml, "column") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:constant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#constant">http://www.w3.org/ns/r2rml#constant</seealso>
    let constant = Prefixed_Name(r2rml, "constant") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the datatype of the object component for the generated triple from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#datatype">http://www.w3.org/ns/r2rml#datatype</seealso>
    let datatype = Prefixed_Name(r2rml, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:defaultGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denotes a default graph"</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#defaultGraph">http://www.w3.org/ns/r2rml#defaultGraph</seealso>
    let defaultGraph = Prefixed_Name(r2rml, "defaultGraph") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An IRI reference for use as the graph name of all triples generated with the GraphMap."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#graph">http://www.w3.org/ns/r2rml#graph</seealso>
    let graph = Prefixed_Name(r2rml, "graph") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:graphMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#graphMap">http://www.w3.org/ns/r2rml#graphMap</seealso>
    let graphMap = Prefixed_Name(r2rml, "graphMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:inverseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An expression that allows, at query processing time, use of index-based access to the the (underlying) relational tables, instead of simply retrieving the table rows first and then applying a filter. This property is useful for retrieval based on conditions involving subject, predicate, or object generated from logical table column(s) and involves some transformation."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#inverseExpression">http://www.w3.org/ns/r2rml#inverseExpression</seealso>
    let inverseExpression = Prefixed_Name(r2rml, "inverseExpression") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:joinCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the join condition for joining the child logical table with the parent logical table of the foreign key constraint."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#joinCondition">http://www.w3.org/ns/r2rml#joinCondition</seealso>
    let joinCondition = Prefixed_Name(r2rml, "joinCondition") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specified the language for the object component for the generated triple from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#language">http://www.w3.org/ns/r2rml#language</seealso>
    let language = Prefixed_Name(r2rml, "language") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:logicalTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Definition of logical table to be mapped."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#logicalTable">http://www.w3.org/ns/r2rml#logicalTable</seealso>
    let logicalTable = Prefixed_Name(r2rml, "logicalTable") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the object for the generated triple from the logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#object">http://www.w3.org/ns/r2rml#object</seealso>
    let object = Prefixed_Name(r2rml, "object") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:objectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An ObjectMap element to generate the object component of the (predicate, object) pair from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#objectMap">http://www.w3.org/ns/r2rml#objectMap</seealso>
    let objectMap = Prefixed_Name(r2rml, "objectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Names a column in the parent table of a join."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#parent">http://www.w3.org/ns/r2rml#parent</seealso>
    let parent = Prefixed_Name(r2rml, "parent") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:parentTriplesMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the TriplesMap element corresponding to the parent logical table of the foreign key constraint."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#parentTriplesMap">http://www.w3.org/ns/r2rml#parentTriplesMap</seealso>
    let parentTriplesMap = Prefixed_Name(r2rml, "parentTriplesMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the predicate for the generated triple from the logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#predicate">http://www.w3.org/ns/r2rml#predicate</seealso>
    let predicate = Prefixed_Name(r2rml, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:predicateMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#predicateMap">http://www.w3.org/ns/r2rml#predicateMap</seealso>
    let predicateMap = Prefixed_Name(r2rml, "predicateMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:predicateObjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A PredicateObjectMap element to generate (predicate, object) pair from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#predicateObjectMap">http://www.w3.org/ns/r2rml#predicateObjectMap</seealso>
    let predicateObjectMap = Prefixed_Name(r2rml, "predicateObjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:sqlQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A valid SQL query."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#sqlQuery">http://www.w3.org/ns/r2rml#sqlQuery</seealso>
    let sqlQuery = Prefixed_Name(r2rml, "sqlQuery") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:sqlVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An identifier for a SQL version."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#sqlVersion">http://www.w3.org/ns/r2rml#sqlVersion</seealso>
    let sqlVersion = Prefixed_Name(r2rml, "sqlVersion") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An IRI reference for use as subject for all the RDF triples generated from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#subject">http://www.w3.org/ns/r2rml#subject</seealso>
    let subject = Prefixed_Name(r2rml, "subject") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:subjectMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SubjectMap element to generate a subject from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#subjectMap">http://www.w3.org/ns/r2rml#subjectMap</seealso>
    let subjectMap = Prefixed_Name(r2rml, "subjectMap") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:tableName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Schema-qualified name of a table or view."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#tableName">http://www.w3.org/ns/r2rml#tableName</seealso>
    let tableName = Prefixed_Name(r2rml, "tableName") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A template (format string) to specify how to generate a value for a subject, predicate, or object, using one or more columns from a logical table row."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#template">http://www.w3.org/ns/r2rml#template</seealso>
    let template = Prefixed_Name(r2rml, "template") |> PrefixedName
    /// <summary>
    ///   <para>r2rml:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A string indicating whether subject or object generated using the value from column name specified for rr:column should be an IRI reference, blank node, or a literal."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/r2rml#termType">http://www.w3.org/ns/r2rml#termType</seealso>
    let termType = Prefixed_Name(r2rml, "termType") |> PrefixedName
