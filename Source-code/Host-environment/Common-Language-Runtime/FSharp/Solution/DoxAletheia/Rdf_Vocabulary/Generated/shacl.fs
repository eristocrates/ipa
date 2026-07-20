namespace http.www.w3.org.ns.shacl.hash

open DoxAletheia

module shacl =
    let _namespace_name = "http://www.w3.org/ns/shacl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The prefix of a prefix declaration.
    /// <see href="http://www.w3.org/ns/shacl#prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// The namespace associated with a prefix in a prefix declaration.
    /// <see href="http://www.w3.org/ns/shacl#namespace"></see></summary>
    let namespace_ = _prefix "namespace"
    /// <summary>
    /// Links a resource with its namespace prefix declarations.
    /// <see href="http://www.w3.org/ns/shacl#declare"></see></summary>
    let declare = _prefix "declare"
    /// <summary>
    /// Suggested shapes graphs for this ontology. The values of this property may be used in the absence of specific sh:shapesGraph statements.
    /// <see href="http://www.w3.org/ns/shacl#suggestedShapesGraph"></see></summary>
    let suggestedShapesGraph = _prefix "suggestedShapesGraph"
    /// <summary>
    /// The base class of validation results, typically not instantiated directly.
    /// <see href="http://www.w3.org/ns/shacl#AbstractResult"></see></summary>
    let AbstractResult = _prefix "AbstractResult"
    /// <summary>
    /// A constraint component that can be used to test whether a value node conforms to all members of a provided list of shapes.
    /// <see href="http://www.w3.org/ns/shacl#AndConstraintComponent"></see></summary>
    let AndConstraintComponent = _prefix "AndConstraintComponent"
    /// <summary>
    /// The class of constraint components.
    /// <see href="http://www.w3.org/ns/shacl#ConstraintComponent"></see></summary>
    let ConstraintComponent = _prefix "ConstraintComponent"
    /// <summary>
    /// The parameters of a function or constraint component.
    /// <see href="http://www.w3.org/ns/shacl#parameter"></see></summary>
    let parameter = _prefix "parameter"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#AndConstraintComponent-and"></see>
    /// </summary>
    let ``AndConstraintComponent-and`` = _prefix "AndConstraintComponent-and"
    /// <summary>
    /// The class of parameter declarations, consisting of a path predicate and (possibly) information about allowed value type, cardinality and other characteristics.
    /// <see href="http://www.w3.org/ns/shacl#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// Specifies the property path of a property shape.
    /// <see href="http://www.w3.org/ns/shacl#path"></see></summary>
    let path = _prefix "path"
    /// <summary>
    /// RDF list of shapes to validate the value nodes against.
    /// <see href="http://www.w3.org/ns/shacl#and"></see></summary>
    let and_ = _prefix "and"
    /// <summary>
    /// The node kind of all blank nodes.
    /// <see href="http://www.w3.org/ns/shacl#BlankNode"></see></summary>
    let BlankNode = _prefix "BlankNode"
    /// <summary>
    /// The class of all node kinds, including sh:BlankNode, sh:IRI, sh:Literal or the combinations of these: sh:BlankNodeOrIRI, sh:BlankNodeOrLiteral, sh:IRIOrLiteral.
    /// <see href="http://www.w3.org/ns/shacl#NodeKind"></see></summary>
    let NodeKind = _prefix "NodeKind"
    /// <summary>
    /// The node kind of all blank nodes or IRIs.
    /// <see href="http://www.w3.org/ns/shacl#BlankNodeOrIRI"></see></summary>
    let BlankNodeOrIRI = _prefix "BlankNodeOrIRI"
    /// <summary>
    /// The node kind of all blank nodes or literals.
    /// <see href="http://www.w3.org/ns/shacl#BlankNodeOrLiteral"></see></summary>
    let BlankNodeOrLiteral = _prefix "BlankNodeOrLiteral"
    /// <summary>
    /// A constraint component that can be used to verify that each value node is an instance of a given type.
    /// <see href="http://www.w3.org/ns/shacl#ClassConstraintComponent"></see></summary>
    let ClassConstraintComponent = _prefix "ClassConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClassConstraintComponent-class"></see>
    /// </summary>
    let ``ClassConstraintComponent-class`` = _prefix "ClassConstraintComponent-class"
    /// <summary>
    /// Specifies the node kind (e.g. IRI or literal) each value node.
    /// <see href="http://www.w3.org/ns/shacl#nodeKind"></see></summary>
    let nodeKind = _prefix "nodeKind"
    /// <summary>
    /// The node kind of all IRIs.
    /// <see href="http://www.w3.org/ns/shacl#IRI"></see></summary>
    let IRI = _prefix "IRI"
    /// <summary>
    /// The type that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// A constraint component that can be used to indicate that focus nodes must only have values for those properties that have been explicitly enumerated via sh:property/sh:path.
    /// <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent"></see></summary>
    let ClosedConstraintComponent = _prefix "ClosedConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-closed"></see>
    /// </summary>
    let ``ClosedConstraintComponent-closed`` =
        _prefix "ClosedConstraintComponent-closed"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-ignoredProperties"></see>
    /// </summary>
    let ``ClosedConstraintComponent-ignoredProperties`` =
        _prefix "ClosedConstraintComponent-ignoredProperties"

    /// <summary>
    /// Specifies an RDF datatype that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// If set to true then the shape is closed.
    /// <see href="http://www.w3.org/ns/shacl#closed"></see></summary>
    let closed = _prefix "closed"
    /// <summary>
    /// Indicates whether a parameter is optional.
    /// <see href="http://www.w3.org/ns/shacl#optional"></see></summary>
    let optional = _prefix "optional"
    /// <summary>
    /// An optional RDF list of properties that are also permitted in addition to those explicitly enumerated via sh:property/sh:path.
    /// <see href="http://www.w3.org/ns/shacl#ignoredProperties"></see></summary>
    let ignoredProperties = _prefix "ignoredProperties"
    /// <summary>
    /// Superclass of components that can take parameters, especially functions and constraint components.
    /// <see href="http://www.w3.org/ns/shacl#Parameterizable"></see></summary>
    let Parameterizable = _prefix "Parameterizable"
    /// <summary>
    /// A constraint component that can be used to restrict the datatype of all value nodes.
    /// <see href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent"></see></summary>
    let DatatypeConstraintComponent = _prefix "DatatypeConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent-datatype"></see>
    /// </summary>
    let ``DatatypeConstraintComponent-datatype`` =
        _prefix "DatatypeConstraintComponent-datatype"

    /// <summary>
    /// Specifies the maximum number of values in the set of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#maxCount"></see></summary>
    let maxCount = _prefix "maxCount"
    /// <summary>
    /// A constraint component that can be used to verify that the set of value nodes is disjoint with the the set of nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#DisjointConstraintComponent"></see></summary>
    let DisjointConstraintComponent = _prefix "DisjointConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#DisjointConstraintComponent-disjoint"></see>
    /// </summary>
    let ``DisjointConstraintComponent-disjoint`` =
        _prefix "DisjointConstraintComponent-disjoint"

    /// <summary>
    /// Specifies a property where the set of values must be disjoint with the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#disjoint"></see></summary>
    let disjoint = _prefix "disjoint"
    /// <summary>
    /// A constraint component that can be used to verify that the set of value nodes is equal to the set of nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#EqualsConstraintComponent"></see></summary>
    let EqualsConstraintComponent = _prefix "EqualsConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#EqualsConstraintComponent-equals"></see>
    /// </summary>
    let ``EqualsConstraintComponent-equals`` =
        _prefix "EqualsConstraintComponent-equals"

    /// <summary>
    /// Specifies a property that must have the same values as the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#equals"></see></summary>
    let equals = _prefix "equals"
    /// <summary>
    /// A constraint component that can be used to verify that a given node expression produces true for all value nodes.
    /// <see href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent"></see></summary>
    let ExpressionConstraintComponent = _prefix "ExpressionConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent-expression"></see>
    /// </summary>
    let ``ExpressionConstraintComponent-expression`` =
        _prefix "ExpressionConstraintComponent-expression"

    /// <summary>
    /// The node expression that must return true for the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#expression"></see></summary>
    let expression = _prefix "expression"
    /// <summary>
    /// The class of SHACL functions.
    /// <see href="http://www.w3.org/ns/shacl#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// A constraint component that can be used to verify that one of the value nodes is a given RDF node.
    /// <see href="http://www.w3.org/ns/shacl#HasValueConstraintComponent"></see></summary>
    let HasValueConstraintComponent = _prefix "HasValueConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#HasValueConstraintComponent-hasValue"></see>
    /// </summary>
    let ``HasValueConstraintComponent-hasValue`` =
        _prefix "HasValueConstraintComponent-hasValue"

    /// <summary>
    /// Specifies a value that must be among the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// The node kind of all IRIs or literals.
    /// <see href="http://www.w3.org/ns/shacl#IRIOrLiteral"></see></summary>
    let IRIOrLiteral = _prefix "IRIOrLiteral"
    /// <summary>
    /// A constraint component that can be used to exclusively enumerate the permitted value nodes.
    /// <see href="http://www.w3.org/ns/shacl#InConstraintComponent"></see></summary>
    let InConstraintComponent = _prefix "InConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#InConstraintComponent-in"></see>
    /// </summary>
    let ``InConstraintComponent-in`` = _prefix "InConstraintComponent-in"
    /// <summary>
    /// Specifies a list of allowed values so that each value node must be among the members of the given list.
    /// <see href="http://www.w3.org/ns/shacl#in"></see></summary>
    let in_ = _prefix "in"
    /// <summary>
    /// The severity for an informational validation result.
    /// <see href="http://www.w3.org/ns/shacl#Info"></see></summary>
    let Info = _prefix "Info"
    /// <summary>
    /// The class of validation result severity levels, including violation and warning levels.
    /// <see href="http://www.w3.org/ns/shacl#Severity"></see></summary>
    let Severity = _prefix "Severity"
    /// <summary>
    /// The class of constraints backed by a JavaScript function.
    /// <see href="http://www.w3.org/ns/shacl#JSConstraint"></see></summary>
    let JSConstraint = _prefix "JSConstraint"
    /// <summary>
    /// Abstract base class of resources that declare an executable JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#JSExecutable"></see></summary>
    let JSExecutable = _prefix "JSExecutable"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#JSConstraint-js"></see>
    /// </summary>
    let ``JSConstraint-js`` = _prefix "JSConstraint-js"
    /// <summary>
    /// Constraints expressed in JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#js"></see></summary>
    let js = _prefix "js"
    /// <summary>
    /// A constraint component with the parameter sh:js linking to a sh:JSConstraint containing a sh:script.
    /// <see href="http://www.w3.org/ns/shacl#JSConstraintComponent"></see></summary>
    let JSConstraintComponent = _prefix "JSConstraintComponent"
    /// <summary>
    /// The class of SHACL functions that execute a JavaScript function when called.
    /// <see href="http://www.w3.org/ns/shacl#JSFunction"></see></summary>
    let JSFunction = _prefix "JSFunction"
    /// <summary>
    /// Represents a JavaScript library, typically identified by one or more URLs of files to include.
    /// <see href="http://www.w3.org/ns/shacl#JSLibrary"></see></summary>
    let JSLibrary = _prefix "JSLibrary"
    /// <summary>
    /// The class of SHACL rules expressed using JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#JSRule"></see></summary>
    let JSRule = _prefix "JSRule"
    /// <summary>
    /// The class of SHACL rules. Never instantiated directly.
    /// <see href="http://www.w3.org/ns/shacl#Rule"></see></summary>
    let Rule = _prefix "Rule"
    /// <summary>
    /// The class of targets that are based on JavaScript functions.
    /// <see href="http://www.w3.org/ns/shacl#JSTarget"></see></summary>
    let JSTarget = _prefix "JSTarget"
    /// <summary>
    /// The base class of targets such as those based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#Target"></see></summary>
    let Target = _prefix "Target"
    /// <summary>
    /// The (meta) class for parameterizable targets that are based on JavaScript functions.
    /// <see href="http://www.w3.org/ns/shacl#JSTargetType"></see></summary>
    let JSTargetType = _prefix "JSTargetType"
    /// <summary>
    /// The (meta) class for parameterizable targets.	Instances of this are instantiated as values of the sh:target property.
    /// <see href="http://www.w3.org/ns/shacl#TargetType"></see></summary>
    let TargetType = _prefix "TargetType"
    /// <summary>
    /// A SHACL validator based on JavaScript. This can be used to declare SHACL constraint components that perform JavaScript-based validation when used.
    /// <see href="http://www.w3.org/ns/shacl#JSValidator"></see></summary>
    let JSValidator = _prefix "JSValidator"
    /// <summary>
    /// The class of validators, which provide instructions on how to process a constraint definition. This class serves as base class for the SPARQL-based validators and other possible implementations.
    /// <see href="http://www.w3.org/ns/shacl#Validator"></see></summary>
    let Validator = _prefix "Validator"
    /// <summary>
    /// A constraint component that can be used to enumerate language tags that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent"></see></summary>
    let LanguageInConstraintComponent = _prefix "LanguageInConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent-languageIn"></see>
    /// </summary>
    let ``LanguageInConstraintComponent-languageIn`` =
        _prefix "LanguageInConstraintComponent-languageIn"

    /// <summary>
    /// Specifies a list of language tags that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#languageIn"></see></summary>
    let languageIn = _prefix "languageIn"
    /// <summary>
    /// A constraint component that can be used to verify that each value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#LessThanConstraintComponent"></see></summary>
    let LessThanConstraintComponent = _prefix "LessThanConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LessThanConstraintComponent-lessThan"></see>
    /// </summary>
    let ``LessThanConstraintComponent-lessThan`` =
        _prefix "LessThanConstraintComponent-lessThan"

    /// <summary>
    /// Specifies a property that must have smaller values than the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#lessThan"></see></summary>
    let lessThan = _prefix "lessThan"

    /// <summary>
    /// A constraint component that can be used to verify that every value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent"></see></summary>
    let LessThanOrEqualsConstraintComponent =
        _prefix "LessThanOrEqualsConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent-lessThanOrEquals"></see>
    /// </summary>
    let ``LessThanOrEqualsConstraintComponent-lessThanOrEquals`` =
        _prefix "LessThanOrEqualsConstraintComponent-lessThanOrEquals"

    /// <summary>
    /// Specifies a property that must have smaller or equal values than the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#lessThanOrEquals"></see></summary>
    let lessThanOrEquals = _prefix "lessThanOrEquals"
    /// <summary>
    /// The node kind of all literals.
    /// <see href="http://www.w3.org/ns/shacl#Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    /// A constraint component that can be used to restrict the maximum number of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent"></see></summary>
    let MaxCountConstraintComponent = _prefix "MaxCountConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent-maxCount"></see>
    /// </summary>
    let ``MaxCountConstraintComponent-maxCount`` =
        _prefix "MaxCountConstraintComponent-maxCount"

    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a maximum exclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent"></see></summary>
    let MaxExclusiveConstraintComponent = _prefix "MaxExclusiveConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent-maxExclusive"></see>
    /// </summary>
    let ``MaxExclusiveConstraintComponent-maxExclusive`` =
        _prefix "MaxExclusiveConstraintComponent-maxExclusive"

    /// <summary>
    /// Specifies the maximum exclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxExclusive"></see></summary>
    let maxExclusive = _prefix "maxExclusive"
    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a maximum inclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent"></see></summary>
    let MaxInclusiveConstraintComponent = _prefix "MaxInclusiveConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent-maxInclusive"></see>
    /// </summary>
    let ``MaxInclusiveConstraintComponent-maxInclusive`` =
        _prefix "MaxInclusiveConstraintComponent-maxInclusive"

    /// <summary>
    /// Specifies the maximum inclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxInclusive"></see></summary>
    let maxInclusive = _prefix "maxInclusive"
    /// <summary>
    /// A constraint component that can be used to restrict the maximum string length of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent"></see></summary>
    let MaxLengthConstraintComponent = _prefix "MaxLengthConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent-maxLength"></see>
    /// </summary>
    let ``MaxLengthConstraintComponent-maxLength`` =
        _prefix "MaxLengthConstraintComponent-maxLength"

    /// <summary>
    /// Specifies the maximum string length of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxLength"></see></summary>
    let maxLength = _prefix "maxLength"
    /// <summary>
    /// A constraint component that can be used to restrict the minimum number of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MinCountConstraintComponent"></see></summary>
    let MinCountConstraintComponent = _prefix "MinCountConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinCountConstraintComponent-minCount"></see>
    /// </summary>
    let ``MinCountConstraintComponent-minCount`` =
        _prefix "MinCountConstraintComponent-minCount"

    /// <summary>
    /// Specifies the minimum number of values in the set of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#minCount"></see></summary>
    let minCount = _prefix "minCount"
    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a minimum exclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent"></see></summary>
    let MinExclusiveConstraintComponent = _prefix "MinExclusiveConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent-minExclusive"></see>
    /// </summary>
    let ``MinExclusiveConstraintComponent-minExclusive`` =
        _prefix "MinExclusiveConstraintComponent-minExclusive"

    /// <summary>
    /// Specifies the minimum exclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minExclusive"></see></summary>
    let minExclusive = _prefix "minExclusive"
    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a minimum inclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent"></see></summary>
    let MinInclusiveConstraintComponent = _prefix "MinInclusiveConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent-minInclusive"></see>
    /// </summary>
    let ``MinInclusiveConstraintComponent-minInclusive`` =
        _prefix "MinInclusiveConstraintComponent-minInclusive"

    /// <summary>
    /// Specifies the minimum inclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minInclusive"></see></summary>
    let minInclusive = _prefix "minInclusive"
    /// <summary>
    /// A constraint component that can be used to restrict the minimum string length of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent"></see></summary>
    let MinLengthConstraintComponent = _prefix "MinLengthConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent-minLength"></see>
    /// </summary>
    let ``MinLengthConstraintComponent-minLength`` =
        _prefix "MinLengthConstraintComponent-minLength"

    /// <summary>
    /// Specifies the minimum string length of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minLength"></see></summary>
    let minLength = _prefix "minLength"
    /// <summary>
    /// A constraint component that can be used to verify that all value nodes conform to the given node shape.
    /// <see href="http://www.w3.org/ns/shacl#NodeConstraintComponent"></see></summary>
    let NodeConstraintComponent = _prefix "NodeConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NodeConstraintComponent-node"></see>
    /// </summary>
    let ``NodeConstraintComponent-node`` = _prefix "NodeConstraintComponent-node"
    /// <summary>
    /// Specifies the node shape that all value nodes must conform to.
    /// <see href="http://www.w3.org/ns/shacl#node"></see></summary>
    let node = _prefix "node"
    /// <summary>
    /// A constraint component that can be used to restrict the RDF node kind of each value node.
    /// <see href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent"></see></summary>
    let NodeKindConstraintComponent = _prefix "NodeKindConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent-nodeKind"></see>
    /// </summary>
    let ``NodeKindConstraintComponent-nodeKind`` =
        _prefix "NodeKindConstraintComponent-nodeKind"

    /// <summary>
    /// A node shape is a shape that specifies constraint that need to be met with respect to focus nodes.
    /// <see href="http://www.w3.org/ns/shacl#NodeShape"></see></summary>
    let NodeShape = _prefix "NodeShape"
    /// <summary>
    /// A shape is a collection of constraints that may be targeted for certain nodes.
    /// <see href="http://www.w3.org/ns/shacl#Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    /// A constraint component that can be used to verify that value nodes do not conform to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#NotConstraintComponent"></see></summary>
    let NotConstraintComponent = _prefix "NotConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NotConstraintComponent-not"></see>
    /// </summary>
    let ``NotConstraintComponent-not`` = _prefix "NotConstraintComponent-not"
    /// <summary>
    /// Specifies a shape that the value nodes must not conform to.
    /// <see href="http://www.w3.org/ns/shacl#not"></see></summary>
    let ``not`` = _prefix "not"
    /// <summary>
    /// A constraint component that can be used to restrict the value nodes so that they conform to at least one out of several provided shapes.
    /// <see href="http://www.w3.org/ns/shacl#OrConstraintComponent"></see></summary>
    let OrConstraintComponent = _prefix "OrConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#OrConstraintComponent-or"></see>
    /// </summary>
    let ``OrConstraintComponent-or`` = _prefix "OrConstraintComponent-or"
    /// <summary>
    /// Specifies a list of shapes so that the value nodes must conform to at least one of the shapes.
    /// <see href="http://www.w3.org/ns/shacl#or"></see></summary>
    let or_ = _prefix "or"
    /// <summary>
    /// A property shape is a shape that specifies constraints on the values of a focus node for a given property or path.
    /// <see href="http://www.w3.org/ns/shacl#PropertyShape"></see></summary>
    let PropertyShape = _prefix "PropertyShape"
    /// <summary>
    /// A constraint component that can be used to verify that every value node matches a given regular expression.
    /// <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent"></see></summary>
    let PatternConstraintComponent = _prefix "PatternConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent-pattern"></see>
    /// </summary>
    let ``PatternConstraintComponent-pattern`` =
        _prefix "PatternConstraintComponent-pattern"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent-flags"></see>
    /// </summary>
    let ``PatternConstraintComponent-flags`` =
        _prefix "PatternConstraintComponent-flags"

    /// <summary>
    /// An optional flag to be used with regular expression pattern matching.
    /// <see href="http://www.w3.org/ns/shacl#flags"></see></summary>
    let flags = _prefix "flags"
    /// <summary>
    /// Specifies a regular expression pattern that the string representations of the value nodes must match.
    /// <see href="http://www.w3.org/ns/shacl#pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// The class of prefix declarations, consisting of pairs of a prefix with a namespace.
    /// <see href="http://www.w3.org/ns/shacl#PrefixDeclaration"></see></summary>
    let PrefixDeclaration = _prefix "PrefixDeclaration"
    /// <summary>
    /// A constraint component that can be used to verify that all value nodes conform to the given property shape.
    /// <see href="http://www.w3.org/ns/shacl#PropertyConstraintComponent"></see></summary>
    let PropertyConstraintComponent = _prefix "PropertyConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PropertyConstraintComponent-property"></see>
    /// </summary>
    let ``PropertyConstraintComponent-property`` =
        _prefix "PropertyConstraintComponent-property"

    /// <summary>
    /// Links a shape to its property shapes.
    /// <see href="http://www.w3.org/ns/shacl#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// Instances of this class represent groups of property shapes that belong together.
    /// <see href="http://www.w3.org/ns/shacl#PropertyGroup"></see></summary>
    let PropertyGroup = _prefix "PropertyGroup"

    /// <summary>
    /// A constraint component that can be used to verify that a specified maximum number of value nodes conforms to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent"></see></summary>
    let QualifiedMaxCountConstraintComponent =
        _prefix "QualifiedMaxCountConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedMaxCount"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedMaxCount`` =
        _prefix "QualifiedMaxCountConstraintComponent-qualifiedMaxCount"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShape"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedValueShape`` =
        _prefix "QualifiedMaxCountConstraintComponent-qualifiedValueShape"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint`` =
        _prefix "QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint"

    /// <summary>
    /// The maximum number of value nodes that can conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedMaxCount"></see></summary>
    let qualifiedMaxCount = _prefix "qualifiedMaxCount"
    /// <summary>
    /// The shape that a specified number of values must conform to.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedValueShape"></see></summary>
    let qualifiedValueShape = _prefix "qualifiedValueShape"
    /// <summary>
    /// Can be used to mark the qualified value shape to be disjoint with its sibling shapes.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedValueShapesDisjoint"></see></summary>
    let qualifiedValueShapesDisjoint = _prefix "qualifiedValueShapesDisjoint"

    /// <summary>
    /// A constraint component that can be used to verify that a specified minimum number of value nodes conforms to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent"></see></summary>
    let QualifiedMinCountConstraintComponent =
        _prefix "QualifiedMinCountConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedMinCount"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedMinCount`` =
        _prefix "QualifiedMinCountConstraintComponent-qualifiedMinCount"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShape"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedValueShape`` =
        _prefix "QualifiedMinCountConstraintComponent-qualifiedValueShape"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint`` =
        _prefix "QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint"

    /// <summary>
    /// The minimum number of value nodes that must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedMinCount"></see></summary>
    let qualifiedMinCount = _prefix "qualifiedMinCount"
    /// <summary>
    /// A class of result annotations, which define the rules to derive the values of a given annotation property as extra values for a validation result.
    /// <see href="http://www.w3.org/ns/shacl#ResultAnnotation"></see></summary>
    let ResultAnnotation = _prefix "ResultAnnotation"
    /// <summary>
    /// The class of SPARQL executables that are based on an ASK query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLAskExecutable"></see></summary>
    let SPARQLAskExecutable = _prefix "SPARQLAskExecutable"
    /// <summary>
    /// The class of resources that encapsulate a SPARQL query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLExecutable"></see></summary>
    let SPARQLExecutable = _prefix "SPARQLExecutable"
    /// <summary>
    /// The class of validators based on SPARQL ASK queries. The queries are evaluated for each value node and are supposed to return true if the given node conforms.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLAskValidator"></see></summary>
    let SPARQLAskValidator = _prefix "SPARQLAskValidator"
    /// <summary>
    /// The class of constraints based on SPARQL SELECT queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstraint"></see></summary>
    let SPARQLConstraint = _prefix "SPARQLConstraint"
    /// <summary>
    /// The class of SPARQL executables based on a SELECT query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLSelectExecutable"></see></summary>
    let SPARQLSelectExecutable = _prefix "SPARQLSelectExecutable"
    /// <summary>
    /// A constraint component that can be used to define constraints based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent"></see></summary>
    let SPARQLConstraintComponent = _prefix "SPARQLConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent-sparql"></see>
    /// </summary>
    let ``SPARQLConstraintComponent-sparql`` =
        _prefix "SPARQLConstraintComponent-sparql"

    /// <summary>
    /// Links a shape with SPARQL constraints.
    /// <see href="http://www.w3.org/ns/shacl#sparql"></see></summary>
    let sparql = _prefix "sparql"
    /// <summary>
    /// The class of SPARQL executables that are based on a CONSTRUCT query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstructExecutable"></see></summary>
    let SPARQLConstructExecutable = _prefix "SPARQLConstructExecutable"
    /// <summary>
    /// A function backed by a SPARQL query - either ASK or SELECT.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLFunction"></see></summary>
    let SPARQLFunction = _prefix "SPARQLFunction"
    /// <summary>
    /// The class of SHACL rules based on SPARQL CONSTRUCT queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLRule"></see></summary>
    let SPARQLRule = _prefix "SPARQLRule"
    /// <summary>
    /// The class of validators based on SPARQL SELECT queries. The queries are evaluated for each focus node and are supposed to produce bindings for all focus nodes that do not conform.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLSelectValidator"></see></summary>
    let SPARQLSelectValidator = _prefix "SPARQLSelectValidator"
    /// <summary>
    /// The class of targets that are based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLTarget"></see></summary>
    let SPARQLTarget = _prefix "SPARQLTarget"
    /// <summary>
    /// The (meta) class for parameterizable targets that are based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLTargetType"></see></summary>
    let SPARQLTargetType = _prefix "SPARQLTargetType"
    /// <summary>
    /// The class of SPARQL executables based on a SPARQL UPDATE.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLUpdateExecutable"></see></summary>
    let SPARQLUpdateExecutable = _prefix "SPARQLUpdateExecutable"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#TripleRule"></see>
    /// </summary>
    let TripleRule = _prefix "TripleRule"
    /// <summary>
    /// A constraint component that can be used to specify that no pair of value nodes may use the same language tag.
    /// <see href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent"></see></summary>
    let UniqueLangConstraintComponent = _prefix "UniqueLangConstraintComponent"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent-uniqueLang"></see>
    /// </summary>
    let ``UniqueLangConstraintComponent-uniqueLang`` =
        _prefix "UniqueLangConstraintComponent-uniqueLang"

    /// <summary>
    /// Specifies whether all node values must have a unique (or no) language tag.
    /// <see href="http://www.w3.org/ns/shacl#uniqueLang"></see></summary>
    let uniqueLang = _prefix "uniqueLang"
    /// <summary>
    /// The class of SHACL validation reports.
    /// <see href="http://www.w3.org/ns/shacl#ValidationReport"></see></summary>
    let ValidationReport = _prefix "ValidationReport"
    /// <summary>
    /// The class of validation results.
    /// <see href="http://www.w3.org/ns/shacl#ValidationResult"></see></summary>
    let ValidationResult = _prefix "ValidationResult"
    /// <summary>
    /// The severity for a violation validation result.
    /// <see href="http://www.w3.org/ns/shacl#Violation"></see></summary>
    let Violation = _prefix "Violation"
    /// <summary>
    /// The severity for a warning validation result.
    /// <see href="http://www.w3.org/ns/shacl#Warning"></see></summary>
    let Warning = _prefix "Warning"
    /// <summary>
    /// A constraint component that can be used to restrict the value nodes so that they conform to exactly one out of several provided shapes.
    /// <see href="http://www.w3.org/ns/shacl#XoneConstraintComponent"></see></summary>
    let XoneConstraintComponent = _prefix "XoneConstraintComponent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#XoneConstraintComponent-xone"></see>
    /// </summary>
    let ``XoneConstraintComponent-xone`` = _prefix "XoneConstraintComponent-xone"
    /// <summary>
    /// Specifies a list of shapes so that the value nodes must conform to exactly one of the shapes.
    /// <see href="http://www.w3.org/ns/shacl#xone"></see></summary>
    let xone = _prefix "xone"
    /// <summary>
    /// The (single) value of this property must be a list of path elements, representing the elements of alternative paths.
    /// <see href="http://www.w3.org/ns/shacl#alternativePath"></see></summary>
    let alternativePath = _prefix "alternativePath"
    /// <summary>
    /// The annotation property that shall be set.
    /// <see href="http://www.w3.org/ns/shacl#annotationProperty"></see></summary>
    let annotationProperty = _prefix "annotationProperty"
    /// <summary>
    /// The (default) values of the annotation property.
    /// <see href="http://www.w3.org/ns/shacl#annotationValue"></see></summary>
    let annotationValue = _prefix "annotationValue"
    /// <summary>
    /// The name of the SPARQL variable from the SELECT clause that shall be used for the values.
    /// <see href="http://www.w3.org/ns/shacl#annotationVarName"></see></summary>
    let annotationVarName = _prefix "annotationVarName"
    /// <summary>
    /// The SPARQL ASK query to execute.
    /// <see href="http://www.w3.org/ns/shacl#ask"></see></summary>
    let ask = _prefix "ask"
    /// <summary>
    /// The shapes that the focus nodes need to conform to before a rule is executed on them.
    /// <see href="http://www.w3.org/ns/shacl#condition"></see></summary>
    let condition = _prefix "condition"
    /// <summary>
    /// True if the validation did not produce any validation results, and false otherwise.
    /// <see href="http://www.w3.org/ns/shacl#conforms"></see></summary>
    let conforms = _prefix "conforms"
    /// <summary>
    /// The SPARQL CONSTRUCT query to execute.
    /// <see href="http://www.w3.org/ns/shacl#construct"></see></summary>
    let construct = _prefix "construct"
    /// <summary>
    /// If set to true then all nodes conform to this.
    /// <see href="http://www.w3.org/ns/shacl#deactivated"></see></summary>
    let deactivated = _prefix "deactivated"
    /// <summary>
    /// A default value for a property, for example for user interface tools to pre-populate input fields.
    /// <see href="http://www.w3.org/ns/shacl#defaultValue"></see></summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// Human-readable descriptions for the property in the context of the surrounding shape.
    /// <see href="http://www.w3.org/ns/shacl#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Links a result with other results that provide more details, for example to describe violations against nested shapes.
    /// <see href="http://www.w3.org/ns/shacl#detail"></see></summary>
    let detail = _prefix "detail"
    /// <summary>
    /// An entailment regime that indicates what kind of inferencing is required by a shapes graph.
    /// <see href="http://www.w3.org/ns/shacl#entailment"></see></summary>
    let entailment = _prefix "entailment"
    /// <summary>
    /// The shape that all input nodes of the expression need to conform to.
    /// <see href="http://www.w3.org/ns/shacl#filterShape"></see></summary>
    let filterShape = _prefix "filterShape"
    /// <summary>
    /// The focus node that was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#focusNode"></see></summary>
    let focusNode = _prefix "focusNode"
    /// <summary>
    /// Can be used to link to a property group to indicate that a property shape belongs to a group of related property shapes.
    /// <see href="http://www.w3.org/ns/shacl#group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    /// A list of node expressions that shall be intersected.
    /// <see href="http://www.w3.org/ns/shacl#intersection"></see></summary>
    let intersection = _prefix "intersection"
    /// <summary>
    /// The (single) value of this property represents an inverse path (object to subject).
    /// <see href="http://www.w3.org/ns/shacl#inversePath"></see></summary>
    let inversePath = _prefix "inversePath"
    /// <summary>
    /// The name of the JavaScript function to execute.
    /// <see href="http://www.w3.org/ns/shacl#jsFunctionName"></see></summary>
    let jsFunctionName = _prefix "jsFunctionName"
    /// <summary>
    /// Declares which JavaScript libraries are needed to execute this.
    /// <see href="http://www.w3.org/ns/shacl#jsLibrary"></see></summary>
    let jsLibrary = _prefix "jsLibrary"
    /// <summary>
    /// Declares the URLs of a JavaScript library. This should be the absolute URL of a JavaScript file. Implementations may redirect those to local files.
    /// <see href="http://www.w3.org/ns/shacl#jsLibraryURL"></see></summary>
    let jsLibraryURL = _prefix "jsLibraryURL"
    /// <summary>
    /// Outlines how human-readable labels of instances of the associated Parameterizable shall be produced. The values can contain {?paramName} as placeholders for the actual values of the given parameter.
    /// <see href="http://www.w3.org/ns/shacl#labelTemplate"></see></summary>
    let labelTemplate = _prefix "labelTemplate"
    /// <summary>
    /// A human-readable message (possibly with placeholders for variables) explaining the cause of the result.
    /// <see href="http://www.w3.org/ns/shacl#message"></see></summary>
    let message = _prefix "message"
    /// <summary>
    /// Human-readable labels for the property in the context of the surrounding shape.
    /// <see href="http://www.w3.org/ns/shacl#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The validator(s) used to evaluate a constraint in the context of a node shape.
    /// <see href="http://www.w3.org/ns/shacl#nodeValidator"></see></summary>
    let nodeValidator = _prefix "nodeValidator"
    /// <summary>
    /// The node expression producing the input nodes of a filter shape expression.
    /// <see href="http://www.w3.org/ns/shacl#nodes"></see></summary>
    let nodes = _prefix "nodes"
    /// <summary>
    /// An expression producing the nodes that shall be inferred as objects.
    /// <see href="http://www.w3.org/ns/shacl#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The (single) value of this property represents a path that is matched one or more times.
    /// <see href="http://www.w3.org/ns/shacl#oneOrMorePath"></see></summary>
    let oneOrMorePath = _prefix "oneOrMorePath"
    /// <summary>
    /// Specifies the relative order of this compared to its siblings. For example use 0 for the first, 1 for the second.
    /// <see href="http://www.w3.org/ns/shacl#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// An expression producing the properties that shall be inferred as predicates.
    /// <see href="http://www.w3.org/ns/shacl#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// The prefixes that shall be applied before parsing the associated SPARQL query.
    /// <see href="http://www.w3.org/ns/shacl#prefixes"></see></summary>
    let prefixes = _prefix "prefixes"
    /// <summary>
    /// The validator(s) used to evaluate a constraint in the context of a property shape.
    /// <see href="http://www.w3.org/ns/shacl#propertyValidator"></see></summary>
    let propertyValidator = _prefix "propertyValidator"
    /// <summary>
    /// The validation results contained in a validation report.
    /// <see href="http://www.w3.org/ns/shacl#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// Links a SPARQL validator with zero or more sh:ResultAnnotation instances, defining how to derive additional result properties based on the variables of the SELECT query.
    /// <see href="http://www.w3.org/ns/shacl#resultAnnotation"></see></summary>
    let resultAnnotation = _prefix "resultAnnotation"
    /// <summary>
    /// Human-readable messages explaining the cause of the result.
    /// <see href="http://www.w3.org/ns/shacl#resultMessage"></see></summary>
    let resultMessage = _prefix "resultMessage"
    /// <summary>
    /// The path of a validation result, based on the path of the validated property shape.
    /// <see href="http://www.w3.org/ns/shacl#resultPath"></see></summary>
    let resultPath = _prefix "resultPath"
    /// <summary>
    /// The severity of the result, e.g. warning.
    /// <see href="http://www.w3.org/ns/shacl#resultSeverity"></see></summary>
    let resultSeverity = _prefix "resultSeverity"
    /// <summary>
    /// The expected type of values returned by the associated function.
    /// <see href="http://www.w3.org/ns/shacl#returnType"></see></summary>
    let returnType = _prefix "returnType"
    /// <summary>
    /// The rules linked to a shape.
    /// <see href="http://www.w3.org/ns/shacl#rule"></see></summary>
    let rule = _prefix "rule"
    /// <summary>
    /// The SPARQL SELECT query to execute.
    /// <see href="http://www.w3.org/ns/shacl#select"></see></summary>
    let select = _prefix "select"
    /// <summary>
    /// Defines the severity that validation results produced by a shape must have. Defaults to sh:Violation.
    /// <see href="http://www.w3.org/ns/shacl#severity"></see></summary>
    let severity = _prefix "severity"
    /// <summary>
    /// Shapes graphs that should be used when validating this data graph.
    /// <see href="http://www.w3.org/ns/shacl#shapesGraph"></see></summary>
    let shapesGraph = _prefix "shapesGraph"
    /// <summary>
    /// If true then the validation engine was certain that the shapes graph has passed all SHACL syntax requirements during the validation process.
    /// <see href="http://www.w3.org/ns/shacl#shapesGraphWellFormed"></see></summary>
    let shapesGraphWellFormed = _prefix "shapesGraphWellFormed"
    /// <summary>
    /// The constraint that was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#sourceConstraint"></see></summary>
    let sourceConstraint = _prefix "sourceConstraint"
    /// <summary>
    /// The constraint component that is the source of the result.
    /// <see href="http://www.w3.org/ns/shacl#sourceConstraintComponent"></see></summary>
    let sourceConstraintComponent = _prefix "sourceConstraintComponent"
    /// <summary>
    /// The shape that is was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#sourceShape"></see></summary>
    let sourceShape = _prefix "sourceShape"
    /// <summary>
    /// An expression producing the resources that shall be inferred as subjects.
    /// <see href="http://www.w3.org/ns/shacl#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Links a shape to a target specified by an extension language, for example instances of sh:SPARQLTarget.
    /// <see href="http://www.w3.org/ns/shacl#target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// Links a shape to a class, indicating that all instances of the class must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetClass"></see></summary>
    let targetClass = _prefix "targetClass"
    /// <summary>
    /// Links a shape to individual nodes, indicating that these nodes must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetNode"></see></summary>
    let targetNode = _prefix "targetNode"
    /// <summary>
    /// Links a shape to a property, indicating that all all objects of triples that have the given property as their predicate must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetObjectsOf"></see></summary>
    let targetObjectsOf = _prefix "targetObjectsOf"
    /// <summary>
    /// Links a shape to a property, indicating that all subjects of triples that have the given property as their predicate must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetSubjectsOf"></see></summary>
    let targetSubjectsOf = _prefix "targetSubjectsOf"
    /// <summary>
    /// A node expression that represents the current focus node.
    /// <see href="http://www.w3.org/ns/shacl#this"></see></summary>
    let this = _prefix "this"
    /// <summary>
    /// A list of node expressions that shall be used together.
    /// <see href="http://www.w3.org/ns/shacl#union"></see></summary>
    let union = _prefix "union"
    /// <summary>
    /// The SPARQL UPDATE to execute.
    /// <see href="http://www.w3.org/ns/shacl#update"></see></summary>
    let update = _prefix "update"
    /// <summary>
    /// The validator(s) used to evaluate constraints of either node or property shapes.
    /// <see href="http://www.w3.org/ns/shacl#validator"></see></summary>
    let validator = _prefix "validator"
    /// <summary>
    /// An RDF node that has caused the result.
    /// <see href="http://www.w3.org/ns/shacl#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// The (single) value of this property represents a path that is matched zero or more times.
    /// <see href="http://www.w3.org/ns/shacl#zeroOrMorePath"></see></summary>
    let zeroOrMorePath = _prefix "zeroOrMorePath"
    /// <summary>
    /// The (single) value of this property represents a path that is matched zero or one times.
    /// <see href="http://www.w3.org/ns/shacl#zeroOrOnePath"></see></summary>
    let zeroOrOnePath = _prefix "zeroOrOnePath"
