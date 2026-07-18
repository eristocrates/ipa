namespace http.w3id.org.rml.slash

open DoxAletheia.Rdf_Vocabulary

module rml_fnml =
    let _namespace_name = "http://w3id.org/rml/"
    /// <summary>
    /// Denotes a blank node, used with termType
    /// <see href="http://w3id.org/rml/BlankNode"></see></summary>
    let BlankNode = Namespaced_IRI.parse _namespace_name "BlankNode" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/rml/core/"></see>
    /// </summary>
    let ``core/`` = Namespaced_IRI.parse _namespace_name "core/" |> NamespacedName
    /// <summary>
    /// Represents a child map
    /// <see href="http://w3id.org/rml/ChildMap"></see></summary>
    let ChildMap = Namespaced_IRI.parse _namespace_name "ChildMap" |> NamespacedName

    /// <summary>
    /// Represents an expression map
    /// <see href="http://w3id.org/rml/ExpressionMap"></see></summary>
    let ExpressionMap =
        Namespaced_IRI.parse _namespace_name "ExpressionMap" |> NamespacedName

    /// <summary>
    /// Represents a datatype map
    /// <see href="http://w3id.org/rml/DatatypeMap"></see></summary>
    let DatatypeMap =
        Namespaced_IRI.parse _namespace_name "DatatypeMap" |> NamespacedName

    /// <summary>
    /// Represents a graph map.
    /// <see href="http://w3id.org/rml/GraphMap"></see></summary>
    let GraphMap = Namespaced_IRI.parse _namespace_name "GraphMap" |> NamespacedName
    /// <summary>
    /// A function that generates any number of RDF terms from a logical source record.
    /// <see href="http://w3id.org/rml/TermMap"></see></summary>
    let TermMap = Namespaced_IRI.parse _namespace_name "TermMap" |> NamespacedName
    /// <summary>
    /// Denotes an IRI, used with termpType.
    /// <see href="http://w3id.org/rml/IRI"></see></summary>
    let IRI = Namespaced_IRI.parse _namespace_name "IRI" |> NamespacedName
    /// <summary>
    /// Represents a join condition.
    /// <see href="http://w3id.org/rml/Join"></see></summary>
    let Join = Namespaced_IRI.parse _namespace_name "Join" |> NamespacedName

    /// <summary>
    /// Represents a language map
    /// <see href="http://w3id.org/rml/LanguageMap"></see></summary>
    let LanguageMap =
        Namespaced_IRI.parse _namespace_name "LanguageMap" |> NamespacedName

    /// <summary>
    /// Denotes a Literal, used with termType.
    /// <see href="http://w3id.org/rml/Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/rml/LogicalSource"></see>
    /// </summary>
    let LogicalSource =
        Namespaced_IRI.parse _namespace_name "LogicalSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/rml/LogicalTarget"></see>
    /// </summary>
    let LogicalTarget =
        Namespaced_IRI.parse _namespace_name "LogicalTarget" |> NamespacedName

    /// <summary>
    /// Represents an object map.
    /// <see href="http://w3id.org/rml/ObjectMap"></see></summary>
    let ObjectMap = Namespaced_IRI.parse _namespace_name "ObjectMap" |> NamespacedName
    /// <summary>
    /// Represents a parent map
    /// <see href="http://w3id.org/rml/ParentMap"></see></summary>
    let ParentMap = Namespaced_IRI.parse _namespace_name "ParentMap" |> NamespacedName

    /// <summary>
    /// Represents a predicate map.
    /// <see href="http://w3id.org/rml/PredicateMap"></see></summary>
    let PredicateMap =
        Namespaced_IRI.parse _namespace_name "PredicateMap" |> NamespacedName

    /// <summary>
    /// Represents a predicate-object map.
    /// <see href="http://w3id.org/rml/PredicateObjectMap"></see></summary>
    let PredicateObjectMap =
        Namespaced_IRI.parse _namespace_name "PredicateObjectMap" |> NamespacedName

    /// <summary>
    /// Denotes a reference to an object map.
    /// <see href="http://w3id.org/rml/RefObjectMap"></see></summary>
    let RefObjectMap =
        Namespaced_IRI.parse _namespace_name "RefObjectMap" |> NamespacedName

    /// <summary>
    /// Denotes a strategy to perform a action (e.g. gather for collections and containers, joins).
    /// <see href="http://w3id.org/rml/Strategy"></see></summary>
    let Strategy = Namespaced_IRI.parse _namespace_name "Strategy" |> NamespacedName
    /// <summary>
    /// Represents a subject map.
    /// <see href="http://w3id.org/rml/SubjectMap"></see></summary>
    let SubjectMap = Namespaced_IRI.parse _namespace_name "SubjectMap" |> NamespacedName
    /// <summary>
    /// Represents a triples map.
    /// <see href="http://w3id.org/rml/TriplesMap"></see></summary>
    let TriplesMap = Namespaced_IRI.parse _namespace_name "TriplesMap" |> NamespacedName
    /// <summary>
    /// Names a source record in the child source of a join.
    /// <see href="http://w3id.org/rml/child"></see></summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName
    /// <summary>
    /// Names a child map in the child source of a join.
    /// <see href="http://w3id.org/rml/childMap"></see></summary>
    let childMap = Namespaced_IRI.parse _namespace_name "childMap" |> NamespacedName
    /// <summary>
    /// The subject value generated for a logical source record will be asserted as an instance of this RDFS class.
    /// <see href="http://w3id.org/rml/class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// A property for indicating whether a expression map is a constant-valued expression map.
    /// <see href="http://w3id.org/rml/constant"></see></summary>
    let constant = Namespaced_IRI.parse _namespace_name "constant" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/rml/core"></see>
    /// </summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName
    /// <summary>
    /// Specifies the datatype of the object component for the generated triple.
    /// <see href="http://w3id.org/rml/datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName

    /// <summary>
    /// A DatatypetMap element to generate the datatype component of the object component from a logical source record.
    /// <see href="http://w3id.org/rml/datatypeMap"></see></summary>
    let datatypeMap =
        Namespaced_IRI.parse _namespace_name "datatypeMap" |> NamespacedName

    /// <summary>
    /// An IRI reference for use as the graph name of all triples generated with the SubjectMap or PredicateObjectMap.
    /// <see href="http://w3id.org/rml/graph"></see></summary>
    let graph = Namespaced_IRI.parse _namespace_name "graph" |> NamespacedName
    /// <summary>
    /// Specifies a GraphMap. When used with a SubjectMap element, all the RDF triples generated from a logical row will be stored in the specified named graph. Otherwise, the RDF triple generated using the (predicate, object) pair will be stored in the specified named graph.
    /// <see href="http://w3id.org/rml/graphMap"></see></summary>
    let graphMap = Namespaced_IRI.parse _namespace_name "graphMap" |> NamespacedName

    /// <summary>
    /// Specifies the join condition for joining the child logical source with the parent logical source of the foreign key constraint.
    /// <see href="http://w3id.org/rml/joinCondition"></see></summary>
    let joinCondition =
        Namespaced_IRI.parse _namespace_name "joinCondition" |> NamespacedName

    /// <summary>
    /// Specified the language for the object component for the generated triple.
    /// <see href="http://w3id.org/rml/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// A LanguagetMap element to generate the language tag of the object component from a logical source record.
    /// <see href="http://w3id.org/rml/languageMap"></see></summary>
    let languageMap =
        Namespaced_IRI.parse _namespace_name "languageMap" |> NamespacedName

    /// <summary>
    /// Represents the logical source to be mapped.
    /// <see href="http://w3id.org/rml/logicalSource"></see></summary>
    let logicalSource =
        Namespaced_IRI.parse _namespace_name "logicalSource" |> NamespacedName

    /// <summary>
    /// Represents the logical target to where triples are exported to.
    /// <see href="http://w3id.org/rml/logicalTarget"></see></summary>
    let logicalTarget =
        Namespaced_IRI.parse _namespace_name "logicalTarget" |> NamespacedName

    /// <summary>
    /// Specifies the object for the generated triple from the logical source record.
    /// <see href="http://w3id.org/rml/object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// An ObjectMap element to generate the object component of the (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/objectMap"></see></summary>
    let objectMap = Namespaced_IRI.parse _namespace_name "objectMap" |> NamespacedName
    /// <summary>
    /// Names a source record in the parent source of a join.
    /// <see href="http://w3id.org/rml/parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// Names a parent map in the parent source of a join.
    /// <see href="http://w3id.org/rml/parentMap"></see></summary>
    let parentMap = Namespaced_IRI.parse _namespace_name "parentMap" |> NamespacedName

    /// <summary>
    /// Specifies the TriplesMap element corresponding to the parent logical source of the foreign key constraint.
    /// <see href="http://w3id.org/rml/parentTriplesMap"></see></summary>
    let parentTriplesMap =
        Namespaced_IRI.parse _namespace_name "parentTriplesMap" |> NamespacedName

    /// <summary>
    /// Specifies the predicate for the generated triple from the logical source record.
    /// <see href="http://w3id.org/rml/predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName

    /// <summary>
    /// A PredicateMap element to generate the predicate component of the (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/predicateMap"></see></summary>
    let predicateMap =
        Namespaced_IRI.parse _namespace_name "predicateMap" |> NamespacedName

    /// <summary>
    /// A PredicateObjectMap element to generate (predicate, object) pair from a logical source record.
    /// <see href="http://w3id.org/rml/predicateObjectMap"></see></summary>
    let predicateObjectMap =
        Namespaced_IRI.parse _namespace_name "predicateObjectMap" |> NamespacedName

    /// <summary>
    /// A valid expression that selects values from the source data. The reference should conform to the syntax rules/grammar of the specified Reference Formulation.
    /// <see href="http://w3id.org/rml/reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName
    /// <summary>
    /// A Strategy element to indicate how to perform an action (e.g. gather for collections and containers, join).
    /// <see href="http://w3id.org/rml/strategy"></see></summary>
    let strategy = Namespaced_IRI.parse _namespace_name "strategy" |> NamespacedName
    /// <summary>
    /// An IRI reference for use as subject for all the RDF triples generated from a logical source record.
    /// <see href="http://w3id.org/rml/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// A SubjectMap element to generate a subject from a logical source record.
    /// <see href="http://w3id.org/rml/subjectMap"></see></summary>
    let subjectMap = Namespaced_IRI.parse _namespace_name "subjectMap" |> NamespacedName
    /// <summary>
    /// A template (format string) to specify how to generate a value for a expression map, using one or more records from a logical source record.
    /// <see href="http://w3id.org/rml/template"></see></summary>
    let template = Namespaced_IRI.parse _namespace_name "template" |> NamespacedName
    /// <summary>
    /// A string indicating whether subject or object generated using the value from a source record name specified should be an IRI reference, blank node, or a literal.
    /// <see href="http://w3id.org/rml/termType"></see></summary>
    let termType = Namespaced_IRI.parse _namespace_name "termType" |> NamespacedName
