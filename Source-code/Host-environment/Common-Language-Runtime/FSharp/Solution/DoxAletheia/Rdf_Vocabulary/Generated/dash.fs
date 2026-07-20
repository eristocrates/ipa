namespace http.datashapes.org.dash.hash

open DoxAletheia

module dash =
    let _namespace_name = "http://datashapes.org/dash#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class of possible values for dash:apiStatus.
    /// <see href="http://datashapes.org/dash#APIStatus"></see></summary>
    let APIStatus = _prefix "APIStatus"
    /// <summary>
    /// An executable command triggered by an agent, backed by a Script implementation. Actions may get deactivated using sh:deactivated.
    /// <see href="http://datashapes.org/dash#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Indicates that a class is "abstract" and cannot be used in asserted rdf:type triples. Only non-abstract subclasses of abstract classes should be instantiated directly.
    /// <see href="http://datashapes.org/dash#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// A class that is also a node shape. This class can be used as rdf:type instead of the combination of rdfs:Class and sh:NodeShape.
    /// <see href="http://datashapes.org/dash#ShapeClass"></see></summary>
    let ShapeClass = _prefix "ShapeClass"
    /// <summary>
    /// An executable unit implemented in one or more languages such as JavaScript.
    /// <see href="http://datashapes.org/dash#Script"></see></summary>
    let Script = _prefix "Script"
    /// <summary>
    /// A group of ResourceActions, used to arrange items in menus etc. Similar to sh:PropertyGroups, they may have a sh:order and should have labels (in multiple languages if applicable).
    /// <see href="http://datashapes.org/dash#ActionGroup"></see></summary>
    let ActionGroup = _prefix "ActionGroup"
    /// <summary>
    /// A test case that evaluates a dash:Action using provided input parameters. Requires exactly one value for dash:action and will operate on the test case's graph (with imports) as both data and shapes graph.
    ///
    /// Currently only supports read-only actions, allowing the comparison of actual results with the expected results.
    /// <see href="http://datashapes.org/dash#ActionTestCase"></see></summary>
    let ActionTestCase = _prefix "ActionTestCase"
    /// <summary>
    /// A test case to verify that a (SHACL-based) feature works as expected.
    /// <see href="http://datashapes.org/dash#TestCase"></see></summary>
    let TestCase = _prefix "TestCase"
    /// <summary>
    /// A reusable instance of dash:AllObjectsTarget.
    /// <see href="http://datashapes.org/dash#AllObjects"></see></summary>
    let AllObjects = _prefix "AllObjects"
    /// <summary>
    /// A target containing all objects in the data graph as focus nodes.
    /// <see href="http://datashapes.org/dash#AllObjectsTarget"></see></summary>
    let AllObjectsTarget = _prefix "AllObjectsTarget"
    /// <summary>
    /// A reusable instance of dash:AllSubjectsTarget.
    /// <see href="http://datashapes.org/dash#AllSubjects"></see></summary>
    let AllSubjects = _prefix "AllSubjects"
    /// <summary>
    /// A target containing all subjects in the data graph as focus nodes.
    /// <see href="http://datashapes.org/dash#AllSubjectsTarget"></see></summary>
    let AllSubjectsTarget = _prefix "AllSubjectsTarget"
    /// <summary>
    /// An auto-complete field to enter the label of instances of a class. This is the fallback editor for any URI resource if no other editors are more suitable.
    /// <see href="http://datashapes.org/dash#AutoCompleteEditor"></see></summary>
    let AutoCompleteEditor = _prefix "AutoCompleteEditor"
    /// <summary>
    /// An editor for individual value nodes.
    /// <see href="http://datashapes.org/dash#SingleEditor"></see></summary>
    let SingleEditor = _prefix "SingleEditor"
    /// <summary>
    /// A Viewer for blank nodes, rendering as the label of the blank node.
    /// <see href="http://datashapes.org/dash#BlankNodeViewer"></see></summary>
    let BlankNodeViewer = _prefix "BlankNodeViewer"
    /// <summary>
    /// A viewer for a single value.
    /// <see href="http://datashapes.org/dash#SingleViewer"></see></summary>
    let SingleViewer = _prefix "SingleViewer"
    /// <summary>
    /// An editor for boolean literals, rendering as a select box with values true and false.
    ///
    /// Also displays the current value (such as "1"^^xsd:boolean), but only allows to switch to true or false.
    /// <see href="http://datashapes.org/dash#BooleanSelectEditor"></see></summary>
    let BooleanSelectEditor = _prefix "BooleanSelectEditor"
    /// <summary>
    /// Class of ADS scripts that are executed after edits to the data graph were made, but within the same edit.
    ///
    /// These scripts may access the current changes from the graphs with names dataset.addedGraphURI and dataset.deletedGraphURI to learn about which resource values have been added or deleted. For example query them using graph.withDataGraph(dataset.addedGraphURI, ...) or via SPARQL's GRAPH keyword.
    ///
    /// Change scripts may then perform further changes which would again become visible to other change scripts. They MUST NOT have other side effects though, because they may get executed in Preview mode, or the change may cause constraint violations and then be rejected. For side effects, after the change has been applied, use commit scripts (dash:CommitScript).
    ///
    /// Change scripts are executed by their relative sh:order, with a default value of 0. Use lower values to execute before other scripts.
    /// <see href="http://datashapes.org/dash#ChangeScript"></see></summary>
    let ChangeScript = _prefix "ChangeScript"
    /// <summary>
    /// A constraint component that can be used to declare that focus nodes are "closed" based on their rdf:types, meaning that focus nodes may only have values for the properties that are explicitly enumerated via sh:property/sh:path in property constraints at their rdf:types and the superclasses of those. This assumes that the type classes are also shapes.
    /// <see href="http://datashapes.org/dash#ClosedByTypesConstraintComponent"></see></summary>
    let ClosedByTypesConstraintComponent = _prefix "ClosedByTypesConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ClosedByTypesConstraintComponent-closedByTypes"></see>
    /// </summary>
    let ``ClosedByTypesConstraintComponent-closedByTypes`` =
        _prefix "ClosedByTypesConstraintComponent-closedByTypes"

    /// <summary>
    /// Can be used to specify the node shape that may be applied to reified statements produced by a property shape. The property shape must have a URI resource as its sh:path. The values of this property must be node shapes. User interfaces can use this information to determine which properties to present to users when reified statements are explored or edited. Use dash:None to indicate that no reification should be permitted.
    /// <see href="http://datashapes.org/dash#reifiableBy"></see></summary>
    let reifiableBy = _prefix "reifiableBy"
    /// <summary>
    /// Can be used to attach sh:severity and sh:messages to individual constraints using reification.
    /// <see href="http://datashapes.org/dash#ConstraintReificationShape"></see></summary>
    let ConstraintReificationShape = _prefix "ConstraintReificationShape"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#closedByTypes"></see>
    /// </summary>
    let closedByTypes = _prefix "closedByTypes"
    /// <summary>
    /// A constraint component that can be used to express a constraint on property shapes so that if the property path has any value then the given property must also have a value, and vice versa.
    /// <see href="http://datashapes.org/dash#CoExistsWithConstraintComponent"></see></summary>
    let CoExistsWithConstraintComponent = _prefix "CoExistsWithConstraintComponent"
    /// <summary>
    /// Can be set to true for those constraint components where the validation does not require to visit any other triples than the shape definitions and the direct property values of the focus node mentioned in the property constraints. Examples of this include sh:minCount and sh:hasValue.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server, assuming the client has downloaded a complete snapshot of the resource.
    ///
    /// Any component marked with dash:staticConstraint is also a dash:localConstraint.
    /// <see href="http://datashapes.org/dash#localConstraint"></see></summary>
    let localConstraint = _prefix "localConstraint"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#CoExistsWithConstraintComponent-coExistsWith"></see>
    /// </summary>
    let ``CoExistsWithConstraintComponent-coExistsWith`` =
        _prefix "CoExistsWithConstraintComponent-coExistsWith"

    /// <summary>
    /// Can be used to link a property shape with an editor, to state a preferred editing widget in user interfaces.
    /// <see href="http://datashapes.org/dash#editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// An editor for properties that are either defined as instances of rdf:Property or used as IRI values of sh:path. The component uses auto-complete to find these properties by their rdfs:labels or sh:names.
    /// <see href="http://datashapes.org/dash#PropertyAutoCompleteEditor"></see></summary>
    let PropertyAutoCompleteEditor = _prefix "PropertyAutoCompleteEditor"
    /// <summary>
    /// Can be used to link a property shape with a viewer, to state a preferred viewing widget in user interfaces.
    /// <see href="http://datashapes.org/dash#viewer"></see></summary>
    let viewer = _prefix "viewer"
    /// <summary>
    /// A viewer for properties that renders a hyperlink using the display label or sh:name, allowing users to either navigate to the rdf:Property resource or the property shape definition. Should be used in conjunction with PropertyAutoCompleteEditor.
    /// <see href="http://datashapes.org/dash#PropertyLabelViewer"></see></summary>
    let PropertyLabelViewer = _prefix "PropertyLabelViewer"
    /// <summary>
    /// Specifies a property that must have a value whenever the property path has a value, and must have no value whenever the property path has no value.
    /// <see href="http://datashapes.org/dash#coExistsWith"></see></summary>
    let coExistsWith = _prefix "coExistsWith"
    /// <summary>
    /// Class of ADS scripts that are executed after edits to the data graph were made and have been committed.
    ///
    /// These scripts may access the changes that have just happened from the graphs with names dataset.addedGraphURI and dataset.deletedGraphURI to learn about which resource values have been added or deleted. For example query them using graph.withDataGraph(dataset.addedGraphURI, ...) or via SPARQL's GRAPH keyword.
    ///
    /// Commit scripts may then perform side effects such as updating other graphs or sending out notifications to external systems. For edits that should be made within a finishing change, use change scripts (dash:ChangeScript).
    ///
    /// Commit scripts are executed by their relative sh:order, with a default value of 0. Use lower values to execute before other scripts.
    /// <see href="http://datashapes.org/dash#CommitScript"></see></summary>
    let CommitScript = _prefix "CommitScript"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ConstraintReificationShape-message"></see>
    /// </summary>
    let ``ConstraintReificationShape-message`` =
        _prefix "ConstraintReificationShape-message"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ConstraintReificationShape-severity"></see>
    /// </summary>
    let ``ConstraintReificationShape-severity`` =
        _prefix "ConstraintReificationShape-severity"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#singleLine"></see>
    /// </summary>
    let singleLine = _prefix "singleLine"
    /// <summary>
    /// An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:string or rdf:langString.
    /// <see href="http://datashapes.org/dash#StringOrLangString"></see></summary>
    let StringOrLangString = _prefix "StringOrLangString"
    /// <summary>
    /// A script that is executed when a new instance of the class associated via dash:constructor is created, e.g. from a New button. Such scripts typically declare one or more parameters that are collected from the user when the script starts. The values of these parameters can be used as named variables in the script for arbitrary purposes such as setting the URI or initializing some property values of the new instance.
    ///
    /// The variable focusNode will hold the named node of the selected type, for example when a constructor is associated with a superclass but the user has pressed New for a subclass.
    ///
    /// The last expression of the script will be used as result of the constructor, so that the surrounding tool knows which resource shall be navigated to next.
    /// <see href="http://datashapes.org/dash#Constructor"></see></summary>
    let Constructor = _prefix "Constructor"
    /// <summary>
    /// An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:date or xsd:dateTime.
    /// <see href="http://datashapes.org/dash#DateOrDateTime"></see></summary>
    let DateOrDateTime = _prefix "DateOrDateTime"
    /// <summary>
    /// An editor for xsd:date literals, offering a calendar-like date picker.
    /// <see href="http://datashapes.org/dash#DatePickerEditor"></see></summary>
    let DatePickerEditor = _prefix "DatePickerEditor"
    /// <summary>
    /// An editor for xsd:dateTime literals, offering a calendar-like date picker and a time selector.
    /// <see href="http://datashapes.org/dash#DateTimePickerEditor"></see></summary>
    let DateTimePickerEditor = _prefix "DateTimePickerEditor"
    /// <summary>
    /// Depiction properties provide images representing the focus nodes. Typical examples may be a photo of an animal or the map of a country.
    /// <see href="http://datashapes.org/dash#DepictionRole"></see></summary>
    let DepictionRole = _prefix "DepictionRole"
    /// <summary>
    /// The class of roles that a property (shape) may take for its focus nodes.
    /// <see href="http://datashapes.org/dash#PropertyRole"></see></summary>
    let PropertyRole = _prefix "PropertyRole"
    /// <summary>
    /// Features that have been marked deprecated will remain in the API but should no longer be used by new code and may get deleted in the foreseeable future (e.g., with the next major release).
    /// <see href="http://datashapes.org/dash#Deprecated"></see></summary>
    let Deprecated = _prefix "Deprecated"
    /// <summary>
    /// Description properties should produce text literals that may be used as an introduction/summary of what a focus node does.
    /// <see href="http://datashapes.org/dash#DescriptionRole"></see></summary>
    let DescriptionRole = _prefix "DescriptionRole"
    /// <summary>
    /// An editor for non-literal values, typically displaying a nested form where the values of the linked resource can be edited directly on the "parent" form. Implementations that do not support this (yet) could fall back to an auto-complete widget.
    /// <see href="http://datashapes.org/dash#DetailsEditor"></see></summary>
    let DetailsEditor = _prefix "DetailsEditor"
    /// <summary>
    /// A Viewer for resources that shows the details of the value using its default view shape as a nested form-like display.
    /// <see href="http://datashapes.org/dash#DetailsViewer"></see></summary>
    let DetailsViewer = _prefix "DetailsViewer"
    /// <summary>
    /// The class of widgets for editing value nodes.
    /// <see href="http://datashapes.org/dash#Editor"></see></summary>
    let Editor = _prefix "Editor"
    /// <summary>
    /// Base class of user interface components that can be used to display or edit value nodes.
    /// <see href="http://datashapes.org/dash#Widget"></see></summary>
    let Widget = _prefix "Widget"
    /// <summary>
    /// A drop-down editor for enumerated values (typically based on sh:in lists).
    /// <see href="http://datashapes.org/dash#EnumSelectEditor"></see></summary>
    let EnumSelectEditor = _prefix "EnumSelectEditor"
    /// <summary>
    /// Features that are marked experimental can be used by early adopters but there is no guarantee that they will reach stable state.
    /// <see href="http://datashapes.org/dash#Experimental"></see></summary>
    let Experimental = _prefix "Experimental"
    /// <summary>
    /// An action typically showing up in an Explore section of a selected resource. Cannot make changes to the data.
    /// <see href="http://datashapes.org/dash#ExploreAction"></see></summary>
    let ExploreAction = _prefix "ExploreAction"
    /// <summary>
    /// An Action that can be executed for a selected resource. Such Actions show up in context menus once they have been assigned a sh:group.
    /// <see href="http://datashapes.org/dash#ResourceAction"></see></summary>
    let ResourceAction = _prefix "ResourceAction"
    /// <summary>
    /// A result representing a validation failure such as an unsupported recursion.
    /// <see href="http://datashapes.org/dash#FailureResult"></see></summary>
    let FailureResult = _prefix "FailureResult"
    /// <summary>
    /// Represents a failure of a test case.
    /// <see href="http://datashapes.org/dash#FailureTestCaseResult"></see></summary>
    let FailureTestCaseResult = _prefix "FailureTestCaseResult"
    /// <summary>
    /// Base class for results produced by running test cases.
    /// <see href="http://datashapes.org/dash#TestCaseResult"></see></summary>
    let TestCaseResult = _prefix "TestCaseResult"
    /// <summary>
    /// A test case that verifies that a given SPARQL expression produces a given, expected result.
    /// <see href="http://datashapes.org/dash#FunctionTestCase"></see></summary>
    let FunctionTestCase = _prefix "FunctionTestCase"
    /// <summary>
    /// A service that does not apply to a specific resource (as ResourceService does) but operates on the whole graph. The focusNode variable will be the URI of the current base graph (e.g. &lt;urn:x-evn-master:geo&gt; as a NamedNode.
    /// <see href="http://datashapes.org/dash#GraphService"></see></summary>
    let GraphService = _prefix "GraphService"
    /// <summary>
    /// A script that gets exposed as a web service, e.g. /tbl/service/ex/MyService
    /// <see href="http://datashapes.org/dash#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A test case that can be used to verify that an RDF file could be loaded (from a file) and that the resulting RDF graph is equivalent to a given TTL file.
    /// <see href="http://datashapes.org/dash#GraphStoreTestCase"></see></summary>
    let GraphStoreTestCase = _prefix "GraphStoreTestCase"
    /// <summary>
    /// A suggestion consisting of added and/or deleted triples, represented as rdf:Statements via dash:addedTriple and dash:deletedTriple.
    /// <see href="http://datashapes.org/dash#GraphUpdate"></see></summary>
    let GraphUpdate = _prefix "GraphUpdate"
    /// <summary>
    /// Base class of suggestions that modify a graph to "fix" the source of a validation result.
    /// <see href="http://datashapes.org/dash#Suggestion"></see></summary>
    let Suggestion = _prefix "Suggestion"
    /// <summary>
    /// A test case that performs SHACL constraint validation on the whole graph and compares the results with the expected validation results stored with the test case. By default this excludes meta-validation (i.e. the validation of the shape definitions themselves). If that's desired, set dash:validateShapes to true.
    /// <see href="http://datashapes.org/dash#GraphValidationTestCase"></see></summary>
    let GraphValidationTestCase = _prefix "GraphValidationTestCase"
    /// <summary>
    /// Abstract superclass for test cases concerning SHACL constraint validation. Future versions may add new kinds of validatin test cases, e.g. to validate a single resource only.
    /// <see href="http://datashapes.org/dash#ValidationTestCase"></see></summary>
    let ValidationTestCase = _prefix "ValidationTestCase"
    /// <summary>
    /// An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either rdf:HTML, xsd:string or rdf:langString (in that order of preference).
    /// <see href="http://datashapes.org/dash#HTMLOrStringOrLangString"></see></summary>
    let HTMLOrStringOrLangString = _prefix "HTMLOrStringOrLangString"
    /// <summary>
    /// A Viewer for HTML encoded text from rdf:HTML literals, rendering as parsed HTML DOM elements. Also displays the language if the HTML has a lang attribute on its root DOM element.
    /// <see href="http://datashapes.org/dash#HTMLViewer"></see></summary>
    let HTMLViewer = _prefix "HTMLViewer"
    /// <summary>
    /// A constraint component that can be used to express a constraint on property shapes so that one of the values of the property path must be a member of a given list of nodes.
    /// <see href="http://datashapes.org/dash#HasValueInConstraintComponent"></see></summary>
    let HasValueInConstraintComponent = _prefix "HasValueInConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#HasValueInConstraintComponent-hasValueIn"></see>
    /// </summary>
    let ``HasValueInConstraintComponent-hasValueIn`` =
        _prefix "HasValueInConstraintComponent-hasValueIn"

    /// <summary>
    /// Defines constraints on what it means for a node to be a well-formed RDF list.
    ///
    /// The focus node must either be rdf:nil or not recursive. Furthermore, this shape uses dash:ListNodeShape as a "helper" to walk through all members of the whole list (including itself).
    /// <see href="http://datashapes.org/dash#ListShape"></see></summary>
    let ListShape = _prefix "ListShape"
    /// <summary>
    /// Specifies a constraint that at least one of the value nodes must be a member of the given list.
    /// <see href="http://datashapes.org/dash#hasValueIn"></see></summary>
    let hasValueIn = _prefix "hasValueIn"
    /// <summary>
    /// A target type for all subjects where a given predicate has a certain object value.
    /// <see href="http://datashapes.org/dash#HasValueTarget"></see></summary>
    let HasValueTarget = _prefix "HasValueTarget"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#predicate"></see>
    /// </summary>
    let predicate = _prefix "predicate"

    /// <summary>
    /// A constraint component that can be used to express a constraint on property shapes so that one of the values of the property path must be an instance of a given class.
    /// <see href="http://datashapes.org/dash#HasValueWithClassConstraintComponent"></see></summary>
    let HasValueWithClassConstraintComponent =
        _prefix "HasValueWithClassConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#HasValueWithClassConstraintComponent-hasValueWithClass"></see>
    /// </summary>
    let ``HasValueWithClassConstraintComponent-hasValueWithClass`` =
        _prefix "HasValueWithClassConstraintComponent-hasValueWithClass"

    /// <summary>
    /// Specifies a constraint that at least one of the value nodes must be an instance of a given class.
    /// <see href="http://datashapes.org/dash#hasValueWithClass"></see></summary>
    let hasValueWithClass = _prefix "hasValueWithClass"
    /// <summary>
    /// A Viewer for literals, rendering as a hyperlink to a URL.
    ///
    /// For literals it assumes the lexical form is the URL.
    ///
    /// This is often used as default viewer for xsd:anyURI literals. Unsupported for blank nodes.
    /// <see href="http://datashapes.org/dash#HyperlinkViewer"></see></summary>
    let HyperlinkViewer = _prefix "HyperlinkViewer"
    /// <summary>
    /// ID properties are short strings or other literals that identify the focus node among siblings. Examples may include social security numbers.
    /// <see href="http://datashapes.org/dash#IDRole"></see></summary>
    let IDRole = _prefix "IDRole"
    /// <summary>
    /// Icon properties produce images that are typically small and almost square-shaped, and that may be displayed in the upper left corner of a focus node's display. Values should be xsd:string or xsd:anyURI literals or IRI nodes pointing at URLs. Those URLs should ideally be vector graphics such as .svg files.
    ///
    /// Instances of the same class often have the same icon, and this icon may be computed using a sh:values rule or as sh:defaultValue.
    ///
    /// If the value is a relative URL then those should be resolved against the server that delivered the surrounding page.
    /// <see href="http://datashapes.org/dash#IconRole"></see></summary>
    let IconRole = _prefix "IconRole"
    /// <summary>
    /// A Viewer for URI values that are recognized as images by a browser, rendering as an image.
    /// <see href="http://datashapes.org/dash#ImageViewer"></see></summary>
    let ImageViewer = _prefix "ImageViewer"
    /// <summary>
    /// The code associated with instances of this class will get injected into the generated APIs, as global code snippets. Typically used to declare libraries of utility functions or constants that are (compared to shape scripts) not necessarily associated with specific classes or shapes.
    ///
    /// Note that the JavaScript code stored in dash:js cannot use the export keyword because the code must also work in external scripts (such as on Node.js). Instead, you need to enumerate the exported symbols via dash:exports.
    /// <see href="http://datashapes.org/dash#IncludedScript"></see></summary>
    let IncludedScript = _prefix "IncludedScript"
    /// <summary>
    /// A constraint component that can be used to mark property shapes to be indexed, meaning that each of its value nodes must carry a dash:index from 0 to N.
    /// <see href="http://datashapes.org/dash#IndexedConstraintComponent"></see></summary>
    let IndexedConstraintComponent = _prefix "IndexedConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#IndexedConstraintComponent-indexed"></see>
    /// </summary>
    let ``IndexedConstraintComponent-indexed`` =
        _prefix "IndexedConstraintComponent-indexed"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#indexed"></see>
    /// </summary>
    let indexed = _prefix "indexed"
    /// <summary>
    /// A test case to verify whether an inferencing engine is producing identical results to those stored as expected results.
    /// <see href="http://datashapes.org/dash#InferencingTestCase"></see></summary>
    let InferencingTestCase = _prefix "InferencingTestCase"
    /// <summary>
    /// A multi-viewer that renders all values horizontally, in a more compact form that just a single value per row.
    /// <see href="http://datashapes.org/dash#InlineViewer"></see></summary>
    let InlineViewer = _prefix "InlineViewer"
    /// <summary>
    /// A viewer for multiple/all values at once.
    /// <see href="http://datashapes.org/dash#MultiViewer"></see></summary>
    let MultiViewer = _prefix "MultiViewer"
    /// <summary>
    /// A drop-down editor for all instances of the target class (based on sh:class of the property).
    /// <see href="http://datashapes.org/dash#InstancesSelectEditor"></see></summary>
    let InstancesSelectEditor = _prefix "InstancesSelectEditor"
    /// <summary>
    /// A tabular viewer for rdf:JSON literals with a lexical form in the following format:
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
    /// You may also produce the JSON literal programmatically in JavaScript, or assert the triples by other means.
    /// <see href="http://datashapes.org/dash#JSONTableViewer"></see></summary>
    let JSONTableViewer = _prefix "JSONTableViewer"
    /// <summary>
    /// The Key info role may be assigned to properties that are likely of special interest to a reader, so that they should appear whenever a summary of a focus node is shown.
    /// <see href="http://datashapes.org/dash#KeyInfoRole"></see></summary>
    let KeyInfoRole = _prefix "KeyInfoRole"
    /// <summary>
    /// Properties with this role produce strings that may serve as display label for the focus nodes. Labels should be either plain string literals or strings with a language tag. The values should also be single-line.
    /// <see href="http://datashapes.org/dash#LabelRole"></see></summary>
    let LabelRole = _prefix "LabelRole"
    /// <summary>
    /// A Viewer for URI resources, rendering as a hyperlink to that URI based on the display label of the resource. Also includes other ways of interacting with the URI such as opening a nested summary display.
    /// <see href="http://datashapes.org/dash#LabelViewer"></see></summary>
    let LabelViewer = _prefix "LabelViewer"
    /// <summary>
    /// A Viewer for literals with a language tag, rendering as the text plus a language indicator.
    /// <see href="http://datashapes.org/dash#LangStringViewer"></see></summary>
    let LangStringViewer = _prefix "LangStringViewer"
    /// <summary>
    /// Defines constraints on what it means for a node to be a node within a well-formed RDF list. Note that this does not check whether the rdf:rest items are also well-formed lists as this would lead to unsupported recursion.
    /// <see href="http://datashapes.org/dash#ListNodeShape"></see></summary>
    let ListNodeShape = _prefix "ListNodeShape"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#nonRecursive"></see>
    /// </summary>
    let nonRecursive = _prefix "nonRecursive"
    /// <summary>
    /// A simple viewer for literals, rendering the lexical form of the value.
    /// <see href="http://datashapes.org/dash#LiteralViewer"></see></summary>
    let LiteralViewer = _prefix "LiteralViewer"
    /// <summary>
    /// An action typically showing up in a Modify section of a selected resource. May make changes to the data.
    /// <see href="http://datashapes.org/dash#ModifyAction"></see></summary>
    let ModifyAction = _prefix "ModifyAction"
    /// <summary>
    /// An editor for multiple/all value nodes at once.
    /// <see href="http://datashapes.org/dash#MultiEditor"></see></summary>
    let MultiEditor = _prefix "MultiEditor"
    /// <summary>
    /// A multi-function is a function that can return zero or more result objects consisting of one or more result variables. While normal (SPARQL/SHACL) functions can only return a single result node, multi-functions may not only return multiple nodes but even multiple individual variables per solution.
    ///
    /// A common way of defining multi-functions is by wrapping a SPARQL SELECT query, using dash:SPARQLMultiFunction. However, some MultiFunctions (in TopBraid) may also be implemented natively.
    /// <see href="http://datashapes.org/dash#MultiFunction"></see></summary>
    let MultiFunction = _prefix "MultiFunction"
    /// <summary>
    /// The class of widgets for viewing value nodes.
    /// <see href="http://datashapes.org/dash#Viewer"></see></summary>
    let Viewer = _prefix "Viewer"
    /// <summary>
    /// An "editor" that simply informs the user that the values cannot be edited here, but for example through source code editing.
    /// <see href="http://datashapes.org/dash#NoSuitableEditor"></see></summary>
    let NoSuitableEditor = _prefix "NoSuitableEditor"
    /// <summary>
    /// A viewer for SHACL Node Expressions.
    /// <see href="http://datashapes.org/dash#NodeExpressionViewer"></see></summary>
    let NodeExpressionViewer = _prefix "NodeExpressionViewer"
    /// <summary>
    /// Used to state that a property or path must not point back to itself.
    /// <see href="http://datashapes.org/dash#NonRecursiveConstraintComponent"></see></summary>
    let NonRecursiveConstraintComponent = _prefix "NonRecursiveConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#NonRecursiveConstraintComponent-nonRecursive"></see>
    /// </summary>
    let ``NonRecursiveConstraintComponent-nonRecursive`` =
        _prefix "NonRecursiveConstraintComponent-nonRecursive"

    /// <summary>
    /// A Shape that is no node can conform to.
    /// <see href="http://datashapes.org/dash#None"></see></summary>
    let None = _prefix "None"
    /// <summary>
    /// A constraint component that can be used to verify that all value nodes conform to the given Parameter.
    /// <see href="http://datashapes.org/dash#ParameterConstraintComponent"></see></summary>
    let ParameterConstraintComponent = _prefix "ParameterConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ParameterConstraintComponent-parameter"></see>
    /// </summary>
    let ``ParameterConstraintComponent-parameter`` =
        _prefix "ParameterConstraintComponent-parameter"

    /// <summary>
    /// Enforces a constraint that the given property (sh:path) serves as primary key for all resources in the target of the shape. If a property has been declared to be the primary key then each resource must have exactly one value for that property. Furthermore, the URIs of those resources must start with a given string (dash:uriStart), followed by the URL-encoded primary key value. For example if dash:uriStart is "http://example.org/country-" and the primary key for an instance is "de" then the URI must be "http://example.org/country-de". Finally, as a result of the URI policy, there can not be any other resource with the same value under the same primary key policy.
    /// <see href="http://datashapes.org/dash#PrimaryKeyConstraintComponent"></see></summary>
    let PrimaryKeyConstraintComponent = _prefix "PrimaryKeyConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#PrimaryKeyConstraintComponent-uriStart"></see>
    /// </summary>
    let ``PrimaryKeyConstraintComponent-uriStart`` =
        _prefix "PrimaryKeyConstraintComponent-uriStart"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#uriStart"></see>
    /// </summary>
    let uriStart = _prefix "uriStart"
    /// <summary>
    /// A test case running a given SPARQL SELECT query and comparing its results with those stored as JSON Result Set in the expected result property.
    /// <see href="http://datashapes.org/dash#QueryTestCase"></see></summary>
    let QueryTestCase = _prefix "QueryTestCase"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#ReifiableByConstraintComponent"></see>
    /// </summary>
    let ReifiableByConstraintComponent = _prefix "ReifiableByConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ReifiableByConstraintComponent-reifiableBy"></see>
    /// </summary>
    let ``ReifiableByConstraintComponent-reifiableBy`` =
        _prefix "ReifiableByConstraintComponent-reifiableBy"

    /// <summary>
    /// A Service that can (and must) be applied to a given resource as focus node. Use dash:resourceService to link a class to the services that apply to its instances.
    /// <see href="http://datashapes.org/dash#ResourceService"></see></summary>
    let ResourceService = _prefix "ResourceService"
    /// <summary>
    /// A rich text editor to enter the lexical value of a literal and a drop down to select language. The selected language is stored in the HTML lang attribute of the root node in the HTML DOM tree.
    /// <see href="http://datashapes.org/dash#RichTextEditor"></see></summary>
    let RichTextEditor = _prefix "RichTextEditor"
    /// <summary>
    /// A constraint component defining the parameter dash:rootClass, which restricts the values to be either the root class itself or one of its subclasses. This is typically used in conjunction with properties that have rdfs:Class as their type.
    /// <see href="http://datashapes.org/dash#RootClassConstraintComponent"></see></summary>
    let RootClassConstraintComponent = _prefix "RootClassConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#RootClassConstraintComponent-rootClass"></see>
    /// </summary>
    let ``RootClassConstraintComponent-rootClass`` =
        _prefix "RootClassConstraintComponent-rootClass"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#hasRootClass"></see>
    /// </summary>
    let hasRootClass = _prefix "hasRootClass"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#rootClass"></see>
    /// </summary>
    let rootClass = _prefix "rootClass"
    /// <summary>
    /// Encapsulates one or more SPARQL CONSTRUCT queries that can be parameterized. Parameters will become pre-bound variables in the queries.
    /// <see href="http://datashapes.org/dash#SPARQLConstructTemplate"></see></summary>
    let SPARQLConstructTemplate = _prefix "SPARQLConstructTemplate"
    /// <summary>
    /// A multi-function based on a SPARQL SELECT query. The query gets executed with the arguments pre-bound to the variables declared as parameters. The results of the multi-function are all result bindings from the SPARQL result set.
    /// <see href="http://datashapes.org/dash#SPARQLMultiFunction"></see></summary>
    let SPARQLMultiFunction = _prefix "SPARQLMultiFunction"
    /// <summary>
    /// Encapsulates a SPARQL SELECT query that can be parameterized. Parameters will become pre-bound variables in the query.
    /// <see href="http://datashapes.org/dash#SPARQLSelectTemplate"></see></summary>
    let SPARQLSelectTemplate = _prefix "SPARQLSelectTemplate"
    /// <summary>
    /// A SuggestionGenerator based on a SPARQL UPDATE query (sh:update), producing an instance of dash:GraphUpdate. The INSERTs become dash:addedTriple and the DELETEs become dash:deletedTriple. The WHERE clause operates on the data graph with the pre-bound variables $focusNode, $predicate and $value, as well as the other pre-bound variables for the parameters of the constraint.
    ///
    /// In many cases, there may be multiple possible suggestions to fix a problem. For example, with sh:maxLength there are many ways to slice a string. In those cases, the system will first iterate through the result variables from a SELECT query (sh:select) and apply these results as pre-bound variables into the UPDATE query.
    /// <see href="http://datashapes.org/dash#SPARQLUpdateSuggestionGenerator"></see></summary>
    let SPARQLUpdateSuggestionGenerator = _prefix "SPARQLUpdateSuggestionGenerator"
    /// <summary>
    /// Base class of objects that can generate suggestions (added or deleted triples) for a validation result of a given constraint component.
    /// <see href="http://datashapes.org/dash#SuggestionGenerator"></see></summary>
    let SuggestionGenerator = _prefix "SuggestionGenerator"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptAPIGenerationRules"></see>
    /// </summary>
    let ScriptAPIGenerationRules = _prefix "ScriptAPIGenerationRules"
    /// <summary>
    /// Defines the properties that instruct the ADS Script API generator about what prefixes, constants and classes to generate.
    /// <see href="http://datashapes.org/dash#ScriptAPIShape"></see></summary>
    let ScriptAPIShape = _prefix "ScriptAPIShape"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptAPIShape-generateClass"></see>
    /// </summary>
    let ``ScriptAPIShape-generateClass`` = _prefix "ScriptAPIShape-generateClass"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptAPIShape-generatePrefixClasses"></see>
    /// </summary>
    let ``ScriptAPIShape-generatePrefixClasses`` =
        _prefix "ScriptAPIShape-generatePrefixClasses"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptAPIShape-generatePrefixConstants"></see>
    /// </summary>
    let ``ScriptAPIShape-generatePrefixConstants`` =
        _prefix "ScriptAPIShape-generatePrefixConstants"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#generateClass"></see>
    /// </summary>
    let generateClass = _prefix "generateClass"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#generatePrefixClasses"></see>
    /// </summary>
    let generatePrefixClasses = _prefix "generatePrefixClasses"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#generatePrefixConstants"></see>
    /// </summary>
    let generatePrefixConstants = _prefix "generatePrefixConstants"
    /// <summary>
    /// The class of constraints that are based on Scripts. Depending on whether dash:onAllValues is set to true, these scripts can access the following pre-assigned variables:
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
    /// Unless another sh:message has been directly returned, the sh:message of the dash:ScriptConstraint will be used, similar to sh:message at SPARQL Constraints. These sh:messages can access the values {$focusNode}, {$value} etc as template variables.
    /// <see href="http://datashapes.org/dash#ScriptConstraint"></see></summary>
    let ScriptConstraint = _prefix "ScriptConstraint"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptConstraintComponent"></see>
    /// </summary>
    let ScriptConstraintComponent = _prefix "ScriptConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#ScriptConstraintComponent-scriptConstraint"></see>
    /// </summary>
    let ``ScriptConstraintComponent-scriptConstraint`` =
        _prefix "ScriptConstraintComponent-scriptConstraint"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#scriptConstraint"></see>
    /// </summary>
    let scriptConstraint = _prefix "scriptConstraint"
    /// <summary>
    /// Script functions can be used from SPARQL queries and will be injected into the generated prefix object (in JavaScript, for ADS scripts). The dash:js will be inserted into a generated JavaScript function and therefore needs to use the return keyword to produce results. These JS snippets can access the parameter values based on the local name of the sh:Parameter's path. For example ex:value can be accessed using value.
    ///
    /// SPARQL use note: Since these functions may be used from any data graph and any shapes graph, they must not rely on any API apart from what's available in the shapes graph that holds the rdf:type triple of the function itself. In other words, at execution time from SPARQL, the ADS shapes graph will be the home graph of the function's declaration.
    /// <see href="http://datashapes.org/dash#ScriptFunction"></see></summary>
    let ScriptFunction = _prefix "ScriptFunction"
    /// <summary>
    /// A Suggestion Generator that is backed by an Active Data Shapes script. The script needs to return a JSON object or an array of JSON objects if it shall generate multiple suggestions. It may also return null to indicate that nothing was suggested. Note that the whole script is evaluated as a (JavaScript) expression, and those will use the last value as result. So simply putting an object at the end of your script should do. Alternatively, define the bulk of the operation as a function and simply call that function in the script.
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
    /// })
    /// <see href="http://datashapes.org/dash#ScriptSuggestionGenerator"></see></summary>
    let ScriptSuggestionGenerator = _prefix "ScriptSuggestionGenerator"
    /// <summary>
    /// A test case that evaluates a script. Requires exactly one value for dash:js and will operate on the test case's graph (with imports) as both data and shapes graph.
    ///
    /// Supports read-only scripts only at this stage.
    /// <see href="http://datashapes.org/dash#ScriptTestCase"></see></summary>
    let ScriptTestCase = _prefix "ScriptTestCase"
    /// <summary>
    /// A SHACL validator based on an Active Data Shapes script.
    ///
    /// See the comment at dash:ScriptConstraint for the basic evaluation approach. Note that in addition to focusNode and value/values, the script can access pre-bound variables for each declared argument of the constraint component.
    /// <see href="http://datashapes.org/dash#ScriptValidator"></see></summary>
    let ScriptValidator = _prefix "ScriptValidator"
    /// <summary>
    /// Properties marked as hidden do not appear in user interfaces, yet remain part of the shape for other purposes such as validation and scripting or GraphQL schema generation.
    /// <see href="http://datashapes.org/dash#hidden"></see></summary>
    let hidden = _prefix "hidden"
    /// <summary>
    /// A shape script contains extra code that gets injected into the API for the associated node shape. In particular you can use this to define additional functions that operate on the current focus node (the this variable in JavaScript).
    /// <see href="http://datashapes.org/dash#ShapeScript"></see></summary>
    let ShapeScript = _prefix "ShapeScript"
    /// <summary>
    /// A constraint component that can be used to declare that all values that are literals must have a lexical form that contains no line breaks ('\n' or '\r').
    ///
    /// User interfaces may use the dash:singleLine flag to prefer a text field over a (multi-line) text area.
    /// <see href="http://datashapes.org/dash#SingleLineConstraintComponent"></see></summary>
    let SingleLineConstraintComponent = _prefix "SingleLineConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#SingleLineConstraintComponent-singleLine"></see>
    /// </summary>
    let ``SingleLineConstraintComponent-singleLine`` =
        _prefix "SingleLineConstraintComponent-singleLine"

    /// <summary>
    /// Features that have been marked stable are deemed of good quality and can be used until marked deprecated.
    /// <see href="http://datashapes.org/dash#Stable"></see></summary>
    let Stable = _prefix "Stable"
    /// <summary>
    /// A constraint component that can be used to verify that every value node is an IRI and the IRI starts with a given string value.
    /// <see href="http://datashapes.org/dash#StemConstraintComponent"></see></summary>
    let StemConstraintComponent = _prefix "StemConstraintComponent"
    /// <summary>
    /// Can be set to true for those constraint components where the validation does not require to visit any other triples than the parameters. Examples of this include sh:datatype or sh:nodeKind, where no further triples need to be queried to determine the result.
    ///
    /// Constraint components that are marked as such can be optimized by engines, e.g. they can be evaluated client-side at form submission time, without having to make a round-trip to a server.
    /// <see href="http://datashapes.org/dash#staticConstraint"></see></summary>
    let staticConstraint = _prefix "staticConstraint"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#StemConstraintComponent-stem"></see>
    /// </summary>
    let ``StemConstraintComponent-stem`` = _prefix "StemConstraintComponent-stem"
    /// <summary>
    /// Checks whether a given node is an IRI starting with a given stem.
    /// <see href="http://datashapes.org/dash#hasStem"></see></summary>
    let hasStem = _prefix "hasStem"
    /// <summary>
    /// Specifies a string value that the IRI of the value nodes must start with.
    /// <see href="http://datashapes.org/dash#stem"></see></summary>
    let stem = _prefix "stem"
    /// <summary>
    /// An rdf:List that can be used in property constraints as value for sh:or to indicate that all values of a property must be either xsd:string, rdf:langString or rdf:HTML (in that order of preference).
    /// <see href="http://datashapes.org/dash#StringOrLangStringOrHTML"></see></summary>
    let StringOrLangStringOrHTML = _prefix "StringOrLangStringOrHTML"
    /// <summary>
    /// An editor for properties that declare a dash:rootClass. The editor allows selecting either the class itself or one of its subclasses.
    /// <see href="http://datashapes.org/dash#SubClassEditor"></see></summary>
    let SubClassEditor = _prefix "SubClassEditor"
    /// <summary>
    /// A constraint component that can be used to state that the set of value nodes must be a subset of the value of a given property.
    /// <see href="http://datashapes.org/dash#SubSetOfConstraintComponent"></see></summary>
    let SubSetOfConstraintComponent = _prefix "SubSetOfConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#SubSetOfConstraintComponent-subSetOf"></see>
    /// </summary>
    let ``SubSetOfConstraintComponent-subSetOf`` =
        _prefix "SubSetOfConstraintComponent-subSetOf"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#subSetOf"></see>
    /// </summary>
    let subSetOf = _prefix "subSetOf"
    /// <summary>
    /// A result representing a successfully validated constraint.
    /// <see href="http://datashapes.org/dash#SuccessResult"></see></summary>
    let SuccessResult = _prefix "SuccessResult"
    /// <summary>
    /// Represents a successful run of a test case.
    /// <see href="http://datashapes.org/dash#SuccessTestCaseResult"></see></summary>
    let SuccessTestCaseResult = _prefix "SuccessTestCaseResult"
    /// <summary>
    /// Class of results that have been produced as suggestions, not through SHACL validation. How the actual results are produced is up to implementers. Each instance of this class should have values for sh:focusNode, sh:resultMessage, sh:resultSeverity (suggested default: sh:Info), and dash:suggestion to point at one or more suggestions.
    /// <see href="http://datashapes.org/dash#SuggestionResult"></see></summary>
    let SuggestionResult = _prefix "SuggestionResult"
    /// <summary>
    /// A contraint component for property shapes to validate that a property is symmetric. For symmetric properties, if A relates to B then B must relate to A.
    /// <see href="http://datashapes.org/dash#SymmetricConstraintComponent"></see></summary>
    let SymmetricConstraintComponent = _prefix "SymmetricConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#SymmetricConstraintComponent-symmetric"></see>
    /// </summary>
    let ``SymmetricConstraintComponent-symmetric`` =
        _prefix "SymmetricConstraintComponent-symmetric"

    /// <summary>
    /// True to declare that the associated property path is symmetric.
    /// <see href="http://datashapes.org/dash#symmetric"></see></summary>
    let symmetric = _prefix "symmetric"
    /// <summary>
    /// Abstract base class for test environments, holding information on how to set up a test case.
    /// <see href="http://datashapes.org/dash#TestEnvironment"></see></summary>
    let TestEnvironment = _prefix "TestEnvironment"
    /// <summary>
    /// A multi-line text area to enter the value of a literal.
    /// <see href="http://datashapes.org/dash#TextAreaEditor"></see></summary>
    let TextAreaEditor = _prefix "TextAreaEditor"
    /// <summary>
    /// A multi-line text area to enter the value of a literal and a drop down to select a language.
    /// <see href="http://datashapes.org/dash#TextAreaWithLangEditor"></see></summary>
    let TextAreaWithLangEditor = _prefix "TextAreaWithLangEditor"
    /// <summary>
    /// A simple input field to enter the value of a literal, without the ability to change language or datatype.
    ///
    /// This is the fallback editor for any literal if no other editors are more suitable.
    /// <see href="http://datashapes.org/dash#TextFieldEditor"></see></summary>
    let TextFieldEditor = _prefix "TextFieldEditor"
    /// <summary>
    /// A single-line input field to enter the value of a literal and a drop down to select language, which is mandatory unless xsd:string is among the permissible datatypes.
    /// <see href="http://datashapes.org/dash#TextFieldWithLangEditor"></see></summary>
    let TextFieldWithLangEditor = _prefix "TextFieldWithLangEditor"
    /// <summary>
    /// An input field to enter the URI of a resource, e.g. rdfs:seeAlso links or images.
    /// <see href="http://datashapes.org/dash#URIEditor"></see></summary>
    let URIEditor = _prefix "URIEditor"
    /// <summary>
    /// A Viewer for URI resources, rendering as a hyperlink to that URI. Also includes other ways of interacting with the URI such as opening a nested summary display.
    /// <see href="http://datashapes.org/dash#URIViewer"></see></summary>
    let URIViewer = _prefix "URIViewer"

    /// <summary>
    /// A constraint component that can be used to state that the values of a property must be unique for all instances of a given class (and its subclasses).
    /// <see href="http://datashapes.org/dash#UniqueValueForClassConstraintComponent"></see></summary>
    let UniqueValueForClassConstraintComponent =
        _prefix "UniqueValueForClassConstraintComponent"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#UniqueValueForClassConstraintComponent-uniqueValueForClass"></see>
    /// </summary>
    let ``UniqueValueForClassConstraintComponent-uniqueValueForClass`` =
        _prefix "UniqueValueForClassConstraintComponent-uniqueValueForClass"

    /// <summary>
    ///   <see href="http://datashapes.org/dash#uniqueValueForClass"></see>
    /// </summary>
    let uniqueValueForClass = _prefix "uniqueValueForClass"
    /// <summary>
    /// A Viewer for HTML content from untrusted sources. This viewer will sanitize the HTML before rendering. Any a, button, checkbox, form, hidden, input, img, script, select, style and textarea tags and class and style attributes will be removed.
    /// <see href="http://datashapes.org/dash#UntrustedHTMLViewer"></see></summary>
    let UntrustedHTMLViewer = _prefix "UntrustedHTMLViewer"
    /// <summary>
    /// A viewer that renders all values of a given property as a table, with one value per row, and the columns defined by the shape that is the sh:node or sh:class of the property.
    /// <see href="http://datashapes.org/dash#ValueTableViewer"></see></summary>
    let ValueTableViewer = _prefix "ValueTableViewer"
    /// <summary>
    /// Links an Action with the ActionGroup that it should be arranged in.
    /// <see href="http://datashapes.org/dash#actionGroup"></see></summary>
    let actionGroup = _prefix "actionGroup"
    /// <summary>
    /// The (CSS) class of an Action for display purposes alongside the label.
    /// <see href="http://datashapes.org/dash#actionIconClass"></see></summary>
    let actionIconClass = _prefix "actionIconClass"
    /// <summary>
    /// May link a dash:GraphUpdate with one or more triples (represented as instances of rdf:Statement) that should be added to fix the source of the result.
    /// <see href="http://datashapes.org/dash#addedTriple"></see></summary>
    let addedTriple = _prefix "addedTriple"
    /// <summary>
    /// Represents all users/roles, for example as a possible value of the default view for role property.
    /// <see href="http://datashapes.org/dash#all"></see></summary>
    let all = _prefix "all"
    /// <summary>
    /// Defines how and whether the associated feature is part of an external API. APIs may be implemented as (REST) web services, via GraphQL or ADS Script APIs.
    /// <see href="http://datashapes.org/dash#apiStatus"></see></summary>
    let apiStatus = _prefix "apiStatus"
    /// <summary>
    /// Can be used to state that a shape is applicable to instances of a given class. This is a softer statement than "target class": a target means that all instances of the class must conform to the shape. Being applicable to simply means that the shape may apply to (some) instances of the class. This information can be used by algorithms or humans.
    /// <see href="http://datashapes.org/dash#applicableToClass"></see></summary>
    let applicableToClass = _prefix "applicableToClass"
    /// <summary>
    /// If set to true then the results of the SHACL function can be cached in between invocations with the same arguments. In other words, they are stateless and do not depend on triples in any graph, or the current time stamp etc.
    /// <see href="http://datashapes.org/dash#cachable"></see></summary>
    let cachable = _prefix "cachable"
    /// <summary>
    /// Can be used to indicate that a property/path represented by a property constraint represents a composite relationship. In a composite relationship, the life cycle of a "child" object (value of the property/path) depends on the "parent" object (focus node). If the parent gets deleted, then the child objects should be deleted, too. Tools may use dash:composite (if set to true) to implement cascading delete operations.
    /// <see href="http://datashapes.org/dash#composite"></see></summary>
    let composite = _prefix "composite"
    /// <summary>
    /// Used to mark certain parameterizables as context-free, meaning that the outcome of a process does not depend on the currently active query graph.
    /// <see href="http://datashapes.org/dash#contextFree"></see></summary>
    let contextFree = _prefix "contextFree"
    /// <summary>
    /// Can be used to annotate a graph (usually the owl:Ontology) with the default language that tools should suggest for new literal values. For example, predominantly English graphs should have "en" as default language.
    /// <see href="http://datashapes.org/dash#defaultLang"></see></summary>
    let defaultLang = _prefix "defaultLang"
    /// <summary>
    /// Links a node shape with the roles for which it shall be used as default view. User interfaces can use these values to select how to present a given RDF resource. The values of this property are URIs representing a group of users or agents. There is a dedicated URI dash:all representing all users.
    /// <see href="http://datashapes.org/dash#defaultViewForRole"></see></summary>
    let defaultViewForRole = _prefix "defaultViewForRole"
    /// <summary>
    /// May link a dash:GraphUpdate result with one or more triples (represented as instances of rdf:Statement) that should be deleted to fix the source of the result.
    /// <see href="http://datashapes.org/dash#deletedTriple"></see></summary>
    let deletedTriple = _prefix "deletedTriple"
    /// <summary>
    /// Can be used in dash:js node expressions to enumerate the predicates that the computation of the values may depend on. This can be used by clients to determine whether an edit requires re-computation of values on a form or elsewhere. For example, if the dash:js is something like "focusNode.firstName + focusNode.lastName" then the dependency predicates should be ex:firstName and ex:lastName.
    /// <see href="http://datashapes.org/dash#dependencyPredicate"></see></summary>
    let dependencyPredicate = _prefix "dependencyPredicate"
    /// <summary>
    /// Can be used to link a SHACL property shape with the URL of a SPARQL endpoint that may contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to values from an external graph when the user wants to retrieve more information about a value.
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information. One implementation strategy would be to periodically fetch the values specified by the sh:node or sh:class shape associated with the property, using the property shapes in that shape, and add the resulting triples into the main query graph.
    ///
    /// An example value is "https://query.wikidata.org/sparql".
    /// <see href="http://datashapes.org/dash#detailsEndpoint"></see></summary>
    let detailsEndpoint = _prefix "detailsEndpoint"
    /// <summary>
    /// Can be used to link a SHACL property shape with a SHACL node expression that produces the URIs of one or more graphs that contain further RDF triples for the value nodes delivered by the property. This can be used to inform a processor that it should switch to another data graph when the user wants to retrieve more information about a value.
    ///
    /// The node expressions are evaluated with the focus node as input. (It is unclear whether there are also cases where the result may be different for each specific value, in which case the node expression would need a second input argument).
    ///
    /// This property should be regarded as an "annotation", i.e. it does not have any impact on validation or other built-in SHACL features. However, selected tools may want to use this information.
    /// <see href="http://datashapes.org/dash#detailsGraph"></see></summary>
    let detailsGraph = _prefix "detailsGraph"
    /// <summary>
    /// The expected result(s) of a test case. The value range of this property is different for each kind of test cases.
    /// <see href="http://datashapes.org/dash#expectedResult"></see></summary>
    let expectedResult = _prefix "expectedResult"
    /// <summary>
    /// A flag to indicate that the expected result represents a JSON string. If set to true, then tests would compare JSON structures (regardless of whitespaces) instead of actual syntax.
    /// <see href="http://datashapes.org/dash#expectedResultIsJSON"></see></summary>
    let expectedResultIsJSON = _prefix "expectedResultIsJSON"
    /// <summary>
    /// A flag to indicate that the expected result represents an RDF graph encoded as a Turtle file. If set to true, then tests would compare graphs instead of actual syntax.
    /// <see href="http://datashapes.org/dash#expectedResultIsTTL"></see></summary>
    let expectedResultIsTTL = _prefix "expectedResultIsTTL"
    /// <summary>
    /// Can be used to mark that certain validation results have already been fixed.
    /// <see href="http://datashapes.org/dash#fixed"></see></summary>
    let fixed_ = _prefix "fixed"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#hasClass"></see>
    /// </summary>
    let hasClass = _prefix "hasClass"
    /// <summary>
    /// Checks whether a given node (?value) has a value less than (&lt;) the provided ?maxExclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.
    /// <see href="http://datashapes.org/dash#hasMaxExclusive"></see></summary>
    let hasMaxExclusive = _prefix "hasMaxExclusive"
    /// <summary>
    /// Checks whether a given node (?value) has a value less than or equal to (&lt;=) the provided ?maxInclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.
    /// <see href="http://datashapes.org/dash#hasMaxInclusive"></see></summary>
    let hasMaxInclusive = _prefix "hasMaxInclusive"
    /// <summary>
    /// Checks whether a given string (?value) has a length within a given maximum string length.
    /// <see href="http://datashapes.org/dash#hasMaxLength"></see></summary>
    let hasMaxLength = _prefix "hasMaxLength"
    /// <summary>
    /// Checks whether a given node (?value) has value greater than (&gt;) the provided ?minExclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.
    /// <see href="http://datashapes.org/dash#hasMinExclusive"></see></summary>
    let hasMinExclusive = _prefix "hasMinExclusive"
    /// <summary>
    /// Checks whether a given node (?value) has value greater than or equal to (&gt;=) the provided ?minInclusive. Returns false if this cannot be determined, e.g. because values do not have comparable types.
    /// <see href="http://datashapes.org/dash#hasMinInclusive"></see></summary>
    let hasMinInclusive = _prefix "hasMinInclusive"
    /// <summary>
    /// Checks whether a given string (?value) has a length within a given minimum string length.
    /// <see href="http://datashapes.org/dash#hasMinLength"></see></summary>
    let hasMinLength = _prefix "hasMinLength"
    /// <summary>
    /// Checks whether a given node (?value) has a given sh:NodeKind (?nodeKind). For example, sh:hasNodeKind(42, sh:Literal) = true.
    /// <see href="http://datashapes.org/dash#hasNodeKind"></see></summary>
    let hasNodeKind = _prefix "hasNodeKind"
    /// <summary>
    /// Checks whether the string representation of a given node (?value) matches a given regular expression (?pattern). Returns false if the value is a blank node.
    /// <see href="http://datashapes.org/dash#hasPattern"></see></summary>
    let hasPattern = _prefix "hasPattern"
    /// <summary>
    /// The height.
    /// <see href="http://datashapes.org/dash#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#index"></see>
    /// </summary>
    let index = _prefix "index"
    /// <summary>
    /// Checks whether a given shape or constraint has been marked as "deactivated" using sh:deactivated.
    /// <see href="http://datashapes.org/dash#isDeactivated"></see></summary>
    let isDeactivated = _prefix "isDeactivated"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#constraintOrShape"></see>
    /// </summary>
    let constraintOrShape = _prefix "constraintOrShape"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#isIn"></see>
    /// </summary>
    let isIn = _prefix "isIn"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#isLanguageIn"></see>
    /// </summary>
    let isLanguageIn = _prefix "isLanguageIn"
    /// <summary>
    /// Checks if a given sh:NodeKind is one that includes BlankNodes.
    /// <see href="http://datashapes.org/dash#isNodeKindBlankNode"></see></summary>
    let isNodeKindBlankNode = _prefix "isNodeKindBlankNode"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#nodeKind"></see>
    /// </summary>
    let nodeKind = _prefix "nodeKind"
    /// <summary>
    /// Checks if a given sh:NodeKind is one that includes IRIs.
    /// <see href="http://datashapes.org/dash#isNodeKindIRI"></see></summary>
    let isNodeKindIRI = _prefix "isNodeKindIRI"
    /// <summary>
    /// Checks if a given sh:NodeKind is one that includes Literals.
    /// <see href="http://datashapes.org/dash#isNodeKindLiteral"></see></summary>
    let isNodeKindLiteral = _prefix "isNodeKindLiteral"
    /// <summary>
    /// Returns true if a given class (first argument) is a subclass of a given other class (second argument), or identical to that class. This is equivalent to an rdfs:subClassOf* check.
    /// <see href="http://datashapes.org/dash#isSubClassOf"></see></summary>
    let isSubClassOf = _prefix "isSubClassOf"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#isSubClassOf-subclass"></see>
    /// </summary>
    let ``isSubClassOf-subclass`` = _prefix "isSubClassOf-subclass"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#isSubClassOf-superclass"></see>
    /// </summary>
    let ``isSubClassOf-superclass`` = _prefix "isSubClassOf-superclass"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#subclass"></see>
    /// </summary>
    let subclass = _prefix "subclass"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#superclass"></see>
    /// </summary>
    let superclass = _prefix "superclass"
    /// <summary>
    /// The JavaScript source code of a Script.
    /// <see href="http://datashapes.org/dash#js"></see></summary>
    let js = _prefix "js"
    /// <summary>
    /// For file-typed properties, this can be used to specify the expected/allowed mime types of its values. This can be used, for example, to limit file input boxes or file selectors. If multiple values are allowed then they need to be separated by commas.
    ///
    /// Example values are listed at https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types
    /// <see href="http://datashapes.org/dash#mimeTypes"></see></summary>
    let mimeTypes = _prefix "mimeTypes"
    /// <summary>
    /// If set to true at a property shape then any sh:values and sh:defaultValue rules of this property will be ignored when 'all inferences' are computed. This is useful for property values that shall only be computed for individual focus nodes (e.g. when a user visits a resource) but not for large inference runs.
    /// <see href="http://datashapes.org/dash#neverMaterialize"></see></summary>
    let neverMaterialize = _prefix "neverMaterialize"
    /// <summary>
    /// If set to true for a ScriptConstraint or ScriptValidator, then the associated script will receive all value nodes at once, as a value of the variable values. By default (or false), the script is called for each value node individually.
    /// <see href="http://datashapes.org/dash#onAllValues"></see></summary>
    let onAllValues = _prefix "onAllValues"
    /// <summary>
    /// Links the constraint component with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by a property constraint.
    /// <see href="http://datashapes.org/dash#propertySuggestionGenerator"></see></summary>
    let propertySuggestionGenerator = _prefix "propertySuggestionGenerator"
    /// <summary>
    /// Used as a hint for user interfaces that values of the associated property should not be editable. The values of this may be the boolean literals true or false or, more generally, a SHACL node expression that must evaluate to true or false.
    /// <see href="http://datashapes.org/dash#readOnly"></see></summary>
    let readOnly = _prefix "readOnly"
    /// <summary>
    /// Links a class with the Resource Actions that can be applied to instances of that class.
    /// <see href="http://datashapes.org/dash#resourceAction"></see></summary>
    let resourceAction = _prefix "resourceAction"
    /// <summary>
    /// States that a subject resource has a given shape. This property can, for example, be used to capture results of SHACL validation on static data.
    /// <see href="http://datashapes.org/dash#shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#shapeScript"></see>
    /// </summary>
    let shapeScript = _prefix "shapeScript"
    /// <summary>
    /// Can be used to link a result with one or more suggestions on how to address or improve the underlying issue.
    /// <see href="http://datashapes.org/dash#suggestion"></see></summary>
    let suggestion = _prefix "suggestion"
    /// <summary>
    /// An optional confidence between 0% and 100%. Suggestions with 100% confidence are strongly recommended. Can be used to sort recommended updates.
    /// <see href="http://datashapes.org/dash#suggestionConfidence"></see></summary>
    let suggestionConfidence = _prefix "suggestionConfidence"
    /// <summary>
    /// Links a sh:SPARQLConstraint or sh:JSConstraint with instances of dash:SuggestionGenerator that may be used to produce suggestions for a given validation result that was produced by the constraint.
    /// <see href="http://datashapes.org/dash#suggestionGenerator"></see></summary>
    let suggestionGenerator = _prefix "suggestionGenerator"
    /// <summary>
    /// Can be used to link a suggestion with the group identifier to which it belongs. By default this is a link to the dash:SuggestionGenerator, but in principle this could be any value.
    /// <see href="http://datashapes.org/dash#suggestionGroup"></see></summary>
    let suggestionGroup = _prefix "suggestionGroup"
    /// <summary>
    /// Returns a literal with datatype xsd:string that has the input value as its string. If the input value is an (URI) resource then its URI will be used.
    /// <see href="http://datashapes.org/dash#toString"></see></summary>
    let toString = _prefix "toString"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#arg"></see>
    /// </summary>
    let arg = _prefix "arg"
    /// <summary>
    /// Inserts a given value into a given URI template, producing a new xsd:anyURI literal.
    ///
    /// In the future this should support RFC 6570 but for now it is limited to simple {...} patterns.
    /// <see href="http://datashapes.org/dash#uriTemplate"></see></summary>
    let uriTemplate = _prefix "uriTemplate"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#template"></see>
    /// </summary>
    let template = _prefix "template"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    /// True to also validate the shapes itself (i.e. parameter declarations).
    /// <see href="http://datashapes.org/dash#validateShapes"></see></summary>
    let validateShapes = _prefix "validateShapes"
    /// <summary>
    /// Computes the number of objects for a given subject/predicate combination.
    /// <see href="http://datashapes.org/dash#valueCount"></see></summary>
    let valueCount = _prefix "valueCount"
    /// <summary>
    ///   <see href="http://datashapes.org/dash#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    /// The width.
    /// <see href="http://datashapes.org/dash#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// The x position.
    /// <see href="http://datashapes.org/dash#x"></see></summary>
    let x = _prefix "x"
    /// <summary>
    /// The y position.
    /// <see href="http://datashapes.org/dash#y"></see></summary>
    let y = _prefix "y"
