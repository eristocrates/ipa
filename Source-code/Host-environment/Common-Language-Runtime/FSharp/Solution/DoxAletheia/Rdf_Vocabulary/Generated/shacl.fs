namespace http.www.w3.org.ns.shacl.hash

open DoxAletheia.Rdf_Vocabulary

module shacl =
    let _namespace_name = "http://www.w3.org/ns/shacl#"
    /// <summary>
    /// The prefix of a prefix declaration.
    /// <see href="http://www.w3.org/ns/shacl#prefix"></see></summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    /// The namespace associated with a prefix in a prefix declaration.
    /// <see href="http://www.w3.org/ns/shacl#namespace"></see></summary>
    let namespace_ = Namespaced_IRI.parse _namespace_name "namespace" |> NamespacedName
    /// <summary>
    /// Links a resource with its namespace prefix declarations.
    /// <see href="http://www.w3.org/ns/shacl#declare"></see></summary>
    let declare = Namespaced_IRI.parse _namespace_name "declare" |> NamespacedName

    /// <summary>
    /// Suggested shapes graphs for this ontology. The values of this property may be used in the absence of specific sh:shapesGraph statements.
    /// <see href="http://www.w3.org/ns/shacl#suggestedShapesGraph"></see></summary>
    let suggestedShapesGraph =
        Namespaced_IRI.parse _namespace_name "suggestedShapesGraph" |> NamespacedName

    /// <summary>
    /// The base class of validation results, typically not instantiated directly.
    /// <see href="http://www.w3.org/ns/shacl#AbstractResult"></see></summary>
    let AbstractResult =
        Namespaced_IRI.parse _namespace_name "AbstractResult" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to test whether a value node conforms to all members of a provided list of shapes.
    /// <see href="http://www.w3.org/ns/shacl#AndConstraintComponent"></see></summary>
    let AndConstraintComponent =
        Namespaced_IRI.parse _namespace_name "AndConstraintComponent" |> NamespacedName

    /// <summary>
    /// The class of constraint components.
    /// <see href="http://www.w3.org/ns/shacl#ConstraintComponent"></see></summary>
    let ConstraintComponent =
        Namespaced_IRI.parse _namespace_name "ConstraintComponent" |> NamespacedName

    /// <summary>
    /// The parameters of a function or constraint component.
    /// <see href="http://www.w3.org/ns/shacl#parameter"></see></summary>
    let parameter = Namespaced_IRI.parse _namespace_name "parameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#AndConstraintComponent-and"></see>
    /// </summary>
    let ``AndConstraintComponent-and`` =
        Namespaced_IRI.parse _namespace_name "AndConstraintComponent-and" |> NamespacedName

    /// <summary>
    /// The class of parameter declarations, consisting of a path predicate and (possibly) information about allowed value type, cardinality and other characteristics.
    /// <see href="http://www.w3.org/ns/shacl#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName
    /// <summary>
    /// Specifies the property path of a property shape.
    /// <see href="http://www.w3.org/ns/shacl#path"></see></summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    /// RDF list of shapes to validate the value nodes against.
    /// <see href="http://www.w3.org/ns/shacl#and"></see></summary>
    let and_ = Namespaced_IRI.parse _namespace_name "and" |> NamespacedName
    /// <summary>
    /// The node kind of all blank nodes.
    /// <see href="http://www.w3.org/ns/shacl#BlankNode"></see></summary>
    let BlankNode = Namespaced_IRI.parse _namespace_name "BlankNode" |> NamespacedName
    /// <summary>
    /// The class of all node kinds, including sh:BlankNode, sh:IRI, sh:Literal or the combinations of these: sh:BlankNodeOrIRI, sh:BlankNodeOrLiteral, sh:IRIOrLiteral.
    /// <see href="http://www.w3.org/ns/shacl#NodeKind"></see></summary>
    let NodeKind = Namespaced_IRI.parse _namespace_name "NodeKind" |> NamespacedName

    /// <summary>
    /// The node kind of all blank nodes or IRIs.
    /// <see href="http://www.w3.org/ns/shacl#BlankNodeOrIRI"></see></summary>
    let BlankNodeOrIRI =
        Namespaced_IRI.parse _namespace_name "BlankNodeOrIRI" |> NamespacedName

    /// <summary>
    /// The node kind of all blank nodes or literals.
    /// <see href="http://www.w3.org/ns/shacl#BlankNodeOrLiteral"></see></summary>
    let BlankNodeOrLiteral =
        Namespaced_IRI.parse _namespace_name "BlankNodeOrLiteral" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that each value node is an instance of a given type.
    /// <see href="http://www.w3.org/ns/shacl#ClassConstraintComponent"></see></summary>
    let ClassConstraintComponent =
        Namespaced_IRI.parse _namespace_name "ClassConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClassConstraintComponent-class"></see>
    /// </summary>
    let ``ClassConstraintComponent-class`` =
        Namespaced_IRI.parse _namespace_name "ClassConstraintComponent-class" |> NamespacedName

    /// <summary>
    /// Specifies the node kind (e.g. IRI or literal) each value node.
    /// <see href="http://www.w3.org/ns/shacl#nodeKind"></see></summary>
    let nodeKind = Namespaced_IRI.parse _namespace_name "nodeKind" |> NamespacedName
    /// <summary>
    /// The node kind of all IRIs.
    /// <see href="http://www.w3.org/ns/shacl#IRI"></see></summary>
    let IRI = Namespaced_IRI.parse _namespace_name "IRI" |> NamespacedName
    /// <summary>
    /// The type that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to indicate that focus nodes must only have values for those properties that have been explicitly enumerated via sh:property/sh:path.
    /// <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent"></see></summary>
    let ClosedConstraintComponent =
        Namespaced_IRI.parse _namespace_name "ClosedConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-closed"></see>
    /// </summary>
    let ``ClosedConstraintComponent-closed`` =
        Namespaced_IRI.parse _namespace_name "ClosedConstraintComponent-closed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ClosedConstraintComponent-ignoredProperties"></see>
    /// </summary>
    let ``ClosedConstraintComponent-ignoredProperties`` =
        Namespaced_IRI.parse _namespace_name "ClosedConstraintComponent-ignoredProperties" |> NamespacedName

    /// <summary>
    /// Specifies an RDF datatype that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// If set to true then the shape is closed.
    /// <see href="http://www.w3.org/ns/shacl#closed"></see></summary>
    let closed = Namespaced_IRI.parse _namespace_name "closed" |> NamespacedName
    /// <summary>
    /// Indicates whether a parameter is optional.
    /// <see href="http://www.w3.org/ns/shacl#optional"></see></summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName

    /// <summary>
    /// An optional RDF list of properties that are also permitted in addition to those explicitly enumerated via sh:property/sh:path.
    /// <see href="http://www.w3.org/ns/shacl#ignoredProperties"></see></summary>
    let ignoredProperties =
        Namespaced_IRI.parse _namespace_name "ignoredProperties" |> NamespacedName

    /// <summary>
    /// Superclass of components that can take parameters, especially functions and constraint components.
    /// <see href="http://www.w3.org/ns/shacl#Parameterizable"></see></summary>
    let Parameterizable =
        Namespaced_IRI.parse _namespace_name "Parameterizable" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the datatype of all value nodes.
    /// <see href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent"></see></summary>
    let DatatypeConstraintComponent =
        Namespaced_IRI.parse _namespace_name "DatatypeConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#DatatypeConstraintComponent-datatype"></see>
    /// </summary>
    let ``DatatypeConstraintComponent-datatype`` =
        Namespaced_IRI.parse _namespace_name "DatatypeConstraintComponent-datatype" |> NamespacedName

    /// <summary>
    /// Specifies the maximum number of values in the set of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#maxCount"></see></summary>
    let maxCount = Namespaced_IRI.parse _namespace_name "maxCount" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that the set of value nodes is disjoint with the the set of nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#DisjointConstraintComponent"></see></summary>
    let DisjointConstraintComponent =
        Namespaced_IRI.parse _namespace_name "DisjointConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#DisjointConstraintComponent-disjoint"></see>
    /// </summary>
    let ``DisjointConstraintComponent-disjoint`` =
        Namespaced_IRI.parse _namespace_name "DisjointConstraintComponent-disjoint" |> NamespacedName

    /// <summary>
    /// Specifies a property where the set of values must be disjoint with the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#disjoint"></see></summary>
    let disjoint = Namespaced_IRI.parse _namespace_name "disjoint" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that the set of value nodes is equal to the set of nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#EqualsConstraintComponent"></see></summary>
    let EqualsConstraintComponent =
        Namespaced_IRI.parse _namespace_name "EqualsConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#EqualsConstraintComponent-equals"></see>
    /// </summary>
    let ``EqualsConstraintComponent-equals`` =
        Namespaced_IRI.parse _namespace_name "EqualsConstraintComponent-equals" |> NamespacedName

    /// <summary>
    /// Specifies a property that must have the same values as the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#equals"></see></summary>
    let equals = Namespaced_IRI.parse _namespace_name "equals" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that a given node expression produces true for all value nodes.
    /// <see href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent"></see></summary>
    let ExpressionConstraintComponent =
        Namespaced_IRI.parse _namespace_name "ExpressionConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#ExpressionConstraintComponent-expression"></see>
    /// </summary>
    let ``ExpressionConstraintComponent-expression`` =
        Namespaced_IRI.parse _namespace_name "ExpressionConstraintComponent-expression" |> NamespacedName

    /// <summary>
    /// The node expression that must return true for the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#expression"></see></summary>
    let expression = Namespaced_IRI.parse _namespace_name "expression" |> NamespacedName
    /// <summary>
    /// The class of SHACL functions.
    /// <see href="http://www.w3.org/ns/shacl#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that one of the value nodes is a given RDF node.
    /// <see href="http://www.w3.org/ns/shacl#HasValueConstraintComponent"></see></summary>
    let HasValueConstraintComponent =
        Namespaced_IRI.parse _namespace_name "HasValueConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#HasValueConstraintComponent-hasValue"></see>
    /// </summary>
    let ``HasValueConstraintComponent-hasValue`` =
        Namespaced_IRI.parse _namespace_name "HasValueConstraintComponent-hasValue" |> NamespacedName

    /// <summary>
    /// Specifies a value that must be among the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// The node kind of all IRIs or literals.
    /// <see href="http://www.w3.org/ns/shacl#IRIOrLiteral"></see></summary>
    let IRIOrLiteral =
        Namespaced_IRI.parse _namespace_name "IRIOrLiteral" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to exclusively enumerate the permitted value nodes.
    /// <see href="http://www.w3.org/ns/shacl#InConstraintComponent"></see></summary>
    let InConstraintComponent =
        Namespaced_IRI.parse _namespace_name "InConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#InConstraintComponent-in"></see>
    /// </summary>
    let ``InConstraintComponent-in`` =
        Namespaced_IRI.parse _namespace_name "InConstraintComponent-in" |> NamespacedName

    /// <summary>
    /// Specifies a list of allowed values so that each value node must be among the members of the given list.
    /// <see href="http://www.w3.org/ns/shacl#in"></see></summary>
    let in_ = Namespaced_IRI.parse _namespace_name "in" |> NamespacedName
    /// <summary>
    /// The severity for an informational validation result.
    /// <see href="http://www.w3.org/ns/shacl#Info"></see></summary>
    let Info = Namespaced_IRI.parse _namespace_name "Info" |> NamespacedName
    /// <summary>
    /// The class of validation result severity levels, including violation and warning levels.
    /// <see href="http://www.w3.org/ns/shacl#Severity"></see></summary>
    let Severity = Namespaced_IRI.parse _namespace_name "Severity" |> NamespacedName

    /// <summary>
    /// The class of constraints backed by a JavaScript function.
    /// <see href="http://www.w3.org/ns/shacl#JSConstraint"></see></summary>
    let JSConstraint =
        Namespaced_IRI.parse _namespace_name "JSConstraint" |> NamespacedName

    /// <summary>
    /// Abstract base class of resources that declare an executable JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#JSExecutable"></see></summary>
    let JSExecutable =
        Namespaced_IRI.parse _namespace_name "JSExecutable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#JSConstraint-js"></see>
    /// </summary>
    let ``JSConstraint-js`` =
        Namespaced_IRI.parse _namespace_name "JSConstraint-js" |> NamespacedName

    /// <summary>
    /// Constraints expressed in JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#js"></see></summary>
    let js = Namespaced_IRI.parse _namespace_name "js" |> NamespacedName

    /// <summary>
    /// A constraint component with the parameter sh:js linking to a sh:JSConstraint containing a sh:script.
    /// <see href="http://www.w3.org/ns/shacl#JSConstraintComponent"></see></summary>
    let JSConstraintComponent =
        Namespaced_IRI.parse _namespace_name "JSConstraintComponent" |> NamespacedName

    /// <summary>
    /// The class of SHACL functions that execute a JavaScript function when called.
    /// <see href="http://www.w3.org/ns/shacl#JSFunction"></see></summary>
    let JSFunction = Namespaced_IRI.parse _namespace_name "JSFunction" |> NamespacedName
    /// <summary>
    /// Represents a JavaScript library, typically identified by one or more URLs of files to include.
    /// <see href="http://www.w3.org/ns/shacl#JSLibrary"></see></summary>
    let JSLibrary = Namespaced_IRI.parse _namespace_name "JSLibrary" |> NamespacedName
    /// <summary>
    /// The class of SHACL rules expressed using JavaScript.
    /// <see href="http://www.w3.org/ns/shacl#JSRule"></see></summary>
    let JSRule = Namespaced_IRI.parse _namespace_name "JSRule" |> NamespacedName
    /// <summary>
    /// The class of SHACL rules. Never instantiated directly.
    /// <see href="http://www.w3.org/ns/shacl#Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName
    /// <summary>
    /// The class of targets that are based on JavaScript functions.
    /// <see href="http://www.w3.org/ns/shacl#JSTarget"></see></summary>
    let JSTarget = Namespaced_IRI.parse _namespace_name "JSTarget" |> NamespacedName
    /// <summary>
    /// The base class of targets such as those based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#Target"></see></summary>
    let Target = Namespaced_IRI.parse _namespace_name "Target" |> NamespacedName

    /// <summary>
    /// The (meta) class for parameterizable targets that are based on JavaScript functions.
    /// <see href="http://www.w3.org/ns/shacl#JSTargetType"></see></summary>
    let JSTargetType =
        Namespaced_IRI.parse _namespace_name "JSTargetType" |> NamespacedName

    /// <summary>
    /// The (meta) class for parameterizable targets.	Instances of this are instantiated as values of the sh:target property.
    /// <see href="http://www.w3.org/ns/shacl#TargetType"></see></summary>
    let TargetType = Namespaced_IRI.parse _namespace_name "TargetType" |> NamespacedName

    /// <summary>
    /// A SHACL validator based on JavaScript. This can be used to declare SHACL constraint components that perform JavaScript-based validation when used.
    /// <see href="http://www.w3.org/ns/shacl#JSValidator"></see></summary>
    let JSValidator =
        Namespaced_IRI.parse _namespace_name "JSValidator" |> NamespacedName

    /// <summary>
    /// The class of validators, which provide instructions on how to process a constraint definition. This class serves as base class for the SPARQL-based validators and other possible implementations.
    /// <see href="http://www.w3.org/ns/shacl#Validator"></see></summary>
    let Validator = Namespaced_IRI.parse _namespace_name "Validator" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to enumerate language tags that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent"></see></summary>
    let LanguageInConstraintComponent =
        Namespaced_IRI.parse _namespace_name "LanguageInConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LanguageInConstraintComponent-languageIn"></see>
    /// </summary>
    let ``LanguageInConstraintComponent-languageIn`` =
        Namespaced_IRI.parse _namespace_name "LanguageInConstraintComponent-languageIn" |> NamespacedName

    /// <summary>
    /// Specifies a list of language tags that all value nodes must have.
    /// <see href="http://www.w3.org/ns/shacl#languageIn"></see></summary>
    let languageIn = Namespaced_IRI.parse _namespace_name "languageIn" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that each value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#LessThanConstraintComponent"></see></summary>
    let LessThanConstraintComponent =
        Namespaced_IRI.parse _namespace_name "LessThanConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LessThanConstraintComponent-lessThan"></see>
    /// </summary>
    let ``LessThanConstraintComponent-lessThan`` =
        Namespaced_IRI.parse _namespace_name "LessThanConstraintComponent-lessThan" |> NamespacedName

    /// <summary>
    /// Specifies a property that must have smaller values than the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#lessThan"></see></summary>
    let lessThan = Namespaced_IRI.parse _namespace_name "lessThan" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that every value node is smaller than all the nodes that have the focus node as subject and the value of a given property as predicate.
    /// <see href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent"></see></summary>
    let LessThanOrEqualsConstraintComponent =
        Namespaced_IRI.parse _namespace_name "LessThanOrEqualsConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#LessThanOrEqualsConstraintComponent-lessThanOrEquals"></see>
    /// </summary>
    let ``LessThanOrEqualsConstraintComponent-lessThanOrEquals`` =
        Namespaced_IRI.parse _namespace_name "LessThanOrEqualsConstraintComponent-lessThanOrEquals" |> NamespacedName

    /// <summary>
    /// Specifies a property that must have smaller or equal values than the value nodes.
    /// <see href="http://www.w3.org/ns/shacl#lessThanOrEquals"></see></summary>
    let lessThanOrEquals =
        Namespaced_IRI.parse _namespace_name "lessThanOrEquals" |> NamespacedName

    /// <summary>
    /// The node kind of all literals.
    /// <see href="http://www.w3.org/ns/shacl#Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the maximum number of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent"></see></summary>
    let MaxCountConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MaxCountConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxCountConstraintComponent-maxCount"></see>
    /// </summary>
    let ``MaxCountConstraintComponent-maxCount`` =
        Namespaced_IRI.parse _namespace_name "MaxCountConstraintComponent-maxCount" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a maximum exclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent"></see></summary>
    let MaxExclusiveConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MaxExclusiveConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxExclusiveConstraintComponent-maxExclusive"></see>
    /// </summary>
    let ``MaxExclusiveConstraintComponent-maxExclusive`` =
        Namespaced_IRI.parse _namespace_name "MaxExclusiveConstraintComponent-maxExclusive" |> NamespacedName

    /// <summary>
    /// Specifies the maximum exclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxExclusive"></see></summary>
    let maxExclusive =
        Namespaced_IRI.parse _namespace_name "maxExclusive" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a maximum inclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent"></see></summary>
    let MaxInclusiveConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MaxInclusiveConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxInclusiveConstraintComponent-maxInclusive"></see>
    /// </summary>
    let ``MaxInclusiveConstraintComponent-maxInclusive`` =
        Namespaced_IRI.parse _namespace_name "MaxInclusiveConstraintComponent-maxInclusive" |> NamespacedName

    /// <summary>
    /// Specifies the maximum inclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxInclusive"></see></summary>
    let maxInclusive =
        Namespaced_IRI.parse _namespace_name "maxInclusive" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the maximum string length of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent"></see></summary>
    let MaxLengthConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MaxLengthConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MaxLengthConstraintComponent-maxLength"></see>
    /// </summary>
    let ``MaxLengthConstraintComponent-maxLength`` =
        Namespaced_IRI.parse _namespace_name "MaxLengthConstraintComponent-maxLength" |> NamespacedName

    /// <summary>
    /// Specifies the maximum string length of each value node.
    /// <see href="http://www.w3.org/ns/shacl#maxLength"></see></summary>
    let maxLength = Namespaced_IRI.parse _namespace_name "maxLength" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the minimum number of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MinCountConstraintComponent"></see></summary>
    let MinCountConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MinCountConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinCountConstraintComponent-minCount"></see>
    /// </summary>
    let ``MinCountConstraintComponent-minCount`` =
        Namespaced_IRI.parse _namespace_name "MinCountConstraintComponent-minCount" |> NamespacedName

    /// <summary>
    /// Specifies the minimum number of values in the set of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#minCount"></see></summary>
    let minCount = Namespaced_IRI.parse _namespace_name "minCount" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a minimum exclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent"></see></summary>
    let MinExclusiveConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MinExclusiveConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinExclusiveConstraintComponent-minExclusive"></see>
    /// </summary>
    let ``MinExclusiveConstraintComponent-minExclusive`` =
        Namespaced_IRI.parse _namespace_name "MinExclusiveConstraintComponent-minExclusive" |> NamespacedName

    /// <summary>
    /// Specifies the minimum exclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minExclusive"></see></summary>
    let minExclusive =
        Namespaced_IRI.parse _namespace_name "minExclusive" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the range of value nodes with a minimum inclusive value.
    /// <see href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent"></see></summary>
    let MinInclusiveConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MinInclusiveConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinInclusiveConstraintComponent-minInclusive"></see>
    /// </summary>
    let ``MinInclusiveConstraintComponent-minInclusive`` =
        Namespaced_IRI.parse _namespace_name "MinInclusiveConstraintComponent-minInclusive" |> NamespacedName

    /// <summary>
    /// Specifies the minimum inclusive value of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minInclusive"></see></summary>
    let minInclusive =
        Namespaced_IRI.parse _namespace_name "minInclusive" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the minimum string length of value nodes.
    /// <see href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent"></see></summary>
    let MinLengthConstraintComponent =
        Namespaced_IRI.parse _namespace_name "MinLengthConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#MinLengthConstraintComponent-minLength"></see>
    /// </summary>
    let ``MinLengthConstraintComponent-minLength`` =
        Namespaced_IRI.parse _namespace_name "MinLengthConstraintComponent-minLength" |> NamespacedName

    /// <summary>
    /// Specifies the minimum string length of each value node.
    /// <see href="http://www.w3.org/ns/shacl#minLength"></see></summary>
    let minLength = Namespaced_IRI.parse _namespace_name "minLength" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that all value nodes conform to the given node shape.
    /// <see href="http://www.w3.org/ns/shacl#NodeConstraintComponent"></see></summary>
    let NodeConstraintComponent =
        Namespaced_IRI.parse _namespace_name "NodeConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NodeConstraintComponent-node"></see>
    /// </summary>
    let ``NodeConstraintComponent-node`` =
        Namespaced_IRI.parse _namespace_name "NodeConstraintComponent-node" |> NamespacedName

    /// <summary>
    /// Specifies the node shape that all value nodes must conform to.
    /// <see href="http://www.w3.org/ns/shacl#node"></see></summary>
    let node = Namespaced_IRI.parse _namespace_name "node" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the RDF node kind of each value node.
    /// <see href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent"></see></summary>
    let NodeKindConstraintComponent =
        Namespaced_IRI.parse _namespace_name "NodeKindConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NodeKindConstraintComponent-nodeKind"></see>
    /// </summary>
    let ``NodeKindConstraintComponent-nodeKind`` =
        Namespaced_IRI.parse _namespace_name "NodeKindConstraintComponent-nodeKind" |> NamespacedName

    /// <summary>
    /// A node shape is a shape that specifies constraint that need to be met with respect to focus nodes.
    /// <see href="http://www.w3.org/ns/shacl#NodeShape"></see></summary>
    let NodeShape = Namespaced_IRI.parse _namespace_name "NodeShape" |> NamespacedName
    /// <summary>
    /// A shape is a collection of constraints that may be targeted for certain nodes.
    /// <see href="http://www.w3.org/ns/shacl#Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that value nodes do not conform to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#NotConstraintComponent"></see></summary>
    let NotConstraintComponent =
        Namespaced_IRI.parse _namespace_name "NotConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#NotConstraintComponent-not"></see>
    /// </summary>
    let ``NotConstraintComponent-not`` =
        Namespaced_IRI.parse _namespace_name "NotConstraintComponent-not" |> NamespacedName

    /// <summary>
    /// Specifies a shape that the value nodes must not conform to.
    /// <see href="http://www.w3.org/ns/shacl#not"></see></summary>
    let ``not`` = Namespaced_IRI.parse _namespace_name "not" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the value nodes so that they conform to at least one out of several provided shapes.
    /// <see href="http://www.w3.org/ns/shacl#OrConstraintComponent"></see></summary>
    let OrConstraintComponent =
        Namespaced_IRI.parse _namespace_name "OrConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#OrConstraintComponent-or"></see>
    /// </summary>
    let ``OrConstraintComponent-or`` =
        Namespaced_IRI.parse _namespace_name "OrConstraintComponent-or" |> NamespacedName

    /// <summary>
    /// Specifies a list of shapes so that the value nodes must conform to at least one of the shapes.
    /// <see href="http://www.w3.org/ns/shacl#or"></see></summary>
    let or_ = Namespaced_IRI.parse _namespace_name "or" |> NamespacedName

    /// <summary>
    /// A property shape is a shape that specifies constraints on the values of a focus node for a given property or path.
    /// <see href="http://www.w3.org/ns/shacl#PropertyShape"></see></summary>
    let PropertyShape =
        Namespaced_IRI.parse _namespace_name "PropertyShape" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that every value node matches a given regular expression.
    /// <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent"></see></summary>
    let PatternConstraintComponent =
        Namespaced_IRI.parse _namespace_name "PatternConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent-pattern"></see>
    /// </summary>
    let ``PatternConstraintComponent-pattern`` =
        Namespaced_IRI.parse _namespace_name "PatternConstraintComponent-pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PatternConstraintComponent-flags"></see>
    /// </summary>
    let ``PatternConstraintComponent-flags`` =
        Namespaced_IRI.parse _namespace_name "PatternConstraintComponent-flags" |> NamespacedName

    /// <summary>
    /// An optional flag to be used with regular expression pattern matching.
    /// <see href="http://www.w3.org/ns/shacl#flags"></see></summary>
    let flags = Namespaced_IRI.parse _namespace_name "flags" |> NamespacedName
    /// <summary>
    /// Specifies a regular expression pattern that the string representations of the value nodes must match.
    /// <see href="http://www.w3.org/ns/shacl#pattern"></see></summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName

    /// <summary>
    /// The class of prefix declarations, consisting of pairs of a prefix with a namespace.
    /// <see href="http://www.w3.org/ns/shacl#PrefixDeclaration"></see></summary>
    let PrefixDeclaration =
        Namespaced_IRI.parse _namespace_name "PrefixDeclaration" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that all value nodes conform to the given property shape.
    /// <see href="http://www.w3.org/ns/shacl#PropertyConstraintComponent"></see></summary>
    let PropertyConstraintComponent =
        Namespaced_IRI.parse _namespace_name "PropertyConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#PropertyConstraintComponent-property"></see>
    /// </summary>
    let ``PropertyConstraintComponent-property`` =
        Namespaced_IRI.parse _namespace_name "PropertyConstraintComponent-property" |> NamespacedName

    /// <summary>
    /// Links a shape to its property shapes.
    /// <see href="http://www.w3.org/ns/shacl#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// Instances of this class represent groups of property shapes that belong together.
    /// <see href="http://www.w3.org/ns/shacl#PropertyGroup"></see></summary>
    let PropertyGroup =
        Namespaced_IRI.parse _namespace_name "PropertyGroup" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that a specified maximum number of value nodes conforms to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent"></see></summary>
    let QualifiedMaxCountConstraintComponent =
        Namespaced_IRI.parse _namespace_name "QualifiedMaxCountConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedMaxCount"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedMaxCount`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMaxCountConstraintComponent-qualifiedMaxCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShape"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedValueShape`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMaxCountConstraintComponent-qualifiedValueShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint"></see>
    /// </summary>
    let ``QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint" |> NamespacedName

    /// <summary>
    /// The maximum number of value nodes that can conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedMaxCount"></see></summary>
    let qualifiedMaxCount =
        Namespaced_IRI.parse _namespace_name "qualifiedMaxCount" |> NamespacedName

    /// <summary>
    /// The shape that a specified number of values must conform to.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedValueShape"></see></summary>
    let qualifiedValueShape =
        Namespaced_IRI.parse _namespace_name "qualifiedValueShape" |> NamespacedName

    /// <summary>
    /// Can be used to mark the qualified value shape to be disjoint with its sibling shapes.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedValueShapesDisjoint"></see></summary>
    let qualifiedValueShapesDisjoint =
        Namespaced_IRI.parse _namespace_name "qualifiedValueShapesDisjoint" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to verify that a specified minimum number of value nodes conforms to a given shape.
    /// <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent"></see></summary>
    let QualifiedMinCountConstraintComponent =
        Namespaced_IRI.parse _namespace_name "QualifiedMinCountConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedMinCount"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedMinCount`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMinCountConstraintComponent-qualifiedMinCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShape"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedValueShape`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMinCountConstraintComponent-qualifiedValueShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint"></see>
    /// </summary>
    let ``QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint`` =
        Namespaced_IRI.parse _namespace_name "QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint" |> NamespacedName

    /// <summary>
    /// The minimum number of value nodes that must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#qualifiedMinCount"></see></summary>
    let qualifiedMinCount =
        Namespaced_IRI.parse _namespace_name "qualifiedMinCount" |> NamespacedName

    /// <summary>
    /// A class of result annotations, which define the rules to derive the values of a given annotation property as extra values for a validation result.
    /// <see href="http://www.w3.org/ns/shacl#ResultAnnotation"></see></summary>
    let ResultAnnotation =
        Namespaced_IRI.parse _namespace_name "ResultAnnotation" |> NamespacedName

    /// <summary>
    /// The class of SPARQL executables that are based on an ASK query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLAskExecutable"></see></summary>
    let SPARQLAskExecutable =
        Namespaced_IRI.parse _namespace_name "SPARQLAskExecutable" |> NamespacedName

    /// <summary>
    /// The class of resources that encapsulate a SPARQL query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLExecutable"></see></summary>
    let SPARQLExecutable =
        Namespaced_IRI.parse _namespace_name "SPARQLExecutable" |> NamespacedName

    /// <summary>
    /// The class of validators based on SPARQL ASK queries. The queries are evaluated for each value node and are supposed to return true if the given node conforms.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLAskValidator"></see></summary>
    let SPARQLAskValidator =
        Namespaced_IRI.parse _namespace_name "SPARQLAskValidator" |> NamespacedName

    /// <summary>
    /// The class of constraints based on SPARQL SELECT queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstraint"></see></summary>
    let SPARQLConstraint =
        Namespaced_IRI.parse _namespace_name "SPARQLConstraint" |> NamespacedName

    /// <summary>
    /// The class of SPARQL executables based on a SELECT query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLSelectExecutable"></see></summary>
    let SPARQLSelectExecutable =
        Namespaced_IRI.parse _namespace_name "SPARQLSelectExecutable" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to define constraints based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent"></see></summary>
    let SPARQLConstraintComponent =
        Namespaced_IRI.parse _namespace_name "SPARQLConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#SPARQLConstraintComponent-sparql"></see>
    /// </summary>
    let ``SPARQLConstraintComponent-sparql`` =
        Namespaced_IRI.parse _namespace_name "SPARQLConstraintComponent-sparql" |> NamespacedName

    /// <summary>
    /// Links a shape with SPARQL constraints.
    /// <see href="http://www.w3.org/ns/shacl#sparql"></see></summary>
    let sparql = Namespaced_IRI.parse _namespace_name "sparql" |> NamespacedName

    /// <summary>
    /// The class of SPARQL executables that are based on a CONSTRUCT query.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLConstructExecutable"></see></summary>
    let SPARQLConstructExecutable =
        Namespaced_IRI.parse _namespace_name "SPARQLConstructExecutable" |> NamespacedName

    /// <summary>
    /// A function backed by a SPARQL query - either ASK or SELECT.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLFunction"></see></summary>
    let SPARQLFunction =
        Namespaced_IRI.parse _namespace_name "SPARQLFunction" |> NamespacedName

    /// <summary>
    /// The class of SHACL rules based on SPARQL CONSTRUCT queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLRule"></see></summary>
    let SPARQLRule = Namespaced_IRI.parse _namespace_name "SPARQLRule" |> NamespacedName

    /// <summary>
    /// The class of validators based on SPARQL SELECT queries. The queries are evaluated for each focus node and are supposed to produce bindings for all focus nodes that do not conform.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLSelectValidator"></see></summary>
    let SPARQLSelectValidator =
        Namespaced_IRI.parse _namespace_name "SPARQLSelectValidator" |> NamespacedName

    /// <summary>
    /// The class of targets that are based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLTarget"></see></summary>
    let SPARQLTarget =
        Namespaced_IRI.parse _namespace_name "SPARQLTarget" |> NamespacedName

    /// <summary>
    /// The (meta) class for parameterizable targets that are based on SPARQL queries.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLTargetType"></see></summary>
    let SPARQLTargetType =
        Namespaced_IRI.parse _namespace_name "SPARQLTargetType" |> NamespacedName

    /// <summary>
    /// The class of SPARQL executables based on a SPARQL UPDATE.
    /// <see href="http://www.w3.org/ns/shacl#SPARQLUpdateExecutable"></see></summary>
    let SPARQLUpdateExecutable =
        Namespaced_IRI.parse _namespace_name "SPARQLUpdateExecutable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#TripleRule"></see>
    /// </summary>
    let TripleRule = Namespaced_IRI.parse _namespace_name "TripleRule" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to specify that no pair of value nodes may use the same language tag.
    /// <see href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent"></see></summary>
    let UniqueLangConstraintComponent =
        Namespaced_IRI.parse _namespace_name "UniqueLangConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#UniqueLangConstraintComponent-uniqueLang"></see>
    /// </summary>
    let ``UniqueLangConstraintComponent-uniqueLang`` =
        Namespaced_IRI.parse _namespace_name "UniqueLangConstraintComponent-uniqueLang" |> NamespacedName

    /// <summary>
    /// Specifies whether all node values must have a unique (or no) language tag.
    /// <see href="http://www.w3.org/ns/shacl#uniqueLang"></see></summary>
    let uniqueLang = Namespaced_IRI.parse _namespace_name "uniqueLang" |> NamespacedName

    /// <summary>
    /// The class of SHACL validation reports.
    /// <see href="http://www.w3.org/ns/shacl#ValidationReport"></see></summary>
    let ValidationReport =
        Namespaced_IRI.parse _namespace_name "ValidationReport" |> NamespacedName

    /// <summary>
    /// The class of validation results.
    /// <see href="http://www.w3.org/ns/shacl#ValidationResult"></see></summary>
    let ValidationResult =
        Namespaced_IRI.parse _namespace_name "ValidationResult" |> NamespacedName

    /// <summary>
    /// The severity for a violation validation result.
    /// <see href="http://www.w3.org/ns/shacl#Violation"></see></summary>
    let Violation = Namespaced_IRI.parse _namespace_name "Violation" |> NamespacedName
    /// <summary>
    /// The severity for a warning validation result.
    /// <see href="http://www.w3.org/ns/shacl#Warning"></see></summary>
    let Warning = Namespaced_IRI.parse _namespace_name "Warning" |> NamespacedName

    /// <summary>
    /// A constraint component that can be used to restrict the value nodes so that they conform to exactly one out of several provided shapes.
    /// <see href="http://www.w3.org/ns/shacl#XoneConstraintComponent"></see></summary>
    let XoneConstraintComponent =
        Namespaced_IRI.parse _namespace_name "XoneConstraintComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl#XoneConstraintComponent-xone"></see>
    /// </summary>
    let ``XoneConstraintComponent-xone`` =
        Namespaced_IRI.parse _namespace_name "XoneConstraintComponent-xone" |> NamespacedName

    /// <summary>
    /// Specifies a list of shapes so that the value nodes must conform to exactly one of the shapes.
    /// <see href="http://www.w3.org/ns/shacl#xone"></see></summary>
    let xone = Namespaced_IRI.parse _namespace_name "xone" |> NamespacedName

    /// <summary>
    /// The (single) value of this property must be a list of path elements, representing the elements of alternative paths.
    /// <see href="http://www.w3.org/ns/shacl#alternativePath"></see></summary>
    let alternativePath =
        Namespaced_IRI.parse _namespace_name "alternativePath" |> NamespacedName

    /// <summary>
    /// The annotation property that shall be set.
    /// <see href="http://www.w3.org/ns/shacl#annotationProperty"></see></summary>
    let annotationProperty =
        Namespaced_IRI.parse _namespace_name "annotationProperty" |> NamespacedName

    /// <summary>
    /// The (default) values of the annotation property.
    /// <see href="http://www.w3.org/ns/shacl#annotationValue"></see></summary>
    let annotationValue =
        Namespaced_IRI.parse _namespace_name "annotationValue" |> NamespacedName

    /// <summary>
    /// The name of the SPARQL variable from the SELECT clause that shall be used for the values.
    /// <see href="http://www.w3.org/ns/shacl#annotationVarName"></see></summary>
    let annotationVarName =
        Namespaced_IRI.parse _namespace_name "annotationVarName" |> NamespacedName

    /// <summary>
    /// The SPARQL ASK query to execute.
    /// <see href="http://www.w3.org/ns/shacl#ask"></see></summary>
    let ask = Namespaced_IRI.parse _namespace_name "ask" |> NamespacedName
    /// <summary>
    /// The shapes that the focus nodes need to conform to before a rule is executed on them.
    /// <see href="http://www.w3.org/ns/shacl#condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// True if the validation did not produce any validation results, and false otherwise.
    /// <see href="http://www.w3.org/ns/shacl#conforms"></see></summary>
    let conforms = Namespaced_IRI.parse _namespace_name "conforms" |> NamespacedName
    /// <summary>
    /// The SPARQL CONSTRUCT query to execute.
    /// <see href="http://www.w3.org/ns/shacl#construct"></see></summary>
    let construct = Namespaced_IRI.parse _namespace_name "construct" |> NamespacedName

    /// <summary>
    /// If set to true then all nodes conform to this.
    /// <see href="http://www.w3.org/ns/shacl#deactivated"></see></summary>
    let deactivated =
        Namespaced_IRI.parse _namespace_name "deactivated" |> NamespacedName

    /// <summary>
    /// A default value for a property, for example for user interface tools to pre-populate input fields.
    /// <see href="http://www.w3.org/ns/shacl#defaultValue"></see></summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    /// Human-readable descriptions for the property in the context of the surrounding shape.
    /// <see href="http://www.w3.org/ns/shacl#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Links a result with other results that provide more details, for example to describe violations against nested shapes.
    /// <see href="http://www.w3.org/ns/shacl#detail"></see></summary>
    let detail = Namespaced_IRI.parse _namespace_name "detail" |> NamespacedName
    /// <summary>
    /// An entailment regime that indicates what kind of inferencing is required by a shapes graph.
    /// <see href="http://www.w3.org/ns/shacl#entailment"></see></summary>
    let entailment = Namespaced_IRI.parse _namespace_name "entailment" |> NamespacedName

    /// <summary>
    /// The shape that all input nodes of the expression need to conform to.
    /// <see href="http://www.w3.org/ns/shacl#filterShape"></see></summary>
    let filterShape =
        Namespaced_IRI.parse _namespace_name "filterShape" |> NamespacedName

    /// <summary>
    /// The focus node that was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#focusNode"></see></summary>
    let focusNode = Namespaced_IRI.parse _namespace_name "focusNode" |> NamespacedName
    /// <summary>
    /// Can be used to link to a property group to indicate that a property shape belongs to a group of related property shapes.
    /// <see href="http://www.w3.org/ns/shacl#group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName

    /// <summary>
    /// A list of node expressions that shall be intersected.
    /// <see href="http://www.w3.org/ns/shacl#intersection"></see></summary>
    let intersection =
        Namespaced_IRI.parse _namespace_name "intersection" |> NamespacedName

    /// <summary>
    /// The (single) value of this property represents an inverse path (object to subject).
    /// <see href="http://www.w3.org/ns/shacl#inversePath"></see></summary>
    let inversePath =
        Namespaced_IRI.parse _namespace_name "inversePath" |> NamespacedName

    /// <summary>
    /// The name of the JavaScript function to execute.
    /// <see href="http://www.w3.org/ns/shacl#jsFunctionName"></see></summary>
    let jsFunctionName =
        Namespaced_IRI.parse _namespace_name "jsFunctionName" |> NamespacedName

    /// <summary>
    /// Declares which JavaScript libraries are needed to execute this.
    /// <see href="http://www.w3.org/ns/shacl#jsLibrary"></see></summary>
    let jsLibrary = Namespaced_IRI.parse _namespace_name "jsLibrary" |> NamespacedName

    /// <summary>
    /// Declares the URLs of a JavaScript library. This should be the absolute URL of a JavaScript file. Implementations may redirect those to local files.
    /// <see href="http://www.w3.org/ns/shacl#jsLibraryURL"></see></summary>
    let jsLibraryURL =
        Namespaced_IRI.parse _namespace_name "jsLibraryURL" |> NamespacedName

    /// <summary>
    /// Outlines how human-readable labels of instances of the associated Parameterizable shall be produced. The values can contain {?paramName} as placeholders for the actual values of the given parameter.
    /// <see href="http://www.w3.org/ns/shacl#labelTemplate"></see></summary>
    let labelTemplate =
        Namespaced_IRI.parse _namespace_name "labelTemplate" |> NamespacedName

    /// <summary>
    /// A human-readable message (possibly with placeholders for variables) explaining the cause of the result.
    /// <see href="http://www.w3.org/ns/shacl#message"></see></summary>
    let message = Namespaced_IRI.parse _namespace_name "message" |> NamespacedName
    /// <summary>
    /// Human-readable labels for the property in the context of the surrounding shape.
    /// <see href="http://www.w3.org/ns/shacl#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// The validator(s) used to evaluate a constraint in the context of a node shape.
    /// <see href="http://www.w3.org/ns/shacl#nodeValidator"></see></summary>
    let nodeValidator =
        Namespaced_IRI.parse _namespace_name "nodeValidator" |> NamespacedName

    /// <summary>
    /// The node expression producing the input nodes of a filter shape expression.
    /// <see href="http://www.w3.org/ns/shacl#nodes"></see></summary>
    let nodes = Namespaced_IRI.parse _namespace_name "nodes" |> NamespacedName
    /// <summary>
    /// An expression producing the nodes that shall be inferred as objects.
    /// <see href="http://www.w3.org/ns/shacl#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName

    /// <summary>
    /// The (single) value of this property represents a path that is matched one or more times.
    /// <see href="http://www.w3.org/ns/shacl#oneOrMorePath"></see></summary>
    let oneOrMorePath =
        Namespaced_IRI.parse _namespace_name "oneOrMorePath" |> NamespacedName

    /// <summary>
    /// Specifies the relative order of this compared to its siblings. For example use 0 for the first, 1 for the second.
    /// <see href="http://www.w3.org/ns/shacl#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// An expression producing the properties that shall be inferred as predicates.
    /// <see href="http://www.w3.org/ns/shacl#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// The prefixes that shall be applied before parsing the associated SPARQL query.
    /// <see href="http://www.w3.org/ns/shacl#prefixes"></see></summary>
    let prefixes = Namespaced_IRI.parse _namespace_name "prefixes" |> NamespacedName

    /// <summary>
    /// The validator(s) used to evaluate a constraint in the context of a property shape.
    /// <see href="http://www.w3.org/ns/shacl#propertyValidator"></see></summary>
    let propertyValidator =
        Namespaced_IRI.parse _namespace_name "propertyValidator" |> NamespacedName

    /// <summary>
    /// The validation results contained in a validation report.
    /// <see href="http://www.w3.org/ns/shacl#result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    /// Links a SPARQL validator with zero or more sh:ResultAnnotation instances, defining how to derive additional result properties based on the variables of the SELECT query.
    /// <see href="http://www.w3.org/ns/shacl#resultAnnotation"></see></summary>
    let resultAnnotation =
        Namespaced_IRI.parse _namespace_name "resultAnnotation" |> NamespacedName

    /// <summary>
    /// Human-readable messages explaining the cause of the result.
    /// <see href="http://www.w3.org/ns/shacl#resultMessage"></see></summary>
    let resultMessage =
        Namespaced_IRI.parse _namespace_name "resultMessage" |> NamespacedName

    /// <summary>
    /// The path of a validation result, based on the path of the validated property shape.
    /// <see href="http://www.w3.org/ns/shacl#resultPath"></see></summary>
    let resultPath = Namespaced_IRI.parse _namespace_name "resultPath" |> NamespacedName

    /// <summary>
    /// The severity of the result, e.g. warning.
    /// <see href="http://www.w3.org/ns/shacl#resultSeverity"></see></summary>
    let resultSeverity =
        Namespaced_IRI.parse _namespace_name "resultSeverity" |> NamespacedName

    /// <summary>
    /// The expected type of values returned by the associated function.
    /// <see href="http://www.w3.org/ns/shacl#returnType"></see></summary>
    let returnType = Namespaced_IRI.parse _namespace_name "returnType" |> NamespacedName
    /// <summary>
    /// The rules linked to a shape.
    /// <see href="http://www.w3.org/ns/shacl#rule"></see></summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName
    /// <summary>
    /// The SPARQL SELECT query to execute.
    /// <see href="http://www.w3.org/ns/shacl#select"></see></summary>
    let select = Namespaced_IRI.parse _namespace_name "select" |> NamespacedName
    /// <summary>
    /// Defines the severity that validation results produced by a shape must have. Defaults to sh:Violation.
    /// <see href="http://www.w3.org/ns/shacl#severity"></see></summary>
    let severity = Namespaced_IRI.parse _namespace_name "severity" |> NamespacedName

    /// <summary>
    /// Shapes graphs that should be used when validating this data graph.
    /// <see href="http://www.w3.org/ns/shacl#shapesGraph"></see></summary>
    let shapesGraph =
        Namespaced_IRI.parse _namespace_name "shapesGraph" |> NamespacedName

    /// <summary>
    /// If true then the validation engine was certain that the shapes graph has passed all SHACL syntax requirements during the validation process.
    /// <see href="http://www.w3.org/ns/shacl#shapesGraphWellFormed"></see></summary>
    let shapesGraphWellFormed =
        Namespaced_IRI.parse _namespace_name "shapesGraphWellFormed" |> NamespacedName

    /// <summary>
    /// The constraint that was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#sourceConstraint"></see></summary>
    let sourceConstraint =
        Namespaced_IRI.parse _namespace_name "sourceConstraint" |> NamespacedName

    /// <summary>
    /// The constraint component that is the source of the result.
    /// <see href="http://www.w3.org/ns/shacl#sourceConstraintComponent"></see></summary>
    let sourceConstraintComponent =
        Namespaced_IRI.parse _namespace_name "sourceConstraintComponent" |> NamespacedName

    /// <summary>
    /// The shape that is was validated when the result was produced.
    /// <see href="http://www.w3.org/ns/shacl#sourceShape"></see></summary>
    let sourceShape =
        Namespaced_IRI.parse _namespace_name "sourceShape" |> NamespacedName

    /// <summary>
    /// An expression producing the resources that shall be inferred as subjects.
    /// <see href="http://www.w3.org/ns/shacl#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// Links a shape to a target specified by an extension language, for example instances of sh:SPARQLTarget.
    /// <see href="http://www.w3.org/ns/shacl#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    /// Links a shape to a class, indicating that all instances of the class must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetClass"></see></summary>
    let targetClass =
        Namespaced_IRI.parse _namespace_name "targetClass" |> NamespacedName

    /// <summary>
    /// Links a shape to individual nodes, indicating that these nodes must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetNode"></see></summary>
    let targetNode = Namespaced_IRI.parse _namespace_name "targetNode" |> NamespacedName

    /// <summary>
    /// Links a shape to a property, indicating that all all objects of triples that have the given property as their predicate must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetObjectsOf"></see></summary>
    let targetObjectsOf =
        Namespaced_IRI.parse _namespace_name "targetObjectsOf" |> NamespacedName

    /// <summary>
    /// Links a shape to a property, indicating that all subjects of triples that have the given property as their predicate must conform to the shape.
    /// <see href="http://www.w3.org/ns/shacl#targetSubjectsOf"></see></summary>
    let targetSubjectsOf =
        Namespaced_IRI.parse _namespace_name "targetSubjectsOf" |> NamespacedName

    /// <summary>
    /// A node expression that represents the current focus node.
    /// <see href="http://www.w3.org/ns/shacl#this"></see></summary>
    let this = Namespaced_IRI.parse _namespace_name "this" |> NamespacedName
    /// <summary>
    /// A list of node expressions that shall be used together.
    /// <see href="http://www.w3.org/ns/shacl#union"></see></summary>
    let union = Namespaced_IRI.parse _namespace_name "union" |> NamespacedName
    /// <summary>
    /// The SPARQL UPDATE to execute.
    /// <see href="http://www.w3.org/ns/shacl#update"></see></summary>
    let update = Namespaced_IRI.parse _namespace_name "update" |> NamespacedName
    /// <summary>
    /// The validator(s) used to evaluate constraints of either node or property shapes.
    /// <see href="http://www.w3.org/ns/shacl#validator"></see></summary>
    let validator = Namespaced_IRI.parse _namespace_name "validator" |> NamespacedName
    /// <summary>
    /// An RDF node that has caused the result.
    /// <see href="http://www.w3.org/ns/shacl#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// The (single) value of this property represents a path that is matched zero or more times.
    /// <see href="http://www.w3.org/ns/shacl#zeroOrMorePath"></see></summary>
    let zeroOrMorePath =
        Namespaced_IRI.parse _namespace_name "zeroOrMorePath" |> NamespacedName

    /// <summary>
    /// The (single) value of this property represents a path that is matched zero or one times.
    /// <see href="http://www.w3.org/ns/shacl#zeroOrOnePath"></see></summary>
    let zeroOrOnePath =
        Namespaced_IRI.parse _namespace_name "zeroOrOnePath" |> NamespacedName
