#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dash =
    let _prefixId = PrefixId.fromNamespaceLabel "http://datashapes.org/dash#" "dash"
    /// <summary>
    ///   <para>rdfs:comment : The class of possible values for dash:apiStatus.^^xsd:string</para>
    ///   <para>rdfs:label : API Status^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#APIStatus">dash:APIStatus</a>
    /// </summary>
    let APIStatus = _prefixId.prefix "APIStatus"
    let Action = _prefixId.prefix "Action"
    let ActionGroup = _prefixId.prefix "ActionGroup"
    let ActionTestCase = _prefixId.prefix "ActionTestCase"
    let AllObjects = _prefixId.prefix "AllObjects"
    let AllObjectsTarget = _prefixId.prefix "AllObjectsTarget"
    let AllSubjects = _prefixId.prefix "AllSubjects"
    let AllSubjectsTarget = _prefixId.prefix "AllSubjectsTarget"
    let AutoCompleteEditor = _prefixId.prefix "AutoCompleteEditor"
    let BlankNodeViewer = _prefixId.prefix "BlankNodeViewer"
    let BooleanSelectEditor = _prefixId.prefix "BooleanSelectEditor"
    let ChangeScript = _prefixId.prefix "ChangeScript"

    let ClosedByTypesConstraintComponent = _prefixId.prefix "ClosedByTypesConstraintComponent"

    let ClosedByTypesConstraintComponent_closedByTypes = _prefixId.prefix "ClosedByTypesConstraintComponent-closedByTypes"

    let CoExistsWithConstraintComponent = _prefixId.prefix "CoExistsWithConstraintComponent"

    let CoExistsWithConstraintComponent_coExistsWith = _prefixId.prefix "CoExistsWithConstraintComponent-coExistsWith"

    let CommitScript = _prefixId.prefix "CommitScript"
    let ConstraintReificationShape = _prefixId.prefix "ConstraintReificationShape"

    let ConstraintReificationShape_message = _prefixId.prefix "ConstraintReificationShape-message"

    let ConstraintReificationShape_severity = _prefixId.prefix "ConstraintReificationShape-severity"

    let Constructor = _prefixId.prefix "Constructor"
    let DateOrDateTime = _prefixId.prefix "DateOrDateTime"
    let DatePickerEditor = _prefixId.prefix "DatePickerEditor"
    let DateTimePickerEditor = _prefixId.prefix "DateTimePickerEditor"
    let DepictionRole = _prefixId.prefix "DepictionRole"
    let Deprecated = _prefixId.prefix "Deprecated"
    let DescriptionRole = _prefixId.prefix "DescriptionRole"
    let DetailsEditor = _prefixId.prefix "DetailsEditor"
    let DetailsViewer = _prefixId.prefix "DetailsViewer"
    let Editor = _prefixId.prefix "Editor"
    let EnumSelectEditor = _prefixId.prefix "EnumSelectEditor"
    let Experimental = _prefixId.prefix "Experimental"
    let ExploreAction = _prefixId.prefix "ExploreAction"
    /// <summary>
    ///   <para>rdfs:comment : A result representing a validation failure such as an unsupported recursion.^^xsd:string</para>
    ///   <para>rdfs:label : Failure result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#FailureResult">dash:FailureResult</a>
    /// </summary>
    let FailureResult = _prefixId.prefix "FailureResult"
    /// <summary>
    ///   <para>rdfs:comment : Represents a failure of a test case.^^xsd:string</para>
    ///   <para>rdfs:label : Failure test case result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#FailureTestCaseResult">dash:FailureTestCaseResult</a>
    /// </summary>
    let FailureTestCaseResult = _prefixId.prefix "FailureTestCaseResult"
    let FunctionTestCase = _prefixId.prefix "FunctionTestCase"
    let GraphService = _prefixId.prefix "GraphService"
    let GraphStoreTestCase = _prefixId.prefix "GraphStoreTestCase"
    /// <summary>
    ///   <para>rdfs:comment : A suggestion consisting of added and/or deleted triples, represented as rdf:Statements via dash:addedTriple and dash:deletedTriple.^^xsd:string</para>
    ///   <para>rdfs:label : Graph update^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#GraphUpdate">dash:GraphUpdate</a>
    /// </summary>
    let GraphUpdate = _prefixId.prefix "GraphUpdate"
    let GraphValidationTestCase = _prefixId.prefix "GraphValidationTestCase"
    let HTMLOrStringOrLangString = _prefixId.prefix "HTMLOrStringOrLangString"
    let HTMLViewer = _prefixId.prefix "HTMLViewer"
    let HasValueInConstraintComponent = _prefixId.prefix "HasValueInConstraintComponent"

    let HasValueInConstraintComponent_hasValueIn = _prefixId.prefix "HasValueInConstraintComponent-hasValueIn"

    let HasValueTarget = _prefixId.prefix "HasValueTarget"

    let HasValueWithClassConstraintComponent = _prefixId.prefix "HasValueWithClassConstraintComponent"

    let HasValueWithClassConstraintComponent_hasValueWithClass = _prefixId.prefix "HasValueWithClassConstraintComponent-hasValueWithClass"

    let HyperlinkViewer = _prefixId.prefix "HyperlinkViewer"
    let IDRole = _prefixId.prefix "IDRole"
    let IconRole = _prefixId.prefix "IconRole"
    let ImageViewer = _prefixId.prefix "ImageViewer"
    let IncludedScript = _prefixId.prefix "IncludedScript"
    let IndexedConstraintComponent = _prefixId.prefix "IndexedConstraintComponent"

    let IndexedConstraintComponent_indexed = _prefixId.prefix "IndexedConstraintComponent-indexed"

    let InferencingTestCase = _prefixId.prefix "InferencingTestCase"
    let InlineViewer = _prefixId.prefix "InlineViewer"
    let InstancesSelectEditor = _prefixId.prefix "InstancesSelectEditor"
    let JSONTableViewer = _prefixId.prefix "JSONTableViewer"
    let KeyInfoRole = _prefixId.prefix "KeyInfoRole"
    let LabelRole = _prefixId.prefix "LabelRole"
    let LabelViewer = _prefixId.prefix "LabelViewer"
    let LangStringViewer = _prefixId.prefix "LangStringViewer"
    let ListNodeShape = _prefixId.prefix "ListNodeShape"
    let ListShape = _prefixId.prefix "ListShape"
    let LiteralViewer = _prefixId.prefix "LiteralViewer"
    let ModifyAction = _prefixId.prefix "ModifyAction"
    let MultiEditor = _prefixId.prefix "MultiEditor"
    /// <summary>
    ///   <para>rdfs:comment : A multi-function is a function that can return zero or more result objects consisting of one or more result variables. While normal (SPARQL/SHACL) functions can only return a single result node, multi-functions may not only return multiple nodes but even multiple individual variables per solution.
    ///
    /// A common way of defining multi-functions is by wrapping a SPARQL SELECT query, using dash:SPARQLMultiFunction. However, some MultiFunctions (in TopBraid) may also be implemented natively.^^xsd:string</para>
    ///   <para>rdfs:label : Multi-function^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#MultiFunction">dash:MultiFunction</a>
    /// </summary>
    let MultiFunction = _prefixId.prefix "MultiFunction"
    let MultiViewer = _prefixId.prefix "MultiViewer"
    let NoSuitableEditor = _prefixId.prefix "NoSuitableEditor"
    let NodeExpressionViewer = _prefixId.prefix "NodeExpressionViewer"

    let NonRecursiveConstraintComponent = _prefixId.prefix "NonRecursiveConstraintComponent"

    let NonRecursiveConstraintComponent_nonRecursive = _prefixId.prefix "NonRecursiveConstraintComponent-nonRecursive"

    let None = _prefixId.prefix "None"
    let ParameterConstraintComponent = _prefixId.prefix "ParameterConstraintComponent"

    let ParameterConstraintComponent_parameter = _prefixId.prefix "ParameterConstraintComponent-parameter"

    let PrimaryKeyConstraintComponent = _prefixId.prefix "PrimaryKeyConstraintComponent"

    let PrimaryKeyConstraintComponent_uriStart = _prefixId.prefix "PrimaryKeyConstraintComponent-uriStart"

    let PropertyAutoCompleteEditor = _prefixId.prefix "PropertyAutoCompleteEditor"
    let PropertyLabelViewer = _prefixId.prefix "PropertyLabelViewer"
    /// <summary>
    ///   <para>rdfs:comment : The class of roles that a property (shape) may take for its focus nodes.^^xsd:string</para>
    ///   <para>rdfs:label : Property role^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#PropertyRole">dash:PropertyRole</a>
    /// </summary>
    let PropertyRole = _prefixId.prefix "PropertyRole"
    let QueryTestCase = _prefixId.prefix "QueryTestCase"

    let ReifiableByConstraintComponent = _prefixId.prefix "ReifiableByConstraintComponent"

    let ReifiableByConstraintComponent_reifiableBy = _prefixId.prefix "ReifiableByConstraintComponent-reifiableBy"

    let ResourceAction = _prefixId.prefix "ResourceAction"
    let ResourceService = _prefixId.prefix "ResourceService"
    let RichTextEditor = _prefixId.prefix "RichTextEditor"
    let RootClassConstraintComponent = _prefixId.prefix "RootClassConstraintComponent"

    let RootClassConstraintComponent_rootClass = _prefixId.prefix "RootClassConstraintComponent-rootClass"

    /// <summary>
    ///   <para>rdfs:comment : Encapsulates one or more SPARQL CONSTRUCT queries that can be parameterized. Parameters will become pre-bound variables in the queries.^^xsd:string</para>
    ///   <para>rdfs:label : SPARQL CONSTRUCT template^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SPARQLConstructTemplate">dash:SPARQLConstructTemplate</a>
    /// </summary>
    let SPARQLConstructTemplate = _prefixId.prefix "SPARQLConstructTemplate"
    /// <summary>
    ///   <para>rdfs:comment : A multi-function based on a SPARQL SELECT query. The query gets executed with the arguments pre-bound to the variables declared as parameters. The results of the multi-function are all result bindings from the SPARQL result set.^^xsd:string</para>
    ///   <para>rdfs:label : SPARQL multi-function^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SPARQLMultiFunction">dash:SPARQLMultiFunction</a>
    /// </summary>
    let SPARQLMultiFunction = _prefixId.prefix "SPARQLMultiFunction"
    /// <summary>
    ///   <para>rdfs:comment : Encapsulates a SPARQL SELECT query that can be parameterized. Parameters will become pre-bound variables in the query.^^xsd:string</para>
    ///   <para>rdfs:label : SPARQL SELECT template^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SPARQLSelectTemplate">dash:SPARQLSelectTemplate</a>
    /// </summary>
    let SPARQLSelectTemplate = _prefixId.prefix "SPARQLSelectTemplate"

    /// <summary>
    ///   <para>rdfs:comment : A SuggestionGenerator based on a SPARQL UPDATE query (sh:update), producing an instance of dash:GraphUpdate. The INSERTs become dash:addedTriple and the DELETEs become dash:deletedTriple. The WHERE clause operates on the data graph with the pre-bound variables $focusNode, $predicate and $value, as well as the other pre-bound variables for the parameters of the constraint.
    ///
    /// In many cases, there may be multiple possible suggestions to fix a problem. For example, with sh:maxLength there are many ways to slice a string. In those cases, the system will first iterate through the result variables from a SELECT query (sh:select) and apply these results as pre-bound variables into the UPDATE query.^^xsd:string</para>
    ///   <para>rdfs:label : SPARQL UPDATE suggestion generator^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SPARQLUpdateSuggestionGenerator">dash:SPARQLUpdateSuggestionGenerator</a>
    /// </summary>
    let SPARQLUpdateSuggestionGenerator = _prefixId.prefix "SPARQLUpdateSuggestionGenerator"

    let Script = _prefixId.prefix "Script"
    let ScriptAPIGenerationRules = _prefixId.prefix "ScriptAPIGenerationRules"
    let ScriptAPIShape = _prefixId.prefix "ScriptAPIShape"
    let ScriptAPIShape_generateClass = _prefixId.prefix "ScriptAPIShape-generateClass"

    let ScriptAPIShape_generatePrefixClasses = _prefixId.prefix "ScriptAPIShape-generatePrefixClasses"

    let ScriptAPIShape_generatePrefixConstants = _prefixId.prefix "ScriptAPIShape-generatePrefixConstants"

    let ScriptConstraint = _prefixId.prefix "ScriptConstraint"
    let ScriptConstraintComponent = _prefixId.prefix "ScriptConstraintComponent"

    let ScriptConstraintComponent_scriptConstraint = _prefixId.prefix "ScriptConstraintComponent-scriptConstraint"

    /// <summary>
    ///   <para>rdfs:comment : Script functions can be used from SPARQL queries and will be injected into the generated prefix object (in JavaScript, for ADS scripts). The dash:js will be inserted into a generated JavaScript function and therefore needs to use the return keyword to produce results. These JS snippets can access the parameter values based on the local name of the sh:Parameter's path. For example ex:value can be accessed using value.
    ///
    /// SPARQL use note: Since these functions may be used from any data graph and any shapes graph, they must not rely on any API apart from what's available in the shapes graph that holds the rdf:type triple of the function itself. In other words, at execution time from SPARQL, the ADS shapes graph will be the home graph of the function's declaration.^^xsd:string</para>
    ///   <para>rdfs:label : Script function^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#ScriptFunction">dash:ScriptFunction</a>
    /// </summary>
    let ScriptFunction = _prefixId.prefix "ScriptFunction"
    let ScriptSuggestionGenerator = _prefixId.prefix "ScriptSuggestionGenerator"
    let ScriptTestCase = _prefixId.prefix "ScriptTestCase"
    let ScriptValidator = _prefixId.prefix "ScriptValidator"
    let Service = _prefixId.prefix "Service"
    let ShapeClass = _prefixId.prefix "ShapeClass"
    /// <summary>
    ///   <para>rdfs:comment : A shape script contains extra code that gets injected into the API for the associated node shape. In particular you can use this to define additional functions that operate on the current focus node (the this variable in JavaScript).^^xsd:string</para>
    ///   <para>rdfs:label : Shape script^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#ShapeScript">dash:ShapeScript</a>
    /// </summary>
    let ShapeScript = _prefixId.prefix "ShapeScript"
    let SingleEditor = _prefixId.prefix "SingleEditor"
    let SingleLineConstraintComponent = _prefixId.prefix "SingleLineConstraintComponent"

    let SingleLineConstraintComponent_singleLine = _prefixId.prefix "SingleLineConstraintComponent-singleLine"

    let SingleViewer = _prefixId.prefix "SingleViewer"
    let Stable = _prefixId.prefix "Stable"
    let StemConstraintComponent = _prefixId.prefix "StemConstraintComponent"
    let StemConstraintComponent_stem = _prefixId.prefix "StemConstraintComponent-stem"
    let StringOrLangString = _prefixId.prefix "StringOrLangString"
    let StringOrLangStringOrHTML = _prefixId.prefix "StringOrLangStringOrHTML"
    let SubClassEditor = _prefixId.prefix "SubClassEditor"
    let SubSetOfConstraintComponent = _prefixId.prefix "SubSetOfConstraintComponent"

    let SubSetOfConstraintComponent_subSetOf = _prefixId.prefix "SubSetOfConstraintComponent-subSetOf"

    /// <summary>
    ///   <para>rdfs:comment : A result representing a successfully validated constraint.^^xsd:string</para>
    ///   <para>rdfs:label : Success result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SuccessResult">dash:SuccessResult</a>
    /// </summary>
    let SuccessResult = _prefixId.prefix "SuccessResult"
    /// <summary>
    ///   <para>rdfs:comment : Represents a successful run of a test case.^^xsd:string</para>
    ///   <para>rdfs:label : Success test case result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SuccessTestCaseResult">dash:SuccessTestCaseResult</a>
    /// </summary>
    let SuccessTestCaseResult = _prefixId.prefix "SuccessTestCaseResult"
    /// <summary>
    ///   <para>dash:abstract : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Base class of suggestions that modify a graph to "fix" the source of a validation result.^^xsd:string</para>
    ///   <para>rdfs:label : Suggestion^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#Suggestion">dash:Suggestion</a>
    /// </summary>
    let Suggestion = _prefixId.prefix "Suggestion"
    /// <summary>
    ///   <para>dash:abstract : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Base class of objects that can generate suggestions (added or deleted triples) for a validation result of a given constraint component.^^xsd:string</para>
    ///   <para>rdfs:label : Suggestion generator^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SuggestionGenerator">dash:SuggestionGenerator</a>
    /// </summary>
    let SuggestionGenerator = _prefixId.prefix "SuggestionGenerator"
    /// <summary>
    ///   <para>rdfs:comment : Class of results that have been produced as suggestions, not through SHACL validation. How the actual results are produced is up to implementers. Each instance of this class should have values for sh:focusNode, sh:resultMessage, sh:resultSeverity (suggested default: sh:Info), and dash:suggestion to point at one or more suggestions.^^xsd:string</para>
    ///   <para>rdfs:label : Suggestion result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#SuggestionResult">dash:SuggestionResult</a>
    /// </summary>
    let SuggestionResult = _prefixId.prefix "SuggestionResult"
    let SymmetricConstraintComponent = _prefixId.prefix "SymmetricConstraintComponent"

    let SymmetricConstraintComponent_symmetric = _prefixId.prefix "SymmetricConstraintComponent-symmetric"

    let TestCase = _prefixId.prefix "TestCase"
    /// <summary>
    ///   <para>dash:abstract : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Base class for results produced by running test cases.^^xsd:string</para>
    ///   <para>rdfs:label : Test case result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#TestCaseResult">dash:TestCaseResult</a>
    /// </summary>
    let TestCaseResult = _prefixId.prefix "TestCaseResult"
    /// <summary>
    ///   <para>dash:abstract : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Abstract base class for test environments, holding information on how to set up a test case.^^xsd:string</para>
    ///   <para>rdfs:label : Test environment^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#TestEnvironment">dash:TestEnvironment</a>
    /// </summary>
    let TestEnvironment = _prefixId.prefix "TestEnvironment"
    let TextAreaEditor = _prefixId.prefix "TextAreaEditor"
    let TextAreaWithLangEditor = _prefixId.prefix "TextAreaWithLangEditor"
    let TextFieldEditor = _prefixId.prefix "TextFieldEditor"
    let TextFieldWithLangEditor = _prefixId.prefix "TextFieldWithLangEditor"
    let URIEditor = _prefixId.prefix "URIEditor"
    let URIViewer = _prefixId.prefix "URIViewer"

    let UniqueValueForClassConstraintComponent = _prefixId.prefix "UniqueValueForClassConstraintComponent"

    let UniqueValueForClassConstraintComponent_uniqueValueForClass = _prefixId.prefix "UniqueValueForClassConstraintComponent-uniqueValueForClass"

    let UntrustedHTMLViewer = _prefixId.prefix "UntrustedHTMLViewer"
    let ValidationTestCase = _prefixId.prefix "ValidationTestCase"
    let ValueTableViewer = _prefixId.prefix "ValueTableViewer"
    let Viewer = _prefixId.prefix "Viewer"
    let Widget = _prefixId.prefix "Widget"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a class is "abstract" and cannot be used in asserted rdf:type triples. Only non-abstract subclasses of abstract classes should be instantiated directly.^^xsd:string</para>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#abstract">dash:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:comment : Links an Action with the ActionGroup that it should be arranged in.^^xsd:string</para>
    ///   <para>rdfs:label : action group^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#actionGroup">dash:actionGroup</a>
    /// </summary>
    let actionGroup = _prefixId.prefix "actionGroup"
    /// <summary>
    ///   <para>rdfs:comment : The (CSS) class of an Action for display purposes alongside the label.^^xsd:string</para>
    ///   <para>rdfs:label : action icon class^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#actionIconClass">dash:actionIconClass</a>
    /// </summary>
    let actionIconClass = _prefixId.prefix "actionIconClass"
    /// <summary>
    ///   <para>rdfs:comment : May link a dash:GraphUpdate with one or more triples (represented as instances of rdf:Statement) that should be added to fix the source of the result.^^xsd:string</para>
    ///   <para>rdfs:label : added triple^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#addedTriple">dash:addedTriple</a>
    /// </summary>
    let addedTriple = _prefixId.prefix "addedTriple"
    let all = _prefixId.prefix "all"
    /// <summary>
    ///   <para>rdfs:comment : Defines how and whether the associated feature is part of an external API. APIs may be implemented as (REST) web services, via GraphQL or ADS Script APIs.^^xsd:string</para>
    ///   <para>rdfs:label : API status^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#apiStatus">dash:apiStatus</a>
    /// </summary>
    let apiStatus = _prefixId.prefix "apiStatus"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to state that a shape is applicable to instances of a given class. This is a softer statement than "target class": a target means that all instances of the class must conform to the shape. Being applicable to simply means that the shape may apply to (some) instances of the class. This information can be used by algorithms or humans.^^xsd:string</para>
    ///   <para>rdfs:label : applicable to class^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#applicableToClass">dash:applicableToClass</a>
    /// </summary>
    let applicableToClass = _prefixId.prefix "applicableToClass"
    let arg = _prefixId.prefix "arg"
    /// <summary>
    ///   <para>rdfs:comment : If set to true then the results of the SHACL function can be cached in between invocations with the same arguments. In other words, they are stateless and do not depend on triples in any graph, or the current time stamp etc.^^xsd:string</para>
    ///   <para>rdfs:label : cachable^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#cachable">dash:cachable</a>
    /// </summary>
    let cachable = _prefixId.prefix "cachable"
    /// <summary>
    ///   <para>rdfs:label : closed by types^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#closedByTypes">dash:closedByTypes</a>
    /// </summary>
    let closedByTypes = _prefixId.prefix "closedByTypes"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a property that must have a value whenever the property path has a value, and must have no value whenever the property path has no value.^^xsd:string</para>
    ///   <para>rdfs:label : co-exists with^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#coExistsWith">dash:coExistsWith</a>
    /// </summary>
    let coExistsWith = _prefixId.prefix "coExistsWith"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to indicate that a property/path represented by a property constraint represents a composite relationship. In a composite relationship, the life cycle of a "child" object (value of the property/path) depends on the "parent" object (focus node). If the parent gets deleted, then the child objects should be deleted, too. Tools may use dash:composite (if set to true) to implement cascading delete operations.^^xsd:string</para>
    ///   <para>rdfs:label : composite^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#composite">dash:composite</a>
    /// </summary>
    let composite = _prefixId.prefix "composite"
    let constraintOrShape = _prefixId.prefix "constraintOrShape"
    /// <summary>
    ///   <para>rdfs:comment : Used to mark certain parameterizables as context-free, meaning that the outcome of a process does not depend on the currently active query graph.^^xsd:string</para>
    ///   <para>rdfs:label : context-free^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#contextFree">dash:contextFree</a>
    /// </summary>
    let contextFree = _prefixId.prefix "contextFree"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to annotate a graph (usually the owl:Ontology) with the default language that tools should suggest for new literal values. For example, predominantly English graphs should have "en" as default language.^^xsd:string</para>
    ///   <para>rdfs:label : default language^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#defaultLang">dash:defaultLang</a>
    /// </summary>
    let defaultLang = _prefixId.prefix "defaultLang"
    /// <summary>
    ///   <para>rdfs:comment : Links a node shape with the roles for which it shall be used as default view. User interfaces can use these values to select how to present a given RDF resource. The values of this property are URIs representing a group of users or agents. There is a dedicated URI dash:all representing all users.^^xsd:string</para>
    ///   <para>rdfs:label : default view for role^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#defaultViewForRole">dash:defaultViewForRole</a>
    /// </summary>
    let defaultViewForRole = _prefixId.prefix "defaultViewForRole"
    /// <summary>
    ///   <para>rdfs:comment : May link a dash:GraphUpdate result with one or more triples (represented as instances of rdf:Statement) that should be deleted to fix the source of the result.^^xsd:string</para>
    ///   <para>rdfs:label : deleted triple^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#deletedTriple">dash:deletedTriple</a>
    /// </summary>
    let deletedTriple = _prefixId.prefix "deletedTriple"
    /// <summary>
    ///   <para>rdfs:comment : Can be used in dash:js node expressions to enumerate the predicates that the computation of the values may depend on. This can be used by clients to determine whether an edit requires re-computation of values on a form or elsewhere. For example, if the dash:js is something like "focusNode.firstName + focusNode.lastName" then the dependency predicates should be ex:firstName and ex:lastName.^^xsd:string</para>
    ///   <para>rdfs:label : dependency predicate^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#dependencyPredicate">dash:dependencyPredicate</a>
    /// </summary>
    let dependencyPredicate = _prefixId.prefix "dependencyPredicate"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a SHACL property shape with the URL of a SPARQL endpoint that may contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to values from an external graph when the user wants to retrieve more information about a value.
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information. One implementation strategy would be to periodically fetch the values specified by the sh:node or sh:class shape associated with the property, using the property shapes in that shape, and add the resulting triples into the main query graph.
    ///
    /// An example value is "https://query.wikidata.org/sparql".^^xsd:string</para>
    ///   <para>rdfs:label : details endpoint^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#detailsEndpoint">dash:detailsEndpoint</a>
    /// </summary>
    let detailsEndpoint = _prefixId.prefix "detailsEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a SHACL property shape with a SHACL node expression that produces the URIs of one or more graphs that contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to another data graph when the user wants to retrieve more information about a value.
    ///
    /// The node expressions are evaluated with the focus node as input. (It is unclear whether there are also cases where the result may be different for each specific value, in which case the node expression would need a second input argument).
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information.^^xsd:string</para>
    ///   <para>rdfs:label : details graph^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#detailsGraph">dash:detailsGraph</a>
    /// </summary>
    let detailsGraph = _prefixId.prefix "detailsGraph"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a property shape with an editor, to state a preferred editing widget in user interfaces.^^xsd:string</para>
    ///   <para>rdfs:label : editor^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#editor">dash:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:comment : The expected result(s) of a test case. The value range of this property is different for each kind of test cases.^^xsd:string</para>
    ///   <para>rdfs:label : expected result^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#expectedResult">dash:expectedResult</a>
    /// </summary>
    let expectedResult = _prefixId.prefix "expectedResult"
    /// <summary>
    ///   <para>rdfs:comment : A flag to indicate that the expected result represents a JSON string. If set to true, then tests would compare JSON structures (regardless of whitespaces) instead of actual syntax.^^xsd:string</para>
    ///   <para>rdfs:label : expected result is JSON^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#expectedResultIsJSON">dash:expectedResultIsJSON</a>
    /// </summary>
    let expectedResultIsJSON = _prefixId.prefix "expectedResultIsJSON"
    /// <summary>
    ///   <para>rdfs:comment : A flag to indicate that the expected result represents an RDF graph encoded as a Turtle file. If set to true, then tests would compare graphs instead of actual syntax.^^xsd:string</para>
    ///   <para>rdfs:label : expected result is Turtle^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#expectedResultIsTTL">dash:expectedResultIsTTL</a>
    /// </summary>
    let expectedResultIsTTL = _prefixId.prefix "expectedResultIsTTL"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to mark that certain validation results have already been fixed.^^xsd:string</para>
    ///   <para>rdfs:label : fixed^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#fixed">dash:fixed</a>
    /// </summary>
    let fixed_ = _prefixId.prefix "fixed"
    let generateClass = _prefixId.prefix "generateClass"
    let generatePrefixClasses = _prefixId.prefix "generatePrefixClasses"
    let generatePrefixConstants = _prefixId.prefix "generatePrefixConstants"
    let hasClass = _prefixId.prefix "hasClass"
    let hasMaxExclusive = _prefixId.prefix "hasMaxExclusive"
    let hasMaxInclusive = _prefixId.prefix "hasMaxInclusive"
    let hasMaxLength = _prefixId.prefix "hasMaxLength"
    let hasMinExclusive = _prefixId.prefix "hasMinExclusive"
    let hasMinInclusive = _prefixId.prefix "hasMinInclusive"
    let hasMinLength = _prefixId.prefix "hasMinLength"
    let hasNodeKind = _prefixId.prefix "hasNodeKind"
    let hasPattern = _prefixId.prefix "hasPattern"
    let hasRootClass = _prefixId.prefix "hasRootClass"
    let hasStem = _prefixId.prefix "hasStem"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a constraint that at least one of the value nodes must be a member of the given list.^^xsd:string</para>
    ///   <para>rdfs:label : has value in^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#hasValueIn">dash:hasValueIn</a>
    /// </summary>
    let hasValueIn = _prefixId.prefix "hasValueIn"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a constraint that at least one of the value nodes must be an instance of a given class.^^xsd:string</para>
    ///   <para>rdfs:label : has value with class^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#hasValueWithClass">dash:hasValueWithClass</a>
    /// </summary>
    let hasValueWithClass = _prefixId.prefix "hasValueWithClass"
    /// <summary>
    ///   <para>rdfs:comment : The height.^^xsd:string</para>
    ///   <para>rdfs:label : height^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#height">dash:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:comment : Properties marked as hidden do not appear in user interfaces, yet remain part of the shape for other purposes such as validation and scripting or GraphQL schema generation.^^xsd:string</para>
    ///   <para>rdfs:label : hidden^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#hidden">dash:hidden</a>
    /// </summary>
    let hidden = _prefixId.prefix "hidden"
    /// <summary>
    ///   <para>rdfs:label : index^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#index">dash:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    let indexed = _prefixId.prefix "indexed"
    let isDeactivated = _prefixId.prefix "isDeactivated"
    let isIn = _prefixId.prefix "isIn"
    let isLanguageIn = _prefixId.prefix "isLanguageIn"
    let isNodeKindBlankNode = _prefixId.prefix "isNodeKindBlankNode"
    let isNodeKindIRI = _prefixId.prefix "isNodeKindIRI"
    let isNodeKindLiteral = _prefixId.prefix "isNodeKindLiteral"
    let isSubClassOf = _prefixId.prefix "isSubClassOf"
    let isSubClassOf_subclass = _prefixId.prefix "isSubClassOf-subclass"
    let isSubClassOf_superclass = _prefixId.prefix "isSubClassOf-superclass"
    /// <summary>
    ///   <para>rdfs:comment : The JavaScript source code of a Script.^^xsd:string</para>
    ///   <para>rdfs:label : JavaScript source code^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#js">dash:js</a>
    /// </summary>
    let js = _prefixId.prefix "js"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true for those constraint components where the validation does not require to visit any other triples than the shape definitions and the direct property values of the focus node mentioned in the property constraints. Examples of this include sh:minCount and sh:hasValue.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server, assuming the client has downloaded a complete snapshot of the resource.
    ///
    /// Any component marked with dash:staticConstraint is also a dash:localConstraint.^^xsd:string</para>
    ///   <para>rdfs:label : local constraint^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#localConstraint">dash:localConstraint</a>
    /// </summary>
    let localConstraint = _prefixId.prefix "localConstraint"
    /// <summary>
    ///   <para>rdfs:comment : For file-typed properties, this can be used to specify the expected/allowed mime types of its values. This can be used, for example, to limit file input boxes or file selectors. If multiple values are allowed then they need to be separated by commas.
    ///
    /// Example values are listed at https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types^^xsd:string</para>
    ///   <para>rdfs:label : mime types^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#mimeTypes">dash:mimeTypes</a>
    /// </summary>
    let mimeTypes = _prefixId.prefix "mimeTypes"
    /// <summary>
    ///   <para>rdfs:comment : If set to true at a property shape then any sh:values and sh:defaultValue rules of this property will be ignored when 'all inferences' are computed. This is useful for property values that shall only be computed for individual focus nodes (e.g. when a user visits a resource) but not for large inference runs.^^xsd:string</para>
    ///   <para>rdfs:label : never materialize^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#neverMaterialize">dash:neverMaterialize</a>
    /// </summary>
    let neverMaterialize = _prefixId.prefix "neverMaterialize"
    let nodeKind = _prefixId.prefix "nodeKind"
    let nonRecursive = _prefixId.prefix "nonRecursive"
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : If set to true for a ScriptConstraint or ScriptValidator, then the associated script will receive all value nodes at once, as a value of the variable values. By default (or false), the script is called for each value node individually.^^xsd:string</para>
    ///   <para>rdfs:label : on all values^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#onAllValues">dash:onAllValues</a>
    /// </summary>
    let onAllValues = _prefixId.prefix "onAllValues"
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : Links the constraint component with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by a property constraint.^^xsd:string</para>
    ///   <para>rdfs:label : property suggestion generator^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#propertySuggestionGenerator">dash:propertySuggestionGenerator</a>
    /// </summary>
    let propertySuggestionGenerator = _prefixId.prefix "propertySuggestionGenerator"
    /// <summary>
    ///   <para>rdfs:comment : Used as a hint for user interfaces that values of the associated property should not be editable. The values of this may be the boolean literals true or false or, more generally, a SHACL node expression that must evaluate to true or false.^^xsd:string</para>
    ///   <para>rdfs:label : read only^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#readOnly">dash:readOnly</a>
    /// </summary>
    let readOnly = _prefixId.prefix "readOnly"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to specify the node shape that may be applied to reified statements produced by a property shape. The property shape must have a URI resource as its sh:path. The values of this property must be node shapes. User interfaces can use this information to determine which properties to present to users when reified statements are explored or edited. Use dash:None to indicate that no reification should be permitted.^^xsd:string</para>
    ///   <para>rdfs:label : reifiable by^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#reifiableBy">dash:reifiableBy</a>
    /// </summary>
    let reifiableBy = _prefixId.prefix "reifiableBy"
    /// <summary>
    ///   <para>rdfs:comment : Links a class with the Resource Actions that can be applied to instances of that class.^^xsd:string</para>
    ///   <para>rdfs:label : resource action^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#resourceAction">dash:resourceAction</a>
    /// </summary>
    let resourceAction = _prefixId.prefix "resourceAction"
    /// <summary>
    ///   <para>rdfs:label : root class^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#rootClass">dash:rootClass</a>
    /// </summary>
    let rootClass = _prefixId.prefix "rootClass"
    let scriptConstraint = _prefixId.prefix "scriptConstraint"
    /// <summary>
    ///   <para>rdfs:comment : States that a subject resource has a given shape. This property can, for example, be used to capture results of SHACL validation on static data.^^xsd:string</para>
    ///   <para>rdfs:label : shape^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#shape">dash:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>rdfs:label : shape script^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#shapeScript">dash:shapeScript</a>
    /// </summary>
    let shapeScript = _prefixId.prefix "shapeScript"
    /// <summary>
    ///   <para>rdfs:label : single line^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#singleLine">dash:singleLine</a>
    /// </summary>
    let singleLine = _prefixId.prefix "singleLine"
    /// <summary>
    ///   <para>rdfs:comment : Can be set to true for those constraint components where the validation does not require to visit any other triples than the parameters. Examples of this include sh:datatype or sh:nodeKind, where no further triples need to be queried to determine the result.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server.^^xsd:string</para>
    ///   <para>rdfs:label : static constraint^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#staticConstraint">dash:staticConstraint</a>
    /// </summary>
    let staticConstraint = _prefixId.prefix "staticConstraint"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a string value that the IRI of the value nodes must start with.</para>
    ///   <para>rdfs:label : stem</para>
    ///   <a href="http://datashapes.org/dash#stem">dash:stem</a>
    /// </summary>
    let stem = _prefixId.prefix "stem"
    /// <summary>
    ///   <para>rdfs:label : sub set of^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#subSetOf">dash:subSetOf</a>
    /// </summary>
    let subSetOf = _prefixId.prefix "subSetOf"
    let subclass = _prefixId.prefix "subclass"
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a result with one or more suggestions on how to address or improve the underlying issue.^^xsd:string</para>
    ///   <para>rdfs:label : suggestion^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#suggestion">dash:suggestion</a>
    /// </summary>
    let suggestion = _prefixId.prefix "suggestion"
    /// <summary>
    ///   <para>rdfs:comment : An optional confidence between 0% and 100%. Suggestions with 100% confidence are strongly recommended. Can be used to sort recommended updates.^^xsd:string</para>
    ///   <para>rdfs:label : suggestion confidence^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#suggestionConfidence">dash:suggestionConfidence</a>
    /// </summary>
    let suggestionConfidence = _prefixId.prefix "suggestionConfidence"
    /// <summary>
    ///   <para>rdfs:comment : Links a sh:SPARQLConstraint or sh:JSConstraint with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by the constraint.^^xsd:string</para>
    ///   <para>rdfs:label : suggestion generator^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#suggestionGenerator">dash:suggestionGenerator</a>
    /// </summary>
    let suggestionGenerator = _prefixId.prefix "suggestionGenerator"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a suggestion with the group identifier to which it belongs. By default this is a link to the dash:SuggestionGenerator, but in principle this could be any value.^^xsd:string</para>
    ///   <para>rdfs:label : suggestion^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#suggestionGroup">dash:suggestionGroup</a>
    /// </summary>
    let suggestionGroup = _prefixId.prefix "suggestionGroup"
    let superclass = _prefixId.prefix "superclass"
    /// <summary>
    ///   <para>rdfs:comment : True to declare that the associated property path is symmetric.^^xsd:string</para>
    ///   <para>rdfs:label : symmetric^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#symmetric">dash:symmetric</a>
    /// </summary>
    let symmetric = _prefixId.prefix "symmetric"
    let template = _prefixId.prefix "template"
    let toString = _prefixId.prefix "toString"
    /// <summary>
    ///   <para>rdfs:label : unique value for class^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#uniqueValueForClass">dash:uniqueValueForClass</a>
    /// </summary>
    let uniqueValueForClass = _prefixId.prefix "uniqueValueForClass"
    let uriStart = _prefixId.prefix "uriStart"
    let uriTemplate = _prefixId.prefix "uriTemplate"
    /// <summary>
    ///   <para>rdfs:comment : True to also validate the shapes itself (i.e. parameter declarations).^^xsd:string</para>
    ///   <para>rdfs:label : validate shapes^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#validateShapes">dash:validateShapes</a>
    /// </summary>
    let validateShapes = _prefixId.prefix "validateShapes"
    let value = _prefixId.prefix "value"
    let valueCount = _prefixId.prefix "valueCount"
    /// <summary>
    ///   <para>rdfs:comment : Can be used to link a property shape with a viewer, to state a preferred viewing widget in user interfaces.^^xsd:string</para>
    ///   <para>rdfs:label : viewer^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#viewer">dash:viewer</a>
    /// </summary>
    let viewer = _prefixId.prefix "viewer"
    /// <summary>
    ///   <para>rdfs:comment : The width.^^xsd:string</para>
    ///   <para>rdfs:label : width^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#width">dash:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:comment : The x position.^^xsd:string</para>
    ///   <para>rdfs:label : x^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#x">dash:x</a>
    /// </summary>
    let x = _prefixId.prefix "x"
    /// <summary>
    ///   <para>rdfs:comment : The y position.^^xsd:string</para>
    ///   <para>rdfs:label : y^^xsd:string</para>
    ///   <a href="http://datashapes.org/dash#y">dash:y</a>
    /// </summary>
    let y = _prefixId.prefix "y"
