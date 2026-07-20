namespace http.datashapes.org.graphql.hash

open DoxAletheia

module graphql =
    let _namespace_name = "http://datashapes.org/graphql#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ClassShape"></see>
    /// </summary>
    let ClassShape = _prefix "ClassShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#protectedClass"></see>
    /// </summary>
    let protectedClass = _prefix "protectedClass"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#SchemaPropertyGroup"></see>
    /// </summary>
    let SchemaPropertyGroup = _prefix "SchemaPropertyGroup"
    /// <summary>
    /// A collection of shapes that are part of a GraphQL schema. Includes declarations about which shapes shall be exposed/published by a GraphQL service. The set of public node shapes consists of all values of graphql:publicShape, all values of graphql:publicClass and their subclasses, all node shapes from any namespace graphql:publicNamespace, minus any explicitly excluded shapes via graphql:privateShape.
    ///
    /// An RDF graph may contain multiple GraphQL schemas, each providing a different API or view on the underlying data. GraphQL services can include each other using owl:imports. To simplify common usage patterns, owl:Ontology has been marked as a subclass, so that all Ontologies are also graphql:Schemas once this graphql namespace is imported.
    /// <see href="http://datashapes.org/graphql#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicClass"></see>
    /// </summary>
    let publicClass = _prefix "publicClass"
    /// <summary>
    /// Represents an input object type in a GraphQL schema.
    /// <see href="http://datashapes.org/graphql#InputObjectType"></see></summary>
    let InputObjectType = _prefix "InputObjectType"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#inputValue"></see>
    /// </summary>
    let inputValue = _prefix "inputValue"
    /// <summary>
    /// The definition of an input value, consisting of a name, type and an optional default value.
    /// <see href="http://datashapes.org/graphql#InputValue"></see></summary>
    let InputValue = _prefix "InputValue"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#InputType"></see>
    /// </summary>
    let InputType = _prefix "InputType"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#defaultValue"></see>
    /// </summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// Defines a GraphQL name for a given subject. The values need to match the regular expression specified in http://facebook.github.io/graphql/October2016/#Name.
    /// <see href="http://datashapes.org/graphql#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    /// A test case that can be used to verify that a given JSON object is translated into RDF triples using shape definitions from a given graphql:Service. The service must be in the test case graph.
    /// <see href="http://datashapes.org/graphql#JSON2RDFTestCase"></see></summary>
    let JSON2RDFTestCase = _prefix "JSON2RDFTestCase"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#json"></see>
    /// </summary>
    let json = _prefix "json"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#schema"></see>
    /// </summary>
    let schema = _prefix "schema"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ListType"></see>
    /// </summary>
    let ListType = _prefix "ListType"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#memberType"></see>
    /// </summary>
    let memberType = _prefix "memberType"
    /// <summary>
    /// A test case that runs a given GraphQL mutation (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The mutation is executed over a given "before" graph which must be isomorphic to a given "after" graph. The TestCase is also a graphql:Schema defining which shapes to publish.
    /// <see href="http://datashapes.org/graphql#MutationTestCase"></see></summary>
    let MutationTestCase = _prefix "MutationTestCase"
    /// <summary>
    /// Represents specific GraphQL queries, stored by their query string and possibly other properties with metadata.
    /// <see href="http://datashapes.org/graphql#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#dataGraph"></see>
    /// </summary>
    let dataGraph = _prefix "dataGraph"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#expectedGraph"></see>
    /// </summary>
    let expectedGraph = _prefix "expectedGraph"
    /// <summary>
    /// Defines syntax restrictions on the use of the graphql:name property.
    /// <see href="http://datashapes.org/graphql#NameShape"></see></summary>
    let NameShape = _prefix "NameShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NamedType"></see>
    /// </summary>
    let NamedType = _prefix "NamedType"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NodeShapeShape"></see>
    /// </summary>
    let NodeShapeShape = _prefix "NodeShapeShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#privateShape"></see>
    /// </summary>
    let privateShape = _prefix "privateShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#protectedShape"></see>
    /// </summary>
    let protectedShape = _prefix "protectedShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicShape"></see>
    /// </summary>
    let publicShape = _prefix "publicShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#NonNullType"></see>
    /// </summary>
    let NonNullType = _prefix "NonNullType"
    /// <summary>
    /// The text of the actual query in GraphQL syntax.
    /// <see href="http://datashapes.org/graphql#queryString"></see></summary>
    let queryString = _prefix "queryString"
    /// <summary>
    /// An optional JSON object with variables that shall be passed into the query for execution.
    /// <see href="http://datashapes.org/graphql#variables"></see></summary>
    let variables = _prefix "variables"
    /// <summary>
    /// A test case that runs a given GraphQL query (graphql:query) and compares its output JSON with an expected JSON string. Formatting of the strings is ignored. The TestCase is also a graphql:Schema defining which shapes to publish.
    /// <see href="http://datashapes.org/graphql#QueryTestCase"></see></summary>
    let QueryTestCase = _prefix "QueryTestCase"
    /// <summary>
    /// Represents a scalar type as defined by a GraphQL schema. The primary purpose of these types is for round-tripping, otherwise they are basically the same as node shapes. The instances must be URIs, and the GraphQL name is derived from them.
    ///
    /// This is currently not marked as a subClassOf sh:NodeShape, although this may happen in the future. The idea is that we don't want all constraint parameters to apply here, only selected ones such as sh:datatype. In the SHACL spec, anything that has constraints counts as a node shape, even if it doesn't have a matching rdf:type triple.
    /// <see href="http://datashapes.org/graphql#ScalarType"></see></summary>
    let ScalarType = _prefix "ScalarType"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-protectedShape"></see>
    /// </summary>
    let ``Schema-protectedShape`` = _prefix "Schema-protectedShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-privateShape"></see>
    /// </summary>
    let ``Schema-privateShape`` = _prefix "Schema-privateShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#queryShape"></see>
    /// </summary>
    let queryShape = _prefix "queryShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-protectedClass"></see>
    /// </summary>
    let ``Schema-protectedClass`` = _prefix "Schema-protectedClass"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicShape"></see>
    /// </summary>
    let ``Schema-publicShape`` = _prefix "Schema-publicShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicNamespace"></see>
    /// </summary>
    let ``Schema-publicNamespace`` = _prefix "Schema-publicNamespace"
    /// <summary>
    /// Points at a prefix declaration of the default namespace for the shapes derived by GraphQL types. This property can be used to round-trip .graphql files.
    /// <see href="http://datashapes.org/graphql#defaultPrefix"></see></summary>
    let defaultPrefix = _prefix "defaultPrefix"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#Schema-publicClass"></see>
    /// </summary>
    let ``Schema-publicClass`` = _prefix "Schema-publicClass"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#ShapesPropertyGroup"></see>
    /// </summary>
    let ShapesPropertyGroup = _prefix "ShapesPropertyGroup"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#publicNamespace"></see>
    /// </summary>
    let publicNamespace = _prefix "publicNamespace"
    /// <summary>
    /// A test case that can be used to verify that a RDF/SHACL to GraphQL writer works correctly. The expected result must be the complete GraphQL schema string.
    /// <see href="http://datashapes.org/graphql#WriterTestCase"></see></summary>
    let WriterTestCase = _prefix "WriterTestCase"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#canRoundTrip"></see>
    /// </summary>
    let canRoundTrip = _prefix "canRoundTrip"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#rdfGraph"></see>
    /// </summary>
    let rdfGraph = _prefix "rdfGraph"
    /// <summary>
    /// Gets the GraphQL field name for a property path at a given node shape.
    /// <see href="http://datashapes.org/graphql#fieldName"></see></summary>
    let fieldName = _prefix "fieldName"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#nodeShape"></see>
    /// </summary>
    let nodeShape = _prefix "nodeShape"
    /// <summary>
    ///   <see href="http://datashapes.org/graphql#path"></see>
    /// </summary>
    let path = _prefix "path"
    /// <summary>
    /// Can be attached to property shapes to indicate they should be round-tripped as GraphQL type ID.
    /// <see href="http://datashapes.org/graphql#isIDField"></see></summary>
    let isIDField = _prefix "isIDField"
    /// <summary>
    /// If set to true for a node shape, then it should become a GraphQL interface.
    /// <see href="http://datashapes.org/graphql#isInterface"></see></summary>
    let isInterface = _prefix "isInterface"
    /// <summary>
    /// The GraphQL query string.
    /// <see href="http://datashapes.org/graphql#query"></see></summary>
    let query = _prefix "query"
    /// <summary>
    /// Can be used to attach a URI template to node shapes, meaning that JSON objects that are processed with the given node shape will become URI resources with a URI derived from the given template. Example: "ex:Person-{$id}".
    ///
    /// URI templates can include {...} blocks that contain a variable reference such as $id if the corresponding GraphQL type has a field named "id". Fields are mandatory by default, meaning that if a JSON converter attempts to produce a URI that lacks a mandatory field then the conversion fails with an exception.
    /// <see href="http://datashapes.org/graphql#uriTemplate"></see></summary>
    let uriTemplate = _prefix "uriTemplate"
