namespace http.www.w3.org.ns.r2rml.hash

open DoxAletheia

module r2rml =
    let _namespace_name = "http://www.w3.org/ns/r2rml#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#BaseTableOrView"></see>
    /// </summary>
    let BaseTableOrView = _prefix "BaseTableOrView"
    /// <summary>
    /// Represents a logical table.
    /// <see href="http://www.w3.org/ns/r2rml#LogicalTable"></see></summary>
    let LogicalTable = _prefix "LogicalTable"
    /// <summary>
    /// Denotes a blank node, used with termType
    /// <see href="http://www.w3.org/ns/r2rml#BlankNode"></see></summary>
    let BlankNode = _prefix "BlankNode"
    /// <summary>
    /// Represents a graph map.
    /// <see href="http://www.w3.org/ns/r2rml#GraphMap"></see></summary>
    let GraphMap = _prefix "GraphMap"
    /// <summary>
    /// A function that generates an RDF term from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#TermMap"></see></summary>
    let TermMap = _prefix "TermMap"
    /// <summary>
    /// Denotes an IRI, used with termpType.
    /// <see href="http://www.w3.org/ns/r2rml#IRI"></see></summary>
    let IRI = _prefix "IRI"
    /// <summary>
    /// Represents a join condition.
    /// <see href="http://www.w3.org/ns/r2rml#Join"></see></summary>
    let Join = _prefix "Join"
    /// <summary>
    /// Names a column in the child table of a join.
    /// <see href="http://www.w3.org/ns/r2rml#child"></see></summary>
    let child = _prefix "child"
    /// <summary>
    /// Names a column in the parent table of a join.
    /// <see href="http://www.w3.org/ns/r2rml#parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// Denotes a Literal, used with termType.
    /// <see href="http://www.w3.org/ns/r2rml#Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    /// Represents an object map.
    /// <see href="http://www.w3.org/ns/r2rml#ObjectMap"></see></summary>
    let ObjectMap = _prefix "ObjectMap"
    /// <summary>
    /// Specifies the datatype of the object component for the generated triple from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// Specified the language for the object component for the generated triple from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Specifies the object for the generated triple from the logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// Represents a predicate map.
    /// <see href="http://www.w3.org/ns/r2rml#PredicateMap"></see></summary>
    let PredicateMap = _prefix "PredicateMap"
    /// <summary>
    /// Specifies the predicate for the generated triple from the logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// Represents a predicate-object map.
    /// <see href="http://www.w3.org/ns/r2rml#PredicateObjectMap"></see></summary>
    let PredicateObjectMap = _prefix "PredicateObjectMap"
    /// <summary>
    /// A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicateMap"></see></summary>
    let predicateMap = _prefix "predicateMap"
    /// <summary>
    /// An ObjectMap element to generate the object component of the (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#objectMap"></see></summary>
    let objectMap = _prefix "objectMap"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#R2RMLView"></see>
    /// </summary>
    let R2RMLView = _prefix "R2RMLView"
    /// <summary>
    /// Denotes a reference to an object map.
    /// <see href="http://www.w3.org/ns/r2rml#RefObjectMap"></see></summary>
    let RefObjectMap = _prefix "RefObjectMap"
    /// <summary>
    /// Core SQL 2008
    /// <see href="http://www.w3.org/ns/r2rml#SQL2008"></see></summary>
    let SQL2008 = _prefix "SQL2008"
    /// <summary>
    /// Represents a subject map.
    /// <see href="http://www.w3.org/ns/r2rml#SubjectMap"></see></summary>
    let SubjectMap = _prefix "SubjectMap"
    /// <summary>
    /// The subject value generated for a logical table row will be asserted as an instance of this RDFS class.
    /// <see href="http://www.w3.org/ns/r2rml#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// Represents a triples map.
    /// <see href="http://www.w3.org/ns/r2rml#TriplesMap"></see></summary>
    let TriplesMap = _prefix "TriplesMap"
    /// <summary>
    /// A SubjectMap element to generate a subject from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#subjectMap"></see></summary>
    let subjectMap = _prefix "subjectMap"
    /// <summary>
    /// Definition of logical table to be mapped.
    /// <see href="http://www.w3.org/ns/r2rml#logicalTable"></see></summary>
    let logicalTable = _prefix "logicalTable"
    /// <summary>
    /// Name of a column in the logical table. When generating RDF triples from a logical table row, value from the specified column is used as the subject, predicate, or object (based upon the specific domain).
    /// <see href="http://www.w3.org/ns/r2rml#column"></see></summary>
    let column = _prefix "column"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#constant"></see>
    /// </summary>
    let constant = _prefix "constant"
    /// <summary>
    /// Denotes a default graph
    /// <see href="http://www.w3.org/ns/r2rml#defaultGraph"></see></summary>
    let defaultGraph = _prefix "defaultGraph"
    /// <summary>
    /// An IRI reference for use as the graph name of all triples generated with the GraphMap.
    /// <see href="http://www.w3.org/ns/r2rml#graph"></see></summary>
    let graph = _prefix "graph"
    /// <summary>
    /// A template (format string) to specify how to generate a value for a subject, predicate, or object, using one or more columns from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#template"></see></summary>
    let template = _prefix "template"
    /// <summary>
    /// Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.
    /// <see href="http://www.w3.org/ns/r2rml#graphMap"></see></summary>
    let graphMap = _prefix "graphMap"
    /// <summary>
    /// An expression that allows, at query processing time, use of index-based access to the the (underlying) relational tables, instead of simply retrieving the table rows first and then applying a filter. This property is useful for retrieval based on conditions involving subject, predicate, or object generated from logical table column(s) and involves some transformation.
    /// <see href="http://www.w3.org/ns/r2rml#inverseExpression"></see></summary>
    let inverseExpression = _prefix "inverseExpression"
    /// <summary>
    /// Specifies the join condition for joining the child logical table with the parent logical table of the foreign key constraint.
    /// <see href="http://www.w3.org/ns/r2rml#joinCondition"></see></summary>
    let joinCondition = _prefix "joinCondition"
    /// <summary>
    /// Specifies the TriplesMap element corresponding to the parent logical table of the foreign key constraint.
    /// <see href="http://www.w3.org/ns/r2rml#parentTriplesMap"></see></summary>
    let parentTriplesMap = _prefix "parentTriplesMap"
    /// <summary>
    /// A PredicateObjectMap element to generate (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicateObjectMap"></see></summary>
    let predicateObjectMap = _prefix "predicateObjectMap"
    /// <summary>
    /// A valid SQL query.
    /// <see href="http://www.w3.org/ns/r2rml#sqlQuery"></see></summary>
    let sqlQuery = _prefix "sqlQuery"
    /// <summary>
    /// An identifier for a SQL version.
    /// <see href="http://www.w3.org/ns/r2rml#sqlVersion"></see></summary>
    let sqlVersion = _prefix "sqlVersion"
    /// <summary>
    /// An IRI reference for use as subject for all the RDF triples generated from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Schema-qualified name of a table or view.
    /// <see href="http://www.w3.org/ns/r2rml#tableName"></see></summary>
    let tableName = _prefix "tableName"
    /// <summary>
    /// A string indicating whether subject or object generated using the value from column name specified for rr:column should be an IRI reference, blank node, or a literal.
    /// <see href="http://www.w3.org/ns/r2rml#termType"></see></summary>
    let termType = _prefix "termType"
