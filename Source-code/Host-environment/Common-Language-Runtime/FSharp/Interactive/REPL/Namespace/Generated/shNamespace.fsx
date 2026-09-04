#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sh =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shacl#" "sh"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Abstract result</para>
    ///   <para>rdfs:comment : The base class of validation results, typically not instantiated directly.</para>
    ///   <a href="http://www.w3.org/ns/shacl#AbstractResult">sh:AbstractResult</a>
    /// </summary>
    let AbstractResult = _prefixId.prefix "AbstractResult"
    let AndConstraintComponent = _prefixId.prefix "AndConstraintComponent"
    let AndConstraintComponent_and = _prefixId.prefix "AndConstraintComponent-and"
    let BlankNode = _prefixId.prefix "BlankNode"
    let BlankNodeOrIRI = _prefixId.prefix "BlankNodeOrIRI"
    let BlankNodeOrLiteral = _prefixId.prefix "BlankNodeOrLiteral"
    let ClassConstraintComponent = _prefixId.prefix "ClassConstraintComponent"

    let ClassConstraintComponent_class =
        _prefixId.prefix "ClassConstraintComponent-class"

    let ClosedConstraintComponent = _prefixId.prefix "ClosedConstraintComponent"

    let ClosedConstraintComponent_closed =
        _prefixId.prefix "ClosedConstraintComponent-closed"

    let ClosedConstraintComponent_ignoredProperties =
        _prefixId.prefix "ClosedConstraintComponent-ignoredProperties"

    /// <summary>
    ///   <para>rdfs:label : Constraint component</para>
    ///   <para>rdfs:comment : The class of constraint components.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ConstraintComponent">sh:ConstraintComponent</a>
    /// </summary>
    let ConstraintComponent = _prefixId.prefix "ConstraintComponent"
    let DatatypeConstraintComponent = _prefixId.prefix "DatatypeConstraintComponent"

    let DatatypeConstraintComponent_datatype =
        _prefixId.prefix "DatatypeConstraintComponent-datatype"

    let DisjointConstraintComponent = _prefixId.prefix "DisjointConstraintComponent"

    let DisjointConstraintComponent_disjoint =
        _prefixId.prefix "DisjointConstraintComponent-disjoint"

    let EqualsConstraintComponent = _prefixId.prefix "EqualsConstraintComponent"

    let EqualsConstraintComponent_equals =
        _prefixId.prefix "EqualsConstraintComponent-equals"

    let ExpressionConstraintComponent = _prefixId.prefix "ExpressionConstraintComponent"

    let ExpressionConstraintComponent_expression =
        _prefixId.prefix "ExpressionConstraintComponent-expression"

    /// <summary>
    ///   <para>rdfs:label : Function</para>
    ///   <para>rdfs:comment : The class of SHACL functions.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Function">sh:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    let HasValueConstraintComponent = _prefixId.prefix "HasValueConstraintComponent"

    let HasValueConstraintComponent_hasValue =
        _prefixId.prefix "HasValueConstraintComponent-hasValue"

    let IRI = _prefixId.prefix "IRI"
    let IRIOrLiteral = _prefixId.prefix "IRIOrLiteral"
    let InConstraintComponent = _prefixId.prefix "InConstraintComponent"
    let InConstraintComponent_in = _prefixId.prefix "InConstraintComponent-in"
    let Info = _prefixId.prefix "Info"
    /// <summary>
    ///   <para>rdfs:label : JavaScript-based constraint</para>
    ///   <para>rdfs:comment : The class of constraints backed by a JavaScript function.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSConstraint">sh:JSConstraint</a>
    /// </summary>
    let JSConstraint = _prefixId.prefix "JSConstraint"
    let JSConstraint_js = _prefixId.prefix "JSConstraint-js"
    let JSConstraintComponent = _prefixId.prefix "JSConstraintComponent"
    /// <summary>
    ///   <para>rdfs:label : JavaScript executable</para>
    ///   <para>rdfs:comment : Abstract base class of resources that declare an executable JavaScript.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSExecutable">sh:JSExecutable</a>
    /// </summary>
    let JSExecutable = _prefixId.prefix "JSExecutable"
    /// <summary>
    ///   <para>rdfs:label : JavaScript function</para>
    ///   <para>rdfs:comment : The class of SHACL functions that execute a JavaScript function when called.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSFunction">sh:JSFunction</a>
    /// </summary>
    let JSFunction = _prefixId.prefix "JSFunction"
    /// <summary>
    ///   <para>rdfs:label : JavaScript library</para>
    ///   <para>rdfs:comment : Represents a JavaScript library, typically identified by one or more URLs of files to include.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSLibrary">sh:JSLibrary</a>
    /// </summary>
    let JSLibrary = _prefixId.prefix "JSLibrary"
    /// <summary>
    ///   <para>rdfs:label : JavaScript rule</para>
    ///   <para>rdfs:comment : The class of SHACL rules expressed using JavaScript.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSRule">sh:JSRule</a>
    /// </summary>
    let JSRule = _prefixId.prefix "JSRule"
    /// <summary>
    ///   <para>rdfs:label : JavaScript target</para>
    ///   <para>rdfs:comment : The class of targets that are based on JavaScript functions.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSTarget">sh:JSTarget</a>
    /// </summary>
    let JSTarget = _prefixId.prefix "JSTarget"
    /// <summary>
    ///   <para>rdfs:label : JavaScript target type</para>
    ///   <para>rdfs:comment : The (meta) class for parameterizable targets that are based on JavaScript functions.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSTargetType">sh:JSTargetType</a>
    /// </summary>
    let JSTargetType = _prefixId.prefix "JSTargetType"
    /// <summary>
    ///   <para>rdfs:label : JavaScript validator</para>
    ///   <para>rdfs:comment : A SHACL validator based on JavaScript. This can be used to declare SHACL constraint components that perform JavaScript-based validation when used.</para>
    ///   <a href="http://www.w3.org/ns/shacl#JSValidator">sh:JSValidator</a>
    /// </summary>
    let JSValidator = _prefixId.prefix "JSValidator"
    let LanguageInConstraintComponent = _prefixId.prefix "LanguageInConstraintComponent"

    let LanguageInConstraintComponent_languageIn =
        _prefixId.prefix "LanguageInConstraintComponent-languageIn"

    let LessThanConstraintComponent = _prefixId.prefix "LessThanConstraintComponent"

    let LessThanConstraintComponent_lessThan =
        _prefixId.prefix "LessThanConstraintComponent-lessThan"

    let LessThanOrEqualsConstraintComponent =
        _prefixId.prefix "LessThanOrEqualsConstraintComponent"

    let LessThanOrEqualsConstraintComponent_lessThanOrEquals =
        _prefixId.prefix "LessThanOrEqualsConstraintComponent-lessThanOrEquals"

    let Literal = _prefixId.prefix "Literal"
    let MaxCountConstraintComponent = _prefixId.prefix "MaxCountConstraintComponent"

    let MaxCountConstraintComponent_maxCount =
        _prefixId.prefix "MaxCountConstraintComponent-maxCount"

    let MaxExclusiveConstraintComponent =
        _prefixId.prefix "MaxExclusiveConstraintComponent"

    let MaxExclusiveConstraintComponent_maxExclusive =
        _prefixId.prefix "MaxExclusiveConstraintComponent-maxExclusive"

    let MaxInclusiveConstraintComponent =
        _prefixId.prefix "MaxInclusiveConstraintComponent"

    let MaxInclusiveConstraintComponent_maxInclusive =
        _prefixId.prefix "MaxInclusiveConstraintComponent-maxInclusive"

    let MaxLengthConstraintComponent = _prefixId.prefix "MaxLengthConstraintComponent"

    let MaxLengthConstraintComponent_maxLength =
        _prefixId.prefix "MaxLengthConstraintComponent-maxLength"

    let MinCountConstraintComponent = _prefixId.prefix "MinCountConstraintComponent"

    let MinCountConstraintComponent_minCount =
        _prefixId.prefix "MinCountConstraintComponent-minCount"

    let MinExclusiveConstraintComponent =
        _prefixId.prefix "MinExclusiveConstraintComponent"

    let MinExclusiveConstraintComponent_minExclusive =
        _prefixId.prefix "MinExclusiveConstraintComponent-minExclusive"

    let MinInclusiveConstraintComponent =
        _prefixId.prefix "MinInclusiveConstraintComponent"

    let MinInclusiveConstraintComponent_minInclusive =
        _prefixId.prefix "MinInclusiveConstraintComponent-minInclusive"

    let MinLengthConstraintComponent = _prefixId.prefix "MinLengthConstraintComponent"

    let MinLengthConstraintComponent_minLength =
        _prefixId.prefix "MinLengthConstraintComponent-minLength"

    let NodeConstraintComponent = _prefixId.prefix "NodeConstraintComponent"
    let NodeConstraintComponent_node = _prefixId.prefix "NodeConstraintComponent-node"
    /// <summary>
    ///   <para>rdfs:label : Node kind</para>
    ///   <para>rdfs:comment : The class of all node kinds, including sh:BlankNode, sh:IRI, sh:Literal or the combinations of these: sh:BlankNodeOrIRI, sh:BlankNodeOrLiteral, sh:IRIOrLiteral.</para>
    ///   <a href="http://www.w3.org/ns/shacl#NodeKind">sh:NodeKind</a>
    /// </summary>
    let NodeKind = _prefixId.prefix "NodeKind"
    let NodeKindConstraintComponent = _prefixId.prefix "NodeKindConstraintComponent"

    let NodeKindConstraintComponent_nodeKind =
        _prefixId.prefix "NodeKindConstraintComponent-nodeKind"

    /// <summary>
    ///   <para>rdfs:label : Node shape</para>
    ///   <para>rdfs:comment : A node shape is a shape that specifies constraint that need to be met with respect to focus nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#NodeShape">sh:NodeShape</a>
    /// </summary>
    let NodeShape = _prefixId.prefix "NodeShape"
    let NotConstraintComponent = _prefixId.prefix "NotConstraintComponent"
    let NotConstraintComponent_not = _prefixId.prefix "NotConstraintComponent-not"
    let OrConstraintComponent = _prefixId.prefix "OrConstraintComponent"
    let OrConstraintComponent_or = _prefixId.prefix "OrConstraintComponent-or"
    /// <summary>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : The class of parameter declarations, consisting of a path predicate and (possibly) information about allowed value type, cardinality and other characteristics.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Parameter">sh:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : Parameterizable</para>
    ///   <para>rdfs:comment : Superclass of components that can take parameters, especially functions and constraint components.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Parameterizable">sh:Parameterizable</a>
    /// </summary>
    let Parameterizable = _prefixId.prefix "Parameterizable"
    let PatternConstraintComponent = _prefixId.prefix "PatternConstraintComponent"

    let PatternConstraintComponent_flags =
        _prefixId.prefix "PatternConstraintComponent-flags"

    let PatternConstraintComponent_pattern =
        _prefixId.prefix "PatternConstraintComponent-pattern"

    /// <summary>
    ///   <para>rdfs:label : Prefix declaration</para>
    ///   <para>rdfs:comment : The class of prefix declarations, consisting of pairs of a prefix with a namespace.</para>
    ///   <a href="http://www.w3.org/ns/shacl#PrefixDeclaration">sh:PrefixDeclaration</a>
    /// </summary>
    let PrefixDeclaration = _prefixId.prefix "PrefixDeclaration"
    let PropertyConstraintComponent = _prefixId.prefix "PropertyConstraintComponent"

    let PropertyConstraintComponent_property =
        _prefixId.prefix "PropertyConstraintComponent-property"

    /// <summary>
    ///   <para>rdfs:label : Property group</para>
    ///   <para>rdfs:comment : Instances of this class represent groups of property shapes that belong together.</para>
    ///   <a href="http://www.w3.org/ns/shacl#PropertyGroup">sh:PropertyGroup</a>
    /// </summary>
    let PropertyGroup = _prefixId.prefix "PropertyGroup"
    /// <summary>
    ///   <para>rdfs:label : Property shape</para>
    ///   <para>rdfs:comment : A property shape is a shape that specifies constraints on the values of a focus node for a given property or path.</para>
    ///   <a href="http://www.w3.org/ns/shacl#PropertyShape">sh:PropertyShape</a>
    /// </summary>
    let PropertyShape = _prefixId.prefix "PropertyShape"

    let QualifiedMaxCountConstraintComponent =
        _prefixId.prefix "QualifiedMaxCountConstraintComponent"

    let QualifiedMaxCountConstraintComponent_qualifiedMaxCount =
        _prefixId.prefix "QualifiedMaxCountConstraintComponent-qualifiedMaxCount"

    let QualifiedMaxCountConstraintComponent_qualifiedValueShape =
        _prefixId.prefix "QualifiedMaxCountConstraintComponent-qualifiedValueShape"

    let QualifiedMaxCountConstraintComponent_qualifiedValueShapesDisjoint =
        _prefixId.prefix "QualifiedMaxCountConstraintComponent-qualifiedValueShapesDisjoint"

    let QualifiedMinCountConstraintComponent =
        _prefixId.prefix "QualifiedMinCountConstraintComponent"

    let QualifiedMinCountConstraintComponent_qualifiedMinCount =
        _prefixId.prefix "QualifiedMinCountConstraintComponent-qualifiedMinCount"

    let QualifiedMinCountConstraintComponent_qualifiedValueShape =
        _prefixId.prefix "QualifiedMinCountConstraintComponent-qualifiedValueShape"

    let QualifiedMinCountConstraintComponent_qualifiedValueShapesDisjoint =
        _prefixId.prefix "QualifiedMinCountConstraintComponent-qualifiedValueShapesDisjoint"

    /// <summary>
    ///   <para>rdfs:label : Result annotation</para>
    ///   <para>rdfs:comment : A class of result annotations, which define the rules to derive the values of a given annotation property as extra values for a validation result.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ResultAnnotation">sh:ResultAnnotation</a>
    /// </summary>
    let ResultAnnotation = _prefixId.prefix "ResultAnnotation"
    /// <summary>
    ///   <para>rdfs:label : Rule</para>
    ///   <para>rdfs:comment : The class of SHACL rules. Never instantiated directly.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Rule">sh:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:label : SPARQL ASK executable</para>
    ///   <para>rdfs:comment : The class of SPARQL executables that are based on an ASK query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLAskExecutable">sh:SPARQLAskExecutable</a>
    /// </summary>
    let SPARQLAskExecutable = _prefixId.prefix "SPARQLAskExecutable"
    /// <summary>
    ///   <para>rdfs:label : SPARQL ASK validator</para>
    ///   <para>rdfs:comment : The class of validators based on SPARQL ASK queries. The queries are evaluated for each value node and are supposed to return true if the given node conforms.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLAskValidator">sh:SPARQLAskValidator</a>
    /// </summary>
    let SPARQLAskValidator = _prefixId.prefix "SPARQLAskValidator"
    /// <summary>
    ///   <para>rdfs:label : SPARQL constraint</para>
    ///   <para>rdfs:comment : The class of constraints based on SPARQL SELECT queries.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLConstraint">sh:SPARQLConstraint</a>
    /// </summary>
    let SPARQLConstraint = _prefixId.prefix "SPARQLConstraint"
    let SPARQLConstraintComponent = _prefixId.prefix "SPARQLConstraintComponent"

    let SPARQLConstraintComponent_sparql =
        _prefixId.prefix "SPARQLConstraintComponent-sparql"

    /// <summary>
    ///   <para>rdfs:label : SPARQL CONSTRUCT executable</para>
    ///   <para>rdfs:comment : The class of SPARQL executables that are based on a CONSTRUCT query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLConstructExecutable">sh:SPARQLConstructExecutable</a>
    /// </summary>
    let SPARQLConstructExecutable = _prefixId.prefix "SPARQLConstructExecutable"
    /// <summary>
    ///   <para>rdfs:label : SPARQL executable</para>
    ///   <para>rdfs:comment : The class of resources that encapsulate a SPARQL query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLExecutable">sh:SPARQLExecutable</a>
    /// </summary>
    let SPARQLExecutable = _prefixId.prefix "SPARQLExecutable"
    /// <summary>
    ///   <para>rdfs:label : SPARQL function</para>
    ///   <para>rdfs:comment : A function backed by a SPARQL query - either ASK or SELECT.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLFunction">sh:SPARQLFunction</a>
    /// </summary>
    let SPARQLFunction = _prefixId.prefix "SPARQLFunction"
    /// <summary>
    ///   <para>rdfs:label : SPARQL CONSTRUCT rule</para>
    ///   <para>rdfs:comment : The class of SHACL rules based on SPARQL CONSTRUCT queries.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLRule">sh:SPARQLRule</a>
    /// </summary>
    let SPARQLRule = _prefixId.prefix "SPARQLRule"
    /// <summary>
    ///   <para>rdfs:label : SPARQL SELECT executable</para>
    ///   <para>rdfs:comment : The class of SPARQL executables based on a SELECT query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLSelectExecutable">sh:SPARQLSelectExecutable</a>
    /// </summary>
    let SPARQLSelectExecutable = _prefixId.prefix "SPARQLSelectExecutable"
    /// <summary>
    ///   <para>rdfs:label : SPARQL SELECT validator</para>
    ///   <para>rdfs:comment : The class of validators based on SPARQL SELECT queries. The queries are evaluated for each focus node and are supposed to produce bindings for all focus nodes that do not conform.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLSelectValidator">sh:SPARQLSelectValidator</a>
    /// </summary>
    let SPARQLSelectValidator = _prefixId.prefix "SPARQLSelectValidator"
    /// <summary>
    ///   <para>rdfs:label : SPARQL target</para>
    ///   <para>rdfs:comment : The class of targets that are based on SPARQL queries.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLTarget">sh:SPARQLTarget</a>
    /// </summary>
    let SPARQLTarget = _prefixId.prefix "SPARQLTarget"
    /// <summary>
    ///   <para>rdfs:label : SPARQL target type</para>
    ///   <para>rdfs:comment : The (meta) class for parameterizable targets that are based on SPARQL queries.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLTargetType">sh:SPARQLTargetType</a>
    /// </summary>
    let SPARQLTargetType = _prefixId.prefix "SPARQLTargetType"
    /// <summary>
    ///   <para>rdfs:label : SPARQL UPDATE executable</para>
    ///   <para>rdfs:comment : The class of SPARQL executables based on a SPARQL UPDATE.</para>
    ///   <a href="http://www.w3.org/ns/shacl#SPARQLUpdateExecutable">sh:SPARQLUpdateExecutable</a>
    /// </summary>
    let SPARQLUpdateExecutable = _prefixId.prefix "SPARQLUpdateExecutable"
    /// <summary>
    ///   <para>rdfs:label : Severity</para>
    ///   <para>rdfs:comment : The class of validation result severity levels, including violation and warning levels.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Severity">sh:Severity</a>
    /// </summary>
    let Severity = _prefixId.prefix "Severity"
    /// <summary>
    ///   <para>rdfs:label : Shape</para>
    ///   <para>rdfs:comment : A shape is a collection of constraints that may be targeted for certain nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Shape">sh:Shape</a>
    /// </summary>
    let Shape = _prefixId.prefix "Shape"
    /// <summary>
    ///   <para>rdfs:label : Target</para>
    ///   <para>rdfs:comment : The base class of targets such as those based on SPARQL queries.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Target">sh:Target</a>
    /// </summary>
    let Target = _prefixId.prefix "Target"
    /// <summary>
    ///   <para>rdfs:label : Target type</para>
    ///   <para>rdfs:comment : The (meta) class for parameterizable targets.	Instances of this are instantiated as values of the sh:target property.</para>
    ///   <a href="http://www.w3.org/ns/shacl#TargetType">sh:TargetType</a>
    /// </summary>
    let TargetType = _prefixId.prefix "TargetType"
    /// <summary>
    ///   <para>rdfs:label : A rule based on triple (subject, predicate, object) pattern.</para>
    ///   <a href="http://www.w3.org/ns/shacl#TripleRule">sh:TripleRule</a>
    /// </summary>
    let TripleRule = _prefixId.prefix "TripleRule"
    let UniqueLangConstraintComponent = _prefixId.prefix "UniqueLangConstraintComponent"

    let UniqueLangConstraintComponent_uniqueLang =
        _prefixId.prefix "UniqueLangConstraintComponent-uniqueLang"

    /// <summary>
    ///   <para>rdfs:label : Validation report</para>
    ///   <para>rdfs:comment : The class of SHACL validation reports.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ValidationReport">sh:ValidationReport</a>
    /// </summary>
    let ValidationReport = _prefixId.prefix "ValidationReport"
    /// <summary>
    ///   <para>rdfs:label : Validation result</para>
    ///   <para>rdfs:comment : The class of validation results.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ValidationResult">sh:ValidationResult</a>
    /// </summary>
    let ValidationResult = _prefixId.prefix "ValidationResult"
    /// <summary>
    ///   <para>rdfs:label : Validator</para>
    ///   <para>rdfs:comment : The class of validators, which provide instructions on how to process a constraint definition. This class serves as base class for the SPARQL-based validators and other possible implementations.</para>
    ///   <a href="http://www.w3.org/ns/shacl#Validator">sh:Validator</a>
    /// </summary>
    let Validator = _prefixId.prefix "Validator"
    let Violation = _prefixId.prefix "Violation"
    let Warning = _prefixId.prefix "Warning"
    let XoneConstraintComponent = _prefixId.prefix "XoneConstraintComponent"
    let XoneConstraintComponent_xone = _prefixId.prefix "XoneConstraintComponent-xone"
    /// <summary>
    ///   <para>rdfs:label : alternative path</para>
    ///   <para>rdfs:comment : The (single) value of this property must be a list of path elements, representing the elements of alternative paths.</para>
    ///   <a href="http://www.w3.org/ns/shacl#alternativePath">sh:alternativePath</a>
    /// </summary>
    let alternativePath = _prefixId.prefix "alternativePath"
    /// <summary>
    ///   <para>rdfs:label : and</para>
    ///   <para>rdfs:comment : RDF list of shapes to validate the value nodes against.</para>
    ///   <a href="http://www.w3.org/ns/shacl#and">sh:and</a>
    /// </summary>
    let and_ = _prefixId.prefix "and"
    /// <summary>
    ///   <para>rdfs:label : annotation property</para>
    ///   <para>rdfs:comment : The annotation property that shall be set.</para>
    ///   <a href="http://www.w3.org/ns/shacl#annotationProperty">sh:annotationProperty</a>
    /// </summary>
    let annotationProperty = _prefixId.prefix "annotationProperty"
    /// <summary>
    ///   <para>rdfs:label : annotation value</para>
    ///   <para>rdfs:comment : The (default) values of the annotation property.</para>
    ///   <a href="http://www.w3.org/ns/shacl#annotationValue">sh:annotationValue</a>
    /// </summary>
    let annotationValue = _prefixId.prefix "annotationValue"
    /// <summary>
    ///   <para>rdfs:label : annotation variable name</para>
    ///   <para>rdfs:comment : The name of the SPARQL variable from the SELECT clause that shall be used for the values.</para>
    ///   <a href="http://www.w3.org/ns/shacl#annotationVarName">sh:annotationVarName</a>
    /// </summary>
    let annotationVarName = _prefixId.prefix "annotationVarName"
    /// <summary>
    ///   <para>rdfs:label : ask</para>
    ///   <para>rdfs:comment : The SPARQL ASK query to execute.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ask">sh:ask</a>
    /// </summary>
    let ask = _prefixId.prefix "ask"
    /// <summary>
    ///   <para>rdfs:label : class</para>
    ///   <para>rdfs:comment : The type that all value nodes must have.</para>
    ///   <a href="http://www.w3.org/ns/shacl#class">sh:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : closed</para>
    ///   <para>rdfs:comment : If set to true then the shape is closed.</para>
    ///   <a href="http://www.w3.org/ns/shacl#closed">sh:closed</a>
    /// </summary>
    let closed = _prefixId.prefix "closed"
    /// <summary>
    ///   <para>rdfs:label : condition</para>
    ///   <para>rdfs:comment : The shapes that the focus nodes need to conform to before a rule is executed on them.</para>
    ///   <a href="http://www.w3.org/ns/shacl#condition">sh:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : conforms</para>
    ///   <para>rdfs:comment : True if the validation did not produce any validation results, and false otherwise.</para>
    ///   <a href="http://www.w3.org/ns/shacl#conforms">sh:conforms</a>
    /// </summary>
    let conforms = _prefixId.prefix "conforms"
    /// <summary>
    ///   <para>rdfs:label : construct</para>
    ///   <para>rdfs:comment : The SPARQL CONSTRUCT query to execute.</para>
    ///   <a href="http://www.w3.org/ns/shacl#construct">sh:construct</a>
    /// </summary>
    let construct = _prefixId.prefix "construct"
    /// <summary>
    ///   <para>rdfs:label : datatype</para>
    ///   <para>rdfs:comment : Specifies an RDF datatype that all value nodes must have.</para>
    ///   <a href="http://www.w3.org/ns/shacl#datatype">sh:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : deactivated</para>
    ///   <para>rdfs:comment : If set to true then all nodes conform to this.</para>
    ///   <a href="http://www.w3.org/ns/shacl#deactivated">sh:deactivated</a>
    /// </summary>
    let deactivated = _prefixId.prefix "deactivated"
    /// <summary>
    ///   <para>rdfs:label : declare</para>
    ///   <para>rdfs:comment : Links a resource with its namespace prefix declarations.</para>
    ///   <a href="http://www.w3.org/ns/shacl#declare">sh:declare</a>
    /// </summary>
    let declare = _prefixId.prefix "declare"
    /// <summary>
    ///   <para>rdfs:label : default value</para>
    ///   <para>rdfs:comment : A default value for a property, for example for user interface tools to pre-populate input fields.</para>
    ///   <a href="http://www.w3.org/ns/shacl#defaultValue">sh:defaultValue</a>
    /// </summary>
    let defaultValue = _prefixId.prefix "defaultValue"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : Human-readable descriptions for the property in the context of the surrounding shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#description">sh:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : detail</para>
    ///   <para>rdfs:comment : Links a result with other results that provide more details, for example to describe violations against nested shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#detail">sh:detail</a>
    /// </summary>
    let detail = _prefixId.prefix "detail"
    /// <summary>
    ///   <para>rdfs:label : disjoint</para>
    ///   <para>rdfs:comment : Specifies a property where the set of values must be disjoint with the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#disjoint">sh:disjoint</a>
    /// </summary>
    let disjoint = _prefixId.prefix "disjoint"
    /// <summary>
    ///   <para>rdfs:label : entailment</para>
    ///   <para>rdfs:comment : An entailment regime that indicates what kind of inferencing is required by a shapes graph.</para>
    ///   <a href="http://www.w3.org/ns/shacl#entailment">sh:entailment</a>
    /// </summary>
    let entailment = _prefixId.prefix "entailment"
    /// <summary>
    ///   <para>rdfs:label : equals</para>
    ///   <para>rdfs:comment : Specifies a property that must have the same values as the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#equals">sh:equals</a>
    /// </summary>
    let equals = _prefixId.prefix "equals"
    /// <summary>
    ///   <para>rdfs:label : expression</para>
    ///   <para>rdfs:comment : The node expression that must return true for the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#expression">sh:expression</a>
    /// </summary>
    let expression = _prefixId.prefix "expression"
    /// <summary>
    ///   <para>rdfs:label : filter shape</para>
    ///   <para>rdfs:comment : The shape that all input nodes of the expression need to conform to.</para>
    ///   <a href="http://www.w3.org/ns/shacl#filterShape">sh:filterShape</a>
    /// </summary>
    let filterShape = _prefixId.prefix "filterShape"
    /// <summary>
    ///   <para>rdfs:label : flags</para>
    ///   <para>rdfs:comment : An optional flag to be used with regular expression pattern matching.</para>
    ///   <a href="http://www.w3.org/ns/shacl#flags">sh:flags</a>
    /// </summary>
    let flags = _prefixId.prefix "flags"
    /// <summary>
    ///   <para>rdfs:label : focus node</para>
    ///   <para>rdfs:comment : The focus node that was validated when the result was produced.</para>
    ///   <a href="http://www.w3.org/ns/shacl#focusNode">sh:focusNode</a>
    /// </summary>
    let focusNode = _prefixId.prefix "focusNode"
    /// <summary>
    ///   <para>rdfs:label : group</para>
    ///   <para>rdfs:comment : Can be used to link to a property group to indicate that a property shape belongs to a group of related property shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#group">sh:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <para>rdfs:comment : Specifies a value that must be among the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#hasValue">sh:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : ignored properties</para>
    ///   <para>rdfs:comment : An optional RDF list of properties that are also permitted in addition to those explicitly enumerated via sh:property/sh:path.</para>
    ///   <a href="http://www.w3.org/ns/shacl#ignoredProperties">sh:ignoredProperties</a>
    /// </summary>
    let ignoredProperties = _prefixId.prefix "ignoredProperties"
    /// <summary>
    ///   <para>rdfs:label : in</para>
    ///   <para>rdfs:comment : Specifies a list of allowed values so that each value node must be among the members of the given list.</para>
    ///   <a href="http://www.w3.org/ns/shacl#in">sh:in</a>
    /// </summary>
    let in_ = _prefixId.prefix "in"
    /// <summary>
    ///   <para>rdfs:label : intersection</para>
    ///   <para>rdfs:comment : A list of node expressions that shall be intersected.</para>
    ///   <a href="http://www.w3.org/ns/shacl#intersection">sh:intersection</a>
    /// </summary>
    let intersection = _prefixId.prefix "intersection"
    /// <summary>
    ///   <para>rdfs:label : inverse path</para>
    ///   <para>rdfs:comment : The (single) value of this property represents an inverse path (object to subject).</para>
    ///   <a href="http://www.w3.org/ns/shacl#inversePath">sh:inversePath</a>
    /// </summary>
    let inversePath = _prefixId.prefix "inversePath"
    /// <summary>
    ///   <para>rdfs:label : JavaScript constraint</para>
    ///   <para>rdfs:comment : Constraints expressed in JavaScript.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/shacl#js">sh:js</a>
    /// </summary>
    let js = _prefixId.prefix "js"
    /// <summary>
    ///   <para>rdfs:label : JavaScript function name</para>
    ///   <para>rdfs:comment : The name of the JavaScript function to execute.</para>
    ///   <a href="http://www.w3.org/ns/shacl#jsFunctionName">sh:jsFunctionName</a>
    /// </summary>
    let jsFunctionName = _prefixId.prefix "jsFunctionName"
    /// <summary>
    ///   <para>rdfs:label : JavaScript library</para>
    ///   <para>rdfs:comment : Declares which JavaScript libraries are needed to execute this.</para>
    ///   <a href="http://www.w3.org/ns/shacl#jsLibrary">sh:jsLibrary</a>
    /// </summary>
    let jsLibrary = _prefixId.prefix "jsLibrary"
    /// <summary>
    ///   <para>rdfs:label : JavaScript library URL</para>
    ///   <para>rdfs:comment : Declares the URLs of a JavaScript library. This should be the absolute URL of a JavaScript file. Implementations may redirect those to local files.</para>
    ///   <a href="http://www.w3.org/ns/shacl#jsLibraryURL">sh:jsLibraryURL</a>
    /// </summary>
    let jsLibraryURL = _prefixId.prefix "jsLibraryURL"
    /// <summary>
    ///   <para>rdfs:label : label template</para>
    ///   <para>rdfs:comment : Outlines how human-readable labels of instances of the associated Parameterizable shall be produced. The values can contain {?paramName} as placeholders for the actual values of the given parameter.</para>
    ///   <a href="http://www.w3.org/ns/shacl#labelTemplate">sh:labelTemplate</a>
    /// </summary>
    let labelTemplate = _prefixId.prefix "labelTemplate"
    /// <summary>
    ///   <para>rdfs:label : language in</para>
    ///   <para>rdfs:comment : Specifies a list of language tags that all value nodes must have.</para>
    ///   <a href="http://www.w3.org/ns/shacl#languageIn">sh:languageIn</a>
    /// </summary>
    let languageIn = _prefixId.prefix "languageIn"
    /// <summary>
    ///   <para>rdfs:label : less than</para>
    ///   <para>rdfs:comment : Specifies a property that must have smaller values than the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#lessThan">sh:lessThan</a>
    /// </summary>
    let lessThan = _prefixId.prefix "lessThan"
    /// <summary>
    ///   <para>rdfs:label : less than or equals</para>
    ///   <para>rdfs:comment : Specifies a property that must have smaller or equal values than the value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#lessThanOrEquals">sh:lessThanOrEquals</a>
    /// </summary>
    let lessThanOrEquals = _prefixId.prefix "lessThanOrEquals"
    /// <summary>
    ///   <para>rdfs:label : max count</para>
    ///   <para>rdfs:comment : Specifies the maximum number of values in the set of value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#maxCount">sh:maxCount</a>
    /// </summary>
    let maxCount = _prefixId.prefix "maxCount"
    /// <summary>
    ///   <para>rdfs:label : max exclusive</para>
    ///   <para>rdfs:comment : Specifies the maximum exclusive value of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#maxExclusive">sh:maxExclusive</a>
    /// </summary>
    let maxExclusive = _prefixId.prefix "maxExclusive"
    /// <summary>
    ///   <para>rdfs:label : max inclusive</para>
    ///   <para>rdfs:comment : Specifies the maximum inclusive value of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#maxInclusive">sh:maxInclusive</a>
    /// </summary>
    let maxInclusive = _prefixId.prefix "maxInclusive"
    /// <summary>
    ///   <para>rdfs:label : max length</para>
    ///   <para>rdfs:comment : Specifies the maximum string length of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#maxLength">sh:maxLength</a>
    /// </summary>
    let maxLength = _prefixId.prefix "maxLength"
    /// <summary>
    ///   <para>rdfs:label : message</para>
    ///   <para>rdfs:comment : A human-readable message (possibly with placeholders for variables) explaining the cause of the result.</para>
    ///   <a href="http://www.w3.org/ns/shacl#message">sh:message</a>
    /// </summary>
    let message = _prefixId.prefix "message"
    /// <summary>
    ///   <para>rdfs:label : min count</para>
    ///   <para>rdfs:comment : Specifies the minimum number of values in the set of value nodes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#minCount">sh:minCount</a>
    /// </summary>
    let minCount = _prefixId.prefix "minCount"
    /// <summary>
    ///   <para>rdfs:label : min exclusive</para>
    ///   <para>rdfs:comment : Specifies the minimum exclusive value of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#minExclusive">sh:minExclusive</a>
    /// </summary>
    let minExclusive = _prefixId.prefix "minExclusive"
    /// <summary>
    ///   <para>rdfs:label : min inclusive</para>
    ///   <para>rdfs:comment : Specifies the minimum inclusive value of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#minInclusive">sh:minInclusive</a>
    /// </summary>
    let minInclusive = _prefixId.prefix "minInclusive"
    /// <summary>
    ///   <para>rdfs:label : min length</para>
    ///   <para>rdfs:comment : Specifies the minimum string length of each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#minLength">sh:minLength</a>
    /// </summary>
    let minLength = _prefixId.prefix "minLength"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : Human-readable labels for the property in the context of the surrounding shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#name">sh:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : namespace</para>
    ///   <para>rdfs:comment : The namespace associated with a prefix in a prefix declaration.</para>
    ///   <a href="http://www.w3.org/ns/shacl#namespace">sh:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>rdfs:label : node</para>
    ///   <para>rdfs:comment : Specifies the node shape that all value nodes must conform to.</para>
    ///   <a href="http://www.w3.org/ns/shacl#node">sh:node</a>
    /// </summary>
    let node = _prefixId.prefix "node"
    /// <summary>
    ///   <para>rdfs:label : node kind</para>
    ///   <para>rdfs:comment : Specifies the node kind (e.g. IRI or literal) each value node.</para>
    ///   <a href="http://www.w3.org/ns/shacl#nodeKind">sh:nodeKind</a>
    /// </summary>
    let nodeKind = _prefixId.prefix "nodeKind"
    /// <summary>
    ///   <para>rdfs:label : shape validator</para>
    ///   <para>rdfs:comment : The validator(s) used to evaluate a constraint in the context of a node shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#nodeValidator">sh:nodeValidator</a>
    /// </summary>
    let nodeValidator = _prefixId.prefix "nodeValidator"
    /// <summary>
    ///   <para>rdfs:label : nodes</para>
    ///   <para>rdfs:comment : The node expression producing the input nodes of a filter shape expression.</para>
    ///   <a href="http://www.w3.org/ns/shacl#nodes">sh:nodes</a>
    /// </summary>
    let nodes = _prefixId.prefix "nodes"
    /// <summary>
    ///   <para>rdfs:label : not</para>
    ///   <para>rdfs:comment : Specifies a shape that the value nodes must not conform to.</para>
    ///   <a href="http://www.w3.org/ns/shacl#not">sh:not</a>
    /// </summary>
    let ``not`` = _prefixId.prefix "not"
    /// <summary>
    ///   <para>rdfs:label : object</para>
    ///   <para>rdfs:comment : An expression producing the nodes that shall be inferred as objects.</para>
    ///   <a href="http://www.w3.org/ns/shacl#object">sh:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : one or more path</para>
    ///   <para>rdfs:comment : The (single) value of this property represents a path that is matched one or more times.</para>
    ///   <a href="http://www.w3.org/ns/shacl#oneOrMorePath">sh:oneOrMorePath</a>
    /// </summary>
    let oneOrMorePath = _prefixId.prefix "oneOrMorePath"
    /// <summary>
    ///   <para>rdfs:label : optional</para>
    ///   <para>rdfs:comment : Indicates whether a parameter is optional.</para>
    ///   <a href="http://www.w3.org/ns/shacl#optional">sh:optional</a>
    /// </summary>
    let optional = _prefixId.prefix "optional"
    /// <summary>
    ///   <para>rdfs:label : or</para>
    ///   <para>rdfs:comment : Specifies a list of shapes so that the value nodes must conform to at least one of the shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#or">sh:or</a>
    /// </summary>
    let or_ = _prefixId.prefix "or"
    /// <summary>
    ///   <para>rdfs:label : order</para>
    ///   <para>rdfs:comment : Specifies the relative order of this compared to its siblings. For example use 0 for the first, 1 for the second.</para>
    ///   <a href="http://www.w3.org/ns/shacl#order">sh:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:label : parameter</para>
    ///   <para>rdfs:comment : The parameters of a function or constraint component.</para>
    ///   <a href="http://www.w3.org/ns/shacl#parameter">sh:parameter</a>
    /// </summary>
    let parameter = _prefixId.prefix "parameter"
    /// <summary>
    ///   <para>rdfs:label : path</para>
    ///   <para>rdfs:comment : Specifies the property path of a property shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#path">sh:path</a>
    /// </summary>
    let path = _prefixId.prefix "path"
    /// <summary>
    ///   <para>rdfs:label : pattern</para>
    ///   <para>rdfs:comment : Specifies a regular expression pattern that the string representations of the value nodes must match.</para>
    ///   <a href="http://www.w3.org/ns/shacl#pattern">sh:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : predicate</para>
    ///   <para>rdfs:comment : An expression producing the properties that shall be inferred as predicates.</para>
    ///   <a href="http://www.w3.org/ns/shacl#predicate">sh:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:label : prefix</para>
    ///   <para>rdfs:comment : The prefix of a prefix declaration.</para>
    ///   <a href="http://www.w3.org/ns/shacl#prefix">sh:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:label : prefixes</para>
    ///   <para>rdfs:comment : The prefixes that shall be applied before parsing the associated SPARQL query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#prefixes">sh:prefixes</a>
    /// </summary>
    let prefixes = _prefixId.prefix "prefixes"
    /// <summary>
    ///   <para>rdfs:label : property</para>
    ///   <para>rdfs:comment : Links a shape to its property shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#property">sh:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : property validator</para>
    ///   <para>rdfs:comment : The validator(s) used to evaluate a constraint in the context of a property shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#propertyValidator">sh:propertyValidator</a>
    /// </summary>
    let propertyValidator = _prefixId.prefix "propertyValidator"
    /// <summary>
    ///   <para>rdfs:label : qualified max count</para>
    ///   <para>rdfs:comment : The maximum number of value nodes that can conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#qualifiedMaxCount">sh:qualifiedMaxCount</a>
    /// </summary>
    let qualifiedMaxCount = _prefixId.prefix "qualifiedMaxCount"
    /// <summary>
    ///   <para>rdfs:label : qualified min count</para>
    ///   <para>rdfs:comment : The minimum number of value nodes that must conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#qualifiedMinCount">sh:qualifiedMinCount</a>
    /// </summary>
    let qualifiedMinCount = _prefixId.prefix "qualifiedMinCount"
    /// <summary>
    ///   <para>rdfs:label : qualified value shape</para>
    ///   <para>rdfs:comment : The shape that a specified number of values must conform to.</para>
    ///   <a href="http://www.w3.org/ns/shacl#qualifiedValueShape">sh:qualifiedValueShape</a>
    /// </summary>
    let qualifiedValueShape = _prefixId.prefix "qualifiedValueShape"
    /// <summary>
    ///   <para>rdfs:label : qualified value shapes disjoint</para>
    ///   <para>rdfs:comment : Can be used to mark the qualified value shape to be disjoint with its sibling shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#qualifiedValueShapesDisjoint">sh:qualifiedValueShapesDisjoint</a>
    /// </summary>
    let qualifiedValueShapesDisjoint = _prefixId.prefix "qualifiedValueShapesDisjoint"
    /// <summary>
    ///   <para>rdfs:label : result</para>
    ///   <para>rdfs:comment : The validation results contained in a validation report.</para>
    ///   <a href="http://www.w3.org/ns/shacl#result">sh:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:label : result annotation</para>
    ///   <para>rdfs:comment : Links a SPARQL validator with zero or more sh:ResultAnnotation instances, defining how to derive additional result properties based on the variables of the SELECT query.</para>
    ///   <a href="http://www.w3.org/ns/shacl#resultAnnotation">sh:resultAnnotation</a>
    /// </summary>
    let resultAnnotation = _prefixId.prefix "resultAnnotation"
    /// <summary>
    ///   <para>rdfs:label : result message</para>
    ///   <para>rdfs:comment : Human-readable messages explaining the cause of the result.</para>
    ///   <a href="http://www.w3.org/ns/shacl#resultMessage">sh:resultMessage</a>
    /// </summary>
    let resultMessage = _prefixId.prefix "resultMessage"
    /// <summary>
    ///   <para>rdfs:label : result path</para>
    ///   <para>rdfs:comment : The path of a validation result, based on the path of the validated property shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#resultPath">sh:resultPath</a>
    /// </summary>
    let resultPath = _prefixId.prefix "resultPath"
    /// <summary>
    ///   <para>rdfs:label : result severity</para>
    ///   <para>rdfs:comment : The severity of the result, e.g. warning.</para>
    ///   <a href="http://www.w3.org/ns/shacl#resultSeverity">sh:resultSeverity</a>
    /// </summary>
    let resultSeverity = _prefixId.prefix "resultSeverity"
    /// <summary>
    ///   <para>rdfs:label : return type</para>
    ///   <para>rdfs:comment : The expected type of values returned by the associated function.</para>
    ///   <a href="http://www.w3.org/ns/shacl#returnType">sh:returnType</a>
    /// </summary>
    let returnType = _prefixId.prefix "returnType"
    /// <summary>
    ///   <para>rdfs:label : rule</para>
    ///   <para>rdfs:comment : The rules linked to a shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#rule">sh:rule</a>
    /// </summary>
    let rule = _prefixId.prefix "rule"
    /// <summary>
    ///   <para>rdfs:label : select</para>
    ///   <para>rdfs:comment : The SPARQL SELECT query to execute.</para>
    ///   <a href="http://www.w3.org/ns/shacl#select">sh:select</a>
    /// </summary>
    let select = _prefixId.prefix "select"
    /// <summary>
    ///   <para>rdfs:label : severity</para>
    ///   <para>rdfs:comment : Defines the severity that validation results produced by a shape must have. Defaults to sh:Violation.</para>
    ///   <a href="http://www.w3.org/ns/shacl#severity">sh:severity</a>
    /// </summary>
    let severity = _prefixId.prefix "severity"
    /// <summary>
    ///   <para>rdfs:label : shapes graph</para>
    ///   <para>rdfs:comment : Shapes graphs that should be used when validating this data graph.</para>
    ///   <a href="http://www.w3.org/ns/shacl#shapesGraph">sh:shapesGraph</a>
    /// </summary>
    let shapesGraph = _prefixId.prefix "shapesGraph"
    /// <summary>
    ///   <para>rdfs:label : shapes graph well-formed</para>
    ///   <para>rdfs:comment : If true then the validation engine was certain that the shapes graph has passed all SHACL syntax requirements during the validation process.</para>
    ///   <a href="http://www.w3.org/ns/shacl#shapesGraphWellFormed">sh:shapesGraphWellFormed</a>
    /// </summary>
    let shapesGraphWellFormed = _prefixId.prefix "shapesGraphWellFormed"
    /// <summary>
    ///   <para>rdfs:label : source constraint</para>
    ///   <para>rdfs:comment : The constraint that was validated when the result was produced.</para>
    ///   <a href="http://www.w3.org/ns/shacl#sourceConstraint">sh:sourceConstraint</a>
    /// </summary>
    let sourceConstraint = _prefixId.prefix "sourceConstraint"
    /// <summary>
    ///   <para>rdfs:label : source constraint component</para>
    ///   <para>rdfs:comment : The constraint component that is the source of the result.</para>
    ///   <a href="http://www.w3.org/ns/shacl#sourceConstraintComponent">sh:sourceConstraintComponent</a>
    /// </summary>
    let sourceConstraintComponent = _prefixId.prefix "sourceConstraintComponent"
    /// <summary>
    ///   <para>rdfs:label : source shape</para>
    ///   <para>rdfs:comment : The shape that is was validated when the result was produced.</para>
    ///   <a href="http://www.w3.org/ns/shacl#sourceShape">sh:sourceShape</a>
    /// </summary>
    let sourceShape = _prefixId.prefix "sourceShape"
    /// <summary>
    ///   <para>rdfs:label : constraint (in SPARQL)</para>
    ///   <para>rdfs:comment : Links a shape with SPARQL constraints.</para>
    ///   <a href="http://www.w3.org/ns/shacl#sparql">sh:sparql</a>
    /// </summary>
    let sparql = _prefixId.prefix "sparql"
    /// <summary>
    ///   <para>rdfs:label : subject</para>
    ///   <para>rdfs:comment : An expression producing the resources that shall be inferred as subjects.</para>
    ///   <a href="http://www.w3.org/ns/shacl#subject">sh:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : suggested shapes graph</para>
    ///   <para>rdfs:comment : Suggested shapes graphs for this ontology. The values of this property may be used in the absence of specific sh:shapesGraph statements.</para>
    ///   <a href="http://www.w3.org/ns/shacl#suggestedShapesGraph">sh:suggestedShapesGraph</a>
    /// </summary>
    let suggestedShapesGraph = _prefixId.prefix "suggestedShapesGraph"
    /// <summary>
    ///   <para>rdfs:label : target</para>
    ///   <para>rdfs:comment : Links a shape to a target specified by an extension language, for example instances of sh:SPARQLTarget.</para>
    ///   <a href="http://www.w3.org/ns/shacl#target">sh:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:label : target class</para>
    ///   <para>rdfs:comment : Links a shape to a class, indicating that all instances of the class must conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#targetClass">sh:targetClass</a>
    /// </summary>
    let targetClass = _prefixId.prefix "targetClass"
    /// <summary>
    ///   <para>rdfs:label : target node</para>
    ///   <para>rdfs:comment : Links a shape to individual nodes, indicating that these nodes must conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#targetNode">sh:targetNode</a>
    /// </summary>
    let targetNode = _prefixId.prefix "targetNode"
    /// <summary>
    ///   <para>rdfs:label : target objects of</para>
    ///   <para>rdfs:comment : Links a shape to a property, indicating that all all objects of triples that have the given property as their predicate must conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#targetObjectsOf">sh:targetObjectsOf</a>
    /// </summary>
    let targetObjectsOf = _prefixId.prefix "targetObjectsOf"
    /// <summary>
    ///   <para>rdfs:label : target subjects of</para>
    ///   <para>rdfs:comment : Links a shape to a property, indicating that all subjects of triples that have the given property as their predicate must conform to the shape.</para>
    ///   <a href="http://www.w3.org/ns/shacl#targetSubjectsOf">sh:targetSubjectsOf</a>
    /// </summary>
    let targetSubjectsOf = _prefixId.prefix "targetSubjectsOf"
    let this = _prefixId.prefix "this"
    /// <summary>
    ///   <para>rdfs:label : union</para>
    ///   <para>rdfs:comment : A list of node expressions that shall be used together.</para>
    ///   <a href="http://www.w3.org/ns/shacl#union">sh:union</a>
    /// </summary>
    let union = _prefixId.prefix "union"
    /// <summary>
    ///   <para>rdfs:label : unique languages</para>
    ///   <para>rdfs:comment : Specifies whether all node values must have a unique (or no) language tag.</para>
    ///   <a href="http://www.w3.org/ns/shacl#uniqueLang">sh:uniqueLang</a>
    /// </summary>
    let uniqueLang = _prefixId.prefix "uniqueLang"
    /// <summary>
    ///   <para>rdfs:label : update</para>
    ///   <para>rdfs:comment : The SPARQL UPDATE to execute.</para>
    ///   <a href="http://www.w3.org/ns/shacl#update">sh:update</a>
    /// </summary>
    let update = _prefixId.prefix "update"
    /// <summary>
    ///   <para>rdfs:label : validator</para>
    ///   <para>rdfs:comment : The validator(s) used to evaluate constraints of either node or property shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#validator">sh:validator</a>
    /// </summary>
    let validator = _prefixId.prefix "validator"
    /// <summary>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:comment : An RDF node that has caused the result.</para>
    ///   <a href="http://www.w3.org/ns/shacl#value">sh:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : exactly one</para>
    ///   <para>rdfs:comment : Specifies a list of shapes so that the value nodes must conform to exactly one of the shapes.</para>
    ///   <a href="http://www.w3.org/ns/shacl#xone">sh:xone</a>
    /// </summary>
    let xone = _prefixId.prefix "xone"
    /// <summary>
    ///   <para>rdfs:label : zero or more path</para>
    ///   <para>rdfs:comment : The (single) value of this property represents a path that is matched zero or more times.</para>
    ///   <a href="http://www.w3.org/ns/shacl#zeroOrMorePath">sh:zeroOrMorePath</a>
    /// </summary>
    let zeroOrMorePath = _prefixId.prefix "zeroOrMorePath"
    /// <summary>
    ///   <para>rdfs:label : zero or one path</para>
    ///   <para>rdfs:comment : The (single) value of this property represents a path that is matched zero or one times.</para>
    ///   <a href="http://www.w3.org/ns/shacl#zeroOrOnePath">sh:zeroOrOnePath</a>
    /// </summary>
    let zeroOrOnePath = _prefixId.prefix "zeroOrOnePath"
