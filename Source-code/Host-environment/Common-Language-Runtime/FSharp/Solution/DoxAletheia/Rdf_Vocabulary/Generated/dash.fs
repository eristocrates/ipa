namespace http.datashapes.org.dash.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dash =
    let _namespace_iri = Namespace_Iri dash |> NamespaceIRI
    /// <summary>
    ///   <para>dash:ShapeClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A class that is also a node shape. This class can be used as rdf:type instead of the combination of rdfs:Class and sh:NodeShape.</para>
    /// labels<para>Shape class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ShapeClass">http://datashapes.org/dash#ShapeClass</seealso>
    let ShapeClass = Prefixed_Name(dash, "ShapeClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:HTMLOrStringOrLangString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either rdf:HTML, xsd:string or rdf:langString (in that order of preference).</para>
    /// labels<para>HTML or string or langString</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HTMLOrStringOrLangString">http://datashapes.org/dash#HTMLOrStringOrLangString</seealso>
    let HTMLOrStringOrLangString =
        Prefixed_Name(dash, "HTMLOrStringOrLangString") |> PrefixedName

    /// <summary>
    ///   <para>dash:HasValueInConstraintComponent-hasValueIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#HasValueInConstraintComponent-hasValueIn">http://datashapes.org/dash#HasValueInConstraintComponent-hasValueIn</seealso>
    let HasValueInConstraintComponent_hasValueIn =
        Prefixed_Name(dash, "HasValueInConstraintComponent-hasValueIn") |> PrefixedName

    /// <summary>
    ///   <para>dash:ListShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Defines constraints on what it means for a node to be a well-formed RDF list.
    ///
    /// The focus node must either be rdf:nil or not recursive. Furthermore, this shape uses dash:ListNodeShape as a "helper" to walk through all members of the whole list (including itself).</para>
    /// labels<para>List shape</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ListShape">http://datashapes.org/dash#ListShape</seealso>
    let ListShape = Prefixed_Name(dash, "ListShape") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasValueIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a constraint that at least one of the value nodes must be a member of the given list.</para>
    /// labels<para>has value in</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasValueIn">http://datashapes.org/dash#hasValueIn</seealso>
    let hasValueIn = Prefixed_Name(dash, "hasValueIn") |> PrefixedName
    /// <summary>
    ///   <para>dash:AllObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:AllObjectsTarget</para>
    ///   <para>A reusable instance of dash:AllObjectsTarget.</para>
    /// labels<para>All objects</para></remarks>
    /// <seealso href="http://datashapes.org/dash#AllObjects">http://datashapes.org/dash#AllObjects</seealso>
    let AllObjects = Prefixed_Name(dash, "AllObjects") |> PrefixedName
    /// <summary>
    ///   <para>dash:LabelViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for URI resources, rendering as a hyperlink to that URI based on the display label of the resource. Also includes other ways of interacting with the URI such as opening a nested summary display.</para>
    /// labels<para>Label viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#LabelViewer">http://datashapes.org/dash#LabelViewer</seealso>
    let LabelViewer = Prefixed_Name(dash, "LabelViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMinInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node (?value) has value greater than or equal to (&gt;=) the provided ?minInclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.</para>
    /// labels<para>has min inclusive</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMinInclusive">http://datashapes.org/dash#hasMinInclusive</seealso>
    let hasMinInclusive = Prefixed_Name(dash, "hasMinInclusive") |> PrefixedName
    /// <summary>
    ///   <para>dash:BooleanSelectEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for boolean literals, rendering as a select box with values true and false.
    ///
    /// Also displays the current value (such as "1"^^xsd:boolean), but only allows to switch to true or false.</para>
    /// labels<para>Boolean select editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#BooleanSelectEditor">http://datashapes.org/dash#BooleanSelectEditor</seealso>
    let BooleanSelectEditor = Prefixed_Name(dash, "BooleanSelectEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:ClosedByTypesConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to declare that focus nodes are "closed" based on their rdf:types, meaning that focus nodes may only have values for the properties that are explicitly enumerated via sh:property/sh:path in property constraints at their rdf:types and the superclasses of those. This assumes that the type classes are also shapes.</para>
    /// labels<para>Closed by types constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ClosedByTypesConstraintComponent">http://datashapes.org/dash#ClosedByTypesConstraintComponent</seealso>
    let ClosedByTypesConstraintComponent =
        Prefixed_Name(dash, "ClosedByTypesConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:ConstraintReificationShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Can be used to attach sh:severity and sh:messages to individual constraints using reification.</para>
    /// labels<para>Constraint reification shape</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ConstraintReificationShape">http://datashapes.org/dash#ConstraintReificationShape</seealso>
    let ConstraintReificationShape =
        Prefixed_Name(dash, "ConstraintReificationShape") |> PrefixedName

    /// <summary>
    ///   <para>dash:None</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A Shape that is no node can conform to.</para>
    /// labels<para>None</para></remarks>
    /// <seealso href="http://datashapes.org/dash#None">http://datashapes.org/dash#None</seealso>
    let None = Prefixed_Name(dash, "None") |> PrefixedName

    /// <summary>
    ///   <para>dash:ParameterConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that all value nodes conform to the given Parameter.</para>
    /// labels<para>Parameter constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ParameterConstraintComponent">http://datashapes.org/dash#ParameterConstraintComponent</seealso>
    let ParameterConstraintComponent =
        Prefixed_Name(dash, "ParameterConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:ParameterConstraintComponent-parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ParameterConstraintComponent-parameter">http://datashapes.org/dash#ParameterConstraintComponent-parameter</seealso>
    let ParameterConstraintComponent_parameter =
        Prefixed_Name(dash, "ParameterConstraintComponent-parameter") |> PrefixedName

    /// <summary>
    ///   <para>dash:PrimaryKeyConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>Enforces a constraint that the given property (sh:path) serves as primary key for all resources in the target of the shape. If a property has been declared to be the primary key then each resource must have exactly one value for that property. Furthermore, the URIs of those resources must start with a given string (dash:uriStart), followed by the URL-encoded primary key value. For example if dash:uriStart is "http://example.org/country-" and the primary key for an instance is "de" then the URI must be "http://example.org/country-de". Finally, as a result of the URI policy, there can not be any other resource with the same value under the same primary key policy.</para>
    /// labels<para>Primary key constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#PrimaryKeyConstraintComponent">http://datashapes.org/dash#PrimaryKeyConstraintComponent</seealso>
    let PrimaryKeyConstraintComponent =
        Prefixed_Name(dash, "PrimaryKeyConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:HyperlinkViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for literals, rendering as a hyperlink to a URL.
    ///
    /// For literals it assumes the lexical form is the URL.
    ///
    /// This is often used as default viewer for xsd:anyURI literals. Unsupported for blank nodes.</para>
    /// labels<para>Hyperlink viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HyperlinkViewer">http://datashapes.org/dash#HyperlinkViewer</seealso>
    let HyperlinkViewer = Prefixed_Name(dash, "HyperlinkViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:IDRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>ID properties are short strings or other literals that identify the focus node among siblings. Examples may include social security numbers.</para>
    /// labels<para>ID</para></remarks>
    /// <seealso href="http://datashapes.org/dash#IDRole">http://datashapes.org/dash#IDRole</seealso>
    let IDRole = Prefixed_Name(dash, "IDRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:defaultLang</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to annotate a graph (usually the owl:Ontology) with the default language that tools should suggest for new literal values. For example, predominantly English graphs should have "en" as default language.</para>
    /// labels<para>default language</para></remarks>
    /// <seealso href="http://datashapes.org/dash#defaultLang">http://datashapes.org/dash#defaultLang</seealso>
    let defaultLang = Prefixed_Name(dash, "defaultLang") |> PrefixedName
    /// <summary>
    ///   <para>dash:APIStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>The class of possible values for dash:apiStatus.</para>
    /// labels<para>API Status</para></remarks>
    /// <seealso href="http://datashapes.org/dash#APIStatus">http://datashapes.org/dash#APIStatus</seealso>
    let APIStatus = Prefixed_Name(dash, "APIStatus") |> PrefixedName
    /// <summary>
    ///   <para>dash:ActionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A group of ResourceActions, used to arrange items in menus etc. Similar to sh:PropertyGroups, they may have a sh:order and should have labels (in multiple languages if applicable).</para>
    /// labels<para>Action group</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ActionGroup">http://datashapes.org/dash#ActionGroup</seealso>
    let ActionGroup = Prefixed_Name(dash, "ActionGroup") |> PrefixedName
    /// <summary>
    ///   <para>dash:ActionTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case that evaluates a dash:Action using provided input parameters. Requires exactly one value for dash:action and will operate on the test case's graph (with imports) as both data and shapes graph.
    ///
    /// Currently only supports read-only actions, allowing the comparison of actual results with the expected results.</para>
    /// labels<para>Action test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ActionTestCase">http://datashapes.org/dash#ActionTestCase</seealso>
    let ActionTestCase = Prefixed_Name(dash, "ActionTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:TestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case to verify that a (SHACL-based) feature works as expected.</para>
    /// labels<para>Test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TestCase">http://datashapes.org/dash#TestCase</seealso>
    let TestCase = Prefixed_Name(dash, "TestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:AllObjectsTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLTargetType</para>
    ///   <para>A target containing all objects in the data graph as focus nodes.</para>
    /// labels<para>All objects target</para></remarks>
    /// <seealso href="http://datashapes.org/dash#AllObjectsTarget">http://datashapes.org/dash#AllObjectsTarget</seealso>
    let AllObjectsTarget = Prefixed_Name(dash, "AllObjectsTarget") |> PrefixedName
    /// <summary>
    ///   <para>dash:AllSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:AllSubjectsTarget</para>
    ///   <para>A reusable instance of dash:AllSubjectsTarget.</para>
    /// labels<para>All subjects</para></remarks>
    /// <seealso href="http://datashapes.org/dash#AllSubjects">http://datashapes.org/dash#AllSubjects</seealso>
    let AllSubjects = Prefixed_Name(dash, "AllSubjects") |> PrefixedName
    /// <summary>
    ///   <para>dash:AllSubjectsTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLTargetType</para>
    ///   <para>A target containing all subjects in the data graph as focus nodes.</para>
    /// labels<para>All subjects target</para></remarks>
    /// <seealso href="http://datashapes.org/dash#AllSubjectsTarget">http://datashapes.org/dash#AllSubjectsTarget</seealso>
    let AllSubjectsTarget = Prefixed_Name(dash, "AllSubjectsTarget") |> PrefixedName
    /// <summary>
    ///   <para>dash:ListNodeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Defines constraints on what it means for a node to be a node within a well-formed RDF list. Note that this does not check whether the rdf:rest items are also well-formed lists as this would lead to unsupported recursion.</para>
    /// labels<para>List node shape</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ListNodeShape">http://datashapes.org/dash#ListNodeShape</seealso>
    let ListNodeShape = Prefixed_Name(dash, "ListNodeShape") |> PrefixedName
    /// <summary>
    ///   <para>dash:DescriptionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>Description properties should produce text literals that may be used as an introduction/summary of what a focus node does.</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DescriptionRole">http://datashapes.org/dash#DescriptionRole</seealso>
    let DescriptionRole = Prefixed_Name(dash, "DescriptionRole") |> PrefixedName

    /// <summary>
    ///   <para>dash:CoExistsWithConstraintComponent-coExistsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#CoExistsWithConstraintComponent-coExistsWith">http://datashapes.org/dash#CoExistsWithConstraintComponent-coExistsWith</seealso>
    let CoExistsWithConstraintComponent_coExistsWith =
        Prefixed_Name(dash, "CoExistsWithConstraintComponent-coExistsWith") |> PrefixedName

    /// <summary>
    ///   <para>dash:ConstraintReificationShape-message</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ConstraintReificationShape-message">http://datashapes.org/dash#ConstraintReificationShape-message</seealso>
    let ConstraintReificationShape_message =
        Prefixed_Name(dash, "ConstraintReificationShape-message") |> PrefixedName

    /// <summary>
    ///   <para>dash:DatePickerEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for xsd:date literals, offering a calendar-like date picker.</para>
    /// labels<para>Date picker editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DatePickerEditor">http://datashapes.org/dash#DatePickerEditor</seealso>
    let DatePickerEditor = Prefixed_Name(dash, "DatePickerEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:DepictionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>Depiction properties provide images representing the focus nodes. Typical examples may be a photo of an animal or the map of a country.</para>
    /// labels<para>Depiction</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DepictionRole">http://datashapes.org/dash#DepictionRole</seealso>
    let DepictionRole = Prefixed_Name(dash, "DepictionRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:Deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:APIStatus</para>
    ///   <para>Features that have been marked deprecated will remain in the API but should no longer be used by new code and may get deleted in the foreseeable future (e.g., with the next major release).</para>
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Deprecated">http://datashapes.org/dash#Deprecated</seealso>
    let Deprecated = Prefixed_Name(dash, "Deprecated") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptSuggestionGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A Suggestion Generator that is backed by an Active Data Shapes script. The script needs to return a JSON object or an array of JSON objects if it shall generate multiple suggestions. It may also return null to indicate that nothing was suggested. Note that the whole script is evaluated as a (JavaScript) expression, and those will use the last value as result. So simply putting an object at the end of your script should do. Alternatively, define the bulk of the operation as a function and simply call that function in the script.
    ///
    /// Each response object can have the following fields:
    ///
    /// {
    /// 	message: "The human readable message",  // Defaults to the rdfs:label(s) of the suggestion generator
    /// 	add: [ // An array of triples to add, each triple as an array with three nodes
    /// 		[ subject, predicate, object ],
    /// 		[ ... ]
    /// 	],
    /// 	delete: [
    /// 		... like add, for the triples to delete
    /// 	]
    /// }
    ///
    /// Suggestions with neither added nor deleted triples will be discarded.
    ///
    /// At execution time, the script operates on the data graph as the active graph, with the following pre-bound variables:
    /// - focusNode: the NamedNode that is the sh:focusNode of the validation result
    /// - predicate: the NamedNode representing the predicate of the validation result, assuming sh:resultPath is a URI
    /// - value: the value node from the validation result's sh:value, cast into the most suitable JS object
    /// - the other pre-bound variables for the parameters of the constraint, e.g. in a sh:maxCount constraint it would be maxCount
    ///
    /// The script will be executed in read-only mode, i.e. it cannot modify the graph.
    ///
    /// Example with dash:js:
    ///
    /// ({
    /// 	message: `Copy labels into ${graph.localName(predicate)}`,
    /// 	add: focusNode.values(rdfs.label).map(label =&gt;
    /// 		[ focusNode, predicate, label ]
    ///     )
    /// })</para>
    /// labels<para>Script suggestion generator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptSuggestionGenerator">http://datashapes.org/dash#ScriptSuggestionGenerator</seealso>
    let ScriptSuggestionGenerator =
        Prefixed_Name(dash, "ScriptSuggestionGenerator") |> PrefixedName

    /// <summary>
    ///   <para>dash:hidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Properties marked as hidden do not appear in user interfaces, yet remain part of the shape for other purposes such as validation and scripting or GraphQL schema generation.</para>
    /// labels<para>hidden</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hidden">http://datashapes.org/dash#hidden</seealso>
    let hidden = Prefixed_Name(dash, "hidden") |> PrefixedName

    /// <summary>
    ///   <para>dash:SingleLineConstraintComponent-singleLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#SingleLineConstraintComponent-singleLine">http://datashapes.org/dash#SingleLineConstraintComponent-singleLine</seealso>
    let SingleLineConstraintComponent_singleLine =
        Prefixed_Name(dash, "SingleLineConstraintComponent-singleLine") |> PrefixedName

    /// <summary>
    ///   <para>dash:Stable</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:APIStatus</para>
    ///   <para>Features that have been marked stable are deemed of good quality and can be used until marked deprecated.</para>
    /// labels<para>stable</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Stable">http://datashapes.org/dash#Stable</seealso>
    let Stable = Prefixed_Name(dash, "Stable") |> PrefixedName

    /// <summary>
    ///   <para>dash:StemConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to verify that every value node is an IRI and the IRI starts with a given string value.</para>
    /// labels<para>Stem constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#StemConstraintComponent">http://datashapes.org/dash#StemConstraintComponent</seealso>
    let StemConstraintComponent =
        Prefixed_Name(dash, "StemConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a string value that the IRI of the value nodes must start with.</para>
    /// labels<para>stem</para></remarks>
    /// <seealso href="http://datashapes.org/dash#stem">http://datashapes.org/dash#stem</seealso>
    let stem = Prefixed_Name(dash, "stem") |> PrefixedName
    /// <summary>
    ///   <para>dash:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a class is "abstract" and cannot be used in asserted rdf:type triples. Only non-abstract subclasses of abstract classes should be instantiated directly.</para>
    /// labels<para>abstract</para></remarks>
    /// <seealso href="http://datashapes.org/dash#abstract">http://datashapes.org/dash#abstract</seealso>
    let abstract_ = Prefixed_Name(dash, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>dash:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An executable command triggered by an agent, backed by a Script implementation. Actions may get deactivated using sh:deactivated.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Action">http://datashapes.org/dash#Action</seealso>
    let Action = Prefixed_Name(dash, "Action") |> PrefixedName
    /// <summary>
    ///   <para>dash:FailureResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A result representing a validation failure such as an unsupported recursion.</para>
    /// labels<para>Failure result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#FailureResult">http://datashapes.org/dash#FailureResult</seealso>
    let FailureResult = Prefixed_Name(dash, "FailureResult") |> PrefixedName
    /// <summary>
    ///   <para>dash:TestCaseResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Base class for results produced by running test cases.</para>
    /// labels<para>Test case result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TestCaseResult">http://datashapes.org/dash#TestCaseResult</seealso>
    let TestCaseResult = Prefixed_Name(dash, "TestCaseResult") |> PrefixedName
    /// <summary>
    ///   <para>dash:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A script that gets exposed as a web service, e.g. /tbl/service/ex/MyService</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Service">http://datashapes.org/dash#Service</seealso>
    let Service = Prefixed_Name(dash, "Service") |> PrefixedName
    /// <summary>
    ///   <para>dash:GraphStoreTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case that can be used to verify that an RDF file could be loaded (from a file) and that the resulting RDF graph is equivalent to a given TTL file.</para>
    /// labels<para>Graph store test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#GraphStoreTestCase">http://datashapes.org/dash#GraphStoreTestCase</seealso>
    let GraphStoreTestCase = Prefixed_Name(dash, "GraphStoreTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:Suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Base class of suggestions that modify a graph to "fix" the source of a validation result.</para>
    /// labels<para>Suggestion</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Suggestion">http://datashapes.org/dash#Suggestion</seealso>
    let Suggestion = Prefixed_Name(dash, "Suggestion") |> PrefixedName
    /// <summary>
    ///   <para>dash:ValidationTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>Abstract superclass for test cases concerning SHACL constraint validation. Future versions may add new kinds of validatin test cases, e.g. to validate a single resource only.</para>
    /// labels<para>Validation test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ValidationTestCase">http://datashapes.org/dash#ValidationTestCase</seealso>
    let ValidationTestCase = Prefixed_Name(dash, "ValidationTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:HTMLViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for HTML encoded text from rdf:HTML literals, rendering as parsed HTML DOM elements. Also displays the language if the HTML has a lang attribute on its root DOM element.</para>
    /// labels<para>HTML viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HTMLViewer">http://datashapes.org/dash#HTMLViewer</seealso>
    let HTMLViewer = Prefixed_Name(dash, "HTMLViewer") |> PrefixedName

    /// <summary>
    ///   <para>dash:UniqueValueForClassConstraintComponent-uniqueValueForClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#UniqueValueForClassConstraintComponent-uniqueValueForClass">http://datashapes.org/dash#UniqueValueForClassConstraintComponent-uniqueValueForClass</seealso>
    let UniqueValueForClassConstraintComponent_uniqueValueForClass =
        Prefixed_Name(dash, "UniqueValueForClassConstraintComponent-uniqueValueForClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:Script</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An executable unit implemented in one or more languages such as JavaScript.</para>
    /// labels<para>Script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Script">http://datashapes.org/dash#Script</seealso>
    let Script = Prefixed_Name(dash, "Script") |> PrefixedName
    /// <summary>
    ///   <para>dash:HasValueTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLTargetType</para>
    ///   <para>A target type for all subjects where a given predicate has a certain object value.</para>
    /// labels<para>Has Value target</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HasValueTarget">http://datashapes.org/dash#HasValueTarget</seealso>
    let HasValueTarget = Prefixed_Name(dash, "HasValueTarget") |> PrefixedName
    /// <summary>
    ///   <para>dash:predicate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#predicate">http://datashapes.org/dash#predicate</seealso>
    let predicate = Prefixed_Name(dash, "predicate") |> PrefixedName

    /// <summary>
    ///   <para>dash:HasValueWithClassConstraintComponent-hasValueWithClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#HasValueWithClassConstraintComponent-hasValueWithClass">http://datashapes.org/dash#HasValueWithClassConstraintComponent-hasValueWithClass</seealso>
    let HasValueWithClassConstraintComponent_hasValueWithClass =
        Prefixed_Name(dash, "HasValueWithClassConstraintComponent-hasValueWithClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:apiStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines how and whether the associated feature is part of an external API. APIs may be implemented as (REST) web services, via GraphQL or ADS Script APIs.</para>
    /// labels<para>API status</para></remarks>
    /// <seealso href="http://datashapes.org/dash#apiStatus">http://datashapes.org/dash#apiStatus</seealso>
    let apiStatus = Prefixed_Name(dash, "apiStatus") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasValueWithClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a constraint that at least one of the value nodes must be an instance of a given class.</para>
    /// labels<para>has value with class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasValueWithClass">http://datashapes.org/dash#hasValueWithClass</seealso>
    let hasValueWithClass = Prefixed_Name(dash, "hasValueWithClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:IconRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>Icon properties produce images that are typically small and almost square-shaped, and that may be displayed in the upper left corner of a focus node's display. Values should be xsd:string or xsd:anyURI literals or IRI nodes pointing at URLs. Those URLs should ideally be vector graphics such as .svg files.
    ///
    /// Instances of the same class often have the same icon, and this icon may be computed using a sh:values rule or as sh:defaultValue.
    ///
    /// If the value is a relative URL then those should be resolved against the server that delivered the surrounding page.</para>
    /// labels<para>Icon</para></remarks>
    /// <seealso href="http://datashapes.org/dash#IconRole">http://datashapes.org/dash#IconRole</seealso>
    let IconRole = Prefixed_Name(dash, "IconRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:ImageViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for URI values that are recognized as images by a browser, rendering as an image.</para>
    /// labels<para>Image viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ImageViewer">http://datashapes.org/dash#ImageViewer</seealso>
    let ImageViewer = Prefixed_Name(dash, "ImageViewer") |> PrefixedName

    /// <summary>
    ///   <para>dash:IndexedConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to mark property shapes to be indexed, meaning that each of its value nodes must carry a dash:index from 0 to N.</para>
    /// labels<para>Indexed constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#IndexedConstraintComponent">http://datashapes.org/dash#IndexedConstraintComponent</seealso>
    let IndexedConstraintComponent =
        Prefixed_Name(dash, "IndexedConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:InferencingTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case to verify whether an inferencing engine is producing identical results to those stored as expected results.</para>
    /// labels<para>Inferencing test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#InferencingTestCase">http://datashapes.org/dash#InferencingTestCase</seealso>
    let InferencingTestCase = Prefixed_Name(dash, "InferencingTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:MultiViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A viewer for multiple/all values at once.</para>
    /// labels<para>Multi viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#MultiViewer">http://datashapes.org/dash#MultiViewer</seealso>
    let MultiViewer = Prefixed_Name(dash, "MultiViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:JSONTableViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A tabular viewer for rdf:JSON literals with a lexical form in the following format:
    ///
    /// {
    /// 	vars: [ 'col1', 'col2' ],                   // These are the column keys
    /// 	headerLabels: [ 'Column 1', 'Column 2' ],   // Optional, for the column headers
    /// 	bindings: [                                 // These become the rows
    /// 		{
    /// 			col1: {
    /// 				lex: 'Value2',
    /// 				datatype: '...#string',
    /// 			},
    /// 			col2: {
    /// 				uri: 'http://.../Instance',
    /// 				label: 'Example Instance',
    /// 			},
    /// 		},
    /// 		...
    /// 	],
    /// }
    ///
    /// The resulting table will use the headerLabels (if they exist) as column headers, otherwise derive the headers from the variable names. The vars must match the fields in the bindings. The table will contain one row for each binding.
    ///
    /// Using Active Data Shapes, you can construct such literals dynamically using a sh:values rule, e.g.
    ///
    /// ex:MyClass-myProperty
    /// 	a sh:PropertyShape ;
    /// 	sh:path ex:myProperty ;
    /// 	sh:values [
    /// 		dash:js """
    /// 			DataViewers.createTableViewerJSON(focusNode.select(`
    /// 				SELECT ?col1 ?col2
    /// 				WHERE {
    /// 					$this ex:prop1 ?col1 .
    /// 					$this ex:prop2 ?col2 .
    /// 				}
    /// 			`))"""
    /// 	] .
    ///
    /// You may also produce the JSON literal programmatically in JavaScript, or assert the triples by other means.</para>
    /// labels<para>JSON table viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#JSONTableViewer">http://datashapes.org/dash#JSONTableViewer</seealso>
    let JSONTableViewer = Prefixed_Name(dash, "JSONTableViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:KeyInfoRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>The Key info role may be assigned to properties that are likely of special interest to a reader, so that they should appear whenever a summary of a focus node is shown.</para>
    /// labels<para>Key info</para></remarks>
    /// <seealso href="http://datashapes.org/dash#KeyInfoRole">http://datashapes.org/dash#KeyInfoRole</seealso>
    let KeyInfoRole = Prefixed_Name(dash, "KeyInfoRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:LabelRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:PropertyRole</para>
    ///   <para>Properties with this role produce strings that may serve as display label for the focus nodes. Labels should be either plain string literals or strings with a language tag. The values should also be single-line.</para>
    /// labels<para>Label</para></remarks>
    /// <seealso href="http://datashapes.org/dash#LabelRole">http://datashapes.org/dash#LabelRole</seealso>
    let LabelRole = Prefixed_Name(dash, "LabelRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:LangStringViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for literals with a language tag, rendering as the text plus a language indicator.</para>
    /// labels<para>LangString viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#LangStringViewer">http://datashapes.org/dash#LangStringViewer</seealso>
    let LangStringViewer = Prefixed_Name(dash, "LangStringViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:IncludedScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>The code associated with instances of this class will get injected into the generated APIs, as global code snippets. Typically used to declare libraries of utility functions or constants that are (compared to shape scripts) not necessarily associated with specific classes or shapes.
    ///
    /// Note that the JavaScript code stored in dash:js cannot use the export keyword because the code must also work in external scripts (such as on Node.js). Instead, you need to enumerate the exported symbols via dash:exports.</para>
    /// labels<para>Included script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#IncludedScript">http://datashapes.org/dash#IncludedScript</seealso>
    let IncludedScript = Prefixed_Name(dash, "IncludedScript") |> PrefixedName

    /// <summary>
    ///   <para>dash:IndexedConstraintComponent-indexed</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#IndexedConstraintComponent-indexed">http://datashapes.org/dash#IndexedConstraintComponent-indexed</seealso>
    let IndexedConstraintComponent_indexed =
        Prefixed_Name(dash, "IndexedConstraintComponent-indexed") |> PrefixedName

    /// <summary>
    ///   <para>dash:indexed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#indexed">http://datashapes.org/dash#indexed</seealso>
    let indexed = Prefixed_Name(dash, "indexed") |> PrefixedName
    /// <summary>
    ///   <para>dash:InlineViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:MultiViewer</para>
    ///   <para>A multi-viewer that renders all values horizontally, in a more compact form that just a single value per row.</para>
    /// labels<para>Inline viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#InlineViewer">http://datashapes.org/dash#InlineViewer</seealso>
    let InlineViewer = Prefixed_Name(dash, "InlineViewer") |> PrefixedName

    /// <summary>
    ///   <para>dash:InstancesSelectEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A drop-down editor for all instances of the target class (based on sh:class of the property).</para>
    /// labels<para>Instances select editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#InstancesSelectEditor">http://datashapes.org/dash#InstancesSelectEditor</seealso>
    let InstancesSelectEditor =
        Prefixed_Name(dash, "InstancesSelectEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:AutoCompleteEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An auto-complete field to enter the label of instances of a class. This is the fallback editor for any URI resource if no other editors are more suitable.</para>
    /// labels<para>Auto-complete editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#AutoCompleteEditor">http://datashapes.org/dash#AutoCompleteEditor</seealso>
    let AutoCompleteEditor = Prefixed_Name(dash, "AutoCompleteEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:ChangeScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>Class of ADS scripts that are executed after edits to the data graph were made, but within the same edit.
    ///
    /// These scripts may access the current changes from the graphs with names dataset.addedGraphURI and dataset.deletedGraphURI to learn about which resource values have been added or deleted. For example query them using graph.withDataGraph(dataset.addedGraphURI, ...) or via SPARQL's GRAPH keyword.
    ///
    /// Change scripts may then perform further changes which would again become visible to other change scripts. They MUST NOT have other side effects though, because they may get executed in Preview mode, or the change may cause constraint violations and then be rejected. For side effects, after the change has been applied, use commit scripts (dash:CommitScript).
    ///
    /// Change scripts are executed by their relative sh:order, with a default value of 0. Use lower values to execute before other scripts.</para>
    /// labels<para>Change script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ChangeScript">http://datashapes.org/dash#ChangeScript</seealso>
    let ChangeScript = Prefixed_Name(dash, "ChangeScript") |> PrefixedName

    /// <summary>
    ///   <para>dash:ClosedByTypesConstraintComponent-closedByTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ClosedByTypesConstraintComponent-closedByTypes">http://datashapes.org/dash#ClosedByTypesConstraintComponent-closedByTypes</seealso>
    let ClosedByTypesConstraintComponent_closedByTypes =
        Prefixed_Name(dash, "ClosedByTypesConstraintComponent-closedByTypes") |> PrefixedName

    /// <summary>
    ///   <para>dash:closedByTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>closed by types</para></remarks>
    /// <seealso href="http://datashapes.org/dash#closedByTypes">http://datashapes.org/dash#closedByTypes</seealso>
    let closedByTypes = Prefixed_Name(dash, "closedByTypes") |> PrefixedName
    /// <summary>
    ///   <para>dash:localConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be set to true for those constraint components where the validation does not require to visit any other triples than the shape definitions and the direct property values of the focus node mentioned in the property constraints. Examples of this include sh:minCount and sh:hasValue.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server, assuming the client has downloaded a complete snapshot of the resource.
    ///
    /// Any component marked with dash:staticConstraint is also a dash:localConstraint.</para>
    /// labels<para>local constraint</para></remarks>
    /// <seealso href="http://datashapes.org/dash#localConstraint">http://datashapes.org/dash#localConstraint</seealso>
    let localConstraint = Prefixed_Name(dash, "localConstraint") |> PrefixedName
    /// <summary>
    ///   <para>dash:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a property shape with an editor, to state a preferred editing widget in user interfaces.</para>
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#editor">http://datashapes.org/dash#editor</seealso>
    let editor = Prefixed_Name(dash, "editor") |> PrefixedName

    /// <summary>
    ///   <para>dash:PropertyAutoCompleteEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for properties that are either defined as instances of rdf:Property or used as IRI values of sh:path. The component uses auto-complete to find these properties by their rdfs:labels or sh:names.</para>
    /// labels<para>Property auto-complete editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#PropertyAutoCompleteEditor">http://datashapes.org/dash#PropertyAutoCompleteEditor</seealso>
    let PropertyAutoCompleteEditor =
        Prefixed_Name(dash, "PropertyAutoCompleteEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:PropertyLabelViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A viewer for properties that renders a hyperlink using the display label or sh:name, allowing users to either navigate to the rdf:Property resource or the property shape definition. Should be used in conjunction with PropertyAutoCompleteEditor.</para>
    /// labels<para>Property label viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#PropertyLabelViewer">http://datashapes.org/dash#PropertyLabelViewer</seealso>
    let PropertyLabelViewer = Prefixed_Name(dash, "PropertyLabelViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:coExistsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property that must have a value whenever the property path has a value, and must have no value whenever the property path has no value.</para>
    /// labels<para>co-exists with</para></remarks>
    /// <seealso href="http://datashapes.org/dash#coExistsWith">http://datashapes.org/dash#coExistsWith</seealso>
    let coExistsWith = Prefixed_Name(dash, "coExistsWith") |> PrefixedName
    /// <summary>
    ///   <para>dash:CommitScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>Class of ADS scripts that are executed after edits to the data graph were made and have been committed.
    ///
    /// These scripts may access the changes that have just happened from the graphs with names dataset.addedGraphURI and dataset.deletedGraphURI to learn about which resource values have been added or deleted. For example query them using graph.withDataGraph(dataset.addedGraphURI, ...) or via SPARQL's GRAPH keyword.
    ///
    /// Commit scripts may then perform side effects such as updating other graphs or sending out notifications to external systems. For edits that should be made within a finishing change, use change scripts (dash:ChangeScript).
    ///
    /// Commit scripts are executed by their relative sh:order, with a default value of 0. Use lower values to execute before other scripts.</para>
    /// labels<para>Commit script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#CommitScript">http://datashapes.org/dash#CommitScript</seealso>
    let CommitScript = Prefixed_Name(dash, "CommitScript") |> PrefixedName

    /// <summary>
    ///   <para>dash:ReifiableByConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///
    /// labels<para>Reifiable-by constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ReifiableByConstraintComponent">http://datashapes.org/dash#ReifiableByConstraintComponent</seealso>
    let ReifiableByConstraintComponent =
        Prefixed_Name(dash, "ReifiableByConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:ReifiableByConstraintComponent-reifiableBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ReifiableByConstraintComponent-reifiableBy">http://datashapes.org/dash#ReifiableByConstraintComponent-reifiableBy</seealso>
    let ReifiableByConstraintComponent_reifiableBy =
        Prefixed_Name(dash, "ReifiableByConstraintComponent-reifiableBy") |> PrefixedName

    /// <summary>
    ///   <para>dash:RichTextEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A rich text editor to enter the lexical value of a literal and a drop down to select language. The selected language is stored in the HTML lang attribute of the root node in the HTML DOM tree.</para>
    /// labels<para>Rich text editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#RichTextEditor">http://datashapes.org/dash#RichTextEditor</seealso>
    let RichTextEditor = Prefixed_Name(dash, "RichTextEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:RootClassConstraintComponent-rootClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#RootClassConstraintComponent-rootClass">http://datashapes.org/dash#RootClassConstraintComponent-rootClass</seealso>
    let RootClassConstraintComponent_rootClass =
        Prefixed_Name(dash, "RootClassConstraintComponent-rootClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:hasRootClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///
    /// labels<para>has root class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasRootClass">http://datashapes.org/dash#hasRootClass</seealso>
    let hasRootClass = Prefixed_Name(dash, "hasRootClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:rootClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>root class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#rootClass">http://datashapes.org/dash#rootClass</seealso>
    let rootClass = Prefixed_Name(dash, "rootClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:SPARQLConstructTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Encapsulates one or more SPARQL CONSTRUCT queries that can be parameterized. Parameters will become pre-bound variables in the queries.</para>
    /// labels<para>SPARQL CONSTRUCT template</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SPARQLConstructTemplate">http://datashapes.org/dash#SPARQLConstructTemplate</seealso>
    let SPARQLConstructTemplate =
        Prefixed_Name(dash, "SPARQLConstructTemplate") |> PrefixedName

    /// <summary>
    ///   <para>dash:SPARQLMultiFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A multi-function based on a SPARQL SELECT query. The query gets executed with the arguments pre-bound to the variables declared as parameters. The results of the multi-function are all result bindings from the SPARQL result set.</para>
    /// labels<para>SPARQL multi-function</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SPARQLMultiFunction">http://datashapes.org/dash#SPARQLMultiFunction</seealso>
    let SPARQLMultiFunction = Prefixed_Name(dash, "SPARQLMultiFunction") |> PrefixedName

    /// <summary>
    ///   <para>dash:SPARQLSelectTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Encapsulates a SPARQL SELECT query that can be parameterized. Parameters will become pre-bound variables in the query.</para>
    /// labels<para>SPARQL SELECT template</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SPARQLSelectTemplate">http://datashapes.org/dash#SPARQLSelectTemplate</seealso>
    let SPARQLSelectTemplate =
        Prefixed_Name(dash, "SPARQLSelectTemplate") |> PrefixedName

    /// <summary>
    ///   <para>dash:SPARQLUpdateSuggestionGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SuggestionGenerator based on a SPARQL UPDATE query (sh:update), producing an instance of dash:GraphUpdate. The INSERTs become dash:addedTriple and the DELETEs become dash:deletedTriple. The WHERE clause operates on the data graph with the pre-bound variables $focusNode, $predicate and $value, as well as the other pre-bound variables for the parameters of the constraint.
    ///
    /// In many cases, there may be multiple possible suggestions to fix a problem. For example, with sh:maxLength there are many ways to slice a string. In those cases, the system will first iterate through the result variables from a SELECT query (sh:select) and apply these results as pre-bound variables into the UPDATE query.</para>
    /// labels<para>SPARQL UPDATE suggestion generator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SPARQLUpdateSuggestionGenerator">http://datashapes.org/dash#SPARQLUpdateSuggestionGenerator</seealso>
    let SPARQLUpdateSuggestionGenerator =
        Prefixed_Name(dash, "SPARQLUpdateSuggestionGenerator") |> PrefixedName

    /// <summary>
    ///   <para>dash:SuggestionGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Base class of objects that can generate suggestions (added or deleted triples) for a validation result of a given constraint component.</para>
    /// labels<para>Suggestion generator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SuggestionGenerator">http://datashapes.org/dash#SuggestionGenerator</seealso>
    let SuggestionGenerator = Prefixed_Name(dash, "SuggestionGenerator") |> PrefixedName
    /// <summary>
    ///   <para>dash:ScriptAPIShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Defines the properties that instruct the ADS Script API generator about what prefixes, constants and classes to generate.</para>
    /// labels<para>Script API</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptAPIShape">http://datashapes.org/dash#ScriptAPIShape</seealso>
    let ScriptAPIShape = Prefixed_Name(dash, "ScriptAPIShape") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptAPIShape-generateClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptAPIShape-generateClass">http://datashapes.org/dash#ScriptAPIShape-generateClass</seealso>
    let ScriptAPIShape_generateClass =
        Prefixed_Name(dash, "ScriptAPIShape-generateClass") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptAPIShape-generatePrefixClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptAPIShape-generatePrefixClasses">http://datashapes.org/dash#ScriptAPIShape-generatePrefixClasses</seealso>
    let ScriptAPIShape_generatePrefixClasses =
        Prefixed_Name(dash, "ScriptAPIShape-generatePrefixClasses") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptAPIShape-generatePrefixConstants</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptAPIShape-generatePrefixConstants">http://datashapes.org/dash#ScriptAPIShape-generatePrefixConstants</seealso>
    let ScriptAPIShape_generatePrefixConstants =
        Prefixed_Name(dash, "ScriptAPIShape-generatePrefixConstants") |> PrefixedName

    /// <summary>
    ///   <para>dash:generatePrefixClasses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#generatePrefixClasses">http://datashapes.org/dash#generatePrefixClasses</seealso>
    let generatePrefixClasses =
        Prefixed_Name(dash, "generatePrefixClasses") |> PrefixedName

    /// <summary>
    ///   <para>dash:generatePrefixConstants</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#generatePrefixConstants">http://datashapes.org/dash#generatePrefixConstants</seealso>
    let generatePrefixConstants =
        Prefixed_Name(dash, "generatePrefixConstants") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///
    /// labels<para>Script constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptConstraintComponent">http://datashapes.org/dash#ScriptConstraintComponent</seealso>
    let ScriptConstraintComponent =
        Prefixed_Name(dash, "ScriptConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptConstraintComponent-scriptConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptConstraintComponent-scriptConstraint">http://datashapes.org/dash#ScriptConstraintComponent-scriptConstraint</seealso>
    let ScriptConstraintComponent_scriptConstraint =
        Prefixed_Name(dash, "ScriptConstraintComponent-scriptConstraint") |> PrefixedName

    /// <summary>
    ///   <para>dash:scriptConstraint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#scriptConstraint">http://datashapes.org/dash#scriptConstraint</seealso>
    let scriptConstraint = Prefixed_Name(dash, "scriptConstraint") |> PrefixedName
    /// <summary>
    ///   <para>dash:ScriptTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case that evaluates a script. Requires exactly one value for dash:js and will operate on the test case's graph (with imports) as both data and shapes graph.
    ///
    /// Supports read-only scripts only at this stage.</para>
    /// labels<para>Script test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptTestCase">http://datashapes.org/dash#ScriptTestCase</seealso>
    let ScriptTestCase = Prefixed_Name(dash, "ScriptTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:ScriptValidator</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A SHACL validator based on an Active Data Shapes script.
    ///
    /// See the comment at dash:ScriptConstraint for the basic evaluation approach. Note that in addition to focusNode and value/values, the script can access pre-bound variables for each declared argument of the constraint component.</para>
    /// labels<para>Script validator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptValidator">http://datashapes.org/dash#ScriptValidator</seealso>
    let ScriptValidator = Prefixed_Name(dash, "ScriptValidator") |> PrefixedName
    /// <summary>
    ///   <para>dash:ShapeScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shape script contains extra code that gets injected into the API for the associated node shape. In particular you can use this to define additional functions that operate on the current focus node (the this variable in JavaScript).</para>
    /// labels<para>Shape script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ShapeScript">http://datashapes.org/dash#ShapeScript</seealso>
    let ShapeScript = Prefixed_Name(dash, "ShapeScript") |> PrefixedName

    /// <summary>
    ///   <para>dash:SingleLineConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to declare that all values that are literals must have a lexical form that contains no line breaks ('\n' or '\r').
    ///
    /// User interfaces may use the dash:singleLine flag to prefer a text field over a (multi-line) text area.</para>
    /// labels<para>Single line constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SingleLineConstraintComponent">http://datashapes.org/dash#SingleLineConstraintComponent</seealso>
    let SingleLineConstraintComponent =
        Prefixed_Name(dash, "SingleLineConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:staticConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be set to true for those constraint components where the validation does not require to visit any other triples than the parameters. Examples of this include sh:datatype or sh:nodeKind, where no further triples need to be queried to determine the result.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server.</para>
    /// labels<para>static constraint</para></remarks>
    /// <seealso href="http://datashapes.org/dash#staticConstraint">http://datashapes.org/dash#staticConstraint</seealso>
    let staticConstraint = Prefixed_Name(dash, "staticConstraint") |> PrefixedName

    /// <summary>
    ///   <para>dash:StemConstraintComponent-stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#StemConstraintComponent-stem">http://datashapes.org/dash#StemConstraintComponent-stem</seealso>
    let StemConstraintComponent_stem =
        Prefixed_Name(dash, "StemConstraintComponent-stem") |> PrefixedName

    /// <summary>
    ///   <para>dash:hasStem</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node is an IRI starting with a given stem.</para>
    /// labels<para>has stem</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasStem">http://datashapes.org/dash#hasStem</seealso>
    let hasStem = Prefixed_Name(dash, "hasStem") |> PrefixedName

    /// <summary>
    ///   <para>dash:StringOrLangStringOrHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:string, rdf:langString or rdf:HTML (in that order of preference).</para>
    /// labels<para>string or langString or HTML</para></remarks>
    /// <seealso href="http://datashapes.org/dash#StringOrLangStringOrHTML">http://datashapes.org/dash#StringOrLangStringOrHTML</seealso>
    let StringOrLangStringOrHTML =
        Prefixed_Name(dash, "StringOrLangStringOrHTML") |> PrefixedName

    /// <summary>
    ///   <para>dash:SubClassEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for properties that declare a dash:rootClass. The editor allows selecting either the class itself or one of its subclasses.</para>
    /// labels<para>Sub-Class editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SubClassEditor">http://datashapes.org/dash#SubClassEditor</seealso>
    let SubClassEditor = Prefixed_Name(dash, "SubClassEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:SubSetOfConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to state that the set of value nodes must be a subset of the value of a given property.</para>
    /// labels<para>Sub set of constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SubSetOfConstraintComponent">http://datashapes.org/dash#SubSetOfConstraintComponent</seealso>
    let SubSetOfConstraintComponent =
        Prefixed_Name(dash, "SubSetOfConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:SubSetOfConstraintComponent-subSetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#SubSetOfConstraintComponent-subSetOf">http://datashapes.org/dash#SubSetOfConstraintComponent-subSetOf</seealso>
    let SubSetOfConstraintComponent_subSetOf =
        Prefixed_Name(dash, "SubSetOfConstraintComponent-subSetOf") |> PrefixedName

    /// <summary>
    ///   <para>dash:subSetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>sub set of</para></remarks>
    /// <seealso href="http://datashapes.org/dash#subSetOf">http://datashapes.org/dash#subSetOf</seealso>
    let subSetOf = Prefixed_Name(dash, "subSetOf") |> PrefixedName
    /// <summary>
    ///   <para>dash:SuccessResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A result representing a successfully validated constraint.</para>
    /// labels<para>Success result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SuccessResult">http://datashapes.org/dash#SuccessResult</seealso>
    let SuccessResult = Prefixed_Name(dash, "SuccessResult") |> PrefixedName

    /// <summary>
    ///   <para>dash:SuccessTestCaseResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a successful run of a test case.</para>
    /// labels<para>Success test case result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SuccessTestCaseResult">http://datashapes.org/dash#SuccessTestCaseResult</seealso>
    let SuccessTestCaseResult =
        Prefixed_Name(dash, "SuccessTestCaseResult") |> PrefixedName

    /// <summary>
    ///   <para>dash:SuggestionResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Class of results that have been produced as suggestions, not through SHACL validation. How the actual results are produced is up to implementers. Each instance of this class should have values for sh:focusNode, sh:resultMessage, sh:resultSeverity (suggested default: sh:Info), and dash:suggestion to point at one or more suggestions.</para>
    /// labels<para>Suggestion result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SuggestionResult">http://datashapes.org/dash#SuggestionResult</seealso>
    let SuggestionResult = Prefixed_Name(dash, "SuggestionResult") |> PrefixedName

    /// <summary>
    ///   <para>dash:SymmetricConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A contraint component for property shapes to validate that a property is symmetric. For symmetric properties, if A relates to B then B must relate to A.</para>
    /// labels<para>Symmetric constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SymmetricConstraintComponent">http://datashapes.org/dash#SymmetricConstraintComponent</seealso>
    let SymmetricConstraintComponent =
        Prefixed_Name(dash, "SymmetricConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:SymmetricConstraintComponent-symmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#SymmetricConstraintComponent-symmetric">http://datashapes.org/dash#SymmetricConstraintComponent-symmetric</seealso>
    let SymmetricConstraintComponent_symmetric =
        Prefixed_Name(dash, "SymmetricConstraintComponent-symmetric") |> PrefixedName

    /// <summary>
    ///   <para>dash:symmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True to declare that the associated property path is symmetric.</para>
    /// labels<para>symmetric</para></remarks>
    /// <seealso href="http://datashapes.org/dash#symmetric">http://datashapes.org/dash#symmetric</seealso>
    let symmetric = Prefixed_Name(dash, "symmetric") |> PrefixedName
    /// <summary>
    ///   <para>dash:TestEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract base class for test environments, holding information on how to set up a test case.</para>
    /// labels<para>Test environment</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TestEnvironment">http://datashapes.org/dash#TestEnvironment</seealso>
    let TestEnvironment = Prefixed_Name(dash, "TestEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>dash:TextAreaEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A multi-line text area to enter the value of a literal.</para>
    /// labels<para>Text area editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TextAreaEditor">http://datashapes.org/dash#TextAreaEditor</seealso>
    let TextAreaEditor = Prefixed_Name(dash, "TextAreaEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:TextAreaWithLangEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A multi-line text area to enter the value of a literal and a drop down to select a language.</para>
    /// labels<para>Text area with lang editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TextAreaWithLangEditor">http://datashapes.org/dash#TextAreaWithLangEditor</seealso>
    let TextAreaWithLangEditor =
        Prefixed_Name(dash, "TextAreaWithLangEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:TextFieldEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A simple input field to enter the value of a literal, without the ability to change language or datatype.
    ///
    /// This is the fallback editor for any literal if no other editors are more suitable.</para>
    /// labels<para>Text field editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TextFieldEditor">http://datashapes.org/dash#TextFieldEditor</seealso>
    let TextFieldEditor = Prefixed_Name(dash, "TextFieldEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:TextFieldWithLangEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A single-line input field to enter the value of a literal and a drop down to select language, which is mandatory unless xsd:string is among the permissible datatypes.</para>
    /// labels<para>Text field with lang editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#TextFieldWithLangEditor">http://datashapes.org/dash#TextFieldWithLangEditor</seealso>
    let TextFieldWithLangEditor =
        Prefixed_Name(dash, "TextFieldWithLangEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:URIEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An input field to enter the URI of a resource, e.g. rdfs:seeAlso links or images.</para>
    /// labels<para>URI editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#URIEditor">http://datashapes.org/dash#URIEditor</seealso>
    let URIEditor = Prefixed_Name(dash, "URIEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:URIViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for URI resources, rendering as a hyperlink to that URI. Also includes other ways of interacting with the URI such as opening a nested summary display.</para>
    /// labels<para>URI viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#URIViewer">http://datashapes.org/dash#URIViewer</seealso>
    let URIViewer = Prefixed_Name(dash, "URIViewer") |> PrefixedName

    /// <summary>
    ///   <para>dash:UniqueValueForClassConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to state that the values of a property must be unique for all instances of a given class (and its subclasses).</para>
    /// labels<para>Unique value for class constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#UniqueValueForClassConstraintComponent">http://datashapes.org/dash#UniqueValueForClassConstraintComponent</seealso>
    let UniqueValueForClassConstraintComponent =
        Prefixed_Name(dash, "UniqueValueForClassConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:uniqueValueForClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>unique value for class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#uniqueValueForClass">http://datashapes.org/dash#uniqueValueForClass</seealso>
    let uniqueValueForClass = Prefixed_Name(dash, "uniqueValueForClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:UntrustedHTMLViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for HTML content from untrusted sources. This viewer will sanitize the HTML before rendering. Any a, button, checkbox, form, hidden, input, img, script, select, style and textarea tags and class and style attributes will be removed.</para>
    /// labels<para>Untrusted HTML viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#UntrustedHTMLViewer">http://datashapes.org/dash#UntrustedHTMLViewer</seealso>
    let UntrustedHTMLViewer = Prefixed_Name(dash, "UntrustedHTMLViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:ValueTableViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:MultiViewer</para>
    ///   <para>A viewer that renders all values of a given property as a table, with one value per row, and the columns defined by the shape that is the sh:node or sh:class of the property.</para>
    /// labels<para>Value table viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ValueTableViewer">http://datashapes.org/dash#ValueTableViewer</seealso>
    let ValueTableViewer = Prefixed_Name(dash, "ValueTableViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:actionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links an Action with the ActionGroup that it should be arranged in.</para>
    /// labels<para>action group</para></remarks>
    /// <seealso href="http://datashapes.org/dash#actionGroup">http://datashapes.org/dash#actionGroup</seealso>
    let actionGroup = Prefixed_Name(dash, "actionGroup") |> PrefixedName
    /// <summary>
    ///   <para>dash:actionIconClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (CSS) class of an Action for display purposes alongside the label.</para>
    /// labels<para>action icon class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#actionIconClass">http://datashapes.org/dash#actionIconClass</seealso>
    let actionIconClass = Prefixed_Name(dash, "actionIconClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:addedTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>May link a dash:GraphUpdate with one or more triples (represented as instances of rdf:Statement) that should be added to fix the source of the result.</para>
    /// labels<para>added triple</para></remarks>
    /// <seealso href="http://datashapes.org/dash#addedTriple">http://datashapes.org/dash#addedTriple</seealso>
    let addedTriple = Prefixed_Name(dash, "addedTriple") |> PrefixedName
    /// <summary>
    ///   <para>dash:all</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Represents all users/roles, for example as a possible value of the default view for role property.</para>
    /// labels<para>all</para></remarks>
    /// <seealso href="http://datashapes.org/dash#all">http://datashapes.org/dash#all</seealso>
    let all = Prefixed_Name(dash, "all") |> PrefixedName
    /// <summary>
    ///   <para>dash:applicableToClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to state that a shape is applicable to instances of a given class. This is a softer statement than "target class": a target means that all instances of the class must conform to the shape. Being applicable to simply means that the shape may apply to (some) instances of the class. This information can be used by algorithms or humans.</para>
    /// labels<para>applicable to class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#applicableToClass">http://datashapes.org/dash#applicableToClass</seealso>
    let applicableToClass = Prefixed_Name(dash, "applicableToClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:cachable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If set to true then the results of the SHACL function can be cached in between invocations with the same arguments. In other words, they are stateless and do not depend on triples in any graph, or the current time stamp etc.</para>
    /// labels<para>cachable</para></remarks>
    /// <seealso href="http://datashapes.org/dash#cachable">http://datashapes.org/dash#cachable</seealso>
    let cachable = Prefixed_Name(dash, "cachable") |> PrefixedName
    /// <summary>
    ///   <para>dash:composite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to indicate that a property/path represented by a property constraint represents a composite relationship. In a composite relationship, the life cycle of a "child" object (value of the property/path) depends on the "parent" object (focus node). If the parent gets deleted, then the child objects should be deleted, too. Tools may use dash:composite (if set to true) to implement cascading delete operations.</para>
    /// labels<para>composite</para></remarks>
    /// <seealso href="http://datashapes.org/dash#composite">http://datashapes.org/dash#composite</seealso>
    let composite = Prefixed_Name(dash, "composite") |> PrefixedName
    /// <summary>
    ///   <para>dash:contextFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to mark certain parameterizables as context-free, meaning that the outcome of a process does not depend on the currently active query graph.</para>
    /// labels<para>context-free</para></remarks>
    /// <seealso href="http://datashapes.org/dash#contextFree">http://datashapes.org/dash#contextFree</seealso>
    let contextFree = Prefixed_Name(dash, "contextFree") |> PrefixedName
    /// <summary>
    ///   <para>dash:defaultViewForRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a node shape with the roles for which it shall be used as default view. User interfaces can use these values to select how to present a given RDF resource. The values of this property are URIs representing a group of users or agents. There is a dedicated URI dash:all representing all users.</para>
    /// labels<para>default view for role</para></remarks>
    /// <seealso href="http://datashapes.org/dash#defaultViewForRole">http://datashapes.org/dash#defaultViewForRole</seealso>
    let defaultViewForRole = Prefixed_Name(dash, "defaultViewForRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:deletedTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>May link a dash:GraphUpdate result with one or more triples (represented as instances of rdf:Statement) that should be deleted to fix the source of the result.</para>
    /// labels<para>deleted triple</para></remarks>
    /// <seealso href="http://datashapes.org/dash#deletedTriple">http://datashapes.org/dash#deletedTriple</seealso>
    let deletedTriple = Prefixed_Name(dash, "deletedTriple") |> PrefixedName
    /// <summary>
    ///   <para>dash:dependencyPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used in dash:js node expressions to enumerate the predicates that the computation of the values may depend on. This can be used by clients to determine whether an edit requires re-computation of values on a form or elsewhere. For example, if the dash:js is something like "focusNode.firstName + focusNode.lastName" then the dependency predicates should be ex:firstName and ex:lastName.</para>
    /// labels<para>dependency predicate</para></remarks>
    /// <seealso href="http://datashapes.org/dash#dependencyPredicate">http://datashapes.org/dash#dependencyPredicate</seealso>
    let dependencyPredicate = Prefixed_Name(dash, "dependencyPredicate") |> PrefixedName
    /// <summary>
    ///   <para>dash:detailsEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a SHACL property shape with the URL of a SPARQL endpoint that may contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to values from an external graph when the user wants to retrieve more information about a value.
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information. One implementation strategy would be to periodically fetch the values specified by the sh:node or sh:class shape associated with the property, using the property shapes in that shape, and add the resulting triples into the main query graph.
    ///
    /// An example value is "https://query.wikidata.org/sparql".</para>
    /// labels<para>details endpoint</para></remarks>
    /// <seealso href="http://datashapes.org/dash#detailsEndpoint">http://datashapes.org/dash#detailsEndpoint</seealso>
    let detailsEndpoint = Prefixed_Name(dash, "detailsEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>dash:detailsGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a SHACL property shape with a SHACL node expression that produces the URIs of one or more graphs that contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to another data graph when the user wants to retrieve more information about a value.
    ///
    /// The node expressions are evaluated with the focus node as input. (It is unclear whether there are also cases where the result may be different for each specific value, in which case the node expression would need a second input argument).
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information.</para>
    /// labels<para>details graph</para></remarks>
    /// <seealso href="http://datashapes.org/dash#detailsGraph">http://datashapes.org/dash#detailsGraph</seealso>
    let detailsGraph = Prefixed_Name(dash, "detailsGraph") |> PrefixedName
    /// <summary>
    ///   <para>dash:expectedResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The expected result(s) of a test case. The value range of this property is different for each kind of test cases.</para>
    /// labels<para>expected result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#expectedResult">http://datashapes.org/dash#expectedResult</seealso>
    let expectedResult = Prefixed_Name(dash, "expectedResult") |> PrefixedName

    /// <summary>
    ///   <para>dash:expectedResultIsJSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A flag to indicate that the expected result represents a JSON string. If set to true, then tests would compare JSON structures (regardless of whitespaces) instead of actual syntax.</para>
    /// labels<para>expected result is JSON</para></remarks>
    /// <seealso href="http://datashapes.org/dash#expectedResultIsJSON">http://datashapes.org/dash#expectedResultIsJSON</seealso>
    let expectedResultIsJSON =
        Prefixed_Name(dash, "expectedResultIsJSON") |> PrefixedName

    /// <summary>
    ///   <para>dash:expectedResultIsTTL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A flag to indicate that the expected result represents an RDF graph encoded as a Turtle file. If set to true, then tests would compare graphs instead of actual syntax.</para>
    /// labels<para>expected result is Turtle</para></remarks>
    /// <seealso href="http://datashapes.org/dash#expectedResultIsTTL">http://datashapes.org/dash#expectedResultIsTTL</seealso>
    let expectedResultIsTTL = Prefixed_Name(dash, "expectedResultIsTTL") |> PrefixedName
    /// <summary>
    ///   <para>dash:fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to mark that certain validation results have already been fixed.</para>
    /// labels<para>fixed</para></remarks>
    /// <seealso href="http://datashapes.org/dash#fixed">http://datashapes.org/dash#fixed</seealso>
    let fixed_ = Prefixed_Name(dash, "fixed") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///
    /// labels<para>has class</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasClass">http://datashapes.org/dash#hasClass</seealso>
    let hasClass = Prefixed_Name(dash, "hasClass") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMaxExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node (?value) has a value less than (&lt;) the provided ?maxExclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.</para>
    /// labels<para>has max exclusive</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMaxExclusive">http://datashapes.org/dash#hasMaxExclusive</seealso>
    let hasMaxExclusive = Prefixed_Name(dash, "hasMaxExclusive") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMaxInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node (?value) has a value less than or equal to (&lt;=) the provided ?maxInclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.</para>
    /// labels<para>has max inclusive</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMaxInclusive">http://datashapes.org/dash#hasMaxInclusive</seealso>
    let hasMaxInclusive = Prefixed_Name(dash, "hasMaxInclusive") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMaxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given string (?value) has a length within a given maximum string length.</para>
    /// labels<para>has max length</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMaxLength">http://datashapes.org/dash#hasMaxLength</seealso>
    let hasMaxLength = Prefixed_Name(dash, "hasMaxLength") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMinExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node (?value) has value greater than (&gt;) the provided ?minExclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.</para>
    /// labels<para>has min exclusive</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMinExclusive">http://datashapes.org/dash#hasMinExclusive</seealso>
    let hasMinExclusive = Prefixed_Name(dash, "hasMinExclusive") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasMinLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given string (?value) has a length within a given minimum string length.</para>
    /// labels<para>has min length</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasMinLength">http://datashapes.org/dash#hasMinLength</seealso>
    let hasMinLength = Prefixed_Name(dash, "hasMinLength") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasNodeKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether a given node (?value) has a given sh:NodeKind (?nodeKind). For example, sh:hasNodeKind(42, sh:Literal) = true.</para>
    /// labels<para>has node kind</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasNodeKind">http://datashapes.org/dash#hasNodeKind</seealso>
    let hasNodeKind = Prefixed_Name(dash, "hasNodeKind") |> PrefixedName
    /// <summary>
    ///   <para>dash:hasPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///   <para>Checks whether the string representation of a given node (?value) matches a given regular expression (?pattern). Returns false if the value is a blank node.</para>
    /// labels<para>has pattern</para></remarks>
    /// <seealso href="http://datashapes.org/dash#hasPattern">http://datashapes.org/dash#hasPattern</seealso>
    let hasPattern = Prefixed_Name(dash, "hasPattern") |> PrefixedName
    /// <summary>
    ///   <para>dash:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The height.</para>
    /// labels<para>height</para></remarks>
    /// <seealso href="http://datashapes.org/dash#height">http://datashapes.org/dash#height</seealso>
    let height = Prefixed_Name(dash, "height") |> PrefixedName
    /// <summary>
    ///   <para>dash:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>index</para></remarks>
    /// <seealso href="http://datashapes.org/dash#index">http://datashapes.org/dash#index</seealso>
    let index = Prefixed_Name(dash, "index") |> PrefixedName
    /// <summary>
    ///   <para>dash:isDeactivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Checks whether a given shape or constraint has been marked as "deactivated" using sh:deactivated.</para>
    /// labels<para>is deactivated</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isDeactivated">http://datashapes.org/dash#isDeactivated</seealso>
    let isDeactivated = Prefixed_Name(dash, "isDeactivated") |> PrefixedName
    /// <summary>
    ///   <para>dash:isIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///
    /// labels<para>is in</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isIn">http://datashapes.org/dash#isIn</seealso>
    let isIn = Prefixed_Name(dash, "isIn") |> PrefixedName
    /// <summary>
    ///   <para>dash:isLanguageIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLAskValidator</para>
    ///
    /// labels<para>is language in</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isLanguageIn">http://datashapes.org/dash#isLanguageIn</seealso>
    let isLanguageIn = Prefixed_Name(dash, "isLanguageIn") |> PrefixedName
    /// <summary>
    ///   <para>dash:isNodeKindBlankNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Checks if a given sh:NodeKind is one that includes BlankNodes.</para>
    /// labels<para>is NodeKind BlankNode</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isNodeKindBlankNode">http://datashapes.org/dash#isNodeKindBlankNode</seealso>
    let isNodeKindBlankNode = Prefixed_Name(dash, "isNodeKindBlankNode") |> PrefixedName
    /// <summary>
    ///   <para>dash:nodeKind</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#nodeKind">http://datashapes.org/dash#nodeKind</seealso>
    let nodeKind = Prefixed_Name(dash, "nodeKind") |> PrefixedName
    /// <summary>
    ///   <para>dash:isNodeKindIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Checks if a given sh:NodeKind is one that includes IRIs.</para>
    /// labels<para>is NodeKind IRI</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isNodeKindIRI">http://datashapes.org/dash#isNodeKindIRI</seealso>
    let isNodeKindIRI = Prefixed_Name(dash, "isNodeKindIRI") |> PrefixedName
    /// <summary>
    ///   <para>dash:isNodeKindLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Checks if a given sh:NodeKind is one that includes Literals.</para>
    /// labels<para>is NodeKind Literal</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isNodeKindLiteral">http://datashapes.org/dash#isNodeKindLiteral</seealso>
    let isNodeKindLiteral = Prefixed_Name(dash, "isNodeKindLiteral") |> PrefixedName
    /// <summary>
    ///   <para>dash:isSubClassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Returns true if a given class (first argument) is a subclass of a given other class (second argument), or identical to that class. This is equivalent to an rdfs:subClassOf* check.</para>
    /// labels<para>is subclass of</para></remarks>
    /// <seealso href="http://datashapes.org/dash#isSubClassOf">http://datashapes.org/dash#isSubClassOf</seealso>
    let isSubClassOf = Prefixed_Name(dash, "isSubClassOf") |> PrefixedName

    /// <summary>
    ///   <para>dash:isSubClassOf-superclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#isSubClassOf-superclass">http://datashapes.org/dash#isSubClassOf-superclass</seealso>
    let isSubClassOf_superclass =
        Prefixed_Name(dash, "isSubClassOf-superclass") |> PrefixedName

    /// <summary>
    ///   <para>dash:subclass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#subclass">http://datashapes.org/dash#subclass</seealso>
    let subclass = Prefixed_Name(dash, "subclass") |> PrefixedName
    /// <summary>
    ///   <para>dash:superclass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#superclass">http://datashapes.org/dash#superclass</seealso>
    let superclass = Prefixed_Name(dash, "superclass") |> PrefixedName
    /// <summary>
    ///   <para>dash:js</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The JavaScript source code of a Script.</para>
    /// labels<para>JavaScript source code</para></remarks>
    /// <seealso href="http://datashapes.org/dash#js">http://datashapes.org/dash#js</seealso>
    let js = Prefixed_Name(dash, "js") |> PrefixedName
    /// <summary>
    ///   <para>dash:mimeTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For file-typed properties, this can be used to specify the expected/allowed mime types of its values. This can be used, for example, to limit file input boxes or file selectors. If multiple values are allowed then they need to be separated by commas.
    ///
    /// Example values are listed at https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types</para>
    /// labels<para>mime types</para></remarks>
    /// <seealso href="http://datashapes.org/dash#mimeTypes">http://datashapes.org/dash#mimeTypes</seealso>
    let mimeTypes = Prefixed_Name(dash, "mimeTypes") |> PrefixedName
    /// <summary>
    ///   <para>dash:neverMaterialize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If set to true at a property shape then any sh:values and sh:defaultValue rules of this property will be ignored when 'all inferences' are computed. This is useful for property values that shall only be computed for individual focus nodes (e.g. when a user visits a resource) but not for large inference runs.</para>
    /// labels<para>never materialize</para></remarks>
    /// <seealso href="http://datashapes.org/dash#neverMaterialize">http://datashapes.org/dash#neverMaterialize</seealso>
    let neverMaterialize = Prefixed_Name(dash, "neverMaterialize") |> PrefixedName
    /// <summary>
    ///   <para>dash:onAllValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If set to true for a ScriptConstraint or ScriptValidator, then the associated script will receive all value nodes at once, as a value of the variable values. By default (or false), the script is called for each value node individually.</para>
    /// labels<para>on all values</para></remarks>
    /// <seealso href="http://datashapes.org/dash#onAllValues">http://datashapes.org/dash#onAllValues</seealso>
    let onAllValues = Prefixed_Name(dash, "onAllValues") |> PrefixedName

    /// <summary>
    ///   <para>dash:propertySuggestionGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the constraint component with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by a property constraint.</para>
    /// labels<para>property suggestion generator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#propertySuggestionGenerator">http://datashapes.org/dash#propertySuggestionGenerator</seealso>
    let propertySuggestionGenerator =
        Prefixed_Name(dash, "propertySuggestionGenerator") |> PrefixedName

    /// <summary>
    ///   <para>dash:readOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used as a hint for user interfaces that values of the associated property should not be editable. The values of this may be the boolean literals true or false or, more generally, a SHACL node expression that must evaluate to true or false.</para>
    /// labels<para>read only</para></remarks>
    /// <seealso href="http://datashapes.org/dash#readOnly">http://datashapes.org/dash#readOnly</seealso>
    let readOnly = Prefixed_Name(dash, "readOnly") |> PrefixedName
    /// <summary>
    ///   <para>dash:resourceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a class with the Resource Actions that can be applied to instances of that class.</para>
    /// labels<para>resource action</para></remarks>
    /// <seealso href="http://datashapes.org/dash#resourceAction">http://datashapes.org/dash#resourceAction</seealso>
    let resourceAction = Prefixed_Name(dash, "resourceAction") |> PrefixedName
    /// <summary>
    ///   <para>dash:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>States that a subject resource has a given shape. This property can, for example, be used to capture results of SHACL validation on static data.</para>
    /// labels<para>shape</para></remarks>
    /// <seealso href="http://datashapes.org/dash#shape">http://datashapes.org/dash#shape</seealso>
    let shape = Prefixed_Name(dash, "shape") |> PrefixedName
    /// <summary>
    ///   <para>dash:suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a result with one or more suggestions on how to address or improve the underlying issue.</para>
    /// labels<para>suggestion</para></remarks>
    /// <seealso href="http://datashapes.org/dash#suggestion">http://datashapes.org/dash#suggestion</seealso>
    let suggestion = Prefixed_Name(dash, "suggestion") |> PrefixedName

    /// <summary>
    ///   <para>dash:suggestionConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional confidence between 0% and 100%. Suggestions with 100% confidence are strongly recommended. Can be used to sort recommended updates.</para>
    /// labels<para>suggestion confidence</para></remarks>
    /// <seealso href="http://datashapes.org/dash#suggestionConfidence">http://datashapes.org/dash#suggestionConfidence</seealso>
    let suggestionConfidence =
        Prefixed_Name(dash, "suggestionConfidence") |> PrefixedName

    /// <summary>
    ///   <para>dash:suggestionGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a sh:SPARQLConstraint or sh:JSConstraint with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by the constraint.</para>
    /// labels<para>suggestion generator</para></remarks>
    /// <seealso href="http://datashapes.org/dash#suggestionGenerator">http://datashapes.org/dash#suggestionGenerator</seealso>
    let suggestionGenerator = Prefixed_Name(dash, "suggestionGenerator") |> PrefixedName
    /// <summary>
    ///   <para>dash:suggestionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a suggestion with the group identifier to which it belongs. By default this is a link to the dash:SuggestionGenerator, but in principle this could be any value.</para>
    /// labels<para>suggestion</para></remarks>
    /// <seealso href="http://datashapes.org/dash#suggestionGroup">http://datashapes.org/dash#suggestionGroup</seealso>
    let suggestionGroup = Prefixed_Name(dash, "suggestionGroup") |> PrefixedName
    /// <summary>
    ///   <para>dash:toString</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Returns a literal with datatype xsd:string that has the input value as its string. If the input value is an (URI) resource then its URI will be used.</para>
    /// labels<para>to string</para></remarks>
    /// <seealso href="http://datashapes.org/dash#toString">http://datashapes.org/dash#toString</seealso>
    let toString = Prefixed_Name(dash, "toString") |> PrefixedName
    /// <summary>
    ///   <para>dash:arg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#arg">http://datashapes.org/dash#arg</seealso>
    let arg = Prefixed_Name(dash, "arg") |> PrefixedName
    /// <summary>
    ///   <para>dash:uriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Inserts a given value into a given URI template, producing a new xsd:anyURI literal.
    ///
    /// In the future this should support RFC 6570 but for now it is limited to simple {...} patterns.</para>
    /// labels<para>URI template</para></remarks>
    /// <seealso href="http://datashapes.org/dash#uriTemplate">http://datashapes.org/dash#uriTemplate</seealso>
    let uriTemplate = Prefixed_Name(dash, "uriTemplate") |> PrefixedName
    /// <summary>
    ///   <para>dash:template</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#template">http://datashapes.org/dash#template</seealso>
    let template = Prefixed_Name(dash, "template") |> PrefixedName
    /// <summary>
    ///   <para>dash:validateShapes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True to also validate the shapes itself (i.e. parameter declarations).</para>
    /// labels<para>validate shapes</para></remarks>
    /// <seealso href="http://datashapes.org/dash#validateShapes">http://datashapes.org/dash#validateShapes</seealso>
    let validateShapes = Prefixed_Name(dash, "validateShapes") |> PrefixedName
    /// <summary>
    ///   <para>dash:valueCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:SPARQLFunction</para>
    ///   <para>Computes the number of objects for a given subject/predicate combination.</para>
    /// labels<para>value count</para></remarks>
    /// <seealso href="http://datashapes.org/dash#valueCount">http://datashapes.org/dash#valueCount</seealso>
    let valueCount = Prefixed_Name(dash, "valueCount") |> PrefixedName
    /// <summary>
    ///   <para>dash:subject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#subject">http://datashapes.org/dash#subject</seealso>
    let subject = Prefixed_Name(dash, "subject") |> PrefixedName
    /// <summary>
    ///   <para>dash:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The width.</para>
    /// labels<para>width</para></remarks>
    /// <seealso href="http://datashapes.org/dash#width">http://datashapes.org/dash#width</seealso>
    let width = Prefixed_Name(dash, "width") |> PrefixedName
    /// <summary>
    ///   <para>dash:x</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The x position.</para>
    /// labels<para>x</para></remarks>
    /// <seealso href="http://datashapes.org/dash#x">http://datashapes.org/dash#x</seealso>
    let x = Prefixed_Name(dash, "x") |> PrefixedName
    /// <summary>
    ///   <para>dash:y</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The y position.</para>
    /// labels<para>y</para></remarks>
    /// <seealso href="http://datashapes.org/dash#y">http://datashapes.org/dash#y</seealso>
    let y = Prefixed_Name(dash, "y") |> PrefixedName
    /// <summary>
    ///   <para>dash:constraintOrShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#constraintOrShape">http://datashapes.org/dash#constraintOrShape</seealso>
    let constraintOrShape = Prefixed_Name(dash, "constraintOrShape") |> PrefixedName
    /// <summary>
    ///   <para>dash:SingleEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An editor for individual value nodes.</para>
    /// labels<para>Single editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SingleEditor">http://datashapes.org/dash#SingleEditor</seealso>
    let SingleEditor = Prefixed_Name(dash, "SingleEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:BlankNodeViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for blank nodes, rendering as the label of the blank node.</para>
    /// labels<para>Blank node viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#BlankNodeViewer">http://datashapes.org/dash#BlankNodeViewer</seealso>
    let BlankNodeViewer = Prefixed_Name(dash, "BlankNodeViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:nonRecursive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#nonRecursive">http://datashapes.org/dash#nonRecursive</seealso>
    let nonRecursive = Prefixed_Name(dash, "nonRecursive") |> PrefixedName
    /// <summary>
    ///   <para>dash:ModifyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An action typically showing up in a Modify section of a selected resource. May make changes to the data.</para>
    /// labels<para>Modify action</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ModifyAction">http://datashapes.org/dash#ModifyAction</seealso>
    let ModifyAction = Prefixed_Name(dash, "ModifyAction") |> PrefixedName
    /// <summary>
    ///   <para>dash:MultiEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An editor for multiple/all value nodes at once.</para>
    /// labels<para>Multi editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#MultiEditor">http://datashapes.org/dash#MultiEditor</seealso>
    let MultiEditor = Prefixed_Name(dash, "MultiEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:Viewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>The class of widgets for viewing value nodes.</para>
    /// labels<para>Viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Viewer">http://datashapes.org/dash#Viewer</seealso>
    let Viewer = Prefixed_Name(dash, "Viewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:NoSuitableEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An "editor" that simply informs the user that the values cannot be edited here, but for example through source code editing.</para>
    /// labels<para>No suitable editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#NoSuitableEditor">http://datashapes.org/dash#NoSuitableEditor</seealso>
    let NoSuitableEditor = Prefixed_Name(dash, "NoSuitableEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:NodeExpressionViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A viewer for SHACL Node Expressions.</para>
    /// labels<para>Node expression viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#NodeExpressionViewer">http://datashapes.org/dash#NodeExpressionViewer</seealso>
    let NodeExpressionViewer =
        Prefixed_Name(dash, "NodeExpressionViewer") |> PrefixedName

    /// <summary>
    ///   <para>dash:SingleViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A viewer for a single value.</para>
    /// labels<para>Single viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#SingleViewer">http://datashapes.org/dash#SingleViewer</seealso>
    let SingleViewer = Prefixed_Name(dash, "SingleViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:reifiableBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to specify the node shape that may be applied to reified statements produced by a property shape. The property shape must have a URI resource as its sh:path. The values of this property must be node shapes. User interfaces can use this information to determine which properties to present to users when reified statements are explored or edited. Use dash:None to indicate that no reification should be permitted.</para>
    /// labels<para>reifiable by</para></remarks>
    /// <seealso href="http://datashapes.org/dash#reifiableBy">http://datashapes.org/dash#reifiableBy</seealso>
    let reifiableBy = Prefixed_Name(dash, "reifiableBy") |> PrefixedName

    /// <summary>
    ///   <para>dash:isSubClassOf-subclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#isSubClassOf-subclass">http://datashapes.org/dash#isSubClassOf-subclass</seealso>
    let isSubClassOf_subclass =
        Prefixed_Name(dash, "isSubClassOf-subclass") |> PrefixedName

    /// <summary>
    ///   <para>dash:LiteralViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A simple viewer for literals, rendering the lexical form of the value.</para>
    /// labels<para>Literal viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#LiteralViewer">http://datashapes.org/dash#LiteralViewer</seealso>
    let LiteralViewer = Prefixed_Name(dash, "LiteralViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:MultiFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A multi-function is a function that can return zero or more result objects consisting of one or more result variables. While normal (SPARQL/SHACL) functions can only return a single result node, multi-functions may not only return multiple nodes but even multiple individual variables per solution.
    ///
    /// A common way of defining multi-functions is by wrapping a SPARQL SELECT query, using dash:SPARQLMultiFunction. However, some MultiFunctions (in TopBraid) may also be implemented natively.</para>
    /// labels<para>Multi-function</para></remarks>
    /// <seealso href="http://datashapes.org/dash#MultiFunction">http://datashapes.org/dash#MultiFunction</seealso>
    let MultiFunction = Prefixed_Name(dash, "MultiFunction") |> PrefixedName

    /// <summary>
    ///   <para>dash:NonRecursiveConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>Used to state that a property or path must not point back to itself.</para>
    /// labels<para>Non-recursive constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#NonRecursiveConstraintComponent">http://datashapes.org/dash#NonRecursiveConstraintComponent</seealso>
    let NonRecursiveConstraintComponent =
        Prefixed_Name(dash, "NonRecursiveConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:NonRecursiveConstraintComponent-nonRecursive</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#NonRecursiveConstraintComponent-nonRecursive">http://datashapes.org/dash#NonRecursiveConstraintComponent-nonRecursive</seealso>
    let NonRecursiveConstraintComponent_nonRecursive =
        Prefixed_Name(dash, "NonRecursiveConstraintComponent-nonRecursive") |> PrefixedName

    /// <summary>
    ///   <para>dash:shapeScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>shape script</para></remarks>
    /// <seealso href="http://datashapes.org/dash#shapeScript">http://datashapes.org/dash#shapeScript</seealso>
    let shapeScript = Prefixed_Name(dash, "shapeScript") |> PrefixedName

    /// <summary>
    ///   <para>dash:CoExistsWithConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to express a constraint on property shapes so that if the property path has any value then the given property must also have a value, and vice versa.</para>
    /// labels<para>Co-exists-with constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#CoExistsWithConstraintComponent">http://datashapes.org/dash#CoExistsWithConstraintComponent</seealso>
    let CoExistsWithConstraintComponent =
        Prefixed_Name(dash, "CoExistsWithConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:viewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Can be used to link a property shape with a viewer, to state a preferred viewing widget in user interfaces.</para>
    /// labels<para>viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#viewer">http://datashapes.org/dash#viewer</seealso>
    let viewer = Prefixed_Name(dash, "viewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:ResourceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A Service that can (and must) be applied to a given resource as focus node. Use dash:resourceService to link a class to the services that apply to its instances.</para>
    /// labels<para>Resource service</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ResourceService">http://datashapes.org/dash#ResourceService</seealso>
    let ResourceService = Prefixed_Name(dash, "ResourceService") |> PrefixedName

    /// <summary>
    ///   <para>dash:RootClassConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component defining the parameter dash:rootClass, which restricts the values to be either the root class itself or one of its subclasses. This is typically used in conjunction with properties that have rdfs:Class as their type.</para>
    /// labels<para>Root class constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#RootClassConstraintComponent">http://datashapes.org/dash#RootClassConstraintComponent</seealso>
    let RootClassConstraintComponent =
        Prefixed_Name(dash, "RootClassConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:PrimaryKeyConstraintComponent-uriStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:Parameter</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#PrimaryKeyConstraintComponent-uriStart">http://datashapes.org/dash#PrimaryKeyConstraintComponent-uriStart</seealso>
    let PrimaryKeyConstraintComponent_uriStart =
        Prefixed_Name(dash, "PrimaryKeyConstraintComponent-uriStart") |> PrefixedName

    /// <summary>
    ///   <para>dash:uriStart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#uriStart">http://datashapes.org/dash#uriStart</seealso>
    let uriStart = Prefixed_Name(dash, "uriStart") |> PrefixedName
    /// <summary>
    ///   <para>dash:QueryTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case running a given SPARQL SELECT query and comparing its results with those stored as JSON Result Set in the expected result property.</para>
    /// labels<para>Query test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#QueryTestCase">http://datashapes.org/dash#QueryTestCase</seealso>
    let QueryTestCase = Prefixed_Name(dash, "QueryTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:value</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#value">http://datashapes.org/dash#value</seealso>
    let value = Prefixed_Name(dash, "value") |> PrefixedName
    /// <summary>
    ///   <para>dash:singleLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>single line</para></remarks>
    /// <seealso href="http://datashapes.org/dash#singleLine">http://datashapes.org/dash#singleLine</seealso>
    let singleLine = Prefixed_Name(dash, "singleLine") |> PrefixedName
    /// <summary>
    ///   <para>dash:StringOrLangString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:string or rdf:langString.</para>
    /// labels<para>String or langString</para></remarks>
    /// <seealso href="http://datashapes.org/dash#StringOrLangString">http://datashapes.org/dash#StringOrLangString</seealso>
    let StringOrLangString = Prefixed_Name(dash, "StringOrLangString") |> PrefixedName
    /// <summary>
    ///   <para>dash:DateOrDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    ///   <para>An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:date or xsd:dateTime.</para>
    /// labels<para>Date or date time</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DateOrDateTime">http://datashapes.org/dash#DateOrDateTime</seealso>
    let DateOrDateTime = Prefixed_Name(dash, "DateOrDateTime") |> PrefixedName
    /// <summary>
    ///   <para>dash:PropertyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of roles that a property (shape) may take for its focus nodes.</para>
    /// labels<para>Property role</para></remarks>
    /// <seealso href="http://datashapes.org/dash#PropertyRole">http://datashapes.org/dash#PropertyRole</seealso>
    let PropertyRole = Prefixed_Name(dash, "PropertyRole") |> PrefixedName
    /// <summary>
    ///   <para>dash:ScriptConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>The class of constraints that are based on Scripts. Depending on whether dash:onAllValues is set to true, these scripts can access the following pre-assigned variables:
    ///
    /// - focusNode: the focus node of the constraint (a NamedNode)
    /// - if dash:onAllValues is not true: value: the current value node (e.g. a JavaScript string for xsd:string literals, a number for numeric literals or true or false for xsd:boolean literals. All other literals become LiteralNodes, and non-literals become instances of NamedNode)
    /// - if dash:onAllValues is true: values: an array of current value nodes, as above.
    ///
    /// If the expression returns an array then each array member will be mapped to one validation result, following the mapping rules below.
    ///
    /// For string results, a validation result will use the string as sh:resultMessage.
    /// For boolean results, a validation result will be produced if the result is false (true means no violation).
    ///
    /// For object results, a validation result will be produced using the value of the field "message" of the object as result message. If the field "value" has a value then this will become the sh:value in the violation.
    ///
    /// Unless another sh:message has been directly returned, the sh:message of the dash:ScriptConstraint will be used, similar to sh:message at SPARQL Constraints. These sh:messages can access the values {$focusNode}, {$value} etc as template variables.</para>
    /// labels<para>Script constraint</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptConstraint">http://datashapes.org/dash#ScriptConstraint</seealso>
    let ScriptConstraint = Prefixed_Name(dash, "ScriptConstraint") |> PrefixedName
    /// <summary>
    ///   <para>dash:ScriptFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Script functions can be used from SPARQL queries and will be injected into the generated prefix object (in JavaScript, for ADS scripts). The dash:js will be inserted into a generated JavaScript function and therefore needs to use the return keyword to produce results. These JS snippets can access the parameter values based on the local name of the sh:Parameter's path. For example ex:value can be accessed using value.
    ///
    /// SPARQL use note: Since these functions may be used from any data graph and any shapes graph, they must not rely on any API apart from what's available in the shapes graph that holds the rdf:type triple of the function itself. In other words, at execution time from SPARQL, the ADS shapes graph will be the home graph of the function's declaration.</para>
    /// labels<para>Script function</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptFunction">http://datashapes.org/dash#ScriptFunction</seealso>
    let ScriptFunction = Prefixed_Name(dash, "ScriptFunction") |> PrefixedName

    /// <summary>
    ///   <para>dash:DateTimePickerEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for xsd:dateTime literals, offering a calendar-like date picker and a time selector.</para>
    /// labels<para>Date time picker editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DateTimePickerEditor">http://datashapes.org/dash#DateTimePickerEditor</seealso>
    let DateTimePickerEditor =
        Prefixed_Name(dash, "DateTimePickerEditor") |> PrefixedName

    /// <summary>
    ///   <para>dash:DetailsEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>An editor for non-literal values, typically displaying a nested form where the values of the linked resource can be edited directly on the "parent" form. Implementations that do not support this (yet) could fall back to an auto-complete widget.</para>
    /// labels<para>Details editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DetailsEditor">http://datashapes.org/dash#DetailsEditor</seealso>
    let DetailsEditor = Prefixed_Name(dash, "DetailsEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:Editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>The class of widgets for editing value nodes.</para>
    /// labels<para>Editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Editor">http://datashapes.org/dash#Editor</seealso>
    let Editor = Prefixed_Name(dash, "Editor") |> PrefixedName
    /// <summary>
    ///   <para>dash:EnumSelectEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleEditor</para>
    ///   <para>A drop-down editor for enumerated values (typically based on sh:in lists).</para>
    /// labels<para>Enum select editor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#EnumSelectEditor">http://datashapes.org/dash#EnumSelectEditor</seealso>
    let EnumSelectEditor = Prefixed_Name(dash, "EnumSelectEditor") |> PrefixedName
    /// <summary>
    ///   <para>dash:ExploreAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An action typically showing up in an Explore section of a selected resource. Cannot make changes to the data.</para>
    /// labels<para>Explore action</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ExploreAction">http://datashapes.org/dash#ExploreAction</seealso>
    let ExploreAction = Prefixed_Name(dash, "ExploreAction") |> PrefixedName

    /// <summary>
    ///   <para>dash:FailureTestCaseResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a failure of a test case.</para>
    /// labels<para>Failure test case result</para></remarks>
    /// <seealso href="http://datashapes.org/dash#FailureTestCaseResult">http://datashapes.org/dash#FailureTestCaseResult</seealso>
    let FailureTestCaseResult =
        Prefixed_Name(dash, "FailureTestCaseResult") |> PrefixedName

    /// <summary>
    ///   <para>dash:FunctionTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case that verifies that a given SPARQL expression produces a given, expected result.</para>
    /// labels<para>Function test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#FunctionTestCase">http://datashapes.org/dash#FunctionTestCase</seealso>
    let FunctionTestCase = Prefixed_Name(dash, "FunctionTestCase") |> PrefixedName
    /// <summary>
    ///   <para>dash:GraphService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A service that does not apply to a specific resource (as ResourceService does) but operates on the whole graph. The focusNode variable will be the URI of the current base graph (e.g. &lt;urn:x-evn-master:geo&gt; as a NamedNode.</para>
    /// labels<para>Graph service</para></remarks>
    /// <seealso href="http://datashapes.org/dash#GraphService">http://datashapes.org/dash#GraphService</seealso>
    let GraphService = Prefixed_Name(dash, "GraphService") |> PrefixedName
    /// <summary>
    ///   <para>dash:GraphUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A suggestion consisting of added and/or deleted triples, represented as rdf:Statements via dash:addedTriple and dash:deletedTriple.</para>
    /// labels<para>Graph update</para></remarks>
    /// <seealso href="http://datashapes.org/dash#GraphUpdate">http://datashapes.org/dash#GraphUpdate</seealso>
    let GraphUpdate = Prefixed_Name(dash, "GraphUpdate") |> PrefixedName

    /// <summary>
    ///   <para>dash:GraphValidationTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A test case that performs SHACL constraint validation on the whole graph and compares the results with the expected validation results stored with the test case. By default this excludes meta-validation (i.e. the validation of the shape definitions themselves). If that's desired, set dash:validateShapes to true.</para>
    /// labels<para>Graph validation test case</para></remarks>
    /// <seealso href="http://datashapes.org/dash#GraphValidationTestCase">http://datashapes.org/dash#GraphValidationTestCase</seealso>
    let GraphValidationTestCase =
        Prefixed_Name(dash, "GraphValidationTestCase") |> PrefixedName

    /// <summary>
    ///   <para>dash:HasValueInConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to express a constraint on property shapes so that one of the values of the property path must be a member of a given list of nodes.</para>
    /// labels<para>Has value in constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HasValueInConstraintComponent">http://datashapes.org/dash#HasValueInConstraintComponent</seealso>
    let HasValueInConstraintComponent =
        Prefixed_Name(dash, "HasValueInConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:object</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#object">http://datashapes.org/dash#object</seealso>
    let object = Prefixed_Name(dash, "object") |> PrefixedName

    /// <summary>
    ///   <para>dash:HasValueWithClassConstraintComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:ConstraintComponent</para>
    ///   <para>A constraint component that can be used to express a constraint on property shapes so that one of the values of the property path must be an instance of a given class.</para>
    /// labels<para>Has value with class constraint component</para></remarks>
    /// <seealso href="http://datashapes.org/dash#HasValueWithClassConstraintComponent">http://datashapes.org/dash#HasValueWithClassConstraintComponent</seealso>
    let HasValueWithClassConstraintComponent =
        Prefixed_Name(dash, "HasValueWithClassConstraintComponent") |> PrefixedName

    /// <summary>
    ///   <para>dash:DetailsViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:SingleViewer</para>
    ///   <para>A Viewer for resources that shows the details of the value using its default view shape as a nested form-like display.</para>
    /// labels<para>Details viewer</para></remarks>
    /// <seealso href="http://datashapes.org/dash#DetailsViewer">http://datashapes.org/dash#DetailsViewer</seealso>
    let DetailsViewer = Prefixed_Name(dash, "DetailsViewer") |> PrefixedName
    /// <summary>
    ///   <para>dash:Widget</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>Base class of user interface components that can be used to display or edit value nodes.</para>
    /// labels<para>Widget</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Widget">http://datashapes.org/dash#Widget</seealso>
    let Widget = Prefixed_Name(dash, "Widget") |> PrefixedName
    /// <summary>
    ///   <para>dash:Experimental</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:APIStatus</para>
    ///   <para>Features that are marked experimental can be used by early adopters but there is no guarantee that they will reach stable state.</para>
    /// labels<para>experimental</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Experimental">http://datashapes.org/dash#Experimental</seealso>
    let Experimental = Prefixed_Name(dash, "Experimental") |> PrefixedName
    /// <summary>
    ///   <para>dash:ResourceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>An Action that can be executed for a selected resource. Such Actions show up in context menus once they have been assigned a sh:group.</para>
    /// labels<para>Resource action</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ResourceAction">http://datashapes.org/dash#ResourceAction</seealso>
    let ResourceAction = Prefixed_Name(dash, "ResourceAction") |> PrefixedName

    /// <summary>
    ///   <para>dash:ConstraintReificationShape-severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://datashapes.org/dash#ConstraintReificationShape-severity">http://datashapes.org/dash#ConstraintReificationShape-severity</seealso>
    let ConstraintReificationShape_severity =
        Prefixed_Name(dash, "ConstraintReificationShape-severity") |> PrefixedName

    /// <summary>
    ///   <para>dash:Constructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dash:ShapeClass</para>
    ///   <para>A script that is executed when a new instance of the class associated via dash:constructor is created, e.g. from a New button. Such scripts typically declare one or more parameters that are collected from the user when the script starts. The values of these parameters can be used as named variables in the script for arbitrary purposes such as setting the URI or initializing some property values of the new instance.
    ///
    /// The variable focusNode will hold the named node of the selected type, for example when a constructor is associated with a superclass but the user has pressed New for a subclass.
    ///
    /// The last expression of the script will be used as result of the constructor, so that the surrounding tool knows which resource shall be navigated to next.</para>
    /// labels<para>Constructor</para></remarks>
    /// <seealso href="http://datashapes.org/dash#Constructor">http://datashapes.org/dash#Constructor</seealso>
    let Constructor = Prefixed_Name(dash, "Constructor") |> PrefixedName

    /// <summary>
    ///   <para>dash:ScriptAPIGenerationRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyGroup</para>
    ///
    /// labels<para>Script API Generation Rules</para></remarks>
    /// <seealso href="http://datashapes.org/dash#ScriptAPIGenerationRules">http://datashapes.org/dash#ScriptAPIGenerationRules</seealso>
    let ScriptAPIGenerationRules =
        Prefixed_Name(dash, "ScriptAPIGenerationRules") |> PrefixedName

    /// <summary>
    ///   <para>dash:generateClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datashapes.org/dash#generateClass">http://datashapes.org/dash#generateClass</seealso>
    let generateClass = Prefixed_Name(dash, "generateClass") |> PrefixedName
