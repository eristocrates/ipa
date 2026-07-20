namespace http.w3id.org.rml.slash

open DoxAletheia

module rml_fnml =
    let _namespace_name = "http://w3id.org/rml/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Denotes a blank node, used with termType
    /// <see href="http://w3id.org/rml/BlankNode"></see></summary>
    let BlankNode = _prefix "BlankNode"
    /// <summary>
    ///   <see href="http://w3id.org/rml/core/"></see>
    /// </summary>
    let ``core/`` = _prefix "core/"
    /// <summary>
    /// Represents a child map
    /// <see href="http://w3id.org/rml/ChildMap"></see></summary>
    let ChildMap = _prefix "ChildMap"
    /// <summary>
    /// Represents an expression map
    /// <see href="http://w3id.org/rml/ExpressionMap"></see></summary>
    let ExpressionMap = _prefix "ExpressionMap"
    /// <summary>
    /// Represents a datatype map
    /// <see href="http://w3id.org/rml/DatatypeMap"></see></summary>
    let DatatypeMap = _prefix "DatatypeMap"
    /// <summary>
    /// Represents a graph map.
    /// <see href="http://w3id.org/rml/GraphMap"></see></summary>
    let GraphMap = _prefix "GraphMap"
    /// <summary>
    /// A function that generates any number of RDF terms from a logical source record.
    /// <see href="http://w3id.org/rml/TermMap"></see></summary>
    let TermMap = _prefix "TermMap"
    /// <summary>
    /// Denotes an IRI, used with termpType.
    /// <see href="http://w3id.org/rml/IRI"></see></summary>
    let IRI = _prefix "IRI"
    /// <summary>
    /// Represents a join condition.
    /// <see href="http://w3id.org/rml/Join"></see></summary>
    let Join = _prefix "Join"
    /// <summary>
    /// Represents a language map
    /// <see href="http://w3id.org/rml/LanguageMap"></see></summary>
    let LanguageMap = _prefix "LanguageMap"
    /// <summary>
    /// Denotes a Literal, used with termType.
    /// <see href="http://w3id.org/rml/Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    ///   <see href="http://w3id.org/rml/LogicalSource"></see>
    /// </summary>
    let LogicalSource = _prefix "LogicalSource"
    /// <summary>
    ///   <see href="http://w3id.org/rml/LogicalTarget"></see>
    /// </summary>
    let LogicalTarget = _prefix "LogicalTarget"
    /// <summary>
    /// Represents an object map.
    /// <see href="http://w3id.org/rml/ObjectMap"></see></summary>
    let ObjectMap = _prefix "ObjectMap"
    /// <summary>
    /// Represents a parent map
    /// <see href="http://w3id.org/rml/ParentMap"></see></summary>
    let ParentMap = _prefix "ParentMap"
    /// <summary>
    /// Represents a predicate map.
    /// <see href="http://w3id.org/rml/PredicateMap"></see></summary>
    let PredicateMap = _prefix "PredicateMap"
    /// <summary>
    /// Represents a predicate-object map.
    /// <see href="http://w3id.org/rml/PredicateObjectMap"></see></summary>
    let PredicateObjectMap = _prefix "PredicateObjectMap"
    /// <summary>
    /// Denotes a reference to an object map.
    /// <see href="http://w3id.org/rml/RefObjectMap"></see></summary>
    let RefObjectMap = _prefix "RefObjectMap"
    /// <summary>
    /// Denotes a strategy to perform a action (e.g. gather for collections and containers, joins).
    /// <see href="http://w3id.org/rml/Strategy"></see></summary>
    let Strategy = _prefix "Strategy"
    /// <summary>
    /// Represents a subject map.
    /// <see href="http://w3id.org/rml/SubjectMap"></see></summary>
    let SubjectMap = _prefix "SubjectMap"
    /// <summary>
    /// Represents a triples map.
    /// <see href="http://w3id.org/rml/TriplesMap"></see></summary>
    let TriplesMap = _prefix "TriplesMap"
    /// <summary>
    /// Names a source record in the child source of a join.
    /// <see href="http://w3id.org/rml/child"></see></summary>
    let child = _prefix "child"
    /// <summary>
    /// Names a child map in the child source of a join.
    /// <see href="http://w3id.org/rml/childMap"></see></summary>
    let childMap = _prefix "childMap"
    /// <summary>
    /// The subject value generated for a logical source record will be asserted as an instance of this RDFS class.
    /// <see href="http://w3id.org/rml/class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// A property for indicating whether a expression map is a constant-valued expression map.
    /// <see href="http://w3id.org/rml/constant"></see></summary>
    let constant = _prefix "constant"
    /// <summary>
    ///   <see href="http://w3id.org/rml/core"></see>
    /// </summary>
    let core = _prefix "core"
    /// <summary>
    /// Specifies the datatype of the object component for the generated triple.
    /// <see href="http://w3id.org/rml/datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// A DatatypetMap element to generate the datatype component of the object component from a logical source record.
    /// <see href="http://w3id.org/rml/datatypeMap"></see></summary>
    let datatypeMap = _prefix "datatypeMap"
    /// <summary>
    /// An IRI reference for use as the graph name of all triples generated with the SubjectMap or PredicateObjectMap.
    /// <see href="http://w3id.org/rml/graph"></see></summary>
    let graph = _prefix "graph"
    /// <summary>
    /// Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.
    /// <see href="http://w3id.org/rml/graphMap"></see></summary>
    let graphMap = _prefix "graphMap"
    /// <summary>
    /// Specifies the join condition for joining the child logical source with the parent logical source of the foreign key constraint.
    /// <see href="http://w3id.org/rml/joinCondition"></see></summary>
    let joinCondition = _prefix "joinCondition"
    /// <summary>
    /// Specified the language for the object component for the generated triple.
    /// <see href="http://w3id.org/rml/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// A LanguagetMap element to generate the language tag of the object component from a logical source record.
    /// <see href="http://w3id.org/rml/languageMap"></see></summary>
    let languageMap = _prefix "languageMap"
    /// <summary>
    /// Represents the logical source to be mapped.
    /// <see href="http://w3id.org/rml/logicalSource"></see></summary>
    let logicalSource = _prefix "logicalSource"
    /// <summary>
    /// Represents the logical target to where triples are exported to.
    /// <see href="http://w3id.org/rml/logicalTarget"></see></summary>
    let logicalTarget = _prefix "logicalTarget"
    /// <summary>
    /// Specifies the object for the generated triple from the logical source record.
    /// <see href="http://w3id.org/rml/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// An ObjectMap element to generate the object component of the (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/objectMap"></see></summary>
    let objectMap = _prefix "objectMap"
    /// <summary>
    /// Names a source record in the parent source of a join.
    /// <see href="http://w3id.org/rml/parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// Names a parent map in the parent source of a join.
    /// <see href="http://w3id.org/rml/parentMap"></see></summary>
    let parentMap = _prefix "parentMap"
    /// <summary>
    /// Specifies the TriplesMap element corresponding to the parent logical source of the foreign key constraint.
    /// <see href="http://w3id.org/rml/parentTriplesMap"></see></summary>
    let parentTriplesMap = _prefix "parentTriplesMap"
    /// <summary>
    /// Specifies the predicate for the generated triple from the logical source record.
    /// <see href="http://w3id.org/rml/predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/predicateMap"></see></summary>
    let predicateMap = _prefix "predicateMap"
    /// <summary>
    /// A PredicateObjectMap element to generate (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/predicateObjectMap"></see></summary>
    let predicateObjectMap = _prefix "predicateObjectMap"
    /// <summary>
    /// A valid expression that selects values from the source data. The reference should conform to the syntax rules/grammar of the specified Reference Formulation.
    /// <see href="http://w3id.org/rml/reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// A Strategy element to indicate how to perform an action (e.g. gather for collections and containers, join).
    /// <see href="http://w3id.org/rml/strategy"></see></summary>
    let strategy = _prefix "strategy"
    /// <summary>
    /// An IRI reference for use as subject for all the RDF triples generated from a logical source record.
    /// <see href="http://w3id.org/rml/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A SubjectMap element to generate a subject from a logical source record.
    /// <see href="http://w3id.org/rml/subjectMap"></see></summary>
    let subjectMap = _prefix "subjectMap"
    /// <summary>
    /// A template (format string) to specify how to generate a value for a expression map, using one or more records from a logical source record.
    /// <see href="http://w3id.org/rml/template"></see></summary>
    let template = _prefix "template"
    /// <summary>
    /// A string indicating whether subject or object generated using the value from a source record name specified should be an IRI reference, blank node, or a literal.
    /// <see href="http://w3id.org/rml/termType"></see></summary>
    let termType = _prefix "termType"
