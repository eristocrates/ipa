namespace http.www.w3.org.ns.r2rml.hash

open DoxAletheia.Rdf_Vocabulary

module r2rml =
    let _namespace_name = "http://www.w3.org/ns/r2rml#"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#BaseTableOrView"></see>
    /// </summary>
    let BaseTableOrView =
        Namespaced_IRI.parse _namespace_name "BaseTableOrView" |> NamespacedName

    /// <summary>
    /// Represents a logical table.
    /// <see href="http://www.w3.org/ns/r2rml#LogicalTable"></see></summary>
    let LogicalTable =
        Namespaced_IRI.parse _namespace_name "LogicalTable" |> NamespacedName

    /// <summary>
    /// Denotes a blank node, used with termType
    /// <see href="http://www.w3.org/ns/r2rml#BlankNode"></see></summary>
    let BlankNode = Namespaced_IRI.parse _namespace_name "BlankNode" |> NamespacedName
    /// <summary>
    /// Represents a graph map.
    /// <see href="http://www.w3.org/ns/r2rml#GraphMap"></see></summary>
    let GraphMap = Namespaced_IRI.parse _namespace_name "GraphMap" |> NamespacedName
    /// <summary>
    /// A function that generates an RDF term from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#TermMap"></see></summary>
    let TermMap = Namespaced_IRI.parse _namespace_name "TermMap" |> NamespacedName
    /// <summary>
    /// Denotes an IRI, used with termpType.
    /// <see href="http://www.w3.org/ns/r2rml#IRI"></see></summary>
    let IRI = Namespaced_IRI.parse _namespace_name "IRI" |> NamespacedName
    /// <summary>
    /// Represents a join condition.
    /// <see href="http://www.w3.org/ns/r2rml#Join"></see></summary>
    let Join = Namespaced_IRI.parse _namespace_name "Join" |> NamespacedName
    /// <summary>
    /// Names a column in the child table of a join.
    /// <see href="http://www.w3.org/ns/r2rml#child"></see></summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName
    /// <summary>
    /// Names a column in the parent table of a join.
    /// <see href="http://www.w3.org/ns/r2rml#parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// Denotes a Literal, used with termType.
    /// <see href="http://www.w3.org/ns/r2rml#Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName
    /// <summary>
    /// Represents an object map.
    /// <see href="http://www.w3.org/ns/r2rml#ObjectMap"></see></summary>
    let ObjectMap = Namespaced_IRI.parse _namespace_name "ObjectMap" |> NamespacedName
    /// <summary>
    /// Specifies the datatype of the object component for the generated triple from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// Specified the language for the object component for the generated triple from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Specifies the object for the generated triple from the logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName

    /// <summary>
    /// Represents a predicate map.
    /// <see href="http://www.w3.org/ns/r2rml#PredicateMap"></see></summary>
    let PredicateMap =
        Namespaced_IRI.parse _namespace_name "PredicateMap" |> NamespacedName

    /// <summary>
    /// Specifies the predicate for the generated triple from the logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName

    /// <summary>
    /// Represents a predicate-object map.
    /// <see href="http://www.w3.org/ns/r2rml#PredicateObjectMap"></see></summary>
    let PredicateObjectMap =
        Namespaced_IRI.parse _namespace_name "PredicateObjectMap" |> NamespacedName

    /// <summary>
    /// A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicateMap"></see></summary>
    let predicateMap =
        Namespaced_IRI.parse _namespace_name "predicateMap" |> NamespacedName

    /// <summary>
    /// An ObjectMap element to generate the object component of the (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#objectMap"></see></summary>
    let objectMap = Namespaced_IRI.parse _namespace_name "objectMap" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#R2RMLView"></see>
    /// </summary>
    let R2RMLView = Namespaced_IRI.parse _namespace_name "R2RMLView" |> NamespacedName

    /// <summary>
    /// Denotes a reference to an object map.
    /// <see href="http://www.w3.org/ns/r2rml#RefObjectMap"></see></summary>
    let RefObjectMap =
        Namespaced_IRI.parse _namespace_name "RefObjectMap" |> NamespacedName

    /// <summary>
    /// Core SQL 2008
    /// <see href="http://www.w3.org/ns/r2rml#SQL2008"></see></summary>
    let SQL2008 = Namespaced_IRI.parse _namespace_name "SQL2008" |> NamespacedName
    /// <summary>
    /// Represents a subject map.
    /// <see href="http://www.w3.org/ns/r2rml#SubjectMap"></see></summary>
    let SubjectMap = Namespaced_IRI.parse _namespace_name "SubjectMap" |> NamespacedName
    /// <summary>
    /// The subject value generated for a logical table row will be asserted as an instance of this RDFS class.
    /// <see href="http://www.w3.org/ns/r2rml#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// Represents a triples map.
    /// <see href="http://www.w3.org/ns/r2rml#TriplesMap"></see></summary>
    let TriplesMap = Namespaced_IRI.parse _namespace_name "TriplesMap" |> NamespacedName
    /// <summary>
    /// A SubjectMap element to generate a subject from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#subjectMap"></see></summary>
    let subjectMap = Namespaced_IRI.parse _namespace_name "subjectMap" |> NamespacedName

    /// <summary>
    /// Definition of logical table to be mapped.
    /// <see href="http://www.w3.org/ns/r2rml#logicalTable"></see></summary>
    let logicalTable =
        Namespaced_IRI.parse _namespace_name "logicalTable" |> NamespacedName

    /// <summary>
    /// Name of a column in the logical table. When generating RDF triples from a logical table row, value from the specified column is used as the subject, predicate, or object (based upon the specific domain).
    /// <see href="http://www.w3.org/ns/r2rml#column"></see></summary>
    let column = Namespaced_IRI.parse _namespace_name "column" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/r2rml#constant"></see>
    /// </summary>
    let constant = Namespaced_IRI.parse _namespace_name "constant" |> NamespacedName

    /// <summary>
    /// Denotes a default graph
    /// <see href="http://www.w3.org/ns/r2rml#defaultGraph"></see></summary>
    let defaultGraph =
        Namespaced_IRI.parse _namespace_name "defaultGraph" |> NamespacedName

    /// <summary>
    /// An IRI reference for use as the graph name of all triples generated with the GraphMap.
    /// <see href="http://www.w3.org/ns/r2rml#graph"></see></summary>
    let graph = Namespaced_IRI.parse _namespace_name "graph" |> NamespacedName
    /// <summary>
    /// A template (format string) to specify how to generate a value for a subject, predicate, or object, using one or more columns from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#template"></see></summary>
    let template = Namespaced_IRI.parse _namespace_name "template" |> NamespacedName
    /// <summary>
    /// Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.
    /// <see href="http://www.w3.org/ns/r2rml#graphMap"></see></summary>
    let graphMap = Namespaced_IRI.parse _namespace_name "graphMap" |> NamespacedName

    /// <summary>
    /// An expression that allows, at query processing time, use of index-based access to the the (underlying) relational tables, instead of simply retrieving the table rows first and then applying a filter. This property is useful for retrieval based on conditions involving subject, predicate, or object generated from logical table column(s) and involves some transformation.
    /// <see href="http://www.w3.org/ns/r2rml#inverseExpression"></see></summary>
    let inverseExpression =
        Namespaced_IRI.parse _namespace_name "inverseExpression" |> NamespacedName

    /// <summary>
    /// Specifies the join condition for joining the child logical table with the parent logical table of the foreign key constraint.
    /// <see href="http://www.w3.org/ns/r2rml#joinCondition"></see></summary>
    let joinCondition =
        Namespaced_IRI.parse _namespace_name "joinCondition" |> NamespacedName

    /// <summary>
    /// Specifies the TriplesMap element corresponding to the parent logical table of the foreign key constraint.
    /// <see href="http://www.w3.org/ns/r2rml#parentTriplesMap"></see></summary>
    let parentTriplesMap =
        Namespaced_IRI.parse _namespace_name "parentTriplesMap" |> NamespacedName

    /// <summary>
    /// A PredicateObjectMap element to generate (predicate, object) pair from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#predicateObjectMap"></see></summary>
    let predicateObjectMap =
        Namespaced_IRI.parse _namespace_name "predicateObjectMap" |> NamespacedName

    /// <summary>
    /// A valid SQL query.
    /// <see href="http://www.w3.org/ns/r2rml#sqlQuery"></see></summary>
    let sqlQuery = Namespaced_IRI.parse _namespace_name "sqlQuery" |> NamespacedName
    /// <summary>
    /// An identifier for a SQL version.
    /// <see href="http://www.w3.org/ns/r2rml#sqlVersion"></see></summary>
    let sqlVersion = Namespaced_IRI.parse _namespace_name "sqlVersion" |> NamespacedName
    /// <summary>
    /// An IRI reference for use as subject for all the RDF triples generated from a logical table row.
    /// <see href="http://www.w3.org/ns/r2rml#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// Schema-qualified name of a table or view.
    /// <see href="http://www.w3.org/ns/r2rml#tableName"></see></summary>
    let tableName = Namespaced_IRI.parse _namespace_name "tableName" |> NamespacedName
    /// <summary>
    /// A string indicating whether subject or object generated using the value from column name specified for rr:column should be an IRI reference, blank node, or a literal.
    /// <see href="http://www.w3.org/ns/r2rml#termType"></see></summary>
    let termType = Namespaced_IRI.parse _namespace_name "termType" |> NamespacedName
